#pragma checksum "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fecdbada22c01fe9d02ce1a80712881ac8925de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Deployments), @"mvc.1.0.view", @"/Views/Home/Deployments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fecdbada22c01fe9d02ce1a80712881ac8925de1", @"/Views/Home/Deployments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4567776fe2f0f03947657081e0e27d6f8c7169", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Deployments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<web_ui.Models.DeploymentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("       \n");
#nullable restore
#line 7 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml"
      
        ViewData["Title"] = "Deployments";    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <h1 class=\"page-header\">Deployments</h1>\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<table class=\"table\">    \n    <thead>    \n        <tr>\n");
            WriteLiteral("            <th>    \n                ");
#nullable restore
#line 23 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n            </th>        \n");
            WriteLiteral("            <th></th>    \n        </tr>    \n    </thead>    \n    <tbody>    \n");
#nullable restore
#line 32 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml"
         foreach (var item in Model)    
{    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>    \n");
            WriteLiteral("                <td>    \n                    ");
#nullable restore
#line 39 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n                </td>    \n");
            WriteLiteral("                <td>    \n");
            WriteLiteral("                </td>    \n            </tr>    \n");
#nullable restore
#line 48 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/Deployments.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<web_ui.Models.DeploymentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
