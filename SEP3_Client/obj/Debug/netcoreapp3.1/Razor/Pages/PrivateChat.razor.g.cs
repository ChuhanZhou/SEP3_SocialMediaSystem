#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2703f974169176cf15e9f7b497257327c2e9dcf6"
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
#line 1 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
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
            __builder.AddMarkupContent(0, "<div style=\"height: 30px\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "text-align: center; width: 150px;height: 40px;float: left");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "oi oi-chevron-left");
            __builder.AddAttribute(6, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                                                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<img src=\"user.PNG\" style=\"float: left\" width=\"65px\" height=\"65px\">\r\n");
            __builder.OpenElement(10, "h1");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 16 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
     if (!string.IsNullOrEmpty(FriendSetting.Note))
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, 
#nullable restore
#line 18 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
         FriendSetting.Note

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                           
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, 
#nullable restore
#line 22 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
         friend.UserName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "text-align: center;\r\n         width: 900px;\r\n         height: 600px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "height: 600px;width:100%;overflow: auto;");
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 32 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
             if (MessageList == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                ");
            __builder.AddMarkupContent(25, "<p>\r\n                    <em>Loading</em>\r\n                </p>\r\n");
#nullable restore
#line 37 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
            }
            else
            {
                if (!MessageList.MessageList.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.AddMarkupContent(27, "<p>\r\n                        <em>Now you can chat with your friend...</em>\r\n                    </p>\r\n");
#nullable restore
#line 45 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                    ");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table");
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "tbody");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 50 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                         foreach (var msg in MessageList.MessageList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                            ");
            __builder.OpenElement(35, "tr");
            __builder.AddAttribute(36, "style", "width: 70%");
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "style", "width: 70%");
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 54 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                     if (msg.SenderId.Equals(Account.Id))
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                                        ");
            __builder.AddMarkupContent(42, "<div style=\"height: 100%;float: right\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: right\"></div>\r\n                                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "width: 70%;float: right");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "style", "float: right;width: auto;border-radius:20px;\r\n                            background-color: #ed969e;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                            word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(48, 
#nullable restore
#line 59 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                         msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 61 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                                        ");
            __builder.AddMarkupContent(52, "<div style=\"height: 100%;float: left\"><img src=\"user.PNG\" width=\"40px\" height=\"40px\" style=\"float: left\"></div>\r\n                                        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "style", @"float: left;width: auto;height: auto;border-radius:20px;
                                         background-color: #b9bbbe;text-align: left;font-size: 20px;padding: 10px;white-space:normal;
                                         word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(56, 
#nullable restore
#line 67 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                      msg.MessageInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 68 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 71 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 75 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        <br>\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "style", "width:400px; font-size: 20px; padding: 10px;border-radius: 10px");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                                               message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "class", "btn btn-outline-dark");
            __builder.AddAttribute(76, "type", "submit");
            __builder.AddAttribute(77, "style", "background-color: #b8daff;height: 50px");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
                                                                                                                        () => send()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "style", "color: red");
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.AddContent(85, 
#nullable restore
#line 84 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
             error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
       
    private Account Account;
    private static PrivateChat page;
    private PrivateMessageList MessageList;
    public static FriendSetting FriendSetting;
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
            Account = ClientModel.GetAccount();
            friend = ClientModel.GetFriendById(FriendSetting.Id);
            MessageList = ClientModel.GetMessageById(friend.Id);
            error = "";
            message = "";
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
