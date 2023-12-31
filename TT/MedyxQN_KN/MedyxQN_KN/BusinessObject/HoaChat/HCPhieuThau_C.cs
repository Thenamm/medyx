using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCPhieuThau_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal HCPhieuThau_CId { get; set; }
        public Decimal HCPhieuThauId { get; set; }
        public String MaHC { get; set; }
        public Decimal SoLuong { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal ThanhTien { get; set; }
        public Boolean Huy { get; set; }
        public String GhiChu { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public String TenHC { get; set; }
        public String TenNguoiSD { get; set; }

        public String TenDVT { get; set; }
        

        public HCPhieuThau_C()
        {
            HCPhieuThau_CId = 0;
            HCPhieuThauId = 0;
            MaHC = "";
            SoLuong = 0;
            DonGia = 0;
            ThanhTien = 0;
            Huy = false;
            GhiChu = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            TenHC = "";
            TenNguoiSD = "";
            TenDVT = "";
            Ordernumber = 0;
        }

        public HCPhieuThau_C(Decimal HCPhieuThau_CId, Decimal HCPhieuThauId, String MaHC, Decimal SoLuong, Decimal DonGia, Decimal ThanhTien, Boolean Huy, String GhiChu, String NgaySD, String NguoiSD, String MaMay, String TenHC, String TenNguoiSD, String TenDVT, Int32 Ordernumber)
        {
            this.HCPhieuThau_CId = HCPhieuThau_CId;
            this.HCPhieuThauId = HCPhieuThauId;
            this.MaHC = MaHC;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            this.Huy = Huy;
            this.GhiChu = GhiChu;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.TenHC = TenHC;
            this.TenNguoiSD = TenNguoiSD;
            this.TenDVT = TenDVT;
            this.Ordernumber = Ordernumber;
        }
        public HCPhieuThau_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["HCPhieuThau_CId"].GetType().Name != "DBNull" && dr["HCPhieuThau_CId"] != null)
            {
                this.HCPhieuThau_CId = Convert.ToDecimal(dr["HCPhieuThau_CId"]);
            }
            else
            {
                this.HCPhieuThau_CId = 0;
            }
            if (dr["HCPhieuThauId"].GetType().Name != "DBNull" && dr["HCPhieuThauId"] != null)
            {
                this.HCPhieuThauId = Convert.ToDecimal(dr["HCPhieuThauId"]);
            }
            else
            {
                this.HCPhieuThauId = 0;
            }
            if (dr["MaHC"].GetType().Name != "DBNull" && dr["MaHC"] != null)
            {
                this.MaHC = Convert.ToString(dr["MaHC"]);
            }
            else
            {
                this.MaHC = "";
            }
            if (dr["SoLuong"].GetType().Name != "DBNull" && dr["SoLuong"] != null)
            {
                this.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
            }
            else
            {
                this.SoLuong = 0;
            }
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
            }
            if (dr["ThanhTien"].GetType().Name != "DBNull" && dr["ThanhTien"] != null)
            {
                this.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
            }
            else
            {
                this.ThanhTien = 0;
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
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
            if (dr["TenHC"].GetType().Name != "DBNull" && dr["TenHC"] != null)
            {
                this.TenHC = Convert.ToString(dr["TenHC"]);
            }
            else
            {
                this.TenHC = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
            }
            this.Ordernumber = Ordernumber; 
        }

        public Decimal Insert()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spHCPhieuThau_C_Insert", HCPhieuThauId, MaHC, SoLuong, DonGia, GhiChu, MaMay).ToString());
        }

        public Decimal Update()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spHCPhieuThau_C_Update", HCPhieuThau_CId, MaHC, SoLuong, DonGia, Huy, GhiChu, NguoiSD, MaMay).ToString());
        }

        public Decimal Delete()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spHCPhieuThau_C_Delete", HCPhieuThau_CId, NguoiSD, MaMay).ToString());
        }

        public static HCPhieuThau_C GetByMa(Decimal HCPhieuThau_CId)
        {
            HCPhieuThau_C obj = new HCPhieuThau_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHCPhieuThau_C_Get", HCPhieuThau_CId))
            {
                while (dr.Read())
                {
                    obj = new HCPhieuThau_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

    }

        [Serializable()]
    public class HCPhieuThau_Cs : List<HCPhieuThau_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public static HCPhieuThau_Cs GetALL(Decimal HCPhieuThauId)
        {
            HCPhieuThau_Cs obj = new HCPhieuThau_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHCPhieuThau_C_GetAll", HCPhieuThauId))
            {
                int Ordernumber = 1;
                while (dr.Read())
                {
                    Ordernumber++;
                    obj.Add(new HCPhieuThau_C(dr, Ordernumber));
                }
            }
            return obj;
        }

        public static DataSet HCPhieuThau_Report(Decimal HCPhieuThauId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spHCPhieuThau_Report", HCPhieuThauId);
        }
    }
}
