#pragma checksum "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ccf5f2d10b61054abe6fc883862f067067b5d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_numbers), @"mvc.1.0.view", @"/Views/Home/numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/numbers.cshtml", typeof(AspNetCore.Views_Home_numbers))]
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
#line 1 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/_ViewImports.cshtml"
using viewmodel;

#line default
#line hidden
#line 1 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/numbers.cshtml"
using viewmodel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ccf5f2d10b61054abe6fc883862f067067b5d7", @"/Views/Home/numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cbee923471f09511bc8ec22a7fda79c5d9a92d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 53, true);
            WriteLiteral("<h4>Here are some numbers</h4>\n<div class=\"numbers\">\n");
            EndContext();
#line 5 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/numbers.cshtml"
     foreach (var number in Model)
    {

#line default
#line hidden
            BeginContext(131, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(143, 6, false);
#line 7 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/numbers.cshtml"
      Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(149, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 8 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/numbers.cshtml"
    }

#line default
#line hidden
            BeginContext(160, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
