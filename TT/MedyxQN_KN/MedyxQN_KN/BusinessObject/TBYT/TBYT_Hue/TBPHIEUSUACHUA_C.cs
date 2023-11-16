using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class TBPHIEUSUACHUA_C
    {
        public Int32 Ordernumber { get; set; }
        public String MaPhieuYC { get; set; }
        public Decimal STT { get; set; }
        public String MaTB { get; set; }
        public Byte LoaiTB { get; set; }
        public String MaCVNhoLe { get; set; }
        public Boolean KS_IsLap { get; set; }
        public String KS_Noidung { get; set; }
        public String KS_MaNV { get; set; }
        public String KS_NgayLap { get; set; }
        public Boolean KS_Huy { get; set; }
        public Boolean DT_IsLap { get; set; }
        public String DT_MaNV { get; set; }
        public String DT_NgayLap { get; set; }
        public String DT_TinhTrang { get; set; }
        public String DT_NguyenNhan { get; set; }
        public String DT_GiaiPhap { get; set; }
        public String DT_MaPXNgoai { get; set; }
        public String DT_MaPX { get; set; }
        public Decimal DT_ChiPhiNC { get; set; }
        public Byte DT_Duyet { get; set; }
        public Byte DT_Phat { get; set; }
        public String DT_LDKhongDuyet { get; set; }
        public String DT_MaNVDuyet { get; set; }
        public String DT_NgayDuyet { get; set; }
        public String DT_MaNVPhat { get; set; }
        public String DT_NgayPhat { get; set; }
        public String NgaySuaChuaBD { get; set; }
        public String NgaySuaChuaKT { get; set; }
        public String SC_NgayHoanThanh { get; set; }
        public String SC_MaNVS { get; set; }
        public String SC_NoiDungCongViec { get; set; }
        public Byte SC_TrangthaiCV { get; set; }
        public String SC_TinhTrangTB { get; set; }
        public String SC_GhiChu { get; set; }
        public Boolean KhongSuachua { get; set; }
        public Boolean Huy { get; set; }
        public String Ngayhuy { get; set; }
        public String Nguoihuy { get; set; }
        public String MaMay { get; set; }
        public String NgayYC { get; set; }
        public String MaKhoaYC { get; set; }
        public String NhanVienYC { get; set; }
        public Decimal SoYC { get; set; }
        public String MoTaYC { get; set; }
        public Byte DuyetYC { get; set; }
        public String NgayDuyetYC { get; set; }
        public String NguoiDuyetYC { get; set; }
        public String LDKhongDuyet { get; set; }
        public String MaDVKS { get; set; }
        public String TenTB { get; set; }
        public String KS_TenNV { get; set; }
        public String DT_TenNV { get; set; }
        public String DT_TenNVDuyet { get; set; }
        public String DT_TenNVPhat { get; set; }
        public String TenNguoiHuy { get; set; }
        public String SC_TenNVS { get; set; }
        public String TenCVNhoLe { get; set; }
        public String TenKhoaYC { get; set; }
        public String TenNhanVienYC { get; set; }
        public String TenNguoiDuyetYC { get; set; }
        public String TenDVKS { get; set; }
        public String TinhTrangPhieu { get; set; }
        public String TenTrangThai { get; set; }
        public String TenTinhTrangTB { get; set; }
        public TBPHIEUSUACHUA_C()
        {
            MaPhieuYC = "";
            STT = 0;
            MaTB = "";
            LoaiTB = 0;
            MaCVNhoLe = "";
            KS_IsLap = false;
            KS_Noidung = "";
            KS_MaNV = "";
            KS_NgayLap = "";
            KS_Huy = false;
            DT_IsLap = false;
            DT_MaNV = "";
            DT_NgayLap = "";
            DT_TinhTrang = "";
            DT_NguyenNhan = "";
            DT_GiaiPhap = "";
            DT_MaPXNgoai = "";
            DT_MaPX = "";
            DT_ChiPhiNC = 0;
            DT_Duyet = 0;
            DT_Phat = 0;
            DT_LDKhongDuyet = "";
            DT_MaNVDuyet = "";
            DT_NgayDuyet = "";
            DT_MaNVPhat = "";
            DT_NgayPhat = "";
            NgaySuaChuaBD = "";
            NgaySuaChuaKT = "";
            SC_NgayHoanThanh = "";
            SC_MaNVS = "";
            SC_NoiDungCongViec = "";
            SC_TrangthaiCV = 0;
            SC_TinhTrangTB = "";
            SC_GhiChu = "";
            KhongSuachua = false;
            Huy = false;
            Ngayhuy = "";
            Nguoihuy = "";
            MaMay = "";
            NgayYC = "";
            MaKhoaYC = "";
            NhanVienYC = "";
            SoYC = 0;
            MoTaYC = "";
            DuyetYC = 0;
            NgayDuyetYC = "";
            NguoiDuyetYC = "";
            LDKhongDuyet = "";
            MaDVKS = "";
            TenTB = "";
            KS_TenNV = "";
            DT_TenNV = "";
            DT_TenNVDuyet = "";
            DT_TenNVPhat = "";
            TenNguoiHuy = "";
            SC_TenNVS = "";
            TenCVNhoLe = "";
            TenKhoaYC = "";
            TenNhanVienYC = "";
            TenNguoiDuyetYC = "";
            TenDVKS = "";
            TinhTrangPhieu = "";
            TenTrangThai = "";
            TenTinhTrangTB = "";
            Ordernumber = 0;
        }
        public TBPHIEUSUACHUA_C(String MaPhieuYC, Decimal STT, String MaTB, Byte LoaiTB, String MaCVNhoLe, Boolean KS_IsLap, String KS_Noidung, String KS_MaNV, String KS_NgayLap, Boolean KS_Huy, Boolean DT_IsLap, String DT_MaNV, String DT_NgayLap, String DT_TinhTrang, String DT_NguyenNhan, String DT_GiaiPhap, String DT_MaPXNgoai, String DT_MaPX, Decimal DT_ChiPhiNC, Byte DT_Duyet, Byte DT_Phat, String DT_LDKhongDuyet, String DT_MaNVDuyet, String DT_NgayDuyet, String DT_MaNVPhat, String DT_NgayPhat, String NgaySuaChuaBD, String NgaySuaChuaKT, String SC_NgayHoanThanh, String SC_MaNVS, String SC_NoiDungCongViec, Byte SC_TrangthaiCV, String SC_TinhTrangTB, String SC_GhiChu, Boolean KhongSuachua, Boolean Huy, String Ngayhuy, String Nguoihuy, String MaMay, String NgayYC, String MaKhoaYC, String NhanVienYC, Decimal SoYC, String MoTaYC, Byte DuyetYC, String NgayDuyetYC, String NguoiDuyetYC, String LDKhongDuyet, String MaDVKS, String TenTB, String KS_TenNV, String DT_TenNV, String DT_TenNVDuyet, String DT_TenNVPhat, String TenNguoiHuy, String SC_TenNVS, String TenCVNhoLe, String TenKhoaYC, String TenNhanVienYC, String TenNguoiDuyetYC, String TenDVKS, String TinhTrangPhieu, String TenTrangThai, String TenTinhTrangTB, Int32 Ordernumber)
        {
            this.MaPhieuYC = MaPhieuYC;
            this.STT = STT;
            this.MaTB = MaTB;
            this.LoaiTB = LoaiTB;
            this.MaCVNhoLe = MaCVNhoLe;
            this.KS_IsLap = KS_IsLap;
            this.KS_Noidung = KS_Noidung;
            this.KS_MaNV = KS_MaNV;
            this.KS_NgayLap = KS_NgayLap;
            this.KS_Huy = KS_Huy;
            this.DT_IsLap = DT_IsLap;
            this.DT_MaNV = DT_MaNV;
            this.DT_NgayLap = DT_NgayLap;
            this.DT_TinhTrang = DT_TinhTrang;
            this.DT_NguyenNhan = DT_NguyenNhan;
            this.DT_GiaiPhap = DT_GiaiPhap;
            this.DT_MaPXNgoai = DT_MaPXNgoai;
            this.DT_MaPX = DT_MaPX;
            this.DT_ChiPhiNC = DT_ChiPhiNC;
            this.DT_Duyet = DT_Duyet;
            this.DT_Phat = DT_Phat;
            this.DT_LDKhongDuyet = DT_LDKhongDuyet;
            this.DT_MaNVDuyet = DT_MaNVDuyet;
            this.DT_NgayDuyet = DT_NgayDuyet;
            this.DT_MaNVPhat = DT_MaNVPhat;
            this.DT_NgayPhat = DT_NgayPhat;
            this.NgaySuaChuaBD = NgaySuaChuaBD;
            this.NgaySuaChuaKT = NgaySuaChuaKT;
            this.SC_NgayHoanThanh = SC_NgayHoanThanh;
            this.SC_MaNVS = SC_MaNVS;
            this.SC_NoiDungCongViec = SC_NoiDungCongViec;
            this.SC_TrangthaiCV = SC_TrangthaiCV;
            this.SC_TinhTrangTB = SC_TinhTrangTB;
            this.SC_GhiChu = SC_GhiChu;
            this.KhongSuachua = KhongSuachua;
            this.Huy = Huy;
            this.Ngayhuy = Ngayhuy;
            this.Nguoihuy = Nguoihuy;
            this.MaMay = MaMay;
            this.NgayYC = NgayYC;
            this.MaKhoaYC = MaKhoaYC;
            this.NhanVienYC = NhanVienYC;
            this.SoYC = SoYC;
            this.MoTaYC = MoTaYC;
            this.DuyetYC = DuyetYC;
            this.NgayDuyetYC = NgayDuyetYC;
            this.NguoiDuyetYC = NguoiDuyetYC;
            this.LDKhongDuyet = LDKhongDuyet;
            this.MaDVKS = MaDVKS;
            this.TenTB = TenTB;
            this.KS_TenNV = KS_TenNV;
            this.DT_TenNV = DT_TenNV;
            this.DT_TenNVDuyet = DT_TenNVDuyet;
            this.DT_TenNVPhat = DT_TenNVPhat;
            this.TenNguoiHuy = TenNguoiHuy;
            this.SC_TenNVS = SC_TenNVS;
            this.TenCVNhoLe = TenCVNhoLe;
            this.TenKhoaYC = TenKhoaYC;
            this.TenNhanVienYC = TenNhanVienYC;
            this.TenNguoiDuyetYC = TenNguoiDuyetYC;
            this.TenDVKS = TenDVKS;
            this.TinhTrangPhieu = TinhTrangPhieu;
            this.TenTrangThai = TenTrangThai;
            this.TenTinhTrangTB = TenTinhTrangTB;
            this.Ordernumber = Ordernumber;
        }
        public TBPHIEUSUACHUA_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPhieuYC"].GetType().Name != "DBNull" && dr["MaPhieuYC"] != null)
            { this.MaPhieuYC = Convert.ToString(dr["MaPhieuYC"]); }
            else
            {
                MaPhieuYC = "";
            }
            if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
            { this.STT = Convert.ToDecimal(dr["STT"]); }
            else
            {
                STT = 0;
            }
            if (dr["MaTB"].GetType().Name != "DBNull" && dr["MaTB"] != null)
            { this.MaTB = Convert.ToString(dr["MaTB"]); }
            else
            {
                MaTB = "";
            }
            if (dr["LoaiTB"].GetType().Name != "DBNull" && dr["LoaiTB"] != null)
            { this.LoaiTB = Convert.ToByte(dr["LoaiTB"]); }
            else
            {
                LoaiTB = 0;
            }
            if (dr["MaCVNhoLe"].GetType().Name != "DBNull" && dr["MaCVNhoLe"] != null)
            { this.MaCVNhoLe = Convert.ToString(dr["MaCVNhoLe"]); }
            else
            {
                MaCVNhoLe = "";
            }
            if (dr["KS_IsLap"].GetType().Name != "DBNull" && dr["KS_IsLap"] != null)
            { this.KS_IsLap = Convert.ToBoolean(dr["KS_IsLap"]); }
            else
            {
                KS_IsLap = false;
            }
            if (dr["KS_Noidung"].GetType().Name != "DBNull" && dr["KS_Noidung"] != null)
            { this.KS_Noidung = Convert.ToString(dr["KS_Noidung"]); }
            else
            {
                KS_Noidung = "";
            }
            if (dr["KS_MaNV"].GetType().Name != "DBNull" && dr["KS_MaNV"] != null)
            { this.KS_MaNV = Convert.ToString(dr["KS_MaNV"]); }
            else
            {
                KS_MaNV = "";
            }
            if (dr["KS_NgayLap"].GetType().Name != "DBNull" && dr["KS_NgayLap"] != null)
            {
                this.KS_NgayLap = Convert.ToDateTime(dr["KS_NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                KS_NgayLap = "";
            }
            if (dr["KS_Huy"].GetType().Name != "DBNull" && dr["KS_Huy"] != null)
            { this.KS_Huy = Convert.ToBoolean(dr["KS_Huy"]); }
            else
            {
                KS_Huy = false;
            }
            if (dr["DT_IsLap"].GetType().Name != "DBNull" && dr["DT_IsLap"] != null)
            { this.DT_IsLap = Convert.ToBoolean(dr["DT_IsLap"]); }
            else
            {
                DT_IsLap = false;
            }
            if (dr["DT_MaNV"].GetType().Name != "DBNull" && dr["DT_MaNV"] != null)
            { this.DT_MaNV = Convert.ToString(dr["DT_MaNV"]); }
            else
            {
                DT_MaNV = "";
            }
            if (dr["DT_NgayLap"].GetType().Name != "DBNull" && dr["DT_NgayLap"] != null)
            {
                this.DT_NgayLap = Convert.ToDateTime(dr["DT_NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                DT_NgayLap = "";
            }
            if (dr["DT_TinhTrang"].GetType().Name != "DBNull" && dr["DT_TinhTrang"] != null)
            { this.DT_TinhTrang = Convert.ToString(dr["DT_TinhTrang"]); }
            else
            {
                DT_TinhTrang = "";
            }
            if (dr["DT_NguyenNhan"].GetType().Name != "DBNull" && dr["DT_NguyenNhan"] != null)
            { this.DT_NguyenNhan = Convert.ToString(dr["DT_NguyenNhan"]); }
            else
            {
                DT_NguyenNhan = "";
            }
            if (dr["DT_GiaiPhap"].GetType().Name != "DBNull" && dr["DT_GiaiPhap"] != null)
            { this.DT_GiaiPhap = Convert.ToString(dr["DT_GiaiPhap"]); }
            else
            {
                DT_GiaiPhap = "";
            }
            if (dr["DT_MaPXNgoai"].GetType().Name != "DBNull" && dr["DT_MaPXNgoai"] != null)
            { this.DT_MaPXNgoai = Convert.ToString(dr["DT_MaPXNgoai"]); }
            else
            {
                DT_MaPXNgoai = "";
            }
            if (dr["DT_MaPX"].GetType().Name != "DBNull" && dr["DT_MaPX"] != null)
            { this.DT_MaPX = Convert.ToString(dr["DT_MaPX"]); }
            else
            {
                DT_MaPX = "";
            }
            if (dr["DT_ChiPhiNC"].GetType().Name != "DBNull" && dr["DT_ChiPhiNC"] != null)
            { this.DT_ChiPhiNC = Convert.ToDecimal(dr["DT_ChiPhiNC"]); }
            else
            {
                DT_ChiPhiNC = 0;
            }
            if (dr["DT_Duyet"].GetType().Name != "DBNull" && dr["DT_Duyet"] != null)
            { this.DT_Duyet = Convert.ToByte(dr["DT_Duyet"]); }
            else
            {
                DT_Duyet = 0;
            }
            if (dr["DT_Phat"].GetType().Name != "DBNull" && dr["DT_Phat"] != null)
            { this.DT_Phat = Convert.ToByte(dr["DT_Phat"]); }
            else
            {
                DT_Phat = 0;
            }
            if (dr["DT_LDKhongDuyet"].GetType().Name != "DBNull" && dr["DT_LDKhongDuyet"] != null)
            { this.DT_LDKhongDuyet = Convert.ToString(dr["DT_LDKhongDuyet"]); }
            else
            {
                DT_LDKhongDuyet = "";
            }
            if (dr["DT_MaNVDuyet"].GetType().Name != "DBNull" && dr["DT_MaNVDuyet"] != null)
            { this.DT_MaNVDuyet = Convert.ToString(dr["DT_MaNVDuyet"]); }
            else
            {
                DT_MaNVDuyet = "";
            }
            if (dr["DT_NgayDuyet"].GetType().Name != "DBNull" && dr["DT_NgayDuyet"] != null)
            {
                this.DT_NgayDuyet = Convert.ToDateTime(dr["DT_NgayDuyet"]).ToString("dd/MM/yyyy");
            }
            else
            {
                DT_NgayDuyet = "";
            }
            if (dr["DT_MaNVPhat"].GetType().Name != "DBNull" && dr["DT_MaNVPhat"] != null)
            { this.DT_MaNVPhat = Convert.ToString(dr["DT_MaNVPhat"]); }
            else
            {
                DT_MaNVPhat = "";
            }
            if (dr["DT_NgayPhat"].GetType().Name != "DBNull" && dr["DT_NgayPhat"] != null)
            {
                this.DT_NgayPhat = Convert.ToDateTime(dr["DT_NgayPhat"]).ToString("dd/MM/yyyy");
            }
            else
            {
                DT_NgayPhat = "";
            }
            if (dr["NgaySuaChuaBD"].GetType().Name != "DBNull" && dr["NgaySuaChuaBD"] != null)
            {
                this.NgaySuaChuaBD = Convert.ToDateTime(dr["NgaySuaChuaBD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgaySuaChuaBD = "";
            }
            if (dr["NgaySuaChuaKT"].GetType().Name != "DBNull" && dr["NgaySuaChuaKT"] != null)
            {
                this.NgaySuaChuaKT = Convert.ToDateTime(dr["NgaySuaChuaKT"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgaySuaChuaKT = "";
            }
            if (dr["SC_NgayHoanThanh"].GetType().Name != "DBNull" && dr["SC_NgayHoanThanh"] != null)
            {
                this.SC_NgayHoanThanh = Convert.ToDateTime(dr["SC_NgayHoanThanh"]).ToString("dd/MM/yyyy");
            }
            else
            {
                SC_NgayHoanThanh = "";
            }
            if (dr["SC_MaNVS"].GetType().Name != "DBNull" && dr["SC_MaNVS"] != null)
            { this.SC_MaNVS = Convert.ToString(dr["SC_MaNVS"]); }
            else
            {
                SC_MaNVS = "";
            }
            if (dr["SC_NoiDungCongViec"].GetType().Name != "DBNull" && dr["SC_NoiDungCongViec"] != null)
            { this.SC_NoiDungCongViec = Convert.ToString(dr["SC_NoiDungCongViec"]); }
            else
            {
                SC_NoiDungCongViec = "";
            }
            if (dr["SC_TrangthaiCV"].GetType().Name != "DBNull" && dr["SC_TrangthaiCV"] != null)
            { this.SC_TrangthaiCV = Convert.ToByte(dr["SC_TrangthaiCV"]); }
            else
            {
                SC_TrangthaiCV = 0;
            }
            if (dr["SC_TinhTrangTB"].GetType().Name != "DBNull" && dr["SC_TinhTrangTB"] != null)
            { this.SC_TinhTrangTB = Convert.ToString(dr["SC_TinhTrangTB"]); }
            else
            {
                SC_TinhTrangTB = "";
            }
            if (dr["SC_GhiChu"].GetType().Name != "DBNull" && dr["SC_GhiChu"] != null)
            { this.SC_GhiChu = Convert.ToString(dr["SC_GhiChu"]); }
            else
            {
                SC_GhiChu = "";
            }
            if (dr["KhongSuachua"].GetType().Name != "DBNull" && dr["KhongSuachua"] != null)
            { this.KhongSuachua = Convert.ToBoolean(dr["KhongSuachua"]); }
            else
            {
                KhongSuachua = false;
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            { this.Huy = Convert.ToBoolean(dr["Huy"]); }
            else
            {
                Huy = false;
            }
            if (dr["Ngayhuy"].GetType().Name != "DBNull" && dr["Ngayhuy"] != null)
            {
                this.Ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngayhuy = "";
            }
            if (dr["Nguoihuy"].GetType().Name != "DBNull" && dr["Nguoihuy"] != null)
            { this.Nguoihuy = Convert.ToString(dr["Nguoihuy"]); }
            else
            {
                Nguoihuy = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            { this.MaMay = Convert.ToString(dr["MaMay"]); }
            else
            {
                MaMay = "";
            }
            if (dr["NgayYC"].GetType().Name != "DBNull" && dr["NgayYC"] != null)
            {
                this.NgayYC = Convert.ToDateTime(dr["NgayYC"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayYC = "";
            }
            if (dr["MaKhoaYC"].GetType().Name != "DBNull" && dr["MaKhoaYC"] != null)
            { this.MaKhoaYC = Convert.ToString(dr["MaKhoaYC"]); }
            else
            {
                MaKhoaYC = "";
            }
            if (dr["NhanVienYC"].GetType().Name != "DBNull" && dr["NhanVienYC"] != null)
            { this.NhanVienYC = Convert.ToString(dr["NhanVienYC"]); }
            else
            {
                NhanVienYC = "";
            }
            if (dr["SoYC"].GetType().Name != "DBNull" && dr["SoYC"] != null)
            { this.SoYC = Convert.ToDecimal(dr["SoYC"]); }
            else
            {
                SoYC = 0;
            }
            if (dr["MoTaYC"].GetType().Name != "DBNull" && dr["MoTaYC"] != null)
            { this.MoTaYC = Convert.ToString(dr["MoTaYC"]); }
            else
            {
                MoTaYC = "";
            }
            if (dr["DuyetYC"].GetType().Name != "DBNull" && dr["DuyetYC"] != null)
            { this.DuyetYC = Convert.ToByte(dr["DuyetYC"]); }
            else
            {
                DuyetYC = 0;
            }
            if (dr["NgayDuyetYC"].GetType().Name != "DBNull" && dr["NgayDuyetYC"] != null)
            {
                this.NgayDuyetYC = Convert.ToDateTime(dr["NgayDuyetYC"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayDuyetYC = "";
            }
            if (dr["NguoiDuyetYC"].GetType().Name != "DBNull" && dr["NguoiDuyetYC"] != null)
            { this.NguoiDuyetYC = Convert.ToString(dr["NguoiDuyetYC"]); }
            else
            {
                NguoiDuyetYC = "";
            }
            if (dr["LDKhongDuyet"].GetType().Name != "DBNull" && dr["LDKhongDuyet"] != null)
            { this.LDKhongDuyet = Convert.ToString(dr["LDKhongDuyet"]); }
            else
            {
                LDKhongDuyet = "";
            }
            if (dr["MaDVKS"].GetType().Name != "DBNull" && dr["MaDVKS"] != null)
            { this.MaDVKS = Convert.ToString(dr["MaDVKS"]); }
            else
            {
                MaDVKS = "";
            }
            if (dr["TenTB"].GetType().Name != "DBNull" && dr["TenTB"] != null)
            { this.TenTB = Convert.ToString(dr["TenTB"]); }
            else
            {
                TenTB = "";
            }
            if (dr["KS_TenNV"].GetType().Name != "DBNull" && dr["KS_TenNV"] != null)
            { this.KS_TenNV = Convert.ToString(dr["KS_TenNV"]); }
            else
            {
                KS_TenNV = "";
            }
            if (dr["DT_TenNV"].GetType().Name != "DBNull" && dr["DT_TenNV"] != null)
            { this.DT_TenNV = Convert.ToString(dr["DT_TenNV"]); }
            else
            {
                DT_TenNV = "";
            }
            if (dr["DT_TenNVDuyet"].GetType().Name != "DBNull" && dr["DT_TenNVDuyet"] != null)
            { this.DT_TenNVDuyet = Convert.ToString(dr["DT_TenNVDuyet"]); }
            else
            {
                DT_TenNVDuyet = "";
            }
            if (dr["DT_TenNVPhat"].GetType().Name != "DBNull" && dr["DT_TenNVPhat"] != null)
            { this.DT_TenNVPhat = Convert.ToString(dr["DT_TenNVPhat"]); }
            else
            {
                DT_TenNVPhat = "";
            }
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            { this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]); }
            else
            {
                TenNguoiHuy = "";
            }
            if (dr["SC_TenNVS"].GetType().Name != "DBNull" && dr["SC_TenNVS"] != null)
            { this.SC_TenNVS = Convert.ToString(dr["SC_TenNVS"]); }
            else
            {
                SC_TenNVS = "";
            }
            if (dr["TenCVNhoLe"].GetType().Name != "DBNull" && dr["TenCVNhoLe"] != null)
            { this.TenCVNhoLe = Convert.ToString(dr["TenCVNhoLe"]); }
            else
            {
                TenCVNhoLe = "";
            }
            if (dr["TenKhoaYC"].GetType().Name != "DBNull" && dr["TenKhoaYC"] != null)
            { this.TenKhoaYC = Convert.ToString(dr["TenKhoaYC"]); }
            else
            {
                TenKhoaYC = "";
            }
            if (dr["TenNhanVienYC"].GetType().Name != "DBNull" && dr["TenNhanVienYC"] != null)
            { this.TenNhanVienYC = Convert.ToString(dr["TenNhanVienYC"]); }
            else
            {
                TenNhanVienYC = "";
            }
            if (dr["TenNguoiDuyetYC"].GetType().Name != "DBNull" && dr["TenNguoiDuyetYC"] != null)
            { this.TenNguoiDuyetYC = Convert.ToString(dr["TenNguoiDuyetYC"]); }
            else
            {
                TenNguoiDuyetYC = "";
            }
            if (dr["TenDVKS"].GetType().Name != "DBNull" && dr["TenDVKS"] != null)
            { this.TenDVKS = Convert.ToString(dr["TenDVKS"]); }
            else
            {
                TenDVKS = "";
            }
            if (dr["TinhTrangPhieu"].GetType().Name != "DBNull" && dr["TinhTrangPhieu"] != null)
            { this.TinhTrangPhieu = Convert.ToString(dr["TinhTrangPhieu"]); }
            else
            {
                TinhTrangPhieu = "";
            }
            if (dr["TenTrangThai"].GetType().Name != "DBNull" && dr["TenTrangThai"] != null)
            { this.TenTrangThai = Convert.ToString(dr["TenTrangThai"]); }
            else
            {
                TenTrangThai = "";
            }
            if (dr["TenTinhTrangTB"].GetType().Name != "DBNull" && dr["TenTinhTrangTB"] != null)
            { this.TenTinhTrangTB = Convert.ToString(dr["TenTinhTrangTB"]); }
            else
            {
                TenTinhTrangTB = "";
            }
            this.Ordernumber = Ordernumber;
        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }
        public static TBPHIEUSUACHUA_C GetbyMaPhieu(String MaPhieuYC, Decimal STT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_GET", MaPhieuYC, STT)))
            {
                while (dr.Read())
                {
                    return new TBPHIEUSUACHUA_C(dr, 0);
                }
            }
            return null;
        }

        public static String InsertDuTru(String MaPhieuYC, String MaTB, Byte LoaiTB, String MaCVNhoLe, Boolean DT_IsLap, String DT_MaNV, Nullable<DateTime> DT_NgayLap, String DT_TinhTrang, String DT_NguyenNhan, String DT_GiaiPhap, String DT_MaPXNgoai, String DT_MaPX, Nullable<Decimal> DT_ChiPhiNC)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_INSERT_DuTru", MaPhieuYC, MaTB, LoaiTB, MaCVNhoLe, DT_IsLap, DT_MaNV, DT_NgayLap, DT_TinhTrang, DT_NguyenNhan, DT_GiaiPhap, DT_MaPXNgoai, DT_MaPX, DT_ChiPhiNC));
        }

        public static String UpdateDuTru(String MaPhieuYC, decimal STT, String MaTB, Byte LoaiTB, String MaCVNhoLe, Boolean DT_IsLap, String DT_MaNV, DateTime DT_NgayLap, String DT_TinhTrang, String DT_NguyenNhan, String DT_GiaiPhap, String DT_MaPXNgoai, String DT_MaPX, Decimal DT_ChiPhiNC, Boolean Huy, String MaMay)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_UPDATE_DuTru", MaPhieuYC, STT, MaTB, LoaiTB, MaCVNhoLe, DT_IsLap, DT_MaNV, DT_NgayLap, DT_TinhTrang, DT_NguyenNhan, DT_GiaiPhap, DT_MaPXNgoai, DT_MaPX, DT_ChiPhiNC, Huy, MaMay));
        }

        public static String Delete(String MaPhieuYC, decimal STT, String NguoiHuy, String MaMay)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DELETE", MaPhieuYC, STT, NguoiHuy, MaMay));
        }

        public static String DuyetDuTru(String MaPhieuYC, decimal STT, String DT_TinhTrang, String DT_NguyenNhan, String DT_GiaiPhap, Decimal DT_ChiPhiNC, Byte DT_Duyet, Byte DT_Phat, String DT_LDKhongDuyet, String DT_MaNVDuyet, String DT_MaNVPhat)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DUYET_DuTru", MaPhieuYC, STT, DT_TinhTrang, DT_NguyenNhan, DT_GiaiPhap, DT_ChiPhiNC, DT_Duyet, DT_Phat, DT_LDKhongDuyet, DT_MaNVDuyet, DT_MaNVPhat));
        }

        public static String UpdateKhaoSat(String MaPhieuYC, decimal STT, Boolean KS_Huy, String NoiDungKS, String NguoiKS)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_UPDATE_KhaoSat", MaPhieuYC, STT, KS_Huy, NoiDungKS, NguoiKS));
        }

        public static String UpdateLapPhieu(String MaPhieuYC, decimal STT, Nullable<DateTime> SC_NgayHoanThanh, String SC_MaNVS, String SC_NoiDungCongViec, Byte SC_TrangthaiCV, String SC_TinhTrangTB, String SC_GhiChu)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPhieuSuaChua_C_UpdateSuaChua", MaPhieuYC, STT, SC_NgayHoanThanh, SC_MaNVS, SC_NoiDungCongViec, SC_TrangthaiCV, SC_TinhTrangTB, SC_GhiChu));
        }
        

    }

    [Serializable()]
    public class TBPHIEUSUACHUA_CList : List<TBPHIEUSUACHUA_C>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TBPHIEUSUACHUA_CList()
        {

        }

        public static TBPHIEUSUACHUA_CList GetAll(DateTime NgayBatDau, DateTime NgayKetThuc, String MaKhoa, Byte Loai, Byte DaDuyet, Byte DaPhat, String Account)
        {
            TBPHIEUSUACHUA_CList List = new TBPHIEUSUACHUA_CList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_GETALL", NgayBatDau, NgayKetThuc, MaKhoa, Loai, DaDuyet, DaPhat, Account))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBPHIEUSUACHUA_C(dr, Ordernumber));
                }
            }
            return List;
        }

        public static TBPHIEUSUACHUA_CList FindByMaYC(String MaPhieuYC)
        {
            TBPHIEUSUACHUA_CList List = new TBPHIEUSUACHUA_CList();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_FindMaYC", MaPhieuYC))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    List.Add(new TBPHIEUSUACHUA_C(dr, Ordernumber));
                }
            }
            return List;
        }
    }
}
