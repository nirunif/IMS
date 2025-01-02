using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PatientID { get; set; }
        public int MedicalStaffID { get; set; }

    }
}
