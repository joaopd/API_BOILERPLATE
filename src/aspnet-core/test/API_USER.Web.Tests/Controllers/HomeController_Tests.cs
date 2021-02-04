using System.Threading.Tasks;
using API_USER.Models.TokenAuth;
using API_USER.Web.Controllers;
using Shouldly;
using Xunit;

namespace API_USER.Web.Tests.Controllers
{
    public class HomeController_Tests: API_USERWebTestBase
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