#pragma checksum "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b4e5cc8f586292478b056052d73cb475a2ede46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4e5cc8f586292478b056052d73cb475a2ede46", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b2a76cd535503f37d1c0b657b47c7bba8f9ecd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d036b2e7e40642efa12ea38b46d09943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(85, 267, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"" type=""text/javascript""></script>


<h1>Bem vindo ao DashBoard de processos decisórios</h1>

<!--http://www.macoratti.net/17/11/mvc_chartjs1.htm-->
<h2>Gráfico com Chart.js</h2>

");
            EndContext();
#line 14 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", null, FormMethod.Post))
{

#line default
#line hidden
            BeginContext(420, 1059, true);
            WriteLiteral(@"    <div Style=""font-family: Corbel; font-size: small ;text-align:center "" class=""row"">
        <div>
            <h2>Sujestão de vendas deste mês</h2>
            <h3 id=""Aguarde"">Aguarde carregando dados para o gráfico...</h3>
            <div style=""width:100%;height:100%"">
                <canvas id=""mChart1"" style=""padding: 0;margin: auto;display: block; ""> </canvas>
            </div>
            <div style=""width:100%;height:100%"">
                <h2>Sujestão de promoções para este mês</h2>
                <h3 id=""Aguarde2"">Aguarde carregando dados para o gráfico...</h3>
                <canvas id=""mChart2"" style=""padding: 0;margin: auto;display: block; ""> </canvas>
            </div>
            <div style=""width:100%;height:100%"">
                <h2>Produtos com maior crescimento de venda</h2>
                <h3 id=""Aguarde3"">Aguarde carregando dados para o gráfico...</h3>
                <canvas id=""mChart3"" style=""padding: 0;margin: auto;display: block; ""> </canvas>
            <");
            WriteLiteral("/div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1481, 6772, true);
            WriteLiteral(@"    <script>
        $.ajax({
            type: ""POST"",
            url: ""/Home/NovoGrafico"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (mems) {
                var aData = mems;
                var aLabels = aData[0];
                var aDataQuantidade= aData[1];
                var TotalQuantidade = {
                    labels: aLabels,
                    datasets: [{
                        label: ""Quantidade vendida"",
                        data: aDataQuantidade,
                        fill: false,
                        backgroundColor: [""rgba(54, 162, 235, 0.2)"", ""rgba(255, 99, 132, 0.2)"", ""rgba(255, 159, 64, 0.2)"",
                            ""rgba(255, 205, 86, 0.2)"", ""rgba(75, 192, 192, 0.2)"", ""rgba(153, 102, 255, 0.2)"", ""rgba(201, 203, 207, 0.2)""],
                        borderColor: [""rgb(54, 162, 235)"", ""rgb(255, 99, 132)"", ""rgb(255, 159, 64)"", ""rgb(255, 205, 86)"",
                            ""r");
            WriteLiteral(@"gb(75, 192, 192)"", ""rgb(153, 102, 255)"", ""rgb(201, 203, 207)""],
                        borderWidth: 5
                    }]
                };

                var ctx2 = document.getElementById('mChart1').getContext('2d');
                document.getElementById('Aguarde').hidden = true;
                var myNewChart = new Chart(ctx2, {
                    type: 'bar',
                    data: TotalQuantidade,
                    options: {
                        responsive: true,
                        title: { display: true, text: 'Previsao de venda desse mes baseando-se nas vendas dos ultimos 3 anos' },
                        legend: { position: 'bottom' },
                        scales: {
                            xAxes: [{ gridLines: { display: false }, display: true, scaleLabel: { display: false, labelString: '' } }],
                            yAxes: [{
                                gridLines: { display: false }, display: true, scaleLabel: { display: false, labelString: '");
            WriteLiteral(@"' },
                                ticks: { stepSize: 50, beginAtZero: true }
                            }]
                        },
                    }
                });
            }
        });

        $.ajax({
            type: ""POST"",
            url: ""/Home/GruposMenosVendidos"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (mems) {
                var aData = mems;
                var aLabels = aData[0];
                var aDataQuantidade = aData[1];
                var TotalQuantidade = {
                    labels: aLabels,
                    datasets: [{
                        label: ""Quantidade vendida"",
                        data: aDataQuantidade,
                        fill: false,
                        backgroundColor: [""rgba(54, 162, 235, 0.2)"", ""rgba(255, 99, 132, 0.2)"", ""rgba(255, 159, 64, 0.2)"",
                            ""rgba(255, 205, 86, 0.2)"", ""rgba(75, 192, 192, 0.2)"", ");
            WriteLiteral(@"""rgba(153, 102, 255, 0.2)"", ""rgba(201, 203, 207, 0.2)""],
                        borderColor: [""rgb(54, 162, 235)"", ""rgb(255, 99, 132)"", ""rgb(255, 159, 64)"", ""rgb(255, 205, 86)"",
                            ""rgb(75, 192, 192)"", ""rgb(153, 102, 255)"", ""rgb(201, 203, 207)""],
                        borderWidth: 5
                    }]
                };

                var ctx = document.getElementById('mChart2').getContext('2d');
                document.getElementById('Aguarde2').hidden = true;
                var myNewChart = new Chart(ctx, {
                    type: 'bar',
                    data: TotalQuantidade,
                    options: {
                        responsive: true,
                        title: { display: true, text: 'Grupos menos vendidos neste mes baseado nos ultimos 3 anos' },
                        legend: { position: 'bottom' },
                        scales: {
                            xAxes: [{ gridLines: { display: false }, display: true, scaleLabel: { d");
            WriteLiteral(@"isplay: false, labelString: '' } }],
                            yAxes: [{
                                gridLines: { display: false }, display: true, scaleLabel: { display: false, labelString: '' },
                                ticks: { stepSize: 50, beginAtZero: true }
                            }]
                        },
                    }
                });
            }
        });

        $.ajax({
            type: ""POST"",
            url: ""/Home/CrescimentoDeVendas"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (mems) {
                var aData = mems;
                var aLabels = aData[0];
                var aDataQuantidade = aData[1];
                var TotalQuantidade = {
                    labels: aLabels,
                    datasets: [{
                        label: ""Percentual de crescimento"",
                        data: aDataQuantidade,
                        fill: false,
");
            WriteLiteral(@"                        backgroundColor: [""rgba(54, 162, 235, 0.2)"", ""rgba(255, 99, 132, 0.2)"", ""rgba(255, 159, 64, 0.2)"",
                            ""rgba(255, 205, 86, 0.2)"", ""rgba(75, 192, 192, 0.2)"", ""rgba(153, 102, 255, 0.2)"", ""rgba(201, 203, 207, 0.2)""],
                        borderColor: [""rgb(54, 162, 235)"", ""rgb(255, 99, 132)"", ""rgb(255, 159, 64)"", ""rgb(255, 205, 86)"",
                            ""rgb(75, 192, 192)"", ""rgb(153, 102, 255)"", ""rgb(201, 203, 207)""],
                        borderWidth: 5
                    }]
                };

                var ctx = document.getElementById('mChart3').getContext('2d');
                document.getElementById('Aguarde3').hidden = true;
                var myNewChart = new Chart(ctx, {
                    type: 'bar',
                    data: TotalQuantidade,
                    options: {
                        responsive: true,
                        title: { display: true, text: 'Produtos com maior crescimento em vendas por peri");
            WriteLiteral(@"odo' },
                        legend: { position: 'bottom' },
                        scales: {
                            xAxes: [{ gridLines: { display: false }, display: true, scaleLabel: { display: false, labelString: '' } }],
                            yAxes: [{
                                gridLines: { display: false }, display: true, scaleLabel: { display: false, labelString: '' },
                                ticks: { stepSize: 50, beginAtZero: true }
                            }]
                        },
                    }
                });
            }
        });
    </script>
");
            EndContext();
#line 169 "C:\Fontes\CSharp\ProcessoDecisorio\CrudCharts\CrudCharts\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
