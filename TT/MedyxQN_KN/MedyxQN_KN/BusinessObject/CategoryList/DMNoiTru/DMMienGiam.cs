
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMMienGiam" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMMienGiam : BusinessBase<DMMienGiam>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maMienGiam = String.Empty;
		private String _tenMienGiam = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaMienGiam
		{
			get 
			{
				CanReadProperty("MaMienGiam", true);
				return _maMienGiam;
			}
			set 
			{
				CanWriteProperty("MaMienGiam", true);
				if (_maMienGiam != value) 
				{
					_maMienGiam = value;
					PropertyHasChanged("MaMienGiam");
				}
			}
		}
		
		public String TenMienGiam
		{
			get 
			{
				CanReadProperty("TenMienGiam", true);
				return _tenMienGiam;
			}
			set 
			{
				CanWriteProperty("TenMienGiam", true);
				if (_tenMienGiam != value) 
				{
					_tenMienGiam = value;
					PropertyHasChanged("TenMienGiam");
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
		
		public String GhiChu
		{
			get 
			{
				CanReadProperty("GhiChu", true);
				return _ghiChu;
			}
			set 
			{
				CanWriteProperty("GhiChu", true);
				if (_ghiChu != value) 
				{
					_ghiChu = value;
					PropertyHasChanged("GhiChu");
				}
			}
		}

        public String hoten
        {
            get
            {
                CanReadProperty("hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("hoten");
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
			return _maMienGiam;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	 protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenMienGiam", 150));
            ValidationRules.AddRule<DMMienGiam>(StringRequired<DMMienGiam>, "TenMienGiam");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMMienGiam
        {

            if (target._tenMienGiam == null || target._tenMienGiam.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMMienGiam" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMMienGiam NewDMMienGiam()
        {
            return DataPortal.Create<DMMienGiam>();
        }
		public static DMMienGiam GetDMMienGiam(String maMienGiam)
		{
			return DataPortal.Fetch<DMMienGiam>(new Criteria(maMienGiam));
		}
		
		/// <summary>
		/// Marks the <see cref="DMMienGiam" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMMienGiam(String maMienGiam, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maMienGiam));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMMienGiam()
		{	
			// Prevent direct creation
		}

        internal DMMienGiam(    int OrderNumber,
                                 String maMienGiam ,
		                         String tenMienGiam ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         String ghiChu ,
                                 String hoten 
                                 
            )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maMienGiam = maMienGiam ;
		                          _tenMienGiam = tenMienGiam ;
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ghiChu = ghiChu ;
                                  _hoten = hoten ;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maMienGiam;
			public String MaMienGiam 
			{
				get
				{
					return _maMienGiam;
				}
			}
			
			public Criteria(String maMienGiam)
			{
				_maMienGiam = maMienGiam;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maMienGiam.Equals(c._maMienGiam)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maMienGiam.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maMienGiam;
            public String MaMienGiam
            {
                get
                {
                    return _maMienGiam;
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
            public OtherCriteria(String Mamay, String Nguoisd, String matenluong)
            {
                _maMienGiam = matenluong;
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
		/// Retrieve an existing <see cref="DMMienGiam" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMMienGiam(String _maMienGiam);
			// public override IDataReader GetDMMienGiam(String _maMienGiam)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maMienGiam));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMMienGiam(crit.MaMienGiam)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMMienGiam" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaMienGiam") != null) _maMienGiam = dr.GetString("MaMienGiam");
			if (dr.GetString("TenMienGiam") != null) _tenMienGiam = dr.GetString("TenMienGiam");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMMienGiam" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMMienGiam
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maMienGiam = DataProvider.Instance().InsertDMMienGiam(_tenMienGiam, _maMay, _nguoiSD , _ghiChu);
			// public abstract String InsertDMMienGiam(String _tenMienGiam, String _maMay, String _nguoiSD, String _ghiChu);
			// public override String InsertDMMienGiam(String _tenMienGiam, String _maMay, String _nguoiSD, String _ghiChu)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMMienGiam_CREATE", _tenMienGiam, _maMay, _nguoiSD , _ghiChu));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMMienGiam" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMMienGiam
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMMienGiam(_maMienGiam, _tenMienGiam, _maMay, _huy, _nguoiSD , _ghiChu);
				// public abstract void UpdateDMMienGiam(String _maMienGiam, String _tenMienGiam, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu);
				// public override void UpdateDMMienGiam(String _maMienGiam, String _tenMienGiam, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMMienGiam_UPDATE", _maMienGiam, _tenMienGiam, _maMay, _huy, _nguoiSD , _ghiChu);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maMienGiam));
		}

		/// <summary>
		/// Delete the <see cref="DMMienGiam" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMMienGiam
            DataProvider.Instance().DeleteDMMienGiam(crit.MaMay, crit.NguoiSD, crit.MaMienGiam);
			// public abstract void DeleteDMMienGiam(String _maMienGiam);
			// public override void DeleteDMMienGiam(String _maMienGiam)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMMienGiam_DELETED", _maMienGiam);
			// }
		}

		#endregion
	}

}
