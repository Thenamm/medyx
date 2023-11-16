// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	SoChamCong
// Kieu doi tuong  :	SoChamCong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/15/2010 9:19:31 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="SoChamCong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class SoChamCong : BusinessBase<SoChamCong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSCC = String.Empty;
        private SmartDate _ngayKham = new SmartDate("", true);
        private SmartDate _ngayKhamD = new SmartDate("", true);
		private String _maPhong = String.Empty;
		private Decimal _ngayNgoaiTru = 0;
		private Decimal _nguoiNgoaiTru = 0;
		private Decimal _soCaSang = 0;
		private Decimal _soCaChieu = 0;
		private Decimal _holter = 0;
		private Decimal _huyetAp = 0;
		private String _bacSy = String.Empty;
		private String _dieuDuong = String.Empty;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate("", true);
		private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate("", true);
		private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD = new SmartDate("", true);
		private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate("", true);
		private String _nguoiSD1 = String.Empty;
		private String _maMay = String.Empty;
        private String _tenKhoa = String.Empty;
        private Decimal _tongSoCa = 0;

        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaSCC
		{
			get 
			{
				CanReadProperty("MaSCC", true);
				return _maSCC;
			}
			set 
			{
				CanWriteProperty("MaSCC", true);
				if (_maSCC != value) 
				{
					_maSCC = value;
					PropertyHasChanged("MaSCC");
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
        public String TongSoCa
        {
            get
            {
                CanReadProperty("TongSoCa", true);
                _tongSoCa = _soCaSang + _soCaChieu + _holter + _huyetAp ;
                if (_tongSoCa == 0)
                    return "";
                else if (_tongSoCa - (int)(_tongSoCa) != 0)
                    return _tongSoCa.ToString("###,###.##");
                else
                    return _tongSoCa.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongSoCa", true);

                if (_tongSoCa.ToString() != value)
                {
                    if (value == "")
                        _tongSoCa = 0;
                    else
                        _tongSoCa = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSoCa");
                }
            }
        }
        public string   NguoiNgoaiTru
        {
            get
            {
                CanReadProperty("NguoiNgoaiTru", true);
              
                if (_nguoiNgoaiTru  == 0)
                    return "";
                else if (_nguoiNgoaiTru - (int)(_nguoiNgoaiTru) != 0)
                    return _nguoiNgoaiTru.ToString("###,###.##");
               
                else
                    return _nguoiNgoaiTru.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NguoiNgoaiTru", true);

                if (_nguoiNgoaiTru.ToString() != value)
                {
                    if (value == "")
                        _nguoiNgoaiTru = 0;
                    else
                        _nguoiNgoaiTru = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiNgoaiTru");
                }
            }
        }
        public String NgayNgoaiTru
        {
            get
            {
                CanReadProperty("NgayNgoaiTru", true);

                if (_ngayNgoaiTru == 0)
                    return "";
                else if (_ngayNgoaiTru - (int)(_ngayNgoaiTru) != 0)
                    return _ngayNgoaiTru.ToString("###,###.##");
                else
                    return _ngayNgoaiTru.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayNgoaiTru", true);

                if (_ngayNgoaiTru.ToString() != value)
                {
                    if (value == "")
                        _ngayNgoaiTru = 0;
                    else
                        _ngayNgoaiTru = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayNgoaiTru");
                }
            }
        }
		public string NgayKham
		{
			get 
			{
				CanReadProperty("NgayKham", true);
				return _ngayKham.Text;
			}
			set 
			{
				CanWriteProperty("NgayKham", true);
				if (_ngayKham.Text != value) 
				{
					_ngayKham.Text = value;
					PropertyHasChanged("NgayKham");
				}
			}
		}
        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham ;
                this._ngayKhamD.FormatString = "dd/MM/yyyy";
                return _ngayKhamD.Text;
            }
            set
            {
                CanWriteProperty("NgayKhamD", true);
                if (_ngayKhamD.Text != value)
                {
                    _ngayKhamD.Text = value;
                    PropertyHasChanged("NgayKhamD");
                }
            }
        }
		
		public String MaPhong
		{
			get 
			{
				CanReadProperty("MaPhong", true);
				return _maPhong;
			}
			set 
			{
				CanWriteProperty("MaPhong", true);
				if (_maPhong != value) 
				{
					_maPhong = value;
					PropertyHasChanged("MaPhong");
				}
			}
		}
		
		
		
		public String  SoCaSang
        {
            get
            {
                CanReadProperty("SoCaSang", true);

                if (_soCaSang == 0)
                    return "";
                else if (_soCaSang - (int)(_soCaSang) != 0)
                    return _soCaSang.ToString("###,###.##");
                else
                    return _soCaSang.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoCaSang", true);

                if (_soCaSang.ToString() != value)
                {
                    if (value == "")
                        _soCaSang = 0;
                    else
                        _soCaSang = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoCaSang");
                }
            }
        }
		
		public String  SoCaChieu
        {
            get
            {
                CanReadProperty("SoCaChieu", true);

                if (_soCaChieu == 0)
                    return "";
                else if (_soCaChieu - (int)(_soCaChieu) != 0)
                    return _soCaChieu.ToString("###,###.##");
                else
                    return _soCaChieu.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoCaChieu", true);

                if (_soCaChieu.ToString() != value)
                {
                    if (value == "")
                        _soCaChieu = 0;
                    else
                        _soCaChieu = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoCaChieu");
                }
            }
        }
		
		
		public String  Holter
        {
            get
            {
                CanReadProperty("Holter", true);

                if (_holter == 0)
                    return "";
                else if (_holter - (int)(_holter) != 0)
                    return _holter.ToString("###,###.##");
                else
                    return _holter.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Holter", true);

                if (_holter.ToString() != value)
                {
                    if (value == "")
                        _holter = 0;
                    else
                        _holter = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Holter");
                }
            }
        }
		
		
		public String  HuyetAp
        {
            get
            {
                CanReadProperty("HuyetAp", true);

                if (_huyetAp == 0)
                    return "";
                else if (_huyetAp - (int)(_huyetAp) != 0)
                    return _huyetAp.ToString("###,###.##");
                else
                    return _huyetAp.ToString("###,###");
            }
            set
            {
                CanWriteProperty("HuyetAp", true);

                if (_huyetAp.ToString() != value)
                {
                    if (value == "")
                        _huyetAp = 0;
                    else
                        _huyetAp = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HuyetAp");
                }
            }
        }
		
		public String BacSy
		{
			get 
			{
				CanReadProperty("BacSy", true);
				return _bacSy;
			}
			set 
			{
				CanWriteProperty("BacSy", true);
				if (_bacSy != value) 
				{
					_bacSy = value;
					PropertyHasChanged("BacSy");
				}
			}
		}
		
		public String DieuDuong
		{
			get 
			{
				CanReadProperty("DieuDuong", true);
				return _dieuDuong;
			}
			set 
			{
				CanWriteProperty("DieuDuong", true);
				if (_dieuDuong != value) 
				{
					_dieuDuong = value;
					PropertyHasChanged("DieuDuong");
				}
			}
		}
		
		public String Ghichu
		{
			get 
			{
				CanReadProperty("Ghichu", true);
				return _ghichu;
			}
			set 
			{
				CanWriteProperty("Ghichu", true);
				if (_ghichu != value) 
				{
					_ghichu = value;
					PropertyHasChanged("Ghichu");
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
             this._ngaySD.FormatString = "dd/MM/yyyy";
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

        SoChamCong_TVList _SoChamCong_TVList = SoChamCong_TVList.NewSoChamCong_TVList();

        public SoChamCong_TVList SoChamCong_TVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _SoChamCong_TVList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_SoChamCong_TVList.Equals(value))
                {
                    _SoChamCong_TVList = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maSCC;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _SoChamCong_TVList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _SoChamCong_TVList.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="SoChamCong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static SoChamCong NewSoChamCong()
        {
            return DataPortal.Create<SoChamCong>();
        }
		public static SoChamCong GetSoChamCong(String maSCC)
		{
			return DataPortal.Fetch<SoChamCong>(new Criteria(maSCC,false  ));
		}
        public static SoChamCong GetSoChamCong(SafeDataReader dr)
        {
            SoChamCong  obj = new SoChamCong ();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="SoChamCong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteSoChamCong(String maSCC, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSCC ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal SoChamCong()
		{	
			// Prevent direct creation
		}
        internal SoChamCong( int OrderNumber,
            String maSCC ,
		 SmartDate ngayKham ,
		 String maPhong ,
		 Decimal ngayNgoaiTru,
		 Decimal nguoiNgoaiTru,
		 Decimal soCaSang,
		 Decimal soCaChieu,
		 Decimal holter,
		 Decimal huyetAp,
		 String bacSy ,
		 String dieuDuong ,
		 String ghichu ,
		 Boolean huy ,
		 SmartDate ngayLap ,
		 String nguoiLap ,
		 SmartDate ngayHuy ,
		 String nguoiHuy ,
		 SmartDate ngaySD ,
		 String nguoiSD ,
		 SmartDate ngaySD1 ,
		 String nguoiSD1 ,    
         String tenkhoa,
		 String maMay 
         )
        {
                                 _OrderNumber = OrderNumber;
 _maSCC = maSCC;
 _ngayKham = ngayKham;
		                          _maPhong = maPhong ;
		                          _ngayNgoaiTru = ngayNgoaiTru ;
		                          _nguoiNgoaiTru = nguoiNgoaiTru ;
		                          _soCaSang = soCaSang ;
		                          _soCaChieu = soCaChieu ;
		                          _holter = holter ;
		                          _huyetAp = huyetAp ;
		                          _bacSy =bacSy ;
		                          _dieuDuong = dieuDuong  ;
		                          _ghichu = ghichu ;
		                          _huy = huy ;
		                          _ngayLap = ngayLap ;
		                          _nguoiLap = nguoiLap ;
		                          _ngayHuy = ngayHuy ;
		                          _nguoiHuy = nguoiHuy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
                                  _tenKhoa = tenkhoa;
                                
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected   class Criteria
		{
             private bool _qadmin = false   ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			private String _maSCC;
			public String MaSCC 
			{
				get
				{
					return _maSCC;
				}
			}
			
			public Criteria(string  maSCC,Boolean qadmin)
			{
				_maSCC = maSCC;
                _qadmin = qadmin ;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSCC.Equals(c._maSCC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSCC.ToString()).GetHashCode();
			}
		}
        [Serializable()]
                protected class OtherCriteria
        {
            private String _maSCC ;
            public String MaSCC
            {
                get
                {
                    return _maSCC;
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
           
            public OtherCriteria(String Mamay, String Nguoisd, String MaSCC)
            {
                _maSCC = MaSCC;       
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
		/// Retrieve an existing <see cref="SoChamCong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetSoChamCong(String _maSCC);
			// public override IDataReader GetSoChamCong(String _maSCC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetSoChamCong(crit.MaSCC, crit.qadmin)))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _SoChamCong_TVList  = SoChamCong_TVList .GetSoChamCong_TVList(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="SoChamCong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSCC") != null) _maSCC = dr.GetString("MaSCC");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("MaPhong") != null) _maPhong = dr.GetString("MaPhong");
			if (dr.GetDecimal("NgayNgoaiTru") != null) _ngayNgoaiTru = dr.GetDecimal("NgayNgoaiTru");
			if (dr.GetDecimal("NguoiNgoaiTru") != null) _nguoiNgoaiTru = dr.GetDecimal("NguoiNgoaiTru");
			if (dr.GetDecimal("SoCaSang") != null) _soCaSang = dr.GetDecimal("SoCaSang");
			if (dr.GetDecimal("SoCaChieu") != null) _soCaChieu = dr.GetDecimal("SoCaChieu");
			if (dr.GetDecimal("Holter") != null) _holter = dr.GetDecimal("Holter");
			if (dr.GetDecimal("HuyetAp") != null) _huyetAp = dr.GetDecimal("HuyetAp");
			if (dr.GetString("BacSy") != null) _bacSy = dr.GetString("BacSy");
			if (dr.GetString("DieuDuong") != null) _dieuDuong = dr.GetString("DieuDuong");
			if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            //if (dr.GetDecimal("TongSoCa") != null) _tongSoCa = dr.GetDecimal("TongSoCa");
          _tenKhoa = dr.GetString("TenKhoa");
		 _maMay = dr.GetString("MaMay");
		}
		
		/// <summary>
		/// Insert the new <see cref="SoChamCong" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            //_ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertSoChamCong
			// Copy & paste ham duoi day vao file DataProvider.cs
            
           // _nguoiSD  = HTC.ShareVariables.pub_sNguoiSD;
			_maSCC = DataProvider.Instance().InsertSoChamCong( _maSCC , _ngayKham , _maPhong , _ngayNgoaiTru , _nguoiNgoaiTru  , _soCaSang , _soCaChieu , _holter, _huyetAp , _bacSy, _dieuDuong,_ghichu,_nguoiSD ,_maMay );
			// public abstract String InsertSoChamCong(String _maSCC, SmartDate _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal _nguoiNgoaiTru, Decimal _soCaSang, Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
			// public override String InsertSoChamCong(String _maSCC, SmartDate _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal _nguoiNgoaiTru, Decimal _soCaSang, Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC, _ngayKham.DBValue, _maPhong, _ngayNgoaiTru, _nguoiNgoaiTru, _soCaSang, _soCaChieu, _holter, _huyetAp, _bacSy, _dieuDuong, _ghichu, _huy, _ngayLap.DBValue,_nguoiSD   , _ngayHuy.DBValue,_nguoiSD, _ngaySD.DBValue,_nguoiSD   , _ngaySD1.DBValue, _nguoiSD1, _maMay), String);
			// }
            _SoChamCong_TVList.Update(this);
            
		}
		
		/// <summary>
		/// Update all changes made on <see cref="SoChamCong" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateSoChamCong
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateSoChamCong( _maSCC, _ngayKham,  _maPhong,  _ngayNgoaiTru,  _nguoiNgoaiTru,  _soCaSang,  _soCaChieu,  _holter,  _huyetAp,  _bacSy,  _dieuDuong,  _ghichu,  _nguoiSD,  _maMay,_huy);
				// public abstract void UpdateSoChamCong(String _maSCC, SmartDate _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal _nguoiNgoaiTru, Decimal _soCaSang, Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
				// public override void UpdateSoChamCong(String _maSCC, SmartDate _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal _nguoiNgoaiTru, Decimal _soCaSang, Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC, _ngayKham.DBValue, _maPhong, _ngayNgoaiTru, _nguoiNgoaiTru, _soCaSang, _soCaChieu, _holter, _huyetAp, _bacSy, _dieuDuong, _ghichu, _huy, _ngayLap.DBValue,_nguoiSD   , _ngayHuy.DBValue,_nguoiSD, _ngaySD.DBValue,_nguoiSD   , _ngaySD1.DBValue, _nguoiSD1, _maMay);
				// }

                _SoChamCong_TVList.Update(this);
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria  (_maSCC,_maMay ,   _nguoiSD));
            
		}

		/// <summary>
		/// Delete the <see cref="SoChamCong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateSoChamCong
            
              
			DataProvider.Instance().DeleteSoChamCong( crit.MaSCC, crit.MaMay , crit.NguoiSD );
			// public abstract void DeleteSoChamCong(String _maSCC);
			// public override void DeleteSoChamCong(String _maSCC);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC);
			// }
           
		}

		#endregion
	}

}
