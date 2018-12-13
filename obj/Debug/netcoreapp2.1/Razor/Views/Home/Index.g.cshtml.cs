#pragma checksum "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "977d7296ba1100be8d090769136c13cda037dbcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 2 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\_ViewImports.cshtml"
using DotNetCoreMvcPractices;

#line default
#line hidden
#line 2 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\_ViewImports.cshtml"
using DotNetCoreMvcPractices.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d7296ba1100be8d090769136c13cda037dbcf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2709aa2c4cac1ac91f188f2593f5a39c764eae86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DotNetCoreMvcPractices.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Carousel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(117, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Carausel", async() => {
                BeginContext(140, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(143, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8210bbf525e0408094778d181432e577", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(171, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(178, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 15 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
  
	var featuredProducts = Model.Where(p => p.MarketDate > DateTime.Today);
	var latestProducts = Model.OrderBy(p => p.CreatedDate).Take(6).ToList();

#line default
#line hidden
#line 19 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
 if (featuredProducts.Any())
{

#line default
#line hidden
            BeginContext(371, 80, true);
            WriteLiteral("\t<div class=\"well well-small\">\r\n\t\t<h4>Gelecek Ürünler <small class=\"pull-right\">");
            EndContext();
            BeginContext(452, 24, false);
#line 22 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                                                 Write(featuredProducts.Count());

#line default
#line hidden
            EndContext();
            BeginContext(476, 140, true);
            WriteLiteral("+ gelecek ürün </small></h4>\r\n\t\t<div class=\"row-fluid\">\r\n\t\t\t<div id=\"featured\" class=\"carousel slide\">\r\n\t\t\t\t<div class=\"carousel-inner\">\r\n\r\n");
            EndContext();
#line 27 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                      
						var itemPerSlide = 4;
						var slideCount = (int)Math.Ceiling((decimal)featuredProducts.Count() / itemPerSlide);
					

#line default
#line hidden
            BeginContext(755, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                     for (int i = 0; i < slideCount; i++)
					{
						var elements = Model.Skip(i * itemPerSlide).Take(itemPerSlide).ToList();

#line default
#line hidden
            BeginContext(889, 10, true);
            WriteLiteral("\t\t\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("class", " class=", 899, "", 939, 1);
#line 35 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
WriteAttributeValue("", 906, i==0 ? "item active" : "item" , 906, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(939, 35, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t<ul class=\"thumbnails\">\r\n");
            EndContext();
#line 37 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                                 foreach (var item in elements)
								{
									

#line default
#line hidden
            BeginContext(1036, 85, false);
#line 39 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                               Write(await Component.InvokeAsync("Product", new { product = item, viewName = "Featured" }));

#line default
#line hidden
            EndContext();
#line 39 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                                                                                                                          
								}

#line default
#line hidden
            BeginContext(1134, 30, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 44 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(1172, 203, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\t\t\t<a class=\"left carousel-control\" href=\"#featured\" data-slide=\"prev\">‹</a>\r\n\t\t\t<a class=\"right carousel-control\" href=\"#featured\" data-slide=\"next\">›</a>\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 53 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"

}

#line default
#line hidden
            BeginContext(1380, 60, true);
            WriteLiteral("\r\n\r\n<h4>Son Eklenen Ürünler </h4>\r\n<ul class=\"thumbnails\">\r\n");
            EndContext();
#line 59 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
     foreach (var item in latestProducts)
	{
		

#line default
#line hidden
            BeginContext(1487, 86, false);
#line 61 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("Product", new { product = item, viewName = "Thumbnail" }));

#line default
#line hidden
            EndContext();
#line 61 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
                                                                                               
	}

#line default
#line hidden
            BeginContext(1579, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1608, 313, true);
                WriteLiteral(@"

	<script>

		$("".add-to-cart-action"").click(function (e) {

			e.preventDefault();
			$.ajax({
				url: $(this).attr(""href""), // comma here instead of semicolon
				success: function () {
					alert(""Value Added""); // or any other indication if you want to show
				}

			});

		});
	</script>
");
                EndContext();
            }
            );
            BeginContext(1924, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DotNetCoreMvcPractices.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
