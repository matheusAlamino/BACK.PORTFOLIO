using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using BACK.PORTFOLIO.Configuration;
using VimeoDotNet;
using VimeoDotNet.Models;

namespace BACK.PORTFOLIO.PortfolioVimeo.VimeoVideo
{
    public class VimeoVideoManager : DomainService, IVimeoVideoManager
    {
        private const string TokenAccess = "55e47bcac38b1883dac5fcaa499e0f9b";

        private readonly string[] Fields = {
            "id",
            "name",
            "description",
            "link",
            "pictures",
            "embed"
        };
        public VimeoVideoManager()
        {
        }

        public async Task<Paginated<Video>> GetAllVideos()
        {
            try
            {
                var userAuthenticatedClient = new VimeoClient(TokenAccess);

                var userInfo = await userAuthenticatedClient.GetAccountInformationAsync();

                var videos = await userAuthenticatedClient.GetVideosAsync(userInfo.Id, 1, 20, null, Fields);

                return videos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar buscar os vídeos. {ex.Message}");
            }
        }
    }
}
