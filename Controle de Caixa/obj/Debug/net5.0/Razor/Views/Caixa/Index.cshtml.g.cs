#pragma checksum "I:\Controle-de-Caixa\Controle de Caixa\Views\Caixa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74c3aead0447ac66ad8377bf195932df5c3be69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caixa_Index), @"mvc.1.0.view", @"/Views/Caixa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74c3aead0447ac66ad8377bf195932df5c3be69", @"/Views/Caixa/Index.cshtml")]
    public class Views_Caixa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "I:\Controle-de-Caixa\Controle de Caixa\Views\Caixa\Index.cshtml"
  
    ViewData["Title"] = "Controle Fluxo de Caixa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form>
    <div class=""form-group"">
        <label for=""formValor"">Valor</label>
        <input type=""text"" class=""form-control"" id=""valor"">
    </div>
    <div class=""form-group"">
        <label for=""formTipo"">Tipo</label>
        <select class=""form-control"" id=""Tipo"">
            <option>Entrada</option>
            <option>Saída</option>
        </select>
    </div>
    <div class=""form-group"">
        <label for=""formValor"">Motivo</label>
        <input type=""text"" class=""form-control"" id=""motivo"">
    </div>
    <button class=""btn btn-lg btn-success"" type=""submit""> Gravar </button>
</form>");
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
