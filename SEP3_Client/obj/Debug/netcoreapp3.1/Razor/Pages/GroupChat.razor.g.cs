#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "022e60ee5d401417ec7e04267ff851e2e3b21a26"
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
#line 1 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
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
            __builder.AddAttribute(6, "style", " float: right; background-color: #03A9F4; color: #FFFFFF; border-radius: 5px; border: hidden; width: 20%");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
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
            __builder.AddAttribute(15, "style", " float: right; background-color: #03A9F4; color: #FFFFFF; border-radius: 5px; border: hidden; width: 20%");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
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
#line 20 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
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
#line 28 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
             if (MessageList == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                ");
            __builder.AddMarkupContent(32, "<p>\r\n                    <em>Loading</em>\r\n                </p>\r\n");
#nullable restore
#line 33 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
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
#line 41 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                     foreach (var msg in MessageList.MessageList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                            ");
            __builder.OpenElement(36, "tr");
            __builder.AddAttribute(37, "style", "width: 70%;");
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "style", "width: 70%");
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 48 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                     if (msg.SenderId.Equals(Account.Id))
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                                        ");
            __builder.AddMarkupContent(43, "<div style=\"height: 100%;float: right\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\"></div>\r\n                                        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "width: 70%;float: right");
            __builder.AddMarkupContent(46, "\r\n                                            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "height: 100%;float: right;");
            __builder.AddMarkupContent(49, "\r\n                                            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "type", "text");
            __builder.AddAttribute(52, "style", "float: right;width: auto;border-radius:20px;\r\n                            background-color: #ed969e;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                            word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(53, 
#nullable restore
#line 55 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                         msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                    <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 59 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                                        ");
            __builder.AddMarkupContent(58, "<div style=\"height: 100%;float: left\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: left\"></div>\r\n                                        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", "width: 70%;float: left;");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "style", "text-align: left;color: #b9bbbe;float: left;width: 100%");
            __builder.AddContent(63, 
#nullable restore
#line 63 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                                                   msg.SenderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, " \r\n                                            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "style", @"float: left;width: auto;height: auto;border-radius:20px;
                                         background-color: #b9bbbe;text-align: left;font-size: 20px;padding: 10px;white-space:normal;
                                         word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(68, 
#nullable restore
#line 66 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                      msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                        <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>\r\n");
#nullable restore
#line 69 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 72 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                         foreach (var msg in offlineMessageList.MessageList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                            ");
            __builder.OpenElement(75, "tr");
            __builder.AddAttribute(76, "style", "width: 70%");
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "style", "width: 70%");
            __builder.AddMarkupContent(80, "\r\n                                    ");
            __builder.AddMarkupContent(81, "<div style=\"height: 100%;float: right\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\"></div>\r\n                                    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "style", "height: 100%;float: right;");
            __builder.AddMarkupContent(84, "\r\n                                        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "style", "width: 70%;float: right");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "type", "text");
            __builder.AddAttribute(89, "style", "float: right;width: auto;max-width: 550px;border-radius:20px;\r\n                            background-color: #ed969e;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                            word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(90, 
#nullable restore
#line 81 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                         msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                        ");
            __builder.AddMarkupContent(92, "<div style=\"height: 100%;float: right\">\r\n                                            <span class=\"oi oi-warning\" style=\"font-size: x-large;\"></span>\r\n                                        </div>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                    <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 89 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                         
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        <br>\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "style", "width:400px; font-size: 20px; padding: 10px;border-radius: 10px");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                               message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "class", "btn btn-outline-dark");
            __builder.AddAttribute(108, "type", "submit");
            __builder.AddAttribute(109, "style", "background-color: #b8daff;height: 50px");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
                                                                                                                        () => send()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(111, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "style", "color: red");
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.AddContent(117, 
#nullable restore
#line 99 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
             error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
       
    public static ChatGroup Group;
    private GroupMessageList MessageList;
    private GroupMessageList offlineMessageList;
    private Account Account;
    private string message;
    private string error;
    private static GroupChat groupChat;


    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        MessageList = ClientModel.GetMessageByGroupId(Group.GroupId);
        Account = ClientModel.GetAccount();
        offlineMessageList = ClientModel.GetOfflineMessageByGroupId(Group.GroupId);
        groupChat = this;
    }

    private void send()
    {
        if (!string.IsNullOrEmpty(message))
        {
            GroupMessage groupMessage = new GroupMessage(Account.Id,Group.GroupId,message);
            error=ClientModel.SendGroupMessage(groupMessage);
            message = null;
        }
        
    }

    public static GroupChat GetPage()
    {
        if (groupChat==null)
        {
            groupChat = new GroupChat();
        }
        return groupChat;
    }

    private void back()
    {
        NavigationManager.NavigateTo("/Group");
    }

    private void clickCog()
    {
        GroupSetting.ChatGroup = ClientModel.GetGroupByGroupId(Group.GroupId);
        Invitation.GroupId = Group.GroupId;
        NavigationManager.NavigateTo("/GroupSetting");
    }

    public void Update()
    {
        if (ClientModel!=null)
        {
            if (string.IsNullOrEmpty(Group.GroupId))
            {
                NavigationManager.NavigateTo("/Group");
            }
            else
            {
                MessageList = ClientModel.GetMessageByGroupId(Group.GroupId);
                Account = ClientModel.GetAccount();
                offlineMessageList = ClientModel.GetOfflineMessageByGroupId(Group.GroupId);
            }
            InvokeAsync(StateHasChanged);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
