using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Text;
using System.Xml;
using System.Data;


/// <summary>
/// Summary description for frmBHYT
/// </summary>
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class frmBHYT : System.Web.Services.WebService
{
    DateTime tungay;
    DateTime denngay;
    public const String SIGN_BY_TAGNAME = "SIGN_BY_TAGNAME";
    public const String TAG_SIGNING = "TAG_SIGNING";
    public const String PARRENT_TAG_SIGNING = "PARRENT_TAG_SIGNING";
    public const String ID_TAG_SIGNING = "ID_TAG_SIGNING";

    public frmBHYT()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    #region LoadData

    public void LoadData()
    {

        LoadDataNoiTru();
        LoadDataNgoaiTru();
    }
    public void LoadDataNgoaiTru()
    {
        try
        {
            string dk = "";
            DataSet ds = HTC.Business.DataProvider.Instance().RptGetKhambenh_VP(tungay, denngay, "1", 10, "000", "2", dk);

            ds.Tables[0].TableName = "TONG_HOP";
            if (ds.Tables.Count > 1)
                ds.Tables.RemoveAt(1);
            ds.DataSetName = "TONGHOP";
            dk = " and b.madt like '1%' and (b.bhtinhtien =1 or b.tinhtien =0)";
            if (ds.Tables[0].Rows.Count > 0)
            {

                DataSet ds1 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuoc(tungay, denngay, "", 105, "1", "", "000", 2, dk, 0);

                ds1.Tables[0].TableName = "CHI_TIET_THUOC";
                ds1.DataSetName = "DSACH_CHI_TIET_THUOC";
                if (ds1.Tables.Count > 1)
                    ds1.Tables.RemoveAt(1);
                dk = " and b.madt like '1%' and (b.bhtinhtien =1 or b.tinhtien =0)";

                DataSet ds2 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuoc(tungay, denngay, "", 104, "1", "", "000", 2, dk, 0);
                ds2.Tables[0].TableName = "CHI_TIET_DVKT";
                ds2.DataSetName = "DSACH_CHI_TIET_DVKT";
                if (ds2.Tables.Count > 1)
                    ds2.Tables.RemoveAt(1);


                OutputXMLTONGHOP(ds, ds1, ds2, false);
            }
        }
        catch (Exception ex)
        {
        }
    }
    public void LoadDataNoiTru()
    {
        try
        {
            string _dk;

            tungay = DateTime.Now.AddMinutes(-10).AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);
            denngay = DateTime.Now.AddSeconds(0 - DateTime.Now.Second + 1).AddMilliseconds(0 - DateTime.Now.Millisecond + 1);

            _dk = "  and A.madt like '1%' and (A.bhtinhtien =1 and A.tinhtien =0  )";


            DataSet ds = HTC.Business.DataProvider.Instance().RptGetBenhAn_VP(tungay, denngay, "1", 25, _dk, true);
            ds.Tables[0].TableName = "TONG_HOP";
            ds.DataSetName = "TONGHOP";
            if (ds.Tables.Count > 1)
                ds.Tables.RemoveAt(1);
            _dk = "";

            _dk = _dk + "  and b.madt like '1%' and (b.bhtinhtien =1 and b.tinhtien =0  )";
            if (ds.Tables[0].Rows.Count > 0)
            {

                DataSet ds1 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuocNT(tungay, denngay, "", 205, 1, "All", _dk);

                ds1.Tables[0].TableName = "CHI_TIET_THUOC";
                ds1.DataSetName = "DSACH_CHI_TIET_THUOC";
                if (ds1.Tables.Count > 1)
                    ds1.Tables.RemoveAt(1);

                DataSet ds2 = new DataSet();
                ds2 = HTC.Business.DataProvider.Instance().RptGetInBCNhapThuocNT(tungay, denngay, "", 206, 1, "All", _dk);
                ds2.Tables[0].TableName = "CHI_TIET_DVKT";
                ds2.DataSetName = "DSACH_CHI_TIET_DVKT";
                if (ds2.Tables.Count > 1)
                    ds2.Tables.RemoveAt(1);

                OutputXMLTONGHOP(ds, ds1, ds2, true);
            }

        }
        catch (Exception ex)
        {
        }
    }
    #endregion

    #region Convert File to Base64
    public String ConvertDataSetToByteArray(DataSet dataTable)
    {
        // byte[] tempBytes = null;
        MemoryStream memStream = new MemoryStream();
        //XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);



        //System.Runtime.Serialization.Formatters.Binary.BinaryFormatter brFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        //if (dataTable.DataSetName == "TONGHOP")
        //{
        //    dataTable.Tables[0].RemotingFormat = SerializationFormat.Xml;
        //    brFormatter.Serialize(memStream, dataTable.Tables[0]);
        //}
        //else
        //{
        //    dataTable.RemotingFormat = SerializationFormat.Xml;
        //    brFormatter.Serialize(memStream, dataTable);
        //}


        //  StringWriter sw = new StringWriter();
        //dataSet.WriteXml(sw);
        //string result = sw.ToString();

        //if (dataTable.DataSetName == "TONGHOP")
        //{
        //    //writer.WriteStartDocument();
        //    dataTable.Tables[0].WriteXml(sw, XmlWriteMode.IgnoreSchema);
        //    //writer.Close();
        //}
        //else
        //{
        //    //DataSet tmp = dataTable;
        //    //tmp.WriteXml(memStream, XmlWriteMode.IgnoreSchema);
        //    //writer.WriteStartDocument();
        //    dataTable.WriteXml(sw, XmlWriteMode.IgnoreSchema);
        //    //writer.Close();
        //}
        string base64String;
        if (dataTable.DataSetName == "TONGHOP")
        {
            //   writer.WriteStartDocument();
            //dataTable.Tables[0].WriteXml(memStream, XmlWriteMode.IgnoreSchema );

            //  writer.Close();
            StringWriter sw = new StringWriter();
            dataTable.WriteXml(sw, XmlWriteMode.IgnoreSchema);
            string s = sw.ToString();
            s = s.Replace("<TONGHOP>", "");
            if (s.Length > 50)
                s = s.Substring(0, s.Length - 10);
            s = s.TrimEnd();
            s = s.TrimStart();
            StreamWriter writer = new StreamWriter(memStream);
            writer.Write(s);
            writer.Flush();
            memStream.Position = 0;


        }
        else
        {
            //DataSet tmp = dataTable;
            //tmp.WriteXml(memStream, XmlWriteMode.IgnoreSchema);
            // writer.WriteStartDocument();
            dataTable.WriteXml(memStream, XmlWriteMode.IgnoreSchema);
            //StringWriter sw = new StringWriter();
            //dataTable.WriteXml(sw, XmlWriteMode.IgnoreSchema);
            //string s = sw.ToString();
            //if (s.Length > 100)
            //    s = s.Substring(0, s.Length - 20);
            //StreamWriter writer = new StreamWriter(memStream);
            //writer.Write(s);
            //writer.Flush();
            //memStream.Position = 0;
            // writer.Close();
        }
        base64String = Convert.ToBase64String(memStream.ToArray());


        //  ShowMessage(sw.ToString());
        //Byte[] bytes = Encoding.Unicode.GetBytes(sw.ToString());
        //string base64 = Convert.ToBase64String(bytes);

        //ShowMessage(base64.ToString());
        //ShowMessage(base64String);
        //tempBytes = Convert.FromBase64String(base64String);


        //Random r = new Random();
        //string name = "LeLoiNgoc" + r.Next().ToString() + ".html";
        //File.WriteAllBytes(Server.MapPath(name), tempBytes);


        return base64String;
        //DataColumn column = new DataColumn();
        //column.DataType = System.Type.GetType("System.Int32");
        //column.AutoIncrement = true;
        //column.AutoIncrementSeed = 1;
        //column.AutoIncrementStep = 1;
        //XmlTextWriter xml = new XmlTextWriter(Response.Output) { Formatting = Formatting.None }; // XML writer
        //xml.WriteStartDocument(); // XML header
        //ds.WriteXml(xml); // Write XML output
    }

    public byte[] convertBase64ByFile(string Path)
    {

        using (StreamReader sr = new StreamReader(Path))
        {
            byte[] AsBytes = File.ReadAllBytes(Path);
            String AsBase64String = Convert.ToBase64String(AsBytes);
            byte[] tempBytes = Convert.FromBase64String(AsBase64String);
            //Random r = new Random();
            //string name = "LeLoiNgoc" + r.Next().ToString() + ".html";
            //File.WriteAllBytes(Server.MapPath(name), tempBytes);
            return tempBytes;
        }

    }
    #endregion

    #region Các object Tạo luôn ở đây vì chỉ form này dùng
    public class GIAMDINHHS
    {
        public THONGTINDONVI THONGTINDONVI { set; get; }
        public THONGTINHOSO THONGTINHOSO { get; set; }
        public string CHUKYDONVI { get; set; }

    }
    public class THONGTINDONVI
    {
        public string MACSKCB { get; set; }
    }
    public class THONGTINHOSO
    {
        public string NGAYLAP { set; get; }
        public int SOLUONGHOSO { get; set; }
        public HOSO[] DANHSACHHOSO { get; set; }
    }
    public class HOSO
    {

        public FILEHOSO[] FILEHOSO;


    }
    public class FILEHOSO
    {
        public string LOAIHOSO { get; set; }
        public String NOIDUNGFILE { get; set; }
    }

    #endregion
    #region Các method tạo ra file XML giám định tổng hợp Hàm Này có thể Writer ra file luôn nếu chỉnh lại
    #region Method chính
    public void OutputXMLTONGHOP(DataSet ds1, DataSet ds2, DataSet ds3, Boolean noitru)
    {
        GIAMDINHHS giamDinhHS = new GIAMDINHHS();
        giamDinhHS.THONGTINDONVI = getThongTinDonVi();
        giamDinhHS.CHUKYDONVI = string.Empty;
        giamDinhHS.THONGTINHOSO = getThongTinHOSO(ds1, ds2, ds3);
        string filename = "";
        string _tungay = tungay.ToString("dd/MM/yyyy HH:mm");
        string _denngay = denngay.ToString("dd/MM/yyyy HH:mm");
        if (noitru == false)
            filename = System.Web.Hosting.HostingEnvironment.MapPath(@"~\Temp\GiamDinhBaoHiemNgoaiTru" + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _tungay.Substring(14, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + _denngay.Substring(14, 2) + ".XML");
        else
        {
            //System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(System.Web.Hosting.HostingEnvironment.MapPath(@"~\Temp"));

            // foreach(System.IO.FileInfo file in directory.GetFiles()) file.Delete();

            filename = System.Web.Hosting.HostingEnvironment.MapPath(@"~\Temp\GiamDinhBaoHiemNoiTru" + _tungay.Substring(0, 2) + _tungay.Substring(11, 2) + _tungay.Substring(14, 2) + _denngay.Substring(0, 2) + _denngay.Substring(11, 2) + _denngay.Substring(14, 2) + ".XML");
        }
        if (File.Exists(filename))
        {
            FileInfo fi = new FileInfo(filename);
            if (fi.IsReadOnly)
                fi.IsReadOnly = false;
            fi.Delete();
        }
        StreamWriter file = new StreamWriter(filename, false, Encoding.UTF8);
        file.Write(returnObjectToXml(giamDinhHS));
        file.Close();
        //this.Response.Clear();
        //this.Response.ContentType = "text/xml";
        //this.Response.Charset = "utf-8";


        System.IO.File.WriteAllText(filename, returnObjectToXml(giamDinhHS));



        //string filename = Server.MapPath(@"~\Temp\GiamDinhBaoHiem" + denngay.Substring(3, 2) + denngay.Substring(6, 4) + ".XML");
        //XmlDocument doc = new XmlDocument();

        ////MemoryStream memoryStream = new MemoryStream();
        ////System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(giamDinhHS .GetType());
        ////XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
        ////xs.Serialize(xmlTextWriter, giamDinhHS);

        ////xmlTextWriter.Formatting = Formatting.Indented;

        ////doc.Save(xmlTextWriter);




        ////Add some elements and attributes.
        ////XmlDocument xmlDoc = new XmlDocument();
        ////XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        ////xmlDoc.AppendChild(xmlDeclaration);

        ////xmlDoc.LoadXml (returnObjectToXml(giamDinhHS));
        ////xmlDoc.Save (filename); 


        ////this.Response.Clear();
        ////this.Response.ContentType = "text/xml";
        ////this.Response.Charset = "utf-8";
        ////string filename = "GiamDinhBaoHiem" + denngay.Substring(3, 2) + denngay.Substring(6, 4) + ".XML";

        ////Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + "");

        ////System.Xml.XmlWriter xmlWriter = new System.Xml.XmlTextWriter(this.Response.OutputStream, System.Text.Encoding.UTF8);

        ////// create xml data document with xml declaration
        ////System.Xml.XmlDataDocument xmlDoc = new System.Xml.XmlDataDocument();
        ////xmlDoc.DataSet.EnforceConstraints = false;
        ////xmlDoc.LoadXml(returnObjectToXml(giamDinhHS));
        ////System.Xml.XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        ////xmlDoc.PrependChild(xmlDec);

        ////// write xml document to response
        ////xmlDoc.WriteTo(xmlWriter);
        ////xmlWriter.Flush();
        ////xmlWriter.Close();
        ////Response.End();
    }
    #endregion
    #endregion


    #region Convert object to XML
    public string returnObjectToXml(GIAMDINHHS o)
    {
        //String outPut = string.Empty;
        //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(obj.GetType());
        //x.Serialize(Console.Out, obj);
        //System.IO.StringWriter sww = new System.IO.StringWriter();
        //XmlWriter writer = XmlWriter.Create(sww);
        //x.Serialize(writer, obj);
        //var xml = sww.ToString();
        //String HSBA = xml.ToString();
        //outPut = xml.ToString();
        //return outPut;

        //StringWriter sw = new StringWriter();
        //XmlTextWriter tw = null;
        //try
        //{
        //    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(o.GetType());
        //    tw = new XmlTextWriter(sw);

        //    serializer.Serialize(tw, o);

        //}
        //catch (Exception ex)
        //{
        //    //Handle Exception Code
        //}
        //finally
        //{
        //    sw.Close();
        //    if (tw != null)
        //    {
        //        tw.Close();
        //    }
        //}
        //return sw.ToString();
        MemoryStream memoryStream = new MemoryStream();
        System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(o.GetType());
        XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
        xs.Serialize(xmlTextWriter, o);
        string sw = Encoding.UTF8.GetString(memoryStream.ToArray());
        sw = sw.Replace("<FILEHOSO><FILEHOSO>", "<FILEHOSO>");
        sw = sw.Replace("</FILEHOSO></FILEHOSO>", "</FILEHOSO>");
        //sw.Replace("<FILEHOSO>", "");
        //sw.Replace("</FILEHOSO>", "");
        //sw.Replace("</LOAIHOSO>", "</LOAIHOSO></FILEHOSO>");
        //sw.Replace("<LOAIHOSO>", "<FILEHOSO><LOAIHOSO>");
        return sw.ToString();
    }
    #endregion

    #region getThongTinDonVi
    public THONGTINDONVI getThongTinDonVi() // MACSKCB sẽ lấy ở data hoặc dynamic ở cái gì đó :D
    {
        THONGTINDONVI thongTinDonVi = new THONGTINDONVI();
        thongTinDonVi.MACSKCB = HTC.ShareVariables.pub_sMaBHXH;
        return thongTinDonVi;
    }

    #endregion

    #region getThongTinHOSO
    public THONGTINHOSO getThongTinHOSO(DataSet ds1, DataSet ds2, DataSet ds3)
    {
        THONGTINHOSO thongTinHS = new THONGTINHOSO();
        thongTinHS.NGAYLAP = DateTime.Now.Year.ToString() + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());


        List<HOSO> HOSO = new List<HOSO>();
        foreach (DataRow Row in ds1.Tables[0].Rows)
        {

            HOSO hs = new HOSO();

            List<FILEHOSO> f = new List<FILEHOSO>();


            FILEHOSO fhs1 = getTongHop(Row);

            FILEHOSO fhs2 = getDichVu(ds2, Row["MA_LK"].ToString(), "DSACH_CHI_TIET_THUOC");
            FILEHOSO fhs3 = getDichVu(ds3, Row["MA_LK"].ToString(), "DSACH_CHI_TIET_DVKT");
            f.Add(fhs1);
            if (fhs2 != null)
                f.Add(fhs2);
            if (fhs3 != null)
                f.Add(fhs3);
            //hs.Add(fhs1);
            hs.FILEHOSO = f.ToArray();
            HOSO.Add(hs);
        }

        thongTinHS.SOLUONGHOSO = HOSO.Count;// ?
        thongTinHS.DANHSACHHOSO = HOSO.ToArray();

        // = getDanhSachHS(ds1, ds2, ds3);
        return thongTinHS;
    }
    #endregion

    #region getDanhSachHS
    public FILEHOSO getTongHop(DataRow r)
    {
        FILEHOSO fileHS = new FILEHOSO();
        fileHS.LOAIHOSO = "XML1";
        MemoryStream memStream = new MemoryStream();

        StringWriter sw = new StringWriter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        ds.DataSetName = "TONGHOP";
        dt.TableName = "TONG_HOP";
        dt = r.Table.Clone();

        dt.Rows.Add(r.ItemArray);

        // dt.ImportRow(r);
        ds.Tables.Add(dt);
        dt.WriteXml(sw, XmlWriteMode.IgnoreSchema);
        string s = sw.ToString();
        s = s.Replace("<TONGHOP>", "");
        if (s.Length > 20)
            s = s.Substring(0, s.Length - 10);
        s = s.TrimEnd();
        s = s.TrimStart();
        StreamWriter writer = new StreamWriter(memStream);
        writer.Write(s);
        writer.Flush();
        memStream.Position = 0;

        string base64String = Convert.ToBase64String(memStream.ToArray());
        fileHS.NOIDUNGFILE = base64String;
        return fileHS;
    }

    public FILEHOSO getDichVu(DataSet ds, string maba, string dataname)
    {
        FILEHOSO fileHS = new FILEHOSO();
        DataRow[] rows = ds.Tables[0].Select("MA_LK='" + maba + "'");

        if (rows != null)
        {
            if (rows.Any())
            {
                if (ds.DataSetName == "DSACH_CHI_TIET_THUOC" || dataname == "DSACH_CHI_TIET_THUOC")
                {
                    fileHS.LOAIHOSO = "XML2";
                    ds.DataSetName = "DSACH_CHI_TIET_THUOC";
                }
                else if (ds.DataSetName == "DSACH_CHI_TIET_DVKT" || dataname == "DSACH_CHI_TIET_DVKT")
                {
                    fileHS.LOAIHOSO = "XML3";
                    ds.DataSetName = "DSACH_CHI_TIET_DVKT";
                }
                MemoryStream memStream = new MemoryStream();
                DataSet dst = new DataSet();
                dst.DataSetName = ds.DataSetName;
                DataTable dt = rows.CopyToDataTable();
                dt.TableName = ds.Tables[0].TableName;
                dst.Tables.Add(dt);
                dst.WriteXml(memStream, XmlWriteMode.IgnoreSchema);
                string base64String = Convert.ToBase64String(memStream.ToArray());
                fileHS.NOIDUNGFILE = base64String;
                return fileHS;
            }
            else
                return null;
        }
        else
            return null;

    }


    #endregion


}



