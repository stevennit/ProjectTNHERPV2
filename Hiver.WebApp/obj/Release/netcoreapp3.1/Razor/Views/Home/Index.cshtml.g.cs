#pragma checksum "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7006d233af79547c95826a2e0b96f50a58c047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7006d233af79547c95826a2e0b96f50a58c047", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1bfadfcddff9ab6c8abcdcb92a2cb23a6f7e19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Home\Index.cshtml"
   ViewData["Title"] = "Trang chủ"; 

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n");
            }
            );
            WriteLiteral(@"

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box"">
                    <span class=""info-box-icon bg-info elevation-1""><i class=""fas fa-shopping-cart""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Đơn hàng đang chạy</span>
                        <span class=""info-box-number"">
                            10
                        </span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-danger elevation-1""><i class=""fas fa-shopping-cart""></i></span>

                    <div class=""info-box-content"">
                      ");
            WriteLiteral(@"  <span class=""info-box-text"">Đơn hàng hoàn thành</span>
                        <span class=""info-box-number"">41,410</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <!-- fix for small devices only -->
            <div class=""clearfix hidden-md-up""></div>

            <div class=""col-12 col-sm-6 col-md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-success elevation-1""><i class=""fas fa-shopping-cart""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Sales</span>
                        <span class=""info-box-number"">760</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
            <div class=""col-12 col-sm-6 col-");
            WriteLiteral(@"md-3"">
                <div class=""info-box mb-3"">
                    <span class=""info-box-icon bg-warning elevation-1""><i class=""fas fa-users""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">New Members</span>
                        <span class=""info-box-number"">2,000</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
            </div>
            <!-- /.col -->
        </div>

        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Simple Full Width Table</h3>

                        <div class=""card-tools"">
                            <ul class=""pagination pagination-sm float-right"">
                                <li class=""page-item""><a class=""page-link"" href=""#"">«</a></li>
                                <li class");
            WriteLiteral(@"=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">»</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body p-0"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th style=""width: 10px"">#</th>
                                    <th>Task</th>
                                    <th>Progress</th>
                                    <th style=""width: 40px"">Label</th>
                                </tr>
                            </thead>
                            <tbody>
                              ");
            WriteLiteral(@"  <tr>
                                    <td>1.</td>
                                    <td>Update software</td>
                                    <td>
                                        <div class=""progress progress-xs"">
                                            <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                                        </div>
                                    </td>
                                    <td><span class=""badge bg-danger"">55%</span></td>
                                </tr>
                                <tr>
                                    <td>2.</td>
                                    <td>Clean database</td>
                                    <td>
                                        <div class=""progress progress-xs"">
                                            <div class=""progress-bar bg-warning"" style=""width: 70%""></div>
                                        </div>
                                    </td>
      ");
            WriteLiteral(@"                              <td><span class=""badge bg-warning"">70%</span></td>
                                </tr>
                                <tr>
                                    <td>3.</td>
                                    <td>Cron job running</td>
                                    <td>
                                        <div class=""progress progress-xs progress-striped active"">
                                            <div class=""progress-bar bg-primary"" style=""width: 30%""></div>
                                        </div>
                                    </td>
                                    <td><span class=""badge bg-primary"">30%</span></td>
                                </tr>
                                <tr>
                                    <td>4.</td>
                                    <td>Fix and squish bugs</td>
                                    <td>
                                        <div class=""progress progress-xs progress-striped active"">
       ");
            WriteLiteral(@"                                     <div class=""progress-bar bg-success"" style=""width: 90%""></div>
                                        </div>
                                    </td>
                                    <td><span class=""badge bg-success"">90%</span></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
            </div>

        </div>

       
    </div><!-- /.container-fluid -->
</section>
<!-- /.content -->");
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
