#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b93b9f1665d95709ffe7b23a272a68815ce2fc"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Request")]
    public partial class Request : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 800px;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "oi oi-chevron-left");
            __builder.AddAttribute(8, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                                                                                                  back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n            Back\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Friend Request</h1>\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "border: 2px solid black; border-radius: 8px;width: 500px;padding: 10px;height: auto;\r\n        text-align: center;margin: auto");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "font-size: 30px;text-align: left");
            __builder.AddMarkupContent(18, "\r\n                <img src=\"user.PNG\" width=\"50px\" height=\"50px\"> ");
            __builder.AddContent(19, 
#nullable restore
#line 21 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                                 accountID

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            <br>\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "font-size: 20px;text-align: left");
            __builder.AddMarkupContent(24, "\r\n                Alias: ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                 nickname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nickname = __value, nickname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            <br>\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "font-size: 20px;text-align: left");
            __builder.AddMarkupContent(33, "\r\n                Hide my posts: \r\n                ");
            __builder.OpenElement(34, "select");
            __builder.AddAttribute(35, "class", "form-control selectpicker");
            __builder.AddAttribute(36, "style", "width: auto;display: inline-block");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                                                                           root

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => root = __value, root));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "option");
            __builder.AddContent(41, "False");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "option");
            __builder.AddContent(44, "True");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            <br>\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "color: red");
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.AddContent(50, 
#nullable restore
#line 36 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                 error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            <br>\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "style", "font-size: 20px;text-align: right; height: 30px");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-outline-dark");
            __builder.AddAttribute(58, "style", "float: right; width:auto;height: auto;border-radius: 15px; color: #007bff;");
            __builder.AddAttribute(59, "type", "submit");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                clickSend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
       
    public static string accountID;
    private string nickname;
    private string root;
    private string error;
    public static bool toAgree;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        root = "False";
        error = null;
    }
  
    private void back()
    {
        NavigationManager.NavigateTo("/FriendRequest");
    }

    private void clickSend()
    {
        if (ClientModel.GetAccount().GetId() != accountID && ClientModel.GetFriendById(accountID) == null)
        {
            FriendSetting friendSetting = new FriendSetting(accountID, nickname, Convert.ToBoolean(root));
            if (toAgree)
            {
                friendSetting.SetStatus(true);
            }
            error=ClientModel.AddNewFriend(friendSetting);
            if (error==null)
            {
                NavigationManager.NavigateTo("/FriendRequest");
            }
        }
        else
        {
            error = "You already have this friend...";
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
