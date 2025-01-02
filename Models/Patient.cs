using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public string MedicalCondition { get; set; }
        public string Diagnosis { get; set; }
        public decimal TotalCost { get; set; }
        public int MedicalStaffID { get; set; }
        public int UserID { get; set; }

        public List<MedicalImages> MedicalImages { get; set; }
    }
}
