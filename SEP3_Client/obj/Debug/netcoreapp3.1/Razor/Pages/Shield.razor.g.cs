#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "151bf383cb3a8f33dbac3f6a7ac155a9b7d5e92c"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Shield")]
    public partial class Shield : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 800px;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "oi oi-chevron-left");
            __builder.AddAttribute(8, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                                                                                                                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "style", "float:right; text-align: left;height: 30px; background-color: #8fd19e");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                                                                                                    shieldFriends

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n        Done\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n     ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "form");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 22 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                 foreach (var friend in friendList.GetFriendSettingList())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "checkbox");
            __builder.AddAttribute(25, "checked", 
#nullable restore
#line 24 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                                                     hasPerson(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                                                                                        () => ChooseMember(friend.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    <img src=\"user.PNG\" width=\"40px\" height=\"40px\">\r\n");
#nullable restore
#line 26 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                     if (friend.GetNote() == null)
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, 
#nullable restore
#line 28 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                         getUserName(friend.GetId())

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 28 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                                                    
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, 
#nullable restore
#line 32 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                         friend.Note

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 32 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                                    
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "                    <br>\r\n");
#nullable restore
#line 35 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
       
    private List<string> disableList;
    private FriendSettingList friendList;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        friendList = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
        disableList = new List<string>();
    }
    
    private string getUserName(string id)
    {
        return ClientModel.GetFriendById(id).GetUserName();
    }
    
    private void ChooseMember(string friendId)
    {
        if (hasPerson(friendId))
        {
            disableList.Remove(friendId);

        }
        else
        {
            disableList.Add(friendId);
        }
    }

    private bool hasPerson(string memberId)
    {
        foreach (var friendID in disableList)
        {
            if (friendID.Equals(memberId))
            {
                return true;
            }
        }
        return false;
    }


    private void back()
    {
        Moment.setIsPublic("Shield"); 
        NavigationManager.NavigateTo("/Moment");
    }

    private void shieldFriends()
    {
        Moment.setIsPublic("Shield");
        Moment.shieldList = disableList;
        NavigationManager.NavigateTo("/Moment");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
