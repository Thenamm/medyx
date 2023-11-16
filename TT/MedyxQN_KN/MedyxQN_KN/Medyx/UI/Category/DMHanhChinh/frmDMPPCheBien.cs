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
using System.Globalization;
using System.ServiceModel;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using Csla;
using Csla.Data;
using System.Data;

public partial class UI_Category_DMHanhChinh_frmDMPPCheBien : HTC.Common.Web.WebBase
{
    private const string ViewState_DMPHUONGPHAPCHEBIENList = "DMPHUONGPHAPCHEBIEN";


    public List<DMPPCheBien> DMPPCheBienList
    {
        get
        {
            if (ViewState[ViewState_DMPHUONGPHAPCHEBIENList] == null)
            {
                ViewState[ViewState_DMPHUONGPHAPCHEBIENList] = DMPPCheBien.GetDMPPCheBien();
            }

            return (List<DMPPCheBien>)ViewState[ViewState_DMPHUONGPHAPCHEBIENList];
        }

        set
        {
            ViewState[ViewState_DMPHUONGPHAPCHEBIENList] = value;
        }

    }
    

    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;   LoadData();
        }
        if (pub_bQadmin == false)
            grdChiTiet.MasterTableView.GetColumn("Huy").Display = false;
    }

    private void LoadData()
    {
        grdChiTiet.DataSource = DMPPCheBienList;
        grdChiTiet.DataBind();
    }

    protected void grdChiTiet_DeletedCommand(object sender, GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;

            if (editedItem != null)
            {

                //string _maBC = editedItem.GetDataKeyValue("MaBC").ToString();
                

                if (UpdateData(editedItem, FormAction.DELETE) == true)
                {
                    ShowMessage(MessageType.SUCCESS, FormAction.DELETE);
                }
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
                if (UpdateData(editedItem, FormAction.EDIT) == true)
                {
                    ShowMessage(MessageType.SUCCESS, FormAction.EDIT);
                }
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

            if (UpdateData(editedItem, FormAction.INSERT) == true)
            {
                ShowMessage(MessageType.SUCCESS, FormAction.INSERT);
            }
        }
        catch (Exception ex)
        {
            HandleException(ex, FormAction.INSERT);

            ShowMessage(MessageType.ERROR, FormAction.INSERT);
        }

        e.Canceled = true;
    }

    protected bool UpdateData(GridEditableItem editedItem, FormAction action)
    {
        string MaPPCB = string.Empty;
        string TenPPCB = string.Empty;
        string MaBHXH = string.Empty;
        string TenNhom = string.Empty;
        if (action != FormAction.INSERT)
        {
            MaPPCB = editedItem.GetDataKeyValue("MaPPCB").ToString();

        }


        //string TenPPCB = string.Empty;
        //string MaBHXH = string.Empty;
        //string TenNhom = string.Empty;
        
        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }
            MaPPCB = ((TextBox)editedItem["MaPPCB"].Controls[0]).Text;
            TenPPCB = ((TextBox)editedItem["TenPPCB"].Controls[0]).Text;
            MaBHXH = ((TextBox)editedItem["MaBHXH"].Controls[0]).Text;
            TenNhom = ((TextBox)editedItem["TenNhom"].Controls[0]).Text;
           
        }



        try
        {
            if (action == FormAction.EDIT)
            {
                //HTC.Business.DataProvider.Instance().UpdateDMNgheNghiep(maNN, tenNN, Pub_sMaMay, Pub_sNguoiSD);
                UpdateDMPPCheBien ( MaPPCB, TenPPCB, MaBHXH,  Pub_sMaMay,  Pub_sNguoiSD, TenNhom);

            }
            else if (action == FormAction.INSERT)
            {
                //HTC.Business.DataProvider.Instance().InsertDMNgheNghiep(tenNN, Pub_sMaMay, Pub_sNguoiSD);
                InsertDMPPCheBien(MaPPCB, TenPPCB, MaBHXH, Pub_sMaMay, Pub_sNguoiSD, TenNhom);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMPPCheBien( Pub_sMaMay, Pub_sNguoiSD,MaPPCB);
                //HTC.Business.DataProvider.Instance().DeleteDMNgheNghiep(Pub_sMaMay, Pub_sNguoiSD, maBC);
            }

            ViewState[ViewState_DMPHUONGPHAPCHEBIENList] = null;
            grdChiTiet.EditIndexes.Clear();
            grdChiTiet.MasterTableView.Rebind();
            grdChiTiet.Rebind();

        }
        catch (Exception ex)
        {
            HandleException(ex, action);

            //throw;
        }

        return true;
    }

    private bool ValidateForm(GridEditableItem editedItem)
    {
        return true;
    }

    protected void grdChiTiet_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridEditableItem && e.Item.IsInEditMode)
        {
            GridEditableItem form = (GridEditableItem)e.Item;
            if (pub_bQadmin == true)
                if (form["Huy"].Text == "false")
                {
                    GridEditManager editMan = form.EditManager;
                    GridCheckBoxColumn ctlColumnWorkflow = editMan.GetColumnEditor("Huy") as GridCheckBoxColumn;
                    ctlColumnWorkflow.ReadOnly = true;
                }
            if (form.ItemIndex == -1)
            {
                if (grdChiTiet.EditItems.Count > 0)
                    e.Item.FireCommandEvent(RadGrid.CancelCommandName, string.Empty);
            }

        }
    }
    protected void grdChiTiet_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if (String.IsNullOrEmpty(e.CommandName))
        {
            Response.Redirect("~/Default.aspx");
        }
          else if (e.CommandName == RadGrid.EditCommandName || e.CommandName == RadGrid.InitInsertCommandName)
        {

            grdChiTiet.MasterTableView.IsItemInserted = false;
            grdChiTiet.EditIndexes.Clear();
            grdChiTiet.DataBind();

        }
        else if (e.CommandName == RadGrid.RebindGridCommandName)
        {
            //  Response.Redirect(referencepage);
            //RadAjaxManager1.ResponseScripts.Add("window.history.back(-1);");                
        }
    }

    protected void grdChiTiet_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
    {
        if (DMPPCheBienList != null)
        {
            grdChiTiet.DataSource = DMPPCheBienList;
        }
    }

    /*
    [OperationContract]
    public RadListBoxItemData[] LoadQuocGiaList(Dictionary<string, object> context)
    {        
        var quocGiaList = (from quocGia in DMNgheNghiepList
                            orderby quocGia.tenNN
                            select new RadListBoxItemData
                            {
                                Text = quocGia.tenNN
                            }).Distinct();

        return quocGiaList.ToArray<RadListBoxItemData>();
    }*/
    public String InsertDMPPCheBien(String _MaPPCB, String _TenPPCB, String MaBHXH,   string _maMay, String _nguoiSD,String TenNhom)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMPHUONGPHAPCHEBIEN_CREATE", _MaPPCB,  _TenPPCB, MaBHXH, _maMay ,_nguoiSD , TenNhom));
    }
    public void UpdateDMPPCheBien(String _MaPPCB, String _TenPPCB, String MaBHXH, string _maMay, String TenNhom, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMPHUONGPHAPCHEBIEN_update", _MaPPCB, _TenPPCB, MaBHXH, _maMay, TenNhom, _nguoiSD);
    }

    public void DeleteDMPPCheBien(String _maMay, String _nguoiSD, String _MaPPCB)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMPHUONGPHAPCHEBIEN_DELETED",  _maMay, _nguoiSD,_MaPPCB);
    }
    [Serializable]
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
            set {
                DateTime d;
                
                if (DateTime.TryParseExact(value,"yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture,
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
                this.Huy =false;
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
        public static List<DMPPCheBien> GetDMPPCheBien()
        {
            List<DMPPCheBien> List = new List<DMPPCheBien>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMPHUONGPHAPCHEBIEN_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMPPCheBien(dr,i));
                }
            }
            return List;
        }
    }
}