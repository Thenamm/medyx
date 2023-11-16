using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDichVu_H" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public class DMDichVu_H
    {
        public Int32 Ordernumber { get; set; }
        public String MaDV { get; set; }
        public String MaNHOMDV { get; set; }
        public String TenDV { get; set; }
        public String MaChungloai { get; set; }
        public String MaLH { get; set; }
        public String TenTat { get; set; }
        public Decimal DongiaTT { get; set; }
        public Decimal DongiaTT1 { get; set; }
        public String Makhoa { get; set; }
        public String TenTA { get; set; }
        public String MaBYTe { get; set; }
        public String QuyetDinh { get; set; }
        public String TenDVBH { get; set; }
        public Boolean NhapSL { get; set; }
        public String SoTban { get; set; }
        public String NgayTT1 { get; set; }
        public String MaBS { get; set; }
        public String Machuyenkhoa { get; set; }
        public Byte Loai { get; set; }
        public Byte NoiThucHien { get; set; }
        public String MaCQ { get; set; }
        public String MaBenhPham { get; set; }
        public Boolean KTCao { get; set; }
        public String ChisocaoNu { get; set; }
        public String ChisocaoNam { get; set; }
        public String ChisothapNu { get; set; }
        public String ChisothapNam { get; set; }
        public String Donvi { get; set; }
        public Boolean ApdungGoi { get; set; }
        public Boolean DichVuGui { get; set; }
        public Byte LoaiKQ { get; set; }
        public String FormSudung { get; set; }
        public Decimal HoaHong { get; set; }
        public Decimal GTHoaHong { get; set; }
        public Boolean TToanSau { get; set; }
        public Boolean TToanNgay { get; set; }
        public Boolean BCThu { get; set; }
        public Boolean InThu { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD1 { get; set; }
        public String NguoiSD1 { get; set; }
        public Boolean Adgiausd { get; set; }
        public String NgayGia { get; set; }
        public Boolean GoiDichVu { get; set; }
        public Boolean LayMauTT { get; set; }
        public String MaKHTH { get; set; }
        public Boolean Apdungnt { get; set; }
        public Boolean Apdungpk { get; set; }
        public Boolean Apdungnk { get; set; }
        public Boolean Apdungsuagia { get; set; }
        public String MaLoaiTT { get; set; }
        public String Makhoa087 { get; set; }
        public String MakhoaNG { get; set; }
        public Decimal DonGiaCLC { get; set; }
        public String FormSudung087 { get; set; }
        public String MakhoaLM { get; set; }
        public String MakhoaLM087 { get; set; }
        public String MakhoaLMNG { get; set; }
        public String TENNHOMDV { get; set; }
        public String TENNGUOILAP { get; set; }
        public String TENNGUOISD { get; set; }
        public String TENNGUOIHUY { get; set; }
        public Decimal DongiaBH { get; set; }
        public Decimal GiaChenhlenh { get; set; }
        public Boolean ADChenhlech { get; set; }
        public Boolean DTBH { get; set; }
        public DMDichVu_H(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaDV"].GetType().Name != "DBNull" && dr["MaDV"] != null)
            { this.MaDV = Convert.ToString(dr["MaDV"]); }
            else
            {
                MaDV = "";
            }
            if (dr["MaNHOMDV"].GetType().Name != "DBNull" && dr["MaNHOMDV"] != null)
            { this.MaNHOMDV = Convert.ToString(dr["MaNHOMDV"]); }
            else
            {
                MaNHOMDV = "";
            }
            if (dr["TenDV"].GetType().Name != "DBNull" && dr["TenDV"] != null)
            { this.TenDV = Convert.ToString(dr["TenDV"]); }
            else
            {
                TenDV = "";
            }
            if (dr["MaChungloai"].GetType().Name != "DBNull" && dr["MaChungloai"] != null)
            { this.MaChungloai = Convert.ToString(dr["MaChungloai"]); }
            else
            {
                MaChungloai = "";
            }
            if (dr["MaLH"].GetType().Name != "DBNull" && dr["MaLH"] != null)
            { this.MaLH = Convert.ToString(dr["MaLH"]); }
            else
            {
                MaLH = "";
            }
            if (dr["TenTat"].GetType().Name != "DBNull" && dr["TenTat"] != null)
            { this.TenTat = Convert.ToString(dr["TenTat"]); }
            else
            {
                TenTat = "";
            }
            if (dr["DongiaTT"].GetType().Name != "DBNull" && dr["DongiaTT"] != null)
            { this.DongiaTT = Convert.ToDecimal(dr["DongiaTT"]); }
            else
            {
                DongiaTT = 0;
            }
            if (dr["DongiaTT1"].GetType().Name != "DBNull" && dr["DongiaTT1"] != null)
            { this.DongiaTT1 = Convert.ToDecimal(dr["DongiaTT1"]); }
            else
            {
                DongiaTT1 = 0;
            }
            if (dr["Makhoa"].GetType().Name != "DBNull" && dr["Makhoa"] != null)
            { this.Makhoa = Convert.ToString(dr["Makhoa"]); }
            else
            {
                Makhoa = "";
            }
            if (dr["TenTA"].GetType().Name != "DBNull" && dr["TenTA"] != null)
            { this.TenTA = Convert.ToString(dr["TenTA"]); }
            else
            {
                TenTA = "";
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
            if (dr["TenDVBH"].GetType().Name != "DBNull" && dr["TenDVBH"] != null)
            { this.TenDVBH = Convert.ToString(dr["TenDVBH"]); }
            else
            {
                TenDVBH = "";
            }
            if (dr["NhapSL"].GetType().Name != "DBNull" && dr["NhapSL"] != null)
            { this.NhapSL = Convert.ToBoolean(dr["NhapSL"]); }
            else
            {
                NhapSL = false;
            }
            if (dr["SoTban"].GetType().Name != "DBNull" && dr["SoTban"] != null)
            { this.SoTban = Convert.ToString(dr["SoTban"]); }
            else
            {
                SoTban = "";
            }
            if (dr["NgayTT1"].GetType().Name != "DBNull" && dr["NgayTT1"] != null)
            {
                this.NgayTT1 = Convert.ToDateTime(dr["NgayTT1"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayTT1 = "";
            }
            if (dr["MaBS"].GetType().Name != "DBNull" && dr["MaBS"] != null)
            { this.MaBS = Convert.ToString(dr["MaBS"]); }
            else
            {
                MaBS = "";
            }
            if (dr["Machuyenkhoa"].GetType().Name != "DBNull" && dr["Machuyenkhoa"] != null)
            { this.Machuyenkhoa = Convert.ToString(dr["Machuyenkhoa"]); }
            else
            {
                Machuyenkhoa = "";
            }
            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
            { this.Loai = Convert.ToByte(dr["Loai"]); }
            else
            {
                Loai = 0;
            }
            if (dr["NoiThucHien"].GetType().Name != "DBNull" && dr["NoiThucHien"] != null)
            { this.NoiThucHien = Convert.ToByte(dr["NoiThucHien"]); }
            else
            {
                NoiThucHien = 0;
            }
            if (dr["MaCQ"].GetType().Name != "DBNull" && dr["MaCQ"] != null)
            { this.MaCQ = Convert.ToString(dr["MaCQ"]); }
            else
            {
                MaCQ = "";
            }
            if (dr["MaBenhPham"].GetType().Name != "DBNull" && dr["MaBenhPham"] != null)
            { this.MaBenhPham = Convert.ToString(dr["MaBenhPham"]); }
            else
            {
                MaBenhPham = "";
            }
            if (dr["KTCao"].GetType().Name != "DBNull" && dr["KTCao"] != null)
            { this.KTCao = Convert.ToBoolean(dr["KTCao"]); }
            else
            {
                KTCao = false;
            }
            if (dr["ChisocaoNu"].GetType().Name != "DBNull" && dr["ChisocaoNu"] != null)
            { this.ChisocaoNu = Convert.ToString(dr["ChisocaoNu"]); }
            else
            {
                ChisocaoNu = "";
            }
            if (dr["ChisocaoNam"].GetType().Name != "DBNull" && dr["ChisocaoNam"] != null)
            { this.ChisocaoNam = Convert.ToString(dr["ChisocaoNam"]); }
            else
            {
                ChisocaoNam = "";
            }
            if (dr["ChisothapNu"].GetType().Name != "DBNull" && dr["ChisothapNu"] != null)
            { this.ChisothapNu = Convert.ToString(dr["ChisothapNu"]); }
            else
            {
                ChisothapNu = "";
            }
            if (dr["ChisothapNam"].GetType().Name != "DBNull" && dr["ChisothapNam"] != null)
            { this.ChisothapNam = Convert.ToString(dr["ChisothapNam"]); }
            else
            {
                ChisothapNam = "";
            }
            if (dr["Donvi"].GetType().Name != "DBNull" && dr["Donvi"] != null)
            { this.Donvi = Convert.ToString(dr["Donvi"]); }
            else
            {
                Donvi = "";
            }
            if (dr["ApdungGoi"].GetType().Name != "DBNull" && dr["ApdungGoi"] != null)
            { this.ApdungGoi = Convert.ToBoolean(dr["ApdungGoi"]); }
            else
            {
                ApdungGoi = false;
            }
            if (dr["DichVuGui"].GetType().Name != "DBNull" && dr["DichVuGui"] != null)
            { this.DichVuGui = Convert.ToBoolean(dr["DichVuGui"]); }
            else
            {
                DichVuGui = false;
            }
            if (dr["LoaiKQ"].GetType().Name != "DBNull" && dr["LoaiKQ"] != null)
            { this.LoaiKQ = Convert.ToByte(dr["LoaiKQ"]); }
            else
            {
                LoaiKQ = 0;
            }
            if (dr["FormSudung"].GetType().Name != "DBNull" && dr["FormSudung"] != null)
            { this.FormSudung = Convert.ToString(dr["FormSudung"]); }
            else
            {
                FormSudung = "";
            }
            if (dr["HoaHong"].GetType().Name != "DBNull" && dr["HoaHong"] != null)
            { this.HoaHong = Convert.ToDecimal(dr["HoaHong"]); }
            else
            {
                HoaHong = 0;
            }
            if (dr["GTHoaHong"].GetType().Name != "DBNull" && dr["GTHoaHong"] != null)
            { this.GTHoaHong = Convert.ToDecimal(dr["GTHoaHong"]); }
            else
            {
                GTHoaHong = 0;
            }
            if (dr["TToanSau"].GetType().Name != "DBNull" && dr["TToanSau"] != null)
            { this.TToanSau = Convert.ToBoolean(dr["TToanSau"]); }
            else
            {
                TToanSau = false;
            }
            if (dr["TToanNgay"].GetType().Name != "DBNull" && dr["TToanNgay"] != null)
            { this.TToanNgay = Convert.ToBoolean(dr["TToanNgay"]); }
            else
            {
                TToanNgay = false;
            }
            if (dr["BCThu"].GetType().Name != "DBNull" && dr["BCThu"] != null)
            { this.BCThu = Convert.ToBoolean(dr["BCThu"]); }
            else
            {
                BCThu = false;
            }
            if (dr["InThu"].GetType().Name != "DBNull" && dr["InThu"] != null)
            { this.InThu = Convert.ToBoolean(dr["InThu"]); }
            else
            {
                InThu = false;
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
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            { this.Huy = Convert.ToBoolean(dr["Huy"]); }
            else
            {
                Huy = false;
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
            if (dr["Adgiausd"].GetType().Name != "DBNull" && dr["Adgiausd"] != null)
            { this.Adgiausd = Convert.ToBoolean(dr["Adgiausd"]); }
            else
            {
                Adgiausd = false;
            }
            if (dr["NgayGia"].GetType().Name != "DBNull" && dr["NgayGia"] != null)
            {
                this.NgayGia = Convert.ToDateTime(dr["NgayGia"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayGia = "";
            }
            if (dr["GoiDichVu"].GetType().Name != "DBNull" && dr["GoiDichVu"] != null)
            { this.GoiDichVu = Convert.ToBoolean(dr["GoiDichVu"]); }
            else
            {
                GoiDichVu = false;
            }
            if (dr["LayMauTT"].GetType().Name != "DBNull" && dr["LayMauTT"] != null)
            { this.LayMauTT = Convert.ToBoolean(dr["LayMauTT"]); }
            else
            {
                LayMauTT = false;
            }
            if (dr["MaKHTH"].GetType().Name != "DBNull" && dr["MaKHTH"] != null)
            { this.MaKHTH = Convert.ToString(dr["MaKHTH"]); }
            else
            {
                MaKHTH = "";
            }
            if (dr["Apdungnt"].GetType().Name != "DBNull" && dr["Apdungnt"] != null)
            { this.Apdungnt = Convert.ToBoolean(dr["Apdungnt"]); }
            else
            {
                Apdungnt = false;
            }
            if (dr["Apdungpk"].GetType().Name != "DBNull" && dr["Apdungpk"] != null)
            { this.Apdungpk = Convert.ToBoolean(dr["Apdungpk"]); }
            else
            {
                Apdungpk = false;
            }
            if (dr["Apdungnk"].GetType().Name != "DBNull" && dr["Apdungnk"] != null)
            { this.Apdungnk = Convert.ToBoolean(dr["Apdungnk"]); }
            else
            {
                Apdungnk = false;
            }
            if (dr["Apdungsuagia"].GetType().Name != "DBNull" && dr["Apdungsuagia"] != null)
            { this.Apdungsuagia = Convert.ToBoolean(dr["Apdungsuagia"]); }
            else
            {
                Apdungsuagia = false;
            }
            if (dr["MaLoaiTT"].GetType().Name != "DBNull" && dr["MaLoaiTT"] != null)
            { this.MaLoaiTT = Convert.ToString(dr["MaLoaiTT"]); }
            else
            {
                MaLoaiTT = "";
            }
            if (dr["Makhoa087"].GetType().Name != "DBNull" && dr["Makhoa087"] != null)
            { this.Makhoa087 = Convert.ToString(dr["Makhoa087"]); }
            else
            {
                Makhoa087 = "";
            }
            if (dr["MakhoaNG"].GetType().Name != "DBNull" && dr["MakhoaNG"] != null)
            { this.MakhoaNG = Convert.ToString(dr["MakhoaNG"]); }
            else
            {
                MakhoaNG = "";
            }
            if (dr["DonGiaCLC"].GetType().Name != "DBNull" && dr["DonGiaCLC"] != null)
            { this.DonGiaCLC = Convert.ToDecimal(dr["DonGiaCLC"]); }
            else
            {
                DonGiaCLC = 0;
            }
            if (dr["FormSudung087"].GetType().Name != "DBNull" && dr["FormSudung087"] != null)
            { this.FormSudung087 = Convert.ToString(dr["FormSudung087"]); }
            else
            {
                FormSudung087 = "";
            }
            if (dr["MakhoaLM"].GetType().Name != "DBNull" && dr["MakhoaLM"] != null)
            { this.MakhoaLM = Convert.ToString(dr["MakhoaLM"]); }
            else
            {
                MakhoaLM = "";
            }
            if (dr["MakhoaLM087"].GetType().Name != "DBNull" && dr["MakhoaLM087"] != null)
            { this.MakhoaLM087 = Convert.ToString(dr["MakhoaLM087"]); }
            else
            {
                MakhoaLM087 = "";
            }
            if (dr["MakhoaLMNG"].GetType().Name != "DBNull" && dr["MakhoaLMNG"] != null)
            { this.MakhoaLMNG = Convert.ToString(dr["MakhoaLMNG"]); }
            else
            {
                MakhoaLMNG = "";
            }
            if (dr["TENNHOMDV"].GetType().Name != "DBNull" && dr["TENNHOMDV"] != null)
            { this.TENNHOMDV = Convert.ToString(dr["TENNHOMDV"]); }
            else
            {
                TENNHOMDV = "";
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
            if (dr["DongiaBH"].GetType().Name != "DBNull" && dr["DongiaBH"] != null)
            { this.DongiaBH = Convert.ToDecimal(dr["DongiaBH"]); }
            else
            {
                DongiaBH = 0;
            }
            if (dr["GiaChenhlenh"].GetType().Name != "DBNull" && dr["GiaChenhlenh"] != null)
            { this.GiaChenhlenh = Convert.ToDecimal(dr["GiaChenhlenh"]); }
            else
            {
                GiaChenhlenh = 0;
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
    public class DMDichVu_HList : List<DMDichVu_H>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static DMDichVu_HList FindDMDichVuByMa(string MaDV, Boolean Qadmin)
        {
            String _DK = " and (A.MADV like '%" + MaDV + "' OR b.TENTAT LIKE N'" + MaDV + "%')";
            DMDichVu_HList List = new DMDichVu_HList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spDMDICHVU_FINDS_Hue", MaDV, Qadmin)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    List.Add(new DMDichVu_H(dr, order));
                }
            }
            return List;
        }
    }
}
