#pragma checksum "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f2a23b8aa082452f86b0a5ce22f6b58f2b4ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tipo_List), @"mvc.1.0.view", @"/Views/Tipo/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tipo/List.cshtml", typeof(AspNetCore.Views_Tipo_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f2a23b8aa082452f86b0a5ce22f6b58f2b4ce3", @"/Views/Tipo/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd6283ade0965df40995a626f9206f94ae8919a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tipo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoEncuesta.Models.TipoModel>>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(97, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d35b4f9ed22410c9f45fb1a79895dee", async() => {
                BeginContext(148, 10, true);
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
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 42, false);
#line 16 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdTipo));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 40, false);
#line 19 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(393, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(511, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(560, 41, false);
#line 28 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdTipo));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(657, 39, false);
#line 31 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(696, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(752, 65, false);
#line 34 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(817, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(838, 71, false);
#line 35 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(909, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(930, 69, false);
#line 36 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(999, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Tipo\List.cshtml"
}

#line default
#line hidden
            BeginContext(1038, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoEncuesta.Models.TipoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
