#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b0b70f7462ba145353b45384ebd977ea84a0583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Create), @"mvc.1.0.view", @"/Views/Patient/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b0b70f7462ba145353b45384ebd977ea84a0583", @"/Views/Patient/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IMSProject.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DoctorSelect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("patientForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "X-Ray", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "MRI", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "CT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ultrasound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
  
    ViewData["Title"] = "Create Patient";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"<link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" rel=""stylesheet"" />

<style>
    .form-container {
        max-width: 100%;
        margin: 0 auto;
        padding: 20px;
        display: flex;
        justify-content: space-between;
        border: 1px solid #ddd;
        border-radius: 8px;
        background-color: #f9f9f9;
    }

    .form-section {
        width: 48%;
    }

    .form-footer {
        text-align: center;
        margin-top: 20px;
    }

        .form-footer .btn {
            margin: 5px;
        }
</style>

<div class=""container mt-4"">
    <h2 class=""text-center mb-4"">Create New Patient</h2>

    <div class=""form-container"">
        <!-- Patient Details Form Section -->
        <div class=""form-section"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a05837867", async() => {
                WriteLiteral("\n                <div class=\"form-group\">\n                    <label for=\"Name\">Name</label>\n                    <input type=\"text\" class=\"form-control\" id=\"Name\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 1181, "\"", 1200, 1);
#nullable restore
#line 47 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 1189, Model.Name, 1189, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required placeholder=""Enter patient's full name"" />
                    <div class=""invalid-feedback"">Name is required.</div>
                </div>

                <div class=""form-group"">
                    <label for=""Address"">Address</label>
                    <input type=""text"" class=""form-control"" id=""Address"" name=""Address""");
                BeginWriteAttribute("value", " value=\"", 1537, "\"", 1559, 1);
#nullable restore
#line 53 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 1545, Model.Address, 1545, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required placeholder=""Enter patient's address"" />
                    <div class=""invalid-feedback"">Address is required.</div>
                </div>

                <div class=""form-group"">
                    <label for=""ContactNumber"">Contact Number</label>
                    <input type=""text"" class=""form-control"" id=""ContactNumber"" name=""ContactNumber""");
                BeginWriteAttribute("value", " value=\"", 1922, "\"", 1950, 1);
#nullable restore
#line 59 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 1930, Model.ContactNumber, 1930, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required placeholder=""Enter contact number"" pattern=""^\d{10}$"" />
                    <div class=""invalid-feedback"">Please enter a valid contact number (10 digits).</div>
                </div>

                <div class=""form-group"">
                    <label for=""DateofBirth"">Date of Birth</label>
                    <input type=""date"" class=""form-control"" id=""DateofBirth"" name=""DateofBirth""");
                BeginWriteAttribute("value", " value=\"", 2350, "\"", 2394, 1);
#nullable restore
#line 65 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 2358, DateTime.Now.ToString("yyyy-MM-dd"), 2358, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\n                    <div class=\"invalid-feedback\">Date of Birth is required.</div>\n                </div>\n\n                <div class=\"form-group\">\n                    <label for=\"DoctorSelect\">Assign Doctor</label>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058311190", async() => {
                    WriteLiteral("\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058311481", async() => {
                        WriteLiteral("-- Select Doctor --");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n");
#nullable restore
#line 73 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
                         foreach (var doctor in (IEnumerable<IMSProject.Models.MedicalStaff>)ViewData["Doctors"])
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058313118", async() => {
#nullable restore
#line 75 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
                                                  Write(doctor.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
                   WriteLiteral(doctor.MedicalStaffID);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("            ");
#nullable restore
#line 75 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 71 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MedicalStaffID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058316782", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 77 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MedicalStaffID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n\n                <div class=\"form-group\">\n                    <label for=\"MedicalCondition\">Medical Condition</label>\n                    <input type=\"text\" class=\"form-control\" id=\"MedicalCondition\" name=\"MedicalCondition\"");
                BeginWriteAttribute("value", " value=\"", 3383, "\"", 3414, 1);
#nullable restore
#line 82 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 3391, Model.MedicalCondition, 3391, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required placeholder=""Enter medical condition"" />
                    <div class=""invalid-feedback"">Medical condition is required.</div>
                </div>

                <div class=""form-group"">
                    <label for=""Diagnosis"">Diagnosis</label>
                    <input type=""text"" class=""form-control"" id=""Diagnosis"" name=""Diagnosis""");
                BeginWriteAttribute("value", " value=\"", 3770, "\"", 3794, 1);
#nullable restore
#line 88 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 3778, Model.Diagnosis, 3778, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required placeholder=""Enter diagnosis"" />
                    <div class=""invalid-feedback"">Diagnosis is required.</div>
                </div>

                <div class=""form-group"">
                    <label for=""TotalCost"">Total Cost</label>
                    <input type=""number"" step=""0.01"" class=""form-control"" id=""TotalCost"" name=""TotalCost""");
                BeginWriteAttribute("value", " value=\"", 4149, "\"", 4173, 1);
#nullable restore
#line 94 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 4157, Model.TotalCost, 4157, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required placeholder=\"Enter total cost\" />\n                    <div class=\"invalid-feedback\">Total cost is required.</div>\n                </div>\n\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        </div>\n\n        <!-- Medical Image Upload Section -->\n\n        <div class=\"form-section\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058322065", async() => {
                WriteLiteral("\n");
                WriteLiteral("\n                <div class=\"form-group\">\n                    <label for=\"ImageType\">Image Type</label>\n                    <select class=\"form-control\" id=\"ImageType\" name=\"ImageType\" required>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058322590", async() => {
                    WriteLiteral("X-Ray");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058323835", async() => {
                    WriteLiteral("MRI");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058325078", async() => {
                    WriteLiteral("CT Scan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b0b70f7462ba145353b45384ebd977ea84a058326325", async() => {
                    WriteLiteral("Ultrasound");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <!-- Add other image types as necessary -->
                    </select>
                </div>

                <div class=""form-group"">
                    <label for=""DiseaseType"">Disease Type</label>
                    <input type=""text"" class=""form-control"" id=""DiseaseType"" name=""DiseaseType"" required placeholder=""Enter disease type"" />
                </div>

                <div class=""form-group"">
                    <label for=""ImageUpload"">Upload Medical Images</label>
                    <input type=""file"" class=""form-control"" id=""ImageUpload"" name=""ImageUpload"" multiple required />
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n\n\n\n    </div>\n\n    <div class=\"form-footer\">\n        <button type=\"submit\" class=\"btn btn-primary\" id=\"savePatientBtn\">Save Patient</button>\n        <a");
            BeginWriteAttribute("href", " href=\"", 5793, "\"", 5831, 1);
#nullable restore
#line 139 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
WriteAttributeValue("", 5800, Url.Action("Index", "Patient"), 5800, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Cancel</a>\n    </div>\n</div>\n\n");
            WriteLiteral(@"<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.5.2/dist/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

<script>
    // Handle the form submission to send patient and image data separately
    document.getElementById(""savePatientBtn"").onclick = function () {
        var patientForm = document.getElementById(""patientForm"");
        var formData = new FormData(patientForm);

        // Send patient details via AJAX
        $.ajax({
            url: '");
#nullable restore
#line 156 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
             Write(Url.Action("Create", "Patient"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            data: formData,
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.patientId) {
                    var patientId = response.patientId; // Get the patientId from the response
                    // Now handle the medical images upload only if patient save is successful

                    var imageForm = new FormData();
                    imageForm.append('patientId', patientId);
                    var imageFiles = document.getElementById('ImageUpload').files;

                    // Loop through selected image files and append to imageForm
                    for (var i = 0; i < imageFiles.length; i++) {
                        imageForm.append('ImageUpload', imageFiles[i]);
                    }

                    imageForm.append('ImageType', document.getElementById('ImageType').value);
                    imageForm.append('DiseaseType', document.getElementById('DiseaseType').v");
            WriteLiteral("alue);\n\n                    // Send medical image data\n                    $.ajax({\n                        url: \'");
#nullable restore
#line 180 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
                         Write(Url.Action("UploadImages", "MedicalImages"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        type: 'POST',
                        data: imageForm,
                        contentType: false,
                        processData: false,
                        success: function () {
                            alert('Saved successfully!');
                            // Redirect to the Patient Index page (or details page)
                            window.location.href = '");
#nullable restore
#line 188 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Patient\Create.cshtml"
                                               Write(Url.Action("Index", "Patient"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                        },
                        error: function () {
                            alert('Error uploading images');
                        }
                    });
                } else {
                    alert('Error saving patient details');
                }
            },
            error: function () {
                alert('Error saving patient details');
            }
        });
    };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IMSProject.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
