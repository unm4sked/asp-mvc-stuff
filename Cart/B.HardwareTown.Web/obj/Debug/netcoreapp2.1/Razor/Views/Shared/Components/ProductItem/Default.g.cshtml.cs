#pragma checksum "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b9ed282c69ed60aba4afbcfd4341d198a6e885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductItem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductItem/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProductItem/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ProductItem_Default))]
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
#line 1 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
using B.HardwareTown.Infrastructure.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b9ed282c69ed60aba4afbcfd4341d198a6e885", @"/Views/Shared/Components/ProductItem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3058481e18e2a01d681734f79033f392ba0193e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductItem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<B.HardwareTown.Web.ViewModels.ProductsPagingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cpu.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-bottom:0.5em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-basic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::B.HardwareTown.Web.TagHelpers.PageLinkTagHelper __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(111, 33, true);
            WriteLiteral("\r\n<ul class=\"list-group-flush\">\r\n");
            EndContext();
#line 5 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
            BeginContext(197, 210, true);
            WriteLiteral("        <li class=\"list-group-item ml-0 pl-0\">\r\n            <div class=\"row\" style=\"padding-bottom: 1em; padding-top: 1em;\">\r\n                <div class=\"col-lg-3 col-md-4 col-sm-12 pl-0\">\r\n                    ");
            EndContext();
            BeginContext(407, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "903121e2508945b0ab5f7219128d9d3c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 112, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-4 col-sm-12 pl-0\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 579, "\"", 639, 1);
#line 13 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
WriteAttributeValue("", 586, Url.Action("Index","Details",new {id = product.Id }), 586, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(640, 15, true);
            WriteLiteral("><p class=\"h5\">");
            EndContext();
            BeginContext(656, 12, false);
#line 13 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                                             Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(668, 36, true);
            WriteLiteral("</p></a>\r\n                    <ul>\r\n");
            EndContext();
#line 15 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                         foreach (var detail in product.Details)
                        {

#line default
#line hidden
            BeginContext(797, 75, true);
            WriteLiteral("                            <li style=\"font-weight:200; font-size:medium;\">");
            EndContext();
            BeginContext(873, 6, false);
#line 17 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                      Write(detail);

#line default
#line hidden
            EndContext();
            BeginContext(879, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(913, 100, true);
            WriteLiteral("                    </ul>\r\n                    <p style=\"font-weight:600; font-size:medium;\">Bought ");
            EndContext();
            BeginContext(1014, 14, false);
#line 20 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                    Write(product.Bought);

#line default
#line hidden
            EndContext();
            BeginContext(1028, 369, true);
            WriteLiteral(@" times</p>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-12"" style=""text-align:right; display:inline;"">
                    <div>
                        <h3 align=""right"" style=""font-weight:700; display:inline-block; color:greenyellow;"">$</h3>
                        <h3 align=""right"" style=""font-weight:700; display:inline-block;"">");
            EndContext();
            BeginContext(1398, 13, false);
#line 25 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                                    Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 109, true);
            WriteLiteral("</h3>\r\n                        <h3 align=\"right\" style=\"font-weight:700; color:grey; display:inline-block;\">.");
            EndContext();
            BeginContext(1521, 50, false);
#line 26 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                                                 Write(String.Format("{0:00}", (product.Price % 1 * 100)));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 31, true);
            WriteLiteral("</h3>\r\n                        ");
            EndContext();
            BeginContext(1602, 541, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c6eef9fb9945d0b9fb7b4adfdc24c9", async() => {
                BeginContext(1684, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                               
                                Guid ProductId = product.Id;
                            

#line default
#line hidden
                BeginContext(1812, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1840, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36b7d7afd09641c292b73079edf4b074", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 31 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1883, 67, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1950, "\"", 2005, 1);
#line 32 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
WriteAttributeValue("", 1958, ViewContext.HttpContext.Request.PathAndQuery(), 1958, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2006, 130, true);
                WriteLiteral("/>\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-lg\">Add to Cart</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
AddHtmlAttributeValue("", 1612, product.Id, 1612, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2143, 185, true);
            WriteLiteral("\r\n                        <p style=\"color:red; margin-top:1em;  font-size:medium;\">Available</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
            EndContext();
#line 40 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(2335, 25, true);
            WriteLiteral("\r\n</ul>\r\n\r\n<center>\r\n    ");
            EndContext();
            BeginContext(2360, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a1c38c1efbc46308ed609d4492d9b3d", async() => {
            }
            );
            __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::B.HardwareTown.Web.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__B_HardwareTown_Web_TagHelpers_PageLinkTagHelper);
#line 45 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
__B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageModel = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 45 "C:\Users\Lukasz\Desktop\Hardware-Town\src\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
__B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __B_HardwareTown_Web_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2560, 11, true);
            WriteLiteral("\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<B.HardwareTown.Web.ViewModels.ProductsPagingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591