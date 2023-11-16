using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login2 : System.Web.UI.Page
{
    /// <summary>
    ///     Page_PreInit event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_PreInit(object sender, EventArgs e)
    {
        /*
        if (Request.Cookies["AdminInfo"] != null)
        {
            HttpCookie cookie = Request.Cookies["AdminInfo"];
            Session["AdminID"] = cookie["AdminID"];
            Session["AdminLoginName"] = cookie["AdminLoginName"];
            Response.Redirect("Default.aspx");
        }
         */
        Session[SessionVariables.pub_showMaSoKham] = "";
        Session[SessionVariables.pub_showview] = 0;
        if (Session[SessionVariables.Pub_sNguoiSD] != null)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
    /// <summary>
    //      Page_Load event is triggered when a page loads, and ASP.NET will automatically call the subroutine Page_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
    }


    /// <summary>
    ///     Handle event when admin clicks on button Button1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string loginName = txtUserName.Text;
            string password = txtPassword.Text;
          
            ASCIIEncoding ascEn = new ASCIIEncoding();
            SHA512Managed sha512 = new SHA512Managed();
         
            byte[] bInput = ascEn.GetBytes(password);
            string encodedPass = ascEn.GetString(sha512.ComputeHash(bInput));

            //if (HTC.Security.HTCPrincipal.Login(loginName, password))
            //{
            //    Session[SessionVariables.Pub_sNguoiSD] = HTC.ShareVariables.pub_sNguoiSD;
            //    Session[SessionVariables.Pub_sAccount] = loginName ;
            //    Session[SessionVariables.Pub_sTenNguoiSD] = HTC.ShareVariables.pub_sTenNguoiSD;
            //    Session[SessionVariables.Pub_sQuay] = HTC.ShareVariables.pub_sQuay;
            //    Session[SessionVariables.pub_bQadmin] = HTC.ShareVariables.pub_bQadmin;
            //    Session[SessionVariables.pub_bSgia] = HTC.ShareVariables.pub_bSgia;
            //    System.Web.Security.FormsAuthentication.SetAuthCookie(loginName, true);
            //   new DBTableAdapters.LogTimeTableAdapter().Insert(Session[SessionVariables.Pub_sNguoiSD].ToString(), Session[SessionVariables.Pub_sTenNguoiSD].ToString(), Context.Session.SessionID, DateTime.Now);

            //    Response.Redirect("~/Default.aspx");
            //}
            System.Data.Linq.ISingleResult<spACCOUNT_Get> _Account = null;
            HL7CoreDataDataContext db = new HL7CoreDataDataContext();

            _Account = db.spACCOUNT_Get(loginName);
            foreach (var item in _Account)
            {
               
                if (item.Password == password)
                {
                    Session[SessionVariables.Pub_sNguoiSD] = item.MaNV;
                    Session[SessionVariables.Pub_sAccount] = loginName;
                    Session[SessionVariables.Pub_sTenNguoiSD] = item.HoTen;
                    Session[SessionVariables.Pub_sQuay] = item.GhiChu;
                    Session[SessionVariables.pub_bQadmin] = item.Qadmin;
                    Session[SessionVariables.pub_bSgia] = item.Qsgia;
                    string user = System.Configuration.ConfigurationManager.AppSettings["BH_user"].ToString();
                    string pass = System.Configuration.ConfigurationManager.AppSettings["BH_pass"].ToString();
                    string bh = System.Configuration.ConfigurationManager.AppSettings["BH_internet"].ToString();
                    if (bh == null || bh == "" || bh.ToString() != "YES")
                    {
                        Application["BH_internet"] = "";
                    }
                    else if (bh.ToString () != "YES")
                    {
                        Application["BH_internet"] = "";
                    }
                    else
                    {
                        Application["BH_internet"] = "YES";
                        HisBHYT bhyt = new HisBHYT(user,pass);
                    }
                    HTC.Business.CategoryList.ThamSo ts = HTC.Business.CategoryList.ThamSo.GetThamSo();
                    HTC.ShareVariables.pub_sDaiDien = ts.daidien;
                   
                    System.Web.Security.FormsAuthentication.SetAuthCookie(loginName, true);
                    new DBTableAdapters.LogTimeTableAdapter().Insert(Session[SessionVariables.Pub_sNguoiSD].ToString(), Session[SessionVariables.Pub_sTenNguoiSD].ToString(), Context.Session.SessionID, DateTime.Now);
                  
                    if (item.Account =="tcbn")
                        Response.Redirect("~/UI/NoiTru/KhamBenh/FrmTTBenhNhan.aspx", false);
                    else if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PS" ||  HTC.ShareVariables.pub_spC == "YH")
                    {
                        List<EntityMenu> ListMenuCap2 = (List<EntityMenu>)Application["Menuleve2" + Session[SessionVariables.Pub_sAccount].ToString()];
                        if (ListMenuCap2 != null)
                        {
                            foreach (EntityMenu item1 in ListMenuCap2)
                            {
                                if (item1.MaMN == "024000")
                                {
                                    // Response.Write(item.Path);
                                    Response.Redirect("~/" + item1.Path, false);
                                    return;
                                }
                            }
                            if ((HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")||HTC.ShareVariables .pub_spC =="PS") 
                            {
                                //if (Session[SessionVariables.Pub_sQuay] != null)
                                //    if (Session[SessionVariables.Pub_sQuay].ToString() != "")
                                        Response.Redirect("~/NhanVienLogin.aspx");
                            }

                            Response.Redirect("~/Default.aspx", false);
                        }
                        if ((HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")||HTC.ShareVariables .pub_spC =="PS")
                        {
                            //if (Session[SessionVariables.Pub_sQuay] != null)
                            //    if (Session[SessionVariables.Pub_sQuay].ToString() != "")
                                    Response.Redirect("~/NhanVienLogin.aspx");
                        }
                        Response.Redirect("~/Default.aspx", false);
                    }
                    else
                    {
                        if ((HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")||HTC.ShareVariables .pub_spC =="PS")
                        {
                            //if (Session[SessionVariables.Pub_sQuay] != null)
                            //    if (Session[SessionVariables.Pub_sQuay].ToString() != "")
                                    Response.Redirect("~/NhanVienLogin.aspx");
                        }
                        Response.Redirect("~/Default.aspx", false);
                    }
                    return;
                }
                else
                    lblInformation.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                return;
            }
            lblInformation.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";

        }
        catch (Exception ex)
        {
            
        }
        /*
        ASCIIEncoding ascEn = new ASCIIEncoding();
        byte[] bInput = ascEn.GetBytes(txtPassword.Text);
        SHA512Managed sha512M = new SHA512Managed();
        byte[] bOutput = sha512M.ComputeHash(bInput);

        AdminsTableAdapter adminDA = new AdminsTableAdapter();
        BookStore.AdminsDataTable adminDT = adminDA.GetAdminByLoginNameAndPassword(loginName, ascEn.GetString(bOutput));
        if (adminDT.Rows.Count > 0)
        {
            BookStore.AdminsRow adminRow = adminDT.Rows[0] as BookStore.AdminsRow;

            Session["AdminID"] = adminRow.AdminID;
            Session["AdminLoginName"] = adminRow.LoginName;

            if (cbRemember.Checked)
            {
                HttpCookie cookie = new HttpCookie("AdminInfo");
                cookie["AdminID"] = adminRow.AdminID.ToString();
                cookie["AdminLoginName"] = adminRow.LoginName;
                cookie.Expires = DateTime.MaxValue;
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblInformation.Text = " Wrong loginname or password ! ";
        }
         * */
    }
}