#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff57c7ce22bb9120a2573c169ed1abba4e87002"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Index), @"mvc.1.0.view", @"/Views/Patient/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\MSc\SAPM\IMS-master\IMS-master\Views\_ViewImports.cshtml"
using IMSProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MSc\SAPM\IMS-master\IMS-master\Views\_ViewImports.cshtml"
using IMSProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff57c7ce22bb9120a2573c169ed1abba4e87002", @"/Views/Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IMSProject.Models.Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
  
    ViewData["Title"] = "Patient List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<link href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" rel=\"stylesheet\" />\n\n<div class=\"container mt-6\">\n    <h2 class=\"text-center mb-4\">Patient List</h2>\n\n    <div class=\"text-center mb-4\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 403, "\"", 442, 1);
#nullable restore
#line 15 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
WriteAttributeValue("", 410, Url.Action("Create", "Patient"), 410, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm"">
            <i class=""fas fa-plus""></i> Add New Patient
        </a>
    </div>

    <div class=""d-flex justify-content-end mb-3"">
        <!-- Search filter box -->
        <input type=""text"" class=""form-control w-25"" id=""searchInput"" placeholder=""Search by name or condition..."" />
    </div>

    <div class=""table-responsive"" style=""width: 100%;"">
        <table class=""table table-bordered table-hover text-center"" id=""patientTable"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Date of Birth</th>
                    <th>Contact</th>
                    <th>Medical Condition</th>
                    <th>Diagnosis</th>
                    <th>Total Cost</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                 foreach (var patient in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 43 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                       Write(patient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                       Write(patient.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                       Write(patient.DateofBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 46 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                       Write(patient.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                       Write(patient.MedicalCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 48 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                       Write(patient.Diagnosis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>$");
#nullable restore
#line 49 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                        Write(patient.TotalCost.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <div class=\"d-flex justify-content-around\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1984, "\"", 2056, 1);
#nullable restore
#line 52 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
WriteAttributeValue("", 1991, Url.Action("Details", "Patient", new { id = patient.PatientID }), 1991, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">\n                                    <i class=\"fas fa-eye\"></i>\n                                </a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2221, "\"", 2290, 1);
#nullable restore
#line 55 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
WriteAttributeValue("", 2228, Url.Action("Edit", "Patient", new { id = patient.PatientID }), 2228, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\n                                    <i class=\"fas fa-edit\"></i>\n                                </a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2459, "\"", 2530, 1);
#nullable restore
#line 58 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
WriteAttributeValue("", 2466, Url.Action("Delete", "Patient", new { id = patient.PatientID }), 2466, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\n                                    <i class=\"fas fa-trash-alt\"></i>\n                                </a>\n                            </div>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 64 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
            WriteLiteral(@"<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.5.2/dist/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
<script src=""https://kit.fontawesome.com/a076d05399.js"" crossorigin=""anonymous""></script>
");
            WriteLiteral(@"<script>
    $(document).ready(function () {
        // Live search filter
        $('#searchInput').on('input', function () {
            var query = $(this).val().toLowerCase();

            // Filter table rows based on the search query
            $('#patientTable tbody tr').each(function () {
                var rowText = $(this).text().toLowerCase();
                if (rowText.indexOf(query) !== -1) {
                    $(this).show(); // Show row if it matches
                } else {
                    $(this).hide(); // Hide row if it doesn't match
                }
            });
        });
    });
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IMSProject.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
