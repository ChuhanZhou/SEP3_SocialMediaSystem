#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f9e5dfd9dfeafc306ef3a5abbc37b3d3739a9b"
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
#line 1 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
using SEP3_Client.Model.List.UserList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FriendRequest")]
    public partial class FriendRequest : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddAttribute(7, "class", "oi oi-chevron-left");
            __builder.AddAttribute(8, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                                                                                                                  back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n           Back\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "p");
            __builder.AddMarkupContent(13, "\r\n            <span class=\"oi oi-magnifying-glass\"></span>\r\n            ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "placeholder", "Account");
            __builder.AddAttribute(17, "style", "width:400px");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                                                                requestID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => requestID = __value, requestID));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "oi oi-magnifying-glass");
            __builder.AddAttribute(23, "style", "background-color: #ed969e; height: 26px");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                              sendRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n         ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "style", "color: red");
            __builder.AddMarkupContent(29, "\r\n             ");
            __builder.AddContent(30, 
#nullable restore
#line 23 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
              error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                \r\n");
#nullable restore
#line 26 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
          if (friendRequests == null)
          {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "              ");
            __builder.AddMarkupContent(34, "<p>\r\n                  <em>Loading</em>\r\n              </p>\r\n");
#nullable restore
#line 31 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
          }
          else
          {
              if (!friendRequests.GetFriendSettingList().Any())
              {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                  ");
            __builder.AddMarkupContent(36, "<p>\r\n                      <em>No friend request in the list...</em>\r\n                  </p>\r\n");
#nullable restore
#line 39 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
              }
              else
              {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                  ");
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table");
            __builder.AddMarkupContent(40, "\r\n                      ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 44 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                       foreach (var request in getFriendSettingList())
                      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                          ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                              ");
            __builder.OpenElement(46, "td");
            __builder.AddMarkupContent(47, "\r\n                                  <img src=\"user.PNG\" width=\"40px\" height=\"40px\">\r\n                                  ");
            __builder.AddContent(48, 
#nullable restore
#line 49 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                   request.GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(49, "\r\n                              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                              ");
            __builder.OpenElement(51, "td");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 52 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                   if (request.NeedAgree())
                                  {
                                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                       if (click.Equals(false))
                                      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                                          ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                                              () => changeStatusTo(request.Id, true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "style", "background-color: #80bdff");
            __builder.AddContent(57, "Confirm");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                          ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                                              () => changeStatusTo(request.Id, false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "style", "background-color: #80bdff");
            __builder.AddContent(62, "Refuse");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 58 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                      }
                                      else
                                      {
                                          

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, 
#nullable restore
#line 61 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                           request.Status

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 61 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                                         
                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                       
                                  }
                                  else
                                  {
                                      

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, 
#nullable restore
#line 66 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                       request.Status

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 66 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                                                     
                                  }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "\r\n                              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 71 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
                      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 74 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
              }
         
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendRequest.razor"
       
    public FriendSettingList friendRequests;
    private static FriendRequest friendRequest;
    public string requestID;
    private string error;
    private string status;
    private bool click;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        friendRequests = ClientModel.GetFriendSettingList();
        //friendRequests.GetFriendSettingList().Reverse();
        click = false;
        friendRequest = this;
    }

    private List<FriendSetting> getFriendSettingList()
    {
        List<FriendSetting> friendSettingList = friendRequests.GetFriendSettingList();
        friendSettingList.Reverse();
        return friendSettingList;
    }
    
    public static FriendRequest GetPage()
    {
        if (friendRequest==null)
        {
            friendRequest = new FriendRequest();
        }
        return friendRequest;
    }

    private void sendRequest()
    {
        if ( ClientModel.SearchId(requestID))
        {
            Request.accountID = requestID;
            Request.toAgree = false;
            NavigationManager.NavigateTo("/Request");
        }
        error = "No user exists in the system...";
    }

    private void changeStatusTo(string id, bool tOrF)
    {
        click = true;
        if (tOrF)
        {
            Request.accountID = id;
            Request.toAgree = true;
            NavigationManager.NavigateTo("/Request");
        }
        else
        {
            FriendSetting a = new FriendSetting(id);
            a.SetStatus(tOrF);
            ClientModel.AddNewFriend(a);
        }
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendList");
    }

    public void Update()
    {
        if (ClientModel!=null)
        {
            friendRequests = ClientModel.GetFriendSettingList();
                    //friendRequests.GetFriendSettingList().Reverse();
                    click = false;
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
