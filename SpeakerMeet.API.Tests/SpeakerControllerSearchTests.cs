using System;
using System.Linq;
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
}
}
} 
