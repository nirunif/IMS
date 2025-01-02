using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class PatientWithImages
    {
        public int ImageID { get; set; }
        public string DiseaseType { get; set; }
        public string ImageType { get; set; }
        public string ImageURL { get; set; }
        public DateTime UploadDate { get; set; }
        public int PatientID { get; set; }



      //  public string PatientName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public string MedicalCondition { get; set; }
        public string Diagnosis { get; set; }
        public decimal TotalCost { get; set; }
        public int MedicalStaffID { get; set; }

        public List<MedicalImages> MedicalImages { get; set; } = new List<MedicalImages>(); // Initialized here
    }
}
