#pragma checksum "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43503390d9e0bf0165f42a2584f8e744f994084c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Forms), @"mvc.1.0.view", @"/Views/Home/Forms.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Forms.cshtml", typeof(AspNetCore.Views_Home_Forms))]
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
#line 1 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
using FormCreatorMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43503390d9e0bf0165f42a2584f8e744f994084c", @"/Views/Home/Forms.cshtml")]
    public class Views_Home_Forms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
  
    ViewData["Title"] = "Form Görüntüleme Sayfası";
    Layout = "_Layout";

#line default
#line hidden
#line 7 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
 if (Model.Form != null)
{

#line default
#line hidden
            BeginContext(167, 252, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2\">\r\n            <label class=\"font-weight-bold\">ID: </label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input class=\"w-75\" id=\"formName\" type=\"text\" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 419, "", 440, 1);
#line 15 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 426, Model.Form.ID, 426, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(440, 268, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">Form İsmi : </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 708, "", 731, 1);
#line 23 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 715, Model.Form.Name, 715, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(731, 267, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">Açıklama : </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 998, "", 1028, 1);
#line 31 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 1005, Model.Form.Description, 1005, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1028, 277, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">Oluşturulma Tarihi : </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 1305, "", 1333, 1);
#line 39 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 1312, Model.Form.CreatedAt, 1312, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1333, 270, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">Oluşturan ID: </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 1603, "", 1631, 1);
#line 47 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 1610, Model.Form.CreatedBy, 1610, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 261, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">İsim </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 1892, "", 1922, 1);
#line 55 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 1899, Model.Form.CreatorName, 1899, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1922, 265, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">Soy İsim </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 2187, "", 2221, 1);
#line 63 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 2194, Model.Form.CreatorLastName, 2194, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2221, 260, true);
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-2"">
            <label class=""font-weight-bold"">Yaş </label>
        </div>
        <div class=""col-md-6"">
            <input class=""w-75"" id=""formName"" type=""text"" required");
            EndContext();
            BeginWriteAttribute("value", " value=", 2481, "", 2510, 1);
#line 71 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
WriteAttributeValue("", 2488, Model.Form.CreatorAge, 2488, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2510, 41, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 75 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2562, 17, true);
            WriteLiteral(" <h2>blank</h2>\r\n");
            EndContext();
#line 79 "/Users/haktanenesbicer/Projects/FormCreator/src/FormCreatorMVC/Views/Home/Forms.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591