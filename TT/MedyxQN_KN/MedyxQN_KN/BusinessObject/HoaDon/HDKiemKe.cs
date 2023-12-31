using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public partial class HDKiemKe
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public Int32 Ordernumber { get; set; }
        public String MaKK { get; set; }
        public String NgayKK { get; set; }
        public String Makho { get; set; }
        public String NguoiKK { get; set; }
        public String NguoiLap { get; set; }
        public String Ngaylap { get; set; }
        public String GhiChu { get; set; }
        public Boolean Xuly { get; set; }
        public String MaMay { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String Ngayhuy { get; set; }
        public String Nguoihuy { get; set; }
        public Boolean Huy { get; set; }
        public String TenKho { get; set; }
        public String TenNguoiKK { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }

        public HDKiemKe()
        {
            MaKK = "";
            NgayKK = "";
            Makho = "";
            NguoiKK = "";
            NguoiLap = "";
            Ngaylap = "";
            GhiChu = "";
            Xuly = false;
            MaMay = "";
            NgaySD = "";
            NguoiSD = "";
            Ngayhuy = "";
            Nguoihuy = "";
            Huy = false;
            TenKho = "";
            TenNguoiKK = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            Ordernumber = 0;
        }

        public HDKiemKe(String MaKK, String NgayKK, String Makho, String NguoiKK, String NguoiLap, String Ngaylap, String GhiChu, Boolean Xuly, String MaMay, String NgaySD, String NguoiSD, String Ngayhuy, String Nguoihuy, Boolean Huy, String TenKho, String TenNguoiKK, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 Ordernumber)
        {
            this.MaKK = MaKK;
            this.NgayKK = NgayKK;
            this.Makho = Makho;
            this.NguoiKK = NguoiKK;
            this.NguoiLap = NguoiLap;
            this.Ngaylap = Ngaylap;
            this.GhiChu = GhiChu;
            this.Xuly = Xuly;
            this.MaMay = MaMay;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Ngayhuy = Ngayhuy;
            this.Nguoihuy = Nguoihuy;
            this.Huy = Huy;
            this.TenKho = TenKho;
            this.TenNguoiKK = TenNguoiKK;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.Ordernumber = Ordernumber;
        }
        
        public HDKiemKe(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaKK"].GetType().Name != "DBNull" && dr["MaKK"] != null)
            {
                this.MaKK = Convert.ToString(dr["MaKK"]);
            }
            else
            {
                this.MaKK = "";
            }
            if (dr["NgayKK"].GetType().Name != "DBNull" && dr["NgayKK"] != null)
            {
                this.NgayKK = Convert.ToDateTime(dr["NgayKK"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayKK = "";
            }
            if (dr["Makho"].GetType().Name != "DBNull" && dr["Makho"] != null)
            {
                this.Makho = Convert.ToString(dr["Makho"]);
            }
            else
            {
                this.Makho = "";
            }
            if (dr["NguoiKK"].GetType().Name != "DBNull" && dr["NguoiKK"] != null)
            {
                this.NguoiKK = Convert.ToString(dr["NguoiKK"]);
            }
            else
            {
                this.NguoiKK = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = "";
            }
            if (dr["Ngaylap"].GetType().Name != "DBNull" && dr["Ngaylap"] != null)
            {
                this.Ngaylap = Convert.ToDateTime(dr["Ngaylap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.Ngaylap = "";
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            if (dr["Xuly"].GetType().Name != "DBNull" && dr["Xuly"] != null)
            {
                this.Xuly = Convert.ToBoolean(dr["Xuly"]);
            }
            else
            {
                this.Xuly = false;
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
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
            if (dr["Ngayhuy"].GetType().Name != "DBNull" && dr["Ngayhuy"] != null)
            {
                this.Ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.Ngayhuy = "";
            }
            if (dr["Nguoihuy"].GetType().Name != "DBNull" && dr["Nguoihuy"] != null)
            {
                this.Nguoihuy = Convert.ToString(dr["Nguoihuy"]);
            }
            else
            {
                this.Nguoihuy = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
            }
            if (dr["TenNguoiKK"].GetType().Name != "DBNull" && dr["TenNguoiKK"] != null)
            {
                this.TenNguoiKK = Convert.ToString(dr["TenNguoiKK"]);
            }
            else
            {
                this.TenNguoiKK = "";
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
            this.Ordernumber = Ordernumber;
        }

        public static HDKiemKe GetByMa(String MaKK)
        {
            HDKiemKe obj = new HDKiemKe();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spHDKiemKe_GET", MaKK))
            {
                while (dr.Read())
                {
                    obj = new HDKiemKe(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_CREATE", NgayKK == "" ? new Nullable<DateTime>(): DateTime.Parse(NgayKK), Makho, NguoiKK, NguoiLap, GhiChu, MaMay).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_UPDATE", MaKK, NgayKK == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayKK), Makho, NguoiKK, GhiChu, MaMay, NguoiSD, Huy).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_DELETED", MaKK, MaMay, Nguoihuy).ToString();
        }

        public String XuLyKiemKe()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spHDKiemKe_XuLy", MaKK, Xuly, MaMay, Nguoihuy).ToString();
        }

    }

}