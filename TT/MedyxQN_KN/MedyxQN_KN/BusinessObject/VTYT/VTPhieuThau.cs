using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
using System.Globalization;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuThau
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal VTPhieuThauId { get; set; }
        public String TenGoiThau { get; set; }
        public String TenLoaiThau { get; set; }
        public String MaLoaiThau { get; set; }
        public String NVThau { get; set; }
        public String MaNCC { get; set; }
        public String DaiDienNCC { get; set; }
        public String MaSoThau { get; set; }
        public String NgayThau { get; set; }
        public Decimal Tong { get; set; }
        public String GhiChu { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public String TenNCC { get; set; }
        public String TenNVThau { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String SoHD { get; set; }
        public String NgayKyHD { get; set; }
        public VTPhieuThau()
        {
            VTPhieuThauId = 0;
            TenGoiThau = "";
            TenLoaiThau = "";
            MaLoaiThau = "";
            NVThau = "";
            MaNCC = "";
            DaiDienNCC = "";
            MaSoThau = "";
            NgayThau = "";
            Tong = 0;
            GhiChu = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgayHuy = "";
            NguoiHuy = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            TenNCC = "";
            TenNVThau = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            SoHD = "";
            NgayKyHD = "";
            Ordernumber = 0;
        }

        public VTPhieuThau(Decimal VTPhieuThauId, String TenGoiThau, String TenLoaiThau, String MaLoaiThau, String NVThau, String MaNCC, String DaiDienNCC, String MaSoThau, String NgayThau, Decimal Tong, String GhiChu, Boolean Huy, String NgayLap, String NguoiLap, String NgayHuy, String NguoiHuy, String NgaySD, String NguoiSD, String MaMay, String TenNCC, String TenNVThau, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String SoHD, String NgayKyHD, Int32 Ordernumber)
        {
            this.VTPhieuThauId = VTPhieuThauId;
            this.TenGoiThau = TenGoiThau;
            this.TenLoaiThau = TenLoaiThau;
            this.MaLoaiThau = MaLoaiThau;
            this.NVThau = NVThau;
            this.MaNCC = MaNCC;
            this.DaiDienNCC = DaiDienNCC;
            this.MaSoThau = MaSoThau;
            this.NgayThau = NgayThau;
            this.Tong = Tong;
            this.GhiChu = GhiChu;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.TenNCC = TenNCC;
            this.TenNVThau = TenNVThau;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.SoHD = SoHD;
            this.NgayKyHD = NgayKyHD;
            this.Ordernumber = Ordernumber;
        }
        public VTPhieuThau(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["VTPhieuThauId"].GetType().Name != "DBNull" && dr["VTPhieuThauId"] != null)
            {
                this.VTPhieuThauId = Convert.ToDecimal(dr["VTPhieuThauId"]);
            }
            else
            {
                this.VTPhieuThauId = 0;
            }
            if (dr["TenGoiThau"].GetType().Name != "DBNull" && dr["TenGoiThau"] != null)
            {
                this.TenGoiThau = Convert.ToString(dr["TenGoiThau"]);
            }
            else
            {
                this.TenGoiThau = "";
            }
            if (dr["TenLoaiThau"].GetType().Name != "DBNull" && dr["TenLoaiThau"] != null)
            {
                this.TenLoaiThau = Convert.ToString(dr["TenLoaiThau"]);
            }
            else
            {
                this.TenLoaiThau = "";
            }
            if (dr["MaLoaiThau"].GetType().Name != "DBNull" && dr["MaLoaiThau"] != null)
            {
                this.MaLoaiThau = Convert.ToString(dr["MaLoaiThau"]);
            }
            else
            {
                this.MaLoaiThau = "";
            }            
            if (dr["NVThau"].GetType().Name != "DBNull" && dr["NVThau"] != null)
            {
                this.NVThau = Convert.ToString(dr["NVThau"]);
            }
            else
            {
                this.NVThau = "";
            }
            if (dr["MaNCC"].GetType().Name != "DBNull" && dr["MaNCC"] != null)
            {
                this.MaNCC = Convert.ToString(dr["MaNCC"]);
            }
            else
            {
                this.MaNCC = "";
            }
            if (dr["DaiDienNCC"].GetType().Name != "DBNull" && dr["DaiDienNCC"] != null)
            {
                this.DaiDienNCC = Convert.ToString(dr["DaiDienNCC"]);
            }
            else
            {
                this.DaiDienNCC = "";
            }
            if (dr["MaSoThau"].GetType().Name != "DBNull" && dr["MaSoThau"] != null)
            {
                this.MaSoThau = Convert.ToString(dr["MaSoThau"]);
            }
            else
            {
                this.MaSoThau = "";
            }
            if (dr["NgayThau"].GetType().Name != "DBNull" && dr["NgayThau"] != null)
            {
                this.NgayThau = Convert.ToDateTime(dr["NgayThau"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayThau = "";
            }
            if (dr["Tong"].GetType().Name != "DBNull" && dr["Tong"] != null)
            {
                this.Tong = Convert.ToDecimal(dr["Tong"]);
            }
            else
            {
                this.Tong = 0;
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayLap = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = "";
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
            if (dr["TenNCC"].GetType().Name != "DBNull" && dr["TenNCC"] != null)
            {
                this.TenNCC = Convert.ToString(dr["TenNCC"]);
            }
            else
            {
                this.TenNCC = "";
            }
            if (dr["TenNVThau"].GetType().Name != "DBNull" && dr["TenNVThau"] != null)
            {
                this.TenNVThau = Convert.ToString(dr["TenNVThau"]);
            }
            else
            {
                this.TenNVThau = "";
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
            if (dr["SoHD"].GetType().Name != "DBNull" && dr["SoHD"] != null)
            {
                this.SoHD = Convert.ToString(dr["SoHD"]);
            }
            else
            {
                this.SoHD = "";
            }
            if (dr["NgayKyHD"].GetType().Name != "DBNull" && dr["NgayKyHD"] != null)
            {
                this.NgayKyHD = Convert.ToDateTime(dr["NgayKyHD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayKyHD = "";
            }
            this.Ordernumber = Ordernumber;
        }

        public Decimal Insert()
        {
            DateTime ngaythau = DateTime.ParseExact(NgayThau, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngaykyHD = DateTime.ParseExact(NgayKyHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spVTPhieuThau_Insert", TenGoiThau, MaLoaiThau, NVThau, MaNCC, DaiDienNCC, MaSoThau, ngaythau, GhiChu, NguoiLap, MaMay, SoHD, ngaykyHD).ToString());
        }

        public Decimal Update()
        {
            DateTime ngaythau = DateTime.ParseExact(NgayThau, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngaykyHD = DateTime.ParseExact(NgayKyHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spVTPhieuThau_Update", VTPhieuThauId, TenGoiThau, MaLoaiThau, NVThau, MaNCC, DaiDienNCC, MaSoThau,ngaythau, GhiChu, Huy, NguoiSD, MaMay, SoHD, ngaykyHD).ToString());
        }

        public Decimal Delete()
        {
            return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spVTPhieuThau_Delete", VTPhieuThauId, NguoiHuy, MaMay).ToString());
        }

        public static VTPhieuThau GetByMa(Decimal VTPhieuThauId)
        {
            VTPhieuThau obj = new VTPhieuThau();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spVTPhieuThau_Get", VTPhieuThauId))
            {
                while (dr.Read())
                {
                    obj = new VTPhieuThau(dr, 1);
                    break;
                }
            }
            return obj;
        }

    }

        [Serializable()]
    public class VTPhieuThaus : List<VTPhieuThau>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public static VTPhieuThaus GetALL(DateTime TuNgay, DateTime DenNgay, Boolean QuyenAdmin)
        {
            VTPhieuThaus obj = new VTPhieuThaus();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spVTPhieuThau_GetAll", TuNgay, DenNgay, QuyenAdmin))
            {
                int Ordernumber = 1;
                while (dr.Read())
                {
                    Ordernumber++;
                    obj.Add(new VTPhieuThau(dr, Ordernumber));
                }
            }
            return obj;
        }
        public static VTPhieuThaus GetHDCC(String MaNCC, String SoHD)
        {
            VTPhieuThaus obj = new VTPhieuThaus();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spVTPhieuThau_GetByHDCC", MaNCC, SoHD))
            {
                int Ordernumber = 1;
                while (dr.Read())
                {
                    Ordernumber++;
                    obj.Add(new VTPhieuThau(dr, Ordernumber));
                }
            }
            return obj;
        }
        public static DataSet BCVTPhieuThauGetAll(DateTime NamThau, String MaNCC, String MaVT)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBCVTPhieuThauGetAll", NamThau, MaNCC, MaVT);
        }

        public static DataSet BCVTPhieuThauTon(DateTime NamThau, String MaNCC, String MaVT)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spBCVTPhieuThauTon", NamThau, MaNCC, MaVT);
        }
    }
}
