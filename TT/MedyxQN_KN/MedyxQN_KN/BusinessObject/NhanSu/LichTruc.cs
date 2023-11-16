using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace HTC.Business.NhanSu
{
    [Serializable()]
    public class LichTruc
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Int64 LichTrucId { get; set; }
        public Int64 LichDangKyId { get; set; }
        public String MaLoaiTruc { get; set; }
        public String MaCongViec { get; set; }
        public String KhoaTruc { get; set; }
        public String ThoiGianTruc { get; set; }
        public String NguoiTruc { get; set; }
        public String NgayTao { get; set; }
        public String NguoiLap { get; set; }
        public String GhiChu { get; set; }
        public String LichTrucMa { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenLoaiTruc { get; set; }
        public Decimal HeSoLoaiTruc { get; set; }
        public String TenCongViec { get; set; }
        public Decimal HeSoCongViec { get; set; }
        public String TenKhoaTruc { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenNguoiTruc { get; set; }
        public String NoiLamViec { get; set; }
        public String MaCD { get; set; }
        public String TenCD { get; set; }
        public String MaTGTruc { get; set; }
        public String TenTGTruc { get; set; }
        public Boolean TrucChinh { get; set; }
        public LichTruc()
        {
            LichTrucId = 0;
            LichDangKyId = 0;
            MaLoaiTruc = "";
            MaCongViec = "";
            KhoaTruc = "";
            ThoiGianTruc = "";
            NguoiTruc = "";
            NgayTao = "";
            NguoiLap = "";
            GhiChu = "";
            LichTrucMa = "";
            MaMay = "";
            Huy = false;
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenLoaiTruc = "";
            HeSoLoaiTruc = 0;
            TenCongViec = "";
            HeSoCongViec = 0;
            TenKhoaTruc = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TenNguoiTruc = "";
            NoiLamViec = "";
            Ordernumber = 0;
            MaCD = "";
            TenCD = "";
            MaTGTruc = "";
            TenTGTruc = "";
            TrucChinh = false;
        }

        public LichTruc(Int64 LichTrucId, Int64 LichDangKyId, String MaLoaiTruc, String MaCongViec, String KhoaTruc, String ThoiGianTruc, String NguoiTruc, String NgayTao, String NguoiLap, String GhiChu, String LichTrucMa, String MaMay, Boolean Huy, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenLoaiTruc, Decimal HeSoLoaiTruc, String TenCongViec, Decimal HeSoCongViec, String TenKhoaTruc, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String TenNguoiTruc, String NoiLamViec, Int32 Ordernumber, String MaCD, String TenCD, String MaTGTruc, String TenTGTruc, Boolean TrucChinh)
        {
            this.LichTrucId = LichTrucId;
            this.LichDangKyId = LichDangKyId;
            this.MaLoaiTruc = MaLoaiTruc;
            this.MaCongViec = MaCongViec;
            this.KhoaTruc = KhoaTruc;
            this.ThoiGianTruc = ThoiGianTruc;
            this.NguoiTruc = NguoiTruc;
            this.NgayTao = NgayTao;
            this.NguoiLap = NguoiLap;
            this.GhiChu = GhiChu;
            this.LichTrucMa = LichTrucMa;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenLoaiTruc = TenLoaiTruc;
            this.HeSoLoaiTruc = HeSoLoaiTruc;
            this.TenCongViec = TenCongViec;
            this.HeSoCongViec = HeSoCongViec;
            this.TenKhoaTruc = TenKhoaTruc;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TenNguoiTruc = TenNguoiTruc;
            this.NoiLamViec = NoiLamViec;
            this.Ordernumber = Ordernumber;
            this.MaCD = MaCD;
            this.TenCD = TenCD;
            this.MaTGTruc = MaTGTruc;
            this.TenTGTruc = TenTGTruc;
            this.TrucChinh = TrucChinh;
        }
        public LichTruc(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["LichTrucId"].GetType().Name != "DBNull" && dr["LichTrucId"] != null)
            {
                this.LichTrucId = Convert.ToInt64(dr["LichTrucId"]);
            }
            else
            {
                this.LichTrucId = 0;
            }
            if (dr["LichDangKyId"].GetType().Name != "DBNull" && dr["LichDangKyId"] != null)
            {
                this.LichDangKyId = Convert.ToInt64(dr["LichDangKyId"]);
            }
            else
            {
                this.LichDangKyId = 0;
            }            
            if (dr["MaLoaiTruc"].GetType().Name != "DBNull" && dr["MaLoaiTruc"] != null)
            {
                this.MaLoaiTruc = Convert.ToString(dr["MaLoaiTruc"]);
            }
            else
            {
                this.MaLoaiTruc = "";
            }
            if (dr["MaCongViec"].GetType().Name != "DBNull" && dr["MaCongViec"] != null)
            {
                this.MaCongViec = Convert.ToString(dr["MaCongViec"]);
            }
            else
            {
                this.MaCongViec = "";
            }
            if (dr["KhoaTruc"].GetType().Name != "DBNull" && dr["KhoaTruc"] != null)
            {
                this.KhoaTruc = Convert.ToString(dr["KhoaTruc"]);
            }
            else
            {
                this.KhoaTruc = "";
            }
            if (dr["ThoiGianTruc"].GetType().Name != "DBNull" && dr["ThoiGianTruc"] != null)
            {
                this.ThoiGianTruc = Convert.ToDateTime(dr["ThoiGianTruc"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.ThoiGianTruc = "";
            }
            if (dr["NguoiTruc"].GetType().Name != "DBNull" && dr["NguoiTruc"] != null)
            {
                this.NguoiTruc = Convert.ToString(dr["NguoiTruc"]);
            }
            else
            {
                this.NguoiTruc = "";
            }
            if (dr["NgayTao"].GetType().Name != "DBNull" && dr["NgayTao"] != null)
            {
                this.NgayTao = Convert.ToDateTime(dr["NgayTao"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayTao = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = "";
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            if (dr["LichTrucMa"].GetType().Name != "DBNull" && dr["LichTrucMa"] != null)
            {
                this.LichTrucMa = Convert.ToString(dr["LichTrucMa"]);
            }
            else
            {
                this.LichTrucMa = "";
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
                this.Huy = false;
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
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHuy = "";
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            {
                this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            }
            else
            {
                this.NguoiHuy = "";
            }
            if (dr["TenLoaiTruc"].GetType().Name != "DBNull" && dr["TenLoaiTruc"] != null)
            {
                this.TenLoaiTruc = Convert.ToString(dr["TenLoaiTruc"]);
            }
            else
            {
                this.TenLoaiTruc = "";
            }
            if (dr["HeSoLoaiTruc"].GetType().Name != "DBNull" && dr["HeSoLoaiTruc"] != null)
            {
                this.HeSoLoaiTruc = Convert.ToDecimal(dr["HeSoLoaiTruc"]);
            }
            else
            {
                this.HeSoLoaiTruc = 0;
            }
            if (dr["TenCongViec"].GetType().Name != "DBNull" && dr["TenCongViec"] != null)
            {
                this.TenCongViec = Convert.ToString(dr["TenCongViec"]);
            }
            else
            {
                this.TenCongViec = "";
            }
            if (dr["HeSoCongViec"].GetType().Name != "DBNull" && dr["HeSoCongViec"] != null)
            {
                this.HeSoCongViec = Convert.ToDecimal(dr["HeSoCongViec"]);
            }
            else
            {
                this.HeSoCongViec = 0;
            }
            if (dr["TenKhoaTruc"].GetType().Name != "DBNull" && dr["TenKhoaTruc"] != null)
            {
                this.TenKhoaTruc = Convert.ToString(dr["TenKhoaTruc"]);
            }
            else
            {
                this.TenKhoaTruc = "";
            }
            if (dr["TenNguoiLap"].GetType().Name != "DBNull" && dr["TenNguoiLap"] != null)
            {
                this.TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            }
            else
            {
                this.TenNguoiLap = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            {
                this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
            }
            else
            {
                this.TenNguoiHuy = "";
            }
            if (dr["TenNguoiTruc"].GetType().Name != "DBNull" && dr["TenNguoiTruc"] != null)
            {
                this.TenNguoiTruc = Convert.ToString(dr["TenNguoiTruc"]);
            }
            else
            {
                this.TenNguoiTruc = "";
            }
            if (dr["NoiLamViec"].GetType().Name != "DBNull" && dr["NoiLamViec"] != null)
            {
                this.NoiLamViec = Convert.ToString(dr["NoiLamViec"]);
            }
            else
            {
                this.NoiLamViec = "";
            }
            if (dr["MaCD"].GetType().Name != "DBNull" && dr["MaCD"] != null)
            {
                this.MaCD = Convert.ToString(dr["MaCD"]);
            }
            else
            {
                this.MaCD = "";
            }
            if (dr["TenCD"].GetType().Name != "DBNull" && dr["TenCD"] != null)
            {
                this.TenCD = Convert.ToString(dr["TenCD"]);
            }
            else
            {
                this.TenCD = "";
            }
            if (dr["MaTGTruc"].GetType().Name != "DBNull" && dr["MaTGTruc"] != null)
            {
                this.MaTGTruc = Convert.ToString(dr["MaTGTruc"]);
            }
            else
            {
                this.MaTGTruc = "";
            }
            if (dr["TenTGTruc"].GetType().Name != "DBNull" && dr["TenTGTruc"] != null)
            {
                this.TenTGTruc = Convert.ToString(dr["TenTGTruc"]);
            }
            else
            {
                this.TenTGTruc = "";
            }
            if (dr["TrucChinh"].GetType().Name != "DBNull" && dr["TrucChinh"] != null)
            {
                this.TrucChinh = Convert.ToBoolean(dr["TrucChinh"]);
            }
            else
            {
                this.TrucChinh = false;
            }
            this.Ordernumber = Ordernumber;
        }

        public static LichTruc GetById(Int64 LichTrucId)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spLichTruc_GetById", LichTrucId)))
            {
                while (dr.Read())
                {
                    return new LichTruc(dr, 1);
                }
            }
            return null;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spLichTruc_Create", LichDangKyId, MaLoaiTruc, MaCongViec, KhoaTruc, ThoiGianTruc == null ? new Nullable<DateTime>() : DateTime.Parse(ThoiGianTruc), NguoiTruc, NguoiLap, GhiChu, LichTrucMa, MaMay, MaCD, MaTGTruc, TrucChinh).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spLichTruc_Update", LichTrucId, MaLoaiTruc, MaCongViec, KhoaTruc, ThoiGianTruc == null ? new Nullable<DateTime>() : DateTime.Parse(ThoiGianTruc), NguoiTruc, GhiChu, LichTrucMa, MaMay, Huy, NguoiSD, MaCD, MaTGTruc, TrucChinh).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spLichTruc_Delete", LichTrucId, MaMay, NguoiHuy).ToString();
        }
    }

    [Serializable()]
    public class LichTrucList : List<LichTruc>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static LichTrucList GetAll(DateTime TuNgay, DateTime DenNgay, String MaLoaiTrucArrary, Boolean Qadmin)
        {
            LichTrucList ListItems = new LichTrucList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "spLichTruc_GetAll", TuNgay, DenNgay, MaLoaiTrucArrary, Qadmin)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    ListItems.Add(new LichTruc(dr, order));
                }
            }
            return ListItems;
        }

        public static LichTrucList FindAll(DateTime TuNgay, DateTime DenNgay, String MaLoaiTrucArrary, String MaKhoaTrucArrary, String MaCongViecArray, String NguoiTrucArray, String MaChuyenMonArray, Boolean Duyet, Boolean Qadmin, String MaCD, String MaTGTruc, Boolean TrucChinh)
        {
            LichTrucList ListItems = new LichTrucList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "spLichTruc_FindAll", TuNgay, DenNgay, MaLoaiTrucArrary, MaKhoaTrucArrary, MaCongViecArray, NguoiTrucArray, MaChuyenMonArray, Duyet, Qadmin, MaCD, MaTGTruc, TrucChinh)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    ListItems.Add(new LichTruc(dr, order));
                }
            }
            return ListItems;
        }

        public static DataSet BaoCaoLichTruc(DateTime TuNgay, DateTime DenNgay, String MaLoaiTrucArrary, String MaCongViecArrary, String MaKhoaTrucArrary, String NhanVienTrucArrary, String MaChuyenMonArray)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBaoCaoLichTruc", TuNgay, DenNgay, MaLoaiTrucArrary, MaCongViecArrary, MaKhoaTrucArrary, NhanVienTrucArrary, MaChuyenMonArray);
        }
        public static DataSet BaoCaoLichTrucChinh(DateTime TuNgay, DateTime DenNgay, String MaLoaiTrucArrary, String MaCongViecArrary, String MaKhoaTrucArrary, String NhanVienTrucArrary, String MaChuyenMonArray)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBaoCaoLichTrucChinh", TuNgay, DenNgay, MaLoaiTrucArrary, MaCongViecArrary, MaKhoaTrucArrary, NhanVienTrucArrary, MaChuyenMonArray);
        }
        public static DataSet BaoCaoSoNgayTruc(DateTime TuNgay, DateTime DenNgay, String MaLoaiTrucArrary, String MaCongViecArrary, String MaKhoaTrucArrary, String NhanVienTrucArrary, String MaChuyenMonArray)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBaoCaoSoNgayTruc", TuNgay, DenNgay, MaLoaiTrucArrary, MaCongViecArrary, MaKhoaTrucArrary, NhanVienTrucArrary, MaChuyenMonArray);
        }
    }
}
