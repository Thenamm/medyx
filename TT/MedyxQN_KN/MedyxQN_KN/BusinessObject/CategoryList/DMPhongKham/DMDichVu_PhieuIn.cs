// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_PhieuIn
// Kieu doi tuong  :	DMDichVu_PhieuIn
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/24/2008 9:35:55 AM
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
using HTC.Business.CategoryList;
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDichVu_PhieuIn" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_PhieuIn : BusinessBase<DMDichVu_PhieuIn>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPhieu = String.Empty;
		private String _tenPhieu = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate  _ngayHuy = new SmartDate(false );
		private String _nguoiHuy = String.Empty;
        private String _tennguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate();
		private String _nguoiLap = String.Empty;
        private String _tennguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPhieu
		{
			get 
			{
				CanReadProperty("MaPhieu", true);
				return _maPhieu;
			}
			set 
			{
				CanWriteProperty("MaPhieu", true);
				if (_maPhieu != value) 
				{
					_maPhieu = value;
					PropertyHasChanged("MaPhieu");
				}
			}
		}
		
		public String TenPhieu
		{
			get 
			{
				CanReadProperty("TenPhieu", true);
				return _tenPhieu;
			}
			set 
			{
				CanWriteProperty("TenPhieu", true);
				if (_tenPhieu != value) 
				{
					_tenPhieu = value;
					PropertyHasChanged("TenPhieu");
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
		
		public SmartDate NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "G"; 
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
        public String tenNguoiHuy
        {
            get
            {
                CanReadProperty("tenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("tenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
                    PropertyHasChanged("tenNguoiHuy");
                }
            }
        }		
		public SmartDate NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm"; 
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
        public String tenNguoiLap
        {
            get
            {
                CanReadProperty("tenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("tenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("tenNguoiLap");
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

        public String tenNguoiSD
        {
            get
            {
                CanReadProperty("tenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("tenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("tenNguoiSD");
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

        DMDichVu_PhieuIn_Cs _DichvuPhieuInCs = DMDichVu_PhieuIn_Cs.NewDMDichVu_PhieuIn_Cs() ;

        public DMDichVu_PhieuIn_Cs DichvuPhieuInCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _DichvuPhieuInCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_DichvuPhieuInCs.Equals(value))
                {
                    _DichvuPhieuInCs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maPhieu;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _DichvuPhieuInCs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _DichvuPhieuInCs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenPhieu", 100));
            ValidationRules.AddRule<DMDichVu_PhieuIn>(StringRequired<DMDichVu_PhieuIn>, "TenPhieu");
            }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_PhieuIn
        {

            if (target._tenPhieu == null || target._tenPhieu.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDichVu_PhieuIn" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_PhieuIn NewDMDichVu_PhieuIn()
        {
            return DataPortal.Create<DMDichVu_PhieuIn>();
        }
		public static DMDichVu_PhieuIn GetDMDichVu_PhieuIn(String maPhieu)
		{
			return DataPortal.Fetch<DMDichVu_PhieuIn>(new Criteria(maPhieu));
		}
        public static DMDichVu_PhieuIn GetDMDichVu_PhieuIn(SafeDataReader dr)
        {
            DMDichVu_PhieuIn obj = new DMDichVu_PhieuIn();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_PhieuIn" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_PhieuIn(String maPhieu, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPhieu));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDichVu_PhieuIn()
		{	
			// Prevent direct creation
		}
        internal DMDichVu_PhieuIn(   int OrderNumber,  
  String maPhieu ,
		                             String tenPhieu ,
		                             String ghichu ,
		                             String maMay ,
		                             Boolean huy ,
		                             SmartDate ngayHuy ,
		                             String nguoiHuy ,
		                             SmartDate ngayLap ,
		                             String nguoiLap ,
		                             SmartDate ngaySD ,
  String nguoiSD, 
  String tennguoiLap, 
  String tennguoiSD, 
  String tennguoiHuy
 )
                    {
                        _OrderNumber = OrderNumber;
                        _maPhieu   = maPhieu ;
                        _tenPhieu  = tenPhieu ;
                        _ghichu = ghichu;
                        _maMay = maMay;
                        _huy = huy;
                        _ngayHuy = ngayHuy;
                        _nguoiHuy = nguoiHuy;
                        _ngayLap = ngayLap;
                        _nguoiLap = nguoiLap;
                        _ngaySD = ngaySD;
                        _nguoiSD = NguoiSD;
                        _tennguoiLap = tennguoiLap;
                        _tennguoiSD = tennguoiSD;
                        _tennguoiHuy = tennguoiHuy;
                    }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPhieu;
			public String MaPhieu 
			{
				get
				{
					return _maPhieu;
				}
			}
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maPhieu)
			{
				_maPhieu = maPhieu;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPhieu.Equals(c._maPhieu)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPhieu.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPhieu;
            public String MaPhieu
            {
                get
                {
                    return _maPhieu;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPhieu)
            {
                _maPhieu = maPhieu;
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
		/// Retrieve an existing <see cref="DMDichVu_PhieuIn" /> Object based on data in the database.
		/// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            _maPhieu = dr.GetString("MaPhieu");
            _tenPhieu = dr.GetString("TenPhieu");
            _ghichu = dr.GetString("Ghichu");
            _maMay = dr.GetString("MaMay");
            _huy = dr.GetBoolean("Huy");
            _ngayHuy = dr.GetSmartDate("NgayHuy",false );
            _nguoiHuy = dr.GetString("NguoiHuy");
            _ngayLap = dr.GetSmartDate("NgayLap",false );
            _nguoiLap = dr.GetString("NguoiLap");
            _ngaySD = dr.GetSmartDate("NgaySD",false );
            _nguoiSD = dr.GetString("NguoiSD");
        }
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_PhieuIn(String _maPhieu);
			// public override IDataReader GetDMDichVu_PhieuIn(String _maPhieu)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhieu));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_PhieuIn(crit.MaPhieu,crit.qadmin )))
			{
				if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _DichvuPhieuInCs = DMDichVu_PhieuIn_Cs.GetDMDichVu_PhieuIn_Cs(dr);
                    }
					//ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_PhieuIn" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaPhieu") != null) _maPhieu = dr.GetString("MaPhieu");
        //    if (dr.GetString("TenPhieu") != null) _tenPhieu = dr.GetString("TenPhieu");
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (GetSmartDate("NgayHuy") != null) _ngayLap = GetSmartDate("NgayHuy");
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD") != null) _ngaySD = dr.GetSmartDate("NgaySD");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_PhieuIn" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date  = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn(_tenPhieu, _ghichu, _maMay, _nguoiSD);
            //if (_maPhieu > 0)
            //{
                _DichvuPhieuInCs.Update(this);
            //}
			// public abstract String InsertDMDichVu_PhieuIn(String _tenPhieu, String _ghichu, String _maMay, String _nguoiLap);
			// public override String InsertDMDichVu_PhieuIn(String _tenPhieu, String _ghichu, String _maMay, String _nguoiLap);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenPhieu, _ghichu, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_PhieuIn" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDichVu_PhieuIn(_maPhieu, _tenPhieu, _ghichu, _maMay, _huy, _nguoiSD);
                _DichvuPhieuInCs.Update(this);

				// public abstract void UpdateDMDichVu_PhieuIn(String _maPhieu, String _tenPhieu, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _nguoiSD);
				// public override void UpdateDMDichVu_PhieuIn(String _maPhieu, String _tenPhieu, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhieu, _tenPhieu, _ghichu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maPhieu));
		}

		/// <summary>
		/// Delete the <see cref="DMDichVu_PhieuIn" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn
            DataProvider.Instance().DeleteDMDichVu_PhieuIn(crit.MaMay, crit.NguoiSD, crit.MaPhieu);
			// public abstract void DeleteDMDichVu_PhieuIn(String _maPhieu);
			// public override void DeleteDMDichVu_PhieuIn(String _maPhieu);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhieu);
			// }
		}

		#endregion
	}

}
