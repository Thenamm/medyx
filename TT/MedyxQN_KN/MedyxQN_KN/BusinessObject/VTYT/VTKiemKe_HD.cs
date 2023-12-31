// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	VTKiemKe_HD
// Kieu doi tuong  :	VTKiemKe_HD
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 10:52:51 AM
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

namespace HTC.Business.VTYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="VTKiemKe_HD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class VTKiemKe_HD : BusinessBase<VTKiemKe_HD>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mAKK = String.Empty;
		private Decimal _sTT = 0;
		private String _maVT = String.Empty;
		private SmartDate _hANDUNG = new SmartDate(true);
        private SmartDate _hanSDD = new SmartDate(false);
		private String _solo = String.Empty;
		private Decimal _sOLUONG = 0;
		private Decimal _sLTon = 0;
		private Decimal _sLDC = 0;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _hamLuong = String.Empty;
        private String _tenDVTHL = String.Empty;
        private String _maQL = String.Empty;
        private Decimal _dongia = 0;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MAKK
		{
			get 
			{
				CanReadProperty("MAKK", true);
				return _mAKK;
			}
			set 
			{
				CanWriteProperty("MAKK", true);
				if (_mAKK != value) 
				{
					_mAKK = value;
					PropertyHasChanged("MAKK");
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
		
		public String MaVT
		{
			get 
			{
				CanReadProperty("MaVT", true);
				return _maVT;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_maVT != value) 
				{
					_maVT = value;
					PropertyHasChanged("MaVT");
				}
			}
		}
		
		public string HANDUNG
		{
			get 
			{
				CanReadProperty("HANDUNG", true);
				return _hANDUNG.Text;
			}
			set 
			{
				CanWriteProperty("HANDUNG", true);
				if (_hANDUNG.Text != value) 
				{
					_hANDUNG.Text = value;
					PropertyHasChanged("HANDUNG");
				}
			}
		}
        public String HanSDD
        {
            get
            {
                CanReadProperty("HanSDD", true);



                _hanSDD = _hANDUNG;
                this._hanSDD.FormatString = "dd/MM/yyyy";
                return _hanSDD.Text;
            }
            //set
            //{
            //    CanWriteProperty("HanSDD", true);

            //    if (!_hanSDD.Equals(value))
            //    {
            //        _hanSDD.FormatString = "MM/dd/yyyy";
            //        _hanSDD.Text = value;
            //        PropertyHasChanged("HanSDD");
            //    }
            //}
        }
		
		public String Solo
		{
			get 
			{
				CanReadProperty("Solo", true);
				return _solo;
			}
			set 
			{
				CanWriteProperty("Solo", true);
				if (_solo != value) 
				{
					_solo = value;
					PropertyHasChanged("Solo");
				}
			}
		}
		
        //public Decimal SOLUONG
        //{
        //    get 
        //    {
        //        CanReadProperty("SOLUONG", true);
        //        return _sOLUONG;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SOLUONG", true);
        //        if (_sOLUONG != value) 
        //        {
        //            _sOLUONG = value;
        //            PropertyHasChanged("SOLUONG");
        //        }
        //    }
        //}
        public string SOLUONG
        {
            get
            {
                CanReadProperty("SOLUONG", true);
                if (_sOLUONG == 0)
                {
                    return "0";
                }
                else
                {
                    return _sOLUONG.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SOLUONG", true);

                if (_sOLUONG.ToString() != value)
                {
                    _sOLUONG = decimal.Parse(value);
                    PropertyHasChanged("SOLUONG");
                }
            }
        }
		
		public Decimal SLTon
		{
			get 
			{
				CanReadProperty("SLTon", true);
				return _sLTon;
			}
			set 
			{
				CanWriteProperty("SLTon", true);
				if (_sLTon != value) 
				{
					_sLTon = value;
					PropertyHasChanged("SLTon");
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
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL;
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
			//return _mAKK.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
            return _mAKK.ToString() + "!" + _sTT.ToString();
            //return  _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
           
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNCC", 150));
            //ValidationRules.AddRule<PhieuNhap>(StringRequired<PhieuNhap>, "TenNCC");
            //ValidationRules.AddRule<VTKiemKe_HD>(ValidationDateTT<VTKiemKe_HD>, "HANDUNG");
           // ValidationRules.AddRule<VTKiemKe_HD>(ValidationDateHD<VTKiemKe_HD>, "HANDUNG");
        }
        //private static bool ValidationDateTT<T>(T target, Csla.Validation.RuleArgs e) where T : VTKiemKe_HD
        //{
        //    if (target._hANDUNG < DateTime.Now)
        //    {
        //        e.Description = "Ngày hạn dùng phải lớn hơn ngày hiện tại";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationDateHD<T>(T target, Csla.Validation.RuleArgs e) where T : VTKiemKe_HD
        //{
        //    if (target._hANDUNG.Date.Year < DateTime.Now.Year + 1)
        //    {
        //        e.Description = "Năm hạn dùng phải lớn hơn năm hiện tại 1 năm";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="VTKiemKe_HD" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static VTKiemKe_HD NewVTKiemKe_HD()
        {
            return new VTKiemKe_HD();

        }

        public static VTKiemKe_HD NewVTKiemKe_HD(string idDMVTYT)
        {
            return new VTKiemKe_HD(DMVTYT.GetDMVTYT(idDMVTYT));
        }

        public static VTKiemKe_HD NewVTKiemKe_HD(DMVTYT _DMVTYT)
        {
            return new VTKiemKe_HD(_DMVTYT);
        }
		public static VTKiemKe_HD GetVTKiemKe_HD(String mAKK, Decimal sTT)
		{
			return DataPortal.Fetch<VTKiemKe_HD>(new Criteria(mAKK, sTT));
		}
        public static VTKiemKe_HD GetVTKiemKe_HD(SafeDataReader dr)
        {
            return new VTKiemKe_HD(dr);
        }
        public static VTKiemKe_HD GetVTKiemKe_HD(SafeDataReader dr, int i)
        {
            return new VTKiemKe_HD(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="VTKiemKe_HD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal VTKiemKe_HD()
		{	
			// Prevent direct creation
		}
		protected VTKiemKe_HD(DMVTYT pro)
        {
            MarkAsChild();
            _maVT = pro.MaVT;
            _tenTM = pro.TenTM;
        }
        protected VTKiemKe_HD(string maKK, DMVTYT pro)
        {
            MarkAsChild();
            _mAKK = maKK;            
            _maVT = pro.MaVT;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
        }
        protected VTKiemKe_HD(SafeDataReader dr)
        {
            MarkAsChild();
            _mAKK = dr.GetString("maKK");
            _sTT = dr.GetDecimal("STT");
            _maVT = dr.GetString("MaVT");
            _hANDUNG = dr.GetSmartDate("HANDUNG", false);
            _hanSDD = dr.GetSmartDate("HANDUNG", false);
            _solo = dr.GetString("solo");
            _sOLUONG = dr.GetDecimal("Soluong");
            _sLDC = dr.GetDecimal("SLDC");
            _sLTon = dr.GetDecimal("SLton");
            _huy = dr.GetBoolean("Huy");
            _ghichu = dr.GetString("GhiChu");
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
        protected VTKiemKe_HD(SafeDataReader dr, int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            _mAKK = dr.GetString("maKK");
            _sTT = dr.GetDecimal("STT");
            _maVT = dr.GetString("MaVT");
            _hANDUNG = dr.GetSmartDate("HANDUNG", false);
            _hanSDD = dr.GetSmartDate("HANDUNG", false);
            _solo = dr.GetString("solo");
            _sOLUONG = dr.GetDecimal("Soluong");
            _sLDC = dr.GetDecimal("SLDC");
            _sLTon = dr.GetDecimal("SLton");
            _huy = dr.GetBoolean("Huy");
            _ghichu = dr.GetString("GhiChu");
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
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _mAKK;
			public String MAKK 
			{
				get
				{
					return _mAKK;
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
			
			public Criteria(String mAKK, Decimal sTT)
			{
				_mAKK = mAKK;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_mAKK.Equals(c._mAKK)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _mAKK.ToString(), _sTT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="VTKiemKe_HD" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetVTKiemKe_HD(String _mAKK, Decimal _sTT);
			// public override IDataReader GetVTKiemKe_HD(String _mAKK, Decimal _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spVTKiemKe_HD_GET", _mAKK, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVTKiemKe_HD(crit.MAKK, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="VTKiemKe_HD" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MAKK") != null) _mAKK = dr.GetString("MAKK");
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
			if (dr.GetSmartDate("HANDUNG", true) != null) _hANDUNG = dr.GetSmartDate("HANDUNG", false);
            if (dr.GetSmartDate("HANDUNG", false) != null) _hanSDD = dr.GetSmartDate("HANDUNG", false);
			if (dr.GetString("solo") != null) _solo = dr.GetString("solo");
			if (dr.GetDecimal("SOLUONG") != null) _sOLUONG = dr.GetDecimal("SOLUONG");
			if (dr.GetDecimal("SLTon") != null) _sLTon = dr.GetDecimal("SLTon");
			if (dr.GetDecimal("SLDC") != null) _sLDC = dr.GetDecimal("SLDC");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenDVTHL") != null) _tenDVTHL = dr.GetString("TenDVTHL");
            if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");

		}
		
		/// <summary>
		/// Insert the new <see cref="VTKiemKe_HD" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(VTKiemKe bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertVTKiemKe_HD
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().InsertVTKiemKe_HD(bill.MaKK, _maVT, _hANDUNG, _solo, _sOLUONG, _sLTon, _sLDC, _ghichu,_nguoiSD , _maMay,_dongia);
            MarkOld();// public abstract String InsertVTKiemKe_HD(String _mAKK, String _maVT, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay);
			// public override String InsertVTKiemKe_HD(String _mAKK, String _maVT, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _mAKK, _maVT, _hANDUNG.DBValue, _solo, _sOLUONG, _sLTon, _sLDC, _ghichu,_nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="VTKiemKe_HD" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(VTKiemKe bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVTKiemKe_HD
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateVTKiemKe_HD(bill.MaKK , _sTT, _maVT, _hANDUNG, _solo, _sOLUONG, _sLTon, _sLDC, _ghichu, _huy,_nguoiSD , _maMay,_dongia );
				// public abstract void UpdateVTKiemKe_HD(String _mAKK, Decimal _sTT, String _maVT, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateVTKiemKe_HD(String _mAKK, Decimal _sTT, String _maVT, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spVTKiemKe_HD_UPDATE", _mAKK, _sTT, _maVT, _hANDUNG.DBValue, _solo, _sOLUONG, _sLTon, _sLDC, _ghichu, _huy,_nguoiSD , _maMay);
				// }				
			}
		}
		

		/// <summary>
		/// Delete the <see cref="VTKiemKe_HD" />.
		/// </summary>
		
        internal void DeleteSelf(VTKiemKe packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteVTKiemKe_HD(_maMay,_nguoiSD , _mAKK, _sTT);
            MarkNew();

        }
		#endregion
	}

}
