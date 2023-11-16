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
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;

public partial class UI_Category_DMHanhChinh_frmDMChucVu : HTC.Common.Web.WebBase
{
    //private const string ViewState_DMChucVuList = "DMChucVu";


    //public DMChucVuList DMChucVuList
    //{
    //    get
    //    {
    //        if (ViewState[ViewState_DMChucVuList] == null)
    //        {
    //            ViewState[ViewState_DMChucVuList] = DMChucVuList.GetAllDMChucVu();
    //        }
    //        return (DMChucVuList)ViewState[ViewState_DMChucVuList];
    //    }

    //    set
    //    {
    //        ViewState[ViewState_DMChucVuList] = value;
    //    }

    //}


    private const string ViewState_DMChucVuList = "DMChucVuM";
    public List<DMChucVuM> DMChucVuList
    {
        get
        {
            if (ViewState[ViewState_DMChucVuList] == null)
            {
                ViewState[ViewState_DMChucVuList] = DMChucVuM.GetDMChucVuM();
            }

            return (List<DMChucVuM>)ViewState[ViewState_DMChucVuList];
        }

        set
        {
            ViewState[ViewState_DMChucVuList] = value;
        }

    }


    public string MaChucVu { get; set; }

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
        grdChiTiet.DataSource = DMChucVuList;
        grdChiTiet.DataBind();
    }

    protected void grdChiTiet_DeletedCommand(object sender, GridCommandEventArgs e)
    {
        try
        {                        
            GridEditableItem editedItem = e.Item as GridEditableItem;

            if (editedItem != null)
            {
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

    //protected bool UpdateData(GridEditableItem editedItem, FormAction action)
    //{
    //    string maCV = string.Empty;
    //    if (action != FormAction.INSERT)
    //    {
    //        maCV = editedItem.GetDataKeyValue("MaCV").ToString();
    //    }                

    //    string tenCV = string.Empty;
    //    //Thêm trường
    //  // string GhiChu = string.Empty;
    //    if (action != FormAction.DELETE)
    //    {
    //        if (ValidateForm(editedItem) == false)
    //        {
    //            return false;
    //        }

    //        tenCV = ((TextBox)editedItem["TenCV"].Controls[0]).Text;
    //        //Thêm trường
    //       // GhiChu = ((TextBox)editedItem["GhiChu"].Controls[0]).Text;
    //       //DMChucVuList.GetAllDMChucVu()[0].TenCV 

    //    }

    //    bool isHuy = false;
    //    if (action == FormAction.EDIT)
    //    {
    //        isHuy = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
    //    }

    //    try 
    // {	        		                 
    //        if (action == FormAction.EDIT)
    //        {
    //            HTC.Business.DataProvider.Instance().UpdateDMChucVu(maCV, tenCV, Pub_sMaMay, Pub_sNguoiSD);

    //            if (isHuy)
    //            {
    //                HTC.Business.DataProvider.Instance().DeleteDMChucVu(Pub_sMaMay, Pub_sNguoiSD, maCV);
    //            }
    //        }
    //        else if (action == FormAction.INSERT)
    //        {
    //            HTC.Business.DataProvider.Instance().InsertDMChucVu(tenCV, Pub_sMaMay, Pub_sNguoiSD);                                        
    //        }
    //        else if (action == FormAction.DELETE)
    //        {
    //            HTC.Business.DataProvider.Instance().DeleteDMChucVu(Pub_sMaMay, Pub_sNguoiSD, maCV);
    //        }

    //        ViewState[ViewState_DMChucVuList] = null;
    //        grdChiTiet.EditIndexes.Clear();
    //        grdChiTiet.MasterTableView.Rebind();
    //        grdChiTiet.Rebind();

    // }
    // catch (Exception ex)
    // {
    //        HandleException(ex, action);        

    //        //throw;  
    // }        

    //    return true;        
    //}



    protected bool UpdateData(GridEditableItem editedItem, FormAction action)
    {
        string MaCV = string.Empty;
        string TenCV = string.Empty;
        string Vi_Tri = string.Empty;
        

        if (action != FormAction.INSERT)
        {
            MaCV = editedItem.GetDataKeyValue("MaCV").ToString();

        }




        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }
            MaCV = ((TextBox)editedItem["MaCV"].Controls[0]).Text;
            TenCV = ((TextBox)editedItem["TenCV"].Controls[0]).Text;
            Vi_Tri = ((TextBox)editedItem["Vi_Tri"].Controls[0]).Text;
            

        }



        try
        {
            if (action == FormAction.EDIT)
            {

                UpdateDMChucVu(MaCV, TenCV, Vi_Tri, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {

                InsertDMChucVu(MaCV, TenCV, Vi_Tri, Pub_sMaMay, Pub_sNguoiSD);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMChucVu(Pub_sMaMay, Pub_sNguoiSD, MaCV);

            }

            ViewState[ViewState_DMChucVuList] = null;
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
        if (DMChucVuList != null)
        {            
            grdChiTiet.DataSource = DMChucVuList;
        }
    }

    /*
    [OperationContract]
    public RadListBoxItemData[] LoadChucVuList(Dictionary<string, object> context)
    {        
        var ChucVuList = (from ChucVu in DMChucVuList
                            orderby ChucVu.TenCV
                            select new RadListBoxItemData
                            {
                                Text = ChucVu.TenCV
                            }).Distinct();

        return ChucVuList.ToArray<RadListBoxItemData>();
    }*/



    public String InsertDMChucVu(String _MaCV, String _TenCV, String _Vi_Tri, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChucVu_CREATE_130", _MaCV, _TenCV, _Vi_Tri, _maMay, _nguoiSD));
    }
    public void UpdateDMChucVu(String _MaCV, String _TenCV, String _Vi_Tri, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChucVu_update", _MaCV, _TenCV, _Vi_Tri, _maMay, _nguoiSD);
    }

    public void DeleteDMChucVu(String _maMay, String _nguoiSD, String _MaCV)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChucVu_DELETED", _maMay, _nguoiSD, _MaCV);
    }
    [Serializable]
    public class DMChucVuM
    {
        private String _MaCV = String.Empty;
        private String _TenCV = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _Vi_Tri = String.Empty;

        private int _OrderNumber;
        public String MaCV
        {
            get
            {
                return _MaCV;
            }
            set
            {
                if (_MaCV != value)
                {
                    _MaCV = value;
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
        public String Vi_Tri
        {
            get
            {
                return _Vi_Tri;
            }
            set
            {
                if (_Vi_Tri != value)
                {
                    _Vi_Tri = value;
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
        public DMChucVuM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaCV"].GetType().Name != "DBNull" && dr["MaCV"] != null)
            {
                this.MaCV = Convert.ToString(dr["MaCV"]);
            }
            else
            {
                this.MaCV = "";
            }
            if (dr["TenCV"].GetType().Name != "DBNull" && dr["TenCV"] != null)
            {
                this.TenCV = Convert.ToString(dr["TenCV"]);
            }
            else
            {
                this.TenCV = "";
            }
            if (dr["Vi_Tri"].GetType().Name != "DBNull" && dr["Vi_Tri"] != null)
            {
                this.Vi_Tri = Convert.ToString(dr["Vi_Tri"]);
            }
            else
            {
                this.Vi_Tri = "";
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
        public static List<DMChucVuM> GetDMChucVuM()
        {
            List<DMChucVuM> List = new List<DMChucVuM>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMChucVu_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMChucVuM(dr, i));
                }
            }
            return List;
        }
    }

}