// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHuongDT
// Kieu doi tuong  :	DMHuongDT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:47:54 PM
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
	/// This is a base generated class of <see cref="DMHuongDT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMHuongDT : BusinessBase<DMHuongDT>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maHDT = String.Empty;
		private String _tenHDT = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private Byte _lOAI = 0;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaHDT
		{
			get 
			{
				CanReadProperty("MaHDT", true);
				return _maHDT;
			}
			set 
			{
				CanWriteProperty("MaHDT", true);
				if (_maHDT != value) 
				{
					_maHDT = value;
					PropertyHasChanged("MaHDT");
				}
			}
		}
		
		public String TenHDT
		{
			get 
			{
				CanReadProperty("TenHDT", true);
				return _tenHDT;
			}
			set 
			{
				CanWriteProperty("TenHDT", true);
				if (_tenHDT != value) 
				{
					_tenHDT = value;
					PropertyHasChanged("TenHDT");
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
			return _maHDT;
		}
		
		#endregion
      
        

		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenHDT", 150));
            ValidationRules.AddRule<DMHuongDT>(StringRequired<DMHuongDT>, "TenHDT");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMHuongDT
        {

            if (target._tenHDT == null || target._tenHDT.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMHuongDT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMHuongDT NewDMHuongDT()
        {
            return DataPortal.Create<DMHuongDT>();  
        }
		public static DMHuongDT GetDMHuongDT(String maHDT)
		{
			return DataPortal.Fetch<DMHuongDT>(new Criteria(maHDT));
		}
		
		/// <summary>
		/// Marks the <see cref="DMHuongDT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMHuongDT(String maHDT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHDT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMHuongDT()
		{	
			// Prevent direct creation
		}
        internal DMHuongDT(int ordernumber, string MaQG, string TenQG,String ghichu, string idmay, bool huy,byte loai, SmartDate ngaySD, string NguoiSD, string hoten)
        {
            _OrderNumber = ordernumber;
            _maHDT   = MaQG;
            _tenHDT  = TenQG;
            _ghichu = ghichu;
            _maMay = idmay;
            _huy = huy;
            _lOAI = loai;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maHDT;
			public String MaHDT 
			{
				get
				{
					return _maHDT;
				}
			}
			
			public Criteria(String maHDT)
			{
				_maHDT = maHDT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maHDT.Equals(c._maHDT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maHDT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHDT;
            public String MaHDT
            {
                get
                {
                    return _maHDT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maHDT)
            {
                _maHDT = maHDT;
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
		/// Retrieve an existing <see cref="DMHuongDT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMHuongDT(String _maHDT);
			// public override IDataReader GetDMHuongDT(String _maHDT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHDT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHuongDT(crit.MaHDT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMHuongDT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHDT") != null) _maHDT = dr.GetString("MaHDT");
			if (dr.GetString("TenHDT") != null) _tenHDT = dr.GetString("TenHDT");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetByte("LOAI") != null) _lOAI = dr.GetByte("LOAI");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMHuongDT" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMHuongDT
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maHDT = DataProvider.Instance().InsertDMHuongDT(_tenHDT, _ghichu, _maMay,_lOAI,_nguoiSD);
			// public abstract String InsertDMHuongDT(String _tenHDT, String _ghichu, String _maMay, Byte _lOAI, String _nguoiSD);
			// public override String InsertDMHuongDT(String _tenHDT, String _ghichu, String _maMay, Byte _lOAI, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenHDT, _ghichu, _maMay, _lOAI, _nguoiSD));
			// }
		}

		
		/// <summary>
		/// Update all changes made on <see cref="DMHuongDT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHuongDT
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMHuongDT(_maHDT, _tenHDT, _ghichu, _maMay,  _lOAI, _huy, _nguoiSD);
				// public abstract void UpdateDMHuongDT(String _maHDT, String _tenHDT, String _ghichu, String _maMay,  Byte _lOAI, String _nguoiSD);
				// public override void UpdateDMHuongDT(String _maHDT, String _tenHDT, String _ghichu, String _maMay, Byte _lOAI, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHDT, _tenHDT, _ghichu, _maMay, _lOAI,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maHDT));
		}

		/// <summary>
		/// Delete the <see cref="DMHuongDT" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHuongDT
            DataProvider.Instance().DeleteDMHuongDT(crit.MaMay, crit.NguoiSD, crit.MaHDT);
			// public abstract void DeleteDMHuongDT(String _maHDT);
			// public override void DeleteDMHuongDT(String _maHDT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHDT);
			// }
		}

		#endregion
	}

}
