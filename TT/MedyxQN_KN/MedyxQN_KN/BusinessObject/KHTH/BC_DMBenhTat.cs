// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_DMBenhTat
// Kieu doi tuong  :	BC_DMBenhTat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/4/2008 2:34:09 PM
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

namespace HTC.Business.KHTH
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BC_DMBenhTat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_DMBenhTat : BusinessBase<BC_DMBenhTat>
	{
		#region Business Methods
		
		#region State Fields
		
		private string _maBenhID = String.Empty;
		private String _maICD = String.Empty;
		private String _tenBenh = String.Empty;
		private String _tenBenhICD = String.Empty;
		private String _maNhom = String.Empty;
        private String _maBHXH = String.Empty;
		private String _maVN = String.Empty;
		private Byte _cap = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private string _idparent = String.Empty;
        private String _tenta = String.Empty;
        private String _maNhomICD = String.Empty ;
        private Boolean _khongsd = false;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaBenhID
		{
			get 
			{
				CanReadProperty("MaBenhID", true);
				return _maBenhID;
			}
			set 
			{
				CanWriteProperty("MaBenhID", true);
				if (_maBenhID != value) 
				{
					_maBenhID = value;
					PropertyHasChanged("MaBenhID");
				}
			}
		}
		
		public String MaICD
		{
			get 
			{
				CanReadProperty("MaICD", true);
				return _maICD;
			}
			set 
			{
				CanWriteProperty("MaICD", true);
				if (_maICD != value) 
				{
					_maICD = value;
					PropertyHasChanged("MaICD");
				}
			}
		}
        public String MaNhomICD
        {
            get
            {
                CanReadProperty("MaNhomICD", true);
                return _maNhomICD;
            }
            set
            {
                CanWriteProperty("MaNhomICD", true);
                if (_maNhomICD != value)
                {
                    _maNhomICD = value;
                    PropertyHasChanged("MaNhomICD");
                }
            }
        }
		public String TenBenh
		{
			get 
			{
				CanReadProperty("TenBenh", true);
				return _tenBenh;
			}
			set 
			{
				CanWriteProperty("TenBenh", true);
				if (_tenBenh != value) 
				{
					_tenBenh = value;
					PropertyHasChanged("TenBenh");
				}
			}
		}
        public String tenta
        {
            get
            {
                CanReadProperty("tenta", true);
                return _tenta;
            }
            set
            {
                CanWriteProperty("tenta", true);
                if (_tenta != value)
                {
                    _tenta = value;
                    PropertyHasChanged("tenta");
                }
            }
        }
		
		public String TenBenhICD
		{
			get 
			{
				CanReadProperty("TenBenhICD", true);
				return _tenBenhICD;
			}
			set 
			{
				CanWriteProperty("TenBenhICD", true);
				if (_tenBenhICD != value) 
				{
					_tenBenhICD = value;
					PropertyHasChanged("TenBenhICD");
				}
			}
		}
		
		public String MaNhom
		{
			get 
			{
				CanReadProperty("MaNhom", true);
				return _maNhom;
			}
			set 
			{
				CanWriteProperty("MaNhom", true);
				if (_maNhom != value) 
				{
					_maNhom = value;
					PropertyHasChanged("MaNhom");
				}
			}
		}

        public String MaBHXH
        {
            get
            {
                CanReadProperty("MaBHXH", true);
                return _maBHXH;
            }
            set
            {
                CanWriteProperty("MaBHXH", true);
                if (_maBHXH != value)
                {
                    _maBHXH = value;
                    PropertyHasChanged("MaBHXH");
                }
            }
        }
		
		public String MaVN
		{
			get 
			{
				CanReadProperty("MaVN", true);
				return _maVN;
			}
			set 
			{
				CanWriteProperty("MaVN", true);
				if (_maVN != value) 
				{
					_maVN = value;
					PropertyHasChanged("MaVN");
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

        public Boolean khongsd
        {
            get
            {
                CanReadProperty("khongsd", true);
                return _khongsd;
            }
            set
            {
                CanWriteProperty("khongsd", true);
                if (_khongsd != value)
                {
                    _khongsd = value;
                    PropertyHasChanged("khongsd");
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
			return _maBenhID;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenBenh", 150));
            ValidationRules.AddRule<BC_DMBenhTat>(StringRequired<BC_DMBenhTat>, "TenBenh");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : BC_DMBenhTat
        {

            if (target._tenBenh == null || target._tenBenh.Trim().Length == 0)
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
		/// Factory method. New <see cref="BC_DMBenhTat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BC_DMBenhTat NewBC_DMBenhTat()
        {
            return DataPortal.Create<BC_DMBenhTat>();
        }
        public static BC_DMBenhTat NewBC_DMBenhTat(string idparent)
        {
            return DataPortal.Create<BC_DMBenhTat>(new Criteria(idparent));
        }
        
		public static BC_DMBenhTat GetBC_DMBenhTat(String maBenhID)
		{
			return DataPortal.Fetch<BC_DMBenhTat>(new Criteria(maBenhID));
		}
		
		/// <summary>
		/// Marks the <see cref="BC_DMBenhTat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBC_DMBenhTat(String maBenhID, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBenhID));
		}
        private BC_DMBenhTat(string idparent)
        {
            _idparent = idparent;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BC_DMBenhTat()
		{	
			// Prevent direct creation
		}
        internal BC_DMBenhTat(int ordernumber, String maBenhID, String maICD,String maNhomICD, String tenBenh, String tenBenhICD, String maNhom, String maBHXH, String maVN, Byte cap, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, string idparent, string _tenta, Boolean _khongsd)
        {
            _OrderNumber = ordernumber;
            _maBenhID = maBenhID;
            _maICD = maICD;
            _maNhomICD = maNhomICD;
            _tenBenh = tenBenh;
            _tenBenhICD = tenBenhICD;
            _maNhom = maNhom;
            _maBHXH = maBHXH;
            _maVN = maVN;
            _cap = cap;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _idparent = idparent;
            _tenta = tenta;
            _khongsd = khongsd;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBenhID;
			public String MaBenhID 
			{
				get
				{
					return _maBenhID;
				}
			}
			
			public Criteria(String maBenhID)
			{
				_maBenhID = maBenhID;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBenhID.Equals(c._maBenhID)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBenhID.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBenhID;
            public String maBenhID
            {
                get
                {
                    return _maBenhID;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBenhID)
            {
                _maBenhID = maBenhID;
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
		/// Retrieve an existing <see cref="BC_DMBenhTat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBC_DMBenhTat(String _maBenhID);
			// public override IDataReader GetBC_DMBenhTat(String _maBenhID)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBenhID));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_DMBenhTat(crit.MaBenhID)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BC_DMBenhTat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBenhID") != null) _maBenhID = dr.GetString("MaBenhID");
			if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("MaNhomICD") != null) _maNhomICD = dr.GetString("MaNhomICD");
			if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");        
			if (dr.GetString("TenBenhICD") != null) _tenBenhICD = dr.GetString("TenBenhICD");
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
            if (dr.GetString("MaBHXH") != null) _maBHXH = dr.GetString("MaBHXH");
			if (dr.GetString("MaVN") != null) _maVN = dr.GetString("MaVN");
			if (dr.GetByte("Cap") != null) _cap = dr.GetByte("Cap");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");     
			if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("idparent") != null) _idparent = dr.GetString("idparent");
            if (dr.GetString("tenta") != null)  _tenta = dr.GetString("tenta");
            if (dr.GetBoolean("khongsd") != null) _khongsd = dr.GetBoolean("khongsd");
		}

		
		/// <summary>
		/// Insert the new <see cref="BC_DMBenhTat" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        protected void DataPortal_Create(Criteria param)
        {
            _idparent = param.MaBenhID;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBC_DMBenhTat
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maBenhID = DataProvider.Instance().InsertBC_DMBenhTat(_maICD, _tenBenh, _tenBenhICD, _maNhom, _maVN, _maMay, _nguoiSD , _idparent,_tenta,_khongsd, _maBHXH,_maNhomICD   );
			// public abstract String InsertBC_DMBenhTat(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertBC_DMBenhTat(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBenhID, _maICD, _tenBenh, _tenBenhICD, _maNhom, _maVN, _cap, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_DMBenhTat" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_DMBenhTat
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateBC_DMBenhTat(_maBenhID, _maICD, _tenBenh, _tenBenhICD, _maNhom, _maVN, _cap, _maMay, _nguoiSD , _tenta, _khongsd, _maBHXH,_maNhomICD );
				// public abstract void UpdateBC_DMBenhTat(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateBC_DMBenhTat(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBenhID, _maICD, _tenBenh, _tenBenhICD, _maNhom, _maVN, _cap, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_maBenhID   ));
		}

		/// <summary>
		/// Delete the <see cref="BC_DMBenhTat" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_DMBenhTat
			DataProvider.Instance().DeleteBC_DMBenhTat(crit.MaMay,crit.NguoiSD,crit.maBenhID );
			// public abstract void DeleteBC_DMBenhTat(String _maBenhID);
			// public override void DeleteBC_DMBenhTat(String _maBenhID);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBenhID);
			// }
		}

		#endregion
	}

}
