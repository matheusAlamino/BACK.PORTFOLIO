using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VimeoDotNet.Models;

namespace BACK.PORTFOLIO.PortfolioVimeo.VimeoVideo
{
    public class VimeoVideoService : IVimeoVideoService
    {
        private readonly IVimeoVideoManager _vimeoVideoManager;

        public VimeoVideoService(
            IVimeoVideoManager vimeoVideoManager
            )
        {
            _vimeoVideoManager = vimeoVideoManager;
        }

        public async Task<Paginated<Video>> GetAllVideos()
        {
            //Get all videos except the video reel
            var videos = await _vimeoVideoManager.GetAllVideos();

            return videos;
        }
    }
}
