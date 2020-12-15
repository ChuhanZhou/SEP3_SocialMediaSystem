#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2572c2b84a4951230a80062e3563c307e4512b5f"
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
#line 1 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Shield.razor"
       
    private List<string> disableList;
    private FriendSettingList friendList;
    public static string postInfo;

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
        Moment.postInfo = postInfo;
        NavigationManager.NavigateTo("/Moment");
    }

    private void shieldFriends()
    {
        Moment.setIsPublic("Shield");
        Moment.shieldList = disableList;
        Moment.postInfo = postInfo;
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
