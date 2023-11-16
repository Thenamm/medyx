// *****************************************************************************************************
//  File nay CNK sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NKPhieuDTNhap_C
// Kieu doi tuong  :	NKPhieuDTNhap_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/12/2009 10:28:35 AM
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
  
namespace HTC.Business.CNK
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NKPhieuDTNhap_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NKPhieuDTNhap_C : BusinessBase<NKPhieuDTNhap_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDuTru = String.Empty;
		private Decimal _sTT = 0;
		private String _mavt = String.Empty;
		private Decimal _soluong = 0;
		private Decimal _donGia = 0;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _maQL = String.Empty;
        private String _hamLuong = String.Empty;
        private String _tenDVTHL = String.Empty;
        private bool _hANDUNG = false;
        private int _OrderNumber;
        private Decimal _thanhTien;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaDuTru
		{
			get 
			{
				CanReadProperty("MaDuTru", true);
				return _maDuTru;
			}
			set 
			{
				CanWriteProperty("MaDuTru", true);
				if (_maDuTru != value) 
				{
					_maDuTru = value;
					PropertyHasChanged("MaDuTru");
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
				return _mavt;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_mavt != value) 
				{
					_mavt = value;
					PropertyHasChanged("MaVT");
				}
			}
		}

        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
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
                CanWriteProperty("Soluong", true);

                if (_soluong.ToString() != value)
                {
                    _soluong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
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

        public String Tennguoisd 
        {
            get
            {
                CanReadProperty("Tennguoisd", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("Tennguoisd", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("Tennguoisd");
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

        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _hANDUNG;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_hANDUNG != value)
                {
                    _hANDUNG = value;
                    PropertyHasChanged("Handung");
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

        public string ThanhTien
        {
            get
            {
                CanReadProperty("ThanhTien", true);
                //  _thanhTien = (_soLuong * _donGia * (100 + _chietKhau)) / 100; 
                return _thanhTien.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("ThanhTien", true);

                if (_thanhTien.ToString() != value)
                {
                    _thanhTien = decimal.Parse(value);
                    PropertyHasChanged("ThanhTien");
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maDuTru.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TENTM", 350));
            ValidationRules.AddRule<NKPhieuDTNhap_C>(StringRequired<NKPhieuDTNhap_C>, "TENTM");
            ValidationRules.AddRule<NKPhieuDTNhap_C>(NumberRequired<NKPhieuDTNhap_C>, "Dongia");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : NKPhieuDTNhap_C
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool NumberRequired<T>(T target, Csla.Validation.RuleArgs e) where T : NKPhieuDTNhap_C
        {
           
              if (Csla.Utilities.IsNumeric(target._donGia) == false)    
                {
                    e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                    return false;
                }
               
              
          
            return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NKPhieuDTNhap_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static NKPhieuDTNhap_C NewNKPhieuDTNhap_C()
        {
            return new NKPhieuDTNhap_C();

        }

        public static NKPhieuDTNhap_C NewNKPhieuDTNhap_C(string idDMCNK)
        {
            return new NKPhieuDTNhap_C(DMCNK.GetDMCNK(idDMCNK));
        }

        public static NKPhieuDTNhap_C NewNKPhieuDTNhap_C(DMCNK _DMCNK)
        {
            return new NKPhieuDTNhap_C(_DMCNK);
        }
		public static NKPhieuDTNhap_C GetNKPhieuDTNhap_C(String maDuTru, Decimal sTT)
		{
			return DataPortal.Fetch<NKPhieuDTNhap_C>(new Criteria(maDuTru, sTT));
		}
        public static NKPhieuDTNhap_C GetNKPhieuDTNhap_C(SafeDataReader dr)
        {
            return new NKPhieuDTNhap_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="NKPhieuDTNhap_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNKPhieuDTNhap_C(String maDuTru, Decimal sTT)
        //{
        //    DataPortal.Delete(new Criteria(maDuTru, sTT));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal NKPhieuDTNhap_C()
		{	
			// Prevent direct creation
		}
		protected NKPhieuDTNhap_C(DMCNK pro)
        {
            MarkAsChild();
            _mavt = pro.MaVT;
            _tenTM = pro.TenTM;
        }
        protected NKPhieuDTNhap_C(string madutru, DMCNK pro)
        {
            MarkAsChild();
            _maDuTru = madutru;            
            _mavt = pro.MaVT;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            //if (pro.ThuocBan == false  )
            //    _donGia = pro.Gianhap ;                    
            //else if (pro.ThuocBan == true) 
            //    _donGia = pro.Gianhap2;
            

        }
        protected NKPhieuDTNhap_C(SafeDataReader dr)
        {
            MarkAsChild();
            _maDuTru = dr.GetString("MaDuTru");
            _sTT = dr.GetDecimal("STT");
            _mavt = dr.GetString("MaVT");
            _soluong = dr.GetDecimal("Soluong");
            _donGia = dr.GetDecimal("DonGia");   
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
            _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong");
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDuTru;
			public String MaDuTru 
			{
				get
				{
					return _maDuTru;
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
			
			public Criteria(String maDuTru, Decimal sTT)
			{
				_maDuTru = maDuTru;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDuTru.Equals(c._maDuTru)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDuTru.ToString(), _sTT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="NKPhieuDTNhap_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT);
			// public override IDataReader GetNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDuTru, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNKPhieuDTNhap_C(crit.MaDuTru, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="NKPhieuDTNhap_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDuTru") != null) _maDuTru = dr.GetString("MaDuTru");
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaVT") != null) _mavt = dr.GetString("MaVT");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
			if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
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
		/// Insert the new <see cref="NKPhieuDTNhap_C" /> Object to underlying database.
		/// </summary>
        /// 
        protected void DataPortal_Create()
        {

            ValidationRules.CheckRules();
        }
        internal virtual void Insert(NKPhieuDTNhap bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNKPhieuDTNhap_C
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            bill.MaDuTru = DataProvider.Instance().InsertNKPhieuDTNhap_C(bill.MaDuTru, _mavt, _soluong, _donGia, _ghichu, _nguoiSD, _maMay);
            MarkOld();	// public abstract String InsertNKPhieuDTNhap_C(String _maDuTru, String _mavt, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
			// public override String InsertNKPhieuDTNhap_C(String _maDuTru, String _mavt, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKPhieuDTNhap_C_CREATE", _maDuTru, _mavt, _soluong, _donGia, _ghichu, _nguoiSD, _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NKPhieuDTNhap_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(NKPhieuDTNhap bill)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKPhieuDTNhap_C
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateNKPhieuDTNhap_C(bill.MaDuTru , _sTT, _mavt, _soluong, _donGia, _huy, _ghichu, _nguoiSD, _maMay);
				// public abstract void UpdateNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mavt, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
				// public override void UpdateNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mavt, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKPhieuDTNhap_C_UPDATE", _maDuTru, _sTT, _mavt, _soluong, _donGia, _huy, _ghichu, _nguoiSD, _maMay);
				// }				
			}
		}
		

		/// <summary>
		/// Delete the <see cref="NKPhieuDTNhap_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKPhieuDTNhap_C
        //    DataProvider.Instance().DeleteNKPhieuDTNhap_C(crit.MaDuTru, crit.STT);
        //    // public abstract void DeleteNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT);
        //    // public override void DeleteNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKPhieuDTNhap_C_DELETED", _maDuTru, _sTT);
        //    // }
        //}
        internal void DeleteSelf(NKPhieuDTNhap packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteNKPhieuDTNhap_C(_maMay, _nguoiSD, _maDuTru, _sTT);
            MarkNew();

        }
		#endregion
	}

}
