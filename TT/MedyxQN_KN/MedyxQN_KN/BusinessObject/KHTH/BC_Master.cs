// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_Master
// Kieu doi tuong  :	BC_Master
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 4:03:07 PM
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
	/// This is a base generated class of <see cref="BC_Master" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_Master : BusinessBase<BC_Master>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private int _thuTu = new int();
		private SmartDate _thang = new SmartDate(true);
		private SmartDate _thangD = new SmartDate(true);
		private byte _phanloaiBC = new int();
		private String _loaiBC = String.Empty;
		private SmartDate _ngayBC = new SmartDate(true);
        private SmartDate _ngayBCD = new SmartDate(true);
		private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _tuNgayD = new SmartDate(true);
		private SmartDate _denNgay = new SmartDate(true);
        private SmartDate _denNgayD = new SmartDate(true);
		private String _nguoiLap = String.Empty;
        private String _tennguoiLap = String.Empty;
		private SmartDate _ngaylap = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private String _maMay = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
        private String _tennguoiHuy = String.Empty;
		private Boolean _huy = false;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

		public int Thutu
		{
			get
			{
				CanReadProperty("Thutu", true);
				return _thuTu;
			}
			set
			{
				CanWriteProperty("Thutu", true);
				if (_thuTu != value)
				{
					_thuTu = value;
					PropertyHasChanged("Thutu");
				}
			}
		}

		public byte PhanloaiBC
		{
			get
			{
				CanReadProperty("PhanloaiBC", true);
				return _phanloaiBC;
			}
			set
			{
				CanWriteProperty("PhanloaiBC", true);
				if (_phanloaiBC != value)
				{
					_phanloaiBC = value;
					PropertyHasChanged("PhanloaiBC");
				}
			}
		}

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
		
		 public string ThangD
        {
            get
            {
				CanReadProperty("ThangD", true);
				_thangD = _thang;
				_thangD.FormatString = "dd/MM/yyyy";
				return _thangD.Text;
            }
        }

		public String MaBC
		{
			get 
			{
				CanReadProperty("MaBC", true);
				return _maBC;
			}
			set 
			{
				CanWriteProperty("MaBC", true);
				if (_maBC != value) 
				{
					_maBC = value;
					PropertyHasChanged("MaBC");
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
		
		public string NgayBC
		{
			get 
			{
				CanReadProperty("NgayBC", true);
				return _ngayBC.Text;
			}
			set 
			{
				CanWriteProperty("NgayBC", true);
				if (_ngayBC.Text != value) 
				{
					_ngayBC.Text = value;
					PropertyHasChanged("NgayBC");
				}
			}
		}
        public string NgayBCD
        {
            get
            {
                CanReadProperty("NgayBCD", true);
                _ngayBCD  = _ngayBC ;
                _ngayBCD.FormatString = "dd/MM/yyyy";
                return _ngayBCD.Text;
            }

        }

		public string TuNgay
		{
			get 
			{
				CanReadProperty("TuNgay", true);
				return _tuNgay.Text;
			}
			set 
			{
				CanWriteProperty("TuNgay", true);
				if (_tuNgay.Text != value) 
				{
					_tuNgay.Text = value;
					PropertyHasChanged("TuNgay");
				}
			}
		}
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _tuNgayD  = _tuNgay ;
                _tuNgayD.FormatString = "dd/MM/yyyy";
                return _tuNgayD.Text;
            }

        }
        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _denNgayD  = _denNgay ;
                _denNgayD.FormatString = "dd/MM/yyyy";
                return _denNgayD.Text;
            }

        }
		public string DenNgay
		{
			get 
			{
				CanReadProperty("DenNgay", true);
				return _denNgay.Text;
			}
			set 
			{
				CanWriteProperty("DenNgay", true);
				if (_denNgay.Text != value) 
				{
					_denNgay.Text = value;
					PropertyHasChanged("DenNgay");
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
                _ngaylap .FormatString = "dd/MM/yyyy HH:mm";
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
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy  hh:mm";
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }
        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
			return _maBC.ToString() + "!" + _loaiBC.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_Master" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BC_Master NewBC_Master()
        {
            //return new BC_DuocBV();
             return DataPortal.Create<BC_Master>();
        }
		public static BC_Master GetBC_Master(String maBC, String loaiBC)
		{
			return DataPortal.Fetch<BC_Master>(new Criteria(maBC, loaiBC));
		}
		
		/// <summary>
		/// Marks the <see cref="BC_Master" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_Master(String maBC, String loaiBC,string mamay,string nguoihuy)
		{
            DataPortal.Delete(new CriteriaOther(mamay,nguoihuy , maBC, loaiBC));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BC_Master()
		{	
			// Prevent direct creation
		}
        internal BC_Master(
                        int OrderNumber,
                        String maBC ,
		             String loaiBC ,
		             SmartDate ngayBC ,
		             SmartDate tuNgay ,
		             SmartDate denNgay ,
		             String nguoiLap ,
		             SmartDate ngaylap ,
		             String nguoiSD ,
		             SmartDate ngaysd ,
		             String maMay ,
		             SmartDate ngayHuy ,
		             String nguoiHuy ,
		             Boolean huy ,
                     String tennguoiSD, 
                     String  tenNguoiHuy,
                     String tenNguoiLap,
					 int thuTu, SmartDate thang, byte phanloaiBC
         )
        {
			_thuTu = thuTu; _thang = thang; _phanloaiBC =phanloaiBC;
            _OrderNumber = OrderNumber  ;
             _maBC = maBC ;
		  _loaiBC = loaiBC ;
		  _ngayBC = ngayBC ;
		  _tuNgay = tuNgay ;
		  _denNgay = denNgay ;
		  _nguoiLap = nguoiLap ;
		  _ngaylap = ngaylap ;
		  _nguoiSD = nguoiSD ;
		  _ngaysd = ngaysd ;
		  _maMay = maMay ;
		  _ngayHuy = ngayHuy ;
		  _nguoiHuy = nguoiHuy ;
		  _huy = huy ;
          _tennguoiSD = tennguoiSD ;
          _tennguoiHuy = tenNguoiHuy;
           _tennguoiLap= tenNguoiLap ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBC;
			public String MaBC 
			{
				get
				{
					return _maBC;
				}
			}
			
			private String _loaiBC;
			public String LoaiBC 
			{
				get
				{
					return _loaiBC;
				}
			}
			
			public Criteria(String maBC, String loaiBC)
			{
				_maBC = maBC;
				_loaiBC = loaiBC;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_loaiBC.Equals(c._loaiBC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _loaiBC.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaOther
        {
            private String _maBC;
            public String MaBC
            {
                get
                {
                    return _maBC;
                }
            }

            private String _loaiBC;
            public String LoaiBC
            {
                get
                {
                    return _loaiBC;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, String LoaiBC)
            {
                _maBC = maBC;
                _loaiBC = LoaiBC ;
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
		/// Retrieve an existing <see cref="BC_Master" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBC_Master(String _maBC, String _loaiBC);
			// public override IDataReader GetBC_Master(String _maBC, String _loaiBC)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_Master_GET", _maBC, _loaiBC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_Master(crit.MaBC, crit.LoaiBC)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BC_Master" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("LoaiBC") != null) _loaiBC = dr.GetString("LoaiBC");
			if (dr.GetSmartDate("NgayBC", true) != null) _ngayBC = dr.GetSmartDate("NgayBC", true);
			if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
			if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngaylap", true) != null) _ngaylap = dr.GetSmartDate("Ngaylap", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("tenNguoiSD") != null) _tennguoiSD = dr.GetString("tenNguoiSD");
            if (dr.GetString("tenNguoiHuy") != null) _tennguoiHuy = dr.GetString("tenNguoiHuy");
            if (dr.GetString("tenNguoiLap") != null) _tennguoiLap = dr.GetString("tenNguoiLap");

			if (dr.GetString("Thang") != null) _thang = dr.GetSmartDate("Thang");
			if (dr.GetString("PhanloaiBC") != null) _phanloaiBC = dr.GetByte("PhanloaiBC");
			if (dr.GetString("Thutu") != null) Thutu = dr.GetInt32("Thutu");

		}
		
		/// <summary>
		/// Insert the new <see cref="BC_Master" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBC_Master
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maBC = DataProvider.Instance().InsertBC_Master(_loaiBC, _ngayBC, _tuNgay, _denNgay, _nguoiSD , _maMay);
            // public abstract String InsertBC_Master(String _loaiBC, SmartDate _ngayBC, SmartDate _tuNgay, SmartDate _denNgay, String _nguoiLap, String _maMay);
            // public override String InsertBC_Master(String _loaiBC, SmartDate _ngayBC, SmartDate _tuNgay, SmartDate _denNgay, String _nguoiLap, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_Master_CREATE", _maBC, _loaiBC, _ngayBC.DBValue, _tuNgay.DBValue, _denNgay.DBValue, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_Master" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_Master
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateBC_Master(_maBC, _loaiBC, _ngayBC, _tuNgay, _denNgay, _nguoiSD ,  _maMay, _huy);
				// public abstract void UpdateBC_Master(String _maBC, String _loaiBC, SmartDate _ngayBC, SmartDate _tuNgay, SmartDate _denNgay, String _nguoiSD, SmartDate _ngaysd, String _maMay, Boolean _huy);
				// public override void UpdateBC_Master(String _maBC, String _loaiBC, SmartDate _ngayBC, SmartDate _tuNgay, SmartDate _denNgay, String _nguoiSD, SmartDate _ngaysd, String _maMay, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_Master_Update", _maBC, _loaiBC, _ngayBC.DBValue, _tuNgay.DBValue, _denNgay.DBValue, _nguoiSD , _maMay, _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBC, _loaiBC));
		}

		/// <summary>
		/// Delete the <see cref="BC_Master" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_Master
            DataProvider.Instance().DeleteBC_Master(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.LoaiBC);
			// public abstract void DeleteBC_Master(String _maBC, String _loaiBC);
			// public override void DeleteBC_Master(String _maBC, String _loaiBC);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_Master_Deleted", _maBC, _loaiBC);
			// }
		}

		#endregion
	}

}
