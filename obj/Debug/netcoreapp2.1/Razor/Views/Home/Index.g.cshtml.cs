#pragma checksum "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c506444078d7411bbfebc137a8c618898155c007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\_ViewImports.cshtml"
using DotNetCoreMvcPractices;

#line default
#line hidden
#line 2 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\_ViewImports.cshtml"
using DotNetCoreMvcPractices.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c506444078d7411bbfebc137a8c618898155c007", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2709aa2c4cac1ac91f188f2593f5a39c764eae86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\ExternalProjects\DotNetCorePractice\Course\DotNetCoreMvcPractices\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Carausel", async() => {
                BeginContext(71, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(77, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2656c312e294d4299cfa6a40e4bb7a1", async() => {
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
                BeginContext(105, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(112, 14301, true);
            WriteLiteral(@"
<h1>Index Page</h1>

<div class=""well well-small"">
    <h4>Featured Products <small class=""pull-right"">200+ featured products</small></h4>
    <div class=""row-fluid"">
        <div id=""featured"" class=""carousel slide"">
            <div class=""carousel-inner"">
                <div class=""item active"">
                    <ul class=""thumbnails"">
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <i class=""tag""></i>
                                <a href=""product_details.html""><img src=""themes/images/products/b1.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">");
            WriteLiteral(@"
                            <div class=""thumbnail"">
                                <i class=""tag""></i>
                                <a href=""product_details.html""><img src=""themes/images/products/b2.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <i class=""tag""></i>
                                <a href=""product_details.html""><img src=""themes/images/products/b3.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href");
            WriteLiteral(@"=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <i class=""tag""></i>
                                <a href=""product_details.html""><img src=""themes/images/products/b4.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class=""item"">
                    <ul class=""thumbnails"">
                        <li class=""span3"">
                            <div cla");
            WriteLiteral(@"ss=""thumbnail"">
                                <i class=""tag""></i>
                                <a href=""product_details.html""><img src=""themes/images/products/5.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <i class=""tag""></i>
                                <a href=""product_details.html""><img src=""themes/images/products/6.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span c");
            WriteLiteral(@"lass=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/7.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/8.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h");
            WriteLiteral(@"5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class=""item"">
                    <ul class=""thumbnails"">
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/9.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
          ");
            WriteLiteral(@"                  <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/10.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/11.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>");
            WriteLiteral(@"
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/1.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class=""item"">
                    <ul class=""thumbnails"">
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/2.jpg"" alt=""""></a>
                                <div cl");
            WriteLiteral(@"ass=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/3.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a ");
            WriteLiteral(@"href=""product_details.html""><img src=""themes/images/products/4.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
                        <li class=""span3"">
                            <div class=""thumbnail"">
                                <a href=""product_details.html""><img src=""themes/images/products/5.jpg"" alt=""""></a>
                                <div class=""caption"">
                                    <h5>Product name</h5>
                                    <h4><a class=""btn"" href=""product_details.html"">VIEW</a> <span class=""pull-right"">$222.00</span></h4>
                                </div>
                            </div>
                        </li>
            ");
            WriteLiteral(@"        </ul>
                </div>
            </div>
            <a class=""left carousel-control"" href=""#featured"" data-slide=""prev"">‹</a>
            <a class=""right carousel-control"" href=""#featured"" data-slide=""next"">›</a>
        </div>
    </div>
</div>
<h4>Latest Products </h4>
<ul class=""thumbnails"">
    <li class=""span3"">
        <div class=""thumbnail"">
            <a href=""product_details.html""><img src=""themes/images/products/6.jpg"" alt="""" /></a>
            <div class=""caption"">
                <h5>Product name</h5>
                <p>
                    Lorem Ipsum is simply dummy text.
                </p>

                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div>
    </li>
    <li class=""span3"">
        <div class=""thumbnail"">
            <a href=""p");
            WriteLiteral(@"roduct_details.html""><img src=""themes/images/products/7.jpg"" alt="""" /></a>
            <div class=""caption"">
                <h5>Product name</h5>
                <p>
                    Lorem Ipsum is simply dummy text.
                </p>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div>
    </li>
    <li class=""span3"">
        <div class=""thumbnail"">
            <a href=""product_details.html""><img src=""themes/images/products/8.jpg"" alt="""" /></a>
            <div class=""caption"">
                <h5>Product name</h5>
                <p>
                    Lorem Ipsum is simply dummy text.
                </p>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <");
            WriteLiteral(@"i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div>
    </li>
    <li class=""span3"">
        <div class=""thumbnail"">
            <a href=""product_details.html""><img src=""themes/images/products/9.jpg"" alt="""" /></a>
            <div class=""caption"">
                <h5>Product name</h5>
                <p>
                    Lorem Ipsum is simply dummy text.
                </p>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div>
    </li>
    <li class=""span3"">
        <div class=""thumbnail"">
            <a href=""product_details.html""><img src=""themes/images/products/10.jpg"" alt="""" /></a>
            <div class=""caption"">
                <h5>Product name</h5>
                <p>
             ");
            WriteLiteral(@"       Lorem Ipsum is simply dummy text.
                </p>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div>
    </li>
    <li class=""span3"">
        <div class=""thumbnail"">
            <a href=""product_details.html""><img src=""themes/images/products/11.jpg"" alt="""" /></a>
            <div class=""caption"">
                <h5>Product name</h5>
                <p>
                    Lorem Ipsum is simply dummy text.
                </p>
                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">$222.00</a></h4>
            </div>
        </div>
    </li>
</ul>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
