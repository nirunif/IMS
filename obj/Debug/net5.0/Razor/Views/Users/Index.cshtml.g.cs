#pragma checksum "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52afad19316a731f4532f59997c77d099e488862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52afad19316a731f4532f59997c77d099e488862", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476740cf8e0b42df5a85349ada601590a85d133", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IMSProject.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "User List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<link href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" rel=\"stylesheet\" />\n\n<div class=\"container mt-6\">\n    <h2 class=\"text-center mb-4\">User List</h2>\n\n    <div class=\"text-center mb-4\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 363, "\"", 400, 1);
#nullable restore
#line 14 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
WriteAttributeValue("", 370, Url.Action("Create", "Users"), 370, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm"">
            <i class=""fas fa-plus""></i> Add New User
        </a>
    </div>

    <div class=""table-responsive"" style=""width: 100%;"">
        <table class=""table table-bordered table-hover text-center"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Role</th>
                    <th>Username</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 32 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
                       Write(user.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 33 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
                       Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <div class=\"d-flex justify-content-around\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1184, "\"", 1245, 1);
#nullable restore
#line 36 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
WriteAttributeValue("", 1191, Url.Action("Edit", "Users", new { id = user.UserID }), 1191, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\n                                    <i class=\"fas fa-edit\"></i> Edit\n                                </a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1419, "\"", 1482, 1);
#nullable restore
#line 39 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
WriteAttributeValue("", 1426, Url.Action("Delete", "Users", new { id = user.UserID }), 1426, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\n                                    <i class=\"fas fa-trash-alt\"></i> Delete\n                                </a>\n                            </div>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 45 "D:\MSc\SAPM\IMS-master\IMS-master\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.5.2/dist/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
<script src=""https://kit.fontawesome.com/a076d05399.js"" crossorigin=""anonymous""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IMSProject.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
