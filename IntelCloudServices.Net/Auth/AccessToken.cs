using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelCloudServices.Net.Auth
{
    class AccessToken
    {
        public Guid token {get; set;}
        public Guid refresh_token {get; set;}
        public String expires_in {get; set;}
        public String authentication_type { get; set; }    
    }
}
