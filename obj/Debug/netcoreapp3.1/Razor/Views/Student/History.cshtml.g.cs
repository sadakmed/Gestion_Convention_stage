#pragma checksum "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026409bfed67a53d7817777fc3b37eba55d05f1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_History), @"mvc.1.0.view", @"/Views/Student/History.cshtml")]
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
#line 1 "/home/akura/Software/Gestion_Convention_stage/Views/_ViewImports.cshtml"
using Gestion_Convention_stage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/akura/Software/Gestion_Convention_stage/Views/_ViewImports.cshtml"
using Gestion_Convention_stage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"026409bfed67a53d7817777fc3b37eba55d05f1b", @"/Views/Student/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e71b1612246a5cbcf127acedd1f93cc177c4b54", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Demande>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
  
    ViewData["Title"] = "History";
    Layout="_Layout_student";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<script\r\n  src=\"https://code.jquery.com/jquery-3.4.1.min.js\"\r\n  integrity=\"sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=\"\r\n  crossorigin=\"anonymous\"></script>\r\n\r\n\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 292, "\"", 300, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n<table class=\"table\">\r\n  <thead >\r\n    <tr>\r\n      <th >Academic Supervisor</th>\r\n      <th >Company Supervisor</th>\r\n      <th >Company</th>\r\n      <th>Status</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n    \r\n\r\n\r\n");
#nullable restore
#line 37 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
     foreach(var item in Model)
{   
   


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 42 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
       Write(item.intern_supervisor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 43 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
       Write(item.extern_supervisor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
       Write(item.company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"status\">");
#nullable restore
#line 45 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
                      Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 48 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n  </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n<script");
            BeginWriteAttribute("src", " src=\"", 812, "\"", 885, 1);
#nullable restore
#line 61 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
WriteAttributeValue("", 818, Url.Content("~/lib/jquery-validation/dist/jquery.validate.min.js"), 818, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script> \r\n<script");
            BeginWriteAttribute("src", " src=\"", 929, "\"", 1021, 1);
#nullable restore
#line 62 "/home/akura/Software/Gestion_Convention_stage/Views/Student/History.cshtml"
WriteAttributeValue("", 935, Url.Content("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), 935, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text/javascript""></script> 
<script>
$("".status"").each(function(){

    var status=$(this).text();
    switch(status){
        case ""-1"":    $(this).text(""Refused"");break;
        case ""0"": $(this).text(""Pending"");break;
        case ""1"":$(this).text(""Accepted"");break;
        default: $(this).text(""Pending"");break;

    }


});


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Demande>> Html { get; private set; }
    }
}
#pragma warning restore 1591
