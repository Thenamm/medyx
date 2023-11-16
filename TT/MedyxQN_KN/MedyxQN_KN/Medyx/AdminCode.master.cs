using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using HTC.Business.Officer;
using Telerik.Web.UI;
using System.Reflection;

public partial class AdminCode_AdminCode : System.Web.UI.MasterPage
{
    [System.Web.Services.WebMethod]
    public static string DeleteSession()
    {
        return "hello";
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        //Page.Header.DataBind();    
        //Master.Page.Header.DataBind();

        try
        {
            //string _admin = Session[SessionVariables.Pub_sAccount].ToString();
            if (Session[SessionVariables.Pub_sAccount] == null || Session[SessionVariables.Pub_sAccount].ToString() == "")
                Response.Redirect("~/Login2.aspx");
            //Page.Header.DataBind();    
        }
        catch (Exception)
        {
            Response.Redirect("~/Login2.aspx");
        }

        if (!IsPostBack)
        {
            string _admin = Session[SessionVariables.Pub_sAccount].ToString();

            if (Request["MaBA"] != null)
            {
                txtCT.Value = "CT";
            }
            else if (Request["LoaiPhieu"] != null && Request["MaSoKham"] != null)
            {
                if (Request["LoaiPhieu"].ToString() == "3" || Request["LoaiPhieu"].ToString() == "4")
                {
                    txtCT.Value = "CT";
                }
            }
            else if (Request["LoaiPhieu"] != null && (Request.Path.IndexOf("frmDSBenhNhan.aspx") > 0))
            {

                txtCT.Value = "CT";

            }
            //else if ( (Request.Path.IndexOf("Default.aspx") <= 0))
            //{

            //    txtCT.Value = "CT";

            //}
            if (txtCT.Value != "CT")
            {
                LoadMenu();
                //   LoadMenu(null, _admin, string.Empty);
            }
            //  LoadMenu(null, _admin, string.Empty);
            //System.IO.StringWriter writer = new System.IO.StringWriter();
            //System.IO.ViewStateParser p = new System.IO.(writer);
            //string  a ="/wEPDwUKLTI1NDA5NTM0Ng8WBB4ETWFNTgUCMDAeAklEBQEwFgJmD2QWAgIBD2QWCgICD2QWAmYPFCsAAg8WBB4TY2FjaGVkU2VsZWN0ZWRWYWx1ZWQeB1Zpc2libGVoZBAWFGYCAQICAgMCBAIFAgYCBwIIAgkCCgILAgwCDQIOAg8CEAIRAhICExYUFCsAAg8WBh4EVGV4dAUFQmxhY2seBVZhbHVlBQVCbGFjax4IU2VsZWN0ZWRoZGQUKwACDxYGHwQFD0JsYWNrTWV0cm9Ub3VjaB8FBQ9CbGFja01ldHJvVG91Y2gfBmhkZBQrAAIPFgYfBAUHRGVmYXVsdB8FBQdEZWZhdWx0HwZnZGQUKwACDxYGHwQFBEdsb3cfBQUER2xvdx8GaGRkFCsAAg8WBh8EBQVNZXRybx8FBQVNZXRybx8GaGRkFCsAAg8WBh8EBQpNZXRyb1RvdWNoHwUFCk1ldHJvVG91Y2gfBmhkZBQrAAIPFgYfBAUKT2ZmaWNlMjAwNx8FBQpPZmZpY2UyMDA3HwZoZGQUKwACDxYGHwQFD09mZmljZTIwMTBCbGFjax8FBQ9PZmZpY2UyMDEwQmxhY2sfBmhkZBQrAAIPFgYfBAUOT2ZmaWNlMjAxMEJsdWUfBQUOT2ZmaWNlMjAxMEJsdWUfBmhkZBQrAAIPFgYfBAUQT2ZmaWNlMjAxMFNpbHZlch8FBRBPZmZpY2UyMDEwU2lsdmVyHwZoZGQUKwACDxYGHwQFB091dGxvb2sfBQUHT3V0bG9vax8GaGRkFCsAAg8WBh8EBQRTaWxrHwUFBFNpbGsfBmhkZBQrAAIPFgYfBAUGU2ltcGxlHwUFBlNpbXBsZR8GaGRkFCsAAg8WBh8EBRVTaXRlZmluaXR5IChPYnNvbGV0ZSkfBQUKU2l0ZWZpbml0eR8GaGRkFCsAAg8WBh8EBQZTdW5zZXQfBQUGU3Vuc2V0HwZoZGQUKwACDxYGHwQFB1RlbGVyaWsfBQUHVGVsZXJpax8GaGRkFCsAAg8WBh8EBQVWaXN0YR8FBQVWaXN0YR8GaGRkFCsAAg8WBh8EBQVXZWIyMB8FBQVXZWIyMB8GaGRkFCsAAg8WBh8EBQdXZWJCbHVlHwUFB1dlYkJsdWUfBmhkZBQrAAIPFgYfBAUIV2luZG93czcfBQUIV2luZG93czcfBmhkZA8WFGZmZmZmZmZmZmZmZmZmZmZmZmZmFgEFd1RlbGVyaWsuV2ViLlVJLlJhZENvbWJvQm94SXRlbSwgVGVsZXJpay5XZWIuVUksIFZlcnNpb249MjAxNC4yLjcyNC40MCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj0xMjFmYWU3ODE2NWJhM2Q0FixmDw8WBB4IQ3NzQ2xhc3MFCXJjYkhlYWRlch4EXyFTQgICZGQCAQ8PFgQfBwUJcmNiRm9vdGVyHwgCAmRkAgIPDxYGHwQFBUJsYWNrHwUFBUJsYWNrHwZoZGQCAw8PFgYfBAUPQmxhY2tNZXRyb1RvdWNoHwUFD0JsYWNrTWV0cm9Ub3VjaB8GaGRkAgQPDxYGHwQFB0RlZmF1bHQfBQUHRGVmYXVsdB8GZ2RkAgUPDxYGHwQFBEdsb3cfBQUER2xvdx8GaGRkAgYPDxYGHwQFBU1ldHJvHwUFBU1ldHJvHwZoZGQCBw8PFgYfBAUKTWV0cm9Ub3VjaB8FBQpNZXRyb1RvdWNoHwZoZGQCCA8PFgYfBAUKT2ZmaWNlMjAwNx8FBQpPZmZpY2UyMDA3HwZoZGQCCQ8PFgYfBAUPT2ZmaWNlMjAxMEJsYWNrHwUFD09mZmljZTIwMTBCbGFjax8GaGRkAgoPDxYGHwQFDk9mZmljZTIwMTBCbHVlHwUFDk9mZmljZTIwMTBCbHVlHwZoZGQCCw8PFgYfBAUQT2ZmaWNlMjAxMFNpbHZlch8FBRBPZmZpY2UyMDEwU2lsdmVyHwZoZGQCDA8PFgYfBAUHT3V0bG9vax8FBQdPdXRsb29rHwZoZGQCDQ8PFgYfBAUEU2lsax8FBQRTaWxrHwZoZGQCDg8PFgYfBAUGU2ltcGxlHwUFBlNpbXBsZR8GaGRkAg8PDxYGHwQFFVNpdGVmaW5pdHkgKE9ic29sZXRlKR8FBQpTaXRlZmluaXR5HwZoZGQCEA8PFgYfBAUGU3Vuc2V0HwUFBlN1bnNldB8GaGRkAhEPDxYGHwQFB1RlbGVyaWsfBQUHVGVsZXJpax8GaGRkAhIPDxYGHwQFBVZpc3RhHwUFBVZpc3RhHwZoZGQCEw8PFgYfBAUFV2ViMjAfBQUFV2ViMjAfBmhkZAIUDw8WBh8EBQdXZWJCbHVlHwUFB1dlYkJsdWUfBmhkZAIVDw8WBh8EBQhXaW5kb3dzNx8FBQhXaW5kb3dzNx8GaGRkAgQPDxYGHhVFbmFibGVFbWJlZGRlZFNjcmlwdHNnHhxFbmFibGVFbWJlZGRlZEJhc2VTdHlsZXNoZWV0Zx4SUmVzb2x2ZWRSZW5kZXJNb2RlCylyVGVsZXJpay5XZWIuVUkuUmVuZGVyTW9kZSwgVGVsZXJpay5XZWIuVUksIFZlcnNpb249MjAxNC4yLjcyNC40MCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj0xMjFmYWU3ODE2NWJhM2Q0ARYCHgVzdHlsZQUNZGlzcGxheTpub25lO2QCBQ9kFgICBw8PFgIfBAUTVsawxqFuZyBIb8OgbmcgTGluaGRkAgYPFCsAAhQrAAIPFgYfCWcfCwsrBAEfCmdkZGRkAgkPZBYCZg8UKwACDxYGHwlnHwpnHwsLKwQBZBAWBmYCAQICAgMCBAIFFgYUKwACZGQUKwACZGQUKwACZGQUKwACZGQUKwACZGQUKwACZGQPFgZmZmZmZmYWAQV4VGVsZXJpay5XZWIuVUkuUmFkVG9vbEJhckJ1dHRvbiwgVGVsZXJpay5XZWIuVUksIFZlcnNpb249MjAxNC4yLjcyNC40MCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj0xMjFmYWU3ODE2NWJhM2Q0ZBgCBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WCQUWY3RsMDAkUXNmRnJvbURlY29yYXRvcgUNY3RsMDAkcmFkTWVudQUjY3RsMDAkQ29udGVudFBsYWNlSG9sZGVyMSRiYXJhY3Rpb24FH2N0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDAFH2N0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDEFH2N0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDIFH2N0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDIFH2N0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDMFH2N0bDAwJENvbnRlbnRQbGFjZUhvbGRlcjEkY3RsMDMFEWN0bDAwJFNraW5DaG9vc2VyDxQrAAJlBQdEZWZhdWx0ZAhvCZggnn+smBVW3P45pZEKSHaQWMhnSllMsrGzFKNI";
            //p.ParseViewStateGraph(a);
            //  txta.Text=writer.ToString();
            /*
            Telerik.Web.UI.RadSkinManager skinManager = new Telerik.Web.UI.RadSkinManager();
            skinManager.Skin = "Default"; 
             */
        }
    }

    private String GetStr(string input, int length)
    {
        string outPut = string.Empty;
        if (!string.IsNullOrEmpty(input) && input.Length >= length)
            outPut = input.Substring(0, length);
        return outPut;
    }
    private void LoadMenu(RadMenuItem parentMenuItem, string accountName, string levelName)
    {
        GetMenuByAccountListInfo menuList = null;

        if (Application["MenuLevel" + levelName + accountName] == null)
        {
            menuList = GetMenuByAccountListInfo.GetAllGetMenuByAccountList(accountName, levelName);

            Application["MenuLevel" + levelName + accountName] = menuList;
        }
        else
        {
            menuList = (GetMenuByAccountListInfo)Application["MenuLevel" + levelName + accountName];
        }

        /*
        int menuItemLevel1Width = 100;
        if (String.IsNullOrEmpty(levelName))
        {
            if (menuList.Count > 0)
            {
                menuItemLevel1Width = 1000 / (menuList.Count);


            }
        }*/



        //      Gán Mã Quyền cho người sử dụng qua biến Session
        if (menuList.Count > 0)
        {
            if (Session[SessionVariables.pub_maRole] == null)
                Session[SessionVariables.pub_maRole] = menuList[0].MaRole;
        }


        if (menuList != null && menuList.Count > 0)
        {

            int numofChar = 0;
            double widPerChar = 0;
            if (String.IsNullOrEmpty(levelName))
            {
                foreach (GetMenuByAccountInfo menuItemInfo in menuList)
                {
                    numofChar += menuItemInfo.TenMN.Trim().Length;
                }
                widPerChar = 950 / Double.Parse(numofChar + "");
            }


            string menuPath = string.Empty;
            foreach (GetMenuByAccountInfo menuItemInfo in menuList)
            {
                menuPath = "";

                if (!string.IsNullOrEmpty(menuItemInfo.Path) && menuItemInfo.Cap > 1)
                    menuPath = "UI/" + menuItemInfo.ClassName + "/" + menuItemInfo.Path;

                RadMenuItem menuItem = new RadMenuItem(menuItemInfo.TenMN.Trim(), menuPath);
                //menuItem.Attributes["Quyen"] = menuItemInfo.QUYENMN.ToString();
                //menuItem.ExpandMode = MenuItemExpandMode.WebService;
                // menuItem.Value = menuItemInfo.MaMN;
                //if (menuItemInfo.Cap > 1)
                //    menuItem.Visible = false;
                if (String.IsNullOrEmpty(levelName) && menuItemInfo.Cap == 1)
                {
                    //menuItem.Width = menuItemLevel1Width + 20;
                    menuItem.Width = new Unit((menuItemInfo.TenMN.Trim().Length * widPerChar) + 0);
                }

                if (parentMenuItem == null)
                {

                    radMenu.Items.Add(menuItem);
                }
                else
                {
                    parentMenuItem.Items.Add(menuItem);
                }
                // if (parentMenuItem != null)
                if (menuItemInfo.MaMN.Length < 9 && (menuItemInfo.Path == "" || menuItemInfo.Path == null))
                    LoadMenu(menuItem, accountName, menuItemInfo.MaMN);
            }
        }
    }
      private void LoadMenu()
    {
        string bdg = "";
        if (Session[SessionVariables.Pub_sAccount] != null)
        {
            List<EntityMenu> ListMenuCap1 = new List<EntityMenu>();
            List<EntityMenu> ListMenuCap2 = new List<EntityMenu>();
            List<EntityMenu> ListMenuCap3 = new List<EntityMenu>();

            if (Application["Menuleve1" + Session[SessionVariables.Pub_sAccount].ToString()] == null)
            {
                List<EntityMenu> List = new List<EntityMenu>();

                System.Data.Linq.ISingleResult<sp_TestMenuResult> ListMenu = null;
                HL7CoreDataDataContext db = new HL7CoreDataDataContext();

                ListMenu = db.sp_TestMenu(Session[SessionVariables.Pub_sAccount].ToString());
                Application["Menuleve1" + Session[SessionVariables.Pub_sAccount].ToString()] = null;
                Application["Menuleve2" + Session[SessionVariables.Pub_sAccount].ToString()] = null;
                Application["Menuleve3" + Session[SessionVariables.Pub_sAccount].ToString()] = null;
                foreach (var item in ListMenu)
                {
                    EntityMenu entity = new EntityMenu();
                    entity.MaMN = item.MaMN;
                    entity.TenMN = item.TenMN;
                    entity.PathNew = "Medyx/" + "UI/" + item.ClassName + "/" + item.Path;
                    entity.QuyenMN = item.QUYENMN.ToString();
                    String menuPath = "UI/" + item.ClassName.Trim();
                    if (!string.IsNullOrEmpty(item.Path))
                        menuPath = menuPath + "/" + item.Path.Trim();
                    entity.Path = menuPath;
                    entity.MaRole = item.MaRole;
                    entity.Cap = item.Cap;
                    List.Add(entity);
                }

                
                #region Lấy dữ liệu
               
                if (Application["Menuleve1" + Session[SessionVariables.Pub_sAccount].ToString()] == null)
                    foreach (var item in List)
                    {
                        RadMenuItem menuItem = new RadMenuItem(item.TenMN.Trim(), "");
                        if (item.Cap == 1)
                        {
                            EntityMenu ItemMenu = new EntityMenu();
                            ItemMenu.MaMN = item.MaMN;
                            ItemMenu.TenMN = item.TenMN;
                            ItemMenu.QuyenMN = item.QuyenMN.ToString();
                            ItemMenu.Path = item.Path;
                            ItemMenu.MaRole = item.MaRole;
                            ListMenuCap1.Add(ItemMenu);
                            
                        }
                        else if (item.Cap == 2)
                        {
                            EntityMenu ItemMenu = new EntityMenu();
                            ItemMenu.MaMN = item.MaMN;
                            ItemMenu.TenMN = item.TenMN;
                            ItemMenu.QuyenMN = item.QuyenMN.ToString();
                            ItemMenu.MaRole = item.MaRole;
                            ItemMenu.Path = item.Path;
                            ListMenuCap2.Add(ItemMenu);
                            if (ItemMenu.MaMN == "024000")
                            {
                                bdg = item.Path;
                            }
                            
                        }
                        else if (item.Cap == 3)
                        {
                            EntityMenu ItemMenu = new EntityMenu();
                            ItemMenu.MaMN = item.MaMN;
                            ItemMenu.TenMN = item.TenMN;
                            ItemMenu.QuyenMN = item.QuyenMN.ToString();
                            ItemMenu.MaRole = item.MaRole;
                            ItemMenu.Path = item.Path;
                            ListMenuCap3.Add(ItemMenu);
                        }
                    }
                #endregion
               Application["Menuleve1" + Session[SessionVariables.Pub_sAccount].ToString()]= ListMenuCap1;
               Application["Menuleve2" + Session[SessionVariables.Pub_sAccount].ToString()] = ListMenuCap2;
               Application["Menuleve3" + Session[SessionVariables.Pub_sAccount].ToString()] = ListMenuCap3;
            }
            else
            {
               
                ListMenuCap1 = (List<EntityMenu>)Application["Menuleve1" + Session[SessionVariables.Pub_sAccount].ToString()];
                ListMenuCap2 = (List<EntityMenu>)Application["Menuleve2" + Session[SessionVariables.Pub_sAccount].ToString()];
                ListMenuCap3 = (List<EntityMenu>)Application["Menuleve3" + Session[SessionVariables.Pub_sAccount].ToString()];
               
            }
            #region Gán vào Menu fix có 3 cấp
            // Giống cũ đều lấy 1 mã role duy nhất. mỗi account đều có 1 mã role duy nhất ?
            Session[SessionVariables.pub_maRole] = null;
            if (ListMenuCap1.Count > 0)
                Session[SessionVariables.pub_maRole] = ListMenuCap1[0].MaRole;
            int numofChar = 0;
            double widPerChar = 0;
            foreach (EntityMenu ItemCap1 in ListMenuCap1)
            {
                numofChar += ItemCap1.TenMN.Trim().Length;
            }
            widPerChar = 950 / Double.Parse(numofChar + "");
            int i = 0; int j = 0; bool cap2 = false; bool cap3 = false;
            foreach (EntityMenu ItemCap1 in ListMenuCap1)
            {
                RadMenuItem MenuCap1 = new RadMenuItem(ItemCap1.TenMN, ItemCap1.Path);

                //MenuCap1.Attributes["QuyenMN"] = ItemCap1.MaMN + ItemCap1.QuyenMN + Session[SessionVariables.pub_a];
                //MenuCap1.Attributes["MaRole"] = ItemCap1.MaRole;
                MenuCap1.Width = new Unit((ItemCap1.TenMN.Trim().Length * widPerChar) + 0);

                radMenu.Items.Add(MenuCap1);
                cap2 = false;
                while (cap2 == false)
                {
                    if (i >= ListMenuCap2.Count)
                        break;
                    EntityMenu ItemCap2 = ListMenuCap2[i];
                    //MenuCap2.Attributes["MaRole"] = ItemCap2.MaRole;
                    if (ItemCap1.MaMN.Equals(GetStr(ItemCap2.MaMN, 3)))
                    {
                        RadMenuItem MenuCap2 = new RadMenuItem(ItemCap2.TenMN, ItemCap2.Path);
                        MenuCap1.Items.Add(MenuCap2);
                        cap3 = false;
                        while (cap3 == false)
                        {
                            if (j >= ListMenuCap3.Count)
                                break;
                            EntityMenu ItemCap3 = ListMenuCap3[j];

                            //MenuCap3.Attributes["QuyenMN"] = ItemCap3.QuyenMN;
                            //MenuCap3.Attributes["MaRole"] = ItemCap3.MaRole;
                            if (ItemCap2.MaMN.Equals(GetStr(ItemCap3.MaMN, 6)))
                            {
                                string mamn = ItemCap3.Path;
                                if ((ItemCap3.Path.Contains("frmDSBNKhamBenh.aspx") == true||ItemCap3.Path.Contains("frmNhapChiDinhNew.aspx") == true || ItemCap3.Path.Contains("frmKhamBenh_") == true || ItemCap3.Path.Contains("frmLapPhieu.aspx") == true  || ItemCap3.Path.Contains("frmThanhToanRaVien.aspx") == true || ItemCap3.Path.Contains("frmThanhToanRaVienDS.aspx") == true))
                                        mamn = mamn + "&IDMN=" + ItemCap3.MaMN +ItemCap3 .QuyenMN ;
                                else  if (ItemCap3.Path.Contains("frmNhapChiDinhDSNew.aspx") == true )
                                    mamn = mamn + "?IDMN=" + ItemCap3.MaMN + ItemCap3.QuyenMN; 
                                RadMenuItem MenuCap3 = new RadMenuItem(ItemCap3.TenMN, mamn);

                                MenuCap2.Items.Add(MenuCap3);
                                j++;
                            }
                            else
                            {
                                cap3 = true;
                            }
                           
                        }
                        i++;
                    }
                    else
                    {
                        cap2 = true;
                    }

                   
                }

            }
            #endregion

            
        }
        if ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" ||  HTC.ShareVariables.pub_spC == "YH") && bdg != "")
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
                    }
                }

            }

        }
    }
  
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        /*
        string crit = txtSearch.Text.Trim();
        int selectedIndex = cboSearch.SelectedIndex;

        switch (selectedIndex)
        {
            case 0: 
                ///     Film                
                break;
            case 1:
                ///     Actor
                break;
            case 2:
                ///     Director
                break;
            case 3:
                ///     Writer
                break;           <asp:ContentPlaceHolder ID="ContentPlaceHolder2" runat="server">
                                </asp:ContentPlaceHolder> 		                         		                         		                        
                            </td>
        }

        Session["index"] = selectedIndex;
        Session["adminCrit"] = crit;

        Response.Redirect("SearchList.aspx");
         */
    }

    protected void radMenu_ItemClick(object sender, RadMenuEventArgs e)
    {
        //Custom code here       
        //Session[SessionVariables.CurrentMenuItem] = e.Item.Text;                     

        //Navigate   
        // Lê Lợi bỏ
        RadMenuItem menuItem = (RadMenuItem)e.Item;

        String Path = menuItem.NavigateUrl;
        if (menuItem.NavigateUrl.ToString().Contains(".aspx") == true)
        {
            if ((Path.Contains("frmDSBNKhamBenh.aspx") == true || Path.Contains("frmKhamBenh_") == true || Path.Contains("frmLapPhieu.aspx") == true || Path.Contains("frmNhapChiDinhNew.aspx") == true || Path.Contains("frmNhapChiDinhDSNew.aspx") == true || Path.Contains("frmThanhToanRaVien.aspx") == true || Path.Contains("frmThanhToanRaVienDS.aspx") == true))
                Response.Redirect(Path + "&IDMN=" + menuItem.Attributes["IDMN"].ToString());
            else
                Response.Redirect(Path);
        }
        // radMenu.ClickToOpen = false;
        //if (menuItem.Items.Count == 0 && menuItem.NavigateUrl == "")
        //{
        //    LoadMenu();
        //    //LoadMenu(menuItem, Session[SessionVariables.Pub_sAccount].ToString(), menuItem.Value);

        //}
        // Lê Lợi bỏ
        //else if (menuItem.NavigateUrl.ToString().Contains(".aspx") == true)
        //    Response.Redirect("~/" + menuItem.NavigateUrl);  
    }

    protected void radMenu_ItemCreated(object sender, RadMenuEventArgs e)
    {
        //e.Item.Attributes["NavigateUrl"] = e.Item.NavigateUrl;
        //e.Item.NavigateUrl = "";                             

        //e.Item.Attributes["ádfasdfasdf"]
    }


}

