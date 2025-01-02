using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Models
{
    public class MedicalStaff
    {
        public int MedicalStaffID { get; set; }  // Unique ID for each staff member

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }  // e.g., Doctor, Radiologist, Nurse

        [StringLength(255)]
        public string ContactNumber { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Specialty { get; set; }  // Optional, for doctors, radiologists, etc.

        [Required]
        public DateTime DateOfJoining { get; set; }

    }
}
