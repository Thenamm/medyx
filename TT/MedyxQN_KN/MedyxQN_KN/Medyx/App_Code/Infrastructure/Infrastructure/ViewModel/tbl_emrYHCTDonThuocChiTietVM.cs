namespace  Infrastructure.ViewModel
{
    using System;
    public partial class tbl_emrYHCTDonThuocChiTietVM
    {
        public int? IdemrDonThuocChiTiet { get; set; }
        public int? IdemrYHCTDonThuoc { get; set; }
        public String machungloai { set; get; }
        public String chidandungthuoc { set; get; }
        public String emrDmDuongDungThuoc { set; get; }
        public String emrDmTanXuatDungThuoc { set; get; }
        public String emrDmYhctViThuoc { set; get; }
        public String lieuluongdung { set; get; }
        public DateTime? ngaybatdau { set; get; }
        public DateTime? ngayketthuc { set; get; }
    }
}
