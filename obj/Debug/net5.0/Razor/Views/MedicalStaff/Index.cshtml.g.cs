#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1402f3543cfd56034e83fc06d322f6ef37466087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MedicalStaff_Index), @"mvc.1.0.view", @"/Views/MedicalStaff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1402f3543cfd56034e83fc06d322f6ef37466087", @"/Views/MedicalStaff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_MedicalStaff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IMSProject.Models.MedicalStaff>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Radiologist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Nurse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
  
    ViewData["Title"] = "Medical Staff List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<link href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" rel=\"stylesheet\" />\n\n<div class=\"container mt-6\">\n    <h2 class=\"text-center mb-4\">Medical Staff List</h2>\n\n    <div class=\"text-center mb-4\">\n");
            WriteLiteral(@"
        <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#createModal"">
            <i class=""fas fa-plus""></i>Add New Medical Staff
        </button>

    </div>
    <!-- Button to trigger the modal -->
    

    <div class=""table-responsive"" style=""width: 100%;"">
        <table class=""table table-bordered table-hover text-center"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Name</th>
                    <th>Role</th>
                    <th>Contact</th>
                    <th>Specialization</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
                 foreach (var staff in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 42 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
                       Write(staff.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 43 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
                       Write(staff.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
                       Write(staff.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
                       Write(staff.Specialty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <div class=\"d-flex justify-content-around\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1757, 1);
#nullable restore
#line 48 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
WriteAttributeValue("", 1684, Url.Action("Details", "MedicalStaff", new { id = staff.MedicalStaffID }), 1684, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">\n                                    <i class=\"fas fa-eye\"></i>\n                                </a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1922, "\"", 1999, 1);
#nullable restore
#line 51 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
WriteAttributeValue("", 1929, Url.Action("Edit", "MedicalStaff", new { id = staff.MedicalStaffID }), 1929, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\n                                    <i class=\"fas fa-edit\"></i>\n                                </a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2168, "\"", 2247, 1);
#nullable restore
#line 54 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
WriteAttributeValue("", 2175, Url.Action("Delete", "MedicalStaff", new { id = staff.MedicalStaffID }), 2175, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\n                                    <i class=\"fas fa-trash-alt\"></i>\n                                </a>\n                            </div>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 60 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>




<!-- Modal -->
<div class=""modal fade"" id=""createModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""createModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModalLabel"">Add New Medical Staff</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1402f3543cfd56034e83fc06d322f6ef3746608710567", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""Name"">Name</label>
                        <input type=""text"" class=""form-control"" id=""Name"" name=""Name"" required />
                    </div>
                    <div class=""form-group"">
                        <label for=""Role"">Role</label>
                        <select class=""form-control"" id=""Role"" name=""Role"" required>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1402f3543cfd56034e83fc06d322f6ef3746608711284", async() => {
                    WriteLiteral("-- Select Role --");
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
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1402f3543cfd56034e83fc06d322f6ef3746608712545", async() => {
                    WriteLiteral("Doctor");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1402f3543cfd56034e83fc06d322f6ef3746608713795", async() => {
                    WriteLiteral("Radiologist");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1402f3543cfd56034e83fc06d322f6ef3746608715050", async() => {
                    WriteLiteral("Nurse");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""ContactNumber"">Contact Number</label>
                        <input type=""text"" class=""form-control"" id=""ContactNumber"" name=""ContactNumber"" required />
                    </div>
                    <div class=""form-group"">
                        <label for=""Email"">Email</label>
                        <input type=""text"" class=""form-control"" id=""Email"" name=""Email"" required />
                    </div>
                    <div class=""form-group"">
                        <label for=""Specialty"">Specialty</label>
                        <input type=""text"" class=""form-control"" id=""Specialty"" name=""Specialty"" required />
                    </div>
                    <div class=""form-group"">
                        <label for=""DateOfJoining"">Date of Joining</label>
                        <input type=""date"" class=""form-control"" id=""DateOfJoining"" name=""DateOfJoining""");
                BeginWriteAttribute("value", "\n                               value=\"", 4908, "\"", 4983, 1);
#nullable restore
#line 109 "D:\MSc\SAPM\IMS-master\IMS-master\Views\MedicalStaff\Index.cshtml"
WriteAttributeValue("", 4947, DateTime.Now.ToString("yyyy-MM-dd"), 4947, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
                        <div class=""invalid-feedback"">Date of joining is required.</div>
                    </div>
                    <div class=""text-center mt-4"">
                        <button type=""submit"" class=""btn btn-success btn-sm"">
                            <i class=""fas fa-check""></i> Save
                        </button>
                        <button type=""button"" class=""btn btn-secondary btn-sm"" data-dismiss=""modal"">
                            <i class=""fas fa-times""></i> Cancel
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IMSProject.Models.MedicalStaff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
