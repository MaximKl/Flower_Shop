#pragma checksum "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Flowers\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef9dd6ee0d4926445db5698f17d190d0b67df75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flowers_List), @"mvc.1.0.view", @"/Views/Flowers/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef9dd6ee0d4926445db5698f17d190d0b67df75", @"/Views/Flowers/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6645ad704d7dc7f9358b9acb79fa57d91941b8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Flowers_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowersListViewModels>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"margin-top:70px\">\r\n    <h1>Всі квіти</h1>\r\n    <div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 5 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Flowers\List.cshtml"
          
            foreach(Flower fl in Model.allFlowers)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Flowers\List.cshtml"
       Write(Html.Partial("AllFlowers",fl));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Flowers\List.cshtml"
                                          ;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowersListViewModels> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
