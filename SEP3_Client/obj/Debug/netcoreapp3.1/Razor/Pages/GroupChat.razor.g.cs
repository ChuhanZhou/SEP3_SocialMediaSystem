#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa4195153a98bcb0b112be8cf99c28a9583badb"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupChat")]
    public partial class GroupChat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"height: 30px\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "text-align: center; width: 150px;height: 40px;float: left");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "oi oi-chevron-left");
            __builder.AddAttribute(6, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "float: right; text-align: left;width: 320px;");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "oi oi-cog");
            __builder.AddAttribute(15, "style", "width: 40px;height: 40px;font-size: xx-large;line-height:50px;text-align: center;border: none;background-color: white");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                                                                      clickCog

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<img src=\"people_multiple_76px_1116527_easyicon.net.png\" style=\"float: left\" width=\"65px\" height=\"65px\">\r\n");
            __builder.OpenElement(19, "h1");
            __builder.AddContent(20, 
#nullable restore
#line 19 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
     Group.GroupName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "text-align: center;\r\n         width: 900px;\r\n         height: 600px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "height: 600px;width:100%;overflow: auto;");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 27 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
             if (MessageList == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                ");
            __builder.AddMarkupContent(32, "<p>\r\n                    <em>Loading</em>\r\n                </p>\r\n");
#nullable restore
#line 32 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
            }
            else
            {
                if (!MessageList.MessageList.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                    ");
            __builder.AddMarkupContent(34, "<p>\r\n                        <em>Now you can chat in the group...</em>\r\n                    </p>\r\n");
#nullable restore
#line 40 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "tbody");
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 45 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                         foreach (var msg in MessageList.MessageList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                            ");
            __builder.OpenElement(42, "tr");
            __builder.AddAttribute(43, "style", "width: 70%");
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "style", "width: 70%");
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 49 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                     if (msg.SenderId.Equals(Account.Id))
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "                                        <img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\">\r\n                                        ");
            __builder.AddMarkupContent(49, "<div style=\"height: 100%;float: right\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\"></div>\r\n                                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "style", "width: 70%;float: right");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "style", "float: right;width: auto;border-radius:20px;\r\n                            background-color: #ed969e;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                            word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(55, 
#nullable restore
#line 55 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                         msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 57 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                        ");
            __builder.AddMarkupContent(59, "<div style=\"height: 100%;float: left\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: left\"></div>\r\n                                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "style", "width: 70%;float: left;");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "style", "text-align: left;color: #b9bbbe;float: left;width: 100%");
            __builder.AddContent(64, 
#nullable restore
#line 61 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                                                   msg.SenderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, " \r\n                                            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "style", @"float: left;width: auto;height: auto;border-radius:20px;
                                         background-color: #b9bbbe;text-align: left;font-size: 20px;padding: 10px;white-space:normal;
                                         word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(69, 
#nullable restore
#line 64 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                      msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 66 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 69 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 72 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        <br>\r\n         ");
            __builder.OpenElement(80, "div");
            __builder.AddMarkupContent(81, "\r\n             ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "text");
            __builder.AddAttribute(84, "style", "width:400px; font-size: 20px; padding: 10px;border-radius: 10px");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n             ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "class", "btn btn-outline-dark");
            __builder.AddAttribute(90, "type", "submit");
            __builder.AddAttribute(91, "style", "background-color: #b8daff;height: 50px");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                         () => send()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(93, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
       
    public static ChatGroup Group;
    private GroupMessageList MessageList;
    private Account Account;
    private string message;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        MessageList = ClientModel.GetMessageByGroupId(Group.GroupId);
        Account = ClientModel.GetAccount();
        message = null;
    }

    private void send()
    {
        if (message!=null)
        {
            MessageList.AddMessage(new GroupMessage(Account.Id,Group.GroupId,message));
            message = null;
        }
        
    }

    private void back()
    {
        NavigationManager.NavigateTo("/Group");
    }

    private void clickCog()
    {
        GroupSetting.ChatGroup = Group;
        NavigationManager.NavigateTo("/GroupSetting");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
