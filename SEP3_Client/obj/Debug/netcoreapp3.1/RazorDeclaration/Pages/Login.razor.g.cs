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
#line 1 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
using SEP3_Client.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\XHYX0\IdeaProjects\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
       
    private string acccount;
    private string password;
    private string confirmPassword;
    private string error;
    private string title;
    private string otherTitle;
    private string username;

    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("/Profile");
        }
        title = "Login";
        otherTitle = "Register";
        confirmPassword = null;
        error = null;
        acccount = null;
        password = null;
    }


    private void PerformLogin()
    {
        error = ClientModel.Login(acccount, password);
        if (error == null)
        {
            MainLayout.Login();
            NavigationManager.NavigateTo("/Profile");
        }
    }
    
    private void ChangeState()
    {
        if (title.Equals("Login"))
        {
            title = "Register";
            otherTitle = "Login";
        }
        else if (title.Equals("Register"))
        {
            title = "Login";
            otherTitle = "Register";
        }
        acccount = null;
        password = null;
        username = null;
        confirmPassword = null;
        error = null;
    }

    private void Register()
    {
        error = ClientModel.Register(username, password);
        if (error == null)
        {
            MainLayout.Login();
            NavigationManager.NavigateTo("/Profile");
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
    }
}
#pragma warning restore 1591
