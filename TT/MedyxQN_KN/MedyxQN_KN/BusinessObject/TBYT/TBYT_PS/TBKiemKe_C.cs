using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBKiemKe_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal KiemKe_CId { get; set; }
        public Decimal KiemKeId { get; set; }
        public Decimal TBYTId { get; set; }
        public String TBYTMaId
        {
            get
            {
                return (TBYTId < 0 ? "HT" : "TB") + Math.Abs(TBYTId).ToString();
            }
        }
        public Decimal SoLuong { get; set; }
        public Decimal DonGia { get; set; }
        public Decimal ThanhTien { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenTBYT { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
        public String TenDVT { get; set; }
        public Decimal TonCK { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }

        public TBKiemKe_C()
        {
            KiemKe_CId = 0;
            KiemKeId = 0;
            TBYTId = 0;
            SoLuong = 0;
            DonGia = 0;
            ThanhTien = 0;
            Ghichu = "";
            MaMay = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenTBYT = "";
            Model = "";
            SerialNo = "";
            TenDVT = "";
            TonCK = 0;
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            Ordernumber = 0;
        }

        public TBKiemKe_C(Decimal KiemKe_CId, Decimal KiemKeId, Decimal TBYTId, Decimal SoLuong, Decimal DonGia, Decimal ThanhTien, String Ghichu, String MaMay, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenTBYT, String Model, String SerialNo, String TenDVT, Decimal TonCK, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 Ordernumber)
        {
            this.KiemKe_CId = KiemKe_CId;
            this.KiemKeId = KiemKeId;
            this.TBYTId = TBYTId;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenTBYT = TenTBYT;
            this.Model = Model;
            this.SerialNo = SerialNo;
            this.TenDVT = TenDVT;
            this.TonCK = TonCK;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.Ordernumber = Ordernumber;
        }

        public TBKiemKe_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["KiemKe_CId"].GetType().Name != "DBNull" && dr["KiemKe_CId"] != null)
            {
                this.KiemKe_CId = Convert.ToDecimal(dr["KiemKe_CId"]);
            }
            else
            {
                this.KiemKe_CId = 0;
            }
            if (dr["KiemKeId"].GetType().Name != "DBNull" && dr["KiemKeId"] != null)
            {
                this.KiemKeId = Convert.ToDecimal(dr["KiemKeId"]);
            }
            else
            {
                this.KiemKeId = 0;
            }
            if (dr["TBYTId"].GetType().Name != "DBNull" && dr["TBYTId"] != null)
            {
                this.TBYTId = Convert.ToDecimal(dr["TBYTId"]);
            }
            else
            {
                this.TBYTId = 0;
            }
            if (dr["SoLuong"].GetType().Name != "DBNull" && dr["SoLuong"] != null)
            {
                this.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
            }
            else
            {
                this.SoLuong = 0;
            }
            if (dr["DonGia"].GetType().Name != "DBNull" && dr["DonGia"] != null)
            {
                this.DonGia = Convert.ToDecimal(dr["DonGia"]);
            }
            else
            {
                this.DonGia = 0;
            }
            if (dr["ThanhTien"].GetType().Name != "DBNull" && dr["ThanhTien"] != null)
            {
                this.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
            }
            else
            {
                this.ThanhTien = 0;
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
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
            {
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            }
            else
            {
                this.TenTBYT = "";
            }
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            {
                this.Model = Convert.ToString(dr["Model"]);
            }
            else
            {
                this.Model = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            {
                this.SerialNo = Convert.ToString(dr["SerialNo"]);
            }
            else
            {
                this.SerialNo = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            {
                this.TenDVT = Convert.ToString(dr["TenDVT"]);
            }
            else
            {
                this.TenDVT = "";
            }
            if (dr["TonCK"].GetType().Name != "DBNull" && dr["TonCK"] != null)
            {
                this.TonCK = Convert.ToDecimal(dr["TonCK"]);
            }
            else
            {
                this.TonCK = 0;
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

        public static TBKiemKe_C GetByMa(Decimal KiemKe_CId)
        {
            TBKiemKe_C obj = new TBKiemKe_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBKiemKe_C_Get", KiemKe_CId))
            {
                while (dr.Read())
                {
                    obj = new TBKiemKe_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public static TBKiemKe_C KhoKhoaGet(String MaKho, DateTime Thang, Byte LoaiPhieu, Decimal TBYTId, String SeriNo)
        {
            TBKiemKe_C obj = new TBKiemKe_C();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBKiemKe_C_KhoKhoaGet", MaKho, Thang, LoaiPhieu, TBYTId, SeriNo))
            {
                while (dr.Read())
                {
                    obj = new TBKiemKe_C(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBKiemKe_C_Create", KiemKeId, TBYTId, SoLuong, Ghichu, MaMay, NguoiLap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBKiemKe_C_Update", KiemKe_CId, KiemKeId, TBYTId, SoLuong, Ghichu, MaMay, Huy, NguoiSD).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBKiemKe_C_Delete", KiemKe_CId, MaMay, NguoiHuy).ToString();
        }
    }
    


    [Serializable()]
    public class TBKiemKe_Cs : List<TBKiemKe_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBKiemKe_Cs GetALL(Decimal KiemKeId, Boolean Qadmin)
        {
            TBKiemKe_Cs obj = new TBKiemKe_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBKiemKe_C_GetAll", KiemKeId, Qadmin))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new TBKiemKe_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }

        public static TBKiemKe_Cs KhoKhoaAll(String MaKho, DateTime Thang, Byte LoaiPhieu)
        {
            TBKiemKe_Cs obj = new TBKiemKe_Cs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBKiemKe_C_KhoKhoaAll", MaKho, Thang, LoaiPhieu))
            {
                int stt = 1;
                while (dr.Read())
                {
                    obj.Add(new TBKiemKe_C(dr, stt));
                    stt++;
                }
            }
            return obj;
        }
        
    }
}