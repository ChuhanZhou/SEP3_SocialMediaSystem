#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96f0e48cc5b4b1d356b5963c44848b1f653f9c1"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FriendProfile")]
    public partial class FriendProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
       
    private Friend friend;
    public static FriendSetting friendSetting;
    private PostList postList;
    private Account Account;
    private string commentInfo;
    private static FriendProfile page;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        friend = ClientModel.GetFriendById(friendSetting.GetId());
        postList =await ClientModel.GetPost();
        Account = ClientModel.GetAccount();
        page = this;
    }

    public static FriendProfile getPage()
    {
        if (page==null)
        {
            page = new FriendProfile();
        }
        return page;
    }
    
    private PostList getReverseFriendPostList()
    {
        PostList reversePostList = new PostList();
        if (postList!=null)
        {
            foreach (var post in postList.Posts)
            {
                if (post.SenderId.Equals(friend.Id))
                {
                    reversePostList.AddPost(post);
                }
            }
            reversePostList.Posts.Reverse();
        }
        return reversePostList;
    }

    private void back()
    {
        NavigationManager.NavigateTo("/FriendList");
    }
    
    private void Setting()
    {
        FriendSettings.FriendSetting = friendSetting;
        NavigationManager.NavigateTo("/FriendSettings");
    }

    private void Chat()
    {
        PrivateChat.FriendSetting = friendSetting;
        NavigationManager.NavigateTo("/PrivateChat");
    }
    
    private string getNote(string id)
    {
        string note=ClientModel.GetFriendSettingList().GetFriendSettingFromAgreeById(id).Note;
        if (!string.IsNullOrEmpty(note))
        {
            return note;
        }
        else
        {
            return ClientModel.GetFriendById(id).UserName;
        }
    }

    private bool isFriend(string id)
    {
        if (ClientModel.GetFriendById(id)!=null)
        {
            return true;
        }
        return false;
    }
    
    private async Task clickLike(string id)
    {
        foreach (var likeId in postList.GetPostByPostId(id).LikerIdList)
        {
            if (likeId.Equals(Account.Id))
            {
                postList.GetPostByPostId(id).LikerIdList.Remove(Account.Id);
            }
            else
            {
                postList.GetPostByPostId(id).LikerIdList.Add(Account.Id);
            }
        }
        await ClientModel.UpdatePostLike(id);
    }

    private async Task sendComment(string id)
    {
        if (!string.IsNullOrEmpty(id)&&!string.IsNullOrEmpty(commentInfo))
        {
            await ClientModel.AddComment(id,new Comment(Account.Id,commentInfo));
            commentInfo = "";
        }
    }

    private async Task deleteComment(string postId,string commentId)
    {
        if (!string.IsNullOrEmpty(postId)&&!string.IsNullOrEmpty(commentId))
        {
            await ClientModel.RemoveComment(postId, commentId);
        }
    }

    public async Task Update()
    {
        if (ClientModel!=null)
        {
            friend = ClientModel.GetFriendById(friendSetting.GetId());
            postList =await ClientModel.GetPost();
            Account = ClientModel.GetAccount();
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
