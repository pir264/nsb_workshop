#pragma checksum "C:\Users\pwind\Documents\GitHub\nsb_workshop\Oefening1\ClientUI\Views\Shared\_LicenseForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "423aeeca36e669dcc227610d34136c232bbd847c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LicenseForm), @"mvc.1.0.view", @"/Views/Shared/_LicenseForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423aeeca36e669dcc227610d34136c232bbd847c", @"/Views/Shared/_LicenseForm.cshtml")]
    public class Views_Shared__LicenseForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 4, "\"", 36, 2);
            WriteAttributeValue("", 12, "col-md-", 12, 7, true);
#line 1 "C:\Users\pwind\Documents\GitHub\nsb_workshop\Oefening1\ClientUI\Views\Shared\_LicenseForm.cshtml"
WriteAttributeValue("", 19, Model.RightWidth, 19, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""card my-4"">
        <h5 class=""card-header"">Get your free development license</h5>
        <div class=""card-body"">
            <p>Are you getting a sense of how NServiceBus can improve your system architecture?</p>
            <p>The Particular Service Platform (including NServiceBus) is free for development, QA, UAT…basically until you’re running in production, as long as you have a valid development license.</p>
            <p>Get your free development license <b>right now</b>.</p>
            <p class=""text-center"">
                <a id=""license-btn"" href=""_blank"" target=""_blank"" class=""btn btn-lg btn-success"">Get Free License</a>
            </p>
        </div>
    </div>
</div>");
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
