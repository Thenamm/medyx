// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThamSo
// Kieu doi tuong  :	ThamSo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 10:27:03 AM
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
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThamSo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThamSo : BusinessBase<ThamSo>
	{
		#region Business Methods
		
		#region State Fields

        private String _tenBV = String.Empty;
        private String _SoHDBH = String.Empty;
        private String _SoHDTT = String.Empty;
        private String _SoHDSacBH = String.Empty;
        private String _SoHDSacTT = String.Empty;
        private String _tenBVTA = String.Empty;
        private String _tenBVViettat = String.Empty;
        private String _diaChi = String.Empty;
        private String _tel = String.Empty;
        private String _email = String.Empty;
        private String _webSite = String.Empty;
        private String _diaChiTA = String.Empty;
		private String _chiCucThue = String.Empty;
        private String _maSoThue = String.Empty;
        private String _taiKhoan = String.Empty;
        private decimal _tyGia = 0;
        private decimal _GiaSacPKBH = 0;
        private decimal _GiaSacPKTT = 0;
        private decimal _GiaSacNTBH = 0;
        private decimal _GiaSacNTTT = 0;
        private decimal _MucLuongCoBan = 0;
        private String _maMay = String.Empty;
        private String _ngayQT1 = String.Empty;
        private String _ngayQT2 = String.Empty;
        private String _ngayQT3 = String.Empty;
        private String _ngayQT4 = String.Empty;
        private SmartDate _ngayLV = new SmartDate(DateTime.Now );
        private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngayXulyThuoc = new SmartDate(true);
        private SmartDate _ngayXulyHC = new SmartDate(true);
        private SmartDate _ngayXulyVT = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _daidien = String.Empty;
        private String _tenpk1 = String.Empty;
        private String _diadiem1 = String.Empty;
        private String _dienthoai1 = String.Empty;
        private String _tenpk2 = String.Empty;
        private String _diadiem2 = String.Empty;
        private String _dienthoai2 = String.Empty;
        private String _thumucluuanh = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public String thumucluuanh
        {
            get
            {
                CanReadProperty("thumucluuanh", true);
                return _thumucluuanh;
            }
            set
            {
                CanWriteProperty("thumucluuanh", true);
                if (_thumucluuanh != value)
                {
                    _thumucluuanh = value;
                    PropertyHasChanged("thumucluuanh");
                }
            }
        }
        public String tenpk1
        {
            get
            {
                CanReadProperty("tenpk1", true);
                return _tenpk1;
            }
            set
            {
                CanWriteProperty("tenpk1", true);
                if (_tenpk1 != value)
                {
                    _tenpk1 = value;
                    PropertyHasChanged("tenpk1");
                }
            }
        }
        public String diadiem1
        {
            get
            {
                CanReadProperty("diadiem1", true);
                return _diadiem1;
            }
            set
            {
                CanWriteProperty("diadiem1", true);
                if (_diadiem1 != value)
                {
                    _diadiem1 = value;
                    PropertyHasChanged("diadiem1");
                }
            }
        }
        public String dienthoai1
        {
            get
            {
                CanReadProperty("dienthoai1", true);
                return _dienthoai1;
            }
            set
            {
                CanWriteProperty("dienthoai1", true);
                if (_dienthoai1 != value)
                {
                    _dienthoai1 = value;
                    PropertyHasChanged("dienthoai1");
                }
            }
        }

        public String tenpk2
        {
            get
            {
                CanReadProperty("tenpk2", true);
                return _tenpk2;
            }
            set
            {
                CanWriteProperty("tenpk2", true);
                if (_tenpk2 != value)
                {
                    _tenpk2 = value;
                    PropertyHasChanged("tenpk2");
                }
            }
        }
        public String diadiem2
        {
            get
            {
                CanReadProperty("diadiem2", true);
                return _diadiem2;
            }
            set
            {
                CanWriteProperty("diadiem2", true);
                if (_diadiem2 != value)
                {
                    _diadiem2 = value;
                    PropertyHasChanged("diadiem2");
                }
            }
        }
        public String dienthoai2
        {
            get
            {
                CanReadProperty("dienthoai2", true);
                return _dienthoai2;
            }
            set
            {
                CanWriteProperty("dienthoai2", true);
                if (_dienthoai2 != value)
                {
                    _dienthoai2 = value;
                    PropertyHasChanged("dienthoai2");
                }
            }
        }
		public String TenBV
		{
			get 
			{
				CanReadProperty("TenBV", true);
				return _tenBV ;
			}
			set 
			{
				CanWriteProperty("TenBV", true);
				if (_tenBV  != value) 
				{
					_tenBV  = value;
					PropertyHasChanged("TenBV");
				}
			}
		}
        public String daidien
        {
            get
            {
                CanReadProperty("daidien", true);
                return _daidien;
            }
            set
            {
                CanWriteProperty("daidien", true);
                if (_daidien != value)
                {
                    _daidien = value;
                    PropertyHasChanged("daidien");
                }
            }
        }
        public String TenBVTA
        {
            get
            {
                CanReadProperty("TenBVTA", true);
                return _tenBVTA;
            }
            set
            {
                CanWriteProperty("TenBVTA", true);
                if (_tenBVTA != value)
                {
                    _tenBVTA = value;
                    PropertyHasChanged("TenBVTA");
                }
            }
        }
        public String TenBVVietTat
        {
            get
            {
                CanReadProperty("TenBVVietTat", true);
                return _tenBVViettat;
            }
            set
            {
                CanWriteProperty("TenBVVietTat", true);
                if (_tenBVViettat != value)
                {
                    _tenBVViettat = value;
                    PropertyHasChanged("TenBVVietTat");
                }
            }
        }
        public String DiaChi
        {
            get
            {
                CanReadProperty("DiaChi", true);
                return _diaChi ;
            }
            set
            {
                CanWriteProperty("DiaChi", true);
                if (_diaChi  != value)
                {
                    _diaChi  = value;
                    PropertyHasChanged("DiaChi");
                }
            }
        }
        public String Tel
        {
            get
            {
                CanReadProperty("Tell", true);
                return _tel;
            }
            set
            {
                CanWriteProperty("Tell", true);
                if (_tel != value)
                {
                    _tel = value;
                    PropertyHasChanged("Tell");
                }
            }
        }
        public String Email
        {
            get
            {
                CanReadProperty("Email", true);
                return _email;
            }
            set
            {
                CanWriteProperty("Email", true);
                if (_email != value)
                {
                    _email = value;
                    PropertyHasChanged("Email");
                }
            }
        }
        public String WebSite
        {
            get
            {
                CanReadProperty("WebSite", true);
                return _webSite;
            }
            set
            {
                CanWriteProperty("WebSite", true);
                if (_webSite != value)
                {
                    _webSite = value;
                    PropertyHasChanged("WebSite");
                }
            }
        }
        public String DiaChiTA
        {
            get
            {
                CanReadProperty("DiaChiTA", true);
                return _diaChiTA;
            }
            set
            {
                CanWriteProperty("DiaChiTA", true);
                if (_diaChiTA != value)
                {
                    _diaChiTA = value;
                    PropertyHasChanged("DiaChiTA");
                }
            }
        }
        public String ChiCucThue
        {
            get
            {
                CanReadProperty("ChiCucThue", true);
                return _chiCucThue;
            }
            set
            {
                CanWriteProperty("ChiCucThue", true);
                if (_chiCucThue != value)
                {
                    _chiCucThue = value;
                    PropertyHasChanged("ChiCucThue");
                }
            }
        }
        public String MaSoThue
        {
            get
            {
                CanReadProperty("MaSoThue", true);
                return _maSoThue;
            }
            set
            {
                CanWriteProperty("MaSoThue", true);
                if (_maSoThue != value)
                {
                    _maSoThue = value;
                    PropertyHasChanged("MaSoThue");
                }
            }
        }
        public String TaiKhoan
        {
            get
            {
                CanReadProperty("TaiKhoan", true);
                return _taiKhoan;
            }
            set
            {
                CanWriteProperty("TaiKhoan", true);
                if (_taiKhoan != value)
                {
                    _taiKhoan = value;
                    PropertyHasChanged("TaiKhoan");
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
        public String SoHDTT
        {
            get
            {
                CanReadProperty("SoHDTT", true);
                return _SoHDTT;
            }
            set
            {
                CanWriteProperty("SoHDTT", true);
                if (_SoHDTT != value)
                {
                    _SoHDTT = value;
                    PropertyHasChanged("SoHDTT");
                }
            }
        }
        public String SoHDBH
        {
            get
            {
                CanReadProperty("SoHDBH", true);
                return _SoHDBH;
            }
            set
            {
                CanWriteProperty("SoHDBH", true);
                if (_SoHDBH != value)
                {
                    _SoHDBH = value;
                    PropertyHasChanged("SoHDBH");
                }
            }
        }
        public String SoHDSacTT
        {
            get
            {
                CanReadProperty("SoHDSacTT", true);
                return _SoHDSacTT;
            }
            set
            {
                CanWriteProperty("SoHDSacTT", true);
                if (_SoHDSacTT != value)
                {
                    _SoHDSacTT = value;
                    PropertyHasChanged("SoHDSacTT");
                }
            }
        }
        public String SoHDSacBH
        {
            get
            {
                CanReadProperty("SoHDSacBH", true);
                return _SoHDSacBH;
            }
            set
            {
                CanWriteProperty("SoHDSacBH", true);
                if (_SoHDSacBH != value)
                {
                    _SoHDSacBH = value;
                    PropertyHasChanged("SoHDSacBH");
                }
            }
        }

        public String NgayQT1
        {
            get
            {
                CanReadProperty("NgayQT1", true);
                return _ngayQT1;
            }
            set
            {
                CanWriteProperty("NgayQT1", true);
                if (_ngayQT1 != value)
                {
                    _ngayQT1 = value;
                    PropertyHasChanged("NgayQT1");
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
        public String NgayQT2
        {
            get
            {
                CanReadProperty("NgayQT2", true);
                return _ngayQT2;
            }
            set
            {
                CanWriteProperty("NgayQT2", true);
                if (_ngayQT2 != value)
                {
                    _ngayQT2 = value;
                    PropertyHasChanged("NgayQT2");
                }
            }
        }
        public String NgayQT3
        {
            get
            {
                CanReadProperty("NgayQT3", true);
                return _ngayQT3;
            }
            set
            {
                CanWriteProperty("NgayQT3", true);
                if (_ngayQT3 != value)
                {
                    _ngayQT3 = value;
                    PropertyHasChanged("NgayQT3");
                }
            }
        }
        public string TyGia
        {
            get
            {
                CanReadProperty("TyGia", true);
                if (_tyGia == 0)
                {
                    return "";
                }
                else if (_tyGia- (int)(_tyGia )!=0 )
                    return _tyGia.ToString("###,##0.##");
                else 
                    return _tyGia.ToString("###,###,###");
               
            }
            set
            {
                CanWriteProperty("TyGia", true);

                if (_tyGia.ToString() != value)
                {
                    if (value == "")
                        _tyGia = 0;
                    else
                        _tyGia = Decimal.Parse(value);
                    PropertyHasChanged("TyGia");
                }
            }
        }
        public Decimal MucLuongCoBan
        {
            get
            {
                CanReadProperty("MucLuongCoBan", true);
                return _MucLuongCoBan;
            }
            set
            {
                CanWriteProperty("MucLuongCoBan", true);
                if (_MucLuongCoBan != value)
                {
                    _MucLuongCoBan = value;
                    PropertyHasChanged("MucLuongCoBan");
                }
            }
        }
        public Decimal GiaSacPKBH
        {
            get
            {
                CanReadProperty("GiaSacPKBH", true);
                return _GiaSacPKBH;
            }
            set
            {
                CanWriteProperty("GiaSacPKBH", true);
                if (_GiaSacPKBH != value)
                {
                    _GiaSacPKBH = value;
                    PropertyHasChanged("GiaSacPKBH");
                }
            }
        }
        public Decimal GiaSacPKTT
        {
            get
            {
                CanReadProperty("GiaSacPKTT", true);
                return _GiaSacPKTT;
            }
            set
            {
                CanWriteProperty("GiaSacPKTT", true);
                if (_GiaSacPKTT != value)
                {
                    _GiaSacPKTT = value;
                    PropertyHasChanged("GiaSacPKTT");
                }
            }
        }
        public Decimal GiaSacNTTT
        {
            get
            {
                CanReadProperty("GiaSacNTTT", true);
                return _GiaSacNTTT;
            }
            set
            {
                CanWriteProperty("GiaSacNTTT", true);
                if (_GiaSacNTTT != value)
                {
                    _GiaSacNTTT = value;
                    PropertyHasChanged("GiaSacNTTT");
                }
            }
        }
        public Decimal GiaSacNTBH
        {
            get
            {
                CanReadProperty("GiaSacNTBH", true);
                return _GiaSacNTBH;
            }
            set
            {
                CanWriteProperty("GiaSacNTBH", true);
                if (_GiaSacNTBH != value)
                {
                    _GiaSacNTBH = value;
                    PropertyHasChanged("GiaSacNTBH");
                }
            }
        }
        public String NgayQT4
        {
            get
            {
                CanReadProperty("NgayQT4", true);
                return _ngayQT4;
            }
            set
            {
                CanWriteProperty("NgayQT4", true);
                if (_ngayQT4 != value)
                {
                    _ngayQT4 = value;
                    PropertyHasChanged("NgayQT4");
                }
            }
        }
		public SmartDate NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_ngaySD != value) 
				{
					_ngaySD = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}

        public SmartDate NgayLV
        {
            get
            {
                CanReadProperty("NgayLV", true);
                _ngayLV.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayLV;
            }
            set
            {
                CanWriteProperty("NgayLV", true);
                if (_ngayLV != value)
                {
                    _ngayLV = value;
                    PropertyHasChanged("NgayLV");
                }
            }
        }
      
        public String NgayXulyVT
        {
            get
            {
                CanReadProperty("NgayXulyVT", true);
                _ngayXulyVT.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayXulyVT.Text;
            }
            set
            {
                CanWriteProperty("NgayXulyVT", true);
                if (_ngayXulyVT.Text != value)
                {
                    _ngayXulyVT.Text = value;
                    PropertyHasChanged("NgayXulyVT");
                }
            }
        }
        public String NgayXulyHC
        {
            get
            {
                CanReadProperty("NgayXulyHC", true);
                _ngayXulyHC.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayXulyHC.Text ;
            }
            set
            {
                CanWriteProperty("NgayXulyHC", true);
                if (_ngayXulyHC.Text  != value)
                {
                    _ngayXulyHC.Text  = value;
                    PropertyHasChanged("NgayXulyHC");
                }
            }
        }
        public String NgayXulyThuoc
        {
            get
            {
                CanReadProperty("NgayXulyThuoc", true);
               
                return _ngayXulyThuoc.Text ;
            }
            set
            {
                CanWriteProperty("NgayXulyThuoc", true);
                if (_ngayXulyThuoc.Text  != value)
                {
                    _ngayXulyThuoc.Text  = value;
                    PropertyHasChanged("NgayXulyThuoc");
                }
            }
        }
        //public int OrderNumber
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        CanReadProperty(true);
        //        return _OrderNumber;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_OrderNumber.Equals(value))
        //        {
        //            _OrderNumber = value;
        //            //PropertyHasChanged();
        //        }
        //    }
        //}
        //public String tenta
        //{
        //    get
        //    {
        //        CanReadProperty("tenta", true);
        //        return _tenta;
        //    }
        //    set
        //    {
        //        CanWriteProperty("tenta", true);
        //        if (_tenta != value)
        //        {
        //            _tenta = value;
        //            PropertyHasChanged("tenta");
        //        }
        //    }
        //}
        //public String hoten
        //{
        //    get
        //    {
        //        CanReadProperty("hoten", true);
        //        return _hoten;
        //    }
        //    set
        //    {
        //        CanWriteProperty("hoten", true);
        //        if (_hoten != value)
        //        {
        //            _hoten = value;
        //            PropertyHasChanged("hoten");
        //        }
        //    }
        //}
        protected override Object GetIdValue()
        {
            return _tenBV ;
        }
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
       
       
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThamSo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static ThamSo NewThamSo()
        {
            return DataPortal.Create<ThamSo>();
            //return new ThamSo();
        }
        //public static ThamSo NewThamSo( )
        //{
        //    //return new DMNhom(idparent);
        //    return DataPortal.Create<ThamSo>();
        //}
		public static ThamSo GetThamSo()
		{
			return DataPortal.Fetch<ThamSo>();
		}
		
		/// <summary>
		/// Marks the <see cref="ThamSo" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThamSo()
		{	
			// Prevent direct creation
            if (_ngayLV== null)
            _ngayLV = new SmartDate(DateTime.Now);
		}
        //internal ThamSo(int ordernumber, string MaQG, string TenQG, Byte loai, Byte cap, Decimal sogiuong, string machuyenkhoa, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string idparent, string tenta, string hoten, Boolean chon, string diadiem, string ghichu, Boolean khonghd)
        //{
        //    _OrderNumber = ordernumber;
        //    _maKhoa = MaQG;
        //    _tenKhoa = TenQG;
        //    _loai = loai;
        //    _cap = cap;
        //    _sogiuong = sogiuong;
        //    _maMay = idmay;
        //    _huy = huy;
        //    _ngaySD = ngaySD;
        //    _nguoiSD = NguoiSD;
        //    _tenta = tenta;
        //    _hoten = hoten;
        //    _diadiem = diadiem;
        //    _ghichu = ghichu;
        //    _KhongHD = khonghd;

        //}
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private String _tenBV;
			public String TenBV 
			{
				get
				{
					return _tenBV;
				}
			}
			
			public Criteria()
			{
               			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_tenBV.Equals(c._tenBV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria").GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _tenBV;
            public String TenBV
            {
                get
                {
                    return _tenBV;
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

           
            public OtherCriteria(String Mamay, String tenBV)
            {
                _tenBV = tenBV ;
                _maMay = Mamay;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
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
		/// Retrieve an existing <see cref="ThamSo" /> Object based on data in the database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected void DataPortal_Create(Criteria param)
        {
            //_idparent = param.MaKhoa ;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
        protected void DataPortal_Fetch()
        {
            // public abstract IDataReader GetThamSo(String _maKhoa);
            // public override IDataReader GetThamSo(String _maKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThamSo()))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="ThamSo" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("thumucluuanh") != null) _thumucluuanh = dr.GetString("thumucluuanh");
           
            if (dr.GetString("tenpk1") != null) _tenpk1 = dr.GetString("tenpk1");
            if (dr.GetString("diadiem1") != null) _diadiem1 = dr.GetString("diadiem1");
            if (dr.GetString("dienthoai1") != null) _dienthoai1 = dr.GetString("dienthoai1");

            if (dr.GetString("tenpk2") != null) _tenpk2 = dr.GetString("tenpk2");
            if (dr.GetString("diadiem2") != null) _diadiem2 = dr.GetString("diadiem2");
            if (dr.GetString("dienthoai2") != null) _dienthoai2 = dr.GetString("dienthoai2");
            if (dr.GetString("dienthoai2") != null) _dienthoai2 = dr.GetString("dienthoai2");


            if (dr.GetString("TenBV") != null) _tenBV = dr.GetString("TenBV");
            if (dr.GetString("daidien") != null) _daidien = dr.GetString("daidien");
            if (dr.GetString("TenBVTA") != null) _tenBVTA = dr.GetString("TenBVTA");
            if (dr.GetString("TenBVViettat") != null) _tenBVViettat = dr.GetString("TenBVViettat");
            if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
            if (dr.GetString("Tel") != null) _tel = dr.GetString("Tel");
            if (dr.GetString("Email") != null) _email = dr.GetString("Email");
            if (dr.GetString("WebSite") != null) _webSite = dr.GetString("WebSite");
            if (dr.GetString("DiaChiTA") != null) _diaChiTA = dr.GetString("DiaChiTA");
            if (dr.GetString("chiCucThue") != null) _chiCucThue = dr.GetString("chiCucThue");
            if (dr.GetString("MaSoThue") != null) _maSoThue = dr.GetString("MaSoThue");
            if (dr.GetString("TaiKhoan") != null) _taiKhoan = dr.GetString("TaiKhoan");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("SoHDSacTT") != null) _SoHDSacTT = dr.GetString("SoHDSacTT");
            if (dr.GetString("SoHDSacBH") != null) _SoHDSacBH = dr.GetString("SoHDSacBH");
            if (dr.GetString("SoHDTT") != null) _SoHDTT = dr.GetString("SoHDTT");
            if (dr.GetString("SoHDBH") != null) _SoHDBH = dr.GetString("SoHDBH");
            if (dr.GetString("NgayQT1") != null) _ngayQT1 = dr.GetString("NgayQT1");
            if (dr.GetString("NgayQT2") != null) _ngayQT2 = dr.GetString("NgayQT2");
            if (dr.GetString("NgayQT3") != null) _ngayQT3 = dr.GetString("NgayQT3");
            if (dr.GetString("NgayQT4") != null) _ngayQT4 = dr.GetString("NgayQT4");
            //if (dr.GetDecimal("GiaSacPKBH") != null) _GiaSacPKBH = dr.GetDecimal("GiaSacPKBH");
            //if (dr.GetDecimal("GiaSacPKTT") != null) _GiaSacPKTT = dr.GetDecimal("GiaSacPKTT");
            //if (dr.GetDecimal("GiaSacNTBH") != null) _GiaSacNTBH = dr.GetDecimal("GiaSacNTBH");
            //if (dr.GetDecimal("GiaSacNTTT") != null) _GiaSacNTTT = dr.GetDecimal("GiaSacNTTT");
            if (dr.GetSmartDate("NgayLV") != null) _ngayLV = dr.GetSmartDate("NgayLV");
            if (dr.GetSmartDate("NgayXulyVT") != null) _ngayXulyVT = dr.GetSmartDate("NgayXulyVT");
            if (dr.GetSmartDate("NgayXulyHC") != null) _ngayXulyHC = dr.GetSmartDate("NgayXulyHC");
            if (dr.GetSmartDate("NgayXulyThuoc") != null) _ngayXulyThuoc = dr.GetSmartDate("NgayXulyThuoc");
            if (_ngayLV == null)
                _ngayLV = new SmartDate(DateTime.Now);
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetDecimal("MucLuongCoBan") != null) _MucLuongCoBan = dr.GetDecimal("MucLuongCoBan");
		}
		
		/// <summary>
		/// Insert the new <see cref="ThamSo" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThamSo
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().InsertThamSo(_tenBV, _tenBVTA, _tenBVViettat, _diaChi, _diaChiTA, _tel, _email, _webSite, _chiCucThue, _maSoThue, _taiKhoan, _tyGia, _maMay, _ngayQT1, _ngayQT2, _ngayQT3, _ngayQT4, _nguoiSD,_ngayXulyThuoc ,_ngayXulyHC ,_ngayXulyVT  );
           // _maKhoa = DataProvider.Instance().InsertThamSo(_tenBV, _tenBVTA,_tenBVViettat, _diaChi , _diaChiTA,_tel,_email,_webSite,_chiCucThue,_maSoThue,_taiKhoan,_tyGia, _maMay,  _ngayQT1, _ngayQT2,  _ngayQT3, _ngayQT4);
         // public abstract String InsertThamSo(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertThamSo(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa, _tenKhoa, _loai, _cap, _sogiuong, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="ThamSo" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThamSo
			if (IsDirty){
                
                 
               DataProvider.Instance().UpdateThamSo(_tenBV, _tenBVTA, _tenBVViettat, _diaChi, _diaChiTA, _tel, _email, _webSite, _chiCucThue, _maSoThue, _taiKhoan, _tyGia, _maMay, _ngayQT1, _ngayQT2, _ngayQT3, _ngayQT4, _nguoiSD, _ngayXulyThuoc, _ngayXulyHC, _ngayXulyVT);
				// public abstract void UpdateThamSo(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateThamSo(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// //{
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa, _tenKhoa, _loai, _cap, _sogiuong, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _tenBV ));
		}

		/// <summary>
		/// Delete the <see cref="ThamSo" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThamSo
            //DataProvider.Instance().DeleteThamSo(crit.MaMay, crit.NguoiSD, crit.MaKhoa);
			// public abstract void DeleteThamSo(String _maKhoa);
			// public override void DeleteThamSo(String _maKhoa);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa);
			// }
		}

		#endregion
	}

}
