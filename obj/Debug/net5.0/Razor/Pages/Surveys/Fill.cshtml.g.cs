#pragma checksum "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96509ca2c23a5f66671abb1017d31fd06a2707ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Surveys_Fill), @"mvc.1.0.razor-page", @"/Pages/Surveys/Fill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96509ca2c23a5f66671abb1017d31fd06a2707ed", @"/Pages/Surveys/Fill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6c503df0691bd6d471b581a26b3350727beeb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Surveys_Fill : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
Write(Model.SurveyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96509ca2c23a5f66671abb1017d31fd06a2707ed5535", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96509ca2c23a5f66671abb1017d31fd06a2707ed5805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 9 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
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
#line 12 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
             if (Model.QuestionsToFill is not null)
            {

                for (int i = 0; i < Model.QuestionsToFill.Count; i++)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h5>");
#nullable restore
#line 18 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                   Write(Model.QuestionsToFill[i].QuestionText);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 20 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                     for (int j = 0; j < Model.QuestionsToFill[i].Answers.Count; j++)
                    {


                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                         switch (Model.QuestionsToFill[i].Answers[j].AnswerTypeId)
                        {
                            //jednokrotny wybór w linii
                            case 1:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check form-check-inline\">\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"radio\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 1000, "\"", 1087, 1);
#nullable restore
#line 31 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 1051, Model.QuestionsToFill[i].QuestionId, 1051, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 1088, "\"", 1182, 1);
#nullable restore
#line 32 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 1137, Model.QuestionsToFill[i].Answers[j].AnswerId, 1137, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 1183, "\"", 1280, 1);
#nullable restore
#line 33 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 1235, Model.QuestionsToFill[i].Answers[j].AnswerId, 1235, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 1353, "\"", 1448, 1);
#nullable restore
#line 36 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 1403, Model.QuestionsToFill[i].Answers[j].AnswerId, 1403, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 37 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 41 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                break;
                            //Wielokrotny wybór w linii
                            case 2:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check form-check-inline\">\r\n\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"checkbox\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 1968, "\"", 2055, 1);
#nullable restore
#line 48 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 2019, Model.QuestionsToFill[i].QuestionId, 2019, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 2056, "\"", 2150, 1);
#nullable restore
#line 49 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 2105, Model.QuestionsToFill[i].Answers[j].AnswerId, 2105, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 2151, "\"", 2248, 1);
#nullable restore
#line 50 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 2203, Model.QuestionsToFill[i].Answers[j].AnswerId, 2203, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 2323, "\"", 2418, 1);
#nullable restore
#line 54 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 2373, Model.QuestionsToFill[i].Answers[j].AnswerId, 2373, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 55 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 58 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                break;
                            case 3:


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row g-2 align-items-center\">\r\n                                    <div class=\"col-auto\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 2856, "\"", 2907, 1);
#nullable restore
#line 63 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 2862, Model.QuestionsToFill[i].Answers[j].AnswerId, 2862, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"col-form-label\">\r\n                                            ");
#nullable restore
#line 64 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                       Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                    <div class=\"col-12\">\r\n                                        ");
#nullable restore
#line 68 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
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
#line 78 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"

                                break;
                            //jednokrotny wybór
                            case 4:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check\">\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"radio\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 4139, "\"", 4226, 1);
#nullable restore
#line 85 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 4190, Model.QuestionsToFill[i].QuestionId, 4190, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 4227, "\"", 4321, 1);
#nullable restore
#line 86 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 4276, Model.QuestionsToFill[i].Answers[j].AnswerId, 4276, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 4322, "\"", 4419, 1);
#nullable restore
#line 87 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 4374, Model.QuestionsToFill[i].Answers[j].AnswerId, 4374, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 4492, "\"", 4587, 1);
#nullable restore
#line 90 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 4542, Model.QuestionsToFill[i].Answers[j].AnswerId, 4542, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 91 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 94 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                break;
                            //Wielokrotny wybór
                            case 20:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check\">\r\n                                    <input class=\"form-check-input\"\r\n                                           type=\"checkbox\"");
                BeginWriteAttribute("name", "\r\n                                           name=\"", 5078, "\"", 5165, 1);
#nullable restore
#line 100 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 5129, Model.QuestionsToFill[i].QuestionId, 5129, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                           id=\"", 5166, "\"", 5260, 1);
#nullable restore
#line 101 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 5215, Model.QuestionsToFill[i].Answers[j].AnswerId, 5215, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                           value=\"", 5261, "\"", 5358, 1);
#nullable restore
#line 102 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 5313, Model.QuestionsToFill[i].Answers[j].AnswerId, 5313, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", "\r\n                                           for=\"", 5429, "\"", 5524, 1);
#nullable restore
#line 104 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 5479, Model.QuestionsToFill[i].Answers[j].AnswerId, 5479, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
#nullable restore
#line 105 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                   Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 108 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                break;
                            case 21:


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row g-3 align-items-center\">\r\n                                    <div class=\"col-auto\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 5963, "\"", 6014, 1);
#nullable restore
#line 113 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 5969, Model.QuestionsToFill[i].Answers[j].AnswerId, 5969, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"col-form-label\">\r\n                                            ");
#nullable restore
#line 114 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                       Write(Model.QuestionsToFill[i].Answers[j].AnswerText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                    <div class=\"col-auto\">\r\n                                        ");
#nullable restore
#line 118 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
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
                BeginWriteAttribute("id", " id=\"", 6947, "\"", 6997, 1);
#nullable restore
#line 128 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
WriteAttributeValue("", 6952, Model.QuestionsToFill[i].Answers[j].AnswerId, 6952, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-text\">\r\n                                            ");
#nullable restore
#line 129 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                       Write(Model.QuestionsToFill[i].Answers[j].DefaultText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </span>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 133 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"

                                break;
                            default:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <strong>\r\n                                    !\r\n                                    ");
#nullable restore
#line 138 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                               Write(Model.QuestionsToFill[i].Answers[j].AnswerTypeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    !\r\n                                </strong>\r\n");
#nullable restore
#line 141 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                         


                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
                     
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96509ca2c23a5f66671abb1017d31fd06a2707ed30015", async() => {
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
#line 161 "C:\Users\Radek\Desktop\inzynierka\dyplomowanie_inżynierka\Radoslaw Mikoś - Praca inżynierska\SurveyUP\Pages\Surveys\Fill.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyUP.Pages.Surveys.FillModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurveyUP.Pages.Surveys.FillModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurveyUP.Pages.Surveys.FillModel>)PageContext?.ViewData;
        public SurveyUP.Pages.Surveys.FillModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
