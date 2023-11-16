namespace  Infrastructure.ViewModel
{
    using System;
    
    
    
    

    public  class tbl_emrXetNghiemVM
    {
        
        public int? IdemrXetNghiem { get; set; }

        public int? STT { get; set; }

        public int? IdDanhSachHSBA { get; set; }

        
        public string bacsixetnghiem { get; set; }

        
        public string bacsiyeucau { get; set; }

        public string MaLH { get; set; }// Mã của Hà Thắng
        public string emrDmLoaiXetNghiem { get; set; }

        public DateTime? ngaythuchien { get; set; }

        public DateTime? ngayyeucau { get; set; }

        public string nhanxet { get; set; }

        public string noidungyeucau { get; set; }

        public byte? LoaiKQ { get; set; }
    }
}
