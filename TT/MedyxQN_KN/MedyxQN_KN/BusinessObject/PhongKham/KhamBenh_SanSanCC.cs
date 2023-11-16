// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_SanSanCC
// Kieu doi tuong  :	KhamBenh_SanSanCC
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
    /// This is a base generated class of <see cref="KhamBenh_SanSanCC" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_SanSanCC : BusinessBase<KhamBenh_SanSanCC>
	{
		#region Business Methods
		
		#region State Fields
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
	
        private String _MaSoKham = String.Empty;
        private Int32 _sTT = 0;
        private String _maDV = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
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

        private String _MaTinhThan = String.Empty;
        private String _TinhThanCT = String.Empty;
        private String _MaPhu = String.Empty;
        private String _ProteinNieu = String.Empty;
        private String _MaCTC = String.Empty;
        private String _ConCoTC = String.Empty;
        private String _CTCMo = String.Empty;
        private String _CTCBishop = String.Empty;
        private String _MaDauOi = String.Empty;
        private String _TGDauOi = String.Empty;
        private String _TienLuong = String.Empty;
        private String _MaNuocOi = String.Empty;

        private String _DieuTri = String.Empty;
        private String _tenBSKham = String.Empty;
     
        private String _Chuandoan = String.Empty;
        private String _BenhKhac = String.Empty;
        private String _LoiDanBS = String.Empty;
    
        private String _BenhSu = String.Empty;
        private String _HuongDT = String.Empty;
        private String _Mabenh = String.Empty;
        private String _MaBenhKem = String.Empty;
        private String _MaBV = String.Empty;
       	private String _maMay = String.Empty;

		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
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

		public String BSKham

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
                CanReadProperty("UonVan ", true);
                return _UonVan ;
            }
            set
            {
                CanWriteProperty("UonVan ", true);
                if (_UonVan  != value)
                {
                    _UonVan  = value;
                    PropertyHasChanged("UonVan");
                }
            }
        }
        public Boolean TiemChungKhac
        {
            get
            {
                CanReadProperty("TiemChungKhac ", true);
                return _UonVan;
            }
            set
            {
                CanWriteProperty("TiemChungKhac ", true);
                if (_TiemChungKhac != value)
                {
                    _TiemChungKhac = value;
                    PropertyHasChanged("TiemChungKhac");
                }
            }
        }

        public String MaTinhThan
        {
            get
            {
                CanReadProperty("MaTinhThan", true);
                return _MaTinhThan;
            }
            set
            {
                CanWriteProperty("MaTinhThan", true);
                if (_MaTinhThan != value)
                {
                    _MaTinhThan = value;
                    PropertyHasChanged("MaTinhThan");
                }
            }
        }
        public String TinhThanCT
        {
            get
            {
                CanReadProperty("TinhThanCT", true);
                return _TinhThanCT;
            }
            set
            {
                CanWriteProperty("TinhThanCT", true);
                if (_TinhThanCT != value)
                {
                    _TinhThanCT = value;
                    PropertyHasChanged("TinhThanCT");
                }
            }
        }
        public String MaPhu
        {
            get
            {
                CanReadProperty("MaPhu", true);
                return _MaPhu;
            }
            set
            {
                CanWriteProperty("MaPhu", true);
                if (_MaPhu != value)
                {
                    _MaPhu = value;
                    PropertyHasChanged("MaPhu");
                }
            }
        }
        public String ProteinNieu
        {
            get
            {
                CanReadProperty("ProteinNieu", true);
                return _ProteinNieu;
            }
            set
            {
                CanWriteProperty("ProteinNieu", true);
                if (_ProteinNieu != value)
                {
                    _ProteinNieu = value;
                    PropertyHasChanged("ProteinNieu");
                }
            }
        }
        public String MaCTC
        {
            get
            {
                CanReadProperty("MaCTC", true);
                return _MaCTC;
            }
            set
            {
                CanWriteProperty("MaCTC", true);
                if (_MaCTC != value)
                {
                    _MaCTC = value;
                    PropertyHasChanged("MaCTC");
                }
            }
        }
        public String ConCoTC
        {
            get
            {
                CanReadProperty("ConCoTC", true);
                return _ConCoTC;
            }
            set
            {
                CanWriteProperty("ConCoTC", true);
                if (_ConCoTC != value)
                {
                    _ConCoTC = value;
                    PropertyHasChanged("ConCoTC");
                }
            }
        }
        public String CTCMo
        {
            get
            {
                CanReadProperty("CTCMo", true);
                return _CTCMo;
            }
            set
            {
                CanWriteProperty("CTCMo", true);
                if (_CTCMo != value)
                {
                    _CTCMo = value;
                    PropertyHasChanged("CTCMo");
                }
            }
        }
        public String CTCBishop
        {
            get
            {
                CanReadProperty("CTCBishop", true);
                return _CTCBishop;
            }
            set
            {
                CanWriteProperty("CTCBishop", true);
                if (_CTCBishop != value)
                {
                    _CTCBishop = value;
                    PropertyHasChanged("CTCBishop");
                }
            }
        }
        public String MaDauOi
        {
            get
            {
                CanReadProperty("MaDauOi", true);
                return _MaDauOi;
            }
            set
            {
                CanWriteProperty("MaDauOi", true);
                if (_MaDauOi != value)
                {
                    _MaDauOi = value;
                    PropertyHasChanged("MaDauOi");
                }
            }
        }
        public String TGDauOi
        {
            get
            {
                CanReadProperty("TGDauOi", true);
                return _TGDauOi;
            }
            set
            {
                CanWriteProperty("TGDauOi", true);
                if (_TGDauOi != value)
                {
                    _TGDauOi = value;
                    PropertyHasChanged("TGDauOi");
                }
            }
        }
        public String TienLuong
        {
            get
            {
                CanReadProperty("TienLuong", true);
                return _TienLuong;
            }
            set
            {
                CanWriteProperty("TienLuong", true);
                if (_TienLuong != value)
                {
                    _TienLuong = value;
                    PropertyHasChanged("TienLuong");
                }
            }
        }
        public String MaNuocOi
        {
            get
            {
                CanReadProperty("MaNuocOi", true);
                return _MaNuocOi;
            }
            set
            {
                CanWriteProperty("MaNuocOi", true);
                if (_MaNuocOi != value)
                {
                    _MaNuocOi = value;
                    PropertyHasChanged("MaNuocOi");
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
                CanReadProperty("BenhKhac", true);
                return _BenhKhac;
            }
            set
            {
                CanWriteProperty("BenhKhac", true);
                if (_BenhKhac != value)
                {
                    _BenhKhac = value;
                    PropertyHasChanged("BenhKhac");
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
		
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _ngaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value) 
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
		
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value) 
        //        {
        //            _nguoiSD1 = value;
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
        /// Factory method. New <see cref="KhamBenh_SanSanCC" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_SanSanCC NewKhamBenh_SanSan()
        {
            return new KhamBenh_SanSanCC();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_SanSanCC NewKhamBenh_SanSan(string idDMDichvu)
        {
            return new KhamBenh_SanSanCC(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_SanSanCC NewKhamBenh_SanSan(DMDichVu _DMDichvu)
        {
            return new KhamBenh_SanSanCC(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_SanSanCC NewKhamBenh_SanSan(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_SanSanCC(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_SanSanCC GetKhamBenh_SanSan(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_SanSanCC>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_SanSanCC GetKhamBenh_SanSan(SafeDataReader dr)
        {
            return new KhamBenh_SanSanCC(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_SanSanCC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_SanSanCC(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_SanSanCC()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_SanSanCC(DMDichVu pro)
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
        protected KhamBenh_SanSanCC(string maSoKham,DMDichVu pro)
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
        protected KhamBenh_SanSanCC(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_SanSanCC(SafeDataReader dr)
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
		/// Retrieve an existing <see cref="KhamBenh_SanSanCC" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_SanSan(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_SanSanCC" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");

			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("maDV") != null) _maDV = dr.GetString("maDV");
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

            if (dr.GetString("MaTinhThan") != null) _MaTinhThan = dr.GetString("MaTinhThan");
            if (dr.GetString("TinhThanCT") != null) _TinhThanCT = dr.GetString("TinhThanCT");
            if (dr.GetString("MaPhu") != null) _MaPhu = dr.GetString("MaPhu");
            if (dr.GetString("ProteinNieu") != null) _ProteinNieu = dr.GetString("ProteinNieu");
            if (dr.GetString("MaCTC") != null) _MaCTC = dr.GetString("MaCTC");
            if (dr.GetString("ConCoTC") != null) _ConCoTC = dr.GetString("ConCoTC");
            if (dr.GetString("CTCMo") != null) _CTCMo = dr.GetString("CTCMo");
            if (dr.GetString("CTCBishop") != null) _CTCBishop = dr.GetString("CTCBishop");
            if (dr.GetString("MaDauOi") != null) _MaDauOi = dr.GetString("MaDauOi");
            if (dr.GetString("TGDauOi") != null) _TGDauOi = dr.GetString("TGDauOi");
            if (dr.GetString("TienLuong") != null) _TienLuong = dr.GetString("TienLuong");
            if (dr.GetString("MaNuocOi") != null) _BenhSu = dr.GetString("MaNuocOi");
            

           
            if (dr.GetString("Chuandoan") != null) _Chuandoan = dr.GetString("Chuandoan");
            if (dr.GetString("BenhKhac") != null) _BenhKhac = dr.GetString("BenhKhac");
            if (dr.GetString("LoiDanBS") != null) _LoiDanBS = dr.GetString("LoiDanBS");
           
         
            if (dr.GetString("BenhSu") != null) _BenhSu = dr.GetString("BenhSu");
            if (dr.GetString("HuongDT") != null) _HuongDT = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _Mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _MaBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("MaBV") != null) _MaBV = dr.GetString("MaBV");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("tenBSKham") != null) _tenBSKham = dr.GetString("tenBSKham");
        
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_SanSanCC" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_SanSan
			// Copy & paste ham duoi day vao file DataProvider.cs
            DataProvider.Instance().InsertKhamBenh_SanSanCC( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _MaTinhThan,  _TinhThanCT,  _MaPhu,  _ProteinNieu,  _MaCTC,  _ConCoTC,  _CTCMo,  _CTCBishop,  _MaDauOi,  _TGDauOi,  _TienLuong,  _MaNuocOi, _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV,_DieuTri , _maMay , _nguoiSD);
            MarkOld();
    
	
		}
		/// Update all changes made on <see cref="KhamBenh_SanSanCC" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanSan
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_SanSanCC(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _MaTinhThan, _TinhThanCT, _MaPhu, _ProteinNieu, _MaCTC, _ConCoTC, _CTCMo, _CTCBishop, _MaDauOi, _TGDauOi, _TienLuong, _MaNuocOi, _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _nguoiSD);
                MarkOld();
              //  DataProvider.Instance().UpdateKhamBenh_SanSan( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _Sinhdoi, _Benhditruyen, _Caohuyetap, _Didang, _Daiduong, _Loaikhac, _Caohuyetapkhoa, _Than, _Moruotthua, _Tim, _Basedow, _Laophoi, _Diungthuoc, _Viemtactinhmach, _Cuthe, _Henphequan, _Dongkinh, _PTongbung, _Tuoicokinh, _UBT, _TSM, _Chukykinh, _UsoTC, _DieutriCTC, _Ngaythaykinh, _DidangSD, _CatcutCTC, _Tuoilaychong, _SSD, _LoaikhacPT, _PARA, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _nguoiSD);
                // public abstract void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)

				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD    , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_SanSanCC" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanSan
            DataProvider.Instance().DeleteKhamBenh_SanSanCC(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			// public abstract void DeleteKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_Deleted", _MaSoKham, _sTT, _sTTKhoa);
			// }
		}

        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_SanSan
            // Copy & paste ham duoi day vao file DataProvider.cs
            DataProvider.Instance().InsertKhamBenh_SanSanCC(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _MaTinhThan, _TinhThanCT, _MaPhu, _ProteinNieu, _MaCTC, _ConCoTC, _CTCMo, _CTCBishop, _MaDauOi, _TGDauOi, _TienLuong, _MaNuocOi,  _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _nguoiSD);
             MarkOld();
          
            
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_SanSanCC" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanSan
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_SanSanCC(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _MaTinhThan, _TinhThanCT, _MaPhu, _ProteinNieu, _MaCTC, _ConCoTC, _CTCMo, _CTCBishop, _MaDauOi, _TGDauOi, _TienLuong, _MaNuocOi, _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _nguoiSD);
                MarkOld();
                //DataProvider.Instance().UpdateKhamBenh_SanSan( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _Sinhdoi, _Benhditruyen, _Caohuyetap, _Didang, _Daiduong, _Loaikhac, _Caohuyetapkhoa, _Than, _Moruotthua, _Tim, _Basedow, _Laophoi, _Diungthuoc, _Viemtactinhmach, _Cuthe, _Henphequan, _Dongkinh, _PTongbung, _Tuoicokinh, _UBT, _TSM, _Chukykinh, _UsoTC, _DieutriCTC, _Ngaythaykinh, _DidangSD, _CatcutCTC, _Tuoilaychong, _SSD, _LoaikhacPT, _PARA, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _nguoiSD);
                // public abstract void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)

                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
                // }				
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
              
            DataProvider.Instance().DeleteKhamBenh_SanSanCC(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }

		#endregion
	}

}
