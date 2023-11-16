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
using HTC.Business;
//using static iTextSharp.awt.geom.Point2D;

public partial class UI_Category_DMVTYT_frmDMLoaiHinh : HTC.Common.Web.WebBase
{
    private const string ViewState_DMLoaiHinhList = "DMLoaiHinh";
    public List<DMLoaiHinhM> DMLoaiHinhList
    {
        get
        {
            if (ViewState[ViewState_DMLoaiHinhList] == null)
            {
                ViewState[ViewState_DMLoaiHinhList] = DMLoaiHinhM.GetDMLoaiHinhM();
            }

            return (List<DMLoaiHinhM>)ViewState[ViewState_DMLoaiHinhList];
        }

        set
        {
            ViewState[ViewState_DMLoaiHinhList] = value;
        }

    }


    private const string ViewState_action = "_action";

    public FormAction _action
    {
        get
        {

            if (ViewState[ViewState_action] != null)
            {
                return (FormAction)ViewState[ViewState_action];
            }

            return FormAction.EDIT;
        }

        set
        {
            ViewState[ViewState_action] = value;
        }
    }

    private const string ViewState_DMLoaiHinh = "_DMLoaiHinh";
    //public DMLoaiHinh _DMLoaiHinh
    //{
    //    get
    //    {
    //        if (ViewState[ViewState_DMLoaiHinh] == null)
    //            ViewState[ViewState_DMLoaiHinh] = DMLoaiHinh.NewDMLoaiHinh();


    //        return (DMLoaiHinh)ViewState[ViewState_DMLoaiHinh];
    //    }

    //    set
    //    {
    //        ViewState[ViewState_DMLoaiHinh] = value;
    //    }

    //}

    //private void LoadDetail()
    //{
    //    if (_action == FormAction.INSERT)
    //        _DMLoaiHinh = DMLoaiHinh.NewDMLoaiHinh();



    //}
    protected void Page_Load(object sender, EventArgs e)
       {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;
            LoadData();
        }
        if (pub_bQadmin == false)
            grdChiTiet.MasterTableView.GetColumn("Huy").Display = false;



    }


    private void LoadData()
    {
        grdChiTiet.DataSource = DMLoaiHinhList;
        grdChiTiet.DataBind();

        //cboChiPhi.DataSource = GetDMNhomChiPhi();
        //cboChiPhi.DataBind();

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

    protected bool UpdateData(GridEditableItem editedItem, FormAction action)
    {

        string MaLH = string.Empty;
        string TenLH = string.Empty;
        string MaChungLoai = string.Empty;
        int Ma_BCTH = 0;

        if (action != FormAction.INSERT)
        {
            MaLH = editedItem.GetDataKeyValue("MaLH").ToString();

        }



        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }
            MaLH = ((TextBox)editedItem["MaLH"].Controls[0]).Text;
            TenLH = ((TextBox)editedItem["TenLH"].Controls[0]).Text;
            MaChungLoai = ((TextBox)editedItem["MaChungLoai"].Controls[0]).Text;
            int.TryParse(((TextBox)editedItem["Ma_BCTH"].Controls[0]).Text, out Ma_BCTH);


        }



        try
        {

            //_DMLoaiHinh.Ma_BCTH = GetDMNhomChiPhi().Count;

            if (action == FormAction.EDIT)
            {
                //HTC.Business.DataProvider.Instance().UpdateDMNgheNghiep(maNN, tenNN, Pub_sMaMay, Pub_sNguoiSD);
                UpdateDMLoaiHinh(MaLH, TenLH, MaChungLoai, Ma_BCTH, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {
                //HTC.Business.DataProvider.Instance().InsertDMNgheNghiep(tenNN, Pub_sMaMay, Pub_sNguoiSD);
                InsertDMLoaiHinh(MaLH, TenLH, MaChungLoai, Ma_BCTH, Pub_sMaMay, Pub_sNguoiSD);
            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMLoaiHinh(Pub_sMaMay, Pub_sNguoiSD, MaLH);
                //HTC.Business.DataProvider.Instance().DeleteDMNgheNghiep(Pub_sMaMay, Pub_sNguoiSD, maBC);
            }



            _action = FormAction.INSERT;
            LoadDetail();

            ViewState[ViewState_DMLoaiHinhList] = null;
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
        if (DMLoaiHinhList != null)
        {
            grdChiTiet.DataSource = DMLoaiHinhList;
        }
    }



    public String InsertDMLoaiHinh(String _MaLH, String _TenLH, String _MaChungLoai, int _Ma_BCTH, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLoaiHinh_CREATE_130", _MaLH, _TenLH, _MaChungLoai, _Ma_BCTH, _maMay, _nguoiSD));
    }
    public void UpdateDMLoaiHinh(String _MaLH, String _TenLH, String _MaChungLoai, int _Ma_BCTH, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLoaiHinh_update_130", _MaLH, _TenLH, _MaChungLoai, _Ma_BCTH, _maMay, _nguoiSD);
    }

    public void DeleteDMLoaiHinh(String _maMay, String _nguoiSD, String _MaLH)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLoaiHinh_DELETED", _maMay, _nguoiSD, _MaLH);
    }
    [Serializable]
    public class DMLoaiHinhM
    {
        private String _MaLH = String.Empty;
        private String _TenLH = String.Empty;
        private String _MaChungLoai = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;
        private int _Ma_BCTH = 0;


        private int _OrderNumber;
        public String MaLH
        {
            get
            {
                return _MaLH;
            }
            set
            {
                if (_MaLH != value)
                {
                    _MaLH = value;
                }
            }
        }

        public String TenLH
        {
            get
            {
                return _TenLH;
            }
            set
            {
                if (_TenLH != value)
                {
                    _TenLH = value;
                }
            }
        }
        public String MaChungLoai
        {
            get
            {
                return _MaChungLoai;
            }
            set
            {
                if (_MaChungLoai != value)
                {
                    _MaChungLoai = value;
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
        public int Ma_BCTH
        {
            get
            {
                return _Ma_BCTH;
            }
            set
            {
                if (_Ma_BCTH != value)
                {
                    _Ma_BCTH = value;
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
        public DMLoaiHinhM(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaLH"].GetType().Name != "DBNull" && dr["MaLH"] != null)
            {
                this.MaLH = Convert.ToString(dr["MaLH"]);
            }
            else
            {
                this.MaLH = "";
            }
            if (dr["TenLH"].GetType().Name != "DBNull" && dr["TenLH"] != null)
            {
                this.TenLH = Convert.ToString(dr["TenLH"]);
            }
            else
            {
                this.TenLH = "";
            }
            if (dr["MaChungLoai"].GetType().Name != "DBNull" && dr["MaChungLoai"] != null)
            {
                this.MaChungLoai = Convert.ToString(dr["MaChungLoai"]);
            }
            else
            {
                this.MaChungLoai = "";
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


            if (dr["Ma_BCTH"] != DBNull.Value && dr["Ma_BCTH"] != null)
            {
                this.Ma_BCTH = Convert.ToInt32(dr["Ma_BCTH"]);
            }
            else
            {
                this.Ma_BCTH = 0;
            }



        }
        private static string ConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
            }
        }
        public static List<DMLoaiHinhM> GetDMLoaiHinhM()
        {
            List<DMLoaiHinhM> List = new List<DMLoaiHinhM>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMLoaiHinh_GetAll2")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMLoaiHinhM(dr, i));
                }
            }
            return List;
        }
    }




    private static string ConnectString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        }
    }
    public static List<DMNhomChiPhi> GetDMNhomChiPhi()
    {
        List<DMNhomChiPhi> List = new List<DMNhomChiPhi>();
        using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNhomChiPhi_GetAll")))
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                List.Add(new DMNhomChiPhi(dr, i));
            }
        }
        return List;
    }

    public class DMNhomChiPhi
    {
        private String _MaNhomCP = String.Empty;
        private String _TenNhomCP = String.Empty;
        private String _MaDuPhong = String.Empty;
        private String _TenDuPhong = String.Empty;
        private Byte _Loai = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;

        private int _OrderNumber;
        public String MaNhomCP
        {
            get
            {
                return _MaNhomCP;
            }
            set
            {
                if (_MaNhomCP != value)
                {
                    _MaNhomCP = value;
                }
            }
        }

        public String TenNhomCP
        {
            get
            {
                return _TenNhomCP;
            }
            set
            {
                if (_TenNhomCP != value)
                {
                    _TenNhomCP = value;
                }
            }
        }

        public String MaDuPhong
        {
            get
            {
                return _MaDuPhong;
            }
            set
            {
                if (_MaDuPhong != value)
                {
                    _MaDuPhong = value;
                }
            }
        }


        public String TenDuPhong
        {
            get
            {
                return _TenDuPhong;
            }
            set
            {
                if (_TenDuPhong != value)
                {
                    _TenDuPhong = value;
                }
            }
        }

        public Byte Loai
        {
            get
            {
                return _Loai;
            }
            set
            {
                if (_Loai != value)
                {
                    _Loai = value;
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
        public DMNhomChiPhi(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;
            // Value properties
            if (dr["MaNhomCP"].GetType().Name != "DBNull" && dr["MaNhomCP"] != null)
            {
                this.MaNhomCP = Convert.ToString(dr["MaNhomCP"]);
            }
            else
            {
                this.MaNhomCP = "";
            }
            if (dr["TenNhomCP"].GetType().Name != "DBNull" && dr["TenNhomCP"] != null)
            {
                this.TenNhomCP = Convert.ToString(dr["TenNhomCP"]);
            }
            else
            {
                this.TenNhomCP = "";
            }
            if (dr["MaDuPhong"].GetType().Name != "DBNull" && dr["MaDuPhong"] != null)
            {
                this.MaDuPhong = Convert.ToString(dr["MaDuPhong"]);
            }
            else
            {
                this.MaDuPhong = "";
            }


            if (dr["TenDuPhong"].GetType().Name != "DBNull" && dr["TenDuPhong"] != null)
            {
                this.TenDuPhong = Convert.ToString(dr["TenDuPhong"]);
            }
            else
            {
                this.TenDuPhong = "";
            }

            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
            {
                this.Loai = Convert.ToByte(dr["Loai"]);
            }
            else
            {
                this.Loai = 0;
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

    }



    protected void grdChiTiet_ItemCreated(object sender, GridItemEventArgs e)
    {
        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;

            RadComboBox list = (RadComboBox)edititem.FindControl("cboChiPhi");
            list.DataSource = GetDMNhomChiPhi();
            list.DataTextField = "TenNhomCP";
            list.DataValueField = "MaNhomCP";
            list.DataBind();         
            list.AutoPostBack = true;
           
        }
    }
    //[Serializable]
    //public  class DMLoaiHinh : BusinessBase<DMLoaiHinh>
    //{
    //    #region Business Methods

    //    #region State Fields
    //    private String _tenChungLoai = String.Empty;
    //    private String _maLH = String.Empty;
    //    private String _tenLH = String.Empty;
    //    private String _maChungLoai = String.Empty;
    //    private String _maMay = String.Empty;
    //    private Boolean _huy = false;
    //    private SmartDate _ngaySD = new SmartDate(true);
    //    private String _nguoiSD = String.Empty;
    //    private int _OrderNumber;
    //    private String _hoten = String.Empty;
    //    private int _Ma_BCTH;

    //    #endregion

    //    #region Business Properties and Methods


    //    public int Ma_BCTH
    //    {
    //        get
    //        {
    //            CanReadProperty("Ma_BCTH", true);
    //            return _Ma_BCTH;
    //        }
    //        set
    //        {
    //            CanWriteProperty("Ma_BCTH", true);
    //            if (_Ma_BCTH != value)
    //            {
    //                _Ma_BCTH = value;
    //                PropertyHasChanged("Ma_BCTH");
    //            }
    //        }
    //    }


    //    public String TenChungLoai
    //    {
    //        get
    //        {
    //            CanReadProperty("TenChungLoai", true);
    //            return _tenChungLoai;
    //        }
    //        set
    //        {
    //            CanWriteProperty("TenChungLoai", true);
    //            if (_tenChungLoai != value)
    //            {
    //                _tenChungLoai = value;
    //                PropertyHasChanged("TenChungLoai");
    //            }
    //        }
    //    }

    //    public String MaLH
    //    {
    //        get
    //        {
    //            CanReadProperty("MaLH", true);
    //            return _maLH;
    //        }
    //        set
    //        {
    //            CanWriteProperty("MaLH", true);
    //            if (_maLH != value)
    //            {
    //                _maLH = value;
    //                PropertyHasChanged("MaLH");
    //            }
    //        }
    //    }

    //    public String TenLH
    //    {
    //        get
    //        {
    //            CanReadProperty("TenLH", true);
    //            return _tenLH;
    //        }
    //        set
    //        {
    //            CanWriteProperty("TenLH", true);
    //            if (_tenLH != value)
    //            {
    //                _tenLH = value;
    //                PropertyHasChanged("TenLH");
    //            }
    //        }
    //    }

    //    public String MaChungLoai
    //    {
    //        get
    //        {
    //            CanReadProperty("MaChungLoai", true);
    //            return _maChungLoai;
    //        }
    //        set
    //        {
    //            CanWriteProperty("MaChungLoai", true);
    //            if (_maChungLoai != value)
    //            {
    //                _maChungLoai = value;
    //                PropertyHasChanged("MaChungLoai");
    //            }
    //        }
    //    }

    //    public String MaMay
    //    {
    //        get
    //        {
    //            CanReadProperty("MaMay", true);
    //            return _maMay;
    //        }
    //        set
    //        {
    //            CanWriteProperty("MaMay", true);
    //            if (_maMay != value)
    //            {
    //                _maMay = value;
    //                PropertyHasChanged("MaMay");
    //            }
    //        }
    //    }

    //    public Boolean Huy
    //    {
    //        get
    //        {
    //            CanReadProperty("Huy", true);
    //            return _huy;
    //        }
    //        set
    //        {
    //            CanWriteProperty("Huy", true);
    //            if (_huy != value)
    //            {
    //                _huy = value;
    //                PropertyHasChanged("Huy");
    //            }
    //        }
    //    }

    //    public string NgaySD
    //    {
    //        get
    //        {
    //            CanReadProperty("NgaySD", true);
    //            _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";

    //            return _ngaySD.Text;
    //        }
    //        set
    //        {
    //            CanWriteProperty("NgaySD", true);
    //            if (_ngaySD.Text != value)
    //            {
    //                _ngaySD.Text = value;
    //                PropertyHasChanged("NgaySD");
    //            }
    //        }
    //    }

    //    public String NguoiSD
    //    {
    //        get
    //        {
    //            CanReadProperty("NguoiSD", true);
    //            return _nguoiSD;
    //        }
    //        set
    //        {
    //            CanWriteProperty("NguoiSD", true);
    //            if (_nguoiSD != value)
    //            {
    //                _nguoiSD = value;
    //                PropertyHasChanged("NguoiSD");
    //            }
    //        }
    //    }
    //    public String hoten
    //    {
    //        get
    //        {
    //            CanReadProperty("hoten", true);
    //            return _hoten;
    //        }
    //        set
    //        {
    //            CanWriteProperty("hoten", true);
    //            if (_hoten != value)
    //            {
    //                _hoten = value;
    //                PropertyHasChanged("hoten");
    //            }
    //        }
    //    }
    //    public int OrderNumber
    //    {
    //        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    //        get
    //        {
    //            CanReadProperty(true);
    //            return _OrderNumber;
    //        }
    //        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    //        set
    //        {
    //            //CanWriteProperty(true);
    //            if (!_OrderNumber.Equals(value))
    //            {
    //                _OrderNumber = value;
    //                //PropertyHasChanged();
    //            }
    //        }
    //    }
    //    protected override Object GetIdValue()
    //    {
    //        return _maLH;
    //    }

    //    #endregion
    //    #endregion


    //    #region Business Object Rules and Validation
    //    protected override void AddBusinessRules()
    //    {

    //        //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
    //        ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenLH", 150));
    //        ValidationRules.AddRule<DMLoaiHinh>(StringRequired<DMLoaiHinh>, "TenLH");


    //    }

    //    private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLoaiHinh
    //    {

    //        if (target._tenLH == null || target._tenLH.Trim().Length == 0)
    //        {
    //            e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
    //            return false;
    //        }
    //        else
    //            return true;
    //    }
    //    #endregion

    //    #region Factory Methods


    //    /// <summary>
    //    /// Factory method. New <see cref="DMLoaiHinh" /> Object is loaded from the database, based on given parameters.
    //    /// </summary> 
    //    /// 
    //    public static DMLoaiHinh NewDMLoaiHinh()
    //    {
    //        //return new DMNhomThuoc();
    //        return DataPortal.Create<DMLoaiHinh>();
    //    }

    //    public static DMLoaiHinh GetDMLoaiHinh(String maLH)
    //    {
    //        return DataPortal.Fetch<DMLoaiHinh>(new Criteria(maLH));
    //    }

    //    /// <summary>
    //    /// Marks the <see cref="DMLoaiHinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
    //    /// </summary>
    //    public static void DeleteDMLoaiHinh(String maLH, string mamay, string nguoihuy)
    //    {
    //        DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maLH));
    //    }

    //    #endregion

    //    #region Constructors
    //    // Chu y !!!
    //    // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
    //    // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
    //    protected internal DMLoaiHinh()
    //    {
    //        // Prevent direct creation
    //    }
    //    internal DMLoaiHinh(int ordernumber, String maNT, String tenNT, String maChungLoai, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten, string tenchungloai, int Ma_BCTH)
    //    {
    //        _OrderNumber = ordernumber;
    //        _maLH = maNT;
    //        _tenLH = tenNT;
    //        _maChungLoai = maChungLoai;
    //        _maMay = maMay;
    //        _huy = huy;
    //        _ngaySD = ngaySD;
    //        _nguoiSD = nguoiSD;
    //        _hoten = hoten;
    //        _tenChungLoai = tenchungloai;
    //        _Ma_BCTH = Ma_BCTH;
    //    }
    //    #endregion

    //    #region Criteria

    //    [Serializable()]
    //    protected class Criteria
    //    {
    //        private String _maLH;
    //        public String MaLH
    //        {
    //            get
    //            {
    //                return _maLH;
    //            }
    //        }

    //        public Criteria(String maLH)
    //        {
    //            _maLH = maLH;
    //        }

    //        public override bool Equals(object obj)
    //        {
    //            if (obj is Criteria)
    //            {
    //                Criteria c = (Criteria)obj;
    //                if (!_maLH.Equals(c._maLH))
    //                    return false;
    //                return true;
    //            }
    //            return false;
    //        }

    //        public override int GetHashCode()
    //        {
    //            return string.Concat("Criteria", _maLH.ToString()).GetHashCode();
    //        }
    //    }

    //    [Serializable()]
    //    protected class OtherCriteria
    //    {
    //        private String _maLH;
    //        public String maLH
    //        {
    //            get
    //            {
    //                return _maLH;
    //            }
    //        }

    //        private String _maMay;
    //        public String MaMay
    //        {
    //            get
    //            {
    //                return _maMay;
    //            }
    //        }

    //        private String _NguoiSD;
    //        public String NguoiSD
    //        {
    //            get
    //            {
    //                return _NguoiSD;
    //            }
    //        }
    //        public OtherCriteria(String Mamay, String Nguoisd, String maLH)
    //        {
    //            _maLH = maLH;
    //            _maMay = Mamay;
    //            _NguoiSD = Nguoisd;
    //        }
    //    }

    //    #endregion

    //    #region Authorization

    //    public static bool CanGetObject()
    //    {
    //        return true;
    //    }

    //    public static bool CanDeleteObject()
    //    {
    //        return true;
    //    }

    //    public static bool CanAddObject()
    //    {
    //        return true;
    //    }

    //    public static bool CanEditObject()
    //    {
    //        return true;
    //    }

    //    #endregion

    //    #region Data Access

    //    /// <summary>
    //    /// Retrieve an existing <see cref="DMLoaiHinh" /> Object based on data in the database.
    //    /// </summary>
    //    protected void DataPortal_Fetch(Criteria crit)
    //    {
    //        // public abstract IDataReader GetDMLoaiHinh(String _maLH);
    //        // public override IDataReader GetDMLoaiHinh(String _maLH)
    //        // {
    //        //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLH));
    //        // }
    //        using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLoaiHinh(crit.MaLH)))
    //        {
    //            if (dr.Read())
    //            {
    //                Fetch(dr);
    //                MarkOld();
    //                ValidationRules.CheckRules();
    //            }
    //        }
    //    }
    //    /// <summary>
    //    /// Load a <see cref="DMLoaiHinh" /> Object from given SafeDataReader.
    //    /// </summary>
    //    private void Fetch(SafeDataReader dr)
    //    {
    //        // Value properties
    //        if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
    //        if (dr.GetString("TenLH") != null) _tenLH = dr.GetString("TenLH");
    //        if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
    //        if (dr.GetString("TenChungLoai") != null) _tenChungLoai = dr.GetString("TenChungLoai");

    //        if (dr.GetInt32("Ma_BCTH") != null) _Ma_BCTH = dr.GetInt32("Ma_BCTH");

    //        if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
    //        if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
    //        if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
    //        if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
    //    }

    //    /// <summary>
    //    /// Insert the new <see cref="DMLoaiHinh" /> Object to underlying database.
    //    /// </summary>
    //    /// 
    //    protected override void DataPortal_Create()
    //    {
    //        ValidationRules.CheckRules();
    //    }
    //    //protected override void DataPortal_Insert()
    //    //{
    //    //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLoaiHinh
    //    //    // Copy & paste ham duoi day vao file DataProvider.cs


    //    //    _maLH = DataProvider.Instance().InsertDMLoaiHinh(_tenLH, _maChungLoai, _maMay, _nguoiSD);
    //    //    // public abstract String InsertDMLoaiHinh(String _tenLH, String _maChungLoai, String _maMay, String _nguoiSD);
    //    //    // public override String InsertDMLoaiHinh(String _tenLH, String _maChungLoai, String _maMay, String _nguoiSD);
    //    //    // {
    //    //    //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenLH, _maChungLoai, _maMay, _nguoiSD), String);
    //    //    // }
    //    //}

    //    ///// <summary>
    //    ///// Update all changes made on <see cref="DMLoaiHinh" /> Object to underlying database.
    //    ///// </summary>
    //    //protected override void DataPortal_Update()
    //    //{
    //    //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiHinh
    //    //    if (IsDirty)
    //    //    {


    //    //        DataProvider.Instance().UpdateDMLoaiHinh(_maLH, _tenLH, _maChungLoai, _maMay, _huy, _nguoiSD);
    //    //        // public abstract void UpdateDMLoaiHinh(String _maLH, String _tenLH, String _maChungLoai, String _maMay, Boolean _huy, String _nguoiSD);
    //    //        // public override void UpdateDMLoaiHinh(String _maLH, String _tenLH, String _maChungLoai, String _maMay, Boolean _huy, String _nguoiSD);
    //    //        // {
    //    //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLH, _tenLH, _maChungLoai, _maMay, _huy, _nguoiSD);
    //    //        // }				
    //    //    }
    //    //}
    //    //protected override void DataPortal_DeleteSelf()
    //    //{
    //    //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maLH));
    //    //}

    //    ///// <summary>
    //    ///// Delete the <see cref="DMLoaiHinh" />.
    //    ///// </summary>
    //    //protected void DataPortal_Delete(OtherCriteria crit)
    //    //{
    //    //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiHinh
    //    //    DataProvider.Instance().DeleteDMLoaiHinh(crit.MaMay, crit.NguoiSD, crit.maLH);
    //    //    // public abstract void DeleteDMLoaiHinh(String _maLH);
    //    //    // public override void DeleteDMLoaiHinh(String _maLH);
    //    //    // {
    //    //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLH);
    //    //    // }
    //    //}

    //    #endregion
    //}

}