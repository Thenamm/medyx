// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBPhieuNhap_KP
// Kieu doi tuong  :	TBPhieuNhap_KP
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/12/2009 11:09:15 AM
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

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBPhieuNhap_KP" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBPhieuNhap_KP : BusinessBase<TBPhieuNhap_KP>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPN = String.Empty;
		private String _maTBC = String.Empty;
		private Int32 _sTT = 0;
		private String _maTB = String.Empty;
		private String _maNguon = String.Empty;
		private Decimal _soTien = 0;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
        private String _tenTB = String.Empty;
        private String _tenNguon = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaPN
		{
			get 
			{
				CanReadProperty("MaPN", true);
				return _maPN;
			}
			set 
			{
				CanWriteProperty("MaPN", true);
				if (_maPN != value) 
				{
					_maPN = value;
					PropertyHasChanged("MaPN");
				}
			}
		}
		
		public String MaTBC
		{
			get 
			{
				CanReadProperty("MaTBC", true);
				return _maTBC;
			}
			set 
			{
				CanWriteProperty("MaTBC", true);
				if (_maTBC != value) 
				{
					_maTBC = value;
					PropertyHasChanged("MaTBC");
				}
			}
		}
		
		public Int32 STT
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
		
		public String MaTB
		{
			get 
			{
				CanReadProperty("MaTB", true);
				return _maTB;
			}
			set 
			{
				CanWriteProperty("MaTB", true);
				if (_maTB != value) 
				{
					_maTB = value;
					PropertyHasChanged("MaTB");
				}
			}
		}
		
		public String MaNguon
		{
			get 
			{
				CanReadProperty("MaNguon", true);
				return _maNguon;
			}
			set 
			{
				CanWriteProperty("MaNguon", true);
				if (_maNguon != value) 
				{
					_maNguon = value;
					PropertyHasChanged("MaNguon");
				}
			}
		}
		
        //public Decimal SoTien
        //{
        //    get 
        //    {
        //        CanReadProperty("SoTien", true);
        //        return _soTien;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SoTien", true);
        //        if (_soTien != value) 
        //        {
        //            _soTien = value;
        //            PropertyHasChanged("SoTien");
        //        }
        //    }
        //}
        public string SoTien
        {
            get
            {
                CanReadProperty("SoTien", true);
                if (_soTien == 0)
                {
                    return "0";
                }
                else
                {
                    return _soTien.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("SoTien", true);

                if (_soTien.ToString() != value)
                {
                    _soTien = decimal.Parse(value);
                    PropertyHasChanged("SoTien");
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

        public String TenTB
        {
            get
            {
                CanReadProperty("TenTB", true);
                return _tenTB;
            }
            set
            {
                CanWriteProperty("TenTB", true);
                if (_tenTB != value)
                {
                    _tenTB = value;
                    PropertyHasChanged("TenTB");
                }
            }
        }
        public String TenNguon
        {
            get
            {
                CanReadProperty("TenNguon", true);
                return _tenNguon;
            }
            set
            {
                CanWriteProperty("TenNguon", true);
                if (_tenNguon != value)
                {
                    _tenNguon = value;
                    PropertyHasChanged("TenNguon");
                }
            }
        }
		protected override Object GetIdValue()
		{
            return _maPN.ToString() + "!" + _maTBC.ToString() + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBPhieuNhap_KP" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBPhieuNhap_KP NewTBPhieuNhap_KP()
        {
            return new TBPhieuNhap_KP();

        }
        public static TBPhieuNhap_KP NewTBPhieuNhap_KP(string idDMNguon)
        {
            return new TBPhieuNhap_KP(DMNguon.GetDMNguon(idDMNguon));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static TBPhieuNhap_KP NewTBPhieuNhap_KP(DMNguon _DMNguon)
        {
            return new TBPhieuNhap_KP(_DMNguon);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
		public static TBPhieuNhap_KP GetTBPhieuNhap_KP(String maPN, String maTBC, Int32 sTT)
		{
            return DataPortal.Fetch<TBPhieuNhap_KP>(new Criteria(maPN, maTBC, sTT));
		}
        public static TBPhieuNhap_KP GetTBPhieuNhap_KP(SafeDataReader dr)
        {
            return new TBPhieuNhap_KP(dr);
        }
		/// <summary>
		/// Marks the <see cref="TBPhieuNhap_KP" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBPhieuNhap_KP(String maPN, String maTBC, Int32 sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPN, maTBC, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBPhieuNhap_KP()
		{	
			// Prevent direct creation
		}
		protected TBPhieuNhap_KP(DMNguon pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maNguon = pro.MaNguon;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            _tenNguon  = pro.TenNguon;
            //MarkOld();
        }
        //protected TBPhieuNhap_KP(string _idMaPN, DMTBYT pro)
        //{
        //    MarkAsChild();
        //    _maPN = _idMaPN;
        //    _maTB = pro.MaTB; 
        //    _maMay = pro.MaMay;
        //    _huy = pro.Huy;
        //    _nguoiSD = pro.NguoiSD;
             
        //    //MarkOld();
        //}
        protected TBPhieuNhap_KP(SafeDataReader dr)
        {
            MarkAsChild();
            _maPN = dr.GetString("MaPN");
            _maTBC = dr.GetString("MaTBC");
            _sTT = dr.GetInt32("STT");
            _maTB = dr.GetString("MaTB");
            _maNguon = dr.GetString("MaNguon");
             _soTien = dr.GetDecimal("SoTien");
            _huy = dr.GetBoolean("Huy");
            _ghichu = dr.GetString("Ghichu");
            _ngaySD = dr.GetSmartDate("NgaySD", true);
           _nguoiSD = dr.GetString("NguoiSD");
            _maMay = dr.GetString("MaMay");

            _tenNguon = dr.GetString("TenNguon");

         
          // _OrderNumber = dr.GetByte("STT");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPN;
			public String MaPN 
			{
				get
				{
					return _maPN;
				}
			}
			
			private String _maTBC;
			public String MaTBC 
			{
				get
				{
					return _maTBC;
				}
			}
            private Int32  _STT;
            public Int32 STT
            {
                get
                {
                    return _STT;
                }
            }
            public Criteria(String maPN, String maTBC, Int32 sTT)
			{
				_maPN = maPN;
				_maTBC = maTBC;
                _STT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPN.Equals(c._maPN)) 
						return false;
					if (!_maTBC.Equals(c._maTBC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPN.ToString(), _maTBC.ToString()).GetHashCode();
			}
		}
        [Serializable()]

        protected class OtherCriteria
        {
            private String _maPN;
            public String maPN
            {
                get
                {
                    return _maPN;
                }
            }

            private String _maTBC;
            public String maTBC
            {
                get
                {
                    return _maTBC;
                }
            }
            private Int32 _STT;
            public Int32 STT
            {
                get
                {
                    return _STT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPN, String maTBC, Int32 sTT)
            {
                _maPN = maPN;
                _maTBC = maTBC;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _STT = sTT;
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
		/// Retrieve an existing <see cref="TBPhieuNhap_KP" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBPhieuNhap_KP(String _maPN, String _maTBC);
			// public override IDataReader GetTBPhieuNhap_KP(String _maPN, String _maTBC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPN, _maTBC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBPhieuNhap_KP(crit.MaPN, crit.MaTBC, crit.STT  )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBPhieuNhap_KP" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPN") != null) _maPN = dr.GetString("MaPN");
			if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
			if (dr.GetString("MaNguon") != null) _maNguon = dr.GetString("MaNguon");
			if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenTB") != null) _tenTB = dr.GetString("TenTB");
		}
		
		/// <summary>
		/// Insert the new <see cref="TBPhieuNhap_KP" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(TBPhieuNhap_C bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
           _sTT = DataProvider.Instance().InsertTBPhieuNhap_KP(bill.MaPN, bill.MaTBC, _maTB, _maNguon, _soTien, _ghichu, _nguoiSD , _maMay);
           MarkOld();// public abstract String InsertTBPhieuNhap_KP(String _maPN, String _maTBC, String _maTB, String _maNguon, Decimal _soTien, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
			// public override String InsertTBPhieuNhap_KP(String _maPN, String _maTBC, String _maTB, String _maNguon, Decimal _soTien, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_KP_CREATE", _maPN, _maTBC, _sTT, _maTB, _maNguon, _soTien, _huy, _ghichu, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBPhieuNhap_KP" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(TBPhieuNhap_C bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
				DataProvider.Instance().UpdateTBPhieuNhap_KP(_maPN, _maTBC, _sTT, _maTB, _maNguon, _soTien, _huy, _ghichu, _nguoiSD , _maMay);
				// public abstract void UpdateTBPhieuNhap_KP(String _maPN, String _maTBC, Int32 _sTT, String _maTB, String _maNguon, Decimal _soTien, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
				// public override void UpdateTBPhieuNhap_KP(String _maPN, String _maTBC, Int32 _sTT, String _maTB, String _maNguon, Decimal _soTien, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_KP_UPDATE", _maPN, _maTBC, _sTT, _maTB, _maNguon, _soTien, _huy, _ghichu, _nguoiSD , _maMay);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maPN, _maTBC));
        //}

        ///// <summary>
        ///// Delete the <see cref="TBPhieuNhap_KP" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuNhap_KP
        //    DataProvider.Instance().DeleteTBPhieuNhap_KP(crit.MaPN, crit.MaTBC);
        //    // public abstract void DeleteTBPhieuNhap_KP(String _maPN, String _maTBC);
        //    // public override void DeleteTBPhieuNhap_KP(String _maPN, String _maTBC);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_KP_DELETED", _maPN, _maTBC);
        //    // }
        //}
        internal void DeleteSelf(TBPhieuNhap_C bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteTBPhieuNhap_KP(_maMay, _nguoiSD , bill.MaPN, bill.MaTBC, _sTT );
            MarkNew();
        }
		#endregion
	}

}
