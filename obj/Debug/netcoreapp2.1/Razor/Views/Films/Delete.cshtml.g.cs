#pragma checksum "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f231f11beb645dfcdb4d0e29c82f95a68fc17a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Delete), @"mvc.1.0.view", @"/Views/Films/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Delete.cshtml", typeof(AspNetCore.Views_Films_Delete))]
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
#line 1 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\_ViewImports.cshtml"
using Sakila;

#line default
#line hidden
#line 2 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\_ViewImports.cshtml"
using Sakila.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f231f11beb645dfcdb4d0e29c82f95a68fc17a70", @"/Views/Films/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454714200a5356a788c1d7220ef9f802b990cfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sakila.Models.Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(118, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Film</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(284, 41, false);
#line 16 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(369, 37, false);
#line 19 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(406, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(450, 47, false);
#line 22 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(497, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(541, 43, false);
#line 25 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(584, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(628, 47, false);
#line 28 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(675, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(719, 43, false);
#line 31 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(762, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(806, 50, false);
#line 34 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentalDuration));

#line default
#line hidden
            EndContext();
            BeginContext(856, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(900, 46, false);
#line 37 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentalDuration));

#line default
#line hidden
            EndContext();
            BeginContext(946, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(990, 46, false);
#line 40 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentalRate));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1080, 42, false);
#line 43 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentalRate));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1166, 42, false);
#line 46 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1252, 38, false);
#line 49 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1334, 51, false);
#line 52 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReplacementCost));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1429, 47, false);
#line 55 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReplacementCost));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1520, 42, false);
#line 58 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1606, 38, false);
#line 61 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1688, 51, false);
#line 64 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialFeatures));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1783, 47, false);
#line 67 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpecialFeatures));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1874, 46, false);
#line 70 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdate));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1964, 42, false);
#line 73 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastUpdate));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2050, 44, false);
#line 76 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2138, 45, false);
#line 79 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Language.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2227, 52, false);
#line 82 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OriginalLanguage));

#line default
#line hidden
            EndContext();
            BeginContext(2279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2323, 53, false);
#line 85 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OriginalLanguage.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2414, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29d24e4f827842399b3927a67fbce5d0", async() => {
                BeginContext(2440, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2450, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eea76afc94e4070a1dece4db07d9d6f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "E:\APP_Class\Course_5_ASP.Net\Lesson_3\Programs\Sakila\Views\Films\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilmId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2490, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2574, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51034a30ff8642de97d5fbb4d18b55ae", async() => {
                    BeginContext(2596, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2612, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2625, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sakila.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
