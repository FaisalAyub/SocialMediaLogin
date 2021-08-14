using System.Threading.Tasks;
using BoilerPlaitApp.Models.TokenAuth;
using BoilerPlaitApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerPlaitApp.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerPlaitAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}