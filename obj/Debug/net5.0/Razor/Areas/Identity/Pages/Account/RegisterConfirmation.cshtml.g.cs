#pragma checksum "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809336e6491f500fdde08cc7486cd8ac2119e281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\_ViewImports.cshtml"
using SurveyUP.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\_ViewImports.cshtml"
using SurveyUP.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SurveyUP.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809336e6491f500fdde08cc7486cd8ac2119e281", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2770de93fa521abf2a13b9b42797c8b58772026", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f87f034cc1248bc92f43a41c376b12c0bc92e0a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Dziękujemy za rejestrację";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Na Twoją skrzynkę email wysłaliśmy link aktywacyjny. Kliknij Potwierdzenie, aby móc korzystać z dostępnych funkcji serwisu.\r\n");
            WriteLiteral("    </p>\r\n");
#nullable restore
#line 16 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n        Sprawdź pocztę, aby potwierdzić swoje konto.\r\n</p>\r\n");
#nullable restore
#line 22 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
