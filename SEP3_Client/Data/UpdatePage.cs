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
            //FriendRequest.GetPage().Update();
        }
        
        public static void ChatSystemUpdate()
        {
            Console.WriteLine("----------------ChatSystemUpdate----------------");
            new Thread(()=>PrivateChat.GetPage().Update()).Start();
            //Chat.GetPage().Update();
            //GroupChat.GetPage().Update();
            //GroupSetting.GetPage().Update();
        }
        
        public static void PostSystemUpdate()
        {
            Console.WriteLine("----------------PostSystemUpdate----------------");
            
        }
    }
}