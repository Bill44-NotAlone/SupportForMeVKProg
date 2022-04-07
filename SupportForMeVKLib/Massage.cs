using Newtonsoft.Json.Linq;

namespace SupportForMeVKLib
{
    public class Massage : SupportVK
    {
        public Massage(string token, string version = "5.131") : base(token, version) { }

        public void Send(string user_id, string message)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/messages.send?random_id=1&peer_id={user_id}&message={message}&access_token={TOKEN}&v={version}"));
        }
    }
}
