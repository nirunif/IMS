#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43c9118c4daa56eb51e3ce5cabca073bfab570ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Delete), @"mvc.1.0.view", @"/Views/Patient/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43c9118c4daa56eb51e3ce5cabca073bfab570ee", @"/Views/Patient/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IMSProject.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Delete Patient</h2>\n\n<div class=\"alert alert-danger\">\n    <strong>Warning!</strong> Are you sure you want to delete the patient \"<strong>");
#nullable restore
#line 6 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                                                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\"?\n</div>\n\n<div>\n    <p>\n        <strong>Name:</strong> ");
#nullable restore
#line 11 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <strong>Address:</strong> ");
#nullable restore
#line 12 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                             Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <strong>Contact Number:</strong> ");
#nullable restore
#line 13 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                                    Write(Model.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <strong>Date of Birth:</strong> ");
#nullable restore
#line 14 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                                   Write(Model.DateofBirth.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <strong>Medical Condition:</strong> ");
#nullable restore
#line 15 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                                       Write(Model.MedicalCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <strong>Diagnosis:</strong> ");
#nullable restore
#line 16 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                               Write(Model.Diagnosis);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <strong>Total Cost:</strong> ");
#nullable restore
#line 17 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
                                Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43c9118c4daa56eb51e3ce5cabca073bfab570ee5923", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"PatientID\"");
                BeginWriteAttribute("value", " value=\"", 797, "\"", 821, 1);
#nullable restore
#line 22 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
WriteAttributeValue("", 805, Model.PatientID, 805, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <button type=\"submit\" class=\"btn btn-danger\">Yes, Delete</button>\n    <a");
                BeginWriteAttribute("href", " href=\"", 902, "\"", 940, 1);
#nullable restore
#line 24 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
WriteAttributeValue("", 909, Url.Action("Index", "Patient"), 909, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\">Cancel</a>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Delete.cshtml"
AddHtmlAttributeValue("", 712, Url.Action("DeleteConfirmed", "Patient"), 712, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<script>$(\'form\').on(\'submit\', function (e) {\n        if (!confirm(\"Are you sure you want to delete this patient?\")) {\n            e.preventDefault(); // Prevent the form from submitting if the user cancels\n        }\n    });</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IMSProject.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
