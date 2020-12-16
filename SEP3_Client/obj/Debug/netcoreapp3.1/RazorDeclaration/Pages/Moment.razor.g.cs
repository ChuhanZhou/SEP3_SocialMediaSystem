#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a354074a26f8717dfa0c7b92b5d1c20bfc6890"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Moment")]
    public partial class Moment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Moment.razor"
       
    public static string postInfo;
    private PostList postList;
    private static Moment page;
    private static string isPublic;
    private static string LastIsPublic;
    private Account Account;
    private string commentInfo;
    public static List<string> shieldList;
    private bool wantComment;
    private string a;
    

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        postList = await ClientModel.GetPost();
        Account = ClientModel.GetAccount();
        wantComment = false;
        a = "";
        if (string.IsNullOrEmpty(postInfo))
        {
            postInfo = "";
        }
        if (string.IsNullOrEmpty(commentInfo))
        {
            commentInfo = "";
        }
        if (string.IsNullOrEmpty(isPublic))
        {
            isPublic = "Public";
            LastIsPublic = "Public";
        }
        if (shieldList==null)
        {
            shieldList = new List<string>();
        }
        page = this;
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

    private PostList getReversePostList()
    {
        PostList reversePostList = postList.Copy();
        reversePostList.Posts.Reverse();
        return reversePostList;
    }

    private bool isFriend(string id)
    {
        if (ClientModel.GetFriendById(id)!=null)
        {
            return true;
        }
        return false;
    }
    
    public static void setIsPublic(string name)
    {
        isPublic= name;
    }

    public static Moment GetPage()
    {
        if (page == null)
        {
            page = new Moment();
        }
        return page;
    }

    private void ShieldBtn()
    {
        if (LastIsPublic!=isPublic)
        {
            if (isPublic.Equals("Shield"))
            {
                LastIsPublic = isPublic;
                Shield.postInfo = postInfo;
                NavigationManager.NavigateTo("/Shield");
            }
        }
        LastIsPublic = isPublic;
    }
    
    

    private async Task postBtn()
    {
        if (!string.IsNullOrEmpty(postInfo))
        {
            Post newPost = new Post(Account.Id, "", postInfo, shieldList);
            await ClientModel.AddPost(newPost);
            postInfo = "";
            shieldList = new List<string>();
        }
        
    }

    private async Task clickLike(string id)
    {
        //foreach (var likeId in postList.GetPostByPostId(id).LikerIdList)
        //{
        //    if (likeId.Equals(Account.Id))
        //    {
        //        postList.GetPostByPostId(id).LikerIdList.Remove(Account.Id);
        //    }
        //    else
        //    {
        //        postList.GetPostByPostId(id).LikerIdList.Add(Account.Id);
        //    }
        //}
        await ClientModel.UpdatePostLike(id);
    }
    

    private async Task sendComment(string id)
    {
        if (!string.IsNullOrEmpty(id)&&!string.IsNullOrEmpty(commentInfo))
        {
            await ClientModel.AddComment(id,new Comment(Account.Id,commentInfo));
            commentInfo = "";
            wantComment = false;
            a = "";
        }
    }

    private void wantTocomment(string postId)
    {
        a = postId;
        if (wantComment == false)
        {
            wantComment = true;
        }
        else
        {
            wantComment = false;
        }
        
    }

    private async Task deletePost(string id)
    {
        if (!string.IsNullOrEmpty(id))
        {
            await ClientModel.RemovePost(id);
        }
    }

    private async Task deleteComment(string postId,string commentId)
    {
        if (!string.IsNullOrEmpty(postId)&&!string.IsNullOrEmpty(commentId))
        {
            await ClientModel.RemoveComment(postId, commentId);
        }
    }

    private void EditShieldFriends(Post post)
    {
        EditShield.Post = post;
        EditShield.disableList = post.DisableList;
        EditShield.lastPage = "/Moment";
        NavigationManager.NavigateTo("/EditShield");
    }

    public async Task Update()
    {
        if (ClientModel!=null)
        {
            postList = await ClientModel.GetPost();
            Account = ClientModel.GetAccount();
            wantComment = false;
            if (string.IsNullOrEmpty(postInfo))
            {
                postInfo = "";
            }
            if (string.IsNullOrEmpty(isPublic))
            {
                isPublic = "Public";
                LastIsPublic = "Public";
            }
            if (shieldList==null)
            {
                shieldList = new List<string>();
            }
            if (string.IsNullOrEmpty(commentInfo))
            {
                commentInfo = "";
            }
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
