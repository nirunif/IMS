#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5aa71c42b993898f2e52de2847903695b23880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient__PatientTable), @"mvc.1.0.view", @"/Views/Patient/_PatientTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5aa71c42b993898f2e52de2847903695b23880", @"/Views/Patient/_PatientTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient__PatientTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IMSProject.Models.Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
 foreach (var patient in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 6 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
       Write(patient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 7 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
       Write(patient.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 8 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
       Write(patient.DateofBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 9 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
       Write(patient.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 10 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
       Write(patient.MedicalCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 11 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
       Write(patient.Diagnosis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>$");
#nullable restore
#line 12 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
        Write(patient.TotalCost.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            <div class=\"d-flex justify-content-around\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 471, "\"", 543, 1);
#nullable restore
#line 15 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
WriteAttributeValue("", 478, Url.Action("Details", "Patient", new { id = patient.PatientID }), 478, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">\n                    <i class=\"fas fa-eye\"></i>\n                </a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 660, "\"", 729, 1);
#nullable restore
#line 18 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
WriteAttributeValue("", 667, Url.Action("Edit", "Patient", new { id = patient.PatientID }), 667, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\n                    <i class=\"fas fa-edit\"></i>\n                </a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 850, "\"", 921, 1);
#nullable restore
#line 21 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
WriteAttributeValue("", 857, Url.Action("Delete", "Patient", new { id = patient.PatientID }), 857, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\n                    <i class=\"fas fa-trash-alt\"></i>\n                </a>\n            </div>\n        </td>\n    </tr>\n");
#nullable restore
#line 27 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\_PatientTable.cshtml"
}

#line default
#line hidden
#nullable disable
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
