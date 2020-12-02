#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb78c8d32190de8e2e1a677851e2c089175e9495"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
using SEP3_Client.Model.List.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Group")]
    public partial class Group : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
       
    private ChatGroupList GroupsToShow;
    private ChatGroupList AllGroups;
    private string groupName;
    

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        AllGroups = ClientModel.GetGroupList();
        GroupsToShow = AllGroups;
    }

    private void search()
    {
        if (!string.IsNullOrEmpty(groupName))
        {
            GroupsToShow = new ChatGroupList();
            foreach (var group in ClientModel.GetGroupList().GetGroupByGroupName(groupName).GroupList)
            {
                GroupsToShow.AddNewGroup(group);
            }
        }
        else
        {
            GroupsToShow = AllGroups;
        }
    }
    
    private void addGroup()
    {
        NavigationManager.NavigateTo("/Invitation");
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendList");
    }

    private void Chat(ChatGroup group)
    {
        GroupChat.Group = group;
        NavigationManager.NavigateTo("/GroupChat");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
