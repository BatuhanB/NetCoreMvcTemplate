#pragma checksum "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c451a23f0ec5c4f496897951f3c0afe935f5eba"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c451a23f0ec5c4f496897951f3c0afe935f5eba", @"/Views/SampleEntity/Index.cshtml")]
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
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 36 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 980, "\"", 1016, 2);
            WriteAttributeValue("", 987, "/SampleEntity/Delete/", 987, 21, true);
#nullable restore
#line 37 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
WriteAttributeValue("", 1008, item.Id, 1008, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1070, "\"", 1111, 2);
            WriteAttributeValue("", 1077, "/SampleEntity/ChangeFalse/", 1077, 26, true);
#nullable restore
#line 38 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
WriteAttributeValue("", 1103, item.Id, 1103, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">To Passive</a></td>\r\n\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1169, "\"", 1205, 2);
            WriteAttributeValue("", 1176, "/SampleEntity/Update/", 1176, 21, true);
#nullable restore
#line 39 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
WriteAttributeValue("", 1197, item.Id, 1197, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Update</a></td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n");
#nullable restore
#line 42 "C:\Users\balib\source\repos\TemplateProject\TemplateProject\Views\SampleEntity\Index.cshtml"
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
