#pragma checksum "/Users/mathieuhebert/Projects/MvCTests/Views/Shared/Components/Textbox/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1569ff3e72a23a3041e289058c6a3f2f6e0437c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Textbox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Textbox/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Textbox/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Textbox_Default))]
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
#line 1 "/Users/mathieuhebert/Projects/MvCTests/Views/_ViewImports.cshtml"
using MvCTests;

#line default
#line hidden
#line 2 "/Users/mathieuhebert/Projects/MvCTests/Views/_ViewImports.cshtml"
using MvCTests.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1569ff3e72a23a3041e289058c6a3f2f6e0437c", @"/Views/Shared/Components/Textbox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484d1377c35111220eeabedbc1a2929c007ce5e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Textbox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvCTests.Models.Components.Textbox.Textbox>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 36, true);
            WriteLiteral("<div class=\"form-group\">\n    <label>");
            EndContext();
            BeginContext(87, 11, false);
#line 3 "/Users/mathieuhebert/Projects/MvCTests/Views/Shared/Components/Textbox/Default.cshtml"
      Write(Model.Label);

#line default
#line hidden
            EndContext();
            BeginContext(98, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(101, 82, false);
#line 3 "/Users/mathieuhebert/Projects/MvCTests/Views/Shared/Components/Textbox/Default.cshtml"
                    Write(Model.IsRequired ? Html.Raw("<span class=\"text-danger\">*</span>") : Html.Raw(""));

#line default
#line hidden
            EndContext();
            BeginContext(184, 31, true);
            WriteLiteral("</label>\n    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 215, "\"", 235, 1);
#line 4 "/Users/mathieuhebert/Projects/MvCTests/Views/Shared/Components/Textbox/Default.cshtml"
WriteAttributeValue("", 223, Model.Value, 223, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 236, "\"", 252, 1);
#line 4 "/Users/mathieuhebert/Projects/MvCTests/Views/Shared/Components/Textbox/Default.cshtml"
WriteAttributeValue("", 241, Model.Name, 241, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 253, "\"", 271, 1);
#line 4 "/Users/mathieuhebert/Projects/MvCTests/Views/Shared/Components/Textbox/Default.cshtml"
WriteAttributeValue("", 260, Model.Name, 260, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(272, 10, true);
            WriteLiteral(" />\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvCTests.Models.Components.Textbox.Textbox> Html { get; private set; }
    }
}
#pragma warning restore 1591