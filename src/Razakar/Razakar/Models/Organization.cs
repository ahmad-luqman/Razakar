using System;
using System.Collections.Generic;
using System.Text;

namespace Razakar.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RepresentativeName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double Rating { get; set; }
    }
}
