#pragma checksum "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3d643a51dddf211b15a2ea023694268d47406b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#line 1 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\_ViewImports.cshtml"
using ClientSideValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\_ViewImports.cshtml"
using ClientSideValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3d643a51dddf211b15a2ea023694268d47406b", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ca72dcd95b4117c436306fe61dcf04a2c125ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Confirmation</h1>
<br /><br />

<table width=""80%"" style=""align-content:center"">
    <tbody>
        <tr>
            <td style=""text-align: right"">First Name Entered</td>
            <td style=""text-align: center""> :: </td>
            <td style=""text-align: left"">");
#nullable restore
#line 14 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml"
                                    Write(Model.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align: right\">Last Name Entered</td>\r\n            <td style=\"text-align: center\"> :: </td>\r\n            <td style=\"text-align: left\">");
#nullable restore
#line 19 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml"
                                    Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align: right\">Email Entered</td>\r\n            <td style=\"text-align: center\"> :: </td>\r\n            <td style=\"text-align: left\">");
#nullable restore
#line 24 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml"
                                    Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align: right\">Password Entered</td>\r\n            <td style=\"text-align: center\"> :: </td>\r\n            <td style=\"text-align: left\">");
#nullable restore
#line 29 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml"
                                    Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align: right\">Password Confirmation Entered</td>\r\n            <td style=\"text-align: center\"> :: </td>\r\n            <td style=\"text-align: left\">");
#nullable restore
#line 34 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Confirmation.cshtml"
                                    Write(Model.confirm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
