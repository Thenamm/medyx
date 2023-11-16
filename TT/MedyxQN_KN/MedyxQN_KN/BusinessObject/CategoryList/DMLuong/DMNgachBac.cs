// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNgachBac
// Kieu doi tuong  :	DMNgachBac
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:34:50 PM
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
	/// This is a base generated class of <see cref="DMNgachBac" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNgachBac : BusinessBase<DMNgachBac>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNgach = String.Empty;
        private String _tenNgach = String.Empty;
        private int _Bac= 0 ;
		private String _maMay = String.Empty;
        private decimal _Heso =0 ;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maNgach
		{
			get 
			{
				CanReadProperty("maNgach", true);
				return _maNgach;
			}
			set 
			{
				CanWriteProperty("maNgach", true);
				if (_maNgach != value) 
				{
					_maNgach = value;
					PropertyHasChanged("maNgach");
				}
			}
		}
        public int Bac 
		{
			get 
			{
                CanReadProperty("Bac", true);
				return _Bac;
			}
			set 
			{
                CanWriteProperty("Bac", true);
				if (_Bac != value) 
				{
					_Bac = value;
                    PropertyHasChanged("Bac");
				}
			}
		}
        public String TenNgach
        {
            get
            {
                CanReadProperty("TenNgach", true);
                return _tenNgach;
            }
            set
            {
                CanWriteProperty("TenNgach", true);
                if (_tenNgach != value)
                {
                    _tenNgach = value;
                    PropertyHasChanged("TenNgach");
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


        public decimal  Heso
        {
            get
            {
                CanReadProperty("Heso", true);
                return _Heso ;
            }
            set
            {
                CanWriteProperty("Heso", true);
                if (_Heso != value)
                {
                    _Heso = value;
                    PropertyHasChanged("Heso");
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
			return _maNgach;
		}
		
		#endregion
		#endregion

			
	
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{

        //    //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
        //    ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("Bac", 4));
        //    ValidationRules.AddRule<DMNgachBac>(StringRequired<DMNgachBac>, "TenNgach");
        //    ValidationRules.AddRule<DMNgachBac>(TextRequired<DMNgachBac>, "MaQL"); 
        //}
        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNgachBac
        //{

        //    if (target._tenNgach == null || target._tenNgach.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool TextRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNgachBac
        //{

        //    if (target._MaQL  == null || target._MaQL .Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMNgachBac" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNgachBac NewDMNgachBac()
        {
            return DataPortal.Create<DMNgachBac>();
        }
		public static DMNgachBac GetDMNgachBac(String maNgach, int Bac)
		{
			return DataPortal.Fetch<DMNgachBac>(new Criteria(maNgach, Bac ));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNgachBac" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNgachBac(String maNgach, decimal Bac, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNgach, Bac ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNgachBac()
		{	
			// Prevent direct creation
		}
        internal DMNgachBac(int ordernumber, string MaNgach,int   Bac, string TenNgach, decimal Heso, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maNgach = MaNgach;
            _Bac = Bac ;
            _tenNgach = TenNgach;
            _Heso = Heso;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _ghiChu = ghichu;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNgach;
			public String maNgach 
			{
				get
				{
					return _maNgach;
				}
			}
            private int _bac;
            public int bac
            {
                get
                {
                    return _bac;
                }
            }
			public Criteria(String maNgach, int bac)
			{
				_maNgach = maNgach;
                _bac = bac;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNgach.Equals(c._maNgach)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNgach.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNgach;
            public String maNgach
            {
                get
                {
                    return _maNgach;
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
            private Decimal  _Bac;
            public Decimal  Bac
            {
                get
                {
                    return _Bac;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maNgach ,decimal Bac)
            {
                _maNgach = maNgach;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _Bac = Bac;
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
		/// Retrieve an existing <see cref="DMNgachBac" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNgachBac(String _maNgach);
			// public override IDataReader GetDMNgachBac(String _maNgach)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgach));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNgachBac(crit.maNgach, crit.bac  )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNgachBac" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maNgach") != null) _maNgach = dr.GetString("maNgach");
            if (dr.GetInt32("Bac") != null) _Bac = dr.GetInt32("Bac");
            if (dr.GetString("TenNgach") != null) _tenNgach = dr.GetString("TenNgach");
            if (dr.GetDecimal("Heso") != null) _Heso  = dr.GetDecimal ("Heso");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNgachBac" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNgachBac
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNgach = DataProvider.Instance().InsertDMNgachBac(_maNgach, _Bac, _ghiChu, _Heso, _maMay, _nguoiSD);
			// public abstract String InsertDMNgachBac(String _tenNgach, String _maMay, String _nguoiSD);
			// public override String InsertDMNgachBac(String _tenNgach, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenNgach, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNgachBac" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNgachBac
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMNgachBac(_maNgach, _Bac, _ghiChu, _Heso, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMNgachBac(String _maNgach, String _tenNgach, String _maMay, String _nguoiSD);
				// public override void UpdateDMNgachBac(String _maNgach, String _tenNgach, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgach, _tenNgach, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNgach,_Bac ));
		}

		/// <summary>
		/// Delete the <see cref="DMNgachBac" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNgachBac
            DataProvider.Instance().DeleteDMNgachBac(crit.MaMay, crit.NguoiSD, crit.maNgach, crit.Bac );
			// public abstract void DeleteDMNgachBac(String _maNgach);
			// public override void DeleteDMNgachBac(String _maNgach);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgach);
			// }
		}

		#endregion
	}

}
