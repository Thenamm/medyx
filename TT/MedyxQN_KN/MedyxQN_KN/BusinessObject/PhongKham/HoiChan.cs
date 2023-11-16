// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HoiChan
// Kieu doi tuong  :	HoiChan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/3/2009 4:05:17 PM
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
////


namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HoiChan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HoiChan : BusinessBase<HoiChan>
	{
		#region Business Methods
		
		#region State Fields
        private String _maKhoaVV = String.Empty;
        private SmartDate _ngayGioVV = new SmartDate(true);
		private String _maHC = String.Empty;
		private String _maBA = String.Empty;
		private String _maBN = String.Empty;
		private String _hoten = String.Empty;
		private Byte _tuoi = 0;
		private Boolean _gt = false;
        private Boolean _gtNu = false;
		private SmartDate _ngaySinh = new SmartDate(true);
        private SmartDate _ngaySinhD = new SmartDate(true);
		private String _maKhoa = String.Empty;
        //private String _maKhoa = HTC.Business.CategoryList.DMKhoaListcb.DefaultPosition();
		private String _maHTHoiChan = String.Empty;
        //private String _maHTHoiChan = HTC.Business.CategoryList.DMHTHoiChanListcb.DefaultPosition();
		private String _maLDHoiChan = String.Empty;
        //private String _maLDHoiChan = HTC.Business.CategoryList.DMLDHoiChanListcb.DefaultPosition();
		private SmartDate _ngayHC = new SmartDate(DateTime.Today);
        private SmartDate _ngayHCD = new SmartDate(DateTime.Today);
		private String _diaDiem = String.Empty;
		private String _yeuCauHC = String.Empty;
		private String _tinhtrang = String.Empty;
		private String _tomTat = String.Empty;
		private String _maBenhID = String.Empty;
        private String _maBenhIDKhoa = String.Empty;
		private String _nguyenNhan = String.Empty;
		private String _phuongPhap = String.Empty;
		private String _chamSoc = String.Empty;
		private String _ketLuan = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private String _nguoihuy = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
        private String _tenLDHoiChan = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenHTHoiChan = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _maICD = String.Empty;
        private String _tenBenh = String.Empty;
        private String _maICDKhoa = String.Empty;
        private String _tenBenhKhoa = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
        private String _tenDT = String.Empty;
        private String _maDT = String.Empty;
        private int _OrderNumber;
        private String _tenbacsiyeucau = String.Empty;
        private String _MaBSYC = String.Empty;
        
		#endregion
		
		#region Business Properties and Methods
        public String MaKhoaVV
        {
            get
            {
                CanReadProperty("MaKhoaVV", true);
                return _maKhoaVV;
            }
            set
            {
                CanWriteProperty("MaKhoaVV", true);
                if (_maKhoaVV != value)
                {
                    _maKhoaVV = value;
                    PropertyHasChanged("MaKhoaVV");
                }
            }
        }
		
        public string NgayGioVV
        {
            get
            {
                CanReadProperty("NgayGioVV", true);
              //  _ngayGioVV.FormatString = "MM/dd/yyyy HH:mm:ss";
                return _ngayGioVV.Text;
            }
            set
            {
                CanWriteProperty("NgayGioVV", true);
                if (_ngayGioVV.Text != value)
                {
                    _ngayGioVV.Text = value;
                    PropertyHasChanged("NgayGioVV");
                }
            }
        }
		public String MaHC
		{
			get 
			{
				CanReadProperty("MaHC", true);
				return _maHC;
			}
			set 
			{
				CanWriteProperty("MaHC", true);
				if (_maHC != value) 
				{
					_maHC = value;
					PropertyHasChanged("MaHC");
				}
			}
		}

        public String MaBSYC
        {
            get
            {
                CanReadProperty("MaBSYC", true);
                return _MaBSYC;
            }
            set
            {
                CanWriteProperty("MaBSYC", true);
                if (_MaBSYC != value)
                {
                    _MaBSYC = value;
                    PropertyHasChanged("MaBSYC");
                }
            }
        }
		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
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
		
		public Byte Tuoi
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
        public string GTD
        {
            get
            {
                CanReadProperty("GTD", true);
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }
            //set
            //{
            //    CanWriteProperty("GT", true);
            //    if (_gt != value)
            //    {
            //        _gt = value;
            //        PropertyHasChanged("GT");
            //    }
            //}
        }

        //public string NgaySinh
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySinh", true);
        //        _ngaySinh.FormatString = "dd/MM/yyyy HH:mm:ss";
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
        public String NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                //_ngayNhap.FormatString = "dd/MM/yyyy"; 
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public String NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinhD", true);
                _ngaySinhD = _ngaySinh;
                this._ngaySinhD.FormatString = "dd/MM/yyyy";
                return _ngaySinhD.Text;
            }
           
        }
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _maKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_maKhoa != value) 
				{
					_maKhoa = value;
					PropertyHasChanged("MaKhoa");
				}
			}
		}
		
		public String MaHTHoiChan
		{
			get 
			{
				CanReadProperty("MaHTHoiChan", true);
				return _maHTHoiChan;
			}
			set 
			{
				CanWriteProperty("MaHTHoiChan", true);
				if (_maHTHoiChan != value) 
				{
					_maHTHoiChan = value;
					PropertyHasChanged("MaHTHoiChan");
				}
			}
		}
		
		public String MaLDHoiChan
		{
			get 
			{
				CanReadProperty("MaLDHoiChan", true);
				return _maLDHoiChan;
			}
			set 
			{
				CanWriteProperty("MaLDHoiChan", true);
				if (_maLDHoiChan != value) 
				{
					_maLDHoiChan = value;
					PropertyHasChanged("MaLDHoiChan");
				}
			}
		}
		
		public string NgayHC
		{
			get 
			{
				CanReadProperty("NgayHC", true);
               _ngayHC.FormatString = "dd/MM/yyyy HH:mm";
				return _ngayHC.Text;
			}
			set 
			{
				CanWriteProperty("NgayHC", true);
				if (_ngayHC.Text != value) 
				{
					_ngayHC.Text = value;
					PropertyHasChanged("NgayHC");
				}
			}
		}
        public String NgayHCD
        {
            get
            {
                CanReadProperty("NgayHCD", true);
                _ngayHCD = _ngayHC;
                this._ngayHCD.FormatString = "dd/MM/yyyy";
                return _ngayHCD.Text;
            }
       
        }
		
		public String DiaDiem
		{
			get 
			{
				CanReadProperty("DiaDiem", true);
				return _diaDiem;
			}
			set 
			{
				CanWriteProperty("DiaDiem", true);
				if (_diaDiem != value) 
				{
					_diaDiem = value;
					PropertyHasChanged("DiaDiem");
				}
			}
		}
		
		public String YeuCauHC
		{
			get 
			{
				CanReadProperty("YeuCauHC", true);
				return _yeuCauHC;
			}
			set 
			{
				CanWriteProperty("YeuCauHC", true);
				if (_yeuCauHC != value) 
				{
					_yeuCauHC = value;
					PropertyHasChanged("YeuCauHC");
				}
			}
		}
		
		public String Tinhtrang
		{
			get 
			{
				CanReadProperty("Tinhtrang", true);
				return _tinhtrang;
			}
			set 
			{
				CanWriteProperty("Tinhtrang", true);
				if (_tinhtrang != value) 
				{
					_tinhtrang = value;
					PropertyHasChanged("Tinhtrang");
				}
			}
		}
		
		public String TomTat
		{
			get 
			{
				CanReadProperty("TomTat", true);
				return _tomTat;
			}
			set 
			{
				CanWriteProperty("TomTat", true);
				if (_tomTat != value) 
				{
					_tomTat = value;
					PropertyHasChanged("TomTat");
				}
			}
		}
		
		public String MaBenhID
		{
			get 
			{
				CanReadProperty("MaBenhID", true);
				return _maBenhID;
			}
			set 
			{
				CanWriteProperty("MaBenhID", true);
				if (_maBenhID != value) 
				{
					_maBenhID = value;
					PropertyHasChanged("MaBenhID");
				}
			}
		}
        public String MaBenhIDKhoa
        {
            get
            {
                CanReadProperty("MaBenhIDKhoa", true);
                return _maBenhIDKhoa;
            }
            set
            {
                CanWriteProperty("MaBenhIDKhoa", true);
                if (_maBenhIDKhoa != value)
                {
                    _maBenhIDKhoa = value;
                    PropertyHasChanged("MaBenhIDKhoa");
                }
            }
        }
		public String NguyenNhan
		{
			get 
			{
				CanReadProperty("NguyenNhan", true);
				return _nguyenNhan;
			}
			set 
			{
				CanWriteProperty("NguyenNhan", true);
				if (_nguyenNhan != value) 
				{
					_nguyenNhan = value;
					PropertyHasChanged("NguyenNhan");
				}
			}
		}
		
		public String PhuongPhap
		{
			get 
			{
				CanReadProperty("PhuongPhap", true);
				return _phuongPhap;
			}
			set 
			{
				CanWriteProperty("PhuongPhap", true);
				if (_phuongPhap != value) 
				{
					_phuongPhap = value;
					PropertyHasChanged("PhuongPhap");
				}
			}
		}
		
		public String ChamSoc
		{
			get 
			{
				CanReadProperty("ChamSoc", true);
				return _chamSoc;
			}
			set 
			{
				CanWriteProperty("ChamSoc", true);
				if (_chamSoc != value) 
				{
					_chamSoc = value;
					PropertyHasChanged("ChamSoc");
				}
			}
		}
		
		public String KetLuan
		{
			get 
			{
				CanReadProperty("KetLuan", true);
				return _ketLuan;
			}
			set 
			{
				CanWriteProperty("KetLuan", true);
				if (_ketLuan != value) 
				{
					_ketLuan = value;
					PropertyHasChanged("KetLuan");
				}
			}
		}
		
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
		
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _nguoihuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_nguoihuy != value) 
				{
					_nguoihuy = value;
					PropertyHasChanged("Nguoihuy");
				}
			}
		}
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
                _ngayhuy.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayhuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_ngayhuy.Text != value) 
				{
					_ngayhuy.Text = value;
					PropertyHasChanged("Ngayhuy");
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
        public String TenLDHoiChan
        {
            get
            {
                CanReadProperty("TenLDHoiChan", true);
                return _tenLDHoiChan;
            }
            set
            {
                CanWriteProperty("TenLDHoiChan", true);
                if (_tenLDHoiChan != value)
                {
                    _tenLDHoiChan = value;
                    PropertyHasChanged("TenLDHoiChan");
                }
            }
        }

        public String TenHTHoiChan
        {
            get
            {
                CanReadProperty("TenHTHoiChan", true);
                return _tenHTHoiChan;
            }
            set
            {
                CanWriteProperty("TenHTHoiChan", true);
                if (_tenHTHoiChan != value)
                {
                    _tenHTHoiChan = value;
                    PropertyHasChanged("TenHTHoiChan");
                }
            }
        }

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }

        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String TenBenhKhoa
        {
            get
            {
                CanReadProperty("TenBenhKhoa", true);
                return _tenBenhKhoa;
            }
            set
            {
                CanWriteProperty("TenBenhKhoa", true);
                if (_tenBenhKhoa != value)
                {
                    _tenBenhKhoa = value;
                    PropertyHasChanged("TenBenhKhoa");
                }
            }
        }
        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
                }
            }
        }
        public String MaICDKhoa
        {
            get
            {
                CanReadProperty("MaICDKhoa", true);
                return _maICDKhoa;
            }
            set
            {
                CanWriteProperty("MaICDKhoa", true);
                if (_maICDKhoa != value)
                {
                    _maICDKhoa = value;
                    PropertyHasChanged("MaICDKhoa");
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

        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _tenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_tenDT != value)
                {
                    _tenDT = value;
                    PropertyHasChanged("TenDT");
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
        public String tenbacsiyeucau
        {
            get
            {
                CanReadProperty("tenbacsiyeucau", true);
                return _tenbacsiyeucau;
            }
            set
            {
                CanWriteProperty("tenbacsiyeucau", true);
                if (_tenbacsiyeucau != value)
                {
                    _tenbacsiyeucau = value;
                    PropertyHasChanged("tenbacsiyeucau");
                }
            }
        }
        public string NgayKham
        {
            get
            {
                CanReadProperty("NgayKham", true);
                //_ngayKham.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayKham.Text;
            }
            set
            {
                CanWriteProperty("NgayKham", true);
                if (_ngayKham.Text != value)
                {
                    _ngayKham.Text = value;
                    PropertyHasChanged("NgayKham");
                }
            }
        }
        public String NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKham", true);
                _ngayKhamD = _ngayKham;
                this._ngayKhamD.FormatString = "dd/MM/yyyy";
                return _ngayKhamD.Text;
            }
         
        }

        private HoiChan_TVList _HoiChan_TVs = HoiChan_TVList.NewHoiChan_TVList();
        public HoiChan_TVList  HoiChan_TVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _HoiChan_TVs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_HoiChan_TVs.Equals(value))
                {
                    _HoiChan_TVs = value;
                    PropertyHasChanged();
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

		protected override Object GetIdValue()
		{
			return _maHC;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _HoiChan_TVs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _HoiChan_TVs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
	    {
            //TODO: add validation rules
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaKhoa", 9));
            ValidationRules.AddRule<HoiChan>(ValidationNgaySinh<HoiChan>, "NgaySinh");
         
            ValidationRules.AddRule<HoiChan>(ValidationNgayKham<HoiChan>, "NgayKham");
            ValidationRules.AddDependantProperty("NgaySinh", "NgayHC");
            ValidationRules.AddDependantProperty("NgaySinh", "NgayKham");
            //ValidationRules.AddRule<HoiChan>(StringRequired<HoiChan>, "TenKhoa");
            ValidationRules.AddRule<HoiChan>(StringRequiredDVT<HoiChan>, "MaKhoa");
        }

        private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : HoiChan 
        {
            if (target._ngaySinh.Date  > System.DateTime.Now.AddDays(1))
            {
                e.Description = "VALIDATION_NOW";
                return false;
            }
            else
                return true;
        }

      
        private static bool ValidationNgayKham<T>(T target, Csla.Validation.RuleArgs e) where T : HoiChan
        {
            if (target._ngayKham.Date > System.DateTime.Now)
            {
                e.Description = "VALIDATION_NOW";
                return false;
            }
            else
                return true;
        }

        private static bool ValidationNgaySinhNgayHC<T>(T target, Csla.Validation.RuleArgs e) where T : HoiChan
        {
            if (target._ngaySinh > target._ngayHC)
            {
                e.Description = "Ngày sinh không được lớn hơn ngày hội chẩn";
                return false;
            }
            else
                return true;
        }
        private static bool ValidationNgaySinhNgayKham<T>(T target, Csla.Validation.RuleArgs e) where T : HoiChan
        {
            if (target._ngaySinh > target._ngayKham)
            {
                e.Description = "Ngày sinh không được lớn hơn ngày khám";
                return false;
            }
            else
                return true;
        }
        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : HoiChan
        //{

        //    if (target._tenKhoa == null || target._tenKhoa.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : HoiChan
        {

            if (target._maKhoa == null || target._maKhoa.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HoiChan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HoiChan NewHoiChan()
        {
            return DataPortal.Create<HoiChan>();
        }
		public static HoiChan GetHoiChan(String maHC)
		{
			return DataPortal.Fetch<HoiChan>(new Criteria(maHC,false   ));
		}
        public static HoiChan GetHoiChan(SafeDataReader dr)
        {
            HoiChan obj = new HoiChan();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="HoiChan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteHoiChan(String maHC, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHC));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HoiChan()
		{	
			// Prevent direct creation
            _maLDHoiChan = "00001";
		}
        internal HoiChan(
                    int OrderNumber,
                    String maHC ,
		             String maBA,
		             String maBN ,
		             String hoten ,
		             Byte tuoi ,
		             Boolean gt ,
		             SmartDate ngaySinh ,
		             String maKhoa ,
		             String maHTHoiChan ,
		             String maLDHoiChan ,
		             SmartDate ngayHC ,
		             String diaDiem ,
		             String yeuCauHC,
		             String tinhtrang ,
		             String tomTat ,
		             String maBenhID ,
		             String nguyenNhan ,
		             String phuongPhap ,
		             String chamSoc ,
		             String ketLuan ,
		             Boolean huy ,
		             SmartDate ngaySD ,
		             String nguoiSD ,
		             String maMay ,
		             String nguoihuy ,
		             SmartDate ngayhuy ,
		             String nguoiLap ,
		             SmartDate ngayLap ,
                     String tenLDHoiChan ,
                     String tenKhoa ,
                     String tenHTHoiChan ,
                     String tenNguoiLap ,
                     String tenNguoiSD ,
                     String tenNguoiHuy ,
                     String maICD ,
                     String tenBenh ,
                     SmartDate ngaykham ,
                     String tendt ,
                     String madt,
		             String maBenhIDkhoa,
                     String maICDkhoa,
                     String tenBenhkhoa ,
                     SmartDate ngaygiovv ,
                     string makhoavv,
                     String tenbacsiyeucau ,
                     string MaBSYC 

                     )
        {
                      _OrderNumber = OrderNumber ;
                      _maHC = maHC ;
                      _maKhoaVV = makhoavv;
                      _ngayGioVV = ngaygiovv;
		              _maBA = maBA ;
		              _maBN = maBN ;
		              _hoten = hoten ;
		              _tuoi = tuoi ;
		              _gt = gt;
		              _ngaySinh = ngaySinh ;
		              _maKhoa = maKhoa ;
		              _maHTHoiChan = maHTHoiChan ;
		              _maLDHoiChan = maLDHoiChan ;
		              _ngayHC = ngayHC ;
		              _diaDiem = diaDiem ;
		              _yeuCauHC = yeuCauHC ;
		              _tinhtrang = tinhtrang ;
		              _tomTat = tomTat ;
		              _maBenhID = maBenhID ;
		              _nguyenNhan = nguyenNhan ;
		              _phuongPhap = phuongPhap ;
		              _chamSoc = chamSoc ;
		              _ketLuan = ketLuan ;
		              _huy = huy;
		              _ngaySD = ngaySD ;
		              _nguoiSD = nguoiSD ;
		              _maMay = maMay ;
		              _nguoihuy = nguoihuy ;
		              _ngayhuy = ngayhuy ;
		              _nguoiLap = nguoiLap ;
		              _ngayLap = ngayLap ;
                      _tenLDHoiChan = tenLDHoiChan ;
                      _tenKhoa = tenKhoa ;
                      _tenHTHoiChan = tenHTHoiChan ;
                      _tenNguoiLap = tenNguoiLap ;
                      _tenNguoiSD = tenNguoiSD ;
                      _tenNguoiHuy = tenNguoiHuy ;
                      _maICD = maICD ;
                      _tenBenh = tenBenh ;
                      _maICDKhoa = maICDkhoa;
                      _tenBenhKhoa = tenBenhkhoa;
                      _maBenhIDKhoa = maBenhIDkhoa;
                    _ngayKham = ngaykham ;
                    _tenDT = tendt ;
                    _maDT = madt ;
                    _MaBSYC = MaBSYC;
                    _tenbacsiyeucau = tenbacsiyeucau;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maHC;
			public String MaHC 
			{
				get
				{
					return _maHC;
				}
			}
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maHC, Boolean qadmin)
			{
				_maHC = maHC;
                _qadmin = qadmin;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maHC.Equals(c._maHC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maHC.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHC;
            public String maHC
            {
                get
                {
                    return _maHC;
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
            //DeletePhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String Mamay, String Nguoisd, string maHC)
            {
                _maHC = maHC;
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
		/// Retrieve an existing <see cref="HoiChan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetHoiChan(String _maHC);
			// public override IDataReader GetHoiChan(String _maHC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHoiChan(crit.MaHC, crit.qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _HoiChan_TVs = HoiChan_TVList.GetHoiChan_TVList(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
                } dr.Close(); dr.Dispose();
			}
		}
		/// <summary>
		/// Load a <see cref="HoiChan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHC") != null) _maHC = dr.GetString("MaHC");
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
			if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
			if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("MaKhoaVV") != null) _maKhoaVV = dr.GetString("MaKhoaVV");
			if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinhD = dr.GetSmartDate("NgaySinh", true);
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaHTHoiChan") != null) _maHTHoiChan = dr.GetString("MaHTHoiChan");
			if (dr.GetString("MaLDHoiChan") != null) _maLDHoiChan = dr.GetString("MaLDHoiChan");
			if (dr.GetSmartDate("NgayHC", true) != null) _ngayHC = dr.GetSmartDate("NgayHC", true);
            if (dr.GetSmartDate("NgayHC", true) != null) _ngayHCD = dr.GetSmartDate("NgayHC", true);
            if (dr.GetSmartDate("NgayGioVV", true) != null) _ngayGioVV = dr.GetSmartDate("NgayGioVV", true);
			if (dr.GetString("DiaDiem") != null) _diaDiem = dr.GetString("DiaDiem");
			if (dr.GetString("YeuCauHC") != null) _yeuCauHC = dr.GetString("YeuCauHC");
			if (dr.GetString("Tinhtrang") != null) _tinhtrang = dr.GetString("Tinhtrang");
			if (dr.GetString("TomTat") != null) _tomTat = dr.GetString("TomTat");
			if (dr.GetString("MaBenhID") != null) _maBenhID = dr.GetString("MaBenhID");
            if (dr.GetString("MaBenhIDkhoa") != null) _maBenhIDKhoa = dr.GetString("MaBenhIDkhoa");
			if (dr.GetString("NguyenNhan") != null) _nguyenNhan = dr.GetString("NguyenNhan");
			if (dr.GetString("PhuongPhap") != null) _phuongPhap = dr.GetString("PhuongPhap");
			if (dr.GetString("ChamSoc") != null) _chamSoc = dr.GetString("ChamSoc");
			if (dr.GetString("KetLuan") != null) _ketLuan = dr.GetString("KetLuan");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
            if (dr.GetString("Maicd") != null) _maICD = dr.GetString("Maicd");
            if (dr.GetString("Tenbenh") != null) _tenBenh = dr.GetString("Tenbenh");
            if (dr.GetString("Maicdkhoa") != null) _maICDKhoa = dr.GetString("Maicdkhoa");
            if (dr.GetString("Tenbenhkhoa") != null) _tenBenhKhoa = dr.GetString("Tenbenhkhoa");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKhamD = dr.GetSmartDate("NgayKham", true);
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("tenbacsiyeucau") != null) _tenbacsiyeucau = dr.GetString("tenbacsiyeucau");
            if (dr.GetString("MaBSYC") != null) _MaBSYC = dr.GetString("MaBSYC");





		}
		
		/// <summary>
		/// Insert the new <see cref="HoiChan" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHoiChan
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maHC = DataProvider.Instance().InsertHoiChan(_maBA, _maBN, _hoten, _tuoi, _gt, _ngaySinh, _maKhoa, _maHTHoiChan, _maLDHoiChan, _ngayHC, _diaDiem, _yeuCauHC, _tinhtrang, _tomTat, _maBenhID, _nguyenNhan, _phuongPhap, _chamSoc, _ketLuan, _maMay , _nguoiSD , _maBenhIDKhoa, _ngayGioVV, _maKhoaVV, TenBenh, TenBenhKhoa,MaBSYC);
            MarkOld(); 
            _HoiChan_TVs.Update(this);
		 
		}
		
		/// <summary>
		/// Update all changes made on <see cref="HoiChan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHoiChan
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateHoiChan(_maHC, _maBA, _maBN, _hoten, _tuoi, _gt, _ngaySinh, _maKhoa, _maHTHoiChan, _maLDHoiChan, _ngayHC, _diaDiem, _yeuCauHC, _tinhtrang, _tomTat, _maBenhID, _nguyenNhan, _phuongPhap, _chamSoc, _ketLuan, _huy,_nguoiSD, _maMay , _maBenhIDKhoa, _ngayGioVV, _maKhoaVV, TenBenh, TenBenhKhoa, MaBSYC);
                 _HoiChan_TVs.Update(this);
				// public abstract void UpdateHoiChan(String _maHC, String _maBA, String _maBN, String _hoten, Byte _tuoi, Boolean _gt, SmartDate _ngaySinh, String _maKhoa, String _maHTHoiChan, String _maLDHoiChan, SmartDate _ngayHC, String _diaDiem, String _yeuCauHC, String _tinhtrang, String _tomTat, String _maBenhID, String _nguyenNhan, String _phuongPhap, String _chamSoc, String _ketLuan, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateHoiChan(String _maHC, String _maBA, String _maBN, String _hoten, Byte _tuoi, Boolean _gt, SmartDate _ngaySinh, String _maKhoa, String _maHTHoiChan, String _maLDHoiChan, SmartDate _ngayHC, String _diaDiem, String _yeuCauHC, String _tinhtrang, String _tomTat, String _maBenhID, String _nguyenNhan, String _phuongPhap, String _chamSoc, String _ketLuan, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHOICHAN_UPDATE", _maHC, _maBA, _maBN, _hoten, _tuoi, _gt, _ngaySinh.DBValue, _maKhoa, _maHTHoiChan, _maLDHoiChan, _ngayHC.DBValue, _diaDiem, _yeuCauHC, _tinhtrang, _tomTat, _maBenhID, _nguyenNhan, _phuongPhap, _chamSoc, _ketLuan, _huy,_nguoiSD   , _maMay);
				// }
                 MarkOld(); 
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maHC));
		}

		/// <summary>
		/// Delete the <see cref="HoiChan" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHoiChan
            DataProvider.Instance().DeleteHoiChan(crit.MaMay, crit.NguoiSD, crit.maHC);
			// public abstract void DeleteHoiChan(String _maHC);
			// public override void DeleteHoiChan(String _maHC);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHOICHAN_DELETED", _maHC);
			// }
		}

		#endregion
	}

}
