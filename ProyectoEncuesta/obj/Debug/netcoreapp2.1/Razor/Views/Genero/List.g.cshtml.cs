#pragma checksum "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10dd26546005184dcd62597991eb826e6fd49049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genero_List), @"mvc.1.0.view", @"/Views/Genero/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Genero/List.cshtml", typeof(AspNetCore.Views_Genero_List))]
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
#line 1 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\_ViewImports.cshtml"
using ProyectoEncuesta;

#line default
#line hidden
#line 2 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\_ViewImports.cshtml"
using ProyectoEncuesta.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10dd26546005184dcd62597991eb826e6fd49049", @"/Views/Genero/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd6283ade0965df40995a626f9206f94ae8919a", @"/Views/_ViewImports.cshtml")]
    public class Views_Genero_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoEncuesta.Models.GeneroModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(99, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fe19bc674ef4eb89b61aca2551090cf", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 44, false);
#line 16 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdGenero));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 42, false);
#line 19 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(399, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(517, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(566, 43, false);
#line 28 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdGenero));

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(665, 41, false);
#line 31 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(706, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(762, 65, false);
#line 34 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(827, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(848, 71, false);
#line 35 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(919, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(940, 69, false);
#line 36 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Genero\List.cshtml"
}

#line default
#line hidden
            BeginContext(1048, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoEncuesta.Models.GeneroModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
