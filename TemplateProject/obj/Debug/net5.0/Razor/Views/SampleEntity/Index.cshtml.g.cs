#pragma checksum "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c87c9e7d9dfc17f3426c604091cb8ebf61b2cf5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SampleEntity_Index), @"mvc.1.0.view", @"/Views/SampleEntity/Index.cshtml")]
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
#line 1 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c87c9e7d9dfc17f3426c604091cb8ebf61b2cf5b", @"/Views/SampleEntity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969cd86bf932d37be447a441683b6878b42a78a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SampleEntity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SampleEntity>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"align-content-center\">\r\n\t\t<h1>This is a sample layout page</h1>\r\n\r\n\t\t<p style=\"font-size: 16px\">Response Message: <span style=\"color: red; font-weight: bold;font-size: 14px\">");
#nullable restore
#line 13 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                                                                                                            Write(ViewBag.responseMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>

		<table class=""table "">
			<thead>
				<tr>
					<th>ID</th>
					<th>Name</th>
					<th>Description</th>
					<th>Create Date</th>
					<th>Status</th>
					<th>Delete</th>
					<th>Change To Passive</th>
					<th>Update</th>
				</tr>
			</thead>
");
#nullable restore
#line 28 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tbody>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 34 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 35 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                       Write(DateTime.Parse(@item.CreateDate.ToString(CultureInfo.CurrentCulture)).ToString("yyyy MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                         if (@item.Status)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td style=\"background-color: #43f527\">");
#nullable restore
#line 38 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                                                             Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td style=\"background-color: #ff3629\">");
#nullable restore
#line 42 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                                                             Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1153, "\"", 1189, 2);
            WriteAttributeValue("", 1160, "/SampleEntity/Delete/", 1160, 21, true);
#nullable restore
#line 44 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
WriteAttributeValue("", 1181, item.Id, 1181, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1243, "\"", 1285, 2);
            WriteAttributeValue("", 1250, "/SampleEntity/ChangeStatus/", 1250, 27, true);
#nullable restore
#line 45 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
WriteAttributeValue("", 1277, item.Id, 1277, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Status</a></td>\r\n\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1337, "\"", 1373, 2);
            WriteAttributeValue("", 1344, "/SampleEntity/Update/", 1344, 21, true);
#nullable restore
#line 46 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
WriteAttributeValue("", 1365, item.Id, 1365, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Update</a></td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n");
#nullable restore
#line 49 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</table>\r\n\t\t<a href=\"/SampleEntity/Add\" class=\"btn btn-success\">Add</a>\r\n\t</div>\r\n</div>");
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
