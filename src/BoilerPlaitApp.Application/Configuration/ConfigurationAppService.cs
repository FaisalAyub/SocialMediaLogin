using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BoilerPlaitApp.Configuration.Dto;

namespace BoilerPlaitApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoilerPlaitAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
