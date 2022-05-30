using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using VimeoDotNet.Models;

namespace BACK.PORTFOLIO.PortfolioVimeo.VimeoVideo
{
    public interface IVimeoVideoManager : IDomainService
    {
        Task<Paginated<Video>> GetAllVideos();
    }
}
