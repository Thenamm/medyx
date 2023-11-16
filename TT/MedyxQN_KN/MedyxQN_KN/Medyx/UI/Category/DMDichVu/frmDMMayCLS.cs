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


public partial class UI_Category_DMDichVu_frmDMMayCLS : HTC.Common.Web.WebBase
{
    private const string ViewState_DMMayCLSList = "DMMayCLS";


    public List<DMMayCLS> DMMayCLSList
    {
        get
        {
            if (ViewState[ViewState_DMMayCLSList] == null)
            {
                ViewState[ViewState_DMMayCLSList] = DMMayCLS.GetDMMayCLS();
            }

            return (List<DMMayCLS>)ViewState[ViewState_DMMayCLSList];
        }

        set
        {
            ViewState[ViewState_DMMayCLSList] = value;
        }

    }


    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY; LoadData();
        }
        if (pub_bQadmin == false)
            grdChiTiet.MasterTableView.GetColumn("Huy").Display = false;
    }

    private void LoadData()
    {
        grdChiTiet.DataSource = DMMayCLSList;
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
                    ShowMessage(MessageType.SUCCESS, FormAction.DELETE); LoadData();
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
                    ShowMessage(MessageType.SUCCESS, FormAction.EDIT); LoadData();
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
                ShowMessage(MessageType.SUCCESS, FormAction.INSERT); LoadData();
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

        string MA_MAY = string.Empty;
        string TEN_TB = string.Empty;
        string KY_HIEU = string.Empty;
        string CONGTY_SX = string.Empty;
        string NUOC_SX = string.Empty;
        decimal NAM_SX = 0;
        decimal NAM_SD = 0;        
        string SO_LUU_HANH = string.Empty;
        string HD_TU = string.Empty;
        string HD_DEN = string.Empty;


        //DateTime HD_TU = DateTime.ParseExact(((TextBox)editedItem["HD_TU"].Controls[0]).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //DateTime HD_DEN = DateTime.ParseExact(((TextBox)editedItem["HD_DEN"].Controls[0]).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);





        //DateTime NgaySD=DateTime.Now;


        Boolean Huy = false;
        if (action != FormAction.INSERT)
        {
            MA_MAY = editedItem.GetDataKeyValue("MA_MAY").ToString();

        }

        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }

            MA_MAY = ((TextBox)editedItem["MA_MAY"].Controls[0]).Text;
            TEN_TB = ((TextBox)editedItem["TEN_TB"].Controls[0]).Text;
            KY_HIEU = ((TextBox)editedItem["KY_HIEU"].Controls[0]).Text;
            CONGTY_SX = ((TextBox)editedItem["CONGTY_SX"].Controls[0]).Text;
            NUOC_SX = ((TextBox)editedItem["NUOC_SX"].Controls[0]).Text;
            NAM_SX = decimal.Parse(((TextBox)editedItem["NAM_SX"].Controls[0]).Text);
            NAM_SD = decimal.Parse(((TextBox)editedItem["NAM_SD"].Controls[0]).Text);
            SO_LUU_HANH = ((TextBox)editedItem["SO_LUU_HANH"].Controls[0]).Text;

            HD_TU = ((TextBox)editedItem["HD_TU"].Controls[0]).Text;
            HD_DEN = ((TextBox)editedItem["HD_DEN"].Controls[0]).Text;
            // NgaySD = DateTime.ParseExact(((TextBox)editedItem["NgaySD"].Controls[0]).Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Huy = false;
            if (action == FormAction.INSERT)
            {
                Huy = ((CheckBox)editedItem["Huy"].Controls[0]).Checked;
            }
        }



        try
        {
            if (action == FormAction.EDIT)
            {

                UpdateDMMayCLS(MA_MAY, TEN_TB, KY_HIEU, CONGTY_SX, NUOC_SX, NAM_SX, NAM_SD, SO_LUU_HANH, HD_TU, HD_DEN, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {


                InsertDMMayCLS(MA_MAY, TEN_TB, KY_HIEU, CONGTY_SX, NUOC_SX, NAM_SX, NAM_SD, SO_LUU_HANH, HD_TU, HD_DEN, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMMayCLS(Pub_sMaMay, Pub_sNguoiSD, MA_MAY);

            }

            grdChiTiet.EditIndexes.Clear();
            grdChiTiet.MasterTableView.Rebind();
            grdChiTiet.Rebind();

            ViewState[ViewState_DMMayCLSList] = null;
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
        if (DMMayCLSList != null)
        {
            grdChiTiet.DataSource = DMMayCLSList;
        }
    }


    public String InsertDMMayCLS(String _MA_MAY, String _TEN_TB, String _KY_HIEU, String _CONGTY_SX, String _NUOC_SX, Decimal _NAM_SX, Decimal _NAM_SD, String _SO_LUU_HANH, String _HD_TU, String _HD_DEN, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMMayCLS_CREATE", _MA_MAY, _TEN_TB, _KY_HIEU, _CONGTY_SX, _NUOC_SX, _NAM_SX, _NAM_SD, _SO_LUU_HANH, _HD_TU, _HD_DEN, _maMay, _nguoiSD));
    }
    public void UpdateDMMayCLS(String _MA_MAY, String _TEN_TB, String _KY_HIEU, String _CONGTY_SX, String _NUOC_SX, Decimal _NAM_SX, Decimal _NAM_SD,  String _SO_LUU_HANH, String _HD_TU, String _HD_DEN, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMMayCLS_update", _MA_MAY, _TEN_TB, _KY_HIEU, _CONGTY_SX, _NUOC_SX, _NAM_SX, _NAM_SD, _SO_LUU_HANH, _HD_TU, _HD_DEN, _maMay,  _nguoiSD);
    }

    public void DeleteDMMayCLS(String _maMay, String _nguoiSD, String _MA_MAY)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMMayCLS_DELETED", _maMay, _nguoiSD, _MA_MAY);
    }
    [Serializable]
    public class DMMayCLS
    {
        //private Decimal _STT = 0;
        private String _TEN_TB = String.Empty;
        private String _KY_HIEU = String.Empty;
        private String _CONGTY_SX = String.Empty;
        private String _NUOC_SX = String.Empty;
        private Decimal _NAM_SX = 0;
        private Decimal _NAM_SD = 0;
        private String _MA_MAY = String.Empty;
        private String _SO_LUU_HANH = String.Empty;
        private String _HD_TU = String.Empty;
        private String _HD_DEN = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;

        private int _OrderNumber;


        public String TEN_TB
        {
            get
            {
                return _TEN_TB;
            }
            set
            {
                if (_TEN_TB != value)
                {
                    _TEN_TB = value;
                }
            }
        }

        public String KY_HIEU
        {
            get
            {
                return _KY_HIEU;
            }
            set
            {
                if (_KY_HIEU != value)
                {
                    _KY_HIEU = value;
                }
            }
        }
        public String CONGTY_SX
        {
            get
            {
                return _CONGTY_SX;
            }
            set
            {
                if (_CONGTY_SX != value)
                {
                    _CONGTY_SX = value;
                }
            }
        }
        public String NUOC_SX
        {
            get
            {
                return _NUOC_SX;
            }
            set
            {
                if (_NUOC_SX != value)
                {
                    _NUOC_SX = value;
                }
            }
        }
        public Decimal NAM_SX
        {
            get
            {
                return _NAM_SX;
            }
            set
            {
                if (_NAM_SX != value)
                {
                    _NAM_SX = value;
                }
            }
        }
        public Decimal NAM_SD
        {
            get
            {
                return _NAM_SD;
            }
            set
            {
                if (_NAM_SD != value)
                {
                    _NAM_SD = value;
                }
            }
        }
        public String MA_MAY
        {
            get
            {
                return _MA_MAY;
            }
            set
            {
                if (_MA_MAY != value)
                {
                    _MA_MAY = value;
                }
            }
        }
        public String SO_LUU_HANH
        {
            get
            {
                return _SO_LUU_HANH;
            }
            set
            {
                if (_SO_LUU_HANH != value)
                {
                    _SO_LUU_HANH = value;
                }
            }
        }

        public String HD_TU
        {
            get
            {
                return _HD_TU;
            }
            set
            {
                if (_HD_TU != value)
                {
                    _HD_TU = value;
                }
            }
        }

        public String HD_DEN
        {
            get
            {
                return _HD_DEN;
            }
            set
            {
                if (_HD_DEN != value)
                {
                    _HD_DEN = value;
                }
            }
        }



        //public String HD_TU
        //{
        //    get
        //    {
        //        return _HD_TU.ToString("dd/MM/yyyy HH:mm");
        //    }
        //    set
        //    {
        //        DateTime d;

        //        if (DateTime.TryParseExact(value, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture,
        //                   DateTimeStyles.None, out d))
        //        {
        //            _HD_TU = d;
        //        }
        //    }
        //}

        //public String HD_DEN
        //{
        //    get
        //    {
        //        return _HD_DEN.ToString("dd/MM/yyyy HH:mm");
        //    }
        //    set
        //    {
        //        DateTime d;

        //        if (DateTime.TryParseExact(value, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture,
        //                   DateTimeStyles.None, out d))
        //        {
        //            _HD_DEN = d;
        //        }
        //    }
        //}
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

                if (DateTime.TryParseExact(value, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture,
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
        public DMMayCLS(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;

            //if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
            //{
            //    this.STT = Convert.ToDecimal(dr["STT"]);
            //}
            //else
            //{
            //    this.STT = 0;
            //}
            if (dr["TEN_TB"].GetType().Name != "DBNull" && dr["TEN_TB"] != null)
            {
                this.TEN_TB = Convert.ToString(dr["TEN_TB"]);
            }
            else
            {
                this.TEN_TB = "";
            }
            if (dr["KY_HIEU"].GetType().Name != "DBNull" && dr["KY_HIEU"] != null)
            {
                this.KY_HIEU = Convert.ToString(dr["KY_HIEU"]);
            }
            else
            {
                this.KY_HIEU = "";
            }


            if (dr["CONGTY_SX"].GetType().Name != "DBNull" && dr["CONGTY_SX"] != null)
            {
                this.CONGTY_SX = Convert.ToString(dr["CONGTY_SX"]);
            }
            else
            {
                this.CONGTY_SX = "";
            }
            if (dr["NUOC_SX"].GetType().Name != "DBNull" && dr["NUOC_SX"] != null)
            {
                this.NUOC_SX = Convert.ToString(dr["NUOC_SX"]);
            }
            else
            {
                this.NUOC_SX = "";
            }
            if (dr["NAM_SX"].GetType().Name != "DBNull" && dr["NAM_SX"] != null)
            {
                this.NAM_SX = Convert.ToDecimal(dr["NAM_SX"]);
            }
            else
            {
                this.NAM_SX = 0;
            }
            if (dr["NAM_SD"].GetType().Name != "DBNull" && dr["NAM_SD"] != null)
            {
                this.NAM_SD = Convert.ToDecimal(dr["NAM_SD"]);
            }
            else
            {
                this.NAM_SD = 0;
            }

            if (dr["MA_MAY"].GetType().Name != "DBNull" && dr["MA_MAY"] != null)
            {
                this.MA_MAY = Convert.ToString(dr["MA_MAY"]);
            }
            else
            {
                this.MA_MAY = "";
            }
            if (dr["SO_LUU_HANH"].GetType().Name != "DBNull" && dr["SO_LUU_HANH"] != null)
            {
                this.SO_LUU_HANH = Convert.ToString(dr["SO_LUU_HANH"]);
            }
            else
            {
                this.SO_LUU_HANH = "";
            }
            if (dr["HD_TU"].GetType().Name != "DBNull" && dr["HD_TU"] != null)
            {
                this.HD_TU = Convert.ToString(dr["HD_TU"]);
            }
            else
            {
                this.HD_TU = "";
            }
            if (dr["HD_DEN"].GetType().Name != "DBNull" && dr["HD_DEN"] != null)
            {
                this.HD_DEN = Convert.ToString(dr["HD_DEN"]);
            }
            else
            {
                this.HD_DEN = "";
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
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy HH:mm");
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
        public static List<DMMayCLS> GetDMMayCLS()
        {
            List<DMMayCLS> List = new List<DMMayCLS>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMMayCLS_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMMayCLS(dr, i));
                }
            }
            return List;
        }
    }
}