#pragma checksum "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10042b6c2c47312dd74c29c3dfe23c6a04de2a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInformation), @"mvc.1.0.view", @"/Views/Home/UserInformation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInformation.cshtml", typeof(AspNetCore.Views_Home_UserInformation))]
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
#line 1 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\_ViewImports.cshtml"
using CRMLibrary.UI;

#line default
#line hidden
#line 2 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\_ViewImports.cshtml"
using CRMLibrary.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10042b6c2c47312dd74c29c3dfe23c6a04de2a9", @"/Views/Home/UserInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7452f03a874d423e210e45e99aa348fa8e7f8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
  
    ViewData["Title"] = "User Information";

#line default
#line hidden
            BeginContext(54, 119, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1>User Information</h1>\r\n    <p>\r\n        <div>\r\n            <label>Username:</label> ");
            EndContext();
            BeginContext(174, 18, false);
#line 10 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
                                Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(192, 75, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label>Claims</label> <br />\r\n");
            EndContext();
#line 14 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
             foreach (var claim in User.Claims)
            {

#line default
#line hidden
            BeginContext(331, 21, true);
            WriteLiteral("                <div>");
            EndContext();
            BeginContext(353, 12, false);
#line 16 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
                Write(claim.Issuer);

#line default
#line hidden
            EndContext();
            BeginContext(365, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(369, 10, false);
#line 16 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
                                Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(379, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(383, 11, false);
#line 16 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
                                              Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(394, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 17 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\UserInformation.cshtml"
            }

#line default
#line hidden
            BeginContext(417, 32, true);
            WriteLiteral("        </div>\r\n    </p>\r\n\r\n    ");
            EndContext();
            BeginContext(449, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98238171161a4f48a970c9ec6dac1397", async() => {
                BeginContext(511, 106, true);
                WriteLiteral("\r\n        <a href=\"javascript:document.forms[0].submit()\" class=\"btn btn-lg btn-primary\">Log Out</a>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(624, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
