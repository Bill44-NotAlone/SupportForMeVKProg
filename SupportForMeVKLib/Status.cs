using Newtonsoft.Json.Linq;
using System;

namespace SupportForMeVKLib
{
    public class Status : SupportVK
    {
        public Status(string token, string version = "5.131") : base(token, version) { }

        public int SetUser(string message)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/status.set?text={message}&access_token={TOKEN}&v={version}"));
            if (pairs.ContainsKey("error")) return -1;
            else return (int)pairs["response"];
        }

        public int SetGroup(string message, string group_id)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/status.set?text={message}&group_id={group_id}&access_token={TOKEN}&v={version}"));
            if (pairs.ContainsKey("error")) return -1;
            else return (int)pairs["response"];
        }

        public string GetUser(string user_id)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/status.get?user_id={user_id}&access_token={TOKEN}&v={version}"));
            if (pairs.ContainsKey("error")) return "-1";
            else return (string)pairs["response"]["text"];
        }
        public string GetGroup(string group_id)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/status.get?group_id={group_id}&access_token={TOKEN}&v={version}"));
            if (pairs.ContainsKey("error")) return "-1";
            else return (string)pairs["response"]["text"];
        }
    }
}
