using System.Threading.Tasks;
using BoilerPlaitApp.Configuration.Dto;

namespace BoilerPlaitApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
