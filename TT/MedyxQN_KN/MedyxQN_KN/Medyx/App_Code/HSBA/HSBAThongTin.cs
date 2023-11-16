using System;
using System.Linq;

/// <summary>
/// Summary description for HSBAThongTinHanhChinh
/// </summary>
public class HSBAThongTin
{
    #region Init

    public HSBAThongTin()
    {

    }
    #endregion

    #region Common
    private int DateDiff(DateInterval intervalType, System.DateTime dateOne, System.DateTime dateTwo)
    {
        switch (intervalType)
        {
            case DateInterval.Day:
            case DateInterval.DayOfYear:
                System.TimeSpan spanForDays = dateTwo - dateOne;
                return (int)spanForDays.TotalDays;

            case DateInterval.Hour:
                System.TimeSpan spanForHours = dateTwo - dateOne;
                return (int)spanForHours.TotalHours;

            case DateInterval.Minute:
                System.TimeSpan spanForMinutes = dateTwo - dateOne;
                return (int)spanForMinutes.TotalMinutes;

            case DateInterval.Month:
                return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);

            case DateInterval.Quarter:
                int dateOneQuarter = (int)System.Math.Ceiling(dateOne.Month / 3.0);
                int dateTwoQuarter = (int)System.Math.Ceiling(dateTwo.Month / 3.0);
                return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;

            case DateInterval.Second:
                System.TimeSpan spanForSeconds = dateTwo - dateOne;
                return (int)spanForSeconds.TotalSeconds;

            case DateInterval.Weekday:
                System.TimeSpan spanForWeekdays = dateTwo - dateOne;
                return (int)(spanForWeekdays.TotalDays / 7.0);

            case DateInterval.WeekOfYear:
                System.DateTime dateOneModified = dateOne;
                System.DateTime dateTwoModified = dateTwo;
                while (dateTwoModified.DayOfWeek != System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                {
                    dateTwoModified = dateTwoModified.AddDays(-1);
                }
                while (dateOneModified.DayOfWeek != System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                {
                    dateOneModified = dateOneModified.AddDays(-1);
                }
                System.TimeSpan spanForWeekOfYear = dateTwoModified - dateOneModified;
                return (int)(spanForWeekOfYear.TotalDays / 7.0);

            case DateInterval.Year:
                return dateTwo.Year - dateOne.Year;

            default:
                return 0;
        }
    }
    private enum DateInterval
    {
        Day,
        DayOfYear,
        Hour,
        Minute,
        Month,
        Quarter,
        Second,
        Weekday,
        WeekOfYear,
        Year
    }
    public string HoTen { get; set; }
    public string NgaySinh { get; set; }
    public string NgaySinhBo { get; set; }
    public string TuoiVaoVien { get; set; }
    public bool GioiTinh { get; set; }
    public string MaNN { get; set; }
    public string TenNgheNghiep { get; set; }
    public string MaDanToc { get; set; }
    public string TenDanToc { get; set; }
    public string MaQuocGia { get; set; }
    public string TenQuocGia { get; set; }
    public string MaHuyen { get; set; }
    public string TenHuyen { get; set; }
    public string MaPhuongXa { get; set; }
    public string TenPhuongXa { get; set; }
    public string MaTinh { get; set; }
    public string TenTinh { get; set; }
    public string MaQuocTich { get; set; }
    public string TenQuocTich { get; set; }
    public string HoTenBo { get; set; }
    public string TrinhDoVanHoaBo { get; set; }
    public string MaNgheNghiepBo { get; set; }
    public string TenNgheNghiepBo { get; set; }
    public string HoTenMe { get; set; }
    public string TrinhDoVanHoaMe { get; set; }
    public string MaNgheNghiepMe { get; set; }
    public string TenNgheNghiepMe { get; set; }
    public string NoiLamViec { get; set; }
    public string MaDoiTuong { get; set; }
    public string TenDoiTuong { get; set; }
    public string BYHTGiaTriDenNgay { get; set; }
    public string SoTheBHYT { get; set; }
    public string DiaChi { get; set; }
    public string HoTenDiaChiNguoiNha { get; set; }
    public string SoDienThoai { get; set; }
    public string MaNoiChuyen { get; set; }
    public string TenNoiChuyen { get; set; }
    public string MaLoaiRaVien { get; set; }
    public string TenLoaiRaVien { get; set; }
    public string MaLoaiChuyenVien { get; set; }
    public string TenLoaiChuyenVien { get; set; }
    public string NgayGioRaVien { get; set; }
    public string TongSoNgayDieuTri { get; set; }
    public string NgayGioVaoVien { get; set; }
    public string TenNoiKham { get; set; }
    public string MaNoiKham { get; set; }
    public string TenNoiGioiThieu { get; set; }
    public string MaNoiGioiThieu { get; set; }
    public string VaoVienLanThu { get; set; }
    public string MaBenhRaVienChinh { get; set; }
    public string TenBenhRaVienChinh { get; set; }
    public string MaBenhChinhICD { get; set; }
    public string MaBenhChinhID { get; set; }
    public string TenBenhChinh { get; set; }
    public string MaBenhKemTheoICD { get; set; }
    public string MaBenhKemTheoID { get; set; }
    public string TenBenhKemTheo { get; set; }
    public string MaBenhPhanBietICD { get; set; }
    public string MaBenhPhanBietID { get; set; }
    public string TenBenhPhanBiet { get; set; }
    public string MaBenhRaVienKemTheo { get; set; }
    public string TenBenhRaVienKemTheo { get; set; }
    public string MaICDRaVienChinh { get; set; }
    public string MaICDRaVienKemTheo { get; set; }
    public string MaBenhNoiGioiThieu { get; set; }
    public string MaICDNoiGioiThieu { get; set; }
    public string TenBenhNoiGioiThieu { get; set; }
    public string MaBenhVaoVien { get; set; }
    public string MaBenhVaoVienICD { get; set; }
    public string TenBenhVaoVien { get; set; }
    public string MaKetQuaDieuTri { get; set; }
    public string TenKetQuaDieuTri { get; set; }
    public string MaKetQuaGiaiPhau { get; set; }
    public string TenKetQuaGiaiPhau { get; set; }
    public string NgayGioTuVong { get; set; }
    public string MaLoaiTuVong { get; set; }
    public string TenLoaiTuVong { get; set; }
    public string NguyenNhanTuVong { get; set; }
    public bool KhamNghiemTuThi { get; set; }
    public string MaChanDoanGiaiPhauTuThi { get; set; }
    public string TenChanDoanGiaiPhauTuThi { get; set; }


    public string QuaTrinhBenhLyVaDienBienLamSang { get; set; }
    public string TomTatKetQuaCLSCoGTriChanDoan { get; set; }
    public string PhuongPhapDieuTri { get; set; }
    public string TinhTrangNguoiBenhRaVien { get; set; }
    public string HuongDieuTri { get; set; }
    public string NgayKyBenhAn { set; get; }//NgayKyRaVien BenhAn nếu không bằng thì sửa lại được nhanh
    public string MaBacSyKyBenhAn { set; get; }// Bác sỹ cho ra viện
    public string TenBacSyKyBenhAn { set; get; }
    public string TienSuBanThan { set; get; }
    public string TienSuGiaDinh { set; get; }
    public string NguonLay { set; get; }

    public string MaICDChanDoanTruocPhauThuat { get; set; }

    public string MaICDChanDoanSauPhauThuat { get; set; }
    public string MaBenhIDChanDoanTruocPhauThuat { get; set; }
    public string MaBenhIDChanDoanSauPhauThuat { get; set; }
    public string TenBenhChanDoanTruocPhauThuat { get; set; }
    public string TenBenhChanDoanSauPhauThuat { get; set; }
    public string PhuongPhapPhauThuat { get; set; }
    public int TongSoLanPhauThuat { get; set; }
    public int TongSoNgayDieuTriSauPhauThuat { get; set; }

    public int LoaiTaiBien { get; set; }
    #endregion

    #region Load THông tin HSBA
    public HSBAThongTin(string MaBa, string MaBN)
    {
        using (HL7CoreHueDataContext db = new HL7CoreHueDataContext())
        {
            int? minSttKhoa = null;
            var checkNull = db.BenhAnPhauThuats.Where(x=>x.MaBA==MaBa).FirstOrDefault();
            if (checkNull != null)
                minSttKhoa = (from p in db.BenhAnPhauThuats where p.MaBA == MaBa select p).Min(p => p.STTKhoa);
            if (minSttKhoa != null)
            {
                var queryPhauThuat = from p in db.BenhAnPhauThuats
                                     join bt in db.DanhMucBenhTats on p.CDTruocMo equals bt.MaBenhID
                                     into gr1
                                     from a1 in gr1.DefaultIfEmpty()
                                     join bt2 in db.DanhMucBenhTats on p.CDSauMo equals bt2.MaBenhID
                                     into gr2
                                     from a2 in gr2.DefaultIfEmpty()
                                     where p.MaBA == MaBa & p.STT == 1 & p.STTKhoa == minSttKhoa
                                     select new
                                     {
                                         MaBenhIDChanDoanSauPhauThuat = p.CDSauMo,
                                         MaBenhIDChanDoanTruocPhauThuat = p.CDTruocMo,
                                         MaICDChanDoanTruocPhauThuat = a1.MaICD,
                                         MaICDChanDoanSauPhauThuat = a2.MaICD,
                                         TenBenhChanDoanTruocPhauThuat = p.TenBenhCDTruocMo,
                                         TenBenhChanDoanSauPhauThuat = p.TenBenhCDSauMo,
                                         PhuongPhapPhauThuat = p.ppphauthuat
                                     };
                var objPhauThuat = queryPhauThuat.SingleOrDefault();
                if (objPhauThuat != null)
                {
                    MaICDChanDoanTruocPhauThuat = objPhauThuat.MaICDChanDoanTruocPhauThuat;
                    MaICDChanDoanSauPhauThuat = objPhauThuat.MaICDChanDoanSauPhauThuat;
                    TenBenhChanDoanTruocPhauThuat = objPhauThuat.TenBenhChanDoanTruocPhauThuat;
                    TenBenhChanDoanSauPhauThuat = objPhauThuat.TenBenhChanDoanSauPhauThuat;
                    PhuongPhapPhauThuat = objPhauThuat.PhuongPhapPhauThuat;
                }
            }

            TongSoLanPhauThuat = 0;
            var tongPhauThuat = (from p in db.BenhAnPhauThuats.Where(x => x.MaBA == MaBa) select p).Count();
            TongSoLanPhauThuat = tongPhauThuat;

            var query =
                 from p in db.ThongTinBenhNhans
                 join n in db.DanhMucNgheNghieps on p.MaNN equals n.MaNN
                 into gr1
                 from a in gr1.DefaultIfEmpty()
                 join t in db.DanhMucTinhs on p.MaTinh equals t.MaTinh
                 into gr2
                 from b in gr2.DefaultIfEmpty()
                 join h in db.DanhMucQuanHuyens on p.MaHuyen equals h.MaQH
                 into gr3
                 from c in gr3.DefaultIfEmpty()
                 join px in db.DanhMucPhuongXas on p.MaPXa equals px.MaPXa
                 into gr4
                 from d in gr4.DefaultIfEmpty()
                 join dt in db.DanhMucDantocs on p.MaDanToc equals dt.MaDanToc
                 into gr5
                 from e in gr5.DefaultIfEmpty()
                 join qg in db.DanhMucQuocGias on p.MaQG equals qg.MaQG
                 into gr6
                 from f in gr6.DefaultIfEmpty()

                 join ba in db.BenhANs on p.MaBN equals ba.MaBN
                 into gr8
                 from h in gr8.DefaultIfEmpty()
                 join doituong in db.DanhMucDoiTuongs on h.MaDT equals doituong.MaDT
                  into gr7
                 from g in gr7.DefaultIfEmpty()
                 join k in db.DanhMucNgheNghieps on p.MaNNBo equals k.MaNN
                 into gr9
                 from l in gr9.DefaultIfEmpty()
                 join q in db.DanhMucNgheNghieps on p.MaNNMe equals q.MaNN
                 into gr10
                 from x in gr10.DefaultIfEmpty()
                 join xx in db.DanhMucNhanViens on h.Mabsravien equals xx.MaNV
                 into gr11
                 from xx2 in gr11.DefaultIfEmpty()
                 join t in db.BenhAn_PKs on h.MaBA equals t.MaBANoiTru
                 into gr12
                 from xx13 in gr12.DefaultIfEmpty()
                 join xx14 in db.DanhMucNhanViens on xx13.BacSyKyBenhAn equals xx14.MaNV
                 into gr13
                 from xx3 in gr13.DefaultIfEmpty()
                 join xx15 in db.DanhMucQuocGias on p.MaQG equals xx15.MaQG
                 into gr14
                 from xx4 in gr14.DefaultIfEmpty()

                 where p.MaBN == MaBN & h.MaBA == MaBa // hơi thừa nhưng kệ:D
                 select new
                 {

                     TenQuocTich = xx4.TenQG,
                     MaQuocTich = p.MaQG,
                     TenBacSyKyBA = (xx3.HoTen),
                     NgayKyBenhAn = xx13.NgayKyBenhAn.HasValue == true ? xx13.NgayKyBenhAn.Value.ToString() : string.Empty,
                     MaBacSyKy = xx13.BacSyKyBenhAn,
                     h,
                     p,
                     d.TenPXa,
                     GiaTriTheDN = (h.GiatriDN),
                     GiaTriTheTN = (h.GiaTriTN),
                     SoThe = (h.Sothe == null ? string.Empty : h.Sothe),
                     TenNgheNghiep = a.TenNN,
                     TenDanToc = e.TenDanToc,
                     f.TenQG,
                     g.TenDT,
                     b.TenTinh,
                     c.TenQH,
                     TenNNghiepBo = (l.TenNN),
                     TenNNghiepMe = (x.TenNN)
                 };
            var obj = query.SingleOrDefault();
            if (obj != null)
            {
                HoTen = obj.p.Hoten == null ? string.Empty : obj.p.Hoten.ToUpper();
                NgaySinh = obj.p.NgaySinh.HasValue == true ? ((DateTime)obj.p.NgaySinh).ToString("dd-MM-yyyy") : string.Empty;
                NgaySinhBo = obj.p.NgaySinhBo.HasValue == true ? ((DateTime)obj.p.NgaySinhBo).ToString("dd-MM-yyyy") : string.Empty;
                TuoiVaoVien = obj.p.Tuoi.ToString();
                GioiTinh = obj.p.GT;
                TenNgheNghiep = obj.TenNgheNghiep;
                MaNN = obj.p.MaNN;
                TenDanToc = obj.TenDanToc;
                MaDanToc = obj.p.MaDanToc;
                TenQuocGia = obj.TenQG;
                MaQuocGia = obj.p.MaQG;
                DiaChi = obj.p.DiaChi;
                TenPhuongXa = obj.TenPXa;
                MaPhuongXa = obj.p.MaPXa;
                TenHuyen = obj.TenQH;
                MaHuyen = obj.p.MaHuyen;
                TenTinh = obj.TenTinh;
                MaTinh = obj.p.MaTinh;
                NoiLamViec = obj.p.NoiLamViec;
                TenDoiTuong = obj.TenDT;
                MaDoiTuong = obj.h.MaDT;
                TenDanToc = obj.TenDanToc;
                MaDanToc = obj.p.MaDanToc;
                HoTenMe = obj.p.HoTenMe;
                TrinhDoVanHoaMe = obj.p.TrinhDoVanHoaMe;
                MaNgheNghiepMe = obj.p.MaNNMe;
                TenNgheNghiepMe = obj.TenNNghiepMe;
                HoTenBo = obj.p.hotenbo;
                TrinhDoVanHoaBo = obj.p.TrinhDoVanHoaBo;
                MaNgheNghiepBo = obj.p.MaNNBo;
                TenNgheNghiepBo = obj.TenNNghiepBo;
                if (obj.GiaTriTheDN != null)
                    BYHTGiaTriDenNgay = ((DateTime)obj.GiaTriTheDN).ToString("dd-MM-yyyy"); // Thông tin này cần check lại chính xác lấy ở đâu
                SoTheBHYT = obj.SoThe == null ? string.Empty : obj.SoThe.ToUpper();
                HoTenDiaChiNguoiNha = obj.p.BaoTin;
                SoDienThoai = obj.p.DienThoai;
            }
            var benhDieuTri = db.sp_GetAllBenhKhoaDieuTri(MaBa).SingleOrDefault();

            if (benhDieuTri != null)
            {
                MaBenhChinhID = benhDieuTri.MaBenhChinhID;
                MaBenhChinhICD = benhDieuTri.MaBenhChinhICD;
                MaBenhKemTheoID = benhDieuTri.MaBenhKemID;
                MaBenhKemTheoICD = benhDieuTri.MaBenhKemICD;
                MaBenhPhanBietID = benhDieuTri.MaBenhPhanBietID;
                MaBenhPhanBietICD = benhDieuTri.MaBenhPhanBietCD;
                TenBenhChinh = benhDieuTri.TenBenhChinh;
                TenBenhKemTheo = benhDieuTri.TenBenhKemTheo;
                TenBenhPhanBiet = benhDieuTri.TenBenhPhanBiet;
            }
            var query2 = from p in db.BenhAn_PKs
                         join cv in db.DanhMucHuongDTs on p.MaHDT equals cv.MaHDT
                         into gr1
                         from a in gr1.DefaultIfEmpty()
                         join dmbv in db.DanhMucBenhViens on p.MaNoiChuyen equals dmbv.MaBV
                         into gr2
                         from b in gr2.DefaultIfEmpty()
                         join noikham in db.DanhMucNoiKhams on p.MaNoiKham equals noikham.MaNoiKham
                         into gr3
                         from c in gr3.DefaultIfEmpty()
                         join noigt in db.DanhMucNoiGTs on p.MaNoiGT equals noigt.MaNoiGT
                         into gr4
                         from d in gr4.DefaultIfEmpty()
                         join gp in db.DanhMucBenhTats on p.MaGPTuThi equals gp.MaICD
                          into gr5
                         from e in gr5.DefaultIfEmpty()
                         join q in db.DMLoaiVongs on p.MaLDTVong equals q.MaLDTVong
                         into gr6
                         from x in gr6.DefaultIfEmpty()
                         join g in db.DanhMucKetQuaDieuTris on p.MaKQDT equals g.MaKQDT
                         into gr7
                         from l in gr7.DefaultIfEmpty()
                         join h in db.DanhMucGPBenhs on p.MaGPBenh equals h.MaGPBenh
                         into gr8
                         from hb in gr8.DefaultIfEmpty()
                         join hh in db.DanhMucBenhTats on p.MaBenhRavien equals hh.MaBenhID
                         into gr9
                         from hhb in gr9.DefaultIfEmpty()
                         join hh1 in db.DanhMucBenhTats on p.Mabenhkem equals hh1.MaBenhID
                         into gr10
                         from hh1b in gr10.DefaultIfEmpty()
                         join hh1a in db.DanhMucBenhTats on p.MaBenhNGT equals hh1a.MaBenhID
                         into gr11
                         from hh1ab in gr11.DefaultIfEmpty()
                         join hhh1 in db.HueDMHTRaViens on p.MaHTRa equals hhh1.MaHTRaVien
                         into gr12
                         from hhh1a in gr12.DefaultIfEmpty()
                         join kkb in db.HueDMBenhTats on p.MaBenhKKB equals kkb.MaBenhID
                         into gr13
                         from kkb1 in gr13.DefaultIfEmpty()
                         where p.MaBANoiTru == MaBa
                         select new { kkb1, hhh1a, BenhLy = (p.benhly), TomTat = p.ketquacls, PhuongPhap = p.DieuTri, TinhTrang = p.tinhtrangbn, HuongDieuTriTiepTheo = p.LoiDan, MaICDNoiGioiThieu = hh1ab.MaICD, MaICDRaVienKemTheo = (hh1b.MaICD), MaICDRaVienChinh = (hhb.MaICD), TenKetQuaGiaiPhau = (hb.TenGPBenh), TenKetQuaDieuTri = (l.TenKQDT), TenLoaiTuVong = x.TenLDTVong, TenBenhGiaiPhau = (e.TenBenh), p, TenNoiChuyen = (b.TenBV == null ? string.Empty : b.TenBV), TenLoaiChuyenVien = (a.TenHDT == null ? string.Empty : a.TenHDT), c.MaNoiKham, c.TenNoiKham, p.MaNoiGT, d.TenNoiGT, p.VaoLan };
            var obj2 = query2.SingleOrDefault();
            if (obj2 != null)
            {
                if (obj2.hhh1a != null)
                {
                    MaLoaiRaVien = obj2.hhh1a.MaHTRaVien;
                    TenLoaiRaVien = obj2.hhh1a.TenHTRaVien;
                }
                this.QuaTrinhBenhLyVaDienBienLamSang = obj2.BenhLy;// obj2.p.benhly;
                TomTatKetQuaCLSCoGTriChanDoan = obj2.TomTat;
                PhuongPhapDieuTri = obj2.PhuongPhap;
                TinhTrangNguoiBenhRaVien = obj2.TinhTrang;
                this.HuongDieuTri = obj2.HuongDieuTriTiepTheo;

                TenLoaiChuyenVien = obj2.TenLoaiChuyenVien;
                MaLoaiChuyenVien = obj2.p.MaHDT;
                TenNoiChuyen = obj2.TenNoiChuyen;
                MaNoiChuyen = obj2.p.MaNoiChuyen;
                NgayGioRaVien = obj2.p.NgayRaVien.HasValue == true ? ((DateTime)obj2.p.NgayRaVien).ToString("dd-MM-yyyy HH:mm") : null;
                if (obj2.p.NgayGioVV.HasValue && obj2.p.NgayRaVien.HasValue)
                    TongSoNgayDieuTri = (DateDiff(DateInterval.Day, (DateTime)obj2.p.NgayGioVV, (DateTime)obj2.p.NgayRaVien) + 1).ToString();
                NgayGioVaoVien = obj2.p.NgayGioVV.HasValue == true ? ((DateTime)(obj2.p.NgayGioVV)).ToString("dd-MM-yyyy HH:mm") : null; //((DateTime)obj.p.NgayVV.ToString("dd-MM-yyyy HH:mm"));
                TenNoiKham = obj2.TenNoiKham;
                MaNoiKham = obj2.MaNoiKham;
                TenNoiGioiThieu = obj2.TenNoiGT;
                MaNoiGioiThieu = obj2.MaNoiGT;
                VaoVienLanThu = obj2.VaoLan.ToString();
                MaBenhRaVienChinh = obj2.p.MaBenhRavien;
                TenBenhRaVienChinh = obj2.p.TenBenhRaVien;
                MaBenhRaVienKemTheo = obj2.p.Mabenhkem;
                TenBenhRaVienKemTheo = obj2.p.TenBenhkem;
                MaBenhNoiGioiThieu = obj2.p.MaBenhNGT;
                MaICDNoiGioiThieu = obj2.MaICDNoiGioiThieu;
                TenBenhNoiGioiThieu = obj2.p.TenBenhNGT;
                MaBenhVaoVien = obj2.p.MaBenhKKB;
                if (obj2.kkb1 != null) // ! DefaultEmpty ?
                    MaBenhVaoVienICD = obj2.kkb1.MaICD;
                TenBenhVaoVien = obj2.p.TenBenhKKB;
                MaChanDoanGiaiPhauTuThi = obj2.p.MaGPTuThi;
                TenChanDoanGiaiPhauTuThi = obj2.TenBenhGiaiPhau;
                KhamNghiemTuThi = (bool)obj2.p.KNTuThi; //((bool)obj2.p.KNTuThi);
                MaLoaiTuVong = obj2.p.MaLDTVong;
                TenLoaiTuVong = obj2.TenLoaiTuVong;
                NguyenNhanTuVong = obj2.p.NNTVong;
                TenKetQuaDieuTri = obj2.TenKetQuaDieuTri;
                MaKetQuaDieuTri = obj2.p.MaKQDT;
                TenKetQuaGiaiPhau = obj2.TenKetQuaGiaiPhau;
                MaKetQuaGiaiPhau = obj2.p.MaGPBenh;
                NgayGioTuVong = obj2.p.NgayTVong.HasValue == true ? ((DateTime)(obj2.p.NgayTVong)).ToString("dd-MM-yyyy HH:mm") : null;
                MaICDRaVienChinh = obj2.MaICDRaVienChinh;
                MaICDRaVienKemTheo = obj2.MaICDRaVienKemTheo;
            }
            if (obj != null)
            {
                NgayKyBenhAn = !string.IsNullOrEmpty(obj.NgayKyBenhAn) == true ? DateTime.Parse(obj.NgayKyBenhAn).ToString("dd-MM-yyyy") : string.Empty;
                MaBacSyKyBenhAn = obj.MaBacSyKy;
                TenBacSyKyBenhAn = obj.TenBacSyKyBA;
                TienSuBanThan = obj.p.TienSu;
                TienSuGiaDinh = obj.p.TienSuGiaDinh;
                NguonLay = obj.p.TienSuThuoc;
            }

        }

    }

    #endregion 

}