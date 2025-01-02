using IMSProject.Models;
using IMSProject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace IMSProject.Controllers
{
    public class UsersController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public UsersController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        // GET: Users/Index
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view
            // Admin-only access
            if (HttpContext.Session.GetString("UserRole") != "Admin")
            {
                return Unauthorized();
            }

            var query = "SELECT * FROM Users";
            var users = _dbHelper.Query<User>(query);
            return View(users);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view
            // Admin-only access
            if (HttpContext.Session.GetString("UserRole") != "Admin")
            {
                return Unauthorized();
            }
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public IActionResult Create(User user, string confirmPassword)
        {

            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            if (HttpContext.Session.GetString("UserRole") != "Admin")
            {
                return Unauthorized();
            }

            if (user.Password != confirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match.");
                return View(user);
            }

            try
            {
                if (ModelState.IsValid)
                {
                    var query = "INSERT INTO Users (Role, Username, Password) VALUES (@Role, @Username, @Password)";
                    var parameters = new
                    {
                        user.Role,
                        user.Username,
                        user.Password
                    };
                    _dbHelper.Execute(query, parameters);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error creating user: " + ex.Message);
            }

            return View(user);
        }

        // Action for displaying the Login page
        public IActionResult Login()
        {
            return View();
        }

        // GET: Users/Edit/5
        public IActionResult Edit(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view

            var query = "SELECT * FROM Users WHERE UserID = @UserID";
            var user = _dbHelper.QuerySingle<User>(query, new { UserID = id });

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var query = "UPDATE Users SET Role = @Role, Username = @Username, Password = @Password WHERE UserID = @UserID";
                _dbHelper.Execute(query, user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public IActionResult Delete(int id)
        {
            var query = "SELECT * FROM Users WHERE UserID = @UserID";
            var user = _dbHelper.QuerySingle<User>(query, new { UserID = id });

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(int userID)
        {
            var query = "DELETE FROM Users WHERE UserID = @UserID";
            _dbHelper.Execute(query, new { UserID = userID });
            return RedirectToAction(nameof(Index));
        }

        // POST: Users/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            //var query = "SELECT * FROM Users WHERE Username = @Username";
            //var user = _dbHelper.QuerySingle<User>(query, new { Username = username });


            //if (user == null || user.Password!= password)
            //{
            //    ModelState.AddModelError("", "Invalid username or password.");
            //    return View();
            //}

            //// Store user details in session
            //HttpContext.Session.SetString("Username", user.Username);
            //HttpContext.Session.SetString("UserRole", user.Role);

            //return RedirectToAction("Index", "Home"); // Redirect to a default page after login


            var query = "SELECT * FROM Users WHERE Username = @Username";
            var user = _dbHelper.QuerySingle<User>(query, new { Username = username });

            if (user != null)
            {
                HttpContext.Session.SetInt32("UserID", user.UserID);
                HttpContext.Session.SetString("UserRole", user.Role);
                HttpContext.Session.SetInt32("PatientID", user.PatientID);
                HttpContext.Session.SetInt32("MedicalStaffID", user.MedicalStaffID);

                if (user.Role == "Patient")
                    return RedirectToAction("Index", "Patient");
                else if (user.Role == "Doctor" || user.Role == "Radiologist")
                    return RedirectToAction("Index", "Home");
                else if (user.Role == "Admin")
                    return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();

        }

        // Action for Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // Helper for Role-Based Access
        private bool HasAccess(string role)
        {
            var userRole = HttpContext.Session.GetString("UserRole");
            return userRole == role || userRole == "Admin";
        }

        // POST: Users/Login
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Login(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Check if the user exists in the database with the given credentials
        //        var dbUser = _dbHelper.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

        //        if (dbUser != null)
        //        {
        //            // Logic to redirect based on role
        //            if (dbUser.Role == "Admin")
        //            {
        //                return RedirectToAction("AdminDashboard", "Admin");
        //            }
        //            else if (dbUser.Role == "Doctor")
        //            {
        //                return RedirectToAction("DoctorDashboard", "Doctor");
        //            }
        //            else if (dbUser.Role == "Patient")
        //            {
        //                return RedirectToAction("PatientDashboard", "Patient");
        //            }
        //        }
        //        else
        //        {
        //            // If login fails, show error message
        //            ViewData["LoginError"] = "Invalid username or password.";
        //        }
        //    }
        //    return View(user);
        //}
    }
}
