#pragma checksum "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/user.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b07635ef58e4f7c56a260be7ac2c47d5aa5c36c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_user), @"mvc.1.0.view", @"/Views/Home/user.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/user.cshtml", typeof(AspNetCore.Views_Home_user))]
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
#line 1 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/user.cshtml"
using viewmodel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b07635ef58e4f7c56a260be7ac2c47d5aa5c36c", @"/Views/Home/user.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cbee923471f09511bc8ec22a7fda79c5d9a92d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_user : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 29, true);
            WriteLiteral("\n<h4>Here is a User!</h4>\n<p>");
            EndContext();
            BeginContext(66, 15, false);
#line 5 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/user.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(81, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(83, 14, false);
#line 5 "/Users/amani/codingDojo/dotnet/asp-mvc/viewmodel/Views/Home/user.cshtml"
               Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(97, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
