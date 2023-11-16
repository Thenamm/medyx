// *****************************************************************************************************
//  File nay VPPYT sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	VTXuatTra
// Kieu doi tuong  :	VTXuatTra
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/11/2009 2:31:43 PM
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
namespace HTC.Business.VPP
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="VPPXuatTra" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class VPPXuatTra : BusinessBase<VPPXuatTra>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPXT = String.Empty;
		private String _maNCC = String.Empty;
		private String _soCT = String.Empty;
		private SmartDate _ngayXT = new SmartDate(true);
		private String _makho = String.Empty;
		private Decimal _tLCK = 0;
		private Boolean _thanhtoan = false;
		private SmartDate _ngayTToan = new SmartDate(true);
		private SmartDate _ngayXuatTT = new SmartDate(true);
        private SmartDate _ngayXuatTTD = new SmartDate(true);
		private String _nVNhap = String.Empty;
		private Decimal _tong = 0;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _maMay = String.Empty;
		private String _nguoihuy = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nVXuat = String.Empty;
		private String _nVNhan = String.Empty;
		private Decimal _vAT = 0;
        private String _tenNCC = String.Empty;
        private String _tenKho = String.Empty;
        private String _tenNVXuat = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _soHoaDon = String.Empty;
        private SmartDate _ngayHoaDon = new SmartDate("", true);
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaPXT
		{
			get 
			{
				CanReadProperty("MaPXT", true);
				return _maPXT;
			}
			set 
			{
				CanWriteProperty("MaPXT", true);
				if (_maPXT != value) 
				{
					_maPXT = value;
					PropertyHasChanged("MaPXT");
				}
			}
		}
		
		public String MaNCC
		{
			get 
			{
				CanReadProperty("MaNCC", true);
				return _maNCC;
			}
			set 
			{
				CanWriteProperty("MaNCC", true);
				if (_maNCC != value) 
				{
					_maNCC = value;
					PropertyHasChanged("MaNCC");
				}
			}
		}
		
		public String SoCT
		{
			get 
			{
				CanReadProperty("SoCT", true);
				return _soCT;
			}
			set 
			{
				CanWriteProperty("SoCT", true);
				if (_soCT != value) 
				{
					_soCT = value;
					PropertyHasChanged("SoCT");
				}
			}
		}
        public String SoHDon
        {
            get
            {
                CanReadProperty("SoHDon", true);
                return _soHoaDon;
            }
            set
            {
                CanWriteProperty("SoHDon", true);
                if (_soHoaDon != value)
                {
                    _soHoaDon = value;
                    PropertyHasChanged("SoHDon");
                }
            }
        }
        public String ngayHoaDon
        {
            get
            {
                CanReadProperty("ngayHoaDon", true);
                // _ngayPhieuNhap.FormatString = "MM/dd/yyyy"; 
                return _ngayHoaDon.Text;
            }
            set
            {
                CanWriteProperty("ngayHoaDon", true);
                //if (_ngayPhieuNhap != value)
                if (!_ngayHoaDon.Equals(value))
                {
                    //  _ngayPhieuNhap.FormatString = "MM/dd/yyyy"; 
                    _ngayHoaDon.Text = value;
                    PropertyHasChanged("ngayHoaDon");
                }
            }
        }
		
		public string NgayXT
		{
			get 
			{
				CanReadProperty("NgayXT", true);
				return _ngayXT.Text;
			}
			set 
			{
				CanWriteProperty("NgayXT", true);
				if (_ngayXT.Text != value) 
				{
					_ngayXT.Text = value;
					PropertyHasChanged("NgayXT");
				}
			}
		}
		
		public String Makho
		{
			get 
			{
				CanReadProperty("Makho", true);
				return _makho;
			}
			set 
			{
				CanWriteProperty("Makho", true);
				if (_makho != value) 
				{
					_makho = value;
					PropertyHasChanged("Makho");
				}
			}
		}
		
		public Decimal TLCK
		{
			get 
			{
				CanReadProperty("TLCK", true);
				return _tLCK;
			}
			set 
			{
				CanWriteProperty("TLCK", true);
				if (_tLCK != value) 
				{
					_tLCK = value;
					PropertyHasChanged("TLCK");
				}
			}
		}
		
		public Boolean Thanhtoan
		{
			get 
			{
				CanReadProperty("Thanhtoan", true);
				return _thanhtoan;
			}
			set 
			{
				CanWriteProperty("Thanhtoan", true);
				if (_thanhtoan != value) 
				{
					_thanhtoan = value;
					PropertyHasChanged("Thanhtoan");
				}
			}
		}
		
		public string NgayTToan
		{
			get 
			{
				CanReadProperty("NgayTToan", true);
				return _ngayTToan.Text;
			}
			set 
			{
				CanWriteProperty("NgayTToan", true);
				if (_ngayTToan.Text != value) 
				{
					_ngayTToan.Text = value;
					PropertyHasChanged("NgayTToan");
				}
			}
		}

        public String ngayXuatTTD
        {
            get
            {
                CanReadProperty("ngayXuatTTD", true);
                _ngayXuatTTD = _ngayXuatTT;
                _ngayXuatTTD.FormatString = "dd/MM/yyyy";

                return _ngayXuatTTD.Text;
            }

        }
        public string NgayXuatTT
        {
            get
            {
                CanReadProperty("NgayXuatTT", true);
                return _ngayXuatTT.Text;
            }
            set
            {
                CanWriteProperty("NgayXuatTT", true);
                if (_ngayXuatTT.Text != value)
                {
                    _ngayXuatTT.Text = value;
                    PropertyHasChanged("NgayXuatTT");
                }
            }
        }
		
		public String NVNhap
		{
			get 
			{
				CanReadProperty("NVNhap", true);
				return _nVNhap;
			}
			set 
			{
				CanWriteProperty("NVNhap", true);
				if (_nVNhap != value) 
				{
					_nVNhap = value;
					PropertyHasChanged("NVNhap");
				}
			}
		}
		
		public Decimal Tong
		{
			get 
			{
				CanReadProperty("Tong", true);
				return _tong;
			}
			set 
			{
				CanWriteProperty("Tong", true);
				if (_tong != value) 
				{
					_tong = value;
					PropertyHasChanged("Tong");
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
                _ngaySD.FormatString = "dd/MM/yyyy";
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
                _ngaySD1.FormatString = "dd/MM/yyyy";
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
		
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _nguoihuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_nguoihuy != value) 
				{
					_nguoihuy = value;
					PropertyHasChanged("Nguoihuy");
				}
			}
		}
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
                _ngayhuy.FormatString = "dd/MM/yyyy";
				return _ngayhuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_ngayhuy.Text != value) 
				{
					_ngayhuy.Text = value;
					PropertyHasChanged("Ngayhuy");
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy";
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
		
		public String NVXuat
		{
			get 
			{
				CanReadProperty("NVXuat", true);
				return _nVXuat;
			}
			set 
			{
				CanWriteProperty("NVXuat", true);
				if (_nVXuat != value) 
				{
					_nVXuat = value;
					PropertyHasChanged("NVXuat");
				}
			}
		}
		
		public String NVNhan
		{
			get 
			{
				CanReadProperty("NVNhan", true);
				return _nVNhan;
			}
			set 
			{
				CanWriteProperty("NVNhan", true);
				if (_nVNhan != value) 
				{
					_nVNhan = value;
					PropertyHasChanged("NVNhan");
				}
			}
		}
		
		public Decimal VAT
		{
			get 
			{
				CanReadProperty("VAT", true);
				return _vAT;
			}
			set 
			{
				CanWriteProperty("VAT", true);
				if (_vAT != value) 
				{
					_vAT = value;
					PropertyHasChanged("VAT");
				}
			}
		}

        public String TenNCC
        {
            get
            {
                CanReadProperty("TenNCC", true);
                return _tenNCC;
            }
            set
            {
                CanWriteProperty("TenNCC", true);
                if (_tenNCC != value)
                {
                    _tenNCC = value;
                    PropertyHasChanged("TenNCC");
                }
            }
        }
        public String TenKho
        {
            get
            {
                CanReadProperty("TenKho", true);
                return _tenKho;
            }
            set
            {
                CanWriteProperty("TenKho", true);
                if (_tenKho != value)
                {
                    _tenKho = value;
                    PropertyHasChanged("TenKho");
                }
            }
        }
        public String TenNVXuat
        {
            get
            {
                CanReadProperty("TenNVXuat", true);
                return _tenNVXuat;
            }
            set
            {
                CanWriteProperty("TenNVXuat", true);
                if (_tenNVXuat != value)
                {
                    _tenNVXuat = value;
                    PropertyHasChanged("TenNVXuat");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        VPPXuatTra_C_List _VPPXuatTraCs = VPPXuatTra_C_List.NewVPPXuatTra_C_List();
        public VPPXuatTra_C_List VPPXuatTraCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _VPPXuatTraCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_VPPXuatTraCs.Equals(value))
                {
                    _VPPXuatTraCs = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maPXT;
		}

        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _VPPXuatTraCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _VPPXuatTraCs.IsValid;
            }
        }

		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNCC", 150));
            ValidationRules.AddRule<VPPXuatTra>(StringRequired<VPPXuatTra>, "TenNCC");
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : VPPXuatTra
        {

            if (target.TenNCC  == null || target.TenNCC .Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="VPPXuatTra" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static VPPXuatTra NewVPPXuatTra()
        {
            return DataPortal.Create<VPPXuatTra>();
        }
		public static VPPXuatTra GetVPPXuatTra(String maPXT)
		{
			return DataPortal.Fetch<VPPXuatTra>(new Criteria(maPXT));
		}
        public static VPPXuatTra GetVPPXuatTra(SafeDataReader dr)
        {
            VPPXuatTra obj = new VPPXuatTra();
            obj.Fetch(dr);
            return obj;

        }
		/// <summary>
		/// Marks the <see cref="VPPXuatTra" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteVPPXuatTra(String maPXT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPXT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal VPPXuatTra()
		{	
			// Prevent direct creation
		}
        internal VPPXuatTra( 
                             int OrderNumber,
                             String maPXT ,
		                     String maNCC ,
		                     String soCT ,
		                     SmartDate ngayXT ,
		                     String makho ,
		                     Boolean thanhtoan ,
		                     SmartDate ngayTToan ,
		                     SmartDate ngayXuatTT ,
		                    // String nVNhap,
		                     Decimal tong ,
		                     String ghichu ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngaySD1 ,
		                     String nguoiSD1 ,
		                     String maMay ,
		                     String nguoihuy ,
		                     SmartDate ngayhuy ,
		                     String nguoiLap ,
		                     SmartDate ngayLap ,
		                     String nVXuat ,
		                     String nVNhan,
		                     Decimal vAT ,
                             String tenNCC,
                             String tenKho,
                             String tenNVXuat ,
                             String tenNguoiLap ,
                             String tenNguoiSD ,
                             String tenNguoiHuy
                          //  SmartDate  ngayXuatTTD
         )
        { 
                         _OrderNumber = OrderNumber ;
                         _maPXT = maPXT;
                         _maNCC = maNCC;
                         _soCT = soCT;
                         _ngayXT = ngayXT;
                         _makho = makho;
                       
                         _thanhtoan = thanhtoan;
                         _ngayTToan = ngayTToan;
                         _ngayXuatTT = ngayXuatTT;
                        // _nVNhap = nVNhap;
                         _tong = tong;
                         _ghichu = ghichu;
                         _huy = huy;
                         _ngaySD = ngaySD;
                         _nguoiSD = nguoiSD;
                         _ngaySD1 = ngaySD1;
                         _nguoiSD1 = nguoiSD1;
                         _maMay = maMay;
                         _nguoihuy = nguoihuy;
                         _ngayhuy = ngayhuy;
                         _nguoiLap = nguoiLap;
                         _ngayLap = ngayLap;
                         _nVXuat = nVXuat;
                         _nVNhan = nVNhan;
                         _vAT = vAT;
                         _tenNCC = tenNCC;
                         _tenKho = tenKho;
                         _tenNVXuat = tenNVXuat;
                         _tenNguoiLap = tenNguoiLap;
                         _tenNguoiSD = tenNguoiSD;
                         _tenNguoiHuy = tenNguoiHuy;
                         //_ngayXuatTTD = ngayXuatTTD;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPXT;
			public String MaPXT 
			{
				get
				{
					return _maPXT;
				}
			}

             private Boolean _qadmin = false ;
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maPXT)
			{
				_maPXT = maPXT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPXT.Equals(c._maPXT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPXT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPXT;
            public String MaPXT
            {
                get
                {
                    return _MaPXT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPXT)
            {
                _MaPXT = MaPXT;
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
		/// Retrieve an existing <see cref="VPPXuatTra" /> Object based on data in the database.
		/// </summary>
        /// 

		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetVPPXuatTra(String _maPXT);
			// public override IDataReader GetVPPXuatTra(String _maPXT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPXuatTra_GET", _maPXT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVPPXuatTra(crit.MaPXT, crit.Qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    //MarkOld();
                    //ValidationRules.CheckRules();
                    if (dr.NextResult())
                    {
                        _VPPXuatTraCs = VPPXuatTra_C_List.GetVPPXuatTra_C_List(dr);
                    } 
				}
			}
		}
		/// <summary>
		/// Load a <see cref="VPPXuatTra" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPXT") != null) _maPXT = dr.GetString("MaPXT");
			if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
			if (dr.GetString("SoCT") != null) _soCT = dr.GetString("SoCT");
            if (dr.GetString("SoHDon") != null) _soHoaDon = dr.GetString("SoHDon");
            if (dr.GetSmartDate("NgayHDON", true) != null) _ngayHoaDon = dr.GetSmartDate("NgayHDON");
			if (dr.GetSmartDate("NgayXT", true) != null) _ngayXT = dr.GetSmartDate("NgayXT", true);
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
		    if (dr.GetBoolean("Thanhtoan") != null) _thanhtoan = dr.GetBoolean("Thanhtoan");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetSmartDate("NgayXuatTT", true) != null) _ngayXuatTT = dr.GetSmartDate("NgayXuatTT", true);
            //if (dr.GetSmartDate("NgayXuatTT", true) != null) _ngayXuatTTD = dr.GetSmartDate("NgayXuatTT", true);
			//if (dr.GetString("NVNhap") != null) _nVNhap = dr.GetString("NVNhap");
			if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NVXuat") != null) _nVXuat = dr.GetString("NVXuat");
			if (dr.GetString("NVNhan") != null) _nVNhan = dr.GetString("NVNhan");
			if (dr.GetDecimal("VAT") != null) _vAT = dr.GetDecimal("VAT");
            _tenNCC = dr.GetString("TenNCC");
            _tenKho = dr.GetString("TenKho");
            _tenNVXuat = dr.GetString("TenNVXuat");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="VPPXuatTra" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            //_ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }

		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertVPPXuatTra
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maPXT = DataProvider.Instance().InsertVPPXuatTra(_maNCC, _soCT, _ngayXT, _makho, _thanhtoan, _ngayTToan, _ngayXuatTT, _tong, _ghichu, _maMay, _nguoiSD , _ngayLap, _nVXuat, _nVNhan, _vAT, _soHoaDon, _ngayHoaDon);
            _VPPXuatTraCs.Update(this);
			// public abstract String InsertVPPXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT);
			// public override String InsertVPPXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPXuatTra_CREATE", _maNCC, _soCT, _ngayXT, _makho,  _thanhtoan, _ngayTToan, _ngayXuatTT, _tong, _ghichu,  _maMay,  _nguoiLap, _ngayLap, _nVXuat, _nVNhan, _vAT);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="VPPXuatTra" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVPPXuatTra
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateVPPXuatTra(_maPXT, _maNCC, _soCT, _ngayXT, _makho, _thanhtoan, _ngayTToan, _ngayXuatTT, _tong, _ghichu, _huy, _nguoiSD , _maMay, _nVXuat, _nVNhan, _vAT, _soHoaDon, _ngayHoaDon);
                _VPPXuatTraCs.Update(this);
				// public abstract void UpdateVPPXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT);
				// public override void UpdateVPPXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPXuatTra_UPDATE", _maPXT, _maNCC, _soCT, _ngayXT, _makho, _thanhtoan, _ngayTToan, _ngayXuatTT, _tong, _ghichu, _huy, _nguoiSD , _maMay, _nVXuat, _nVNhan, _vAT);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,_maPXT));
		}

		/// <summary>
		/// Delete the <see cref="VPPXuatTra" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVPPXuatTra
            DataProvider.Instance().DeleteVPPXuatTra(crit.MaMay, crit.NguoiSD, crit.MaPXT);
			// public abstract void DeleteVPPXuatTra(String _maPXT);
			// public override void DeleteVPPXuatTra(String _maPXT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPXuatTra_DELETED", _maPXT);
			// }
		}

		#endregion
	}

}
