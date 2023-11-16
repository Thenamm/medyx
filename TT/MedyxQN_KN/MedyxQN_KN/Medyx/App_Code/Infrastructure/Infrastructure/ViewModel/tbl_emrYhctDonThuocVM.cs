namespace Infrastructure.ViewModel
{
    using System;
    public partial class tbl_emrYhctDonThuocVM
    {
        public int? IdemrYHCTDonThuoc { get; set; }
        public Int32? IDDanhSachHSBA { set; get; }
        public Int32? STT { set; get; }
        public String bacsikedon { set; get; }
        public String chidan { set; get; }
        public DateTime? ngaybatdaudung { set; get; }
        public DateTime? ngaykedon { set; get; }
        public DateTime? ngayketthuc { set; get; }
        public DateTime? TuNgay { set; get; }
        public DateTime? DenNgay { set; get; }
        public byte? sodon { set; get; }
        public byte? soluongthang { set; get; }
    }
}
