using LadangApi.Controllers;
using LadangApi.Interface;
using LadangApi.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace LadangApi.UnitTests.Controllers
{
    [TestFixture]
    public class PlantationsControllerTests
    {
        [Test]
        //[Ignore("I will try later")]
        public void Get_WhenCalled_ReturnAllPlantationDetails()
        {
            // Arrange
            var moqSet = new Mock<DbSet<Plantation>>();

            var moqContext = new Mock<IPlantationDbContext>();

            moqContext.Setup(x => x.Plantations)
                .Returns(moqSet.Object);

            var control = new PlantationsController(moqContext.Object);

            // Act
            var result = control.Get();

            // Assert
            Assert.That(result, Is.Not.Empty);
        }
    }
}