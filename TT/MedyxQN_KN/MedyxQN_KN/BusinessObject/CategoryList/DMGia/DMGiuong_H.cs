using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.Category
{
    [Serializable()]
    public class DMGiuong_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaGiuong { get; set; }
        public String magiuongql { get; set; }
        public String TenGiuong { get; set; }
        public String MaNHOM { get; set; }
        public String TenTA { get; set; }
        public String TenTat { get; set; }
        public Nullable<Decimal> DongiaTT { get; set; }
        public Nullable<Decimal> DongiaTT1 { get; set; }
        public Nullable<DateTime> NgayTT1 { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public Nullable<DateTime> NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public Nullable<DateTime> NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public Nullable<DateTime> NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Nullable<Boolean> Huy { get; set; }
        public Nullable<DateTime> NgaySD1 { get; set; }
        public String NguoiSD1 { get; set; }
        public Nullable<Boolean> ADGiaUSD { get; set; }
        public Nullable<DateTime> NgayGia { get; set; }
        public Nullable<Boolean> ApdungGoi { get; set; }
        public Nullable<Decimal> HoaHong { get; set; }
        public Nullable<Decimal> GTHoaHong { get; set; }
        public Nullable<Boolean> BCThu { get; set; }
        public Nullable<Boolean> InThu { get; set; }
        public String TenGiuongBH { get; set; }
        public Nullable<Decimal> DonGiaCLC { get; set; }
        public String MaBYTe { get; set; }
        public String QuyetDinh { get; set; }
        public String TENNHOM { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }
        public Nullable<Decimal> DongiaBH { get; set; }
        public Nullable<Decimal> GiaChenhlech { get; set; }
        public Nullable<Boolean> ADChenhlech { get; set; }
        public Nullable<Boolean> DTBH { get; set; }

        public DMGiuong_H()
        {
            MaGiuong = "";
            magiuongql = "";
            TenGiuong = "";
            MaNHOM = "";
            TenTA = "";
            TenTat = "";
            DongiaTT = new Nullable<Decimal>();
            DongiaTT1 = new Nullable<Decimal>();
            NgayTT1 = new Nullable<DateTime>();
            Ghichu = "";
            MaMay = "";
            NgayHuy = new Nullable<DateTime>();
            NguoiHuy = "";
            NgayLap = new Nullable<DateTime>();
            NguoiLap = "";
            NgaySD = new Nullable<DateTime>();
            NguoiSD = "";
            Huy = new Nullable<Boolean>();
            NgaySD1 = new Nullable<DateTime>();
            NguoiSD1 = "";
            ADGiaUSD = new Nullable<Boolean>();
            NgayGia = new Nullable<DateTime>();
            ApdungGoi = new Nullable<Boolean>();
            HoaHong = new Nullable<Decimal>();
            GTHoaHong = new Nullable<Decimal>();
            BCThu = new Nullable<Boolean>();
            InThu = new Nullable<Boolean>();
            TenGiuongBH = "";
            DonGiaCLC = new Nullable<Decimal>();
            MaBYTe = "";
            QuyetDinh = "";
            TENNHOM = "";
            TENNGUOILAP = "";
            TENNGUOISD = "";
            TENNGUOIHUY = "";
            DongiaBH = new Nullable<Decimal>();
            GiaChenhlech = new Nullable<Decimal>();
            ADChenhlech = new Nullable<Boolean>();
            DTBH = new Nullable<Boolean>();
            Ordernumber = 0;
        }
        public DMGiuong_H(String MaGiuong, String magiuongql, String TenGiuong, String MaNHOM, String TenTA, String TenTat, Nullable<Decimal> DongiaTT, Nullable<Decimal> DongiaTT1, Nullable<DateTime> NgayTT1, String Ghichu, String MaMay, Nullable<DateTime> NgayHuy, String NguoiHuy, Nullable<DateTime> NgayLap, String NguoiLap, Nullable<DateTime> NgaySD, String NguoiSD, Nullable<Boolean> Huy, Nullable<DateTime> NgaySD1, String NguoiSD1, Nullable<Boolean> ADGiaUSD, Nullable<DateTime> NgayGia, Nullable<Boolean> ApdungGoi, Nullable<Decimal> HoaHong, Nullable<Decimal> GTHoaHong, Nullable<Boolean> BCThu, Nullable<Boolean> InThu, String TenGiuongBH, Nullable<Decimal> DonGiaCLC, String MaBYTe, String QuyetDinh, String TENNHOM, String TENNGUOILAP, String TENNGUOISD, String TENNGUOIHUY, Nullable<Decimal> DongiaBH, Nullable<Decimal> GiaChenhlech, Nullable<Boolean> ADChenhlech, Nullable<Boolean> DTBH, Int32 Ordernumber)
        {
            this.MaGiuong = MaGiuong;
            this.magiuongql = magiuongql;
            this.TenGiuong = TenGiuong;
            this.MaNHOM = MaNHOM;
            this.TenTA = TenTA;
            this.TenTat = TenTat;
            this.DongiaTT = DongiaTT;
            this.DongiaTT1 = DongiaTT1;
            this.NgayTT1 = NgayTT1;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.NgaySD1 = NgaySD1;
            this.NguoiSD1 = NguoiSD1;
            this.ADGiaUSD = ADGiaUSD;
            this.NgayGia = NgayGia;
            this.ApdungGoi = ApdungGoi;
            this.HoaHong = HoaHong;
            this.GTHoaHong = GTHoaHong;
            this.BCThu = BCThu;
            this.InThu = InThu;
            this.TenGiuongBH = TenGiuongBH;
            this.DonGiaCLC = DonGiaCLC;
            this.MaBYTe = MaBYTe;
            this.QuyetDinh = QuyetDinh;
            this.TENNHOM = TENNHOM;
            this.TENNGUOILAP = TENNGUOILAP;
            this.TENNGUOISD = TENNGUOISD;
            this.TENNGUOIHUY = TENNGUOIHUY;
            this.DongiaBH = DongiaBH;
            this.GiaChenhlech = GiaChenhlech;
            this.ADChenhlech = ADChenhlech;
            this.DTBH = DTBH;
            this.Ordernumber = Ordernumber;
        }
        public DMGiuong_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaGiuong"].GetType().Name != "DBNull" && dr["MaGiuong"] != null)
            {
                this.MaGiuong = Convert.ToString(dr["MaGiuong"]);
            }
            else
            {
                this.MaGiuong = "";
            }
            if (dr["magiuongql"].GetType().Name != "DBNull" && dr["magiuongql"] != null)
            {
                this.magiuongql = Convert.ToString(dr["magiuongql"]);
            }
            else
            {
                this.magiuongql = "";
            }
            if (dr["TenGiuong"].GetType().Name != "DBNull" && dr["TenGiuong"] != null)
            {
                this.TenGiuong = Convert.ToString(dr["TenGiuong"]);
            }
            else
            {
                this.TenGiuong = "";
            }
            if (dr["MaNHOM"].GetType().Name != "DBNull" && dr["MaNHOM"] != null)
            {
                this.MaNHOM = Convert.ToString(dr["MaNHOM"]);
            }
            else
            {
                this.MaNHOM = "";
            }
            if (dr["TenTA"].GetType().Name != "DBNull" && dr["TenTA"] != null)
            {
                this.TenTA = Convert.ToString(dr["TenTA"]);
            }
            else
            {
                this.TenTA = "";
            }
            if (dr["TenTat"].GetType().Name != "DBNull" && dr["TenTat"] != null)
            {
                this.TenTat = Convert.ToString(dr["TenTat"]);
            }
            else
            {
                this.TenTat = "";
            }
            if (dr["DongiaTT"].GetType().Name != "DBNull" && dr["DongiaTT"] != null)
            {
                this.DongiaTT = Convert.ToDecimal(dr["DongiaTT"]);
            }
            else
            {
                this.DongiaTT = new Nullable<Decimal>();
            }
            if (dr["DongiaTT1"].GetType().Name != "DBNull" && dr["DongiaTT1"] != null)
            {
                this.DongiaTT1 = Convert.ToDecimal(dr["DongiaTT1"]);
            }
            else
            {
                this.DongiaTT1 = new Nullable<Decimal>();
            }
            if (dr["NgayTT1"].GetType().Name != "DBNull" && dr["NgayTT1"] != null)
            {
                this.NgayTT1 = Convert.ToDateTime(dr["NgayTT1"]);
            }
            else
            {
                this.NgayTT1 = new Nullable<DateTime>();
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
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]);
            }
            else
            {
                this.NgayHuy = new Nullable<DateTime>();
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            {
                this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            }
            else
            {
                this.NguoiHuy = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]);
            }
            else
            {
                this.NgayLap = new Nullable<DateTime>();
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
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]);
            }
            else
            {
                this.NgaySD = new Nullable<DateTime>();
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
                this.Huy = new Nullable<Boolean>();
            }
            if (dr["NgaySD1"].GetType().Name != "DBNull" && dr["NgaySD1"] != null)
            {
                this.NgaySD1 = Convert.ToDateTime(dr["NgaySD1"]);
            }
            else
            {
                this.NgaySD1 = new Nullable<DateTime>();
            }
            if (dr["NguoiSD1"].GetType().Name != "DBNull" && dr["NguoiSD1"] != null)
            {
                this.NguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
            }
            else
            {
                this.NguoiSD1 = "";
            }
            if (dr["ADGiaUSD"].GetType().Name != "DBNull" && dr["ADGiaUSD"] != null)
            {
                this.ADGiaUSD = Convert.ToBoolean(dr["ADGiaUSD"]);
            }
            else
            {
                this.ADGiaUSD = new Nullable<Boolean>();
            }
            if (dr["NgayGia"].GetType().Name != "DBNull" && dr["NgayGia"] != null)
            {
                this.NgayGia = Convert.ToDateTime(dr["NgayGia"]);
            }
            else
            {
                this.NgayGia = new Nullable<DateTime>();
            }
            if (dr["ApdungGoi"].GetType().Name != "DBNull" && dr["ApdungGoi"] != null)
            {
                this.ApdungGoi = Convert.ToBoolean(dr["ApdungGoi"]);
            }
            else
            {
                this.ApdungGoi = new Nullable<Boolean>();
            }
            if (dr["HoaHong"].GetType().Name != "DBNull" && dr["HoaHong"] != null)
            {
                this.HoaHong = Convert.ToDecimal(dr["HoaHong"]);
            }
            else
            {
                this.HoaHong = new Nullable<Decimal>();
            }
            if (dr["GTHoaHong"].GetType().Name != "DBNull" && dr["GTHoaHong"] != null)
            {
                this.GTHoaHong = Convert.ToDecimal(dr["GTHoaHong"]);
            }
            else
            {
                this.GTHoaHong = new Nullable<Decimal>();
            }
            if (dr["BCThu"].GetType().Name != "DBNull" && dr["BCThu"] != null)
            {
                this.BCThu = Convert.ToBoolean(dr["BCThu"]);
            }
            else
            {
                this.BCThu = new Nullable<Boolean>();
            }
            if (dr["InThu"].GetType().Name != "DBNull" && dr["InThu"] != null)
            {
                this.InThu = Convert.ToBoolean(dr["InThu"]);
            }
            else
            {
                this.InThu = new Nullable<Boolean>();
            }
            if (dr["TenGiuongBH"].GetType().Name != "DBNull" && dr["TenGiuongBH"] != null)
            {
                this.TenGiuongBH = Convert.ToString(dr["TenGiuongBH"]);
            }
            else
            {
                this.TenGiuongBH = "";
            }
            if (dr["DonGiaCLC"].GetType().Name != "DBNull" && dr["DonGiaCLC"] != null)
            {
                this.DonGiaCLC = Convert.ToDecimal(dr["DonGiaCLC"]);
            }
            else
            {
                this.DonGiaCLC = new Nullable<Decimal>();
            }
            if (dr["MaBYTe"].GetType().Name != "DBNull" && dr["MaBYTe"] != null)
            {
                this.MaBYTe = Convert.ToString(dr["MaBYTe"]);
            }
            else
            {
                this.MaBYTe = "";
            }
            if (dr["QuyetDinh"].GetType().Name != "DBNull" && dr["QuyetDinh"] != null)
            {
                this.QuyetDinh = Convert.ToString(dr["QuyetDinh"]);
            }
            else
            {
                this.QuyetDinh = "";
            }
            if (dr["TENNHOM"].GetType().Name != "DBNull" && dr["TENNHOM"] != null)
            {
                this.TENNHOM = Convert.ToString(dr["TENNHOM"]);
            }
            else
            {
                this.TENNHOM = "";
            }
            if (dr["TENNGUOILAP"].GetType().Name != "DBNull" && dr["TENNGUOILAP"] != null)
            {
                this.TENNGUOILAP = Convert.ToString(dr["TENNGUOILAP"]);
            }
            else
            {
                this.TENNGUOILAP = "";
            }
            if (dr["TENNGUOISD"].GetType().Name != "DBNull" && dr["TENNGUOISD"] != null)
            {
                this.TENNGUOISD = Convert.ToString(dr["TENNGUOISD"]);
            }
            else
            {
                this.TENNGUOISD = "";
            }
            if (dr["TENNGUOIHUY"].GetType().Name != "DBNull" && dr["TENNGUOIHUY"] != null)
            {
                this.TENNGUOIHUY = Convert.ToString(dr["TENNGUOIHUY"]);
            }
            else
            {
                this.TENNGUOIHUY = "";
            }
            if (dr["DongiaBH"].GetType().Name != "DBNull" && dr["DongiaBH"] != null)
            {
                this.DongiaBH = Convert.ToDecimal(dr["DongiaBH"]);
            }
            else
            {
                this.DongiaBH = new Nullable<Decimal>();
            }
            if (dr["GiaChenhlech"].GetType().Name != "DBNull" && dr["GiaChenhlech"] != null)
            {
                this.GiaChenhlech = Convert.ToDecimal(dr["GiaChenhlech"]);
            }
            else
            {
                this.GiaChenhlech = new Nullable<Decimal>();
            }
            if (dr["ADChenhlech"].GetType().Name != "DBNull" && dr["ADChenhlech"] != null)
            {
                this.ADChenhlech = Convert.ToBoolean(dr["ADChenhlech"]);
            }
            else
            {
                this.ADChenhlech = new Nullable<Boolean>();
            }
            if (dr["DTBH"].GetType().Name != "DBNull" && dr["DTBH"] != null)
            {
                this.DTBH = Convert.ToBoolean(dr["DTBH"]);
            }
            else
            {
                this.DTBH = new Nullable<Boolean>();
            }
            this.Ordernumber = Ordernumber;
        }
    }

    [Serializable()]
    public class DMGiuong_HList : List<DMGiuong_H>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMGiuong_HList FindDMGiuongByMa(String Ma, Boolean QAdmin)
        {
            Ma = " (A.MaGiuong like N'%" + Ma + "%' or A.TENTAT like N'%" + Ma + "%')";
            DMGiuong_HList List = new DMGiuong_HList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMGiuong_FINDS_Hue", Ma, QAdmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMGiuong_H(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
