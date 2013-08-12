using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelCloudServices.Net
{
    class ClientConfig
    {
        public string APIURI { get; set; }
        public string OAuthURI { get; set; }
        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }
        public string RedirectURI { get; private set; }

        public ClientConfig(string apiURI, string oauthURI, string clientId, string clientSecret, string redirectURI)
        {
            APIURI = apiURI;
            OAuthURI = oauthURI;
            ClientId = clientId;
            ClientSecret = clientSecret;
            RedirectURI = redirectURI;
        }
    }
}
