using System;

namespace Infrastructure.ViewModel
{
    public partial class tbl_emrChanDoanVM
    {
        public Int32? IdDanhSachHSBA { set; get; }
        public Boolean? bibienchung { set; get; }
        public Boolean? bitaibien { set; get; }
        public String emrDmLyDoTaiBienBienChung { set; get; }
        public String emrDmMaBenhByIdicdChandoandieutri { set; get; }
        public String emrDmMaBenhByIdicdChandoankkb { set; get; }
        public String emrDmMaBenhByIdicdChandoannoiden { set; get; }
        public String emrDmMaBenhByIdicdChandoanravienchinh { set; get; }
        public String emrDmMaBenhByIdicdChandoanravienkemtheo { set; get; }
        public String emrDmMaBenhByIdicdChandoanraviennguyennhan { set; get; }
        public String emrDmMaBenhByIdicdChandoansaupt { set; get; }
        public String emrDmMaBenhByIdicdChandoantruocpt { set; get; }
        public String motachandoandieutri { set; get; }
        public String motachandoankkb { set; get; }
        public String motachandoannoiden { set; get; }
        public String motachandoanravienchinh { set; get; }
        public String motachandoanravienkemtheo { set; get; }
        public String motachandoanraviennguyennhan { set; get; }
        public String motachandoansaupt { set; get; }
        public String motachandoantruocpt { set; get; }
        public Int32? tongsolanpt { set; get; }
        public Int32? tongsongaysaupt { set; get; }
    }
}