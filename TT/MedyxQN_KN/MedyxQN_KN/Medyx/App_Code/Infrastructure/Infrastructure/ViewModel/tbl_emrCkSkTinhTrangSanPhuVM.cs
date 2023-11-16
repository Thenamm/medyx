namespace  Infrastructure.ViewModel
{
    using System;
    
    
    
    

    public partial class tbl_emrCkSkTinhTrangSanPhuVM
    {
        
       
        public int? IdDanhSachHSBA { get; set; }

        public int? chieucaotucung { get; set; }

        public string chisobishop { get; set; } // trong db kiểu nvarchar
        public string concotucung { get; set; }

        public int? cotucung { get; set; }

        public int? dauoi { get; set; }

        public bool? dauvetmo { get; set; }

        
        public string domo { get; set; }

        
        public string huyetap { get; set; }

        public string mach { get; set; }

        public int? maunuocoi { get; set; }

        
        public string ngoithai { get; set; }

        public string nhietdo { get; set; }

        public string nhiptho { get; set; }

        public bool? phu { get; set; }

        public string proteinnieu { get; set; }

        public bool? seomocu { get; set; }

        public DateTime? thoidiemvooi { get; set; }

        public string timthai { get; set; }

        public int? tinhthan { get; set; }

        
        public byte? tinhtrangtimthai { get; set; }

        public byte? vongbung { get; set; }
    }
}
