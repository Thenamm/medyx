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
//using static UI_Category_DMHanhChinh_frmDMDanToc;

public partial class UI_Category_DMHanhChinh_frmDMDanToc : HTC.Common.Web.WebBase
{
    private const string ViewState_DMDanTocList = "DMDanToc";


    public List<DMDanToc> DMDanTocList
    {
        get
        {
            if (ViewState[ViewState_DMDanTocList] == null)
            {
                ViewState[ViewState_DMDanTocList] = DMDanToc.GetDMDanToc();
            }

            return (List<DMDanToc>)ViewState[ViewState_DMDanTocList];
        }

        set
        {
            ViewState[ViewState_DMDanTocList] = value;
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
        grdChiTiet.DataSource = DMDanTocList;
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
        string MaDanToc = string.Empty;
        string TenDanToc = string.Empty;
        string MaQL = string.Empty;
        string MaBYTe = string.Empty;

        if (action != FormAction.INSERT)
        {
            MaDanToc = editedItem.GetDataKeyValue("MaDanToc").ToString();

        }



        
        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }
            MaDanToc = ((TextBox)editedItem["MaDanToc"].Controls[0]).Text;
            TenDanToc = ((TextBox)editedItem["TenDanToc"].Controls[0]).Text;
            MaQL = ((TextBox)editedItem["MaQL"].Controls[0]).Text;
            MaBYTe = ((TextBox)editedItem["MaBYTe"].Controls[0]).Text;

        }



        try
        {
            if (action == FormAction.EDIT)
            {
                //HTC.Business.DataProvider.Instance().UpdateDMNgheNghiep(maNN, tenNN, Pub_sMaMay, Pub_sNguoiSD);
                UpdateDMDanToc(MaDanToc, TenDanToc, MaQL, MaBYTe,  Pub_sMaMay,  Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {
                //HTC.Business.DataProvider.Instance().InsertDMNgheNghiep(tenNN, Pub_sMaMay, Pub_sNguoiSD);
                InsertDMDanToc(MaDanToc, TenDanToc, MaQL, MaBYTe, Pub_sMaMay, Pub_sNguoiSD);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMDanToc( Pub_sMaMay, Pub_sNguoiSD, MaDanToc);
                //HTC.Business.DataProvider.Instance().DeleteDMNgheNghiep(Pub_sMaMay, Pub_sNguoiSD, maBC);
            }

            ViewState[ViewState_DMDanTocList] = null;
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
        if (DMDanTocList != null)
        {
            grdChiTiet.DataSource = DMDanTocList;
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
    public String InsertDMDanToc(String _MaDanToc, String _TenDanToc, String _MaQL, String _MaBYTe, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanToc_CREATE", _MaDanToc, _TenDanToc, _MaQL, _MaBYTe, _maMay, _nguoiSD));
    }
    public void UpdateDMDanToc(String _MaDanToc, String _TenDanToc, String _MaQL, String _MaBYTe, string _maMay,  String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanToc_update", _MaDanToc, _TenDanToc, _MaQL, _MaBYTe,  _maMay, _nguoiSD);
    }

    public void DeleteDMDanToc(String _maMay, String _nguoiSD, String _MaDanToc)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanToc_DELETED",  _maMay, _nguoiSD, _MaDanToc);
    }
    [Serializable]
    public class DMDanToc
    {
        private String _MaDanToc = String.Empty;
        private String _TenDanToc = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _MaQL = String.Empty;
        private String _MaBYTe = String.Empty;
        private int _OrderNumber;
        public String MaDanToc
        {
            get
            {
                return _MaDanToc;
            }
            set
            {
                if (_MaDanToc != value)
                {
                    _MaDanToc = value;
                }
            }
        }

        public String TenDanToc
        {
            get
            {
                return _TenDanToc;
            }
            set
            {
                if (_TenDanToc != value)
                {
                    _TenDanToc = value;
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
        public String MaBYTe
        {
            get
            {
                return _MaBYTe;
            }
            set
            {
                if (_MaBYTe != value)
                {
                    _MaBYTe = value;
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
        public DMDanToc(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaDanToc"].GetType().Name != "DBNull" && dr["MaDanToc"] != null)
            {
                this.MaDanToc = Convert.ToString(dr["MaDanToc"]);
            }
            else
            {
                this.MaDanToc = "";
            }
            if (dr["TenDanToc"].GetType().Name != "DBNull" && dr["TenDanToc"] != null)
            {
                this.TenDanToc = Convert.ToString(dr["TenDanToc"]);
            }
            else
            {
                this.TenDanToc = "";
            }
            if (dr["MaQL"].GetType().Name != "DBNull" && dr["MaQL"] != null)
            {
                this.MaQL = Convert.ToString(dr["MaQL"]);
            }
            else
            {
                this.MaQL = "";
            }
            if (dr["MaBYTe"].GetType().Name != "DBNull" && dr["MaBYTe"] != null)
            {
                this.MaBYTe = Convert.ToString(dr["MaBYTe"]);
            }
            else
            {
                this.MaBYTe = "";
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
        public static List<DMDanToc> GetDMDanToc()
        {
            List<DMDanToc> List = new List<DMDanToc>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDanToc_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMDanToc(dr,i));
                }
            }
            return List;
        }
    }
}