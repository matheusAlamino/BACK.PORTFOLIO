using Abp.Application.Services.Dto;

namespace BACK.PORTFOLIO.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

