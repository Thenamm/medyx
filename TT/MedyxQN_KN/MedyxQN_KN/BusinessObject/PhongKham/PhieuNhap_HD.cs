// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	PhieuNhap_HD
// Kieu doi tuong  :	PhieuNhap_HD
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	9/29/2009 9:33:09 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="PhieuNhap_HD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class PhieuNhap_HD : BusinessBase<PhieuNhap_HD>
	{
		#region Business Methods
		
		#region State Fields
       	private String _MaP = String.Empty;
		private Decimal _tong = 0;
		private SmartDate _ngayThu = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		
		private String _GhiChu = String.Empty;
		
        private String _tenNguoiLap = String.Empty;
      
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
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
       
		public String MaP
		{
			get 
			{
				CanReadProperty("MaP", true);
				return _MaP;
			}
			set 
			{
				CanWriteProperty("MaP", true);
				if (_MaP != value) 
				{
					_MaP = value;
					PropertyHasChanged("MaP");
				}
			}
		}
		
		
		
		public Decimal tong
		{
			get 
			{
				CanReadProperty("tong", true);
				return _tong;
			}
			set 
			{
				CanWriteProperty("tong", true);
				if (_tong != value) 
				{
					_tong = value;
					PropertyHasChanged("tong");
				}
			}
		}
		
	
		
		public string NgayThu
		{
			get 
			{
				CanReadProperty("NgayThu", true);
				return _ngayThu.Text;
			}
			set 
			{
				CanWriteProperty("NgayThu", true);
				if (_ngayThu.Text != value) 
				{
					_ngayThu.Text = value;
					PropertyHasChanged("NgayThu");
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
      
		protected override Object GetIdValue()
		{
			return _MaP.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="PhieuNhap_HD" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static PhieuNhap_HD NewPhieuNhap_HD()
        {
            return new PhieuNhap_HD();
        }
        //public static PhieuNhap_HD GetPhieuNhap_HD(Int32 sTT, String MaP, Int32 sTTKhoa)
        //{
        //    return DataPortal.Fetch<PhieuNhap_HD>(new Criteria(sTT, MaP, sTTKhoa));
        //}
        internal static PhieuNhap_HD GetPhieuNhap_HD(SafeDataReader dr, int i)
        {
            return new PhieuNhap_HD(dr, i);
        }
        //public static PhieuNhap_HD GetPhieuNhap_HD(String MaP, Int32 sTT)
        //{
        //    return DataPortal.Fetch<PhieuNhap_HD>(new Criteria(MaP, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="PhieuNhap_HD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeletePhieuNhap_HD(String MaP, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(MaP, sTT));
        //}
        public PhieuNhap_HD()
        {
            MarkAsChild();
        }
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal PhieuNhap_HD()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaP;
			public String MaP 
			{
				get
				{
					return _MaP;
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
			
			public Criteria(String MaP, Int32 sTT)
			{
				_MaP = MaP;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaP.Equals(c._MaP)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaP.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaP;
            public String MaP
            {
                get
                {
                    return _MaP;
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
           
            public OtherCriteria(String Mamay, String Nguoisd, String MaP, Int32 sTT)
            {
                _MaP = MaP;
                _sTT = sTT;
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
		/// Retrieve an existing <see cref="PhieuNhap_HD" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetPhieuNhap_HD(String _MaP, Int32 _sTT);
        //    // public override IDataReader GetPhieuNhap_HD(String _MaP, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaP, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuNhap_HD(crit.MaP, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="PhieuNhap_HD" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaP") != null) _MaP = dr.GetString("MaP");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
        //    if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
        //    if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
        //    if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
        //    if (dr.GetDecimal("tong") != null) _tong = dr.GetDecimal("tong");
        //    if (dr.GetDecimal("TongChi") != null) _tongChi = dr.GetDecimal("TongChi");
        //    if (dr.GetSmartDate("NgayThu", true) != null) _ngayThu = dr.GetSmartDate("NgayThu", true);
        //    if (dr.GetSmartDate("NgayChi", true) != null) _ngayChi = dr.GetSmartDate("NgayChi", true);
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
        //    if (dr.GetString("NGUOITHU") != null) _nGUOITHU = dr.GetString("NGUOITHU");
        //    if (dr.GetString("NGUOICHI") != null) _nGUOICHI = dr.GetString("NGUOICHI");
        //    if (dr.GetByte("LanIn") != null) _lanIn = dr.GetByte("LanIn");
        //    if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
        //    if (dr.GetString("LYDOChi") != null) _lYDOChi = dr.GetString("LYDOChi");
        //}
		
		/// <summary>
		/// Insert the new <see cref="PhieuNhap_HD" /> Object to underlying database.
		/// </summary>
        /// 

        private PhieuNhap_HD(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaP") != null) _MaP = dr.GetString("MaP");
				if (dr.GetDecimal("tong") != null) _tong = dr.GetDecimal("tong");
			if (dr.GetSmartDate("NgayThu", true) != null) _ngayThu = dr.GetSmartDate("NgayThu", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
			
              MarkOld();
        }

       

		#endregion
	}

}
