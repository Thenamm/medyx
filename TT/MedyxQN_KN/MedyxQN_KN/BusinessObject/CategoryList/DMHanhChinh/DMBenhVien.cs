// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMBenhVien
// Kieu doi tuong  :	DMBenhVien
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/4/2008 3:32:39 PM
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
	/// This is a base generated class of <see cref="DMBenhVien" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMBenhVien : BusinessBase<DMBenhVien>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBV = String.Empty;
		private String _tenBV = String.Empty;
        private String _tenTA = String.Empty;
		private String _maBHXH = String.Empty;
		private String _matinh = String.Empty;
		private String _diachi = String.Empty;
		private String _tel = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _tenTinh = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		public string  TenTinh
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _tenTinh;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_tenTinh.Equals(value))
                {
                    _tenTinh = value;
                    //PropertyHasChanged();
                }
            }
        }
		public String MaBV
		{
			get 
			{
				CanReadProperty("MaBV", true);
				return _maBV;
			}
			set 
			{
				CanWriteProperty("MaBV", true);
				if (_maBV != value) 
				{
					_maBV = value;
					PropertyHasChanged("MaBV");
				}
			}
		}
		
		public String TenBV
		{
			get 
			{
				CanReadProperty("TenBV", true);
				return _tenBV;
			}
			set 
			{
				CanWriteProperty("TenBV", true);
				if (_tenBV != value) 
				{
					_tenBV = value;
					PropertyHasChanged("TenBV");
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
        public String MaBHXHTenBV
        {
            get
            {
               
                return _maBHXH+"          "+_tenBV;
            }
           
        }
		public String Matinh
		{
			get 
			{
				CanReadProperty("Matinh", true);
				return _matinh;
			}
			set 
			{
				CanWriteProperty("Matinh", true);
				if (_matinh != value) 
				{
					_matinh = value;
					PropertyHasChanged("Matinh");
				}
			}
		}
		
		public String Diachi
		{
			get 
			{
				CanReadProperty("Diachi", true);
				return _diachi;
			}
			set 
			{
				CanWriteProperty("Diachi", true);
				if (_diachi != value) 
				{
					_diachi = value;
					PropertyHasChanged("Diachi");
				}
			}
		}
		
		public String Tel
		{
			get 
			{
				CanReadProperty("Tel", true);
				return _tel;
			}
			set 
			{
				CanWriteProperty("Tel", true);
				if (_tel != value) 
				{
					_tel = value;
					PropertyHasChanged("Tel");
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

		protected override Object GetIdValue()
		{
			return _maBV;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMBenhVien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMBenhVien NewDMBenhVien()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new DMBenhVien();
        }
		public static DMBenhVien GetDMBenhVien(String maBV)
		{
			return DataPortal.Fetch<DMBenhVien>(new Criteria(maBV));
		}
		
		/// <summary>
		/// Marks the <see cref="DMBenhVien" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMBenhVien(String maBV, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBV));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMBenhVien()
		{	
			// Prevent direct creation
		}
        internal DMBenhVien(int ordernumber, String maBV, String tenBV, String maBHXH, String matinh, String diachi,
            String tel, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String tenTA, string tentinh)
        {
            _OrderNumber = ordernumber;
            _maBV = maBV;
            _tenBV = tenBV;
            _maBHXH = maBHXH;
            _matinh = matinh;
            _diachi = diachi;
            _tel = tel;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _tenTA = tenTA;
            _tenTinh = tentinh ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBV;
			public String MaBV 
			{
				get
				{
					return _maBV;
				}
			}
			
			public Criteria(String maBV)
			{
				_maBV = maBV;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBV.Equals(c._maBV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBV.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBV;
            public String maBV
            {
                get
                {
                    return _maBV;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBV)
            {
                _maBV = maBV;
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
		/// Retrieve an existing <see cref="DMBenhVien" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMBenhVien(String _maBV);
			// public override IDataReader GetDMBenhVien(String _maBV)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBV));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMBenhVien(crit.MaBV)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMBenhVien" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
			if (dr.GetString("TenBV") != null) _tenBV = dr.GetString("TenBV");
            if (dr.GetString("TenTA") != null) _tenTA = dr.GetString("TenTA");
			if (dr.GetString("MaBHXH") != null) _maBHXH = dr.GetString("MaBHXH");
			if (dr.GetString("Matinh") != null) _matinh = dr.GetString("Matinh");
			if (dr.GetString("Diachi") != null) _diachi = dr.GetString("Diachi");
			if (dr.GetString("Tel") != null) _tel = dr.GetString("Tel");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenTinh") != null) _tenTinh = dr.GetString("TenTinh");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMBenhVien" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMBenhVien
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maBV = DataProvider.Instance().InsertDMBenhVien(_tenBV, _maBHXH, _matinh, _diachi, _tel, _maMay,_nguoiSD, _tenTA );
			// public abstract String InsertDMBenhVien(String _maBV, String _tenBV, String _maBHXH, String _matinh, String _diachi, String _tel, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMBenhVien(String _maBV, String _tenBV, String _maBHXH, String _matinh, String _diachi, String _tel, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBV, _tenBV, _maBHXH, _matinh, _diachi, _tel, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMBenhVien" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMBenhVien
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMBenhVien(_maBV, _tenBV, _maBHXH, _matinh, _diachi, _tel, _maMay, _nguoiSD , _tenTA);
				// public abstract void UpdateDMBenhVien(String _maBV, String _tenBV, String _maBHXH, String _matinh, String _diachi, String _tel, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMBenhVien(String _maBV, String _tenBV, String _maBHXH, String _matinh, String _diachi, String _tel, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBV, _tenBV, _maBHXH, _matinh, _diachi, _tel, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_maBV   ));
		}

		/// <summary>
		/// Delete the <see cref="DMBenhVien" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMBenhVien
			DataProvider.Instance().DeleteDMBenhVien(crit.MaMay, crit.NguoiSD, crit.maBV );
			// public abstract void DeleteDMBenhVien(String _maBV);
			// public override void DeleteDMBenhVien(String _maBV);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBV);
			// }
		}

		#endregion
	}

}
