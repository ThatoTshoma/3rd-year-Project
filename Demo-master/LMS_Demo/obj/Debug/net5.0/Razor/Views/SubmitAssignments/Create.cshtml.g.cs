#pragma checksum "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed0810aadfad68ccece0aad33eee0d10c3199108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubmitAssignments_Create), @"mvc.1.0.view", @"/Views/SubmitAssignments/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed0810aadfad68ccece0aad33eee0d10c3199108", @"/Views/SubmitAssignments/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2bcdd8fc08353438d43240261eaaa1c0873ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SubmitAssignments_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LMS_Demo.Models.SubmitAssignment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
 using (Html.BeginForm("Upload", "SubmitAssignments", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>SubmitAssignment</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 17 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
       Write(Html.LabelFor(model => model.StudentId, "StudentId", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.EditorFor(model => model.StudentId, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly", @Value=ViewData["ID"] } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.StudentId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
       Write(Html.LabelFor(model => model.AssesmentId, "AssesmentId", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 29 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.EditorFor(model => model.AssesmentId, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.AssesmentId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
       Write(Html.LabelFor(model => model.FilePath, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <input type=\"file\" name=\"File\" required />\r\n");
            WriteLiteral("                ");
#nullable restore
#line 39 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FilePath, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 44 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
       Write(Html.LabelFor(model => model.SubmissionDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 46 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.EditorFor(model => model.SubmissionDate, new { htmlAttributes = new { @class = "form-control", @Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),@readonly="readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 47 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.SubmissionDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <button type=""submit"" class=""btn btn-success""><i class=""fa fa-send-o""></i>Submit</button>
            </div>
        </div>
    </div>
");
#nullable restore
#line 57 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 60 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\SubmitAssignments\Create.cshtml"
Write(Html.ActionLink("Back", "Index",new { },new { @class="btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LMS_Demo.Models.SubmitAssignment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
