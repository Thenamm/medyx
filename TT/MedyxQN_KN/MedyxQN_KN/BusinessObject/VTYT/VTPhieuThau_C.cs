using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuThau_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal VTPhieuThau_CId { get; set; }
        public Decimal VTPhieuThauId { get; set; }
        public String MaVT { get; set; }
        public Decimal SoLuong { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal ThanhTien { get; set; }
        public Boolean Huy { get; set; }
        public String GhiChu { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public String MaBH { get; set; }
        public String SoVisa { get; set; }
        public String TenVT { get; set; }
        public String TenNguoiSD { get; set; }

        public String TenDVT { get; set; }
        

        public VTPhieuThau_C()
        {
            VTPhieuThau_CId = 0;
            VTPhieuThauId = 0;
            MaVT = "";
            SoLuong = 0;
            DonGia = 0;
            ThanhTien = 0;
            Huy = false;
            GhiChu = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            MaBH = "";
            SoVisa = "";
            TenVT = "";
            TenNguoiSD = "";
            TenDVT = "";
            Ordernumber = 0;
        }

        public VTPhieuThau_C(Decimal VTPhieuThau_CId, Decimal VTPhieuThauId, String MaVT, Decimal SoLuong, Decimal DonGia, Decimal ThanhTien, Boolean Huy, String GhiChu, String NgaySD, String NguoiSD, String MaMay, String MaBH, String SoVisa, String TenVT, String TenNguoiSD, String TenDVT, Int32 Ordernumber)
        {
            this.VTPhieuThau_CId = VTPhieuThau_CId;
            this.VTPhieuThauId = VTPhieuThauId;
            this.MaVT = MaVT;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            this.Huy = Huy;
            this.GhiChu = GhiChu;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.MaBH = MaBH;
            this.SoVisa = SoVisa;
            this.TenVT = TenVT;
            this.TenNguoiSD = TenNguoiSD;
            this.TenDVT = TenDVT;
            this.Ordernumber = Ordernumber;
        }
        public VTPhieuThau_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["VTPhieuThau_CId"].GetType().Name != "DBNull" && dr["VTPhieuThau_CId"] != null)
            {
                this.VTPhieuThau_CId = Convert.ToDecimal(dr["VTPhieuThau_CId"]);
            }
            else
            {
                this.VTPhieuThau_CId = 0;
            }
            if (dr["VTPhieuThauId"].GetType().Name != "DBNull" && dr["VTPhieuThauId"] != null)
            {
                this.VTPhieuThauId = Convert.ToDecimal(dr["VTPhieuThauId"]);
            }
            else
            {
                this.VTPhieuThauId = 0;
            }
            if (dr["MaVT"].GetType().Name != "DBNull" && dr["MaVT"] != null)
            {
                this.MaVT = Convert.ToString(dr["MaVT"]);
            }
            else
            {
                this.MaVT = "";
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
            if (dr["MaBH"].GetType().Name != "DBNull" && dr["MaBH"] != null)
            {
                this.MaBH = Convert.ToString(dr["MaBH"]);
            }
            else
            {
                this.MaBH = "";
            }
            if (dr["SoVisa"].GetType().Name != "DBNull" && dr["SoVisa"] != null)
            {
                this.SoVisa = Convert.ToString(dr["SoVisa"]);
            }
            else
            {
                this.SoVisa = "";
            }
            if (dr["TenVT"].GetType().Name != "DBNull" && dr["TenVT"] != null)
            {
                this.TenVT = Convert.ToString(dr["TenVT"]);
            }
            else
            {
                this.TenVT = "";
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
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spVTPhieuThau_C_Insert", VTPhieuThauId, MaVT, SoLuong, DonGia, GhiChu, MaMay, MaBH, SoVisa).ToString());
        }

        public Decimal Update()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spVTPhieuThau_C_Update", VTPhieuThau_CId, MaVT, SoLuong, DonGia, Huy, GhiChu, NguoiSD, MaMay, MaBH, SoVisa).ToString());
        }

        public Decimal Delete()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spVTPhieuThau_C_Delete", VTPhieuThau_CId, NguoiSD, MaMay).ToString());
        }

        public static VTPhieuThau_C GetByMa(Decimal VTPhieuThau_CId)
        {
            VTPhieuThau_C obj = new VTPhieuThau_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spVTPhieuThau_C_Get", VTPhieuThau_CId))
            {
                while (dr.Read())
                {
                    obj = new VTPhieuThau_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

    }

        [Serializable()]
    public class VTPhieuThau_Cs : List<VTPhieuThau_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public static VTPhieuThau_Cs GetALL(Decimal VTPhieuThauId)
        {
            VTPhieuThau_Cs obj = new VTPhieuThau_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spVTPhieuThau_C_GetAll", VTPhieuThauId))
            {
                int Ordernumber = 1;
                while (dr.Read())
                {
                    Ordernumber++;
                    obj.Add(new VTPhieuThau_C(dr, Ordernumber));
                }
            }
            return obj;
        }

        public static DataSet VTPhieuThau_Report(Decimal VTPhieuThauId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spVTPhieuThau_Report", VTPhieuThauId);
        }
    }
}
