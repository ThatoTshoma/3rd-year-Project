#pragma checksum "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23eeee40ae87603722141cdd4e669c2c80ced4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Years_Edit), @"mvc.1.0.view", @"/Views/Years/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23eeee40ae87603722141cdd4e669c2c80ced4d1", @"/Views/Years/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2bcdd8fc08353438d43240261eaaa1c0873ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Years_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LMS_Demo.Models.Year>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Year</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 18 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
Write(Html.HiddenFor(model => model.SysId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
   Write(Html.LabelFor(model => model.Value, "Year", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
       Write(Html.EditorFor(model => model.Value, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Value, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
   Write(Html.LabelFor(model => model.CreatedBy, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
       Write(Html.EditorFor(model => model.CreatedBy, new { htmlAttributes = new { @class = "form-control", @Value = ViewData["ID"], @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.CreatedBy, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 43 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 46 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\Years\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index", new { }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LMS_Demo.Models.Year> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
