#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "164b08a9725a1db38af23e4590379c939e3e39be"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FriendProfile")]
    public partial class FriendProfile : Microsoft.AspNetCore.Components.ComponentBase
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
#line 12 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                                  back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n            Back\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "oi oi-cog");
            __builder.AddAttribute(16, "style", "float: right;width: auto;height: auto;display: inline-block;");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                     Setting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Profile</h1>\r\n        \r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "background: #b9bbbe");
            __builder.AddMarkupContent(24, "\r\n            <span class=\"oi oi-person\" style=\"float: inherit;width:600px;height: 50px;color: white;\r\n                                           font-size: xx-large;line-height:50px;text-align: center\"></span><br>\r\n            ");
            __builder.OpenElement(25, "label");
            __builder.AddAttribute(26, "style", "font-size: 25px");
            __builder.AddContent(27, 
#nullable restore
#line 24 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                            friendSetting.GetNote()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        <div style=\"height: 8px\"></div>\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "float: left; width: 800px;height: auto;");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, @"<div>
                <button class=""oi oi-chat"" style=""border: 2px solid black;border-radius: 8px; background-color: #8fd19e; width: 100px;
                padding: 10px;height: auto;text-align: center;margin: auto; font-size: 20px;float: right"">
                    Chat
                </button>
            </div>
            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "style", "border: 2px solid black;\r\n                      border-radius: 8px;width: 500px;padding: 10px;height: auto;text-align: center;margin: auto");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddMarkupContent(37, "<div style=\"font-size: 25px;text-align: left\">\r\n                    Basic Information\r\n                </div>\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "style", "font-size: 20px;");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "span");
            __builder.AddAttribute(42, "class", "oi oi-sun");
            __builder.AddAttribute(43, "style", "float: left");
            __builder.AddContent(44, "Account : ");
            __builder.AddContent(45, 
#nullable restore
#line 40 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                           friendSetting.GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "<br>\r\n                    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "oi oi-calendar");
            __builder.AddAttribute(49, "style", "float: left");
            __builder.AddContent(50, "Birth of date: ");
            __builder.AddContent(51, 
#nullable restore
#line 41 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                    friend.GetBirthday().GetDay()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " / ");
            __builder.AddContent(53, 
#nullable restore
#line 41 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                     friend.GetBirthday().GetMonth()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "<br>\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "oi oi-star");
            __builder.AddAttribute(58, "style", "float: left;");
            __builder.AddContent(59, "Gender: ");
            __builder.AddContent(60, 
#nullable restore
#line 42 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                          friend.GetGender()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "<br>\r\n                    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "oi oi-home");
            __builder.AddAttribute(65, "style", "float: left");
            __builder.AddContent(66, "Hometown : ");
            __builder.AddContent(67, 
#nullable restore
#line 43 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                            friend.GetHomeTown()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "<br>\r\n                    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "oi oi-phone");
            __builder.AddAttribute(71, "style", "float: left");
            __builder.AddContent(72, "TelNo. : ");
            __builder.AddContent(73, 
#nullable restore
#line 44 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                           friend.GetPhoneNumber()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "<br>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            <div style=\"height: 8px\"></div>\r\n            ");
            __builder.AddMarkupContent(77, @"<div style=""border: 2px solid black;
                         border-radius: 8px;width: 500px;padding: 10px;height: auto;text-align: center;margin: auto"">
                <div style=""font-size: 25px;text-align: left"">
                    Posts
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
       
    private Friend friend;
    public static FriendSetting friendSetting;

    protected override async Task OnInitializedAsync()
    {
        friend = ClientModel.GetFriendById(friendSetting.GetId());
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendList");
    }
    
    private void Setting()
    {
        FriendSettings.FriendSetting = friendSetting;
        NavigationManager.NavigateTo("/FriendSettings");
    }
    
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
