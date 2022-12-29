using FakeItEasy;
using Microsoft.EntityFrameworkCore;
using WebApi3.Controllers;
using WebApi3.Data;
using WebApi3.Models;
using WebApi3.Services.SuperHeroService;

namespace WebApi3.Test
{
    public class SuperHeroControllerTest
    {
        [Fact]
        public async Task TasGetAllHeroes_Return_All_Heros()
        {
            //Arange

            //int count = 5;
            var fakeHeros = new List<SuperHero>();
            //var fakeHeros = A.CollectionOfDummy<SuperHero>(count).ToList();
            var dataStore = A.Fake<ISuperHeroService>();
            A.CallTo(() => dataStore.GetAllHeroes()).Returns(Task.FromResult(fakeHeros));
             //var controller = new SuperHeroController(dataStore);

            //Act

            var actionResult = dataStore.GetAllHeroes();

            //var actionResult = new SuperHeroController(dataStore).GetAllHeroes();

            //Assert
            //var result = actionResult.Result as OkObjectResult;
            //var returnHeros = result.Value as IEnumerable<SuperHero>;
            Assert.Equal(fakeHeros, actionResult.Result);

        }
    }
}