// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLieuDung
// Kieu doi tuong  :	DMLieuDung
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/3/2009 11:10:50 AM
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
	/// This is a base generated class of <see cref="DMLieuDung" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLieuDung : BusinessBase<DMLieuDung>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maLieuDung = String.Empty;
		private String _tenLieuDung = String.Empty;
		private String _tenTA = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Byte _loai = 0;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private bool _khongsd = false;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaLieuDung
		{
			get 
			{
				CanReadProperty("MaLieuDung", true);
				return _maLieuDung;
			}
			set 
			{
				CanWriteProperty("MaLieuDung", true);
				if (_maLieuDung != value) 
				{
					_maLieuDung = value;
					PropertyHasChanged("MaLieuDung");
				}
			}
		}
		
		public String TenLieuDung
		{
			get 
			{
				CanReadProperty("TenLieuDung", true);
				return _tenLieuDung;
			}
			set 
			{
				CanWriteProperty("TenLieuDung", true);
				if (_tenLieuDung != value) 
				{
					_tenLieuDung = value;
					PropertyHasChanged("TenLieuDung");
				}
			}
		}
		
		public String TenTA
		{
			get 
			{
				CanReadProperty("TenTA", true);
				return _tenTA;
			}
			set 
			{
				CanWriteProperty("TenTA", true);
				if (_tenTA != value) 
				{
					_tenTA = value;
					PropertyHasChanged("TenTA");
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
		
		public Byte Loai
		{
			get 
			{
				CanReadProperty("Loai", true);
				return _loai;
			}
			set 
			{
				CanWriteProperty("Loai", true);
				if (_loai != value) 
				{
					_loai = value;
					PropertyHasChanged("Loai");
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
                    _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";  
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

        public bool  KhongSD
        {
            get
            {
                CanReadProperty("KhongSD", true);
                return _khongsd;
            }
            set
            {
                CanWriteProperty("KhongSD", true);
                if (_khongsd != value)
                {
                    _khongsd = value;
                    PropertyHasChanged("KhongSD");
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
			return _maLieuDung;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenLieuDung", 150));
            ValidationRules.AddRule<DMLieuDung>(StringRequired<DMLieuDung>, "TenLieuDung");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTA", 150));
            //ValidationRules.AddRule<DMLieuDung>(StringRequiredTA<DMLieuDung>, "TenTA");
            ValidationRules.AddRule<DMLieuDung>(NumberRequired<DMLieuDung>, "Loai");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLieuDung
        {

            if (target._tenLieuDung == null || target._tenLieuDung.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        //private static bool StringRequiredTA<T>(T target, Csla.Validation.RuleArgs e) where T : DMLieuDung
        //{

        //    if (target._tenTA == null || target._tenTA.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        private static bool NumberRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLieuDung
        {
            if (Csla.Utilities.IsNumeric(target._loai) == false && target._loai != null)
            {
                e.Description = HTC.ShareVariables.VAR_NUMBERREQUIRED;
                return false;
            }
            
            return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMLieuDung" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLieuDung NewDMLieuDung()
        {
            return DataPortal.Create<DMLieuDung>();
        }
        public static DMLieuDung NewDMLieuDung(byte Loai)
        {
            return DataPortal.Create<DMLieuDung>(new CriteriaNew(Loai));
        }
		public static DMLieuDung GetDMLieuDung(String MaLieuDung)
		{
			return DataPortal.Fetch<DMLieuDung>(new Criteria(MaLieuDung));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLieuDung" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLieuDung(String MaLieuDung, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, MaLieuDung));
		}
        private DMLieuDung(byte Loai)
        {
            _loai = Loai;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLieuDung()
		{	
			// Prevent direct creation
		}
        internal DMLieuDung(      int OrderNumber,
                                 String MaLieuDung ,
		                         String TenLieuDung ,
		                         String tenTA ,
		                         String ghichu ,
		                         String maMay ,
		                         Byte loai ,
                                 bool khongsd,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
                                 String hoten 
                                 )  
    { 

_OrderNumber = OrderNumber ;
                                  _maLieuDung = MaLieuDung ;
		                          _tenLieuDung = TenLieuDung ;
		                          _tenTA = tenTA ;
		                          _ghichu = ghichu ;
		                          _maMay = maMay ;
                                  _khongsd = khongsd;
		                          _loai = loai ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
                                  _hoten = hoten;
    }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maLieuDung;
			public String MaLieuDung 
			{
				get
				{
					return _maLieuDung;
				}
			}
			
			public Criteria(String MaLieuDung)
			{
				_maLieuDung = MaLieuDung;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLieuDung.Equals(c._maLieuDung)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLieuDung.ToString()).GetHashCode();
			}
		}
        protected class CriteriaNew
        {
            

            private byte _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            public CriteriaNew(byte Loai)
            {
               _Loai = Loai;
            }


        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLieuDung;
            public String MaLieuDung
            {
                get
                {
                    return _maLieuDung;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaLieuDung)
            {
                _maLieuDung = MaLieuDung;
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
		/// Retrieve an existing <see cref="DMLieuDung" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLieuDung(String _maLieuDung);
			// public override IDataReader GetDMLieuDung(String _maLieuDung)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLieuDung));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLieuDung(crit.MaLieuDung)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLieuDung" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaLieuDung") != null) _maLieuDung = dr.GetString("MaLieuDung");
			if (dr.GetString("TenLieuDung") != null) _tenLieuDung = dr.GetString("TenLieuDung");
			if (dr.GetString("TenTA") != null) _tenTA = dr.GetString("TenTA");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetBoolean("KhongSD") != null) _khongsd = dr.GetBoolean("KhongSD");

			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLieuDung" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        protected void DataPortal_Create(CriteriaNew param)
        {
            _loai = param.Loai;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLieuDung
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maLieuDung = DataProvider.Instance().InsertDMLieuDung(_tenLieuDung, _tenTA, _ghichu, _maMay, _loai, _nguoiSD );
			// public abstract String InsertDMLieuDung(String _tenLieuDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
			// public override String InsertDMLieuDung(String _tenLieuDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLieuDung_CREATE", _tenLieuDung, _tenTA, _ghichu, _maMay, _loai, _nguoiSD ));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLieuDung" /> Object to underlying database.
		/// </summary>
   		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLieuDung
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMLieuDung(_maLieuDung, _tenLieuDung, _tenTA, _ghichu, _maMay, _loai, _huy,_khongsd , _nguoiSD );
				// public abstract void UpdateDMLieuDung(String _maLieuDung, String _tenLieuDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD);
                // public override void UpdateDMLieuDung(String _maLieuDung, String _tenLieuDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLieuDung_UPDATED", _maLieuDung, _tenLieuDung, _tenTA, _ghichu, _maMay, _loai, _huy, _khongsd, _nguoiSD );
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maLieuDung));
		}

		/// <summary>
		/// Delete the <see cref="DMLieuDung" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLieuDung
            DataProvider.Instance().DeleteDMLieuDung(crit.MaMay, crit.NguoiSD, crit.MaLieuDung);
			// public abstract void DeleteDMLieuDung(String _maLieuDung);
			// public override void DeleteDMLieuDung(String _maLieuDung)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLieuDung_DELETED", _maLieuDung);
			// }
		}

		#endregion
	}

}
