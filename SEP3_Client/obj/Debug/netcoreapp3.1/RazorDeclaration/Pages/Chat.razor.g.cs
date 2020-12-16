#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855edfbdc663847b3915baf4add82b5cb9a9a0e9"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using SEP3_Client.Model.List.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using SEP3_Client.Model.Unit.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 288 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Chat.razor"
       
    private FriendSettingList friends;
    private Account Account;
    private PrivateMessageList MessageList;
    private PrivateMessageList OfflineMessageList;
    private GroupMessageList GroupMessageList;
    private GroupMessageList offlineGroupMessageList;
    private ChatGroupList groups;
    private string ID;
    private string message;
    private string error;
    private static Chat page;
    private bool showFriends;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        Account = ClientModel.GetAccount();
        friends = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
        groups = ClientModel.GetGroupList();
        showFriends = true;
        ID = "";
        page = this;
    }

    public static Chat GetPage()
    {
        if (page == null)
        {
            page = new Chat();
        }
        return page;
    }
    
    private string getFriendStatus(string id)
    {
        return ClientModel.GetFriendById(id).UserStatus.GetStatus();
    }

    private string getUserName(string id)
    {
        return ClientModel.GetFriendById(id).GetUserName();
    }

    private string getNote(string id)
    {
        return ClientModel.GetFriendSettingList().GetFriendSettingFromAgreeById(id).GetNote();
    }

    private string getGroupName(string id)
    {
        return ClientModel.GetGroupByGroupId(id).GroupName;
    }

    private void privateChat(string id)
    {
        ID = id;
        MessageList = ClientModel.GetMessageById(ID);
        OfflineMessageList = ClientModel.GetOfflineMessageById(ID);
    }

    private void groupChat(string id)
    {
        ID = id;
        GroupMessageList = ClientModel.GetMessageByGroupId(ID);
        offlineGroupMessageList = ClientModel.GetOfflineMessageByGroupId(ID);
    }
    
    private void send()
    {
        if (!string.IsNullOrEmpty(message))
        {
            error=ClientModel.SendPrivateMessage(new PrivateMessage(Account.Id, ID, message));
            message = "";
        }
    }

    private void sendGroupMsg()
    {
        if (!string.IsNullOrEmpty(message))
        {
            error=ClientModel.SendGroupMessage(new GroupMessage(Account.Id,ID,message));
            message = null;
        }
    }

    private void clickFriendBtn()
    {
        showFriends = true;
        ID = "";
    }

    private void clickGroupBtn()
    {
        showFriends = false;
        ID = "";
    }

    public void Update()
    {
        if (ClientModel!=null)
        {
            Account = ClientModel.GetAccount();
            friends.FriendSettings = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE).FriendSettings;
            groups = ClientModel.GetGroupList();
            if (showFriends)
            {
                if (!string.IsNullOrEmpty(ID))
                {
                    privateChat(ID);
                    MessageList = ClientModel.GetMessageById(ID);
                    OfflineMessageList = ClientModel.GetOfflineMessageById(ID);
                }
                else
                {
                    ID = "";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(ID))
                {
                    groups = ClientModel.GetGroupList();
                    groupChat(ID);
                    GroupMessageList = ClientModel.GetMessageByGroupId(ID);
                    offlineGroupMessageList = ClientModel.GetOfflineMessageByGroupId(ID);
                }
                else
                {
                    ID = "";
                    groups = ClientModel.GetGroupList();
                }
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
