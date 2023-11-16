using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
    [Serializable()]
    public class TBPhieuBaoTri
    {
        public Int32 Ordernumber { get; set; }
        public Decimal MaPhieuBT { get; set; }
        public String NgayLapTT { get; set; }
        public String MaNVYC { get; set; }
        public String MaDVYC { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String Ngayhuy { get; set; }
        public String Nguoihuy { get; set; }
        public String TenNVYC { get; set; }
        public String TenDVYC { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }

        public TBPhieuBaoTri()
        {
            MaPhieuBT = 0;
            NgayLapTT = "";
            MaNVYC = "";
            MaDVYC = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            Ngayhuy = "";
            Nguoihuy = "";
            TenNVYC = "";
            TenDVYC = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            Ordernumber = 0;
        }
        public TBPhieuBaoTri(Decimal MaPhieuBT, String NgayLapTT, String MaNVYC, String MaDVYC, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String Ngayhuy, String Nguoihuy, String TenNVYC, String TenDVYC, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 Ordernumber)
        {
            this.MaPhieuBT = MaPhieuBT;
            this.NgayLapTT = NgayLapTT;
            this.MaNVYC = MaNVYC;
            this.MaDVYC = MaDVYC;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.Ngayhuy = Ngayhuy;
            this.Nguoihuy = Nguoihuy;
            this.TenNVYC = TenNVYC;
            this.TenDVYC = TenDVYC;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.Ordernumber = Ordernumber;
        }
        public TBPhieuBaoTri(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPhieuBT"].GetType().Name != "DBNull" && dr["MaPhieuBT"] != null)
            { this.MaPhieuBT = Convert.ToDecimal(dr["MaPhieuBT"]); }
            else
            {
                MaPhieuBT = 0;
            }
            if (dr["NgayLapTT"].GetType().Name != "DBNull" && dr["NgayLapTT"] != null)
            {
                this.NgayLapTT = Convert.ToDateTime(dr["NgayLapTT"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayLapTT = "";
            }
            if (dr["MaNVYC"].GetType().Name != "DBNull" && dr["MaNVYC"] != null)
            { this.MaNVYC = Convert.ToString(dr["MaNVYC"]); }
            else
            {
                MaNVYC = "";
            }
            if (dr["MaDVYC"].GetType().Name != "DBNull" && dr["MaDVYC"] != null)
            { this.MaDVYC = Convert.ToString(dr["MaDVYC"]); }
            else
            {
                MaDVYC = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayLap = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            { this.NguoiLap = Convert.ToString(dr["NguoiLap"]); }
            else
            {
                NguoiLap = "";
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            { this.NguoiSD = Convert.ToString(dr["NguoiSD"]); }
            else
            {
                NguoiSD = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            { this.Huy = Convert.ToBoolean(dr["Huy"]); }
            else
            {
                Huy = false;
            }
            if (dr["Ngayhuy"].GetType().Name != "DBNull" && dr["Ngayhuy"] != null)
            {
                this.Ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngayhuy = "";
            }
            if (dr["Nguoihuy"].GetType().Name != "DBNull" && dr["Nguoihuy"] != null)
            { this.Nguoihuy = Convert.ToString(dr["Nguoihuy"]); }
            else
            {
                Nguoihuy = "";
            }
            if (dr["TenNVYC"].GetType().Name != "DBNull" && dr["TenNVYC"] != null)
            { this.TenNVYC = Convert.ToString(dr["TenNVYC"]); }
            else
            {
                TenNVYC = "";
            }
            if (dr["TenDVYC"].GetType().Name != "DBNull" && dr["TenDVYC"] != null)
            { this.TenDVYC = Convert.ToString(dr["TenDVYC"]); }
            else
            {
                TenDVYC = "";
            }
            if (dr["TenNguoiLap"].GetType().Name != "DBNull" && dr["TenNguoiLap"] != null)
            { this.TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]); }
            else
            {
                TenNguoiLap = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            { this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]); }
            else
            {
                TenNguoiSD = "";
            }
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            { this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]); }
            else
            {
                TenNguoiHuy = "";
            }
            this.Ordernumber = Ordernumber;
        }

        #region GetDaTa
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static TBPhieuBaoTri GetByMaPhieu(Decimal MaPhieuBT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPhieuBaoTri_Get", MaPhieuBT)))
            {
                while (dr.Read())
                {
                    return new TBPhieuBaoTri(dr, 1);
                }
            }
            return null;
        }

        public static String Insert(DateTime NgayLapTT, String MaNVYC, String MaDVYC, String NguoiLap)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_INSERT", NgayLapTT, MaNVYC, MaDVYC, NguoiLap));
        }

        public static int Update(Decimal MaPhieuBT, DateTime NgayLapTT, String MaNVYC, String MaDVYC, String NguoiSD, Nullable<Boolean> Huy)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_UPDATE", MaPhieuBT, NgayLapTT, MaNVYC, MaDVYC, NguoiSD, Huy));
        }

        public static int Delete(Decimal MaPhieuBT, String @Nguoihuy)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_Delete", MaPhieuBT, @Nguoihuy));
        }

        public static DataSet CRBienBanYeuCauBaoTri_Get(Decimal MaPhieuBT, Boolean qAdmin)
        {
            DataSet ds = new DataSet();
            string[] s = { "PhieuYeuCau", "DanhSachTBYeuCau" };
            SqlHelper.FillDataset(ConnectString, "dbo.CRBienBanYeuCauBaoTri_Get", ds, s, MaPhieuBT, qAdmin);
            //ds.WriteXmlSchema("E:\\PhieuYeuCau.xsd");
            return ds;
        }

        public static DataSet CRBienBanDuTruBaoTri_GetMaPhieu(Decimal MaPhieuBT_C, Boolean isqAdmin, Boolean isLoai)
        {
            DataSet ds = new DataSet();
            string[] s = { "PhieuYeuCau", "DanhSachTBVTPhieuXuat" };
            SqlHelper.FillDataset(ConnectString, "dbo.CRBienBanDuTruBaoTri_GetMaPhieu", ds, s, MaPhieuBT_C, isqAdmin, isLoai);
            //ds.WriteXmlSchema("E:\\PhieuYeuCauBT.xsd");
            return ds;
        }



        #endregion
    }
}
