#pragma checksum "M:\netbean\project\NetCore_SPA_React\KittenKatKookie\KittenKatKookie\Pages\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d23b0fe0c45a6f6de966f9415211b137c86931b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KittenKatKookie.Pages.Account.Pages_Account_Profile), @"mvc.1.0.razor-page", @"/Pages/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/Profile.cshtml", typeof(KittenKatKookie.Pages.Account.Pages_Account_Profile), null)]
namespace KittenKatKookie.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "M:\netbean\project\NetCore_SPA_React\KittenKatKookie\KittenKatKookie\Pages\_ViewImports.cshtml"
using KittenKatKookie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d23b0fe0c45a6f6de966f9415211b137c86931b", @"/Pages/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cf58b09aa0451901ded8a1e0f1ddc558035abe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Account_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "M:\netbean\project\NetCore_SPA_React\KittenKatKookie\KittenKatKookie\Pages\Account\Profile.cshtml"
  
    ViewData["Recipe-Title-Name"] = "Profile";

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRecipesService RecipesService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel>)PageContext?.ViewData;
        public ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
