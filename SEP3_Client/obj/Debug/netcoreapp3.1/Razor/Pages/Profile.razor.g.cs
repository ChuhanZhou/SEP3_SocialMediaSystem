#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1051e26c054526cdd6035480eb782add0788b8"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
using SEP3_Client.Model.Unit.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 100%;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "oi oi-cog");
            __builder.AddAttribute(10, "style", "float: right;width: auto;height: auto;display: inline-block;");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                     Setting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Profile</h1>\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "background: #b9bbbe");
            __builder.AddMarkupContent(18, "\r\n            <span class=\"oi oi-person\" style=\"float: inherit;width:100%;height: 50px;color: white;\r\n                                           font-size: xx-large;line-height:50px;text-align: center\"></span><br>\r\n            ");
            __builder.OpenElement(19, "label");
            __builder.AddAttribute(20, "style", "font-size: 25px");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                            username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        <div style=\"height: 8px\"></div>\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "style", "border: 2px solid black;\r\n                      border-radius: 8px;width: 500px;padding: 10px;height: auto;text-align: center;margin: auto");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "font-size: 25px;text-align: left");
            __builder.AddMarkupContent(32, "\r\n                    Basic Information\r\n                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-outline-dark");
            __builder.AddAttribute(35, "style", "float: right; width:auto;border-radius: 20px");
            __builder.AddAttribute(36, "type", "submit");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                      clickEDIT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "font-size: 20px;");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "span");
            __builder.AddAttribute(45, "class", "oi oi-sun");
            __builder.AddAttribute(46, "style", "float: left");
            __builder.AddContent(47, "Account : ");
            __builder.AddContent(48, 
#nullable restore
#line 33 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                           accountId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "<br>\r\n");
#nullable restore
#line 34 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                     if (day == 0 || month == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                        ");
            __builder.AddMarkupContent(51, "<div class=\"oi oi-calendar\" style=\"float: left\">Birth of date: Not set... </div><br>\r\n");
#nullable restore
#line 37 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "oi oi-calendar");
            __builder.AddAttribute(55, "style", "float: left");
            __builder.AddContent(56, "Birth of date: ");
            __builder.AddContent(57, 
#nullable restore
#line 40 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                        day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " / ");
            __builder.AddContent(59, 
#nullable restore
#line 40 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                               month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "<br>\r\n");
#nullable restore
#line 41 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "oi oi-star");
            __builder.AddAttribute(65, "style", "float: left;");
            __builder.AddContent(66, "Gender:  ");
            __builder.AddContent(67, 
#nullable restore
#line 42 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                           gender

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "<br>\r\n                                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "oi oi-home");
            __builder.AddAttribute(72, "style", "float: left");
            __builder.AddContent(73, "Hometown : ");
            __builder.AddContent(74, 
#nullable restore
#line 43 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                hometown

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "<br>\r\n                    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "oi oi-phone");
            __builder.AddAttribute(78, "style", "float: left");
            __builder.AddContent(79, "TelNo. : ");
            __builder.AddContent(80, 
#nullable restore
#line 44 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                           telNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "<br>\r\n                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            <div style=\"height: 8px\"></div>\r\n            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "style", "border: 2px solid black;\r\n                         border-radius: 8px;width: 500px;padding: 10px;height: auto;text-align: center;margin: auto");
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "style", "font-size: 25px;text-align: center");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.AddMarkupContent(90, "<div style=\"float: left;text-align: left\">Posts</div>\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 54 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                          if (postList == null)
                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                             ");
            __builder.AddMarkupContent(94, "<p>\r\n                                 <em>Loading</em>\r\n                             </p>\r\n");
#nullable restore
#line 59 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                         }
                         else
                         {
                             if (!postList.Posts.Any())
                             {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                                 ");
            __builder.AddMarkupContent(96, "<p>\r\n                                     <em>You never share posts...</em>\r\n                                 </p>\r\n");
#nullable restore
#line 67 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                             }
                             else
                             {
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                  foreach (var post in postList.Posts)
                                 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                                     ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "style", "border: 2px solid black;\r\n                                                                 border-radius: 8px;width: 800px;padding: 15px;height: auto;margin: auto;text-align: left");
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 74 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                          if (post.SenderId.Equals(account.Id))
                                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "                                             ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "style", "width: 100%;font-size: 20px");
            __builder.AddMarkupContent(104, "<img src=\"user.PNG\" width=\"40px\" height=\"40px\">");
            __builder.AddContent(105, 
#nullable restore
#line 76 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                      account.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(106, "\r\n                                                 ");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "class", "oi oi-pencil");
            __builder.AddAttribute(109, "style", "text-align: right;font-size: larger");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                    (() => EditShieldFriends(post))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                                 ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "class", "oi oi-delete");
            __builder.AddAttribute(114, "style", "font-size: larger;text-align: right");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                    (() => deletePost(post.PostId))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                             ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "style", "width: 100%;");
            __builder.AddMarkupContent(120, "\r\n                                                 ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "type", "text");
            __builder.AddAttribute(123, "style", "width:100%;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                                           word-break:break-all;word-wrap:break-word;height: auto");
            __builder.AddContent(124, 
#nullable restore
#line 82 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                    post.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                                             ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "style", "width: 100%;border-top: 2px solid #b9bbbe;border-bottom: 2px solid #b9bbbe");
            __builder.AddMarkupContent(129, "\r\n                                                 ");
            __builder.OpenElement(130, "button");
            __builder.AddAttribute(131, "class", "oi oi-thumb-up");
            __builder.AddAttribute(132, "style", "width: 50%;text-align: center;border: none;background-color: white");
            __builder.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                                                     (() => clickLike(post.PostId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(134, "Like ");
            __builder.AddContent(135, 
#nullable restore
#line 85 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                                                                                           post.LikerIdList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                                                 ");
            __builder.AddMarkupContent(137, "<button class=\"oi oi-comment-square\" style=\"width: 50%;text-align: center;border: none;background-color: white\">Comment</button>\r\n                                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                             ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "style", "width: 100%;");
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 89 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                  foreach (var comment in post.CommentList.Comments)
                                                 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "                                                     ");
            __builder.OpenElement(143, "tr");
            __builder.AddAttribute(144, "style", "width: 70%");
            __builder.AddMarkupContent(145, "\r\n");
#nullable restore
#line 92 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                          if (comment.SenderId.Equals(account.Id))
                                                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(146, "                                                             ");
            __builder.OpenElement(147, "button");
            __builder.AddAttribute(148, "class", "oi oi-x");
            __builder.AddAttribute(149, "style", "text-align: right;border: none;font-size: medium;background-color: white");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                                                                                                (() => deleteComment(post.PostId, comment.CommentId))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n");
#nullable restore
#line 95 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                          if (isFriend(comment.SenderId) || comment.SenderId.Equals(account.Id))
                                                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(152, "                                                             ");
            __builder.AddMarkupContent(153, "<div style=\"height: 100%;\"><img src=\"user.PNG\" width=\"20px\" height=\"20px\">\r\n                                                             </div>\r\n                                                             ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "style", "width: 70%;");
            __builder.AddMarkupContent(156, "\r\n                                                                 ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "style", "text-align: left;color: #b9bbbe;float: left;width: 100%");
            __builder.AddMarkupContent(159, "\r\n");
#nullable restore
#line 102 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                      if (comment.SenderId.Equals(account.Id))
                                                                     {
                                                                         

#line default
#line hidden
#nullable disable
            __builder.AddContent(160, 
#nullable restore
#line 104 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                          account.UserName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 104 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                          
                                                                     }
                                                                     else
                                                                     {
                                                                         

#line default
#line hidden
#nullable disable
            __builder.AddContent(161, 
#nullable restore
#line 108 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                          getNote(comment.SenderId)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 108 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                   
                                                                     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(162, "\r\n                                                                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                                                                 ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "type", "text");
            __builder.AddAttribute(166, "style", @"float: left;width: auto;height: auto;border-radius:20px;
                                                               background-color: #b9bbbe;text-align: left;font-size: 20px;padding: 10px;white-space:normal;
                                                               word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(167, 
#nullable restore
#line 114 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                            comment.CommentBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                                                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                                                             <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>\r\n");
#nullable restore
#line 117 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(170, "                                                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n");
#nullable restore
#line 119 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                 }

#line default
#line hidden
#nullable disable
            __builder.AddContent(172, "                                                 ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "style", "width: 100%;text-align: left");
            __builder.AddMarkupContent(175, "<img src=\"user.PNG\" width=\"20px\" height=\"20px\">\r\n                                                     ");
            __builder.OpenElement(176, "input");
            __builder.AddAttribute(177, "placeholder", "Write a comment...");
            __builder.AddAttribute(178, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 121 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                    commentInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(179, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => commentInfo = __value, commentInfo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                                                     ");
            __builder.OpenElement(181, "button");
            __builder.AddAttribute(182, "class", "btn btn-outline-dark");
            __builder.AddAttribute(183, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                                                                                    (() => sendComment(post.PostId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(184, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n                                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n");
#nullable restore
#line 124 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(187, "                                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n");
#nullable restore
#line 126 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
                                  
                             }
                         }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(189, "                                       \r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\Profile.razor"
       
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
    
    private void clickLike(string id)
    {
        foreach (var likeId in postList.GetPostByPostId(id).LikerIdList)
        {
            if (likeId.Equals(account.Id))
            {
                postList.GetPostByPostId(id).LikerIdList.Remove(account.Id);
            }
            else
            {
                postList.GetPostByPostId(id).LikerIdList.Add(account.Id);
            }
        }
        ClientModel.UpdatePostLike(id);
    }

    private void sendComment(string id)
    {
        if (!string.IsNullOrEmpty(id)&&!string.IsNullOrEmpty(commentInfo))
        {
            ClientModel.AddComment(id,new Comment(account.Id,commentInfo));
            commentInfo = "";
        }
    }

    private void deletePost(string id)
    {
        ClientModel.RemovePost(id);
    }

    private void deleteComment(string postId,string commentId)
    {
        ClientModel.RemoveComment(postId,commentId);
    }
    
    private void EditShieldFriends(Post post)
    {
        EditShield.Post = post;
        EditShield.disableList = post.DisableList;
        EditShield.lastPage = "/Profile";
        NavigationManager.NavigateTo("/EditShield");
    }

    public async Task Update()
    {
        account = ClientModel.GetAccount().Copy();
        accountId = account.GetId();
        username = account.GetUserName();
        postList = await ClientModel.GetPost();
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

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientModel ClientModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
