namespace  Infrastructure.ViewModel
{
    using System;
    public  class tbl_emrVaoKhoaVM
    {
        public Int32? IdDanhSachHSBA { set; get; }
        public Int32? STTKhoa { set; get; }
        public String MaKhoa { set; get; }
        public String bacsidieutri { set; get; }
        public String emrDmKhoaDieuTri { set; get; }
        public String giuong { set; get; }
        public DateTime? ngaygiovaokhoa { set; get; }
        public DateTime? ngayketthucdieutri { set; get; }
        public String phong { set; get; }
        public Int32? songaydieutri { set; get; }
        public String tenkhoa { set; get; }
        public String tentruongkhoa { set; get; }
    }
}
