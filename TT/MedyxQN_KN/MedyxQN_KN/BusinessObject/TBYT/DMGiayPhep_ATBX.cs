// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMGiayPhep_ATBX
// Kieu doi tuong  :	DMGiayPhep_ATBX
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
	/// This is a base generated class of <see cref="DMGiayPhep_ATBX" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMGiayPhep_ATBX : BusinessBase<DMGiayPhep_ATBX>
	{
        #region Business Methods

        #region State Fields
        private String _MaGP = String.Empty;
        private String _MaTB = String.Empty;
        private SmartDate _NgayCap = new SmartDate(false);
        private SmartDate _NgayHetHan = new SmartDate(false);
        private String _NoiCap = String.Empty;
        private String _GhiChu = String.Empty;
        private String _SoGP = String.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _TenTB = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Methods
        public String MaGP
        {
            get
            {
                CanReadProperty("MaGP", true);
                return _MaGP;
            }
            set
            {
                CanWriteProperty("MaGP", true);
                if (_MaGP != value)
                {
                    _MaGP = value;
                    PropertyHasChanged("MaGP");
                }
            }
        }
        public String MaTB
		{
			get 
			{
				CanReadProperty("MaTB", true);
				return _MaTB;
			}
			set 
			{
				CanWriteProperty("MaTB", true);
				if (_MaTB != value) 
				{
                    _MaTB = value;
					PropertyHasChanged("MaTB");
				}
			}
		}
        public SmartDate NgayCap
        {
            get
            {
                CanReadProperty("NgayCap", true);
                _NgayCap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayCap;
            }
            set
            {
                CanWriteProperty("NgayCap", true);
                if (_NgayCap != value)
                {
                    _NgayCap = value;
                    PropertyHasChanged("NgayCap");
                }
            }
        }
        public string txtNgayCap
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _NgayCap.ToString();
            }
        }
        public SmartDate NgayHetHan
        {
            get
            {
                CanReadProperty("NgayHetHan", true);
                _NgayHetHan.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayHetHan;
            }
            set
            {
                CanWriteProperty("NgayHetHan", true);
                if (_NgayHetHan != value)
                {
                    _NgayHetHan = value;
                    PropertyHasChanged("NgayHetHan");
                }
            }
        }
        public string txtNgayHetHan
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _NgayHetHan.ToString();
            }
        }
        public String NoiCap
        {
            get
            {
                CanReadProperty("NoiCap", true);
                return _NoiCap;
            }
            set
            {
                CanWriteProperty("NoiCap", true);
                if (_NoiCap != value)
                {
                    _NoiCap = value;
                    PropertyHasChanged("NoiCap");
                }
            }
        }
        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _GhiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_GhiChu != value)
                {
                    _GhiChu = value;
                    PropertyHasChanged("GhiChu");
                }
            }
        }
        public String SoGP
        {
            get
            {
                CanReadProperty("SoGP", true);
                return _SoGP;
            }
            set
            {
                CanWriteProperty("SoGP", true);
                if (_SoGP != value)
                {
                    _SoGP = value;
                    PropertyHasChanged("SoGP");
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
        public String TenTB
        {
            get
            {
                CanReadProperty("TenTB", true);
                return _TenTB;
            }
            set
            {
                CanWriteProperty("TenTB", true);
                if (_TenTB != value)
                {
                    _TenTB = value;
                    PropertyHasChanged("TenTB");
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
			return _MaGP;
		}
		
		#endregion
		#endregion

		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaGP", 10));
            ValidationRules.AddRule<DMGiayPhep_ATBX>(StringRequired<DMGiayPhep_ATBX>, "MaGP");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMGiayPhep_ATBX
        {

            if (target._MaGP == null || target._MaGP.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMGiayPhep_ATBX" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMGiayPhep_ATBX NewDMGiayPhep_ATBX()
        {
            return DataPortal.Create<DMGiayPhep_ATBX>();
        }
		public static DMGiayPhep_ATBX GetDMGiayPhep_ATBX_ByID(String MaGP)
		{
			return DataPortal.Fetch<DMGiayPhep_ATBX>(new Criteria(MaGP));
		}
        /// <summary>
        /// Marks the <see cref="DMGiayPhep_ATBX" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMGiayPhep_ATBX(String MaGP, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaGP));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMGiayPhep_ATBX()
		{	
			// Prevent direct creation
		}
        internal DMGiayPhep_ATBX(String MaGP,String MaTB,SmartDate NgayCap,SmartDate NgayHetHan,String NoiCap,String GhiChu, String SoGP,
Boolean huy,String maMay,SmartDate ngaySD,String nguoiSD,String TenTB,String hoten,int OrderNumber)
        {
            _MaGP = MaGP;
            _MaTB = MaTB;
            _NgayCap = NgayCap;
            _NgayHetHan = NgayHetHan;
            _NoiCap = NoiCap;
            _GhiChu = GhiChu;
            _SoGP = SoGP;
            _huy = huy;
            _maMay = maMay;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _TenTB = TenTB;
            _hoten = hoten;
            _OrderNumber = OrderNumber;
        }
        #endregion

        #region Criteria

        [Serializable()]
		protected class Criteria
		{
			private String _MaGP;
			public String MaGP 
			{
				get
				{
					return _MaGP;
				}
			}
			
			public Criteria(String MaGP)
			{
				_MaGP = MaGP;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaGP.Equals(c._MaGP)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaGP.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaGP;
            public String MaGP
            {
                get
                {
                    return _MaGP;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaGP)
            {
                _MaGP = MaGP;
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
		/// Retrieve an existing <see cref="DMGiayPhep_ATBX" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMGiayPhep_ATBX(String _MaGP);
			// public override IDataReader GetDMGiayPhep_ATBX(String _MaGP)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaGP));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMGiayPhepATBX(crit.MaGP)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
        /// <summary>
        /// Load a <see cref="DMGiayPhep_ATBX" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
		{
            // Value properties
            if (dr.GetString("MaGP") != null) _MaGP = dr.GetString("MaGP");
            if (dr.GetString("MaTB") != null) _MaTB = dr.GetString("MaTB");
            if (dr.GetSmartDate("NgayCap", false) != null) _NgayCap = dr.GetSmartDate("NgayCap", false);
            if (dr.GetSmartDate("NgayHetHan", false) != null) _NgayHetHan = dr.GetSmartDate("NgayHetHan", false);
            if (dr.GetString("NoiCap") != null) _NoiCap = dr.GetString("NoiCap");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetString("SoGP") != null) _SoGP = dr.GetString("SoGP");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenTB") != null) _TenTB = dr.GetString("TenTB");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
        }
		
		/// <summary>
		/// Insert the new <see cref="DMGiayPhep_ATBX" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMGiayPhep_ATBX
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaGP = DataProvider.Instance().InsertDMGiayPhepATBX(_MaTB, _NgayCap.Date, _NgayHetHan.Date, _NoiCap, _GhiChu, _SoGP);
			// public abstract String InsertDMGiayPhep_ATBX(String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
			// public override String InsertDMGiayPhep_ATBX(String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenKiemDinh_ATBX, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMGiayPhep_ATBX" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiayPhep_ATBX
			if (IsDirty){


                DataProvider.Instance().UpdateDMGiayPhepATBX(_MaGP, _MaTB, _NgayCap.Date, _NgayHetHan.Date, _NoiCap, _huy, _GhiChu, _maMay, _nguoiSD, _SoGP);
				// public abstract void UpdateDMGiayPhep_ATBX(String _MaGP, String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
				// public override void UpdateDMGiayPhep_ATBX(String _MaGP, String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaGP, _tenKiemDinh_ATBX, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaGP));
		}

		/// <summary>
		/// Delete the <see cref="DMGiayPhep_ATBX" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiayPhep_ATBX
            DataProvider.Instance().DeleteDMGiayPhepATBX( crit.MaMay, crit.NguoiSD, crit.MaGP);
			// public abstract void DeleteDMGiayPhep_ATBX(String _MaGP);
			// public override void DeleteDMGiayPhep_ATBX(String _MaGP);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaGP);
			// }
		}

		#endregion
	}

}
