// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDoiTuong
// Kieu doi tuong  :	DMDoiTuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 9:44:04 AM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDoiTuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDoiTuong : BusinessBase<DMDoiTuong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDT = String.Empty;
		private String _tenDT = String.Empty;
		private Decimal _bhtra = 0;
		private Decimal _sotienKTC = 0;
        private Decimal _sotien = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _kieuThe = String.Empty;
        private int _OrderNumber;
        private bool  _chon = false;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaDT
		{
			get 
			{
				CanReadProperty("MaDT", true);
				return _maDT;
			}
			set 
			{
				CanWriteProperty("MaDT", true);
				if (_maDT != value) 
				{
					_maDT = value;
					PropertyHasChanged("MaDT");
				}
			}
		}
		
		public String TenDT
		{
			get 
			{
				CanReadProperty("TenDT", true);
				return _tenDT;
			}
			set 
			{
				CanWriteProperty("TenDT", true);
				if (_tenDT != value) 
				{
					_tenDT = value;
					PropertyHasChanged("TenDT");
				}
			}
		}
		
		public Decimal bhtra
		{
			get 
			{
				CanReadProperty("bhtra", true);
				return _bhtra;
			}
			set 
			{
				CanWriteProperty("bhtra", true);
				if (_bhtra != value) 
				{
					_bhtra = value;
					PropertyHasChanged("bhtra");
				}
			}
		}
		
		public Decimal Sotien
		{
			get 
			{
				CanReadProperty("Sotien", true);
				return _sotien;
			}
			set 
			{
				CanWriteProperty("Sotien", true);
				if (_sotien != value) 
				{
					_sotien = value;
					PropertyHasChanged("Sotien");
				}
			}
		}
        public Decimal sotienKTC
        {
            get
            {
                CanReadProperty("sotienKTC", true);
                return _sotienKTC;
            }
            set
            {
                CanWriteProperty("sotienKTC", true);
                if (_sotienKTC != value)
                {
                    _sotienKTC = value;
                    PropertyHasChanged("sotienKTC");
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
        public bool chon
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _chon;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_chon.Equals(value))
                {
                    _chon = value;
                    //PropertyHasChanged();
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

        public String KieuThe
        {
            get
            {
                CanReadProperty("KieuThe", true);
                return _kieuThe;
            }
            set
            {
                CanWriteProperty("KieuThe", true);
                if (_kieuThe != value)
                {
                    _kieuThe = value;
                    PropertyHasChanged("KieuThe");
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
			return _maDT;
		}
		
		#endregion
		#endregion
				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDoiTuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
		public static DMDoiTuong GetDMDoiTuong(String maDT)
		{
			return DataPortal.Fetch<DMDoiTuong>(new Criteria(maDT));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDoiTuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDoiTuong(String maDT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDoiTuong()
		{	
			// Prevent direct creation
		}
        internal DMDoiTuong(int ordernumber, string MaDT, string TenDT, Decimal bhtra, Decimal sotien, Decimal sotienKTC, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, Boolean chon, string kieuthe)
        {
            _OrderNumber = ordernumber;
            _maDT  = MaDT ;
            _tenDT  = TenDT;
            _bhtra = bhtra;
            _sotien = sotien;
            _sotienKTC = sotienKTC;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _chon = chon;
            _kieuThe = kieuthe;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDT;
			public String MaDT 
			{
				get
				{
					return _maDT;
				}
			}
			
			public Criteria(String maDT)
			{
				_maDT = maDT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDT.Equals(c._maDT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDT)
            {
                _maDT = maDT;
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
		/// Retrieve an existing <see cref="DMDoiTuong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDoiTuong(String _maDT);
			// public override IDataReader GetDMDoiTuong(String _maDT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDoiTuong(crit.MaDT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDoiTuong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
			if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
			if (dr.GetDecimal("bhtra") != null) _bhtra = dr.GetDecimal("bhtra");
			if (dr.GetDecimal("Sotien") != null) _sotien = dr.GetDecimal("Sotien");
            if (dr.GetDecimal("sotienKTC") != null) _sotienKTC = dr.GetDecimal("sotienKTC");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Kieuthe") != null) _kieuThe = dr.GetString("Kieuthe");
           		}
		
		/// <summary>
		/// Insert the new <see cref="DMDoiTuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDoiTuong
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maDT = DataProvider.Instance().InsertDMDoiTuong(_tenDT, _bhtra, _sotien,sotienKTC, _maMay, _nguoiSD , _kieuThe);
			// public abstract String InsertDMDoiTuong(String _maDT, String _tenDT, Decimal _bhtra, Decimal _sotien, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMDoiTuong(String _maDT, String _tenDT, Decimal _bhtra, Decimal _sotien, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _tenDT, _bhtra, _sotien, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDoiTuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDoiTuong
			if (IsDirty){


                DataProvider.Instance().UpdateDMDoiTuong(_maDT, _tenDT, _bhtra, _sotien, sotienKTC,_maMay, _nguoiSD, _kieuThe);
				// public abstract void UpdateDMDoiTuong(String _maDT, String _tenDT, Decimal _bhtra, Decimal _sotien, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMDoiTuong(String _maDT, String _tenDT, Decimal _bhtra, Decimal _sotien, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _tenDT, _bhtra, _sotien, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,  _maDT));
		}

		/// <summary>
		/// Delete the <see cref="DMDoiTuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDoiTuong
			DataProvider.Instance().DeleteDMDoiTuong(crit.MaMay,crit.NguoiSD,  crit.MaDT);
			// public abstract void DeleteDMDoiTuong(String _maDT);
			// public override void DeleteDMDoiTuong(String _maDT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT);
			// }
		}

		#endregion
	}

}
