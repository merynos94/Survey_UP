#pragma checksum "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00273399deb38b63a617eee241f598b049be3aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Voters_Details), @"mvc.1.0.razor-page", @"/Pages/Voters/Details.cshtml")]
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
#line 1 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\_ViewImports.cshtml"
using SurveyUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\_ViewImports.cshtml"
using SurveyUP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\_ViewImports.cshtml"
using SurveyUP.Models.Tables;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00273399deb38b63a617eee241f598b049be3aae", @"/Pages/Voters/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6c503df0691bd6d471b581a26b3350727beeb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Voters_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 10 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.AllAnswers[0].VoterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.AllAnswers[0].AnswerText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.AllAnswers[0].Answers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
             foreach (var item in Model.AllAnswers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.VoterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.AnswerText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <table class=\"table\">\r\n                        <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
                             foreach(var answer in item.Answers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 38 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
                                   Write(Model.GetAnswer(answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Voters\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00273399deb38b63a617eee241f598b049be3aae8264", async() => {
                WriteLiteral("Powrót do listy głosujących");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyUP.Pages.Voters.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurveyUP.Pages.Voters.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurveyUP.Pages.Voters.DetailsModel>)PageContext?.ViewData;
        public SurveyUP.Pages.Voters.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591