#pragma checksum "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad3a23994b4d8b699792b91b33de9e2e50ee156"
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
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProfile")]
    public partial class EditProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
       
    private string username;
    private int month;
    private int day;
    private bool change;
    private static EditProfile editProfile;
    private char gender;
    private string hometown;
    private long telNo;

    protected override async Task OnInitializedAsync()
    {
        Account account = ClientModel.GetAccount();
        username = account.GetUserName();
        if (account.Birthday==null)
        {
            month = 0;
            day = 0;
        }
        else
        {
            month = account.Birthday.GetMonth();
            day = account.Birthday.GetDay();
        }
        change = false;
        gender = 'M';
        if (account.GetHomeTown()==null)
        {
            hometown = "No hometown to show";
        }
        else
        {
            hometown = account.GetHomeTown();
        }
        if (account.GetPhoneNumber()==0)
        {
            telNo = 0;
        }
        else
        {
            telNo = account.GetPhoneNumber();
        }
    }

    public static EditProfile ChangePage()
    {
        if (editProfile==null)
        {
            editProfile = new EditProfile();
        }
        return editProfile;
    }

    private List<int> num = new[]
    {
        31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    }.ToList();

    private async Task update()
    {
        Account newAccount = ClientModel.GetAccount().Copy();
        newAccount.Update(username,new Birthday(day,month),gender,hometown,telNo);
        await ClientModel.UpdateBasicInformation(newAccount);
        NavigationManager.NavigateTo("/Profile");
    }

    private int GetDays(int month)
    {
        if (month>0)
        {
            return num[month - 1];
        }
        return 0;
    }

    private void clickPen()
    {
        change = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
