using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using HTC.Business.PhongKham;

using HTC.Common.Web;
using Telerik.Web.UI;

public partial class UI_NoiTru_TiepDon_frmDangKyDS : WebBase
{

    private const string viewState_KhamBenhBAListInfo = "KhamBenhBAListInfo";
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

    public KhamBenhBAListInfo _KhamBenhBAListInfo
    {
        get
        {
            if (ViewState[viewState_KhamBenhBAListInfo] == null)
            {
                LoadData();
            }

            return (KhamBenhBAListInfo)ViewState[viewState_KhamBenhBAListInfo];
        }

        set
        {
            ViewState[viewState_KhamBenhBAListInfo] = value;
        }

    }

    #region var
    private const string ViewState_loaikq = "_loaikq";

    public string _loaikq
    {
        get
        {
            if (ViewState[ViewState_loaikq] == null)
            {
                ViewState[ViewState_loaikq] = "0";

            }

            return (string)ViewState[ViewState_loaikq];
        }

        set
        {
            ViewState[ViewState_loaikq] = value;
        }
    }
    private const string ViewState_loai = "_loai";
    public byte _loai
    {
        get
        {
            if (ViewState[ViewState_loai] == null)
            {
                if (Request["loai"] == null)
                    Response.Redirect("~/Default.aspx");
                else
                    ViewState[ViewState_loai] = Convert.ToByte(Request["loai"].ToString());
            }

            return (byte)ViewState[ViewState_loai];
        }

        set
        {
            ViewState[ViewState_loai] = value;
        }

    }

    private const string ViewState_loaicn = "_loaicn";
    public byte _loaicn
    {
        get
        {
            if (ViewState[ViewState_loaicn] == null)
            {
                if (Request["loaicn"] == null)
                    Response.Redirect("~/Default.aspx");
                else
                    ViewState[ViewState_loaicn] = Convert.ToByte(Request["loaicn"].ToString());
            }

            return (byte)ViewState[ViewState_loaicn];
        }


    }

    #endregion





    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_SACH_CHI_TIET;

            dtTuNgay.Text = DateTime.Now.ToString(ConfigurationManager.AppSettings["DateFormat"]);
            dtDenNgay.Text = DateTime.Now.ToString(ConfigurationManager.AppSettings["DateFormat"]);
            if (!string.IsNullOrEmpty(Request["loaikq"]))
            {
                _loaikq = Request["loaikq"].ToString();
                cboTrangThai.SelectedIndex = int.Parse(_loaikq);
                cboTrangThai.Enabled = false;
            }
            grdDanhSach.DataSource = "";
            LoadData();

        }

    }
    private void SetData()
    {
       
             
       
        cboKhoa.DataSource = HTC.Business.CategoryList.DMKhoaListcb.GetListAdd();
        cboKhoa.DataBind();

        cboDoiTuong.DataSourceID = "odsDoiTuong";
        cboDoiTuong.DataBind();
        cboTrangThai.DataSourceID = "odsTrangThai";
        cboTrangThai.DataBind();
       // ShowMessage((Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fSua).ToString ());
        if (Pub_bQuyenForm < HTC.ShareVariables.KieuFormChiTiet.fSua)
        {

            baraction.FindItemByValue("cmdAdd").Enabled = false;
        }

    }


    private void LoadData(Boolean _load = true, KhamBenhBAInfo _KhamBenhBAInfo = null)
    {
        try
        {
           
            if (cboKhoa.Items.Count == 0)
                SetData();
            if (!String.IsNullOrEmpty(cboKhoa.SelectedValue))
            {

                DateTime tuNgay = ConvertStringToDate(dtTuNgay.Text.Trim());
                DateTime denNgay = ConvertStringToDate(dtDenNgay.Text.Trim());
                string khoaId = cboKhoa.SelectedValue;
                string doiTuongId = cboDoiTuong.SelectedValue;
                string _loaikq = cboTrangThai.SelectedValue;
                
                if (_load == true)
                {
                    if (cboTrangThai.SelectedIndex == 0)
                        _KhamBenhBAListInfo = KhamBenhBAListInfo.GetKhamBenhBAListInfo(DateTime.Parse(dtTuNgay.Text), DateTime.Parse(dtDenNgay.Text), _loai, "", cboKhoa.SelectedValue, cboDoiTuong.SelectedValue, byte.Parse(_loaikq));
                    else
                        _KhamBenhBAListInfo = KhamBenhBAListInfo.GetKhamBenhBAListInfo(DateTime.Parse(dtTuNgay.Text), DateTime.Parse(dtDenNgay.Text), _loai, " and n.noitt='" + _NoiTT + "'", cboKhoa.SelectedValue, cboDoiTuong.SelectedValue, byte.Parse(_loaikq));
                }
                if (_KhamBenhBAInfo != null)
                    _KhamBenhBAListInfo.RemoveTo(_KhamBenhBAInfo);

                grdDanhSach.DataSource = _KhamBenhBAListInfo;
                grdDanhSach.DataBind();
                if (_KhamBenhBAListInfo.Count > 0)
                    grdDanhSach.MasterTableView.Items[0].Selected = true;


            }
        }
        catch (Exception ex)
        { }
    }

    protected void grdDanhSach_ItemCommand(object sender, GridCommandEventArgs e)
    {
        try
        {
            if (String.IsNullOrEmpty(e.CommandName))
            {
                Response.Redirect("~/Default.aspx");
            }
            else if (e.CommandName.Equals("edit", StringComparison.InvariantCultureIgnoreCase))
            {
                GridEditableItem _editedItem = e.Item as GridEditableItem;

                if (_editedItem != null)
                {
                    string _MaBA = _editedItem.GetDataKeyValue("MaBA").ToString();
                    string _MaBN = _editedItem.GetDataKeyValue("MaBN").ToString();
                    string _MaSoKham = _editedItem.GetDataKeyValue("MaSoKham").ToString();
                    int _STT = int.Parse(_editedItem.GetDataKeyValue("STT").ToString());
                    string _NgayVV = _editedItem["NgayVV"].Text.Substring(0, 10);

                    string _loaikq = cboTrangThai.SelectedValue;
                    if (!string.IsNullOrEmpty(_MaBA))
                    {
                        if (cboTrangThai.SelectedIndex == 0)
                            // Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&mabn=" + _MaBN + "&ngaydk=" + _NgayVV + "&maBA=" + _MaBA, false);
                            OpenWindow("frmBenhAnNoiTruPK.aspx?loai=" + _loai.ToString() + "&loaicn=" + _loaicn.ToString() + "&loaikq=" + _loaikq.ToString() + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&maBN=" + _MaBN + "&NgayDK=" + _NgayVV + "&maBA=" + _MaBA);

                        else
                            //  Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&mabn=" + _MaBN + "&ngaydk=" + _NgayVV + "&maBA=" + _MaBA, false);
                            OpenWindow("frmBenhAnNoiTruPK.aspx?loai=" + _loai.ToString() + "&loaicn=" + _loaicn.ToString() + "&loaikq=" + _loaikq.ToString() + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&maBN=" + _MaBN + "&NgayDK=" + _NgayVV + "&maBA=" + _MaBA);
                        int index = 0;

                        if (_KhamBenhBAListInfo.Count > 10 || _KhamBenhBAListInfo.Count == 1)
                        {
                            index = _editedItem.RowIndex - 2;

                            int OrderNumber = int.Parse(_editedItem["OrderNumber"].Text);
                            KhamBenhBAInfo _KhamBenhBAInfo = _KhamBenhBAListInfo.FirstOrDefault(X => X.OrderNumber == OrderNumber);
                            _KhamBenhBAListInfo.RemoveTo(_KhamBenhBAInfo);
                            grdDanhSach.DataSource = _KhamBenhBAListInfo;
                            grdDanhSach.DataBind();
                            if (index >= 0)
                            {
                                index = ((index >= _KhamBenhBAListInfo.Count) || (index < 1) ? 0 : index);
                            }
                        }
                        else
                        {
                            int OrderNumber = int.Parse(_editedItem["OrderNumber"].Text);
                            KhamBenhBAInfo KhamBenhBAInfo = _KhamBenhBAListInfo.FirstOrDefault(X => X.OrderNumber == OrderNumber);

                            LoadData(true, KhamBenhBAInfo);
                        }

                        if (grdDanhSach.MasterTableView.Items.Count > 0 && index >= 0) grdDanhSach.MasterTableView.Items[index].Selected = true;
                        e.Canceled = true;
                    }
                }
            }
            else if ((e.CommandName == "LoadDetails") && (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fSua))
            {
                if (e.Item != null)
                { }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("Không thực hiện được dữ liệu" + ex.Message);
        }    
    }

    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        try
        {
        if (((RadToolBarButton)e.Item).CommandName.Equals("cmdExit", StringComparison.InvariantCultureIgnoreCase))
        {
            Response.Redirect("~/Default.aspx");

        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdAdd", StringComparison.InvariantCultureIgnoreCase))
        {
            
            cboTrangThai.SelectedIndex = 0;
            string _loaikq = cboTrangThai.SelectedValue;
            // Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT, false);
            OpenWindow("frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT);

        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdView", StringComparison.InvariantCultureIgnoreCase))
        {
            LoadData();
        }
        else if (((RadToolBarButton)e.Item).CommandName.Equals("cmdFilter", StringComparison.InvariantCultureIgnoreCase))
        {
            grdDanhSach.AllowFilteringByColumn = !grdDanhSach.AllowFilteringByColumn;


            LoadData(false);


        }
        }
        catch (Exception ex)
        {
            ShowMessage("Không thực hiện được dữ liệu" + ex.Message);
            
        }    
    }

    protected void grdDanhSach_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
        if (_KhamBenhBAListInfo != null)
        {
            grdDanhSach.DataSource = _KhamBenhBAListInfo;
        }


    }

    protected void grdDanhSach_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    if (grdDanhSach.SelectedItems.Count > 0)
        //    {
        //        GridDataItem _editedItem = (GridDataItem)grdDanhSach.SelectedItems[0];

        //        if (_editedItem != null)
        //        {
        //            string _MaBA = _editedItem.GetDataKeyValue("MaBA").ToString();
        //            string _MaBN = _editedItem.GetDataKeyValue("MaBN").ToString();
        //            string _MaSoKham = _editedItem.GetDataKeyValue("MaSoKham").ToString();
        //            int _STT = int.Parse(_editedItem.GetDataKeyValue("STT").ToString());
        //            string _NgayVV = _editedItem["NgayVV"].Text.Substring(0, 10);

        //            string _loaikq = cboTrangThai.SelectedValue;

        //            if (!string.IsNullOrEmpty(_MaBA))
        //            {
        //                //if (cboTrangThai.SelectedIndex == 0)
        //                //    Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&mabn=" + _MaBN + "&ngaydk=" + _NgayVV + "&maBA=" + _MaBA, false);

        //                //else
        //                //    Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&mabn=" + _MaBN + "&ngaydk=" + _NgayVV + "&maBA=" + _MaBA, false);
        //                if (cboTrangThai.SelectedIndex == 0)
        //                    // Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&mabn=" + _MaBN + "&ngaydk=" + _NgayVV + "&maBA=" + _MaBA, false);
        //                    OpenWindow("frmBenhAnNoiTruPK.aspx?loai=" + _loai.ToString() + "&loaicn=" + _loaicn.ToString() + "&loaikq=" + _loaikq.ToString() + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&maBN=" + _MaBN + "&NgayDK=" + _NgayVV + "&maBA=" + _MaBA);

        //                else
        //                    //  Response.Redirect("~/UI/NoiTru/TiepDon/frmBenhAnNoiTruPK.aspx?loai=" + _loai + "&loaicn=" + _loaicn + "&loaikq=" + _loaikq + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&mabn=" + _MaBN + "&ngaydk=" + _NgayVV + "&maBA=" + _MaBA, false);
        //                    OpenWindow("frmBenhAnNoiTruPK.aspx?loai=" + _loai.ToString() + "&loaicn=" + _loaicn.ToString() + "&loaikq=" + _loaikq.ToString() + "&NoiTT=" + _NoiTT + "&STT=" + _STT + "&maBN=" + _MaBN + "&NgayDK=" + _NgayVV + "&maBA=" + _MaBA);
        //                int index = 0;
        //                index = _editedItem.RowIndex - 2;

        //                if (_KhamBenhBAListInfo.Count > 10 || _KhamBenhBAListInfo.Count == 1)
        //                {
        //                    int OrderNumber = int.Parse(_editedItem["OrderNumber"].Text);
        //                    KhamBenhBAInfo _KhamBenhBAInfo = _KhamBenhBAListInfo.FirstOrDefault(X => X.OrderNumber == OrderNumber);
        //                    _KhamBenhBAListInfo.RemoveTo(_KhamBenhBAInfo);
        //                    grdDanhSach.DataSource = _KhamBenhBAListInfo;
        //                    grdDanhSach.DataBind();
        //                    if (index >= 0)
        //                    {
        //                        index = ((index >= _KhamBenhBAListInfo.Count) || (index < 1) ? 0 : index);
        //                    }
        //                    Myformulas["NguoiKy"].Text = "'"+ cboNhanVien.Text +"'"; 
                      
        //                }
        //                else
        //                {
        //                    int OrderNumber = int.Parse(_editedItem["OrderNumber"].Text);
        //                    KhamBenhBAInfo KhamBenhBAInfo = _KhamBenhBAListInfo.FirstOrDefault(X => X.OrderNumber == OrderNumber);

        //                    LoadData(true, KhamBenhBAInfo);
        //                }
        //            }
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    HandleException(ex, FormAction.OTHERS);
        //}

    }
    protected void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadData();
    }
    protected void odsKhoa_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters["account"] = Pub_sAccount;
    }
}