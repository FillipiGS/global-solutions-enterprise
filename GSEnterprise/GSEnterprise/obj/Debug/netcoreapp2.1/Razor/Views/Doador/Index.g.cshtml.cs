#pragma checksum "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becb47b9e10728d88355aa6f41071c8740a2b060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doador_Index), @"mvc.1.0.view", @"/Views/Doador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doador/Index.cshtml", typeof(AspNetCore.Views_Doador_Index))]
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
#line 1 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\_ViewImports.cshtml"
using GSEnterprise;

#line default
#line hidden
#line 2 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\_ViewImports.cshtml"
using GSEnterprise.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"becb47b9e10728d88355aa6f41071c8740a2b060", @"/Views/Doador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a9b1f5c156c9956de6b6cfffc980096c2bc3f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Doador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GSEnterprise.Models.Entidades.Doador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Perfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mt-2 mt-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 23, true);
            WriteLiteral("\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(124, 694, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59e60c1efd524e73bb931d71f1a672a6", async() => {
                BeginContext(130, 681, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <link rel=""stylesheet"" href=""../../../static/css/style.css"">
    <link rel=""icon"" href=""../../../static/img/favicon.ico"" type=""image/x-icon"">

    <title>Home</title>

    <!-- Principal CSS do Bootstrap -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">

    <meta id=""webpki_lacunasoftware_com"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(818, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(820, 7166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b1f4aade7d4af1b5d4f30d990e332b", async() => {
                BeginContext(826, 760, true);
                WriteLiteral(@"

    <header>
        <nav class=""navbar navbar-expand-md navbar-dark fixed-top bg-dark"">
            <a class=""navbar-brand"" href=""#"">FHG Tech</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        ");
                EndContext();
                BeginContext(1586, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7a8f4e49e94dc598d384de340e684c", async() => {
                    BeginContext(1658, 8, true);
                    WriteLiteral("Cadastro");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1670, 96, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(1766, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e471601b8545a48e1c056a62f42d2e", async() => {
                    BeginContext(1836, 42, true);
                    WriteLiteral("Perfil<span class=\"sr-only\">(atual)</span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1882, 96, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(1978, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40ab01874d24e16bd5f5b8ece84209c", async() => {
                    BeginContext(2047, 5, true);
                    WriteLiteral("Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2056, 68, true);
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n                ");
                EndContext();
                BeginContext(2124, 282, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c865f3714984efab9a64a397efaa0ba", async() => {
                    BeginContext(2163, 236, true);
                    WriteLiteral("\r\n                    <input class=\"form-control mr-sm-2\" type=\"text\" placeholder=\"Buscar\" aria-label=\"Search\">\r\n                    <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Pesquisar</button>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2406, 350, true);
                WriteLiteral(@"
            </div>
        </nav>
    </header>

    <main role=""main"" style=""margin-top: 100px;"">

            <h4 class=""font-weight-bold py-3 mb-4"">
                PERFIL
            </h4>

            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            ");
                EndContext();
                BeginContext(2757, 38, false);
#line 64 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(2795, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(2887, 40, false);
#line 67 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2927, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3019, 45, false);
#line 70 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
                EndContext();
                BeginContext(3064, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3156, 41, false);
#line 73 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(3197, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3289, 44, false);
#line 76 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
                EndContext();
                BeginContext(3333, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3425, 44, false);
#line 79 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
                EndContext();
                BeginContext(3469, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3561, 42, false);
#line 82 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
                EndContext();
                BeginContext(3603, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3695, 42, false);
#line 85 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
                EndContext();
                BeginContext(3737, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3829, 42, false);
#line 88 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
                EndContext();
                BeginContext(3871, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(3963, 42, false);
#line 91 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(4005, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(4097, 39, false);
#line 94 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
                EndContext();
                BeginContext(4136, 146, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 100 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(4355, 96, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4452, 37, false);
#line 104 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(4489, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4593, 39, false);
#line 107 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(4632, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4736, 44, false);
#line 110 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Documento));

#line default
#line hidden
                EndContext();
                BeginContext(4780, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4884, 40, false);
#line 113 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(4924, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5028, 43, false);
#line 116 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
                EndContext();
                BeginContext(5071, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5175, 43, false);
#line 119 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
                EndContext();
                BeginContext(5218, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5322, 41, false);
#line 122 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
                EndContext();
                BeginContext(5363, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5467, 41, false);
#line 125 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
                EndContext();
                BeginContext(5508, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5612, 41, false);
#line 128 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
                EndContext();
                BeginContext(5653, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5757, 41, false);
#line 131 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(5798, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(5902, 38, false);
#line 134 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cep));

#line default
#line hidden
                EndContext();
                BeginContext(5940, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(6044, 78, false);
#line 137 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(6122, 36, true);
                WriteLiteral(" |\r\n                                ");
                EndContext();
                BeginContext(6159, 84, false);
#line 138 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(6243, 36, true);
                WriteLiteral(" |\r\n                                ");
                EndContext();
                BeginContext(6280, 82, false);
#line 139 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(6362, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 142 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(6453, 1526, true);
                WriteLiteral(@"                </tbody>
            </table>

</main>

    <!-- Principal JavaScript do Bootstrap
    ================================================== -->
    <!-- Foi colocado no final para a página carregar mais rápido -->

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
    <script>window.jQuery || document.write('<script src=""../../assets/js/vendor/jquery-slim.min.js""><\/script>')</script>

    <!-- Só faz o nossos placeholders de imagens funcio");
                WriteLiteral(@"narem. Não precisar copiar a próxima linha! -->
    <script src=""../../assets/js/vendor/holder.min.js""></script>


    <svg xmlns=""http://www.w3.org/2000/svg"" width=""500"" height=""500"" viewBox=""0 0 500 500"" preserveAspectRatio=""none"" style=""display: none; visibility: hidden; position: absolute; top: -100%; left: -100%;""><defs><style type=""text/css""></style></defs><text x=""0"" y=""25"" style=""font-weight:bold;font-size:25pt;font-family:Arial, Helvetica, Open Sans, sans-serif"">500x500</text></svg>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7986, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GSEnterprise.Models.Entidades.Doador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
