#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21545f4c25f3b4a53227e3e4c34a32bf9378228b"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 300px;\r\n         height: auto;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Profile</h1>\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "float: left;text-align: left;font-size: 17px");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "float: left;margin: 20px auto;width: 300px;height: 30px");
            __builder.AddMarkupContent(12, " \r\n            ");
            __builder.AddMarkupContent(13, "<span class=\"oi oi-person\" style=\"float: left;width:300px;height: 30px\">Username : </span>\r\n            ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "style", "float: left;width:300px;height: 30px");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                   username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "float: left;margin: 20px auto; height: auto;width: 300px");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<span class=\"oi oi-calendar\" style=\"float: left;width:300px;height: 30px\">Birth of date: </span>\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "float: left");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<label style=\"visibility: hidden\">m</label>\r\n                Month :\r\n                ");
            __builder.OpenElement(29, "select");
            __builder.AddAttribute(30, "class", "form-control selectpicker");
            __builder.AddAttribute(31, "style", "width: auto; display: inline-block");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                           month

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => month = __value, month));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddContent(39, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "option");
            __builder.AddContent(42, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "option");
            __builder.AddContent(45, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "option");
            __builder.AddContent(48, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "option");
            __builder.AddContent(51, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "option");
            __builder.AddContent(54, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "option");
            __builder.AddContent(57, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "option");
            __builder.AddContent(60, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "option");
            __builder.AddContent(63, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "option");
            __builder.AddContent(66, "11");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "option");
            __builder.AddContent(69, "12");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            <div style=\"height: 6px\"></div>\r\n        ");
            __builder.OpenElement(74, "div");
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.AddMarkupContent(76, "<label style=\"visibility: hidden\">m</label>\r\n            Day :\r\n            ");
            __builder.OpenElement(77, "select");
            __builder.AddAttribute(78, "class", "form-control selectpicker");
            __builder.AddAttribute(79, "style", "width: auto;display: inline-block");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                       day

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => day = __value, day));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 44 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                 for (int i = 0; i < GetDays(month); i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "                    ");
            __builder.OpenElement(84, "option");
            __builder.AddContent(85, 
#nullable restore
#line 46 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                              i + 1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 47 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "style", "float: left;margin: 20px auto;");
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.OpenElement(93, "span");
            __builder.AddAttribute(94, "class", "oi oi-star");
            __builder.AddAttribute(95, "style", "float: left;width:300px;height: 30px");
            __builder.AddMarkupContent(96, "Gender:\r\n                ");
            __builder.OpenElement(97, "select");
            __builder.AddAttribute(98, "class", "form-control selectpicker");
            __builder.AddAttribute(99, "style", "width: auto;display: inline-block");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                           gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gender = __value, gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "option");
            __builder.AddContent(104, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "option");
            __builder.AddContent(107, "F");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "<br>\r\n        ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "style", "float: left; margin: 20px auto;width: 300px;height: 30px");
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.AddMarkupContent(113, "<span class=\"oi oi-home\" style=\"float: left;width:300px;height: 30px\">Hometown : </span>\r\n            ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "text");
            __builder.AddAttribute(116, "style", "float: left;width:300px;height: 30px");
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                   hometown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hometown = __value, hometown));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "<br>\r\n        ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "style", "float: left; margin: 20px auto;width: 300px;height: 30px");
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.AddMarkupContent(124, "<span class=\"oi oi-phone\" style=\"float: left;width:300px;height: 30px\">TelNo. :</span>\r\n            ");
            __builder.OpenElement(125, "input");
            __builder.AddAttribute(126, "type", "number");
            __builder.AddAttribute(127, "style", "float: left;width:300px;height: 30px");
            __builder.AddAttribute(128, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                     telNo

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telNo = __value, telNo, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "<br>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n    ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "style", "float: left;margin: 20px auto;width: 300px; height: 40px");
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.OpenElement(136, "button");
            __builder.AddAttribute(137, "class", "btn btn-light");
            __builder.AddAttribute(138, "style", "width: 100%; height: 100%;background-color: #9fcdff");
            __builder.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
                                                                                                            update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(140, "SAVE");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\EditProfile.razor"
       
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
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        Account account = ClientModel.GetAccount().Copy();
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
        if (char.IsWhiteSpace(account.Gender))
        {
            gender = 'M';
        }
        else
        {
            gender = account.Gender;
        }
        if (string.IsNullOrEmpty(account.GetHomeTown()))
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
        editProfile = this;
    }

    public static EditProfile GetPage()
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

    private void update()
    {
        Account newAccount = ClientModel.GetAccount().Copy();
        newAccount.Update(username,new Birthday(day,month),gender,hometown,telNo);
        ClientModel.UpdateBasicInformation(newAccount);
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



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
