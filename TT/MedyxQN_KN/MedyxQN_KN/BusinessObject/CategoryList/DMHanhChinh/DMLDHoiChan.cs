// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLDHoiChan
// Kieu doi tuong  :	DMLDHoiChan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/3/2009 9:56:57 AM
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
	/// This is a base generated class of <see cref="DMLDHoiChan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLDHoiChan : BusinessBase<DMLDHoiChan>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maLDHoiChan = String.Empty;
		private String _tenLDHoiChan = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaLDHoiChan
		{
			get 
			{
				CanReadProperty("MaLDHoiChan", true);
				return _maLDHoiChan;
			}
			set 
			{
				CanWriteProperty("MaLDHoiChan", true);
				if (_maLDHoiChan != value) 
				{
					_maLDHoiChan = value;
					PropertyHasChanged("MaLDHoiChan");
				}
			}
		}
		
		public String TenLDHoiChan
		{
			get 
			{
				CanReadProperty("TenLDHoiChan", true);
				return _tenLDHoiChan;
			}
			set 
			{
				CanWriteProperty("TenLDHoiChan", true);
				if (_tenLDHoiChan != value) 
				{
					_tenLDHoiChan = value;
					PropertyHasChanged("TenLDHoiChan");
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
			return _maLDHoiChan;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenLDHoiChan", 150));
            ValidationRules.AddRule<DMLDHoiChan>(StringRequired<DMLDHoiChan>, "TenLDHoiChan");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLDHoiChan
        {

            if (target._tenLDHoiChan == null || target._tenLDHoiChan.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMLDHoiChan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLDHoiChan NewDMLDHoiChan()
        {
            return DataPortal.Create<DMLDHoiChan>();
            
        }
		public static DMLDHoiChan GetDMLDHoiChan(String MaLDHoiChan)
		{
			return DataPortal.Fetch<DMLDHoiChan>(new Criteria(MaLDHoiChan));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLDHoiChan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLDHoiChan(String MaLDHoiChan, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaLDHoiChan));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLDHoiChan()
		{	
			// Prevent direct creation
		}
        internal DMLDHoiChan(    int OrderNumber,
                                 String MaLDHoiChan ,
		                         String tenLDHoiChan ,
		                         String ghiChu ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
                                 String hoten 
                                 )
        {
                                 _OrderNumber = OrderNumber ;
                                  _maLDHoiChan = MaLDHoiChan ;
		                          _tenLDHoiChan = tenLDHoiChan ;
		                          _ghiChu = ghiChu ;
		                          _maMay = maMay ;
		                          _huy = huy;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
                                  _hoten = hoten ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maLDHoiChan;
			public String MaLDHoiChan 
			{
				get
				{
					return _maLDHoiChan;
				}
			}
			
			public Criteria(String MaLDHoiChan)
			{
				_maLDHoiChan = MaLDHoiChan;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLDHoiChan.Equals(c._maLDHoiChan)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLDHoiChan.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLDHoiChan;
            public String MaLDHoiChan
            {
                get
                {
                    return _maLDHoiChan;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaLDHoiChan)
            {
                _maLDHoiChan = MaLDHoiChan;
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
		/// Retrieve an existing <see cref="DMLDHoiChan" /> Object based on data in the database.
		/// </summary>
        /// 

		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLDHoiChan(String _maLDHoiChan);
			// public override IDataReader GetDMLDHoiChan(String _maLDHoiChan)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLDHoiChan));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLDHoiChan(crit.MaLDHoiChan)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLDHoiChan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaLDHoiChan") != null) _maLDHoiChan = dr.GetString("MaLDHoiChan");
			if (dr.GetString("TenLDHoiChan") != null) _tenLDHoiChan = dr.GetString("TenLDHoiChan");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLDHoiChan" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLDHoiChan
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maLDHoiChan = DataProvider.Instance().InsertDMLDHoiChan(_tenLDHoiChan, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMLDHoiChan(String _tenLDHoiChan, String _ghiChu, String _maMay, String _nguoiSD);
			// public override String InsertDMLDHoiChan(String _tenLDHoiChan, String _ghiChu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLDHoiChan_CREATE", _tenLDHoiChan, _ghiChu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLDHoiChan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLDHoiChan
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMLDHoiChan(_maLDHoiChan, _tenLDHoiChan, _ghiChu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMLDHoiChan(String _maLDHoiChan, String _tenLDHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMLDHoiChan(String _maLDHoiChan, String _tenLDHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLDHoiChan_UPDATE", _maLDHoiChan, _tenLDHoiChan, _ghiChu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maLDHoiChan));
		}

		/// <summary>
		/// Delete the <see cref="DMLDHoiChan" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLDHoiChan
            DataProvider.Instance().DeleteDMLDHoiChan(crit.MaMay, crit.NguoiSD, crit.MaLDHoiChan);
			// public abstract void DeleteDMLDHoiChan(String _maLDHoiChan);
			// public override void DeleteDMLDHoiChan(String _maLDHoiChan)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLDHoiChan_DELETED", _maLDHoiChan);
			// }
		}

		#endregion
	}

}
