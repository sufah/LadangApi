using System.Collections;
using System.Linq;
using LadangApi.Controllers;
using LadangApi.Data;
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
        public void Get_WhenCalled_ReturnAllPlantationDetails()
        {
            // Arrange
            var moqControl = new Mock<IPlantationDbContext>();

            moqControl.Setup(x => x.Plantations)
                .Returns();

            var control = new PlantationsController(moqControl.Object);
            

            // Act
            var result = control.Get();
            

            // Assert
            Assert.That(result, Is.TypeOf<IEnumerable>());
        }
    }
}