using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using HTC.Business.NoiTru;
using HTC.Business.PhongKham;
using HTC.Common.Web;
using Telerik.Web.UI;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
using System.IO;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Globalization;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;


public partial class UI_NoiTru_TiepDon_FrmBenhAnNoiTruPK : WebBase
{



    private const string ViewState_BenhAnPK = "BenhAnPK";
    private const string ViewState_MaBN = "MaBN";

    private const string ViewState_MaBA = "MaBA";
    private const string ViewState_maSoKham = "_maSoKham";
    private const string ViewState_STTKhoa = "STTKhoa";
    private const string ViewState_STT = "STT";
    private const string ViewState_loai = "_loai";
    private const string ViewState_loaicn = "_loaicn";
    private const string ViewState_loaikq = "_loaikq";
    private const string ViewState_ngaydk = "_ngaydk";

    private const string ViewState_NoiTT = "NoiTT";

    public string _NoiTT
    {
        get
        {
            if (ViewState[ViewState_NoiTT] == null)
            {
                if (!string.IsNullOrEmpty(Request["NoiTT"]))
                {
                    ViewState[ViewState_NoiTT] = (Request["NoiTT"].ToString());
                }
                else
                    Response.Redirect("~/Default.aspx");
            }
            return (string)ViewState[ViewState_NoiTT];
        }

        set
        {
            ViewState[ViewState_NoiTT] = value;
        }

    }
    public byte _loai
    {
        get
        {
            if (ViewState[ViewState_loai] == null)
            {
                if (!string.IsNullOrEmpty(Request["loai"]))
                {
                    ViewState[ViewState_loai] = Convert.ToByte(Request["loai"].ToString());
                }
                else
                    Response.Redirect("~/Default.aspx");
            }

            return (byte)ViewState[ViewState_loai];
        }

        set
        {
            ViewState[ViewState_loai] = value;
        }
    }
    private const string ViewState_lanbao = "_lanbao";
    public byte lanbao
    {
        get
        {
            if (ViewState[ViewState_lanbao] == null)
                ViewState[ViewState_lanbao] = 0;
            return (byte)ViewState[ViewState_lanbao];
        }

        set
        {
            ViewState[ViewState_lanbao] = value;
        }
    }
    private const string ViewState_lanbaobn = "_lanbaobn";
    public byte lanbaobn
    {
        get
        {
            if (ViewState[ViewState_lanbaobn] == null)
                ViewState[ViewState_lanbaobn] = 0;
            return (byte)ViewState[ViewState_lanbaobn];
        }

        set
        {
            ViewState[ViewState_lanbaobn] = value;
        }
    }
    public byte loaicn
    {
        get
        {
            if (ViewState[ViewState_loaicn] == null)
            {
                if (!string.IsNullOrEmpty(Request["loaicn"]))
                {
                    ViewState[ViewState_loaicn] = Convert.ToByte(Request["loaicn"].ToString());
                }
                else
                    Response.Redirect("~/Default.aspx");
            }

            return (byte)ViewState[ViewState_loaicn];
        }

        set
        {
            ViewState[ViewState_loaicn] = value;
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

    public string _ngaydk
    {
        get
        {
            if (ViewState[ViewState_ngaydk] == null)
            {
                if (!string.IsNullOrEmpty(Request["ngaydk"]))
                {
                    ViewState[ViewState_ngaydk] = Request["ngaydk"].ToString();
                }
                else
                    return string.Empty;
            }

            return (string)ViewState[ViewState_ngaydk];
        }

        set
        {
            ViewState[ViewState_ngaydk] = value;
        }
    }
    public string _MaBN
    {
        get
        {
            if (ViewState[ViewState_MaBN] != null)
                return ViewState[ViewState_MaBN].ToString();
            else
                return string.Empty;
        }
        set
        {
            ViewState[ViewState_MaBN] = value;
        }
    }
    public string _MaBA
    {
        get
        {
            if (ViewState[ViewState_MaBA] != null)
                return ViewState[ViewState_MaBA].ToString();

            else
                return string.Empty;
        }
        set
        {
            ViewState[ViewState_MaBA] = value;
        }
    }


   
    protected bool CheckData()
    {
        if (cboKhoaNV.SelectedValue == "" || cboKhoaNV.SelectedValue == null)
        {
            ShowMessage("Chưa có khoa nhập viện");
            return false;
        }
        if (cboLoaiBA.SelectedValue == "" || cboLoaiBA.SelectedValue == null)
        {
            ShowMessage("Chưa nhập loại bệnh án");
            return false;
        }
        if (txthoten.Text == "")
        {
            ShowMessage("Chưa nhập họ tên");
            return false;
        }
        if (txttuoi.Text == "")
        {
            ShowMessage("Chưa nhập ngày sinh hoặc tuổi");
            return false;
        }
        try
        {
            byte.Parse(txttuoi.Text);
            if (byte.Parse(txttuoi.Text) >= byte.Parse("131"))
            {
                ShowMessage("Tuổi phải nhỏ hơn 131 tuổi");

            }
        }
        catch (Exception ex)
        {
            ShowMessage("Tuổi phải nhỏ hơn 256 tuổi" + ex.Message);
            return false;
            //throw;
        }
        if (cboquocgia.SelectedValue == "00084")
        {
            if (HTC.ShareVariables.pub_spC != "HU")
            {
                if (txtDiaChi.Text == "")
                {
                    ShowMessage("Chưa nhập địa chỉ");

                    txtDiaChi.Focus();
                    return false;
                }
            }
            if (HTC.ShareVariables.pub_spC == "HU" && cbotinh.SelectedValue == "00031")
            {
                if (cboPXa.SelectedValue == "")
                {
                    ShowMessage("Chưa nhập phường xã");
                    cboPXa.Focus();
                    return false;
                }
            }
            if (cbohuyen.SelectedValue == "")
            {
                ShowMessage("Chưa nhập quận , huyện");

                cbohuyen.Focus();
                return false;
            }
            if (cbotinh.SelectedValue == "")
            {
                ShowMessage("Chưa nhập tỉnh, thành phố");

                cbotinh.Focus();
                return false;
            }
        }
        if ((HTC.ShareVariables.pub_spC == "PS") || (HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ "))
        {
            if (cboNgheNghiep.SelectedValue == "")
            {
                ShowMessage("Chưa nhập nghề nghiệp");
                cboNgheNghiep.Focus();
                return false;
            }
           
        }
        if ((HTC.ShareVariables.pub_spC == "PS"))
        {
           
            if (txtdienthoai.Text == "")
            {
                ShowMessage("Chưa nhập điện thoại liên hệ");
                cboNgheNghiep.Focus();
                return false;
            }
        }
        if (txtBaoTin.Text == "")
        {
            ShowMessage("Chưa nhập địa chỉ liên hệ bệnh nhân");
            return false;
        }
        if ((cboKhoaNV.SelectedValue != "007" && HTC.ShareVariables.pub_spC == "PS") || HTC.ShareVariables.pub_spC != "PS")
        {
            if (cboDoiTuong.SelectedValue.Substring(0, 1) == "1" && cboLoaiBA.SelectedValue != "00027")
            {
                if (cboDKBD.SelectedValue == "")
                {
                    ShowMessage("Chưa nhập nơi đăng ký ban đầu");
                    return false;
                }
                if (dtBHYTTN.Text == "")
                {
                    ShowMessage("Từ ngày sai");
                    return false;
                }
                if (ConvertStringToDate(dtBHYTTN.Text) == null)
                {
                    ShowMessage("Từ ngày sai");
                    return false;
                }
                if (dtBHYTDN.Text == "")
                {
                    ShowMessage("Đến ngày sai");
                    return false;
                }
                if (ConvertStringToDate(dtBHYTDN.Text) == null)
                {
                    ShowMessage("Đến ngày sai");
                    return false;
                }
                if (!EqualsToDateTime(dtBHYTTN.Text, dtBHYTDN.Text))
                {
                    ShowMessage("Từ ngày trước đến ngày");
                    return false;
                }
                if (cboDoiTuong.SelectedValue.Substring(0, 1) == "1" && (cboDKBD.SelectedValue == "" || cboDKBD.SelectedValue == null))
                {
                    ShowMessage("Chưa nhập nơi đăng ký ban đầu");
                    cboDKBD.Focus();
                    return false;
                }

                if (DateDiff(DateInterval.Day, DateTime.Parse(dtNgayVV.Text  ), DateTime.Parse(dtBHYTTN.Text)) > 0)
                {
                    ShowMessage("Ngày vào viện không được nhỏ hơn giá trị ngày");
                    return false;
                }
                if (DateDiff(DateInterval.Day, DateTime.Parse(dtBHYTDN.Text), DateTime.Parse(dtNgayVV.Text)) > 0)
                {
                    ShowMessage("Ngày vào viện không được lớn hơn giá trị ngày");
                    return false;
                }
            }
        }
        if (dtNgaySinh.Text == "")
        {
            ShowMessage("Chưa nhập ngày sinh");
            return false;
        }
        if (ConvertStringToDate(dtNgaySinh.Text) == null)
        {
            ShowMessage("Chưa nhập ngày sinh");
            return false;
        }
        if (txttuoi.Text == "")
        {
            ShowMessage("Chưa nhập ngày sinh hoặc tuổi");
            txttuoi.Focus();
            return false;
        }
        try
        {
            byte.Parse(txttuoi.Text);
            if (byte.Parse(txttuoi.Text) >= byte.Parse("255"))
            {
                ShowMessage("Tuổi phải nhỏ hơn 256 tuổi");

            }
        }
        catch (Exception ex)
        {
            ShowMessage("Tuổi phải nhỏ hơn 256 tuổi" + ex.Message);
            return false;
            //throw;
        }
        if (ConvertStringToDateTime(dtNgayVV.Text) == null)
        {
            ShowMessage("Chưa nhập ngày vào viện");
            return false;
        }
        if ((txtBenhKCC.Text == "" || cboCDKKBCC.SelectedValue == "") && HTC.ShareVariables.pub_spC != "PH")
        {
            ShowMessage("Chưa nhập bệnh vào viện");
            return false;
        }
        if (_ThongTinBN.KhamBenh != null)
            if (_ThongTinBN.KhamBenh.NgayDK != "" && HTC.ShareVariables.pub_spC != "YH" && _ThongTinBN.KhamBenh.KhamBenh_C_List.Count > 0)
            {

                DateTime ngayDK = DateTime.ParseExact(_ThongTinBN.KhamBenh.NgayDK, "M/dd/yyyy", null);
                DateTime ngayVV = DateTime.ParseExact(dtNgayVV.Text.Substring(0, 10), "dd/MM/yyyy", null);
                //if (DateDiff(DateInterval.Day, DateTime.ParseExact(_ThongTinBN.KhamBenh.NgayDK.Substring(0, 10), "MM/dd/yyyy", null), 
                //    DateTime.ParseExact(dtNgayVV.Text.Substring(0, 10), "dd/MM/yyyy", null)) < 0)
                if (DateDiff(DateInterval.Day, ngayDK, ngayVV) < 0)
                {
                    ShowMessage("Ngày vào viện phải lớn hơn ngày khám bệnh");
                    return false;
                }



            }
        return true;
    }

    public object thang { get; set; }
    protected Boolean PrintData(Boolean bshow = true)
    {
        try
        {
            if (CheckData() == true)
            {
                String sPath;

                String ngay = DateTime.Now.Day <= 9 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
                String thang = DateTime.Now.Month <= 9 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();

                if (cboDoiTuong.SelectedValue.Substring(0, 1) == "1") //    'bao cao bien nhan
                {
                    ReportDocument rptbn = new ReportDocument();
                    FormulaFieldDefinitions Myformulasbn;
                    sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayBienNhanBHYT.rpt";
                    rptbn.Load(Server.MapPath(sPath));
                    Myformulasbn = rptbn.DataDefinition.FormulaFields;

                    Myformulasbn["ten"].Text = "'" + txthoten.Text.ToUpper() + "'";
                    Myformulasbn["BHYT"].Text = "'" + txtSoThe.Text.ToUpper() + "'";
                    Myformulasbn["hanthe"].Text = "'" + dtBHYTDN.Text + "'";
                    Myformulasbn["dkbh"].Text = "'" + txtTenBVBD.Text + "'";
                    Myformulasbn["mabh"].Text = "'" + (cboDKBD.Text.Length > 10 ? cboDKBD.Text.Substring(0, 10) : cboDKBD.Text) + "'";

                    if (HTC.ShareVariables.pub_spC == "PH")
                    {
                        Myformulasbn["nguoinhan"].Text = "'" + Pub_sTenNguoiSD + "'";
                    }
                    if (HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")
                    {
                        Myformulasbn["TenQuay"].Text = "'" + Pub_sTenQuay + "'";
                    }
                    Myformulasbn["NgayNhan"].Text = "'" + "Ngày " + ngay + "  tháng  " + thang + "  năm  " + DateTime.Now.Year.ToString() + "'";
                    Myformulasbn["TenBV"].Text = "'" + (HTC.ShareVariables.pub_sTenBV) + "'";
                    Myformulasbn["Tendvcq"].Text = "'" + (HTC.ShareVariables.pub_sTenDVChuQuan) + "'";

                    PrintExport(rptbn);// HTCReportViewer1.LoadReport(rptbn, true, false);

                }

                ReportDocument rpt = new ReportDocument();
                FormulaFieldDefinitions Myformulas;
                if (txtLanVV.Text == "")
                    txtLanVV.Text = "1";

                if (cboLoaiBA.SelectedValue == "00014" && HTC.ShareVariables.pub_spC == "PS" && txtLanVV.Text != "1")
                    sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/crPhieuVaoVienPhuKhoa.rpt";
                else if (cboLoaiBA.SelectedValue == "00026" && HTC.ShareVariables.pub_spC == "PS" && txtLanVV.Text != "1")
                    sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/crPhieuVaoVienSanKhoa.rpt";
                else
                    sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/CRGiayVaoVien.rpt";
                rpt.Load(Server.MapPath(sPath));
                Myformulas = rpt.DataDefinition.FormulaFields;
                Myformulas["mabn"].Text = "'" + (txtmaql.Text == "" ? _ThongTinBN.MaBN : txtmaql.Text) + "'";
                Myformulas["hoten"].Text = "'" + txthoten.Text.Replace("'", "''").ToUpper() + "'";
                Myformulas["Tuoi"].Text = "'" + dtNgaySinh.Text.Substring(6, 4) + "'";
                Myformulas["GT"].Text = "'" + (optGT.Items[0].Selected == false ? "Nữ" : "Nam") + "'";
                Myformulas["khoadt"].Text = "'" + cboKhoaNV.Text + "'";
                if (_ThongTinBN.KhamBenh != null)
                {
                    if (_ThongTinBN.KhamBenh.KhamBenh_C_List.Count > 0)
                    {
                        foreach (KhamBenh_C kb in _ThongTinBN.KhamBenh.KhamBenh_C_List)
                        {
                            if (kb.malh == "00003" || kb.malh == "00030")
                            {
                                Myformulas["khoagt"].Text = "'" + kb.tenkhoa + "'";
                                break;
                            }
                        }
                    }
                }
                Myformulas["TenBV"].Text = "'" + (HTC.ShareVariables.pub_sTenBV) + "'";
                Myformulas["Tendvcq"].Text = "'" + (HTC.ShareVariables.pub_sTenDVChuQuan) + "'";
                Myformulas["lienhe"].Text = "'" + txtBaoTin.Text + "-" + txtdienthoai.Text + "'";
                Myformulas["quan"].Text = "'" + cbohuyen.Text.Replace("'", "''") + "'";
                Myformulas["tinh"].Text = "'" + cbotinh.Text + "'";
                Myformulas["NgheNghiep"].Text = "'" + cboNgheNghiep.Text + "'";
                Myformulas["NgayBC"].Text = "'" + "Ngày " + ngay + "  tháng  " + thang + "  năm  " + DateTime.Now.Year.ToString() + "'";
                if (cboLoaiBA.SelectedValue == "00014" && HTC.ShareVariables.pub_spC == "PS" && txtLanVV.Text != "1")
                {
                    Myformulas["diachi"].Text = "'" + (txtDiaChi.Text + "-" + cbohuyen.Text + "-" + cbotinh.Text).Replace("'", "''") + "'";
                    Myformulas["lanvao"].Text = "'" + txtLanVV.Text + "'";
                }
                else if (cboLoaiBA.SelectedValue == "00026" && HTC.ShareVariables.pub_spC == "PS" && txtLanVV.Text != "1")
                {
                    Myformulas["diachi"].Text = "'" + (txtDiaChi.Text + "-" + cbohuyen.Text + "-" + cbotinh.Text).Replace("'", "''") + "'";
                    Myformulas["lanvao"].Text = "'" + txtLanVV.Text + "'";
                }
                else if (HTC.ShareVariables.pub_spC == "HU")
                    Myformulas["diachi"].Text = "'" + (txtDiaChi.Text + (!string.IsNullOrEmpty(cboPXa.Text) ? " - " + cboPXa.Text : "")).Replace("'", "''") + "'";
                else
                    Myformulas["DiaChi"].Text = "'" + txtDiaChi.Text.Replace("'", "''") + "'";
                Myformulas["noigioithieu"].Text = "'" + cboNoiGT.SelectedItem.Text + "'";
                Myformulas["bacsy"].Text = "'" + cboBacSi.Text + "'";
                //if (txtLanVV.Text != "1" || HTC.ShareVariables.pub_spC != "PS")
                Myformulas["ngayvv"].Text = "' " + DateTime.Parse(dtNgayVV.Text).Hour + " giờ " + DateTime.Parse(dtNgayVV.Text).Minute + " phút ngày " + DateTime.Parse(dtNgayVV.Text).Day + " tháng " + DateTime.Parse(dtNgayVV.Text).Month + " năm " + DateTime.Parse(dtNgayVV.Text).Year + "'";
                //else
                //    Myformulas["ngayvv"].Text = "'       giờ       phút ngày " + DateTime.Parse(dtNgayVV.Text).Day + " tháng " + DateTime.Parse(dtNgayVV.Text).Month + " năm " + DateTime.Parse(dtNgayVV.Text).Year + "'";

                Myformulas["chandoan"].Text = "'" + (cboCDKKBCC.Text.Length > 5 ? cboCDKKBCC.Text.Substring(0, 5) : cboCDKKBCC.Text) + "-" + txtBenhKCC.Text + "'";
                if (HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ ")
                {
                    Myformulas["TenQuay"].Text = "'" + Pub_sTenQuay + "'";
                }
                PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer2.LoadReport(rpt, true, false);


            }
        }

        catch (Exception ex)
        {
            ShowMessage("Không in được báo cáo" + ex.Message);

            //throw;
        }
        return true;
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
    private const string ViewState_ThongTinBN = "ThongTinBN";
    public ThongtinBN _ThongTinBN
    {
        get
        {
            if (ViewState[ViewState_ThongTinBN] == null)
            {
                return null;
            }

            return (ThongtinBN)ViewState[ViewState_ThongTinBN];
        }

        set
        {
            ViewState[ViewState_ThongTinBN] = value;
        }
    }
    private const string ViewState_BenhAnPKtmp = "BenhAnPKtmp";

    public BenhAnPK _BenhAnPKtmp
    {
        get
        {
            if (ViewState[ViewState_BenhAnPKtmp] == null)
            {
                return null;
            }

            return (BenhAnPK)ViewState[ViewState_BenhAnPKtmp];
        }

        set
        {
            ViewState[ViewState_BenhAnPKtmp] = value;
        }
    }

    private const string ViewState_BenhAnPKtmp1 = "BenhAnPKtmp1";

    public BenhAnPK _BenhAnPKtmp1
    {
        get
        {
            if (ViewState[ViewState_BenhAnPKtmp1] == null)
            {
                return null;
            }

            return (BenhAnPK)ViewState[ViewState_BenhAnPKtmp1];
        }

        set
        {
            ViewState[ViewState_BenhAnPKtmp1] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    
    
    {
        
        if (!IsPostBack)
        {

            if (_loaikq == "1")
            {
                if (Request["NgayDK"] == null)
                    Response.Redirect("~/Default.aspx");
                if (Request["MaBN"] == null)
                    Response.Redirect("~/Default.aspx");
                if (Request["MaBA"] == null)
                    Response.Redirect("~/Default.aspx");
            }
            if ((_MaBN == null || _MaBN == "") && Request["MaBN"] != null)
            {
                _MaBN = Request["MaBN"].ToString();
                _MaBA = Request["MaBA"].ToString();
                _ngaydk = Request["NgayDK"].ToString();
                if (Request["STT"] != null)
                    _STT = int.Parse(Request["STT"].ToString());

            }
            lanbao = 0;
            lanbaobn = 0;
            SetData();
            LoadData();
            LoadDetails();

        }
    }

    private void SetData()
    {
        //    // Bind the data
        if (HTC.ShareVariables.pub_spC == "HU" ||HTC.ShareVariables .pub_spC =="QN"  )
        {
            cbohuyen.AutoPostBack = true;
            diachi.ColSpan = 3;
            
        }
        else
        {
            cbohuyen.AutoPostBack = true;
            lblxa.Visible = false;
            lblxa.Disabled = false;
            xa.Visible = false;
            xa.Disabled = false;
        }
                   
        txtview.Value = HTC.ShareVariables.pub_spC;
        if (pub_bQadmin == false)
        {
            baraction.FindItemByValue("cmdHuyBA").Visible = false;
        }
        //if (HTC.ShareVariables.pub_spC == "HU" || (HTC.ShareVariables.pub_spC == "QN" && HTC.ShareVariables.pub_sTenBV != "BỆnh VIỆn CHÂM CỨU TRUNG ƯƠNG"))
        if (HTC.ShareVariables.pub_spC == "HU" )
            cboDoiTuong.Enabled = false;

        if (_MaBA != "" && _loaikq == "1")
        {
            if (Pub_bQuyenForm <= HTC.ShareVariables.KieuFormChiTiet.fThem)
            {
                baraction.FindItemByValue("cmdSave").Enabled = false;
                baraction.FindItemByValue("cmdPrint").Enabled = false;
            }
            if (Pub_bQuyenForm != HTC.ShareVariables.KieuFormChiTiet.fDelete && HTC.ShareVariables.pub_spC != "HU")
            {
                txtBaoTin.Enabled = false;
                txthoten.Enabled = false;

                txthoten.Enabled = false;

                optGT.Enabled = false;

                dtNgaySinh.Enabled = false;
                txttuoi.Enabled = false;

                txtmaql.Enabled = false;

                cbodantoc.Enabled = false;

                cboquocgia.Enabled = false;



                cbotinh.Enabled = false;

                cbohuyen.Enabled = false;

                txtDiaChi.Enabled = false;

                txtdienthoai.Enabled = false;
                cboNgheNghiep.Enabled = false;
                txtBaoTin.Enabled = false;
                cboDKGT.Enabled = false;
                txtTenBVGT.Enabled = false;
                cboCDnoiGT.Enabled = false;
                txtBenhNGT.Enabled = false;
                //cboDoiTuong.Enabled = false;
                cboNoiGT.Enabled = false;
                cboLoaiBA.Enabled = false;
                cboTrucTiepVao.Enabled = false;
                txtLanVV.Enabled = false;
                txtSoVVmoi.Enabled = false;
                cboKhoaNV.Enabled = false;

                txtbschuyen.Enabled = false;
                dtNgayChuyen.Enabled = false;
                txtGhiChu.Enabled = false;

                cboBacSi.Enabled = false;
                cboCDKKBCC.Enabled = false;
                txtBenhKCC.Enabled = false;
                dtNgayVV.Enabled = false;

                cboDKGT.Enabled = false;
                txtTenBVGT.Enabled = false;
                txtMaBAGD.Enabled = false;

                txtSoVVcu.Enabled = false;

            }
           
        }
        if (HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ " && Pub_bQuyenForm ==HTC.ShareVariables.KieuFormChiTiet.fDelete )
        {
            baraction.FindItemByValue("cmdChuyenDT").Visible = true;
        }
    }

    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        if (((RadToolBarButton)e.Item).CommandName.Equals("cmdSave", StringComparison.InvariantCultureIgnoreCase))
        {
            if (UpdateData("0") == true)
            // Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai + "&loaicn=" + loaicn + "&NoiTT=" + _NoiTT,false);
            {
                if ((HTC.ShareVariables.pub_spC == "HU" && (cboKhoaNV.SelectedValue == "007" || cboKhoaNV.SelectedValue == "008") && HTC.ShareVariables.pub_spC!= "BỆNH VIỆN TRUNG ƯƠNG HUẾ ") || HTC.ShareVariables.pub_sTenBV=="BỆNH VIỆN ĐA KHOA MƯỜNG KHƯƠNG")
                    UpdateDataVV();
                CloseWindow();
            }

        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdHuyBA", StringComparison.InvariantCultureIgnoreCase))
        {
           string sql = "update benhanpk set huy = 1, ngayhuy =getdate(), nguoihuy ='"+Pub_sNguoiSD +"' , mamay ='"+Pub_sMaMay +"'  where maba ='" + _MaBA + "' and  isnull(mabanoitru,'')='' ";

            HTC.Business.DataProvider.Instance().ExcSQL(sql);
            ShowMessage("Đã hủy xong bệnh án");
        }
           
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdChuyenDT", StringComparison.InvariantCultureIgnoreCase))
        {
            if (UpdateData("1") == true)
            {
                if (HTC.ShareVariables.pub_spC == "HU" && (cboKhoaNV.SelectedValue == "007" || cboKhoaNV.SelectedValue == "008"))
                    UpdateDataVV();
                baraction.FindItemByValue("cmdSave").Visible = false;
                baraction.FindItemByValue("cmdPrint").Visible = false;

                PrintData();
                CloseWindow();
                //string popupScript = "<script language='javascript'>" + "window.open('" + "~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "', '_blank');</script>";
                //Context.Response.Write(popupScript);

                //Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai + "&loaicn=" + loaicn + "&NoiTT=" + _NoiTT);

                // Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai);

            }

        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdExit", StringComparison.InvariantCultureIgnoreCase))
        {
            // Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai + "&loaicn=" + loaicn + "&NoiTT=" + _NoiTT,false);
            CloseWindow();
        }

        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdPrint", StringComparison.InvariantCultureIgnoreCase))
        {
            if (UpdateData() == true)
            {
                if ((HTC.ShareVariables.pub_spC == "HU" && (cboKhoaNV.SelectedValue == "007" || cboKhoaNV.SelectedValue == "008")) || HTC.ShareVariables.pub_sTenBV=="BỆNH VIỆN ĐA KHOA MƯỜNG KHƯƠNG")
                    UpdateDataVV();
                baraction.FindItemByValue("cmdSave").Visible = false;
                baraction.FindItemByValue("cmdPrint").Visible = false;

                PrintData();
                CloseWindow();
                //string popupScript = "<script language='javascript'>" + "window.open('" + "~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "', '_blank');</script>";
                //Context.Response.Write(popupScript);

                //Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai + "&loaicn=" + loaicn + "&NoiTT=" + _NoiTT);

                // Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai);

            }
        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("exitcmdPrint", StringComparison.InvariantCultureIgnoreCase))
        {
            //HTCReportViewer1.UnLoadReport();
            //HTCReportViewer2.UnLoadReport();
            //  Response.Redirect("~/UI/NoiTru/TiepDon/FrmBenhNhanNoiTruPKDS.aspx?loai=" + _loai + "&NoiTT=" + _NoiTT);

        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdUpLoad", StringComparison.InvariantCultureIgnoreCase))
        {
            if (fuFileUploader.Visible == true)
            {
                UploadFile();
                fuFileUploader.Visible = false;
            }
            else
                fuFileUploader.Visible = true;
        }

        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdXemFile", StringComparison.InvariantCultureIgnoreCase))
        {
            Context.Response.Write("<script> language='javascript'>window.open('frmKhamBenh_File.aspx?maba=" + _ThongTinBN.MaBN + "','_newtab');</script>");
        }


    }
    protected void LoadThongTinBN()
    {

        txthoten.Text = _ThongTinBN.Hoten;
        if (_loaikq == "0" && _ThongTinBN.Hoten != "" && HTC.ShareVariables.pub_spC == "PS")
            txthoten.Enabled = false;

        if (_ThongTinBN.GT == true && _ThongTinBN.IsNew == false)
        {
            optGT.Items[0].Selected = true;
            optGT.Items[1].Selected = false;
            cboGioiTinh.Items[0].Selected = true;

        }
        else
        {
            optGT.Items[1].Selected = true;
            optGT.Items[0].Selected = false;
            cboGioiTinh.Items[1].Selected = true;

        }
        dtNgaySinh.Text = _ThongTinBN.NgaySinh;
        txttuoi.Text = _ThongTinBN.Tuoi.ToString();
        if (txttuoi .Text =="0")
             {
                 txttuoi.Text = DateDiff (DateInterval.Month ,DateTime.Parse (dtNgaySinh.Text),   DateTime.Now ).ToString ();
             }
        txtSoThe.Text = _ThongTinBN.Sothe;
        cboDoiTuong.Text = _ThongTinBN.TenDT;
        cboDoiTuong.SelectedValue = _ThongTinBN.MaDT;
        txtSoCMT.Text = _ThongTinBN.SoCMT;
        txtMaBAGD.Text = _ThongTinBN.MaBAGD;
        cboLoaiGiay.SelectedValue = _ThongTinBN.MaQuanHeQD;
        cboLoaiGiay.SelectedIndex = _ThongTinBN.MaQuanHeQD == "" ? 0 : (_ThongTinBN.MaQuanHeQD == "GCS" ? 1 : 2); ;
        cboLoaiGiay.Text = _ThongTinBN.MaQuanHeQD == "GKS" ? cboLoaiGiay.Items[2].Text : (_ThongTinBN.MaQuanHeQD == "GCS" ? cboLoaiGiay.Items[0].Text : cboLoaiGiay.Items[0].Text);
        txtLoaiGiay.Text = _ThongTinBN.MaQuanHam;
        cboKhuVuc.SelectedValue = _ThongTinBN.MaDonVi;
        cboKhuVuc.Text = _ThongTinBN.MaDonVi;
        if (HTC.ShareVariables.pub_spC == "PS")
            txtmaql.Text = _ThongTinBN.MaBN;
        //else

        //    txtmaql.Text = _ThongTinBN.MaBAQL;
        if (_ThongTinBN.madantoc != "")
        {
            RadComboBoxItem selectedItem = new RadComboBoxItem();
            HTC.Business.CategoryList.DMDantoc list = DMDantoc.GetDMDantoc(_ThongTinBN.madantoc);
            //if (list != null)
            //    selectedItem.Text = list.TenDanToc;
            //list = null;
            //selectedItem.Value = _ThongTinBN.madantoc;
            //cbodantoc.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbodantoc.DataBind();
            if (list != null)
                cbodantoc.Text = list.TenDanToc;
            list = null;
            cbodantoc.SelectedValue = _ThongTinBN.madantoc;

        }
        if (_ThongTinBN.MaQG != "")
        {
            RadComboBoxItem selectedItem = new RadComboBoxItem();
            //if (_ThongTinBN.TenQG == "")
            //{
            //    HTC.Business.CategoryList.DMQuocGia list = DMQuocGia.GetDMQuocGia("00084")  ;
            //    if (list != null)
            //        selectedItem.Text = list.TenQG ;
            //    list = null;

            //}
            //else
            //{
            //    selectedItem.Text = _ThongTinBN.TenQG;
            //}
            //selectedItem.Value = _ThongTinBN.MaQG;
            //cboquocgia.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cboquocgia.DataBind();
            if (_ThongTinBN.TenQG == "")
            {
                HTC.Business.CategoryList.DMQuocGia list = DMQuocGia.GetDMQuocGia("00084");
                if (list != null)
                    cboquocgia.Text = list.TenQG;
                list = null;

            }
            else
            {
                cboquocgia.Text = _ThongTinBN.TenQG;
            }
            cboquocgia.SelectedValue = _ThongTinBN.MaQG;

            // ShowMessage(selectedItem.Text + cboquocgia.Text );
        }
        else
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();
            //if (_ThongTinBN.TenQG == "")
            //{
            //    HTC.Business.CategoryList.DMQuocGia list = DMQuocGia.GetDMQuocGia("00084");
            //    if (list != null)
            //        selectedItem.Text = list.TenQG;
            //    list = null;
            //}
            //else
            //    selectedItem.Text = _ThongTinBN.TenQG;
            //selectedItem.Value = "00084";
            //cboquocgia.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cboquocgia.DataBind();
            RadComboBoxItem selectedItem = new RadComboBoxItem();
            if (_ThongTinBN.TenQG == "")
            {
                HTC.Business.CategoryList.DMQuocGia list = DMQuocGia.GetDMQuocGia("00084");
                if (list != null)
                    cboquocgia.Text = list.TenQG;
                list = null;
            }
            else
                cboquocgia.Text = _ThongTinBN.TenQG;
            cboquocgia.SelectedValue = "00084";

        }
        if (_ThongTinBN.MaTinh != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _ThongTinBN.TenTinh;
            //selectedItem.Value = _ThongTinBN.MaTinh;
            //cbotinh.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbotinh.DataBind();

            cbotinh.Text = _ThongTinBN.TenTinh;
            cbotinh.SelectedValue = _ThongTinBN.MaTinh;

        }
        if (_ThongTinBN.MaHuyen != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _ThongTinBN.TenQH;
            //selectedItem.Value = _ThongTinBN.MaHuyen;
            //cbohuyen.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbohuyen.DataBind();
            cbohuyen.Text = _ThongTinBN.TenQH;
            cbohuyen.SelectedValue = _ThongTinBN.MaHuyen;
        }
        if (_ThongTinBN.MaPXa != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _ThongTinBN.TenQH;
            //selectedItem.Value = _ThongTinBN.MaHuyen;
            //cbohuyen.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbohuyen.DataBind();

            cboPXa.Text = _ThongTinBN.TenPXa;
            cboPXa.SelectedValue = _ThongTinBN.MaPXa;
        }
        txtDiaChi.Text = _ThongTinBN.DiaChi;
        txtBaoTin.Text = _ThongTinBN.BaoTin;
        txtNoiLamViec.Text = _ThongTinBN.NoiLamViec;
        txtdienthoai.Text = _ThongTinBN.DienThoai;

        if (_ThongTinBN.MaNN != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _ThongTinBN.TenNN;
            //selectedItem.Value = _ThongTinBN.MaNN;
            //cboNgheNghiep.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cboNgheNghiep.DataBind();

            cboNgheNghiep.Text = _ThongTinBN.TenNN;
            cboNgheNghiep.SelectedValue = _ThongTinBN.MaNN;

        }
        txtDiaChi.Text = _ThongTinBN.DiaChi;
        txtBaoTin.Text = _ThongTinBN.BaoTin;
        txtdienthoai.Text = _ThongTinBN.DienThoai;
        if (_ThongTinBN.KhamBenh != null)
        {
            if (_ThongTinBN.KhamBenh.MaBV != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _ThongTinBN.KhamBenh.mabhxh;
                //selectedItem.Value = _ThongTinBN.KhamBenh.MaBV;
                //cboDKBD.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKBD.DataBind();
                cboDKBD.Text = _ThongTinBN.KhamBenh.mabhxh;
                cboDKBD.SelectedValue = _ThongTinBN.KhamBenh.MaBV;
                txtTenBVBD.Text = _ThongTinBN.KhamBenh.tenbv;
            }
            if (_ThongTinBN.KhamBenh.MABHXHGT != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _ThongTinBN.KhamBenh.MABHXHGT;
                //selectedItem.Value = _ThongTinBN.KhamBenh.MaBVGT;
                //cboDKGT.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKGT.DataBind();
                cboDKGT.Text = _ThongTinBN.KhamBenh.MABHXHGT;
                cboDKGT.SelectedValue = _ThongTinBN.KhamBenh.MaBVGT;
                txtTenBVGT.Text = _ThongTinBN.KhamBenh.tenbenhngt;
            }
            if (_ThongTinBN.KhamBenh.maicdngt != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _ThongTinBN.KhamBenh.maicdngt;
                //selectedItem.Value = _ThongTinBN.KhamBenh.MaBenhNoiGT;
                //cboCDnoiGT.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboCDnoiGT.DataBind();
                cboCDnoiGT.Text = _ThongTinBN.KhamBenh.maicdngt;
                cboCDnoiGT.SelectedValue = _ThongTinBN.KhamBenh.MaBenhNoiGT;
                txtBenhNGT.Text = _ThongTinBN.KhamBenh.tenbenhngt;
            }
        }
        else
        {
            if (_ThongTinBN.MaBV != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _ThongTinBN.KhamBenh.mabhxh;
                //selectedItem.Value = _ThongTinBN.KhamBenh.MaBV;
                //cboDKBD.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKBD.DataBind();
                cboDKBD.Text = _ThongTinBN.mabhxh;
                cboDKBD.SelectedValue = _ThongTinBN.MaBV;
                txtTenBVBD.Text = _ThongTinBN.tenbv;
            }
        }
        //KhamBenh_C _kbc = _ThongTinBN.KhamBenh.KhamBenh_C_List.FirstOrDefault(X => X.STT == _STT);
        //if (_kbc != null)
        //{

        //    if (_kbc.maicd != "")
        //    {
        //        //RadComboBoxItem selectedItem = new RadComboBoxItem();

        //        //selectedItem.Text = _kbc.maicd;
        //        //selectedItem.Value = _kbc.Mabenh;
        //        //cboCDKKBCC.Items.Add(selectedItem);
        //        //selectedItem.Selected = true;
        //        //selectedItem.DataBind();
        //        //cboCDKKBCC.DataBind();
        //        cboCDKKBCC.Text = _kbc.maicd;
        //        cboCDKKBCC.SelectedValue = _kbc.Mabenh;

        //    }
        //    txtBenhKCC.Text = _kbc.tenbenh;
        //    if (_kbc.MakhoaVV != "")
        //    {
        //        //RadComboBoxItem selectedItem = new RadComboBoxItem();

        //        //selectedItem.Text = DMKhoa.GetDMKhoa(_kbc.MakhoaVV).TenKhoa;
        //        //selectedItem.Value = _kbc.MakhoaVV;
        //        //cboKhoaNV.Items.Add(selectedItem);
        //        //selectedItem.Selected = true;
        //        //selectedItem.DataBind();
        //        //cboKhoaNV.DataBind();
        //        cboKhoaNV.Text = DMKhoa.GetDMKhoa(_kbc.MakhoaVV).TenKhoa;
        //        cboKhoaNV.SelectedValue = _kbc.MakhoaVV;
        //    }
        //}
    }
    protected void LoadDetails()  
    {
        if (HTC.ShareVariables.pub_spC != "YH")
            chanDoanYHCT.Visible = false;
        _ThongTinBN = ThongtinBN.NewThongtinBN(); ;
        if (_loaikq != "0" || _MaBN != "")
        {
            string moi = _ngaydk;
            //_ngaydk = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            DateTime d = DateTime.ParseExact(_ngaydk, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None);

            _ThongTinBN = ThongtinBN.GetThongtinBN(_MaBN, d, 3);



            //string ngaydkStr = _ngaydk;
            //DateTime ngaydk;
            //if (!DateTime.TryParseExact(ngaydkStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaydk))
            //{
            //    throw new Exception("Không thể chuyển đổi ngày đăng ký thành kiểu DateTime.");
            //}
            //_ThongTinBN = ThongtinBN.GetThongtinBN(_MaBN, ngaydk, 3);


        }
        LoadThongTinBN();
        if (_MaBA != "" && _loaikq == "1")
            _BenhAnPK = BenhAnPK.GetBenhAnPK(_MaBA);
        else if (_STT != 0 && _MaBN != "")
        {
            KhamBenh_C _khambenh_c = _ThongTinBN.KhamBenh.KhamBenh_C_List.Containsfind(_STT);
            if (_khambenh_c != null)
            {
                if (_khambenh_c.MaSoKham != "")
                {
                    BenhAnPK _BenhAnPKtmp = BenhAnPK.GetBenhAnPK(_khambenh_c.MaSoKham, _khambenh_c.STT, 1);
                    if (_BenhAnPKtmp.MaBA != "")
                    {
                        _BenhAnPK = BenhAnPK.NewBenhAnPK();
                        _BenhAnPK.NNCapcuu = _BenhAnPKtmp.NNCapcuu;
                        _BenhAnPK.NNTVong = _BenhAnPKtmp.NNTVong;
                        _BenhAnPK.NNTVong = _BenhAnPKtmp.NNTVong;
                        _BenhAnPK.MaLDTVong = _BenhAnPKtmp.MaLDTVong;
                        _BenhAnPK.matgbthuong = _BenhAnPKtmp.matgbthuong;
                        _BenhAnPK.MaTGTVong = _BenhAnPKtmp.MaTGTVong;
                        _BenhAnPK.MaGPTuThi = _BenhAnPKtmp.MaGPTuThi;
                        _BenhAnPK.tinhtrangbn = _BenhAnPKtmp.tinhtrangbn;
                    }
                }
            }
        }
        if (_MaBA != "" && _loaikq == "1")
        {

            txtLanVV.Text = _BenhAnPK.VaoLan.ToString();
            cboLoaiBA.SelectedValue = _BenhAnPK.MaLoaiBA;
            txtSoVVmoi.Text = _BenhAnPK.MaBA;

            if (_BenhAnPK.MaKhoaVV != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _BenhAnPK.TenKhoaVV;
                //selectedItem.Value = _BenhAnPK.MaKhoaVV;
                //cboKhoaNV.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboKhoaNV.DataBind();
                cboKhoaNV.Text = _BenhAnPK.TenKhoaVV;
                cboKhoaNV.SelectedValue = _BenhAnPK.MaKhoaVV;
            }

            cboNoiGT.SelectedValue = _BenhAnPK.MaNoiGT;
            cboTrucTiepVao.SelectedValue = _BenhAnPK.MaNoiKham;
            txtbschuyen.Text = _BenhAnPK.BSChuyenVao;
            dtNgayChuyen.Text = _BenhAnPK.NgayGioCV;
            txtGhiChu.Text = _BenhAnPK.Ghichu;
            cboLoaiBN.SelectedValue = _BenhAnPK.maloaibn;
            if (_BenhAnPK.BSVaovien != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _BenhAnPK.TenBSVaoVien;
                //selectedItem.Value = _BenhAnPK.BSVaovien;
                //cboBacSi.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboBacSi.DataBind();
                cboBacSi.Text = _BenhAnPK.TenBSVaoVien;
                cboBacSi.SelectedValue = _BenhAnPK.BSVaovien;
            }
            if (_BenhAnPK.maicdNGT != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _BenhAnPK.maicdNGT;
                //selectedItem.Value = _BenhAnPK.MaBenhNGT;
                //cboCDnoiGT.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboCDnoiGT.DataBind();
                cboCDnoiGT.Text = _BenhAnPK.maicdNGT;
                cboCDnoiGT.SelectedValue = _BenhAnPK.MaBenhNGT;
            }
            txtBenhNGT.Text = _BenhAnPK.TenBenhNGT;
            if (_BenhAnPK.maicdKKB != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _BenhAnPK.maicdKKB;
                //selectedItem.Value = _BenhAnPK.MaBenhKKB;
                //cboCDKKBCC.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboCDKKBCC.DataBind();
                cboCDKKBCC.Text = _BenhAnPK.maicdKKB;
                cboCDKKBCC.SelectedValue = _BenhAnPK.MaBenhKKB;
            }
            cboChanDoanTheoYHCT.SelectedValue = _BenhAnPK.MaBenhYHCTKKB;
            cboChanDoanTheoYHCT.Text = _BenhAnPK.MaBenhYHCTKKB;
            txtChanDoanTheoYHCT.Text = _BenhAnPK.TenBenhKKBYHCT;
            txtBenhKCC.Text = _BenhAnPK.TenBenhKKB;
            dtNgayVV.Text = _BenhAnPK.NgayGioVV;
            dtBHYTDN.Text = _BenhAnPK.GiaTriDN;
            dtBHYTTN.Text = _BenhAnPK.GiaTriTN;
            txtSoThe.Text = _BenhAnPK.Sothe;
            cboDoiTuong.SelectedValue = _BenhAnPK.MaDT;
            if (HTC.ShareVariables.pub_spC == "PS")
                txtmaql.Text = _BenhAnPK.MaBN;
            else

                txtmaql.Text = _BenhAnPK.MaBAQL;
            if (_BenhAnPK.MaBV != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _BenhAnPK.MaBHXH;
                //selectedItem.Value = _BenhAnPK.MaBV;
                //cboDKBD.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKBD.DataBind();
                cboDKBD.Text = _BenhAnPK.MaBHXH;
                cboDKBD.SelectedValue = _BenhAnPK.MaBV;
            }
            txtTenBVBD.Text = _BenhAnPK.TenBV;
            if (_BenhAnPK.MaBVGT != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _BenhAnPK.MABHXHGT;
                //selectedItem.Value = _BenhAnPK.MaBVGT;
                //cboDKGT.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKGT.DataBind();
                cboDKGT.Text = _BenhAnPK.MABHXHGT;
                cboDKGT.SelectedValue = _BenhAnPK.MaBVGT;
            }
            txtTenBVGT.Text = _BenhAnPK.TenBVGT;
        }
        else
        {


            txtLanVV.Text = "1";

            BenhAnPK _benhanpktmp = BenhAnPK.GetBenhAnPK("");
            if (_benhanpktmp.MaBA.Length > 7)
            {
                txtSoVVcu.Text = (int.Parse(_benhanpktmp.MaBA.Substring(_benhanpktmp.MaBA.Length - 7, 7)) + 1).ToString();
            }
            KhamBenh_C _khambenh_c = _ThongTinBN.KhamBenh.KhamBenh_C_List.Containsfind(_STT);


            if (_khambenh_c != null)
            {
                dtNgayVV.Text = _khambenh_c.NgayKT;
                cboKhoaNV.SelectedValue = _khambenh_c.MakhoaVV;
                
                if (_khambenh_c.BSKham != "")
                {
                    //RadComboBoxItem selectedItem = new RadComboBoxItem();

                    //selectedItem.Text = _khambenh_c.tenbs;
                    //selectedItem.Value = _khambenh_c.BSKham;
                    //cboBacSi.Items.Add(selectedItem);
                    //selectedItem.Selected = true;
                    //selectedItem.DataBind();
                    //cboBacSi.DataBind();
                    cboBacSi.Text = _khambenh_c.tenbs;
                    cboBacSi.SelectedValue = _khambenh_c.BSKham;
                }
                if (_khambenh_c.maicd != "")
                {
                    //RadComboBoxItem selectedItem = new RadComboBoxItem();

                    //selectedItem.Text = _khambenh_c.maicd;
                    //selectedItem.Value = _khambenh_c.Mabenh;
                    //cboCDKKBCC.Items.Add(selectedItem);
                    //selectedItem.Selected = true;
                    //selectedItem.DataBind();
                    //cboCDKKBCC.DataBind();
                    cboCDKKBCC.Text = _khambenh_c.maicd;
                    cboCDKKBCC.SelectedValue = _khambenh_c.Mabenh;
                }



                txtBenhKCC.Text = _khambenh_c.tenbenh;
                if (_khambenh_c.MakhoaVV != "")
                {
                    //RadComboBoxItem selectedItem = new RadComboBoxItem();

                    //selectedItem.Text = DMKhoa.GetDMKhoa(_kbc.MakhoaVV).TenKhoa;
                    //selectedItem.Value = _kbc.MakhoaVV;
                    //cboKhoaNV.Items.Add(selectedItem);
                    //selectedItem.Selected = true;
                    //selectedItem.DataBind();
                    //cboKhoaNV.DataBind();
                    cboKhoaNV.Text = DMKhoa.GetDMKhoa(_khambenh_c.MakhoaVV).TenKhoa;
                    cboKhoaNV.SelectedValue = _khambenh_c.MakhoaVV;
                }


            }
            dtNgayVV.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            dtBHYTDN.Text = _ThongTinBN.GiaTriDN;
            dtBHYTTN.Text = _ThongTinBN.GiaTriTN;
            txtSoThe.Text = _ThongTinBN.Sothe;
            if (_ThongTinBN.KhamBenh.LoaiKham == 2)
            {
                cboNoiGT.SelectedValue = "00048";
            }
            if (HTC.ShareVariables.pub_spC == "PS")
                cboDoiTuong.SelectedValue = "00001";
            else if (_NoiTT == "087")
                cboDoiTuong.SelectedValue = "00002";

            else
                cboDoiTuong.SelectedValue = _ThongTinBN.MaDT;
            if (_ThongTinBN.KhamBenh.MaBV != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _ThongTinBN.KhamBenh.mabhxh;
                //selectedItem.Value = _ThongTinBN.KhamBenh.MaBV;
                //cboDKBD.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKBD.DataBind();
                cboDKBD.Text = _ThongTinBN.KhamBenh.mabhxh;
                cboDKBD.SelectedValue = _ThongTinBN.KhamBenh.MaBV;
            }
            txtTenBVBD.Text = _ThongTinBN.KhamBenh.tenbv;
            if (_ThongTinBN.KhamBenh.MaBVGT != "")
            {
                //RadComboBoxItem selectedItem = new RadComboBoxItem();

                //selectedItem.Text = _ThongTinBN.KhamBenh.MABHXHGT;
                //selectedItem.Value = _ThongTinBN.KhamBenh.MaBVGT;
                //cboDKBD.Items.Add(selectedItem);
                //selectedItem.Selected = true;
                //selectedItem.DataBind();
                //cboDKGT.DataBind();
                cboDKGT.Text = _ThongTinBN.KhamBenh.MABHXHGT;
                cboDKGT.SelectedValue = _ThongTinBN.KhamBenh.MaBVGT;
            }
            txtTenBVGT.Text = _ThongTinBN.KhamBenh.TenBVGT;
        }
        if (cboDoiTuong.SelectedValue.Substring(0, 1) == "0" || cboDoiTuong.SelectedValue.Substring(0, 1) == "2")
        {
            dtBHYTTN.Enabled = false;
            dtBHYTDN.Enabled = false;
            // txtSoThe.Enabled = false;
            cboDKBD.Enabled = false;
            txtTenBVBD.Enabled = false;

            cboDKGT.Enabled = false;
            txtTenBVGT.Enabled = false;
        }
        else if (cboDoiTuong.SelectedValue.Substring(0, 1) == "0")
        {
            dtBHYTTN.Enabled = true;
            dtBHYTDN.Enabled = true;
            txtSoThe.Enabled = true;
            cboDKBD.Enabled = true;
            txtTenBVBD.Enabled = true;

            cboDKGT.Enabled = false;
            txtTenBVGT.Enabled = false;
            if (cboDoiTuong.SelectedValue.Substring(cboDoiTuong.SelectedValue.Length - 1, 1) != "10008")
            {
                cboDKGT.Enabled = true;
                txtTenBVGT.Enabled = true;
            }
        }
        if (txtSoThe.Text != "")
        {
            txtTenBVBD.Enabled = false;
            cboDKBD.Enabled = false;
        }
        txthoten.Focus();


        DataTable dt = spDMUpdateVV_KB(_ThongTinBN.MaBN);
        if (dt != null && dt.Rows.Count > 0)
        {
            string mavaovien = dt.Rows[0][0].ToString();
            string lydovaovien = dt.Rows[0][1].ToString();
            string makhambenh = dt.Rows[0][2].ToString();
            string doituongkhambenh = dt.Rows[0][3].ToString();
            cbolydovaovien.SelectedValue = mavaovien;
            cbolydovaovien.Text = lydovaovien;
            cbodoituongkhambenh.SelectedValue = makhambenh;
            cbodoituongkhambenh.Text = doituongkhambenh;
        }



    }

    protected void LoadData()
    {

        cbolydovaovien.DataSource = GetDMlydovaovienM();// combo 
        cbolydovaovien.DataBind();

        cbodoituongkhambenh.DataSource = GetDMdoituongkhambenhM();// combo 
        cbodoituongkhambenh.DataBind();


    }

    private void CheckThe()   
    {
        string ketqua = "";

        string sql = " insert into CheckOutTheBHYT(SoThe,HoTen,NgaySinh,NgayLap,MaLoi,MoTa,MaMay,NguoiLap) select ";

        try
        {
            HisBHYT bhyt = new HisBHYT();
            HisBHYT.KQNhanLichSuKCB2018 ls = bhyt.CheckOutSoThe2018(txtSoThe.Text.ToUpper(), txthoten.Text.ToUpper(), dtNgaySinh.Text, (optGT.Items[0].Selected == true ? "1" : "2"), dtBHYTTN.Text, dtBHYTDN.Text, cboDKBD.Text);
           
              if (ls == null)
            {

                if (ketqua == "")
                {
                    sql = sql + "'" + txtSoThe.Text + "',N'" + txthoten.Text + "','" + dtNgaySinh.Text + "',getdate(),null,N'" + "Không thể tra cứu thẻ bảo hiểm trên cổng BHXH!Kiểm tra kết nối hoặc mật khẩu" + Application["BH_user"].ToString() + "/" + Application["BH_password"].ToString() + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";
                }
                HTC.Business.DataProvider.Instance().ExcSQL(sql);
                ketqua = "Không thể tra cứu thẻ bảo hiểm trên cổng BHXH!Kiểm tra kết nối hoặc mật khẩu";

            }
            else if (ls.maKetQua == "401" || ls.maKetQua == "500")
            {

                ketqua = "Không kết nối được với máy BHYT";
                sql = sql + "'" + txtSoThe.Text + "',N'" + txthoten.Text + "','" + dtNgaySinh.Text + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "01" || ls.maKetQua == "02" || ls.maKetQua == "03" || ls.maKetQua == "04")
            {
                ketqua = "Thẻ khám bệnh có vấn đề về hạn thẻ! Hạn thẻ trên cổng BHXH giá trị  từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen;
                //dtBHYTTN.Text = ls.gtTheTu;
                //dtBHYTDN.Text = ls.gtTheDen;
                //  sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "08" || ls.maKetQua == "080")
            {
                ketqua = "Thẻ khám bệnh bị sai giới tính";
                //   sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "09" || ls.maKetQua == "090")
            {

                ketqua = "Thẻ khám bệnh bị sai nơi đăng ký ban đầu! Nơi đăng ký ban đầu của thẻ là +" + ls.maDKBD;
                //   sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "07" || ls.maKetQua == "070")
            {

                ketqua = "Thẻ khám bệnh bị sai ngày sinh ";
                //   sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "010")
            {


                ketqua = "Thẻ hết giá trị sử dụng! Hạn thẻ trên cổng BHXH giá trị  từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + " thời điểm đủ năm 5 năm liên tục : " + ls.ngayDu5Nam;

                //   sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";
                //dtBHYTTN.Text = ls.gtTheTu;
                //dtBHYTDN.Text = ls.gtTheDen;
            }
            else if (ls.maKetQua == "110")
            {
                ketqua = "Thẻ bị thu hồi! Hạn thẻ trên cổng BHXH giá trị  từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + " thời điểm đủ năm 5 năm liên tục : " + ls.ngayDu5Nam;
                //  sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }

            else if (ls.maKetQua == "110" || ls.maKetQua == "120" || ls.maKetQua == "121" || ls.maKetQua == "122" || ls.maKetQua == "123" || ls.maKetQua == "124")
            {


                ketqua = "Thẻ đã báo giảm!Nơi đăng ký ban đầu trên cổng BHXH của thẻ là +" + ls.maDKBD + " giá trị  từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + " thời điểm đủ năm 5 năm liên tục : " + ls.ngayDu5Nam;
                //  sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "051" || ls.maKetQua == "050" || ls.maKetQua == "052" || ls.maKetQua == "053")
            {


                ketqua = "Các thông tin trên thẻ bị sai! Nơi đăng ký ban đầu trên cổng BHXH của thẻ là :" + ls.maDKBD + " giá trị  từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + " thời điểm đủ năm 5 năm liên tục : " + ls.ngayDu5Nam;
                //sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }
            else if (ls.maKetQua == "060" || ls.maKetQua == "061" || ls.maKetQua == "06")
            {


                ketqua = "Thông tin họ tên trên thẻ bị sai ";
                // sql = sql + "'" + txtSoThe .Text + "',N'" + ls.hoTen  + "','" + dtNgaySinh .Text + "',getdate(),'"+ ls.maKetQua +"',N'" +ketqua +"','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

            }

            if (ls != null)
            {
                if (ls.gtTheDen != "" && ls.gtTheDen != null)
                {
                    dtBHYTDN.Text = ls.gtTheDen;
                    dtBHYTTN.Text = ls.gtTheTu;
                    if (ls.gioiTinh == "Nữ")
                    {
                        cboGioiTinh.Items[1].Selected = true;
                        optGT.Items[1].Selected = true;
                    }
                    else
                    {
                        cboGioiTinh.Items[0].Selected = true;
                        optGT.Items[0].Selected = true;
                    }
                    DMBenhVienList _DMBenhVienl = DMBenhVienList.FindDMBenhVienByMa(ls.maDKBD);
                    if (_DMBenhVienl.Count > 0)
                    {
                        cboDKBD.SelectedValue = _DMBenhVienl[0].MaBV;
                        txtTenBVBD.Text = _DMBenhVienl[0].TenBV;
                        cboDKBD.Text = _DMBenhVienl[0].MaBHXH;
                      
                        cbotinh.Focus();
                    }
                    else
                    {
                        ShowMessage("Không có mã bệnh viện này ");

                    }        
                }
                //_ThongTinBN.ngayDu5Nam = ls.ngayDu5Nam;
                //_ThongTinBN.MaKV = ls.maKV;
                //_ThongTinBN.KhamBenh.ngayDu5Nam = ls.ngayDu5Nam;
                //_ThongTinBN.KhamBenh.MaKV = ls.maKV;
                if (ls.dsLichSuKCB2018 != null)
                {
                    if (ls.dsLichSuKCB2018.Length > 0)
                    {
                        HisBHYT.HoSo2018 hs = ls.dsLichSuKCB2018[0];
                        if ((DateTime.Parse(hs.ngayRa.Substring(6, 2) + "/" + hs.ngayRa.Substring(4, 2) + "/" + hs.ngayRa.Substring(0, 4)) - DateTime.Now).Days >= -7)
                        {
                            ketqua = ketqua + ". Khám ngày cuối là " + hs.ngayRa.Substring(6, 2) + "/" + hs.ngayRa.Substring(4, 2) + "/" + hs.ngayRa.Substring(0, 4) + " với bệnh là " + hs.tenBenh;

                            sql = sql + "'" + txtSoThe.Text + "',N'" + ls.hoTen + "','" + dtNgaySinh.Text + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + " ! Hạn thẻ từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";
                        }
                        else
                        {
                            sql = sql + "'" + txtSoThe.Text + "',N'" + ls.hoTen + "','" + dtNgaySinh.Text + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + " ! Hạn thẻ từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + " ! Khám ngày cuối là " + hs.ngayRa + " với bệnh là " + hs.tenBenh + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

                        }
                        //if (dtBHYTTN.Text != ls.gtTheTu || dtBHYTDN.Text != ls.gtTheDen)
                        //    ketqua = "Thẻ " + txtSoThe.Text + " họ tên là :" + txthoten.Text + " có giá trị thẻ BHYT từ ngày  :" + ls.gtTheTu + " đến ngày :" + ls.gtTheDen + " thời điểm đủ năm 5 năm liên tục : " + ls.ngayDu5Nam + ".Yêu cầu check lại giá trị thẻ! " + ketqua;

                        HTC.Business.DataProvider.Instance().ExcSQL(sql);
                    }
                    else
                    {

                        ketqua = ketqua + "Bệnh nhân chưa có lịch sử khám bệnh";

                        //if (dtBHYTTN.Text != ls.gtTheTu || dtBHYTDN.Text != ls.gtTheDen)
                        //    ketqua = "Thẻ " + txtSoThe.Text + " họ tên là :" + txthoten.Text + " có giá trị thẻ BHYT từ ngày  :" + ls.gtTheTu + " đến ngày :" + ls.gtTheDen + " thời điểm đủ năm 5 năm liên tục : " + ls.ngayDu5Nam + ".Yêu cầu check lại giá trị thẻ! " + ketqua;
                        if (sql == " insert into CheckOutTheBHYT(SoThe,HoTen,NgaySinh,NgayLap,MaLoi,MoTa,MaMay,NguoiLap) select ")
                        {
                            sql = sql + "'" + txtSoThe.Text + "',N'" + ls.hoTen + "','" + dtNgaySinh.Text + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + " ! Hạn thẻ từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";
                        }
                        HTC.Business.DataProvider.Instance().ExcSQL(sql);
                    }
                }
                else
                {
                    if (ketqua == "")
                    {
                        ketqua = "Bệnh nhân chưa có lịch sử khám bệnh trên cổng BHYT" + ls.maKetQua;
                    }
                    if (sql == " insert into CheckOutTheBHYT(SoThe,HoTen,NgaySinh,NgayLap,MaLoi,MoTa,MaMay,NguoiLap) select ")
                    {
                        sql = sql + "'" + txtSoThe.Text + "',N'" + ls.hoTen + "','" + dtNgaySinh.Text + "',getdate(),'" + ls.maKetQua + "',N'" + ketqua + " ! Hạn thẻ từ ngày  :" + ls.gtTheTu + " đến ngày là :" + ls.gtTheDen + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";
                    }
                    HTC.Business.DataProvider.Instance().ExcSQL(sql);
                }

                //dtBHYTTN.Text = ls.gtTheTu;
                //dtBHYTDN.Text = ls.gtTheDen;
            }
            if (HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "QN")
            {
                ketqua = ketqua + ". Họ tên : " + ls.hoTen + ", Giới tính : " + ls.gioiTinh + " , Hạn thẻ : " + ls.gtTheTu + "-" + ls.gtTheDen;
                ketqua = ketqua + " . Thời điểm đủ 5 năm liên tục : " + ls.ngayDu5Nam + " . Nơi KCBBĐ:" + ls.maDKBD;
                if (ls.maTheMoi != "" && ls.maTheMoi != ls.maThe)
                    ketqua = ketqua + ". Chủ thẻ đã được cấp mã thẻ mới: " + ls.maTheMoi + " hạn thẻ từ: " + ls.gtTheTuMoi + " đến " + ls.gtTheDenMoi + " . Nơi KCBBĐ:" + ls.maDKBD;
                else if (ls.gtTheDenMoi != ls.gtTheDen && ls.maTheMoi == ls.maThe)
                {
                    ketqua = ketqua + ". Chủ thẻ đã được gia hạn thẻ mới: " + ls.maTheMoi + " hạn thẻ từ: " + ls.gtTheTuMoi + " đến " + ls.gtTheDenMoi + " . Nơi KCBBĐ:" + ls.maDKBD;
                    if (ls.gtTheDenMoi != "" && ls.gtTheDenMoi != null)
                    {
                        dtBHYTDN.Text = ls.gtTheDenMoi;
                        dtBHYTTN.Text = ls.gtTheTuMoi;
                    }
                }
                HisBHYT.HoSo2018 hs = ls.dsLichSuKCB2018[0];
                if (ls.dsLichSuKCB2018 != null)
                {

                    if (ls.dsLichSuKCB2018.Length > 0)
                        ketqua = ketqua + ".Khám ngày cuối là " + hs.ngayRa.Substring(6, 2) + "/" + hs.ngayRa.Substring(4, 2) + "/" + hs.ngayRa.Substring(0, 4) + " với bệnh là " + hs.tenBenh;
                }
                ShowMessage(ketqua);
            }
            else if (ketqua != "")
                ShowMessage(ketqua);

        }
        catch (Exception ex)
        {
            try
            {
                 lanbao = ++lanbao;
                if (ketqua != "")
                    ShowMessage(ketqua);
                else
                {
                    ketqua = "Không thể tra cứu thẻ bảo hiểm trên cổng BHXH!Kiểm tra kết nối hoặc mật khẩu";
                    ShowMessage(ketqua);
                   
                }
                if (sql == " insert into CheckOutTheBHYT(SoThe,HoTen,NgaySinh,NgayLap,MaLoi,MoTa,MaMay,NguoiLap) select ")
                {
                    sql = sql + "'" + txtSoThe.Text + "',N'" + txthoten.Text + "','" + dtNgaySinh.Text + "',getdate(),null,N'" + "Không thể tra cứu thẻ bảo hiểm trên cổng BHXH!Kiểm tra kết nối hoặc mật khẩu" + Application["BH_user"].ToString() + "/" + Application["BH_password"].ToString() + "','" + Pub_sMaMay + "','" + Pub_sNguoiSD + "'";

                    HTC.Business.DataProvider.Instance().ExcSQL(sql);
                }

            }
            catch (Exception ex1)
            {
                lanbao = ++lanbao;
                ShowMessage(ex1.Message);
            }
        }
      
    }
    protected Boolean UpdateData(string madt ="0")    
    {
        try
        {
            if (baraction.FindItemByValue("cmdSave").Enabled == false || baraction.FindItemByValue("cmdSave").Visible == false)
                return false;
            if (CheckData() == false)
                return false;
            if (txtSoThe.Text != "" && lanbao ==0)
            {
               
                CheckThe();
                if (lanbao > 0 && HTC.ShareVariables .pub_spC !="PH" )
                {
                    return false;
                }
            }
            if (_ThongTinBN.IsNew == true && lanbaobn == 0)
            {
                if (SearchData() == false)
                    return false;
            }
            if (txtSoThe.Text != "" && txtMaBAGD.Text == "" && HTC.ShareVariables.pub_spC == "HU"  && HTC.ShareVariables.pub_sTenBV != "BỆNH VIỆN TRUNG ƯƠNG HUẾ - CƠ SỞ 2")
            {
                BenhAn_ChuyenBN chuyen = BenhAn_ChuyenBN.GetBenhAn_ChuyenBN(txtSoThe.Text, 0);
                if (chuyen.MaBA != "")
                {
                    ShowMessage("Bệnh nhân này là bệnh nhân ghép bệnh án!Yêu cầu nhập bệnh án liên quan");
                    return false;
                }
            }
                    
            // thong tinbn 
            _ThongTinBN.GiaTriDN = dtBHYTDN.Text;
            _ThongTinBN.GiaTriTN = dtBHYTTN.Text;
            _ThongTinBN.Hoten = txthoten.Text;
            _ThongTinBN.MaDT = cboDoiTuong.SelectedValue;
            _ThongTinBN.Sothe = txtSoThe.Text;
            _ThongTinBN.MaBV = cboDKBD.SelectedValue;
            _ThongTinBN.SoCMT = txtSoCMT.Text;
            _ThongTinBN.MaDonVi = cboKhuVuc.SelectedValue;
            _ThongTinBN.MaQuanHam = cboLoaiGiay.SelectedValue;
            _ThongTinBN.MaQuanHeQD = txtLoaiGiay.Text;
            if (optGT.Items[0].Selected == true)

                _ThongTinBN.GT = true;
            else
                _ThongTinBN.GT = false;
            if (cboGioiTinh.Visible == true)
            {
                if (cboGioiTinh.Items[0].Selected == true)
                {
                    optGT.Items[0].Selected = true;
                    _ThongTinBN.GT = true;
                }
                else
                {
                    _ThongTinBN.GT = false;
                    optGT.Items[1].Selected = true;
                }
            }
            string sql = "UPDATE ThongTinBN SET Lydovaovien = '" + cbolydovaovien.SelectedValue + "', Doituongkhambenh = '" + cbodoituongkhambenh.SelectedValue + "' WHERE mabn = '" + _ThongTinBN.MaBN + "'";
            HTC.Business.DataProvider.Instance().ExcSQL(sql);

            _ThongTinBN.MaBAGD = txtMaBAGD.Text;
            _ThongTinBN.NgaySinh = dtNgaySinh.Text;
            _ThongTinBN.Tuoi = byte.Parse(txttuoi.Text);
            _ThongTinBN.MaBAQL = txtmaql.Text;
            _ThongTinBN.madantoc = cbodantoc.SelectedValue;
            _ThongTinBN.MaQG = cboquocgia.SelectedValue;
            _ThongTinBN.MaTinh = cbotinh.SelectedValue;
            _ThongTinBN.MaHuyen = cbohuyen.SelectedValue;
            _ThongTinBN.MaPXa = cboPXa.SelectedValue;
            _ThongTinBN.TenPXa = cboPXa.Text;
            _ThongTinBN.MaNN = cboNgheNghiep.SelectedValue;

            _ThongTinBN.DiaChi = txtDiaChi.Text;
            _ThongTinBN.BaoTin = txtBaoTin.Text;
            _ThongTinBN.NoiLamViec = txtNoiLamViec.Text;
            _ThongTinBN.DienThoai = txtdienthoai.Text;



            if (_ThongTinBN.IsNew == true)
            {
                _ThongTinBN.NguoiLap = Pub_sNguoiSD;
                _ThongTinBN.MaMay = Pub_sMaMay;
            }
            else if (_ThongTinBN.IsDirty == true)
            {
                _ThongTinBN.NguoiSD = Pub_sNguoiSD;
                _ThongTinBN.MaMay = Pub_sMaMay;
            }

            _ThongTinBN.ApplyEdit();
            _ThongTinBN = _ThongTinBN.Save();

            //benhan_pk
            if (_BenhAnPK == null)
                _BenhAnPK = BenhAnPK.NewBenhAnPK();
            _BenhAnPK.NgayGioVV = dtNgayVV.Text;
            _BenhAnPK.NgayVKhoa = dtNgayVV.Text;
            _BenhAnPK.MaBN = _ThongTinBN.MaBN;
            if (_ThongTinBN.KhamBenh != null)
                _BenhAnPK.MaSoKham = _ThongTinBN.KhamBenh.MaSoKham;
            _BenhAnPK.MaBAQL = txtmaql.Text;
            _BenhAnPK.VaoLan = txtLanVV.Text == "" ? byte.Parse("1") : byte.Parse(txtLanVV.Text);
            _BenhAnPK.MaLoaiBA = cboLoaiBA.SelectedValue;
            _BenhAnPK.BSChuyenVao = txtbschuyen.Text;
            _BenhAnPK.NgayGioCV = dtNgayChuyen.Text;
            _BenhAnPK.MaKhoaVV = cboKhoaNV.SelectedValue;
            _BenhAnPK.MaNoiGT = cboNoiGT.SelectedValue;
            _BenhAnPK.MaNoiKham = cboTrucTiepVao.SelectedValue;
            _BenhAnPK.Ghichu = txtGhiChu.Text;
            _BenhAnPK.Loai = (byte)3;
            _BenhAnPK.NoiTT = _NoiTT;
            _BenhAnPK.NgayGioCV = dtNgayChuyen.Text;
            _BenhAnPK.BSVaovien = cboBacSi.SelectedValue;
            _BenhAnPK.TenBenhNGT = txtBenhNGT.Text;
            _BenhAnPK.TenBenhKKB = txtBenhKCC.Text;
            _BenhAnPK.MaBenhKKB = cboCDKKBCC.SelectedValue;
            _BenhAnPK.MaBenhNGT = cboCDnoiGT.SelectedValue;
            _BenhAnPK.MaBenhYHCTKKB = cboChanDoanTheoYHCT.SelectedValue;
            _BenhAnPK.TenBenhKKBYHCT = txtChanDoanTheoYHCT.Text;
            _BenhAnPK.MaBV = cboDKBD.SelectedValue;
            _BenhAnPK.MaBVGT = cboDKGT.SelectedValue;
            if (HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ " && HTC.ShareVariables.pub_spC == "HU" && madt == "0")
                _BenhAnPK.MaDT = "00001";
            else
                _BenhAnPK.MaDT = cboDoiTuong.SelectedValue;
            _BenhAnPK.Sothe = txtSoThe.Text;
            _BenhAnPK.GiaTriDN = dtBHYTDN.Text;
            _BenhAnPK.GiaTriTN = dtBHYTTN.Text;
            _BenhAnPK.maloaibn = cboLoaiBN.SelectedValue;
            if (_BenhAnPK.IsNew == true)
            {
                _BenhAnPK.NguoiLap = Pub_sNguoiSD;
                _BenhAnPK.MaMay = Pub_sMaMay;
            }

            _BenhAnPK.NguoiSD = Pub_sNguoiSD;
            _BenhAnPK.MaMay = Pub_sMaMay;

            _BenhAnPK.ApplyEdit();
            _BenhAnPK = _BenhAnPK.Save();
            if (HTC.ShareVariables.pub_spC == "HU" && txtmaql.Text == "")
                txtmaql.Text = _BenhAnPK.MaBA.Substring(4);
            //if (_loaikq == "0" && HTC.ShareVariables.pub_spC == "HU")
            //{
            //    if (UpdateDataVV() == true)
            //        return true;
            //    else
            //        return false;
            //}
            return true;
        }
        catch (Exception ex)
        {
            lanbao = ++lanbao;
            ShowMessage("Không lưu được dữ liệu" + ex.Message);
            //throw;
            return false;
        }


    }

    protected Boolean UpdateDataVV()
    {
        try
        {
            if (baraction.FindItemByValue("cmdSave").Enabled == false || baraction.FindItemByValue("cmdSave").Visible == false)
                return false;
            if (_loaikq == "1")
                return true;
            BenhNhan _BenhNhan = BenhNhan.NewBenhNhan();
            if (_ThongTinBN.IsNew ==false) 
            {
                _BenhNhan = BenhNhan.GetBenhNhan(_ThongTinBN.MaBN);
                if (_BenhNhan.MaBN =="")
                    _BenhNhan = BenhNhan.NewBenhNhan();
            }
            BenhAn _BenhAn = BenhAn.NewBenhAn();
           
            _BenhNhan.BaoTin = _ThongTinBN.BaoTin;
            _BenhNhan.DiaChi = _ThongTinBN.DiaChi;
            _BenhNhan.DienThoai = _ThongTinBN.DienThoai;
            _BenhNhan.MaBAGD = _ThongTinBN.MaBAGD;
            _BenhNhan.RHD = _ThongTinBN.RHD;
            _BenhNhan.Ghichu = _ThongTinBN.Ghichu;
            _BenhNhan.GT = _ThongTinBN.GT;
            _BenhNhan.Hoten = _ThongTinBN.Hoten;
            _BenhNhan.HoTenBoMe = _ThongTinBN.hotenbome;
            _BenhNhan.MaBN = _BenhAnPK.MaBN;
            _BenhNhan.MaDanToc = _ThongTinBN.madantoc;
            _BenhNhan.MaHuyen = _ThongTinBN.MaHuyen;
            _BenhNhan.MaPXa = _ThongTinBN.MaPXa;
            _BenhNhan.MaNN = _ThongTinBN.MaNN;
            _BenhNhan.MaQG = _ThongTinBN.MaQG;
            _BenhNhan.MaTinh = _ThongTinBN.MaTinh;
            _BenhNhan.TenTinh = _ThongTinBN.TenTinh;
            _BenhNhan.TenQH = _ThongTinBN.TenQH;
            //_BenhNhan.ngayDu5Nam = _ThongTinBN.ngayDu5Nam;
            //_BenhNhan.NgayMienCCT = _ThongTinBN.NgayMienCCT;
            _BenhNhan.MaKV = _ThongTinBN.MaKV;
            _BenhNhan.MaQuanHeQD = _ThongTinBN.MaQuanHeQD;
            _BenhNhan.MaDonVi = _ThongTinBN.MaDonVi;
            _BenhNhan.SoCMT = _ThongTinBN.SoCMT;
            _BenhNhan.NgaySinh = _ThongTinBN.NgaySinh;
            _BenhNhan.NhomMau = _ThongTinBN.NhomMau;
            _BenhNhan.TienSuGiaDinh = _ThongTinBN.TienSuGiaDinh;
            _BenhNhan.TienSu = _ThongTinBN.TienSu;
            _BenhNhan.TienSuThuoc = _ThongTinBN.TienSuThuoc;
            _BenhNhan.Tuoi = _ThongTinBN.Tuoi;

            _BenhAn = BenhAn.NewBenhAn();
            if (_ThongTinBN.KhamBenh == null)
            {
                _BenhAn.bhtra = 0;
                _BenhAn.CDNoiGT = _BenhAnPK.TenBenhNGT;
                _BenhAn.sotienbhtra = 0;

            }
            else
            {
                _BenhAn.bhtra = _ThongTinBN.KhamBenh.bhtra;
                _BenhAn.CDNoiGT = _ThongTinBN.KhamBenh.CDNoiGT;
                _BenhAn.sotienbhtra = _ThongTinBN.KhamBenh.sotienbhtra;

            }
            ///chinh moi them môi 1 dong nay
            ///    // add cac gia tri vao bang benh an

            _BenhAn.MaLoaiBA = _BenhAnPK.MaLoaiBA;

            _BenhAn.MaBAQL = _BenhAnPK.MaBAQL;
            if (string.IsNullOrEmpty(_BenhAn.MaBAQL))
            {
                _BenhAn.MaBAQL = _BenhAnPK.MaBN;
            }
            _BenhAn.NoiTT = _NoiTT;
            _BenhAn.Diachi = _ThongTinBN.DiaChi;
            _BenhAn.Ghichu = _ThongTinBN.Ghichu;
            _BenhAn.GiatriDN = _BenhAnPK.GiaTriDN;
            _BenhAn.GiaTriTN = _BenhAnPK.GiaTriTN;
            _BenhAn.MaLoaiBA = _BenhAnPK.MaLoaiBA;
            _BenhAn.MaBenhNoiGT = _BenhAnPK.MaBenhNGT;
            _BenhAn.mabhxh = _BenhAnPK.MaBHXH;
            _BenhAn.MaBN = _BenhAnPK.MaBN;
            _BenhAn.MaBAQL = _BenhAnPK.MaBAQL;
            _BenhAn.MaBV = _BenhAnPK.MaBV;
            _BenhAn.MaBV = _BenhAnPK.MaBV;
            _BenhAn.mabhxh = _BenhAnPK.MaBHXH;
            _BenhAn.TenBV = _BenhAnPK.TenBV;
            _BenhAn.MaDT = _BenhAnPK.MaDT;
            _BenhAn.maicdngt = _BenhAnPK.maicdNGT;
            _BenhAn.maicdngt = _BenhAnPK.TenBenhNGT;
            _BenhAn.MaKhoa_HT = _BenhAnPK.MaKhoaVV;
            _BenhAn.TenKhoaHT = _BenhAnPK.TenKhoaVV;
            _BenhAn.MaNoiGT = _BenhAnPK.MaNoiGT;
            _BenhAn.MaTinh = _ThongTinBN.MaTinh;
            _BenhAn.NgayVV = _BenhAnPK.NgayGioVV;
            _BenhAn.Sothe = _BenhAnPK.Sothe;
            _BenhAn.tenbenhngt = _BenhAnPK.TenBenhNGT;
            _BenhAn.TenBV = _BenhAnPK.TenBV;
            _BenhAn.tendt = _BenhAnPK.TenDT;

            _BenhAn.GiaTriTN = _BenhAnPK.GiaTriTN;

            _BenhAn.GiatriDN = _BenhAnPK.GiaTriDN;

            _BenhNhan.NguoiLap = Pub_sNguoiSD;
            _BenhNhan.MaMay = Pub_sMaMay;
            _BenhNhan.ApplyEdit();
            _BenhNhan = _BenhNhan.Save();

            _BenhAn.NoiTT = _NoiTT;
            _BenhAn.NguoiLap = Pub_sNguoiSD;
            _BenhAn.MaMay = Pub_sMaMay;
            _BenhAn.ApplyEdit();
            _BenhAn = _BenhAn.Save();
            //benhan khoa;

            BenhAn_Khoa _BenhAn_Khoa = BenhAn_Khoa.NewBenhAn_Khoa();
            _BenhAn_Khoa.MaBA = _BenhAn.MaBA;
            _BenhAn_Khoa.MaDT = _BenhAn.MaDT;
            _BenhAn_Khoa.MaKhoa = _BenhAn.MaKhoa_HT;
            _BenhAn_Khoa.MaBN = _BenhAn.MaBN;
            _BenhAn_Khoa.NgayVKhoa = _BenhAn.NgayVV;
            _BenhAn_Khoa.MaBenh = _BenhAnPK.MaBenhKKB;
            _BenhAn_Khoa.MaBenhKem = _BenhAnPK.MabenhKem;
            _BenhAn_Khoa.TenBenh = _BenhAnPK.TenBenhKKB;
            _BenhAn_Khoa.TenBenhKem = _BenhAnPK.tenbenhKem;

            _BenhAn_Khoa.NguoiLap = Pub_sNguoiSD;
            _BenhAn_Khoa.MaMay = Pub_sMaMay;
            _BenhAn_Khoa.Clone();
            _BenhAn_Khoa.ApplyEdit();
            _BenhAn_Khoa = _BenhAn_Khoa.Save();
            //update benhanpk
            string sql = "update benhanpk set mabanoitru ='" + _BenhAn.MaBA + "' where maba ='" + _MaBA + "'";
            HTC.Business.DataProvider.Instance().ExcSQL(sql);


            return true;
        }
        catch (Exception ex)
        {
            ShowMessage("Không lưu được dữ liệu" + ex.Message);
            return false;
        }
    }
    protected void cboBenh_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhTat dataItem = e.Item.DataItem as DMBenhTat;

        if (dataItem == null)
            e.Item.Attributes["TenBenh"] = "";
        else
            e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
    }
    protected void cboBenhDanh_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhDanh dataItem = e.Item.DataItem as DMBenhDanh;

        if (dataItem == null)
            e.Item.Attributes["TenBenh"] = "";
        else
            e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
    }

    protected void cboBenhVien_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhVien dataItem = e.Item.DataItem as DMBenhVien;

        if (dataItem == null)
            e.Item.Attributes["TenBV"] = "";
        else
            e.Item.Attributes["TenBV"] = dataItem.TenBV.ToString();
    }
    protected void txtSoThe_TextChanged(object sender, EventArgs e)
    {
        if (txtSoThe.Text != "")
            if (txtSoThe.Text.Length < 15 && txtSoThe.Text.Substring(0, 2).ToUpper() == "TE")
            {
                string sql = "Select max(sothe) from thongtinbn where sothe like 'TE110KT%'";
                string sothe = HTC.Business.DataProvider.Instance().ExcSQLString(sql);
                if (sothe == "")
                    txtSoThe.Text = "TE110KT00000001";
                else
                    txtSoThe.Text = "TE110KT" + Addx(int.Parse(sothe.Substring(9)).ToString(), 8, "0");
            }
        if (txtSoThe.Text != "")
        {
            if (!((txtSoThe.Text.Length == 15 && HTC.ShareVariables.pub_spC != "YH") || ((txtSoThe.Text.Length == 15 || txtSoThe.Text.Length == 16) && HTC.ShareVariables.pub_spC == "YH")) && cboLoaiBA.SelectedValue != "00027")
            {
                ShowMessage("Số thẻ bảo hiểm phải có 15 ký tự!");
                return;
            }

            if (cboDKBD.Text == "" && HTC.ShareVariables.pub_sTenBVBHXH != "")
            {
                RadComboBoxItem selectedItem = new RadComboBoxItem();

                selectedItem.Text = HTC.ShareVariables.pub_sMaBHXH;
                selectedItem.Value = HTC.ShareVariables.pub_sMaBV;
                cboDKBD.Items.Add(selectedItem);
                selectedItem.Selected = true;
                selectedItem.DataBind();
                cboDKBD.DataBind();
                txtTenBVBD.Text = HTC.ShareVariables.pub_sTenBVBHXH;
            }

            if (cboDoiTuong.SelectedValue.Substring(cboDoiTuong.SelectedValue.Length - 1, 1) != "8")
            {
                //DMDoiTuongList _DMDoiTuongList = DMDoiTuongList.FindDMDoiTuongKyHieu(txtSoThe.Text.Substring(2, 1));

                //if (_NoiTT == "085")
                //{
                //    if (_DMDoiTuongList.Count > 0)
                //    {
                //        cboDoiTuong.SelectedValue = _DMDoiTuongList[0].MaDT;

                //    }
                //}
                //else
                //{
                //    if (_DMDoiTuongList.Count > 1)
                //    {

                //        cboDoiTuong.SelectedValue = _DMDoiTuongList[1].MaDT;


                //    }
                //    else if (_DMDoiTuongList.Count > 0)
                //    {
                //        cboDoiTuong.SelectedValue = _DMDoiTuongList[0].MaDT;

                //    }

                //}
                //DMTheBH _dmthebh = DMTheBH.GetDMTheBH(txtSoThe.Text.Substring(0, 2).ToUpper());

                //// DMDoiTuongList _DMDoiTuongList = DMDoiTuongList.FindDMDoiTuongKyHieu(txtSoThe.Text.Substring(2, 1));

                //if (_NoiTT == "085")
                //{
                //    if(txtSoThe.Text.Substring(0, 3).ToUpper()=="HT2")
                //        cboDoiTuong.SelectedValue = "10002";
                //    else
                //    cboDoiTuong.SelectedValue = _dmthebh.MaDT;
                //}
                //else
                //{
                //    if (txtSoThe.Text.Substring(0, 3).ToUpper() == "HT2")
                //        cboDoiTuong.SelectedValue = "11002";
                //    else
                //        cboDoiTuong.SelectedValue = "11" + _dmthebh.MaDT.Substring(2, 3);
                //}
                if (cboDoiTuong.SelectedValue.Substring(cboDoiTuong.SelectedValue.Length - 1, 1) != "8")
                {
                    if ((txtSoThe.Text.Substring(0, 3).ToUpper()) == "HN4" || txtSoThe.Text.Substring(0, 3).ToUpper() == "BT4" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "KC7" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "CB7" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "QN5" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "CA5" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "CY5")
                    {
                        if (_NoiTT == "085")
                            cboDoiTuong.SelectedValue = "10002";
                        else
                            cboDoiTuong.SelectedValue = "11002";

                    }
                    else if (txtSoThe.Text.Substring(0, 3).ToUpper() == "CN6" || txtSoThe.Text.Substring(0, 3).ToUpper() == "TC7")
                    {
                        if (_NoiTT == "085")
                            cboDoiTuong.SelectedValue = "10007";
                        else
                            cboDoiTuong.SelectedValue = "11007";

                    }

                    else
                    {
                        DMDoiTuongList _DMDoiTuongList = DMDoiTuongList.FindDMDoiTuongKyHieu(txtSoThe.Text.Substring(2, 1));
                        if (_DMDoiTuongList.Count > 0)
                        {
                            if (_NoiTT == "085")
                            {
                                cboDoiTuong.SelectedValue = _DMDoiTuongList[0].MaDT;
                            }
                            else if (_NoiTT == "087")
                            {
                                cboDoiTuong.SelectedValue = "11" + _DMDoiTuongList[0].MaDT.Substring(2);
                            }
                        }
                    }
                }
            }
            if (dtBHYTTN.Text == "")
            {
                dtBHYTTN.Text = "01/01/" + DateTime.Now.Year.ToString();
                dtBHYTDN.Text = "31/12/" + DateTime.Now.Year.ToString();

            }
            if (txtSoThe.Text != "" && txtMaBAGD.Text == "" && HTC.ShareVariables.pub_spC == "HU" && HTC.ShareVariables .pub_sTenBV != "BỆNH VIỆN TRUNG ƯƠNG HUẾ - CƠ SỞ 2")
            {
                BenhAn_ChuyenBN chuyen = BenhAn_ChuyenBN.GetBenhAn_ChuyenBN(txtSoThe.Text, 0);
                if (chuyen.MaBA != "")
                {
                    ShowMessage("Bệnh nhân này là bệnh nhân ghép bệnh án");
                    txtMaBAGD.Text = chuyen.MaBAQL;
                }
            }
            if (_BenhAnPKtmp != null && txtkieu.Value == "2")
            {


                //if (string.IsNullOrEmpty(_BenhAnPKtmp.NgayRaVien))
                //{
                //    _BenhAnPKtmp = null;
                //    txtkieu.Value = "";
                //    MsgBox("Bệnh án chưa ra viện, bạn lấy lại mã bệnh án này không? ");

                //}
                //else
                {
                    ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(_BenhAnPKtmp1.MaBN.ToString(), DateTime.Now, 3);

                    if (_ThongtinBNtemp.MaBN.Length > 0)
                    {
                        _ThongTinBN = _ThongtinBNtemp;
                        LoadThongTinBN();

                    }
                    else
                    {
                        ShowMessage("Không tìm thấy mã bệnh án bạn vừa nhập!");

                        return;
                    }
                }
            }
            else if (_BenhAnPKtmp1 != null && txtkieu.Value != "")
            {
                ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(_BenhAnPKtmp1.MaBN, DateTime.Now, _loai);

                if (_ThongtinBNtemp.MaBN.Length > 0)
                {
                    _ThongTinBN = _ThongtinBNtemp;
                    LoadThongTinBN();

                }
                else
                {
                    ShowMessage("Không tìm thấy mã bệnh án bạn vừa nhập!");

                    return;
                }
            }

            else if (_MaBA == "" && txthoten.Text == "")
            {
                BenhAnPKList _benhanpklist = BenhAnPKList.GetBenhAnPKList(txtSoThe.Text);
                if (_benhanpklist.Count > 0)
                {
                    _BenhAnPKtmp = _benhanpklist[_benhanpklist.Count - 1];
                    _BenhAnPKtmp1 = _benhanpklist[0];

                    if (_BenhAnPKtmp1.NgayRaVien == null)
                    {
                        ShowMessage("Bệnh nhân này chưa ra viện");
                        txtmaql.Text = "";
                        return;

                    }

                    ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(txtSoThe.Text, 1);

                    if (!string.IsNullOrEmpty(_ThongtinBNtemp.MaBN))
                    {
                        _ThongTinBN = _ThongtinBNtemp;
                        LoadThongTinBN();
                    }
                }
                else
                {

                    ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(txtSoThe.Text, 1);

                    if (!string.IsNullOrEmpty(_ThongtinBNtemp.MaBN))
                    {
                        _ThongTinBN = _ThongtinBNtemp;
                        LoadThongTinBN();
                    }
                }
            }
        }
        if (txtSoThe.Text == "")
        {
            dtBHYTDN.Enabled = false;
            dtBHYTTN.Enabled = false;
            cboDKBD.Enabled = false;
            txtTenBVBD.Enabled = false;
            cboDKGT.Enabled = false;
            txtTenBVGT.Enabled = false;
            cboLoaiBA.Focus();
        }
        else
        {
            dtBHYTDN.Enabled = true;
            dtBHYTTN.Enabled = true;
            cboDKBD.Enabled = true;
            txtTenBVBD.Enabled = false;
            cboDKGT.Enabled = false;
            txtTenBVGT.Enabled = false;
            if (cboDoiTuong.SelectedValue.Substring(cboDoiTuong.SelectedValue.Length - 1, 1) != "8")
            {
                cboDKGT.Enabled = true;
                txtTenBVGT.Enabled = true;
            }
            dtBHYTTN.Focus();
        }
    }

    protected void txtmaql_TextChanged(object sender, EventArgs e)
    {
        if (txtmaql.Text != "" && _loaikq =="0"   && HTC.ShareVariables.pub_spC =="QN")
        {
            BenhAnPKList _benhanpklist = BenhAnPKList.GetBenhAnPKList(txtmaql.Text);
            if (_benhanpklist.Count > 0)
            {
                _BenhAnPKtmp = _benhanpklist[_benhanpklist.Count - 1];
                _BenhAnPKtmp1 = _benhanpklist[0];

                if (DateDiff(DateInterval.Year,DateTime.Parse (_BenhAnPKtmp1.NgayGioVV),DateTime .Now) ==0)
                {
                    ShowMessage("Bệnh nhân này đã tồn tại");
                    txtmaql.Text = "";
                    return;

                }

              
            }
           
        }
        else if (_BenhAnPKtmp != null && txtkieu.Value == "2")
        {


            //if (string.IsNullOrEmpty(_BenhAnPKtmp.NgayRaVien))
            //{
            //    _BenhAnPKtmp = null;
            //    txtkieu.Value = "";
            //    MsgBox("Bệnh án chưa ra viện, bạn lấy lại mã bệnh án này không? ");

            //}
            //else
            {
                ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(_BenhAnPKtmp1.MaBN.ToString(), DateTime.Now, 3);

                if (_ThongtinBNtemp.MaBN.Length > 0)
                {
                    _ThongTinBN = _ThongtinBNtemp;
                    if ((_ThongTinBN.Sothe.Substring(0, 3).ToUpper()) == "HN4" || _ThongTinBN.Sothe.Substring(0, 3).ToUpper() == "BT4" || (_ThongTinBN.Sothe.Substring(0, 3).ToUpper()) == "KC7" || (_ThongTinBN.Sothe.Substring(0, 3).ToUpper()) == "CB7" || (_ThongTinBN.Sothe.Substring(0, 3).ToUpper()) == "QN5" || (_ThongTinBN.Sothe.Substring(0, 3).ToUpper()) == "CA5" || (_ThongTinBN.Sothe.Substring(0, 3).ToUpper()) == "CY5")
                    {
                        if (_NoiTT == "085")
                            cboDoiTuong.SelectedValue = "10002";
                        else
                            cboDoiTuong.SelectedValue = "11002";
                        DMDoiTuong _dmdoituong = DMDoiTuong.GetDMDoiTuong(cboDoiTuong.SelectedValue);
                        
                        _ThongTinBN.MaDT = cboDoiTuong.SelectedValue;
                       
                    }
                    else if (_ThongTinBN.Sothe.Substring(0, 3).ToUpper() == "CN6" || _ThongTinBN.Sothe.Substring(0, 3).ToUpper() == "TC7")
                    {
                        if (_NoiTT == "085")
                            cboDoiTuong.SelectedValue = "10007";
                        else
                            cboDoiTuong.SelectedValue = "11007";
                        DMDoiTuong _dmdoituong = DMDoiTuong.GetDMDoiTuong(cboDoiTuong.SelectedValue);

                        _ThongTinBN.MaDT = cboDoiTuong.SelectedValue;
                       
                    }

                    else
                    {
                        DMDoiTuongList _DMDoiTuongList = DMDoiTuongList.FindDMDoiTuongKyHieu(_ThongTinBN.Sothe.Substring(2, 1));
                        if (_DMDoiTuongList.Count > 0)
                        {
                            if (_NoiTT == "085")
                            {
                                cboDoiTuong.SelectedValue = _DMDoiTuongList[0].MaDT;
                            }
                            else if (_NoiTT == "087")
                            {
                                cboDoiTuong.SelectedValue = "11" + _DMDoiTuongList[0].MaDT.Substring(2);
                            }

                            _ThongTinBN.MaDT = cboDoiTuong.SelectedValue;
                           
                        }
                    }
                    LoadThongTinBN();

                }
                else
                {
                    ShowMessage("Không tìm thấy mã bệnh án bạn vừa nhập!");

                    return;
                }
            }
        }
        else if (_BenhAnPKtmp1 != null && txtkieu.Value != "")
        {
            ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(_BenhAnPKtmp1.MaBN, DateTime.Now, _loai);

            if (_ThongtinBNtemp.MaBN.Length > 0)
            {
                _ThongTinBN = _ThongtinBNtemp;
                LoadThongTinBN();

            }
            else
            {
                ShowMessage("Không tìm thấy mã bệnh án bạn vừa nhập!");

                return;
            }
        }

        else if (txtmaql.Text != "" && _MaBA == "" && txthoten.Text == "")
        {
            BenhAnPKList _benhanpklist = BenhAnPKList.GetBenhAnPKList(txtmaql.Text);
            if (_benhanpklist.Count > 0)
            {
                _BenhAnPKtmp = _benhanpklist[_benhanpklist.Count - 1];
                _BenhAnPKtmp1 = _benhanpklist[0];

                if (_BenhAnPKtmp1.NgayRaVien == null)
                {
                    ShowMessage("Bệnh nhân này chưa ra viện");
                    txtmaql.Text = "";
                    return;

                }

                ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(txtmaql.Text, 1);

                if (!string.IsNullOrEmpty(_ThongtinBNtemp.MaBN))
                {
                    _ThongTinBN = _ThongtinBNtemp;
                    LoadThongTinBN();
                }
            }
            else
            {

                ThongtinBN _ThongtinBNtemp = ThongtinBN.GetThongtinBN(txtmaql.Text, 1);

                if (!string.IsNullOrEmpty(_ThongtinBNtemp.MaBN))
                {
                    _ThongTinBN = _ThongtinBNtemp;
                    LoadThongTinBN();
                }
            }
        }

    }
    protected void odshuyen_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        if (cbotinh.SelectedValue == null)
        {
            e.Cancel = false;
            e.InputParameters["matinh"] = "";
        }
        else
            e.InputParameters["matinh"] = cbotinh.SelectedValue;
    }


    protected void cbotinh_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {

        cbohuyen.DataBind();
        cbohuyen.Focus();

    }
    private void UploadFile()
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
            fileSavePath = ThamSo.GetThamSo().thumucluuanh + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\PK";
            //if (!Directory.Exists(fileSavePath))
            //    Directory.CreateDirectory(fileSavePath);
            if (!Directory.Exists(fileSavePath))
                Directory.CreateDirectory(fileSavePath);
            //after checking or creating folder it's time to save the file
            //fileSavePath = fileSavePath + "//" + fileName;
            fileSavePath = fileSavePath + "\\" + _ThongTinBN.MaBN + fileName;
            fuFileUploader.PostedFile.SaveAs(fileSavePath);
            // ShowMessage(fileSavePath);
            HTC.Business.NoiTru.BenhAn_File file = HTC.Business.NoiTru.BenhAn_File.NewBenhAn_File();
            // file.DangFile = fileName.LastIndexOf(".doc")>0 ?"word":(fileName.LastIndexOf(".xls")>0?"excel"));
            file.DuongDan = fileName;
            file.DuongDanDD = fileSavePath;
            file.MaBA = _ThongTinBN.MaBN;
            file.STT = 0;
            file.STTKhoa = 0;
            file.MaBN = _ThongTinBN.MaBN;
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
    protected void cbohuyen_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        try
        {

            if (cbohuyen.AutoPostBack == true && HTC.ShareVariables.pub_spC == "HU")
            {
                cboPXa.DataBind();
                cboPXa.Focus();
            }
            else
                txtDiaChi.Focus();
        }
        catch (Exception ex)
        {
            ShowMessage("Không hiển thị được dữ liệu" + ex.Message);

            //throw;
        }
    }
    protected void odspxa_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        if (cbohuyen.SelectedValue == null)
        {
            e.Cancel = false;
            e.InputParameters["maqh"] = "";
        }
        else
            e.InputParameters["maqh"] = cbohuyen.SelectedValue;
    }
    protected void odsKhoa_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        if (HTC.ShareVariables.pub_spC == "HU")
            e.InputParameters["account"] = Pub_sAccount;
        else
            e.InputParameters["account"] = "";
    }
    private Boolean SearchData()
    {
        try
        {
            lanbaobn = ++lanbaobn;
            string dk = "";
            if (dtNgaySinh.Text != "")
            {
                dk = dk + " and year(a.ngaysinh)=" + dtNgaySinh.Text.Substring(6, 4);
            }
            if (cboPXa.Text != "")
            {
                dk = dk + " and a.mapxa='" + cboPXa .SelectedValue +"'";
            }
            ThongtinBNList _ThongTinBNList;
            if (HTC.ShareVariables .pub_spC =="HU")
                _ThongTinBNList = ThongtinBNList.FindThongtinBN(0, txtmaql.Text, txthoten.Text, true,"", "", DateTime.Parse("01/01/1900"), "", "", "", "", "", 0, DateTime.Parse("01/01/1900"), optGT.Items[0].Selected, "", cboquocgia.SelectedValue, cbotinh.SelectedValue, cbohuyen.SelectedValue, "", "", "", "", "", DateTime.Parse("01/01/1900"), DateTime.Parse("01/01/1900"), dk, DateTime.Parse("01/01/1900"), false, (dtNgaySinh.Text != "" ? true : false));
            else
                _ThongTinBNList  = ThongtinBNList.FindThongtinBN(0, txtmaql.Text, txthoten.Text, true, txtSoThe.Text, cboDKBD.SelectedValue, DateTime.Parse(dtBHYTDN.Text == "" ? "01/01/1900" : dtBHYTDN.Text), txtDiaChi.Text, txtdienthoai.Text, "", "", "", 0, DateTime.Parse("01/01/1900"), optGT.Items[0].Selected, "", cboquocgia.SelectedValue, cbotinh.SelectedValue, cbohuyen.SelectedValue, "", "", "", "", "", DateTime.Parse("01/01/1900"), DateTime.Parse("01/01/1900"), dk, DateTime.Parse("01/01/1900"), false, (dtNgaySinh.Text != "" ? true : false));
            if (_ThongTinBNList.Count > 0)
            {
                if (txtmaql.Text != _ThongTinBNList[0].MaBN)
                {
                    if (_ThongTinBNList[0].NgayVV != "")
                    {
                        if (DateTime.Parse(_ThongTinBNList[0].NgayVV).AddDays(1) >= DateTime.Now.AddHours(0 - DateTime.Now.Day) && HTC.ShareVariables .pub_spC !="HU" )
                        {
                            ShowMessage("Bệnh nhân này đã khám trong 2 gần đây.Đề nghị kiểm tra lại bệnh nhân ở phòng khám hoặc trạng thái CHƯA ĐĂNG KÝ/ NẰM TRONG VIỆN ! Mã BN là " + _ThongTinBNList[0].MaBN);
                            return false;
                        }
                        else
                            if (DateTime.Parse(_ThongTinBNList[0].NgayVV).AddDays(4) >= DateTime.Now.AddHours(0 - DateTime.Now.Day) && HTC.ShareVariables.pub_spC == "HU")
                            {
                                ShowMessage("Bệnh nhân này đã khám trong 5 gần đây.Đề nghị kiểm tra lại bệnh nhân ở phòng khám hoặc trạng thái CHƯA ĐĂNG KÝ/ NẰM TRONG VIỆN ! Mã BN là " + _ThongTinBNList[0].MaBN);
                                return false;
                            }
                    }

                    else if (txtmaql.Text != _ThongTinBNList[0].MaBN)
                    {

                        ShowMessage("Đã tồn tại bệnh nhân này trong dữ liệu! Mã BN là " + _ThongTinBNList[0].MaBN);
                        return false;
                    }
                }
                
            }
            if (_ThongTinBNList.Count > 1)
            {
                if (_ThongTinBNList[0].NgayVV != "")
                {
                    if (DateTime.Parse(_ThongTinBNList[1].NgayVV).AddDays(1) >= DateTime.Now.AddHours(0 - DateTime.Now.Day))
                    {
                        ShowMessage("Bệnh nhân này đã khám trong 2 gần đây.Đề nghị kiểm tra lại bệnh nhân ở phòng khám hoặc trạng thái CHƯA ĐĂNG KÝ/ NẰM TRONG VIỆN ! Mã BN là " + _ThongTinBNList[1].MaBN);
                        return false;
                    }
                }

                else if (txtmaql.Text != _ThongTinBNList[1].MaBN)
                {

                    ShowMessage("Đã tồn tại bệnh nhân này trong dữ liệu! Mã BN là " + _ThongTinBNList[1].MaBN);
                    return false;
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            ShowMessage("Không thể kiểm tra được dữ liệu" + ex.Message);
            return true;
        }
    }
    protected void txtQRCode_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (txtQRCode.Text != "")
            {
                txtSoThe.Text = txtQRCode.Text.Substring(0, 15).ToUpper();
              
                string charkt = txtQRCode.Text.Substring(15, 1);
                if (cboDoiTuong.SelectedValue.Substring(cboDoiTuong.SelectedValue.Length - 1, 1) != "8")
                {
                    if ((txtSoThe.Text.Substring(0, 3).ToUpper()) == "HN4" || txtSoThe.Text.Substring(0, 3).ToUpper() == "BT4" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "KC7" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "CB7" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "QN5" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "CA5" || (txtSoThe.Text.Substring(0, 3).ToUpper()) == "CY5")
                    {
                        if (_NoiTT == "085")
                            cboDoiTuong.SelectedValue = "10002";
                        else
                            cboDoiTuong.SelectedValue = "11002";

                    }
                    else if (txtSoThe.Text.Substring(0, 3).ToUpper() == "CN6" || txtSoThe.Text.Substring(0, 3).ToUpper() == "TC7")
                    {
                        if (_NoiTT == "085")
                            cboDoiTuong.SelectedValue = "10007";
                        else
                            cboDoiTuong.SelectedValue = "11007";

                    }

                    else
                    {
                        DMDoiTuongList _DMDoiTuongList = DMDoiTuongList.FindDMDoiTuongKyHieu(txtSoThe.Text.Substring(2, 1));
                        if (_DMDoiTuongList.Count > 0)
                        {
                            if (_NoiTT == "085")
                            {
                                cboDoiTuong.SelectedValue = _DMDoiTuongList[0].MaDT;
                            }
                            else if (_NoiTT == "087")
                            {
                                cboDoiTuong.SelectedValue = "11" + _DMDoiTuongList[0].MaDT.Substring(2);
                            }
                        }
                    }
                }
                string chuoi = txtQRCode.Text.Substring(16);
                string kt = chuoi.Substring(0, chuoi.IndexOf(charkt));
                txthoten.Text = ConvertHexStrToUnicode(kt.Trim());
                chuoi = chuoi.Replace(kt + charkt, "");
                dtNgaySinh.Text = chuoi.Substring(0, 10);
                txttuoi.Text = DateDiff(DateInterval.Year, DateTime.Parse(dtNgaySinh.Text), DateTime.Now).ToString();
                //chuoi = chuoi.Replace(dtNgaySinh.Text + charkt, "");
                chuoi = chuoi.Substring(11);
                DMTinh TI = DMTinh.GetDMTinh(txtQRCode.Text.Substring(3, 2));
                if (TI.MaTinh != "" &&    (HTC.ShareVariables .pub_spC !="PS") )
                {
                    cbotinh.SelectedValue = TI.MaTinh;
                    cbotinh.Text = TI.TenTinh;
                    cbohuyen.DataBind();
                }
                if (chuoi.Substring(0, 1) == "1")
                {
                    optGT.Items[0].Selected = true;
                    optGT.Items[1].Selected = false;
                    cboGioiTinh.Items[0].Selected = true;

                }
                else
                {
                    optGT.Items[1].Selected = true;
                    optGT.Items[0].Selected = false;
                    cboGioiTinh.Items[1].Selected = true;

                }
                chuoi = chuoi.Substring(2);
                kt = chuoi.Substring(0, chuoi.IndexOf(charkt));
                if (HTC.ShareVariables.pub_spC != "PS") 
                txtDiaChi.Text = ConvertHexStrToUnicode(kt.Trim());
                chuoi = chuoi.Replace(kt + charkt, "");
                kt = chuoi.Substring(0, chuoi.IndexOf(charkt));
                chuoi = chuoi.Replace(kt + charkt, "");
                kt = kt.Replace(" - ", "");
                kt = kt.Replace("-", "");
                kt = kt.Replace(" ", "");
                kt = kt.Replace(" – ", "");
                kt = kt.Replace("–", "");
                kt = kt.Replace(" ", "");
                

                cboDKBD.Text = kt;
                DMBenhVienList _DMBenhVienl = DMBenhVienList.FindDMBenhVienByMa(cboDKBD.Text);
                if (_DMBenhVienl.Count > 0)
                {
                    cboDKBD.SelectedValue = _DMBenhVienl[0].MaBV;
                    txtTenBVBD.Text = _DMBenhVienl[0].TenBV;
                    cboDKBD.Text = _DMBenhVienl[0].MaBHXH;
                    cbodantoc.Focus();
                }
                else
                {
                    ShowMessage("Không có mã bệnh viện này ");
                    return;
                }

                dtBHYTTN.Text = chuoi.Substring(0, 10);
                chuoi = chuoi.Substring(11);
                if (chuoi.Substring(0, 2) == "-|")
                {
                    chuoi = chuoi.Substring(3);
                    dtBHYTDN.Text = DateTime.Parse(dtBHYTTN.Text).AddYears (1).AddDays (-1).ToString ("dd/MM/yyyy");
                }
                else
                {
                    dtBHYTDN.Text = chuoi.Substring(0, 10);
                    chuoi = chuoi.Substring(11);
                }
                try
                {
                    chuoi = chuoi.Substring(chuoi.IndexOf("|") + 1);
                    chuoi = chuoi.Substring(chuoi.IndexOf("|") + 1);
                    chuoi = chuoi.Substring(chuoi.IndexOf("|") + 1);

                    if (int.Parse(chuoi.Substring(0, 1)) - 4 > 0)
                        cboKhuVuc.SelectedValue = "K" + (int.Parse(chuoi.Substring(0, 1)) - 4).ToString();
                }
                catch (Exception ex)
                {
                    try
                    {
                        chuoi = chuoi.Substring(chuoi.IndexOf("|") + 1);
                        chuoi = chuoi.Substring(chuoi.IndexOf("|") + 1);
                        chuoi = chuoi.Substring(chuoi.IndexOf("|") + 1);
                       
                        if (int.Parse(chuoi.Substring(0, 1)) - 4 > 0)
                            cboKhuVuc.SelectedValue = "K" + (int.Parse(chuoi.Substring(0, 1)) - 4).ToString();
                    }
                    catch (Exception ex1)
                    {
                       
                    }
                }
            }
        
            if (txtSoThe.Text != "")
                CheckThe();
            cboDKGT.Enabled = true;
            string chuoidc = txtDiaChi.Text;
           
            if (txtDiaChi.Text.LastIndexOf(", ") > 1 && (HTC.ShareVariables.pub_spC != "QN" || (HTC.ShareVariables.pub_spC == "QN" && HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN Y DƯỢC CỔ TRUYỀN")))
            {
                int i = chuoidc.LastIndexOf(", ");
                chuoidc = chuoidc.Substring(0, i);
                txtDiaChi.Text = chuoidc;
                if (chuoidc.LastIndexOf(", ") > 1)
                {
                    i = chuoidc.LastIndexOf(", ");
                    txtDiaChi.Text = chuoidc.Substring(0, i);
                    chuoidc = chuoidc.Substring(i + 1).Trim();
                    DMQuanHuyen qh = DMQuanHuyen.GetDMQuanHuyen(cbotinh.SelectedValue + chuoidc);
                    if (qh.TenQH != "")
                    {
                        cbohuyen.Text = qh.TenQH;
                        cbohuyen.SelectedValue = qh.MaQH;

                        if (HTC.ShareVariables.pub_spC == "HU")
                        {
                            cboPXa.DataBind();
                            cboPXa.Focus();
                        }
                        else
                        {
                            cboNgheNghiep.Focus();
                        }
                    }
                }
            }
            else   if (txtDiaChi.Text.LastIndexOf(", Tỉnh") > 1)
            {
               
                int i = chuoidc.LastIndexOf(", Tỉnh"); 
                chuoidc = chuoidc.Substring(0, i);
                txtDiaChi.Text = chuoidc;
                

                if (chuoidc.LastIndexOf(", Huyện") >1 )
                {
                       i = chuoidc.LastIndexOf(", Huyện");
                      
                    txtDiaChi.Text = txtDiaChi.Text.Substring(0, i);
                    chuoidc = chuoidc.Substring(i + 1).Trim();
                    i = txtDiaChi.Text.LastIndexOf(" Xã ");
                    if (i <= 0)
                        i = txtDiaChi.Text.LastIndexOf("Thị trấn");
                   
                    txtDiaChi.Text = txtDiaChi.Text.Substring(0, i).Trim();
                    if (txtDiaChi.Text.Substring (txtDiaChi.Text.Length -1)==",")
                        txtDiaChi.Text = txtDiaChi.Text.Substring(0, txtDiaChi.Text.Length-1).Trim();
                    DMQuanHuyen qh = DMQuanHuyen.GetDMQuanHuyen(cbotinh.SelectedValue + chuoidc);
                    if (qh.TenQH != "")
                    {
                        cbohuyen.Text = qh.TenQH;
                        cbohuyen.SelectedValue = qh.MaQH;
                        
                        if (HTC.ShareVariables.pub_spC == "QN")
                        {
                            cboPXa.DataBind();
                            cboPXa.Focus();
                        }
                        else
                        {
                            txtBaoTin.Focus();
                        }
                    }
                }
            }
            else 
                  {
                      ShowMessage(txtDiaChi.Text);
                  }
            if (HTC.ShareVariables.pub_spC == "HU")
            {
                if (txtDiaChi.Text.IndexOf(", ") > 0)
                {
                    int i = txtDiaChi.Text.IndexOf(", ");
                    txtDiaChi.Text = txtDiaChi.Text.Substring(0, i);
                }
            }
            txtQRCode.Text = "";
          
        }
        catch (Exception ex)
        {
            ShowMessage("Không thực hiện được " + ex.Message);

            //throw;
        }
    }
    private string ConvertHexStrToUnicode(string hexString)
    {
        try
            {
        int length = hexString.Length;
        byte[] bytes = new byte[length / 2];
        for (int i = 0; i < length; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
        }
        return Encoding.UTF8.GetString(bytes);
            }
        catch (Exception ex)
        {
            return "";

            //throw;
        }
    }


    private static string ConnectString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        }
    }


    public static List<DMlydovaovienM> GetDMlydovaovienM()
    {
        List<DMlydovaovienM> List = new List<DMlydovaovienM>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMLYDOVAOVIEN_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMlydovaovienM(dr, i));
            }
        }
        return List;
    }


    public class DMlydovaovienM
    {
        private String _maVV = String.Empty;
        private String _lydoVV = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _maBHXH = String.Empty;
        private int _OrderNumber;

        public String MaVV
        {
            get
            {
                return _maVV;
            }
            set
            {
                if (_maVV != value)
                {
                    _maVV = value;
                }
            }
        }
        public String LydoVV
        {
            get
            {
                return _lydoVV;
            }
            set
            {
                if (_lydoVV != value)
                {
                    _lydoVV = value;
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
        public String MaBHXH
        {
            get
            {
                return _maBHXH;
            }
            set
            {
                if (_maBHXH != value)
                {
                    _maBHXH = value;
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

        public DMlydovaovienM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaVV"].GetType().Name != "DBNull" && dr["MaVV"] != null)
            {
                this.MaVV = Convert.ToString(dr["MaVV"]);
            }
            else
            {
                this.MaVV = "";
            }
            if (dr["LydoVV"].GetType().Name != "DBNull" && dr["LydoVV"] != null)
            {
                this.LydoVV = Convert.ToString(dr["LydoVV"]);
            }
            else
            {
                this.LydoVV = "";
            }
            if (dr["MaBHXH"].GetType().Name != "DBNull" && dr["MaBHXH"] != null)
            {
                this.MaBHXH = Convert.ToString(dr["MaBHXH"]);
            }
            else
            {
                this.MaBHXH = "";
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


    public static List<DMdoituongkhambenhM> GetDMdoituongkhambenhM()
    {
        List<DMdoituongkhambenhM> List = new List<DMdoituongkhambenhM>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDOITUONGKHAMBENH_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMdoituongkhambenhM(dr, i));
            }
        }
        return List;
    }

    public class DMdoituongkhambenhM
    {
        private String _maKB = String.Empty;
        private String _tenBN = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _maBHXH = String.Empty;
        private int _OrderNumber;

        public String MaKB
        {
            get
            {
                return _maKB;
            }
            set
            {
                if (_maKB != value)
                {
                    _maKB = value;
                }
            }
        }
        public String TenBN
        {
            get
            {
                return _tenBN;
            }
            set
            {
                if (_tenBN != value)
                {
                    _tenBN = value;
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
        public String MaBHXH
        {
            get
            {
                return _maBHXH;
            }
            set
            {
                if (_maBHXH != value)
                {
                    _maBHXH = value;
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

        public DMdoituongkhambenhM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaKB"].GetType().Name != "DBNull" && dr["MaKB"] != null)
            {
                this.MaKB = Convert.ToString(dr["MaKB"]);
            }
            else
            {
                this.MaKB = "";
            }
            if (dr["TenBN"].GetType().Name != "DBNull" && dr["TenBN"] != null)
            {
                this.TenBN = Convert.ToString(dr["TenBN"]);
            }
            else
            {
                this.TenBN = "";
            }
            if (dr["MaBHXH"].GetType().Name != "DBNull" && dr["MaBHXH"] != null)
            {
                this.MaBHXH = Convert.ToString(dr["MaBHXH"]);
            }
            else
            {
                this.MaBHXH = "";
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

    public DataTable spDMUpdateVV_KB(string mabn) 
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMUpdateVV_KB";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@mabn", mabn));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }

}