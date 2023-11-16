// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTBVTYT_TonKhoHD
// Kieu doi tuong  :	DMTBVTYT_TonKhoHD
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
	/// This is a base generated class of <see cref="DMTBVTYT_TonKhoHD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTBVTYT_TonKhoHD : BusinessBase<DMTBVTYT_TonKhoHD>
	{
		#region Business Methods
		
		#region State Fields

        
		private String _MaVT = String.Empty;
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
        public String MaVT
		{
			get 
			{
                CanReadProperty("MaVT", true);
                return _MaVT;
			}
			set 
			{
                CanWriteProperty("MaVT", true);
                if (_MaVT != value) 
				{
                    _MaVT = value;
                    PropertyHasChanged("MaVT");
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
			return _MaVT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTBVTYT_TonKhoHD" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        //public static DMTBVTYT_TonKhoHD NewDMTBVTYT_TonKhoHD()
        //{
        //    //return new DMNhomThuoc();
        //    return DataPortal.Create<DMTBVTYT_TonKhoHD>();
        //}
        public static DMTBVTYT_TonKhoHD GetDMTBVTYTTonKho(String maKho, DateTime thang, String MaVT)
		{
			return DataPortal.Fetch<DMTBVTYT_TonKhoHD>(new Criteria(maKho, thang , MaVT,"",DateTime.Parse("01/01/1900")  ));
		}
        public static DMTBVTYT_TonKhoHD GetDMTBVTYTTonKho(String maKho, DateTime thang, String MaVT,string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMTBVTYT_TonKhoHD>(new Criteria(maKho, thang, MaVT,solo,hansd ));
        }
		/// <summary>
		/// Marks the <see cref="DMTBVTYT_TonKhoHD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMTBVTYT_TonKhoHD(String maChungLoai)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChungLoai));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTBVTYT_TonKhoHD()
		{	
			// Prevent direct creation
		}
        internal DMTBVTYT_TonKhoHD( 
  int STT,
  String MaVT ,
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
 // String Tengoc,
  string solo,
  SmartDate hansd,
  Decimal nguong   
        )       
                            {
                                _MaVT = MaVT ;
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
                               // _Tengoc = Tengoc;
                                _soLo = solo;
                                _hanSD = hansd;
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
            private String _MaVT;
            public String MaVT
            {
                get
                {
                    return _MaVT;
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
            public Criteria(String maKho, DateTime thang, String MaVT, string solo, DateTime hansd)
			{
				_maKho = maKho  ;
                _thang = thang ;
                _MaVT = MaVT ;
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
		/// Retrieve an existing <see cref="DMTBVTYT_TonKhoHD" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTBVTYT_TonKhoHD(String _maChungLoai);
			// public override IDataReader GetDMTBVTYT_TonKhoHD(String _maChungLoai)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
			// }

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTBVTYTTonKhoHD(crit.maKho, crit.thang, crit.MaVT, crit.solo, crit.hansd)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					//ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTBVTYT_TonKhoHD" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
       
            if (dr.GetString("MaVT") != null) _MaVT = dr.GetString("MaVT");
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("TenTA") != null) _TenTA = dr.GetString("TenTA");
            if (dr.GetDecimal("DonGiatt") != null) _DonGiaTT =dr.GetDecimal("DonGiatt");
            if (dr.GetDecimal("gianhap")  != null) _GiaNhap = dr.GetDecimal("gianhap");
            //if (dr.GetString("Tengoc") != null) _Tengoc =dr.GetString("Tengoc");
            if (dr.GetString("TenNSX") != null) _TenNSX = dr.GetString("TenNSX");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetBoolean("Handung") != null) _Handung = dr.GetBoolean("Handung");
            if (dr.GetSmartDate("HanSD", false) != null) _hanSD = dr.GetSmartDate("HanSD", false);
            if (dr.GetString("SoLo") != null) _soLo = dr.GetString("SoLo");
            if (dr.GetDecimal("nguong") != null) _nguong = dr.GetDecimal("nguong");
        }
		
		

		#endregion
	}

}
