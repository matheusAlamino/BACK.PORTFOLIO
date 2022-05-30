using Microsoft.AspNetCore.Antiforgery;
using BACK.PORTFOLIO.Controllers;

namespace BACK.PORTFOLIO.Web.Host.Controllers
{
    public class AntiForgeryController : PORTFOLIOControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
