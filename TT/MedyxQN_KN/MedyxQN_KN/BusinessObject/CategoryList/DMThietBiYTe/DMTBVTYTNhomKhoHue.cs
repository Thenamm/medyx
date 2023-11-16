using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HTC.BusinessObject.CategoryList
{
    [Serializable]
    public class DMTBVTYTNhomKhoHue
    {
        public Int32 Ordernumber { get; set; }
        public String Makho { get; set; }
        public String MaNhom { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public Boolean IsLock { get; set; }
        public String TenNhom { get; set; }
        public String TenKho { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }

        public DMTBVTYTNhomKhoHue()
        {
            Makho = "";
            MaNhom = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            MaMay = "";
            Huy = false;
            IsLock = false;
            TenNhom = "";
            TenKho = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            Ordernumber = 0;
        }

        public DMTBVTYTNhomKhoHue(String Makho, String MaNhom, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String MaMay, Boolean Huy, Boolean IsLock, String TenNhom, String TenKho, String TenNguoiLap, String TenNguoiSD, Int32 Ordernumber)
        {
            this.Makho = Makho;
            this.MaNhom = MaNhom;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.IsLock = IsLock;
            this.TenNhom = TenNhom;
            this.TenKho = TenKho;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.Ordernumber = Ordernumber;
        }
        public DMTBVTYTNhomKhoHue(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["Makho"].GetType().Name != "DBNull" && dr["Makho"] != null)
            {
                this.Makho = Convert.ToString(dr["Makho"]);
            }
            else
            {
                this.Makho = "";
            }
            if (dr["MaNhom"].GetType().Name != "DBNull" && dr["MaNhom"] != null)
            {
                this.MaNhom = Convert.ToString(dr["MaNhom"]);
            }
            else
            {
                this.MaNhom = "";
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
            if (dr["IsLock"].GetType().Name != "DBNull" && dr["IsLock"] != null)
            {
                this.IsLock = Convert.ToBoolean(dr["IsLock"]);
            }
            else
            {
                this.IsLock = false;
            }
            if (dr["TenNhom"].GetType().Name != "DBNull" && dr["TenNhom"] != null)
            {
                this.TenNhom = Convert.ToString(dr["TenNhom"]);
            }
            else
            {
                this.TenNhom = "";
            }
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
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
            this.Ordernumber = Ordernumber;
        }

        private String ConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        #region GetAll,Update

        public DMTBVTYTNhomKhoHue GetByMaNhom(String MaNhom)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBVTYTNhomKho_Get", MaNhom)))
            {
                while (dr.Read())
                {
                    return new DMTBVTYTNhomKhoHue(dr, 1);
                }
            }
            return null;
        }

        public List<DMTBVTYTNhomKhoHue> GetAll(Boolean QAdmin)
        {
            List<DMTBVTYTNhomKhoHue> List = new List<DMTBVTYTNhomKhoHue>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTBVTYTNhomKho_GetAll", QAdmin)))
            {
                int order = 1;
                while (dr.Read())
                {
                    List.Add(new DMTBVTYTNhomKhoHue(dr, order));
                }
            }
            return List;
        }

        public string Add()
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spDMTBVTYTNhomKho_Insert", Makho, MaNhom, NguoiLap, MaMay));
        }

        public string Edit(String MakhoCu, String MaNhomCu)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spDMTBVTYTNhomKho_Update", MakhoCu, MaNhomCu, Makho, MaNhom, NguoiSD, MaMay, Huy));
        }

        public string Delete()
        {
            return System.Convert.ToString(SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spDMTBVTYTNhomKho_Delete", Makho, MaNhom, NguoiSD, MaMay));
        }
        #endregion

    }
}
