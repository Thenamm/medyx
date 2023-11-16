using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using HTC.Business.NoiTru;
using HTC.Business.PhongKham;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using HTC.Common.Web;
using Telerik.Web.UI;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq.Dynamic;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Net.Http;
using Microsoft.ApplicationBlocks.Data;
public partial class UI_NoiTru_KhamBenh_frmRaVienNoiTru : WebBase
{
    private const string ViewState_CurrentTab = "CurrentTab";
    public int CurrentTabIndex
    {
        get
        {
            if (ViewState[ViewState_CurrentTab] == null)
            {
                ViewState[ViewState_CurrentTab] = 0;
                return (int)ViewState[ViewState_CurrentTab];
            }
            else
                return (int)ViewState[ViewState_CurrentTab];
        }
        set
        {
            ViewState[ViewState_CurrentTab] = value;
        }
    }
    private const string ViewState_BenhAn_Khoa = "BenhAn_Khoa";
    private const string ViewState_BenhAnPK = "BenhAnPK";
    private const string ViewState_loaikq = "_loaikq";
    private const string ViewState_MaBA = "MaBA";
    private const string ViewState_STTKhoa = "STTKhoa";
    private const string ViewState_STT = "STT";
    public string _MaBA
    {
        get
        {
            if (ViewState[ViewState_MaBA] != null)
                return ViewState[ViewState_MaBA].ToString();
            return null;
        }
        set
        {
            ViewState[ViewState_MaBA] = value;
        }
    }
    public string _loaikq
    {
        get
        {
            if (ViewState[ViewState_loaikq] == null)
            {
                if (!string.IsNullOrEmpty(Request["loaikq"]))
                {
                    ViewState[ViewState_loaikq] = Request["loaikq"].ToString();
                }
                else
                    Response.Redirect("~/Default.aspx");
            }
            return (string)ViewState[ViewState_loaikq];
        }
        set
        {
            ViewState[ViewState_loaikq] = value;
        }
    }
    private const string ViewState_print = "_print";
    public Boolean _print
    {
        get
        {
            if (ViewState[ViewState_print] == null)
                ViewState[ViewState_print] = false;
            return (Boolean)ViewState[ViewState_print];
        }
        set
        {
            ViewState[ViewState_print] = value;
        }
    }
    public BenhAn_Khoa _BenhAn_Khoa
    {
        get
        {
            if (ViewState[ViewState_BenhAn_Khoa] == null)
            {
                return null;
            }
            return (BenhAn_Khoa)ViewState[ViewState_BenhAn_Khoa];
        }
        set
        {
            ViewState[ViewState_BenhAn_Khoa] = value;
        }
    }
    public BenhAnPK _BenhAnPK
    {
        get
        {
            if (ViewState[ViewState_BenhAnPK] == null)
            {
                return null;
            }
            return (BenhAnPK)ViewState[ViewState_BenhAnPK];
        }
        set
        {
            ViewState[ViewState_BenhAnPK] = value;
        }
    }
    public byte _STTKhoa
    {
        get
        {
            if (ViewState[ViewState_STTKhoa] != null)
                return Byte.Parse(ViewState[ViewState_STTKhoa].ToString());
            return byte.MinValue;
        }
        set
        {
            ViewState[ViewState_STTKhoa] = value;
        }
    }
    public int _STT
    {
        get
        {
            if (ViewState[ViewState_STT] != null)
                return Int32.Parse(ViewState[ViewState_STT].ToString());
            return Int32.MinValue;
        }
        set
        {
            ViewState[ViewState_STT] = value;
        }
    }
    protected void RadTabStrip1_TabClick(object sender, RadTabStripEventArgs e)
    {
        CurrentTabIndex = RadTabStrip1.SelectedIndex;
        RadMultiPage1.SelectedIndex = CurrentTabIndex;
        LoadDetails(CurrentTabIndex);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (String.IsNullOrEmpty(Request["maBA"]) || String.IsNullOrEmpty(Request["STTKhoa"]))
            {
                // Response.Redirect("~/UI/NoiTru/KhamBenh/frmRaVienNoiTruDS.aspx");
                CloseWindow();
            }
            else
            {
                _MaBA = Request["maBA"];
                _STTKhoa = Byte.Parse(Request["STTKhoa"]);
                CurrentTabIndex = 0;
                SetData();
                LoadData();
                if (_loaikq != "0" && pub_bQadmin == false && HTC.ShareVariables.pub_spC != "PH")
                {
                    BenhAn _benhan = BenhAn.GetBenhAn(_MaBA, "");
                    if (_benhan.RaVien == true && HTC.ShareVariables.pub_spC != "QN")
                        CloseWindow();
                }
                if ((_BenhAn_Khoa.RaKhoa == 3))
                {
                    // Khong Duoc Edit???
                    //Response.Redirect("~/UI/NoiTru/KhamBenh/frmRaVienNoiTruDS.aspx");
                    CloseWindow();
                }
            }
        }
    }
    private void SetData()
    {
        //  Bind the data
        if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fThem)
            baraction.FindItemByValue("cmdSave").Enabled = false;
        if (_loaikq != "0" && pub_bQadmin == false)
            baraction.FindItemByValue("cmdSave").Enabled = false;
        //if (HTC.ShareVariables.pub_spC == "HH" || HTC.ShareVariables.pub_spC == "QN")
        //{
        //    baraction.FindItemByValue("cmdThongTinBA").Enabled = false;
        //}
        if (cboKQDT.Items.Count == 0)
        {
            if (HTC.ShareVariables.pub_spC == "PS")
            {
                cboBacSy.DataSourceID = "ObjectDanhMucNVDu";
                cboBacSy.DataBind();
            }
            cboKQDT.DataSourceID = "odsKQDT";
            cboKQDT.DataBind();
            cboHTravien.DataSourceID = "odsHTravien";
            cboHTravien.DataBind();
            cboGPbenh.DataSourceID = "odsGPbenh";
            cboGPbenh.DataBind();
            cboLoaiBA.DataSourceID = "odsLoaiBA";
            cboLoaiBA.DataBind();
        }
        if (HTC.ShareVariables.pub_spC == "PH")
        {
            txtBenhRa.ReadOnly = true;
            txtBenhKem.ReadOnly = true;
        }
    }
    private void LoadData()
    {
        if (!string.IsNullOrEmpty(_MaBA))
        {
            if (!(_IsBVYHocCoTruyen || HTC.ShareVariables.pub_spC == "QN"))
            {
                lblChanDoanYHCT.Text = "CĐ kèm 2(Nhập liên tiếp)";
                cboChanDoanTheoYHCT.DataSourceID = "ObjectDanhMucBenh";
                if (HTC.ShareVariables.pub_spC != "PH")
                {
                    GhichuChanDoan.Visible = false;
                }
            }
            _BenhAn_Khoa = BenhAn_Khoa.GetBenhAn_KhoaTT(_MaBA, _STTKhoa);
            _BenhAnPK = BenhAnPK.GetBenhAnPK(_MaBA);
            if (_BenhAn_Khoa != null)
            {
                txtMaQL.Text = _BenhAn_Khoa.MaBAQL;
                dtNgaySinh.Text = _BenhAn_Khoa.NgaySinh;
                dtNgayVaoKhoa.Text = _BenhAn_Khoa.NgayVVTT;
                txtHoTen.Text = _BenhAn_Khoa.Hoten;
                txtTenKhoa.Text = _BenhAn_Khoa.TenKhoa;
                if (HTC.ShareVariables.pub_spC == "PH")
                    txtGhiChuBenh.Text = _BenhAn_Khoa.Ghichu;
                lblGioiTinh.Text = _BenhAn_Khoa.GT ? "Nam" : "Nữ";
                txtTenDoiTuong.Text = _BenhAn_Khoa.TenDT;
                if (_BenhAn_Khoa.RaKhoa > 0 && pub_bQadmin == false)
                    baraction.FindItemByValue("cmdSave").Enabled = false;
                DataTable dt = spThongTinBN_GetGiayNghiBHXH(_MaBA, _BenhAn_Khoa.MaBN);
                if (dt.Rows.Count > 0)
                {
                    //dttungay_bhxh.Text = dt.Rows[0]["tungay_bhxh"].ToString() == "" ? _BenhAn_Khoa.NgayVVTT : "";
                    //dtdenngay_bhxh.Text = dt.Rows[0]["denngay_bhxh"].ToString() == "" ? _BenhAnPK.NgayRaVien == "" ? DateTime.Now.ToString("dd/MM/yyyy HH:mm") : _BenhAnPK.NgayRaVien : "";
                    dttungay_bhxh.Text = dt.Rows[0]["tungay_bhxh"].ToString();
                    dtdenngay_bhxh.Text = dt.Rows[0]["denngay_bhxh"].ToString();
                    dtngaycap_bhxh.Text = dt.Rows[0]["ngaycap_bhxh"].ToString();
                    dtNGAY_CHUNG_TU_RaVien.Text = dt.Rows[0]["NGAY_CHUNG_TU_RaVien"].ToString();
                    txthotencha.Text = dt.Rows[0]["hotenbo"].ToString();
                    txthotenme.Text = dt.Rows[0]["hotenme"].ToString();
                    txtnguoigiamho.Text = dt.Rows[0]["nguoigiamho"].ToString();
                    dtNGAYCAP_CMND.Text = dt.Rows[0]["NGAYCAP_CMND"].ToString();
                    txtNoiCapCMND.Text = dt.Rows[0]["NOICAP_CMND"].ToString();
                    txtSoCMND.Text = dt.Rows[0]["SoCMT"].ToString();
                    cboTruongKhoa.SelectedValue = dt.Rows[0]["MaTruongKhoa"].ToString();
                    cboTruongKhoa.Text = dt.Rows[0]["TenTruongKhoa"].ToString();
                    txtNoiLV.Text = dt.Rows[0]["NoiLamViec"].ToString();
                    txtMaSoBHXH.Text = dt.Rows[0]["Ma_BHXH"].ToString();
                    txtSoSeri.Text = dt.Rows[0]["SoSeri"].ToString();
                }
            }
            string sql = "select isnull(VET_THUONG_TP,0) as VET_THUONG_TP from BenhAnPK where mabanoitru ='" + _MaBA + "'" ;
            string VET_THUONG_TP = "";
            VET_THUONG_TP = ExcSQLString(sql);
            if (VET_THUONG_TP.Length > 0 && VET_THUONG_TP == "1")
                chkVET_THUONG_TP.Checked = true;
            else
                chkVET_THUONG_TP.Checked = false;
            LoadDetails(4);
            if (HTC.ShareVariables.pub_spC == "PH")
                txtBenhRa.ReadOnly = true;
        }
    }
    private void LoadDetails(int tabindex)
    {
        switch (tabindex)
        {
            case 4:
                {
                    {
                        dtngayravien.Text = _BenhAnPK.NgayRaVien;
                        if (_BenhAnPK.NgayRaVien != "")
                        {
                            BenhAn _BenhAn = BenhAn.GetBenhAn(_MaBA, "");
                            chkchuyenBA.Checked = _BenhAn.daks;
                            if (_BenhAn.mabsravien != "")
                            {
                                RadComboBoxItem selectedItem = new RadComboBoxItem();
                                selectedItem.Text = _BenhAn.tenbsravien;
                                selectedItem.Value = _BenhAn.mabsravien;
                                cboBacSy.Items.Add(selectedItem);
                                selectedItem.Selected = true;
                                selectedItem.DataBind();
                                cboBacSy.DataBind();
                            }
                            txtmaluutru.Text = _BenhAn.MaBALuu;
                        }
                        if (dtngayravien.Text == "")
                            dtngayravien.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                        cboHTravien.SelectedValue = _BenhAnPK.MaHTRa;
                        cboKQDT.SelectedValue = _BenhAnPK.MaKQDT;
                        cboLoaiBA.SelectedValue = _BenhAnPK.MaLoaiBA;
                        cboGPbenh.SelectedValue = _BenhAnPK.MaGPBenh;
                        cboChanDoanTheoYHCT.SelectedValue = _BenhAnPK.MaBenhRaVienYHCT;
                        txtGhiChu.Text = _BenhAnPK.Ghichu;
                        // txtBenhKem.Text = _BenhAnPK.tenbenhKem;
                        cboChanDoanTheoYHCT.Text = _BenhAnPK.MaICDravienYHCT;
                        txtChanDoanTheoYHCT.Text = _BenhAnPK.TenBenhRaVienKKBYHCT;
                        if (_BenhAnPK.MaBenhRaVienYHCT != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            selectedItemc.Text = _BenhAnPK.MaICDravienYHCT;
                            selectedItemc.Value = _BenhAnPK.MaBenhRaVienYHCT;
                            cboChanDoanTheoYHCT.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cboChanDoanTheoYHCT.DataBind();
                        }
                        if (_BenhAnPK.MaBenhKKB != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            selectedItemc.Text = _BenhAnPK.maicdKKB;
                            selectedItemc.Value = _BenhAnPK.MaBenhKKB;
                            cboCDVaoVien.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cboCDVaoVien.DataBind();
                        }
                        txtBenhVao.Text = _BenhAnPK.TenBenhKKB;
                        if (_BenhAnPK.MaBenhRavien != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            if (_BenhAnPK.MaICDRaVien == "")
                                selectedItemc.Text = _BenhAnPK.MaBenhRavien;
                            else
                                selectedItemc.Text = _BenhAnPK.MaICDRaVien;
                            selectedItemc.Value = _BenhAnPK.MaBenhRavien;
                            cbocdravien.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cbocdravien.DataBind();
                        }
                        txtBenhRa.Text = _BenhAnPK.TenBenhRaVien;
                        if (_BenhAnPK.MabenhKem != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            selectedItemc.Text = _BenhAnPK.maicdKem;
                            selectedItemc.Value = _BenhAnPK.MabenhKem;
                            cboCDKem.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cboCDKem.DataBind();
                        }
                        txtBenhKem.Text = _BenhAnPK.tenbenhKem;
                        if (_BenhAnPK.MaGPBenh != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            selectedItemc.Text = _BenhAnPK.MaGPBenh;
                            selectedItemc.Value = _BenhAnPK.MaBenhKKB;
                            cboCDVaoVien.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cboCDVaoVien.DataBind();
                        }
                        txtBenhVao.Text = _BenhAnPK.TenBenhKKB;
                    }
                    {
                        txtLoiDan.Text = _BenhAnPK.LoiDan;
                        txtNguoiVanChuyen.Text = _BenhAnPK.GDVV;
                        txtPhuongtienVC.Text = _BenhAnPK.GDRV;
                        txtPhuongPhapDT.Text = _BenhAnPK.DieuTri;
                        cboHuongDT.SelectedValue = _BenhAnPK.MaHDT;
                        txtBenhLy.Text = _BenhAnPK.benhly;
                        txtKetQuaCLS.Text = _BenhAnPK.ketquacls;
                        txtTinhTrang.Text = _BenhAnPK.tinhtrangbn;
                        txtGhiChu.Text = _BenhAnPK.Ghichu;
                        if (_BenhAnPK.MRV == "" && HTC.ShareVariables.pub_spC == "PH")
                        {
                            dtNgayVV.Text = DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");
                        }
                        else if (HTC.ShareVariables.pub_spC == "PH")
                            dtNgayVV.Text = _BenhAnPK.MRV;
                        else
                            dtNgayVV.Text = _BenhAnPK.NgayGioCV;
                        if (_BenhAnPK.MaHDT == "00020")
                            dtNgayVV.Visible = true;
                        if (_BenhAnPK.MaNoiChuyen != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            selectedItemc.Text = _BenhAnPK.MABHXHChuyen;
                            selectedItemc.Value = _BenhAnPK.MaNoiChuyen;
                            cboNoiDK.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cboNoiDK.DataBind();
                            cboNoiDK.Visible = true;
                            txtTenBV.Visible = true;
                        }
                        txtTenBV.Text = _BenhAnPK.TenBVChuyen;
                    }
                    {
                        dtNgayTV.Text = _BenhAnPK.NgayTVong;
                        cboLyDoTV.SelectedValue = _BenhAnPK.MaLDTVong;
                        cboThoiGianTV.SelectedValue = _BenhAnPK.MaTGTVong;
                        chkknTuthi.Checked = _BenhAnPK.KNTuThi;
                        if (_BenhAnPK.MaGPTuThi != "")
                        {
                            RadComboBoxItem selectedItemc = new RadComboBoxItem();
                            selectedItemc.Text = _BenhAnPK.MaICDGP;
                            selectedItemc.Value = _BenhAnPK.MaGPTuThi;
                            cboCDGiaiPhau.Items.Add(selectedItemc);
                            selectedItemc.Selected = true;
                            selectedItemc.DataBind();
                            cboCDGiaiPhau.DataBind();
                        }
                        txtBenhGP.Text = _BenhAnPK.TenBenhGP;
                        txtNguyennhanTV.Text = _BenhAnPK.NNTVong;
                    }
                    break;
                }
        }
    }
    private void UploadFile(int Loai)
    {
        //try
        //{
        if (fuFileUploader.PostedFile != null && fuFileUploader.PostedFile.ContentLength > 4)
        {
            string fileName = Path.GetFileName(fuFileUploader.PostedFile.FileName);
            string fileExtension = Path.GetExtension(fuFileUploader.PostedFile.FileName);
            //first check if "uploads" folder exist or not, if not create it
            string fileSavePath;//= Server.MapPath("tem");
            //if (!Directory.Exists(fileSavePath))
            //    Directory.CreateDirectory(fileSavePath);
            //    fileSavePath = Server.MapPath("~\\tem\\" + DateTime.Now.Year.ToString("####") + DateTime.Now.Month.ToString());
            // fileSavePath = Server.MapPath("c:\\tem\\" + DateTime.Now.Year.ToString("####") + DateTime.Now.Month.ToString());
            fileSavePath = ThamSo.GetThamSo().thumucluuanh + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\NT";
            //if (!Directory.Exists(fileSavePath))
            //    Directory.CreateDirectory(fileSavePath);
            if (!Directory.Exists(fileSavePath))
                Directory.CreateDirectory(fileSavePath);
            //after checking or creating folder it's time to save the file
            //fileSavePath = fileSavePath + "//" + fileName;
            fileSavePath = fileSavePath + "\\" + _MaBA + fileName;
            fuFileUploader.PostedFile.SaveAs(fileSavePath);
            // ShowMessage(fileSavePath);
            HTC.Business.NoiTru.BenhAn_File file = HTC.Business.NoiTru.BenhAn_File.NewBenhAn_File();
            // file.DangFile = fileName.LastIndexOf(".doc")>0 ?"word":(fileName.LastIndexOf(".xls")>0?"excel"));
            file.DuongDan = fileName;
            file.DuongDanDD = fileSavePath;
            file.MaBA = _MaBA;
            file.LoaiPhieuKem = Loai;
            file.MaBN = _BenhAn_Khoa.MaBN;
            file.MaMay = Pub_sMaMay;
            file.NguoiLap = Pub_sNguoiSD;
            file.ApplyEdit();
            file.Save();
        }
        // }
        //catch (Exception ex)
        //{
        //    ShowMessage ("Không upload file được");
        //}
    }
    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        try
        {
            if (((RadToolBarButton)e.Item).CommandName.Equals("cmdSave", StringComparison.InvariantCultureIgnoreCase))
            {
                if (UpdateData(2) == true)
                {
                    // Response.Redirect("~/UI/NoiTru/KhamBenh/frmRaVienNoiTruDS.aspx?makhoa=" + _BenhAn_Khoa.MaKhoa,false);
                    #region đẩy 4210 sang Viettel
                    try
                    {
                        string portPID = "";
                        string usernamePID = "";
                        string passwordPID = "";
                        string loaitoken = "HS4210TokenUpdate";
                        DataTable dt = GetPort(loaitoken);
                        if (dt.Rows.Count > 0)
                        {
                            portPID = dt.Rows[0][0].ToString();
                            usernamePID = dt.Rows[0][1].ToString();
                            passwordPID = dt.Rows[0][2].ToString();
                        }
                        string tokenUpdate = "";
                        loaitoken = "HS4210Update";
                        dt = GetPort(loaitoken);
                        string portUpdate = "";
                        string usernameUpdate = "";
                        string passwordUpdate = "";
                        if (dt.Rows.Count > 0)
                        {
                            portUpdate = dt.Rows[0][0].ToString();
                            usernameUpdate = dt.Rows[0][1].ToString();
                            passwordUpdate = dt.Rows[0][2].ToString();
                        }
                        //WriteLog("lay tokenUpdate");
                        tokenUpdate = GetTokenUpdate(portPID, usernamePID, passwordPID);
                        //WriteLog("tokenUpdate: " + tokenUpdate);
                        UpdateHS4210(portUpdate, tokenUpdate);
                    }
                    catch (Exception ex)
                    {
                        WriteLog("Loi day 4210: " + ex.ToString());
                    }
                    #endregion
                    CloseWindow();
                }
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdExit", StringComparison.InvariantCultureIgnoreCase))
            {
                // Response.Redirect("~/UI/NoiTru/KhamBenh/frmRaVienNoiTruDS.aspx?makhoa=" + _BenhAn_Khoa.MaKhoa, false);
                CloseWindow();
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("exitcmdPrint", StringComparison.InvariantCultureIgnoreCase))
            {
                //HTCReportViewer1.UnLoadReport();
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdUpLoad", StringComparison.InvariantCultureIgnoreCase))
            {
                if (fuFileUploader.Visible == true)
                {
                    UploadFile(1);
                    fuFileUploader.Visible = false;
                }
                else
                    fuFileUploader.Visible = true;
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdUpLoadHinhAnh", StringComparison.InvariantCultureIgnoreCase))
            {
                if (fuFileUploader.Visible == true)
                {
                    UploadFile(2);
                    fuFileUploader.Visible = false;
                }
                else
                    fuFileUploader.Visible = true;
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdXemFile", StringComparison.InvariantCultureIgnoreCase))
            {
                Context.Response.Write("<script> language='javascript'>window.open('frmKhamBenh_File.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN + "','_newtab');</script>");
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdThongTinBA", StringComparison.InvariantCultureIgnoreCase))
            {
                string page = "";
                if (_BenhAn_Khoa.MaLoaiBA == "00031")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnYHCTNoiTru.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00045")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnUngBuou.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00048")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnTruyenNhiem.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00043")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnThanKinh.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00027")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnSoSinh.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00026")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnSan.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00014")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnPhuKhoa.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00029")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnNhiKhoa.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00041")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnMau.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00005")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnMat.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00047")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnLao.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00044")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnDaLieu.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else if (_BenhAn_Khoa.MaLoaiBA == "00042")
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnBong.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                else
                    page = "~/UI/Administration/HL7Core/frmHoSoBenhAnnoikhoa.aspx?MaBA=" + _MaBA + "&MaBN=" + _BenhAn_Khoa.MaBN;
                Response.Write(String.Format("<script type='text/javascript'> window.open('{0}','_blank') </script>", ResolveUrl(page)));
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdTomTatBA", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dtngayravien.Text != "")
                    PrintdataTT();
            }
            else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdPrint", StringComparison.InvariantCultureIgnoreCase))
            {

                if (UpdateData(1))
                {
                    if (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "YH")
                    {
                        baraction.FindItemByValue("cmdSave").Visible = false;
                        baraction.FindItemByValue("cmdPrint").Visible = false;
                    }
                    if (dtngayravien.Text != "")
                        Printdata();
                    //  CloseWindow();
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("Không lưu được dữ liệu" + ex.Message);
        }
    }
    protected bool CheckData()
    {
        if (HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ - CƠ SỞ 2")
        {
            if (_BenhAn_Khoa.MaLoaiBA == "00031")
            {
                if (BenhAn_NoiList.GetAllBenhAn_Noi(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00004")
            {
                if (BenhAn_TMHList.GetAllBenhAn_TMH(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00006")
            {
                if (BenhAn_RHMList.GetAllBenhAn_RHM(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00046")
            {
                if (BenhAn_PHCNList.GetAllBenhAn_PHCN(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00007")
            {
                if (BenhAn_VLTLList.GetAllBenhAn_VLTL(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00002")
            {
                if (BenhAn_NgoaiKhoaList.GetAllBenhAn_NgoaiKhoa(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00045")
            {
                if (BenhAn_UBList.GetAllBenhAn_UB(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00048")
            {
                if (BenhAn_TruyenNhiemList.GetAllBenhAn_TruyenNhiem(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00043")
            {
                if (BenhAn_TamThanList.GetAllBenhAn_TamThan(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00027")
            {
                if (BenhAn_SoSinhList.GetAllBenhAn_SoSinh(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00026")
            {
                if (BenhAn_San_DeList.GetAllBenhAn_San_De(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00006")
            {
                if (BenhAn_PhuList.GetAllBenhAn_Phu(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00014")
            {
                if (BenhAn_PhuList.GetAllBenhAn_Phu(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00041")
            {
                if (BenhAn_BenhMauList.GetAllBenhAn_BenhMau(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00005")
            {
                if (BenhAn_MatList.GetAllBenhAn_Mat(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00028")
            {
                if (BenhAn_NhiKhoaList.GetAllBenhAn_NhiKhoa(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00047")
            {
                if (BenhAn_LaoList.GetAllBenhAn_Lao(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00044")
            {
                if (BenhAn_DaLieuList.GetAllBenhAn_DaLieu(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else if (_BenhAn_Khoa.MaLoaiBA == "00042")
            {
                if (BenhAn_BongList.GetAllBenhAn_Bong(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
            else
            {
                if (BenhAn_NoiList.GetAllBenhAn_Noi(_MaBA, 0).Count == 0)
                {
                    ShowMessage("Chưa khám bệnh vào viện!Yêu cầu khám bệnh");
                    return false;
                }
            }
        }
        if (HTC.ShareVariables.pub_spC == "PH" && cbocdravien.SelectedValue != "")
        {
            DMBenhTat bt = DMBenhTat.GetDMBenhTat(cbocdravien.SelectedValue);
            if (bt != null)
                txtBenhRa.Text = bt.TenBenh;
        }
        else if (HTC.ShareVariables.pub_spC == "PH")
        {
            txtBenhRa.Text = "";
        }
        if (HTC.ShareVariables.pub_spC == "PH" && cboCDKem.SelectedValue != "")
        {
            DMBenhTat bt = DMBenhTat.GetDMBenhTat(cboCDKem.SelectedValue);
            if (bt != null)
                txtBenhKem.Text = bt.TenBenh;
        }
        else if (HTC.ShareVariables.pub_spC == "PH")
        {
            txtBenhKem.Text = "";
        }
        //if (HTC.ShareVariables.pub_spC == "PH" && cboChanDoanTheoYHCT.SelectedValue != "")
        //{
        //    DMBenhTat bt = DMBenhTat.GetDMBenhTat(cboChanDoanTheoYHCT.SelectedValue);
        //    if (bt != null)
        //        txtChanDoanTheoYHCT.Text = bt.TenBenh;
        //}
        //else if (HTC.ShareVariables.pub_spC == "PH")
        //{
        //    txtChanDoanTheoYHCT.Text = "";
        //}
        if (txtBenhRa.Text == "" || cbocdravien.SelectedValue == "")
        {
            ShowMessage("Chưa nhập bệnh ra viện");
            return false;
        }
        if (cboHTravien.SelectedValue == "")
        {
            ShowMessage("Chưa nhập hình thức ra viện");
            return false;
        }
        if (cboKQDT.SelectedValue == "")
        {
            ShowMessage("Chưa nhập kết quả ra viện");
            return false;
        }
        if (HTC.ShareVariables.pub_spC == "HU")
        {
            if (_BenhAn_Khoa.maloaibn == "3" && HTC.ShareVariables.pub_sTenBV != "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")
            {
                ShowMessage("Bệnh nhân bảo lãnh không được ra viện");
                return false;
            }
        }
        if (HTC.ShareVariables.pub_spC == "PS")
        {
            if (txtGhiChu.Text == "")
            {
                ShowMessage("Chưa nhập ghi chú");
                return false;
            }
            if (txtPhuongPhapDT.Text == "")
            {
                ShowMessage("Chưa nhập phương pháp điều trị");
                return false;
            }
        }
        //if (HTC.ShareVariables.pub_spC == "PS")
        //{
        //    if (txtBenhRa.Text == "")
        //    {
        //        ShowMessage("Chưa nhập bệnh ra viện");
        //        return false;
        //    }
        //}
        //else
        //{
        //    if (txtBenhRa.Text == "" || cbocdravien.SelectedValue == "")
        //    {
        //        ShowMessage("Chưa nhập bệnh ra viện");
        //        return false;
        //    }
        //}
        DateTime d, tn, dn;
        if (dtngaycap_bhxh.Text.Trim().Length > 0)
        {
            if (dtdenngay_bhxh.Text.Trim().Length == 0)
            {
                ShowMessage("Chưa chọn ngày kết thúc nghỉ việc hưởng BHXH!");
                dtdenngay_bhxh.Focus();
                return false;
            }
            else if (!DateTime.TryParseExact(dtdenngay_bhxh.Text.Trim(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dn))
            {
                ShowMessage("Chọn ngày kết thúc nghỉ việc hưởng BHXH không hợp lệ!");
                dtdenngay_bhxh.Text = "";
                dtdenngay_bhxh.Focus();
                return false;
            }
            else if (dttungay_bhxh.Text.Trim().Length == 0)
            {
                ShowMessage("Chưa chọn ngày bắt đầu nghỉ việc hưởng BHXH!");
                dttungay_bhxh.Focus();
                return false;
            }
            else if (!DateTime.TryParse(dttungay_bhxh.Text.Trim(), out tn))
            {
                ShowMessage("Chọn ngày bắt đầu nghỉ việc hưởng BHXH không hợp lệ!");
                dttungay_bhxh.Text = "";
                dttungay_bhxh.Focus();
                return false;
            }
            else if (dtngaycap_bhxh.Text.Trim().Length == 0)
            {
                ShowMessage("Chưa chọn ngày cấp giấy nghỉ việc hưởng BHXH!");
                dtngaycap_bhxh.Focus();
                return false;
            }
            else if (!DateTime.TryParse(dtngaycap_bhxh.Text.Trim(), out d))
            {
                ShowMessage("Chọn ngày cấp giấy nghỉ việc hưởng BHXH không hợp lệ!");
                dtngaycap_bhxh.Text = "";
                dtngaycap_bhxh.Focus();
                return false;
            }
            else if (tn > dn)
            {
                ShowMessage("Ngày bắt đầu nghỉ việc hưởng BHXH > ngày kết thúc!");
                dttungay_bhxh.Focus();
                return false;
            }
            else if (dtNGAY_CHUNG_TU_RaVien.Text.Trim().Length == 0)
            {
                ShowMessage("Chưa chọn ngày ra viện nghỉ việc hưởng BHXH!");
                dtNGAY_CHUNG_TU_RaVien.Focus();
                return false;
            }
        }
        return true;
    }
    protected Boolean UpdateData(int loai)
    {
        try
        {
            if (baraction.FindItemByValue("cmdSave").Enabled == false || baraction.FindItemByValue("cmdSave").Visible == false)
                return true;
            if (CheckData() == false)
                return false;
            if ((loai == 2 || (((HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ ") || HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH"))) && _loaikq == "0")
            {
                if (dtngayravien.Text == "")
                {
                    ShowMessage("Chưa nhập ngày ra viện");
                    return false;
                }
                try
                {
                    if (txtmaluutru.Text != "" && HTC.ShareVariables.pub_spC == "PH")
                    {
                        if (int.Parse(txtmaluutru.Text) == 0)
                        {
                            ShowMessage("Chưa nhập mã lưu trữ");
                            return false;
                        }
                        BenhAn ba = BenhAn.GetBenhAn(txtmaluutru.Text, "");
                        if (ba.MaBA != _BenhAn_Khoa.MaBA && ba.MaBA != "")
                        {
                            ShowMessage("Mã bệnh án luư trữ này đã tồn tại ");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage("Bệnh án lưu trữ không phải dạng số");
                }
                if (cboHTravien.Text == "")
                {
                    ShowMessage("Chưa nhập hình thức ra viện");
                    return false;
                }
                if (cboKQDT.Text == "")
                {
                    ShowMessage("Chưa nhập kết quả ra viện");
                    return false;
                }
                if (dtngayravien.Text != "")
                {
                    if (ConvertStringToDateTime(dtngayravien.Text) == null)
                    {
                        ShowMessage("Chưa nhập ngày ra viện");
                        return false;
                    }
                    if ((DateTime.Parse(dtngayravien.Text) - DateTime.Parse(_BenhAn_Khoa.NgayVVTT)).Minutes < 0)
                    {
                        ShowMessage("Ngày ra viện nhỏ hơn ngày vào viện");
                        return false;
                    }
                    if ((DateTime.Parse(dtngayravien.Text) - DateTime.Parse(_BenhAn_Khoa.NgayVKhoa)).Days < 0)
                    {
                        ShowMessage("Ngày ra viện nhỏ hơn ngày vào khoa ");
                        return false;
                    }
                }
                //   ShowMessage(dtNgayVV.Text +"-" + cboHTravien.SelectedValue + "/" + cboNoiDK.SelectedValue + "-" + cboHTravien.SelectedValue + "/" + dtNgayTV.Text);
                if (cboHTravien.SelectedValue == "00005" && cboNoiDK.SelectedValue == "")
                {
                    ShowMessage("Chưa nhập bệnh viện chuyển đi");
                    return false;
                }
                if (cboHTravien.SelectedValue == "00006")
                {
                    if (dtNgayTV.Text == "")
                    {
                        ShowMessage("Chưa nhập ngày tử vong");
                        return false;
                    }
                    if (cboThoiGianTV.Text == "")
                    {
                        ShowMessage("Chưa nhập thời gian tử vong");
                        return false;
                    }
                    if (cboLyDoTV.Text == "")
                    {
                        ShowMessage("Chưa nhập lý do tử vong");
                        return false;
                    }
                    if (txtNguyennhanTV.Text == "")
                    {
                        ShowMessage("Chưa nhập nguyên nhân tử vong");
                        return false;
                    }
                }
                if (HTC.ShareVariables.pub_spC == "PH")
                {
                    if (!(cboKQDT.SelectedValue == "00005" || cboKQDT.SelectedValue == "00004") && dtNgayVV.Text == "")
                    {
                        ShowMessage("Chưa nhập ngày hẹn hoặc ngày chuyển viện  ");
                        return false;
                    }
                }
            }
            if (_loaikq == "7")
            {
                DMThuocList dmthuoc = DMThuocList.GetAllDMThuoc();
                BenhAn_ThuocSDList _BenhAn_ThuocSDList = BenhAn_ThuocSDList.GetAllBenhAn_ThuocSD(_BenhAn_Khoa.MaBA, false);
                if (_BenhAn_ThuocSDList.Count > 0)
                {
                    if (cboBacSy.SelectedValue != "")
                    {
                        try
                        {
                            //thuoc gay nghien
                            String mapl = "00002";
                            //bool contains = ReportData6.Tables[0].AsEnumerable().Any(row => mapl == row.Field<String>("mapl"));
                            var tblgaynghien = (from order in _BenhAn_ThuocSDList
                                                join plan in dmthuoc
                                                     on order.Mathuoc equals plan.MaThuoc
                                                where plan.MaPL == mapl
                                                select order);
                            //var tblgaynghien = query.AsEnumerable()
                            // .Where(r => r.plan.MaPL == mapl)
                            // .CopyToDataTable();
                            if (tblgaynghien != null && tblgaynghien.Any())
                            {
                                GuiDonThuoc(tblgaynghien, "n", cboBacSy.SelectedValue);
                            }
                            //thuoc huong than
                            mapl = "00003";
                            //DataTable tblhuongthan = ReportData5.Tables[0].AsEnumerable()
                            // .Where(r => r.Field<string>("mapl") == mapl)
                            // .CopyToDataTable();
                            var tblhuongthan = (from order in _BenhAn_ThuocSDList
                                                join plan in dmthuoc
                                                     on order.Mathuoc equals plan.MaThuoc
                                                where plan.MaPL == mapl
                                                select order);
                            if (tblhuongthan != null && tblhuongthan.Any())
                            {
                                GuiDonThuoc(tblhuongthan, "h", cboBacSy.SelectedValue);
                            }
                            //thuoc thuong
                            //DataTable tblthuong = ReportData5.Tables[0].AsEnumerable()
                            // .Where(r => (r.Field<string>("mapl") != "00002") && (r.Field<string>("mapl") != "00003"))
                            // .CopyToDataTable();
                            var tblthuong = (from order in _BenhAn_ThuocSDList
                                             join plan in dmthuoc
                                                  on order.Mathuoc equals plan.MaThuoc
                                             where (plan.MaPL != "00002" && plan.MaPL != "00003")
                                             select order);
                            if (tblthuong != null && tblthuong.Any())
                            {
                                GuiDonThuoc(tblthuong, "c", cboBacSy.SelectedValue);
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteLog("Loi lien thong don thuoc: " + ex.Message);
                        }
                    }
                }
            }
            if (_loaikq == "0")
            {
                DMThuocList dmthuoc = DMThuocList.GetAllDMThuoc();
                BenhAn_ThuocSDList _BenhAn_ThuocSDList = BenhAn_ThuocSDList.GetAllBenhAn_ThuocSD(_BenhAn_Khoa.MaBA, false);
                if (_BenhAn_ThuocSDList.Count > 0)
                {
                    foreach (BenhAn_ThuocSD ba in _BenhAn_ThuocSDList)
                    {
                        if (HTC.ShareVariables.pub_spC == "HH")
                        {
                            if (DateDiff(DateInterval.Day, DateTime.Parse(ba.DenNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0 && ba.Phat == true && ba.BHTinhtien == true && ba.Tinhtien == false)
                            {
                                if (decimal.Parse(ba.SLMua) - decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > decimal.Parse("0.1"))
                                {
                                    ShowMessage("Bệnh nhân có ngày dùng thuốc lớn hơn ngày ra viện");
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            if (DateDiff(DateInterval.Day, DateTime.Parse(ba.DenNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0 && ba.BHTinhtien == true && ba.Tinhtien == false)
                            {
                                if (decimal.Parse(ba.SLMua) - decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > decimal.Parse("0.1"))
                                {
                                    ShowMessage("Bệnh nhân có ngày dùng thuốc lớn hơn ngày ra viện");
                                    if (loai == 2 || (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PS"))
                                        return false;
                                }
                            }
                            if (HTC.ShareVariables.pub_spC == "QN" && decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > 0 && ba.DaTHTra == false)
                            {
                                string _Mess = "Bệnh nhân có thuốc ngày " + ba.TuNgay + " chưa trả thuốc.Đề nghị hoàn trả hoặc hủy thuốc, xn, vt, máu dự trù có y lệnh sau ngày ra viện trước khi in giấy ra viện của BN";
                                ShowMessage("Bệnh nhân có thuốc ngày " + ba.TuNgay + " chưa trả thuốc.Đề nghị hoàn trả hoặc hủy thuốc, xn, vt, máu dự trù có y lệnh sau ngày ra viện trước khi in giấy ra viện của BN");
                                if (loai == 2)
                                    return false;
                            }
                            if (HTC.ShareVariables.pub_spC == "QN" && ba.Phat == false && ba.thuocdx == false)
                            {
                                if (decimal.Parse(ba.SLMua) - decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > decimal.Parse("0.1"))
                                {
                                    ShowMessage("Bệnh nhân có thuốc chưa duyệt");
                                    if (loai == 2)
                                        return false;
                                }
                            }
                        }
                    }
                    if (cboBacSy.SelectedValue != "")
                    {
                        try
                        {
                            //thuoc gay nghien
                            String mapl = "00002";
                            //bool contains = ReportData6.Tables[0].AsEnumerable().Any(row => mapl == row.Field<String>("mapl"));
                            var tblgaynghien = (from order in _BenhAn_ThuocSDList
                                                join plan in dmthuoc
                                                     on order.Mathuoc equals plan.MaThuoc
                                                where plan.MaPL == mapl
                                                select order);
                            //var tblgaynghien = query.AsEnumerable()
                            // .Where(r => r.plan.MaPL == mapl)
                            // .CopyToDataTable();
                            if (tblgaynghien != null && tblgaynghien.Any())
                            {
                                GuiDonThuoc(tblgaynghien, "n", cboBacSy.SelectedValue);
                            }
                            //thuoc huong than
                            mapl = "00003";
                            //DataTable tblhuongthan = ReportData5.Tables[0].AsEnumerable()
                            // .Where(r => r.Field<string>("mapl") == mapl)
                            // .CopyToDataTable();
                            var tblhuongthan = (from order in _BenhAn_ThuocSDList
                                                join plan in dmthuoc
                                                     on order.Mathuoc equals plan.MaThuoc
                                                where plan.MaPL == mapl
                                                select order);
                            if (tblhuongthan != null && tblhuongthan.Any())
                            {
                                GuiDonThuoc(tblhuongthan, "h", cboBacSy.SelectedValue);
                            }
                            //thuoc thuong
                            //DataTable tblthuong = ReportData5.Tables[0].AsEnumerable()
                            // .Where(r => (r.Field<string>("mapl") != "00002") && (r.Field<string>("mapl") != "00003"))
                            // .CopyToDataTable();
                            var tblthuong = (from order in _BenhAn_ThuocSDList
                                             join plan in dmthuoc
                                                  on order.Mathuoc equals plan.MaThuoc
                                             where (plan.MaPL != "00002" && plan.MaPL != "00003")
                                             select order);
                            if (tblthuong != null && tblthuong.Any())
                            {
                                GuiDonThuoc(tblthuong, "c", cboBacSy.SelectedValue);
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteLog("Loi lien thong don thuoc: " + ex.Message);
                        }
                    }
                }
                BenhAn_ThuocSD_DYList _BenhAn_ThuocSD_DYList = BenhAn_ThuocSD_DYList.GetAllBenhAn_ThuocSD_DY(_BenhAn_Khoa.MaBA, false);
                if (_BenhAn_ThuocSD_DYList.Count > 0)
                {
                    foreach (BenhAn_ThuocSD_DY ba in _BenhAn_ThuocSD_DYList)
                    {
                        if (ba.Phat == false)
                        {
                            //string _Mess = "Bệnh nhân có thuốc ngày " + ba.TuNgay + " chưa trả thuốc.Đề nghị hoàn trả hoặc hủy thuốc, xn, vt, máu dự trù có y lệnh sau ngày ra viện trước khi in giấy ra viện của BN";
                            ShowMessage("Bệnh nhân có thuốc ngày " + ba.TuNgay + " chưa phát thuốc.Đề nghị hoàn trả hoặc hủy thuốc, xn, vt, máu dự trù có y lệnh sau ngày ra viện trước khi in giấy ra viện của BN");
                            //if (loai == 2)
                            return false;
                        }
                        if (DateDiff(DateInterval.Day, DateTime.Parse(ba.DenNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0 && ba.BHTinhtien == true && ba.Tinhtien == false)
                        {
                            if (decimal.Parse(ba.SLMua) - ba.SLTra > decimal.Parse("0.1"))
                            {
                                ShowMessage("Bệnh nhân có ngày dùng thuốc lớn hơn ngày ra viện");
                                if (HTC.ShareVariables.pub_spC == "QN" && loai == 2)
                                    return false;
                            }
                            //WriteLog(ba.Phat.ToString());
                            
                        }
                    }
                    //try
                    //{
                    //    GuiDonThuocDY(_BenhAn_ThuocSD_DYList, "c");
                    //}
                    //catch (Exception ex)
                    //{
                    //    WriteLog("Loi lien thong don thuoc: " + ex.Message);
                    //}

                }
                BenhAn_C_List _BenhAn_C_List = BenhAn_C_List.GetAllBenhAn_C(_BenhAn_Khoa.MaBA, false);
                foreach (BenhAn_C ba in _BenhAn_C_List)
                {
                    if (DateDiff(DateInterval.Day, DateTime.Parse(ba.DenNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0 && ba.BHTinhTien == true && ba.TinhTien == false)
                    {
                        if (decimal.Parse(ba.Slmua) - decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > decimal.Parse("0.1"))
                        {
                            ShowMessage("Bệnh nhân có ngày dùng dịch vụ lớn hơn ngày ra viện");
                            if (loai == 2 || (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PS"))
                                return false;
                        }
                    }
                }
                BenhAn_VTTHList _BenhAn_VTTHList = BenhAn_VTTHList.GetAllBenhAn_VTTH(_BenhAn_Khoa.MaBA, false);
                foreach (BenhAn_VTTH ba in _BenhAn_VTTHList)
                {
                    if (DateDiff(DateInterval.Day, DateTime.Parse(ba.DenNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0 && ba.BHTinhtien == true && ba.Tinhtien == false)
                    {
                        if (decimal.Parse(ba.SLMua) - decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > decimal.Parse("0.1"))
                        {
                            ShowMessage("Bệnh nhân có ngày dùng VTTH lớn hơn ngày ra viện");
                            if (loai == 2 || (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PS"))
                                return false;
                        }
                    }
                    if (HTC.ShareVariables.pub_spC == "QN" && decimal.Parse(ba.SLTra == "" ? "0" : ba.SLTra) > 0 && ba.DaTHTra == false)
                    {
                        string _Mess = "Bệnh nhân có VTTH ngày " + ba.TuNgay + " chưa trả VTTH.Đề nghị hoàn trả hoặc hủy thuốc, xn, vt, máu dự trù có y lệnh sau ngày ra viện trước khi in giấy ra viện của BN";
                        ShowMessage("Bệnh nhân có VTTH ngày " + ba.TuNgay + " chưa trả VTTH.Đề nghị hoàn trả hoặc hủy thuốc, xn, vt, máu dự trù có y lệnh sau ngày ra viện trước khi in giấy ra viện của BN");
                        if (loai == 2)
                            return false;
                    }
                }
                BenhAn_GiuongList _BenhAn_GiuongList = BenhAn_GiuongList.GetAllBenhAn_Giuong(_BenhAn_Khoa.MaBA, false);
                decimal g = 0;
                foreach (BenhAn_Giuong ba in _BenhAn_GiuongList)
                {
                    if (DateDiff(DateInterval.Day, DateTime.Parse(ba.TuNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0 && ba.BHTinhtien == true && ba.Tinhtien == false)
                    {
                        if (decimal.Parse(ba.SLMua) > decimal.Parse("0.1"))
                        {
                            ShowMessage("Bệnh nhân có giường dùng dịch vụ lớn hơn ngày ra viện");
                            if (loai == 2 || (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PS"))
                                return false;
                        }
                    }
                    if (DateDiff(DateInterval.Day, DateTime.Parse(ba.DenNgay), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) < 0)
                    {
                        if (decimal.Parse(ba.SLMua) > decimal.Parse("0.1"))
                        {
                            ShowMessage("Bệnh nhân có giường dùng dịch vụ lớn hơn ngày ra viện");
                            if (loai == 2 || (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PS"))
                                return false;
                        }
                    }
                    g = g + decimal.Parse(ba.SLMua);
                }
                if (HTC.ShareVariables.pub_spC == "PH")
                {
                    if ((DateDiff(DateInterval.Day, DateTime.Parse(_BenhAn_Khoa.NgayVVTT.Substring(0, 10)), DateTime.Parse(dtngayravien.Text.Substring(0, 10))) + 1) != g)
                    {
                        ShowMessage("Ngày giường không bằng nhau");
                        //  return false;
                    }
                }
                if (HTC.ShareVariables.pub_spC == "PH")
                {
                    if (DateDiff(DateInterval.Hour, DateTime.Parse(dtngayravien.Text), DateTime.Parse(_BenhAn_Khoa.NgayVVTT)) < -5)
                    {
                        if (_BenhAn_GiuongList.Count <= 0)
                        {
                            ShowMessage("Bệnh nhân chưa kê giường");
                            if (loai == 2 && HTC.ShareVariables.pub_spC == "PH")
                                return false;
                        }
                    }
                }
            }
            //if (loai == 2 && HTC.ShareVariables.pub_spC == "HU" && (HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ " || HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ"))
            //{
            //    BenhAn_DoiTuongList dtl = BenhAn_DoiTuongList.GetAllBenhAn_DoiTuongByMaBA(_MaBA);
            //    foreach (BenhAn_DoiTuong dt in dtl)
            //    {
            //        if (dt.MaDT.Substring(0, 1) == "1")
            //        {
            //            BenhAn_ChuyenBN chuyen = BenhAn_ChuyenBN.GetBenhAn_ChuyenBN(dt.Sothe, 0);
            //            if (chuyen.MaBA != "")
            //            {
            //                ShowMessage("Bệnh nhân này là bệnh nhân ghép bệnh án!Yêu cầu hoàn tất hồ sơ chuyển bệnh nhân");
            //                return false;
            //            }
            //        }
            //    }
            //}
            if (dtngayravien.Text != "")
            {
                _BenhAnPK.NgayRaVien = dtngayravien.Text;
            }
            else
            {
                _BenhAnPK.NgayRaVien = "";
            }
            if (HTC.ShareVariables.pub_spC == "PH")
                _BenhAnPK.MRV = dtNgayVV.Text;
            else
                _BenhAnPK.NgayGioCV = dtNgayVV.Text;
            _BenhAnPK.MaHTRa = cboHTravien.SelectedValue;
            _BenhAnPK.MaKQDT = cboKQDT.SelectedValue;
            _BenhAnPK.MaLoaiBA = cboLoaiBA.SelectedValue;
            _BenhAnPK.MaGPBenh = cboGPbenh.SelectedValue;
            _BenhAnPK.MaBenhKKB = cboCDVaoVien.SelectedValue;
            _BenhAnPK.maicdKKB = cboCDVaoVien.Text;
            _BenhAnPK.TenBenhKKB = txtBenhVao.Text;
            _BenhAnPK.Ghichu = txtGhiChu.Text;
            _BenhAnPK.MaBenhRavien = cbocdravien.SelectedValue;
            _BenhAnPK.MaICDRaVien = cbocdravien.Text;
            _BenhAnPK.MabenhKem = cboCDKem.SelectedValue;
            _BenhAnPK.maicdKem = cboCDKem.Text;
            _BenhAnPK.tenbenhKem = txtBenhKem.Text;
            _BenhAnPK.MaBenhRaVienYHCT = cboChanDoanTheoYHCT.SelectedValue;
            _BenhAnPK.TenBenhRaVienKKBYHCT = txtChanDoanTheoYHCT.Text;
            _BenhAnPK.MaICDravienYHCT = cboChanDoanTheoYHCT.Text;
            if (cbocdravien.SelectedValue == "")
                if (cbocdravien.SelectedValue == "")
                    _BenhAnPK.MaBenhRavien = cbocdravien.Text;
            _BenhAnPK.TenBenhRaVien = txtBenhRa.Text;
            _BenhAnPK.benhly = txtBenhLy.Text;
            _BenhAnPK.ketquacls = txtKetQuaCLS.Text;
            _BenhAnPK.tinhtrangbn = txtTinhTrang.Text;
            _BenhAnPK.LoiDan = txtLoiDan.Text;
            _BenhAnPK.GDVV = txtNguoiVanChuyen.Text;
            _BenhAnPK.GDRV = txtPhuongtienVC.Text;
            _BenhAnPK.DieuTri = txtPhuongPhapDT.Text;
            _BenhAnPK.MaHDT = cboHuongDT.SelectedValue;
            _BenhAnPK.MaNoiChuyen = cboNoiDK.SelectedValue;
            _BenhAnPK.TenBVChuyen = txtTenBV.Text;
            _BenhAnPK.MABHXHChuyen = cboNoiDK.Text;
            _BenhAnPK.NgayTVong = dtNgayTV.Text;
            _BenhAnPK.MaLDTVong = cboLyDoTV.SelectedValue;
            _BenhAnPK.MaTGTVong = cboThoiGianTV.SelectedValue;
            _BenhAnPK.KNTuThi = chkknTuthi.Checked;
            _BenhAnPK.MaMay = Pub_sMaMay;
            _BenhAnPK.NguoiSD = Pub_sNguoiSD;
            if (cboCDGiaiPhau.SelectedValue != "")
            {
                _BenhAnPK.MaGPTuThi = cboCDGiaiPhau.SelectedValue;
            }
            _BenhAnPK.TenBenhGP = txtBenhGP.Text;
            _BenhAnPK.NNTVong = txtNguyennhanTV.Text;
            DateTime d, d1, d2;
            string sqlh = "";
            if (dtngaycap_bhxh.Text.Trim().Length > 0 && DateTime.TryParse(dttungay_bhxh.Text, out d) && DateTime.TryParse(dtdenngay_bhxh.Text, out d1) && DateTime.TryParse(dtngaycap_bhxh.Text, out d2))
            {
                if (CheckTrungNghiBHXH(_BenhAnPK.Sothe, d, 7) == true)
                {
                    ShowMessage("Bệnh nhân này đã có giấy nghỉ việc hưởng BHXH!");
                }
                else
                {
                    //_BenhAnPK.Tungay_bhxh = dttungay_bhxh.Text;
                    //_BenhAnPK.Denngay_bhxh = dtdenngay_bhxh.Text;
                    //_BenhAnPK.Ngaycap_bhxh = dtngaycap_bhxh.Text;
                    //HTC.Business.DataProvider.Instance().ExcSQL(sqlh);
                    //update so seri
                    sqlh += " declare @soseri numeric(38,0),@soserikb numeric(38,0) set @soserikb=0";
                    sqlh += " select @soseri= isnull(soseri,0) from benhanpk where mabanoitru='" + _MaBA + "' and isnull(huy,0)=0";
                    sqlh += " if isnull(@soseri,0)=0 select @soseri= isnull(max(soseri),0) from benhanpk_luu";
                    sqlh += " if isnull(@soserikb,0)=0 select @soserikb= isnull(max(soseri),0) from khambenh";
                    sqlh += " if isnull(@soserikb,0)=0 select @soserikb= isnull(max(soseri),0) from khambenh_luu";
                    sqlh += " if isnull(@soserikb,0) > isnull(@soseri,0) set @soseri=@soserikb";
                    sqlh += " if isnull(@soseri,0)=0 set @soseri= 1 else set @soseri=@soseri+1";
                    sqlh += " update benhanpk set soseri= @soseri where mabanoitru='" + _MaBA + "' and isnull(huy,0)=0";
                }
                sqlh += " update BenhAnPK set Tungay_bhxh ='" + d.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', denngay_bhxh ='" + d1.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', Ngaycap_bhxh ='" + d2.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' where MaBANoiTru='" + _MaBA + "';";
            }
            //if (dtngaycap_bhxh.Text.Trim().Length > 0 && DateTime.TryParse(dtNGAY_CHUNG_TU_RaVien.Text, out d))
            if ( DateTime.TryParse(dtNGAY_CHUNG_TU_RaVien.Text, out d))
            {
                //_BenhAnPK.NGAY_CHUNG_TU_RaVien = dtNGAY_CHUNG_TU_RaVien.Text;
                sqlh += " update BenhAnPK set NGAY_CHUNG_TU_RaVien ='" + d.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', MaTruongKhoa='" + cboTruongKhoa.SelectedValue + "' where MaBANoiTru='" + _MaBA + "';";
            }
            sqlh += " update BenhAnPK set VET_THUONG_TP =" + (chkVET_THUONG_TP.Checked == true ? "1" : "0") + " where MaBANoiTru='" + _MaBA + "';";
            if (dtngaycap_bhxh.Text.Trim().Length > 0)
            {
                sqlh += " update ThongTinBN set nguoigiamho ='" + txtnguoigiamho.Text + "', hotenbo ='" + txthotencha.Text + "', hotenme ='" + txthotenme.Text + "', SoCMT ='" + txtSoCMND.Text + "', NGAYCAP_CMND ='" + DateTime.Parse(dtNGAYCAP_CMND.Text).ToString("yyyy-MM-dd HH:mm:ss.fff") + "', NOICAP_CMND ='" + txtNoiCapCMND.Text + "', NoiLamViec ='" + txtNoiLV.Text + "' where MaBN='" + _BenhAn_Khoa.MaBN + "';";
                if (txtMaSoBHXH.Text.Trim().Length > 0)
                    //spThongTinBN_SetSoBHXH(txtMaSoBHXH.Text.Trim(), _ThongtinBN.MaBN);
                    sqlh += " update ThongTinBN set Ma_BHXH ='" + txtMaSoBHXH.Text + "' where MaBN='" + _BenhAn_Khoa.MaBN + "';";
                sqlh += " update BenhNhan set nguoigiamho ='" + txtnguoigiamho.Text + "', hotenbo ='" + txthotencha.Text + "', hotenme ='" + txthotenme.Text + "', SoCMT ='" + txtSoCMND.Text + "', NGAYCAP_CMND ='" + DateTime.Parse(dtNGAYCAP_CMND.Text).ToString("yyyy-MM-dd HH:mm:ss.fff") + "', NOICAP_CMND ='" + txtNoiCapCMND.Text + "', NoiLamViec ='" + txtNoiLV.Text + "' where MaBN='" + _BenhAn_Khoa.MaBN + "';";
            }
            HTC.Business.DataProvider.Instance().ExcSQL(sqlh);
            _BenhAnPK.ApplyEdit();
            _BenhAnPK.Save();
            string sql = "";
            string ks = chkchuyenBA.Checked == true ? "1" : "0";
            if (_BenhAnPK.NgayRaVien != "")
            {
                sql = " update benhan set ngaybaluu = " + (dtNgayLuu.Text == "" ? "null" : "'" + vvdate(dtNgayLuu.Text) + "'") + ", ngayravien='" + vvdate(dtngayravien.Text) + "' ,mabaluu ='" + txtmaluutru.Text + "', mabsravien ='" + (cboBacSy.SelectedValue != null ? cboBacSy.SelectedValue.Substring(cboBacSy.SelectedValue.IndexOf("-") + 1) : "") + "' , daks =" + ks + " where maba ='" + _MaBA + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);
            }
            if ((loai == 2 || HTC.ShareVariables.pub_spC == "YH" || (HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV != "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")) && _loaikq == "0")
            {
                if (_BenhAnPK.NgayRaVien != "")
                {
                    //if (HTC.ShareVariables.pub_spC == "PS")
                    //{
                    //    BenhAn_ThuocSDList _bal = BenhAn_ThuocSDList.GetAllBenhAn_ThuocSD(_MaBA, "and isnull(a.huy,0)=0 and isnull(a.datt,0)=0 and (isnull(a.duyet ,0)=0  or (isnull(DaYCTra,0) =0 and isnull(sltra,0) >0))");
                    //    if (_bal.Count > 0)
                    //    {
                    //        ShowMessage("Chưa duyệt hoặc trả thuốc ! Không thể ra viện");
                    //        return false;
                    //    }
                    //}
                    BenhAn_ThanhToanList _BenhAn_ThanhToanList = BenhAn_ThanhToanList.GetAllBenhAn_ThanhToanByMaBA(_MaBA);

                    if (_BenhAn_Khoa.RaKhoa == 0)
                    {
                        if (_BenhAn_ThanhToanList.Count != 0 && HTC.ShareVariables.pub_spC == "PS")
                        {
                            if ((DateTime.Parse(dtngayravien.Text.Substring(0, 10)) - DateTime.Parse(_BenhAn_ThanhToanList[_BenhAn_ThanhToanList.Count - 1].DenNgay)).Days >= 0)
                            {
                                BenhAn_ThanhToan _BenhAn_ThanhToan = BenhAn_ThanhToan.NewBenhAn_ThanhToan();
                                _BenhAn_ThanhToan.MaBA = _BenhAn_Khoa.MaBA;
                                _BenhAn_ThanhToan.MaBV = _BenhAn_Khoa.MaBV;
                                _BenhAn_ThanhToan.MaDT = _BenhAn_Khoa.MaDT;
                                _BenhAn_ThanhToan.NgayQT = dtngayravien.Text;
                                _BenhAn_ThanhToan.NguoiQT = Pub_sNguoiSD;
                                _BenhAn_ThanhToan.Sothe = _BenhAn_Khoa.Sothe;
                                _BenhAn_ThanhToan.TenDT = _BenhAn_Khoa.TenDT;
                                _BenhAn_ThanhToan.MaMay = Pub_sMaMay;
                                _BenhAn_ThanhToan.NguoiSD = Pub_sNguoiSD;
                                if (_BenhAn_ThanhToanList.Count > 0)
                                {
                                    _BenhAn_ThanhToan.TuNgay = _BenhAn_ThanhToanList[_BenhAn_ThanhToanList.Count - 1].DenNgay;
                                }
                                else
                                {
                                    _BenhAn_ThanhToan.TuNgay = _BenhAnPK.NgayVKhoa;
                                }
                                _BenhAn_ThanhToan.DenNgay = dtngayravien.Text;

                                BenhAn_ThanhToan abc = _BenhAn_ThanhToan.Clone();
                                _BenhAn_ThanhToan = abc.Save();
                            }
                        }
                        else if (_BenhAn_ThanhToanList.Count == 0)
                        {
                            BenhAn_ThanhToan _BenhAn_ThanhToan = BenhAn_ThanhToan.NewBenhAn_ThanhToan();
                            _BenhAn_ThanhToan.MaBA = _BenhAn_Khoa.MaBA;
                            _BenhAn_ThanhToan.MaBV = _BenhAn_Khoa.MaBV;
                            _BenhAn_ThanhToan.MaDT = _BenhAn_Khoa.MaDT;
                            _BenhAn_ThanhToan.NgayQT = dtngayravien.Text;
                            _BenhAn_ThanhToan.NguoiQT = Pub_sNguoiSD;
                            _BenhAn_ThanhToan.Sothe = _BenhAn_Khoa.Sothe;
                            _BenhAn_ThanhToan.TenDT = _BenhAn_Khoa.TenDT;
                            _BenhAn_ThanhToan.TuNgay = _BenhAnPK.NgayVKhoa;
                            _BenhAn_ThanhToan.DenNgay = dtngayravien.Text;
                            _BenhAn_ThanhToan.MaMay = Pub_sMaMay;
                            _BenhAn_ThanhToan.NguoiSD = Pub_sNguoiSD;
                            BenhAn_ThanhToan abc = _BenhAn_ThanhToan.Clone();
                            _BenhAn_ThanhToan = abc.Save();
                        }
                    }
                    if (HTC.ShareVariables.pub_spC == "PH")
                    {
                        _BenhAn_Khoa.Ghichu = txtGhiChuBenh.Text;
                    }
                    _BenhAn_Khoa.RaKhoa = 2;
                    _BenhAn_Khoa.NgayKT = dtngayravien.Text;
                    _BenhAn_Khoa.NguoiSD = Pub_sNguoiSD;
                    _BenhAn_Khoa.MaMay = Pub_sMaMay;
                    BenhAn_Khoa abck = _BenhAn_Khoa.Clone();
                    _BenhAn_Khoa = abck.Save();
                    // benh an khoa
                    //sql = " update benhan_khoa set rakhoa =2 , ngaykt ='" + _BenhAnPK.NgayRaVien.Substring(3, 2) + "/" + _BenhAnPK.NgayRaVien.Substring(0, 2) + "/" + _BenhAnPK.NgayRaVien.Substring(6) + "' , nguoisd ='" + Pub_sNguoiSD + "',ngaysd = getdate() where maba ='" + _MaBA + "' and sttkhoa =" + _STTKhoa;
                    //HTC.Business.DataProvider.Instance().ExcSQL(sql);
                }
            }
            else
            {
                if (_loaikq != "0")
                {
                    if (_BenhAnPK.NgayRaVien != "")
                    {
                        BenhAn_ThanhToanList _BenhAn_ThanhToanList = BenhAn_ThanhToanList.GetAllBenhAn_ThanhToanByMaBA(_MaBA);
                        if (_BenhAn_ThanhToanList.Count > 0)
                        {
                            sql = " update benhan_thanhtoan set denngay ='" + _BenhAnPK.NgayRaVien.Substring(3, 2) + "/" + _BenhAnPK.NgayRaVien.Substring(0, 2) + "/" + _BenhAnPK.NgayRaVien.Substring(6) + "' , nguoisd ='" + Pub_sNguoiSD + "',ngaysd = getdate() where maba ='" + _MaBA + "' and isnull(daqt,0)=0 and datt =" + _BenhAn_ThanhToanList[_BenhAn_ThanhToanList.Count - 1].DaTT.ToString();
                            HTC.Business.DataProvider.Instance().ExcSQL(sql);
                        }
                    }
                }
            }
            //load so seri
            txtSoSeri.Text = spBenhAnPK_GetSeri(_MaBA);
            //tao file xml đẩy giấy ra viện lên cổng BHXH
            if (txtMaQL.Text.Trim().Length > 0 && DateTime.TryParse(dtNGAY_CHUNG_TU_RaVien.Text, out d))
            {
                WriteLog("tao file xml đẩy giấy ra viện lên cổng BHXH");
                string dk = "";
                string cin = txtMaQL.Text.Trim();
                dk += " and (isnull(b.mabaql,isnull(b.maba,'')) in ('" + cin + "') or isnull(b.maba,'') in ('" + cin + "'))";
                string nt = "CT03";
                DataTable dt = GetData(d, d, 3, dk);
                {
                    HSCHUNGTU hSCHUNGTU = new HSCHUNGTU();
                    //HTC.Business.NoiTru.THONGTINDONVI tHONGTINDONVI = new HTC.Business.NoiTru.THONGTINDONVI();
                    THONGTINDONVI tHONGTINDONVI = new THONGTINDONVI();
                    tHONGTINDONVI.MACSKCB = HTC.ShareVariables.pub_sMaBHXH;
                    tHONGTINDONVI.CHUKYDONVI = "";
                    hSCHUNGTU.THONGTINDONVI = tHONGTINDONVI;
                    //HTC.Business.NoiTru.BHXH bHXH = new HTC.Business.NoiTru.BHXH();
                    BHXH bHXH = new BHXH();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        //HTC.Business.NoiTru.THONGTINHOSO tHONGTINHOSO = new HTC.Business.NoiTru.THONGTINHOSO();
                        THONGTINHOSO tHONGTINHOSO = new THONGTINHOSO();
                        tHONGTINHOSO.NGAYLAP = DateTime.Now.ToString("yyyyMMdd");
                        //tHONGTINHOSO.SOLUONGHOSO = dt.Rows.Count.ToString();
                        tHONGTINHOSO.SOLUONGHOSO = dt.Rows.Count;
                        //List<HTC.Business.NoiTru.HOSO> hOSOs = new List<HTC.Business.NoiTru.HOSO>();
                        List<HOSO> hOSOs = new List<HOSO>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //HTC.Business.NoiTru.HOSO hOSO = new HTC.Business.NoiTru.HOSO();
                            //HTC.Business.NoiTru.FILEHOSO fILEHOSO = new HTC.Business.NoiTru.FILEHOSO();
                            HOSO hOSO = new HOSO();
                            FILEHOSO fILEHOSO = new FILEHOSO();
                            fILEHOSO.LOAIHOSO = "CT03";
                            CT03 cT07 = new CT03();
                            cT07.SO_LUU_TRU = dt.Rows[i]["SO_LUU_TRU"].ToString();
                            cT07.MA_YTE = dt.Rows[i]["MA_YTE"].ToString();
                            cT07.MA_KHOA = dt.Rows[i]["MA_KHOA"].ToString();
                            cT07.MA_BHXH = dt.Rows[i]["MA_BHXH"].ToString();
                            cT07.MA_THE = dt.Rows[i]["MA_THE"].ToString();
                            cT07.HO_TEN = dt.Rows[i]["HO_TEN"].ToString();
                            cT07.NGAY_SINH = dt.Rows[i]["NGAY_SINH"].ToString();
                            cT07.GIOI_TINH = dt.Rows[i]["GIOI_TINH"].ToString();
                            cT07.MA_DANTOC = dt.Rows[i]["MA_DANTOC"].ToString();
                            cT07.NGHE_NGHIEP = dt.Rows[i]["NGHE_NGHIEP"].ToString();
                            cT07.DIA_CHI = dt.Rows[i]["DIA_CHI"].ToString();
                            cT07.NGAY_VAO = dt.Rows[i]["NGAY_VAO"].ToString();
                            cT07.NGAY_RA = dt.Rows[i]["NGAY_RA"].ToString();
                            cT07.DINH_CHI_THAI_NGHEN = dt.Rows[i]["DINH_CHI_THAI_NGHEN"].ToString();
                            cT07.TUOI_THAI = dt.Rows[i]["TUOI_THAI"].ToString();
                            cT07.CHAN_DOAN = dt.Rows[i]["CHAN_DOAN"].ToString();
                            cT07.PP_DIEUTRI = dt.Rows[i]["PP_DIEUTRI"].ToString();
                            cT07.GHI_CHU = dt.Rows[i]["GHI_CHU"].ToString();
                            cT07.THU_TRUONG_DVI = dt.Rows[i]["THU_TRUONG_DVI"].ToString();
                            cT07.MA_CCHN_TRUONGKHOA = dt.Rows[i]["MA_CCHN_TRUONGKHOA"].ToString();
                            cT07.TEN_TRUONGKHOA = dt.Rows[i]["TEN_TRUONGKHOA"].ToString();
                            cT07.NGAY_CHUNG_TU = dt.Rows[i]["NGAY_CHUNG_TU"].ToString();
                            cT07.TEKT = dt.Rows[i]["TEKT"].ToString();
                            cT07.HO_TEN_CHA = dt.Rows[i]["HO_TEN_CHA"].ToString();
                            cT07.HO_TEN_ME = dt.Rows[i]["HO_TEN_ME"].ToString();
                            cT07.NGOAITRU_TUNGAY = dt.Rows[i]["NGOAITRU_TUNGAY"].ToString();
                            cT07.NGOAITRU_DENNGAY = dt.Rows[i]["NGOAITRU_DENNGAY"].ToString();
                            string ndfilexml = bHXH.Serialize(cT07, "");
                            MemoryStream memStream = new MemoryStream();
                            StreamWriter writer = new StreamWriter(memStream);
                            writer.Write(ndfilexml);
                            writer.Flush();
                            memStream.Position = 0;
                            string base64String = Convert.ToBase64String(memStream.ToArray());
                            fILEHOSO.NOIDUNGFILE = base64String;
                            FILEHOSO[] FILEHOSOs = { fILEHOSO };
                            hOSO.FILEHOSO = FILEHOSOs;
                            hOSOs.Add(hOSO);
                            memStream.Dispose();
                            memStream.Close();
                            writer.Dispose();
                            writer.Close();
                        }
                        tHONGTINHOSO.DANHSACHHOSO = hOSOs.ToArray();
                        hSCHUNGTU.THONGTINHOSO = tHONGTINHOSO;
                    }
                    //string filename = Server.MapPath(@"~\Temp\BHXH" + nt + dtDenNgay.Text.Substring(3, 2) + dtDenNgay.Text.Substring(6, 4) + ".XML");
                    //if (File.Exists(filename))
                    //{
                    //    FileInfo fi = new FileInfo(filename);
                    //    if (fi.IsReadOnly)
                    //        fi.IsReadOnly = false;
                    //    fi.Delete();
                    //}
                    //XmlSerializer xs = new XmlSerializer(typeof(HSCHUNGTU));
                    //TextWriter txtWriter = new StreamWriter(filename, false, Encoding.UTF8);
                    //xs.Serialize(txtWriter, hSCHUNGTU);
                    //txtWriter.Close();
                    //ShowMessage("Tạo file thành công!");
                    //ReadfileXml(filename);
                    string filename = "";
                    DateTime tungay;
                    DateTime denngay;
                    tungay = DateTime.Now.AddMinutes(-10).AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                    denngay = DateTime.Now.AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                    string _tungay = tungay.ToString("dd/MM/yyyy HH:mm");
                    string _denngay = denngay.ToString("dd/MM/yyyy HH:mm");
                    filename = System.Web.Hosting.HostingEnvironment.MapPath(@"~\HSChungTu\BHXH" + nt + txtMaQL.Text.Trim() + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + ".XML");
                    WriteLog("file name: " + filename);
                    if (File.Exists(filename))
                    {
                        FileInfo fi = new FileInfo(filename);
                        if (fi.IsReadOnly)
                            fi.IsReadOnly = false;
                        fi.Delete();
                    }
                    //StreamWriter file = new StreamWriter(filename, false, Encoding.UTF8);
                    //file.Write(returnObjectToXml(hSCHUNGTU));
                    //file.Close();
                    XmlSerializer xs = new XmlSerializer(typeof(HSCHUNGTU));
                    TextWriter txtWriter = new StreamWriter(filename, false, Encoding.UTF8);
                    xs.Serialize(txtWriter, hSCHUNGTU);
                    txtWriter.Close();

                    //System.IO.File.WriteAllText(filename, returnObjectToXml(hSCHUNGTU));
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            ShowMessage("Không lưu được dữ liệu" + ex.Message);
            return false;
        }
    }
    protected Boolean PrintdataTT(Boolean _load = true)
    {
        try
        {
            ReportDocument rpt = new ReportDocument();
            String sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CrTomTatBA.rpt";
            //if (HTC.ShareVariables.pub_spC != "HU")
            //    sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CrTomTatBAT.rpt";
            rpt.Load(Server.MapPath(sPath));
            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
            BenhNhan _benhnhan = BenhNhan.GetBenhNhan(_BenhAn_Khoa.MaBN);
            Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
            Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
            Myformulas["Khoa"].Text = "'" + txtTenKhoa.Text + "'";
            Myformulas["mabaql"].Text = "'" + _BenhAn_Khoa.MaBAQL + "'";
            Myformulas["SoThe"].Text = "'" + (_BenhAn_Khoa.Sothe == "" ? _BenhAnPK.Sothe : _BenhAn_Khoa.Sothe) + "'";
            Myformulas["hoten"].Text = "'" + txtHoTen.Text.Replace("'", "''").ToUpper() + "'";
            Myformulas["namsinh"].Text = "'" + dtNgaySinh.Text.Substring(6, 4) + "'";
            Myformulas["Dantoc"].Text = "'" + DMDantoc.GetDMDantoc(_benhnhan.MaDanToc).TenDanToc + "'";
            Myformulas["NgheNghiep"].Text = "'" + DMNgheNghiep.GetDMNgheNghiep(_benhnhan.MaNN).TenNN + "'";
            Myformulas["DiaChi"].Text = "'" + (_benhnhan.DiaChi + " Huyện(quận): " + _benhnhan.TenQH + " Tỉnh, thành phố " + _benhnhan.TenTinh).Replace("'", "") + "'";
            Myformulas["NoiLamViec"].Text = "'" + _benhnhan.NoiLamViec + "'";
            Myformulas["VaoVien"].Text = "'" + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Day.ToString() + " / " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Month.ToString() + " / " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Year.ToString() + "'";
            Myformulas["RV"].Text = "'" + dtngayravien.Text.Substring(0, 2) + " / " + dtngayravien.Text.Substring(3, 2) + " / " + dtngayravien.Text.Substring(6, 4) + "'";
            Myformulas["RaVien"].Text = "'" + dtngayravien.Text.Substring(11, 2) + " giờ  " + dtngayravien.Text.Substring(14, 2) + " phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
            Myformulas["ChanDoanvv"].Text = "'" + (_BenhAnPK.maicdKKB != "" ? _BenhAnPK.maicdKKB : "") + "-" + _BenhAnPK.TenBenhKKB + "'";
            Myformulas["ChanDoan"].Text = "'" + (_BenhAnPK.MaICDRaVien != "" ? _BenhAnPK.MaICDRaVien : "") + "-" + _BenhAnPK.TenBenhRaVien + "'";
            Myformulas["GT"].Text = "'" + lblGioiTinh.Text + "'";
            Myformulas["BL"].Text = "'" + txtBenhLy.Text.Replace("'", "").Replace("\r\n", "|||||") + "'";
            Myformulas["CLS"].Text = "'" + txtKetQuaCLS.Text.Replace("'", "").Replace("\r\n", "|||||") + "'";
            Myformulas["PP"].Text = "'" + txtPhuongPhapDT.Text.Replace("'", "").Replace("\r\n", "|||||") + "'";
            Myformulas["TT"].Text = "'" + txtTinhTrang.Text.Replace("'", "").Replace("\r\n", "|||||") + "'";
            Myformulas["GhiChu"].Text = "'" + txtGhiChu.Text.Replace("'", "").Replace("\r\n", "|||||") + "'";
            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt, true, false);
        }
        catch (Exception ex)
        {
            ShowMessage("Không in được báo cáo" + ex.Message);
        }
        return true;
    }
    protected Boolean Printdata(Boolean _load = true)
    {
        try
        {
            ReportDocument rpt = new ReportDocument();
            String sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayRaVien_RPT.rpt";
            if (HTC.ShareVariables.pub_spC == "HU")
                sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayRaVienA5.rpt";
            if (HTC.ShareVariables.pub_spC == "PH")
                sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayRaVien_RPTP.rpt";
            if (HTC.ShareVariables.pub_spC == "PS")
                sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayRaVien_RPTPS.rpt";
            if (HTC.ShareVariables.pub_spC == "HU" && _BenhAn_Khoa.GoiDichVu == false && _BenhAn_Khoa.maloaibn == "3" && HTC.ShareVariables.pub_sTenBV != "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")
            {
                ShowMessage("Bệnh nhân này là loại bệnh nhân bảo lãnh");
            }
            rpt.Load(Server.MapPath(sPath));
            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
            BenhNhan _benhnhan = BenhNhan.GetBenhNhan(_BenhAn_Khoa.MaBN);
            Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
            Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
            Myformulas["Khoa"].Text = "'" + txtTenKhoa.Text + "'";
            Myformulas["hoten"].Text = "'" + txtHoTen.Text.Replace("'", "''").ToUpper() + "'";
            Myformulas["bsdieutri"].Text = "'" + cboBacSy.Text + "'";
            if (HTC.ShareVariables.pub_spC == "HU")
                Myformulas["Tuoi"].Text = "'" + _BenhAn_Khoa.Tuoi + "'";
            else
                Myformulas["Tuoi"].Text = "'" + _BenhAn_Khoa.NgaySinh.Substring(_BenhAn_Khoa.NgaySinh.Length - 4, 4) + "'";
            Myformulas["mabn"].Text = "'" + _BenhAn_Khoa.MaBN + "'";
            Myformulas["quoctich"].Text = "'" + _benhnhan.TenQG + "'";
            Myformulas["mabaql"].Text = "'" + _BenhAn_Khoa.MaBAQL + "'";
            Myformulas["SoThe"].Text = "'" + (_BenhAn_Khoa.Sothe == "" ? _BenhAnPK.Sothe : _BenhAn_Khoa.Sothe) + "'";
            Myformulas["Dantoc"].Text = "'" + DMDantoc.GetDMDantoc(_benhnhan.MaDanToc).TenDanToc + "'";
            Myformulas["NgheNghiep"].Text = "'" + DMNgheNghiep.GetDMNgheNghiep(_benhnhan.MaNN).TenNN + "'";
            Myformulas["DiaChi"].Text = "'" + (_benhnhan.DiaChi + " " + _benhnhan.TenPXa + " " + _benhnhan.TenQH + " " + _benhnhan.TenTinh).Replace("'", "") + "'";
            if (HTC.ShareVariables.pub_spC == "QN")
                Myformulas["NoiLamViec"].Text = "'" + _benhnhan.NoiLamViec + "'";
            if (_BenhAn_Khoa.MaDT != "00001")
            {
                if (_BenhAnPK.GiaTriTN != "")
                    // Myformulas["TuNgay"].Text = "'" + DateTime.Parse(_BenhAnPK.GiaTriTN).Day + " / " + DateTime.Parse(_BenhAnPK.GiaTriTN).Month + " / " + DateTime.Parse(_BenhAnPK.GiaTriTN).Year + "'";
                    Myformulas["TuNgay"].Text = "'" + _BenhAnPK.GiaTriTN + "'";
                if (_BenhAnPK.GiaTriDN != "")
                    //  Myformulas["DenNgay"].Text = "'" + DateTime.Parse(_BenhAnPK.GiaTriDN).Day + " / " + DateTime.Parse(_BenhAnPK.GiaTriDN).Month + " / " + DateTime.Parse(_BenhAnPK.GiaTriDN).Year + "'";
                    Myformulas["DenNgay"].Text = "'" + _BenhAnPK.GiaTriDN + "'";
            }
            if (HTC.ShareVariables.pub_spC == "PS")
                Myformulas["MaYTe"].Text = "'" + "101/905/" + dtngayravien.Text.Substring(8, 2) + _BenhAnPK.MaBA.Substring(5, 5) + "'";
            if (HTC.ShareVariables.pub_spC == "PS")
            {
                Myformulas["ChanDoanvv"].Text = "'" + _BenhAnPK.maicdKKB + " " + _BenhAnPK.TenBenhKKB + "'";
                if (_BenhAnPK.MaICDRaVien.Length < 8)
                    Myformulas["ChanDoan"].Text = "'" + _BenhAnPK.MaICDRaVien + " " + _BenhAnPK.TenBenhRaVien + " " + txtGhiChuBenh.Text + "'";
                else
                    Myformulas["ChanDoan"].Text = "'" + _BenhAnPK.MaICDRaVien.Substring(0, 8) + " " + _BenhAnPK.TenBenhRaVien + " " + txtGhiChuBenh.Text + "'";
                //  Myformulas["RaVien"].Text = "'    giờ     phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
                Myformulas["RaVien"].Text = "'" + dtngayravien.Text.Substring(11, 2) + " giờ  " + dtngayravien.Text.Substring(14, 2) + " phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
            }
            else
            {
                Myformulas["ChanDoanvv"].Text = "'" + (_BenhAnPK.maicdKKB != "" ? (_BenhAnPK.maicdKKB.Length >= 5 ? _BenhAnPK.maicdKKB.Substring(0, 5) : _BenhAnPK.maicdKKB) : "") + "-" + _BenhAnPK.TenBenhKKB + "'";
                if (HTC.ShareVariables.pub_spC == "PH")
                    Myformulas["ChanDoan"].Text = "'" + (_BenhAnPK.MaICDRaVien != "" ? (_BenhAnPK.MaICDRaVien.Length >= 5 ? _BenhAnPK.MaICDRaVien.Substring(0, 5) : _BenhAnPK.MaICDRaVien) : "") + "-" + _BenhAnPK.TenBenhRaVien + " " + txtGhiChuBenh.Text + "'";
                else
                    Myformulas["ChanDoan"].Text = "'" + (_BenhAnPK.MaICDRaVien != "" ? (_BenhAnPK.MaICDRaVien.Length >= 5 ? _BenhAnPK.MaICDRaVien.Substring(0, 5) : _BenhAnPK.MaICDRaVien) : "") + "-" + _BenhAnPK.TenBenhRaVien + "'";
                Myformulas["RaVien"].Text = "'" + dtngayravien.Text.Substring(11, 2) + " giờ  " + dtngayravien.Text.Substring(14, 2) + " phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
            }
            if (HTC.ShareVariables.pub_spC == "PH")
                Myformulas["ChanDoanKem"].Text = "'" + (_BenhAnPK.maicdKem != "" ? (_BenhAnPK.maicdKem.Length >= 5 ? _BenhAnPK.maicdKem.Substring(0, 5) : _BenhAnPK.maicdKem) : "") + "-" + _BenhAnPK.tenbenhKem + "," + (_BenhAnPK.MaICDravienYHCT != "" ? (_BenhAnPK.MaICDravienYHCT.Length >= 5 ? _BenhAnPK.MaICDravienYHCT.Substring(0, 5) : _BenhAnPK.MaICDravienYHCT) : "") + "-" + _BenhAnPK.TenBenhRaVienKKBYHCT + "'";
            else
                Myformulas["ChanDoanKem"].Text = "'" + (_BenhAnPK.maicdKem != "" ? (_BenhAnPK.maicdKem.Length >= 5 ? _BenhAnPK.maicdKem.Substring(0, 5) : _BenhAnPK.maicdKem) : "") + "-" + _BenhAnPK.tenbenhKem + "'";
            Myformulas["GT"].Text = "'" + lblGioiTinh.Text + "'";
            if (_BenhAn_Khoa.NgayVVTT != "")
                Myformulas["VaoVien"].Text = "'" + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Hour.ToString() + " giờ " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Minute.ToString() + " phút, ngày " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Day.ToString() + " tháng " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Month.ToString() + " năm " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Year.ToString() + "'";
            Myformulas["PP"].Text = "'" + txtPhuongPhapDT.Text.Replace("\r\n", "|||||") + "'";
            Myformulas["LD"].Text = "'" + txtLoiDan.Text.Replace("\r\n", "|||||") + "'";
            Myformulas["tinhtrang"].Text = "'" + cboKQDT.SelectedItem.Text + "'";
            Myformulas["GC"].Text = "'" + txtGhiChu.Text.Replace("\r\n", "|||||") + "'";
            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt, true, false);
            // giay chuyen vien
            if (HTC.ShareVariables.pub_spC == "QN")
            {
                ReportDocument rptrv = new ReportDocument();
                sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/crHoSoBenhAnYHCTT7.rpt";
                rptrv.Load(Server.MapPath(sPath));
                FormulaFieldDefinitions Myformulasrv = rptrv.DataDefinition.FormulaFields;
                Myformulasrv["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
                Myformulasrv["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
                Myformulasrv["Khoa"].Text = "'" + txtTenKhoa.Text + "'";
                Myformulasrv["hoten"].Text = "'" + txtHoTen.Text.Replace("'", "''").ToUpper() + "'";
                Myformulasrv["bsdieutri"].Text = "'" + cboBacSy.Text + "'";
                if (HTC.ShareVariables.pub_spC == "HU")
                    Myformulasrv["Tuoi"].Text = "'" + _BenhAn_Khoa.Tuoi + "'";
                else
                    Myformulasrv["Tuoi"].Text = "'" + _BenhAn_Khoa.NgaySinh.Substring(_BenhAn_Khoa.NgaySinh.Length - 4, 4) + "'";
                Myformulasrv["mabn"].Text = "'" + _BenhAn_Khoa.MaBN + "'";
                Myformulasrv["quoctich"].Text = "'" + _benhnhan.TenQG + "'";
                Myformulasrv["mabaql"].Text = "'" + _BenhAn_Khoa.MaBAQL + "'";
                Myformulasrv["SoThe"].Text = "'" + (_BenhAn_Khoa.Sothe == "" ? _BenhAnPK.Sothe : _BenhAn_Khoa.Sothe) + "'";
                Myformulasrv["Dantoc"].Text = "'" + DMDantoc.GetDMDantoc(_benhnhan.MaDanToc).TenDanToc + "'";
                Myformulasrv["NgheNghiep"].Text = "'" + DMNgheNghiep.GetDMNgheNghiep(_benhnhan.MaNN).TenNN + "'";
                Myformulasrv["DiaChi"].Text = "'" + (_benhnhan.DiaChi + " " + _benhnhan.TenPXa + " " + _benhnhan.TenQH + " " + _benhnhan.TenTinh).Replace("'", "") + "'";
                if (_BenhAn_Khoa.MaDT != "00001")
                {
                    if (_BenhAnPK.GiaTriTN != "")
                        Myformulasrv["TuNgay"].Text = "'" + DateTime.Parse(_BenhAnPK.GiaTriTN).Day + " / " + DateTime.Parse(_BenhAnPK.GiaTriTN).Month + " / " + DateTime.Parse(_BenhAnPK.GiaTriTN).Year + "'";
                    if (_BenhAnPK.GiaTriDN != "")
                        Myformulasrv["DenNgay"].Text = "'" + DateTime.Parse(_BenhAnPK.GiaTriDN).Day + " / " + DateTime.Parse(_BenhAnPK.GiaTriDN).Month + " / " + DateTime.Parse(_BenhAnPK.GiaTriDN).Year + "'";
                }
                if (HTC.ShareVariables.pub_spC == "PS")
                {
                    Myformulasrv["ChanDoanvv"].Text = "'" + _BenhAnPK.TenBenhKKB + "'";
                    Myformulasrv["ChanDoan"].Text = "'" + _BenhAnPK.TenBenhRaVien + txtGhiChuBenh.Text + "'";
                    //  Myformulasrv["RaVien"].Text = "'    giờ     phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
                    Myformulasrv["RaVien"].Text = "'" + dtngayravien.Text.Substring(11, 2) + " giờ  " + dtngayravien.Text.Substring(14, 2) + " phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
                }
                else
                {
                    Myformulasrv["ChanDoanvv"].Text = "'" + (_BenhAnPK.maicdKKB != "" ? (_BenhAnPK.maicdKKB.Length >= 5 ? _BenhAnPK.maicdKKB.Substring(0, 5) : _BenhAnPK.maicdKKB) : "") + "-" + _BenhAnPK.TenBenhKKB + "'";
                    if (HTC.ShareVariables.pub_spC == "PH")
                        Myformulasrv["ChanDoan"].Text = "'" + (_BenhAnPK.MaICDRaVien != "" ? (_BenhAnPK.MaICDRaVien.Length >= 5 ? _BenhAnPK.MaICDRaVien.Substring(0, 5) : _BenhAnPK.MaICDRaVien) : "") + "-" + _BenhAnPK.TenBenhRaVien + " " + txtGhiChuBenh.Text + "'";
                    else
                        Myformulasrv["ChanDoan"].Text = "'" + (_BenhAnPK.MaICDRaVien != "" ? (_BenhAnPK.MaICDRaVien.Length >= 5 ? _BenhAnPK.MaICDRaVien.Substring(0, 5) : _BenhAnPK.MaICDRaVien) : "") + "-" + _BenhAnPK.TenBenhRaVien + "'";
                    Myformulasrv["RaVien"].Text = "'" + dtngayravien.Text.Substring(11, 2) + " giờ  " + dtngayravien.Text.Substring(14, 2) + " phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
                }
                if (HTC.ShareVariables.pub_spC == "PH")
                    Myformulasrv["ChanDoanKem"].Text = "'" + (_BenhAnPK.maicdKem != "" ? (_BenhAnPK.maicdKem.Length >= 5 ? _BenhAnPK.maicdKem.Substring(0, 5) : _BenhAnPK.maicdKem) : "") + "-" + _BenhAnPK.tenbenhKem + "," + (_BenhAnPK.MaICDravienYHCT != "" ? (_BenhAnPK.MaICDravienYHCT.Length >= 5 ? _BenhAnPK.MaICDravienYHCT.Substring(0, 5) : _BenhAnPK.MaICDravienYHCT) : "") + "-" + _BenhAnPK.TenBenhRaVienKKBYHCT + "'";
                else
                    Myformulasrv["ChanDoanKem"].Text = "'" + (_BenhAnPK.maicdKem != "" ? (_BenhAnPK.maicdKem.Length >= 5 ? _BenhAnPK.maicdKem.Substring(0, 5) : _BenhAnPK.maicdKem) : "") + "-" + _BenhAnPK.tenbenhKem + "'";
                Myformulasrv["GT"].Text = "'" + lblGioiTinh.Text + "'";
                if (_BenhAn_Khoa.NgayVVTT != "")
                    Myformulasrv["VaoVien"].Text = "'" + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Hour.ToString() + " giờ " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Minute.ToString() + " phút, ngày " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Day.ToString() + " tháng " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Month.ToString() + " năm " + DateTime.Parse(_BenhAn_Khoa.NgayVVTT).Year.ToString() + "'";
                Myformulasrv["PP"].Text = "'" + txtPhuongPhapDT.Text.Replace("\r\n", "|||||") + "'";
                Myformulasrv["LD"].Text = "'" + txtLoiDan.Text.Replace("\r\n", "|||||") + "'";
                Myformulasrv["tinhtrang"].Text = "'" + cboKQDT.SelectedItem.Text + "'";
                Myformulasrv["GC"].Text = "'" + txtGhiChu.Text.Replace("\r\n", "|||||") + "'";
                BenhAn_KhoaList kl = BenhAn_KhoaList.GetAllBenhAn_KhoaByMaBA(_MaBA);
                int sttkhoa = 1;
                if (kl.Count > 0)
                {
                    sttkhoa = kl[0].STTKhoa;
                }
                BenhAn_Noi kb = BenhAn_Noi.GetBenhAn_Noi(_MaBA, 1, sttkhoa);
                BenhAn_DY dy = BenhAn_DY.GetBenhAn_DY(_MaBA, 1, sttkhoa);
                Myformulasrv["chandoanRVtheoYHCT"].Text = "'" + (_BenhAnPK.MaICDravienYHCT != "" ? (_BenhAnPK.MaICDravienYHCT.Length >= 7 ? _BenhAnPK.MaICDravienYHCT.Substring(0, 7) : _BenhAnPK.MaICDravienYHCT) : "") + "-" + _BenhAnPK.TenBenhRaVienKKBYHCT + "'";
                Myformulasrv["phuongphapDY"].Text = "'" + dy.Phapdieutri.Replace("\r\n", "|||||") + "'";
                Myformulasrv["ChanDoanvvDY"].Text = "'" + dy.maICDKKB + "-" + dy.ChanDoanKKB + "'";
                Myformulasrv["bschoravien"].Text = "'" + cboBacSy.Text + "'";
                Myformulasrv["ttravien"].Text = "'" + txtTinhTrang.Text.Replace("\r\n", "|||||") + "'";
                Myformulasrv["LDVV"].Text = "'" + kb.LyDoKham.Replace("\r\n", "|||||") + "'";
                Myformulasrv["QTBL"].Text = "'" + txtBenhLy.Text.Replace("\r\n", "|||||") + "'";
                Myformulasrv["CLS"].Text = "'" + txtKetQuaCLS.Text.Replace("\r\n", "|||||") + "'";
                PrintExport(rptrv); rptrv.Dispose(); rptrv = null;//HTCReportViewer1.LoadReport(rpt, true, false);
            }
            if (cboHTravien.SelectedValue == "00005")
            {
                ReportDocument rpt2 = new ReportDocument();
                String sPath2 = "";
                if (HTC.ShareVariables.pub_spC == "PS")
                    sPath2 = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayChuyenTuyenPS_RPT.rpt";
                else if (HTC.ShareVariables.pub_spC == "PH")
                    sPath2 = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayChuyenTuyen_RPTP.rpt";
                else
                    sPath2 = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayChuyenTuyen_RPT.rpt";
                rpt2.Load(Server.MapPath(sPath2));
                Myformulas = rpt2.DataDefinition.FormulaFields;
                Myformulas["hoten"].Text = "'" + txtHoTen.Text.Replace("'", "''").ToUpper() + "'";
                Myformulas["GT"].Text = "'" + lblGioiTinh.Text + "'";
                Myformulas["Tuoi"].Text = "'" + _BenhAn_Khoa.NgaySinh.Substring(_BenhAn_Khoa.NgaySinh.Length - 4, 4) + "'";
                Myformulas["ngaysinh"].Text = "'" + _benhnhan.NgaySinh + "'";
                Myformulas["khoa"].Text = "'" + _BenhAn_Khoa.TenKhoa + "'";
                Myformulas["NgheNghiep"].Text = "'" + DMNgheNghiep.GetDMNgheNghiep(_benhnhan.MaNN).TenNN + "'";
                Myformulas["Dantoc"].Text = "'" + DMDantoc.GetDMDantoc(_benhnhan.MaDanToc).TenDanToc + "'";
                Myformulas["quoctich"].Text = "'" + DMQuocGia.GetDMQuocGia(_benhnhan.MaQG).TenQG + "'";
                Myformulas["Diachi"].Text = "'" + _BenhAn_Khoa.Diachi.Replace("'", "") + "'";
                Myformulas["TenDoiTuong"].Text = "'" + _BenhAn_Khoa.TenDT + "'";
                Myformulas["bvgui"].Text = "'" + txtTenBV.Text + "'";
                Myformulas["noichuyen"].Text = "'" + txtTenBV.Text.ToUpper() + "'";
                Myformulas["TuyenChuyenTruoc"].Text = "'" + _BenhAnPK.TenBVGT + "'";
                Myformulas["noilamviec"].Text = "'" + _benhnhan.NoiLamViec + "'";
                if (HTC.ShareVariables.pub_spC != "")
                    Myformulas["noichuyen"].Text = "'" + txtTenBV.Text + "'";
                if (HTC.ShareVariables.pub_spC != "PS")
                    Myformulas["noichuyen1"].Text = "'" + HTC.ShareVariables.pub_sTenBV + "'";
                if (HTC.ShareVariables.pub_spC == "PH")
                    Myformulas["GCHDT"].Text = "'" + txtGhiChu.Text.Replace("\r\n", "|||||") + "'";
                Myformulas["dauhieu"].Text = "'" + txtBenhLy.Text.Replace("\r\n", "|||||") + "'";
                Myformulas["dieutri"].Text = "'" + txtKetQuaCLS.Text.Replace("\r\n", "|||||") + "'";
                Myformulas["phuongphap"].Text = "'" + txtPhuongPhapDT.Text.Replace("\r\n", "|||||") + "'";
                Myformulas["tinhtrang"].Text = "'" + txtTinhTrang.Text.Replace("\r\n", "|||||") + "'";
                Myformulas["huongdt"].Text = "'" + txtLoiDan.Text.Replace("\r\n", "|||||") + "'";
                Myformulas["Huyen"].Text = "'" + DMQuanHuyen.GetDMQuanHuyen(_benhnhan.MaHuyen).TenQH + "'";
                Myformulas["Thanhpho"].Text = "'" + DMTinh.GetDMTinh(_benhnhan.MaTinh).TenTinh + "'";
                if (_BenhAn_Khoa.GiatriDN != "")
                    Myformulas["DenNgay"].Text = "'" + _BenhAn_Khoa.GiatriDN + "'";
                if (_BenhAn_Khoa.GiaTriTN != "")
                    Myformulas["TuNgay"].Text = "'" + _BenhAn_Khoa.GiaTriTN + "'";
                Myformulas["SoThe"].Text = "'" + _BenhAn_Khoa.Sothe + "'";
                if (HTC.ShareVariables.pub_spC == "PH")
                    Myformulas["VaoVien"].Text = "'" + _BenhAn_Khoa.NgayVVTT + "'";
                else
                    Myformulas["VaoVien"].Text = "'" + _BenhAn_Khoa.NgayVVTT.Substring(0, 10) + "'";
                Myformulas["ChanDoanVV"].Text = "'" + txtBenhVao.Text + "'";
                if (HTC.ShareVariables.pub_spC != "PH")
                {
                    Myformulas["ChanDoan"].Text = "'" + txtBenhRa.Text + "'";
                    Myformulas["ChanDoanKem"].Text = "'" + (txtBenhKem.Text != "" ? " , " + txtBenhKem.Text : "") + (txtChanDoanTheoYHCT.Text != "" ? " , " + txtChanDoanTheoYHCT.Text : "") + "'";
                }
                else
                {
                    Myformulas["GhiChu"].Text = "'" + txtGhiChuBenh.Text + "'";
                    Myformulas["ChanDoan"].Text = "'" + (_BenhAnPK.MaICDRaVien != "" ? (_BenhAnPK.MaICDRaVien.Length >= 5 ? _BenhAnPK.MaICDRaVien.Substring(0, 5) : _BenhAnPK.MaICDRaVien) : "") + "-" + _BenhAnPK.TenBenhRaVien + "'";
                    Myformulas["ChanDoanKem"].Text = "'" + (_BenhAnPK.maicdKem != "" ? (_BenhAnPK.maicdKem.Length >= 5 ? _BenhAnPK.maicdKem.Substring(0, 5) : _BenhAnPK.maicdKem) : "") + "-" + _BenhAnPK.tenbenhKem + "," + (_BenhAnPK.MaICDravienYHCT != "" ? (_BenhAnPK.MaICDravienYHCT.Length >= 5 ? _BenhAnPK.MaICDravienYHCT.Substring(0, 5) : _BenhAnPK.MaICDravienYHCT) : "") + "-" + _BenhAnPK.TenBenhRaVienKKBYHCT + "'";
                }
                //  Myformulas["RaVien"].Text = "'    giờ     phút, ngày " + dtngayravien.Text.Substring(0, 2) + " tháng " + dtngayravien.Text.Substring(3, 2) + " năm " + dtngayravien.Text.Substring(6, 4) + "'";
                if (HTC.ShareVariables.pub_spC != "PH")
                    Myformulas["RaVien"].Text = "'" + dtngayravien.Text + "'";
                else
                    Myformulas["RaVien"].Text = "'" + dtngayravien.Text.Substring(0, 10) + "'";
                // Myformulas["Ngaykham"].Text = "'" + _BenhAn_Khoa.NgayVVTT.Substring(0, 10) + "  đến ngày  " + dtngayravien.Text.Substring(0, 10) + "'";
                Myformulas["NgayBC"].Text = "'" + "Ngày " + DateTime.Now.Day.ToString() + "  tháng  " + DateTime.Now.Month.ToString() + "  năm  " + DateTime.Now.Year.ToString() + "'";
                Myformulas["MaBN"].Text = "'" + _BenhAn_Khoa.MaBN + "'";
                Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV + "'";
                Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan + "'";
                PrintExport(rpt2);//HTCReportViewer2.LoadReport(rpt2, true, false);
            }
            // neu co phau thuat
            BenhAn_PhauThuatList _benhan_phauthuatlist = BenhAn_PhauThuatList.GetAll(_BenhAn_Khoa.MaBA, false);
            if (_benhan_phauthuatlist.Count > 0)
            {
                foreach (BenhAn_PhauThuat bapt in _benhan_phauthuatlist)
                {
                    if (bapt.NoiDung != "")
                    {
                        BenhAn_PhauThuat _benhan_phauthuat = BenhAn_PhauThuat.GetBenhAn_PhauThuat(bapt.MaBA, bapt.STT, bapt.STTKhoa, pub_bQadmin);
                        //// GIAY HEN KHAM LAI
                        //if (_benhan_phauthuat != null && _benhan_phauthuat.CK == 0)
                        //    if (_BenhAn_Khoa.MaDT.Substring(0, 1) == "1")
                        //    {
                        //        ReportDocument rpt3 = new ReportDocument();
                        //        String sPath3 = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayHenKhamLai.rpt";
                        //        rpt3.Load(Server.MapPath(sPath3));
                        //        Myformulas = rpt3.DataDefinition.FormulaFields;
                        //        Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
                        //        Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
                        //        Myformulas["hoten"].Text = "'" + txthoten.Text.Replace("'", "''").ToUpper() + "'";
                        //        Myformulas["Tuoi"].Text = "'" + dtNgaySinh.Text.Substring(6, 4) + "'";
                        //        Myformulas["ngaypt"].Text = "'" + _benhan_phauthuat.NgayDKD.ToString() + "'";
                        //        Myformulas["SoThe"].Text = "'" + _BenhAnPK.Sothe.ToUpper() + "'";
                        //        Myformulas["DiaChi"].Text = "'" + _benhnhan.DiaChi + " " + _benhnhan.TenQH + " " + _benhnhan.TenTinh + "'";
                        //        Myformulas["GT"].Text = "'" + lblGioiTinh.Text + "'";
                        //        Myformulas["RaVien"].Text = "'" + dtngayravien.Text.Substring(0, 10) + "'";
                        //        if (_BenhAn_Khoa.NgayVVTT != "")
                        //            Myformulas["VaoVien"].Text = "'" + _BenhAn_Khoa.NgayVVTT + "'";
                        //        Myformulas["PhuongPhap"].Text = "'" + txtPhuongPhapDT.Text.Replace("\r\n", "|||||") + "'";
                        //        PrintExport(rpt3);//HTCReportViewer3.LoadReport(rpt3, true, false);
                        //    }
                        string xaupt = "";
                        foreach (BenhAn_PhauThuat_TV pttv in _benhan_phauthuat.BenhAn_PhauThuat_TVs)
                        {
                            if (xaupt == "" && pttv.VaiTro == 3)
                                xaupt = pttv.Hoten;
                            else if (pttv.VaiTro == 3)
                                xaupt = xaupt + " , " + pttv.Hoten;
                        }
                        ReportDocument rpt4 = new ReportDocument();
                        String sPath4 = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayChungNhanPhauThuat.rpt";
                        rpt4.Load(Server.MapPath(sPath4));
                        Myformulas = rpt4.DataDefinition.FormulaFields;
                        Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
                        Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
                        Myformulas["hoten"].Text = "'" + txtHoTen.Text.Replace("'", "''").ToUpper() + "'";
                        Myformulas["namsinh"].Text = "'" + dtNgaySinh.Text.Substring(6, 4) + "'";
                        Myformulas["pt"].Text = "'" + _benhan_phauthuat.NgayDK + "'";
                        Myformulas["phuongphap"].Text = "'" + (_benhan_phauthuat.ppphauthuat == "" ? _benhan_phauthuat.cecc : _benhan_phauthuat.ppphauthuat) + "'";
                        Myformulas["ptvien"].Text = "'" + xaupt + "'";
                        Myformulas["nhommau"].Text = "'" + _benhnhan.NhomMau + "'";
                        Myformulas["TenBVDu"].Text = "'" + ThamSo.GetThamSo().TenBV + "'";
                        Myformulas["cachgayme"].Text = "'" + _benhan_phauthuat.cachgayme + "'";
                        Myformulas["khoa"].Text = "'" + _BenhAn_Khoa.TenKhoa + "'";
                        Myformulas["chandoan"].Text = "'" + _benhan_phauthuat.TenBenhCDSauMo + "-" + _benhan_phauthuat.MaICDSauMo + "'";
                        Myformulas["kqgpb"].Text = "'" + _BenhAnPK.TenBenhGP + "-" + _BenhAnPK.MaICDGP + "'";
                        Myformulas["tinhhinhravien"].Text = "'" + DMKQDTri.GetDMKQDTri(_BenhAnPK.MaKQDT).TenKQDT + "'";
                        Myformulas["DiaChi"].Text = "'" + (_benhnhan.DiaChi + " " + _benhnhan.TenQH + " " + _benhnhan.TenTinh).Replace("'", "") + "'";
                        Myformulas["RaVien"].Text = "'" + dtngayravien.Text.Substring(0, 10) + "'";
                        if (_BenhAn_Khoa.NgayVVTT != "")
                            Myformulas["VaoVien"].Text = "'" + _BenhAn_Khoa.NgayVVTT + "'";
                        PrintExport(rpt4, bapt.STTKhoa.ToString() + "P" + bapt.STT.ToString());//HTCReportViewer4.LoadReport(rpt4, true, false);
                    }
                }
            }
            if (!(cboHTravien.SelectedValue == "00005" || cboHTravien.SelectedValue == "00006") && (HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "PS" || HTC.ShareVariables.pub_spC == "PH" || HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ " || HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ - CƠ SỞ 2" || (HTC.ShareVariables.pub_spC == "HU" && (_BenhAn_Khoa.MaKhoa == "026" || _BenhAn_Khoa.MaKhoa == "059"))))
            {
                ReportDocument rpth = new ReportDocument();
                sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayHenPK.rpt";
                rpth.Load(Server.MapPath(sPath));
                Myformulas = rpth.DataDefinition.FormulaFields;
                Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan + "'";
                Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV + "'";
                Myformulas["hoten"].Text = "'" + txtHoTen.Text.Replace("'", "''").ToUpper() + "'";
                Myformulas["Tuoi"].Text = "'" + dtNgaySinh.Text.Substring(6, 4) + "'";
                Myformulas["SoThe"].Text = "'" + _BenhAn_Khoa.Sothe + "'";
                Myformulas["MABN"].Text = "'" + txtMaQL.Text + "'";
                Myformulas["DiaChi"].Text = "'" + _BenhAn_Khoa.Diachi.Replace("'", "") + "'";
                Myformulas["GT"].Text = "'" + lblGioiTinh.Text + "'";
                Myformulas["ChanDoanngt"].Text = "'" + _BenhAnPK.TenBenhNGT + "'";
                Myformulas["mabenhngt"].Text = "'" + _BenhAnPK.maicdNGT + "'";
                Myformulas["chandoan"].Text = "'" + txtBenhRa.Text + "'";
                Myformulas["mabenh"].Text = "'" + (cbocdravien.Text == "" ? "" : cbocdravien.Text.Substring(0, 3)) + "'";
                Myformulas["noidk"].Text = "'" + _BenhAn_Khoa.mabhxh + "-" + _BenhAn_Khoa.TenBV + "'";
                Myformulas["noigt"].Text = "'" + _BenhAnPK.MABHXHGT + "-" + _BenhAnPK.TenBVGT + "'";
                Myformulas["HanSDTu"].Text = "'" + _BenhAn_Khoa.GiaTriTN + "'";
                Myformulas["HanSDDen"].Text = "'" + _BenhAn_Khoa.GiatriDN + "'";
                Myformulas["ChanDoanKem"].Text = "'" + (_BenhAnPK.maicdKem != "" ? _BenhAnPK.maicdKem : "") + "-" + _BenhAnPK.tenbenhKem + "'";
                //   Myformulas["vaovien"].Text = "' " + "    tháng " + "   năm " + "'";
                Myformulas["vaovien"].Text = "'" + dtNgayVaoKhoa.Text + "'";
                Myformulas["RaVien"].Text = "'" + dtngayravien.Text + "'";
                if (dtNgayVV.Text != "")
                    Myformulas["NgayHen"].Text = "'" + DateTime.Parse(dtNgayVV.Text).Day + " tháng " + DateTime.Parse(dtNgayVV.Text).Month + " năm " + DateTime.Parse(dtNgayVV.Text).Year + "'";
                else
                    Myformulas["NgayHen"].Text = "'ngày  " + "    tháng " + "   năm " + "'";
                //   Myformulas["RaVien"].Text = "'" + DateTime.Parse(dtNgayHen.Text).Day + " tháng " + DateTime.Parse(dtNgayHen.Text).Month + " năm " + DateTime.Parse(dtNgayHen.Text).Year + "'";
                Myformulas["NgayBC"].Text = "'Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year + "'";
                PrintExport(rpth); rpth.Dispose(); rpth = null;//HTCReportViewer6.LoadReport(rpt, true, false);
            }
            //benh nhan nghi viec huong BHXH
            if (dtngaycap_bhxh.Text.Trim().Length > 0)
            {

                ReportDocument rptnvbh = new ReportDocument();
                sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/crGiayCNNghiViecHuongBHXH.rpt";
                rptnvbh.Load(Server.MapPath(sPath));
                FormulaFieldDefinitions Myformulasnv = rptnvbh.DataDefinition.FormulaFields;
                Myformulasnv["Hoten"].Text = "'" + txtHoTen.Text.Replace("\r\n", "|||||") + "'";
                Myformulasnv["GT"].Text = "'" + lblGioiTinh.Text + "'";
                Myformulasnv["ChanDoan"].Text = "'" + cbocdravien.Text + "'";
                Myformulasnv["SoThe"].Text = "'" + (_BenhAn_Khoa.Sothe == "" ? _BenhAnPK.Sothe : _BenhAn_Khoa.Sothe).ToUpper() + "'";
                Myformulasnv["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
                Myformulasnv["TuNgay"].Text = "'" + dttungay_bhxh.Text.Substring(0, 10) + "'";
                Myformulasnv["DenNgay"].Text = "'" + dtdenngay_bhxh.Text.Substring(0, 10) + "'";
                Myformulasnv["Ngaysinh"].Text = "'" + dtNgaySinh.Text.Substring(0, 10) + "'";
                Myformulasnv["NoiLamViec"].Text = "'" + txtNoiLV.Text + "'";
                Myformulasnv["hotencha"].Text = "'" + txthotencha.Text + "'";
                Myformulasnv["hotenme"].Text = "'" + txthotenme.Text + "'";
                string ngaycap = "Ngày       tháng     năm      ";
                DateTime d;
                if (DateTime.TryParse(dtngaycap_bhxh.Text.Substring(0, 10), out d))
                    ngaycap = "Ngày " + d.ToString("dd") + " tháng " + d.ToString("MM") + " năm " + d.ToString("yyyy");
                //string ngaycap = "Ngày 1 tháng 9 năm 2020";
                Myformulasnv["ngaycap"].Text = "'" + ngaycap + "'";
                Myformulasnv["MaSoBHXH"].Text = "'" + txtMaSoBHXH.Text + "'";
                Myformulasnv["TenBS"].Text = "'" + cboBacSy.Text + "'";
                Myformulasnv["songaynghi"].Text = "'" + Math.Abs((DateTime.Parse(dtdenngay_bhxh.Text.Substring(0, 10)) - DateTime.Parse(dttungay_bhxh.Text.Substring(0, 10))).TotalDays).ToString() + "'";
                txtSoSeri.Text = spBenhAnPK_GetSeri(_MaBA);
                Myformulasnv["SoSeri"].Text = "'" + txtSoSeri.Text + "'";
                Myformulasnv["So"].Text = "'" + _MaBA + "'";
                PrintExport(rptnvbh); rptnvbh.Dispose(); rptnvbh = null;
            }
            return true;
        }
        catch (Exception ex)
        {
            ShowMessage("Không in được báo cáo" + ex.Message);
        }
        return true;
    }
    protected void cboBenh_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhTat dataItem = e.Item.DataItem as DMBenhTat;
        if (dataItem == null)
            e.Item.Attributes["TenBenh"] = "";
        else
            e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
    }
    protected void cboBenhYHCT_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        if (HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "QN")
        {
            DMBenhDanh dataItem = e.Item.DataItem as DMBenhDanh;
            if (dataItem == null)
                e.Item.Attributes["TenBenh"] = "";
            else
                e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
        }
        else
        {
            DMBenhTat dataItem = e.Item.DataItem as DMBenhTat;
            if (dataItem == null)
                e.Item.Attributes["TenBenh"] = "";
            else
                e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
        }
    }
    protected void cboBenhVien_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhVien dataItem = e.Item.DataItem as DMBenhVien;
        if (dataItem == null)
            e.Item.Attributes["TenBV"] = "";
        else
            e.Item.Attributes["TenBV"] = dataItem.TenBV.ToString();
    }
    protected void cboHuongDT_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboHuongDT.SelectedValue == "00007" || cboHuongDT.SelectedValue == "00107" || cboHuongDT.SelectedValue == "00207" || cboHuongDT.SelectedValue == "10007" || cboHuongDT.SelectedValue == "20007" || cboHuongDT.SelectedValue == "30007" || cboHuongDT.SelectedValue == "40007")
        {
            cboNoiDK.Enabled = true;
            txtTenBV.Enabled = true;
            dtNgayVV.Visible = false;
            Label16.Visible = false;
        }
        //else if (cboHuongDT.SelectedValue == "00014" )
        //{
        //    cboNoiDK.Enabled = false;
        //    txtTenBV.Enabled = false;
        //     Label19.Visible = true;
        //    dtNgayVV.Visible = true;
        //}
        else if (cboHuongDT.SelectedValue == "00020")
        {
            cboNoiDK.Enabled = false;
            txtTenBV.Enabled = false;
            dtNgayVV.Visible = true;
            Label16.Visible = true;
        }
        else
        {
            cboNoiDK.Enabled = false;
            txtTenBV.Enabled = false;
            dtNgayVV.Visible = false;
            Label16.Visible = false;
        }
    }
    protected void ObjectDanhMucNV_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        if (HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "PS")
            e.InputParameters["makhoa"] = _BenhAn_Khoa.MaKhoa;
        else
            e.InputParameters["makhoa"] = "";
    }
    #region DTDT
    //ham lay ma lien thong, pass cua bac si
    //public DataTable GetDTAccount(string Account, int lan = 0)
    //{
    //    DataTable dr = new DataTable();
    //    if (lan < 3)
    //    {
    //        string tenStore = "spAccount_GetDTDT";
    //        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
    //        using (SqlConnection Conection = new SqlConnection(StrConection))
    //        {
    //            Conection.Open();
    //            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //            {
    //                Command.CommandType = CommandType.StoredProcedure;
    //                Command.Parameters.Add(new SqlParameter("@Account", Account));
    //                SqlDataAdapter dp = new SqlDataAdapter(Command);
    //                dp.Fill(dr);
    //            }
    //            if (dr.Rows.Count > 0 && dr.Rows[0][0].ToString().Length > 0)
    //                return dr;
    //            else
    //                return GetDTAccount(Account, lan + 1);
    //        }
    //    }
    //    else
    //        return dr;
    //}
    //ham lay ma lien thong, pass cua bac si
    public DataTable GetDTAccount(string Account, int lan = 0)
    {
        DataTable dr = new DataTable();
        if (lan < 3)
        {
            string tenStore = "spAccount_GetDTDT_ByMaNV";
            string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
            using (SqlConnection Conection = new SqlConnection(StrConection))
            {
                Conection.Open();
                using (SqlCommand Command = new SqlCommand(tenStore, Conection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add(new SqlParameter("@manv", Account));
                    SqlDataAdapter dp = new SqlDataAdapter(Command);
                    dp.Fill(dr);
                }
                if (dr.Rows.Count > 0 && dr.Rows[0][0].ToString().Length > 0)
                    return dr;
                else
                    return GetDTAccount(Account, lan + 1);
            }
        }
        else
            return dr;
    }
    //ham lay url cua API lien thong DTDT
    public DataTable GetPort(string loai)
    {
        DataTable dr = new DataTable();
        string tenStore = "PACS_Port_Get";
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
    //ham lay ma don thuoc dien tu
    public static string GetMaxID()
    {
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        DataTable dr = new DataTable();
        string tenStore = "spKhamBenh_ThuocSD_MaxIDDTDT";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                //Command.Parameters.Add(new SqlParameter("@Loai", loai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            if (dr.Rows.Count > 0)
                return dr.Rows[0][0].ToString();
            else
                return "";
        }
        //DataSet ds = SqlHelpers.ExecuteDataset(StrConection, "spKhamBenh_ThuocSD_MaxIDDTDT");
        //if (ds != null)
        //{
        //    return ds.Tables[0].Rows[0][0].ToString();
        //}
        //else
        //{
        //    return "";
        //}
    }
    //Ham de ghi magiaodich vao bang hososuckhoe_lichsu 
    public void CreateMaGiaoDich(string masokham, string magiaodich, string thongbao, string trangthai, string mamay, string nguoilap, string chuoi)
    {
        DataTable dr = new DataTable();
        string tenStore = "spHoSoSucKhoe_LichSu_CREATE";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaSoKham", masokham));
                Command.Parameters.Add(new SqlParameter("@MaGiaoDich", magiaodich));
                Command.Parameters.Add(new SqlParameter("@ThongBao", thongbao));
                Command.Parameters.Add(new SqlParameter("@TrangThai", trangthai));
                Command.Parameters.Add(new SqlParameter("@MaMay", mamay));
                Command.Parameters.Add(new SqlParameter("@NguoiLap", nguoilap));
                Command.Parameters.Add(new SqlParameter("@Chuoi", chuoi));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
        }
    }
    //ham ghi log
    public static void WriteLog(string log)
    {
        string logname = "DTDT_Log_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
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
    //ham check don thuoc da gui hay chua
    public bool CheckDT(string masokham, int sttkhoa, string sttin, string dk)
    {
        bool kq = false;
        DataTable dr = new DataTable();
        string tenStore = "spBenhan_ThuocSD_CheckLT";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaSoKham", masokham));
                Command.Parameters.Add(new SqlParameter("@STTKhoa", sttkhoa));
                //Command.Parameters.Add(new SqlParameter("@NgayDk", ngaydk));
                Command.Parameters.Add(new SqlParameter("@sttin", sttin));
                Command.Parameters.Add(new SqlParameter("@DK", dk));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            if (dr.Rows.Count > 0)
                kq = true;
        }
        return kq;
    }
    public bool CheckDTDY(string masokham, int sttkhoa, string sttin, string dk)
    {
        bool kq = false;
        DataTable dr = new DataTable();
        string tenStore = "spBenhan_ThuocSD_CheckLTDY";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaSoKham", masokham));
                Command.Parameters.Add(new SqlParameter("@STTKhoa", sttkhoa));
                //Command.Parameters.Add(new SqlParameter("@NgayDk", ngaydk));
                Command.Parameters.Add(new SqlParameter("@sttin", sttin));
                Command.Parameters.Add(new SqlParameter("@DK", dk));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            if (dr.Rows.Count > 0)
                kq = true;
        }
        return kq;
    }
    //ham gui don thuoc
    public void GuiDonThuoc(IEnumerable<BenhAn_ThuocSD> don, string maloaidt, string account)
    {
        string mss = "";
        try
        {
            //lay ma lien thong don thuoc cua bac si
            //neu bs khong co ma lien thong thi khong duoc gui
            DataTable dtAC = dtAC = GetDTAccount(account);
            WriteLog("dtAC: " + dtAC);
            if (dtAC.Rows.Count > 0)
            {
                DTDTAPI rf = new DTDTAPI();
                string malienthongbs = dtAC.Rows[0][0].ToString();
                string passBS = dtAC.Rows[0][1].ToString();
                string portdnkcb = "";
                string username = "";
                string pass = "";
                string token = "";
                string loaitoken = "DTDT";
                DataTable dt = GetPort(loaitoken);
                if (dt.Rows.Count > 0)
                {
                    portdnkcb = dt.Rows[0][0].ToString();
                    username = dt.Rows[0][1].ToString();
                    pass = dt.Rows[0][2].ToString();
                }
                if (token != null && token.Length == 0)
                {
                    // ham  dang nhap bac si 
                    token = rf.dangnhapBS(portdnkcb, malienthongbs, passBS, username);
                    WriteLog("token: " + token);
                }
                BenhAn_Noi ban = BenhAn_Noi.GetBenhAn_Noi(_MaBA, _STT, _STTKhoa);
                ThongtinBN ttbn = ThongtinBN.GetThongtinBN(_BenhAn_Khoa.MaBN, DateTime.Now, 3);
                List<thongtindonthuoc> ttdt = new List<thongtindonthuoc>();
                string sttin = "";
                //string ngaydk = "";

                foreach (BenhAn_ThuocSD item in don)
                {
                    thongtindonthuoc t = new thongtindonthuoc();
                    t.biet_duoc = item.Tengoc;
                    t.ten_thuoc = item.TenTM;
                    t.don_vi_tinh = item.TenDVT;
                    t.so_luong = int.Parse(string.IsNullOrEmpty(item.SLMua) ? "0" : item.SLMua);
                    t.cach_dung = item.CachDung;
                    ttdt.Add(t);
                    sttin += item.STT + ",";
                    //ngaydk = don[i].NgayDK;
                }

                if (sttin.Length > 0)
                    sttin = sttin.Remove(sttin.Length - 1);
                mss += " / STT in: " + sttin;
                if (CheckDT(_MaBA, _STTKhoa, sttin, "") == false)
                {
                    donthuoc donthuoc = new donthuoc();
                    donthuoc.loai_don_thuoc = maloaidt;
                    //ma don thuoc = ma cs kcb + so tu sinh
                    //donthuoc.ma_don_thuoc = "45923" + "0000005";
                    donthuoc.ma_don_thuoc = GetMaxID();
                    donthuoc.ho_ten_benh_nhan = _BenhAn_Khoa.Hoten;
                    donthuoc.ma_dinh_danh_y_te = _BenhAn_Khoa.Sothe;
                    donthuoc.ma_dinh_danh_cong_dan = ttbn.SoCMT;
                    donthuoc.ngay_sinh_benh_nhan = ttbn.NgaySinhD;

                    //donthuoc.tuoi_benh_nhan = _BenhAn_Khoa.Tuoi;
                    string cannang = (string.IsNullOrEmpty(ban.CanNang) || ban.CanNang.Length == 0) ? "1" : ban.CanNang;
                    donthuoc.can_nang = decimal.Parse(cannang);
                    donthuoc.gioi_tinh = _BenhAn_Khoa.GT == true ? "Nam" : "Nữ";
                    donthuoc.ma_so_the_bao_hiem_y_te = _BenhAn_Khoa.Sothe;
                    donthuoc.thong_tin_nguoi_giam_ho = ttbn.BaoTin;
                    donthuoc.dia_chi = ttbn.DiaChi;
                    //List<string> cd = new List<string>();
                    //if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenh))
                    //    cd.Add(_BenhAn_Khoa.TenBenh);
                    //if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenhKem))
                    //    cd.Add(_BenhAn_Khoa.TenBenhKem);
                    ////if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenhChuyenKhoa))
                    ////    cd.Add(_BenhAn_Khoa.TenBenhChuyenKhoa);
                    ////if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenhPhanBiet))
                    ////    cd.Add(_BenhAn_Khoa.TenBenhPhanBiet);
                    //donthuoc.chuan_doan = cd;
                    //donthuoc.ma_chan_doan = _BenhAn_Khoa.MaBA;
                    //donthuoc.ten_chan_doan = _BenhAn_Khoa.TenBenh;
                    //donthuoc.ket_luan = "";
                    List<chandoan> lo = new List<chandoan>();
                    chandoan lol = new chandoan();
                    lol.ma_chan_doan = _BenhAn_Khoa.MaBA;
                    lol.ten_chan_doan = _BenhAn_Khoa.TenBenh;
                    lol.ket_luan = "";
                    lo.Add(lol);
                    donthuoc.chan_doan = lo;

                    donthuoc.luu_y = "";
                    donthuoc.hinh_thuc_dieu_tri = "";


                    List<dot_dung_thuoc> dot_Dung_Thuocs = new List<dot_dung_thuoc>();
                    dot_dung_thuoc dot_Dung_Thuoc = new dot_dung_thuoc();
                    dot_Dung_Thuoc.dot = 1;
                    DateTime tungay = DateTime.ParseExact(_BenhAnPK.NgayGioVV, "dd/MM/yyyy HH:mm:ss", null);
                    DateTime denngay = DateTime.ParseExact(_BenhAnPK.NgayGioVV, "dd/MM/yyyy HH:mm:ss", null);
                    dot_Dung_Thuoc.tu_ngay = tungay.ToString("dd/MM/yyyy");
                    dot_Dung_Thuoc.den_ngay = denngay.ToString("dd/MM/yyyy");
                    dot_Dung_Thuocs.Add(dot_Dung_Thuoc);

                    donthuoc.dot_dung_thuoc = dot_Dung_Thuocs;


                    List<thongtindonthuoc> li = new List<thongtindonthuoc>();
                    foreach (var item in don)
                    {
                        thongtindonthuoc lil = new thongtindonthuoc();
                        lil.ma_thuoc = item.Mathuoc;
                        lil.biet_duoc = item.Tengoc;
                        lil.ten_thuoc = item.TenTM;
                        lil.don_vi_tinh = item.TenDVT;
                        lil.so_luong = int.Parse(item.SLKeDon);
                        lil.cach_dung = item.CachDung;
                        donthuoc.loi_dan = item.BSChiDinh;
                        li.Add(lil);
                    }
                    donthuoc.thong_tin_don_thuoc = li;


                    string dthoai = "01234567890";
                    string sdt = ttbn.DienThoai.Length < 10 ? dthoai.Substring(0, 10 - ttbn.DienThoai.Length) + ttbn.DienThoai : ttbn.DienThoai;
                    donthuoc.so_dien_thoai_nguoi_kham_benh = sdt;
                    DateTime d, d1;
                    int ngayhen = 0;
                    if (DateTime.TryParse(_BenhAnPK.NgayGioCV, out d) && DateTime.TryParse(_BenhAnPK.NgayRaVien, out d1))
                        ngayhen = int.Parse((d - d1).TotalDays.ToString());
                    donthuoc.ngay_tai_kham = ngayhen;
                    donthuoc.ngay_gio_ke_don = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    donthuoc.signature = "";


                    //donthuoc.hinh_thuc_dieu_tri = "noitru";
                    //donthuoc.thong_tin_don_thuoc = ttdt;
                    //donthuoc.loi_dan = ban.DieuTri;
                    //donthuoc.so_dien_thoai_nguoi_kham_benh = ttbn.DienThoai;
                    var serializer = new JavaScriptSerializer();
                    string serializedResult = serializer.Serialize(donthuoc);
                    mss += " / " + serializedResult;
                    string result = rf.Gui_don_thuoc(portdnkcb, token, donthuoc);
                    mss += " / " + result;
                    //gui thanh cong ket qua tra ve
                    //{"success":"Gửi đơn thuốc thành công"}
                    string duoibang = "";
                    if (maloaidt == "y")
                        duoibang = "_DY";
                    //strore  benh an sd   ra vien noi tru 
                    if (result == "{\"success\":\"Gửi đơn thuốc thành công\"}")
                    {

                        string sql = "Update benhan_thuocSD " + duoibang + " set SoDTDT ='" + donthuoc.ma_don_thuoc + "' where isnull(huy,0)=0 and maba ='" + _MaBA + "' and sttkhoa=" + _STTKhoa + " in(" + sttin + ")";
                        WriteLog("sql" + sql);
                        HTC.Business.DataProvider.Instance().ExcSQL(sql);

                    }
                    else
                    {
                        WriteLog("da lien thong don thuoc: maBA:" + _MaBA + " STTKhoa: " + _STTKhoa + " sttin: " + sttin);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            WriteLog("Loi: " + mss + " " + ex.ToString());
        }
    }
    public void GuiDonThuocDY(BenhAn_ThuocSD_DYList don, string maloaidt, string account)
    {
        string mss = "";
        try
        {
            //lay ma lien thong don thuoc cua bac si
            //neu bs khong co ma lien thong thi khong duoc gui
            DataTable dtAC = dtAC = GetDTAccount(account);
            WriteLog("dtAC: " + dtAC);
            if (dtAC.Rows.Count > 0)
            {
                DTDTAPI rf = new DTDTAPI();
                string malienthongbs = dtAC.Rows[0][0].ToString();
                string passBS = dtAC.Rows[0][1].ToString();
                string portdnkcb = "";
                string username = "";
                string pass = "";
                string token = "";
                string loaitoken = "DTDT";
                DataTable dt = GetPort(loaitoken);
                if (dt.Rows.Count > 0)
                {
                    portdnkcb = dt.Rows[0][0].ToString();
                    username = dt.Rows[0][1].ToString();
                    pass = dt.Rows[0][2].ToString();
                }
                if (token != null && token.Length == 0)
                {
                    //ham dang nhap bac si   
                    token = rf.dangnhapBS(portdnkcb, malienthongbs, passBS, username);
                    WriteLog("token: " + token);
                }
                BenhAn_Noi ban = BenhAn_Noi.GetBenhAn_Noi(_MaBA, _STT, _STTKhoa);
                ThongtinBN ttbn = ThongtinBN.GetThongtinBN(_BenhAn_Khoa.MaBN, DateTime.Now, 3);
                List<thongtindonthuoc> ttdt = new List<thongtindonthuoc>();
                string sttin = "";
                //string ngaydk = "";
                for (int i = 0; i < don.Count; i++)
                {
                    for (int j = 0; j < don[i].BenhAn_ThuocSD_DY_Cs.Count; j++)
                    {
                        thongtindonthuoc t = new thongtindonthuoc();
                        t.biet_duoc = don[i].BenhAn_ThuocSD_DY_Cs[j].TenGoc;
                        t.ten_thuoc = don[i].BenhAn_ThuocSD_DY_Cs[j].TenTM;
                        t.don_vi_tinh = don[i].BenhAn_ThuocSD_DY_Cs[j].TenDVT;
                        t.so_luong = int.Parse(string.IsNullOrEmpty(don[i].SLMua) ? "0" : don[i].SLMua);
                        t.cach_dung = don[i].CachDung;
                        ttdt.Add(t);
                        sttin += don[i].STT + ",";
                    }
                    //ngaydk = don[i].NgaySD;
                }
                if (sttin.Length > 0)
                    sttin = sttin.Remove(sttin.Length - 1);
                mss += " / STT in: " + sttin;
                if (CheckDTDY(_MaBA, _STTKhoa, sttin, "") == false)
                {
                    donthuoc donthuoc = new donthuoc();
                    donthuoc.loai_don_thuoc = maloaidt;
                    //ma don thuoc = ma cs kcb + so tu sinh
                    //donthuoc.ma_don_thuoc = "45923" + "0000005";
                    donthuoc.ma_don_thuoc = GetMaxID() + "-y";
                    donthuoc.ho_ten_benh_nhan = _BenhAn_Khoa.Hoten;
                    donthuoc.ma_dinh_danh_y_te = _BenhAn_Khoa.Sothe;
                    donthuoc.ma_dinh_danh_cong_dan = ttbn.SoCMT;
                    donthuoc.ngay_sinh_benh_nhan = ttbn.NgaySinhD;



                    //donthuoc.tuoi_benh_nhan = _BenhAn_Khoa.Tuoi;
                    //donthuoc.can_nang = decimal.Parse(ban.CanNang);
                    string cannang = (string.IsNullOrEmpty(ban.CanNang) || ban.CanNang.Length == 0) ? "1" : ban.CanNang;
                    donthuoc.can_nang = decimal.Parse(cannang);
                    donthuoc.gioi_tinh = _BenhAn_Khoa.GT == true ? "Nam" : "Nữ";
                    donthuoc.ma_so_the_bao_hiem_y_te = _BenhAn_Khoa.Sothe;
                    donthuoc.thong_tin_nguoi_giam_ho = ttbn.BaoTin;
                    donthuoc.dia_chi = ttbn.DiaChi;
                    //List<string> cd = new List<string>();
                    //if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenh))
                    //    cd.Add(_BenhAn_Khoa.TenBenh);
                    //if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenhKem))
                    //    cd.Add(_BenhAn_Khoa.TenBenhKem);
                    //if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenhChuyenKhoa))
                    //    cd.Add(_BenhAn_Khoa.TenBenhChuyenKhoa);
                    //if (!string.IsNullOrEmpty(_BenhAn_Khoa.TenBenhPhanBiet))
                    //    cd.Add(_BenhAn_Khoa.TenBenhPhanBiet);

                    List<chandoan> no = new List<chandoan>();
                    chandoan non = new chandoan();
                    non.ma_chan_doan = _BenhAn_Khoa.MaBA;
                    non.ten_chan_doan = _BenhAn_Khoa.TenBenh;
                    non.ket_luan = _BenhAn_Khoa.TenBenh;
                    no.Add(non);
                    donthuoc.chan_doan = no;

                    donthuoc.luu_y = "";
                    donthuoc.hinh_thuc_dieu_tri = "";



                    List<dot_dung_thuoc> dot_Dung_Thuocs = new List<dot_dung_thuoc>();
                    dot_dung_thuoc dot_Dung_Thuoc = new dot_dung_thuoc();
                    dot_Dung_Thuoc.dot = 1;
                    DateTime tungay = DateTime.ParseExact(_BenhAnPK.NgayGioVV, "dd/MM/yyyy HH:mm:ss", null);
                    DateTime denngay = DateTime.ParseExact(_BenhAnPK.NgayGioVV, "dd/MM/yyyy HH:mm:ss", null);
                    dot_Dung_Thuoc.tu_ngay = tungay.ToString("dd/MM/yyyy");
                    dot_Dung_Thuoc.den_ngay = denngay.ToString("dd/MM/yyyy");
                    dot_Dung_Thuocs.Add(dot_Dung_Thuoc);
                    donthuoc.dot_dung_thuoc = dot_Dung_Thuocs;
                    donthuoc.luu_y = "";

                    List<thongtindonthuoc> ni = new List<thongtindonthuoc>();
                    foreach (var item in don)
                    {
                        foreach (var thuocdongY in item.BenhAn_ThuocSD_DY_Cs)
                        {
                            thongtindonthuoc nin = new thongtindonthuoc();
                            nin.ma_thuoc = thuocdongY.Mathuoc;
                            nin.biet_duoc = thuocdongY.TenGoc;
                            nin.ten_thuoc = thuocdongY.TenTM;
                            nin.don_vi_tinh = thuocdongY.TenDVT;
                            nin.so_luong = int.Parse(thuocdongY.SLKeDon);
                            nin.cach_dung = "";

                            donthuoc.loi_dan = "";
                            ni.Add(nin);
                        }
                    }

                    donthuoc.thong_tin_don_thuoc = ni;


                    //donthuoc.hinh_thuc_dieu_tri = "noitru";
                    donthuoc.loi_dan = ban.DieuTri;
                    //donthuoc.so_dien_thoai_nguoi_kham_benh = ttbn.DienThoai;
                    string dthoai = "01234567890";
                    string sdt = ttbn.DienThoai.Length < 10 ? dthoai.Substring(0, 10 - ttbn.DienThoai.Length) + ttbn.DienThoai : ttbn.DienThoai;
                    donthuoc.so_dien_thoai_nguoi_kham_benh = sdt;
                    DateTime d, d1;
                    int ngayhen = 0;
                    if (DateTime.TryParse(_BenhAnPK.NgayGioCV, out d) && DateTime.TryParse(_BenhAnPK.NgayRaVien, out d1))
                        ngayhen = int.Parse((d - d1).TotalDays.ToString());
                    donthuoc.ngay_tai_kham = ngayhen;
                    var serializer = new JavaScriptSerializer();
                    string serializedResult = serializer.Serialize(donthuoc);
                    WriteLog("serializedResult: " + serializedResult);
                    mss += " / " + serializedResult;
                    //ham gui don thuoc  
                    string result = rf.Gui_don_thuoc(portdnkcb, token, donthuoc);
                    WriteLog("result: " + result);
                    mss += " / " + result;
                    //gui thanh cong ket qua tra ve
                    //{"success":"Gửi đơn thuốc thành công"}
                    string duoibang = "";
                    if (maloaidt == "y")
                        duoibang = "_DY";
                    //strore  benh an sd   ra vien noi tru dong y   
                    if (result == "{\"success\":\"Gửi đơn thuốc thành công\"}")
                    {
                        string sql = "Update benhan_thuocSD_DY " + duoibang + " set SoDTDT ='" + donthuoc.ma_don_thuoc + "' where isnull(huy,0)=0 and maba ='" + _MaBA + "' and sttkhoa=" + _STTKhoa + " and stt in(" + sttin + ")";
                        WriteLog("sql" + sql);
                        HTC.Business.DataProvider.Instance().ExcSQL(sql);
                    }
                }
                else
                {
                    WriteLog("da lien thong don thuoc: maBA:" + _MaBA + " STTKhoa: " + _STTKhoa + " sttin: " + sttin);
                }
            }
        }
        catch (Exception ex)
        {
            WriteLog("Loi: " + mss + " " + ex.ToString());
        }
    }
    #region object RESTful
    //object phan API đăng nhập lấy phiên làm việc
    //object gui username, pass
    [Serializable()]
    public class dangnhapcosokhamchuabenh
    {
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
        private string Password = string.Empty;
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
    //object lay token tra ve
    [Serializable()]
    public class dangnhapbacsi_return_data
    {
        private string Token = string.Empty;
        public string token
        {
            get
            {
                return Token;
            }
            set
            {
                Token = value;
            }
        }
        private string Token_type = string.Empty;
        public string token_type
        {
            get
            {
                return Token_type;
            }
            set
            {
                Token_type = value;
            }
        }
    }
    [Serializable()]
    public class dangnhapbacsi
    {
        private string Ma_lien_thong_bac_si = string.Empty;
        public string ma_lien_thong_bac_si
        {
            get
            {
                return Ma_lien_thong_bac_si;
            }
            set
            {
                Ma_lien_thong_bac_si = value;
            }
        }
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
        private string Password = string.Empty;
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
    //object phan Tạo đơn thuốc từ cơ sở khám chữa bệnh
    [Serializable()]
    public class donthuoc
    {
        private string Loai_don_thuoc = string.Empty;
        public string loai_don_thuoc
        {
            get
            {
                return Loai_don_thuoc;
            }
            set
            {
                Loai_don_thuoc = value;
            }
        }
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }
        private string Ho_ten_benh_nhan = string.Empty;
        public string ho_ten_benh_nhan
        {
            get
            {
                return Ho_ten_benh_nhan;
            }
            set
            {
                Ho_ten_benh_nhan = value;
            }
        }
        private string Ma_dinh_danh_y_te = string.Empty;
        public string ma_dinh_danh_y_te
        {
            get
            {
                return Ma_dinh_danh_y_te;
            }
            set
            {
                Ma_dinh_danh_y_te = value;
            }
        }
        private string Ma_dinh_danh_cong_dan = string.Empty;
        public string ma_dinh_danh_cong_dan
        {
            get
            {
                return Ma_dinh_danh_cong_dan;
            }
            set
            {
                Ma_dinh_danh_cong_dan = value;
            }
        }
        private string Ngay_sinh_benh_nhan = string.Empty;
        public string ngay_sinh_benh_nhan
        {
            get
            {
                return Ngay_sinh_benh_nhan;
            }
            set
            {
                Ngay_sinh_benh_nhan = value;
            }
        }
        private decimal Can_nang = 0;
        public decimal can_nang
        {
            get
            {
                return Can_nang;
            }
            set
            {
                Can_nang = value;
            }
        }
        private string Gioi_tinh = string.Empty;
        public string gioi_tinh
        {
            get
            {
                return Gioi_tinh;
            }
            set
            {
                Gioi_tinh = value;
            }
        }
        private string Ma_so_the_bao_hiem_y_te = string.Empty;
        public string ma_so_the_bao_hiem_y_te
        {
            get
            {
                return Ma_so_the_bao_hiem_y_te;
            }
            set
            {
                Ma_so_the_bao_hiem_y_te = value;
            }
        }
        private string Thong_tin_nguoi_giam_ho = string.Empty;
        public string thong_tin_nguoi_giam_ho
        {
            get
            {
                return Thong_tin_nguoi_giam_ho;
            }
            set
            {
                Thong_tin_nguoi_giam_ho = value;
            }
        }
        private string Dia_chi = string.Empty;
        public string dia_chi
        {
            get
            {
                return Dia_chi;
            }
            set
            {
                Dia_chi = value;
            }
        }
        private List<chandoan> Chan_doan;
        public List<chandoan> chan_doan
        {
            get
            {
                if (Chan_doan == null)
                    Chan_doan = new List<chandoan>();
                return Chan_doan;
            }
            set
            {
                Chan_doan = value;
            }
        }
        private string Luu_y = string.Empty;
        public string luu_y
        {
            get
            {
                return Luu_y;
            }
            set
            {
                Luu_y = value;
            }
        }
        private string Hinh_thuc_dieu_tri = string.Empty;
        public string hinh_thuc_dieu_tri
        {
            get
            {
                return Hinh_thuc_dieu_tri;
            }
            set
            {
                Hinh_thuc_dieu_tri = value;
            }
        }
        private List<dot_dung_thuoc> Dot_dung_thuoc;
        public List<dot_dung_thuoc> dot_dung_thuoc
        {
            get
            {
                if (Dot_dung_thuoc == null)
                    Dot_dung_thuoc = new List<dot_dung_thuoc>();
                return Dot_dung_thuoc;
            }
            set
            {
                Dot_dung_thuoc = value;
            }
        }
        private List<thongtindonthuoc> Thong_tin_don_thuoc;
        public List<thongtindonthuoc> thong_tin_don_thuoc
        {
            get
            {
                if (Thong_tin_don_thuoc == null)
                    Thong_tin_don_thuoc = new List<thongtindonthuoc>();
                return Thong_tin_don_thuoc;
            }
            set
            {
                Thong_tin_don_thuoc = value;
            }
        }
        private string Loi_dan = string.Empty;
        public string loi_dan
        {
            get
            {
                return Loi_dan;
            }
            set
            {
                Loi_dan = value;
            }
        }
        private string So_dien_thoai_nguoi_kham_benh = string.Empty;
        public string so_dien_thoai_nguoi_kham_benh
        {
            get
            {
                return So_dien_thoai_nguoi_kham_benh;
            }
            set
            {
                So_dien_thoai_nguoi_kham_benh = value;
            }
        }
        private int Ngay_tai_kham;
        public int ngay_tai_kham
        {
            get
            {
                return Ngay_tai_kham;
            }
            set
            {
                Ngay_tai_kham = value;
            }
        }
        private string Ngay_gio_ke_don = string.Empty;
        public string ngay_gio_ke_don
        {
            get
            {
                return Ngay_gio_ke_don;
            }
            set
            {
                Ngay_gio_ke_don = value;
            }
        }
        private string Signature = string.Empty;
        public string signature
        {
            get
            {
                return Signature;
            }
            set
            {
                Signature = value;
            }
        }
    }
    [Serializable()]

    public class donthuoccn
    {
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }

        private List<thongtinthuoc> Thong_tin_thuoc;
        public List<thongtinthuoc> thong_tin_thuoc
        {
            get
            {
                if (Thong_tin_thuoc == null)
                    Thong_tin_thuoc = new List<thongtinthuoc>();
                return Thong_tin_thuoc;
            }
            set
            {
                Thong_tin_thuoc = value;
            }
        }

        private string Ma_dinh_danh_co_so_cung_ung_thuoc = string.Empty;
        public string ma_dinh_danh_co_so_cung_ung_thuoc
        {
            get
            {
                return Ma_dinh_danh_co_so_cung_ung_thuoc;
            }
            set
            {
                Ma_dinh_danh_co_so_cung_ung_thuoc = value;
            }
        }

        private string Ten_co_so_cung_ung_thuoc = string.Empty;
        public string ten_co_so_cung_ung_thuoc
        {
            get
            {
                return Ten_co_so_cung_ung_thuoc;
            }
            set
            {
                Ten_co_so_cung_ung_thuoc = value;
            }
        }

        private string So_dien_thoai_co_so_cung_ung_thuoc = string.Empty;
        public string so_dien_thoai_co_so_cung_ung_thuoc
        {
            get
            {
                return So_dien_thoai_co_so_cung_ung_thuoc;
            }
            set
            {
                So_dien_thoai_co_so_cung_ung_thuoc = value;
            }
        }

        private string Dia_chi_co_so_cung_ung_thuoc = string.Empty;
        public string dia_chi_co_so_cung_ung_thuoc
        {
            get
            {
                return Dia_chi_co_so_cung_ung_thuoc;
            }
            set
            {
                Dia_chi_co_so_cung_ung_thuoc = value;
            }
        }

        private string Ma_hoa_don = string.Empty;
        public string ma_hoa_don
        {
            get
            {
                return Ma_hoa_don;
            }
            set
            {
                Ma_hoa_don = value;
            }
        }
    }

    public class thongtinthuoc
    {
        private string Ma_thuoc_da_ke_don = string.Empty;
        public string ma_thuoc_da_ke_don
        {
            get
            {
                return Ma_thuoc_da_ke_don;
            }
            set
            {
                Ma_thuoc_da_ke_don = value;
            }
        }
        private string Ma_thuoc = string.Empty;
        public string ma_thuoc
        {
            get
            {
                return Ma_thuoc;
            }
            set
            {
                Ma_thuoc = value;
            }
        }
        private string Biet_duoc = string.Empty;
        public string biet_duoc
        {
            get
            {
                return Biet_duoc;
            }
            set
            {
                Biet_duoc = value;
            }
        }
        private string Ten_thuoc = string.Empty;
        public string ten_thuoc
        {
            get
            {
                return Ten_thuoc;
            }
            set
            {
                Ten_thuoc = value;
            }
        }

        private string Don_vi_tinh = string.Empty;
        public string don_vi_tinh
        {
            get
            {
                return Don_vi_tinh;
            }
            set
            {
                Don_vi_tinh = value;
            }
        }

        private int So_luong = 0;
        public int so_luong
        {
            get
            {
                return So_luong;
            }
            set
            {
                So_luong = value;
            }
        }

        private int So_luong_ban = 0;
        public int so_luong_ban
        {
            get
            {
                return So_luong_ban;
            }
            set
            {
                So_luong_ban = value;
            }
        }



        private string Cach_dung = string.Empty;
        public string cach_dung
        {
            get
            {
                return Cach_dung;
            }
            set
            {
                Cach_dung = value;
            }
        }
    }
    public class dot_dung_thuoc
    {
        private int Dot = 0;
        public int dot
        {
            get
            {
                return Dot;
            }
            set
            {
                Dot = value;
            }
        }
        private string Tu_ngay = string.Empty;
        public string tu_ngay
        {
            get
            {
                return Tu_ngay;
            }
            set
            {
                Tu_ngay = value;
            }
        }
        private string Den_ngay = string.Empty;
        public string den_ngay
        {
            get
            {
                return Den_ngay;
            }
            set
            {
                Den_ngay = value;
            }
        }
        private int So_thang_thuoc = 0;
        public int so_thang_thuoc
        {
            get
            {
                return So_thang_thuoc;
            }
            set
            {
                So_thang_thuoc = value;
            }
        }
    }
    //[Serializable()]
    //public class thong_tin_don_thuoc
    //{
    //    private string Biet_duoc = string.Empty;
    //    public string biet_duoc
    //    {
    //        get
    //        {
    //            return Biet_duoc;
    //        }
    //        set
    //        {
    //            Biet_duoc = value;
    //        }
    //    }
    //    private string Ten_thuoc = string.Empty;
    //    public string ten_thuoc
    //    {
    //        get
    //        {
    //            return Ten_thuoc;
    //        }
    //        set
    //        {
    //            Ten_thuoc = value;
    //        }
    //    }
    //    private string Don_vi_tinh = string.Empty;
    //    public string don_vi_tinh
    //    {
    //        get
    //        {
    //            return Don_vi_tinh;
    //        }
    //        set
    //        {
    //            Don_vi_tinh = value;
    //        }
    //    }
    //    private decimal So_luong = 0;
    //    public decimal so_luong
    //    {
    //        get
    //        {
    //            return So_luong;
    //        }
    //        set
    //        {
    //            So_luong = value;
    //        }
    //    }
    //    private string Cach_dung = string.Empty;
    //    public string cach_dung
    //    {
    //        get
    //        {
    //            return Cach_dung;
    //        }
    //        set
    //        {
    //            Cach_dung = value;
    //        }
    //    }
    //}
    [Serializable()]
    public class dangkybacsi
    {
        private string Ho_ten = string.Empty;
        public string ho_ten
        {
            get
            {
                return Ho_ten;
            }
            set
            {
                Ho_ten = value;
            }
        }
        private string Ngay_sinh = string.Empty;
        public string ngay_sinh
        {
            get
            {
                return Ngay_sinh;
            }
            set
            {
                Ngay_sinh = value;
            }
        }
        private string So_chung_chi_hanh_nghe = string.Empty;
        public string so_chung_chi_hanh_nghe
        {
            get
            {
                return So_chung_chi_hanh_nghe;
            }
            set
            {
                So_chung_chi_hanh_nghe = value;
            }
        }
        private string Ngay_cap_chung_chi_hanh_nghe = string.Empty;
        public string ngay_cap_chung_chi_hanh_nghe
        {
            get
            {
                return Ngay_cap_chung_chi_hanh_nghe;
            }
            set
            {
                Ngay_cap_chung_chi_hanh_nghe = value;
            }
        }
        private string Noi_cap_chung_chi_hanh_nghe = string.Empty;
        public string noi_cap_chung_chi_hanh_nghe
        {
            get
            {
                return Noi_cap_chung_chi_hanh_nghe;
            }
            set
            {
                Noi_cap_chung_chi_hanh_nghe = value;
            }
        }
        private string So_chung_minh_thu = string.Empty;
        public string so_chung_minh_thu
        {
            get
            {
                return So_chung_minh_thu;
            }
            set
            {
                So_chung_minh_thu = value;
            }
        }
        private string Ngay_cap_chung_minh_thu = string.Empty;
        public string ngay_cap_chung_minh_thu
        {
            get
            {
                return Ngay_cap_chung_minh_thu;
            }
            set
            {
                Ngay_cap_chung_minh_thu = value;
            }
        }
        private string Noi_cap_chung_minh_thu = string.Empty;
        public string noi_cap_chung_minh_thu
        {
            get
            {
                return Noi_cap_chung_minh_thu;
            }
            set
            {
                Noi_cap_chung_minh_thu = value;
            }
        }
        private string Dia_chi_thanh_pho = string.Empty;
        public string dia_chi_thanh_pho
        {
            get
            {
                return Dia_chi_thanh_pho;
            }
            set
            {
                Dia_chi_thanh_pho = value;
            }
        }
        private string Dia_chi_quan_huyen = string.Empty;
        public string dia_chi_quan_huyen
        {
            get
            {
                return Dia_chi_quan_huyen;
            }
            set
            {
                Dia_chi_quan_huyen = value;
            }
        }
        private string Dia_chi_phuong_xa = string.Empty;
        public string dia_chi_phuong_xa
        {
            get
            {
                return Dia_chi_phuong_xa;
            }
            set
            {
                Dia_chi_phuong_xa = value;
            }
        }
        private string Dia_chi_chi_tiet = string.Empty;
        public string dia_chi_chi_tiet
        {
            get
            {
                return Dia_chi_chi_tiet;
            }
            set
            {
                Dia_chi_chi_tiet = value;
            }
        }
        private string Email = string.Empty;
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        private string Dien_thoai = string.Empty;
        public string dien_thoai
        {
            get
            {
                return Dien_thoai;
            }
            set
            {
                Dien_thoai = value;
            }
        }
        private string Van_bang_chuyen_mon = string.Empty;
        public string van_bang_chuyen_mon
        {
            get
            {
                return Van_bang_chuyen_mon;
            }
            set
            {
                Van_bang_chuyen_mon = value;
            }
        }
        private List<thoi_gian_lam_viec> Thoi_gian_lam_viec;
        public List<thoi_gian_lam_viec> thoi_gian_lam_viec
        {
            get
            {
                if (Thoi_gian_lam_viec == null)
                    Thoi_gian_lam_viec = new List<thoi_gian_lam_viec>();
                return Thoi_gian_lam_viec;
            }
            set
            {
                Thoi_gian_lam_viec = value;
            }
        }
        private List<string> File_giay_chung_nhan_hanh_nghe;
        public List<string> file_giay_chung_nhan_hanh_nghe
        {
            get
            {
                if (File_giay_chung_nhan_hanh_nghe == null)
                    File_giay_chung_nhan_hanh_nghe = new List<string>();
                return File_giay_chung_nhan_hanh_nghe;
            }
            set
            {
                File_giay_chung_nhan_hanh_nghe = value;
            }
        }
        private string File_anh_dai_dien = string.Empty;
        public string file_anh_dai_dien
        {
            get
            {
                return File_anh_dai_dien;
            }
            set
            {
                File_anh_dai_dien = value;
            }
        }
        private List<string> Linh_vuc;
        public List<string> linh_vuc
        {
            get
            {
                if (Linh_vuc == null)
                    Linh_vuc = new List<string>();
                return Linh_vuc;
            }
            set
            {
                Linh_vuc = value;
            }
        }
        private string Don_vi_khai_bao = string.Empty;
        public string don_vi_khai_bao
        {
            get
            {
                return Don_vi_khai_bao;
            }
            set
            {
                Don_vi_khai_bao = value;
            }
        }
    }
    [Serializable()]
    public class thoi_gian_lam_viec
    {
        private string Ten_don_vi = string.Empty;
        public string ten_don_vi
        {
            get
            {
                return Ten_don_vi;
            }
            set
            {
                Ten_don_vi = value;
            }
        }
        private string Dia_chi_don_vi = string.Empty;
        public string dia_chi_don_vi
        {
            get
            {
                return Dia_chi_don_vi;
            }
            set
            {
                Dia_chi_don_vi = value;
            }
        }
        private string _thoi_gian_lam_viec = string.Empty;
        public string Thoi_gian_lam_viec
        {
            get
            {
                return _thoi_gian_lam_viec;
            }
            set
            {
                _thoi_gian_lam_viec = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongbacsi
    {
        private string So_chung_chi_hanh_nghe_bac_si = string.Empty;
        public string so_chung_chi_hanh_nghe_bac_si
        {
            get
            {
                return So_chung_chi_hanh_nghe_bac_si;
            }
            set
            {
                So_chung_chi_hanh_nghe_bac_si = value;
            }
        }
        private string Ma_lien_thong_bac_si = string.Empty;
        public string ma_lien_thong_bac_si
        {
            get
            {
                return Ma_lien_thong_bac_si;
            }
            set
            {
                Ma_lien_thong_bac_si = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongbacsi_return_data
    {
        private string Ma_lien_thong_bac_si = string.Empty;
        public string ma_lien_thong_bac_si
        {
            get
            {
                return Ma_lien_thong_bac_si;
            }
            set
            {
                Ma_lien_thong_bac_si = value;
            }
        }
        private string Message = string.Empty;
        public string message
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
            }
        }
    }
    //object nhan ket qua tra ve khi thao tac voi don thuoc
    [Serializable()]
    public class dangkycosokhamchuabenh
    {
        private string So_giay_phep = string.Empty;
        public string so_giay_phep
        {
            get
            {
                return So_giay_phep;
            }
            set
            {
                So_giay_phep = value;
            }
        }
        private string Ngay_cap_giay_phep = string.Empty;
        public string ngay_cap_giay_phep
        {
            get
            {
                return Ngay_cap_giay_phep;
            }
            set
            {
                Ngay_cap_giay_phep = value;
            }
        }
        private string Noi_cap_giay_phep = string.Empty;
        public string noi_cap_giay_phep
        {
            get
            {
                return Noi_cap_giay_phep;
            }
            set
            {
                Noi_cap_giay_phep = value;
            }
        }
        private string Ten_co_so = string.Empty;
        public string ten_co_so
        {
            get
            {
                return Ten_co_so;
            }
            set
            {
                Ten_co_so = value;
            }
        }
        private string Ten_nguoi_dai_dien = string.Empty;
        public string ten_nguoi_dai_dien
        {
            get
            {
                return Ten_nguoi_dai_dien;
            }
            set
            {
                Ten_nguoi_dai_dien = value;
            }
        }
        private string So_chung_chi_hanh_nghe = string.Empty;
        public string so_chung_chi_hanh_nghe
        {
            get
            {
                return So_chung_chi_hanh_nghe;
            }
            set
            {
                So_chung_chi_hanh_nghe = value;
            }
        }
        private string Noi_cap_chung_chi_hanh_nghe = string.Empty;
        public string noi_cap_chung_chi_hanh_nghe
        {
            get
            {
                return Noi_cap_chung_chi_hanh_nghe;
            }
            set
            {
                Noi_cap_chung_chi_hanh_nghe = value;
            }
        }
        private string Dia_chi_hanh_nghe_thanh_pho = string.Empty;
        public string dia_chi_hanh_nghe_thanh_pho
        {
            get
            {
                return Dia_chi_hanh_nghe_thanh_pho;
            }
            set
            {
                Dia_chi_hanh_nghe_thanh_pho = value;
            }
        }
        private string Dia_chi_hanh_nghe_quan_huyen = string.Empty;
        public string dia_chi_hanh_nghe_quan_huyen
        {
            get
            {
                return Dia_chi_hanh_nghe_quan_huyen;
            }
            set
            {
                Dia_chi_hanh_nghe_quan_huyen = value;
            }
        }
        private string Dia_chi_hanh_nghe_phuong_xa = string.Empty;
        public string dia_chi_hanh_nghe_phuong_xa
        {
            get
            {
                return Dia_chi_hanh_nghe_phuong_xa;
            }
            set
            {
                Dia_chi_hanh_nghe_phuong_xa = value;
            }
        }
        private string Dia_chi_hanh_nghe_chi_tiet = string.Empty;
        public string dia_chi_hanh_nghe_chi_tiet
        {
            get
            {
                return Dia_chi_hanh_nghe_chi_tiet;
            }
            set
            {
                Dia_chi_hanh_nghe_chi_tiet = value;
            }
        }
        private string Email = string.Empty;
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        private string Dien_thoai = string.Empty;
        public string dien_thoai
        {
            get
            {
                return Dien_thoai;
            }
            set
            {
                Dien_thoai = value;
            }
        }
        private List<thoi_gian_hoat_dong> Thoi_gian_hoat_dong;
        public List<thoi_gian_hoat_dong> thoi_gian_hoat_dong
        {
            get
            {
                if (Thoi_gian_hoat_dong == null)
                    Thoi_gian_hoat_dong = new List<thoi_gian_hoat_dong>();
                return Thoi_gian_hoat_dong;
            }
            set
            {
                Thoi_gian_hoat_dong = value;
            }
        }
        private List<string> Pham_vi_hoat_dong_chuyen_mon;
        public List<string> pham_vi_hoat_dong_chuyen_mon
        {
            get
            {
                if (Pham_vi_hoat_dong_chuyen_mon == null)
                    Pham_vi_hoat_dong_chuyen_mon = new List<string>();
                return Pham_vi_hoat_dong_chuyen_mon;
            }
            set
            {
                Pham_vi_hoat_dong_chuyen_mon = value;
            }
        }
        private string Hinh_thuc_to_chuc = string.Empty;
        public string hinh_thuc_to_chuc
        {
            get
            {
                return Hinh_thuc_to_chuc;
            }
            set
            {
                Hinh_thuc_to_chuc = value;
            }
        }
        private string File_giay_phep = string.Empty;
        public string file_giay_phep
        {
            get
            {
                return File_giay_phep;
            }
            set
            {
                File_giay_phep = value;
            }
        }
        private string File_danh_muc_ky_thuat = string.Empty;
        public string file_danh_muc_ky_thuat
        {
            get
            {
                return File_danh_muc_ky_thuat;
            }
            set
            {
                File_danh_muc_ky_thuat = value;
            }
        }
        private string File_nhan_su_dang_ky = string.Empty;
        public string file_nhan_su_dang_ky
        {
            get
            {
                return File_nhan_su_dang_ky;
            }
            set
            {
                File_nhan_su_dang_ky = value;
            }
        }
        private string File_trang_thiet_bi_dang_ky = string.Empty;
        public string file_trang_thiet_bi_dang_ky
        {
            get
            {
                return File_trang_thiet_bi_dang_ky;
            }
            set
            {
                File_trang_thiet_bi_dang_ky = value;
            }
        }
        private string Mo_hinh_to_chuc = string.Empty;
        public string mo_hinh_to_chuc
        {
            get
            {
                return Mo_hinh_to_chuc;
            }
            set
            {
                Mo_hinh_to_chuc = value;
            }
        }
        private string Tuyen_ky_thuat = string.Empty;
        public string tuyen_ky_thuat
        {
            get
            {
                return Tuyen_ky_thuat;
            }
            set
            {
                Tuyen_ky_thuat = value;
            }
        }
        private string Loai_hinh_quan_ly = string.Empty;
        public string loai_hinh_quan_ly
        {
            get
            {
                return Loai_hinh_quan_ly;
            }
            set
            {
                Loai_hinh_quan_ly = value;
            }
        }
    }
    [Serializable()]
    public class thoi_gian_hoat_dong
    {
        private string Loai_thoi_gian_hoat_dong = string.Empty;
        public string loai_thoi_gian_hoat_dong
        {
            get
            {
                return Loai_thoi_gian_hoat_dong;
            }
            set
            {
                Loai_thoi_gian_hoat_dong = value;
            }
        }
        private string ma_hoa_don = string.Empty;
        public string Ma_hoa_don
        {
            get
            {
                return ma_hoa_don;
            }
            set
            {
                ma_hoa_don = value;
            }
        }
        private List<tuy_chon> Tuy_chon;
        public List<tuy_chon> tuy_chon
        {
            get
            {
                if (Tuy_chon == null)
                    Tuy_chon = new List<tuy_chon>();
                return Tuy_chon;
            }
            set
            {
                Tuy_chon = value;
            }
        }
    }
    [Serializable()]
    public class tuy_chon
    {
        private string Type = string.Empty;
        public string type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
        private string Gio_tu = string.Empty;
        public string gio_tu
        {
            get
            {
                return Gio_tu;
            }
            set
            {
                Gio_tu = value;
            }
        }
        private string Gio_den = string.Empty;
        public string gio_den
        {
            get
            {
                return Gio_den;
            }
            set
            {
                Gio_den = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongcosokhamchuabenh
    {
        private string Ma_bao_hiem_co_so_kham_chua_benh = string.Empty;
        public string ma_bao_hiem_co_so_kham_chua_benh
        {
            get
            {
                return Ma_bao_hiem_co_so_kham_chua_benh;
            }
            set
            {
                Ma_bao_hiem_co_so_kham_chua_benh = value;
            }
        }
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongcosokhamchuabenh_return_data
    {
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
        private string Message = string.Empty;
        public string message
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
            }
        }
    }
    [Serializable()]
    public class chandoan
    {
        private string Ma_chan_doan = string.Empty;
        public string ma_chan_doan
        {
            get
            {
                return Ma_chan_doan;
            }
            set
            {
                Ma_chan_doan = value;
            }
        }
        private string Ten_chan_doan = string.Empty;
        public string ten_chan_doan
        {
            get
            {
                return Ten_chan_doan;
            }
            set
            {
                Ten_chan_doan = value;
            }
        }
        private string Ket_luan = string.Empty;
        public string ket_luan
        {
            get
            {
                return Ket_luan;
            }
            set
            {
                Ket_luan = value;
            }
        }
    }
    [Serializable()]
    public class thongtindonthuoc
    {
        private string Ma_thuoc = string.Empty;
        public string ma_thuoc
        {
            get
            {
                return Ma_thuoc;
            }
            set
            {
                Ma_thuoc = value;
            }
        }
        private string Biet_duoc = string.Empty;
        public string biet_duoc
        {
            get
            {
                return Biet_duoc;
            }
            set
            {
                Biet_duoc = value;
            }
        }
        private string Ten_thuoc = string.Empty;
        public string ten_thuoc
        {
            get
            {
                return Ten_thuoc;
            }
            set
            {
                Ten_thuoc = value;
            }
        }
        private string Don_vi_tinh = string.Empty;
        public string don_vi_tinh
        {
            get
            {
                return Don_vi_tinh;
            }
            set
            {
                Don_vi_tinh = value;
            }
        }
        private int So_luong = 0;
        public int so_luong
        {
            get
            {
                return So_luong;
            }
            set
            {
                So_luong = value;
            }
        }
        private string Cach_dung = string.Empty;
        public string cach_dung
        {
            get
            {
                return Cach_dung;
            }
            set
            {
                Cach_dung = value;
            }
        }
    }
    [Serializable()]
    public class donthuocget
    {
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }
        private string Ho_ten_benh_nhan = string.Empty;
        public string ho_ten_benh_nhan
        {
            get
            {
                return Ho_ten_benh_nhan;
            }
            set
            {
                Ho_ten_benh_nhan = value;
            }
        }
        private string Ngay_sinh_benh_nhan = string.Empty;
        public string ngay_sinh_benh_nhan
        {
            get
            {
                return Ngay_sinh_benh_nhan;
            }
            set
            {
                Ngay_sinh_benh_nhan = value;
            }
        }
        private string Ma_dinh_danh_y_te = string.Empty;
        public string ma_dinh_danh_y_te
        {
            get
            {
                return Ma_dinh_danh_y_te;
            }
            set
            {
                Ma_dinh_danh_y_te = value;
            }
        }
        private string Loai_don_thuoc = string.Empty;
        public string loai_don_thuoc
        {
            get
            {
                return Loai_don_thuoc;
            }
            set
            {
                Loai_don_thuoc = value;
            }
        }
        private string Hinh_thuc_dieu_tri = string.Empty;
        public string hinh_thuc_dieu_tri
        {
            get
            {
                return Hinh_thuc_dieu_tri;
            }
            set
            {
                Hinh_thuc_dieu_tri = value;
            }
        }
        private string Dia_chi = string.Empty;
        public string dia_chi
        {
            get
            {
                return Dia_chi;
            }
            set
            {
                Dia_chi = value;
            }
        }
        private string Gioi_tinh = string.Empty;
        public string gioi_tinh
        {
            get
            {
                return Gioi_tinh;
            }
            set
            {
                Gioi_tinh = value;
            }
        }
        private decimal Can_nang = 0;
        public decimal can_nang
        {
            get
            {
                return Can_nang;
            }
            set
            {
                Can_nang = value;
            }
        }
        private string Ma_so_the_bao_hiem_y_te = string.Empty;
        public string ma_so_the_bao_hiem_y_te
        {
            get
            {
                return Ma_so_the_bao_hiem_y_te;
            }
            set
            {
                Ma_so_the_bao_hiem_y_te = value;
            }
        }
        private List<thongtindonthuoc> Thong_tin_don_thuoc;
        public List<thongtindonthuoc> thong_tin_don_thuoc
        {
            get
            {
                if (Thong_tin_don_thuoc == null)
                    Thong_tin_don_thuoc = new List<thongtindonthuoc>();
                return Thong_tin_don_thuoc;
            }
            set
            {
                Thong_tin_don_thuoc = value;
            }
        }
        private List<dot_dung_thuoc> Dot_dung_thuoc;
        public List<dot_dung_thuoc> dot_dung_thuoc
        {
            get
            {
                if (Dot_dung_thuoc == null)
                    Dot_dung_thuoc = new List<dot_dung_thuoc>();
                return Dot_dung_thuoc;
            }
            set
            {
                Dot_dung_thuoc = value;
            }
        }
        private List<chandoan> Chan_doan;
        public List<chandoan> chan_doan
        {
            get
            {
                if (Chan_doan == null)
                    Chan_doan = new List<chandoan>();
                return Chan_doan;
            }
            set
            {
                Chan_doan = value;
            }
        }
        private string Luu_y = string.Empty;
        public string luu_y
        {
            get
            {
                return Luu_y;
            }
            set
            {
                Luu_y = value;
            }
        }
        private string Loi_dan = string.Empty;
        public string loi_dan
        {
            get
            {
                return Loi_dan;
            }
            set
            {
                Loi_dan = value;
            }
        }
        private string Ten_bac_si = string.Empty;
        public string ten_bac_si
        {
            get
            {
                return Ten_bac_si;
            }
            set
            {
                Ten_bac_si = value;
            }
        }
        private string Ten_co_so_kham_chua_benh = string.Empty;
        public string ten_co_so_kham_chua_benh
        {
            get
            {
                return Ten_co_so_kham_chua_benh;
            }
            set
            {
                Ten_co_so_kham_chua_benh = value;
            }
        }
        private string So_dien_thoai_co_so_kham_chua_benh = string.Empty;
        public string so_dien_thoai_co_so_kham_chua_benh
        {
            get
            {
                return So_dien_thoai_co_so_kham_chua_benh;
            }
            set
            {
                So_dien_thoai_co_so_kham_chua_benh = value;
            }
        }
        private string Ngay_gio_ke_don = string.Empty;
        public string ngay_gio_ke_don
        {
            get
            {
                return Ngay_gio_ke_don;
            }
            set
            {
                Ngay_gio_ke_don = value;
            }
        }
    }
    [Serializable()]
    public class donthuocUpdate
    {
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }

        private string Loai_don_thuoc = string.Empty;
        public string loai_don_thuoc
        {
            get
            {
                return Loai_don_thuoc;
            }
            set
            {
                Loai_don_thuoc = value;
            }
        }


        private List<thongtinthuoc> Thong_tin_thuoc;
        public List<thongtinthuoc> thong_tin_thuoc
        {
            get
            {
                if (Thong_tin_thuoc == null)
                    Thong_tin_thuoc = new List<thongtinthuoc>();
                return Thong_tin_thuoc;
            }
            set
            {
                Thong_tin_thuoc = value;
            }
        }
        private string Ma_dinh_danh_co_so_cung_ung_thuoc = string.Empty;
        public string ma_dinh_danh_co_so_cung_ung_thuoc
        {
            get
            {
                return Ma_dinh_danh_co_so_cung_ung_thuoc;
            }
            set
            {
                Ma_dinh_danh_co_so_cung_ung_thuoc = value;
            }
        }
        private string Ten_co_so_cung_ung_thuoc = string.Empty;
        public string ten_co_so_cung_ung_thuoc
        {
            get
            {
                return Ten_co_so_cung_ung_thuoc;
            }
            set
            {
                Ten_co_so_cung_ung_thuoc = value;
            }
        }
        private string So_dien_thoai_co_so_cung_ung_thuoc = string.Empty;
        public string so_dien_thoai_co_so_cung_ung_thuoc
        {
            get
            {
                return So_dien_thoai_co_so_cung_ung_thuoc;
            }
            set
            {
                So_dien_thoai_co_so_cung_ung_thuoc = value;
            }
        }
        private string Dia_chi_co_so_cung_ung_thuoc = string.Empty;
        public string dia_chi_co_so_cung_ung_thuoc
        {
            get
            {
                return Dia_chi_co_so_cung_ung_thuoc;
            }
            set
            {
                Dia_chi_co_so_cung_ung_thuoc = value;
            }
        }
        private string Ma_hoa_don = string.Empty;
        public string ma_hoa_don
        {
            get
            {
                return Ma_hoa_don;
            }
            set
            {
                Ma_hoa_don = value;
            }
        }
    }
    [Serializable()]


    #endregion
    // ham dung de trao doi du lieu voi API RESTfull
    private class DTDTAPI
    {
        public string PostURL(string url, string username, string password, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PutURLtoken(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "PUT";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLtoken(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string DeleteURLtoken(string url, string token)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "DELETE";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLNoAuth(string url, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
            //var serializer = new JavaScriptSerializer();
            //var token = serializer.Deserialize<dangnhapbacsi_return_data>(pageContent);
            //return token.token;
            // return pageContent;
        }
        public string GetURL(string url, string name, string key)
        {
            Uri myUri = new Uri(url);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myUri);
            request.ContentType = "application/json";
            request.Headers.Add("app-name", name);
            request.Headers.Add("app-key", key);
            request.Method = "GET";
            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            //NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            //CredentialCache myCredentialCache = new CredentialCache();
            //myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            //myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Credentials = myCredentialCache;
            //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    //streamWriter.Write(jsondata);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            WebResponse myWebResponse = request.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostAppName(string url, string name, string key, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Headers.Add("app-name", name);
            myWebRequest.Headers.Add("app-key", key);
            myWebRequest.Method = "POST";
            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            //NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            //CredentialCache myCredentialCache = new CredentialCache();
            //myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            //myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        #region RESTfulAPI
        //ham giai ma chuoi UTF-8
        public string DecodeFromUtf8(string utf8String)
        {
            return Regex.Replace(
              utf8String,
              @"\\u(?<Value>[a-fA-F0-9]{4})",
              m =>
              {
                  return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
              });
        }
        //ham dang nhap co so kham chua benh de lay to_ken them bac si
        public string dangnhapCoSoKCB(string port, string user, string pass)
        {
            string url = port + "/api/auth/dang-nhap-co-so-kham-chua-benh";
            dangnhapcosokhamchuabenh dn = new dangnhapcosokhamchuabenh();
            //RESTful rf = new RESTful();
            dn.ma_lien_thong_co_so_kham_chua_benh = user;
            dn.password = pass;
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(dn);
            string returndata = PostURLNoAuth(url, serializedResult);
            var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
                return data.token;
            else return "";
            //return serializedResult;
            //return returndata;
        }
        //ham dang nhap bac si de lay to_ken day don thuoc
        public string dangnhapBS(string port, string user, string pass, string macskcb)
        {
            string loai = "SAVETokenUpdate";
            DataTable dr = new DataTable();
            string tenStore = "spSAVETokenAPI_Get";
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
                if (dr.Rows.Count > 0)
                    return dr.Rows[0][0].ToString();
                else
                {
                    string url = port + "/auth/dang-nhap-bac-si";
                    dangnhapbacsi dn = new dangnhapbacsi();
                    dn.ma_lien_thong_bac_si = user;
                    dn.ma_lien_thong_co_so_kham_chua_benh = macskcb;
                    dn.password = pass;
                    var serializer = new JavaScriptSerializer();
                    string serializedResult = serializer.Serialize(dn);
                    string token = PostURLNoAuth(url, serializedResult);
                    //var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
                    //if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
                    //    return data.token;
                    //else return "";
                    //WriteLog(token);
                    if (!string.IsNullOrEmpty(token) && token.Length > 0)
                        CreateToken(loai, token);
                    return token;

                }

            }
        }
        //Ham de ghi token vao bang HSSKTokenAPI
        public void CreateToken(string loai, string token)
        {
            DataTable dr = new DataTable();
            string tenStore = "spLUUTokenAPI_Token_CREATE";
            string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            using (SqlConnection Conection = new SqlConnection(StrConection))
            {
                Conection.Open();
                using (SqlCommand Command = new SqlCommand(tenStore, Conection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add(new SqlParameter("@Token", token));
                    Command.Parameters.Add(new SqlParameter("@Loai", loai));
                    SqlDataAdapter dp = new SqlDataAdapter(Command);
                    dp.Fill(dr);
                }
            }
        }
        //ham them ma lien thong bac si vao co so kcb
        public string themBS(string port, string user, string token)
        {
            string url = port + "/api/v1/them-bac-si";
            var serializer = new JavaScriptSerializer();
            string serializedResult = "{\"ma_lien_thong_bac_si\" : \"" + user + "\"}";
            string returndata = PostURLtoken(url, token, serializedResult);
            //var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            //if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
            //    return data.token;
            //else return "";
            //return serializedResult;
            //return returndata;
            string output = DecodeFromUtf8(returndata);
            return output;
        }
        //ham xoa ma lien thong bac si khoi co so kcb
        public string xoaBS(string port, string user, string token)
        {
            string url = port + "/api/v1/xoa-bac-si";
            var serializer = new JavaScriptSerializer();
            string serializedResult = "{\"ma_lien_thong_bac_si\" : \"" + user + "\"}";
            string returndata = PostURLtoken(url, token, serializedResult);
            //var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            //if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
            //    return data.token;
            //else return "";
            //return serializedResult;
            //return returndata;
            string output = DecodeFromUtf8(returndata);
            return output;
        }
        //ham gui don thuoc
        public string Gui_don_thuoc(string port, string token, donthuoc dt)
        {
            string url = port + "/api/v1/gui-don-thuoc";
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(dt);
            string returndata = PostURLtoken(url, token, serializedResult);
            //var data = serializer.Deserialize<kq_don_thuoc_return>(returndata);
            //if (data != null && data.Code == 200 && data.Ma_don_thuoc_quoc_gia != "")
            //    return data.Ma_don_thuoc_quoc_gia;
            //else return "";
            //var output = System.Net.WebUtility.HtmlDecode(returndata);
            string output = DecodeFromUtf8(returndata);
            return output;
        }
        //ham lay thong tin don thuoc
        public donthuocget laydonthuoc(string port, string madonthuoc, string name, string key)
        {
            string url = port + "/api/v1/thong-tin-don-thuoc/" + madonthuoc;
            string returndata = GetURL(url, name, key);
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<donthuocget>(returndata);
            if (data != null)
                return data;
            else return null;
        }
        public string capnhatdonthuoc(string port, string name, string key, donthuocUpdate donthuoc)
        {
            string url = port + "/api/v1/cap-nhat-don-thuoc";
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(donthuoc);
            string returndata = PostAppName(url, name, key, serializedResult);

            string output = DecodeFromUtf8(returndata);
            return output;
        }
        #endregion
    }
    #endregion
    #region 4210
    #region Token
    //ham lay token API de lay Update HSSK 
    //ktra trong bang HSSKTokenAPI xem da có token mà thời gian lấy token < thời gian hiện tại 25 phút thì lấy, neu khong thi goi API de lay token moi va luu token lay duoc vao bang HSSKTokenAPI
    //Loai=HS4210TokenUpdate
    public string GetTokenUpdate(string port, string username, string password)
    {
        string mss = "GetTokenUpdate/";
        string loai = "HS4210TokenUpdate";
        DataTable dr = new DataTable();
        string tenStore = "spHSSKTokenAPI_Get";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            mss += "lay token cu trong DB/";
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@Loai", loai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            if (dr.Rows.Count > 0)
            {
                mss += "co token cu: " + dr.Rows[0][0].ToString();
                //WriteLog(mss);
                return dr.Rows[0][0].ToString();
            }
            else
            {
                //chua co token trong ngay hoac token da qua han
                mss += "chua co token trong ngay hoac token da qua han/";
                //lay token moi
                //string url = port + "/api/authenticate";
                string url = port;
                mss += "port: " + port + "/";
                //WriteLog(url);
                Hilo h = new Hilo();
                string json = "{\"username\":\"" + username + "\",\"password\":\"" + password + "\"}";
                //WriteLog(json);
                string xau = h.PostURL(url, json);
                mss += "xau: " + xau + "/";
                //string value = HttpUtility.UrlEncode(HttpUtility.HtmlEncode(xau), Encoding.GetEncoding("iso-8859-1"));
                try
                {
                    var returndata = JsonConvert.DeserializeObject<LoginError>(xau);
                    if (returndata != null && returndata.Data != null)
                    {
                        //return returndata.token;
                        string token = returndata.Data.access_token;
                        //mss += "token: " + token + "/";
                        //WriteLog(token);
                        if (!string.IsNullOrEmpty(token) && token.Length > 0)
                            CreateToken(loai, token);
                        else WriteLog(xau);
                        //WriteLog(mss);
                        return token;
                    }
                    else
                    {
                        WriteLog(mss);
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    WriteLog(mss+" loi: "+ex.ToString());
                    return "";
                }
            }
        }
    }
    //Ham de ghi token vao bang HSSKTokenAPI
    public void CreateToken(string loai, string token)
    {
        //WriteLog("CreateToken");
        DataTable dr = new DataTable();
        string tenStore = "spHSSKTokenAPI_Token_CREATE";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@Token", token));
                Command.Parameters.Add(new SqlParameter("@Loai", loai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
        }
        //WriteLog("CreateToken");
    }
    #endregion
    //ham update HSSK
    public string UpdateHS4210(string port, string token)
    {
        //string url = port + "/api/upload";
        string url = port;
        WriteLog("UpdateHS4210: url: " + url + " maba: " + _MaBA);
        string mss = "";
        string sothe = "";
        string _dk = "";
        _BenhAnPK = BenhAnPK.GetBenhAnPK(_MaBA);
        if (_BenhAnPK != null && _BenhAnPK.Sothe.Trim().Length > 0)
            sothe = _BenhAnPK.Sothe;
        mss += "sothe:" + sothe + "/";
        BenhAn_ThanhToanList _BenhAn_ThanhToanList = BenhAn_ThanhToanList.GetAllBenhAn_ThanhToanByMaBA(_MaBA);
        mss += "_BenhAn_ThanhToanList.Count:" + _BenhAn_ThanhToanList.Count + "/";
        if (sothe.Trim().Length > 0&& _BenhAn_ThanhToanList.Count>0)
        {
            WriteLog("lay dl 4210");
            string ngayqttt = _BenhAn_ThanhToanList[_BenhAn_ThanhToanList.Count - 1].NgayQTTT;
            string ngayqt = _BenhAn_ThanhToanList[_BenhAn_ThanhToanList.Count - 1].NgayQT;
            _dk = _dk + " and  datediff(d,c.ngayravien,'" + vvdate(dtngayravien.Text) + "') <=0 and  datediff(d,c.ngayravien,'" + vvdate(dtngayravien.Text) + "') >=0";
            _dk = _dk + " and ( c.sothe in ('" + sothe.Replace(",", "','") + "'))";
            DataSet ds = new DataSet();
            ds = HTC.Business.DataProvider.Instance().RptGetBenhAn_VP(DateTime.Parse(ngayqttt), DateTime.Parse(ngayqttt), _BenhAn_Khoa.MaDT, 25, _dk, true);

            ds.Tables[0].TableName = "TONG_HOP";
            ds.DataSetName = "TONGHOP";
            if (ds.Tables.Count > 1)
                ds.Tables.RemoveAt(1);
            _dk = "";
            _dk = _dk + " and  datediff(d,v.ngayravien,'" + vvdate(dtngayravien.Text) + "') <=0 and  datediff(d,v.ngayravien,'" + vvdate(dtngayravien.Text) + "') >=0";
            _dk = _dk + " and v.sothe in ('" + sothe.Replace(",", "','") + "')";
            DataSet ds1 = new DataSet();
            ds1 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuocNT(DateTime.Parse(ngayqt), DateTime.Parse(ngayqt), "", 205, 1, _BenhAn_Khoa.MaKhoa.Trim(), _dk);
            ds1.Tables[0].TableName = "CHI_TIET_THUOC";
            ds1.DataSetName = "DSACH_CHI_TIET_THUOC";
            if (ds1.Tables.Count > 1)
                ds1.Tables.RemoveAt(1);

            DataSet ds2 = new DataSet();
            ds2 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuocNT(DateTime.Parse(ngayqt), DateTime.Parse(ngayqt), "", 206, 1, _BenhAn_Khoa.MaKhoa.Trim(), _dk);

            ds2.Tables[0].TableName = "CHI_TIET_DVKT";
            ds2.DataSetName = "DSACH_CHI_TIET_DVKT";
            if (ds2.Tables.Count > 1)
                ds2.Tables.RemoveAt(1);

            DataSet ds3 = new DataSet();
            ds3 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuocNT(DateTime.Parse(ngayqt), DateTime.Parse(ngayqt), "", 203, 1, _BenhAn_Khoa.MaKhoa.Trim(), _dk);
            if (ds3.Tables.Count > 0)
            {
                ds3.Tables[0].TableName = "CHI_TIET_CLS";
                ds3.DataSetName = "DSACH_CHI_TIET_CLS";
                if (ds3.Tables.Count > 1)
                    ds3.Tables.RemoveAt(1);
            }
            DataSet ds4 = new DataSet();
            ds4 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuocNT(DateTime.Parse(ngayqt), DateTime.Parse(ngayqt), "", 204, 1, _BenhAn_Khoa.MaKhoa.Trim(), _dk);
            if (ds4.Tables.Count > 0)
            {
                ds4.Tables[0].TableName = "CHI_TIET_DIEN_BIEN_BENH";
                ds4.DataSetName = "DSACH_CHI_TIET_DIEN_BIEN_BENH";

                if (ds4.Tables.Count > 1)
                    ds4.Tables.RemoveAt(1);
            }
            GIAMDINHHS giamDinhHS = new GIAMDINHHS();
            giamDinhHS.THONGTINDONVI = getThongTinDonVi();
            giamDinhHS.CHUKYDONVI = string.Empty;
            giamDinhHS.THONGTINHOSO = getThongTinHOSO(ds, ds1, ds2, ds3, ds4, 42);
            //tao file xml
            string data = Serialize<GIAMDINHHS>(giamDinhHS);
            WriteLog(data);
            XmlSerializer ser = new XmlSerializer(typeof(GIAMDINHHS));
            MemoryStream writer = new MemoryStream();
            ser.Serialize(writer, giamDinhHS);
            writer.Position = 0;
            StreamContent fileStreamContent = new StreamContent(writer);
            using (var Client = new HttpClient())
            {
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                using (var formData = new MultipartFormDataContent())
                {
                    //formData.Headers.TryAddWithoutValidation("Content-Type", "multipart/form-data");
                    fileStreamContent.Headers.Add("Content-Type", "multipart/form-data");
                    string filename = _BenhAnPK.MaBA + "4210V" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xml";
                    fileStreamContent.Headers.Add("Content-Disposition", "form-data; name=\"file\"; filename=\"" + filename + "\"");
                    //fileStreamContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    //fileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("file") { FileName = filename };
                    //formData.Add(fileStreamContent);
                    formData.Add(fileStreamContent, "file", filename);
                    var response = Client.PostAsync(url, formData).Result;
                    string xau = response.Content.ReadAsStringAsync().Result;
                    WriteLog(xau);
                    var returndata = JsonConvert.DeserializeObject<UpdateError>(xau);
                    if (response.IsSuccessStatusCode)
                    {
                        //gui thanh cong
                        if (!string.IsNullOrEmpty(returndata.maGiaoDich))
                        {
                            //ghi lai log + magiaodich
                            CreateMaGiaoDich(_BenhAnPK.MaBA, returndata.maGiaoDich, "4210: " + returndata.message, returndata.status.ToString(), Pub_sMaMay, Pub_sNguoiSD, xau);
                            writer.Close();
                            formData.Dispose();
                            Client.Dispose();
                            return returndata.maGiaoDich;
                        }
                    }
                    else
                    {
                        //gui khong thanh cong
                        WriteLog(xau);
                        writer.Close();
                        formData.Dispose();
                        Client.Dispose();
                        return "";
                    }
                    writer.Close();
                    formData.Dispose();
                    Client.Dispose();
                    return "";
                }
            }
            //Hilo h = new Hilo();

            //string xau = h.PostInvoice(url, token, data);
            ////string value = HttpUtility.UrlEncode(HttpUtility.HtmlEncode(xau), Encoding.GetEncoding("iso-8859-1"));
        }
        else return "";
    }
    public static string Serialize<T>(T dataToSerialize)
    {
        try
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringwriter, dataToSerialize);
            return stringwriter.ToString();
        }
        catch
        {
            throw;
        }
    }
    public class Hilo
    {
        //giai ma chuoi xml thanh object 
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        public string PostURL(string url, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            NetworkCredential myNetworkCredential = new NetworkCredential();
            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Accept = "application/json";
            myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostInvoice(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "multipart/form-data";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLtoken(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Basic " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string GetTokenPID(string url, string username, string password)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Headers.Add("U", username);
            //myHttpWebRequest.Headers.Add("P", password);
            string jsondata = "{\"username\":\"" + username + "\",\"password\":\"" + password + "\"}";
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
    }
    [Serializable()]
    public class LoginError
    {
        private int Code = 0;
        public int code
        {
            get
            {
                return Code;
            }
            set
            {
                Code = value;
            }
        }
        private Data _Data;
        public Data Data
        {
            get
            {
                if (_Data == null)
                    _Data = new Data();
                return _Data;
            }
            set
            {
                _Data = value;
            }
        }
        private string Message = string.Empty;
        public string message
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
            }
        }
    }
    [Serializable()]
    public class Data
    {
        private string _access_token = string.Empty;
        public string access_token
        {
            get
            {
                return _access_token;
            }
            set
            {
                _access_token = value;
            }
        }
        private int _expires_in = 0;
        public int expires_in
        {
            get
            {
                return _expires_in;
            }
            set
            {
                _expires_in = value;
            }
        }
        private int _refresh_expires_in = 0;
        public int refresh_expires_in
        {
            get
            {
                return _refresh_expires_in;
            }
            set
            {
                _refresh_expires_in = value;
            }
        }
        private string _refresh_token = string.Empty;
        public string refresh_token
        {
            get
            {
                return _refresh_token;
            }
            set
            {
                _refresh_token = value;
            }
        }
        private decimal _not_before_policy = 0;
        public decimal not_before_policy
        {
            get
            {
                return _not_before_policy;
            }
            set
            {
                _not_before_policy = value;
            }
        }
        private string _scope = string.Empty;
        public string scope
        {
            get
            {
                return _scope;
            }
            set
            {
                _scope = value;
            }
        }
    }
    [Serializable()]
    public class UpdateError
    {
        private string _maGiaoDich = string.Empty;
        public string maGiaoDich
        {
            get
            {
                return _maGiaoDich;
            }
            set
            {
                _maGiaoDich = value;
            }
        }
        private string _message = string.Empty;
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }
        private int _status = 0;
        public int status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
    }
    #region Các object Tạo luôn ở đây vì chỉ form này dùng
    public class GIAMDINHHS
    {
        public THONGTINDONVI THONGTINDONVI { set; get; }
        public THONGTINHOSO THONGTINHOSO { get; set; }
        public string CHUKYDONVI { get; set; }

    }
    [Serializable]
    public class THONGTINDONVI
    {
        public string MACSKCB { get; set; }
        private string _CHUKYDONVI;
        public string CHUKYDONVI
        {
            get
            {
                return _CHUKYDONVI;
            }
            set
            {
                _CHUKYDONVI = value;
            }
        }
    }
    public class THONGTINHOSO
    {
        public string NGAYLAP { set; get; }
        public int SOLUONGHOSO { get; set; }
        public HOSO[] DANHSACHHOSO { get; set; }
    }
    public class HOSO
    {
        [XmlElement("FILEHOSO")]
        public FILEHOSO[] FILEHOSO;


    }
    public class FILEHOSO
    {
        public string LOAIHOSO { get; set; }
        public String NOIDUNGFILE { get; set; }
    }

    #endregion
    #region getThongTinDonVi
    public THONGTINDONVI getThongTinDonVi() // MACSKCB sẽ lấy ở data hoặc dynamic ở cái gì đó :D
    {
        THONGTINDONVI thongTinDonVi = new THONGTINDONVI();
        thongTinDonVi.MACSKCB = HTC.ShareVariables.pub_sMaBHXH;
        return thongTinDonVi;
    }
    #endregion
    public THONGTINHOSO getThongTinHOSO(DataSet ds1, DataSet ds2, DataSet ds3, DataSet ds4, DataSet ds5, byte loai)
    {
        THONGTINHOSO thongTinHS = new THONGTINHOSO();
        thongTinHS.NGAYLAP = DateTime.Now.Year.ToString() + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());


        List<HOSO> HOSO = new List<HOSO>();

        foreach (DataRow Row in ds1.Tables[0].Rows)
        {

            HOSO hs = new HOSO();

            List<FILEHOSO> f = new List<FILEHOSO>();
            string dk = "Ma_LK='" + Row["MA_LK"].ToString() + "'";
            decimal sumthuoc = 0;
            decimal sumtong = 0;
            decimal sumtt = 0;

            decimal sumbh = 0;

            decimal sumct = 0;

            decimal sumttt = 0;

            decimal sumbht = 0;
            decimal sumtongt = 0;
            decimal sumctt = 0;
            decimal sumcvtt = 0;
            decimal sumvt = 0;
            FILEHOSO fhs2 = null;
            if (ds2.Tables.Count > 0)
                fhs2 = getDichVu(ds2, Row["MA_LK"].ToString(), out sumtong, out sumtt, out sumbh, out sumct, out sumcvtt, loai, 2);
            sumthuoc = sumtong;
            FILEHOSO fhs3 = null;
            if (ds3.Tables.Count > 0)
                fhs3 = getDichVu(ds3, Row["MA_LK"].ToString(), out sumtongt, out sumttt, out sumbht, out sumctt, out sumvt, loai, 3);

            sumtong = sumtong + sumtongt;

            sumct = sumct + sumctt;

            sumtt = sumtt + sumttt;

            sumbh = sumbh + sumbht;

            FILEHOSO fhs4 = null;
            if (ds4.Tables.Count > 0)
                fhs4 = getDichVu(ds4, Row["MA_LK"].ToString(), out sumtongt, out sumttt, out sumbht, out sumctt, out sumcvtt, loai, 4);
            FILEHOSO fhs5 = null;
            if (ds5.Tables.Count > 0)
                fhs5 = getDichVu(ds5, Row["MA_LK"].ToString(), out sumtongt, out sumttt, out sumbht, out sumctt, out sumcvtt, loai, 5);
            FILEHOSO fhs1 = getTongHop(Row, sumtong, sumtt, sumbh, sumct, sumvt, sumthuoc);

            f.Add(fhs1);
            if (fhs2 != null)
                f.Add(fhs2);
            if (fhs3 != null)
                f.Add(fhs3);
            if (fhs4 != null)
                f.Add(fhs4);
            if (fhs5 != null)
                f.Add(fhs5);
            //hs.Add(fhs1);
            hs.FILEHOSO = f.ToArray();
            HOSO.Add(hs);
        }

        thongTinHS.SOLUONGHOSO = HOSO.Count;// ?
        thongTinHS.DANHSACHHOSO = HOSO.ToArray();

        // = getDanhSachHS(ds1, ds2, ds3);
        return thongTinHS;
    }
    #region getDanhSachHS
    public FILEHOSO getTongHop(DataRow r, decimal sumtong, decimal sumtt, decimal sumbh, decimal sumct, decimal sumvt, decimal sumthuoc)
    {
        FILEHOSO fileHS = new FILEHOSO();
        fileHS.LOAIHOSO = "XML1";
        MemoryStream memStream = new MemoryStream();

        StringWriter sw = new StringWriter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        ds.DataSetName = "TONGHOP";
        dt.TableName = "TONG_HOP";
        dt = r.Table.Clone();

        dt.Rows.Add(r.ItemArray);
        if (sumtt + sumbh + sumct != 0)
        {
            dt.Rows[0]["T_TONGCHI"] = sumtong.ToString();
            dt.Rows[0]["T_BHTT"] = sumbh.ToString();
            dt.Rows[0]["T_BNTT"] = sumtt.ToString();
            dt.Rows[0]["T_BNCCT"] = sumct.ToString();
            dt.Rows[0]["T_VTYT"] = sumvt.ToString();
            dt.Rows[0]["T_THUOC"] = sumthuoc.ToString();
        }
        // dt.ImportRow(r);
        ds.Tables.Add(dt);
        dt.WriteXml(sw, XmlWriteMode.IgnoreSchema);
        string s = sw.ToString();
        s = s.Replace("<TONGHOP>", "");
        if (s.Length > 20)
            s = s.Substring(0, s.Length - 10);
        s = s.TrimEnd();
        s = s.TrimStart();
        StreamWriter writer = new StreamWriter(memStream);
        writer.Write(s);
        writer.Flush();
        memStream.Position = 0;

        string base64String = Convert.ToBase64String(memStream.ToArray());
        fileHS.NOIDUNGFILE = base64String;
        return fileHS;
    }


    //public FILEHOSO getDichVu(DataSet ds, string maba,byte loai =0)
    //{
    //    FILEHOSO fileHS = new FILEHOSO();
    //    DataRow[] rows = ds.Tables[0].Select("MA_LK='" + maba + "'");

    //    if (rows != null)
    //    {
    //        if (rows.Any())
    //        {
    //            if (ds.DataSetName == "DSACH_CHI_TIET_THUOC" ||loai ==2)
    //                fileHS.LOAIHOSO = "XML2";
    //            else if (ds.DataSetName == "DSACH_CHI_TIET_DVKT" || loai == 3)
    //                fileHS.LOAIHOSO = "XML3";
    //            else if (ds.DataSetName == "DSACH_CHI_TIET_CLS" || loai == 4)
    //                fileHS.LOAIHOSO = "XML4";
    //            else if (ds.DataSetName == "DSACH_CHI_TIET_DIEN_BIEN_BENH" || loai == 5)
    //                fileHS.LOAIHOSO = "XML5";

    //            MemoryStream memStream = new MemoryStream();
    //            DataSet dst = new DataSet();
    //            dst.DataSetName = ds.DataSetName;
    //            DataTable dt = rows.CopyToDataTable();
    //            dt.TableName = ds.Tables[0].TableName;
    //            dst.Tables.Add(dt);
    //            dst.WriteXml(memStream, XmlWriteMode.IgnoreSchema);
    //            string base64String = Convert.ToBase64String(memStream.ToArray());
    //            fileHS.NOIDUNGFILE = base64String;
    //            return fileHS;
    //        }
    //        else
    //            return null;
    //    }
    //    else
    //        return null;



    //}

    public FILEHOSO getDichVu(DataSet ds, string maba, out decimal sumtong, out decimal sumtt, out decimal sumbh, out decimal sumct, out decimal sumvt, byte read, byte loai = 0)
    {
        FILEHOSO fileHS = new FILEHOSO();
        DataRow[] rows = ds.Tables[0].Select("MA_LK='" + maba + "'");
        sumct = 0;
        sumtt = 0;
        sumbh = 0;
        sumvt = 0;
        sumtong = 0;
        if (rows != null)
        {
            if (rows.Any())
            {
                if (ds.DataSetName == "DSACH_CHI_TIET_THUOC" || loai == 2)
                    fileHS.LOAIHOSO = "XML2";
                else if (ds.DataSetName == "DSACH_CHI_TIET_DVKT" || loai == 3)
                    fileHS.LOAIHOSO = "XML3";
                else if (ds.DataSetName == "DSACH_CHI_TIET_CLS" || loai == 4)
                    fileHS.LOAIHOSO = "XML4";
                else if (ds.DataSetName == "DSACH_CHI_TIET_DIEN_BIEN_BENH" || loai == 5)
                    fileHS.LOAIHOSO = "XML5";

                MemoryStream memStream = new MemoryStream();
                DataSet dst = new DataSet();
                dst.DataSetName = ds.DataSetName;
                DataTable dt = rows.CopyToDataTable();
                dt.TableName = ds.Tables[0].TableName;
                dst.Tables.Add(dt);
                if (read == 42 && (loai == 2 || loai == 3))
                {
                    sumtong = dt.AsEnumerable().Sum(x => x.Field<Decimal>("THANH_TIEN"));//Convert.ToDecimal(dt.Compute("THANH_TIEN", ""));

                    sumct = dt.AsEnumerable().Sum(x => x.Field<Decimal>("T_BNCCT"));//Convert.ToDecimal(dt.Compute("T_BNCCT", ""));

                    sumtt = dt.AsEnumerable().Sum(x => x.Field<Decimal>("T_BNTT")); //Convert.ToDecimal(dt.Compute("T_BNTT", ""));

                    sumbh = dt.AsEnumerable().Sum(x => x.Field<Decimal>("T_BHTT")); //Convert.ToDecimal(dt.Compute("T_BHTT", ""));
                }

                if (ds.DataSetName == "DSACH_CHI_TIET_DVKT" || loai == 3)
                    sumvt = dt.AsEnumerable().Where(r => r.Field<String>("MA_NHOM") == "10" || r.Field<String>("MA_NHOM") == "11").Sum(x => x.Field<Decimal>("THANH_TIEN"));

                dst.WriteXml(memStream, XmlWriteMode.IgnoreSchema);
                string base64String = Convert.ToBase64String(memStream.ToArray());
                fileHS.NOIDUNGFILE = base64String;
                return fileHS;
            }
            else
                return null;
        }
        else
            return null;



    }

    #endregion
    #endregion
    #region GiayNghiViecHuong BHXH
    public DataTable GetData(DateTime TuNgay, DateTime DenNgay, Byte LoaiBC, string dk)
    {
        DataTable dr = new DataTable();
        string tenStore = "spBHXH_XML_GetBC";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@TuNgay", TuNgay));
                Command.Parameters.Add(new SqlParameter("@DenNgay", DenNgay));
                Command.Parameters.Add(new SqlParameter("@LoaiBC", LoaiBC));
                Command.Parameters.Add(new SqlParameter("@dk", dk));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            //if (dr.Rows.Count == 0)
            //    return true;
            //else
            //    return false;
            return dr;
        }
        //return HTC.Business.DataProvider.Instance().spBHXH_XML_GetBC(TuNgay, DenNgay, LoaiBC, dk);
    }
    public DataTable spThongTinBN_GetGiayNghiBHXH(string maba, string mabn)
    {
        DataTable dr = new DataTable();
        string tenStore = "spThongTinBN_GetGiayNghiBHXH";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", mabn));
                Command.Parameters.Add(new SqlParameter("@maba", maba));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            //if (dr.Rows.Count == 0)
            //    return true;
            //else
            //    return false;
            return dr;
        }
        //return HTC.Business.DataProvider.Instance().spBHXH_XML_GetBC(TuNgay, DenNgay, LoaiBC, dk);
    }
    public static bool CheckTrungNghiBHXH(String MaBHXH, DateTime tungay, byte loaiBC)
    {
        DataTable dr = new DataTable();
        string tenStore = "spBHXH_CheckTrung";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@maBHXH", MaBHXH));
                Command.Parameters.Add(new SqlParameter("@tungay", tungay));
                Command.Parameters.Add(new SqlParameter("@loaibc", loaiBC));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            if (dr.Rows.Count == 0)
                return true;
            else
                return false;
        }
        //DataTable dr = HTC.Business.DataProvider.Instance().CheckTrungNghiBHXH(MaBHXH, tungay, loaiBC);
        //if (dr.Rows.Count == 0)
        //    return true;
        //else
        //    return false;
    }
    public string spBenhAnPK_GetSeri(string maba)
    {
        DataTable dr = new DataTable();
        string tenStore = "spBenhAnPK_GetSeri";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBA", maba));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            if (dr.Rows.Count > 0)
                return dr.Rows[0][0].ToString();
            else
                return "";
        }
    }
    [Serializable]
    public class HSCHUNGTU
    {
        private THONGTINDONVI _THONGTINDONVI;
        public THONGTINDONVI THONGTINDONVI
        {
            get
            {
                if (_THONGTINDONVI == null)
                    _THONGTINDONVI = new THONGTINDONVI();
                return _THONGTINDONVI;
            }
            set
            {
                _THONGTINDONVI = value;
            }
        }
        private THONGTINHOSO _THONGTINHOSO;
        public THONGTINHOSO THONGTINHOSO
        {
            get
            {
                if (_THONGTINHOSO == null)
                    _THONGTINHOSO = new THONGTINHOSO();
                return _THONGTINHOSO;
            }
            set
            {
                _THONGTINHOSO = value;
            }
        }
    }
    public class BHXH
    {
        //giai ma chuoi xml thanh object 
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        // ma hoa object thanh chuoi xml 
        public string Serialize<T>(T ObjectToSerialize, string loai)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            //using (StringWriter textWriter = new StringWriter())
            //{
            //    xmlSerializer.Serialize(textWriter, ObjectToSerialize);
            //    return textWriter.ToString();
            //}
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            // exclude xsi and xsd namespaces by adding the following:
            ns.Add(string.Empty, string.Empty);

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, ObjectToSerialize, ns);
                }
                if (loai == "Chuoi")
                    return textWriter.ToString();
                else
                    return textWriter.ToString().Replace(" p5:nil=\"true\" xmlns:p5=\"http://www.w3.org/2001/XMLSchema-instance\"", "").Replace(" p2:nil=\"true\" xmlns:p2=\"http://www.w3.org/2001/XMLSchema-instance\"", "").Replace("\r\n ", string.Empty).Replace("  ", string.Empty); //This is the output as a string

            }
        }
        public string SerializeT<T>(T dataToSerialize)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(dataToSerialize.GetType());
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                xs.Serialize(xmlTextWriter, dataToSerialize);
                string sw = Encoding.UTF8.GetString(memoryStream.ToArray());
                return sw.ToString();
            }
            catch
            {
                throw;
            }
        }
        public string PostURL(string url, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            NetworkCredential myNetworkCredential = new NetworkCredential();
            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Accept = "application/json";
            myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostInvoice(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "multipart/form-data";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLtoken(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Basic " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLNoAuth(string url, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string GetTokenPID(string url, string username, string password)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "GET";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("U", username);
            myHttpWebRequest.Headers.Add("P", password);
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
    }
    [Serializable()]
    public class CT03
    {
        private string _SO_LUU_TRU;
        public string SO_LUU_TRU
        {
            get
            {
                return _SO_LUU_TRU;
            }
            set
            {
                _SO_LUU_TRU = value;
            }
        }
        private string _MA_YTE;
        public string MA_YTE
        {
            get
            {
                return _MA_YTE;
            }
            set
            {
                _MA_YTE = value;
            }
        }
        private string _MA_KHOA;
        public string MA_KHOA
        {
            get
            {
                return _MA_KHOA;
            }
            set
            {
                _MA_KHOA = value;
            }
        }
        private string _MA_BHXH;
        public string MA_BHXH
        {
            get
            {
                return _MA_BHXH;
            }
            set
            {
                _MA_BHXH = value;
            }
        }
        private string _MA_THE;
        public string MA_THE
        {
            get
            {
                return _MA_THE;
            }
            set
            {
                _MA_THE = value;
            }
        }
        private string _HO_TEN;
        public string HO_TEN
        {
            get
            {
                return _HO_TEN;
            }
            set
            {
                _HO_TEN = value;
            }
        }
        private string _NGAY_SINH;
        public string NGAY_SINH
        {
            get
            {
                return _NGAY_SINH;
            }
            set
            {
                _NGAY_SINH = value;
            }
        }
        private string _GIOI_TINH;
        public string GIOI_TINH
        {
            get
            {
                return _GIOI_TINH;
            }
            set
            {
                _GIOI_TINH = value;
            }
        }
        private string _MA_DANTOC;
        public string MA_DANTOC
        {
            get
            {
                return _MA_DANTOC;
            }
            set
            {
                _MA_DANTOC = value;
            }
        }
        private string _NGHE_NGHIEP;
        public string NGHE_NGHIEP
        {
            get
            {
                return _NGHE_NGHIEP;
            }
            set
            {
                _NGHE_NGHIEP = value;
            }
        }
        private string _DIA_CHI;
        public string DIA_CHI
        {
            get
            {
                return _DIA_CHI;
            }
            set
            {
                _DIA_CHI = value;
            }
        }
        private string _NGAY_VAO;
        public string NGAY_VAO
        {
            get
            {
                return _NGAY_VAO;
            }
            set
            {
                _NGAY_VAO = value;
            }
        }
        private string _NGAY_RA;
        public string NGAY_RA
        {
            get
            {
                return _NGAY_RA;
            }
            set
            {
                _NGAY_RA = value;
            }
        }
        private string _DINH_CHI_THAI_NGHEN;
        public string DINH_CHI_THAI_NGHEN
        {
            get
            {
                return _DINH_CHI_THAI_NGHEN;
            }
            set
            {
                _DINH_CHI_THAI_NGHEN = value;
            }
        }
        private string _TUOI_THAI;
        public string TUOI_THAI
        {
            get
            {
                return _TUOI_THAI;
            }
            set
            {
                _TUOI_THAI = value;
            }
        }
        private string _CHAN_DOAN;
        public string CHAN_DOAN
        {
            get
            {
                return _CHAN_DOAN;
            }
            set
            {
                _CHAN_DOAN = value;
            }
        }
        private string _PP_DIEUTRI;
        public string PP_DIEUTRI
        {
            get
            {
                return _PP_DIEUTRI;
            }
            set
            {
                _PP_DIEUTRI = value;
            }
        }
        private string _GHI_CHU;
        public string GHI_CHU
        {
            get
            {
                return _GHI_CHU;
            }
            set
            {
                _GHI_CHU = value;
            }
        }
        private string _THU_TRUONG_DVI;
        public string THU_TRUONG_DVI
        {
            get
            {
                return _THU_TRUONG_DVI;
            }
            set
            {
                _THU_TRUONG_DVI = value;
            }
        }
        private string _MA_CCHN_TRUONGKHOA;
        public string MA_CCHN_TRUONGKHOA
        {
            get
            {
                return _MA_CCHN_TRUONGKHOA;
            }
            set
            {
                _MA_CCHN_TRUONGKHOA = value;
            }
        }
        private string _TEN_TRUONGKHOA;
        public string TEN_TRUONGKHOA
        {
            get
            {
                return _TEN_TRUONGKHOA;
            }
            set
            {
                _TEN_TRUONGKHOA = value;
            }
        }
        private string _NGAY_CHUNG_TU;
        public string NGAY_CHUNG_TU
        {
            get
            {
                return _NGAY_CHUNG_TU;
            }
            set
            {
                _NGAY_CHUNG_TU = value;
            }
        }
        private string _TEKT;
        public string TEKT
        {
            get
            {
                return _TEKT;
            }
            set
            {
                _TEKT = value;
            }
        }
        private string _HO_TEN_CHA;
        public string HO_TEN_CHA
        {
            get
            {
                return _HO_TEN_CHA;
            }
            set
            {
                _HO_TEN_CHA = value;
            }
        }
        private string _HO_TEN_ME;
        public string HO_TEN_ME
        {
            get
            {
                return _HO_TEN_ME;
            }
            set
            {
                _HO_TEN_ME = value;
            }
        }
        private string _NGOAITRU_TUNGAY;
        public string NGOAITRU_TUNGAY
        {
            get
            {
                return _NGOAITRU_TUNGAY;
            }
            set
            {
                _NGOAITRU_TUNGAY = value;
            }
        }
        private string _NGOAITRU_DENNGAY;
        public string NGOAITRU_DENNGAY
        {
            get
            {
                return _NGOAITRU_DENNGAY;
            }
            set
            {
                _NGOAITRU_DENNGAY = value;
            }
        }
    }
    #endregion
    #region QD130
    public string ExcSQLString(String _sql)
    {
        // SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spExcSQL", _sql);
        System.Data.SqlClient.SqlCommand cmd;
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        System.Data.SqlClient.SqlConnection SQLConnectionData = new System.Data.SqlClient.SqlConnection(StrConection);
        if (SQLConnectionData.State == System.Data.ConnectionState.Closed)
            SQLConnectionData.Open();
        cmd = SqlHelper.CreateCommand(SQLConnectionData, "dbo." + "spExcSQL");
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("sql", _sql);

        cmd.CommandTimeout = 18000;
        IDataReader reader = (IDataReader)cmd.ExecuteReader(CommandBehavior.CloseConnection);
        string kq = "";
        while (reader.Read())
        {
            kq = reader[0].ToString(); //get Value of ppassword Column
        }

        cmd.Dispose();
        cmd = null;

        return kq;
    }
    #endregion
}