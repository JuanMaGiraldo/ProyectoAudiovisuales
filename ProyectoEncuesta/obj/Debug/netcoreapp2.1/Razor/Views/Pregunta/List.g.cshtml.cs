#pragma checksum "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34a8d20fc12fb27012d7dd2815fd2d6ded1b493"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pregunta_List), @"mvc.1.0.view", @"/Views/Pregunta/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pregunta/List.cshtml", typeof(AspNetCore.Views_Pregunta_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34a8d20fc12fb27012d7dd2815fd2d6ded1b493", @"/Views/Pregunta/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd6283ade0965df40995a626f9206f94ae8919a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pregunta_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoEncuesta.Models.PreguntaModel>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(101, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "955d0c3267dc430095c0f1f38cb8f820", async() => {
                BeginContext(152, 10, true);
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
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 46, false);
#line 16 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPregunta));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 55, false);
#line 19 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPreguntaPrincipal));

#line default
#line hidden
            EndContext();
            BeginContext(416, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(472, 45, false);
#line 22 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Enunciado));

#line default
#line hidden
            EndContext();
            BeginContext(517, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(573, 42, false);
#line 25 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IdTipo));

#line default
#line hidden
            EndContext();
            BeginContext(615, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(733, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(782, 45, false);
#line 34 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdPregunta));

#line default
#line hidden
            EndContext();
            BeginContext(827, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(883, 54, false);
#line 37 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdPreguntaPrincipal));

#line default
#line hidden
            EndContext();
            BeginContext(937, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(993, 44, false);
#line 40 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Enunciado));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1093, 41, false);
#line 43 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdTipo));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1190, 65, false);
#line 46 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1276, 71, false);
#line 47 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1368, 69, false);
#line 48 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Juan Manuel\Desktop\ProyectoEncuesta\ProyectoEncuesta\Views\Pregunta\List.cshtml"
}

#line default
#line hidden
            BeginContext(1476, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoEncuesta.Models.PreguntaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
