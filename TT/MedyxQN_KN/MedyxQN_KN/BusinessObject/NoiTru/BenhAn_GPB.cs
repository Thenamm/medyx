// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_GPB
// Kieu doi tuong  :	BenhAn_GPB
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/8/2009 2:28:41 PM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_GPB" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_GPB : BusinessBase<BenhAn_GPB>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayDK = new SmartDate(true);
        private SmartDate _ngayNhan = new SmartDate(true);
		private String _bSKHAM = String.Empty;
		private String _NguoiNhan = String.Empty;
		private String _MaDV = String.Empty;
		private String _TenDV = String.Empty;
		private String _LayTu = String.Empty;
		private String _Dungdich = String.Empty;
        private SmartDate _NgayCoDinh = new SmartDate(true);
		private String _TomTat = String.Empty;

        private String _QuaTrinh = String.Empty;
        private String _NhanXet = String.Empty;
        private String _KetQua = String.Empty;
        private String _mabenh = String.Empty;
        private String _tenBenh = String.Empty;
        private String _maICD = String.Empty;
     
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
	
        private String _tenBSKham = String.Empty;
        private String _tennguoinhan = String.Empty;
       
		#endregion
		
		#region Business Properties and Methods
		
		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
				}
			}
		}
		
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
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}
		
		public string NgayDK
		{
			get 
			{
				CanReadProperty("NgayDK", true);
               
				return _ngayDK.Text;
			}
			set 
			{
				CanWriteProperty("NgayDK", true);
				if (_ngayDK.Text != value) 
				{
					_ngayDK.Text = value;
					PropertyHasChanged("NgayDK");
				}
			}
		}
        public string NgayNhan
        {
            get
            {
                CanReadProperty("NgayNhan", true);
                _ngayNhan.FormatString = "MM/dd/yyyy HH:mm";
                return _ngayNhan.Text;
            }
            set
            {
                CanWriteProperty("NgayNhan", true);
                if (_ngayNhan.Text != value)
                {
                    _ngayNhan.Text = value;
                    PropertyHasChanged("NgayNhan");
                }
            }
        }
        public string NgayCoDinh
        {
            get
            {
                CanReadProperty("NgayCoDinh", true);
                _NgayCoDinh.FormatString = "MM/dd/yyyy HH:mm";
                return _NgayCoDinh.Text;
            }
            set
            {
                CanWriteProperty("NgayCoDinh", true);
                if (_NgayCoDinh.Text != value)
                {
                    _NgayCoDinh.Text = value;
                    PropertyHasChanged("NgayCoDinh");
                }
            }
        }
		public String BSKHAM
		{
			get 
			{
				CanReadProperty("BSKHAM", true);
				return _bSKHAM;
			}
			set 
			{
				CanWriteProperty("BSKHAM", true);
				if (_bSKHAM != value) 
				{
					_bSKHAM = value;
					PropertyHasChanged("BSKHAM");
				}
			}
		}
		
		public String NguoiNhan
		{
			get 
			{
				CanReadProperty("NguoiNhan", true);
				return _NguoiNhan;
			}
			set 
			{
				CanWriteProperty("NguoiNhan", true);
				if (_NguoiNhan != value) 
				{
					_NguoiNhan = value;
					PropertyHasChanged("NguoiNhan");
				}
			}
		}
		
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _MaDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_MaDV != value) 
				{
					_MaDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
		
		public String TenDV
		{
			get 
			{
				CanReadProperty("TenDV", true);
				return _TenDV;
			}
			set 
			{
				CanWriteProperty("TenDV", true);
				if (_TenDV != value) 
				{
					_TenDV = value;
					PropertyHasChanged("TenDV");
				}
			}
		}
		
		public String LayTu
		{
			get 
			{
				CanReadProperty("LayTu", true);
				return _LayTu;
			}
			set 
			{
				CanWriteProperty("LayTu", true);
				if (_LayTu != value) 
				{
					_LayTu = value;
					PropertyHasChanged("LayTu");
				}
			}
		}
		
		public String Dungdich
		{
			get 
			{
				CanReadProperty("Dungdich", true);
				return _Dungdich;
			}
			set 
			{
				CanWriteProperty("Dungdich", true);
				if (_Dungdich != value) 
				{
					_Dungdich = value;
					PropertyHasChanged("Dungdich");
				}
			}
		}
		
		public String TomTat
		{
			get 
			{
				CanReadProperty("TomTat", true);
				return _TomTat;
			}
			set 
			{
				CanWriteProperty("TomTat", true);
				if (_TomTat != value) 
				{
					_TomTat = value;
					PropertyHasChanged("TomTat");
				}
			}
		}
		
		public String QuaTrinh
		{
			get 
			{
				CanReadProperty("QuaTrinh", true);
				return _QuaTrinh;
			}
			set 
			{
				CanWriteProperty("QuaTrinh", true);
				if (_QuaTrinh != value) 
				{
					_QuaTrinh = value;
					PropertyHasChanged("QuaTrinh");
				}
			}
		}
		
		public String NhanXet
		{
			get 
			{
				CanReadProperty("NhanXet", true);
				return _NhanXet;
			}
			set 
			{
				CanWriteProperty("NhanXet", true);
				if (_NhanXet != value) 
				{
					_NhanXet = value;
					PropertyHasChanged("NhanXet");
				}
			}
		}


        public String KetQua
        {
            get
            {
                CanReadProperty("KetQua", true);
                return _KetQua;
            }
            set
            {
                CanWriteProperty("KetQua", true);
                if (_KetQua != value)
                {
                    _KetQua = value;
                    PropertyHasChanged("KetQua");
                }
            }
        }
		
		
		public String Mabenh
		{
			get 
			{
				CanReadProperty("Mabenh", true);
				return _mabenh;
			}
			set 
			{
				CanWriteProperty("Mabenh", true);
				if (_mabenh != value) 
				{
					_mabenh = value;
					PropertyHasChanged("Mabenh");
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm"; 
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
		
		
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
       
        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
                }
            }
        }
       
        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
                }
            }
        }

        public String tennguoinhan
        {
            get
            {
                CanReadProperty("tennguoinhan", true);
                return _tennguoinhan;
            }
            set
            {
                CanWriteProperty("tennguoinhan", true);
                if (_tennguoinhan != value)
                {
                    _tennguoinhan = value;
                    PropertyHasChanged("tennguoinhan");
                }
            }
        }

      
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_GPB" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_GPB NewBenhAn_GPB()
        {
            return DataPortal.Create<BenhAn_GPB>();
        }
		public static BenhAn_GPB GetBenhAn_GPB(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_GPB>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_GPB" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_GPB(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_GPB()
		{	
			// Prevent direct creation
		}

        internal BenhAn_GPB(     int OrderNumber,
                                 String maBA ,
		                         Int32 sTT ,
		                         Int32 sTTKhoa ,
		                         SmartDate NgayDK ,
                                  SmartDate Ngaynhan,
                                  SmartDate Ngaycodinh,
		                         String bSKHAM ,
		                         String NguoiNhan ,
		                         String MaDV ,
		                         String TenDV ,
		                         String LayTu ,
		                         String Dungdich ,
		                         String TomTat ,
		                         String QuaTrinh ,

		                        String  NhanXet ,
                               String ketQua,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                     
                                 String tenBenh ,
                                          String maICD ,
                                   String tenBSKham ,
                                string tennguoinhan
                                )
        {
                                   _maBA = maBA ;
		                          _sTT = sTT;
		                          _sTTKhoa = sTTKhoa;
		                          _ngayDK = NgayDK ;
                                  _ngayNhan = Ngaynhan;
                                  _NgayCoDinh = Ngaycodinh;
		                          _bSKHAM = bSKHAM ;
		                          _NguoiNhan = NguoiNhan ;
		                          _MaDV = MaDV ;
		                          _TenDV = TenDV ;
		                          _LayTu = LayTu ;
		                          _Dungdich = Dungdich ;
		                          _TomTat = TomTat ;
		                          _QuaTrinh = QuaTrinh ;

		                          _NhanXet = NhanXet ;
                                  _KetQua = ketQua;
		                          _mabenh = Mabenh ;
		                       
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                        
                                  _tenBenh = tenBenh ;
                                
                                  _maICD = maICD ;
                                 
                                  _tenBSKham = tenBSKham ;
                                  _tennguoinhan = tennguoinhan;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
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
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
		/// Retrieve an existing <see cref="BenhAn_GPB" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_GPB_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_GPB(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_GPB" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
            if (dr.GetSmartDate("Ngaynhan", true) != null) _ngayNhan = dr.GetSmartDate("Ngaynhan", true);
            if (dr.GetSmartDate("NgayCoDinh", true) != null) _NgayCoDinh = dr.GetSmartDate("NgayCoDinh", true);
			if (dr.GetString("NguoiNhan") != null) _NguoiNhan = dr.GetString("NguoiNhan");
			if (dr.GetString("MaDV") != null) _MaDV = dr.GetString("MaDV");
			if (dr.GetString("TenDV") != null) _TenDV = dr.GetString("TenDV");
			if (dr.GetString("LayTu") != null) _LayTu = dr.GetString("LayTu");
			if (dr.GetString("Dungdich") != null) _Dungdich = dr.GetString("Dungdich");
			if (dr.GetString("TomTat") != null) _TomTat = dr.GetString("TomTat");
			if (dr.GetString("QuaTrinh") != null) _QuaTrinh = dr.GetString("QuaTrinh");

            if (dr.GetString("NhanXet") != null) _NhanXet = dr.GetString("NhanXet");
            if (dr.GetString("KetQua") != null) _KetQua = dr.GetString("KetQua");
           
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
        
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("tennguoinhan") != null) _tennguoinhan = dr.GetString("tennguoinhan");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_GPB" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_GPB
			// Copy & paste ham duoi day vao file DataProvider.cs
            _sTT = DataProvider.Instance().InsertBenhAn_GPB(_maBA,_sTT , _sTTKhoa, _ngayDK,_ngayNhan,_NgayCoDinh, _bSKHAM, _NguoiNhan, _MaDV,  _LayTu, _Dungdich, _TomTat, _QuaTrinh, _NhanXet, _KetQua, _mabenh,_tenBenh ,  _maMay, _nguoiSD);
            // public abstract String InsertBenhAn_GPB(String _maBA, Int32 _sTTKhoa, SmartDate _NgayDK, String _bSKHAM, String _NguoiNhan, String _MaDV, String _TenDV, String _LayTu, String _Dungdich, String _TomTat, String _QuaTrinh, String _NhanXet, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaDVuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_GPB(String _maBA, Int32 _sTTKhoa, SmartDate _NgayDK, String _bSKHAM, String _NguoiNhan, String _MaDV, String _TenDV, String _LayTu, String _Dungdich, String _TomTat, String _QuaTrinh, String _NhanXet, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaDVuyenkhoa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_GPB_CREATE", _maBA, _sTTKhoa, _NgayDK.DBValue, _bSKHAM, _NguoiNhan, _MaDV, _TenDV, _LayTu, _Dungdich, _TomTat, _QuaTrinh, _NhanXet, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaDVuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
            MarkOld();

        }
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_GPB" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_GPB
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAn_GPB(_maBA, _sTT, _sTTKhoa, _ngayDK, _ngayNhan, _NgayCoDinh, _bSKHAM, _NguoiNhan, _MaDV, _LayTu, _Dungdich, _TomTat, _QuaTrinh, _NhanXet, _KetQua, _mabenh, _tenBenh, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _NgayDK, String _bSKHAM, String _NguoiNhan, String _MaDV, String _TenDV, String _LayTu, String _Dungdich, String _TomTat, String _QuaTrinh, String _NhanXet, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaDVuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _NgayDK, String _bSKHAM, String _NguoiNhan, String _MaDV, String _TenDV, String _LayTu, String _Dungdich, String _TomTat, String _QuaTrinh, String _NhanXet, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaDVuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_GPB_UPDATE", _maBA, _sTT, _sTTKhoa, _NgayDK.DBValue, _bSKHAM, _NguoiNhan, _MaDV, _TenDV, _LayTu, _Dungdich, _TomTat, _QuaTrinh, _NhanXet, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaDVuyenkhoa, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_GPB" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_GPB
            DataProvider.Instance().DeleteBenhAn_GPB(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_GPB_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
