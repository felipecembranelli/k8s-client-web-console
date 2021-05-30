#pragma checksum "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c6e9b2dab94166769d4298a74e50241cd3edd93"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6e9b2dab94166769d4298a74e50241cd3edd93", @"/Views/Home/PodLogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4567776fe2f0f03947657081e0e27d6f8c7169", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PodLogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web_ui.Models.PodLogModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
  
    ViewData["Title"] = "Pod Logs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("       \n");
#nullable restore
#line 7 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
      
        ViewData["Title"] = "Pod Logs";    
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 class=""page-header"">Logs</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Log
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                            <thead>
                                <tr>
                                    <th>Pod Id</th>
                                    <th>Namespace</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class=""odd gradeX"">
                                    ");
            WriteLiteral("<td>");
#nullable restore
#line 37 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
                                   Write(Html.DisplayFor(model => model.PodName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                    <td>");
#nullable restore
#line 38 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
                                   Write(Html.DisplayFor(model => model.PodNamespace));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                </tr>
                            
                            </tbody>
                        </table>
                    </div>
                    <!-- /.table-responsive -->
                
        </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
");
            WriteLiteral(@"                    <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>    
                            <tr>
                                <th>    
                                    Log Info
                                </th>    
                            </tr>    
                        </thead>    
                        <tbody>    
");
#nullable restore
#line 71 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
                             foreach (var row in Model.LogRows)    
                    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>    \n                                    <td>    \n                                        ");
#nullable restore
#line 75 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
                                   Write(Html.DisplayFor(modelItem => row));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n                                    </td>    \n                                </tr>    \n");
#nullable restore
#line 78 "/home/felipe/projects/personal/k8s-study/k8s-client-web-console/kubernetes-client-api-consumer/web-ui/Views/Home/PodLogs.cshtml"
                            }    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>    
                    </table>   
                </div>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
</div>
<!-- /.panel-body -->");
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