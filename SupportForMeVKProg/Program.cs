using SupportForMeVKLib;
using System;

namespace SupportForMeVKProg
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ваша реализация
            SupportVK supportVK = new SupportVK("247c8656af383f37b05ce5d06261704806b0fa510448602eb1c068ae19308915338699c0b4afff2255c1e");
            supportVK.SetUserID("bill44");
            Console.WriteLine(supportVK.Friends.GetListFriends(Friends.Order.hints)[6]);
            Console.ReadLine();
        }
    }
}
