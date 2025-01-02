using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public int PatientID { get; set; }
        public int MedicalStaffID { get; set; }
        public string DiagnosisDetails { get; set; }
        public DateTime ReportDate { get; set; }
        public decimal Cost { get; set; }
    }
}
