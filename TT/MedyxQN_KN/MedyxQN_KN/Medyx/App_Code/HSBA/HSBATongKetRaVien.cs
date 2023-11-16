using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HSBATongKetRaVien
/// </summary>
public static class HSBATongKetRaVien
{
    #region Update Bác Sỹ Ký
    public static void UpdateBacSyKy(string MaBA, string MaBacSy, DateTime? NgayKy)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var obj5 = db.BenhAn_PKs.Where(x => x.MaBANoiTru == MaBA).SingleOrDefault();
            if (obj5 != null)
            {
                obj5.BacSyKyBenhAn = MaBacSy;
                obj5.NgayKyBenhAn = NgayKy;
            }
            db.SubmitChanges();

        }

    }

    #endregion

    #region Update Bệnh chính, bệnh kèm theo, bệnh phân biệt
    public static void UpdateBenhKhoaDieuTri(string maBA, string maBenhChinh, string tenBenhChinh, string maBenhKem, string tenBenhKem, string maBenhPhanBiet, string tenBenhPhanBiet)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var objKhoa = db.HueBenhAnKhoas.Where(x => x.MaBA == maBA & x.STTKhoa == 1).SingleOrDefault();
            if (objKhoa != null)
            {
                objKhoa.MaBenh = maBenhChinh;
                objKhoa.MaBenhKem = maBenhKem;
                objKhoa.MaBenhPhanBiet = maBenhPhanBiet;
                objKhoa.TenBenh = tenBenhChinh;
                objKhoa.TenBenhKem = tenBenhKem;
                objKhoa.TenBenhPhanBiet = tenBenhPhanBiet;
                db.SubmitChanges();
            }

        }

    }
    #endregion

    #region Update Tờ 4 bệnh án
    public static void UpdateTo4BenhAn(string maBenhRaVien, string tenBenhRaVien, string maBenhRaVienKem, string tenBenhRaVienKem, string MaBa, string QuaTrinhDienBienLamSang, string TomTatKetQuaCanLamSangCoGiaTriChanDoan, string PhuongPhapDieuTri, string TinhTrangNguoiBenhRaVien, string HuongDieuTriVaCacCheDoTiepTheo, string MaGiaiPhauBenh)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var obj5 = db.BenhAn_PKs.Where(x => x.MaBANoiTru == MaBa).SingleOrDefault();
            if (obj5 != null)
            {
                if (!string.IsNullOrEmpty(QuaTrinhDienBienLamSang))
                    obj5.benhly = QuaTrinhDienBienLamSang;
                if (!string.IsNullOrEmpty(TomTatKetQuaCanLamSangCoGiaTriChanDoan))
                    obj5.ketquacls = TomTatKetQuaCanLamSangCoGiaTriChanDoan;
                if (!string.IsNullOrEmpty(PhuongPhapDieuTri))
                    obj5.DieuTri = PhuongPhapDieuTri;
                if (!string.IsNullOrEmpty(MaGiaiPhauBenh))
                    obj5.MaGPBenh = MaGiaiPhauBenh;
                if (!string.IsNullOrEmpty(TinhTrangNguoiBenhRaVien))
                    obj5.tinhtrangbn = TinhTrangNguoiBenhRaVien;
                if (!string.IsNullOrEmpty(HuongDieuTriVaCacCheDoTiepTheo))
                    obj5.LoiDan = HuongDieuTriVaCacCheDoTiepTheo;
                if (!string.IsNullOrEmpty(maBenhRaVien))
                    obj5.MaBenhRavien = maBenhRaVien;
                if (!string.IsNullOrEmpty(tenBenhRaVien))
                    obj5.TenBenhRaVien = tenBenhRaVien;
                if (!string.IsNullOrEmpty(maBenhRaVienKem))
                    obj5.Mabenhkem = maBenhRaVienKem;// Tạm thời tận dụng
                if (!string.IsNullOrEmpty(tenBenhRaVienKem))
                    obj5.TenBenhkem = tenBenhRaVienKem;
                db.SubmitChanges();
            }
        }
    }

    #endregion

    #region Update Or Insert Thong Tin Tu Vong, Hiện tại chỉ update :D
    public static void InsertOrUpdateThongTinTuVong(string maGPTuThi, string maBA, DateTime? ngayGioTV, string nguyenNhanTV, string tenGPBenh, string maLDTVong, string maTGTVong, bool khamNghiemTuThi)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var obj = db.BenhAn_PKs.Where(x => x.MaBANoiTru == maBA).SingleOrDefault();
            if (obj != null)
            {
                if (ngayGioTV.HasValue)
                    obj.NgayTVong = ngayGioTV.Value;
                obj.NNTVong = nguyenNhanTV;
                obj.tenbenhgp = tenGPBenh;
                obj.MaGPTuThi = maGPTuThi;
                obj.MaLDTVong = maLDTVong;
                obj.MaTGTVong = maTGTVong;
                obj.KNTuThi = khamNghiemTuThi;
                db.SubmitChanges();
            }
        }
    }

    #endregion

    #region UpdateThongTinChuyenVien
    public static void UpdateThongTinChuyenVien(string maBA, string maLoaiChuyenVien, string maBenhVienChuyen, string maLoaiRaVien, DateTime? ngayGioRaVien)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var benhAnPK = db.Huebenhanpks.Where(x => x.MaBANoiTru == maBA).SingleOrDefault();
            if (benhAnPK != null)
            {
                if (!string.IsNullOrEmpty(maLoaiRaVien))
                    benhAnPK.MaHTRa = maLoaiRaVien;
                if (ngayGioRaVien.HasValue)
                    benhAnPK.NgayRaVien = ngayGioRaVien;
                if (!string.IsNullOrEmpty(maBenhVienChuyen))
                    benhAnPK.MaNoiChuyen = maBenhVienChuyen;
                if (!string.IsNullOrEmpty(maLoaiChuyenVien))
                    benhAnPK.MaHDT = maLoaiChuyenVien;
                db.SubmitChanges();
            }
        }
    }

    #endregion

    #region Update thông tin vào viện
    public static void UpdateThongTinVaoVien(string maBA, string maNoiGT, string maNoiTrucTiepVao, DateTime? NgayGioVaoVien)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var obj = db.BenhAn_PKs.Where(x => x.MaBANoiTru == maBA).SingleOrDefault();
            if (obj != null)
            {
                if (NgayGioVaoVien.HasValue)
                    obj.NgayGioVV = NgayGioVaoVien.Value;
                if (!string.IsNullOrEmpty(maNoiTrucTiepVao))
                    obj.MaNoiKham = maNoiTrucTiepVao;
                if (!string.IsNullOrEmpty(maNoiGT))
                    obj.MaNoiGT = maNoiGT;
                db.SubmitChanges();
            }
        }
    }
    #endregion

    #region Update Thông tin Phẫu thuật
    public static void UpdateThongTinPhauThuat(string maBA, string maChanDoanTruocPhauThuat, string maChanDoanSauPhauThuat, string tenBenhChanDoanTruocPhauThuat, string tenBenhChanDoanSauPhauThuat, string phuongPhapPhauThuat)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            var objPhauThuat = db.BenhAnPhauThuats.Where(x => x.MaBA == maBA && x.STT == 1 && x.STTKhoa == 1).SingleOrDefault();
            if (objPhauThuat != null)
            {
                if (!string.IsNullOrEmpty(maChanDoanTruocPhauThuat))
                    objPhauThuat.CDTruocMo = maChanDoanTruocPhauThuat;
                if (!string.IsNullOrEmpty(maChanDoanSauPhauThuat))
                    objPhauThuat.CDSauMo = maChanDoanSauPhauThuat;
                if (!string.IsNullOrEmpty(tenBenhChanDoanSauPhauThuat))
                    objPhauThuat.TenBenhCDSauMo = tenBenhChanDoanSauPhauThuat;
                if (!string.IsNullOrEmpty(tenBenhChanDoanTruocPhauThuat))
                    objPhauThuat.TenBenhCDTruocMo = tenBenhChanDoanTruocPhauThuat;
                if (!string.IsNullOrEmpty(phuongPhapPhauThuat))
                    objPhauThuat.ppphauthuat = phuongPhapPhauThuat;
                db.SubmitChanges();
            }
        }
    }
    #endregion
}