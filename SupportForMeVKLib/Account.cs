using Newtonsoft.Json.Linq;

namespace SupportForMeVKLib
{
    public class Account : SupportVK
    {
        public void Ban(string owner_id)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/account.ban?owner_id={owner_id}&access_token={TOKEN}&v={version}"));
        }

        public JObject GetProfileInfo()
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/account.getProfileInfo?access_token={TOKEN}&v={version}"));
            return pairs;
        }

        public int SetOffline()
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/account.setOffline?access_token={TOKEN}&v={version}"));
            return (int)pairs["response"];
        }
        public int SetOnline(int voip = 0)
        {
            JObject pairs = JObject.Parse(webclient.DownloadString($"https://api.vk.com/method/account.setOnline?voip={voip}&access_token={TOKEN}&v={version}"));
            return (int)pairs["response"];
        }
    }
}
