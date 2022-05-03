using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace SupportForMeVKLib
{
    public class SupportVK
    {
        protected static string TOKEN;
        protected static string version;
        protected static WebClient webclient;

        public string UserID { get; private set; }
        public Massage Massage { get; }
        public Account Account { get; }
        public Status Status { get; }

        public SupportVK(string token, string version = "5.131")
        {
            TOKEN = token;
            webclient = new WebClient() { Proxy = null };
            SupportVK.version = version;
            Massage = new Massage();
            Account = new Account();
            Status = new Status();
        }

        protected SupportVK() { }

        public void SetUserID(string surname)
        {
            string text = webclient.DownloadString($"https://api.vk.com/method/users.get?user_ids={surname}&access_token={TOKEN}&v={version}");
            UserID = (string)JObject.Parse(text)["response"][0]["id"];
        }
    }
}
