using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace DonThuocDT
{
    

        string portdn = "https://api.donthuocquocgia.vn";
        string userdn = "0172011";
        string passdn = "5EnOdKpJcf";
        DTDTAPI dt = new DTDTAPI();
        string logintoken = dt.dangnhapCoSoKCB(portdn, userdn, passdn);






    #region object RESTful
    //object phan API đăng nhập lấy phiên làm việc
    //object gui username, pass
    [Serializable()]
    public class dangnhapcosokhamchuabenh
    {
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
        private string Password = string.Empty;
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
    //object lay token tra ve
    [Serializable()]
    public class dangnhapbacsi_return_data
    {
        private string Token = string.Empty;
        public string token
        {
            get
            {
                return Token;
            }
            set
            {
                Token = value;
            }
        }
        private string Token_type = string.Empty;
        public string token_type
        {
            get
            {
                return Token_type;
            }
            set
            {
                Token_type = value;
            }
        }
    }
    [Serializable()]
    public class dangnhapbacsi
    {
        private string Ma_lien_thong_bac_si = string.Empty;
        public string ma_lien_thong_bac_si
        {
            get
            {
                return Ma_lien_thong_bac_si;
            }
            set
            {
                Ma_lien_thong_bac_si = value;
            }
        }
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
        private string Password = string.Empty;
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
    //object phan Tạo đơn thuốc từ cơ sở khám chữa bệnh
    [Serializable()]
    public class donthuoc
    {
        private string Loai_don_thuoc = string.Empty;
        public string loai_don_thuoc
        {
            get
            {
                return Loai_don_thuoc;
            }
            set
            {
                Loai_don_thuoc = value;
            }
        }
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }
        private string Ho_ten_benh_nhan = string.Empty;
        public string ho_ten_benh_nhan
        {
            get
            {
                return Ho_ten_benh_nhan;
            }
            set
            {
                Ho_ten_benh_nhan = value;
            }
        }
        private string Ma_dinh_danh_y_te = string.Empty;
        public string ma_dinh_danh_y_te
        {
            get
            {
                return Ma_dinh_danh_y_te;
            }
            set
            {
                Ma_dinh_danh_y_te = value;
            }
        }
        private string Ma_dinh_danh_cong_dan = string.Empty;
        public string ma_dinh_danh_cong_dan
        {
            get
            {
                return Ma_dinh_danh_cong_dan;
            }
            set
            {
                Ma_dinh_danh_cong_dan = value;
            }
        }
        private string Ngay_sinh_benh_nhan = string.Empty;
        public string ngay_sinh_benh_nhan
        {
            get
            {
                return Ngay_sinh_benh_nhan;
            }
            set
            {
                Ngay_sinh_benh_nhan = value;
            }
        }
        private decimal Can_nang = 0;
        public decimal can_nang
        {
            get
            {
                return Can_nang;
            }
            set
            {
                Can_nang = value;
            }
        }
        private string Gioi_tinh = string.Empty;
        public string gioi_tinh
        {
            get
            {
                return Gioi_tinh;
            }
            set
            {
                Gioi_tinh = value;
            }
        }
        private string Ma_so_the_bao_hiem_y_te = string.Empty;
        public string ma_so_the_bao_hiem_y_te
        {
            get
            {
                return Ma_so_the_bao_hiem_y_te;
            }
            set
            {
                Ma_so_the_bao_hiem_y_te = value;
            }
        }
        private string Thong_tin_nguoi_giam_ho = string.Empty;
        public string thong_tin_nguoi_giam_ho
        {
            get
            {
                return Thong_tin_nguoi_giam_ho;
            }
            set
            {
                Thong_tin_nguoi_giam_ho = value;
            }
        }
        private string Dia_chi = string.Empty;
        public string dia_chi
        {
            get
            {
                return Dia_chi;
            }
            set
            {
                Dia_chi = value;
            }
        }
        private List<chandoan> Chan_doan;
        public List<chandoan> chan_doan
        {
            get
            {
                if (Chan_doan == null)
                    Chan_doan = new List<chandoan>();
                return Chan_doan;
            }
            set
            {
                Chan_doan = value;
            }
        }
        private string Luu_y = string.Empty;
        public string luu_y
        {
            get
            {
                return Luu_y;
            }
            set
            {
                Luu_y = value;
            }
        }
        private string Hinh_thuc_dieu_tri = string.Empty;
        public string hinh_thuc_dieu_tri
        {
            get
            {
                return Hinh_thuc_dieu_tri;
            }
            set
            {
                Hinh_thuc_dieu_tri = value;
            }
        }
        private List<dot_dung_thuoc> Dot_dung_thuoc;
        public List<dot_dung_thuoc> dot_dung_thuoc
        {
            get
            {
                if (Dot_dung_thuoc == null)
                    Dot_dung_thuoc = new List<dot_dung_thuoc>();
                return Dot_dung_thuoc;
            }
            set
            {
                Dot_dung_thuoc = value;
            }
        }
        private List<thongtindonthuoc> Thong_tin_don_thuoc;
        public List<thongtindonthuoc> thong_tin_don_thuoc
        {
            get
            {
                if (Thong_tin_don_thuoc == null)
                    Thong_tin_don_thuoc = new List<thongtindonthuoc>();
                return Thong_tin_don_thuoc;
            }
            set
            {
                Thong_tin_don_thuoc = value;
            }
        }
        private string Loi_dan = string.Empty;
        public string loi_dan
        {
            get
            {
                return Loi_dan;
            }
            set
            {
                Loi_dan = value;
            }
        }
        private string So_dien_thoai_nguoi_kham_benh = string.Empty;
        public string so_dien_thoai_nguoi_kham_benh
        {
            get
            {
                return So_dien_thoai_nguoi_kham_benh;
            }
            set
            {
                So_dien_thoai_nguoi_kham_benh = value;
            }
        }
        private int Ngay_tai_kham;
        public int ngay_tai_kham
        {
            get
            {
                return Ngay_tai_kham;
            }
            set
            {
                Ngay_tai_kham = value;
            }
        }
        private string Ngay_gio_ke_don = string.Empty;
        public string ngay_gio_ke_don
        {
            get
            {
                return Ngay_gio_ke_don;
            }
            set
            {
                Ngay_gio_ke_don = value;
            }
        }
        private string Signature = string.Empty;
        public string signature
        {
            get
            {
                return Signature;
            }
            set
            {
                Signature = value;
            }
        }
    }
    [Serializable()]
    public class dot_dung_thuoc
    {
        private int Dot = 0;
        public int dot
        {
            get
            {
                return Dot;
            }
            set
            {
                Dot = value;
            }
        }
        private string Tu_ngay = string.Empty;
        public string tu_ngay
        {
            get
            {
                return Tu_ngay;
            }
            set
            {
                Tu_ngay = value;
            }
        }
        private string Den_ngay = string.Empty;
        public string den_ngay
        {
            get
            {
                return Den_ngay;
            }
            set
            {
                Den_ngay = value;
            }
        }
        private int So_thang_thuoc = 0;
        public int so_thang_thuoc
        {
            get
            {
                return So_thang_thuoc;
            }
            set
            {
                So_thang_thuoc = value;
            }
        }
    }
    //[Serializable()]
    //public class thong_tin_don_thuoc
    //{
    //    private string Biet_duoc = string.Empty;
    //    public string biet_duoc
    //    {
    //        get
    //        {
    //            return Biet_duoc;
    //        }
    //        set
    //        {
    //            Biet_duoc = value;
    //        }
    //    }
    //    private string Ten_thuoc = string.Empty;
    //    public string ten_thuoc
    //    {
    //        get
    //        {
    //            return Ten_thuoc;
    //        }
    //        set
    //        {
    //            Ten_thuoc = value;
    //        }
    //    }
    //    private string Don_vi_tinh = string.Empty;
    //    public string don_vi_tinh
    //    {
    //        get
    //        {
    //            return Don_vi_tinh;
    //        }
    //        set
    //        {
    //            Don_vi_tinh = value;
    //        }
    //    }
    //    private decimal So_luong = 0;
    //    public decimal so_luong
    //    {
    //        get
    //        {
    //            return So_luong;
    //        }
    //        set
    //        {
    //            So_luong = value;
    //        }
    //    }
    //    private string Cach_dung = string.Empty;
    //    public string cach_dung
    //    {
    //        get
    //        {
    //            return Cach_dung;
    //        }
    //        set
    //        {
    //            Cach_dung = value;
    //        }
    //    }
    //}
    [Serializable()]
    public class dangkybacsi
    {
        private string Ho_ten = string.Empty;
        public string ho_ten
        {
            get
            {
                return Ho_ten;
            }
            set
            {
                Ho_ten = value;
            }
        }
        private string Ngay_sinh = string.Empty;
        public string ngay_sinh
        {
            get
            {
                return Ngay_sinh;
            }
            set
            {
                Ngay_sinh = value;
            }
        }
        private string So_chung_chi_hanh_nghe = string.Empty;
        public string so_chung_chi_hanh_nghe
        {
            get
            {
                return So_chung_chi_hanh_nghe;
            }
            set
            {
                So_chung_chi_hanh_nghe = value;
            }
        }
        private string Ngay_cap_chung_chi_hanh_nghe = string.Empty;
        public string ngay_cap_chung_chi_hanh_nghe
        {
            get
            {
                return Ngay_cap_chung_chi_hanh_nghe;
            }
            set
            {
                Ngay_cap_chung_chi_hanh_nghe = value;
            }
        }
        private string Noi_cap_chung_chi_hanh_nghe = string.Empty;
        public string noi_cap_chung_chi_hanh_nghe
        {
            get
            {
                return Noi_cap_chung_chi_hanh_nghe;
            }
            set
            {
                Noi_cap_chung_chi_hanh_nghe = value;
            }
        }
        private string So_chung_minh_thu = string.Empty;
        public string so_chung_minh_thu
        {
            get
            {
                return So_chung_minh_thu;
            }
            set
            {
                So_chung_minh_thu = value;
            }
        }
        private string Ngay_cap_chung_minh_thu = string.Empty;
        public string ngay_cap_chung_minh_thu
        {
            get
            {
                return Ngay_cap_chung_minh_thu;
            }
            set
            {
                Ngay_cap_chung_minh_thu = value;
            }
        }
        private string Noi_cap_chung_minh_thu = string.Empty;
        public string noi_cap_chung_minh_thu
        {
            get
            {
                return Noi_cap_chung_minh_thu;
            }
            set
            {
                Noi_cap_chung_minh_thu = value;
            }
        }
        private string Dia_chi_thanh_pho = string.Empty;
        public string dia_chi_thanh_pho
        {
            get
            {
                return Dia_chi_thanh_pho;
            }
            set
            {
                Dia_chi_thanh_pho = value;
            }
        }
        private string Dia_chi_quan_huyen = string.Empty;
        public string dia_chi_quan_huyen
        {
            get
            {
                return Dia_chi_quan_huyen;
            }
            set
            {
                Dia_chi_quan_huyen = value;
            }
        }
        private string Dia_chi_phuong_xa = string.Empty;
        public string dia_chi_phuong_xa
        {
            get
            {
                return Dia_chi_phuong_xa;
            }
            set
            {
                Dia_chi_phuong_xa = value;
            }
        }
        private string Dia_chi_chi_tiet = string.Empty;
        public string dia_chi_chi_tiet
        {
            get
            {
                return Dia_chi_chi_tiet;
            }
            set
            {
                Dia_chi_chi_tiet = value;
            }
        }
        private string Email = string.Empty;
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        private string Dien_thoai = string.Empty;
        public string dien_thoai
        {
            get
            {
                return Dien_thoai;
            }
            set
            {
                Dien_thoai = value;
            }
        }
        private string Van_bang_chuyen_mon = string.Empty;
        public string van_bang_chuyen_mon
        {
            get
            {
                return Van_bang_chuyen_mon;
            }
            set
            {
                Van_bang_chuyen_mon = value;
            }
        }
        private List<thoi_gian_lam_viec> Thoi_gian_lam_viec;
        public List<thoi_gian_lam_viec> thoi_gian_lam_viec
        {
            get
            {
                if (Thoi_gian_lam_viec == null)
                    Thoi_gian_lam_viec = new List<thoi_gian_lam_viec>();
                return Thoi_gian_lam_viec;
            }
            set
            {
                Thoi_gian_lam_viec = value;
            }
        }
        private List<string> File_giay_chung_nhan_hanh_nghe;
        public List<string> file_giay_chung_nhan_hanh_nghe
        {
            get
            {
                if (File_giay_chung_nhan_hanh_nghe == null)
                    File_giay_chung_nhan_hanh_nghe = new List<string>();
                return File_giay_chung_nhan_hanh_nghe;
            }
            set
            {
                File_giay_chung_nhan_hanh_nghe = value;
            }
        }
        private string File_anh_dai_dien = string.Empty;
        public string file_anh_dai_dien
        {
            get
            {
                return File_anh_dai_dien;
            }
            set
            {
                File_anh_dai_dien = value;
            }
        }
        private List<string> Linh_vuc;
        public List<string> linh_vuc
        {
            get
            {
                if (Linh_vuc == null)
                    Linh_vuc = new List<string>();
                return Linh_vuc;
            }
            set
            {
                Linh_vuc = value;
            }
        }
        private string Don_vi_khai_bao = string.Empty;
        public string don_vi_khai_bao
        {
            get
            {
                return Don_vi_khai_bao;
            }
            set
            {
                Don_vi_khai_bao = value;
            }
        }
    }
    [Serializable()]
    public class thoi_gian_lam_viec
    {
        private string Ten_don_vi = string.Empty;
        public string ten_don_vi
        {
            get
            {
                return Ten_don_vi;
            }
            set
            {
                Ten_don_vi = value;
            }
        }
        private string Dia_chi_don_vi = string.Empty;
        public string dia_chi_don_vi
        {
            get
            {
                return Dia_chi_don_vi;
            }
            set
            {
                Dia_chi_don_vi = value;
            }
        }
        private string _thoi_gian_lam_viec = string.Empty;
        public string Thoi_gian_lam_viec
        {
            get
            {
                return _thoi_gian_lam_viec;
            }
            set
            {
                _thoi_gian_lam_viec = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongbacsi
    {
        private string So_chung_chi_hanh_nghe_bac_si = string.Empty;
        public string so_chung_chi_hanh_nghe_bac_si
        {
            get
            {
                return So_chung_chi_hanh_nghe_bac_si;
            }
            set
            {
                So_chung_chi_hanh_nghe_bac_si = value;
            }
        }
        private string Ma_lien_thong_bac_si = string.Empty;
        public string ma_lien_thong_bac_si
        {
            get
            {
                return Ma_lien_thong_bac_si;
            }
            set
            {
                Ma_lien_thong_bac_si = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongbacsi_return_data
    {
        private string Ma_lien_thong_bac_si = string.Empty;
        public string ma_lien_thong_bac_si
        {
            get
            {
                return Ma_lien_thong_bac_si;
            }
            set
            {
                Ma_lien_thong_bac_si = value;
            }
        }
        private string Message = string.Empty;
        public string message
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
            }
        }
    }
    //object nhan ket qua tra ve khi thao tac voi don thuoc
    [Serializable()]
    public class dangkycosokhamchuabenh
    {
        private string So_giay_phep = string.Empty;
        public string so_giay_phep
        {
            get
            {
                return So_giay_phep;
            }
            set
            {
                So_giay_phep = value;
            }
        }
        private string Ngay_cap_giay_phep = string.Empty;
        public string ngay_cap_giay_phep
        {
            get
            {
                return Ngay_cap_giay_phep;
            }
            set
            {
                Ngay_cap_giay_phep = value;
            }
        }
        private string Noi_cap_giay_phep = string.Empty;
        public string noi_cap_giay_phep
        {
            get
            {
                return Noi_cap_giay_phep;
            }
            set
            {
                Noi_cap_giay_phep = value;
            }
        }
        private string Ten_co_so = string.Empty;
        public string ten_co_so
        {
            get
            {
                return Ten_co_so;
            }
            set
            {
                Ten_co_so = value;
            }
        }
        private string Ten_nguoi_dai_dien = string.Empty;
        public string ten_nguoi_dai_dien
        {
            get
            {
                return Ten_nguoi_dai_dien;
            }
            set
            {
                Ten_nguoi_dai_dien = value;
            }
        }
        private string So_chung_chi_hanh_nghe = string.Empty;
        public string so_chung_chi_hanh_nghe
        {
            get
            {
                return So_chung_chi_hanh_nghe;
            }
            set
            {
                So_chung_chi_hanh_nghe = value;
            }
        }
        private string Noi_cap_chung_chi_hanh_nghe = string.Empty;
        public string noi_cap_chung_chi_hanh_nghe
        {
            get
            {
                return Noi_cap_chung_chi_hanh_nghe;
            }
            set
            {
                Noi_cap_chung_chi_hanh_nghe = value;
            }
        }
        private string Dia_chi_hanh_nghe_thanh_pho = string.Empty;
        public string dia_chi_hanh_nghe_thanh_pho
        {
            get
            {
                return Dia_chi_hanh_nghe_thanh_pho;
            }
            set
            {
                Dia_chi_hanh_nghe_thanh_pho = value;
            }
        }
        private string Dia_chi_hanh_nghe_quan_huyen = string.Empty;
        public string dia_chi_hanh_nghe_quan_huyen
        {
            get
            {
                return Dia_chi_hanh_nghe_quan_huyen;
            }
            set
            {
                Dia_chi_hanh_nghe_quan_huyen = value;
            }
        }
        private string Dia_chi_hanh_nghe_phuong_xa = string.Empty;
        public string dia_chi_hanh_nghe_phuong_xa
        {
            get
            {
                return Dia_chi_hanh_nghe_phuong_xa;
            }
            set
            {
                Dia_chi_hanh_nghe_phuong_xa = value;
            }
        }
        private string Dia_chi_hanh_nghe_chi_tiet = string.Empty;
        public string dia_chi_hanh_nghe_chi_tiet
        {
            get
            {
                return Dia_chi_hanh_nghe_chi_tiet;
            }
            set
            {
                Dia_chi_hanh_nghe_chi_tiet = value;
            }
        }
        private string Email = string.Empty;
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        private string Dien_thoai = string.Empty;
        public string dien_thoai
        {
            get
            {
                return Dien_thoai;
            }
            set
            {
                Dien_thoai = value;
            }
        }
        private List<thoi_gian_hoat_dong> Thoi_gian_hoat_dong;
        public List<thoi_gian_hoat_dong> thoi_gian_hoat_dong
        {
            get
            {
                if (Thoi_gian_hoat_dong == null)
                    Thoi_gian_hoat_dong = new List<thoi_gian_hoat_dong>();
                return Thoi_gian_hoat_dong;
            }
            set
            {
                Thoi_gian_hoat_dong = value;
            }
        }
        private List<string> Pham_vi_hoat_dong_chuyen_mon;
        public List<string> pham_vi_hoat_dong_chuyen_mon
        {
            get
            {
                if (Pham_vi_hoat_dong_chuyen_mon == null)
                    Pham_vi_hoat_dong_chuyen_mon = new List<string>();
                return Pham_vi_hoat_dong_chuyen_mon;
            }
            set
            {
                Pham_vi_hoat_dong_chuyen_mon = value;
            }
        }
        private string Hinh_thuc_to_chuc = string.Empty;
        public string hinh_thuc_to_chuc
        {
            get
            {
                return Hinh_thuc_to_chuc;
            }
            set
            {
                Hinh_thuc_to_chuc = value;
            }
        }
        private string File_giay_phep = string.Empty;
        public string file_giay_phep
        {
            get
            {
                return File_giay_phep;
            }
            set
            {
                File_giay_phep = value;
            }
        }
        private string File_danh_muc_ky_thuat = string.Empty;
        public string file_danh_muc_ky_thuat
        {
            get
            {
                return File_danh_muc_ky_thuat;
            }
            set
            {
                File_danh_muc_ky_thuat = value;
            }
        }
        private string File_nhan_su_dang_ky = string.Empty;
        public string file_nhan_su_dang_ky
        {
            get
            {
                return File_nhan_su_dang_ky;
            }
            set
            {
                File_nhan_su_dang_ky = value;
            }
        }
        private string File_trang_thiet_bi_dang_ky = string.Empty;
        public string file_trang_thiet_bi_dang_ky
        {
            get
            {
                return File_trang_thiet_bi_dang_ky;
            }
            set
            {
                File_trang_thiet_bi_dang_ky = value;
            }
        }
        private string Mo_hinh_to_chuc = string.Empty;
        public string mo_hinh_to_chuc
        {
            get
            {
                return Mo_hinh_to_chuc;
            }
            set
            {
                Mo_hinh_to_chuc = value;
            }
        }
        private string Tuyen_ky_thuat = string.Empty;
        public string tuyen_ky_thuat
        {
            get
            {
                return Tuyen_ky_thuat;
            }
            set
            {
                Tuyen_ky_thuat = value;
            }
        }
        private string Loai_hinh_quan_ly = string.Empty;
        public string loai_hinh_quan_ly
        {
            get
            {
                return Loai_hinh_quan_ly;
            }
            set
            {
                Loai_hinh_quan_ly = value;
            }
        }
    }
    [Serializable()]
    public class thoi_gian_hoat_dong
    {
        private string Loai_thoi_gian_hoat_dong = string.Empty;
        public string loai_thoi_gian_hoat_dong
        {
            get
            {
                return Loai_thoi_gian_hoat_dong;
            }
            set
            {
                Loai_thoi_gian_hoat_dong = value;
            }
        }
        private string ma_hoa_don = string.Empty;
        public string Ma_hoa_don
        {
            get
            {
                return ma_hoa_don;
            }
            set
            {
                ma_hoa_don = value;
            }
        }
        private List<tuy_chon> Tuy_chon;
        public List<tuy_chon> tuy_chon
        {
            get
            {
                if (Tuy_chon == null)
                    Tuy_chon = new List<tuy_chon>();
                return Tuy_chon;
            }
            set
            {
                Tuy_chon = value;
            }
        }
    }
    [Serializable()]
    public class tuy_chon
    {
        private string Type = string.Empty;
        public string type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
        private string Gio_tu = string.Empty;
        public string gio_tu
        {
            get
            {
                return Gio_tu;
            }
            set
            {
                Gio_tu = value;
            }
        }
        private string Gio_den = string.Empty;
        public string gio_den
        {
            get
            {
                return Gio_den;
            }
            set
            {
                Gio_den = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongcosokhamchuabenh
    {
        private string Ma_bao_hiem_co_so_kham_chua_benh = string.Empty;
        public string ma_bao_hiem_co_so_kham_chua_benh
        {
            get
            {
                return Ma_bao_hiem_co_so_kham_chua_benh;
            }
            set
            {
                Ma_bao_hiem_co_so_kham_chua_benh = value;
            }
        }
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
    }
    [Serializable()]
    public class doitacmalienthongcosokhamchuabenh_return_data
    {
        private string Ma_lien_thong_co_so_kham_chua_benh = string.Empty;
        public string ma_lien_thong_co_so_kham_chua_benh
        {
            get
            {
                return Ma_lien_thong_co_so_kham_chua_benh;
            }
            set
            {
                Ma_lien_thong_co_so_kham_chua_benh = value;
            }
        }
        private string Message = string.Empty;
        public string message
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
            }
        }
    }
    [Serializable()]
    public class chandoan
    {
        private string Ma_chan_doan = string.Empty;
        public string ma_chan_doan
        {
            get
            {
                return Ma_chan_doan;
            }
            set
            {
                Ma_chan_doan = value;
            }
        }
        private string Ten_chan_doan = string.Empty;
        public string ten_chan_doan
        {
            get
            {
                return Ten_chan_doan;
            }
            set
            {
                Ten_chan_doan = value;
            }
        }
        private string Ket_luan = string.Empty;
        public string ket_luan
        {
            get
            {
                return Ket_luan;
            }
            set
            {
                Ket_luan = value;
            }
        }
    }
    [Serializable()]
    public class thongtindonthuoc
    {
        private string Ma_thuoc = string.Empty;
        public string ma_thuoc
        {
            get
            {
                return Ma_thuoc;
            }
            set
            {
                Ma_thuoc = value;
            }
        }
        private string Biet_duoc = string.Empty;
        public string biet_duoc
        {
            get
            {
                return Biet_duoc;
            }
            set
            {
                Biet_duoc = value;
            }
        }
        private string Ten_thuoc = string.Empty;
        public string ten_thuoc
        {
            get
            {
                return Ten_thuoc;
            }
            set
            {
                Ten_thuoc = value;
            }
        }
        private string Don_vi_tinh = string.Empty;
        public string don_vi_tinh
        {
            get
            {
                return Don_vi_tinh;
            }
            set
            {
                Don_vi_tinh = value;
            }
        }
        private int So_luong = 0;
        public int so_luong
        {
            get
            {
                return So_luong;
            }
            set
            {
                So_luong = value;
            }
        }
        private string Cach_dung = string.Empty;
        public string cach_dung
        {
            get
            {
                return Cach_dung;
            }
            set
            {
                Cach_dung = value;
            }
        }
    }
    [Serializable()]
    public class donthuocget
    {
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }
        private string Ho_ten_benh_nhan = string.Empty;
        public string ho_ten_benh_nhan
        {
            get
            {
                return Ho_ten_benh_nhan;
            }
            set
            {
                Ho_ten_benh_nhan = value;
            }
        }
        private string Ngay_sinh_benh_nhan = string.Empty;
        public string ngay_sinh_benh_nhan
        {
            get
            {
                return Ngay_sinh_benh_nhan;
            }
            set
            {
                Ngay_sinh_benh_nhan = value;
            }
        }
        private string Ma_dinh_danh_y_te = string.Empty;
        public string ma_dinh_danh_y_te
        {
            get
            {
                return Ma_dinh_danh_y_te;
            }
            set
            {
                Ma_dinh_danh_y_te = value;
            }
        }
        private string Loai_don_thuoc = string.Empty;
        public string loai_don_thuoc
        {
            get
            {
                return Loai_don_thuoc;
            }
            set
            {
                Loai_don_thuoc = value;
            }
        }
        private string Hinh_thuc_dieu_tri = string.Empty;
        public string hinh_thuc_dieu_tri
        {
            get
            {
                return Hinh_thuc_dieu_tri;
            }
            set
            {
                Hinh_thuc_dieu_tri = value;
            }
        }
        private string Dia_chi = string.Empty;
        public string dia_chi
        {
            get
            {
                return Dia_chi;
            }
            set
            {
                Dia_chi = value;
            }
        }
        private string Gioi_tinh = string.Empty;
        public string gioi_tinh
        {
            get
            {
                return Gioi_tinh;
            }
            set
            {
                Gioi_tinh = value;
            }
        }
        private decimal Can_nang = 0;
        public decimal can_nang
        {
            get
            {
                return Can_nang;
            }
            set
            {
                Can_nang = value;
            }
        }
        private string Ma_so_the_bao_hiem_y_te = string.Empty;
        public string ma_so_the_bao_hiem_y_te
        {
            get
            {
                return Ma_so_the_bao_hiem_y_te;
            }
            set
            {
                Ma_so_the_bao_hiem_y_te = value;
            }
        }
        private List<thongtindonthuoc> Thong_tin_don_thuoc;
        public List<thongtindonthuoc> thong_tin_don_thuoc
        {
            get
            {
                if (Thong_tin_don_thuoc == null)
                    Thong_tin_don_thuoc = new List<thongtindonthuoc>();
                return Thong_tin_don_thuoc;
            }
            set
            {
                Thong_tin_don_thuoc = value;
            }
        }
        private List<dot_dung_thuoc> Dot_dung_thuoc;
        public List<dot_dung_thuoc> dot_dung_thuoc
        {
            get
            {
                if (Dot_dung_thuoc == null)
                    Dot_dung_thuoc = new List<dot_dung_thuoc>();
                return Dot_dung_thuoc;
            }
            set
            {
                Dot_dung_thuoc = value;
            }
        }
        private List<chandoan> Chan_doan;
        public List<chandoan> chan_doan
        {
            get
            {
                if (Chan_doan == null)
                    Chan_doan = new List<chandoan>();
                return Chan_doan;
            }
            set
            {
                Chan_doan = value;
            }
        }
        private string Luu_y = string.Empty;
        public string luu_y
        {
            get
            {
                return Luu_y;
            }
            set
            {
                Luu_y = value;
            }
        }
        private string Loi_dan = string.Empty;
        public string loi_dan
        {
            get
            {
                return Loi_dan;
            }
            set
            {
                Loi_dan = value;
            }
        }
        private string Ten_bac_si = string.Empty;
        public string ten_bac_si
        {
            get
            {
                return Ten_bac_si;
            }
            set
            {
                Ten_bac_si = value;
            }
        }
        private string Ten_co_so_kham_chua_benh = string.Empty;
        public string ten_co_so_kham_chua_benh
        {
            get
            {
                return Ten_co_so_kham_chua_benh;
            }
            set
            {
                Ten_co_so_kham_chua_benh = value;
            }
        }
        private string So_dien_thoai_co_so_kham_chua_benh = string.Empty;
        public string so_dien_thoai_co_so_kham_chua_benh
        {
            get
            {
                return So_dien_thoai_co_so_kham_chua_benh;
            }
            set
            {
                So_dien_thoai_co_so_kham_chua_benh = value;
            }
        }
        private string Ngay_gio_ke_don = string.Empty;
        public string ngay_gio_ke_don
        {
            get
            {
                return Ngay_gio_ke_don;
            }
            set
            {
                Ngay_gio_ke_don = value;
            }
        }
    }
    [Serializable()]
    public class donthuocUpdate
    {
        private string Ma_don_thuoc = string.Empty;
        public string ma_don_thuoc
        {
            get
            {
                return Ma_don_thuoc;
            }
            set
            {
                Ma_don_thuoc = value;
            }
        }
        private List<thongtinthuoc> Thong_tin_thuoc;
        public List<thongtinthuoc> thong_tin_thuoc
        {
            get
            {
                if (Thong_tin_thuoc == null)
                    Thong_tin_thuoc = new List<thongtinthuoc>();
                return Thong_tin_thuoc;
            }
            set
            {
                Thong_tin_thuoc = value;
            }
        }
        private string Ma_dinh_danh_co_so_cung_ung_thuoc = string.Empty;
        public string ma_dinh_danh_co_so_cung_ung_thuoc
        {
            get
            {
                return Ma_dinh_danh_co_so_cung_ung_thuoc;
            }
            set
            {
                Ma_dinh_danh_co_so_cung_ung_thuoc = value;
            }
        }
        private string Ten_co_so_cung_ung_thuoc = string.Empty;
        public string ten_co_so_cung_ung_thuoc
        {
            get
            {
                return Ten_co_so_cung_ung_thuoc;
            }
            set
            {
                Ten_co_so_cung_ung_thuoc = value;
            }
        }
        private string So_dien_thoai_co_so_cung_ung_thuoc = string.Empty;
        public string so_dien_thoai_co_so_cung_ung_thuoc
        {
            get
            {
                return So_dien_thoai_co_so_cung_ung_thuoc;
            }
            set
            {
                So_dien_thoai_co_so_cung_ung_thuoc = value;
            }
        }
        private string Dia_chi_co_so_cung_ung_thuoc = string.Empty;
        public string dia_chi_co_so_cung_ung_thuoc
        {
            get
            {
                return Dia_chi_co_so_cung_ung_thuoc;
            }
            set
            {
                Dia_chi_co_so_cung_ung_thuoc = value;
            }
        }
        private string Ma_hoa_don = string.Empty;
        public string ma_hoa_don
        {
            get
            {
                return Ma_hoa_don;
            }
            set
            {
                Ma_hoa_don = value;
            }
        }
    }
    [Serializable()]
    public class thongtinthuoc
    {
        private string Ma_thuoc_da_ke_don = string.Empty;
        public string ma_thuoc_da_ke_don
        {
            get
            {
                return Ma_thuoc_da_ke_don;
            }
            set
            {
                Ma_thuoc_da_ke_don = value;
            }
        }
        private string Ma_thuoc = string.Empty;
        public string ma_thuoc
        {
            get
            {
                return Ma_thuoc;
            }
            set
            {
                Ma_thuoc = value;
            }
        }
        private string Biet_duoc = string.Empty;
        public string biet_duoc
        {
            get
            {
                return Biet_duoc;
            }
            set
            {
                Biet_duoc = value;
            }
        }
        private string Ten_thuoc = string.Empty;
        public string ten_thuoc
        {
            get
            {
                return Ten_thuoc;
            }
            set
            {
                Ten_thuoc = value;
            }
        }
        private string Don_vi_tinh = string.Empty;
        public string don_vi_tinh
        {
            get
            {
                return Don_vi_tinh;
            }
            set
            {
                Don_vi_tinh = value;
            }
        }
        private int So_luong = 0;
        public int so_luong
        {
            get
            {
                return So_luong;
            }
            set
            {
                So_luong = value;
            }
        }
        private string Cach_dung = string.Empty;
        public string cach_dung
        {
            get
            {
                return Cach_dung;
            }
            set
            {
                Cach_dung = value;
            }
        }
    }

    #endregion


    // ham dung de trao doi du lieu voi API RESTfull
    public class DTDTAPI
    {
        public string PostURL(string url, string username, string password, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PutURLtoken(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "PUT";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLtoken(string url, string token, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string DeleteURLtoken(string url, string token)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "DELETE";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string PostURLNoAuth(string url, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "POST";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public string GetURL(string url, string name, string key)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Headers.Add("app-name", name);
            myWebRequest.Headers.Add("app-key", key);
            myWebRequest.Method = "GET";
            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            //NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            //CredentialCache myCredentialCache = new CredentialCache();
            //myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            //myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                //streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            return pageContent;
        }
        public void PostAppName(string url, string name, string key, string jsondata)
        {
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            myWebRequest.ContentType = "application/json";
            myWebRequest.Headers.Add("app-name", name);
            myWebRequest.Headers.Add("app-key", key);
            myWebRequest.Method = "POST";
            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            //NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            //CredentialCache myCredentialCache = new CredentialCache();
            //myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            //myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Credentials = myCredentialCache;
            using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsondata);
                streamWriter.Flush();
                streamWriter.Close();
            }
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();
            myWebResponse.Close();
            //return pageContent;
        }
        #region RESTfulAPI
        //ham giai ma chuoi UTF-8
        public string DecodeFromUtf8(string utf8String)
        {
            return Regex.Replace(
              utf8String,
              @"\\u(?<Value>[a-fA-F0-9]{4})",
              m =>
              {
                  return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
              });
        }
        //ham dang nhap co so kham chua benh de lay to_ken them bac si
        public string dangnhapCoSoKCB(string port, string user, string pass)
        {
            string url = port + "/api/auth/dang-nhap-co-so-kham-chua-benh";
            dangnhapcosokhamchuabenh dn = new dangnhapcosokhamchuabenh();
            //RESTful rf = new RESTful();
            dn.ma_lien_thong_co_so_kham_chua_benh = user;
            dn.password = pass;
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(dn);
            string returndata = PostURLNoAuth(url, serializedResult);
            var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
                return data.token;
            else return "";
            //return serializedResult;
            //return returndata;
        }
        //ham dang nhap bac si de lay to_ken day don thuoc
        public string dangnhapBS(string port, string user, string pass, string macskcb)
        {
            string url = port + "/auth/dang-nhap-bac-si";
            dangnhapbacsi dn = new dangnhapbacsi();
            dn.ma_lien_thong_bac_si = user;
            dn.ma_lien_thong_co_so_kham_chua_benh = macskcb;
            dn.password = pass;
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(dn);
            string returndata = PostURLNoAuth(url, serializedResult);
            var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
                return data.token;
            else return "";
            //return serializedResult;
            //return returndata;
        }
        //ham them ma lien thong bac si vao co so kcb
        public string themBS(string port, string user, string token)
        {
            string url = port + "/api/v1/them-bac-si";
            var serializer = new JavaScriptSerializer();
            string serializedResult = "{\"ma_lien_thong_bac_si\" : \"" + user + "\"}";
            string returndata = PostURLtoken(url, token, serializedResult);
            //var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            //if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
            //    return data.token;
            //else return "";
            //return serializedResult;
            //return returndata;
            string output = DecodeFromUtf8(returndata);
            return output;
        }
        //ham xoa ma lien thong bac si khoi co so kcb
        public string xoaBS(string port, string user, string token)
        {
            string url = port + "/api/v1/xoa-bac-si";
            var serializer = new JavaScriptSerializer();
            string serializedResult = "{\"ma_lien_thong_bac_si\" : \"" + user + "\"}";
            string returndata = PostURLtoken(url, token, serializedResult);
            //var data = serializer.Deserialize<dangnhapbacsi_return_data>(returndata);
            //if (data != null && data.token_type == "bearer" && !string.IsNullOrEmpty(data.token))
            //    return data.token;
            //else return "";
            //return serializedResult;
            //return returndata;
            string output = DecodeFromUtf8(returndata);
            return output;
        }
        //ham gui don thuoc
        public string Gui_don_thuoc(string port, string token, donthuoc dt)
        {
            string url = port + "/api/v1/gui-don-thuoc";
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(dt);
            string returndata = PostURLtoken(url, token, serializedResult);
            //var data = serializer.Deserialize<kq_don_thuoc_return>(returndata);
            //if (data != null && data.Code == 200 && data.Ma_don_thuoc_quoc_gia != "")
            //    return data.Ma_don_thuoc_quoc_gia;
            //else return "";
            //var output = System.Net.WebUtility.HtmlDecode(returndata);
            string output = DecodeFromUtf8(returndata);
            return output;
        }
        //ham lay thong tin don thuoc
        public donthuocget laydonthuoc(string port, string madonthuoc, string name, string key)
        {
            string url = port + "/api/v1/thong-tin-don-thuoc/" + madonthuoc;
            string returndata = GetURL(url, name, key);
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<donthuocget>(returndata);
            if (data != null)
                return data;
            else return null;
        }
        public void capnhatdonthuoc(string port, string name, string key, donthuocUpdate donthuoc)
        {
            string url = port + "/api/v1/cap-nhat-don-thuoc";
            var serializer = new JavaScriptSerializer();
            string serializedResult = serializer.Serialize(donthuoc);
            PostAppName(url, name, key, serializedResult);
        }
        #endregion
    }
}
