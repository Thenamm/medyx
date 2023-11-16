// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Mau_CT_T
// Kieu doi tuong  :	BenhAn_Mau_CT_T
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/18/2009 2:15:54 PM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_Mau_CT_T" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_Mau_CT_T : BusinessBase<BenhAn_Mau_CT_T>
	{
		#region Business Methods
		
		#region State Fields
        private Int32 _STTTruyen = 0;
     	private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ThoiGian = new SmartDate(true);
    	private String _TocDo = String.Empty;
		private String _MauSac = String.Empty;
		private String _NhipTho = String.Empty;
		private String _Mach = String.Empty;
		private String _HuyetAp = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
	    private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _NhietDo = String.Empty;
        private int _OrderNumber;
        private String _Khac = String.Empty;
      
        #endregion

        #region Business Properties and Methodst
       
        public String Khac
        {
            get
            {
                CanReadProperty("Khac", true);
                return _Khac;
            }
            set
            {
                if (_Khac != value)
                {
                    _Khac = value;

                }
            }
        }
        
        public Int32 STTTruyen
        {
            get
            {
                CanReadProperty("STTTruyen", true);
                return _STTTruyen;
            }
            set
            {
                CanWriteProperty("STTTruyen", true);
                if (_STTTruyen != value)
                {
                    _STTTruyen = value;
                    PropertyHasChanged("STTTruyen");
                }
            }
        }
      	public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
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
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}
		
		
		public string ThoiGian
		{
			get 
			{
				CanReadProperty("ThoiGian", true);
                _ThoiGian.FormatString = "HH:mm";
				return _ThoiGian.Text;
			}
			set 
			{
				CanWriteProperty("ThoiGian", true);
				if (_ThoiGian.Text != value) 
				{
					_ThoiGian.Text = value;
					PropertyHasChanged("ThoiGian");
				}
			}
		}

		public String TocDo
		{
			get 
			{
				CanReadProperty("TocDo", true);
				return _TocDo;
			}
			set 
			{
				CanWriteProperty("TocDo", true);
				if (_TocDo != value) 
				{
					_TocDo = value;
					PropertyHasChanged("TocDo");
				}
			}
		}
        public String NhipTho
        {
            get
            {
                CanReadProperty("NhipTho", true);
                return _NhipTho;
            }
            set
            {
                CanWriteProperty("NhipTho", true);
                if (_NhipTho != value)
                {
                    _NhipTho = value;
                    PropertyHasChanged("NhipTho");
                }
            }
        }
		public String MauSac
		{
			get 
			{
				CanReadProperty("MauSac", true);
				return _MauSac;
			}
			set 
			{
				CanWriteProperty("MauSac", true);
				if (_MauSac != value) 
				{
					_MauSac = value;
					PropertyHasChanged("MauSac");
				}
			}
		}
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _Mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_Mach != value) 
				{
					_Mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String HuyetAp
		{
			get 
			{
				CanReadProperty("HuyetAp", true);
				return _HuyetAp;
			}
			set 
			{
				CanWriteProperty("HuyetAp", true);
				if (_HuyetAp != value) 
				{
					_HuyetAp = value;
					PropertyHasChanged("HuyetAp");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
     

        public String NhietDo
        {
            get
            {
                CanReadProperty("NhietDo", true);
                return _NhietDo;
            }
            set
            {
                CanWriteProperty("NhietDo", true);
                if (_NhietDo != value)
                {
                    _NhietDo = value;
                    PropertyHasChanged("NhietDo");
                }
            }
        }
       
       
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //TODO: add validation rules

        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "TuNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationThoiGianDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationThoiGianDenNgay<BenhAn_ThuocSD>, "ThoiGian");
        //ValidationRules.AddDependantProperty("TuNgay", "DenNgay");
        //ValidationRules.AddDependantProperty("DenNgay", "ThoiGian");

        //}

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationThoiGianDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._ThoiGian > target._DenNgay)
        //    {
        //        e.Description = "Ngày lĩnh không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationTuNgayDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._TuNgay > target._DenNgay)
        //    {
        //        e.Description = "Từ ngày không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_Mau_CT_T" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_Mau_CT_T NewBenhAn_Mau_CT_T()
        {
            return new BenhAn_Mau_CT_T();
        }
        internal static BenhAn_Mau_CT_T GetBenhAn_Mau_CT_T(SafeDataReader dr, int i)
        {
            return new BenhAn_Mau_CT_T(dr, i);
        }
        public static BenhAn_Mau_CT_T GetBenhAn_Mau_CT_T(String maBA, Int32 sTT, Int32 sTTKhoa,Int32 stttruyen)
        {
            return DataPortal.Fetch<BenhAn_Mau_CT_T>(new Criteria(maBA, sTT, sTTKhoa,stttruyen));
        }
        public BenhAn_Mau_CT_T()
        {
            MarkAsChild();
        }
        //public static BenhAn_Mau_CT_T GetBenhAn_Mau_CT_T(String maBA, Int32 sTT, Int32 sTTKhoa)
        //{
        //    return DataPortal.Fetch<BenhAn_Mau_CT_T>(new Criteria(maBA, sTT, sTTKhoa));
        //}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_Mau_CT_T" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBenhAn_Mau_CT_T(String maBA, Int32 sTT, Int32 sTTKhoa)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT, sTTKhoa));
        //}
		
		#endregion
		
		

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
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
            private Int32 _sTTtruyen;
            public Int32 STTtruyen
            {
                get
                {
                    return _sTTtruyen;
                }
            }
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa,Int32 sttruyen)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
                _sTTtruyen = sttruyen;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString(), _sTTtruyen.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
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
            private Int32 _sTTtruyen;
            public Int32 STTtruyen
            {
                get
                {
                    return _sTTtruyen;
                }
            }
            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, Int32 stttruyen)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTtruyen = stttruyen ;
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
		/// Retrieve an existing <see cref="BenhAn_Mau_CT_T" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Mau_CT_T(crit.MaBA, crit.STT, crit.STTKhoa,crit.STTtruyen )))
            {
                if (dr.Read()){
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
         //<summary>
         //Load a <see cref="BenhAn_Mau_CT_T" /> Object from given SafeDataReader.
         //</summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTTruyen") != null) _STTTruyen = dr.GetInt32("STTTruyen");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
             if (dr.GetSmartDate("ThoiGian", true) != null) _ThoiGian = dr.GetSmartDate("ThoiGian", true);
              if (dr.GetString("TocDo") != null) _TocDo = dr.GetString("TocDo");
             if (dr.GetString("MauSac") != null) _MauSac = dr.GetString("MauSac");
             if (dr.GetString("NhipTho") != null) _NhipTho = dr.GetString("NhipTho");
                if (dr.GetString("Mach") != null) _Mach = dr.GetString("Mach");
            if (dr.GetString("HuyetAp") != null) _HuyetAp = dr.GetString("HuyetAp");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
             if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
             if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
              if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
              if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
             if (dr.GetString("NhietDo") != null) _NhietDo = dr.GetString("NhietDo");
             if (dr.GetString("Khac") != null) _Khac = dr.GetString("Khac");
         
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_Mau_CT_T" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_Mau_CT_T(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTTruyen") != null) _STTTruyen = dr.GetInt32("STTTruyen");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("ThoiGian", true) != null) _ThoiGian = dr.GetSmartDate("ThoiGian", true);
            if (dr.GetString("TocDo") != null) _TocDo = dr.GetString("TocDo");
            if (dr.GetString("MauSac") != null) _MauSac = dr.GetString("MauSac");
            if (dr.GetString("NhipTho") != null) _NhipTho = dr.GetString("NhipTho");
            if (dr.GetString("Mach") != null) _Mach = dr.GetString("Mach");
            if (dr.GetString("HuyetAp") != null) _HuyetAp = dr.GetString("HuyetAp");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("NhietDo") != null) _NhietDo = dr.GetString("NhietDo");
            if (dr.GetString("Khac") != null) _Khac = dr.GetString("Khac");

            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
          _sTT =  DataProvider.Instance().InsertBenhAn_Mau_CT_T(_maBA, _sTT, _sTTKhoa, _ThoiGian,  _TocDo,_MauSac, _NhipTho, _Mach, _HuyetAp,  _maMay, _nguoiSD , _NhietDo,  Khac  );
			// public abstract String InsertBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ThoiGian, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _TocDo, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MauSac, SmartDate _ngayTToan, Boolean _daTra, String _NhipTho, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _Mach, String _HuyetAp, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ThoiGian, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _TocDo, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MauSac, SmartDate _ngayTToan, Boolean _daTra, String _NhipTho, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _Mach, String _HuyetAp, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mau_CT_T_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ThoiGian.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _TocDo, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _NhipTho, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _Mach, _HuyetAp, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_Mau_CT_T" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            DataProvider.Instance().UpdateBenhAn_Mau_CT_T(_maBA, _sTT, _sTTKhoa, _STTTruyen, _ThoiGian, _TocDo, _MauSac , _NhipTho, _Mach, _HuyetAp, _maMay, _huy, _nguoiSD,_NhietDo , Khac);
	   
            // public abstract void UpdateBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ThoiGian, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _TocDo, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MauSac, SmartDate _ngayTToan, Boolean _daTra, String _NhipTho, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _Mach, String _HuyetAp, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ThoiGian, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _TocDo, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MauSac, SmartDate _ngayTToan, Boolean _daTra, String _NhipTho, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _Mach, String _HuyetAp, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mau_CT_T_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ThoiGian.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _TocDo, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _NhipTho, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _Mach, _HuyetAp, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
				// }	
                MarkOld();
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD, _maBA, _sTT, _sTTKhoa, _STTTruyen));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_Mau_CT_T(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.STTtruyen);
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_Mau_CT_T" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Mau_CT_T
        //    DataProvider.Instance().DeleteBenhAn_Mau_CT_T(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mau_CT_T_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
