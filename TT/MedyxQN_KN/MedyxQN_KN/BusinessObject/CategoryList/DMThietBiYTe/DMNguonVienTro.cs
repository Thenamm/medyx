using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HTC.BusinessObject.CategoryList
{
    [Serializable()]
    public class DMNguonVienTro
    {
        public int Ordernumber;
        public String MaNguon{get; set;}
        public String TenNguon { get; set; }
        public String TenTA { get; set; }
        public Boolean VienTro { get; set; }
        public Boolean KhongSD { get; set; }
        public String GhiChu { get; set; }
        public String MaMay { get; set; }
        public Byte Loai { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }

        public DMNguonVienTro()
        {
            MaNguon = string.Empty;
            TenNguon = string.Empty;
            TenTA = string.Empty;
            VienTro = false;
            KhongSD = false;
            GhiChu = string.Empty;
            MaMay = string.Empty;
            Loai = 0;
            Huy = false;
            NgayLap = "";
            NguoiLap = string.Empty;
            NgaySD = "";
            NguoiSD = string.Empty;
            TenNguoiLap = string.Empty;
            TenNguoiSD = string.Empty;
        }

        public DMNguonVienTro(IDataReader dr, int Ordernumber)
		{
            this.Ordernumber = Ordernumber;
            if (dr["MaNguon"] != null && dr["MaNguon"].GetType().Name != "DBNull") MaNguon = Convert.ToString(dr["MaNguon"]);
            if (dr["TenNguon"] != null && dr["TenNguon"].GetType().Name != "DBNull") TenNguon = Convert.ToString(dr["TenNguon"]);
            if (dr["TenTA"] != null && dr["TenTA"].GetType().Name != "DBNull") TenTA = Convert.ToString(dr["TenTA"]);
            if (dr["VienTro"] != null && dr["VienTro"].GetType().Name != "DBNull") VienTro = Convert.ToBoolean(dr["VienTro"]);
            if (dr["KhongSD"] != null && dr["KhongSD"].GetType().Name != "DBNull") KhongSD = Convert.ToBoolean(dr["KhongSD"]);
            if (dr["GhiChu"] != null && dr["GhiChu"].GetType().Name != "DBNull") GhiChu = Convert.ToString(dr["GhiChu"]);
			if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") MaMay = Convert.ToString(dr["MaMay"]);
            if (dr["Loai"] != null && dr["Loai"].GetType().Name != "DBNull") Loai = Convert.ToByte(dr["Loai"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") Huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") NguoiLap = Convert.ToString(dr["NguoiLap"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") NguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["TenNguoiLap"] != null && dr["TenNguoiLap"].GetType().Name != "DBNull") TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            if (dr["TenNguoiSD"] != null && dr["TenNguoiSD"].GetType().Name != "DBNull") TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
		}

        #region GetAll,Update
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMNguonVienTro GetByMaNguon(String MaNguon)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNguonVienTro_Get", MaNguon)))
            {
                while (dr.Read())
                {
                    return new DMNguonVienTro(dr, 1);
                }
            }
            return null;
        }

        public static List<DMNguonVienTro> GetAll(Byte Loai, Boolean QAdmin)
        {
            List<DMNguonVienTro>  List = new List<DMNguonVienTro>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNguonVienTro_GetAll", Loai, QAdmin)))
            {
                int order = 1;
                while (dr.Read())
                {
                    List.Add(new DMNguonVienTro(dr, order));
                }
            }
            return List;
        }

        public static List<DMNguonVienTro> Finds(String DK, Boolean QAdmin)
        {
            List<DMNguonVienTro>  List = new List<DMNguonVienTro>();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMNguonVienTro_FINDS", DK, QAdmin)))
            {
                int order = 1;
                while (dr.Read())
                {
                    List.Add(new DMNguonVienTro(dr, order));
                }
            }
            return List;
        }


        public static string Add(String TenNguon, String TenTA, Boolean VienTro, Boolean KhongSD, String GhiChu, String MaMay, Byte Loai, String NguoiLap)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spDMNguonVienTro_CREATE", TenNguon, TenTA, VienTro, KhongSD, GhiChu, MaMay, Loai, NguoiLap));
        }

        public static string Edit(String MaNguon, String TenNguon, String TenTA, Boolean VienTro, Boolean KhongSD, String GhiChu, String MaMay, Byte Loai, Boolean Huy, String NguoiSD)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spDMNguonVienTro_UPDATED", MaNguon, TenNguon, TenTA, VienTro, KhongSD, GhiChu, MaMay, Loai, Huy, NguoiSD));
        }

        public static void Delete(String MaNguon, String MaMay, String NguoiHuy)
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spDMNguonVienTro_DELETED", MaNguon, MaMay, NguoiHuy);
        }
        #endregion
    }    
}
