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


public partial class UI_Category_DMHanhChinh_frmDMLoaiHinhKCB : HTC.Common.Web.WebBase
{
    private const string ViewState_DMLoaiHinhKCBList = "DMLoaiHinhKCB";


    public List<DMLoaiHinhKCB> DMLoaiHinhKCBList
    {
        get
        {
            if (ViewState[ViewState_DMLoaiHinhKCBList] == null)
            {
                ViewState[ViewState_DMLoaiHinhKCBList] = DMLoaiHinhKCB.GetDMLoaiHinhKCB();
            }

            return (List<DMLoaiHinhKCB>)ViewState[ViewState_DMLoaiHinhKCBList];
        }

        set
        {
            ViewState[ViewState_DMLoaiHinhKCBList] = value;
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
        grdChiTiet.DataSource = DMLoaiHinhKCBList;
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

        
        string MA_LOAI_KCB = string.Empty;

        if (action != FormAction.INSERT)
        {
            MA_LOAI_KCB = editedItem.GetDataKeyValue("MA_LOAI_KCB").ToString();
            
        }



        byte LoaiBN = 0;

        string TEN_LOAI_KCB = string.Empty;
        if (action != FormAction.DELETE)
        {
            if (ValidateForm(editedItem) == false)
            {
                return false;
            }


            TEN_LOAI_KCB = ((TextBox)editedItem["TEN_LOAI_KCB"].Controls[0]).Text;
            LoaiBN = byte.Parse(((TextBox)editedItem["LoaiBN"].Controls[0]).Text);

        }



        try
        {
            if (action == FormAction.EDIT)
            {
                //HTC.Business.DataProvider.Instance().UpdateDMNgheNghiep(maNN, tenNN, Pub_sMaMay, Pub_sNguoiSD);                
                UpdateDMLoaiHinhKCB(MA_LOAI_KCB, TEN_LOAI_KCB, LoaiBN, Pub_sMaMay, Pub_sNguoiSD);

            }
            else if (action == FormAction.INSERT)
            {
                //HTC.Business.DataProvider.Instance().InsertDMLoaiHinhKCB(TEN_LOAI_KCB, Pub_sMaMay, Pub_sNguoiSD);

                InsertDMLoaiHinhKCB(TEN_LOAI_KCB, LoaiBN, Pub_sMaMay, Pub_sNguoiSD);


                //string sql = "update DMLoaiHinhKCB set TEN_LOAI_KCB =N" + TEN_LOAI_KCB + " where MA_LOAI_KCB ='" + MA_LOAI_KCB + "'";
                //HTC.Business.DataProvider.Instance().ExcSQL(sql);


            }
            else if (action == FormAction.DELETE)
            {
                DeleteDMLoaiHinhKCB(Pub_sMaMay, Pub_sNguoiSD, MA_LOAI_KCB);
                //HTC.Business.DataProvider.Instance().DeleteDMNgheNghiep(Pub_sMaMay, Pub_sNguoiSD, maBC);
            }

            ViewState[ViewState_DMLoaiHinhKCBList] = null;
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
        if (DMLoaiHinhKCBList != null)
        {
            grdChiTiet.DataSource = DMLoaiHinhKCBList;
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
    public String InsertDMLoaiHinhKCB(String _TEN_LOAI_KCB, Byte _loaiBN, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLoaiHinhKCB_CREATE", _TEN_LOAI_KCB, _loaiBN, _maMay, _nguoiSD));
    }
    public void UpdateDMLoaiHinhKCB(String _MA_LOAI_KCB, String _TEN_LOAI_KCB, Byte _loaiBN, string _maMay, String _nguoiSD)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLoaiHinhKCB_update", _MA_LOAI_KCB, _TEN_LOAI_KCB, _loaiBN, _maMay, _nguoiSD);
    }

    public void DeleteDMLoaiHinhKCB(String _maMay, String _nguoiSD, String _MA_LOAI_KCB)
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string DatabaseOwner = "dbo.";
        string ObjectQualifier = "";
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLoaiHinhKCB_DELETED", _maMay, _nguoiSD, _MA_LOAI_KCB);
    }
    [Serializable]
    public class DMLoaiHinhKCB
    {
        private String _MA_LOAI_KCB = String.Empty;
        private String _TEN_LOAI_KCB = String.Empty;
        private byte _loaiBN = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private DateTime _ngaySD;
        private String _nguoiSD = String.Empty;

        private int _OrderNumber;
        public String MA_LOAI_KCB
        {
            get
            {
                return _MA_LOAI_KCB;
            }
            set
            {
                if (_MA_LOAI_KCB != value)
                {
                    _MA_LOAI_KCB = value;
                }
            }
        }

        public String TEN_LOAI_KCB
        {
            get
            {
                return _TEN_LOAI_KCB;
            }
            set
            {
                if (_TEN_LOAI_KCB != value)
                {
                    _TEN_LOAI_KCB = value;
                }
            }
        }

        public Byte LoaiBN
        {
            get
            {
                return _loaiBN;
            }
            set
            {
                if (_loaiBN != value)
                {
                    _loaiBN = value;
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
        public DMLoaiHinhKCB(IDataReader dr, int stt)
        {
            this.OrderNumber = stt;

            if (dr["MA_LOAI_KCB"].GetType().Name != "DBNull" && dr["MA_LOAI_KCB"] != null)
            {
                this.MA_LOAI_KCB = Convert.ToString(dr["MA_LOAI_KCB"]);
            }
            else
            {
                this.MA_LOAI_KCB = "";
            }
            if (dr["TEN_LOAI_KCB"].GetType().Name != "DBNull" && dr["TEN_LOAI_KCB"] != null)
            {
                this.TEN_LOAI_KCB = Convert.ToString(dr["TEN_LOAI_KCB"]);
            }
            else
            {
                this.TEN_LOAI_KCB = "";
            }
            if (dr["LoaiBN"].GetType().Name != "DBNull" && dr["LoaiBN"] != null)
            {
                this.LoaiBN = Convert.ToByte(dr["LoaiBN"]);
            }
            else
            {
                this.LoaiBN = 0;
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
        public static List<DMLoaiHinhKCB> GetDMLoaiHinhKCB()
        {
            List<DMLoaiHinhKCB> List = new List<DMLoaiHinhKCB>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMLoaiHinhKCB_GetAll")))
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    List.Add(new DMLoaiHinhKCB(dr,i));
                }
            }
            return List;
        }
    }
}