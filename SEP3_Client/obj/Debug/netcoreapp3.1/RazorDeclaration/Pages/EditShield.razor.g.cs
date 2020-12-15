#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditShield.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1700886834e027a2148f600ce43815a7a8bd26c1"
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
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditShield.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditShield.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditShield.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditShield.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditShield")]
    public partial class EditShield : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditShield.razor"
       
    public static string lastPage;
    public static List<string> disableList;
    public static Post Post;
    private FriendSettingList friendList;
    private static EditShield page;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        friendList = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
        page = this;
    }

    public static EditShield getPage()
    {
        if (page==null)
        {
            page = new EditShield();
        }
        return page;
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
        NavigationManager.NavigateTo(lastPage);
    }

    private async Task shieldFriends()
    {
        await ClientModel.UpdatePostBySender(Post);
        NavigationManager.NavigateTo(lastPage);
    }

    public void Update()
    {
        friendList = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
    }
    
    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
