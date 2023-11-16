using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;

/// <summary>
/// Summary description for DMTBYTS
/// </summary>

namespace Dzual.CategoryList
{
    [Serializable()]
    public class DMTBYTS
    {
        public Int32 Ordernumber { get; set; }
        public String MaTBYT { get; set; }
        public String TenTBYT { get; set; }
        public String TenTA { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public Nullable<DateTime> NgayNhap { get; set; }
        public String NguoiNhap { get; set; }
        public Nullable<DateTime> NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Byte Loai { get; set; }
        public String TenNguoiNhap { get; set; }
        public String TenNguoiSD { get; set; }
        public List<DMTBYTS> List
        {
            get;
            set;
        }
        public DMTBYTS()
        {
            MaTBYT = "";
            TenTBYT = "";
            TenTA = "";
            Ghichu = "";
            MaMay = "";
            Huy = false;
            NgayNhap = new Nullable<DateTime>();
            NguoiNhap = "";
            NgaySD = new Nullable<DateTime>();
            NguoiSD = "";
            Loai = 0;
            TenNguoiNhap = "";
            TenNguoiSD = "";
            Ordernumber = 0;
        }
        public DMTBYTS(String MaTBYT, String TenTBYT, String TenTA, String Ghichu, String MaMay, Boolean Huy, Nullable<DateTime> NgayNhap, String NguoiNhap, Nullable<DateTime> NgaySD, String NguoiSD, Byte Loai, String TenNguoiNhap, String TenNguoiSD, Int32 Ordernumber)
        {
            this.MaTBYT = MaTBYT;
            this.TenTBYT = TenTBYT;
            this.TenTA = TenTA;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayNhap = NgayNhap;
            this.NguoiNhap = NguoiNhap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Loai = Loai;
            this.TenNguoiNhap = TenNguoiNhap;
            this.TenNguoiSD = TenNguoiSD;
            this.Ordernumber = Ordernumber;
        }
        
        public void CopyTo(DMTBYTS dmTBYT)
        {
            this.MaTBYT = dmTBYT.MaTBYT;
            this.TenTBYT = dmTBYT.TenTBYT;
            this.TenTA = dmTBYT.TenTA;
            this.Ghichu = dmTBYT.Ghichu;
            this.MaMay = dmTBYT.MaMay;
            this.Huy = dmTBYT.Huy;
            this.NgayNhap = dmTBYT.NgayNhap;
            this.NguoiNhap = dmTBYT.NguoiNhap;
            this.NgaySD = dmTBYT.NgaySD;
            this.NguoiSD = dmTBYT.NguoiSD;
            this.Loai = dmTBYT.Loai;
            this.TenNguoiNhap = dmTBYT.TenNguoiNhap;
            this.TenNguoiSD = dmTBYT.TenNguoiSD;
            this.Ordernumber = dmTBYT.Ordernumber;
        }

        public DMTBYTS(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaTBYT"].GetType().Name != "DBNull" && dr["MaTBYT"] != null)
                this.MaTBYT = Convert.ToString(dr["MaTBYT"]);
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            if (dr["TenTA"].GetType().Name != "DBNull" && dr["TenTA"] != null)
                this.TenTA = Convert.ToString(dr["TenTA"]);
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
                this.MaMay = Convert.ToString(dr["MaMay"]);
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["NgayNhap"].GetType().Name != "DBNull" && dr["NgayNhap"] != null)
                this.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
            if (dr["NguoiNhap"].GetType().Name != "DBNull" && dr["NguoiNhap"] != null)
                this.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]);
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
                this.Loai = Convert.ToByte(dr["Loai"]);
            if (dr["TenNguoiNhap"].GetType().Name != "DBNull" && dr["TenNguoiNhap"] != null)
                this.TenNguoiNhap = Convert.ToString(dr["TenNguoiNhap"]);
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            this.Ordernumber = Ordernumber;
        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public DMTBYTS Get(string MaTBYT)
        {
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYTS_Get", MaTBYT))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    return (new DMTBYTS(dr, Ordernumber));
                }
                return new DMTBYTS();
            }
        }

        public static List<DMTBYTS> CopyGetAll(Boolean Qadmin)
        {
            List<DMTBYTS> List = new List<DMTBYTS>();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYTS_GetALL", Qadmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMTBYTS(dr, Ordernumber));
                }
            }
            return List;
        }

        public List<DMTBYTS> GetAll(Boolean Qadmin)
        {
            List = new List<DMTBYTS>();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBYTS_GetALL", Qadmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMTBYTS(dr, Ordernumber));
                }
            }
            return List;
        }

        public String Update()
        {
            if (String.IsNullOrEmpty(this.TenTBYT) || String.IsNullOrEmpty(this.NguoiSD))
            {
                return "ERROR1";
            }

            try
            {
                return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "spDMTBYTS_UPDATE", this.MaTBYT, this.TenTBYT, this.TenTA, this.Ghichu, this.MaMay, this.Loai, this.Huy, this.NguoiSD));
            }
            catch
            {
                return "ERROR1";
            }
        }

        public String Insert()
        {
            if (String.IsNullOrEmpty(this.TenTBYT) || String.IsNullOrEmpty(this.NguoiNhap))
            {
                return "ERROR1";
            }

            try
            {
                return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "spDMTBYTS_CREATE", this.TenTBYT, this.TenTA, this.Ghichu, this.MaMay, this.Loai, this.NguoiNhap));
            }
            catch
            {
                return "ERROR1";
            }
        }

        public Boolean Delete()
        {
            if (String.IsNullOrEmpty(this.MaTBYT) || String.IsNullOrEmpty(this.NguoiSD))
            {
                return false;
            }

            try
            {
                SqlHelper.ExecuteNonQuery(ConnectString, "spDMTBYTS_Delete", this.MaTBYT, this.MaMay, this.NguoiSD);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
