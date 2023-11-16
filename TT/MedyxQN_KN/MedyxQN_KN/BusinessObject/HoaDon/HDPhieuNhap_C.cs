using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
//
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuNhap_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public Int32 Ordernumber { get; set; }
        public String MaPN { get; set; }
        public Decimal STT { get; set; }
        public String KyHieuMau { get; set; }
        public String KyHieu { get; set; }
        public Decimal VAT { get; set; }
        public Decimal TuSo { get; set; }
        public Decimal DenSo { get; set; }
        public Decimal DonGia { get; set; }
        public Boolean Huy { get; set; }
        public String Ghichu { get; set; }
        public String NgayNhap { get; set; }
        public String NguoiNhap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public Decimal SoLuong { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiNhap { get; set; }
        public Decimal ThanhTien
        {
            get
            {
                return DonGia * SoLuong * (VAT + 100) / 100;
            }
            
        }
        public long SoQuyen
        {
            get
            {
                return (long)SoLuong / 50;
            }
            
        }
        
        public HDPhieuNhap_C()
        {
            MaPN = "";
            STT = 0;
            KyHieuMau = "";
            KyHieu = "";
            VAT = 0;
            TuSo = 0;
            DenSo = 0;
            DonGia = 0;
            Huy = false;
            Ghichu = "";
            NgayNhap = "";
            NguoiNhap = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            SoLuong = 0;
            TenNguoiSD = "";
            TenNguoiNhap = "";
            Ordernumber = 0;
        }

        public HDPhieuNhap_C(String MaPN, Decimal STT, String KyHieuMau, String KyHieu, Decimal VAT, Decimal TuSo, Decimal DenSo, Decimal DonGia, Boolean Huy, String Ghichu, String NgayNhap, String NguoiNhap,String NgaySD, String NguoiSD, String MaMay, Decimal SoLuong, String TenNguoiSD, String TenNguoiNhap, Int32 Ordernumber)
        {
            this.MaPN = MaPN;
            this.STT = STT;
            this.KyHieuMau = KyHieuMau;
            this.KyHieu = KyHieu;
            this.VAT = VAT;
            this.TuSo = TuSo;
            this.DenSo = DenSo;
            this.DonGia = DonGia;
            this.Huy = Huy;
            this.Ghichu = Ghichu;
            this.NgayNhap = NgayNhap;
            this.NguoiNhap = NguoiNhap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.SoLuong = SoLuong;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiNhap = TenNguoiNhap;
            this.Ordernumber = Ordernumber;
        }
        public HDPhieuNhap_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPN"].GetType().Name != "DBNull" && dr["MaPN"] != null)
            {
                this.MaPN = Convert.ToString(dr["MaPN"]);
            }
            else
            {
                this.MaPN = "";
            }
            if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
            {
                this.STT = Convert.ToDecimal(dr["STT"]);
            }
            else
            {
                this.STT = 0;
            }
            if (dr["KyHieuMau"].GetType().Name != "DBNull" && dr["KyHieuMau"] != null)
            {
                this.KyHieuMau = Convert.ToString(dr["KyHieuMau"]);
            }
            else
            {
                this.KyHieuMau = "";
            }
            if (dr["KyHieu"].GetType().Name != "DBNull" && dr["KyHieu"] != null)
            {
                this.KyHieu = Convert.ToString(dr["KyHieu"]);
            }
            else
            {
                this.KyHieu = "";
            }
            if (dr["VAT"].GetType().Name != "DBNull" && dr["VAT"] != null)
            {
                this.VAT = Convert.ToDecimal(dr["VAT"]);
            }
            else
            {
                this.VAT = 0;
            }
            if (dr["TuSo"].GetType().Name != "DBNull" && dr["TuSo"] != null)
            {
                this.TuSo = Convert.ToDecimal(dr["TuSo"]);
            }
            else
            {
                this.TuSo = 0;
            }
            if (dr["DenSo"].GetType().Name != "DBNull" && dr["DenSo"] != null)
            {
                this.DenSo = Convert.ToDecimal(dr["DenSo"]);
            }
            else
            {
                this.DenSo = 0;
            }
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = "";
            }
            if (dr["NgayNhap"].GetType().Name != "DBNull" && dr["NgayNhap"] != null)
            {
                this.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]).ToShortDateString();
            }
            else
            {
                this.NgayNhap = "";
            }
            if (dr["NguoiNhap"].GetType().Name != "DBNull" && dr["NguoiNhap"] != null)
            {
                this.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
            }
            else
            {
                this.NguoiNhap = "";
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
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["SoLuong"].GetType().Name != "DBNull" && dr["SoLuong"] != null)
            {
                this.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
            }
            else
            {
                this.SoLuong = 0;
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenNguoiNhap"].GetType().Name != "DBNull" && dr["TenNguoiNhap"] != null)
            {
                this.TenNguoiNhap = Convert.ToString(dr["TenNguoiNhap"]);
            }
            else
            {
                this.TenNguoiNhap = "";
            }
            this.Ordernumber = Ordernumber;
        }


        public static HDPhieuNhap_C GetByMa(String MaPN, Byte STT)
        {
            HDPhieuNhap_C obj = new HDPhieuNhap_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPhieuNhap_C_GET", MaPN, STT))
            {                
                while (dr.Read())
                {
                    obj = new HDPhieuNhap_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuNhap_C_CREATE", MaPN, KyHieuMau, KyHieu, VAT, TuSo, DenSo, DonGia, Ghichu, MaMay, NguoiNhap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuNhap_C_UPDATE", MaPN, STT, KyHieuMau, KyHieu, VAT, TuSo, DenSo, DonGia, Ghichu, MaMay, NguoiSD, Huy).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuNhap_C_DELETED", MaPN, STT, NguoiSD, MaMay).ToString();
        }

    }
}
