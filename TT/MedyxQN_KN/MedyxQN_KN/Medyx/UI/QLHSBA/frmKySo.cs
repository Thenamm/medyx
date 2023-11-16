
using Org.BouncyCastle.Crypto.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Xml;
using CrystalDecisions.Web;
using Telerik.Web.UI;
using HTC.Business.CategoryList;
using Lucene.Net.Store;
using Telerik.Web.UI.Widgets;
using System.Net;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text.pdf;
//using Telerik.Web.UI.ImageEditor;
//using CrystalDecisions.Web.Services;
//using System.Runtime.Serialization;
//using System.Runtime.CompilerServices;
//using Org.BouncyCastle.Crypto.Tls;
//using Microsoft.SqlServer.Management.SqlParser.Metadata;
//using TestStack.White.UIItems.Finders;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;

public partial class UI_QLHSBA_frmKySo : HTC.Common.Web.WebBase
{


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            ConvertPDFtoBase64();

        }
        else
        {
            Response.Redirect("/Default.aspx");
        }
    }

    protected void ConvertPDFtoBase64()
    {
        try
        {
            string pdfFilePath = @"E:\file.pdf";
            byte[] pdfBytes = File.ReadAllBytes(pdfFilePath);

            string base64Data = Convert.ToBase64String(pdfBytes);
            pdfPath.Value = base64Data;
        }
        catch (Exception ex)
        {
            SigningResult.InnerText = "Lỗi: " + ex.Message;
        }
    }

    protected void SignBase64PDF()
    {
        try
        {
            string base64Data = SigningResult.InnerText;

            byte[] dataBytes = Convert.FromBase64String(base64Data);

            string pdfText = Encoding.UTF8.GetString(dataBytes);
            savecf.Value = pdfText;
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string logFileName = Request.Unvalidated["filepath"].ToString();
            string logFilePath = Path.Combine(directory, logFileName);

            File.WriteAllText(logFilePath, pdfText);
            string signedPdfPath = @"E:\signed_file.pdf";
            //byte[] signedPdfBytes = Convert.FromBase64String(base64Data);
            File.WriteAllBytes(signedPdfPath, dataBytes);
        }
        catch (Exception ex)
        {
            SigningResult.InnerText = "Lỗi : " + ex.Message;
        }
    }

    protected void btnSign_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(SigningResult.InnerText))
        {
            SigningResult.InnerText = "Lỗi: Không thể ký một PDF trống";
        }
        else
        {
            SignBase64PDF();
        }
    }


    protected void btnEXIT_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Default.aspx");
    }



    //public DataTable KeyVip(string MaKey)
    //{
    //    DataTable dr = new DataTable();
    //    string tenStore = "KeyVip";
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@MaKey", MaKey));
    //            SqlDataAdapter dp = new SqlDataAdapter(Command);
    //            dp.Fill(dr);
    //        }
    //        Conection.Close();
    //        Conection.Dispose();
    //        return dr;
    //    }
    //}
    //public DataTable spHSBA_Insert(string STT, string LoaiTaiLieu, string STTDV, string MaBA, string MaBN, string TaiLieuDinhKem, string Link,  string Data, string MaMay, DateTime NgayLap, string NguoiLap)
    //{
    //    string tenStore = "spHSBA_Insert";
    //    DataTable dr = new DataTable();
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@STT", STT));
    //            Command.Parameters.Add(new SqlParameter("@LoaiTaiLieu", LoaiTaiLieu));
    //            Command.Parameters.Add(new SqlParameter("@STTDV  ", STTDV));
    //            Command.Parameters.Add(new SqlParameter("@MaBA ", MaBA));
    //            Command.Parameters.Add(new SqlParameter("@MaBN ", MaBN));
    //            Command.Parameters.Add(new SqlParameter("@TaiLieuDinhKem", TaiLieuDinhKem));
    //            Command.Parameters.Add(new SqlParameter("@Link ", Link));
    //            Command.Parameters.Add(new SqlParameter("@Data", Data));
    //            Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
    //            Command.Parameters.Add(new SqlParameter("@NgayLap", NgayLap));
    //            Command.Parameters.Add(new SqlParameter("@NguoiLap", NguoiLap));


    //            //Command.ExecuteNonQuery();
    //            SqlDataAdapter dp = new SqlDataAdapter(Command);
    //            dp.Fill(dr);
    //        }
    //        Conection.Close();
    //        Conection.Dispose();
    //        return dr;
    //    }
    //}

    //protected void btnSave_Click(object sender, EventArgs e)
    //{

    //    string pdfLink = Textarea1.Value.Trim();
        
    //    string STT = "";
    //    string LoaiTaiLieu = "";
    //    string STTDV = "";
    //    string MaBA = "";
    //    string MaBN = "";
    //    string TaiLieuDinhKem = "";
    //    string Link = "";
    //    string Data = "";
    //    string MaMay = Pub_sMaMay;
    //    DateTime NgayLap = DateTime.Now;
    //    string NguoiLap = Pub_sNguoiSD;
    //    if (!string.IsNullOrEmpty(pdfLink))
    //    {

    //        WebClient client = new WebClient();
    //        byte[] pdfBytes = client.DownloadData(pdfLink);

    //        string base64Pdf = Convert.ToBase64String(pdfBytes);

    //        ShowMessage("Lưu thành công !");

    //        spHSBA_Insert(STT, LoaiTaiLieu, STTDV, MaBA, MaBN, TaiLieuDinhKem, Link, Data, Pub_sMaMay, NgayLap, Pub_sNguoiSD);
    //    }
    //    else
    //    {
    //        ShowMessage(" Lưu không  thành công!");
    //    }
    //}

    //protected void btnSave_Click(object sender, EventArgs e)
    //{

    //    string content = file2.Text;
    //    string STT = "1";
    //    string IDBA = "12";
    //    string STT_Khoa = "";
    //    string LoaiGiayTo = "";
    //    string MaBN = "";
    //    string MaBS = "";
    //    string TenBS = "";
    //    string TrangThaiKy = "";
    //    string LanKy = "";
    //    string DuongDanFile = "";
    //    string MaMay = Pub_sMaMay;
    //    DateTime NgayLap = DateTime.Now;
    //    DateTime NgaySD = DateTime.Now;
    //    string NguoiSD = Pub_sNguoiSD;

    //    if (content.Contains("http"))
    //    {

    //        spTrangThaiKy_Insert(STT, IDBA, STT_Khoa,  LoaiGiayTo,  MaBN,  MaBS,  TenBS,  TrangThaiKy,  LanKy,  DuongDanFile,  MaMay,  NgayLap,  NgaySD,  NguoiSD);
    //    }
    //}


    //public DataTable spTrangThaiKy_Insert(string STT, string IDBA, string STT_Khoa, string LoaiGiayTo, string MaBN, string MaBS, string TenBS,string TrangThaiKy, string LanKy, string DuongDanFile, string MaMay, DateTime NgayLap, DateTime NgaySD, string NguoiSD)
    //{
    //    string tenStore = "spTrangThaiKy_Insert";
    //    DataTable dr = new DataTable();
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@STT", STT));
    //            Command.Parameters.Add(new SqlParameter("@IDBA", IDBA));
    //            Command.Parameters.Add(new SqlParameter("@STT_Khoa", STT_Khoa));
    //            Command.Parameters.Add(new SqlParameter("@LoaiGiayTo  ", LoaiGiayTo));
    //            Command.Parameters.Add(new SqlParameter("@MaBN ", MaBN));
    //            Command.Parameters.Add(new SqlParameter("@MaBS ", MaBS));
    //            Command.Parameters.Add(new SqlParameter("@TenBS", TenBS));
    //            Command.Parameters.Add(new SqlParameter("@TrangThaiKy ", TrangThaiKy));
    //            Command.Parameters.Add(new SqlParameter("@LanKy ", LanKy));
    //            Command.Parameters.Add(new SqlParameter("@DuongDanFile", DuongDanFile));
    //            Command.Parameters.Add(new SqlParameter("@MaMay", MaMay));
    //            Command.Parameters.Add(new SqlParameter("@NgayLap", NgayLap));
    //            Command.Parameters.Add(new SqlParameter("@NgaySD", NgaySD));
    //            Command.Parameters.Add(new SqlParameter("@NguoiSD", NguoiSD));

    //            //Command.ExecuteNonQuery();
    //            SqlDataAdapter dp = new SqlDataAdapter(Command);
    //            dp.Fill(dr);
    //        }
    //        Conection.Close();
    //        Conection.Dispose();
    //        return dr;
    //    }
    //}



}




