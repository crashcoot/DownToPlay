#pragma checksum "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3a2af02acd2549ed18f8aed4744e07f5cf9440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameSessions_AllGames), @"mvc.1.0.view", @"/Views/GameSessions/AllGames.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GameSessions/AllGames.cshtml", typeof(AspNetCore.Views_GameSessions_AllGames))]
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
#line 1 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\_ViewImports.cshtml"
using DTP;

#line default
#line hidden
#line 2 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\_ViewImports.cshtml"
using DTP.Models;

#line default
#line hidden
#line 3 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\_ViewImports.cshtml"
using DTP.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3a2af02acd2549ed18f8aed4744e07f5cf9440", @"/Views/GameSessions/AllGames.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2db18b9b0557f1f5705d7c9731a11ee62c1755b6", @"/Views/_ViewImports.cshtml")]
    public class Views_GameSessions_AllGames : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DTP.ViewModels.GameSessionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GameSessions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LeaveGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JoinGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Games", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
  
    ViewBag.Title = "All Games";

#line default
#line hidden
            BeginContext(183, 409, true);
            WriteLiteral(@"<nav role=""navigation"" id=""wb-bc"" property=""breadcrumb"">
    <h2>You are here:</h2>
    <div class=""container"">
        <div class=""row"">
            <ol class=""breadcrumb"">
                <li>
                    Home
                </li>
            </ol>
        </div>
    </div>
</nav>
<main role=""main"" property=""mainContentOfPage"" class=""container"">
    <h1 id=""wb-cont"" property=""name"">");
            EndContext();
            BeginContext(593, 13, false);
#line 20 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(606, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 21 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
     foreach (var g in Model.Games)
    {
        string borderColor;
        if (g.CurrentPlayers >= g.NeededPlayers)
        {
            borderColor = "green";
        }
        else if (g.CurrentPlayers > 0)
        {
            borderColor = "orange";
        }
        else
        {
            borderColor = "gainsboro";
        }

#line default
#line hidden
            BeginContext(969, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 981, "\"", 1089, 15);
            WriteAttributeValue("", 989, "border:", 989, 7, true);
            WriteAttributeValue(" ", 996, "5px", 997, 4, true);
            WriteAttributeValue(" ", 1000, "solid", 1001, 6, true);
#line 36 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
WriteAttributeValue(" ", 1006, borderColor, 1007, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1019, ";", 1019, 1, true);
            WriteAttributeValue(" ", 1020, "float:", 1021, 7, true);
            WriteAttributeValue(" ", 1027, "left;", 1028, 6, true);
            WriteAttributeValue(" ", 1033, "width:", 1034, 7, true);
            WriteAttributeValue(" ", 1040, "230px;", 1041, 7, true);
            WriteAttributeValue(" ", 1047, "height:", 1048, 8, true);
            WriteAttributeValue(" ", 1055, "100%;", 1056, 6, true);
            WriteAttributeValue(" ", 1061, "margin:", 1062, 8, true);
            WriteAttributeValue(" ", 1069, "10px;", 1070, 6, true);
            WriteAttributeValue(" ", 1075, "padding:", 1076, 9, true);
            WriteAttributeValue(" ", 1084, "5px;", 1085, 5, true);
            EndWriteAttribute();
            BeginContext(1090, 46, true);
            WriteLiteral(">\r\n            <h2 style=\"text-align: center\">");
            EndContext();
            BeginContext(1137, 6, false);
#line 37 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                      Write(g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 61, true);
            WriteLiteral("</h2>\r\n            <ul>\r\n                <li>Needed Players: ");
            EndContext();
            BeginContext(1205, 15, false);
#line 39 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                               Write(g.NeededPlayers);

#line default
#line hidden
            EndContext();
            BeginContext(1220, 44, true);
            WriteLiteral("</li>\r\n                <li>Current Players: ");
            EndContext();
            BeginContext(1265, 16, false);
#line 40 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                Write(g.CurrentPlayers);

#line default
#line hidden
            EndContext();
            BeginContext(1281, 29, true);
            WriteLiteral("</li>\r\n                <ul>\r\n");
            EndContext();
#line 42 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                     foreach (var jg in Model.JoinedGames)
                    {
                        if (jg.GameID == g.ID)
                        {

#line default
#line hidden
            BeginContext(1468, 32, true);
            WriteLiteral("                            <li>");
            EndContext();
            BeginContext(1501, 11, false);
#line 46 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                           Write(jg.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 47 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1569, 114, true);
            WriteLiteral("                </ul>\r\n            </ul>\r\n            <div style=\"  bottom:0; padding: 2px; text-align: center\">\r\n");
            EndContext();
#line 52 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                 if (Model.CurrentUserGames.Contains(g.ID))
                {

#line default
#line hidden
            BeginContext(1763, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1783, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f3b4cdb8914f588420753072934a83", async() => {
                BeginContext(1896, 5, true);
                WriteLiteral("Leave");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gameID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                                                                  WriteLiteral(g.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gameID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1905, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                }
                else if (Model.CurrentUserID != null)
                {

#line default
#line hidden
            BeginContext(2000, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2020, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "364588a375dc4f82b843c80d111d15ff", async() => {
                BeginContext(2132, 4, true);
                WriteLiteral("Join");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gameID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                                                                 WriteLiteral(g.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gameID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                }

#line default
#line hidden
            BeginContext(2161, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 60 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                 if (g.CreatedBy == Model.CurrentUserID)
                {

#line default
#line hidden
            BeginContext(2238, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2258, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37bcec6c01ae482b8055e5177809d31b", async() => {
                BeginContext(2355, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                                                  WriteLiteral(g.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2363, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2385, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824ab3957a1e4db59a704052bc9bb123", async() => {
                BeginContext(2483, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                                                                    WriteLiteral(g.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2493, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
                }

#line default
#line hidden
            BeginContext(2514, 36, true);
            WriteLiteral("            </div>\r\n        </div>\r\n");
            EndContext();
#line 67 "C:\Users\BurneyD\Documents\Code\DownToPlay\DTP\Views\GameSessions\AllGames.cshtml"
    }

#line default
#line hidden
            BeginContext(2557, 7, true);
            WriteLiteral("</main>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DTP.ViewModels.GameSessionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
