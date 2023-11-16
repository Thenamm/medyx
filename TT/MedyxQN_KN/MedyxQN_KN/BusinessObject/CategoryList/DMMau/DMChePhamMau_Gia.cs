// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChePhamMau_Gia
// Kieu doi tuong  :	DMChePhamMau_Gia
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/15/2008 9:51:22 AM
// Nguoi tao       :	NVT
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMChePhamMau_Gia" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMChePhamMau_Gia : BusinessBase<DMChePhamMau_Gia>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDT = String.Empty;
        private String _tenDT = String.Empty;
        private Decimal _STT = 0;
        private String _maCPMau = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private Decimal _dongia = 0;
        private Decimal _giachenhlech = 0;
        private Boolean _aDChenhlech = false;
        private Boolean _DTBH = false;
        private Byte _aDPhongMo = 0;
        private Decimal _donGia1 = 0;
        private Decimal _giachenhlech1 = 0;
        private DateTime _ngay1 = DateTime.Now;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(false);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(false);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(false);
        private String _nguoiSD1 = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;  	
		private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public Decimal DonGiaBH
        {
            get;
            set;
        }
        public Decimal DonGiaBH1
        {
            get;
            set;
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


        public Decimal STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _STT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_STT != value)
                {
                    _STT = value;
                    PropertyHasChanged("STT");
                }
            }
        }

        public String MaCPMau
		{
			get 
			{
                CanReadProperty("MaCPMau", true);
                return _maCPMau;
			}
			set 
			{
                CanWriteProperty("MaCPMau", true);
                if (_maCPMau != value) 
				{
                    _maCPMau = value;
                    PropertyHasChanged("MaCPMau");
				}
			}
		}
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT  != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
       
        //public Decimal Dongia
        //{
        //    get
        //    {
        //        CanReadProperty("Dongia", true);
        //        return _dongia ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Dongia", true);
        //        if (_dongia  != value)
        //        {
        //            _dongia  = value;
        //            PropertyHasChanged("Dongia");
        //        }
        //    }
        //}
        public string Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                if (_dongia == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongia.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Dongia", true);

                if (_dongia.ToString() != value)
                {
                    _dongia = decimal.Parse(value);
                    PropertyHasChanged("Dongia");
                }
            }
        }


        //public Decimal GiaChenhLech
        //{
        //    get
        //    {
        //        CanReadProperty("GiaChenhLech", true);
        //        return _giachenhlech;
        //    }
        //    set
        //    {
        //        CanWriteProperty("GiaChenhLech", true);
        //        if (_giachenhlech != value)
        //        {
        //            _giachenhlech = value;
        //            PropertyHasChanged("GiaChenhLech");
        //        }
        //    }
        //}
        public string GiaChenhLech
        {
            get
            {
                CanReadProperty("GiaChenhLech", true);
                if (_giachenhlech == 0)
                {
                    return "0";
                }
                else
                {
                    return _giachenhlech.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhLech", true);

                if (_giachenhlech.ToString() != value)
                {
                    _giachenhlech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhLech");
                }
            }
        }


        public Boolean ADChenhLech
        {
            get
            {
                CanReadProperty("ADChenhLech", true);
                return _aDChenhlech;
            }
            set
            {
                CanWriteProperty("ADChenhLech", true);
                if (_aDChenhlech != value)
                {
                    _aDChenhlech = value;
                    PropertyHasChanged("ADChenhLech");
                }
            }
        }

        public Boolean DTBH
        {
            get
            {
                CanReadProperty("DTBH", true);
                return _DTBH;
            }
            set
            {
                CanWriteProperty("DTBH", true);
                if (_DTBH != value)
                {
                    _DTBH = value;
                    PropertyHasChanged("DTBH");
                }
            }
        }

        public Byte ADPhongmo
        {
            get
            {
                CanReadProperty("ADPhongmo", true);
                return _aDPhongMo;
            }
            set
            {
                CanWriteProperty("ADPhongmo", true);
                if (_aDPhongMo != value)
                {
                    _aDPhongMo = value;
                    PropertyHasChanged("ADPhongmo");
                }
            }
        }

		public Decimal DonGia1
		{
			get 
			{
				CanReadProperty("DonGia1", true);
				return _donGia1;
			}
			set 
			{
				CanWriteProperty("DonGia1", true);
				if (_donGia1 != value) 
				{
					_donGia1 = value;
					PropertyHasChanged("DonGia1");
				}
			}
		}

        public Decimal GiaChenhLech1
        {
            get
            {
                CanReadProperty("GiaChenhLech1", true);
                return _giachenhlech1;
            }
            set
            {
                CanWriteProperty("GiaChenhLech1", true);
                if (_giachenhlech1 != value)
                {
                    _giachenhlech1 = value;
                    PropertyHasChanged("GiaChenhLech1");
                }
            }
        }


        public DateTime Ngay1
        {
            get
            {
                return _ngay1;
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
		
		
        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayLap;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap != value)
                {
                    _ngayLap = value;
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

        public SmartDate NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayHuy;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy != value)
                {
                    _ngayHuy = value;
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

        public SmartDate NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                _ngaySD1.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD1;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1 != value)
                {
                    _ngaySD1 = value;
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

        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
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

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
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
			return _maDT.ToString() + "!" + _maCPMau .ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMChePhamMau_Gia" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMChePhamMau_Gia NewDMChePhamMau_Gia()
        {
            return new DMChePhamMau_Gia();
        }
        //public static DMChePhamMau_Gia GetDMChePhamMau_Gia(String maDT, String maThuoc)
        //{
        //    return DataPortal.Fetch<DMChePhamMau_Gia>(new Criteria(maDT, maThuoc));
        //}
        internal static DMChePhamMau_Gia GetDMChePhamMau_Gia(SafeDataReader dr)
        {
            return new DMChePhamMau_Gia (dr);
        }
         public DMChePhamMau_Gia()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="DMChePhamMau_Gia" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMChePhamMau_Gia(String maDT, Decimal  sTT)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDT, sTT));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal DMChePhamMau_Gia()
        //{	
        //    // Prevent direct creation
        //}
        //internal DMChePhamMau_Gia( int ordernumber, 
        //                     String maDT,
        //                     Decimal STT,
        //                     String maThuoc ,
        //                     String tenThuoc,
        //                     Decimal donGiaBH ,
        //                     Decimal donGiaThuT ,
        //                     Decimal donGiaPhauT ,
        //                     Decimal donGiaCLS ,
        //                     Decimal giachenhlech ,
        //                     Boolean aDChenhlech ,
        //                     Boolean DTBH ,
        //                     Boolean aDPhongMo,
        //                     Decimal donGia1 ,
        //                     Decimal giachenhlech1 ,
        //                     SmartDate ngay1 ,
        //                     String ghichu ,
        //                     String maMay ,
        //                     Boolean huy ,
        //                     SmartDate ngayLap ,
        //                     String nguoiLap ,
        //                     SmartDate ngayHuy ,
        //                     String nguoiHuy,
        //                     SmartDate ngaySD1 ,
        //                     String nguoiSD1 ,
        //                     SmartDate ngaySD ,
        //                     String nguoiSD )
        //                {
        //                   _OrderNumber = ordernumber;
        //                    _maDT  = maDT;
        //                    _STT  =  STT ;  
        //                    _maThuoc  = maThuoc ;
        //                    _tenThuoc = tenThuoc ;
        //                    _donGiaBH  = donGiaBH ;
        //                    _donGiaThuT  = donGiaThuT ;
        //                    _donGiaPhauT  = donGiaPhauT ;
        //                    _donGiaCLS = donGiaCLS ;
        //                     _giachenhlech = giachenhlech; 
        //                     _aDChenhlech = aDChenhlech ;
        //                     _DTBH = DTBH ;
        //                     _aDPhongMo = aDPhongMo;
        //                     _donGia1 = donGia1 ;
        //                     _giachenhlech1 = giachenhlech1 ;
        //                     _ngay1 = ngay1 ;
        //                     _ghichu = ghichu ;
        //                     _maMay = maMay ;
        //                     _huy = huy ;
        //                     _ngayLap = ngayLap ;
        //                     _nguoiLap = nguoiLap ;
        //                     _ngayHuy = ngayHuy ;
        //                     _nguoiHuy = nguoiHuy;
        //                     _ngaySD1 = ngaySD1 ;
        //                     _nguoiSD1 = nguoiSD1 ;
        //                    _ngaySD = ngaySD ;
        //                    _nguoiSD  = nguoiSD; 
        //                }
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDT;
			public String MaDT 
			{
				get
				{
					return _maDT;
				}
			}

            private String _maCPMau;
            public String MaCPMau 
			{
				get
				{
					return _maCPMau ;
				}
			}
			
			public Criteria(String maDT, String maCPMau)
			{
				_maDT = maDT;
				_maCPMau  = maCPMau ;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDT.Equals(c._maDT)) 
						return false;
					if (!_maCPMau .Equals(c._maCPMau )) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDT.ToString(), _maCPMau .ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
                }
            }

            private Decimal  _STT;
            public Decimal STT
            {
                get
                {
                    return _STT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDT, Decimal sTT)
            {
                _maDT = maDT;
                _STT = sTT ;
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
		/// Retrieve an existing <see cref="DMChePhamMau_Gia" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetDMChePhamMau_Gia(String _maDT, String _maThuoc);
        //    // public override IDataReader GetDMChePhamMau_Gia(String _maDT, String _maThuoc)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maThuoc));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChePhamMau_Gia(crit.MaDT, crit.MaThuoc)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="DMChePhamMau_Gia" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        //    if (dr.GetDecimal("STT") != null) _STT = dr.GetDecimal("STT");
        //    if (dr.GetString("MaThuoc") != null) _maThuoc = dr.GetString("MaThuoc");
        //    if (dr.GetString("TenThuoc") != null) _tenThuoc = dr.GetString("TenThuoc");
        //    if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
        //    if (dr.GetDecimal("DonGiaThuT") != null) _donGiaThuT = dr.GetDecimal("DonGiaThuT");
        //    if (dr.GetDecimal("DonGiaPhauT") != null) _donGiaPhauT = dr.GetDecimal("DonGiaPhauT");
        //    if (dr.GetDecimal("DonGiaCLS") != null) _donGiaCLS = dr.GetDecimal("DonGiaCLS");
        //    if (dr.GetDecimal("GiaChenhLech") != null) _giachenhlech = dr.GetDecimal("GiaChenhLech");
        //    if (dr.GetBoolean("ADChenhLech") != null) _aDChenhlech = dr.GetBoolean("ADChenhLech");
        //    if (dr.GetBoolean("DTBH") != null) _DTBH = dr.GetBoolean("DTBH");
        //    if (dr.GetBoolean("ADPhongMo") != null) _aDPhongMo = dr.GetBoolean("ADPhongMo");
        //    if (dr.GetDecimal("DonGia1") != null) _donGia1 = dr.GetDecimal("DonGia1");
        //    if (dr.GetDecimal("GiachenhLech1") != null) _giachenhlech1 = dr.GetDecimal("GiachenhLech1");
        //    if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayLap", false) != null) _ngayLap = dr.GetSmartDate("NgayLap", false);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", false) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", false);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD1", false) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", false);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
		  private  DMChePhamMau_Gia(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
                if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
                if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetDecimal("STT") != null) _STT = dr.GetDecimal("STT");
            if (dr.GetString("MaCPMau") != null) _maCPMau = dr.GetString("MaCPMau");
            if (dr.GetString("TenTM") != null) _tenTM  = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _tenDVT  = dr.GetString("TenDVT");
            if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
            if (dr.GetDecimal("GiaChenhLech") != null) _giachenhlech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetBoolean("ADChenhLech") != null) _aDChenhlech = dr.GetBoolean("ADChenhLech");
            if (dr.GetBoolean("DTBH") != null) _DTBH = dr.GetBoolean("DTBH");
            if (dr.GetByte("ADPhongMo") != null) _aDPhongMo = dr.GetByte("ADPhongMo");
            if (dr.GetDecimal("DonGia1") != null) _donGia1 = dr.GetDecimal("DonGia1");
            if (dr.GetDecimal("GiachenhLech1") != null) _giachenhlech1 = dr.GetDecimal("GiachenhLech1");
            //if (dr.GetDateTime("Ngay1", true) != null) _ngay1 = dr.GetDateTime("Ngay1", true);
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap", false) != null) _ngayLap = dr.GetSmartDate("NgayLap", false);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", false) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", false);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", false) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", false);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="DMChePhamMau_Gia" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChePhamMau_Gia
			// Copy & paste ham duoi day vao file DataProvider.cs
              
              
            //_maDT = 
                DataProvider.Instance().InsertDMChePhamMau_Gia(_maDT, _maCPMau , _dongia , _giachenhlech , _aDChenhlech, _DTBH, _aDPhongMo, _ghichu, _maMay, _nguoiSD);
			// public abstract String InsertDMChePhamMau_Gia(String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMChePhamMau_Gia(String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maThuoc, _donGiaBH, _donGiaBH1, _ngayBH1.DBValue, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMChePhamMau_Gia" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateDMChePhamMau_Gia(_maDT,_STT,  _maCPMau ,_dongia , _giachenhlech , _aDChenhlech , _DTBH, _aDPhongMo, _ghichu, _maMay, _nguoiSD ,_huy );
				// public abstract void UpdateDMChePhamMau_Gia(String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMChePhamMau_Gia(String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maThuoc, _donGiaBH, _donGiaBH1, _ngayBH1.DBValue, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDT, _STT));
            MarkNew();
        }
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChePhamMau_Gia
            DataProvider.Instance().DeleteDMChePhamMau_Gia(crit.MaMay, crit.NguoiSD, crit.MaDT, crit.STT);
			// public abstract void DeleteDMChePhamMau_Gia(String _maDT, String _maThuoc);
			// public override void DeleteDMChePhamMau_Gia(String _maDT, String _maThuoc);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maThuoc);
			// }
		}

		#endregion
	}

}
