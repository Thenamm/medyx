using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{

    [Serializable()]
    public class HDKiemKe_HD
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String NgayKK { get; set; }
        public Boolean Xuly { get; set; }
        public String Makho { get; set; }
        public String GhiChuKK { get; set; }
        public String MAKK { get; set; }
        public Decimal STT { get; set; }
        public String KyHieuMau { get; set; }
        public String KyHieu { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal TuSo { get; set; }
        public Decimal DenSo { get; set; }
        public String Ghichu { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenKho { get; set; }
        public Decimal TuSoKho { get; set; }
        public Decimal DenSoKho { get; set; }
        public Boolean IsKiemKe { get; set; }
        public Int32 Quyen { get; set; }
        public Int64 SoLuong { get; set; }

        public HDKiemKe_HD()
        {
            NgayKK = "";
            Xuly = false;
            Makho = "";
            GhiChuKK = "";
            MAKK = "";
            STT = 0;
            KyHieuMau = "";
            KyHieu = "";
            DonGia = 0;
            TuSo = 0;
            DenSo = 0;
            Ghichu = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenKho = "";
            TuSoKho = 0;
            DenSoKho = 0;
            IsKiemKe = false;
            Ordernumber = 0;
            Quyen = 0;
            SoLuong = 0;
        }

        public HDKiemKe_HD(String NgayKK, Boolean Xuly, String Makho, String GhiChuKK, String MAKK, Decimal STT, String KyHieuMau, String KyHieu, Decimal DonGia, Decimal TuSo, Decimal DenSo, String Ghichu, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String MaMay, String TenNguoiLap, String TenNguoiSD, String TenKho, Decimal TuSoKho, Decimal DenSoKho, Boolean IsKiemKe, Int32 Ordernumber)
        {
            this.NgayKK = NgayKK;
            this.Xuly = Xuly;
            this.Makho = Makho;
            this.GhiChuKK = GhiChuKK;
            this.MAKK = MAKK;
            this.STT = STT;
            this.KyHieuMau = KyHieuMau;
            this.KyHieu = KyHieu;
            this.DonGia = DonGia;
            this.TuSo = TuSo;
            this.DenSo = DenSo;
            this.Ghichu = Ghichu;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenKho = TenKho;
            this.TuSoKho = TuSoKho;
            this.DenSoKho = DenSoKho;
            this.IsKiemKe = IsKiemKe;
            this.Ordernumber = Ordernumber;
            this.Quyen = Convert.ToInt32((DenSo - TuSo + 1) / 50);
            this.SoLuong = Convert.ToInt64(DenSo - TuSo + 1);
        }
        public HDKiemKe_HD(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["NgayKK"].GetType().Name != "DBNull" && dr["NgayKK"] != null)
            {
                this.NgayKK = Convert.ToDateTime(dr["NgayKK"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayKK = "";
            }
            if (dr["Xuly"].GetType().Name != "DBNull" && dr["Xuly"] != null)
            {
                this.Xuly = Convert.ToBoolean(dr["Xuly"]);
            }
            else
            {
                this.Xuly = false;
            }
            if (dr["Makho"].GetType().Name != "DBNull" && dr["Makho"] != null)
            {
                this.Makho = Convert.ToString(dr["Makho"]);
            }
            else
            {
                this.Makho = "";
            }
            if (dr["GhiChuKK"].GetType().Name != "DBNull" && dr["GhiChuKK"] != null)
            {
                this.GhiChuKK = Convert.ToString(dr["GhiChuKK"]);
            }
            else
            {
                this.GhiChuKK = "";
            }
            if (dr["MAKK"].GetType().Name != "DBNull" && dr["MAKK"] != null)
            {
                this.MAKK = Convert.ToString(dr["MAKK"]);
            }
            else
            {
                this.MAKK = "";
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
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
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
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
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
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
            }
            if (dr["TuSoKho"].GetType().Name != "DBNull" && dr["TuSoKho"] != null)
            {
                this.TuSoKho = Convert.ToDecimal(dr["TuSoKho"]);
            }
            else
            {
                this.TuSoKho = new Decimal();
            }
            if (dr["DenSoKho"].GetType().Name != "DBNull" && dr["DenSoKho"] != null)
            {
                this.DenSoKho = Convert.ToDecimal(dr["DenSoKho"]);
            }
            else
            {
                this.DenSoKho = new Decimal();
            }
            if (dr["IsKiemKe"].GetType().Name != "DBNull" && dr["IsKiemKe"] != null)
            {
                this.IsKiemKe = Convert.ToBoolean(dr["IsKiemKe"]);
            }
            else
            {
                this.IsKiemKe = false;
            }
            this.Quyen = Convert.ToInt32((DenSo - TuSo + 1) / 50);
            this.SoLuong = Convert.ToInt64(DenSo - TuSo + 1);
            this.Ordernumber = Ordernumber;
        }


        public static HDKiemKe_HD GetByMa(String MAKK, Byte STT)
        {
            HDKiemKe_HD obj = new HDKiemKe_HD();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDKiemKe_HD_GET", MAKK, STT))
            {
                while (dr.Read())
                {
                    obj = new HDKiemKe_HD(dr, 1);
                    break;
                }
            }
            return obj;
        }


        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_HD_CREATE", MAKK, KyHieuMau, KyHieu, DonGia, TuSo, DenSo, Ghichu, MaMay, NguoiLap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_HD_UPDATE", MAKK, STT, KyHieuMau, KyHieu, DonGia, TuSo, DenSo, Ghichu, Huy, NguoiSD, MaMay).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_HD_DELETED", MAKK, STT, MaMay, NguoiSD).ToString();
        }
    }
}