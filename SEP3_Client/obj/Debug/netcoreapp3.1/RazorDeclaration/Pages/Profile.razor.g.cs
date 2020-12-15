#pragma checksum "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6befb2c0ad19c45378113b066ce9a4ef4448f5ab"
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
#line 2 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 145 "C:\Users\Think\IdeaProjects\SEP3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
       
    private string username;
    private string accountId;
    private string password;
    private int month;
    private int day;
    private char gender;
    private string hometown;
    private long telNo;
    private PostList postList;
    private Account account;
    private string commentInfo;
    private static Profile page;
    private bool wantComment;
    private string a;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        account = ClientModel.GetAccount().Copy();
        accountId = account.GetId();
        username = account.GetUserName();
        postList = await ClientModel.GetPost();
        a = "";
        wantComment = false;
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
            hometown = account.Hometown;
        }
        if (account.GetPhoneNumber()==0)
        {
            telNo = 0;
        }
        else
        {
            telNo = account.PhoneNumber;
        }
        page = this;

    }

    public static Profile getPage()
    {
        if (page==null)
        {
            page = new Profile();
        }
        return page;
    }
    
    private PostList getReversePostList()
    {
        PostList reversePostList = new PostList();
        if (postList!=null)
        {
            foreach (var post in postList.Posts)
                    {
                        if (post.SenderId.Equals(accountId))
                        {
                            reversePostList.AddPost(post);
                        }
                    }
                    reversePostList.Posts.Reverse();
        }
        
        return reversePostList;
    }
    
    private void clickEDIT()
    {
        NavigationManager.NavigateTo("/EditProfile");
    }
    
    private void Setting()
    {
        NavigationManager.NavigateTo("/Setting");
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
        //foreach (var likeId in postList.GetPostByPostId(id).LikerIdList)
        //{
        //    if (likeId.Equals(account.Id))
        //    {
        //        isLike = false;
        //        postList.GetPostByPostId(id).LikerIdList.Remove(account.Id);
        //        break;
        //    }
        //    else
        //    {
        //        isLike = true;
        //        postList.GetPostByPostId(id).LikerIdList.Add(account.Id);
        //    }
        //}
        await ClientModel.UpdatePostLike(id);
    }

    private void wantToComment(string postId)
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
    

    private async Task sendComment(string id)
    {
        if (!string.IsNullOrEmpty(id)&&!string.IsNullOrEmpty(commentInfo))
        {
            await ClientModel.AddComment(id,new Comment(account.Id,commentInfo));
            commentInfo = "";
            a = "";
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
        EditShield.lastPage = "/Profile";
        NavigationManager.NavigateTo("/EditShield");
    }

    public void UpdateUser()
    {
        if (ClientModel!=null)
        {
            account = ClientModel.GetAccount().Copy();
            accountId = account.GetId();
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
                hometown = account.Hometown;
            }
            if (account.GetPhoneNumber()==0)
            {
                telNo = 0;
            }
            else
            {
                telNo = account.PhoneNumber;
            }
            InvokeAsync(StateHasChanged);
        }
    }

    public async Task UpdatePost()
    {
        if (ClientModel!=null)
        {
            postList = await ClientModel.GetPost();
            wantComment = false;
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
