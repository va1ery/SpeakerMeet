using System;
using System.Collections.Generic;
using Xunit;
using SpeakerMeet.API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SpeakerMeet.API.Tests
{
    public class SpeakerControllerSearchTests
    {       
private readonly SpeakerController _controller;

public SpeakerControllerSearchTests()
{
  _controller = new SpeakerController();
}       
[Fact]
public void GivenExactMatchThenOneSpeakerInCollection()
{
  // Arrange
  // Act
  var result = _controller.Search("Joshua") as OkObjectResult;

  // Assert
  var speakers = ((IEnumerable<Speaker>)result.Value).ToList();
  Assert.Equal(1, speakers.Count);
}

[Fact(Skip = "No longer needed")]
public void ItReturnsCollectionOfSpeakers()
{
  // Arrange
  var controller = new SpeakerController();

  // Act
  var result = controller.Search("Jos") as OkObjectResult;

  // Assert
  Assert.NotNull(result);
  Assert.NotNull(result.Value); 
  Assert.IsType<List<Speaker>>(result.Value);
}
}
} 
