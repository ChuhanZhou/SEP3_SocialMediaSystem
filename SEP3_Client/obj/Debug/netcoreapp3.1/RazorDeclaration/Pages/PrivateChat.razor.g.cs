#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bd162ecc69249df51bda2c98e031fd2d6b33f19"
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
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.List.Message;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
using SEP3_Client.Model.Unit.Message;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PrivateChat")]
    public partial class PrivateChat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\PrivateChat.razor"
       
    private Account Account;
    private static PrivateChat page;
    private PrivateMessageList MessageList;
    public static FriendSetting FriendSetting;
    private PrivateMessageList OfflineMessageList;
    private Friend friend;
    private string message;
    private string error;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        Account = ClientModel.GetAccount();
        friend = ClientModel.GetFriendById(FriendSetting.Id);
        MessageList = ClientModel.GetMessageById(friend.Id);
        OfflineMessageList = ClientModel.GetOfflineMessageById(friend.Id);
        error = "";
        message = "";
        page = this;
    }

    public static PrivateChat GetPage()
    {
        if (page == null)
        {
            page = new PrivateChat();
        }
        return page;
    }
    
    private void send()
    {
        if (!string.IsNullOrEmpty(message))
        {
            error=ClientModel.SendPrivateMessage(new PrivateMessage(Account.Id, friend.Id, message));
            message = null;
        }
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendProfile");
    }

    public void Update()
    {
        if (ClientModel != null)
        {
            if (string.IsNullOrEmpty(FriendSetting.Id))
            {
                NavigationManager.NavigateTo("/FriendProfile");
            }
            else
            {
                Account = ClientModel.GetAccount();
                friend = ClientModel.GetFriendById(FriendSetting.Id);
                MessageList = ClientModel.GetMessageById(friend.Id);
                error = "";
                message = "";
                OfflineMessageList = ClientModel.GetOfflineMessageById(friend.Id);
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
