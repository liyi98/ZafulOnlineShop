#pragma checksum "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fcf7bcd27cfc4e75e97b6dbff51eac3e6703c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cart.cshtml", typeof(AspNetCore.Views_Home_Cart))]
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
#line 1 "C:\Users\liyi\source\repos\project1\project1\Views\_ViewImports.cshtml"
using project1;

#line default
#line hidden
#line 2 "C:\Users\liyi\source\repos\project1\project1\Views\_ViewImports.cshtml"
using project1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fcf7bcd27cfc4e75e97b6dbff51eac3e6703c99", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5cc777859ddb072dc9ba748efb6e247b95c7fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project1.Models.CartProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/vendor/jquery/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/vendor/animsition/js/animsition.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/vendor/bootstrap/js/popper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/vendor/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/vendor/select2/select2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var sum = 0.0;
    var user = Context.Request.Cookies["UserId"];


#line default
#line hidden
            BeginContext(197, 20, true);
            WriteLiteral("\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(217, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecebd9c5aa45483eb029b7a678ad2021", async() => {
                BeginContext(223, 133, true);
                WriteLiteral("\r\n    <title>Cart</title>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n  \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(363, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(365, 8971, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d177929c735e407a9d466519421ea054", async() => {
                BeginContext(390, 243, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    <!-- Title Page -->\r\n    <section class=\"bg-title-page p-t-40 p-b-50 flex-col-c-m\" style=\"background-image: url(../images/cart_banner.jpg);\">\r\n        <h2 class=\"l-text2 t-center\">\r\n            Cart\r\n        </h2>\r\n    </section>\r\n");
                EndContext();
#line 27 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
       if (user != null)
        {

#line default
#line hidden
                BeginContext(670, 336, true);
                WriteLiteral(@"            <!-- Cart -->
            <section class=""cart bgwhite p-t-70 p-b-100"">
                <div class=""container"">
                    <!-- Cart item -->
                    <div class=""container-table-cart pos-relative"">
                        <div class=""wrap-table-shopping-cart bgwhite"">
                            ");
                EndContext();
                BeginContext(1006, 3689, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beef8601a2714cf2b0003f9e4a7ae23f", async() => {
                    BeginContext(1072, 613, true);
                    WriteLiteral(@"
                                <table class=""table-shopping-cart"">
                                    <tr class=""table-head"">
                                        <th class=""column-1""></th>
                                        <th class=""column-2"">Product Name</th>
                                        <th class=""column-3"">Price</th>
                                        <th class=""column-4"">Quantity</th>
                                        <th class=""column-5"">Total</th>
                                        <th class=""column-6""></th>
                                    </tr>
");
                    EndContext();
#line 45 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                                     if (ViewData["CartProducts"] != null)
                                    {
                                        var listitem = ViewData["CartProducts"] as List<CartProduct>;

                                        foreach (var cartitem in listitem)
                                        {
                                            var total = cartitem.Product.Price * cartitem.Quantity;
                                            sum = sum + total;

#line default
#line hidden
                    BeginContext(2189, 302, true);
                    WriteLiteral(@"                                            <tr class=""table-row"">
                                                <td class=""column-1"">
                                                    <div class=""cart-img-product b-rad-4 o-f-hidden"">
                                                        <img");
                    EndContext();
                    BeginWriteAttribute("src", " src=\"", 2491, "\"", 2594, 2);
                    WriteAttributeValue("", 2497, "https://aspnetcorestoragestorage.blob.core.windows.net/zaful-pictures/", 2497, 70, true);
#line 56 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2567, cartitem.Product.ImagePath, 2567, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2595, 205, true);
                    WriteLiteral(" alt=\"IMG-PRODUCT\">\r\n                                                    </div>\r\n                                                </td>\r\n                                                <td class=\"column-2\">");
                    EndContext();
                    BeginContext(2801, 28, false);
#line 59 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                                                                Write(cartitem.Product.ProductName);

#line default
#line hidden
                    EndContext();
                    BeginContext(2829, 76, true);
                    WriteLiteral("</td>\r\n                                                <td class=\"column-3\">");
                    EndContext();
                    BeginContext(2906, 22, false);
#line 60 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                                                                Write(cartitem.Product.Price);

#line default
#line hidden
                    EndContext();
                    BeginContext(2928, 624, true);
                    WriteLiteral(@"</td>
                                                <td class=""column-4"">
                                                    <div class=""flex-w bo5 of-hidden w-size17"">
                                                        <button class=""btn-num-product-down color1 flex-c-m size7 bg8 eff2"">
                                                            <i class=""fs-12 fa fa-minus"" aria-hidden=""true""></i>
                                                        </button>

                                                        <input class=""size8 m-text18 t-center num-product"" type=""number"" name=""num-product1""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3552, "\"", 3578, 1);
#line 67 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3560, cartitem.Quantity, 3560, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3579, 493, true);
                    WriteLiteral(@">

                                                        <button class=""btn-num-product-up color1 flex-c-m size7 bg8 eff2"">
                                                            <i class=""fs-12 fa fa-plus"" aria-hidden=""true""></i>
                                                        </button>
                                                    </div>
                                                </td>
                                                <td class=""column-5"">");
                    EndContext();
                    BeginContext(4073, 5, false);
#line 74 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                                                                Write(total);

#line default
#line hidden
                    EndContext();
                    BeginContext(4078, 132, true);
                    WriteLiteral("</td>\r\n\r\n                                                <td class=\"column-6\">\r\n                                                    ");
                    EndContext();
                    BeginContext(4210, 79, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03d1e0c364a443ed887b16220fc8f479", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CartProductId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 77 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                                                                                            WriteLiteral(cartitem.CartProductId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4289, 245, true);
                    WriteLiteral("\r\n                                                    <button type=\"submit\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i></button>\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
                    EndContext();
#line 82 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                                        }
                                    }

#line default
#line hidden
                    BeginContext(4616, 72, true);
                    WriteLiteral("\r\n                                </table>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4695, 1853, true);
                WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""flex-w flex-sb-m p-t-25 p-b-25 bo8 p-l-35 p-r-60 p-lr-15-sm"">
                        <div class=""flex-w flex-m w-full-sm"">
                            <div class=""size11 bo4 m-r-10"">
                                <input class=""sizefull s-text7 p-l-22 p-r-22"" type=""text"" name=""coupon-code"" placeholder=""Coupon Code"">
                            </div>

                            <div class=""size12 trans-0-4 m-t-10 m-b-10 m-r-10"">
                                <!-- Button -->
                                <button class=""flex-c-m sizefull bg1 bo-rad-23 hov1 s-text1 trans-0-4"">
                                    Apply coupon
                                </button>
                            </div>
                        </div>

                        <div class=""size10 trans-0-4 m-t-10 m-b-10"">
                            <!-- Button -->
                            <button class=""flex-c-m s");
                WriteLiteral(@"izefull bg1 bo-rad-23 hov1 s-text1 trans-0-4"">
                                Update Cart
                            </button>
                        </div>
                    </div>

                    <!-- Total -->
                    <div class=""bo9 w-size18 p-l-40 p-r-40 p-t-30 p-b-38 m-t-30 m-r-0 m-l-auto p-lr-15-sm"">
                        <h5 class=""m-text20 p-b-24"">
                            Cart Totals
                        </h5>


                        <!--  -->
                        <div class=""flex-w flex-sb-m p-t-26 p-b-30"">
                            <span class=""m-text22 w-size19 w-full-sm"">
                                Total:
                            </span>

                            <span class=""m-text21 w-size20 w-full-sm"">
                                ");
                EndContext();
                BeginContext(6549, 3, false);
#line 126 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
                           Write(sum);

#line default
#line hidden
                EndContext();
                BeginContext(6552, 97, true);
                WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(6649, 524, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1f955eede1498da799413396904d14", async() => {
                    BeginContext(6710, 456, true);
                    WriteLiteral(@"

                            <div class=""size15 trans-0-4"">
                                <!-- Button -->
                                <input type=""hidden"" value="""">
                                <button class=""flex-c-m sizefull bg1 bo-rad-23 hov1 s-text1 trans-0-4"" type=""submit"">
                                    Proceed to Checkout
                                </button>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7173, 80, true);
                WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </section>\r\n");
                EndContext();
#line 144 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(7289, 115, true);
                WriteLiteral("            <h2>You should login first to proceed...</h2>\r\n            <a href=\"/Home/Login\">Proceed to Login</a>\r\n");
                EndContext();
#line 149 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
        }
    

#line default
#line hidden
                BeginContext(7422, 458, true);
                WriteLiteral(@"
    <!-- Back to top -->
    <div class=""btn-back-to-top bg0-hov"" id=""myBtn"">
        <span class=""symbol-btn-back-to-top"">
            <i class=""fa fa-angle-double-up"" aria-hidden=""true""></i>
        </span>
    </div>

    <!-- Container Selection -->
    <div id=""dropDownSelect1""></div>
    <div id=""dropDownSelect2""></div>



    <!--===============================================================================================-->
    ");
                EndContext();
                BeginContext(7880, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3c91feaad34f29956095f7e701717d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7970, 114, true);
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                EndContext();
                BeginContext(8084, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f6afc85919e4e3f972f80d3546542c8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8179, 114, true);
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                EndContext();
                BeginContext(8293, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e452ad1f58b46579b5b25b135ce3f92", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8379, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8385, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68bd511e64bd435ca6dab85e5d9750ed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8478, 114, true);
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                EndContext();
                BeginContext(8592, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53dcd798874c4d09b744b11e8d135e7f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8678, 454, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $("".selection-1"").select2({
            minimumResultsForSearch: 20,
            dropdownParent: $('#dropDownSelect1')
        });

        $("".selection-2"").select2({
            minimumResultsForSearch: 20,
            dropdownParent: $('#dropDownSelect2')
        });
    </script>
    <!--===============================================================================================-->
    ");
                EndContext();
                BeginContext(9132, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09773ebce3de417caf651caad08ced69", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9176, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 187 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
                BeginContext(9220, 68, true);
                WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            ");
                EndContext();
                BeginContext(9289, 15, false);
#line 190 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(9304, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 192 "C:\Users\liyi\source\repos\project1\project1\Views\Home\Cart.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9336, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<project1.Models.CartProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
