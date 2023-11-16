// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KiemKe_C
// Kieu doi tuong  :	KiemKe_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 10:11:21 AM
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
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KiemKe_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KiemKe_C : BusinessBase<KiemKe_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maKK = String.Empty;
		private Decimal _sTT = 0;
		private String _maThuoc = String.Empty;
		private Decimal _soLuong = 0;
		private Decimal _dongia = 0;
		private Decimal _sLDC = 0;
		private String _ghiChu = String.Empty;
		private Decimal _sLton = 0;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _hamLuong = String.Empty;
        private String _tenDVTHL = String.Empty;
        private String _maQL = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods

        public string ThanhTien
        {
            get
            {
               
                //  _thanhTien = (_soLuong * _donGia * (100 + _chietKhau)) / 100; 
                return (_soLuong * _dongia ).ToString("###,###.00");
            }
           
        }

		public String MaKK
		{
			get 
			{
				CanReadProperty("MaKK", true);
				return _maKK;
			}
			set 
			{
				CanWriteProperty("MaKK", true);
				if (_maKK != value) 
				{
					_maKK = value;
					PropertyHasChanged("MaKK");
				}
			}
		}
		
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
		
		public String MaThuoc
		{
			get 
			{
				CanReadProperty("MaThuoc", true);
				return _maThuoc;
			}
			set 
			{
				CanWriteProperty("MaThuoc", true);
				if (_maThuoc != value) 
				{
					_maThuoc = value;
					PropertyHasChanged("MaThuoc");
				}
			}
		}
		
        //public Decimal SoLuong
        //{
        //    get 
        //    {
        //        CanReadProperty("SoLuong", true);
        //        return _soLuong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SoLuong", true);
        //        if (_soLuong != value) 
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                    return "0";
                else if (_soLuong - (int)(_soLuong) != 0)
                    return _soLuong.ToString("###,###.###");
                else
                    return _soLuong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }
		
        //public Decimal Dongia
        //{
        //    get 
        //    {
        //        CanReadProperty("Dongia", true);
        //        return _dongia;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Dongia", true);
        //        if (_dongia != value) 
        //        {
        //            _dongia = value;
        //            PropertyHasChanged("Dongia");
        //        }
        //    }
        //}
        public string Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                if (_dongia == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongia.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("Dongia", true);

                if (_dongia.ToString() != value)
                {
                    _dongia = decimal.Parse(value);
                    PropertyHasChanged("Dongia");
                }
            }
        }
		
		public Decimal SLDC
		{
			get 
			{
				CanReadProperty("SLDC", true);
				return _sLDC;
			}
			set 
			{
				CanWriteProperty("SLDC", true);
				if (_sLDC != value) 
				{
					_sLDC = value;
					PropertyHasChanged("SLDC");
				}
			}
		}
		
		public String GhiChu
		{
			get 
			{
				CanReadProperty("GhiChu", true);
				return _ghiChu;
			}
			set 
			{
				CanWriteProperty("GhiChu", true);
				if (_ghiChu != value) 
				{
					_ghiChu = value;
					PropertyHasChanged("GhiChu");
				}
			}
		}
		
		public Decimal SLton
		{
			get 
			{
				CanReadProperty("SLton", true);
				return _sLton;
			}
			set 
			{
				CanWriteProperty("SLton", true);
				if (_sLton != value) 
				{
					_sLton = value;
					PropertyHasChanged("SLton");
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
        public String TenDVTHL
        {
            get
            {
                CanReadProperty("TenDVTHL", true);
                return _tenDVTHL;
            }
            set
            {
                CanWriteProperty("TenDVTHL", true);
                if (_tenDVTHL != value)
                {
                    _tenDVTHL = value;
                    PropertyHasChanged("TenDVTHL");
                }
            }
        }
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL ;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_maQL != value)
                {
                    _maQL = value;
                    PropertyHasChanged("MaQL");
                }
            }
        }
        public String HamLuong
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamLuong;
            }
            set
            {
                CanWriteProperty("HamLuong", true);
                if (_hamLuong != value)
                {
                    _hamLuong = value;
                    PropertyHasChanged("HamLuong");
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
			//return _maKK.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
            return _maKK.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KiemKe_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KiemKe_C NewKiemKe_C()
        {
            return new KiemKe_C();

        }

        public static KiemKe_C NewKiemKe_C(string idDMThuoc)
        {
            return new KiemKe_C(DMThuoc.GetDMThuoc(idDMThuoc));
        }

        public static KiemKe_C NewKiemKe_C(DMThuoc _DMThuoc)
        {
            return new KiemKe_C(_DMThuoc);
        }
		public static KiemKe_C GetKiemKe_C(String maKK, Decimal sTT)
		{
			return DataPortal.Fetch<KiemKe_C>(new Criteria(maKK, sTT));
		}
        public static KiemKe_C GetKiemKe_C(SafeDataReader dr)
        {
            return new KiemKe_C(dr);
        }
        public static KiemKe_C GetKiemKe_C(SafeDataReader dr, int i)
        {
            return new KiemKe_C(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="KiemKe_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKiemKe_C(String maKK, Decimal sTT)
        {
            DataPortal.Delete(new Criteria(maKK, sTT));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KiemKe_C()
		{	
			// Prevent direct creation
		}
		protected KiemKe_C(DMThuoc pro)
        {
            MarkAsChild();
            _maThuoc = pro.MaThuoc;
            _tenTM = pro.TenTM;
        }
        protected KiemKe_C(string maKK, DMThuoc pro)
        {
            MarkAsChild();
            _maKK = maKK;            
            _maThuoc = pro.MaThuoc;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
        }
        protected KiemKe_C(SafeDataReader dr)
        {
            MarkAsChild();
          
            _maKK = dr.GetString("maKK");
            _sTT = dr.GetDecimal("STT");
            _maThuoc = dr.GetString("MaThuoc");
            _soLuong = dr.GetDecimal("Soluong");
            _dongia = dr.GetDecimal("DonGia");
            _sLDC = dr.GetDecimal("SLDC");
            _sLton = dr.GetDecimal("SLton");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _hamLuong = dr.GetString("HamLuong");
            _tenDVTHL = dr.GetString("TenDVTHL");
            _maQL = dr.GetString("MaQL");
            MarkOld();
        }
        protected KiemKe_C(SafeDataReader dr, int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            _maKK = dr.GetString("maKK");
            _sTT = dr.GetDecimal("STT");
            _maThuoc = dr.GetString("MaThuoc");
            _soLuong = dr.GetDecimal("Soluong");
            _dongia = dr.GetDecimal("DonGia");
            _sLDC = dr.GetDecimal("SLDC");
            _sLton = dr.GetDecimal("SLton");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _hamLuong = dr.GetString("HamLuong");
            _tenDVTHL = dr.GetString("TenDVTHL");
            _maQL = dr.GetString("MaQL");
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKK;
			public String MaKK 
			{
				get
				{
					return _maKK;
				}
			}
			
			private Decimal _sTT;
			public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maKK, Decimal sTT)
			{
				_maKK = maKK;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maKK.Equals(c._maKK)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maKK.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maKK;
            public String MaKK
            {
                get
                {
                    return _maKK;
                }
            }

            private Decimal _sTT;
            public Decimal STT
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaKK, decimal stt)
            {
                _maKK = MaKK;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = stt;
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
		/// Retrieve an existing <see cref="KiemKe_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKiemKe_C(String _maKK, Decimal _sTT);
			// public override IDataReader GetKiemKe_C(String _maKK, Decimal _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKIEMKE_C_GET", _maKK, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKiemKe_C(crit.MaKK, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KiemKe_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKK") != null) _maKK = dr.GetString("MaKK");
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("maThuoc") != null) _maThuoc = dr.GetString("maThuoc");
			if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
			if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
			if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetDecimal("SLton") != null) _sLton = dr.GetDecimal("SLton");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenDVTHL") != null) _tenDVTHL = dr.GetString("TenDVTHL");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
		}
		
		/// <summary>
		/// Insert the new <see cref="KiemKe_C" /> Object to underlying database.
		/// </summary>
        /// 
        protected void DataPortal_Create()
        {
           
            ValidationRules.CheckRules();
        }
        internal virtual void Insert(KiemKe  bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKiemKe_C
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().InsertKiemKe_C(bill.MaKK, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _nguoiSD , _maMay);
            MarkOld();
            // public abstract String InsertKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay);
			// public override String InsertKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKIEMKE_C_CREATE", _maKK, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _nguoiSD , _maMay));
			// }
		}
        internal virtual void Insert(KiemKeDT bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKiemKe_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().InsertKiemKe_C(bill.MaKK, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _nguoiSD , _maMay);
            MarkOld();
            // public abstract String InsertKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay);
            // public override String InsertKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKIEMKE_C_CREATE", _maKK, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _nguoiSD , _maMay));
            // }
        }
		
		/// <summary>
		/// Update all changes made on <see cref="KiemKe_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KiemKe bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKiemKe_C
			if (IsDirty){
                
                  
                _maKK = bill.MaKK;
                DataProvider.Instance().UpdateKiemKe_C(bill.MaKK, _sTT, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _huy, _nguoiSD , _maMay);
				// public abstract void UpdateKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKIEMKE_C_UPDATE", _maKK, _sTT, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _huy, _nguoiSD , _maMay);
				// }				
			}
		}
        internal virtual void Update(KiemKeDT bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKiemKe_C
            if (IsDirty)
            {
                
                  
                _maKK = bill.MaKK;
                DataProvider.Instance().UpdateKiemKe_C(bill.MaKK, _sTT, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _huy, _nguoiSD , _maMay);
                // public abstract void UpdateKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay);
                // public override void UpdateKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKIEMKE_C_UPDATE", _maKK, _sTT, _maThuoc, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _huy, _nguoiSD , _maMay);
                // }				
            }
        }
		/// <summary>
		/// Delete the <see cref="KiemKe_C" />.
		/// </summary>
		
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKiemKe_C
			//DataProvider.Instance().DeleteKiemKe_C(crit.MaKK, crit.STT);
			// public abstract void DeleteKiemKe_C(String _maKK, Decimal _sTT);
			// public override void DeleteKiemKe_C(String _maKK, Decimal _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKIEMKE_C_DELETED", _maKK, _sTT);
			// }
		
        internal void DeleteSelf(KiemKe  packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteKiemKe_C(_maMay, _nguoiSD , _maKK, _sTT);
            MarkNew();

        }
        internal void DeleteSelf(KiemKeDT packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteKiemKe_C(_maMay, _nguoiSD , _maKK, _sTT);
            MarkNew();

        }
		#endregion
	}

}
