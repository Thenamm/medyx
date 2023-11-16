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

public partial class UI_QLHSBA_frmGiayBaoTu : WebBase
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
    private const string ViewState_SoGiayBaoTu = "SoGiayBaoTu";
    public string _SoGiayBaoTu
    {
        get
        {
            if (ViewState[ViewState_SoGiayBaoTu] == null)
                ViewState[ViewState_SoGiayBaoTu] = "0";
            return (string)ViewState[ViewState_SoGiayBaoTu];
        }
        set
        {
            ViewState[ViewState_SoGiayBaoTu] = value;
        }
    }
    private void LoadData()
    {
        DataTable dt = spGiayTuVong_Get(_MaBN, _MaBA, decimal.Parse(_SoGiayBaoTu));
        if (dt != null && dt.Rows.Count > 0)
        {
            txtSoGiayBT.Text = dt.Rows[0]["SoGiayBaoTu"].ToString();
            chkHuy.Checked = dt.Rows[0]["Huy"].ToString() == "False" ? false : true;
            dtNgayTV.Text = dt.Rows[0]["NgayTV"].ToString();
            dtNgayCap.Text = dt.Rows[0]["NgayCap"].ToString();
            txtNguyenNhanA.Text = dt.Rows[0]["NguyenNhanA"].ToString();
            txtThoiGianA.Text = dt.Rows[0]["ThoiGianA"].ToString();
            txtNguyenNhanB.Text = dt.Rows[0]["NguyenNhanB"].ToString();
            txtThoiGianB.Text = dt.Rows[0]["ThoiGianB"].ToString();
            txtNguyenNhanC.Text = dt.Rows[0]["NguyenNhanC"].ToString();
            txtThoiGianC.Text = dt.Rows[0]["ThoiGianC"].ToString();
            txtNguyenNhanD.Text = dt.Rows[0]["NguyenNhanD"].ToString();
            txtThoiGianD.Text = dt.Rows[0]["ThoiGianD"].ToString();
            txtNguyenNhan2.Text = dt.Rows[0]["NguyenNhan2"].ToString();
            txtThoiGian2.Text = dt.Rows[0]["ThoiGian2"].ToString();
            SetRadioButtonListValues(rblPhauThuat, Convert.ToByte(dt.Rows[0]["PhauThuat"].ToString()));
            dtNgayPhauThuat.Text = dt.Rows[0]["NgayPhauThuat"].ToString();
            txtLyDoPT.Text = dt.Rows[0]["LyDoPT"].ToString();
            SetRadioButtonListValues(rblKNTT, Convert.ToByte(dt.Rows[0]["KNTT"].ToString()));
            SetRadioButtonListValues(rblSDKQ, Convert.ToByte(dt.Rows[0]["SDKQ"].ToString()));
            SetRadioButtonListValues(rblHinhThucTV, Convert.ToByte(dt.Rows[0]["HinhThucTV"].ToString()));
            dtNgayChanThuong.Text = dt.Rows[0]["NgayChanThuong"].ToString();
            txtNguyenNhanChanThuong.Text = dt.Rows[0]["NguyenNhanChanThuong"].ToString();
            SetRadioButtonListValues(rblNoiTuVong, Convert.ToByte(dt.Rows[0]["NoiTuVong"].ToString()));
            txtNoiTV.Text = dt.Rows[0]["NoiTV"].ToString();
            SetRadioButtonListValues(rblDaThai, Convert.ToByte(dt.Rows[0]["DaThai"].ToString()));
            SetRadioButtonListValues(rblSinhNon, Convert.ToByte(dt.Rows[0]["SinhNon"].ToString()));
            txtGioSongSauSinh.Text = dt.Rows[0]["GioSongSauSinh"].ToString();
            txtCanNang.Text = dt.Rows[0]["CanNang"].ToString();
            txtSoTuanMangThai.Text = dt.Rows[0]["SoTuanMangThai"].ToString();
            txtTuoiMe.Text = dt.Rows[0]["TuoiMe"].ToString();
            txtChuSinh.Text = dt.Rows[0]["ChuSinh"].ToString();
            SetRadioButtonListValues(rblMangThai, Convert.ToByte(dt.Rows[0]["MangThai"].ToString()));
            SetRadioButtonListValues(rblThoiDiemMangThai, Convert.ToByte(dt.Rows[0]["ThoiDiemMangThai"].ToString()));
            SetRadioButtonListValues(rblMangThaiGayTV, Convert.ToByte(dt.Rows[0]["MangThaiGayTV"].ToString()));
            SetRadioButtonListValues(rblTVCC, Convert.ToByte(dt.Rows[0]["TVCC"].ToString() == "False" ? 1 : 0));
            cbocdravien.SelectedValue = dt.Rows[0]["MaNNTV"].ToString();
            cbocdravien.Text = dt.Rows[0]["TenNNTV"].ToString();
            txtNguoiThan.Text = dt.Rows[0]["NguoiThan"].ToString();
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
                _SoGiayBaoTu = Request["SoGiayBaoTu"];
            SetData();
        }
    }
    private void SetData()
    {
        _ThongtinBN = ThongtinBN.GetThongtinBN(_MaBN, DateTime.Now, 1, "", 1, 1);
        if (_ThongtinBN != null)
        {
            dtNgaySinh.Text = _ThongtinBN.NgaySinh;
            txtHoTen.Text = _ThongtinBN.Hoten;
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
            txtNgheNghiep.Text = _ThongtinBN.TenNN;
            txtDiaChi.Text = _ThongtinBN.DiaChiC;
            txtDienThoai.Text = _ThongtinBN.DienThoai;
            txtSoThe.Text = _ThongtinBN.Sothe;
            txtSoCMND.Text = _ThongtinBN.SoCMT;
            //dtNGAYCAP_CMND.Text = _ThongtinBN.NGAYCAP_CMND;
            //txtNoiCapCMND.Text = _ThongtinBN.NOICAP_CMND;
            LoadData();
        }
    }
    public bool CheckXoa(string MaPhieuGN, bool NhanOng)
    {
        if (NhanOng == true)
            return true;
        else
        {
            DataTable dr = new DataTable();
            string tenStore = "spGiayBaoTu_CheckXoa";
            string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            using (SqlConnection Conection = new SqlConnection(StrConection))
            {
                Conection.Open();
                using (SqlCommand Command = new SqlCommand(tenStore, Conection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add(new SqlParameter("@MaPhieuGN", MaPhieuGN));
                    SqlDataAdapter dp = new SqlDataAdapter(Command);
                    dp.Fill(dr);
                }
                if (dr.Rows.Count == 0)
                    return true;
                else
                    return false;
            }
        }
    }
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
                case "cmdPrintCD":
                    if (UpdateData())
                        PrintDataCD();
                    break;
                case "cmdPrint":
                    if (UpdateData())
                        PrintData();
                    break;
                case "cmdPrintLai":
                    PrintLaiData();
                    break;
                case "cmdExit":
                    Response.Redirect("~/Default.aspx");
                    break;
                default:
                    break;
            }
        }

    }
    public void PrintDataCD()
    {
        if (_ThongtinBN != null)
        {
            DataTable dt = spGiayTuVong_Get(_MaBN, _MaBA, decimal.Parse(_SoGiayBaoTu));
            string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRPhieuChanDoanNNTV.rpt";
            ReportDocument rpt = new ReportDocument();
            rpt.Load(Server.MapPath(sPath));
            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
            Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
            Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
            Myformulas["NguoiLap"].Text = "'" + Pub_sTenNguoiSD + "'";
            Myformulas["ThuTruong"].Text = "''";
            Myformulas["NgayBC"].Text = "'Hà Nội, ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year + "'";
            rpt.SetDataSource(dt);
            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
        }
        else
            ShowMessage("Không có dữ liệu hiển thị!");
    }
    public void PrintData()
    {
        if (_ThongtinBN != null)
        {
            string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayBaoTuHH.rpt";
            DataTable dt = spGiayTuVong_SoGiay_GetMin(_MaBN, _MaBA);
            string so1 = "";
            DateTime NgayTV = DateTime.Parse(dtNgayTV.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() != _SoGiayBaoTu)
                    so1 = dt.Rows[0][0].ToString() + " Quyển số: " + NgayTV.ToString("yyyy");
            }
            ReportDocument rpt = new ReportDocument();
            rpt.Load(Server.MapPath(sPath));
            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
            Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenDVChuQuan.ToUpper() + "'";
            Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV.ToUpper() + "'";
            Myformulas["Hoten"].Text = "'" + _ThongtinBN.Hoten.ToUpper() + "'";
            Myformulas["DanToc"].Text = "'" + DMDantoc.GetDMDantoc(_ThongtinBN.madantoc).TenDanToc + "'";
            Myformulas["DiaChi"].Text = "'" + _ThongtinBN.DiaChi + ", " + _ThongtinBN.TenPXa + ", " + _ThongtinBN.TenQH + ", " + _ThongtinBN.TenTinh + "'";
            Myformulas["QuocTich"].Text = "'" + _ThongtinBN.TenQG + "'";
            Myformulas["So"].Text = "'" + _SoGiayBaoTu + "'";
            Myformulas["GT"].Text = "'" + _ThongtinBN.gtD + "'";
            Myformulas["TVCC"].Text = "'" + (GetRadioButtonListValues(rblTVCC) == 0 ? "Co" : "") + "'";
            Myformulas["NguoiLap"].Text = "'" + Pub_sTenNguoiSD + "'";
            Myformulas["ThuTruong"].Text = "''";
            Myformulas["NgayTV"].Text = "'" + NgayTV.ToString("HH") + " giờ " + NgayTV.ToString("mm") + " phút, ngày " + NgayTV.ToString("dd") + " tháng " + NgayTV.ToString("MM") + " năm " + NgayTV.ToString("yyyy") + "'";
            Myformulas["DiaChiBV"].Text = "'" + HTC.ShareVariables.pub_sDiaChiBV + "'";
            Myformulas["QuyenSo"].Text = "'" + NgayTV.ToString("yyyy") + "'";
            Myformulas["ngaylap"].Text = "''";
            Myformulas["NguyenNhanTV"].Text = "'" + txtNguyenNhanA.Text + "'";
            Myformulas["NamSinh"].Text = "'" + _ThongtinBN.NgaySinh + "'";
            Myformulas["TenBC1"].Text = "'GIẤY BÁO TỬ'";
            Myformulas["NgayBC"].Text = "'Hà Nội, ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year + "'";
            //Myformulas["NgayCapCMT"].Text = "'" + _ThongtinBN.NGAYCAP_CMND + "'";
            Myformulas["SoCMT"].Text = "'" + _ThongtinBN.SoCMT + "'";
            //Myformulas["NoiCapCMT"].Text = "'" + _ThongtinBN.NOICAP_CMND + "'";
            Myformulas["so1"].Text = "'" + so1 + "'";
            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
        }
        else
            ShowMessage("Không có dữ liệu hiển thị!");
    }
    public void PrintLaiData()
    {
        if (_ThongtinBN != null)
        {
            string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRDeNghiCapLaiGBT.rpt";
            DataTable dt = spDeNghiCapLaiGBT_Get(_MaBN, _MaBA);
            if (dt.Rows.Count > 0)
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Server.MapPath(sPath));
                FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
                Myformulas["NgayBC"].Text = "'Làm tại Hà Nội ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year + "'";
                rpt.SetDataSource(dt);
                PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
            }

            else
                ShowMessage("Không có dữ liệu hiển thị!");
        }
        else
            ShowMessage("Không có dữ liệu hiển thị!");
    }
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
                DateTime NgayTV = DateTime.Parse(dtNgayTV.Text);

                string NguyenNhanA = txtNguyenNhanA.Text;
                string ThoiGianA = txtThoiGianA.Text;
                string NguyenNhanB = txtNguyenNhanB.Text;
                string ThoiGianB = txtThoiGianB.Text;
                string NguyenNhanC = txtNguyenNhanC.Text;
                string ThoiGianC = txtThoiGianC.Text;
                string NguyenNhanD = txtNguyenNhanD.Text;
                string ThoiGianD = txtThoiGianD.Text;
                string NguyenNhan2 = txtNguyenNhan2.Text;
                string ThoiGian2 = txtThoiGian2.Text;
                byte PhauThuat = GetRadioButtonListValues(rblPhauThuat);
                DateTime d;
                DateTime NgayPhauThuat = new DateTime();
                if (DateTime.TryParse(dtNgayPhauThuat.Text, out d))
                    NgayPhauThuat = d;
                string LyDoPT = txtLyDoPT.Text;
                byte KNTT = GetRadioButtonListValues(rblKNTT);
                byte SDKQ = GetRadioButtonListValues(rblSDKQ);
                byte HinhThucTV = GetRadioButtonListValues(rblHinhThucTV);
                DateTime NgayChanThuong = new DateTime();
                if (DateTime.TryParse(dtNgayChanThuong.Text, out d))
                    NgayChanThuong = d;
                string NguyenNhanChanThuong = txtNguyenNhanChanThuong.Text;
                byte NoiTuVong = GetRadioButtonListValues(rblNoiTuVong);
                string NoiTV = txtNoiTV.Text;
                byte DaThai = GetRadioButtonListValues(rblDaThai);
                byte SinhNon = GetRadioButtonListValues(rblSinhNon);
                string GioSongSauSinh = txtGioSongSauSinh.Text;
                string CanNang = txtCanNang.Text;
                string SoTuanMangThai = txtSoTuanMangThai.Text;
                string TuoiMe = txtTuoiMe.Text;
                string ChuSinh = txtChuSinh.Text;
                byte MangThai = GetRadioButtonListValues(rblMangThai);
                byte ThoiDiemMangThai = GetRadioButtonListValues(rblThoiDiemMangThai);
                byte MangThaiGayTV = GetRadioButtonListValues(rblMangThaiGayTV);
                bool TVCC = GetRadioButtonListValues(rblTVCC) == 0 ? true : false;
                string MaNNTV = cbocdravien.SelectedValue;
                string TenNNTV = cbocdravien.Text;
                string NguoiThan = txtNguoiThan.Text;
                //if ( dtNGAYCAP_CMND.Text != _ThongtinBN.NGAYCAP_CMND || txtNoiCapCMND.Text != _ThongtinBN.NOICAP_CMND || txtSoCMND.Text != _ThongtinBN.SoCMT)
                {
                    if (DateTime.TryParse(dtNGAYCAP_CMND.Text, out d))
                    //    _ThongtinBN.NGAYCAP_CMND = dtNGAYCAP_CMND.Text;
                    //_ThongtinBN.NOICAP_CMND = txtNoiCapCMND.Text;
                    _ThongtinBN.SoCMT = txtSoCMND.Text;
                    _ThongtinBN.ApplyEdit();
                    _ThongtinBN.Save();
                    BenhNhan _benhnhan = BenhNhan.GetBenhNhan(_ThongtinBN.MaBN);
                    //_benhnhan.NGAYCAP_CMND = dtNGAYCAP_CMND.Text;
                    //_benhnhan.NOICAP_CMND = txtNoiCapCMND.Text;
                    _benhnhan.ApplyEdit();
                    _benhnhan.Save();
                }
                if (_SoGiayBaoTu == "0")
                {
                    //them moi giay bao tu
                    _SoGiayBaoTu = spGiayTuVong_Create(_MaBA, _MaBN, NgayTV == null ? "" : NgayTV.ToString("yyyy-MM-dd HH:mm:ss"), NguyenNhanA, ThoiGianA, NguyenNhanB, ThoiGianB, NguyenNhanC, ThoiGianC, NguyenNhanD, ThoiGianD, NguyenNhan2, ThoiGian2, PhauThuat, NgayPhauThuat == new DateTime() ? "" : NgayPhauThuat.ToString("yyyy-MM-dd HH:mm:ss"), LyDoPT, KNTT, SDKQ, HinhThucTV, NgayChanThuong == new DateTime() ? "" : NgayChanThuong.ToString("yyyy-MM-dd HH:mm:ss"), NguyenNhanChanThuong, NoiTuVong, NoiTV, DaThai, SinhNon, GioSongSauSinh, CanNang, SoTuanMangThai, TuoiMe, ChuSinh, MangThai, ThoiDiemMangThai, MangThaiGayTV, TVCC, MaNNTV, TenNNTV, NguoiThan);
                }
                else
                {
                    //cap nhat thong tin giay bao tu
                    spGiayTuVong_Update(decimal.Parse(_SoGiayBaoTu), _MaBA, _MaBN, NgayTV == null ? "" : NgayTV.ToString("yyyy-MM-dd HH:mm:ss"), NguyenNhanA, ThoiGianA, NguyenNhanB, ThoiGianB, NguyenNhanC, ThoiGianC, NguyenNhanD, ThoiGianD, NguyenNhan2, ThoiGian2, PhauThuat, NgayPhauThuat == new DateTime() ? "" : NgayPhauThuat.ToString("yyyy-MM-dd HH:mm:ss"), LyDoPT, KNTT, SDKQ, HinhThucTV, NgayChanThuong == new DateTime() ? "" : NgayChanThuong.ToString("yyyy-MM-dd HH:mm:ss"), NguyenNhanChanThuong, NoiTuVong, NoiTV, DaThai, SinhNon, GioSongSauSinh, CanNang, SoTuanMangThai, TuoiMe, ChuSinh, MangThai, ThoiDiemMangThai, MangThaiGayTV, TVCC, MaNNTV, TenNNTV, NguoiThan);
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
                DataTable TV = spGiayTuVong_GetXML(_MaBA, _MaBN, decimal.Parse(_SoGiayBaoTu));
                //    if (token != null)
                if (TV.Rows.Count > 0)
                {
                    HSDLGBT hSDLGBT = new HSDLGBT();
                    List<GIAYBAOTU> gIAYBAOTUs = new List<GIAYBAOTU>();
                    GIAYBAOTU gIAYBAOTU = new GIAYBAOTU();
                    gIAYBAOTU.MA_GBT = TV.Rows[0]["MA_GBT"].ToString();
                    gIAYBAOTU.MA_BN = TV.Rows[0]["MA_BN"].ToString();
                    gIAYBAOTU.MA_HSBA = TV.Rows[0]["MA_HSBA"].ToString();
                    gIAYBAOTU.HO_TEN = TV.Rows[0]["HO_TEN"].ToString();
                    gIAYBAOTU.NGAY_SINH = TV.Rows[0]["NGAY_SINH"].ToString();
                    gIAYBAOTU.GIOI_TINH = int.Parse(TV.Rows[0]["GIOI_TINH"].ToString());
                    gIAYBAOTU.MA_THE = TV.Rows[0]["MA_THE"].ToString();
                    gIAYBAOTU.MA_DANTOC = TV.Rows[0]["MA_DANTOC"].ToString();
                    gIAYBAOTU.MA_QUOCTICH = TV.Rows[0]["MA_QUOCTICH"].ToString();
                    gIAYBAOTU.DCHI_THUONGTRU = TV.Rows[0]["DCHI_THUONGTRU"].ToString();
                    gIAYBAOTU.MATINH_THUONGTRU = TV.Rows[0]["MATINH_THUONGTRU"].ToString();
                    gIAYBAOTU.MAHUYEN_THUONGTRU = TV.Rows[0]["MAHUYEN_THUONGTRU"].ToString();
                    gIAYBAOTU.MAXA_THUONGTRU = TV.Rows[0]["MAXA_THUONGTRU"].ToString();
                    gIAYBAOTU.MATINH_HIENTAI = TV.Rows[0]["MATINH_HIENTAI"].ToString();
                    gIAYBAOTU.MAHUYEN_HIENTAI = TV.Rows[0]["MAHUYEN_HIENTAI"].ToString();
                    gIAYBAOTU.MAXA_HIENTAI = TV.Rows[0]["MAXA_HIENTAI"].ToString();
                    gIAYBAOTU.LOAI_GIAYTO = int.Parse(TV.Rows[0]["LOAI_GIAYTO"].ToString());
                    gIAYBAOTU.SO_GIAYTO = TV.Rows[0]["SO_GIAYTO"].ToString();
                    gIAYBAOTU.NGAY_CAP = TV.Rows[0]["NGAY_CAP"].ToString();
                    gIAYBAOTU.NOI_CAP = TV.Rows[0]["NOI_CAP"].ToString();
                    gIAYBAOTU.NGAYGIO_VV = TV.Rows[0]["NGAYGIO_VV"].ToString();
                    gIAYBAOTU.NGAY_TV = TV.Rows[0]["NGAY_TV"].ToString();
                    gIAYBAOTU.TINHTRANG_TV = int.Parse(TV.Rows[0]["TINHTRANG_TV"].ToString());
                    gIAYBAOTU.NGUYENNHAN_TV = TV.Rows[0]["NGUYENNHAN_TV"].ToString();
                    gIAYBAOTU.NGUOI_GHIGIAY = TV.Rows[0]["NGUOI_GHIGIAY"].ToString();
                    gIAYBAOTU.NGUOI_THANTHICH = TV.Rows[0]["NGUOI_THANTHICH"].ToString();
                    gIAYBAOTU.TTRUONG_DVI = TV.Rows[0]["TTRUONG_DVI"].ToString();
                    gIAYBAOTU.SO_BAOTU = TV.Rows[0]["SO_BAOTU"].ToString();
                    gIAYBAOTU.QUYEN_SO = TV.Rows[0]["QUYEN_SO"].ToString();
                    gIAYBAOTU.NGAY_CAPGIAYBT = TV.Rows[0]["NGAY_CAPGIAYBT"].ToString();
                    gIAYBAOTU.SO_BAOTU_BD = TV.Rows[0]["SO_BAOTU_BD"].ToString();
                    gIAYBAOTU.QUYEN_SO_BD = TV.Rows[0]["QUYEN_SO_BD"].ToString();
                    gIAYBAOTU.MACSKCB = TV.Rows[0]["MACSKCB"].ToString();
                    gIAYBAOTU.DIACHI_CSKCB = TV.Rows[0]["DIACHI_CSKCB"].ToString();
                    DMDantocList dMDantocs = DMDantocList.GetAllDMDantoc();
                    gIAYBAOTUs.Add(gIAYBAOTU);
                    hSDLGBT.GIAYBAOTU = gIAYBAOTUs;
                    //tao file xml
                    string filename = "";
                    DateTime tungay;
                    DateTime denngay;
                    tungay = DateTime.Now.AddMinutes(-10).AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                    denngay = DateTime.Now.AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                    string _tungay = tungay.ToString("dd/MM/yyyy HH:mm");
                    string _denngay = denngay.ToString("dd/MM/yyyy HH:mm");
                    //filename = System.Web.Hosting.HostingEnvironment.MapPath(@"~\GBT\BHXH" + txtMaQL.Text.Trim() + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + ".XML");
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
                    XmlSerializer xs = new XmlSerializer(typeof(HSDLGBT));
                    TextWriter txtWriter = new StreamWriter(filename, false, Encoding.UTF8);
                    xs.Serialize(txtWriter, hSDLGBT);
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
    public string spGiayTuVong_Create(string MaBA, string MaBN, string NgayTV, string NguyenNhanA, string ThoiGianA, string NguyenNhanB, string ThoiGianB, string NguyenNhanC, string ThoiGianC, string NguyenNhanD, string ThoiGianD, string NguyenNhan2, string ThoiGian2, byte PhauThuat, string NgayPhauThuat, string LyDoPT, byte KNTT, byte SDKQ, byte HinhThucTV, string NgayChanThuong, string NguyenNhanChanThuong, byte NoiTuVong, string NoiTV, byte DaThai, byte SinhNon, string GioSongSauSinh, string CanNang, string SoTuanMangThai, string TuoiMe, string ChuSinh, byte MangThai, byte ThoiDiemMangThai, byte MangThaiGayTV, bool TVCC, string MaNNTV, string TenNNTV, string NguoiThan)
    {
        string tenStore = "spGiayTuVong_Create";
        DataTable dr = new DataTable();
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@NgayTV", NgayTV));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanA", NguyenNhanA));
                Command.Parameters.Add(new SqlParameter("@ThoiGianA", ThoiGianA));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanB", NguyenNhanB));
                Command.Parameters.Add(new SqlParameter("@ThoiGianB", ThoiGianB));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanC", NguyenNhanC));
                Command.Parameters.Add(new SqlParameter("@ThoiGianC", ThoiGianC));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanD", NguyenNhanD));
                Command.Parameters.Add(new SqlParameter("@ThoiGianD", ThoiGianD));
                Command.Parameters.Add(new SqlParameter("@NguyenNhan2", NguyenNhan2));
                Command.Parameters.Add(new SqlParameter("@ThoiGian2", ThoiGian2));
                Command.Parameters.Add(new SqlParameter("@PhauThuat", PhauThuat));
                Command.Parameters.Add(new SqlParameter("@NgayPhauThuat", NgayPhauThuat));
                Command.Parameters.Add(new SqlParameter("@LyDoPT", LyDoPT));
                Command.Parameters.Add(new SqlParameter("@KNTT", KNTT));
                Command.Parameters.Add(new SqlParameter("@SDKQ", SDKQ));
                Command.Parameters.Add(new SqlParameter("@HinhThucTV", HinhThucTV));
                Command.Parameters.Add(new SqlParameter("@NgayChanThuong", NgayChanThuong));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanChanThuong", NguyenNhanChanThuong));
                Command.Parameters.Add(new SqlParameter("@NoiTuVong", NoiTuVong));
                Command.Parameters.Add(new SqlParameter("@NoiTV", NoiTV));
                Command.Parameters.Add(new SqlParameter("@DaThai", DaThai));
                Command.Parameters.Add(new SqlParameter("@SinhNon", SinhNon));
                Command.Parameters.Add(new SqlParameter("@GioSongSauSinh", GioSongSauSinh));
                Command.Parameters.Add(new SqlParameter("@CanNang", CanNang));
                Command.Parameters.Add(new SqlParameter("@SoTuanMangThai", SoTuanMangThai));
                Command.Parameters.Add(new SqlParameter("@TuoiMe", TuoiMe));
                Command.Parameters.Add(new SqlParameter("@ChuSinh", ChuSinh));
                Command.Parameters.Add(new SqlParameter("@MangThai", MangThai));
                Command.Parameters.Add(new SqlParameter("@ThoiDiemMangThai", ThoiDiemMangThai));
                Command.Parameters.Add(new SqlParameter("@MangThaiGayTV", MangThaiGayTV));
                Command.Parameters.Add(new SqlParameter("@TVCC", TVCC));
                Command.Parameters.Add(new SqlParameter("@MaNNTV", MaNNTV));
                Command.Parameters.Add(new SqlParameter("@TenNNTV", TenNNTV));
                Command.Parameters.Add(new SqlParameter("@NguoiLap", Pub_sNguoiSD));
                Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@NguoiThan", NguoiThan));
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
    public void spGiayTuVong_Update(decimal SoGiayBaoTu, string MaBA, string MaBN, string NgayTV, string NguyenNhanA, string ThoiGianA, string NguyenNhanB, string ThoiGianB, string NguyenNhanC, string ThoiGianC, string NguyenNhanD, string ThoiGianD, string NguyenNhan2, string ThoiGian2, byte PhauThuat, string NgayPhauThuat, string LyDoPT, byte KNTT, byte SDKQ, byte HinhThucTV, string NgayChanThuong, string NguyenNhanChanThuong, byte NoiTuVong, string NoiTV, byte DaThai, byte SinhNon, string GioSongSauSinh, string CanNang, string SoTuanMangThai, string TuoiMe, string ChuSinh, byte MangThai, byte ThoiDiemMangThai, byte MangThaiGayTV, bool TVCC, string MaNNTV, string TenNNTV, string NguoiThan)
    {
        string tenStore = "spGiayTuVong_Update";
        DataTable dr = new DataTable();
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@SoGiayBaoTu", SoGiayBaoTu));
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@NgayTV", NgayTV));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanA", NguyenNhanA));
                Command.Parameters.Add(new SqlParameter("@ThoiGianA", ThoiGianA));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanB", NguyenNhanB));
                Command.Parameters.Add(new SqlParameter("@ThoiGianB", ThoiGianB));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanC", NguyenNhanC));
                Command.Parameters.Add(new SqlParameter("@ThoiGianC", ThoiGianC));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanD", NguyenNhanD));
                Command.Parameters.Add(new SqlParameter("@ThoiGianD", ThoiGianD));
                Command.Parameters.Add(new SqlParameter("@NguyenNhan2", NguyenNhan2));
                Command.Parameters.Add(new SqlParameter("@ThoiGian2", ThoiGian2));
                Command.Parameters.Add(new SqlParameter("@PhauThuat", PhauThuat));
                Command.Parameters.Add(new SqlParameter("@NgayPhauThuat", NgayPhauThuat));
                Command.Parameters.Add(new SqlParameter("@LyDoPT", LyDoPT));
                Command.Parameters.Add(new SqlParameter("@KNTT", KNTT));
                Command.Parameters.Add(new SqlParameter("@SDKQ", SDKQ));
                Command.Parameters.Add(new SqlParameter("@HinhThucTV", HinhThucTV));
                Command.Parameters.Add(new SqlParameter("@NgayChanThuong", NgayChanThuong));
                Command.Parameters.Add(new SqlParameter("@NguyenNhanChanThuong", NguyenNhanChanThuong));
                Command.Parameters.Add(new SqlParameter("@NoiTuVong", NoiTuVong));
                Command.Parameters.Add(new SqlParameter("@NoiTV", NoiTV));
                Command.Parameters.Add(new SqlParameter("@DaThai", DaThai));
                Command.Parameters.Add(new SqlParameter("@SinhNon", SinhNon));
                Command.Parameters.Add(new SqlParameter("@GioSongSauSinh", GioSongSauSinh));
                Command.Parameters.Add(new SqlParameter("@CanNang", CanNang));
                Command.Parameters.Add(new SqlParameter("@SoTuanMangThai", SoTuanMangThai));
                Command.Parameters.Add(new SqlParameter("@TuoiMe", TuoiMe));
                Command.Parameters.Add(new SqlParameter("@ChuSinh", ChuSinh));
                Command.Parameters.Add(new SqlParameter("@MangThai", MangThai));
                Command.Parameters.Add(new SqlParameter("@ThoiDiemMangThai", ThoiDiemMangThai));
                Command.Parameters.Add(new SqlParameter("@MangThaiGayTV", MangThaiGayTV));
                Command.Parameters.Add(new SqlParameter("@TVCC", TVCC));
                Command.Parameters.Add(new SqlParameter("@MaNNTV", MaNNTV));
                Command.Parameters.Add(new SqlParameter("@TenNNTV", TenNNTV));
                Command.Parameters.Add(new SqlParameter("@NguoiSD", Pub_sNguoiSD));
                Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@NguoiThan", NguoiThan));
                Command.ExecuteNonQuery();
            }
            Conection.Dispose();
            Conection.Close();
        }
    }
    public DataTable spGiayTuVong_Get(string MaBN, string MaBA, decimal SoGiayBaoTu)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayTuVong_Get";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@SoGiayBaoTu", SoGiayBaoTu));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    public DataTable spDeNghiCapLaiGBT_Get(string MaBN, string MaBA)
    {
        DataTable dr = new DataTable();
        string tenStore = "spDeNghiCapLaiGBT_Get";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    public DataTable spGiayTuVong_SoGiay_GetMin(string MaBN, string MaBA)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayTuVong_SoGiay_GetMin";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    public DataTable spGiayTuVong_GetXML(string MaBN, string MaBA, decimal SoGiayBaoTu)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayTuVong_GetXML";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@SoGiayBaoTu", SoGiayBaoTu));
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
        if (dtNgayPhauThuat.Text != "" && !DateTime.TryParse(dtNgayPhauThuat.Text, out d))
        {
            ShowMessage("Ngày phẫu thuật sai định dạng!");
            dtNgayPhauThuat.Text = "";
            dtNgayPhauThuat.Focus();
            return false;
        }
        else if (dtNgayChanThuong.Text != "" && !DateTime.TryParse(dtNgayChanThuong.Text, out d))
        {
            ShowMessage("Ngày chấn thương sai định dạng!");
            dtNgayChanThuong.Text = "";
            dtNgayChanThuong.Focus();
            return false;
        }
        else return true;

    }
    #region API Giay Bao Tu
    #region object
    public class HSDLGBT
    {
        public List<GIAYBAOTU> GIAYBAOTU { get; set; }
    }
    public class GIAYBAOTU
    {
        public string MA_GBT { get; set; }
        public string MA_BN { get; set; }
        public string MA_HSBA { get; set; }
        public string HO_TEN { get; set; }
        public string NGAY_SINH { get; set; }
        public int GIOI_TINH { get; set; }
        public string MA_THE { get; set; }
        public string MA_DANTOC { get; set; }
        public string MA_QUOCTICH { get; set; }
        public string DCHI_THUONGTRU { get; set; }
        public string MATINH_THUONGTRU { get; set; }
        public string MAHUYEN_THUONGTRU { get; set; }
        public string MAXA_THUONGTRU { get; set; }
        public string DCHI_HIENTAI { get; set; }
        public string MATINH_HIENTAI { get; set; }
        public string MAHUYEN_HIENTAI { get; set; }
        public string MAXA_HIENTAI { get; set; }
        public int LOAI_GIAYTO { get; set; }
        public string SO_GIAYTO { get; set; }
        public string NGAY_CAP { get; set; }
        public string NOI_CAP { get; set; }
        public string NGAYGIO_VV { get; set; }
        public string NGAY_TV { get; set; }
        public int TINHTRANG_TV { get; set; }
        public string NGUYENNHAN_TV { get; set; }
        public string NGUOI_GHIGIAY { get; set; }
        public string NGUOI_THANTHICH { get; set; }
        public string TTRUONG_DVI { get; set; }
        public string SO_BAOTU { get; set; }
        public string QUYEN_SO { get; set; }
        public string NGAY_CAPGIAYBT { get; set; }
        public string SO_BAOTU_BD { get; set; }
        public string QUYEN_SO_BD { get; set; }
        public string MACSKCB { get; set; }
        public string DIACHI_CSKCB { get; set; }
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
    public class gbtsend
    {
        public string maCskcb { get; set; }
        public string token { get; set; }
        public string id_token { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int loaiHs { get; set; }
        public string fileBase64Str { get; set; }
    }
    public class gbtrequest
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
}