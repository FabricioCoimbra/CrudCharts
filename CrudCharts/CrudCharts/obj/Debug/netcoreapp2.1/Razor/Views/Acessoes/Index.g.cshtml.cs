#pragma checksum "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbda1d24a8f7fb8161d3e2821da89d2c2678c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acessoes_Index), @"mvc.1.0.view", @"/Views/Acessoes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Acessoes/Index.cshtml", typeof(AspNetCore.Views_Acessoes_Index))]
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
#line 1 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\_ViewImports.cshtml"
using CrudCharts;

#line default
#line hidden
#line 2 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\_ViewImports.cshtml"
using CrudCharts.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cbda1d24a8f7fb8161d3e2821da89d2c2678c51", @"/Views/Acessoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b2a76cd535503f37d1c0b657b47c7bba8f9ecd", @"/Views/_ViewImports.cshtml")]
    public class Views_Acessoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudCharts.Models.Acesso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693e892705a54d7dbe6e6a06ab1803d1", async() => {
                BeginContext(141, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(155, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 41, false);
#line 16 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DtAtz));

#line default
#line hidden
            EndContext();
            BeginContext(289, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(407, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(456, 40, false);
#line 25 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DtAtz));

#line default
#line hidden
            EndContext();
            BeginContext(496, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(552, 65, false);
#line 28 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(617, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(638, 71, false);
#line 29 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(709, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(730, 69, false);
#line 30 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(799, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Acessoes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(838, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudCharts.Models.Acesso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
