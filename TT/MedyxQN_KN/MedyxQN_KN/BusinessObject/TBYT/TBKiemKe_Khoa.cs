// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBKiemKe_Khoa
// Kieu doi tuong  :	TBKiemKe_Khoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/25/2009 8:39:44 AM
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

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBKiemKe_Khoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBKiemKe_Khoa : BusinessBase<TBKiemKe_Khoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maKK = String.Empty;
        private SmartDate _ngayKK = new SmartDate(DateTime.Today);
        private SmartDate _ngayKKD = new SmartDate(DateTime.Today);
		private String _makhoa = String.Empty;
		private String _nguoiKK = String.Empty;
        
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaylap = new SmartDate(true);
		private String _ghiChu = String.Empty;
		private Boolean _xuly = false;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoihuy = String.Empty;
		private Boolean _huy = false;
        private String _tenKhoa = String.Empty;
        private String _tenNVKK = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaKK
		{
			get 
			{
				CanReadProperty("MaKK", true);
				return _maKK;
			}
			set 
			{
				CanWriteProperty("MaKK", true);
				if (_maKK != value) 
				{
					_maKK = value;
					PropertyHasChanged("MaKK");
				}
			}
		}
		
		public string NgayKK
		{
			get 
			{
				CanReadProperty("NgayKK", true);
				return _ngayKK.Text;
			}
			set 
			{
				CanWriteProperty("NgayKK", true);
				if (_ngayKK.Text != value) 
				{
					_ngayKK.Text = value;
					PropertyHasChanged("NgayKK");
				}
			}
		}
        public String NgayKKD
        {
            get
            {
                CanReadProperty("NgayKKD", true);
                _ngayKKD = _ngayKK;
                _ngayKKD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayKKD.Text;
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
		
		public String NguoiKK
		{
			get 
			{
				CanReadProperty("NguoiKK", true);
				return _nguoiKK;
			}
			set 
			{
				CanWriteProperty("NguoiKK", true);
				if (_nguoiKK != value) 
				{
					_nguoiKK = value;
					PropertyHasChanged("NguoiKK");
				}
			}
		}
		
		public String NguoiLap
		{
			get 
			{
				CanReadProperty("NguoiLap", true);
				return _nguoiLap;
			}
			set 
			{
				CanWriteProperty("NguoiLap", true);
				if (_nguoiLap != value) 
				{
					_nguoiLap = value;
					PropertyHasChanged("NguoiLap");
				}
			}
		}
		
		public string Ngaylap
		{
			get 
			{
				CanReadProperty("Ngaylap", true);
				return _ngaylap.Text;
			}
			set 
			{
				CanWriteProperty("Ngaylap", true);
				if (_ngaylap.Text != value) 
				{
					_ngaylap.Text = value;
					PropertyHasChanged("Ngaylap");
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
		
		public Boolean Xuly
		{
			get 
			{
				CanReadProperty("Xuly", true);
				return _xuly;
			}
			set 
			{
				CanWriteProperty("Xuly", true);
				if (_xuly != value) 
				{
					_xuly = value;
					PropertyHasChanged("Xuly");
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
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
				return _ngayhuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_ngayhuy.Text != value) 
				{
					_ngayhuy.Text = value;
					PropertyHasChanged("Ngayhuy");
				}
			}
		}
		
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _nguoihuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_nguoihuy != value) 
				{
					_nguoihuy = value;
					PropertyHasChanged("Nguoihuy");
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

        public String TenNVKK
        {
            get
            {
                CanReadProperty("TenNVKK", true);
                return _tenNVKK;
            }
            set
            {
                CanWriteProperty("TenNVKK", true);
                if (_tenNVKK != value)
                {
                    _tenNVKK = value;
                    PropertyHasChanged("TenNVKK");
                }
            }
        }
        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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
        TBKiemKe_Khoa_C_List _TBKiemKe_Khoa_Cs = TBKiemKe_Khoa_C_List.NewTBKiemKe_Khoa_C_List();

        public TBKiemKe_Khoa_C_List TBKiemKe_Khoa_Cs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _TBKiemKe_Khoa_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TBKiemKe_Khoa_Cs.Equals(value))
                {
                    _TBKiemKe_Khoa_Cs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maKK;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _TBKiemKe_Khoa_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _TBKiemKe_Khoa_Cs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBKiemKe_Khoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBKiemKe_Khoa NewTBKiemKe_Khoa()
        {
            return DataPortal.Create<TBKiemKe_Khoa>();
        }
		public static TBKiemKe_Khoa GetTBKiemKe_Khoa(String maKK)
		{
			return DataPortal.Fetch<TBKiemKe_Khoa>(new Criteria(maKK));
		}
        public static TBKiemKe_Khoa GetTBKiemKe_Khoa(SafeDataReader dr)
        {
            TBKiemKe_Khoa obj = new TBKiemKe_Khoa();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="TBKiemKe_Khoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBKiemKe_Khoa(String maKK, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maKK));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBKiemKe_Khoa()
		{	
			// Prevent direct creation
		}
        internal TBKiemKe_Khoa( 
                                 int OrderNumber,
                                 String maKK ,
		                         SmartDate ngayKK ,
		                         String makhoa ,
		                         String nguoiKK ,
		                         String nguoiLap ,
		                         SmartDate ngaylap ,
		                         String ghiChu ,
		                         Boolean xuly ,
		                         String maMay ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngayhuy ,
		                         String nguoihuy ,
		                         Boolean huy ,
                                 String tenKhoa ,
                                 String tenNVKK ,
                                 String tenNguoiLap ,
                                 String tenNguoiSD ,
                                 String tenNguoiHuy 
         )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maKK = maKK ;
		                          _ngayKK = ngayKK ;
		                          _makhoa = makhoa ;
		                          _nguoiKK = nguoiKK;
		                          _nguoiLap = nguoiLap ;
		                          _ngaylap = ngaylap ;
		                          _ghiChu = ghiChu ;
		                          _xuly = xuly ;
		                          _maMay = maMay ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngayhuy = ngayhuy ;
		                          _nguoihuy =nguoihuy ;
		                          _huy = huy;
                                  _tenKhoa = tenKhoa ;
                                  _tenNVKK = tenNVKK ;
                                  _tenNguoiLap = tenNguoiLap ;
                                  _tenNguoiSD = tenNguoiSD ;
                                  _tenNguoiHuy = tenNguoiHuy ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKK;
			public String MaKK 
			{
				get
				{
					return _maKK;
				}
			}
			 private bool  _qadmin = false;
			public bool qadmin 
			{
				get
				{
					return _qadmin;
				}
			}
			public Criteria(String maKK)
			{
				_maKK = maKK;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maKK.Equals(c._maKK)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maKK.ToString()).GetHashCode();
			}
		}
		[Serializable()]
        protected class OtherCriteria
        {
            private String _maKK;
			public String MaKK 
			{
				get
				{
					return _maKK;
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
            //DeletePhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String Mamay, String Nguoisd, String maKK )
            {
                _maKK = maKK;
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
		/// Retrieve an existing <see cref="TBKiemKe_Khoa" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBKiemKe_Khoa(String _maKK);
			// public override IDataReader GetTBKiemKe_Khoa(String _maKK)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBKIEMKE_KHOA_GET", _maKK));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBKiemKe_Khoa(crit.MaKK, crit.qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _TBKiemKe_Khoa_Cs = TBKiemKe_Khoa_C_List.GetTBKiemKe_Khoa_C_List(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBKiemKe_Khoa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKK") != null) _maKK = dr.GetString("MaKK");
			if (dr.GetSmartDate("NgayKK", true) != null) _ngayKK = dr.GetSmartDate("NgayKK");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
			if (dr.GetString("NguoiKK") != null) _nguoiKK = dr.GetString("NguoiKK");
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngaylap", true) != null) _ngaylap = dr.GetSmartDate("Ngaylap", true);
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetBoolean("Xuly") != null) _xuly = dr.GetBoolean("Xuly");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            _tenKhoa = dr.GetString("TenKhoa");
            _tenNVKK = dr.GetString("TenNVKK");
            _tenNguoiLap = dr.GetString("TENNGUOILAP");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
            _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
		}
		
		/// <summary>
		/// Insert the new <see cref="TBKiemKe_Khoa" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngaylap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTBKiemKe_Khoa
			// Copy & paste ham duoi day vao file DataProvider.cs
             
            
			_maKK = DataProvider.Instance().InsertTBKiemKe_Khoa(_ngayKK, _makhoa, _nguoiKK, _nguoiSD , _ghiChu, _xuly, _maMay,_nguoiSD);
            MarkOld();// public abstract String InsertTBKiemKe_Khoa(SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _nguoiLap, SmartDate _ngaylap, String _ghiChu, Boolean _xuly, String _maMay );
			// public override String InsertTBKiemKe_Khoa(SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _nguoiLap, SmartDate _ngaylap, String _ghiChu, Boolean _xuly, String _maMay);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBKIEMKE_KHOA_Create", _ngayKK.DBValue, _makhoa, _nguoiKK, _nguoiSD , _ngaylap.DBValue, _ghiChu, _xuly, _maMay));
			// }
            if (this.TBKiemKe_Khoa_Cs.IsDirty == true)
                _TBKiemKe_Khoa_Cs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBKiemKe_Khoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBKiemKe_Khoa
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateTBKiemKe_Khoa(_maKK, _ngayKK, _makhoa, _nguoiKK, _ghiChu, _xuly, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateTBKiemKe_Khoa(String _maKK, SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateTBKiemKe_Khoa(String _maKK, SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBKIEMKE_KHOA_UPDATE", _maKK, _ngayKK.DBValue, _makhoa, _nguoiKK, _ghiChu, _xuly, _maMay, _nguoiSD , _huy);
                // }	
                if (this.TBKiemKe_Khoa_Cs.IsDirty == true)
                    _TBKiemKe_Khoa_Cs.Update(this);
            }
		}
		protected override void DataPortal_DeleteSelf()
		{
             //_nguoihuy = HTC.ShareVariables.pub_sNguoiSD ;  
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoihuy , _maKK));
		}

		/// <summary>
		/// Delete the <see cref="TBKiemKe_Khoa" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBKiemKe_Khoa
			DataProvider.Instance().DeleteTBKiemKe_Khoa(crit.MaMay, crit.NguoiSD, crit.MaKK);
			// public abstract void DeleteTBKiemKe_Khoa(String _maKK);
			// public override void DeleteTBKiemKe_Khoa(String _maKK);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBKIEMKE_KHOA_DELETED", _maKK);
			// }
		}

		#endregion
	}

}
