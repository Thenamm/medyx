// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_Ngoai
// Kieu doi tuong  :	KhamBenh_Ngoai
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_Ngoai" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_Ngoai : BusinessBase<KhamBenh_Ngoai>
	{
		#region Business Methods
		
		#region State Fields
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;
        private String _maDV = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
        private Boolean _Rubella = false;
        private Boolean _UonVan = false;
        private Boolean _TiemChungKhac = false;
		private String _toanThan = String.Empty;
		private String _benhNgoaiKhoa = String.Empty;
		private String _coquankhac = String.Empty;
     
		private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _MaBV = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public Boolean Rubella
        {
            get
            {
                CanReadProperty("Rubella", true);
                return _Rubella;
            }
            set
            {
                CanWriteProperty("Rubella", true);
                if (_Rubella != value)
                {
                    _Rubella = value;
                    PropertyHasChanged("Rubella");
                }
            }
        }

        public Boolean UonVan
        {
            get
            {
                CanReadProperty("UonVan", true);
                return _UonVan;
            }
            set
            {
                CanWriteProperty("UonVan", true);
                if (_UonVan != value)
                {
                    _UonVan = value;
                    PropertyHasChanged("UonVan");
                }
            }
        }
        public Boolean TiemChungKhac
        {
            get
            {
                CanReadProperty("TiemChungKhac", true);
                return _TiemChungKhac;
            }
            set
            {
                CanWriteProperty("TiemChungKhac", true);
                if (_TiemChungKhac != value)
                {
                    _TiemChungKhac = value;
                    PropertyHasChanged("TiemChungKhac");
                }
            }
        }
        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }

        public String TenBV
        {
            get
            {
                CanReadProperty("TenBV", true);
                return _tenBV;
            }
            set
            {
                CanWriteProperty("TenBV", true);
                if (_tenBV != value)
                {
                    _tenBV = value;
                    PropertyHasChanged("TenBV");
                }
            }
        }
        public String MaDV
        {
            get
            {
                CanReadProperty("MaDV", true);
                return _maDV;
            }
            set
            {
                CanWriteProperty("MaDV", true);
                if (_maDV != value)
                {
                    _maDV = value;
                    PropertyHasChanged("MaDV");
                }
            }
        }
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _MaSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_MaSoKham != value) 
				{
					_MaSoKham = value;
					PropertyHasChanged("MaSoKham");
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
		
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_mach != value) 
				{
					_mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String ApHuyet
		{
			get 
			{
				CanReadProperty("ApHuyet", true);
				return _apHuyet;
			}
			set 
			{
				CanWriteProperty("ApHuyet", true);
				if (_apHuyet != value) 
				{
					_apHuyet = value;
					PropertyHasChanged("ApHuyet");
				}
			}
		}
		
		public String NhietDo
		{
			get 
			{
				CanReadProperty("NhietDo", true);
				return _nhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_nhietDo != value) 
				{
					_nhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
		
		public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _nhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_nhipTho != value) 
				{
					_nhipTho = value;
					PropertyHasChanged("NhipTho");
				}
			}
		}
		
		public String CanNang
		{
			get 
			{
				CanReadProperty("CanNang", true);
				return _canNang;
			}
			set 
			{
				CanWriteProperty("CanNang", true);
				if (_canNang != value) 
				{
					_canNang = value;
					PropertyHasChanged("CanNang");
				}
			}
		}
		
		public String ChieuCao
		{
			get 
			{
				CanReadProperty("ChieuCao", true);
				return _chieuCao;
			}
			set 
			{
				CanWriteProperty("ChieuCao", true);
				if (_chieuCao != value) 
				{
					_chieuCao = value;
					PropertyHasChanged("ChieuCao");
				}
			}
		}
		
		
		
		public String ToanThan
		{
			get 
			{
                CanReadProperty("ToanThan", true);
                return _toanThan;
			}
			set 
			{
                CanWriteProperty("ToanThan", true);
                if (_toanThan != value) 
				{
                    _toanThan = value;
                    PropertyHasChanged("ToanThan");
				}
			}
		}
		
		public String BenhNgoaiKhoa
		{
			get 
			{
                CanReadProperty("BenhNgoaiKhoa", true);
                return _benhNgoaiKhoa;
			}
			set 
			{
                CanWriteProperty("BenhNgoaiKhoa", true);
                if (_benhNgoaiKhoa != value) 
				{
                    _benhNgoaiKhoa = value;
                    PropertyHasChanged("BenhNgoaiKhoa");
				}
			}
		}
		
		public String Coquankhac
		{
			get 
			{
				CanReadProperty("Coquankhac", true);
				return _coquankhac;
			}
			set 
			{
				CanWriteProperty("Coquankhac", true);
				if (_coquankhac != value) 
				{
					_coquankhac = value;
					PropertyHasChanged("Coquankhac");
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
		
		public String MaBV
		{
			get 
			{
				CanReadProperty("MaBV", true);
				return _MaBV;
			}
			set 
			{
				CanWriteProperty("MaBV", true);
				if (_MaBV != value) 
				{
					_MaBV = value;
					PropertyHasChanged("MaBV");
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
            return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!";
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh_Ngoai" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_Ngoai NewKhamBenh_Ngoai()
        {
            return new KhamBenh_Ngoai();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_Ngoai NewKhamBenh_Ngoai(string idDMDichvu)
        {
            return new KhamBenh_Ngoai(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_Ngoai NewKhamBenh_Ngoai(DMDichVu _DMDichvu)
        {
            return new KhamBenh_Ngoai(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_Ngoai NewKhamBenh_Ngoai(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_Ngoai(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_Ngoai GetKhamBenh_Ngoai(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_Ngoai>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_Ngoai GetKhamBenh_Ngoai(SafeDataReader dr)
        {
            return new KhamBenh_Ngoai(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_Ngoai" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_Ngoai(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_Ngoai()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_Ngoai(DMDichVu pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maDV = pro.MaDV;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
        //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Ngoai(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _MaSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Ngoai(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Ngoai(SafeDataReader dr)
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
			private String _MaSoKham;
			public String MaSoKham 
			{
				get
				{
					return _MaSoKham;
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
			
			
			
			public Criteria(String MaSoKham, Int32 sTT)
			{
				_MaSoKham = MaSoKham;
				_sTT = sTT;
				
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaSoKham.Equals(c._MaSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
                    //if (!_sTTKhoa.Equals(c._sTTKhoa)) 
                    //    return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaSoKham.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaSoKham, Int32 sTT)
            {
                _MaSoKham = MaSoKham;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
             

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
		/// Retrieve an existing <see cref="KhamBenh_Ngoai" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Ngoai_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_Ngoai (crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_Ngoai" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            //if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");

            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");

            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
            if (dr.GetString("BenhNgoaiKhoa") != null) _benhNgoaiKhoa = dr.GetString("BenhNgoaiKhoa");
			if (dr.GetString("Coquankhac") != null) _coquankhac = dr.GetString("Coquankhac");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
			if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("MaBV") != null) _MaBV = dr.GetString("MaBV");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_Ngoai" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Ngoai
			// Copy & paste ham duoi day vao file DataProvider.cs
			_MaSoKham = DataProvider.Instance().InsertKhamBenh_Ngoai (_MaSoKham,_sTT,_maDV , _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan , _benhNgoaiKhoa , _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _nguoiSD);
            MarkOld();// public abstract String InsertKhamBenh_Ngoai(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_Ngoai(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Ngoai_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_Ngoai" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Ngoai
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_Ngoai (_MaSoKham, _sTT,_maDV , _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhNgoaiKhoa, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// public abstract void UpdateKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Ngoai_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// }		
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_Ngoai" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Ngoai
            DataProvider.Instance().DeleteKhamBenh_Ngoai (crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			// public abstract void DeleteKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Ngoai_Deleted", _MaSoKham, _sTT, _sTTKhoa);
			// }
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Ngoai
            // Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_Ngoai(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhNgoaiKhoa, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay , _nguoiSD );
            MarkOld(); // public abstract String InsertKhamBenh_Ngoai(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_Ngoai(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Ngoai_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_Ngoai" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Ngoai
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_Ngoai(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhNgoaiKhoa, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay , _huy, _nguoiSD );
                // public abstract void UpdateKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Ngoai_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
                // }	
                MarkOld();
            }
        }
        internal void DeleteSelf(KhamBenh_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_Ngoai(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
