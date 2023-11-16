// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHoaChat_TonKho
// Kieu doi tuong  :	DMHoaChat_TonKho
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
	/// This is a base generated class of <see cref="DMHoaChat_TonKho" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMHoaChat_TonKho : BusinessBase<DMHoaChat_TonKho>
	{
		#region Business Methods
		
		#region State Fields

        
		private String _MaHC = String.Empty;
		private String _TenTM = String.Empty;
        private String _TenDVT = String.Empty;
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
        private String _TenTA = String.Empty;
        private String _Tengoc = String.Empty;
        private Boolean _Handung = false;
        private String _TenNSX = String.Empty;
        private Decimal _DonGiaTT ;
        private Decimal _GiaNhap;
        private int _STT;

		#endregion
		
		#region Business Properties and Methods

        public String MaHC
		{
			get 
			{
                CanReadProperty("MaHC", true);
                return _MaHC;
			}
			set 
			{
                CanWriteProperty("MaHC", true);
                if (_MaHC != value) 
				{
                    _MaHC = value;
                    PropertyHasChanged("MaHC");
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
			return _MaHC;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMHoaChat_TonKho" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        //public static DMHoaChat_TonKho NewDMHoaChat_TonKho()
        //{
        //    //return new DMNhomThuoc();
        //    return DataPortal.Create<DMHoaChat_TonKho>();
        //}
        public static DMHoaChat_TonKho GetDMHoaChatTonKho(String maKho, DateTime thang, String MaHC)
		{
			return DataPortal.Fetch<DMHoaChat_TonKho>(new Criteria(maKho, thang , MaHC));
		}
		
		/// <summary>
		/// Marks the <see cref="DMHoaChat_TonKho" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMHoaChat_TonKho(String maChungLoai)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChungLoai));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMHoaChat_TonKho()
		{	
			// Prevent direct creation
		}
        internal DMHoaChat_TonKho( 
  int STT,
  String MaHC ,
		                             String TenTM ,
  String TenDVT ,
  Decimal TonCK,
  Decimal TonCKDT,
  String TenTA ,
  Boolean Handung ,
  String TenNSX ,
  Decimal donGiaTT ,
  Decimal Gianhap
 // String Tengoc
        )
                            {
                                _MaHC = MaHC ;
		                        _TenTM = TenTM;
                                _TenDVT = TenDVT ;
                                _TonCK = TonCK  ;
                                _TonCKDT = TonCKDT   ;
                                _TenTA = TenTA  ;
                                _Handung = Handung  ;
                                _TenNSX = TenNSX  ;
                                _STT = STT ;
                                _DonGiaTT =donGiaTT ;
                                _GiaNhap =Gianhap ;
                               // _Tengoc = Tengoc;
                               
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
            private String _MaHC;
            public String MaHC
            {
                get
                {
                    return _MaHC;
                }
            }
            public Criteria(String maKho, DateTime thang, String MaHC)
			{
				_maKho = maKho  ;
                _thang = thang ;
                _MaHC = MaHC ;
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
		/// Retrieve an existing <see cref="DMHoaChat_TonKho" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMHoaChat_TonKho(String _maChungLoai);
			// public override IDataReader GetDMHoaChat_TonKho(String _maChungLoai)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHoaChatTonKho(crit.maKho ,crit.thang ,crit.MaHC    )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					//ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMHoaChat_TonKho" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
       
            if (dr.GetString("MaHC") != null) _MaHC = dr.GetString("MaHC");
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("TenTA") != null) _TenTA = dr.GetString("TenTA");
            if (dr.GetDecimal("DonGiatt") != null) _DonGiaTT =dr.GetDecimal("DonGiatt");
            if (dr.GetDecimal("gianhap")  != null) _GiaNhap = dr.GetDecimal("gianhap");
            //if (dr.GetString("Tengoc") != null) _Tengoc =dr.GetString("Tengoc");
            if (dr.GetString("TenNSX") != null) _TenNSX = dr.GetString("TenNSX");
            if (dr.GetBoolean("Handung") != null) _Handung = dr.GetBoolean("Handung");
        }
		
		

		#endregion
	}

}
