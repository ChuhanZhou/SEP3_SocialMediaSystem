using System;
using System.Threading;
using System.Threading.Tasks;
using SEP3_Client.Pages;

namespace SEP3_Client.Data
{
    public class UpdatePage
    {
        public static void UserSystemUpdate()
        {
            Console.WriteLine("----------------UserSystemUpdate----------------");
            new Thread(()=>FriendList.GetPage().Update()).Start();
            new Thread(()=>FriendRequest.GetPage().Update()).Start();
            //await Profile.getPage().Update();
            //await FriendProfile.getPage().Update();
            new Thread(()=>Profile.getPage().UpdateUser()).Start();
            new Thread(()=>FriendProfile.getPage().UpdateUser()).Start();
        }
        
        public static void ChatSystemUpdate()
        {
            Console.WriteLine("----------------ChatSystemUpdate----------------");
            new Thread(()=>PrivateChat.GetPage().Update()).Start(); 
            new Thread(()=>Chat.GetPage().Update()).Start();
            new Thread(()=>GroupChat.GetPage().Update()).Start();
            new Thread(()=>GroupSetting.GetPage().Update()).Start();
            new Thread(()=>Group.getPage().Update()).Start();
        }
        
        public static async Task PostSystemUpdate()
        {
            Console.WriteLine("----------------PostSystemUpdate----------------");
            await Moment.GetPage().Update();
            await Profile.getPage().UpdatePost();
            await FriendProfile.getPage().UpdatePost();
            //new Thread(async ()=>await Moment.GetPage().Update()).Start();
            //new Thread(async ()=>await Profile.getPage().Update()).Start();
            //new Thread(async ()=>await FriendProfile.getPage().Update()).Start();
        }
    }
}