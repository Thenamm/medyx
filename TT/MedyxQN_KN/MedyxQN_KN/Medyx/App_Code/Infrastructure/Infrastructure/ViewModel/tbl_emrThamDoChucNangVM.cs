using System;

namespace Infrastructure.ViewModel
{
    public class tbl_emrThamDoChucNangVM
    {
        public Int32? IdDanhSachHSBA { set; get; }
        public Int32? STT { set; get; }
        public String bacsichuyenkhoa { set; get; }
        public String bacsiyeucau { set; get; }
        public String emrDmThamDoChucNang { set; get; }
        public String emrDmLoaiThamDoChucNang { set; get; }
        public String ketluan { set; get; }
        public String ketqua { set; get; }
        public String loidan { set; get; }
        public DateTime? ngaythuchien { set; get; }
        public DateTime? ngayyeucau { set; get; }
        public String noidungyeucau { set; get; }
        public Byte? LoaiKQ { set; get; }

    }
}