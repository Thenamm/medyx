// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_PhieuGN
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
    public partial class BenhAn_PhieuGN : BusinessBase<BenhAn_PhieuGN>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaPhieuGN = String.Empty;
		private String _MaKhoa = String.Empty;
        private String _TenKhoa = String.Empty;
        private String _GhiChu = String.Empty;
        private SmartDate _NgayGN = new SmartDate(false);
        private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private Boolean _NoiTru = false;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPhieuGN
        {
			get 
			{
                CanReadProperty("MaPhieuGN", true);
				return _MaPhieuGN;
			}
			set 
			{
                CanWriteProperty("MaPhieuGN", true);
				if (_MaPhieuGN != value) 
				{
                    _MaPhieuGN = value;
                    PropertyHasChanged("MaPhieuGN");
				}
			}
		}
		
		public String MaKhoa
        {
			get 
			{
                CanReadProperty("MaKhoa", true);
				return _MaKhoa;
			}
			set 
			{
                CanWriteProperty("MaKhoa", true);
				if (_MaKhoa != value) 
				{
                    _MaKhoa = value;
                    PropertyHasChanged("MaKhoa");
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
        public SmartDate NgayGN
        {
            get
            {
                CanReadProperty("NgayGN", true);
                _NgayGN.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayGN;
            }
            set
            {
                CanWriteProperty("NgayGN", true);
                if (_NgayGN != value)
                {
                    _NgayGN = value;
                    PropertyHasChanged("NgayGN");
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
        public Boolean NoiTru
        {
            get
            {
                CanReadProperty("NoiTru", true);
                return _NoiTru;
            }
            set
            {
                CanWriteProperty("NoiTru", true);
                if (_NoiTru != value)
                {
                    _NoiTru = value;
                    PropertyHasChanged("NoiTru");
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
			return _MaPhieuGN;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static BenhAn_PhieuGN NewBenhAn_PhieuGN()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new BenhAn_PhieuGN();
        }
		public static BenhAn_PhieuGN GetBenhAn_PhieuGN(String MaPhieuGN)
		{
            return DataPortal.Fetch<BenhAn_PhieuGN>(new Criteria(MaPhieuGN));
		}
		
		/// <summary>
		/// Marks the <see cref="CslaObject" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_PhieuGN(String _MaPhieuGN, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _MaPhieuGN));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_PhieuGN()
		{	
			// Prevent direct creation
		}
		
        internal BenhAn_PhieuGN(int ordernumber, string MaPhieuGN, string MaKhoa, string TenKhoa, string GhiChu, SmartDate NgayGN, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, Boolean NoiTru)
        {
            _OrderNumber = ordernumber;
            _MaPhieuGN  = MaPhieuGN;
            _MaKhoa = MaKhoa;
            _TenKhoa  = TenKhoa;
            _GhiChu = GhiChu;
            _NgayGN = NgayGN;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _NoiTru = NoiTru;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaPhieuGN;
			public String MaPhieuGN 
			{
				get
				{
					return _MaPhieuGN;
				}
			}
			
			public Criteria(String MaPhieuGN)
			{
                _MaPhieuGN = MaPhieuGN;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaPhieuGN.Equals(c._MaPhieuGN)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaPhieuGN.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPhieuGN;
            public String MaPhieuGN
            {
                get
                {
                    return _MaPhieuGN;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPhieuGN)
            {
                _MaPhieuGN = MaPhieuGN;
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
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_PhieuGN(crit.MaPhieuGN)))
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
            if (dr.GetString("MaPhieuGN") != null) _MaPhieuGN = dr.GetString("MaPhieuGN");
            if (dr.GetString("MaKhoa") != null) _MaKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("TenKhoa") != null) _TenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetSmartDate("NgayGN", false) != null) _NgayGN = dr.GetSmartDate("NgayGN", false);
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetBoolean("NoiTru") != null) _NoiTru = dr.GetBoolean("NoiTru");
        }
		
		/// <summary>
		/// Insert the new <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertCslaObject
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _MaPhieuGN = DataProvider.Instance().InsertBenhAn_PhieuGN(_MaKhoa, _GhiChu, _NgayGN, _maMay, _nguoiSD, _NoiTru);
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
                
                  
                DataProvider.Instance().UpdateBenhAn_PhieuGN(_MaPhieuGN, _MaKhoa, _GhiChu, _NgayGN, _maMay, _nguoiSD,_huy, NoiTru);
				// public abstract void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_MaPhieuGN ));
		}

		/// <summary>
		/// Delete the <see cref="CslaObject" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            DataProvider.Instance().DeleteBenhAn_PhieuGN(crit.MaMay, crit.NguoiSD, crit.MaPhieuGN);
			// public abstract void DeleteCslaObject(String _maVungLT);
			// public override void DeleteCslaObject(String _maVungLT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT);
			// }
		}

		#endregion
	}

}
