#pragma checksum "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0805abcc07d5f47d68352943bc9c0ce14c3c052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recebedor_Details), @"mvc.1.0.view", @"/Views/Recebedor/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recebedor/Details.cshtml", typeof(AspNetCore.Views_Recebedor_Details))]
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
#line 1 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\_ViewImports.cshtml"
using GSEnterprise;

#line default
#line hidden
#line 2 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\_ViewImports.cshtml"
using GSEnterprise.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0805abcc07d5f47d68352943bc9c0ce14c3c052", @"/Views/Recebedor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a9b1f5c156c9956de6b6cfffc980096c2bc3f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Recebedor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GSEnterprise.Models.Entidades.Recebedor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Recebedor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(217, 38, false);
#line 14 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 34, false);
#line 17 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 47, false);
#line 20 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Instituicao));

#line default
#line hidden
            EndContext();
            BeginContext(424, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(468, 43, false);
#line 23 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Instituicao));

#line default
#line hidden
            EndContext();
            BeginContext(511, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(555, 40, false);
#line 26 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(639, 36, false);
#line 29 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(675, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(719, 41, false);
#line 32 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(804, 37, false);
#line 35 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(841, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(885, 44, false);
#line 38 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(973, 40, false);
#line 41 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1057, 44, false);
#line 44 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1145, 40, false);
#line 47 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1229, 42, false);
#line 50 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1315, 38, false);
#line 53 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1397, 42, false);
#line 56 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1483, 38, false);
#line 59 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1565, 42, false);
#line 62 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1651, 38, false);
#line 65 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1733, 42, false);
#line 68 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1819, 38, false);
#line 71 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1901, 39, false);
#line 74 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1984, 35, false);
#line 77 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2067, 68, false);
#line 82 "C:\Users\filli\source\repos\GSEnterprise\GSEnterprise\Views\Recebedor\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2143, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "518e987650a64b7ca7d20e41682474fe", async() => {
                BeginContext(2165, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2181, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSEnterprise.Models.Entidades.Recebedor> Html { get; private set; }
    }
}
#pragma warning restore 1591
