#pragma checksum "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283feb4ad65fe48c84260aae2bba949b16a0d276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssesmentsControllerler_Delete), @"mvc.1.0.view", @"/Views/AssesmentsControllerler/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283feb4ad65fe48c84260aae2bba949b16a0d276", @"/Views/AssesmentsControllerler/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2bcdd8fc08353438d43240261eaaa1c0873ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AssesmentsControllerler_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LMS_Demo.Models.Assesment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<h3>You are going to delete this assesment including filled marks and submitted files.<br />\r\n    Are you sure you want to delete?</h3>\r\n<div> \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 30 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GivenDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GivenDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeadLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeadLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 46 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 50 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 54 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 58 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 70 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AssesmentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 74 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AssesmentType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 78 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 82 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 86 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 90 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 94 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Section));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");
            WriteLiteral("        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 102 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 106 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 111 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
     using (Html.BeginForm()) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n            ");
#nullable restore
#line 116 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index", new { }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 118 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\AssesmentsControllerler\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LMS_Demo.Models.Assesment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
