#pragma checksum "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a737c5bab27687ea129269201e5d1ba6e4aa91ba"
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
#line 1 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\_ViewImports.cshtml"
using MyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\_ViewImports.cshtml"
using MyShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a737c5bab27687ea129269201e5d1ba6e4aa91ba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac74f13ce1837588570ccc8938c94d33e1ab613", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- Start Products  -->
<div class=""products-box"">
    <div class=""container"">
     
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""title-all text-center"">
                    <h1>Products</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""special-menu text-center"">
                    <div class=""button-group filter-button-group"">
                        <button class=""active"" data-filter=""*"">All</button>
");
#nullable restore
#line 19 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button data-filter=\".");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
                                             Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
                                                               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 23 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row special-list\">\r\n        \r\n");
#nullable restore
#line 32 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 1022, "\"", 1077, 4);
            WriteAttributeValue("", 1030, "col-lg-3", 1030, 8, true);
            WriteAttributeValue(" ", 1038, "col-md-6", 1039, 9, true);
            WriteAttributeValue(" ", 1047, "special-grid", 1048, 13, true);
#nullable restore
#line 36 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1060, item.CategoryId, 1061, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""products-single fix"">
                    <div class=""box-img-hover"">
                        <div class=""type-lb"">
                            <p class=""sale"">Sale</p>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a737c5bab27687ea129269201e5d1ba6e4aa91ba6713", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1348, "~/", 1348, 2, true);
#nullable restore
#line 42 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1350, item.Image, 1350, 11, false);

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
            WriteLiteral(@"
                        <div class=""mask-icon"">
                            <ul>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                            </ul>
                            <a class=""cart"" href=""#"">Add to Cart</a>
                        </div>
                    </div>
                    <div class=""why-text"">
                        <h4>");
#nullable restore
#line 53 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h5> $");
#nullable restore
#line 54 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 58 "C:\Users\selim\Desktop\Programming\MyStore\MyShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
