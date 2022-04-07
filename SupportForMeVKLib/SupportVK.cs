using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace SupportForMeVKLib
{
    public abstract class SupportVK
    {
        protected string TOKEN;
        protected string version;
        protected HttpClient client;
        protected WebClient webclient;
        public string UserID { get; private set; }
        public SupportVK(string token, string version = "5.131")
        {
            TOKEN = token;
            client = new HttpClient();
            webclient = new WebClient() { Proxy = null };
            this.version = version;
        }
        public async void SetUserID(string surname)
        {
            HttpResponseMessage response = await client.GetAsync($"https://api.vk.com/method/users.get?user_ids={surname}&access_token={TOKEN}&v={version}");
            string text = await response.Content.ReadAsStringAsync();
            UserID = (string)JObject.Parse(text)["response"][0]["id"];
        }
    }
}
