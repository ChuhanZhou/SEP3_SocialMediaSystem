using System;
using SEP3_Client.Pages;

namespace SEP3_Client.Data
{
    public class UpdatePage
    {
        public static void UserSystemUpdate()
        {
            Console.WriteLine("----------------UserSystemUpdate----------------");
            FriendList.GetPage().Update();
            //FriendRequest.GetPage().Update();
        }
        
        public static void ChatSystemUpdate()
        {
            Console.WriteLine("----------------ChatSystemUpdate----------------");
            PrivateChat.GetPage().Update();
            //GroupChat.GetPage().Update();
            //GroupSetting.GetPage().Update();
        }
        
        public static void PostSystemUpdate()
        {
            Console.WriteLine("----------------PostSystemUpdate----------------");
            
        }
    }
}