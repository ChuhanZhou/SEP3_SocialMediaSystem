using System;
using System.Threading;
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
        
        public static void PostSystemUpdate()
        {
            Console.WriteLine("----------------PostSystemUpdate----------------");
            
        }
    }
}