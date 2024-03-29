#pragma checksum "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "885be937b2323e05637ac86b18f8f78568c4d23b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Index), @"mvc.1.0.view", @"/Views/Wedding/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Index.cshtml", typeof(AspNetCore.Views_Wedding_Index))]
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
#line 1 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#line 1 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"885be937b2323e05637ac86b18f8f78568c4d23b", @"/Views/Wedding/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(70, 425, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f09e03688f74e10a3ac2b4701baa192", async() => {
                BeginContext(76, 412, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Dashboard</title>
");
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
            BeginContext(495, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(497, 2229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123e4090be41455abc635d6c24736966", async() => {
                BeginContext(503, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(531, 391, true);
                WriteLiteral(@"    <h1>Welcome to Wedding Planner!</h1>
    <a style=""float: right;"" href=""/logout"">Logout</a>
    <table class=""table table-striped"">
        <thead>
            <tr>
            <th scope=""col"">Wedding</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">Guests</th>
            <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 25 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
             foreach (var wedding in Model)
            {

#line default
#line hidden
                BeginContext(982, 48, true);
                WriteLiteral("                <tr>\r\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1030, "\"", 1065, 2);
                WriteAttributeValue("", 1037, "/weddings/", 1037, 10, true);
#line 28 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
WriteAttributeValue("", 1047, wedding.WeddingId, 1047, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1066, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1068, 17, false);
#line 28 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                                                          Write(wedding.WedderOne);

#line default
#line hidden
                EndContext();
                BeginContext(1085, 3, true);
                WriteLiteral(" & ");
                EndContext();
                BeginContext(1089, 17, false);
#line 28 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                                                                               Write(wedding.WedderTwo);

#line default
#line hidden
                EndContext();
                BeginContext(1106, 35, true);
                WriteLiteral("</a></td>\r\n                    <td>");
                EndContext();
                BeginContext(1142, 35, false);
#line 29 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                   Write(wedding.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1177, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1209, 23, false);
#line 30 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                   Write(wedding.Attendees.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1232, 33, true);
                WriteLiteral("</td>\r\n                    <td>\r\n");
                EndContext();
#line 32 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                          
                            string Id = @Context.Session.GetString("UserID");
                            int uid = Convert.ToInt32(Id);
                            if(wedding.CreatorId == uid)
                            {

#line default
#line hidden
                BeginContext(1521, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1555, "\"", 1588, 2);
                WriteAttributeValue("", 1562, "/delete/", 1562, 8, true);
#line 37 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
WriteAttributeValue("", 1570, wedding.WeddingId, 1570, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1589, 30, true);
                WriteLiteral("><button>Delete</button></a>\r\n");
                EndContext();
#line 38 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                            }
                            
                            bool contained = false;
                            foreach(var g in wedding.Attendees)
                            {
                                if(g.UserId == uid)
                                {
                                    contained = true;
                                }
                            }
                            if(contained == true && wedding.CreatorId != uid)
                            {

#line default
#line hidden
                BeginContext(2148, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2182, "\"", 2215, 2);
                WriteAttributeValue("", 2189, "/unrsvp/", 2189, 8, true);
#line 50 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
WriteAttributeValue("", 2197, wedding.WeddingId, 2197, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2216, 31, true);
                WriteLiteral("><button>Un-RSVP</button></a>\r\n");
                EndContext();
#line 51 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                            }
                            if(contained == false && wedding.CreatorId != uid)
                            {

#line default
#line hidden
                BeginContext(2389, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2423, "\"", 2454, 2);
                WriteAttributeValue("", 2430, "/rsvp/", 2430, 6, true);
#line 54 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
WriteAttributeValue("", 2436, wedding.WeddingId, 2436, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2455, 28, true);
                WriteLiteral("><button>RSVP</button></a>\r\n");
                EndContext();
#line 55 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(2541, 50, true);
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 59 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/WeddingPlanner/Views/Wedding/Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2606, 113, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/new\"><Button class=\"btn btn-primary\">Add New Wedding</Button></a>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2726, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
