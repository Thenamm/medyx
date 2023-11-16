using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList.DanhMucPhuSan
{
    [Serializable]
    public class TBTonKho
    {
        public Int32 Ordernumber { get; set; }
        public String Thang { get; set; }
        public String MaKho { get; set; }
        public Decimal TBYTId { get; set; }
        public String TBYTMaId
        {
            get
            {
                return (TBYTId < 0 ? "HT" : "TB") + Math.Abs(TBYTId).ToString();
            }
        }
        public Decimal TonDK { get; set; }
        public Decimal SLNhap { get; set; }
        public Decimal SLXuat { get; set; }
        public Decimal SLXuatDT { get; set; }
        public Decimal SLThanhLy { get; set; }
        public Decimal SLHuy { get; set; }
        public Decimal TonCK { get; set; }
        public Decimal TonCKDT { get; set; }
        public String TenTBYT { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
        public String TenDVT { get; set; }
        public String TenKho { get; set; }
        public String TenNSX { get; set; }
        public String TenQuocGia { get; set; }
        public String BaoTri { get; set; }
        public String SuaChua { get; set; }
        public String TenTBYTAll
        {
            get
            {
                return TenTBYT + (SerialNo != "" ? "-" + SerialNo : SerialNo) + (Model != "" ? "-" + Model : Model);
            }
        }

        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public TBTonKho()
        {
            Thang = "";
            MaKho = "";
            TBYTId = 0;
            TonDK = 0;
            SLNhap = 0;
            SLXuat = 0;
            SLXuatDT = 0;
            SLThanhLy = 0;
            SLHuy = 0;
            TonCK = 0;
            TonCKDT = 0;
            TenTBYT = "";
            Model = "";
            SerialNo = "";
            TenDVT = "";
            TenKho = "";
            TenNSX = "";
            TenQuocGia = "";
            BaoTri = "";
            SuaChua = "";
            Ordernumber = 0;
        }

        public TBTonKho(String Thang, String MaKho, Decimal TBYTId, Decimal TonDK, Decimal SLNhap, Decimal SLXuat, Decimal SLXuatDT, Decimal SLThanhLy, Decimal SLHuy, Decimal TonCK, Decimal TonCKDT, String TenTBYT, String Model, String SerialNo, String TenDVT, String TenKho, String TenNSX, String TenQuocGia, String BaoTri, String SuaChua, Int32 Ordernumber)
        {
            this.Thang = Thang;
            this.MaKho = MaKho;
            this.TBYTId = TBYTId;
            this.TonDK = TonDK;
            this.SLNhap = SLNhap;
            this.SLXuat = SLXuat;
            this.SLXuatDT = SLXuatDT;
            this.SLThanhLy = SLThanhLy;
            this.SLHuy = SLHuy;
            this.TonCK = TonCK;
            this.TonCKDT = TonCKDT;
            this.TenTBYT = TenTBYT;
            this.Model = Model;
            this.SerialNo = SerialNo;
            this.TenDVT = TenDVT;
            this.TenKho = TenKho;
            this.TenNSX = TenNSX;
            this.TenQuocGia = TenQuocGia;
            this.BaoTri = BaoTri;
            this.SuaChua = SuaChua;
            this.Ordernumber = Ordernumber;
        }
        public TBTonKho(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["Thang"].GetType().Name != "DBNull" && dr["Thang"] != null)
            {
                this.Thang = Convert.ToDateTime(dr["Thang"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.Thang = "";
            }
            if (dr["MaKho"].GetType().Name != "DBNull" && dr["MaKho"] != null)
            {
                this.MaKho = Convert.ToString(dr["MaKho"]);
            }
            else
            {
                this.MaKho = "";
            }
            if (dr["TBYTId"].GetType().Name != "DBNull" && dr["TBYTId"] != null)
            {
                this.TBYTId = Convert.ToDecimal(dr["TBYTId"]);
            }
            else
            {
                this.TBYTId = 0;
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
            if (dr["SLXuatDT"].GetType().Name != "DBNull" && dr["SLXuatDT"] != null)
            {
                this.SLXuatDT = Convert.ToDecimal(dr["SLXuatDT"]);
            }
            else
            {
                this.SLXuatDT = 0;
            }
            if (dr["SLThanhLy"].GetType().Name != "DBNull" && dr["SLThanhLy"] != null)
            {
                this.SLThanhLy = Convert.ToDecimal(dr["SLThanhLy"]);
            }
            else
            {
                this.SLThanhLy = 0;
            }
            if (dr["SLHuy"].GetType().Name != "DBNull" && dr["SLHuy"] != null)
            {
                this.SLHuy = Convert.ToDecimal(dr["SLHuy"]);
            }
            else
            {
                this.SLHuy = 0;
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
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
            {
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            }
            else
            {
                this.TenTBYT = "";
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
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
            }
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
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
            if (dr["BaoTri"].GetType().Name != "DBNull" && dr["BaoTri"] != null)
            {
                this.BaoTri = Convert.ToString(dr["BaoTri"]);
            }
            else
            {
                this.BaoTri = "";
            }
            if (dr["SuaChua"].GetType().Name != "DBNull" && dr["SuaChua"] != null)
            {
                this.SuaChua = Convert.ToString(dr["SuaChua"]);
            }
            else
            {
                this.SuaChua = "";
            }
            this.Ordernumber = Ordernumber;
        }

        public static TBTonKho GetBDSCByMa(String MaKho, DateTime Thang, Decimal TBYTId)
        {
            TBTonKho obj = new TBTonKho();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBTonKhoBDSC_Get", MaKho, Thang, TBYTId))
            {
                while (dr.Read())
                {
                    obj = new TBTonKho(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public static TBTonKho GetByMa(String MaKho, DateTime Thang, Decimal TBYTId)
        {
            TBTonKho obj = new TBTonKho();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBTonKho_Get", MaKho, Thang, TBYTId))
            {
                while (dr.Read())
                {
                    obj = new TBTonKho(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public void Update(DateTime Thang, String MaKho, Decimal TBYTId, Decimal SLNhap, Decimal SLXuat, Decimal SLXuatDT, Decimal SLThanhLy, Decimal SLHuy)
        {
            SqlHelper.ExecuteNonQuery(strConnect, "spTBTonKho_Update", Thang, MaKho, TBYTId, SLNhap, SLXuat, SLXuatDT, SLThanhLy, SLHuy);
        }

        public static void TinhTonKho(String MaKho, DateTime Thang)
        {
            SqlHelper.ExecuteNonQuery(strConnect, "spTBTinhTonKho", MaKho, Thang);
        }

    }

    [Serializable]
    public class TBTonKhos : List<TBTonKho>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        private Int32 _countRowTotal = 0;
        public Int32 CountRowTotal
        {
            get
            {
                return _countRowTotal;
            }
        }
        public static TBTonKhos GetAll(String MaKho, DateTime Thang)
        {
            TBTonKhos List = new TBTonKhos();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBTonKho_GetAll", MaKho, Thang))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBTonKho(dr, Ordernumber));
                }
            }
            return List;
        }

        public static TBTonKhos GetBDSCAll(Byte Loai, String MaNoiXuat, String MaNoiNhan, DateTime Thang)
        {
            TBTonKhos List = new TBTonKhos();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBTonKhoBDSC_GetAll", Loai, MaNoiXuat, MaNoiNhan, Thang))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBTonKho(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
