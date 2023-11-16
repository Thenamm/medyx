using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.BusinessObject.CategoryList;
using Telerik.Web.UI;
using FlexCel.XlsAdapter;
using System.IO;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

public partial class UI_Category_DMTBYT_frmDMTuongTac : HTC.Common.Web.WebBase
{
    public DMTuongTacs _DMTuongTacs
    {
        get
        {
            if(ViewState["DMTuongTacs"] == null)
            {
                ViewState["DMTuongTacs"] = new DMTuongTacs();
            }
            return (DMTuongTacs)ViewState["DMTuongTacs"];
        }

        set
        {
            ViewState["DMTuongTacs"] = value;
        }
    }
    private const string ViewState_FilterSql = "_FilterSql";
    public string _FilterSql
    {
        get
        {
            if (ViewState[ViewState_FilterSql] == null)
            {
                ViewState[ViewState_FilterSql] = "";
            }

            return (string)ViewState[ViewState_FilterSql];
        }

        set
        {
            ViewState[ViewState_FilterSql] = value;
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_MUC_ONLY;            
            SetData();
        }
    }
    protected void baraction_ButtonClick(object sender, Telerik.Web.UI.RadToolBarEventArgs e)
    {
        if (e.Item.Visible == true && e.Item.Enabled == true)
        {
            switch (e.Item.Value)
            {
                case "cmdAdd":
                    grdChiTiet.MasterTableView.IsItemInserted = true;
                    grdChiTiet.DataSource = _DMTuongTacs;
                    grdChiTiet.DataBind();
                    break;

                case "cmdExit":
                    Response.Redirect("~/Default.aspx");
                    break;
                case "cmdFilter":
                    grdChiTiet.MasterTableView.AllowFilteringByColumn = !grdChiTiet.MasterTableView.AllowFilteringByColumn;
                    grdChiTiet.DataSource = _DMTuongTacs;
                    grdChiTiet.DataBind();
                    break;
                case "cmdExportData":
                    //ExportExcel("ExportExcel.xls");
                    break;
                case "cmdUploadData":
                    //ImportExcel("ImportExcel.xls");
                    break;
                default:
                    break;
            }
        }
    }
    //public void ExportExcel(string fileSavePath)
    //{
    //    XlsFile Result = new XlsFile();
    //    String[] arrHeader = new String[] { grdChiTiet.MasterTableView.Columns[3].HeaderText, grdChiTiet.MasterTableView.Columns[4].HeaderText, grdChiTiet.MasterTableView.Columns[5].HeaderText, grdChiTiet.MasterTableView.Columns[6].HeaderText };
    //    if (!Directory.Exists(Server.MapPath("Temp")))
    //    {
    //        Directory.CreateDirectory(Server.MapPath("Temp"));
    //    }

    //    if (File.Exists(Server.MapPath("Temp") + "\\" + fileSavePath))
    //    {
    //        File.Delete(Server.MapPath("Temp") + "\\" + fileSavePath);
    //        //Result.Open(Server.MapPath("Temp") + "\\" + fileSavePath);
    //        //Result.AllowOverwritingFiles = true;
    //    }
    //    Result.NewFile(1);

    //    Result.SetCellValue(1, 1, Pub_sTenMN.ToUpper());
    //    Result.SetCellValue(2, 1, "Người lập: " + Pub_sTenNguoiSD);
    //    Result.SetCellValue(3, 1, "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy"));

    //    for (int i = 1; i <= arrHeader.Length; i++)
    //    {
    //        Result.SetCellValue(4, i, arrHeader[i - 1]);
    //    }


    //    List<DMTuongTac> listData = DMTuongTac.GetAll(Loai, pub_bQadmin);
    //    int oderRow = 5;

    //    foreach (var ItemValue in listData)
    //    {
    //        arrHeader = new String[] { ItemValue.MaNguon, ItemValue.TenNguon, ItemValue.VienTro.ToString(), ItemValue.GhiChu };
    //        for (int i = 1; i <= arrHeader.Length; i++)
    //        {
    //            Result.SetCellValue(oderRow, i, arrHeader[i - 1]);
    //        }
    //        oderRow++;
    //    }
    //    Result.Save(Server.MapPath("Temp") + "\\" + fileSavePath);
    //    string popupScript;
    //    popupScript = " <script language='javascript'>" + "window.open(\"Temp/" + fileSavePath + "\");</script>";
    //    Context.Response.Write(popupScript);
    //}
    //public void ImportExcel(string fileSavePath)
    //{
    //    try
    //    {
    //        FileUpload file = this.baraction.Items[3].FindControl("FileUpload1") as FileUpload;
    //        if (file.HasFile)
    //        {
    //            if (CheckFileType(file.FileName))
    //            {
    //                file.SaveAs(Server.MapPath("Temp") + "\\" + fileSavePath);
    //            }
    //            else
    //            {
    //                return;
    //            }
    //        }
    //        else
    //        {
    //            ShowMessage("Yêu cầu upload file excel");
    //            return;
    //        }
    //        XlsFile Result = new XlsFile();
    //        Result.Open(Server.MapPath("Temp") + "\\" + fileSavePath); // Mở file

    //        int row = 4;
    //        int col = 1;
    //        int colfinish = 0;
    //        while (Result.GetCellValue(row, col) != null)
    //        {
    //            colfinish++;
    //            col++;
    //        }

    //        col = 1;
    //        row++;
    //        String[] arrItem = new String[colfinish];
    //        while (true)
    //        {
    //            Boolean bfinish = true;
    //            for (col = 1; col <= colfinish; col++)
    //            {
    //                if (Result.GetCellValue(row, col) != null)
    //                {
    //                    bfinish = false;
    //                    arrItem[col - 1] = Result.GetCellValue(row, col).ToString();
    //                }
    //                else
    //                {
    //                    arrItem[col - 1] = "";
    //                }
    //            }

    //            if (bfinish)
    //            {
    //                _DMTuongTac = null;
    //                grdChiTiet.DataSource = _DMTuongTac;
    //                grdChiTiet.DataBind();
    //                return;
    //            }
    //            else
    //            {
    //                row++;
    //                if (arrItem[0] != "")
    //                {
    //                    if (DMTuongTac.Edit(arrItem[0], arrItem[1], "", Convert.ToBoolean(arrItem[2]), false,  arrItem[2], Pub_sMaMay, Loai, false, Pub_sNguoiSD) == "ERROR")
    //                    {
    //                        ShowMessage("Tên bị trùng. Yêu cầu nhập lại tên");
    //                        return;
    //                    }
    //                }
    //                else
    //                {
    //                    if (DMTuongTac.Add(arrItem[1], "", Convert.ToBoolean(arrItem[2]), false, arrItem[3], Pub_sMaMay, Loai, Pub_sNguoiSD) == "ERROR")
    //                    {
    //                        ShowMessage("Tên bị trùng. Yêu cầu nhập lại tên");
    //                        return;
    //                    }
    //                }

    //            }
    //        }
    //    }
    //    catch
    //    {
    //        ShowMessage("Upload không thành công!");
    //    }
    //}
    bool CheckFileType(string fileName)
    {
        string ext = Path.GetExtension(fileName);
        switch (ext.ToLower())
        {
            case ".xls":
                return true;
            case ".xlsx":
                return true;
            default:
                ShowMessage("Yêu cầu nhập file excel có đuôi: .xls, .xlsx");
                return false;
        }

    }

    protected void grdChiTiet_ItemCreated(object sender, GridItemEventArgs e)
    {
        if (e.Item is IGridInsertItem)
        {
            ((e.Item as GridEditableItem)["TenGoc1"].FindControl("cboDMThuoc1")).Focus();
        }
    }
    private void SetData()
    {
        _DMTuongTacs = DMTuongTacs.Find(_FilterSql, pub_bQadmin, 0, grdChiTiet.PageSize);
        if (_DMTuongTacs != null)
        {
            grdChiTiet.VirtualItemCount = _DMTuongTacs.CountRowTotal;
            grdChiTiet.DataSource = _DMTuongTacs;
        }
        else
        {
            grdChiTiet.VirtualItemCount = 0;
            grdChiTiet.DataSource = "";
        }
        grdChiTiet.DataBind();
    }

    private Boolean UpdateData(GridEditableItem ItemData, FormAction Action)
    {
        DMTuongTac _dmTuongTac = new DMTuongTac();
        if (Action != FormAction.INSERT)
        {
            _dmTuongTac = _DMTuongTacs.Find(x => x.STT.Equals(int.Parse(ItemData.GetDataKeyValue("STT").ToString())));
        }

        if (Action != FormAction.DELETE)
        {
            _dmTuongTac.TenGoc1 = (ItemData["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).SelectedValue;
            if (String.IsNullOrEmpty(_dmTuongTac.TenGoc1))
            {
                ShowMessage("Yêu cầu nhập tên gốc 1");
                (ItemData["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).Focus();
                return false;
            }

            _dmTuongTac.TenGoc2 = (ItemData["TenGoc2"].FindControl("cboDMThuoc2") as RadComboBox).SelectedValue;
            if (String.IsNullOrEmpty(_dmTuongTac.TenGoc1))
            {
                ShowMessage("Yêu cầu nhập tên gốc 2");
                (ItemData["TenGoc2"].FindControl("cboDMThuoc2") as RadComboBox).Focus();
                return false;
            }

            _dmTuongTac.TenGoc3 = (ItemData["TenGoc3"].FindControl("cboDMThuoc3") as RadComboBox).SelectedValue;
            _dmTuongTac.TuongTacThuoc = (ItemData["TuongTacThuoc"].Controls[0] as TextBox).Text;
            _dmTuongTac.MoTa = (ItemData["MoTa"].Controls[0] as TextBox).Text;

            _dmTuongTac.MucDo = Byte.Parse((ItemData["MucDo"].Controls[0] as RadNumericTextBox).Text);
            if (_dmTuongTac.MucDo < 0 || _dmTuongTac.MucDo > 9)
            {
                ShowMessage("Yêu cầu nhập mức độ trong khoảng từ 0 đến 9");
                (ItemData["MucDo"].Controls[0] as RadNumericTextBox).Focus();
                return false;
            }
        }
        _dmTuongTac.MaMay = Pub_sMaMay;
        _dmTuongTac.NguoiLap = Pub_sNguoiSD;
        _dmTuongTac.NguoiSD = Pub_sNguoiSD;
        _dmTuongTac.NguoiHuy = Pub_sNguoiSD;

        if (Action != FormAction.DELETE)
        {
            String temp = _dmTuongTac.Update();
            if (temp != "")
            {
                ShowMessage(temp);
                (ItemData["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).Focus();
                return false;
            }
            return true;
        }
        else
        {
            _dmTuongTac.Delete();
            return true;
        }
    }

    protected void grdChiTiet_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        if (_DMTuongTacs != null)
        {
            grdChiTiet.DataSource = _DMTuongTacs;
            grdChiTiet.VirtualItemCount = _DMTuongTacs.CountRowTotal;
        }
        else
        {
            grdChiTiet.DataSource = "";
            grdChiTiet.VirtualItemCount = 0;
        }
    }
    protected void grdChiTiet_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        if (e.CommandName == "PerformInsert")
        {
            GridEditableItem ItemData = e.Item as GridEditableItem;
            if (UpdateData(ItemData, FormAction.INSERT))
            {
                SetData();
            }
            else
            {
                e.Canceled = true;
            }
        }
        else if (e.CommandName == "Update")
        {
            GridEditableItem ItemData = e.Item as GridEditableItem;
            if (UpdateData(ItemData, FormAction.EDIT))
            {
                SetData();
            }
            else
            {
                e.Canceled = true;
            }
        }
        else if (e.CommandName == "Delete")
        {
            GridEditableItem ItemData = e.Item as GridEditableItem;
            if (UpdateData(ItemData, FormAction.DELETE))
            {
                SetData();
            }           
        }
        else if (e.CommandName == RadGrid.FilterCommandName)
        {
            GridFilteringItem item = (e.Item as GridFilteringItem);
            TextBox filterTenGoc1 = item["TenGoc1"].Controls[0] as TextBox;
            TextBox filterTenGoc2 = item["TenGoc2"].Controls[0] as TextBox;
            TextBox filterTenGoc3 = item["TenGoc3"].Controls[0] as TextBox;
            TextBox filterSTT = item["OrderNumber"].Controls[0] as TextBox;
            RadNumericTextBox filterMucDo = item["MucDo"].Controls[0] as RadNumericTextBox;
            TextBox filterMoTa = item["MoTa"].Controls[0] as TextBox;
            TextBox filterTuongTacThuoc = item["TuongTacThuoc"].Controls[0] as TextBox;
            TextBox filterTenNguoiLap = item["TenNguoiLap"].Controls[0] as TextBox;
            TextBox filterTenNguoiSD = item["TenNguoiSD"].Controls[0] as TextBox;
            _FilterSql = "";
            if (filterTenGoc1.Text != "")
            {
                _FilterSql = _FilterSql + "and a.TenGoc1 like N'%" + filterTenGoc1.Text + "%'";
            }
            if (filterTenGoc2.Text != "")
            {
                _FilterSql = _FilterSql + "and a.TenGoc2 like N'%" + filterTenGoc2.Text + "%'";
            }
            if (filterTenGoc3.Text != "")
            {
                _FilterSql = _FilterSql + "and a.TenGoc3 like N'%" + filterTenGoc3.Text + "%'";
            }
            if (filterSTT.Text != "")
            {
                _FilterSql = _FilterSql + "and a.STT like N'%" + filterSTT.Text + "%'";
            }
            if (filterMucDo.Text != "")
            {
                _FilterSql = _FilterSql + "and a.MucDo like N'%" + filterMucDo.Text + "%'";
            }
            if (filterMoTa.Text != "")
            {
                _FilterSql = _FilterSql + "and a.MoTa = '" + filterMoTa.Text + "'";
            }


            if (filterTuongTacThuoc.Text != "")
            {
                _FilterSql = _FilterSql + "and a.TuongTacThuoc = '" + filterTuongTacThuoc.Text + "'";
            }



            if (filterTenNguoiLap.Text != "")
            {
                _FilterSql = _FilterSql + "and NV1.HoTen = '" + filterTenNguoiLap.Text + "'";
            }

            if (filterTenNguoiSD.Text != "")
            {
                _FilterSql = _FilterSql + "and NV2.HoTen = '" + filterTenNguoiSD.Text + "'";
            }
            
            if (_FilterSql != "")
                _FilterSql = " " + _FilterSql;
            grdChiTiet.CurrentPageIndex = 0;

            _DMTuongTacs = DMTuongTacs.Find(_FilterSql, pub_bQadmin, grdChiTiet.CurrentPageIndex, grdChiTiet.PageSize);
            if (_DMTuongTacs != null)
            {
                grdChiTiet.VirtualItemCount = _DMTuongTacs.CountRowTotal;
                grdChiTiet.DataSource = _DMTuongTacs;
            }
            else
            {
                grdChiTiet.VirtualItemCount = 0;
                grdChiTiet.DataSource = "";
            }
            grdChiTiet.DataBind();
        }

    }
    protected void grdChiTiet_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
    {
        if (e.Item.IsInEditMode && e.Item is GridEditableItem)
        {
            GridEditableItem item = e.Item as GridEditableItem;
            InitTabIndexForRadGrid(((RadGrid)sender), item, 4);

            if (item.ItemIndex != -1)
            {
                ((e.Item as GridEditableItem)["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).Focus();
            }
            else if (grdChiTiet.EditItems.Count > 0)
            {
                e.Item.FireCommandEvent(RadGrid.CancelCommandName, string.Empty);
            }
            else
            {
                ((e.Item as GridEditableItem)["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).Focus();
            }

            if(!(e.Item is IGridInsertItem))
            {
                DMTuongTac _dmTuongTac = _DMTuongTacs.Find(x => x.STT.Equals(int.Parse((e.Item as GridEditableItem).GetDataKeyValue("STT").ToString())));
                ((e.Item as GridEditableItem)["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).SelectedValue = _dmTuongTac.TenGoc1;
                ((e.Item as GridEditableItem)["TenGoc1"].FindControl("cboDMThuoc1") as RadComboBox).Text = _dmTuongTac.TenGoc1;

                ((e.Item as GridEditableItem)["TenGoc2"].FindControl("cboDMThuoc2") as RadComboBox).SelectedValue = _dmTuongTac.TenGoc2;
                ((e.Item as GridEditableItem)["TenGoc2"].FindControl("cboDMThuoc2") as RadComboBox).Text = _dmTuongTac.TenGoc2;

                ((e.Item as GridEditableItem)["TenGoc3"].FindControl("cboDMThuoc3") as RadComboBox).SelectedValue = _dmTuongTac.TenGoc3;
                ((e.Item as GridEditableItem)["TenGoc3"].FindControl("cboDMThuoc3") as RadComboBox).Text = _dmTuongTac.TenGoc3;
            }
        }
    }

    protected void grdChiTiet_PageIndexChanged(object sender, GridPageChangedEventArgs e)
    {
        _DMTuongTacs = DMTuongTacs.Find(_FilterSql, pub_bQadmin, e.NewPageIndex, grdChiTiet.PageSize);
        if (_DMTuongTacs != null)
        {
            grdChiTiet.VirtualItemCount = _DMTuongTacs.CountRowTotal;
            grdChiTiet.DataSource = _DMTuongTacs;
        }
        else
        {
            grdChiTiet.VirtualItemCount = 0;
            grdChiTiet.DataSource = "";
        }
        grdChiTiet.DataBind();
    }

    protected void grdChiTiet_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
    {
        _DMTuongTacs = DMTuongTacs.Find(_FilterSql, pub_bQadmin, grdChiTiet.CurrentPageIndex, e.NewPageSize);
        if (_DMTuongTacs != null)
        {
            grdChiTiet.VirtualItemCount = _DMTuongTacs.CountRowTotal;
            grdChiTiet.DataSource = _DMTuongTacs;
        }
        else
        {
            grdChiTiet.VirtualItemCount = 0;
            grdChiTiet.DataSource = "";
        }
        grdChiTiet.DataBind();
    }



    [Serializable()]
    public class DMTuongTac
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Int32 STT { get; set; }
        public String TenGoc1 { get; set; }
        public String TenGoc2 { get; set; }
        public String TenGoc3 { get; set; }
        public String TuongTacThuoc { get; set; }
        public Byte MucDo { get; set; }
        public String MoTa { get; set; }
        public String MaMay { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String MaThuoc1 { get; set; }
        public String TenThuoc1 { get; set; }
        public String MaThuoc2 { get; set; }
        public String TenThuoc2 { get; set; }
        public String MaThuoc3 { get; set; }
        public String TenThuoc3 { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }

        public DMTuongTac()
        {
            STT = 0;
            TenGoc1 = "";
            TenGoc2 = "";
            TenGoc3 = "";
            TuongTacThuoc = "";
            MucDo = 0;
            MoTa = "";
            MaMay = "";
            NgayHuy = "";
            NguoiHuy = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            MaThuoc1 = "";
            TenThuoc1 = "";
            MaThuoc2 = "";
            TenThuoc2 = "";
            MaThuoc3 = "";
            TenThuoc3 = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            Ordernumber = 0;
        }

        public DMTuongTac(Int32 STT, String TenGoc1, String TenGoc2, String TenGoc3,string TuongTacThuoc, Byte MucDo, String MoTa, String MaMay, String NgayHuy, String NguoiHuy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String MaThuoc1, String TenThuoc1, String MaThuoc2, String TenThuoc2, String MaThuoc3, String TenThuoc3, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 Ordernumber)
        {
            this.STT = STT;
            this.TenGoc1 = TenGoc1;
            this.TenGoc2 = TenGoc2;
            this.TenGoc3 = TenGoc3;
            this.TuongTacThuoc = TuongTacThuoc;
            this.MucDo = MucDo;
            this.MoTa = MoTa;
            this.MaMay = MaMay;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.MaThuoc1 = MaThuoc1;
            this.TenThuoc1 = TenThuoc1;
            this.MaThuoc2 = MaThuoc2;
            this.TenThuoc2 = TenThuoc2;
            this.MaThuoc3 = MaThuoc3;
            this.TenThuoc3 = TenThuoc3;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.Ordernumber = Ordernumber;
        }
        public DMTuongTac(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
            {
                this.STT = Convert.ToInt32(dr["STT"]);
            }
            else
            {
                this.STT = 0;
            }
            if (dr["TenGoc1"].GetType().Name != "DBNull" && dr["TenGoc1"] != null)
            {
                this.TenGoc1 = Convert.ToString(dr["TenGoc1"]);
            }
            else
            {
                this.TenGoc1 = "";
            }
            if (dr["TenGoc2"].GetType().Name != "DBNull" && dr["TenGoc2"] != null)
            {
                this.TenGoc2 = Convert.ToString(dr["TenGoc2"]);
            }
            else
            {
                this.TenGoc2 = "";
            }
            if (dr["TenGoc3"].GetType().Name != "DBNull" && dr["TenGoc3"] != null)
            {
                this.TenGoc3 = Convert.ToString(dr["TenGoc3"]);
            }
            else
            {
                this.TenGoc3 = "";
            }


            if (dr["TuongTacThuoc"].GetType().Name != "DBNull" && dr["TuongTacThuoc"] != null)
            {
                this.TuongTacThuoc = Convert.ToString(dr["TuongTacThuoc"]);
            }
            else
            {
                this.TuongTacThuoc = "";
            }



            if (dr["MucDo"].GetType().Name != "DBNull" && dr["MucDo"] != null)
            {
                this.MucDo = Convert.ToByte(dr["MucDo"]);
            }
            else
            {
                this.MucDo = 0;
            }
            if (dr["MoTa"].GetType().Name != "DBNull" && dr["MoTa"] != null)
            {
                this.MoTa = Convert.ToString(dr["MoTa"]);
            }
            else
            {
                this.MoTa = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHuy = "";
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            {
                this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            }
            else
            {
                this.NguoiHuy = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayLap = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = "";
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
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
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["MaThuoc1"].GetType().Name != "DBNull" && dr["MaThuoc1"] != null)
            {
                this.MaThuoc1 = Convert.ToString(dr["MaThuoc1"]);
            }
            else
            {
                this.MaThuoc1 = "";
            }
            if (dr["TenThuoc1"].GetType().Name != "DBNull" && dr["TenThuoc1"] != null)
            {
                this.TenThuoc1 = Convert.ToString(dr["TenThuoc1"]);
            }
            else
            {
                this.TenThuoc1 = "";
            }
            if (dr["MaThuoc2"].GetType().Name != "DBNull" && dr["MaThuoc2"] != null)
            {
                this.MaThuoc2 = Convert.ToString(dr["MaThuoc2"]);
            }
            else
            {
                this.MaThuoc2 = "";
            }
            if (dr["TenThuoc2"].GetType().Name != "DBNull" && dr["TenThuoc2"] != null)
            {
                this.TenThuoc2 = Convert.ToString(dr["TenThuoc2"]);
            }
            else
            {
                this.TenThuoc2 = "";
            }
            if (dr["MaThuoc3"].GetType().Name != "DBNull" && dr["MaThuoc3"] != null)
            {
                this.MaThuoc3 = Convert.ToString(dr["MaThuoc3"]);
            }
            else
            {
                this.MaThuoc3 = "";
            }
            if (dr["TenThuoc3"].GetType().Name != "DBNull" && dr["TenThuoc3"] != null)
            {
                this.TenThuoc3 = Convert.ToString(dr["TenThuoc3"]);
            }
            else
            {
                this.TenThuoc3 = "";
            }
            if (dr["TenNguoiLap"].GetType().Name != "DBNull" && dr["TenNguoiLap"] != null)
            {
                this.TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            }
            else
            {
                this.TenNguoiLap = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            {
                this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
            }
            else
            {
                this.TenNguoiHuy = "";
            }
            this.Ordernumber = Ordernumber;
        }
        public static DMTuongTac GetByMa(Int32 STT)
        {
            DMTuongTac obj = new DMTuongTac();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMTuongTac_Get", STT))
            {
                while (dr.Read())
                {
                    obj = new DMTuongTac(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTuongTac_Update_2", STT, TenGoc1, TenGoc2, TenGoc3, TuongTacThuoc, MucDo, MoTa, MaMay, NguoiSD, Huy).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTuongTac_Delete", STT, MaMay, NguoiHuy).ToString();
        }
    }

    [Serializable()]
    public class DMTuongTacs : List<DMTuongTac>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        private Int32 _countRowTotal = 0;
        public Int32 CountRowTotal
        {
            get
            {
                return _countRowTotal;
            }
        }
        public static DMTuongTacs Find(String DK, Boolean Qadmin, Int32 SoTrang, Int32 SoBanGhi)
        {
            DMTuongTacs obj = new DMTuongTacs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMTuongTac_Find", DK, Qadmin, SoTrang, SoBanGhi))
            {
                int Ordernumber = SoTrang * SoBanGhi;
                while (dr.Read())
                {
                    if (Ordernumber == SoTrang * SoBanGhi)
                    {
                        obj._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                        break;
                    }
                }

                if (dr.NextResult())
                {
                    while (dr.Read())
                    {
                        Ordernumber++;
                        obj.Add(new DMTuongTac(dr, Ordernumber));
                    }
                }
            }
            return obj;
        }

        public static DataTable DMThuocGetAll(String TenGoc)
        {
            return SqlHelper.ExecuteDataset(strConnect, CommandType.Text, "SELECT DISTINCT TenGoc from DMThuoc where LTRIM(ISNULL(TenGoc,'')) <> '' AND LTRIM(ISNULL(TenGoc,'')) like '" + TenGoc + "%'").Tables[0];
        }
        public static DMTuongTacs DMThuocFind(String TenGoc)
        {
            DMTuongTacs obj = new DMTuongTacs();
            string dk = "and ( LTRIM(ISNULL(TenGoc1,'')) <> '' AND LTRIM(ISNULL(TenGoc1,'')) = N'" + TenGoc + "') or  (LTRIM(ISNULL(TenGoc2,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = N'" + TenGoc + "') or ( LTRIM(ISNULL(TenGoc3,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = '" + TenGoc + "')";
            obj = Find(dk, false, 100, 100);
            //using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, CommandType.Text, "SELECT *,null as TenThuoc1, null as MaThuoc1, null as TenThuoc2, null as MaThuoc2, null as TenThuoc3, null as MaThuoc3, null   as TenNguoiLap, null as TenNguoiSD, null as TenNguoiHuy from DMTuongTac where ( LTRIM(ISNULL(TenGoc1,'')) <> '' AND LTRIM(ISNULL(TenGoc1,'')) = N'" + TenGoc + "') or  (LTRIM(ISNULL(TenGoc2,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = N'" + TenGoc + "') or ( LTRIM(ISNULL(TenGoc3,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = '" + TenGoc + "')"))
            //{
            //    int  Ordernumber=0;
            //    if (dr.NextResult())
            //    {
            //        while (dr.Read())
            //        {
            //            Ordernumber++;
            //            obj.Add(new DMTuongTac(dr, Ordernumber));
            //        }
            //    }
            //}
            return obj;
        }
    }




}