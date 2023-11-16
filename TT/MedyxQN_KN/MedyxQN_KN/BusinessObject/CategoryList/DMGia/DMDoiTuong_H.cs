using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HTC.Business.CategoryList
{
    [Serializable]
    public class DMDoiTuong_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaDT { get; set; }
        public String TenDT { get; set; }
        public Nullable<Decimal> BHTra { get; set; }
        public Nullable<Decimal> Sotien { get; set; }
        public Nullable<Decimal> SotienKTC { get; set; }
        public String MaMay { get; set; }
        public Nullable<Boolean> Huy { get; set; }
        public Nullable<DateTime> NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String Diachi { get; set; }
        public String TenHangBH { get; set; }
        public String DienThoai { get; set; }
        public String Masothue { get; set; }
        public String TaiKhoan { get; set; }
        public Nullable<Boolean> BVTra { get; set; }
        public String KieuThe { get; set; }
        public Nullable<Decimal> HesoDV { get; set; }
        public Nullable<Decimal> HesoPT { get; set; }
        public Nullable<Decimal> HesoGiuong { get; set; }

        public DMDoiTuong_H()
        {
            MaDT = "";
            TenDT = "";
            BHTra = new Nullable<Decimal>();
            Sotien = new Nullable<Decimal>();
            SotienKTC = new Nullable<Decimal>();
            MaMay = "";
            Huy = new Nullable<Boolean>();
            NgaySD = new Nullable<DateTime>();
            NguoiSD = "";
            Diachi = "";
            TenHangBH = "";
            DienThoai = "";
            Masothue = "";
            TaiKhoan = "";
            BVTra = new Nullable<Boolean>();
            KieuThe = "";
            HesoDV = new Nullable<Decimal>();
            HesoPT = new Nullable<Decimal>();
            HesoGiuong = new Nullable<Decimal>();
            Ordernumber = 0;
        }

        public DMDoiTuong_H(String MaDT, String TenDT, Nullable<Decimal> BHTra, Nullable<Decimal> Sotien, Nullable<Decimal> SotienKTC, String MaMay, Nullable<Boolean> Huy, Nullable<DateTime> NgaySD, String NguoiSD, String Diachi, String TenHangBH, String DienThoai, String Masothue, String TaiKhoan, Nullable<Boolean> BVTra, String KieuThe, Nullable<Decimal> HesoDV, Nullable<Decimal> HesoPT, Nullable<Decimal> HesoGiuong, Int32 Ordernumber)
        {
            this.MaDT = MaDT;
            this.TenDT = TenDT;
            this.BHTra = BHTra;
            this.Sotien = Sotien;
            this.SotienKTC = SotienKTC;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Diachi = Diachi;
            this.TenHangBH = TenHangBH;
            this.DienThoai = DienThoai;
            this.Masothue = Masothue;
            this.TaiKhoan = TaiKhoan;
            this.BVTra = BVTra;
            this.KieuThe = KieuThe;
            this.HesoDV = HesoDV;
            this.HesoPT = HesoPT;
            this.HesoGiuong = HesoGiuong;
            this.Ordernumber = Ordernumber;
        }
        public DMDoiTuong_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaDT"].GetType().Name != "DBNull" && dr["MaDT"] != null)
            {
                this.MaDT = Convert.ToString(dr["MaDT"]);
            }
            else
            {
                this.MaDT = "";
            }
            if (dr["TenDT"].GetType().Name != "DBNull" && dr["TenDT"] != null)
            {
                this.TenDT = Convert.ToString(dr["TenDT"]);
            }
            else
            {
                this.TenDT = "";
            }
            if (dr["BHTra"].GetType().Name != "DBNull" && dr["BHTra"] != null)
            {
                this.BHTra = Convert.ToDecimal(dr["BHTra"]);
            }
            else
            {
                this.BHTra = new Nullable<Decimal>();
            }
            if (dr["Sotien"].GetType().Name != "DBNull" && dr["Sotien"] != null)
            {
                this.Sotien = Convert.ToDecimal(dr["Sotien"]);
            }
            else
            {
                this.Sotien = new Nullable<Decimal>();
            }
            if (dr["SotienKTC"].GetType().Name != "DBNull" && dr["SotienKTC"] != null)
            {
                this.SotienKTC = Convert.ToDecimal(dr["SotienKTC"]);
            }
            else
            {
                this.SotienKTC = new Nullable<Decimal>();
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
                this.Huy = new Nullable<Boolean>();
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]);
            }
            else
            {
                this.NgaySD = new Nullable<DateTime>();
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
            if (dr["Diachi"].GetType().Name != "DBNull" && dr["Diachi"] != null)
            {
                this.Diachi = Convert.ToString(dr["Diachi"]);
            }
            else
            {
                this.Diachi = "";
            }
            if (dr["TenHangBH"].GetType().Name != "DBNull" && dr["TenHangBH"] != null)
            {
                this.TenHangBH = Convert.ToString(dr["TenHangBH"]);
            }
            else
            {
                this.TenHangBH = "";
            }
            if (dr["DienThoai"].GetType().Name != "DBNull" && dr["DienThoai"] != null)
            {
                this.DienThoai = Convert.ToString(dr["DienThoai"]);
            }
            else
            {
                this.DienThoai = "";
            }
            if (dr["Masothue"].GetType().Name != "DBNull" && dr["Masothue"] != null)
            {
                this.Masothue = Convert.ToString(dr["Masothue"]);
            }
            else
            {
                this.Masothue = "";
            }
            if (dr["TaiKhoan"].GetType().Name != "DBNull" && dr["TaiKhoan"] != null)
            {
                this.TaiKhoan = Convert.ToString(dr["TaiKhoan"]);
            }
            else
            {
                this.TaiKhoan = "";
            }
            if (dr["BVTra"].GetType().Name != "DBNull" && dr["BVTra"] != null)
            {
                this.BVTra = Convert.ToBoolean(dr["BVTra"]);
            }
            else
            {
                this.BVTra = new Nullable<Boolean>();
            }
            if (dr["KieuThe"].GetType().Name != "DBNull" && dr["KieuThe"] != null)
            {
                this.KieuThe = Convert.ToString(dr["KieuThe"]);
            }
            else
            {
                this.KieuThe = "";
            }
            if (dr["HesoDV"].GetType().Name != "DBNull" && dr["HesoDV"] != null)
            {
                this.HesoDV = Convert.ToDecimal(dr["HesoDV"]);
            }
            else
            {
                this.HesoDV = new Nullable<Decimal>();
            }
            if (dr["HesoPT"].GetType().Name != "DBNull" && dr["HesoPT"] != null)
            {
                this.HesoPT = Convert.ToDecimal(dr["HesoPT"]);
            }
            else
            {
                this.HesoPT = new Nullable<Decimal>();
            }
            if (dr["HesoGiuong"].GetType().Name != "DBNull" && dr["HesoGiuong"] != null)
            {
                this.HesoGiuong = Convert.ToDecimal(dr["HesoGiuong"]);
            }
            else
            {
                this.HesoGiuong = new Nullable<Decimal>();
            }
            this.Ordernumber = Ordernumber;
        }
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }
        public static DMDoiTuong_H Get(String MaDT)
        {
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDOITUONG_Get", MaDT))
            {
                while (dr.Read())
                {
                    return new DMDoiTuong_H(dr, 0);
                }
            }
            return new DMDoiTuong_H();
        }

        public String Insert()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "spDMDOITUONG_CREATE", TenDT, BHTra, Sotien, SotienKTC, HesoDV, HesoPT, HesoGiuong, MaMay, NguoiSD));
        }

        public String Edit()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "spDMDOITUONG_UPDATE", MaDT, TenDT, BHTra, Sotien, SotienKTC, HesoDV, HesoPT, HesoGiuong, MaMay, NguoiSD, KieuThe));
        }

    }

    [Serializable]
    public class DMDoiTuongList_H: List<DMDoiTuong_H>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMDoiTuongList_H GetAll()
        {
            DMDoiTuongList_H List = new DMDoiTuongList_H();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDOITUONG_GetAll"))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMDoiTuong_H(dr, Ordernumber));
                }
            }
            return List;
        }        
    }
}
