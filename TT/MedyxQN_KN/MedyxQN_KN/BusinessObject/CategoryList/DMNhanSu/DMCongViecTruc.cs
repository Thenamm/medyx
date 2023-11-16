using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMCongViecTruc
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String MaCongViec { get; set; }
        public String TenCongViec { get; set; }
        public String GhiChu { get; set; }
        public Decimal HeSo { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenMaCongViec
        {
            get
            {
                return TenCongViec + (MaCongViec == ""? "": "-" + MaCongViec);
            }
        }


        public DMCongViecTruc()
        {
            MaCongViec = "";
            TenCongViec = "";
            GhiChu = "";
            HeSo = 0;
            MaMay = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            Ordernumber = 0;
        }

        public DMCongViecTruc(String MaCongViec, String TenCongViec, String GhiChu, Decimal HeSo, String MaMay, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 Ordernumber)
        {
            this.MaCongViec = MaCongViec;
            this.TenCongViec = TenCongViec;
            this.GhiChu = GhiChu;
            this.HeSo = HeSo;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.Ordernumber = Ordernumber;
        }
        public DMCongViecTruc(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaCongViec"].GetType().Name != "DBNull" && dr["MaCongViec"] != null)
            {
                this.MaCongViec = Convert.ToString(dr["MaCongViec"]);
            }
            else
            {
                this.MaCongViec = "";
            }
            if (dr["TenCongViec"].GetType().Name != "DBNull" && dr["TenCongViec"] != null)
            {
                this.TenCongViec = Convert.ToString(dr["TenCongViec"]);
            }
            else
            {
                this.TenCongViec = "";
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            if (dr["HeSo"].GetType().Name != "DBNull" && dr["HeSo"] != null)
            {
                this.HeSo = Convert.ToDecimal(dr["HeSo"]);
            }
            else
            {
                this.HeSo = 0;
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

        public static DMCongViecTruc GetById(String MaCongViec)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spDMCongViecTruc_GetById", MaCongViec)))
            {
                while (dr.Read())
                {
                    return new DMCongViecTruc(dr, 1);
                }
            }
            return null;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMCongViecTruc_Create", TenCongViec, GhiChu, HeSo, MaMay, NguoiLap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMCongViecTruc_Update", MaCongViec, TenCongViec, GhiChu, HeSo, MaMay, Huy, NguoiSD).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMCongViecTruc_Delete", MaCongViec, MaMay, NguoiHuy).ToString();
        }

    }

    [Serializable()]
    public class DMCongViecTrucList : List<DMCongViecTruc>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static DMCongViecTrucList GetAll(String DK, Boolean Qadmin, int STTBD = 0, int STTKT = 100)
        {
            DMCongViecTrucList ListItems = new DMCongViecTrucList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "spDMCongViecTruc_FindAll", DK, Qadmin)))
            {
                int order = 0;
                while (dr.Read())
                {
                    if (order >= STTBD && order <= STTKT)
                    {
                        order++;
                        ListItems.Add(new DMCongViecTruc(dr, order));
                    }
                    else if(order > STTKT)
                    {
                        return ListItems;
                    }
                }
            }
            return ListItems;
        }
    }
}
