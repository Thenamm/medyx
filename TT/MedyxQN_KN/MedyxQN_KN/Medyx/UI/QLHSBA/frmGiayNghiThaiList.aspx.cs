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

public partial class UI_QLHSBA_frmGiayNghiThaiList : WebBase
{
    private const string ViewState_GiayNghiThaiList = "_GiayNghiThaiList";
    public DataTable _GiayNghiThaiList
   {
       get
       {
           if (ViewState[ViewState_GiayNghiThaiList] == null)
           {
               ViewState[ViewState_GiayNghiThaiList] = LoadData ();
           }

           return (DataTable)ViewState[ViewState_GiayNghiThaiList];
       }

       set
       {
           ViewState[ViewState_GiayNghiThaiList] = value;
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
                tuNgay = DateTime.Parse(dtTuNgay.Text.Trim());
            }
            catch (Exception)
            { }
        }

        if (dtDenNgay.Text != null && !String.IsNullOrEmpty(dtDenNgay.Text))
        {
            try
            {
                denNgay = DateTime.Parse(dtDenNgay.Text.Trim());
            }
            catch (Exception)
            { }
        }
        string dk = "";
        //if (txtMaBN.Text.Trim().Length > 0)
        //    dk = " and c.mabn=N'" + txtMaBN.Text.Trim() + "'";
        return spGiayNghiThaiList_GetAll(tuNgay, denNgay, cboKhoa.SelectedValue, dk);
        //return GiayNghiThaiList.GetAllGiayNghiThai(tuNgay, denNgay, cboKhoa.SelectedValue == "All" ? "" : cboKhoa.SelectedValue, chkNhanOng.Checked, true);
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
            //baraction.FindItemByValue("cmdAdd").Enabled = !_NhanOng;
            //chkNhanOng.Visible = true;
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
        grdDanhSach.DataSource = _GiayNghiThaiList;
        if(!NeedDataSource)
        {
            grdDanhSach.DataBind();
        }
        if(_GiayNghiThaiList.Rows.Count > 0)
        {
            _Selected_Ma = _GiayNghiThaiList.Rows[0]["MaBN"].ToString();
            LoadgrdChiTiet(_Selected_Ma, _GiayNghiThaiList.Rows[0]["MaBA"].ToString());
        }
    }
    public void LoadgrdChiTiet(String MaBN, String MaBA)
    {
        grdChiTiet.DataSource = spGiayNghiThai_GetListByMaBN(MaBN,MaBA);
        grdChiTiet.DataBind();
    }
    protected void grdDanhSach_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if ((e.CommandName == RadGrid.InitInsertCommandName))
        {
            Response.Redirect("~/UI/NoiTru/KhamBenh/frmGiayNghiThai.aspx?&MaKhoa=" + cboKhoa.SelectedValue);
        }

        else if ((e.CommandName == RadGrid.EditCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            _Selected_Ma = editedItem.GetDataKeyValue("MaBN").ToString();
            Response.Redirect("~/UI/NoiTru/KhamBenh/frmGiayNghiThai.aspx?MaBN=" + _Selected_Ma + "&MaKhoa=" + cboKhoa.SelectedValue + "&MaBA=" + editedItem.GetDataKeyValue("MaBA").ToString() + "&SoGiayNghiThai=0", false);

        }
        else if ((e.CommandName == RadGrid.DeleteCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            _Selected_Ma = editedItem.GetDataKeyValue("SoGiayNghiThai").ToString();
            decimal SoGiayNghiThai = 0;
            if (decimal.TryParse(_Selected_Ma, out SoGiayNghiThai))
                spGiayNghiThai_Delete(SoGiayNghiThai);
            //if (CheckXoa(_Selected_Ma, _NhanOng))
            //    GiayNghiThai.DeleteGiayNghiThai(_Selected_Ma, Pub_sMaMay, Pub_sNguoiSD);
            //else
            //    ShowMessage("Phiếu giao nhận này đã được nhận trả! Không thể xóa!");
            //_GiayNghiThaiList = null;

            LoadgrdDanhSach();
        }
        else if (e.CommandName == "ViewDetail")
        {
            if (e.CommandArgument.ToString() != "")
            {
                GridDataItem item = grdDanhSach.MasterTableView.Items[e.CommandArgument.ToString()] as GridDataItem;
                GridEditableItem editedItem = (GridEditableItem)(grdDanhSach.MasterTableView.Items[e.CommandArgument.ToString()] as GridEditableItem);
                if (_Selected_Ma == editedItem.GetDataKeyValue("MaBN").ToString())
                    Response.Redirect("~/UI/NoiTru/KhamBenh/frmGiayNghiThai.aspx?MaBN=" + _Selected_Ma + "&MaKhoa=" + cboKhoa.SelectedValue + "&MaBA=" + editedItem.GetDataKeyValue("MaBA").ToString());
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
    public void spGiayNghiThai_Delete(Decimal SoGiayNghiThai)
    {
        string tenStore = "spGiayNghiThai_Delete";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@SoGiayNghiThai", SoGiayNghiThai));
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
    public DataTable spGiayNghiThaiList_GetAll(DateTime TuNgay, DateTime DenNgay, String makhoa, string dk)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayNghiThaiList_GetAll";
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
    public DataTable spGiayNghiThai_GetListByMaBN(string MaBN, string MaBA)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayNghiThai_GetListByMaBN";
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
                    _GiayNghiThaiList = null;
                    LoadgrdDanhSach();
                    break;
                case "cmdFilter":
                    if (grdDanhSach.AllowFilteringByColumn == true)
                        grdDanhSach.AllowFilteringByColumn = false;
                    else
                        grdDanhSach.AllowFilteringByColumn = true;
                    LoadgrdDanhSach();
                    break;
                case "cmdExit":
                    Response.Redirect("~/Default.aspx");
                    break;
                default:
                    break;
            }
        }

    }
    protected void cboKhoa_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
    {
        _GiayNghiThaiList = null;
        LoadgrdDanhSach();
    }
    protected void odsKhoa_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["account"] = Pub_sAccount;
    }
    protected void grdChiTiet_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if ((e.CommandName == RadGrid.EditCommandName) && (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fSua))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            Response.Redirect("~/UI/NoiTru/KhamBenh/frmGiayNghiThai.aspx?MaBN=" + editedItem.GetDataKeyValue("MaBN").ToString() + "&MaKhoa=" + cboKhoa.SelectedValue + "&MaBA=" + editedItem.GetDataKeyValue("MaBA").ToString() + "&SoGiayNghiThai=" + editedItem.GetDataKeyValue("SoGiayNghiThai").ToString(), false);

        }
        else if ((e.CommandName == RadGrid.DeleteCommandName))
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            _Selected_Ma = editedItem.GetDataKeyValue("SoGiayNghiThai").ToString();
            decimal SoGiayNghiThai = 0;
            if (decimal.TryParse(_Selected_Ma, out SoGiayNghiThai))
                spGiayNghiThai_Delete(SoGiayNghiThai);
            //if (CheckXoa(_Selected_Ma, _NhanOng))
            //    GiayNghiThai.DeleteGiayNghiThai(_Selected_Ma, Pub_sMaMay, Pub_sNguoiSD);
            //else
            //    ShowMessage("Phiếu giao nhận này đã được nhận trả! Không thể xóa!");
            //_GiayNghiThaiList = null;

            LoadgrdDanhSach();
        }
    }
}