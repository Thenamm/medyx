using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using Telerik.Web.UI;
using HTC.Common.Web;
using System.Drawing.Imaging;
using System.IO ;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Configuration;
using Resources.RadGrid;
using System.Globalization;
using HTC.Business.NhanSu;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using iTextSharp.text;
using Image = System.Web.UI.WebControls.Image;

public partial class UI_Category_DMHanhChinh_frmDMNhanVien : WebBase
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
    private const string ViewState_DMNhanVienList = "_DMNhanVienList";
    private string maNV;
    private string _nguoiSD;
    private string maMay;
    private string nguoiSD;

    public List<DMNhanVienM> _DMNhanVienList
    {
        get
        {
            if (ViewState[ViewState_DMNhanVienList] == null)
            {
                ViewState[ViewState_DMNhanVienList] = DMNhanVienM.GetDMNhanVienM();
            }

            return (List<DMNhanVienM>)ViewState[ViewState_DMNhanVienList];
        }

        set
        {
            ViewState[ViewState_DMNhanVienList] = value;
        }

    }

    public string HoTen { get; private set; }
    public string MaNV { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;
            LoadDMKhoa();
          
            if (Request["makhoa"] != null)
            {
                cboDSKhoa.SelectedValue = Request["makhoa"].ToString();
                grdChiTiet.MasterTableView.GetColumn("EditRoles").Display = false;
                grdChiTiet.MasterTableView.GetColumn("Delete").Display = false;
            }
            if (HTC.ShareVariables.pub_spC == "PS")
            {
                grdChiTiet.MasterTableView.GetColumn("GhiChu").Display = false;
                grdChiTiet.MasterTableView.GetColumn("DienThoaiKhoa").Display = false;
            }
            else
            {
                grdChiTiet.MasterTableView.GetColumn("SoCMT").Display = false;
                grdChiTiet.MasterTableView.GetColumn("TaiKhoan").Display = false;
            }
            BindGridData();
            grdChiTiet.DataBind();
        }

        if (pub_bQadmin == false)
            grdChiTiet.MasterTableView.GetColumn("Huy").Display = false;
    }
 
    private void LoadDMKhoa()
    {
        DMKhoaListcb list = DMKhoaListcb.GetList();

        cboDSKhoa.DataSource = list;
        cboDSKhoa.DataBind();
    }

    protected void cboDSKhoa_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        BindGridData(true,"","",null, null);
        
    }

    public void BindGridData(Boolean _load = true, string dk = "", string dkfilter = "",object source=null, GridNeedDataSourceEventArgs e=null)
    {
        
        //string maKhoa = cboDSKhoa.SelectedValue;
        if (dkfilter == "")
            dkfilter = " and a.row >= 0 and a.row < " + grdChiTiet.PageSize.ToString();

        if (dk == null)
            dk = "";
        if (string.IsNullOrEmpty(cboDSKhoa.SelectedValue))
        {
          
        }
        else
        {
            dk = dk+ " AND A.MAKHOA LIKE  '" + cboDSKhoa.SelectedValue + "%'";
           
        }
         //_DMNhanVienList = DMNhanVienM.FindDMNhanVienByFilter(dk, dkfilter, true);
         
         if (_DMNhanVienList != null)
        {
            grdChiTiet.VirtualItemCount = _DMNhanVienList.Count;
      
            grdChiTiet.DataSource = _DMNhanVienList;
        }
        else
        {
            grdChiTiet.DataSource = "";
        }
        grdChiTiet.DataBind();
    }


    /// <summary>
    /// Shows a <see cref="RadWindow"/> alert if an error occurs
    /// </summary>
    private void ShowErrorMessage()
    {
        //RadAjaxManager1.ResponseScripts.Add(string.Format("window.radalert(\"Please enter valid data!\")"));
    }

    private void UpdateNhanVien(GridEditableItem item, FormAction action)
    {
        try
        {

            // var editableItem = ((GridEditableItem)e.Item);
            string MaNV = item.GetDataKeyValue("MaNV").ToString();
            var ten = DMNhanVien.GetDMNhanVien(MaNV);
            //  GridEditableItem editedItem = e.Item as GridEditableItem;

            if (ten != null)
            {
                string hoten = string.Empty;

                string maKhoa = cboDSKhoa.SelectedValue;
                string machucvu = string.Empty;
                string maLoaiHD = string.Empty;
                string machuyenmon = string.Empty;
                string mamay = string.Empty;
                string macd = string.Empty;
                string tentat = string.Empty;
                string ghichu = string.Empty;
                string idnhanvien = string.Empty;
                string nguoisd = string.Empty;
                string DienThoai = string.Empty;
                string MaChungChiHanhNghe = string.Empty;
                string DienThoaiKhoa = string.Empty;
                string NguoiGiamHo = string.Empty;               
                bool isHuy = false;
                isHuy = ((CheckBox)item["Huy"].Controls[0]).Checked;
                bool khongsd = false;
                khongsd = ((CheckBox)item["KhongSD"].Controls[0]).Checked;
                string MaBHXH = string.Empty;
                string NgayCap_CCHN = string.Empty;
                string NgaySinh = string.Empty;
                string PhamVi_CM = string.Empty;
                string PhamVi_CMBS = string.Empty;
                string ThoiGian_Ngay = string.Empty;
                string ThoiGian_Tuan = string.Empty;
                try
                {
                    if (item["Hoten"].Controls[0] != null)
                    {
                        hoten = ((TextBox)item["Hoten"].Controls[0]).Text;
                    }

                    if (hoten == "")
                    {
                        ShowMessage("Chưa nhập họ tên nhân viên");
                        return;
                    }
                    if (item["MaBHXH"].Controls[0] != null)
                    {
                        MaBHXH = ((TextBox)item["MaBHXH"].Controls[0]).Text;
                    }

                    if (MaBHXH == "")
                    {
                        ShowMessage("nhap MaBHXH");
                        return;
                    }

                    if (item["NgayCap_CCHN"].Controls[0] != null)
                    {
                        NgayCap_CCHN = ((TextBox)item["NgayCap_CCHN"].Controls[0]).Text;
                    }

                    if (NgayCap_CCHN == "")
                    {
                        ShowMessage("Nhập Ngày cấp CCHN");
                        return;
                    }

                    if (item["NgaySinh"].Controls[0] != null)
                    {
                        NgaySinh = ((TextBox)item["NgaySinh"].Controls[0]).Text;
                    }
                    if (NgaySinh == "")
                    {
                        ShowMessage("Nhập Ngày sinh");
                        return;
                    }

                    if (item["PhamVi_CM"].Controls[0] != null)
                    {
                        PhamVi_CM = ((TextBox)item["PhamVi_CM"].Controls[0]).Text;
                    }
                    if (PhamVi_CM == "")
                    {
                        ShowMessage("Nhập phạm vi hoạt động chuyên môn");
                        return;
                    }
                    if (item["PhamVi_CMBS"].Controls[0] != null)
                    {
                        PhamVi_CMBS = ((TextBox)item["PhamVi_CMBS"].Controls[0]).Text;
                    }
                    if (PhamVi_CMBS == "")
                    {
                        ShowMessage("Nhập phạm vi  chuyên môn bổ sung");
                        return;
                    }

                    if (item["ThoiGian_Ngay"].Controls[0] != null)
                    {
                        ThoiGian_Ngay = ((TextBox)item["ThoiGian_Ngay"].Controls[0]).Text;
                    }
                    if (ThoiGian_Ngay == "")
                    {
                        ShowMessage("Nhập thời gian làm việc");
                        return;
                    }

                    if (item["ThoiGian_Tuan"].Controls[0] != null)
                    {
                        ThoiGian_Tuan = ((TextBox)item["ThoiGian_Tuan"].Controls[0]).Text;
                    }
                    if (ThoiGian_Tuan == "")
                    {
                        ShowMessage("Nhập ngày  làm việc");
                        return;
                    }


                    if (item["MaChucVu"].FindControl("cboChucVu") != null)
                    {
                        machucvu = ((RadComboBox)item["MaChucVu"].FindControl("cboChucVu")).SelectedValue;
                    }
                    if (item["MaLoaiHD"].FindControl("cboLoaiHD") != null)
                    {
                        maLoaiHD = ((RadComboBox)item["MaLoaiHD"].FindControl("cboLoaiHD")).SelectedValue;
                    }
                    if (item["MaKhoa"].FindControl("cboKhoa") != null)
                    {
                        maKhoa = ((RadComboBox)item["MaKhoa"].FindControl("cboKhoa")).SelectedValue;
                    }
                    if (item["MaChuyenMon"].FindControl("cboChuyenmon") != null)
                    {
                        machuyenmon = ((RadComboBox)item["MaChuyenMon"].FindControl("cboChuyenmon")).SelectedValue;
                    }
                    if (item["MaCD"].FindControl("cboChucDanh") != null)
                    {
                        macd = ((RadComboBox)item["MaCD"].FindControl("cboChucDanh")).SelectedValue;
                    }

                    MaNV = item.GetDataKeyValue("MaNV").ToString();

                    if (item["DienThoai"].Controls[0] != null)
                    {
                        DienThoai = ((TextBox)item["DienThoai"].Controls[0]).Text;
                    }

                    if (item["MaChungChiHanhNghe"].Controls[0] != null)
                    {
                        MaChungChiHanhNghe = ((TextBox)item["MaChungChiHanhNghe"].Controls[0]).Text;
                    }


                    string chuKy = "";
                    if (HTC.ShareVariables.pub_spC == "PS")
                    {
                        if (item["TaiKhoan"].Controls[0] != null)
                        {
                            DienThoaiKhoa = ((TextBox)item["TaiKhoan"].Controls[0]).Text;
                        }
                        if (item["SoCMT"].Controls[0] != null)
                        {
                            ghichu = ((TextBox)item["SoCMT"].Controls[0]).Text;
                        }
                    }
                    else
                    {
                        if (item["GhiChu"].FindControl("cboQuay") != null)
                        {
                            ghichu = ((DropDownList)item["GhiChu"].FindControl("cboQuay")).SelectedValue;
                            ghichu = ((DropDownList)item["GhiChu"].FindControl("cboQuay")).SelectedValue;
                        }


                        if (item["DienThoaiKhoa"].Controls[0] != null)
                        {
                            DienThoaiKhoa = ((TextBox)item["DienThoaiKhoa"].Controls[0]).Text;
                        }
                        RadAsyncUpload upload = (RadAsyncUpload)item.FindControl("ChuKy");
                         chuKy = saveImage(upload, MaNV);
                    }

                    if (item["NguoiGiamHo"].FindControl("DMNguoiGiamHo") != null)
                    {
                        NguoiGiamHo = ((RadComboBox)item["NguoiGiamHo"].FindControl("DMNguoiGiamHo")).SelectedValue;
                    }

                   // UpdateDMNhanVienM(MaNV,hoten, machucvu,machuyenmon, maKhoa,khongsd,isHuy,mamay, nguoiSD, macd, tentat, ghichu, idnhanvien, DienThoai, MaChungChiHanhNghe, NguoiGiamHo, DienThoaiKhoa, MaBHXH, NgayCap_CCHN, NgaySinh, PhamVi_CM, PhamVi_CMBS, ThoiGian_Ngay, ThoiGian_Tuan);

                    UpdateDMNhanVienM(MaNV, hoten, machucvu, machuyenmon, maKhoa, khongsd, isHuy, mamay, nguoiSD, macd, tentat, ghichu, idnhanvien, DienThoai, MaChungChiHanhNghe, NguoiGiamHo, DienThoaiKhoa, MaBHXH, NgayCap_CCHN, NgaySinh, PhamVi_CM, PhamVi_CMBS, ThoiGian_Ngay, ThoiGian_Tuan);
                    //HTC.Business.DataProvider.Instance().UpdateDMNhanVien(MaNV, hoten, machucvu, maLoaiHD, machuyenmon, maKhoa, khongsd, isHuy, mamay, nguoisd, macd, tentat, ghichu, idnhanvien, DienThoai, MaChungChiHanhNghe, NguoiGiamHo, DienThoaiKhoa, chuKy);
                    BindGridData();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString() + "\\" + ex.Message);
                }
            }
        }
        catch (Exception)
        {


        }

        


    }
    public System.Drawing.Bitmap resizeImage(System.Drawing.Bitmap img, int width, int height)
    {
        System.Drawing.Bitmap b = new System.Drawing.Bitmap(width, height);
        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage((System.Drawing.Image)b);

        g.DrawImage(img, 0, 0, width, height);
        g.Dispose();

        return (System.Drawing.Bitmap)b;
    }
    public string saveImage(RadAsyncUpload upload, string manv)
    {
        string chuKy = Server.MapPath("/ChuKy/AnhNV") + manv + ".jpg";
        if (System.IO.File.Exists(chuKy))
            System.IO.File.Delete(chuKy);
        if (upload.UploadedFiles != null && upload.UploadedFiles.Count > 0)
        {
            System.Drawing.Bitmap bmpPostedImage = new System.Drawing.Bitmap(upload.UploadedFiles[0].InputStream);
            if (bmpPostedImage.Width > 200 || bmpPostedImage.Height > 100)
            {
                System.Drawing.Bitmap bmp = resizeImage(bmpPostedImage, 100, 50);
                bmp.Save(chuKy, ImageFormat.Jpeg);
            }
            else
            {
                bmpPostedImage.Save(chuKy, ImageFormat.Jpeg);
            }
        }
        return chuKy;
    }





    protected void grdChiTiet_DeleteCommand(object sender, GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;

            if (editedItem != null)
            {
                string MaNV = editedItem.GetDataKeyValue("MaNV").ToString();

                //HTC.Business.DataProvider.Instance().DeleteDMNhanVien(Pub_sMaMay, Pub_sNguoiSD, _maNV);
                DeleteDMNhanVienM(Pub_sMaMay, Pub_sNguoiSD, MaNV);
                _DMNhanVienList = null;

                //grdChiTiet.DataSource = _DMNhanVienList;
                //grdChiTiet.DataBind();

                //ShowMessage(MessageType.SUCCESS, FormAction.DELETE);
            }
        }
        catch (Exception ex)
        {
            HandleException(ex, FormAction.DELETE);
            ShowMessage(MessageType.ERROR, FormAction.DELETE);
        }

        e.Canceled = true;
    }

    public void grdChiTiet_InsertCommand(object sender, GridCommandEventArgs e)
    {

        var editableItem = ((GridEditableItem)e.Item);

        GridEditableItem editedItem = e.Item as GridEditableItem;
        string hoten = string.Empty;
        string MaNV = string.Empty;
        string maKhoa = cboDSKhoa.SelectedValue;
        string machucvu = string.Empty;
        string maLoaiHD = string.Empty;
        string machuyenmon = string.Empty;
        string mamay = string.Empty;
        string macd = string.Empty;
        string tentat = string.Empty;
        string ghichu = string.Empty;
        string idnhanvien = string.Empty;
        string nguoisd = string.Empty;
        bool isHuy = false;
        isHuy = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
        bool khongsd = false;
        khongsd = ((CheckBox)editedItem["KhongSD"].Controls[0]).Checked;
        string DienThoai = string.Empty;
        string MaChungChiHanhNghe = string.Empty;
        string DienThoaiKhoa = string.Empty;
        string NguoiGiamHo = string.Empty;
        string MaBHXH = string.Empty;
        string NgayCap_CCHN = string.Empty;
        string NgaySinh = string.Empty;
        string PhamVi_CM = string.Empty;
        string PhamVi_CMBS = string.Empty;
        string ThoiGian_Ngay = string.Empty;
        string ThoiGian_Tuan = string.Empty;
        string chuKy = "";

        
        try
        {
            if (editableItem["Hoten"].Controls[0] != null)
            {
                hoten = ((TextBox)editableItem["Hoten"].Controls[0]).Text;
            }
            if (hoten == "")
            {
                ShowMessage("Chưa nhập họ tên nhân viên");
                e.Canceled = true;
                return;
            }
            if (editableItem["MaBHXH"].Controls[0] != null)
            {
                MaBHXH = ((TextBox)editableItem["MaBHXH"].Controls[0]).Text;
            }
            if (MaBHXH == "")
            {
                ShowMessage("Nhap maBHXH");
                e.Canceled = true;
                return;
            }
            if (editableItem["NgayCap_CCHN"].Controls[0] != null)
            {
                NgayCap_CCHN = ((TextBox)editableItem["NgayCap_CCHN"].Controls[0]).Text;
            }
            if (NgayCap_CCHN == "")
            {
                ShowMessage("Nhập Ngày cấp CCHN");
                e.Canceled = true;
                return;
            }
            if (editableItem["NgaySinh"].Controls[0] != null)
            {
                NgaySinh = ((TextBox)editableItem["NgaySinh"].Controls[0]).Text;
            }
            if (NgaySinh == "")
            {
                ShowMessage("Nhập ngày sinh");
                e.Canceled = true;
                return;
            }


            if (editableItem["PhamVi_CM"].Controls[0] != null)
            {
                PhamVi_CM = ((TextBox)editableItem["PhamVi_CM"].Controls[0]).Text;
            }
            if (PhamVi_CM == "")
            {
                ShowMessage("Nhập phạm vi hoạt động chuyên môn");
                e.Canceled = true;
                return;
            }
            if (editableItem["PhamVi_CMBS"].Controls[0] != null)
            {
                PhamVi_CMBS = ((TextBox)editableItem["PhamVi_CMBS"].Controls[0]).Text;
            }
            if (PhamVi_CMBS == "")
            {
                ShowMessage("Nhập phạm vi chuyên môn bổ sung");
                e.Canceled = true;
                return;
            }



            if (editableItem["ThoiGian_Ngay "].Controls[0] != null)
            {
                ThoiGian_Ngay = ((TextBox)editableItem["ThoiGian_Ngay "].Controls[0]).Text;
            }
            if (ThoiGian_Ngay == "")
            {
                ShowMessage("Nhập thời gian làm việc");
                e.Canceled = true;
                return;
            }

            if (editableItem["ThoiGian_Tuan"].Controls[0] != null)
            {
                ThoiGian_Tuan = ((TextBox)editableItem["ThoiGian_Tuan"].Controls[0]).Text;
            }
            if (ThoiGian_Tuan == "")
            {
                ShowMessage("Nhập ngày làm việc");
                e.Canceled = true;
                return;
            }


            if (editableItem["MaChucVu"].FindControl("cboChucVu") != null)
            {
                machucvu = ((RadComboBox)editableItem["MaChucVu"].FindControl("cboChucVu")).SelectedValue;
            }
            if (editableItem["MaLoaiHD"].FindControl("cboLoaiHD") != null)
            {
                maLoaiHD = ((RadComboBox)editableItem["MaLoaiHD"].FindControl("cboLoaiHD")).SelectedValue;
            }
            if (editableItem["MaChuyenMon"].FindControl("cboChuyenmon") != null)
            {
                machuyenmon = ((RadComboBox)editableItem["MaChuyenMon"].FindControl("cboChuyenmon")).SelectedValue;
            }
            if (editableItem["MaCD"].FindControl("cboChucDanh") != null)
            {
                macd = ((RadComboBox)editableItem["MaCD"].FindControl("cboChucDanh")).SelectedValue;
            }
            if (editableItem["MaKhoa"].FindControl("cboKhoa") != null)
            {
                maKhoa = ((RadComboBox)editableItem["MaKhoa"].FindControl("cboKhoa")).SelectedValue;
            }
            if (editableItem["DienThoai"].Controls[0] != null)
            {
                DienThoai = ((TextBox)editableItem["DienThoai"].Controls[0]).Text;
            }

            if (editableItem["MaChungChiHanhNghe"].Controls[0] != null)
            {
                MaChungChiHanhNghe = ((TextBox)editableItem["MaChungChiHanhNghe"].Controls[0]).Text;
            }
            

            if (editableItem["NguoiGiamHo"].FindControl("DMNguoiGiamHo") != null)
            {
                NguoiGiamHo = ((RadComboBox)editableItem["NguoiGiamHo"].FindControl("DMNguoiGiamHo")).SelectedValue;
            }
            


            
            if (HTC.ShareVariables.pub_spC == "PS")
            {
                if (editableItem["TaiKhoan"].Controls[0] != null)
                {
                    DienThoaiKhoa = ((TextBox)editableItem["TaiKhoan"].Controls[0]).Text;
                }
                if (editableItem["SoCMT"].Controls[0] != null)
                {
                    ghichu = ((TextBox)editableItem["SoCMT"].Controls[0]).Text;
                }
            }
            else
            {
                if (editableItem["GhiChu"].FindControl("cboQuay") != null)
                {
                    ghichu = ((DropDownList)editableItem["GhiChu"].FindControl("cboQuay")).SelectedValue;
                }
                if (editableItem["DienThoaiKhoa"].Controls[0] != null)
                {
                    DienThoaiKhoa = ((TextBox)editableItem["DienThoaiKhoa"].Controls[0]).Text;
                }
                RadAsyncUpload upload = (RadAsyncUpload)editableItem.FindControl("ChuKy");
                if (upload != null)
                    chuKy = saveImage(upload, MaNV);
            }


            mamay = Pub_sMaMay;
            nguoisd = Pub_sNguoiSD;
            InsertDMNhanVienM( hoten, MaBHXH, mamay, nguoisd, maKhoa, machucvu,  machuyenmon, mamay, macd, tentat, ghichu, idnhanvien,  khongsd, DienThoai, MaChungChiHanhNghe, DienThoaiKhoa, NguoiGiamHo,  NgayCap_CCHN, NgaySinh, PhamVi_CM, PhamVi_CMBS, ThoiGian_Ngay, ThoiGian_Tuan);

            





        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString() + "\\" + ex.Message);
        }

    }
    protected void grdChiTiet_PageIndexChanged(object sender, GridPageChangedEventArgs e)
    {

        string sql = "";
        sql = " and row >= " + ((e.NewPageIndex) * grdChiTiet.PageSize).ToString() + " and row < " + ((e.NewPageIndex + 1) * grdChiTiet.PageSize).ToString();

        // _FilterSql = "";
        BindGridData(true, _FilterSql, sql);
    }
    protected void grdChiTiet_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
    {
        string sql = "";
        sql = " and a.row >= " + ((grdChiTiet.CurrentPageIndex) * e.NewPageSize).ToString() + " and a.row < " + ((grdChiTiet.CurrentPageIndex + 1) * e.NewPageSize).ToString();
        // _FilterSql = "";
        BindGridData(true, _FilterSql, sql);
    }
    protected void grdChiTiet_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if (String.IsNullOrEmpty(e.CommandName))
        {
            Response.Redirect("~/Default.aspx");
        }
        else if (e.CommandName == RadGrid.ExportToExcelCommandName)
        {
            try
            {
                string filename = "DMNhanVien_" + DateTime.Now.Date.ToString() + ".xls";
                string excelHeader = "DMNhanVien";
                System.IO.StringWriter tw = new System.IO.StringWriter();
                System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
                DataGrid dgGrid = new DataGrid();

                dgGrid.DataSource = HTC.Business.DataProvider.Instance().GetAllDMNhanVien(false);
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
        else if (e.CommandName == RadGrid.FilterCommandName)
        {

            Pair filterPair = (Pair)e.CommandArgument;
            GridFilteringItem item = (e.Item as GridFilteringItem);
            TextBox filterBoxMaBAQL = item["MaNV"].Controls[0] as TextBox;
            TextBox filterBoxHoTen = item["HoTen"].Controls[0] as TextBox;
          
            string FilterSql = "";
          
            if (filterBoxMaBAQL.Text != "")
            {
                FilterSql = FilterSql + "and A.MANV like N'%" + filterBoxMaBAQL.Text + "%'";
            }
           
            if (filterBoxHoTen.Text != "")
            {
                FilterSql = FilterSql + "and A.hoten like N'%" + filterBoxHoTen.Text + "%'";
            }
            
            grdChiTiet.CurrentPageIndex = 0;
            string sql = " and a.row >= " + (( grdChiTiet.CurrentPageIndex) *  grdChiTiet.PageSize).ToString() + " and a.row < " + (( grdChiTiet.CurrentPageIndex + 1) *  grdChiTiet.PageSize).ToString();
            _FilterSql = FilterSql;
           
            BindGridData(true, FilterSql, sql);


        }
        if (e.CommandName == RadGrid.RebindGridCommandName)
        {
            //  Response.Redirect(referencepage);
            //RadAjaxManager1.ResponseScripts.Add("window.history.back(-1);");                
        }
        else if (e.CommandName == RadGrid.EditCommandName)
        {
        }
        else if (e.CommandName == RadGrid.UpdateCommandName)
        {
            GridEditableItem item = e.Item as GridEditableItem;
            UpdateNhanVien(item, FormAction.EDIT);
        }
        //else if (e.CommandName == "PerformInsert")
        //{
        //    GridEditableItem item = e.Item as GridEditableItem;
        //    UpdateNhanVien(item);
        //}

        else if (e.CommandName.Equals("EditRoles", StringComparison.InvariantCultureIgnoreCase))
        {
            GridDataItem item = e.Item as GridDataItem;

            if (item != null)
            {
                string maNV = item.GetDataKeyValue("MaNV").ToString();

                Response.Redirect("~/UI/Category/DMQuanTri/frmPhanQuyen.aspx?MaNV=" + maNV);
            }
        }
    }
	protected void grdChiTiet_ItemDataBound(object sender, GridItemEventArgs e)
	{
        if (e.Item is GridEditableItem && e.Item.IsInEditMode && !(e.Item is IGridInsertItem))
        {
            GridEditableItem EditItems = e.Item as GridEditableItem;
            RadComboBox rcbObj;
            DMNhanVienM _DMNhanVien = _DMNhanVienList.FirstOrDefault(X => X.MaNV == EditItems.GetDataKeyValue("MaNV").ToString ());
            rcbObj = EditItems["MaChucVu"].FindControl("cboChucVu") as RadComboBox;

            rcbObj.SelectedValue = _DMNhanVien.MaChucVu ;

            rcbObj = EditItems["MaKhoa"].FindControl("cboKhoa") as RadComboBox;
            rcbObj.SelectedValue = _DMNhanVien.MaKhoa;

            rcbObj = EditItems["MaChuyenMon"].FindControl("cboChuyenmon") as RadComboBox;
            rcbObj.SelectedValue = _DMNhanVien.MaChuyenMon;

            rcbObj = EditItems["MaCD"].FindControl("cboChucDanh") as RadComboBox;
            rcbObj.SelectedValue = _DMNhanVien.MaCD;

            rcbObj = EditItems["NguoiGiamHo"].FindControl("DMNguoiGiamHo") as RadComboBox;
            rcbObj.SelectedValue = _DMNhanVien.NguoiGiamHo;
            rcbObj.Text = _DMNhanVien.TenNguoiGiamHo;

            (EditItems["GhiChu"].FindControl("cboQuay") as DropDownList).SelectedValue = _DMNhanVien.ghichu;
            if (e.Item is GridDataItem)
            {
                GridDataItem item = (GridDataItem)e.Item;
                // you can access the image and set the ImageUrl property  
                Image image = (Image)item["ChuKy"].FindControl("anhChuKy");
                if (File.Exists(Server.MapPath("/ChuKy/AnhNV") + e.Item.DataItem + ".jpg"))
                {
                    string url = "~/ChuKy/AnhNV" + e.Item.DataItem + ".jpg";
                    if (image != null)
                    {
                        image.ImageUrl = url;
                    }
                }
            }

        }
	}
    protected void grdChiTiet_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
       
        grdChiTiet.DataSource = _DMNhanVienList;
    }


    public String InsertDMNhanVienM( String _HoTen, String MaBHXH, string _maMay, String _nguoiSD, string maKhoa,string machucvu,string machuyenmon,string mamay,string macd,string tentat,string ghichu,string idnhanvien,bool khongsd,string DienThoai,string MaChungChiHanhNghe,string NguoiGiamHo, String DienThoaiKhoa, string NgayCap_CCHN, string NgaySinh,string PhamVi_CM, string PhamVi_CMBS, string ThoiGian_Ngay, string ThoiGian_Tuan)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhanVien_CREATE_QD130",  _HoTen, machucvu,machuyenmon,maKhoa,khongsd,mamay,nguoiSD,macd,tentat,ghichu,idnhanvien,DienThoai,MaChungChiHanhNghe,NguoiGiamHo,DienThoaiKhoa,MaBHXH, NgayCap_CCHN, NgaySinh, PhamVi_CM, PhamVi_CMBS, ThoiGian_Ngay, ThoiGian_Tuan));
    }
    public void UpdateDMNhanVienM(string _maNV,string _HoTen,string machuyenmon,string machucvu,string maKhoa, bool khongsd, bool isHuy,string mamay,string nguoisd,string macd,string tentat,string ghichu,string idnhanvien , string DienThoai, string MaChungChiHanhNghe, string NguoiGiamHo, String DienThoaiKhoa, string MaBHXH, string NgayCap_CCHN, string NgaySinh, string PhamVi_CM, string PhamVi_CMBS, string ThoiGian_Ngay, string ThoiGian_Tuan)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhanVien_update_QD130", _maNV, _HoTen,machucvu,machuyenmon,maKhoa,khongsd,isHuy,mamay, nguoisd, macd,tentat,ghichu,idnhanvien, DienThoai, MaChungChiHanhNghe, NguoiGiamHo, DienThoaiKhoa, MaBHXH, NgayCap_CCHN, NgaySinh, PhamVi_CM, PhamVi_CMBS, ThoiGian_Ngay, ThoiGian_Tuan);
    }
    public void DeleteDMNhanVienM(String _maMay, String _nguoiSD, String _maNV)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNHANVIEN_DELETED", _maMay, _nguoiSD, _maNV);
    }
    [Serializable]
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
        private String _maBHXH = String.Empty;
        private String _NgayCap_CCHN = String.Empty;
        private String _NgaySinh = String.Empty;
        private String _PhamVi_CM = String.Empty;
        private String _ThoiGian_Ngay = String.Empty;
        private String _ThoiGian_Tuan = String.Empty;
        private String _PhamVi_CMBS = String.Empty;
        private String _TenCV = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private String _TenKhoa = String.Empty;
        private String _TENCHUYENMON = String.Empty;
        private String _TENCD = String.Empty;
        private String _TenLoaiHD = String.Empty;

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
        public String NgayCap_CCHN
        {
            get
            {
                return _NgayCap_CCHN;
            }
            set
            {
                if (_NgayCap_CCHN != value)
                {
                    _NgayCap_CCHN = value;
                }
            }
        }

        public String NgaySinh
        {
            get
            {
                return _NgaySinh;
            }
            set
            {
                if (_NgaySinh != value)
                {
                    _NgaySinh = value;
                }
            }
        }
        public String PhamVi_CM
        {
            get
            {
                return _PhamVi_CM;
            }
            set
            {
                if (_PhamVi_CM != value)
                {
                    _PhamVi_CM = value;
                }
            }
        }

        public String PhamVi_CMBS
        {
            get
            {
                return _PhamVi_CMBS;
            }
            set
            {
                if (_PhamVi_CMBS != value)
                {
                    _PhamVi_CMBS = value;
                }
            }
        }

        public String ThoiGian_Ngay
        {
            get
            {
                return _ThoiGian_Ngay;
            }
            set
            {
                if (_ThoiGian_Ngay != value)
                {
                    _ThoiGian_Ngay = value;
                }
            }
        }

        public String ThoiGian_Tuan
        {
            get
            {
                return _ThoiGian_Tuan;
            }
            set
            {
                if (_ThoiGian_Tuan != value)
                {
                    _ThoiGian_Tuan = value;
                }
            }
        }
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

        public DMNhanVienM(IDataReader dr)
        {
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
            if (dr["MaBHXH"].GetType().Name != "DBNull" && dr["MaBHXH"] != null)
            {
                this.MaBHXH = Convert.ToString(dr["MaBHXH"]);
            }
            else
            {
                this.MaBHXH = "";
            }

            if (dr["NgayCap_CCHN"].GetType().Name != "DBNull" && dr["NgayCap_CCHN"] != null)
            {
                this.NgayCap_CCHN = Convert.ToString(dr["NgayCap_CCHN"]);
            }
            else
            {
                this.NgayCap_CCHN = "";
            }
            if (dr["NgaySinh"].GetType().Name != "DBNull" && dr["NgaySinh"] != null)
            {
                this.NgaySinh = Convert.ToString(dr["NgaySinh"]);
            }
            else
            {
                this.NgaySinh = "";
            }
            if (dr["PhamVi_CM"].GetType().Name != "DBNull" && dr["PhamVi_CM"] != null)
            {
                this.PhamVi_CM = Convert.ToString(dr["PhamVi_CM"]);
            }
            else
            {
                this.PhamVi_CM = "";
            }

            if (dr["PhamVi_CMBS"].GetType().Name != "DBNull" && dr["PhamVi_CMBS"] != null)
            {
                this.PhamVi_CMBS = Convert.ToString(dr["PhamVi_CMBS"]);
            }
            else
            {
                this.PhamVi_CMBS = "";
            }



            if (dr["ThoiGian_Tuan"].GetType().Name != "DBNull" && dr["ThoiGian_Tuan"] != null)
            {
                this.ThoiGian_Tuan = Convert.ToString(dr["ThoiGian_Tuan"]);
            }
            else
            {
                this.ThoiGian_Tuan = "";
            }
            if (dr["ThoiGian_Ngay"].GetType().Name != "DBNull" && dr["ThoiGian_Ngay"] != null)
            {
                this.ThoiGian_Ngay = Convert.ToString(dr["ThoiGian_Ngay"]);
            }
            else
            {
                this.ThoiGian_Ngay = "";
            }


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
            //using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNhanVien_GetAll", true)))
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNhanVien_GetAll")))
            {
                while (dr.Read())
                {
                    List.Add(new DMNhanVienM(dr));
                }
            }
            return List;
        }
        //public static List<DMNhanVienM> FindDMNhanVienByFilter(String _DK, String _DKFilter, Boolean qadmin)
        //{
        //    List<DMNhanVienM> List = new List<DMNhanVienM>();
        //    using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNhanVienFilter_FindsM", _DK, _DKFilter, qadmin)))
        //    {
        //        while (dr.Read())
        //        {
        //            List.Add(new DMNhanVienM(dr));
        //        }
        //    }
        //    return List;
        //}
    }

}


