using LadangApi.Controllers;
using LadangApi.Interface;
using Moq;
using NUnit.Framework;

namespace LadangApi.UnitTests.Controllers
{
    [TestFixture]
    public class PlantationsControllerTests
    {
        [Test]
        public void Get_WhenCalled_ReturnAllPlantationDetails()
        {
            var moqControl = new Mock<IPlantationDbContext>();

            // Arrange
            var control = new PlantationsController(moqControl.Object);

            // Act
            var result = control.Get();

            // Assert
        }
    }
}