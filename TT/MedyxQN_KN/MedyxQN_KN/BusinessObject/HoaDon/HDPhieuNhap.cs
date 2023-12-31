using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuNhap
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String MaPN { get; set; }
        public String MaNCC { get; set; }
        public String SoHD { get; set; }
        public String SoCT { get; set; }
        public String SoHDon { get; set; }
        public String Makho { get; set; }
        public Boolean Thanhtoan { get; set; }
        public String NgayTToan { get; set; }
        public String NgayNhapTT { get; set; }
        public String NVNhap { get; set; }
        public Decimal VAT { get; set; }
        public Decimal Tong { get; set; }
        public String Ghichu { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgaySD1 { get; set; }
        public String NguoiSD1 { get; set; }
        public String Nguoigiao { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String Ngayhuy { get; set; }
        public String Nguoihuy { get; set; }
        public String MaMay { get; set; }
        public String MaHinhThuc { get; set; }
        public String MaNguon { get; set; }
        public String NgayHDon { get; set; }
        public String NgayPnhap { get; set; }
        public String TENNCC { get; set; }
        public String TENKHO { get; set; }
        public String TENNVNHAP { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }

        public HDPhieuNhap()
        {
            MaPN = "";
            MaNCC = "";
            SoHD = "";
            SoCT = "";
            SoHDon = "";
            Makho = "";
            Thanhtoan = false;
            NgayTToan = "";
            NgayNhapTT = "";
            NVNhap = "";
            VAT = 0;
            Tong = 0;
            Ghichu = "";
            Huy = false;
            NgaySD = "";
            NguoiSD = "";
            NgaySD1 = "";
            NguoiSD1 = "";
            Nguoigiao = "";
            NgayLap = "";
            NguoiLap = "";
            Ngayhuy = "";
            Nguoihuy = "";
            MaMay = "";
            MaHinhThuc = "";
            MaNguon = "";
            NgayHDon = "";
            NgayPnhap = "";
            TENNCC = "";
            TENKHO = "";
            TENNVNHAP = "";
            TENNGUOILAP = "";
            TENNGUOISD = "";
            TENNGUOIHUY = "";
            Ordernumber = 0;
        }

        public HDPhieuNhap(String MaPN, String MaNCC, String SoHD, String SoCT, String SoHDon, String Makho, Boolean Thanhtoan, String NgayTToan, String NgayNhapTT, String NVNhap, Decimal VAT, Decimal Tong, String Ghichu, Boolean Huy, String NgaySD, String NguoiSD, String NgaySD1, String NguoiSD1, String Nguoigiao, String NgayLap, String NguoiLap, String Ngayhuy, String Nguoihuy, String MaMay, String MaHinhThuc, String MaNguon, String NgayHDon, String NgayPnhap, String TENNCC, String TENKHO, String TENNVNHAP, String TENNGUOILAP, String TENNGUOISD, String TENNGUOIHUY, Int32 Ordernumber)
        {
            this.MaPN = MaPN;
            this.MaNCC = MaNCC;
            this.SoHD = SoHD;
            this.SoCT = SoCT;
            this.SoHDon = SoHDon;
            this.Makho = Makho;
            this.Thanhtoan = Thanhtoan;
            this.NgayTToan = NgayTToan;
            this.NgayNhapTT = NgayNhapTT;
            this.NVNhap = NVNhap;
            this.VAT = VAT;
            this.Tong = Tong;
            this.Ghichu = Ghichu;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgaySD1 = NgaySD1;
            this.NguoiSD1 = NguoiSD1;
            this.Nguoigiao = Nguoigiao;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.Ngayhuy = Ngayhuy;
            this.Nguoihuy = Nguoihuy;
            this.MaMay = MaMay;
            this.MaHinhThuc = MaHinhThuc;
            this.MaNguon = MaNguon;
            this.NgayHDon = NgayHDon;
            this.NgayPnhap = NgayPnhap;
            this.TENNCC = TENNCC;
            this.TENKHO = TENKHO;
            this.TENNVNHAP = TENNVNHAP;
            this.TENNGUOILAP = TENNGUOILAP;
            this.TENNGUOISD = TENNGUOISD;
            this.TENNGUOIHUY = TENNGUOIHUY;
            this.Ordernumber = Ordernumber;
        }
        public HDPhieuNhap(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPN"].GetType().Name != "DBNull" && dr["MaPN"] != null)
            {
                this.MaPN = Convert.ToString(dr["MaPN"]);
            }
            else
            {
                this.MaPN = "";
            }
            if (dr["MaNCC"].GetType().Name != "DBNull" && dr["MaNCC"] != null)
            {
                this.MaNCC = Convert.ToString(dr["MaNCC"]);
            }
            else
            {
                this.MaNCC = "";
            }
            if (dr["SoHD"].GetType().Name != "DBNull" && dr["SoHD"] != null)
            {
                this.SoHD = Convert.ToString(dr["SoHD"]);
            }
            else
            {
                this.SoHD = "";
            }
            if (dr["SoCT"].GetType().Name != "DBNull" && dr["SoCT"] != null)
            {
                this.SoCT = Convert.ToString(dr["SoCT"]);
            }
            else
            {
                this.SoCT = "";
            }
            if (dr["SoHDon"].GetType().Name != "DBNull" && dr["SoHDon"] != null)
            {
                this.SoHDon = Convert.ToString(dr["SoHDon"]);
            }
            else
            {
                this.SoHDon = "";
            }
            if (dr["Makho"].GetType().Name != "DBNull" && dr["Makho"] != null)
            {
                this.Makho = Convert.ToString(dr["Makho"]);
            }
            else
            {
                this.Makho = "";
            }

            if (dr["Thanhtoan"].GetType().Name != "DBNull" && dr["Thanhtoan"] != null)
            {
                this.Thanhtoan = Convert.ToBoolean(dr["Thanhtoan"]);
            }
            else
            {
                this.Thanhtoan = false;
            }
            if (dr["NgayTToan"].GetType().Name != "DBNull" && dr["NgayTToan"] != null)
            {
                this.NgayTToan = Convert.ToDateTime(dr["NgayTToan"]).ToShortDateString();
            }
            else
            {
                this.NgayTToan = "";
            }
            if (dr["NgayNhapTT"].GetType().Name != "DBNull" && dr["NgayNhapTT"] != null)
            {
                this.NgayNhapTT = Convert.ToDateTime(dr["NgayNhapTT"]).ToShortDateString();
            }
            else
            {
                this.NgayNhapTT = "";
            }
            if (dr["NVNhap"].GetType().Name != "DBNull" && dr["NVNhap"] != null)
            {
                this.NVNhap = Convert.ToString(dr["NVNhap"]);
            }
            else
            {
                this.NVNhap = "";
            }
            if (dr["VAT"].GetType().Name != "DBNull" && dr["VAT"] != null)
            {
                this.VAT = Convert.ToDecimal(dr["VAT"]);
            }
            else
            {
                this.VAT = 0;
            }
            if (dr["Tong"].GetType().Name != "DBNull" && dr["Tong"] != null)
            {
                this.Tong = Convert.ToDecimal(dr["Tong"]);
            }
            else
            {
                this.Tong = 0;
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = "";
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
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToShortDateString();
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
            if (dr["NgaySD1"].GetType().Name != "DBNull" && dr["NgaySD1"] != null)
            {
                this.NgaySD1 = Convert.ToDateTime(dr["NgaySD1"]).ToShortDateString();
            }
            else
            {
                this.NgaySD1 = "";
            }
            if (dr["NguoiSD1"].GetType().Name != "DBNull" && dr["NguoiSD1"] != null)
            {
                this.NguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
            }
            else
            {
                this.NguoiSD1 = "";
            }
            if (dr["Nguoigiao"].GetType().Name != "DBNull" && dr["Nguoigiao"] != null)
            {
                this.Nguoigiao = Convert.ToString(dr["Nguoigiao"]);
            }
            else
            {
                this.Nguoigiao = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToShortDateString();
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
            if (dr["Ngayhuy"].GetType().Name != "DBNull" && dr["Ngayhuy"] != null)
            {
                this.Ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToShortDateString();
            }
            else
            {
                this.Ngayhuy = "";
            }
            if (dr["Nguoihuy"].GetType().Name != "DBNull" && dr["Nguoihuy"] != null)
            {
                this.Nguoihuy = Convert.ToString(dr["Nguoihuy"]);
            }
            else
            {
                this.Nguoihuy = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["MaHinhThuc"].GetType().Name != "DBNull" && dr["MaHinhThuc"] != null)
            {
                this.MaHinhThuc = Convert.ToString(dr["MaHinhThuc"]);
            }
            else
            {
                this.MaHinhThuc = "";
            }
            if (dr["MaNguon"].GetType().Name != "DBNull" && dr["MaNguon"] != null)
            {
                this.MaNguon = Convert.ToString(dr["MaNguon"]);
            }
            else
            {
                this.MaNguon = "";
            }
            if (dr["NgayHDon"].GetType().Name != "DBNull" && dr["NgayHDon"] != null)
            {
                this.NgayHDon = Convert.ToDateTime(dr["NgayHDon"]).ToShortDateString();
            }
            else
            {
                this.NgayHDon = "";
            }
            if (dr["NgayPnhap"].GetType().Name != "DBNull" && dr["NgayPnhap"] != null)
            {
                this.NgayPnhap = Convert.ToDateTime(dr["NgayPnhap"]).ToShortDateString();
            }
            else
            {
                this.NgayPnhap = "";
            }
            if (dr["TENNCC"].GetType().Name != "DBNull" && dr["TENNCC"] != null)
            {
                this.TENNCC = Convert.ToString(dr["TENNCC"]);
            }
            else
            {
                this.TENNCC = "";
            }
            if (dr["TENKHO"].GetType().Name != "DBNull" && dr["TENKHO"] != null)
            {
                this.TENKHO = Convert.ToString(dr["TENKHO"]);
            }
            else
            {
                this.TENKHO = "";
            }
            if (dr["TENNVNHAP"].GetType().Name != "DBNull" && dr["TENNVNHAP"] != null)
            {
                this.TENNVNHAP = Convert.ToString(dr["TENNVNHAP"]);
            }
            else
            {
                this.TENNVNHAP = "";
            }
            if (dr["TENNGUOILAP"].GetType().Name != "DBNull" && dr["TENNGUOILAP"] != null)
            {
                this.TENNGUOILAP = Convert.ToString(dr["TENNGUOILAP"]);
            }
            else
            {
                this.TENNGUOILAP = "";
            }
            if (dr["TENNGUOISD"].GetType().Name != "DBNull" && dr["TENNGUOISD"] != null)
            {
                this.TENNGUOISD = Convert.ToString(dr["TENNGUOISD"]);
            }
            else
            {
                this.TENNGUOISD = "";
            }
            if (dr["TENNGUOIHUY"].GetType().Name != "DBNull" && dr["TENNGUOIHUY"] != null)
            {
                this.TENNGUOIHUY = Convert.ToString(dr["TENNGUOIHUY"]);
            }
            else
            {
                this.TENNGUOIHUY = "";
            }
            this.Ordernumber = Ordernumber;
        }


        public static HDPhieuNhap GetByMa(String MaPN)
        {
            HDPhieuNhap obj = new HDPhieuNhap();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPhieuNhap_GET", MaPN))
            {
                while (dr.Read())
                {
                    obj = new HDPhieuNhap(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuNhap_CREATE", MaNCC, SoHD, SoCT, (NgayPnhap == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayPnhap)), Makho, VAT, Thanhtoan, (NgayTToan == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayTToan)), (NgayNhapTT == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayNhapTT)), NVNhap, Tong, Ghichu, Huy, NguoiSD, MaMay, Nguoigiao, MaNguon, MaHinhThuc, SoHDon, (NgayHDon == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayHDon))).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuNhap_UPDATE", MaPN, MaNCC, SoHD, SoCT, (NgayPnhap == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayPnhap)), Makho, VAT, Thanhtoan, (NgayTToan == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayTToan)), (NgayNhapTT == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayNhapTT)), NVNhap, Tong, Ghichu, Huy, NguoiSD, (NgaySD1 == "" ? new Nullable<DateTime>() : DateTime.Parse(NgaySD1)), NguoiSD1, Nguoigiao, MaNguon, MaHinhThuc, SoHDon, (NgayHDon == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayHDon))).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuNhap_DELETED", MaPN, MaMay, NguoiSD).ToString();
        }

    }
}
