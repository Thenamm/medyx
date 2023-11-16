using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace Dzual.Category
{
    [Serializable]
    public class DMVTYT_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaVT { get; set; }
        public String MaNhom { get; set; }
        public String MaChungLoai { get; set; }
        public String TenTM { get; set; }
        public String tenTA { get; set; }
        public String MaNSX { get; set; }
        public Nullable<Decimal> Nguong { get; set; }
        public String MaDVT { get; set; }
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
        public Nullable<Boolean> VTThuT { get; set; }
        public Nullable<Boolean> VTPhauT { get; set; }
        public Nullable<Boolean> VTCLS { get; set; }
        public Nullable<Boolean> VTDuoc { get; set; }
        public Nullable<Boolean> VTBan { get; set; }
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
        public Nullable<Boolean> VTNoiT { get; set; }
        public String MaLH { get; set; }
        public String MaDVTHL { get; set; }
        public String HamLuong { get; set; }
        public Nullable<DateTime> NgayGia { get; set; }
        public String MaQG { get; set; }
        public Nullable<Boolean> KhongSD { get; set; }
        public String QuyCach { get; set; }
        public String MaQL { get; set; }
        public String MaDVT2 { get; set; }
        public Nullable<Decimal> Quydoi { get; set; }
        public Nullable<Byte> loai { get; set; }
        public String MaBYTe { get; set; }
        public String QuyetDinh { get; set; }
        public String TenTMBH { get; set; }
        public Nullable<Decimal> GiaChenhLech { get; set; }
        public String TENNHOM { get; set; }
        public String TENCHUNGLOAI { get; set; }
        public String TENNSX { get; set; }
        public String TENDVT { get; set; }
        public String TENKHOBAN { get; set; }
        public String TENKHOPHAT { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }
        public String TENDVTHL { get; set; }
        public Nullable<Decimal> DongiaBH { get; set; }
        public Nullable<Decimal> GiaChenhlenh { get; set; }
        public Nullable<Boolean> ADChenhlech { get; set; }
        public Nullable<Boolean> DTBH { get; set; }

        public DMVTYT_H()
        {
            MaVT = "";
            MaNhom = "";
            MaChungLoai = "";
            TenTM = "";
            tenTA = "";
            MaNSX = "";
            Nguong = new Nullable<Decimal>();
            MaDVT = "";
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
            VTThuT = new Nullable<Boolean>();
            VTPhauT = new Nullable<Boolean>();
            VTCLS = new Nullable<Boolean>();
            VTDuoc = new Nullable<Boolean>();
            VTBan = new Nullable<Boolean>();
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
            VTNoiT = new Nullable<Boolean>();
            MaLH = "";
            MaDVTHL = "";
            HamLuong = "";
            NgayGia = new Nullable<DateTime>();
            MaQG = "";
            KhongSD = new Nullable<Boolean>();
            QuyCach = "";
            MaQL = "";
            MaDVT2 = "";
            Quydoi = new Nullable<Decimal>();
            loai = new Nullable<Byte>();
            MaBYTe = "";
            QuyetDinh = "";
            TenTMBH = "";
            GiaChenhLech = new Nullable<Decimal>();
            TENNHOM = "";
            TENCHUNGLOAI = "";
            TENNSX = "";
            TENDVT = "";
            TENKHOBAN = "";
            TENKHOPHAT = "";
            TENNGUOILAP = "";
            TENNGUOISD = "";
            TENNGUOIHUY = "";
            TENDVTHL = "";
            DongiaBH = new Nullable<Decimal>();
            GiaChenhlenh = new Nullable<Decimal>();
            ADChenhlech = new Nullable<Boolean>();
            DTBH = new Nullable<Boolean>();
            Ordernumber = 0;
        }

        public DMVTYT_H(String MaVT, String MaNhom, String MaChungLoai, String TenTM, String tenTA, String MaNSX, Nullable<Decimal> Nguong, String MaDVT, Nullable<Boolean> ApDungGoi, Nullable<Boolean> Handung, Nullable<Decimal> Gianhap, Nullable<DateTime> Ngaynhap, Nullable<Decimal> Gianhap1, Nullable<DateTime> Ngaynhap1, Nullable<Decimal> Gianhap2, Nullable<DateTime> Ngaynhap2, Nullable<Decimal> DonGiaTT, Nullable<Decimal> DonGiaTT1, Nullable<Decimal> DongiaThuT, Nullable<Decimal> DongiaPhauT, Nullable<Decimal> DongiaCLS, Nullable<Decimal> GiaQuay, Nullable<Decimal> GiaQuay1, String Khoban, String Khophat, Nullable<Boolean> VTThuT, Nullable<Boolean> VTPhauT, Nullable<Boolean> VTCLS, Nullable<Boolean> VTDuoc, Nullable<Boolean> VTBan, Nullable<Boolean> DuyetNgoaiT, Nullable<Boolean> DuyetNoiT, String Ghichu, String MaMay, Nullable<Boolean> Huy, Nullable<DateTime> NgaySD, String NguoiSD, Nullable<DateTime> NgaySD1, String NguoiSD1, Nullable<DateTime> NgayLap, String NguoiLap, Nullable<DateTime> NgayHuy, String NguoiHuy, Nullable<Boolean> VTNoiT, String MaLH, String MaDVTHL, String HamLuong, Nullable<DateTime> NgayGia, String MaQG, Nullable<Boolean> KhongSD, String QuyCach, String MaQL, String MaDVT2, Nullable<Decimal> Quydoi, Nullable<Byte> loai, String MaBYTe, String QuyetDinh, String TenTMBH, Nullable<Decimal> GiaChenhLech, String TENNHOM, String TENCHUNGLOAI, String TENNSX, String TENDVT, String TENKHOBAN, String TENKHOPHAT, String TENNGUOILAP, String TENNGUOISD, String TENNGUOIHUY, String TENDVTHL, Nullable<Decimal> DongiaBH, Nullable<Decimal> GiaChenhlenh, Nullable<Boolean> ADChenhlech, Nullable<Boolean> DTBH, Int32 Ordernumber)
        {
            this.MaVT = MaVT;
            this.MaNhom = MaNhom;
            this.MaChungLoai = MaChungLoai;
            this.TenTM = TenTM;
            this.tenTA = tenTA;
            this.MaNSX = MaNSX;
            this.Nguong = Nguong;
            this.MaDVT = MaDVT;
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
            this.VTThuT = VTThuT;
            this.VTPhauT = VTPhauT;
            this.VTCLS = VTCLS;
            this.VTDuoc = VTDuoc;
            this.VTBan = VTBan;
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
            this.VTNoiT = VTNoiT;
            this.MaLH = MaLH;
            this.MaDVTHL = MaDVTHL;
            this.HamLuong = HamLuong;
            this.NgayGia = NgayGia;
            this.MaQG = MaQG;
            this.KhongSD = KhongSD;
            this.QuyCach = QuyCach;
            this.MaQL = MaQL;
            this.MaDVT2 = MaDVT2;
            this.Quydoi = Quydoi;
            this.loai = loai;
            this.MaBYTe = MaBYTe;
            this.QuyetDinh = QuyetDinh;
            this.TenTMBH = TenTMBH;
            this.GiaChenhLech = GiaChenhLech;
            this.TENNHOM = TENNHOM;
            this.TENCHUNGLOAI = TENCHUNGLOAI;
            this.TENNSX = TENNSX;
            this.TENDVT = TENDVT;
            this.TENKHOBAN = TENKHOBAN;
            this.TENKHOPHAT = TENKHOPHAT;
            this.TENNGUOILAP = TENNGUOILAP;
            this.TENNGUOISD = TENNGUOISD;
            this.TENNGUOIHUY = TENNGUOIHUY;
            this.TENDVTHL = TENDVTHL;
            this.DongiaBH = DongiaBH;
            this.GiaChenhlenh = GiaChenhlenh;
            this.ADChenhlech = ADChenhlech;
            this.DTBH = DTBH;
            this.Ordernumber = Ordernumber;
        }
        public DMVTYT_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaVT"].GetType().Name != "DBNull" && dr["MaVT"] != null)
            {
                this.MaVT = Convert.ToString(dr["MaVT"]);
            }
            else
            {
                this.MaVT = "";
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
            if (dr["VTThuT"].GetType().Name != "DBNull" && dr["VTThuT"] != null)
            {
                this.VTThuT = Convert.ToBoolean(dr["VTThuT"]);
            }
            else
            {
                this.VTThuT = new Nullable<Boolean>();
            }
            if (dr["VTPhauT"].GetType().Name != "DBNull" && dr["VTPhauT"] != null)
            {
                this.VTPhauT = Convert.ToBoolean(dr["VTPhauT"]);
            }
            else
            {
                this.VTPhauT = new Nullable<Boolean>();
            }
            if (dr["VTCLS"].GetType().Name != "DBNull" && dr["VTCLS"] != null)
            {
                this.VTCLS = Convert.ToBoolean(dr["VTCLS"]);
            }
            else
            {
                this.VTCLS = new Nullable<Boolean>();
            }
            if (dr["VTDuoc"].GetType().Name != "DBNull" && dr["VTDuoc"] != null)
            {
                this.VTDuoc = Convert.ToBoolean(dr["VTDuoc"]);
            }
            else
            {
                this.VTDuoc = new Nullable<Boolean>();
            }
            if (dr["VTBan"].GetType().Name != "DBNull" && dr["VTBan"] != null)
            {
                this.VTBan = Convert.ToBoolean(dr["VTBan"]);
            }
            else
            {
                this.VTBan = new Nullable<Boolean>();
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
            if (dr["VTNoiT"].GetType().Name != "DBNull" && dr["VTNoiT"] != null)
            {
                this.VTNoiT = Convert.ToBoolean(dr["VTNoiT"]);
            }
            else
            {
                this.VTNoiT = new Nullable<Boolean>();
            }
            if (dr["MaLH"].GetType().Name != "DBNull" && dr["MaLH"] != null)
            {
                this.MaLH = Convert.ToString(dr["MaLH"]);
            }
            else
            {
                this.MaLH = "";
            }
            if (dr["MaDVTHL"].GetType().Name != "DBNull" && dr["MaDVTHL"] != null)
            {
                this.MaDVTHL = Convert.ToString(dr["MaDVTHL"]);
            }
            else
            {
                this.MaDVTHL = "";
            }
            if (dr["HamLuong"].GetType().Name != "DBNull" && dr["HamLuong"] != null)
            {
                this.HamLuong = Convert.ToString(dr["HamLuong"]);
            }
            else
            {
                this.HamLuong = "";
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
            if (dr["KhongSD"].GetType().Name != "DBNull" && dr["KhongSD"] != null)
            {
                this.KhongSD = Convert.ToBoolean(dr["KhongSD"]);
            }
            else
            {
                this.KhongSD = new Nullable<Boolean>();
            }
            if (dr["QuyCach"].GetType().Name != "DBNull" && dr["QuyCach"] != null)
            {
                this.QuyCach = Convert.ToString(dr["QuyCach"]);
            }
            else
            {
                this.QuyCach = "";
            }
            if (dr["MaQL"].GetType().Name != "DBNull" && dr["MaQL"] != null)
            {
                this.MaQL = Convert.ToString(dr["MaQL"]);
            }
            else
            {
                this.MaQL = "";
            }
            if (dr["MaDVT2"].GetType().Name != "DBNull" && dr["MaDVT2"] != null)
            {
                this.MaDVT2 = Convert.ToString(dr["MaDVT2"]);
            }
            else
            {
                this.MaDVT2 = "";
            }
            if (dr["Quydoi"].GetType().Name != "DBNull" && dr["Quydoi"] != null)
            {
                this.Quydoi = Convert.ToDecimal(dr["Quydoi"]);
            }
            else
            {
                this.Quydoi = new Nullable<Decimal>();
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
            if (dr["GiaChenhLech"].GetType().Name != "DBNull" && dr["GiaChenhLech"] != null)
            {
                this.GiaChenhLech = Convert.ToDecimal(dr["GiaChenhLech"]);
            }
            else
            {
                this.GiaChenhLech = new Nullable<Decimal>();
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
            if (dr["GiaChenhlenh"].GetType().Name != "DBNull" && dr["GiaChenhlenh"] != null)
            {
                this.GiaChenhlenh = Convert.ToDecimal(dr["GiaChenhlenh"]);
            }
            else
            {
                this.GiaChenhlenh = new Nullable<Decimal>();
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
    public class DMVTYT_HList : List<DMVTYT_H>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMVTYT_HList FindDMVTYTMa(Byte loai, String Ma, Boolean QAdmin)
        {
            Ma = " and a.loai = " + loai + "  and (a.MAvt like N'%" + Ma + "%' or a.MAql like N'%" + Ma + "%')";
            DMVTYT_HList List = new DMVTYT_HList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMVTYT_FINDS_Hue", Ma, QAdmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMVTYT_H(dr, Ordernumber));
                }
            }
            return List;
        }

    }
}

