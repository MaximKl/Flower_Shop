#pragma checksum "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\Reg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c00cb41fa3b1b62cec4e7794d322fb29ef0c00e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Reg), @"mvc.1.0.view", @"/Views/Shared/Reg.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c00cb41fa3b1b62cec4e7794d322fb29ef0c00e", @"/Views/Shared/Reg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6645ad704d7dc7f9358b9acb79fa57d91941b8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Reg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\Reg.cshtml"
     if (Shopp.Data.Models.User.getRMail() != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\" style=\"margin-left:700px;\">\r\n        <a class=\"nav-link\" href=\"/Registration/Info\">");
#nullable restore
#line 4 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\Reg.cshtml"
                                                        string st=Shopp.Data.Models.User.getRMail();

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\Reg.cshtml"
                                                                                                 Write(st);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n        </li>\r\n");
#nullable restore
#line 6 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\Reg.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""nav-item"" style=""margin-left:800px;"">
            <a class=""nav-link"" href=""/Registration/User"">Реєстрація</a>
        </li>
        <li class=""nav-item"" style=""margin-left:50px;"">
            <a class=""nav-link"" href=""/Registration/Sign"">Увійти</a>
        </li>
");
#nullable restore
#line 15 "C:\Users\rkbij\OneDrive\Рабочий стол\универ\семестр 6\ASP.net\Shopp\Shopp\Views\Shared\Reg.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
