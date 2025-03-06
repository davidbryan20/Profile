using Microsoft.AspNetCore.Mvc;
using SalesProfile.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private static List<Certificate> _certificates = new List<Certificate>
        {
            new Certificate { Id = 1, Name = "Risk Management and Vulnerability", Institution = "FIAP", CompletionDate = new DateTime(2024, 5, 1), CertificateUrl = "https://example.com/cert1" },
            new Certificate { Id = 2, Name = "Excel Mastery", Institution = "Alura", CompletionDate = new DateTime(2023, 8, 10), CertificateUrl = "https://example.com/cert2" }
        };

        [HttpGet]
        public IActionResult GetCertificates()
        {
            return Ok(_certificates);
        }

        [HttpPost]
        public IActionResult AddCertificate([FromBody] Certificate certificate)
        {
            certificate.Id = _certificates.Any() ? _certificates.Max(c => c.Id) + 1 : 1;
            _certificates.Add(certificate);
            return CreatedAtAction(nameof(GetCertificates), new { id = certificate.Id }, certificate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCertificate(int id)
        {
            var certificate = _certificates.FirstOrDefault(c => c.Id == id);
            if (certificate == null) return NotFound();
            _certificates.Remove(certificate);
            return NoContent();
        }
    }
}
