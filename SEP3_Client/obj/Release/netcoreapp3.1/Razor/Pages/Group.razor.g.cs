#pragma checksum "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30dddc15545c3e7e22c9431420165026f3b0da43"
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
#line 2 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
using SEP3_Client.Model.List.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
using SEP3_Client.Model.Unit.Group;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Group")]
    public partial class Group : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Group chat</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "text-align: center;\r\n         width: 800px;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "oi oi-chevron-right");
            __builder.AddAttribute(9, "style", "float:right; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                                                                                                                                back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n        Back\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "float: left; width: 250px; height: 40px;");
            __builder.AddMarkupContent(15, "\r\n        <span class=\"oi oi-plus\" style=\"background-color: #e0a800; color: white;width: 40px;height: 40px;\r\n     float: left;font-size: x-large;line-height:40px;text-align: center \"></span>\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "style", "border: none;width: 180px; height: 40px;float: left;text-align: left;background-color: white;\r\n     font-size: 25px;");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                                 addGroup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "New Group\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(22, "<div style=\"width: 100%;height: 30px;float:left;\">\r\n    </div>\r\n    ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "style", "width: 800px;height: 35px;text-align: center");
            __builder.AddMarkupContent(25, "\r\n        <div class=\"oi oi-magnifying-glass\" style=\"height: 26px;width: 25px\"></div>\r\n        ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "placeholder", "Group name");
            __builder.AddAttribute(29, "style", "width:200px");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                                                                               groupName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => groupName = __value, groupName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "oi oi-magnifying-glass");
            __builder.AddAttribute(35, "style", "background-color: #ed969e; height: 26px");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                                                                                                         search

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(39, "<div style=\"width: 100%;height: 20px;float:left;\">\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
      if (GroupsToShow == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.AddMarkupContent(41, "<p>\r\n                    <em>Loading</em>\r\n                </p>\r\n");
#nullable restore
#line 40 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
            }
     else
     {
         if (!GroupsToShow.GroupList.Any())
         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "             ");
            __builder.AddMarkupContent(43, "<p>\r\n                 <em>No groups in the list...</em>\r\n             </p>\r\n");
#nullable restore
#line 48 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
         }
         else
         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "             ");
            __builder.OpenElement(45, "table");
            __builder.AddAttribute(46, "class", "table");
            __builder.AddMarkupContent(47, "\r\n                 ");
            __builder.OpenElement(48, "tbody");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 53 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                  foreach (var group in GroupsToShow.GroupList)
                 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                     ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n                         ");
            __builder.OpenElement(53, "td");
            __builder.AddMarkupContent(54, "\r\n                             <img src=\"people_multiple_76px_1116527_easyicon.net.png\" width=\"40px\" height=\"40px\">\r\n                             ");
            __builder.AddContent(55, 
#nullable restore
#line 58 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                              group.GroupName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\r\n                         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                         ");
            __builder.OpenElement(58, "td");
            __builder.AddMarkupContent(59, "\r\n                             ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "oi oi-chat");
            __builder.AddAttribute(62, "style", "color: cornflowerblue");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                                                                                                () => Chat(group)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 65 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
                 }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 68 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
         }
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\XHYX0\source\repos\ChuhanZhou\SEP3_SocialMediaSystem\SEP3_Client\Pages\Group.razor"
       
    private ChatGroupList GroupsToShow;
    private ChatGroupList AllGroups;
    private string groupName;
    private static Group page;
    

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        AllGroups = ClientModel.GetGroupList();
        GroupsToShow = AllGroups;
        page = this;
    }

    public static Group getPage()
    {
        if (page == null)
        {
            page = new Group();
        }
        return page;
    }

    private void search()
    {
        if (!string.IsNullOrEmpty(groupName))
        {
            GroupsToShow = new ChatGroupList();
            foreach (var group in ClientModel.GetGroupList().GetGroupByGroupName(groupName).GroupList)
            {
                GroupsToShow.AddNewGroup(group);
            }
        }
        else
        {
            GroupsToShow = AllGroups;
        }
    }
    
    private void addGroup()
    {
        NavigationManager.NavigateTo("/AddGroup");
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendList");
    }

    private void Chat(ChatGroup group)
    {
        GroupChat.Group = group;
        //GroupSetting.ChatGroup = group;
        NavigationManager.NavigateTo("/GroupChat");
    }

    public void Update()
    {
        if (ClientModel !=null)
        {
            AllGroups = ClientModel.GetGroupList();
            GroupsToShow = AllGroups;
            InvokeAsync(StateHasChanged);
        }
        
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
