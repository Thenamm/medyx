// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_TM
// Kieu doi tuong  :	BenhAn_TM
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/8/2009 2:28:41 PM
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
	/// This is a base generated class of <see cref="BenhAn_TM" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_TM : BusinessBase<BenhAn_TM>
	{
		#region Business Methods
		
		#region State Fields
		  

		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
		private Boolean _da = false;
		private Boolean _phu = false;
		private Boolean _ngonTay = false;
		private Boolean _hach = false;
		private Boolean _khotho = false;
		private Boolean _ho = false;
		private Boolean _daunguc = false;
		private Boolean _tim = false;
		private Boolean _ngoiXom = false;
		private Boolean _ngat = false;
		private Boolean _hoihop = false;
		private String _dauhieuKhac = String.Empty;
		private String _longnguc = String.Empty;
		private String _vitrimomtim = String.Empty;
		private String _tiengtim = String.Empty;
		private String _tiengthoitim = String.Empty;
		private String _tiengthoimach = String.Empty;
		private String _tiengthoikhac = String.Empty;
		private String _machtuchi = String.Empty;
		private String _hohap = String.Empty;
		private String _bung = String.Empty;
		private String _thanhkinh = String.Empty;
		private String _coquankhac = String.Empty;
		private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _machuyenkhoa = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
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
		
		public Int32 STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}
		
		public string NgayKham
		{
			get 
			{
				CanReadProperty("NgayKham", true);
               
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
        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham; 
                this._ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";
                return _ngayKhamD.Text;
            }
            
        }
		public String BSKHAM
		{
			get 
			{
				CanReadProperty("BSKHAM", true);
				return _bSKHAM;
			}
			set 
			{
				CanWriteProperty("BSKHAM", true);
				if (_bSKHAM != value) 
				{
					_bSKHAM = value;
					PropertyHasChanged("BSKHAM");
				}
			}
		}
		
		public String LyDoKham
		{
			get 
			{
				CanReadProperty("LyDoKham", true);
				return _lyDoKham;
			}
			set 
			{
				CanWriteProperty("LyDoKham", true);
				if (_lyDoKham != value) 
				{
					_lyDoKham = value;
					PropertyHasChanged("LyDoKham");
				}
			}
		}
		
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_mach != value) 
				{
					_mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String ApHuyet
		{
			get 
			{
				CanReadProperty("ApHuyet", true);
				return _apHuyet;
			}
			set 
			{
				CanWriteProperty("ApHuyet", true);
				if (_apHuyet != value) 
				{
					_apHuyet = value;
					PropertyHasChanged("ApHuyet");
				}
			}
		}
		
		public String NhietDo
		{
			get 
			{
				CanReadProperty("NhietDo", true);
				return _nhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_nhietDo != value) 
				{
					_nhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
		
		public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _nhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_nhipTho != value) 
				{
					_nhipTho = value;
					PropertyHasChanged("NhipTho");
				}
			}
		}
		
		public String CanNang
		{
			get 
			{
				CanReadProperty("CanNang", true);
				return _canNang;
			}
			set 
			{
				CanWriteProperty("CanNang", true);
				if (_canNang != value) 
				{
					_canNang = value;
					PropertyHasChanged("CanNang");
				}
			}
		}
		
		public String ChieuCao
		{
			get 
			{
				CanReadProperty("ChieuCao", true);
				return _chieuCao;
			}
			set 
			{
				CanWriteProperty("ChieuCao", true);
				if (_chieuCao != value) 
				{
					_chieuCao = value;
					PropertyHasChanged("ChieuCao");
				}
			}
		}
		
		public Boolean Da
		{
			get 
			{
				CanReadProperty("Da", true);
				return _da;
			}
			set 
			{
				CanWriteProperty("Da", true);
				if (_da != value) 
				{
					_da = value;
					PropertyHasChanged("Da");
				}
			}
		}
		
		public Boolean Phu
		{
			get 
			{
				CanReadProperty("Phu", true);
				return _phu;
			}
			set 
			{
				CanWriteProperty("Phu", true);
				if (_phu != value) 
				{
					_phu = value;
					PropertyHasChanged("Phu");
				}
			}
		}
		
		public Boolean NgonTay
		{
			get 
			{
				CanReadProperty("NgonTay", true);
				return _ngonTay;
			}
			set 
			{
				CanWriteProperty("NgonTay", true);
				if (_ngonTay != value) 
				{
					_ngonTay = value;
					PropertyHasChanged("NgonTay");
				}
			}
		}
		
		public Boolean Hach
		{
			get 
			{
				CanReadProperty("Hach", true);
				return _hach;
			}
			set 
			{
				CanWriteProperty("Hach", true);
				if (_hach != value) 
				{
					_hach = value;
					PropertyHasChanged("Hach");
				}
			}
		}
		
		public Boolean Khotho
		{
			get 
			{
				CanReadProperty("Khotho", true);
				return _khotho;
			}
			set 
			{
				CanWriteProperty("Khotho", true);
				if (_khotho != value) 
				{
					_khotho = value;
					PropertyHasChanged("Khotho");
				}
			}
		}
		
		public Boolean Ho
		{
			get 
			{
				CanReadProperty("Ho", true);
				return _ho;
			}
			set 
			{
				CanWriteProperty("Ho", true);
				if (_ho != value) 
				{
					_ho = value;
					PropertyHasChanged("Ho");
				}
			}
		}
		
		public Boolean Daunguc
		{
			get 
			{
				CanReadProperty("Daunguc", true);
				return _daunguc;
			}
			set 
			{
				CanWriteProperty("Daunguc", true);
				if (_daunguc != value) 
				{
					_daunguc = value;
					PropertyHasChanged("Daunguc");
				}
			}
		}
		
		public Boolean Tim
		{
			get 
			{
				CanReadProperty("Tim", true);
				return _tim;
			}
			set 
			{
				CanWriteProperty("Tim", true);
				if (_tim != value) 
				{
					_tim = value;
					PropertyHasChanged("Tim");
				}
			}
		}
		
		public Boolean NgoiXom
		{
			get 
			{
				CanReadProperty("NgoiXom", true);
				return _ngoiXom;
			}
			set 
			{
				CanWriteProperty("NgoiXom", true);
				if (_ngoiXom != value) 
				{
					_ngoiXom = value;
					PropertyHasChanged("NgoiXom");
				}
			}
		}
		
		public Boolean Ngat
		{
			get 
			{
				CanReadProperty("Ngat", true);
				return _ngat;
			}
			set 
			{
				CanWriteProperty("Ngat", true);
				if (_ngat != value) 
				{
					_ngat = value;
					PropertyHasChanged("Ngat");
				}
			}
		}
		
		public Boolean Hoihop
		{
			get 
			{
				CanReadProperty("Hoihop", true);
				return _hoihop;
			}
			set 
			{
				CanWriteProperty("Hoihop", true);
				if (_hoihop != value) 
				{
					_hoihop = value;
					PropertyHasChanged("Hoihop");
				}
			}
		}
		
		public String DauhieuKhac
		{
			get 
			{
				CanReadProperty("DauhieuKhac", true);
				return _dauhieuKhac;
			}
			set 
			{
				CanWriteProperty("DauhieuKhac", true);
				if (_dauhieuKhac != value) 
				{
					_dauhieuKhac = value;
					PropertyHasChanged("DauhieuKhac");
				}
			}
		}
		
		public String Longnguc
		{
			get 
			{
				CanReadProperty("Longnguc", true);
				return _longnguc;
			}
			set 
			{
				CanWriteProperty("Longnguc", true);
				if (_longnguc != value) 
				{
					_longnguc = value;
					PropertyHasChanged("Longnguc");
				}
			}
		}
		
		public String Vitrimomtim
		{
			get 
			{
				CanReadProperty("Vitrimomtim", true);
				return _vitrimomtim;
			}
			set 
			{
				CanWriteProperty("Vitrimomtim", true);
				if (_vitrimomtim != value) 
				{
					_vitrimomtim = value;
					PropertyHasChanged("Vitrimomtim");
				}
			}
		}
		
		public String Tiengtim
		{
			get 
			{
				CanReadProperty("Tiengtim", true);
				return _tiengtim;
			}
			set 
			{
				CanWriteProperty("Tiengtim", true);
				if (_tiengtim != value) 
				{
					_tiengtim = value;
					PropertyHasChanged("Tiengtim");
				}
			}
		}
		
		public String Tiengthoitim
		{
			get 
			{
				CanReadProperty("Tiengthoitim", true);
				return _tiengthoitim;
			}
			set 
			{
				CanWriteProperty("Tiengthoitim", true);
				if (_tiengthoitim != value) 
				{
					_tiengthoitim = value;
					PropertyHasChanged("Tiengthoitim");
				}
			}
		}
		
		public String Tiengthoimach
		{
			get 
			{
				CanReadProperty("Tiengthoimach", true);
				return _tiengthoimach;
			}
			set 
			{
				CanWriteProperty("Tiengthoimach", true);
				if (_tiengthoimach != value) 
				{
					_tiengthoimach = value;
					PropertyHasChanged("Tiengthoimach");
				}
			}
		}
		
		public String Tiengthoikhac
		{
			get 
			{
				CanReadProperty("Tiengthoikhac", true);
				return _tiengthoikhac;
			}
			set 
			{
				CanWriteProperty("Tiengthoikhac", true);
				if (_tiengthoikhac != value) 
				{
					_tiengthoikhac = value;
					PropertyHasChanged("Tiengthoikhac");
				}
			}
		}
		
		public String Machtuchi
		{
			get 
			{
				CanReadProperty("Machtuchi", true);
				return _machtuchi;
			}
			set 
			{
				CanWriteProperty("Machtuchi", true);
				if (_machtuchi != value) 
				{
					_machtuchi = value;
					PropertyHasChanged("Machtuchi");
				}
			}
		}
		
		public String Hohap
		{
			get 
			{
				CanReadProperty("Hohap", true);
				return _hohap;
			}
			set 
			{
				CanWriteProperty("Hohap", true);
				if (_hohap != value) 
				{
					_hohap = value;
					PropertyHasChanged("Hohap");
				}
			}
		}
		
		public String Bung
		{
			get 
			{
				CanReadProperty("Bung", true);
				return _bung;
			}
			set 
			{
				CanWriteProperty("Bung", true);
				if (_bung != value) 
				{
					_bung = value;
					PropertyHasChanged("Bung");
				}
			}
		}
		
		public String Thanhkinh
		{
			get 
			{
				CanReadProperty("Thanhkinh", true);
				return _thanhkinh;
			}
			set 
			{
				CanWriteProperty("Thanhkinh", true);
				if (_thanhkinh != value) 
				{
					_thanhkinh = value;
					PropertyHasChanged("Thanhkinh");
				}
			}
		}
		
		public String Coquankhac
		{
			get 
			{
				CanReadProperty("Coquankhac", true);
				return _coquankhac;
			}
			set 
			{
				CanWriteProperty("Coquankhac", true);
				if (_coquankhac != value) 
				{
					_coquankhac = value;
					PropertyHasChanged("Coquankhac");
				}
			}
		}
		
		public String DieuTri
		{
			get 
			{
				CanReadProperty("DieuTri", true);
				return _dieuTri;
			}
			set 
			{
				CanWriteProperty("DieuTri", true);
				if (_dieuTri != value) 
				{
					_dieuTri = value;
					PropertyHasChanged("DieuTri");
				}
			}
		}
		
		public String BenhSu
		{
			get 
			{
				CanReadProperty("BenhSu", true);
				return _benhSu;
			}
			set 
			{
				CanWriteProperty("BenhSu", true);
				if (_benhSu != value) 
				{
					_benhSu = value;
					PropertyHasChanged("BenhSu");
				}
			}
		}
		
		public String HuongDT
		{
			get 
			{
				CanReadProperty("HuongDT", true);
				return _huongDT;
			}
			set 
			{
				CanWriteProperty("HuongDT", true);
				if (_huongDT != value) 
				{
					_huongDT = value;
					PropertyHasChanged("HuongDT");
				}
			}
		}
		
		public String Mabenh
		{
			get 
			{
				CanReadProperty("Mabenh", true);
				return _mabenh;
			}
			set 
			{
				CanWriteProperty("Mabenh", true);
				if (_mabenh != value) 
				{
					_mabenh = value;
					PropertyHasChanged("Mabenh");
				}
			}
		}
		
		public String MaBenhKem
		{
			get 
			{
				CanReadProperty("MaBenhKem", true);
				return _maBenhKem;
			}
			set 
			{
				CanWriteProperty("MaBenhKem", true);
				if (_maBenhKem != value) 
				{
					_maBenhKem = value;
					PropertyHasChanged("MaBenhKem");
				}
			}
		}
		
		public String Machuyenkhoa
		{
			get 
			{
				CanReadProperty("Machuyenkhoa", true);
				return _machuyenkhoa;
			}
			set 
			{
				CanWriteProperty("Machuyenkhoa", true);
				if (_machuyenkhoa != value) 
				{
					_machuyenkhoa = value;
					PropertyHasChanged("Machuyenkhoa");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm"; 
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
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
        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenBenhKem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenBenhKem != value)
                {
                    _tenBenhKem = value;
                    PropertyHasChanged("TenBenhKem");
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
        public String MaICDKem
        {
            get
            {
                CanReadProperty("MaICDKem", true);
                return _maICDKem;
            }
            set
            {
                CanWriteProperty("MaICDKem", true);
                if (_maICDKem != value)
                {
                    _maICDKem = value;
                    PropertyHasChanged("MaICDKem");
                }
            }
        }
        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_TM" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_TM NewBenhAn_TM()
        {
            return DataPortal.Create<BenhAn_TM>();
        }
		public static BenhAn_TM GetBenhAn_TM(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_TM>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_TM" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_TM(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_TM()
		{	
			// Prevent direct creation
		}

        internal BenhAn_TM(     int OrderNumber,
                                 String maBA ,
		                         Int32 sTT ,
		                         Int32 sTTKhoa ,
		                         SmartDate ngayKham ,
		                         String bSKHAM ,
		                         String lyDoKham ,
		                         String mach ,
		                         String apHuyet ,
		                         String nhietDo ,
		                         String nhipTho ,
		                         String canNang ,
		                         String chieuCao ,
		                         Boolean da ,
		                         Boolean phu ,
		                         Boolean ngonTay ,
		                         Boolean hach ,
		                         Boolean khotho ,
		                         Boolean ho ,
		                         Boolean daunguc ,
		                         Boolean tim,
		                         Boolean ngoiXom ,
		                         Boolean ngat ,
		                         Boolean hoihop ,
		                         String dauhieuKhac ,
		                         String longnguc ,
		                         String vitrimomtim ,
		                         String tiengtim ,
		                         String tiengthoitim ,
		                         String tiengthoimach ,
		                         String tiengthoikhac ,
		                         String machtuchi,
		                         String hohap ,
		                         String bung ,
		                         String thanhkinh ,
		                         String coquankhac ,
		                         String dieuTri ,
		                         String benhSu ,
		                         String huongDT ,
		                         String mabenh ,
		                         String maBenhKem ,
		                         String machuyenkhoa ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD1 ,
                                 String tenBenh ,
                                 String tenBenhKem ,
                                 //String maICD ,
                                 String maICDKem ,
                                 String tenBSKham ,
                                string tennguoisd
                                )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maBA = maBA ;
		                          _sTT = sTT;
		                          _sTTKhoa = sTTKhoa;
		                          _ngayKham = ngayKham ;
		                          _bSKHAM = bSKHAM ;
		                          _lyDoKham = lyDoKham ;
		                          _mach = mach ;
		                          _apHuyet = apHuyet ;
		                          _nhietDo = nhietDo ;
		                          _nhipTho = nhipTho ;
		                          _canNang = canNang ;
		                          _chieuCao = chieuCao ;
		                          _da = da ;
		                          _phu = phu ;
		                          _ngonTay = ngonTay ;
		                          _hach = hach ;
		                          _khotho = khotho ;
		                          _ho = ho ;
		                          _daunguc = daunguc;
		                          _tim = tim ;
		                          _ngoiXom = ngoiXom ;
		                          _ngat = ngat ;
		                          _hoihop = hoihop ;
		                          _dauhieuKhac = dauhieuKhac ;
		                          _longnguc = longnguc ;
		                          _vitrimomtim = vitrimomtim ;
		                          _tiengtim = tiengtim ;
		                          _tiengthoitim = tiengthoitim ;
		                          _tiengthoimach = tiengthoimach ;
		                          _tiengthoikhac = tiengthoikhac ;
		                          _machtuchi = machtuchi ;
		                          _hohap = hohap ;
		                          _bung = bung ;
		                          _thanhkinh = thanhkinh ;
		                          _coquankhac = coquankhac ;
		                          _dieuTri = dieuTri ;
		                          _benhSu = benhSu ;
		                          _huongDT = huongDT;
		                          _mabenh = mabenh ;
		                          _maBenhKem = maBenhKem ;
		                          _machuyenkhoa = machuyenkhoa ;
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
                                  _tenBenh = tenBenh ;
                                  _tenBenhKem = tenBenhKem ;
                                 // _maICD = maICD ;
                                  _maICDKem = maICDKem ;
                                  _tenBSKham = tenBSKham ;
                                  _tennguoiSD = tennguoisd;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
				}
			}
			
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
		/// Retrieve an existing <see cref="BenhAn_TM" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TM_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_TM(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_TM" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
			if (dr.GetBoolean("Da") != null) _da = dr.GetBoolean("Da");
			if (dr.GetBoolean("Phu") != null) _phu = dr.GetBoolean("Phu");
			if (dr.GetBoolean("NgonTay") != null) _ngonTay = dr.GetBoolean("NgonTay");
			if (dr.GetBoolean("Hach") != null) _hach = dr.GetBoolean("Hach");
			if (dr.GetBoolean("Khotho") != null) _khotho = dr.GetBoolean("Khotho");
			if (dr.GetBoolean("Ho") != null) _ho = dr.GetBoolean("Ho");
			if (dr.GetBoolean("Daunguc") != null) _daunguc = dr.GetBoolean("Daunguc");
			if (dr.GetBoolean("Tim") != null) _tim = dr.GetBoolean("Tim");
			if (dr.GetBoolean("NgoiXom") != null) _ngoiXom = dr.GetBoolean("NgoiXom");
			if (dr.GetBoolean("Ngat") != null) _ngat = dr.GetBoolean("Ngat");
			if (dr.GetBoolean("Hoihop") != null) _hoihop = dr.GetBoolean("Hoihop");
			if (dr.GetString("DauhieuKhac") != null) _dauhieuKhac = dr.GetString("DauhieuKhac");
			if (dr.GetString("Longnguc") != null) _longnguc = dr.GetString("Longnguc");
			if (dr.GetString("Vitrimomtim") != null) _vitrimomtim = dr.GetString("Vitrimomtim");
			if (dr.GetString("Tiengtim") != null) _tiengtim = dr.GetString("Tiengtim");
			if (dr.GetString("Tiengthoitim") != null) _tiengthoitim = dr.GetString("Tiengthoitim");
			if (dr.GetString("Tiengthoimach") != null) _tiengthoimach = dr.GetString("Tiengthoimach");
			if (dr.GetString("Tiengthoikhac") != null) _tiengthoikhac = dr.GetString("Tiengthoikhac");
			if (dr.GetString("Machtuchi") != null) _machtuchi = dr.GetString("Machtuchi");
			if (dr.GetString("Hohap") != null) _hohap = dr.GetString("Hohap");
			if (dr.GetString("Bung") != null) _bung = dr.GetString("Bung");
			if (dr.GetString("Thanhkinh") != null) _thanhkinh = dr.GetString("Thanhkinh");
			if (dr.GetString("Coquankhac") != null) _coquankhac = dr.GetString("Coquankhac");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
			if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_TM" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_TM
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn_TM(_maBA, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _nguoiSD , _tenBenh, _tenBenhKem);
			// public abstract String InsertBenhAn_TM(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_TM(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TM_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_TM" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_TM
			if (IsDirty){
				DataProvider.Instance().UpdateBenhAn_TM(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD ,_tenBenh ,_tenBenhKem );
				// public abstract void UpdateBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TM_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_TM" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_TM
            DataProvider.Instance().DeleteBenhAn_TM(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TM_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
