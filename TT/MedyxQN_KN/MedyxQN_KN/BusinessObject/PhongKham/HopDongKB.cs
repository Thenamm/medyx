// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HopDongKB
// Kieu doi tuong  :	HopDongKB
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 9:28:57 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HopDongKB" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HopDongKB : BusinessBase<HopDongKB>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaHD = String.Empty;
        private byte _LoaiHD = 0;
        private String _SoHD = String.Empty;
        private SmartDate _NgayKy = new SmartDate(DateTime.Today);
        private SmartDate _TuNgay = new SmartDate(DateTime.Today);
        private SmartDate _DenNgay = new SmartDate(DateTime.Today);
        private String _NguoiDD = String.Empty;
        private String _NguoiLienHe = String.Empty;		      
        private String _DonVi = String.Empty;
        private String _DiaChi = String.Empty;
        private String _DienThoai = String.Empty;
        private String _Fax = String.Empty;
        private String _MaSoThue = String.Empty;
        private String _TaiKhoan = String.Empty;
        private String _PTTT = String.Empty;
        private Decimal _GiatriHD = 0;
        private Boolean _datt = false;
        private SmartDate _NgayTT = new SmartDate(true);
        private String _GhiChu = String.Empty;
        private String _NoiTT = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaylap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _NguoiSD = String.Empty;        
        private String _maMay = String.Empty;
        private SmartDate _NgayHuy = new SmartDate(true);
        private String _NguoiHuy = String.Empty;
        private String _tennguoidd = String.Empty;
        private String _maDT = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaHD
		{
			get 
			{
				CanReadProperty("MaHD", true);
				return _MaHD;
			}
            set
            {
                CanWriteProperty("MaHD", true);
                if (_MaHD != value)
                {
                    _MaHD = value;
                    PropertyHasChanged("MaHD");
                }
            }
		}
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }
        public byte LoaiHD
        {
            get
            {
                CanReadProperty("LoaiHD", true);
                return _LoaiHD;
            }
            set
            {
                CanWriteProperty("LoaiHD", true);
                if (_LoaiHD != value)
                {
                    _LoaiHD = value;
                    PropertyHasChanged("LoaiHD");
                }
            }
        }		       
        public String SoHD
        {
            get
            {
                CanReadProperty("SoHD", true);
                return _SoHD;
            }
            set
            {
                CanWriteProperty("SoHD", true);
                if (_SoHD != value)
                {
                    _SoHD = value;
                    PropertyHasChanged("SoHD");
                }
            }
        }
		public string NgayKy
		{
			get 
			{
				CanReadProperty("NgayKy", true);
				return _NgayKy.Text;
			}
			set 
			{
				CanWriteProperty("NgayKy", true);
				if (_NgayKy.Text != value) 
				{
					_NgayKy.Text = value;
					PropertyHasChanged("NgayKy");
				}
			}
		}
     	public string TuNgay
		{
			get 
			{
				CanReadProperty("TuNgay", true);
				return _TuNgay.Text;
			}
			set 
			{
				CanWriteProperty("TuNgay", true);
				if (_TuNgay.Text != value) 
				{
					_TuNgay.Text = value;
					PropertyHasChanged("TuNgay");
				}
			}
		}
		public string DenNgay
		{
			get 
			{
				CanReadProperty("DenNgay", true);
				return _DenNgay.Text;
			}
			set 
			{
				CanWriteProperty("DenNgay", true);
				if (_DenNgay.Text != value) 
				{
					_DenNgay.Text = value;
					PropertyHasChanged("DenNgay");
				}
			}
		}
		public String NguoiDD
		{
			get 
			{
				CanReadProperty("NguoiDD", true);
				return _NguoiDD;
			}
			set 
			{
				CanWriteProperty("NguoiDD", true);
				if (_NguoiDD != value) 
				{
					_NguoiDD = value;
					PropertyHasChanged("NguoiDD");
				}
			}
		}
        public String TenNguoiDD
        {
            get
            {
                CanReadProperty("TenNguoiDD", true);
                return _tennguoidd;
            }
            set
            {
                CanWriteProperty("TenNguoiDD", true);
                if (_tennguoidd != value)
                {
                    _tennguoidd = value;
                    PropertyHasChanged("TenNguoiDD");
                }
            }
        }
        public String NguoiLienHe
        {
            get
            {
                CanReadProperty("NguoiLienHe", true);
                return _NguoiLienHe;
            }
            set
            {
                CanWriteProperty("NguoiLienHe", true);
                if (_NguoiLienHe != value)
                {
                    _NguoiLienHe = value;
                    PropertyHasChanged("NguoiLienHe");
                }
            }
        }
        public String DonVi
		{
			get 
			{
                CanReadProperty("DonVi", true);
                return _DonVi;
			}
			set 
			{
                CanWriteProperty("DonVi", true);
                if (_DonVi != value) 
				{
                    _DonVi = value;
                    PropertyHasChanged("DonVi");
				}
			}
		}
        public String DiaChi
		{
			get 
			{
                CanReadProperty("DiaChi", true);
                return _DiaChi;
			}
			set 
			{
                CanWriteProperty("DiaChi", true);
                if (_DiaChi != value) 
				{
                    _DiaChi = value;
                    PropertyHasChanged("DiaChi");
				}
			}
		}
        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                return _DienThoai;
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_DienThoai != value)
                {
                    _DienThoai = value;
                    PropertyHasChanged("DienThoai");
                }
            }
        }
        public String Fax
        {
            get
            {
                CanReadProperty("Fax", true);
                return _Fax;
            }
            set
            {
                CanWriteProperty("Fax", true);
                if (_Fax != value)
                {
                    _Fax = value;
                    PropertyHasChanged("Fax");
                }
            }
        }
        public String MaSoThue
        {
            get
            {
                CanReadProperty("MaSoThue", true);
                return _MaSoThue;
            }
            set
            {
                CanWriteProperty("MaSoThue", true);
                if (_MaSoThue != value)
                {
                    _MaSoThue = value;
                    PropertyHasChanged("MaSoThue");
                }
            }
        }
        public String TaiKhoan
        {
            get
            {
                CanReadProperty("TaiKhoan", true);
                return _TaiKhoan;
            }
            set
            {
                CanWriteProperty("TaiKhoan", true);
                if (_TaiKhoan != value)
                {
                    _TaiKhoan = value;
                    PropertyHasChanged("TaiKhoan");
                }
            }
        }
        public String PTTT
        {
            get
            {
                CanReadProperty("PTTT", true);
                return _PTTT;
            }
            set
            {
                CanWriteProperty("PTTT", true);
                if (_PTTT != value)
                {
                    _PTTT = value;
                    PropertyHasChanged("PTTT");
                }
            }
        }
        public Decimal GiatriHD
        {
            get
            {
                CanReadProperty("GiatriHD", true);
                return _GiatriHD;
            }
            set
            {
                CanWriteProperty("GiatriHD", true);
                if (_GiatriHD != value)
                {
                    _GiatriHD = value;
                    PropertyHasChanged("GiatriHD");
                }
            }
        }
        public Boolean datt
        {
            get
            {
                CanReadProperty("datt", true);
                return _datt;
            }
            set
            {
                CanWriteProperty("datt", true);
                if (_datt != value)
                {
                    _datt = value;
                    PropertyHasChanged("datt");
                }
            }
        }
        public string  NgayTT
        {
            get
            {
                CanReadProperty("NgayTT", true);
             
                return _NgayTT.Text;
            }
            set
            {
                CanWriteProperty("NgayTT", true);
                if (_NgayTT.Text != value)
                {
                    _NgayTT.Text = value;
                    PropertyHasChanged("NgayTT");
                }
            }
        }
        public String GhiChu
		{
			get 
			{
				CanReadProperty("GhiChu", true);
				return _GhiChu;
			}
			set 
			{
				CanWriteProperty("GhiChu", true);
				if (_GhiChu != value) 
				{
					_GhiChu = value;
					PropertyHasChanged("GhiChu");
				}
			}
		}
        public String NoiTT
        {
            get
            {
                CanReadProperty("NoiTT", true);
                return _NoiTT;
            }
            set
            {
                CanWriteProperty("NoiTT", true);
                if (_NoiTT != value)
                {
                    _NoiTT = value;
                    PropertyHasChanged("NoiTT");
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
        public SmartDate ngaylap
        {
            get
            {
                CanReadProperty("ngaylap", true);
                _ngaylap.FormatString = "dd/MM/yyyy HH:mm";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("ngaylap", true);
                if (_ngaylap != value)
                {
                    _ngaylap = value;
                    PropertyHasChanged("ngaylap");
                }
            }
        }
        public String nguoilap
        {
            get
            {
                CanReadProperty("nguoilap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("nguoilap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("nguoilap");
                }
            }
        }
        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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
        public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
				return _NgayHuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_NgayHuy.Text != value) 
				{
					_NgayHuy.Text = value;
					PropertyHasChanged("Ngayhuy");
				}
			}
		}
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _NguoiHuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_NguoiHuy != value) 
				{
					_NguoiHuy = value;
					PropertyHasChanged("Nguoihuy");
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

        private HopDongKB_DV_List _HopDongKB_DV_List = HopDongKB_DV_List.NewHopDongKB_DV_List();
        public HopDongKB_DV_List HopDongKB_DV_List
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _HopDongKB_DV_List;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_HopDongKB_DV_List.Equals(value))
                {
                    _HopDongKB_DV_List = value;
                    PropertyHasChanged();
                }
            }
        }

        private HopDongKB_BNList _HopDongKB_BNList = HopDongKB_BNList.NewHopDongKB_BNList();
        public HopDongKB_BNList HopDongKB_BNList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _HopDongKB_BNList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_HopDongKB_BNList.Equals(value))
                {
                    _HopDongKB_BNList = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _MaHD;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _HopDongKB_DV_List.IsDirty || _HopDongKB_BNList.IsDirty ;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _HopDongKB_DV_List.IsValid && _HopDongKB_BNList.IsValid ;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            //ValidationRules.AddRule<DMThuoc>(StringRequired<DMThuoc>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            
            ValidationRules.AddRule<HopDongKB>(ValidationDateTT<HopDongKB>, "NgayKy");

        }
        private static bool ValidationDateTT<T>(T target, Csla.Validation.RuleArgs e) where T : HopDongKB
        {
            if (target._NgayKy > DateTime.Now)
            {
                e.Description = "Ngày KK phải nhỏ hơn hoặc bằng ngày hiện tại";
                return false;
            }
            else
                return true;
        }
        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc
        //{

        //    if (target._tenTM == null || target._tenTM.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        //private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : HopDongKB
        //{

        //    if (target._makho == null || target._makho.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HopDongKB" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HopDongKB NewHopDongKB()
        {
            return DataPortal.Create<HopDongKB>();
        }
		public static HopDongKB GetHopDongKB(String MaHD)
		{
			return DataPortal.Fetch<HopDongKB>(new Criteria(MaHD));
		}
        public static HopDongKB GetHopDongKB(SafeDataReader dr)
        {
            HopDongKB obj = new HopDongKB();
            obj.Fetch(dr);
            return obj;

        }
		/// <summary>
		/// Marks the <see cref="HopDongKB" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteHopDongKB(String MaHD, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaHD));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HopDongKB()
		{	
			// Prevent direct creation
		}
        internal HopDongKB(    int __OrderNumber, 
         String __MaHD ,
         byte __LoaiHD,
         String __SoHD ,
         SmartDate __NgayKy,
         SmartDate __TuNgay,
         SmartDate __DenNgay,
         String __NguoiDD,
         String __NguoiLienHe,		      
         String __DonVi,
         String __DiaChi ,
         String __DienThoai,
         String __Fax,
         String __MaSoThue,
         String __TaiKhoan,
         String __PTTT,
         Decimal __GiatriHD,
         Boolean __datt,
         SmartDate __NgayTT,
         String __GhiChu,
         String __NoiTT,
         Boolean __huy,
         SmartDate __ngaylap,
         String __nguoiLap,
         SmartDate __ngaySD,
         String __NguoiSD,        
         String __maMay,

         SmartDate __NgayHuy,
         String __NguoiHuy,
         String __tenNguoidd,
         String __madt
                             )
        {
            _maDT = __madt;
                                _OrderNumber = __OrderNumber;
                                _MaHD = __MaHD;
                                _LoaiHD = __LoaiHD;
                                _SoHD = __SoHD;
                                _NgayKy = __NgayKy;
                                _TuNgay = __TuNgay;
                                _DenNgay = __DenNgay;
                                _NguoiDD = __NguoiDD;
                                _NguoiLienHe = __NguoiLienHe;
                                _tennguoidd = __tenNguoidd;
                                _DonVi = __DonVi;
                                _DiaChi = __DiaChi;
                                _DienThoai = __DienThoai;
                                _Fax = __Fax;
                                _MaSoThue = __MaSoThue;
                                _TaiKhoan = __TaiKhoan;
                                _PTTT = __PTTT;
                                _GiatriHD = __GiatriHD;
                                _datt = __datt;
                                _NgayTT = __NgayTT;
                                _GhiChu = __GhiChu;
                                _NoiTT = __NoiTT;
                                _huy = __huy;
                                _ngaylap = __ngaylap;
                                _nguoiLap = __nguoiLap;
                                _ngaySD = __ngaySD;
                                _NguoiSD = __NguoiSD;
                                _maMay = __maMay;

                                _NgayHuy = __NgayHuy;
                                _NguoiHuy = __NguoiHuy; 
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaHD;
			public String MaHD 
			{
				get
				{
					return _MaHD;
				}
			}
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String MaHD)
			{
				_MaHD = MaHD;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaHD.Equals(c._MaHD)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaHD.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaHD;
            public String MaHD
            {
                get
                {
                    return _MaHD;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaHD)
            {
                _MaHD = MaHD ;
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
		/// Retrieve an existing <see cref="HopDongKB" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetHopDongKB(String _MaHD, bool qadmin);
            // public override IDataReader GetHopDongKB(String _MaHD, bool qadmin)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaHD,qadmin));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHopDongKB(crit.MaHD, crit.qadmin)))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _HopDongKB_DV_List = HopDongKB_DV_List.GetHopDongKB_DV_List(dr) ;
                    }
                    if (dr.NextResult())
                    {
                        _HopDongKB_BNList = HopDongKB_BNList.GetHopDongKB_BNList(dr);
                    } 
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="HopDongKB" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHD") != null) _MaHD = dr.GetString("MaHD");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetByte("LoaiHD") != null) _LoaiHD = dr.GetByte("LoaiHD");
            if (dr.GetString("SoHD") != null) _SoHD = dr.GetString("SoHD");
			if (dr.GetSmartDate("NgayKy", true) != null) _NgayKy = dr.GetSmartDate("NgayKy");
            if (dr.GetSmartDate("TuNgay", true) != null) _TuNgay = dr.GetSmartDate("TuNgay");
            if (dr.GetSmartDate("DenNgay", true) != null) _DenNgay = dr.GetSmartDate("DenNgay");
			if (dr.GetString("NguoiDD") != null) _NguoiDD = dr.GetString("NguoiDD");
            if (dr.GetString("TenNguoiDD") != null) _tennguoidd = dr.GetString("TenNguoiDD");
            if (dr.GetString("NguoiLienHe") != null) _NguoiLienHe = dr.GetString("NguoiLienHe");
            if (dr.GetString("DonVi") != null) _DonVi = dr.GetString("DonVi");
            if (dr.GetString("DiaChi") != null) _DiaChi = dr.GetString("DiaChi");
            if (dr.GetString("DienThoai") != null) _DienThoai = dr.GetString("DienThoai");
            if (dr.GetString("Fax") != null) _Fax = dr.GetString("Fax");
            if (dr.GetString("MaSoThue") != null) _MaSoThue = dr.GetString("MaSoThue");
            if (dr.GetString("TaiKhoan") != null) _TaiKhoan = dr.GetString("TaiKhoan");
            if (dr.GetString("PTTT") != null) _PTTT = dr.GetString("PTTT");
            if (dr.GetDecimal("GiatriHD") != null) _GiatriHD = dr.GetDecimal("GiatriHD");
            if (dr.GetBoolean("datt") != null) _datt = dr.GetBoolean("datt");
            if (dr.GetSmartDate("NgayTT", true) != null) _NgayTT = dr.GetSmartDate("NgayTT", true);
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetString("NoiTT") != null) _NoiTT = dr.GetString("NoiTT");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngaylap", true) != null) _ngaylap = dr.GetSmartDate("Ngaylap", true);
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _NguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _NgayHuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("Nguoihuy") != null) _NguoiHuy = dr.GetString("Nguoihuy");
			
      
 



            
		}
		
		/// <summary>
		/// Insert the new <see cref="HopDongKB" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHopDongKB
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
              _MaHD = DataProvider.Instance().InsertHopDongKB(_LoaiHD, _SoHD, _NgayKy, _TuNgay, _DenNgay,_maDT, _NguoiDD, _NguoiLienHe, _DonVi, _DiaChi, _DienThoai, _Fax, _MaSoThue, _TaiKhoan, _PTTT, _GiatriHD, _datt, _NgayTT, _NoiTT, _NguoiSD , _GhiChu, _maMay);
            MarkOld();
            _HopDongKB_DV_List.Update(this);
            _HopDongKB_BNList.Update(this);
			// public abstract String InsertHopDongKB(SmartDate _NgayKy, String _makho, String _NguoiDD, String _nguoiLap, SmartDate _ngaylap, String _ghiChu, Boolean _xuly, String _maMay);
			// public override String InsertHopDongKB(SmartDate _NgayKy, String _makho, String _NguoiDD, String _nguoiLap, SmartDate _ngaylap, String _ghiChu, Boolean _xuly, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_DVreate", _NgayKy.DBValue, _makho, _NguoiDD, _nguoiSD , _ghiChu, _xuly, _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="HopDongKB" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDongKB
			if (IsDirty){
                
                
                DataProvider.Instance().UpdateHopDongKB(_MaHD, _LoaiHD, _SoHD, _NgayKy, _TuNgay, _DenNgay,_maDT, _NguoiDD, _NguoiLienHe, _DonVi, _DiaChi, _DienThoai, _Fax, _MaSoThue, _TaiKhoan, _PTTT, _GiatriHD, _datt, _NgayTT, _NoiTT,_NguoiSD, _GhiChu,_huy , _maMay);
                _HopDongKB_DV_List.Update(this);
                _HopDongKB_BNList.Update(this);

				// public abstract void UpdateHopDongKB(String _MaHD, SmartDate _NgayKy, String _makho, String _NguoiDD, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateHopDongKB(String _MaHD, SmartDate _NgayKy, String _makho, String _NguoiDD, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_Update", _MaHD, _NgayKy.DBValue, _makho, _NguoiDD, _ghiChu, _xuly, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_NguoiSD, _MaHD));
		}

		/// <summary>
		/// Delete the <see cref="HopDongKB" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDongKB
            DataProvider.Instance().DeleteHopDongKB(crit.MaMay, crit.NguoiSD, crit.MaHD);
			// public abstract void DeleteHopDongKB(String _MaHD);
			// public override void DeleteHopDongKB(String _MaHD);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_DELETED",_maMay, _nguoiSD ,  _MaHD);
			// }
		}

		#endregion
	}

}
