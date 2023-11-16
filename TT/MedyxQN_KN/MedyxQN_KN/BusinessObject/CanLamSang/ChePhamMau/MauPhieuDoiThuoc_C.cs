// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	MauPhieuDoiThuoc_C
// Kieu doi tuong  :	MauPhieuDoiThuoc_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 4:04:49 PM
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

namespace HTC.Business.CanLamSang
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="MauPhieuDoiThuoc_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class MauPhieuDoiThuoc_C : BusinessBase<MauPhieuDoiThuoc_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDThuoc = String.Empty;
		private Decimal _sTT = 0;
		private String _macpmau = String.Empty;
		private Decimal _soluong = 0;
		private SmartDate _hanSD = new SmartDate(true);
        private SmartDate _hanSDD = new SmartDate(true);
		private SmartDate _hanSDCu = new SmartDate(true);
        private SmartDate _hanSDCuD = new SmartDate(true);
		private Decimal _donGia = 0;
		private String _soLo = String.Empty;
		private String _soLoCu = String.Empty;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
        public String TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_TonCK == 0)
                    return "0";
                else
                    return _TonCK.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCK", true);
                if (_TonCK.ToString() != value)
                {
                    if (value == "")
                        _TonCK = 0;
                    else
                        _TonCK = decimal.Parse(value);
                    PropertyHasChanged("TonCK");
                }
            }
        }

        public String TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                if (_TonCKDT == 0)
                    return "0";
                else
                    return _TonCKDT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCKDT", true);
                if (_TonCKDT.ToString() != value)
                {
                    _TonCKDT = decimal.Parse(value);
                    PropertyHasChanged("TonCKDT");
                }
            }
        }
		public String MaDThuoc
		{
			get 
			{
				CanReadProperty("MaDThuoc", true);
				return _maDThuoc;
			}
			set 
			{
				CanWriteProperty("MaDThuoc", true);
				if (_maDThuoc != value) 
				{
					_maDThuoc = value;
					PropertyHasChanged("MaDThuoc");
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
		
		public String MaCPMau
		{
			get 
			{
				CanReadProperty("MaCPMau", true);
				return _macpmau;
			}
			set 
			{
				CanWriteProperty("MaCPMau", true);
				if (_macpmau != value) 
				{
					_macpmau = value;
					PropertyHasChanged("MaCPMau");
				}
			}
		}

        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soluong == 0)
                {
                    return "0";
                }
                else
                {
                    return _soluong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soluong.ToString() != value)
                {
                    _soluong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }
        public String HanSDD
        {
            get
            {
                //CanReadProperty("NgayDThuocD", true);
                _hanSDD = _hanSD;
                _hanSDD.FormatString = "dd/MM/yyyy";

                return _hanSDD.Text;
            }

        }
        public String HanSDCuD
        {
            get
            {
                //CanReadProperty("NgayDThuocD", true);
                _hanSDCuD = _hanSDCu ;
                _hanSDCuD.FormatString = "dd/MM/yyyy";

                return _hanSDCuD.Text;
            }

        }
		public string HanSD
		{
			get 
			{
				CanReadProperty("HanSD", true);
				return _hanSD.Text;
			}
			set 
			{
				CanWriteProperty("HanSD", true);
				if (_hanSD.Text != value) 
				{
					_hanSD.Text = value;
					PropertyHasChanged("HanSD");
				}
			}
		}
		
		public string HanSDCu
		{
			get 
			{
				CanReadProperty("HanSDCu", true);
              
				return _hanSDCu.Text;
			}
			set 
			{
				CanWriteProperty("HanSDCu", true);
				if (_hanSDCu.Text != value) 
				{
					_hanSDCu.Text = value;
					PropertyHasChanged("HanSDCu");
				}
			}
		}

        public string DonGia
        {
            get
            {
                CanReadProperty("DonGia", true);
                if (_donGia == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGia.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("DonGia", true);

                if (_donGia.ToString() != value)
                {
                    _donGia = decimal.Parse(value);
                    PropertyHasChanged("DonGia");
                }
            }
        }
		
		public String SoLo
		{
			get 
			{
				CanReadProperty("SoLo", true);
				return _soLo;
			}
			set 
			{
				CanWriteProperty("SoLo", true);
				if (_soLo != value) 
				{
					_soLo = value;
					PropertyHasChanged("SoLo");
				}
			}
		}
		
		public String SoLoCu
		{
			get 
			{
				CanReadProperty("SoLoCu", true);
				return _soLoCu;
			}
			set 
			{
				CanWriteProperty("SoLoCu", true);
				if (_soLoCu != value) 
				{
					_soLoCu = value;
					PropertyHasChanged("SoLoCu");
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
			return _maDThuoc.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="MauPhieuDoiThuoc_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static MauPhieuDoiThuoc_C NewMauPhieuDoiThuoc_C()
        {
            return new MauPhieuDoiThuoc_C();

        }

        public static MauPhieuDoiThuoc_C NewMauPhieuDoiThuoc_C(string idDMChePhamMau)
        {
            return new MauPhieuDoiThuoc_C(DMChePhamMau.GetDMChePhamMau(idDMChePhamMau));
        }

        public static MauPhieuDoiThuoc_C NewMauPhieuDoiThuoc_C(DMChePhamMau _DMChePhamMau)
        {
            return new MauPhieuDoiThuoc_C(_DMChePhamMau);
        }

		public static MauPhieuDoiThuoc_C GetMauPhieuDoiThuoc_C(String maDThuoc, Decimal sTT)
		{
			return DataPortal.Fetch<MauPhieuDoiThuoc_C>(new Criteria(maDThuoc, sTT));
		}

        public static MauPhieuDoiThuoc_C GetMauPhieuDoiThuoc_C(SafeDataReader dr)
        {
            return new MauPhieuDoiThuoc_C(dr);
        }

		/// <summary>
		/// Marks the <see cref="MauPhieuDoiThuoc_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal MauPhieuDoiThuoc_C()
		{	
			// Prevent direct creation
		}
		
        protected MauPhieuDoiThuoc_C(DMChePhamMau pro)
        {
            MarkAsChild();
            _macpmau = pro.MaCPMau;
            _tenTM = pro.TenCPMau;
        }
        protected MauPhieuDoiThuoc_C(string maDThuoc, DMChePhamMau pro)
        {
            MarkAsChild();
            _maDThuoc = maDThuoc;            
            _macpmau = pro.MaCPMau;
            _tenTM = pro.TenCPMau;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
        }
        protected MauPhieuDoiThuoc_C(SafeDataReader dr)
        {
            MarkAsChild();
            _maDThuoc = dr.GetString("MaDThuoc");
            _sTT = dr.GetDecimal("STT");
            _macpmau = dr.GetString("MaCPMau");
            _soluong = dr.GetDecimal("Soluong");
            _hanSD = dr.GetSmartDate("HanSD", false);
            _hanSDCu = dr.GetSmartDate("HanSDCu", false);
            _donGia = dr.GetDecimal("DonGia");
            _soLo = dr.GetString("SoLo");
            _soLoCu = dr.GetString("SoLoCu");
            _huy = dr.GetBoolean("Huy");
            _ghichu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _TonCK = dr.GetDecimal("TonCK");
            _TonCKDT = dr.GetDecimal("TonCKDT");

            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDThuoc;
			public String MaDThuoc 
			{
				get
				{
					return _maDThuoc;
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
			
			public Criteria(String maDThuoc, Decimal sTT)
			{
				_maDThuoc = maDThuoc;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDThuoc.Equals(c._maDThuoc)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDThuoc.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDThuoc;
            public String MaDThuoc
            {
                get
                {
                    return _maDThuoc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaDThuoc, decimal stt)
            {
                _maDThuoc = MaDThuoc;
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
		/// Retrieve an existing <see cref="MauPhieuDoiThuoc_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
			// public override IDataReader GetMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_C_GET", _maDThuoc, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetMauPhieuDoiThuoc_C(crit.MaDThuoc, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="MauPhieuDoiThuoc_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDThuoc") != null) _maDThuoc = dr.GetString("MaDThuoc");
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaCPMau") != null) _macpmau = dr.GetString("MaCPMau");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
			if (dr.GetSmartDate("HanSD", true) != null) _hanSD = dr.GetSmartDate("HanSD", true);
            if (dr.GetSmartDate("HanSD", true) != null) _hanSDD = dr.GetSmartDate("HanSD", true);
			if (dr.GetSmartDate("HanSDCu", true) != null) _hanSDCu = dr.GetSmartDate("HanSDCu", true);
            if (dr.GetSmartDate("HanSDCu", true) != null) _hanSDCuD = dr.GetSmartDate("HanSDCu", true);
			if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
			if (dr.GetString("SoLo") != null) _soLo = dr.GetString("SoLo");
			if (dr.GetString("SoLoCu") != null) _soLoCu = dr.GetString("SoLoCu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");

		}
		
		/// <summary>
		/// Insert the new <see cref="MauPhieuDoiThuoc_C" /> Object to underlying database.
		/// </summary>
        /// 

        protected void DataPortal_Create()
        {

            ValidationRules.CheckRules();
        }
        internal virtual void Insert(MauPhieuDoiThuoc bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertMauPhieuDoiThuoc_C
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            bill.MaDThuoc = DataProvider.Instance().InsertMauPhieuDoiThuoc_C(bill.MaDThuoc, _macpmau, _soluong, _hanSD, _hanSDCu, _donGia, _soLo, _soLoCu, _ghichu, _nguoiSD , _maMay);
			// public abstract String InsertMauPhieuDoiThuoc_C(String _maDThuoc, String _macpmau, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay);
			// public override String InsertMauPhieuDoiThuoc_C(String _maDThuoc, String _macpmau, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_C_CREATE", _maDThuoc, _macpmau, _soluong, _hanSD.DBValue, _hanSDCu.DBValue, _donGia, _soLo, _soLoCu, _ghichu, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="MauPhieuDoiThuoc_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(MauPhieuDoiThuoc bill)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateMauPhieuDoiThuoc_C
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateMauPhieuDoiThuoc_C(bill.MaDThuoc, _sTT, _macpmau, _soluong, _hanSD, _hanSDCu, _donGia, _soLo, _soLoCu, _huy, _ghichu, _nguoiSD , _maMay);
				// public abstract void UpdateMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _macpmau, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
				// public override void UpdateMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _macpmau, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_C_UPDATE", _maDThuoc, _sTT, _macpmau, _soluong, _hanSD.DBValue, _hanSDCu.DBValue, _donGia, _soLo, _soLoCu, _huy, _ghichu, _nguoiSD , _maMay);
				// }				
			}
		}
		

		/// <summary>
		/// Delete the <see cref="MauPhieuDoiThuoc_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateMauPhieuDoiThuoc_C
        //    DataProvider.Instance().DeleteMauPhieuDoiThuoc_C(crit.MaDThuoc, crit.STT);
        //    // public abstract void DeleteMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        //    // public override void DeleteMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_C_DELETED", _maDThuoc, _sTT);
        //    // }
        //}
        internal void DeleteSelf(MauPhieuDoiThuoc packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteMauPhieuDoiThuoc_C(_maMay, _nguoiSD , _maDThuoc, _sTT);
            MarkNew();

        }
		#endregion
	}

}
