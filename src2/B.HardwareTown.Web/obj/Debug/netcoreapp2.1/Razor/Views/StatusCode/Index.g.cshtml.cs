#pragma checksum "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\StatusCode\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f4c5739e3162edea1d104e1a80a5481128bb244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StatusCode_Index), @"mvc.1.0.view", @"/Views/StatusCode/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StatusCode/Index.cshtml", typeof(AspNetCore.Views_StatusCode_Index))]
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
#line 1 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\_ViewImports.cshtml"
using B.HardwareTown.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4c5739e3162edea1d104e1a80a5481128bb244", @"/Views/StatusCode/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3058481e18e2a01d681734f79033f392ba0193e7", @"/Views/_ViewImports.cshtml")]
    public class Views_StatusCode_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\StatusCode\Index.cshtml"
  
    var statusCode = Model;
    var statusmessage = "";
    switch (statusCode)
    {
        case 400:
            statusmessage = "Bad request: The request cannot be fulfilled due to bad syntax";
            break;
        case 403:
            statusmessage = "Forbidden";
            break;
        case 404:
            statusmessage = "Page not found";
            break;
        case 408:
            statusmessage = "The server timed out waiting for the request";
            break;
        case 500:
            statusmessage = "Internal Server Error - server was unable to finish processing the request";
            break;
        default:
            statusmessage = "That’s odd... Something we didn't expect happened";
            break;
    }

#line default
#line hidden
            BeginContext(799, 60, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1 class=\"text-danger\">Error: ");
            EndContext();
            BeginContext(860, 5, false);
#line 28 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\StatusCode\Index.cshtml"
                              Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(865, 16, true);
            WriteLiteral("  </h1>\r\n    <p>");
            EndContext();
            BeginContext(882, 13, false);
#line 29 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\StatusCode\Index.cshtml"
  Write(statusmessage);

#line default
#line hidden
            EndContext();
            BeginContext(895, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
