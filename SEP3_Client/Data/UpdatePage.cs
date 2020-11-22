using System;
using SEP3_Client.Pages;

namespace SEP3_Client.Data
{
    public class UpdatePage
    {
        public static void Update()
        {
            Console.WriteLine("--------------------------------");
            FriendList.GetPage().Update();
        }
    }
}