#pragma checksum "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b30a6db449d6e5e7c320fda90aa99ed6ab3cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication2.Pages.Pages_index), @"mvc.1.0.razor-page", @"/Pages/index.cshtml")]
namespace WebApplication2.Pages
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
#line 1 "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b30a6db449d6e5e7c320fda90aa99ed6ab3cad", @"/Pages/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538f37ef395561d5f352aabc9fc72bce1358fc6b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleforChat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6b30a6db449d6e5e7c320fda90aa99ed6ab3cad3787", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\index.cshtml"
 foreach (var person in Model.Users)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr><td>");
#nullable restore
#line 9 "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\index.cshtml"
       Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 9 "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\index.cshtml"
                            Write(person.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 10 "C:\Users\damir\source\repos\WebApplication2\WebApplication2\Pages\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row clearfix"">
        <div class=""col-lg-12"">
            <div class=""card chat-app"">
                <div id=""plist"" class=""people-list"">
                    <div class=""input-group"">
                    </div>
                    <ul class=""list-unstyled chat-list mt-2 mb-0"">
                        <li class=""clearfix"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar1.png"" alt=""avatar"">
                            <div class=""about"">
                                <div class=""name"">Vincent Porter</div>
                                <div class=""status""> <i class=""fa fa-circle offline""></i> left 7 mins ago </div>
                            </div>
                        </li>
                        <li class=""clearfix active"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar2.png"" alt=""avatar"">
                            <div class=""about"">
                                <d");
            WriteLiteral(@"iv class=""name"">Aiden Chavez</div>
                                <div class=""status""> <i class=""fa fa-circle online""></i> online </div>
                            </div>
                        </li>
                        <li class=""clearfix"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar3.png"" alt=""avatar"">
                            <div class=""about"">
                                <div class=""name"">Mike Thomas</div>
                                <div class=""status""> <i class=""fa fa-circle online""></i> online </div>
                            </div>
                        </li>
                        <li class=""clearfix"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""avatar"">
                            <div class=""about"">
                                <div class=""name"">Christian Kelly</div>
                                <div class=""status""> <i class=""fa fa-circle offline""></i> left 10 hour");
            WriteLiteral(@"s ago </div>
                            </div>
                        </li>
                        <li class=""clearfix"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar8.png"" alt=""avatar"">
                            <div class=""about"">
                                <div class=""name"">Monica Ward</div>
                                <div class=""status""> <i class=""fa fa-circle online""></i> online </div>
                            </div>
                        </li>
                        <li class=""clearfix"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar3.png"" alt=""avatar"">
                            <div class=""about"">
                                <div class=""name"">Dean Henry</div>
                                <div class=""status""> <i class=""fa fa-circle offline""></i> offline since Oct 28 </div>
                            </div>
                        </li>
                    </ul>
                </di");
            WriteLiteral(@"v>
                <div class=""chat"">
                    <div class=""chat-header clearfix"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <a href=""javascript:void(0);"" data-toggle=""modal"" data-target=""#view_info"">
                                    <img src=""https://bootdey.com/img/Content/avatar/avatar2.png"" alt=""avatar"">
                                </a>
                                <div class=""chat-about"">
                                    <h6 class=""m-b-0"">Aiden Chavez</h6>
                                    <small>Last seen: 2 hours ago</small>
                                </div>
                            </div>
                            <div class=""col-lg-6 hidden-sm text-right"">
                                <a href=""javascript:void(0);"" class=""btn btn-outline-secondary""><i class=""fa fa-camera""></i></a>
                                <a href=""javascript:void(0);"" class=""btn btn-outline-pri");
            WriteLiteral(@"mary""><i class=""fa fa-image""></i></a>
                                <a href=""javascript:void(0);"" class=""btn btn-outline-info""><i class=""fa fa-cogs""></i></a>
                                <a href=""javascript:void(0);"" class=""btn btn-outline-warning""><i class=""fa fa-question""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""chat-history"">
                        <ul class=""m-b-0"">
                            <li class=""clearfix"">
                                <div class=""message-data text-right"">
                                    <span class=""message-data-time"">10:10 AM, Today</span>
                                    <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""avatar"">
                                </div>
                                <div class=""message other-message float-right""> Hi Aiden, how are you? How is the project coming along? </div>
                            </li>");
            WriteLiteral(@"
                            <li class=""clearfix"">
                                <div class=""message-data"">
                                    <span class=""message-data-time"">10:12 AM, Today</span>
                                </div>
                                <div class=""message my-message"">Are we meeting today?</div>
                            </li>
                            <li class=""clearfix"">
                                <div class=""message-data"">
                                    <span class=""message-data-time"">10:15 AM, Today</span>
                                </div>
                                <div class=""message my-message"">Project has been already finished and I have results to show you.</div>
                            </li>
                        </ul>
                    </div>
                    <div class=""chat-message clearfix"">
                        <div class=""input-group mb-0"">
                            <input type=""text"" class=""form-contr");
            WriteLiteral("ol\" placeholder=\"Enter text here...\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
