using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Web;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Security.Policy;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            var mst = "0101243150-042";

            Sign sign = new Sign();
            sign.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            sign.taxcode = "0101243150-042";
            sign.username = "testmisa@yahoo.com";
            sign.password = "123456Aa";


            //linkurl
            string url1 = "https://testapi.meinvoice.vn/api/v3/itg/invoicepublishing/createinvoice";
            string url2 = "https://testapi.meinvoice.vn/api/v3/auth/token";
            string url3 = "https://testapi.meinvoice.vn/api/v3/itg/InvoicePublishing/templates?invyear=" + DateTime.Now.ToString("yyyy");
            string urlsignthebill = "http://192.1.0.33:12019/api/SignXML";
            string urlIssuetheinvoice = "https://testapi.meinvoice.vn/api/v3/itg/invoicepublishing";
            //string urlCancelinvoice = "https://testapi.meinvoice.vn/api/v3/itg/invoicepublished/cancel";
            string urlSeethebill = "https://testapi.meinvoice.vn/api/v3/invoicepublished/linkview";



            var _sign = JsonConvert.SerializeObject(sign);

            string token1 = LoginToken(url2, _sign,mst);//dangnhaplaytoken

            string token3 = getlistofinvoicetemplates(url3, token1,mst); //lấy danh sách mẫu hóa đơn
            OriginalInvoiceData dm = new OriginalInvoiceData();
            dm.RefID = "dg1234344355443266436";
            dm.InvSeries = token3;
            dm.InvoiceName = "Hóa đơn giá trị gia tăng";
            dm.InvDate = DateTime.Now;
            dm.CurrencyCode = "VND";
            dm.ExchangeRate = 1;
            dm.PaymentMethodName = "TM/CK";
            dm.BuyerLegalName = "Công ty cổ phần MISA";
            dm.BuyerTaxCode = "0101243150";
            dm.BuyerAddress = "Tầng 9 tòa nhà Technosoft, Duy Tân, Dịch Vọng Hậu, Cầu Giấy, Hà Nội";
            dm.BuyerCode = "MS001";
            dm.BuyerPhoneNumber = "0241 522 526";
            dm.BuyerEmail = "contact@misa.com.vn";
            dm.BuyerFullName = "Nguyễn Xuân Hoàng";
            dm.BuyerBankAccount = "010124315087210";
            dm.BuyerBankName = "Ngân hàng Việt Nam Thịnh Vượng";
            dm.ReferenceType = null;
            dm.OrgInvoiceType = null;
            dm.OrgInvTemplateNo = null;
            dm.OrgInvSeries = null;
            dm.OrgInvNo = null;
            dm.OrgInvDate = null;
            dm.TotalSaleAmountOC = 7540000;
            dm.TotalAmountWithoutVATOC = 7540000;
            dm.TotalVATAmountOC = 381950;
            dm.TotalDiscountAmountOC = 460000;
            dm.TotalAmountOC = 7921950;
            dm.TotalSaleAmount = 7540000;
            dm.TotalAmountWithoutVAT = 7540000;
            dm.TotalVATAmount = 381950;
            dm.TotalDiscountAmount = 460000;
            dm.TotalAmount = 7921950;
            dm.TotalAmountInWords = "Bảy triệu chín trăm hai mươi mốt nghìn chín trăm năm mươi đồng.";
            List<OriginalInvoiceDetail> lo = new List<OriginalInvoiceDetail>();
            OriginalInvoiceDetail lol = new OriginalInvoiceDetail();
            lol.ItemType = 1;
            lol.LineNumber = 1;
            lol.SortOrder = 1;
            lol.ItemCode = "AOSM01";
            lol.ItemName = "Áo sơ mi Nam 40";
            lol.UnitName = "Chiếc";
            lol.Quantity = 10;
            lol.UnitPrice = 500000;
            lol.DiscountRate = 5;
            lol.DiscountAmountOC = 250000;
            lol.DiscountAmount = 250000;
            lol.AmountOC = 5000000;
            lol.Amount = 5000000;
            lol.AmountWithoutVATOC = 4750000;
            lol.AmountWithoutVAT = 4750000;
            lol.VATRateName = "5%";
            lol.VATAmountOC = 475000;
            lol.VATAmount = 475000;
            lo.Add(lol);

            dm.OriginalInvoiceDetail = lo;

            List<TaxRateInfo> li = new List<TaxRateInfo>();
            TaxRateInfo lil = new TaxRateInfo();

            lil.VATRateName = "5%";
            lil.AmountWithoutVATOC = 950000;
            lil.VATAmountOC = 47500;
            li.Add(lil);
            dm.TaxRateInfo = li;

            OptionUserDefined la = new OptionUserDefined();


            la.MainCurrency = "VND";
            la.AmountDecimalDigits = "0";
            la.AmountOCDecimalDigits = "2";
            la.UnitPriceOCDecimalDigits = "0";
            la.UnitPriceDecimalDigits = "1";
            la.QuantityDecimalDigits = "2";
            la.CoefficientDecimalDigits = "2";
            la.ExchangRateDecimalDigits = "0";

            dm.OptionUserDefined = la;
            List<OriginalInvoiceData> ldm = new List<OriginalInvoiceData>();
            ldm.Add(dm);
            var credentials = JsonConvert.SerializeObject(ldm);

            string token = Createinvoid(url1, credentials, token1, mst); //Tạo hóa đơn


            List<Datataohd> ld = JsonConvert.DeserializeObject<List<Datataohd>>(token);


          
            signthebill stbill = new signthebill();
            stbill.PinCode = "12345678";
            stbill.XmlContent = ld[0].InvoiceData;



            var _stbill = JsonConvert.SerializeObject(stbill);
            string signthebill = Signthebill1(urlsignthebill, _stbill, mst); //Ký hóa đơn


            List<RequestIssuetheinvoice> itv = new List<RequestIssuetheinvoice>();


            Responsesignthebill stbb = JsonConvert.DeserializeObject<Responsesignthebill>(signthebill);

            RequestIssuetheinvoice it = new RequestIssuetheinvoice();

            it.RefID = ld[0].RefID;
            it.TransactionID = ld[0].TransactionID;
          
            it.InvoiceData = stbb.Payload;
         
            it.IsSendEmail = false;
            it.ReceiverName = null;
      

            it.IsInvoiceSummary = false;

            itv.Add(it);
            var _it = JsonConvert.SerializeObject(itv);
            string issuetheinvoice = Issuetheinvoice(urlIssuetheinvoice, _it, token1,mst);//Phát hành hóa đơn


            // tokenLabel.Text = token;
            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = token;




            // xem hóa đơn 
            ResponseIssuetheinvoice dll = JsonConvert.DeserializeObject<ResponseIssuetheinvoice>(issuetheinvoice);
            List<Dataxemhd> ldll= JsonConvert.DeserializeObject<List<Dataxemhd>>(dll.Data);
            List<string> ls = new List<string>();
            var _bodyseethebill = ldll[0].TransactionID;
            ls.Add(_bodyseethebill);
            var lls = JsonConvert.SerializeObject(ls);
            string tokenviewthebill = Seethebill(urlSeethebill,lls,token1,mst);


            //huy hoa don 
            //Cancle cliv = new Cancle();

            //cliv.TransactionID = ldll[0].TransactionID;
            //cliv.InvNo = ldll[0].InvNo;
            //cliv.RefDate = DateTime.Now;
            //cliv.CancelReason = "hủy qua API";


            //var _cancle = JsonConvert.SerializeObject(cliv);
            //string cancel = TokenCancle(urlCancelinvoice, _cancle, token1, mst);

            try
            {
                ResponseSeethebill shd = JsonConvert.DeserializeObject<ResponseSeethebill>(tokenviewthebill);
                if ( shd!= null && shd.Data != null && shd.Data.Length > 2)
                {
                    var linkshd = shd.Data;
                    var shdl = JsonConvert.SerializeObject(linkshd);
                    string link = shdl.Replace("\"", "");
                    Page.Response.Write("<script>window.open('" + link + "', '_blank');</script>");
                }
                else
                {
                    // Handle case where Data.Count <= 1
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }

        }

        catch (Exception ex)
        {
        }
    }

    #region 
    public static string LoginToken(string url, string json , string  mst)  //Đăng nhập lấy token
    {
        try
        {
            //Sign dm = new Sign();
            //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            //dm.taxcode = "0101243150-042";
            //dm.username = "testmisa@yahoo.com";
            //dm.password = "123456Aa";
            //var credentials = JsonConvert.SerializeObject(dm);
            var  _sign = json;
            #region Http Post
            //string messageUri = "https://testapi.meinvoice.vn/api/v3/auth/token";
            string messageUri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
            request.Headers.Add("Authorization", "Basic" + _sign);
            request.Headers.Add("CompanyTaxCode", mst);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
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
            //return pageContent;
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<ResponseString>(pageContent);
            #endregion Http Post

            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = data.Data.ToString();
            if (data != null && data.Data != null && data.Data.Length > 0)
            {
                //co chuoi nhan ve 
                if (data.ErrorCode == "TokenExpiredCode")
                {
                    //goi api refeshtoken 
                    return LoginToken(url.Replace("/auth/token", "/auth/refreshtoken"), json,mst);
                }
                else
                    return data.Data;
            }
            else
            {
                //khong co chuoi nhan ve  
                return LoginToken(url, json, mst);
            }
        }
        catch (Exception ex)
        {
            //ghi log
            return "";
        }
    }

    public static string getlistofinvoicetemplates(string url2, string token , string mst)  //Lấy danh sách mẫu hóa đơn
    {
        try
        {
            //Sign dm = new Sign();
            //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            //dm.taxcode = "0101243150-042";
            //dm.username = "testmisa@yahoo.com";
            //dm.password = "123456Aa";
            //var credentials = JsonConvert.SerializeObject(dm);

            #region Http Get
            //string messageUri = "https://testapi.meinvoice.vn/api/v3/itg/invoicepublishing/createinvoice";
            string messageUri2 = url2;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri2);
            request.Headers.Add("Authorization", "Bearer " + token);
            request.Headers.Add("CompanyTaxCode", mst);
            //request.ContentType = "application/json";
            request.Method = "GET";
            //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
            //    //streamWriter.Write(json1);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            //return pageContent;
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<Responseldsmhd>(pageContent);

            #endregion Http GET
            // return pageContent;
            //return data1.Data.ToString(CreateInvoiceData);
            //return pageContent;
            //return data.Data;
            if (data != null && data.Data != null && data.Data.Length > 0)
            {
                var data1 = serializer.Deserialize<List<TemplateData>>(data.Data);
                return data1[0].InvSeries;
            }
            else
            {
                return null;
            }


            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = data.Data.ToString();

        }
        catch (Exception ex)
        {
            //ghi log
            return "eror";
        }
    }
    public static string Createinvoid(string url1, string json1, string token,string mst ) // taọ hóa đơn 
    {
        try
        {
            //Sign dm = new Sign();
            //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            //dm.taxcode = "0101243150-042";
            //dm.username = "testmisa@yahoo.com";
            //dm.password = "123456Aa";
            //var credentials = JsonConvert.SerializeObject(dm);
            var credentials = json1;
            #region Http Post
            //string messageUri = "https://testapi.meinvoice.vn/api/v3/itg/invoicepublishing/createinvoice";
            string messageUri1 = url1;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri1);
            request.Headers.Add("Authorization", "Bearer " + token);
            request.Headers.Add("CompanyTaxCode", mst);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
                streamWriter.Write(json1);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            //return pageContent;
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<Responsetaohd>(pageContent);
            #endregion Http Post
            // return pageContent;
            //return data1.Data.ToString(CreateInvoiceData);
            //return pageContent;
            return data.Data;

            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = data.Data.ToString();

        }
        catch (Exception ex)
        {
            //ghi log
            return "eror";
        }
    }

    public static string Signthebill1(string urlstb, string jsonstb, string mst)  // ký hóa đơn 
    {

        try
        {
            //Sign dm = new Sign();
            //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            //dm.taxcode = "0101243150-042";
            //dm.username = "testmisa@yahoo.com";
            //dm.password = "123456Aa";
            //var credentials = JsonConvert.SerializeObject(dm);
            var stb = jsonstb;
            #region Http Post
            //string messageUri = "https://testapi.meinvoice.vn/api/v3/auth/token";
            string messageUristb = urlstb;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUristb);
            //  request.Headers.Add("Authorization", "Bearer " );
            request.Headers.Add("CompanyTaxCode", mst);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
                streamWriter.Write(jsonstb);
                streamWriter.Flush();
                streamWriter.Close();
            }

            // HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            //Stream responseStream = myWebResponse.GetResponseStream();
            //StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            // string pageContent = myStreamReader.ReadToEnd();
            // responseStream.Close();
            //myWebResponse.Close();
            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            //return pageContent;
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<Responsesignthebill>(pageContent);
            #endregion Http Post

            return pageContent;
            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = data.Data.ToString();



        }
        catch (Exception ex)
        {
            //ghi log
            return "eror";
        }
    }

    public static string Issuetheinvoice(string urlitv, string jsonitv, string token,string  mst ) // phát hành hóa đơn 
    {

        try
        {
            //Sign dm = new Sign();
            //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            //dm.taxcode = "0101243150-042";
            //dm.username = "testmisa@yahoo.com";
            //dm.password = "123456Aa";
            //var credentials = JsonConvert.SerializeObject(dm);
            var itv = jsonitv;
            #region Http Post
            //string messageUri = "https://testapi.meinvoice.vn/api/v3/auth/token";
            string messageUriitv = urlitv;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUriitv);
            request.Headers.Add("Authorization", "Bearer " + token);
            request.Headers.Add("CompanyTaxCode", mst);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
                streamWriter.Write(jsonitv);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse =  (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();

            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<ResponseIssuetheinvoice>(pageContent);
            #endregion Http Post
            return pageContent;
            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = data.Data.ToString();



        }
        catch (Exception ex)
        {
            //ghi log
            return "error";
        }
    }


    public static string Seethebill(string urlsetb,string jsonsetb,string tokensetb,string mst)  //xem hóa đơn 
    {

        try
        {
            //Sign dm = new Sign();
            //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
            //dm.taxcode = "0101243150-042";
            //dm.username = "testmisa@yahoo.com";
            //dm.password = "123456Aa";
            //var credentials = JsonConvert.SerializeObject(dm);
            var _bodyseethebill = jsonsetb;
            #region Http Post
            //string messageUri = "https://testapi.meinvoice.vn/api/v3/auth/token";
            string messageUristbill = urlsetb;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUristbill);
            request.Headers.Add("Authorization", "Bearer " + tokensetb);
            request.Headers.Add("CompanyTaxCode", mst);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
                streamWriter.Write(jsonsetb);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();

            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<ResponseSeethebill>(pageContent);
            #endregion Http Post
            return pageContent;
            // Set the text of the label to the value of jsonString
            //tokenLabel.Text = data.Data.ToString();



        }
        catch (Exception ex)
        {
            //ghi log
            return "error";
        }
    }



    //public static string TokenCancle(string urlcl, string jsoncl, string tokencl, string mst) // huyr  hóa đơn
    //{

    //    try
    //    {
    //        //Sign dm = new Sign();
    //        //dm.appid = "FB901C53-FF73-4F8E-810D-B6BBA7203DD0";
    //        //dm.taxcode = "0101243150-042";
    //        //dm.username = "testmisa@yahoo.com";
    //        //dm.password = "123456Aa";
    //        //var credentials = JsonConvert.SerializeObject(dm);
    //        var _cancle = jsoncl;
    //        #region Http Post
    //        //string messageUri = "https://testapi.meinvoice.vn/api/v3/auth/token";
    //        string messageUricl = urlcl;
    //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUricl);
    //        request.Headers.Add("Authorization", "Bearer " + tokencl);
    //        request.Headers.Add("CompanyTaxCode", mst);
    //        request.ContentType = "application/json";
    //        request.Method = "POST";
    //        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
    //        {
    //            //string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(dm);
    //            streamWriter.Write(jsoncl);
    //            streamWriter.Flush();
    //            streamWriter.Close();
    //        }

    //        HttpWebResponse myWebResponse = (HttpWebResponse)request.GetResponse();
    //        Stream responseStream = myWebResponse.GetResponseStream();
    //        StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
    //        string pageContent = myStreamReader.ReadToEnd();
    //        responseStream.Close();
    //        myWebResponse.Close();

    //        var serializer = new JavaScriptSerializer();
    //        var data = serializer.Deserialize<Responseldsmhd>(pageContent);
    //        #endregion Http Post
    //        return pageContent;
    //        // Set the text of the label to the value of jsonString
    //        //tokenLabel.Text = data.Data.ToString();



    //    }
    //    catch (Exception ex)
    //    {
    //        //ghi log
    //        return "error";
    //    }
    //}

         
    #endregion

    #region class
    public class Response
    {

        /// thành công hay ko 

        public bool Success { get; set; }

        /// data

        public List<Data> Data { get; set; }


        /// Mã lỗi

        public string ErrorCode { get; set; }


        /// Lỗi 

        public List<string> Errors { get; set; }


        /// Dữ liệu tùy chỉnh 

        public string CustomData { get; set; }

    }

    public class Responseldsmhd
    {

        /// thành công hay ko 

        public bool Success { get; set; }

        /// data

        public string Data { get; set; }


        /// Mã lỗi

        public string ErrorCode { get; set; }


        /// Lỗi 

        public List<string> Errors { get; set; }


        /// Dữ liệu tùy chỉnh 

        public string CustomData { get; set; }

    }

    public class Responsetaohd
    {

        /// thành công hay ko 

        public bool Success { get; set; }

        /// data

        public string Data { get; set; }


        /// Mã lỗi

        public string ErrorCode { get; set; }


        /// Lỗi 

        public List<string> Errors { get; set; }


        /// Dữ liệu tùy chỉnh 

        public string CustomData { get; set; }

    }
    public class ResponseString
    {

        /// thành công hay ko 

        public bool Success { get; set; }

        /// data

        public string Data { get; set; }


        /// Mã lỗi

        public string ErrorCode { get; set; }


        /// Lỗi 

        public List<object> Errors { get; set; }


        /// Dữ liệu tùy chỉnh 

        public string CustomData { get; set; }

    }

    public class ResponseSeethebill
    {

        /// thành công hay ko 

        public bool Success { get; set; }


        /// Mã lỗi

        public string ErrorCode { get; set; }


        /// Lỗi 

        public List<object> Errors { get; set; }


        /// Dữ liệu tùy chỉnh  <summary>
        /// Dữ liệu tùy chỉnh 
        /// </summary>


        public string Data { get; set; }


        public string CustomData { get; set; }

    }
    /// dữ liệu

    public class Responsesignthebill
    {
        public int Status { get; set; }

        public string Message { get; set; }

        public string Payload { get; set; }

        public string Data { get; set; }

        public string AppVersion { get; set; }
    }

    public class ResponseIssuetheinvoice
    {

        /// thành công hay ko 

        public bool Success { get; set; }

        /// data

        public string Data { get; set; }


        /// Mã lỗi

        public string ErrorCode { get; set; }


        /// Lỗi 

        public List<string> Errors { get; set; }


        /// Dữ liệu tùy chỉnh 

        public string CustomData { get; set; }


        public string DescriptionErrorCode { get; set; }

    }
    public class Data
    {

        //CreateInvoiceData
        public List<CreateInvoiceData> CreateInvoiceData { get; set; }

        /// OriginalInvoiceData
        public List<OriginalInvoiceData> OriginalInvoiceData { get; set; }
        /// Company
        public List<CompanyInfoResult> CompanyInfoResult { get; set; }
        /// InvoiceStatus
        public List<InvoiceStatus> InvoiceStatus { get; set; }
    }
    public class Datataohd
    {
        /// <summary>
        /// ID của hóa đơn trên Client App
        /// </summary>
        public string RefID { get; set; }

        public string TransactionID { get; set; }

        public string InvNo { get; set; }
        public string InvCode { get; set; }
        public string InvDate { get; set; }

        public string InvoiceData { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorData { get; set; }

        public string TokenCallback { get; set; }

        public string CallbackUrl { get; set; }
    }

    public class Dataxemhd
    {
        /// <summary>
        /// ID của hóa đơn trên Client App
        /// </summary>
        public string RefID { get; set; }

        public string TransactionID { get; set; }


        public string  InvTemplateNo { get; set; }
        public string InvNo { get; set; }
        public string InvCode { get; set; }

        public string InvSeries { get; set; }


        public DateTime InvDate { get; set; }

        public string ErrorCode { get; set; }

        public string CustomData { get; set; }

     
    }

    public class CreateInvoiceData
    {

        /// <summary>
        /// ID của hóa đơn trên Client App
        /// </summary>
        public string RefID { get; set; }

        /// <summary>
        /// Ký hiệu hóa đơn
        /// </summary>
        public string InvSeries { get; set; }

        /// <summary>
        /// Tên hóa đơn
        /// </summary>
        public string InvoiceName { get; set; }

        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        /// <returns></returns>
        public DateTime InvDate { get; set; }

        /// <summary>
        /// Mã loại tiền tệ
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Tỷ giá
        /// </summary>
        public decimal? ExchangeRate { get; set; }


        /// <summary>
        /// Tên đơn vị mua
        /// </summary>
        public string BuyerLegalName { get; set; }

        /// <summary>
        /// MST người mua
        /// </summary>
        public string BuyerTaxCode { get; set; }

        /// <summary>
        /// Địa chỉ người mua
        /// </summary>
        public string BuyerAddress { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string BuyerCode { get; set; }

        /// <summary>
        /// ĐT người mua
        /// </summary>
        public string BuyerPhoneNumber { get; set; }

        /// <summary>
        /// Email người mua
        /// </summary>
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Tên người mua hàng
        /// </summary>
        public string BuyerFullName { get; set; }

        /// <summary>
        /// Số TK ngân hàng người mua
        /// </summary>
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng người mua
        /// </summary>
        public string BuyerBankName { get; set; }
        /// <summary>
        /// Tính chất hóa đơn (1: thay thế; 2: điều chỉnh)
        /// </summary>
        public int? ReferenceType { get; set; }

        /// <summary>
        /// Loại hóa đơn bị thay thế/điều chỉnh (1: Hóa đơn 123; 2: Hóa đơn có mã; 3: Hóa đơn 51; 4: Hóa đơn đặt in 123)
        /// </summary>
        public int? OrgInvoiceType { get; set; }

        /// <summary>
        /// Ký hiệu mẫu hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvTemplateNo { get; set; }

        /// <summary>
        /// Ký hiệu hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvSeries { get; set; }

        /// <summary>
        /// Số hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvNo { get; set; }

        /// <summary>
        /// Ngày hóa đơn bị thay thế/điều chỉnh
        /// </summary>
        public DateTime? OrgInvDate { get; set; }
        /// <summary>
        /// tổng tiền chưa thuế
        /// </summary>
        public decimal? TotalAmountWithoutVATOC { get; set; }

        /// <summary>
        /// Tổng tiền thuế
        /// </summary>
        public decimal? TotalVATAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền CKTM
        /// </summary>
        public decimal? TotalDiscountAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền bằng số
        /// </summary>
        public decimal? TotalAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền bằng số quy đổi
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// tổng tiền chưa thuế quy đổi
        /// </summary>
        public decimal? TotalAmountWithoutVAT { get; set; }

        /// <summary>


        /// <summary>
        /// Tổng tiền CKTM quy đổi
        /// </summary>
        public decimal? TotalDiscountAmount { get; set; }

        /// <summary>
        /// Tổng tiền hàng
        /// </summary>
        public decimal? TotalSaleAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền hàng quy đổi
        /// </summary>
        public decimal? TotalSaleAmount { get; set; }
        /// <summary>
        /// Chi tiết hóa đơn
        /// </summary>
        /// <returns></returns>
        public List<OriginalInvoiceDetail> OriginalInvoiceDetail { get; set; }

        /// <summary>
        /// Danh sách các loại thuế suất
        /// </summary>
        public List<TaxRateInfo> TaxRateInfo { get; set; }

        /// <summary>
        /// Danh sách các loại phí
        /// </summary>
        public List<FeeInfo> FeeInfo { get; set; }

        /// <summary>
        /// Định dạng số để hiển thị hóa đơn
        /// </summary>
        public OptionUserDefined OptionUserDefined { get; set; }

        /// <summary>
        /// ID mẫu hóa đơn
        /// </summary>

    }
    public class OriginalInvoiceData
    {
        /// <summary>
        /// ID của hóa đơn trên Client App
        /// </summary>
        public string RefID { get; set; }

        /// <summary>
        /// Ký hiệu hóa đơn
        /// </summary>
        public string InvSeries { get; set; }

        /// <summary>
        /// Tên hóa đơn
        /// </summary>
        public string InvoiceName { get; set; }

        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        /// <returns></returns>
        public DateTime InvDate { get; set; }

        /// <summary>
        /// Mã loại tiền tệ
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Tỷ giá
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Hình thức thanh toán
        /// </summary>
        public string PaymentMethodName { get; set; }

        /// <summary>
        /// Tính chất hóa đơn (1: thay thế; 2: điều chỉnh)
        /// </summary>
        public int? ReferenceType { get; set; }

        /// <summary>
        /// Là hóa đơn gửi dạng bảng tổng hợp
        /// </summary>
        public bool IsInvoiceSummary { get; set; }

        /// <summary>
        /// Loại hóa đơn bị thay thế/điều chỉnh (1: Hóa đơn 123; 2: Hóa đơn có mã; 3: Hóa đơn 51; 4: Hóa đơn đặt in 123)
        /// </summary>
        public int? OrgInvoiceType { get; set; }

        /// <summary>
        /// Ký hiệu mẫu hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvTemplateNo { get; set; }

        /// <summary>
        /// Ký hiệu hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvSeries { get; set; }

        /// <summary>
        /// Số hđ bị thay thế/điều chỉnh
        /// </summary>
        public string OrgInvNo { get; set; }

        /// <summary>
        /// Ngày hóa đơn bị thay thế/điều chỉnh
        /// </summary>
        public DateTime? OrgInvDate { get; set; }

        /// <summary>
        /// Ghi chú của hóa đơn
        /// </summary>
        public string InvoiceNote { get; set; }

        /// <summary>
        /// Tên người bán
        /// </summary>
        public string SellerLegalName { get; set; }

        /// <summary>
        /// MST người bán
        /// </summary>
        public string SellerTaxCode { get; set; }

        /// <summary>
        /// Địa chỉ người bán
        /// </summary>
        public string SellerAddress { get; set; }

        /// <summary>
        /// ĐT người bán
        /// </summary>
        public string SellerPhoneNumber { get; set; }

        /// <summary>
        /// Email người bán
        /// </summary>
        public string SellerEmail { get; set; }

        /// <summary>
        /// Số TK ngân hàng người bán
        /// </summary>
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng người bán
        /// </summary>
        public string SellerBankName { get; set; }

        /// <summary>
        /// Fax người bán
        /// </summary>
        public string SellerFax { get; set; }

        /// <summary>
        /// Website người bán
        /// </summary>
        public string SellerWebsite { get; set; }

        /// <summary>
        /// Tên (Tên người xuất hàng)
        /// </summary>
        public string StockOutLegalName { get; set; }

        /// <summary>
        /// Mã số thuế (MST người xuất hàng)
        /// </summary>
        public string StockOutTaxCode { get; set; }

        /// <summary>
        /// Lệnh điều động nội bộ
        /// </summary>
        public string InternalCommand { get; set; }

        /// <summary>
        /// Địa chỉ (Địa chỉ kho xuất hàng)
        /// </summary>
        public string StockOutAddress { get; set; }

        /// <summary>
        /// Họ và tên người xuất hàng
        /// </summary>
        public string StockOutFullName { get; set; }

        /// <summary>
        /// Tên người vận chuyển
        /// </summary>
        public string TransporterName { get; set; }

        /// <summary>
        /// Hợp đồng số (Hợp đồng vận chuyển)
        /// </summary>
        public string TransportContractCode { get; set; }

        /// <summary>
        /// Phương tiện vận chuyển
        /// </summary>
        public string Transport { get; set; }

        /// <summary>
        /// Tên (Tên người nhận hàng)
        /// </summary>
        public string StockInLegalName { get; set; }

        /// <summary>
        /// Mã số thuế (Mã số thuế người nhận hàng)
        /// </summary>
        public string StockInTaxCode { get; set; }

        /// <summary>
        /// Họ và tên người nhận hàng
        /// </summary>
        public string StockInFullName { get; set; }

        /// <summary>
        /// Địa chỉ (Địa chỉ kho nhận hàng)
        /// </summary>
        public string StockInAddress { get; set; }

        /// <summary>
        /// Mã số thuế (MST người xuất hàng)
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// Hợp đồng kinh tế ngày
        /// </summary>
        public DateTime? ContractDate { get; set; }

        /// <summary>
        /// Tên đơn vị mua
        /// </summary>
        public string BuyerLegalName { get; set; }

        /// <summary>
        /// MST người mua
        /// </summary>
        public string BuyerTaxCode { get; set; }

        /// <summary>
        /// Địa chỉ người mua
        /// </summary>
        public string BuyerAddress { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string BuyerCode { get; set; }

        /// <summary>
        /// ĐT người mua
        /// </summary>
        public string BuyerPhoneNumber { get; set; }

        /// <summary>
        /// Email người mua
        /// </summary>
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Tên người mua hàng
        /// </summary>
        public string BuyerFullName { get; set; }

        /// <summary>
        /// Số TK ngân hàng người mua
        /// </summary>
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng người mua
        /// </summary>
        public string BuyerBankName { get; set; }

        /// <summary>
        /// tên người liên hệ
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Tỷ lệ chiết khấu cho hóa đơn chiết khấu theo giá trị hóa đơn
        /// </summary>
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// tổng tiền chưa thuế
        /// </summary>
        public decimal? TotalAmountWithoutVATOC { get; set; }

        /// <summary>
        /// Tổng tiền thuế
        /// </summary>
        public decimal? TotalVATAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền CKTM
        /// </summary>
        public decimal? TotalDiscountAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền bằng số
        /// </summary>
        public decimal? TotalAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền bằng chữ
        /// </summary>
        public string TotalAmountInWords { get; set; }
        /// <summary>
        /// Chi tiết hóa đơn
        /// </summary>
        /// <returns></returns>
        public List<OriginalInvoiceDetail> OriginalInvoiceDetail { get; set; }

        /// <summary>
        /// Danh sách các loại thuế suất
        /// </summary>
        public List<TaxRateInfo> TaxRateInfo { get; set; }

        /// <summary>
        /// Danh sách các loại phí
        /// </summary>
        public List<FeeInfo> FeeInfo { get; set; }

        /// <summary>
        /// Định dạng số để hiển thị hóa đơn
        /// </summary>
        public OptionUserDefined OptionUserDefined { get; set; }

        /// <summary>
        /// ID mẫu hóa đơn
        /// </summary>
        public Guid? InvoiceTemplateID { get; set; }

        /// <summary>
        /// Trường mở rộng 1
        /// </summary>
        public string CustomField1 { get; set; }

        /// <summary>
        /// Trường mở rộng 2
        /// </summary>
        public string CustomField2 { get; set; }

        /// <summary>
        /// Trường mở rộng 3
        /// </summary>
        public string CustomField3 { get; set; }

        /// <summary>
        /// Trường mở rộng 4
        /// </summary>
        public string CustomField4 { get; set; }

        /// <summary>
        /// Trường mở rộng 5
        /// </summary>
        public string CustomField5 { get; set; }

        /// <summary>
        /// Trường mở rộng 6
        /// </summary>
        public string CustomField6 { get; set; }

        /// <summary>
        /// Trường mở rộng 7
        /// </summary>
        public string CustomField7 { get; set; }

        /// <summary>
        /// Trường mở rộng 8
        /// </summary>
        public string CustomField8 { get; set; }

        /// <summary>
        /// Trường mở rộng 9
        /// </summary>
        public string CustomField9 { get; set; }

        /// <summary>
        /// Trường mở rộng 10
        /// </summary>
        public string CustomField10 { get; set; }

        /// <summary>
        /// Tổng tiền bằng số quy đổi
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// tổng tiền chưa thuế quy đổi
        /// </summary>
        public decimal? TotalAmountWithoutVAT { get; set; }

        /// <summary>
        /// Tổng tiền thuế quy đổi
        /// </summary>
        public decimal? TotalVATAmount { get; set; }

        /// <summary>
        /// Tổng tiền CKTM quy đổi
        /// </summary>
        public decimal? TotalDiscountAmount { get; set; }

        /// <summary>
        /// Tổng tiền hàng
        /// </summary>
        public decimal? TotalSaleAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền hàng quy đổi
        /// </summary>
        public decimal? TotalSaleAmount { get; set; }

        /// <summary>
        /// Tổng tiền xuất kho nguyên tệ
        /// </summary>
        public decimal? StockTotalAmountOC { get; set; }

        /// <summary>
        /// Tổng tiền xuất kho
        /// </summary>
        public decimal? StockTotalAmount { get; set; }

        /// <summary>
        /// Có giảm trừ thuế không
        /// </summary>
        public bool? IsTaxReduction { get; set; }

        /// <summary>
        /// Số tiền bằng chữ (VNĐ)
        /// </summary>
        public string TotalAmountInWordsVN { get; set; }

        /// <summary>
        /// Số tiền bằng chữ không dấu
        /// </summary>
        public string TotalAmountInWordsUnsignNormalVN { get; set; }

        /// <summary>
        /// Tên chi nhánh ngân hàng người bán
        /// </summary>
        public string CompanyBranchBankName { get; set; }

        /// <summary>
        /// Tên ngân hàng (kèm chi nhánh) của người bán
        /// </summary>
        public string CompanyBankNameWithBranch { get; set; }

        /// <summary>
        /// Phí hoàn vé máy bay
        /// </summary>
        public decimal? ReturnTicketAmount { get; set; }

        /// <summary>
        /// Phí hoàn vé máy bay nguyên tệ
        /// </summary>
        public decimal? ReturnTicketAmountOC { get; set; }

        /// <summary>
        /// Phần trăm thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal? ExciseTaxRate { get; set; }

        /// <summary>
        /// Tiền thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal? ExciseTaxAmount { get; set; }

        /// <summary>
        /// Thuế tiêu thụ ĐB nguyên tệ
        /// </summary>
        public decimal? ExciseTaxAmountOC { get; set; }

        /// <summary>
        /// Số hợp đồng
        /// </summary>
        public string TrsContractNo { get; set; }

        /// <summary>
        /// Vận đơn
        /// </summary>
        public string TrsBLNo { get; set; }

        /// <summary>
        /// Tên tàu
        /// </summary>
        public string TrsNameVessel { get; set; }

        /// <summary>
        /// Quốc tịch
        /// </summary>
        public string TrsFlag { get; set; }

        /// <summary>
        /// Ngày đến
        /// </summary>
        public DateTime? TrsArrival { get; set; }

        /// <summary>
        /// Ngày đi
        /// </summary>
        public DateTime? TrsDeparture { get; set; }

        /// <summary>
        /// Phòng số
        /// </summary>
        public string RoomNo { get; set; }

        /// <summary>
        /// Ngày đến
        /// </summary>
        public string CheckIn { get; set; }

        /// <summary>
        /// Ngày đi
        /// </summary>
        public string CheckOut { get; set; }

        /// <summary>
        /// Toán tử tỷ giá
        /// </summary>
        public string ExchangeRateOperation { get; set; }

        /// <summary>
        /// Ds kho
        /// </summary>
        public string ListStockName { get; set; }

        /// <summary>
        /// Ds địa chỉ kho
        /// </summary>
        public string ListStockAddress { get; set; }

        /// <summary>
        /// Mã kho đi
        /// </summary>
        public string ListFromStockCode { get; set; }

        /// <summary>
        /// Mã kho đến
        /// </summary>
        public string ListToStockCode { get; set; }

        /// <summary>
        /// Địa chỉ kho đi
        /// </summary>
        public string FromStockAddress { get; set; }

        /// <summary>
        /// Địa chỉ kho đến
        /// </summary>
        public string ToStockAddress { get; set; }

        /// <summary>
        /// Lệnh điều động số
        /// </summary>
        public string InternalCommandNo { get; set; }

        /// <summary>
        /// Lệnh điều động của
        /// </summary>
        public string InternalCommandOwner { get; set; }

        /// <summary>
        /// Lệnh điều động ngày
        /// </summary>
        public DateTime? InternalCommandDate { get; set; }

        /// <summary>
        /// Về việc
        /// </summary>
        public string JournalMemo { get; set; }

        /// <summary>
        /// Kỳ thu
        /// </summary>
        public string PeriodName { get; set; }

        /// <summary>
        ///Từ ngày
        /// </summary>
        public DateTime? PeriodFromDate { get; set; }

        /// <summary>
        /// Đến ngày
        /// </summary>
        public DateTime? PeriodToDate { get; set; }

        /// <summary>
        /// Số nước truy thu
        /// </summary>
        public decimal? WaterArrearage { get; set; }

        /// <summary>
        /// Số nước khuyến mại
        /// </summary>
        public decimal? WaterPromotion { get; set; }

        /// <summary>
        /// Số nước tiêu thụ
        /// </summary>
        public decimal? WaterUsed { get; set; }

        /// <summary>
        /// Mức % Phí bảo vệ môi trường
        /// </summary>
        public int EnvironmmentFeeRate { get; set; }

        /// <summary>
        /// Tiền phí bảo vệ môi trường
        /// </summary>
        public decimal? EnvironmmentFeeAmount { get; set; }

        /// <summary>
        /// Phí đăng kiểm
        /// </summary>
        public decimal? RegistrationFee { get; set; }

        /// <summary>
        /// Tổng chỉ số của các đồng hồ - Điện năng tiêu thụ
        /// </summary>
        public decimal? SumOfClockIndex { get; set; }

        /// <summary>
        /// Danh sách đồng hồ
        /// </summary>
        public List<ClockInfo> ClockInfos { get; set; }
    }

    public class OriginalInvoiceDetail
    {
        /// <summary>
        /// Tính chất (1: HHDV; 2: khuyến mại; 3: chiết khẩu; 4: ghi chú/diễn giải)
        /// </summary>
        public int ItemType { get; set; }

        /// <summary>
        /// STT dòng mặt hàng (bắt đầu từ 1)
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// Mã mặt hàng
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// Tên mặt hàng
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Đơn vị tính
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Số lượng mặt hàng
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Đơn giá
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Tỷ lệ chiết khấu
        /// </summary>
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// Tiền chiết khấu
        /// </summary>
        public decimal? DiscountAmountOC { get; set; }

        /// <summary>
        /// Tiền chiết khấu quy đổi
        /// </summary>
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Thành tiền
        /// </summary>
        public decimal? AmountOC { get; set; }

        /// <summary>
        /// Thành tiền quy đổi
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Thành tiền chưa thuế
        /// </summary>
        public decimal? AmountWithoutVATOC { get; set; }
        public decimal? AmountWithoutVAT { get; set; }
        /// <summary>
        /// Đơn giá sau thuế
        /// </summary>
        public decimal? UnitPriceAfterTax { get; set; }

        /// <summary>
        /// Thành tiền sau thuế quy đổi
        /// </summary>
        public decimal? AmountAfterTax { get; set; }

        /// <summary>
        /// Tên loại thuế suất
        /// </summary>
        public string VATRateName { get; set; }

        /// <summary>
        /// Tiền thuế
        /// </summary>
        public decimal? VATAmountOC { get; set; }

        /// <summary>
        /// Tiền thuế quy đổi
        /// </summary>
        public decimal? VATAmount { get; set; }

        /// <summary>
        /// Trường mở rộng 1
        /// </summary>
        public string CustomField1Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 2
        /// </summary>
        public string CustomField2Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 3
        /// </summary>
        public string CustomField3Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 4
        /// </summary>
        public string CustomField4Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 5
        /// </summary>
        public string CustomField5Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 6
        /// </summary>
        public string CustomField6Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 7
        /// </summary>
        public string CustomField7Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 8
        /// </summary>
        public string CustomField8Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 9
        /// </summary>
        public string CustomField9Detail { get; set; }

        /// <summary>
        /// Trường mở rộng 10
        /// </summary>
        public string CustomField10Detail { get; set; }

        /// <summary>
        /// Thứ tự hiển thị lên mẫu
        /// </summary>
        public int? SortOrder { get; set; }

        /// <summary>
        /// Diễn giải hàng hóa
        /// </summary>
        public string InventoryItemNote { get; set; }

        /// <summary>
        /// Số lô
        /// </summary>
        public string LotNo { get; set; }

        /// <summary>
        /// Hạn sử dụng
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Mã ĐVT
        /// </summary>
        public string UnitCode { get; set; }

        /// <summary>
        /// Tiền thuế đc giảm nguyên tệ (406)
        /// </summary>
        public decimal? TaxReductionAmountOC { get; set; }

        /// <summary>
        /// Tiền thuế được giảm quy đổi (406)
        /// </summary>
        public decimal? TaxReductionAmount { get; set; }

        ///// <summary>
        ///// Số lượng thực nhập
        ///// </summary>
        public decimal? InWards { get; set; }

        /// <summary>
        /// Số khung
        /// </summary>
        public string ChassisNumber { get; set; }

        /// <summary>
        /// Số khung
        /// </summary>
        public string EngineNumber { get; set; }

        /// <summary>
        /// Xuất bản phí
        /// </summary>
        public string PublishFee { get; set; }
    }

    public class ClockInfo
    {
        /// <summary>
        /// STT dòng mặt hàng (bắt đầu từ 1)
        /// </summary>
        public int ClockOrder { get; set; }

        /// <summary>
        /// Mã đồng hồ
        /// </summary>
        public string ClockCode { get; set; }

        /// <summary>
        /// Seri đồng hồ
        /// </summary>
        public string ClockSeri { get; set; }

        /// <summary>
        /// Chỉ số mới
        /// </summary>
        public decimal LastIndex { get; set; }

        /// <summary>
        /// Chỉ số cũ
        /// </summary>
        public decimal FirstIndex { get; set; }

        /// <summary>
        /// Hệ số của đồng hồ
        /// </summary>
        public decimal Coefficient { get; set; }

        /// <summary>
        /// Mã đồng hồ cũ
        /// </summary>
        public string ClockCodeOld { get; set; }

        /// <summary>
        /// Seri đồng hồ cũ
        /// </summary>
        public string ClockSeriOld { get; set; }

        /// <summary>
        /// Chỉ số mới của đồng hồ cũ
        /// </summary>
        public decimal? LastIndexOld { get; set; }

        /// <summary>
        /// Chỉ số cũ của đồng hồ cũ
        /// </summary>
        public decimal? FirstIndexOld { get; set; }

        /// <summary>
        /// Hệ số của đồng hồ cũ
        /// </summary>
        public decimal? CoefficientOld { get; set; }

        /// <summary>
        /// Trạng thái của đồng hồ
        /// 0 là đang sử dụng
        /// 1 là thay mới đồng hồ => truyền thêm thông tin đồng hồ cũ vào các trường có Old
        /// </summary>
        public int ClockStatus { get; set; }

        /// <summary>
        /// Xe tra nạp
        /// </summary>
        public string RefuelerNo { get; set; }

        /// <summary>
        /// Số lô
        /// </summary>
        public string QualityControlNo { get; set; }

        /// <summary>
        /// Số công tơ đầu
        /// </summary>
        public decimal? StartMeter { get; set; }

        /// <summary>
        /// Số công tơ cuối
        /// </summary>
        public decimal? EndMeter { get; set; }

        /// <summary>
        /// Nhiệt độ thực tế
        /// </summary>
        public decimal? ActualTemperature { get; set; }

        /// <summary>
        /// Tỉ trọng thực tế
        /// </summary>
        public decimal? ActualDensity { get; set; }

        /// <summary>
        /// Gallon thực tế
        /// </summary>
        public decimal? ObservedGallon { get; set; }

        /// <summary>
        /// Lít thực tế
        /// </summary>
        public decimal? ObservedLiters { get; set; }
    }

    /// <summary>
    /// Thông tin các loại thuế suất
    /// </summary>
    public class TaxRateInfo
    {
        /// <summary>
        /// Tên loại thuế suất
        /// </summary>
        public string VATRateName { get; set; }

        /// <summary>
        /// Tiền chưa thuế
        /// </summary>
        public decimal? AmountWithoutVATOC { get; set; }

        /// <summary>
        /// Tiền thuế
        /// </summary>
        public decimal? VATAmountOC { get; set; }
    }

    /// <summary>
    /// Thông tin các loại phí
    /// </summary>
    public class FeeInfo
    {
        /// <summary>
        /// Tên loại phí
        /// </summary>
        public string FeeName { get; set; }

        /// <summary>
        /// Tiền phí
        /// </summary>
        public decimal? FeeAmountOC { get; set; }
    }

    public class OptionUserDefined
    {
        /// <summary>
        /// Đồng tiền hạch toán
        /// </summary>
        public string MainCurrency { get; set; }

        /// <summary>
        /// Định dạng số tiền quy dổi
        /// </summary>
        public string AmountDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng số tiền nguyên tệ
        /// </summary>
        public string AmountOCDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng đơn giá nguyên tệ
        /// </summary>
        public string UnitPriceOCDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng đơn giá quy đổi
        /// </summary>
        public string UnitPriceDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng số lượng
        /// </summary>
        public string QuantityDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng tỷ lệ
        /// </summary>
        public string CoefficientDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng tỷ giá
        /// </summary>
        public string ExchangRateDecimalDigits { get; set; }

        /// <summary>
        /// Định dạng tham số decimal trong ClockInfo
        /// </summary>
        public string ClockDecimalDigits { get; set; }
    }
    /// <summary>
    /// Trạng thái phát hành hóa đơn
    /// </summary>
    public class InvoiceStatus
    {
        /// <summary>
        /// Mã tra cứu hóa đơn
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Mã cơ quan thuế cấp - đối với hóa đơn có mã
        /// </summary>
        public string InvoiceCode { get; set; }

        /// <summary>
        /// Trạng thái gửi hóa đơn sang Cơ quan thuế
        ///     - Không có mã: (0: chưa gửi CQT; 1: Đã gửi CQT; 2: CQT tiếp nhận; 3: CQT không tiếp nhận; 4: gửi lỗi)
        ///     - Có mã: (0: chờ cấp mã; 1: gửi lỗi; 2: đã cấp mã; 3: từ chối cấp mã; 4: gửi lỗi)
        /// Mô tả theo <see cref="Enum.SendToTaxStatus"/>
        /// </summary>
        public int SendTaxStatus { get; set; }

        /// <summary>
        /// Trạng thái gửi hóa đơn cho khách hàng (0: Chưa gửi; 1: Đã gửi)
        /// </summary>
        public bool IsSentEmail { get; set; }

        /// <summary>
        /// Là hóa đơn bị hủy chưa
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// Ngày hủy hóa đơn
        /// </summary>
        public System.DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Lý do hủy hóa đơn
        /// </summary>
        public string DeletedReason { get; set; }

        /// <summary>
        /// Người mua đã nhận hóa đơn: 0: Chưa nhận được; 1: Đã nhận được
        /// </summary>
        public int ReceivedStatus { get; set; }
    }

    /// <summary>
    /// Summary description for Sign
    /// </summary>
    public class Sign
    {

        /// <summary>
        /// chuỗi ký tự được MISA cung cấp
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string taxcode { get; set; }

        /// <summary>
        /// tài khoản
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// mật khẩu
        /// </summary>
        public string password { get; set; }

    }

    public class TemplateData
    {
        /// <summary>
        /// ID mẫu
        /// </summary>
        public Guid IPTemplateID { get; set; }
        /// <summary>
        /// ID công ty
        /// </summary>
        public int CompanyID { get; set; }
        /// <summary>
        /// Tên mẫu
        /// </summary>
        public string TemplateName { get; set; }
        /// <summary>
        /// Mẫu số
        /// </summary>
        public string InvTemplateNo { get; set; }
        /// <summary>
        /// Ký hiệu
        /// </summary>
        public string InvSeries { get; set; }

        /// <summary>
        /// Ký hiệu
        /// </summary>
        public string OrgInvSeries { get; set; }
        /// <summary>
        /// Loại mẫu (stimul, xslt,...)
        /// </summary>
        public int TemplateType { get; set; }
        /// <summary>
        /// Loại hóa đơn (GTGT, bán hàng, xuất kho,...)
        /// </summary>
        public int InvoiceType { get; set; }
        /// <summary>
        /// Nghiệp vụ
        /// </summary>
        public int BusinessAreas { get; set; }
        /// <summary>
        /// Thứ tự
        /// </summary>
        public int SortOrder { get; set; }
        /// <summary>
        /// Ngày ký
        /// </summary>
        public DateTime? SignedDate { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Ngày sửa
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Người sửa
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Ngừng hoạt động
        /// </summary>
        /// <returns></returns>
        public bool Inactive { get; set; }
        /// <summary>
        /// Nội dung file mẫu
        /// </summary>
        public byte[] TemplateContent { get; set; }
        /// <summary>
        /// ID mẫu mặc định
        /// </summary>
        public Guid DefaultTemplateID { get; set; }
        /// <summary>
        /// Có phải mẫu custom không
        /// </summary>
        public bool IsCustomTemplate { get; set; }
        /// <summary>
        /// kế thừa từ mẫu cũ hay không
        /// </summary>
        public bool IsInheritFromOldTemplate { get; set; }

        /// <summary>
        /// Phiên bản mẫu xslt
        /// </summary>
        public int? XsltVersion { get; set; }
        /// <summary>
        /// Đã phát hành hđ hay chưa
        /// </summary>
        public bool IsPublished { get; set; }
    }

    public class CompanyInfoResult
    {
        /// <summary>
        /// Thông tin công ty
        /// </summary>
        public Company CompanyInfo { get; set; }
    }

    public class Company
    {
        /// <summary>
        /// ID công ty
        /// </summary>
        public int CompanyID { get; set; }

        /// <summary>
        /// Mã công ty
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// Tên công ty
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Mã bảo mật
        /// </summary>
        public string SecureToken { get; set; }

        /// <summary>
        /// Mã số thuế công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }

        /// <summary>
        /// Ngưng hoạt dộng
        /// </summary>
        public bool Inactive { get; set; }

        /// <summary>
        /// Địa chỉ công ty
        /// </summary>
        public string CompanyAddress { get; set; }

        /// <summary>
        /// Tỉnh/ Thành phố
        /// </summary>
        public string CompanyCity { get; set; }

        /// <summary>
        /// Mã nhân viên MISA
        /// </summary>
        public string MISAEmployeeCode { get; set; }

        /// <summary>
        /// Đơn vị tích hợp
        /// </summary>
        public int SourceType { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Ngày tích hợp
        /// </summary>
        public DateTime? IntegratedDate { get; set; }

        /// <summary>
        /// Mã số thuế không dấu
        /// </summary>
        public string CompanyTaxCodeWithoutSign { get; set; }

        /// <summary>
        /// Thông tin người đại diện pháp luật
        /// </summary>
        public string CompanyAgentFollowLaw { get; set; }

        /// <summary>
        /// ĐT cty
        /// </summary>
        public string CompanyTel { get; set; }

        /// <summary>
        /// Email cty
        /// </summary>
        public string CompanyEmail { get; set; }

        /// <summary>
        /// Website
        /// </summary>
        public string CompanyWebsite { get; set; }

        /// <summary>
        /// Lĩnh vực hoạt động
        /// </summary>
        public string BusinessType { get; set; }

        /// <summary>
        /// TK Ngân Hàng
        /// </summary>
        public string BankAccount { get; set; }

        /// <summary>
        /// Ngân hàng
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Chi nhánh NH
        /// </summary>
        public string BankBranchName { get; set; }

        /// <summary>
        /// Cơ quan thuế cấp cục
        /// </summary>
        public string TaxationBureau { get; set; }

        /// <summary>
        /// CQ thuế quản lý
        /// </summary>
        public string TaxOrganManagement { get; set; }

        /// <summary>
        /// Mã CQ thuế quản lý
        /// </summary>
        public string TaxOrganManagementCode { get; set; }

        /// <summary>
        /// Người đại diện pháp luật
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// Fax công ty
        /// </summary>
        public string CompanyFax { get; set; }

        /// <summary>
        /// nghệ nghiệp lĩnh vực hoạt động của công ty
        /// </summary>
        public string Career { get; set; }

        /// <summary>
        /// email người đại diện pháp luật
        /// </summary>
        public string LegalepresentationEmail { get; set; }

        /// <summary>
        /// SĐT người đại diện pháp luật
        /// </summary>
        public string LegalepresentationPhone { get; set; }

        /// <summary>
        /// Thông tư áp dụng
        /// </summary>
        public string CircularFollow { get; set; }

        /// <summary>
        /// True: sử dụng HĐ có mã
        /// </summary>
        public bool IsInvoiceWithCode { get; set; }

        /// <summary>
        /// Sử dụng vé
        /// </summary>
        public bool IsUsingTicket { get; set; }

        /// <summary>
        /// Người liên hệ
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Địa chỉ liên hệ
        /// </summary>
        public string ContactAddress { get; set; }

        /// <summary>
        /// Email liên hệ
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Điện thoại liên hệ
        /// </summary>
        public string ContactMobile { get; set; }

        /// <summary>
        /// Có tờ khai được chấp nhận hay chưa
        /// </summary>
        public bool HasAccepted123 { get; set; }
    }

    // Lê Vũ Hoàng Nam
    public class Convert
    {
        //tên người chuyển đổi
        public string Converter { get; set; }

        //ngày chuyển đổi
        public DateTime ConvertDate { get; set; }

        //Mã tra cứu hóa đơn
        public int TransactionIDList { get; set; }
    }
    public class SendEmailParameter
    {
        /// <summary>
        /// Danh sách thông tin gửi email
        /// </summary>
        public System.Collections.Generic.List<SendEmailData> SendEmailDatas { get; set; }

        /// <summary>
        /// Hóa đơn có mã hay không
        /// </summary>
        public bool IsInvoiceCode { get; set; }
    }

    /// <summary>
    /// Tham số gửi Email
    /// </summary>
    public class SendEmailData
    {
        /// <summary>
        /// Mã tra cứu
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Tên người nhận
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// List Email
        /// </summary>
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// Email cc
        /// </summary>
        public string CCEmail { get; set; }

        /// <summary>
        /// Email bcc
        /// </summary>
        public string BCCEmail { get; set; }

        /// <summary>
        /// Link callback
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// địa chỉ email khi reply
        /// </summary>
        public string ReplyEmail { get; set; }
    }
    public class Cancle
    {
        //mã tra cứu
        public string TransactionID { get; set; }

        //số hóa đơn
        public string InvNo { get; set; }

        //ngày hủy hóa đơn
        public DateTime RefDate { get; set; }

        //lý do hủy hóa đơn
        public string CancelReason { get; set; }
    }
    public class RequestIssuetheinvoice
    {
        public string RefID { get; set; }
        public string TransactionID { get; set; }
        //public string CallbackUrl { get; set; }
        public string InvoiceData { get; set; }
        //public string InvoiceDataOld { get; set; }
        public bool IsSendEmail { get; set; }
        public string ReceiverName { get; set; }
        //public string ReceiverEmailCC { get; set; }
        //public string ReceiverEmailBCC { get; set; }
        public string ReceiverEmail { get; set; }
        //public string oDataOld { get; set; }
        //public string ClientIDToPush { get; set; }
        //public decimal EditVersion { get; set; }
        //public string InvNo { get; set; }
        public bool IsInvoiceSummary { get; set; }
        //public bool IsValidateSigned { get; set; }
    }
    public class signthebill
    {
        public string PinCode { get; set; }

        public string XmlContent { get; set; }


    }
    #endregion

}