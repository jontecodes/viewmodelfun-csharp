#pragma checksum "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd20eed631cc6b9b355700593ee9821607ef3b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_users), @"mvc.1.0.view", @"/Views/Home/users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/users.cshtml", typeof(AspNetCore.Views_Home_users))]
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
#line 1 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/users.cshtml"
using viewmodel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd20eed631cc6b9b355700593ee9821607ef3b5", @"/Views/Home/users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cbee923471f09511bc8ec22a7fda79c5d9a92d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 32, true);
            WriteLiteral("\n<h3>Here are some Users!</h3>\n\n");
            EndContext();
#line 6 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/users.cshtml"
 foreach (var user in Model)
{

#line default
#line hidden
            BeginContext(105, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(113, 14, false);
#line 8 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/users.cshtml"
  Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(127, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(129, 13, false);
#line 8 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/users.cshtml"
                  Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(142, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 9 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/users.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
