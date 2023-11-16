using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList.DanhMucPhuSan
{
    [Serializable]
    public class TBHTTonKhoKhoa
    {
        public Int32 Ordernumber { get; set; }
        public String MaKho { get; set; }
        public String MaKhoa { get; set; }
        public String TenKho { get; set; }
        public String TenKhoa { get; set; }
        public Decimal TBHTID { get; set; }
        public String TenTBHT { get; set; }
        public String SerialNo { get; set; }
        public String Model { get; set; }
        public String TenDVT { get; set; }
        public Decimal TonCK { get; set; }
        public Decimal TonCKDT { get; set; }

        public TBHTTonKhoKhoa()
        {
            MaKho = "";
            MaKhoa = "";
            TenKho = "";
            TenKhoa = "";
            TBHTID = 0;
            TenTBHT = "";
            SerialNo = "";
            Model = "";
            TenDVT = "";
            TonCK = 0;
            TonCKDT = 0;
            Ordernumber = 0;
        }

        public TBHTTonKhoKhoa(String MaKho, String MaKhoa, String TenKho, String TenKhoa, Decimal TBHTID, String TenTBHT, String SerialNo, String Model, String TenDVT, Decimal TonCK, Decimal TonCKDT, Int32 Ordernumber)
        {
            this.MaKho = MaKho;
            this.MaKhoa = MaKhoa;
            this.TenKho = TenKho;
            this.TenKhoa = TenKhoa;
            this.TBHTID = TBHTID;
            this.TenTBHT = TenTBHT;
            this.SerialNo = SerialNo;
            this.Model = Model;
            this.TenDVT = TenDVT;
            this.TonCK = TonCK;
            this.TonCKDT = TonCKDT;
            this.Ordernumber = Ordernumber;
        }
        public TBHTTonKhoKhoa(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaKho"].GetType().Name != "DBNull" && dr["MaKho"] != null)
            {
                this.MaKho = Convert.ToString(dr["MaKho"]);
            }
            else
            {
                this.MaKho = "";
            }
            if (dr["MaKhoa"].GetType().Name != "DBNull" && dr["MaKhoa"] != null)
            {
                this.MaKhoa = Convert.ToString(dr["MaKhoa"]);
            }
            else
            {
                this.MaKhoa = "";
            }
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
            }
            if (dr["TenKhoa"].GetType().Name != "DBNull" && dr["TenKhoa"] != null)
            {
                this.TenKhoa = Convert.ToString(dr["TenKhoa"]);
            }
            else
            {
                this.TenKhoa = "";
            }
            if (dr["TBHTID"].GetType().Name != "DBNull" && dr["TBHTID"] != null)
            {
                this.TBHTID = Convert.ToDecimal(dr["TBHTID"]);
            }
            else
            {
                this.TBHTID = 0;
            }
            if (dr["TenTBHT"].GetType().Name != "DBNull" && dr["TenTBHT"] != null)
            {
                this.TenTBHT = Convert.ToString(dr["TenTBHT"]);
            }
            else
            {
                this.TenTBHT = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            {
                this.SerialNo = Convert.ToString(dr["SerialNo"]);
            }
            else
            {
                this.SerialNo = "";
            }
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            {
                this.Model = Convert.ToString(dr["Model"]);
            }
            else
            {
                this.Model = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
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
            this.Ordernumber = Ordernumber;
        }
    }


    [Serializable]
    public class TBHTTonKhoKhoas : List<TBHTTonKhoKhoa>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBHTTonKhoKhoas GetAll(String MaKho, String MaKhoa, DateTime Thang, Byte Loai, String HTenBang = "", Decimal? HMaPhieu = new Decimal?())
        {
            TBHTTonKhoKhoas List = new TBHTTonKhoKhoas();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBHTTonKhoKhoa", MaKho, MaKhoa, Thang, Loai, HTenBang, HMaPhieu))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBHTTonKhoKhoa(dr, Ordernumber));
                }
            }
            return List;
        }
    }


    [Serializable]
    public class TBHeThongCategory
    {
        public Int32 Ordernumber { get; set; }
        public Decimal TBYTId { get; set; }
        public String TBYTMaId
        {
            get
            {
                return (TBYTId < 0 ? "HT" : "TB") + Math.Abs(TBYTId).ToString();
            }
        }
        public String TenTBYT { get; set; }
        public String MaTBYT { get; set; }
        public String NamSX { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
        public Decimal KhoiLuong { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal NguyenTe { get; set; }
        public String DacTinhKT { get; set; }
        public String TenDVT { get; set; }
        public String TenNSX { get; set; }
        public String TenQuocGia { get; set; }
        public Decimal TonDK { get; set; }
        public Decimal SLNhap { get; set; }
        public Decimal SLXuat { get; set; }
        public Decimal SLNhapDT { get; set; }
        public Decimal SLXuatDT { get; set; }
        public Decimal TonCK { get; set; }
        public Decimal TonCKDT { get; set; }
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public TBHeThongCategory()
        {
            TBYTId = 0;
            TenTBYT = "";
            MaTBYT = "";           
            NamSX = "";
            Model = "";
            SerialNo = "";
            KhoiLuong = 0;           
            DonGia = 0;
            NguyenTe = 0;
            DacTinhKT = "";
            TenDVT = "";
            TenNSX = "";
            TenQuocGia = "";
            TonDK = 0;
            SLNhap = 0;
            SLXuat = 0;
            SLNhapDT = 0;
            SLXuatDT = 0;
            TonCK = 0;
            TonCKDT = 0;
            Ordernumber = 0;
        }

        public TBHeThongCategory(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["TBYTId"].GetType().Name != "DBNull" && dr["TBYTId"] != null)
            {
                this.TBYTId = Convert.ToDecimal(dr["TBYTId"]);
            }
            else
            {
                this.TBYTId = 0;
            }
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
            {
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            }
            else
            {
                this.TenTBYT = "";
            }
            if (dr["MaTBYT"].GetType().Name != "DBNull" && dr["MaTBYT"] != null)
            {
                this.MaTBYT = Convert.ToString(dr["MaTBYT"]);
            }
            else
            {
                this.MaTBYT = "";
            }
            
           
            if (dr["NamSX"].GetType().Name != "DBNull" && dr["NamSX"] != null)
            {
                this.NamSX = Convert.ToDateTime(dr["NamSX"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NamSX = "";
            }
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            {
                this.Model = Convert.ToString(dr["Model"]);
            }
            else
            {
                this.Model = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            {
                this.SerialNo = Convert.ToString(dr["SerialNo"]);
            }
            else
            {
                this.SerialNo = "";
            }
            if (dr["KhoiLuong"].GetType().Name != "DBNull" && dr["KhoiLuong"] != null)
            {
                this.KhoiLuong = Convert.ToDecimal(dr["KhoiLuong"]);
            }
            else
            {
                this.KhoiLuong = 0;
            }           
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
            }
            if (dr["NguyenTe"].GetType().Name != "DBNull" && dr["NguyenTe"] != null)
            {
                this.NguyenTe = Convert.ToDecimal(dr["NguyenTe"]);
            }
            else
            {
                this.NguyenTe = 0;
            }           
            if (dr["DacTinhKT"].GetType().Name != "DBNull" && dr["DacTinhKT"] != null)
            {
                this.DacTinhKT = Convert.ToString(dr["DacTinhKT"]);
            }
            else
            {
                this.DacTinhKT = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
            }
            if (dr["TenNSX"].GetType().Name != "DBNull" && dr["TenNSX"] != null)
            {
                this.TenNSX = Convert.ToString(dr["TenNSX"]);
            }
            else
            {
                this.TenNSX = "";
            }
            if (dr["TenQuocGia"].GetType().Name != "DBNull" && dr["TenQuocGia"] != null)
            {
                this.TenQuocGia = Convert.ToString(dr["TenQuocGia"]);
            }
            else
            {
                this.TenQuocGia = "";
            }            
            if (dr["TonDK"].GetType().Name != "DBNull" && dr["TonDK"] != null)
            {
                this.TonDK = Convert.ToDecimal(dr["TonDK"]);
            }
            else
            {
                this.TonDK = 0;
            }
            if (dr["SLNhap"].GetType().Name != "DBNull" && dr["SLNhap"] != null)
            {
                this.SLNhap = Convert.ToDecimal(dr["SLNhap"]);
            }
            else
            {
                this.SLNhap = 0;
            }
            if (dr["SLXuat"].GetType().Name != "DBNull" && dr["SLXuat"] != null)
            {
                this.SLXuat = Convert.ToDecimal(dr["SLXuat"]);
            }
            else
            {
                this.SLXuat = 0;
            }
            if (dr["SLNhapDT"].GetType().Name != "DBNull" && dr["SLNhapDT"] != null)
            {
                this.SLNhapDT = Convert.ToDecimal(dr["SLNhapDT"]);
            }
            else
            {
                this.SLNhapDT = 0;
            }
            if (dr["SLXuatDT"].GetType().Name != "DBNull" && dr["SLXuatDT"] != null)
            {
                this.SLXuatDT = Convert.ToDecimal(dr["SLXuatDT"]);
            }
            else
            {
                this.SLXuatDT = 0;
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
            this.Ordernumber = Ordernumber;
        }
    }

    [Serializable]
    public class TBHeThongCategorys : List<TBHeThongCategory>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBHeThongCategorys PhieuNhapGetAll(Byte Loai, String TenTBHeThong, Int32 PageFirst, Int32 CountLine)
        {
            TBHeThongCategorys List = new TBHeThongCategorys();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuNhap_GetHTTB", Loai, TenTBHeThong, PageFirst, CountLine))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBHeThongCategory(dr, Ordernumber));
                }
            }
            return List;
        }

        public static TBHeThongCategorys PhieuKiemKeGetAll(Byte Loai, String TenTBHeThong, Int32 PageFirst, Int32 CountLine)
        {
            TBHeThongCategorys List = new TBHeThongCategorys();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBKiemKe_GetHTTB", Loai, TenTBHeThong, PageFirst, CountLine))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBHeThongCategory(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
