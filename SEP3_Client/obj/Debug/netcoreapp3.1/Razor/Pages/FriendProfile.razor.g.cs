#pragma checksum "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b14c01b8e923fbad962a5aaf693ca00f51f450"
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
#line 2 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Model.Unit.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
using SEP3_Client.Model.List.PostList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "text-align: center;\r\n         width: 100%;\r\n         height: 800px;\r\n         margin: auto;\r\n         ");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "oi oi-chevron-left");
            __builder.AddAttribute(8, "style", "float:left; text-align: left;height: 30px; background-color: #007bff");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                                  back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n            Back\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "oi oi-cog");
            __builder.AddAttribute(16, "style", "float: right;width: auto;height: auto;display: inline-block;");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                     Setting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<h1 style=\"text-shadow: 2px 2px 5px #818182; color: #4e555b\">Profile</h1>\r\n        \r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "background: #b9bbbe");
            __builder.AddMarkupContent(24, "\r\n            <span class=\"oi oi-person\" style=\"float: inherit;width:100%;height: 50px;color: white;\r\n                                           font-size: xx-large;line-height:50px;text-align: center\"></span><br>\r\n            ");
            __builder.OpenElement(25, "label");
            __builder.AddAttribute(26, "style", "font-size: 25px");
            __builder.AddContent(27, 
#nullable restore
#line 26 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                            friendSetting.GetNote()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        <div style=\"height: 8px\"></div>\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "float: left; width: 100%;height: auto;");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "oi oi-chat");
            __builder.AddAttribute(37, "style", "border: 2px solid black;border-radius: 8px; background-color: #8fd19e; width: 100px;\r\n                padding: 10px;height: auto;text-align: center;margin: auto; font-size: 20px;float: right");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                    Chat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "\r\n                    Chat\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "style", "border: 2px solid black;\r\n                      border-radius: 8px;width: 500px;padding: 10px;height: auto;text-align: center;margin: auto");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<div style=\"font-size: 25px;text-align: left\">\r\n                    Basic Information\r\n                </div>\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "style", "font-size: 20px;");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "class", "oi oi-sun");
            __builder.AddAttribute(51, "style", "float: left");
            __builder.AddContent(52, "Account : ");
            __builder.AddContent(53, 
#nullable restore
#line 42 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                           friendSetting.GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "<br>\r\n                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "oi oi-calendar");
            __builder.AddAttribute(57, "style", "float: left");
            __builder.AddContent(58, "Birth of date: ");
            __builder.AddContent(59, 
#nullable restore
#line 43 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                    friend.GetBirthday().GetDay()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " / ");
            __builder.AddContent(61, 
#nullable restore
#line 43 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                     friend.GetBirthday().GetMonth()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "<br>\r\n                    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "oi oi-star");
            __builder.AddAttribute(66, "style", "float: left;");
            __builder.AddContent(67, "Gender: ");
            __builder.AddContent(68, 
#nullable restore
#line 44 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                          friend.GetGender()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "<br>\r\n                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "oi oi-home");
            __builder.AddAttribute(73, "style", "float: left");
            __builder.AddContent(74, "Hometown : ");
            __builder.AddContent(75, 
#nullable restore
#line 45 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                            friend.GetHomeTown()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "<br>\r\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "oi oi-phone");
            __builder.AddAttribute(79, "style", "float: left");
            __builder.AddContent(80, "TelNo. : ");
            __builder.AddContent(81, 
#nullable restore
#line 46 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                           friend.GetPhoneNumber()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "<br>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            <div style=\"height: 8px\"></div>\r\n            ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "style", "border: 2px solid black;\r\n                         border-radius: 8px;width: 500px;padding: 10px;height: auto;text-align: center;margin: auto");
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "style", "font-size: 25px;text-align: left");
            __builder.AddMarkupContent(90, "\r\n                     ");
            __builder.AddMarkupContent(91, "<div style=\"float: left;text-align: left\">Posts</div><br>\r\n                    ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "style", "float: left;text-align: center;");
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 55 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                      if (getReverseFriendPostList().Posts == null)
                     {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                         ");
            __builder.AddMarkupContent(96, "<p>\r\n                             <em>Loading</em>\r\n                         </p>\r\n");
#nullable restore
#line 60 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                     }
                     else
                     {
                         if (!getReverseFriendPostList().Posts.Any())
                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                             ");
            __builder.AddMarkupContent(98, "<p>\r\n                                 <em>The friend never shares posts...</em>\r\n                             </p>\r\n");
#nullable restore
#line 68 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                         }
                         else
                         {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                              foreach (var post in getReverseFriendPostList().Posts)
                             {

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "                                 ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "style", "border: 2px solid black;\r\n                                                             border-radius: 8px;width: 450px;padding: 15px;height: auto;margin: auto;text-align: left;float: left;");
            __builder.AddMarkupContent(102, "\r\n                                     ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "style", "width: 100%;font-size: 20px");
            __builder.AddMarkupContent(105, "<img src=\"user.PNG\" width=\"40px\" height=\"40px\">");
            __builder.AddContent(106, 
#nullable restore
#line 75 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                              getNote(friend.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(107, "\r\n                                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                     ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "style", "width: 100%;");
            __builder.AddMarkupContent(111, "\r\n                                         ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "type", "text");
            __builder.AddAttribute(114, "style", "width:100%;text-align: left;font-size: 20px;padding: 10px;white-space:normal;\r\n                                       word-break:break-all;word-wrap:break-word;height: auto");
            __builder.AddContent(115, 
#nullable restore
#line 79 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                post.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                     ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "style", "width: 100%;border-top: 2px solid #b9bbbe;border-bottom: 2px solid #b9bbbe;float: left;font-size: 15px");
            __builder.AddMarkupContent(120, "\r\n                                         ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "style", "width: 50%;float:left;text-align: center");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "class", "oi oi-thumb-up");
            __builder.AddAttribute(125, "style", "width: 50%;text-align: center;border: none;background-color: white");
            __builder.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                                                                                                                   (() => clickLike(post.PostId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(127, "Like ");
            __builder.AddContent(128, 
#nullable restore
#line 82 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                                                                                                                                                         post.LikerIdList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                         ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "style", "width: 50%;float:right;text-align: center");
            __builder.OpenElement(132, "button");
            __builder.AddAttribute(133, "class", "oi oi-comment-square");
            __builder.AddAttribute(134, "style", "width: 50%;text-align: center;border: none;background-color: white");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                                                                                                                          (() => wantToComment(post.PostId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "Comment");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                     ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "style", "width: 100%;");
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 86 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                          foreach (var comment in post.CommentList.Comments)
                                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "                                             ");
            __builder.OpenElement(143, "tr");
            __builder.AddAttribute(144, "style", "width: 70%;float: left;");
            __builder.AddMarkupContent(145, "\r\n                                                     \r\n");
#nullable restore
#line 90 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                  if (isFriend(comment.SenderId) || comment.SenderId.Equals(Account.Id))
                                                 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(146, "                                                     ");
            __builder.AddMarkupContent(147, "<div style=\"height: 100%;float: left;\"><img src=\"user.PNG\" width=\"30px\" height=\"30px\">\r\n                                                     </div>\r\n");
#nullable restore
#line 94 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                      if (comment.SenderId.Equals(Account.Id))
                                                     {

#line default
#line hidden
#nullable disable
            __builder.AddContent(148, "                                                         ");
            __builder.OpenElement(149, "button");
            __builder.AddAttribute(150, "class", "oi oi-x");
            __builder.AddAttribute(151, "style", "float: right;text-align: right;border: none;font-size: medium;background-color: white");
            __builder.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                                                                                         (() => deleteComment(post.PostId, comment.CommentId))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 97 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(154, "                                                     ");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "style", "width: 70%;float: left");
            __builder.AddMarkupContent(157, "\r\n                                                         ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "style", "text-align: left;color: #b9bbbe;float: left;width: 100%;font-size: 15px");
            __builder.AddMarkupContent(160, "\r\n");
#nullable restore
#line 100 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                              if (comment.SenderId.Equals(Account.Id))
                                                             {
                                                                 

#line default
#line hidden
#nullable disable
            __builder.AddContent(161, 
#nullable restore
#line 102 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                  Account.UserName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 102 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                  
                                                             }
                                                             else
                                                             {
                                                                 

#line default
#line hidden
#nullable disable
            __builder.AddContent(162, 
#nullable restore
#line 106 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                  getNote(comment.SenderId)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 106 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                           
                                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(163, "                                                         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                                                         ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "type", "text");
            __builder.AddAttribute(167, "style", @"float: left;width: auto;height: auto;border-radius:20px;
                                                           background-color: #b9bbbe;text-align: left;font-size: 15px;padding: 5px;white-space:normal;
                                                           word-break:break-all;word-wrap:break-word;");
            __builder.AddContent(168, 
#nullable restore
#line 111 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                        comment.CommentBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                                                         <div style=\"text-align: left;float: left;width: 100%;height: 10px\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n");
#nullable restore
#line 113 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                 }

#line default
#line hidden
#nullable disable
            __builder.AddContent(171, "                                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
#nullable restore
#line 115 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                          if (wantComment&&post.PostId.Equals(a))
                                         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(173, "                                             ");
            __builder.OpenElement(174, "div");
            __builder.AddAttribute(175, "style", "width: 100%;text-align: left;float: left;font-size: 15px");
            __builder.AddMarkupContent(176, "<img src=\"user.PNG\" width=\"20px\" height=\"20px\">\r\n                                                 ");
            __builder.OpenElement(177, "input");
            __builder.AddAttribute(178, "placeholder", "Write a comment...");
            __builder.AddAttribute(179, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 119 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                commentInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(180, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => commentInfo = __value, commentInfo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                                                 ");
            __builder.OpenElement(182, "button");
            __builder.AddAttribute(183, "class", "btn btn-outline-dark");
            __builder.AddAttribute(184, "style", "font-size: 15px");
            __builder.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 120 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                                                                                                        (() => sendComment(post.PostId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(186, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n");
#nullable restore
#line 121 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                                         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(188, "                                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                                 <div style=\"text-align: left;width: 100%;height: 15px;float: left\"></div>\r\n");
#nullable restore
#line 125 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
                              
                         }
                     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(191, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "C:\Users\魏佳\IdeaProjects\Java3\SEP3_SocialMediaSystem\SEP3_Client\Pages\FriendProfile.razor"
       
    private Friend friend;
    public static FriendSetting friendSetting;
    private PostList postList;
    private Account Account;
    private string commentInfo;
    private static FriendProfile page;
    private bool wantComment;
    private string a;

    protected override async Task OnInitializedAsync()
    {
        if (!MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("");
        }
        friend = ClientModel.GetFriendById(friendSetting.GetId());
        postList =await ClientModel.GetPost();
        Account = ClientModel.GetAccount();
        wantComment = false;
        a = "";
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
            await ClientModel.AddComment(id,new Comment(Account.Id,commentInfo));
            commentInfo = "";
            a = "";
            wantComment = false;
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
