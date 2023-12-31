#pragma checksum "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ebd11824d569bd1cc4876c6ab0dcf9c84ff78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NewsWebsite.Pages.Pages_Politics), @"mvc.1.0.razor-page", @"/Pages/Politics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ebd11824d569bd1cc4876c6ab0dcf9c84ff78f", @"/Pages/Politics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90043ec9aee9334ecbb764efdea4c6fd9611f75b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Politics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("popular-news img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
  
    Layout = "Customer_Layout";
    ViewData["Title"] = "Politics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ebd11824d569bd1cc4876c6ab0dcf9c84ff78f4575", async() => {
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.1/css/all.css"" integrity=""sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr"" crossorigin=""anonymous"">

    <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ebd11824d569bd1cc4876c6ab0dcf9c84ff78f5824", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("            <main>\r\n                <section class=\"more-news\">\r\n                    <div class=\"news-section\">\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                         foreach (News_ClassLibrary.Logic.Classes.NewsArticle cont in Model.articles)
                        {

                            if (cont.NewsType == "POLITICS")

                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <article class=\"sport\">\r\n\r\n                                    <h2>");
#nullable restore
#line 48 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                   Write(cont.NewsType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5ebd11824d569bd1cc4876c6ab0dcf9c84ff78f7097", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2374, "~/photo/", 2374, 8, true);
#nullable restore
#line 49 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
AddHtmlAttributeValue("", 2382, cont.Img, 2382, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n                                    <h3>");
#nullable restore
#line 50 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                   Write(cont.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 51 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                  Write(cont.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 52 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                  Write(cont.NewsType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 53 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                  Write(cont.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 54 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                  Write(cont.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ebd11824d569bd1cc4876c6ab0dcf9c84ff78f10319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"
                                                            WriteLiteral(cont.NewsID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </article>\r\n");
#nullable restore
#line 59 "C:\Users\vera2\source\repos\NewsWebsite\NewsWebsite\Pages\Politics.cshtml"

                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <aside>
                        <h4>RECENT</h4>
                        <div class=""recent-news"">
                            <img src=""images/article1.jpg"">
                            <p>2021 Mercedes-AMG C63 Coupe Makes its Debut</p>
                        </div>
                        <div class=""recent-news"">
                            <img src=""images/aside2.jpg"">
                            <p>2021 Mercedes-AMG C63 Coupe Makes its Debut</p>
                        </div>
                        <div class=""recent-news"">
                            <img src=""images/aside3.jpg"">
                            <p>2021 Mercedes-AMG C63 Coupe Makes its Debut</p>
                        </div>
                        <div class=""recent-news"">
                            <img src=""images/aside4.jpg"">
                            <p>2021 Mercedes-AMG C63 Coupe Makes its Debut</p>
                        </div>
                        <div class");
                WriteLiteral("=\"recent-news\">\r\n                            <img src=\"images/aside5.jpg\">\r\n                            <p>2021 Mercedes-AMG C63 Coupe Makes its Debut</p>\r\n                        </div>\r\n                    </aside>\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n    </section>\r\n        </main>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.Pages.PoliticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewsWebsite.Pages.PoliticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewsWebsite.Pages.PoliticsModel>)PageContext?.ViewData;
        public NewsWebsite.Pages.PoliticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
