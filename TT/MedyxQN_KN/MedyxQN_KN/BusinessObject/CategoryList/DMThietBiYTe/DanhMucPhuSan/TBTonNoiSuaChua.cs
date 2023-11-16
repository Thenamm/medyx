using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList.DanhMucPhuSan
{
    [Serializable]
    public class TBTonNoiSuaChua
    {
        public Int32 Ordernumber { get; set; }
        public String Thang { get; set; }
        public String MaNoiXuat { get; set; }
        public Decimal TBYTId { get; set; }
        public String TBYTMaId
        {
            get
            {
                return (TBYTId < 0 ? "HT" : "TB") + Math.Abs(TBYTId).ToString();
            }
        }
        public Int32 TonDK { get; set; }
        public Decimal SLNhap { get; set; }
        public Decimal SLXuat { get; set; }
        public Int32 SLXuatDT { get; set; }
        public Int32 SLThanhLy { get; set; }
        public Int32 SLHuy { get; set; }
        public Decimal TonCK { get; set; }
        public Decimal TonCKDT { get; set; }
        public String TenTBYT { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
        public String TenDVT { get; set; }
        public String TenNoiSua { get; set; }
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
        public TBTonNoiSuaChua()
        {
            Thang = "";
            MaNoiXuat = "";
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
            TenNoiSua = "";
            TenNSX = "";
            TenQuocGia = "";
            BaoTri = "";
            SuaChua = "";
            Ordernumber = 0;
        }

        public TBTonNoiSuaChua(String Thang, String MaNoiXuat, Decimal TBYTId, Int32 TonDK, Decimal SLNhap, Decimal SLXuat, Int32 SLXuatDT, Int32 SLThanhLy, Int32 SLHuy, Decimal TonCK, Decimal TonCKDT, String TenTBYT, String Model, String SerialNo, String TenDVT, String TenNoiSua, String TenNSX, String TenQuocGia, String BaoTri, String SuaChua, Int32 Ordernumber)
        {
            this.Thang = Thang;
            this.MaNoiXuat = MaNoiXuat;
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
            this.TenNoiSua = TenNoiSua;
            this.TenNSX = TenNSX;
            this.TenQuocGia = TenQuocGia;
            this.BaoTri = BaoTri;
            this.SuaChua = SuaChua;
            this.Ordernumber = Ordernumber;
        }
        public TBTonNoiSuaChua(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["Thang"].GetType().Name != "DBNull" && dr["Thang"] != null)
            {
                this.Thang = Convert.ToDateTime(dr["Thang"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.Thang = "";
            }
            if (dr["MaNoiXuat"].GetType().Name != "DBNull" && dr["MaNoiXuat"] != null)
            {
                this.MaNoiXuat = Convert.ToString(dr["MaNoiXuat"]);
            }
            else
            {
                this.MaNoiXuat = "";
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
                this.TonDK = Convert.ToInt32(dr["TonDK"]);
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
                this.SLXuatDT = Convert.ToInt32(dr["SLXuatDT"]);
            }
            else
            {
                this.SLXuatDT = 0;
            }
            if (dr["SLThanhLy"].GetType().Name != "DBNull" && dr["SLThanhLy"] != null)
            {
                this.SLThanhLy = Convert.ToInt32(dr["SLThanhLy"]);
            }
            else
            {
                this.SLThanhLy = 0;
            }
            if (dr["SLHuy"].GetType().Name != "DBNull" && dr["SLHuy"] != null)
            {
                this.SLHuy = Convert.ToInt32(dr["SLHuy"]);
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
            if (dr["TenNoiSua"].GetType().Name != "DBNull" && dr["TenNoiSua"] != null)
            {
                this.TenNoiSua = Convert.ToString(dr["TenNoiSua"]);
            }
            else
            {
                this.TenNoiSua = "";
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



        public static TBTonNoiSuaChua GetByMa(String MaDVSC, DateTime Thang, Decimal TBYTId)
        {
            TBTonNoiSuaChua obj = new TBTonNoiSuaChua();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBTonDVSC_Get", MaDVSC, Thang, TBYTId))
            {
                while (dr.Read())
                {
                    obj = new TBTonNoiSuaChua(dr, 1);
                    break;
                }
            }
            return obj;
        }
    }

    [Serializable]
    public class TBTonNoiSuaChuas : List<TBTonNoiSuaChua>
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
        public static TBTonNoiSuaChuas GetAll(String MaDVSC, DateTime Thang)
        {
            TBTonNoiSuaChuas List = new TBTonNoiSuaChuas();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBTonDVSC_GetAll", MaDVSC, Thang))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBTonNoiSuaChua(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
