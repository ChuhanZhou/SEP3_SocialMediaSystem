#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b389154f697d89a374dbbf383b3eb7a4d2c82c"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
using SEP3_Client.Model.Unit.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupChat.razor"
       
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
