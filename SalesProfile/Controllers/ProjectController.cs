using Microsoft.AspNetCore.Mvc;
using SalesProfile.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private static List<Project> _projects = new List<Project>
        {
            new Project { Id = 1, Name = "ProspOcean", Description = "AI-powered data analysis tool.", StartDate = new DateTime(2024, 1, 10), EndDate = new DateTime(2024, 6, 15), Repository = "https://github.com/davidbryan20/ProspOcean", Technologies = ".NET, AI, MongoDB" }
        };

        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok(_projects);
        }

        [HttpPost]
        public IActionResult AddProject([FromBody] Project project)
        {
            project.Id = _projects.Count + 1;
            _projects.Add(project);
            return CreatedAtAction(nameof(GetProjects), new { id = project.Id }, project);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();
            _projects.Remove(project);
            return NoContent();
        }
    }
}
