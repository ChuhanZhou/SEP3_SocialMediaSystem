#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126ebb916ee213b7df10054fc0eca345260dc3c3"
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
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using System.Runtime.InteropServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Invitation")]
    public partial class Invitation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 800px;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "oi oi-chevron-left");
            __builder.AddAttribute(8, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                                                                                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "submit");
            __builder.AddAttribute(14, "style", "float:right; text-align: left;height: 30px; background-color: #8fd19e");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                                                                                    () => addMembers()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n                Confirm\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "width: 100%");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "style", "color: red;font-size: 20px;text-align: center");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddContent(24, 
#nullable restore
#line 23 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                     error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            <br>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "form");
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 29 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
             foreach (var friend in friendList.GetFriendSettingList())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "checked", 
#nullable restore
#line 31 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                 hasMember(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                                                    () => ChooseMember(friend.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                <img src=\"user.PNG\" width=\"40px\" height=\"40px\">\r\n");
#nullable restore
#line 33 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                 if (friend.GetNote() == null)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, 
#nullable restore
#line 35 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                     getUserName(friend.GetId())

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, 
#nullable restore
#line 39 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                     friend.Note

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 39 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "                <br>\r\n");
#nullable restore
#line 42 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
       
    private ChatGroup ChatGroup;
    private FriendSettingList friendList;
    private string error;
    public static string GroupId;
    private Account Account;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        friendList = ClientModel.GetFriendSettingList().GetFriendSettingListByStatus(FriendSettingStatus.AGREE);
        ChatGroup = ClientModel.GetGroupByGroupId(GroupId);
        Account = ClientModel.GetAccount();
    }

    private string getUserName(string id)
    {
        return ClientModel.GetFriendById(id).GetUserName();
    }

    private void ChooseMember(string memberId)
    {
        if (hasMember(memberId))
        {
            //if (ChatGroup.CreatorId.Equals(Account.Id))
            //{
            error=ClientModel.RemoveGroupMember(ChatGroup, memberId);
            //}
        }
        else
        {
              //ChatGroup.AccountIdList.Add(memberId);
              error=ClientModel.AddGroupMember(ChatGroup, memberId);
              Console.WriteLine("eeeeeeeeeeeeee"+error+memberId);
        }
    }

    private bool hasMember(string memberId)
    {
      foreach (var member in ClientModel.GetGroupByGroupId(GroupId).AccountIdList)
       {
           if (member.Equals(memberId))
           {
               return true;
           }
       }
       return false;
    }

    private void back()
    {
        NavigationManager.NavigateTo("/GroupSetting");
    }

    private void addMembers()
    {
        //ChatGroup newChatGroup = ChatGroup;
        //ClientModel.UpdateGroupInformation(newChatGroup);
        //GroupSetting.ChatGroup = newChatGroup;
        NavigationManager.NavigateTo("/GroupSetting");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
