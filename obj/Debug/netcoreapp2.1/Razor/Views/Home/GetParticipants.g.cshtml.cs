#pragma checksum "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc57040f428e1e6e477568acec74ed2a436b3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetParticipants), @"mvc.1.0.view", @"/Views/Home/GetParticipants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetParticipants.cshtml", typeof(AspNetCore.Views_Home_GetParticipants))]
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
#line 1 "C:\Users\Natashka\Desktop\CoreRegSite\Views\_ViewImports.cshtml"
using CoreRegSite;

#line default
#line hidden
#line 2 "C:\Users\Natashka\Desktop\CoreRegSite\Views\_ViewImports.cshtml"
using CoreRegSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc57040f428e1e6e477568acec74ed2a436b3e5", @"/Views/Home/GetParticipants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e2957a1180965b1c11d66a5d0deb9809f26160", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetParticipants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreRegSite.Models.SimpleUserModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
  
    ViewBag.Title = "Participants";

#line default
#line hidden
            BeginContext(100, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(125, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a90fbf2b964981b0b23eead253d21c", async() => {
                BeginContext(131, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(253, 17, false);
#line 10 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(270, 24, true);
                WriteLiteral(" - CoreRegSite</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(301, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(303, 433, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784caf0373ab42ab95799bd2d4659ebf", async() => {
                BeginContext(309, 105, true);
                WriteLiteral("\r\n    \r\n    <table class=\"table table-striped table-light table-hover table-bordered\">\r\n        <tbody>\r\n");
                EndContext();
#line 16 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(471, 47, true);
                WriteLiteral("                <tr> \r\n                    <td>");
                EndContext();
                BeginContext(519, 25, false);
#line 19 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
                   Write(item.ParticipantFirstName);

#line default
#line hidden
                EndContext();
                BeginContext(544, 32, true);
                WriteLiteral("</td> \r\n                    <td>");
                EndContext();
                BeginContext(577, 26, false);
#line 20 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
                   Write(item.ParticipantSecondName);

#line default
#line hidden
                EndContext();
                BeginContext(603, 32, true);
                WriteLiteral("</td> \r\n                    <td>");
                EndContext();
                BeginContext(636, 24, false);
#line 21 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
                   Write(item.ParticipantActivity);

#line default
#line hidden
                EndContext();
                BeginContext(660, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 23 "C:\Users\Natashka\Desktop\CoreRegSite\Views\Home\GetParticipants.cshtml"
            }

#line default
#line hidden
                BeginContext(705, 24, true);
                WriteLiteral("        </tbody>\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(736, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreRegSite.Models.SimpleUserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
