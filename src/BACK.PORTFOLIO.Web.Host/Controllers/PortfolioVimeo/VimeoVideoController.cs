using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using BACK.PORTFOLIO.PortfolioVimeo.VimeoVideo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VimeoDotNet.Models;

namespace BACK.PORTFOLIO.Web.Host.Controllers.PortfolioVimeo
{
    [Route("api/v1/vimeo")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class VimeoVideoController : AbpController
    {
        private readonly IVimeoVideoService _vimeoVideoService;

        public VimeoVideoController(
            IVimeoVideoService vimeoVideoService
            )
        {
            _vimeoVideoService = vimeoVideoService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<Paginated<Video>> GetAll()
        {
            return await _vimeoVideoService.GetAllVideos();
        }
    }
}
