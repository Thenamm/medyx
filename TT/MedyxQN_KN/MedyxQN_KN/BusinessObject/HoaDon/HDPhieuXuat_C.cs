using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDPhieuXuat_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String MaPX { get; set; }
        public Decimal STT { get; set; }
        public String KyHieuMau { get; set; }
        public String KyHieu { get; set; }
        public Decimal TuSo { get; set; }
        public Decimal DenSo { get; set; }
        public Int32 Quyen { get; set; }
        public Int64 SoLuong { get; set; }
        public Decimal SLYC { get; set; }
        public Decimal GiaBan { get; set; }
        public String Ghichu { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }

        public HDPhieuXuat_C()
        {
            Quyen = 0;
            SoLuong = 0;
            MaPX = "";
            STT = 0;
            KyHieuMau = "";
            KyHieu = "";
            TuSo = 0;
            DenSo = 0;
            SLYC = 0;
            GiaBan = 0;
            Ghichu = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            Ordernumber = 0;
        }

        public HDPhieuXuat_C(String MaPX, Decimal STT, String KyHieuMau, String KyHieu, Decimal TuSo, Decimal DenSo, Decimal SLYC, Decimal GiaBan, String Ghichu, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String MaMay, String TenNguoiLap, String TenNguoiSD, Int32 Ordernumber)
        {
            this.MaPX = MaPX;
            this.STT = STT;
            this.KyHieuMau = KyHieuMau;
            this.KyHieu = KyHieu;
            this.TuSo = TuSo;
            this.DenSo = DenSo;
            this.SLYC = SLYC;
            this.GiaBan = GiaBan;
            this.Ghichu = Ghichu;
            this.Huy = Huy;
            this.Quyen = Convert.ToInt32((DenSo - TuSo + 1) / 50);
            this.SoLuong = Convert.ToInt64(DenSo - TuSo + 1);
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.Ordernumber = Ordernumber;
        }
        public HDPhieuXuat_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPX"].GetType().Name != "DBNull" && dr["MaPX"] != null)
            {
                this.MaPX = Convert.ToString(dr["MaPX"]);
            }
            else
            {
                this.MaPX = "";
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
            if (dr["SLYC"].GetType().Name != "DBNull" && dr["SLYC"] != null)
            {
                this.SLYC = Convert.ToDecimal(dr["SLYC"]);
            }
            else
            {
                this.SLYC = 0;
            }
            if (dr["GiaBan"].GetType().Name != "DBNull" && dr["GiaBan"] != null)
            {
                this.GiaBan = Convert.ToDecimal(dr["GiaBan"]);
            }
            else
            {
                this.GiaBan = 0;
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

            this.Quyen = Convert.ToInt32((DenSo - TuSo + 1) / 50);
            this.SoLuong = Convert.ToInt64(DenSo - TuSo + 1);

            this.Ordernumber = Ordernumber;
        }

        public static HDPhieuXuat_C GetByMa(String MAPX, Byte STT)
        {
            HDPhieuXuat_C obj = new HDPhieuXuat_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDPHIEUXUAT_C_GET", MAPX, STT))
            {
                while (dr.Read())
                {
                    obj = new HDPhieuXuat_C(dr, 1);
                    break;
                }
            }
            return obj;
        }


        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuXuat_C_CREATE", MaPX, KyHieuMau, KyHieu, TuSo, DenSo, SLYC, GiaBan, Ghichu, NguoiLap, MaMay).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPhieuXuat_C_UPDATE", MaPX, STT, KyHieuMau, KyHieu, TuSo, DenSo, SLYC, GiaBan, Ghichu, Huy, NguoiSD, MaMay).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDPHIEUXUAT_C_DELETED", MaPX, STT, NguoiSD, MaMay).ToString();
        }

    }

}