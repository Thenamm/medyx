// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLDThuTien
// Kieu doi tuong  :	DMLDThuTien
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/10/2009 8:51:46 AM
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
	/// This is a base generated class of <see cref="DMLDThuTien" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLDThuTien : BusinessBase<DMLDThuTien>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maLDThuTien = String.Empty;
		private String _tenLDThuTien = String.Empty;
		private String _ghiChu = String.Empty;
		private Boolean _loai = false;
        private Boolean _loaichi = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private Decimal _soNgay = 0;
        private Decimal _soTien = 0;
        private int _OrderNumber;
        private Boolean _kieutinh = true;
		#endregion
		
		#region Business Properties and Methods
        public Boolean kieutinh
        {
            get
            {
                CanReadProperty("kieutinh", true);
                return _kieutinh;
            }
            set
            {
                CanWriteProperty("kieutinh", true);
                if (_kieutinh != value)
                {
                    _kieutinh = value;
                    PropertyHasChanged("kieutinh");
                }
            }
        }
        public string soNgay
        {
            get
            {
                CanReadProperty("soNgay", true);
                if (_soNgay == 0)
                {
                    return "0";
                }
                else if (_soNgay - (int)(_soNgay) != 0)
                {
                    return _soNgay.ToString("###,###.###");
                }
                else
                {
                    return _soNgay.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("soNgay", true);

                if (_soNgay.ToString() != value)
                {
                    _soNgay = decimal.Parse(value);
                    PropertyHasChanged("soNgay");
                }
            }
        }
        public string soTien
        {
            get
            {
                CanReadProperty("soTien", true);
                if (_soTien == 0)
                {
                    return "0";
                }
                else if (_soTien - (int)(_soTien) != 0)
                {
                    return _soTien.ToString("###,###.###");
                }
                else
                {
                    return _soTien.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("soTien", true);

                if (_soTien.ToString() != value)
                {
                    _soTien = decimal.Parse(value);
                    PropertyHasChanged("soTien");
                }
            }
        }
		public String MaLDThuTien
		{
			get 
			{
				CanReadProperty("MaLDThuTien", true);
				return _maLDThuTien;
			}
			set 
			{
				CanWriteProperty("MaLDThuTien", true);
				if (_maLDThuTien != value) 
				{
					_maLDThuTien = value;
					PropertyHasChanged("MaLDThuTien");
				}
			}
		}
		
		public String TenLDThuTien
		{
			get 
			{
				CanReadProperty("TenLDThuTien", true);
				return _tenLDThuTien;
			}
			set 
			{
				CanWriteProperty("TenLDThuTien", true);
				if (_tenLDThuTien != value) 
				{
					_tenLDThuTien = value;
					PropertyHasChanged("TenLDThuTien");
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
		
		public Boolean Loai
		{
			get 
			{
				CanReadProperty("Loai", true);
				return _loai;
			}
			set 
			{
				CanWriteProperty("Loai", true);
				if (_loai != value) 
				{
					_loai = value;
					PropertyHasChanged("Loai");
				}
			}
		}

        public Boolean LoaiChi
        {
            get
            {
                //CanReadProperty("LoaiChi", true);
                if (_loai == true)
                    return false;
                else
                    return true;
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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
			return _maLDThuTien;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenLDThuTien", 150));
            ValidationRules.AddRule<DMLDThuTien>(StringRequired<DMLDThuTien>, "TenLDThuTien");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLDThuTien
        {

            if (target._tenLDThuTien == null || target._tenLDThuTien.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMLDThuTien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLDThuTien NewDMLDThuTien()
        {
            return DataPortal.Create<DMLDThuTien>();
        }
		public static DMLDThuTien GetDMLDThuTien(String maLDThuTien)
		{
			return DataPortal.Fetch<DMLDThuTien>(new Criteria(maLDThuTien));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLDThuTien" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLDThuTien(String maLDThuTien, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maLDThuTien));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLDThuTien()
		{	
			// Prevent direct creation
		}

        internal DMLDThuTien(
                             int OrderNumber,
                             String maLDThuTien ,
		                     String tenLDThuTien ,
		                     String ghiChu ,
		                     Boolean loai ,
		                     String maMay ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
                             String hoten ,
            decimal songay,
            decimal sotien,
                             Boolean kieutinh
         
                            )
        {
                               _OrderNumber = OrderNumber ;
                              _maLDThuTien = maLDThuTien ;
		                      _tenLDThuTien = tenLDThuTien ;
		                      _ghiChu = ghiChu ;
		                      _loai = loai ;
		                      _maMay = maMay ;
		                      _huy = huy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
                              _hoten = hoten ;
                              _soNgay = songay;
                              _soTien = sotien;
                              _kieutinh = kieutinh;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maLDThuTien;
			public String MaLDThuTien 
			{
				get
				{
					return _maLDThuTien;
				}
			}
			
			public Criteria(String maLDThuTien)
			{
				_maLDThuTien = maLDThuTien;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLDThuTien.Equals(c._maLDThuTien)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLDThuTien.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLDThuTien;
            public String MaLDThuTien
            {
                get
                {
                    return _maLDThuTien;
                }
            }

            private String _MaMay;
            public String MaMay
            {
                get
                {
                    return _MaMay;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaLDThuTien)
            {
                _maLDThuTien = MaLDThuTien;
                _MaMay = Mamay;
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
		/// Retrieve an existing <see cref="DMLDThuTien" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLDThuTien(String _maLDThuTien);
			// public override IDataReader GetDMLDThuTien(String _maLDThuTien)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLDThuTien));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLDThuTien(crit.MaLDThuTien)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLDThuTien" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaLDThuTien") != null) _maLDThuTien = dr.GetString("MaLDThuTien");
			if (dr.GetString("TenLDThuTien") != null) _tenLDThuTien = dr.GetString("TenLDThuTien");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetBoolean("Loai") != null) _loai = dr.GetBoolean("Loai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetDecimal("soTien") != null) _soTien = dr.GetDecimal("soTien");
            if (dr.GetDecimal("soNgay") != null) _soNgay = dr.GetDecimal("soNgay");
            if (dr.GetBoolean("kieutinh") != null) _kieutinh = dr.GetBoolean("kieutinh");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLDThuTien" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLDThuTien
			// Copy & paste ham duoi day vao file DataProvider.cs
            //_maMay = ,_maMay ,;
            //_nguoiSD = HTC.ShareVariables.pub_sNguoiSD;
			_maLDThuTien = DataProvider.Instance().InsertDMLDThuTien(_tenLDThuTien, _ghiChu, _loai, _maMay, _nguoiSD,kieutinh,_soNgay,_soTien  );
			// public abstract String InsertDMLDThuTien(String _tenLDThuTien, String _ghiChu, Boolean _loai, String _maMay, String _nguoiSD);
			// public override String InsertDMLDThuTien(String _tenLDThuTien, String _ghiChu, Boolean _loai, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLDThuTien_CREATE", _tenLDThuTien, _ghiChu, _loai, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLDThuTien" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLDThuTien

			if (IsDirty){
                //_maMay = ,_maMay ,;
                //_nguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                DataProvider.Instance().UpdateDMLDThuTien(_maLDThuTien, _tenLDThuTien, _ghiChu, _loai, _maMay, _huy, _nguoiSD, kieutinh, _soNgay, _soTien);
				// public abstract void UpdateDMLDThuTien(String _maLDThuTien, String _tenLDThuTien, String _ghiChu, Boolean _loai, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMLDThuTien(String _maLDThuTien, String _tenLDThuTien, String _ghiChu, Boolean _loai, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLDThuTien_UPDATED", _maLDThuTien, _tenLDThuTien, _ghiChu, _loai, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD  , _maLDThuTien));
		}

		/// <summary>
		/// Delete the <see cref="DMLDThuTien" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLDThuTien
            DataProvider.Instance().DeleteDMLDThuTien(crit.MaMay, crit.NguoiSD, crit.MaLDThuTien);
			// public abstract void DeleteDMLDThuTien(String _maLDThuTien);
			// public override void DeleteDMLDThuTien(String _maLDThuTien);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMLDThuTien_DELETED", _maLDThuTien);
			// }
		}

		#endregion
	}

}
