// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_QLHSBAPhieuMuon
// Kieu doi tuong  :	CslaObject
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/27/2008 9:40:15 AM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="CslaObject" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class BenhAn_QLHSBAPhieuMuon : BusinessBase<BenhAn_QLHSBAPhieuMuon>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaPM = String.Empty;
        private SmartDate _NgayMuon = new SmartDate(false);
        private String _NguoiMuon = String.Empty;
        private String _TenNguoiMuon = String.Empty;
        private String _KhoaMuon = String.Empty;
        private String _TenKhoa = String.Empty;
        private String _GhiChu = String.Empty;
        private String _maMay = String.Empty;
		private Boolean _huy = false;
        private SmartDate _NgayLap = new SmartDate(false);
        private String _NguoiLap = String.Empty;
        private String _TenNguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private int _OrderNumber;
        private Boolean _Tra = false;
        #endregion

        #region Business Properties and Methods

        public String MaPM
        {
			get 
			{
                CanReadProperty("MaPM", true);
				return _MaPM;
			}
			set 
			{
                CanWriteProperty("MaPM", true);
				if (_MaPM != value) 
				{
                    _MaPM = value;
                    PropertyHasChanged("MaPM");
				}
			}
		}
        public SmartDate NgayMuon
        {
            get
            {
                CanReadProperty("NgayMuon", true);
                _NgayMuon.FormatString = "dd/MM/yyyy";
                return _NgayMuon;
            }
            set
            {
                CanWriteProperty("NgayMuon", true);
                if (_NgayMuon != value)
                {
                    _NgayMuon = value;
                    PropertyHasChanged("NgayMuon");
                }
            }
        }
        public String NguoiMuon
        {
            get
            {
                CanReadProperty("NguoiMuon", true);
                return _NguoiMuon;
            }
            set
            {
                CanWriteProperty("NguoiMuon", true);
                if (_NguoiMuon != value)
                {
                    _NguoiMuon = value;
                    PropertyHasChanged("NguoiMuon");
                }
            }
        }
        public String TenNguoiMuon
        {
            get
            {
                CanReadProperty("TenNguoiMuon", true);
                return _TenNguoiMuon;
            }
            set
            {
                CanWriteProperty("TenNguoiMuon", true);
                if (_TenNguoiMuon != value)
                {
                    _TenNguoiMuon = value;
                    PropertyHasChanged("TenNguoiMuon");
                }
            }
        }
        public String KhoaMuon
        {
			get 
			{
                CanReadProperty("KhoaMuon", true);
				return _KhoaMuon;
			}
			set 
			{
                CanWriteProperty("KhoaMuon", true);
				if (_KhoaMuon != value) 
				{
                    _KhoaMuon = value;
                    PropertyHasChanged("KhoaMuon");
				}
			}
		}
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _TenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_TenKhoa != value)
                {
                    _TenKhoa = value;
                    PropertyHasChanged("TenKhoa");
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
        public Boolean Tra
        {
            get
            {
                CanReadProperty("Tra", true);
                return _Tra;
            }
            set
            {
                CanWriteProperty("Tra", true);
                if (_Tra != value)
                {
                    _Tra = value;
                    PropertyHasChanged("Tra");
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
        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _NgayLap.FormatString = "dd/MM/yyyy";
                return _NgayLap;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_NgayLap != value)
                {
                    _NgayLap = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }
        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _NguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_NguoiLap != value)
                {
                    _NguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }
        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _TenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_TenNguoiLap != value)
                {
                    _TenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _TenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_TenNguoiSD != value)
                {
                    _TenNguoiSD = value;
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

		protected override Object GetIdValue()
		{
			return _MaPM;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static BenhAn_QLHSBAPhieuMuon NewBenhAn_QLHSBAPhieuMuon()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new BenhAn_QLHSBAPhieuMuon();
        }
		public static BenhAn_QLHSBAPhieuMuon GetBenhAn_QLHSBAPhieuMuon(String MaPM)
		{
            return DataPortal.Fetch<BenhAn_QLHSBAPhieuMuon>(new Criteria(MaPM));
		}
		
		/// <summary>
		/// Marks the <see cref="CslaObject" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_QLHSBAPhieuMuon(String _MaPM, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _MaPM));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_QLHSBAPhieuMuon()
		{	
			// Prevent direct creation
		}
		
        internal BenhAn_QLHSBAPhieuMuon(int ordernumber, string MaPM, SmartDate NgayMuon, string NguoiMuon, string TenNguoiMuon, string KhoaMuon, string TenKhoa, string GhiChu,  string idmay, bool huy, SmartDate ngaylap, string NguoiLap, String TenNguoiLap, SmartDate ngaySD, string NguoiSD, String TenNguoiSD,Boolean Tra)
        {
            _OrderNumber = ordernumber;
            _MaPM  = MaPM;
            _NgayMuon = NgayMuon;
            _NguoiMuon = NguoiMuon;
            _TenNguoiMuon = TenNguoiMuon;
            _KhoaMuon = KhoaMuon;
            _TenKhoa  = TenKhoa;
            _GhiChu = GhiChu;
            _maMay = idmay;
            _huy = huy;
            _NgayLap = ngaylap;
            _NguoiLap = NguoiLap;
            _TenNguoiLap = TenNguoiLap;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _TenNguoiSD = TenNguoiSD;
            _Tra = Tra;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaPM;
			public String MaPM 
			{
				get
				{
					return _MaPM;
				}
			}
			
			public Criteria(String MaPM)
			{
                _MaPM = MaPM;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaPM.Equals(c._MaPM)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaPM.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPM;
            public String MaPM
            {
                get
                {
                    return _MaPM;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPM)
            {
                _MaPM = MaPM;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
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
		/// Retrieve an existing <see cref="CslaObject" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetCslaObject(String _maVungLT);
			// public override IDataReader GetCslaObject(String _maVungLT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_QLHSBAPhieuMuon(crit.MaPM)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="CslaObject" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaPM") != null) _MaPM = dr.GetString("MaPM");
            if (dr.GetSmartDate("NgayMuon", false) != null) _NgayMuon = dr.GetSmartDate("NgayMuon", false);
            if (dr.GetString("NguoiMuon") != null) _NguoiMuon = dr.GetString("NguoiMuon");
            if (dr.GetString("TenNguoiMuon") != null) _TenNguoiMuon = dr.GetString("TenNguoiMuon");
            if (dr.GetString("KhoaMuon") != null) _KhoaMuon = dr.GetString("KhoaMuon");
            if (dr.GetString("TenKhoa") != null) _TenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap", false) != null) _NgayLap = dr.GetSmartDate("NgayLap", false);
            if (dr.GetString("NguoiLap") != null) _NguoiLap = dr.GetString("NguoiLap");
            if (dr.GetString("TenNguoiLap") != null) _TenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetBoolean("Tra") != null) _Tra = dr.GetBoolean("Tra");
        }
		
		/// <summary>
		/// Insert the new <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertCslaObject
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _MaPM = DataProvider.Instance().InsertBenhAn_QLHSBAPhieuMuon(_NgayMuon.Date, _NguoiMuon,_KhoaMuon, _GhiChu, _maMay, _nguoiSD,_Tra);
			// public abstract String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateBenhAn_QLHSBAPhieuMuon(_MaPM, _NgayMuon.Date, _NguoiMuon, _KhoaMuon, _GhiChu,  _maMay, _nguoiSD,_huy,_Tra);
				// public abstract void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_MaPM ));
		}

		/// <summary>
		/// Delete the <see cref="CslaObject" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            DataProvider.Instance().DeleteBenhAn_QLHSBAPhieuMuon(crit.MaMay, crit.NguoiSD, crit.MaPM);
			// public abstract void DeleteCslaObject(String _maVungLT);
			// public override void DeleteCslaObject(String _maVungLT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT);
			// }
		}

		#endregion
	}

}
