using System;
using Xunit;
using SpeakerMeet.API.Controllers;

namespace SpeakerMeet.API.Tests
{
    public class SpeakerControllerSearchTests
    {
        [Fact/*(Skip = "No longer needed")*/]
        public void ItExists()
        {
        var controller = new SpeakerController();
        }
 
         [Fact]
        public void ItHasSearch()
        {
        // Arrange
        var controller = new SpeakerController();

        // Act
        controller.Search("Jos");
        }  
    }
}
