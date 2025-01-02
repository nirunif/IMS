using Microsoft.AspNetCore.Mvc;
using System;
using IMSProject.Data;
using IMSProject.Models;
using Rotativa.AspNetCore;
using DinkToPdf;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;

namespace IMSProject.Controllers
{
    public class ReportsController : Controller
    {
        private readonly DatabaseHelper _dbHelper;
      //  private readonly IConverter _converter;

        public ReportsController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        //    _converter = converter;
        }

        // GET: Reports/Index
        public IActionResult Index(string searchQuery)
        {
            int? userId = HttpContext.Session.GetInt32("UserID");
            string role = HttpContext.Session.GetString("UserRole");
            int? PatientID = HttpContext.Session.GetInt32("PatientID");
            int? MedicalStaffID = HttpContext.Session.GetInt32("MedicalStaffID");

            ViewBag.UserRole = role; // Pass role to the view


            var query = "SELECT PatientID, Name FROM Patients";

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE Name LIKE @SearchQuery OR ContactNumber LIKE @SearchQuery";
            }

            var patients = _dbHelper.Query<Patient>(query, new { SearchQuery = "%" + searchQuery + "%" });
            ViewData["SearchQuery"] = searchQuery;

            return View(patients);
        }

        // GET: Reports/GetReport/{id}
        //public IActionResult GetReport(int id)
        //{
        //    //var patientQuery = "SELECT * FROM Patients WHERE PatientID = @PatientID";
        //    //var patient = _dbHelper.QuerySingle<Patient>(patientQuery, new { PatientID = id });

        //    //if (patient == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //var doctorQuery = "SELECT * FROM MedicalStaff WHERE MedicalStaffID = @MedicalStaffID";
        //    //var doctor = _dbHelper.QuerySingle<MedicalStaff>(doctorQuery, new { MedicalStaffID = patient.MedicalStaffID });

        //    //var imagesQuery = "SELECT ImageURL FROM MedicalImages WHERE PatientID = @PatientID";
        //    //var images = _dbHelper.Query<string>(imagesQuery, new { PatientID = id });

        //    //var report = new Report
        //    //{
        //    //    PatientID = patient.PatientID,
        //    //    MedicalStaffID = doctor?.MedicalStaffID ?? 0,
        //    //    DiagnosisDetails = patient.Diagnosis,
        //    //    ReportDate = DateTime.Now,
        //    //    Cost = patient.TotalCost
        //    //};

        //    //var reportViewModel = new
        //    //{
        //    //    Patient = patient,
        //    //    Doctor = doctor,
        //    //    Images = images,
        //    //    Report = report
        //    //};

        //    //// Return PDF using ViewAsPdf from Rotativa.AspNetCore
        //    //var pdfResult = new ViewAsPdf("ReportTemplate", reportViewModel)
        //    //{
        //    //    FileName = $"Patient_Report_{patient.Name}.pdf"
        //    //};

        //    //return pdfResult; // Return the generated PDF file


        //    var patientQuery = "SELECT * FROM Patients WHERE PatientID = @PatientID";
        //    var patient = _dbHelper.QuerySingle<Patient>(patientQuery, new { PatientID = id });

        //    if (patient == null)
        //    {
        //        return NotFound();
        //    }

        //    var doctorQuery = "SELECT * FROM MedicalStaff WHERE MedicalStaffID = @MedicalStaffID";
        //    var doctor = _dbHelper.QuerySingle<MedicalStaff>(doctorQuery, new { MedicalStaffID = patient.MedicalStaffID });

        //    var imagesQuery = "SELECT ImageURL FROM MedicalImages WHERE PatientID = @PatientID";
        //    var images = _dbHelper.Query<string>(imagesQuery, new { PatientID = id });

        //    var report = new Report
        //    {
        //        PatientID = patient.PatientID,
        //        MedicalStaffID = doctor?.MedicalStaffID ?? 0,
        //        DiagnosisDetails = patient.Diagnosis,
        //        ReportDate = DateTime.Now,
        //        Cost = patient.TotalCost
        //    };

        //    var reportHtml = RenderViewToString("ReportTemplate", new
        //    {
        //        Patient = patient,
        //        Doctor = doctor,
        //        Images = images,
        //        Report = report
        //    });

        //    var pdf = new HtmlToPdfDocument()
        //    {
        //        GlobalSettings = new GlobalSettings
        //        {
        //            ColorMode = ColorMode.Color,
        //            Orientation = Orientation.Portrait,
        //            PaperSize = PaperKind.A4,
        //            Margins = new MarginSettings { Top = 10, Bottom = 10 }
        //        },
        //        Objects = new List<ObjectSettings>
        //        {
        //            new ObjectSettings
        //            {
        //                HtmlContent = reportHtml,
        //                WebSettings = { DefaultEncoding = "utf-8" }
        //            }
        //        }
        //    };

        //    var pdfBytes = _converter.Convert(pdf);

        //    return File(pdfBytes, "application/pdf", $"Patient_Report_{patient.Name}.pdf");
        //}
    }

    //private async Task<string> RenderViewToString(string viewName, object model)
    //{
    //    var viewEngine = HttpContext.RequestServices.GetService(typeof(IRazorViewEngine)) as IRazorViewEngine;
    //    var tempDataProvider = HttpContext.RequestServices.GetService(typeof(ITempDataProvider)) as ITempDataProvider;
    //    var actionContext = new ActionContext(HttpContext, RouteData, ControllerContext.ActionDescriptor);

    //    using (var stringWriter = new StringWriter())
    //    {
    //        var viewResult = viewEngine.FindView(actionContext, viewName, false);

    //        if (viewResult.View == null)
    //        {
    //            throw new ArgumentNullException($"View {viewName} was not found.");
    //        }

    //        var viewContext = new ViewContext(
    //            actionContext,
    //            viewResult.View,
    //            ViewData,
    //            TempData,
    //            stringWriter,
    //            new Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelperOptions()
    //        );

    //        viewContext.ViewData.Model = model;

    //        await viewResult.View.RenderAsync(viewContext);
    //        return stringWriter.ToString();
    //    }
    //}

}

