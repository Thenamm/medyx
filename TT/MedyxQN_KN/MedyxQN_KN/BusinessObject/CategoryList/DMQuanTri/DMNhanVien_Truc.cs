// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNhanVien_Truc
// Kieu doi tuong  :	DMNhanVien_Truc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/17/2009 3:10:21 PM
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
	/// This is a base generated class of <see cref="DMNhanVien_Truc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNhanVien_Truc : BusinessBase<DMNhanVien_Truc>
	{
		#region Business Methods
		
		#region State Fields
		
		private Decimal _sTT = 0;
		private String _makhoa = String.Empty;
		private String _MaNV = String.Empty;
		private Boolean  _huy = false;
        private SmartDate _TuNgayDK = new SmartDate(true);
        private SmartDate _DenNgayDK = new SmartDate(true);
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenKhoa = String.Empty;
        private string _HoTen = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;
        //private String _hamLuong = String.Empty;
        //private String _tenDVTHL = String.Empty;
		#endregion
		
		#region Business Properties and Methods
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
        public string HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _HoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_HoTen != value)
                {
                    _HoTen = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }
	
		
		public Decimal STT
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
		
		public String Makhoa
		{
			get 
			{
				CanReadProperty("Makhoa", true);
				return _makhoa;
			}
			set 
			{
				CanWriteProperty("Makhoa", true);
				if (_makhoa != value) 
				{
					_makhoa = value;
					PropertyHasChanged("Makhoa");
				}
			}
		}
		
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _MaNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_MaNV != value) 
				{
					_MaNV = value;
					PropertyHasChanged("MaNV");
				}
			}
		}
		
		public Boolean huy
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
                _ngaySD.FormatString = "dd/MM/yyyy";
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
        public string TuNgayDK
        {
            get
            {
                CanReadProperty("TuNgayDK", true);
                _TuNgayDK.FormatString = "dd/MM/yyyy";
                return _TuNgayDK.Text;
            }
            set
            {
                CanWriteProperty("TuNgayDK", true);
                if (_TuNgayDK.Text != value)
                {
                    _TuNgayDK.Text = value;
                    PropertyHasChanged("TuNgayDK");
                }
            }
        }
        public string DenNgayDK
        {
            get
            {
                CanReadProperty("DenNgayDK", true);
                _DenNgayDK.FormatString = "dd/MM/yyyy";
                return _DenNgayDK.Text;
            }
            set
            {
                CanWriteProperty("DenNgayDK", true);
                if (_DenNgayDK.Text != value)
                {
                    _DenNgayDK.Text = value;
                    PropertyHasChanged("DenNgayDK");
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

       

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
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
		protected override Object GetIdValue()
		{
			return _sTT.ToString().ToString() + "!" + _MaNV.ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMNhanVien_Truc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNhanVien_Truc NewDMNhanVien_Truc()
        {
            return new DMNhanVien_Truc();
            //return DataPortal.Create<DMNhanVien_Truc>();
        }
        ////public static DMNhanVien_Truc GetDMNhanVien_Truc(String makho, Decimal sTT, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMNhanVien_Truc>(new Criteria(makho, sTT, makhoa));
        ////}
        internal static DMNhanVien_Truc GetDMNhanVien_Truc(int i,SafeDataReader dr)
        {
            return new DMNhanVien_Truc(i,dr);
        }
		/// <summary>
		/// Marks the <see cref="DMNhanVien_Truc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMNhanVien_Truc(String makho, Decimal sTT, String makhoa)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,makho, sTT, makhoa));
        //}
        public DMNhanVien_Truc()
        {
            MarkAsChild();
        }

		#endregion
		
        ////#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        ////protected internal DMNhanVien_Truc()
        ////{	
        ////     Prevent direct creation
        ////}

        ////internal DMNhanVien_Truc(Decimal ordernumber, String makho,
        ////                             String makhoa ,
        ////                             String MaNV ,
        ////                             Boolean huy ,
        ////                             SmartDate ngaySD ,
        ////                             String nguoiSD ,
        ////                             String maMay ,
        ////                             String tenKho ,
        ////                             String tenKhoa,
        ////                             string HoTen)
        ////{
        ////                               _sTT = ordernumber;
        ////                               _makho = makho ;
        ////                              _makhoa = makhoa  ;
        ////                              _MaNV = MaNV  ;
        ////                              _huy = huy  ;
        ////                              _ngaySD = ngaySD  ;
        ////                              _nguoiSD = nguoiSD  ;
        ////                              _maMay = maMay  ;
        ////                              _tenKho = tenKho  ;
        ////                              _tenKhoa = tenKhoa;
        ////                              _HoTen = HoTen;
  
        ////}

        ////#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _makho;
			public String Makho 
			{
				get
				{
					return _makho;
				}
			}
			
			private Decimal _sTT;
			public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private String _makhoa;
			public String Makhoa 
			{
				get
				{
					return _makhoa;
				}
			}
			
			public Criteria(String makho, Decimal sTT, String makhoa)
			{
				_makho = makho;
				_sTT = sTT;
				_makhoa = makhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_makho.Equals(c._makho)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_makhoa.Equals(c._makhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _makho.ToString(), _sTT.ToString(), _makhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
         
            private Decimal _sTT;
            public Decimal STT
            {
                get
                {
                    return _sTT;
                }
            }

            private string _manv;
            public string manv
            {
                get
                {
                    return _manv;
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

            public OtherCriteria(String Mamay, String Nguoisd,  Decimal sTT, string    MaNV)
            {
                 _sTT = sTT;
                 _manv = MaNV;
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
		/// Retrieve an existing <see cref="DMNhanVien_Truc" /> Object based on data in the database.
		/// </summary>
        ////protected void DataPortal_Fetch(Criteria crit)
        ////{
        ////    // public abstract IDataReader GetDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa);
        ////    // public override IDataReader GetDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa)
        ////    // {
        ////    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makho, _sTT, _makhoa));
        ////    // }
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNhanVien_Truc(crit.Makho, crit.STT, crit.Makhoa)))
        ////    {
        ////        if (dr.Read()){
        ////            Fetch(dr);
        ////            MarkOld();
        ////            ValidationRules.CheckRules();
        ////        }
        ////    }
        ////}
		/// <summary>
		/// Load a <see cref="DMNhanVien_Truc" /> Object from given SafeDataReader.
		/// </summary>
        ////private void Fetch(SafeDataReader dr)
        ////{
        ////    // Value properties
        ////    if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
        ////    if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
        ////    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        ////    if (dr.GetString("MaNV") != null) _MaNV = dr.GetString("MaNV");
        ////    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        ////    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        ////    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        ////    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        ////    if (dr.GetString("Tenkho") != null) _tenKho  = dr.GetString("Tenkho");
        ////    if (dr.GetString("Tenkhoa") != null) _tenKhoa = dr.GetString("Tenkhoa");
        ////    if (dr.GetString("HoTen") != null) _HoTen = dr.GetString("HoTen");
        ////}
        private  DMNhanVien_Truc(int i,SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
             if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaNV") != null) _MaNV = dr.GetString("MaNV");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("TuNgayDK", true) != null) _TuNgayDK = dr.GetSmartDate("TuNgayDK", true);
            if (dr.GetSmartDate("DenNgayDK", true) != null) _DenNgayDK = dr.GetSmartDate("DenNgayDK", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("Tenkhoa") != null) _tenKhoa = dr.GetString("Tenkhoa");
            if (dr.GetString("HoTen") != null) _HoTen = dr.GetString("HoTen");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            //if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
            //if (dr.GetString("TENDVTHL") != null) _tenDVTHL  = dr.GetString("TENDVTHL");
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="DMNhanVien_Truc" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNhanVien_Truc
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


         _sTT =   DataProvider.Instance().InsertDMNhanVien_Truc(_makhoa, _MaNV, _TuNgayDK,_DenNgayDK , _nguoiSD, _maMay);
			// public abstract String InsertDMNhanVien_Truc(String _makho, String _makhoa, String _MaNV, String _nguoiSD, String _maMay);
			// public override String InsertDMNhanVien_Truc(String _makho, String _makhoa, String _MaNV, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhanVien_Truc_Create", _makho, _makhoa, _MaNV, _nguoiSD , _maMay), String);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNhanVien_Truc" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhanVien_Truc
			 if (!this.IsDirty)
                return;
                //
                //  
             DataProvider.Instance().UpdateDMNhanVien_Truc(_sTT, _makhoa, _MaNV, _TuNgayDK,_DenNgayDK , _huy, _nguoiSD, _maMay);
				// public abstract void UpdateDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa, String _MaNV, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa, String _MaNV, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhanVien_Truc_Update", _makho, _sTT, _makhoa, _MaNV, _huy, _nguoiSD , _maMay);
				// }				
                MarkOld();
		}
        //internal void Delete()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhanVien_Truc
        //    if (!this.IsDirty)
        //        return;
        //    
        //      
        //    DataProvider.Instance().DeleteDMNhanVien_Truc(_makho, _sTT, _makhoa);
        //    // public abstract void UpdateDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa, String _MaNV, Boolean _huy, String _nguoiSD, String _maMay);
        //    // public override void UpdateDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa, String _MaNV, Boolean _huy, String _nguoiSD, String _maMay)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhanVien_Truc_Update", _makho, _sTT, _makhoa, _MaNV, _huy, _nguoiSD , _maMay);
        //    // }				
        //    MarkOld();
        //}
        //internal void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _makho, _sTT, _makhoa));
        //}

        /// <summary>
        /// Delete the <see cref="DMNhanVien_Truc" />.
        /// </summary>
        //internal void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhanVien_Truc
        //    DataProvider.Instance().DeleteDMNhanVien_Truc(crit.MaMay, crit.NguoiSD, crit.Makho, crit.STT, crit.Makhoa);
        //    // public abstract void DeleteDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa);
        //    // public override void DeleteDMNhanVien_Truc(String _makho, Decimal _sTT, String _makhoa)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhanVien_Truc_Deleted", _makho, _sTT, _makhoa);
        //    // }
        //}

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _sTT, _MaNV ));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMNhanVien_Truc(crit.MaMay, crit.NguoiSD, crit.STT, crit.manv);
        }

		#endregion
	}

}
