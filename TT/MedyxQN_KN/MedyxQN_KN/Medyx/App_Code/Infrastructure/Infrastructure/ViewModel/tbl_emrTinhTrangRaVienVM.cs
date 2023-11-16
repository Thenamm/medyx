namespace Infrastructure.ViewModel
{
    using System;
    public class tbl_emrTinhTrangRaVienVM
    {
        public Int32? IdDanhSachHSBA { set; get; }
        public String emrDmKetQuaDieuTri { set; get; }
        public String emrDmKetQuaGiaiPhauBenh { set; get; }
        public String emrDmLyDoTuVong { set; get; }
        public String emrDmMaBenhByIdicdGiaiphaututhi { set; get; }
        public String emrDmMaBenhByIdicdNguyennhantuvong { set; get; }
        public String emrDMThoiDiemTuVong { set; get; }
        public Boolean? khamnghiemtuthi { set; get; }
        public String motagiaiphaututhi { set; get; }
        public String motanguyennhantuvong { set; get; }
        public DateTime? ngaygiotuvong { set; get; }
    }
}