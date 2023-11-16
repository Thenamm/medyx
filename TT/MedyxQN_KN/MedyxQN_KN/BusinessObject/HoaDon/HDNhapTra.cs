using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDNhapTra
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String MaNT { get; set; }
        public String NoiXuat { get; set; }
        public String NgayXuat { get; set; }
        public Boolean IsDuTru { get; set; }
        public Boolean DaPhat { get; set; }
        public Boolean DaDuyet { get; set; }
        public String NgayXuatTT { get; set; }
        public String NoiNhap { get; set; }
        public Byte Loaiphieu { get; set; }
        public String SoCT { get; set; }
        public String NVXuat { get; set; }
        public String NVNhan { get; set; }
        public String Ghichu { get; set; }
        public Boolean Huy { get; set; }
        public String MaMay { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TENNOIXUAT { get; set; }
        public String TENNOINHAP { get; set; }
        public String TENNVXUAT { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }
        public String TENNGUOINHAN { get; set; }

        public HDNhapTra()
        {
            MaNT = String.Empty;
            NoiXuat = String.Empty;
            NgayXuat = String.Empty;
            IsDuTru = false;
            DaPhat = false;
            DaDuyet = false;
            NgayXuatTT = String.Empty;
            NoiNhap = String.Empty;
            Loaiphieu = 0;
            SoCT = String.Empty;
            NVXuat = String.Empty;
            NVNhan = String.Empty;
            Ghichu = String.Empty;
            Huy = false;
            MaMay = String.Empty;
            NgayLap = String.Empty;
            NguoiLap = String.Empty;
            NgaySD = String.Empty;
            NguoiSD = String.Empty;
            NgayHuy = String.Empty;
            NguoiHuy = String.Empty;
            TENNOIXUAT = String.Empty;
            TENNOINHAP = String.Empty;
            TENNVXUAT = String.Empty;
            TENNGUOILAP = String.Empty;
            TENNGUOISD = String.Empty;
            TENNGUOIHUY = String.Empty;
            TENNGUOINHAN = String.Empty;
            Ordernumber = 0;
        }

        public HDNhapTra(String MaNT, String NoiXuat, String NgayXuat, Boolean IsDuTru, Boolean DaPhat, Boolean DaDuyet, String NgayXuatTT, String NoiNhap, Byte Loaiphieu, String SoCT, String NVXuat, String NVNhan, String Ghichu, Boolean Huy, String MaMay, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TENNOIXUAT, String TENNOINHAP, String TENNVXUAT, String TENNGUOILAP, String TENNGUOISD, String TENNGUOIHUY, String TENNGUOINHAN, Int32 Ordernumber)
        {
            this.MaNT = MaNT;
            this.NoiXuat = NoiXuat;
            this.NgayXuat = NgayXuat;
            this.IsDuTru = IsDuTru;
            this.DaPhat = DaPhat;
            this.DaDuyet = DaDuyet;
            this.NgayXuatTT = NgayXuatTT;
            this.NoiNhap = NoiNhap;
            this.Loaiphieu = Loaiphieu;
            this.SoCT = SoCT;
            this.NVXuat = NVXuat;
            this.NVNhan = NVNhan;
            this.Ghichu = Ghichu;
            this.Huy = Huy;
            this.MaMay = MaMay;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TENNOIXUAT = TENNOIXUAT;
            this.TENNOINHAP = TENNOINHAP;
            this.TENNVXUAT = TENNVXUAT;
            this.TENNGUOILAP = TENNGUOILAP;
            this.TENNGUOISD = TENNGUOISD;
            this.TENNGUOIHUY = TENNGUOIHUY;
            this.TENNGUOINHAN = TENNGUOINHAN;
            this.Ordernumber = Ordernumber;
        }
        public HDNhapTra(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaNT"].GetType().Name != "DBNull" && dr["MaNT"] != null)
            {
                this.MaNT = Convert.ToString(dr["MaNT"]);
            }
            else
            {
                this.MaNT = String.Empty;
            }
            if (dr["NoiXuat"].GetType().Name != "DBNull" && dr["NoiXuat"] != null)
            {
                this.NoiXuat = Convert.ToString(dr["NoiXuat"]);
            }
            else
            {
                this.NoiXuat = String.Empty;
            }
            if (dr["NgayXuat"].GetType().Name != "DBNull" && dr["NgayXuat"] != null)
            {
                this.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayXuat = String.Empty;
            }
            if (dr["IsDuTru"].GetType().Name != "DBNull" && dr["IsDuTru"] != null)
            {
                this.IsDuTru = Convert.ToBoolean(dr["IsDuTru"]);
            }
            else
            {
                this.IsDuTru = false;
            }
            if (dr["DaPhat"].GetType().Name != "DBNull" && dr["DaPhat"] != null)
            {
                this.DaPhat = Convert.ToBoolean(dr["DaPhat"]);
            }
            else
            {
                this.DaPhat = false;
            }
            if (dr["DaDuyet"].GetType().Name != "DBNull" && dr["DaDuyet"] != null)
            {
                this.DaDuyet = Convert.ToBoolean(dr["DaDuyet"]);
            }
            else
            {
                this.DaDuyet = false;
            }
            if (dr["NgayXuatTT"].GetType().Name != "DBNull" && dr["NgayXuatTT"] != null)
            {
                this.NgayXuatTT = Convert.ToDateTime(dr["NgayXuatTT"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayXuatTT = String.Empty;
            }
            if (dr["NoiNhap"].GetType().Name != "DBNull" && dr["NoiNhap"] != null)
            {
                this.NoiNhap = Convert.ToString(dr["NoiNhap"]);
            }
            else
            {
                this.NoiNhap = String.Empty;
            }
            if (dr["Loaiphieu"].GetType().Name != "DBNull" && dr["Loaiphieu"] != null)
            {
                this.Loaiphieu = Convert.ToByte(dr["Loaiphieu"]);
            }
            else
            {
                this.Loaiphieu = 0;
            }
            if (dr["SoCT"].GetType().Name != "DBNull" && dr["SoCT"] != null)
            {
                this.SoCT = Convert.ToString(dr["SoCT"]);
            }
            else
            {
                this.SoCT = String.Empty;
            }
            if (dr["NVXuat"].GetType().Name != "DBNull" && dr["NVXuat"] != null)
            {
                this.NVXuat = Convert.ToString(dr["NVXuat"]);
            }
            else
            {
                this.NVXuat = String.Empty;
            }
            if (dr["NVNhan"].GetType().Name != "DBNull" && dr["NVNhan"] != null)
            {
                this.NVNhan = Convert.ToString(dr["NVNhan"]);
            }
            else
            {
                this.NVNhan = String.Empty;
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = String.Empty;
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = String.Empty;
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayLap = String.Empty;
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = String.Empty;
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgaySD = String.Empty;
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = String.Empty;
            }
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHuy = String.Empty;
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            {
                this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            }
            else
            {
                this.NguoiHuy = String.Empty;
            }
            if (dr["TENNOIXUAT"].GetType().Name != "DBNull" && dr["TENNOIXUAT"] != null)
            {
                this.TENNOIXUAT = Convert.ToString(dr["TENNOIXUAT"]);
            }
            else
            {
                this.TENNOIXUAT = String.Empty;
            }
            if (dr["TENNOINHAP"].GetType().Name != "DBNull" && dr["TENNOINHAP"] != null)
            {
                this.TENNOINHAP = Convert.ToString(dr["TENNOINHAP"]);
            }
            else
            {
                this.TENNOINHAP = String.Empty;
            }
            if (dr["TENNVXUAT"].GetType().Name != "DBNull" && dr["TENNVXUAT"] != null)
            {
                this.TENNVXUAT = Convert.ToString(dr["TENNVXUAT"]);
            }
            else
            {
                this.TENNVXUAT = String.Empty;
            }
            if (dr["TENNGUOILAP"].GetType().Name != "DBNull" && dr["TENNGUOILAP"] != null)
            {
                this.TENNGUOILAP = Convert.ToString(dr["TENNGUOILAP"]);
            }
            else
            {
                this.TENNGUOILAP = String.Empty;
            }
            if (dr["TENNGUOISD"].GetType().Name != "DBNull" && dr["TENNGUOISD"] != null)
            {
                this.TENNGUOISD = Convert.ToString(dr["TENNGUOISD"]);
            }
            else
            {
                this.TENNGUOISD = String.Empty;
            }
            if (dr["TENNGUOIHUY"].GetType().Name != "DBNull" && dr["TENNGUOIHUY"] != null)
            {
                this.TENNGUOIHUY = Convert.ToString(dr["TENNGUOIHUY"]);
            }
            else
            {
                this.TENNGUOIHUY = String.Empty;
            }
            if (dr["TENNGUOINHAN"].GetType().Name != "DBNull" && dr["TENNGUOINHAN"] != null)
            {
                this.TENNGUOINHAN = Convert.ToString(dr["TENNGUOINHAN"]);
            }
            else
            {
                this.TENNGUOINHAN = String.Empty;
            }
            this.Ordernumber = Ordernumber;
        }

        public static HDNhapTra GetByMa(String MaNT, Byte Loai)
        {
            HDNhapTra obj = new HDNhapTra();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDNhapTra_GET", MaNT, Loai))
            {
                while (dr.Read())
                {
                    obj = new HDNhapTra(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDNhapTra_CREATE", NoiXuat, (NgayXuat == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuat)), IsDuTru, DaPhat, DaDuyet, (NgayXuatTT == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuatTT)), NoiNhap, Loaiphieu, SoCT, NVXuat, NVNhan, Ghichu, MaMay, NguoiLap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDNhapTra_UPDATE", MaNT, NoiXuat, (NgayXuat == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuat)), IsDuTru, DaPhat, DaDuyet, (NgayXuatTT == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuatTT)), NoiNhap, Loaiphieu, SoCT, NVXuat, NVNhan, Ghichu, Huy, MaMay, NguoiSD).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDNhapTra_DELETED", MaNT, MaMay, NguoiSD).ToString();
        }
    }
}
