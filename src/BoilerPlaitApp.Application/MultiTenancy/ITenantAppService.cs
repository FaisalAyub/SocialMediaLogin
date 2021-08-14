using Abp.Application.Services;
using BoilerPlaitApp.MultiTenancy.Dto;

namespace BoilerPlaitApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

