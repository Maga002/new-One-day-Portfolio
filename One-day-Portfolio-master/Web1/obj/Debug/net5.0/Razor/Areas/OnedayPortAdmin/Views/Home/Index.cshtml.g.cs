#pragma checksum "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a78216595beb6b38c921302aa447d25c5c6cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OnedayPortAdmin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/OnedayPortAdmin/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\_ViewImports.cshtml"
using Web1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\_ViewImports.cshtml"
using Web1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\_ViewImports.cshtml"
using Web1.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a78216595beb6b38c921302aa447d25c5c6cfa", @"/Areas/OnedayPortAdmin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8e6ae676d81679462fa75759e28cda1c650e45", @"/Areas/OnedayPortAdmin/Views/_ViewImports.cshtml")]
    public class Areas_OnedayPortAdmin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Section 1</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">First Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">SubHeader<i class=""mdi mdi-chevron-down""></i></th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 19 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.SubHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>
<h2>Section 2</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">PhotoURL<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">Description 1<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">Description 2<i class=""mdi mdi-chevron-down""></i></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                    ");
            WriteLiteral("    <td>");
#nullable restore
#line 48 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect2s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect2s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect2s.PhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect2s.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect2s.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>

<h2 class=""mt-5"">Section 3</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">First Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">SubHeader<i class=""mdi mdi-chevron-down""></i></th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
");
#nullable restore
#line 78 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                         foreach (var item in Model.Sect3s)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 80 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 81 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 82 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>

<h2 class=""mt-5"">Section 4</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">First Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">SubHeader<i class=""mdi mdi-chevron-down""></i></th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 110 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 111 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 112 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.SubHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>

<h2 class=""mt-5"">Section 5</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">First Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">SubHeader<i class=""mdi mdi-chevron-down""></i></th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 139 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 140 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 141 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.SubHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>

<h2 class=""mt-5"">Section 6</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">First Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">SubHeader<i class=""mdi mdi-chevron-down""></i></th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 168 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 169 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 170 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.SubHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                    </tr>

                </tbody>
            </table>
        </div>
    </div>
</div>

<h2 class=""mt-5"">Section 7</h2>
<div class=""card-body"">
    <h4 class=""card-title"">Basic Sortable Table</h4>
    <p class=""page-description"">Add class</p>
    <div class=""row"">
        <div class=""table-sorter-wrapper col-lg-12 table-responsive"">
            <table id=""sortable-table-1"" class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th class=""sortStyle"">First Name<i class=""mdi mdi-chevron-down""></i></th>
                        <th class=""sortStyle"">SubHeader<i class=""mdi mdi-chevron-down""></i></th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 197 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 198 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 199 "C:\Users\User\Desktop\One-day-Portfolio-master\One-day-Portfolio-master\Web1\Areas\OnedayPortAdmin\Views\Home\Index.cshtml"
                       Write(Model.Sect1s.SubHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591