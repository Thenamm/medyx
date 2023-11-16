// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTBVTYT_KhoKhoa
// Kieu doi tuong  :	DMTBVTYT_KhoKhoa
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
	/// This is a base generated class of <see cref="DMTBVTYT_KhoKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTBVTYT_KhoKhoa : BusinessBase<DMTBVTYT_KhoKhoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _makho = String.Empty;
		private Decimal _sTT = 0;
		private String _makhoa = String.Empty;
		private String _maVT = String.Empty;
		private Boolean  _huy = false;
       
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenKho = String.Empty;
        private String _tenKhoa = String.Empty;
        private string _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tennguoiSD = String.Empty;

		#endregion
		
		#region Business Properties and Methods
        public string TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
		public String Makho
		{
			get 
			{
				CanReadProperty("Makho", true);
				return _makho;
			}
			set 
			{
				CanWriteProperty("Makho", true);
				if (_makho != value) 
				{
					_makho = value;
					PropertyHasChanged("Makho");
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
		
		public String MaVT
		{
			get 
			{
				CanReadProperty("MaVT", true);
				return _maVT;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_maVT != value) 
				{
					_maVT = value;
					PropertyHasChanged("MaVT");
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

        public String TenKho
        {
            get
            {
                CanReadProperty("TenKho", true);
                return _tenKho;
            }
            set
            {
                CanWriteProperty("TenKho", true);
                if (_tenKho != value)
                {
                    _tenKho = value;
                    PropertyHasChanged("TenKho");
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
        public String TENDVT
        {
            get
            {
                CanReadProperty("TENDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TENDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TENDVT");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _makho.ToString() + "!" + _sTT.ToString().ToString() + "!" + _makhoa.ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTBVTYT_KhoKhoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTBVTYT_KhoKhoa NewDMTBVTYT_KhoKhoa()
        {
            return new DMTBVTYT_KhoKhoa();
            //return DataPortal.Create<DMTBVTYT_KhoKhoa>();
        }
        ////public static DMTBVTYT_KhoKhoa GetDMTBVTYT_KhoKhoa(String makho, Decimal sTT, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMTBVTYT_KhoKhoa>(new Criteria(makho, sTT, makhoa));
        ////}
        internal static DMTBVTYT_KhoKhoa GetDMTBVTYT_KhoKhoa(SafeDataReader dr)
        {
            return new DMTBVTYT_KhoKhoa(dr);
        }
		/// <summary>
		/// Marks the <see cref="DMTBVTYT_KhoKhoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMTBVTYT_KhoKhoa(String makho, Decimal sTT, String makhoa)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,makho, sTT, makhoa));
        //}
        public DMTBVTYT_KhoKhoa()
        {
            MarkAsChild();
        }

		#endregion
		
        ////#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        ////protected internal DMTBVTYT_KhoKhoa()
        ////{	
        ////     Prevent direct creation
        ////}

        ////internal DMTBVTYT_KhoKhoa(Decimal ordernumber, String makho,
        ////                             String makhoa ,
        ////                             String maVT ,
        ////                             Boolean huy ,
        ////                             SmartDate ngaySD ,
        ////                             String nguoiSD ,
        ////                             String maMay ,
        ////                             String tenKho ,
        ////                             String tenKhoa,
        ////                             string tenTM)
        ////{
        ////                               _sTT = ordernumber;
        ////                               _makho = makho ;
        ////                              _makhoa = makhoa  ;
        ////                              _maVT = maVT  ;
        ////                              _huy = huy  ;
        ////                              _ngaySD = ngaySD  ;
        ////                              _nguoiSD = nguoiSD  ;
        ////                              _maMay = maMay  ;
        ////                              _tenKho = tenKho  ;
        ////                              _tenKhoa = tenKhoa;
        ////                              _tenTM = TenTM;
  
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

            public OtherCriteria(String Mamay, String Nguoisd, String makho, Decimal sTT, String makhoa)
            {
                _makho = makho;
                _sTT = sTT;
                _makhoa = makhoa;
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
		/// Retrieve an existing <see cref="DMTBVTYT_KhoKhoa" /> Object based on data in the database.
		/// </summary>
        ////protected void DataPortal_Fetch(Criteria crit)
        ////{
        ////    // public abstract IDataReader GetDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        ////    // public override IDataReader GetDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa)
        ////    // {
        ////    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makho, _sTT, _makhoa));
        ////    // }
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTBVTYT_KhoKhoa(crit.Makho, crit.STT, crit.Makhoa)))
        ////    {
        ////        if (dr.Read()){
        ////            Fetch(dr);
        ////            MarkOld();
        ////            ValidationRules.CheckRules();
        ////        }
        ////    }
        ////}
		/// <summary>
		/// Load a <see cref="DMTBVTYT_KhoKhoa" /> Object from given SafeDataReader.
		/// </summary>
        ////private void Fetch(SafeDataReader dr)
        ////{
        ////    // Value properties
        ////    if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
        ////    if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
        ////    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        ////    if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
        ////    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        ////    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        ////    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        ////    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        ////    if (dr.GetString("Tenkho") != null) _tenKho  = dr.GetString("Tenkho");
        ////    if (dr.GetString("Tenkhoa") != null) _tenKhoa = dr.GetString("Tenkhoa");
        ////    if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
        ////}
        private  DMTBVTYT_KhoKhoa(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("Tenkho") != null) _tenKho = dr.GetString("Tenkho");
            if (dr.GetString("Tenkhoa") != null) _tenKhoa = dr.GetString("Tenkhoa");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TENDVT") != null) _tenDVT = dr.GetString("TENDVT");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="DMTBVTYT_KhoKhoa" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTBVTYT_KhoKhoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_makho = DataProvider.Instance().InsertDMTBVTYT_KhoKhoa(_makho, _makhoa, _maVT, _nguoiSD , _maMay);
			// public abstract String InsertDMTBVTYT_KhoKhoa(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay);
			// public override String InsertDMTBVTYT_KhoKhoa(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBVTYT_KhoKhoa_Create", _makho, _makhoa, _maVT, _nguoiSD , _maMay), String);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTBVTYT_KhoKhoa" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTBVTYT_KhoKhoa
			 if (!this.IsDirty)
                return;
                //
                //  
				DataProvider.Instance().UpdateDMTBVTYT_KhoKhoa(_makho, _sTT, _makhoa, _maVT, _huy, _nguoiSD , _maMay);
				// public abstract void UpdateDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBVTYT_KhoKhoa_Update", _makho, _sTT, _makhoa, _maVT, _huy, _nguoiSD , _maMay);
				// }				
                MarkOld();
		}
        //internal void Delete()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTBVTYT_KhoKhoa
        //    if (!this.IsDirty)
        //        return;
        //    
        //      
        //    DataProvider.Instance().DeleteDMTBVTYT_KhoKhoa(_makho, _sTT, _makhoa);
        //    // public abstract void UpdateDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
        //    // public override void UpdateDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBVTYT_KhoKhoa_Update", _makho, _sTT, _makhoa, _maVT, _huy, _nguoiSD , _maMay);
        //    // }				
        //    MarkOld();
        //}
        //internal void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _makho, _sTT, _makhoa));
        //}

        /// <summary>
        /// Delete the <see cref="DMTBVTYT_KhoKhoa" />.
        /// </summary>
        //internal void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTBVTYT_KhoKhoa
        //    DataProvider.Instance().DeleteDMTBVTYT_KhoKhoa(crit.MaMay, crit.NguoiSD, crit.Makho, crit.STT, crit.Makhoa);
        //    // public abstract void DeleteDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        //    // public override void DeleteDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBVTYT_KhoKhoa_Deleted", _makho, _sTT, _makhoa);
        //    // }
        //}

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _makho, _sTT, _makhoa));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMTBVTYT_KhoKhoa(crit.MaMay, crit.NguoiSD, crit.Makho, crit.STT, crit.Makhoa);
        }

		#endregion
	}

}
