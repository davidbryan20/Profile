using Microsoft.AspNetCore.Mvc;
using SalesProfile.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private static List<Experience> _experiences = new List<Experience>
        {
            new Experience { Id = 1, Company = "B2X Care Solutions", Position = "Customer Support Assistant", StartDate = new DateTime(2024, 10, 1), Description = "Providing software support for Samsung devices." },
            new Experience { Id = 2, Company = "Faiser Telecomunicações", Position = "Technical Support", StartDate = new DateTime(2023, 5, 1), EndDate = new DateTime(2024, 9, 30), Description = "Assisted customers with router configurations and network troubleshooting." }
        };

        [HttpGet]
        public IActionResult GetExperiences()
        {
            return Ok(_experiences);
        }

        [HttpPost]
        public IActionResult AddExperience([FromBody] Experience experience)
        {
            experience.Id = _experiences.Count + 1;
            _experiences.Add(experience);
            return CreatedAtAction(nameof(GetExperiences), new { id = experience.Id }, experience);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExperience(int id)
        {
            var experience = _experiences.FirstOrDefault(e => e.Id == id);
            if (experience == null) return NotFound();
            _experiences.Remove(experience);
            return NoContent();
        }
    }
}
