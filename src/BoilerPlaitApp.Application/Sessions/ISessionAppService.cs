using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlaitApp.Sessions.Dto;

namespace BoilerPlaitApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
