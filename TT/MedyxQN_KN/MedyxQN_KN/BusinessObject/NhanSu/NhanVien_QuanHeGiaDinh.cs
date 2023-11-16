// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhanVien_QuanHeGiaDinh
// Kieu doi tuong  :	NhanVien_QuanHeGiaDinh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/12/2009 10:18:37 AM
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

namespace HTC.Business.NhanSu
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NhanVien_QuanHeGiaDinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NhanVien_QuanHeGiaDinh : BusinessBase<NhanVien_QuanHeGiaDinh>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private String _maNV = String.Empty;
		private String _maQHGiaDinh = String.Empty;
		private String _hoten = String.Empty;
		private Int16 _namsinh = 0;
		private String _maNN = String.Empty;
		private String _noilamviec = String.Empty;
		private String _diachi = String.Empty;
		private Boolean _huy = false;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenQHGiaDinh = String.Empty;
        private String _tenNN = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public Int32 STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
		
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _maNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_maNV != value) 
				{
					_maNV = value;
					PropertyHasChanged("MaNV");
				}
			}
		}
		
		public String MaQHGiaDinh
		{
			get 
			{
				CanReadProperty("MaQHGiaDinh", true);
				return _maQHGiaDinh;
			}
			set 
			{
				CanWriteProperty("MaQHGiaDinh", true);
				if (_maQHGiaDinh != value) 
				{
					_maQHGiaDinh = value;
					PropertyHasChanged("MaQHGiaDinh");
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
		
		public Int16 Namsinh
		{
			get 
			{
				CanReadProperty("Namsinh", true);
				return _namsinh;
			}
			set 
			{
				CanWriteProperty("Namsinh", true);
				if (_namsinh != value) 
				{
					_namsinh = value;
					PropertyHasChanged("Namsinh");
				}
			}
		}
		
		public String MaNN
		{
			get 
			{
				CanReadProperty("MaNN", true);
				return _maNN;
			}
			set 
			{
				CanWriteProperty("MaNN", true);
				if (_maNN != value) 
				{
					_maNN = value;
					PropertyHasChanged("MaNN");
				}
			}
		}
		
		public String Noilamviec
		{
			get 
			{
				CanReadProperty("Noilamviec", true);
				return _noilamviec;
			}
			set 
			{
				CanWriteProperty("Noilamviec", true);
				if (_noilamviec != value) 
				{
					_noilamviec = value;
					PropertyHasChanged("Noilamviec");
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public String TenQHGiaDinh
        {
            get
            {
                CanReadProperty("TenQHGiaDinh", true);
                return _tenQHGiaDinh;
            }
            set
            {
                CanWriteProperty("TenQHGiaDinh", true);
                if (_tenQHGiaDinh != value)
                {
                    _tenQHGiaDinh = value;
                    PropertyHasChanged("TenQHGiaDinh");
                }
            }
        }

        public String TenNN
        {
            get
            {
                CanReadProperty("TenNN", true);
                return _tenNN ;
            }
            set
            {
                CanWriteProperty("TenNN", true);
                if (_tenNN != value)
                {
                    _tenNN = value;
                    PropertyHasChanged("TenNN");
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
			return _sTT.ToString() + "!" + _maNV.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NhanVien_QuanHeGiaDinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static NhanVien_QuanHeGiaDinh GetNhanVien_QuanHeGiaDinh(Int32 sTT, String maNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QuanHeGiaDinh>(new Criteria(sTT, maNV));
        //}
		
        ///// <summary>
        ///// Marks the <see cref="NhanVien_QuanHeGiaDinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
        ///// </summary>
        //public static void DeleteNhanVien_QuanHeGiaDinh(Int32 sTT, String maNV)
        //{
        //    DataPortal.Delete(new Criteria(sTT, maNV));
        //}
		public static NhanVien_QuanHeGiaDinh NewNhanVien_QuanHeGiaDinh()
        {
            return DataPortal.Create<NhanVien_QuanHeGiaDinh>();
        }
        internal static NhanVien_QuanHeGiaDinh GetNhanVien_QuanHeGiaDinh(SafeDataReader dr, int i)
        {
            return new NhanVien_QuanHeGiaDinh(dr, i);
        }
        public NhanVien_QuanHeGiaDinh()
        {
            MarkAsChild();
        }
		#endregion
		
        //#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NhanVien_QuanHeGiaDinh()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private String _maNV;
			public String MaNV 
			{
				get
				{
					return _maNV;
				}
			}
			
			public Criteria(Int32 sTT, String maNV)
			{
				_sTT = sTT;
				_maNV = maNV;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_maNV.Equals(c._maNV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString(), _maNV.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
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

            public OtherCriteria(String Mamay, String Nguoisd, String maNV, Int32 sTT)
            {
                _maNV = maNV;
                _sTT = sTT;
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
		/// Retrieve an existing <see cref="NhanVien_QuanHeGiaDinh" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV);
        //    // public override IDataReader GetNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _maNV));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien_QuanHeGiaDinh(crit.STT, crit.MaNV)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="NhanVien_QuanHeGiaDinh" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("MaQHGiaDinh") != null) _maQHGiaDinh = dr.GetString("MaQHGiaDinh");
        //    if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
        //    if (dr.GetInt16("Namsinh") != null) _namsinh = dr.GetInt16("Namsinh");
        //    if (dr.GetString("MaNN") != null) _maNN = dr.GetString("MaNN");
        //    if (dr.GetString("Noilamviec") != null) _noilamviec = dr.GetString("Noilamviec");
        //    if (dr.GetString("Diachi") != null) _diachi = dr.GetString("Diachi");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
        private NhanVien_QuanHeGiaDinh(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("MaQHGiaDinh") != null) _maQHGiaDinh = dr.GetString("MaQHGiaDinh");
			if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
			if (dr.GetInt16("Namsinh") != null) _namsinh = dr.GetInt16("Namsinh");
			if (dr.GetString("MaNN") != null) _maNN = dr.GetString("MaNN");
			if (dr.GetString("Noilamviec") != null) _noilamviec = dr.GetString("Noilamviec");
			if (dr.GetString("Diachi") != null) _diachi = dr.GetString("Diachi");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenQHGiaDinh") != null) _tenQHGiaDinh = dr.GetString("TenQHGiaDinh");
            if (dr.GetString("TenNN") != null) _tenNN = dr.GetString("TenNN");
            
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="NhanVien_QuanHeGiaDinh" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_DongTien
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_sTT = DataProvider.Instance().InsertNhanVien_QuanHeGiaDinh(_maNV, _maQHGiaDinh, _hoten, _namsinh, _maNN, _noilamviec, _diachi, _maMay, _nguoiSD);
			// public abstract Int32 InsertNhanVien_QuanHeGiaDinh(String _maNV, String _maQHGiaDinh, String _hoten, Int16 _namsinh, String _maNN, String _noilamviec, String _diachi, String _maMay, String _nguoiSD);
			// public override Int32 InsertNhanVien_QuanHeGiaDinh(String _maNV, String _maQHGiaDinh, String _hoten, Int16 _namsinh, String _maNN, String _noilamviec, String _diachi, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNhanVien_QuanHeGiaDinh_Create", _maNV, _maQHGiaDinh, _hoten, _namsinh, _maNN, _noilamviec, _diachi, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NhanVien_QuanHeGiaDinh" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DongTien
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdateNhanVien_QuanHeGiaDinh(_sTT, _maNV, _maQHGiaDinh, _hoten, _namsinh, _maNN, _noilamviec, _diachi, _huy, _maMay, _nguoiSD);
				// public abstract void UpdateNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV, String _maQHGiaDinh, String _hoten, Int16 _namsinh, String _maNN, String _noilamviec, String _diachi, Boolean _huy, String _maMay, String _nguoiSD);
				// public override void UpdateNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV, String _maQHGiaDinh, String _hoten, Int16 _namsinh, String _maNN, String _noilamviec, String _diachi, Boolean _huy, String _maMay, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QuanHeGiaDinh_Update", _sTT, _maNV, _maQHGiaDinh, _hoten, _namsinh, _maNN, _noilamviec, _diachi, _huy, _maMay,  _nguoiSD);
				// }				
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNV, _sTT));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="NhanVien_QuanHeGiaDinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien_QuanHeGiaDinh
            DataProvider.Instance().DeleteNhanVien_QuanHeGiaDinh(crit.MaMay, crit.NguoiSD, crit.STT, crit.MaNV);
			// public abstract void DeleteNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV);
			// public override void DeleteNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QuanHeGiaDinh_DELETED", _sTT, _maNV);
			// }
		}

		#endregion
	}

}
