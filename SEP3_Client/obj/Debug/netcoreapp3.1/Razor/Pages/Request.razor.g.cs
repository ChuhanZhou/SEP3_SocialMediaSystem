#pragma checksum "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a088e2e5e4218d61f9e88c86d2e16203d3bb01"
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
#line 1 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
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
#line 12 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
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
#line 19 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                                 accountID

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(22, "<div style=\"font-size: 20px;text-align: left\">\r\n                Alias: <input type=\"text\" @nickname>\r\n            </div>\r\n            <br>\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "font-size: 20px;text-align: left");
            __builder.AddMarkupContent(25, "\r\n                Hide my posts: \r\n                ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control selectpicker");
            __builder.AddAttribute(28, "style", "width: auto;display: inline-block");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                                                                           root

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => root = __value, root));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "option");
            __builder.AddContent(33, "False");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "True");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            <br>\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "color: red");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.AddContent(42, 
#nullable restore
#line 34 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                 error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            <br>\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "style", "font-size: 20px;text-align: right; height: 30px");
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-outline-dark");
            __builder.AddAttribute(50, "style", "float: right; width:auto;height: auto;border-radius: 15px; color: #007bff;");
            __builder.AddAttribute(51, "type", "submit");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
                                                clickSend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
       
    public static string accountID;
    private string nickname;
    private bool root;
    private string error;

    protected override async Task OnInitializedAsync()
    {
        root = false;
        error = null;
    }
  
    private void back()
    {
        NavigationManager.NavigateTo("/FriendRequest");
    }

    private void clickSend()
    {
        if (ClientModel.GetAccount().GetId()!=accountID&&ClientModel.GetFriendById(accountID)==null)
        {
            FriendSetting friendSetting = new FriendSetting(accountID,nickname,root);
            ClientModel.AddNewFriend(friendSetting);
            NavigationManager.NavigateTo("/FriendRequest");
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