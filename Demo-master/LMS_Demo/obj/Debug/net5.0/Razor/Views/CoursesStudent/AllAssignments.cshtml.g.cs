#pragma checksum "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01b788bda1f01a1c78e13088fc5f145149d3faa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoursesStudent_AllAssignments), @"mvc.1.0.view", @"/Views/CoursesStudent/AllAssignments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b788bda1f01a1c78e13088fc5f145149d3faa4", @"/Views/CoursesStudent/AllAssignments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2bcdd8fc08353438d43240261eaaa1c0873ff7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CoursesStudent_AllAssignments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LMS_Demo.Models.Assesment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-primary li"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:10px;width:95%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
  
    ViewBag.Title = "AllAssignments";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<h2>All ");
#nullable restore
#line 8 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
   Write(ViewBag.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.GivenDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.DeadLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.AssesmentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 31 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            Instructor\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 37 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
       Write(Html.DisplayNameFor(model => model.Attachment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.GivenDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeadLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssesmentType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Facilitator.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
           Write(Html.ActionLink("Download", "Download", new { filePath = item.Attachment }, new { @class = "fa fa-download" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 73 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
                  
                    string assesmentType = item.AssesmentType.Name;
                    if (assesmentType == "Assignment")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b788bda1f01a1c78e13088fc5f145149d3faa411373", async() => {
                WriteLiteral("<i class=\"fa-send\"></i>Submit");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2268, "~/SubmitAssignments/Create?assesmentID=", 2268, 39, true);
#nullable restore
#line 77 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
AddHtmlAttributeValue("", 2307, item.SysId, 2307, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
#nullable restore
#line 86 "C:\Users\sngec\Documents\Demo_Project\LMS_Demo\Views\CoursesStudent\AllAssignments.cshtml"
Write(Html.ActionLink("Back", "Index", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LMS_Demo.Models.Assesment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
