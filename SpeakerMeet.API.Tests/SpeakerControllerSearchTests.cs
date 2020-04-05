using System;
using Xunit;
using SpeakerMeet.API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SpeakerMeet.API.Tests
{
    public class SpeakerControllerSearchTests
    {
        [Fact(Skip = "No longer needed")]
        public void ItExists()
        {
        var controller = new SpeakerController();
        }
 
         [Fact(Skip = "No longer needed")]
        public void ItHasSearch()
        {
        // Arrange
        var controller = new SpeakerController();

        // Act
        controller.Search("Jos");
        }  
        [Fact]
        public void ItReturnsOkObjectResult()
        {
        // Arrange
        var controller = new SpeakerController();

        // Act
        var result = controller.Search("Jos");

        // Assert
        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result);
        }
    }
}
