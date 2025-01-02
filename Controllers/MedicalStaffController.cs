using IMSProject.Data;
using IMSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Controllers
{
    public class MedicalStaffController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public MedicalStaffController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        // GET: MedicalStaff/Index
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view

            var query = "SELECT * FROM MedicalStaff";
            var staffList = _dbHelper.Query<MedicalStaff>(query);
            return View(staffList);
        }

        // GET: MedicalStaff/Details/5
        public IActionResult Details(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            var query = "SELECT * FROM MedicalStaff WHERE MedicalStaffID = @MedicalStaffID";
            var staff = _dbHelper.QuerySingle<MedicalStaff>(query, new { MedicalStaffID = id });
            return View(staff);
        }

        // GET: MedicalStaff/Create
        public IActionResult Create()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view

            return View(new MedicalStaff());
        }

        // POST: MedicalStaff/Create
        [HttpPost]
        public IActionResult Create(MedicalStaff medicalStaff)
        {
            if (ModelState.IsValid)
            {
                var query = "INSERT INTO MedicalStaff (Name, Role, ContactNumber, Email, Specialty, DateOfJoining) " +
                            "VALUES (@Name, @Role, @ContactNumber, @Email, @Specialty, @DateOfJoining)";
                _dbHelper.Execute(query, medicalStaff);
                return RedirectToAction(nameof(Index));
            }
            return View(medicalStaff);
        }

        // GET: MedicalStaff/Edit/5
        public IActionResult Edit(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            var query = "SELECT * FROM MedicalStaff WHERE MedicalStaffID = @MedicalStaffID";
            var staff = _dbHelper.QuerySingle<MedicalStaff>(query, new { MedicalStaffID = id });

            if (staff == null)
            {
                return NotFound(); // Handle the case where the staff member doesn't exist
            }

            return View(staff);
        }

        // POST: MedicalStaff/Edit/5
        [HttpPost]
        public IActionResult Edit(MedicalStaff medicalStaff)
        {
            if (ModelState.IsValid)
            {
                var query = "UPDATE MedicalStaff SET Name = @Name, Role = @Role, ContactNumber = @ContactNumber, " +
                            "Specialty = @Specialty, Email=@Email, DateOfJoining = @DateOfJoining " +
                            "WHERE MedicalStaffID = @MedicalStaffID";
                _dbHelper.Execute(query, medicalStaff);
                return RedirectToAction(nameof(Index));
            }
            return View(medicalStaff);
        }

        // GET: MedicalStaff/Delete/5
        public IActionResult Delete(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view

            var query = "SELECT * FROM MedicalStaff WHERE MedicalStaffID = @MedicalStaffID";
            var staff = _dbHelper.QuerySingle<MedicalStaff>(query, new { MedicalStaffID = id });

            if (staff == null)
            {
                return NotFound();
            }

            return View(staff); // Pass the staff member to the Delete view
        }

        // POST: MedicalStaff/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(int medicalStaffID)
        {
            var query = "DELETE FROM MedicalStaff WHERE MedicalStaffID = @MedicalStaffID";
            _dbHelper.Execute(query, new { MedicalStaffID = medicalStaffID });

            // Redirect back to the Index view after deletion
            return RedirectToAction(nameof(Index));
        }
    }
}

