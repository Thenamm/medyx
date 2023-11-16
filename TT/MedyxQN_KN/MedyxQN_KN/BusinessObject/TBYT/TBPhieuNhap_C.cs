// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBPhieuNhap_C
// Kieu doi tuong  :	TBPhieuNhap_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/10/2009 10:50:48 AM
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

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBPhieuNhap_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBPhieuNhap_C : BusinessBase<TBPhieuNhap_C>
	{
		#region Business Methods
		
		#region State Fields
        private int _khauHao = 0;
		private String _maPN = String.Empty;
		private String _maTBC = String.Empty;
		private String _maTB = String.Empty;
		private Boolean _tBKem = false;
		private Decimal _vat = 0;
		private Decimal _chatLuong = 0;
		private Decimal _soluong = 0;
		private String _serialNo = String.Empty;
		private String _model = String.Empty;
		private Decimal _donGia = 0;
		private Decimal _nguyenTe = 0;
		private Decimal _tyGia = 0;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private Decimal _thanhTien;

        private SmartDate _namSX = new SmartDate(true);
        private Decimal _khoiLuong = 0;
        private Decimal _tl_KHCB = 0;
        private String _congSuatTK = String.Empty;
        private String _maNSX = String.Empty;
        private String _maQG = String.Empty;
        private String _tenNSX = String.Empty;
        private String _tenQG = String.Empty;
        private Int32 _kybaoduong = 0;
        private String _tenTB = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;
        private String _maTrangThai = String.Empty;
        private int _SuDungDN = Int32.MinValue;
		#endregion
		
		#region Business Properties and Methods

        public int KhauHao
        {
            get
            {
                CanReadProperty("KhauHao", true);
                return _khauHao;
            }
            set
            {
                CanWriteProperty("KhauHao", true);
                if (_khauHao != value)
                {
                    _khauHao = value;
                    PropertyHasChanged("KhauHao");
                }
            }
        }

        public int SuDungDN
        {
            get
            {
                CanReadProperty("SuDungDN", true);
                return _SuDungDN;
            }
            set
            {
                CanWriteProperty("SuDungDN", true);
                if (_SuDungDN != value)
                {
                    _SuDungDN = value;
                    PropertyHasChanged("SuDungDN");
                }
            }
        }
		public String MaPN
		{
			get 
			{
				CanReadProperty("MaPN", true);
				return _maPN;
			}
			set 
			{
				CanWriteProperty("MaPN", true);
				if (_maPN != value) 
				{
					_maPN = value;
					PropertyHasChanged("MaPN");
				}
			}
		}
		
		public String MaTBC
		{
			get 
			{
				CanReadProperty("MaTBC", true);
				return _maTBC;
			}
			set 
			{
				CanWriteProperty("MaTBC", true);
				if (_maTBC != value) 
				{
					_maTBC = value;
					PropertyHasChanged("MaTBC");
				}
			}
		}
		
		public String MaTB
		{
			get 
			{
				CanReadProperty("MaTB", true);
				return _maTB;
			}
			set 
			{
				CanWriteProperty("MaTB", true);
				if (_maTB != value) 
				{
					_maTB = value;
					PropertyHasChanged("MaTB");
				}
			}
		}
        public String MaTrangThai
        {
            get
            {
                CanReadProperty("MaTrangThai", true);
                return _maTrangThai;
            }
            set
            {
                CanWriteProperty("MaTrangThai", true);
                if (_maTrangThai != value)
                {
                    _maTrangThai = value;
                    PropertyHasChanged("MaTrangThai");
                }
            }
        }
		
		
		public Boolean TBKem
		{
			get 
			{
				CanReadProperty("TBKem", true);
				return _tBKem;
			}
			set 
			{
				CanWriteProperty("TBKem", true);
				if (_tBKem != value) 
				{
					_tBKem = value;
					PropertyHasChanged("TBKem");
				}
			}
		}
		
        //public Decimal Vat
        //{
        //    get 
        //    {
        //        CanReadProperty("Vat", true);
        //        return _vat;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Vat", true);
        //        if (_vat != value) 
        //        {
        //            _vat = value;
        //            PropertyHasChanged("Vat");
        //        }
        //    }
        //}
        public string Vat
        {
            get
            {
                CanReadProperty("Vat", true);
                if (_vat == 0)
                {
                    return "0";
                }
                else
                {
                    return _vat.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Vat", true);

                if (_vat.ToString() != value)
                {
                    _vat = decimal.Parse(value);
                    PropertyHasChanged("Vat");
                }
            }
        }
		
		public Decimal ChatLuong
		{
			get 
			{
				CanReadProperty("ChatLuong", true);
				return _chatLuong;
			}
			set 
			{
				CanWriteProperty("ChatLuong", true);
				if (_chatLuong != value) 
				{
					_chatLuong = value;
					PropertyHasChanged("ChatLuong");
				}
			}
		}
		
        //public Decimal Soluong
        //{
        //    get 
        //    {
        //        CanReadProperty("Soluong", true);
        //        return _soluong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Soluong", true);
        //        if (_soluong != value) 
        //        {
        //            _soluong = value;
        //            PropertyHasChanged("Soluong");
        //        }
        //    }
        //}
        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soluong == 0)
                {
                    return "0";
                }

                else
                {
                    return _soluong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Soluong", true);
                if (_soluong.ToString() == "" || value == null)
                {
                    _soluong = 0;
                    PropertyHasChanged("Soluong");
                }
                else if (_soluong.ToString() != value)
                {
                    _soluong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
                }


            }
        }
		
		public String SerialNo
		{
			get 
			{
				CanReadProperty("SerialNo", true);
				return _serialNo;
			}
			set 
			{
				CanWriteProperty("SerialNo", true);
				if (_serialNo != value) 
				{
					_serialNo = value;
					PropertyHasChanged("SerialNo");
				}
			}
		}
		
		public String Model
		{
			get 
			{
				CanReadProperty("Model", true);
				return _model;
			}
			set 
			{
				CanWriteProperty("Model", true);
				if (_model != value) 
				{
					_model = value;
					PropertyHasChanged("Model");
				}
			}
		}
		
        //public Decimal DonGia
        //{
        //    get 
        //    {
        //        CanReadProperty("DonGia", true);
        //        return _donGia;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DonGia", true);
        //        if (_donGia != value) 
        //        {
        //            _donGia = value;
        //            PropertyHasChanged("DonGia");
        //        }
        //    }
        //}
        public string DonGia
        {
            get
            {
                CanReadProperty("DonGia", true);
                if (_donGia == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGia.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("DonGia", true);

                if (_donGia.ToString() != value)
                {
                    _donGia = decimal.Parse(value);
                    PropertyHasChanged("DonGia");
                }
            }
        }
		
		public Decimal NguyenTe
		{
			get 
			{
				CanReadProperty("NguyenTe", true);
				return _nguyenTe;
			}
			set 
			{
				CanWriteProperty("NguyenTe", true);
				if (_nguyenTe != value) 
				{
					_nguyenTe = value;
					PropertyHasChanged("NguyenTe");
				}
			}
		}
		
		public Decimal TyGia
		{
			get 
			{
				CanReadProperty("TyGia", true);
				return _tyGia;
			}
			set 
			{
				CanWriteProperty("TyGia", true);
				if (_tyGia != value) 
				{
					_tyGia = value;
					PropertyHasChanged("TyGia");
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

        public string NamSX
        {
            get
            {
                CanReadProperty("NamSX", true);
                return _namSX.Text ;
            }
            set
            {
                CanWriteProperty("NamSX", true);
                if (_namSX.Text  != value)
                {
                    _namSX.Text  = value;
                    PropertyHasChanged("NamSX");
                }
            }
        }

        public Decimal KhoiLuong
        {
            get
            {
                CanReadProperty("KhoiLuong", true);
                return _khoiLuong;
            }
            set
            {
                CanWriteProperty("KhoiLuong", true);
                if (_khoiLuong != value)
                {
                    _khoiLuong = value;
                    PropertyHasChanged("KhoiLuong");
                }
            }
        }

        public Decimal tl_KHCB
        {
            get
            {
                CanReadProperty("tl_KHCB", true);
                return _tl_KHCB;
            }
            set
            {
                CanWriteProperty("tl_KHCB", true);
                if (_tl_KHCB != value)
                {
                    _tl_KHCB = value;
                    PropertyHasChanged("tl_KHCB");
                }
            }
        }

        public String CongSuatTK
        {
            get
            {
                CanReadProperty("CongSuatTK", true);
                return _congSuatTK;
            }
            set
            {
                CanWriteProperty("CongSuatTK", true);
                if (_congSuatTK != value)
                {
                    _congSuatTK = value;
                    PropertyHasChanged("CongSuatTK");
                }
            }
        }

        public String MaNSX
        {
            get
            {
                CanReadProperty("MaNSX", true);
                return _maNSX;
            }
            set
            {
                CanWriteProperty("MaNSX", true);
                if (_maNSX != value)
                {
                    _maNSX = value;
                    PropertyHasChanged("MaNSX");
                }
            }
        }
        public String MaQG
        {
            get
            {
                CanReadProperty("MaQG", true);
                return _maQG;
            }
            set
            {
                CanWriteProperty("MaQG", true);
                if (_maQG != value)
                {
                    _maQG = value;
                    PropertyHasChanged("MaQG");
                }
            }
        }

        public String TenNSX
        {
            get
            {
                CanReadProperty("TenNSX", true);
                return _tenNSX;
            }
            set
            {
                CanWriteProperty("TenNSX", true);
                if (_tenNSX != value)
                {
                    _tenNSX = value;
                    PropertyHasChanged("TenNSX");
                }
            }
        }
        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
                }
            }
        }
        public Int32  Kybaoduong
        {
            get
            {
                CanReadProperty("Kybaoduong", true);
                return _kybaoduong;
            }
            set
            {
                CanWriteProperty("Kybaoduong", true);
                if (_kybaoduong != value)
                {
                    _kybaoduong = value;
                    PropertyHasChanged("Kybaoduong");
                }
            }
        }
        public String TenTB
        {
            get
            {
                CanReadProperty("TenTB", true);
                return _tenTB;
            }
            set
            {
                CanWriteProperty("TenTB", true);
                if (_tenTB != value)
                {
                    _tenTB = value;
                    PropertyHasChanged("TenTB");
                }
            }
        }

        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
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
        public string ThanhTien
        {
            get
            {
                CanReadProperty("ThanhTien", true);
                //  _thanhTien = (_soLuong * _donGia * (100 + _chietKhau)) / 100; 
                return _thanhTien.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("ThanhTien", true);

                if (_thanhTien.ToString() != value)
                {
                    _thanhTien = decimal.Parse(value);
                    PropertyHasChanged("ThanhTien");
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
        // Thuy bo
        //TBPhieuNhap_KP_List _TBPhieuNhap_KPs = TBPhieuNhap_KP_List.NewTBPhieuNhap_KP_List();

        //public TBPhieuNhap_KP_List TBPhieuNhap_KPs
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _TBPhieuNhap_KPs;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_TBPhieuNhap_KPs.Equals(value))
        //        {
        //            _TBPhieuNhap_KPs = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        TBLinhKien_PNC_List _TBPhieuNhap_KPs = TBLinhKien_PNC_List.NewTBLinhKien_C_List();

        public TBLinhKien_PNC_List TBPhieuNhap_KPs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _TBPhieuNhap_KPs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TBPhieuNhap_KPs.Equals(value))
                {
                    _TBPhieuNhap_KPs = value;
                    PropertyHasChanged();
                }
            }
        }



		protected override Object GetIdValue()
		{
			return _maPN.ToString() + "!" + _maTBC.ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _TBPhieuNhap_KPs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _TBPhieuNhap_KPs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBPhieuNhap_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static TBPhieuNhap_C NewTBPhieuNhap_C()
        {
            return new TBPhieuNhap_C();

        }
        public static TBPhieuNhap_C NewTBPhieuNhap_C(string idDMTB)
        {
            return new TBPhieuNhap_C(DMTBYT.GetDMTBYT(idDMTB));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static TBPhieuNhap_C NewTBPhieuNhap_C(DMTBYT _DMTBYT)
        {
            return new TBPhieuNhap_C(_DMTBYT);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
		public static TBPhieuNhap_C GetTBPhieuNhap_C(String maPN, String maTBC)
		{
			return DataPortal.Fetch<TBPhieuNhap_C>(new Criteria(maPN, maTBC));
		}
        public static TBPhieuNhap_C GetTBPhieuNhap_C(SafeDataReader dr)
        {
            return new TBPhieuNhap_C(dr);
        }
        public static TBPhieuNhap_C GetTBPhieuNhap_C(int i, SafeDataReader dr)
        {
            return new TBPhieuNhap_C(i, dr);
        }
		/// <summary>
		/// Marks the <see cref="TBPhieuNhap_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBPhieuNhap_C(String maPN, String maTBC, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPN, maTBC));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBPhieuNhap_C()
		{	
			// Prevent direct creation
		}
		protected TBPhieuNhap_C(DMTBYT pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maTB = pro.MaTB;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            _tenTB = pro.TenTB;
            //MarkOld();
        }
        protected TBPhieuNhap_C(string _idMaPN, DMTBYT pro)
        {
            MarkAsChild();
            _maPN = _idMaPN;
            _maTB = pro.MaTB; 
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected TBPhieuNhap_C(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            try
            {
                _khauHao = dr.GetInt32("KhauHao");
            }
            catch
            {

            }

            _maPN = dr.GetString("MaPN");
            _SuDungDN = dr.GetInt32("SuDungDN");
             _maTBC = dr.GetString("MaTBC");
             _maTB = dr.GetString("MaTB");
             _tBKem = dr.GetBoolean("TBKem");
             _vat = dr.GetDecimal("vat");
             _chatLuong = dr.GetDecimal("ChatLuong");
             _soluong = dr.GetDecimal("Soluong");
            _serialNo = dr.GetString("SerialNo");
             _model = dr.GetString("Model");
             _donGia = dr.GetDecimal("DonGia");
             _nguyenTe = dr.GetDecimal("NguyenTe");
             _tyGia = dr.GetDecimal("TyGia");
             _huy = dr.GetBoolean("Huy");
             _ghichu = dr.GetString("Ghichu");
             _ngaySD = dr.GetSmartDate("NgaySD", true);
            _nguoiSD = dr.GetString("NguoiSD");
            _maMay = dr.GetString("MaMay");
            _maTrangThai = dr.GetString("MaTrangThai");
            _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;

            _namSX = dr.GetSmartDate("NamSX", true);
            _khoiLuong = dr.GetDecimal("KhoiLuong");
            _tl_KHCB = dr.GetDecimal("tl_KHCB");
            _congSuatTK = dr.GetString("congSuatTK");
            _maNSX = dr.GetString("maNSX");
            _maQG = dr.GetString("maQG");
            _tenNSX = dr.GetString("tenNSX");
            _tenQG = dr.GetString("tenQG");
            _kybaoduong = dr.GetInt32("kybaoduong");
              _tenTB = dr.GetString("tenTB");
              _tenDVT = dr.GetString("TENDVT");
              _tenNguoiSD = dr.GetString("TENNGUOISD");

         
          // _OrderNumber = dr.GetByte("STT");
            MarkOld();
        }
        protected TBPhieuNhap_C(int i, SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber  = i;
            try
            {
                _khauHao = dr.GetInt32("KhauHao");
            }
            catch
            {

            }
            _maPN = dr.GetString("MaPN");
            _maTBC = dr.GetString("MaTBC");
            _SuDungDN = dr.GetInt32("SuDungDN");
            _maTB = dr.GetString("MaTB");
            _tBKem = dr.GetBoolean("TBKem");
            _vat = dr.GetDecimal("vat");
            _chatLuong = dr.GetDecimal("ChatLuong");
            _soluong = dr.GetDecimal("Soluong");
            _serialNo = dr.GetString("SerialNo");
            _model = dr.GetString("Model");
            _donGia = dr.GetDecimal("DonGia");
            _nguyenTe = dr.GetDecimal("NguyenTe");
            _tyGia = dr.GetDecimal("TyGia");
            _huy = dr.GetBoolean("Huy");
            _ghichu = dr.GetString("Ghichu");
            _ngaySD = dr.GetSmartDate("NgaySD", true);
            _nguoiSD = dr.GetString("NguoiSD");
            _maMay = dr.GetString("MaMay");
            _maTrangThai = dr.GetString("MaTrangThai");
            _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;

            _namSX = dr.GetSmartDate("NamSX", true);
            _khoiLuong = dr.GetDecimal("KhoiLuong");
            _tl_KHCB = dr.GetDecimal("tl_KHCB");
            _congSuatTK = dr.GetString("congSuatTK");
            _maNSX = dr.GetString("maNSX");
            _maQG = dr.GetString("maQG");
            _tenNSX = dr.GetString("tenNSX");
            _tenQG = dr.GetString("tenQG");
            _kybaoduong = dr.GetInt32("kybaoduong");
            _tenTB = dr.GetString("tenTB");
            _tenDVT = dr.GetString("TENDVT");
            _tenNguoiSD = dr.GetString("TENNGUOISD");


            // _OrderNumber = dr.GetByte("STT");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPN;
			public String MaPN 
			{
				get
				{
					return _maPN;
				}
			}
			
			private String _maTBC;
			public String MaTBC 
			{
				get
				{
					return _maTBC;
				}
			}
			
			public Criteria(String maPN, String maTBC)
			{
				_maPN = maPN;
				_maTBC = maTBC;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPN.Equals(c._maPN)) 
						return false;
					if (!_maTBC.Equals(c._maTBC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPN.ToString(), _maTBC.ToString()).GetHashCode();
			}
		}

        [Serializable()]

        protected class OtherCriteria
        {
            private String _maPN;
            public String maPN
            {
                get
                {
                    return _maPN;
                }
            }

            private String _maTBC;
            public String maTBC
            {
                get
                {
                    return _maTBC;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPN, String maTBC)
            {
                _maPN = maPN;
                _maTBC = maTBC;
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
		/// Retrieve an existing <see cref="TBPhieuNhap_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBPhieuNhap_C(String _maPN, String _maTBC);
			// public override IDataReader GetTBPhieuNhap_C(String _maPN, String _maTBC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPN, _maTBC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBPhieuNhap_C(crit.MaPN, crit.MaTBC,false    )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        //_TBPhieuNhap_KPs = TBPhieuNhap_KP_List.GetTBPhieuNhap_KP_List(dr);
                        _TBPhieuNhap_KPs = TBLinhKien_PNC_List.GetTBLinhKien_C_List (dr);
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBPhieuNhap_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPN") != null) _maPN = dr.GetString("MaPN");
			if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");

            if (dr.GetInt32("SuDungDN") != null) _SuDungDN = dr.GetInt32("SuDungDN");

            try
            {
                _khauHao = dr.GetInt32("KhauHao");
            }
            catch
            {

            }

			if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
			if (dr.GetBoolean("TBKem") != null) _tBKem = dr.GetBoolean("TBKem");
			if (dr.GetDecimal("vat") != null) _vat = dr.GetDecimal("vat");
			if (dr.GetDecimal("ChatLuong") != null) _chatLuong = dr.GetDecimal("ChatLuong");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
			if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
			if (dr.GetString("Model") != null) _model = dr.GetString("Model");
			if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
			if (dr.GetDecimal("NguyenTe") != null) _nguyenTe = dr.GetDecimal("NguyenTe");
			if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _maTrangThai = dr.GetString("MaTrangThai");
            _namSX = dr.GetSmartDate("NamSX", true);
            _khoiLuong = dr.GetDecimal("KhoiLuong");
            _tl_KHCB = dr.GetDecimal("tl_KHCB");
            _congSuatTK = dr.GetString("congSuatTK");
            _maNSX = dr.GetString("maNSX");
            _maQG = dr.GetString("maQG");
            _tenNSX = dr.GetString("tenNSX");
            _tenQG = dr.GetString("tenQG");
            _kybaoduong = dr.GetInt32("kybaoduong");
            _tenTB = dr.GetString("tenTB");
            _tenDVT = dr.GetString("TENDVT");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
		}

        private void Fetch(int i, SafeDataReader dr)
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaPN") != null) _maPN = dr.GetString("MaPN");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
            try
            {
                _khauHao = dr.GetInt32("KhauHao");
            }
            catch
            {

            }
            if (dr.GetInt32("SuDungDN") != null) _SuDungDN = dr.GetInt32("SuDungDN");
            if (dr.GetBoolean("TBKem") != null) _tBKem = dr.GetBoolean("TBKem");
            if (dr.GetDecimal("vat") != null) _vat = dr.GetDecimal("vat");
            if (dr.GetDecimal("ChatLuong") != null) _chatLuong = dr.GetDecimal("ChatLuong");
            if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
            if (dr.GetDecimal("NguyenTe") != null) _nguyenTe = dr.GetDecimal("NguyenTe");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _maTrangThai = dr.GetString("MaTrangThai");
            _namSX = dr.GetSmartDate("NamSX", true);
            _khoiLuong = dr.GetDecimal("KhoiLuong");
            _tl_KHCB = dr.GetDecimal("tl_KHCB");
            _congSuatTK = dr.GetString("congSuatTK");
            _maNSX = dr.GetString("maNSX");
            _maQG = dr.GetString("maQG");
            _tenNSX = dr.GetString("tenNSX");
            _tenQG = dr.GetString("tenQG");
            _kybaoduong = dr.GetInt32("kybaoduong");
            _tenTB = dr.GetString("tenTB");
            _tenDVT = dr.GetString("TENDVT");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
        }

		/// <summary>
		/// Insert the new <see cref="TBPhieuNhap_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(TBPhieuNhap bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _maPN = bill.MaPN;
			_maTBC = DataProvider.Instance().InsertTBPhieuNhap_C(bill.MaPN, _maTB, _tBKem, _vat, _chatLuong, _soluong, _serialNo, _model, _donGia, _nguyenTe, _tyGia, _ghichu,_nguoiSD, _maMay, _maTrangThai, SuDungDN, _namSX, _maNSX,_tenQG, _khauHao);
            MarkOld();// public abstract String InsertTBPhieuNhap_C(String _maPN, String _maTBC, String _maTB, Boolean _tBKem, Decimal _vat, Decimal _chatLuong, Decimal _soluong, String _serialNo, String _model, Decimal _donGia, Decimal _nguyenTe, Decimal _tyGia, String _ghichu,  String _nguoiSD, String _maMay);
			// public override String InsertTBPhieuNhap_C(String _maPN, String _maTBC, String _maTB, Boolean _tBKem, Decimal _vat, Decimal _chatLuong, Decimal _soluong, String _serialNo, String _model, Decimal _donGia, Decimal _nguyenTe, Decimal _tyGia, String _ghichu,  String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_C_CREATE", _maPN, _maTB, _tBKem, _vat, _chatLuong, _soluong, _serialNo, _model, _donGia, _nguyenTe, _tyGia, _ghichu, _nguoiSD , _maMay));
			// }
            _TBPhieuNhap_KPs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBPhieuNhap_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(TBPhieuNhap bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateTBPhieuNhap_C(bill.MaPN, _maTBC, _maTB, _tBKem, _vat, _chatLuong, _soluong, _serialNo, _model, _donGia, _nguyenTe, _tyGia, _huy, _ghichu, _nguoiSD , _maMay, _maTrangThai, SuDungDN,_namSX,_maNSX,_tenQG, _khauHao);
				// public abstract void UpdateTBPhieuNhap_C(String _maPN, String _maTBC, String _maTB, Boolean _tBKem, Decimal _vat, Decimal _chatLuong, Decimal _soluong, String _serialNo, String _model, Decimal _donGia, Decimal _nguyenTe, Decimal _tyGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
				// public override void UpdateTBPhieuNhap_C(String _maPN, String _maTBC, String _maTB, Boolean _tBKem, Decimal _vat, Decimal _chatLuong, Decimal _soluong, String _serialNo, String _model, Decimal _donGia, Decimal _nguyenTe, Decimal _tyGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_C_UPDATE", _maPN, _maTBC, _maTB, _tBKem, _vat, _chatLuong, _soluong, _serialNo, _model, _donGia, _nguyenTe, _tyGia, _huy, _ghichu, _nguoiSD , _maMay);
				// }		
                _TBPhieuNhap_KPs.Update(this);

			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maPN, _maTBC));
        //}

        ///// <summary>
        ///// Delete the <see cref="TBPhieuNhap_C" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuNhap_C
        //    DataProvider.Instance().DeleteTBPhieuNhap_C(crit.MaPN, crit.MaTBC);
        //    // public abstract void DeleteTBPhieuNhap_C(String _maPN, String _maTBC);
        //    // public override void DeleteTBPhieuNhap_C(String _maPN, String _maTBC);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "[spTBPHIEUNHAP_C_DELETED]", _maPN, _maTBC);
        //    // }
        //}
        internal void DeleteSelf(TBPhieuNhap bill)
        {
            // if we're not dirty then don't update the database
            //if (!this.IsDirty)
            //    return;

            // if we're new then don't update the database
            //if (this.IsNew)
            //    return;
            
              
            DataProvider.Instance().DeleteTBPhieuNhap_C(_maMay, _nguoiSD , bill.MaPN, _maTBC);
            MarkNew();
        }
		#endregion
	}

}
