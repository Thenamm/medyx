using System;

namespace DEMO_SDK
{
    class Property
    {
        public Property(String baseUrl, String relyingParty, String relyingPartyUser, String relyingPartyPassword, String relyingPartySignature, String relyingPartyKeyStore, String relyingPartyKeyStorePassword)
        {
            this.baseUrl = baseUrl;
            this.relyingParty = relyingParty;
            this.relyingPartyUser = relyingPartyUser;
            this.relyingPartyPassword = relyingPartyPassword;
            this.relyingPartySignature = relyingPartySignature;
            this.relyingPartyKeyStore = relyingPartyKeyStore;
            this.relyingPartyKeyStorePassword = relyingPartyKeyStorePassword;
        }

        public String profile = "rssp-119.432-v2.0";
        public String baseUrl { get; }
        public String relyingParty { get; }
        public String relyingPartyUser { get;  }
        public String relyingPartyPassword { get;  }
        public String relyingPartySignature { get;  }
        public String relyingPartyKeyStore { get; } 
        public String relyingPartyKeyStorePassword { get;  }


        public string getAuthorization(string username, string password)
        {
            string timestamp = Utils.CurrentTimeMillis().ToString();
            string data2sign = relyingPartyUser + relyingPartyPassword + relyingPartySignature + timestamp;
            string pkcs1Signature = Utils.getPKCS1Signature(data2sign, relyingPartyKeyStore, relyingPartyKeyStorePassword);
            //sreturn "SSL2 " + Utils.Base64Encode(Encoding.ASCII.GetBytes(DemoFunction.relyingPartyUser + ":"+ DemoFunction.relyingPartyPassword + ":"+ DemoFunction.relyingPartySignature + ":"+ timestamp + ":"+ pkcs1Signature));
            //return "SSL2 " + Utils.Base64Encode((relyingPartyUser + ":" + relyingPartyPassword + ":" + relyingPartySignature + ":" + timestamp + ":" + pkcs1Signature));

            string SSL2 = relyingPartyUser + ":" + relyingPartyPassword + ":" + relyingPartySignature + ":" + timestamp + ":" + pkcs1Signature;
            string Basic = "USERNAME:" + username + ":" + password;
            string BasicEncode = Utils.Base64Encode(Basic);

            //string test = Convert.ToBase64String(byteSSL2);

            return "SSL2 " + Utils.Base64Encode(SSL2)
                + ", Basic "
                + BasicEncode;
        }
    }
}
