#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b6892c2cba7e93a7a0b181c1740a1bd6a549a23"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
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
            __builder.AddMarkupContent(0, "<hr>\r\n<br>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin:auto;width: 80%;height: 50%");
            __builder.AddMarkupContent(3, "\r\n        <br>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "        margin: auto;\r\n        background-color: #F5F5F5;\r\n        border-radius: 5px;\r\n        box-shadow: 8px 8px 3px #888888;\r\n    ");
            __builder.AddMarkupContent(6, "\r\n            <br>\r\n            ");
            __builder.OpenElement(7, "h1");
            __builder.AddAttribute(8, "style", "        text-align: center;\r\n        color: #212121\r\n");
            __builder.AddContent(9, 
#nullable restore
#line 18 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
   title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 19 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
             if (title.Equals("Login"))
            {
               

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "background: #B3E5FC;\r\n        margin: 40px auto;\r\n        width: 300px;\r\n        height: 50px;\r\n        border-radius: 5px;\r\n        box-shadow: 1px 1px 0.5px;\r\n        border: hidden\r\n");
            __builder.AddMarkupContent(14, "\r\n                            <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;\r\n                            font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                            ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "placeholder", "account");
            __builder.AddAttribute(18, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                               acccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => acccount = __value, acccount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "        background: #B3E5FC;\r\n        margin: 40px auto;\r\n        width: 300px;\r\n        height: 50px;\r\n        border-radius: 5px;\r\n        box-shadow: 1px 1px 0.5px;\r\n        border: hidden\r\n");
            __builder.AddMarkupContent(25, "\r\n                    <span class=\"oi oi-lock-locked\" style=\"float: left;width:50px;height: 50px;color: white;font-size: xx-large;\r\n                    line-height:50px;text-align: center\"></span>\r\n                    ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "password");
            __builder.AddAttribute(28, "placeholder", "password");
            __builder.AddAttribute(29, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 46 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
             if (title.Equals("Register"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                 if (username==null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "style", "        background: #B3E5FC;\r\n        margin: 40px auto;\r\n        width: 300px;\r\n        height: 50px;\r\n        border-radius: 5px;\r\n        box-shadow: 1px 1px 0.5px;\r\n        border: hidden\r\n");
            __builder.AddMarkupContent(37, "\r\n                        <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;\r\n                font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "text");
            __builder.AddAttribute(40, "placeholder", "username");
            __builder.AddAttribute(41, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 63 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "        background: #B3E5FC;\r\n        margin: 40px auto;\r\n        width: 300px;\r\n        height: 50px;\r\n        border-radius: 5px;\r\n        box-shadow: 1px 1px 0.5px;\r\n        border: hidden\r\n");
            __builder.AddMarkupContent(49, "\r\n                        <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;\r\n                font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "text");
            __builder.AddAttribute(52, "placeholder", "username");
            __builder.AddAttribute(53, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 78 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", "        background: #B3E5FC;\r\n        margin: 40px auto;\r\n        width: 300px;\r\n        height: 50px;\r\n        border-radius: 5px;\r\n        box-shadow: 1px 1px 0.5px;\r\n        border: hidden\r\n");
            __builder.AddMarkupContent(61, "\r\n                    <span class=\"oi oi-lock-locked\" style=\"float: left;width:50px;height: 50px;color: white;font-size: xx-large;\r\n                line-height:50px;text-align: center\"></span>\r\n                    ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "password");
            __builder.AddAttribute(64, "placeholder", "password");
            __builder.AddAttribute(65, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 93 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                 if (password==confirmPassword&&!string.IsNullOrEmpty(confirmPassword))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "style", "        background: #B3E5FC;\r\n        margin: 40px auto;\r\n        width: 300px;\r\n        height: 50px;\r\n        border-radius: 5px;\r\n        box-shadow: 1px 1px 0.5px;\r\n        border: hidden\r\n");
            __builder.AddMarkupContent(73, "\r\n                        <span class=\"oi oi-circle-check\" style=\"float: left;width: 50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "password");
            __builder.AddAttribute(76, "placeholder", "Confirm Password");
            __builder.AddAttribute(77, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                                   confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 106 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "style", "background: red;margin: 40px auto;width: 300px;height: 50px;border-radius:5px;box-shadow:1px 1px 0.5px;border:hidden");
            __builder.AddMarkupContent(85, "\r\n                        <span class=\"oi oi-circle-x\" style=\"float: left;width: 50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                        ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "password");
            __builder.AddAttribute(88, "placeholder", "Confirm Password");
            __builder.AddAttribute(89, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 111 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                                                                                                                   confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 113 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "            ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "style", "margin: 0px auto;width: 300px;height: auto");
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "p");
            __builder.AddAttribute(99, "style", "color: red");
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.AddContent(101, 
#nullable restore
#line 117 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                     error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 120 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
             switch (title)
            {
                case "Login":

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "style", "margin: 40px auto;width: 300px;height: auto");
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "class", "btn btn-primary");
            __builder.AddAttribute(111, "style", "        width: 100%;\r\n        height: 100%;\r\n        border-radius: 5px;\r\n        background: #F44336;\r\n        color: white");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                                PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(113, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.OpenElement(115, "button");
            __builder.AddAttribute(116, "class", "btn btn-primary");
            __builder.AddAttribute(117, "style", "        width: 100%;\r\n        height: 100%;\r\n        border-radius: 5px;\r\n        background: #01579b;\r\n        color: white\r\n");
            __builder.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 136 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
            ChangeState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(119, " ");
            __builder.AddContent(120, 
#nullable restore
#line 136 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                           otherTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            <br>\r\n            <br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        <hr>\r\n");
#nullable restore
#line 141 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                    break;
                case "Register":

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "        ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "style", "margin: 40px auto;width: 300px;height: auto");
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "button");
            __builder.AddAttribute(128, "class", "btn btn-primary");
            __builder.AddAttribute(129, "style", "        width: 100%;\r\n        height: 100%;\r\n        border-radius: 5px;\r\n        background: #F44336;\r\n        color: white\r\n");
            __builder.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 149 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
            Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(131, "Confirm");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "class", "btn btn-primary");
            __builder.AddAttribute(135, "style", "        width: 100%;\r\n        height: 100%;\r\n        border-radius: 5px;\r\n        background: #01579b;\r\n        color: white;\r\n");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 157 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
            ChangeState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(137, " ");
            __builder.AddContent(138, 
#nullable restore
#line 157 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                           otherTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n            <br>\r\n            <br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        <br>\r\n");
#nullable restore
#line 162 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
                    break;
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Login.razor"
       
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
            NavigationManager.NavigateTo("/Chat");
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
        if (string.IsNullOrEmpty(username))
        {
            error = "Please write the username";
        }
        else if (string.IsNullOrEmpty(password))
        {
            error = "Please write the password";
        }
        else if (confirmPassword!=password)
        {
            error = "The confirm password is different from password";
        }
        if (!string.IsNullOrEmpty(username)&&!string.IsNullOrEmpty(password)&&!string.IsNullOrEmpty(confirmPassword)&&confirmPassword==password)
        {
            error = ClientModel.Register(username, password);
        }
        
        if (error == null)
        {
            MainLayout.Login();
            NavigationManager.NavigateTo("/Chat");
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
