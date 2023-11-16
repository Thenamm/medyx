using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Telerik.Web.UI;
using System.Globalization;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Management;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;

using System.Web.UI;
using System.IO;
using DBTableAdapters;
//using HTC.Business.CategoryList;
using System.Collections;
using System.Configuration;
using System.Text;
//using System.Printing;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data.SqlClient;
using System.Web.Services;
using ServiceQueue;
using RadComboBox = Telerik.Web.UI.RadComboBox;
using RadGrid = Telerik.Web.UI.RadGrid;
using Telerik.Web.UI.Skins;
using RadToolBar = Telerik.Web.UI.RadToolBar;
//using PdfSharp.Pdf;
//using PdfSharp.Pdf.IO;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
//using HL7CoreDBTableAdapters;
//using HTC.Business.NoiTru;
/// <summary>
/// Summary description for WebBase
/// </summary>
/// 
namespace HTC.Common.Web
{
    public class WebBase : System.Web.UI.Page
    {
        private const string viewState_ScriptCodeBlock = "viewState_ScriptCodeBlock";
        public List<string> _ScriptRegisterList
        {

            get
            {
                if (ViewState[viewState_ScriptCodeBlock] == null)
                {
                    ViewState[viewState_ScriptCodeBlock] = new List<string>();
                }

                return (List<string>)ViewState[viewState_ScriptCodeBlock];
            }

            set
            {
                ViewState[viewState_ScriptCodeBlock] = value;
            }
        }

        private const string viewState_CurrentFormType = "CurrentFormType";
        public FormType _CurrentFormType
        {

            get
            {
                if (ViewState[viewState_CurrentFormType] == null)
                {
                    return FormType.OTHERS;
                }


                return (FormType)ViewState[viewState_CurrentFormType];
            }

            set
            {
                ViewState[viewState_CurrentFormType] = value;
            }
        }


        public enum FormType
        {
            FORM_DANH_MUC_ONLY = 1,
            FORM_CHI_TIET = 2,
            FORM_DANH_SACH_CHI_TIET = 3,
            OTHERS = 4,
            FORM_ViewManHinh = 5
        }

        public enum MessageType
        {
            SUCCESS = 1,
            ERROR = 2,
            WARNING = 3,
            FLUSH = 4
        }

        public enum FormAction
        {
            INSERT = 1,
            EDIT = 2,
            DELETE = 3,
            VIEW = 4,
            OTHERS = 5,
            CONVERT_DATA = 6,
            REPORTS = 7,
            CONVERT_DATE = 8,
            DOITUONG = 9,
            ERROR = 10,
            SEARCH = 11,
            NOINHAPXUAT = 12,
            SLTON = 13,
            VITRI = 14,
            NCC = 15,
            INITALIZE_FORM = 16,
            XuLy
        }

        public void ShowMessage(string msg)
        {
            if (this.Master != null)
            {
                Label lblMessage = this.Master.FindControl("lblMessage") as Label;

                if (lblMessage != null)
                {
                    lblMessage.Text = msg;

                }
                AlertMessage(msg);
            }
        }
        public string ReadControl()
        {
            string ipAdd = "";
            ipAdd = GetIP4Address();
            RFID r = new RFID();
            var r1 = r.GetData(ipAdd);
            return r1;
        }
        private string GetCurrentURL()
        {
            //return Request.Url.GetLeftPart(UriPartial.Path);

            Uri uri = Request.Url;
            string query = uri.Query;
            //string url = stringUri.Substring(0, stringUri.Length - query.Length);

            return Path.GetFileName(Request.Path) + query;
        }

        public static List<object> GetQuyenSelectForDataSource()
        {
            /*
                return new List<ShareVariables.KieuFormChiTiet>
                    { 
                        ShareVariables.KieuFormChiTiet.fXem, 
                        ShareVariables.KieuFormChiTiet.fThem, 
                        ShareVariables.KieuFormChiTiet.fSua, 
                        ShareVariables.KieuFormChiTiet.fDelete,
                        ShareVariables.KieuFormChiTiet.fNotDelete,
                        ShareVariables.KieuFormChiTiet.fNotAccess,
                    };
            */

            return System.Enum.GetNames(typeof(ShareVariables.KieuFormChiTiet)).Select(o => new { Text = o, Value = (int)(System.Enum.Parse(typeof(ShareVariables.KieuFormChiTiet), o)) }).ToList<object>();
        }

        public static bool IsHSBAFinished(string maHSBA, bool LoaiBenhAn)
        {
            if (LoaiBenhAn) // Bệnh án nôi trú
            {
                HTC.Business.NoiTru.BenhAn _benhan = HTC.Business.NoiTru.BenhAn.GetBenhAn(maHSBA, "");
                if (_benhan.NgayRaVien != null)
                {
                    if (!string.IsNullOrEmpty(_benhan.NgayRaVien))

                        return true; //// ho so khong duoc sua lai o cac chuc nang nhap ...
                    else
                        return false; //// ho so  duoc sua o cac chuc nang nhap ...
                }
                else
                    return false;
            }
            else // Bệnh án ngoại trú
            {
                HTC.Business.PhongKham.BenhAnPK _benhan = HTC.Business.PhongKham.BenhAnPK.GetBenhAnPK(maHSBA);
                if (_benhan.NgayRaVien != null)
                {
                    if (!string.IsNullOrEmpty(_benhan.NgayRaVien))

                        return true; //// ho so khong duoc sua lai o cac chuc nang nhap ...
                    else
                        return false; //// ho so  duoc sua o cac chuc nang nhap ...

                }
                else
                    return false;
            }
        }

        public static bool IsHSBAEditable(string maHSBA)
        {
            HL7CoreDBTableAdapters.HSBALockTableAdapter adapter = new HL7CoreDBTableAdapters.HSBALockTableAdapter();

            HL7CoreDB.HSBALockDataTable dt = adapter.GetHSBALockByMaHSBA(maHSBA);

            if (dt != null && dt.Rows.Count > 0)
            {
                HL7CoreDB.HSBALockRow row = dt.Rows[0] as HL7CoreDB.HSBALockRow;
                if (row != null)
                {
                    return row.IsLocked == true ? false : true;
                }
            }

            return true;
        }

        public static Hashtable GetQuyenSelectForDataSource2()
        {
            /*
            // get the names from the enumeration
            string[] names = System.Enum.GetNames(typeof(ShareVariables.KieuFormChiTiet));

            // get the values from the enumeration
            Array values = System.Enum.GetValues(typeof(ShareVariables.KieuFormChiTiet));
            
            // turn it into a hash table
            Hashtable ht = new Hashtable();
            for (int i = 0; i < names.Length; i++)                
                ht.Add(names[i], (int)values.GetValue(i));

            return ht;*/

            Hashtable ht = new Hashtable();

            ht.Add("", "");
            ht.Add(3, "Xóa");
            ht.Add(2, "Sửa");
            ht.Add(1, "Thêm");
            ht.Add(0, "Xem");

            return ht;
        }

        /*
        protected void Page_Init(object sender, EventArgs e)
        {
            RadGrid grdChiTiet = FindControlIterative(this, "grdChiTiet") as RadGrid;
            if (grdChiTiet != null)
            { 
                if (grdChiTiet.DataSource == null)  
                {
                    grdChiTiet.DataSource = new System.Data.DataTable();
                }                  
            }            

            RadGrid grdDanhSach = FindControlIterative(this, "grdDanhSach") as RadGrid;
            if (grdDanhSach != null)
            {
                if (grdDanhSach.DataSource == null)
                {

                    grdDanhSach.DataSource = new System.Data.DataTable();
                }
            }
        }*/

        public void Page_Unload(object sender, EventArgs e)
        {
            //Control control = FindControlIterative(Page, "HTCReportViewer1");

            //if (control != null && control is HTCReportViewer)

            //HTCReportViewer1
            //CrystalReportViewer1.ReportSource.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        public void SetDataDacDiemBenhYHCT(CheckBoxList ckblName, string Maba)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Medyxv3ConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("sp_GetDacDiemBenh", con);
                com.Parameters.Add("MaBa", SqlDbType.NChar).Value = Maba;
                com.CommandType = CommandType.StoredProcedure;
                com.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ckblName.DataSource = dt;
                ckblName.DataTextField = "TenDacDiemBenh";
                ckblName.DataValueField = "IdDacDiemBenh";
                ckblName.DataBind();
                foreach (System.Web.UI.WebControls.ListItem item in ckblName.Items)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row != null)
                        {
                            //if (row["BAHuy"].ToString())
                            //    Response.Write("ID TRUE" + item.Value.Equals(row["IdDacDiemBenhBA"].ToString()) + "</br>");
                            if (item.Value.Equals(row["IdDacDiemBenhBA"].ToString(), StringComparison.InvariantCultureIgnoreCase))
                            {
                                bool Huy = bool.Parse(row["BAHuy"].ToString());
                                if (!Huy)
                                    item.Selected = true;
                            }

                        }
                    }
                }
            }
        }
        public void SetDataDacDiemBenh(Panel PanelName, string Maba)// Sếp bảo làm thì làm theo chứ cách này show auto ra dễ sau input auto khó vãi.
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Medyxv3ConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("sp_GetDacDiemBenh", con);
                com.Parameters.Add("MaBa", SqlDbType.NChar).Value = Maba;
                com.CommandType = CommandType.StoredProcedure;
                com.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    for (int i = 0; i < dt.Rows.Count; i++) // Vẽ 4 <td>
                    {
                        if (i == 0 || i % 3 == 0)// 1 hàng 3 cột
                        {
                            // <tr>
                            Literal StartRow = new Literal();
                            StartRow.ID = "StartRow_" + i.ToString();
                            StartRow.Mode = LiteralMode.Transform;
                            StartRow.Text = "<tr>";
                            PanelName.Controls.Add(StartRow);
                            // Hàng 1
                            Literal ColStart = new Literal();
                            ColStart.ID = "ColStart" + i.ToString();
                            ColStart.Mode = LiteralMode.Transform;
                            ColStart.Text = "<td style='width: 250px '>";
                            PanelName.Controls.Add(ColStart);

                            CheckBox checkDacDiem = new CheckBox();
                            checkDacDiem.Width = 85;
                            checkDacDiem.ID = "ckb" + i.ToString();
                            if (dt.Rows[i]["TenDacDiemBenh"] is DBNull)
                                checkDacDiem.Text = string.Empty;
                            else
                                checkDacDiem.Text = dt.Rows[i]["TenDacDiemBenh"].ToString();

                            HiddenField hidden1 = new HiddenField();
                            hidden1.ID = "ckbValue" + i.ToString();
                            hidden1.Value = dt.Rows[i]["IdDacDiemBenh"].ToString();
                            PanelName.Controls.Add(hidden1);

                            RadNumericTextBox txtSoThang = new RadNumericTextBox();
                            txtSoThang.Width = 40;
                            txtSoThang.MinValue = 0;
                            txtSoThang.MaxValue = 999;
                            txtSoThang.NumberFormat.DecimalDigits = 0;
                            txtSoThang.ID = "txtSoThang" + i.ToString();

                            bool Huy = false;
                            if (dt.Rows[i]["BaHuy"].ToString().Equals("True"))
                                Huy = true;
                            if (dt.Rows[i]["IdDacDiemBenhBA"] != null)
                            {
                                string IdDacDiemBenhAn = string.Empty;
                                IdDacDiemBenhAn = dt.Rows[i]["IdDacDiemBenhBA"].ToString();
                                if (!string.IsNullOrEmpty(IdDacDiemBenhAn) && Huy == false)
                                {
                                    checkDacDiem.Checked = true;
                                    txtSoThang.Text = dt.Rows[i]["SoThang"].ToString();
                                }
                                else
                                    checkDacDiem.Checked = false;
                            }
                            if (Huy)
                            {
                                checkDacDiem.Checked = false;
                            }
                            PanelName.Controls.Add(checkDacDiem);
                            Label SoThang1_ = new Label();
                            SoThang1_.Width = 85;
                            SoThang1_.ID = "SoThang1_" + i.ToString();
                            SoThang1_.Text = "Số Tháng :";
                            PanelName.Controls.Add(SoThang1_);
                            PanelName.Controls.Add(txtSoThang);



                            Literal ColEnd = new Literal();
                            ColEnd.ID = "ColEnd" + i.ToString();
                            ColEnd.Mode = LiteralMode.Transform;
                            ColEnd.Text = "</td>";
                            PanelName.Controls.Add(ColEnd);
                            // End Hàng 1
                            // Hàng 2
                            if (dt.Rows.Count > 1)
                            {
                                Literal ColStartLe = new Literal();
                                ColStartLe.ID = "ColStartLe" + i + 1.ToString();
                                ColStartLe.Mode = LiteralMode.Transform;
                                ColStartLe.Text = "<td style='width: 250px'>";
                                PanelName.Controls.Add(ColStartLe);
                                CheckBox checkDacDiemLe = new CheckBox();
                                checkDacDiemLe.Width = 85;
                                checkDacDiemLe.ID = "ckb" + i + 1.ToString();
                                if (dt.Rows[i + 1]["TenDacDiemBenh"] is DBNull)
                                    checkDacDiemLe.Text = string.Empty;
                                else
                                    checkDacDiemLe.Text = dt.Rows[i + 1]["TenDacDiemBenh"].ToString();
                                PanelName.Controls.Add(checkDacDiemLe);
                                HiddenField hidden2 = new HiddenField();
                                hidden2.ID = "ckbValue" + i + 1.ToString();
                                hidden2.Value = dt.Rows[i + 1]["IdDacDiemBenh"].ToString();
                                PanelName.Controls.Add(hidden2);

                                Label SoThang2_ = new Label();
                                SoThang2_.Width = 85;
                                SoThang2_.ID = "SoThang2_" + i + 2.ToString();
                                SoThang2_.Text = "Số Tháng :";
                                PanelName.Controls.Add(SoThang2_);


                                RadNumericTextBox txtSoThangLe = new RadNumericTextBox();
                                txtSoThangLe.ID = "txtSoThang" + i + 1.ToString();
                                txtSoThangLe.Width = 40;
                                txtSoThangLe.NumberFormat.DecimalDigits = 0;
                                bool Huy1 = false;
                                if (dt.Rows[i + 1]["BaHuy"].ToString().Equals("True"))
                                    Huy1 = true;

                                if (dt.Rows[i + 1]["IdDacDiemBenhBA"] != null)
                                {
                                    string IdDacDiemBenhAn = string.Empty;
                                    IdDacDiemBenhAn = dt.Rows[i + 1]["IdDacDiemBenhBA"].ToString();

                                    if (!string.IsNullOrEmpty(IdDacDiemBenhAn) && Huy == false)
                                    {
                                        checkDacDiemLe.Checked = true;
                                        txtSoThangLe.Text = dt.Rows[i + 1]["SoThang"].ToString();
                                    }
                                    else
                                        checkDacDiemLe.Checked = false;

                                }

                                PanelName.Controls.Add(txtSoThangLe);
                                Literal ColEnd2Le = new Literal();
                                ColEnd2Le.ID = "ColEnd2Le" + i + 1.ToString();
                                ColEnd2Le.Mode = LiteralMode.Transform;
                                ColEnd2Le.Text = " </td>";
                                PanelName.Controls.Add(ColEnd2Le);
                            }
                            // End Hàng 2
                            // Hàng 3
                            if (dt.Rows.Count > 2)
                            {
                                Literal ColStart3 = new Literal();
                                ColStart3.ID = "ColStart3" + i + 2.ToString();
                                ColStart3.Mode = LiteralMode.Transform;
                                ColStart3.Text = "<td style='width: 250px'>";
                                PanelName.Controls.Add(ColStart3);
                                CheckBox checkDacDiem3 = new CheckBox();
                                checkDacDiem3.Width = 85;
                                checkDacDiem3.ID = "ckb" + i + 2.ToString();
                                if (dt.Rows[i + 2]["TenDacDiemBenh"] is DBNull)
                                    checkDacDiem3.Text = string.Empty;
                                else
                                    checkDacDiem3.Text = dt.Rows[i + 2]["TenDacDiemBenh"].ToString();
                                PanelName.Controls.Add(checkDacDiem3);
                                HiddenField hidden3 = new HiddenField();
                                hidden3.ID = "ckbValue" + i + 2.ToString();
                                hidden3.Value = dt.Rows[i + 2]["IdDacDiemBenh"].ToString();// ? Null kệ
                                PanelName.Controls.Add(hidden3);

                                Label SoThang3_ = new Label();
                                SoThang3_.Width = 85;
                                SoThang3_.ID = "SoThang3_" + i + 2.ToString();
                                SoThang3_.Text = "Số Tháng :";
                                PanelName.Controls.Add(SoThang3_);

                                RadNumericTextBox txtSoThang3 = new RadNumericTextBox();
                                txtSoThang3.ID = "txtSoThang" + i + 2.ToString();
                                txtSoThang3.Width = 40;
                                txtSoThang3.NumberFormat.DecimalDigits = 0;
                                bool Huy2 = false;
                                if (dt.Rows[i + 2]["BaHuy"].ToString().Equals("True"))
                                    Huy2 = true;
                                if (dt.Rows[i + 2]["IdDacDiemBenhBA"] != null)
                                {
                                    string IdDacDiemBenhAn = string.Empty;
                                    IdDacDiemBenhAn = dt.Rows[i + 2]["IdDacDiemBenhBA"].ToString();

                                    if (!string.IsNullOrEmpty(IdDacDiemBenhAn) && Huy == false)
                                    {
                                        checkDacDiem3.Checked = true;
                                        txtSoThang3.Text = dt.Rows[i + 2]["SoThang"].ToString();
                                    }
                                    else
                                        checkDacDiem3.Checked = false;
                                }
                                else
                                    checkDacDiem.Checked = false;
                                PanelName.Controls.Add(txtSoThang3);
                                Literal ColEnd3_3 = new Literal();
                                ColEnd3_3.ID = "ColEnd3_3" + i + 2.ToString();
                                ColEnd3_3.Mode = LiteralMode.Transform;
                                ColEnd3_3.Text = " </td>";
                                PanelName.Controls.Add(ColEnd3_3);
                            }
                            // End Hàng 3
                            // End <Tr>
                            Literal EndRow = new Literal();
                            EndRow.Mode = LiteralMode.Transform;
                            EndRow.ID = "EndRow" + i.ToString();
                            EndRow.Text = "</tr>";
                            PanelName.Controls.Add(EndRow);
                        }
                    }



                con.Close();
            }



        }
        public List<string> getDacDiemBenhYHCT(CheckBoxList ckblName) // Lấy toàn bộ dữ liệu của CheckBoxList
        {

            List<string> list = new List<string>();
            foreach (System.Web.UI.WebControls.ListItem item in ckblName.Items)
            {
                if (item.Selected)
                    list.Add(item.Value + "|0");
                else
                    list.Add(item.Value + "|1");
            }
            return list;
        }

        public void Insert_tbl_BenhAn_DacDiemLienQuan(List<String> list, string MaBa)// Có thể truyền luôn MaBa vào list
        {
            if (list.Count > 0)
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Medyxv3ConnectionString"].ConnectionString))
                {
                    con.Open();
                    foreach (String item in list)
                    {
                        string[] listPara = item.Split('|');
                        if (listPara.Count() > 1)
                        {

                            SqlCommand com = new SqlCommand("sp_InsertOrUpdateBenhAn_DacDiemLienQuan", con);
                            // para[0]= Mã Đặc điểm
                            // para[1]= Số tháng
                            // para[2]= Trạng thái hủy
                            int IdDacDiem = int.Parse(listPara[0]);
                            int SoThang = 0;
                            int Huy = 0;
                            if (!_IsBVYHocCoTruyen)
                            {
                                SoThang = int.Parse(listPara[1]);
                                Huy = int.Parse(listPara[2]);
                            }
                            else
                                Huy = int.Parse(listPara[1]);
                            com.Parameters.Add("@MaBa", SqlDbType.NChar).Value = MaBa;
                            com.Parameters.Add("@IdDacDiemBenh", SqlDbType.Int).Value = IdDacDiem;
                            com.Parameters.Add("@SoThang", SqlDbType.Int).Value = SoThang;
                            com.Parameters.Add("@Huy", SqlDbType.Bit).Value = Huy;
                            com.CommandType = CommandType.StoredProcedure;
                            com.ExecuteNonQuery();

                        }

                    }
                    con.Dispose();
                }
        }
        private string GetIndexIdControlCheckBox(string IdCheckBox)
        {
            string Index = string.Empty;
            if (IdCheckBox != null && IdCheckBox.Length > 3)
                Index = IdCheckBox.Substring(3, IdCheckBox.Length - 3);
            return Index;
        }
        public List<string> GetDataDacDiemBenhFromDesgin(Panel PanelName)
        {// Lỡ ngu rồi làm luôn =))
            List<String> ListIndexChecked = new List<string>();
            List<String> ListIndexUnChecked = new List<string>();
            List<string> ListIdDacDiemCheck = new List<string>();
            List<string> ListIdDacDiemUnCheck = new List<string>();
            List<string> ResultAll = new List<string>();
            foreach (Control control in PanelName.Controls)
            {
                // Lấy Index theo quy tắc 1 hàng 3 cột
                if (control != null)
                    if (control is CheckBox)
                    {
                        CheckBox ckb = (CheckBox)control;
                        if (ckb.Checked == true)// Check tạm thời/ True mới đúng
                            ListIndexChecked.Add(GetIndexIdControlCheckBox(ckb.ID));
                        else
                            ListIndexUnChecked.Add(GetIndexIdControlCheckBox(ckb.ID));
                    }
            }
            foreach (Control control in PanelName.Controls)
            {
                if (control != null)
                    if (control is HiddenField)
                    {
                        foreach (string item in ListIndexChecked)
                        {
                            if (control.ID == "ckbValue" + item)
                            {
                                ListIdDacDiemCheck.Add(item + "|" + ((HiddenField)(control)).Value);
                                break;
                            }
                        }
                        foreach (string item in ListIndexUnChecked)
                        {
                            if (control.ID == "ckbValue" + item)
                            {
                                ListIdDacDiemUnCheck.Add(item + "|" + ((HiddenField)(control)).Value);
                                break;
                            }
                        }
                    }
            }
            foreach (Control control in PanelName.Controls)
            {
                if (control != null)
                    if (control is RadNumericTextBox)
                    {
                        foreach (string item in ListIdDacDiemCheck)
                        {
                            if (item.Split('|').Length > 1)
                                if (control.ID == "txtSoThang" + item.Split('|')[0].ToString())
                                {
                                    if (!string.IsNullOrEmpty(((RadNumericTextBox)(control)).Text))
                                    {
                                        string ItemNode = item.Split('|')[1] + "|" + ((RadNumericTextBox)(control)).Text + "|0";
                                        ResultAll.Add(ItemNode);
                                        break;
                                    }
                                }
                        }
                        foreach (string item in ListIdDacDiemUnCheck)
                        {
                            if (item.Split('|').Length > 1)
                                if (control.ID == "txtSoThang" + item.Split('|')[0].ToString())
                                {
                                    if (!string.IsNullOrEmpty(((RadNumericTextBox)(control)).Text))
                                    {
                                        string ItemNode = item.Split('|')[1] + "|" + ((RadNumericTextBox)(control)).Text + "|1";
                                        ResultAll.Add(ItemNode);
                                        break;
                                    }
                                }
                        }
                    }
            }

            return ResultAll;
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            //ShowMessage(MessageType.FLUSH, FormAction.OTHERS);
            //if (!IsPostBack)
            //{
            //    if (!string.IsNullOrEmpty(Request["msg"]))
            //    {
            //        if (Request["msg"].Equals("add"))
            //        {
            //            ShowMessage(MessageType.SUCCESS, FormAction.INSERT);
            //        }
            //        else if (Request["msg"].Equals("update"))
            //        {
            //            ShowMessage(MessageType.SUCCESS, FormAction.EDIT);
            //        }
            //    }
            //}



        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (_CurrentFormType == FormType.FORM_ViewManHinh)
                    return;
                ShowPageTitle();
                // Quoted out cho 1 số form không biết Tên Menu <Nhập kết quả xét nghiệm>
                if (IsAccessAuthorized)
                {

                    AuthorizePermission();
                }
                else
                {
                    //Response.Redirect("~/AccessDenied.aspx");
                }
                // ShowMessage(ViewState[viewState_ID].ToString());
                // HttpContext.Current.RewritePath("~/" + ViewState[viewState_ID].ToString());




                ApplyCustomizedStyle();
            }
            else
            {
                if (_CurrentFormType == FormType.FORM_ViewManHinh)
                    return;
                int i = 0;
                if (_ScriptRegisterList != null)
                {
                    foreach (string script in _ScriptRegisterList)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), i.ToString(), script, true);
                        i++;
                    }
                }
            }
            if (_MaMN != "" && _MaMN != null)
            {
                if (_MaMN.Length >= 6)
                {
                    if (_MaMN.Substring(0, 6) == "005011" || (_MaMN.Substring(0, 6) == "005012" && HTC.ShareVariables.pub_spC == "QN"))
                    {
                        ShowPageThongBao();

                    }
                }
            }
        }

        public void ApplyCustomizedStyle()
        {

            if (_CurrentFormType == FormType.OTHERS)
            {
                if (Page.Master != null)
                {
                    HiddenField txtloaiphieu = (HiddenField)Page.Master.FindControl("txtloaiphieu");
                    txtloaiphieu.Value = "NghiepVu";
                }
                return;
            }
            if (_CurrentFormType == FormType.FORM_DANH_MUC_ONLY)
            {
                //RadStyleSheetManager radStyleSheetManager = FindControlIterative(this, "RadStyleSheetManager1") as RadStyleSheetManager;

                //StyleSheetReference refer = new StyleSheetReference(;                
                //Control a = Page.Master.FindControl("masterHead");                
                //                Header.Style.Add(".RadForm.rfdTextbox input.rfdDecorated[type='text'], .RadForm.rfdTextbox input.rfdDecorated[type='password'], .RadForm.rfdTextbox input.rfdDecorated[type='search'], .RadForm.rfdTextbox input.rfdDecorated[type='url'], .RadForm.rfdTextbox input.rfdDecorated[type='tel'], .RadForm.rfdTextbox input.rfdDecorated[type='email']", "width: 100% !important;");

                /*
                RadGrid grdChiTiet = FindControlIterative(this, "grdChiTiet") as RadGrid;                
                if (grdChiTiet != null)
                {
                    string classStr = grdChiTiet.Attributes["class"];
                    if (string.IsNullOrEmpty(classStr))
                    {
                        grdChiTiet.Attributes["class"] = "RadForm1";
                    }
                    else
                    {
                        classStr = classStr + " RadForm1";
                    }
                }         
                 */
            }
        }
        private const string viewState_ID = "ID";

        private const string viewState_MaMN = "MaMN";
        private const string viewState_MaMN2 = "MaMN2";
        public string _MaMN
        {
            get
            {
                if (ViewState[viewState_MaMN] == null)
                {
                    string currentURL = GetCurrentURL();

                    if (!string.IsNullOrEmpty(currentURL))
                    {
                        if (currentURL.Contains("frmDSBNKhamBenhView.aspx") == true || currentURL.Contains("Default.aspx") == true)
                        {
                            ViewState[viewState_MaMN] = "000000000";
                            Pub_bQuyenForm = HTC.ShareVariables.KieuFormChiTiet.fDelete;
                            return ViewState[viewState_MaMN].ToString();
                        }
                        else if (Request["IDMN"] != null && (currentURL.Contains("frmDSBNKhamBenh_") == true || currentURL.Contains("frmKhamBenh_") == true || currentURL.Contains("frmLapPhieu.aspx") == true || currentURL.Contains("frmNhapChiDinhNew.aspx") == true || currentURL.Contains("frmNhapChiDinhDSNew.aspx") == true || currentURL.Contains("frmThanhToanRaVien.aspx") == true || currentURL.Contains("frmThanhToanRaVienDS.aspx") == true))
                        {
                            ViewState[viewState_MaMN] = Request["IDMN"].ToString().Substring(0, 9);
                            Pub_bQuyenForm = Request["IDMN"].ToString().Substring(9, 1) == "0" ? HTC.ShareVariables.KieuFormChiTiet.fXem : (Request["IDMN"].ToString().Substring(9, 1) == "1" ? HTC.ShareVariables.KieuFormChiTiet.fThem : (Request["IDMN"].ToString().Substring(9, 1) == "2" ? HTC.ShareVariables.KieuFormChiTiet.fSua : (Request["IDMN"].ToString().Substring(9, 1) == "3" ? HTC.ShareVariables.KieuFormChiTiet.fDelete : HTC.ShareVariables.KieuFormChiTiet.fNotAccess)));
                            return ViewState[viewState_MaMN].ToString();
                        }
                        else
                        {
                            DB.MenuPagesDataTable menuOfCurrentPage = new MenuPagesTableAdapter().GetAllByPageURL(currentURL);
                            if (menuOfCurrentPage != null && menuOfCurrentPage.Count > 0)
                            {
                                DB.MenuPagesRow row = menuOfCurrentPage.Rows[0] as DB.MenuPagesRow;
                                if (row != null)
                                {
                                    ViewState[viewState_MaMN] = row.MaMN;
                                    ViewState[viewState_ID] = row.MappingId.ToString();
                                    return ViewState[viewState_MaMN].ToString();
                                }
                            }
                        }

                    }

                    return null;
                }
                else
                    return (string)ViewState[viewState_MaMN];
            }

            set
            {
                ViewState[viewState_MaMN] = value;
            }
        }
        public string _MaMN2
        {
            get
            {
                if (ViewState[viewState_MaMN2] == null)
                {
                    string currentURL = GetCurrentURL();

                    if (!string.IsNullOrEmpty(currentURL))
                    {
                        DB.MenuPagesDataTable menuOfCurrentPage = new MenuPagesTableAdapter().GetAllByPageURL(currentURL);
                        if (menuOfCurrentPage != null && menuOfCurrentPage.Count > 1)
                        {
                            DB.MenuPagesRow row = menuOfCurrentPage.Rows[1] as DB.MenuPagesRow;
                            if (row != null)
                            {
                                ViewState[viewState_MaMN2] = row.MaMN;
                                ViewState[viewState_ID] = row.MappingId.ToString();
                                return ViewState[viewState_MaMN2].ToString();
                            }
                        }
                    }

                    return null;
                }
                else
                    return (string)ViewState[viewState_MaMN2];
            }

            set
            {
                ViewState[viewState_MaMN2] = value;
            }
        }
        public bool IsAccessAuthorized
        {
            get
            {
                if (GetCurrentURL().Contains("Default.aspx"))
                {
                    return true;
                }

                return Pub_bQuyenForm == ShareVariables.KieuFormChiTiet.fNotAccess ? false : true;
            }
        }

        public void ShowHideColumn(string gridName, string columnName, bool isShowed = false)
        {
            RadGrid grd = FindControlIterative(this, gridName) as RadGrid;

            if (grd != null)
            {
                try
                {
                    /*
                    GridColumn col = grd.MasterTableView.GetColumn(columnName);

                    if (col != null)
                    {
                        grd.MasterTableView.GetColumn(columnName).Display = isShowed;
                    }*/
                }
                catch (Exception)
                { }

                var tableView = grd.MasterTableView;
                var gridColumn = tableView.Columns.FindByUniqueNameSafe(columnName);
                if (gridColumn != null)
                {
                    gridColumn.Display = isShowed;
                }

                if (columnName.Equals("edit", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (isShowed == false)
                    {
                        tableView.ClearEditItems();
                        grd.ClientSettings.ClientEvents.OnRowDblClick = "";
                    }
                    else
                    {
                        grd.ClientSettings.ClientEvents.OnRowDblClick = "RowDblClickForDMForms";
                    }
                }
            }
        }

        public static Control FindControlIterative_CU(Control root, string id)
        {
            Control ctl = root;
            LinkedList<Control> ctls = new LinkedList<Control>();

            while (ctl != null)
            {
                if (ctl.ID == id)
                    return ctl;
                foreach (Control child in ctl.Controls)
                {
                    if (child.ID == id)
                        return child;
                    if (child.HasControls())
                        ctls.AddLast(child);
                }
                ctl = ctls.First.Value;
                ctls.Remove(ctl);
            }
            return null;
        }


        public Control FindControlIterative(Control containerControl, string controlId)
        {
            Queue<Control> queue = new Queue<Control>();
            queue.Enqueue(containerControl);

            while (queue.Count > 0)
            {
                Control currentControl = queue.Dequeue();

                if (currentControl.ID == controlId)
                {
                    return currentControl;
                }

                foreach (Control childControl in currentControl.Controls)
                {
                    queue.Enqueue(childControl);
                }
            }

            return null;
        }

        public RadToolBarItem FindButtonInToolbar(RadToolBar toolBar, string buttonValue)
        {
            return toolBar.FindItemByValue(buttonValue);
        }

        private void ShowHideButtonInToolBar(RadToolBar toolBar, string buttonValue, bool isDisplayed = false)
        {
            if (toolBar != null)
            {
                RadToolBarItem viewItem = toolBar.FindItemByValue(buttonValue);
                if (viewItem != null)
                {
                    viewItem.Visible = isDisplayed;
                }
            }
        }

        private void ShowHideHeaderActions(string gridName, string columnName, bool isDisplayed = false)
        {
            RadGrid grd = FindControlIterative(this, gridName) as RadGrid;

            if (grd != null)
            {
                var tableView = grd.MasterTableView;

                if (columnName.Equals("cmdAdd", StringComparison.InvariantCultureIgnoreCase))
                {
                    tableView.CommandItemSettings.ShowAddNewRecordButton = isDisplayed;
                    //tableView.IsItemInserted = isDisplayed;
                }
            }
        }

        public void AuthorizePermission()
        {
            if (_CurrentFormType == FormType.FORM_ViewManHinh)
                return;
            RadToolBar toolBar = FindControlIterative(Page, "baraction") as RadToolBar;

            if (_CurrentFormType == FormType.FORM_CHI_TIET)
            {
                if (toolBar != null)
                {
                    #region Disable Buttons

                    ShowHideButtonInToolBar(toolBar, "cmdView", false);
                    ShowHideButtonInToolBar(toolBar, "cmdAdd", false);
                    ShowHideButtonInToolBar(toolBar, "cmdSave", false);

                    CheckBox ckbHuy = this.FindControl("ckbHuy") as CheckBox;
                    if (ckbHuy != null)
                    {
                        ckbHuy.Enabled = false;
                    }

                    #endregion

                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fXem)
                    {
                        ShowHideButtonInToolBar(toolBar, "cmdView", true);
                    }

                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fThem)
                    {
                        ShowHideButtonInToolBar(toolBar, "cmdAdd", true);
                    }

                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fSua)
                    {
                        ShowHideButtonInToolBar(toolBar, "cmdSave", true);

                        //ShowColumn("grdChiTiet", "EditMaster", true);
                    }

                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fDelete)
                    {
                        if (ckbHuy != null)
                        {
                            if (pub_bQadmin == true)
                            {
                                ckbHuy.Enabled = true;
                                //ShowColumn("grdChiTiet", "Huy", true);
                                //ShowColumn("grdChiTiet", "delete", true);
                            }
                        }
                    }
                }
            }
            else if (_CurrentFormType == FormType.FORM_DANH_MUC_ONLY)
            {
                #region Disable Buttons/ Columns

                ShowHideButtonInToolBar(toolBar, "cmdView", false);

                ShowHideButtonInToolBar(toolBar, "cmdAdd", false);
                ShowHideHeaderActions("grdChiTiet", "cmdAdd", false);

                ShowHideButtonInToolBar(toolBar, "cmdSave", false);

                ShowHideColumn("grdChiTiet", "edit", false);
                ShowHideColumn("grdChiTiet", "delete", false);
                ShowHideColumn("grdChiTiet", "Huy", false);

                #endregion

                if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fXem)
                {
                    ShowHideButtonInToolBar(toolBar, "cmdView", true);
                }

                if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fThem)
                {
                    ShowHideButtonInToolBar(toolBar, "cmdAdd", true);
                    ShowHideHeaderActions("grdChiTiet", "cmdAdd", true);

                    _ScriptRegisterList.Add("$(document).ready(function () { document.onkeydown = keyHandlerForDMFormsFull; });");
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "AddScript", "$(document).ready(function () { document.onkeydown = keyHandlerForDMFormsFull; });", true);
                }
                else
                {
                    _ScriptRegisterList.Add("$(document).ready(function () { document.onkeydown = keyHandlerForDMFormsPrintOnly; });");
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "AddScript", "$(document).ready(function () { document.onkeydown = keyHandlerForDMFormsPrintOnly; });", true);

                }

                if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fSua)
                {
                    ShowHideButtonInToolBar(toolBar, "cmdSave", true);
                    ShowHideColumn("grdChiTiet", "edit", true);
                }

                if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fDelete)
                {
                    if (pub_bQadmin == true)
                    {
                        ShowHideColumn("grdChiTiet", "Huy", true);

                    }
                    ShowHideColumn("grdChiTiet", "delete", true);
                }


                RadGrid grd = FindControlIterative(this, "grdChiTiet") as RadGrid;
                if (grd != null)
                {
                    grd.Rebind();
                }
            }
            else if (_CurrentFormType == FormType.FORM_DANH_SACH_CHI_TIET)
            {
                if (toolBar != null)
                {
                    ShowHideButtonInToolBar(toolBar, "cmdView", false);
                    ShowHideButtonInToolBar(toolBar, "cmdAdd", false);
                    //ShowHideButtonInToolBar(toolBar, "cmdSave", false);
                    ShowHideColumn("grdChiTiet", "Huy", false);
                    ShowHideColumn("grdChiTiet", "DeleteMaster", false);


                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fXem)
                    {
                        ShowHideButtonInToolBar(toolBar, "cmdView", true);
                    }

                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fThem)
                    {
                        ShowHideButtonInToolBar(toolBar, "cmdAdd", true);
                    }

                    //if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fSua)
                    //{
                    //    ShowHideButtonInToolBar(toolBar, "cmdSave", true);

                    //    //ShowColumn("grdChiTiet", "edit", true);
                    //}

                    if (Pub_bQuyenForm >= HTC.ShareVariables.KieuFormChiTiet.fDelete)
                    {
                        if (pub_bQadmin == true)
                        {
                            ShowHideColumn("grdChiTiet", "Huy", true);
                            ShowHideColumn("grdChiTiet", "DeleteMaster", true);
                            ShowHideColumn("grdChiTiet", "Delete", true);
                        }
                    }
                }
            }
        }

        //public Boolean MsgBox(string mess)
        //{

        //    ClientScriptManager CSM = Page.ClientScript;

        //    string strconfirm = "<script>  var confirm_value = document.createElement('INPUT');confirm_value.type = 'hidden';confirm_value.name = 'confirm_value';  if (confirm('" + mess + "')) {";
        //    strconfirm = strconfirm + " confirm_value.value = 'Yes'; alert(confirm_value); } else {confirm_value.value = 'No';} document.forms[0].appendChild(confirm_value); </script>";
        //    CSM.RegisterClientScriptBlock(this.GetType(), "Confirm", strconfirm, false );
        //    string confirmValue = Request.Form["confirm_value"];
        //    if (confirmValue == "Yes")
        //        return true;
        //    else
        //        return false;
        //}
        public void MsgBox(string mess)
        {

            ClientScriptManager CSM = Page.ClientScript;

            string strconfirm = "<script>  MsgBox('" + mess + "')  </script>";
            CSM.RegisterClientScriptBlock(this.GetType(), "Confirm", strconfirm, false);

        }
        public void CloseWindow()
        {

            //ClientScriptManager CSM = Page.ClientScript;

            //string strconfirm = "<script>  open(location, '_self').close();  </script>";
            //CSM.RegisterClientScriptBlock(this.GetType(), "Close", strconfirm, false);
            ClientScriptManager CSM = Page.ClientScript;
            // string strconfirm = "<script>  var win = window.open('', '_self');win.close();return false; </script>";

            string strconfirm = "<script>   window.opener = null; window.close(); </script>";
            CSM.RegisterClientScriptBlock(this.GetType(), "Close", strconfirm, false);


            //ClientScript.RegisterClientScriptBlock(Page.GetType(), "script", "window.close();return false;", true);
            //ClientScript.RegisterClientScriptBlock(Page.GetType(), "close", "<script>self.close();return false;</script>", true);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "Close_Window", "self.close();return false;", true);

            //System.Web.HttpContext.Current.Response.Write("<script>self.close();return false;</script>");
            //Response.Write("<script>window.close();</script>");
            //Response.Write("<script language='javascript'>self.close();</script>");

        }
        public void OpenWindow(string filePath)
        {
            //string popupScript = "<script language='javascript'> var w = screen.availWidth-10;";
            //popupScript = popupScript + "var h = screen.availHeight-10;";
            //popupScript = popupScript + " var p = window.self;";
            //popupScript = popupScript + " p.opener = window.self;";

            //popupScript = popupScript + " function Window()";
            //popupScript = popupScript + "{";
            //popupScript = popupScript + "if(info.indexOf('Netscape') != -1 )";
            //popupScript = popupScript + "{";
            //popupScript = popupScript + "netscape.security.PrivilegeManager.enablePrivilege('UniversalBrowserWrite');";
            //popupScript = popupScript + "window.menubar.visible = false;";
            //popupScript = popupScript + "window.toolbar.visible = false;";
            //popupScript = popupScript + "window.locationbar.visible = false;";
            //popupScript = popupScript + "window.statusbar.visible = false;";
            //popupScript = popupScript + "window.linkbar.visible = false;";
            //popupScript = popupScript + "return true;";
            //popupScript = popupScript + "}";
            //popupScript = popupScript + "if(info.indexOf('Microsoft') != -1 )";
            //popupScript = popupScript + "{";
            //popupScript = popupScript + " window.open('" + filePath + "');";
            //popupScript = popupScript + "p.close();";
            //popupScript = popupScript + "return true;";
            //popupScript = popupScript + "}";
            //popupScript = popupScript + "}" + "</script>";
            string popupScript = "<script language='javascript'> window.open('" + filePath + "' );</script>";
            Context.Response.Write(popupScript);
        }
        public void OpenWindowOther(string filePath)
        {
            //string popupScript = "<script language='javascript'> var w = screen.availWidth-10;";
            //popupScript = popupScript + "var h = screen.availHeight-10;";
            //popupScript = popupScript + " var p = window.self;";
            //popupScript = popupScript + " p.opener = window.self;";

            //popupScript = popupScript + " function Window()";
            //popupScript = popupScript + "{";
            //popupScript = popupScript + "if(info.indexOf('Netscape') != -1 )";
            //popupScript = popupScript + "{";
            //popupScript = popupScript + "netscape.security.PrivilegeManager.enablePrivilege('UniversalBrowserWrite');";
            //popupScript = popupScript + "window.menubar.visible = false;";
            //popupScript = popupScript + "window.toolbar.visible = false;";
            //popupScript = popupScript + "window.locationbar.visible = false;";
            //popupScript = popupScript + "window.statusbar.visible = false;";
            //popupScript = popupScript + "window.linkbar.visible = false;";
            //popupScript = popupScript + "return true;";
            //popupScript = popupScript + "}";
            //popupScript = popupScript + "if(info.indexOf('Microsoft') != -1 )";
            //popupScript = popupScript + "{";
            //popupScript = popupScript + " window.open('" + filePath + "');";
            //popupScript = popupScript + "p.close();";
            //popupScript = popupScript + "return true;";
            //popupScript = popupScript + "}";
            //popupScript = popupScript + "}" + "</script>";
            string popupScript = "<script language='javascript'> var win = window.open('" + filePath + "','_blank','left=0,top=0' ); win.moveTo(0,1024); win.resizeTo(window.screen.availWidth, window.screen.availHeight);</script>";
            Context.Response.Write(popupScript);
        }
        public void PrintWindow(string filePath)
        {
            string popupScript = "<script language='javascript'> var win = window.open('" + filePath + "',left=0,top=0,width=0,height=0,toolbar=0,scrollbars=0,status =0 ) ;";
            popupScript += "var content = '<html><body \"window.print(); window.close();\">';";
            popupScript += " content += document.getElementById('divToPrint').innerHTML;";
            popupScript += " content += '</body>';";
            popupScript += "content += '</html>';";
            popupScript += " win.document.write(content); win.print();";
            popupScript += " win.document.close(); win.close();";
            popupScript += "</script>";
            Context.Response.Write(popupScript);
        }
        public void AlertMessage(string lblMessage)
        {

            String csname1 = "PopupScript";
            String csname2 = "ButtonClickScript";
            Type cstype = this.GetType();

            ClientScriptManager cs = Page.ClientScript;
            StringBuilder cstext2 = new StringBuilder();
            string type = "text/javascript";
            //cstext2.Append("<script type="+'"'+type+'"'+">");
            cstext2.Append("$(document).ready(function () {");
            cstext2.Append("alert('" + lblMessage + "', 'Medyx');");
            //cstext2.Append("jAlert('" + lblMessage + "', 'Medyx');");
            cstext2.Append("});");

            cs.RegisterClientScriptBlock(cstype, csname2, cstext2.ToString(), true);
        }
        public void setColertLableMessage(Label lblMessage)
        {
            lblMessage.Visible = true;
            //lblMessage.CssClass = "errormesage";
        }
        public void ShowMessage(MessageType messageType, FormAction formAction)
        {
            if (this.Master != null)
            {
                Label lblMessage = this.Master.FindControl("lblMessage") as Label;
                String Error_WarningMessage = "";
                if (lblMessage != null)
                {
                    string msg = string.Empty;

                    if (messageType == MessageType.SUCCESS)
                    {
                        if (formAction == FormAction.INSERT)
                        {
                            lblMessage.Text = "Thêm mới bản ghi thành công!";
                        }
                        else if (formAction == FormAction.EDIT)
                        {
                            lblMessage.Text = "Cập nhật bản ghi thành công!";
                        }
                        else if (formAction == FormAction.DELETE)
                        {
                            lblMessage.Text = "Xóa bản ghi thành công!";
                        }
                    }
                    else if (messageType == MessageType.WARNING)
                    {

                        if (formAction == FormAction.DOITUONG)
                        {
                            lblMessage.Text = "Chưa nhập đối tượng!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Chưa nhập đối tượng!";
                        }
                        else if (formAction == FormAction.CONVERT_DATE)
                        {
                            lblMessage.Text = "Ngày chưa nhập hoặc không hợp lệ!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Ngày chưa nhập hoặc không hợp lệ!";
                        }
                        else if (formAction == FormAction.INSERT)
                        {
                            lblMessage.Text = "Không có quyền thêm số liệu!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Không có quyền thêm số liệu!";
                        }
                        else if (formAction == FormAction.EDIT)
                        {
                            lblMessage.Text = "Không có quyền sửa số liệu!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Không có quyền sửa số liệu!";
                        }
                        else if (formAction == FormAction.DELETE)
                        {
                            lblMessage.Text = "Không có quyền xóa số liệu!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Không có quyền xóa số liệu!";
                        }
                        else if (formAction == FormAction.NOINHAPXUAT)
                        {
                            lblMessage.Text = "Nơi nhập không thể là nơi xuất !";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Nơi nhập không thể là nơi xuất !";
                        }
                        else if (formAction == FormAction.NCC)
                        {
                            lblMessage.Text = "Nhà cung cấp không thể rỗng !";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Nhà cung cấp không thể rỗng !";
                        }
                        else if (formAction == FormAction.VITRI)
                        {
                            lblMessage.Text = "Nơi nhập, xuất không thể rỗng!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Nơi nhập, xuất không thể rỗng!";
                        }
                        else if (formAction == FormAction.SLTON)
                        {
                            lblMessage.Text = "Số lượng không được lớn hơn số lượng tồn !";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Số lượng không được lớn hơn số lượng tồn !";
                        }
                        else if (formAction == FormAction.XuLy)
                        {
                            lblMessage.Text = "Không cho phép xóa thông tin này !";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Không cho phép xóa thông tin này !";
                        }
                        else
                        {
                            lblMessage.Text = "Nhập dữ liệu thiếu hoặc sai định dạng!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Nhập dữ liệu thiếu hoặc sai định dạng!";
                        }
                        AlertMessage(Error_WarningMessage);
                    }
                    else if (messageType == MessageType.ERROR)
                    {
                        //lblMessage.CssClass = "errormesage";

                        if (formAction == FormAction.INSERT)
                        {
                            lblMessage.Text = "Có lỗi khi thêm mới bản ghi. Trùng hoặc dữ liệu không hợp lệ!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Có lỗi khi thêm mới bản ghi. Trùng hoặc dữ liệu không hợp lệ!";
                        }
                        else if (formAction == FormAction.EDIT)
                        {
                            lblMessage.Text = "Có lỗi khi cập nhật bản ghi. Dữ liệu không hợp lệ!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Có lỗi khi cập nhật bản ghi. Dữ liệu không hợp lệ!";
                        }
                        else if (formAction == FormAction.DELETE)
                        {
                            lblMessage.Text = "Có lỗi khi xóa bản ghi!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Có lỗi khi xóa bản ghi!";
                        }
                        else if (formAction == FormAction.REPORTS)
                        {
                            lblMessage.Text = "Có lỗi khi trích xuất báo cáo!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Có lỗi khi trích xuất báo cáo!";
                        }
                        else if (formAction == FormAction.CONVERT_DATE)
                        {
                            lblMessage.Text = "Ngày tháng sai định dạng!";
                            setColertLableMessage(lblMessage);
                            Error_WarningMessage = "Ngày tháng sai định dạng!";
                        }
                        AlertMessage(Error_WarningMessage);
                    }
                    else
                    {
                        lblMessage.Text = string.Empty;
                    }
                }
            }
        }

        /*
        public object Pub_rpt
        {
            get
            {
                if (Session[SessionVariables.Pub_rpt] != null)
                    return Session[SessionVariables.Pub_rpt];
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sNguoiSD] = value;
            }
        }*/
        //public string Pub_sMaBN
        //{
        //    get
        //    {
        //        if (Session[SessionVariables.Pub_sMaBN] != null)
        //            return Session[SessionVariables.Pub_sMaBN].ToString();
        //        else
        //            return null;
        //    }
        //    set
        //    {
        //        Session[SessionVariables.Pub_sMaBN] = value;
        //    }
        //}
        public string Pub_sMaBN
        {
            get
            {
                if (Session[SessionVariables.Pub_sMaBN] != null)
                    return Session[SessionVariables.Pub_sMaBN].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sMaBN] = value;
            }
        }
        public string BH_internet
        {
            get
            {

                return ConfigurationManager.AppSettings["BH_internet"].ToString();
            }
        }
        public string BH_pass
        {
            get
            {

                return ConfigurationManager.AppSettings["BH_pass"].ToString();
            }
        }
        public string BH_user
        {
            get
            {

                return ConfigurationManager.AppSettings["BH_user"].ToString();
            }
        }
        public string Pub_sNguoiSD
        {
            get
            {
                if (Session[SessionVariables.Pub_sNguoiSD] != null)
                    return Session[SessionVariables.Pub_sNguoiSD].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sNguoiSD] = value;
            }
        }
        public string Pub_sQuay
        {
            get
            {
                if (Session[SessionVariables.Pub_sQuay] != null)
                    return Session[SessionVariables.Pub_sQuay].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sQuay] = value;
            }
        }
        public string Pub_sTenQuay
        {
            get
            {
                if (Session[SessionVariables.Pub_sTenQuay] != null)
                    return Session[SessionVariables.Pub_sTenQuay].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sTenQuay] = value;
            }
        }
        public string Pub_sAccount
        {
            get
            {
                if (Session[SessionVariables.Pub_sAccount] != null)
                    return Session[SessionVariables.Pub_sAccount].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sAccount] = value;
            }
        }

        public string Pub_sTenNguoiSD
        {
            get
            {
                if (Session[SessionVariables.Pub_sTenNguoiSD] != null)
                    return Session[SessionVariables.Pub_sTenNguoiSD].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.Pub_sTenNguoiSD] = value;
            }
        }
        public int Pub_TransactionID
        {
            get
            {
                if (Session[SessionVariables.Pub_TransactionID] != null)
                    return int.Parse(Session[SessionVariables.Pub_TransactionID].ToString());
                else
                    return 0;
            }
            set
            {
                Session[SessionVariables.Pub_TransactionID] = value;
            }
        }
        public string Pub_QueryID
        {
            get
            {
                if (Session[SessionVariables.Pub_QueryID] != null)
                    return Session[SessionVariables.Pub_QueryID].ToString();
                else
                    return "";
            }
            set
            {
                Session[SessionVariables.Pub_QueryID] = value;
            }
        }
        public string Pub_sCodePatient
        {
            get
            {
                if (Session[SessionVariables.Pub_sCodePatient] != null)
                    return Session[SessionVariables.Pub_sCodePatient].ToString();
                else
                    return "";
            }
            set
            {
                Session[SessionVariables.Pub_sCodePatient] = value;
            }
        }

        #region  TÊN MENU

        private const string viewState_TenMN = "viewState_TenMN";
        public string Pub_sTenMN
        {
            get
            {
                if (ViewState[viewState_TenMN] == null)
                {
                    if (_MaMN != null)
                    {
                        // TODO
                        DB.MenuDataTable dt = new MenuTableAdapter().GetMenuByMaMN(_MaMN) as DB.MenuDataTable;
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            DB.MenuRow row = dt.Rows[0] as DB.MenuRow;

                            if (row != null)
                            {
                                ViewState[viewState_TenMN] = row.TenMN;
                                return ViewState[viewState_TenMN].ToString();
                            }
                        }
                    }

                    return null;
                }
                else
                {
                    return ViewState[viewState_TenMN].ToString();
                }

                /*
                if (Session[SessionVariables.CurrentMenuItem] != null)
                    return Session[SessionVariables.CurrentMenuItem].ToString();
                else
                    return null;*/
            }
            set
            {
                ViewState[viewState_TenMN] = value;
            }
        }

        #endregion


        public void ShowPageTitle()
        {
            /*
            if (Session[SessionVariables.CurrentMenuItem] != null)
                lblFormTitle.Text = Session[SessionVariables.CurrentMenuItem].ToString();
             */

            if (Pub_sTenMN != null)
            {
                if (this.Master != null)
                {
                    Label lblFormTitle = this.Master.FindControl("lblFormTitle") as Label;
                    if (lblFormTitle != null)
                    {
                        lblFormTitle.Text = Pub_sTenMN;


                        //      Using the Title property of Page requires a header control on the page. (e.g. <head runat="server" />).
                        //Page.Title = Pub_sTenMN;
                    }
                }
                else
                {
                    Label lblFormTitle = this.FindControl("lblFormTitle") as Label;
                    if (lblFormTitle != null)
                    {
                        lblFormTitle.Text = Pub_sTenMN;


                        //      Using the Title property of Page requires a header control on the page. (e.g. <head runat="server" />).
                        //Page.Title = Pub_sTenMN;
                    }
                }
            }
            ShowPageThongBao();

        }
        public void ShowPageTitle(string customTitlePage)
        {
            if (!string.IsNullOrEmpty(customTitlePage))
            {
                Label lblFormTitle = this.Master.FindControl("lblFormTitle") as Label;
                if (lblFormTitle != null)
                {
                    lblFormTitle.Text = customTitlePage;
                }
            }

        }
        public void ShowPageThongBao()
        {
            /*
            if (Session[SessionVariables.CurrentMenuItem] != null)
                lblFormTitle.Text = Session[SessionVariables.CurrentMenuItem].ToString();
             */
            if (_MaMN != "" && _MaMN != null)
            {
                if (_MaMN.Length >= 6)
                {
                    if (_MaMN.Substring(0, 6) == "002003" || (_MaMN.Substring(0, 6) == "008005" && HTC.ShareVariables.pub_spC != "QN") || (_MaMN.Substring(0, 6) == "008005" && HTC.ShareVariables.pub_spC != "QN" && _MaMN != "008005005"))
                    {

                        HTC.Business.Duoc.ThongBaoList tbl = HTC.Business.Duoc.ThongBaoList.GetAllThongBao(false);
                        if (tbl.Count > 0)
                        {
                            Label lblFormTitle = this.Master.FindControl("lblFormThongBao") as Label;
                            if (System.DateTime.Now.AddDays(-3) < DateTime.Parse(tbl[0].TuNgay))
                                if (tbl[0].conhan == "" && tbl[0].hethan == "")
                                    lblFormTitle.Text = tbl[0].Thongbao;
                                else if (tbl[0].conhan == "" && tbl[0].hethan != "")
                                    lblFormTitle.Text = (tbl[0].hethan != "" ? tbl[0].hethan + " hết hạn," : "") + tbl[0].Thongbao;

                                else
                                    lblFormTitle.Text = (tbl[0].conhan != "" ? tbl[0].conhan + " còn hạn," : "") + (tbl[0].hethan != "" ? tbl[0].hethan + " hết hạn," : "") + tbl[0].Thongbao;
                        }
                    }
                    else if (_MaMN.Substring(0, 6) == "005011" || (_MaMN.Substring(0, 6) == "005012" && HTC.ShareVariables.pub_spC == "QN"))
                    {
                        if (Application["Pub_sThongBaoThuoc"] != null)
                        {
                            if (Application["Pub_sThongBaoThuoc"].ToString() != "")
                            {
                                Label lblFormTitle = this.Master.FindControl("lblFormThongBao") as Label;
                                lblFormTitle.Text = Application["Pub_sThongBaoThuoc"].ToString();
                            }
                        }
                    }
                }
            }
        }
        public string Pub_sMaMay
        {

            get
            {
                if (Session[SessionVariables.Pub_sMaMay] == null)
                    Session[SessionVariables.Pub_sMaMay] = GetIP4Address();
                else if (Session[SessionVariables.Pub_sMaMay].ToString() == "")
                    Session[SessionVariables.Pub_sMaMay] = GetIP4Address();
                return Session[SessionVariables.Pub_sMaMay].ToString();
            }
            set
            {
                Session[SessionVariables.Pub_sMaMay] = value;
            }

        }
        public string GetComputerName()
        {
            string VisitorsIPAddr = string.Empty;
            string LogonUserIdentity = string.Empty;
            string UserAgent = string.Empty;
            string UserHostName = string.Empty;
            string currentName = string.Empty;
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                VisitorsIPAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
            {
                VisitorsIPAddr = HttpContext.Current.Request.UserHostAddress;
                //  UserAgent = HttpContext.Current.Request.UserAgent.ToString();
                //  currentName = HttpContext.Current.User.Identity.Name.ToString();
                // UserHostName = HttpContext.Current.Request.UserHostName.ToString();
            }
            try
            {
                var hostEntry = Dns.GetHostEntry(VisitorsIPAddr);
                return hostEntry.HostName;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        public bool pub_bQadmin
        {
            get
            {
                if (Session[SessionVariables.pub_bQadmin] == null)
                    return false;

                return (bool)Session[SessionVariables.pub_bQadmin];
            }
            set
            {
                Session[SessionVariables.pub_bQadmin] = value;
            }
        }
        public bool pub_bSgia
        {
            get
            {
                if (Session[SessionVariables.pub_bSgia] == null)
                    return false;

                return (bool)Session[SessionVariables.pub_bSgia];
            }
            set
            {
                Session[SessionVariables.pub_bSgia] = value;
            }
        }
        public string _MaRole
        {
            get
            {
                if (Session[SessionVariables.pub_maRole] != null)
                    return Session[SessionVariables.pub_maRole].ToString();
                else
                    return null;
            }
            set
            {
                Session[SessionVariables.pub_maRole] = value;
            }
        }
        public byte _ShowView
        {
            get
            {
                if (Session[SessionVariables.pub_showview] != null)
                    return byte.Parse(Session[SessionVariables.pub_showview].ToString());
                else
                    return 0;
            }
            set
            {
                Session[SessionVariables.pub_showview] = value;
            }
        }
        public string _ShowMaKhoa
        {
            get
            {
                if (Session[SessionVariables.pub_showMaKhoa] != null)
                    return Session[SessionVariables.pub_showMaKhoa].ToString();
                else
                    return "";
            }
            set
            {
                Session[SessionVariables.pub_showMaKhoa] = value;
            }
        }
        public string _ShowMaSoKham
        {
            get
            {
                if (Session[SessionVariables.pub_showMaSoKham] != null)
                    return Session[SessionVariables.pub_showMaSoKham].ToString();
                else
                    return "";
            }
            set
            {
                Session[SessionVariables.pub_showMaSoKham] = value;
            }
        }
        public string _ShowBSKham
        {
            get
            {
                if (Session[SessionVariables.pub_showMaSoKham] != null)
                    return Session[SessionVariables.pub_showMaSoKham].ToString();
                else
                    return "";
            }
            set
            {
                Session[SessionVariables.pub_showMaSoKham] = value;
            }
        }

        public string _ShowSoTT
        {
            get
            {
                if (Session[SessionVariables.pub_showSoTT] != null)
                    return Session[SessionVariables.pub_showSoTT].ToString();
                else
                    return "0";
            }
            set
            {
                Session[SessionVariables.pub_showSoTT] = value;
            }
        }
        public string pub_sKyHieuHD
        {
            get
            {
                if (Application["KHHD" + Pub_sNguoiSD] != null)
                    return Application["KHHD" + Pub_sNguoiSD].ToString();
                else
                    return null;
            }
            set
            {
                Application["KHHD" + Pub_sNguoiSD] = value;
            }
        }

        public string pub_sSoHD
        {
            get
            {
                if (Application["SoHD" + Pub_sNguoiSD] != null)
                    return Application["SoHD" + Pub_sNguoiSD].ToString();
                else
                    return null;
            }
            set
            {
                Application["SoHD" + Pub_sNguoiSD] = value;
            }
        }
        private const string viewState_Pub_bQuyenForm = "Pub_bQuyenForm";
        public HTC.ShareVariables.KieuFormChiTiet Pub_bQuyenForm
        {
            get
            {
                if (ViewState[viewState_Pub_bQuyenForm] != null)
                    return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];
                else
                {

                    if (_MaRole != null && _MaMN != null)
                    {
                        if (Request["IDMN"] != null)
                        {
                            string currentURL = GetCurrentURL();

                            if (!string.IsNullOrEmpty(currentURL))
                            {
                                if (currentURL.Contains("frmDSBNKhamBenhView") == true)
                                {
                                    return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];

                                }
                                else if (Request["IDMN"] != null && (currentURL.Contains("frmDSBNKhamBenh_") == true || currentURL.Contains("frmKhamBenh_") == true || currentURL.Contains("frmLapPhieu.aspx") == true || currentURL.Contains("frmNhapChiDinhNew.aspx") == true || currentURL.Contains("frmNhapChiDinhDSNew.aspx") == true || currentURL.Contains("frmThanhToanRaVien.aspx") == true || currentURL.Contains("frmThanhToanRaVienDS.aspx") == true))
                                {
                                    return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];

                                }
                            }
                        }
                        HTC.Business.CategoryList.DMRole roleList = HTC.Business.CategoryList.DMRole.GetDMRole(_MaRole);
                        if (roleList != null && roleList.QuyenRoleList[_MaMN] != null)
                        {
                            int tempI = roleList.QuyenRoleList[_MaMN].QuyenMN;
                            ViewState[viewState_Pub_bQuyenForm] = tempI;
                            if ((HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm] == HTC.ShareVariables.KieuFormChiTiet.fNotAccess)
                                if (roleList != null && roleList.QuyenRoleList[_MaMN2] != null)
                                {
                                    int tempI2 = roleList.QuyenRoleList[_MaMN2].QuyenMN;
                                    ViewState[viewState_Pub_bQuyenForm] = tempI2;

                                    return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];
                                }
                            return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];
                        }
                        else if (_MaRole != null && _MaMN2 != null)
                        {
                            if (roleList != null && roleList.QuyenRoleList[_MaMN2] != null)
                            {
                                int tempI = roleList.QuyenRoleList[_MaMN2].QuyenMN;
                                ViewState[viewState_Pub_bQuyenForm] = tempI;
                                if ((HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm] == HTC.ShareVariables.KieuFormChiTiet.fNotAccess)
                                    if (roleList != null && roleList.QuyenRoleList[_MaMN] != null)
                                    {
                                        int tempI2 = roleList.QuyenRoleList[_MaMN].QuyenMN;
                                        ViewState[viewState_Pub_bQuyenForm] = tempI2;

                                        return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];
                                    }
                                return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];
                            }
                        }
                    }
                    else if (_MaRole != null && _MaMN2 != null)
                    {
                        HTC.Business.CategoryList.DMRole roleList = HTC.Business.CategoryList.DMRole.GetDMRole(_MaRole);
                        if (roleList != null && roleList.QuyenRoleList[_MaMN2] != null)
                        {
                            int tempI = roleList.QuyenRoleList[_MaMN2].QuyenMN;
                            ViewState[viewState_Pub_bQuyenForm] = tempI;

                            return (HTC.ShareVariables.KieuFormChiTiet)ViewState[viewState_Pub_bQuyenForm];
                        }
                    }
                }

                return HTC.ShareVariables.KieuFormChiTiet.fNotAccess;
            }
            set
            {
                ViewState[viewState_Pub_bQuyenForm] = value;
            }
        }


        private static string GetIP4Address(Boolean ip = false)
        {
            string IP4Address = String.Empty;
            //if (HTC.ShareVariables.pub_spC == "HU"&& ip==false )
            //{
            //   // NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            //   // // nics[0].GetPhysicalAddress().ToString();
            //   //// string strHostName = "";
            //   //// strHostName = System.Net.Dns.GetHostName();
            //   // //return nics[0].GetPhysicalAddress().ToString();
            //   // foreach (NetworkInterface nic in nics)
            //   // {
            //   //     if (nic.OperationalStatus == OperationalStatus.Up )
            //   //     {
            //   //         return nic.GetPhysicalAddress().ToString();
            //   //     }
            //   // }
            //    //ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //    //ManagementObjectCollection moc = mc.GetInstances();
            //    //string MACAddress = String.Empty;
            //    //foreach (ManagementObject mo in moc)
            //    //{
            //    //    if (MACAddress == String.Empty)
            //    //    {
            //    //        if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
            //    //    }
            //    //    mo.Dispose();
            //    //}

            //    //MACAddress = MACAddress.Replace(":", "");
            //    //return MACAddress;
            //    string[] computer_name = System.Net.Dns.GetHostEntry(HttpContext.Current.Request.ServerVariables["remote_addr"]).HostName.Split(new Char[] { '.' });
            //    String ecn = System.Environment.MachineName;
            //    return computer_name[0].ToString();
            //}
            //else if (HTC.ShareVariables.pub_spC == "PS" && ip == false)
            //{
            //    string[] computer_name = System.Net.Dns.GetHostEntry(HttpContext.Current.Request.ServerVariables["remote_addr"]).HostName.Split(new Char[] { '.' });
            //    String ecn = System.Environment.MachineName;
            //   return  computer_name[0].ToString();
            //}
            try
            {
                foreach (IPAddress IPA in Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
                {
                    if (IPA.AddressFamily.ToString() == "InterNetwork")
                    {
                        IP4Address = IPA.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            if (IP4Address != String.Empty)
            {
                return IP4Address;
            }
            try
            {
                foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (IPA.AddressFamily.ToString() == "InterNetwork")
                    {
                        IP4Address = IPA.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            return IP4Address;
        }
        public string vvdate(string sdate)
        {

            return sdate.Substring(3, 2) + "/" + sdate.Substring(0, 2) + "/" + sdate.Substring(6);

        }
        public string vdate(string sdate)
        {
            //DateTime.Now.ToString(ConfigurationManager.AppSettings["DateFormat"]);            

            //if (sdate == "")
            //    return "";
            //else if (sdate.Length == 10)
            //   //return sdate;
            //    return sdate.Substring(3, 2) + "/" + sdate.Substring(0, 2) + "/" + sdate.Substring(6, 4);
            //else if (sdate.Length == 9)
            //{
            //    if (byte.Parse(sdate.Substring(0, 2).Replace("/", "")) < 10)
            //    {
            //        string month = "0" + sdate.Substring(0, 1);
            //        string day = sdate.Substring(2, 2);
            //        return day + "/" + month + "/" + sdate.Substring(6, 4);
            //    }
            //    else
            //    {
            //        string month = sdate.Substring(0, 2);
            //        string day = "0" + sdate.Substring(3, 1);
            //        return day + "/" + month + "/" + sdate.Substring(6, 4);
            //    }

            //}
            //else if (sdate.Length == 8)
            //    return "0" + sdate.Substring(2, 1) + "/" + "0" + sdate.Substring(0, 1) + "/" + sdate.Substring(4, 4);
            //else
            //    return sdate.Substring(3, 2) + "/" + sdate.Substring(0, 2) + "/" + sdate.Substring(6, 4) + " " + sdate.Substring(11, 5);            

            return sdate;

        }
        public Boolean CheckDate(string date, byte loai = 2)
        {
            if (loai == 0)
                if ((DateTime.Parse(date) - DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"))).Days > 0)
                {
                    Label lblMessage = this.Master.FindControl("lblMessage") as Label;
                    lblMessage.Text = "Ngày phải trước ngày hiện tại!";
                    return false;
                }
            if (loai == 1)
                if ((DateTime.Parse(date) - DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"))).Days < 0)
                {
                    Label lblMessage = this.Master.FindControl("lblMessage") as Label;
                    lblMessage.Text = "Ngày phải sau ngày hiện tại!";
                    return false;
                }
            return true;
        }
        public string vdateto(string sdate)
        {
            if (sdate == "")
                return "";
            else
                return sdate.Substring(2, 2) + "/" + sdate.Substring(0, 2) + "/" + sdate.Substring(4, 4);


        }
        public string vdatefrom(string sdate)
        {
            if (sdate == "")
                return "";
            else
                return sdate.Substring(3, 2) + sdate.Substring(0, 2) + sdate.Substring(6, 4);


        }

        public string ExtractGridItemDataKey(GridEditableItem editableItem, string dataKey)
        {
            return editableItem.GetDataKeyValue(dataKey).ToString();
        }

        public DateTime ConvertStringToDate(string date)
        {
            try
            {
                //return DateTime.Parse(date.Trim());

                string format = "dd/MM/yyyy";
                return DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
                //return DateTime.ParseExact(date, ConfigurationManager.AppSettings["DateFormat"], CultureInfo.InvariantCulture);

            }
            catch (Exception ex)
            {
                return DateTime.MinValue;
            }
        }

        public DateTime ConvertStringToDateTime(string date)
        {
            try
            {
                //return DateTime.Parse(date.Trim());
                string format = "dd/MM/yyyy hh:mm:ss";
                return DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
                //return DateTime.ParseExact(date, ConfigurationManager.AppSettings["DateTimeFormat"], CultureInfo.InvariantCulture);

            }
            catch (Exception ex)
            {
                return DateTime.MinValue;
            }
        }

        public Boolean EqualsToDateTime(string date1, string date2, int type = 0, byte day = 0, string chuoi = "")
        {
            try
            {
                //return DateTime.Parse(date.Trim());
                DateTime day1 = DateTime.ParseExact(date1, ConfigurationManager.AppSettings["DateFormat"], CultureInfo.InvariantCulture);
                DateTime day2 = DateTime.ParseExact(date2, ConfigurationManager.AppSettings["DateFormat"], CultureInfo.InvariantCulture);
                if (type == 0) //khong lon hon
                    if (day1.AddDays(day).CompareTo(day2) > 0)
                    {

                        if (day == 0)
                            if (chuoi == "")
                                ShowMessage("Từ ngày không lớn hơn đến ngày");
                            else
                                ShowMessage(chuoi);
                        else
                            if (chuoi == "")
                                ShowMessage("Từ ngày không nhỏ hơn " + day.ToString() + " so với đến ngày");
                            else
                                ShowMessage(chuoi);

                        return false;

                    }
                    else
                        return true;
                else if (type == -1) // khong cach nhau
                {
                    if (day1.CompareTo(day2) > 0)
                    {
                        if (chuoi == "")
                            ShowMessage("Từ ngày không lớn hơn đến ngày");
                        else
                            ShowMessage(chuoi);

                        return false;

                    }
                    if (day1.AddDays(day).CompareTo(day2) < 0)
                    {
                        if (day == 0)
                            if (chuoi == "")
                                ShowMessage("Từ ngày không lớn hơn đến ngày");
                            else
                                ShowMessage(chuoi);
                        else
                            if (chuoi == "")
                                ShowMessage("Từ ngày không nhỏ hơn " + day.ToString() + " so với đến ngày");
                            else
                                ShowMessage(chuoi);
                        return false;

                    }
                    else
                        return true;
                }


            }
            catch (Exception ex)
            {
                ShowMessage("Định dạng ngày tháng bị lỗi" + ex.Message); //HandleException(ex, FormAction.CONVERT_DATA);

                //throw;
            }
            return true;
        }
        public DateTime ExtractDateValue(HttpRequestBase request, string dateControlId)
        {
            var dateAsString = ExtractStringValue(request, dateControlId);
            DateTime value = DateTime.MinValue;
            if (!DateTime.TryParse(dateAsString, out value))
            {
                DateTime.TryParseExact(dateAsString, "yyyy-MM-dd-HH-mm-ss",
                    DateTimeFormatInfo.InvariantInfo,
                    DateTimeStyles.None,
                    out value);
            }
            return value;
        }

        public string ExtractStringValue(HttpRequestBase request, string controlId)
        {
            return request.Form.Keys.OfType<string>()
                .Where(postedValue => postedValue.EndsWith(controlId))
                .Select(postedValue => request.Form[postedValue])
                .FirstOrDefault();
        }
        public void HandleException(Exception ex, FormAction action)
        {
            //bool t = ExceptionPolicy.HandleException(ex, "AllExceptionsPolicy");

            //bool rethrow = ExceptionPolicy.HandleException(ex, "Business Layer Policy");

            ////var container = new UnityContainer().AddNewExtension<EnterpriseLibraryCoreExtension>();
            //if (rethrow)
            //{
            //    throw ex;
            //}
            //ExceptionManager exManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();            
            //ExceptionPolicy.SetExceptionManager(exManager);            
        }



        //public void HandleException(Exception ex, FormAction action)
        //{
        //    //bool t = ExceptionPolicy.HandleException(ex, "AllExceptionsPolicy");

        //    bool rethrow = ExceptionPolicy.HandleException(ex, "Business Layer Policy");

        //    //var container = new UnityContainer().AddNewExtension<EnterpriseLibraryCoreExtension>();
        //    if (rethrow)
        //    {
        //        throw ex;
        //    }
        //    //ExceptionManager exManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();            
        //    //ExceptionPolicy.SetExceptionManager(exManager);            
        //}








        public bool _IsBVPhuSan
        {
            get
            {
                return HTC.ShareVariables.pub_spC.Equals("PS");
            }
        }

        public bool _IsBVYHocCoTruyen
        {
            get
            {
                return HTC.ShareVariables.pub_spC.Equals("YH") || HTC.ShareVariables.pub_spC.Equals("QN");
            }
        }

        public bool _IsBVTWHue
        {
            get
            {
                return HTC.ShareVariables.pub_spC.Equals("HU");
            }
        }
        public static void MergeRows(RadGrid grdChiTiet, string columnName)
        {
            for (int i = grdChiTiet.Items.Count - 1; i > 0; i--)
            {
                if (grdChiTiet.Items[i][columnName].Text.Equals(grdChiTiet.Items[i - 1][columnName].Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    grdChiTiet.Items[i - 1][columnName].RowSpan = grdChiTiet.Items[i][columnName].RowSpan < 2 ? 2 : grdChiTiet.Items[i][columnName].RowSpan + 1;
                    grdChiTiet.Items[i][columnName].Visible = false;
                    //grdChiTiet.Items[i][columnName].Text = "&nbsp;";  
                }
            }

            //To mau lai cho Radgird 
            foreach (GridDataItem dataItem in grdChiTiet.Items)
            {
                foreach (GridColumn col in grdChiTiet.MasterTableView.RenderColumns)
                {
                    //if (dataItem[col.UniqueName].Text == string.Empty) 
                    dataItem[col.UniqueName].Style.Add("border-left", "solid 1px #ededed");
                }
            }
        }

        private const string viewState_CurrentAction = "CurrentAction";
        public FormAction _CurrentAction
        {

            get
            {
                if (ViewState[viewState_CurrentAction] == null)
                {
                    return FormAction.INSERT;
                }

                return (FormAction)ViewState[viewState_CurrentAction];
            }

            set
            {
                ViewState[viewState_CurrentAction] = value;
            }
        }

        public string Addx(string Xau, int Dodai, string KyTu = "0")
        {

            Xau = (int.Parse(Xau) + 1).ToString();
            if (KyTu == null)
                KyTu = "0";
            if (KyTu != "")
            {
                int length = Xau.Length;
                while (length < Dodai)
                {
                    Xau = KyTu + Xau;
                    length = length + 1;
                }
            }
            return Xau;

        }
        public void SetGridCellFocus(object sender, GridItemEventArgs e, string columnName)
        {
            if (e.Item is GridEditableItem && e.Item.IsInEditMode)
            {
                GridEditableItem item = (GridEditableItem)e.Item;
                if (item != null)
                {
                    Control dataField = item[columnName].Controls[0];

                    if (dataField != null)
                    {
                        if (dataField is LiteralControl)
                        {
                            dataField = item[columnName].Controls[1];
                        }

                        dataField.Focus();
                    }
                }
            }
        }

        public bool CheckReportViewerReload(DataSet ReportData)
        {
            if (ReportData != null)
            {
                if (Request.Params["__EVENTTARGET"] != null)
                {
                    string eTarget = Request.Params["__EVENTTARGET"].ToString().Trim();
                    if (!string.IsNullOrEmpty(eTarget))
                    {
                        if (eTarget.Contains("baraction")
                            || eTarget.Contains("ContentPlaceHolder1")
                                    || eTarget.Contains("grdChiTiet")
                                    || eTarget.Contains("grdChitiet") || eTarget.Contains("grdDanhSach") || eTarget.Contains("grdMT") || eTarget.Contains("grdVSHK") || eTarget.Contains("grdDSChiSo"))
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
            }
            else
                return false;
            return true;
        }
        public void ResetLoginApplication(string loginName)
        {
            string containKey = string.Empty;

            if (string.IsNullOrEmpty(loginName))
                containKey = "MenuLevel";
            else
                containKey = loginName;


            List<string> allApplicationKeys = Application.AllKeys.ToList<string>();
            for (int i = allApplicationKeys.Count - 1; i > 0; i--)
            {
                if (allApplicationKeys[i].Contains(containKey))
                {
                    Application.Remove(allApplicationKeys[i]);
                    allApplicationKeys.Remove(allApplicationKeys[i]);
                }
            }

        }

        protected void InitTabIndexForRadGrid(RadGrid grd, GridEditableItem item, short tabIndex = 4)
        {
            if (item.IsInEditMode && item is GridEditableItem)
            {
                for (int i = 0; i < grd.MasterTableView.Columns.Count; i++)
                {
                    //item.TabIndex = tabIndex;
                    if (item[grd.MasterTableView.Columns[i]] != null && grd.MasterTableView.Columns[i].Display == true && item[grd.MasterTableView.Columns[i]].Controls.Count > 0)
                    {
                        Control control = item[grd.MasterTableView.Columns[i]].Controls[0];

                        if (control is Button)
                        {
                            ((Button)control).TabIndex = 1100;
                        }
                        else if (control is ImageButton)
                        {
                            ((ImageButton)control).TabIndex = 1100;
                        }
                        else if (control is RadComboBox)
                        {
                            ((RadComboBox)control).TabIndex = tabIndex;
                            ((RadComboBox)control).CssClass = "inputColumRight";
                        }
                        else if (control is TextBox)
                        {
                            if (((TextBox)control).ReadOnly == false && ((TextBox)control).Enabled == true)
                            {
                                ((TextBox)control).TabIndex = tabIndex;
                                ((TextBox)control).CssClass = "inputColumRight";
                            }
                        }
                        else if (control is CheckBox)
                        {
                            if (((CheckBox)control).Enabled == true)
                            {
                                ((CheckBox)control).TabIndex = tabIndex;
                                ((CheckBox)control).CssClass = "inputColumRight";
                            }
                        }
                        else if (control is RadNumericTextBox)
                        {
                            //if (item[grd.MasterTableView.Columns[i]].Controls[0] is TextBox && (((TextBox)item[grd.MasterTableView.Columns[i]].Controls[0]).ReadOnly == false && ((TextBox)item[grd.MasterTableView.Columns[i]].Controls[0]).Enabled == true))                       

                            ((RadNumericTextBox)control).TabIndex = tabIndex;
                            ((RadNumericTextBox)control).CssClass = "inputColumRight";
                        }

                    }
                }

            }
        }
        public enum DateInterval
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year
        }

        public int DateDiff(DateInterval intervalType, System.DateTime dateOne, System.DateTime dateTwo)
        {
            switch (intervalType)
            {
                case DateInterval.Day:
                case DateInterval.DayOfYear:
                    System.TimeSpan spanForDays = dateTwo - dateOne;
                    return (int)spanForDays.TotalDays;
                case DateInterval.Hour:
                    System.TimeSpan spanForHours = dateTwo - dateOne;
                    return (int)spanForHours.TotalHours;
                case DateInterval.Minute:
                    System.TimeSpan spanForMinutes = dateTwo - dateOne;
                    return (int)spanForMinutes.TotalMinutes;
                case DateInterval.Month:
                    return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
                case DateInterval.Quarter:
                    int dateOneQuarter = (int)System.Math.Ceiling(dateOne.Month / 3.0);
                    int dateTwoQuarter = (int)System.Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;
                case DateInterval.Second:
                    System.TimeSpan spanForSeconds = dateTwo - dateOne;
                    return (int)spanForSeconds.TotalSeconds;
                case DateInterval.Weekday:
                    System.TimeSpan spanForWeekdays = dateTwo - dateOne;
                    return (int)(spanForWeekdays.TotalDays / 7.0);
                case DateInterval.WeekOfYear:
                    System.DateTime dateOneModified = dateOne;
                    System.DateTime dateTwoModified = dateTwo;
                    while (dateTwoModified.DayOfWeek != System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateTwoModified = dateTwoModified.AddDays(-1);
                    }
                    while (dateOneModified.DayOfWeek != System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateOneModified = dateOneModified.AddDays(-1);
                    }
                    System.TimeSpan spanForWeekOfYear = dateTwoModified - dateOneModified;
                    return (int)(spanForWeekOfYear.TotalDays / 7.0);
                case DateInterval.Year:
                    return dateTwo.Year - dateOne.Year;
                default:
                    return 0;
            }
        }

        public void ShowFile(string spath)
        {
            try
            {
                //System.IO.FileInfo fileObj = new System.IO.FileInfo(spath);

                //fileObj.Attributes = System.IO.FileAttributes.ReadOnly;

                //System.Diagnostics.Process.Start(fileObj.FullName);
                // FileInfo file = new FileInfo(spath);
                //file.Attributes = System.IO.FileAttributes.ReadOnly;

                // Buffer to read 10K bytes in chunk:
                byte[] buffer = new Byte[10000];
                // Length of the file:
                int length;
                // Total bytes to read:
                long dataToRead;
                using (FileStream iStream = new FileStream(spath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    // Total bytes to read:
                    dataToRead = iStream.Length;

                    Context.Response.Clear();

                    if (Path.GetExtension(spath).ToLower() == ".wav")

                        Context.Response.ContentType = "audio/wav";
                    else if (Path.GetExtension(spath).ToLower() == ".mp3")
                        Context.Response.ContentType = "audio/mpeg";
                    else if (Path.GetExtension(spath).ToLower() == ".avi")
                        Context.Response.ContentType = "video/x-msvideo";
                    else if (Path.GetExtension(spath).ToLower() == ".WRF" || Path.GetExtension(spath).ToLower() == ".INTRO" || Path.GetExtension(spath).ToLower() == ".mp4" || Path.GetExtension(spath).ToLower() == ".mpeg")
                        Context.Response.ContentType = "video/mpeg";
                    else if (Path.GetExtension(spath).ToLower() == ".pdf")
                        Context.Response.ContentType = "application/pdf";
                    else if (Path.GetExtension(spath).ToLower() == ".ppt")
                        Context.Response.ContentType = "application/vnd.ms-powerpoint";
                    else if (Path.GetExtension(spath).ToLower() == ".doc")
                        Context.Response.ContentType = "application/msword";
                    else if (Path.GetExtension(spath).ToLower() == ".docx")
                        Context.Response.ContentType = "application/vnd.ms-word.document";
                    else if (Path.GetExtension(spath).ToLower() == ".xls")
                        Context.Response.ContentType = "application/vnd.ms-excel";
                    else if (Path.GetExtension(spath).ToLower() == ".xlsx")
                        Context.Response.ContentType = "application/vnd.ms-excel.12";
                    else if (Path.GetExtension(spath).ToLower() == ".rar")
                        Context.Response.ContentType = "application/rar";
                    else if (Path.GetExtension(spath).ToLower() == ".zip")
                        Context.Response.ContentType = "application/zip";
                    else if (Path.GetExtension(spath).ToLower() == ".gif")
                        Context.Response.ContentType = "image/gif";
                    else if (Path.GetExtension(spath).ToLower() == ".bmp")
                        Context.Response.ContentType = "image/bmp";
                    else if (Path.GetExtension(spath).ToLower() == ".ico")
                        Context.Response.ContentType = "image/vnd.microsoft.icon";
                    else if (Path.GetExtension(spath).ToLower() == ".jpeg")
                        Context.Response.ContentType = "image/jpeg";

                    //switch (Path.GetExtension(spath).ToLower())
                    //{
                    //    case "wav":
                    //        Context.Response.ContentType = "audio/wav";
                    //        break;
                    //    case "mp3":
                    //        Context.Response.ContentType = "audio/mpeg";
                    //        break;
                    //    case "avi":
                    //        Context.Response.ContentType = "video/x-msvideo";
                    //        break;
                    //    case "WRF":
                    //    case "INTRO":
                    //    case "mp4":
                    //    case "mpeg":
                    //        Context.Response.ContentType = "video/mpeg";
                    //        break;
                    //    case "pdf":
                    //        Context.Response.ContentType = "application/pdf";
                    //        break;
                    //    case "ppt":
                    //        Context.Response.ContentType = "application/vnd.ms-powerpoint";
                    //        break;
                    //    case "doc":
                    //        Context.Response.ContentType = "application/msword";
                    //        break;
                    //    case "docx":
                    //        Context.Response.ContentType = "application/vnd.ms-word.document.12";
                    //        break;
                    //    case "xls":
                    //        Context.Response.ContentType = "application/vnd.ms-excel";
                    //        break;
                    //    case "xlsx":
                    //        Context.Response.ContentType = "application/vnd.ms-excel.12";
                    //        break;
                    //    case "rar":
                    //        Context.Response.ContentType = "application/rar";
                    //        break;
                    //    case "zip":
                    //        Context.Response.ContentType = "application/zip";
                    //        break;
                    //    case "gif":
                    //        Context.Response.ContentType = "image/gif";
                    //        break;
                    //    case "bmp":
                    //        Context.Response.ContentType = "image/bmp";
                    //        break;
                    //    case "ico":
                    //        Context.Response.ContentType = "image/vnd.microsoft.icon";
                    //        break;
                    //    case "jpeg":
                    //        Context.Response.ContentType = "image/jpeg";
                    //        break;
                    //}
                    Context.Response.Cache.SetNoStore();
                    Context.Response.AddHeader("Content-Disposition", "attachment; filename=" + spath);
                    // Context.Response.AppendHeader("Content-Disposition", "inline; filename=" + file.Name);
                    //      Context.Response.AppendHeader("Content-Length", file.Length.ToString());
                    // Read the bytes.
                    while (dataToRead > 0)
                    {
                        // Verify that the client is connected.
                        if (Context.Response.IsClientConnected)
                        {
                            // Read the data in buffer.
                            length = iStream.Read(buffer, 0, 10000);

                            // Write the data to the current output stream.
                            Context.Response.OutputStream.Write(buffer, 0, length);

                            // Flush the data to the HTML output.
                            Context.Response.Flush();

                            buffer = new Byte[10000];
                            dataToRead = dataToRead - length;
                        }
                        else
                        {
                            //prevent infinite loop if user disconnects
                            dataToRead = -1;
                        }
                    }
                    // Context.Response.WriteFile(file.FullName);
                    Context.Response.End();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Context.Response.Close();
            }
        }
        public DataTable ConvertIsingleResuletoDataTable<T>(IEnumerable<T> anon)
        {
            DataTable results = new DataTable();
            int Row_Count = 0;
            if (anon != null)
            {
                PropertyInfo[] columns = null;

                foreach (T item in anon)
                {
                    if (columns == null)
                    {
                        columns = ((Type)item.GetType()).GetProperties();

                        foreach (PropertyInfo column in columns)
                        {
                            Type columnType = column.PropertyType;

                            if ((columnType.IsGenericType) && (columnType.GetGenericTypeDefinition()
                                == typeof(Nullable<>)))
                            {
                                columnType = columnType.GetGenericArguments()[0];
                            }

                            results.Columns.Add(new DataColumn(column.Name, columnType));
                        }
                    }

                    DataRow dr = results.NewRow();

                    foreach (PropertyInfo column in columns)
                    {
                        if (column.Name.Equals("Row_Number"))
                        {
                            Row_Count++;
                            dr["Row_Number"] = Row_Count.ToString();
                        }
                        else
                            dr[column.Name] = column.GetValue(item, null) == null ? DBNull.Value : column.GetValue(item, null);

                    }

                    results.Rows.Add(dr);

                }
            }

            return results;
        }
        public DataTable ConvertIsingleResuletoDataTable2<T>(IEnumerable<T> anon)
        {
            DataTable results = new DataTable();
            int Row_Count = 0;
            if (anon != null)
            {
                PropertyInfo[] columns = null;

                foreach (T item in anon)
                {
                    if (columns == null)
                    {
                        columns = ((Type)item.GetType()).GetProperties();

                        foreach (PropertyInfo column in columns)
                        {
                            Type columnType = column.PropertyType;

                            if ((columnType.IsGenericType) && (columnType.GetGenericTypeDefinition()
                                == typeof(Nullable<>)))
                            {
                                columnType = columnType.GetGenericArguments()[0];
                            }

                            results.Columns.Add(new DataColumn(column.Name, columnType));
                        }
                    }

                    DataRow dr = results.NewRow();

                    foreach (PropertyInfo column in columns)
                    {
                        if (column.Name.Equals("OrderNumber"))
                        {
                            Row_Count++;
                            dr["OrderNumber"] = Row_Count.ToString();
                        }
                        else
                            dr[column.Name] = column.GetValue(item, null) == null ? DBNull.Value : column.GetValue(item, null);

                    }

                    results.Rows.Add(dr);

                }
            }

            return results;
        }
        public DataTable ConvertIsingleResuletoDataTable3<T>(IEnumerable<T> anon)
        {
            DataTable results = new DataTable();
            int Row_Count = 0;
            if (anon != null)
            {
                PropertyInfo[] columns = null;

                foreach (T item in anon)
                {
                    if (columns == null)
                    {
                        columns = ((Type)item.GetType()).GetProperties();

                        foreach (PropertyInfo column in columns)
                        {
                            Type columnType = column.PropertyType;

                            if ((columnType.IsGenericType) && (columnType.GetGenericTypeDefinition()
                                == typeof(Nullable<>)))
                            {
                                columnType = columnType.GetGenericArguments()[0];
                            }

                            results.Columns.Add(new DataColumn(column.Name, columnType));
                        }
                    }

                    DataRow dr = results.NewRow();

                    foreach (PropertyInfo column in columns)
                    {
                        if (column.Name.Equals("STT"))
                        {
                            Row_Count++;
                            dr["STT"] = Row_Count.ToString();
                        }
                        else
                            dr[column.Name] = column.GetValue(item, null) == null ? DBNull.Value : column.GetValue(item, null);

                    }

                    results.Rows.Add(dr);

                }
            }

            return results;
        }
        protected void PrintExport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, string maprint = "")
        {
            try
            {
                string filename = Path.GetFileName(rpt.FileName);
                string fileadd = "";
                maprint = Pub_sNguoiSD + maprint;
                string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
                if (Directory.Exists(Server.MapPath(fileSavePatht)))
                    Directory.Delete(Server.MapPath(fileSavePatht), true);

                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                if (!Directory.Exists(Server.MapPath(fileSavePath)))
                    Directory.CreateDirectory(Server.MapPath(fileSavePath));
                //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
                if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"))
                    File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf");

                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf";


                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));

                //string popupScript = "<script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";
                //Context.Response.Write(popupScript);
                //// File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                //rpt.Dispose(); rpt = null;

                //// export the second page
                //report.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                //using CrystalDecisions.CrystalReports.Engine;
                CrystalDecisions.Shared.ExportRequestContext reqContext = new CrystalDecisions.Shared.ExportRequestContext();
                var exportOptions2 = new CrystalDecisions.Shared.ExportOptions
                {
                    ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                    FormatOptions = new CrystalDecisions.Shared.PdfFormatOptions { UsePageRange = false, FirstPageNumber = 1, LastPageNumber = 1 }
                };
                reqContext.ExportInfo = exportOptions2;
                var stream2 = rpt.FormatEngine.ExportToStream(reqContext);
                stream2.Seek(0, SeekOrigin.Begin);

                // //// merge the two PDF streams
                var combinedPdf = new PdfSharp.Pdf.PdfDocument();

                // //foreach (PdfPage page in PdfReader.Open(stream1, PdfDocumentOpenMode.Import).Pages)
                // //    combinedPdf.AddPage(page);
                int i = 0;
                foreach (PdfSharp.Pdf.PdfPage page in PdfSharp.Pdf.IO.PdfReader.Open(stream2, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import).Pages)
                {
                    if ((filename.Contains("crBCHoadon") == true || filename.Contains("CRPhieuTamThu") == true || filename.Contains("CRPhieuChi") == true) && i == 0)
                        combinedPdf.AddPage(page);
                    else if ((filename.Contains("crBCHoadon") == true || filename.Contains("CRPhieuTamThu") == true || filename.Contains("CRPhieuChi") == true) && i > 0)
                    {
                    }
                    else if (!(filename.Contains("crBCHoadon") == true || filename.Contains("CRPhieuTamThu") == true || filename.Contains("CRPhieuChi") == true))
                        combinedPdf.AddPage(page);
                    i++;

                }

                //// probably not the most efficient, but works
                //  var output = new MemoryStream();
                combinedPdf.Save(Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + maprint + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));

             
                string popupScript;
                //if (rpt.PrintOptions.PaperOrientation == PaperOrientation.Landscape)
                //{
                //    popupScript = " <style>@page{size:landscape;}</style> <script language='javascript'>";
                //    popupScript = popupScript + "var win = window.open('" + fileSavePath + "','');";


                //    popupScript = popupScript + "</script>";
                //}
                //else
                popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";

                Context.Response.Write(popupScript);
                // File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                rpt.Dispose(); rpt.Close(); rpt = null;
                // FileStreamResult(output, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf";
                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                //string popupScript = "<script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";
                //Context.Response.Write(popupScript);
                //// File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                //rpt.Dispose(); rpt = null;
            }
            catch (System.IO.IOException ex)
            {
                ShowMessage("Không in được báo cáo" + ex.Message);
                // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

            }
        }

        protected void PrintExportExcel(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt)
        {
            try
            {
                string filename = Path.GetFileName(rpt.FileName);
                string fileadd = "";
                string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
                if (Directory.Exists(Server.MapPath(fileSavePatht)))
                    Directory.Delete(Server.MapPath(fileSavePatht), true);

                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                if (!Directory.Exists(Server.MapPath(fileSavePath)))
                    Directory.CreateDirectory(Server.MapPath(fileSavePath));
                //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";


                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".xls";


                rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelWorkbook, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".xls"));

                string popupScript;
                popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";

                Context.Response.Write(popupScript);
                //// File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                rpt.Dispose(); rpt = null;
            }
            catch (System.IO.IOException ex)
            {
                ShowMessage("Không in được báo cáo" + ex.Message);
                // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

            }
        }
        protected void PrintExport1(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, string maprint = "")
        {
            try
            {
                string filename = Path.GetFileName(rpt.FileName);
                string fileadd = "";
                string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
                //if (Directory.Exists(Server.MapPath(fileSavePatht)))
                //    Directory.Delete(Server.MapPath(fileSavePatht), true);

                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                //if (!Directory.Exists(Server.MapPath(fileSavePath)))
                //    Directory.CreateDirectory(Server.MapPath(fileSavePath));
                //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
                //if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"))
                //    File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf");

                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                // fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf";
                fileSavePath = @"tem/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf";
                //Environment.SetEnvironmentVariable("TEMP", "<dir>");

                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));

                //string popupScript = "<script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";
                //Context.Response.Write(popupScript);
                //// File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                //rpt.Dispose(); rpt = null;

                //// export the second page
                //report.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                //using CrystalDecisions.CrystalReports.Engine;
                CrystalDecisions.Shared.ExportRequestContext reqContext = new CrystalDecisions.Shared.ExportRequestContext();
                var exportOptions2 = new CrystalDecisions.Shared.ExportOptions
                {
                    ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                    FormatOptions = new CrystalDecisions.Shared.PdfFormatOptions { UsePageRange = false, FirstPageNumber = 1, LastPageNumber = 1 }
                };
                reqContext.ExportInfo = exportOptions2;
                //  MemoryStream stream2 = (MemoryStream ) rpt.FormatEngine.ExportToStream(reqContext);
                var stream2 = rpt.FormatEngine.ExportToStream(reqContext);
                byte[] byteArray = new byte[stream2.Length];
                stream2.Read(byteArray, 0, Convert.ToInt32(stream2.Length - 1));
                //Response.Clear();
                //Response.Buffer = true;
                //Response.ClearContent();
                Response.AddHeader("Content-Disposition", " filename=" + (Server.MapPath(fileSavePath)) + "; size=" + byteArray.Length.ToString());

                Response.ContentType = "application/pdf";

                Response.BinaryWrite(byteArray);
                Response.Flush();


                //stream2.Seek(0, SeekOrigin.Begin);

                //// //// merge the two PDF streams
                //var combinedPdf = new PdfSharp.Pdf.PdfDocument();

                //// //foreach (PdfPage page in PdfReader.Open(stream1, PdfDocumentOpenMode.Import).Pages)
                //// //    combinedPdf.AddPage(page);
                //int i = 0;
                //foreach (PdfSharp.Pdf.PdfPage page in PdfSharp.Pdf.IO.PdfReader.Open(stream2, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import).Pages)
                //{
                //    if ((filename.Contains("crBCHoadon") == true || filename.Contains("CRPhieuTamThu") == true || filename.Contains("CRPhieuChi") == true) && i == 0)
                //        combinedPdf.AddPage(page);
                //    else if ((filename.Contains("crBCHoadon") == true || filename.Contains("CRPhieuTamThu") == true || filename.Contains("CRPhieuChi") == true) && i > 0)
                //    {
                //    }
                //    else if (!(filename.Contains("crBCHoadon") == true || filename.Contains("CRPhieuTamThu") == true || filename.Contains("CRPhieuChi") == true))
                //        combinedPdf.AddPage(page);
                //    i++;

                //}

                ////// probably not the most efficient, but works
                //var output = new MemoryStream();
                //combinedPdf.Save(Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + maprint + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));

                //string popupScript;
                ////if (rpt.PrintOptions.PaperOrientation == PaperOrientation.Landscape)
                ////{
                ////    popupScript = " <style>@page{size:landscape;}</style> <script language='javascript'>";
                ////    popupScript = popupScript + "var win = window.open('" + fileSavePath + "','');";


                ////    popupScript = popupScript + "</script>";
                ////}
                ////else
                //popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";
            }
            catch (System.IO.IOException ex)
            {
                ShowMessage("Không in được báo cáo" + ex.Message);
                // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

            }
        }
        protected void PrintExportWord(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt)
        {
            try
            {

                string filename = Path.GetFileName(rpt.FileName);
                string fileadd = "";
                string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
                if (Directory.Exists(Server.MapPath(fileSavePatht)))
                    Directory.Delete(Server.MapPath(fileSavePatht), true);

                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                if (!Directory.Exists(Server.MapPath(fileSavePath)))
                    Directory.CreateDirectory(Server.MapPath(fileSavePath));
                //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";


                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";



                rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                string popupScript;
                popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";

                Context.Response.Write(popupScript);

                //string popupScript;
                //popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";

                //Context.Response.Write(popupScript);
                //// File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                rpt.Dispose(); rpt = null;
            }
            catch (System.IO.IOException ex)
            {
                ShowMessage("Không in được báo cáo" + ex.Message);
                // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

            }
        }

        public void NewRequestOpen(string Path)
        {
            string popupScript = "<script language='javascript'>" + "window.open('";
            popupScript += Path;
            popupScript += "','mywindow','toolbar=yes, scrollbars=yes, resizable=yes, top=500, left=500,width=700,height=100'";
            popupScript += ");</script>";
            Context.Response.Write(popupScript);
        }

        //protected void PrintExportDirect1(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean direct = true, string maprint = "")
        //{

        //    try
        //    {
        //        //   Document document 
        //        //   if ( rpt.PrintOptions.PaperSize == CrystalDecisions.Shared.PaperSize.PaperA4 && rpt.PrintOptions.PaperOrientation==CrystalDecisions.Shared.PaperOrientation.Landscape)
        //        //      document = new Document(PageSize.A4_LANDSCAPE);
        //        //    else  if ( rpt.PrintOptions.PaperSize == CrystalDecisions.Shared.PaperSize.PaperA4 && rpt.PrintOptions.PaperOrientation==CrystalDecisions.Shared.PaperOrientation.Landscape)
        //        //      document = new Document(PageSize.A4);
        //        //   else  if ( rpt.PrintOptions.PaperSize == CrystalDecisions.Shared.PaperSize.PaperA5)
        //        //      document = new Document(PageSize.A5);
        //        //  else if ( rpt.PrintOptions.PaperSize == CrystalDecisions.Shared.PaperSize.PaperLetter && rpt.PrintOptions.PaperOrientation==CrystalDecisions.Shared.PaperOrientation.Landscape)
        //        //      document = new Document(PageSize.LETTER_LANDSCAPE);
        //        //   else 
        //        //      document = new Document(PageSize.LETTER);



        //        ////Getting a instance of new pdf wrtiter
        //        //MemoryStream mem = (MemoryStream)rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
        //        //System.Collections.Generic.List<byte[]> sourceFiles = new List<byte[]>();
        //        //sourceFiles.Add(mem.ToArray());
        //        ////PdfReader reader = new PdfReader(mem);
        //        //MemoryStream output = new MemoryStream();

        //        //PdfWriter writer = PdfWriter.GetInstance(document, output);
        //        //writer.CloseStream = false ;
        //        //document.Open();

        //        //PdfContentByte content = writer.DirectContent;

        //        ////int i = 0;
        //        ////int p = 0;
        //        ////int n = reader.NumberOfPages;
        //        ////Rectangle psize = reader.GetPageSize(1);
        //        ////float width = psize.Width;
        //        ////float height = psize.Height;

        //        ////Add Page to new document

        //        ////while (i < n)
        //        ////{
        //        ////    document.NewPage();
        //        ////    p++;
        //        ////    i++;
        //        ////    PdfImportedPage page1 = writer.GetImportedPage(reader, i);
        //        ////    cb.AddTemplate(page1, 0, 0);

        //        ////}
        //        //for (int fileCounter = 0; fileCounter < sourceFiles.Count;
        //        //                  fileCounter++)
        //        //{
        //        //    // Create pdf reader
        //        //    PdfReader reader = new PdfReader(sourceFiles[fileCounter]);
        //        //    int numberOfPages = reader.NumberOfPages;

        //        //    // Iterate through all pages
        //        //    for (int currentPageIndex = 1; currentPageIndex <=
        //        //                       numberOfPages; currentPageIndex++)
        //        //    {
        //        //        // Determine page size for the current page
        //        //        document.SetPageSize(
        //        //           reader.GetPageSizeWithRotation(currentPageIndex));

        //        //        // Create page
        //        //        document.NewPage();
        //        //        PdfImportedPage importedPage =
        //        //          writer.GetImportedPage(reader, currentPageIndex);


        //        //        // Determine page orientation
        //        //        int pageOrientation =
        //        //          reader.GetPageRotation(currentPageIndex);
        //        //        if ((pageOrientation == 90) || (pageOrientation == 270))
        //        //        {
        //        //            content.AddTemplate(importedPage, 0, -1f, 1f, 0, 0,
        //        //            reader.GetPageSizeWithRotation(currentPageIndex).Height);
        //        //        }
        //        //        else
        //        //        {
        //        //            content.AddTemplate(importedPage, 1f, 0, 0, 1f, 0, 0);
        //        //        }
        //        //    }
        //        //}
        //        ////Attach javascript to the document

        //        //PdfAction jAction = PdfAction.JavaScript("this.print(false);\r", writer);
        //        //writer.AddJavaScript(jAction);
        //        //document.Close();
        //        //document = null;
        //        //jAction.Clear();
        //        //jAction = null;
        //        string filename = Path.GetFileName(rpt.FileName);
        //        string fileadd = "";
        //        string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
        //        if (Directory.Exists(Server.MapPath(fileSavePatht)))
        //            Directory.Delete(Server.MapPath(fileSavePatht), true);

        //        string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
        //        if (!Directory.Exists(Server.MapPath(fileSavePath)))
        //            Directory.CreateDirectory(Server.MapPath(fileSavePath));


        //        fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
        //        if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF"))
        //            File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF");


        //        rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + maprint + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));


        //        // File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
        //        rpt.Dispose(); rpt = null;


        //        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

        //        object confirmConversions = Type.Missing;

        //        object readOnly = Type.Missing;

        //        object addToRecentFiles = Type.Missing;

        //        object passwordDoc = Type.Missing;

        //        object passwordTemplate = Type.Missing;

        //        object revert = Type.Missing;

        //        object writepwdoc = Type.Missing;

        //        object writepwTemplate = Type.Missing;

        //        object format = Type.Missing;

        //        object encoding = Type.Missing;

        //        object visible = Type.Missing;

        //        object openRepair = Type.Missing;

        //        object docDirection = Type.Missing;

        //        object notEncoding = Type.Missing;

        //        object xmlTransform = Type.Missing;
        //        if (direct == true)
        //            wordApp.Visible = false;
        //        else
        //            wordApp.Visible = true;
        //        LocalPrintServer localPrintServer = new LocalPrintServer();

        //        PrintQueue defaultPrintQueue = LocalPrintServer.GetDefaultPrintQueue();
        //        Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(

        //             Server.MapPath(fileSavePath), confirmConversions, readOnly, addToRecentFiles,

        //             passwordDoc, passwordTemplate, revert, writepwdoc,

        //             writepwTemplate, format, encoding, visible, openRepair,

        //             docDirection, notEncoding, xmlTransform);
        //        if (direct == true)
        //        {
        //            doc.Activate();
        //            doc.Application.ActivePrinter = defaultPrintQueue.FullName;

        //            doc.PrintOut(readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly, readOnly);
        //            doc.Close(visible, visible, visible); ;

        //            wordApp.Quit(visible, visible, visible); ;
        //            if (doc != null)
        //                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
        //            if (wordApp != null)
        //                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
        //            doc = null;

        //            wordApp = null;
        //            GC.Collect();
        //        }
        //    }
        //    catch (System.IO.IOException ex)
        //    {
        //        ShowMessage("Không in được báo cáo" + ex.Message);
        //        // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

        //    }
        //    }
        public string TinhTuoiVaoVien(bool LoaiBA, string MaBA)
        {
            string tuoi = string.Empty;
            string sql = string.Empty;
            emrConnection con = new emrConnection();

            SqlCommand com = new SqlCommand();
            if (LoaiBA)// Nội trú
                sql = "select distinct DATEDIFF(YEAR,bn.NgaySinh,pk.NgayVV) as Tuoi from BenhAn pk join ThongTinBN bn on pk.MaBN = bn.MaBN where MaBA = '" + MaBA + "'";
            else
                sql = "select distinct DATEDIFF(YEAR,bn.NgaySinh,pk.NgayGioVV) as Tuoi from benhanpk pk join ThongTinBN bn on pk.MaBN=bn.MaBN where MaBA='" + MaBA + "'";
            com.CommandText = sql;
            com.Connection = con.Connection();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
                tuoi = dr["Tuoi"].ToString();
            return tuoi;
            dr.Close();
            con.ClosedConnection();
        }
        protected void PrintExportDirect2(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean direct = true, string maprint = "")
        {

            try
            {

                string filename = Path.GetFileName(rpt.FileName);
                string fileadd = "";
                string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
                if (Directory.Exists(Server.MapPath(fileSavePatht)))
                    Directory.Delete(Server.MapPath(fileSavePatht), true);

                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                if (!Directory.Exists(Server.MapPath(fileSavePath)))
                    Directory.CreateDirectory(Server.MapPath(fileSavePath));


                fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
                if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF"))
                    File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF");


                rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + maprint + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));


                // File.Delete(Server.MapPath(fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                rpt.Dispose(); rpt = null;
                PrintWindow(fileSavePath);

            }
            catch (System.IO.IOException ex)
            {
                ShowMessage("Không in được báo cáo" + ex.Message);
                // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

            }
        }
        protected void PrintExportDirect(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, string maprint = "")
        {
            try
            {
                string filename = Path.GetFileName(rpt.FileName);
                string fileadd = "";
                string fileSavePatht = @"tem/" + DateTime.Now.AddDays(-1).Month.ToString() + DateTime.Now.AddDays(-1).Day.ToString() + "/";
                //if (Directory.Exists(Server.MapPath(fileSavePatht)))
                //    Directory.Delete(Server.MapPath(fileSavePatht), true);

                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                //if (!Directory.Exists(Server.MapPath(fileSavePath)))
                //    Directory.CreateDirectory(Server.MapPath(fileSavePath));
                ////fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
                //if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf"))
                //    File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf");

                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                fileSavePath = @"tem/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf";


                //using CrystalDecisions.CrystalReports.Engine;
                CrystalDecisions.Shared.ExportRequestContext reqContext = new CrystalDecisions.Shared.ExportRequestContext();
                var exportOptions2 = new CrystalDecisions.Shared.ExportOptions
                {
                    ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                    FormatOptions = new CrystalDecisions.Shared.PdfFormatOptions { UsePageRange = false, FirstPageNumber = 1, LastPageNumber = 1 }
                };
                reqContext.ExportInfo = exportOptions2;
                var stream2 = rpt.FormatEngine.ExportToStream(reqContext);

                //stream2.Seek(0, SeekOrigin.Begin);

                //// //// merge the two PDF streams
                //var combinedPdf = new PdfSharp.Pdf.PdfDocument();

                //// //foreach (PdfPage page in PdfReader.Open(stream1, PdfDocumentOpenMode.Import).Pages)
                //// //    combinedPdf.AddPage(page);
                //foreach (PdfSharp.Pdf.PdfPage page in PdfSharp.Pdf.IO.PdfReader.Open(stream2, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import).Pages)
                //    combinedPdf.AddPage(page);

                ////// probably not the most efficient, but works
                //combinedPdf.Save(Server.MapPath("tem\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "\\" + fileadd + maprint + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".pdf"));
                //  Document document = new Document(PageSize.LETTER);
                //  PdfReader reader = new PdfReader(HttpContext.Current.Server.MapPath(fileSavePath));


                //stream2.Flush(); // Don't know if this is necessary
                //stream2.Position = 0;
                byte[] byteArray = new byte[stream2.Length];
                stream2.Read(byteArray, 0, Convert.ToInt32(stream2.Length - 1));
                PdfReader reader = new PdfReader(byteArray);

                //Getting a instance of new pdf wrtiter
                string fileSavePathdbf = @"tem/" + fileadd + maprint + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".pdf";


                MemoryStream outputStream = new MemoryStream();


                var pdfStamper = new PdfStamper(reader, outputStream);
                //Add the auto-print javascript
                var writer = pdfStamper.Writer;
                //string jsText = "var res = app.setTimeOut('var pp = this.getPrintParams();pp.interactive = pp.constants.interactionLevel.full;this.print(pp);', 200);";
                ////string jsTextNoWait = "var pp = this.getPrintParams();pp.interactive = pp.constants.interactionLevel.full;this.print(pp);";
                //PdfAction js = PdfAction.JavaScript(jsText, writer);
                //writer.AddJavaScript(js);
                PdfAction jAction = PdfAction.JavaScript("this.print(false);\r", writer);
                writer.AddJavaScript(jAction);
                //  pdfStamper.SetPageAction(PdfWriter.PAGE_OPEN, new PdfAction(PdfAction.PRINTDIALOG ), 1);
                writer.SetAdditionalAction(PdfWriter.DID_PRINT, PdfAction.JavaScript("app.execMenuItem('Close');", writer));
                writer.SetAdditionalAction(PdfWriter.DID_PRINT, PdfAction.JavaScript("app.close();", writer));

                pdfStamper.Close();
                var content = outputStream.ToArray();
                outputStream.Close();
                Response.Clear();
                Response.Buffer = true;
                Response.ClearContent();
                Response.AddHeader("content-disposition", String.Format("attachment;filename={0}", (Server.MapPath(fileSavePathdbf))));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = "application/pdf";
                Response.BinaryWrite(content);
                Response.Flush();
                Response.Close();
                // Response.End();
                outputStream.Close();
                outputStream.Dispose();
                //Stream dataStream = req.GetRequestStream();
                //dataStream.Write(encData, 0, encData.Length);
                //dataStream.Flush();
                //dataStream.Close();
                //                var newWin = window.frames["printf"];
                //newWin.document.write('<body onload="window.print()">dddd</body>');
                //newWin.document.close()
                //                var html = '<html><head></head><body>Foo</body></html>';
                //var iframe = document.createElement('iframe');
                //iframe.src = 'data:text/html;charset=utf-8,' + encodeURI(html);

                //                <script type="text/javascript">
                //function prepareFrame() {
                //ifrm = document.createElement("IFRAME");
                //ifrm.setAttribute("src", "http://google.com/");
                //ifrm.style.width = 640+"px";
                //ifrm.style.height = 480+"px";
                //document.body.appendChild(ifrm);
                //}
                //</script> 
                //WebResponse res = req.GetResponse();
                //StreamReader sr = new StreamReader(res.GetResponseStream());
                //string s = sr.ReadToEnd();
                //frmLoader.InnerHtml = s;
                //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(HttpContext.Current.Server.MapPath(fileSavePathdbf), FileMode.Create));

                //document.Open();

                //PdfContentByte cb = writer.DirectContent;

                //int i = 0;
                //int p = 0;
                //int n = reader.NumberOfPages;
                //Rectangle psize = reader.GetPageSize(1);
                //float width = psize.Width;
                //float height = psize.Height;

                ////Add Page to new document

                //while (i < n)
                //{
                //    document.NewPage();
                //    p++;
                //    i++;
                //    PdfImportedPage page1 = writer.GetImportedPage(reader, i);
                //    cb.AddTemplate(page1, 0, 0);

                //}

                ////Attach javascript to the document

                //PdfAction jAction = PdfAction.JavaScript("this.print(false);\r", writer);
                //writer.AddJavaScript(jAction);

                // document.Close();
                //rpt.Dispose(); rpt.Close(); rpt = null; document = null;

                //Response.Clear();

                //Response.Buffer = true;

                //Response.ContentType = "application/pdf";
                //Response.WriteFile(HttpContext.Current.Server.MapPath(fileSavePathdbf));
                //Response.Flush();
                //Response.Close();
                //Response.End();
            }
            catch (System.IO.IOException ex)
            {
                ShowMessage("Không in được báo cáo" + ex.Message);
                // ShowMessage(MessageType.ERROR, FormAction.REPORTS);

            }
        }

        //protected void PrintWord(string fileSavePath, Boolean direct = true)
        //{
        //    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

        //    object confirmConversions = Type.Missing;

        //    object readOnly = Type.Missing;

        //    object addToRecentFiles = Type.Missing;

        //    object passwordDoc = Type.Missing;

        //    object passwordTemplate = Type.Missing;

        //    object revert = Type.Missing;

        //    object writepwdoc = Type.Missing;

        //    object writepwTemplate = Type.Missing;

        //    object format = Type.Missing;

        //    object encoding = Type.Missing;

        //    object visible = Type.Missing;

        //    object openRepair = Type.Missing;

        //    object docDirection = Type.Missing;

        //    object notEncoding = Type.Missing;

        //    object xmlTransform = Type.Missing;

        //    Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(

        //         Server.MapPath(fileSavePath), true, true, true,

        //         passwordDoc, passwordTemplate, true, writepwdoc,

        //         writepwTemplate, format, encoding, true, false,

        //         true, notEncoding, xmlTransform);
        //    if (direct == true)
        //        wordApp.Visible = false;
        //    else
        //        wordApp.Visible = true;

        //    object noReset = Type.Missing;

        //    object password = Type.Missing;

        //    object useIRM = Type.Missing;

        //    object enforceStyleLock = Type.Missing;

        //    doc.Protect(Microsoft.Office.Interop.Word.WdProtectionType.wdAllowOnlyReading, noReset, password, useIRM, enforceStyleLock);
        //    if (direct == true)
        //    {
        //        doc.PrintOut();
        //        doc.Close(visible, visible, visible); ;
        //        wordApp.Quit(visible, visible, visible); ;
        //        if (doc != null)
        //            System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
        //        if (wordApp != null)
        //            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
        //        doc = null;

        //        wordApp = null;
        //        GC.Collect();
        //    }
        //    else
        //    {

        //        wordApp.ScreenUpdating = true;
        //        wordApp.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMaximize;
        //        doc.Activate();
        //    }


        //}
        //protected void OpenWord(string fileSavePath, string[] strField = null, string[] strReplacementText = null)
        //{
        //    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

        //    object confirmConversions = Type.Missing;

        //    object readOnly = Type.Missing;

        //    object addToRecentFiles = Type.Missing;

        //    object passwordDoc = Type.Missing;

        //    object passwordTemplate = Type.Missing;

        //    object revert = Type.Missing;

        //    object writepwdoc = Type.Missing;

        //    object writepwTemplate = Type.Missing;

        //    object format = Type.Missing;

        //    object encoding = Type.Missing;

        //    object visible = Type.Missing;

        //    object openRepair = Type.Missing;

        //    object docDirection = Type.Missing;

        //    object notEncoding = Type.Missing;

        //    object xmlTransform = Type.Missing;

        //    Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(

        //         Server.MapPath(fileSavePath), confirmConversions, readOnly, addToRecentFiles,

        //         passwordDoc, passwordTemplate, revert, writepwdoc,

        //         writepwTemplate, format, encoding, true, openRepair,

        //         docDirection, notEncoding, xmlTransform);

        //    wordApp.Visible = true;

        //    object noReset = Type.Missing;

        //    object password = Type.Missing;

        //    object useIRM = Type.Missing;

        //    object enforceStyleLock = Type.Missing;

        //    doc.Protect(Microsoft.Office.Interop.Word.WdProtectionType.wdAllowOnlyReading, noReset, password, useIRM, enforceStyleLock);
        //    int i;

        //    wordApp.Selection.Find.Text = "[" + strField + "]";
        //    wordApp.Selection.Find.Replacement.Text = "[" + strReplacementText + "]";
        //    wordApp.Selection.Find.Forward = true;
        //    wordApp.Selection.Find.Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
        //    wordApp.Selection.Find.Format = false;
        //    wordApp.Selection.Find.MatchCase = false;
        //    wordApp.Selection.Find.MatchWholeWord = false;
        //    wordApp.Selection.Find.MatchWildcards = false;
        //    wordApp.Selection.Find.MatchSoundsLike = false;
        //    wordApp.Selection.Find.MatchAllWordForms = false;

        //    wordApp.Selection.Find.Execute(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
        //    wordApp.ScreenUpdating = true;
        //    wordApp.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMaximize;
        //    doc.Activate();



        //}

        public class SentQueue
        {
            public String queueNo { get; set; }
            public string codeTerminal { get; set; }
            public string codePatient { get; set; }
            public string patientName { get; set; }
            public int patientAge { get; set; }


        }
        public class FeesQueue
        {

            public string codePatient { get; set; }

            public int transactionID { get; set; }


        }
        public class EndQueue
        {

            public string codeTerminal { get; set; }

            public int transactionId { get; set; }


        }

        public void createQueueByRoom(String queueNo, String codeTerminal, String codePatient, String patientName, int patientAge)
        {
            try
            {
                //var postParameters = new SentQueue
                //{
                //    queueNo = queueNo,
                //    codeTerminal = codeTerminal,
                //    codePatient = codePatient,
                //    patientName = patientName,
                //    patientAge = patientAge,

                //};

                //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(postParameters);
                //byte[] bytes = Encoding.UTF8.GetBytes(postData);

                //string request = "http://101.99.17.230:5719/serviceQueue/serviceQueue?wsdl";
                //var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
                //httpWebRequest.Method = "POST";
                //httpWebRequest.ContentLength = bytes.Length;
                //httpWebRequest.ContentType = "application/json; charset=utf-8";
                //using (Stream requestStream = httpWebRequest.GetRequestStream())
                //{
                //    requestStream.Write(bytes, 0, bytes.Length);
                //    requestStream.Flush();
                //    requestStream.Close();
                //}
                ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
                queue.createQueueNumber(codeTerminal, codePatient, patientName, patientAge);
            }
            catch
            {

            }
        }

        public void addServiceTranferRoom(String patientCode, int transactionId)
        {
            try
            {
                //var postParameters = new FeesQueue
                //{
                //    transactionID = transactionId,

                //    codePatient = patientCode,


                //};

                //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(postParameters);
                //byte[] bytes = Encoding.UTF8.GetBytes(postData);

                //string request = "http://101.99.17.230:5719/serviceQueue/serviceQueue?wsdl";
                //var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
                //httpWebRequest.Method = "POST";
                //httpWebRequest.ContentLength = bytes.Length;
                //httpWebRequest.ContentType = "application/json; charset=utf-8";
                //using (Stream requestStream = httpWebRequest.GetRequestStream())
                //{
                //    requestStream.Write(bytes, 0, bytes.Length);
                //    requestStream.Flush();
                //    requestStream.Close();
                //}

                ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
                queue.addServiceTranferRoom(patientCode, transactionId);
            }
            catch
            {
                ;
            }
        }
        public void endQueuePatient(int transactionId, String codeTerminal)
        {
            try
            {
                //var postParameters = new EndQueue
                //{
                //    transactionId = transactionId,

                //    codeTerminal = codeTerminal,


                //};

                //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(postParameters);
                //byte[] bytes = Encoding.UTF8.GetBytes(postData);

                //string request = "http://101.99.17.230:5719/serviceQueue/serviceQueue?wsdl";
                //var httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
                //httpWebRequest.Method = "POST";
                //httpWebRequest.ContentLength = bytes.Length;
                //httpWebRequest.ContentType = "application/json; charset=utf-8";
                //using (Stream requestStream = httpWebRequest.GetRequestStream())
                //{
                //    requestStream.Write(bytes, 0, bytes.Length);
                //    requestStream.Flush();
                //    requestStream.Close();
                //}
                //Session["TransactionID"] = "";
                //Session["QueryID"] = "";
                //Session["CodePatient"] = ""; ;
                ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
                queue.endQueuePatient(transactionId, codeTerminal);
            }
            catch
            {
                ;
            }
        }

        //public void GetNumber(string makhoa)
        //{
        //    try
        //    {

        //        if (makhoa.Length < 3 && makhoa != "" && makhoa != null)
        //            makhoa = Pub_sQuay;
        //        Pub_TransactionID = 0;
        //        Pub_sCodePatient = "";
        //        Pub_QueryID = "0";
        //        ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
        //        string s = queue.GetNumber(makhoa);
        //        int i = s.IndexOf("|");
        //        string x = "";
        //        if (i > 0)
        //            x = s.Substring(0, i);
        //        if (x == "-1" || x == "0" || x == "" || x == "null")
        //            Pub_TransactionID = 0;
        //        else
        //            Pub_TransactionID = int.Parse(x);
        //        s = s.Substring(i + 1);
        //        i = s.IndexOf("|");
        //        x = "";
        //        if (i > 0) // mã phòng
        //            s = s.Substring(i + 1);
        //        i = s.IndexOf("|");
        //        x = "";
        //        if (i > 0)
        //            x = s.Substring(0, i);
        //        if (x == "-1" || x == "0" || x == "" || x == "null")
        //            Pub_sCodePatient = "";
        //        else
        //            Pub_sCodePatient = x;
        //        s = s.Substring(i + 1);
        //        i = s.IndexOf("|");
        //        x = "";
        //        if (i > 0)
        //            x = s.Substring(0, i);
        //        if (x == "-1" || x == "0" || x == "" || x == "null")
        //            Pub_QueryID = "";
        //        else
        //            Pub_QueryID = x;
        //        s = s.Substring(i + 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        ;
        //    }
        //}

        public DataTable _ListPub_XepHang
        {

            get
            {



                return (DataTable)ViewState["ListPub_XepHang"];
            }

            set
            {
                ViewState["ListPub_XepHang"] = value;
            }
        }

        public DataTable _ListNhoPub_XepHang
        {

            get
            {



                return (DataTable)ViewState["ListNhoPub_XepHang"];
            }

            set
            {
                ViewState["ListNhoPub_XepHang"] = value;
            }
        }
        public void XepHang(string makhoa)
        {
            try
            {
                if (Pub_sQuay.Length < 3 && Pub_sQuay != "" && Pub_sQuay != null)
                    makhoa = Pub_sQuay;

                ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
                stringArray[] s = queue.freshQueueCall(makhoa);
                DataTable dtgoi = new DataTable();

                dtgoi.Columns.Add(new DataColumn("TransactionId", typeof(int)));
                dtgoi.Columns.Add(new DataColumn("STT", typeof(string)));
                dtgoi.Columns.Add(new DataColumn("TrangThai", typeof(string)));
                dtgoi.Columns.Add(new DataColumn("MaBN", typeof(string)));
                DataTable dtgoinho = new DataTable();

                dtgoinho.Columns.Add(new DataColumn("TransactionId", typeof(int)));
                dtgoinho.Columns.Add(new DataColumn("STT", typeof(string)));
                dtgoinho.Columns.Add(new DataColumn("TrangThai", typeof(string)));
                dtgoinho.Columns.Add(new DataColumn("MaBN", typeof(string)));
                stringArray x = s[0];
                string TransactionId = "";
                string trangthai = "";
                string STT = "";
                string MaBN = "";
                string s1 = "";
                int i1 = 0;
                string x1 = "";
                if (x != null)
                {
                    if (x.item != null)
                    {
                        for (int i = 0; i <= x.item.Length - 1; i++)
                        {
                            TransactionId = "";
                            STT = "";
                            trangthai = "";
                            MaBN = "";
                            s1 = x.item[i];
                            i1 = s1.IndexOf("|");
                            x1 = "";
                            if (i1 > 0)
                                x1 = s1.Substring(0, i1);
                            if (x1 != "")
                                TransactionId = x1;

                            s1 = s1.Substring(i1 + 1);
                            // trang thai
                            i1 = s1.IndexOf("|");
                            x1 = "";
                            if (i1 > 0)
                                x1 = s1.Substring(0, i1);
                            if (x1 != "")
                                trangthai = x1;
                            s1 = s1.Substring(i1 + 1);
                            //stt
                            i1 = s1.IndexOf("|");
                            x1 = "";
                            if (i1 > 0)
                                x1 = s1.Substring(0, i1);
                            if (x1 != "")
                                STT = x1;
                            s1 = s1.Substring(i1 + 1);
                            if (s1 != "")
                                MaBN = s1;
                            if (TransactionId != "")
                                dtgoi.Rows.Add(int.Parse(TransactionId), STT, trangthai, MaBN);
                        }
                    }
                }
                _ListPub_XepHang = dtgoi;
                x = s[1];
                if (x != null)
                {
                    if (x.item != null)
                    {
                        for (int i = 0; i <= x.item.Length - 1; i++)
                        {
                            TransactionId = "";
                            STT = "";
                            trangthai = "";
                            MaBN = "";
                            s1 = x.item[i];
                            i1 = s1.IndexOf("|");
                            x1 = "";
                            if (i1 > 0)
                                x1 = s1.Substring(0, i1);
                            if (x1 != "")
                                TransactionId = x1;

                            s1 = s1.Substring(i1 + 1);
                            // trang thai
                            i1 = s1.IndexOf("|");
                            x1 = "";
                            if (i1 > 0)
                                x1 = s1.Substring(0, i1);
                            if (x1 != "")
                                trangthai = x1;
                            s1 = s1.Substring(i1 + 1);
                            //stt
                            i1 = s1.IndexOf("|");
                            x1 = "";
                            if (i1 > 0)
                                x1 = s1.Substring(0, i1);
                            if (x1 != "")
                                STT = x1;
                            s1 = s1.Substring(i1 + 1);
                            //mabn


                            if (s1 != "")
                                MaBN = s1;
                            if (TransactionId != "")
                                dtgoinho.Rows.Add(int.Parse(TransactionId), STT, trangthai, MaBN);
                        }
                    }
                }
                _ListNhoPub_XepHang = dtgoinho;
            }
            catch
            {
                ;
            }
        }


        public void GetGoiHang(int transactionId, String makhoa)
        {
            try
            {
                if (Pub_sQuay.Length < 3 && Pub_sQuay != "" && Pub_sQuay != null)
                    makhoa = Pub_sQuay;
                ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
                queue.callQueueNumber(transactionId, makhoa);
            }
            catch
            {
                ;
            }
        }
        public void AddHangNho(int transactionId, String makhoa)
        {
            try
            {
                if (Pub_sQuay.Length < 3 && Pub_sQuay != "" && Pub_sQuay != null)
                    makhoa = Pub_sQuay;
                ServiceQueue.serviceQueueClient queue = new ServiceQueue.serviceQueueClient();
                queue.setMissQueue(transactionId, makhoa);
                XepHang(makhoa);
            }
            catch
            {
                ;
            }
        }
    public static void WriteLog(string log)
    {
        string logname = "Log_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
        //string fileName = HttpContext.Current.Request.MapPath("MyLogs.txt");
        string fileName = HttpContext.Current.Request.MapPath(logname);
        if (!File.Exists(fileName))
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + log);
                sw.Close();
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + log);
                sw.Close();
            }
        }
    }

    }
}