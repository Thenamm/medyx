// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChuyenMon
// Kieu doi tuong  :	DMChuyenMon
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 2:48:49 PM
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
	/// This is a base generated class of <see cref="DMChuyenMon" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMChuyenMon : BusinessBase<DMChuyenMon>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maChuyenMon = String.Empty;
		private String _tenChuyenMon = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        
        private Byte _cap = 0;
        private String _loai = String.Empty;
        private String _idparent = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaChuyenMon
		{
			get 
			{
				CanReadProperty("MaChuyenMon", true);
				return _maChuyenMon;
			}
			set 
			{
				CanWriteProperty("MaChuyenMon", true);
				if (_maChuyenMon != value) 
				{
					_maChuyenMon = value;
					PropertyHasChanged("MaChuyenMon");
				}
			}
		}
		
		public String TenChuyenMon
		{
			get 
			{
				CanReadProperty("TenChuyenMon", true);
				return _tenChuyenMon;
			}
			set 
			{
				CanWriteProperty("TenChuyenMon", true);
				if (_tenChuyenMon != value) 
				{
					_tenChuyenMon = value;
					PropertyHasChanged("TenChuyenMon");
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
        public String loai
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
        public Byte Cap
        {
            get
            {
                CanReadProperty("Cap", true);
                return _cap;
            }
            set
            {
                CanWriteProperty("Cap", true);
                if (_cap != value)
                {
                    _cap = value;
                    PropertyHasChanged("Cap");
                }
            }
        }
        public String idparent
        {
            get
            {
                CanReadProperty("idparent", true);
                return _idparent;
            }
            set
            {
                CanWriteProperty("idparent", true);
                if (_idparent != value)
                {
                    _idparent = value;
                    PropertyHasChanged("idparent");
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maChuyenMon;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenChuyenMon", 150));
            ValidationRules.AddRule<DMChuyenMon>(StringRequired<DMChuyenMon>, "TenChuyenMon");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMChuyenMon
        {

            if (target._tenChuyenMon == null || target._tenChuyenMon.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMChuyenMon" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static DMChuyenMon NewDMChuyenMon()
        {
            //return new DMChuyenMon();
            return DataPortal.Create<DMChuyenMon>();
        }
        public static DMChuyenMon NewDMChuyenMon(string idparent)
        {
            //return new DMChuyenMon(idparent);
            return DataPortal.Create<DMChuyenMon>(new Criteria(idparent));
        }
		public static DMChuyenMon GetDMChuyenMon(String maChuyenMon)
		{
			return DataPortal.Fetch<DMChuyenMon>(new Criteria(maChuyenMon));
		}
		
		/// <summary>
		/// Marks the <see cref="DMChuyenMon" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMChuyenMon(String maChuyenMon, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChuyenMon));
		}
        private DMChuyenMon(string idparent)
        {
            _idparent = idparent;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMChuyenMon()
		{	
			// Prevent direct creation
		}
        internal DMChuyenMon(int ordernumber, string Macm, string Tencm, string idmay, bool huy, SmartDate ngaySD, string NguoiSD,string loai , byte cap ,string idparent)
        {
            _OrderNumber = ordernumber;
            _maChuyenMon  = Macm;
            _tenChuyenMon  = Tencm;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _loai = loai;
            _cap = cap;
            _idparent = idparent; 
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maChuyenMon;
			public String MaChuyenMon 
			{
				get
				{
					return _maChuyenMon;
				}
			}
			
			public Criteria(String maChuyenMon)
			{
				_maChuyenMon = maChuyenMon;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maChuyenMon.Equals(c._maChuyenMon)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maChuyenMon.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maCM;
            public String MaCM
            {
                get
                {
                    return _maCM;
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
           
     
            public OtherCriteria(String Mamay, String Nguoisd, String maCM)
            {
                _maCM = maCM;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
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
		/// Retrieve an existing <see cref="DMChuyenMon" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMChuyenMon(String _maChuyenMon);
			// public override IDataReader GetDMChuyenMon(String _maChuyenMon)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChuyenMon(crit.MaChuyenMon)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMChuyenMon" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaChuyenMon") != null) _maChuyenMon = dr.GetString("MaChuyenMon");
			if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("loai") != null) _loai = dr.GetString("loai");
            if (dr.GetByte("Cap") != null) _cap = dr.GetByte("Cap");
            if (dr.GetString("idparent") != null) _idparent = dr.GetString("idparent");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMChuyenMon" /> Object to underlying database.
		/// </summary>
        /// 
        protected void DataPortal_Create(Criteria param)
        {
            _idparent = param.MaChuyenMon;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChuyenMon
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maChuyenMon = DataProvider.Instance().InsertDMChuyenMon(_tenChuyenMon, _maMay, _nguoiSD ,_loai,_idparent );
			// public abstract String InsertDMChuyenMon( String _tenChuyenMon, String _maMay,  String _nguoiSD);
			// public override String InsertDMChuyenMon( String _tenChuyenMon, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon, _tenChuyenMon, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMChuyenMon" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChuyenMon
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMChuyenMon(_maChuyenMon, _tenChuyenMon, _maMay,_huy , _nguoiSD ,_loai);
				// public abstract void UpdateDMChuyenMon(String _maChuyenMon, String _tenChuyenMon, String _maMay, String _nguoiSD);
				// public override void UpdateDMChuyenMon(String _maChuyenMon, String _tenChuyenMon, String _maMay,  String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon, _tenChuyenMon, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maChuyenMon));
		}

		/// <summary>
		/// Delete the <see cref="DMChuyenMon" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChuyenMon
            DataProvider.Instance().DeleteDMChuyenMon(crit.MaMay, crit.NguoiSD, crit.MaCM );
			// public abstract void DeleteDMChuyenMon(String _maChuyenMon);
			// public override void DeleteDMChuyenMon(String _maChuyenMon);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon);
			// }
		}

		#endregion
	}

}
