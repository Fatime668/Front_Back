#pragma checksum "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2e7dd9554306fe3afd20316a0f07479597c201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\user\source\repos\project\project\Views\_ViewImports.cshtml"
using project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\project\project\Views\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2e7dd9554306fe3afd20316a0f07479597c201", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fcded930a32da9b72a26bc2560ba7528a8701cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- Top start -->
<section id=""top-header"">
    <div class=""top"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-md-6 col-lg-6"">
                    <div class=""contact"">
                        <ul class=""d-flex m-0 p-0"">
                            <li><i class=""fa-solid fa-envelope""></i><a href=""#"">");
#nullable restore
#line 10 "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml"
                                                                           Write(Model.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"ms-5\">\r\n                                <i class=\"fa-solid fa-mobile-screen-button\"></i><a href=\"#\">");
#nullable restore
#line 12 "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml"
                                                                                       Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="" col-md-6 col-lg-6"">
                    <div class=""icons"">
                        <ul class=""d-flex justify-content-end m-0 p-0"">
");
#nullable restore
#line 21 "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml"
                             foreach (var item in Model.SocialMedias)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"ms-3\"><a");
            BeginWriteAttribute("href", " href=\"", 1061, "\"", 1081, 1);
#nullable restore
#line 23 "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1068, item.IconUrl, 1068, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1085, "\"", 1103, 1);
#nullable restore
#line 23 "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1093, item.Icon, 1093, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\project\project\Views\Shared\Components\Header\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Top end -->
<!-- Header Start -->
<header>
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-3"">
                <div class=""nav-logo"">
                    <h1><a href=""#"">Eterna</a></h1>
                </div>
            </div>
            <div class=""col-lg-9"">
                <nav>
                    <ul class=""menu d-flex p-0 m-0 justify-content-end"">
                        <li><a href=""#"">home</a></li>
                        <li><a href=""#"">about</a></li>
                        <li><a class=""active"" href=""#"">services</a></li>
                        <li><a href=""#"">portfolio</a></li>
                        <li><a href=""#"">team</a></li>
                        <li><a href=""#"">pricing</a></li>
                        <li><a href=""#"">blog</a></li>
                        <li class=""d");
            WriteLiteral(@"ropdown"">
                            <a href=""#"">drop down<i class=""fa-solid fa-angle-down""></i></a>
                            <ul class=""downmenu m-0 p-0"">
                                <li><a href=""#"">Drop Down 1</a></li>
                                <li class=""dropmenu"">
                                    <a href=""#"">
                                        Deep Drop Down<i class=""fa-solid fa-angle-right""></i>
                                    </a>
                                    <ul class=""dripmenu m-0 p-0"">
                                        <li><a href=""#"">Drop Down 1</a></li>
                                        <li><a href=""#"">Deep Drop Down</a></li>
                                        <li><a href=""#"">Drop Down 3</a></li>
                                        <li><a href=""#"">Drop Down 4</a></li>
                                        <li><a href=""#"">Drop Down 5</a></li>
                                    </ul>
                                </li>
       ");
            WriteLiteral(@"                         <li><a href=""#"">Drop Down 3</a></li>
                                <li><a href=""#"">Drop Down 4</a></li>
                                <li><a href=""#"">Drop Down 5</a></li>
                            </ul>
                        </li>
                        <li><a href=""#"">contact</a></li>
                    </ul>
                </nav>
            </div>
            <div class=""col-lg-2 d-flex justify-content-end align-items-center navbar"">
                <i class=""fa-solid fa-bars d-none""></i>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""nav-pane"">
            <div class=""close"">
                <i class=""fa-solid fa-x""></i>
            </div>
            <div class=""pane"">
                <ul>
                    <li><a href=""#"">home</a></li>
                    <li><a href=""#"">about</a></li>
                    <li><a href=""#"">service</a></li>
                    <li><a href=""#"">portfolio</a></li>");
            WriteLiteral(@"
                    <li><a href=""#"">pricing</a></li>
                    <li><a href=""#"">blog</a></li>
                    <li>
                        <a href=""#"">drop down</a>
                    </li>
                    <li><a href=""#"">contact</a></li>
                </ul>
            </div>
        </div>
    </div>
</header>
<!-- Header End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
