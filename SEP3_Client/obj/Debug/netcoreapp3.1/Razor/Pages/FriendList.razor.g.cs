#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e173df7e760c8992a5e3ae8f11c400045824de5f"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FriendList")]
    public partial class FriendList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Friend List</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "text-align: center;\r\n         width: 800px;\r\n         height: 400px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "text-align: left; width: 220px; height: 40px;");
            __builder.AddMarkupContent(9, "\r\n            <span class=\"oi oi-people\" style=\"background-color: #86cfda;color: white;width: 40px;height: 40px;\r\n                  float: left;font-size: x-large;line-height:40px;text-align: center \"></span>\r\n            ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "style", "border: none;width: 180px; height: 40px;float: left;text-align: left;background-color: white;\r\n                                                   font-size: 25px;");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                               addGroup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Group Chat");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        <br>\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "text-align: left; width: 260px; height: 40px;");
            __builder.AddMarkupContent(18, "\r\n             <span class=\"oi oi-plus\" style=\"background-color: #e0a800; color: white;width: 40px;height: 40px;\r\n             float: left;font-size: x-large;line-height:40px;text-align: center \"></span>\r\n            ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "style", "border: none;width: 180px; height: 40px;float: left;text-align: left;background-color: white;\r\n             font-size: 25px;");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                         addFriend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Friend request");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "width: 30px; height: 40px;float: left;");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 27 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
             if (show)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "float:left;background-color: red;color: white;font-size:23px;height: 30px;width: 30px;display: inline-block; border-radius: 30px;text-align:center");
            __builder.AddContent(30, 
#nullable restore
#line 29 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                                                                                                                                 NeedAgreeNum()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 30 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        <br>\r\n        ");
            __builder.OpenElement(35, "p");
            __builder.AddMarkupContent(36, "\r\n            <span class=\"oi oi-magnifying-glass\"></span>\r\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "placeholder", "AccountID");
            __builder.AddAttribute(40, "style", "width:200px");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                                  id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "oi oi-magnifying-glass");
            __builder.AddAttribute(46, "style", "background-color: #ed969e; height: 26px");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                                                             search

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "oi oi-x");
            __builder.AddAttribute(51, "style", "background-color: #6f42c1; height: 26px");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                                              showAll

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 40 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
         if (friendsToshow == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "            ");
            __builder.AddMarkupContent(56, "<p>\r\n                <em>Loading</em>\r\n            </p>\r\n");
#nullable restore
#line 45 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
        }
        else
        {
            if (!friendsToshow.GetFriendSettingList().Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                ");
            __builder.AddMarkupContent(58, "<p>\r\n                    <em>No friends in the list...</em>\r\n                </p>\r\n");
#nullable restore
#line 53 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                ");
            __builder.OpenElement(60, "table");
            __builder.AddAttribute(61, "class", "table");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "tbody");
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 58 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                     foreach (var friend in friendsToshow.GetFriendSettingList())
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                        ");
            __builder.OpenElement(66, "tr");
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.OpenElement(68, "td");
            __builder.AddMarkupContent(69, "\r\n                                <img src=\"user.PNG\" width=\"40px\" height=\"40px\">\r\n");
#nullable restore
#line 63 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                 if (string.IsNullOrEmpty(getNote(friend.Id)))
                                {
                                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, 
#nullable restore
#line 65 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                     getUserName(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(71, "span");
            __builder.AddContent(72, 
#nullable restore
#line 65 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                  getFriendStatus(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 66 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, 
#nullable restore
#line 69 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                     getNote(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(75, "span");
            __builder.AddContent(76, 
#nullable restore
#line 69 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                              getFriendStatus(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 70 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.OpenElement(80, "td");
            __builder.AddMarkupContent(81, "\r\n                                ");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "oi oi-eye");
            __builder.AddAttribute(84, "style", "color: cornflowerblue");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                                                                                                  () => seeFriendProfile(friend)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 77 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 80 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor"
       
    private static FriendList page;
    private FriendSettingList friendsToshow;
    private FriendSettingList allFriends;
    private string id;
    private string nickName;
    private bool show;

    public static FriendList GetPage()
    {
        if (page==null)
        {
            page = new FriendList();
        }
        return page;
    }

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        allFriends = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
        friendsToshow = allFriends;
        if (NeedAgreeNum()>0)
        {
            show = true;
        }
        else
        {
            show = false;
        }
        page = this;
    }

    private string getFriendStatus(string id)
    {
        return ClientModel.GetFriendById(id).UserStatus.GetStatus();
    }

    private int NeedAgreeNum()
    {
        int n = 0;
        for (int i = 0; i < ClientModel.GetFriendSettingList().FriendSettings.Count; i++)
        {
            if (ClientModel.GetFriendSettingList().FriendSettings[i].NeedAgree())
            {
                n++;
            }
        }
        return n;
    }

    private string getUserName(string id)
    {
        return nickName=ClientModel.GetFriendById(id).GetUserName();
    }

    private string getNote(string id)
    {
        return nickName=ClientModel.GetFriendSettingList().GetFriendSettingFromAgreeById(id).GetNote();
    }

    private void search()
    {
        if (!string.IsNullOrEmpty(id))
        {
            friendsToshow = new FriendSettingList();
            friendsToshow.AddNewFriendSetting(ClientModel.GetFriendSettingList().GetFriendSettingFromAgreeById(id));
        }
    }

    private void addFriend()
    {
        NavigationManager.NavigateTo("/FriendRequest");
    }

    private void addGroup()
    {
        NavigationManager.NavigateTo("/Group");
    }
    
    

    private void seeFriendProfile(FriendSetting friendSetting)
    {
        FriendProfile.friendSetting = friendSetting;
        PrivateChat.FriendSetting = friendSetting;
        NavigationManager.NavigateTo("/FriendProfile");
    }
    
    private void showAll()
    {
        friendsToshow = allFriends;
        id = null;
    }

    public void Update()
    {
        if (ClientModel!=null)
        {
            allFriends = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
            friendsToshow = allFriends;
            if (NeedAgreeNum()>0)
            {
                show = true;
            }
            else
            {
                show = false;
            }
            search();
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
