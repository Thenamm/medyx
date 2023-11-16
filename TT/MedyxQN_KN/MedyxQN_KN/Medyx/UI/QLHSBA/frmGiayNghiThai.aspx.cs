using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using HTC.Business.Duoc;
using HTC.Common.Web;
using Telerik.Web.UI;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using OfficeOpenXml;
using HTC.Business.NoiTru;
using HTC.Business.PhongKham;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;
public partial class UI_QLHSBA_frmGiayNghiThai : WebBase
{
    private const string ViewState_MaBN = "MaBN";
    public string _MaBN
    {
        get
        {
            if (ViewState[ViewState_MaBN] == null)
                ViewState[ViewState_MaBN] = "";
            return (string)ViewState[ViewState_MaBN];
        }
        set
        {
            ViewState[ViewState_MaBN] = value;
        }
    }
    private const string ViewState_MaBA = "MaBA";
    public string _MaBA
    {
        get
        {
            if (ViewState[ViewState_MaBA] == null)
                ViewState[ViewState_MaBA] = "";
            return (string)ViewState[ViewState_MaBA];
        }
        set
        {
            ViewState[ViewState_MaBA] = value;
        }
    }
    private const string ViewState_SoGiayNghiThai = "SoGiayNghiThai";
    public string _SoGiayNghiThai
    {
        get
        {
            if (ViewState[ViewState_SoGiayNghiThai] == null)
                ViewState[ViewState_SoGiayNghiThai] = "0";
            return (string)ViewState[ViewState_SoGiayNghiThai];
        }
        set
        {
            ViewState[ViewState_SoGiayNghiThai] = value;
        }
    }
    private void LoadData()
    {
        DataTable dt = spGiayNghiThai_Get(_MaBN, _MaBA, decimal.Parse(_SoGiayNghiThai));
        if (dt != null && dt.Rows.Count > 0)
        {
            txtHoTen.Text = dt.Rows[0]["Hoten"].ToString();
            if (dt.Rows[0]["GT"].ToString() == "True")
            {
                lblGioitinh.Items[0].Selected = true;
                lblGioitinh.Items[1].Selected = false;
            }
            else
            {
                lblGioitinh.Items[1].Selected = true;
                lblGioitinh.Items[0].Selected = false;
            }
            dtNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
            txtTuoi.Text = dt.Rows[0]["Tuoi"].ToString();
            txtMaQL.Text = dt.Rows[0]["MaBN"].ToString();
            txtNguoiThan.Text = dt.Rows[0]["NGUOI_DAI_DIEN"].ToString();
            txtSoCMND.Text = dt.Rows[0]["SoCMT"].ToString();
            dtNGAYCAP_CMND.Text = dt.Rows[0]["NGAYCAP_CMND"].ToString();
            txtNoiCapCMND.Text = dt.Rows[0]["SoCMT"].ToString();
            txtNgheNghiep.Text = dt.Rows[0]["TenNN"].ToString();
            txtDonVi.Text = dt.Rows[0]["NoiLamViec"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dt.Rows[0]["DienThoai"].ToString();
            txtSoThe.Text = dt.Rows[0]["Sothe"].ToString();
            txtSoGiayNT.Text = dt.Rows[0]["SoGiayNghiThai"].ToString();
            dtNgayVao.Text = dt.Rows[0]["NGAY_VAO"].ToString();
            dtNgayRa.Text = dt.Rows[0]["NGAY_RA"].ToString();
            dtNgayCap.Text = dt.Rows[0]["NGAY_CT"].ToString();
            cbocdravien.SelectedValue = dt.Rows[0]["MaChanDoan"].ToString();
            cbocdravien.Text = dt.Rows[0]["TenBenh"].ToString();
            cboBS.SelectedValue = dt.Rows[0]["MA_BS"].ToString();
            cboBS.Text = dt.Rows[0]["TEN_BS"].ToString();
            chkHuy.Checked = (dt.Rows[0]["Huy"] != null) ? (dt.Rows[0]["Huy"].ToString() == "True") ? true : false : false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            _CurrentFormType = FormType.FORM_DANH_SACH_CHI_TIET;
            base.Page_PreLoad(sender, e);
            if (Request["MaBN"] != null)
                _MaBN = Request["MaBN"];
            if (Request["MaBA"] != null)
                _MaBA = Request["MaBA"];
            if (Request["SoGiayNghiThai"] != null)
                _SoGiayNghiThai = Request["SoGiayNghiThai"];
            LoadData();
        }
    }
    protected void baraction_ButtonClick(object sender, RadToolBarEventArgs e)
    {
        if (e.Item.Visible == true && e.Item.Enabled == true)
        {
            switch (e.Item.Value)
            {
                case "cmdSave":
                    //    Response.Redirect("~/UI/ChePhamMau/ChePhamMau/FrmNhanChiDinhLS.aspx?NhanOng="+_NhanOng.ToString()+"&MaKhoa="+cboKhoa.SelectedValue);
                    if (UpdateData())
                        LoadData();
                    break;
                case "cmdView":
                    LoadData();
                    break;
                case "cmdPrint":
                    if (UpdateData())
                    {
                        PrintData();
                    }
                    break;
                case "cmdExit":
                    Response.Redirect("~/Default.aspx");
                    break;
                default:
                    break;
            }
        }
    }
    protected void cboBenh_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
    {
        DMBenhTat dataItem = e.Item.DataItem as DMBenhTat;
        if (dataItem == null)
            e.Item.Attributes["TenBenh"] = "";
        else
            e.Item.Attributes["TenBenh"] = dataItem.TenBenh.ToString();
    }
    public bool UpdateData()
    {
        if (CheckData())
        {
            decimal SoGiayNghiThai = decimal.Parse(txtSoGiayNT.Text);
            DateTime ngayvao = DateTime.ParseExact(dtNgayVao.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime ngayra = DateTime.ParseExact(dtNgayRa.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime ngayct = DateTime.ParseExact(dtNgayCap.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime ngaycmt = DateTime.ParseExact(dtNGAYCAP_CMND.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None);
            _SoGiayNghiThai = spGiayNghiThai_CreateOrUpdate(SoGiayNghiThai, _MaBN, _MaBA, cbocdravien.SelectedValue, txtDonVi.Text.Trim(), ngayvao, ngayra, txtNguoiThan.Text.Trim(), cboBS.SelectedValue, ngayct, chkHuy.Checked, txtSoCMND.Text, ngaycmt, txtNoiCapCMND.Text, txtDonVi.Text, txtDiaChi.Text, txtDienThoai.Text);
            #region day giay bao tu len cong BHXH
            #region lay token
            //LAY port, username, passwword log in
            //DataTable dt = GetPort("GetTokenLoginGBT");
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    string port = dt.Rows[0]["port"].ToString();
            //    string username = dt.Rows[0]["username"].ToString();
            //    string password = dt.Rows[0]["password"].ToString();
            //    string macskcb = dt.Rows[0]["Madvcs"].ToString();
            //    //lay token
            //    APIKey token = GetToken(port, username, password);
            DataTable TV = spGiayNghiThai_GetXML(decimal.Parse(_SoGiayNghiThai));
            //    if (token != null)
            if (TV.Rows.Count > 0)
            {
                HSDLGBT hSDLGBT = new HSDLGBT();
                List<GiayNghiThai> GiayNghiThais = new List<GiayNghiThai>();
                GiayNghiThai GiayNghiThai = new GiayNghiThai();
                GiayNghiThai.SO_SERI = TV.Rows[0]["SO_SERI"].ToString();
                GiayNghiThai.MA_CT = TV.Rows[0]["MA_CT"].ToString();
                GiayNghiThai.SO_KCB = TV.Rows[0]["SO_KCB"].ToString();
                GiayNghiThai.MA_BHXH = TV.Rows[0]["MA_BHXH"].ToString();
                GiayNghiThai.MA_THE = TV.Rows[0]["MA_THE"].ToString();
                GiayNghiThai.HO_TEN = TV.Rows[0]["HO_TEN"].ToString();
                GiayNghiThai.NGAY_SINH = TV.Rows[0]["NGAY_SINH"].ToString();
                GiayNghiThai.TEN_DVI = TV.Rows[0]["TEN_DVI"].ToString();
                GiayNghiThai.CHAN_DOAN = TV.Rows[0]["CHAN_DOAN"].ToString();
                GiayNghiThai.NGAY_VAO = TV.Rows[0]["NGAY_VAO"].ToString();
                GiayNghiThai.NGAY_RA = TV.Rows[0]["NGAY_RA"].ToString();
                GiayNghiThai.NGUOI_DAI_DIEN = TV.Rows[0]["NGUOI_DAI_DIEN"].ToString();
                GiayNghiThai.TEN_BS = TV.Rows[0]["TEN_BS"].ToString();
                GiayNghiThai.MA_BS = TV.Rows[0]["MA_BS"].ToString();
                GiayNghiThai.NGAY_CT = TV.Rows[0]["NGAY_CT"].ToString();
                GiayNghiThais.Add(GiayNghiThai);
                hSDLGBT.GiayNghiThai = GiayNghiThais;
                //tao file xml
                string filename = "";
                DateTime tungay;
                DateTime denngay;
                tungay = DateTime.Now.AddMinutes(-10).AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                denngay = DateTime.Now.AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
                string _tungay = tungay.ToString("dd/MM/yyyy HH:mm");
                string _denngay = denngay.ToString("dd/MM/yyyy HH:mm");
                //filename = System.Web.Hosting.HostingEnvironment.MapPath(@"~\GBT\BHXH" + txtMaQL.Text.Trim() + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + ".XML");
                filename = "GNT"+txtMaQL.Text.Trim() + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + ".XML";
                string fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/";
                if (!Directory.Exists(Server.MapPath(fileSavePath)))
                    Directory.CreateDirectory(Server.MapPath(fileSavePath));
                //fileSavePath = @"tem/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "/" + fileadd + Pub_sMaMay + "" + filename + "" + Path.GetFileName(Request.PhysicalPath) + ".RTF";
                if (System.IO.File.Exists(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + Pub_sMaMay + "" + filename))
                    File.Delete(@"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + Pub_sMaMay + "" + filename);

                //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.RichText, Server.MapPath("tem\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "\\" + fileadd + Pub_sMaMay + "" + filename + Path.GetFileName(Request.PhysicalPath) + ".RTF"));
                fileSavePath = @"tem/" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "/" + Pub_sMaMay + "" + filename;

                if (File.Exists(filename))
                {
                    FileInfo fi = new FileInfo(filename);
                    if (fi.IsReadOnly)
                        fi.IsReadOnly = false;
                    fi.Delete();
                }
                XmlSerializer xs = new XmlSerializer(typeof(HSDLGBT));
                TextWriter txtWriter = new StreamWriter(filename, false, Encoding.UTF8);
                xs.Serialize(txtWriter, hSDLGBT);
                txtWriter.Close();
                string popupScript;
                popupScript = " <script language='javascript'>" + "window.open('" + fileSavePath + "');</script>";
                Context.Response.Write(popupScript);
            }
            //}
            #endregion
            #endregion
            LoadData();
            return true;
        }
        else return false;
    }
    public string spGiayNghiThai_CreateOrUpdate(decimal SoGiayNghiThai, string MaBN, string MaBA, string MaChanDoan, string TEN_DVI, DateTime NGAY_VAO, DateTime NGAY_RA, string NGUOI_DAI_DIEN, string MA_BS, DateTime NGAY_CT, Boolean Huy, string SoCMT, DateTime NGAYCAP_CMND, string NOICAP_CMND, string NoiLamViec, string DiaChi, string DienThoai)
    {
        string tenStore = "spGiayNghiThai_CreateOrUpdate";
        DataTable dr = new DataTable();
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=6000; pooling=true; Max Pool Size=6000;Timeout=6000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@SoGiayNghiThai", SoGiayNghiThai));
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@MaChanDoan", MaChanDoan));
                Command.Parameters.Add(new SqlParameter("@TEN_DVI", TEN_DVI));
                Command.Parameters.Add(new SqlParameter("@NGAY_VAO", NGAY_VAO));
                Command.Parameters.Add(new SqlParameter("@NGAY_RA", NGAY_RA));
                Command.Parameters.Add(new SqlParameter("@NGUOI_DAI_DIEN", NGUOI_DAI_DIEN));
                Command.Parameters.Add(new SqlParameter("@MA_BS", MA_BS));
                Command.Parameters.Add(new SqlParameter("@NGAY_CT", NGAY_CT));
                Command.Parameters.Add(new SqlParameter("@Huy", Huy));
                Command.Parameters.Add(new SqlParameter("@MaMay", Pub_sMaMay));
                Command.Parameters.Add(new SqlParameter("@NguoiSD", Pub_sNguoiSD));
                Command.Parameters.Add(new SqlParameter("@SoCMT", SoCMT));
                Command.Parameters.Add(new SqlParameter("@NGAYCAP_CMND", NGAYCAP_CMND));
                Command.Parameters.Add(new SqlParameter("@NOICAP_CMND", NOICAP_CMND));
                Command.Parameters.Add(new SqlParameter("@NoiLamViec", NoiLamViec));
                Command.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
                Command.Parameters.Add(new SqlParameter("@DienThoai", DienThoai));
                //Command.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Dispose();
            Conection.Close();
            if (dr != null && dr.Rows.Count > 0)
                return dr.Rows[0][0].ToString();
            else return "0";
        }
    }
    public DataTable spGiayNghiThai_Get(string MaBN, string MaBA, decimal SoGiayNghiThai)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayNghiThai_Get";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@MaBN", MaBN));
                Command.Parameters.Add(new SqlParameter("@MaBA", MaBA));
                Command.Parameters.Add(new SqlParameter("@SoGiayNghiThai", SoGiayNghiThai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    public DataTable spGiayNghiThai_GetXML(decimal SoGiayNghiThai)
    {
        DataTable dr = new DataTable();
        string tenStore = "spGiayNghiThai_GetXML";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600000; pooling=true; Max Pool Size=600000;Timeout=600000;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@SoGiayNghiThai", SoGiayNghiThai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            Conection.Close();
            Conection.Dispose();
            return dr;
        }
    }
    public bool CheckData()
    {
        DateTime d;
        if (txtNguoiThan.Text.Trim().Length == 0)
        {
            ShowMessage("Chưa nhập tên người đại diện ký!");
            txtNguoiThan.Focus();
            return false;
        }
        else if (txtDonVi.Text.Trim().Length == 0)
        {
            ShowMessage("Chưa nhập đơn vị công tác!");
            txtDonVi.Focus();
            return false;
        }
        else if (cbocdravien.SelectedValue == "")
        {
            ShowMessage("Chưa nhập chẩn đoán cho bệnh nhân!");
            cbocdravien.Focus();
            return false;
        }
        else if (dtNgayRa.Text.Trim().Length == 0)
        {
            ShowMessage("Chưa nhập ngày kết thúc nghỉ!");
            dtNgayRa.Focus();
            return false;
        }
        else if (!DateTime.TryParseExact(dtNgayRa.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
        {
            ShowMessage("Nhập ngày kết thúc nghỉ không đúng định dạng!");
            dtNgayRa.Focus();
            return false;
        }
        else if (dtNgayVao.Text.Trim().Length == 0)
        {
            ShowMessage("Chưa nhập ngày bắt đầu nghỉ!");
            dtNgayVao.Focus();
            return false;
        }
        else if (!DateTime.TryParseExact(dtNgayVao.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
        {
            ShowMessage("Nhập ngày bắt đầu nghỉ không đúng định dạng!");
            dtNgayVao.Focus();
            return false;
        }
        else if (dtNgayCap.Text.Trim().Length == 0)
        {
            ShowMessage("Chưa nhập ngày cấp!");
            dtNgayCap.Focus();
            return false;
        }
        else if (!DateTime.TryParseExact(dtNgayCap.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
        {
            ShowMessage("Nhập ngày cấp không đúng định dạng!");
            dtNgayCap.Focus();
            return false;
        }
        else if (dtNGAYCAP_CMND.Text.Trim().Length > 0 && !DateTime.TryParseExact(dtNGAYCAP_CMND.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
        {
            ShowMessage("Nhập cấp CMND không đúng định dạng!");
            dtNgayVao.Focus();
            return false;
        }
        else if (cboBS.SelectedValue == "")
        {
            ShowMessage("Chưa nhập bác sĩ lập phiếu!");
            cboBS.Focus();
            return false;
        }
        else if (cboBS.SelectedValue != "")
        {
            DMNhanVien nv = DMNhanVien.GetDMNhanVien(cboBS.SelectedValue);
            if (nv == null)
            {
                ShowMessage("Chưa nhập bác sĩ lập phiếu!");
                cboBS.Focus();
                return false;
            }
            else if (nv != null && nv.MaChungChiHanhNghe.Length == 0)
            {
                ShowMessage("Bác sĩ lập phiếu chưa có chứng chỉ hành nghề!");
                cboBS.Focus();
                return false;
            }
            else return true;
        }
        else return true;
    }
    public void PrintData()
    {

        string sPath = Request.ApplicationPath + "/UI/NoiTru/Reports/crGiayCNNghiDuongThai.rpt";
        DataTable dt = spGiayNghiThai_GetXML(decimal.Parse(_SoGiayNghiThai));
        if (dt.Rows.Count > 0)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(Server.MapPath(sPath));
            FormulaFieldDefinitions Myformulas = rpt.DataDefinition.FormulaFields;
            Myformulas["TenBV"].Text = "'" + HTC.ShareVariables.pub_sTenBV + "'";
            rpt.SetDataSource(dt);
            PrintExport(rpt); rpt.Dispose(); rpt = null;//HTCReportViewer1.LoadReport(rpt,true,false);
        }
        else
            ShowMessage("Không có dữ liệu hiển thị!");
    }

    #region API Giay Bao Tu
    #region object
    public class HSDLGBT
    {
        public List<GiayNghiThai> GiayNghiThai { get; set; }
    }
    public class GiayNghiThai
    {
        public string SO_SERI { get; set; }
        public string MA_CT { get; set; }
        public string SO_KCB { get; set; }
        public string MA_BHXH { get; set; }
        public string MA_THE { get; set; }
        public string HO_TEN { get; set; }
        public string NGAY_SINH { get; set; }
        public string TEN_DVI { get; set; }
        public string CHAN_DOAN { get; set; }
        public string NGAY_VAO { get; set; }
        public string NGAY_RA { get; set; }
        public string NGUOI_DAI_DIEN { get; set; }
        public string TEN_BS { get; set; }
        public string MA_BS { get; set; }
        public string NGAY_CT { get; set; }
    }
    public class bodylogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class loginrequest
    {
        public string maKetQua { get; set; }
        public APIKey APIKey { get; set; }
    }
    public class APIKey
    {
        public string access_token { get; set; }
        public string id_token { get; set; }
        public string token_type { get; set; }
        public string username { get; set; }
        public string expires_in { get; set; }
    }
    public class gbtsend
    {
        public string maCskcb { get; set; }
        public string token { get; set; }
        public string id_token { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int loaiHs { get; set; }
        public string fileBase64Str { get; set; }
    }
    public class gbtrequest
    {
        public string MaKetQua { get; set; }
        public string MaGD { get; set; }
        public string ThoiGianTiepNhan { get; set; }
    }
    #endregion
    //ham ma hoa MD5
    public String GetMD5(string txt)
    {
        String str = "";
        Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        buffer = md5.ComputeHash(buffer);
        foreach (Byte b in buffer)
        {
            str += b.ToString("X2");
        }
        return str;
    }
    //ham lay thong tin port
    public DataTable GetPort(string loai)
    {
        DataTable dr = new DataTable();
        string tenStore = "PACS_Port_Get";
        string StrConection = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        using (SqlConnection Conection = new SqlConnection(StrConection))
        {
            Conection.Open();
            using (SqlCommand Command = new SqlCommand(tenStore, Conection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                //Command.Parameters.Add(new SqlParameter("@Loai", "View"));
                Command.Parameters.Add(new SqlParameter("@Loai", loai));
                SqlDataAdapter dp = new SqlDataAdapter(Command);
                dp.Fill(dr);
            }
            //if (dr.Rows.Count > 0)
            //    return dr.Rows[0][0].ToString();
            //else
            //    return "";
            return dr;
        }
    }
    //ham post API
    public string PostOrder(string url, object send)
    {
        var serializer = new JavaScriptSerializer();
        string serializedResult = serializer.Serialize(send);
        Uri myUri = new Uri(url);
        WebRequest myWebRequest = HttpWebRequest.Create(myUri);
        myWebRequest.ContentType = "application/json";
        myWebRequest.Method = "POST";
        HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
        myHttpWebRequest.PreAuthenticate = true;
        //myHttpWebRequest.Headers.Add("Authorization", "Basic " + token);
        using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
        {
            streamWriter.Write(serializedResult);
            streamWriter.Flush();
            streamWriter.Close();
        }
        WebResponse myWebResponse = myWebRequest.GetResponse();
        Stream responseStream = myWebResponse.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
        string pageContent = myStreamReader.ReadToEnd();
        responseStream.Close();
        myWebResponse.Close();
        return pageContent;
        //return xau;
    }
    //ham get token
    public APIKey GetToken(string url, string username, string password)
    {
        APIKey kq = null;
        try
        {
            bodylogin b = new bodylogin();
            b.username = username;
            b.password = password;
            string xau = PostOrder(url, b);
            var returndata = JsonConvert.DeserializeObject<loginrequest>(xau);
            if (returndata != null)
            {
                kq = returndata.APIKey;
            }
        }
        catch (Exception ex)
        {
            kq = null;
            WriteLog("Login error: " + ex.ToString());
        }
        return kq;
    }
    //ham ghi log ra file
    public static void WriteLog(string log)
    {
        string logname = "GBTLog_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
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
    // ma hoa object thanh chuoi xml 
    public string Serialize<T>(T ObjectToSerialize, string loai)
    {
        //XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

        //using (StringWriter textWriter = new StringWriter())
        //{
        //    xmlSerializer.Serialize(textWriter, ObjectToSerialize);
        //    return textWriter.ToString();
        //}
        System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
        settings.Indent = true;
        settings.OmitXmlDeclaration = true;

        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
        // exclude xsi and xsd namespaces by adding the following:
        ns.Add(string.Empty, string.Empty);

        using (StringWriter textWriter = new StringWriter())
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
            {
                serializer.Serialize(xmlWriter, ObjectToSerialize, ns);
            }
            if (loai == "Chuoi")
                return textWriter.ToString();
            else
                return textWriter.ToString().Replace(" p5:nil=\"true\" xmlns:p5=\"http://www.w3.org/2001/XMLSchema-instance\"", "").Replace(" p2:nil=\"true\" xmlns:p2=\"http://www.w3.org/2001/XMLSchema-instance\"", "").Replace("\r\n ", string.Empty).Replace("  ", string.Empty); //This is the output as a string

        }
    }
    #endregion
}