#pragma checksum "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf92e3489e0c1dfed2ffcd75844f20b6bb6e959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Nodes), @"mvc.1.0.view", @"/Views/Home/Nodes.cshtml")]
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
#line 1 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/_ViewImports.cshtml"
using web_ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/_ViewImports.cshtml"
using web_ui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf92e3489e0c1dfed2ffcd75844f20b6bb6e959", @"/Views/Home/Nodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4567776fe2f0f03947657081e0e27d6f8c7169", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Nodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<web_ui.Models.NodeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
  
    ViewData["Title"] = "Nodes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("       \n");
#nullable restore
#line 7 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
      
        ViewData["Title"] = "Nodes";    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <h1 class=\"page-header\">Nodes</h1>\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<table class=\"table\">    \n    <thead>    \n        <tr>\n            <th>    \n                ");
#nullable restore
#line 21 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
           Write(Html.DisplayNameFor(model => model.Uid));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n            </th>    \n            <th>    \n                ");
#nullable restore
#line 24 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
           Write(Html.DisplayNameFor(model => model.PodIP));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n            </th>        \n            <th>    \n                ");
#nullable restore
#line 27 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
           Write(Html.DisplayNameFor(model => model.HostName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n            </th>    \n            <th></th>    \n        </tr>    \n    </thead>    \n    <tbody>    \n");
#nullable restore
#line 33 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
         foreach (var item in Model)    
{    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>    \n                <td>    \n                    ");
#nullable restore
#line 37 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
               Write(Html.DisplayFor(modelItem => item.Uid));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
#nullable restore
#line 40 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
               Write(Html.DisplayFor(modelItem => item.PodIP));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
#nullable restore
#line 43 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
               Write(Html.DisplayFor(modelItem => item.HostName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n                </td>    \n                <td>    \n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecf92e3489e0c1dfed2ffcd75844f20b6bb6e9596864", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
                                              WriteLiteral(item.Uid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("    \n                </td>    \n            </tr>    \n");
#nullable restore
#line 49 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Nodes.cshtml"
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>    \n</table>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<web_ui.Models.NodeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
