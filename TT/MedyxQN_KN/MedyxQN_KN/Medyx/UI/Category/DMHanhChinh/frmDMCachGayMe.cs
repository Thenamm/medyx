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

public partial class UI_Category_DMHanhChinh_frmDMCachGayMe : HTC.Common.Web.WebBase
{
    private const string ViewState_DMCachGayMeList = "DMCachGayMe";
    private Button sender;

    public List<DMCachGayMeM> DMCachGayMeList
    {
        get
        {
            if (ViewState[ViewState_DMCachGayMeList] == null)
            {
                ViewState[ViewState_DMCachGayMeList] = DMCachGayMeM.GetDMCachGayMeM();
            }

            return (List<DMCachGayMeM>)ViewState[ViewState_DMCachGayMeList];
        }

        set
        {
            ViewState[ViewState_DMCachGayMeList] = value;
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
        grdChiTiet.DataSource = DMCachGayMeList;
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
        string MaCGM = string.Empty;
        string TenCGM = string.Empty;
        string PP_VO_CAM = string.Empty;

        if (action != FormAction.INSERT)
        {
            MaCGM = editedItem.GetDataKeyValue("MaCGM").ToString();

        }
        
        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }

           

            MaCGM = ((TextBox)editedItem["MaCGM"].Controls[0]).Text;
            TenCGM = ((TextBox)editedItem["TenCGM"].Controls[0]).Text;
            PP_VO_CAM = ((TextBox)editedItem["PP_VO_CAM"].Controls[0]).Text;
            //PP_VO_CAM = byte.Parse(((TextBox)editedItem["PP_VO_CAM"].Controls[0]).Text);





        }



        try
        {
            //byte rb = 0;

            //if (chkgayme.Checked == true)
            //{
            //    rb = 1;
            //}
            //else if (chkgayte.Checked == true)
            //{
            //    rb = 2;
            //}
            //else if (chkchamte.Checked == true)
            //{
            //    rb = 3;
            //}
            //else if (chkppkhac.Checked == true)
            //{
            //    rb = 4;
            //}




            if (action == FormAction.EDIT)
            {
                //HTC.Business.DataProvider.Instance().UpdateDMNgheNghiep(maNN, tenNN, Pub_sMaMay, Pub_sNguoiSD);
                UpdateDMCachGayMeM(MaCGM, TenCGM, PP_VO_CAM,  Pub_sMaMay,  Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {
                //HTC.Business.DataProvider.Instance().InsertDMNgheNghiep(tenNN, Pub_sMaMay, Pub_sNguoiSD);
                InsertDMCachGayMeM(MaCGM, TenCGM, PP_VO_CAM, Pub_sMaMay, Pub_sNguoiSD);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMCachGayMeM( Pub_sMaMay, Pub_sNguoiSD, MaCGM);
                //HTC.Business.DataProvider.Instance().DeleteDMNgheNghiep(Pub_sMaMay, Pub_sNguoiSD, maBC);
            }

            ViewState[ViewState_DMCachGayMeList] = null;
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
        if (DMCachGayMeList != null)
        {
            grdChiTiet.DataSource = DMCachGayMeList;
        }
    }


    public String InsertDMCachGayMeM(String _MaCGM, String _TenCGM, string _PP_VO_CAM,   string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCachGayMe_CREATE", _MaCGM, _TenCGM, _PP_VO_CAM, _maMay, _nguoiSD));
    }
    public void UpdateDMCachGayMeM(String _MaCGM, String _TenCGM, string _PP_VO_CAM, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCachGayMe_update", _MaCGM, _TenCGM, _PP_VO_CAM, _maMay, _nguoiSD);
    }

    public void DeleteDMCachGayMeM(String _maMay, String _nguoiSD, String _MaCGM)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCachGayMe_DELETED",  _maMay, _nguoiSD, _MaCGM);
    }
    [Serializable]
    public class DMCachGayMeM
    {
        private String _MaCGM = String.Empty;
        private String _TenCGM = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private String _PP_VO_CAM = String.Empty;

        private int _OrderNumber;
        public String MaCGM
        {
            get
            {
                return _MaCGM;
            }
            set
            {
                if (_MaCGM != value)
                {
                    _MaCGM = value;
                }
            }
        }

        public String TenCGM
        {
            get
            {
                return _TenCGM;
            }
            set
            {
                if (_TenCGM != value)
                {
                    _TenCGM = value;
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
        //public Byte PP_VO_CAM
        //{
        //    get
        //    {
        //        return _PP_VO_CAM;
        //    }
        //    set
        //    {
        //        if (_PP_VO_CAM != value)
        //        {
        //            _PP_VO_CAM = value;
        //        }
        //    }
        //}


        public String PP_VO_CAM
        {
            get
            {
                return _PP_VO_CAM;
            }
            set
            {
                if (_PP_VO_CAM != value)
                {
                    _PP_VO_CAM = value;
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
        public DMCachGayMeM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaCGM"].GetType().Name != "DBNull" && dr["MaCGM"] != null)
            {
                this.MaCGM = Convert.ToString(dr["MaCGM"]);
            }
            else
            {
                this.MaCGM = "";
            }
            if (dr["TenCGM"].GetType().Name != "DBNull" && dr["TenCGM"] != null)
            {
                this.TenCGM = Convert.ToString(dr["TenCGM"]);
            }
            else
            {
                this.TenCGM = "";
            }
            //if (dr["PP_VO_CAM"].GetType().Name != "DBNull" && dr["PP_VO_CAM"] != null)
            //{
            //    this.PP_VO_CAM = Convert.ToByte(dr["PP_VO_CAM"]);
            //}
            //else
            //{
            //    this.PP_VO_CAM = 0;
            //}


            if (dr["PP_VO_CAM"].GetType().Name != "DBNull" && dr["PP_VO_CAM"] != null)
            {
                this.PP_VO_CAM = Convert.ToString(dr["PP_VO_CAM"]);
            }
            else
            {
                this.PP_VO_CAM = "";
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
        public static List<DMCachGayMeM> GetDMCachGayMeM()
        {
            List<DMCachGayMeM> List = new List<DMCachGayMeM>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMCachGayMe_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMCachGayMeM(dr,i));
                }
            }
            return List;
        }
    }
}