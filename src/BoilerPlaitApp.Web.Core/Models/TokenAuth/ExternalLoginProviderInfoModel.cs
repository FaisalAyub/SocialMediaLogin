using Abp.AutoMapper;
using BoilerPlaitApp.Authentication.External;

namespace BoilerPlaitApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
