#pragma checksum "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3e43709a3b1393cf2ca3bd33b1a3d87d3bb205"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3e43709a3b1393cf2ca3bd33b1a3d87d3bb205", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ca72dcd95b4117c436306fe61dcf04a2c125ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validate()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/confirmation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    function validate() {
        let FNmessage = document.getElementById('FNmessage');
        let LNmessage = document.getElementById('LNmessage');
        let Emailmessage = document.getElementById('Emailmessage');
        let Passmessage = document.getElementById('Passmessage');
        let Confmessage = document.getElementById('Confmessage');
        let cont = true;

        let firstname = document.getElementById('firstname');
        if (!isNaN(firstname.value) || firstname.value.length < 2) {
            FNmessage.innerHTML = 'First Name must be at least 2 letters long and not contain numbers.';
            cont = false;
        }
        else {
            FNmessage.innerHTML = '';
        }

        let lastname = document.getElementById('lastname');
        if (!isNaN(lastname.value) || lastname.value.length < 2) {
            LNmessage.innerHTML = 'Last Name must be at least 2 letters long and not contain numbers.';
            cont = false;
        }
        else ");
            WriteLiteral("{\r\n            LNmessage.innerHTML = \'\';\r\n        }\r\n\r\n        let email = document.getElementById(\'email\');\r\n        if (email.value.match(/^(.{2,})");
            WriteLiteral(@"@(.{2,})\.(.{2,})$/)) {
            Emailmessage.innerHTML = '';
        }
        else {
            Emailmessage.innerHTML = 'Please enter a valid email address.';
            cont = false;
        }

        let confirm = document.getElementById('confirm');
        if (confirm.value != password.value) {
            Confmessage.innerHTML = 'Confirmation password must match the password exactly.';
            cont = false;
        }
        else {
            Confmessage.innerHTML = '';
        }

        return cont;
    }




</script>




");
#nullable restore
#line 57 "C:\Users\lbrown4\dev\week15\week15project1\ClientSideValidation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Fill This Out For No Reason! #FTOFNR</h1>\r\n</div>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea3e43709a3b1393cf2ca3bd33b1a3d87d3bb2056479", async() => {
                WriteLiteral(@"
    <input type=""submit"" value=""Pointless Entry"" style=""width: 200px; margin: 0 auto;"" />
    <table width=""100%"" style=""align-content:center"">
        <tbody>
            <tr>
                <td style=""text-align: right"">
                    First Name
                </td>
                <td style=""text-align: center""> :: </td>
                <td style=""text-align: left"">
                    <input type=""text"" name=""firstname"" id=""firstname"" />
                    <span style=""color:red; font:bolder"" id=""FNmessage""></span>
                </td>
            </tr>
            <tr>
                <td style=""text-align: right"">
                    Last Name
                </td>
                <td style=""text-align: center""> :: </td>

                <td style=""text-align: left"">
                    <input type=""text"" name=""lastname"" id=""lastname"" />
                    <span style=""color:red; font:bolder"" id=""LNmessage""></span>
                </td>
            </tr>
            ");
                WriteLiteral(@"<tr>
                <td style=""text-align: right"">
                    Email
                </td>
                <td style=""text-align: center""> :: </td>

                <td style=""text-align: left"">
                    <input type=""text"" name=""email"" id=""email"" />
                    <span style=""color:red; font:bolder"" id=""Emailmessage""></span>
                </td>
            </tr>
            <tr>
                <td style=""text-align: right"">
                    Password
                </td>
                <td style=""text-align: center""> :: </td>

                <td style=""text-align: left"">
                    <input type=""text"" name=""password"" id=""password"" />
                    <span style=""color:red; font:bolder"" id=""Passmessage""></span>
                </td>
            </tr>
            <tr>
                <td style=""text-align: right"">
                    Confirm Password
                </td>
                <td style=""text-align: center""> :: </td>

         ");
                WriteLiteral(@"       <td style=""text-align: left"">
                    <input type=""text"" name=""confirm"" id=""confirm"" />
                    <span style=""color:red; font:bolder"" id=""Confmessage""></span>
                </td>
            </tr>
        </tbody>

    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
