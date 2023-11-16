// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_T
// Kieu doi tuong  :	Luong_T
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/29/2009 9:27:28 AM
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

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_T" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_T : BusinessBase<Luong_T>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;

        private Decimal _tienLamDem = 0;
        private Decimal _hoiChan = 0;
        private Decimal _hoiChanNV = 0;
        private Decimal _donGiaHC = 0;
        private Decimal _donGiaHCNV = 0;
        private Decimal _heSoBDPT = 0;
        private Decimal _tongTienPT = 0;
        private Decimal _xQUANGDD = 0;
        private Decimal _tongTienDD = 0;
        private Decimal _heSoM2 = 0;
        private Decimal _mucLuongM2 = 0;
        private Decimal _ngoaiGio1 = 0;
        private Decimal _ngoaiGio2 = 0;
        private Decimal _ngoaiGio3 = 0;
        private Decimal _ngoaiGio4 = 0;
        private Decimal _heSoNgoaiGio = 0;
        private Decimal _aBC = 0;
        private Decimal _heSoTT = 0;
        private Decimal _tTDB = 0;
        private Decimal _tT1 = 0;
        private Decimal _tT2 = 0;
        private Decimal _tT3 = 0;

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
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
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
		
		public string Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang.Text;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang.Text != value) 
				{
					_thang.Text = value;
					PropertyHasChanged("Thang");
				}
			}
		}
		
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _maNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_maNV != value) 
				{
					_maNV = value;
					PropertyHasChanged("MaNV");
				}
			}
		}
		
		public String Makhoa
		{
			get 
			{
				CanReadProperty("Makhoa", true);
				return _makhoa;
			}
			set 
			{
				CanWriteProperty("Makhoa", true);
				if (_makhoa != value) 
				{
					_makhoa = value;
					PropertyHasChanged("Makhoa");
				}
			}
		}

        public Decimal TienLamDem
        {
            get
            {
                CanReadProperty("TienLamDem", true);
                return _tienLamDem;
            }
            set
            {
                CanWriteProperty("TienLamDem", true);
                if (_tienLamDem != value)
                {
                    _tienLamDem = value;
                    PropertyHasChanged("TienLamDem");
                }
            }
        }

        public Decimal HoiChan
        {
            get
            {
                CanReadProperty("HoiChan", true);
                return _hoiChan;
            }
            set
            {
                CanWriteProperty("HoiChan", true);
                if (_hoiChan != value)
                {
                    _hoiChan = value;
                    PropertyHasChanged("HoiChan");
                }
            }
        }

        public Decimal HoiChanNV
        {
            get
            {
                CanReadProperty("HoiChanNV", true);
                return _hoiChanNV;
            }
            set
            {
                CanWriteProperty("HoiChanNV", true);
                if (_hoiChanNV != value)
                {
                    _hoiChanNV = value;
                    PropertyHasChanged("HoiChanNV");
                }
            }
        }

        public Decimal DonGiaHC
        {
            get
            {
                CanReadProperty("DonGiaHC", true);
                return _donGiaHC;
            }
            set
            {
                CanWriteProperty("DonGiaHC", true);
                if (_donGiaHC != value)
                {
                    _donGiaHC = value;
                    PropertyHasChanged("DonGiaHC");
                }
            }
        }

        public Decimal DonGiaHCNV
        {
            get
            {
                CanReadProperty("DonGiaHCNV", true);
                return _donGiaHCNV;
            }
            set
            {
                CanWriteProperty("DonGiaHCNV", true);
                if (_donGiaHCNV != value)
                {
                    _donGiaHCNV = value;
                    PropertyHasChanged("DonGiaHCNV");
                }
            }
        }

        public Decimal HeSoBDPT
        {
            get
            {
                CanReadProperty("HeSoBDPT", true);
                return _heSoBDPT;
            }
            set
            {
                CanWriteProperty("HeSoBDPT", true);
                if (_heSoBDPT != value)
                {
                    _heSoBDPT = value;
                    PropertyHasChanged("HeSoBDPT");
                }
            }
        }

        public Decimal TongTienPT
        {
            get
            {
                CanReadProperty("TongTienPT", true);
                return _tongTienPT;
            }
            set
            {
                CanWriteProperty("TongTienPT", true);
                if (_tongTienPT != value)
                {
                    _tongTienPT = value;
                    PropertyHasChanged("TongTienPT");
                }
            }
        }

        public Decimal XQUANGDD
        {
            get
            {
                CanReadProperty("XQUANGDD", true);
                return _xQUANGDD;
            }
            set
            {
                CanWriteProperty("XQUANGDD", true);
                if (_xQUANGDD != value)
                {
                    _xQUANGDD = value;
                    PropertyHasChanged("XQUANGDD");
                }
            }
        }

        public Decimal TongTienDD
        {
            get
            {
                CanReadProperty("TongTienDD", true);
                return _tongTienDD;
            }
            set
            {
                CanWriteProperty("TongTienDD", true);
                if (_tongTienDD != value)
                {
                    _tongTienDD = value;
                    PropertyHasChanged("TongTienDD");
                }
            }
        }

        public Decimal HeSoM2
        {
            get
            {
                CanReadProperty("HeSoM2", true);
                return _heSoM2;
            }
            set
            {
                CanWriteProperty("HeSoM2", true);
                if (_heSoM2 != value)
                {
                    _heSoM2 = value;
                    PropertyHasChanged("HeSoM2");
                }
            }
        }

        public Decimal MucLuongM2
        {
            get
            {
                CanReadProperty("MucLuongM2", true);
                return _mucLuongM2;
            }
            set
            {
                CanWriteProperty("MucLuongM2", true);
                if (_mucLuongM2 != value)
                {
                    _mucLuongM2 = value;
                    PropertyHasChanged("MucLuongM2");
                }
            }
        }

        public Decimal NgoaiGio1
        {
            get
            {
                CanReadProperty("NgoaiGio1", true);
                return _ngoaiGio1;
            }
            set
            {
                CanWriteProperty("NgoaiGio1", true);
                if (_ngoaiGio1 != value)
                {
                    _ngoaiGio1 = value;
                    PropertyHasChanged("NgoaiGio1");
                }
            }
        }

        public Decimal NgoaiGio2
        {
            get
            {
                CanReadProperty("NgoaiGio2", true);
                return _ngoaiGio2;
            }
            set
            {
                CanWriteProperty("NgoaiGio2", true);
                if (_ngoaiGio2 != value)
                {
                    _ngoaiGio2 = value;
                    PropertyHasChanged("NgoaiGio2");
                }
            }
        }

        public Decimal NgoaiGio3
        {
            get
            {
                CanReadProperty("NgoaiGio3", true);
                return _ngoaiGio3;
            }
            set
            {
                CanWriteProperty("NgoaiGio3", true);
                if (_ngoaiGio3 != value)
                {
                    _ngoaiGio3 = value;
                    PropertyHasChanged("NgoaiGio3");
                }
            }
        }

        public Decimal NgoaiGio4
        {
            get
            {
                CanReadProperty("NgoaiGio4", true);
                return _ngoaiGio4;
            }
            set
            {
                CanWriteProperty("NgoaiGio4", true);
                if (_ngoaiGio4 != value)
                {
                    _ngoaiGio4 = value;
                    PropertyHasChanged("NgoaiGio4");
                }
            }
        }

        public Decimal HeSoNgoaiGio
        {
            get
            {
                CanReadProperty("HeSoNgoaiGio", true);
                return _heSoNgoaiGio;
            }
            set
            {
                CanWriteProperty("HeSoNgoaiGio", true);
                if (_heSoNgoaiGio != value)
                {
                    _heSoNgoaiGio = value;
                    PropertyHasChanged("HeSoNgoaiGio");
                }
            }
        }

        public Decimal ABC
        {
            get
            {
                CanReadProperty("ABC", true);
                return _aBC;
            }
            set
            {
                CanWriteProperty("ABC", true);
                if (_aBC != value)
                {
                    _aBC = value;
                    PropertyHasChanged("ABC");
                }
            }
        }

        public Decimal HeSoTT
        {
            get
            {
                CanReadProperty("HeSoTT", true);
                return _heSoTT;
            }
            set
            {
                CanWriteProperty("HeSoTT", true);
                if (_heSoTT != value)
                {
                    _heSoTT = value;
                    PropertyHasChanged("HeSoTT");
                }
            }
        }

        public Decimal TTDB
        {
            get
            {
                CanReadProperty("TTDB", true);
                return _tTDB;
            }
            set
            {
                CanWriteProperty("TTDB", true);
                if (_tTDB != value)
                {
                    _tTDB = value;
                    PropertyHasChanged("TTDB");
                }
            }
        }

        public Decimal TT1
        {
            get
            {
                CanReadProperty("TT1", true);
                return _tT1;
            }
            set
            {
                CanWriteProperty("TT1", true);
                if (_tT1 != value)
                {
                    _tT1 = value;
                    PropertyHasChanged("TT1");
                }
            }
        }

        public Decimal TT2
        {
            get
            {
                CanReadProperty("TT2", true);
                return _tT2;
            }
            set
            {
                CanWriteProperty("TT2", true);
                if (_tT2 != value)
                {
                    _tT2 = value;
                    PropertyHasChanged("TT2");
                }
            }
        }

        public Decimal TT3
        {
            get
            {
                CanReadProperty("TT3", true);
                return _tT3;
            }
            set
            {
                CanWriteProperty("TT3", true);
                if (_tT3 != value)
                {
                    _tT3 = value;
                    PropertyHasChanged("TT3");
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
			return _sTT.ToString() + "!" + _thang.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_T" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_T NewLuong_T()
        {
            return new Luong_T();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_T GetLuong_T(SafeDataReader dr, int i)
        {
            return new Luong_T(dr, i);
        }
        //public static Luong_T GetLuong_T(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_T>(new Criteria(sTT, thang));
        //}
        public Luong_T()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_T" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_T(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_T()
        //{	
        //    // Prevent direct creation
        //}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private SmartDate _thang;
			public SmartDate Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			public Criteria(Int32 sTT, SmartDate thang)
			{
				_sTT = sTT;
				_thang = thang;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_thang.Equals(c._thang)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString(), _thang.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class CriteriaOther
        {
            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
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
            public CriteriaOther(String Mamay, String Nguoisd, Int32 sTT, SmartDate thang)
            {
                _sTT = sTT;
                _thang = thang;
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
		/// Retrieve an existing <see cref="Luong_T" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_T(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_T(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_T(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_T" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_TCB") != null) _mucLuong_TCB = dr.GetDecimal("MucLuong_TCB");
        //    if (dr.GetDecimal("HeSoLuong_T") != null) _heSoLuong_T = dr.GetDecimal("HeSoLuong_T");
        //    if (dr.GetDecimal("HeSoPC") != null) _heSoPC = dr.GetDecimal("HeSoPC");
        //    if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
        //    if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
        //    if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
        //    if (dr.GetDecimal("AnToi") != null) _anToi = dr.GetDecimal("AnToi");
        //    if (dr.GetDecimal("AnTrua") != null) _anTrua = dr.GetDecimal("AnTrua");
        //    if (dr.GetDecimal("HeSoDocHai") != null) _heSoDocHai = dr.GetDecimal("HeSoDocHai");
        //    if (dr.GetDecimal("MucPCBoiDuong") != null) _mucPCBoiDuong = dr.GetDecimal("MucPCBoiDuong");
        //    if (dr.GetDecimal("HeSoPCTrachNhiem") != null) _heSoPCTrachNhiem = dr.GetDecimal("HeSoPCTrachNhiem");
        //    if (dr.GetDecimal("TienNgoaiGio") != null) _tienNgoaiGio = dr.GetDecimal("TienNgoaiGio");
        //    if (dr.GetDecimal("TienPC") != null) _tienPC = dr.GetDecimal("TienPC");
        //    if (dr.GetDecimal("TienTruc") != null) _tienTruc = dr.GetDecimal("TienTruc");
        //    if (dr.GetDecimal("TienLamDem") != null) _tienLamDem = dr.GetDecimal("TienLamDem");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //}
        private Luong_T(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");

            if (dr.GetDecimal("TienLamDem") != null) _tienLamDem = dr.GetDecimal("TienLamDem");
            if (dr.GetDecimal("HoiChan") != null) _hoiChan = dr.GetDecimal("HoiChan");
            if (dr.GetDecimal("HoiChanNV") != null) _hoiChanNV = dr.GetDecimal("HoiChanNV");
            if (dr.GetDecimal("DonGiaHC") != null) _donGiaHC = dr.GetDecimal("DonGiaHC");
            if (dr.GetDecimal("DonGiaHCNV") != null) _donGiaHCNV = dr.GetDecimal("DonGiaHCNV");
            if (dr.GetDecimal("HeSoBDPT") != null) _heSoBDPT = dr.GetDecimal("HeSoBDPT");
            if (dr.GetDecimal("TongTienPT") != null) _tongTienPT = dr.GetDecimal("TongTienPT");
            if (dr.GetDecimal("XQUANGDD") != null) _xQUANGDD = dr.GetDecimal("XQUANGDD");
            if (dr.GetDecimal("TongTienDD") != null) _tongTienDD = dr.GetDecimal("TongTienDD");
            if (dr.GetDecimal("HeSoM2") != null) _heSoM2 = dr.GetDecimal("HeSoM2");
            if (dr.GetDecimal("MucLuongM2") != null) _mucLuongM2 = dr.GetDecimal("MucLuongM2");
            if (dr.GetDecimal("NgoaiGio1") != null) _ngoaiGio1 = dr.GetDecimal("NgoaiGio1");
            if (dr.GetDecimal("NgoaiGio2") != null) _ngoaiGio2 = dr.GetDecimal("NgoaiGio2");
            if (dr.GetDecimal("NgoaiGio3") != null) _ngoaiGio3 = dr.GetDecimal("NgoaiGio3");
            if (dr.GetDecimal("NgoaiGio4") != null) _ngoaiGio4 = dr.GetDecimal("NgoaiGio4");
            if (dr.GetDecimal("HeSoNgoaiGio") != null) _heSoNgoaiGio = dr.GetDecimal("HeSoNgoaiGio");
            if (dr.GetDecimal("ABC") != null) _aBC = dr.GetDecimal("ABC");
            if (dr.GetDecimal("HeSoTT") != null) _heSoTT = dr.GetDecimal("HeSoTT");
            if (dr.GetDecimal("TTDB") != null) _tTDB = dr.GetDecimal("TTDB");
            if (dr.GetDecimal("TT1") != null) _tT1 = dr.GetDecimal("TT1");
            if (dr.GetDecimal("TT2") != null) _tT2 = dr.GetDecimal("TT2");
            if (dr.GetDecimal("TT3") != null) _tT3 = dr.GetDecimal("TT3");

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

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong_T" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_T(_sTT, _thang, _maNV, _makhoa, _tienLamDem, _hoiChan, _hoiChanNV, _donGiaHC, _donGiaHCNV, _heSoBDPT, _tongTienPT, _xQUANGDD, _tongTienDD, _heSoM2, _mucLuongM2, _ngoaiGio1, _ngoaiGio2, _ngoaiGio3, _ngoaiGio4, _heSoNgoaiGio, _aBC, _heSoTT, _tTDB, _tT1, _tT2, _tT3, _maMay, _nguoiSD);
            // public abstract Int32 InsertLuong_T(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _tienLamDem, Decimal _hoiChan, Decimal _hoiChanNV, Decimal _donGiaHC, Decimal _donGiaHCNV, Decimal _heSoBDPT, Decimal _tongTienPT, Decimal _xQUANGDD, Decimal _tongTienDD, Decimal _heSoM2, Decimal _mucLuongM2, Decimal _ngoaiGio1, Decimal _ngoaiGio2, Decimal _ngoaiGio3, Decimal _ngoaiGio4, Decimal _heSoNgoaiGio, Decimal _aBC, Decimal _heSoTT, Decimal _tTDB, Decimal _tT1, Decimal _tT2, Decimal _tT3, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_T(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _tienLamDem, Decimal _hoiChan, Decimal _hoiChanNV, Decimal _donGiaHC, Decimal _donGiaHCNV, Decimal _heSoBDPT, Decimal _tongTienPT, Decimal _xQUANGDD, Decimal _tongTienDD, Decimal _heSoM2, Decimal _mucLuongM2, Decimal _ngoaiGio1, Decimal _ngoaiGio2, Decimal _ngoaiGio3, Decimal _ngoaiGio4, Decimal _heSoNgoaiGio, Decimal _aBC, Decimal _heSoTT, Decimal _tTDB, Decimal _tT1, Decimal _tT2, Decimal _tT3, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_T_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa, _tienLamDem, _hoiChan, _hoiChanNV, _donGiaHC, _donGiaHCNV, _heSoBDPT, _tongTienPT, _xQUANGDD, _tongTienDD, _heSoM2, _mucLuongM2, _ngoaiGio1, _ngoaiGio2, _ngoaiGio3, _ngoaiGio4, _heSoNgoaiGio, _aBC, _heSoTT, _tTDB, _tT1, _tT2, _tT3, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_T" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_T(_sTT, _thang, _maNV, _makhoa, _tienLamDem, _hoiChan, _hoiChanNV, _donGiaHC, _donGiaHCNV, _heSoBDPT, _tongTienPT, _xQUANGDD, _tongTienDD, _heSoM2, _mucLuongM2, _ngoaiGio1, _ngoaiGio2, _ngoaiGio3, _ngoaiGio4, _heSoNgoaiGio, _aBC, _heSoTT, _tTDB, _tT1, _tT2, _tT3, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong_T(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _tienLamDem, Decimal _hoiChan, Decimal _hoiChanNV, Decimal _donGiaHC, Decimal _donGiaHCNV, Decimal _heSoBDPT, Decimal _tongTienPT, Decimal _xQUANGDD, Decimal _tongTienDD, Decimal _heSoM2, Decimal _mucLuongM2, Decimal _ngoaiGio1, Decimal _ngoaiGio2, Decimal _ngoaiGio3, Decimal _ngoaiGio4, Decimal _heSoNgoaiGio, Decimal _aBC, Decimal _heSoTT, Decimal _tTDB, Decimal _tT1, Decimal _tT2, Decimal _tT3, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_T(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _tienLamDem, Decimal _hoiChan, Decimal _hoiChanNV, Decimal _donGiaHC, Decimal _donGiaHCNV, Decimal _heSoBDPT, Decimal _tongTienPT, Decimal _xQUANGDD, Decimal _tongTienDD, Decimal _heSoM2, Decimal _mucLuongM2, Decimal _ngoaiGio1, Decimal _ngoaiGio2, Decimal _ngoaiGio3, Decimal _ngoaiGio4, Decimal _heSoNgoaiGio, Decimal _aBC, Decimal _heSoTT, Decimal _tTDB, Decimal _tT1, Decimal _tT2, Decimal _tT3, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_T_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _tienLamDem, _hoiChan, _hoiChanNV, _donGiaHC, _donGiaHCNV, _heSoBDPT, _tongTienPT, _xQUANGDD, _tongTienDD, _heSoM2, _mucLuongM2, _ngoaiGio1, _ngoaiGio2, _ngoaiGio3, _ngoaiGio4, _heSoNgoaiGio, _aBC, _heSoTT, _tTDB, _tT1, _tT2, _tT3, _maMay, _nguoiSD , _huy);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _sTT, _thang));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="Luong_T" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_T
            DataProvider.Instance().DeleteLuong_T(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_T(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_T(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_T_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
