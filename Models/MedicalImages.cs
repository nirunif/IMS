using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class MedicalImages
    {
        public int ImageID { get; set; }
        public string ImageType { get; set; }  // MRI, CT, Xray
        public string ImageURL { get; set; }
        public string DiseaseType { get; set; }
        public DateTime UploadDate { get; set; }
        public int PatientID { get; set; }  // Foreign key to Patient
        public Patient Patient { get; set; }
        public string Name { get; set; }
        public int MedicalStaffID { get; set; }

    }
}
