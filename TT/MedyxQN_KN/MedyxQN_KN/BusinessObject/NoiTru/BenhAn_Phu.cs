// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Phu
// Kieu doi tuong  :	BenhAn_Phu
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/30/2010 1:34:22 PM
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
	/// This is a base generated class of <see cref="BenhAn_Phu" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_Phu : BusinessBase<BenhAn_Phu>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayKham = new SmartDate(true);
		private String _bSKham = String.Empty;
		private String _lyDoKham = String.Empty;
		
		private String _da = String.Empty;
		private String _niemMac = String.Empty;
        private String _mach = String.Empty;
      	private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
        private String _xuatHuyet = String.Empty;
		private String _phu = String.Empty;
		private String _thieuMau = String.Empty;
		private String _cao = String.Empty;
		private String _tim = String.Empty;
		private String _gan = String.Empty;
		private String _phoi = String.Empty;
		private String _than = String.Empty;
		private String _benhKhac = String.Empty;
        private String _TrieuChung = String.Empty;
        private String _BenhSu = String.Empty;
        private String _amho = String.Empty;
        private String _amdao = String.Empty;
        private String _CTC = String.Empty;
        private String _Tucung = String.Empty;
        private String _PhanPhu = String.Empty;
        private String _KetLuan = String.Empty;
        private String _Tuvan = String.Empty;
		private String _tomTat = String.Empty;
		private String _dieuTri = String.Empty;
		private String _chanDoan = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
        public String TrieuChung
        {
            get
            {
                CanReadProperty("TrieuChung", true);
                return _TrieuChung;
            }
            set
            {
                CanWriteProperty("TrieuChung", true);
                if (_TrieuChung != value)
                {
                    _TrieuChung = value;
                    PropertyHasChanged("TrieuChung");
                }
            }
        }

        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _BenhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_BenhSu != value)
                {
                    _BenhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }
        public String amho
        {
            get
            {
                CanReadProperty("amho", true);
                return _amho;
            }
            set
            {
                CanWriteProperty("amho", true);
                if (_amho != value)
                {
                    _amho = value;
                    PropertyHasChanged("amho");
                }
            }
        }

        public String amdao
        {
            get
            {
                CanReadProperty("amdao", true);
                return _amdao;
            }
            set
            {
                CanWriteProperty("amdao", true);
                if (_amdao != value)
                {
                    _amdao = value;
                    PropertyHasChanged("amdao");
                }
            }
        }

        public String CTC
        {
            get
            {
                CanReadProperty("CTC", true);
                return _CTC;
            }
            set
            {
                CanWriteProperty("CTC", true);
                if (_CTC != value)
                {
                    _CTC = value;
                    PropertyHasChanged("CTC");
                }
            }
        }

        public String Tucung
        {
            get
            {
                CanReadProperty("Tucung", true);
                return _Tucung;
            }
            set
            {
                CanWriteProperty("Tucung", true);
                if (_Tucung != value)
                {
                    _Tucung = value;
                    PropertyHasChanged("Tucung");
                }
            }
        }


        public String PhanPhu
        {
            get
            {
                CanReadProperty("PhanPhu", true);
                return _PhanPhu;
            }
            set
            {
                CanWriteProperty("PhanPhu", true);
                if (_PhanPhu != value)
                {
                    _PhanPhu = value;
                    PropertyHasChanged("PhanPhu");
                }
            }
        }

        public String KetLuan
        {
            get
            {
                CanReadProperty("KetLuan", true);
                return _KetLuan;
            }
            set
            {
                CanWriteProperty("KetLuan", true);
                if (_KetLuan != value)
                {
                    _KetLuan = value;
                    PropertyHasChanged("KetLuan");
                }
            }
        }

        public String Tuvan
        {
            get
            {
                CanReadProperty("Tuvan", true);
                return _Tuvan;
            }
            set
            {
                CanWriteProperty("Tuvan", true);
                if (_Tuvan != value)
                {
                    _Tuvan = value;
                    PropertyHasChanged("Tuvan");
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
		
		public String BSKham
		{
			get 
			{
				CanReadProperty("BSKham", true);
				return _bSKham;
			}
			set 
			{
				CanWriteProperty("BSKham", true);
				if (_bSKham != value) 
				{
					_bSKham = value;
					PropertyHasChanged("BSKham");
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
		
		public String Da
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
		
		public String NiemMac
		{
			get 
			{
				CanReadProperty("NiemMac", true);
				return _niemMac;
			}
			set 
			{
				CanWriteProperty("NiemMac", true);
				if (_niemMac != value) 
				{
					_niemMac = value;
					PropertyHasChanged("NiemMac");
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
		
		public String XuatHuyet
		{
			get 
			{
				CanReadProperty("XuatHuyet", true);
				return _xuatHuyet;
			}
			set 
			{
				CanWriteProperty("XuatHuyet", true);
				if (_xuatHuyet != value) 
				{
					_xuatHuyet = value;
					PropertyHasChanged("XuatHuyet");
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
		
		public String Phu
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
		
		public String ThieuMau
		{
			get 
			{
				CanReadProperty("ThieuMau", true);
				return _thieuMau;
			}
			set 
			{
				CanWriteProperty("ThieuMau", true);
				if (_thieuMau != value) 
				{
					_thieuMau = value;
					PropertyHasChanged("ThieuMau");
				}
			}
		}
		
		public String Cao
		{
			get 
			{
				CanReadProperty("Cao", true);
				return _cao;
			}
			set 
			{
				CanWriteProperty("Cao", true);
				if (_cao != value) 
				{
					_cao = value;
					PropertyHasChanged("Cao");
				}
			}
		}
		
		public String Tim
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
		
		public String Gan
		{
			get 
			{
				CanReadProperty("Gan", true);
				return _gan;
			}
			set 
			{
				CanWriteProperty("Gan", true);
				if (_gan != value) 
				{
					_gan = value;
					PropertyHasChanged("Gan");
				}
			}
		}
		
		public String Phoi
		{
			get 
			{
				CanReadProperty("Phoi", true);
				return _phoi;
			}
			set 
			{
				CanWriteProperty("Phoi", true);
				if (_phoi != value) 
				{
					_phoi = value;
					PropertyHasChanged("Phoi");
				}
			}
		}
		
		public String Than
		{
			get 
			{
				CanReadProperty("Than", true);
				return _than;
			}
			set 
			{
				CanWriteProperty("Than", true);
				if (_than != value) 
				{
					_than = value;
					PropertyHasChanged("Than");
				}
			}
		}
		
		public String BenhKhac
		{
			get 
			{
				CanReadProperty("BenhKhac", true);
				return _benhKhac;
			}
			set 
			{
				CanWriteProperty("BenhKhac", true);
				if (_benhKhac != value) 
				{
					_benhKhac = value;
					PropertyHasChanged("BenhKhac");
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
		
		public String ChanDoan
		{
			get 
			{
				CanReadProperty("ChanDoan", true);
				return _chanDoan;
			}
			set 
			{
				CanWriteProperty("ChanDoan", true);
				if (_chanDoan != value) 
				{
					_chanDoan = value;
					PropertyHasChanged("ChanDoan");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_Phu" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_Phu NewBenhAn_Phu()
        {
            return DataPortal.Create<BenhAn_Phu>();
        }
		public static BenhAn_Phu GetBenhAn_Phu(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_Phu>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_Phu" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_Phu(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_Phu()
		{	
			// Prevent direct creation
		}
        internal BenhAn_Phu( 
            int OrderNumber,
            String maBA ,
		 Int32 sTT ,
		 Int32 sTTKhoa ,
		 SmartDate ngayKham ,
		 String bSKham ,
		 String lyDoKham ,
		 String mach ,
		 String da ,
		 String niemMac ,
		 String apHuyet ,
		 String xuatHuyet ,
		 String nhietDo ,
		 String nhipTho ,
		 String canNang ,
		 String chieuCao ,
		 String phu ,
		 String thieuMau ,
		 String cao ,
		 String tim ,
		 String gan ,
		 String phoi ,
		 String than ,
		 String benhKhac ,
          String   TrieuChung, String amho,String  amdao, String CTC, String Tucung, String PhanPhu,String KetLuan,
            String Tuvan, String BenhSu,
		 String tomTat ,
		 String dieuTri ,
		 String chanDoan ,
		 String maMay ,
		 Boolean huy ,
		 SmartDate ngaySD ,
		 String nguoiSD ,
		 SmartDate ngaySD1 ,
		 String nguoiSD1 ,
         String tenBSKham ,
         String tennguoiSD 
         )
        {
             _OrderNumber= OrderNumber ;
             _maBA = maBA ;
		  _sTT = sTT ;
		  _sTTKhoa = sTTKhoa ;
		  _ngayKham = ngayKham ;
		  _bSKham = bSKham ;
		  _lyDoKham = lyDoKham ;
		  _mach =  mach ;
		  _da = da ;
		  _niemMac = niemMac ;
		  _apHuyet = apHuyet ;
		  _xuatHuyet = xuatHuyet ;
          _nhietDo = nhietDo;
		  _nhipTho = nhipTho ;
		  _canNang = canNang ;
		  _chieuCao = chieuCao ;
		  _phu = phu;
		  _thieuMau = thieuMau ;
		  _cao = cao; 
		  _tim = tim ;
		  _gan = gan;
		  _phoi = phoi;
		  _than = than;
		  _benhKhac = benhKhac ;
          _TrieuChung = TrieuChung; _amho = amho; _amdao = amdao; _CTC = CTC; _Tucung = Tucung; _PhanPhu = PhanPhu; _KetLuan = KetLuan; _Tuvan = Tuvan; _BenhSu = BenhSu;
		  _tomTat = TomTat;
		  _dieuTri = dieuTri ;
		  _chanDoan = chanDoan ;
		  _maMay = maMay ;
		  _huy = huy ; 
		  _ngaySD = ngaySD ;
		  _nguoiSD = nguoiSD ;
		  _ngaySD1 = ngaySD1 ;
		  _nguoiSD1 = nguoiSD1 ;
          _tenBSKham = tenBSKham ;
          _tennguoiSD = tennguoiSD ;
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
		/// Retrieve an existing <see cref="BenhAn_Phu" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Phu_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Phu(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_Phu" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("Da") != null) _da = dr.GetString("Da");
			if (dr.GetString("NiemMac") != null) _niemMac = dr.GetString("NiemMac");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("XuatHuyet") != null) _xuatHuyet = dr.GetString("XuatHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
			if (dr.GetString("Phu") != null) _phu = dr.GetString("Phu");
			if (dr.GetString("ThieuMau") != null) _thieuMau = dr.GetString("ThieuMau");
			if (dr.GetString("Cao") != null) _cao = dr.GetString("Cao");
			if (dr.GetString("Tim") != null) _tim = dr.GetString("Tim");
			if (dr.GetString("Gan") != null) _gan = dr.GetString("Gan");
			if (dr.GetString("Phoi") != null) _phoi = dr.GetString("Phoi");
			if (dr.GetString("Than") != null) _than = dr.GetString("Than");
			if (dr.GetString("BenhKhac") != null) _benhKhac = dr.GetString("BenhKhac");

            if (dr.GetString("BenhSu") != null) _BenhSu = dr.GetString("BenhSu");
            if (dr.GetString("TrieuChung") != null) _TrieuChung = dr.GetString("TrieuChung");
            if (dr.GetString("amho") != null) _amho = dr.GetString("amho");
            if (dr.GetString("amdao") != null) _amdao = dr.GetString("amdao");
            if (dr.GetString("CTC") != null) _CTC = dr.GetString("CTC");
            if (dr.GetString("Tucung") != null) _Tucung = dr.GetString("Tucung");
            if (dr.GetString("PhanPhu") != null) _PhanPhu = dr.GetString("PhanPhu");
            if (dr.GetString("KetLuan") != null) _KetLuan = dr.GetString("KetLuan");
            if (dr.GetString("Tuvan") != null) _Tuvan = dr.GetString("Tuvan");

			if (dr.GetString("TomTat") != null) _tomTat = dr.GetString("TomTat");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_Phu" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_Phu
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
              _maBA = DataProvider.Instance().InsertBenhAn_Phu(_maBA, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _BenhSu, _tomTat, _dieuTri, _chanDoan, _maMay, _nguoiSD);
            MarkOld();	// public abstract String InsertBenhAn_Phu(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_Phu(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Phu_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_Phu" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Phu
			if (IsDirty){
                
                  
                  DataProvider.Instance().UpdateBenhAn_Phu(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan,_BenhSu, _tomTat, _dieuTri, _chanDoan, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Phu_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_Phu" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Phu
            DataProvider.Instance().DeleteBenhAn_Phu(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Phu_DELETED", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
