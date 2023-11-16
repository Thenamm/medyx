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

public partial class UI_QLHSBA_frmGiayChungSinhList : WebBase
{
    private const string ViewState_GiayChungSinhList = "_GiayChungSinhList";
    public DataTable _GiayChungSinhList
    {
       get
       {
           if (ViewState[ViewState_GiayChungSinhList] == null)
           {
               ViewState[ViewState_GiayChungSinhList] = LoadData ();
           }

           return (DataTable)ViewState[ViewState_GiayChungSinhList];
       }

       set
       {
           ViewState[ViewState_GiayChungSinhList] = value;
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
    private DataTable LoadData()
    {
        grdChiTiet.DataSource = null;
        grdChiTiet.DataBind();
        DateTime tuNgay = DateTime.Now;
        DateTime denNgay = DateTime.Now;

        if (dtTuNgay.Text != null && !String.IsNullOrEmpty(dtTuNgay.Text))
        {
            try
            {
                tuNgay = DateTime.ParseExact(dtTuNgay.Text.Trim(), "dd/MM/yyyy", null);
            }
            catch (Exception)
            { }
        }

        if (dtDenNgay.Text != null && !String.IsNullOrEmpty(dtDenNgay.Text))
        {
            try
            {
                denNgay = DateTime.ParseExact(dtDenNgay.Text.Trim(), "dd/MM/yyyy", null);
            }
            catch (Exception)
            { }
        }
        string dk = "";
        //if (txtMaBN.Text.Trim().Length > 0)
        //    dk = " and c.mabn=N'" + txtMaBN.Text.Trim() + "'";
        return spGiayChungSinhList_GetAll(tuNgay, denNgay, cboKhoa.SelectedValue, dk);

        //return GiayBaoTuList.GetAllGiayBaoTu(tuNgay, denNgay, cboKhoa.SelectedValue == "All" ? "" : cboKhoa.SelectedValue, chkNhanOng.Checked, true);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_SACH_CHI_TIET;
            base.Page_PreLoad(sender, e);
            SetData();
        }   
    }
    private void SetData()
    {
        //if (Pub_bQuyenForm != HTC.ShareVariables.KieuFormChiTiet.fDelete)
        //{
        //    grdDanhSach.MasterTableView.GetColumn("Delete").Display = false;
        //}
        //if (_NhanOng)
        //{
        //    baraction.FindItemByValue("cmdAdd").Enabled = !_NhanOng;
        //    chkNhanOng.Visible = true;
        //}
        //if (pub_bQadmin == false)
        //{
        //    grdDanhSach.MasterTableView.GetColumn("Huy").Display = false;
        //}
        string thang = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
        string ngay = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

        dtDenNgay.Text = ngay + "/" + thang + "/" + DateTime.Now.Year.ToString();
        dtTuNgay.Text = "01" + "/" + thang + "/" + DateTime.Now.Year.ToString();
        LoadgrdDanhSach();
    }
    public void LoadgrdDanhSach(Boolean NeedDataSource = false)
    {
        grdDanhSach.DataSource = _GiayChungSinhList;
        if(!NeedDataSource)
        {
            grdDanhSach.DataBind();
        }
        if(_GiayChungSinhList.Rows.Count > 0)
        {
            _Selected_Ma = _GiayChungSinhList.Rows[0]["MaBN"].ToString();
            LoadgrdChiTiet(_Selected_Ma, _GiayChungSinhList.Rows[0]["MaBA"].ToString());
        }
    }
    public void LoadgrdChiTiet(String MaBN, String MaBA)
    {
        grdChiTiet.DataSource = spGiayChungSinh_GetListByMaBN(MaBN,MaBA);
        grdChiTiet.DataBind();
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
    protected void grdDanhSach_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if ((e.CommandName == RadGrid.InitInsertCommandName))
        {
            Response.Redirect("~/UI/QLHSBA/frmGiayChungSinh.aspx.aspx?&MaKhoa=" + cboKhoa.SelectedValue);
        }

        else if ((e.CommandName == RadGrid.EditCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            _Selected_Ma = editedItem.GetDataKeyValue("MaBN").ToString();
            Response.Redirect("~/UI/QLHSBA/frmGiayChungSinh.aspx?MaBN=" + _Selected_Ma + "&MaKhoa=" + cboKhoa.SelectedValue + "&MaBA=" + editedItem.GetDataKeyValue("MaBA").ToString(), false);

        }
        else if ((e.CommandName == RadGrid.DeleteCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            _Selected_Ma = editedItem.GetDataKeyValue("SoGiayChungSinh").ToString();
            decimal SoGiayChungSinh = 0;
            if (decimal.TryParse(_Selected_Ma, out SoGiayChungSinh))
                spGiayChungSinh_Delete(SoGiayChungSinh);

            //_Selected_Ma = editedItem.GetDataKeyValue("MaPhieuGNBP").ToString();
            //spMau_PhieuGNBPLS_Delete(_Selected_Ma);
            //if (CheckXoa(_Selected_Ma, _NhanOng))
            //    GiayBaoTu.DeleteGiayBaoTu(_Selected_Ma, Pub_sMaMay, Pub_sNguoiSD);
            //else
            //    ShowMessage("Phiếu giao nhận này đã được nhận trả! Không thể xóa!");
            //_GiayBaoTuList = null;

            LoadgrdDanhSach();
        }
        else if (e.CommandName == "ViewDetail")
        {
            if (e.CommandArgument.ToString() != "")
            {
                GridDataItem item = grdDanhSach.MasterTableView.Items[e.CommandArgument.ToString()] as GridDataItem;
                GridEditableItem editedItem = (GridEditableItem)(grdDanhSach.MasterTableView.Items[e.CommandArgument.ToString()] as GridEditableItem);
                if (_Selected_Ma == editedItem.GetDataKeyValue("MaBN").ToString())
                    Response.Redirect("~/UI/QLHSBA/frmGiayChungSinh.aspx?MaBN=" + _Selected_Ma + "&MaKhoa=" + cboKhoa.SelectedValue + "&MaBA=" + editedItem.GetDataKeyValue("MaBA").ToString());
                else
                {
                    _Selected_Ma = editedItem.GetDataKeyValue("MaBN").ToString();
                    LoadgrdChiTiet(_Selected_Ma, editedItem.GetDataKeyValue("MaBA").ToString());
                    grdDanhSach.MasterTableView.Items[editedItem.ItemIndex].Selected = true;
                }
            }
        }
        else if (e.CommandName == "FiterMaster")
        {
            if (grdDanhSach.AllowFilteringByColumn == true)
                grdDanhSach.AllowFilteringByColumn = false;
            else
                grdDanhSach.AllowFilteringByColumn = true;
            grdDanhSach.DataBind();
        }
    }


    //public void spMau_PhieuGNBPLS_Delete(String MaPhieuGNBPLS)
    //{
    //    string tenStore = "spMau_PhieuGNBPLS_Delete";
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@maPhieuGNBP", MaPhieuGNBPLS));
    //            Command.Parameters.Add(new SqlParameter("@NguoiSD", Pub_sNguoiSD));
    //            Command.Parameters.Add(new SqlParameter("@maPhieuGNBP", MaPhieuGNBPLS));
    //            Command.ExecuteNonQuery();
    //        }
    //        //if (dr.Rows.Count == 0)
    //        //    return "";
    //        //else
    //        //    return dr.Rows[0][0].ToString();
    //        //return dr;
    //    }
    //}
    public DataTable spGiayChungSinhList_GetAll(DateTime TuNgay, DateTime DenNgay, String makhoa, string dk)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayChungSinhList_GetAll";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@makhoa", makhoa));
                Command.Parameters.Add(new SqlParameter("@TuNgay", TuNgay));
                Command.Parameters.Add(new SqlParameter("@DenNgay", DenNgay));
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
    }
    public DataTable spGiayChungSinh_GetListByMaBN(string MaBN, string MaBA)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayChungSinh_GetListByMaBN";
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

    public void spGiayChungSinh_Delete(Decimal SoGiayChungSinh)
    {
        string tenStore = "spGiayChungSinh_Delete";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@SoGiayChungSinh", SoGiayChungSinh));
                Command.Parameters.Add(new SqlParameter("@NguoiSD", Pub_sNguoiSD));
                Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                Command.ExecuteNonQuery();
            }
            //if (dr.Rows.Count == 0)
            //    return "";
            //else
            //    return dr.Rows[0][0].ToString();
            //return dr;
        }
    }



    //public static DataTable GetBC(string dk, string loai)
    //{
    //    DataTable dr = new DataTable();
    //    string tenStore = "spMau_XetNghiem_BCKQ";
    //    string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
    //    using (SqlConnection Conection = new SqlConnection(StrConection))
    //    {
    //        Conection.Open();
    //        using (SqlCommand Command = new SqlCommand(tenStore, Conection))
    //        {
    //            Command.CommandType = CommandType.StoredProcedure;
    //            Command.Parameters.Add(new SqlParameter("@loai", loai));
    //            Command.Parameters.Add(new SqlParameter("@DK", dk));
    //            SqlDataAdapter dp = new SqlDataAdapter(Command);
    //            dp.Fill(dr);
    //        }
    //        //if (dr.Rows.Count > 0)
    //        return dr;
    //        //else
    //        //    return "";
    //    }
    //}
    protected void grdDanhSach_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
        LoadgrdDanhSach(true);
    }
    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        if (e.Item.Visible == true && e.Item.Enabled == true)
        {
            switch (e.Item.Value)
            {
                //case "cmdAdd":
                //    Response.Redirect("~/UI/ChePhamMau/ChePhamMau/FrmNhanChiDinhLS.aspx?NhanOng="+_NhanOng.ToString()+"&MaKhoa="+cboKhoa.SelectedValue);
                //    break;
                case "cmdView":
                    _GiayChungSinhList = null;
                    LoadgrdDanhSach();
                    break;
                case "cmdFilter":
                    if (grdDanhSach.AllowFilteringByColumn == true)
                        grdDanhSach.AllowFilteringByColumn = false;
                    else
                        grdDanhSach.AllowFilteringByColumn = true;
                    LoadgrdDanhSach();
                    break;
                //case "cmdPrintThieuGiay":
                //    PrintData();
                //    break;
                case "cmdExit":
                    Response.Redirect("~/Default.aspx");
                    break;
                default:
                    break;
            }
        }

    }
    //public void PrintData()
    //{
    //    DateTime d;
    //    if (cboKhoa.SelectedValue == "")
    //    {
    //        ShowMessage("Chưa chọn khoa nhận mẫu bệnh phẩm!");
    //        cboKhoa.Focus();
    //    }
    //    else if (string.IsNullOrEmpty(dtTuNgay.Text))
    //    {
    //        ShowMessage("Chưa chọn từ ngày chỉ định xét nghiệm nhận mẫu bệnh phẩm!");
    //        dtTuNgay.Focus();
    //    }
    //    else if (!string.IsNullOrEmpty(dtTuNgay.Text) && !DateTime.TryParse(dtTuNgay.Text, out d))
    //    {
    //        ShowMessage("Từ ngày chỉ định xét nghiệm nhận mẫu bệnh phẩm không hợp lệ!");
    //        dtTuNgay.Text = "";
    //        dtTuNgay.Focus();
    //    }
    //    else if (string.IsNullOrEmpty(dtTuNgay.Text))
    //    {
    //        ShowMessage("Chưa chọn đến ngày chỉ định xét nghiệm nhận mẫu bệnh phẩm!");
    //        dtTuNgay.Focus();
    //    }
    //    else if (!string.IsNullOrEmpty(dtTuNgay.Text) && !DateTime.TryParse(dtTuNgay.Text, out d))
    //    {
    //        ShowMessage("Đến ngày chỉ định xét nghiệm nhận mẫu bệnh phẩm không hợp lệ!");
    //        dtTuNgay.Text = "";
    //        dtTuNgay.Focus();
    //    }
    //    else
    //    {
    //        string sPath = Request.ApplicationPath + "/UI/ChePhamMau/Reports/CRPhieuGiaoNhanBP.rpt";
    //        string dk = "";
    //        string tk = "PGNO";
    //        DateTime tungay = DateTime.Parse(dtTuNgay.Text);
    //        DateTime denngay = DateTime.Parse(dtDenNgay.Text);
    //        dk = " and a.MaKhoaCD='" + cboKhoa.SelectedValue + "'";
    //        dk += " and d.MaPhieuGNBP is null AND ISNULL(A.SLMUA,0) - ISNULL(A.SLTRA,0) > 0 and isnull(a.dalaymau,0)= 1 ";
    //        dk += " and datediff(day, a.NgayDK, '" + tungay.ToString("yyyy-MM-dd HH:mm:ss") + "')<=0 and datediff(day, a.NgayDK, '" + denngay.ToString("yyyy-MM-dd HH:mm:ss") + "')>=0";
    //        DataTable dt = GetBC(dk, tk);
    //        if (dt.Rows.Count > 0)
    //        {
    //            ReportDocument rpt = new ReportDocument();
    //            rpt.Load(Server.MapPath(sPath));
    //            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
    //            Myformulas["TenDVCQ"].Text = "'" + HTC.ShareVariables.pub_sTenBV + "'";
    //            Myformulas["TenDV"].Text = "'KHOA HUYẾT THANH HỌC NHÓM MÁU'";
    //            Myformulas["TenKhoa"].Text = "'" + cboKhoa.Text + "'";
    //            Myformulas["NguoiBC"].Text = "'" + Pub_sTenNguoiSD + "'";
    //            Myformulas["TenBC"].Text = "'DANH SÁCH XÉT NGHIỆM CHƯA NHẬN PHIẾU XÉT NGHIỆM'";
    //            rpt.SetDataSource(dt);
    //            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
    //        }
    //        else
    //        {
    //            ShowMessage("Không có dữ liệu để hiển thị!");
    //        }
    //    }
    //}
    protected void cboKhoa_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        _GiayChungSinhList = null;
        LoadgrdDanhSach();
    }
    protected void odsKhoa_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["account"] = Pub_sAccount;
    }
    protected void grdChiTiet_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if ((e.CommandName == RadGrid.EditCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            Response.Redirect("~/UI/QLHSBA/frmGiayChungSinh.aspx?MaBN=" + editedItem.GetDataKeyValue("MaBN").ToString() + "&MaKhoa=" + cboKhoa.SelectedValue + "&MaBA=" + editedItem.GetDataKeyValue("MaBA").ToString() + "&SoGiayChungSinh=" + editedItem.GetDataKeyValue("SoGiayChungSinh").ToString(), false);

        }

        else if ((e.CommandName == RadGrid.DeleteCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            _Selected_Ma = editedItem.GetDataKeyValue("SoGiayChungSinh").ToString();
            decimal SoGiayChungSinh = 0;
            if (decimal.TryParse(_Selected_Ma, out SoGiayChungSinh))
                spGiayChungSinh_Delete(SoGiayChungSinh);

            //if (CheckXoa(_Selected_Ma, _NhanOng))
            //    GiayNghiThai.DeleteGiayNghiThai(_Selected_Ma, Pub_sMaMay, Pub_sNguoiSD);
            //else
            //    ShowMessage("Phiếu giao nhận này đã được nhận trả! Không thể xóa!");
            //_GiayNghiThaiList = null;

            LoadgrdDanhSach();
        }
    }


}