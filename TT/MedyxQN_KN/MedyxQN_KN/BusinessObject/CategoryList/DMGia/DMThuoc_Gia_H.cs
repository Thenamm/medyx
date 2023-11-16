using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.Category
{
    [Serializable()]
    public class DMTHUOC_Hue
    {
        public Int32 Ordernumber { get; set; }
        public String MaThuoc { get; set; }
        public String Parent { get; set; }
        public String MaNhom { get; set; }
        public String MaPL { get; set; }
        public String MaChungLoai { get; set; }
        public String TenGoc { get; set; }
        public String TenTC { get; set; }
        public String TenTM { get; set; }
        public String TenTM1 { get; set; }
        public String TenTM2 { get; set; }
        public String tenTA { get; set; }
        public Boolean ThuocGoc { get; set; }
        public Decimal Ngaydungtoida { get; set; }
        public String MaNSX { get; set; }
        public String HamLuong { get; set; }
        public String MaDVTHL { get; set; }
        public Decimal Nguong { get; set; }
        public String MaDVT { get; set; }
        public Decimal Quydoi { get; set; }
        public String MaThuocgoc { get; set; }
        public String MaDVT2 { get; set; }
        public Boolean ApDungGoi { get; set; }
        public Boolean Handung { get; set; }
        public String Lieudung { get; set; }
        public String Cachdung { get; set; }
        public Decimal Gianhap { get; set; }
        public String Ngaynhap { get; set; }
        public Decimal Gianhap1 { get; set; }
        public String Ngaynhap1 { get; set; }
        public Decimal Gianhap2 { get; set; }
        public String Ngaynhap2 { get; set; }
        public Decimal DonGiaTT { get; set; }
        public Decimal DonGiaTT1 { get; set; }
        public Decimal DongiaThuT { get; set; }
        public Decimal DongiaPhauT { get; set; }
        public Decimal DongiaCLS { get; set; }
        public Decimal GiaQuay { get; set; }
        public Decimal GiaQuay1 { get; set; }
        public String Khoban { get; set; }
        public String Khophat { get; set; }
        public Boolean bh50 { get; set; }
        public Boolean ThuocThuT { get; set; }
        public Boolean ThuocPhauT { get; set; }
        public Boolean ThuocCLS { get; set; }
        public Boolean ThuocDuoc { get; set; }
        public Boolean ThuocBan { get; set; }
        public Boolean DuyetNgoaiT { get; set; }
        public Boolean DuyetNoiT { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgaySD1 { get; set; }
        public String NguoiSD1 { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public Boolean ThuocNoiT { get; set; }
        public String MaLH { get; set; }
        public String NguoiQuay { get; set; }
        public String NgayQuay { get; set; }
        public String NgayGia { get; set; }
        public Boolean ThuocBan2 { get; set; }
        public String SoVisa { get; set; }
        public String MaTK { get; set; }
        public String QuyCach { get; set; }
        public String MaQG { get; set; }
        public Boolean KhongSD { get; set; }
        public String MaQL { get; set; }
        public Boolean ThuocHoiChan { get; set; }
        public Byte ThuocTieuHao { get; set; }
        public Decimal GiaQuay56 { get; set; }
        public Decimal GiaQuay561 { get; set; }
        public String DuongDung { get; set; }
        public String MaTP { get; set; }
        public Boolean InThu { get; set; }
        public Decimal Gianhap43 { get; set; }
        public String Ngaynhap43 { get; set; }
        public Decimal Gianhap56 { get; set; }
        public String Ngaynhap56 { get; set; }
        public String MaBYTe { get; set; }
        public String QuyetDinh { get; set; }
        public String TenTMBH { get; set; }
        public String tendvt2 { get; set; }
        public String TENNHOM { get; set; }
        public String TENPL { get; set; }
        public String TENCHUNGLOAI { get; set; }
        public String TENNSX { get; set; }
        public String TENDVT { get; set; }
        public String TENGOC1 { get; set; }
        public String TENKHOBAN { get; set; }
        public String TENKHOPHAT { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }
        public String TENDVTHL { get; set; }
        public Decimal DongiaBH { get; set; }
        public Decimal GiaChenhlech { get; set; }
        public Boolean ADChenhlech { get; set; }
        public Boolean DTBH { get; set; }
        public DMTHUOC_Hue()
        {
            MaThuoc = "";
            Parent = "";
            MaNhom = "";
            MaPL = "";
            MaChungLoai = "";
            TenGoc = "";
            TenTC = "";
            TenTM = "";
            TenTM1 = "";
            TenTM2 = "";
            tenTA = "";
            ThuocGoc = false;
            Ngaydungtoida = 0;
            MaNSX = "";
            HamLuong = "";
            MaDVTHL = "";
            Nguong = 0;
            MaDVT = "";
            Quydoi = 0;
            MaThuocgoc = "";
            MaDVT2 = "";
            ApDungGoi = false;
            Handung = false;
            Lieudung = "";
            Cachdung = "";
            Gianhap = 0;
            Ngaynhap = "";
            Gianhap1 = 0;
            Ngaynhap1 = "";
            Gianhap2 = 0;
            Ngaynhap2 = "";
            DonGiaTT = 0;
            DonGiaTT1 = 0;
            DongiaThuT = 0;
            DongiaPhauT = 0;
            DongiaCLS = 0;
            GiaQuay = 0;
            GiaQuay1 = 0;
            Khoban = "";
            Khophat = "";
            bh50 = false;
            ThuocThuT = false;
            ThuocPhauT = false;
            ThuocCLS = false;
            ThuocDuoc = false;
            ThuocBan = false;
            DuyetNgoaiT = false;
            DuyetNoiT = false;
            Ghichu = "";
            MaMay = "";
            Huy = false;
            NgaySD = "";
            NguoiSD = "";
            NgaySD1 = "";
            NguoiSD1 = "";
            NgayLap = "";
            NguoiLap = "";
            NgayHuy = "";
            NguoiHuy = "";
            ThuocNoiT = false;
            MaLH = "";
            NguoiQuay = "";
            NgayQuay = "";
            NgayGia = "";
            ThuocBan2 = false;
            SoVisa = "";
            MaTK = "";
            QuyCach = "";
            MaQG = "";
            KhongSD = false;
            MaQL = "";
            ThuocHoiChan = false;
            ThuocTieuHao = 0;
            GiaQuay56 = 0;
            GiaQuay561 = 0;
            DuongDung = "";
            MaTP = "";
            InThu = false;
            Gianhap43 = 0;
            Ngaynhap43 = "";
            Gianhap56 = 0;
            Ngaynhap56 = "";
            MaBYTe = "";
            QuyetDinh = "";
            TenTMBH = "";
            tendvt2 = "";
            TENNHOM = "";
            TENPL = "";
            TENCHUNGLOAI = "";
            TENNSX = "";
            TENDVT = "";
            TENGOC1 = "";
            TENKHOBAN = "";
            TENKHOPHAT = "";
            TENNGUOILAP = "";
            TENNGUOISD = "";
            TENNGUOIHUY = "";
            TENDVTHL = "";
            DongiaBH = 0;
            GiaChenhlech = 0;
            ADChenhlech = false;
            DTBH = false;
            Ordernumber = 0;
        }
        public DMTHUOC_Hue(String MaThuoc, String Parent, String MaNhom, String MaPL, String MaChungLoai, String TenGoc, String TenTC, String TenTM, String TenTM1, String TenTM2, String tenTA, Boolean ThuocGoc, Decimal Ngaydungtoida, String MaNSX, String HamLuong, String MaDVTHL, Decimal Nguong, String MaDVT, Decimal Quydoi, String MaThuocgoc, String MaDVT2, Boolean ApDungGoi, Boolean Handung, String Lieudung, String Cachdung, Decimal Gianhap, String Ngaynhap, Decimal Gianhap1, String Ngaynhap1, Decimal Gianhap2, String Ngaynhap2, Decimal DonGiaTT, Decimal DonGiaTT1, Decimal DongiaThuT, Decimal DongiaPhauT, Decimal DongiaCLS, Decimal GiaQuay, Decimal GiaQuay1, String Khoban, String Khophat, Boolean bh50, Boolean ThuocThuT, Boolean ThuocPhauT, Boolean ThuocCLS, Boolean ThuocDuoc, Boolean ThuocBan, Boolean DuyetNgoaiT, Boolean DuyetNoiT, String Ghichu, String MaMay, Boolean Huy, String NgaySD, String NguoiSD, String NgaySD1, String NguoiSD1, String NgayLap, String NguoiLap, String NgayHuy, String NguoiHuy, Boolean ThuocNoiT, String MaLH, String NguoiQuay, String NgayQuay, String NgayGia, Boolean ThuocBan2, String SoVisa, String MaTK, String QuyCach, String MaQG, Boolean KhongSD, String MaQL, Boolean ThuocHoiChan, Byte ThuocTieuHao, Decimal GiaQuay56, Decimal GiaQuay561, String DuongDung, String MaTP, Boolean InThu, Decimal Gianhap43, String Ngaynhap43, Decimal Gianhap56, String Ngaynhap56, String MaBYTe, String QuyetDinh, String TenTMBH, String tendvt2, String TENNHOM, String TENPL, String TENCHUNGLOAI, String TENNSX, String TENDVT, String TENGOC1, String TENKHOBAN, String TENKHOPHAT, String TENNGUOILAP, String TENNGUOISD, String TENNGUOIHUY, String TENDVTHL, Decimal DongiaBH, Decimal GiaChenhlech, Boolean ADChenhlech, Boolean DTBH, Int32 Ordernumber)
        {
            this.MaThuoc = MaThuoc;
            this.Parent = Parent;
            this.MaNhom = MaNhom;
            this.MaPL = MaPL;
            this.MaChungLoai = MaChungLoai;
            this.TenGoc = TenGoc;
            this.TenTC = TenTC;
            this.TenTM = TenTM;
            this.TenTM1 = TenTM1;
            this.TenTM2 = TenTM2;
            this.tenTA = tenTA;
            this.ThuocGoc = ThuocGoc;
            this.Ngaydungtoida = Ngaydungtoida;
            this.MaNSX = MaNSX;
            this.HamLuong = HamLuong;
            this.MaDVTHL = MaDVTHL;
            this.Nguong = Nguong;
            this.MaDVT = MaDVT;
            this.Quydoi = Quydoi;
            this.MaThuocgoc = MaThuocgoc;
            this.MaDVT2 = MaDVT2;
            this.ApDungGoi = ApDungGoi;
            this.Handung = Handung;
            this.Lieudung = Lieudung;
            this.Cachdung = Cachdung;
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
            this.bh50 = bh50;
            this.ThuocThuT = ThuocThuT;
            this.ThuocPhauT = ThuocPhauT;
            this.ThuocCLS = ThuocCLS;
            this.ThuocDuoc = ThuocDuoc;
            this.ThuocBan = ThuocBan;
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
            this.ThuocNoiT = ThuocNoiT;
            this.MaLH = MaLH;
            this.NguoiQuay = NguoiQuay;
            this.NgayQuay = NgayQuay;
            this.NgayGia = NgayGia;
            this.ThuocBan2 = ThuocBan2;
            this.SoVisa = SoVisa;
            this.MaTK = MaTK;
            this.QuyCach = QuyCach;
            this.MaQG = MaQG;
            this.KhongSD = KhongSD;
            this.MaQL = MaQL;
            this.ThuocHoiChan = ThuocHoiChan;
            this.ThuocTieuHao = ThuocTieuHao;
            this.GiaQuay56 = GiaQuay56;
            this.GiaQuay561 = GiaQuay561;
            this.DuongDung = DuongDung;
            this.MaTP = MaTP;
            this.InThu = InThu;
            this.Gianhap43 = Gianhap43;
            this.Ngaynhap43 = Ngaynhap43;
            this.Gianhap56 = Gianhap56;
            this.Ngaynhap56 = Ngaynhap56;
            this.MaBYTe = MaBYTe;
            this.QuyetDinh = QuyetDinh;
            this.TenTMBH = TenTMBH;
            this.tendvt2 = tendvt2;
            this.TENNHOM = TENNHOM;
            this.TENPL = TENPL;
            this.TENCHUNGLOAI = TENCHUNGLOAI;
            this.TENNSX = TENNSX;
            this.TENDVT = TENDVT;
            this.TENGOC1 = TENGOC1;
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
        public DMTHUOC_Hue(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaThuoc"].GetType().Name != "DBNull" && dr["MaThuoc"] != null)
            { this.MaThuoc = Convert.ToString(dr["MaThuoc"]); }
            else
            {
                MaThuoc = "";
            }
            if (dr["Parent"].GetType().Name != "DBNull" && dr["Parent"] != null)
            { this.Parent = Convert.ToString(dr["Parent"]); }
            else
            {
                Parent = "";
            }
            if (dr["MaNhom"].GetType().Name != "DBNull" && dr["MaNhom"] != null)
            { this.MaNhom = Convert.ToString(dr["MaNhom"]); }
            else
            {
                MaNhom = "";
            }
            if (dr["MaPL"].GetType().Name != "DBNull" && dr["MaPL"] != null)
            { this.MaPL = Convert.ToString(dr["MaPL"]); }
            else
            {
                MaPL = "";
            }
            if (dr["MaChungLoai"].GetType().Name != "DBNull" && dr["MaChungLoai"] != null)
            { this.MaChungLoai = Convert.ToString(dr["MaChungLoai"]); }
            else
            {
                MaChungLoai = "";
            }
            if (dr["TenGoc"].GetType().Name != "DBNull" && dr["TenGoc"] != null)
            { this.TenGoc = Convert.ToString(dr["TenGoc"]); }
            else
            {
                TenGoc = "";
            }
            if (dr["TenTC"].GetType().Name != "DBNull" && dr["TenTC"] != null)
            { this.TenTC = Convert.ToString(dr["TenTC"]); }
            else
            {
                TenTC = "";
            }
            if (dr["TenTM"].GetType().Name != "DBNull" && dr["TenTM"] != null)
            { this.TenTM = Convert.ToString(dr["TenTM"]); }
            else
            {
                TenTM = "";
            }
            if (dr["TenTM1"].GetType().Name != "DBNull" && dr["TenTM1"] != null)
            { this.TenTM1 = Convert.ToString(dr["TenTM1"]); }
            else
            {
                TenTM1 = "";
            }
            if (dr["TenTM2"].GetType().Name != "DBNull" && dr["TenTM2"] != null)
            { this.TenTM2 = Convert.ToString(dr["TenTM2"]); }
            else
            {
                TenTM2 = "";
            }
            if (dr["tenTA"].GetType().Name != "DBNull" && dr["tenTA"] != null)
            { this.tenTA = Convert.ToString(dr["tenTA"]); }
            else
            {
                tenTA = "";
            }
            if (dr["ThuocGoc"].GetType().Name != "DBNull" && dr["ThuocGoc"] != null)
            { this.ThuocGoc = Convert.ToBoolean(dr["ThuocGoc"]); }
            else
            {
                ThuocGoc = false;
            }
            if (dr["Ngaydungtoida"].GetType().Name != "DBNull" && dr["Ngaydungtoida"] != null)
            { this.Ngaydungtoida = Convert.ToDecimal(dr["Ngaydungtoida"]); }
            else
            {
                Ngaydungtoida = 0;
            }
            if (dr["MaNSX"].GetType().Name != "DBNull" && dr["MaNSX"] != null)
            { this.MaNSX = Convert.ToString(dr["MaNSX"]); }
            else
            {
                MaNSX = "";
            }
            if (dr["HamLuong"].GetType().Name != "DBNull" && dr["HamLuong"] != null)
            { this.HamLuong = Convert.ToString(dr["HamLuong"]); }
            else
            {
                HamLuong = "";
            }
            if (dr["MaDVTHL"].GetType().Name != "DBNull" && dr["MaDVTHL"] != null)
            { this.MaDVTHL = Convert.ToString(dr["MaDVTHL"]); }
            else
            {
                MaDVTHL = "";
            }
            if (dr["Nguong"].GetType().Name != "DBNull" && dr["Nguong"] != null)
            { this.Nguong = Convert.ToDecimal(dr["Nguong"]); }
            else
            {
                Nguong = 0;
            }
            if (dr["MaDVT"].GetType().Name != "DBNull" && dr["MaDVT"] != null)
            { this.MaDVT = Convert.ToString(dr["MaDVT"]); }
            else
            {
                MaDVT = "";
            }
            if (dr["Quydoi"].GetType().Name != "DBNull" && dr["Quydoi"] != null)
            { this.Quydoi = Convert.ToDecimal(dr["Quydoi"]); }
            else
            {
                Quydoi = 0;
            }
            if (dr["MaThuocgoc"].GetType().Name != "DBNull" && dr["MaThuocgoc"] != null)
            { this.MaThuocgoc = Convert.ToString(dr["MaThuocgoc"]); }
            else
            {
                MaThuocgoc = "";
            }
            if (dr["MaDVT2"].GetType().Name != "DBNull" && dr["MaDVT2"] != null)
            { this.MaDVT2 = Convert.ToString(dr["MaDVT2"]); }
            else
            {
                MaDVT2 = "";
            }
            if (dr["ApDungGoi"].GetType().Name != "DBNull" && dr["ApDungGoi"] != null)
            { this.ApDungGoi = Convert.ToBoolean(dr["ApDungGoi"]); }
            else
            {
                ApDungGoi = false;
            }
            if (dr["Handung"].GetType().Name != "DBNull" && dr["Handung"] != null)
            { this.Handung = Convert.ToBoolean(dr["Handung"]); }
            else
            {
                Handung = false;
            }
            if (dr["Lieudung"].GetType().Name != "DBNull" && dr["Lieudung"] != null)
            { this.Lieudung = Convert.ToString(dr["Lieudung"]); }
            else
            {
                Lieudung = "";
            }
            if (dr["Cachdung"].GetType().Name != "DBNull" && dr["Cachdung"] != null)
            { this.Cachdung = Convert.ToString(dr["Cachdung"]); }
            else
            {
                Cachdung = "";
            }
            if (dr["Gianhap"].GetType().Name != "DBNull" && dr["Gianhap"] != null)
            { this.Gianhap = Convert.ToDecimal(dr["Gianhap"]); }
            else
            {
                Gianhap = 0;
            }
            if (dr["Ngaynhap"].GetType().Name != "DBNull" && dr["Ngaynhap"] != null)
            {
                this.Ngaynhap = Convert.ToDateTime(dr["Ngaynhap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngaynhap = "";
            }
            if (dr["Gianhap1"].GetType().Name != "DBNull" && dr["Gianhap1"] != null)
            { this.Gianhap1 = Convert.ToDecimal(dr["Gianhap1"]); }
            else
            {
                Gianhap1 = 0;
            }
            if (dr["Ngaynhap1"].GetType().Name != "DBNull" && dr["Ngaynhap1"] != null)
            {
                this.Ngaynhap1 = Convert.ToDateTime(dr["Ngaynhap1"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngaynhap1 = "";
            }
            if (dr["Gianhap2"].GetType().Name != "DBNull" && dr["Gianhap2"] != null)
            { this.Gianhap2 = Convert.ToDecimal(dr["Gianhap2"]); }
            else
            {
                Gianhap2 = 0;
            }
            if (dr["Ngaynhap2"].GetType().Name != "DBNull" && dr["Ngaynhap2"] != null)
            {
                this.Ngaynhap2 = Convert.ToDateTime(dr["Ngaynhap2"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngaynhap2 = "";
            }
            if (dr["DonGiaTT"].GetType().Name != "DBNull" && dr["DonGiaTT"] != null)
            { this.DonGiaTT = Convert.ToDecimal(dr["DonGiaTT"]); }
            else
            {
                DonGiaTT = 0;
            }
            if (dr["DonGiaTT1"].GetType().Name != "DBNull" && dr["DonGiaTT1"] != null)
            { this.DonGiaTT1 = Convert.ToDecimal(dr["DonGiaTT1"]); }
            else
            {
                DonGiaTT1 = 0;
            }
            if (dr["DongiaThuT"].GetType().Name != "DBNull" && dr["DongiaThuT"] != null)
            { this.DongiaThuT = Convert.ToDecimal(dr["DongiaThuT"]); }
            else
            {
                DongiaThuT = 0;
            }
            if (dr["DongiaPhauT"].GetType().Name != "DBNull" && dr["DongiaPhauT"] != null)
            { this.DongiaPhauT = Convert.ToDecimal(dr["DongiaPhauT"]); }
            else
            {
                DongiaPhauT = 0;
            }
            if (dr["DongiaCLS"].GetType().Name != "DBNull" && dr["DongiaCLS"] != null)
            { this.DongiaCLS = Convert.ToDecimal(dr["DongiaCLS"]); }
            else
            {
                DongiaCLS = 0;
            }
            if (dr["GiaQuay"].GetType().Name != "DBNull" && dr["GiaQuay"] != null)
            { this.GiaQuay = Convert.ToDecimal(dr["GiaQuay"]); }
            else
            {
                GiaQuay = 0;
            }
            if (dr["GiaQuay1"].GetType().Name != "DBNull" && dr["GiaQuay1"] != null)
            { this.GiaQuay1 = Convert.ToDecimal(dr["GiaQuay1"]); }
            else
            {
                GiaQuay1 = 0;
            }
            if (dr["Khoban"].GetType().Name != "DBNull" && dr["Khoban"] != null)
            { this.Khoban = Convert.ToString(dr["Khoban"]); }
            else
            {
                Khoban = "";
            }
            if (dr["Khophat"].GetType().Name != "DBNull" && dr["Khophat"] != null)
            { this.Khophat = Convert.ToString(dr["Khophat"]); }
            else
            {
                Khophat = "";
            }
            if (dr["bh50"].GetType().Name != "DBNull" && dr["bh50"] != null)
            { this.bh50 = Convert.ToBoolean(dr["bh50"]); }
            else
            {
                bh50 = false;
            }
            if (dr["ThuocThuT"].GetType().Name != "DBNull" && dr["ThuocThuT"] != null)
            { this.ThuocThuT = Convert.ToBoolean(dr["ThuocThuT"]); }
            else
            {
                ThuocThuT = false;
            }
            if (dr["ThuocPhauT"].GetType().Name != "DBNull" && dr["ThuocPhauT"] != null)
            { this.ThuocPhauT = Convert.ToBoolean(dr["ThuocPhauT"]); }
            else
            {
                ThuocPhauT = false;
            }
            if (dr["ThuocCLS"].GetType().Name != "DBNull" && dr["ThuocCLS"] != null)
            { this.ThuocCLS = Convert.ToBoolean(dr["ThuocCLS"]); }
            else
            {
                ThuocCLS = false;
            }
            if (dr["ThuocDuoc"].GetType().Name != "DBNull" && dr["ThuocDuoc"] != null)
            { this.ThuocDuoc = Convert.ToBoolean(dr["ThuocDuoc"]); }
            else
            {
                ThuocDuoc = false;
            }
            if (dr["ThuocBan"].GetType().Name != "DBNull" && dr["ThuocBan"] != null)
            { this.ThuocBan = Convert.ToBoolean(dr["ThuocBan"]); }
            else
            {
                ThuocBan = false;
            }
            if (dr["DuyetNgoaiT"].GetType().Name != "DBNull" && dr["DuyetNgoaiT"] != null)
            { this.DuyetNgoaiT = Convert.ToBoolean(dr["DuyetNgoaiT"]); }
            else
            {
                DuyetNgoaiT = false;
            }
            if (dr["DuyetNoiT"].GetType().Name != "DBNull" && dr["DuyetNoiT"] != null)
            { this.DuyetNoiT = Convert.ToBoolean(dr["DuyetNoiT"]); }
            else
            {
                DuyetNoiT = false;
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            { this.Ghichu = Convert.ToString(dr["Ghichu"]); }
            else
            {
                Ghichu = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            { this.MaMay = Convert.ToString(dr["MaMay"]); }
            else
            {
                MaMay = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            { this.Huy = Convert.ToBoolean(dr["Huy"]); }
            else
            {
                Huy = false;
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            { this.NguoiSD = Convert.ToString(dr["NguoiSD"]); }
            else
            {
                NguoiSD = "";
            }
            if (dr["NgaySD1"].GetType().Name != "DBNull" && dr["NgaySD1"] != null)
            {
                this.NgaySD1 = Convert.ToDateTime(dr["NgaySD1"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgaySD1 = "";
            }
            if (dr["NguoiSD1"].GetType().Name != "DBNull" && dr["NguoiSD1"] != null)
            { this.NguoiSD1 = Convert.ToString(dr["NguoiSD1"]); }
            else
            {
                NguoiSD1 = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayLap = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            { this.NguoiLap = Convert.ToString(dr["NguoiLap"]); }
            else
            {
                NguoiLap = "";
            }
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayHuy = "";
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            { this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]); }
            else
            {
                NguoiHuy = "";
            }
            if (dr["ThuocNoiT"].GetType().Name != "DBNull" && dr["ThuocNoiT"] != null)
            { this.ThuocNoiT = Convert.ToBoolean(dr["ThuocNoiT"]); }
            else
            {
                ThuocNoiT = false;
            }
            if (dr["MaLH"].GetType().Name != "DBNull" && dr["MaLH"] != null)
            { this.MaLH = Convert.ToString(dr["MaLH"]); }
            else
            {
                MaLH = "";
            }
            if (dr["NguoiQuay"].GetType().Name != "DBNull" && dr["NguoiQuay"] != null)
            { this.NguoiQuay = Convert.ToString(dr["NguoiQuay"]); }
            else
            {
                NguoiQuay = "";
            }
            if (dr["NgayQuay"].GetType().Name != "DBNull" && dr["NgayQuay"] != null)
            {
                this.NgayQuay = Convert.ToDateTime(dr["NgayQuay"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayQuay = "";
            }
            if (dr["NgayGia"].GetType().Name != "DBNull" && dr["NgayGia"] != null)
            {
                this.NgayGia = Convert.ToDateTime(dr["NgayGia"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayGia = "";
            }
            if (dr["ThuocBan2"].GetType().Name != "DBNull" && dr["ThuocBan2"] != null)
            { this.ThuocBan2 = Convert.ToBoolean(dr["ThuocBan2"]); }
            else
            {
                ThuocBan2 = false;
            }
            if (dr["SoVisa"].GetType().Name != "DBNull" && dr["SoVisa"] != null)
            { this.SoVisa = Convert.ToString(dr["SoVisa"]); }
            else
            {
                SoVisa = "";
            }
            if (dr["MaTK"].GetType().Name != "DBNull" && dr["MaTK"] != null)
            { this.MaTK = Convert.ToString(dr["MaTK"]); }
            else
            {
                MaTK = "";
            }
            if (dr["QuyCach"].GetType().Name != "DBNull" && dr["QuyCach"] != null)
            { this.QuyCach = Convert.ToString(dr["QuyCach"]); }
            else
            {
                QuyCach = "";
            }
            if (dr["MaQG"].GetType().Name != "DBNull" && dr["MaQG"] != null)
            { this.MaQG = Convert.ToString(dr["MaQG"]); }
            else
            {
                MaQG = "";
            }
            if (dr["KhongSD"].GetType().Name != "DBNull" && dr["KhongSD"] != null)
            { this.KhongSD = Convert.ToBoolean(dr["KhongSD"]); }
            else
            {
                KhongSD = false;
            }
            if (dr["MaQL"].GetType().Name != "DBNull" && dr["MaQL"] != null)
            { this.MaQL = Convert.ToString(dr["MaQL"]); }
            else
            {
                MaQL = "";
            }
            if (dr["ThuocHoiChan"].GetType().Name != "DBNull" && dr["ThuocHoiChan"] != null)
            { this.ThuocHoiChan = Convert.ToBoolean(dr["ThuocHoiChan"]); }
            else
            {
                ThuocHoiChan = false;
            }
            if (dr["ThuocTieuHao"].GetType().Name != "DBNull" && dr["ThuocTieuHao"] != null)
            { this.ThuocTieuHao = Convert.ToByte(dr["ThuocTieuHao"]); }
            else
            {
                ThuocTieuHao = 0;
            }
            if (dr["GiaQuay56"].GetType().Name != "DBNull" && dr["GiaQuay56"] != null)
            { this.GiaQuay56 = Convert.ToDecimal(dr["GiaQuay56"]); }
            else
            {
                GiaQuay56 = 0;
            }
            if (dr["GiaQuay561"].GetType().Name != "DBNull" && dr["GiaQuay561"] != null)
            { this.GiaQuay561 = Convert.ToDecimal(dr["GiaQuay561"]); }
            else
            {
                GiaQuay561 = 0;
            }
            if (dr["DuongDung"].GetType().Name != "DBNull" && dr["DuongDung"] != null)
            { this.DuongDung = Convert.ToString(dr["DuongDung"]); }
            else
            {
                DuongDung = "";
            }
            if (dr["MaTP"].GetType().Name != "DBNull" && dr["MaTP"] != null)
            { this.MaTP = Convert.ToString(dr["MaTP"]); }
            else
            {
                MaTP = "";
            }
            if (dr["InThu"].GetType().Name != "DBNull" && dr["InThu"] != null)
            { this.InThu = Convert.ToBoolean(dr["InThu"]); }
            else
            {
                InThu = false;
            }
            if (dr["Gianhap43"].GetType().Name != "DBNull" && dr["Gianhap43"] != null)
            { this.Gianhap43 = Convert.ToDecimal(dr["Gianhap43"]); }
            else
            {
                Gianhap43 = 0;
            }
            if (dr["Ngaynhap43"].GetType().Name != "DBNull" && dr["Ngaynhap43"] != null)
            {
                this.Ngaynhap43 = Convert.ToDateTime(dr["Ngaynhap43"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngaynhap43 = "";
            }
            if (dr["Gianhap56"].GetType().Name != "DBNull" && dr["Gianhap56"] != null)
            { this.Gianhap56 = Convert.ToDecimal(dr["Gianhap56"]); }
            else
            {
                Gianhap56 = 0;
            }
            if (dr["Ngaynhap56"].GetType().Name != "DBNull" && dr["Ngaynhap56"] != null)
            {
                this.Ngaynhap56 = Convert.ToDateTime(dr["Ngaynhap56"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngaynhap56 = "";
            }
            if (dr["MaBYTe"].GetType().Name != "DBNull" && dr["MaBYTe"] != null)
            { this.MaBYTe = Convert.ToString(dr["MaBYTe"]); }
            else
            {
                MaBYTe = "";
            }
            if (dr["QuyetDinh"].GetType().Name != "DBNull" && dr["QuyetDinh"] != null)
            { this.QuyetDinh = Convert.ToString(dr["QuyetDinh"]); }
            else
            {
                QuyetDinh = "";
            }
            if (dr["TenTMBH"].GetType().Name != "DBNull" && dr["TenTMBH"] != null)
            { this.TenTMBH = Convert.ToString(dr["TenTMBH"]); }
            else
            {
                TenTMBH = "";
            }
            if (dr["tendvt2"].GetType().Name != "DBNull" && dr["tendvt2"] != null)
            { this.tendvt2 = Convert.ToString(dr["tendvt2"]); }
            else
            {
                tendvt2 = "";
            }
            if (dr["TENNHOM"].GetType().Name != "DBNull" && dr["TENNHOM"] != null)
            { this.TENNHOM = Convert.ToString(dr["TENNHOM"]); }
            else
            {
                TENNHOM = "";
            }
            if (dr["TENPL"].GetType().Name != "DBNull" && dr["TENPL"] != null)
            { this.TENPL = Convert.ToString(dr["TENPL"]); }
            else
            {
                TENPL = "";
            }
            if (dr["TENCHUNGLOAI"].GetType().Name != "DBNull" && dr["TENCHUNGLOAI"] != null)
            { this.TENCHUNGLOAI = Convert.ToString(dr["TENCHUNGLOAI"]); }
            else
            {
                TENCHUNGLOAI = "";
            }
            if (dr["TENNSX"].GetType().Name != "DBNull" && dr["TENNSX"] != null)
            { this.TENNSX = Convert.ToString(dr["TENNSX"]); }
            else
            {
                TENNSX = "";
            }
            if (dr["TENDVT"].GetType().Name != "DBNull" && dr["TENDVT"] != null)
            { this.TENDVT = Convert.ToString(dr["TENDVT"]); }
            else
            {
                TENDVT = "";
            }
            if (dr["TENGOC1"].GetType().Name != "DBNull" && dr["TENGOC1"] != null)
            { this.TENGOC1 = Convert.ToString(dr["TENGOC1"]); }
            else
            {
                TENGOC1 = "";
            }
            if (dr["TENKHOBAN"].GetType().Name != "DBNull" && dr["TENKHOBAN"] != null)
            { this.TENKHOBAN = Convert.ToString(dr["TENKHOBAN"]); }
            else
            {
                TENKHOBAN = "";
            }
            if (dr["TENKHOPHAT"].GetType().Name != "DBNull" && dr["TENKHOPHAT"] != null)
            { this.TENKHOPHAT = Convert.ToString(dr["TENKHOPHAT"]); }
            else
            {
                TENKHOPHAT = "";
            }
            if (dr["TENNGUOILAP"].GetType().Name != "DBNull" && dr["TENNGUOILAP"] != null)
            { this.TENNGUOILAP = Convert.ToString(dr["TENNGUOILAP"]); }
            else
            {
                TENNGUOILAP = "";
            }
            if (dr["TENNGUOISD"].GetType().Name != "DBNull" && dr["TENNGUOISD"] != null)
            { this.TENNGUOISD = Convert.ToString(dr["TENNGUOISD"]); }
            else
            {
                TENNGUOISD = "";
            }
            if (dr["TENNGUOIHUY"].GetType().Name != "DBNull" && dr["TENNGUOIHUY"] != null)
            { this.TENNGUOIHUY = Convert.ToString(dr["TENNGUOIHUY"]); }
            else
            {
                TENNGUOIHUY = "";
            }
            if (dr["TENDVTHL"].GetType().Name != "DBNull" && dr["TENDVTHL"] != null)
            { this.TENDVTHL = Convert.ToString(dr["TENDVTHL"]); }
            else
            {
                TENDVTHL = "";
            }
            if (dr["DongiaBH"].GetType().Name != "DBNull" && dr["DongiaBH"] != null)
            { this.DongiaBH = Convert.ToDecimal(dr["DongiaBH"]); }
            else
            {
                DongiaBH = 0;
            }
            if (dr["GiaChenhlech"].GetType().Name != "DBNull" && dr["GiaChenhlech"] != null)
            { this.GiaChenhlech = Convert.ToDecimal(dr["GiaChenhlech"]); }
            else
            {
                GiaChenhlech = 0;
            }
            if (dr["ADChenhlech"].GetType().Name != "DBNull" && dr["ADChenhlech"] != null)
            { this.ADChenhlech = Convert.ToBoolean(dr["ADChenhlech"]); }
            else
            {
                ADChenhlech = false;
            }
            if (dr["DTBH"].GetType().Name != "DBNull" && dr["DTBH"] != null)
            { this.DTBH = Convert.ToBoolean(dr["DTBH"]); }
            else
            {
                DTBH = false;
            }
            this.Ordernumber = Ordernumber;
        }
    }

    [Serializable()]
    public class DMThuoc_HueList : List<DMTHUOC_Hue>
    {

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMThuoc_HueList FindDMThuocMa(String Ma, Boolean QAdmin)
        {
            Ma = " and (a.MAthuoc like N'%" + Ma + "%' or a.MAql like N'%" + Ma + "%')";
            DMThuoc_HueList List = new DMThuoc_HueList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMTHUOC_FINDS_Hue", Ma, QAdmin))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new DMTHUOC_Hue(dr, Ordernumber));
                }
            }
            return List;
        }
    }

}
