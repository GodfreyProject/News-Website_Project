#pragma checksum "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a03f72376e718bf11559d6e682e6711cf5e4962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NewsWebsite.Pages.Pages_CustomerComments), @"mvc.1.0.razor-page", @"/Pages/CustomerComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a03f72376e718bf11559d6e682e6711cf5e4962", @"/Pages/CustomerComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90043ec9aee9334ecbb764efdea4c6fd9611f75b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CustomerComments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
  
    Layout = "Admin_Layout";
    ViewData["Title"] = "CustomerComments";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table id=\"customers\">\r\n\r\n    <tr>\r\n        <th>REVIEWID</th>\r\n        <th>PERSONID</th>\r\n        <th>USERNAME</th>\r\n        <th>NEWSID</th>\r\n        <th>NEWSTYPE</th>\r\n        <th>MESSAGE</th>\r\n        <th>DATE</th>\r\n");
            WriteLiteral(">\r\n      \r\n\r\n");
            WriteLiteral("    </tr>\r\n\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
     foreach (News_ClassLibrary.Logic.Classes.Review r in Model.reviews)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.ReviewID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.PersonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 43 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.NewsID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.NewsType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"
           Write(r.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n");
            WriteLiteral("\r\n");
            WriteLiteral("            <td>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\CustomerComments.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.Pages.CustomerCommentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewsWebsite.Pages.CustomerCommentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewsWebsite.Pages.CustomerCommentsModel>)PageContext?.ViewData;
        public NewsWebsite.Pages.CustomerCommentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
