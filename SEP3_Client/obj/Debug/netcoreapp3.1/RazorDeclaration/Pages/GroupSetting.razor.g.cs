#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb3aa5441a07d545ebf327031f01380d78f8914"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupSetting")]
    public partial class GroupSetting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
       
    public static ChatGroup ChatGroup;
    private Account Account;
    private bool show;
    private bool showMembers;
    private static GroupSetting page;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        Account = ClientModel.GetAccount();
        if (ChatGroup.CreatorId.Equals(Account.Id))
          {
              show = true;
          }
          else
          {
              show = false;
          }
        showMembers = false;
        page = this;
    }

    public static GroupSetting GetPage()
    {
        if (page == null)
        {
            page = new GroupSetting();
        }
        return page;
    }

    private string getGroupId()
    {
        return ChatGroup.GroupId;
    }

    private void clickMembers()
    {
        if (showMembers==false)
        {
            showMembers = true;
        }
        else
        {
            showMembers = false;
        }
    }

    private void invite()
    {
        Invitation.GroupId = getGroupId();
        NavigationManager.NavigateTo("/Invitation");
    }

    private void Delete()
    {
        if (ChatGroup.CreatorId.Equals(Account.Id))
        {
            Console.WriteLine("hhhhhhhhhhhhhhhhhhhhhhhhhhh");
             string error = ClientModel.RemoveGroup(ChatGroup);
            Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeee"+ error);
            NavigationManager.NavigateTo("/Group");
        }
        else
        {
            ClientModel.RemoveGroupMember(ChatGroup, Account.Id);
            NavigationManager.NavigateTo("/Group");
        }
       
    }

    private void Back()
    {
        changName();
        GroupChat.Group = ChatGroup;
        NavigationManager.NavigateTo("/GroupChat");
    }
    
    private void ChooseMember(string memberId)
    {
        if (hasMember(memberId))
        {
            ClientModel.RemoveGroupMember(ChatGroup, memberId);
        }
        else
        {
            ClientModel.AddGroupMember(ChatGroup, memberId);
        }
    }

    private bool hasMember(string memberId)
    {
        foreach (var member in ClientModel.GetGroupByGroupId(ChatGroup.GroupId).AccountIdList)
        {
            if (member.Equals(memberId))
            {
                return true;
            }
        }
        return false;
    }

    public void Update()
    {
        Account = ClientModel.GetAccount();
        if (ChatGroup.CreatorId.Equals(Account.Id))
        {
            show = true;
        }
        else
        {
            show = false;
        }
        showMembers = false;
    }

    private void changName()
    {
        ChatGroup newChatGroup = ChatGroup;
        ClientModel.UpdateGroupInformation(newChatGroup);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
