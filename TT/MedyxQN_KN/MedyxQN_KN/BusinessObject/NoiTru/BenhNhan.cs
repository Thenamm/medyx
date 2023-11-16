// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhNhan
// Kieu doi tuong  :	BenhNhan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/9/2009 3:25:08 PM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhNhan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhNhan : BusinessBase<BenhNhan>
	{
		#region Business Methods
		
		#region State Fields
        private SmartDate _giaTriTN = new SmartDate(true);
		private String _maBN = String.Empty;
		private String _hoten = String.Empty;
		private String _sothe = String.Empty;
		private String _maBV = String.Empty;
		private SmartDate _giaTriDN = new SmartDate(true);
		private String _diaChi = String.Empty;
		private String _dienThoai = String.Empty;
		private String _RHD = String.Empty;
		private String _MaBAGD = String.Empty;
		private String _mail = String.Empty;
		private Byte _tuoi = 0;
		private SmartDate _ngaySinh = new SmartDate(true);
        private SmartDate _NgaySinhD = new SmartDate(true);
		private Boolean _gt = false;
        private Boolean _gtNu = false;
		private String _baoTin = String.Empty;
		private String _maQG = String.Empty;
		private String _maTinh = String.Empty;
		private String _maHuyen = String.Empty;
        private String _maPXa = String.Empty;
		
		private String _maNN = String.Empty;
		private String _tienSu = String.Empty;
		private String _tienSuThuoc = String.Empty;
		private String _tienSuGiaDinh = String.Empty;
		private String _nhomMau = String.Empty;

		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Boolean _huy = false;
		private String _maDT = String.Empty;
		private String _hoTenBoMe = String.Empty;
		private String _maDanToc = String.Empty;
        private String _tenBV = String.Empty;
        private String _maBHXH = String.Empty;
        private String _tentinh = String.Empty;
        private String _tenQH = String.Empty;
        private String _tenPXa = String.Empty;
        private String _tenNN = String.Empty;
        private String _tenQG = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _MaQuanHeQD = String.Empty;
        private String _MaQuanHam = String.Empty;
        private String _MaDonVi = String.Empty;
        private String _SoCMT = String.Empty;
        private string _noiLamViec = String.Empty;
        private int _OrderNumber;
        private String _ngayDu5Nam = String.Empty;
        private String _maKV = String.Empty;
        private String _ngayMienCCT = String.Empty;
		//private String _Lansinh = String.Empty;
		//private String _Tinhtrangcon = String.Empty;
		//private String _Nguoidode = String.Empty;
		//private String _MaBHXHCha = String.Empty;
		//private String _hotencha = String.Empty;
		#endregion

		#region Business Properties and Methods
		public string MaKV
        {
            get
            {
                CanReadProperty(true);
                return _maKV;
            }
            set
            {
                CanReadProperty("MaKV", true);
                if (!_maKV.Equals(value))
                {
                    _maKV = value;
                    PropertyHasChanged("MaKV");
                }
            }
        }
        public string NgayMienCCT
        {
            get
            {
                CanReadProperty(true);
                return _ngayMienCCT;
            }
            set
            {
                CanReadProperty("NgayMienCCT", true);
                if (!_ngayMienCCT.Equals(value))
                {
                    _ngayMienCCT = value;
                    PropertyHasChanged("NgayMienCCT");
                }
            }
        }
        public String ngayDu5Nam
        {
            get
            {
                CanReadProperty("ngayDu5Nam", true);
                return _ngayDu5Nam;
            }
            set
            {
                CanWriteProperty("ngayDu5Nam", true);
                if (_ngayDu5Nam != value)
                {
                    _ngayDu5Nam = value;
                    PropertyHasChanged("ngayDu5Nam");
                }
            }
        }
        public string NoiLamViec
        {
            get
            {
                CanReadProperty(true);
                return _noiLamViec;
            }
            set
            {
                CanReadProperty("NoiLamViec", true);
                if (!_noiLamViec.Equals(value))
                {
                    _noiLamViec = value;
                    PropertyHasChanged("NoiLamViec");
                }
            }
        }
        public String MaQuanHeQD
        {
            get
            {
                CanReadProperty("MaQuanHeQD", true);
                return _MaQuanHeQD;
            }
            set
            {
                CanWriteProperty("MaQuanHeQD", true);
                if (_MaQuanHeQD != value)
                {
                    _MaQuanHeQD = value;
                    PropertyHasChanged("MaQuanHeQD");
                }
            }
        }
        public String MaQuanHam
        {
            get
            {
                CanReadProperty("MaQuanHam", true);
                return _MaQuanHam;
            }
            set
            {
                CanWriteProperty("MaQuanHam", true);
                if (_MaQuanHam != value)
                {
                    _MaQuanHam = value;
                    PropertyHasChanged("MaQuanHam");
                }
            }
        }
        public String MaDonVi
        {
            get
            {
                CanReadProperty("MaDonVi", true);
                return _MaDonVi;
            }
            set
            {
                CanWriteProperty("MaDonVi", true);
                if (_MaDonVi != value)
                {
                    _MaDonVi = value;
                    PropertyHasChanged("MaDonVi");
                }
            }
        }
        public String SoCMT
        {
            get
            {
                CanReadProperty("SoCMT", true);
                return _SoCMT;
            }
            set
            {
                CanWriteProperty("SoCMT", true);
                if (_SoCMT != value)
                {
                    _SoCMT = value;
                    PropertyHasChanged("SoCMT");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
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
        //public String Hotencha
        //{
        //    get
        //    {
        //        CanReadProperty("Hotencha", true);
        //        return _hotencha;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Hotencha", true);
        //        if (_hotencha != value)
        //        {
        //            _hotencha = value;
        //            PropertyHasChanged("Hotencha");
        //        }
        //    }
        //}

        //public String MaBHXHCha
        //{
        //    get
        //    {
        //        CanReadProperty("MaBHXHCha", true);
        //        return _MaBHXHCha;
        //    }
        //    set
        //    {
        //        CanWriteProperty("MaBHXHCha", true);
        //        if (_MaBHXHCha != value)
        //        {
        //            _MaBHXHCha = value;
        //            PropertyHasChanged("MaBHXHCha");
        //        }
        //    }
        //}


        //public String Lansinh
        //{
        //    get
        //    {
        //        CanReadProperty("Lansinh", true);
        //        return _Lansinh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Lansinh", true);
        //        if (_Lansinh != value)
        //        {
        //            _Lansinh = value;
        //            PropertyHasChanged("Lansinh");
        //        }
        //    }
        //}
        //public String Tinhtrangcon
        //{
        //    get
        //    {
        //        CanReadProperty("Tinhtrangcon", true);
        //        return _Tinhtrangcon;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Tinhtrangcon", true);
        //        if (_Tinhtrangcon != value)
        //        {
        //            _Tinhtrangcon = value;
        //            PropertyHasChanged("Tinhtrangcon");
        //        }
        //    }
        //}

        //public String Nguoidode
        //{
        //    get
        //    {
        //        CanReadProperty("Nguoidode", true);
        //        return _Nguoidode;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Nguoidode", true);
        //        if (_Nguoidode != value)
        //        {
        //            _Nguoidode = value;
        //            PropertyHasChanged("Nguoidode");
        //        }
        //    }
        //}
        public String Sothe
		{
			get 
			{
				CanReadProperty("Sothe", true);
				return _sothe;
			}
			set 
			{
				CanWriteProperty("Sothe", true);
				if (_sothe != value) 
				{
					_sothe = value;
					PropertyHasChanged("Sothe");
				}
			}
		}
		
		public String MaBV
		{
			get 
			{
				CanReadProperty("MaBV", true);
				return _maBV;
			}
			set 
			{
				CanWriteProperty("MaBV", true);
				if (_maBV != value) 
				{
					_maBV = value;
					PropertyHasChanged("MaBV");
				}
			}
		}
		
		public string GiaTriDN
		{
			get 
			{
				CanReadProperty("GiaTriDN", true);
				return _giaTriDN.Text;
			}
			set 
			{
				CanWriteProperty("GiaTriDN", true);
				if (_giaTriDN.Text != value) 
				{
					_giaTriDN.Text = value;
					PropertyHasChanged("GiaTriDN");
				}
			}
		}
		
		public String DiaChi
		{
			get 
			{
				CanReadProperty("DiaChi", true);
				return _diaChi;
			}
			set 
			{
				CanWriteProperty("DiaChi", true);
				if (_diaChi != value) 
				{
					_diaChi = value;
					PropertyHasChanged("DiaChi");
				}
			}
		}
		
		public String DienThoai
		{
			get 
			{
				CanReadProperty("DienThoai", true);
				return _dienThoai;
			}
			set 
			{
				CanWriteProperty("DienThoai", true);
				if (_dienThoai != value) 
				{
					_dienThoai = value;
					PropertyHasChanged("DienThoai");
				}
			}
		}
		
		public String RHD
		{
			get 
			{
				CanReadProperty("RHD", true);
				return _RHD;
			}
			set 
			{
				CanWriteProperty("RHD", true);
				if (_RHD != value) 
				{
					_RHD = value;
					PropertyHasChanged("RHD");
				}
			}
		}
		
		public String MaBAGD
		{
			get 
			{
				CanReadProperty("MaBAGD", true);
				return _MaBAGD;
			}
			set 
			{
				CanWriteProperty("MaBAGD", true);
				if (_MaBAGD != value) 
				{
					_MaBAGD = value;
					PropertyHasChanged("MaBAGD");
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

        public byte Tuoi
        {
            get
            {
                byte _Age = 0;
                //CanReadProperty("Tuoi", true);
                if (_ngaySinh.Date.Year != 1)
                    _Age = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                return _Age;
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

        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                //_ngaySinh.FormatString = "dd/MM/yyyy HH:mm:ss";
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
        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinhD", true);
                _NgaySinhD.FormatString = "dd/MM/yyyy HH:mm";
                _NgaySinhD = _ngaySinh;
                return _NgaySinhD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayDK", true);
            //    if (_ngayDK.Text != value)
            //    {
            //        _ngayDK.Text = value;
            //        PropertyHasChanged("NgayDK");
            //    }
            //}
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

        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }

        }

		public String BaoTin
		{
			get 
			{
				CanReadProperty("BaoTin", true);
				return _baoTin;
			}
			set 
			{
				CanWriteProperty("BaoTin", true);
				if (_baoTin != value) 
				{
					_baoTin = value;
					PropertyHasChanged("BaoTin");
				}
			}
		}
		
		public String MaQG
		{
			get 
			{
				CanReadProperty("MaQG", true);
				return _maQG;
			}
			set 
			{
				CanWriteProperty("MaQG", true);
				if (_maQG != value) 
				{
					_maQG = value;
					PropertyHasChanged("MaQG");
				}
			}
		}
		
		public String MaTinh
		{
			get 
			{
				CanReadProperty("MaTinh", true);
				return _maTinh;
			}
			set 
			{
				CanWriteProperty("MaTinh", true);
				if (_maTinh != value) 
				{
					_maTinh = value;
					PropertyHasChanged("MaTinh");
				}
			}
		}
        public String MaPXa
        {
            get
            {
                CanReadProperty("MaPXa", true);
                return _maPXa;
            }
            set
            {
                CanWriteProperty("MaPXa", true);
                if (_maPXa != value)
                {
                    _maPXa = value;
                    PropertyHasChanged("MaPXa");
                }
            }
        }
	
		public String MaHuyen
		{
			get 
			{
				CanReadProperty("MaHuyen", true);
				return _maHuyen;
			}
			set 
			{
				CanWriteProperty("MaHuyen", true);
				if (_maHuyen != value) 
				{
					_maHuyen = value;
					PropertyHasChanged("MaHuyen");
				}
			}
		}
		
		public String MaNN
		{
			get 
			{
				CanReadProperty("MaNN", true);
				return _maNN;
			}
			set 
			{
				CanWriteProperty("MaNN", true);
				if (_maNN != value) 
				{
					_maNN = value;
					PropertyHasChanged("MaNN");
				}
			}
		}
		
		public String TienSu
		{
			get 
			{
				CanReadProperty("TienSu", true);
				return _tienSu;
			}
			set 
			{
				CanWriteProperty("TienSu", true);
				if (_tienSu != value) 
				{
					_tienSu = value;
					PropertyHasChanged("TienSu");
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
		
		public String TienSuGiaDinh
		{
			get 
			{
				CanReadProperty("TienSuGiaDinh", true);
				return _tienSuGiaDinh;
			}
			set 
			{
				CanWriteProperty("TienSuGiaDinh", true);
				if (_tienSuGiaDinh != value) 
				{
					_tienSuGiaDinh = value;
					PropertyHasChanged("TienSuGiaDinh");
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
		
		public String MaMay
		{
			get 
			{
				CanReadProperty("MaMay", true);
				return _maMay;
			}
			set 
			{
				CanWriteProperty("MaMay", true);
				if (_maMay != value) 
				{
					_maMay = value;
					PropertyHasChanged("MaMay");
				}
			}
		}
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayLap.Text;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text != value) 
				{
					_ngayLap.Text = value;
					PropertyHasChanged("NgayLap");
				}
			}
		}
		
		public String NguoiLap
		{
			get 
			{
				CanReadProperty("NguoiLap", true);
				return _nguoiLap;
			}
			set 
			{
				CanWriteProperty("NguoiLap", true);
				if (_nguoiLap != value) 
				{
					_nguoiLap = value;
					PropertyHasChanged("NguoiLap");
				}
			}
		}
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
				}
			}
		}
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngaySD.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_ngaySD.Text != value) 
				{
					_ngaySD.Text = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}
		
		public String NguoiSD
		{
			get 
			{
				CanReadProperty("NguoiSD", true);
				return _nguoiSD;
			}
			set 
			{
				CanWriteProperty("NguoiSD", true);
				if (_nguoiSD != value) 
				{
					_nguoiSD = value;
					PropertyHasChanged("NguoiSD");
				}
			}
		}
		
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        _ngaySD1.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public Boolean Huy
		{
			get 
			{
				CanReadProperty("Huy", true);
				return _huy;
			}
			set 
			{
				CanWriteProperty("Huy", true);
				if (_huy != value) 
				{
					_huy = value;
					PropertyHasChanged("Huy");
				}
			}
		}
		
		public String MaDT
		{
			get 
			{
				CanReadProperty("MaDT", true);
				return _maDT;
			}
			set 
			{
				CanWriteProperty("MaDT", true);
				if (_maDT != value) 
				{
					_maDT = value;
					PropertyHasChanged("MaDT");
				}
			}
		}
		
		public String HoTenBoMe
		{
			get 
			{
				CanReadProperty("HoTenBoMe", true);
				return _hoTenBoMe;
			}
			set 
			{
				CanWriteProperty("HoTenBoMe", true);
				if (_hoTenBoMe != value) 
				{
					_hoTenBoMe = value;
					PropertyHasChanged("HoTenBoMe");
				}
			}
		}
		
		public String MaDanToc
		{
			get 
			{
				CanReadProperty("MaDanToc", true);
				return _maDanToc;
			}
			set 
			{
				CanWriteProperty("MaDanToc", true);
				if (_maDanToc != value) 
				{
					_maDanToc = value;
					PropertyHasChanged("MaDanToc");
				}
			}
		}

        public String TenBV
        {
            get
            {
                CanReadProperty("TenBV", true);
                return _tenBV;
            }
            set
            {
                CanWriteProperty("TenBV", true);
                if (_tenBV != value)
                {
                    _tenBV = value;
                    PropertyHasChanged("TenBV");
                }
            }
        }

        public String MaBHXH
        {
            get
            {
                CanReadProperty("MaBHXH", true);
                return _maBHXH;
            }
            set
            {
                CanWriteProperty("MaBHXH", true);
                if (_maBHXH != value)
                {
                    _maBHXH = value;
                    PropertyHasChanged("MaBHXH");
                }
            }
        }

        public String TenTinh
        {
            get
            {
                CanReadProperty("TenTinh", true);
                return _tentinh;
            }
            set
            {
                CanWriteProperty("TenTinh", true);
                if (_tentinh != value)
                {
                    _tentinh = value;
                    PropertyHasChanged("TenTinh");
                }
            }
        }

        public String TenQH
        {
            get
            {
                CanReadProperty("TenQH", true);
                return _tenQH;
            }
            set
            {
                CanWriteProperty("TenQH", true);
                if (_tenQH != value)
                {
                    _tenQH = value;
                    PropertyHasChanged("TenQH");
                }
            }
        }
        public String TenPXa
        {
            get
            {
                CanReadProperty("TenPXa", true);
                return _tenPXa;
            }
            set
            {
                CanWriteProperty("TenPXa", true);
                if (_tenPXa != value)
                {
                    _tenPXa = value;
                    PropertyHasChanged("TenPXa");
                }
            }
        }
        public String TenNN
        {
            get
            {
                CanReadProperty("TenNN", true);
                return _tenNN;
            }
            set
            {
                CanWriteProperty("TenNN", true);
                if (_tenNN != value)
                {
                    _tenNN = value;
                    PropertyHasChanged("TenNN");
                }
            }
        }

        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maBN;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhNhan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhNhan NewBenhNhan()
        {

            return DataPortal.Create<BenhNhan>();
        }
		public static BenhNhan GetBenhNhan(String maBN)
		{
			return DataPortal.Fetch<BenhNhan>(new Criteria(maBN));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhNhan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhNhan(String maBN, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhNhan()
		{	
			// Prevent direct creation
		}

        internal BenhNhan(
                     int OrderNumber,
                     String maBN ,
		             String hoten ,
		             String sothe ,
		             String maBV ,
		             SmartDate giaTriDN ,
		             String diaChi ,
		             String dienThoai ,
		             String RHD ,
		             String MaBAGD ,
		             String mail ,
		             Byte tuoi ,
		             SmartDate ngaySinh ,
		             Boolean gt ,
		             String baoTin ,
		             String maQG ,
		             String maTinh ,
		             String maHuyen,
                     String MaPXa,
		             String maNN ,
		             String tienSu ,
		             String tienSuThuoc ,
		             String tienSuGiaDinh ,
		             String nhomMau ,
		             String ghichu ,
		             String maMay ,
		             SmartDate ngayLap ,
		             String nguoiLap ,
		             SmartDate ngayHuy,
		             String nguoiHuy ,
		             SmartDate ngaySD ,
		             String nguoiSD ,
		             SmartDate ngaySD1 ,
		             String nguoiSD1 ,
		             Boolean huy ,
		             String maDT ,
		             String hoTenBoMe ,
		             String maDanToc ,
                     String tenBV ,
                     String maBHXH ,
                     String tentinh ,
                     String tenQH ,
                     String tenPXa,
                     String tenNN ,
                     String tenQG ,
                     String tenNguoiLap ,
                     String tenNguoiSD ,
                     String tenNguoiHuy,
                             SmartDate giaTriTN, string madonvi
 , string maquanham
 , string maquanheqd
 , string socmt
                  //   SmartDate ngaySinhD
                     
                    )
        {
                      _maBN = maBN ;
		              _hoten = hoten ;
		              _sothe = sothe ;
		              _maBV = maBV ;
                      _MaDonVi = madonvi;
                      _MaQuanHam = maquanham;
                      _MaQuanHeQD = maquanheqd;
                      _SoCMT = socmt;
		              _giaTriDN = giaTriDN ;
		              _diaChi = diaChi ;
		              _dienThoai = dienThoai ;
		              _RHD = RHD ;
		              _MaBAGD = MaBAGD ;
		              _mail = mail ;
		              _tuoi = tuoi ;
		              _ngaySinh = ngaySinh ;
		              _gt = gt ;
		              _baoTin = baoTin ;
		              _maQG = maQG ;
		              _maTinh = maTinh ;
		              _maHuyen = maHuyen ;
                      _maPXa = MaPXa;
		              _maNN = maNN ;
		              _tienSu = tienSu ;
		              _tienSuThuoc = tienSuThuoc ;
		              _tienSuGiaDinh = tienSuGiaDinh ;
		              _nhomMau = nhomMau ;
		              _ghichu = ghichu ;
		              _maMay = maMay ;
		              _ngayLap = ngayLap ;
		              _nguoiLap = nguoiLap ;
		              _ngayHuy = ngayHuy ;
		              _nguoiHuy = nguoiHuy ;
		              _ngaySD = ngaySD ;
		              _nguoiSD = nguoiSD ;
		              _ngaySD1 = ngaySD1 ;
		              _nguoiSD1 = nguoiSD1 ;
		              _huy = huy ;
		              _maDT = maDT ;
		              _hoTenBoMe = hoTenBoMe ;
		              _maDanToc = maDanToc ;
                      _tenBV = tenBV ;
                      _maBHXH = maBHXH ;
                      _tentinh = tentinh ;
                      _tenQH = tenQH ;
                      _tenPXa = tenPXa;
                      _tenNN = tenNN ;
                      _tenQG = tenQG ;
                      _tenNguoiLap = tenNguoiLap ;
                      _tenNguoiSD = tenNguoiSD ;
                      _tenNguoiHuy = tenNguoiHuy ;
                      _OrderNumber = OrderNumber ;
                      _giaTriTN = giaTriTN;
                    //  _ngaySinhD = ngaySinhD;
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

            public OtherCriteria(String Mamay, String Nguoisd, String maBN)
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
		/// Retrieve an existing <see cref="BenhNhan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhNhan(String _maBN);
			// public override IDataReader GetBenhNhan(String _maBN)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_GET", _maBN));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhNhan(crit.MaBN)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhNhan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties

            //if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            //if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            //if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
			if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
			if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
			if (dr.GetSmartDate("GiaTriDN", true) != null) _giaTriDN = dr.GetSmartDate("GiaTriDN", true);
			if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
			if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
			if (dr.GetString("RHD") != null) _RHD = dr.GetString("RHD");
			if (dr.GetString("MaBAGD") != null) _MaBAGD = dr.GetString("MaBAGD");
			if (dr.GetString("Mail") != null) _mail = dr.GetString("Mail");
            if (dr.GetString("SoCMT") != null) _SoCMT = dr.GetString("SoCMT");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");
            if (dr.GetString("MaQuanHam") != null) _MaQuanHam = dr.GetString("MaQuanHam");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");

            if (dr.GetString("NoiLamViec") != null) _noiLamViec = dr.GetString("NoiLamViec");
        
			if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
			if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetSmartDate("NgaySinh", true) != null) _NgaySinhD = dr.GetSmartDate("NgaySinh", true);
			if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
			if (dr.GetString("BaoTin") != null) _baoTin = dr.GetString("BaoTin");
			if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
			if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
			if (dr.GetString("MaHuyen") != null) _maHuyen = dr.GetString("MaHuyen");
            if (dr.GetString("MaPXa") != null) _maPXa = dr.GetString("MaPXa");
            if (dr.GetString("MaNN") != null) _maNN = dr.GetString("MaNN");
			if (dr.GetString("TienSu") != null) _tienSu = dr.GetString("TienSu");
			if (dr.GetString("TienSuThuoc") != null) _tienSuThuoc = dr.GetString("TienSuThuoc");
			if (dr.GetString("TienSuGiaDinh") != null) _tienSuGiaDinh = dr.GetString("TienSuGiaDinh");
			if (dr.GetString("NhomMau") != null) _nhomMau = dr.GetString("NhomMau");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
			if (dr.GetString("HoTenBoMe") != null) _hoTenBoMe = dr.GetString("HoTenBoMe");
			if (dr.GetString("MaDanToc") != null) _maDanToc = dr.GetString("MaDanToc");
            if (dr.GetString("TenBV") != null) _tenBV = dr.GetString("TenBV");
            if (dr.GetString("mabhxh") != null) _maBHXH = dr.GetString("mabhxh");
            if (dr.GetString("TenTinh") != null) _tentinh = dr.GetString("TenTinh");
            if (dr.GetString("TenQH") != null) _tenQH = dr.GetString("TenQH");
            if (dr.GetString("TenPXa") != null) _tenPXa = dr.GetString("TenPXa");
            if (dr.GetString("TenNN") != null) _tenNN = dr.GetString("TenNN");
            if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");
            dr.GetString("tenNguoiLap") ;
            dr.GetString("tenNguoiSD") ;
            dr.GetString("tenNguoiHuy");
            if (dr.GetSmartDate("GiaTriTN", true) != null) _giaTriTN = dr.GetSmartDate("GiaTriTN", true);
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhNhan" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            ValidationRules.CheckRules();
            //MarkOld();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhNhan
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBN = DataProvider.Instance().InsertBenhNhan(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD, _hoTenBoMe, _maDanToc, _giaTriTN, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);
			// public abstract String InsertBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, String _hoTenBoMe, String _maDanToc);
            // public override String InsertBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, String _hoTenBoMe, String _maDanToc)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_CREATE",_maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _nguoiSD , _hoTenBoMe, _maDanToc ));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhNhan" /> Object to underlying database.
		/// </summary>
        /// 

		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan
			if (IsDirty){
                DataProvider.Instance().UpdateBenhNhan(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maPXa, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay, _huy, _nguoiSD, _hoTenBoMe, _maDanToc, _giaTriTN, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT, _noiLamViec);
                // public abstract void UpdateBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy,  String _nguoiSD, String _maDT, String _hoTenBoMe, String _maDanToc);
                // public override void UpdateBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _RHD, String _MaBAGD, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy,  String _nguoiSD,String _maDT, String _hoTenBoMe, String _maDanToc)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_UPDATE", _maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _RHD, _MaBAGD, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay,_huy, _nguoiSD ,  _hoTenBoMe, _maDanToc);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBN));
		}

		/// <summary>
		/// Delete the <see cref="BenhNhan" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan
            DataProvider.Instance().DeleteBenhNhan(crit.MaMay, crit.NguoiSD, crit.maBN);
			// public abstract void DeleteBenhNhan(String _maBN);
			// public override void DeleteBenhNhan(String _maBN)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHNHAN_DELETED", _maBN);
			// }
		}

		#endregion
	}

}
