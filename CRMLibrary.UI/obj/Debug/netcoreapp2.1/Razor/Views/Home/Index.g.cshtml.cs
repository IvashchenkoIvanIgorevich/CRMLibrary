#pragma checksum "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81fa954179f6e8eb5df36f0fdb04a09b8d9d931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81fa954179f6e8eb5df36f0fdb04a09b8d9d931", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7452f03a874d423e210e45e99aa348fa8e7f8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 395, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <table border=""1"">
        <br />
        <tr>
            <th>Id</th>
            <th>Author</th>
            <th>Name</th>
            <th>Redaction</th>
            <th>Pages</th>
            <th>Summary</th>
            <th>Location</th>
            <th>IsAvailable</th>
        </tr>
");
            EndContext();
#line 18 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
         foreach (BookViewModel book in Model)
        {

#line default
#line hidden
            BeginContext(499, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(538, 7, false);
#line 21 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(545, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(573, 11, false);
#line 22 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(584, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(612, 9, false);
#line 23 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(621, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(649, 14, false);
#line 24 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Redaction);

#line default
#line hidden
            EndContext();
            BeginContext(663, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(691, 10, false);
#line 25 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Pages);

#line default
#line hidden
            EndContext();
            BeginContext(701, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(729, 12, false);
#line 26 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(741, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(769, 13, false);
#line 27 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.Location);

#line default
#line hidden
            EndContext();
            BeginContext(782, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(810, 16, false);
#line 28 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
               Write(book.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(826, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\MyPrograms\PetProjects\CRMLibrary\CRMLibrary.UI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(863, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
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
