using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using HTC.Common;
using Telerik.Web.UI;
using System.Collections;
using Csla.Data;
using Csla.Validation;
using Csla;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.Style;
using Resources.RadGrid;

public partial class UI_Category_DMVTYT_frmDMVTYT : HTC.Common.Web.WebBase
{

    private const string ViewState_MaVT = "MaVT";
    public string _MaVT
    {
        get
        {
            if (ViewState[ViewState_MaVT] == null)
                ViewState[ViewState_MaVT] = "";
            return (string)ViewState[ViewState_MaVT];
        }
        set
        {
            ViewState[ViewState_MaVT] = value;
        }
    }

    private const string ViewState_dk = "dk";
    public string _dk
    {
        get
        {
            if (ViewState[ViewState_dk] == null)
                ViewState[ViewState_dk] = "";
            return (string)ViewState[ViewState_dk];
        }
        set
        {
            ViewState[ViewState_dk] = value;
        }
    }



    private const string ViewState_FilterSql = "_FilterSql";
    public string _FilterSql
    {
        get
        {
            if (ViewState[ViewState_FilterSql] == null)
            {
                ViewState[ViewState_FilterSql] = "";
            }

            return (string)ViewState[ViewState_FilterSql];
        }

        set
        {
            ViewState[ViewState_FilterSql] = value;
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
    private const string ViewState_Selected_Ma = "_Selected_Ma";
    public string _Selected_Ma
    {
        get
        {


            return (string)ViewState[ViewState_Selected_Ma];
        }

        set
        {
            ViewState[ViewState_Selected_Ma] = value;
        }

    }
    private const string ViewState_DMVTYT = "_DMVTYT";
    public DMVTYT _DMVTYT
    {
        get
        {
            if (ViewState[ViewState_DMVTYT] == null)
                ViewState[ViewState_DMVTYT] = DMVTYT.NewDMVTYT();


            return (DMVTYT)ViewState[ViewState_DMVTYT];
        }

        set
        {
            ViewState[ViewState_DMVTYT] = value;
        }

    }
    private const string ViewState_loai = "loai";
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
    private const string ViewState_DMVTYTList = "_DMVTYTList";


    public DMVTYTList _DMVTYTList
    {
        get
        {
            if (ViewState[ViewState_DMVTYTList] == null)
            {
                ViewState[ViewState_DMVTYTList] = DMVTYTList.FindDMVTYTByNhomVTFilter("", "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), _loai, pub_bQadmin);
            }

            return (DMVTYTList)ViewState[ViewState_DMVTYTList];
        }

        set
        {
            ViewState[ViewState_DMVTYTList] = value;
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        if (!IsPostBack)
        {


            if (Request.QueryString["loai"] != null)
                _loai = byte.Parse(Request.QueryString["loai"].ToString());

            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;

            LoadData();
            base.OnLoad(e);
        }
    }



    private void LoadData()
    {
        cboQuocGia.DataSource = GetDMQuocGia();// combo 
        cboQuocGia.DataBind();

        cboDMNguon.DataSource = GetDMNguonM();// combo 
        cboDMNguon.DataBind();

        cboDsnhom.DataSource = DMNhomListcb.GetListAll(_loai);
        cboDsnhom.DataBind();
        cboNhomVattu.DataSource = DMNhomListcb.GetList(_loai);
        cboNhomVattu.DataBind();
        cboDonVi.DataSource = DMDonvitinhListcb.GetList();
        cboDonVi.DataBind();
        cboDonVi2.DataSource = DMDonvitinhListcb.GetList();
        cboDonVi2.DataBind();
        cboNSX.DataSource = DMNhaSXListcb.GetList(_loai);
        cboNSX.DataBind();
        cboChungLoai.DataSource = DMChungLoaiListcb.GetList(_loai);
        cboChungLoai.DataBind();
        if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fThem)
            baraction.FindItemByValue("cmdAdd").Enabled = false;
        if (Pub_bQuyenForm != HTC.ShareVariables.KieuFormChiTiet.fDelete)
        {

            grdChiTiet.MasterTableView.GetColumn("Delete").Display = false;
        }
        if (pub_bQadmin != true)
        {
            grdChiTiet.MasterTableView.GetColumn("Huy").Display = false;

        }

    }
    private void LoadDetail()
    {
        if (_action == FormAction.INSERT)
            _DMVTYT = DMVTYT.NewDMVTYT();
        //else
        //	_DMVTYT = DMVTYT.GetDMVTYT(_Selected_Ma);
        cboNhomVattu.SelectedValue = _DMVTYT.MaNhom;
        cboNhomVattu.Text = DMNhom.GetDMNhom(_DMVTYT.MaNhom).tenNhom;
        cboNSX.SelectedValue = _DMVTYT.MaNSX;
        cboNSX.SelectedItem.Text = _DMVTYT.TenNSX;
        cboDonVi.SelectedValue = _DMVTYT.MaDVT;
        cboDonVi.SelectedItem.Text = _DMVTYT.tendvt;
        if (_DMVTYT.MaDVT2 != "")
        {
            cboDonVi2.SelectedValue = _DMVTYT.MaDVT2;
            cboDonVi2.SelectedItem.Text = DMDonvitinh.GetDMDonvitinh(_DMVTYT.MaDVT2).tenDVT;
        }
        cboChungLoai.SelectedValue = _DMVTYT.MaChungLoai;
        if (_DMVTYT.MaChungLoai != "")
        {
            cboChungLoai.DataSource = DMChungLoaiListcb.GetList(_loai);
            cboChungLoai.DataBind();
        }
        cboLoaihinh.SelectedValue = _DMVTYT.MaLH;
        txtMaVT.Text = _DMVTYT.MaVT;
        txtGhiChu.Text = _DMVTYT.Ghichu;
        txtMaQL.Text = _DMVTYT.maql;
        TxtNguong.Text = _DMVTYT.Nguong.ToString();
        txtQuyCach.Text = _DMVTYT.quycach;
        txtQuydoi.Text = _DMVTYT.Quydoi.ToString();
        txtTenTA.Text = _DMVTYT.TenTA;
        txtTenVT.Text = _DMVTYT.TenTM;
        chkHuy.Checked = _DMVTYT.Huy;
        chkKhongSD.Checked = _DMVTYT.KhongSD;
        chkVTYTBan.Checked = _DMVTYT.VTBan;
        chkVTYTCoHD.Checked = _DMVTYT.Handung;
        chkVTYTDuoc.Checked = _DMVTYT.VTDuoc;
        chkVTYTPhauthuat.Checked = _DMVTYT.VTPhauT;
        chkVTYTThuthuat.Checked = _DMVTYT.VTThuT;
        chkApdunggoi.Checked = _DMVTYT.ApDungGoi;
        chkCLS.Checked = _DMVTYT.VTCLS;
        chkDuyetNgoaiT.Checked = _DMVTYT.DuyetNgoaiT;
        chkDuyetNoiT.Checked = _DMVTYT.DuyetNoiT;
        txtDonGiaTT.Text = _DMVTYT.DonGiaTT.ToString("###,###");
        txtGiaNhap.Text = _DMVTYT.Gianhap.ToString("###,###");
        txtMaBYTe.Text = _DMVTYT.MaBYTe;
        txtQuyetDinh.Text = _DMVTYT.QuyetDinh;
        txtTenBH.Text = _DMVTYT.TenTMBH;
        txtMaBH.Text = _DMVTYT.MaBH;
        txtMaTDuong.Text = _DMVTYT.MaTDuong;
        txtQuyetDinhBH.Text = _DMVTYT.QuyetDinhBH;
        txtTenBYte.Text = _DMVTYT.TenBYTe;

        //txtMaHieuSP.Text = _DMVTYT.MaHieuSP;


        if (pub_bQadmin == false && HTC.ShareVariables.pub_spC == "YH" && _DMVTYT.IsNew == true)
        {
            _DMVTYT.KhongSD = true;
            chkKhongSD.Checked = true;
        }
        if (pub_bQadmin == true || HTC.ShareVariables.pub_spC == "PS")
            chkKhongSD.Visible = true;
        else
            chkKhongSD.Visible = true;



        DataTable dt = spDMVTYT_GetBC(_DMVTYT.MaVT);
        if (dt != null && dt.Rows.Count > 0)
        {

            string maquocgia = dt.Rows[0][0].ToString();
            string tenquocgia = dt.Rows[0][1].ToString();
            byte bh50 = Convert.ToByte(dt.Rows[0][2]);
            byte DinhMuc = Convert.ToByte(dt.Rows[0][3]);
            string MaNguon = dt.Rows[0][4].ToString();
            string TenNguon = dt.Rows[0][5].ToString();

            cboQuocGia.SelectedValue = maquocgia;
            cboQuocGia.Text = tenquocgia;

            txtbh50.Text = bh50.ToString();
            txtDinhMuc.Text = DinhMuc.ToString();

            cboDMNguon.SelectedValue = MaNguon;
            cboDMNguon.Text = TenNguon;

        }





    }
    private void UpdateData()
    {
        try
        {
            if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fSua)
                if (_DMVTYT.IsNew == false)
                    return;
            if (txtTenVT.Text == "" || cboDonVi.SelectedValue == "")
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            if ((cboNhomVattu.SelectedValue == "" || cboNhomVattu.SelectedValue == null) && HTC.ShareVariables.pub_spC == "HU")
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            _DMVTYT.MaNhom = cboNhomVattu.SelectedValue;
            _DMVTYT.MaNSX = cboNSX.SelectedValue;
            _DMVTYT.TenNSX = cboNSX.SelectedItem.Text;
            _DMVTYT.MaDVT = cboDonVi.SelectedValue;
            _DMVTYT.tendvt = cboDonVi.SelectedItem.Text;
            _DMVTYT.MaDVT2 = cboDonVi2.SelectedValue;
            _DMVTYT.MaChungLoai = cboChungLoai.SelectedValue;
            _DMVTYT.MaLH = cboLoaihinh.SelectedValue;
            _DMVTYT.MaVT = txtMaVT.Text;
            _DMVTYT.Ghichu = txtGhiChu.Text;
            _DMVTYT.maql = txtMaQL.Text;
            _DMVTYT.Nguong = decimal.Parse(TxtNguong.Text);
            _DMVTYT.quycach = txtQuyCach.Text;
            _DMVTYT.Quydoi = decimal.Parse(txtQuydoi.Text);
            _DMVTYT.TenTA = txtTenTA.Text;
            _DMVTYT.TenTM = txtTenVT.Text;
            _DMVTYT.Huy = chkHuy.Checked;
            _DMVTYT.KhongSD = chkKhongSD.Checked;
            _DMVTYT.VTBan = chkVTYTBan.Checked;
            _DMVTYT.Handung = chkVTYTCoHD.Checked;
            _DMVTYT.VTDuoc = chkVTYTDuoc.Checked;
            _DMVTYT.VTPhauT = chkVTYTPhauthuat.Checked;
            _DMVTYT.VTThuT = chkVTYTThuthuat.Checked;
            _DMVTYT.ApDungGoi = chkApdunggoi.Checked;
            _DMVTYT.VTCLS = chkCLS.Checked;
            _DMVTYT.DuyetNgoaiT = chkDuyetNgoaiT.Checked;
            _DMVTYT.DuyetNoiT = chkDuyetNoiT.Checked;
            _DMVTYT.loai = _loai;
            _DMVTYT.MaBYTe = txtMaBYTe.Text;
            _DMVTYT.QuyetDinh = txtQuyetDinh.Text;
            _DMVTYT.TenTMBH = txtTenBH.Text;
            _DMVTYT.MaBH = txtMaBH.Text;
            _DMVTYT.MaTDuong = txtMaTDuong.Text;
            _DMVTYT.QuyetDinhBH = txtQuyetDinhBH.Text;
            _DMVTYT.TenBYTe = txtTenBYte.Text;
            _DMVTYT.bh50 = byte.Parse(txtbh50.Text);
            _DMVTYT.DinhMuc = byte.Parse(txtDinhMuc.Text);
            _DMVTYT.MaNguon = cboDMNguon.SelectedValue;


            _DMVTYT.Gianhap = decimal.Parse(txtGiaNhap.Text == "" ? "0" : txtGiaNhap.Text);
            if (_action != FormAction.DELETE)
            {
                //_DMVTYT.ApplyEdit();     
                //DMVTYT tmp = _DMVTYT.Clone();
                //_DMVTYT = tmp.Save();                                

            }
            else
            {
                _DMVTYT.NguoiHuy = Pub_sNguoiSD;
                _DMVTYT.MaMay = Pub_sMaMay;


                DMVTYT.DeleteDMVTYT(_DMVTYT.MaVT, Pub_sMaMay, Pub_sNguoiSD);
            }
            if (_action == FormAction.EDIT)
            {

                _DMVTYT.NguoiSD = Pub_sNguoiSD;
                _DMVTYT.MaMay = Pub_sMaMay;
                //_DMVTYTList.UpdatedTo(_DMVTYT);
                _DMVTYT.ApplyEdit();
                _DMVTYT.Save();

            }
            else if (_action == FormAction.INSERT)
            {
                _DMVTYT.NguoiLap = Pub_sNguoiSD;

                _DMVTYT.MaMay = Pub_sMaMay;
                //_DMVTYTList.NewTo(_DMVTYT);
                _DMVTYT.ApplyEdit();
                _DMVTYT.Save();
            }
            else
            {
                _DMVTYT.NguoiHuy = Pub_sNguoiSD;

                _DMVTYT.MaMay = Pub_sMaMay;
                //_DMVTYTList.RemoveTo(_DMVTYT);
                DMVTYT.DeleteDMVTYT(_DMVTYT.MaVT, Pub_sMaMay, Pub_sNguoiSD);
            }


            string sql = "UPDATE DMVTYT SET  MaQG = '" + cboQuocGia.SelectedValue + "',DinhMuc = '" + txtDinhMuc.Text + "',bh50 = '" + txtbh50.Text + "',MaNguon = '" + cboDMNguon.SelectedValue + "' WHERE MaVT = '" + _DMVTYT.MaVT + "'";
            HTC.Business.DataProvider.Instance().ExcSQL(sql);


            _action = FormAction.INSERT;
            LoadDetail();
            grdChiTiet.DataSource = _DMVTYTList;
            grdChiTiet.DataBind();

        }
        catch (Exception ex)
        {

            ShowMessage("Không ghi được dữ liệu" + ex.Message);

            //throw;
        }


    }

    protected void grdChiTiet_DeletedCommand(object sender, GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;

            if (editedItem != null)
            {
                string _maVT = editedItem.GetDataKeyValue("MaVT").ToString();

                HTC.Business.DataProvider.Instance().DeleteDMVTYT(Pub_sMaMay, Pub_sNguoiSD, _maVT);
                _DMVTYTList = null;
                grdChiTiet.DataSource = _DMVTYTList;
                grdChiTiet.DataBind();

                ShowMessage(MessageType.SUCCESS, FormAction.DELETE);
            }
        }
        catch (Exception ex)
        {
            HandleException(ex, FormAction.DELETE);
            ShowMessage(MessageType.ERROR, FormAction.DELETE);
        }

        e.Canceled = true;
    }

    //protected void grdChiTiet_UpdateCommand(object sender, GridCommandEventArgs e)
    //{
    //    FormAction action = FormAction.EDIT;
    //    try
    //    {
    //        GridEditableItem editedItem = e.Item as GridEditableItem;

    //        if (editedItem != null)
    //        {
    //            if (editedItem != null)
    //            {

    //                string _maVT = editedItem.GetDataKeyValue("MaVT").ToString();
    //                string _maChungLoai = string.Empty;
    //                string _tenGoc = string.Empty;
    //                string _tenTC = string.Empty;
    //                string _tenTM = string.Empty;
    //                string _tenTM1 = string.Empty;
    //                string _tenTM2 = string.Empty;
    //                string _tenTA = string.Empty;
    //                string _maNSX = string.Empty;
    //                string _hamLuong = string.Empty;
    //                string _maDVTHL = string.Empty;
    //                string _nguong = string.Empty;
    //                string _maDVT = string.Empty;
    //                string _quydoi = string.Empty;
    //                string _maDVT2 = string.Empty;
    //                string _khoban = string.Empty;
    //                string _khophat = string.Empty;
    //                bool _apDungGoi = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _apDungGoi = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }

    //                bool _handung = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _handung = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }


    //                bool _vTThuT = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _vTThuT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }

    //                bool _vTPhauT = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _vTPhauT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }

    //                bool _vTCLS = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _vTCLS = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }

    //                bool _vTNoiT = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _vTNoiT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }
    //                bool _vTDuoc = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _vTDuoc = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }

    //                bool _vTBan = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _vTBan = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }

    //                bool _duyetNgoaiT = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _duyetNgoaiT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }
    //                bool _duyetNoiT = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _duyetNoiT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }
    //                bool _huy = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    _huy = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }
    //                bool KhongSD = false;
    //                if (action == FormAction.EDIT)
    //                {
    //                    KhongSD = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //                }
    //                string _maql = string.Empty;
    //                string _ghichu = string.Empty;
    //                string _malh = string.Empty;
    //                string _quycach = string.Empty;

    //                string quyetdinh = string.Empty;
    //                if (action == FormAction.EDIT)
    //                {
    //                    quyetdinh = ((TextBox)editedItem["QuyetDinh"].Controls[0]).Text;
    //                }
    //                string mabhyte = string.Empty;
    //                if (action == FormAction.EDIT)
    //                {
    //                    mabhyte = ((TextBox)editedItem["MaBHYTe"].Controls[0]).Text;
    //                }
    //                string tenbh = string.Empty;
    //                if (action == FormAction.EDIT)
    //                {
    //                    tenbh = ((TextBox)editedItem["TenTM"].Controls[0]).Text;
    //                }  
    //                HTC.Business.DataProvider.Instance().UpdateDMVTYT(_maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, decimal.Parse(_nguong), _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, Pub_sMaMay, _huy, Pub_sNguoiSD, _vTNoiT, _malh, _hamLuong, _maDVTHL, KhongSD, _maql, _quycach, _maDVT2, decimal.Parse(_quydoi),mabhyte ,quyetdinh ,tenbh );

    //                _DMVTYTList = null;

    //                grdChiTiet.DataSource = _DMVTYTList;
    //                grdChiTiet.DataBind();

    //                ShowMessage(MessageType.SUCCESS, FormAction.DELETE);
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        //HandleException(ex, FormAction.EDIT);
    //        ShowMessage(MessageType.ERROR, FormAction.EDIT);
    //    }

    //    e.Canceled = true;
    //}

    //protected void grdChiTiet_InsertCommand(object sender, GridCommandEventArgs e)
    //{
    //    FormAction action = FormAction.EDIT;
    //    try
    //    {
    //        GridEditableItem editedItem = grdChiTiet.MasterTableView.GetInsertItem();
    //        if (editedItem != null)
    //        {
    //            string _maVT = editedItem.GetDataKeyValue("MaVT").ToString();
    //            string _maChungLoai = string.Empty;
    //            string _tenGoc = string.Empty;
    //            string _tenTC = string.Empty;
    //            string _tenTM = string.Empty;
    //            string _tenTM1 = string.Empty;
    //            string _tenTM2 = string.Empty;
    //            string _tenTA = string.Empty;
    //            string _maNSX = string.Empty;
    //            string _hamLuong = string.Empty;
    //            string _maDVTHL = string.Empty;
    //            string _nguong = string.Empty;
    //            string _maDVT = string.Empty;
    //            string _quydoi = string.Empty;
    //            string _maDVT2 = string.Empty;
    //            string _khoban = string.Empty;
    //            string _khophat = string.Empty;
    //            bool _apDungGoi = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _apDungGoi = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }

    //            bool _handung = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _handung = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }


    //            bool _vTThuT = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _vTThuT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }

    //            bool _vTPhauT = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _vTPhauT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }

    //            bool _vTCLS = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _vTCLS = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }

    //            bool _vTNoiT = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _vTNoiT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }
    //            bool _vTDuoc = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _vTDuoc = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }

    //            bool _vTBan = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _vTBan = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }

    //            bool _duyetNgoaiT = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _duyetNgoaiT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }
    //            bool _duyetNoiT = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _duyetNoiT = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }
    //            bool _huy = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                _huy = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }
    //            bool KhongSD = false;
    //            if (action == FormAction.EDIT)
    //            {
    //                KhongSD = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //            }
    //            string _maql = string.Empty;
    //            string _ghichu = string.Empty;
    //            string _malh = string.Empty;
    //            string _quycach = string.Empty;
    //            string _nguoiLap = string.Empty;

    //            string quyetdinh = string.Empty;
    //            if (action == FormAction.EDIT)
    //            {
    //                quyetdinh = ((TextBox)editedItem["QuyetDinh"].Controls[0]).Text;
    //            }
    //            string mabhyte = string.Empty;
    //            if (action == FormAction.EDIT)
    //            {
    //                mabhyte = ((TextBox)editedItem["MaBHYTe"].Controls[0]).Text;
    //            }
    //            string tenbh = string.Empty;
    //            if (action == FormAction.EDIT)
    //            {
    //                tenbh = ((TextBox)editedItem["TenTM"].Controls[0]).Text;
    //            }  
    //            HTC.Business.DataProvider.Instance().InsertDMVTYT(_maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, decimal.Parse(_nguong), _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, Pub_sMaMay, _nguoiLap, _vTNoiT, _malh, _hamLuong, _maDVTHL, KhongSD, _maql, _quycach, _maDVT2, decimal.Parse(_quydoi), _loai,mabhyte ,quyetdinh ,tenbh );

    //            _DMVTYTList = null;

    //            grdChiTiet.DataSource = _DMVTYTList;
    //            grdChiTiet.DataBind();

    //            ShowMessage(MessageType.SUCCESS, FormAction.DELETE);
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        HandleException(ex, FormAction.INSERT);

    //        ShowMessage(MessageType.ERROR, FormAction.INSERT);
    //    }

    //    e.Canceled = true;
    //}

    protected void grdChiTiet_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
        grdChiTiet.VirtualItemCount = _DMVTYTList.record;
        grdChiTiet.DataSource = _DMVTYTList;
    }
    protected void grdChiTiet_PageIndexChanged(object sender, GridPageChangedEventArgs e)
    {

        string sql = "";
        sql = " and row >= " + ((e.NewPageIndex) * grdChiTiet.PageSize).ToString() + " and row < " + ((e.NewPageIndex + 1) * grdChiTiet.PageSize).ToString();

        if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            _DMVTYTList = DMVTYTList.FindDMVTYTbyFilter(_FilterSql, sql, _loai, pub_bQadmin);
        else
            _DMVTYTList = DMVTYTList.FindDMVTYTbyFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, _loai, pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMVTYTList.record;
        grdChiTiet.DataSource = _DMVTYTList;
        grdChiTiet.DataBind();
    }
    protected void grdChiTiet_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
    {
        string sql = "";
        sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * e.NewPageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * e.NewPageSize).ToString();
        if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            _DMVTYTList = DMVTYTList.FindDMVTYTbyFilter(_FilterSql, sql, _loai, pub_bQadmin);
        else
            _DMVTYTList = DMVTYTList.FindDMVTYTbyFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, _loai, pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMVTYTList.record;
        grdChiTiet.DataSource = _DMVTYTList;
        grdChiTiet.DataBind();
    }

    protected void grdChiTiet_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if (String.IsNullOrEmpty(e.CommandName))
        {
            Response.Redirect("~/Default.aspx");
        }
        else if (e.CommandName == RadGrid.FilterCommandName)
        {
            Pair filterPair = (Pair)e.CommandArgument;
            GridFilteringItem item = (e.Item as GridFilteringItem);
            TextBox filterBoxMaDV = item["MaVT"].Controls[0] as TextBox;

            TextBox filterBoxTenDV = item["TenTM"].Controls[0] as TextBox;
            // TextBox filterBoxTenHamLuong = item["HamLuong"].Controls[0] as TextBox;

            TextBox filterBoxTenDVT = item["TenDVT"].Controls[0] as TextBox;
            TextBox filterBoxTenMaMay = item["MaMay"].Controls[0] as TextBox;
            TextBox filterBoxTenNgaySD = item["NgaySD"].Controls[0] as TextBox;
            string FilterSql = "";
            if (filterBoxTenDV.Text != "")
            {
                FilterSql = FilterSql + "and a.tentm like N'%" + filterBoxTenDV.Text + "%'";
            }
            if (filterBoxMaDV.Text != "")
            {
                FilterSql = FilterSql + "and a.mavt like N'%" + filterBoxMaDV.Text + "%'";
            }
            if (filterBoxTenDVT.Text != "")
            {
                FilterSql = FilterSql + "and f.tendvt like N'%" + filterBoxTenDVT.Text + "%'";
            }

            //if (filterBoxTenHamLuong.Text != "")
            //{
            //    FilterSql = FilterSql + "and a.hamluong like N'%" + filterBoxTenHamLuong.Text + "%'";
            //}
            if (filterBoxTenMaMay.Text != "")
            {
                FilterSql = FilterSql + "and a.mamay like N'%" + filterBoxTenMaMay.Text + "%'";
            }
            if (filterBoxTenNgaySD.Text != "")
            {
                FilterSql = FilterSql + "and a.ngaysd = '" + filterBoxTenNgaySD.Text + "'";
            }
            _FilterSql = FilterSql;
            grdChiTiet.CurrentPageIndex = 0;
            string sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * grdChiTiet.PageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * grdChiTiet.PageSize).ToString();
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMVTYTList = DMVTYTList.FindDMVTYTbyFilter(_FilterSql, sql, _loai, pub_bQadmin);
            else
                _DMVTYTList = DMVTYTList.FindDMVTYTbyFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, _loai, pub_bQadmin);

            grdChiTiet.VirtualItemCount = _DMVTYTList.record;

            grdChiTiet.DataSource = _DMVTYTList;
            grdChiTiet.DataBind();
        }
        else if (e.CommandName == "Edit")
        {
            GridDataItem item = e.Item as GridDataItem;

            if (item != null)
            {
                if (item.GetDataKeyValue("MaVT") != null)
                {
                    _Selected_Ma = item.GetDataKeyValue("MaVT").ToString();
                    //_DMVTYT = DMVTYT.GetDMVTYT(_Selected_Ma);
                    //_DMVTYT.OrderNumber = int.Parse(item.GetDataKeyValue("OrderNumber").ToString());
                    _DMVTYT = DMVTYT.GetDMVTYT(_Selected_Ma);//  [int.Parse(item.GetDataKeyValue("OrderNumber").ToString()) - 1];
                    _action = FormAction.EDIT;
                    LoadDetail();

                }
            }

            e.Canceled = true;
            /*
            if (e.CommandArgument.ToString() != "")
            {
                GridDataItem item = grdChiTiet.MasterTableView.Items[e.CommandArgument.ToString()] as GridDataItem;
                GridEditableItem editedItem = (GridEditableItem)(grdChiTiet.MasterTableView.Items[e.CommandArgument.ToString()] as GridEditableItem);
                
            }*/

        }

    }
    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        switch (e.Item.Value)
        {
            case "cmdSave":
                UpdateData();

                break;
            case "cmdAdd":
                _action = FormAction.INSERT;
                LoadDetail();

                break;
            case "cmdExport":
                ExportData();

                break;
            case "cmdDelete":
                _action = FormAction.DELETE;
                UpdateData();
                _action = FormAction.INSERT;
                LoadDetail();
                break;
            case "cmdFilter":
                grdChiTiet.AllowFilteringByColumn = !grdChiTiet.AllowFilteringByColumn;
                grdChiTiet.DataSource = _DMVTYTList;
                grdChiTiet.DataBind();
                //if (grdChiTiet.AllowFilteringByColumn == true)
                //    grdChiTiet.AllowFilteringByColumn = false;
                //else
                //    grdChiTiet.AllowFilteringByColumn = true;


                break;
            //case "cmdky":
            //    Response.Redirect("~/UI/Category/DMHanhChinh/CKS.aspx?filepath=E:\\TT\\MedyxQN_KN\\MedyxQN_KN\\Medyx\\SignedXML\\config.", false);
            //    break;
            case "cmdView":

                if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                    _DMVTYTList = DMVTYTList.FindDMVTYTMa("", _loai);
                else
                    _DMVTYTList = DMVTYTList.FindDMVTYTByNhomVTYT(cboDsnhom.SelectedValue, _loai);
                grdChiTiet.VirtualItemCount = _DMVTYTList.record;
                grdChiTiet.DataSource = _DMVTYTList;
                grdChiTiet.DataBind();
                break;
            case "cmdExit":
                Response.Redirect("~/Default.aspx");
                break;

            default:
                break;

        }

    }
    protected void cboChungLoai_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        cboLoaihinh.DataSource = DMLoaiHinhListcb.GetList(cboChungLoai.SelectedValue);
        cboLoaihinh.DataBind();
    }
    protected void cboDsNhom_OnSelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            _DMVTYTList = DMVTYTList.GetAllDMVTYT();
        else
            _DMVTYTList = DMVTYTList.FindDMVTYTByNhomVTYT(cboDsnhom.SelectedValue);
        grdChiTiet.DataSource = _DMVTYTList;
        grdChiTiet.DataBind();
    }


    private void ExportData()
    {
        try
        {
            string filename = "DMVTYT_" + DateTime.Now.Date.ToString() + ".xls";
            string excelHeader = "DMVTYT";
            System.IO.StringWriter tw = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
            DataGrid dgGrid = new DataGrid();

           // dgGrid.DataSource = HTC.Business.DataProvider.Instance().crDMVTYT_GIA_RPT("all", "");

            dgGrid.DataSource = HTC.Business.DataProvider.Instance().crDMVTYT_GIA_RPT("10002", "");

            dgGrid.DataBind();
            hw.WriteLine("<b><u><font size=’3′> " + excelHeader + " </font></u></b>");
            dgGrid.RenderControl(hw);
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            Response.ContentType = "application/vnd.ms-excel";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + "");
            this.EnableViewState = false;
            Response.Write(tw.ToString());
            Response.End();

        }
        catch (System.IO.IOException ex)
        {
            ShowMessage("Không lưu được dữ liệu" + ex.Message);
            //ShowMessage(MessageType.ERROR, FormAction.REPORTS);

        }
    }



    

    

    private static string ConnectString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        }
    }
    public static List<DMQuocGia> GetDMQuocGia()
    {
        List<DMQuocGia> List = new List<DMQuocGia>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMQuocGia_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMQuocGia(dr, i));
            }
        }
        return List;
    }

    public class DMQuocGia
    {
        private String _MaQG = String.Empty;
        private String _TenQG = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _MaQL = String.Empty;
        private String _MaQuocTich = String.Empty;
        private int _OrderNumber;
        public String MaQG
        {
            get
            {
                return _MaQG;
            }
            set
            {
                if (_MaQG != value)
                {
                    _MaQG = value;
                }
            }
        }

        public String TenQG
        {
            get
            {
                return _TenQG;
            }
            set
            {
                if (_TenQG != value)
                {
                    _TenQG = value;
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


        public String MaQuocTich
        {
            get
            {
                return _MaQuocTich;
            }
            set
            {
                if (_MaQuocTich != value)
                {
                    _MaQuocTich = value;
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
        public DMQuocGia(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaQG"].GetType().Name != "DBNull" && dr["MaQG"] != null)
            {
                this.MaQG = Convert.ToString(dr["MaQG"]);
            }
            else
            {
                this.MaQG = "";
            }
            if (dr["TenQG"].GetType().Name != "DBNull" && dr["TenQG"] != null)
            {
                this.TenQG = Convert.ToString(dr["TenQG"]);
            }
            else
            {
                this.TenQG = "";
            }
            if (dr["MaQL"].GetType().Name != "DBNull" && dr["MaQL"] != null)
            {
                this.MaQL = Convert.ToString(dr["MaQL"]);
            }
            else
            {
                this.MaQL = "";
            }


            //if (dr["MaQuocTich"].GetType().Name != "DBNull" && dr["MaQuocTich"] != null)
            //{
            //    this.MaQuocTich = Convert.ToString(dr["MaQuocTich"]);
            //}
            //else
            //{
            //    this.MaQuocTich = "";
            //}


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



    public static List<DMNguonM> GetDMNguonM()
    {
        List<DMNguonM> List = new List<DMNguonM>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNguon_GetAll2")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMNguonM(dr, i));
            }
        }
        return List;
    }


    //public static List<DMNguonM> GetDMNguon(byte loai, bool isAdmin)
    //{
    //    List<DMNguonM> list = new List<DMNguonM>();
    //    using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNguon_GetAll", loai, isAdmin)))
    //    {
    //        int i = 0;
    //        while (dr.Read())
    //        {
    //            i++;
    //            list.Add(new DMNguonM(dr, i));
    //        }
    //    }
    //    return list;
    //}



    public class DMNguonM
    {
        private String _maNguon = String.Empty;
        private String _tenNguon = String.Empty;
        private String _tenta = String.Empty;
        private String _Ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Byte _Loai;
        private Boolean _huy = false;
        private Boolean _KhongSD = false;
        private DateTime _ngaySD  ;
        private String _nguoiSD = String.Empty;
        //private String _hoten = String.Empty;
        private int _OrderNumber;
        public String MaNguon
        {
            get
            {
                return _maNguon;
            }
            set
            {
                if (_maNguon != value)
                {
                    _maNguon = value;
                }
            }
        }

        public String TenNguon
        {
            get
            {
                return _tenNguon;
            }
            set
            {
                if (_tenNguon != value)
                {
                    _tenNguon = value;
                }
            }
        }

        public String TenTA
        {
            get
            {
                return _tenta;
            }
            set
            {
                if (_tenta != value)
                {
                    _tenta = value;
                }
            }
        }


        public String GhiChu
        {
            get
            {
                return _Ghichu;
            }
            set
            {
                if (_Ghichu != value)
                {
                    _Ghichu = value;
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


        public Byte Loai
        {
            get
            {
                return _Loai;
            }
            set
            {
                if (_Loai != value)
                {
                    _Loai = value;
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
        public DMNguonM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaNguon"].GetType().Name != "DBNull" && dr["MaNguon"] != null)
            {
                this.MaNguon = Convert.ToString(dr["MaNguon"]);
            }
            else
            {
                this.MaNguon = "";
            }
            if (dr["TenNguon"].GetType().Name != "DBNull" && dr["TenNguon"] != null)
            {
                this.TenNguon = Convert.ToString(dr["TenNguon"]);
            }
            else
            {
                this.TenNguon = "";
            }
            if (dr["TenTA"].GetType().Name != "DBNull" && dr["TenTA"] != null)
            {
                this.TenTA = Convert.ToString(dr["TenTA"]);
            }
            else
            {
                this.TenTA = "";
            }


            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }


            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }


            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
            {
                this.Loai = Convert.ToByte(dr["Loai"]);
            }
            else
            {
                this.Loai = 2;
            }



            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }


            if (dr["KhongSD"].GetType().Name != "DBNull" && dr["KhongSD"] != null)
            {
                this.KhongSD = Convert.ToBoolean(dr["KhongSD"]);
            }
            else
            {
                this.KhongSD = false;
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



    [Serializable()]
    public class DMVTYT : BusinessBase<DMVTYT>
    {
        #region Business Methods

        #region State Fields
        private String _maql = String.Empty;
        private String _maVT = String.Empty;
        private String _maNhom = String.Empty;
        private String _maChungLoai = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenTMHL = String.Empty;
        private String _tenTA = String.Empty;
        private String _maNSX = String.Empty;
        private Decimal _nguong = 0;
        private String _maDVT2 = String.Empty;
        private Decimal _quydoi = 0;
        private String _hamLuong = String.Empty;
        private String _hamLuongD = String.Empty;
        private String _maDVTHL = String.Empty;
        private String _tendvthl = String.Empty;
        private String _maDVT = String.Empty;
        private Boolean _apDungGoi = true;
        private Boolean _handung = true;
        private Decimal _gianhap = 0;
        private SmartDate _ngaynhap = new SmartDate(true);
        private Decimal _gianhap1 = 0;
        private SmartDate _ngaynhap1 = new SmartDate(true);
        private Decimal _gianhap2 = 0;
        private SmartDate _ngaynhap2 = new SmartDate(true);
        private Decimal _donGiaTT = 0;
        private Decimal _donGiaTT1 = 0;
        private Decimal _dongiaThuT = 0;
        private Decimal _dongiaPhauT = 0;
        private Decimal _dongiaCLS = 0;
        private Decimal _giaQuay = 0;
        private Decimal _giaQuay1 = 0;
        private String _khoban = String.Empty;
        private String _khophat = String.Empty;
        private Boolean _vTThuT = false;
        private Boolean _vTPhauT = false;
        private Boolean _vTCLS = false;
        private Boolean _vTDuoc = false;
        private Boolean _vTBan = false;
        private Boolean _duyetNgoaiT = true;
        private Boolean _duyetNoiT = true;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private Boolean _vTNoiT = false;
        private String _maLH = String.Empty;
        private int _OrderNumber;
        private String _tendvt = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private String _tenNSX = String.Empty;
        private Boolean _KhongSD = false;
        private String _quycach = String.Empty;
        private Byte _loai = 0;
        private String _maBYTe = String.Empty;
        private String _TenTMBH = String.Empty;
        private String _QuyetDinh = String.Empty;
        private String _QuyetDinhBH = String.Empty;
        private String _MaBH = String.Empty;
        private string _MaTDuong = String.Empty;
        private String _TenBYTe = String.Empty;
        private byte _bh50 = 100;
        private byte _DinhMuc = 0;

        private String _MaNguon = String.Empty;


        #endregion

        #region Business Properties and Methods
        public byte bh50
        {
            get
            {
                CanReadProperty("bh50");
                return _bh50;
            }
            set
            {
                CanWriteProperty("bh50");
                if (_bh50 != value)
                {
                    _bh50 = value;
                    PropertyHasChanged("bh50");
                }
            }
        }


        public byte DinhMuc
        {
            get
            {
                CanReadProperty("DinhMuc");
                return _DinhMuc;
            }
            set
            {
                CanWriteProperty("DinhMuc");
                if (_DinhMuc != value)
                {
                    _DinhMuc = value;
                    PropertyHasChanged("DinhMuc");
                }
            }
        }
        public String MaTDuong
        {
            get
            {
                CanReadProperty("MaTDuong", true);
                return _MaTDuong;
            }
            set
            {
                CanWriteProperty("MaTDuong", true);
                if (_MaTDuong != value)
                {
                    _MaTDuong = value;
                    PropertyHasChanged("MaTDuong");
                }
            }
        }
        public String MaBH
        {
            get
            {
                CanReadProperty("MaBH", true);
                return _MaBH;
            }
            set
            {
                CanWriteProperty("MaBH", true);
                if (_MaBH != value)
                {
                    _MaBH = value;
                    PropertyHasChanged("MaBH");
                }
            }
        }
        public String QuyetDinhBH
        {
            get
            {
                CanReadProperty("QuyetDinhBH", true);
                return _QuyetDinhBH;
            }
            set
            {
                CanWriteProperty("QuyetDinhBH", true);
                if (_QuyetDinhBH != value)
                {
                    _QuyetDinhBH = value;
                    PropertyHasChanged("QuyetDinhBH");
                }
            }
        }
        public String TenBYTe
        {
            get
            {
                CanReadProperty("TenBYTe", true);
                return _TenBYTe;
            }
            set
            {
                CanWriteProperty("TenBYTe", true);
                if (_TenBYTe != value)
                {
                    _TenBYTe = value;
                    PropertyHasChanged("TenBYTe");
                }
            }
        }




        public String MaNguon
        {
            get
            {
                CanReadProperty("MaNguon", true);
                return _MaNguon;
            }
            set
            {
                CanWriteProperty("MaNguon", true);
                if (_MaNguon != value)
                {
                    _MaNguon = value;
                    PropertyHasChanged("MaNguon");
                }
            }
        }
        public String TenTMDu
        {
            get
            {

                return _maVT + "-" + _tenTM;
            }

        }
        public String MaBYTe
        {
            get
            {
                CanReadProperty("MaBYTe", true);
                return _maBYTe;
            }
            set
            {
                CanWriteProperty("MaBYTe", true);
                if (_maBYTe != value)
                {
                    _maBYTe = value;
                    PropertyHasChanged("MaBYTe");
                }
            }
        }

        public String QuyetDinh
        {
            get
            {
                CanReadProperty("QuyetDinh", true);
                return _QuyetDinh;
            }
            set
            {
                CanWriteProperty("QuyetDinh", true);
                if (_QuyetDinh != value)
                {
                    _QuyetDinh = value;
                    PropertyHasChanged("QuyetDinh");
                }
            }
        }
        public String TenTMBH
        {
            get
            {
                CanReadProperty("TenTMBH", true);
                return _TenTMBH;
            }
            set
            {
                CanWriteProperty("TenTMBH", true);
                if (_TenTMBH != value)
                {
                    _TenTMBH = value;
                    PropertyHasChanged("TenTMBH");
                }
            }
        }
        public Byte loai
        {
            get
            {
                CanReadProperty("loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("loai");
                }
            }
        }
        public Decimal Quydoi
        {
            get
            {
                CanReadProperty("Quydoi", true);
                return _quydoi;
            }
            set
            {
                CanWriteProperty("Quydoi", true);
                if (_quydoi != value)
                {
                    _quydoi = value;
                    PropertyHasChanged("Quydoi");
                }
            }
        }
        public String MaDVT2
        {
            get
            {
                CanReadProperty("MaDVT2", true);
                return _maDVT2;
            }
            set
            {
                CanWriteProperty("MaDVT2", true);
                if (_maDVT2 != value)
                {
                    _maDVT2 = value;
                    PropertyHasChanged("MaDVT2");
                }
            }
        }
        public String quycach
        {
            get
            {
                CanReadProperty("quycach", true);
                return _quycach;
            }
            set
            {
                CanWriteProperty("quycach", true);
                if (_quycach != value)
                {
                    _quycach = value;
                    PropertyHasChanged("quycach");
                }
            }
        }
        public Boolean KhongSD
        {
            get
            {
                CanReadProperty("KhongSD", true);
                return _KhongSD;
            }
            set
            {
                CanWriteProperty("KhongSD", true);
                if (_KhongSD != value)
                {
                    _KhongSD = value;
                    PropertyHasChanged("KhongSD");
                }
            }
        }
        public String TenTMHL
        {
            get
            {
                CanReadProperty("TenTMHL", true);
                return _tenTM + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX;
            }
            //set
            //{
            //    CanWriteProperty("TenTMHL", true);
            //    if (_tenTM != value)
            //    {
            //        _tenTM = value;
            //        PropertyHasChanged("TenTMHL");
            //    }
            //}
        }
        public String tendvt
        {
            get
            {
                CanReadProperty("tendvt", true);
                return _tendvt;
            }
            set
            {
                CanWriteProperty("tendvt", true);
                if (_tendvt != value)
                {
                    _tendvt = value;
                    PropertyHasChanged("tendvt");
                }
            }
        }
        public String tendvthl
        {
            get
            {
                CanReadProperty("tendvthl", true);
                return _tendvthl;
            }
            set
            {
                CanWriteProperty("tendvthl", true);
                if (_tendvthl != value)
                {
                    _tendvthl = value;
                    PropertyHasChanged("tendvthl");
                }
            }
        }
        public String MaVT
        {
            get
            {
                CanReadProperty("MaVT", true);
                return _maVT;
            }
            set
            {
                CanWriteProperty("MaVT", true);
                if (_maVT != value)
                {
                    _maVT = value;
                    PropertyHasChanged("MaVT");
                }
            }
        }
        public String maql
        {
            get
            {
                CanReadProperty("maql", true);
                return _maql;
            }
            set
            {
                CanWriteProperty("maql", true);
                if (_maql != value)
                {
                    _maql = value;
                    PropertyHasChanged("maql");
                }
            }
        }
        public String HamLuong
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamLuong;
            }
            set
            {
                CanWriteProperty("HamLuong", true);
                if (_hamLuong != value)
                {
                    _hamLuong = value;
                    PropertyHasChanged("HamLuong");
                }
            }
        }
        public String HamLuongD
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamLuong + " " + _tendvthl;
            }

        }
        public String MaDVTHL
        {
            get
            {
                CanReadProperty("MaDVTHL", true);
                return _maDVTHL;
            }
            set
            {
                CanWriteProperty("MaDVTHL", true);
                if (_maDVTHL != value)
                {
                    _maDVTHL = value;
                    PropertyHasChanged("MaDVTHL");
                }
            }
        }
        public String MaNhom
        {
            get
            {
                CanReadProperty("MaNhom", true);
                return _maNhom;
            }
            set
            {
                CanWriteProperty("MaNhom", true);
                if (_maNhom != value)
                {
                    _maNhom = value;
                    PropertyHasChanged("MaNhom");
                }
            }
        }

        public String MaChungLoai
        {
            get
            {
                CanReadProperty("MaChungLoai", true);
                return _maChungLoai;
            }
            set
            {
                CanWriteProperty("MaChungLoai", true);
                if (_maChungLoai != value)
                {
                    _maChungLoai = value;
                    PropertyHasChanged("MaChungLoai");
                }
            }
        }

        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }


        public String TenTA
        {
            get
            {
                CanReadProperty("TenTA", true);
                return _tenTA;
            }
            set
            {
                CanWriteProperty("TenTA", true);
                if (_tenTA != value)
                {
                    _tenTA = value;
                    PropertyHasChanged("TenTA");
                }
            }
        }

        public String MaNSX
        {
            get
            {
                CanReadProperty("MaNSX", true);
                return _maNSX;
            }
            set
            {
                CanWriteProperty("MaNSX", true);
                if (_maNSX != value)
                {
                    _maNSX = value;
                    PropertyHasChanged("MaNSX");
                }
            }
        }

        public Decimal Nguong
        {
            get
            {
                CanReadProperty("Nguong", true);
                return _nguong;
            }
            set
            {
                CanWriteProperty("Nguong", true);
                if (_nguong != value)
                {
                    _nguong = value;
                    PropertyHasChanged("Nguong");
                }
            }
        }

        public String MaDVT
        {
            get
            {
                CanReadProperty("MaDVT", true);
                return _maDVT;
            }
            set
            {
                CanWriteProperty("MaDVT", true);
                if (_maDVT != value)
                {
                    _maDVT = value;
                    PropertyHasChanged("MaDVT");
                }
            }
        }

        public Boolean ApDungGoi
        {
            get
            {
                CanReadProperty("ApDungGoi", true);
                return _apDungGoi;
            }
            set
            {
                CanWriteProperty("ApDungGoi", true);
                if (_apDungGoi != value)
                {
                    _apDungGoi = value;
                    PropertyHasChanged("ApDungGoi");
                }
            }
        }

        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _handung;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_handung != value)
                {
                    _handung = value;
                    PropertyHasChanged("Handung");
                }
            }
        }

        public Decimal Gianhap
        {
            get
            {
                CanReadProperty("Gianhap", true);
                return _gianhap;
            }
            set
            {
                CanWriteProperty("Gianhap", true);
                if (_gianhap != value)
                {
                    _gianhap = value;
                    PropertyHasChanged("Gianhap");
                }
            }
        }

        public string Ngaynhap
        {
            get
            {
                CanReadProperty("Ngaynhap", true);
                return _ngaynhap.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap", true);
                if (_ngaynhap.Text != value)
                {
                    _ngaynhap.Text = value;
                    PropertyHasChanged("Ngaynhap");
                }
            }
        }

        public Decimal Gianhap1
        {
            get
            {
                CanReadProperty("Gianhap1", true);
                return _gianhap1;
            }
            set
            {
                CanWriteProperty("Gianhap1", true);
                if (_gianhap1 != value)
                {
                    _gianhap1 = value;
                    PropertyHasChanged("Gianhap1");
                }
            }
        }

        public string Ngaynhap1
        {
            get
            {
                CanReadProperty("Ngaynhap1", true);
                return _ngaynhap1.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap1", true);
                if (_ngaynhap1.Text != value)
                {
                    _ngaynhap1.Text = value;
                    PropertyHasChanged("Ngaynhap1");
                }
            }
        }

        public Decimal Gianhap2
        {
            get
            {
                CanReadProperty("Gianhap2", true);
                return _gianhap2;
            }
            set
            {
                CanWriteProperty("Gianhap2", true);
                if (_gianhap2 != value)
                {
                    _gianhap2 = value;
                    PropertyHasChanged("Gianhap2");
                }
            }
        }

        public string Ngaynhap2
        {
            get
            {
                CanReadProperty("Ngaynhap2", true);
                return _ngaynhap2.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap2", true);
                if (_ngaynhap2.Text != value)
                {
                    _ngaynhap2.Text = value;
                    PropertyHasChanged("Ngaynhap2");
                }
            }
        }

        public Decimal DonGiaTT
        {
            get
            {
                CanReadProperty("DonGiaTT", true);
                return _donGiaTT;
            }
            set
            {
                CanWriteProperty("DonGiaTT", true);
                if (_donGiaTT != value)
                {
                    _donGiaTT = value;
                    PropertyHasChanged("DonGiaTT");
                }
            }
        }

        public Decimal DonGiaTT1
        {
            get
            {
                CanReadProperty("DonGiaTT1", true);
                return _donGiaTT1;
            }
            set
            {
                CanWriteProperty("DonGiaTT1", true);
                if (_donGiaTT1 != value)
                {
                    _donGiaTT1 = value;
                    PropertyHasChanged("DonGiaTT1");
                }
            }
        }

        public Decimal DongiaThuT
        {
            get
            {
                CanReadProperty("DongiaThuT", true);
                return _dongiaThuT;
            }
            set
            {
                CanWriteProperty("DongiaThuT", true);
                if (_dongiaThuT != value)
                {
                    _dongiaThuT = value;
                    PropertyHasChanged("DongiaThuT");
                }
            }
        }

        public Decimal DongiaPhauT
        {
            get
            {
                CanReadProperty("DongiaPhauT", true);
                return _dongiaPhauT;
            }
            set
            {
                CanWriteProperty("DongiaPhauT", true);
                if (_dongiaPhauT != value)
                {
                    _dongiaPhauT = value;
                    PropertyHasChanged("DongiaPhauT");
                }
            }
        }

        public Decimal DongiaCLS
        {
            get
            {
                CanReadProperty("DongiaCLS", true);
                return _dongiaCLS;
            }
            set
            {
                CanWriteProperty("DongiaCLS", true);
                if (_dongiaCLS != value)
                {
                    _dongiaCLS = value;
                    PropertyHasChanged("DongiaCLS");
                }
            }
        }

        public Decimal GiaQuay
        {
            get
            {
                CanReadProperty("GiaQuay", true);
                return _giaQuay;
            }
            set
            {
                CanWriteProperty("GiaQuay", true);
                if (_giaQuay != value)
                {
                    _giaQuay = value;
                    PropertyHasChanged("GiaQuay");
                }
            }
        }

        public Decimal GiaQuay1
        {
            get
            {
                CanReadProperty("GiaQuay1", true);
                return _giaQuay1;
            }
            set
            {
                CanWriteProperty("GiaQuay1", true);
                if (_giaQuay1 != value)
                {
                    _giaQuay1 = value;
                    PropertyHasChanged("GiaQuay1");
                }
            }
        }

        public String Khoban
        {
            get
            {
                CanReadProperty("Khoban", true);
                return _khoban;
            }
            set
            {
                CanWriteProperty("Khoban", true);
                if (_khoban != value)
                {
                    _khoban = value;
                    PropertyHasChanged("Khoban");
                }
            }
        }

        public String Khophat
        {
            get
            {
                CanReadProperty("Khophat", true);
                return _khophat;
            }
            set
            {
                CanWriteProperty("Khophat", true);
                if (_khophat != value)
                {
                    _khophat = value;
                    PropertyHasChanged("Khophat");
                }
            }
        }

        public Boolean VTThuT
        {
            get
            {
                CanReadProperty("VTThuT", true);
                return _vTThuT;
            }
            set
            {
                CanWriteProperty("VTThuT", true);
                if (_vTThuT != value)
                {
                    _vTThuT = value;
                    PropertyHasChanged("VTThuT");
                }
            }
        }

        public Boolean VTPhauT
        {
            get
            {
                CanReadProperty("VTPhauT", true);
                return _vTPhauT;
            }
            set
            {
                CanWriteProperty("VTPhauT", true);
                if (_vTPhauT != value)
                {
                    _vTPhauT = value;
                    PropertyHasChanged("VTPhauT");
                }
            }
        }

        public Boolean VTCLS
        {
            get
            {
                CanReadProperty("VTCLS", true);
                return _vTCLS;
            }
            set
            {
                CanWriteProperty("VTCLS", true);
                if (_vTCLS != value)
                {
                    _vTCLS = value;
                    PropertyHasChanged("VTCLS");
                }
            }
        }

        public Boolean VTDuoc
        {
            get
            {
                CanReadProperty("VTDuoc", true);
                return _vTDuoc;
            }
            set
            {
                CanWriteProperty("VTDuoc", true);
                if (_vTDuoc != value)
                {
                    _vTDuoc = value;
                    PropertyHasChanged("VTDuoc");
                }
            }
        }

        public Boolean VTBan
        {
            get
            {
                CanReadProperty("VTBan", true);
                return _vTBan;
            }
            set
            {
                CanWriteProperty("VTBan", true);
                if (_vTBan != value)
                {
                    _vTBan = value;
                    PropertyHasChanged("VTBan");
                }
            }
        }

        public Boolean DuyetNgoaiT
        {
            get
            {
                CanReadProperty("DuyetNgoaiT", true);
                return _duyetNgoaiT;
            }
            set
            {
                CanWriteProperty("DuyetNgoaiT", true);
                if (_duyetNgoaiT != value)
                {
                    _duyetNgoaiT = value;
                    PropertyHasChanged("DuyetNgoaiT");
                }
            }
        }

        public Boolean DuyetNoiT
        {
            get
            {
                CanReadProperty("DuyetNoiT", true);
                return _duyetNoiT;
            }
            set
            {
                CanWriteProperty("DuyetNoiT", true);
                if (_duyetNoiT != value)
                {
                    _duyetNoiT = value;
                    PropertyHasChanged("DuyetNoiT");
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

        public Boolean VTNoiT
        {
            get
            {
                CanReadProperty("VTNoiT", true);
                return _vTNoiT;
            }
            set
            {
                CanWriteProperty("VTNoiT", true);
                if (_vTNoiT != value)
                {
                    _vTNoiT = value;
                    PropertyHasChanged("VTNoiT");
                }
            }
        }

        public String MaLH
        {
            get
            {
                CanReadProperty("MaLH", true);
                return _maLH;
            }
            set
            {
                CanWriteProperty("MaLH", true);
                if (_maLH != value)
                {
                    _maLH = value;
                    PropertyHasChanged("MaLH");
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

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }
        public String TenNSX
        {
            get
            {
                CanReadProperty("TenNSX", true);
                return _tenNSX;
            }
            set
            {
                CanWriteProperty("TenNSX", true);
                if (_tenNSX != value)
                {
                    _tenNSX = value;
                    PropertyHasChanged("TenNSX");
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }


        protected override Object GetIdValue()
        {
            return _maVT;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMVTYT>(StringRequired<DMVTYT>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMVTYT>(StringRequiredDVT<DMVTYT>, "MaDVT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMVTYT
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMVTYT
        {

            if (target._maDVT == null || target._maDVT.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMVTYT" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMVTYT NewDMVTYT()
        {
            return DataPortal.Create<DMVTYT>();
        }
        public static DMVTYT GetDMVTYT(String maVT)
        {
            return DataPortal.Fetch<DMVTYT>(new Criteria(maVT));
        }

        /// <summary>
        /// Marks the <see cref="DMVTYT" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMVTYT(String maVT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maVT));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMVTYT()
        {
            // Prevent direct creation
        }
        internal DMVTYT(int OrderNumber,
                             String maVT,

                             String maNhom,
                             String maChungLoai,
                             String tenTM,
                             String tenTA,
                             String maNSX,
                             Decimal nguong,
                             String maDVT,
                             Boolean apDungGoi,
                             Boolean handung,
                             Decimal gianhap,
                             SmartDate ngaynhap,
                             Decimal gianhap1,
                             SmartDate ngaynhap1,
                             Decimal gianhap2,
                             SmartDate ngaynhap2,
                             Decimal donGiaTT,
                             Decimal donGiaTT1,
                             Decimal dongiaThuT,
                             Decimal dongiaPhauT,
                             Decimal dongiaCLS,
                             Decimal giaQuay,
                             Decimal giaQuay1,
                             String khoban,
                             String khophat,
                             Boolean vTThuT,
                             Boolean vTPhauT,
                             Boolean vTCLS,
                             Boolean vTDuoc,
                             Boolean vTBan,
                             Boolean duyetNgoaiT,
                             Boolean duyetNoiT,
                             String ghichu,
                             String maMay,
                             Boolean huy,
                             SmartDate ngaySD,
                             String nguoiSD,
                             SmartDate ngaySD1,
                             String nguoiSD1,
                             SmartDate ngayLap,
                             String nguoiLap,
                             SmartDate ngayHuy,
                             String nguoiHuy,
                             Boolean vTNoiT,
                             String maLH,
                             string tendvt,
                             String hamLuong,
                             String maDVTHL,
                             string tendvthl,
                             string tennguoisd,
                             string tennguoilap,
                             string tennguoihuy,
                             string tennsx,
            Boolean KhongSD,
                                 string maql,
                                string quycach, String maDVT2, Decimal quydoi, String maBYTe,
             String quyetdinh,
            String tentmbh,
            String maBh, String matduong,
             String quyetdinhbh,
            String tenbyte, string MaNguon, byte DinhMuc,
            byte thuocbh

            )
        {
            _bh50 = thuocbh;
            _DinhMuc = DinhMuc;
            _MaBH = maBh; _MaTDuong = matduong;
            _TenBYTe = tenbyte;
            _MaNguon = MaNguon;
            _QuyetDinhBH = quyetdinhbh;
            _maBYTe = maBYTe;
            _QuyetDinh = quyetdinh;
            _TenTMBH = tentmbh;
            _OrderNumber = OrderNumber;
            _maVT = maVT;

            _quydoi = quydoi;
            _maDVT2 = maDVT2;
            _quycach = quycach;
            _maNhom = maNhom;
            _maChungLoai = maChungLoai;
            _tenTM = tenTM;
            _tenTA = tenTA;
            _maNSX = maNSX;
            _nguong = nguong;
            _maDVT = maDVT;
            _apDungGoi = apDungGoi;
            _handung = handung;
            _gianhap = gianhap;
            _ngaynhap = ngaynhap;
            _gianhap1 = gianhap1;
            _ngaynhap1 = ngaynhap1;
            _gianhap2 = gianhap2;
            _ngaynhap2 = ngaynhap2;
            _donGiaTT = donGiaTT;
            _donGiaTT1 = donGiaTT1;
            _dongiaThuT = dongiaThuT;
            _dongiaPhauT = dongiaPhauT;
            _dongiaCLS = dongiaCLS;
            _maql = maql;
            _giaQuay = giaQuay;
            _giaQuay1 = giaQuay1;
            _khoban = khoban;
            _khophat = khophat;
            _vTThuT = vTThuT;
            _vTPhauT = vTPhauT;
            _vTCLS = vTCLS;
            _vTDuoc = vTDuoc;
            _vTBan = vTBan;
            _duyetNgoaiT = duyetNgoaiT;
            _duyetNoiT = duyetNoiT;
            _ghichu = ghichu;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _vTNoiT = vTNoiT;
            _maLH = maLH;
            _tendvt = tendvt;
            _hamLuong = hamLuong;
            _maDVTHL = maDVTHL;
            _tendvthl = tendvthl;
            _tennguoiSD = tennguoisd;
            _tennguoiLap = tennguoilap;
            _tennguoiHuy = tennguoihuy;
            _tenNSX = tennsx;
            _KhongSD = KhongSD;
            if (_maql == "")
                _maql = _maVT;

        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maVT;
            public String MaVT
            {
                get
                {
                    return _maVT;
                }
            }

            public Criteria(String maVT)
            {
                _maVT = maVT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maVT.Equals(c._maVT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maVT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maVT;
            public String maVT
            {
                get
                {
                    return _maVT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maVTYT)
            {
                _maVT = maVTYT;
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
        /// Retrieve an existing <see cref="DMVTYT" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMVTYT(String _maVT);
            // public override IDataReader GetDMVTYT(String _maVT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMVTYT(crit.MaVT)))
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
        /// Load a <see cref="DMVTYT" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBH") != null) _MaBH = dr.GetString("MaBH"); if (dr.GetString("MaTDuong") != null) _MaTDuong = dr.GetString("MaTDuong");
            if (dr.GetString("QuyetDinhBH") != null) _QuyetDinhBH = dr.GetString("QuyetDinhBH");
            if (dr.GetString("TenBYte") != null) _TenBYTe = dr.GetString("TenBYte");
            if (dr.GetString("MaNguon") != null) _MaNguon = dr.GetString("MaNguon");
            if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");

            if (dr.GetString("QuyetDinh") != null) _QuyetDinh = dr.GetString("QuyetDinh");
            if (dr.GetString("TenTMBH") != null) _TenTMBH = dr.GetString("TenTMBH");
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetString("maql") != null) _maql = dr.GetString("maql");
            if (_maql == "")
                _maql = _maVT;
            if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("tenTA") != null) _tenTA = dr.GetString("tenTA");
            if (dr.GetString("MaNSX") != null) _maNSX = dr.GetString("MaNSX");
            if (dr.GetString("tenNSX") != null) _tenNSX = dr.GetString("tenNSX");

            if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
            if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
            if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
            if (dr.GetString("MaDVTHL") != null) _maDVTHL = dr.GetString("MaDVTHL");
            if (dr.GetString("tendvthl") != null) _tendvthl = dr.GetString("tendvthl");
            if (dr.GetBoolean("ApDungGoi") != null) _apDungGoi = dr.GetBoolean("ApDungGoi");
            if (dr.GetString("quycach") != null) _quycach = dr.GetString("quycach");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            if (dr.GetDecimal("Gianhap") != null) _gianhap = dr.GetDecimal("Gianhap");
            if (dr.GetSmartDate("Ngaynhap", true) != null) _ngaynhap = dr.GetSmartDate("Ngaynhap", true);
            if (dr.GetDecimal("Gianhap1") != null) _gianhap1 = dr.GetDecimal("Gianhap1");
            if (dr.GetSmartDate("Ngaynhap1", true) != null) _ngaynhap1 = dr.GetSmartDate("Ngaynhap1", true);
            if (dr.GetDecimal("Gianhap2") != null) _gianhap2 = dr.GetDecimal("Gianhap2");
            if (dr.GetSmartDate("Ngaynhap2", true) != null) _ngaynhap2 = dr.GetSmartDate("Ngaynhap2", true);
            if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
            if (dr.GetDecimal("DonGiaTT1") != null) _donGiaTT1 = dr.GetDecimal("DonGiaTT1");
            if (dr.GetDecimal("DongiaThuT") != null) _dongiaThuT = dr.GetDecimal("DongiaThuT");
            if (dr.GetDecimal("DongiaPhauT") != null) _dongiaPhauT = dr.GetDecimal("DongiaPhauT");
            if (dr.GetDecimal("DongiaCLS") != null) _dongiaCLS = dr.GetDecimal("DongiaCLS");
            if (dr.GetDecimal("GiaQuay") != null) _giaQuay = dr.GetDecimal("GiaQuay");
            if (dr.GetDecimal("GiaQuay1") != null) _giaQuay1 = dr.GetDecimal("GiaQuay1");
            if (dr.GetString("Khoban") != null) _khoban = dr.GetString("Khoban");
            if (dr.GetString("Khophat") != null) _khophat = dr.GetString("Khophat");
            if (dr.GetDecimal("Quydoi") != null) _quydoi = dr.GetDecimal("Quydoi");
            if (dr.GetString("MaDVT2") != null) _maDVT2 = dr.GetString("MaDVT2");
            if (dr.GetBoolean("VTThuT") != null) _vTThuT = dr.GetBoolean("VTThuT");
            if (dr.GetBoolean("VTPhauT") != null) _vTPhauT = dr.GetBoolean("VTPhauT");
            if (dr.GetBoolean("VTCLS") != null) _vTCLS = dr.GetBoolean("VTCLS");
            if (dr.GetBoolean("VTDuoc") != null) _vTDuoc = dr.GetBoolean("VTDuoc");
            if (dr.GetBoolean("VTBan") != null) _vTBan = dr.GetBoolean("VTBan");
            if (dr.GetBoolean("DuyetNgoaiT") != null) _duyetNgoaiT = dr.GetBoolean("DuyetNgoaiT");
            if (dr.GetBoolean("DuyetNoiT") != null) _duyetNoiT = dr.GetBoolean("DuyetNoiT");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetBoolean("VTNoiT") != null) _vTNoiT = dr.GetBoolean("VTNoiT");
            if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
            if (dr.GetByte("bh50") != null) _bh50 = dr.GetByte("bh50");
            if (dr.GetByte("DinhMuc") != null) _DinhMuc = dr.GetByte("DinhMuc");
        }

        /// <summary>
        /// Insert the new <see cref="DMVTYT" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMVTYT
            // Copy & paste ham duoi day vao file DataProvider.cs

            _maVT = InsertDMVTYT(_maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD, _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi, _loai, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _bh50,  _DinhMuc,_MaNguon);

            // public abstract String InsertDMVTYT(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH);
            // public override String InsertDMVTYT(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_CREATE", _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD , _vTNoiT, _maLH));
            // }
        }

        public string InsertDMVTYT(string _maNhom, string _maChungLoai, string _tenTM, string _tenTA, string _maNSX, decimal _nguong, string _maDVT, bool _apDungGoi, bool _handung, string _khoban, string _khophat, bool _vTThuT, bool _vTPhauT, bool _vTCLS, bool _vTDuoc, bool _vTBan, bool _duyetNgoaiT, bool _duyetNoiT, string _ghichu, string _maMay, string _nguoiSD, bool _vTNoiT, string _maLH, string _hamLuong, string _maDVTHL, bool _KhongSD, string _maql, string _quycach, string _maDVT2, decimal _quydoi, byte _loai, string _maBYTe, string _QuyetDinh, string _TenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe, byte _bh50,   byte _DinhMuc, string _MaNguon)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_CREATE_130", _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD, _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi, _loai, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _bh50,  _DinhMuc, _MaNguon));
        }

        /// <summary>
        /// Update all changes made on <see cref="DMVTYT" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT
            if (IsDirty)
            {

                //DataProvider.Instance().UpdateDMVTYT(_maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD, _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _bh50); // _MaHieuSP, DinhMuc


                UpdateDMVTYT(_maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD, _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _bh50, _DinhMuc , _MaNguon); // _MaHieuSP, DinhMuc
                // public abstract void UpdateDMVTYT(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH);
                // public override void UpdateDMVTYT(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_UPDATE", _maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , _vTNoiT, _maLH);
                // }				
            }
        }
        public string UpdateDMVTYT(string _maVT, string _maNhom, string _maChungLoai, string _tenTM, string _tenTA, string _maNSX, decimal _nguong, string _maDVT, bool _apDungGoi, bool _handung, string _khoban, string _khophat, bool _vTThuT, bool _vTPhauT, bool _vTCLS, bool _vTDuoc, bool _vTBan, bool _duyetNgoaiT, bool _duyetNoiT, string _ghichu, string _maMay, bool _huy, string _nguoiSD, bool _vTNoiT, string _maLH, string _hamLuong, string _maDVTHL, bool _KhongSD, string _maql, string _quycach, string _maDVT2, decimal _quydoi, string _maBYTe, string _QuyetDinh, string _TenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe, byte _bh50,  byte _DinhMuc , string _MaNguon )
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_UPDATE_130", _maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD, _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _bh50,  _DinhMuc, _MaNguon));
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maVT));
        }

        /// <summary>
        /// Delete the <see cref="DMVTYT" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT
            DataProvider.Instance().DeleteDMVTYT(crit.MaMay, crit.NguoiSD, crit.maVT);
            // public abstract void DeleteDMVTYT(String _maVT);
            // public override void DeleteDMVTYT(String _maVT);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_DELETED", _maVT);
            // }
        }

        #endregion
    }

    public DataTable spDMVTYT_GetBC(string MaVT)
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMVTYT_GetBC";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }


    
}







