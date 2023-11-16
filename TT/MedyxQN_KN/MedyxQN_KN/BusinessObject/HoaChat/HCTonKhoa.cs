// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HCTonKhoa
// Kieu doi tuong  :	HCTonKhoa
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
	/// This is a base generated class of <see cref="HCTonKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HCTonKhoa : BusinessBase<HCTonKhoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _makhoa = String.Empty;
		private String _mahc = String.Empty;
		private SmartDate _thang = new SmartDate(true);
		private Decimal _soDK = 0;
		private decimal _sLN = 0;
		private Decimal _sLX = 0;
		private Decimal _sLNT = 0;
		private Decimal _sLXT = 0;
		private Decimal _sLDC = 0;
		private Decimal _tonCK = 0;
		private Decimal _giaNhap = 0;
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
				return _mahc;
			}
			set 
			{
				CanWriteProperty("MaHC", true);
				if (_mahc != value) 
				{
					_mahc = value;
					PropertyHasChanged("MaHC");
				}
			}
		}
		
		public string Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang.Text;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang.Text != value) 
				{
					_thang.Text = value;
					PropertyHasChanged("Thang");
				}
			}
		}

        public string SoDK
        {
            get
            {
                CanReadProperty("SoDK", true);
                return _soDK.ToString("###,###.00");
               
            }
            set
            {
                CanWriteProperty("SoDK", true);

                if (_soDK.ToString() != value)
                {
                    _soDK = decimal.Parse(value);
                    PropertyHasChanged("SoDK");
                }
            }
        }

        public string SLN
        {
            get
            {
                CanReadProperty("SLN", true);
               
                    return _sLN.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("SLN", true);

                if (_sLN.ToString() != value)
                {
                    _sLN = decimal.Parse(value);
                    PropertyHasChanged("SLN");
                }
            }
        }

        public string SLX
        {
            get
            {
                CanReadProperty("SLX", true);
               
                    return _sLX.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("SLX", true);

                if (_sLX.ToString() != value)
                {
                    _sLX = decimal.Parse(value);
                    PropertyHasChanged("SLX");
                }
            }
        }

        public string SLNT
        {
            get
            {
                CanReadProperty("SLNT", true);
                
                    return _sLNT.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("SLNT", true);

                if (_sLNT.ToString() != value)
                {
                    _sLNT = decimal.Parse(value);
                    PropertyHasChanged("SLNT");
                }
            }
        }

        public string SLXT
        {
            get
            {
                CanReadProperty("SLXT", true);
                
                    return _sLXT.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("SLXT", true);

                if (_sLXT.ToString() != value)
                {
                    _sLXT = decimal.Parse(value);
                    PropertyHasChanged("SLXT");
                }
            }
        }

        public string SLDC
        {
            get
            {
                CanReadProperty("SLDC", true);
                
                    return _sLDC.ToString("###,###.00");
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

        public string TonCK
		{
			get 
			{
				CanReadProperty("TonCK", true);
                _tonCK = _soDK + _sLN + _sLDC - _sLX;
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
        
        public string GiaNhap
        {
            get
            {
                CanReadProperty("GiaNhap", true);
                return _giaNhap.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("GiaNhap", true);

                if (_giaNhap.ToString() != value)
                {
                    _giaNhap = decimal.Parse(value);
                    PropertyHasChanged("GiaNhap");
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
			return _makhoa.ToString() + "!" + _mahc.ToString().ToString() + "!" + _thang.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HCTonKhoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HCTonKhoa NewHCTonKhoa()
        {
            return new HCTonKhoa();
        }
        //public static HCTonKhoa GetHCTonKhoa(String makhoa, String MaHC, SmartDate thang)
        //{
        //    return DataPortal.Fetch<HCTonKhoa>(new Criteria(makhoa, MaHC, thang));
        //}
        internal static HCTonKhoa GetHCTonKhoa(SafeDataReader dr)
        {
            return new HCTonKhoa(dr);
        }
        internal static HCTonKhoa GetHCTonKhoa(SafeDataReader dr,int i)
        {
            return new HCTonKhoa(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="HCTonKhoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteHCTonKhoa(String makhoa, String MaHC, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(makhoa, MaHC, thang));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal HCTonKhoa()
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
			
			private String _mahc;
			public String MaHC 
			{
				get
				{
					return _mahc;
				}
			}
			
			private SmartDate _thang;
			public SmartDate Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			public Criteria(String makhoa, String MaHC, SmartDate thang)
			{
				_makhoa = makhoa;
				_mahc = MaHC;
				_thang = thang;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_makhoa.Equals(c._makhoa)) 
						return false;
					if (!_mahc.Equals(c._mahc)) 
						return false;
					if (!_thang.Equals(c._thang)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _makhoa.ToString(), _mahc.ToString(), _thang.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="HCTonKhoa" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang);
        //    // public override IDataReader GetHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _mahc, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCTonKhoa(crit.Makhoa, crit.MaHC, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="HCTonKhoa" /> Object from given SafeDataReader.
		/// </summary>
        /// 
        public HCTonKhoa()
        {
            MarkAsChild();
        }
        private HCTonKhoa(SafeDataReader dr)
        {
            // Value properties
            MarkAsChild();
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaHC") != null) _mahc = dr.GetString("MaHC");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetDecimal("SoDK") != null) _soDK = dr.GetDecimal("SoDK");
            if (dr.GetDecimal("SLN") != null) _sLN = dr.GetDecimal("SLN");
			if (dr.GetDecimal("SLX") != null) _sLX = dr.GetDecimal("SLX");
			if (dr.GetDecimal("SLNT") != null) _sLNT = dr.GetDecimal("SLNT");
			if (dr.GetDecimal("SLXT") != null) _sLXT = dr.GetDecimal("SLXT");
			if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
			if (dr.GetDecimal("TonCK") != null) _tonCK = dr.GetDecimal("TonCK");
			if (dr.GetDecimal("GiaNhap") != null) _giaNhap = dr.GetDecimal("GiaNhap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            MarkOld();
        }

        private HCTonKhoa(SafeDataReader dr,int i)
        {
            // Value properties
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaHC") != null) _mahc = dr.GetString("MaHC");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetDecimal("SoDK") != null) _soDK = dr.GetDecimal("SoDK");
            try
            {
                if (dr.GetDecimal("SLN") != null) _sLN = dr.GetDecimal("SLN");

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);

            }
            if (dr.GetDecimal("SLX") != null) _sLX = dr.GetDecimal("SLX");
            if (dr.GetDecimal("SLNT") != null) _sLNT = dr.GetDecimal("SLNT");
            if (dr.GetDecimal("SLXT") != null) _sLXT = dr.GetDecimal("SLXT");
            if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
            if (dr.GetDecimal("TonCK") != null) _tonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("GiaNhap") != null) _giaNhap = dr.GetDecimal("GiaNhap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            MarkOld();
        }
		
		/// <summary>
		/// Insert the new <see cref="HCTonKhoa" /> Object to underlying database.
		/// </summary>
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHCTonKhoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			 DataProvider.Instance().InsertHCTonKhoa(_makhoa, _mahc, _thang, _soDK, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD , _maMay);
			// public abstract String InsertHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
			// public override String InsertHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonKhoa_CREATE", _makhoa, _mahc, _thang.DBValue, _soDK, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD , _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="HCTonKhoa" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHCTonKhoa
            if (!this.IsDirty)
                return;
				DataProvider.Instance().UpdateHCTonKhoa(_makhoa, _mahc, _thang, _soDK, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD , _maMay);
				// public abstract void UpdateHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
				// public override void UpdateHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonKhoa_UPDATE", _makhoa, _mahc, _thang.DBValue, _soDK, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD , _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf(HCTonKhoa  bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteHCTonKhoa(bill._makhoa, bill._mahc, bill._thang ,_nguoiSD,_maMay);
          
             MarkNew();
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new Criteria(_makhoa, _mahc, _thang));
        }

        ///// <summary>
        ///// Delete the <see cref="HCTonKhoa" />.
        ///// </summary>
        protected void DataPortal_Delete(Criteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHCTonKhoa
            DataProvider.Instance().DeleteHCTonKhoa(crit.Makhoa, crit.MaHC, crit.Thang,_nguoiSD , _maMay );
            // public abstract void DeleteHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang);
            // public override void DeleteHCTonKhoa(String _makhoa, String _mahc, SmartDate _thang);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _mahc, _thang);
            // }
        }

		#endregion
	}

}
