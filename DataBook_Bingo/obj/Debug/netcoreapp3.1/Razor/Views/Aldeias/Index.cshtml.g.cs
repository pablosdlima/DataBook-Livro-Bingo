#pragma checksum "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80c46e88909e62539c6548b9683fb2bc68edb408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aldeias_Index), @"mvc.1.0.view", @"/Views/Aldeias/Index.cshtml")]
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
#line 1 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\_ViewImports.cshtml"
using DataBook_Bingo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\_ViewImports.cshtml"
using DataBook_Bingo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80c46e88909e62539c6548b9683fb2bc68edb408", @"/Views/Aldeias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f728b75d328aa43f716d16aaa95106f185000870", @"/Views/_ViewImports.cshtml")]
    public class Views_Aldeias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataBook_Bingo.Models.Aldeia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Aldeias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Imagens/nulo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:15%; width:70%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("figure-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""aviso"" class=""alert alert-warning alert-dismissible"" role=""alert"" >
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <strong aria-hidden=""true"" style=""text-indent:25px; font-family:Calibri; color:slategrey;"">
        Total de ");
#nullable restore
#line 5 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
            Write(ViewBag.TotalAldeiaAlerta);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vila(s) já Cadastrada(s)...\r\n    </strong>\r\n</div>\r\n<div style=\"padding-left:2%;\" class=\"row\">\r\n    <div class=\"btn-group btn-group-justified busca\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80c46e88909e62539c6548b9683fb2bc68edb4086873", async() => {
                WriteLiteral("\r\n            <input style=\"padding-left:1%;\" class=\"btn btn-outline-info\" type=\"search\" placeholder=\"Buscar:\" name=\"buscaAldeia\" />\r\n            <input type=\"submit\" class=\"btn btn-info\" value=\"Buscar\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"btn-group btn-group-justified\">\r\n    <a href=\"#\" class=\"btn btn-outline-info disabled\">Total de Registros:</a>\r\n    <a href=\"#\" class=\"btn btn-info disabled\">");
#nullable restore
#line 18 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
                                         Write(ViewBag.TotalAldeia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</div>\r\n\r\n<div class=\"btn-group btn-group-justified\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80c46e88909e62539c6548b9683fb2bc68edb4089481", async() => {
                WriteLiteral("Adicionar Aldeia");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"padding-left:10%; padding-right:10%; padding-top:3%;\" class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <figure class=\"col-md-2 border-left border-bottom\">\r\n");
#nullable restore
#line 29 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
         if (item.ImgAldeia != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <figcaption align=\"center\">");
#nullable restore
#line 31 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.NomeAldeia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption>\r\n            <hr />\r\n");
#nullable restore
#line 33 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
            var _img64 = Convert.ToBase64String(item.ImgAldeia);
            var imgScr = String.Format("data:image/gif;base64,{0}", _img64);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 1654, "\"", 1667, 1);
#nullable restore
#line 35 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
WriteAttributeValue("", 1660, imgScr, 1660, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Teste\" style=\"margin-left:15%; width:70%;\" class=\"figure-img\" />\r\n");
#nullable restore
#line 36 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80c46e88909e62539c6548b9683fb2bc68edb40812736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </figure>\r\n");
#nullable restore
#line 43 "C:\Aplicações\DataBook-Livro-Bingo\DataBook_Bingo\Views\Aldeias\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <figure class=\"col-md-2 border-left\">\r\n    </figure>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataBook_Bingo.Models.Aldeia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
