#pragma checksum "/home/felipe/projects/personal/k8s-study/kubernetes-csharp/examples/web-ui/Views/Home/PodLogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb733326ee8b3b2ebdb3d92759b22eb26ade60f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PodLogs), @"mvc.1.0.view", @"/Views/Home/PodLogs.cshtml")]
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
#nullable restore
#line 1 "/home/felipe/projects/personal/k8s-study/kubernetes-csharp/examples/web-ui/Views/_ViewImports.cshtml"
using web_ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/felipe/projects/personal/k8s-study/kubernetes-csharp/examples/web-ui/Views/_ViewImports.cshtml"
using web_ui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb733326ee8b3b2ebdb3d92759b22eb26ade60f6", @"/Views/Home/PodLogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4567776fe2f0f03947657081e0e27d6f8c7169", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PodLogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web_ui.Models.PodLogModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/felipe/projects/personal/k8s-study/kubernetes-csharp/examples/web-ui/Views/Home/PodLogs.cshtml"
  
    ViewData["Title"] = "Pod Logs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("       \n");
#nullable restore
#line 7 "/home/felipe/projects/personal/k8s-study/kubernetes-csharp/examples/web-ui/Views/Home/PodLogs.cshtml"
      
        ViewData["Title"] = "Pod Logs";    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Pod Logs</h2>    \n<p>    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb733326ee8b3b2ebdb3d92759b22eb26ade60f63933", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("    \n</p>    \n\n<div>    \n    <h4>Details</h4>    \n    <hr />    \n    <dl class=\"dl-horizontal\">    \n        <dt>    \n            \"Log\"    \n        </dt>    \n        <dd>    \n            ");
#nullable restore
#line 23 "/home/felipe/projects/personal/k8s-study/kubernetes-csharp/examples/web-ui/Views/Home/PodLogs.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n        </dd>    \n    </dl>    \n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web_ui.Models.PodLogModel> Html { get; private set; }
    }
}
#pragma warning restore 1591