using Abp.Application.Services.Dto;

namespace BoilerPlaitApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

