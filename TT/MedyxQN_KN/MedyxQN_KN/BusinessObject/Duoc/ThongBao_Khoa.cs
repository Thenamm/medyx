// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongBao_Khoa
// Kieu doi tuong  :	ThongBao_Khoa
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

namespace HTC.Business.Duoc
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThongBao_Khoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongBao_Khoa : BusinessBase<ThongBao_Khoa>
	{
		#region Business Methods
		
		#region State Fields
        private Decimal _sTT = 0;
		private String _makhoa = String.Empty;
		private String _mathuoc = String.Empty;
		private SmartDate _NgayYC = new SmartDate(true);
		private String _NoiDung =String.Empty;
        private String _GhiChu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _hoTen = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
     	private Boolean _huy = false;

        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
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
		
		public String Mathuoc
		{
			get 
			{
				CanReadProperty("Mathuoc", true);
				return _mathuoc;
			}
			set 
			{
				CanWriteProperty("Mathuoc", true);
				if (_mathuoc != value) 
				{
					_mathuoc = value;
					PropertyHasChanged("Mathuoc");
				}
			}
		}
		
		public string NgayYC
		{
			get 
			{
				CanReadProperty("NgayYC", true);
				return _NgayYC.Text;
			}
			set 
			{
				CanWriteProperty("NgayYC", true);
				if (_NgayYC.Text != value) 
				{
					_NgayYC.Text = value;
					PropertyHasChanged("NgayYC");
				}
			}
		}

        public string NoiDung
        {
            get
            {
                CanReadProperty("NoiDung", true);
                return _NoiDung;
               
            }
            set
            {
                CanWriteProperty("NoiDung", true);

                if (_NoiDung.ToString() != value)
                {
                    _NoiDung =value;
                    PropertyHasChanged("NoiDung");
                }
            }
        }

        public string GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
               
                    return _GhiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);

                if (_GhiChu.ToString() != value)
                {
                    _GhiChu = value;
                    PropertyHasChanged("GhiChu");
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
			return _makhoa.ToString() + "!" + _mathuoc.ToString().ToString() + "!" + _NgayYC.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThongBao_Khoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static ThongBao_Khoa NewThongBao_Khoa()
        {
            return new ThongBao_Khoa();
        }
        //public static ThongBao_Khoa GetThongBao_Khoa(String makhoa, String mathuoc, SmartDate NgayYC)
        //{
        //    return DataPortal.Fetch<ThongBao_Khoa>(new Criteria(makhoa, mathuoc, NgayYC));
        //}
        internal static ThongBao_Khoa GetThongBao_Khoa(SafeDataReader dr)
        {
            return new ThongBao_Khoa(dr);
        }
        internal static ThongBao_Khoa GetThongBao_Khoa(SafeDataReader dr,int i)
        {
            return new ThongBao_Khoa(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="ThongBao_Khoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteThongBao_Khoa(String makhoa, String mathuoc, SmartDate NgayYC)
        //{
        //    DataPortal.Delete(new Criteria(makhoa, mathuoc, NgayYC));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal ThongBao_Khoa()
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
			
			private String _mathuoc;
			public String Mathuoc 
			{
				get
				{
					return _mathuoc;
				}
			}
			
			private SmartDate _NgayYC;
			public SmartDate NgayYC 
			{
				get
				{
					return _NgayYC;
				}
			}
			
			public Criteria(String makhoa, String mathuoc, SmartDate NgayYC)
			{
				_makhoa = makhoa;
				_mathuoc = mathuoc;
				_NgayYC = NgayYC;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_makhoa.Equals(c._makhoa)) 
						return false;
					if (!_mathuoc.Equals(c._mathuoc)) 
						return false;
					if (!_NgayYC.Equals(c._NgayYC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _makhoa.ToString(), _mathuoc.ToString(), _NgayYC.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="ThongBao_Khoa" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC);
        //    // public override IDataReader GetThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _mathuoc, _NgayYC));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongBao_Khoa(crit.Makhoa, crit.Mathuoc, crit.NgayYC.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="ThongBao_Khoa" /> Object from given SafeDataReader.
		/// </summary>
        /// 
        public ThongBao_Khoa()
        {
            MarkAsChild();
        }
        private ThongBao_Khoa(SafeDataReader dr)
        {
            // Value properties
            MarkAsChild();
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
            if (dr.GetSmartDate("NgayYC", true) != null) _NgayYC = dr.GetSmartDate("NgayYC", true);
            if (dr.GetString("NoiDung") != null) _NoiDung = dr.GetString("NoiDung");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
           
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            MarkOld();
        }

        private ThongBao_Khoa(SafeDataReader dr,int i)
        {
            // Value properties
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
            if (dr.GetSmartDate("NgayYC", true) != null) _NgayYC = dr.GetSmartDate("NgayYC", true);
            if (dr.GetString("NoiDung") != null) _NoiDung = dr.GetString("NoiDung");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");

            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");

            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            MarkOld();
        }
		
		/// <summary>
		/// Insert the new <see cref="ThongBao_Khoa" /> Object to underlying database.
		/// </summary>
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongBao_Khoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			 DataProvider.Instance().InsertThongBao_Khoa(_makhoa, _mathuoc, _NgayYC, _NoiDung, _GhiChu,  _nguoiSD , _maMay);
			// public abstract String InsertThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC, Decimal _NoiDung, Decimal _GhiChu, Decimal _sLX, Decimal _GhiChuT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
			// public override String InsertThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC, Decimal _NoiDung, Decimal _GhiChu, Decimal _sLX, Decimal _GhiChuT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongBao_Khoa_CREATE", _makhoa, _mathuoc, _NgayYC.DBValue, _NoiDung, _GhiChu, _sLX, _GhiChuT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD , _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="ThongBao_Khoa" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongBao_Khoa
            if (!this.IsDirty)
                return;
				DataProvider.Instance().UpdateThongBao_Khoa(_makhoa,_sTT , _mathuoc, _NgayYC, _NoiDung, _GhiChu, _nguoiSD , _maMay, _huy);
				// public abstract void UpdateThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC, Decimal _NoiDung, Decimal _GhiChu, Decimal _sLX, Decimal _GhiChuT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
				// public override void UpdateThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC, Decimal _NoiDung, Decimal _GhiChu, Decimal _sLX, Decimal _GhiChuT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongBao_Khoa_UPDATE", _makhoa, _mathuoc, _NgayYC.DBValue, _NoiDung, _GhiChu, _sLX, _GhiChuT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD , _maMay);
				// }
                MarkOld();
		}
        internal void DeleteSelf(ThongBao_Khoa bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteThongBao_Khoa(bill.Makhoa,_sTT ,_nguoiSD, _maMay);

            MarkNew();
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_makhoa, _mathuoc, _NgayYC));
        //}

        ///// <summary>
        ///// Delete the <see cref="ThongBao_Khoa" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongBao_Khoa
        //    DataProvider.Instance().DeleteThongBao_Khoa(crit.Makhoa, crit.Mathuoc, crit.NgayYC.DBValue);
        //    // public abstract void DeleteThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC);
        //    // public override void DeleteThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _NgayYC);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _mathuoc, _NgayYC);
        //    // }
        //}

		#endregion
	}

}
