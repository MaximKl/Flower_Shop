#pragma checksum "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23f96ee32728ddcd875594ea8373928358ae1fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllFlowers), @"mvc.1.0.view", @"/Views/Shared/AllFlowers.cshtml")]
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
#line 1 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\_ViewImports.cshtml"
using Shopp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\_ViewImports.cshtml"
using Shopp.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23f96ee32728ddcd875594ea8373928358ae1fc", @"/Views/Shared/AllFlowers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6645ad704d7dc7f9358b9acb79fa57d91941b8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_AllFlowers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flower>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"col-lg-4\">\r\n        <h2>Вид: ");
#nullable restore
#line 4 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
            Write(Model.Category.categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n        <div style=\"block-size:370px;\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 157, "\"", 173, 1);
#nullable restore
#line 6 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
WriteAttributeValue("", 163, Model.img, 163, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 174, "\"", 191, 1);
#nullable restore
#line 6 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
WriteAttributeValue("", 180, Model.name, 180, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"min-width:300px; max-width:320px;height:350px;\" />\r\n        </div>\r\n        <h2>Назва: ");
#nullable restore
#line 8 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
              Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>Опис: ");
#nullable restore
#line 9 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
            Write(Model.shortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p>Ціна: ");
#nullable restore
#line 10 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
            Write(Model.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23f96ee32728ddcd875594ea8373928358ae1fc6221", async() => {
                WriteLiteral("Додати до корзини");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\AllFlowers.cshtml"
                                                                                         WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flower> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
