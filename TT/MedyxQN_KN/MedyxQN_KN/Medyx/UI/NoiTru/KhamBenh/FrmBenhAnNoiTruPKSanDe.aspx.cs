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
using System.Data.SqlClient;
using Csla.Data;
using HTC.Business;
using Csla.Validation;
using Csla;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Microsoft.ApplicationBlocks.Data;
using System.IO;
using System.Globalization;
//using static HisBHYT;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;
using Resources.RadGrid;
using Microsoft.Office.Interop.Word;


//using static UI_NoiTru_KhamBenh_FrmBenhAnNoiTruPKSanDe;
//using static UI_NoiTru_KhamBenh_FrmBenhAnNoiTruPKSanDe;
//using System.Globalization.CultureInfo.CurrentCulture;




public partial class UI_NoiTru_KhamBenh_FrmBenhAnNoiTruPKSanDe : WebBase
{

    private const string ViewState_BenhAnPK = "BenhAnPK";
    private const string viewState_BenhAn_Khoa = "BenhAn_Khoa";
    private const string viewState_CurrentAction = "CurrentAction";
    private const string ViewState_MaBN = "MaBN";
    private const string ViewState_MaBA = "MaBA";
    private const string ViewState_maSoKham = "_maSoKham";
    private const string ViewState_STTKhoa = "STTKhoa";
    //private const string ViewState_LoaiKQ = "LoaiKQ";
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
    public byte _loaicn
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
            if (ViewState[ViewState_STT] == null)
                ViewState[ViewState_STT] = 0;
            return (int)ViewState[ViewState_STT];
        }

        set
        {
            ViewState[ViewState_STT] = value;
        }

    }
    

    public BenhAn_Khoa _BenhAn_Khoa
    {
        get
        {
            if (ViewState[viewState_BenhAn_Khoa] == null)
            {
                return null;
            }

            return (BenhAn_Khoa)ViewState[viewState_BenhAn_Khoa];
        }

        set
        {
            ViewState[viewState_BenhAn_Khoa] = value;
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
    public ThongtinBN1 _ThongTinBN
    {
        get
        {
            if (ViewState[ViewState_ThongTinBN] == null)
            {
                return null;
            }

            return (ThongtinBN1)ViewState[ViewState_ThongTinBN];
        }

        set
        {
            ViewState[ViewState_ThongTinBN] = value;
        }
    }

    private const string ViewState_BenhNhan = "BenhNhan";
    private const string ViewState_BenhAn = "BenhAn";
    public BenhNhan1 _benhnhan
    {
        get
        {
            if (ViewState[ViewState_BenhNhan] == null)
            {
                return null;
            }

            return (BenhNhan1)ViewState[ViewState_BenhNhan];
        }

        set
        {
            ViewState[ViewState_BenhNhan] = value;
        }
    }


    public BenhAn _benhan
    {
        get
        {
            if (ViewState[ViewState_BenhAn] == null)
            {
                return null;
            }

            return (BenhAn)ViewState[ViewState_BenhAn];
        }

        set
        {
            ViewState[ViewState_BenhAn] = value;
        }
    }



    private const string ViewState_action = "_action";

    public FormAction _action
    {
        get
        {

            if (ViewState[ViewState_action] != null)
            {
                return (FormAction)ViewState[ViewState_action];
            }

            return FormAction.EDIT;
        }

        set
        {
            ViewState[ViewState_action] = value;
        }
    }
    private const string ViewState_BenhAnSoSinh = "BenhAn_SoSinh";
    public BenhAn_SoSinh2 _BenhAnSoSinh
    {
        get
        {
            if (ViewState[ViewState_BenhAnSoSinh] == null)
            {
                return null;
            }

            return (BenhAn_SoSinh2)ViewState[ViewState_BenhAnSoSinh];
        }

        set
        {
            ViewState[ViewState_BenhAnSoSinh] = value;
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
            if (String.IsNullOrEmpty(Request["maBA"]) || String.IsNullOrEmpty(Request["NoiTT"]))
            {
                // Response.Redirect("~/UI/NoiTru/KhamBenh/FrmBenhAnNoiTruPKSanDeDS.aspx?loai="+_loai +"&loaicn="+_loaicn );
                CloseWindow();
            }
            else
            {
                _MaBA = Request["maBA"];
                _MaBN = Request["maBn"];


                if (!String.IsNullOrEmpty(Request["STT"]))
                {
                    _STT = Byte.Parse(Request["STT"]);
                    _CurrentAction = FormAction.EDIT;
                }
                else
                    _CurrentAction = FormAction.INSERT;


                SetData();
                LoadData();                
                LoadDetails();

            }
        }
        else
        {
            if (_CurrentAction == FormAction.EDIT)
            {

            }
        }
    }

    protected void LoadData()
    {
        
        cbonhanvien.DataSource = GetDMNhanVienM();// combo 
        cbonhanvien.DataBind();

        DataTable dt = spDMBASS_Update(_MaBA);
        if (dt != null && dt.Rows.Count > 0)
        {
            string CanNang = dt.Rows[0][0].ToString();
            string TuoiThai = dt.Rows[0][1].ToString();
            byte CachDe = Convert.ToByte(dt.Rows[0][2]);
            byte LanSinh = Convert.ToByte(dt.Rows[0][3]);
            byte Soconsong = Convert.ToByte(dt.Rows[0][4]);
            string Noisinh = dt.Rows[0][5].ToString();
            string Tinhtrangcon = dt.Rows[0][6].ToString();
            string MaNV = dt.Rows[0][7].ToString();
            string HoTen = dt.Rows[0][8].ToString();

           

            cbonhanvien.SelectedValue = MaNV;
            cbonhanvien.Text = HoTen;

            txtcannang.Text = CanNang;
            txttuoithai.Text = TuoiThai;




           


            if (CachDe == 1)
            {
                chkdethuong.Checked = true;
                chkFoocxep.Checked = false;
                chkGiacHut.Checked = false;
                chkmolaythai.Checked = false;
                chkdechihuy.Checked = false;
            }
            else if (CachDe == 2)
            {
                chkdethuong.Checked = false;
                chkFoocxep.Checked = true;
                chkGiacHut.Checked = false;
                chkmolaythai.Checked = false;
                chkdechihuy.Checked = false;
            }
            else if (CachDe == 3)
            {
                chkdethuong.Checked = false;
                chkFoocxep.Checked = false;
                chkGiacHut.Checked = true;
                chkmolaythai.Checked = false;
                chkdechihuy.Checked = false;
            }
            else if (CachDe == 4)
            {
                chkdethuong.Checked = false;
                chkFoocxep.Checked = false;
                chkGiacHut.Checked = false;
                chkmolaythai.Checked = true;
                chkdechihuy.Checked = false;
            }
            else if (CachDe == 5)
            {
                chkdethuong.Checked = false;
                chkFoocxep.Checked = false;
                chkGiacHut.Checked = false;
                chkmolaythai.Checked = false;
                chkdechihuy.Checked = true;
            }


            txtLansinh.Text = LanSinh.ToString();
            txtSoconsong.Text = Soconsong.ToString();
            txtNoisinh.Text = Noisinh;
            txtTinhtrangcon.Text = Tinhtrangcon;

        

        }

        DataTable dt1 = spDMBN_Get(_MaBN);
        if (dt1 != null && dt1.Rows.Count > 0)
        {
            string Hotencha = dt1.Rows[0][0].ToString();
            string MaBHXHCha = dt1.Rows[0][1].ToString();
            txthotencha.Text = Hotencha.ToString();
            txtMaBHXHCha.Text = MaBHXHCha.ToString();
        }

    }

    private void SetData()
    {

        

        if (HTC.ShareVariables.pub_spC == "HU")
        {
            cbohuyen.AutoPostBack = true;
            xa.ColSpan = 2;
            diachi.ColSpan = 2;
        }
        else
        {
            lblxa.Visible = false;
            lblxa.Disabled = false;
            xa.Visible = false;
            xa.Disabled = false;
        }
        //    // Bind the data
        if (_MaBA != "")
        {
            if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fThem)
                baraction.FindItemByValue("cmdSave").Enabled = false;
            if (Pub_bQuyenForm != HTC.ShareVariables.KieuFormChiTiet.fDelete)
            {

                baraction.FindItemByValue("cmdSave").Enabled = false;
            }
        }
        if (cboDoiTuong.Items.Count == 0)
        {
            cboDoiTuong.DataSourceID = "odsDoiTuong";
            cboDoiTuong.DataBind();
            cboNgheNghiep.DataSourceID = "odsNgheNghiep";
            cboNgheNghiep.DataBind();
        }
        LoadData();
    }
    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        if (((RadToolBarButton)e.Item).CommandName.Equals("cmdSave", StringComparison.InvariantCultureIgnoreCase))
        {
            UpdateData();
            CloseWindow();
            
             //Response.Redirect("~/UI/NoiTru/KhamBenh/FrmBenhAnNoiTruPKSanDeDS.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&makhoa=" + _BenhAn_Khoa.MaKhoa, false);
        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdExit", StringComparison.InvariantCultureIgnoreCase))
        {
            // Response.Redirect("~/UI/NoiTru/KhamBenh/FrmBenhAnNoiTruPKSanDeDS.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&makhoa=" + cboKhoaNV.SelectedValue , false);
        }

    }

    //protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    //{
    //    switch (e.Item.Value)
    //    {
    //        case "cmdSave":
    //            UpdateData();

    //            break;



    //        case "cmdExit":
    //            Response.Redirect("~/Default.aspx");
    //            break;



    //        //default:
    //        //    break;

    //    }

    //}









    protected void LoadDetails()
    {

        BenhAn _benhan = BenhAn.GetBenhAn(_MaBA, "", byte.Parse(_loaikq));

        BenhNhan1 _benhnhan = BenhNhan1.GetBenhNhan(_MaBN); 
        if (_loaikq == "1")
        {
            txthoten.Text = _benhnhan.Hoten;            
            txthotenBM.Text = _benhnhan.HoTenBoMe;

            dtNgaySinh.Enabled = false;
            cboKhoaNV.Enabled = false;
            dtNgayVV.Enabled = false;
            
        }
        else
        {
            txthotenBM.Text = _benhnhan.Hoten;
        }
        if (_benhnhan.GT == true)
        {
            optGT.Items[0].Selected = true;
            optGT.Items[1].Selected = false;
        }
        else
        {
            optGT.Items[1].Selected = true;
            optGT.Items[0].Selected = false;
        }
        dtNgaySinh.Text = _benhnhan.NgaySinh;
        if (HTC.ShareVariables.pub_spC == "HU")
        {
            if (_NoiTT == "085")
                cboDoiTuong.SelectedValue = "00001";
            else
                cboDoiTuong.SelectedValue = "00002";
        }
        else
        {
            if (_NoiTT == "085")
                cboDoiTuong.SelectedValue = "10002";
            else
                cboDoiTuong.SelectedValue = "11002";
        }
        if (HTC.ShareVariables.pub_spC == "PS")
            cboKhoaNV.SelectedValue = "009";

        //txtmabame.Text = _MaBA;
        if (_benhan != null && _benhan.MaBALienQuan.Length > 0)
            txtmabame.Text = _benhan.MaBALienQuan;
        else
            txtmabame.Text = _MaBA;
        txtNhomMauMe.Text = _benhnhan.NhomMau;

        
        if (_benhnhan.MaDanToc != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = DMDantoc.GetDMDantoc(_benhnhan.MaDanToc).TenDanToc;
            //selectedItem.Value = _benhnhan.MaDanToc;
            //cbodantoc.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbodantoc.DataBind();
            cbodantoc.Text = DMDantoc.GetDMDantoc(_benhnhan.MaDanToc).TenDanToc;

            cbodantoc.SelectedValue = _benhnhan.MaDanToc;
        }
        if (_benhnhan.MaQG != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();
            //selectedItem.Text = _benhnhan .TenQG ;
            //selectedItem.Value = _benhnhan.MaQG;
            //cboquocgia.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cboquocgia.DataBind();
            cboquocgia.Text = _benhnhan.TenQG;
            cboquocgia.SelectedValue = _benhnhan.MaQG;
        }
        if (_benhnhan.MaTinh != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _benhnhan.TenTinh;
            //selectedItem.Value = _benhnhan.MaTinh;
            //cbotinh.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbotinh.DataBind();
            cbotinh.Text = _benhnhan.TenTinh;
            cbotinh.SelectedValue = _benhnhan.MaTinh;
        }
        if (_benhnhan.MaHuyen != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _benhnhan.TenQH;
            //selectedItem.Value = _benhnhan.MaHuyen;
            //cbohuyen.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbohuyen.DataBind();
            cbohuyen.Text = _benhnhan.TenQH;
            cbohuyen.SelectedValue = _benhnhan.MaHuyen;
        }
        if (_benhnhan.MaPXa != "")
        {
            //RadComboBoxItem selectedItem = new RadComboBoxItem();

            //selectedItem.Text = _benhnhan.TenQH;
            //selectedItem.Value = _benhnhan.MaHuyen;
            //cbohuyen.Items.Add(selectedItem);
            //selectedItem.Selected = true;
            //selectedItem.DataBind();
            //cbohuyen.DataBind();
            cboPXa.Text = _benhnhan.TenPXa;
            cboPXa.SelectedValue = _benhnhan.MaPXa;
        }
        cboNgheNghiep.SelectedValue = _benhnhan.MaNN;
        cboNgheNghiep.Text = _benhnhan.TenNN;
        txtThonXa.Text = _benhnhan.DiaChi;
        txtDiaChi.Text = _benhnhan.BaoTin;
        txtdienthoai.Text = _benhnhan.DienThoai;
        
        
        //dtNgayVV.Text =  DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        //dtNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm", CultureInfo.InvariantCulture);

        dtNgayVV.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        dtNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        


        if (_loaikq != "0")
        {
            BenhAnPK ba = BenhAnPK.GetBenhAnPK(_MaBA);

            txtSocon.Text = ba.MVV;

            //chkdethuong.Checked = ba.MeCachDeThuong;
            //chkdechihuy.Checked = ba.MeCachDeChihuy;
            //chkFoocxep.Checked = ba.MeCachDeFoocxep;
            //chkGiacHut.Checked = ba.MeCachDeGiachut;
            //chkmolaythai.Checked = ba.MeCachDeMo;
            cboKhoaNV.SelectedValue = ba.MaKhoaVV;
            cboKhoaNV.Text = ba.TenKhoaVV;
        }






        //DataTable dt1 = spDMBN_Get(_benhnhan.MaBN);
        //if (dt1 != null && dt1.Rows.Count > 0)
        //{
        //    string Hotencha = dt1.Rows[0][0].ToString();
        //    string MaBHXHCha = dt1.Rows[0][1].ToString();
        //    txthotencha.Text = Hotencha.ToString();
        //    txtMaBHXHCha.Text = MaBHXHCha.ToString();
        //}



    }

    protected Boolean UpdateData()
    {


        try
        {
            if (cboKhoaNV.SelectedValue == "" || cboKhoaNV.SelectedValue == null)
            {
                ShowMessage("Chưa nhập khoa vào viện");
                return false;

            }


            // thong tinbn 

             _ThongTinBN = ThongtinBN1.NewThongtinBN();



            if (HTC.ShareVariables.pub_spC == "HU")
            {
                if (_NoiTT == "087")
                    _ThongTinBN.MaDT = "00002";
                else
                    _ThongTinBN.MaDT = "00001";
            }
            else
            {
                if (_NoiTT == "087")
                    _ThongTinBN.MaDT = "11002";
                else
                    _ThongTinBN.MaDT = "10002";
            }


            if (optGT.Items[0].Selected == true)

                _ThongTinBN.GT = true;
            else
                _ThongTinBN.GT = false;





           // DateTime NgaySinh = DateTime.ParseExact(dtNgaySinh.Text, "dd/MM/yyyy", null);

            

         dtNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //_ThongTinBN.NgaySinh = NgaySinh.ToString("dd/MM/yyyy");

            //string NgaySinh = DateTime.Now.ToString("dd/MM/yyyy");
            //NgaySinh = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            //_ThongTinBN.NgaySinh = NgaySinh.ToString();





            _ThongTinBN.NgaySinh = dtNgaySinh.Text;


            //DateTime NgayVV = DateTime.ParseExact(dtNgayVV.Text, "dd/MM/yyyy", null);
            dtNgayVV.Text =  DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            _ThongTinBN.Hoten = txthoten.Text;
            //_ThongTinBN.Hotencha = txthotencha.Text;
            //_ThongTinBN.MaBHXHCha = txtMaBHXHCha.Text;
            _ThongTinBN.madantoc = cbodantoc.SelectedValue;
            _ThongTinBN.MaQG = cboquocgia.SelectedValue;
            _ThongTinBN.MaTinh = cbotinh.SelectedValue;
            _ThongTinBN.MaHuyen = cbohuyen.SelectedValue;
            _ThongTinBN.MaPXa = cboPXa.SelectedValue;
            _ThongTinBN.DiaChi = txtThonXa.Text;
            _ThongTinBN.BaoTin = txtDiaChi.Text;
            _ThongTinBN.DienThoai = txtdienthoai.Text;
            _ThongTinBN.MaNN = cboNgheNghiep.SelectedValue;
            _ThongTinBN.hotenbome = txthotenBM.Text;
            _ThongTinBN.NhomMau = txtNhomMauMe.Text;
            _ThongTinBN.MaNN = cboNgheNghiep.SelectedValue;
            _ThongTinBN.MaDT = cboDoiTuong.SelectedValue;
            _ThongTinBN.MaMay = Pub_sMaMay;
            _ThongTinBN.NguoiSD = Pub_sNguoiSD;
            if (_ThongTinBN.IsNew == true)
                _ThongTinBN.NguoiLap = Pub_sNguoiSD;
            _ThongTinBN.ApplyEdit();
            _ThongTinBN = _ThongTinBN.Save();


            // benh nhan
            BenhNhan1 _benhnhan = BenhNhan1.NewBenhNhan();


            _benhnhan.BaoTin = _ThongTinBN.BaoTin;
            _benhnhan.DiaChi = _ThongTinBN.DiaChi;
            _benhnhan.DienThoai = _ThongTinBN.DienThoai;
            _benhnhan.MaBAGD = _ThongTinBN.MaBAGD;
            _benhnhan.RHD = _ThongTinBN.RHD;
            _benhnhan.Ghichu = _ThongTinBN.Ghichu;
            _benhnhan.GT = _ThongTinBN.GT;
            _benhnhan.Hoten = _ThongTinBN.Hoten;
            _benhnhan.Hotencha = _ThongTinBN.Hotencha;
            _benhnhan.MaBHXHCha = _ThongTinBN.MaBHXHCha;
            _benhnhan.HoTenBoMe = _ThongTinBN.hotenbome;
            _benhnhan.MaBN = _ThongTinBN.MaBN;
            _benhnhan.MaQG = _ThongTinBN.MaQG;
            _benhnhan.MaDanToc = _ThongTinBN.madantoc;
            _benhnhan.MaHuyen = _ThongTinBN.MaHuyen;
            _benhnhan.MaNN = _ThongTinBN.MaNN;
            //_benhnhan.MaQG = _ThongTinBN.MaQG;

            _benhnhan.Hotencha = txthotencha.Text;
            _benhnhan.MaBHXHCha = txtMaBHXHCha.Text;

            _benhnhan.MaTinh = _ThongTinBN.MaTinh;
            _benhnhan.NgaySinh = _ThongTinBN.NgaySinh;
            _benhnhan.NhomMau = _ThongTinBN.NhomMau;
            _benhnhan.TienSuGiaDinh = _ThongTinBN.TienSuGiaDinh;
            _benhnhan.TienSu = _ThongTinBN.TienSu;
            _benhnhan.TienSuThuoc = _ThongTinBN.TienSuThuoc;
            _benhnhan.Tuoi = _ThongTinBN.Tuoi;
            _benhnhan.MaDT = _ThongTinBN.MaDT;
            _benhnhan.MaMay = Pub_sMaMay;
            _benhnhan.NguoiSD = Pub_sNguoiSD;
            if (_benhnhan.IsNew == true)

                _benhnhan.NguoiLap = Pub_sNguoiSD;
            _benhnhan.ApplyEdit();
            _benhnhan = _benhnhan.Save();

            SmartDate dn = new SmartDate();
            dn.Text = _benhnhan.GiaTriDN;
            SmartDate du = new SmartDate();
            du.Text = _benhnhan.NgaySinh;


            SmartDate da = new SmartDate();
            da.Text = _benhnhan.GiaTriTN;   

            

            DataProvider.Instance().UpdateBenhNhan(_benhnhan.MaBN, _benhnhan.Hoten, _benhnhan.Sothe, _benhnhan.MaBV, dn, _benhnhan.DiaChi, _benhnhan.DienThoai, _benhnhan.RHD, _benhnhan.MaBAGD, _benhnhan.Mail, _benhnhan.Tuoi, du, _benhnhan.GT, _benhnhan.BaoTin, _benhnhan.MaQG, _benhnhan.MaTinh, _benhnhan.MaHuyen, _benhnhan.MaPXa, _benhnhan.MaNN, _benhnhan.TienSu, _benhnhan.TienSuThuoc, _benhnhan.TienSuGiaDinh, _benhnhan.NhomMau, _benhnhan.Ghichu, _benhnhan.MaMay, _benhnhan.Huy, _benhnhan.NguoiSD, _benhnhan.HoTenBoMe, _benhnhan.MaDanToc, da, _benhnhan.MaQuanHeQD, _benhnhan.MaQuanHam, _benhnhan.MaDonVi, _benhnhan.SoCMT, _benhnhan.NoiLamViec);

            

            //benhan_pk
            BenhAnPK _BenhAnPK = BenhAnPK.NewBenhAnPK();



            string NgayGioVV = DateTime.Now.ToString("dd/MM/yyyy");
            NgayGioVV = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            _BenhAnPK.NgayGioVV = NgayGioVV.ToString();



            string NgayVKhoa = DateTime.Now.ToString("dd/MM/yyyy");
            NgayVKhoa = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            _BenhAnPK.NgayVKhoa = NgayVKhoa.ToString();



            //DateTime NgayGioVV = DateTime.ParseExact(dtNgayVV.Text.Substring(0, 10), "dd/MM/yyyy", null);
            ////_BenhAnPK.NgayGioVV = dtNgayVV.Text;

            //_BenhAnPK.NgayGioVV = NgayGioVV.ToString("M/dd/yyyy");
            //DateTime NgayVKhoa = DateTime.ParseExact(dtNgayVV.Text.Substring(0, 10), "dd/MM/yyyy", null);

            ////_BenhAnPK.NgayVKhoa = dtNgayVV.Text;
            //_BenhAnPK.NgayVKhoa = NgayVKhoa.ToString("M/dd/yyyy");

            //DateTime NgayVKhoa = DateTime.ParseExact(_BenhAnPK.NgayVKhoa, "M/dd/yyyy", null);



            _BenhAnPK.MaBN = _ThongTinBN.MaBN;
            _BenhAnPK.MaBAQL = _ThongTinBN.MaBN;
            _BenhAnPK.VaoLan = 1;
            _BenhAnPK.MaBATruoc = "";
            _BenhAnPK.MaLoaiBA = "00027";
            _BenhAnPK.BSChuyenVao = "";
            _BenhAnPK.NgayGioCV = "";
            _BenhAnPK.MaKhoaVV = cboKhoaNV.SelectedValue;
            _BenhAnPK.MaNoiGT = "";
            _BenhAnPK.MaNoiKham = "";
            _BenhAnPK.BSVaovien = cboBacSi.SelectedValue;
            _BenhAnPK.TenBenhNGT = "";
            _BenhAnPK.TenBenhKKB = "";
            _BenhAnPK.MaBenhKKB = "";
            _BenhAnPK.MaBenhNGT = "";
            _BenhAnPK.MaBV = "";
            _BenhAnPK.MaBVGT = "";
            _BenhAnPK.MaDT = cboDoiTuong.SelectedValue;
            _BenhAnPK.Sothe = "";
            _BenhAnPK.GiaTriDN = "";
            _BenhAnPK.GiaTriTN = "";
            _BenhAnPK.NoiTT = _NoiTT;
            _BenhAnPK.Loai = 3;
            _BenhAnPK.MVV = txtSocon.Text;
            if (chkdethuong.Checked == true)
                _BenhAnPK.GDRV = "1";
            else
                _BenhAnPK.GDRV = "0";

            if (chkFoocxep.Checked == true)
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "1";
            else
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "0";
            if (chkGiacHut.Checked == true)
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "1";
            else
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "0";
            if (chkmolaythai.Checked == true)
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "1";
            else
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "0";
            if (chkdechihuy.Checked == true)
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "1";
            else
                _BenhAnPK.GDRV = _BenhAnPK.GDRV + "0";



            // benhan
            BenhAn _benhan = BenhAn.NewBenhAn();

            _benhan.MaBALienQuan = txtmabame.Text;
            _benhan.bhtra = _ThongTinBN.KhamBenh.bhtra;
            _benhan.CDNoiGT = _ThongTinBN.KhamBenh.CDNoiGT;
            _benhan.MaLoaiBA = "00027";
            _benhan.Cungtra = _ThongTinBN.KhamBenh.Cungtra;
            _benhan.Diachi = _ThongTinBN.DiaChi;
            _benhan.Ghichu = _ThongTinBN.Ghichu;
            _benhan.GiatriDN = _BenhAnPK.GiaTriDN;
            _benhan.GiaTriTN = _BenhAnPK.GiaTriTN;
            _benhan.MaLoaiBA = _BenhAnPK.MaLoaiBA;
            _benhan.MaBenhNoiGT = _BenhAnPK.MaBenhNGT;
            _benhan.mabhxh = _BenhAnPK.MaBHXH;
            _benhan.MaBN = _ThongTinBN.MaBN;
            _benhan.MaBAQL = _ThongTinBN.MaBN;

            _benhan.MaBV = _BenhAnPK.MaBV;
            _benhan.MaDT = _BenhAnPK.MaDT;
            _benhan.maicdngt = _BenhAnPK.maicdNGT;
            _benhan.MaKhoa_HT = _BenhAnPK.MaKhoaVV;
            _benhan.MaNoiGT = _BenhAnPK.MaNoiGT;
            _benhan.MaTinh = _ThongTinBN.MaTinh;
            _benhan.NgayVV = NgayGioVV.ToString();
            //WriteLog(" NgayVV: " + NgayGioVV);
            _benhan.Sothe = _BenhAnPK.Sothe;
            _benhan.sotienbhtra = _ThongTinBN.KhamBenh.sotienbhtra;
            _benhan.tenbenhngt = _BenhAnPK.TenBenhNGT;
            _benhan.TenBV = _BenhAnPK.TenBV;
            _benhan.MaDT = cboDoiTuong.SelectedValue;
            _benhan.MaMay = Pub_sMaMay;
            _benhan.NguoiSD = Pub_sNguoiSD;
            _benhan.NoiTT = _NoiTT;
            if (_benhan.IsNew == true)

                _benhan.NguoiLap = Pub_sNguoiSD;

            _benhan.ApplyEdit();
            _benhan = _benhan.Save();
            // bapk
            _BenhAnPK.MaBANoiTru = _benhan.MaBA;
            _BenhAnPK.MaMay = Pub_sMaMay;
            _BenhAnPK.NguoiSD = Pub_sNguoiSD;
            if (_BenhAnPK.IsNew == true)

            _BenhAnPK.NguoiLap = Pub_sNguoiSD;
            _BenhAnPK.ApplyEdit();
            _BenhAnPK.Save();


            //benhan_khoa
            _BenhAn_Khoa = BenhAn_Khoa.NewBenhAn_Khoa();
            _BenhAn_Khoa.MaBA = _benhan.MaBA;
            _BenhAn_Khoa.MaDT = _benhan.MaDT;
            _BenhAn_Khoa.MaKhoa = _benhan.MaKhoa_HT;
            _BenhAn_Khoa.MaBN = _benhan.MaBN;
            _BenhAn_Khoa.NgayVKhoa = _benhan.NgayVV;
            _BenhAn_Khoa.Clone();
            _BenhAn_Khoa.MaMay = Pub_sMaMay;
            _BenhAn_Khoa.NguoiSD = Pub_sNguoiSD;
            if (_BenhAn_Khoa.IsNew == true)
                _BenhAn_Khoa.NguoiLap = Pub_sNguoiSD;
            _BenhAn_Khoa.ApplyEdit();
            _BenhAn_Khoa = _BenhAn_Khoa.Save();

            // benh an so sinh


             _BenhAnSoSinh = BenhAn_SoSinh2.NewBenhAn_SoSinh();

            _BenhAnSoSinh.MaBA = _benhan.MaBA;
            _BenhAnSoSinh.STTKhoa = _BenhAn_Khoa.STTKhoa;

            _BenhAnSoSinh.Tinhtrangcon = txtTinhtrangcon.Text;
            _BenhAnSoSinh.Noisinh = txtNoisinh.Text;
            _BenhAnSoSinh.CanNang = txtcannang.Text;
            _BenhAnSoSinh.TuoiThai = txttuoithai.Text;



            byte b = (byte)0;
            if (byte.TryParse(txtLansinh.Text, out b)) { }
            _BenhAnSoSinh.LanSinh = b;

            if (byte.TryParse(txtSoconsong.Text, out b)) { }
            _BenhAnSoSinh.Soconsong = b;


            string NgayKham = DateTime.Now.ToString("dd/MM/yyyy");
            NgayKham = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            _BenhAnSoSinh.NgayKham = NgayKham.ToString();


            //DateTime NgayKham = DateTime.ParseExact(dtNgayVV.Text.Substring(0, 10), "dd/MM/yyyy", null);
            //_BenhAnSoSinh.NgayKham = NgayKham.ToString("M/dd/yyyy");





            byte rb = 0;

            if (chkdethuong.Checked == true)
            {
                rb = 1;
            }
            else if (chkFoocxep.Checked == true)
            {
                rb = 2;
            }
            else if (chkGiacHut.Checked == true)
            {
                rb = 3;
            }
            else if (chkmolaythai.Checked == true)
            {
                rb = 4;
            }
            else if (chkdechihuy.Checked == true)
            {
                rb = 5;
            }

            _BenhAnSoSinh.ApplyEdit();
            _BenhAnSoSinh = _BenhAnSoSinh.Save();

            if (_loaikq == "0")
            {



                string sql = "update thongtinbn set Hotencha =N'" + txthotencha.Text + "',nhommau ='" + txtNhomMauMe.Text + "',MaBHXHCha = '" + txtMaBHXHCha.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);

                sql = "update benhnhan set Hotencha =N'" + txthotencha.Text + "',nhommau ='" + txtNhomMauMe.Text + "',MaBHXHCha = '" + txtMaBHXHCha.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);


                sql = "update BenhAn_SoSinh set Tinhtrangcon =N'" + txtTinhtrangcon.Text + "',Noisinh =N'" + txtNoisinh.Text + "',Cannang = '" + txtcannang.Text + "',TuoiThai = '" + txttuoithai.Text + "',Lansinh = '" + txtLansinh.Text + "',Nguoidode = '" + cbonhanvien.SelectedValue + "',Soconsong = '" + txtSoconsong.Text + "',CachDe =" + rb.ToString() + " where maba ='" + _BenhAnSoSinh.MaBA + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);





                //sql = "update benhnhan set Hotencha =N'" + txthotencha.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                //HTC.Business.DataProvider.Instance().ExcSQL(sql);

                //DataProvider.Instance().UpdateBenhNhan(_benhnhan.MaBN, _benhnhan.Hoten, _benhnhan.Sothe, _benhnhan.MaBV, dn, _benhnhan.DiaChi, _benhnhan.DienThoai, _benhnhan.RHD, _benhnhan.MaBAGD, _benhnhan.Mail, _benhnhan.Tuoi, du, _benhnhan.GT, _benhnhan.BaoTin, _benhnhan.MaQG, _benhnhan.MaTinh, _benhnhan.MaHuyen, _benhnhan.MaPXa, _benhnhan.MaNN, _benhnhan.TienSu, _benhnhan.TienSuThuoc, _benhnhan.TienSuGiaDinh, _benhnhan.NhomMau, _benhnhan.Ghichu, _benhnhan.MaMay, _benhnhan.Huy, _benhnhan.NguoiSD, _benhnhan.HoTenBoMe, _benhnhan.MaDanToc, da, _benhnhan.MaQuanHeQD, _benhnhan.MaQuanHam, _benhnhan.MaDonVi, _benhnhan.SoCMT, _benhnhan.NoiLamViec);



            }
            else

            {


                string sql = "update thongtinbn set hoten =N'" + txthoten.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);
                sql = "update benhnhan set hoten =N'" + txthoten.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);




                BenhAnPK _ba = BenhAnPK.GetBenhAnPK(_MaBA);

                if (chkdethuong.Checked == true)
                    _ba.GDRV = "1";
                else
                    _ba.GDRV = "0";
                if (chkGiacHut.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";

                if (chkFoocxep.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";

                if (chkmolaythai.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";
                if (chkdechihuy.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";




                sql = "update benhanpk set mvv ='" + txtSocon.Text + "',GDRV='" + _ba.GDRV + "'  where maba ='" + _ba.MaBA + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);
                sql = "update benhnhan set nhommau ='" + txtNhomMauMe.Text + "' where mabn ='" + _ba.MaBAQL + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);

            }



            if (_loaikq == "1")
            {



                string sql = "update thongtinbn set Hotencha =N'" + txthotencha.Text + "',nhommau ='" + txtNhomMauMe.Text + "',MaBHXHCha = '" + txtMaBHXHCha.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);

                sql = "update benhnhan set Hotencha =N'" + txthotencha.Text + "',nhommau ='" + txtNhomMauMe.Text + "',MaBHXHCha = '" + txtMaBHXHCha.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);


                sql = "update BenhAn_SoSinh set Tinhtrangcon =N'" + txtTinhtrangcon.Text + "',Noisinh =N'" + txtNoisinh.Text + "',Cannang = '" + txtcannang.Text + "',TuoiThai = '" + txttuoithai.Text + "',Lansinh = '" + txtLansinh.Text + "',Nguoidode = '" + cbonhanvien.SelectedValue + "',Soconsong = '" + txtSoconsong.Text + "',CachDe =" + rb.ToString() + " where maba ='" + _benhan.MaBA + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);



                //sql = "update BenhAn_SoSinh set CachDe =" + rb.ToString() + " where maba =" + _benhan.MaBA + "";
                //HTC.Business.DataProvider.Instance().ExcSQL(sql);


                //sql = "update benhnhan set Hotencha =N'" + txthotencha.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                //HTC.Business.DataProvider.Instance().ExcSQL(sql);


                DataProvider.Instance().UpdateBenhNhan(_benhnhan.MaBN, _benhnhan.Hoten, _benhnhan.Sothe, _benhnhan.MaBV, dn, _benhnhan.DiaChi, _benhnhan.DienThoai, _benhnhan.RHD, _benhnhan.MaBAGD, _benhnhan.Mail, _benhnhan.Tuoi, du, _benhnhan.GT, _benhnhan.BaoTin, _benhnhan.MaQG, _benhnhan.MaTinh, _benhnhan.MaHuyen, _benhnhan.MaPXa, _benhnhan.MaNN, _benhnhan.TienSu, _benhnhan.TienSuThuoc, _benhnhan.TienSuGiaDinh, _benhnhan.NhomMau, _benhnhan.Ghichu, _benhnhan.MaMay, _benhnhan.Huy, _benhnhan.NguoiSD, _benhnhan.HoTenBoMe, _benhnhan.MaDanToc, da, _benhnhan.MaQuanHeQD, _benhnhan.MaQuanHam, _benhnhan.MaDonVi, _benhnhan.SoCMT, _benhnhan.NoiLamViec);


            }
            else

            {


                string sql = "update thongtinbn set hoten =N'" + txthoten.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);
                sql = "update benhnhan set hoten =N'" + txthoten.Text + "',gt =" + (optGT.Items[0].Selected == true ? "1" : "0") + " where mabn ='" + _MaBN + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);




                BenhAnPK _ba = BenhAnPK.GetBenhAnPK(_MaBA);

                if (chkdethuong.Checked == true)
                    _ba.GDRV = "1";
                else
                    _ba.GDRV = "0";
                if (chkGiacHut.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";

                if (chkFoocxep.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";

                if (chkmolaythai.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";
                if (chkdechihuy.Checked == true)
                    _ba.GDRV = _ba.GDRV + "1";
                else
                    _ba.GDRV = _ba.GDRV + "0";




                sql = "update benhanpk set mvv ='" + txtSocon.Text + "',GDRV='" + _ba.GDRV + "'  where maba ='" + _ba.MaBA + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);
                sql = "update benhnhan set nhommau ='" + txtNhomMauMe.Text + "' where mabn ='" + _ba.MaBAQL + "'";
                HTC.Business.DataProvider.Instance().ExcSQL(sql);

            }



            return true;
        }
        catch (Exception ex)
        {
            //HandleException(ex, FormAction.EDIT);
            ShowMessage("Không lưu được dữ liệu" + ex.Message);



            //throw;
            return false;
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
    protected void cbohuyen_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        try
        {
            if (cbohuyen.AutoPostBack == true)
            {
                cboPXa.DataBind();
                cboPXa.Focus();
            }
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



    [Serializable()]
    public  class ThongtinBN1 : BusinessBase<ThongtinBN1>
    {
        #region Business Methods

        #region State Fields
        private SmartDate _giaTriTN = new SmartDate(true);
        private String _maBN = String.Empty;
        private String _hoten = String.Empty;
        private String _sothe = String.Empty;
        private String _maBV = String.Empty;
        private SmartDate _giaTriDN = new SmartDate(true);
        private String _maDT = String.Empty;
        private String _diaChi = String.Empty;
        private String _diaChiC = String.Empty;
        private String _dienThoai = String.Empty;
        private String _DTDD = String.Empty;
        private String _DTCQ = String.Empty;
        private String _RHD = String.Empty;
        private String _MaBAGD = String.Empty;
        private String _mail = String.Empty;
        private Byte _tuoi = 1;
        private int _thang = 1;
        private SmartDate _ngaySinh = new SmartDate(true);
        private SmartDate _ngaySinhD = new SmartDate(true);
        private SmartDate _ngayyc = new SmartDate(true);
        private Boolean _gt = false;
        private String _gtD = "Nữ";
        private Boolean _gtNu = false;
        private String _baoTin = String.Empty;
        private String _maQG = String.Empty;
        private String _maTinh = String.Empty;
        private String _maHuyen = String.Empty;
        private String _maPXa = String.Empty;
        private String _maNN = String.Empty;
        private String _tienSu = String.Empty;
        private String _tienSuThuoc = String.Empty;
        private String _tienSuGiaDinh = String.Empty;
        private String _nhomMau = String.Empty;
        private String _maBANoiT = String.Empty;
        private String _maKhoaVV = String.Empty;
        private SmartDate _ngayVV = new SmartDate(true);
        private String _maBANgoaiT = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayBANgoaiT = new SmartDate(true);
        private String _madantoc = String.Empty;
        private String _hotenbome = String.Empty;
        private String _hotencha = String.Empty;
        private String _Lansinh = String.Empty;
        private String _MaBHXHCha = String.Empty;
        //private String _MaBHXHMe = String.Empty;

        private int _OrderNumber;
        private SmartDate _NgayDK = new SmartDate(true);
        private String _mabhxh = String.Empty;
        private String _tenbv = String.Empty;
        private String _maBAQL = String.Empty;
        private String _TenDT = String.Empty;
        private String _MaQuanHeQD = String.Empty;
        private String _MaQuanHam = String.Empty;
        private String _ngayDu5Nam = String.Empty;
        private String _maKV = String.Empty;
        private String _ngayMienCCT = String.Empty;
        private String _MaDonVi = String.Empty;
        private String _SoCMT = String.Empty;
        private String _MaNhomDV1 = String.Empty;
        private String _MaNhomDV2 = String.Empty;
        private String _tenQH = String.Empty;
        private String _tenPXa = String.Empty;
        private String _tenTinh = String.Empty;
        private String _tenQG = String.Empty;
        private String _tenNN = String.Empty;
        private string _noiLamViec = String.Empty;
        #endregion

        #region Business Properties and Methods
        public string NoiLamViec
        {
            get
            {
                CanReadProperty(true);
                return _noiLamViec;
            }
            set
            {
                CanReadProperty("NoiLamViec", true);
                if (!_noiLamViec.Equals(value))
                {
                    _noiLamViec = value;
                    PropertyHasChanged("NoiLamViec");
                }
            }
        }
        public String MaQuanHam
        {
            get
            {
                CanReadProperty("MaQuanHam", true);
                return _MaQuanHam;
            }
            set
            {
                CanWriteProperty("MaQuanHam", true);
                if (_MaQuanHam != value)
                {
                    _MaQuanHam = value;
                    PropertyHasChanged("MaQuanHam");
                }
            }
        }
        public string MaKV
        {
            get
            {
                CanReadProperty(true);
                return _maKV;
            }
            set
            {
                CanReadProperty("MaKV", true);
                if (!_maKV.Equals(value))
                {
                    _maKV = value;
                    PropertyHasChanged("MaKV");
                }
            }
        }
        public string NgayMienCCT
        {
            get
            {
                CanReadProperty(true);
                return _ngayMienCCT;
            }
            set
            {
                CanReadProperty("NgayMienCCT", true);
                if (!_ngayMienCCT.Equals(value))
                {
                    _ngayMienCCT = value;
                    PropertyHasChanged("NgayMienCCT");
                }
            }
        }
        public String ngayDu5Nam
        {
            get
            {
                CanReadProperty("ngayDu5Nam", true);
                return _ngayDu5Nam;
            }
            set
            {
                CanWriteProperty("ngayDu5Nam", true);
                if (_ngayDu5Nam != value)
                {
                    _ngayDu5Nam = value;
                    PropertyHasChanged("ngayDu5Nam");
                }
            }
        }
        public string TenTinh
        {
            get
            {
                CanReadProperty(true);
                return _tenTinh;
            }
            set
            {
                //CanWriteProperty(true);
                if (!_tenTinh.Equals(value))
                {
                    _tenTinh = value;
                    //PropertyHasChanged();
                }
            }
        }
        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
                }
            }
        }
        public String TenQH
        {
            get
            {
                CanReadProperty("TenQH", true);
                return _tenQH;
            }
            set
            {
                CanWriteProperty("TenQH", true);
                if (_tenQH != value)
                {
                    _tenQH = value;
                    PropertyHasChanged("TenQH");
                }
            }
        }
        public String TenPXa
        {
            get
            {
                CanReadProperty("TenPXa", true);
                return _tenPXa;
            }
            set
            {
                CanWriteProperty("TenPXa", true);
                if (_tenPXa != value)
                {
                    _tenPXa = value;
                    PropertyHasChanged("TenPXa");
                }
            }
        }
        public String TenNN
        {
            get
            {
                CanReadProperty("TenNN", true);
                return _tenNN;
            }
            set
            {
                CanWriteProperty("TenNN", true);
                if (_tenNN != value)
                {
                    _tenNN = value;
                    PropertyHasChanged("TenNN");
                }
            }
        }

        public String MaNhomDV1
        {
            get
            {
                CanReadProperty("MaNhomDV1", true);
                return _MaNhomDV1;
            }
            set
            {
                CanWriteProperty("MaNhomDV1", true);
                if (_MaNhomDV1 != value)
                {
                    _MaNhomDV1 = value;
                    PropertyHasChanged("MaNhomDV1");
                }
            }
        }
        public String MaNhomDV2
        {
            get
            {
                CanReadProperty("MaNhomDV2", true);
                return _MaNhomDV2;
            }
            set
            {
                CanWriteProperty("MaNhomDV2", true);
                if (_MaNhomDV2 != value)
                {
                    _MaNhomDV2 = value;
                    PropertyHasChanged("MaNhomDV2");
                }
            }
        }
        public String MaQuanHeQD
        {
            get
            {
                CanReadProperty("MaQuanHeQD", true);
                return _MaQuanHeQD;
            }
            set
            {
                CanWriteProperty("MaQuanHeQD", true);
                if (_MaQuanHeQD != value)
                {
                    _MaQuanHeQD = value;
                    PropertyHasChanged("MaQuanHeQD");
                }
            }
        }

        public String MaDonVi
        {
            get
            {
                CanReadProperty("MaDonVi", true);
                return _MaDonVi;
            }
            set
            {
                CanWriteProperty("MaDonVi", true);
                if (_MaDonVi != value)
                {
                    _MaDonVi = value;
                    PropertyHasChanged("MaDonVi");
                }
            }
        }
        public String SoCMT
        {
            get
            {
                CanReadProperty("SoCMT", true);
                return _SoCMT;
            }
            set
            {
                CanWriteProperty("SoCMT", true);
                if (_SoCMT != value)
                {
                    _SoCMT = value;
                    PropertyHasChanged("SoCMT");
                }
            }
        }
        public String MaBAQL
        {
            get
            {
                CanReadProperty("MaBAQL", true);
                return _maBAQL;
            }
            set
            {
                CanWriteProperty("MaBAQL", true);
                if (_maBAQL != value)
                {
                    _maBAQL = value;
                    PropertyHasChanged("MaBAQL");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }
        public String gtD
        {
            get
            {
                CanReadProperty("gtD", true);
                if (_gt == true)
                    return "Nam";
                else
                    return "Nữ";

            }

        }
        public String hotenbome
        {
            get
            {
                CanReadProperty("hotenbome", true);
                return _hotenbome;
            }
            set
            {
                CanWriteProperty("hotenbome", true);
                if (_hotenbome != value)
                {
                    _hotenbome = value;
                    PropertyHasChanged("hotenbome");
                }
            }
        }
        public String Hotencha
        {
            get
            {
                CanReadProperty("Hotencha", true);
                return _hotencha;
            }
            set
            {
                CanWriteProperty("Hotencha", true);
                if (_hotencha != value)
                {
                    _hotencha = value;
                    PropertyHasChanged("Hotencha");
                }
            }
        }
        public String madantoc
        {
            get
            {
                CanReadProperty("madantoc", true);
                return _madantoc;
            }
            set
            {
                CanWriteProperty("madantoc", true);
                if (_madantoc != value)
                {
                    _madantoc = value;
                    PropertyHasChanged("madantoc");
                }
            }
        }
        public String tenbv
        {
            get
            {
                CanReadProperty("tenbv", true);
                return _tenbv;
            }
            set
            {
                CanWriteProperty("tenbv", true);
                if (_tenbv != value)
                {
                    _tenbv = value;
                    PropertyHasChanged("tenbv");
                }
            }
        }
        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
                }
            }
        }
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }
        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _TenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_TenDT != value)
                {
                    _TenDT = value;
                    PropertyHasChanged("TenDT");
                }
            }
        }
        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _maBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_maBN != value)
                {
                    _maBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten.ToUpper();
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }
        public String Lansinh
        {
            get
            {
                CanReadProperty("Lansinh", true);
                return _Lansinh.ToUpper();
            }
            set
            {
                CanWriteProperty("Lansinh", true);
                if (_Lansinh != value)
                {
                    _Lansinh = value;
                    PropertyHasChanged("Lansinh");
                }
            }
        }
        public String MaBHXHCha
        {
            get
            {
                CanReadProperty("MaBHXHCha", true);
                return _MaBHXHCha.ToUpper();
            }
            set
            {
                CanWriteProperty("MaBHXHCha", true);
                if (_MaBHXHCha != value)
                {
                    _MaBHXHCha = value;
                    PropertyHasChanged("MaBHXHCha");
                }
            }
        }
        //public String MaBHXHMe
        //{
        //    get
        //    {
        //        CanReadProperty("MaBHXHMe", true);
        //        return _MaBHXHMe.ToUpper();
        //    }
        //    set
        //    {
        //        CanWriteProperty("MaBHXHMe", true);
        //        if (_MaBHXHMe != value)
        //        {
        //            _MaBHXHMe = value;
        //            PropertyHasChanged("MaBHXHMe");
        //        }
        //    }
        //}



        //public String Sothe
        //{
        //    get 
        //    {
        //        CanReadProperty("Sothe", true);
        //        return _sothe;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Sothe", true);
        //        if (_sothe != value) 
        //        {
        //            _sothe = value;
        //            PropertyHasChanged("Sothe");
        //        }
        //    }
        //}

        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _maBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_maBV != value)
                {
                    _maBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }






        public String GiaTriDN
        {
            get
            {
                CanReadProperty("GiaTriDN", true);
                return _giaTriDN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriDN", true);
                if (_giaTriDN.Text != value)
                {
                    _giaTriDN.Text = value;
                    PropertyHasChanged("GiaTriDN");
                }
            }
        }

        public String DiaChi
        {
            get
            {
                CanReadProperty("DiaChi", true);

                return _diaChi;
            }
            set
            {
                CanWriteProperty("DiaChi", true);
                if (_diaChi != value)
                {
                    _diaChi = value;
                    PropertyHasChanged("DiaChi");
                }
            }
        }
        public String DiaChiC
        {
            get
            {
                CanReadProperty("DiaChiC", true);

                return _diaChiC;
            }
            set
            {
                CanWriteProperty("DiaChiC", true);
                if (_diaChiC != value)
                {
                    _diaChiC = value;
                    PropertyHasChanged("DiaChiC");
                }
            }
        }

        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                return _dienThoai;
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_dienThoai != value)
                {
                    _dienThoai = value;
                    PropertyHasChanged("DienThoai");
                }
            }
        }
        public String DTCQ
        {
            get
            {
                CanReadProperty("DTCQ", true);
                return _DTCQ;
            }
            set
            {
                CanWriteProperty("DTCQ", true);
                if (_DTCQ != value)
                {
                    _DTCQ = value;
                    PropertyHasChanged("DTCQ");
                }
            }
        }
        public String DTDD
        {
            get
            {
                CanReadProperty("DTDD", true);
                return _DTDD;
            }
            set
            {
                CanWriteProperty("DTDD", true);
                if (_DTDD != value)
                {
                    _DTDD = value;
                    PropertyHasChanged("DTDD");
                }
            }
        }

        public String RHD
        {
            get
            {
                CanReadProperty("RHD", true);
                return _RHD;
            }
            set
            {
                CanWriteProperty("RHD", true);
                if (_RHD != value)
                {
                    _RHD = value;
                    PropertyHasChanged("RHD");
                }
            }
        }

        public String MaBAGD
        {
            get
            {
                CanReadProperty("MaBAGD", true);
                return _MaBAGD;
            }
            set
            {
                CanWriteProperty("MaBAGD", true);
                if (_MaBAGD != value)
                {
                    _MaBAGD = value;
                    PropertyHasChanged("MaBAGD");
                }
            }
        }

        public String Mail
        {
            get
            {
                CanReadProperty("Mail", true);
                return _mail;
            }
            set
            {
                CanWriteProperty("Mail", true);
                if (_mail != value)
                {
                    _mail = value;
                    PropertyHasChanged("Mail");
                }
            }
        }

        public byte Tuoi
        {
            get
            {

                //CanReadProperty("Tuoi", true);
                if (_ngaySinh.Date != DateTime.MinValue)
                    if (_ngaySinh.Date.Year != 0)
                        _tuoi = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                return _tuoi;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }
        public int thang
        {
            get
            {

                //CanReadProperty("thang", true);
                if (Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month) < 0)
                    _thang = Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month + 13);
                else
                    _thang = Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month + 1);
                return _thang;
            }
            set
            {
                CanWriteProperty("thang", true);
                if (_thang != value)
                {
                    _thang = value;
                    PropertyHasChanged("thang");
                }
            }
        }
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinh.FormatString = "dd/MM/yyyy";
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    if (_ngaySinh.Date.Year != 1)
                        _tuoi = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinhD = _ngaySinh;
                _ngaySinhD.FormatString = "dd/MM/yyyy";
                return _ngaySinh.Text;
            }

        }
        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
                }
            }
        }
        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("GTNu", true);
                if (_gtNu != value)
                {
                    if (value == true)
                        _gt = false;
                    else
                        _gt = true;
                    _gtNu = value;

                    PropertyHasChanged("GTnu");
                }

            }
        }
        public String BaoTin
        {
            get
            {
                CanReadProperty("BaoTin", true);
                return _baoTin;
            }
            set
            {
                CanWriteProperty("BaoTin", true);
                if (_baoTin != value)
                {
                    _baoTin = value;
                    PropertyHasChanged("BaoTin");
                }
            }
        }

        public String MaQG
        {
            get
            {
                CanReadProperty("MaQG", true);
                return _maQG;
            }
            set
            {
                CanWriteProperty("MaQG", true);
                if (_maQG != value)
                {
                    _maQG = value;
                    PropertyHasChanged("MaQG");
                }
            }
        }

        public String MaTinh
        {
            get
            {
                CanReadProperty("MaTinh", true);
                return _maTinh;
            }
            set
            {
                CanWriteProperty("MaTinh", true);
                if (_maTinh != value)
                {
                    _maTinh = value;
                    PropertyHasChanged("MaTinh");
                }
            }
        }

        public String MaHuyen
        {
            get
            {
                CanReadProperty("MaHuyen", true);
                return _maHuyen;
            }
            set
            {
                CanWriteProperty("MaHuyen", true);
                if (_maHuyen != value)
                {
                    _maHuyen = value;
                    PropertyHasChanged("MaHuyen");
                }
            }
        }
        public String MaPXa
        {
            get
            {
                CanReadProperty("MaPXa", true);
                return _maPXa;
            }
            set
            {
                CanWriteProperty("MaPXa", true);
                if (_maPXa != value)
                {
                    _maPXa = value;
                    PropertyHasChanged("MaPXa");
                }
            }
        }

        public String MaNN
        {
            get
            {
                CanReadProperty("MaNN", true);
                return _maNN;
            }
            set
            {
                CanWriteProperty("MaNN", true);
                if (_maNN != value)
                {
                    _maNN = value;
                    PropertyHasChanged("MaNN");
                }
            }
        }

        public String TienSu
        {
            get
            {
                CanReadProperty("TienSu", true);
                return _tienSu;
            }
            set
            {
                CanWriteProperty("TienSu", true);
                if (_tienSu != value)
                {
                    _tienSu = value;
                    PropertyHasChanged("TienSu");
                }
            }
        }

        public String TienSuThuoc
        {
            get
            {
                CanReadProperty("TienSuThuoc", true);
                return _tienSuThuoc;
            }
            set
            {
                CanWriteProperty("TienSuThuoc", true);
                if (_tienSuThuoc != value)
                {
                    _tienSuThuoc = value;
                    PropertyHasChanged("TienSuThuoc");
                }
            }
        }

        public String TienSuGiaDinh
        {
            get
            {
                CanReadProperty("TienSuGiaDinh", true);
                return _tienSuGiaDinh;
            }
            set
            {
                CanWriteProperty("TienSuGiaDinh", true);
                if (_tienSuGiaDinh != value)
                {
                    _tienSuGiaDinh = value;
                    PropertyHasChanged("TienSuGiaDinh");
                }
            }
        }

        public String NhomMau
        {
            get
            {
                CanReadProperty("NhomMau", true);
                return _nhomMau;
            }
            set
            {
                CanWriteProperty("NhomMau", true);
                if (_nhomMau != value)
                {
                    _nhomMau = value;
                    PropertyHasChanged("NhomMau");
                }
            }
        }

        public String MaBANoiT
        {
            get
            {
                CanReadProperty("MaBANoiT", true);
                return _maBANoiT;
            }
            set
            {
                CanWriteProperty("MaBANoiT", true);
                if (_maBANoiT != value)
                {
                    _maBANoiT = value;
                    PropertyHasChanged("MaBANoiT");
                }
            }
        }

        public String MaKhoaVV
        {
            get
            {
                CanReadProperty("MaKhoaVV", true);
                return _maKhoaVV;
            }
            set
            {
                CanWriteProperty("MaKhoaVV", true);
                if (_maKhoaVV != value)
                {
                    _maKhoaVV = value;
                    PropertyHasChanged("MaKhoaVV");
                }
            }
        }

        public string NgayVV
        {
            get
            {
                CanReadProperty("NgayVV", true);
                return _ngayVV.Text;
            }
            set
            {
                CanWriteProperty("NgayVV", true);
                if (_ngayVV.Text != value)
                {
                    _ngayVV.Text = value;
                    PropertyHasChanged("NgayVV");
                }
            }
        }

        public String MaBANgoaiT
        {
            get
            {
                CanReadProperty("MaBANgoaiT", true);
                return _maBANgoaiT;
            }
            set
            {
                CanWriteProperty("MaBANgoaiT", true);
                if (_maBANgoaiT != value)
                {
                    _maBANgoaiT = value;
                    PropertyHasChanged("MaBANgoaiT");
                }
            }
        }

        public string NgayKham
        {
            get
            {
                CanReadProperty("NgayKham", true);
                _ngayKham.FormatString = "dd/MM/yyyy";
                return _ngayKham.Text;
            }
            set
            {
                CanWriteProperty("NgayKham", true);
                if (_ngayKham.Text != value)
                {
                    _ngayKham.FormatString = "dd/MM/yyyy";
                    _ngayKham.Text = value;
                    PropertyHasChanged("NgayKham");
                }
            }
        }
        public string NgayDK
        {
            get
            {
                CanReadProperty("NgayDK", true);
                _NgayDK.FormatString = "dd/MM/yyyy";
                return _NgayDK.Text;
            }
            set
            {
                CanWriteProperty("NgayDK", true);
                if (_NgayDK.Text != value)
                {
                    _NgayDK.FormatString = "dd/MM/yyyy";
                    _NgayDK.Text = value;
                    PropertyHasChanged("NgayDK");
                }
            }
        }
        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("Ghichu");
                }
            }
        }

        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }

        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }

        //public string NgayHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayHuy", true);
        //        return _ngayHuy.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayHuy", true);
        //        if (_ngayHuy.Text != value) 
        //        {
        //            _ngayHuy.Text = value;
        //            PropertyHasChanged("NgayHuy");
        //        }
        //    }
        //}

        //public String NguoiHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiHuy", true);
        //        return _nguoiHuy;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiHuy", true);
        //        if (_nguoiHuy != value) 
        //        {
        //            _nguoiHuy = value;
        //            PropertyHasChanged("NguoiHuy");
        //        }
        //    }
        //}

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }

        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }

        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _ngaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value) 
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}

        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value) 
        //        {
        //            _nguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}

        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }

        //public string NgayBANgoaiT
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayBANgoaiT", true);
        //        return _ngayBANgoaiT.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayBANgoaiT", true);
        //        if (_ngayBANgoaiT.Text != value) 
        //        {
        //            _ngayBANgoaiT.Text = value;
        //            PropertyHasChanged("NgayBANgoaiT");
        //        }
        //    }
        //}

        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
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
        private KhamBenh _KhamBenh = KhamBenh.NewKhamBenh();

        public KhamBenh KhamBenh
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh.Equals(value))
                {
                    _KhamBenh = value;
                    PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maBN;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid;
            }
        }
        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //TODO: add validation rules

            ValidationRules.AddRule<ThongtinBN1>(ValidationNgaySinh<ThongtinBN1>, "NgaySinh");

        }
        private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : ThongtinBN1
        {
            if (target._ngaySinh.Date > System.DateTime.Now.AddDays(1))
            {
                e.Description = "VALIDATION_NOW";
                return false;
            }
            else
                return true;
        }

        #endregion


        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="ThongtinBN1" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static ThongtinBN1 NewThongtinBN()
        {
            //return new DMNhomThuoc();

            return DataPortal.Create<ThongtinBN1>();
        }
        public static ThongtinBN1 GetThongtinBN(String maBN, DateTime ngaydk, Byte loai)
        {
            return DataPortal.Fetch<ThongtinBN1>(new Criteria(maBN, ngaydk, loai));
        }
        public static ThongtinBN1 GetThongtinBN(String maBN, DateTime ngaydk, Byte loai, string noitt)
        {
            return DataPortal.Fetch<ThongtinBN1>(new CriteriaTT(maBN, ngaydk, loai, noitt));
        }
        public static ThongtinBN1 GetThongtinBN(String maBN, Byte loai)
        {
            return DataPortal.Fetch<ThongtinBN1>(new OtherCriteria("", "", maBN, loai));
        }
        public static ThongtinBN1 GetThongtinBN(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn, byte loaikq, string makhoa)
        {
            return DataPortal.Fetch<ThongtinBN1>(new CriteriaKB(maBN, ngaydk, loai, masokham, stt, loaikqcn, loaikq, makhoa));
        }
        public static ThongtinBN1 GetThongtinBN(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn)
        {
            return DataPortal.Fetch<ThongtinBN1>(new CriteriaKB(maBN, ngaydk, loai, masokham, stt, loaikqcn, 0, ""));
        }
        /// <summary>
        /// Marks the <see cref="ThongtinBN1" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteThongtinBN(String maBN, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBN, 0));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal ThongtinBN1()
        {
            // MarkAsChild();

            _maDT = "00001";
            _madantoc = "00025";
            _MaNhomDV1 = "";
            _MaNhomDV2 = "";
            _gt = true;
            //MarkOld();

        }

        internal ThongtinBN1(int OrderNumber,
  String maBN,
  String hoten,
  String sothe,
  String maBV,
  SmartDate giaTriDN,
  String diaChi,
            String diaChiC,
  String dienThoai,
  String RHD,
  String MaBAGD,
  String mail,
  Byte tuoi,
  SmartDate ngaySinh,
  Boolean gt,
  String baoTin,
  String maQG,
  String maTinh,
  String maHuyen,
              String maPXa,
  String maNN,
  String tienSu,
  String tienSuThuoc,
  String tienSuGiaDinh,
  String nhomMau,
  String maBANoiT,
  String maKhoaVV,
  SmartDate ngayVV,
  String maBANgoaiT,
  SmartDate ngayKham,
  String ghichu,
  String maMay,
  SmartDate ngayLap,
  String nguoiLap,
  SmartDate ngayHuy,
  String nguoiHuy,
  SmartDate ngaySD,
  String nguoiSD,
  SmartDate ngaySD1,
  String nguoiSD1,
  Boolean huy,
  SmartDate ngayBANgoaiT,
  string mabhxh,

  string tenbv,
  string madt,
                             SmartDate giatriTN, string mabaql, string tendt,
  SmartDate ngaydk, string MaDonVi
 , string ngayDu5Nam
 , string maquanheqd
 , string maquanham
 , string socmt
            , string tenqg
 , string tentinh
            , string tenqh, string tenPXa,
            string tennn)
        {
            _tenQG = tenqg;
            _MaQuanHam = maquanham;
            _tenTinh = tentinh;
            _tenQH = tenqh;
            _tenPXa = tenPXa;
            _tenNN = tennn;
            _TenDT = tendt;
            _OrderNumber = OrderNumber;
            _maBN = maBN;
            _MaDonVi = MaDonVi;
            _ngayDu5Nam = ngayDu5Nam;
            _MaQuanHeQD = maquanheqd;
            _SoCMT = socmt;
            _maBAQL = mabaql;
            _hoten = hoten;
            _sothe = sothe;
            _maBV = maBV;
            _giaTriDN = giaTriDN;
            _diaChi = diaChi;
            _diaChiC = diaChiC;
            _dienThoai = dienThoai;
            _RHD = RHD;
            _MaBAGD = MaBAGD;
            _mail = mail;
            _tuoi = tuoi;
            _ngaySinh = ngaySinh;
            _gt = gt;
            _baoTin = baoTin;
            _maQG = maQG;
            _maTinh = maTinh;
            _maHuyen = maHuyen;
            _maPXa = maPXa;
            _maNN = maNN;
            _tienSu = tienSu;
            _tienSuThuoc = tienSuThuoc;
            _tienSuGiaDinh = tienSuGiaDinh;
            _nhomMau = nhomMau;
            _maBANoiT = maBANoiT;
            _maKhoaVV = maKhoaVV;
            _ngayVV = ngayVV;
            _maBANgoaiT = maBANgoaiT;
            _ngayKham = ngayKham;
            _NgayDK = ngaydk;
            _ghichu = ghichu;
            _maMay = maMay;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _huy = huy;
            _ngayBANgoaiT = ngayBANgoaiT;
            _mabhxh = mabhxh;
            _maDT = madt;
            _tenbv = tenbv;
            _giaTriTN = giatriTN;
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
                }
            }
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            public Criteria(String maBN, DateTime ngaydk, Byte loai)
            {
                _maBN = maBN;
                _ngaydk = ngaydk;
                _loai = loai;

            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBN.Equals(c._maBN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBN.ToString()).GetHashCode();
            }
        }
        protected class CriteriaTT
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
                }
            }
            private String _noiTT;
            public String noiTT
            {
                get
                {
                    return _noiTT;
                }
            }
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            public CriteriaTT(String maBN, DateTime ngaydk, Byte loai, string noitt)
            {
                _maBN = maBN;
                _ngaydk = ngaydk;
                _loai = loai;
                _noiTT = noitt;
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTT)
                {
                    CriteriaTT c = (CriteriaTT)obj;
                    if (!_maBN.Equals(c._maBN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTT", _maBN.ToString()).GetHashCode();
            }
        }

        protected class CriteriaKB
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
                }
            }
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private String _masokham;
            public String masokham
            {
                get
                {
                    return _masokham;
                }
            }
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _loaikq;
            public Byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            private int _stt;
            public int stt
            {
                get
                {
                    return _stt;
                }
            }
            public CriteriaKB(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn, byte loaikq, string makhoa)
            {
                _maBN = maBN;
                _ngaydk = ngaydk;
                _loai = loai;
                _masokham = masokham;
                _stt = stt;
                _loaikqcn = loaikqcn;
                _loaikq = loaikq;
                _makhoa = makhoa;

            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaKB)
                {
                    CriteriaKB c = (CriteriaKB)obj;
                    if (!_maBN.Equals(c._maBN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaKB", _maBN.ToString()).GetHashCode();
            }
        }


        protected class OtherCriteria
        {
            private String _maBN;
            public String maBN
            {
                get
                {
                    return _maBN;
                }
            }

            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }

            public OtherCriteria(String Mamay, String Nguoisd, String maBN, byte loai)
            {
                _maBN = maBN;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }

        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Retrieve an existing <see cref="ThongtinBN" /> Object based on data in the database.
        /// </summary>
        /// 

        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetThongtinBN(String _maBN);
            // public override IDataReader GetThongtinBN(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.MaBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    //if (dr.NextResult())
                    //{
                    dr.Close();
                    //  dr = null;
                    if (!_NgayDK.IsEmpty)
                        _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, _NgayDK.Date, "", crit.loai, crit.loaikqcn, 0, "");
                    else
                        _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, "", crit.loai, crit.loaikqcn, 0, "");
                    //  _KhamBenh = KhamBenh.GetKhamBenh(dr.GetString("masokham")   "", crit.loai, crit.loaikqcn);
                    if (_KhamBenh.MaSoKham == "")
                    {
                        _KhamBenh = KhamBenh.NewKhamBenh();
                        _KhamBenh.MaBV = _maBV;
                        _KhamBenh.MaDT = _maDT;
                        _KhamBenh.NgayDK = crit.ngaydk.ToString("dd/MM/yyyy");
                        _KhamBenh.mabhxh = _mabhxh;
                        _KhamBenh.Sothe = _sothe;
                        _KhamBenh.tenbv = _tenbv;
                        _KhamBenh.GiatriDN = _giaTriDN.ToString();
                        _KhamBenh.GiaTriTN = _giaTriTN.ToString();

                    }

                    //}
                    if (dr != null)
                    {
                        dr.Close();
                        //   dr = null;
                    }
                    MarkOld();
                    ValidationRules.CheckRules();
                    // dr.Close();
                    //DataProvider.Instance().CloseDB();
                }
            }
        }
        protected void DataPortal_Fetch(CriteriaTT crit)
        {
            // public abstract IDataReader GetThongtinBN(String _maBN);
            // public override IDataReader GetThongtinBN(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.MaBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    //if (dr.NextResult())
                    //{
                    dr.Close();
                    //  dr = null;
                    if (!_NgayDK.IsEmpty)
                        _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, _NgayDK.Date, crit.loai, crit.noiTT);
                    else
                        _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.loai, crit.noiTT);
                    //  _KhamBenh = KhamBenh.GetKhamBenh(dr.GetString("masokham")   "", crit.loai, crit.loaikqcn);
                    if (_KhamBenh.MaSoKham == "")
                    {
                        _KhamBenh = KhamBenh.NewKhamBenh();
                        _KhamBenh.MaBV = _maBV;
                        _KhamBenh.MaDT = _maDT;
                        _KhamBenh.NgayDK = crit.ngaydk.ToString("dd/MM/yyyy");
                        _KhamBenh.mabhxh = _mabhxh;
                        _KhamBenh.Sothe = _sothe;
                        _KhamBenh.tenbv = _tenbv;
                        _KhamBenh.GiatriDN = _giaTriDN.ToString();
                        _KhamBenh.GiaTriTN = _giaTriTN.ToString();

                    }

                    //}
                    if (dr != null)
                    {
                        dr.Close();
                        //   dr = null;
                    }
                    MarkOld();
                    ValidationRules.CheckRules();
                    // dr.Close();
                    //DataProvider.Instance().CloseDB();
                }
            }
        }
        protected void DataPortal_Fetch(CriteriaKB crit)
        {
            // public abstract IDataReader GetThongtinBN(String _maBN);
            // public override IDataReader GetThongtinBN(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.MaBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);

                    dr.Close();
                    // dr = null;

                    //    if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                    //    _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                    //else
                    //_KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.stt.ToString(), crit.loai, crit.loaikqcn, crit.loaikq,"");
                    if (!_NgayDK.IsEmpty)
                    {
                        //if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                        //    _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, _NgayDK.Date, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                        //else
                        //    _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, _NgayDK.Date, "", crit.loai, crit.loaikqcn, 0, "");
                        if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                            _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, _NgayDK.Date, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                        else
                            _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, _NgayDK.Date, crit.stt.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, "");

                    }

                    else
                    {

                        if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                            _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                        else
                            _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.stt.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, "");
                        //if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                        //    _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                        //else
                        //   _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, "", crit.loai, crit.loaikqcn, 0, "");

                    }


                    //_KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, "", crit.loai, crit.loaikqcn, 0, "");

                    if (_KhamBenh.MaSoKham == "")
                    {
                        _KhamBenh.MaBV = _maBV;
                        _KhamBenh.MaBN = _maBN;
                        _KhamBenh.MaDT = _maDT;
                        _KhamBenh.NgayDK = crit.ngaydk.ToString("dd/MM/yyyy");
                        _KhamBenh.mabhxh = _mabhxh;
                        _KhamBenh.Sothe = _sothe;
                        _KhamBenh.tenbv = _tenbv;
                        _KhamBenh.GiatriDN = _giaTriDN.ToString();
                        _KhamBenh.GiaTriTN = _giaTriTN.ToString();
                        _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                    }
                    if (dr != null)
                    {
                        dr.Close();
                        //   dr = null;
                    }
                    MarkOld();
                    ValidationRules.CheckRules();
                    //DataProvider.Instance().CloseDB();
                    // dr.Close();
                }
            }
        }
        protected void DataPortal_Fetch(OtherCriteria crit)
        {
            // public abstract IDataReader GetThongtinBN(String _maBN);
            // public override IDataReader GetThongtinBN(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.maBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr != null)
                    {
                        dr.Close();
                        //  dr = null;
                    }
                    _KhamBenh = null;
                    MarkOld();
                    ValidationRules.CheckRules();
                }
                // dr.Close();
                if (dr != null)
                {
                    dr.Close();
                    // dr = null;
                }
                //DataProvider.Instance().CloseDB();
            }
        }
        /// <summary>
        /// Load a <see cref="ThongtinBN" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("TenTinh") != null) _tenTinh = dr.GetString("TenTinh");
            if (dr.GetString("TenQH") != null) _tenQH = dr.GetString("TenQH");
            if (dr.GetString("TenPXa") != null) _tenPXa = dr.GetString("TenPXa");
            if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");
            if (dr.GetString("TenNN") != null) _tenNN = dr.GetString("TenNN");


            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
            if (dr.GetString("TenDT") != null) _TenDT = dr.GetString("TenDT");
            if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
            if (dr.GetSmartDate("GiaTriDN", true) != null) _giaTriDN = dr.GetSmartDate("GiaTriDN", true);
            if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
            if (dr.GetString("DiaChiC") != null) _diaChiC = dr.GetString("DiaChiC");
            if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
            if (dr.GetString("DTCQ") != null) _DTCQ = dr.GetString("DTCQ");
            if (dr.GetString("DTDD") != null) _DTDD = dr.GetString("DTDD");
            if (dr.GetString("RHD") != null) _RHD = dr.GetString("RHD");
            if (dr.GetString("MaBAGD") != null) _MaBAGD = dr.GetString("MaBAGD");
            if (dr.GetString("Mail") != null) _mail = dr.GetString("Mail");
            if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
            if (dr.GetString("mabaql") != null) _maBAQL = dr.GetString("mabaql");
            if (dr.GetString("SoCMT") != null) _SoCMT = dr.GetString("SoCMT");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");
            if (_MaDonVi.Length != 0 && _MaDonVi.Length >= 3)

                _MaNhomDV1 = _MaDonVi.Substring(0, 3);
            if (_MaDonVi.Length >= 6)

                _MaNhomDV2 = _MaDonVi.Substring(2, 3);

            //if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            //if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            //if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");
            if (dr.GetString("MaQuanheqd") != null) _MaQuanHeQD = dr.GetString("MaQuanHeQD");
            if (dr.GetString("MaQuanham") != null) _MaQuanHam = dr.GetString("MaQuanham");

            if (dr.GetSmartDate("GiatritN", true) != null) _giaTriTN = dr.GetSmartDate("GiatritN", true);
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("BaoTin") != null) _baoTin = dr.GetString("BaoTin");
            if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
            if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
            if (dr.GetString("MaHuyen") != null) _maHuyen = dr.GetString("MaHuyen");
            if (dr.GetString("MaPXa") != null) _maPXa = dr.GetString("MaPXa");
            if (dr.GetString("MaNN") != null) _maNN = dr.GetString("MaNN");
            if (dr.GetString("TienSu") != null) _tienSu = dr.GetString("TienSu");
            if (dr.GetString("TienSuThuoc") != null) _tienSuThuoc = dr.GetString("TienSuThuoc");
            if (dr.GetString("TienSuGiaDinh") != null) _tienSuGiaDinh = dr.GetString("TienSuGiaDinh");
            if (dr.GetString("NhomMau") != null) _nhomMau = dr.GetString("NhomMau");
            if (dr.GetString("MaBANoiT") != null) _maBANoiT = dr.GetString("MaBANoiT");
            if (dr.GetString("MaKhoaVV") != null) _maKhoaVV = dr.GetString("MaKhoaVV");
            if (dr.GetSmartDate("NgayVV", true) != null) _ngayVV = dr.GetSmartDate("NgayVV", true);
            if (dr.GetString("MaBANgoaiT") != null) _maBANgoaiT = dr.GetString("MaBANgoaiT");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetSmartDate("NgayDK", true) != null) _NgayDK = dr.GetSmartDate("NgayDK", true);

            if (dr.GetString("NoiLamViec") != null) _noiLamViec = dr.GetString("NoiLamViec");


            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayBANgoaiT", true) != null) _ngayBANgoaiT = dr.GetSmartDate("NgayBANgoaiT", true);
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("madantoc") != null) _madantoc = dr.GetString("madantoc");
            if (dr.GetString("hotenbome") != null) _hotenbome = dr.GetString("hotenbome");
            if (dr.GetString("tenbv") != null) _tenbv = dr.GetString("tenbv");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        }

        /// <summary>
        /// Insert the new <see cref="ThongtinBN" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            ValidationRules.CheckRules();
            _maDT = "00001";
            _maQG = "00084";
            _ngayKham.Date = DateTime.Now;
            //MarkOld();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongtinBN
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (_MaNhomDV2 != "" && _MaDonVi == "")
                _MaDonVi = _MaNhomDV2;
            if (_MaNhomDV1 != "" && _MaDonVi == "")
                _MaDonVi = _MaNhomDV1;
            if (HTC.ShareVariables.pub_spC == "PS")
            {
                _MaDonVi = _DTCQ;
                _ngayDu5Nam = DTDD;
            }
            if (HTC.ShareVariables.pub_spC == "YH")
                _maBN = DataProvider.Instance().InsertThongtinBN(_hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _DTDD, _DTCQ, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD, _madantoc, _hotenbome, _giaTriTN, _maBAQL, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);

            else
                _maBN = DataProvider.Instance().InsertThongtinBN(_hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD, _madantoc, _hotenbome, _giaTriTN, _maBAQL, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);
            MarkOld();// public abstract String InsertThongtinBN(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap);
                      // public override String InsertThongtinBN(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap);
                      // {
                      //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTHONGTINBN_CREATE",_hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _nguoiLap);
                      // }
                      //_KhamBenh.MaBN = _maBN; 
                      //  KhamBenh  tmp = _KhamBenh.Clone() ;
                      //  if (tmp.IsDirty)
                      //  {
                      //      tmp.ApplyEdit();
                      //      _KhamBenh = tmp.Save();
                      //  };

        }

        /// <summary>
        /// Update all changes made on <see cref="ThongtinBN" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBN
            if (IsDirty)
            {

                //if (base.IsDirty)
                //{
                if (_MaNhomDV2 != "" && _MaDonVi == "")
                    _MaDonVi = _MaNhomDV2;
                if (_MaNhomDV1 != "" && _MaDonVi == "")
                    _MaDonVi = _MaNhomDV1;
                if (HTC.ShareVariables.pub_spC == "PS")
                {
                    _MaDonVi = _DTCQ;
                    _ngayDu5Nam = DTDD;
                }
                if (HTC.ShareVariables.pub_spC == "YH")
                    DataProvider.Instance().UpdateThongtinBN(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _DTDD, _DTCQ, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _huy, _nguoiSD, _madantoc, _hotenbome, _giaTriTN, _maBAQL, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);
                else
                    DataProvider.Instance().UpdateThongtinBN(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _huy, _nguoiSD, _madantoc, _hotenbome, _giaTriTN, _maBAQL, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);

                // public abstract void UpdateThongtinBN(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateThongtinBN(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTHONGTINBN_UPDATE", _maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _huy, _nguoiSD );
                // }

                //  _KhamBenh.MaBN = _maBN;
                //}


            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maBN, 0));
        }

        /// <summary>
        /// Delete the <see cref="ThongtinBN" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBN
            DataProvider.Instance().DeleteThongtinBN(crit.MaMay, crit.NguoiSD, crit.maBN);
            // public abstract void DeleteThongtinBN(String _maBN);
            // public override void DeleteThongtinBN(String _maBN);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTHONGTINBN_DELETED", _maBN);
            // }
        }

        #endregion
    }

    [Serializable()]
    public  class BenhNhan1 : BusinessBase<BenhNhan1>
    {
        #region Business Methods

        #region State Fields
        private SmartDate _giaTriTN = new SmartDate(true);
        private String _maBN = String.Empty;
        private String _hoten = String.Empty;
        private String _sothe = String.Empty;
        private String _maBV = String.Empty;
        private SmartDate _giaTriDN = new SmartDate(true);
        private String _diaChi = String.Empty;
        private String _dienThoai = String.Empty;
        private String _RHD = String.Empty;
        private String _MaBAGD = String.Empty;
        private String _mail = String.Empty;
        private Byte _tuoi = 0;
        private SmartDate _ngaySinh = new SmartDate(true);

        private SmartDate _NgaySinhD = new SmartDate(true);
        private Boolean _gt = false;
        private Boolean _gtNu = false;
        private String _baoTin = String.Empty;
        private String _maQG = String.Empty;
        private String _maTinh = String.Empty;
        private String _maHuyen = String.Empty;
        private String _maPXa = String.Empty;

        private String _maNN = String.Empty;
        private String _tienSu = String.Empty;
        private String _tienSuThuoc = String.Empty;
        private String _tienSuGiaDinh = String.Empty;
        private String _nhomMau = String.Empty;

        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private Boolean _huy = false;
        private String _maDT = String.Empty;
        private String _hoTenBoMe = String.Empty;
        private String _maDanToc = String.Empty;
        private String _tenBV = String.Empty;
        private String _maBHXH = String.Empty;
        private String _tentinh = String.Empty;
        private String _tenQH = String.Empty;
        private String _tenPXa = String.Empty;
        private String _tenNN = String.Empty;
        private String _tenQG = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _MaQuanHeQD = String.Empty;
        private String _MaQuanHam = String.Empty;
        private String _MaDonVi = String.Empty;
        private String _SoCMT = String.Empty;
        private string _noiLamViec = String.Empty;
        private int _OrderNumber;
        private String _ngayDu5Nam = String.Empty;
        private String _maKV = String.Empty;
        private String _ngayMienCCT = String.Empty;

        private String _MaBHXHCha = String.Empty;
        private String _hotencha = String.Empty;
        #endregion

        #region Business Properties and Methods
        public string MaKV
        {
            get
            {
                CanReadProperty(true);
                return _maKV;
            }
            set
            {
                CanReadProperty("MaKV", true);
                if (!_maKV.Equals(value))
                {
                    _maKV = value;
                    PropertyHasChanged("MaKV");
                }
            }
        }
        public string NgayMienCCT
        {
            get
            {
                CanReadProperty(true);
                return _ngayMienCCT;
            }
            set
            {
                CanReadProperty("NgayMienCCT", true);
                if (!_ngayMienCCT.Equals(value))
                {
                    _ngayMienCCT = value;
                    PropertyHasChanged("NgayMienCCT");
                }
            }
        }
        public String ngayDu5Nam
        {
            get
            {
                CanReadProperty("ngayDu5Nam", true);
                return _ngayDu5Nam;
            }
            set
            {
                CanWriteProperty("ngayDu5Nam", true);
                if (_ngayDu5Nam != value)
                {
                    _ngayDu5Nam = value;
                    PropertyHasChanged("ngayDu5Nam");
                }
            }
        }
        public string NoiLamViec
        {
            get
            {
                CanReadProperty(true);
                return _noiLamViec;
            }
            set
            {
                CanReadProperty("NoiLamViec", true);
                if (!_noiLamViec.Equals(value))
                {
                    _noiLamViec = value;
                    PropertyHasChanged("NoiLamViec");
                }
            }
        }
        public String MaQuanHeQD
        {
            get
            {
                CanReadProperty("MaQuanHeQD", true);
                return _MaQuanHeQD;
            }
            set
            {
                CanWriteProperty("MaQuanHeQD", true);
                if (_MaQuanHeQD != value)
                {
                    _MaQuanHeQD = value;
                    PropertyHasChanged("MaQuanHeQD");
                }
            }
        }
        public String MaQuanHam
        {
            get
            {
                CanReadProperty("MaQuanHam", true);
                return _MaQuanHam;
            }
            set
            {
                CanWriteProperty("MaQuanHam", true);
                if (_MaQuanHam != value)
                {
                    _MaQuanHam = value;
                    PropertyHasChanged("MaQuanHam");
                }
            }
        }
        public String MaDonVi
        {
            get
            {
                CanReadProperty("MaDonVi", true);
                return _MaDonVi;
            }
            set
            {
                CanWriteProperty("MaDonVi", true);
                if (_MaDonVi != value)
                {
                    _MaDonVi = value;
                    PropertyHasChanged("MaDonVi");
                }
            }
        }
        public String SoCMT
        {
            get
            {
                CanReadProperty("SoCMT", true);
                return _SoCMT;
            }
            set
            {
                CanWriteProperty("SoCMT", true);
                if (_SoCMT != value)
                {
                    _SoCMT = value;
                    PropertyHasChanged("SoCMT");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _maBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_maBN != value)
                {
                    _maBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }
        public String Hotencha
        {
            get
            {
                CanReadProperty("Hotencha", true);
                return _hotencha;
            }
            set
            {
                CanWriteProperty("Hotencha", true);
                if (_hotencha != value)
                {
                    _hotencha = value;
                    PropertyHasChanged("Hotencha");
                }
            }
        }

        public String MaBHXHCha
        {
            get
            {
                CanReadProperty("MaBHXHCha", true);
                return _MaBHXHCha;
            }
            set
            {
                CanWriteProperty("MaBHXHCha", true);
                if (_MaBHXHCha != value)
                {
                    _MaBHXHCha = value;
                    PropertyHasChanged("MaBHXHCha");
                }
            }
        }






        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
                }
            }
        }

        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _maBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_maBV != value)
                {
                    _maBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }

        public string GiaTriDN
        {
            get
            {
                CanReadProperty("GiaTriDN", true);
                return _giaTriDN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriDN", true);
                if (_giaTriDN.Text != value)
                {
                    _giaTriDN.Text = value;
                    PropertyHasChanged("GiaTriDN");
                }
            }
        }













        public String DiaChi
        {
            get
            {
                CanReadProperty("DiaChi", true);
                return _diaChi;
            }
            set
            {
                CanWriteProperty("DiaChi", true);
                if (_diaChi != value)
                {
                    _diaChi = value;
                    PropertyHasChanged("DiaChi");
                }
            }
        }

        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                return _dienThoai;
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_dienThoai != value)
                {
                    _dienThoai = value;
                    PropertyHasChanged("DienThoai");
                }
            }
        }

        public String RHD
        {
            get
            {
                CanReadProperty("RHD", true);
                return _RHD;
            }
            set
            {
                CanWriteProperty("RHD", true);
                if (_RHD != value)
                {
                    _RHD = value;
                    PropertyHasChanged("RHD");
                }
            }
        }

        public String MaBAGD
        {
            get
            {
                CanReadProperty("MaBAGD", true);
                return _MaBAGD;
            }
            set
            {
                CanWriteProperty("MaBAGD", true);
                if (_MaBAGD != value)
                {
                    _MaBAGD = value;
                    PropertyHasChanged("MaBAGD");
                }
            }
        }

        public String Mail
        {
            get
            {
                CanReadProperty("Mail", true);
                return _mail;
            }
            set
            {
                CanWriteProperty("Mail", true);
                if (_mail != value)
                {
                    _mail = value;
                    PropertyHasChanged("Mail");
                }
            }
        }

        public byte Tuoi
        {
            get
            {
                byte _Age = 0;
                //CanReadProperty("Tuoi", true);
                if (_ngaySinh.Date.Year != 1)
                    _Age = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                return _Age;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }

        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                //_ngaySinh.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    if (_ngaySinh.Date.Year != 1)
                        _tuoi = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                    PropertyHasChanged("NgaySinh");
                }
            }
        }




        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinhD", true);
                _NgaySinhD.FormatString = "dd/MM/yyyy HH:mm";
                _NgaySinhD = _ngaySinh;
                return _NgaySinhD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayDK", true);
            //    if (_ngayDK.Text != value)
            //    {
            //        _ngayDK.Text = value;
            //        PropertyHasChanged("NgayDK");
            //    }
            //}
        }
        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
                }
            }
        }

        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }

        }

        public String BaoTin
        {
            get
            {
                CanReadProperty("BaoTin", true);
                return _baoTin;
            }
            set
            {
                CanWriteProperty("BaoTin", true);
                if (_baoTin != value)
                {
                    _baoTin = value;
                    PropertyHasChanged("BaoTin");
                }
            }
        }

        public String MaQG
        {
            get
            {
                CanReadProperty("MaQG", true);
                return _maQG;
            }
            set
            {
                CanWriteProperty("MaQG", true);
                if (_maQG != value)
                {
                    _maQG = value;
                    PropertyHasChanged("MaQG");
                }
            }
        }

        public String MaTinh
        {
            get
            {
                CanReadProperty("MaTinh", true);
                return _maTinh;
            }
            set
            {
                CanWriteProperty("MaTinh", true);
                if (_maTinh != value)
                {
                    _maTinh = value;
                    PropertyHasChanged("MaTinh");
                }
            }
        }
        public String MaPXa
        {
            get
            {
                CanReadProperty("MaPXa", true);
                return _maPXa;
            }
            set
            {
                CanWriteProperty("MaPXa", true);
                if (_maPXa != value)
                {
                    _maPXa = value;
                    PropertyHasChanged("MaPXa");
                }
            }
        }

        public String MaHuyen
        {
            get
            {
                CanReadProperty("MaHuyen", true);
                return _maHuyen;
            }
            set
            {
                CanWriteProperty("MaHuyen", true);
                if (_maHuyen != value)
                {
                    _maHuyen = value;
                    PropertyHasChanged("MaHuyen");
                }
            }
        }

        public String MaNN
        {
            get
            {
                CanReadProperty("MaNN", true);
                return _maNN;
            }
            set
            {
                CanWriteProperty("MaNN", true);
                if (_maNN != value)
                {
                    _maNN = value;
                    PropertyHasChanged("MaNN");
                }
            }
        }

        public String TienSu
        {
            get
            {
                CanReadProperty("TienSu", true);
                return _tienSu;
            }
            set
            {
                CanWriteProperty("TienSu", true);
                if (_tienSu != value)
                {
                    _tienSu = value;
                    PropertyHasChanged("TienSu");
                }
            }
        }

        public String TienSuThuoc
        {
            get
            {
                CanReadProperty("TienSuThuoc", true);
                return _tienSuThuoc;
            }
            set
            {
                CanWriteProperty("TienSuThuoc", true);
                if (_tienSuThuoc != value)
                {
                    _tienSuThuoc = value;
                    PropertyHasChanged("TienSuThuoc");
                }
            }
        }

        public String TienSuGiaDinh
        {
            get
            {
                CanReadProperty("TienSuGiaDinh", true);
                return _tienSuGiaDinh;
            }
            set
            {
                CanWriteProperty("TienSuGiaDinh", true);
                if (_tienSuGiaDinh != value)
                {
                    _tienSuGiaDinh = value;
                    PropertyHasChanged("TienSuGiaDinh");
                }
            }
        }

        public String NhomMau
        {
            get
            {
                CanReadProperty("NhomMau", true);
                return _nhomMau;
            }
            set
            {
                CanWriteProperty("NhomMau", true);
                if (_nhomMau != value)
                {
                    _nhomMau = value;
                    PropertyHasChanged("NhomMau");
                }
            }
        }

        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("Ghichu");
                }
            }
        }

        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }

        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }

        public string NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
                    PropertyHasChanged("NgayHuy");
                }
            }
        }

        public String NguoiHuy
        {
            get
            {
                CanReadProperty("NguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("NguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("NguoiHuy");
                }
            }
        }

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }

        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }

        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        _ngaySD1.FormatString = "dd/MM/yyyy HH:mm:ss";
        //        return _ngaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value) 
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}

        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value) 
        //        {
        //            _nguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}

        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }

        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }

        public String HoTenBoMe
        {
            get
            {
                CanReadProperty("HoTenBoMe", true);
                return _hoTenBoMe;
            }
            set
            {
                CanWriteProperty("HoTenBoMe", true);
                if (_hoTenBoMe != value)
                {
                    _hoTenBoMe = value;
                    PropertyHasChanged("HoTenBoMe");
                }
            }
        }

        public String MaDanToc
        {
            get
            {
                CanReadProperty("MaDanToc", true);
                return _maDanToc;
            }
            set
            {
                CanWriteProperty("MaDanToc", true);
                if (_maDanToc != value)
                {
                    _maDanToc = value;
                    PropertyHasChanged("MaDanToc");
                }
            }
        }

        public String TenBV
        {
            get
            {
                CanReadProperty("TenBV", true);
                return _tenBV;
            }
            set
            {
                CanWriteProperty("TenBV", true);
                if (_tenBV != value)
                {
                    _tenBV = value;
                    PropertyHasChanged("TenBV");
                }
            }
        }

        public String MaBHXH
        {
            get
            {
                CanReadProperty("MaBHXH", true);
                return _maBHXH;
            }
            set
            {
                CanWriteProperty("MaBHXH", true);
                if (_maBHXH != value)
                {
                    _maBHXH = value;
                    PropertyHasChanged("MaBHXH");
                }
            }
        }

        public String TenTinh
        {
            get
            {
                CanReadProperty("TenTinh", true);
                return _tentinh;
            }
            set
            {
                CanWriteProperty("TenTinh", true);
                if (_tentinh != value)
                {
                    _tentinh = value;
                    PropertyHasChanged("TenTinh");
                }
            }
        }

        public String TenQH
        {
            get
            {
                CanReadProperty("TenQH", true);
                return _tenQH;
            }
            set
            {
                CanWriteProperty("TenQH", true);
                if (_tenQH != value)
                {
                    _tenQH = value;
                    PropertyHasChanged("TenQH");
                }
            }
        }
        public String TenPXa
        {
            get
            {
                CanReadProperty("TenPXa", true);
                return _tenPXa;
            }
            set
            {
                CanWriteProperty("TenPXa", true);
                if (_tenPXa != value)
                {
                    _tenPXa = value;
                    PropertyHasChanged("TenPXa");
                }
            }
        }
        public String TenNN
        {
            get
            {
                CanReadProperty("TenNN", true);
                return _tenNN;
            }
            set
            {
                CanWriteProperty("TenNN", true);
                if (_tenNN != value)
                {
                    _tenNN = value;
                    PropertyHasChanged("TenNN");
                }
            }
        }

        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }

        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _maBN;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhNhan1" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhNhan1 NewBenhNhan()
        {

            return DataPortal.Create<BenhNhan1>();
        }
        public static BenhNhan1 GetBenhNhan(String maBN)
        {
            return DataPortal.Fetch<BenhNhan1>(new Criteria(maBN));
        }

        /// <summary>
        /// Marks the <see cref="BenhNhan1" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhNhan(String maBN, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBN));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhNhan1()
        {
            // Prevent direct creation
        }

        internal BenhNhan1(
                     int OrderNumber,
                     String maBN,
                     String hoten,
                     String sothe,
                     String maBV,
                    SmartDate giaTriDN,
                   
                     String diaChi,
                     String dienThoai,
                     String RHD,
                     String MaBAGD,
                     String mail,
                     Byte tuoi,
                     SmartDate ngaySinh,
                     Boolean gt,
                     String baoTin,
                     String maQG,
                     String maTinh,
                     String maHuyen,
                     String MaPXa,
                     String maNN,
                     String tienSu,
                     String tienSuThuoc,
                     String tienSuGiaDinh,
                     String nhomMau,
                     String ghichu,
                     String maMay,
                     SmartDate ngayLap,
                     String nguoiLap,
                     SmartDate ngayHuy,
                     String nguoiHuy,
                     SmartDate ngaySD,
                     String nguoiSD,
                     SmartDate ngaySD1,
                     String nguoiSD1,
                     Boolean huy,
                     String maDT,
                     String hoTenBoMe,
                     String maDanToc,
                     String tenBV,
                     String maBHXH,
                     String tentinh,
                     String tenQH,
                     String tenPXa,
                     String tenNN,
                     String tenQG,
                     String tenNguoiLap,
                     String tenNguoiSD,
                     String tenNguoiHuy,
                             SmartDate giaTriTN, string madonvi
 , string maquanham
 , string maquanheqd
 , string socmt , string hotencha , string MaBHXHCha
                    //   SmartDate ngaySinhD

                    )
        {
            _maBN = maBN;
            _hoten = hoten;
            _sothe = sothe;
            _maBV = maBV;
            _MaDonVi = madonvi;
            _MaQuanHam = maquanham;
            _MaQuanHeQD = maquanheqd;
            _SoCMT = socmt;
            _giaTriDN = giaTriDN;
            _diaChi = diaChi;
            _dienThoai = dienThoai;
            _RHD = RHD;
            _MaBAGD = MaBAGD;
            _mail = mail;
            _tuoi = tuoi;
            _ngaySinh = ngaySinh;
            _gt = gt;
            _baoTin = baoTin;
            _maQG = maQG;
            _maTinh = maTinh;
            _maHuyen = maHuyen;
            _maPXa = MaPXa;
            _maNN = maNN;
            _tienSu = tienSu;
            _tienSuThuoc = tienSuThuoc;
            _tienSuGiaDinh = tienSuGiaDinh;
            _nhomMau = nhomMau;
            _ghichu = ghichu;
            _maMay = maMay;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _huy = huy;
            _maDT = maDT;
            _hoTenBoMe = hoTenBoMe;
            _maDanToc = maDanToc;
            _tenBV = tenBV;
            _maBHXH = maBHXH;
            _tentinh = tentinh;
            _tenQH = tenQH;
            _tenPXa = tenPXa;
            _tenNN = tenNN;
            _tenQG = tenQG;
            _tenNguoiLap = tenNguoiLap;
            _tenNguoiSD = tenNguoiSD;
            _tenNguoiHuy = tenNguoiHuy;
            _OrderNumber = OrderNumber;
            _giaTriTN = giaTriTN;
            _hotencha = hotencha;
            _MaBHXHCha = MaBHXHCha;
            //  _ngaySinhD = ngaySinhD;
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
                }
            }

            public Criteria(String maBN)
            {
                _maBN = maBN;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBN.Equals(c._maBN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBN.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBN;
            public String maBN
            {
                get
                {
                    return _maBN;
                }
            }

            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }

            public OtherCriteria(String Mamay, String Nguoisd, String maBN)
            {
                _maBN = maBN;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }

        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Retrieve an existing <see cref="BenhNhan" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhNhan(String _maBN);
            // public override IDataReader GetBenhNhan(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_GET", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhNhan(crit.MaBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="BenhNhan" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties

            //if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            //if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            //if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
            if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
            if (dr.GetSmartDate("GiaTriDN", true) != null) _giaTriDN = dr.GetSmartDate("GiaTriDN", true);
            if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
            if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
            if (dr.GetString("RHD") != null) _RHD = dr.GetString("RHD");
            if (dr.GetString("MaBAGD") != null) _MaBAGD = dr.GetString("MaBAGD");
            if (dr.GetString("Mail") != null) _mail = dr.GetString("Mail");
            if (dr.GetString("SoCMT") != null) _SoCMT = dr.GetString("SoCMT");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");
            if (dr.GetString("MaQuanHam") != null) _MaQuanHam = dr.GetString("MaQuanHam");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");

            if (dr.GetString("NoiLamViec") != null) _noiLamViec = dr.GetString("NoiLamViec");
            if (dr.GetString("Hotencha") != null) _hotencha = dr.GetString("Hotencha");
            if (dr.GetString("MaBHXHCha") != null) _MaBHXHCha = dr.GetString("MaBHXHCha");
            if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetSmartDate("NgaySinh", true) != null) _NgaySinhD = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("BaoTin") != null) _baoTin = dr.GetString("BaoTin");
            if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
            if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
            if (dr.GetString("MaHuyen") != null) _maHuyen = dr.GetString("MaHuyen");
            if (dr.GetString("MaPXa") != null) _maPXa = dr.GetString("MaPXa");
            if (dr.GetString("MaNN") != null) _maNN = dr.GetString("MaNN");
            if (dr.GetString("TienSu") != null) _tienSu = dr.GetString("TienSu");
            if (dr.GetString("TienSuThuoc") != null) _tienSuThuoc = dr.GetString("TienSuThuoc");
            if (dr.GetString("TienSuGiaDinh") != null) _tienSuGiaDinh = dr.GetString("TienSuGiaDinh");
            if (dr.GetString("NhomMau") != null) _nhomMau = dr.GetString("NhomMau");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("HoTenBoMe") != null) _hoTenBoMe = dr.GetString("HoTenBoMe");
            if (dr.GetString("MaDanToc") != null) _maDanToc = dr.GetString("MaDanToc");
            if (dr.GetString("TenBV") != null) _tenBV = dr.GetString("TenBV");
            if (dr.GetString("mabhxh") != null) _maBHXH = dr.GetString("mabhxh");
            if (dr.GetString("TenTinh") != null) _tentinh = dr.GetString("TenTinh");
            if (dr.GetString("TenQH") != null) _tenQH = dr.GetString("TenQH");
            if (dr.GetString("TenPXa") != null) _tenPXa = dr.GetString("TenPXa");
            if (dr.GetString("TenNN") != null) _tenNN = dr.GetString("TenNN");
            if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");
            dr.GetString("tenNguoiLap");
            dr.GetString("tenNguoiSD");
            dr.GetString("tenNguoiHuy");
            if (dr.GetSmartDate("GiaTriTN", true) != null) _giaTriTN = dr.GetSmartDate("GiaTriTN", true);
        }

        /// <summary>
        /// Insert the new <see cref="BenhNhan" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            ValidationRules.CheckRules();
            //MarkOld();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhNhan
            // Copy & paste ham duoi day vao file DataProvider.cs

            //_maBN = DataProvider.Instance().InsertBenhNhan(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD, _hoTenBoMe, _maDanToc, _giaTriTN, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);

            _maBN = InsertBenhNhan(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD, _hoTenBoMe, _maDanToc, _giaTriTN, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec, _hotencha, _MaBHXHCha);
            // public abstract String InsertBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, String _hoTenBoMe, String _maDanToc);
            // public override String InsertBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, String _hoTenBoMe, String _maDanToc)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_CREATE",_maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD , _hoTenBoMe, _maDanToc ));
            // }
        }



        public String InsertBenhNhan(string _maBN, string _hoten, string _sothe, string _maBV, SmartDate _giaTriDN, string _diaChi, string _dienThoai, string _RHD, string _MaBAGD, string _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, string _baoTin, string _maQG, string _maTinh, string _maHuyen, string _maPXa, string _maNN, string _tienSu, string _tienSuThuoc, string _tienSuGiaDinh, string _nhomMau, string _ghichu, string _maMay, string _nguoiSD, string _hoTenBoMe, string _maDanToc, SmartDate _giaTriTN, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noiLamViec, string _hotencha, string _MaBHXHCha)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_CREATE_130", _maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD, _hoTenBoMe, _maDanToc, _giaTriTN.DBValue, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec, _hotencha, _MaBHXHCha));
        }






        /// <summary>
        /// Update all changes made on <see cref="BenhNhan" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan
            if (IsDirty)
            {
                DataProvider.Instance().UpdateBenhNhan(_maBN, _hoten, _sothe, _maBV, _giaTriDN ,_diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _huy, _nguoiSD, _hoTenBoMe, _maDanToc, _giaTriTN, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);
                // public abstract void UpdateBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy,  String _nguoiSD, String _maDT, String _hoTenBoMe, String _maDanToc);
                // public override void UpdateBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy,  String _nguoiSD,String _maDT, String _hoTenBoMe, String _maDanToc)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_UPDATE", _maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay,_huy, _nguoiSD ,  _hoTenBoMe, _maDanToc);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maBN));
        }

        /// <summary>
        /// Delete the <see cref="BenhNhan" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan
            DataProvider.Instance().DeleteBenhNhan(crit.MaMay, crit.NguoiSD, crit.maBN);
            // public abstract void DeleteBenhNhan(String _maBN);
            // public override void DeleteBenhNhan(String _maBN)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_DELETED", _maBN);
            // }
        }

        #endregion
    }


    [Serializable()]
    public  class BenhAn_SoSinh2 : BusinessBase<BenhAn_SoSinh2>
    {
        #region Business Methods

        #region State Fields

        private String _MaBA = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private SmartDate _ngayKham = new SmartDate(true);


        private SmartDate _ngayKhamD = new SmartDate(true);
        private String _bSKham = String.Empty;
        private String _lyDoKham = String.Empty;
        private String _meMach = String.Empty;
        private String _meDa = String.Empty;
        private String _benhSu = String.Empty;
        private String _meNiemMac = String.Empty;
        private String _meApHuyet = String.Empty;
        private String _meNhietDo = String.Empty;
        private String _meNhipTho = String.Empty;
        private String _meCanNang = String.Empty;
        private String _meChieuCao = String.Empty;
        private Boolean _mePhu = false;
        private String _meToanThan = String.Empty;
        private String _meToanTrang = String.Empty;
        private String _meCao = String.Empty;
        private String _meTim = String.Empty;
        private String _meGan = String.Empty;
        private String _mePhoi = String.Empty;
        private String _meThan = String.Empty;
        private String _meNuocOi = String.Empty;
        private String _meKieuOiVo = String.Empty;
        private String _meTieng = String.Empty;
        private String _meCachDe = String.Empty;
        private SmartDate _meGioDe = new SmartDate(true);
        private String _meLyDo = String.Empty;
        private String _meNguoiDoDe = String.Empty;
        private String _meApgar1 = String.Empty;
        private String _meApgar5 = String.Empty;
        private Boolean _hutDich = false;
        private Boolean _hutDichK = false;
        private Boolean _xoaBop = false;
        private Boolean _xoaBopK = false;
        private Boolean _tho = false;
        private Boolean _thoK = false;
        private Boolean _diTat = false;
        private Boolean _diTatK = false;
        private Boolean _datNoiKhiQuan = false;
        private Boolean _bopBong = false;
        private Boolean _diTathaumon = false;
        private Boolean _datNoiKhiQuanK = false;
        private Boolean _bopBongK = false;
        private Boolean _diTathaumonK = false;
        private String _cuThe = String.Empty;
        private String _nguoiChuyen = String.Empty;
        private String _nhipTim = String.Empty;
        private String _xuongKhop = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _nhipTho = String.Empty;
        private String _canNang = String.Empty;
        private String _chieuCao = String.Empty;
        private Boolean _phu = false;
        private String _toanThan = String.Empty;
        private String _toanTrang = String.Empty;
        private String _vongDau = String.Empty;
        private String _vongNguc = String.Empty;
        private Byte _da = 0;
        private Boolean _daH = false;
        private Boolean _daX = false;
        private Boolean _daV = false;
        private Boolean _daT = false;
        private String _nghePhoi = String.Empty;
        private String _chiSoSilerman = String.Empty;
        private String _bung = String.Empty;
        private String _sinhDucNgoai = String.Empty;
        private String _phanXa = String.Empty;
        private String _truongLucCo = String.Empty;
        private String _boPhanKhac = String.Empty;
        private String _tuoiThai = String.Empty;
        private String _dieuTri = String.Empty;
        private String _chanDoan = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

        private String _benhsu = String.Empty;
        private Int32 _hohapnhiptho = 0;
        private String _mabenhICD = String.Empty;
        private SmartDate _methoigianvooi = new SmartDate(true);
        private String _MeApgar10 = String.Empty;
        private Byte _LoaiTinhTrangKhiSinh = 0;
        private Boolean _HoiSinhKhac = false;
        private String _CanNangVaoKhoa = String.Empty;
        private String _DienBien = String.Empty;
        private Byte _VaoVienNgayThuCuaBenh = 0;
        private String _CacXetNghiemCanLamSangCanLam = String.Empty;
        private String _DinhDuongSauSinh = String.Empty;
        private String _TinhHinhKhiVaoKhoa = String.Empty;
        private String _TinhTrangToanThan = String.Empty;
        private String _TomTat = String.Empty;
        private Byte _CachDe = 0;
        private Byte _LanSinh = 0;
        private Byte _Soconsong = 0;
        private String _Noisinh = String.Empty;
        private String _Tinhtrangcon = String.Empty;

        private String _Phauthuat = String.Empty;
        private bool IsDirty;

        private String _GDRV = String.Empty;
        private Boolean _meCachDeThuong = false;

        private Boolean _meCachDeFoocxep = false;
        private Boolean _meCachDeGiachut = false;
        private Boolean _meCachDeMo = false;
        private Boolean _meCachDeChihuy = false;

        public String GDRV
        {
            get
            {
                CanReadProperty("GDRV", true);
                return _GDRV;
            }
            set
            {
                CanWriteProperty("GDRV", true);
                if (_GDRV != value)
                {
                    _GDRV = value;
                    PropertyHasChanged("GDRV");
                }
            }
        }

        #endregion

        #region Business Properties and Methods

        public String MaBA
        {
            get
            {
                CanReadProperty("MaBA", true);
                return _MaBA;
            }
            set
            {
                CanWriteProperty("MaBA", true);
                if (_MaBA != value)
                {
                    _MaBA = value;
                    PropertyHasChanged("MaBA");
                }
            }
        }

        public Int32 STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _sTT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_sTT != value)
                {
                    _sTT = value;
                    PropertyHasChanged("STT");
                }
            }
        }

        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _sTTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                    PropertyHasChanged("STTKhoa");
                }
            }
        }

        public string NgayKham
        {
            get
            {
                CanReadProperty("NgayKham", true);
                return _ngayKham.Text;
            }
            set
            {
                CanWriteProperty("NgayKham", true);
                if (_ngayKham.Text != value)
                {
                    _ngayKham.Text = value;
                    PropertyHasChanged("NgayKham");
                }
            }
        }



        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham;
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";

                return _ngayKhamD.Text;
            }

        }
        public String BSKham
        {
            get
            {
                CanReadProperty("BSKham", true);
                return _bSKham;
            }
            set
            {
                CanWriteProperty("BSKham", true);
                if (_bSKham != value)
                {
                    _bSKham = value;
                    PropertyHasChanged("BSKham");
                }
            }
        }

        public String LyDoKham
        {
            get
            {
                CanReadProperty("LyDoKham", true);
                return _lyDoKham;
            }
            set
            {
                CanWriteProperty("LyDoKham", true);
                if (_lyDoKham != value)
                {
                    _lyDoKham = value;
                    PropertyHasChanged("LyDoKham");
                }
            }
        }
        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _benhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_benhSu != value)
                {
                    _benhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }

        public String MeMach
        {
            get
            {
                CanReadProperty("MeMach", true);
                return _meMach;
            }
            set
            {
                CanWriteProperty("MeMach", true);
                if (_meMach != value)
                {
                    _meMach = value;
                    PropertyHasChanged("MeMach");
                }
            }
        }

        public String MeDa
        {
            get
            {
                CanReadProperty("MeDa", true);
                return _meDa;
            }
            set
            {
                CanWriteProperty("MeDa", true);
                if (_meDa != value)
                {
                    _meDa = value;
                    PropertyHasChanged("MeDa");
                }
            }
        }

        public String MeNiemMac
        {
            get
            {
                CanReadProperty("MeNiemMac", true);
                return _meNiemMac;
            }
            set
            {
                CanWriteProperty("MeNiemMac", true);
                if (_meNiemMac != value)
                {
                    _meNiemMac = value;
                    PropertyHasChanged("MeNiemMac");
                }
            }
        }

        public String MeApHuyet
        {
            get
            {
                CanReadProperty("MeApHuyet", true);
                return _meApHuyet;
            }
            set
            {
                CanWriteProperty("MeApHuyet", true);
                if (_meApHuyet != value)
                {
                    _meApHuyet = value;
                    PropertyHasChanged("MeApHuyet");
                }
            }
        }

        public String MeNhietDo
        {
            get
            {
                CanReadProperty("MeNhietDo", true);
                return _meNhietDo;
            }
            set
            {
                CanWriteProperty("MeNhietDo", true);
                if (_meNhietDo != value)
                {
                    _meNhietDo = value;
                    PropertyHasChanged("MeNhietDo");
                }
            }
        }

        public String MeNhipTho
        {
            get
            {
                CanReadProperty("MeNhipTho", true);
                return _meNhipTho;
            }
            set
            {
                CanWriteProperty("MeNhipTho", true);
                if (_meNhipTho != value)
                {
                    _meNhipTho = value;
                    PropertyHasChanged("MeNhipTho");
                }
            }
        }

        public String MeCanNang
        {
            get
            {
                CanReadProperty("MeCanNang", true);
                return _meCanNang;
            }
            set
            {
                CanWriteProperty("MeCanNang", true);
                if (_meCanNang != value)
                {
                    _meCanNang = value;
                    PropertyHasChanged("MeCanNang");
                }
            }
        }

        public String MeChieuCao
        {
            get
            {
                CanReadProperty("MeChieuCao", true);
                return _meChieuCao;
            }
            set
            {
                CanWriteProperty("MeChieuCao", true);
                if (_meChieuCao != value)
                {
                    _meChieuCao = value;
                    PropertyHasChanged("MeChieuCao");
                }
            }
        }

        public Boolean MePhu
        {
            get
            {
                CanReadProperty("MePhu", true);
                return _mePhu;
            }
            set
            {
                CanWriteProperty("MePhu", true);
                if (_mePhu != value)
                {
                    _mePhu = value;
                    PropertyHasChanged("MePhu");
                }
            }
        }

        public String MeToanThan
        {
            get
            {
                CanReadProperty("MeToanThan", true);
                return _meToanThan;
            }
            set
            {
                CanWriteProperty("MeToanThan", true);
                if (_meToanThan != value)
                {
                    _meToanThan = value;
                    PropertyHasChanged("MeToanThan");
                }
            }
        }

        public String MeToanTrang
        {
            get
            {
                CanReadProperty("MeToanTrang", true);
                return _meToanTrang;
            }
            set
            {
                CanWriteProperty("MeToanTrang", true);
                if (_meToanTrang != value)
                {
                    _meToanTrang = value;
                    PropertyHasChanged("MeToanTrang");
                }
            }
        }

        public String MeCao
        {
            get
            {
                CanReadProperty("MeCao", true);
                return _meCao;
            }
            set
            {
                CanWriteProperty("MeCao", true);
                if (_meCao != value)
                {
                    _meCao = value;
                    PropertyHasChanged("MeCao");
                }
            }
        }

        public String MeTim
        {
            get
            {
                CanReadProperty("MeTim", true);
                return _meTim;
            }
            set
            {
                CanWriteProperty("MeTim", true);
                if (_meTim != value)
                {
                    _meTim = value;
                    PropertyHasChanged("MeTim");
                }
            }
        }

        public String MeGan
        {
            get
            {
                CanReadProperty("MeGan", true);
                return _meGan;
            }
            set
            {
                CanWriteProperty("MeGan", true);
                if (_meGan != value)
                {
                    _meGan = value;
                    PropertyHasChanged("MeGan");
                }
            }
        }

        public String MePhoi
        {
            get
            {
                CanReadProperty("MePhoi", true);
                return _mePhoi;
            }
            set
            {
                CanWriteProperty("MePhoi", true);
                if (_mePhoi != value)
                {
                    _mePhoi = value;
                    PropertyHasChanged("MePhoi");
                }
            }
        }

        public String MeThan
        {
            get
            {
                CanReadProperty("MeThan", true);
                return _meThan;
            }
            set
            {
                CanWriteProperty("MeThan", true);
                if (_meThan != value)
                {
                    _meThan = value;
                    PropertyHasChanged("MeThan");
                }
            }
        }

        public String MeNuocOi
        {
            get
            {
                CanReadProperty("MeNuocOi", true);
                return _meNuocOi;
            }
            set
            {
                CanWriteProperty("MeNuocOi", true);
                if (_meNuocOi != value)
                {
                    _meNuocOi = value;
                    PropertyHasChanged("MeNuocOi");
                }
            }
        }

        public String MeKieuOiVo
        {
            get
            {
                CanReadProperty("MeKieuOiVo", true);
                return _meKieuOiVo;
            }
            set
            {
                CanWriteProperty("MeKieuOiVo", true);
                if (_meKieuOiVo != value)
                {
                    _meKieuOiVo = value;
                    PropertyHasChanged("MeKieuOiVo");
                }
            }
        }

        public String MeTieng
        {
            get
            {
                CanReadProperty("MeTieng", true);
                return _meTieng;
            }
            set
            {
                CanWriteProperty("MeTieng", true);
                if (_meTieng != value)
                {
                    _meTieng = value;
                    PropertyHasChanged("MeTieng");
                }
            }
        }

        public String MeCachDe
        {
            get
            {
                CanReadProperty("MeCachDe", true);
                return _meCachDe;
            }
            set
            {
                CanWriteProperty("MeCachDe", true);
                if (_meCachDe != value)
                {
                    _meCachDe = value;
                    PropertyHasChanged("MeCachDe");
                }
            }
        }




        public string MeGioDe
        {
            get
            {
                CanReadProperty("MeGioDe", true);
                return _meGioDe.Text;
            }
            set
            {
                CanWriteProperty("MeGioDe", true);
                if (_meGioDe.Text != value)
                {
                    _meGioDe.Text = value;
                    PropertyHasChanged("MeGioDe");
                }
            }
        }




        public String MeLyDo
        {
            get
            {
                CanReadProperty("MeLyDo", true);
                return _meLyDo;
            }
            set
            {
                CanWriteProperty("MeLyDo", true);
                if (_meLyDo != value)
                {
                    _meLyDo = value;
                    PropertyHasChanged("MeLyDo");
                }
            }
        }

        public String MeNguoiDoDe
        {
            get
            {
                CanReadProperty("MeNguoiDoDe", true);
                return _meNguoiDoDe;
            }
            set
            {
                CanWriteProperty("MeNguoiDoDe", true);
                if (_meNguoiDoDe != value)
                {
                    _meNguoiDoDe = value;
                    PropertyHasChanged("MeNguoiDoDe");
                }
            }
        }

        public String MeApgar1
        {
            get
            {
                CanReadProperty("MeApgar1", true);
                return _meApgar1;
            }
            set
            {
                CanWriteProperty("MeApgar1", true);
                if (_meApgar1 != value)
                {
                    _meApgar1 = value;
                    PropertyHasChanged("MeApgar1");
                }
            }
        }

        public String MeApgar5
        {
            get
            {
                CanReadProperty("MeApgar5", true);
                return _meApgar5;
            }
            set
            {
                CanWriteProperty("MeApgar5", true);
                if (_meApgar5 != value)
                {
                    _meApgar5 = value;
                    PropertyHasChanged("MeApgar5");
                }
            }
        }

        public Boolean HutDich
        {
            get
            {
                CanReadProperty("HutDich", true);
                return _hutDich;
            }
            set
            {
                CanWriteProperty("HutDich", true);
                if (_hutDich != value)
                {
                    _hutDich = value;
                    PropertyHasChanged("HutDich");
                }
            }
        }
        public Boolean HutDichK
        {
            get
            {
                CanReadProperty("HutDichK", true);
                if (_hutDich == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("HutDichK", true);
                if (_hutDichK != value)
                {
                    if (value == true)
                        _hutDich = false;
                    else
                        _hutDich = true;
                    _hutDichK = value;

                    PropertyHasChanged("HutDichK");
                }

            }
        }
        public Boolean XoaBop
        {
            get
            {
                CanReadProperty("XoaBop", true);
                return _xoaBop;
            }
            set
            {
                CanWriteProperty("XoaBop", true);
                if (_xoaBop != value)
                {
                    _xoaBop = value;
                    PropertyHasChanged("XoaBop");
                }
            }
        }
        public Boolean XoaBopK
        {
            get
            {
                CanReadProperty("XoaBopK", true);
                if (_xoaBop == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("XoaBopK", true);
                if (_xoaBopK != value)
                {
                    if (value == true)
                        _xoaBop = false;
                    else
                        _xoaBop = true;
                    _xoaBopK = value;

                    PropertyHasChanged("XoaBopK");
                }

            }
        }
        public Boolean Tho
        {
            get
            {
                CanReadProperty("Tho", true);
                return _tho;
            }
            set
            {
                CanWriteProperty("Tho", true);
                if (_tho != value)
                {
                    _tho = value;
                    PropertyHasChanged("Tho");
                }
            }
        }
        public Boolean ThoK
        {
            get
            {
                CanReadProperty("ThoK", true);
                if (_tho == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("ThoK", true);
                if (_thoK != value)
                {
                    if (value == true)
                        _tho = false;
                    else
                        _tho = true;
                    _thoK = value;

                    PropertyHasChanged("ThoK");
                }

            }
        }
        public Boolean DiTat
        {
            get
            {
                CanReadProperty("DiTat", true);
                return _diTat;
            }
            set
            {
                CanWriteProperty("DiTat", true);
                if (_diTat != value)
                {
                    _diTat = value;
                    PropertyHasChanged("DiTat");
                }
            }
        }
        public Boolean DiTatK
        {
            get
            {
                CanReadProperty("DiTatK", true);
                if (_diTat == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DiTatK", true);
                if (_diTatK != value)
                {
                    if (value == true)
                        _diTat = false;
                    else
                        _diTat = true;
                    _diTatK = value;

                    PropertyHasChanged("DiTatK");
                }

            }
        }
        public Boolean DatNoiKhiQuan
        {
            get
            {
                CanReadProperty("DatNoiKhiQuan", true);
                return _datNoiKhiQuan;
            }
            set
            {
                CanWriteProperty("DatNoiKhiQuan", true);
                if (_datNoiKhiQuan != value)
                {
                    _datNoiKhiQuan = value;
                    PropertyHasChanged("DatNoiKhiQuan");
                }
            }
        }
        public Boolean DatNoiKhiQuanK
        {
            get
            {
                CanReadProperty("DatNoiKhiQuanK", true);
                if (_datNoiKhiQuan == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DatNoiKhiQuanK", true);
                if (_datNoiKhiQuanK != value)
                {
                    if (value == true)
                        _datNoiKhiQuan = false;
                    else
                        _datNoiKhiQuan = true;
                    _datNoiKhiQuanK = value;

                    PropertyHasChanged("DatNoiKhiQuanK");
                }

            }
        }
        public Boolean BopBong
        {
            get
            {
                CanReadProperty("BopBong", true);
                return _bopBong;
            }
            set
            {
                CanWriteProperty("BopBong", true);
                if (_bopBong != value)
                {
                    _bopBong = value;
                    PropertyHasChanged("BopBong");
                }
            }
        }
        public Boolean BopBongK
        {
            get
            {
                CanReadProperty("BopBongK", true);
                if (_bopBong == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("BopBongK", true);
                if (_bopBongK != value)
                {
                    if (value == true)
                        _bopBong = false;
                    else
                        _bopBong = true;
                    _bopBongK = value;

                    PropertyHasChanged("BopBongK");
                }

            }
        }
        public Boolean DiTathaumon
        {
            get
            {
                CanReadProperty("DiTathaumon", true);
                return _diTathaumon;
            }
            set
            {
                CanWriteProperty("DiTathaumon", true);
                if (_diTathaumon != value)
                {
                    _diTathaumon = value;
                    PropertyHasChanged("DiTathaumon");
                }
            }
        }
        public Boolean DiTathaumonK
        {
            get
            {
                CanReadProperty("DiTathaumonK", true);
                if (_diTathaumon == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DiTathaumonK", true);
                if (_diTathaumonK != value)
                {
                    if (value == true)
                        _diTathaumon = false;
                    else
                        _diTathaumon = true;
                    _diTathaumonK = value;

                    PropertyHasChanged("DiTathaumonK");
                }

            }
        }
        public String CuThe
        {
            get
            {
                CanReadProperty("CuThe", true);
                return _cuThe;
            }
            set
            {
                CanWriteProperty("CuThe", true);
                if (_cuThe != value)
                {
                    _cuThe = value;
                    PropertyHasChanged("CuThe");
                }
            }
        }

        public String NguoiChuyen
        {
            get
            {
                CanReadProperty("NguoiChuyen", true);
                return _nguoiChuyen;
            }
            set
            {
                CanWriteProperty("NguoiChuyen", true);
                if (_nguoiChuyen != value)
                {
                    _nguoiChuyen = value;
                    PropertyHasChanged("NguoiChuyen");
                }
            }
        }

        public String NhipTim
        {
            get
            {
                CanReadProperty("NhipTim", true);
                return _nhipTim;
            }
            set
            {
                CanWriteProperty("NhipTim", true);
                if (_nhipTim != value)
                {
                    _nhipTim = value;
                    PropertyHasChanged("NhipTim");
                }
            }
        }

        public String XuongKhop
        {
            get
            {
                CanReadProperty("XuongKhop", true);
                return _xuongKhop;
            }
            set
            {
                CanWriteProperty("XuongKhop", true);
                if (_xuongKhop != value)
                {
                    _xuongKhop = value;
                    PropertyHasChanged("XuongKhop");
                }
            }
        }

        public String ApHuyet
        {
            get
            {
                CanReadProperty("ApHuyet", true);
                return _apHuyet;
            }
            set
            {
                CanWriteProperty("ApHuyet", true);
                if (_apHuyet != value)
                {
                    _apHuyet = value;
                    PropertyHasChanged("ApHuyet");
                }
            }
        }

        public String NhietDo
        {
            get
            {
                CanReadProperty("NhietDo", true);
                return _nhietDo;
            }
            set
            {
                CanWriteProperty("NhietDo", true);
                if (_nhietDo != value)
                {
                    _nhietDo = value;
                    PropertyHasChanged("NhietDo");
                }
            }
        }

        public String NhipTho
        {
            get
            {
                CanReadProperty("NhipTho", true);
                return _nhipTho;
            }
            set
            {
                CanWriteProperty("NhipTho", true);
                if (_nhipTho != value)
                {
                    _nhipTho = value;
                    PropertyHasChanged("NhipTho");
                }
            }
        }

        public String CanNang
        {
            get
            {
                CanReadProperty("CanNang", true);
                return _canNang;
            }
            set
            {
                CanWriteProperty("CanNang", true);
                if (_canNang != value)
                {
                    _canNang = value;
                    PropertyHasChanged("CanNang");
                }
            }
        }

        public String ChieuCao
        {
            get
            {
                CanReadProperty("ChieuCao", true);
                return _chieuCao;
            }
            set
            {
                CanWriteProperty("ChieuCao", true);
                if (_chieuCao != value)
                {
                    _chieuCao = value;
                    PropertyHasChanged("ChieuCao");
                }
            }
        }

        public Boolean Phu
        {
            get
            {
                CanReadProperty("Phu", true);
                return _phu;
            }
            set
            {
                CanWriteProperty("Phu", true);
                if (_phu != value)
                {
                    _phu = value;
                    PropertyHasChanged("Phu");
                }
            }
        }

        public String ToanThan
        {
            get
            {
                CanReadProperty("ToanThan", true);
                return _toanThan;
            }
            set
            {
                CanWriteProperty("ToanThan", true);
                if (_toanThan != value)
                {
                    _toanThan = value;
                    PropertyHasChanged("ToanThan");
                }
            }
        }

        public String ToanTrang
        {
            get
            {
                CanReadProperty("ToanTrang", true);
                return _toanTrang;
            }
            set
            {
                CanWriteProperty("ToanTrang", true);
                if (_toanTrang != value)
                {
                    _toanTrang = value;
                    PropertyHasChanged("ToanTrang");
                }
            }
        }

        public String VongDau
        {
            get
            {
                CanReadProperty("VongDau", true);
                return _vongDau;
            }
            set
            {
                CanWriteProperty("VongDau", true);
                if (_vongDau != value)
                {
                    _vongDau = value;
                    PropertyHasChanged("VongDau");
                }
            }
        }

        public String VongNguc
        {
            get
            {
                CanReadProperty("VongNguc", true);
                return _vongNguc;
            }
            set
            {
                CanWriteProperty("VongNguc", true);
                if (_vongNguc != value)
                {
                    _vongNguc = value;
                    PropertyHasChanged("VongNguc");
                }
            }
        }

        public Byte Da
        {
            get
            {
                CanReadProperty("Da", true);
                return _da;
            }
            set
            {
                CanWriteProperty("Da", true);
                if (_da != value)
                {
                    _da = value;
                    PropertyHasChanged("Da");
                }
            }
        }
        public Boolean DaH
        {
            get
            {
                CanReadProperty("DaH", true);

                if (_da == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaH", true);

                if (_daH != value)
                {

                    _daH = value;

                }
                if (_daH == true)
                    _da = 0;
                PropertyHasChanged("DaH");

            }
        }
        public Boolean DaX
        {
            get
            {
                CanReadProperty("DaX", true);

                if (_da == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaX", true);

                if (_daX != value)
                {

                    _daX = value;

                }
                if (_daX == true)
                    _da = 1;
                PropertyHasChanged("DaX");

            }
        }
        public Boolean DaV
        {
            get
            {
                CanReadProperty("DaV", true);

                if (_da == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaV", true);

                if (_daV != value)
                {

                    _daV = value;

                }
                if (_daV == true)
                    _da = 2;
                PropertyHasChanged("DaV");

            }
        }
        public Boolean DaT
        {
            get
            {
                CanReadProperty("DaT", true);

                if (_da == 3)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaT", true);

                if (_daT != value)
                {

                    _daT = value;

                }
                if (_daT == true)
                    _da = 3;
                PropertyHasChanged("DaT");

            }
        }
        public String NghePhoi
        {
            get
            {
                CanReadProperty("NghePhoi", true);
                return _nghePhoi;
            }
            set
            {
                CanWriteProperty("NghePhoi", true);
                if (_nghePhoi != value)
                {
                    _nghePhoi = value;
                    PropertyHasChanged("NghePhoi");
                }
            }
        }

        public String ChiSoSilerman
        {
            get
            {
                CanReadProperty("ChiSoSilerman", true);
                return _chiSoSilerman;
            }
            set
            {
                CanWriteProperty("ChiSoSilerman", true);
                if (_chiSoSilerman != value)
                {
                    _chiSoSilerman = value;
                    PropertyHasChanged("ChiSoSilerman");
                }
            }
        }

        public String Bung
        {
            get
            {
                CanReadProperty("Bung", true);
                return _bung;
            }
            set
            {
                CanWriteProperty("Bung", true);
                if (_bung != value)
                {
                    _bung = value;
                    PropertyHasChanged("Bung");
                }
            }
        }

        public String SinhDucNgoai
        {
            get
            {
                CanReadProperty("SinhDucNgoai", true);
                return _sinhDucNgoai;
            }
            set
            {
                CanWriteProperty("SinhDucNgoai", true);
                if (_sinhDucNgoai != value)
                {
                    _sinhDucNgoai = value;
                    PropertyHasChanged("SinhDucNgoai");
                }
            }
        }

        public String PhanXa
        {
            get
            {
                CanReadProperty("PhanXa", true);
                return _phanXa;
            }
            set
            {
                CanWriteProperty("PhanXa", true);
                if (_phanXa != value)
                {
                    _phanXa = value;
                    PropertyHasChanged("PhanXa");
                }
            }
        }

        public String TruongLucCo
        {
            get
            {
                CanReadProperty("TruongLucCo", true);
                return _truongLucCo;
            }
            set
            {
                CanWriteProperty("TruongLucCo", true);
                if (_truongLucCo != value)
                {
                    _truongLucCo = value;
                    PropertyHasChanged("TruongLucCo");
                }
            }
        }

        public String BoPhanKhac
        {
            get
            {
                CanReadProperty("BoPhanKhac", true);
                return _boPhanKhac;
            }
            set
            {
                CanWriteProperty("BoPhanKhac", true);
                if (_boPhanKhac != value)
                {
                    _boPhanKhac = value;
                    PropertyHasChanged("BoPhanKhac");
                }
            }
        }

        public String TuoiThai
        {
            get
            {
                CanReadProperty("TuoiThai", true);
                return _tuoiThai;
            }
            set
            {
                CanWriteProperty("TuoiThai", true);
                if (_tuoiThai != value)
                {
                    _tuoiThai = value;
                    PropertyHasChanged("TuoiThai");
                }
            }
        }

        public String DieuTri
        {
            get
            {
                CanReadProperty("DieuTri", true);
                return _dieuTri;
            }
            set
            {
                CanWriteProperty("DieuTri", true);
                if (_dieuTri != value)
                {
                    _dieuTri = value;
                    PropertyHasChanged("DieuTri");
                }
            }
        }

        public String ChanDoan
        {
            get
            {
                CanReadProperty("ChanDoan", true);
                return _chanDoan;
            }
            set
            {
                CanWriteProperty("ChanDoan", true);
                if (_chanDoan != value)
                {
                    _chanDoan = value;
                    PropertyHasChanged("ChanDoan");
                }
            }
        }

        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }

        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }

        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }

        public string NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                return _ngaySD1.Text;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1.Text != value)
                {
                    _ngaySD1.Text = value;
                    PropertyHasChanged("NgaySD1");
                }
            }
        }

        public String NguoiSD1
        {
            get
            {
                CanReadProperty("NguoiSD1", true);
                return _nguoiSD1;
            }
            set
            {
                CanWriteProperty("NguoiSD1", true);
                if (_nguoiSD1 != value)
                {
                    _nguoiSD1 = value;
                    PropertyHasChanged("NguoiSD1");
                }
            }
        }

        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        public String benhsu
        {
            get
            {
                CanReadProperty("benhsu", true);
                return _benhsu;
            }
            set
            {
                CanWriteProperty("benhsu", true);
                if (_benhsu != value)
                {
                    _benhsu = value;
                    PropertyHasChanged("benhsu");
                }
            }
        }

        public Int32 hohapnhiptho
        {
            get
            {
                CanReadProperty("hohapnhiptho", true);
                return _hohapnhiptho;
            }
            set
            {
                CanWriteProperty("hohapnhiptho", true);
                if (_hohapnhiptho != value)
                {
                    _hohapnhiptho = value;
                    PropertyHasChanged("hohapnhiptho");
                }
            }
        }

        public String mabenhICD
        {
            get
            {
                CanReadProperty("mabenhICD", true);
                return _mabenhICD;
            }
            set
            {
                CanWriteProperty("mabenhICD", true);
                if (_mabenhICD != value)
                {
                    _mabenhICD = value;
                    PropertyHasChanged("mabenhICD");
                }
            }
        }

        public string MeThoiGianVoOi
        {
            get
            {
                CanReadProperty("MeThoiGianVoOi", true);
                return _methoigianvooi.Text;
            }
            set
            {
                CanWriteProperty("MeThoiGianVoOi", true);
                if (_methoigianvooi.Text != value)
                {
                    _methoigianvooi.Text = value;
                    PropertyHasChanged("MeThoiGianVoOi");
                }
            }
        }
        public String MeApgar10
        {
            get
            {
                CanReadProperty("MeApgar10", true);
                return _MeApgar10;
            }
            set
            {
                CanWriteProperty("MeApgar10", true);
                if (_MeApgar10 != value)
                {
                    _MeApgar10 = value;
                    PropertyHasChanged("MeApgar10");
                }
            }
        }

        public Byte LoaiTinhTrangKhiSinh
        {
            get
            {
                CanReadProperty("LoaiTinhTrangKhiSinh", true);
                return _LoaiTinhTrangKhiSinh;
            }
            set
            {
                CanWriteProperty("LoaiTinhTrangKhiSinh", true);
                if (_LoaiTinhTrangKhiSinh != value)
                {
                    _LoaiTinhTrangKhiSinh = value;
                    PropertyHasChanged("LoaiTinhTrangKhiSinh");
                }
            }
        }

        public Boolean HoiSinhKhac
        {
            get
            {
                CanReadProperty("HoiSinhKhac", true);

                if (_da == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("HoiSinhKhac", true);

                if (_HoiSinhKhac != value)
                {

                    _HoiSinhKhac = value;

                }
                if (_HoiSinhKhac == true)
                    _da = 0;
                PropertyHasChanged("HoiSinhKhac");

            }
        }
        public String CanNangVaoKhoa
        {
            get
            {
                CanReadProperty("CanNangVaoKhoa", true);
                return _CanNangVaoKhoa;
            }
            set
            {
                CanWriteProperty("CanNangVaoKhoa", true);
                if (_CanNangVaoKhoa != value)
                {
                    _CanNangVaoKhoa = value;
                    PropertyHasChanged("CanNangVaoKhoa");
                }
            }
        }
        public String DienBien
        {
            get
            {
                CanReadProperty("DienBien", true);
                return _DienBien;
            }
            set
            {
                CanWriteProperty("DienBien", true);
                if (_DienBien != value)
                {
                    _DienBien = value;
                    PropertyHasChanged("DienBien");
                }
            }
        }
        public Byte VaoVienNgayThuCuaBenh
        {
            get
            {
                CanReadProperty("VaoVienNgayThuCuaBenh", true);
                return _VaoVienNgayThuCuaBenh;
            }
            set
            {
                CanWriteProperty("VaoVienNgayThuCuaBenh", true);
                if (_VaoVienNgayThuCuaBenh != value)
                {
                    _VaoVienNgayThuCuaBenh = value;
                    PropertyHasChanged("VaoVienNgayThuCuaBenh");
                }
            }
        }
        public String CacXetNghiemCanLamSangCanLam
        {
            get
            {
                CanReadProperty("CacXetNghiemCanLamSangCanLam", true);
                return _CacXetNghiemCanLamSangCanLam;
            }
            set
            {
                CanWriteProperty("CacXetNghiemCanLamSangCanLam", true);
                if (_CacXetNghiemCanLamSangCanLam != value)
                {
                    _CacXetNghiemCanLamSangCanLam = value;
                    PropertyHasChanged("CacXetNghiemCanLamSangCanLam");
                }
            }
        }
        public String DinhDuongSauSinh
        {
            get
            {
                CanReadProperty("DinhDuongSauSinh", true);
                return _DinhDuongSauSinh;
            }
            set
            {
                CanWriteProperty("DinhDuongSauSinh", true);
                if (_DinhDuongSauSinh != value)
                {
                    _DinhDuongSauSinh = value;
                    PropertyHasChanged("DinhDuongSauSinh");
                }
            }
        }
        public String TinhHinhKhiVaoKhoa
        {
            get
            {
                CanReadProperty("TinhHinhKhiVaoKhoa", true);
                return _TinhHinhKhiVaoKhoa;
            }
            set
            {
                CanWriteProperty("TinhHinhKhiVaoKhoa", true);
                if (_TinhHinhKhiVaoKhoa != value)
                {
                    _TinhHinhKhiVaoKhoa = value;
                    PropertyHasChanged("TinhHinhKhiVaoKhoa");
                }
            }
        }
        public String TinhTrangToanThan
        {
            get
            {
                CanReadProperty("TinhTrangToanThan", true);
                return _TinhTrangToanThan;
            }
            set
            {
                CanWriteProperty("TinhTrangToanThan", true);
                if (_TinhTrangToanThan != value)
                {
                    _TinhTrangToanThan = value;
                    PropertyHasChanged("TinhTrangToanThan");
                }
            }
        }
        public String TomTat
        {
            get
            {
                CanReadProperty("TomTat", true);
                return _TomTat;
            }
            set
            {
                CanWriteProperty("TomTat", true);
                if (_TomTat != value)
                {
                    _TomTat = value;
                    PropertyHasChanged("TomTat");
                }
            }
        }
        public Byte CachDe
        {
            get
            {
                CanReadProperty("CachDe", true);
                return _CachDe;
            }
            set
            {
                CanWriteProperty("CachDe", true);
                if (_CachDe != value)
                {
                    _CachDe = value;
                    PropertyHasChanged("CachDe");
                }
            }
        }
        public Byte LanSinh
        {
            get
            {
                CanReadProperty("LanSinh", true);
                return _LanSinh;
            }
            set
            {
                CanWriteProperty("LanSinh", true);
                if (_LanSinh != value)
                {
                    _LanSinh = value;
                    PropertyHasChanged("LanSinh");
                }
            }
        }
        public Byte Soconsong
        {
            get
            {
                CanReadProperty("Soconsong", true);
                return _Soconsong;
            }
            set
            {
                CanWriteProperty("Soconsong", true);
                if (_Soconsong != value)
                {
                    _Soconsong = value;
                    PropertyHasChanged("Soconsong");
                }
            }
        }

        public String Noisinh
        {
            get
            {
                CanReadProperty("Noisinh", true);
                return _Noisinh;
            }
            set
            {
                CanWriteProperty("Noisinh", true);
                if (_Noisinh != value)
                {
                    _Noisinh = value;
                    PropertyHasChanged("Noisinh");
                }
            }
        }
        public String Tinhtrangcon
        {
            get
            {
                CanReadProperty("Tinhtrangcon", true);
                return _Tinhtrangcon;
            }
            set
            {
                CanWriteProperty("Tinhtrangcon", true);
                if (_Tinhtrangcon != value)
                {
                    _Tinhtrangcon = value;
                    PropertyHasChanged("Tinhtrangcon");
                }
            }
        }



        public String Phauthuat
        {
            get
            {
                CanReadProperty("Phauthuat", true);
                return _Phauthuat;
            }
            set
            {
                CanWriteProperty("Phauthuat", true);
                if (_Phauthuat != value)
                {
                    _Phauthuat = value;
                    PropertyHasChanged("Phauthuat");
                }
            }
        }

        public Boolean MeCachDeThuong
        {
            get
            {
                CanReadProperty("MeCachDeThuong", true);


                return _meCachDeThuong;
            }
            set
            {
                CanWriteProperty("MeCachDeThuong", true);

                if (_meCachDeThuong != value)
                {

                    _meCachDeThuong = value;


                    if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                        if (_meCachDeThuong == true)
                            _GDRV = "1" + _GDRV.Substring(1, 4);
                        else
                            _GDRV = "0" + _GDRV.Substring(1, 4);
                    PropertyHasChanged("MeCachDeThuong");
                }
            }
        }

        public Boolean MeCachDeFoocxep
        {
            get
            {
                CanReadProperty("MeCachDeFoocxep", true);

                //if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                //if ((_GDRV.Substring(2, 1) == "1"))
                //    return true;
                //else
                //    return false;
                return _meCachDeFoocxep;
            }
            set
            {
                CanWriteProperty("MeCachDeFoocxep", true);

                if (_meCachDeFoocxep != value)
                {

                    _meCachDeFoocxep = value;


                    if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                        if (_meCachDeFoocxep == true)
                            _GDRV = _GDRV.Substring(0, 1) + "1" + _GDRV.Substring(2, 3);
                        else
                            _GDRV = _GDRV.Substring(0, 1) + "0" + _GDRV.Substring(2, 3);
                    PropertyHasChanged("MeCachDeFoocxep");
                }
            }
        }

        public Boolean MeCachDeGiachut
        {
            get
            {
                CanReadProperty("MeCachDeGiachut", true);
                ////if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                ////if ((_GDRV.Substring(3, 1) == "1"))
                ////    return true;
                ////else
                ////    return false;
                return _meCachDeGiachut;
            }
            set
            {
                CanWriteProperty("MeCachDeGiachut", true);

                if (_meCachDeGiachut != value)
                {

                    _meCachDeGiachut = value;

                }
                if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                    if (_meCachDeGiachut == true)
                        _GDRV = _GDRV.Substring(0, 2) + "1" + _GDRV.Substring(3, 2);
                    else
                        _GDRV = _GDRV.Substring(0, 2) + "0" + _GDRV.Substring(3, 2);
                PropertyHasChanged("MeCachDeGiachut");

            }
        }

        public Boolean MeCachDeMo
        {
            get
            {
                CanReadProperty("MeCachDeMo", true);
                //if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                //if ((_GDRV.Substring(4, 1) == "1"))
                //    return true;
                //else
                //    return false;
                return _meCachDeMo;
            }
            set
            {
                CanWriteProperty("MeCachDeMo", true);

                if (_meCachDeMo != value)
                {

                    _meCachDeMo = value;


                    if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                        if (_meCachDeMo == true)
                            _GDRV = _GDRV.Substring(0, 3) + "1" + _GDRV.Substring(4, 1);
                        else
                            _GDRV = _GDRV.Substring(0, 3) + "0" + _GDRV.Substring(4, 1);

                    PropertyHasChanged("MeCachDeMo");
                }
            }
        }

        public Boolean MeCachDeChihuy
        {
            get
            {
                CanReadProperty("MeCachDeChihuy", true);
                //if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                //if ((_GDRV.Substring(5, 1) == "1"))
                //    return true;
                //else
                //    return false;
                return _meCachDeChihuy;
            }
            set
            {
                CanWriteProperty("MeCachDeChihuy", true);

                if (_meCachDeChihuy != value)
                {

                    _meCachDeChihuy = value;


                    if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                        if (_meCachDeChihuy == true)
                            _GDRV = _GDRV.Substring(0, 4) + "1";
                        else
                            _GDRV = _GDRV.Substring(0, 4) + "0";
                    PropertyHasChanged("MeCachDeChihuy");
                }
            }
        }


        protected override Object GetIdValue()
        {
            return _MaBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_SoSinh2" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_SoSinh2 NewBenhAn_SoSinh()
        {
            return DataPortal.Create<BenhAn_SoSinh2>();
        }
        public static BenhAn_SoSinh2 GetBenhAn_SoSinh(String maBA, Int32 sTT, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_SoSinh2>(new Criteria(maBA, sTT, sTTKhoa));
        }

        /// <summary>
        /// Marks the <see cref="BenhAn_SoSinh2" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhAn_SoSinh(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, sTT, sTTKhoa));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhAn_SoSinh2()
        {
            // Prevent direct creation
        }
        internal BenhAn_SoSinh2(
                        int OrderNumber,
                         String maBA,
                     Int32 sTT,
                     Int32 sTTKhoa,
                     SmartDate ngayKham,
                     String bSKham,
                     String lyDoKham,
                     string benhsu,
                     String meMach,
                     String meDa,
                     String meNiemMac,
                     String meApHuyet,
                     String meNhietDo,
                     String meNhipTho,
                     String meCanNang,
                     String meChieuCao,
                     Boolean mePhu,
                     String meToanThan,
                     String meToanTrang,
                     String meCao,
                     String meTim,
                     String meGan,
                     String mePhoi,
                     String meThan,
                     String meBenhKhac,
                     String meKieuOiVo,
                     String meTieng,
                     String meCachDe,
                     SmartDate meGioDe,
                     String meLyDo,
                     String meNguoiDoDe,
                     String meApgar1,
                     String meApgar5,
                     Boolean hutDich,
                     Boolean xoaBop,
                     Boolean tho,
                     Boolean diTat,
                     Boolean datNoiKhiQuan,
                     Boolean bopBong,
                     Boolean diTathaumon,
                     String cuThe,
                     String nguoiChuyen,
                     String mach,
                     String niemMac,
                     String apHuyet,
                     String nhietDo,
                     String nhipTho,
                     String canNang,
                     String chieuCao,
                     Boolean phu,
                     String toanThan,
                     String toanTrang,
                     String vongDau,
                     String vongNguc,
                     Byte da,
                     String nghePhoi,
                     String chiSoSilerman,
                     String bung,
                     String sinhDucNgoai,
                     String phanXa,
                     String truongLucCo,
                     String boPhanKhac,
                     String tuoiThai,
                     String dieuTri,
                     String chanDoan,
                     String maMay,
                     Boolean huy,
                     SmartDate ngaySD,
                     String nguoiSD,
                     SmartDate ngaySD1,
                     String nguoiSD1,
                     String tenBSKham,
                     String tennguoiSD,

                     Int32 hohapnhiptho,
                     string mabenhICD,
                     SmartDate MeThoiGianVoOi,
                     byte loaiTinhTrangKhiSinh,
                     string MeApgar10,
                     bool hoiSinhKhac,
                     string canNangVaoKhoa,
                     string dienBien,
                     byte vaoVienNgayThuCuaBenh,
                     string cacXetNghiemCanLamSangCanLam,
                     string dinhDuongSauSinh,
                     string tinhHinhKhiVaoKhoa,
                     string tinhTrangToanThan,
                     string tomTat,
                     byte cachDe,
                     byte lanSinh,
                     byte soconsong,
                     string noisinh,
                     string tinhtrangcon,

                     string phauthuat


         )
        {
            _OrderNumber = OrderNumber;
            _MaBA = maBA;
            _sTT = sTT;

            _sTTKhoa = sTTKhoa;
            _ngayKham = ngayKham;
            _bSKham = bSKham;
            _lyDoKham = lyDoKham;
            _benhSu = benhsu;
            _meMach = meMach;
            _meDa = meDa;
            _meNiemMac = meNiemMac;
            _meApHuyet = meApHuyet;
            _meNhietDo = meNhietDo;
            _meNhipTho = meNhipTho;
            _meCanNang = meCanNang;
            _meChieuCao = meChieuCao;
            _mePhu = mePhu;
            _meToanThan = meToanThan;
            _meToanTrang = meToanTrang;
            _meCao = meCao;
            _meTim = meTim;
            _meGan = meGan;
            _mePhoi = mePhoi;
            _meThan = meThan;
            _meNuocOi = meBenhKhac;
            _meKieuOiVo = meKieuOiVo;
            _meTieng = meTieng;
            _meCachDe = meCachDe;
            _meGioDe = meGioDe;
            _meLyDo = meLyDo;
            _meNguoiDoDe = meNguoiDoDe;
            _meApgar1 = meApgar1;
            _meApgar5 = meApgar5;
            _hutDich = hutDich;
            _xoaBop = xoaBop;
            _tho = tho;
            _diTat = diTat;
            _datNoiKhiQuan = datNoiKhiQuan;
            _bopBong = bopBong;
            _diTathaumon = diTathaumon;
            _cuThe = cuThe;
            _nguoiChuyen = nguoiChuyen;
            _nhipTim = mach;
            _xuongKhop = niemMac;
            _apHuyet = apHuyet;
            _nhietDo = nhietDo;
            _nhipTho = nhipTho;
            _canNang = canNang;
            _chieuCao = chieuCao;
            _phu = phu;
            _toanThan = toanThan;
            _toanTrang = toanTrang;
            _vongDau = vongDau;
            _vongNguc = vongNguc;
            _da = da;
            _nghePhoi = nghePhoi;
            _chiSoSilerman = chiSoSilerman;
            _bung = bung;
            _sinhDucNgoai = sinhDucNgoai;
            _phanXa = phanXa;
            _truongLucCo = truongLucCo;
            _boPhanKhac = boPhanKhac;
            _tuoiThai = tuoiThai;
            _dieuTri = dieuTri;
            _chanDoan = chanDoan;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _tenBSKham = tenBSKham;
            _tennguoiSD = tennguoiSD;

            _hohapnhiptho = hohapnhiptho;
            _mabenhICD = mabenhICD;
            _MeApgar10 = MeApgar10;
            _methoigianvooi = MeThoiGianVoOi;
            _LoaiTinhTrangKhiSinh = loaiTinhTrangKhiSinh;
            _HoiSinhKhac = hoiSinhKhac;
            _CanNangVaoKhoa = canNangVaoKhoa;
            _DienBien = dienBien;
            _VaoVienNgayThuCuaBenh = vaoVienNgayThuCuaBenh;
            _CacXetNghiemCanLamSangCanLam = cacXetNghiemCanLamSangCanLam;
            _DinhDuongSauSinh = dinhDuongSauSinh;
            _TinhHinhKhiVaoKhoa = tinhHinhKhiVaoKhoa;
            _TinhTrangToanThan = tinhTrangToanThan;
            _TomTat = tomTat;
            _CachDe = cachDe;
            _LanSinh = lanSinh;
            _Soconsong = soconsong;
            _Noisinh = noisinh;
            _Tinhtrangcon = tinhtrangcon;

            _Phauthuat = phauthuat;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }

            public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    if (!_sTTKhoa.Equals(c._sTTKhoa))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }

            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

            }

        }
        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Retrieve an existing <see cref="BenhAn_SoSinh" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_GET", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_SoSinh(crit.MaBA, crit.STT, crit.STTKhoa)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }

        //private void MarkOld()
        //{
        //    //throw new NotImplementedException();
        //}

        /// <summary>
        /// Load a <see cref="BenhAn_SoSinh" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("maBa") != null) _MaBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
            if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
            if (dr.GetString("MeMach") != null) _meMach = dr.GetString("MeMach");
            if (dr.GetString("MeDa") != null) _meDa = dr.GetString("MeDa");
            if (dr.GetString("MeNiemMac") != null) _meNiemMac = dr.GetString("MeNiemMac");
            if (dr.GetString("MeApHuyet") != null) _meApHuyet = dr.GetString("MeApHuyet");
            if (dr.GetString("MeNhietDo") != null) _meNhietDo = dr.GetString("MeNhietDo");
            if (dr.GetString("MeNhipTho") != null) _meNhipTho = dr.GetString("MeNhipTho");
            if (dr.GetString("MeCanNang") != null) _meCanNang = dr.GetString("MeCanNang");
            if (dr.GetString("MeChieuCao") != null) _meChieuCao = dr.GetString("MeChieuCao");
            if (dr.GetBoolean("MePhu") != null) _mePhu = dr.GetBoolean("MePhu");
            if (dr.GetString("MeToanThan") != null) _meToanThan = dr.GetString("MeToanThan");
            if (dr.GetString("MeToanTrang") != null) _meToanTrang = dr.GetString("MeToanTrang");
            if (dr.GetString("MeCao") != null) _meCao = dr.GetString("MeCao");
            if (dr.GetString("MeTim") != null) _meTim = dr.GetString("MeTim");
            if (dr.GetString("MeGan") != null) _meGan = dr.GetString("MeGan");
            if (dr.GetString("MePhoi") != null) _mePhoi = dr.GetString("MePhoi");
            if (dr.GetString("MeThan") != null) _meThan = dr.GetString("MeThan");
            if (dr.GetString("meNuocOi") != null) _meNuocOi = dr.GetString("meNuocOi");
            if (dr.GetString("MeKieuOiVo") != null) _meKieuOiVo = dr.GetString("MeKieuOiVo");
            if (dr.GetString("MeTieng") != null) _meTieng = dr.GetString("MeTieng");
            if (dr.GetString("MeCachDe") != null) _meCachDe = dr.GetString("MeCachDe");
            if (dr.GetSmartDate("MeGioDe", true) != null) _meGioDe = dr.GetSmartDate("MeGioDe", true);

            if (dr.GetString("MeLyDo") != null) _meLyDo = dr.GetString("MeLyDo");
            if (dr.GetString("MeNguoiDoDe") != null) _meNguoiDoDe = dr.GetString("MeNguoiDoDe");
            if (dr.GetString("MeApgar1") != null) _meApgar1 = dr.GetString("MeApgar1");
            if (dr.GetString("MeApgar5") != null) _meApgar5 = dr.GetString("MeApgar5");
            if (dr.GetBoolean("HutDich") != null) _hutDich = dr.GetBoolean("HutDich");
            if (dr.GetBoolean("XoaBop") != null) _xoaBop = dr.GetBoolean("XoaBop");
            if (dr.GetBoolean("Tho") != null) _tho = dr.GetBoolean("Tho");
            if (dr.GetBoolean("DiTat") != null) _diTat = dr.GetBoolean("DiTat");
            if (dr.GetBoolean("DatNoiKhiQuan") != null) _datNoiKhiQuan = dr.GetBoolean("DatNoiKhiQuan");
            if (dr.GetBoolean("BopBong") != null) _bopBong = dr.GetBoolean("BopBong");
            if (dr.GetBoolean("DiTathaumon") != null) _diTathaumon = dr.GetBoolean("DiTathaumon");
            if (dr.GetString("CuThe") != null) _cuThe = dr.GetString("CuThe");
            if (dr.GetString("NguoiChuyen") != null) _nguoiChuyen = dr.GetString("NguoiChuyen");
            if (dr.GetString("nhipTim") != null) _nhipTim = dr.GetString("nhipTim");
            if (dr.GetString("xuongKhop") != null) _xuongKhop = dr.GetString("xuongKhop");
            if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
            if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
            if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetBoolean("Phu") != null) _phu = dr.GetBoolean("Phu");
            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
            if (dr.GetString("ToanTrang") != null) _toanTrang = dr.GetString("ToanTrang");
            if (dr.GetString("VongDau") != null) _vongDau = dr.GetString("VongDau");
            if (dr.GetString("VongNguc") != null) _vongNguc = dr.GetString("VongNguc");
            if (dr.GetByte("Da") != null) _da = dr.GetByte("Da");

            if (dr.GetString("NghePhoi") != null) _nghePhoi = dr.GetString("NghePhoi");
            if (dr.GetString("ChiSoSilerman") != null) _chiSoSilerman = dr.GetString("ChiSoSilerman");
            if (dr.GetString("Bung") != null) _bung = dr.GetString("Bung");
            if (dr.GetString("SinhDucNgoai") != null) _sinhDucNgoai = dr.GetString("SinhDucNgoai");
            if (dr.GetString("PhanXa") != null) _phanXa = dr.GetString("PhanXa");
            if (dr.GetString("TruongLucCo") != null) _truongLucCo = dr.GetString("TruongLucCo");
            if (dr.GetString("BoPhanKhac") != null) _boPhanKhac = dr.GetString("BoPhanKhac");
            if (dr.GetString("TuoiThai") != null) _tuoiThai = dr.GetString("TuoiThai");
            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetInt32("hohapnhiptho") != null) _hohapnhiptho = dr.GetInt32("hohapnhiptho");


            if (dr.GetString("mabenhICD") != null) _mabenhICD = dr.GetString("mabenhICD");
            if (dr.GetString("MeApgar10") != null) _MeApgar10 = dr.GetString("MeApgar10");
            if (dr.GetSmartDate("MeThoiGianVoOi", true) != null) _methoigianvooi = dr.GetSmartDate("MeThoiGianVoOi", true);
            if (dr.GetByte("loaiTinhTrangKhiSinh") != null) _LoaiTinhTrangKhiSinh = dr.GetByte("loaiTinhTrangKhiSinh");
            if (dr.GetBoolean("hoiSinhKhac") != null) _HoiSinhKhac = dr.GetBoolean("hoiSinhKhac");
            if (dr.GetString("canNangVaoKhoa") != null) _CanNangVaoKhoa = dr.GetString("canNangVaoKhoa");
            if (dr.GetString("dienBien") != null) _DienBien = dr.GetString("dienBien");
            if (dr.GetByte("vaoVienNgayThuCuaBenh") != null) _VaoVienNgayThuCuaBenh = dr.GetByte("vaoVienNgayThuCuaBenh");
            if (dr.GetString("cacXetNghiemCanLamSangCanLam") != null) _CacXetNghiemCanLamSangCanLam = dr.GetString("cacXetNghiemCanLamSangCanLam");
            if (dr.GetString("dinhDuongSauSinh") != null) _DinhDuongSauSinh = dr.GetString("dinhDuongSauSinh");
            if (dr.GetString("tinhHinhKhiVaoKhoa") != null) _TinhHinhKhiVaoKhoa = dr.GetString("tinhHinhKhiVaoKhoa");
            if (dr.GetString("tinhTrangToanThan") != null) _TinhTrangToanThan = dr.GetString("tinhTrangToanThan");
            if (dr.GetString("tomTat") != null) _TomTat = dr.GetString("tomTat");
            if (dr.GetByte("cachDe") != null) _CachDe = dr.GetByte("cachDe");
            if (dr.GetByte("lanSinh") != null) _LanSinh = dr.GetByte("lanSinh");
            if (dr.GetByte("soconsong") != null) _Soconsong = dr.GetByte("soconsong");
            if (dr.GetString("noisinh") != null) _Noisinh = dr.GetString("noisinh");
            if (dr.GetString("tinhtrangcon") != null) _Tinhtrangcon = dr.GetString("tinhtrangcon");

            if (dr.GetString("phauthuat") != null) _Phauthuat = dr.GetString("phauthuat");
        }

        /// <summary>
        /// Insert the new <see cref="BenhAn_SoSinh" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }



        protected override void DataPortal_Insert()
        {


            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_SoSinh
            // Copy & paste ham duoi day vao file DataProvider.cs

            // DataProvider.Instance().
            _MaBA =  InsertBenhAn_SoSinh(_MaBA, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham, _benhSu, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay, _nguoiSD, _CachDe, _LanSinh, _Soconsong, _Noisinh, _Tinhtrangcon);



         



            // public abstract String InsertBenhAn_SoSinh(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _nhipTim, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _mach, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meBenhKhac, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _mach, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay, _nguoiSD));
            // }
        }


        public String InsertBenhAn_SoSinh(String _maBA, Int32 _sTTKhoa,SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _benhSu, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, String _meKieuOiVo, String _meTieng, String _meCachDe,SmartDate _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD,Byte _CachDe, Byte _LanSinh , Byte _Soconsong ,String _Noisinh ,String _Tinhtrangcon )
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_CREATE_QD130", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _benhSu, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe.DBValue, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay, _nguoiSD, _CachDe, _LanSinh, _Soconsong, _Noisinh, _Tinhtrangcon));
        }


        /// <summary>
        /// Update all changes made on <see cref="BenhAn_SoSinh" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_SoSinh
            if (IsDirty)
            {


                DataProvider.Instance().UpdateBenhAn_SoSinh(_MaBA, _sTT, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham, _benhSu, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateBenhAn_SoSinh(String _maBA,Int32 _sTT,  Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _nhipTim, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay,Boolean _huy,  String _nguoiSD);
                // public override void UpdateBenhAn_SoSinh(String _maBA,Int32 _sTT,  Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _mach, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay,Boolean _huy,  String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_UPDATE", _maBA,_sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meBenhKhac, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _mach, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay,_huy,  _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _MaBA, _sTT, _sTTKhoa));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_SoSinh" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_SoSinh
            DataProvider.Instance().DeleteBenhAn_SoSinh(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
            // public abstract void DeleteBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_Deleted", _maBA, _sTT, _sTTKhoa);
            // }
        }

        internal static BenhAn_SoSinh GetBenhAn_SoSinh(string maBA)
        {
            throw new NotImplementedException();
        }

        #endregion
    }





    //private void WriteLog(string log)
    //{
    //    string logname = "LOG Tra Ra" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
    //    string fileName = HttpContext.Current.Request.MapPath(logname);
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
       // using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNHANVIEN_GetAll", true)))


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


    public DataTable spDMBASS_Update(string maba) 
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMBASS_Update";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@maba", maba));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }

    public DataTable spDMBN_Get(string mabn)
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMBN_Get";
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











