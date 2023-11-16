// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_BC
// Kieu doi tuong  :	DMDichVu_BC
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
	/// This is a base generated class of <see cref="DMDichVu_BC" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_BC : BusinessBase<DMDichVu_BC>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _tenBC = String.Empty;
        private Byte _lOAI = 0;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate(false);
		private String _nguoiHuy = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate(false );
		private String _nguoiLap = String.Empty;
        private String _tennguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaBC
		{
			get 
			{
				CanReadProperty("MaBC", true);
				return _maBC;
			}
			set 
			{
				CanWriteProperty("MaBC", true);
				if (_maBC != value) 
				{
					_maBC = value;
					PropertyHasChanged("MaBC");
				}
			}
		}
		
		public String TenBC
		{
			get 
			{
				CanReadProperty("TenBC", true);
				return _tenBC;
			}
			set 
			{
				CanWriteProperty("TenBC", true);
				if (_tenBC != value) 
				{
					_tenBC = value;
					PropertyHasChanged("TenBC");
				}
			}
		}
        public Byte LOAI
        {
            get
            {
                CanReadProperty("LOAI", true);
                return _lOAI;
            }
            set
            {
                CanWriteProperty("LOAI", true);
                if (_lOAI != value)
                {
                    _lOAI = value;
                    PropertyHasChanged("LOAI");
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

        DMDichVu_BC_Cs _DichvuBCCs = DMDichVu_BC_Cs.NewDMDichVu_BC_Cs() ;

        public DMDichVu_BC_Cs DichvuBCCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _DichvuBCCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_DichvuBCCs.Equals(value))
                {
                    _DichvuBCCs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maBC;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _DichvuBCCs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _DichvuBCCs.IsValid;
            }
        }
		#endregion
		#endregion
				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenBC", 100));
            ValidationRules.AddRule<DMDichVu_BC>(StringRequired<DMDichVu_BC>, "TenBC");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_BC
        {

            if (target._tenBC == null || target._tenBC.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_BC NewDMDichVu_BC()
        {
            return DataPortal.Create<DMDichVu_BC>();
        }
		public static DMDichVu_BC GetDMDichVu_BC(String maBC)
		{
			return DataPortal.Fetch<DMDichVu_BC>(new Criteria(maBC));
		}
        public static DMDichVu_BC GetDMDichVu_BC(SafeDataReader dr)
        {
            DMDichVu_BC obj = new DMDichVu_BC();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_BC(String maBC, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBC));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDichVu_BC()
		{	
			// Prevent direct creation
		}
        internal DMDichVu_BC(   int OrderNumber,  
  String maBC ,
		                             String tenBC ,
  Byte loai,
		                             String ghichu ,
		                             String maMay ,
		                             Boolean huy ,
		                             SmartDate NgayHuy ,
		                             String nguoiHuy ,
		                             SmartDate NgayLap ,
		                             String nguoiLap ,
		                             SmartDate ngaySD ,
		                             String nguoiSD,
  String tennguoiLap,
  String tennguoiSD,
  String tennguoiHuy
                 )
        {
                            _OrderNumber = OrderNumber;
                            _maBC   = maBC ;
                            _tenBC  = tenBC ;
                            _lOAI = loai;
                            _ghichu = ghichu;
                            _maMay = maMay;
                            _huy = huy;
                            _ngayHuy = NgayHuy;
                            _nguoiHuy = nguoiHuy;
                            _ngayLap = NgayLap;
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
			private String _maBC;
			public String MaBC 
			{
				get
				{
					return _maBC;
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
			public Criteria(String maBC)
			{
				_maBC = maBC;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBC;
            public String MaBC
            {
                get
                {
                    return _maBC;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBC)
            {
                _maBC = maBC;
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
		/// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
		/// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            _maBC = dr.GetString("MaBC");
           _tenBC = dr.GetString("TenBC");
           _lOAI = dr.GetByte("Loai");
            _ghichu = dr.GetString("Ghichu");
            _maMay = dr.GetString("MaMay");
            _huy = dr.GetBoolean("Huy");
            _ngayHuy = dr.GetSmartDate("NgayHuy");
            _nguoiHuy = dr.GetString("NguoiHuy");
            _ngayLap = dr.GetSmartDate("NgayLap");
            _nguoiLap = dr.GetString("NguoiLap");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
        }
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_BC(String _maBC);
			// public override IDataReader GetDMDichVu_BC(String _maBC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_BC(crit.MaBC, crit.qadmin)))
			{
				if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _DichvuBCCs = DMDichVu_BC_Cs.GetDMDichVu_BC_Cs(dr);
                    }
					//ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_BC" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("TenBC") != null) _tenBC = dr.GetString("TenBC");
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (GetSmartDate("NgayHuy") != null) _ngayLap = GetSmartDate("NgayHuy");
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date  = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maBC = DataProvider.Instance().InsertDMDichVu_BC(_tenBC,_lOAI , _ghichu, _maMay, _nguoiSD);
            //if (_maBC > 0)
            //{
            _DichvuBCCs.Update(this); 
            //}
			// public abstract String InsertDMDichVu_BC(String _tenBC, String _ghichu, String _maMay, String _nguoiLap);
			// public override String InsertDMDichVu_BC(String _tenBC, String _ghichu, String _maMay, String _nguoiLap);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenBC, _ghichu, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDichVu_BC(_maBC, _tenBC,_lOAI , _ghichu, _maMay, _huy, _nguoiSD);
                _DichvuBCCs.Update(this);

				// public abstract void UpdateDMDichVu_BC(String _maBC, String _tenBC, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _nguoiSD);
				// public override void UpdateDMDichVu_BC(String _maBC, String _tenBC, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _tenBC, _ghichu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBC));
		}

		/// <summary>
		/// Delete the <see cref="DMDichVu_BC" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteDMDichVu_BC(crit.MaMay, crit.NguoiSD, crit.MaBC);
			// public abstract void DeleteDMDichVu_BC(String _maBC);
			// public override void DeleteDMDichVu_BC(String _maBC);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC);
			// }
		}

		#endregion
	}

}
