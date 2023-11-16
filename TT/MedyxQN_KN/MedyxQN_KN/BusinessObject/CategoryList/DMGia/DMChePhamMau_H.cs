using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.Category
{
    [Serializable]
    public class DMChePhamMau_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaCPMau { get; set; }
        public String TenCPMau { get; set; }
        public String TenTA { get; set; }
        public String Ghichu { get; set; }
        public String MaNhom { get; set; }
        public String Hamluong { get; set; }
        public Nullable<Decimal> Nguong { get; set; }
        public String MaDVT { get; set; }
        public Nullable<Decimal> DongiaTT { get; set; }
        public Nullable<Decimal> DongiaTT1 { get; set; }
        public Nullable<Boolean> ApDungGoi { get; set; }
        public Nullable<Decimal> Gianhap { get; set; }
        public Nullable<Decimal> Gianhap1 { get; set; }
        public Nullable<Decimal> Gianhap2 { get; set; }
        public Nullable<DateTime> Ngaynhap { get; set; }
        public Nullable<DateTime> Ngaynhap1 { get; set; }
        public Nullable<DateTime> Ngaynhap2 { get; set; }
        public String Makho { get; set; }
        public Nullable<Boolean> Huy { get; set; }
        public String MaMay { get; set; }
        public Nullable<DateTime> NgaySD { get; set; }
        public Nullable<DateTime> NgaySD1 { get; set; }
        public String NguoiSD { get; set; }
        public String NguoiSD1 { get; set; }
        public String MaDVTHL { get; set; }
        public Nullable<Boolean> HanDung { get; set; }
        public Nullable<DateTime> NgayGia { get; set; }
        public String MaChungLoai { get; set; }
        public Nullable<DateTime> NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String MaLH { get; set; }
        public Nullable<Boolean> KhongSD { get; set; }
        public String TenTat { get; set; }
        public String QuyCach { get; set; }
        public String MaNSX { get; set; }
        public String MaBYTe { get; set; }
        public String QuyetDinh { get; set; }
        public String TenCPMauBH { get; set; }
        public String TENNHOM { get; set; }
        public String TENDVT { get; set; }
        public String TENKHO { get; set; }
        public String hoten { get; set; }
        public String TENDVTHL { get; set; }
        public Nullable<Decimal> DongiaBH { get; set; }
        public Nullable<Decimal> GiaChenhlech { get; set; }
        public Nullable<Boolean> ADChenhlech { get; set; }
        public Nullable<Boolean> DTBH { get; set; }

        public DMChePhamMau_H()
        {
            MaCPMau = "";
            TenCPMau = "";
            TenTA = "";
            Ghichu = "";
            MaNhom = "";
            Hamluong = "";
            Nguong = new Nullable<Decimal>();
            MaDVT = "";
            DongiaTT = new Nullable<Decimal>();
            DongiaTT1 = new Nullable<Decimal>();
            ApDungGoi = new Nullable<Boolean>();
            Gianhap = new Nullable<Decimal>();
            Gianhap1 = new Nullable<Decimal>();
            Gianhap2 = new Nullable<Decimal>();
            Ngaynhap = new Nullable<DateTime>();
            Ngaynhap1 = new Nullable<DateTime>();
            Ngaynhap2 = new Nullable<DateTime>();
            Makho = "";
            Huy = new Nullable<Boolean>();
            MaMay = "";
            NgaySD = new Nullable<DateTime>();
            NgaySD1 = new Nullable<DateTime>();
            NguoiSD = "";
            NguoiSD1 = "";
            MaDVTHL = "";
            HanDung = new Nullable<Boolean>();
            NgayGia = new Nullable<DateTime>();
            MaChungLoai = "";
            NgayHuy = new Nullable<DateTime>();
            NguoiHuy = "";
            MaLH = "";
            KhongSD = new Nullable<Boolean>();
            TenTat = "";
            QuyCach = "";
            MaNSX = "";
            MaBYTe = "";
            QuyetDinh = "";
            TenCPMauBH = "";
            TENNHOM = "";
            TENDVT = "";
            TENKHO = "";
            hoten = "";
            TENDVTHL = "";
            DongiaBH = new Nullable<Decimal>();
            GiaChenhlech = new Nullable<Decimal>();
            ADChenhlech = new Nullable<Boolean>();
            DTBH = new Nullable<Boolean>();
            Ordernumber = 0;
        }

        public DMChePhamMau_H(String MaCPMau, String TenCPMau, String TenTA, String Ghichu, String MaNhom, String Hamluong, Nullable<Decimal> Nguong, String MaDVT, Nullable<Decimal> DongiaTT, Nullable<Decimal> DongiaTT1, Nullable<Boolean> ApDungGoi, Nullable<Decimal> Gianhap, Nullable<Decimal> Gianhap1, Nullable<Decimal> Gianhap2, Nullable<DateTime> Ngaynhap, Nullable<DateTime> Ngaynhap1, Nullable<DateTime> Ngaynhap2, String Makho, Nullable<Boolean> Huy, String MaMay, Nullable<DateTime> NgaySD, Nullable<DateTime> NgaySD1, String NguoiSD, String NguoiSD1, String MaDVTHL, Nullable<Boolean> HanDung, Nullable<DateTime> NgayGia, String MaChungLoai, Nullable<DateTime> NgayHuy, String NguoiHuy, String MaLH, Nullable<Boolean> KhongSD, String TenTat, String QuyCach, String MaNSX, String MaBYTe, String QuyetDinh, String TenCPMauBH, String TENNHOM, String TENDVT, String TENKHO, String hoten, String TENDVTHL, Nullable<Decimal> DongiaBH, Nullable<Decimal> GiaChenhlech, Nullable<Boolean> ADChenhlech, Nullable<Boolean> DTBH, Int32 Ordernumber)
        {
            this.MaCPMau = MaCPMau;
            this.TenCPMau = TenCPMau;
            this.TenTA = TenTA;
            this.Ghichu = Ghichu;
            this.MaNhom = MaNhom;
            this.Hamluong = Hamluong;
            this.Nguong = Nguong;
            this.MaDVT = MaDVT;
            this.DongiaTT = DongiaTT;
            this.DongiaTT1 = DongiaTT1;
            this.ApDungGoi = ApDungGoi;
            this.Gianhap = Gianhap;
            this.Gianhap1 = Gianhap1;
            this.Gianhap2 = Gianhap2;
            this.Ngaynhap = Ngaynhap;
            this.Ngaynhap1 = Ngaynhap1;
            this.Ngaynhap2 = Ngaynhap2;
            this.Makho = Makho;
            this.Huy = Huy;
            this.MaMay = MaMay;
            this.NgaySD = NgaySD;
            this.NgaySD1 = NgaySD1;
            this.NguoiSD = NguoiSD;
            this.NguoiSD1 = NguoiSD1;
            this.MaDVTHL = MaDVTHL;
            this.HanDung = HanDung;
            this.NgayGia = NgayGia;
            this.MaChungLoai = MaChungLoai;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.MaLH = MaLH;
            this.KhongSD = KhongSD;
            this.TenTat = TenTat;
            this.QuyCach = QuyCach;
            this.MaNSX = MaNSX;
            this.MaBYTe = MaBYTe;
            this.QuyetDinh = QuyetDinh;
            this.TenCPMauBH = TenCPMauBH;
            this.TENNHOM = TENNHOM;
            this.TENDVT = TENDVT;
            this.TENKHO = TENKHO;
            this.hoten = hoten;
            this.TENDVTHL = TENDVTHL;
            this.DongiaBH = DongiaBH;
            this.GiaChenhlech = GiaChenhlech;
            this.ADChenhlech = ADChenhlech;
            this.DTBH = DTBH;
            this.Ordernumber = Ordernumber;
        }
        public DMChePhamMau_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaCPMau"].GetType().Name != "DBNull" && dr["MaCPMau"] != null)
            {
                this.MaCPMau = Convert.ToString(dr["MaCPMau"]);
            }
            else
            {
                this.MaCPMau = "";
            }
            if (dr["TenCPMau"].GetType().Name != "DBNull" && dr["TenCPMau"] != null)
            {
                this.TenCPMau = Convert.ToString(dr["TenCPMau"]);
            }
            else
            {
                this.TenCPMau = "";
            }
            if (dr["TenTA"].GetType().Name != "DBNull" && dr["TenTA"] != null)
            {
                this.TenTA = Convert.ToString(dr["TenTA"]);
            }
            else
            {
                this.TenTA = "";
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = "";
            }
            if (dr["MaNhom"].GetType().Name != "DBNull" && dr["MaNhom"] != null)
            {
                this.MaNhom = Convert.ToString(dr["MaNhom"]);
            }
            else
            {
                this.MaNhom = "";
            }
            if (dr["Hamluong"].GetType().Name != "DBNull" && dr["Hamluong"] != null)
            {
                this.Hamluong = Convert.ToString(dr["Hamluong"]);
            }
            else
            {
                this.Hamluong = "";
            }
            if (dr["Nguong"].GetType().Name != "DBNull" && dr["Nguong"] != null)
            {
                this.Nguong = Convert.ToDecimal(dr["Nguong"]);
            }
            else
            {
                this.Nguong = new Nullable<Decimal>();
            }
            if (dr["MaDVT"].GetType().Name != "DBNull" && dr["MaDVT"] != null)
            {
                this.MaDVT = Convert.ToString(dr["MaDVT"]);
            }
            else
            {
                this.MaDVT = "";
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
            if (dr["ApDungGoi"].GetType().Name != "DBNull" && dr["ApDungGoi"] != null)
            {
                this.ApDungGoi = Convert.ToBoolean(dr["ApDungGoi"]);
            }
            else
            {
                this.ApDungGoi = new Nullable<Boolean>();
            }
            if (dr["Gianhap"].GetType().Name != "DBNull" && dr["Gianhap"] != null)
            {
                this.Gianhap = Convert.ToDecimal(dr["Gianhap"]);
            }
            else
            {
                this.Gianhap = new Nullable<Decimal>();
            }
            if (dr["Gianhap1"].GetType().Name != "DBNull" && dr["Gianhap1"] != null)
            {
                this.Gianhap1 = Convert.ToDecimal(dr["Gianhap1"]);
            }
            else
            {
                this.Gianhap1 = new Nullable<Decimal>();
            }
            if (dr["Gianhap2"].GetType().Name != "DBNull" && dr["Gianhap2"] != null)
            {
                this.Gianhap2 = Convert.ToDecimal(dr["Gianhap2"]);
            }
            else
            {
                this.Gianhap2 = new Nullable<Decimal>();
            }
            if (dr["Ngaynhap"].GetType().Name != "DBNull" && dr["Ngaynhap"] != null)
            {
                this.Ngaynhap = Convert.ToDateTime(dr["Ngaynhap"]);
            }
            else
            {
                this.Ngaynhap = new Nullable<DateTime>();
            }
            if (dr["Ngaynhap1"].GetType().Name != "DBNull" && dr["Ngaynhap1"] != null)
            {
                this.Ngaynhap1 = Convert.ToDateTime(dr["Ngaynhap1"]);
            }
            else
            {
                this.Ngaynhap1 = new Nullable<DateTime>();
            }
            if (dr["Ngaynhap2"].GetType().Name != "DBNull" && dr["Ngaynhap2"] != null)
            {
                this.Ngaynhap2 = Convert.ToDateTime(dr["Ngaynhap2"]);
            }
            else
            {
                this.Ngaynhap2 = new Nullable<DateTime>();
            }
            if (dr["Makho"].GetType().Name != "DBNull" && dr["Makho"] != null)
            {
                this.Makho = Convert.ToString(dr["Makho"]);
            }
            else
            {
                this.Makho = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = new Nullable<Boolean>();
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
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]);
            }
            else
            {
                this.NgaySD = new Nullable<DateTime>();
            }
            if (dr["NgaySD1"].GetType().Name != "DBNull" && dr["NgaySD1"] != null)
            {
                this.NgaySD1 = Convert.ToDateTime(dr["NgaySD1"]);
            }
            else
            {
                this.NgaySD1 = new Nullable<DateTime>();
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
            if (dr["NguoiSD1"].GetType().Name != "DBNull" && dr["NguoiSD1"] != null)
            {
                this.NguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
            }
            else
            {
                this.NguoiSD1 = "";
            }
            if (dr["MaDVTHL"].GetType().Name != "DBNull" && dr["MaDVTHL"] != null)
            {
                this.MaDVTHL = Convert.ToString(dr["MaDVTHL"]);
            }
            else
            {
                this.MaDVTHL = "";
            }
            if (dr["HanDung"].GetType().Name != "DBNull" && dr["HanDung"] != null)
            {
                this.HanDung = Convert.ToBoolean(dr["HanDung"]);
            }
            else
            {
                this.HanDung = new Nullable<Boolean>();
            }
            if (dr["NgayGia"].GetType().Name != "DBNull" && dr["NgayGia"] != null)
            {
                this.NgayGia = Convert.ToDateTime(dr["NgayGia"]);
            }
            else
            {
                this.NgayGia = new Nullable<DateTime>();
            }
            if (dr["MaChungLoai"].GetType().Name != "DBNull" && dr["MaChungLoai"] != null)
            {
                this.MaChungLoai = Convert.ToString(dr["MaChungLoai"]);
            }
            else
            {
                this.MaChungLoai = "";
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
            if (dr["MaLH"].GetType().Name != "DBNull" && dr["MaLH"] != null)
            {
                this.MaLH = Convert.ToString(dr["MaLH"]);
            }
            else
            {
                this.MaLH = "";
            }
            if (dr["KhongSD"].GetType().Name != "DBNull" && dr["KhongSD"] != null)
            {
                this.KhongSD = Convert.ToBoolean(dr["KhongSD"]);
            }
            else
            {
                this.KhongSD = new Nullable<Boolean>();
            }
            if (dr["TenTat"].GetType().Name != "DBNull" && dr["TenTat"] != null)
            {
                this.TenTat = Convert.ToString(dr["TenTat"]);
            }
            else
            {
                this.TenTat = "";
            }
            if (dr["QuyCach"].GetType().Name != "DBNull" && dr["QuyCach"] != null)
            {
                this.QuyCach = Convert.ToString(dr["QuyCach"]);
            }
            else
            {
                this.QuyCach = "";
            }
            if (dr["MaNSX"].GetType().Name != "DBNull" && dr["MaNSX"] != null)
            {
                this.MaNSX = Convert.ToString(dr["MaNSX"]);
            }
            else
            {
                this.MaNSX = "";
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
            if (dr["TenCPMauBH"].GetType().Name != "DBNull" && dr["TenCPMauBH"] != null)
            {
                this.TenCPMauBH = Convert.ToString(dr["TenCPMauBH"]);
            }
            else
            {
                this.TenCPMauBH = "";
            }
            if (dr["TENNHOM"].GetType().Name != "DBNull" && dr["TENNHOM"] != null)
            {
                this.TENNHOM = Convert.ToString(dr["TENNHOM"]);
            }
            else
            {
                this.TENNHOM = "";
            }
            if (dr["TENDVT"].GetType().Name != "DBNull" && dr["TENDVT"] != null)
            {
                this.TENDVT = Convert.ToString(dr["TENDVT"]);
            }
            else
            {
                this.TENDVT = "";
            }
            if (dr["TENKHO"].GetType().Name != "DBNull" && dr["TENKHO"] != null)
            {
                this.TENKHO = Convert.ToString(dr["TENKHO"]);
            }
            else
            {
                this.TENKHO = "";
            }
            if (dr["hoten"].GetType().Name != "DBNull" && dr["hoten"] != null)
            {
                this.hoten = Convert.ToString(dr["hoten"]);
            }
            else
            {
                this.hoten = "";
            }
            if (dr["TENDVTHL"].GetType().Name != "DBNull" && dr["TENDVTHL"] != null)
            {
                this.TENDVTHL = Convert.ToString(dr["TENDVTHL"]);
            }
            else
            {
                this.TENDVTHL = "";
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

    [Serializable]
    public class DMChePhamMau_HList : List<DMChePhamMau_H>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMChePhamMau_HList FindDMChePhamMauMa(String Ma, Boolean QAdmin)
        {
            Ma = " and (a.MaCPMau like N'%" + Ma + "%')";
            DMChePhamMau_HList List = new DMChePhamMau_HList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMCHEPHAMMAU_FINDS_Hue", Ma, QAdmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMChePhamMau_H(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
