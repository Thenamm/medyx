//using DocumentFormat.OpenXml;
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
using System.Activities.Statements;
using System.Xml;
//using DocumentFormat.OpenXml.Drawing.Diagrams;
using CrystalDecisions.Web;
//using DocumentFormat.OpenXml.Presentation;
//using Microsoft.Security.Application;
using Telerik.Web.UI;
using HTC.Business.CategoryList;
using Lucene.Net.Store;
using Telerik.Web.UI.Widgets;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text.pdf;


public partial class UI_Category_DMHanhChinh_CKS : HTC.Common.Web.WebBase
{

    //public class AntiXssEncoder : System.Web.Util.HttpEncoder { }
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

            if (!CheckURL())
            {
          
                ReadFormdata();

                ReadDataFormdata();
            }
            else
            {
                Response.Redirect("/Default.aspx");
            }
        }
        //else
        //{
        //    ShowMessage("load lai trang");
        //}
    }

    private bool CheckURL()
    {

        string currentUrl = HttpContext.Current.Request.Url.AbsoluteUri;

        return !currentUrl.Contains(".XML");
    }
    private string  ReadFormdata()
    {
        string logFileName = Request.Unvalidated["filepath"].ToString();
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        string logFilePath = Path.Combine(directory, logFileName);
        string config = File.ReadAllText(logFilePath);
        Textarea1.Value= config;
        return config;
    }
    private string ReadDataFormdata()
    {
        string logFileName = Request.Unvalidated["filepath"].ToString();
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        string logFilePath = Path.Combine(directory, logFileName);
        string config = File.ReadAllText(logFilePath);
        //if (Textarea1.Text.Length == 0)
        //    Textarea1.Text = config;
        byte[] configBytes = Encoding.UTF8.GetBytes(config);
        string base64String = Convert.ToBase64String(configBytes);
        if (xmlPath.Value.Length == 0)
            xmlPath.Value = base64String;
        return base64String;

    }

    protected void SignBase64XML()
    {
        try
        {   
            string base64Data = SigningResult.InnerText;

            byte[] dataBytes = Convert.FromBase64String(base64Data);

            string xmlText = Encoding.UTF8.GetString(dataBytes);
            savecf.Value = xmlText;
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string logFileName = Request.Unvalidated["filepath"].ToString();
            string logFilePath = Path.Combine(directory, logFileName);

            File.WriteAllText(logFilePath, xmlText);



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
            SigningResult.InnerText = "Lỗi: Không thể ký một XML trống";
        }
        else
        {
            
            SignBase64XML();

        }
    }
    protected void btnEXIT_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Default.aspx");
    }

    //protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    //{

    //    switch (e.Item.Value)
    //    {
    //        case "cmdExit":
    //            Response.Redirect("~/Default.aspx");
    //            break;
    //        default:
    //            break;

    //    }
    //}



}