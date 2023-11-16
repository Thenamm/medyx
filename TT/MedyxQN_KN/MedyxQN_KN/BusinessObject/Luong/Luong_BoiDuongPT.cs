// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_BoiDuongPT
// Kieu doi tuong  :	Luong_BoiDuongPT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/05/2010 9:09:24 AM
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
using HTC.Business;
//

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_BoiDuongPT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_BoiDuongPT : BusinessBase<Luong_BoiDuongPT>
	{
		#region Business Methods
		
		#region State Fields
		
		private SmartDate _thang = new SmartDate(true);
		private String _maKhoa = String.Empty;
        private Decimal _heSo = 0;
        private Decimal _tong = 0;
        private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Boolean _huy = false;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public string Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang.Text;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang.Text != value) 
				{
					_thang.Text = value;
					PropertyHasChanged("Thang");
				}
			}
		}
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _maKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_maKhoa != value) 
				{
					_maKhoa = value;
					PropertyHasChanged("MaKhoa");
				}
			}
		}

        public String HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                if (_heSo == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo.ToString("###,##0.##");
                }
            }
            set
            {
                CanWriteProperty("HeSo", true);
                if (_heSo.ToString() != value)
                {
                    if (value == "")
                        _heSo = 0;
                    else
                        _heSo = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo");
                }
            }
        }
        public String Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                if (_tong == 0)
                {
                    return "";
                }
                else
                {
                    return _tong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tong", true);
                if (_tong.ToString() != value)
                {
                    if (value == "")
                        _tong = 0;
                    else
                        _tong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tong");
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
				return _ngayLap.Text;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text != value) 
				{
					_ngayLap.Text = value;
					PropertyHasChanged("NgayLap");
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
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
        Luong_BoiDuongPT_NVList _Luong_BoiDuongPT_NVs = Luong_BoiDuongPT_NVList.NewLuong_BoiDuongPT_NVList();

        public Luong_BoiDuongPT_NVList Luong_BoiDuongPT_NVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _Luong_BoiDuongPT_NVs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_Luong_BoiDuongPT_NVs.Equals(value))
                {
                    _Luong_BoiDuongPT_NVs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _thang.ToString() + "!" + _maKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _Luong_BoiDuongPT_NVs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _Luong_BoiDuongPT_NVs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_BoiDuongPT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_BoiDuongPT NewLuong_BoiDuongPT()
        {
            return DataPortal.Create<Luong_BoiDuongPT>();
        }
        public static Luong_BoiDuongPT GetLuong_BoiDuongPT(DateTime thang, String maKhoa, string dk)
		{
            return DataPortal.Fetch<Luong_BoiDuongPT>(new Criteria(thang, maKhoa, dk ));
		}
        public static Luong_BoiDuongPT GetLuong_BoiDuongPT(SafeDataReader dr)
        {
            Luong_BoiDuongPT obj = new Luong_BoiDuongPT();
            obj.Fetch(dr);
            return obj;
        }
        public static bool CheckLuongBoiDuongPT(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_BoiDuongPT(Thang, maKhoa, dk)))
            {
                if (dr.Read())
                {
                    if (!dr.GetSmartDate("Thang", true).IsEmpty)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
		/// <summary>
		/// Marks the <see cref="Luong_BoiDuongPT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteLuong_BoiDuongPT(SmartDate thang, String maKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,  thang, maKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Luong_BoiDuongPT()
		{	
			// Prevent direct creation
		}
        internal Luong_BoiDuongPT(
  int OrderNumber,
  SmartDate thang ,
		                             String maKhoa ,
		                             Decimal heso ,
  
		                             Decimal tong ,
		                             String ghiChu ,
		                             String maMay ,
		                             SmartDate ngayLap ,
		                             String nguoiLap ,
		                             SmartDate ngayHuy ,
		                             String nguoiHuy ,
		                             SmartDate ngaySD ,
		                             String nguoiSD ,
		                             SmartDate ngaySD1 ,
		                             String nguoiSD1 ,
		                             Boolean huy ,
  String tenNguoiLap ,
  String tenNguoiSD ,
  String tenNguoiHuy 
         
            )
        {
                              _OrderNumber = OrderNumber ;
                              _thang = thang ;
		                      _maKhoa = maKhoa ;
                              _heSo = heso;
		                      _tong = tong ;
		                      _ghiChu = ghiChu ;
		                      _maMay = maMay ;
		                      _ngayLap = ngayLap ;
		                      _nguoiLap = nguoiLap ;
		                      _ngayHuy = ngayHuy ;
		                      _nguoiHuy = nguoiHuy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
		                      _ngaySD1 = ngaySD1 ;
		                      _nguoiSD1 = nguoiSD1 ;
		                      _huy = huy ;
                              _tenNguoiLap = tenNguoiLap ;
                              _tenNguoiSD = tenNguoiSD ;
                              _tenNguoiHuy = tenNguoiHuy ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private DateTime _thang;
            public DateTime Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			private String _maKhoa;
			public String MaKhoa 
			{
				get
				{
					return _maKhoa;
				}
			}
            private String _dk;
            public String DK
            {
                get
                {
                    return _dk;
                }
            }

            public Criteria(DateTime thang, String maKhoa, string dk)
			{
				_thang = thang;
				_maKhoa = maKhoa;
                _dk = dk;
			}
			
			
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }

            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, SmartDate thang, String maKhoa)
            {
                _thang = thang;
                _maKhoa = maKhoa;
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
		/// Retrieve an existing <see cref="Luong_BoiDuongPT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetLuong_BoiDuongPT(SmartDate _thang, String _maKhoa);
			// public override IDataReader GetLuong_BoiDuongPT(SmartDate _thang, String _maKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_GET", _thang, _maKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_BoiDuongPT(crit.Thang, crit.MaKhoa, crit.DK  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _Luong_BoiDuongPT_NVs = Luong_BoiDuongPT_NVList.GetLuong_BoiDuongPT_NVList(dr);//////////////
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="Luong_BoiDuongPT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("Heso") != null) _heSo = dr.GetDecimal("Heso");      
			if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="Luong_BoiDuongPT" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertLuong_BoiDuongPT
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maKhoa = DataProvider.Instance().InsertLuong_BoiDuongPT(_thang, _maKhoa,  _heSo, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract String InsertLuong_BoiDuongPT(SmartDate _thang, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override String InsertLuong_BoiDuongPT(SmartDate _thang, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_CREATE", _thang.DBValue, _maKhoa, _heSo,  _tong, _ghiChu, _maMay, _nguoiSD));
			// }
            if (this.Luong_BoiDuongPT_NVs.IsDirty == true)

            _Luong_BoiDuongPT_NVs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_BoiDuongPT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_BoiDuongPT
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateLuong_BoiDuongPT(_thang, _maKhoa, _heSo , _tong, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong_BoiDuongPT(SmartDate _thang, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_BoiDuongPT(SmartDate _thang, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_UPDATE", _thang.DBValue, _maKhoa, _heSo, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// }		
                if (this.Luong_BoiDuongPT_NVs.IsDirty == true)

                _Luong_BoiDuongPT_NVs.Update(this);

			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _thang, _maKhoa));
		}

		/// <summary>
		/// Delete the <see cref="Luong_BoiDuongPT" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_BoiDuongPT
            DataProvider.Instance().DeleteLuong_BoiDuongPT(crit.MaMay, crit.NguoiSD, crit.Thang, crit.MaKhoa);
			// public abstract void DeleteLuong_BoiDuongPT(SmartDate _thang, String _maKhoa);
			// public override void DeleteLuong_BoiDuongPT(SmartDate _thang, String _maKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_DELETED", _thang, _maKhoa);
			// }
		}

		#endregion
	}

}
