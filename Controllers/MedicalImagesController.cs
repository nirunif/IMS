using IMSProject.Data;
using IMSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IMSProject.Controllers
{
    public class MedicalImagesController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public MedicalImagesController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }


        // GET: MedicalImages/Index
        //public IActionResult Index()
        //{
        //    var query = "SELECT * FROM MedicalImages";
        //    var medicalImages = _dbHelper.Query<MedicalImages>(query).ToList();
        //    return View(medicalImages);
        //}
//        public IActionResult Details(int id)
//        {
//            int? userId = HttpContext.Session.GetInt32("UserID");
//            string role = HttpContext.Session.GetString("UserRole");
//            int? PatientID = HttpContext.Session.GetInt32("PatientID");
//            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

//            ViewBag.UserRole = role; // Pass role to the view

//            var query = @"SELECT Patients.Name, Patients.Address, Patients.ContactNumber, Patients.DateofBirth, Patients.MedicalCondition, Patients.Diagnosis, Patients.TotalCost, Patients.MedicalStaffID, MedicalImages.ImageID, MedicalImages.ImageType, 
//                  MedicalImages.DiseaseType, MedicalImages.ImageURL, MedicalImages.UploadDate, Patients.PatientID
//FROM     Patients INNER JOIN
//                  MedicalImages ON Patients.PatientID = MedicalImages.PatientID WHERE PatientID = @PatientID";
            
//            var patient = _dbHelper.QuerySingle<Patient>(query, new { PatientID = id });
//            return View(patient);
//        }

        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view

            // SQL query to fetch medical images with patient details
            string query = @"SELECT Patients.PatientID, Patients.Name, MedicalImages.ImageID, MedicalImages.ImageType, MedicalImages.DiseaseType, MedicalImages.ImageURL, MedicalImages.UploadDate, Patients.Address
            FROM     Patients INNER JOIN
                              MedicalImages ON Patients.PatientID = MedicalImages.PatientID";


            //            string query = @"SELECT Patients.Name, Patients.Address, Patients.ContactNumber, Patients.DateofBirth, Patients.MedicalCondition, Patients.Diagnosis, Patients.TotalCost, Patients.MedicalStaffID, MedicalImages.ImageID, MedicalImages.ImageType, 
            //                  MedicalImages.DiseaseType, MedicalImages.ImageURL, MedicalImages.UploadDate, Patients.PatientID
            //FROM     Patients INNER JOIN
            //                  MedicalImages ON Patients.PatientID = MedicalImages.PatientID";

            // Execute the query and map the results to MedicalImageWithPatient class
            var medicalImages = _dbHelper.ExecuteQuery<PatientWithImages>(query);

           // var medicalImagesWithPatients = _dbHelper.ExecutePatientWithImagesQuery(query);

            return View(medicalImages);
        }


        //public IActionResult MedcialStaffPatientImages()
        //{
        //    string query = @"SELECT Patients.PatientID, Patients.Name, Patients.Address, Patients.ContactNumber, 
        //                    Patients.DateofBirth, Patients.MedicalCondition, Patients.Diagnosis, 
        //                    Patients.TotalCost, Patients.MedicalStaffID, 
        //                    MedicalImages.ImageID, MedicalImages.ImageType, MedicalImages.DiseaseType, 
        //                    MedicalImages.ImageURL, MedicalImages.UploadDate
        //             FROM Patients 
        //             LEFT JOIN MedicalImages ON Patients.PatientID = MedicalImages.PatientID";

        //    var medicalImagesWithPatients = _dbHelper.ExecutePatientWithImagesQuery(query);
        //    return View(medicalImagesWithPatients); // Ensure the correct view is returned here
        //}


        [HttpPost("UploadImages")]
        public IActionResult UploadImages(int patientId, [FromForm] List<IFormFile> ImageUpload, [FromForm] string ImageType, [FromForm] string DiseaseType)
        {
            try 
            {
                //if (ImageUpload != null && ImageUpload.Count > 0)
                //{
                //    foreach (var file in ImageUpload)
                //    {
                //        var imageUrl = SaveFile(file);
                //        var query = "INSERT INTO MedicalImages (PatientID, ImageType, DiseaseType, ImageURL, UploadDate) " +
                //                    "VALUES (@PatientID, @ImageType, @DiseaseType, @ImageURL, @UploadDate)";
                //        _dbHelper.Execute(query, new { PatientID = patientId, ImageType, DiseaseType, ImageURL = imageUrl, UploadDate = DateTime.Now });
                //    }
                //}
                //return Json(new { success = true });



                // Check if there are files to upload
                if (ImageUpload != null && ImageUpload.Count > 0)
                {
                    foreach (var file in ImageUpload)
                    {
                        // Ensure the file is not empty
                        if (file.Length > 0)
                        {
                            // Save the file to the server and get the URL
                            var imageUrl = SaveFile(file);

                            // Insert image details into the database
                            var query = "INSERT INTO MedicalImages (PatientID, ImageType, DiseaseType, ImageURL, UploadDate) " +
                                        "VALUES (@PatientID, @ImageType, @DiseaseType, @ImageURL, @UploadDate)";

                            var parameters = new
                            {
                                PatientID = patientId,
                                ImageType,
                                DiseaseType,
                                ImageURL = imageUrl,
                                UploadDate = DateTime.Now
                            };

                            _dbHelper.Execute(query, parameters); // Insert into database
                        }
                    }
                }
                return Json(new { success = true }); // Return success


            }
            catch (Exception ex)
            {
                // Log the exception and return an error response
                return Json(new { success = false, message = "Error uploading images: " + ex.Message });
            }
        }

        private string SaveFile(IFormFile file)
        {
            //var filePath = Path.Combine("wwwroot/images/medical", file.FileName);
            //using (var stream = new FileStream(filePath, FileMode.Create))
            //{
            //    file.CopyTo(stream);
            //}
            //return $"/images/medical/{file.FileName}";

            // Define the directory where you want to save the image
            var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "medical");

            // Check if the directory exists, if not, create it
            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            // Get the file path where the image will be saved
            var filePath = Path.Combine(uploadDirectory, file.FileName);

            // Save the file to the directory
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // Return the relative path of the saved image
            return Path.Combine("images", "medical", file.FileName);



        }

        // GET: MedicalImages/Edit/5
        public IActionResult Edit(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            // Query to fetch the medical image along with the associated patient details
            var query = "SELECT mi.ImageID, mi.DiseaseType, mi.ImageType, mi.ImageURL, p.Name, p.PatientID " +
                        "FROM MedicalImages mi " +
                        "JOIN Patients p ON mi.PatientID = p.PatientID " +
                        "WHERE mi.ImageID = @ImageID";

            var medicalImage = _dbHelper.QuerySingle<MedicalImages>(query, new { ImageID = id });

            if (medicalImage == null)
            {
                return NotFound(); // Handle the case where the medical image doesn't exist
            }

            // Now check if the patient details are included correctly
            var patientWithImages = new PatientWithImages
            {
                PatientID = medicalImage.PatientID,  // Make sure this property exists in the result
                Name = medicalImage.Name,  // Make sure this property exists in the result
                ImageID = medicalImage.ImageID,
                DiseaseType = medicalImage.DiseaseType,
                ImageType = medicalImage.ImageType,
                ImageURL = medicalImage.ImageURL
            };

            return View(medicalImage);
        }


        // POST: MedicalImages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MedicalImages model, IFormFile newImage, bool removeImage)
        {
            if (ModelState.IsValid)
            {
                // First, check if the image should be removed
                if (removeImage && !string.IsNullOrEmpty(model.ImageURL))
                {
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", model.ImageURL);
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }

                    model.ImageURL = null; // Clear the image URL
                }

                // If a new image is uploaded, save it
                if (newImage != null && newImage.Length > 0)
                {
                    var fileName = Path.GetFileName(newImage.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        newImage.CopyTo(stream);
                    }

                    model.ImageURL = fileName; // Update the image URL in the model
                }

                // Update the medical image details in the database
                var query = "UPDATE MedicalImages SET DiseaseType = @DiseaseType, ImageType = @ImageType, ImageURL = @ImageURL " +
                            "WHERE ImageID = @ImageID";

                _dbHelper.Execute(query, model);

                return RedirectToAction(nameof(Index)); // Redirect to the Index page after successful update
            }

            return View(model); // Return the view with the model if validation fails
        }

    }
}

