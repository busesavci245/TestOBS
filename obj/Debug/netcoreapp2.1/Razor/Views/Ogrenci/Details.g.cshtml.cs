#pragma checksum "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0353173f2d3efaaeddf55135c75c3c893fd177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Details), @"mvc.1.0.view", @"/Views/Ogrenci/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ogrenci/Details.cshtml", typeof(AspNetCore.Views_Ogrenci_Details))]
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
#line 1 "C:\Users\buses\Projeler .Net\1.3\Views\_ViewImports.cshtml"
using _1._3;

#line default
#line hidden
#line 2 "C:\Users\buses\Projeler .Net\1.3\Views\_ViewImports.cshtml"
using _1._3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0353173f2d3efaaeddf55135c75c3c893fd177", @"/Views/Ogrenci/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6863938f2982be4071ab54e75d3f2f48c78638a", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_1._3.Models.Ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 3, true);
            WriteLiteral("  \n");
            EndContext();
#line 3 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
      
    ViewData["Title"] = "Detaylar";    

#line default
#line hidden
            BeginContext(85, 133, true);
            WriteLiteral("<h2>Details</h2>    \n<div>    \n    <h4>Detaylar</h4>    \n    <hr />    \n    <dl class=\"dl-horizontal\"> \n        <dt>    \n            ");
            EndContext();
            BeginContext(219, 46, false);
#line 12 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ogrenci_no));

#line default
#line hidden
            EndContext();
            BeginContext(265, 52, true);
            WriteLiteral("    \n        </dt>    \n        <dd>    \n            ");
            EndContext();
            BeginContext(318, 42, false);
#line 15 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayFor(model => model.ogrenci_no));

#line default
#line hidden
            EndContext();
            BeginContext(360, 52, true);
            WriteLiteral("    \n        </dd>    \n        <dt>    \n            ");
            EndContext();
            BeginContext(413, 46, false);
#line 18 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ogrenci_ad));

#line default
#line hidden
            EndContext();
            BeginContext(459, 52, true);
            WriteLiteral("    \n        </dt>    \n        <dd>    \n            ");
            EndContext();
            BeginContext(512, 42, false);
#line 21 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayFor(model => model.ogrenci_ad));

#line default
#line hidden
            EndContext();
            BeginContext(554, 49, true);
            WriteLiteral("    \n        </dd> \n        <dt>    \n            ");
            EndContext();
            BeginContext(604, 49, false);
#line 24 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ogrenci_soyad));

#line default
#line hidden
            EndContext();
            BeginContext(653, 52, true);
            WriteLiteral("    \n        </dt>    \n        <dd>    \n            ");
            EndContext();
            BeginContext(706, 45, false);
#line 27 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayFor(model => model.ogrenci_soyad));

#line default
#line hidden
            EndContext();
            BeginContext(751, 52, true);
            WriteLiteral("    \n        </dd>    \n        <dt>    \n            ");
            EndContext();
            BeginContext(804, 49, false);
#line 30 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ogrenci_email));

#line default
#line hidden
            EndContext();
            BeginContext(853, 52, true);
            WriteLiteral("    \n        </dt>    \n        <dd>    \n            ");
            EndContext();
            BeginContext(906, 45, false);
#line 33 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayFor(model => model.ogrenci_email));

#line default
#line hidden
            EndContext();
            BeginContext(951, 52, true);
            WriteLiteral("    \n        </dd>    \n        <dt>    \n            ");
            EndContext();
            BeginContext(1004, 49, false);
#line 36 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ogrenci_sifre));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 52, true);
            WriteLiteral("    \n        </dt>    \n        <dd>    \n            ");
            EndContext();
            BeginContext(1106, 45, false);
#line 39 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
       Write(Html.DisplayFor(model => model.ogrenci_sifre));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 66, true);
            WriteLiteral("    \n        </dd>        \n    </dl>    \n</div>    \n<div>    \n    ");
            EndContext();
            BeginContext(1217, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f2b518884dd484bbb08d376b4976496", async() => {
                BeginContext(1271, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\buses\Projeler .Net\1.3\Views\Ogrenci\Details.cshtml"
                           WriteLiteral(Model.ogrenci_no);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1279, 11, true);
            WriteLiteral(" |    \n    ");
            EndContext();
            BeginContext(1290, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "251b638fda334e5aaa9dba399299ccb3", async() => {
                BeginContext(1312, 12, true);
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
            BeginContext(1328, 11, true);
            WriteLiteral("    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_1._3.Models.Ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
