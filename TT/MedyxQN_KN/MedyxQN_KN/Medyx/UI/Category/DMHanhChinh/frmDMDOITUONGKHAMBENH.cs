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
using HTC.Business.NoiTru;
using System.Web.UI.WebControls.Expressions;
using Resources.RadGrid;


public partial class UI_Category_DMHanhChinh_frmDMDOITUONGKHAMBENH : HTC.Common.Web.WebBase
{
    private const string ViewState_DMDOITUONGKHAMBENHList = "frmDMDOITUONGKHAMBENH";


    public List<DMDOITUONGKHAMBENH> DMDOITUONGKHAMBENHList
    {
        get
        {
            if (ViewState[ViewState_DMDOITUONGKHAMBENHList] == null)
            {
                ViewState[ViewState_DMDOITUONGKHAMBENHList] = DMDOITUONGKHAMBENH.GetDMDOITUONGKHAMBENH();
            }

            return (List<DMDOITUONGKHAMBENH>)ViewState[ViewState_DMDOITUONGKHAMBENHList];
        }

        set
        {
            ViewState[ViewState_DMDOITUONGKHAMBENHList] = value;
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
        grdChiTiet.DataSource = DMDOITUONGKHAMBENHList;
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



        

        string MA_DOITUONG_KCB = string.Empty;
        string TEN_DOITUONG_KCB = string.Empty;
        string DIEN_GIAI = string.Empty;
        string TRICH_DAN = string.Empty;
        string MaDT = string.Empty;
        string MaBHXH = string.Empty;

        if (action != FormAction.INSERT)
        {
            MA_DOITUONG_KCB = editedItem.GetDataKeyValue("MA_DOITUONG_KCB").ToString();
            
        }


        //string GhiChu = string.Empty;
        //if (action != FormAction.DELETE)
        //{
        //    if (ValidateForm(editedItem) == false)
        //    {
        //        return false;
        //    }

        //GhiChu = ((TextBox)editedItem["GhiChu"].Controls[0]).Text;
        //}




        
    




        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }

            MA_DOITUONG_KCB = ((TextBox)editedItem["MA_DOITUONG_KCB"].Controls[0]).Text;
            TEN_DOITUONG_KCB = ((TextBox)editedItem["TEN_DOITUONG_KCB"].Controls[0]).Text;
            DIEN_GIAI = ((TextBox)editedItem["DIEN_GIAI"].Controls[0]).Text;
            TRICH_DAN = ((TextBox)editedItem["TRICH_DAN"].Controls[0]).Text;
            MaDT = ((TextBox)editedItem["MaDT"].Controls[0]).Text;
            MaBHXH = ((TextBox)editedItem["MaBHXH"].Controls[0]).Text;

        }



        try
        {
            if (action == FormAction.EDIT)
            {
                              
                UpdateDMDOITUONGKHAMBENH(MA_DOITUONG_KCB, TEN_DOITUONG_KCB, DIEN_GIAI, TRICH_DAN, MaDT, MaBHXH, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {
                

                InsertDMDOITUONGKHAMBENH(MA_DOITUONG_KCB,TEN_DOITUONG_KCB, DIEN_GIAI, TRICH_DAN, MaDT, MaBHXH, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMDOITUONGKHAMBENH(Pub_sMaMay, Pub_sNguoiSD, MA_DOITUONG_KCB);
             
            }

            ViewState[ViewState_DMDOITUONGKHAMBENHList] = null;
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
        if (DMDOITUONGKHAMBENHList != null)
        {
            grdChiTiet.DataSource = DMDOITUONGKHAMBENHList;
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
    public String InsertDMDOITUONGKHAMBENH(String _MA_DOITUONG_KCB, String _TEN_DOITUONG_KCB, String _DIEN_GIAI, String _TRICH_DAN, String _MaDT, String _MaBHXH, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDOITUONGKHAMBENH_CREATE", _MA_DOITUONG_KCB, _TEN_DOITUONG_KCB, _DIEN_GIAI, _TRICH_DAN, _MaDT, _MaBHXH, _maMay, _nguoiSD));
    }
    public void UpdateDMDOITUONGKHAMBENH(String _MA_DOITUONG_KCB, String _TEN_DOITUONG_KCB, String _DIEN_GIAI, String _TRICH_DAN, String _MaDT, String _MaBHXH, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDOITUONGKHAMBENH_update", _MA_DOITUONG_KCB, _TEN_DOITUONG_KCB, _DIEN_GIAI, _TRICH_DAN, _MaDT, _MaBHXH, _maMay, _nguoiSD);
    }

    public void DeleteDMDOITUONGKHAMBENH(String _maMay, String _nguoiSD, String _MA_DOITUONG_KCB)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDOITUONGKHAMBENH_DELETED", _maMay, _nguoiSD, _MA_DOITUONG_KCB);
    }
    [Serializable]
    public class DMDOITUONGKHAMBENH
    {
        private String _MA_DOITUONG_KCB = String.Empty;
        private String _TEN_DOITUONG_KCB = String.Empty;
        private String _DIEN_GIAI = String.Empty;
        private String _TRICH_DAN = String.Empty;
        private String _MaDT = String.Empty;
        private String _MaBHXH = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;

        private int _OrderNumber;
        public String MA_DOITUONG_KCB
        {
            get
            {
                return _MA_DOITUONG_KCB;
            }
            set
            {
                if (_MA_DOITUONG_KCB != value)
                {
                    _MA_DOITUONG_KCB = value;
                }
            }
        }

        public String TEN_DOITUONG_KCB
        {
            get
            {
                return _TEN_DOITUONG_KCB;
            }
            set
            {
                if (_TEN_DOITUONG_KCB != value)
                {
                    _TEN_DOITUONG_KCB = value;
                }
            }
        }

        public String DIEN_GIAI
        {
            get
            {
                return _DIEN_GIAI;
            }
            set
            {
                if (_DIEN_GIAI != value)
                {
                    _DIEN_GIAI = value;
                }
            }
        }
        public String TRICH_DAN
        {
            get
            {
                return _TRICH_DAN;
            }
            set
            {
                if (_TRICH_DAN != value)
                {
                    _TRICH_DAN = value;
                }
            }
        }
        public String MaDT
        {
            get
            {
                return _MaDT;
            }
            set
            {
                if (_MaDT != value)
                {
                    _MaDT = value;
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
        public DMDOITUONGKHAMBENH(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;

            if (dr["MA_DOITUONG_KCB"].GetType().Name != "DBNull" && dr["MA_DOITUONG_KCB"] != null)
            {
                this.MA_DOITUONG_KCB = Convert.ToString(dr["MA_DOITUONG_KCB"]);
            }
            else
            {
                this.MA_DOITUONG_KCB = "";
            }
            if (dr["TEN_DOITUONG_KCB"].GetType().Name != "DBNull" && dr["TEN_DOITUONG_KCB"] != null)
            {
                this.TEN_DOITUONG_KCB = Convert.ToString(dr["TEN_DOITUONG_KCB"]);
            }
            else
            {
                this.TEN_DOITUONG_KCB = "";
            }
            if (dr["DIEN_GIAI"].GetType().Name != "DBNull" && dr["DIEN_GIAI"] != null)
            {
                this.DIEN_GIAI = Convert.ToString(dr["DIEN_GIAI"]);
            }
            else
            {
                this.DIEN_GIAI = "";
            }


            if (dr["TRICH_DAN"].GetType().Name != "DBNull" && dr["TRICH_DAN"] != null)
            {
                this.TRICH_DAN = Convert.ToString(dr["TRICH_DAN"]);
            }
            else
            {
                this.TRICH_DAN = "";
            }
            if (dr["MaDT"].GetType().Name != "DBNull" && dr["MaDT"] != null)
            {
                this.MaDT = Convert.ToString(dr["MaDT"]);
            }
            else
            {
                this.MaDT = "";
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
        public static List<DMDOITUONGKHAMBENH> GetDMDOITUONGKHAMBENH()
        {
            List<DMDOITUONGKHAMBENH> List = new List<DMDOITUONGKHAMBENH>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDOITUONGKHAMBENH_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMDOITUONGKHAMBENH(dr,i));
                }
            }
            return List;
        }
    }
}