namespace Infrastructure.ViewModel
{
    using System;
    public partial class tbl_emrChanDoanHinhAnhVM
    {
        public Int32? IdDanhSachHSBA { set; get; }
        public Int32? STT { set; get; }
        public String bacsichuyenkhoa { set; get; }
        public String bacsiyeucau { set; get; }
        public String emrDmChanDoanHinhAnh { set; get; }
        public String emrDmLoaiChanDoanHinhAnh { set; get; }
        public String ketluan { set; get; }
        public String ketqua { set; get; }
        public String loidan { set; get; }
        public DateTime? ngaythuchien { set; get; }
        public DateTime? ngayyeucau { set; get; }
        public Byte? LoaiKQ { set; get; }
    }
}
