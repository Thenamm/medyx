using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMGiuong_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public String MaKhoa { get; set; }
        public String SoGiuongTT { get; set; }
        public String SoGiuongBH { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenKhoa { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String SoPhong { get; set; }
        public DMGiuong_C()
        {
            MaKhoa = "";
            SoGiuongTT = "";
            SoGiuongBH = "";
            Ghichu = "";
            MaMay = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            NgayHuy = "";
            NguoiHuy = "";
            TenKhoa = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            SoPhong = "";
            Ordernumber = 0;
        }

        public DMGiuong_C(String MaKhoa, String SoGiuongTT, String SoGiuongBH, String Ghichu, String MaMay, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String NgayHuy, String NguoiHuy, String TenKhoa, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String SoPhong, Int32 Ordernumber)
        {
            this.MaKhoa = MaKhoa;
            this.SoGiuongTT = SoGiuongTT;
            this.SoGiuongBH = SoGiuongBH;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenKhoa = TenKhoa;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.SoPhong = SoPhong;
            this.Ordernumber = Ordernumber;
        }
        public DMGiuong_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaKhoa"].GetType().Name != "DBNull" && dr["MaKhoa"] != null)
            {
                this.MaKhoa = Convert.ToString(dr["MaKhoa"]);
            }
            else
            {
                this.MaKhoa = "";
            }
            if (dr["SoGiuongTT"].GetType().Name != "DBNull" && dr["SoGiuongTT"] != null)
            {
                this.SoGiuongTT = Convert.ToString(dr["SoGiuongTT"]);
            }
            else
            {
                this.SoGiuongTT = "";
            }
            if (dr["SoGiuongBH"].GetType().Name != "DBNull" && dr["SoGiuongBH"] != null)
            {
                this.SoGiuongBH = Convert.ToString(dr["SoGiuongBH"]);
            }
            else
            {
                this.SoGiuongBH = "";
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
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
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
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
            
            if (dr["TenKhoa"].GetType().Name != "DBNull" && dr["TenKhoa"] != null)
            {
                this.TenKhoa = Convert.ToString(dr["TenKhoa"]);
            }
            else
            {
                this.TenKhoa = "";
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
            if (dr["SoPhong"].GetType().Name != "DBNull" && dr["SoPhong"] != null)
            {
                this.SoPhong = Convert.ToString(dr["SoPhong"]);
            }
            else
            {
                this.SoPhong = "";
            }
            this.Ordernumber = Ordernumber;
        }

        public static DMGiuong_C Get(String MaKhoa, String SoGiuongTT)
        {
            DMGiuong_C obj = new DMGiuong_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMGiuong_C_Get", MaKhoa, SoGiuongTT))
            {
                while (dr.Read())
                {
                    obj = new DMGiuong_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMGiuong_C_Insert", MaKhoa, SoGiuongTT, SoGiuongBH, Ghichu, MaMay, NguoiLap, SoPhong).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMGiuong_C_Update", MaKhoa, SoGiuongTT, SoGiuongBH, Ghichu, MaMay, NguoiSD, Huy, SoPhong).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMGiuong_C_Delete", MaKhoa, SoGiuongTT, MaMay, NguoiHuy).ToString();
        }
    }

    [Serializable()]
    public class DMGiuong_Cs : List<DMGiuong_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static DMGiuong_Cs Find(String MaKhoa, String DK, Boolean Qadmin)
        {
            DMGiuong_Cs obj = new DMGiuong_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMGiuong_C_Find", MaKhoa, DK, Qadmin))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new DMGiuong_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }
        
    }

}