using System;
using System.Collections.Generic;
using System.Text;

namespace Razakar.Models
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Duration { get; set; }
        public string Details { get; set; }
    }
}
