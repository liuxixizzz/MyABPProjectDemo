using System.Threading.Tasks;
using MyABPProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyABPProject.Web.Tests.Controllers
{
    public class HomeController_Tests: MyABPProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
