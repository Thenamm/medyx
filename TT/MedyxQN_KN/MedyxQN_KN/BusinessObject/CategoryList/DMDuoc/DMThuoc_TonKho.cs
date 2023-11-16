// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMThuoc_TonKho
// Kieu doi tuong  :	DMThuoc_TonKho
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
	/// This is a base generated class of <see cref="DMThuoc_TonKho" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMThuoc_TonKho : BusinessBase<DMThuoc_TonKho>
	{
		#region Business Methods
		
		#region State Fields
        private String _duongdung = String.Empty;
        private String _hamluong = String.Empty;
        private String _sovisa = String.Empty;
        private String _matduong = String.Empty;
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
        private String  _TenDVT2;

		#endregion
		
		#region Business Properties and Methods
        public String duongdung
        {
            get
            {
                CanReadProperty("duongdung", true);
                return _duongdung;
            }
            set
            {
                CanWriteProperty("duongdung", true);
                if (_duongdung != value)
                {
                    _duongdung = value;
                    PropertyHasChanged("duongdung");
                }
            }
        }
        public String hamluong
        {
            get
            {
                CanReadProperty("hamluong", true);
                return _hamluong;
            }
            set
            {
                CanWriteProperty("hamluong", true);
                if (_hamluong != value)
                {
                    _hamluong = value;
                    PropertyHasChanged("hamluong");
                }
            }
        }
        public String sovisa
        {
            get
            {
                CanReadProperty("sovisa", true);
                return _sovisa;
            }
            set
            {
                CanWriteProperty("sovisa", true);
                if (_sovisa != value)
                {
                    _sovisa = value;
                    PropertyHasChanged("sovisa");
                }
            }
        }
        public String matduong
        {
            get
            {
                CanReadProperty("matduong", true);
                return _matduong;
            }
            set
            {
                CanWriteProperty("matduong", true);
                if (_matduong != value)
                {
                    _matduong = value;
                    PropertyHasChanged("matduong");
                }
            }
        }
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
        public String TenDVT2
        {
            get
            {
                CanReadProperty("TenDVT2", true);
                return _TenDVT2;
            }
            set
            {
                CanWriteProperty("TenDVT2", true);
                if (_TenDVT2 != value)
                {
                    _TenDVT2 = value;
                    PropertyHasChanged("TenDVT2");
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

        public Decimal TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);

                return _TonCK ;
            }
            set
            {
                CanWriteProperty("TonCK", true);
                if (_TonCK != value)
                {
                    _TonCK = value;
                    PropertyHasChanged("TonCK");
                }
            }
        }
      
        public Decimal TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                return _TonCKDT;
            }
            set
            {
                CanWriteProperty("TonCKDT", true);
                if (_TonCKDT != value)
                {
                    _TonCKDT = value;
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
		/// Factory method. New <see cref="DMThuoc_TonKho" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        //public static DMThuoc_TonKho NewDMThuoc_TonKho()
        //{
        //    //return new DMNhomThuoc();
        //    return DataPortal.Create<DMThuoc_TonKho>();
        //}
        public static DMThuoc_TonKho GetDMThuocTonKho(String maKho, DateTime thang, String maThuoc)
		{
			return DataPortal.Fetch<DMThuoc_TonKho>(new Criteria(maKho, thang , maThuoc));
		}
        public static DMThuoc_TonKho GetDMThuocTonKho(String maKho, String MaDT, DateTime thang, String maThuoc)
        {
            return DataPortal.Fetch<DMThuoc_TonKho>(new CriteriaOther(maKho, MaDT, thang, maThuoc));
        }
		/// <summary>
		/// Marks the <see cref="DMThuoc_TonKho" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMThuoc_TonKho(String maChungLoai)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChungLoai));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMThuoc_TonKho()
		{	
			// Prevent direct creation
		}
        internal DMThuoc_TonKho( 
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
                                  Decimal quydoi, string sovisa, string duongdung, string hamluong, string matduong
        )
                            {
                                _sovisa = sovisa;
                                _duongdung = duongdung;
                                _hamluong = hamluong;
                                _matduong = matduong;
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
                                _quydoi = quydoi;
                               
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
            public Criteria(String maKho, DateTime thang, String maThuoc)
			{
				_maKho = maKho  ;
                _thang = thang ;
                _maThuoc = maThuoc ;
			}
			
           
		}

       
		#endregion
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
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public CriteriaOther(String maKho, String MaDT, DateTime thang, String maThuoc)
            {
                _maKho = maKho;
                _MaDT = MaDT;
                _thang = thang;
                _maThuoc = maThuoc;
            }


        }

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
		/// Retrieve an existing <see cref="DMThuoc_TonKho" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMThuoc_TonKho(String _maChungLoai);
			// public override IDataReader GetDMThuoc_TonKho(String _maChungLoai)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuocTonKho(crit.maKho ,crit.thang ,crit.MaThuoc    )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					//ValidationRules.CheckRules();
				}
			}
		}
        protected void DataPortal_Fetch(CriteriaOther crit)
        {
            // public abstract IDataReader GetDMThuoc_TonKho(String _maChungLoai);
            // public override IDataReader GetDMThuoc_TonKho(String _maChungLoai)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuocTonKho(crit.maKho, crit.MaDT, crit.thang, crit.MaThuoc)))
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
		/// Load a <see cref="DMThuoc_TonKho" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("hamluong") != null) _hamluong = dr.GetString("hamluong");
            if (dr.GetString("sovisa") != null) _sovisa = dr.GetString("sovisa");
            if (dr.GetString("duongdung") != null) _sovisa = dr.GetString("duongdung");
            if (dr.GetString("matduong") != null) _matduong = dr.GetString("matduong");
            if (dr.GetString("MaThuoc") != null) _MaThuoc = dr.GetString("MaThuoc");
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenDVT2") != null) _TenDVT2 = dr.GetString("TenDVT2");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("TenTA") != null) _TenTA = dr.GetString("TenTA");
            if (dr.GetDecimal("DonGiatt") != null) _DonGiaTT =dr.GetDecimal("DonGiatt");
            if (dr.GetDecimal("gianhap")  != null) _GiaNhap = dr.GetDecimal("gianhap");
            if (dr.GetString("Tengoc") != null) _Tengoc =dr.GetString("Tengoc");
            if (dr.GetString("TenNSX") != null) _TenNSX = dr.GetString("TenNSX");
            if (dr.GetString("MaQL") != null) _maQL  = dr.GetString("MaQL");
            if (dr.GetBoolean("Handung") != null) _Handung = dr.GetBoolean("Handung");
            if (dr.GetDecimal("quydoi") != null) _quydoi = dr.GetDecimal("quydoi");
        }
		
		

		#endregion
	}

}
