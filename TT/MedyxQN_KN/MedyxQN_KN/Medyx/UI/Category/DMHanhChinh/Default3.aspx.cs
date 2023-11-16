//using CrystalDecisions.Web.Services;
using Lucene.Net.Index;
using Lucene.Net.Support;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Web;
//using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI.com.hisoftware.api2;


public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServicePointManager.CheckCertificateRevocationList = false;
        ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
        ServicePointManager.Expect100Continue = true;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        ServicePointManager.DefaultConnectionLimit = 9999;


        string relyingPartyUser = "MPKI_QUANGNINH_BVYDCT";
        //string credentialID;
        string relyingPartyPassword = "9Zs8TxDb";
        string relyingPartySignature = "VSUs9lQxtI48V23/EQKMd95MvaSkjBnJEOhziLwJaIXj+wy/KtDHZ96aPQCiof41oFP3qd8Qo0k7Uq4frMPb8phSeiftbvuUpK8DYmJVgRHnKJxBYe2g2bPjk5I5jOH1+l3dfsQVdmb4fH5oVfSStkLPbW35nkRRT+ga/3jYizCcCv58QzbZglKKkHBgzHUY8Y7eGR5bNejxfQGcu1/3jOkUKE6DscxnV4jGFO2aTrU0i/KfyuuVh5lpJQOicCaU7Zf0t/Iwdlpw07tQIvbF4UFCX1haR2WPRrprNoZ4w4F0Anim3AayMbRed7EWg8nQgfUau7JNJ2iiQXm73/SZ+A==";
        string relyingPartyKeyStore = "MPKI_QUANGNINH_BVYDCT.p12";
        string relyingPartyKeyStorePassword = "HV9kNXNP";
        string username = "vuthihuyentrang9@quangninh.gov.vn";
        string password = "57905736";

        string timestamp = Utils.CurrentTimeMillis().ToString();
        string data2sign = relyingPartyUser + relyingPartyPassword +relyingPartySignature + timestamp;
        string pkcs1Signature = Utils.getPKCS1Signature(data2sign,relyingPartyKeyStore,relyingPartyKeyStorePassword);
        string SSL2 = relyingPartyUser + ":" + relyingPartyPassword + ":" +relyingPartySignature + ":" + timestamp + ":" + pkcs1Signature;

        string Basic = "USERNAME:" + username + ":" + password;
        string BasicEncode = Utils.Base64Encode(Basic);

        string authHeader = "SSL2 " + Utils.Base64Encode(SSL2) + ", Basic " + BasicEncode;
        string portvgca = "";
        string loaitokenvgca = "DNVGCA";

        DataTable dc = GetPort_BHXH(loaitokenvgca);
        if (dc.Rows.Count > 0)
        {
            portvgca = dc.Rows[0][0].ToString();
            WriteLog("portvgca: " + portvgca);
        }
        Sign sign = new Sign
        {
            relyingParty = "MPKI_QUANGNINH_BVYDCT",
            //rpRequestID = "",
            //requestID = "",
            rememberMeEnabled = true,
            lang = "VN",
            profile = "rssp-119.432-v2.0",
        };

        clientInfo client = new clientInfo
        {
            iccid = "",
            imei = "",
            //o = "",
        };
        sign.clientInfo = client;

        tseNotification notification = new tseNotification
        {
            notificationMessage = "",
            messageCaption = "",
            message = "",
            logoURI = "",
            bgImageURI = "",
            rpIconURI = "",
            rpName = "",
            vcEnabled = "False",
            scaIdentity = "RP/vCSP",
            confirmationPolicy = "TAP",
            validityPeriod = 30,
            hashes = "",
            hashAlgorithmOID = "",
        };
        sign.tseNotification = notification;

        var _sign = JsonConvert.SerializeObject(sign);
        WriteLog("_sign: " + _sign);
        //var _sign1 = JsonConvert.SerializeObject(client);
        //var _sign2 = JsonConvert.SerializeObject(notification);


        string token1 = LoginToken(portvgca, _sign, authHeader);
        WriteLog("token1: " + token1);
        string url = "";
        string portvgcalist = "";
        string loailistvgca = "DNVGCALIST";

        DataTable dt = GetPort_BHXH(loailistvgca);
        if (dt.Rows.Count > 0)
        {
            portvgcalist = dt.Rows[0][0].ToString();
            WriteLog("portvgcalist: " + portvgcalist);
        }

        List list = new List
        {
            rpRequestID = "",
            requestID = "",
            lang = "VN",
            agreementUUID = "",
            //credentialID = "",
            certificates = "single",
            certInfoEnabled = true,
            authInfoEnabled = false,
         
            profile = "rssp-119.432-v2.0"
        };
        searchConditions search  = new searchConditions
        {
            certificateStatus = "ALL",
            certificatePurpose = "ALL"

        };
        list.searchConditions = search;
        var _list = JsonConvert.SerializeObject(list);
        WriteLog("_list: " + _list);

        string credentialslist = Credentialslist(portvgcalist, _list, token1);
        WriteLog("credentialslist: " + credentialslist);


        string portvgcainfo = "";
        string loaiinfovgca = "DNVGCAINFO";
        DataTable dr = GetPort_BHXH(loaiinfovgca);
        if (dr.Rows.Count > 0)
        {
            portvgcainfo = dr.Rows[0][0].ToString();
            WriteLog("portvgcainfo: " + portvgcainfo);
        }

        Info info = new Info
        {
            lang = "VN",
            agreementUUID = null,
            credentialID = credentialslist, 
            certificates = "single",
            certInfoEnabled = false,
            authInfoEnabled = false,           
            profile = "rssp-119.432-v2.0"
        };
        var _info = JsonConvert.SerializeObject(info);
        WriteLog("_info: " + _info);
        string credentialsinfo = Credentialsinfo(portvgcalist, _info, token1);
        WriteLog("credentialsinfo: " + credentialsinfo);


        string portvgcaauth = "";
        string loaiauthvgca = "DNVGCAAUTH";
        DataTable dv = GetPort_BHXH(loaiauthvgca);
        if (dv.Rows.Count > 0)
        {
            portvgcaauth = dv.Rows[0][0].ToString();
            WriteLog("portvgcaauth: " + portvgcaauth);
        }

        Auth auth = new Auth
        {
            rpRequestID = "",
            requestID = "",
            agreementUUID = "",
            credentialID = credentialslist,
            authorizeCode = "",
            lang = "VN",
            numSignatures = 2,
            notificationMessage = "",
            messageCaption = "",
            message = "",
            logoURI = "",
            bgImageURI = "",
            rpIconURI = "",
            rpName = "",
            confirmationPolicy = "",
            vcEnabled = true,
            acEnabled = true,
            operationMode = "",
            scaIdentity = "",
            responseURI = "",
            validityPeriod = 0, 
            profile = "",
            documents = "",
            signAlgo = "",
            signAlgoParams = ""
        };
        documentDigests authdoc = new documentDigests
        {
            hashes = "",
            hashAlgorithmOID = ""
        };
        auth.documentDigests = authdoc;

        clientInfo  authcl = new clientInfo
        {
            iccid = "",
            imei = "",
            macAddr = "",
            instanceUUID = ""
        };
        auth.clientInfo = authcl;



        var _auth = JsonConvert.SerializeObject(auth);


        string credentialsauth = Credentialsauth(portvgcaauth, _auth, token1);
        WriteLog("credentialsauth: " + credentialsauth);
        string portvgcaHash = "";
        string loaiHashvgca = "DNVGCAINFO";
        DataTable dn = GetPort_BHXH(loaiHashvgca);
        if (dn.Rows.Count > 0)
        {
            portvgcaHash = dn.Rows[0][0].ToString();
        }

        Hash hash = new Hash
        {
            rpRequestID = "",
            requestID = "",
            lang = "",
            agreementUUID = "",
            credentialID = "",
            SAD = "",
            signAlgo = "",
            signAlgoParams = "",
            operationMode = "",
            scaIdentity = "",
            responseURI = "",
            validityPeriod = "",
            profile = ""
        };


        Hash.documentDigests doc = new Hash.documentDigests
        {
            hashes = "",
            hashAlgorithmOID = ""
        };


        Hash.clientInfo cli = new Hash.clientInfo
        {
            instanceUUID = ""
        };

        var _hash = JsonConvert.SerializeObject(hash);

        string credentialshash = Credentialshash(portvgcaHash, _auth);


    }

    #region
    public class Utils
    {

        public static string getPKCS1Signature(string data, string key, string passkey)
        {
            MakeSignature mks = new MakeSignature(data, key, passkey);
            return mks.getSignature();
        }

        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }

        private static long nanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }

        internal static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static String Base64Encode(byte[] rawData)
        {
            //Console.WriteLine(Encoding.Default.GetString(rawData));
            var data = System.Convert.ToBase64String(rawData);
            return data;
            //return System.Text.Encoding.UTF8.GetBytes(data);
        }

        public static byte[] Base64Decode(String base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            //Console.WriteLine(Encoding.Default.GetString(base64EncodedBytes));
            return base64EncodedBytes;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static String computeVC(DocumentDigests doc)
        {
            List<byte[]> hashes = doc.hashes;
            int hshLen = hashes[0].Length;
            BitArray bits = new BitArray(new byte[hshLen]);
            foreach (byte[] h in hashes)
            {
                bits.Xor(new BitArray(h));
            }

            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            byte[] final = SHA256.Create().ComputeHash(ret);

            byte[] vc = new byte[4];
            vc[0] = final[0];
            vc[1] = final[1];
            vc[2] = final[hshLen - 2];
            vc[3] = final[hshLen - 1];
            //Console.WriteLine(Utils.ByteArrayToString(final));
            return String.Format("{0:X2}{1:X2}-{2:X2}{3:X2}", vc[0], vc[1], vc[2], vc[3]);

        }
    }

    public enum HashAlgorithmOID
    {
        //[Description("1.3.14.3.2.26")]
        [EnumMember(Value = "1.3.14.3.2.26")]
        SHA_1,
        //[Description("2.16.840.1.101.3.4.2.1")]
        [EnumMember(Value = "2.16.840.1.101.3.4.2.1")]
        SHA_256,
        //[Description("2.16.840.1.101.3.4.2.2")]
        [EnumMember(Value = "2.16.840.1.101.3.4.2.2")]
        SHA_384,
        //[Description("2.16.840.1.101.3.4.2.3")]
        [EnumMember(Value = "2.16.840.1.101.3.4.2.3")]
        SHA_512,
    }
    public class DocumentDigests
    {
        public List<byte[]> hashes { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Nullable<HashAlgorithmOID> hashAlgorithmOID { get; set; }
    }
    public   class MakeSignature
    {
        private String data;
        private String key;
        private String passKey;

        public MakeSignature(String data, String PriKeyPath, String PriKeyPass)
        {
            this.data = data;
            this.key = PriKeyPath;
            this.passKey = PriKeyPass;
        }

        public String getSignature()
        {
            System.Security.Cryptography.RSACryptoServiceProvider key = GetKey();
            return Sign(this.data, key);
        }

        public static string Sign(string content, System.Security.Cryptography.RSACryptoServiceProvider rsa)
        {
            System.Security.Cryptography.RSACryptoServiceProvider crsa = rsa;
            byte[] Data = Encoding.UTF8.GetBytes(content);
            byte[] signData = crsa.SignData(Data, "sha1");
            return Convert.ToBase64String(signData);

        }
        string p12FilePassword = "HV9kNXNP";
        private System.Security.Cryptography.RSACryptoServiceProvider GetKey()
        {
            string p12FileName = "MPKI_QUANGNINH_BVYDCT.p12";
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string p12FilePath = Path.Combine(directory, p12FileName);
            if (File.Exists(p12FilePath))
            {
                var certificate = new X509Certificate2(File.ReadAllBytes(p12FilePath),
                    p12FilePassword,
                    X509KeyStorageFlags.MachineKeySet |
                    X509KeyStorageFlags.PersistKeySet |
                    X509KeyStorageFlags.Exportable);
               
                System.Security.Cryptography.RSACryptoServiceProvider rsa = (System.Security.Cryptography.RSACryptoServiceProvider)certificate.PrivateKey;
                return rsa;
         
            }
            else
            {
              
                return null;
            }
        }



    }
    public class Sign
    {

        public string relyingParty { get; set; }

        public string rpRequestID { get; set; }

        public string requestID { get; set; }

        public Boolean rememberMeEnabled { get; set; }

        public clientInfo clientInfo { get; set; }

        public string lang { get; set; }
        public string profile { get; set; }
        public tseNotification tseNotification { get; set; }




    }

    public class clientInfo
    {
        public string iccid { get; set; }
        public string imei { get; set; }

        public string macAddr { get; set; }

        public string instanceUUID { get; set; }
    }

    public class tseNotification
    {
        public string notificationMessage { get; set; }
        public string messageCaption { get; set; }
        public string message { get; set; }
        public string logoURI { get; set; }
        public string bgImageURI { get; set; }
        public string rpIconURI { get; set; }

        public string rpName { get; set; }

        public string vcEnabled { get; set; }

        public string scaIdentity { get; set; }

        public string confirmationPolicy { get; set; }

        public int validityPeriod { get; set; }

        public string hashes { get; set; }

        public string hashAlgorithmOID { get; set; }
    }
    public class Signdaura
    {

        public int error { get; set; }
        public string errorDescription { get; set; }
        public string responseID { get; set; }
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public int expiresIn { get; set; }
        public int remainingCounter { get; set; }
        public int tempLockoutDuration { get; set; }

        public ownerInfo ownerInfo { get; set; }
        public string authorizeToken { get; set; }


    }
    public class ownerInfo
    {
        public string fullName { get; set; }
        public string phone { get; set; }

        public string email { get; set; }
        public string oauth2 { get; set; }
    }

    public class List
    {

        public string rpRequestID { get; set; }

        public string requestID { get; set; }

        public string agreementUUID { get; set; }

        public searchConditions searchConditions { get; set; }

        public Boolean certInfoEnabled { get; set; }
        public string certificates { get; set; }
        public Boolean authInfoEnabled { get; set; }
        public string lang { get; set; }
        public string profile { get; set; }

    }

    public class searchConditions
    {
        public string certificateStatus { get; set; }

        public string certificatePurpose { get; set; }
    }

    public class Listdaura
    {

        public int error { get; set; }
        public string errorDescription { get; set; }
        public string responseID { get; set; }
        public List<certs> certs { get; set; }
    }

    public class certs
    {
        public string issuerDN { get; set; }
        public string serialNumber { get; set; }
        public string credentialID { get; set; }
        public string subjectDN { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public string name { get; set; }

        public string description { get; set; }
        public string purpose { get; set; }

        public int multisign { get; set; }

        public int remainingSigningCounter { get; set; }

        public int version { get; set; }

        public string certificates { get; set; }

        public string authorizationEmail { get; set; }
        public string authorizationPhone { get; set; }
        public string status { get; set; }

        public string statusDesc { get; set; }
        public Boolean trialEnabled { get; set; }
    }
    public class Info
    {

        //public string rpRequestID { get; set; }

        //public string requestID { get; set; }
        public string lang { get; set; }  

        public string agreementUUID { get; set; }

        public string credentialID { get; set; }

        public string certificates { get; set; }
        public Boolean certInfoEnabled { get; set; }
        public Boolean authInfoEnabled { get; set; }
        public string profile { get; set; }


    }
    public class Infodaura
    {

        public int error { get; set; }
        public string errorDescription { get; set; }
        public string responseID { get; set; }
        public cert cert { get; set; }
        public int csr { get; set; }

        public string sharedMode { get; set; }

        public string createdRP { get; set; }
        public Boolean multisign { get; set; }

        public Boolean authModes { get; set; }
        public string authMode { get; set; }

        public string SCAL { get; set; }
        public string contractExpirationDate { get; set; }
        public string remainingSigningCounter { get; set; }
        public int authorizationEmail { get; set; }
        public string authorizationPhone { get; set; }
        public string defaultPassphraseEnabled { get; set; }
        public string trialEnabled { get; set; }




    }


    public class cert
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public string certificates { get; set; }
        public string issuerDN { get; set; }
        public string serialNumber { get; set; }
        public string thumbprint { get; set; }

        public string subjectDN { get; set; }
        public string validFrom { get; set; }

        public string validTo { get; set; }



        public certificateProfile certificateProfile { get; set; }


        public certificateAuthority certificateAuthority { get; set; }


        public string purpose { get; set; }
        public string version { get; set; }

        public string name { get; set; }
        public string description { get; set; }

    }
    public class certificateProfile
    {
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }

    }
    public class certificateAuthority
    {

        public string name { get; set; }
        public string description { get; set; }

    }

    public class Auth
    {

        public string rpRequestID { get; set; }

        public string requestID { get; set; }

        public string agreementUUID { get; set; }

        public string credentialID { get; set; }

        public string authorizeCode { get; set; }
        public string lang { get; set; }
        public int numSignatures { get; set; }
        public documentDigests documentDigests { get; set; }

        public clientInfo clientInfo { get; set; }
        public string notificationMessage { get; set; }
        public string messageCaption { get; set; }
        public string message { get; set; }

        public string logoURI { get; set; }

        public string bgImageURI { get; set; }

        public string rpIconURI { get; set; }

        public string rpName { get; set; }
        public string confirmationPolicy { get; set; }

        public Boolean vcEnabled { get; set; }

        public Boolean acEnabled { get; set; }

        public string operationMode { get; set; }

        public string scaIdentity { get; set; }


        public string responseURI { get; set; }

        public int validityPeriod { get; set; }

        public string profile { get; set; }
        public string documents { get; set; }

        public string signAlgo { get; set; }
        public string signAlgoParams { get; set; }


    }

    public class documentDigests
    {
        public string hashes { get; set; }
        public string hashAlgorithmOID { get; set; }
    }
    //public class clientInfo
    //{
    //    public string iccid { get; set; }

    //    public string imei { get; set; }

    //    public string macAddr { get; set; }

    //    public string instanceUUID { get; set; }
    //}


    public class Authdaura
    {

        public int error { get; set; }
        public string errorDescription { get; set; }
        public string responseID { get; set; }
        public string SAD { get; set; }
        public int expiresIn { get; set; }
        public int remainingCounter { get; set; }
        public int tempLockoutDuration { get; set; }
        public string hashes { get; set; }
        public documentDigests documentDigests { get; set; }




    }




    public class Hash
    {

        public string rpRequestID { get; set; }

        public string requestID { get; set; }

        public string lang { get; set; }

        public string agreementUUID { get; set; }

        public string credentialID { get; set; }
        public string SAD { get; set; }
        public class documentDigests
        {
            public string hashes { get; set; }
            public string hashAlgorithmOID { get; set; }
        }
        public string signAlgo { get; set; }

        public string signAlgoParams { get; set; }

        public string operationMode { get; set; }

        public string scaIdentity { get; set; }
        public class clientInfo
        {
            public string instanceUUID { get; set; }
        }
        public string responseURI { get; set; }
        public string validityPeriod { get; set; }

        public string profile { get; set; }




    }
    public class daura
    {

        public int error { get; set; }
        public string errorDescription { get; set; }
        public string responseID { get; set; }
        public string signatures { get; set; }
        public int remainingSigningCounter { get; set; }
        public int remainingCounter { get; set; }
        public int tempLockoutDuration { get; set; }


    }
    #endregion
    public static string LoginToken(string url, string json,string ssl2 )  //Đăng nhập lấy token
    {
        try
        {

            var _sign = json;
         
            #region Http Post

            string messageUri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers["Authorization"] = ssl2;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
           // return pageContent;
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<Signdaura>(pageContent);
            return data.accessToken;
            #endregion


        }
        catch (Exception ex)
        {
            //ghi log
            return "";
        }
    }

    public static string Credentialslist(string url, string json, string token1)
    {
        try
        {
            
            var _sign = json;
            #region Http Post
            string messageUri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + token1;

            //using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    streamWriter.Write(json);
            //}

            //HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
            //using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //     result = streamReader.ReadToEnd();
            //}
            //return result;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
            //var serializer = new JavaScriptSerializer();
            //var data = serializer.Deserialize<Listdaura>(pageContent);
            //return data.certs[0].credentialID;
            #endregion
        }
        catch (Exception ex)
        {
            // Ghi log
            return "";
        }
    }


    public static string Credentialsinfo(string url, string json, string token1)  //Đăng nhập lấy token
    {
        try
        {
            var _sign = json;
            #region Http Post
            string messageUri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
            request.ContentType = "application/json";         
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + token1;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }


            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
            //var serializer = new JavaScriptSerializer();
            //var data = serializer.Deserialize<Responsecks>(pageContent);
            //return data.APIKey.access_token;
            #endregion


        }
        catch (Exception ex)
        {
            //ghi log
            return "";
        }
    }
    public static string Credentialsauth(string url, string json, string token1)  //Đăng nhập lấy token
    {
        try
        {
            var _sign = json;
            #region Http Post
            string messageUri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
            request.ContentType = "application/json";
            // request.Headers.Add("Authorization", "Bearer " + token1);
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + token1;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
            //var serializer = new JavaScriptSerializer();
            //var data = serializer.Deserialize<Responsecks>(pageContent);
            //return data.APIKey.access_token;
            #endregion


        }
        catch (Exception ex)
        {
            //ghi log
            return "";
        }
    }

    public static string Credentialshash(string url, string json)  //Đăng nhập lấy token
    {
        try
        {
            var _sign = json;
            #region Http Post

            string messageUri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
            request.Headers.Add("Authorization", "Bearer" + _sign);
            request.ContentType = "application/json ";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
            //var serializer = new JavaScriptSerializer();
            //var data = serializer.Deserialize<Responsecks>(pageContent);
            //return data.APIKey.access_token;
            #endregion


        }
        catch (Exception ex)
        {
            //ghi log
            return "";
        }
    }

    public DataTable GetPort_BHXH(string loai)
    {
        DataTable dr = new DataTable();
        string tenStore = "PACS_Port_Get_BHXH";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@Loai", loai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            //if (dr.Rows.Count > 0)
            return dr;
            //else
            //    return "";
        }
    }
    public static void WriteLog(string log)
    {
        string logname = "vgcaLog_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
        //string fileName = HttpContext.Current.Request.MapPath("MyLogs.txt");
        string fileName = HttpContext.Current.Request.MapPath(logname);
        if (!File.Exists(fileName))
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + log);
                sw.Close();
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + log);
                sw.Close();
            }
        }
    }
}