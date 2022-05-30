using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using VimeoDotNet.Models;

namespace BACK.PORTFOLIO.PortfolioVimeo.VimeoVideo
{
    public interface IVimeoVideoService : IApplicationService
    {
        Task<Paginated<Video>> GetAllVideos();
    }
}
