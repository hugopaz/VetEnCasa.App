#pragma checksum "C:\Mascotas\VetEnCasa.App\VetEnCasa.App.Frontend\Pages\Clientes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4351b76b3a1c9accfd18486348dde286cb6ba9d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetEnCasa.App.Frontend.Pages.Clientes.Pages_Clientes_List), @"mvc.1.0.razor-page", @"/Pages/Clientes/List.cshtml")]
namespace VetEnCasa.App.Frontend.Pages.Clientes
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
#line 1 "C:\Mascotas\VetEnCasa.App\VetEnCasa.App.Frontend\Pages\_ViewImports.cshtml"
using VetEnCasa.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4351b76b3a1c9accfd18486348dde286cb6ba9d1", @"/Pages/Clientes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf2cd76e201a49df72e285ac49ac5c606d2f686", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de clientes</h1>\r\n<table class=\"table\">\r\n");
#nullable restore
#line 7 "C:\Mascotas\VetEnCasa.App\VetEnCasa.App.Frontend\Pages\Clientes\List.cshtml"
     foreach (var cliente in Model.Clientes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "C:\Mascotas\VetEnCasa.App\VetEnCasa.App.Frontend\Pages\Clientes\List.cshtml"
           Write(cliente.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Mascotas\VetEnCasa.App\VetEnCasa.App.Frontend\Pages\Clientes\List.cshtml"
           Write(cliente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Mascotas\VetEnCasa.App\VetEnCasa.App.Frontend\Pages\Clientes\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetEnCasa.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetEnCasa.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetEnCasa.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public VetEnCasa.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
