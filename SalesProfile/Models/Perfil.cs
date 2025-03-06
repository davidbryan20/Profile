using System;
using System.Collections.Generic;
namespace SalesProfile.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub {  get; set; }
        public string ResumePdf { get; set; }

    }
}
