#pragma checksum "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3703443a07b34e42b51ff238911ee9f888c64c7"
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
#line 1 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\_ViewImports.cshtml"
using PC3_Berrocal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\_ViewImports.cshtml"
using PC3_Berrocal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3703443a07b34e42b51ff238911ee9f888c64c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24231d75a777f0fa2b172c47cf119065be729f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <H1>Lista de productos</H1>\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
         foreach (var productos in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 278, "\"", 298, 1);
#nullable restore
#line 14 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
WriteAttributeValue("", 284, productos.Url, 284, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" width=\"150\"px height=\"150\"px>\r\n              <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
                                  Write(productos.Nombre_Producto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <label>Descripcion:");
#nullable restore
#line 18 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
                              Write(productos.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n                <label>Precio:");
#nullable restore
#line 19 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
                         Write(productos.Precio_Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n                <label>Celular:");
#nullable restore
#line 20 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
                          Write(productos.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n                <label>Lugar:");
#nullable restore
#line 21 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
                        Write(productos.Lugar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n                <label>Usuario:");
#nullable restore
#line 22 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"
                          Write(productos.Nombre_Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n              </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\aleon\Documents\2020 - II\Programacion Teoria\Practica03\PC3-Berrocal\Views\Home\Index.cshtml"

 


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591