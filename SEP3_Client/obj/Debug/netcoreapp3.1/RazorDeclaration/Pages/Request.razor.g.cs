#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b93b9f1665d95709ffe7b23a272a68815ce2fc"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Request")]
    public partial class Request : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Request.razor"
       
    public static string accountID;
    private string nickname;
    private string root;
    private string error;
    public static bool toAgree;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        root = "False";
        error = null;
    }
  
    private void back()
    {
        NavigationManager.NavigateTo("/FriendRequest");
    }

    private void clickSend()
    {
        if (ClientModel.GetAccount().GetId() != accountID && ClientModel.GetFriendById(accountID) == null)
        {
            FriendSetting friendSetting = new FriendSetting(accountID, nickname, Convert.ToBoolean(root));
            if (toAgree)
            {
                friendSetting.SetStatus(true);
            }
            error=ClientModel.AddNewFriend(friendSetting);
            if (error==null)
            {
                NavigationManager.NavigateTo("/FriendRequest");
            }
        }
        else
        {
            error = "You already have this friend...";
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
