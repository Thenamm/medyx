// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAnPK_RHM
// Kieu doi tuong  :	BenhAnPK_RHM
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
////
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
		
	[Serializable()]
	public partial class BenhAnPK_RHM : BusinessBase<BenhAnPK_RHM>
	{
		#region Business Methods
		
		#region State Fields
     	private String _MaBA = String.Empty;
		
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _QuanhRang = String.Empty;
		private String _ChiSoLoi = String.Empty;
		private Boolean _ViemLoi = false;
        private Boolean _ViemCauRang = false;
		private String _TenBenh = String.Empty;
		private String _TenBenhKem = String.Empty;

     

		private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
	
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
    
		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _MaBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_MaBA != value) 
				{
					_MaBA = value;
					PropertyHasChanged("MaBA");
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
                _ngayKhamD = _ngayKham; 
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";
                
                return _ngayKhamD.Text;
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
		
		public String LyDoKham
		{
			get 
			{
				CanReadProperty("LyDoKham", true);
				return _lyDoKham;
			}
			set 
			{
				CanWriteProperty("LyDoKham", true);
				if (_lyDoKham != value) 
				{
					_lyDoKham = value;
					PropertyHasChanged("LyDoKham");
				}
			}
		}
		
		public String QuanhRang
		{
			get 
			{
				CanReadProperty("QuanhRang", true);
				return _QuanhRang;
			}
			set 
			{
				CanWriteProperty("QuanhRang", true);
				if (_QuanhRang != value) 
				{
					_QuanhRang = value;
					PropertyHasChanged("QuanhRang");
				}
			}
		}
		
		public String ChiSoLoi
		{
			get 
			{
				CanReadProperty("ChiSoLoi", true);
				return _ChiSoLoi;
			}
			set 
			{
				CanWriteProperty("ChiSoLoi", true);
				if (_ChiSoLoi != value) 
				{
					_ChiSoLoi = value;
					PropertyHasChanged("ChiSoLoi");
				}
			}
		}
		
		public Boolean ViemLoi
		{
			get 
			{
				CanReadProperty("ViemLoi", true);
				return _ViemLoi;
			}
			set 
			{
				CanWriteProperty("ViemLoi", true);
				if (_ViemLoi != value) 
				{
					_ViemLoi = value;
					PropertyHasChanged("ViemLoi");
				}
			}
		}
		
		public Boolean ViemCauRang
		{
			get 
			{
				CanReadProperty("ViemCauRang", true);
				return _ViemCauRang;
			}
			set 
			{
				CanWriteProperty("ViemCauRang", true);
				if (_ViemCauRang != value) 
				{
					_ViemCauRang = value;
					PropertyHasChanged("ViemCauRang");
				}
			}
		}
		
	

		public String DieuTri
		{
			get 
			{
				CanReadProperty("DieuTri", true);
				return _dieuTri;
			}
			set 
			{
				CanWriteProperty("DieuTri", true);
				if (_dieuTri != value) 
				{
					_dieuTri = value;
					PropertyHasChanged("DieuTri");
				}
			}
		}
		
		public String BenhSu
		{
			get 
			{
				CanReadProperty("BenhSu", true);
				return _benhSu;
			}
			set 
			{
				CanWriteProperty("BenhSu", true);
				if (_benhSu != value) 
				{
					_benhSu = value;
					PropertyHasChanged("BenhSu");
				}
			}
		}
		
		public String HuongDT
		{
			get 
			{
				CanReadProperty("HuongDT", true);
				return _huongDT;
			}
			set 
			{
				CanWriteProperty("HuongDT", true);
				if (_huongDT != value) 
				{
					_huongDT = value;
					PropertyHasChanged("HuongDT");
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
		
		public String MaBenhKem
		{
			get 
			{
				CanReadProperty("MaBenhKem", true);
				return _maBenhKem;
			}
			set 
			{
				CanWriteProperty("MaBenhKem", true);
				if (_maBenhKem != value) 
				{
					_maBenhKem = value;
					PropertyHasChanged("MaBenhKem");
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
        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenBenhKem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenBenhKem != value)
                {
                    _tenBenhKem = value;
                    PropertyHasChanged("TenBenhKem");
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
        public String MaICDKem
        {
            get
            {
                CanReadProperty("MaICDKem", true);
                return _maICDKem;
            }
            set
            {
                CanWriteProperty("MaICDKem", true);
                if (_maICDKem != value)
                {
                    _maICDKem = value;
                    PropertyHasChanged("MaICDKem");
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
			return _MaBA.ToString() + "!" ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAnPK_RHM" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static BenhAnPK_RHM NewBenhAnPK_RHM()
        {
            return new BenhAnPK_RHM();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
     
     
      
        public static BenhAnPK_RHM GetBenhAnPK_RHM(String MaBA)
        {
            return DataPortal.Fetch<BenhAnPK_RHM>(new Criteria(MaBA));
        }

        public static BenhAnPK_RHM GetBenhAnPK_RHM(SafeDataReader dr)
        {
            return new BenhAnPK_RHM(dr);
        }

        /// <summary>
        /// Marks the <see cref="BenhAnPK_RHM" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhAnPK_RHM(String MaBA, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaBA));
        }

        #endregion
		
			#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAnPK_RHM()
		{	
			// Prevent direct creation
		}
		
        protected BenhAnPK_RHM(DMDichVu pro)
        {
          
           
          
        }
        protected BenhAnPK_RHM(string MaBA)
        {
            MarkAsChild();

            _MaBA = MaBA;
          
          
        }
      
        protected BenhAnPK_RHM(SafeDataReader dr)
        {
            MarkAsChild();

            Fetch(dr);
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaBA;
			public String MaBA 
			{
				get
				{
					return _MaBA;
				}
			}
			
		
		
			
			public Criteria(String MaBA)
			{
				_MaBA = MaBA;
				
				
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaBA.Equals(c._MaBA)) 
						return false;
				
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaBA.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaBA;
            public String MaBA
            {
                get
                {
                    return _MaBA;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaBA)
            {
                _MaBA = MaBA;
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
		/// Retrieve an existing <see cref="BenhAnPK_RHM" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
				using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAnPK_RHM(crit.MaBA)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAnPK_RHM" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _MaBA = dr.GetString("MaBA");
		   //if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("QuanhRang") != null) _QuanhRang = dr.GetString("QuanhRang");
			if (dr.GetString("ChiSoLoi") != null) _ChiSoLoi = dr.GetString("ChiSoLoi");
            if (dr.GetBoolean("ViemLoi") != null) _ViemLoi = dr.GetBoolean("ViemLoi");
            if (dr.GetBoolean("ViemCauRang") != null) _ViemCauRang = dr.GetBoolean("ViemCauRang");
			if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
			if (dr.GetString("TenBenhKem") != null) _TenBenhKem = dr.GetString("TenBenhKem");

          

			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
			if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
		
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAnPK_RHM" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAnPK_RHM
			// Copy & paste ham duoi day vao file DataProvider.cs
           DataProvider.Instance().InsertBenhAnPK_RHM(_MaBA, _ngayKham, _bSKHAM, _lyDoKham, _QuanhRang, _ChiSoLoi, _ViemLoi, _ViemCauRang, _TenBenh, _TenBenhKem, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _maMay ,   _nguoiSD);
            MarkOld(); // public abstract String InsertBenhAnPK_RHM(String _MaBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _QuanhRang, String _ChiSoLoi, String _ViemLoi, String _ViemCauRang, String _TenBenh, String _TenBenhKem, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertBenhAnPK_RHM(String _MaBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _QuanhRang, String _ChiSoLoi, String _ViemLoi, String _ViemCauRang, String _TenBenh, String _TenBenhKem, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_RHM_CREATE", _MaBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _QuanhRang, _ChiSoLoi, _ViemLoi, _ViemCauRang, _TenBenh, _TenBenhKem, _toanThan, _benhChuyenKhoa, _coQuanKhac, _tonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAnPK_RHM" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPK_RHM
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAnPK_RHM(_MaBA,   _ngayKham, _bSKHAM, _lyDoKham, _QuanhRang, _ChiSoLoi, _ViemLoi, _ViemCauRang, _TenBenh, _TenBenhKem,  _dieuTri, _benhSu,_huongDT, _mabenh, _maBenhKem, _maMay ,   _huy, _nguoiSD );
                // public abstract void UpdateBenhAnPK_RHM(String _MaBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _QuanhRang, String _ChiSoLoi, String _ViemLoi, String _ViemCauRang, String _TenBenh, String _TenBenhKem, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAnPK_RHM(String _MaBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _QuanhRang, String _ChiSoLoi, String _ViemLoi, String _ViemCauRang, String _TenBenh, String _TenBenhKem, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_RHM_UPDATE", _MaBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _QuanhRang, _ChiSoLoi, _ViemLoi, _ViemCauRang, _TenBenh, _TenBenhKem, _toanThan, _benhChuyenKhoa, _coQuanKhac, _tonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// }
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD , _MaBA));
		}

	
      
      
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPK_RHM
            DataProvider.Instance().DeleteBenhAnPK_RHM(crit.MaMay, crit.NguoiSD, crit.MaBA);
			// public abstract void DeleteBenhAnPK_RHM(String _MaBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAnPK_RHM(String _MaBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_RHM_Deleted", _MaBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
