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
using Microsoft.Office.Interop.Word;

public partial class UI_Category_DMHanhChinh_frmDMNguyenNhanCapCuu : HTC.Common.Web.WebBase
{
    private const string ViewState_DMNguyenNhanCapCuuList = "DMNguyenNhanCapCuu ";


    public List<DMNguyenNhanCapCuu> DMNguyenNhanCapCuuList
    {
        get
        {
            if (ViewState[ViewState_DMNguyenNhanCapCuuList] == null)
            {
                ViewState[ViewState_DMNguyenNhanCapCuuList] = DMNguyenNhanCapCuu.GetDMNguyenNhanCapCuu();
            }

            return (List<DMNguyenNhanCapCuu>)ViewState[ViewState_DMNguyenNhanCapCuuList];
        }

        set
        {
            ViewState[ViewState_DMNguyenNhanCapCuuList] = value;
        }

    }
    

    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;   LoadData();
        }
        //if (pub_bQadmin == false)
        //    grdChiTiet.MasterTableView.GetColumn("Huy").Display = false;
    }

    private void LoadData()
    {
        grdChiTiet.DataSource = DMNguyenNhanCapCuuList;
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
        string manncapcuu = string.Empty;
        if (action != FormAction.INSERT)
        {
            manncapcuu = editedItem.GetDataKeyValue("manncapcuu").ToString();
        }

        string nguyennhancc = string.Empty;
        string MaBH = string.Empty;
        string TenBH = string.Empty;
        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }
            manncapcuu = ((TextBox)editedItem["manncapcuu"].Controls[0]).Text;
            nguyennhancc = ((TextBox)editedItem["nguyennhancc"].Controls[0]).Text;
            MaBH = ((TextBox)editedItem["MaBH"].Controls[0]).Text;
            TenBH = ((TextBox)editedItem["TenBH"].Controls[0]).Text;
        }



        try
        {
            if (action == FormAction.EDIT)
            {
                
                UpdateDMNguyenNhanCapCuu(manncapcuu, nguyennhancc, TenBH, MaBH);

            }
            else if (action == FormAction.INSERT)
            {
                
                InsertDMNguyenNhanCapCuu(manncapcuu, nguyennhancc, MaBH, TenBH);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMNguyenNhanCapCuu(manncapcuu, nguyennhancc, TenBH, MaBH);
               
            }

            ViewState[ViewState_DMNguyenNhanCapCuuList] = null;
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
        if (DMNguyenNhanCapCuuList != null)
        {
            grdChiTiet.DataSource = DMNguyenNhanCapCuuList;
        }
    }

 
    public String InsertDMNguyenNhanCapCuu(String _manncapcuu, String _nguyennhancc, String _MaBH, string _TenBH)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNNCapCuu_CREATE", _manncapcuu, _nguyennhancc, _MaBH, _TenBH));
    }
    public void UpdateDMNguyenNhanCapCuu(String _manncapcuu, String _nguyennhancc, String _MaBH, string _TenBH)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNNCapCuu_update", _manncapcuu, _nguyennhancc, _MaBH, _TenBH);
    }

    public void DeleteDMNguyenNhanCapCuu(String _manncapcuu, String _nguyennhancc, String _MaBH, string _TenBH)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNNCapCuu_DELETED", _manncapcuu, _nguyennhancc, _MaBH, _TenBH);
    }
    [Serializable]
    public class DMNguyenNhanCapCuu
    {
        private String _manncapcuu = String.Empty;
        private String _nguyennhancc = String.Empty;
        private String _MaBH = String.Empty;
        private String _TenBH = String.Empty;
        private int _OrderNumber;
        public String manncapcuu
        {
            get
            {
                return _manncapcuu;
            }
            set
            {
                if (_manncapcuu != value)
                {
                    _manncapcuu = value;
                }
            }
        }

        public String nguyennhancc
        {
            get
            {
                return _nguyennhancc;
            }
            set
            {
                if (_nguyennhancc != value)
                {
                    _nguyennhancc = value;
                }
            }
        }


        public String TenBH
        {
            get
            {
                return _TenBH;
            }
            set
            {
                if (_TenBH != value)
                {
                    _TenBH = value;
                }
            }
        }

        public String MaBH
        {
            get
            {
                return _MaBH;
            }
            set
            {
                if (_MaBH != value)
                {
                    _MaBH = value;
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
        public DMNguyenNhanCapCuu(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["manncapcuu"].GetType().Name != "DBNull" && dr["manncapcuu"] != null)
            {
                this.manncapcuu = Convert.ToString(dr["manncapcuu"]);
            }
            else
            {
                this.manncapcuu = "";
            }
            if (dr["nguyennhancc"].GetType().Name != "DBNull" && dr["nguyennhancc"] != null)
            {
                this.nguyennhancc = Convert.ToString(dr["nguyennhancc"]);
            }
            else
            {
                this.nguyennhancc = "";
            }
            if (dr["TenBH"].GetType().Name != "DBNull" && dr["TenBH"] != null)
            {
                this.TenBH = Convert.ToString(dr["TenBH"]);
            }
            else
            {
                this.TenBH = "";
            }
            if (dr["MaBH"].GetType().Name != "DBNull" && dr["MaBH"] != null)
            {
                this.MaBH = Convert.ToString(dr["MaBH"]);
            }
            else
            {
                this.MaBH = "";
            }
        }
        private static string ConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            }
        }
        public static List<DMNguyenNhanCapCuu> GetDMNguyenNhanCapCuu()
        {
            List<DMNguyenNhanCapCuu> List = new List<DMNguyenNhanCapCuu>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNNCapCuu_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMNguyenNhanCapCuu(dr,i));
                }
            }
            return List;
        }
    }
}