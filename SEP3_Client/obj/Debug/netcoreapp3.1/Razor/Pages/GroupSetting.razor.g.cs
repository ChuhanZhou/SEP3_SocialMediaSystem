#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b33f300fe287871b60f0a8a6d62bcc2e481d40"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupSetting")]
    public partial class GroupSetting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 800px;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-outline-dark");
            __builder.AddAttribute(8, "style", "float: right; width:auto;border-radius: 5px;background-color: #007bff;");
            __builder.AddAttribute(9, "type", "submit");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                                                                                                    Back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "h1");
            __builder.AddAttribute(14, "style", "text-shadow: 2px 2px 3px #818182; color: #4e555b; text-align: left");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                                        ChatGroup.GroupName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", " text-align: left;width: 800px;height: auto;font-size: 20px");
            __builder.AddMarkupContent(19, "\r\n           \r\n");
#nullable restore
#line 17 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                 foreach (var member in ChatGroup.AccountIdList)
                {
                    if (member.Equals(ChatGroup.CreatorId))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "width: fit-content;height: 65px;text-align: center;float: left; padding: 10px");
            __builder.AddMarkupContent(23, "\r\n                            <img src=\"user.PNG\" width=\"30px\" height=\"30px\"><br>\r\n                            ");
            __builder.AddContent(24, 
#nullable restore
#line 23 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                             member

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.AddMarkupContent(26, "<span>(Creator)</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 24 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "style", "width: fit-content;height: 65px;text-align: center;float: left; padding: 10px");
            __builder.AddMarkupContent(31, "\r\n                            <img src=\"user.PNG\" width=\"30px\" height=\"30px\"><br>\r\n                            ");
            __builder.AddContent(32, 
#nullable restore
#line 29 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                             member

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 30 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        <div style=\"height: 30px;width: 100%;float: left\"></div>\r\n");
#nullable restore
#line 35 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
         if (show)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", " text-align: left;width: 800px;height: auto;font-size: 20px;float: left");
            __builder.AddMarkupContent(39, "\r\n                Group name: ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "placeholder", "");
            __builder.AddAttribute(42, "style", "width: 300px;font-size: 20px");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                                              ChatGroup.GroupName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ChatGroup.GroupName = __value, ChatGroup.GroupName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-outline-dark");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                               (() => changName())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, " SAVE ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "<br>\r\n            <div style=\"height: 30px;width: 100%;float: left\"></div>\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "style", " text-align: left;width: 800px;height: auto;font-size: 20px;float: left");
            __builder.AddMarkupContent(54, "\r\n                Manage members: ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-outline-dark");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                               clickMembers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "Members<span class=\"oi oi-chevron-bottom\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 44 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                 if (showMembers)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                    ");
            __builder.OpenElement(61, "form");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 47 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                         foreach (var member in ChatGroup.AccountIdList)
                        {
                            if (!member.Equals(Account.Id))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                                ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "checkbox");
            __builder.AddAttribute(66, "checked", 
#nullable restore
#line 51 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                 hasMember(member)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                                                 () => ChooseMember(member)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.AddContent(69, 
#nullable restore
#line 52 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                 member

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(70, "<br>\r\n");
#nullable restore
#line 53 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                        ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-outline-dark");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                                       clickMembers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "SAVE");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 57 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 60 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "        <div style=\"height: 30px;width: 100%;float: left\"></div>\r\n        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "style", " text-align: left;width: 800px;height: auto;font-size: 20px;float: left");
            __builder.AddMarkupContent(83, "\r\n              GroupID:  ");
            __builder.AddContent(84, 
#nullable restore
#line 63 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                         ChatGroup.GroupId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "<br>\r\n        <div style=\"height: 30px;width: 100%;float: left\"></div>\r\n        ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "style", " text-align: left;width: 800px;height: auto;font-size: 20px");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "oi oi-plus");
            __builder.AddAttribute(92, "style", "background-color: #80bdff; border: 2px solid black; border-radius: 8px;\r\n                    padding: 10px;width: 400px");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                          invite

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, " Invite more friends");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "<br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        <div style=\"height: 30px;width: 100%;float: left\"></div>\r\n        ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "style", " text-align: left;width: 800px;height: auto;font-size: 20px");
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "oi oi-x");
            __builder.AddAttribute(102, "style", "background-color: red ; border: 2px solid black; border-radius: 8px;\r\n                    padding: 10px;width: 400px");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
                                                          Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(104, "Delete and Leave");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "<br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\GroupSetting.razor"
       
    public static ChatGroup ChatGroup;
    private Account Account;
    private bool show;
    private bool showMembers;
    private static GroupSetting page;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        Account = ClientModel.GetAccount();
        if (ChatGroup.CreatorId.Equals(Account.Id))
          {
              show = true;
          }
          else
          {
              show = false;
          }
        showMembers = false;
        getGroupId();
        page = this;
    }

    public static GroupSetting GetPage()
    {
        if (page == null)
        {
            page = new GroupSetting();
        }
        return page;
    }

    private string getGroupId()
    {
        return ChatGroup.GroupId;
    }

    private void clickMembers()
    {
        if (showMembers==false)
        {
            showMembers = true;
        }
        else
        {
            showMembers = false;
        }
    }

    private void invite()
    {
        Invitation.GroupId = getGroupId();
        Console.WriteLine("ggggggggggg"+Invitation.GroupId);
        NavigationManager.NavigateTo("/Invitation");
    }

    private void Delete()
    {
        if (ChatGroup.CreatorId.Equals(Account.Id))
        {
            string error = ClientModel.RemoveGroup(ChatGroup);
        }
        else
        {
            ClientModel.RemoveGroupMember(ChatGroup, Account.Id);
            NavigationManager.NavigateTo("/Group");
        }
       
    }

    private void Back()
    {
        changName();
        GroupChat.Group = ChatGroup;
        NavigationManager.NavigateTo("/GroupChat");
    }
    
    private void ChooseMember(string memberId)
    {
        if (hasMember(memberId))
        {
            ClientModel.RemoveGroupMember(ChatGroup, memberId);
        }
        else
        {
            ClientModel.AddGroupMember(ChatGroup, memberId);
        }
        changName();
    }

    private bool hasMember(string memberId)
    {
        foreach (var member in ClientModel.GetGroupByGroupId(ChatGroup.GroupId).AccountIdList)
        {
            if (member.Equals(memberId))
            {
                return true;
            }
        }
        return false;
    }

    public void Update()
    {
        if (ClientModel!=null)
        {
            ChatGroup = ClientModel.GetGroupByGroupId(getGroupId());
            Account = ClientModel.GetAccount();
            if (ChatGroup.CreatorId.Equals(Account.Id))
            {
                show = true;
            }
            else
            {
                show = false;
            }
            showMembers = false;
            getGroupId();
        }
    }

    private void changName()
    {
        ChatGroup newChatGroup = ChatGroup;
        ClientModel.UpdateGroupInformation(newChatGroup);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
