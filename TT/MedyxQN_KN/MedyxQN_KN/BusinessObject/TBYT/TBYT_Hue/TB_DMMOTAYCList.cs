using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class TB_DMMOTAYC
    {
        public Int32 Ordernumber { get; set; }
        public Int32 MaMoTaYC { get; set; }
        public String MotaYC { get; set; }
        public String TenTA { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public String NgayNhap { get; set; }
        public String NguoiNhap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String TenNguoiNhap { get; set; }
        public String TenNguoiSD { get; set; }
        public TB_DMMOTAYC()
        {
            MaMoTaYC = 0;
            MotaYC = "";
            TenTA = "";
            Ghichu = "";
            MaMay = "";
            NgayNhap = "";
            NguoiNhap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            TenNguoiNhap = "";
            TenNguoiSD = "";
            Ordernumber = 0;
        }
        public TB_DMMOTAYC(Int32 MaMoTaYC, String MotaYC, String TenTA, String Ghichu, String MaMay, String NgayNhap, String NguoiNhap, String NgaySD, String NguoiSD, Boolean Huy, String TenNguoiNhap, String TenNguoiSD, Int32 Ordernumber)
        {
            this.MaMoTaYC = MaMoTaYC;
            this.MotaYC = MotaYC;
            this.TenTA = TenTA;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.NgayNhap = NgayNhap;
            this.NguoiNhap = NguoiNhap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.TenNguoiNhap = TenNguoiNhap;
            this.TenNguoiSD = TenNguoiSD;
            this.Ordernumber = Ordernumber;
        }
        public TB_DMMOTAYC(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaMoTaYC"].GetType().Name != "DBNull" && dr["MaMoTaYC"] != null)
                this.MaMoTaYC = Convert.ToInt32(dr["MaMoTaYC"]);
            if (dr["MotaYC"].GetType().Name != "DBNull" && dr["MotaYC"] != null)
                this.MotaYC = Convert.ToString(dr["MotaYC"]);
            if (dr["TenTA"].GetType().Name != "DBNull" && dr["TenTA"] != null)
                this.TenTA = Convert.ToString(dr["TenTA"]);
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
                this.MaMay = Convert.ToString(dr["MaMay"]);
            if (dr["NgayNhap"].GetType().Name != "DBNull" && dr["NgayNhap"] != null)
                this.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiNhap"].GetType().Name != "DBNull" && dr["NguoiNhap"] != null)
                this.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
                this.Huy = Convert.ToBoolean(dr["Huy"]);
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

        public static TB_DMMOTAYC Get(int Ma)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTB_DMMOTAYC_Get", Ma)))
            {
                while (dr.Read())
                {
                    return new TB_DMMOTAYC(dr, 0);
                }
            }
            return null;
        }

        /// <summary>
        /// Thêm mô tả yêu cầu
        /// yêu cầu phải có MotaYC, MaMay, NguoiNhap
        /// </summary>
        public String Insert()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString,"dbo.spTB_DMMOTAYC_INSERT", MotaYC, TenTA, Ghichu, MaMay, NguoiNhap));
        }

        /// <summary>
        /// Cập nhật lại mô tả yêu cầu
        /// Yêu cầu phải có MaMoTaYC, MotaYC, MaMay, NguoiSD
        /// </summary>
        /// <returns></returns>
        public String Update()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTB_DMMOTAYC_UPDATE", MaMoTaYC, MotaYC, TenTA, Ghichu, MaMay, NguoiSD, Huy));
        }
         
        /// <summary>
        ///  xóa dữ liệu
        ///  Yêu cầu phải có MaMoTaYC, MaMay, NguoiSD
        /// </summary>
        public void Delete()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTB_DMMOTAYC_DELETE", MaMoTaYC, MaMay, NguoiSD);
        }
    }

    [Serializable()]
    public class TB_DMMOTAYCList: List<TB_DMMOTAYC>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TB_DMMOTAYCList()
        {
            
        }

        public static TB_DMMOTAYCList GetAll(int BatDau, int KetThuc, Boolean bQuyen)
        {

            TB_DMMOTAYCList List = new TB_DMMOTAYCList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTB_DMMOTAYC_GetAll", BatDau, KetThuc, bQuyen))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TB_DMMOTAYC(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
