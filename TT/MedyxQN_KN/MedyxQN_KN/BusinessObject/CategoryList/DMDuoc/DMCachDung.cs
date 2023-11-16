// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMCachDung
// Kieu doi tuong  :	DMCachDung
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
	/// This is a base generated class of <see cref="DMCachDung" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMCachDung : BusinessBase<DMCachDung>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maCachDung = String.Empty;
		private String _tenCachDung = String.Empty;
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
		
		public String MaCachDung
		{
			get 
			{
				CanReadProperty("MaCachDung", true);
				return _maCachDung;
			}
			set 
			{
				CanWriteProperty("MaCachDung", true);
				if (_maCachDung != value) 
				{
					_maCachDung = value;
					PropertyHasChanged("MaCachDung");
				}
			}
		}
		
		public String TenCachDung
		{
			get 
			{
				CanReadProperty("TenCachDung", true);
				return _tenCachDung;
			}
			set 
			{
				CanWriteProperty("TenCachDung", true);
				if (_tenCachDung != value) 
				{
					_tenCachDung = value;
					PropertyHasChanged("TenCachDung");
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
			return _maCachDung;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenCachDung", 150));
            ValidationRules.AddRule<DMCachDung>(StringRequired<DMCachDung>, "TenCachDung");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTA", 150));
            //ValidationRules.AddRule<DMCachDung>(StringRequiredTA<DMCachDung>, "TenTA");
            ValidationRules.AddRule<DMCachDung>(NumberRequired<DMCachDung>, "Loai");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMCachDung
        {

            if (target._tenCachDung == null || target._tenCachDung.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        //private static bool StringRequiredTA<T>(T target, Csla.Validation.RuleArgs e) where T : DMCachDung
        //{

        //    if (target._tenTA == null || target._tenTA.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        private static bool NumberRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMCachDung
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
		/// Factory method. New <see cref="DMCachDung" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMCachDung NewDMCachDung()
        {
            return DataPortal.Create<DMCachDung>();
        }
        public static DMCachDung NewDMCachDung(byte Loai)
        {
            return DataPortal.Create<DMCachDung>(new CriteriaNew(Loai));
        }
		public static DMCachDung GetDMCachDung(String MaCachDung)
		{
			return DataPortal.Fetch<DMCachDung>(new Criteria(MaCachDung));
		}
		
		/// <summary>
		/// Marks the <see cref="DMCachDung" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMCachDung(String MaCachDung, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, MaCachDung));
		}
        private DMCachDung(byte Loai)
        {
            _loai = Loai;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMCachDung()
		{	
			// Prevent direct creation
		}
        internal DMCachDung(      int OrderNumber,
                                 String MaCachDung ,
		                         String TenCachDung ,
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
                                  _maCachDung = MaCachDung ;
		                          _tenCachDung = TenCachDung ;
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
			private String _maCachDung;
			public String MaCachDung 
			{
				get
				{
					return _maCachDung;
				}
			}
			
			public Criteria(String MaCachDung)
			{
				_maCachDung = MaCachDung;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maCachDung.Equals(c._maCachDung)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maCachDung.ToString()).GetHashCode();
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
            private String _maCachDung;
            public String MaCachDung
            {
                get
                {
                    return _maCachDung;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaCachDung)
            {
                _maCachDung = MaCachDung;
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
		/// Retrieve an existing <see cref="DMCachDung" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMCachDung(String _maCachDung);
			// public override IDataReader GetDMCachDung(String _maCachDung)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCachDung));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMCachDung(crit.MaCachDung)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMCachDung" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaCachDung") != null) _maCachDung = dr.GetString("MaCachDung");
			if (dr.GetString("TenCachDung") != null) _tenCachDung = dr.GetString("TenCachDung");
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
		/// Insert the new <see cref="DMCachDung" /> Object to underlying database.
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
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMCachDung
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maCachDung = DataProvider.Instance().InsertDMCachDung(_tenCachDung, _tenTA, _ghichu, _maMay, _loai, _nguoiSD );
			// public abstract String InsertDMCachDung(String _tenCachDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
			// public override String InsertDMCachDung(String _tenCachDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCachDung_CREATE", _tenCachDung, _tenTA, _ghichu, _maMay, _loai, _nguoiSD ));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMCachDung" /> Object to underlying database.
		/// </summary>
   		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCachDung
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMCachDung(_maCachDung, _tenCachDung, _tenTA, _ghichu, _maMay, _loai, _huy,_khongsd , _nguoiSD );
				// public abstract void UpdateDMCachDung(String _maCachDung, String _tenCachDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD);
                // public override void UpdateDMCachDung(String _maCachDung, String _tenCachDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCachDung_UPDATED", _maCachDung, _tenCachDung, _tenTA, _ghichu, _maMay, _loai, _huy, _khongsd, _nguoiSD );
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maCachDung));
		}

		/// <summary>
		/// Delete the <see cref="DMCachDung" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCachDung
            DataProvider.Instance().DeleteDMCachDung(crit.MaMay, crit.NguoiSD, crit.MaCachDung);
			// public abstract void DeleteDMCachDung(String _maCachDung);
			// public override void DeleteDMCachDung(String _maCachDung)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCachDung_DELETED", _maCachDung);
			// }
		}

		#endregion
	}

}
