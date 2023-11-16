// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBKiemKe_C
// Kieu doi tuong  :	TBKiemKe_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/25/2009 8:41:12 AM
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
	/// This is a base generated class of <see cref="TBKiemKe_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBKiemKe_C : BusinessBase<TBKiemKe_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mAKK = String.Empty;
		private Decimal _sTT = 0;
		private String _maTBC = String.Empty;
		private Decimal _sOLUONG = 0;
		private Decimal _donGia = 0;
		private Decimal _sLSUACHUA = 0;
		private Decimal _sLBAODUONG = 0;
		private Decimal _sLXINTHANHLY = 0;
		private Decimal _sLSUACHUADC = 0;
		private Decimal _sLBAODUONGDC = 0;
		private Decimal _sLXINTHANHLYDC = 0;
		private Decimal _sLDC = 0;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenTB = String.Empty;
        private String _serialNo = String.Empty;
        private String _model = String.Empty;
        private int _sudungDN = 0;
        private String _tenNguoiSD = String.Empty;
        private SmartDate _NgayBaoDuong = new SmartDate(true);
		private int _namSanxuat = 0;
        private String _congSuatTK = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

		public int NAMSX
		{
			get
			{
				CanReadProperty("NAMSX", true);
				return _namSanxuat;
			}
			set
			{
				CanWriteProperty("NAMSX", true);
				if (_namSanxuat != value)
				{
					_namSanxuat = value;
					PropertyHasChanged("NAMSX");
				}
			}
		}

        public string NgayBaoDuong
        {
            get
            {
                CanReadProperty("NgayBaoDuong", true);
                return _NgayBaoDuong.Text;
            }
            set
            {
                CanWriteProperty("NgayBaoDuong", true);
                if (_NgayBaoDuong.Text != value)
                {
                    _NgayBaoDuong.Text = value;
                    PropertyHasChanged("NgayBaoDuong");
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
		public String MAKK
		{
			get 
			{
				CanReadProperty("MAKK", true);
				return _mAKK;
			}
			set 
			{
				CanWriteProperty("MAKK", true);
				if (_mAKK != value) 
				{
					_mAKK = value;
					PropertyHasChanged("MAKK");
				}
			}
		}
		
		public Decimal STT
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
        public int SuDungDN
        {
            get
            {
                CanReadProperty("SuDungDN", true);
                return _sudungDN;
            }
            set
            {
                CanWriteProperty("SuDungDN", true);
                if (_sudungDN != value)
                {
                    _sudungDN = value;
                    PropertyHasChanged("SuDungDN");
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
		
        //public Decimal SOLUONG
        //{
        //    get 
        //    {
        //        CanReadProperty("SOLUONG", true);
        //        return _sOLUONG;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SOLUONG", true);
        //        if (_sOLUONG != value) 
        //        {
        //            _sOLUONG = value;
        //            PropertyHasChanged("SOLUONG");
        //        }
        //    }
        //}
        public string SOLUONG
        {
            get
            {
                CanReadProperty("SOLUONG", true);
                if (_sOLUONG == 0)
                {
                    return "0";
                }
                else
                {
                    return _sOLUONG.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SOLUONG", true);
                if (_sOLUONG.ToString() == "" || value == null)
                {
                    _sOLUONG = 0;
                    PropertyHasChanged("SOLUONG");
                }
                else if (_sOLUONG.ToString() != value)
                {
                    _sOLUONG = decimal.Parse(value);
                    PropertyHasChanged("SOLUONG");
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
		
		
        //public Decimal SLSUACHUA
        //{
        //    get 
        //    {
        //        CanReadProperty("SLSUACHUA", true);
        //        return _sLSUACHUA;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLSUACHUA", true);
        //        if (_sLSUACHUA != value) 
        //        {
        //            _sLSUACHUA = value;
        //            PropertyHasChanged("SLSUACHUA");
        //        }
        //    }
        //}
        public string SLSUACHUA
        {
            get
            {
                CanReadProperty("SLSUACHUA", true);
                if (_sLSUACHUA == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLSUACHUA.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLSUACHUA", true);

                if (_sLSUACHUA.ToString() != value)
                {
                    _sLSUACHUA = decimal.Parse(value);
                    PropertyHasChanged("SLSUACHUA");
                }
            }
        }
        //public Decimal SLBAODUONG
        //{
        //    get 
        //    {
        //        CanReadProperty("SLBAODUONG", true);
        //        return _sLBAODUONG;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLBAODUONG", true);
        //        if (_sLBAODUONG != value) 
        //        {
        //            _sLBAODUONG = value;
        //            PropertyHasChanged("SLBAODUONG");
        //        }
        //    }
        //}
        public string SLBAODUONG
        {
            get
            {
                CanReadProperty("SLBAODUONG", true);
                if (_sLBAODUONG == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLBAODUONG.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLBAODUONG", true);

                if (_sLBAODUONG.ToString() != value)
                {
                    _sLBAODUONG = decimal.Parse(value);
                    PropertyHasChanged("SLBAODUONG");
                }
            }
        }
		
        //public Decimal SLXINTHANHLY
        //{
        //    get 
        //    {
        //        CanReadProperty("SLXINTHANHLY", true);
        //        return _sLXINTHANHLY;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLXINTHANHLY", true);
        //        if (_sLXINTHANHLY != value) 
        //        {
        //            _sLXINTHANHLY = value;
        //            PropertyHasChanged("SLXINTHANHLY");
        //        }
        //    }
        //}
        public string SLXINTHANHLY
        {
            get
            {
                CanReadProperty("SLXINTHANHLY", true);
                if (_sLXINTHANHLY == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLXINTHANHLY.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLXINTHANHLY", true);

                if (_sLXINTHANHLY.ToString() != value)
                {
                    _sLXINTHANHLY = decimal.Parse(value);
                    PropertyHasChanged("SLXINTHANHLY");
                }
            }
        }
		
        //public Decimal SLSUACHUADC
        //{
        //    get 
        //    {
        //        CanReadProperty("SLSUACHUADC", true);
        //        return _sLSUACHUADC;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLSUACHUADC", true);
        //        if (_sLSUACHUADC != value) 
        //        {
        //            _sLSUACHUADC = value;
        //            PropertyHasChanged("SLSUACHUADC");
        //        }
        //    }
        //}
        public string SLSUACHUADC
        {
            get
            {
                CanReadProperty("SLSUACHUADC", true);
                if (_sLSUACHUADC == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLSUACHUADC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLSUACHUADC", true);

                if (_sLSUACHUADC.ToString() != value)
                {
                    _sLSUACHUADC = decimal.Parse(value);
                    PropertyHasChanged("SLSUACHUADC");
                }
            }
        }
		
        //public Decimal SLBAODUONGDC
        //{
        //    get 
        //    {
        //        CanReadProperty("SLBAODUONGDC", true);
        //        return _sLBAODUONGDC;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLBAODUONGDC", true);
        //        if (_sLBAODUONGDC != value) 
        //        {
        //            _sLBAODUONGDC = value;
        //            PropertyHasChanged("SLBAODUONGDC");
        //        }
        //    }
        //}
        public string SLBAODUONGDC
        {
            get
            {
                CanReadProperty("SLBAODUONGDC", true);
                if (_sLBAODUONGDC == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLBAODUONGDC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLBAODUONGDC", true);

                if (_sLBAODUONGDC.ToString() != value)
                {
                    _sLBAODUONGDC = decimal.Parse(value);
                    PropertyHasChanged("SLBAODUONGDC");
                }
            }
        }
		
        //public Decimal SLXINTHANHLYDC
        //{
        //    get 
        //    {
        //        CanReadProperty("SLXINTHANHLYDC", true);
        //        return _sLXINTHANHLYDC;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLXINTHANHLYDC", true);
        //        if (_sLXINTHANHLYDC != value) 
        //        {
        //            _sLXINTHANHLYDC = value;
        //            PropertyHasChanged("SLXINTHANHLYDC");
        //        }
        //    }
        //}
        public string SLXINTHANHLYDC
        {
            get
            {
                CanReadProperty("SLXINTHANHLYDC", true);
                if (_sLXINTHANHLYDC == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLXINTHANHLYDC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLXINTHANHLYDC", true);

                if (_sLXINTHANHLYDC.ToString() != value)
                {
                    _sLXINTHANHLYDC = decimal.Parse(value);
                    PropertyHasChanged("SLXINTHANHLYDC");
                }
            }
        }
		
        //public Decimal SLDC
        //{
        //    get 
        //    {
        //        CanReadProperty("SLDC", true);
        //        return _sLDC;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLDC", true);
        //        if (_sLDC != value) 
        //        {
        //            _sLDC = value;
        //            PropertyHasChanged("SLDC");
        //        }
        //    }
        //}
        public string SLDC
        {
            get
            {
                CanReadProperty("SLDC", true);
                if (_sLDC == 0)
                {
                    return "0";
                }
                else
                {
                    return _sLDC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLDC", true);

                if (_sLDC.ToString() != value)
                {
                    _sLDC = decimal.Parse(value);
                    PropertyHasChanged("SLDC");
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
        TBLinhKien_C_List _TBLinhkien_Cs = TBLinhKien_C_List.NewTBLinhKien_C_List ();

        public TBLinhKien_C_List TBLinhkien_Cs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _TBLinhkien_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TBLinhkien_Cs.Equals(value))
                {
                    _TBLinhkien_Cs = value;
                    PropertyHasChanged();
                }
            }
        }


        protected override Object GetIdValue()
        {
            return _mAKK.ToString() + "!" + _maTBC.ToString();
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _TBLinhkien_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _TBLinhkien_Cs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBKiemKe_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBKiemKe_C NewTBKiemKe_C()
        {
            return new TBKiemKe_C();

        }
        public static TBKiemKe_C NewTBKiemKe_C(string idDMTB)
        {
            return new TBKiemKe_C(DMTBYT.GetDMTBYT(idDMTB));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static TBKiemKe_C NewTBKiemKe_C(DMTBYT _DMTBYT)
        {
            return new TBKiemKe_C(_DMTBYT);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
		public static TBKiemKe_C GetTBKiemKe_C(String mAKK, Decimal sTT)
		{
			return DataPortal.Fetch<TBKiemKe_C>(new Criteria(mAKK, sTT));
		}
        public static TBKiemKe_C GetTBKiemKe_C(SafeDataReader dr)
        {
            return new TBKiemKe_C(dr);
        }
        public static TBKiemKe_C GetTBKiemKe_C(int i, SafeDataReader dr)
        {
            return new TBKiemKe_C(i, dr);
        }
      

		/// <summary>
		/// Marks the <see cref="TBKiemKe_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBKiemKe_C(String mAKK, Decimal sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,mAKK, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBKiemKe_C()
		{	
			// Prevent direct creation
		}
		protected TBKiemKe_C(DMTBYT pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maTBC = pro.MaTB;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            _tenTB = pro.TenTB;            
            //MarkOld();
        }
        protected TBKiemKe_C(string _idMaKK, DMTBYT pro)
        {
            MarkAsChild();
            _mAKK = _idMaKK;
            _maTBC = pro.MaTB;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected TBKiemKe_C(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            if (dr.GetString("MAKK") != null) _mAKK = dr.GetString("MAKK");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("SOLUONG") != null) _sOLUONG = dr.GetDecimal("SOLUONG");
            if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
            if (dr.GetDecimal("SLSUACHUA") != null) _sLSUACHUA = dr.GetDecimal("SLSUACHUA");
            if (dr.GetDecimal("SLBAODUONG") != null) _sLBAODUONG = dr.GetDecimal("SLBAODUONG");
            if (dr.GetDecimal("SLXINTHANHLY") != null) _sLXINTHANHLY = dr.GetDecimal("SLXINTHANHLY");
            if (dr.GetDecimal("SLSUACHUADC") != null) _sLSUACHUADC = dr.GetDecimal("SLSUACHUADC");
            if (dr.GetDecimal("SLBAODUONGDC") != null) _sLBAODUONGDC = dr.GetDecimal("SLBAODUONGDC");
            if (dr.GetDecimal("SLXINTHANHLYDC") != null) _sLXINTHANHLYDC = dr.GetDecimal("SLXINTHANHLYDC");
            if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");                     
           _tenDVT = dr.GetString("TENDVT");
           _tenTB = dr.GetString("tenTB");
           _sudungDN = dr.GetInt32("SuDungDN");
		   if (dr.GetInt32("NAMSX") != null) _namSanxuat = dr.GetInt32("NAMSX");
           if (dr.GetSmartDate("ngaybaoduong", true) != null) _NgayBaoDuong = dr.GetSmartDate("ngaybaoduong", true);
           if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
           if (dr.GetString("Model") != null) _model = dr.GetString("Model");
           if (dr.GetString("tennguoisd") != null) _tenNguoiSD = dr.GetString("tennguoisd");
            MarkOld();
        }

        protected TBKiemKe_C(int i, SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _sTT = i;
            if (dr.GetString("MAKK") != null) _mAKK = dr.GetString("MAKK");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("SOLUONG") != null) _sOLUONG = dr.GetDecimal("SOLUONG");
            if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
            if (dr.GetDecimal("SLSUACHUA") != null) _sLSUACHUA = dr.GetDecimal("SLSUACHUA");
            if (dr.GetDecimal("SLBAODUONG") != null) _sLBAODUONG = dr.GetDecimal("SLBAODUONG");
            if (dr.GetDecimal("SLXINTHANHLY") != null) _sLXINTHANHLY = dr.GetDecimal("SLXINTHANHLY");
            if (dr.GetDecimal("SLSUACHUADC") != null) _sLSUACHUADC = dr.GetDecimal("SLSUACHUADC");
            if (dr.GetDecimal("SLBAODUONGDC") != null) _sLBAODUONGDC = dr.GetDecimal("SLBAODUONGDC");
            if (dr.GetDecimal("SLXINTHANHLYDC") != null) _sLXINTHANHLYDC = dr.GetDecimal("SLXINTHANHLYDC");
            if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetSmartDate("ngaybaoduong", true) != null) _NgayBaoDuong = dr.GetSmartDate("ngaybaoduong", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _tenDVT = dr.GetString("TENDVT");
            _tenTB = dr.GetString("tenTB");
            _sudungDN = dr.GetInt32("SuDungDN");
			if (dr.GetSmartDate("NAMSX") != null) _namSanxuat = DateTime.Parse(dr.GetSmartDate("NAMSX").DBValue.ToString()).Year;
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            try
            {
                if (dr.GetString("CongSuatTK") != null) _congSuatTK = dr.GetString("CongSuatTK");
            }
            catch (Exception)
            { }
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            if (dr.GetString("tennguoisd") != null) _tenNguoiSD = dr.GetString("tennguoisd");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _mAKK;
			public String MAKK 
			{
				get
				{
					return _mAKK;
				}
			}
			
			private Decimal _sTT;
			public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String mAKK, Decimal sTT)
			{
				_mAKK = mAKK;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_mAKK.Equals(c._mAKK)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _mAKK.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _mAKK;
            public String MAKK
            {
                get
                {
                    return _mAKK;
                }
            }

            private decimal _STT;
            public decimal STT
            {
                get
                {
                    return _STT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maKK, decimal stt)
            {
                _mAKK = maKK;
                _STT = stt;
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
		/// Retrieve an existing <see cref="TBKiemKe_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBKiemKe_C(crit.MAKK, crit.STT)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _TBLinhkien_Cs = TBLinhKien_C_List.GetTBLinhKien_C_List (dr);//////////////
                    }
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }

            
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBKiemKe_C(crit.MAKK, crit.STT)))
            //{
            //    if (dr.Read()){
            //        Fetch(dr);
            //        MarkOld();
            //        ValidationRules.CheckRules();
            //    }
            //}
		}
		/// <summary>
		/// Load a <see cref="TBKiemKe_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MAKK") != null) _mAKK = dr.GetString("MAKK");
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
			if (dr.GetDecimal("SOLUONG") != null) _sOLUONG = dr.GetDecimal("SOLUONG");
			if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
			if (dr.GetDecimal("SLSUACHUA") != null) _sLSUACHUA = dr.GetDecimal("SLSUACHUA");
			if (dr.GetDecimal("SLBAODUONG") != null) _sLBAODUONG = dr.GetDecimal("SLBAODUONG");
			if (dr.GetDecimal("SLXINTHANHLY") != null) _sLXINTHANHLY = dr.GetDecimal("SLXINTHANHLY");
			if (dr.GetDecimal("SLSUACHUADC") != null) _sLSUACHUADC = dr.GetDecimal("SLSUACHUADC");
			if (dr.GetDecimal("SLBAODUONGDC") != null) _sLBAODUONGDC = dr.GetDecimal("SLBAODUONGDC");
			if (dr.GetDecimal("SLXINTHANHLYDC") != null) _sLXINTHANHLYDC = dr.GetDecimal("SLXINTHANHLYDC");
			if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("ngaybaoduong", true) != null) _NgayBaoDuong = dr.GetSmartDate("ngaybaoduong", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _tenDVT = dr.GetString("TENDVT");
            _tenTB = dr.GetString("TenTB");
            _sudungDN = dr.GetInt32("SuDungDN");
			if (dr.GetSmartDate("NAMSX") != null) _namSanxuat = DateTime.Parse(dr.GetSmartDate("NAMSX").DBValue.ToString()).Year;
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            if (dr.GetString("tennguoisd") != null) _tenNguoiSD = dr.GetString("tennguoisd");
		}
		
		/// <summary>
		/// Insert the new <see cref="TBKiemKe_C" /> Object to underlying database.
		/// </summary>
        /// 
        private void Fetch(int i, SafeDataReader dr)
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MAKK") != null) _mAKK = dr.GetString("MAKK");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("SOLUONG") != null) _sOLUONG = dr.GetDecimal("SOLUONG");
            if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
            if (dr.GetDecimal("SLSUACHUA") != null) _sLSUACHUA = dr.GetDecimal("SLSUACHUA");
            if (dr.GetDecimal("SLBAODUONG") != null) _sLBAODUONG = dr.GetDecimal("SLBAODUONG");
            if (dr.GetDecimal("SLXINTHANHLY") != null) _sLXINTHANHLY = dr.GetDecimal("SLXINTHANHLY");
            if (dr.GetDecimal("SLSUACHUADC") != null) _sLSUACHUADC = dr.GetDecimal("SLSUACHUADC");
            if (dr.GetDecimal("SLBAODUONGDC") != null) _sLBAODUONGDC = dr.GetDecimal("SLBAODUONGDC");
            if (dr.GetDecimal("SLXINTHANHLYDC") != null) _sLXINTHANHLYDC = dr.GetDecimal("SLXINTHANHLYDC");
            if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("ngaybaoduong", true) != null) _NgayBaoDuong = dr.GetSmartDate("ngaybaoduong", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _tenDVT = dr.GetString("TENDVT");
            _tenTB = dr.GetString("TenTB");
            _sudungDN = dr.GetInt32("SuDungDN");
			if (dr.GetSmartDate("NAMSX") != null) _namSanxuat = DateTime.Parse(dr.GetSmartDate("NAMSX").DBValue.ToString()).Year;
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            if (dr.GetString("tennguoisd") != null) _tenNguoiSD = dr.GetString("tennguoisd");
        }
        internal virtual void Insert(TBKiemKe bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _mAKK = bill.MaKK;
            _maTBC = DataProvider.Instance().InsertTBKiemKe_C(bill.MaKK, _maTBC, _sOLUONG, _donGia, _sLSUACHUA, _sLBAODUONG, _sLXINTHANHLY, _sLSUACHUADC, _sLBAODUONGDC, _sLXINTHANHLYDC, _sLDC, _ghichu, this._sOLUONG, _nguoiSD , _maMay, _sudungDN, _serialNo, _model, _NgayBaoDuong, _namSanxuat);
            MarkOld();
            _TBLinhkien_Cs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBKiemKe_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(TBKiemKe bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateTBKiemKe_C(bill.MaKK, _sTT, _maTBC, _sOLUONG, _donGia, _sLSUACHUA, _sLBAODUONG, _sLXINTHANHLY, _sLSUACHUADC, _sLBAODUONGDC, _sLXINTHANHLYDC, _sLDC, _ghichu, _huy, _nguoiSD , _maMay, _sudungDN, _serialNo, _model, _NgayBaoDuong,_namSanxuat);
                _TBLinhkien_Cs.Update(this);				
			}
		}
      
        internal void DeleteSelf(TBKiemKe bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            

              

            DataProvider.Instance().DeleteTBKiemKe_C(_maMay, _nguoiSD , bill.MaKK, _sTT);
            MarkNew();
        }
		#endregion
	}

}
