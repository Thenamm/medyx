// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_DanhMuc
// Kieu doi tuong  :	BC_DanhMuc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 3:53:20 PM
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

namespace HTC.Business.KHTH
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BC_DanhMuc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_DanhMuc : BusinessBase<BC_DanhMuc>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _ma = String.Empty;
		private String _donVi = String.Empty;
		private String _maLoai = String.Empty;
		private String _loaiBC = String.Empty;
		private String _ten = String.Empty;
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private int _OrderNumber;
        private String _tenLoai = String.Empty;
        private String _tennguoiSD = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String Ma
		{
			get 
			{
				CanReadProperty("Ma", true);
				return _ma;
			}
			set 
			{
				CanWriteProperty("Ma", true);
				if (_ma != value) 
				{
					_ma = value;
					PropertyHasChanged("Ma");
				}
			}
		}
		
		public String DonVi
		{
			get 
			{
				CanReadProperty("DonVi", true);
				return _donVi;
			}
			set 
			{
				CanWriteProperty("DonVi", true);
				if (_donVi != value) 
				{
					_donVi = value;
					PropertyHasChanged("DonVi");
				}
			}
		}
		
		public String MaLoai
		{
			get 
			{
				CanReadProperty("MaLoai", true);
				return _maLoai;
			}
			set 
			{
				CanWriteProperty("MaLoai", true);
				if (_maLoai != value) 
				{
					_maLoai = value;
					PropertyHasChanged("MaLoai");
				}
			}
		}
		
		public String LoaiBC
		{
			get 
			{
				CanReadProperty("LoaiBC", true);
				return _loaiBC;
			}
			set 
			{
				CanWriteProperty("LoaiBC", true);
				if (_loaiBC != value) 
				{
					_loaiBC = value;
					PropertyHasChanged("LoaiBC");
				}
			}
		}
		
		public String Ten
		{
			get 
			{
				CanReadProperty("Ten", true);
				return _ten;
			}
			set 
			{
				CanWriteProperty("Ten", true);
				if (_ten != value) 
				{
					_ten = value;
					PropertyHasChanged("Ten");
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
		
		public string Ngaysd
		{
			get 
			{
				CanReadProperty("Ngaysd", true);
                _ngaysd.FormatString = "dd/MM/yyyy  hh:mm";
				return _ngaysd.Text;
			}
			set 
			{
				CanWriteProperty("Ngaysd", true);
				if (_ngaysd.Text != value) 
				{
					_ngaysd.Text = value;
					PropertyHasChanged("Ngaysd");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
        public String TenLoai
        {
            get
            {
                CanReadProperty("TenLoai", true);
                return _tenLoai;
            }
            set
            {
                CanWriteProperty("TenLoai", true);
                if (_tenLoai != value)
                {
                    _tenLoai = value;
                    PropertyHasChanged("TenLoai");
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
			return _ma;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_DanhMuc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BC_DanhMuc NewBC_DanhMuc()
        {
            return new BC_DanhMuc();
            // return DataPortal.Create<BC_DuocBV>();
        }
        internal static BC_DanhMuc GetBC_DanhMuc(SafeDataReader dr, int i)
        {
            return new BC_DanhMuc(dr, i);
        }
        //public static BC_DanhMuc GetBC_DanhMuc(String ma)
        //{
        //    return DataPortal.Fetch<BC_DanhMuc>(new Criteria(ma));
        //}
		
		/// <summary>
		/// Marks the <see cref="BC_DanhMuc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_DanhMuc(String ma)
		{
			DataPortal.Delete(new Criteria(ma));
		}
        public BC_DanhMuc()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_DanhMuc()
        //{	
        //    // Prevent direct creation
        //}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _ma;
			public String Ma 
			{
				get
				{
					return _ma;
				}
			}
			
			public Criteria(String ma)
			{
				_ma = ma;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_ma.Equals(c._ma)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _ma.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaOther
        {
            private String _ma;
            public String MA
            {
                get
                {
                    return _ma;
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
            public CriteriaOther(String Mamay, String Nguoisd, String ma)
            {
                _ma = ma;
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
		/// Retrieve an existing <see cref="BC_DanhMuc" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_DanhMuc(String _ma);
        //    // public override IDataReader GetBC_DanhMuc(String _ma)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _ma));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_DanhMuc(crit.Ma)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_DanhMuc" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
        //    if (dr.GetString("DonVi") != null) _donVi = dr.GetString("DonVi");
        //    if (dr.GetString("MaLoai") != null) _maLoai = dr.GetString("MaLoai");
        //    if (dr.GetString("LoaiBC") != null) _loaiBC = dr.GetString("LoaiBC");
        //    if (dr.GetString("Ten") != null) _ten = dr.GetString("Ten");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //}
        private BC_DanhMuc(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetString("DonVi") != null) _donVi = dr.GetString("DonVi");
            if (dr.GetString("MaLoai") != null) _maLoai = dr.GetString("MaLoai");
            if (dr.GetString("LoaiBC") != null) _loaiBC = dr.GetString("LoaiBC");
            if (dr.GetString("Ten") != null) _ten = dr.GetString("Ten");
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenLoai") != null) _tenLoai = dr.GetString("TenLoai");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_DanhMuc" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_ma = DataProvider.Instance().InsertBC_DanhMuc(_donVi, _maLoai, _loaiBC, _ten, _nguoiSD , _maMay);
			// public abstract String InsertBC_DanhMuc(String _donVi, String _maLoai, String _loaiBC, String _ten, String _nguoiSD, String _maMay);
			// public override String InsertBC_DanhMuc(String _donVi, String _maLoai, String _loaiBC, String _ten, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_DanhMuc_CREATE", _donVi, _maLoai, _loaiBC, _ten, _nguoiSD , _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_DanhMuc" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_DanhMuc(_ma, _donVi, _maLoai, _loaiBC, _ten, _nguoiSD , _huy, _maMay);
				// public abstract void UpdateBC_DanhMuc(String _ma, String _donVi, String _maLoai, String _loaiBC, String _ten, String _nguoiSD, Boolean _huy, String _maMay);
				// public override void UpdateBC_DanhMuc(String _ma, String _donVi, String _maLoai, String _loaiBC, String _ten, String _nguoiSD, Boolean _huy, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_DanhMuc_Update", _ma, _donVi, _maLoai, _loaiBC, _ten, _nguoiSD , _huy, _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _ma));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_DanhMuc" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_DanhMuc
            DataProvider.Instance().DeleteBC_DanhMuc(crit.MaMay, crit.NguoiSD, crit.MA);
			// public abstract void DeleteBC_DanhMuc(String _ma);
			// public override void DeleteBC_DanhMuc(String _ma)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_DanhMuc_Deleted", _ma);
			// }
		}

		#endregion
	}

}
