﻿// *****************************************************************************************************
//  File nay VTYT sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	VTPhieuDTNhap
// Kieu doi tuong  :	VTPhieuDTNhap
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/12/2009 10:25:05 AM
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
namespace HTC.Business.VTYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="VTPhieuDTNhap" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class VTPhieuDTNhap : BusinessBase<VTPhieuDTNhap>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDuTru = String.Empty;
        private String _maNCC = String.Empty;
        private string _tenNCC = string.Empty;
		private String _soCT = String.Empty;
		private SmartDate _ngayPhieu = new SmartDate(DateTime.Today);
        private SmartDate _ngayPhieuD = new SmartDate(DateTime.Today);
		private String _makho = String.Empty;
		private String _nguoiDuTru = String.Empty;
		private Decimal _tong = 0;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _maMay = String.Empty;
        private String _tenKho = String.Empty;
        private String _tenNguoiDT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		
		#endregion
		
		#region Business Properties and Methods
		
		public String MaDuTru
		{
			get 
			{
				CanReadProperty("MaDuTru", true);
				return _maDuTru;
			}
			set 
			{
				CanWriteProperty("MaDuTru", true);
				if (_maDuTru != value) 
				{
					_maDuTru = value;
					PropertyHasChanged("MaDuTru");
				}
			}
		}
        public String MaNCC
        {
            get
            {
                CanReadProperty("MaNCC", true);
                return _maNCC ;
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

        public String TenNCC
        {
            get
            {
                CanReadProperty("TenNCC", true);
                return _tenNCC ;
            }
            set
            {
                CanWriteProperty("TenNCC", true);
                if (_tenNCC  != value)
                {
                    _tenNCC = value;
                    PropertyHasChanged("TenNCC");
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
		
		public string NgayPhieu
		{
			get 
			{
				CanReadProperty("NgayPhieu", true);
				return _ngayPhieu.Text;
			}
			set 
			{
				CanWriteProperty("NgayPhieu", true);
				if (_ngayPhieu.Text != value) 
				{
					_ngayPhieu.Text = value;
					PropertyHasChanged("NgayPhieu");
				}
			}
		}

        //public String NgayPhieuD
        //{
        //    get
        //    {
        //        //CanReadProperty("NgayPhieuD", true);
        //        this._ngayPhieuD.FormatString = "dd/MM/yyyy";
        //        _ngayPhieuD = _ngayPhieu;
        //        return _ngayPhieuD.Text;
        //    }
        //    //set
        //    //{
        //    //    CanWriteProperty("NgayPhieu", true);
        //    //    if (_ngayPhieu != value)
        //    //    {
        //    //        _ngayPhieu.FormatString = "MM/dd/yyyy";
        //    //        _ngayPhieu.Text = value;
        //    //        PropertyHasChanged("NgayPhieu");
        //    //    }
        //    //}
        //}
        public String NgayPhieuD
        {
            get
            {
                CanReadProperty("NgayPhieuD", true);
                _ngayPhieuD = _ngayPhieu;
                this._ngayPhieuD.FormatString = "dd/MM/yyyy";
                return _ngayPhieuD.Text;
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
		
		public String NguoiDuTru
		{
			get 
			{
				CanReadProperty("NguoiDuTru", true);
				return _nguoiDuTru;
			}
			set 
			{
				CanWriteProperty("NguoiDuTru", true);
				if (_nguoiDuTru != value) 
				{
					_nguoiDuTru = value;
					PropertyHasChanged("NguoiDuTru");
				}
			}
		}

        public string Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                return _tong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Tong", true);

                if (_tong.ToString() != value)
                {
                    _tong = decimal.Parse(value);
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
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
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
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
        public String NgaySDD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySDD = _ngaySD;
                this._ngaySDD.FormatString = "dd/MM/yyyy";
                return _ngaySDD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayPhieu", true);
            //    if (_ngayPhieu != value)
            //    {
            //        _ngayPhieu.FormatString = "MM/dd/yyyy";
            //        _ngayPhieuD.Text = value;
            //        PropertyHasChanged("NgayPhieu");
            //    }
            //}
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

        public String TenNguoiDT
        {
            get
            {
                CanReadProperty("TenNguoiDT", true);
                return _tenNguoiDT;
            }
            set
            {
                CanWriteProperty("TenNguoiDT", true);
                if (_tenNguoiDT != value)
                {
                    _tenNguoiDT = value;
                    PropertyHasChanged("TenNguoiDT");
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

        VTPhieuDTNhap_C_List _VTPhieuDTNhap_Cs = VTPhieuDTNhap_C_List.NewVTPhieuDTNhap_C_List();

        public VTPhieuDTNhap_C_List VTPhieuDTNhap_Cs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _VTPhieuDTNhap_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_VTPhieuDTNhap_Cs.Equals(value))
                {
                    _VTPhieuDTNhap_Cs = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maDuTru;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _VTPhieuDTNhap_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _VTPhieuDTNhap_Cs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaKho", 6));
            ValidationRules.AddRule<VTPhieuDTNhap>(StringRequired<VTPhieuDTNhap>, "MaKho");
            ValidationRules.AddRule<VTPhieuDTNhap>(ValidationDateTT<VTPhieuDTNhap>, "NgayPhieu");
            ValidationRules.AddRule<VTPhieuDTNhap>(ValidationDateNow<VTPhieuDTNhap>, "NgayPhieu");
        }
        private static bool ValidationDateTT<T>(T target, Csla.Validation.RuleArgs e) where T : VTPhieuDTNhap
        {
            if (target._ngayPhieu == null)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool ValidationDateNow<T>(T target, Csla.Validation.RuleArgs e) where T : VTPhieuDTNhap
        {
            if (target._ngayPhieu > DateTime.Now )
            {
                e.Description = HTC.ShareVariables.VAR_VALIDATION_NOW;
                return false;
            }
            else
                return true;
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : VTPhieuDTNhap
        {

            if (target._makho == null || target._makho.Trim().Length == 0)
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
		/// Factory method. New <see cref="VTPhieuDTNhap" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static VTPhieuDTNhap NewVTPhieuDTNhap()
        {
            return DataPortal.Create<VTPhieuDTNhap>();
        }
		public static VTPhieuDTNhap GetVTPhieuDTNhap(String maDuTru)
		{
			return DataPortal.Fetch<VTPhieuDTNhap>(new Criteria(maDuTru));
		}
        public static VTPhieuDTNhap GetVTPhieuDTNhap(SafeDataReader dr)
        {
            VTPhieuDTNhap obj = new VTPhieuDTNhap();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="VTPhieuDTNhap" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteVTPhieuDTNhap(String maDuTru, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDuTru));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal VTPhieuDTNhap()
		{	
			// Prevent direct creation
		}
        internal VTPhieuDTNhap(
  int OrderNumber,
  String maDuTru ,
  String maNCC,
  string tenNCC,
		                                 String soCT ,
		                                 SmartDate ngayPhieu ,
  SmartDate ngayPhieuD ,
		                                 String makho ,
		                                 String nguoiDuTru ,
		                                 Decimal tong ,
		                                 String ghichu ,
		                                 Boolean huy ,
		                                 SmartDate ngayLap ,
		                                 String nguoiLap ,
		                                 SmartDate ngayHuy ,
		                                 String nguoiHuy ,
		                                 SmartDate ngaySD ,
		                                 String nguoiSD ,
		                                 SmartDate ngaySD1 ,
		                                 String nguoiSD1 ,
		                                 String maMay ,
  String tenKho ,
  String tenNguoiDT ,
  String tenNguoiLap ,
  String tenNguoiSD ,
  String tenNguoiHuy 
         )
        {
 _OrderNumber = OrderNumber;
 _maDuTru = maDuTru;
 _maNCC = MaNCC;
 _tenNCC = tenNCC;
 _soCT = soCT;
 _ngayPhieu = ngayPhieu;
 _ngayPhieuD = ngayPhieuD;
 _makho = makho;
 _nguoiDuTru = nguoiDuTru;
 _tong = tong;
 _ghichu = ghichu;
 _huy = huy;
 _ngayLap = ngayLap;
 _nguoiLap = nguoiLap;
 _ngayHuy = ngayHuy;
 _nguoiHuy = nguoiHuy;
 _ngaySD = ngaySD;
 _nguoiSD = nguoiSD;
 _ngaySD1 = ngaySD1;
 _nguoiSD1 = nguoiSD1;
 _maMay = maMay;
 _tenKho = tenKho;
 _tenNguoiDT = tenNguoiDT;
 _tenNguoiLap = tenNguoiLap;
 _tenNguoiSD = tenNguoiSD;
 _tenNguoiHuy = tenNguoiHuy;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDuTru;
			public String MaDuTru 
			{
				get
				{
					return _maDuTru;
				}
			}
             private bool  _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maDuTru)
			{
				_maDuTru = maDuTru;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDuTru.Equals(c._maDuTru)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDuTru.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDuTru;
            public String MaDuTru
            {
                get
                {
                    return _maDuTru;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDuTru)
            {
                _maDuTru = maDuTru;
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
		/// Retrieve an existing <see cref="VTPhieuDTNhap" /> Object based on data in the database.
		/// </summary>
        /// 

		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetVTPhieuDTNhap(String _maDuTru);
			// public override IDataReader GetVTPhieuDTNhap(String _maDuTru)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDuTru));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVTPhieuDTNhap(crit.MaDuTru,crit.qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _VTPhieuDTNhap_Cs = VTPhieuDTNhap_C_List.GetVTPhieuDTNhap_C_List(dr);
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="VTPhieuDTNhap" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDuTru") != null) _maDuTru = dr.GetString("MaDuTru");
            if (dr.GetString("MaNCC") != null) _maNCC  = dr.GetString("MaNCC");
            if (dr.GetString("TenNCC") != null) _tenNCC  = dr.GetString("TenNCC");
			if (dr.GetString("SoCT") != null) _soCT = dr.GetString("SoCT");
			if (dr.GetSmartDate("NgayPhieu", true) != null) _ngayPhieu = dr.GetSmartDate("NgayPhieu", true);
            if (dr.GetSmartDate("NgayPhieu", true) != null) _ngayPhieuD = dr.GetSmartDate("NgayPhieu", true);
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
			if (dr.GetString("NguoiDuTru") != null) _nguoiDuTru = dr.GetString("NguoiDuTru");
			if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySDD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _tenKho = dr.GetString("TenKho");
            _tenNguoiDT = dr.GetString("TenNguoiDT");
            _tenNguoiLap = dr.GetString("TENNGUOILAP");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
            _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
		}
		
		/// <summary>
		/// Insert the new <see cref="VTPhieuDTNhap" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            //ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertVTPhieuDTNhap
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maDuTru = DataProvider.Instance().InsertVTPhieuDTNhap(_soCT, _ngayPhieu, _makho, _nguoiDuTru, _tong, _ghichu,  _nguoiLap, _maMay, _maNCC );
            MarkOld();
            _VTPhieuDTNhap_Cs.Update(this);
			// public abstract String InsertVTPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
			// public override String InsertVTPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDuTru, _soCT, _ngayPhieu.DBValue, _makho, _nguoiDuTru, _tong, _ghichu, _huy, _ngayLap.DBValue, _nguoiSD , _ngayHuy.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1, _maMay), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="VTPhieuDTNhap" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVTPhieuDTNhap
			if (IsDirty){
                
                
				DataProvider.Instance().UpdateVTPhieuDTNhap(_maDuTru, _soCT, _ngayPhieu, _makho, _nguoiDuTru, _tong, _ghichu, _huy, _nguoiSD , _maMay, _maNCC );
                _VTPhieuDTNhap_Cs.Update(this);
				// public abstract void UpdateVTPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
				// public override void UpdateVTPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, Boolean _huy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _maMay);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDuTru, _soCT, _ngayPhieu.DBValue, _makho, _nguoiDuTru, _tong, _ghichu, _huy, _ngayLap.DBValue, _nguoiSD , _ngayHuy.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1, _maMay);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDuTru));
		}

		/// <summary>
		/// Delete the <see cref="VTPhieuDTNhap" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVTPhieuDTNhap
            DataProvider.Instance().DeleteVTPhieuDTNhap(crit.MaMay, crit.NguoiSD, crit.MaDuTru);
			// public abstract void DeleteVTPhieuDTNhap(String _maDuTru);
			// public override void DeleteVTPhieuDTNhap(String _maDuTru);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDuTru);
			// }
		}

		#endregion
	}

}
