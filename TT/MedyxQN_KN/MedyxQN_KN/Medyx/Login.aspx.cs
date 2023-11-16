using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string LoginName = txtLoginName.Text.Trim();
        string password = txtPassword.Text.Trim();

        ASCIIEncoding ascEn = new ASCIIEncoding();
        SHA512Managed sha512 = new SHA512Managed();

        byte[] bInput = ascEn.GetBytes(password);
        string encodedPass = ascEn.GetString(sha512.ComputeHash(bInput));

        System.Data.Linq.ISingleResult<spACCOUNT_Get> _Account = null;
        HL7CoreDataDataContext db = new HL7CoreDataDataContext();

        _Account = db.spACCOUNT_Get(LoginName);
        foreach (var item in _Account)
        {
            if (item.Password == password)
            {
                Session[SessionVariables.Pub_sNguoiSD] = item.MaNV;
                Session[SessionVariables.Pub_sAccount] = LoginName;
                Session[SessionVariables.Pub_sTenNguoiSD] = item.HoTen;
                Session[SessionVariables.Pub_sQuay] = item.GhiChu;
                Session[SessionVariables.pub_bQadmin] = item.Qadmin;
                Session[SessionVariables.pub_bSgia] = item.Qsgia;
                HTC.Business.CategoryList.ThamSo ts = HTC.Business.CategoryList.ThamSo.GetThamSo();
                HTC.ShareVariables.pub_sDaiDien = ts.daidien;

                System.Web.Security.FormsAuthentication.SetAuthCookie(LoginName, true);
                new DBTableAdapters.LogTimeTableAdapter().Insert(Session[SessionVariables.Pub_sNguoiSD].ToString(), Session[SessionVariables.Pub_sTenNguoiSD].ToString(), Context.Session.SessionID, DateTime.Now);
                Response.Redirect("~/Default.aspx");
                return;
            }
          
        }
     
    }
}