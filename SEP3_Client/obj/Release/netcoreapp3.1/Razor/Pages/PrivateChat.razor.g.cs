#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bd162ecc69249df51bda2c98e031fd2d6b33f19"
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
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.Unit.Message;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PrivateChat")]
    public partial class PrivateChat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "text-align: center; width: 150px;height: 40px;float: left");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "oi oi-chevron-left");
            __builder.AddAttribute(5, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                                                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n<img src=\"user.PNG\" style=\"float: left\" width=\"65px\" height=\"65px\">\r\n");
            __builder.OpenElement(9, "h1");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 16 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
     if (!string.IsNullOrEmpty(FriendSetting.Note))
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, 
#nullable restore
#line 18 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
         FriendSetting.Note

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                           
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
         friend.UserName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "text-align: center;\r\n         width: 900px;\r\n         height: 600px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "height: 600px;width:100%;overflow: auto;");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 32 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
             if (MessageList == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.AddMarkupContent(24, "<p>\r\n                    <em>Loading</em>\r\n                </p>\r\n");
#nullable restore
#line 37 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
            }
            else
            {
                if (!MessageList.MessageList.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                    ");
            __builder.AddMarkupContent(26, "<p>\r\n                        <em>Now you can chat with your friend...</em>\r\n                    </p>\r\n");
#nullable restore
#line 45 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                     foreach (var msg in MessageList.MessageList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                            ");
            __builder.OpenElement(28, "tr");
            __builder.AddAttribute(29, "style", "width: 70%");
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "style", "width: 70%");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 52 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                     if (msg.SenderId.Equals(Account.Id))
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                                        ");
            __builder.AddMarkupContent(35, "<div style=\"height: 100%;float: right;\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\"></div>\r\n                                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "width: 70%;float: right;");
            __builder.AddMarkupContent(38, "\r\n                                            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "height: 100%;float: right;");
            __builder.AddMarkupContent(41, "\r\n                                            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "style", "float: right;width: auto;border-radius:20px;\r\n                            background-color: #ed969e;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                            word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(45, 
#nullable restore
#line 59 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                         msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                        <div style=\"float: right;width: 100%;height: 10px\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 62 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                                        ");
            __builder.AddMarkupContent(50, "<div style=\"height: 100%;float: left\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: left\"></div>\r\n                                        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "style", @"float: left;width: auto;height: auto;border-radius:20px;
                                         background-color: #b9bbbe;text-align: left;font-size: 20px;padding: 10px;white-space:normal;
                                         word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(54, 
#nullable restore
#line 68 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                      msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>\r\n");
#nullable restore
#line 70 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 73 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                         foreach (var msg in OfflineMessageList.MessageList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                            ");
            __builder.OpenElement(60, "tr");
            __builder.AddAttribute(61, "style", "width: 70%");
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "style", "width: 70%");
            __builder.AddMarkupContent(65, "\r\n                                    ");
            __builder.AddMarkupContent(66, "<div style=\"height: 100%;float: right\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\"></div>\r\n                                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "style", "width: 70%;float: right");
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "style", "height: 100%;float: right;");
            __builder.AddMarkupContent(72, "\r\n                                            ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "type", "text");
            __builder.AddAttribute(75, "style", @"float: right;width: auto;max-width: 550px;border-radius:20px;
                                     background-color: #ed969e;text-align: left;font-size: 20px;padding: 10px;white-space:normal;
                                     word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(76, 
#nullable restore
#line 83 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                  msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                                        ");
            __builder.AddMarkupContent(78, "<div style=\"height: 100%;float: right\">\r\n                                            <span class=\"oi oi-warning\" style=\"font-size: x-large;\"></span>\r\n                                        </div>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                    <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 91 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                         
                        }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        <br>\r\n        ");
            __builder.OpenElement(84, "div");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "text");
            __builder.AddAttribute(88, "style", "width:400px; font-size: 20px; padding: 10px;border-radius: 10px");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                                               message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-outline-dark");
            __builder.AddAttribute(94, "type", "submit");
            __builder.AddAttribute(95, "style", "background-color: #b8daff;height: 50px");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                                                        () => send()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(97, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "style", "color: red");
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.AddContent(103, 
#nullable restore
#line 101 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
             error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
       
    private Account Account;
    private static PrivateChat page;
    private PrivateMessageList MessageList;
    public static FriendSetting FriendSetting;
    private PrivateMessageList OfflineMessageList;
    private Friend friend;
    private string message;
    private string error;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        Account = ClientModel.GetAccount();
        friend = ClientModel.GetFriendById(FriendSetting.Id);
        MessageList = ClientModel.GetMessageById(friend.Id);
        OfflineMessageList = ClientModel.GetOfflineMessageById(friend.Id);
        error = "";
        message = "";
        page = this;
    }

    public static PrivateChat GetPage()
    {
        if (page == null)
        {
            page = new PrivateChat();
        }
        return page;
    }
    
    private void send()
    {
        if (!string.IsNullOrEmpty(message))
        {
            error=ClientModel.SendPrivateMessage(new PrivateMessage(Account.Id, friend.Id, message));
            message = null;
        }
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendProfile");
    }

    public void Update()
    {
        if (ClientModel != null)
        {
            if (string.IsNullOrEmpty(FriendSetting.Id))
            {
                NavigationManager.NavigateTo("/FriendProfile");
            }
            else
            {
                Account = ClientModel.GetAccount();
                friend = ClientModel.GetFriendById(FriendSetting.Id);
                MessageList = ClientModel.GetMessageById(friend.Id);
                error = "";
                message = "";
                OfflineMessageList = ClientModel.GetOfflineMessageById(friend.Id);
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
