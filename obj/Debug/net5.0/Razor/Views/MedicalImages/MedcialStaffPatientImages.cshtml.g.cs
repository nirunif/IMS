#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43abf257b0da953f94922875fb0f0a29edbbddff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MedicalImages_MedcialStaffPatientImages), @"mvc.1.0.view", @"/Views/MedicalImages/MedcialStaffPatientImages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43abf257b0da953f94922875fb0f0a29edbbddff", @"/Views/MedicalImages/MedcialStaffPatientImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_MedicalImages_MedcialStaffPatientImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IMSProject.Models.PatientWithImages>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
  
    ViewData["Title"] = "Patients with Images";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Patients with Images</h2>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Patient Name</th>
            <th>Disease Type</th>
            <th>Image Type</th>
            <th>Image URL</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (var image in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 25 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
       Write(image.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
       Write(image.DiseaseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
       Write(image.ImageType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 666, "\"", 708, 1);
#nullable restore
#line 29 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
WriteAttributeValue("", 673, Url.Content("~/" + image.ImageURL), 673, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 29 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
                                                                     Write(image.ImageURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 790, "\"", 864, 1);
#nullable restore
#line 32 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
WriteAttributeValue("", 797, Url.Action("Details", "MedicalImages", new { id = image.ImageID }), 797, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">Details</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 921, "\"", 992, 1);
#nullable restore
#line 33 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
WriteAttributeValue("", 928, Url.Action("Edit", "MedicalImages", new { id = image.ImageID }), 928, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Edit</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1049, "\"", 1122, 1);
#nullable restore
#line 34 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
WriteAttributeValue("", 1056, Url.Action("Delete", "MedicalImages", new { id = image.ImageID }), 1056, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'Are you sure you want to delete this image?\');\">Delete</a>\r\n        </td>\r\n    </tr> ");
#nullable restore
#line 36 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
          }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td colspan=\"5\" class=\"text-center\">No medical images found.</td>\r\n    </tr>            ");
#nullable restore
#line 42 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalImages\MedcialStaffPatientImages.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IMSProject.Models.PatientWithImages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
