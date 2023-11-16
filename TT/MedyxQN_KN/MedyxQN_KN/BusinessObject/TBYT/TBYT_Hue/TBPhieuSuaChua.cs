using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class TBPHIEUSUACHUA
    {
        public Int32 Ordernumber { get; set; }
        public String MaPhieuYC { get; set; }
        public String NgayYC { get; set; }
        public String MaKhoaYC { get; set; }
        public String NhanVienYC { get; set; }
        public Decimal SoYC { get; set; }
        public String MoTaYC { get; set; }
        public Byte DuyetYC { get; set; }
        public String NgayDuyetYC { get; set; }
        public String NguoiDuyetYC { get; set; }
        public String LDKhongDuyet { get; set; }
        public String MaDVKS { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String Ngayhuy { get; set; }
        public String Nguoihuy { get; set; }
        public String MaMay { get; set; }
        public String TenKhoaYC { get; set; }
        public String TenNhanVienYC { get; set; }
        public String TenNguoiDuyetYC { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenDVKS { get; set; }
        public String TinhTrangPhieu { get; set; }
        public TBPHIEUSUACHUA()
        {
            MaPhieuYC = "";
            NgayYC = "";
            MaKhoaYC = "";
            NhanVienYC = "";
            SoYC = 0;
            MoTaYC = "";
            DuyetYC = 0;
            NgayDuyetYC = "";
            NguoiDuyetYC = "";
            LDKhongDuyet = "";
            MaDVKS = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            Ngayhuy = "";
            Nguoihuy = "";
            MaMay = "";
            TenKhoaYC = "";
            TenNhanVienYC = "";
            TenNguoiDuyetYC = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TenDVKS = "";
            TinhTrangPhieu = "";
            Ordernumber = 0;
        }
        public TBPHIEUSUACHUA(String MaPhieuYC, String NgayYC, String MaKhoaYC, String NhanVienYC, Decimal SoYC, String MoTaYC, Byte DuyetYC, String NgayDuyetYC, String NguoiDuyetYC, String LDKhongDuyet, String MaDVKS, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String Ngayhuy, String Nguoihuy, String MaMay, String TenKhoaYC, String TenNhanVienYC, String TenNguoiDuyetYC, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String TenDVKS, String TinhTrangPhieu, Int32 Ordernumber)
        {
            this.MaPhieuYC = MaPhieuYC;
            this.NgayYC = NgayYC;
            this.MaKhoaYC = MaKhoaYC;
            this.NhanVienYC = NhanVienYC;
            this.SoYC = SoYC;
            this.MoTaYC = MoTaYC;
            this.DuyetYC = DuyetYC;
            this.NgayDuyetYC = NgayDuyetYC;
            this.NguoiDuyetYC = NguoiDuyetYC;
            this.LDKhongDuyet = LDKhongDuyet;
            this.MaDVKS = MaDVKS;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.Ngayhuy = Ngayhuy;
            this.Nguoihuy = Nguoihuy;
            this.MaMay = MaMay;
            this.TenKhoaYC = TenKhoaYC;
            this.TenNhanVienYC = TenNhanVienYC;
            this.TenNguoiDuyetYC = TenNguoiDuyetYC;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TenDVKS = TenDVKS;
            this.TinhTrangPhieu = TinhTrangPhieu;
            this.Ordernumber = Ordernumber;
        }
        public TBPHIEUSUACHUA(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPhieuYC"].GetType().Name != "DBNull" && dr["MaPhieuYC"] != null)
            { this.MaPhieuYC = Convert.ToString(dr["MaPhieuYC"]); }
            else
            {
                MaPhieuYC = "";
            }
            if (dr["NgayYC"].GetType().Name != "DBNull" && dr["NgayYC"] != null)
            {
                this.NgayYC = Convert.ToDateTime(dr["NgayYC"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayYC = "";
            }
            if (dr["MaKhoaYC"].GetType().Name != "DBNull" && dr["MaKhoaYC"] != null)
            { this.MaKhoaYC = Convert.ToString(dr["MaKhoaYC"]); }
            else
            {
                MaKhoaYC = "";
            }
            if (dr["NhanVienYC"].GetType().Name != "DBNull" && dr["NhanVienYC"] != null)
            { this.NhanVienYC = Convert.ToString(dr["NhanVienYC"]); }
            else
            {
                NhanVienYC = "";
            }
            if (dr["SoYC"].GetType().Name != "DBNull" && dr["SoYC"] != null)
            { this.SoYC = Convert.ToDecimal(dr["SoYC"]); }
            else
            {
                SoYC = 0;
            }
            if (dr["MoTaYC"].GetType().Name != "DBNull" && dr["MoTaYC"] != null)
            { this.MoTaYC = Convert.ToString(dr["MoTaYC"]); }
            else
            {
                MoTaYC = "";
            }
            if (dr["DuyetYC"].GetType().Name != "DBNull" && dr["DuyetYC"] != null)
            { this.DuyetYC = Convert.ToByte(dr["DuyetYC"]); }
            else
            {
                DuyetYC = 0;
            }
            if (dr["NgayDuyetYC"].GetType().Name != "DBNull" && dr["NgayDuyetYC"] != null)
            {
                this.NgayDuyetYC = Convert.ToDateTime(dr["NgayDuyetYC"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayDuyetYC = "";
            }
            if (dr["NguoiDuyetYC"].GetType().Name != "DBNull" && dr["NguoiDuyetYC"] != null)
            { this.NguoiDuyetYC = Convert.ToString(dr["NguoiDuyetYC"]); }
            else
            {
                NguoiDuyetYC = "";
            }
            if (dr["LDKhongDuyet"].GetType().Name != "DBNull" && dr["LDKhongDuyet"] != null)
            { this.LDKhongDuyet = Convert.ToString(dr["LDKhongDuyet"]); }
            else
            {
                LDKhongDuyet = "";
            }
            if (dr["MaDVKS"].GetType().Name != "DBNull" && dr["MaDVKS"] != null)
            { this.MaDVKS = Convert.ToString(dr["MaDVKS"]); }
            else
            {
                MaDVKS = "";
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
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            { this.MaMay = Convert.ToString(dr["MaMay"]); }
            else
            {
                MaMay = "";
            }
            if (dr["TenKhoaYC"].GetType().Name != "DBNull" && dr["TenKhoaYC"] != null)
            { this.TenKhoaYC = Convert.ToString(dr["TenKhoaYC"]); }
            else
            {
                TenKhoaYC = "";
            }
            if (dr["TenNhanVienYC"].GetType().Name != "DBNull" && dr["TenNhanVienYC"] != null)
            { this.TenNhanVienYC = Convert.ToString(dr["TenNhanVienYC"]); }
            else
            {
                TenNhanVienYC = "";
            }
            if (dr["TenNguoiDuyetYC"].GetType().Name != "DBNull" && dr["TenNguoiDuyetYC"] != null)
            { this.TenNguoiDuyetYC = Convert.ToString(dr["TenNguoiDuyetYC"]); }
            else
            {
                TenNguoiDuyetYC = "";
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
            if (dr["TenDVKS"].GetType().Name != "DBNull" && dr["TenDVKS"] != null)
            { this.TenDVKS = Convert.ToString(dr["TenDVKS"]); }
            else
            {
                TenDVKS = "";
            }
            if (dr["TinhTrangPhieu"].GetType().Name != "DBNull" && dr["TinhTrangPhieu"] != null)
            { this.TinhTrangPhieu = Convert.ToString(dr["TinhTrangPhieu"]); }
            else
            {
                TinhTrangPhieu = "";
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

        public static TBPHIEUSUACHUA GetbyMaPhieu(String MaPhieuYC)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_Get", MaPhieuYC)))
            {
                while (dr.Read())
                {
                    return new TBPHIEUSUACHUA(dr, 0);
                }
            }
            return null;
        }

        public static String Add(DateTime NgayYC, String MaKhoaYC, String NhanVienYC, String MoTaYC, String NguoiLap, String MaMay)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_INSERT", NgayYC, MaKhoaYC, NhanVienYC, MoTaYC, NguoiLap, MaMay));
        }

        public static String Edit(string MaPhieuYC, DateTime NgayYC, String MaKhoaYC, String NhanVienYC, String MaMoTa, String NguoiSD, String MaMay, Boolean Huy)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_UPDATE", MaPhieuYC, NgayYC, MaKhoaYC, NhanVienYC, MaMoTa, NguoiSD, MaMay, Huy));
        }

        public static String Delete(string MaPhieuYC, String NguoiHuy, String MaMay)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_DELETE", MaPhieuYC, NguoiHuy, MaMay));
        }

        public static String Duyet(string MaPhieuYC, Byte DuyetYC, String NguoiDuyet, String DVKS, String NguyenNhanKhongDuyet, String MaMay)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_DUYET", MaPhieuYC, DuyetYC, NguoiDuyet, DVKS, NguyenNhanKhongDuyet, MaMay));
        }

        public static String DeleteDuTru(string MaPhieuYC, String NguoiDuyet, String MaMay)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DELETE_DuTru", MaPhieuYC, NguoiDuyet, MaMay));
        }
    }


    [Serializable()]
    public class TBPHIEUSUACHUALIST : List<TBPHIEUSUACHUA>
    {
        public TBPHIEUSUACHUALIST()
        {

        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static TBPHIEUSUACHUALIST GetAll(DateTime NgayBatDau, DateTime NgayKetThuc, String MaKhoaYC, Byte Loai,  String Account)
        {
            TBPHIEUSUACHUALIST List = new TBPHIEUSUACHUALIST();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_GetAll", NgayBatDau, NgayKetThuc, MaKhoaYC, Loai, Account))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBPHIEUSUACHUA(dr, Ordernumber));
                }
            }
            return List;
        }

        public static TBPHIEUSUACHUALIST HictoryMaTB(String MaTB)
        {
            TBPHIEUSUACHUALIST List = new TBPHIEUSUACHUALIST();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_HictoryMaTB", MaTB))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBPHIEUSUACHUA(dr, Ordernumber));
                }
            }
            return List;
        }   

    }

}
