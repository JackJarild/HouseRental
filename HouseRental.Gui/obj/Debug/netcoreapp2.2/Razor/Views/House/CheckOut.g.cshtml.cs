#pragma checksum "C:\Users\jack.jarild\Desktop\HouseRental\HouseRental.Gui\Views\House\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b279bb7f672963022ff94b1cb04dbb07fe93faa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_House_CheckOut), @"mvc.1.0.view", @"/Views/House/CheckOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/House/CheckOut.cshtml", typeof(AspNetCore.Views_House_CheckOut))]
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
#line 1 "C:\Users\jack.jarild\Desktop\HouseRental\HouseRental.Gui\Views\_ViewImports.cshtml"
using HouseRental.Gui;

#line default
#line hidden
#line 2 "C:\Users\jack.jarild\Desktop\HouseRental\HouseRental.Gui\Views\_ViewImports.cshtml"
using HouseRental.Gui.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b279bb7f672963022ff94b1cb04dbb07fe93faa2", @"/Views/House/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1568d0cf9ef81c10b68b13bc601f00cc7325b15", @"/Views/_ViewImports.cshtml")]
    public class Views_House_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HouseRental.Common.ReservationResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jack.jarild\Desktop\HouseRental\HouseRental.Gui\Views\House\CheckOut.cshtml"
  
    ViewData["Title"] = "CheckOut";

#line default
#line hidden
            BeginContext(91, 49, true);
            WriteLiteral("\r\n<h1>CheckOut</h1>\r\n\r\n\r\n<h1>Reservation number: ");
            EndContext();
            BeginContext(141, 23, false);
#line 9 "C:\Users\jack.jarild\Desktop\HouseRental\HouseRental.Gui\Views\House\CheckOut.cshtml"
                   Write(Model.ReservationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(164, 18, true);
            WriteLiteral("</h1>\r\n<h2>Price: ");
            EndContext();
            BeginContext(183, 11, false);
#line 10 "C:\Users\jack.jarild\Desktop\HouseRental\HouseRental.Gui\Views\House\CheckOut.cshtml"
      Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(194, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HouseRental.Common.ReservationResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591