#pragma checksum "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3652b9c4e9cae92d27e89ff0b3b4d84908151bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Public_Fill), @"mvc.1.0.razor-page", @"/Pages/Public/Fill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3652b9c4e9cae92d27e89ff0b3b4d84908151bf", @"/Pages/Public/Fill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6c503df0691bd6d471b581a26b3350727beeb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Public_Fill : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 4 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
Write(Model.SurveyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3652b9c4e9cae92d27e89ff0b3b4d84908151bf5529", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3652b9c4e9cae92d27e89ff0b3b4d84908151bf5799", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 9 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
             if (Model.QuestionsToFill is not null)
            {

                for (int i = 0; i < Model.QuestionsToFill.Count; i++)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h5>");
#nullable restore
#line 18 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                   Write(Model.QuestionsToFill[i].QuestionText);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 20 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                     for (int j = 0; j < Model.QuestionsToFill[i].Answers.Count; j++)
                    {


                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                         switch (Model.QuestionsToFill[i].Answers[j].AnswerTypeId)
                        {
                            //jednokrotny wybór w linii
                            case 1:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check form-check-inline\">\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"radio\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 999, "\"", 1086, 1);
#nullable restore
#line 31 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 1050, Model.QuestionsToFill[i].QuestionId, 1050, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 1087, "\"", 1181, 1);
#nullable restore
#line 32 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 1136, Model.QuestionsToFill[i].Answers[j].AnswerId, 1136, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 1182, "\"", 1279, 1);
#nullable restore
#line 33 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 1234, Model.QuestionsToFill[i].Answers[j].AnswerId, 1234, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 1352, "\"", 1447, 1);
#nullable restore
#line 36 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 1402, Model.QuestionsToFill[i].Answers[j].AnswerId, 1402, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 37 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 41 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                break;
                            //Wielokrotny wybór w linii
                            case 2:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check form-check-inline\">\r\n\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"checkbox\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 1967, "\"", 2054, 1);
#nullable restore
#line 48 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 2018, Model.QuestionsToFill[i].QuestionId, 2018, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 2055, "\"", 2149, 1);
#nullable restore
#line 49 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 2104, Model.QuestionsToFill[i].Answers[j].AnswerId, 2104, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 2150, "\"", 2247, 1);
#nullable restore
#line 50 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 2202, Model.QuestionsToFill[i].Answers[j].AnswerId, 2202, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 2322, "\"", 2417, 1);
#nullable restore
#line 54 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 2372, Model.QuestionsToFill[i].Answers[j].AnswerId, 2372, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 55 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 58 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                break;
                            case 3:


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row g-2 align-items-center\">\r\n                                    <div class=\"col-auto\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 2855, "\"", 2906, 1);
#nullable restore
#line 63 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 2861, Model.QuestionsToFill[i].Answers[j].AnswerId, 2861, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"col-form-label\">\r\n                                            ");
#nullable restore
#line 64 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                       Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                    <div class=\"col-12\">\r\n                                        ");
#nullable restore
#line 68 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                   Write(Html.TextBox(
                                            @Model.QuestionsToFill[i].Answers[j].AnswerId.ToString(),
                                            string.Empty,
                                            new
                                                 {
                                                    @class = "form-control",
                                                    placeholder = @Model.QuestionsToFill[i].Answers[j].DefaultText
                                                 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 78 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"

                                break;
                            //jednokrotny wybór
                            case 4:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check\">\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"radio\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 4138, "\"", 4225, 1);
#nullable restore
#line 85 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 4189, Model.QuestionsToFill[i].QuestionId, 4189, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 4226, "\"", 4320, 1);
#nullable restore
#line 86 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 4275, Model.QuestionsToFill[i].Answers[j].AnswerId, 4275, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 4321, "\"", 4418, 1);
#nullable restore
#line 87 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 4373, Model.QuestionsToFill[i].Answers[j].AnswerId, 4373, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 4491, "\"", 4586, 1);
#nullable restore
#line 90 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 4541, Model.QuestionsToFill[i].Answers[j].AnswerId, 4541, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 91 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 94 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                break;
                            //Wielokrotny wybór
                            case 20:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check\">\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"checkbox\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 5077, "\"", 5164, 1);
#nullable restore
#line 100 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 5128, Model.QuestionsToFill[i].QuestionId, 5128, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 5165, "\"", 5259, 1);
#nullable restore
#line 101 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 5214, Model.QuestionsToFill[i].Answers[j].AnswerId, 5214, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 5260, "\"", 5357, 1);
#nullable restore
#line 102 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 5312, Model.QuestionsToFill[i].Answers[j].AnswerId, 5312, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 5428, "\"", 5523, 1);
#nullable restore
#line 104 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 5478, Model.QuestionsToFill[i].Answers[j].AnswerId, 5478, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 105 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 108 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                break;
                            case 21:


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row g-3 align-items-center\">\r\n                                    <div class=\"col-auto\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 5962, "\"", 6013, 1);
#nullable restore
#line 113 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 5968, Model.QuestionsToFill[i].Answers[j].AnswerId, 5968, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"col-form-label\">\r\n                                            ");
#nullable restore
#line 114 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                       Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                    <div class=\"col-auto\">\r\n                                        ");
#nullable restore
#line 118 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                   Write(Html.TextBox(
                                            @Model.QuestionsToFill[i].Answers[j].AnswerId.ToString(),
                                            string.Empty,
                                            new
                                            {
                                                @class = "form-control",
                                                @type = "datetime-local"
                                            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-auto\">\r\n                                        <span");
                BeginWriteAttribute("id", " id=\"", 6946, "\"", 6996, 1);
#nullable restore
#line 128 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
WriteAttributeValue("", 6951, Model.QuestionsToFill[i].Answers[j].AnswerId, 6951, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-text\">\r\n                                            ");
#nullable restore
#line 129 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                       Write(Model.QuestionsToFill[i].Answers[j].DefaultText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </span>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 133 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"

                                break;
                            default:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <strong>\r\n                                    !\r\n                                    ");
#nullable restore
#line 138 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                               Write(Model.QuestionsToFill[i].Answers[j].AnswerTypeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    !\r\n                                </strong>\r\n");
#nullable restore
#line 141 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                         


                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
                     
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Wypełnij\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3652b9c4e9cae92d27e89ff0b3b4d84908151bf29965", async() => {
                WriteLiteral("Powrót do listy ankiet");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 161 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Public\Fill.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyUP.Pages.Public.FillModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurveyUP.Pages.Public.FillModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurveyUP.Pages.Public.FillModel>)PageContext?.ViewData;
        public SurveyUP.Pages.Public.FillModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591