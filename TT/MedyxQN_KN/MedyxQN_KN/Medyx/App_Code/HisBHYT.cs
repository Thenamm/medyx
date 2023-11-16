using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Xml;
using Newtonsoft.Json.Linq;
/// <summary>
/// Summary description for HisBHYT
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class HisBHYT : System.Web.Services.WebService
{
    public HisBHYT()
    {

    }
    public HisBHYT(string _username, string _password)
    {
        Application["BH_user"] = _username;
        Application["BH_password"] = encryptData(_password);
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public HoSo[] CheckOutHoSo(string _mathe, string _hoten, string _ngaysinh, string _gioitinh, string _ngaybd, string _ngaykt, string _macskcb)
    {


        //string data = "token="+token+"&id_token="+id_token+"&username="+username+"&password="+password ; //replace <value>
        //byte[] dataStream = Encoding.UTF8.GetBytes(data);
        //string url = string.Format("egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB");
        //string request = url + data;
        //HttpWebRequest httpWebRequest = WebRequest.Create(request) as HttpWebRequest;
        //httpWebRequest.Method = "POST";
        //httpWebRequest.ContentType = "application/json; charset=utf-8";

        //httpWebRequest.ContentLength = dataStream.Length;

        //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //{
        //    string json = "{\"x\":\"true\"}";

        //    streamWriter.Write(json);
        //    streamWriter.Flush();
        //}

        //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //{
        //    var result = streamReader.ReadToEnd();
        //    return result;
        //}
        try
        {
            var postParameters = new theBHYT
            {
                maThe = _mathe,
                hoTen = _hoten,
                ngaySinh = _ngaysinh,
                gioiTinh = _gioitinh,
                maCSKCB = _macskcb,
                ngayBD = _ngaybd,
                ngayKT = _ngaykt
            };
            //string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB");
            string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB595");
            if (Application["BH_token"] == null)
                Login();
            string postData = JsonConvert.SerializeObject(postParameters);
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            string data = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
            string request = url + "?" + data;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Count());
                requestStream.Flush();
                requestStream.Close();
            }
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if (httpWebResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    LichSuKCB ls = JsonConvert.DeserializeObject<LichSuKCB>(result);
                    if (ls.maKetQua == "401")
                        Login();
                    else
                    {
                        int i = 0;
                        foreach (HoSo hs in ls.dsLichSuKCB)
                        {
                            hs.OrderNumber = ++i;
                        }
                        return ls.dsLichSuKCB;
                    }
                    return null;
                }
            }
            else
                return null;

        }
        catch
        {
            return null;
        }

    }
    //public LichSuKCB  CheckOutSoThe(string _mathe, string _hoten, string _ngaysinh, string _gioitinh, string _ngaybd, string _ngaykt, string _macskcb, string _mamay, string _nguoicheck)
    //{

    //    string ketqua = "";
    //    //string data = "token="+token+"&id_token="+id_token+"&username="+username+"&password="+password ; //replace <value>
    //    //byte[] dataStream = Encoding.UTF8.GetBytes(data);
    //    //string url = string.Format("egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB");
    //    //string request = url + data;
    //    //HttpWebRequest httpWebRequest = WebRequest.Create(request) as HttpWebRequest;
    //    //httpWebRequest.Method = "POST";
    //    //httpWebRequest.ContentType = "application/json; charset=utf-8";

    //    //httpWebRequest.ContentLength = dataStream.Length;

    //    //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
    //    //{
    //    //    string json = "{\"x\":\"true\"}";

    //    //    streamWriter.Write(json);
    //    //    streamWriter.Flush();
    //    //}

    //    //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
    //    //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
    //    //{
    //    //    var result = streamReader.ReadToEnd();
    //    //    return result;
    //    //}
    //    string sql = " insert into CheckOutTheBHYT(SoThe,HoTen,NgaySinh,NgayLap,MaLoi,MoTa,MaMay,NguoiLap) select ";

    //    try
    //    {
    //        _mathe = _mathe.ToUpper();
    //        var postParameters = new theBHYT
    //        {
    //            maThe = _mathe,
    //            hoTen = _hoten,
    //            ngaySinh = _ngaysinh,
    //            gioiTinh = _gioitinh,
    //            maCSKCB = _macskcb,
    //            ngayBD = _ngaybd,
    //            ngayKT = _ngaykt
    //        };
    //        if (Application["BH_token"] == null)
    //            Login();
    //       // string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB");
    //        string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB595");
    //        string postData = JsonConvert.SerializeObject(postParameters);
    //        byte[] bytes = Encoding.UTF8.GetBytes(postData);
    //        string data = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
    //        string request = url + "?" + data;
    //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
    //        httpWebRequest.Method = "POST";
    //        httpWebRequest.ContentLength = bytes.Length;
    //        httpWebRequest.ContentType = "application/json; charset=utf-8";
    //        using (Stream requestStream = httpWebRequest.GetRequestStream())
    //        {
    //            requestStream.Write(bytes, 0, bytes.Count());
    //            requestStream.Flush();
    //            requestStream.Close();
    //        }
    //        var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
    //        if (httpWebResponse.StatusCode == HttpStatusCode.OK)
    //        {
    //            using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
    //            {
    //                var result = streamReader.ReadToEnd();
    //                LichSuKCB ls = JsonConvert.DeserializeObject<LichSuKCB>(result);
    //                if (ls.maKetQua == "401")
    //                {
    //                    Login();
    //                    ketqua = "Không kết nối được với máy BHYT";

    //                }
    //                else if (ls.maKetQua == "01" || ls.maKetQua == "02" || ls.maKetQua == "03" || ls.maKetQua == "04")
    //                {
    //                    ketqua = "Thẻ khám bệnh có vấn đề về hạn thẻ";
    //                }
    //                else if (ls.maKetQua == "08")
    //                {
    //                    ketqua = "Thẻ khám bệnh bị sai giới tính";
    //                }
    //                else if (ls.maKetQua == "09")
    //                {

    //                    ketqua = "Thẻ khám bệnh bị sai nơi đăng ký ban đầu";
    //                }
    //                else if (ls.maKetQua == "010")
    //                {

    //                    ketqua = "Thẻ hết giá trị sử dụng";
    //                }
    //                else if (ls.maKetQua == "110")
    //                {

    //                    ketqua = "Thẻ bị thu hồi";
    //                }
    //                else if (ls.maKetQua == "090")
    //                {

    //                    ketqua = "Sai nơi đăng ký ban đầu";
    //                }
    //                else if (ls.maKetQua == "110" || ls.maKetQua == "120" || ls.maKetQua == "121" || ls.maKetQua == "122" || ls.maKetQua == "123" || ls.maKetQua == "124")
    //                {

    //                    ketqua = "Thẻ đã báo giảm";
    //                }
    //                else if (ls.maKetQua == "051" || ls.maKetQua == "050" || ls.maKetQua == "052" || ls.maKetQua == "053")
    //                {

    //                    ketqua = "Các thông tin trên thẻ bị sai ";
    //                }
    //                else if (ls.maKetQua == "060" || ls.maKetQua == "061" || ls.maKetQua == "06")
    //                {

    //                    ketqua = "Các thông tin họ tên trên thẻ bị sai ";
    //                }
    //                else if (ls.maKetQua == "070" || ls.maKetQua == "07")
    //                {

    //                    ketqua = "Thông tin ngày sinh bị sai ";
    //                }

    //                if (ls.dsLichSuKCB != null)
    //                {
    //                    if (ls.dsLichSuKCB.Length > 0)
    //                    {
    //                        HoSo hs = ls.dsLichSuKCB[0];
    //                        if ((DateTime.Parse(hs.denNgay) - DateTime.Now).Days >= -7)
    //                        {
    //                            ketqua = ketqua + ls.maKetQua + "Khám ngày cuối là " + hs.denNgay + " với bệnh là " + hs.tenBenh;
    //                            sql = sql + "'" + _mathe + "',N'" + _hoten + "','" + _ngaysinh + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + "','" + _mamay + "','" + _nguoicheck + "'";
    //                        }
    //                        else
    //                        {
    //                            sql = sql + "'" + _mathe + "',N'" + _hoten + "','" + _ngaysinh + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + "Khám ngày cuối là " + hs.denNgay + " với bệnh là " + hs.tenBenh + "','" + _mamay + "','" + _nguoicheck + "'";

    //                        }
    //                        HTC.Business.DataProvider.Instance().ExcSQL(sql);
    //                    }
    //                    else
    //                    {
    //                        ketqua = ketqua + ls.maKetQua + "Bệnh nhân chưa có lịch sử khám bệnh";

    //                        sql = sql + "'" + _mathe + "',N'" + _hoten + "','" + _ngaysinh + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + "','" + _mamay + "','" + _nguoicheck + "'";

    //                        HTC.Business.DataProvider.Instance().ExcSQL(sql);
    //                    }
    //                }
    //                else
    //                {
    //                    if (ketqua == "")
    //                    {
    //                        ketqua = "Bệnh nhân chưa có lịch sử khám bệnh trên cổng BHYT" + ls.maKetQua + Application["BH_user"].ToString() + "/" + Application["BH_password"].ToString();
    //                    }
    //                    sql = sql + "'" + _mathe + "',N'" + _hoten + "','" + _ngaysinh + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + "','" + _mamay + "','" + _nguoicheck + "'";
    //                    HTC.Business.DataProvider.Instance().ExcSQL(sql);
    //                }
    //            }
    //        }
    //        else
    //        {
    //            if (ketqua == "")
    //            {
    //                ketqua = "Không check được thông tin trên cổng bảo hiểm";
    //            }
    //            sql = sql + "'" + _mathe + "',N'" + _hoten + "','" + _ngaysinh + "',getdate(),null,N'" + ketqua + "','" + _mamay + "','" + _nguoicheck + "'";
    //            HTC.Business.DataProvider.Instance().ExcSQL(sql);
    //        }
    //        return ketqua;
    //    }
    //    catch (Exception ex)
    //    {
    //        if (ketqua == "")
    //        {
    //            sql = sql + "'" + _mathe + "',N'" + _hoten + "','" + _ngaysinh + "',getdate(),null,N'" +"Không thể tra cứu thẻ bảo hiểm trên cổng BHXH!Kiểm tra kết nối hoặc mật khẩu" + Application["BH_user"].ToString() + "/" + Application["BH_password"].ToString() + ex.Message + _mamay + "','" + _nguoicheck + "'";
    //        }
    //        HTC.Business.DataProvider.Instance().ExcSQL(sql);
    //        return "Không thể tra cứu thẻ bảo hiểm trên cổng BHXH!Kiểm tra kết nối hoặc mật khẩu" + Application["BH_user"].ToString() + "/" + Application["BH_password"].ToString() + ex.Message;

    //    }

    //}

    public LichSuKCB CheckOutSoThe(string _mathe, string _hoten, string _ngaysinh, string _gioitinh, string _ngaybd, string _ngaykt, string _macskcb)
    {
        try
        {
            _mathe = _mathe.ToUpper();
            var postParameters = new theBHYT
            {
                maThe = _mathe,
                hoTen = _hoten,
                ngaySinh = _ngaysinh,
                gioiTinh = _gioitinh,
                maCSKCB = _macskcb,
                ngayBD = _ngaybd,
                ngayKT = _ngaykt
            };
           
                Login();
            // string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB");
            string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/KQnhanLichSuKCB595");
            string postData = JsonConvert.SerializeObject(postParameters);
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            string data = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
            string request = url + "?" + data;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Count());
                requestStream.Flush();
                requestStream.Close();
            }
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if (httpWebResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    LichSuKCB ls = JsonConvert.DeserializeObject<LichSuKCB>(result);
                    if (ls.maKetQua == "401" || ls.maKetQua == "500")
                    {
                        Login();

                        string datalan2 = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
                        string requestlan2 = url + "?" + data;
                        var httpWebRequestlan2 = (HttpWebRequest)WebRequest.Create(requestlan2);
                        httpWebRequestlan2.Method = "POST";
                        httpWebRequestlan2.ContentLength = bytes.Length;
                        httpWebRequestlan2.ContentType = "application/json; charset=utf-8";
                        using (Stream requestStreamlan2 = httpWebRequestlan2.GetRequestStream())
                        {
                            requestStreamlan2.Write(bytes, 0, bytes.Count());
                            requestStreamlan2.Flush();
                            requestStreamlan2.Close();
                        }
                        var httpWebResponselan2 = (HttpWebResponse)httpWebRequestlan2.GetResponse();
                        if (httpWebResponselan2.StatusCode == HttpStatusCode.OK)
                        {
                            using (var streamReaderlan2 = new StreamReader(httpWebResponselan2.GetResponseStream()))
                            {
                                var resultlan2 = streamReaderlan2.ReadToEnd();
                                LichSuKCB lslan2 = JsonConvert.DeserializeObject<LichSuKCB>(resultlan2);
                                if (lslan2.maKetQua == "401" || lslan2.maKetQua == "500")
                                {
                                    Login();

                                    string datalan3 = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
                                    string requestlan3 = url + "?" + data;
                                    var httpWebRequestlan3 = (HttpWebRequest)WebRequest.Create(requestlan3);
                                    httpWebRequestlan3.Method = "POST";
                                    httpWebRequestlan3.ContentLength = bytes.Length;
                                    httpWebRequestlan3.ContentType = "application/json; charset=utf-8";
                                    using (Stream requestStreamlan3 = httpWebRequestlan3.GetRequestStream())
                                    {
                                        requestStreamlan3.Write(bytes, 0, bytes.Count());
                                        requestStreamlan3.Flush();
                                        requestStreamlan3.Close();
                                    }
                                    var httpWebResponselan3 = (HttpWebResponse)httpWebRequestlan3.GetResponse();
                                    if (httpWebResponselan3.StatusCode == HttpStatusCode.OK)
                                    {
                                        using (var streamReaderlan3 = new StreamReader(httpWebResponselan3.GetResponseStream()))
                                        {
                                            var resultlan3 = streamReaderlan3.ReadToEnd();
                                            LichSuKCB lslan3 = JsonConvert.DeserializeObject<LichSuKCB>(resultlan3);

                                            return lslan3;
                                        }
                                    }
                                }
                                httpWebRequestlan2.Abort();  // !! Yes, abort the request
                                streamReaderlan2.Dispose();
                                httpWebResponselan2.Close();
                                return lslan2;
                            }
                        }
                    }
                     httpWebRequest.Abort();  // !! Yes, abort the request
                    streamReader.Dispose ();
                     httpWebResponse.Close();
                    return ls;
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            return null;
        }

    }
    public KQNhanLichSuKCB2018 CheckOutSoThe2018(string _mathe, string _hoten, string _ngaysinh, string _gioitinh, string _ngaybd, string _ngaykt, string _macskcb)
    {
        try
        {
            _mathe = _mathe.ToUpper();
            var postParameters = new theBHYT
            {
                maThe = _mathe,
                hoTen = _hoten,
                ngaySinh = _ngaysinh,
                gioiTinh = _gioitinh,
                maCSKCB = _macskcb,
                ngayBD = _ngaybd,
                ngayKT = _ngaykt
            };

            Login();
            // string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/nhanLichSuKCB");
            string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/egw/NhanLichSuKCB2018");
            string postData = JsonConvert.SerializeObject(postParameters);
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            string data = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
            string request = url + "?" + data;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Count());
                requestStream.Flush();
                requestStream.Close();
            }
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if (httpWebResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    KQNhanLichSuKCB2018 ls = JsonConvert.DeserializeObject<KQNhanLichSuKCB2018>(result);
                    if (ls.maKetQua == "401" || ls.maKetQua == "500")
                    {
                        Login();

                        string datalan2 = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
                        string requestlan2 = url + "?" + data;
                        var httpWebRequestlan2 = (HttpWebRequest)WebRequest.Create(requestlan2);
                        httpWebRequestlan2.Method = "POST";
                        httpWebRequestlan2.ContentLength = bytes.Length;
                        httpWebRequestlan2.ContentType = "application/json; charset=utf-8";
                        using (Stream requestStreamlan2 = httpWebRequestlan2.GetRequestStream())
                        {
                            requestStreamlan2.Write(bytes, 0, bytes.Count());
                            requestStreamlan2.Flush();
                            requestStreamlan2.Close();
                        }
                        var httpWebResponselan2 = (HttpWebResponse)httpWebRequestlan2.GetResponse();
                        if (httpWebResponselan2.StatusCode == HttpStatusCode.OK)
                        {
                            using (var streamReaderlan2 = new StreamReader(httpWebResponselan2.GetResponseStream()))
                            {
                                var resultlan2 = streamReaderlan2.ReadToEnd();
                                KQNhanLichSuKCB2018 lslan2 = JsonConvert.DeserializeObject<KQNhanLichSuKCB2018>(resultlan2);
                                if (lslan2.maKetQua == "401" || lslan2.maKetQua == "500")
                                {
                                    Login();

                                    string datalan3 = "token=" + Application["BH_token"].ToString() + "&id_token=" + Application["BH_id_token"].ToString() + "&username=" + Application["BH_user"].ToString() + "&password=" + Application["BH_password"].ToString(); //replace <value>
                                    string requestlan3 = url + "?" + data;
                                    var httpWebRequestlan3 = (HttpWebRequest)WebRequest.Create(requestlan3);
                                    httpWebRequestlan3.Method = "POST";
                                    httpWebRequestlan3.ContentLength = bytes.Length;
                                    httpWebRequestlan3.ContentType = "application/json; charset=utf-8";
                                    using (Stream requestStreamlan3 = httpWebRequestlan3.GetRequestStream())
                                    {
                                        requestStreamlan3.Write(bytes, 0, bytes.Count());
                                        requestStreamlan3.Flush();
                                        requestStreamlan3.Close();
                                    }
                                    var httpWebResponselan3 = (HttpWebResponse)httpWebRequestlan3.GetResponse();
                                    if (httpWebResponselan3.StatusCode == HttpStatusCode.OK)
                                    {
                                        using (var streamReaderlan3 = new StreamReader(httpWebResponselan3.GetResponseStream()))
                                        {
                                            var resultlan3 = streamReaderlan3.ReadToEnd();
                                            KQNhanLichSuKCB2018 lslan3 = JsonConvert.DeserializeObject<KQNhanLichSuKCB2018>(resultlan3);

                                            return lslan3;
                                        }
                                    }
                                }
                                httpWebRequestlan2.Abort();  // !! Yes, abort the request
                                streamReaderlan2.Dispose();
                                httpWebResponselan2.Close();
                                return lslan2;
                            }
                        }
                    }
                    httpWebRequest.Abort();  // !! Yes, abort the request
                    streamReader.Dispose();
                    httpWebResponse.Close();
                    return ls;
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            return null;
        }

    }
 
    public static string encryptData(string data)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashedBytes;
        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
        return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
    }
    public void Login()
    {
        try
        {


            string _username = Application["BH_user"].ToString();
            string _password = Application["BH_password"].ToString();

            string userbh = System.Configuration.ConfigurationManager.AppSettings["BH_user"].ToString();
            string passbh = System.Configuration.ConfigurationManager.AppSettings["BH_pass"].ToString();
            Application["BH_user"] = userbh;
            Application["BH_password"] = encryptData(passbh);
            _username = Application["BH_user"].ToString();
            _password = Application["BH_password"].ToString();
            var postParameters = new ApiToken
            {
                username = _username,
                password = _password
            };
            string url = string.Format("http://egw.baohiemxahoi.gov.vn/api/token/take");
          
            string postData = JsonConvert.SerializeObject(postParameters);
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.Accept = "application/json";
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            //  httpWebRequest.Headers.Add("Authorization", "BASIC " + Convert.ToBase64String(bytes));
            httpWebRequest.UseDefaultCredentials = true;
            httpWebRequest.PreAuthenticate = true;
            //httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            httpWebRequest.Credentials = new NetworkCredential(_username, _password);
            //httpWebRequest.Credentials = new NetworkCredential("username", "password");
            byte[] user = Encoding.UTF8.GetBytes(_username + ":" + _password);
            httpWebRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(user));
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Count());
                requestStream.Flush();
                requestStream.Close();
            }

            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            if (httpWebResponse.StatusCode == HttpStatusCode.OK)
            {
                using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string result = streamReader.ReadToEnd();
                    dynamic data = JsonConvert.DeserializeObject(result);
                    // take the first element of the array
                    //Newtonsoft.Json.Linq.JObject address = data.APIKey;
                    // Newtonsoft.Json.Linq.JObject address = JObject.Parse(result);
                    // Find the first array using Linq
                    //var trgArray = new JArray();

                    //    var cleanRow = new JObject();
                    //    foreach (JProperty column in data.APIKey.Properties())
                    //    {
                    //        // Only include JValue types
                    //        if (column.Value is JValue)
                    //        {
                    //            cleanRow.Add(column.Name, column.Value);
                    //        }
                    //    }

                    //    trgArray.Add(cleanRow);


                    Token dataset = JsonConvert.DeserializeObject<Token>(result);
                    Application["BH_id_token"] = dataset.APIKey.id_token;
                    Application["BH_token"] = dataset.APIKey.access_token;
                }
            }
            httpWebResponse.Close();
            httpWebRequest.GetResponse().Close();
        }

        catch (Exception ex)
        {

        }
    }
    public class ApiToken
    {
        public string username { get; set; }
        public string password { get; set; }

    }
    public class theBHYT
    {
        public string maThe { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string maCSKCB { get; set; }
        public string ngayBD { get; set; }
        public string ngayKT { get; set; }

    }
    public class ApiKey
    {
        public string access_token { get; set; }
        public string id_token { get; set; }
        public string expires_in { get; set; }
        public string token_type { get; set; }
    }
    public class Token
    {
        public string maKetQua { get; set; }
        public ApiKey APIKey { get; set; }

    }
    public class LichSuKCB
    {
        public string maKetQua { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string maDKBD { get; set; }
        public string gtTheTu { get; set; }
        public string gtTheDen { get; set; }
        public string ngayDu5Nam { get; set; }
        public HoSo[] dsLichSuKCB { get; set; }

    }
    public class KQNhanLichSuKCB2018
    {
        public string maKetQua { get; set; }
        public string maThe { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string maDKBD { get; set; }
        public string gtTheTu { get; set; }
        public string gtTheDen { get; set; }
        public string ngayDu5Nam { get; set; }
        public string maKV { get; set; }
        public string maSoBHXH { get; set; }
        public string maTheCu { get; set; }
        public string maTheMoi { get; set; }
        public string gtTheTuMoi { get; set; }
        public string gtTheDenMoi { get; set; }
        public HoSo2018[] dsLichSuKCB2018 { get; set; }

    }
    public class HoSo
    {
        public string maHoSo { get; set; }
        public string maCSKCB { get; set; }
        public string tuNgay { get; set; }
        public string denNgay { get; set; }
        public string tenBenh { get; set; }
        public string tinhTrang { get; set; }
        public string kqDieuTri { get; set; }
        public int OrderNumber { get; set; }
        public string DieuTri
        {
            get
            {
                if (kqDieuTri == "1")
                    return "Khỏi";
                else if (kqDieuTri == "2")
                    return "Đỡ,giảm";
                else if (kqDieuTri == "3")
                    return "Không thay đổi";
                else
                    return "Nặng hơn";
            }
        }
        public string TT
        {
            get
            {
                if (tinhTrang == "1")
                    return "Bác sỹ cho ra viện";
                else if (kqDieuTri == "2")
                    return "Chuyển viện";
                else if (kqDieuTri == "3")
                    return "Trốn viện";
                else
                    return "Xin ra viện";
            }

        }
    }
    public class HoSo2018
    {
        public string maHoSo { get; set; }
        public string maCSKCB { get; set; }
        public string ngayVao { get; set; }
        public string ngayRa { get; set; }
        public string tenBenh { get; set; }
        public string tinhTrang { get; set; }
        public string kqDieuTri { get; set; }
        public int OrderNumber { get; set; }
        public string DieuTri
        {
            get
            {
                if (kqDieuTri == "1")
                    return "Khỏi";
                else if (kqDieuTri == "2")
                    return "Đỡ,giảm";
                else if (kqDieuTri == "3")
                    return "Không thay đổi";
                else
                    return "Nặng hơn";
            }
        }
        public string TT
        {
            get
            {
                if (tinhTrang == "1")
                    return "Bác sỹ cho ra viện";
                else if (kqDieuTri == "2")
                    return "Chuyển viện";
                else if (kqDieuTri == "3")
                    return "Trốn viện";
                else
                    return "Xin ra viện";
            }

        }
    }
}
