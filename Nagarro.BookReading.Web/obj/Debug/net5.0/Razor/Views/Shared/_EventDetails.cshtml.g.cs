#pragma checksum "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d20e838e0c7157bbd6bb71d6fc6e1f93355c45297a797957db66822dee488dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EventDetails), @"mvc.1.0.view", @"/Views/Shared/_EventDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d20e838e0c7157bbd6bb71d6fc6e1f93355c45297a797957db66822dee488dbb", @"/Views/Shared/_EventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"38a51df6d2d23236ecf432919f5ce46892cde4adf17db669ac9dbe574e987219", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__EventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nagarro.BookReading.Web.Models.EventViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var email = user != null ? user.Email : "";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-4"">
    <div class=""card mb-4 shadow-sm"" style=""width: 18rem;"">
        <img class=""bd-placeholder-img card-img-top"" width=""100"" height=""225"" src=""https://janefriedman.com/wp-content/uploads/2016/07/book-reading-1000x750.jpg"" alt=""Card image cap"">
        <div class=""card-body"">
            <div class=""card-title"">
                <h4>");
#nullable restore
#line 16 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
               Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n            </div>\n\n            <div>\n                <p class=\"text-success d-inline\">Location :</p>");
#nullable restore
#line 20 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                                          Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div>\n                <p class=\"text-success d-inline\">Date :</p> ");
#nullable restore
#line 23 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                                       Write(Model.date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div>\n                <p class=\"text-success d-inline\">Start Time :</p> ");
#nullable restore
#line 26 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                                             Write(Model.startTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n            <div class=\"btn-group\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20e838e0c7157bbd6bb71d6fc6e1f93355c45297a797957db66822dee488dbb7287", async() => {
                WriteLiteral("View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <p></p>\n");
#nullable restore
#line 33 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
             if (_signInManager.IsSignedIn(User) && (User.Identity.Name == Model.organiser || email== "myadmin@bookevents.com") && Model.date >= DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p></p>\n                <div class=\"btn-group\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20e838e0c7157bbd6bb71d6fc6e1f93355c45297a797957db66822dee488dbb10354", async() => {
                WriteLiteral("Update Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <p></p>\n");
#nullable restore
#line 40 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"row\">\n                <div class=\"col-md-6\">\n                    <p class=\"text-danger\">");
#nullable restore
#line 44 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                      Write(Model.eventType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Event</p>\n                </div>\n                <div class=\"col-md-6 text-danger\">Organised by <b>");
#nullable restore
#line 46 "C:\Users\Pranav\Desktop\Ashi\nagarro\Projects\MVCAssignment\Nagarro.BookReading.Web\Views\Shared\_EventDetails.cshtml"
                                                             Write(Model.organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n            </div>\n\n\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nagarro.BookReading.Web.Models.EventViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
