#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class PerPageSelector : Hangfire.Dashboard.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("\r\n");


            
            #line 5 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
 if (_pager.TotalPageCount > 1)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"btn-group paginator pull-right hidden-xs\">\r\n        <a href=\"");


            
            #line 8 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
            Write(_pager.PageUrl(_pager.CurrentPage > 1 ? _pager.CurrentPage - 1 : 0));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default btn-sm ");


            
            #line 8 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
                                                                                                                 Write(_pager.CurrentPage == 1 ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 9 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
       Write(Strings.Paginator_Prev);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n        <a href=\"");


            
            #line 11 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
            Write(_pager.PageUrl(_pager.CurrentPage < _pager.TotalPageCount ? _pager.CurrentPage + 1 : 0));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default btn-sm ");


            
            #line 11 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
                                                                                                                                     Write(_pager.CurrentPage == _pager.TotalPageCount ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 12 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
       Write(Strings.Paginator_Next);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n    </div>\r\n");


            
            #line 15 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"btn-group pull-right paginator\">\r\n");


            
            #line 17 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
         foreach (var count in new[] { 10, 20, 50, 100, 500, 1000, 5000 })
        {

            
            #line default
            #line hidden
WriteLiteral("            <a class=\"btn btn-sm btn-default ");


            
            #line 19 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
                                         Write(count == _pager.RecordsPerPage ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 19 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
                                                                                             Write(count > 999 ? "visible-lg" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                   href=\"");


            
            #line 20 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
                    Write(_pager.RecordsPerPageUrl(count));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 20 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
                                                      Write(count.ToString("N0"));

            
            #line default
            #line hidden
WriteLiteral("</a>    \r\n");


            
            #line 21 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <div class=\"btn-toolbar-spacer pull-right hidden-xs\"></div>\r\n    " +
"<div class=\"btn-toolbar-label btn-toolbar-label-sm pull-right hidden-xs\">\r\n     " +
"   ");


            
            #line 25 "..\..\Dashboard\Pages\_PerPageSelector.cshtml"
   Write(Strings.PerPageSelector_ItemsPerPage);

            
            #line default
            #line hidden
WriteLiteral(":\r\n    </div>\r\n");


        }
    }
}
#pragma warning restore 1591