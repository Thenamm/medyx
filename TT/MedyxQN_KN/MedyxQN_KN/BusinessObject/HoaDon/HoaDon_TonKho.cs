// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HoaDon_TonKho
// Kieu doi tuong  :	HoaDon_TonKho
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 11:11:49 AM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi cac ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.HoaDon
{

    [Serializable()]
    public class HoaDon_TonKho
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal HDTonKhoId { get; set; }
        public String Makho { get; set; }
        public String KyHieuMau { get; set; }
        public String KyHieu { get; set; }
        public Decimal TuSo { get; set; }
        public Decimal DenSo { get; set; }
        public Decimal TonCK { get; set; }
        public Decimal TonCKDT { get; set; }
        public Decimal GiaNhap { get; set; }
        public Decimal KhoangBD { get; set; }
        public Decimal KhoangKT { get; set; }
        public Decimal SoLuong { get; set; }
        public String Thang { get; set; }
        public String TenTat { get; set; }

        public HoaDon_TonKho()
        {
            HDTonKhoId = 0;
            Makho = "";
            KyHieuMau = "";
            KyHieu = "";
            TuSo = 0;
            DenSo = 0;
            TonCK = 0;
            TonCKDT = 0;
            GiaNhap = 0;
            KhoangBD = 0;
            KhoangKT = 0;
            SoLuong = 0;
            Thang = "";
            Ordernumber = 0;
            TenTat = "";
        }

        public HoaDon_TonKho(Decimal HDTonKhoId, String Makho, String KyHieuMau, String KyHieu, Decimal TuSo, Decimal DenSo, Decimal TonCK, Decimal TonCKDT, Decimal GiaNhap, Decimal KhoangBD, Decimal KhoangKT, String Thang, Int32 Ordernumber)
        {
            this.HDTonKhoId = HDTonKhoId;
            this.Makho = Makho;
            this.KyHieuMau = KyHieuMau;
            this.KyHieu = KyHieu;
            this.TuSo = TuSo;
            this.DenSo = DenSo;
            this.TonCK = TonCK;
            this.TonCKDT = TonCKDT;
            this.GiaNhap = GiaNhap;
            this.KhoangBD = KhoangBD;
            this.KhoangKT = KhoangKT;
            this.SoLuong = Math.Round(TonCK/50,0);
            this.Thang = Thang;
            this.TenTat = KyHieuMau + "(" + HDTonKhoId + ")";
            this.Ordernumber = Ordernumber;
        }
        public HoaDon_TonKho(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["HDTonKhoId"].GetType().Name != "DBNull" && dr["HDTonKhoId"] != null)
            {
                this.HDTonKhoId = Convert.ToDecimal(dr["HDTonKhoId"]);
            }
            else
            {
                this.HDTonKhoId = 0;
            }
            if (dr["Makho"].GetType().Name != "DBNull" && dr["Makho"] != null)
            {
                this.Makho = Convert.ToString(dr["Makho"]);
            }
            else
            {
                this.Makho = "";
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
            if (dr["TonCK"].GetType().Name != "DBNull" && dr["TonCK"] != null)
            {
                this.TonCK = Convert.ToDecimal(dr["TonCK"]);
            }
            else
            {
                this.TonCK = 0;
            }
            if (dr["TonCKDT"].GetType().Name != "DBNull" && dr["TonCKDT"] != null)
            {
                this.TonCKDT = Convert.ToDecimal(dr["TonCKDT"]);
            }
            else
            {
                this.TonCKDT = 0;
            }
            if (dr["GiaNhap"].GetType().Name != "DBNull" && dr["GiaNhap"] != null)
            {
                this.GiaNhap = Convert.ToDecimal(dr["GiaNhap"]);
            }
            else
            {
                this.GiaNhap = 0;
            }
            if (dr["KhoangBD"].GetType().Name != "DBNull" && dr["KhoangBD"] != null)
            {
                this.KhoangBD = Convert.ToDecimal(dr["KhoangBD"]);
            }
            else
            {
                this.KhoangBD = 0;
            }
            if (dr["KhoangKT"].GetType().Name != "DBNull" && dr["KhoangKT"] != null)
            {
                this.KhoangKT = Convert.ToDecimal(dr["KhoangKT"]);
            }
            else
            {
                this.KhoangKT = 0;
            }

            this.SoLuong = Math.Round(this.TonCKDT / 50, 0);

            if (dr["Thang"].GetType().Name != "DBNull" && dr["Thang"] != null)
            {
                this.Thang = Convert.ToString(dr["Thang"]);
            }
            else
            {
                this.Thang = "";
            }
            this.TenTat = KyHieuMau + "(" + HDTonKhoId + ")";
            this.Ordernumber = Ordernumber;
        }
        
        public static String TinhTon(DateTime Thang, String Makho)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(strConnect, "spHDTinhTonKho", Thang, Makho);
                return "Tính tồn đã thành công";
            }
            catch
            {
                return "Tính tồn không thành công";
            }
        }
    }
}
