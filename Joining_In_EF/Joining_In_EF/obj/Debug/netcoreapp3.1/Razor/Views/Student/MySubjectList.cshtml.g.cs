#pragma checksum "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a4e08a3f9f4e7e55b3c57bc6ee0848bd068bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_MySubjectList), @"mvc.1.0.view", @"/Views/Student/MySubjectList.cshtml")]
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
#line 1 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\_ViewImports.cshtml"
using Joining_In_EF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\_ViewImports.cshtml"
using Joining_In_EF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a4e08a3f9f4e7e55b3c57bc6ee0848bd068bf1", @"/Views/Student/MySubjectList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1cb983f8390191f8694271af330c62f69c2f1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_MySubjectList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Joining_In_EF.Models.Subject>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
  
    ViewData["Title"] = "MySubjectList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MySubjectList</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 32 "D:\DotNetProject\Joining_In_EF\Joining_In_EF\Views\Student\MySubjectList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Joining_In_EF.Models.Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
