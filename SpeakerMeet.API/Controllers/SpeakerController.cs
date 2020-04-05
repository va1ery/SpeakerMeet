using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SpeakerMeet.API.Controllers
{
    [Route("api/[controller]")]
    public class SpeakerController : Controller
    {
        [HttpGet]
        [Route("search")]
        public IActionResult Search(string searchString)
        {
            var hardCodedSpeakers = new List<Speaker>
            {
                new Speaker {Name = "Josh"},
                new Speaker {Name = "Joshua"},
                new Speaker {Name = "Joseph"},
                new Speaker {Name = "Bill"},
            };

            var speakers = hardCodedSpeakers
                .Where(x => x.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(speakers);
        }
    }
        public class Speaker
    {
        public string Name { get; set; }
    }
}

