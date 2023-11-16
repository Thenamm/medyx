// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_Nhi
// Kieu doi tuong  :	KhamBenh_Nhi
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
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_Nhi" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_Nhi : BusinessBase<KhamBenh_Nhi>
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
        private String _TrieuChung = String.Empty;
        private String _Tiensu = String.Empty;
        private String _DiungThuoc = String.Empty;
        private String _nhommau = String.Empty;
        private String _Chuandoan = String.Empty;
        private String _BenhKhac = String.Empty;
        private String _TenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _BenhLyKhac = String.Empty;
        private String _DieuTri = String.Empty;
        private String _LoiDanBS = String.Empty;
        private String _BenhSu = String.Empty;
     
        private String _HuongDT = String.Empty;
        private String _Mabenh = String.Empty;
        private String _MaBenhKem = String.Empty;
        private String _MaBV = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _Huy = false;

        private SmartDate _NgaySD = new SmartDate(true);
        private String _NguoiSD = String.Empty;
        private SmartDate _NgaySD1 = new SmartDate(true);
        private String _NguoiSD1 = String.Empty;
        private int _OrderNumber;
        private String _tenBSKham = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
		#endregion
		
			#region Business Properties and Methods
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
        public String tenBSKham
        {
            get
            {
                CanReadProperty("tenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("tenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("tenBSKham");
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
        //public string NgayKhamD
        //{
        //    get
        //    {
        //        CanReadProperty("NgayKhamD", true);
        //        _ngayKhamD = _ngayKham; 
        //        _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";
               
        //        return _ngayKhamD.Text;
        //    }
            
        //}
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
		
        public String TrieuChung
		{
			get 
			{
				CanReadProperty("TrieuChung", true);
				return _TrieuChung;
			}
			set 
			{
				CanWriteProperty("TrieuChung", true);
				if (_TrieuChung != value) 
				{
					_TrieuChung = value;
					PropertyHasChanged("TrieuChung");
				}
			}
		}
 	    public String Tiensu
		{
			get 
			{
				CanReadProperty("Tiensu", true);
				return _Tiensu;
			}
			set 
			{
				CanWriteProperty("Tiensu", true);
				if (_Tiensu != value) 
				{
					_Tiensu = value;
					PropertyHasChanged("Tiensu");
				}
			}
		}	
        public String DiungThuoc
		{
			get 
			{
				CanReadProperty("DiungThuoc", true);
				return _DiungThuoc;
			}
			set 
			{
				CanWriteProperty("DiungThuoc", true);
				if (_DiungThuoc != value) 
				{
					_DiungThuoc = value;
					PropertyHasChanged("DiungThuoc");
				}
			}
		}
        public String nhommau
        {
            get
            {
                CanReadProperty("nhommau", true);
                return _nhommau;
            }
            set
            {
                CanWriteProperty("nhommau", true);
                if (_nhommau != value)
                {
                    _nhommau = value;
                    PropertyHasChanged("nhommau");
                }
            }
        }	
        public String Chuandoan
		{
			get 
			{
				CanReadProperty("Chuandoan", true);
				return _Chuandoan;
			}
			set 
			{
				CanWriteProperty("Chuandoan", true);
				if (_Chuandoan != value) 
				{
					_Chuandoan = value;
					PropertyHasChanged("Chuandoan");
				}
			}
		}	
        public String BenhKhac 
		{
			get 
			{
				CanReadProperty("BenhKhac ", true);
				return _BenhKhac ;
			}
			set 
			{
				CanWriteProperty("BenhKhac ", true);
				if (_BenhKhac  != value) 
				{
					_BenhKhac  = value;
					PropertyHasChanged("BenhKhac");
				}
			}
		}	
        
        public String TenBenh
		{
			get 
			{
				CanReadProperty("TenBenh", true);
				return _TenBenh;
			}
			set 
			{
				CanWriteProperty("TenBenh", true);
				if (_TenBenh != value) 
				{
					_TenBenh = value;
					PropertyHasChanged("TenBenh");
				}
			}
		}	
        public String BenhLyKhac
		{
			get 
			{
				CanReadProperty("BenhLyKhac", true);
				return _BenhLyKhac;
			}
			set 
			{
				CanWriteProperty("BenhLyKhac", true);
				if (_BenhLyKhac != value) 
				{
					_BenhLyKhac = value;
					PropertyHasChanged("BenhLyKhac");
				}
			}
		}	
        public String DieuTri
		{
			get 
			{
				CanReadProperty("DieuTri", true);
				return _DieuTri;
			}
			set 
			{
				CanWriteProperty("DieuTri", true);
				if (_DieuTri != value) 
				{
					_DieuTri = value;
					PropertyHasChanged("DieuTri");
				}
			}
		}	

        public String LoiDanBS
		{
			get 
			{
				CanReadProperty("LoiDanBS", true);
				return _LoiDanBS;
			}
			set 
			{
				CanWriteProperty("LoiDanBS", true);
				if (_LoiDanBS != value) 
				{
					_LoiDanBS = value;
					PropertyHasChanged("LoiDanBS");
				}
			}
		}
        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _BenhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_BenhSu != value)
                {
                    _BenhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }

        public String HuongDT
		{
			get 
			{
				CanReadProperty("HuongDT", true);
				return _HuongDT;
			}
			set 
			{
				CanWriteProperty("HuongDT", true);
				if (_HuongDT != value) 
				{
					_HuongDT = value;
					PropertyHasChanged("HuongDT");
				}
			}
		}	
        public String Mabenh
		{
			get 
			{
				CanReadProperty("Mabenh", true);
				return _Mabenh;
			}
			set 
			{
				CanWriteProperty("Mabenh", true);
				if (_Mabenh != value) 
				{
					_Mabenh = value;
					PropertyHasChanged("Mabenh");
				}
			}
		}	
        public String MaBenhKem
		{
			get 
			{
				CanReadProperty("MaBenhKem", true);
				return _MaBenhKem;
			}
			set 
			{
				CanWriteProperty("MaBenhKem", true);
				if (_MaBenhKem != value) 
				{
					_MaBenhKem = value;
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
				return _Huy;
			}
			set 
			{
				CanWriteProperty("Huy", true);
				if (_Huy != value) 
				{
					_Huy = value;
					PropertyHasChanged("Huy");
				}
			}
		}
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _NgaySD.FormatString = "dd/MM/yyyy HH:mm"; 
				return _NgaySD.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_NgaySD.Text != value) 
				{
					_NgaySD.Text = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}
		
		public String NguoiSD
		{
			get 
			{
				CanReadProperty("NguoiSD", true);
				return _NguoiSD;
			}
			set 
			{
				CanWriteProperty("NguoiSD", true);
				if (_NguoiSD != value) 
				{
					_NguoiSD = value;
					PropertyHasChanged("NguoiSD");
				}
			}
		}
		
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _NgaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_NgaySD1.Text != value) 
        //        {
        //            _NgaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
		
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _NguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_NguoiSD1 != value) 
        //        {
        //            _NguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}
    
    
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
			return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh_Nhi" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_Nhi NewKhamBenh_Nhi()
        {
            return new KhamBenh_Nhi();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_Nhi NewKhamBenh_Nhi(string idDMDichvu)
        {
            return new KhamBenh_Nhi(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_Nhi NewKhamBenh_Nhi(DMDichVu _DMDichvu)
        {
            return new KhamBenh_Nhi(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_Nhi NewKhamBenh_Nhi(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_Nhi(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_Nhi GetKhamBenh_Nhi(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_Nhi>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_Nhi GetKhamBenh_Nhi(SafeDataReader dr)
        {
            return new KhamBenh_Nhi(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_Nhi" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_Nhi(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
			#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_Nhi()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_Nhi(DMDichVu pro)
        {
            MarkAsChild();
           
            
            _maDV = pro.MaDV;
         
        }
        protected KhamBenh_Nhi(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _MaSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _Huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _NguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Nhi(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Nhi(SafeDataReader dr)
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
		/// Retrieve an existing <see cref="KhamBenh_Nhi" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_Nhi(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_Nhi(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Nhi_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_Nhi(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_Nhi" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
         	if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");

            if (dr.GetBoolean("Rubella") != null) _Rubella = dr.GetBoolean("Rubella");
            if (dr.GetBoolean("UonVan") != null) _UonVan = dr.GetBoolean("UonVan");
            if (dr.GetBoolean("TiemChungKhac") != null) _TiemChungKhac = dr.GetBoolean("TiemChungKhac");
            if (dr.GetString("TrieuChung") != null) _TrieuChung = dr.GetString("TrieuChung");


            if (dr.GetString("Tiensu") != null) _Tiensu = dr.GetString("Tiensu");
            if (dr.GetString("DiungThuoc") != null) _DiungThuoc = dr.GetString("DiungThuoc");
            if (dr.GetString("nhommau") != null) _nhommau = dr.GetString("nhommau");
            
            if (dr.GetString("Chuandoan") != null) _Chuandoan = dr.GetString("Chuandoan");
            if (dr.GetString("BenhKhac") != null) _BenhKhac = dr.GetString("BenhKhac");
            if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
            if (dr.GetString("BenhLyKhac") != null) _BenhLyKhac = dr.GetString("BenhLyKhac");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");
            if (dr.GetString("LoiDanBS") != null) _LoiDanBS = dr.GetString("LoiDanBS");
            if (dr.GetString("BenhSu") != null) _BenhSu = dr.GetString("BenhSu");
         
            if (dr.GetString("HuongDT") != null) _HuongDT = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _Mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _MaBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("MaBV") != null) _MaBV = dr.GetString("MaBV");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _Huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _NgaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _NguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _NgaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _NguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("tenBSKham") != null) _tenBSKham = dr.GetString("tenBSKham");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
          
          
           
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_Nhi" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Nhi
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_Nhi(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _Tiensu, _DiungThuoc, _nhommau, _Chuandoan, _BenhKhac, _TenBenh, _BenhLyKhac, _DieuTri, _LoiDanBS,_BenhSu , _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _NguoiSD);
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_Nhi" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Nhi
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_Nhi(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _Tiensu, _DiungThuoc, _nhommau, _Chuandoan, _BenhKhac, _TenBenh, _BenhLyKhac, _DieuTri, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _Huy, _NguoiSD);
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_NguoiSD , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_Nhi" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Nhi
            DataProvider.Instance().DeleteKhamBenh_Nhi(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Nhi
            // Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_Nhi(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _Tiensu, _DiungThuoc, _nhommau, _Chuandoan, _BenhKhac, _TenBenh, _BenhLyKhac, _DieuTri, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay, _NguoiSD);
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_Nhi" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Nhi
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_Nhi(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _Tiensu, _DiungThuoc,_nhommau, _Chuandoan, _BenhKhac, _TenBenh, _BenhLyKhac, _DieuTri, _LoiDanBS,_BenhSu , _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _Huy, _NguoiSD);
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
              
              DataProvider.Instance().DeleteKhamBenh_Nhi(_maMay, _NguoiSD, obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
