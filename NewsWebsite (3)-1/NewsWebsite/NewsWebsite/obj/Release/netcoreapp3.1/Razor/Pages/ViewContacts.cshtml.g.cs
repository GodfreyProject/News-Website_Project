#pragma checksum "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2496cce1aa80573de6f0fb2e4d4fe969cbd0bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NewsWebsite.Pages.Pages_ViewContacts), @"mvc.1.0.razor-page", @"/Pages/ViewContacts.cshtml")]
namespace NewsWebsite.Pages
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
#line 1 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\_ViewImports.cshtml"
using NewsWebsite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2496cce1aa80573de6f0fb2e4d4fe969cbd0bf", @"/Pages/ViewContacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90043ec9aee9334ecbb764efdea4c6fd9611f75b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewContacts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
  
    Layout = "Admin_Layout";
    ViewData["Title"] = "ViewContacts";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table id=\"customers\">\r\n\r\n    <tr>\r\n        <th>CONTACTID</th>\r\n        <th>PERSONID</th>\r\n        <th>FIRSTNAME</th>\r\n        <th>EMAIL</th>\r\n        <th>SUBJECT</th>\r\n\r\n        \r\n");
            WriteLiteral(">\r\n\r\n\r\n");
            WriteLiteral("    </tr>\r\n\r\n\r\n\r\n");
#nullable restore
#line 33 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
     foreach (var r in Model.contacts)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
           Write(r.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
           Write(r.PersonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
           Write(r.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 42 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
           Write(r.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"
           Write(r.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n          \r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("            <td>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\ViewContacts.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.Pages.ViewContactsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewsWebsite.Pages.ViewContactsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewsWebsite.Pages.ViewContactsModel>)PageContext?.ViewData;
        public NewsWebsite.Pages.ViewContactsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
