#pragma checksum "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7864e2a776e73f2dfdeff15053d9702973e573fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums__TableComents), @"mvc.1.0.view", @"/Views/Albums/_TableComents.cshtml")]
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
#line 1 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\_ViewImports.cshtml"
using BertoniSolutions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\_ViewImports.cshtml"
using BertoniSolutions.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7864e2a776e73f2dfdeff15053d9702973e573fe", @"/Views/Albums/_TableComents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1025c5c75e050d6403751b0928af0d3dbbf3a3d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums__TableComents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BertoniSolutions.Models.ComentarioViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n");
#nullable restore
#line 4 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"
     foreach (var com in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"
           Write(com.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"
           Write(com.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"
           Write(com.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"
           Write(com.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"
           Write(com.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Gaston\Desktop\BertoniSolutions\BertoniSolutions\BertoniSolutions\Views\Albums\_TableComents.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BertoniSolutions.Models.ComentarioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
