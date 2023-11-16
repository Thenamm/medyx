using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using HTC.Business.Duoc;
using HTC.Common.Web;
using Telerik.Web.UI;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using OfficeOpenXml;
using HTC.Business.NoiTru;
using HTC.Business.PhongKham;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;
//using static UI_QLHSBA_frmGiayChungSinh;


public partial class UI_QLHSBA_frmGiayChungSinh : WebBase
{
    private const string ViewState_ThongtinBN = "ThongtinBN";
    public ThongtinBN _ThongtinBN
    {
        get
        {
            return (ThongtinBN)ViewState[ViewState_ThongtinBN];
        }
        set
        {
            ViewState[ViewState_ThongtinBN] = value;
        }
    }
    private const string ViewState_MaBN = "MaBN";
    public string _MaBN
    {
        get
        {
            if (ViewState[ViewState_MaBN] == null)
                ViewState[ViewState_MaBN] = "";
            return (string)ViewState[ViewState_MaBN];
        }
        set
        {
            ViewState[ViewState_MaBN] = value;
        }
    }
    private const string ViewState_MaBA = "MaBA";
    public string _MaBA
    {
        get
        {
            if (ViewState[ViewState_MaBA] == null)
                ViewState[ViewState_MaBA] = "";
            return (string)ViewState[ViewState_MaBA];
        }
        set
        {
            ViewState[ViewState_MaBA] = value;
        }
    }
    private const string ViewState_SoGiayChungSinh = "SoGiayChungSinh";
    public string _SoGiayChungSinh
    {
        get
        {
            if (ViewState[ViewState_SoGiayChungSinh] == null)
                ViewState[ViewState_SoGiayChungSinh] = "0";
            return (string)ViewState[ViewState_SoGiayChungSinh];
        }
        set
        {
            ViewState[ViewState_SoGiayChungSinh] = value;
        }
    }
    private void LoadData()
    {
        cbonhanvien.DataSource = GetDMNhanVienM();// combo 
        cbonhanvien.DataBind();
        cbodantoc.DataSource = GetDMDanToc();// combo 
        cbodantoc.DataBind();

        DataTable dt = spGiayChungSinh_Get(_MaBN, _MaBA, decimal.Parse(_SoGiayChungSinh));
        if (dt != null && dt.Rows.Count > 0)
        {
            txtSoGiayChungSinh.Text = dt.Rows[0]["SoGiayChungSinh"].ToString();
            //chkHuy.Checked = dt.Rows[0]["Huy"].ToString() == "False" ? false : true;
            //dtNgayTV.Text = dt.Rows[0]["NgayTV"].ToString();
            //dtNgayCap.Text = dt.Rows[0]["NgayCap"].ToString();
            txtMA_BHXH_NND.Text = dt.Rows[0]["MA_BHXH_NND"].ToString();
            txtHOTEN_NND.Text = dt.Rows[0]["HOTEN_NND"].ToString();
            dtNGAYSINH_NND.Text = dt.Rows[0]["NGAYSINH_NND"].ToString();
            //txtMA_DANTOC_NND.Text = dt.Rows[0]["MA_DANTOC_NND"].ToString();
            //txtSO_CMND_NND.Text = dt.Rows[0]["SO_CMND_NND"].ToString();
            dtNGAY_CAP_CCCD_NND.Text = dt.Rows[0]["NGAY_CAP_CCCD_NND"].ToString();
            txtNOI_CAP_CCCD_NND.Text = dt.Rows[0]["NOI_CAP_CCCD_NND"].ToString();
            txtNOI_DK_THUONGTRU_NDD.Text = dt.Rows[0]["NOI_DK_THUONGTRU_NDD"].ToString();
            txtHO_TEN_BO.Text = dt.Rows[0]["HO_TEN_BO"].ToString();

            SetRadioButtonListValues(rblGIOI_TINH_CON, Convert.ToByte(dt.Rows[0]["GIOI_TINH_CON"].ToString()));
            rblGIOI_TINH_CON.Text = dt.Rows[0]["GIOI_TINH_CON"].ToString();
            //SetRadioButtonListValues(rblNoiTuVong, Convert.ToByte(dt.Rows[0]["NoiTuVong"].ToString()));

            txtSO_CON.Text = dt.Rows[0]["SO_CON"].ToString();
            txtCAN_NANG_CON.Text = dt.Rows[0]["CAN_NANG_CON"].ToString();
            dtNGAY_SINH_CON.Text = dt.Rows[0]["NGAY_SINH_CON"].ToString();
            txtNOI_SINH_CON.Text = dt.Rows[0]["NOI_SINH_CON"].ToString();
            txtLAN_SINH.Text = dt.Rows[0]["LAN_SINH"].ToString();
            txtTINH_TRANG_CON.Text = dt.Rows[0]["TINH_TRANG_CON"].ToString();

            SetRadioButtonListValues(rblSINHCON_PHAUTHUAT, Convert.ToByte(dt.Rows[0]["SINHCON_PHAUTHUAT"].ToString() == "False" ? 1 : 0));
            SetRadioButtonListValues(rblSINHCON_DUOI32TUAN, Convert.ToByte(dt.Rows[0]["SINHCON_DUOI32TUAN"].ToString() == "False" ? 1 : 0));
            txtGHI_CHU.Text = dt.Rows[0]["GHI_CHU"].ToString();
            //txtNGUOI_DO_DE.Text = dt.Rows[0]["NGUOI_DO_DE"].ToString();
            txtNGUOI_GHI_PHIEU.Text = dt.Rows[0]["NGUOI_GHI_PHIEU"].ToString();
            //txtTHU_TRUONG_DVI.Text = dt.Rows[0]["THU_TRUONG_DVI"].ToString();
            dtNGAY_CT.Text = dt.Rows[0]["NGAY_CT"].ToString();
            //txtSO.Text = dt.Rows[0]["SO"].ToString();
            //txtQUYEN_SO.Text = dt.Rows[0]["QUYEN_SO"].ToString();


            //SetRadioButtonListValues(rblTVCC, Convert.ToByte(dt.Rows[0]["TVCC"].ToString() == "False" ? 1 : 0));
            //cbocdravien.SelectedValue = dt.Rows[0]["MaNNTV"].ToString();
            //cbocdravien.Text = dt.Rows[0]["TenNNTV"].ToString();
            //txtNguoiThan.Text = dt.Rows[0]["NguoiThan"].ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_SACH_CHI_TIET;
            base.Page_PreLoad(sender, e);
            if (Request["MaBN"] != null)
                _MaBN = Request["MaBN"];
            if (Request["MaBA"] != null)
                _MaBA = Request["MaBA"];
            if (Request["SoGiayBaoTu"] != null)
                _SoGiayChungSinh = Request["SoGiayBaoTu"];
            SetData();
        }
    }
    private void SetData()
    {
        _ThongtinBN = ThongtinBN.GetThongtinBN(_MaBN, DateTime.Now, 1, "", 1, 1);
        if (_ThongtinBN != null)
        {
            dtNGAYSINH_NND.Text = _ThongtinBN.NgaySinh;
            txtHOTEN_NND.Text = _ThongtinBN.Hoten;
            if (_ThongtinBN.GT == true)
            {
                lblGioitinh.Items[0].Selected = true;
                lblGioitinh.Items[1].Selected = false;
            }
            else
            {
                lblGioitinh.Items[1].Selected = true;
                lblGioitinh.Items[0].Selected = false;
            }
            txtTuoi.Text = _ThongtinBN.Tuoi.ToString();
            txtMaQL.Text = _ThongtinBN.MaBN;
            //txtNgheNghiep.Text = _ThongtinBN.TenNN;
            txtDiaChi.Text = _ThongtinBN.DiaChiC;
            txtDienThoai.Text = _ThongtinBN.DienThoai;
            txtSoThe.Text = _ThongtinBN.Sothe;
            txtSO_CMND_NND.Text = _ThongtinBN.SoCMT;
            //dtNGAYCAP_CMND.Text = _ThongtinBN.NGAYCAP_CMND;
            //txtNoiCapCMND.Text = _ThongtinBN.NOICAP_CMND;
            LoadData();
        }
    }
    //public bool CheckXoa(string MaPhieuGN, bool NhanOng)
    //{
    //    if (NhanOng == true)
    //        return true;
    //    else
    //    {
    //        DataTable dr = new DataTable();
    //        string tenStore = "spGiayBaoTu_CheckXoa";
    //        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
    //        using (SqlConnection Conection = new SqlConnection(StrConection))
    //        {
    //            Conection.Open();
    //            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //            {
    //                Command.CommandType = CommandType.StoredProcedure;
    //                Command.Parameters.Add(new SqlParameter("@MaPhieuGN", MaPhieuGN));
    //                SqlDataAdapter dp = new SqlDataAdapter(Command);
    //                dp.Fill(dr);
    //            }
    //            if (dr.Rows.Count == 0)
    //                return true;
    //            else
    //                return false;
    //        }
    //    }
    //}
    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        if (e.Item.Visible == true && e.Item.Enabled == true)
        {
            switch (e.Item.Value)
            {
                case "cmdSave":
                    //    Response.Redirect("~/UI/ChePhamMau/ChePhamMau/FrmNhanChiDinhLS.aspx?NhanOng="+_NhanOng.ToString()+"&MaKhoa="+cboKhoa.SelectedValue);
                    if (UpdateData())
                        SetData();
                    break;
                case "cmdView":
                    SetData();
                    break;
                //case "cmdPrintCD":
                //    if (UpdateData())
                //        PrintDataCD();
                //    break;
                case "cmdPrint":
                    if (UpdateData())
                        PrintData();
                    break;
                //case "cmdPrintLai":
                //    PrintLaiData();
                    //break;
                case "cmdExit":
                    Response.Redirect("~/Default.aspx");
                    break;
                case "cmdKy":
                    
                    break;
                default:
                    break;
            }
        }

    }
    //public void PrintDataCD()
    //{
    //    if (_ThongtinBN != null)
    //    {
    //        DataTable dt = spGiayChungSinh_Get(_MaBN, _MaBA, decimal.Parse(_SoGiayChungSinh));
    //        string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/giaychungsinh.rpt";
    //        ReportDocument rpt = new ReportDocument();
    //        rpt.Load(Server.MapPath(sPath));
    //        FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
    //        Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
    //        Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
    //        Myformulas["NguoiLap"].Text = "'" + Pub_sTenNguoiSD + "'";
    //        Myformulas["ThuTruong"].Text = "''";
    //        Myformulas["NgayBC"].Text = "'Hà Nội, ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year + "'";
    //        rpt.SetDataSource(dt);
    //        PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
    //    }
    //    else
    //        ShowMessage("Không có dữ liệu hiển thị!");
    //}
    public void PrintData()
    {

        string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/crGiayCNNghiDuongThai.rpt";
        DataTable dt = spGiayChungSinh_GetXML(_MaBN, _MaBA, decimal.Parse(_SoGiayChungSinh));

        if (dt.Rows.Count > 0)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(Server.MapPath(sPath));
            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
            Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV + "'";
            rpt.SetDataSource(dt);
            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
        }
        else
            ShowMessage("Không có dữ liệu hiển thị!");
    }
    //public void PrintLaiData()
    //{
    //    if (_ThongtinBN != null)
    //    {
    //        string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRDeNghiCapLaiGBT.rpt";
    //        DataTable dt = spDeNghiCapLaiGBT_Get(_MaBN, _MaBA);
    //        if (dt.Rows.Count > 0)
    //        {
    //            ReportDocument rpt = new ReportDocument();
    //            rpt.Load(Server.MapPath(sPath));
    //            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
    //            Myformulas["NgayBC"].Text = "'Làm tại Hà Nội ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year + "'";
    //            rpt.SetDataSource(dt);
    //            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
    //        }

    //        else
    //            ShowMessage("Không có dữ liệu hiển thị!");
    //    }
    //    else
    //        ShowMessage("Không có dữ liệu hiển thị!");
    //}
    protected void cboBenh_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhTat dataItem = e.Item.DataItem as DMBenhTat;

        if (dataItem == null)
            e.Item.Attributes["TenBenh"] = "";
        else
            e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
    }
    public bool UpdateData()
    {
        if (CheckData())
        {
            if (_ThongtinBN != null)
            {
                //DateTime NgayTV = DateTime.Parse(dtNgayTV.Text);
                string MA_BHXH_NND = txtMA_BHXH_NND.Text;
                string HOTEN_NND = txtHOTEN_NND.Text;
                DateTime d;
                DateTime NgaySinh_NND = new DateTime();
                if (DateTime.TryParse(dtNGAYSINH_NND.Text, out d))
                    NgaySinh_NND = d;
                //string MA_DANTOC_NND = txtMA_DANTOC_NND.Text;
                string SO_CMND_NND = txtSO_CMND_NND.Text;
                DateTime NGAY_CAP_CCCD_NND = new DateTime();
                if (DateTime.TryParse(dtNGAY_CAP_CCCD_NND.Text, out d))
                    NGAY_CAP_CCCD_NND = d;
                string NOI_CAP_CCCD_NND = txtNOI_CAP_CCCD_NND.Text;
                string NOI_DK_THUONGTRU_NDD = txtNOI_DK_THUONGTRU_NDD.Text;
                string HO_TEN_BO = txtHO_TEN_BO.Text;
                byte GIOI_TINH_CON = GetRadioButtonListValues(rblGIOI_TINH_CON);
                string SO_CON = txtSO_CON.Text;
                string CAN_NANG_CON = txtCAN_NANG_CON.Text;
                DateTime NGAY_SINH_CON = new DateTime();
                if (DateTime.TryParse(dtNGAY_SINH_CON.Text, out d))
                    NGAY_SINH_CON = d;
                string NOI_SINH_CON = txtNOI_SINH_CON.Text;

                string LAN_SINH = txtLAN_SINH.Text;
                string TINH_TRANG_CON = txtTINH_TRANG_CON.Text;
                bool SINHCON_PHAUTHUAT = GetRadioButtonListValues(rblSINHCON_PHAUTHUAT) == 0 ? true : false;
                bool SINHCON_DUOI32TUAN = GetRadioButtonListValues(rblSINHCON_DUOI32TUAN) == 0 ? true : false;


                string GHI_CHU = txtGHI_CHU.Text;

                //string NGUOI_DO_DE = txtNGUOI_DO_DE.Text;

                string NGUOI_GHI_PHIEU = txtNGUOI_GHI_PHIEU.Text;
                //string THU_TRUONG_DVI = txtTHU_TRUONG_DVI.Text;
                DateTime NGAY_CT = new DateTime();
                if (DateTime.TryParse(dtNGAY_CT.Text, out d))
                    NGAY_CT = d;
                //string SO = txtSO.Text;
                //string QUYEN_SO = txtQUYEN_SO.Text;


                //bool TVCC = GetRadioButtonListValues(rblTVCC) == 0 ? true : false;
                //string MaNNTV = cbocdravien.SelectedValue;
                //string TenNNTV = cbocdravien.Text;
                //string NguoiThan = txtNguoiThan.Text;
                //if ( dtNGAYCAP_CMND.Text != _ThongtinBN.NGAYCAP_CMND || txtNoiCapCMND.Text != _ThongtinBN.NOICAP_CMND || txtSoCMND.Text != _ThongtinBN.SoCMT)
                {
                    if (DateTime.TryParse(dtNGAY_CAP_CCCD_NND.Text, out d))
                    //    _ThongtinBN.NGAYCAP_CMND = dtNGAYCAP_CMND.Text;
                    //_ThongtinBN.NOICAP_CMND = txtNoiCapCMND.Text;
                    _ThongtinBN.SoCMT = txtSO_CMND_NND.Text;
                    _ThongtinBN.ApplyEdit();
                    _ThongtinBN.Save();
                    BenhNhan _benhnhan = BenhNhan.GetBenhNhan(_ThongtinBN.MaBN);
                    //_benhnhan.NGAYCAP_CMND = dtNGAYCAP_CMND.Text;
                    //_benhnhan.NOICAP_CMND = txtNoiCapCMND.Text;
                    _benhnhan.ApplyEdit();
                    _benhnhan.Save();
                }
                if (_SoGiayChungSinh == "0")
                {
                    //them moi giay bao tu
                    _SoGiayChungSinh = spGiayChungSinh_Create(_MaBA, _MaBN, MA_BHXH_NND, HOTEN_NND,   SO_CMND_NND, NGAY_CAP_CCCD_NND  == new DateTime() ? "" : NGAY_SINH_CON.ToString("yyyy-MM-dd HH:mm:ss"), NOI_CAP_CCCD_NND, NOI_DK_THUONGTRU_NDD, HO_TEN_BO, GIOI_TINH_CON, SO_CON, CAN_NANG_CON, NGAY_SINH_CON == new DateTime() ? "" : NGAY_SINH_CON.ToString("yyyy-MM-dd HH:mm:ss"), NOI_SINH_CON, LAN_SINH, TINH_TRANG_CON, SINHCON_PHAUTHUAT, SINHCON_DUOI32TUAN, GHI_CHU,  NGUOI_GHI_PHIEU,  NGAY_CT == new DateTime() ? "" : NGAY_CT.ToString("yyyy-MM-dd HH:mm:ss"));
                }
                else
                {
                    //cap nhat thong tin giay bao tu
                    spGiayChungSinh_Update(decimal.Parse(_SoGiayChungSinh), _MaBA, _MaBN, MA_BHXH_NND, HOTEN_NND, SO_CMND_NND, NGAY_CAP_CCCD_NND == new DateTime() ? "" : NGAY_SINH_CON.ToString("yyyy-MM-dd HH:mm:ss"), NOI_CAP_CCCD_NND, NOI_DK_THUONGTRU_NDD, HO_TEN_BO, GIOI_TINH_CON, SO_CON, CAN_NANG_CON, NGAY_SINH_CON == new DateTime() ? "" : NGAY_SINH_CON.ToString("yyyy-MM-dd HH:mm:ss"), NOI_SINH_CON, LAN_SINH, TINH_TRANG_CON, SINHCON_PHAUTHUAT, SINHCON_DUOI32TUAN, GHI_CHU, NGUOI_GHI_PHIEU, NGAY_CT == new DateTime() ? "" : NGAY_CT.ToString("yyyy-MM-dd HH:mm:ss"));
                }
                #region day giay bao tu len cong BHXH
                #region lay token
                //LAY port, username, passwword log in
                //DataTable dt = GetPort("GetTokenLoginGBT");
                string ngaysinh = DateTime.ParseExact(_ThongtinBN.NgaySinhD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None).ToString("yyyyMMdd");
                //if (dt != null && dt.Rows.Count > 0)
                //{
                //    string port = dt.Rows[0]["port"].ToString();
                //    string username = dt.Rows[0]["username"].ToString();
                //    string password = dt.Rows[0]["password"].ToString();
                //    string macskcb = dt.Rows[0]["Madvcs"].ToString();
                //    //lay token
                //    APIKey token = GetToken(port, username, password);
                DataTable TV = spGiayChungSinh_GetXML(_MaBA, _MaBN, decimal.Parse(_SoGiayChungSinh));
                //    if (token != null)
                if (TV.Rows.Count > 0)
                {
                    HSDLGCS hSDLGCS = new HSDLGCS();
                    List<GIAYCHUNGSINH> gIAYCHUNGSINHs = new List<GIAYCHUNGSINH>();
                    GIAYCHUNGSINH gIAYCHUNGSINH = new GIAYCHUNGSINH();
                    gIAYCHUNGSINH.MA_GCS = TV.Rows[0]["MA_GCS"].ToString();
                    gIAYCHUNGSINH.MA_BN = TV.Rows[0]["MA_BN"].ToString();
                    gIAYCHUNGSINH.MA_CT = TV.Rows[0]["MA_CT"].ToString();
                    gIAYCHUNGSINH.SO_SERI = TV.Rows[0]["SO_SERI"].ToString();
                    gIAYCHUNGSINH.MA_BHXH_NND = TV.Rows[0]["MA_BHXH_NND"].ToString();
                    gIAYCHUNGSINH.MA_THE_NND = TV.Rows[0]["MA_THE_NND"].ToString();
                    gIAYCHUNGSINH.HOTEN_NDD = TV.Rows[0]["HOTEN_NDD"].ToString();
                    gIAYCHUNGSINH.NGAYSINH_NDD = TV.Rows[0]["NGAYSINH_NDD"].ToString();
                    gIAYCHUNGSINH.MA_DANTOC_NDD = TV.Rows[0]["MA_DANTOC_NDD"].ToString();
                    gIAYCHUNGSINH.MA_QUOCTICH_NDD = TV.Rows[0]["MA_QUOCTICH_NDD"].ToString();
                    gIAYCHUNGSINH.LOAI_GIAYTO_NDD = int.Parse(TV.Rows[0]["LOAI_GIAYTO_NDD"].ToString());
                    gIAYCHUNGSINH.SO_CCCD_NDD = TV.Rows[0]["SO_CCCD_NDD"].ToString();
                    gIAYCHUNGSINH.NGAYCAP_CCCD_NDD = TV.Rows[0]["NGAYCAP_CCCD_NDD"].ToString();
                    gIAYCHUNGSINH.NOICAP_CCCD_NDD = TV.Rows[0]["NOICAP_CCCD_NDD"].ToString();
                    gIAYCHUNGSINH.NOI_CU_TRU_NDD = TV.Rows[0]["NOI_CU_TRU_NDD"].ToString();
                    gIAYCHUNGSINH.MATINH_CU_TRU = TV.Rows[0]["MATINH_CU_TRU"].ToString();
                    gIAYCHUNGSINH.MAHUYEN_CU_TRU = TV.Rows[0]["MAHUYEN_CU_TRU"].ToString();
                    gIAYCHUNGSINH.MAXA_CU_TRU = TV.Rows[0]["MAXA_CU_TRU"].ToString();
                    gIAYCHUNGSINH.HO_TEN_CHA = TV.Rows[0]["HO_TEN_CHA"].ToString();
                    gIAYCHUNGSINH.MA_THE_TAM = TV.Rows[0]["MA_THE_TAM"].ToString();
                    gIAYCHUNGSINH.GIOI_TINH_CON = int.Parse(TV.Rows[0]["GIOI_TINH_CON"].ToString());
                    gIAYCHUNGSINH.TEN_CON = TV.Rows[0]["TEN_CON"].ToString();
                    gIAYCHUNGSINH.SO_CON = TV.Rows[0]["SO_CON"].ToString();
                    gIAYCHUNGSINH.LAN_SINH = int.Parse(TV.Rows[0]["LAN_SINH"].ToString());
                    gIAYCHUNGSINH.SO_CON_SONG = int.Parse(TV.Rows[0]["SO_CON_SONG"].ToString());
                    gIAYCHUNGSINH.CAN_NANG_CON = TV.Rows[0]["CAN_NANG_CON"].ToString();
                    gIAYCHUNGSINH.NGAY_SINH_CON = TV.Rows[0]["NGAY_SINH_CON"].ToString();
                    gIAYCHUNGSINH.NOI_SINH_CON = TV.Rows[0]["NOI_SINH_CON"].ToString();
                    gIAYCHUNGSINH.TINH_TRANG_CON = TV.Rows[0]["TINH_TRANG_CON"].ToString();
                    gIAYCHUNGSINH.SINHCON_DUOI32TUAN = int.Parse(TV.Rows[0]["SINHCON_DUOI32TUAN"].ToString());
                    gIAYCHUNGSINH.SINHCON_PHAUTHUAT = int.Parse(TV.Rows[0]["SINHCON_PHAUTHUAT"].ToString());
                    gIAYCHUNGSINH.GHI_CHU = TV.Rows[0]["GHI_CHU"].ToString();
                    gIAYCHUNGSINH.NGUOI_DO_DE = TV.Rows[0]["NGUOI_DO_DE"].ToString();
                    gIAYCHUNGSINH.NGUOI_GHI_PHIEU = TV.Rows[0]["NGUOI_GHI_PHIEU"].ToString();
                    gIAYCHUNGSINH.MA_TTDV = int.Parse(TV.Rows[0]["MA_TTDV"].ToString());
                    gIAYCHUNGSINH.NGAY_CT = TV.Rows[0]["NGAY_CT"].ToString();
                    gIAYCHUNGSINH.SO = TV.Rows[0]["SO"].ToString();
                    gIAYCHUNGSINH.QUYEN_SO = TV.Rows[0]["QUYEN_SO"].ToString();


                    DMDantocList dMDantocs = DMDantocList.GetAllDMDantoc();
                    gIAYCHUNGSINHs.Add(gIAYCHUNGSINH);
                    hSDLGCS.GIAYCHUNGSINH = gIAYCHUNGSINHs;
                    //tao file xml
                    string filename = "";
                    DateTime tungay;
                    DateTime denngay;
                    tungay = DateTime.Now.AddMinutes(-10).AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                    denngay = DateTime.Now.AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                    string _tungay = tungay.ToString("dd/MM/yyyy HH:mm");
                    string _denngay = denngay.ToString("dd/MM/yyyy HH:mm");
                    filename = System.Web.Hosting.HostingEnvironment.MapPath(@"~\GBT\BHXH" + txtMaQL.Text.Trim() + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + ".XML");
                    filename = txtMaQL.Text.Trim() + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + ".XML";
                    string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                    if (!Directory.Exists(Server.MapPath(fileSavePath)))
                        Directory.CreateDirectory(Server.MapPath(fileSavePath));
                    //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
                    if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + Pub_sMaMay + "" + filename))
                        File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + Pub_sMaMay + "" + filename);

                    //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                    fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + Pub_sMaMay + "" + filename;

                    if (File.Exists(filename))
                    {
                        FileInfo fi = new FileInfo(filename);
                        if (fi.IsReadOnly)
                            fi.IsReadOnly = false;
                        fi.Delete();
                    }
                    XmlSerializer xs = new XmlSerializer(typeof(HSDLGCS));
                    TextWriter txtWriter = new StreamWriter(filename, false, Encoding.UTF8);
                    xs.Serialize(txtWriter, hSDLGCS);
                    txtWriter.Close();
                    string popupScript;
                    popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";
                    Context.Response.Write(popupScript);
                }
                //}
                #endregion
                #endregion
                return true;
            }
            else
            {
                ShowMessage("Thông tin bệnh nhân không tồn tại! Không thể lưu dữ liệu!");
                return false;
            }
        }
        else return false;
    }
    private void SetRadioButtonListValues(RadioButtonList opt, byte value)
    {
        //foreach (ListItem item in opt.Items)
        //{
        //    if (item.Value.Equals(value, StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        item.Selected = true;
        //        break;
        //    }
        //    else
        //        item.Selected = false;
        //}
        if (value <= opt.Items.Count)
            opt.Items[value].Selected = true;
    }
    private byte GetRadioButtonListValues(RadioButtonList opt)
    {
        //foreach (ListItem item in opt.Items)
        //{
        //    if (item.Selected)
        //    {
        //        return Int32.Parse(item.Value) == 1 ? true : false;
        //    }
        //}
        byte kq = Convert.ToByte(opt.Items.Count - 1);
        for (byte i = 0; i < opt.Items.Count; i++)
            if (opt.Items[i].Selected == true)
                kq = i;
        return kq;
    }
    public string spGiayChungSinh_Create(string MaBA, string MaBN, string MA_BHXH_NND,string HOTEN_NND, string SO_CMND_NND,string NGAY_CAP_CCCD_NND,string NOI_CAP_CCCD_NND,string NOI_DK_THUONGTRU_NDD  ,  string HO_TEN_BO,byte GIOI_TINH_CON, string SO_CON , string CAN_NANG_CON, string NGAY_SINH_CON , string NOI_SINH_CON , string LAN_SINH , string TINH_TRANG_CON , bool SINHCON_PHAUTHUAT,bool SINHCON_DUOI32TUAN , string GHI_CHU ,  string NGUOI_GHI_PHIEU ,  string NGAY_CT)
    {
        string tenStore = "GiayChungSinh_CreateOrUpdate";
        DataTable dr = new DataTable();
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA  ", MaBA));
                Command.Parameters.Add(new SqlParameter("@MA_BHXH_NND ", MA_BHXH_NND));
                Command.Parameters.Add(new SqlParameter("@HOTEN_NND ", HOTEN_NND));
                //Command.Parameters.Add(new SqlParameter("@NGAYSINH_NND ", NGAYSINH_NND));
                //Command.Parameters.Add(new SqlParameter("@MA_DANTOC_NND ", MA_DANTOC_NND));
                Command.Parameters.Add(new SqlParameter("@SO_CMND_NND", SO_CMND_NND));
                Command.Parameters.Add(new SqlParameter("@NGAY_CAP_CCCD_NND ", NGAY_CAP_CCCD_NND));
                Command.Parameters.Add(new SqlParameter("@NOI_CAP_CCCD_NND ", NOI_CAP_CCCD_NND));
                Command.Parameters.Add(new SqlParameter("@NOI_DK_THUONGTRU_NDD", NOI_DK_THUONGTRU_NDD));
                Command.Parameters.Add(new SqlParameter("@HO_TEN_BO", HO_TEN_BO));
                Command.Parameters.Add(new SqlParameter("@GIOI_TINH_CON", GIOI_TINH_CON));
                Command.Parameters.Add(new SqlParameter("@SO_CON ", SO_CON));
                Command.Parameters.Add(new SqlParameter("@CAN_NANG_CON ", CAN_NANG_CON));
                Command.Parameters.Add(new SqlParameter("@NGAY_SINH_CON ", NGAY_SINH_CON));
                Command.Parameters.Add(new SqlParameter("@NOI_SINH_CON ", NOI_SINH_CON));
                Command.Parameters.Add(new SqlParameter("@LAN_SINH ", LAN_SINH));
                Command.Parameters.Add(new SqlParameter("@TINH_TRANG_CON ", TINH_TRANG_CON));
                Command.Parameters.Add(new SqlParameter("@SINHCON_PHAUTHUAT", SINHCON_PHAUTHUAT));
                Command.Parameters.Add(new SqlParameter("@SINHCON_DUOI32TUAN ", SINHCON_DUOI32TUAN));
                Command.Parameters.Add(new SqlParameter("@GHI_CHU ", GHI_CHU));
                //Command.Parameters.Add(new SqlParameter("@NGUOI_DO_DE ", NGUOI_DO_DE));
                Command.Parameters.Add(new SqlParameter("@NGUOI_GHI_PHIEU ", NGUOI_GHI_PHIEU));
                //Command.Parameters.Add(new SqlParameter("@THU_TRUONG_DVI ", THU_TRUONG_DVI));
                Command.Parameters.Add(new SqlParameter("@NGAY_CT ", NGAY_CT));
                Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                Command.Parameters.Add(new SqlParameter("@NguoiSD", Pub_sNguoiSD));
                //Command.Parameters.Add(new SqlParameter("@CanNang", CanNang));
                //Command.Parameters.Add(new SqlParameter("@SoTuanMangThai", SoTuanMangThai));
                //Command.Parameters.Add(new SqlParameter("@TuoiMe", TuoiMe));
                //Command.Parameters.Add(new SqlParameter("@ChuSinh", ChuSinh));
                //Command.Parameters.Add(new SqlParameter("@MangThai", MangThai));
                //Command.Parameters.Add(new SqlParameter("@ThoiDiemMangThai", ThoiDiemMangThai));
                //Command.Parameters.Add(new SqlParameter("@MangThaiGayTV", MangThaiGayTV));
                //Command.Parameters.Add(new SqlParameter("@TVCC", TVCC));
                //Command.Parameters.Add(new SqlParameter("@MaNNTV", MaNNTV));
                //Command.Parameters.Add(new SqlParameter("@TenNNTV", TenNNTV));
                //Command.Parameters.Add(new SqlParameter("@NguoiLap", Pub_sNguoiSD));
                //Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                //Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                //Command.Parameters.Add(new SqlParameter("@NguoiThan", NguoiThan));
                //Command.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Dispose();
            Conection.Close();
            if (dr.Rows.Count == 0)
                return "";
            else
                return dr.Rows[0][0].ToString();
        }
    }
    public void spGiayChungSinh_Update(decimal SoGiayChungSinh, string MaBA, string MaBN, string MA_BHXH_NND, string HOTEN_NND, string SO_CMND_NND, string NGAY_CAP_CCCD_NND, string NOI_CAP_CCCD_NND, string NOI_DK_THUONGTRU_NDD, string HO_TEN_BO, byte GIOI_TINH_CON, string SO_CON, string CAN_NANG_CON, string NGAY_SINH_CON, string NOI_SINH_CON, string LAN_SINH, string TINH_TRANG_CON, bool SINHCON_PHAUTHUAT, bool SINHCON_DUOI32TUAN, string GHI_CHU, string NGUOI_GHI_PHIEU, string NGAY_CT)
    {
        string tenStore = "GiayChungSinh_CreateOrUpdate";
        DataTable dr = new DataTable();
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@SoGiayChungSinh", SoGiayChungSinh));
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA  ", MaBA));
                Command.Parameters.Add(new SqlParameter("@MA_BHXH_NND ", MA_BHXH_NND));
                Command.Parameters.Add(new SqlParameter("@HOTEN_NND ", HOTEN_NND));
                //Command.Parameters.Add(new SqlParameter("@NGAYSINH_NND ", NGAYSINH_NND));
                //Command.Parameters.Add(new SqlParameter("@MA_DANTOC_NND ", MA_DANTOC_NND));
                Command.Parameters.Add(new SqlParameter("@SO_CMND_NND", SO_CMND_NND));
                Command.Parameters.Add(new SqlParameter("@NGAY_CAP_CCCD_NND ", NGAY_CAP_CCCD_NND));
                Command.Parameters.Add(new SqlParameter("@NOI_CAP_CCCD_NND ", NOI_CAP_CCCD_NND));
                Command.Parameters.Add(new SqlParameter("@NOI_DK_THUONGTRU_NDD", NOI_DK_THUONGTRU_NDD));
                Command.Parameters.Add(new SqlParameter("@HO_TEN_BO", HO_TEN_BO));
                Command.Parameters.Add(new SqlParameter("@GIOI_TINH_CON", GIOI_TINH_CON));
                Command.Parameters.Add(new SqlParameter("@SO_CON ", SO_CON));
                Command.Parameters.Add(new SqlParameter("@CAN_NANG_CON ", CAN_NANG_CON));
                Command.Parameters.Add(new SqlParameter("@NGAY_SINH_CON ", NGAY_SINH_CON));
                Command.Parameters.Add(new SqlParameter("@NOI_SINH_CON ", NOI_SINH_CON));
                Command.Parameters.Add(new SqlParameter("@LAN_SINH ", LAN_SINH));
                Command.Parameters.Add(new SqlParameter("@TINH_TRANG_CON ", TINH_TRANG_CON));
                Command.Parameters.Add(new SqlParameter("@SINHCON_PHAUTHUAT", SINHCON_PHAUTHUAT));
                Command.Parameters.Add(new SqlParameter("@SINHCON_DUOI32TUAN ", SINHCON_DUOI32TUAN));
                Command.Parameters.Add(new SqlParameter("@GHI_CHU ", GHI_CHU));
                //Command.Parameters.Add(new SqlParameter("@NGUOI_DO_DE ", NGUOI_DO_DE));
                Command.Parameters.Add(new SqlParameter("@NGUOI_GHI_PHIEU ", NGUOI_GHI_PHIEU));
                //Command.Parameters.Add(new SqlParameter("@THU_TRUONG_DVI ", THU_TRUONG_DVI));
                Command.Parameters.Add(new SqlParameter("@NGAY_CT ", NGAY_CT));
                
                Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                Command.Parameters.Add(new SqlParameter("@NguoiSD", Pub_sNguoiSD));
                Command.ExecuteNonQuery();
            }
            Conection.Dispose();
            Conection.Close();
        }
    }
    public DataTable spGiayChungSinh_Get(string MaBN, string MaBA, decimal SoGiayChungSinh)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayChungSinh_Get";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@SoGiayChungSinh", SoGiayChungSinh));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    //public DataTable spDeNghiCapLaiGBT_Get(string MaBN, string MaBA)
    //{
    //    DataTable dr = new DataTable();
    //    string tenStore = "spDeNghiCapLaiGBT_Get";
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
    //            Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
    //            SqlDataAdapter dp = new SqlDataAdapter(Command);
    //            dp.Fill(dr);
    //        }
    //        Conection.Close();
    //        Conection.Dispose();
    //        return dr;
    //    }
    //}
    //public DataTable spGiayTuVong_SoGiay_GetMin(string MaBN, string MaBA)
    //{
    //    DataTable dr = new DataTable();
    //    string tenStore = "spGiayTuVong_SoGiay_GetMin";
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
    //            Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
    //            SqlDataAdapter dp = new SqlDataAdapter(Command);
    //            dp.Fill(dr);
    //        }
    //        Conection.Close();
    //        Conection.Dispose();
    //        return dr;
    //    }
    //}
    public DataTable spGiayChungSinh_GetXML(string MaBN, string MaBA, decimal SoGiayChungSinh)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayChungSinh_GetXML";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@SoGiayChungSinh", SoGiayChungSinh));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    public bool CheckData()
    {
        DateTime d;
        if (dtNGAY_SINH_CON.Text != "" && !DateTime.TryParse(dtNGAY_SINH_CON.Text, out d))
        {
            ShowMessage("Ngày sinh con sai định dạng!");
            dtNGAY_SINH_CON.Text = "";
            dtNGAY_SINH_CON.Focus();
            return false;
        }
        else if (dtNGAY_CT.Text != "" && !DateTime.TryParse(dtNGAY_CT.Text, out d))
        {
            ShowMessage("Ngày cấp giấy sai định dạng!");
            dtNGAY_CT.Text = "";
            dtNGAY_CT.Focus();
            return false;
        }
        else return true;

    }
    #region API Giay Chung Sinh
    #region object
    public class HSDLGCS
    {
        public List<GIAYCHUNGSINH> GIAYCHUNGSINH { get; set; }
    }

    public class GIAYCHUNGSINH
    {
        public string MA_GCS { get; set; }
        public string MA_BN { get; set; }
        public string MA_CT { get; set; }
        public string SO_SERI { get; set; }
        public string MA_BHXH_NND { get; set; }
        public string MA_THE_NND { get; set; }
        public string HOTEN_NDD { get; set; }
        public string NGAYSINH_NDD { get; set; }
        public string MA_DANTOC_NDD { get; set; }
        public string MA_QUOCTICH_NDD { get; set; }
        public int LOAI_GIAYTO_NDD { get; set; }
        public string SO_CCCD_NDD { get; set; }
        public string NGAYCAP_CCCD_NDD { get; set; }
        public string NOICAP_CCCD_NDD { get; set; }
        public string NOI_CU_TRU_NDD { get; set; }
        public string MATINH_CU_TRU { get; set; }
        public string MAHUYEN_CU_TRU { get; set; }
        public string MAXA_CU_TRU { get; set; }
        public string HO_TEN_CHA { get; set; }
        public string MA_THE_TAM { get; set; }
        public string TEN_CON { get; set; }
        public int GIOI_TINH_CON { get; set; }
        public string SO_CON { get; set; }
        public int LAN_SINH { get; set; }
        public int SO_CON_SONG { get; set; }
        public string CAN_NANG_CON { get; set; }
        public string NGAY_SINH_CON { get; set; }
        public string NOI_SINH_CON { get; set; }
        public string TINH_TRANG_CON { get; set; }
        public int SINHCON_PHAUTHUAT { get; set; }
        public int SINHCON_DUOI32TUAN { get; set; }
        public string GHI_CHU { get; set; }
        public string NGUOI_DO_DE { get; set; }
        public string NGUOI_GHI_PHIEU { get; set; }
        public int MA_TTDV { get; set; }
        public string THU_TRUONG_DVI { get; set; }
        public string NGAY_CT { get; set; }
        public string SO { get; set; }
        public string QUYEN_SO { get; set; }
    }
    public class bodylogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class loginrequest
    {
        public string maKetQua { get; set; }
        public APIKey APIKey { get; set; }
    }

    public class APIKey
    {
        public string access_token { get; set; }
        public string id_token { get; set; }
        public string token_type { get; set; }
        public string username { get; set; }
        public string expires_in { get; set; }
    }

    public class giaychungsinhsend
    {
        public string maCskcb { get; set; }
        public string token { get; set; }
        public string id_token { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int loaiHs { get; set; }
        public string fileBase64Str { get; set; }
    }

    public class giaychungsinhrequest
    {
        public string MaKetQua { get; set; }
        public string MaGD { get; set; }
        public string ThoiGianTiepNhan { get; set; }
    }
    #endregion
    //ham ma hoa MD5
    public String GetMD5(string txt)
    {
        String str = "";
        Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        buffer = md5.ComputeHash(buffer);
        foreach (Byte b in buffer)
        {
            str += b.ToString("X2");
        }
        return str;
    }
    //ham lay thong tin port
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
                //Command.Parameters.Add(new SqlParameter("@Loai", "View"));
                Command.Parameters.Add(new SqlParameter("@Loai", loai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            //if (dr.Rows.Count > 0)
            //    return dr.Rows[0][0].ToString();
            //else
            //    return "";
            return dr;
        }
    }
    //ham post API
    public string PostOrder(string url, object send)
    {
        var serializer = new JavaScriptSerializer();
        string serializedResult = serializer.Serialize(send);
        Uri myUri = new Uri(url);
        WebRequest myWebRequest = HttpWebRequest.Create(myUri);
        myWebRequest.ContentType = "application/json";
        myWebRequest.Method = "POST";
        HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
        myHttpWebRequest.PreAuthenticate = true;
        //myHttpWebRequest.Headers.Add("Authorization", "Basic " + token);
        using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
        {
            streamWriter.Write(serializedResult);
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
        //return xau;
    }
    //ham get token
    public APIKey GetToken(string url, string username, string password)
    {
        APIKey kq = null;
        try
        {
            bodylogin b = new bodylogin();
            b.username = username;
            b.password = password;
            string xau = PostOrder(url, b);
            var returndata = JsonConvert.DeserializeObject<loginrequest>(xau);
            if (returndata != null)
            {
                kq = returndata.APIKey;
            }
        }
        catch (Exception ex)
        {
            kq = null;
            WriteLog("Login error: " + ex.ToString());
        }
        return kq;
    }
    //ham ghi log ra file
    public static void WriteLog(string log)
    {
        string logname = "GBTLog_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
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
    #endregion


    private static string ConnectString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        }
    }


    public static List<DMNhanVienM> GetDMNhanVienM()
    {
        List<DMNhanVienM> List = new List<DMNhanVienM>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNHANVIEN_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMNhanVienM(dr, i));
            }
        }
        return List;
    }

    public class DMNhanVienM
    {
        private String _maNV = String.Empty;
        private String _HoTen = String.Empty;
        private String _maChucVu = String.Empty;
        private String _maLoaiHD = String.Empty;
        private String _maChuyenMon = String.Empty;
        private String _maKhoa = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private Boolean _KhongSD = false;
        private String _nguoiSD1 = String.Empty;
        private DateTime _ngaySD1;
        private String _maQL = String.Empty;
        private String _maCD = String.Empty;
        private String _TenTat = String.Empty;
        private String _GhiChu = String.Empty;
        private String _ghichu = String.Empty;
        private String _idnhanvien = String.Empty;
        private String _maNV1 = String.Empty;
        private String _DienThoai = String.Empty;
        private String _maChungChiHanhNghe = String.Empty;
        private String _NguoiGiamHo = String.Empty;
        private String _TenNguoiGiamHo = String.Empty;
        private String _DienThoaiKhoa = String.Empty;
        private String _ChuKy = String.Empty;
        //private String _maBHXH = String.Empty;
        private String _TenCV = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private String _TenKhoa = String.Empty;
        private String _TENCHUYENMON = String.Empty;
        private String _TENCD = String.Empty;
        private String _TenLoaiHD = String.Empty;
        private int _OrderNumber;

        public String MaNV
        {
            get
            {
                return _maNV;
            }
            set
            {
                if (_maNV != value)
                {
                    _maNV = value;
                }
            }
        }
        public String HoTen
        {
            get
            {
                return _HoTen;
            }
            set
            {
                if (_HoTen != value)
                {
                    _HoTen = value;
                }
            }
        }
        public String MaChucVu
        {
            get
            {
                return _maChucVu;
            }
            set
            {
                if (_maChucVu != value)
                {
                    _maChucVu = value;
                }
            }
        }
        public String MaLoaiHD
        {
            get
            {
                return _maLoaiHD;
            }
            set
            {
                if (_maLoaiHD != value)
                {
                    _maLoaiHD = value;
                }
            }
        }
        public String MaChuyenMon
        {
            get
            {
                return _maChuyenMon;
            }
            set
            {
                if (_maChuyenMon != value)
                {
                    _maChuyenMon = value;
                }
            }
        }
        public String MaKhoa
        {
            get
            {
                return _maKhoa;
            }
            set
            {
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                }
            }
        }
        public String MaMay
        {
            get
            {
                return _maMay;
            }
            set
            {
                if (_maMay != value)
                {
                    _maMay = value;
                }
            }
        }
        public Boolean Huy
        {
            get
            {
                return _huy;
            }
            set
            {
                if (_huy != value)
                {
                    _huy = value;
                }
            }
        }
        public string NgaySD
        {
            get
            {
                return _ngaySD.ToString("dd/MM/yyyy HH:mm");
            }
            set
            {
                DateTime d;

                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture,
                           DateTimeStyles.None, out d))
                {
                    _ngaySD = d;
                }
            }
        }
        public String NguoiSD
        {
            get
            {
                return _nguoiSD;
            }
            set
            {
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                }
            }
        }
        public Boolean KhongSD
        {
            get
            {
                return _KhongSD;
            }
            set
            {
                if (_KhongSD != value)
                {
                    _KhongSD = value;
                }
            }
        }
        public String NguoiSD1
        {
            get
            {
                return _nguoiSD1;
            }
            set
            {
                if (_nguoiSD1 != value)
                {
                    _nguoiSD1 = value;
                }
            }
        }
        public string NgaySD1
        {
            get
            {
                return _ngaySD1.ToString("dd/MM/yyyy HH:mm");
            }
            set
            {
                DateTime d;

                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture,
                           DateTimeStyles.None, out d))
                {
                    _ngaySD1 = d;
                }
            }
        }
        public String MaQL
        {
            get
            {
                return _maQL;
            }
            set
            {
                if (_maQL != value)
                {
                    _maQL = value;
                }
            }
        }
        public String MaCD
        {
            get
            {
                return _maCD;
            }
            set
            {
                if (_maCD != value)
                {
                    _maCD = value;
                }
            }
        }
        public String TenTat
        {
            get
            {
                return _TenTat;
            }
            set
            {
                if (_TenTat != value)
                {
                    _TenTat = value;
                }
            }
        }
        public String GhiChu
        {
            get
            {
                return _GhiChu;
            }
            set
            {
                if (_GhiChu != value)
                {
                    _GhiChu = value;
                }
            }
        }
        public String ghichu
        {
            get
            {
                return _ghichu;
            }
            set
            {
                if (_ghichu != value)
                {
                    _ghichu = value;
                }
            }
        }
        public String idnhanvien
        {
            get
            {
                return _idnhanvien;
            }
            set
            {
                if (_idnhanvien != value)
                {
                    _idnhanvien = value;
                }
            }
        }
        public String manv1
        {
            get
            {
                return _maNV1;
            }
            set
            {
                if (_maNV1 != value)
                {
                    _maNV1 = value;
                }
            }
        }
        public String DienThoai
        {
            get
            {
                return _DienThoai;
            }
            set
            {
                if (_DienThoai != value)
                {
                    _DienThoai = value;
                }
            }
        }
        public String MaChungChiHanhNghe
        {
            get
            {
                return _maChungChiHanhNghe;
            }
            set
            {
                if (_maChungChiHanhNghe != value)
                {
                    _maChungChiHanhNghe = value;
                }
            }
        }
        public String NguoiGiamHo
        {
            get
            {
                return _NguoiGiamHo;
            }
            set
            {
                if (_NguoiGiamHo != value)
                {
                    _NguoiGiamHo = value;
                }
            }
        }
        public String TenNguoiGiamHo
        {
            get
            {
                return _TenNguoiGiamHo;
            }
            set
            {
                if (_TenNguoiGiamHo != value)
                {
                    _TenNguoiGiamHo = value;
                }
            }
        }
        public String DienThoaiKhoa
        {
            get
            {
                return _DienThoaiKhoa;
            }
            set
            {
                if (_DienThoaiKhoa != value)
                {
                    _DienThoaiKhoa = value;
                }
            }
        }
        public String ChuKy
        {
            get
            {
                return _ChuKy;
            }
            set
            {
                if (_ChuKy != value)
                {
                    _ChuKy = value;
                }
            }
        }
        //public String MaBHXH
        //{
        //    get
        //    {
        //        return _maBHXH;
        //    }
        //    set
        //    {
        //        if (_maBHXH != value)
        //        {
        //            _maBHXH = value;
        //        }
        //    }
        //}
        public String TenCV
        {
            get
            {
                return _TenCV;
            }
            set
            {
                if (_TenCV != value)
                {
                    _TenCV = value;
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                return _TenNguoiSD;
            }
            set
            {
                if (_TenNguoiSD != value)
                {
                    _TenNguoiSD = value;
                }
            }
        }
        public String TenKhoa
        {
            get
            {
                return _TenKhoa;
            }
            set
            {
                if (_TenKhoa != value)
                {
                    _TenKhoa = value;
                }
            }
        }
        public String TENCHUYENMON
        {
            get
            {
                return _TENCHUYENMON;
            }
            set
            {
                if (_TENCHUYENMON != value)
                {
                    _TENCHUYENMON = value;
                }
            }
        }
        public String TENCD
        {
            get
            {
                return _TENCD;
            }
            set
            {
                if (_TENCD != value)
                {
                    _TENCD = value;
                }
            }
        }
        public String TenLoaiHD
        {
            get
            {
                return _TenLoaiHD;
            }
            set
            {
                if (_TenLoaiHD != value)
                {
                    _TenLoaiHD = value;
                }
            }
        }

        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

        public DMNhanVienM(IDataReader dr, int stt)

        {
            this.OrderNumber = stt;


            if (dr["MaNV"].GetType().Name != "DBNull" && dr["MaNV"] != null)
            {
                this.MaNV = Convert.ToString(dr["MaNV"]);
            }
            else
            {
                this.MaNV = "";
            }
            if (dr["HoTen"].GetType().Name != "DBNull" && dr["HoTen"] != null)
            {
                this.HoTen = Convert.ToString(dr["HoTen"]);
            }
            else
            {
                this.HoTen = "";
            }
            if (dr["MaChucVu"].GetType().Name != "DBNull" && dr["MaChucVu"] != null)
            {
                this.MaChucVu = Convert.ToString(dr["MaChucVu"]);
            }
            else
            {
                this.MaChucVu = "";
            }
            if (dr["MaLoaiHD"].GetType().Name != "DBNull" && dr["MaLoaiHD"] != null)
            {
                this.MaLoaiHD = Convert.ToString(dr["MaLoaiHD"]);
            }
            else
            {
                this.MaLoaiHD = "";
            }
            if (dr["MaChuyenMon"].GetType().Name != "DBNull" && dr["MaChuyenMon"] != null)
            {
                this.MaChuyenMon = Convert.ToString(dr["MaChuyenMon"]);
            }
            else
            {
                this.MaChuyenMon = "";
            }
            if (dr["MaKhoa"].GetType().Name != "DBNull" && dr["MaKhoa"] != null)
            {
                this.MaKhoa = Convert.ToString(dr["MaKhoa"]);
            }
            else
            {
                this.MaKhoa = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToString(dr["NgaySD"]);
            }
            else
            {
                this.NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
            if (dr["KhongSD"].GetType().Name != "DBNull" && dr["KhongSD"] != null)
            {
                this.KhongSD = Convert.ToBoolean(dr["KhongSD"]);
            }
            else
            {
                this.KhongSD = false;
            }
            if (dr["NguoiSD1"].GetType().Name != "DBNull" && dr["NguoiSD1"] != null)
            {
                this.NguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
            }
            else
            {
                this.NguoiSD1 = "";
            }
            if (dr["NgaySD1"].GetType().Name != "DBNull" && dr["NgaySD1"] != null)
            {
                this.NgaySD1 = Convert.ToString(dr["NgaySD1"]);
            }
            else
            {
                this.NgaySD1 = "";
            }
            if (dr["MaQL"].GetType().Name != "DBNull" && dr["MaQL"] != null)
            {
                this.MaQL = Convert.ToString(dr["MaQL"]);
            }
            else
            {
                this.MaQL = "";
            }
            if (dr["MaCD"].GetType().Name != "DBNull" && dr["MaCD"] != null)
            {
                this.MaCD = Convert.ToString(dr["MaCD"]);
            }
            else
            {
                this.MaCD = "";
            }
            if (dr["TenTat"].GetType().Name != "DBNull" && dr["TenTat"] != null)
            {
                this.TenTat = Convert.ToString(dr["TenTat"]);
            }
            else
            {
                this.TenTat = "";
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            if (dr["ghichu"].GetType().Name != "DBNull" && dr["ghichu"] != null)
            {
                this.ghichu = Convert.ToString(dr["ghichu"]);
            }
            else
            {
                this.ghichu = "";
            }
            if (dr["idnhanvien"].GetType().Name != "DBNull" && dr["idnhanvien"] != null)
            {
                this.idnhanvien = Convert.ToString(dr["idnhanvien"]);
            }
            else
            {
                this.idnhanvien = "";
            }
            if (dr["manv1"].GetType().Name != "DBNull" && dr["manv1"] != null)
            {
                this.manv1 = Convert.ToString(dr["manv1"]);
            }
            else
            {
                this.manv1 = "";
            }
            if (dr["DienThoai"].GetType().Name != "DBNull" && dr["DienThoai"] != null)
            {
                this.DienThoai = Convert.ToString(dr["DienThoai"]);
            }
            else
            {
                this.DienThoai = "";
            }
            if (dr["MaChungChiHanhNghe"].GetType().Name != "DBNull" && dr["MaChungChiHanhNghe"] != null)
            {
                this.MaChungChiHanhNghe = Convert.ToString(dr["MaChungChiHanhNghe"]);
            }
            else
            {
                this.MaChungChiHanhNghe = "";
            }
            if (dr["NguoiGiamHo"].GetType().Name != "DBNull" && dr["NguoiGiamHo"] != null)
            {
                this.NguoiGiamHo = Convert.ToString(dr["NguoiGiamHo"]);
            }
            else
            {
                this.NguoiGiamHo = "";
            }
            if (dr["TenNguoiGiamHo"].GetType().Name != "DBNull" && dr["TenNguoiGiamHo"] != null)
            {
                this.TenNguoiGiamHo = Convert.ToString(dr["TenNguoiGiamHo"]);
            }
            else
            {
                this.TenNguoiGiamHo = "";
            }
            if (dr["DienThoaiKhoa"].GetType().Name != "DBNull" && dr["DienThoaiKhoa"] != null)
            {
                this.DienThoaiKhoa = Convert.ToString(dr["DienThoaiKhoa"]);
            }
            else
            {
                this.DienThoaiKhoa = "";
            }
            if (dr["ChuKy"].GetType().Name != "DBNull" && dr["ChuKy"] != null)
            {
                this.ChuKy = Convert.ToString(dr["ChuKy"]);
            }
            else
            {
                this.ChuKy = "";
            }
            //if (dr["MaBHXH"].GetType().Name != "DBNull" && dr["MaBHXH"] != null)
            //{
            //    this.MaBHXH = Convert.ToString(dr["MaBHXH"]);
            //}
            //else
            //{
            //    this.MaBHXH = "";
            //}
            if (dr["TENCV"].GetType().Name != "DBNull" && dr["TENCV"] != null)
            {
                this.TenCV = Convert.ToString(dr["TENCV"]);
            }
            else
            {
                this.TenCV = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenKhoa"].GetType().Name != "DBNull" && dr["TenKhoa"] != null)
            {
                this.TenKhoa = Convert.ToString(dr["TenKhoa"]);
            }
            else
            {
                this.TenKhoa = "";
            }
            if (dr["TENCHUYENMON"].GetType().Name != "DBNull" && dr["TENCHUYENMON"] != null)
            {
                this.TENCHUYENMON = Convert.ToString(dr["TENCHUYENMON"]);
            }
            else
            {
                this.TENCHUYENMON = "";
            }
            if (dr["TENCD"].GetType().Name != "DBNull" && dr["TENCD"] != null)
            {
                this.TENCD = Convert.ToString(dr["TENCD"]);
            }
            else
            {
                this.TENCD = "";
            }
            if (dr["TenLoaiHD"].GetType().Name != "DBNull" && dr["TenLoaiHD"] != null)
            {
                this.TenLoaiHD = Convert.ToString(dr["TenLoaiHD"]);
            }
            else
            {
                this.TenLoaiHD = "";
            }


        }

    }

    public static List<DMDanToc> GetDMDanToc()
    {
        List<DMDanToc> List = new List<DMDanToc>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDanToc_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMDanToc(dr, i));
            }
        }
        return List;
    }

    public class DMDanToc
    {
        private String _MaDanToc = String.Empty;
        private String _TenDanToc = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _MaQL = String.Empty;
        private String _MaBYTe = String.Empty;
        private int _OrderNumber;
        public String MaDanToc
        {
            get
            {
                return _MaDanToc;
            }
            set
            {
                if (_MaDanToc != value)
                {
                    _MaDanToc = value;
                }
            }
        }

        public String TenDanToc
        {
            get
            {
                return _TenDanToc;
            }
            set
            {
                if (_TenDanToc != value)
                {
                    _TenDanToc = value;
                }
            }
        }

        public String MaMay
        {
            get
            {
                return _maMay;
            }
            set
            {
                if (_maMay != value)
                {
                    _maMay = value;
                }
            }
        }

        public Boolean Huy
        {
            get
            {
                return _huy;
            }
            set
            {
                if (_huy != value)
                {
                    _huy = value;
                }
            }
        }

        public string NgaySD
        {
            get
            {
                return _ngaySD.ToString("dd/MM/yyyy HH:mm");
            }
            set
            {
                DateTime d;

                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture,
                           DateTimeStyles.None, out d))
                {
                    _ngaySD = d;
                }
            }
        }

        public String NguoiSD
        {
            get
            {
                return _nguoiSD;
            }
            set
            {
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                }
            }
        }
        public String MaQL
        {
            get
            {
                return _MaQL;
            }
            set
            {
                if (_MaQL != value)
                {
                    _MaQL = value;
                }
            }
        }
        public String MaBYTe
        {
            get
            {
                return _MaBYTe;
            }
            set
            {
                if (_MaBYTe != value)
                {
                    _MaBYTe = value;
                }
            }
        }
        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }
        public DMDanToc(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaDanToc"].GetType().Name != "DBNull" && dr["MaDanToc"] != null)
            {
                this.MaDanToc = Convert.ToString(dr["MaDanToc"]);
            }
            else
            {
                this.MaDanToc = "";
            }
            if (dr["TenDanToc"].GetType().Name != "DBNull" && dr["TenDanToc"] != null)
            {
                this.TenDanToc = Convert.ToString(dr["TenDanToc"]);
            }
            else
            {
                this.TenDanToc = "";
            }
            if (dr["MaQL"].GetType().Name != "DBNull" && dr["MaQL"] != null)
            {
                this.MaQL = Convert.ToString(dr["MaQL"]);
            }
            else
            {
                this.MaQL = "";
            }
            if (dr["MaBYTe"].GetType().Name != "DBNull" && dr["MaBYTe"] != null)
            {
                this.MaBYTe = Convert.ToString(dr["MaBYTe"]);
            }
            else
            {
                this.MaBYTe = "";
            }

            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToString(dr["NgaySD"]);
            }
            else
            {
                this.NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
        }

    }

}