#pragma checksum "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\CustomLayout\_SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3230701f9662878e92a9eb0fa6748bb76ec5c5fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomLayout__SideMenu), @"mvc.1.0.view", @"/Views/Shared/CustomLayout/_SideMenu.cshtml")]
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
#line 1 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3230701f9662878e92a9eb0fa6748bb76ec5c5fc", @"/Views/Shared/CustomLayout/_SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1bfadfcddff9ab6c8abcdcb92a2cb23a6f7e19", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomLayout__SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""main-sidebar sidebar-dark-primary elevation-4"">
    <a href=""../../index3.html"" class=""brand-link"">
        <img src=""../../dist/img/AdminLTELogo.png""
             alt=""AdminLTE Logo""
             class=""brand-image img-circle elevation-3""
             style=""opacity: .8"">
        <span class=""brand-text font-weight-light"">TNH</span>
    </a>
    <div class=""sidebar"">
        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                ");
#nullable restore
#line 13 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\CustomLayout\_SideMenu.cshtml"
            Write(await Component.InvokeAsync("Menu", new { parentId = -1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n        <!-- /.sidebar-menu -->\r\n    </div>\r\n    <!--  /.sidebar -->\r\n</aside>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
