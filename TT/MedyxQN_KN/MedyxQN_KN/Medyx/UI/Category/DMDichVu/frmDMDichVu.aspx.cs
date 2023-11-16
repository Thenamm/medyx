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
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Configuration;
using System.Globalization;
using System.Data.SqlClient;
using HTC.Business.PhongKham;
using Csla.Data;
using Csla.Validation;
using Csla;
using HTC.Business;

public partial class UI_Category_DMDichVu_frmDMDichVu : HTC.Common.Web.WebBase
{

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
    private const string ViewState_DMDichVu = "_DMDichVu";
    public DMDichVu _DMDichVu
    {
        get
        {
            if (ViewState[ViewState_DMDichVu] == null)
                ViewState[ViewState_DMDichVu] = DMDichVu.NewDMDichVu();


            return (DMDichVu)ViewState[ViewState_DMDichVu];
        }

        set
        {
            ViewState[ViewState_DMDichVu] = value;
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
    private const string ViewState_DMDichVuList = "_DMDichVuList";
    public DMDichVuList _DMDichVuList
    {
        get
        {
            if (ViewState[ViewState_DMDichVuList] == null)
            {
                ViewState[ViewState_DMDichVuList] = DMDichVuList.FindDMDichVuByNhomDVFilter("", "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);

            }

            return (DMDichVuList)ViewState[ViewState_DMDichVuList];
        }

        set
        {
            ViewState[ViewState_DMDichVuList] = value;
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;

            if (Request.QueryString["loai"] != null)
                _loai = byte.Parse(Request.QueryString["loai"].ToString());



            LoadData();

        }
    }
    string _maNhom = string.Empty;

    private void LoadData()
    {
        cboDsnhom.DataSource = DMNhomDVListcb.GetList();
        cboDsnhom.DataBind();
        cboNhomDV.DataSource = DMNhomDVListcb.GetList();
        cboNhomDV.DataBind();

        cboNhomBHXH.DataSource = GetDMDichVu_NhomBHXH();
        cboNhomBHXH.DataBind();


        cboDonVi.DataSource = DMDonvitinhListcb.GetList();
        cboDonVi.DataBind();
        cboNoiTH.DataSource = DMDichVuNoithuchienListcb.GetList();
        cboNoiTH.DataBind();
        cboKhoaTH1.DataSource = DMKhoaListcb.GetList();
        cboKhoaTH1.DataBind();

        cboKhoaTH2.DataSource = DMKhoaListcb.GetList();
        cboKhoaTH2.DataBind();
        cboKhoaTH3.DataSource = DMKhoaListcb.GetList();
        cboKhoaTH3.DataBind();
        cboKhoaLM1.DataSource = DMKhoaListcb.GetList();
        cboKhoaLM1.DataBind();

        cboKhoaLM2.DataSource = DMKhoaListcb.GetList();
        cboKhoaLM2.DataBind();
        cboKhoaLM3.DataSource = DMKhoaListcb.GetList();
        cboKhoaLM3.DataBind();
        cboBenhpham.DataSource = DMBenhPhamListcb.GetList();
        cboBenhpham.DataBind();
        cboKieuDV.DataSource = DMDichVuLoaiListcb.GetList();
        cboKieuDV.DataBind();
        cboChuyenkhoa.DataSource = DMChuyenKhoaListcb.GetList();
        cboChuyenkhoa.DataBind();
        cboLoaihinh.DataSource = DMPhanLoaiListcb.GetList();
        cboLoaihinh.DataBind();
        cboChungLoai.DataSource = DMChungLoaiListcb.GetList(_loai);
        cboChungLoai.DataBind();
        cboLoaiKQ.DataSource = DMDichVuLoaiKQListcb.GetList();
        cboLoaiKQ.DataBind();
        cboLoaiTT.DataSource = DMLoaiHinhListcb.GetList("00004");
        cboLoaiTT.DataBind();
        cboMaKHTH.DataSource = BC_DanhMuc_CMListcb.GetList();
        cboMaKHTH.DataBind();
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
            _DMDichVu = DMDichVu.NewDMDichVu();
        else

           _DMDichVu = DMDichVu.GetDMDichVu(_Selected_Ma);
       // cboNhomDV.SelectedValue = _DMDichVu.MaNhomDV;
        cboChungLoai.SelectedValue = _DMDichVu.Machungloai;
        if (_DMDichVu.Machungloai != "")
        {
            cboLoaihinh.DataSource = DMLoaiHinhListcb.GetList(cboChungLoai.SelectedValue);
            cboLoaihinh.DataBind();
        }
        cboLoaihinh.SelectedValue = _DMDichVu.maLH;
        cboLoaiTT.SelectedValue = _DMDichVu.maloaiTT;
        if (_DMDichVu.Donvi != "")
        {
            cboDonVi.SelectedValue = _DMDichVu.Donvi;
            cboDonVi.SelectedItem.Text = DMDonVi.GetDMDonVi(_DMDichVu.Donvi).TenDonVi;
        }
        cboNoiTH.SelectedValue = _DMDichVu.NoiThucHien.ToString();
        //cboKhoaTH.SelectedValue = _DMDichVu.Makhoa;
        cboKhoaTH2.SelectedValue = _DMDichVu.Makhoa087;
        cboKhoaTH3.SelectedValue = _DMDichVu.MakhoaNG;
        cboKhoaTH1.SelectedValue = _DMDichVu.Makhoa;
        cboKhoaLM2.SelectedValue = _DMDichVu.MakhoaLM087;
        cboKhoaLM3.SelectedValue = _DMDichVu.MakhoaLMNG;
        cboKhoaLM1.SelectedValue = _DMDichVu.MakhoaLM;
        try
        {
            cboBenhpham.SelectedValue = _DMDichVu.MaBenhPham;
        }
        catch
        {

        }
        cboKieuDV.SelectedValue = _DMDichVu.Loai.ToString();
        cboChuyenkhoa.SelectedValue = _DMDichVu.Machuyenkhoa;
        cboLoaiKQ.SelectedValue = _DMDichVu.LoaiKQ.ToString();
        txtCaoNam.Text = _DMDichVu.ChisocaoNam;
        txtCaoNu.Text = _DMDichVu.ChisocaoNu;
        txtThapNam.Text = _DMDichVu.ChisothapNam;
        txtThapNu.Text = _DMDichVu.ChisothapNu;
        txtTyLeBH.Text = _DMDichVu.ChisothapNu;

        txtMaDV.Text = _DMDichVu.MaDV;
        txtGhiChu.Text = _DMDichVu.Ghichu;
        chkInthu.Checked = _DMDichVu.InThu;
        txtPhieuYC.Text = _DMDichVu.FormSudung;
        txtPhieuYC2.Text = _DMDichVu.FormSudung087;
        txtTenTA.Text = _DMDichVu.TenTA;
        txtTenDV.Text = _DMDichVu.TenDV;
        txtTentat.Text = _DMDichVu.TenTat;
        txtSotieuban.Text = _DMDichVu.SoTban;
        txtQuyetDinh.Text = _DMDichVu.QuyetDinh;
        txtTenBH.Text = _DMDichVu.TenDVBH;
        txtMaBYTe.Text = _DMDichVu.MaBYTe;
        txtQuyetDinhBH.Text = _DMDichVu.QuyetDinhBH;
        txtTenBYte.Text = _DMDichVu.TenBYTe;
        txtMaBH.Text = _DMDichVu.MaBH;
        txtMaTDuong.Text = _DMDichVu.MaTDuong;
        txtMaCSBH.Text = _DMDichVu.MaCSBH;
        txtTenCSBH.Text = _DMDichVu.TenCSBH;
        txtMaMayXNBH.Text = _DMDichVu.MaMayXNBH;
        txtDonGiaBD.Text = _DMDichVu.gtHoaHong.ToString("###,###");
        txtTyLeBH.Text = _DMDichVu.BHTra.ToString("###");
        cboMaKHTH.SelectedValue = _DMDichVu.makhth;
        cboNhomBHXH.SelectedValue = _DMDichVu.NhomBHXH;

        if (_DMDichVu.makhth != "")
        {
            BC_DanhMuc_CMListcb a = BC_DanhMuc_CMListcb.GetList();
            cboMaKHTH.Text = a.FirstOrDefault(x => x.Key == _DMDichVu.makhth).Value;
        }
        chkApdunggoi.Checked = _DMDichVu.ApdungGoi;
        chkApdungNK.Checked = _DMDichVu.apdungnk;
        chkApdungNT.Checked = _DMDichVu.apdungnt;
        chkApdungPK.Checked = _DMDichVu.apdungpk;
        chkBCThu.Checked = _DMDichVu.BCThu;
        chkDichvugui.Checked = _DMDichVu.DichVuGui;
        chkHuy.Checked = _DMDichVu.Huy;
        chkKythuatcao.Checked = _DMDichVu.KTCao;
        chkLaymauTT.Checked = _DMDichVu.LayMauTT;
        chkNhapSL.Checked = _DMDichVu.NhapSL;
        chkSuagia.Checked = _DMDichVu.apdungsuagia;
        if (pub_bQadmin == false && HTC.ShareVariables.pub_spC == "YH" && _DMDichVu.IsNew == true)
        {
            _DMDichVu.Huy = true;
            chkHuy.Checked = true;
        }
        if (pub_bQadmin == true || HTC.ShareVariables.pub_spC == "PS")
            chkHuy.Visible = true;
        else
            chkHuy.Visible = true;



        DataTable dt = spDMUpdate_DV_NhomBHXH(_DMDichVu.MaDV);
        if (dt != null && dt.Rows.Count > 0)
        {
            string madichvu = dt.Rows[0][0].ToString();
            string tendichvu = dt.Rows[0][1].ToString();
            
            cboNhomBHXH.SelectedValue = madichvu;
            cboNhomBHXH.Text = tendichvu;
            
        }
    }
    private void UpdateData()
    {
        try
        {
            if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fSua)
                if (_DMDichVu.IsNew == false)
                    return;
            if ((txtKyTu.Text == "" || txtTenDV.Text == "" || txtKyTu.Text.Length != 2) && _DMDichVu.IsNew == true)
            {
                ShowMessage("Chưa nhập ký tự đầu");
                return;
            }
            if ((txtTenDV.Text == ""))
            {
                ShowMessage("Chưa nhập tên dịch vụ");
                return;
            }
            if (cboChungLoai.SelectedValue == "" || cboChungLoai.SelectedValue == null)
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            if (cboChungLoai.SelectedValue == "00003" && (cboLoaihinh.SelectedValue == "" || cboLoaihinh.SelectedValue == null))
            {
                ShowMessage("Chưa nhập loại hình");
                return;
            }
            if ((cboNhomDV.SelectedValue == "" || cboNhomDV.SelectedValue == null) && HTC.ShareVariables.pub_spC == "HU")
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            _DMDichVu.MaNhomDV = cboNhomDV.SelectedValue;
            _DMDichVu.Machungloai = cboChungLoai.SelectedValue;
            _DMDichVu.maLH = cboLoaihinh.SelectedValue;
            _DMDichVu.maloaiTT = cboLoaiTT.SelectedValue;
            //cboDonVi.SelectedValue = _DMDichVu.MaDVT;
            //cboDonVi.SelectedItem.Text = _DMDichVu.tendvt;
            _DMDichVu.Donvi = cboDonVi.SelectedValue;
            _DMDichVu.NoiThucHien = byte.Parse(cboNoiTH.SelectedValue);
            _DMDichVu.Makhoa = cboKhoaTH1.SelectedValue;
            _DMDichVu.Makhoa087 = cboKhoaTH2.SelectedValue;
            _DMDichVu.MakhoaNG = cboKhoaTH3.SelectedValue;
            _DMDichVu.MakhoaLM = cboKhoaLM1.SelectedValue;
            _DMDichVu.MakhoaLM087 = cboKhoaLM2.SelectedValue;
            _DMDichVu.MakhoaLMNG = cboKhoaLM3.SelectedValue;
            _DMDichVu.MaBenhPham = cboBenhpham.SelectedValue;
            _DMDichVu.Loai = byte.Parse(cboKieuDV.SelectedValue);
            _DMDichVu.Machuyenkhoa = cboChuyenkhoa.SelectedValue;
            _DMDichVu.LoaiKQ = byte.Parse(cboLoaiKQ.SelectedValue);
            _DMDichVu.ChisocaoNam = txtCaoNam.Text;
            _DMDichVu.ChisocaoNu = txtCaoNu.Text;
            _DMDichVu.ChisothapNam = txtThapNam.Text;
            _DMDichVu.ChisothapNu = txtThapNu.Text;
            _DMDichVu.kytu = txtKyTu.Text;
            _DMDichVu.MaBYTe = txtMaBYTe.Text;
            _DMDichVu.QuyetDinh = txtQuyetDinh.Text;
            _DMDichVu.TenDVBH = txtTenBH.Text;
            _DMDichVu.MaBH = txtMaBH.Text;
            _DMDichVu.MaTDuong = txtMaTDuong.Text;
            _DMDichVu.makhth = cboMaKHTH.SelectedValue;
            _DMDichVu.QuyetDinhBH = txtQuyetDinhBH.Text;
            _DMDichVu.TenBYTe = txtTenBYte.Text;
            _DMDichVu.MaDV = txtMaDV.Text;
            _DMDichVu.TenTA = txtTenTA.Text;
            _DMDichVu.TenDV = txtTenDV.Text;
            _DMDichVu.TenTat = txtTentat.Text;
            _DMDichVu.SoTban = txtSotieuban.Text;
            _DMDichVu.ApdungGoi = chkApdunggoi.Checked;
            _DMDichVu.apdungnk = chkApdungNK.Checked;
            _DMDichVu.apdungnt = chkApdungNT.Checked;
            _DMDichVu.apdungpk = chkApdungPK.Checked;
            _DMDichVu.BCThu = chkBCThu.Checked;
            _DMDichVu.DichVuGui = chkDichvugui.Checked;
            _DMDichVu.MaCSBH = txtMaCSBH.Text;
            _DMDichVu.TenCSBH = txtTenCSBH.Text;
            _DMDichVu.MaMayXNBH = txtMaMayXNBH.Text;
            _DMDichVu.NhomBHXH = cboNhomBHXH.SelectedValue;
            if (txtTyLeBH.Text == "")
                _DMDichVu.BHTra = 100;
            else
                _DMDichVu.BHTra = decimal.Parse(txtTyLeBH.Text);

            if (txtDonGiaBD.Text == "")
                _DMDichVu.gtHoaHong = 0;
            else
                _DMDichVu.gtHoaHong = decimal.Parse(txtDonGiaBD.Text);

            if ((pub_bQadmin == true || pub_bSgia == true) && _DMDichVu.Huy == true)
                _DMDichVu.Huy = chkHuy.Checked;
            _DMDichVu.KTCao = chkKythuatcao.Checked;
            _DMDichVu.LayMauTT = chkLaymauTT.Checked;
            _DMDichVu.NhapSL = chkNhapSL.Checked;
            _DMDichVu.apdungsuagia = chkSuagia.Checked;
            _DMDichVu.Ghichu = txtGhiChu.Text;
            _DMDichVu.FormSudung = txtPhieuYC.Text;
            _DMDichVu.FormSudung087 = txtPhieuYC2.Text; 
            _DMDichVu.InThu = chkInthu.Checked;

            if (_action != FormAction.DELETE)
            {
                //_DMDichVu.ApplyEdit();          
                //DMDichVu tmp = _DMDichVu.Clone();
                //_DMDichVu = tmp.Save();                                

            }
            else
            {
                _DMDichVu.NguoiHuy = Pub_sNguoiSD;

                _DMDichVu.MaMay = Pub_sMaMay;


                DMDichVu.DeleteDMDichVu(_DMDichVu.MaDV, Pub_sMaMay, Pub_sNguoiSD);
            }
            if (_action == FormAction.EDIT)
            {

                _DMDichVu.NguoiSD = Pub_sNguoiSD;
                _DMDichVu.MaMay = Pub_sMaMay;
               // _DMDichVuList.UpdatedTo(_DMDichVu);

                _DMDichVu.Save();

            }
            else if (_action == FormAction.INSERT)
            {
                _DMDichVu.NguoiLap = Pub_sNguoiSD;

                _DMDichVu.MaMay = Pub_sMaMay;
              //  _DMDichVuList.NewTo(_DMDichVu);
                _DMDichVu.ApplyEdit();
                _DMDichVu.Save();
            }
            else
            {
                _DMDichVu.NguoiHuy = Pub_sNguoiSD;

                _DMDichVu.MaMay = Pub_sMaMay;
             //  _DMDichVuList.RemoveTo(_DMDichVu);
                DMDichVu.DeleteDMDichVu(_DMDichVu.MaDV, Pub_sMaMay, Pub_sNguoiSD);
            }


            string sql = "UPDATE DMDichVu SET NhomBHXH = '" + cboNhomBHXH.SelectedValue + "' WHERE madv = '" + _DMDichVu.MaDV + "'";
            HTC.Business.DataProvider.Instance().ExcSQL(sql);

            _action = FormAction.INSERT;
            LoadDetail();
            grdChiTiet.DataSource = _DMDichVuList;
            grdChiTiet.DataBind();

        }


        catch (Exception ex)
        {
            ShowMessage("Không lưu được dữ liệu" + ex.Message);

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
                string _maDV = editedItem.GetDataKeyValue("MaDV").ToString();

                HTC.Business.DataProvider.Instance().DeleteDMDichVu(Pub_sMaMay, Pub_sNguoiSD, _maDV);
                _DMDichVuList = null;
                grdChiTiet.DataSource = _DMDichVuList;
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

    protected void grdChiTiet_UpdateCommand(object sender, GridCommandEventArgs e)
    {

    }

    protected void grdChiTiet_InsertCommand(object sender, GridCommandEventArgs e)
    {
    }
    protected void grdChiTiet_PageIndexChanged(object sender, GridPageChangedEventArgs e)
    {

        string sql = "";
        sql = " and row >= " + ((e.NewPageIndex) * grdChiTiet.PageSize).ToString() + " and row < " + ((e.NewPageIndex + 1) * grdChiTiet.PageSize).ToString();

        if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            _DMDichVuList = DMDichVuList.FindDMDichVuByFilter(_FilterSql, sql, pub_bQadmin);
        else
            _DMDichVuList = DMDichVuList.FindDMDichVuByFilter(_FilterSql + " and a.manhomdv like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMDichVuList.record;
        grdChiTiet.DataSource = _DMDichVuList;
        grdChiTiet.DataBind();
    }
    protected void grdChiTiet_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
    {
        string sql = "";
        sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * e.NewPageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * e.NewPageSize).ToString();
        if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            _DMDichVuList = DMDichVuList.FindDMDichVuByFilter(_FilterSql, sql, pub_bQadmin);
        else
            _DMDichVuList = DMDichVuList.FindDMDichVuByFilter(_FilterSql + " and a.manhomdv like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMDichVuList.record;
        grdChiTiet.DataSource = _DMDichVuList;
        grdChiTiet.DataBind();
    }
    protected void grdChiTiet_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
        grdChiTiet.VirtualItemCount = _DMDichVuList.record;
        grdChiTiet.DataSource = _DMDichVuList;

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
            TextBox filterBoxMaDV = item["MaDV"].Controls[0] as TextBox;

            TextBox filterBoxTenDV = item["TenDV"].Controls[0] as TextBox;
            TextBox filterBoxTenTat = item["TenTat"].Controls[0] as TextBox;

            TextBox filterBoxTenDVT = item["DonVi"].Controls[0] as TextBox;
            TextBox filterBoxTenMaMay = item["MaMay"].Controls[0] as TextBox;
            TextBox filterBoxTenNgaySD = item["NgaySD"].Controls[0] as TextBox;
            string FilterSql = "";
            if (filterBoxTenDV.Text != "")
            {
                FilterSql = FilterSql + "and a.tendv like N'%" + filterBoxTenDV.Text + "%'";
            }
            if (filterBoxMaDV.Text != "")
            {
                FilterSql = FilterSql + "and a.madv like N'%" + filterBoxMaDV.Text + "%'";
            }
            if (filterBoxTenDVT.Text != "")
            {
                FilterSql = FilterSql + "and a.DonVi like N'%" + filterBoxTenDVT.Text + "%'";
            }
            if (filterBoxTenTat.Text != "")
            {
                FilterSql = FilterSql + "and a.tentat like N'%" + filterBoxTenTat.Text + "%'";
            }
            if (filterBoxTenMaMay.Text != "")
            {
                FilterSql = FilterSql + "and a.mamay like N'%" + filterBoxTenMaMay.Text + "%'";
            }
            if (filterBoxTenNgaySD.Text != "")
            {
                FilterSql = FilterSql + "and a.ngaysd = '" + filterBoxTenNgaySD.Text + "'";
            }
            if (FilterSql != "")
                FilterSql = " " + FilterSql;
            grdChiTiet.CurrentPageIndex = 0;
            string sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * grdChiTiet.PageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * grdChiTiet.PageSize).ToString();
            _FilterSql = FilterSql;
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMDichVuList = DMDichVuList.FindDMDichVuByFilter(_FilterSql, sql, pub_bQadmin);
            else
                _DMDichVuList = DMDichVuList.FindDMDichVuByFilter(_FilterSql + " and a.manhomdv like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);

            grdChiTiet.VirtualItemCount = _DMDichVuList.record;

            grdChiTiet.DataSource = _DMDichVuList;
            grdChiTiet.DataBind();
        }
        else if (e.CommandName == "Edit")
        {
            GridDataItem item = e.Item as GridDataItem;

            if (item != null)
            {
                if (item.GetDataKeyValue("MaDV") != null)
                {
                    _Selected_Ma = item.GetDataKeyValue("MaDV").ToString();
                    //_DMDichVu = DMDichVu.GetDMDichVu(_Selected_Ma);
                    //_DMDichVu.OrderNumber = int.Parse(item.GetDataKeyValue("OrderNumber").ToString());
                   // _DMDichVu = _DMDichVuList[int.Parse(item.GetDataKeyValue("OrderNumber").ToString()) - 1];
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
            case "cmdExport":
                ExportData();

                break;
            case "cmdAdd":
                _action = FormAction.INSERT;
                LoadDetail();

                break;
            case "cmdDelete":
                _action = FormAction.DELETE;
                UpdateData();
                _action = FormAction.INSERT;
                LoadDetail();
                break;
            case "cmdFilter":
                _FilterSql = "";
                grdChiTiet.AllowFilteringByColumn = !grdChiTiet.AllowFilteringByColumn;
                grdChiTiet.DataSource = _DMDichVuList;
                grdChiTiet.DataBind();
                //if (grdChiTiet.AllowFilteringByColumn == true)
                //    grdChiTiet.AllowFilteringByColumn = false;
                //else
                //    grdChiTiet.AllowFilteringByColumn = true;


                break;
            case "cmdView":
                _FilterSql = "";
                _DMDichVuList = null;

                grdChiTiet.DataSource = _DMDichVuList;
                grdChiTiet.DataBind();
                break;
            case "cmdGoi":
                Response.Redirect("~/UI/Category/DMDichVu/frmDMDichVu_Goi.aspx?loai=" + _loai + "&MaDVGoi=" + txtMaDV.Text + "&TenDVGoi=" + txtTenDV.Text);

                break;
            case "cmdDMVT":
                Response.Redirect("~/UI/Category/DMDichVu/frmDMDichVu_VT.aspx?loai=" + _loai + "&MaDV=" + txtMaDV.Text + "&TenDV=" + txtTenDV.Text);

                break;
            case "cmdDMThuoc":
                Response.Redirect("~/UI/Category/DMDichVu/frmDMDichVu_Thuoc.aspx?loai=" + _loai + "&MaDV=" + txtMaDV.Text + "&TenDV=" + txtTenDV.Text);

                break;
            case "cmdDMHC":
                Response.Redirect("~/UI/Category/DMDichVu/frmDMDichVu_HC.aspx?loai=" + _loai + "&MaDV=" + txtMaDV.Text + "&TenDV=" + txtTenDV.Text);

                break;
            case "cmdExit":
                Response.Redirect("~/Default.aspx");
                break;
            case "cmdPhieuHen":
                Response.Redirect("~/UI/Category/DMDichVu/FrmDMDichVu_PhieuHen.aspx?madv=" + txtMaDV.Text + "&loaiKQ=" + cboLoaiKQ.SelectedItem.Value);

                break;
            case "cmdNhapKQ":
                if (cboLoaiKQ.SelectedItem.Value == "1" || cboLoaiKQ.SelectedItem.Value == "2")
                {
                    Response.Redirect("~/UI/Category/DMDichVu/frmDMDichVu_CS.aspx?madv=" + txtMaDV.Text + "&tendv=" + txtTenDV.Text);
                }
                if (cboLoaiKQ.SelectedItem.Value == "4" || cboLoaiKQ.SelectedItem.Value == "5")
                {
                    Response.Redirect("~/UI/Category/DMDichVu/FrmDMDichVu_Mahoa.aspx?madv=" + txtMaDV.Text + "&loaiKQ=" + cboLoaiKQ.SelectedItem.Value);
                }
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
    protected void cboDsNhom_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        _FilterSql = "";
        grdChiTiet.CurrentPageIndex = 0;
        if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            _DMDichVuList = DMDichVuList.FindDMDichVuByNhomDVFilter("", "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);

        else
            _DMDichVuList = DMDichVuList.FindDMDichVuByNhomDVFilter(cboDsnhom.SelectedValue, "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMDichVuList.record;
        grdChiTiet.DataSource = _DMDichVuList;
        grdChiTiet.DataBind();
    }
    private void ExportData()
    {
        try
        {
            string filename = "DMDichVu_" + DateTime.Now.Date.ToString() + ".xls";
            string excelHeader = "DMDichVu";
            System.IO.StringWriter tw = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
            DataGrid dgGrid = new DataGrid();

            dgGrid.DataSource = HTC.Business.DataProvider.Instance().RptDMDichVu_GIA_RPT("10002", "", false);
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
    public static List<DMDichVu_NhomBHXH> GetDMDichVu_NhomBHXH()
    {
        List<DMDichVu_NhomBHXH> List = new List<DMDichVu_NhomBHXH>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDichVu_NhomBHXH_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMDichVu_NhomBHXH(dr, i));
            }
        }
        return List;
    }

    public class DMDichVu_NhomBHXH
    {
        private String _maDV = String.Empty;
        private String _tenDV = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _maBHXH = String.Empty;
        private int _OrderNumber;
        public String MaDV
        {
            get
            {
                return _maDV;
            }
            set
            {
                if (_maDV != value)
                {
                    _maDV = value;
                }
            }
        }
        public String TenDV
        {
            get
            {
                return _tenDV;
            }
            set
            {
                if (_tenDV != value)
                {
                    _tenDV = value;
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
        public DMDichVu_NhomBHXH(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaDV"].GetType().Name != "DBNull" && dr["MaDV"] != null)
            {
                this.MaDV = Convert.ToString(dr["MaDV"]);
            }
            else
            {
                this.MaDV = "";
            }
            if (dr["TenDV"].GetType().Name != "DBNull" && dr["TenDV"] != null)
            {
                this.TenDV = Convert.ToString(dr["TenDV"]);
            }
            else
            {
                this.TenDV = "";
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


    public DataTable spDMUpdate_DV_NhomBHXH(string madv) 
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMUpdate_DV_NhomBHXH";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@madv", madv));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }

    [Serializable]
    public  class DMDichVu : BusinessBase<DMDichVu>
    {
        #region Business Methods

        #region State Fields
        private String _MaBS = String.Empty;
        private String _maDV = String.Empty;
        private String _maNhomDV = String.Empty;
        private String _tenDV = String.Empty;
        private String _tenTA = String.Empty;
        private String _maBYTe = String.Empty;
        private String _kytu = String.Empty;
        private String _TenDVBH = String.Empty;
        private String _QuyetDinh = String.Empty;
        private Boolean _nhapSL = false;
        private String _tenTat = String.Empty;
        private String _soTban = String.Empty;  //
        private String _maLH = String.Empty;  //
        private Decimal _dongiaTT = 0;
        private Decimal _dongiaTT1 = 0;
        private SmartDate _ngayTT1 = new SmartDate(true);
        private String _makhoa = String.Empty;   //String.Empty;
        private String _makhoa087 = String.Empty;   //String.Empty;
        private String _makhoaNG = String.Empty;   //String.Empty;
        private String _makhoaLM = String.Empty;   //String.Empty;
        private String _makhoaLM087 = String.Empty;   //String.Empty;
        private String _makhoaLMNG = String.Empty;   //String.Empty;
        private String _tenTMBH = String.Empty;
        private String _makhth = String.Empty;
        private String _machuyenkhoa = String.Empty;
        private String _machungloai = String.Empty;//
        private Byte _loai = 0;
        private Byte _noiThucHien = 0;  //
        private String _maCQ = String.Empty;  //
        private String _maBenhPham = String.Empty;  //
        private Boolean _KTCao = false;  //
        private Boolean _LayMauTT = false;  //
        private String _chisocaoNu = String.Empty;
        private String _chisocaoNam = String.Empty;
        private String _chisothapNu = String.Empty;
        private String _chisothapNam = String.Empty;
        private String _donvi = String.Empty;
        private Boolean _apdungGoi = true;
        private Boolean _dichVuGui = false;
        private Byte _loaiKQ = 0;
        private String _formSudung = String.Empty;
        private String _formSudung087 = String.Empty;
        private Decimal _BHTra = 0;
        private Decimal _gtHoaHong = 0;
        private Decimal _HoaHong = 0;
        private Boolean _tToanSau = false;
        private Boolean _tToanNgay = false;
        private Boolean _bCThu = false;
        private Boolean _inThu = false;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngayHuy = new SmartDate();
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate();
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(false);
        private String _nguoiSD1 = String.Empty;
        private Boolean _huy = false;
        private Boolean _apdungpk = false;
        private Boolean _apdungnt = false;
        private Boolean _apdungnk = false;
        private Boolean _apdungsuagia = false;
        private String _maloaiTT = String.Empty;
        private String _CLS1lan = String.Empty;
        private String _tendd = String.Empty;
        private String _QuyetDinhBH = String.Empty;
        private String _MaBH = String.Empty; private string _MaTDuong = String.Empty;
        private String _TenBYTe = String.Empty;
        private int _OrderNumber;
        private String _tenCSBH = String.Empty;
        private String _maCSBH = String.Empty;
        private String _maMayXNBH = String.Empty;
        private String _NhomBHXH = String.Empty;
        #endregion

        #region Business Properties and Methods


        public String NhomBHXH
        {
            get
            {
                CanReadProperty("NhomBHXH", true);
                return _NhomBHXH;
            }
            set
            {
                CanWriteProperty("NhomBHXH", true);
                if (_NhomBHXH != value)
                {
                    _NhomBHXH = value;
                    PropertyHasChanged("NhomBHXH");
                }
            }
        }


        public String MaMayXNBH
        {
            get
            {
                CanReadProperty("MaMayXNBH", true);
                return _maMayXNBH;
            }
            set
            {
                CanWriteProperty("MaMayXNBH", true);
                if (_maMayXNBH != value)
                {
                    _maMayXNBH = value;
                    PropertyHasChanged("MaMayXNBH");
                }
            }
        }
        public String MaCSBH
        {
            get
            {
                CanReadProperty("MaCSBH", true);
                return _maCSBH;
            }
            set
            {
                CanWriteProperty("MaCSBH", true);
                if (_maCSBH != value)
                {
                    _maCSBH = value;
                    PropertyHasChanged("MaCSBH");
                }
            }
        }
        public String TenCSBH
        {
            get
            {
                CanReadProperty("TenCSBH", true);
                return _tenCSBH;
            }
            set
            {
                CanWriteProperty("TenCSBH", true);
                if (_tenCSBH != value)
                {
                    _tenCSBH = value;
                    PropertyHasChanged("TenCSBH");
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
        public String tendd
        {
            get
            {
                if (_tenTat.Length > 1)
                    _tendd = _tenTat.Substring(0, 2) + " " + _tenDV;
                else
                    _tendd = _tenDV;
                CanReadProperty("tendd", true);
                return _tendd;
            }
        }
        public String TenDVDu
        {
            get
            {

                return _maDV + "-" + _tenDV;
            }

        }
        public String maloaiTT
        {
            get
            {
                CanReadProperty("maloaiTT", true);
                return _maloaiTT;
            }
            set
            {
                CanWriteProperty("maloaiTT", true);
                if (_maloaiTT != value)
                {
                    _maloaiTT = value;
                    PropertyHasChanged("maloaiTT");
                }
            }
        }

        public String CLS1lan
        {
            get
            {
                CanReadProperty("CLS1lan", true);
                return _CLS1lan;
            }
            set
            {
                CanWriteProperty("CLS1lan", true);
                if (_CLS1lan != value)
                {
                    _CLS1lan = value;
                    PropertyHasChanged("CLS1lan");
                }
            }
        }


        public String MaDV
        {
            get
            {
                CanReadProperty("MaDV", true);
                return _maDV;
            }
            set
            {
                CanWriteProperty("MaDV", true);
                if (_maDV != value)
                {
                    _maDV = value;
                    PropertyHasChanged("MaDV");
                }
            }
        }

        public String MaBS
        {
            get
            {
                CanReadProperty("MaBS", true);
                return _MaBS;
            }
            set
            {
                CanWriteProperty("MaBS", true);
                if (_MaBS != value)
                {
                    _MaBS = value;
                    PropertyHasChanged("MaBS");
                }
            }
        }



        public String kytu
        {
            get
            {
                CanReadProperty("kytu", true);
                return _kytu;
            }
            set
            {
                CanWriteProperty("kytu", true);
                if (_kytu != value)
                {
                    _kytu = value;
                    PropertyHasChanged("kytu");
                }
            }
        }
        public String MaNhomDV
        {
            get
            {
                CanReadProperty("MaNhomDV", true);
                return _maNhomDV;
            }
            set
            {
                CanWriteProperty("MaNhomDV", true);
                if (_maNhomDV != value)
                {
                    _maNhomDV = value;
                    PropertyHasChanged("MaNhomDV");
                }
            }
        }

        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
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
        public String TenDVBH
        {
            get
            {
                CanReadProperty("TenDVBH", true);
                return _TenDVBH;
            }
            set
            {
                CanWriteProperty("TenDVBH", true);
                if (_TenDVBH != value)
                {
                    _TenDVBH = value;
                    PropertyHasChanged("TenDVBH");
                }
            }
        }
        public Boolean NhapSL
        {
            get
            {
                CanReadProperty("NhapSL", true);
                return _nhapSL;
            }
            set
            {
                CanWriteProperty("NhapSL", true);
                if (_nhapSL != value)
                {
                    _nhapSL = value;
                    PropertyHasChanged("NhapSL");
                }
            }
        }

        public String TenTat
        {
            get
            {
                CanReadProperty("TenTat", true);
                return _tenTat;
            }
            set
            {
                CanWriteProperty("TenTat", true);
                if (_tenTat != value)
                {
                    _tenTat = value;
                    PropertyHasChanged("TenTat");
                }
            }
        }

        public String SoTban
        {
            get
            {
                CanReadProperty("SoTban", true);

                return _soTban;
            }
            set
            {
                CanWriteProperty("SoTban", true);
                if (_soTban != value)
                {
                    _soTban = value;
                    PropertyHasChanged("SoTban");
                }
            }
        }

        public String maLH
        {
            get
            {
                CanReadProperty("maLH", true);
                return _maLH;
            }
            set
            {
                CanWriteProperty("maLH", true);
                if (_maLH != value)
                {
                    _maLH = value;
                    PropertyHasChanged("maLH");
                }
            }
        }

        public Decimal DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                return _dongiaTT;
            }
            set
            {
                CanWriteProperty("DongiaTT", true);
                if (_dongiaTT != value)
                {
                    _dongiaTT = value;
                    PropertyHasChanged("DongiaTT");
                }
            }
        }

        public Decimal DongiaTT1
        {
            get
            {
                CanReadProperty("DongiaTT1", true);
                return _dongiaTT1;
            }
            set
            {
                CanWriteProperty("DongiaTT1", true);
                if (_dongiaTT1 != value)
                {
                    _dongiaTT1 = value;
                    PropertyHasChanged("DongiaTT1");
                }
            }
        }

        public string NgayTT1
        {
            get
            {
                CanReadProperty("NgayTT1", true);
                return _ngayTT1.Text;
            }
            set
            {
                CanWriteProperty("NgayTT1", true);
                if (_ngayTT1.Text != value)
                {
                    _ngayTT1.Text = value;
                    PropertyHasChanged("NgayTT1");
                }
            }
        }

        public String Makhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("Makhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("Makhoa");
                }
            }
        }
        public String Makhoa087
        {
            get
            {
                CanReadProperty("Makhoa087", true);
                return _makhoa087;
            }
            set
            {
                CanWriteProperty("Makhoa087", true);
                if (_makhoa087 != value)
                {
                    _makhoa087 = value;
                    PropertyHasChanged("Makhoa087");
                }
            }
        }
        public String MakhoaNG
        {
            get
            {
                CanReadProperty("MakhoaNG", true);
                return _makhoaNG;
            }
            set
            {
                CanWriteProperty("MakhoaNG", true);
                if (_makhoaNG != value)
                {
                    _makhoaNG = value;
                    PropertyHasChanged("MakhoaNG");
                }
            }
        }
        public String MakhoaLM
        {
            get
            {
                CanReadProperty("MakhoaLM", true);
                return _makhoaLM;
            }
            set
            {
                CanWriteProperty("MakhoaLM", true);
                if (_makhoaLM != value)
                {
                    _makhoaLM = value;
                    PropertyHasChanged("MakhoaLM");
                }
            }
        }
        public String MakhoaLM087
        {
            get
            {
                CanReadProperty("MakhoaLM087", true);
                return _makhoaLM087;
            }
            set
            {
                CanWriteProperty("MakhoaLM087", true);
                if (_makhoaLM087 != value)
                {
                    _makhoaLM087 = value;
                    PropertyHasChanged("MakhoaLM087");
                }
            }
        }
        public String MakhoaLMNG
        {
            get
            {
                CanReadProperty("MakhoaLMNG", true);
                return _makhoaLMNG;
            }
            set
            {
                CanWriteProperty("MakhoaLMNG", true);
                if (_makhoaLMNG != value)
                {
                    _makhoaLMNG = value;
                    PropertyHasChanged("MakhoaLMNG");
                }
            }
        }


        public String tenTMBH
        {
            get
            {
                CanReadProperty("tenTMBH", true);
                return _tenTMBH;
            }
            set
            {
                CanWriteProperty("tenTMBH", true);
                if (_tenTMBH != value)
                {
                    _tenTMBH = value;
                    PropertyHasChanged("tenTMBH");
                }
            }
        }







        public String makhth
        {
            get
            {
                CanReadProperty("makhth", true);
                return _makhth;
            }
            set
            {
                CanWriteProperty("makhth", true);
                if (_makhth != value)
                {
                    _makhth = value;
                    PropertyHasChanged("makhth");
                }
            }
        }

        public String Machuyenkhoa
        {
            get
            {
                CanReadProperty("Machuyenkhoa", true);
                return _machuyenkhoa;
            }
            set
            {
                CanWriteProperty("Machuyenkhoa", true);
                if (_machuyenkhoa != value)
                {
                    _machuyenkhoa = value;
                    PropertyHasChanged("Machuyenkhoa");
                }
            }
        }

        public String Machungloai
        {
            get
            {
                CanReadProperty("Machungloai", true);
                return _machungloai;
            }
            set
            {
                CanWriteProperty("Machungloai", true);
                if (_machungloai != value)
                {
                    _machungloai = value;
                    PropertyHasChanged("Machungloai");
                }
            }
        }

        public Byte Loai
        {
            get
            {
                CanReadProperty("Loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("Loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("Loai");
                }
            }
        }

        public Byte NoiThucHien
        {
            get
            {
                CanReadProperty("NoiThucHien", true);
                return _noiThucHien;
            }
            set
            {
                CanWriteProperty("NoiThucHien", true);
                if (_noiThucHien != value)
                {
                    _noiThucHien = value;
                    PropertyHasChanged("NoiThucHien");
                }
            }
        }

        public String MaCQ
        {
            get
            {
                CanReadProperty("MaCQ", true);
                return _maCQ;
            }
            set
            {
                CanWriteProperty("MaCQ", true);
                if (_maCQ != value)
                {
                    _maCQ = value;
                    PropertyHasChanged("MaCQ");
                }
            }
        }

        public String MaBenhPham
        {
            get
            {
                CanReadProperty("MaBenhPham", true);
                return _maBenhPham;
            }
            set
            {
                CanWriteProperty("MaBenhPham", true);
                if (_maBenhPham != value)
                {
                    _maBenhPham = value;
                    PropertyHasChanged("MaBenhPham");
                }
            }
        }

        public Boolean KTCao
        {
            get
            {
                CanReadProperty("KTCao", true);
                return _KTCao;
            }
            set
            {
                CanWriteProperty("KTCao", true);
                if (_KTCao != value)
                {
                    _KTCao = value;
                    PropertyHasChanged("KTCao");
                }
            }
        }
        public Boolean LayMauTT
        {
            get
            {
                CanReadProperty("LayMauTT", true);
                return _LayMauTT;
            }
            set
            {
                CanWriteProperty("LayMauTT", true);
                if (_LayMauTT != value)
                {
                    _LayMauTT = value;
                    PropertyHasChanged("LayMauTT");
                }
            }
        }

        public String ChisocaoNu
        {
            get
            {
                CanReadProperty("ChisocaoNu", true);
                return _chisocaoNu;
            }
            set
            {
                CanWriteProperty("ChisocaoNu", true);
                if (_chisocaoNu != value)
                {
                    _chisocaoNu = value;
                    PropertyHasChanged("ChisocaoNu");
                }
            }
        }

        public String ChisocaoNam
        {
            get
            {
                CanReadProperty("ChisocaoNam", true);
                return _chisocaoNam;
            }
            set
            {
                CanWriteProperty("ChisocaoNam", true);
                if (_chisocaoNam != value)
                {
                    _chisocaoNam = value;
                    PropertyHasChanged("ChisocaoNam");
                }
            }
        }

        public String ChisothapNu
        {
            get
            {
                CanReadProperty("ChisothapNu", true);
                return _chisothapNu;
            }
            set
            {
                CanWriteProperty("ChisothapNu", true);
                if (_chisothapNu != value)
                {
                    _chisothapNu = value;
                    PropertyHasChanged("ChisothapNu");
                }
            }
        }

        public String ChisothapNam
        {
            get
            {
                CanReadProperty("ChisothapNam", true);
                return _chisothapNam;
            }
            set
            {
                CanWriteProperty("ChisothapNam", true);
                if (_chisothapNam != value)
                {
                    _chisothapNam = value;
                    PropertyHasChanged("ChisothapNam");
                }
            }
        }

        public String Donvi
        {
            get
            {
                CanReadProperty("Donvi", true);
                return _donvi;
            }
            set
            {
                CanWriteProperty("Donvi", true);
                if (_donvi != value)
                {
                    _donvi = value;
                    PropertyHasChanged("Donvi");
                }
            }
        }
        public Boolean ApdungGoi
        {
            get
            {
                CanReadProperty("ApdungGoi", true);
                return _apdungGoi;
            }
            set
            {
                CanWriteProperty("ApdungGoi", true);
                if (_apdungGoi != value)
                {
                    _apdungGoi = value;
                    PropertyHasChanged("ApdungGoi");
                }
            }
        }

        public Boolean DichVuGui
        {
            get
            {
                CanReadProperty("DichVuGui", true);
                return _dichVuGui;
            }
            set
            {
                CanWriteProperty("DichVuGui", true);
                if (_dichVuGui != value)
                {
                    _dichVuGui = value;
                    PropertyHasChanged("DichVuGui");
                }
            }
        }
        public Byte LoaiKQ
        {
            get
            {
                CanReadProperty("LoaiKQ", true);
                return _loaiKQ;
            }
            set
            {
                CanWriteProperty("LoaiKQ", true);
                if (_loaiKQ != value)
                {
                    _loaiKQ = value;
                    PropertyHasChanged("LoaiKQ");
                }
            }
        }

        public String FormSudung
        {
            get
            {
                CanReadProperty("FormSudung", true);
                return _formSudung;
            }
            set
            {
                CanWriteProperty("FormSudung", true);
                if (_formSudung != value)
                {
                    _formSudung = value;
                    PropertyHasChanged("FormSudung");
                }
            }
        }
        public String FormSudung087
        {
            get
            {
                CanReadProperty("FormSudung087", true);
                return _formSudung087;
            }
            set
            {
                CanWriteProperty("FormSudung087", true);
                if (_formSudung087 != value)
                {
                    _formSudung087 = value;
                    PropertyHasChanged("FormSudung087");
                }
            }
        }
        public Decimal BHTra
        {
            get
            {
                CanReadProperty("BHTra", true);
                return _BHTra;
            }
            set
            {
                CanWriteProperty("BHTra", true);
                if (_BHTra != value)
                {
                    _BHTra = value;
                    PropertyHasChanged("BHTra");
                }
            }
        }

        public Decimal gtHoaHong
        {
            get
            {
                CanReadProperty("gtHoaHong", true);
                return _gtHoaHong;
            }
            set
            {
                CanWriteProperty("gtHoaHong", true);
                if (_gtHoaHong != value)
                {
                    _gtHoaHong = value;
                    PropertyHasChanged("gtHoaHong");
                }
            }
        }


        public Decimal HoaHong
        {
            get
            {
                CanReadProperty("HoaHong", true);
                return _HoaHong;
            }
            set
            {
                CanWriteProperty("HoaHong", true);
                if (_HoaHong != value)
                {
                    _HoaHong = value;
                    PropertyHasChanged("HoaHong");
                }
            }
        }



        public Boolean TToanSau
        {
            get
            {
                CanReadProperty("TToanSau", true);
                return _tToanSau;
            }
            set
            {
                CanWriteProperty("TToanSau", true);
                if (_tToanSau != value)
                {
                    _tToanSau = value;
                    PropertyHasChanged("TToanSau");
                }
            }
        }

        public Boolean TToanNgay
        {
            get
            {
                CanReadProperty("TToanNgay", true);
                return _tToanNgay;
            }
            set
            {
                CanWriteProperty("TToanNgay", true);
                if (_tToanNgay != value)
                {
                    _tToanNgay = value;
                    PropertyHasChanged("TToanNgay");
                }
            }
        }

        public Boolean BCThu
        {
            get
            {
                CanReadProperty("BCThu", true);
                return _bCThu;
            }
            set
            {
                CanWriteProperty("BCThu", true);
                if (_bCThu != value)
                {
                    _bCThu = value;
                    PropertyHasChanged("BCThu");
                }
            }
        }

        public Boolean InThu
        {
            get
            {
                CanReadProperty("InThu", true);
                return _inThu;
            }
            set
            {
                CanWriteProperty("InThu", true);
                if (_inThu != value)
                {
                    _inThu = value;
                    PropertyHasChanged("InThu");
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

        public SmartDate NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayHuy;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy != value)
                {
                    _ngayHuy = value;
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

        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayLap;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap != value)
                {
                    _ngayLap = value;
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

        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
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

        public SmartDate NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD1;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1 != value)
                {
                    _ngaySD1 = value;
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
        public Boolean apdungpk
        {
            get
            {
                CanReadProperty("apdungpk", true);
                return _apdungpk;
            }
            set
            {
                CanWriteProperty("apdungpk", true);
                if (_apdungpk != value)
                {
                    _apdungpk = value;
                    PropertyHasChanged("apdungpk");
                }
            }
        }
        public Boolean apdungnt
        {
            get
            {
                CanReadProperty("apdungnt", true);
                return _apdungnt;
            }
            set
            {
                CanWriteProperty("apdungnt", true);
                if (_apdungnt != value)
                {
                    _apdungnt = value;
                    PropertyHasChanged("apdungnt");
                }
            }
        }
        public Boolean apdungnk
        {
            get
            {
                CanReadProperty("apdungnk", true);
                return _apdungnk;
            }
            set
            {
                CanWriteProperty("apdungnk", true);
                if (_apdungnk != value)
                {
                    _apdungnk = value;
                    PropertyHasChanged("apdungnk");
                }
            }
        }
        public Boolean apdungsuagia
        {
            get
            {
                CanReadProperty("apdungsuagia", true);
                return _apdungsuagia;
            }
            set
            {
                CanWriteProperty("apdungsuagia", true);
                if (_apdungsuagia != value)
                {
                    _apdungsuagia = value;
                    PropertyHasChanged("apdungsuagia");
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
            return _maDV;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenDV", 350));
            ValidationRules.AddRule<DMDichVu>(StringRequired<DMDichVu>, "TenDV");
            // ValidationRules.AddRule<DMDichVu>(NumberRequired<DMDichVu>, "SoTban");
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu
        {

            if (target._tenDV == null || target._tenDV.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool TextRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu
        {

            if (target._maNhomDV == null || target._maNhomDV.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        //private static bool NumberRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu
        //{
        //    if (Csla.Utilities.IsNumeric(target._soTban) == false && target._soTban !=null ) 
        //    {
        //        e.Description = HTC.ShareVariables.VAR_NUMBERREQUIRED;
        //        return false;
        //    }
        //    if (target._soTban.Trim() == "")
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        // }


        //  return true;
        // }
        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMDichVu NewDMDichVu()
        {
            return DataPortal.Create<DMDichVu>();
        }
        public static DMDichVu GetDMDichVu(String maDV)
        {
            return DataPortal.Fetch<DMDichVu>(new Criteria(maDV));
        }

        /// <summary>
        /// Marks the <see cref="DMDichVu" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMDichVu(String maDV, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maDV));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMDichVu()
        {
            // Prevent direct creation
        }
        internal DMDichVu(
             int ordernumber,
             String maDV,
             String maNhomDV,
             String tenDV,
             String tenTA,
             String maBYTe,
             String quyetdinh,
            String tendvbh,
             Boolean nhapSL,
             String tenTat,
             String soTban,
             String maLH,
             Decimal dongiaTT,
             Decimal dongiaTT1,
             SmartDate ngayTT1,
             String makhoa,
            String makhoa087,
            String makhoaNG,
             String makhoaLM,
            String makhoaLM087,
            String makhoaLMNG,
             String makhth,
             String machuyenkhoa,
             String machungloai,
             Byte loai,
             Byte noiThucHien,
             String maCQ,
            String maBenhPham,
            Boolean KTCao,
             String chisocaoNu,
             String chisocaoNam,
             String chisothapNu,
             String chisothapNam,
             String donvi,
             Boolean apdungGoi,
             Boolean dichvugui,
             Byte loaiKQ,
             String formSudung,
            String formSudung087,
             Decimal BHTra,
             Decimal gthoahong,
             Decimal HoaHong,
             Boolean tToanSau,
             Boolean tToanNgay,
             Boolean bCThu,
             Boolean inThu,
             String ghichu,
             String maMay,
             SmartDate NgayHuy,
             String nguoiHuy,
             SmartDate NgayLap,
             String nguoiLap,
             SmartDate ngaySD,
             String nguoiSD,
             SmartDate ngaySD1,
             String nguoiSD1,
             Boolean huy,
           Boolean LayMauTT,
             Boolean apdungpk,
             Boolean apdungnt,
             Boolean apdungnk,
             Boolean apdungsuagia,
             String maloaitt,
             string CLS1lan,
            String maBh, String matduong,
             String quyetdinhbh,
            String tenbyte,
            String MAKHTH,
            String macsbh,
            string tencsbh,
            string mamayxhbh,
            string NhomBHXH,
            string MaBS,
            string tenTMBH
            )
        {
            _maCSBH = macsbh;
            _tenCSBH = tencsbh;
            _maMayXNBH = mamayxhbh;
            _NhomBHXH = NhomBHXH;
            _MaBH = maBh; _MaTDuong = matduong;
            _TenBYTe = tenbyte;
            _QuyetDinhBH = quyetdinhbh;
            _OrderNumber = ordernumber;
            _maloaiTT = maloaitt;
            _CLS1lan = CLS1lan;
            _maDV = maDV;
            _MaBS = MaBS;
            _LayMauTT = LayMauTT;
            _apdungpk = apdungpk;
            _apdungnt = apdungnt;
            _apdungnk = apdungnk;
            _apdungsuagia = apdungsuagia;
            _maNhomDV = maNhomDV;
            _tenDV = tenDV;
            _tenTA = tenTA;
            _maBYTe = maBYTe;
            _QuyetDinh = quyetdinh;
            _TenDVBH = tendvbh;
            _nhapSL = nhapSL;
            _tenTat = tenTat;
            _soTban = soTban;
            _maLH = maLH;
            _dongiaTT = dongiaTT;
            _dongiaTT1 = dongiaTT1;
            _ngayTT1 = ngayTT1;
            _makhoa = makhoa;
            _makhoa087 = makhoa087;
            _makhoaNG = makhoaNG;
            _makhoaLM = makhoaLM;
            _makhoaLM087 = makhoaLM087;
            _makhoaLMNG = makhoaLMNG;
            _tenTMBH = tenTMBH;
            _makhth = makhth;
            _machuyenkhoa = machuyenkhoa;
            _machungloai = machungloai;
            _loai = loai;
            _noiThucHien = noiThucHien;
            _maCQ = maCQ;
            _maBenhPham = maBenhPham;
            _KTCao = KTCao;
            _chisocaoNu = chisocaoNu;
            _chisocaoNam = chisocaoNam;
            _chisothapNu = chisothapNu;
            _chisothapNam = chisothapNam;
            _donvi = donvi;
            _apdungGoi = apdungGoi;
            _dichVuGui = dichvugui;
            _loaiKQ = loaiKQ;
            _formSudung = formSudung;
            _formSudung087 = formSudung087;
            _BHTra = BHTra;
            _gtHoaHong = gthoahong;
            _HoaHong = HoaHong;
            _tToanSau = tToanSau;
            _tToanNgay = tToanNgay;
            _bCThu = bCThu;
            _inThu = inThu;
            _ghichu = ghichu;
            _maMay = maMay;
            _ngayHuy = NgayHuy;
            _nguoiHuy = nguoiHuy;
            _ngayLap = NgayLap;
            _nguoiLap = nguoiLap;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _makhth = MAKHTH;
            _huy = huy;
            MarkOld();

        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maDV;
            public String MaDV
            {
                get
                {
                    return _maDV;
                }
            }

            public Criteria(String maDV)
            {
                _maDV = maDV;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maDV.Equals(c._maDV))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDV;
            public String maDV
            {
                get
                {
                    return _maDV;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDV)
            {
                _maDV = maDV;
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
        /// Retrieve an existing <see cref="DMDichVu" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMDichVu(String _maDV);
            // public override IDataReader GetDMDichVu(String _maDV)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDV));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu(crit.MaDV)))
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
        /// Load a <see cref="DMDichVu" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("MaBS") != null) _MaBS = dr.GetString("MaBS");
            if (dr.GetString("maloaiTT") != null) _maloaiTT = dr.GetString("maloaiTT");
            //if (dr.GetString("CLS1lan") != null) _CLS1lan = dr.GetString("CLS1lan");
            if (dr.GetString("MaNhomDV") != null) _maNhomDV = dr.GetString("MaNhomDV");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("TenTA") != null) _tenTA = dr.GetString("TenTA");
            if (dr.GetString("MaBH") != null) _MaBH = dr.GetString("MaBH"); if (dr.GetString("MaTDuong") != null) _MaTDuong = dr.GetString("MaTDuong");
            if (dr.GetString("QuyetDinhBH") != null) _QuyetDinhBH = dr.GetString("QuyetDinhBH");
            if (dr.GetString("TenBYte") != null) _TenBYTe = dr.GetString("TenBYte");
            if (dr.GetString("TenCSBH") != null) _tenCSBH = dr.GetString("TenCSBH");
            if (dr.GetString("MaCSBH") != null) _maCSBH = dr.GetString("MaCSBH");
            if (dr.GetString("MaMayXNBH") != null) _maMayXNBH = dr.GetString("MaMayXNBH");

            if (dr.GetString("NhomBHXH") != null) _NhomBHXH = dr.GetString("NhomBHXH");


            if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");
            if (dr.GetString("QuyetDinh") != null) _QuyetDinh = dr.GetString("QuyetDinh");

            if (dr.GetString("TenDVBH") != null) _TenDVBH = dr.GetString("TenDVBH");
            if (dr.GetBoolean("NhapSL") != null) _nhapSL = dr.GetBoolean("NhapSL");
            if (dr.GetString("TenTat") != null) _tenTat = dr.GetString("TenTat");
            if (dr.GetString("SoTban") != null) _soTban = dr.GetString("SoTban");
            if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
            if (dr.GetDecimal("DongiaTT1") != null) _dongiaTT1 = dr.GetDecimal("DongiaTT1");
            if (dr.GetSmartDate("NgayTT1", true) != null) _ngayTT1 = dr.GetSmartDate("NgayTT1", true);
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("Makhoa087") != null) _makhoa087 = dr.GetString("Makhoa087");
            if (dr.GetString("MakhoaNG") != null) _makhoaNG = dr.GetString("MakhoaNG");
            if (dr.GetString("MakhoaLM") != null) _makhoaLM = dr.GetString("MakhoaLM");
            if (dr.GetString("MakhoaLM087") != null) _makhoaLM087 = dr.GetString("MakhoaLM087");
            if (dr.GetString("MakhoaLMNG") != null) _makhoaLMNG = dr.GetString("MakhoaLMNG");

          //  if (dr.GetString("tenTMBH") != null) _tenTMBH = dr.GetString("tenTMBH");

            if (dr.GetString("makhth") != null) _makhth = dr.GetString("makhth");
            if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
            if (dr.GetString("Machungloai") != null) _machungloai = dr.GetString("Machungloai");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetByte("NoiThucHien") != null) _noiThucHien = dr.GetByte("NoiThucHien");
            if (dr.GetString("MaCQ") != null) _maCQ = dr.GetString("MaCQ");
            if (dr.GetString("MaBenhPham") != null) _maBenhPham = dr.GetString("MaBenhPham");
            if (dr.GetBoolean("KTCao") != null) _KTCao = dr.GetBoolean("KTCao");
            if (dr.GetBoolean("LayMauTT") != null) _LayMauTT = dr.GetBoolean("LayMauTT");
            if (dr.GetString("ChisocaoNu") != null) _chisocaoNu = dr.GetString("ChisocaoNu");
            if (dr.GetString("ChisocaoNam") != null) _chisocaoNam = dr.GetString("ChisocaoNam");
            if (dr.GetString("ChisothapNu") != null) _chisothapNu = dr.GetString("ChisothapNu");
            if (dr.GetString("ChisothapNam") != null) _chisothapNam = dr.GetString("ChisothapNam");
            if (dr.GetString("Donvi") != null) _donvi = dr.GetString("Donvi");
            if (dr.GetBoolean("ApdungGoi") != null) _apdungGoi = dr.GetBoolean("ApdungGoi");
            if (dr.GetBoolean("DichVuGui") != null) _dichVuGui = dr.GetBoolean("DichVuGui");
            if (dr.GetByte("LoaiKQ") != null) _loaiKQ = dr.GetByte("LoaiKQ");
            if (dr.GetString("FormSudung") != null) _formSudung = dr.GetString("FormSudung");
            if (dr.GetString("FormSudung087") != null) _formSudung087 = dr.GetString("FormSudung087");
            if (dr.GetDecimal("BHTra") != null) _BHTra = dr.GetDecimal("BHTra");
            if (dr.GetDecimal("GTHoaHong") != null) _gtHoaHong = dr.GetDecimal("GTHoaHong");
            if (dr.GetDecimal("HoaHong") != null) _HoaHong = dr.GetDecimal("HoaHong");
            if (dr.GetBoolean("TToanSau") != null) _tToanSau = dr.GetBoolean("TToanSau");
            if (dr.GetBoolean("TToanNgay") != null) _tToanNgay = dr.GetBoolean("TToanNgay");
            if (dr.GetBoolean("BCThu") != null) _bCThu = dr.GetBoolean("BCThu");
            if (dr.GetBoolean("InThu") != null) _inThu = dr.GetBoolean("InThu");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgayLap") != null) _ngayLap = dr.GetSmartDate("NgayLap");
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", false) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", false);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("apdungnk") != null) _apdungnk = dr.GetBoolean("apdungnk");
            if (dr.GetBoolean("apdungnt") != null) _apdungnt = dr.GetBoolean("apdungnt");
            if (dr.GetBoolean("apdungpk") != null) _apdungpk = dr.GetBoolean("apdungpk");
            if (dr.GetBoolean("apdungsuagia") != null) _apdungsuagia = dr.GetBoolean("apdungsuagia");

        }

        /// <summary>
        /// Insert the new <see cref="DMDichVu" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu
            // Copy & paste ham duoi day vao file DataProvider.cs

          //  _maDV = DataProvider.Instance().InsertDMDichVu(_kytu, _maNhomDV, _tenDV, _tenTA, _maBYTe, _QuyetDinh, _TenDVBH, _nhapSL, _tenTat, _soTban, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1, _makhoa, _makhoa087, _makhoaNG, _makhoaLM, _makhoaLM087, _makhoaLMNG, _makhth, _machuyenkhoa, _machungloai, _loai, _noiThucHien, _maCQ, _maBenhPham, _KTCao, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _apdungGoi, _dichVuGui, _loaiKQ, _formSudung, _formSudung087, _BHTra, _gtHoaHong, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _nguoiSD, _LayMauTT, _apdungpk, _apdungnt, _apdungnk, _apdungsuagia, _maloaiTT, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _maCSBH, _tenCSBH, _maMayXNBH);

            _maDV = InsertDMDichVu (_kytu, _maNhomDV, _tenDV, _tenTA, _maBYTe, _QuyetDinh, _TenDVBH, _nhapSL, _tenTat, _soTban, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1, _makhoa, _makhoa087, _makhoaNG, _makhoaLM, _makhoaLM087, _makhoaLMNG, _MaBS, _machuyenkhoa, _machungloai, _loai, _noiThucHien, _maCQ, _maBenhPham, _KTCao, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _apdungGoi, _dichVuGui, _loaiKQ, _formSudung, _formSudung087,  _HoaHong,_gtHoaHong, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _nguoiSD, _LayMauTT, _apdungpk, _apdungnt, _apdungnk, _apdungsuagia, _maloaiTT, _CLS1lan,  _maCSBH, _tenCSBH, _maMayXNBH,_NhomBHXH);
            // public abstract String InsertDMDichVu(String _maNhomDV, String _tenDV, String _maBYTe, Byte _nhapSL, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhth, String _machuyenkhoa, Byte _loai, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Byte _loaiKQ, String _formSudung, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay, DateTime _ngayLap, String _nguoiLap);
            // public override String InsertDMDichVu(String _maNhomDV, String _tenDV, String _maBYTe, Byte _nhapSL, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhth, String _machuyenkhoa, Byte _loai, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Byte _loaiKQ, String _formSudung, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay,DateTime _ngayLap, String _nguoiLap);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNhomDV, _tenDV, _maBYTe, _nhapSL, _tenTat, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _makhoa, _makhth, _machuyenkhoa, _loai, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _loaiKQ, _formSudung, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _ngayLap.DBValue, _nguoiSD ,), String);
            // }
        }

        public string InsertDMDichVu(String _kytu, String _maNhomDV, String _tenDV, String _tenTA, String _maBYTe, string _QuyetDinh, string _TenDVBH, Boolean _nhapSL, String _tenTat, String _soTban, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhoa087, String _makhoaNG, String _makhoaLM, String _makhoaLM087, String _makhoaLMNG, String _MaBS, String _machuyenkhoa, String _machungloai, Byte _loai, Byte _noiThucHien, String _maCQ, String _maBenhPham, Boolean _KTCao, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Boolean _apdungGoi, Boolean _dichVuGui, Byte _loaiKQ, String _formSudung, String _formSudung087,  Decimal _HoaHong, Decimal _gtHoaHong, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay, String _nguoiLap, Boolean _LayMauTT, bool _apdungpk, bool _apdungnt, bool _apdungnk, bool _apdungsuagia, string _maloaiTT,string _CLS1lan,  string _maCSBH, string _tenCSBH, string _maMayXNBH, string _NhomBHXH)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_CREATE_130", _kytu, _maNhomDV, _tenDV, _tenTA, _maBYTe, _QuyetDinh, _TenDVBH, _nhapSL, _tenTat, _soTban, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _makhoa, _makhoa087, _makhoaNG, _makhoaLM, _makhoaLM087, _makhoaLMNG, _MaBS, _machuyenkhoa, _machungloai, _loai, _noiThucHien, _maCQ, _maBenhPham, _KTCao, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _apdungGoi, _dichVuGui, _loaiKQ, _formSudung, _formSudung087,  _HoaHong, _gtHoaHong, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _nguoiSD, _LayMauTT, _apdungpk, _apdungnt, _apdungnk, _apdungsuagia, _maloaiTT, _CLS1lan,  _maCSBH, _tenCSBH, _maMayXNBH,_NhomBHXH));
        }


        /// <summary>
        /// Update all changes made on <see cref="DMDichVu" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu
            if (IsDirty)
            {

               // DataProvider.Instance().UpdateDMDichVu(_maDV, _maNhomDV, _tenDV, _tenTA, _maBYTe, _QuyetDinh, _TenDVBH, _nhapSL, _tenTat, _soTban, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1, _makhoa, _makhoa087, _makhoaNG, _makhoaLM, _makhoaLM087, _makhoaLMNG, _makhth, _machuyenkhoa, _machungloai, _loai, _noiThucHien, _maCQ, _maBenhPham, _KTCao, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _apdungGoi, _dichVuGui, _loaiKQ, _formSudung, _formSudung087, _BHTra, _gtHoaHong, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _nguoiSD, _huy, _LayMauTT, _apdungpk, _apdungnt, _apdungnk, _apdungsuagia, _maloaiTT, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _maCSBH, _tenCSBH, _maMayXNBH);

                UpdateDMDichVu(_maDV, _maNhomDV, _tenDV, _tenTA, _maBYTe, _QuyetDinh, _tenTMBH, _nhapSL, _tenTat, _soTban, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1, _makhoa, _makhoa087, _makhoaNG, _makhoaLM, _makhoaLM087, _makhoaLMNG, _makhth, _machuyenkhoa, _machungloai, _loai, _noiThucHien, _maCQ, _maBenhPham, _KTCao, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _apdungGoi, _dichVuGui, _CLS1lan, _loaiKQ, _formSudung, _formSudung087,  _gtHoaHong, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _nguoiSD, _huy, _LayMauTT, _apdungpk, _apdungnt, _apdungnk, _apdungsuagia, _maloaiTT, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _maCSBH, _tenCSBH, _maMayXNBH, _NhomBHXH);
                // public abstract void UpdateDMDichVu(String _maDV, String _maNhomDV, String _tenDV, String _maBYTe, Byte _nhapSL, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhth, String _machuyenkhoa, Byte _loai, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Byte _loaiKQ, String _formSudung, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay,SmartDate _ngaySD, String _nguoiSD, Boolean _huy);
                // public override void UpdateDMDichVu(String _maDV, String _maNhomDV, String _tenDV, String _maBYTe, Byte _nhapSL, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhth, String _machuyenkhoa, Byte _loai, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Byte _loaiKQ, String _formSudung, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay,SmartDate _ngaySD, String _nguoiSD, Boolean _huy);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDV, _maNhomDV, _tenDV, _maBYTe, _nhapSL, _tenTat, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _makhoa, _makhth, _machuyenkhoa, _loai, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _loaiKQ, _formSudung, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _ngaySD.DBValue, _nguoiSD , _huy);
                // }				
            }
        }

        public string UpdateDMDichVu(String _maDV, String _maNhomDV, String _tenDV, String _tenTA, String _maBYTe, string _QuyetDinh, string _tenTMBH, Boolean _nhapSL, String _tenTat, String _soTban, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhoa087, String _makhoaNG, String _makhoaLM, String _makhoaLM087, String _makhoaLMNG, String _makhth, String _machuyenkhoa, String _machungloai, Byte _loai, Byte _noiThucHien, String _maCQ, String _maBenhPham, Boolean _KTCao, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Boolean _apdungGoi, Boolean _dichVuGui, string _CLS1lan, Byte _loaiKQ, String _formSudung, String _formSudung087,  Decimal _gtHoaHong, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _LayMauTT, bool _apdungpk, bool _apdungnt, bool _apdungnk, bool _apdungsuagia, string _maloaiTT, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe, string _maCSBH, string _tenCSBH, string _maMayXNBH, string _NhomBHXH)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_UPDATE_130", _maDV, _maNhomDV, _tenDV, _tenTA, _maBYTe, _QuyetDinh, _tenTMBH, _nhapSL, _tenTat, _soTban, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _makhoa, _makhoa087, _makhoaNG, _makhoaLM, _makhoaLM087, _makhoaLMNG, _makhth, _machuyenkhoa, _machungloai, _loai, _noiThucHien, _maCQ, _maBenhPham, _KTCao, _chisocaoNu, _chisocaoNam, _chisothapNu, _chisothapNam, _donvi, _apdungGoi, _dichVuGui, _CLS1lan, _loaiKQ, _formSudung, _formSudung087,  _gtHoaHong, _tToanSau, _tToanNgay, _bCThu, _inThu, _ghichu, _maMay, _nguoiSD, _huy, _LayMauTT, _apdungpk, _apdungnt, _apdungnk, _apdungsuagia, _maloaiTT, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _maCSBH, _tenCSBH, _maMayXNBH, _NhomBHXH));
              
        }


        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maDV));
        }

        /// <summary>
        /// Delete the <see cref="DMDichVu" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu
            DataProvider.Instance().DeleteDMDichVu(crit.MaMay, crit.NguoiSD, crit.maDV);
            // public abstract void DeleteDMDichVu(String _maDV);
            // public override void DeleteDMDichVu(String _maDV);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDV);
            // }
        }

        #endregion
    }







}