// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongtinBNNoiTru
// Kieu doi tuong  :	ThongtinBNNoiTru
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/23/2009 9:30:39 AM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi cac ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThongtinBNNoiTru" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongtinBNNoiTru : BusinessBase<ThongtinBNNoiTru>
	{
		#region Business Methods
		
		#region State Fields
        //private SmartDate _giaTriTN = new SmartDate(true);
        //private String _maBN = String.Empty;
        //private String _hoten = String.Empty;
        //private String _sothe = String.Empty;
        //private String _maBV = String.Empty;
        //private SmartDate _giaTriDN = new SmartDate(true);
        //private String _maDT = String.Empty;
        //private String _diaChi = String.Empty;
        //private String _diaChiC = String.Empty;
        //private String _dienThoai = String.Empty;
        //private String _dTDD = String.Empty;
        //private String _dTCQ = String.Empty;
        //private String _mail = String.Empty;
        //private Byte _tuoi = 1;
        //private int _thang = 1;
        //private SmartDate _ngaySinh = new SmartDate(true);
        //private SmartDate _ngaySinhD = new SmartDate(true);
        //private SmartDate _ngayyc = new SmartDate(true);
        //private Boolean _gt = false;
        //private Boolean _gtNu = false;
        //private String _baoTin = String.Empty;
        //private String _maQG = String.Empty;
        //private String _maTinh = String.Empty;
        //private String _maHuyen = String.Empty;
        //private String _maNN = String.Empty;
        //private String _tienSu = String.Empty;
        //private String _tienSuThuoc = String.Empty;
        //private String _tienSuGiaDinh = String.Empty;
        //private String _nhomMau = String.Empty;
        //private String _maBANoiT = String.Empty;
        //private String _maKhoaVV = String.Empty;
        //private SmartDate _ngayVV = new SmartDate(true);
        //private String _maBANgoaiT = String.Empty;
        //private SmartDate _ngayKham = new SmartDate(true);
        //private String _ghichu = String.Empty;
        //private String _maMay = String.Empty;
        //private SmartDate _ngayLap = new SmartDate(true);
        //private String _nguoiLap = String.Empty;
        //private SmartDate _ngayHuy = new SmartDate(true);
        //private String _nguoiHuy = String.Empty;
        //private SmartDate _ngaySD = new SmartDate(true);
        //private String _nguoiSD = String.Empty;
        //private SmartDate _ngaySD1 = new SmartDate(true);
        //private String _nguoiSD1 = String.Empty;
        //private Boolean _huy = false;
        //private SmartDate _ngayBANgoaiT = new SmartDate(true);
        //private String _madantoc = String.Empty;
        //private String _hotenbome = String.Empty;
		
        //private int _OrderNumber;
        //private String _mabhxh = String.Empty;
        //private String _tenbv = String.Empty;

        private String _maBN = String.Empty;
        private String _hoten = String.Empty;
        private SmartDate _ngaySinh = new SmartDate(true);
        private String _tENDT = String.Empty;
        private Byte _tuoi = 0;
        private String _diachi = String.Empty;
        private String _dienthoai = String.Empty;
        private Boolean _gt = false;
        private String _nhomMau = String.Empty;
        private String _tIENSUBenh = String.Empty;
        private String _tienSuThuoc = String.Empty;
        private String _dTCQ = String.Empty;
        private String _dTDD = String.Empty;
        private String _mail = String.Empty;
        private String _diachiCT = String.Empty;
        private String _ghichu = String.Empty;
        private String _soThe = String.Empty;
        private String _baotin = String.Empty;
        private SmartDate _gIATRIDN = new SmartDate(true);
        private String _tENBV = String.Empty;
        private String _mABHXH = String.Empty;
        private String _tENTINH = String.Empty;
        private String _tENQH = String.Empty;
        private String _tENNN = String.Empty;
        private String _tENQG = String.Empty;
        private SmartDate _ngaySinhD = new SmartDate(true);
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
        //public string GiaTriTN
        //{
        //    get
        //    {
        //        CanReadProperty("GiaTriTN", true);
        //        return _giaTriTN.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("GiaTriTN", true);
        //        if (_giaTriTN.Text != value)
        //        {
        //            _giaTriTN.Text = value;
        //            PropertyHasChanged("GiaTriTN");
        //        }
        //    }
        //}
        //public String mabhxh
        //{
        //    get
        //    {
        //        CanReadProperty("mabhxh", true);
        //        return _mabhxh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("mabhxh", true);
        //        if (_mabhxh != value)
        //        {
        //            _mabhxh = value;
        //            PropertyHasChanged("mabhxh");
        //        }
        //    }
        //}
        //public String hotenbome
        //{
        //    get
        //    {
        //        CanReadProperty("hotenbome", true);
        //        return _hotenbome;
        //    }
        //    set
        //    {
        //        CanWriteProperty("hotenbome", true);
        //        if (_hotenbome != value)
        //        {
        //            _hotenbome = value;
        //            PropertyHasChanged("hotenbome");
        //        }
        //    }
        //}
        //public String madantoc
        //{
        //    get
        //    {
        //        CanReadProperty("madantoc", true);
        //        return _madantoc;
        //    }
        //    set
        //    {
        //        CanWriteProperty("madantoc", true);
        //        if (_madantoc != value)
        //        {
        //            _madantoc = value;
        //            PropertyHasChanged("madantoc");
        //        }
        //    }
        //}
        //public String tenbv
        //{
        //    get
        //    {
        //        CanReadProperty("tenbv", true);
        //        return _tenbv;
        //    }
        //    set
        //    {
        //        CanWriteProperty("tenbv", true);
        //        if (_tenbv != value)
        //        {
        //            _tenbv = value;
        //            PropertyHasChanged("tenbv");
        //        }
        //    }
        //}
        //public String Sothe
        //{
        //    get
        //    {
        //        CanReadProperty("Sothe", true);
        //        return _sothe;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Sothe", true);
        //        if (_sothe != value)
        //        {
        //            _sothe = value;
        //            PropertyHasChanged("Sothe");
        //        }
        //    }
        //}
        //public String MaDT
        //{
        //    get
        //    {
        //        CanReadProperty("MaDT", true);
        //        return _maDT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("MaDT", true);
        //        if (_maDT != value)
        //        {
        //            _maDT = value;
        //            PropertyHasChanged("MaDT");
        //        }
        //    }
        //}
        //public String MaBN
        //{
        //    get 
        //    {
        //        CanReadProperty("MaBN", true);
        //        return _maBN;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaBN", true);
        //        if (_maBN != value) 
        //        {
        //            _maBN = value;
        //            PropertyHasChanged("MaBN");
        //        }
        //    }
        //}
		
        //public String Hoten
        //{
        //    get 
        //    {
        //        CanReadProperty("Hoten", true);
        //        return  _hoten.ToUpper();
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Hoten", true);
        //        if (_hoten != value) 
        //        {
        //            _hoten = value;
        //            PropertyHasChanged("Hoten");
        //        }
        //    }
        //}
		
        ////public String Sothe
        ////{
        ////    get 
        ////    {
        ////        CanReadProperty("Sothe", true);
        ////        return _sothe;
        ////    }
        ////    set 
        ////    {
        ////        CanWriteProperty("Sothe", true);
        ////        if (_sothe != value) 
        ////        {
        ////            _sothe = value;
        ////            PropertyHasChanged("Sothe");
        ////        }
        ////    }
        ////}
		
        //public String MaBV
        //{
        //    get 
        //    {
        //        CanReadProperty("MaBV", true);
        //        return _maBV;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaBV", true);
        //        if (_maBV != value) 
        //        {
        //            _maBV = value;
        //            PropertyHasChanged("MaBV");
        //        }
        //    }
        //}
		
        //public string GiaTriDN
        //{
        //    get 
        //    {
        //        CanReadProperty("GiaTriDN", true);
        //        return _giaTriDN.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GiaTriDN", true);
        //        if (_giaTriDN.Text != value) 
        //        {
        //            _giaTriDN.Text = value;
        //            PropertyHasChanged("GiaTriDN");
        //        }
        //    }
        //}
		
        //public String DiaChi
        //{
        //    get 
        //    {
        //        CanReadProperty("DiaChi", true);
               
        //        return _diaChi;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DiaChi", true);
        //        if (_diaChi != value) 
        //        {
        //            _diaChi = value;
        //            PropertyHasChanged("DiaChi");
        //        }
        //    }
        //}
        //public String DiaChiC
        //{
        //    get
        //    {
        //        CanReadProperty("DiaChiC", true);

        //        return _diaChiC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DiaChiC", true);
        //        if (_diaChiC != value)
        //        {
        //            _diaChiC = value;
        //            PropertyHasChanged("DiaChiC");
        //        }
        //    }
        //}
		
        //public String DienThoai
        //{
        //    get 
        //    {
        //        CanReadProperty("DienThoai", true);
        //        return _dienThoai;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DienThoai", true);
        //        if (_dienThoai != value) 
        //        {
        //            _dienThoai = value;
        //            PropertyHasChanged("DienThoai");
        //        }
        //    }
        //}
		
        //public String DTDD
        //{
        //    get 
        //    {
        //        CanReadProperty("DTDD", true);
        //        return _dTDD;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DTDD", true);
        //        if (_dTDD != value) 
        //        {
        //            _dTDD = value;
        //            PropertyHasChanged("DTDD");
        //        }
        //    }
        //}
		
        //public String DTCQ
        //{
        //    get 
        //    {
        //        CanReadProperty("DTCQ", true);
        //        return _dTCQ;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DTCQ", true);
        //        if (_dTCQ != value) 
        //        {
        //            _dTCQ = value;
        //            PropertyHasChanged("DTCQ");
        //        }
        //    }
        //}
		
        //public String Mail
        //{
        //    get 
        //    {
        //        CanReadProperty("Mail", true);
        //        return _mail;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Mail", true);
        //        if (_mail != value) 
        //        {
        //            _mail = value;
        //            PropertyHasChanged("Mail");
        //        }
        //    }
        //}
		
        //public byte Tuoi
        //{
        //    get
        //    {
                   
        //        //CanReadProperty("Tuoi", true);
        //      if (_ngaySinh.Date   != DateTime.MinValue   ) 
        //      if (_ngaySinh.Date.Year != 0)
        //          _tuoi = Convert.ToByte ( Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year );
        //        return _tuoi;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Tuoi", true);
        //        if (_tuoi != value)
        //        {
        //            _tuoi = value;
        //            PropertyHasChanged("Tuoi");
        //        }
        //    }
        //}
        //public int thang
        //{
        //    get
        //    {

        //        //CanReadProperty("thang", true);
        //        if (Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month) < 0)
        //            _thang = Convert.ToInt32 (DateTime.Now.Month - _ngaySinh.Date.Month  +13);
        //        else
        //            _thang = Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month + 1);
        //        return _thang; 
        //    }
        //    set
        //    {
        //        CanWriteProperty("thang", true);
        //        if (_thang != value)
        //        {
        //            _thang = value;
        //            PropertyHasChanged("thang");
        //        }
        //    }
        //}
        //public string NgaySinh
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySinh", true);
        //     //   _ngaySinh.FormatString = "MM/dd/yyyy"; 
        //        return _ngaySinh.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySinh", true);
        //        if (_ngaySinh.Text != value) 
        //        {
        //            _ngaySinh.Text = value;
        //            if (_ngaySinh.Date.Year != 1)
        //                _tuoi  = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
        //            PropertyHasChanged("NgaySinh");
        //        }
        //    }
        //}
        //public string NgaySinhD
        //{
        //    get
        //    {
        //        CanReadProperty("NgaySinh", true);
        //        _ngaySinhD = _ngaySinh;
        //        _ngaySinhD.FormatString = "dd/MM/yyyy";
        //        return _ngaySinh.Text;
        //    }
            
        //}
        //public Boolean GT
        //{
        //    get 
        //    {
        //        CanReadProperty("GT", true);
        //        return _gt;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GT", true);
        //        if (_gt != value) 
        //        {
        //            _gt = value;
        //            PropertyHasChanged("GT");
        //        }
        //    }
        //}
        //public Boolean GTNu
        //{
        //    get
        //    {
        //        CanReadProperty("GTNu", true);
        //        if (_gt == true)
        //            return false;
        //        else
        //            return true;
        //    }
        //    set
        //    {
        //        CanWriteProperty("GTNu", true);
        //        if (_gtNu  != value)
        //        {
        //            if (value == true)
        //                _gt = false;
        //            else
        //                _gt = true;
        //            _gtNu  = value;

        //            PropertyHasChanged("GTnu");
        //        }
                
        //    }
        //}
        //public String BaoTin
        //{
        //    get 
        //    {
        //        CanReadProperty("BaoTin", true);
        //        return _baoTin;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("BaoTin", true);
        //        if (_baoTin != value) 
        //        {
        //            _baoTin = value;
        //            PropertyHasChanged("BaoTin");
        //        }
        //    }
        //}
		
        //public String MaQG
        //{
        //    get 
        //    {
        //        CanReadProperty("MaQG", true);
        //        return _maQG;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaQG", true);
        //        if (_maQG != value) 
        //        {
        //            _maQG = value;
        //            PropertyHasChanged("MaQG");
        //        }
        //    }
        //}
		
        //public String MaTinh
        //{
        //    get 
        //    {
        //        CanReadProperty("MaTinh", true);
        //        return _maTinh;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaTinh", true);
        //        if (_maTinh != value) 
        //        {
        //            _maTinh = value;
        //            PropertyHasChanged("MaTinh");
        //        }
        //    }
        //}
		
        //public String MaHuyen
        //{
        //    get 
        //    {
        //        CanReadProperty("MaHuyen", true);
        //        return _maHuyen;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaHuyen", true);
        //        if (_maHuyen != value) 
        //        {
        //            _maHuyen = value;
        //            PropertyHasChanged("MaHuyen");
        //        }
        //    }
        //}
		
        //public String MaNN
        //{
        //    get 
        //    {
        //        CanReadProperty("MaNN", true);
        //        return _maNN;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaNN", true);
        //        if (_maNN != value) 
        //        {
        //            _maNN = value;
        //            PropertyHasChanged("MaNN");
        //        }
        //    }
        //}
		
        //public String TienSu
        //{
        //    get 
        //    {
        //        CanReadProperty("TienSu", true);
        //        return _tienSu;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TienSu", true);
        //        if (_tienSu != value) 
        //        {
        //            _tienSu = value;
        //            PropertyHasChanged("TienSu");
        //        }
        //    }
        //}
		
        //public String TienSuThuoc
        //{
        //    get 
        //    {
        //        CanReadProperty("TienSuThuoc", true);
        //        return _tienSuThuoc;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TienSuThuoc", true);
        //        if (_tienSuThuoc != value) 
        //        {
        //            _tienSuThuoc = value;
        //            PropertyHasChanged("TienSuThuoc");
        //        }
        //    }
        //}
		
        //public String TienSuGiaDinh
        //{
        //    get 
        //    {
        //        CanReadProperty("TienSuGiaDinh", true);
        //        return _tienSuGiaDinh;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TienSuGiaDinh", true);
        //        if (_tienSuGiaDinh != value) 
        //        {
        //            _tienSuGiaDinh = value;
        //            PropertyHasChanged("TienSuGiaDinh");
        //        }
        //    }
        //}
		
        //public String NhomMau
        //{
        //    get 
        //    {
        //        CanReadProperty("NhomMau", true);
        //        return _nhomMau;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NhomMau", true);
        //        if (_nhomMau != value) 
        //        {
        //            _nhomMau = value;
        //            PropertyHasChanged("NhomMau");
        //        }
        //    }
        //}
		
        //public String MaBANoiT
        //{
        //    get 
        //    {
        //        CanReadProperty("MaBANoiT", true);
        //        return _maBANoiT;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaBANoiT", true);
        //        if (_maBANoiT != value) 
        //        {
        //            _maBANoiT = value;
        //            PropertyHasChanged("MaBANoiT");
        //        }
        //    }
        //}
		
        //public String MaKhoaVV
        //{
        //    get 
        //    {
        //        CanReadProperty("MaKhoaVV", true);
        //        return _maKhoaVV;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaKhoaVV", true);
        //        if (_maKhoaVV != value) 
        //        {
        //            _maKhoaVV = value;
        //            PropertyHasChanged("MaKhoaVV");
        //        }
        //    }
        //}
		
        //public string NgayVV
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayVV", true);
        //        return _ngayVV.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayVV", true);
        //        if (_ngayVV.Text != value) 
        //        {
        //            _ngayVV.Text = value;
        //            PropertyHasChanged("NgayVV");
        //        }
        //    }
        //}
		
        //public String MaBANgoaiT
        //{
        //    get 
        //    {
        //        CanReadProperty("MaBANgoaiT", true);
        //        return _maBANgoaiT;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaBANgoaiT", true);
        //        if (_maBANgoaiT != value) 
        //        {
        //            _maBANgoaiT = value;
        //            PropertyHasChanged("MaBANgoaiT");
        //        }
        //    }
        //}
		
        //public string NgayKham
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayKham", true);
        //        _ngayKham.FormatString = "dd/MM/yyyy";
        //        return _ngayKham.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayKham", true);
        //        if (_ngayKham.Text != value) 
        //        {
        //            _ngayKham.FormatString = "dd/MM/yyyy";
        //            _ngayKham.Text = value;
        //            PropertyHasChanged("NgayKham");
        //        }
        //    }
        //}
		
        //public String Ghichu
        //{
        //    get 
        //    {
        //        CanReadProperty("Ghichu", true);
        //        return _ghichu;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Ghichu", true);
        //        if (_ghichu != value) 
        //        {
        //            _ghichu = value;
        //            PropertyHasChanged("Ghichu");
        //        }
        //    }
        //}
		
        //public String MaMay
        //{
        //    get 
        //    {
        //        CanReadProperty("MaMay", true);
        //        return _maMay;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaMay", true);
        //        if (_maMay != value) 
        //        {
        //            _maMay = value;
        //            PropertyHasChanged("MaMay");
        //        }
        //    }
        //}
		
        //public string NgayLap
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayLap", true);
        //        return _ngayLap.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayLap", true);
        //        if (_ngayLap.Text != value) 
        //        {
        //            _ngayLap.Text = value;
        //            PropertyHasChanged("NgayLap");
        //        }
        //    }
        //}
		
        //public String NguoiLap
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiLap", true);
        //        return _nguoiLap;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiLap", true);
        //        if (_nguoiLap != value) 
        //        {
        //            _nguoiLap = value;
        //            PropertyHasChanged("NguoiLap");
        //        }
        //    }
        //}
		
        //public string NgayHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayHuy", true);
        //        return _ngayHuy.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayHuy", true);
        //        if (_ngayHuy.Text != value) 
        //        {
        //            _ngayHuy.Text = value;
        //            PropertyHasChanged("NgayHuy");
        //        }
        //    }
        //}
		
        //public String NguoiHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiHuy", true);
        //        return _nguoiHuy;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiHuy", true);
        //        if (_nguoiHuy != value) 
        //        {
        //            _nguoiHuy = value;
        //            PropertyHasChanged("NguoiHuy");
        //        }
        //    }
        //}
		
        //public string NgaySD
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD", true);
        //        return _ngaySD.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD", true);
        //        if (_ngaySD.Text != value) 
        //        {
        //            _ngaySD.Text = value;
        //            PropertyHasChanged("NgaySD");
        //        }
        //    }
        //}
		
        //public String NguoiSD
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD", true);
        //        return _nguoiSD;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD", true);
        //        if (_nguoiSD != value) 
        //        {
        //            _nguoiSD = value;
        //            PropertyHasChanged("NguoiSD");
        //        }
        //    }
        //}
		
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _ngaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value) 
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
		
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value) 
        //        {
        //            _nguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}
		
        //public Boolean Huy
        //{
        //    get 
        //    {
        //        CanReadProperty("Huy", true);
        //        return _huy;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Huy", true);
        //        if (_huy != value) 
        //        {
        //            _huy = value;
        //            PropertyHasChanged("Huy");
        //        }
        //    }
        //}
		
        //public string NgayBANgoaiT
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayBANgoaiT", true);
        //        return _ngayBANgoaiT.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayBANgoaiT", true);
        //        if (_ngayBANgoaiT.Text != value) 
        //        {
        //            _ngayBANgoaiT.Text = value;
        //            PropertyHasChanged("NgayBANgoaiT");
        //        }
        //    }
        //}
        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _maBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_maBN != value)
                {
                    _maBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }

        //public string NgaySinh
        //{
        //    get
        //    {
        //        CanReadProperty("NgaySinh", true);
        //        return _ngaySinh.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgaySinh", true);
        //        if (_ngaySinh.Text != value)
        //        {
        //            _ngaySinh.Text = value;
        //            PropertyHasChanged("NgaySinh");
        //        }
        //    }
        //}
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinh.FormatString = "MM/dd/yyyy";
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    if (_ngaySinh.Date.Year != 1)
                        _tuoi = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public String TENDT
        {
            get
            {
                CanReadProperty("TENDT", true);
                return _tENDT;
            }
            set
            {
                CanWriteProperty("TENDT", true);
                if (_tENDT != value)
                {
                    _tENDT = value;
                    PropertyHasChanged("TENDT");
                }
            }
        }

        public Byte Tuoi
        {
            get
            {
                CanReadProperty("Tuoi", true);
                return _tuoi;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }

        public String Diachi
        {
            get
            {
                CanReadProperty("Diachi", true);
                return _diachi;
            }
            set
            {
                CanWriteProperty("Diachi", true);
                if (_diachi != value)
                {
                    _diachi = value;
                    PropertyHasChanged("Diachi");
                }
            }
        }

        public String Dienthoai
        {
            get
            {
                CanReadProperty("Dienthoai", true);
                return _dienthoai;
            }
            set
            {
                CanWriteProperty("Dienthoai", true);
                if (_dienthoai != value)
                {
                    _dienthoai = value;
                    PropertyHasChanged("Dienthoai");
                }
            }
        }

        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
                }
            }
        }

        public String NhomMau
        {
            get
            {
                CanReadProperty("NhomMau", true);
                return _nhomMau;
            }
            set
            {
                CanWriteProperty("NhomMau", true);
                if (_nhomMau != value)
                {
                    _nhomMau = value;
                    PropertyHasChanged("NhomMau");
                }
            }
        }

        public String TIENSUBenh
        {
            get
            {
                CanReadProperty("TIENSUBenh", true);
                return _tIENSUBenh;
            }
            set
            {
                CanWriteProperty("TIENSUBenh", true);
                if (_tIENSUBenh != value)
                {
                    _tIENSUBenh = value;
                    PropertyHasChanged("TIENSUBenh");
                }
            }
        }

        public String TienSuThuoc
        {
            get
            {
                CanReadProperty("TienSuThuoc", true);
                return _tienSuThuoc;
            }
            set
            {
                CanWriteProperty("TienSuThuoc", true);
                if (_tienSuThuoc != value)
                {
                    _tienSuThuoc = value;
                    PropertyHasChanged("TienSuThuoc");
                }
            }
        }

        public String DTCQ
        {
            get
            {
                CanReadProperty("DTCQ", true);
                return _dTCQ;
            }
            set
            {
                CanWriteProperty("DTCQ", true);
                if (_dTCQ != value)
                {
                    _dTCQ = value;
                    PropertyHasChanged("DTCQ");
                }
            }
        }

        public String DTDD
        {
            get
            {
                CanReadProperty("DTDD", true);
                return _dTDD;
            }
            set
            {
                CanWriteProperty("DTDD", true);
                if (_dTDD != value)
                {
                    _dTDD = value;
                    PropertyHasChanged("DTDD");
                }
            }
        }

        public String Mail
        {
            get
            {
                CanReadProperty("Mail", true);
                return _mail;
            }
            set
            {
                CanWriteProperty("Mail", true);
                if (_mail != value)
                {
                    _mail = value;
                    PropertyHasChanged("Mail");
                }
            }
        }

        public String DiachiCT
        {
            get
            {
                CanReadProperty("DiachiCT", true);
                return _diachiCT;
            }
            set
            {
                CanWriteProperty("DiachiCT", true);
                if (_diachiCT != value)
                {
                    _diachiCT = value;
                    PropertyHasChanged("DiachiCT");
                }
            }
        }

        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("Ghichu");
                }
            }
        }

        public String SoThe
        {
            get
            {
                CanReadProperty("SoThe", true);
                return _soThe;
            }
            set
            {
                CanWriteProperty("SoThe", true);
                if (_soThe != value)
                {
                    _soThe = value;
                    PropertyHasChanged("SoThe");
                }
            }
        }

        public String Baotin
        {
            get
            {
                CanReadProperty("Baotin", true);
                return _baotin;
            }
            set
            {
                CanWriteProperty("Baotin", true);
                if (_baotin != value)
                {
                    _baotin = value;
                    PropertyHasChanged("Baotin");
                }
            }
        }
        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinhD = _ngaySinh;
                _ngaySinhD.FormatString = "dd/MM/yyyy";
                return _ngaySinh.Text;
            }
        }
        public string GIATRIDN
        {
            get
            {
                CanReadProperty("GIATRIDN", true);
                return _gIATRIDN.Text;
            }
            set
            {
                CanWriteProperty("GIATRIDN", true);
                if (_gIATRIDN.Text != value)
                {
                    _gIATRIDN.Text = value;
                    PropertyHasChanged("GIATRIDN");
                }
            }
        }

        public String TENBV
        {
            get
            {
                CanReadProperty("TENBV", true);
                return _tENBV;
            }
            set
            {
                CanWriteProperty("TENBV", true);
                if (_tENBV != value)
                {
                    _tENBV = value;
                    PropertyHasChanged("TENBV");
                }
            }
        }

        public String MABHXH
        {
            get
            {
                CanReadProperty("MABHXH", true);
                return _mABHXH;
            }
            set
            {
                CanWriteProperty("MABHXH", true);
                if (_mABHXH != value)
                {
                    _mABHXH = value;
                    PropertyHasChanged("MABHXH");
                }
            }
        }

        public String TENTINH
        {
            get
            {
                CanReadProperty("TENTINH", true);
                return _tENTINH;
            }
            set
            {
                CanWriteProperty("TENTINH", true);
                if (_tENTINH != value)
                {
                    _tENTINH = value;
                    PropertyHasChanged("TENTINH");
                }
            }
        }

        public String TENQH
        {
            get
            {
                CanReadProperty("TENQH", true);
                return _tENQH;
            }
            set
            {
                CanWriteProperty("TENQH", true);
                if (_tENQH != value)
                {
                    _tENQH = value;
                    PropertyHasChanged("TENQH");
                }
            }
        }

        public String TENNN
        {
            get
            {
                CanReadProperty("TENNN", true);
                return _tENNN;
            }
            set
            {
                CanWriteProperty("TENNN", true);
                if (_tENNN != value)
                {
                    _tENNN = value;
                    PropertyHasChanged("TENNN");
                }
            }
        }

        public String TENQG
        {
            get
            {
                CanReadProperty("TENQG", true);
                return _tENQG;
            }
            set
            {
                CanWriteProperty("TENQG", true);
                if (_tENQG != value)
                {
                    _tENQG = value;
                    PropertyHasChanged("TENQG");
                }
            }
        }
        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }
       // KhamBenh _KhamBenh = KhamBenh.NewKhamBenh();

        //public KhamBenh KhamBenh
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh.Equals(value))
        //        {
        //            _KhamBenh = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        protected override Object GetIdValue()
        {
            return _maBN;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty ;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //    //TODO: add validation rules

        //    ValidationRules.AddRule<ThongtinBNNoiTru>(ValidationNgaySinh<ThongtinBNNoiTru>, "NgaySinh");
           
        //}
        private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : ThongtinBNNoiTru
        {
            if (target._ngaySinh.Date > System.DateTime.Now.AddDays(1))
            {
                e.Description = "VALIDATION_NOW";
                return false;
            }
            else
                return true;
        }

		#endregion

       
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThongtinBNNoiTru" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        //public static ThongtinBNNoiTru NewThongtinBNNoiTru()
        //{
        //    //return new DMNhomThuoc();

        //    return DataPortal.Create<ThongtinBNNoiTru>();
        //}
		public static ThongtinBNNoiTru GetThongtinBNNoiTru(String maBN)
		{
			return DataPortal.Fetch<ThongtinBNNoiTru>(new Criteria(maBN));
		}
        public static ThongtinBNNoiTru GetThongtinBNNoiTru(String maBN,  Byte loai,string _nguoisd,string mamay)
        {
            return DataPortal.Fetch<ThongtinBNNoiTru>(new OtherCriteria(mamay   ,_nguoisd    ,maBN, loai));
        }
        public static ThongtinBNNoiTru GetThongtinBNNoiTru(String maBN, DateTime ngaydk, Byte loai,string masokham, int stt,byte loaikqcn,byte loaikq,string makhoa)
        {
            return DataPortal.Fetch<ThongtinBNNoiTru>(new CriteriaKB(maBN, ngaydk, loai, masokham, stt, loaikqcn, loaikq, makhoa));
        }
        public static ThongtinBNNoiTru GetThongtinBNNoiTru(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn)
        {
            return DataPortal.Fetch<ThongtinBNNoiTru>(new CriteriaKB(maBN, ngaydk, loai, masokham, stt, loaikqcn, 0,""));
        }
		/// <summary>
		/// Marks the <see cref="ThongtinBNNoiTru" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteThongtinBNNoiTru(String maBN)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN, 0));
        //}
        
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThongtinBNNoiTru()
		{
             // MarkAsChild();
            
             //_maDT = "00001";
             //_madantoc = "00025";
             //_maQG = "00084";
             //_gt = true;
            //MarkOld();
                         
		}

        internal ThongtinBNNoiTru(       int OrderNumber,
  String maBN ,
  String hoten ,
  SmartDate ngaySinh,
  String tENDT ,
  Byte tuoi,
  String diachi ,
  String dienthoai ,
  Boolean gt ,
  String nhomMau ,
  String tIENSUBenh ,
  String tienSuThuoc ,
  String dTCQ ,
  String dTDD ,
  String mail ,
  String diachiCT ,
  String ghichu ,
  String soThe ,
  String baotin ,
  SmartDate gIATRIDN ,
  String tENBV ,
  String mABHXH ,
  String tENTINH ,
  String tENQH ,
  String tENNN ,
  String tENQG )
        { 
    _OrderNumber = OrderNumber ;
    _maBN = maBN;
    _hoten = hoten;
    _ngaySinh = ngaySinh;
    _tENDT = tENDT;
    _tuoi = tuoi;
    _diachi = diachi;
    _dienthoai = dienthoai;
    _gt = gt;
    _nhomMau = nhomMau ;
    _tIENSUBenh = tIENSUBenh;
    _tienSuThuoc = tienSuThuoc;
    _dTCQ = dTCQ;
    _dTDD = dTDD;
    _mail = mail ;
    _diachiCT = diachiCT;
    _ghichu = ghichu;
    _soThe = soThe;
    _baotin = baotin;
    _gIATRIDN = gIATRIDN;
    _tENBV = tENBV;
    _mABHXH = mABHXH;
    _tENTINH = tENTINH;
    _tENQH = tENQH;
    _tENNN = tENNN;
    _tENQG = tENQG;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBN;
			public String MaBN 
			{
				get
				{
					return _maBN;
				}
			}
            
           
			public Criteria(String maBN)
			{
				_maBN = maBN;
                
                
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBN.Equals(c._maBN)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBN.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaKB
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
                }
            }
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private String _masokham;
            public String masokham
            {
                get
                {
                    return _masokham;
                }
            }
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _loaikq;
            public Byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            private int _stt;
            public int  stt
            {
                get
                {
                    return _stt;
                }
            }
            public CriteriaKB(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn, byte loaikq, string makhoa)
            {
                _maBN = maBN;
                _ngaydk = ngaydk;
                _loai = loai;
                _masokham = masokham;
                _stt = stt;
                _loaikqcn = loaikqcn;
                _loaikq = loaikq;
                _makhoa = makhoa;
             
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaKB)
                {
                    CriteriaKB c = (CriteriaKB)obj;
                    if (!_maBN.Equals(c._maBN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaKB", _maBN.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBN;
            public String maBN
            {
                get
                {
                    return _maBN;
                }
            }

            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }

            public OtherCriteria(String Mamay, String Nguoisd, String maBN, byte loai)
            {
                _maBN = maBN;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }

		#endregion
		
		#region Authorization

		public static bool CanGetObject()
		{
			return true;
		}
		
		public static bool CanDeleteObject()
		{
			return true;
		}

		public static bool CanAddObject()
		{
			return true;
		}

		public static bool CanEditObject()
		{
			return true;
		}
		
		#endregion

		#region Data Access

		/// <summary>
		/// Retrieve an existing <see cref="ThongtinBNNoiTru" /> Object based on data in the database.
		/// </summary>
        /// 
        
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetThongtinBNNoiTru(String _maBN);
			// public override IDataReader GetThongtinBNNoiTru(String _maBN)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBNNoiTru(crit.MaBN )))
			{
				if (dr.Read()){
					Fetch(dr);
                    //if (dr.NextResult())
                    //{
                      //  _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN,crit.ngaydk,"",crit.loai,crit.loaikqcn,0,""   );
                      ////  _KhamBenh = KhamBenh.GetKhamBenh(dr.GetString("masokham")   "", crit.loai, crit.loaikqcn);
                      //  if (_KhamBenh.MaSoKham == "")
                      //  {
                      //      _KhamBenh = KhamBenh.NewKhamBenh();
                      //      _KhamBenh.MaBV = _maBV;
                      //      _KhamBenh.MaDT = _maDT;
                      //      _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                      //      _KhamBenh.mabhxh = _mabhxh;
                      //      _KhamBenh.Sothe = _sothe;
                      //      _KhamBenh.tenbv = _tenbv;
                      //      _KhamBenh.GiatriDN = _giaTriDN.ToString();
                      //      _KhamBenh.GiaTriTN = _giaTriTN.ToString();
                            
                      //  }
                       
                    //}
					MarkOld();
					ValidationRules.CheckRules();
                   // dr.Close();
				}
			}
		}
        protected void DataPortal_Fetch(CriteriaKB crit)
        {
            // public abstract IDataReader GetThongtinBNNoiTru(String _maBN);
            // public override IDataReader GetThongtinBNNoiTru(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBNNoiTru(crit.MaBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    //if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                    //    _KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                    //else
                    //_KhamBenh = KhamBenh.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.stt.ToString(), crit.loai, crit.loaikqcn, crit.loaikq,"");

                    //    if (_KhamBenh.MaSoKham == "")
                    //    {
                    //        _KhamBenh.MaBV = _maBV;
                    //        _KhamBenh.MaBN = _maBN;
                    //        _KhamBenh.MaDT = _maDT;
                    //        _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                    //        _KhamBenh.mabhxh = _mabhxh;
                    //        _KhamBenh.Sothe = _sothe;
                    //        _KhamBenh.tenbv = _tenbv;
                    //        _KhamBenh.GiatriDN = _giaTriDN.ToString ();
                    //        _KhamBenh.GiaTriTN = _giaTriTN.ToString(); 
                    //        _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                    //    }
                    
                    MarkOld();
                    ValidationRules.CheckRules();
                   // dr.Close();
                }
            }
        }
        protected void DataPortal_Fetch(OtherCriteria crit)
        {
            // public abstract IDataReader GetThongtinBNNoiTru(String _maBN);
            // public override IDataReader GetThongtinBNNoiTru(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBNNoiTru(crit.maBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    
                    MarkOld();
                    ValidationRules.CheckRules();
                }
               // dr.Close();
            }
        }
		/// <summary>
		/// Load a <see cref="ThongtinBNNoiTru" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetString("TENDT") != null) _tENDT = dr.GetString("TENDT");
            if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
            if (dr.GetString("Diachi") != null) _diachi = dr.GetString("Diachi");
            if (dr.GetString("Dienthoai") != null) _dienthoai = dr.GetString("Dienthoai");
            if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("NhomMau") != null) _nhomMau = dr.GetString("NhomMau");
            if (dr.GetString("TIENSUBenh") != null) _tIENSUBenh = dr.GetString("TIENSUBenh");
            if (dr.GetString("TienSuThuoc") != null) _tienSuThuoc = dr.GetString("TienSuThuoc");
            if (dr.GetString("DTCQ") != null) _dTCQ = dr.GetString("DTCQ");
            if (dr.GetString("DTDD") != null) _dTDD = dr.GetString("DTDD");
            if (dr.GetString("Mail") != null) _mail = dr.GetString("Mail");
            if (dr.GetString("DiachiCT") != null) _diachiCT = dr.GetString("DiachiCT");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("SoThe") != null) _soThe = dr.GetString("SoThe");
            if (dr.GetString("Baotin") != null) _baotin = dr.GetString("Baotin");
            if (dr.GetSmartDate("GIATRIDN", true) != null) _gIATRIDN = dr.GetSmartDate("GIATRIDN", true);
            if (dr.GetString("TENBV") != null) _tENBV = dr.GetString("TENBV");
            if (dr.GetString("MABHXH") != null) _mABHXH = dr.GetString("MABHXH");
            if (dr.GetString("TENTINH") != null) _tENTINH = dr.GetString("TENTINH");
            if (dr.GetString("TENQH") != null) _tENQH = dr.GetString("TENQH");
            if (dr.GetString("TENNN") != null) _tENNN = dr.GetString("TENNN");
            if (dr.GetString("TENQG") != null) _tENQG = dr.GetString("TENQG");
        }
		
		/// <summary>
		/// Insert the new <see cref="ThongtinBNNoiTru" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            ValidationRules.CheckRules();
            //_maDT = "00001";
            //_maQG = "00084";
            //_ngayKham.Date = DateTime.Now; 
            //MarkOld();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongtinBNNoiTru
			// Copy & paste ham duoi day vao file DataProvider.cs
            //_maBN = DataProvider.Instance().InsertThongtinBNNoiTru(_hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu  ,_maMay ,_nguoiSD,_madantoc ,_hotenbome,_giaTriTN  );
			// public abstract String InsertThongtinBNNoiTru(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap);
			// public override String InsertThongtinBNNoiTru(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongtinBNNoiTru_CREATE",_hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _nguoiLap);
			// }
            //_KhamBenh.MaBN = _maBN; 
            //  KhamBenh  tmp = _KhamBenh.Clone() ;
            //  if (tmp.IsDirty)
            //  {
            //      tmp.ApplyEdit();
            //      _KhamBenh = tmp.Save();
            //  };
           
		}
		
		/// <summary>
		/// Update all changes made on <see cref="ThongtinBNNoiTru" /> Object to underlying database.
		/// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBNNoiTru
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateThongtinBNNoiTru(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _huy,_nguoiSD   , _madantoc, _hotenbome, _giaTriTN);
        //        // public abstract void UpdateThongtinBNNoiTru(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        //        // public override void UpdateThongtinBNNoiTru(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongtinBNNoiTru_UPDATE", _maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _huy, _nguoiSD);
        //        // }	
        //        _KhamBenh.MaBN = _maBN;
        //        KhamBenh tmp = _KhamBenh.Clone();
        //       tmp.ApplyEdit();
        //          _KhamBenh= tmp.Save();
        //    }
        //}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBN,0));
        //}

        ///// <summary>
        ///// Delete the <see cref="ThongtinBNNoiTru" />.
        ///// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBNNoiTru
        //    DataProvider.Instance().DeleteThongtinBNNoiTru(crit.MaMay, crit.NguoiSD, crit.maBN);
        //    // public abstract void DeleteThongtinBNNoiTru(String _maBN);
        //    // public override void DeleteThongtinBNNoiTru(String _maBN);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongtinBNNoiTru_DELETED", _maBN);
        //    // }
        //}

		#endregion
	}

}
