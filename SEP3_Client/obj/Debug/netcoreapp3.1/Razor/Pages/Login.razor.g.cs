#pragma checksum "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5087bdcb1bca8e9dec2d5ed65dd2e04ba8a96e2"
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
#line 2 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn-primary");
            __builder.AddAttribute(5, "style", "float: right;position: relative;width:auto;right:15%;height: 40px;border-radius: 5px");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                                           ChangeState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                                                         otherTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "margin: auto");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "h1");
            __builder.AddAttribute(17, "style", "text-align: center");
            __builder.AddContent(18, 
#nullable restore
#line 12 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                            title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 13 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
             if (title.Equals("Login"))
            {
               

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "background: #86cfda;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(23, "\r\n                            <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;\r\n                            font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "placeholder", "account");
            __builder.AddAttribute(27, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                               acccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => acccount = __value, acccount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "background: #86cfda;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(34, "\r\n                    <span class=\"oi oi-lock-locked\" style=\"float: left;width:50px;height: 50px;color: white;font-size: xx-large;\r\n                    line-height:50px;text-align: center\"></span>\r\n                    ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "password");
            __builder.AddAttribute(37, "placeholder", "password");
            __builder.AddAttribute(38, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 26 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
             if (title.Equals("Register"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                 if (username==null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "background: #86cfda;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(46, "\r\n                        <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;\r\n                font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "placeholder", "username");
            __builder.AddAttribute(50, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 36 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "style", "background: #86cfda;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(58, "\r\n                        <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;\r\n                font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "text");
            __builder.AddAttribute(61, "placeholder", "username");
            __builder.AddAttribute(62, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 44 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "style", "background: #86cfda;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(70, "\r\n                    <span class=\"oi oi-lock-locked\" style=\"float: left;width:50px;height: 50px;color: white;font-size: xx-large;\r\n                line-height:50px;text-align: center\"></span>\r\n                    ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "password");
            __builder.AddAttribute(73, "placeholder", "password");
            __builder.AddAttribute(74, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 52 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                 if (password==confirmPassword&&!string.IsNullOrEmpty(confirmPassword))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                    ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "style", "background: #86cfda;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(82, "\r\n                        <span class=\"oi oi-circle-check\" style=\"float: left;width: 50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "password");
            __builder.AddAttribute(85, "placeholder", "Confirm Password");
            __builder.AddAttribute(86, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                                   confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 58 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "                    ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "style", "background: red;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(94, "\r\n                        <span class=\"oi oi-circle-x\" style=\"float: left;width: 50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "password");
            __builder.AddAttribute(97, "placeholder", "Confirm Password");
            __builder.AddAttribute(98, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                                   confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 65 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "style", "margin: 0px auto;width: 300px;height: auto");
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.OpenElement(107, "p");
            __builder.AddAttribute(108, "style", "color: red");
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.AddContent(110, 
#nullable restore
#line 69 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                     error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 72 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
             switch (title)
            {
                case "Login":

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                    ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "style", "background: #1b6ec2;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-primary");
            __builder.AddAttribute(120, "style", "width: 100%;height: 100%;border-radius: 0px");
            __builder.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                      PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(122, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 78 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                    break;
                case "Register":

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "style", "background: #1b6ec2;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(128, "\r\n                        ");
            __builder.OpenElement(129, "button");
            __builder.AddAttribute(130, "class", "btn btn-primary");
            __builder.AddAttribute(131, "style", "width: 100%;height: 100%;border-radius: 0px");
            __builder.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                      Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(133, "Confirm");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n");
#nullable restore
#line 83 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                    break;
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\魏佳\Desktop\Software Engineering\小组\SEP3X\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
       
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
        else
        {
            title = "Login";
                    otherTitle = "Register";
                    confirmPassword = null;
                    error = null;
                    acccount = null;
                    password = null;
                    
        }
        
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
