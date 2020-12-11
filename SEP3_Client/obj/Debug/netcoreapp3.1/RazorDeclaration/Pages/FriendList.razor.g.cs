#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e173df7e760c8992a5e3ae8f11c400045824de5f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
