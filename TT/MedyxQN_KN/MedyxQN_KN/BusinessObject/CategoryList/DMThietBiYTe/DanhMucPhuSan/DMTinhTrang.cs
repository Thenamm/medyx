using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace HTC.Business.CategoryList.DanhMucPhuSan
{
    [Serializable()]
    public class  DMTinhTrang
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String MaTinhTrang { get; set; }
        public String TenTinhTrang { get; set; }
        public Byte Loai { get; set; }
        public String GhiChu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public  DMTinhTrang()
        {
            MaTinhTrang = "";
            TenTinhTrang = "";
            Loai = 0;
            GhiChu = "";
            MaMay = "";
            Huy = false;
            NgaySD = "";
            NguoiSD = "";
            Ordernumber = 0;
        }

        public  DMTinhTrang(String MaTinhTrang, String TenTinhTrang, Byte Loai, String GhiChu, String MaMay, Boolean Huy, String NgaySD, String NguoiSD, Int32 Ordernumber)
        {
            this.MaTinhTrang = MaTinhTrang;
            this.TenTinhTrang = TenTinhTrang;
            this.Loai = Loai;
            this.GhiChu = GhiChu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Ordernumber = Ordernumber;
        }
        public  DMTinhTrang(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaTinhTrang"].GetType().Name != "DBNull" && dr["MaTinhTrang"] != null)
            {
                this.MaTinhTrang = Convert.ToString(dr["MaTinhTrang"]);
            }
            else
            {
                this.MaTinhTrang = "";
            }
            if (dr["TenTinhTrang"].GetType().Name != "DBNull" && dr["TenTinhTrang"] != null)
            {
                this.TenTinhTrang = Convert.ToString(dr["TenTinhTrang"]);
            }
            else
            {
                this.TenTinhTrang = "";
            }
            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
            {
                this.Loai = Convert.ToByte(dr["Loai"]);
            }
            else
            {
                this.Loai = 0;
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
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
            this.Ordernumber = Ordernumber;
        }
    }

    [Serializable()]
    public class  DMTinhTrangList : List< DMTinhTrang>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static  DMTinhTrangList GetAll(Byte loai)
        {
             DMTinhTrangList ListItems = new  DMTinhTrangList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spDMTinhTrang_GetAll", loai)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    ListItems.Add(new  DMTinhTrang(dr, order));
                }
            }
            return ListItems;
        }
    }
}
