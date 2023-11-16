// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMThuoc_TonKhoHD
// Kieu doi tuong  :	DMThuoc_TonKhoHD
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 11:11:49 AM
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
//


namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMThuoc_TonKhoHD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMThuoc_TonKhoHD : BusinessBase<DMThuoc_TonKhoHD>
	{
		#region Business Methods
		
		#region State Fields

        private Decimal _quydoi = 1;
		private String _MaThuoc = String.Empty;
		private String _TenTM = String.Empty;
        private String _TenDVT = String.Empty;
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
        private String _TenTA = String.Empty;
        private String _Tengoc = String.Empty;
        private Boolean _Handung = false;
        private String _TenNSX = String.Empty;
        private String _maQL = String.Empty;
        private Decimal _DonGiaTT ;
        private Decimal _GiaNhap;
        private int _STT;
        private SmartDate _hanSD = new SmartDate(false);
        private SmartDate _hanSDD = new SmartDate(false);
        private String _soLo = String.Empty;
        private Decimal _nguong = 0;
		#endregion
		
		#region Business Properties and Methods
        public Decimal quydoi
        {
            get
            {
                CanReadProperty("quydoi", true);
                return _quydoi;
            }
            set
            {
                CanWriteProperty("quydoi", true);
                if (_quydoi != value)
                {
                    _quydoi = value;
                    PropertyHasChanged("quydoi");
                }
            }
        }
        public String HanSD
        {
            get
            {
                CanReadProperty("HanSD", true);
            
                return _hanSD.Text;
            }
            set
            {
                CanWriteProperty("HanSD", true);

                if (!_hanSD.Equals(value))
                {
                    //_hanSD.FormatString = "dd/MM/yyyy HH:mm:ss";
                    _hanSD.Text = value;
                    PropertyHasChanged("HanSD");
                }
            }
        }
        public String HanSDD
        {
            get
            {
                CanReadProperty("HanSDd", true);
                _hanSDD = _hanSD; 
                _hanSDD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _hanSDD.Text;
            }
           
        }
        public String SoLo
        {
            get
            {
                CanReadProperty("SoLo", true);
                return _soLo;
            }
            set
            {
                CanWriteProperty("SoLo", true);
                if (_soLo != value)
                {
                    _soLo = value;
                    PropertyHasChanged("SoLo");
                }
            }
        }
        public String MaThuoc
		{
			get 
			{
                CanReadProperty("MaThuoc", true);
                return _MaThuoc;
			}
			set 
			{
                CanWriteProperty("MaThuoc", true);
                if (_MaThuoc != value) 
				{
                    _MaThuoc = value;
                    PropertyHasChanged("MaThuoc");
				}
			}
		}

        public String TenDVT
		{
			get 
			{
                CanReadProperty("TenDVT", true);
                return _TenDVT;
			}
			set 
			{
                CanWriteProperty("TenDVT", true);
                if (_TenDVT != value) 
				{
                    _TenDVT = value;
                    PropertyHasChanged("TenDVT");
				}
			}
		}

        public String TenTA
        {
            get
            {
                CanReadProperty("TenTA", true);
                return _TenTA;
            }
            set
            {
                CanWriteProperty("TenTA", true);
                if (_TenTA != value)
                {
                    _TenTA = value;
                    PropertyHasChanged("TenTA");
                }
            }
        }

        public String TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_TonCK == 0)
                    return "0";
                else if (_TonCK - (int)(_TonCK) != 0)
                {
                    return _TonCK.ToString("###,###.###");
                }
                else
                    return _TonCK.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCK", true);
                if (_TonCK.ToString() != value)
                {
                    if (value == "")
                        _TonCK = 0;
                    else
                    _TonCK = decimal.Parse(value);
                    PropertyHasChanged("TonCK");
                }
            }
        }
        public Decimal Nguong
        {
            get
            {
                CanReadProperty("nguong", true);
                return _nguong;
            }
            set
            {
                CanWriteProperty("nguong", true);
                if (_nguong != value)
                {
                    _nguong = value;
                    PropertyHasChanged("nguong");
                }
            }
        }

        public String TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                if (_TonCKDT == 0)
                    return "0";
                else if (_TonCKDT - (int)(_TonCKDT) != 0)
                {
                    return _TonCKDT.ToString("###,###.###");
                }
                else
                return _TonCKDT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCKDT", true);
                if (_TonCKDT.ToString() != value)
                {
                    if (value == "")
                        _TonCKDT = 0;
                    else
                    _TonCKDT = decimal.Parse(value);
                    PropertyHasChanged("TonCKDT");
                }
            }
        }

        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _TenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_TenTM != value)
                {
                    _TenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
        public String TenGoc
        {
            get
            {
                CanReadProperty("TenGoc", true);
                return _Tengoc;
            }
            set
            {
                CanWriteProperty("TenGoc", true);
                if (_Tengoc != value)
                {
                    _Tengoc = value;
                    PropertyHasChanged("TenGoc");
                }
            }
        }
        public Decimal DonGiaTT
        {
            get
            {
                CanReadProperty("DonGiaTT", true);
                return _DonGiaTT;
            }
            set
            {
                CanWriteProperty("DonGiaTT", true);
                if (_DonGiaTT != value)
                {
                    _DonGiaTT = value;
                    PropertyHasChanged("DonGiaTT");
                }
            }
        }
        public Decimal GiaNhap
        {
            get
            {
                CanReadProperty("GiaNhap", true);
                return _GiaNhap;
            }
            set
            {
                CanWriteProperty("GiaNhap", true);
                if (_GiaNhap != value)
                {
                    _GiaNhap = value;
                    PropertyHasChanged("GiaNhap");
                }
            }
        }
        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _Handung;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_Handung != value)
                {
                    _Handung = value;
                    PropertyHasChanged("Handung");
                }
            }
        }

        public String TenNSX
        {
            get
            {
                CanReadProperty("TenNSX", true);
                return _TenNSX;
            }
            set
            {
                CanWriteProperty("TenNSX", true);
                if (_TenNSX != value)
                {
                    _TenNSX = value;
                    PropertyHasChanged("TenNSX");
                }
            }
        }
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_maQL != value)
                {
                    _maQL = value;
                    PropertyHasChanged("MaQL");
                }
            }
        }

        public int STT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _STT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_STT.Equals(value))
                {
                    _STT = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _MaThuoc;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMThuoc_TonKhoHD" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        //public static DMThuoc_TonKhoHD NewDMThuoc_TonKhoHD()
        //{
        //    //return new DMNhomThuoc();
        //    return DataPortal.Create<DMThuoc_TonKhoHD>();
        //}
        public static DMThuoc_TonKhoHD GetDMThuocTonKho(String maKho, DateTime thang, String maThuoc)
		{
			return DataPortal.Fetch<DMThuoc_TonKhoHD>(new Criteria(maKho, thang , maThuoc,"",DateTime.Parse("01/01/1900")  ));
		}
        public static DMThuoc_TonKhoHD GetDMThuocTonKho(String maKho, DateTime thang, String maThuoc,string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHD>(new Criteria(maKho, thang, maThuoc,solo,hansd ));
        }
        public static DMThuoc_TonKhoHD GetDMThuocTonKho(String maKho, String MaDT, DateTime thang, String maThuoc)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHD>(new CriteriaOther(maKho, MaDT, thang, maThuoc, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHD GetDMThuocTonKho(String maKho, String MaDT, DateTime thang, String maThuoc, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHD>(new CriteriaOther(maKho, MaDT, thang, maThuoc, solo, hansd));
        }
		/// <summary>
		/// Marks the <see cref="DMThuoc_TonKhoHD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMThuoc_TonKhoHD(String maChungLoai)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChungLoai));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMThuoc_TonKhoHD()
		{	
			// Prevent direct creation
		}
        internal DMThuoc_TonKhoHD( 
  int STT,
  String MaThuoc ,
		                             String TenTM ,
  String TenDVT ,
  Decimal TonCK,
  Decimal TonCKDT,
  String TenTA ,
  Boolean Handung ,
  String TenNSX ,
  String MaQL,
  Decimal donGiaTT ,
  Decimal Gianhap,
  String Tengoc,
  string solo,
  SmartDate hansd,
                                  Decimal quydoi,
 Decimal nguong
        )
                            {
                                _MaThuoc = MaThuoc ;
		                        _TenTM = TenTM;
                                _TenDVT = TenDVT ;
                                _TonCK = TonCK  ;
                                _TonCKDT = TonCKDT   ;
                                _TenTA = TenTA  ;
                                _Handung = Handung  ;
                                _TenNSX = TenNSX  ;
                                _maQL = MaQL;
                                _STT = STT ;
                                _DonGiaTT =donGiaTT ;
                                _GiaNhap =Gianhap ;
                                _Tengoc = Tengoc;
                                _soLo = solo;
                                _hanSD = hansd;
                                _quydoi = quydoi;
                                _nguong = nguong;
                            }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKho;
			public String maKho
			{
				get
				{
                    return _maKho;
				}
			}

            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang;
                }
            }
            private String _maThuoc;
            public String MaThuoc
            {
                get
                {
                    return _maThuoc;
                }
            }
            private DateTime _hansd;
            public DateTime hansd
            {
                get
                {
                    return _hansd;
                }
            }
            private String _solo;
            public String solo
            {
                get
                {
                    return _solo;
                }
            }
            public Criteria(String maKho, DateTime thang, String maThuoc, string solo, DateTime hansd)
			{
				_maKho = maKho  ;
                _thang = thang ;
                _maThuoc = maThuoc ;
                _solo = solo;
                _hansd = hansd;
			}
			
           
		}

       
		#endregion
        #region CriteriaOther

        [Serializable()]
        protected class CriteriaOther
        {
            private String _maKho;
            public String maKho
            {
                get
                {
                    return _maKho;
                }
            }

            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang;
                }
            }
            private String _maThuoc;
            public String MaThuoc
            {
                get
                {
                    return _maThuoc;
                }
            }
            private DateTime _hansd;
            public DateTime hansd
            {
                get
                {
                    return _hansd;
                }
            }
            private String _solo;
            public String solo
            {
                get
                {
                    return _solo;
                }
            }
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }

            public CriteriaOther(String maKho, String MaDT, DateTime thang, String maThuoc, string solo, DateTime hansd)
            {
                _maKho = maKho;
                _MaDT = MaDT;
                _thang = thang;
                _maThuoc = maThuoc;
                _solo = solo;
                _hansd = hansd;
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
		/// Retrieve an existing <see cref="DMThuoc_TonKhoHD" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMThuoc_TonKhoHD(String _maChungLoai);
			// public override IDataReader GetDMThuoc_TonKhoHD(String _maChungLoai)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
			// }

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuocTonKhoHD(crit.maKho, crit.thang, crit.MaThuoc, crit.solo, crit.hansd)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					//ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMThuoc_TonKhoHD" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
       
            if (dr.GetString("MaThuoc") != null) _MaThuoc = dr.GetString("MaThuoc");
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("TenTA") != null) _TenTA = dr.GetString("TenTA");
            if (dr.GetDecimal("DonGiatt") != null) _DonGiaTT =dr.GetDecimal("DonGiatt");
            if (dr.GetDecimal("gianhap")  != null) _GiaNhap = dr.GetDecimal("gianhap");
            if (dr.GetString("Tengoc") != null) _Tengoc =dr.GetString("Tengoc");
            if (dr.GetString("TenNSX") != null) _TenNSX = dr.GetString("TenNSX");
            if (dr.GetString("MaQL") != null) _maQL  = dr.GetString("MaQL");
            if (dr.GetBoolean("Handung") != null) _Handung = dr.GetBoolean("Handung");
            if (dr.GetSmartDate("HanSD", false) != null) _hanSD = dr.GetSmartDate("HanSD", false);
            if (dr.GetString("SoLo") != null) _soLo = dr.GetString("SoLo");
            if (dr.GetDecimal("quydoi") != null) _quydoi = dr.GetDecimal("quydoi");
            if (dr.GetDecimal("nguong") != null) _nguong = dr.GetDecimal("nguong");
        }

        protected void DataPortal_Fetch(CriteriaOther crit)
        {
            // public abstract IDataReader GetDMThuoc_TonKhoHD(String _maChungLoai);
            // public override IDataReader GetDMThuoc_TonKhoHD(String _maChungLoai)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
            // }

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuocTonKhoHD(crit.maKho, crit.MaDT, crit.thang, crit.MaThuoc, crit.solo, crit.hansd)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    //ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="DMThuoc_TonKhoHD" /> Object from given SafeDataReader.
        /// </summary>
        

		#endregion
	}

}
