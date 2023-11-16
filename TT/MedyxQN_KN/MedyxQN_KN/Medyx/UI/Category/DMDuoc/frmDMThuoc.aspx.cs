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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using OfficeOpenXml;
using System.IO;
using System.Globalization;
using HTC.Business;
using OfficeOpenXml.Style;
using Microsoft.ApplicationBlocks.Data;
using Csla.Data;
using Csla.Validation;
using Csla;

public partial class UI_Category_DMDuoc_frmDMThuoc : HTC.Common.Web.WebBase
{

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
    private const string ViewState_DMthuocImport = "_DMthuocImport";
    public string _DMthuocImport
    {
        get
        {
            if (Cache["ViewState_DMthuocImport"] == null)
            {
                ViewState[ViewState_DMthuocImport] = "";
            }

            return (string)Cache["ViewState_DMthuocImport"];
        }

        set
        {
            Cache["ViewState_DMthuocImport"] = value;
        }
    }
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
    private const string ViewState_DMThuoc = "_DMThuoc";

    public DMThuoc _DMThuoc
    {
        get
        {
            if (ViewState[ViewState_DMThuoc] == null)
                ViewState[ViewState_DMThuoc] = DMThuoc.NewDMThuoc();

            return (DMThuoc)ViewState[ViewState_DMThuoc];
        }

        set
        {
            ViewState[ViewState_DMThuoc] = value;
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
    private const string ViewState_loaiphieu = "_loaiphieu";
    public byte _loaiphieu
    {
        get
        {
            if (ViewState[ViewState_loaiphieu] == null)
            {
                if (Request["loaiphieu"] == null)
                    ViewState[ViewState_loaiphieu] = Convert.ToByte("0");
                else
                    ViewState[ViewState_loaiphieu] = Convert.ToByte(Request["loaiphieu"].ToString());
            }

            return (byte)ViewState[ViewState_loaiphieu];
        }

        set
        {
            ViewState[ViewState_loaiphieu] = value;
        }

    }

    private const string ViewState_DMThuocList = "_DMThuocList";
    public DMThuocList _DMThuocList
    {
        get
        {
            if (ViewState[ViewState_DMThuocList] == null)
            {

                //if (_loaiphieu == null || _loaiphieu == 0)
                //    ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByNhomThuocFilter("", "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(),pub_bQadmin );
                //else if (_loaiphieu == 1)
                //    ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByNhomThuocTYFilter("", "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);
                //else if (_loaiphieu == 2)
                //    ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByNhomThuocDYFilter("", "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);
                if (_loaiphieu == null || _loaiphieu == 0)
                    //ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByNhomThuocFilter("", _DMthuocImport+"  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(),pub_bQadmin );
                    ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByFilter(_DMthuocImport, "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);
                else if (_loaiphieu == 1)
                    //ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByNhomThuocTYFilter("", _DMthuocImport+"  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);
                    ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport, "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);
                else if (_loaiphieu == 2)
                    //ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByNhomThuocDYFilter("", _DMthuocImport+"  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);
                    ViewState[ViewState_DMThuocList] = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport, "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString(), pub_bQadmin);

            }

            return (DMThuocList)ViewState[ViewState_DMThuocList];
        }

        set
        {
            ViewState[ViewState_DMThuocList] = value;
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        if (!IsPostBack)
        {

            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;
            if (Request.QueryString["loai"] != null)
                _loai = byte.Parse(Request.QueryString["loai"].ToString());
            if (Request.QueryString["loaiphieu"] != null)
                _loaiphieu = byte.Parse(Request.QueryString["loaiphieu"].ToString());
            _DMthuocImport = "";
            LoadData();
            base.OnLoad(e);
        }
    }


    private void LoadData()
    {
        cboQuocGia.DataSource = GetDMQuocGia();// combo 
        cboQuocGia.DataBind();

        cboDangBC.DataSource = GetDMDangBaoChe();// combo dạng bào chế
        cboDangBC.DataBind();

        cboDangCB.DataSource = GetDPhuongPhapCheBien();// combo dạng chế biến
        cboDangCB.DataBind();


        cboDsnhom.DataSource = DMNhomListcb.GetListAll(_loai);
        cboDsnhom.DataBind();
        cboNhomThuoc.DataSource = DMNhomListcb.GetList(_loai);
        cboNhomThuoc.DataBind();
        cboDuongDung.DataSource = DMDuongDungListcb.GetList(_loai);
        cboDuongDung.DataBind();
        cboDonViHL.DataSource = DMDonvitinhListcb.GetList();
        cboDonViHL.DataBind();
        cboDonVi.DataSource = DMDonvitinhListcb.GetList();
        cboDonVi.DataBind();
        cboDonVi2.DataSource = DMDonvitinhListcb.GetList();
        cboDonVi2.DataBind();
        cboChungLoai.DataSource = DMChungLoaiListcb.GetList(_loai);
        cboChungLoai.DataBind();
        //cboLoaihinh.DataSource = DMLoaiHinhListcb.GetList(cboLoaihinh.SelectedValue);
        //cboLoaihinh.DataBind();
        cboLoaiTP.DataSource = DMThanhPhamListcb.GetList(cboLoaiTP.SelectedValue);
        cboLoaiTP.DataBind();
        cboNSX.DataSource = DMNhaSXListcb.GetList(_loai);
        cboNSX.DataBind();
        cboPhanLoai.DataSource = DMPhanLoaiListcb.GetList();
        cboPhanLoai.DataBind();
        if (HTC.ShareVariables.pub_spC == "YH")
            chkThuoc56.Visible = false;
        if (HTC.ShareVariables.pub_spC == "QN")
        {
            Label13.Text = "Tỷ lệ HH";
            if (_loaiphieu == 2)
            {
                Label3.Text = "Mã chín";
            }
        }
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
            _DMThuoc = DMThuoc.NewDMThuoc();
        cboNhomThuoc.SelectedValue = _DMThuoc.MaNhom;
        cboPhanLoai.SelectedValue = _DMThuoc.MaPL;
        cboDonViHL.SelectedValue = _DMThuoc.MaDVTHL;
        cboDonViHL.SelectedItem.Text = _DMThuoc.tendvthl;
        cboDonVi.SelectedValue = _DMThuoc.MaDVT;
        cboDonVi.SelectedItem.Text = _DMThuoc.tendvt;

        cboDonVi2.SelectedValue = _DMThuoc.MaDVT2;
        cboDonVi2.SelectedItem.Text = _DMThuoc.tendvt2;
        cboChungLoai.SelectedValue = _DMThuoc.MaChungLoai;
        if (_DMThuoc.MaChungLoai != "")
        {
            cboChungLoai.DataSource = DMChungLoaiListcb.GetList(_loai);
            cboChungLoai.DataBind();
        }
        cboLoaihinh.SelectedValue = _DMThuoc.malh;
        cboNSX.SelectedValue = _DMThuoc.MaNSX;

        cboNSX.SelectedItem.Text = _DMThuoc.TenNSX;
        if (_DMThuoc.matp.Trim() != "")
            cboLoaiTP.SelectedValue = _DMThuoc.matp;

        txtMaThuoc.Text = _DMThuoc.MaThuoc;
        if (_DMThuoc.Parent != "")
        {
            cboMaGoc.SelectedValue = _DMThuoc.Parent;
            cboMaGoc.Text = DMThuoc.GetDMThuoc(_DMThuoc.Parent).TenTM;
        }
        else
        {
            cboMaGoc.SelectedValue = "";
            cboMaGoc.Text = "";
        }
        txtTenGoc.Text = _DMThuoc.TenGoc;
        txtMaQL.Text = _DMThuoc.maql;
        txtNgayDung.Text = _DMThuoc.Ngaydungtoida.ToString();
        txtTenTM.Text = _DMThuoc.TenTM;
        txtHamLuong.Text = _DMThuoc.HamLuong;
        txtTenTM1.Text = _DMThuoc.TenTM1;
        txtQuydoi.Text = _DMThuoc.Quydoi.ToString();
        txtTenTM2.Text = _DMThuoc.TenTM2;
        txtNguong.Text = _DMThuoc.Nguong.ToString();
        txtNguongNhap.Text = _DMThuoc.Nguongnhap.ToString();
        txtTenTA.Text = _DMThuoc.TenTA;
        txtSoViSa.Text = _DMThuoc.sovisa;
        cboDuongDung.SelectedValue = _DMThuoc.duongdung;

        txtGhiChu.Text = _DMThuoc.Ghichu;
        txtQuyCach.Text = _DMThuoc.quycach;
        chkDuyetNoiT.Checked = _DMThuoc.DuyetNoiT;
        chkDuyetNgoaiT.Checked = _DMThuoc.DuyetNgoaiT;
        chkThuoc43.Checked = _DMThuoc.ThuocBan;
        chkThuoc56.Checked = _DMThuoc.thuocban2;
        chkThuocHanSD.Checked = _DMThuoc.Handung;
        chkThuocHoiChan.Checked = _DMThuoc.ThuocHoiChan;
        chkNoiVien.Checked = _DMThuoc.ThuocNoiT;

        txtThuocBH.Text = _DMThuoc.bh50.ToString();

        chkCLS.Checked = _DMThuoc.ThuocCLS;
        chkDuoc.Checked = _DMThuoc.ThuocDuoc;
        chkTieuHao.Checked = _DMThuoc.ThuocTieuHao == Byte.Parse("1") ? true : false;
        chkKhongSD.Checked = _DMThuoc.KhongSD;
        chkHuy.Checked = _DMThuoc.Huy;
        chkThuocGoc.Checked = _DMThuoc.ThuocGoc;
        txtMaBYTe.Text = _DMThuoc.MaBYTe;
        txtQuyetDinh.Text = _DMThuoc.QuyetDinh;
        txtTenBH.Text = _DMThuoc.TenTMBH;
        txtMaBH.Text = _DMThuoc.MaBH;
        txtMaTDuong.Text = _DMThuoc.MaTDuong;
        txtQuyetDinhBH.Text = _DMThuoc.QuyetDinhBH;
        txtTenBYte.Text = _DMThuoc.TenBYTe;
        txtDonGiaTT.Text = _DMThuoc.DonGiaTT.ToString("###,###");
        txtGiaNhap.Text = _DMThuoc.Gianhap.ToString("###,###");
        txtGiaNT.Text = _DMThuoc.GiaQuay.ToString("###,###");
        if (pub_bQadmin == false && HTC.ShareVariables.pub_spC == "YH" && _DMThuoc.IsNew == true)
        {
            _DMThuoc.KhongSD = true;
            chkKhongSD.Checked = true;
        }
        if (pub_bQadmin == true || HTC.ShareVariables.pub_spC == "PS")
            chkKhongSD.Visible = true;
        else
            chkKhongSD.Visible = true;



        DataTable dt = spDMThuoc_GetBC(_DMThuoc.MaThuoc);
        if (dt != null && dt.Rows.Count > 0)
        {
            string madangbc = dt.Rows[0][0].ToString();
            string tendangbc = dt.Rows[0][1].ToString();
            string madangcb = dt.Rows[0][2].ToString();
            string tendangcb = dt.Rows[0][3].ToString();
            string maquocgia = dt.Rows[0][4].ToString();
            string tenquocgia = dt.Rows[0][5].ToString();
            string MaDVKT = dt.Rows[0][6].ToString();
            //string MaDangBC = dt.Rows[0][7].ToString();
            //string MaDangCB = dt.Rows[0][8]. ToString();
            //string TenDangBC = dt.Rows[0][9].ToString();
            //string TenDangCB = dt.Rows[0][10].ToString();
            cboDangBC.SelectedValue = madangbc;
            cboDangBC.Text = tendangbc;
            cboDangCB.SelectedValue = madangcb;
            cboDangCB.Text = tendangcb;
            cboQuocGia.SelectedValue = maquocgia;
            cboQuocGia.Text = tenquocgia;
            txtMaDVKT.Text = MaDVKT;


            txtDangBC.Text = madangbc;
            txtDangCB.Text = madangcb;
           // txtDangCB.Text = MaDangCB + "--" + TenDangCB + ";";
        }






        }
    private void UpdateData()
    {
        try
        {
            if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fSua)
                if (_DMThuoc.IsNew == false)
                    return;
            if (txtTenTM.Text == "" || cboDonVi.SelectedValue == "")
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            if (cboPhanLoai.SelectedValue == "" || cboPhanLoai.SelectedValue == null)
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            if (cboChungLoai.SelectedValue == "" || cboChungLoai.SelectedValue == null)
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            if ((cboNhomThuoc.SelectedValue == "" || cboNhomThuoc.SelectedValue == null) && HTC.ShareVariables.pub_spC == "HU")
            {
                ShowMessage("Chưa nhập đủ thông tin");
                return;
            }
            if (HTC.ShareVariables.pub_sTenBV == "BỆNH VIỆN TRUNG ƯƠNG HUẾ " && txtMaQL.Text != "")
            {
                DMThuoc dm = DMThuoc.GetDMThuoc("0000" + txtMaQL.Text);
                if (dm != null)
                {
                    if (dm.MaThuoc != "" && _action == FormAction.INSERT)
                    {
                        ShowMessage("Đã tồn tại mã quản lý thuốc này");
                    }
                    if (dm.MaThuoc != _DMThuoc.MaThuoc && _action == FormAction.EDIT && dm.MaThuoc != "")
                    {
                        ShowMessage("Đã tồn tại mã quản lý thuốc này");
                    }
                }
            }
            _DMThuoc.MaNhom = cboNhomThuoc.SelectedValue;
            _DMThuoc.MaPL = cboPhanLoai.SelectedValue;
            _DMThuoc.MaDVTHL = cboDonViHL.SelectedValue;
            _DMThuoc.tendvthl = cboDonViHL.SelectedItem.Text;
            _DMThuoc.MaDVT = cboDonVi.SelectedValue;
            _DMThuoc.tendvt = cboDonVi.SelectedItem.Text;
            _DMThuoc.MaDVT2 = cboDonVi2.SelectedValue;
            _DMThuoc.tendvt2 = cboDonVi2.SelectedItem.Text;
            _DMThuoc.MaChungLoai = cboChungLoai.SelectedValue;
            _DMThuoc.malh = cboLoaihinh.SelectedValue;
            _DMThuoc.MaNSX = cboNSX.SelectedValue;
            _DMThuoc.TenNSX = cboNSX.SelectedItem.Text;
            _DMThuoc.matp = cboLoaiTP.SelectedValue;
            _DMThuoc.MaThuoc = txtMaThuoc.Text;
            _DMThuoc.Huy = chkHuy.Checked;
            _DMThuoc.ThuocGoc = chkThuocGoc.Checked;
            _DMThuoc.Parent = cboMaGoc.SelectedValue;
            _DMThuoc.TenGoc = txtTenGoc.Text;
            _DMThuoc.maql = txtMaQL.Text;
            if (txtNgayDung.Text != "")
                _DMThuoc.Ngaydungtoida = decimal.Parse(txtNgayDung.Text);
            _DMThuoc.TenTM = txtTenTM.Text;
            _DMThuoc.HamLuong = txtHamLuong.Text;
            _DMThuoc.TenTM1 = txtTenTM1.Text;
            _DMThuoc.Quydoi = decimal.Parse(txtQuydoi.Text == "" ? "1" : txtQuydoi.Text);
            _DMThuoc.TenTM2 = txtTenTM2.Text;
            if (txtNguong.Text != "")
                _DMThuoc.Nguong = decimal.Parse(txtNguong.Text);
            if (txtNguongNhap.Text != "")
                _DMThuoc.Nguongnhap = decimal.Parse(txtNguongNhap.Text);
            _DMThuoc.TenTA = txtTenTA.Text;
            _DMThuoc.sovisa = txtSoViSa.Text;
            _DMThuoc.duongdung = cboDuongDung.SelectedValue;
            _DMThuoc.Ghichu = txtGhiChu.Text;
            _DMThuoc.quycach = txtQuyCach.Text;
            _DMThuoc.DuyetNoiT = chkDuyetNoiT.Checked;
            _DMThuoc.DuyetNgoaiT = chkDuyetNgoaiT.Checked;
            _DMThuoc.ThuocBan = chkThuoc43.Checked;
            _DMThuoc.thuocban2 = chkThuoc56.Checked;
            _DMThuoc.Handung = chkThuocHanSD.Checked;
            _DMThuoc.ThuocHoiChan = chkThuocHoiChan.Checked;
            _DMThuoc.ThuocNoiT = chkNoiVien.Checked;
            if (txtThuocBH.Text == "")
                _DMThuoc.bh50 = 100;
            else
                _DMThuoc.bh50 = byte.Parse(txtThuocBH.Text);
            _DMThuoc.ThuocCLS = chkCLS.Checked;
            _DMThuoc.ThuocDuoc = chkDuoc.Checked;
            _DMThuoc.ThuocTieuHao = chkTieuHao.Checked == true ? Byte.Parse("1") : Byte.Parse("0");
            _DMThuoc.KhongSD = chkKhongSD.Checked;
            _DMThuoc.MaBYTe = txtMaBYTe.Text;
            _DMThuoc.QuyetDinh = txtQuyetDinh.Text;
            _DMThuoc.TenTMBH = txtTenBH.Text;
            _DMThuoc.MaBH = txtMaBH.Text;
            _DMThuoc.MaTDuong = txtMaTDuong.Text;
            _DMThuoc.QuyetDinhBH = txtQuyetDinhBH.Text;
            _DMThuoc.TenBYTe = txtTenBYte.Text;
            _DMThuoc.MaDangBC = cboDangBC.SelectedValue;
            _DMThuoc.MaDangCB = cboDangCB.SelectedValue;
            _DMThuoc.MaQG = cboQuocGia.SelectedValue;
            _DMThuoc.MaDVKT = txtMaDVKT.Text;

            _DMThuoc.MaDangBC = txtDangBC.Text;
            _DMThuoc.MaDangCB = txtDangCB.Text;


            //string sql = "UPDATE DMThuoc SET MaDangBC = '" + cboDangBC.SelectedValue + "', MaDangCB = '" + cboDangCB.SelectedValue + "',MaQG = '" + cboQuocGia.SelectedValue + "',MaDVKT ='" + txtMaDVKT.Text + "' WHERE mathuoc = '" + _DMThuoc.MaThuoc + "'";
            //HTC.Business.DataProvider.Instance().ExcSQL(sql);


            //string sql = "UPDATE DMThuoc SET MaDangBC = '" + cboDangBC.SelectedValue + ";" + cboDangBC.SelectedValue + "', MaDangCB = '" + cboDangCB.SelectedValue + "',MaQG = '" + cboQuocGia.SelectedValue + "',MaDVKT ='" + txtMaDVKT.Text + "' WHERE mathuoc = '" + _DMThuoc.MaThuoc + "'";
            //HTC.Business.DataProvider.Instance().ExcSQL(sql);


            string sql = "UPDATE DMThuoc SET  MaDangBC ='" + txtDangBC.Text + "', MaDangCB ='" + txtDangCB.Text + "',MaQG = '" + cboQuocGia.SelectedValue + "',MaDVKT ='" + txtMaDVKT.Text + "' WHERE mathuoc = '" + _DMThuoc.MaThuoc + "'";
            HTC.Business.DataProvider.Instance().ExcSQL(sql);



            if (_action != FormAction.DELETE)
            {

            }
            else
            {
                _DMThuoc.nguoiHuy = Pub_sNguoiSD;
                _DMThuoc.MaMay = Pub_sMaMay;


                _DMThuoc.nguoiHuy = Pub_sNguoiSD;

                _DMThuoc.MaMay = Pub_sMaMay;
                DMThuoc.DeleteDMThuoc(_DMThuoc.MaThuoc, Pub_sMaMay, Pub_sNguoiSD);
            }
            if (_action == FormAction.EDIT)
            {

                _DMThuoc.NguoiSD = Pub_sNguoiSD;
                _DMThuoc.MaMay = Pub_sMaMay;
                //_DMThuocList.UpdatedTo(_DMThuoc);
                _DMThuoc.ApplyEdit();
                _DMThuoc.Save();

            }
            else if (_action == FormAction.INSERT)
            {
                _DMThuoc.NguoiLap = Pub_sNguoiSD;
                _DMThuoc.NguoiSD = Pub_sNguoiSD;
                _DMThuoc.MaMay = Pub_sMaMay;
                //_DMThuocList.NewTo(_DMThuoc);
                _DMThuoc.ApplyEdit();
                if (HTC.ShareVariables.pub_spC == "HU")
                {
                    _DMThuoc = _DMThuoc.Save();
                    _action = FormAction.EDIT;
                }
                else
                {
                    _DMThuoc = _DMThuoc.Save();
                }
            }
            else
            {
                //_DMThuocList.RemoveTo(_DMThuoc);
                DMThuoc.DeleteDMThuoc(_DMThuoc.MaThuoc, Pub_sMaMay, Pub_sNguoiSD);
            }
            if (HTC.ShareVariables.pub_spC != "HU")
                _action = FormAction.INSERT;
            LoadDetail();
            grdChiTiet.DataSource = _DMThuocList;
            grdChiTiet.DataBind();
        }
        catch (System.IO.IOException ex)
        {
            ShowMessage("Không lưu được dữ liệu" + ex.Message);
            //ShowMessage(MessageType.ERROR, FormAction.REPORTS);

        }


    }
    private void ExportData()
    {
        try
        {
            string filename = "DMThuoc_" + DateTime.Now.Date.ToString() + ".xls";
            string excelHeader = "DMThuoc";
            System.IO.StringWriter tw = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
            DataGrid dgGrid = new DataGrid();

            dgGrid.DataSource = HTC.Business.DataProvider.Instance().CrDMThuoc_GIA_RPT("10002", false, (_loaiphieu == 1 ? " and b.machungloai <> '00019'" : (_loaiphieu == 2 ? " and b.machungloai = '00019'" : "")));
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
    protected void grdChiTiet_PageIndexChanged(object sender, GridPageChangedEventArgs e)
    {

        string sql = "";
        sql = " and row >= " + ((e.NewPageIndex) * grdChiTiet.PageSize).ToString() + " and row < " + ((e.NewPageIndex + 1) * grdChiTiet.PageSize).ToString();

        //if (_loaiphieu == null || _loaiphieu == 0)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql, sql,pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        //else if (_loaiphieu == 1)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        //else if (_loaiphieu == 2)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        if (_loaiphieu == null || _loaiphieu == 0)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        else if (_loaiphieu == 1)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        else if (_loaiphieu == 2)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMThuocList.record;
        grdChiTiet.DataSource = _DMThuocList;
        grdChiTiet.DataBind();
    }
    protected void grdChiTiet_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
    {
        string sql = "";
        sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * e.NewPageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * e.NewPageSize).ToString();
        //if (_loaiphieu == null || _loaiphieu == 0)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        //else if (_loaiphieu == 1)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        //else if (_loaiphieu == 2)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        if (_loaiphieu == null || _loaiphieu == 0)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql + _DMthuocImport, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        else if (_loaiphieu == 1)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        else if (_loaiphieu == 2)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        grdChiTiet.VirtualItemCount = _DMThuocList.record;
        grdChiTiet.DataSource = _DMThuocList;
        grdChiTiet.DataBind();
    }
    protected void grdChiTiet_DeletedCommand(object sender, GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;

            if (editedItem != null)
            {
                string _maThuoc = editedItem.GetDataKeyValue("MaThuoc").ToString();

                HTC.Business.DataProvider.Instance().DeleteDMThuoc(Pub_sMaMay, Pub_sNguoiSD, _maThuoc);
                _DMThuocList = null;
                grdChiTiet.DataSource = _DMThuocList;
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
        try
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;

            if (editedItem != null)
            {

            }
        }
        catch (Exception ex)
        {
            //HandleException(ex, FormAction.EDIT);
            ShowMessage(MessageType.ERROR, FormAction.EDIT);
        }

        e.Canceled = true;
    }

    protected void grdChiTiet_InsertCommand(object sender, GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem editedItem = grdChiTiet.MasterTableView.GetInsertItem();


        }
        catch (Exception ex)
        {
            HandleException(ex, FormAction.INSERT);

            ShowMessage(MessageType.ERROR, FormAction.INSERT);
        }

        e.Canceled = true;
    }
    protected void grdChiTiet_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {

        grdChiTiet.VirtualItemCount = _DMThuocList.record;
        grdChiTiet.DataSource = _DMThuocList;
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
            TextBox filterBoxMaDV = item["MaThuoc"].Controls[0] as TextBox;

            TextBox filterBoxTenDV = item["TenTM"].Controls[0] as TextBox;
            TextBox filterBoxTenGoc = item["TenGoc"].Controls[0] as TextBox;
            TextBox filterBoxTenHamLuong = item["HamLuong"].Controls[0] as TextBox;

            TextBox filterBoxTenDVT = item["TenDVT"].Controls[0] as TextBox;
            //  TextBox filterBoxTenMaMay = item["MaMay"].Controls[0] as TextBox;
            TextBox filterBoxTenNgaySD = item["NgaySD"].Controls[0] as TextBox;
            string FilterSql = "";
            if (filterBoxTenDV.Text != "")
            {
                FilterSql = FilterSql + "and a.tentm like N'%" + filterBoxTenDV.Text + "%'";
            }
            if (filterBoxMaDV.Text != "")
            {
                FilterSql = FilterSql + "and a.mathuoc like N'%" + filterBoxMaDV.Text + "%'";
            }
            if (filterBoxTenDVT.Text != "")
            {
                FilterSql = FilterSql + "and f.tendvt like N'%" + filterBoxTenDVT.Text + "%'";
            }
            if (filterBoxTenGoc.Text != "")
            {
                FilterSql = FilterSql + "and a.tengoc like N'%" + filterBoxTenGoc.Text + "%'";
            }
            if (filterBoxTenHamLuong.Text != "")
            {
                FilterSql = FilterSql + "and a.hamluong like N'%" + filterBoxTenHamLuong.Text + "%'";
            }
            //if (filterBoxTenMaMay.Text != "")
            //{
            //    FilterSql = FilterSql + "and a.mamay like N'%" + filterBoxTenMaMay.Text + "%'";
            //}
            if (filterBoxTenNgaySD.Text != "")
            {
                FilterSql = FilterSql + "and a.ngaysd = '" + filterBoxTenNgaySD.Text + "'";
            }
            _FilterSql = FilterSql;
            grdChiTiet.CurrentPageIndex = 0;
            string sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * grdChiTiet.PageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * grdChiTiet.PageSize).ToString();

            //if (_loaiphieu == null || _loaiphieu == 0)
            //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql, sql, pub_bQadmin);
            //    else
            //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
            //else if (_loaiphieu == 1)
            //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql, sql, pub_bQadmin);
            //    else
            //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
            //else if (_loaiphieu == 2)
            //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
            //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql, sql, pub_bQadmin);
            //    else
            //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
            if (_loaiphieu == null || _loaiphieu == 0)
                if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                    _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
                else
                    _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
            else if (_loaiphieu == 1)
                if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                    _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
                else
                    _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
            else if (_loaiphieu == 2)
                if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                    _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
                else
                    _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);

            grdChiTiet.VirtualItemCount = _DMThuocList.record;

            grdChiTiet.DataSource = _DMThuocList;
            grdChiTiet.DataBind();
        }
        else if (e.CommandName == "Edit")
        {
            GridDataItem item = e.Item as GridDataItem;

            if (item != null)
            {
                if (item.GetDataKeyValue("MaThuoc") != null)
                {
                    _Selected_Ma = item.GetDataKeyValue("MaThuoc").ToString();
                    _DMThuoc = DMThuoc.GetDMThuoc(_Selected_Ma);
                    _action = FormAction.EDIT;
                    LoadDetail();

                }
            }

            e.Canceled = true;


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
            case "cmdExit":
                Response.Redirect("~/Default.aspx");
                break;

            case "cmdFilter":
                _FilterSql = "";
                grdChiTiet.AllowFilteringByColumn = !grdChiTiet.AllowFilteringByColumn;
                grdChiTiet.DataSource = _DMThuocList;
                grdChiTiet.DataBind();

                break;
            case "cmdView":
                _DMThuocList = null;
                _FilterSql = "";
                grdChiTiet.VirtualItemCount = _DMThuocList.record;
                grdChiTiet.DataSource = _DMThuocList;
                grdChiTiet.DataBind();
                break;
            case "cmdUploadData":
                ImportExcel();
                break;
            default:
                break;

        }

    }
    bool CheckExcelFileType(string fileName)
    {
        string ext = Path.GetExtension(fileName);
        switch (ext.ToLower())
        {
            case ".xls":
                return true;
            case ".xlsx":
                return true;
            default:
                ShowMessage("Yêu cầu nhập file excel có đuôi: .xls, .xlsx");
                return false;
        }

    }
    public void ImportExcel()
    {
        FileUpload file = this.baraction.Items[6].FindControl("FileUpload1") as FileUpload;
        if (file.HasFile)
        {
            if (CheckExcelFileType(file.FileName))
            {
                ExcelPackage package = new ExcelPackage(file.FileContent);
                ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
                //DataTable exportTable = new DataTable();
                //exportTable.Columns.Add("VTPhieuThauID", typeof(decimal));
                //exportTable.Columns.Add("TenGoiThau", typeof(string));
                //exportTable.Columns.Add("MaLoaiThau", typeof(string));
                //exportTable.Columns.Add("TenNCC", typeof(string));
                //exportTable.Columns.Add("MaNCC", typeof(string));
                //exportTable.Columns.Add("DaiDienNCC", typeof(string));
                //exportTable.Columns.Add("MaSoThau", typeof(string));
                //exportTable.Columns.Add("SoHD", typeof(string));
                //exportTable.Columns.Add("NgayKyHD", typeof(DateTime));
                //exportTable.Columns.Add("VTPhieuThau_CID", typeof(decimal));
                //exportTable.Columns.Add("BH50", typeof(string));
                //exportTable.Columns.Add("mabh", typeof(string));
                //exportTable.Columns.Add("tengoc", typeof(string));
                //exportTable.Columns.Add("duongdung", typeof(string));
                //exportTable.Columns.Add("hamluong", typeof(string));
                //exportTable.Columns.Add("tentm", typeof(string));
                //exportTable.Columns.Add("SoVisa", typeof(string));
                //exportTable.Columns.Add("madvt", typeof(string));
                //exportTable.Columns.Add("DonGia", typeof(decimal));
                //exportTable.Columns.Add("SoLuong", typeof(decimal));
                //exportTable.Columns.Add("CONG_BO", typeof(DateTime));
                //exportTable.Columns.Add("maql", typeof(string));
                //exportTable.Columns.Add("NHOM_THAU", typeof(string));
                //exportTable.Columns.Add("GoiThau_NhomThau", typeof(string));
                //exportTable.Columns.Add("MaTHuoc", typeof(string));
                DataTable importDMThuoc_gia = new DataTable();
                importDMThuoc_gia.Columns.Add("MaDT", typeof(string));
                importDMThuoc_gia.Columns.Add("STT", typeof(decimal));
                importDMThuoc_gia.Columns.Add("MaThuoc", typeof(string));
                importDMThuoc_gia.Columns.Add("DonGia", typeof(decimal));
                importDMThuoc_gia.Columns.Add("GiaChenhLech", typeof(decimal));
                importDMThuoc_gia.Columns.Add("ADChenhLech", typeof(bool));
                importDMThuoc_gia.Columns.Add("DTBH", typeof(bool));
                importDMThuoc_gia.Columns.Add("MaMay", typeof(string));
                importDMThuoc_gia.Columns.Add("NguoiLap", typeof(string));

                DataTable maxstt = DmThuoc_Gia_GetMaxSTT();
                DMDoiTuongList dMDoiTuongs = DMDoiTuongList.GetAllDMDoiTuong();
                if (workSheet.Dimension.End.Row >= 2)
                {
                    _DMthuocImport = " and isnull(a.Mathuoc,'') in (";
                    DMChungLoaiList dMChungLoai = DMChungLoaiList.GetAllDMChungLoai(1);
                    DMNhomList dMNhoms = DMNhomList.GetAllDMNhom(1);
                    DMPhanLoaiList dMPhanLoais = DMPhanLoaiList.GetAllDMPhanLoai();
                    DMDuongDungList dMDuongDungs = DMDuongDungList.GetAllDMDuongDung(1, false);
                    DMDonvitinhList dMDonvitinhLists = DMDonvitinhList.GetAllDMDonvitinh();
                    DMNhaSXList dMNhas = DMNhaSXList.GetAllDMNhaSX(1);
                    DMQuocGiaList dMQuocGiaLists = DMQuocGiaList.GetAllDMQuocGia();
                    DMNCCList dMNCCs = DMNCCList.GetAllDMNCC(1);
                    for (var rowNumber = workSheet.Dimension.Start.Row + 1; rowNumber <= workSheet.Dimension.End.Row; rowNumber++)
                    {
                        //MaQL
                        string maql = (workSheet.Cells[rowNumber, 2].Value != null && workSheet.Cells[rowNumber, 2].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 2].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //NhomThuoc(DMNhomThuoc)
                        string TenNhom = (workSheet.Cells[rowNumber, 3].Value != null && workSheet.Cells[rowNumber, 3].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 3].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaNhom = TenNhom.Trim().Length > 0 ? dMNhoms.Where(x => x.tenNhom.ToUpper() == TenNhom.ToUpper()).FirstOrDefault() == null ? "" : dMNhoms.Where(x => x.tenNhom.ToUpper() == TenNhom.ToUpper()).FirstOrDefault().maNhom : "";
                        //PhanLoai(DmPhanloai)
                        string TenPhanLoai = (workSheet.Cells[rowNumber, 4].Value != null && workSheet.Cells[rowNumber, 4].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 4].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaPhanLoai = TenPhanLoai.Trim().Length > 0 ? dMPhanLoais.Where(x => x.TenPL.ToUpper() == TenPhanLoai.ToUpper()).FirstOrDefault() == null ? "" : dMPhanLoais.Where(x => x.TenPL.ToUpper() == TenPhanLoai.ToUpper()).FirstOrDefault().MaPL : "";
                        //LoaiThuoc(DMChungloai)
                        string TenChungLoai = (workSheet.Cells[rowNumber, 5].Value != null && workSheet.Cells[rowNumber, 5].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 5].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaChungLoai = TenChungLoai.Trim().Length > 0 ? dMChungLoai.Where(x => x.TenChungLoai.ToUpper() == TenChungLoai.ToUpper()).FirstOrDefault() == null ? "" : dMChungLoai.Where(x => x.TenChungLoai.ToUpper() == TenChungLoai.ToUpper()).FirstOrDefault().MaChungLoai : "";
                        //TenGoc
                        string TENGOC = (workSheet.Cells[rowNumber, 6].Value != null && workSheet.Cells[rowNumber, 6].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 6].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //HamLuong
                        string HAM_LUONG = (workSheet.Cells[rowNumber, 7].Value != null && workSheet.Cells[rowNumber, 7].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 7].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //TenTM
                        string TENTM = (workSheet.Cells[rowNumber, 8].Value != null && workSheet.Cells[rowNumber, 8].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 8].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //QuyCach
                        string QUYCach = (workSheet.Cells[rowNumber, 9].Value != null && workSheet.Cells[rowNumber, 9].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 9].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //SoViSa
                        string SOVISA = (workSheet.Cells[rowNumber, 10].Value != null && workSheet.Cells[rowNumber, 10].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 10].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //DonViTinh(DMDonViTinh)
                        string TenDVT = (workSheet.Cells[rowNumber, 11].Value != null && workSheet.Cells[rowNumber, 11].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 11].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaDVT = TenDVT.Trim().Length > 0 ? dMDonvitinhLists.Where(x => x.TenDVT.ToUpper() == TenDVT.ToUpper()).FirstOrDefault().MaDVT : "";
                        //HangSX(DMNSX)
                        string TenNSX = (workSheet.Cells[rowNumber, 12].Value != null && workSheet.Cells[rowNumber, 12].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 12].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaNSX = TenNSX.Trim().Length > 0 ? dMNhas.Where(x => x.TenNSX.ToUpper() == TenNSX.ToUpper()).FirstOrDefault() == null ? "" : dMNhas.Where(x => x.TenNSX.ToUpper() == TenNSX.ToUpper()).FirstOrDefault().MaNSX : "";
                        //NuocSX(DMQG)
                        string TenQG = (workSheet.Cells[rowNumber, 13].Value != null && workSheet.Cells[rowNumber, 13].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 13].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaQG = TenQG.Trim().Length > 0 ? dMQuocGiaLists.Where(x => x.TenQG.ToUpper() == TenQG.ToUpper()).FirstOrDefault() == null ? "" : dMQuocGiaLists.Where(x => x.TenQG.ToUpper() == TenQG.ToUpper()).FirstOrDefault().MaQG : "";
                        //DonGiaTT
                        decimal DONGIATT = 0;
                        if ((workSheet.Cells[rowNumber, 14].Value != null && workSheet.Cells[rowNumber, 14].Value.ToString().Trim().Length > 0) && decimal.TryParse(workSheet.Cells[rowNumber, 14].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out DONGIATT))
                        { }
                        //DonGiaBH
                        decimal DONGIABH = 0;
                        if ((workSheet.Cells[rowNumber, 15].Value != null && workSheet.Cells[rowNumber, 15].Value.ToString().Trim().Length > 0) && decimal.TryParse(workSheet.Cells[rowNumber, 15].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out DONGIABH))
                        { }
                        //NhaCungCap
                        string TenNCC = (workSheet.Cells[rowNumber, 16].Value != null && workSheet.Cells[rowNumber, 16].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 16].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string MaNCC = TenNCC.Trim().Length > 0 ? dMNCCs.Where(x => x.TenNCC.ToUpper() == TenNCC.ToUpper()).FirstOrDefault() == null ? "" : dMNCCs.Where(x => x.TenNCC.ToUpper() == TenNCC.ToUpper()).FirstOrDefault().MaNCC : "";
                        //NhomThau
                        string NHOM_THAU = (workSheet.Cells[rowNumber, 17].Value != null && workSheet.Cells[rowNumber, 17].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 17].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";
                        //QuyDoi(mặc định là 1)
                        decimal QuyDoi = 1;
                        if ((workSheet.Cells[rowNumber, 18].Value != null && workSheet.Cells[rowNumber, 18].Value.ToString().Trim().Length > 0) && decimal.TryParse(workSheet.Cells[rowNumber, 18].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out QuyDoi))
                        { }
                        //MaDuongDung(DuongDung)
                        string maDUONGDUNG = (workSheet.Cells[rowNumber, 19].Value != null && workSheet.Cells[rowNumber, 19].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 19].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        string TenDuongDung = maDUONGDUNG.Trim().Length > 0 ? dMDuongDungs.Where(x => x.MaDuongDung.ToUpper() == maDUONGDUNG.ToUpper()).FirstOrDefault().TenDuongDung : "";
                        //BHTra
                        byte bh50 = 0;
                        if ((workSheet.Cells[rowNumber, 20].Value != null && workSheet.Cells[rowNumber, 20].Value.ToString().Trim().Length > 0) && byte.TryParse(workSheet.Cells[rowNumber, 20].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out bh50))
                        { }
                        //MaBH
                        string MaBH = (workSheet.Cells[rowNumber, 21].Value != null && workSheet.Cells[rowNumber, 21].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 21].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //MaTDuong
                        string MaTDuong = (workSheet.Cells[rowNumber, 22].Value != null && workSheet.Cells[rowNumber, 22].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 22].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //MaBYTe
                        string MaBYTe = (workSheet.Cells[rowNumber, 23].Value != null && workSheet.Cells[rowNumber, 23].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 23].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //TenBH=tentmbh
                        string tentmbh = (workSheet.Cells[rowNumber, 24].Value != null && workSheet.Cells[rowNumber, 24].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 24].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //TenByte
                        string TenByte = (workSheet.Cells[rowNumber, 25].Value != null && workSheet.Cells[rowNumber, 25].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 25].Value.ToString().Trim().Replace(System.Environment.NewLine, "") : "";
                        //QuyetDinh
                        string QUYET_DINH = (workSheet.Cells[rowNumber, 26].Value != null && workSheet.Cells[rowNumber, 26].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 26].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";
                        //ThongTinThau(QuyetdinhBH)
                        string QuyetdinhBH = (workSheet.Cells[rowNumber, 27].Value != null && workSheet.Cells[rowNumber, 27].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 27].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";
                        //GhiChu
                        string GhiChu = (workSheet.Cells[rowNumber, 28].Value != null && workSheet.Cells[rowNumber, 28].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 28].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";

                        //bool thuocthuhoivo = (workSheet.Cells[rowNumber, 4].Value != null && workSheet.Cells[rowNumber, 4].Value.ToString().Trim().Length > 0) && workSheet.Cells[rowNumber, 4].Value.ToString().Trim().ToUpper().Replace(System.Environment.NewLine, "") == "1" ? true : false;
                        //bool thuochoichan = (workSheet.Cells[rowNumber, 5].Value != null && workSheet.Cells[rowNumber, 5].Value.ToString().Trim().Length > 0) && workSheet.Cells[rowNumber, 5].Value.ToString().Trim().ToUpper().Replace(System.Environment.NewLine, "") == "1" ? true : false;
                        //decimal thetich = 0;
                        //if ((workSheet.Cells[rowNumber, 6].Value != null && workSheet.Cells[rowNumber, 6].Value.ToString().Trim().Length > 0) && decimal.TryParse(workSheet.Cells[rowNumber, 6].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out thetich))
                        //{ }
                        //byte bh50 = 0;
                        //if ((workSheet.Cells[rowNumber, 7].Value != null && workSheet.Cells[rowNumber, 7].Value.ToString().Trim().Length > 0) && byte.TryParse(workSheet.Cells[rowNumber, 7].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out bh50))
                        //{ }
                        //string MaBYTE = (workSheet.Cells[rowNumber, 8].Value != null && workSheet.Cells[rowNumber, 8].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 8].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";

                        //decimal DONGIATT1 = 0;
                        //if ((workSheet.Cells[rowNumber, 17].Value != null && workSheet.Cells[rowNumber, 17].Value.ToString().Trim().Length > 0) && decimal.TryParse(workSheet.Cells[rowNumber, 17].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out DONGIATT1))
                        //{ }
                        //decimal SO_LUONG = 0;
                        //if (workSheet.Cells[rowNumber, 18].Value != null && workSheet.Cells[rowNumber, 18].Value.ToString().Trim().Length > 0 && decimal.TryParse(workSheet.Cells[rowNumber, 18].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), out SO_LUONG))
                        //{ }
                        //DataRow r = exportTable.NewRow();
                        //r[0] = 0;
                        //r[1] = QUYET_DINH;
                        //DateTime CONG_BO;
                        //if (workSheet.Cells[rowNumber, 23].Value != null && workSheet.Cells[rowNumber, 23].Value.ToString().Trim().Length > 0 && DateTime.TryParseExact(workSheet.Cells[rowNumber, 23].Value.ToString().Trim().Replace(System.Environment.NewLine, ""), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out CONG_BO))
                        //{
                        //    r[8] = CONG_BO;
                        //    r[20] = CONG_BO;
                        //    //r[12] = CONG_BO.ToString("dd/MM/yyyy");
                        //}
                        //r[3] = TenNCC;
                        //r[4] = MaNCC;
                        //string LOAI_THUOC = (workSheet.Cells[rowNumber, 24].Value != null && workSheet.Cells[rowNumber, 24].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 24].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";
                        //string LOAI_THAU = (workSheet.Cells[rowNumber, 25].Value != null && workSheet.Cells[rowNumber, 25].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 25].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";
                        //r[2] = LOAI_THAU;
                        //string GOI_THAU = (workSheet.Cells[rowNumber, 27].Value != null && workSheet.Cells[rowNumber, 27].Value.ToString().Length > 0) ? workSheet.Cells[rowNumber, 27].Value.ToString().Trim().Replace(",", ".").Replace(System.Environment.NewLine, "") : "";
                        //string QuyetdinhBH = QUYET_DINH + ";" + GOI_THAU + ";" + NHOM_THAU;
                        DMThuoc dMThuoc = DMThuoc.NewDMThuoc();
                        //string _maThuoc = DataProvider.Instance().InsertDMThuoc("", MaNhom, MaPhanLoai, MaChungLoai, TENGOC, "", TENTM, "", "", "", false, (decimal)0, MaNSX, HAM_LUONG, "", (decimal)100000, (decimal)100000, MaDVT, QuyDoi, "", MaDVT, false, false, "", "", "", "", false, false, bh50, false, false, false, false, false, false, GhiChu, Pub_sMaMay, Pub_sNguoiSD, "", QUYCach, "", SOVISA, false, false, maql, 0, "", maDUONGDUNG, DONGIATT, DONGIATT, DONGIATT, MaBYTe, QUYET_DINH, tentmbh, MaBH, MaTDuong, QuyetdinhBH, TenByte);
                        string _maThuoc = DataProvider.Instance().InsertDMThuoc("", MaNhom, MaPhanLoai, MaChungLoai, TENGOC, "", TENTM, "", "", "", false, (decimal)0, MaNSX, HAM_LUONG, "", (decimal)10000, (decimal)10000, MaDVT, QuyDoi, "", MaDVT, false, false, "", "", "", "", false, false, bh50, false, false, false, false, false, false, false, GhiChu, Pub_sMaMay, Pub_sNguoiSD, "", QUYCach, "", SOVISA, false, false, maql, 0, "", "", 0, 0, 0, MaBYTe, QUYET_DINH, tentmbh, MaBH, MaTDuong, QuyetdinhBH, TenByte);
                        if (_maThuoc.Length > 0)
                            _DMthuocImport += "N'" + _maThuoc + "',";
                        //r[5] = "";
                        //r[6] = QUYET_DINH;
                        //r[7] = QUYET_DINH;
                        //r[9] = 0;
                        //r[10] = bh50;
                        //r[11] = MaBYTE;
                        //r[12] = TENGOC;
                        //r[13] = maDUONGDUNG;
                        //r[14] = HAM_LUONG;
                        //r[15] = TENTM;
                        //r[16] = SOVISA;
                        //r[17] = TenDVT;
                        //r[18] = DONGIATT;
                        //r[19] = SO_LUONG;
                        //r[21] = _maThuoc.ToUpper() + "_SD";
                        //r[22] = NHOM_THAU;
                        //r[23] = ";" + GOI_THAU + ";" + NHOM_THAU;
                        //r[24] = _maThuoc;
                        //exportTable.Rows.Add(r);

                        //importDMThuoc_gia
                        for (int i = 0; i < dMDoiTuongs.Count; i++)
                        {
                            if (dMDoiTuongs[i].MaDT != "00002" && dMDoiTuongs[i].MaDT != "00003" && dMDoiTuongs[i].MaDT != "00004" && dMDoiTuongs[i].MaDT != "00005")
                            {
                                decimal stt = decimal.Parse(maxstt.Select("madt = '" + dMDoiTuongs[i].MaDT + "'").First()["STT"].ToString().Trim() == "" ? "0" : maxstt.Select("madt = '" + dMDoiTuongs[i].MaDT + "'").First()["STT"].ToString().Trim()) + rowNumber - workSheet.Dimension.Start.Row;
                                DataRow rg = importDMThuoc_gia.NewRow();
                                rg[0] = dMDoiTuongs[i].MaDT;
                                rg[1] = stt;
                                rg[2] = _maThuoc;
                                decimal dgn = 0;
                                decimal giachenhlech = 0;
                                bool ADChenhlech = false;
                                bool DTBH = false;
                                if (dMDoiTuongs[i].MaDT == "00001")
                                    dgn = DONGIATT;
                                else
                                {
                                    dgn = DONGIATT * bh50 / 100;
                                    giachenhlech = DONGIATT - dgn;
                                    ADChenhlech = giachenhlech > 0 ? true : false;
                                    DTBH = true;
                                }
                                rg[3] = dgn;
                                rg[4] = giachenhlech;
                                rg[5] = ADChenhlech;
                                rg[6] = DTBH;
                                rg[7] = Pub_sMaMay;
                                rg[8] = Pub_sNguoiSD;
                                importDMThuoc_gia.Rows.Add(rg);
                            }
                        }
                    }
                    _DMthuocImport = _DMthuocImport.Substring(0, _DMthuocImport.Length - 1) + ")";
                }
                DataTable MaQl = DmThuoc_GetMaQL(_DMthuocImport);
                if (importDMThuoc_gia.Rows.Count > 0)
                {
                    string tenStore = "spDMThuoc_Gia_Import";
                    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
                    using (SqlConnection Conection = new SqlConnection(StrConection))
                    {
                        Conection.Open();
                        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
                        {
                            Command.CommandType = CommandType.StoredProcedure;
                            Command.Parameters.Add(new SqlParameter("@TempMau_importDMThuoc_gia", importDMThuoc_gia));
                            Command.ExecuteNonQuery();
                        }
                        Conection.Close();
                    }
                }
                _DMThuocList = null;
                //Export ra file thau
                //if (exportTable.Rows.Count > 0)
                //{
                //    try
                //    {
                //        ExcelPackage excel = new ExcelPackage();
                //        var exportSheet = excel.Workbook.Worksheets.Add("DMThuocThau");
                //        exportSheet.TabColor = System.Drawing.Color.Black;
                //        exportSheet.DefaultRowHeight = 12;
                //        //Header of table  
                //        exportSheet.Cells[1, 1].Value = "TenGoiThau";
                //        exportSheet.Cells[1, 2].Value = "MaLoaiThau";
                //        exportSheet.Cells[1, 3].Value = "TenNCC";
                //        exportSheet.Cells[1, 4].Value = "MaNCC";
                //        exportSheet.Cells[1, 5].Value = "DaiDienNCC";
                //        exportSheet.Cells[1, 6].Value = "SoQD";
                //        exportSheet.Cells[1, 7].Value = "SoHD";
                //        exportSheet.Cells[1, 8].Value = "NgayKyHD";
                //        exportSheet.Cells[1, 9].Value = "BH50";
                //        exportSheet.Cells[1, 10].Value = "mabh";
                //        exportSheet.Cells[1, 11].Value = "tengoc";
                //        exportSheet.Cells[1, 12].Value = "duongdung";
                //        exportSheet.Cells[1, 13].Value = "hamluong";
                //        exportSheet.Cells[1, 14].Value = "tentm";
                //        exportSheet.Cells[1, 15].Value = "sovisa";
                //        exportSheet.Cells[1, 16].Value = "madvt";
                //        exportSheet.Cells[1, 17].Value = "dongia";
                //        exportSheet.Cells[1, 18].Value = "soluong";
                //        exportSheet.Cells[1, 19].Value = "CONG_BO";
                //        exportSheet.Cells[1, 20].Value = "maql";
                //        exportSheet.Cells[1, 21].Value = "NHOM_THAU";
                //        exportSheet.Cells[1, 22].Value = "GoiThau_NhomThau";
                //        exportSheet.Cells[1, 23].Value = "MaTHuoc";
                //        //Body of table  
                //        int recordIndex = 2;
                //        for (int i = 0; i < exportTable.Rows.Count; i++)
                //        {
                //            exportSheet.Cells[recordIndex, 1].Value = exportTable.Rows[i][1].ToString();
                //            exportSheet.Cells[recordIndex, 2].Value = exportTable.Rows[i][2].ToString();
                //            exportSheet.Cells[recordIndex, 3].Value = exportTable.Rows[i][3].ToString();
                //            exportSheet.Cells[recordIndex, 4].Value = exportTable.Rows[i][4].ToString();
                //            exportSheet.Cells[recordIndex, 5].Value = exportTable.Rows[i][5].ToString();
                //            exportSheet.Cells[recordIndex, 6].Value = exportTable.Rows[i][6].ToString();
                //            exportSheet.Cells[recordIndex, 7].Value = exportTable.Rows[i][7].ToString();
                //            exportSheet.Cells[recordIndex, 8].Value = exportTable.Rows[i][8].ToString();
                //            exportSheet.Cells[recordIndex, 9].Value = exportTable.Rows[i][10].ToString();
                //            exportSheet.Cells[recordIndex, 10].Value = exportTable.Rows[i][11].ToString();
                //            exportSheet.Cells[recordIndex, 11].Value = exportTable.Rows[i][12].ToString();
                //            exportSheet.Cells[recordIndex, 12].Value = exportTable.Rows[i][13].ToString();
                //            exportSheet.Cells[recordIndex, 13].Value = exportTable.Rows[i][14].ToString();
                //            exportSheet.Cells[recordIndex, 14].Value = exportTable.Rows[i][15].ToString();
                //            exportSheet.Cells[recordIndex, 15].Value = exportTable.Rows[i][16].ToString();
                //            exportSheet.Cells[recordIndex, 16].Value = exportTable.Rows[i][17].ToString();
                //            exportSheet.Cells[recordIndex, 17].Value = exportTable.Rows[i][18].ToString();
                //            exportSheet.Cells[recordIndex, 18].Value = exportTable.Rows[i][19].ToString();
                //            exportSheet.Cells[recordIndex, 19].Value = exportTable.Rows[i][20].ToString();
                //            //exportSheet.Cells[recordIndex, 20].Value = exportTable.Rows[i][21].ToString();
                //            exportSheet.Cells[recordIndex, 20].Value = MaQl.Select("mathuoc = '" + exportTable.Rows[i][24].ToString() + "'").First() != null ? MaQl.Select("mathuoc = '" + exportTable.Rows[i][24].ToString() + "'").First()["maql"].ToString().Trim() : "";
                //            exportSheet.Cells[recordIndex, 21].Value = exportTable.Rows[i][22].ToString();
                //            exportSheet.Cells[recordIndex, 22].Value = exportTable.Rows[i][23].ToString();
                //            exportSheet.Cells[recordIndex, 23].Value = exportTable.Rows[i][24].ToString();
                //            recordIndex++;
                //        }
                //        string excelName = "DMThuocThauExport" + DateTime.Now.ToString("ddMMyyyyHHmmss");
                //        using (var memoryStream = new MemoryStream())
                //        {
                //            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                //            Response.AddHeader("content-disposition", "attachment; filename=" + excelName + ".xlsx");
                //            excel.SaveAs(memoryStream);
                //            memoryStream.WriteTo(Response.OutputStream);
                //            Response.Flush();
                //            Response.End();
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        ShowMessage("Export lỗi: " + ex.ToString());
                //    }
                //}
                ShowMessage("Import xong!");
            }
            else
            {
                return;
            }
        }
    }
    #region DMthuoc_Gia
    public DataTable DmThuoc_Gia_GetMaxSTT()
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMThuoc_Gia_GetMaxSTT";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }
    #endregion
    #region DMthuoc
    public DataTable DmThuoc_GetMaQL(string DK)
    {
        DataTable dr = new DataTable();
        string tenStore = "spDmThuoc_GetMaQL";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@dk", DK));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }
    #endregion
    protected void cboChungLoai_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        cboLoaihinh.DataSource = DMLoaiHinhListcb.GetList(cboChungLoai.SelectedValue);
        cboLoaihinh.DataBind();
    }
    protected void cboDsNhom_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        _FilterSql = "";
        grdChiTiet.CurrentPageIndex = 0;

        string sql = "  and row >= 0   and row < " + grdChiTiet.PageSize.ToString();
        //if (_loaiphieu == null || _loaiphieu == 0)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        //else if (_loaiphieu == 1)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        //else if (_loaiphieu == 2)
        //    if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
        //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql, sql, pub_bQadmin);
        //    else
        //        _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        if (_loaiphieu == null || _loaiphieu == 0)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        else if (_loaiphieu == 1)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByTYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);
        else if (_loaiphieu == 2)
            if (cboDsnhom.SelectedValue == "" || cboDsnhom.SelectedValue == "All")
                _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql, sql, pub_bQadmin);
            else
                _DMThuocList = DMThuocList.FindDMThuocByDYFilter(_DMthuocImport + _FilterSql + " and a.manhom like N'%" + cboDsnhom.SelectedValue + "%'", sql, pub_bQadmin);

        grdChiTiet.VirtualItemCount = _DMThuocList.record;
        grdChiTiet.DataSource = _DMThuocList;
        grdChiTiet.DataBind();
    }
    protected void ObjectDanhMuc_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

        LoadComBo();
    }
    public void LoadComBo()
    {
        ObjectDanhMuc.TypeName = "HTC.Business.CategoryList.DMThuocList";
        if (_loaiphieu == 1)
        {

            if (ObjectDanhMuc.SelectMethod != "FindDMThuocMaTY")
            {
                ObjectDanhMuc.SelectMethod = "FindDMThuocMaTY";
                ObjectDanhMuc.SelectParameters["Ma"].DefaultValue = "";
                ObjectDanhMuc.DataBind();
            }
        }
        else if (_loaiphieu == 2)
        {
            if (ObjectDanhMuc.SelectMethod != "FindDMThuocMaDY")
            {
                ObjectDanhMuc.SelectMethod = "FindDMThuocMaDY";
                ObjectDanhMuc.SelectParameters["Ma"].DefaultValue = "";
                ObjectDanhMuc.DataBind();
            }
        }
        else
        {
            if (ObjectDanhMuc.SelectMethod != "FindDMThuocMa")
            {
                ObjectDanhMuc.SelectMethod = "FindDMThuocMa";
                ObjectDanhMuc.SelectParameters["Ma"].DefaultValue = "";
                ObjectDanhMuc.DataBind();
            }
        }


    }


    public static List<DMDangBaoChe> GetDMDangBaoChe()
    {
        List<DMDangBaoChe> List = new List<DMDangBaoChe>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDANGBAOCHE_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMDangBaoChe(dr, i));
            }
        }
        return List;
    }
    private static string ConnectString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        }
    }

    public class DMDangBaoChe
    {
        private String _MaDangBC = String.Empty;
        private String _TenDangBC = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _MotaDangBC = String.Empty;
        private String _MaBHXH = String.Empty;
        private int _OrderNumber;
        public String MaDangBC
        {
            get
            {
                return _MaDangBC;
            }
            set
            {
                if (_MaDangBC != value)
                {
                    _MaDangBC = value;
                }
            }
        }

        public String TenDangBC
        {
            get
            {
                return _TenDangBC;
            }
            set
            {
                if (_TenDangBC != value)
                {
                    _TenDangBC = value;
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
        public String MotaDangBC
        {
            get
            {
                return _MotaDangBC;
            }
            set
            {
                if (_MotaDangBC != value)
                {
                    _MotaDangBC = value;
                }
            }
        }
        public String MaBHXH
        {
            get
            {
                return _MaBHXH;
            }
            set
            {
                if (_MaBHXH != value)
                {
                    _MaBHXH = value;
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
        public DMDangBaoChe(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaDangBC"].GetType().Name != "DBNull" && dr["MaDangBC"] != null)
            {
                this.MaDangBC = Convert.ToString(dr["MaDangBC"]);
            }
            else
            {
                this.MaDangBC = "";
            }
            if (dr["TenDangBC"].GetType().Name != "DBNull" && dr["TenDangBC"] != null)
            {
                this.TenDangBC = Convert.ToString(dr["TenDangBC"]);
            }
            else
            {
                this.TenDangBC = "";
            }
            if (dr["MotaDangBC"].GetType().Name != "DBNull" && dr["MotaDangBC"] != null)
            {
                this.MotaDangBC = Convert.ToString(dr["MotaDangBC"]);
            }
            else
            {
                this.MotaDangBC = "";
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
        private static string ConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            }
        }

    }
    public static List<DMPPCheBien> GetDPhuongPhapCheBien()
    {
        List<DMPPCheBien> List = new List<DMPPCheBien>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMPHUONGPHAPCHEBIEN_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMPPCheBien(dr, i));
            }
        }
        return List;
    }


    public class DMPPCheBien
    {
        private String _MaPPCB = String.Empty;
        private String _TenPPCB = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _maBHXH = String.Empty;
        private String _TenNhom = String.Empty;
        private int _OrderNumber;
        public String MaPPCB
        {
            get
            {
                return _MaPPCB;
            }
            set
            {
                if (_MaPPCB != value)
                {
                    _MaPPCB = value;
                }
            }
        }

        public String TenPPCB
        {
            get
            {
                return _TenPPCB;
            }
            set
            {
                if (_TenPPCB != value)
                {
                    _TenPPCB = value;
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
        public String TenNhom
        {
            get
            {
                return _TenNhom;
            }
            set
            {
                if (_TenNhom != value)
                {
                    _TenNhom = value;
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
        public DMPPCheBien(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaPPCB"].GetType().Name != "DBNull" && dr["MaPPCB"] != null)
            {
                this.MaPPCB = Convert.ToString(dr["MaPPCB"]);
            }
            else
            {
                this.MaPPCB = "";
            }
            if (dr["TenPPCB"].GetType().Name != "DBNull" && dr["TenPPCB"] != null)
            {
                this.TenPPCB = Convert.ToString(dr["TenPPCB"]);
            }
            else
            {
                this.TenPPCB = "";
            }
            if (dr["MaBHXH"].GetType().Name != "DBNull" && dr["MaBHXH"] != null)
            {
                this.MaBHXH = Convert.ToString(dr["MaBHXH"]);
            }
            else
            {
                this.MaBHXH = "";
            }
            if (dr["TenNhom"].GetType().Name != "DBNull" && dr["TenNhom"] != null)
            {
                this.TenNhom = Convert.ToString(dr["TenNhom"]);
            }
            else
            {
                this.TenNhom = "";
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


            if (dr["MaQuocTich"].GetType().Name != "DBNull" && dr["MaQuocTich"] != null)
            {
                this.MaQuocTich = Convert.ToString(dr["MaQuocTich"]);
            }
            else
            {
                this.MaQuocTich = "";
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


    public DataTable spDMThuoc_GetBC(string mathuoc) //dòng333
    {
        DataTable dr = new DataTable();
        string tenStore = "spDMThuoc_GetBC";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@mathuoc", mathuoc));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            return dr;
        }
    }


    protected void cboDangBC_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMDangBaoChe dataItem = e.Item.DataItem as DMDangBaoChe;
        if (dataItem == null)
            e.Item.Attributes["MaDangBC"] = "";
        else
            e.Item.Attributes["MaDangBC"] = dataItem.MaDangBC.ToString();
    }


    protected void cboDangCB_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMPPCheBien dataItem = e.Item.DataItem as DMPPCheBien;
        if (dataItem == null)
            e.Item.Attributes["MaPPCB"] = "";
        else
            e.Item.Attributes["MaPPCB"] = dataItem.MaPPCB.ToString();
    }


    [Serializable()]
    public  class DMThuoc : BusinessBase<DMThuoc>
    {
        #region Business Methods

        #region State Fields

        private String _maThuoc = String.Empty;
        private String _parent = String.Empty;
        private String _maNhom = String.Empty;
        private String _maPL = String.Empty;
        private String _maChungLoai = String.Empty;
        private String _tenGoc = String.Empty;
        private String _tenTC = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenTMHL = String.Empty;
        private String _tenTM1 = String.Empty;
        private String _tenTM2 = String.Empty;
        private String _tenTA = String.Empty;
        private Boolean _thuocGoc = false;
        private Decimal _ngaydungtoida = 0;
        private String _maNSX = String.Empty;
        private String _hamLuong = String.Empty;
        private String _hamLuongD = String.Empty;
        private String _maDVTHL = String.Empty;
        private Decimal _nguong = 0;
        private Decimal _nguongnhap = 0;
        private String _maDVT = String.Empty;
        private String _maDVT2 = String.Empty;
        private Decimal _quydoi = 0;
        private String _maThuoc2 = String.Empty;

        private Boolean _apDungGoi = true;
        private Boolean _handung = true;
        private String _lieudung = String.Empty;
        private String _cachdung = String.Empty;
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
        private Boolean _thuocThuT = false;
        private Boolean _thuocPhauT = false;
        private byte _bh50 = 100;
        private Boolean _thuocCLS = false;
        private Boolean _ThuocNoiT = false;
        private Boolean _thuocDuoc = false;
        private Boolean _thuocBan = false;
        private Boolean _duyetNgoaiT = true;
        private Boolean _duyetNoiT = true;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private String _tendvt = String.Empty;
        private String _tendvt2 = String.Empty;
        private String _tendvthl = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private String _malh = String.Empty;
        private String _matp = String.Empty;
        private String _duongdung = String.Empty;
        private int _OrderNumber;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private String _tenNSX = String.Empty;
        private String _quycach = String.Empty;
        private String _matk = String.Empty;
        private String _sovisa = String.Empty;
        private Boolean _thuocban2 = false;
        private Boolean _KhongSD = false;
        private Decimal _giaQuay56 = 0;
        private Decimal _giaQuay561 = 0;

        private String _maql = String.Empty;
        private Decimal _gianhap43 = 0;
        private SmartDate _ngaynhap43 = new SmartDate(true);
        private Decimal _gianhap56 = 0;
        private SmartDate _ngaynhap56 = new SmartDate(true);

        private Boolean _thuocHoiChan = false;
        private Byte _thuocTieuHao = 0;
        private String _maBYTe = String.Empty;
        private String _TenTMBH = String.Empty;
        private String _QuyetDinh = String.Empty;
        private String _QuyetDinhBH = String.Empty;
        private String _MaBH = String.Empty;
        private string _MaTDuong = String.Empty;
        private String _TenBYTe = String.Empty;

        private String _madangBC = String.Empty;
        private String _madangCB = String.Empty;
        private String _MaQG = String.Empty;
        private String _MaDVKT = String.Empty;

        #endregion

        #region Business Properties and Methods

        public String MaDVKT
        {
            get
            {
                CanReadProperty("MaDVKT", true);
                return _MaDVKT;
            }
            set
            {
                CanWriteProperty("MaDVKT", true);
                if (_MaDVKT != value)
                {
                    _MaDVKT = value;
                    PropertyHasChanged("MaDVKT");
                }
            }
        }

        public String MaDangBC
        {
            get
            {
                CanReadProperty("MaDangBC", true);
                return _madangBC;
            }
            set
            {
                CanWriteProperty("MaDangBC", true);
                if (_madangBC != value)
                {
                    _madangBC = value;
                    PropertyHasChanged("MaDangBC");
                }
            }
        }

        public String MaDangCB
        {
            get
            {
                CanReadProperty("MaDangCB", true);
                return _madangCB;
            }
            set
            {
                CanWriteProperty("MaDangCB", true);
                if (_madangCB != value)
                {
                    _madangCB = value;
                    PropertyHasChanged("MaDangCB");
                }
            }
        }
        public String MaQG
        {
            get
            {
                CanReadProperty("MaQG", true);
                return _MaQG;
            }
            set
            {
                CanWriteProperty("MaQG", true);
                if (_MaQG != value)
                {
                    _MaQG = value;
                    PropertyHasChanged("MaQG");
                }
            }
        }



        public String TenTMDu
        {
            get
            {

                return _maThuoc + "-" + _tenTM;
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
        public Decimal Gianhap43
        {
            get
            {
                CanReadProperty("Gianhap43", true);
                return _gianhap43;
            }
            set
            {
                CanWriteProperty("Gianhap43", true);
                if (_gianhap43 != value)
                {
                    _gianhap43 = value;
                    PropertyHasChanged("Gianhap43");
                }
            }
        }

        public string Ngaynhap43
        {
            get
            {
                CanReadProperty("Ngaynhap43", true);
                return _ngaynhap43.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap43", true);
                if (_ngaynhap43.Text != value)
                {
                    _ngaynhap43.Text = value;
                    PropertyHasChanged("Ngaynhap43");
                }
            }
        }
        public Decimal Gianhap56
        {
            get
            {
                CanReadProperty("Gianhap56", true);
                return _gianhap56;
            }
            set
            {
                CanWriteProperty("Gianhap56", true);
                if (_gianhap56 != value)
                {
                    _gianhap56 = value;
                    PropertyHasChanged("Gianhap56");
                }
            }
        }

        public string Ngaynhap56
        {
            get
            {
                CanReadProperty("Ngaynhap56", true);
                return _ngaynhap56.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap56", true);
                if (_ngaynhap56.Text != value)
                {
                    _ngaynhap56.Text = value;
                    PropertyHasChanged("Ngaynhap56");
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
        public String MaThuoc
        {
            get
            {
                CanReadProperty("MaThuoc", true);
                return _maThuoc;
            }
            set
            {
                CanWriteProperty("MaThuoc", true);
                if (_maThuoc != value)
                {
                    _maThuoc = value;
                    PropertyHasChanged("MaThuoc");
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
        public String matk
        {
            get
            {
                CanReadProperty("matk", true);
                return _matk;
            }
            set
            {
                CanWriteProperty("matk", true);
                if (_matk != value)
                {
                    _matk = value;
                    PropertyHasChanged("matk");
                }
            }
        }
        public String sovisa
        {
            get
            {
                CanReadProperty("sovisa", true);
                return _sovisa;
            }
            set
            {
                CanWriteProperty("sovisa", true);
                if (_sovisa != value)
                {
                    _sovisa = value;
                    PropertyHasChanged("sovisa");
                }
            }
        }
        public String tendvt2
        {
            get
            {
                CanReadProperty("tendvt2", true);
                return _tendvt2;
            }
            set
            {
                CanWriteProperty("tendvt2", true);
                if (_tendvt2 != value)
                {
                    _tendvt2 = value;
                    PropertyHasChanged("tendvt2");
                }
            }
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
        public String Parent
        {
            get
            {
                CanReadProperty("Parent", true);
                return _parent;
            }
            set
            {
                CanWriteProperty("Parent", true);
                if (_parent != value)
                {
                    _parent = value;
                    PropertyHasChanged("Parent");
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

        public String MaPL
        {
            get
            {
                CanReadProperty("MaPL", true);
                return _maPL;
            }
            set
            {
                CanWriteProperty("MaPL", true);
                if (_maPL != value)
                {
                    _maPL = value;
                    PropertyHasChanged("MaPL");
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

        public String TenGoc
        {
            get
            {
                CanReadProperty("TenGoc", true);
                return _tenGoc;
            }
            set
            {
                CanWriteProperty("TenGoc", true);
                if (_tenGoc != value)
                {
                    _tenGoc = value;
                    PropertyHasChanged("TenGoc");
                }
            }
        }

        public String TenTC
        {
            get
            {
                CanReadProperty("TenTC", true);
                return _tenTC;
            }
            set
            {
                CanWriteProperty("TenTC", true);
                if (_tenTC != value)
                {
                    _tenTC = value;
                    PropertyHasChanged("TenTC");
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
        public String TenTMHL
        {
            get
            {
                CanReadProperty("TenTMHL", true);
                if ((_tenTM1 != "") && (_tenTM2 != ""))
                    return _tenTM + "(" + _tenTM1 + ")" + "(" + _tenTM2 + ")" + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX;
                else if ((_tenTM1 == "") && (_tenTM2 != ""))
                    return _tenTM + "(" + _tenTM2 + ")" + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX;

                else if ((_tenTM1 != "") && (_tenTM2 == ""))
                    return _tenTM + "(" + _tenTM1 + ")" + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX;
                else
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

        public String TenTM1
        {
            get
            {
                CanReadProperty("TenTM1", true);
                return _tenTM1;
            }
            set
            {
                CanWriteProperty("TenTM1", true);
                if (_tenTM1 != value)
                {
                    _tenTM1 = value;
                    PropertyHasChanged("TenTM1");
                }
            }
        }

        public String TenTM2
        {
            get
            {
                CanReadProperty("TenTM2", true);
                return _tenTM2;
            }
            set
            {
                CanWriteProperty("TenTM2", true);
                if (_tenTM2 != value)
                {
                    _tenTM2 = value;
                    PropertyHasChanged("TenTM2");
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

        public Boolean ThuocGoc
        {
            get
            {
                CanReadProperty("ThuocGoc", true);
                return _thuocGoc;
            }
            set
            {
                CanWriteProperty("ThuocGoc", true);
                if (_thuocGoc != value)
                {
                    _thuocGoc = value;
                    PropertyHasChanged("ThuocGoc");
                }
            }
        }
        public Boolean thuocban2
        {
            get
            {
                CanReadProperty("thuocban2", true);
                return _thuocban2;
            }
            set
            {
                CanWriteProperty("thuocban2", true);
                if (_thuocban2 != value)
                {
                    _thuocban2 = value;
                    PropertyHasChanged("thuocban2");
                }
            }
        }
        public Decimal Ngaydungtoida
        {
            get
            {
                CanReadProperty("Ngaydungtoida", true);
                return _ngaydungtoida;
            }
            set
            {
                CanWriteProperty("Ngaydungtoida", true);
                if (_ngaydungtoida != value)
                {
                    _ngaydungtoida = value;
                    PropertyHasChanged("Ngaydungtoida");
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
        public Decimal Nguongnhap
        {
            get
            {
                CanReadProperty("Nguongnhap", true);
                return _nguongnhap;
            }
            set
            {
                CanWriteProperty("Nguongnhap", true);
                if (_nguongnhap != value)
                {
                    _nguongnhap = value;
                    PropertyHasChanged("Nguongnhap");
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
        public String maThuocgoc
        {
            get
            {
                CanReadProperty("MaThuocgoc", true);
                return _maThuoc2;
            }
            set
            {
                CanWriteProperty("MaThuocgoc", true);
                if (_maThuoc2 != value)
                {
                    _maThuoc2 = value;
                    PropertyHasChanged("MaThuocgoc");
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

        public String Lieudung
        {
            get
            {
                CanReadProperty("Lieudung", true);
                return _lieudung;
            }
            set
            {
                CanWriteProperty("Lieudung", true);
                if (_lieudung != value)
                {
                    _lieudung = value;
                    PropertyHasChanged("Lieudung");
                }
            }
        }

        public String Cachdung
        {
            get
            {
                CanReadProperty("Cachdung", true);
                return _cachdung;
            }
            set
            {
                CanWriteProperty("Cachdung", true);
                if (_cachdung != value)
                {
                    _cachdung = value;
                    PropertyHasChanged("Cachdung");
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
        public Decimal GiaQuay56
        {
            get
            {
                CanReadProperty("GiaQuay56", true);
                return _giaQuay56;
            }
            set
            {
                CanWriteProperty("GiaQuay56", true);
                if (_giaQuay56 != value)
                {
                    _giaQuay56 = value;
                    PropertyHasChanged("GiaQuay56");
                }
            }
        }
        public Decimal GiaQuay561
        {
            get
            {
                CanReadProperty("GiaQuay561", true);
                return _giaQuay561;
            }
            set
            {
                CanWriteProperty("GiaQuay561", true);
                if (_giaQuay561 != value)
                {
                    _giaQuay561 = value;
                    PropertyHasChanged("GiaQuay561");
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

        public Boolean ThuocThuT
        {
            get
            {
                CanReadProperty("ThuocThuT", true);
                return _thuocThuT;
            }
            set
            {
                CanWriteProperty("ThuocThuT", true);
                if (_thuocThuT != value)
                {
                    _thuocThuT = value;
                    PropertyHasChanged("ThuocThuT");
                }
            }
        }

        public Boolean ThuocPhauT
        {
            get
            {
                CanReadProperty("ThuocPhauT", true);
                return _thuocPhauT;
            }
            set
            {
                CanWriteProperty("ThuocPhauT", true);
                if (_thuocPhauT != value)
                {
                    _thuocPhauT = value;
                    PropertyHasChanged("ThuocPhauT");
                }
            }
        }
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

        public Boolean ThuocCLS
        {
            get
            {
                CanReadProperty("ThuocCLS", true);
                return _thuocCLS;
            }
            set
            {
                CanWriteProperty("ThuocCLS", true);
                if (_thuocCLS != value)
                {
                    _thuocCLS = value;
                    PropertyHasChanged("ThuocCLS");
                }
            }
        }

        public Boolean ThuocNoiT
        {
            get
            {
                CanReadProperty("ThuocNoiT", true);
                return _ThuocNoiT;
            }
            set
            {
                CanWriteProperty("ThuocNoiT", true);
                if (_ThuocNoiT != value)
                {
                    _ThuocNoiT = value;
                    PropertyHasChanged("ThuocNoiT");
                }
            }
        }

        public Boolean ThuocDuoc
        {
            get
            {
                CanReadProperty("ThuocDuoc", true);
                return _thuocDuoc;
            }
            set
            {
                CanWriteProperty("ThuocDuoc", true);
                if (_thuocDuoc != value)
                {
                    _thuocDuoc = value;
                    PropertyHasChanged("ThuocDuoc");
                }
            }
        }

        public Boolean ThuocBan
        {
            get
            {
                CanReadProperty("ThuocBan", true);
                return _thuocBan;
            }
            set
            {
                CanWriteProperty("ThuocBan", true);
                if (_thuocBan != value)
                {
                    _thuocBan = value;
                    PropertyHasChanged("ThuocBan");
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
        public Boolean ThuocHoiChan
        {
            get
            {
                CanReadProperty("ThuocHoiChan", true);
                return _thuocHoiChan;
            }
            set
            {
                CanWriteProperty("ThuocHoiChan", true);
                if (_thuocHoiChan != value)
                {
                    _thuocHoiChan = value;
                    PropertyHasChanged("ThuocHoiChan");
                }
            }
        }
        public Byte ThuocTieuHao
        {
            get
            {
                CanReadProperty("ThuocTieuHao", true);
                return _thuocTieuHao;
            }
            set
            {
                CanWriteProperty("ThuocTieuHao", true);
                if (_thuocTieuHao != value)
                {
                    _thuocTieuHao = value;
                    PropertyHasChanged("ThuocTieuHao");
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

        public String nguoiHuy
        {
            get
            {
                CanReadProperty("nguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("nguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("nguoiHuy");
                }
            }
        }
        public String matp
        {
            get
            {
                CanReadProperty("matp", true);
                return _matp;
            }
            set
            {
                CanWriteProperty("matp", true);
                if (_matp != value)
                {
                    _matp = value;
                    PropertyHasChanged("matp");
                }
            }
        }
        public String duongdung
        {
            get
            {
                CanReadProperty("duongdung", true);
                return _duongdung;
            }
            set
            {
                CanWriteProperty("duongdung", true);
                if (_duongdung != value)
                {
                    _duongdung = value;
                    PropertyHasChanged("duongdung");
                }
            }
        }
        public String malh
        {
            get
            {
                CanReadProperty("malh", true);
                return _malh;
            }
            set
            {
                CanWriteProperty("malh", true);
                if (_malh != value)
                {
                    _malh = value;
                    PropertyHasChanged("malh");
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
            return _maThuoc;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            //  ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMThuoc>(StringRequired<DMThuoc>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMThuoc>(StringRequiredDVT<DMThuoc>, "MaDVT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc
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
        /// Factory method. New <see cref="DMThuoc" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMThuoc NewDMThuoc()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMThuoc>();
        }
        public static DMThuoc GetDMThuoc(String maThuoc)
        {
            return DataPortal.Fetch<DMThuoc>(new Criteria(maThuoc));
        }

        /// <summary>
        /// Marks the <see cref="DMThuoc" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMThuoc(String maThuoc, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maThuoc));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMThuoc()
        {
            // Prevent direct creation
        }
        internal DMThuoc(int OrderNumber,
                                 String maThuoc,
                                 String parent,
                                 String maNhom,
                                 String maPL,
                                 String maChungLoai,
                                 String tenGoc,
                                 String tenTC,
                                 String tenTM,
                                 String tenTM1,
                                 String tenTM2,
                                 String tenTA,
                                 Boolean thuocGoc,
                                 Decimal ngaydungtoida,
                                 String maNSX,
                                 String hamLuong,
                                 String maDVTHL,
                                 Decimal nguong,
                                 Decimal nguongNhap,
                                 String maDVT,
                                 Decimal quydoi,
                                 String maThuocgoc,
                                 String maDVT2,
                                 Boolean apDungGoi,
                                 Boolean handung,
                                 String lieudung,
                                 String cachdung,
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
                                 Boolean thuocThuT,
                                 Boolean thuocPhauT,
                                 byte thuocbh,
                                 Boolean thuocCLS,
                                 Boolean ThuocNoiT,
                                 Boolean thuocDuoc,
                                 Boolean thuocBan,
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
                                 string malh,
                                 String tendvt,
                                 string tendvthl,
                                 string tennguoisd,
                                 string tennguoilap,
                                 string tennguoihuy,
                                 string tennsx,
                                 string quycach,
                                 string matk,
                                 string sovisa,
                                 Boolean thuocban2,
                                 Boolean ThuocHoiChan,
                                 Byte ThuocTieuHao,
                                 Boolean KhongSD,
                                 Decimal giaQuay56,
                                 Decimal giaQuay561,
                                 string maql, string matp, string duongdung, string teNdvt2,
                                 Decimal gianhap43,
                                 SmartDate ngaynhap43,
                                 Decimal gianhap56,
                                 SmartDate ngaynhap56, String maBYTe,
                                 String quyetdinh,
                                String tentmbh,
                                String maBh,
                                String matduong,
                                 String quyetdinhbh,
                                String tenbyte,
                                string madangbc,
                                string madangcb,
                                string maqg,
                                string madvkt

            )
        {
            _MaBH = maBh;
            _MaTDuong = matduong;

            _TenBYTe = tenbyte;
            _QuyetDinhBH = quyetdinhbh;
            _maBYTe = maBYTe;
            _QuyetDinh = quyetdinh;
            _TenTMBH = tentmbh;
            _OrderNumber = OrderNumber;
            _gianhap56 = gianhap56;
            _ngaynhap56 = ngaynhap56;
            _gianhap43 = gianhap43;
            _ngaynhap43 = ngaynhap43;
            _maThuoc = maThuoc;
            _parent = parent;
            _maNhom = maNhom;
            _maPL = maPL;
            _duongdung = duongdung;
            _matp = matp;
            _maChungLoai = maChungLoai;
            _tenGoc = tenGoc;
            _tenTC = tenTC;
            _tenTM = tenTM;
            _tenTM1 = tenTM1;
            _tenTM2 = tenTM2;
            _tenTA = tenTA;
            _tendvt2 = teNdvt2;
            _thuocGoc = thuocGoc;
            _ngaydungtoida = ngaydungtoida;
            _maNSX = maNSX;
            _hamLuong = hamLuong;
            _maDVTHL = maDVTHL;
            _nguong = nguong;
            _nguongnhap = nguongNhap;
            _maDVT = maDVT;
            _quydoi = quydoi;
            _maThuoc2 = maThuocgoc;
            _maDVT2 = maDVT2;
            _apDungGoi = apDungGoi;
            _handung = handung;
            _lieudung = lieudung;
            _cachdung = cachdung;
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
            _giaQuay = giaQuay;
            _giaQuay1 = giaQuay1;
            _khoban = khoban;
            _maql = maql;
            _khophat = khophat;
            _thuocThuT = thuocThuT;
            _thuocPhauT = ThuocPhauT;
            _bh50 = thuocbh;
            _thuocCLS = thuocCLS;
            _ThuocNoiT = ThuocNoiT;
            _thuocDuoc = thuocDuoc;
            _thuocBan = thuocBan;
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
            _malh = malh;
            _tendvt = tendvt;
            _tendvthl = tendvthl;
            _tennguoiSD = tennguoisd;
            _tennguoiLap = tennguoilap;
            _tennguoiHuy = tennguoihuy;
            _tenNSX = tennsx;
            _KhongSD = KhongSD;
            _quycach = quycach;
            _matk = matk;
            _sovisa = sovisa;
            _thuocban2 = thuocban2;
            _thuocHoiChan = ThuocHoiChan;
            _thuocTieuHao = ThuocTieuHao;
            _giaQuay56 = giaQuay56;
            _giaQuay561 = giaQuay561;
            _madangBC = madangbc;
            _madangCB = madangcb;
            _MaQG = maqg;
            _MaDVKT = madvkt;



            if (_maql == "")
                _maql = _maThuoc;

        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maThuoc;
            public String MaThuoc
            {
                get
                {
                    return _maThuoc;
                }
            }

            public Criteria(String maThuoc)
            {
                _maThuoc = maThuoc;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maThuoc.Equals(c._maThuoc))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maThuoc.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maThuoc;
            public String maThuoc
            {
                get
                {
                    return _maThuoc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maThuoc)
            {
                _maThuoc = maThuoc;
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
        /// Retrieve an existing <see cref="DMThuoc" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMThuoc(String _maThuoc);
            // public override IDataReader GetDMThuoc(String _maThuoc)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maThuoc));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuoc(crit.MaThuoc)))
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
        /// Load a <see cref="DMThuoc" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties


            if (dr.GetString("MaDangBC") != null) _madangBC = dr.GetString("MaDangBC");
            if (dr.GetString("MaDangCB") != null) _madangCB = dr.GetString("MaDangCB");
            if (dr.GetString("MaQG") != null) _MaQG = dr.GetString("MaQG");
            if (dr.GetString("MaDVKT") != null) _MaDVKT = dr.GetString("MaDVKT");


            if (dr.GetString("MaBH") != null) _MaBH = dr.GetString("MaBH");
            if (dr.GetString("MaTDuong") != null) _MaTDuong = dr.GetString("MaTDuong");

            if (dr.GetString("QuyetDinhBH") != null) _QuyetDinhBH = dr.GetString("QuyetDinhBH");
            if (dr.GetString("TenBYte") != null) _TenBYTe = dr.GetString("TenBYte");

            if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");
            if (dr.GetString("QuyetDinh") != null) _QuyetDinh = dr.GetString("QuyetDinh");
            if (dr.GetString("TenTMBH") != null) _TenTMBH = dr.GetString("TenTMBH");
            if (dr.GetString("MaThuoc") != null) _maThuoc = dr.GetString("MaThuoc");
            if (dr.GetDecimal("Gianhap56") != null) _gianhap56 = dr.GetDecimal("Gianhap56");
            if (dr.GetSmartDate("Ngaynhap56", true) != null) _ngaynhap56 = dr.GetSmartDate("Ngaynhap56", true);

            if (dr.GetDecimal("Gianhap43") != null) _gianhap43 = dr.GetDecimal("Gianhap43");
            if (dr.GetSmartDate("Ngaynhap43", true) != null) _ngaynhap43 = dr.GetSmartDate("Ngaynhap43", true);
            if (dr.GetString("maql") != null) _maql = dr.GetString("maql");
            if (dr.GetString("Parent") != null) _parent = dr.GetString("Parent");
            if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
            if (dr.GetString("MaPL") != null) _maPL = dr.GetString("MaPL");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetString("TenGoc") != null) _tenGoc = dr.GetString("TenGoc");
            if (dr.GetString("TenTC") != null) _tenTC = dr.GetString("TenTC");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenTM1") != null) _tenTM1 = dr.GetString("TenTM1");
            if (dr.GetString("TenTM2") != null) _tenTM2 = dr.GetString("TenTM2");
            if (dr.GetString("tenTA") != null) _tenTA = dr.GetString("tenTA");
            if (dr.GetBoolean("ThuocGoc") != null) _thuocGoc = dr.GetBoolean("ThuocGoc");
            if (dr.GetDecimal("Ngaydungtoida") != null) _ngaydungtoida = dr.GetDecimal("Ngaydungtoida");
            if (dr.GetString("MaNSX") != null) _maNSX = dr.GetString("MaNSX");
            if (dr.GetString("tenNSX") != null) _tenNSX = dr.GetString("tenNSX");
            if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
            if (dr.GetString("MaDVTHL") != null) _maDVTHL = dr.GetString("MaDVTHL");
            if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
            if (dr.GetDecimal("Nguongnhap") != null) _nguongnhap = dr.GetDecimal("Nguongnhap");
            if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
            if (dr.GetDecimal("Quydoi") != null) _quydoi = dr.GetDecimal("Quydoi");
            if (dr.GetString("MaThuocgoc") != null) _maThuoc2 = dr.GetString("MaThuocgoc");
            if (dr.GetString("MaDVT2") != null) _maDVT2 = dr.GetString("MaDVT2");
            if (dr.GetBoolean("ApDungGoi") != null) _apDungGoi = dr.GetBoolean("ApDungGoi");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            if (dr.GetString("Lieudung") != null) _lieudung = dr.GetString("Lieudung");
            if (dr.GetString("Cachdung") != null) _cachdung = dr.GetString("Cachdung");
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
            if (dr.GetBoolean("ThuocThuT") != null) _thuocThuT = dr.GetBoolean("ThuocThuT");
            if (dr.GetBoolean("ThuocPhauT") != null) _thuocPhauT = dr.GetBoolean("ThuocPhauT");
            if (dr.GetByte("bh50") != null) _bh50 = dr.GetByte("bh50");
            if (dr.GetBoolean("ThuocCLS") != null) _thuocCLS = dr.GetBoolean("ThuocCLS");
            if (dr.GetBoolean("ThuocNoiT") != null) _ThuocNoiT = dr.GetBoolean("ThuocNoiT");
            if (dr.GetBoolean("ThuocDuoc") != null) _thuocDuoc = dr.GetBoolean("ThuocDuoc");
            if (dr.GetBoolean("ThuocBan") != null) _thuocBan = dr.GetBoolean("ThuocBan");
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
            if (dr.GetString("nguoiHuy") != null) _nguoiHuy = dr.GetString("nguoiHuy");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");
            if (dr.GetString("duongdung") != null) _duongdung = dr.GetString("duongdung");
            if (dr.GetString("matp") != null) _matp = dr.GetString("matp");
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("tendvt2") != null) _tendvt2 = dr.GetString("tendvt2");
            if (dr.GetString("tendvthl") != null) _tendvthl = dr.GetString("tendvthl");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("quycach") != null) _quycach = dr.GetString("quycach");
            if (dr.GetString("matk") != null) _matk = dr.GetString("matk");
            if (dr.GetString("sovisa") != null) _sovisa = dr.GetString("sovisa");
            if (dr.GetBoolean("thuocban2") != null) _thuocban2 = dr.GetBoolean("thuocban2");
            if (dr.GetBoolean("ThuocHoiChan") != null) _thuocHoiChan = dr.GetBoolean("ThuocHoiChan");
            if (dr.GetByte("ThuocTieuHao") != null) _thuocTieuHao = dr.GetByte("ThuocTieuHao");
            if (dr.GetBoolean("khongsd") != null) _KhongSD = dr.GetBoolean("khongsd");
            if (dr.GetDecimal("GiaQuay56") != null) _giaQuay56 = dr.GetDecimal("GiaQuay56");
            if (dr.GetDecimal("GiaQuay561") != null) _giaQuay561 = dr.GetDecimal("GiaQuay561");
            if (_maql == "")
                _maql = _maThuoc;
        }

        /// <summary>
        /// Insert the new <see cref="DMThuoc" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc
            // Copy & paste ham duoi day vao file DataProvider.cs


            _maThuoc = InsertDMThuoc(_parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _nguongnhap, _maDVT, _quydoi, _maThuoc2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _bh50, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _thuocHoiChan, _ghichu, _maMay, _nguoiSD, _malh, _quycach, _matk, _sovisa, _thuocban2, _maql, _thuocTieuHao, _matp, _duongdung, _gianhap, _gianhap43, _gianhap56, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _madangBC, _madangCB, _MaQG, _MaDVKT);
            // public abstract String InsertDMThuoc(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD);
            // public override String InsertDMThuoc(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTHUOC_CREATE",  _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maThuoc2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD), String);
            // }
        }


        public String InsertDMThuoc(string _parent,string  _maNhom, string _maPL, string _maChungLoai, string _tenGoc, string _tenTC, string _tenTM, string _tenTM1, string _tenTM2, string _tenTA,Boolean _thuocGoc,Decimal _ngaydungtoida,string _maNSX, string _hamLuong, string _maDVTHL,Decimal _nguong,Decimal _nguongnhap,string _maDVT,Decimal _quydoi,string _maThuoc2, string _maDVT2,Boolean _apDungGoi, Boolean  _handung,string _lieudung, string  _cachdung, string  _khoban, string _khophat,Boolean _thuocThuT, Boolean _thuocPhauT,Byte _bh50,Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, Boolean _thuocHoiChan,string _ghichu, string _maMay, string _nguoiSD, string _malh, string _quycach, string _matk, string _sovisa,Boolean _thuocban2, string _maql,Byte _thuocTieuHao,string _matp, string _duongdung, Decimal _gianhap,Decimal _gianhap43, Decimal _gianhap56,string _maBYTe, string _QuyetDinh, string _TenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe, string _madangBC, string _madangCB, string _MaQG, string _MaDVKT )
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            string DatabaseOwner = "dbo.";
            string ObjectQualifier = "";
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTHUOC_CREATE_130", _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _nguongnhap, _maDVT, _quydoi, _maThuoc2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _bh50, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _thuocHoiChan, _ghichu, _maMay, _nguoiSD, _malh, _quycach, _matk, _sovisa, _thuocban2, _maql, _thuocTieuHao, _matp, _duongdung, _gianhap, _gianhap43, _gianhap56, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _madangBC, _madangCB, _MaQG, _MaDVKT));
        }



        /// <summary>
        /// Update all changes made on <see cref="DMThuoc" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc
            if (IsDirty)
            {


                DataProvider.Instance().UpdateDMThuoc(_maThuoc, _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _nguongnhap, _maDVT, _quydoi, _maThuoc2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _bh50, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _thuocHoiChan, _ghichu, _maMay, _huy, _nguoiSD, _malh, _quycach, _matk, _sovisa, _thuocban2, _KhongSD, _maql, _thuocTieuHao, _matp, _duongdung, _gianhap, _gianhap43, _gianhap56, _maBYTe, _QuyetDinh, _TenTMBH, _MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe);
                // public abstract void UpdateDMThuoc(String _maThuoc, String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateDMThuoc(String _maThuoc, String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTHUOC_UPDATE", _maThuoc, _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maThuoc2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _gianhap, _ngaynhap.DBValue, _gianhap1, _ngaynhap1.DBValue, _gianhap2, _ngaynhap2.DBValue, _donGiaTT, _donGiaTT1, _dongiaThuT, _dongiaPhauT, _dongiaCLS, _giaQuay, _giaQuay1, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , );
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maThuoc));
        }

        /// <summary>
        /// Delete the <see cref="DMThuoc" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc
            DataProvider.Instance().DeleteDMThuoc(crit.MaMay, crit.NguoiSD, crit.maThuoc);
            // public abstract void DeleteDMThuoc(String _maThuoc);
            // public override void DeleteDMThuoc(String _maThuoc);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTHUOC_DELETED", _maThuoc);
            // }
        }

        #endregion
    }





}