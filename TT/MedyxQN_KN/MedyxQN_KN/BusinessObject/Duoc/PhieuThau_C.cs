using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuThau_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal PhieuThau_CId { get; set; }
        public Decimal PhieuThauId { get; set; }
        public String MaThuoc { get; set; }
        public Decimal SoLuong { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal ThanhTien { get; set; }
        public Boolean Huy { get; set; }
        public String GhiChu { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public String TenTM { get; set; }
        public String TenNguoiSD { get; set; }

        public String TenDVT { get; set; }
        

        public PhieuThau_C()
        {
            PhieuThau_CId = 0;
            PhieuThauId = 0;
            MaThuoc = "";
            SoLuong = 0;
            DonGia = 0;
            ThanhTien = 0;
            Huy = false;
            GhiChu = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            TenTM = "";
            TenNguoiSD = "";
            TenDVT = "";
            Ordernumber = 0;
        }

        public PhieuThau_C(Decimal PhieuThau_CId, Decimal PhieuThauId, String MaThuoc, Decimal SoLuong, Decimal DonGia, Decimal ThanhTien, Boolean Huy, String GhiChu, String NgaySD, String NguoiSD, String MaMay, String TenTM, String TenNguoiSD, String TenDVT, Int32 Ordernumber)
        {
            this.PhieuThau_CId = PhieuThau_CId;
            this.PhieuThauId = PhieuThauId;
            this.MaThuoc = MaThuoc;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            this.Huy = Huy;
            this.GhiChu = GhiChu;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.TenTM = TenTM;
            this.TenNguoiSD = TenNguoiSD;
            this.TenDVT = TenDVT;
            this.Ordernumber = Ordernumber;
        }
        public PhieuThau_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["PhieuThau_CId"].GetType().Name != "DBNull" && dr["PhieuThau_CId"] != null)
            {
                this.PhieuThau_CId = Convert.ToDecimal(dr["PhieuThau_CId"]);
            }
            else
            {
                this.PhieuThau_CId = 0;
            }
            if (dr["PhieuThauId"].GetType().Name != "DBNull" && dr["PhieuThauId"] != null)
            {
                this.PhieuThauId = Convert.ToDecimal(dr["PhieuThauId"]);
            }
            else
            {
                this.PhieuThauId = 0;
            }
            if (dr["MaThuoc"].GetType().Name != "DBNull" && dr["MaThuoc"] != null)
            {
                this.MaThuoc = Convert.ToString(dr["MaThuoc"]);
            }
            else
            {
                this.MaThuoc = "";
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
            if (dr["TenTM"].GetType().Name != "DBNull" && dr["TenTM"] != null)
            {
                this.TenTM = Convert.ToString(dr["TenTM"]);
            }
            else
            {
                this.TenTM = "";
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
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spPhieuThau_C_Insert", PhieuThauId, MaThuoc, SoLuong, DonGia, GhiChu, MaMay).ToString());
        }

        public Decimal Update()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spPhieuThau_C_Update", PhieuThau_CId, MaThuoc, SoLuong, DonGia, Huy, GhiChu, NguoiSD, MaMay).ToString());
        }

        public Decimal Delete()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spPhieuThau_C_Delete", PhieuThau_CId, NguoiSD, MaMay).ToString());
        }

        public static PhieuThau_C GetByMa(Decimal PhieuThau_CId)
        {
            PhieuThau_C obj = new PhieuThau_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spPhieuThau_C_Get", PhieuThau_CId))
            {
                while (dr.Read())
                {
                    obj = new PhieuThau_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

    }

        [Serializable()]
    public class PhieuThau_Cs : List<PhieuThau_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public static PhieuThau_Cs GetALL(Decimal PhieuThauId)
        {
            PhieuThau_Cs obj = new PhieuThau_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spPhieuThau_C_GetAll", PhieuThauId))
            {
                int Ordernumber = 1;
                while (dr.Read())
                {
                    Ordernumber++;
                    obj.Add(new PhieuThau_C(dr, Ordernumber));
                }
            }
            return obj;
        }

        public static DataSet PhieuThau_Report(Decimal PhieuThauId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spPhieuThau_Report", PhieuThauId);
        }
    }
}
