#pragma checksum "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de5beb2012195d6a8aa2f5e2a3772167528cc11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoursesStudent_Index), @"mvc.1.0.view", @"/Views/CoursesStudent/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de5beb2012195d6a8aa2f5e2a3772167528cc11", @"/Views/CoursesStudent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2bcdd8fc08353438d43240261eaaa1c0873ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CoursesStudent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LMS_Demo.Models.Course>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Your Registered Courses</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            Course Name\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            Instructor\r\n        </th>\r\n        <th>Assesments</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 27 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 30 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Year.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 33 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Facilitator.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td> \r\n        <td> \r\n            ");
#nullable restore
#line 36 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
       Write(Html.ActionLink(" ", "AssesmentsUnderCourse", new { id = item.SysId }, new { @class = "btn  btn-success li fa fa-eye" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LMS_Demo.Models.Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591