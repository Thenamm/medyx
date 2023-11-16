using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for RFID
/// day la web service dung lam trung gian de doc va ghi the tu mifare 1k
/// khi dau doc doc the thi thong tin doc duoc se duoc day vao webservice nay de luu lai
/// neu webform can thong tin se phai ket noi toi webservice de lay thong tin
/// webform can ghi thong tin len the se phai day thong tin len webservice
/// winform se kiem tra trang thai ghi, neu co thi se lay thong tin tu webservice xuong de ghi len the
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class RFID : System.Web.Services.WebService
{
    //private void WriteLog(string log)
    //{
    //    string fileName = HttpContext.Current.Request.MapPath("MyLogs.txt");
    //    if (!File.Exists(fileName))
    //    {
    //        using (StreamWriter sw = File.CreateText(fileName))
    //        {
    //            sw.WriteLine(DateTime.Now.ToString() + " " + log);
    //            sw.Close();
    //        }
    //    }
    //    else
    //    {
    //        using (StreamWriter sw = File.AppendText(fileName))
    //        {
    //            sw.WriteLine(DateTime.Now.ToString() + " " + log);
    //            sw.Close();
    //        }
    //    }
    //}
    public RFID()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    //Mang de luu du lieu cua cac card duoc doc vao
    //Moi may khi luu du lieu phai luu lai dia chi ip, may lay du lieu cung phai cung dia chi ip der khoi bi nham lan thong tin
    public static List<RFIDData> card = new List<RFIDData>();
    //Ham de luu du lieu doc tu dau doc vao mang card (winform gui)
    [WebMethod]
    public void Receive(string data, string ip)
    {
       // WriteLog("Dữ liệu gửi từ winform lên webservice (Hàm Receive(string data, string ip))\n");
        if (card.Count > 0)
        {
            var cardData = card.FirstOrDefault(i => i.IP == ip);
            if (cardData != null)
            {
              //  WriteLog("Trước khi gán lúc" + DateTime.Now.ToString() + ":\n");
              //  WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
                cardData.DATA = data;
                cardData.IP = ip;
                cardData.UpData = null;
                cardData.GHI = false;
                cardData.CALL = false;
              //  WriteLog("Sau khi gán lúc" + DateTime.Now.ToString() + ":\n");
              //  WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
            }
            else
            {
              //  WriteLog("Trước khi gán:\n");
              //  WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
                RFIDData cd = new RFIDData(data, null, false, ip, false);
                card.Add(cd);
               // WriteLog("Sau khi gán:\n");
              //  WriteLog("Data: " + cd.DATA + " IP:" + cd.IP + " Ghi: " + cd.GHI + " Call: " + cd.CALL);
            }
        }
        else
        {
            RFIDData cd = new RFIDData(data, null, false, ip, false);
            card.Add(cd);
           // WriteLog("Sau khi gán:\n");
          //  WriteLog("Data: " + cd.DATA + " IP:" + cd.IP + " Ghi: " + cd.GHI + " Call: " + cd.CALL);
        }
    }
    //Ham de hien thi thong tin duoc doc vao (webform hien thi)
    [WebMethod]
    public string GetData(string ip)
    {
       // WriteLog("Dữ liệu webform lấy từ webservice (Hàm GetData(string ip))\n");
        string result = null;
        var cardData = card.FirstOrDefault(i => i.IP == ip);
        {
            if (cardData != null)
            {
              //  WriteLog("Trước khi gán lúc" + DateTime.Now.ToString() + ":\n");
              //  WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
                result = cardData.DATA;
                cardData.DATA = null;
                cardData.GHI = false;
                cardData.CALL = false;
               // WriteLog("Sau khi gán lúc" + DateTime.Now.ToString() + ":\n");
               // WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
            }
        }
        return result;
    }
    //Ham de day thong tin can ghi len the (webform day sang)
    [WebMethod]
    public void UpdateCard(string[] data, string ip)
    {
        var cardData = card.FirstOrDefault(i => i.IP == ip);
        {
            if (cardData != null)
            {
                cardData.UpData = data;
                cardData.DATA = null;
                cardData.GHI = true;
                cardData.CALL = false;
            }
        }
    }
    //Ham de kiem tra trang thai ghi cua the(winform lay)
    [WebMethod]
    public bool IsUpdate(string ip)
    {
        bool result = false;
        var cardData = card.FirstOrDefault(i => i.IP == ip);
        {
            if (cardData != null)
            {
                result = cardData.GHI;
            }
        }
        return result;
    }
    //Ham de lay thong tin can ghi de ghi (winform lay)
    [WebMethod]
    public string[] GetUpdateData(string ip)
    {
        string[] result = null;
        var cardData = card.FirstOrDefault(i => i.IP == ip);
        {
            if (cardData != null)
            {
                result = cardData.UpData;
                card.Remove(cardData);
            }
        }
        return result;
    }
    [WebMethod]
    public string GetAllCardData()
    {
      //  WriteLog("Hàm GetAllCardData()\n");
        string result = null;
        result += "Mảng card có: " + card.Count + " card!";
        if (card.Count > 0)
        {
            for (int i = 0; i < card.Count; i++)
            {
                result += "\n";
                result += "ip: " + card[i].IP + " seri: " + card[i].DATA;
            }
        }
        return result;
    }
    //Ham nay dung de winform kiem tra xem web co goi doc the khong
    [WebMethod]
    public bool IsCallReadCard(string ip)
    {
       // WriteLog("Ham nay dung de winform kiem tra xem web co goi doc the khong (Hàm IsCallReadCard(string ip))\n");
        bool result = false;
        var cardData = card.FirstOrDefault(i => i.IP == ip);
        {
            if (cardData != null)
            {
              //  WriteLog("Trước khi gán lúc" + DateTime.Now.ToString() + ":\n");
              //  WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
                result = cardData.CALL;
              //  WriteLog("Sau khi gán lúc" + DateTime.Now.ToString() + ":\n");
               // WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);

            }
        }
        return result;
    }
    //Ham nay dung de web goi doc the
    [WebMethod]
    public void CallReadCard(string ip)
    {
        if (card.Count > 0)
        {
           // WriteLog("Ham nay dung de web goi doc the (Hàm CallReadCard(string ip))\n");
            var cardData = card.FirstOrDefault(i => i.IP == ip);
            if (cardData != null)
            {
              //  WriteLog("Trước khi gán lúc" + DateTime.Now.ToString() + ":\n");
              //  WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
                cardData.DATA = null;
                cardData.IP = ip;
                cardData.UpData = null;
                cardData.GHI = false;
                cardData.CALL = true;
               // WriteLog("Sau khi gán lúc" + DateTime.Now.ToString() + ":\n");
             //   WriteLog("Data: " + cardData.DATA + " IP:" + cardData.IP + " Ghi: " + cardData.GHI + " Call: " + cardData.CALL);
            }
            else
            {
                RFIDData cd = new RFIDData(null, null, false, ip, true);
                card.Add(cd);
            }
        }
        else
        {
            RFIDData cd = new RFIDData(null, null, false, ip, true);
            card.Add(cd);
        }
    }
}
public class RFIDData
{
    string Data;
    string[] UpdateData;
    bool Ghi;
    string Ip;
    bool Call;
    public RFIDData()
    {
        Data = null;
        UpdateData = null;
        Ghi = false;
        Ip = null;
        Call = false;
    }
    public RFIDData(string data, string[] updata, bool ghi, string ip, bool call)
    {
        Data = data;
        UpdateData = updata;
        Ghi = ghi;
        Ip = ip;
        Call = call;
    }
    public string DATA
    {
        get
        {
            return Data;
        }
        set
        {
            Data = value;
        }
    }
    public string[] UpData
    {
        get
        {
            return UpdateData;
        }
        set
        {
            UpdateData = value;
        }
    }
    public bool GHI
    {
        get
        {
            return Ghi;
        }
        set
        {
            Ghi = value;
        }
    }
    public string IP
    {
        get
        {
            return Ip;
        }
        set
        {
            Ip = value;
        }
    }
    public bool CALL
    {
        get
        {
            return Call;
        }
        set
        {
            Call = value;
        }
    }
}