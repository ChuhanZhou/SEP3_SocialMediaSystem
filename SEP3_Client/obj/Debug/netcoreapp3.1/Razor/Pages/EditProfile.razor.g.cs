#pragma checksum "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57ca34b8357385c2d81821d8bd10f8a693bfe7b"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProfile")]
    public partial class EditProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 300px;\r\n         height: 350px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Profile</h1>\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "margin: 40px auto;width: 300px;height: 40px");
            __builder.AddMarkupContent(9, "\r\n        <span class=\"oi oi-person\" style=\"float: left;width:50px;height:40px;color: #fd7e14;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n        ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "placeholder", "Username");
            __builder.AddAttribute(13, "style", "float: left;width:250px;height: 40px");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                      username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "margin: 40px auto;width: 300px;height: 40px");
            __builder.AddMarkupContent(20, "\r\n        <span class=\"oi oi-key\" style=\"float: left;width:50px;height:40px;color: #fd7e14;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n");
#nullable restore
#line 19 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
         if (change.Equals(true))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "            ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "password");
            __builder.AddAttribute(24, "style", "float: left;width:220px;height: 40px");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                       password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 22 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
         if (change.Equals(false))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "            ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "password");
            __builder.AddAttribute(31, "disabled", true);
            __builder.AddAttribute(32, "style", "float: left;width:220px;height: 40px");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 26 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "        \r\n        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "oi oi-pencil");
            __builder.AddAttribute(39, "style", "float: right;width:20px;height:30px;color: #495057;font-size: xx-large;line-height:50px;text-align: center");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                                                                                  clickPen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "float: left");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddMarkupContent(47, "\r\n            Birth of date: Month :\r\n            ");
            __builder.OpenElement(48, "select");
            __builder.AddAttribute(49, "class", "form-control selectpicker");
            __builder.AddAttribute(50, "style", "width: 150px");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                 month

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => month = __value, month));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "option");
            __builder.AddContent(55, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "option");
            __builder.AddContent(58, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "option");
            __builder.AddContent(61, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "option");
            __builder.AddContent(64, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "option");
            __builder.AddContent(67, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "option");
            __builder.AddContent(70, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "option");
            __builder.AddContent(73, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "option");
            __builder.AddContent(76, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "option");
            __builder.AddContent(79, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "option");
            __builder.AddContent(82, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "option");
            __builder.AddContent(85, "11");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "option");
            __builder.AddContent(88, "12");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenElement(92, "div");
            __builder.AddMarkupContent(93, "\r\n        Day :\r\n        ");
            __builder.OpenElement(94, "select");
            __builder.AddAttribute(95, "class", "form-control selectpicker");
            __builder.AddAttribute(96, "style", "width: 150px");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                              day

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => day = __value, day));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 51 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
             for (int i = 0; i < GetDays(month); i++)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                ");
            __builder.OpenElement(101, "option");
            __builder.AddContent(102, 
#nullable restore
#line 53 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                          i+1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 54 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.OpenElement(108, "div");
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.OpenElement(110, "button");
            __builder.AddAttribute(111, "class", "btn btn-light");
            __builder.AddAttribute(112, "style", "width: 100%;height: 100%;background-color: #9fcdff");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                           update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(114, "SAVE");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
       
    private string username;
    private string password;
    private int month;
    private int day;
    private bool change;

    protected override async Task OnInitializedAsync()
    {
        username = ClientModel.GetAccount().GetUserName();
        password = ClientModel.GetAccount().Password;
        month = ClientModel.GetAccount().Birthday.GetMonth();
        day = ClientModel.GetAccount().Birthday.GetDay();
        change = false;
    }

    private List<int> num = new[]
    {
        31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    }.ToList();

    private void update()
    {
        ClientModel.UpdateBasicInformation(ClientModel.GetAccount());
        ClientModel.ChangePassword(ClientModel.GetAccount().Password, password);
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