#pragma checksum "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f438cb1128079d7577821103c4d196844bc37125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doador_Details), @"mvc.1.0.view", @"/Views/Doador/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doador/Details.cshtml", typeof(AspNetCore.Views_Doador_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f438cb1128079d7577821103c4d196844bc37125", @"/Views/Doador/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a9b1f5c156c9956de6b6cfffc980096c2bc3f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Doador_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GSEnterprise.Models.Entidades.Doador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 4826, true);
            WriteLiteral(@"
<h2>PERFIL</h2>

<div class=""card overflow-hidden"">
    <div class=""row no-gutters row-bordered row-border-light"">
        <div class=""col-md-3 pt-0"">
            <div class=""list-group list-group-flush account-settings-links"">
                <a class=""list-group-item list-group-item-action active"" data-toggle=""list"" href=""#account-general"">Geral</a>
                <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""account-visualizar-solicitacoes"">Visualizar solicitações</a>
                <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#account-change-password"">Mudar senha</a>
                <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#account-info"">Informações do Perfil</a>
                <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#account-social-links"">Redes Sociais</a>
                <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#account-connecti");
            WriteLiteral(@"ons"">Conexões</a>
                <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#account-notifications"">Notificações</a>
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""tab-content"">
                <div class=""tab-pane fade active show"" id=""account-general"">

                    <div class=""card-body media align-items-center"">
                        <img src=""https://bootdey.com/img/Content/avatar/avatar1.png"" style=""width: 200px; height: 200px"" alt="""" class=""d-block ui-w-80"">
                        <div class=""media-body ml-4"">
                            <label class=""btn btn-outline-primary"">
                                Upload nova foto
                                <input type=""file"" class=""account-settings-fileinput"">
                            </label>
                            <button type=""button"" class=""btn btn-default md-btn-flat"">Reset</button>

                            <div class=""text-light small");
            WriteLiteral(@" mt-1"">Somente arquivos JPG, GIF ou PNG. Tamanho máximo de 800Kb</div>
                        </div>
                    </div>

                </div>
                <div class=""tab-pane fade"" id=""account-visualizar-solicitacoes"">
                    <div class=""card-body pb-2"">
                        <div class=""card-body pb-2"">
                            <h1>Lista de pedidos</h1>
                        </div>
                    </div>
                </div>

                <div class=""tab-pane fade"" id=""account-change-password"">
                    <div class=""card-body pb-2"">

                        <div class=""form-group"">
                            <label class=""form-label"">Configurar senha</label>
                            <input type=""password"" class=""form-control"">
                        </div>
                        <div class=""alert alert-warning mt-3"">
                            Sua senha ainda não está configurada. Por favor configurar senha para realizar o logi");
            WriteLiteral(@"n!<br>
                            <a href=""javascript:void(0)"">Salvar senha</a>
                        </div>

                        <div class=""form-group"">
                            <label class=""form-label"">Mudar senha</label>
                            <input type=""password"" class=""form-control"">
                        </div>

                        <div class=""form-group"">
                            <label class=""form-label"">Repetir nova senha</label>
                            <input type=""password"" class=""form-control"">
                        </div>

                    </div>
                </div>

                <div class=""tab-pane fade"" id=""account-info"">
                    <div class=""card-body pb-2"">

                        <div class=""form-group"">
                            <label class=""form-label"">Bio</label>
                            <textarea class=""form-control"" rows=""5"">Amigos do Bem é uma instituição sem fins lucrativos que desenvolve projetos educ");
            WriteLiteral(@"acionais, de geração de trabalho e renda, água, saúde e moradia no sertão do Nordeste brasileiro, promovendo, desde 1993, desenvolvimento local e inclusão social junto às populações em situação de extrema pobreza e miséria.</textarea>
                        </div>
                        <div class=""form-group"">
                            <label class=""form-label"">Aniversário</label>
                            <input type=""text"" class=""form-control"" value=""3 de Junho, 2005"">
                        </div>
                        <div class=""form-group"">
                            <label class=""form-label"">País</label>
                            <select class=""custom-select"">
                                ");
            EndContext();
            BeginContext(4916, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df093b8472ec46528d9cc36ce84e9a44", async() => {
                BeginContext(4924, 3, true);
                WriteLiteral("USA");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4936, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4970, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa61cde26774e31aa4886e204c8a25d", async() => {
                BeginContext(4990, 6, true);
                WriteLiteral("Brasil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5005, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5039, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f9816b6234499daacf6438e35723e3", async() => {
                BeginContext(5047, 6, true);
                WriteLiteral("Canadá");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5062, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5096, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a99b447d718c46938412820811adb38b", async() => {
                BeginContext(5104, 8, true);
                WriteLiteral("Alemanha");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5121, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5155, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d7f27ed4594b69a54adbfe9d19d50a", async() => {
                BeginContext(5163, 6, true);
                WriteLiteral("França");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5178, 7941, true);
            WriteLiteral(@"
                            </select>
                        </div>


                    </div>
                    <hr class=""border-light m-0"">
                    <div class=""card-body pb-2"">

                        <h6 class=""mb-4"">Contatos</h6>
                        <div class=""form-group"">
                            <label class=""form-label"">Telefone</label>
                            <input type=""text"" class=""form-control"" value=""+55 (11) 3019-0100"">
                        </div>
                        <div class=""form-group"">
                            <label class=""form-label"">Site</label>
                            <input type=""text"" class=""form-control"" value=""https://www.amigosdobem.org/"">
                        </div>

                    </div>

                </div>
                <div class=""tab-pane fade"" id=""account-social-links"">
                    <div class=""card-body pb-2"">

                        <div class=""form-group"">
                       ");
            WriteLiteral(@"     <label class=""form-label"">Twitter</label>
                            <input type=""text"" class=""form-control"" value=""https://twitter.com/amigosdobem"">
                        </div>
                        <div class=""form-group"">
                            <label class=""form-label"">Facebook</label>
                            <input type=""text"" class=""form-control"" value=""https://www.facebook.com/amigosdobem"">
                        </div>
                        <div class=""form-group"">
                            <label class=""form-label"">Youtube</label>
                            <input type=""text"" class=""form-control"" value=""https://www.youtube.com/user/amigosdobemweb"">
                        </div>
                        <div class=""form-group"">
                            <label class=""form-label"">LinkedIn</label>
                            <input type=""text"" class=""form-control"" value=""https://www.linkedin.com/company/amigos-do-bem/"">
                        </div>
          ");
            WriteLiteral(@"              <div class=""form-group"">
                            <label class=""form-label"">Instagram</label>
                            <input type=""text"" class=""form-control"" value=""https://www.instagram.com/amigosdobem/"">
                        </div>

                    </div>
                </div>
                <div class=""tab-pane fade"" id=""account-connections"">
                    <div class=""card-body"">
                        <button type=""button"" class=""btn btn-twitter"">Conectar <strong>Twitter</strong></button>
                    </div>
                    <hr class=""border-light m-0"">
                    <div class=""card-body"">
                        <h5 class=""mb-2"">
                            <a href=""javascript:void(0)"" class=""float-right text-muted text-tiny""><i class=""ion ion-md-close""></i> Remover</a>
                            <i class=""ion ion-logo-google text-google""></i>
                            Você está conectado ao Google:
                        </h5>
");
            WriteLiteral(@"                        amigosdobem@gmail.com
                    </div>
                    <hr class=""border-light m-0"">
                    <div class=""card-body"">
                        <button type=""button"" class=""btn btn-facebook"">Conectar <strong>Facebook</strong></button>
                    </div>
                    <hr class=""border-light m-0"">
                    <div class=""card-body"">
                        <button type=""button"" class=""btn btn-instagram"">Conectar <strong>Instagram</strong></button>
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""account-notifications"">
                    <div class=""card-body pb-2"">

                        <h6 class=""mb-4"">Atividades</h6>

                        <div class=""form-group"">
                            <label class=""switcher"">
                                <input type=""checkbox"" class=""switcher-input"" checked="""">
                                <span class=""switcher-indicator""");
            WriteLiteral(@">
                                    <span class=""switcher-yes""></span>
                                    <span class=""switcher-no""></span>
                                </span>
                                <span class=""switcher-label"">Notificar quando uma solicitação expirar</span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""switcher"">
                                <input type=""checkbox"" class=""switcher-input"" checked="""">
                                <span class=""switcher-indicator"">
                                    <span class=""switcher-yes""></span>
                                    <span class=""switcher-no""></span>
                                </span>
                                <span class=""switcher-label"">Notificar quando uma solicitação for aceita</span>
                            </label>
                        </div>
                        <div");
            WriteLiteral(@" class=""form-group"">
                            <label class=""switcher"">
                                <input type=""checkbox"" class=""switcher-input"">
                                <span class=""switcher-indicator"">
                                    <span class=""switcher-yes""></span>
                                    <span class=""switcher-no""></span>
                                </span>
                                <span class=""switcher-label"">Notificar quando alguém entrar em contato</span>
                            </label>
                        </div>
                    </div>
                    <hr class=""border-light m-0"">
                    <div class=""card-body pb-2"">

                        <h6 class=""mb-4"">Aplicação</h6>

                        <div class=""form-group"">
                            <label class=""switcher"">
                                <input type=""checkbox"" class=""switcher-input"" checked="""">
                                <span class=""switch");
            WriteLiteral(@"er-indicator"">
                                    <span class=""switcher-yes""></span>
                                    <span class=""switcher-no""></span>
                                </span>
                                <span class=""switcher-label"">Noticías e anúncios</span>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""switcher"">
                                <input type=""checkbox"" class=""switcher-input"">
                                <span class=""switcher-indicator"">
                                    <span class=""switcher-yes""></span>
                                    <span class=""switcher-no""></span>
                                </span>
                                <span class=""switcher-label"">Conectar com doadores próximos</span>
                            </label>
                        </div>
                        <div class=""form-group"">
          ");
            WriteLiteral(@"                  <label class=""switcher"">
                                <input type=""checkbox"" class=""switcher-input"" checked="""">
                                <span class=""switcher-indicator"">
                                    <span class=""switcher-yes""></span>
                                    <span class=""switcher-no""></span>
                                </span>
                                <span class=""switcher-label"">Conectar com outros recebedores</span>
                            </label>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div>
    <h4>Solicitações</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(13120, 40, false);
#line 245 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(13160, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(13204, 36, false);
#line 248 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(13240, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(13284, 45, false);
#line 251 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(13329, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(13373, 41, false);
#line 254 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(13414, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(13458, 41, false);
#line 257 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(13499, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(13543, 37, false);
#line 260 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(13580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(13624, 44, false);
#line 263 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(13668, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(13712, 40, false);
#line 266 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(13752, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(13796, 44, false);
#line 269 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(13840, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(13884, 40, false);
#line 272 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(13924, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(13968, 42, false);
#line 275 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(14010, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(14054, 38, false);
#line 278 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(14092, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(14136, 42, false);
#line 281 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(14178, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(14222, 38, false);
#line 284 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(14260, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(14304, 42, false);
#line 287 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(14346, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(14390, 38, false);
#line 290 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(14428, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(14472, 42, false);
#line 293 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(14514, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(14558, 38, false);
#line 296 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(14596, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(14640, 39, false);
#line 299 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(14679, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(14723, 35, false);
#line 302 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(14758, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(14806, 68, false);
#line 307 "C:\Users\filli\Desktop\global-solutions-enterprise\GSEnterprise\GSEnterprise\Views\Doador\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(14874, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(14882, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e26041e0131b4173a800bb6931ec2033", async() => {
                BeginContext(14904, 12, true);
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
            BeginContext(14920, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSEnterprise.Models.Entidades.Doador> Html { get; private set; }
    }
}
#pragma warning restore 1591