#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "736bc6b9f653128185417d97d66e05cee6e1638d"
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
#line 1 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\_Imports.razor"
using SEP3_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using System.Runtime.InteropServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
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
#line 15 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                                                                                              back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                      ChatGroup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                 addMembers

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.AddMarkupContent(21, "<button type=\"submit\" style=\"float:right; text-align: left;height: 30px; background-color: #8fd19e\">\r\n                Confirm\r\n            </button>\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "style", "width: 100%");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "p");
                __builder2.AddAttribute(26, "style", "color: red;font-size: 20px;text-align: center");
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.AddContent(28, 
#nullable restore
#line 26 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                     error

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            <br>\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "form");
                __builder2.AddMarkupContent(36, "\r\n");
#nullable restore
#line 32 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
             foreach (var friend in friendList.GetFriendSettingList())
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(37, "                ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "checkbox");
                __builder2.AddAttribute(40, "checked", 
#nullable restore
#line 34 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                 hasMember(friend.Id)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                                                    () => ChooseMember(friend.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                <img src=\"user.PNG\" width=\"40px\" height=\"40px\">\r\n");
#nullable restore
#line 36 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                 if (friend.GetNote() == null)
                {
                    

#line default
#line hidden
#nullable disable
                __builder2.AddContent(43, 
#nullable restore
#line 38 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                     getUserName(friend.GetId())

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 38 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                                
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
                __builder2.AddContent(44, 
#nullable restore
#line 42 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                     friend.Note

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 42 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
                                
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(45, "                <br>\r\n");
#nullable restore
#line 45 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(46, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Invitation.razor"
       
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
        Console.WriteLine("eeeeeee"+GroupId);
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
        //Model.Unit.Group.ChatGroup newChatGroup = ChatGroup;
        //ClientModel.UpdateGroupInformation(newChatGroup);
        ChatGroup newChatGroup = ChatGroup;
        ClientModel.UpdateGroupInformation(newChatGroup);
        GroupSetting.ChatGroup = ChatGroup;
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
