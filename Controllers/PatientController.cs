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
    public class PatientController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public PatientController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        // GET: Patient/Index
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view



            if (role == "Radiologist" || role == "Doctor" && MedicalStaffID.HasValue)
            {
                //var query = "SELECT * FROM Patients";
                var query = @"SELECT Patients.Name, Patients.Address, Patients.ContactNumber, Patients.DateofBirth, Patients.MedicalCondition, Patients.Diagnosis, Patients.TotalCost, Patients.MedicalStaffID, MedicalImages.ImageID, MedicalImages.ImageType, 
                  MedicalImages.DiseaseType, MedicalImages.ImageURL, MedicalImages.UploadDate, Patients.PatientID
FROM     Patients INNER JOIN
                  MedicalImages ON Patients.PatientID = MedicalImages.PatientID
WHERE  (Patients.MedicalStaffID = @MedicalStaffID)";

               //var patients = _dbHelper.Query<Patient>(query);

                var patients = _dbHelper.Query<Patient>(query, new { MedicalStaffID = MedicalStaffID.Value }).ToList();

                return View("MSPatientDets", patients);
            }

            if (role == "Admin")
            {
                var query = "SELECT * FROM Patients";
                var patients = _dbHelper.Query<Patient>(query);
                return View(patients);
            }


            // Check if the user is a patient
            if (role == "Patient" && userId.HasValue)
            {
                // Fetch the patient's details and associated medical images
                //    var query = @"
                //SELECT p.*, mi.*
                //FROM Patients p
                //LEFT JOIN MedicalImages mi ON p.PatientID = mi.PatientID
                //WHERE p.UserId = @UserId";



                var query = @"SELECT Patients.PatientID, Patients.Name, Patients.Address, Patients.ContactNumber, Patients.DateofBirth, Patients.MedicalCondition, Patients.Diagnosis, Patients.TotalCost, Patients.MedicalStaffID, MedicalImages.ImageID, 
                  MedicalImages.ImageType, MedicalImages.DiseaseType, MedicalImages.ImageURL, MedicalImages.UploadDate, Users.UserID, Users.Role
FROM     Patients INNER JOIN
                  MedicalImages ON Patients.PatientID = MedicalImages.PatientID INNER JOIN
                  Users ON Patients.PatientID = Users.PatientID
WHERE  (Users.UserID = @UserID)";



                var patientDetails = _dbHelper.Query<PatientWithImages>(query, new { UserId = userId.Value }).FirstOrDefault();

                if (patientDetails == null)
                {
                    return NotFound(); // Return a 404 if no patient details are found
                }

                return View("PatientDetails", patientDetails); // Load a specific view for patient details
            }

            return Unauthorized(); // Return a 401 if the user is not authorized


        }

        // GET: Patient/Details/5
        public IActionResult Details(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view

            var query = @"SELECT Patients.Name, Patients.Address, Patients.ContactNumber, Patients.DateofBirth, Patients.MedicalCondition, Patients.Diagnosis, Patients.TotalCost, Patients.MedicalStaffID, MedicalImages.ImageID, MedicalImages.ImageType, 
                  MedicalImages.DiseaseType, MedicalImages.ImageURL, MedicalImages.UploadDate, Patients.PatientID
FROM     Patients INNER JOIN
                  MedicalImages ON Patients.PatientID = MedicalImages.PatientID
WHERE  (Patients.PatientID = @PatientID)";
            var patient = _dbHelper.QuerySingle<Patient>(query, new { PatientID = id });

            if (patient == null)
            {
                return NotFound(); // Handle missing data gracefully
            }

            return View(patient);
        }

        // GET: Patient/Create
        public IActionResult Create()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            var query = "SELECT * FROM MedicalStaff WHERE Role = 'Doctor'";
            var doctors = _dbHelper.Query<MedicalStaff>(query); // Fetch all doctors
            ViewData["Doctors"] = doctors; // Pass the doctors to the view
            return View(new Patient());
        }

        // POST: Patient/Create
        [HttpPost]
        //public IActionResult Create(Patient patient)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var query = "INSERT INTO Patients (Name, Address, ContactNumber, DateofBirth, MedicalCondition, Diagnosis, TotalCost) " +
        //                    "VALUES (@Name, @Address, @ContactNumber, @DateofBirth, @MedicalCondition, @Diagnosis, @TotalCost)";
        //        _dbHelper.Execute(query, patient);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(patient);
        //}

        public IActionResult Create(Patient patient)
        {
            try
            {


                //if (ModelState.IsValid)
                //{
                //    // Insert patient details into the Patients table
                //    var query = "INSERT INTO Patients (Name, Address, ContactNumber, DateofBirth, MedicalCondition, Diagnosis, TotalCost) " +
                //                "VALUES (@Name, @Address, @ContactNumber, @DateofBirth, @MedicalCondition, @Diagnosis, @TotalCost); " +
                //                "SELECT SCOPE_IDENTITY();"; // Get the last inserted patient ID


                //    // Creating a dictionary to pass parameters explicitly
                //    var parameters = new Dictionary<string, object>
                //    {
                //        { "@Name", patient.Name },
                //        { "@Address", patient.Address },
                //        { "@ContactNumber", patient.ContactNumber },
                //        { "@DateofBirth", patient.DateofBirth },
                //        { "@MedicalCondition", patient.MedicalCondition },
                //        { "@Diagnosis", patient.Diagnosis },
                //        { "@TotalCost", patient.TotalCost }
                //    };

                //    // Execute the query and get the generated PatientId
                //    var patientId = _dbHelper.ExecuteScalar<int>(query, parameters);

                //    // Redirect to the MedicalImagesController to handle image uploads
                //    return RedirectToAction("UploadImages", "MedicalImages", new { patientId = patientId });
                //}

                //// If ModelState is invalid, return the same view with the patient data
                //return View(patient);
                // ..................................................................................


                if (ModelState.IsValid)
                {
                    var query = "INSERT INTO Patients (Name, Address, ContactNumber, DateofBirth, MedicalCondition, Diagnosis, TotalCost, MedicalStaffID) " +
                    "VALUES (@Name, @Address, @ContactNumber, @DateofBirth, @MedicalCondition, @Diagnosis, @TotalCost, @MedicalStaffID); " +
                    "SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    // Creating a dictionary to pass parameters explicitly
                    var parameters = new Dictionary<string, object>
                        {
                            { "@Name", patient.Name },
                            { "@Address", patient.Address },
                            { "@ContactNumber", patient.ContactNumber },
                            { "@DateofBirth", patient.DateofBirth },
                            { "@MedicalCondition", patient.MedicalCondition },
                            { "@Diagnosis", patient.Diagnosis },
                            { "@TotalCost", patient.TotalCost },
                            { "@MedicalStaffID", patient.MedicalStaffID }
                        };


                    // Get the patient ID after insert (assuming it is auto-generated)
                    var patientId = _dbHelper.ExecuteScalar<int>(query, parameters);

                    return Json(new { patientId }); // Return patientId in response
                }
                return Json(new { success = false, message = "Error saving patient details" });



            }
            catch (Exception ex)
            {
                // Log or display the error message for debugging
                ModelState.AddModelError("", "Error saving patient details: " + ex.Message);
                return View(patient);
            }
        }

        // GET: Patient/Edit/5
        public IActionResult Edit(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            var query = "SELECT * FROM Patients WHERE PatientID = @PatientID";
            var patient = _dbHelper.QuerySingle<Patient>(query, new { PatientID = id });

            if (patient == null)
            {
                return NotFound(); // Handle the case where the patient doesn't exist
            }

            return View(patient);
        }

        // POST: Patient/Edit/5
        [HttpPost]
        public IActionResult Edit(Patient patient)
        {
            if (ModelState.IsValid)
            {
                var query = "UPDATE Patients SET Name = @Name, Address = @Address, ContactNumber = @ContactNumber, " +
                            "DateofBirth = @DateofBirth, MedicalCondition = @MedicalCondition, Diagnosis = @Diagnosis, TotalCost = @TotalCost " +
                            "WHERE PatientID = @PatientID";
                _dbHelper.Execute(query, patient);
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patient/Delete/5
        public IActionResult Delete(int id)
        {
            var query = "SELECT * FROM Patients WHERE PatientID = @PatientID";
            var patient = _dbHelper.QuerySingle<Patient>(query, new { PatientID = id });

            if (patient == null)
            {
                return NotFound();
            }

            return View(patient); // Pass the patient to the Delete view
        }

        // POST: Patient/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(int patientID)
        {
            var query = "DELETE FROM Patients WHERE PatientID = @PatientID";
            _dbHelper.Execute(query, new { PatientID = patientID });

            // Redirect back to the Index view after deletion
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult GetImageCount(int patientID)
        {
            var query = "SELECT COUNT(*) FROM MedicalImages WHERE PatientID = @PatientID";
            var imageCount = _dbHelper.ExecuteScalar<int>(query, new { PatientID = patientID });
            return Json(new { count = imageCount });
        }

        public IActionResult Search(string searchQuery)
        {
            // Build a query that filters patients based on the search query
            var query = "SELECT * FROM Patients WHERE Name LIKE @SearchQuery OR MedicalCondition LIKE @SearchQuery";
            var patients = _dbHelper.Query<Patient>(query, new { SearchQuery = "%" + searchQuery + "%" });

            return PartialView("_PatientTable", patients); // Return a partial view with the filtered patients
        }


    }
}
