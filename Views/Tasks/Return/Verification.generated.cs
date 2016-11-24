﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.Sales;
    
    #line 1 "..\..\Views\Tasks\Return\Verification.cshtml"
    using MixERP.Sales.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Return/Verification.cshtml")]
    public partial class _Views_Tasks_Return_Verification_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Return_Verification_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tasks\Return\Verification.cshtml"
  
    ViewBag.Title = "Sales Return Verification";
    Layout = ViewBag.SalesLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Tasks\Return\Verification.cshtml"
Write(Html.FinancePartialView("Shared/Verification.cshtml", TenantConvention.GetTenant()));

            
            #line default
            #line hidden
WriteLiteral(@"

<script>
    window.prepareVerification({
        Title: ""Sales Return Verification"",
        Book: ""Sales Return"",
        ChecklistUrl : ""/dashboard/sales/tasks/return/checklist/{tranId}"",
        AdviceButtons: [
            {
                Title: ""View Sales Return"",
                Href: ""javascript:void(0);"",
                OnClick: ""showReturn({tranId});""
            }
        ]
    });

    function showReturn(tranId) {
        $("".advice.modal iframe"").attr(""src"", ""/dashboard/reports/source/Areas/MixERP.Sales/Reports/Return.xml?transaction_master_id="" + tranId);

        setTimeout(function () {
            $("".advice.modal"")
                .modal('setting', 'transition', 'horizontal flip')
                .modal(""show"");

        }, 300);
    };
</script>");

        }
    }
}
#pragma warning restore 1591
