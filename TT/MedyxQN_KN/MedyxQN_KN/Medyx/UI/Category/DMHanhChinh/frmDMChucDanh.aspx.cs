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
using System.Data;

public partial class UI_Category_DMHanhChinh_frmDMChucDanh : HTC.Common.Web.WebBase
{
    //private const string ViewState_DMChucDanhList = "DMChucDanh";


    //public DMChucDanhList DMChucDanhList
    //{
    //    get
    //    {
    //        if (ViewState[ViewState_DMChucDanhList] == null)
    //        {
    //            //ViewState[ViewState_DMChucDanhList] = DMChucDanhList.GetAllDMChucDanh()[0].MaCD;
    //            ViewState[ViewState_DMChucDanhList] = DMChucDanhList.GetAllDMChucDanh();
    //        }
    //        return (DMChucDanhList)ViewState[ViewState_DMChucDanhList];
    //    }

    //    set
    //    {
    //        ViewState[ViewState_DMChucDanhList] = value;
    //    }

    //}


    private const string ViewState_DMChucDanhList = "DMChucDanhM";


    public List<DMChucDanhM> DMChucDanhList
    {
        get
        {
            if (ViewState[ViewState_DMChucDanhList] == null)
            {
                ViewState[ViewState_DMChucDanhList] = DMChucDanhM.GetDMChucDanhM();
            }

            return (List<DMChucDanhM>)ViewState[ViewState_DMChucDanhList];
        }

        set
        {
            ViewState[ViewState_DMChucDanhList] = value;
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
        grdChiTiet.DataSource = DMChucDanhList;
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
    //    string maCD = string.Empty;
    //    if (action != FormAction.INSERT)
    //    {
    //        maCD = editedItem.GetDataKeyValue("MaCD").ToString();
    //    }                

    //    string tenCD = string.Empty;
    //    //Thêm trường
    //  // string GhiChu = string.Empty;
    //    if (action != FormAction.DELETE)
    //    {
    //        if (ValidateForm(editedItem) == false)
    //        {
    //            return false;
    //        }

    //        tenCD = ((TextBox)editedItem["TenCD"].Controls[0]).Text;
    //        //Thêm trường
    //       // GhiChu = ((TextBox)editedItem["GhiChu"].Controls[0]).Text;
    //       //DMChucDanhList.GetAllDMChucDanh()[0].TenCD 

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
    //            HTC.Business.DataProvider.Instance().UpdateDMChucDanh(maCD, tenCD, Pub_sMaMay, Pub_sNguoiSD);

    //            if (isHuy)
    //            {
    //                HTC.Business.DataProvider.Instance().DeleteDMChucDanh(Pub_sMaMay, Pub_sNguoiSD,maCD);
    //            }
    //        }
    //        else if (action == FormAction.INSERT)
    //        {
    //            HTC.Business.DataProvider.Instance().InsertDMChucDanh(tenCD, Pub_sMaMay, Pub_sNguoiSD);                                        
    //        }
    //        else if (action == FormAction.DELETE)
    //        {
    //            HTC.Business.DataProvider.Instance().DeleteDMChucDanh(Pub_sMaMay, Pub_sNguoiSD, maCD);
    //        }

    //        ViewState[ViewState_DMChucDanhList] = null;
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
        string MaCD = string.Empty;
        string TenCD = string.Empty;
        string ChucDanh_NN = string.Empty;
        //string MaBYTe = string.Empty;

        if (action != FormAction.INSERT)
        {
            MaCD = editedItem.GetDataKeyValue("MaCD").ToString();

        }




        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }
            MaCD = ((TextBox)editedItem["MaCD"].Controls[0]).Text;
            TenCD = ((TextBox)editedItem["TenCD"].Controls[0]).Text;
            ChucDanh_NN = ((TextBox)editedItem["ChucDanh_NN"].Controls[0]).Text;
            //MaBYTe = ((TextBox)editedItem["MaBYTe"].Controls[0]).Text;

        }



        try
        {
            if (action == FormAction.EDIT)
            {
                
                UpdateDMChucDanh(MaCD, TenCD, ChucDanh_NN,  Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {
               
                InsertDMChucDanh(MaCD,TenCD, ChucDanh_NN,  Pub_sMaMay, Pub_sNguoiSD);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMChucDanh(Pub_sMaMay, Pub_sNguoiSD, MaCD);
                
            }

            ViewState[ViewState_DMChucDanhList] = null;
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
        if (DMChucDanhList != null)
        {            
            grdChiTiet.DataSource = DMChucDanhList;
        }
    }

    /*
    [OperationContract]
    public RadListBoxItemData[] LoadChucVuList(Dictionary<string, object> context)
    {        
        var ChucVuList = (from ChucVu in DMChucDanhList
                            orderby ChucVu.TenCD
                            select new RadListBoxItemData
                            {
                                Text = ChucVu.TenCD
                            }).Distinct();

        return ChucVuList.ToArray<RadListBoxItemData>();
    }*/


    public String InsertDMChucDanh(String _MaCD, String _TenCD, String _ChucDanh_NN,  string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChucDanh_CREATE_130", _MaCD, _TenCD, _ChucDanh_NN,  _maMay, _nguoiSD));
    }
    public void UpdateDMChucDanh(String _MaCD, String _TenCD, String _ChucDanh_NN,  string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChucDanh_update", _MaCD, _TenCD, _ChucDanh_NN,  _maMay, _nguoiSD);
    }

    public void DeleteDMChucDanh(String _maMay, String _nguoiSD, String _MaCD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChucDanh_DELETED", _maMay, _nguoiSD, _MaCD);
    }
    [Serializable]
    public class DMChucDanhM
    {
        private String _MaCD = String.Empty;
        private String _TenCD = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _ChucDanh_NN = String.Empty;
        
        private int _OrderNumber;
        public String MaCD
        {
            get
            {
                return _MaCD;
            }
            set
            {
                if (_MaCD != value)
                {
                    _MaCD = value;
                }
            }
        }

        public String TenCD
        {
            get
            {
                return _TenCD;
            }
            set
            {
                if (_TenCD != value)
                {
                    _TenCD = value;
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
        public String ChucDanh_NN
        {
            get
            {
                return _ChucDanh_NN;
            }
            set
            {
                if (_ChucDanh_NN != value)
                {
                    _ChucDanh_NN = value;
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
        public DMChucDanhM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaCD"].GetType().Name != "DBNull" && dr["MaCD"] != null)
            {
                this.MaCD = Convert.ToString(dr["MaCD"]);
            }
            else
            {
                this.MaCD = "";
            }
            if (dr["TenCD"].GetType().Name != "DBNull" && dr["TenCD"] != null)
            {
                this.TenCD = Convert.ToString(dr["TenCD"]);
            }
            else
            {
                this.TenCD = "";
            }
            if (dr["ChucDanh_NN"].GetType().Name != "DBNull" && dr["ChucDanh_NN"] != null)
            {
                this.ChucDanh_NN = Convert.ToString(dr["ChucDanh_NN"]);
            }
            else
            {
                this.ChucDanh_NN = "";
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
        public static List<DMChucDanhM> GetDMChucDanhM()
        {
            List<DMChucDanhM> List = new List<DMChucDanhM>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMChucDanh_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMChucDanhM(dr, i));
                }
            }
            return List;
        }
    }




}