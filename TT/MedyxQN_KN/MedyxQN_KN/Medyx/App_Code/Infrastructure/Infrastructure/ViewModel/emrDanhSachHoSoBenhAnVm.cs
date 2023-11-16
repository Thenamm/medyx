using Infrastructure.ViewModel;
using System.Collections.Generic;

/// <summary>
/// Summary description for emrDanhSachHoSoBenhAnVm
/// </summary>
public class emrDanhSachHoSoBenhAnVm
{
    public tbl_emrDanhSachHoSoBenhAnVM HoSoBenhAn { get; set; }
    public tbl_emrBenhNhanVM emrBenhNhan { get; set; }
    public tbl_emrBenhAnVM emrBenhAn { get; set; }
    public IEnumerable<tbl_emrVaoKhoaVM> emrVaoKhoas { get; set; }
    public IEnumerable<tbl_emrDonThuocVM> emrDonThuocs { get; set; }
    public tbl_emrChanDoanVM emrChanDoan { get; set; }
    public IEnumerable<tbl_emrPhauThuatThuThuatVM> emrPhauThuatThuThuats { get; set; }
    public IEnumerable<tbl_emrChanDoanHinhAnhVM> emrChanDoanHinhAnhs { get; set; }
    public IEnumerable<tbl_emrQuanLyFileDinhKemVM> emrQuanLyFileDinhKemCdhas { get; set; }
    public IEnumerable<tbl_emrQuanLyFileDinhKemCdhaVM> emrQuanLyFileDinhKemCdhaSaveFiles { get; set; }
    public IEnumerable<tbl_emrHinhAnhTonThuongVM> emrHinhAnhTonThuongs { get; set; }// Đang chưa có dữ liệu
    public IEnumerable<tbl_emrThamDoChucNangVM> emrThamDoChucNangs { get; set; }
    public IEnumerable<tbl_emrQuanLyFileDinhKemVM> emrQuanLyFileDinhKemTdcns { get; set; }
    public IEnumerable<tbl_emrQuanLyFileDinhKemTdcnVM> emrQuanLyFileDinhKemTdcnSaveFiles { get; set; }
    public IEnumerable<tbl_emrGiaiPhauBenhVM> emrGiaiPhauBenhs { get; set; }
    public IEnumerable<tbl_ID_emrQuanLyFileDinhKemBenhAnVM> emrQuanLyFileDinhKemBenhAns { get; set; }
    public tbl_emrTongKetSanKhoaVM emrTongKetSanKhoa { get; set; }
    public tbl_emrTinhTrangRaVienVM emrTinhTrangRaVien { get; set; }
    public tbl_emrYhctNhaBaVM emrYhctNhaBa { get; set; }
    public IEnumerable<tbl_emrYhctNhaBaGhiChuVM> emrYhctNhaBaGhiChus { get; set; }
    public IEnumerable<tbl_emrYhctBenhAnVM> emrYhctBenhAn { get; set; }
    public tbl_emrYhctBenhanVongChanVM emrYhctBenhanVongChan { get; set; }
    public tbl_emrYhctBenhanVaanChanVM emrYhctBenhanVaanChan { get; set; }
    public tbl_emrYhctBenhanVawnChanVM emrYhctBenhanVawnChan { get; set; }
    public tbl_emrYhctBenhanThietChanVM emrYhctBenhanThietChan { get; set; }
    public tbl_emrYhctDonThuocVM emrYhctDonThuocs { get; set; }
    public IEnumerable<tbl_emrYHCTDonThuocChiTietVM> emrYhctDonThuocChiTiets { get; set; }
    public tbl_emrYhctChanDoan emrYhctChanDoan { get; set; }

}