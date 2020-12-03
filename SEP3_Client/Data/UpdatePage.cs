using System;
using SEP3_Client.Pages;

namespace SEP3_Client.Data
{
    public class UpdatePage
    {
        public static void UserSystemUpdate()
        {
            Console.WriteLine("--------------------------------");
            FriendList.GetPage().Update();
            //FriendRequest.GetPage().Update();
        }
        
        public static void ChatSystemUpdate()
        {
            Console.WriteLine("--------------------------------");
            PrivateChat.GetPage().Update();
            //GroupChat.GetPage().Update();
            //GroupSetting.GetPage().Update();
        }
    }
}