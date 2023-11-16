using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.Category
{
    [Serializable]
    public class DMHoaChat_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaHC { get; set; }
        public String MaNhom { get; set; }
        public String MaChungLoai { get; set; }
        public String TenTM { get; set; }
        public String tenTA { get; set; }
        public String MaNSX { get; set; }
        public String HamLuong { get; set; }
        public String MaDVTHL { get; set; }
        public Nullable<Decimal> Nguong { get; set; }
        public String MaDVT { get; set; }
        public Nullable<Decimal> Quydoi { get; set; }
        public String MaHCgoc { get; set; }
        public String MaDVTGoc { get; set; }
        public Nullable<Boolean> ApDungGoi { get; set; }
        public Nullable<Boolean> Handung { get; set; }
        public Nullable<Decimal> Gianhap { get; set; }
        public Nullable<DateTime> Ngaynhap { get; set; }
        public Nullable<Decimal> Gianhap1 { get; set; }
        public Nullable<DateTime> Ngaynhap1 { get; set; }
        public Nullable<Decimal> Gianhap2 { get; set; }
        public Nullable<DateTime> Ngaynhap2 { get; set; }
        public Nullable<Decimal> DonGiaTT { get; set; }
        public Nullable<Decimal> DonGiaTT1 { get; set; }
        public Nullable<Decimal> DongiaThuT { get; set; }
        public Nullable<Decimal> DongiaPhauT { get; set; }
        public Nullable<Decimal> DongiaCLS { get; set; }
        public Nullable<Decimal> GiaQuay { get; set; }
        public Nullable<Decimal> GiaQuay1 { get; set; }
        public String Khoban { get; set; }
        public String Khophat { get; set; }
        public Nullable<Boolean> HCThuT { get; set; }
        public Nullable<Boolean> HCPhauT { get; set; }
        public Nullable<Boolean> HCCLS { get; set; }
        public Nullable<Boolean> HCDuoc { get; set; }
        public Nullable<Boolean> HCBan { get; set; }
        public Nullable<Boolean> DuyetNgoaiT { get; set; }
        public Nullable<Boolean> DuyetNoiT { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public Nullable<Boolean> Huy { get; set; }
        public Nullable<DateTime> NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Nullable<DateTime> NgaySD1 { get; set; }
        public String NguoiSD1 { get; set; }
        public Nullable<DateTime> NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public Nullable<DateTime> NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public Nullable<Boolean> HCNoiT { get; set; }
        public String MaLH { get; set; }
        public Nullable<DateTime> NgayGia { get; set; }
        public String MaQG { get; set; }
        public String QuyCach { get; set; }
        public Nullable<Boolean> KhongSD { get; set; }
        public String maql { get; set; }
        public Nullable<Byte> sothanghd { get; set; }
        public Nullable<Byte> loai { get; set; }
        public String MaBYTe { get; set; }
        public String QuyetDinh { get; set; }
        public String TenTMBH { get; set; }
        public String TENNHOM { get; set; }
        public String TENCHUNGLOAI { get; set; }
        public String TENNSX { get; set; }
        public String TENDVT { get; set; }
        public String TENGOC { get; set; }
        public String TENKHOBAN { get; set; }
        public String TENKHOPHAT { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }
        public String TENDVTHL { get; set; }
        public Nullable<Decimal> DongiaBH { get; set; }
        public Nullable<Decimal> GiaChenhlech { get; set; }
        public Nullable<Boolean> ADChenhlech { get; set; }
        public Nullable<Boolean> DTBH { get; set; }

        public DMHoaChat_H()
        {
            MaHC = "";
            MaNhom = "";
            MaChungLoai = "";
            TenTM = "";
            tenTA = "";
            MaNSX = "";
            HamLuong = "";
            MaDVTHL = "";
            Nguong = new Nullable<Decimal>();
            MaDVT = "";
            Quydoi = new Nullable<Decimal>();
            MaHCgoc = "";
            MaDVTGoc = "";
            ApDungGoi = new Nullable<Boolean>();
            Handung = new Nullable<Boolean>();
            Gianhap = new Nullable<Decimal>();
            Ngaynhap = new Nullable<DateTime>();
            Gianhap1 = new Nullable<Decimal>();
            Ngaynhap1 = new Nullable<DateTime>();
            Gianhap2 = new Nullable<Decimal>();
            Ngaynhap2 = new Nullable<DateTime>();
            DonGiaTT = new Nullable<Decimal>();
            DonGiaTT1 = new Nullable<Decimal>();
            DongiaThuT = new Nullable<Decimal>();
            DongiaPhauT = new Nullable<Decimal>();
            DongiaCLS = new Nullable<Decimal>();
            GiaQuay = new Nullable<Decimal>();
            GiaQuay1 = new Nullable<Decimal>();
            Khoban = "";
            Khophat = "";
            HCThuT = new Nullable<Boolean>();
            HCPhauT = new Nullable<Boolean>();
            HCCLS = new Nullable<Boolean>();
            HCDuoc = new Nullable<Boolean>();
            HCBan = new Nullable<Boolean>();
            DuyetNgoaiT = new Nullable<Boolean>();
            DuyetNoiT = new Nullable<Boolean>();
            Ghichu = "";
            MaMay = "";
            Huy = new Nullable<Boolean>();
            NgaySD = new Nullable<DateTime>();
            NguoiSD = "";
            NgaySD1 = new Nullable<DateTime>();
            NguoiSD1 = "";
            NgayLap = new Nullable<DateTime>();
            NguoiLap = "";
            NgayHuy = new Nullable<DateTime>();
            NguoiHuy = "";
            HCNoiT = new Nullable<Boolean>();
            MaLH = "";
            NgayGia = new Nullable<DateTime>();
            MaQG = "";
            QuyCach = "";
            KhongSD = new Nullable<Boolean>();
            maql = "";
            sothanghd = new Nullable<Byte>();
            loai = new Nullable<Byte>();
            MaBYTe = "";
            QuyetDinh = "";
            TenTMBH = "";
            TENNHOM = "";
            TENCHUNGLOAI = "";
            TENNSX = "";
            TENDVT = "";
            TENGOC = "";
            TENKHOBAN = "";
            TENKHOPHAT = "";
            TENNGUOILAP = "";
            TENNGUOISD = "";
            TENNGUOIHUY = "";
            TENDVTHL = "";
            DongiaBH = new Nullable<Decimal>();
            GiaChenhlech = new Nullable<Decimal>();
            ADChenhlech = new Nullable<Boolean>();
            DTBH = new Nullable<Boolean>();
            Ordernumber = 0;
        }

        public DMHoaChat_H(String MaHC, String MaNhom, String MaChungLoai, String TenTM, String tenTA, String MaNSX, String HamLuong, String MaDVTHL, Nullable<Decimal> Nguong, String MaDVT, Nullable<Decimal> Quydoi, String MaHCgoc, String MaDVTGoc, Nullable<Boolean> ApDungGoi, Nullable<Boolean> Handung, Nullable<Decimal> Gianhap, Nullable<DateTime> Ngaynhap, Nullable<Decimal> Gianhap1, Nullable<DateTime> Ngaynhap1, Nullable<Decimal> Gianhap2, Nullable<DateTime> Ngaynhap2, Nullable<Decimal> DonGiaTT, Nullable<Decimal> DonGiaTT1, Nullable<Decimal> DongiaThuT, Nullable<Decimal> DongiaPhauT, Nullable<Decimal> DongiaCLS, Nullable<Decimal> GiaQuay, Nullable<Decimal> GiaQuay1, String Khoban, String Khophat, Nullable<Boolean> HCThuT, Nullable<Boolean> HCPhauT, Nullable<Boolean> HCCLS, Nullable<Boolean> HCDuoc, Nullable<Boolean> HCBan, Nullable<Boolean> DuyetNgoaiT, Nullable<Boolean> DuyetNoiT, String Ghichu, String MaMay, Nullable<Boolean> Huy, Nullable<DateTime> NgaySD, String NguoiSD, Nullable<DateTime> NgaySD1, String NguoiSD1, Nullable<DateTime> NgayLap, String NguoiLap, Nullable<DateTime> NgayHuy, String NguoiHuy, Nullable<Boolean> HCNoiT, String MaLH, Nullable<DateTime> NgayGia, String MaQG, String QuyCach, Nullable<Boolean> KhongSD, String maql, Nullable<Byte> sothanghd, Nullable<Byte> loai, String MaBYTe, String QuyetDinh, String TenTMBH, String TENNHOM, String TENCHUNGLOAI, String TENNSX, String TENDVT, String TENGOC, String TENKHOBAN, String TENKHOPHAT, String TENNGUOILAP, String TENNGUOISD, String TENNGUOIHUY, String TENDVTHL, Nullable<Decimal> DongiaBH, Nullable<Decimal> GiaChenhlech, Nullable<Boolean> ADChenhlech, Nullable<Boolean> DTBH, Int32 Ordernumber)
        {
            this.MaHC = MaHC;
            this.MaNhom = MaNhom;
            this.MaChungLoai = MaChungLoai;
            this.TenTM = TenTM;
            this.tenTA = tenTA;
            this.MaNSX = MaNSX;
            this.HamLuong = HamLuong;
            this.MaDVTHL = MaDVTHL;
            this.Nguong = Nguong;
            this.MaDVT = MaDVT;
            this.Quydoi = Quydoi;
            this.MaHCgoc = MaHCgoc;
            this.MaDVTGoc = MaDVTGoc;
            this.ApDungGoi = ApDungGoi;
            this.Handung = Handung;
            this.Gianhap = Gianhap;
            this.Ngaynhap = Ngaynhap;
            this.Gianhap1 = Gianhap1;
            this.Ngaynhap1 = Ngaynhap1;
            this.Gianhap2 = Gianhap2;
            this.Ngaynhap2 = Ngaynhap2;
            this.DonGiaTT = DonGiaTT;
            this.DonGiaTT1 = DonGiaTT1;
            this.DongiaThuT = DongiaThuT;
            this.DongiaPhauT = DongiaPhauT;
            this.DongiaCLS = DongiaCLS;
            this.GiaQuay = GiaQuay;
            this.GiaQuay1 = GiaQuay1;
            this.Khoban = Khoban;
            this.Khophat = Khophat;
            this.HCThuT = HCThuT;
            this.HCPhauT = HCPhauT;
            this.HCCLS = HCCLS;
            this.HCDuoc = HCDuoc;
            this.HCBan = HCBan;
            this.DuyetNgoaiT = DuyetNgoaiT;
            this.DuyetNoiT = DuyetNoiT;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgaySD1 = NgaySD1;
            this.NguoiSD1 = NguoiSD1;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.HCNoiT = HCNoiT;
            this.MaLH = MaLH;
            this.NgayGia = NgayGia;
            this.MaQG = MaQG;
            this.QuyCach = QuyCach;
            this.KhongSD = KhongSD;
            this.maql = maql;
            this.sothanghd = sothanghd;
            this.loai = loai;
            this.MaBYTe = MaBYTe;
            this.QuyetDinh = QuyetDinh;
            this.TenTMBH = TenTMBH;
            this.TENNHOM = TENNHOM;
            this.TENCHUNGLOAI = TENCHUNGLOAI;
            this.TENNSX = TENNSX;
            this.TENDVT = TENDVT;
            this.TENGOC = TENGOC;
            this.TENKHOBAN = TENKHOBAN;
            this.TENKHOPHAT = TENKHOPHAT;
            this.TENNGUOILAP = TENNGUOILAP;
            this.TENNGUOISD = TENNGUOISD;
            this.TENNGUOIHUY = TENNGUOIHUY;
            this.TENDVTHL = TENDVTHL;
            this.DongiaBH = DongiaBH;
            this.GiaChenhlech = GiaChenhlech;
            this.ADChenhlech = ADChenhlech;
            this.DTBH = DTBH;
            this.Ordernumber = Ordernumber;
        }
        public DMHoaChat_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaHC"].GetType().Name != "DBNull" && dr["MaHC"] != null)
            {
                this.MaHC = Convert.ToString(dr["MaHC"]);
            }
            else
            {
                this.MaHC = "";
            }
            if (dr["MaNhom"].GetType().Name != "DBNull" && dr["MaNhom"] != null)
            {
                this.MaNhom = Convert.ToString(dr["MaNhom"]);
            }
            else
            {
                this.MaNhom = "";
            }
            if (dr["MaChungLoai"].GetType().Name != "DBNull" && dr["MaChungLoai"] != null)
            {
                this.MaChungLoai = Convert.ToString(dr["MaChungLoai"]);
            }
            else
            {
                this.MaChungLoai = "";
            }
            if (dr["TenTM"].GetType().Name != "DBNull" && dr["TenTM"] != null)
            {
                this.TenTM = Convert.ToString(dr["TenTM"]);
            }
            else
            {
                this.TenTM = "";
            }
            if (dr["tenTA"].GetType().Name != "DBNull" && dr["tenTA"] != null)
            {
                this.tenTA = Convert.ToString(dr["tenTA"]);
            }
            else
            {
                this.tenTA = "";
            }
            if (dr["MaNSX"].GetType().Name != "DBNull" && dr["MaNSX"] != null)
            {
                this.MaNSX = Convert.ToString(dr["MaNSX"]);
            }
            else
            {
                this.MaNSX = "";
            }
            if (dr["HamLuong"].GetType().Name != "DBNull" && dr["HamLuong"] != null)
            {
                this.HamLuong = Convert.ToString(dr["HamLuong"]);
            }
            else
            {
                this.HamLuong = "";
            }
            if (dr["MaDVTHL"].GetType().Name != "DBNull" && dr["MaDVTHL"] != null)
            {
                this.MaDVTHL = Convert.ToString(dr["MaDVTHL"]);
            }
            else
            {
                this.MaDVTHL = "";
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
            if (dr["Quydoi"].GetType().Name != "DBNull" && dr["Quydoi"] != null)
            {
                this.Quydoi = Convert.ToDecimal(dr["Quydoi"]);
            }
            else
            {
                this.Quydoi = new Nullable<Decimal>();
            }
            if (dr["MaHCgoc"].GetType().Name != "DBNull" && dr["MaHCgoc"] != null)
            {
                this.MaHCgoc = Convert.ToString(dr["MaHCgoc"]);
            }
            else
            {
                this.MaHCgoc = "";
            }
            if (dr["MaDVTGoc"].GetType().Name != "DBNull" && dr["MaDVTGoc"] != null)
            {
                this.MaDVTGoc = Convert.ToString(dr["MaDVTGoc"]);
            }
            else
            {
                this.MaDVTGoc = "";
            }
            if (dr["ApDungGoi"].GetType().Name != "DBNull" && dr["ApDungGoi"] != null)
            {
                this.ApDungGoi = Convert.ToBoolean(dr["ApDungGoi"]);
            }
            else
            {
                this.ApDungGoi = new Nullable<Boolean>();
            }
            if (dr["Handung"].GetType().Name != "DBNull" && dr["Handung"] != null)
            {
                this.Handung = Convert.ToBoolean(dr["Handung"]);
            }
            else
            {
                this.Handung = new Nullable<Boolean>();
            }
            if (dr["Gianhap"].GetType().Name != "DBNull" && dr["Gianhap"] != null)
            {
                this.Gianhap = Convert.ToDecimal(dr["Gianhap"]);
            }
            else
            {
                this.Gianhap = new Nullable<Decimal>();
            }
            if (dr["Ngaynhap"].GetType().Name != "DBNull" && dr["Ngaynhap"] != null)
            {
                this.Ngaynhap = Convert.ToDateTime(dr["Ngaynhap"]);
            }
            else
            {
                this.Ngaynhap = new Nullable<DateTime>();
            }
            if (dr["Gianhap1"].GetType().Name != "DBNull" && dr["Gianhap1"] != null)
            {
                this.Gianhap1 = Convert.ToDecimal(dr["Gianhap1"]);
            }
            else
            {
                this.Gianhap1 = new Nullable<Decimal>();
            }
            if (dr["Ngaynhap1"].GetType().Name != "DBNull" && dr["Ngaynhap1"] != null)
            {
                this.Ngaynhap1 = Convert.ToDateTime(dr["Ngaynhap1"]);
            }
            else
            {
                this.Ngaynhap1 = new Nullable<DateTime>();
            }
            if (dr["Gianhap2"].GetType().Name != "DBNull" && dr["Gianhap2"] != null)
            {
                this.Gianhap2 = Convert.ToDecimal(dr["Gianhap2"]);
            }
            else
            {
                this.Gianhap2 = new Nullable<Decimal>();
            }
            if (dr["Ngaynhap2"].GetType().Name != "DBNull" && dr["Ngaynhap2"] != null)
            {
                this.Ngaynhap2 = Convert.ToDateTime(dr["Ngaynhap2"]);
            }
            else
            {
                this.Ngaynhap2 = new Nullable<DateTime>();
            }
            if (dr["DonGiaTT"].GetType().Name != "DBNull" && dr["DonGiaTT"] != null)
            {
                this.DonGiaTT = Convert.ToDecimal(dr["DonGiaTT"]);
            }
            else
            {
                this.DonGiaTT = new Nullable<Decimal>();
            }
            if (dr["DonGiaTT1"].GetType().Name != "DBNull" && dr["DonGiaTT1"] != null)
            {
                this.DonGiaTT1 = Convert.ToDecimal(dr["DonGiaTT1"]);
            }
            else
            {
                this.DonGiaTT1 = new Nullable<Decimal>();
            }
            if (dr["DongiaThuT"].GetType().Name != "DBNull" && dr["DongiaThuT"] != null)
            {
                this.DongiaThuT = Convert.ToDecimal(dr["DongiaThuT"]);
            }
            else
            {
                this.DongiaThuT = new Nullable<Decimal>();
            }
            if (dr["DongiaPhauT"].GetType().Name != "DBNull" && dr["DongiaPhauT"] != null)
            {
                this.DongiaPhauT = Convert.ToDecimal(dr["DongiaPhauT"]);
            }
            else
            {
                this.DongiaPhauT = new Nullable<Decimal>();
            }
            if (dr["DongiaCLS"].GetType().Name != "DBNull" && dr["DongiaCLS"] != null)
            {
                this.DongiaCLS = Convert.ToDecimal(dr["DongiaCLS"]);
            }
            else
            {
                this.DongiaCLS = new Nullable<Decimal>();
            }
            if (dr["GiaQuay"].GetType().Name != "DBNull" && dr["GiaQuay"] != null)
            {
                this.GiaQuay = Convert.ToDecimal(dr["GiaQuay"]);
            }
            else
            {
                this.GiaQuay = new Nullable<Decimal>();
            }
            if (dr["GiaQuay1"].GetType().Name != "DBNull" && dr["GiaQuay1"] != null)
            {
                this.GiaQuay1 = Convert.ToDecimal(dr["GiaQuay1"]);
            }
            else
            {
                this.GiaQuay1 = new Nullable<Decimal>();
            }
            if (dr["Khoban"].GetType().Name != "DBNull" && dr["Khoban"] != null)
            {
                this.Khoban = Convert.ToString(dr["Khoban"]);
            }
            else
            {
                this.Khoban = "";
            }
            if (dr["Khophat"].GetType().Name != "DBNull" && dr["Khophat"] != null)
            {
                this.Khophat = Convert.ToString(dr["Khophat"]);
            }
            else
            {
                this.Khophat = "";
            }
            if (dr["HCThuT"].GetType().Name != "DBNull" && dr["HCThuT"] != null)
            {
                this.HCThuT = Convert.ToBoolean(dr["HCThuT"]);
            }
            else
            {
                this.HCThuT = new Nullable<Boolean>();
            }
            if (dr["HCPhauT"].GetType().Name != "DBNull" && dr["HCPhauT"] != null)
            {
                this.HCPhauT = Convert.ToBoolean(dr["HCPhauT"]);
            }
            else
            {
                this.HCPhauT = new Nullable<Boolean>();
            }
            if (dr["HCCLS"].GetType().Name != "DBNull" && dr["HCCLS"] != null)
            {
                this.HCCLS = Convert.ToBoolean(dr["HCCLS"]);
            }
            else
            {
                this.HCCLS = new Nullable<Boolean>();
            }
            if (dr["HCDuoc"].GetType().Name != "DBNull" && dr["HCDuoc"] != null)
            {
                this.HCDuoc = Convert.ToBoolean(dr["HCDuoc"]);
            }
            else
            {
                this.HCDuoc = new Nullable<Boolean>();
            }
            if (dr["HCBan"].GetType().Name != "DBNull" && dr["HCBan"] != null)
            {
                this.HCBan = Convert.ToBoolean(dr["HCBan"]);
            }
            else
            {
                this.HCBan = new Nullable<Boolean>();
            }
            if (dr["DuyetNgoaiT"].GetType().Name != "DBNull" && dr["DuyetNgoaiT"] != null)
            {
                this.DuyetNgoaiT = Convert.ToBoolean(dr["DuyetNgoaiT"]);
            }
            else
            {
                this.DuyetNgoaiT = new Nullable<Boolean>();
            }
            if (dr["DuyetNoiT"].GetType().Name != "DBNull" && dr["DuyetNoiT"] != null)
            {
                this.DuyetNoiT = Convert.ToBoolean(dr["DuyetNoiT"]);
            }
            else
            {
                this.DuyetNoiT = new Nullable<Boolean>();
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
                this.Huy = new Nullable<Boolean>();
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
            if (dr["HCNoiT"].GetType().Name != "DBNull" && dr["HCNoiT"] != null)
            {
                this.HCNoiT = Convert.ToBoolean(dr["HCNoiT"]);
            }
            else
            {
                this.HCNoiT = new Nullable<Boolean>();
            }
            if (dr["MaLH"].GetType().Name != "DBNull" && dr["MaLH"] != null)
            {
                this.MaLH = Convert.ToString(dr["MaLH"]);
            }
            else
            {
                this.MaLH = "";
            }
            if (dr["NgayGia"].GetType().Name != "DBNull" && dr["NgayGia"] != null)
            {
                this.NgayGia = Convert.ToDateTime(dr["NgayGia"]);
            }
            else
            {
                this.NgayGia = new Nullable<DateTime>();
            }
            if (dr["MaQG"].GetType().Name != "DBNull" && dr["MaQG"] != null)
            {
                this.MaQG = Convert.ToString(dr["MaQG"]);
            }
            else
            {
                this.MaQG = "";
            }
            if (dr["QuyCach"].GetType().Name != "DBNull" && dr["QuyCach"] != null)
            {
                this.QuyCach = Convert.ToString(dr["QuyCach"]);
            }
            else
            {
                this.QuyCach = "";
            }
            if (dr["KhongSD"].GetType().Name != "DBNull" && dr["KhongSD"] != null)
            {
                this.KhongSD = Convert.ToBoolean(dr["KhongSD"]);
            }
            else
            {
                this.KhongSD = new Nullable<Boolean>();
            }
            if (dr["maql"].GetType().Name != "DBNull" && dr["maql"] != null)
            {
                this.maql = Convert.ToString(dr["maql"]);
            }
            else
            {
                this.maql = "";
            }
            if (dr["sothanghd"].GetType().Name != "DBNull" && dr["sothanghd"] != null)
            {
                this.sothanghd = Convert.ToByte(dr["sothanghd"]);
            }
            else
            {
                this.sothanghd = new Nullable<Byte>();
            }
            if (dr["loai"].GetType().Name != "DBNull" && dr["loai"] != null)
            {
                this.loai = Convert.ToByte(dr["loai"]);
            }
            else
            {
                this.loai = new Nullable<Byte>();
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
            if (dr["TenTMBH"].GetType().Name != "DBNull" && dr["TenTMBH"] != null)
            {
                this.TenTMBH = Convert.ToString(dr["TenTMBH"]);
            }
            else
            {
                this.TenTMBH = "";
            }
            if (dr["TENNHOM"].GetType().Name != "DBNull" && dr["TENNHOM"] != null)
            {
                this.TENNHOM = Convert.ToString(dr["TENNHOM"]);
            }
            else
            {
                this.TENNHOM = "";
            }
            if (dr["TENCHUNGLOAI"].GetType().Name != "DBNull" && dr["TENCHUNGLOAI"] != null)
            {
                this.TENCHUNGLOAI = Convert.ToString(dr["TENCHUNGLOAI"]);
            }
            else
            {
                this.TENCHUNGLOAI = "";
            }
            if (dr["TENNSX"].GetType().Name != "DBNull" && dr["TENNSX"] != null)
            {
                this.TENNSX = Convert.ToString(dr["TENNSX"]);
            }
            else
            {
                this.TENNSX = "";
            }
            if (dr["TENDVT"].GetType().Name != "DBNull" && dr["TENDVT"] != null)
            {
                this.TENDVT = Convert.ToString(dr["TENDVT"]);
            }
            else
            {
                this.TENDVT = "";
            }
            if (dr["TENGOC"].GetType().Name != "DBNull" && dr["TENGOC"] != null)
            {
                this.TENGOC = Convert.ToString(dr["TENGOC"]);
            }
            else
            {
                this.TENGOC = "";
            }
            if (dr["TENKHOBAN"].GetType().Name != "DBNull" && dr["TENKHOBAN"] != null)
            {
                this.TENKHOBAN = Convert.ToString(dr["TENKHOBAN"]);
            }
            else
            {
                this.TENKHOBAN = "";
            }
            if (dr["TENKHOPHAT"].GetType().Name != "DBNull" && dr["TENKHOPHAT"] != null)
            {
                this.TENKHOPHAT = Convert.ToString(dr["TENKHOPHAT"]);
            }
            else
            {
                this.TENKHOPHAT = "";
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
    public class DMHoaChat_HList : List<DMHoaChat_H>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMHoaChat_HList FindDMHoaChatMa(Byte loai, String Ma, Boolean QAdmin)
        {
            Ma = " and a.loai = " + loai + " and (a.MaHC like N'%" + Ma + "%')";
            DMHoaChat_HList List = new DMHoaChat_HList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMHOACHAT_FINDS_Hue", Ma, QAdmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMHoaChat_H(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}