using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class Cost
    {
        public int CostId { get; set; }
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
