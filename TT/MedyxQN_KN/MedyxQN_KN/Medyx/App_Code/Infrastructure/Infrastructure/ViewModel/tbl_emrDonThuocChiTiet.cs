namespace  Infrastructure.ViewModel
{
    using System;
    
    public  class tbl_emrDonThuocChiTietVM
    {
        public int? IdemrDonThuocChiTiet { get; set; }
        public int? IdemrDonThuoc { get; set; }
        public String machungloai { set; get; }
        public String chidandungthuoc { set; get; }
        public String emrDmDuongDungThuoc { set; get; }
        public String emrDmTanXuatDungThuoc { set; get; }
        public String emrDmThuoc { set; get; }
        public String lieuluongdung { set; get; }
        public DateTime? ngaybatdau { set; get; }
        public DateTime? ngayketthuc { set; get; }
        public String bietduoc { set; get; }
    }
}
