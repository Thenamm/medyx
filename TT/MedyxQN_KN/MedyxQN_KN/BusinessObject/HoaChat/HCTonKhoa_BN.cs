// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HCTonKhoa_BN
// Kieu doi tuong  :	HCTonKhoa_BN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/4/2009 9:15:42 AM
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
 //using System.Windows.Forms;

namespace HTC.Business.HoaChat
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HCTonKhoa_BN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HCTonKhoa_BN : BusinessBase<HCTonKhoa_BN>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _makhoa = String.Empty;
		private String _maHC = String.Empty;
		private SmartDate _ngayyclinh = new SmartDate(true);
		private String _mapx = "";
		private Decimal _tonCK = 0;
		private SmartDate _ngayphat = new SmartDate(true);
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _hoTen = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
		
		public String Makhoa
		{
			get 
			{
				CanReadProperty("Makhoa", true);
				return _makhoa;
			}
			set 
			{
				CanWriteProperty("Makhoa", true);
				if (_makhoa != value) 
				{
					_makhoa = value;
					PropertyHasChanged("Makhoa");
				}
			}
		}
		
		public String MaHC
		{
			get 
			{
				CanReadProperty("MaHC", true);
				return _maHC;
			}
			set 
			{
				CanWriteProperty("MaHC", true);
				if (_maHC != value) 
				{
					_maHC = value;
					PropertyHasChanged("MaHC");
				}
			}
		}
		
		public string ngayyclinh
		{
			get 
			{
				CanReadProperty("ngayyclinh", true);
				return _ngayyclinh.Text;
			}
			set 
			{
				CanWriteProperty("ngayyclinh", true);
				if (_ngayyclinh.Text != value) 
				{
					_ngayyclinh.Text = value;
					PropertyHasChanged("ngayyclinh");
				}
			}
		}

        public string mapx
        {
            get
            {
                CanReadProperty("mapx", true);
                
                return _mapx;
               
            }
            set
            {
                CanWriteProperty("mapx", true);

               
                
                if (_mapx != value)
                {
                    _mapx = value;
                    PropertyHasChanged("Mapx");
                }
            }
        }

       

        public string TonCK
		{
			get 
			{
				CanReadProperty("TonCK", true);
                return _tonCK.ToString("###,###.00");
			}
			set 
			{
				CanWriteProperty("TonCK", true);
                if (_tonCK.ToString() != value) 
				{
                    _tonCK = decimal.Parse(value);
					PropertyHasChanged("TonCK");
				}
			}
		}
        
        public string ngayphat
        {
            get
            {
                CanReadProperty("ngayphat", true);
                return _ngayphat.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("ngayphat", true);

                if (_ngayphat.Text != value) 
 
				{
					_ngayphat.Text = value;
                    PropertyHasChanged("ngayphat");
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

        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoTen != value)
                {
                    _hoTen = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }

        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
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

		protected override Object GetIdValue()
		{
			return _makhoa.ToString() + "!" + _maHC.ToString().ToString() + "!" + _ngayyclinh.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HCTonKhoa_BN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HCTonKhoa_BN NewHCTonKhoa_BN()
        {
            return new HCTonKhoa_BN();
        }
        //public static HCTonKhoa_BN GetHCTonKhoa_BN(String makhoa, String maHC, SmartDate ngayyclinh)
        //{
        //    return DataPortal.Fetch<HCTonKhoa_BN>(new Criteria(makhoa, maHC, ngayyclinh));
        //}
        internal static HCTonKhoa_BN GetHCTonKhoa_BN(SafeDataReader dr)
        {
            return new HCTonKhoa_BN(dr);
        }
        internal static HCTonKhoa_BN GetHCTonKhoa_BN(SafeDataReader dr,int i)
        {
            return new HCTonKhoa_BN(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="HCTonKhoa_BN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteHCTonKhoa_BN(String makhoa, String maHC, SmartDate ngayyclinh)
        //{
        //    DataPortal.Delete(new Criteria(makhoa, maHC, ngayyclinh));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal HCTonKhoa_BN()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _makhoa;
			public String Makhoa 
			{
				get
				{
					return _makhoa;
				}
			}
			
			private String _maHC;
			public String MaHC 
			{
				get
				{
					return _maHC;
				}
			}
			
			private SmartDate _ngayyclinh;
			public SmartDate ngayyclinh 
			{
				get
				{
					return _ngayyclinh;
				}
			}
			
			public Criteria(String makhoa, String maHC, SmartDate ngayyclinh)
			{
				_makhoa = makhoa;
				_maHC = maHC;
				_ngayyclinh = ngayyclinh;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_makhoa.Equals(c._makhoa)) 
						return false;
					if (!_maHC.Equals(c._maHC)) 
						return false;
					if (!_ngayyclinh.Equals(c._ngayyclinh)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _makhoa.ToString(), _maHC.ToString(), _ngayyclinh.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="HCTonKhoa_BN" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh);
        //    // public override IDataReader GetHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _maHC, _ngayyclinh));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCTonKhoa_BN(crit.Makhoa, crit.MaHC, crit.ngayyclinh.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="HCTonKhoa_BN" /> Object from given SafeDataReader.
		/// </summary>
        /// 
        public HCTonKhoa_BN()
        {
            MarkAsChild();
        }
        private HCTonKhoa_BN(SafeDataReader dr)
        {
            // Value properties
            MarkAsChild();
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaHC") != null) _maHC = dr.GetString("MaHC");
            if (dr.GetSmartDate("ngayyclinh", true) != null) _ngayyclinh = dr.GetSmartDate("ngayyclinh", true);
            if (dr.GetString("mapx") != null) _mapx = dr.GetString("mapx");
          
			if (dr.GetDecimal("TonCK") != null) _tonCK = dr.GetDecimal("TonCK");
			if (dr.GetSmartDate("ngayphat") != null) _ngayphat = dr.GetSmartDate("ngayphat");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            MarkOld();
        }

        private HCTonKhoa_BN(SafeDataReader dr,int i)
        {
            // Value properties
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaHC") != null) _maHC = dr.GetString("MaHC");
            if (dr.GetSmartDate("ngayyclinh", true) != null) _ngayyclinh = dr.GetSmartDate("ngayyclinh", true);
            if (dr.GetString("mapx") != null) _mapx = dr.GetString("mapx");
            if (dr.GetDecimal("TonCK") != null) _tonCK = dr.GetDecimal("TonCK");
            if (dr.GetSmartDate("ngayphat") != null) _ngayphat = dr.GetSmartDate("ngayphat");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            MarkOld();
        }
		
		/// <summary>
		/// Insert the new <see cref="HCTonKhoa_BN" /> Object to underlying database.
		/// </summary>
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHCTonKhoa_BN
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			 DataProvider.Instance().InsertHCTonKhoa_BN(_makhoa, _maHC, _ngayyclinh, _ngayphat , _tonCK, _nguoiSD , _maMay);
			// public abstract String InsertHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh, Decimal _mapx, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _ngayphat, String _nguoiSD, String _maMay);
			// public override String InsertHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh, Decimal _mapx, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _ngayphat, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonKhoa_BN_CREATE", _makhoa, _maHC, _ngayyclinh.DBValue, _mapx, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _ngayphat, _nguoiSD , _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="HCTonKhoa_BN" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHCTonKhoa_BN
            if (!this.IsDirty)
                return;
				DataProvider.Instance().UpdateHCTonKhoa_BN(_makhoa, _maHC, _ngayyclinh, _ngayphat,  _tonCK,_mapx , _nguoiSD , _maMay);
				// public abstract void UpdateHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh, Decimal _mapx, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _ngayphat, String _nguoiSD, String _maMay);
				// public override void UpdateHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh, Decimal _mapx, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _ngayphat, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonKhoa_BN_UPDATE", _makhoa, _maHC, _ngayyclinh.DBValue, _mapx, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _ngayphat, _nguoiSD , _maMay);
				// }				
                MarkOld();
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_makhoa, _maHC, _ngayyclinh));
        //}

        ///// <summary>
        ///// Delete the <see cref="HCTonKhoa_BN" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHCTonKhoa_BN
        //    DataProvider.Instance().DeleteHCTonKhoa_BN(crit.Makhoa, crit.MaHC, crit.ngayyclinh.DBValue);
        //    // public abstract void DeleteHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh);
        //    // public override void DeleteHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _maHC, _ngayyclinh);
        //    // }
        //}

		#endregion
	}

}
