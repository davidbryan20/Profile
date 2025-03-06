using Microsoft.AspNetCore.Mvc;
using SalesProfile.Models;
using System.Collections.Generic;

namespace SalesProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private static Profile _profile = new Profile
        {
            Id = 1,
            Name = "David Sales",
            Email = "davidbryan20@icloud.com",
            Phone = "+55 11 95550-4214",
            Description = "Software Developer with experience in .NET, AI, and backend development.",
            LinkedIn = "https://linkedin.com/in/bryan",
            GitHub = "https://github.com/davidbryan20",
            ResumePdf = "/files/BryanResume.pdf"
        };

        [HttpGet]
        public IActionResult GetProfile()
        {
            return Ok(_profile);
        }

        [HttpPut]
        public IActionResult UpdateProfile([FromBody] Profile updatedProfile)
        {
            _profile = updatedProfile;
            return Ok(_profile);
        }
    }
}
