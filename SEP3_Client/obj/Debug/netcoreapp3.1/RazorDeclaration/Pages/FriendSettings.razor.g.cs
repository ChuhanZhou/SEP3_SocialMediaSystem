#pragma checksum "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendSettings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "620a6a6a11d9327c727bfe986402388fbaa041a5"
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
#line 1 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendSettings.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendSettings.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FriendSettings")]
    public partial class FriendSettings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendSettings.razor"
       
    private static FriendSettings friendSettings;
    public static FriendSetting FriendSetting;
    
    public static FriendSettings getPage()
    {
        if (friendSettings==null)
        {
            friendSettings = new FriendSettings();
        }
        return friendSettings;
    }

    private void Save()
    {
        FriendSetting newFriendSetting = FriendSetting;
        ClientModel.UpdateFriendSetting(newFriendSetting);
        NavigationManager.NavigateTo("/FriendProfile");
    }

    private void Delete()
    {
        ClientModel.RemoveFriend(FriendSetting.GetId());
        NavigationManager.NavigateTo("/FriendList");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591