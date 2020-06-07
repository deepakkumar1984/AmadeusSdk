using AmadeusSdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;

namespace AmadeusSdk
{
    public class AuthClient
    {
        private string client_id;
        private string client_secret;
        internal string _baseUrl = "https://test.api.amadeus.com/v1";

        public AuthClient(string clientId, string clientSecret, bool isLive = false)
        {
            client_id = clientId;
            client_secret = clientSecret;
            if (isLive)
                _baseUrl = _baseUrl.Replace("test.", "");
        }

        public AuthToken GenerateAccessToken()
        {
            string url = $"{_baseUrl}/security/oauth2/token";
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("client_id", client_id));
            postData.Add(new KeyValuePair<string, string>("client_secret", client_secret));
            postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            var content = new FormUrlEncodedContent(postData);

            HttpClient client = new HttpClient();
            var ret = client.PostAsync(url, content).Result;
            if (ret.StatusCode != System.Net.HttpStatusCode.OK)
                throw new AuthenticationException(ret.Content.ReadAsStringAsync().Result);

            AuthToken token = JsonConvert.DeserializeObject<AuthToken>(ret.Content.ReadAsStringAsync().Result);
            return token;
        }

        public AuthToken GetTokenInfo(string access_token)
        {
            string url = $"{_baseUrl}/security/oauth2/token/{access_token}";
            HttpClient client = new HttpClient();
            var ret = client.GetAsync(url).Result;
            if (ret.StatusCode != System.Net.HttpStatusCode.OK)
                throw new AuthenticationException(ret.Content.ReadAsStringAsync().Result);

            AuthToken token = JsonConvert.DeserializeObject<AuthToken>(ret.Content.ReadAsStringAsync().Result);
            return token;
        }
    }
}
