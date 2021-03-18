using Microsoft.AspNetCore.Identity;
using System;

namespace webBank.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CNP { get; set; }
        public string CNPSerial { get; set; }
        public string Country { get; set; }
        public string Citizenship { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public string Employer { get; set; }
    }

}
