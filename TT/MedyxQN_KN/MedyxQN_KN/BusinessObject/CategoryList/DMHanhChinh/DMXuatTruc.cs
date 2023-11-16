// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMXuatTruc
// Kieu doi tuong  :	DMXuatTruc
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
	/// This is a base generated class of <see cref="DMXuatTruc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMXuatTruc : BusinessBase<DMXuatTruc>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaKhoa = String.Empty;
		private String _MaCD = String.Empty;
        private String _MaKhoaCu = String.Empty;
        private String _MaCDCu = String.Empty;
        private int _XuatTruc = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
        private String _TenKhoa = String.Empty;
        private String _TenCD;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _MaKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_MaKhoa != value) 
				{
					_MaKhoa = value;
					PropertyHasChanged("MaKhoa");
				}
			}
		}
        public String MaKhoaCu
        {
            get
            {
                //CanReadProperty("MaKhoa", true);
                return _MaKhoaCu;
            }
            set
            {
                //CanWriteProperty("MaKhoa", true);
                if (_MaKhoaCu != value)
                {
                    _MaKhoaCu = value;
                    //PropertyHasChanged("MaKhoa");
                }
            }
        }
        public String TenKhoa
		{
			get 
			{
                CanReadProperty("TenKhoa", true);
				return _TenKhoa;
			}
			set 
			{
                CanWriteProperty("TenKhoa", true);
				if (_TenKhoa != value) 
				{
					_TenKhoa = value;
                    PropertyHasChanged("TenKhoa");
				}
			}
		}
        public String MaCD
        {
            get
            {
                CanReadProperty("MaCD", true);
                return _MaCD;
            }
            set
            {
                CanWriteProperty("MaCD", true);
                if (_MaCD != value)
                {
                    _MaCD = value;
                    PropertyHasChanged("MaCD");
                }
            }
        }
        public String MaCDCu
        {
            get
            {
                //CanReadProperty("MaCD", true);
                return _MaCDCu;
            }
            set
            {
                //CanWriteProperty("MaCD", true);
                if (_MaCDCu != value)
                {
                    _MaCDCu = value;
                    //PropertyHasChanged("MaCD");
                }
            }
        }
        public String TenCD
        {
            get
            {
                CanReadProperty("TenCD", true);
                return _TenCD;
            }
            set
            {
                CanWriteProperty("TenCD", true);
                if (_TenCD != value)
                {
                    _TenCD = value;
                    PropertyHasChanged("TenCD");
                }
            }
        }
        public int XuatTruc
        {
            get
            {
                CanReadProperty("XuatTruc", true);
                return _XuatTruc;
            }
            set
            {
                CanWriteProperty("XuatTruc", true);
                if (_XuatTruc != value)
                {
                    _XuatTruc = value;
                    PropertyHasChanged("XuatTruc");
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
			return _MaKhoa;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenKhoa", 150));
            ValidationRules.AddRule<DMXuatTruc>(StringRequired<DMXuatTruc>, "TenKhoa");
           
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMXuatTruc
        {

            if (target._TenKhoa == null || target._TenKhoa.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMXuatTruc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMXuatTruc NewDMXuatTruc()
        {
            return DataPortal.Create<DMXuatTruc>();
        }
		public static DMXuatTruc GetDMXuatTruc(String MaKhoa)
		{
			return DataPortal.Fetch<DMXuatTruc>(new Criteria(MaKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="DMXuatTruc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMXuatTruc(String MaKhoa, String MaCD, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaKhoa, MaCD));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMXuatTruc()
		{	
			// Prevent direct creation
		}
        internal DMXuatTruc(int ordernumber, string MaKhoa, string MaCD, int xuatTruc, string MaMay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten, string tenKhoa, string tenCD)
        {
            _OrderNumber = ordernumber;
            _MaKhoa   = MaKhoa;
            _TenKhoa  = TenKhoa;
            _maMay = MaMay;
            _MaCD = MaCD;
            _TenCD = tenCD;
            _XuatTruc = xuatTruc;
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
			private String _MaKhoa;
			public String MaKhoa 
			{
				get
				{
					return _MaKhoa;
				}
			}
			
			public Criteria(String MaKhoa)
			{
				_MaKhoa = MaKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaKhoa.Equals(c._MaKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaKhoa.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaKhoa;
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            private String _MaCD;
            public String MaCD
            {
                get
                {
                    return _MaCD;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaKhoa, String MaCD)
            {
                _MaKhoa = MaKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _MaCD = MaCD;
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
        [Serializable()]
        protected class Criteria1
        {
            private String _MaKhoa;
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            private String _MaCD;
            public String MaCD
            {
                get
                {
                    return _MaCD;
                }
            }
            public Criteria1(String MaKhoa, String MaCD)
            {
                _MaKhoa = MaKhoa;
                _MaCD = MaCD;
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
		/// Retrieve an existing <see cref="DMXuatTruc" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMXuatTruc(String _MaKhoa);
			// public override IDataReader GetDMXuatTruc(String _MaKhoa)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMXuatTruc(crit.MaKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
        protected void DataPortal_Fetch(Criteria1 crit)
        {
            // public abstract IDataReader GetDMXuatTruc(String _MaKhoa);
            // public override IDataReader GetDMXuatTruc(String _MaKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMXuatTruc(crit.MaKhoa, crit.MaCD)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="DMXuatTruc" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKhoa") != null) _MaKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("TenKhoa") != null) _TenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("MaCD") != null) _MaCD = dr.GetString("MaCD");
            if (dr.GetString("TenCD") != null) _TenCD = dr.GetString("TenCD");
            if (dr.GetInt32("XuatTruc") != null) _XuatTruc = dr.GetInt32("XuatTruc");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMXuatTruc" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMXuatTruc
            // Copy & paste ham duoi day vao file DataProvider.cs


            DataProvider.Instance().InsertDMXuatTruc(_MaKhoa, _MaCD, _XuatTruc, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMXuatTruc(String _TenKhoa, String _maMay, String _nguoiSD);
			// public override String InsertDMXuatTruc(String _TenKhoa, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _TenKhoa, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMXuatTruc" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMXuatTruc
			if (IsDirty){


                DataProvider.Instance().UpdateDMXuatTruc(_MaKhoa, _MaCD, _MaKhoaCu, _MaCDCu, _XuatTruc, _huy, _ghiChu, _maMay, _nguoiSD);
				// public abstract void UpdateDMXuatTruc(String _MaKhoa, String _TenKhoa, String _maMay, String _nguoiSD);
				// public override void UpdateDMXuatTruc(String _MaKhoa, String _TenKhoa, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa, _TenKhoa, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaKhoa, _MaCD));
		}

		/// <summary>
		/// Delete the <see cref="DMXuatTruc" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMXuatTruc
            DataProvider.Instance().DeleteDMXuatTruc(crit.MaKhoa, crit.MaCD, crit.MaMay, crit.NguoiSD);
			// public abstract void DeleteDMXuatTruc(String _MaKhoa);
			// public override void DeleteDMXuatTruc(String _MaKhoa);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa);
			// }
		}

		#endregion
	}

}
