#pragma checksum "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aec273f0df80d67102309960238dee4e7417b869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Results_ViewResult), @"mvc.1.0.view", @"/Views/Results/ViewResult.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\_ViewImports.cshtml"
using LMS_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\_ViewImports.cshtml"
using LMS_Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\_ViewImports.cshtml"
using System.Web.Optimization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec273f0df80d67102309960238dee4e7417b869", @"/Views/Results/ViewResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2bcdd8fc08353438d43240261eaaa1c0873ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Results_ViewResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LMS_Demo.Models.Result>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
  
    ViewBag.Title = "ViewResult";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>ViewResult</h2>\r\n\r\n<table id=\"tblResult\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
           Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
           Write(Html.DisplayNameFor(model => model.Assesment.TotalMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
           Write(Html.DisplayNameFor(model => model.Assesment.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
           Write(Html.DisplayNameFor(model => model.Facilitator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Assesment.TotalMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Assesment.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Facilitator.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.SysId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Results\ViewResult.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#tblResult\").DataTable();\r\n    })\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LMS_Demo.Models.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591