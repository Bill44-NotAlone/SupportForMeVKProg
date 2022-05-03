using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace SupportForMeVKLib
{
    public class Friends : SupportVK
    {
        public enum Order { hints, random, name }
        public string[] GetListFriends(Order order)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/friends.get?user_id={UserID}&order={order}&access_token={TOKEN}&v={version}"));
            List<string> frendsid = new List<string>();
            foreach (string id in pairs["response"]["items"]) frendsid.Add(id);
            return frendsid.ToArray();
        }
    }
}
