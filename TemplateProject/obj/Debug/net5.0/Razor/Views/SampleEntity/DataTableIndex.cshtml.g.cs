#pragma checksum "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2902aff91969f84f9ca516ee4b8f53e6bc9cb212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SampleEntity_DataTableIndex), @"mvc.1.0.view", @"/Views/SampleEntity/DataTableIndex.cshtml")]
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
#line 1 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\_ViewImports.cshtml"
using TemplateProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\_ViewImports.cshtml"
using TemplateProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2902aff91969f84f9ca516ee4b8f53e6bc9cb212", @"/Views/SampleEntity/DataTableIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969cd86bf932d37be447a441683b6878b42a78a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SampleEntity_DataTableIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SampleEntity>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
  
	ViewBag.Title = "title";
	Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Styles -->
<link href=""/lib/DataTable/css/lib/font-awesome.min.css"" rel=""stylesheet"">
<link href=""/lib/DataTable/css/lib/themify-icons.css"" rel=""stylesheet"">
<link href=""/lib/DataTable/css/lib/data-table/buttons.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""/lib/DataTable/css/lib/menubar/sidebar.css"" rel=""stylesheet"">
<link href=""/lib/DataTable/css/lib/bootstrap.min.css"" rel=""stylesheet"">
<link href=""/lib/DataTable/css/lib/helper.css"" rel=""stylesheet"">
<link href=""/lib/DataTable/css/style.css"" rel=""stylesheet"">

<div class=""content-wrap"">
	<div class=""main"">
		<div class=""container-fluid"">
			<section id=""main-content"">
				<div class=""row"">
					<div class=""col-lg-12"">
						<div class=""card"">
							<div class=""bootstrap-data-table-panel"">
								<div class=""table-responsive"">
									<table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
										<thead>
											<tr>
												<th>Id</th>
												<th>Name</th>
												<th>Des");
            WriteLiteral("cription</th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<th>Status</th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<th>CreateDate</th>\r\n\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t\t</thead>\r\n\t\t\t\t\t\t\t\t\t\t<tbody>\r\n");
#nullable restore
#line 38 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
                                             foreach (var item in Model)
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 41 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 42 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 43 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 44 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
                                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 45 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
                                                   Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 47 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\DataTableIndex.cshtml"
											}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"										</tbody>
									</table>
								</div>
							</div>
						</div>
						<!-- /# card -->
					</div>
					<!-- /# column -->
				</div>
				<!-- /# row -->
			</section>
		</div>
	</div>
</div>




<!-- sidebar -->
<!-- bootstrap -->

<script src=""/lib/DataTable/js/scripts.js""></script>
<!-- scripit init-->
<script src=""/lib/DataTable/js/lib/data-table/datatables.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/dataTables.buttons.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/buttons.flash.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/jszip.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/pdfmake.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/vfs_fonts.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/buttons.html5.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/buttons.print.min.js""></script>
<script src=""/lib/DataTable/js/lib/data-table/datatables-init.js""><");
            WriteLiteral("/script>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SampleEntity>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
