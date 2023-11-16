// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_HDChiDaoTuyenB
// Kieu doi tuong  :	BC_HDChiDaoTuyenB
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 9:48:33 AM
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

namespace HTC.Business.KHTH
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BC_HDChiDaoTuyenB" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_HDChiDaoTuyenB : BusinessBase<BC_HDChiDaoTuyenB>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private Int32 _sTT = 0;
		private String _tenDeTai = String.Empty;
		private decimal  _kinhPhi;
		private Int32 _sLCapNN ;
		private Int32 _sLCapBo ;
		private Int32 _sLCapCoSo ;
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaBC
		{
			get 
			{
				CanReadProperty("MaBC", true);
				return _maBC;
			}
			set 
			{
				CanWriteProperty("MaBC", true);
				if (_maBC != value) 
				{
					_maBC = value;
					PropertyHasChanged("MaBC");
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
		
		public String TenDeTai
		{
			get 
			{
				CanReadProperty("TenDeTai", true);
				return _tenDeTai;
			}
			set 
			{
				CanWriteProperty("TenDeTai", true);
				if (_tenDeTai != value) 
				{
					_tenDeTai = value;
					PropertyHasChanged("TenDeTai");
				}
			}
		}
		
		public string  KinhPhi
        {
            get
            {
                CanReadProperty("KinhPhi", true);
                if (_kinhPhi == 0)
                {
                    return "";
                }
                else
                {
                    return _kinhPhi.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("KinhPhi", true);

                if (_kinhPhi.ToString() != value)
                {
                    if (value == "")
                        _kinhPhi = 0;
                    else
                        _kinhPhi = decimal  .Parse(value.Replace(",", ""));
                    PropertyHasChanged("KinhPhi");
                }
            }
        }
		public string  SLCapNN
        {
            get
            {
                CanReadProperty("SLCapNN", true);
                if (_sLCapNN == 0)
                {
                    return "";
                }
                else
                {
                    return _sLCapNN.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLCapNN", true);

                if (_sLCapNN.ToString() != value)
                {
                    if (value == "")
                        _sLCapNN = 0;
                    else
                        _sLCapNN = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLCapNN");
                }
            }
        }
		
		public string  SLCapBo
        {
            get
            {
                CanReadProperty("SLCapBo", true);
                if (_sLCapBo == 0)
                {
                    return "";
                }
                else
                {
                    return _sLCapBo.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLCapBo", true);

                if (_sLCapBo.ToString() != value)
                {
                    if (value == "")
                        _sLCapBo = 0;
                    else
                        _sLCapBo = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLCapBo");
                }
            }
        }
		public string  SLCapCoSo
        {
            get
            {
                CanReadProperty("SLCapCoSo", true);
                if (_sLCapCoSo == 0)
                {
                    return "";
                }
                else
                {
                    return _sLCapCoSo.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLCapCoSo", true);

                if (_sLCapCoSo.ToString() != value)
                {
                    if (value == "")
                        _sLCapCoSo = 0;
                    else
                        _sLCapCoSo = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLCapCoSo");
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
		
		public string Ngaysd
		{
			get 
			{
				CanReadProperty("Ngaysd", true);
                _ngaysd.FormatString = "dd/MM/yyyy HH:mm";
				return _ngaysd.Text;
			}
			set 
			{
				CanWriteProperty("Ngaysd", true);
				if (_ngaysd.Text != value) 
				{
					_ngaysd.Text = value;
					PropertyHasChanged("Ngaysd");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maBC.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_HDChiDaoTuyenB" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_HDChiDaoTuyenB GetBC_HDChiDaoTuyenB(String maBC, Int32 sTT)
        //{
        //    return DataPortal.Fetch<BC_HDChiDaoTuyenB>(new Criteria(maBC, sTT));
        //}

        public static BC_HDChiDaoTuyenB NewBC_HDChiDaoTuyenB()
        {
            return new BC_HDChiDaoTuyenB();
            //return DataPortal.Create<BC_HDChiDaoTuyenB>();
        }

        internal static BC_HDChiDaoTuyenB GetBC_HDChiDaoTuyenB(SafeDataReader dr, int i)
        {
            return new BC_HDChiDaoTuyenB(dr,i);
        }

		/// <summary>
		/// Marks the <see cref="BC_HDChiDaoTuyenB" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_HDChiDaoTuyenB(String maBC, Int32 sTT)
		{
			DataPortal.Delete(new Criteria(maBC, sTT));
		}
        public BC_HDChiDaoTuyenB()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_HDChiDaoTuyenB()
        //{	
        //    // Prevent direct creation
        //}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBC;
			public String MaBC 
			{
				get
				{
					return _maBC;
				}
			}
			
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maBC, Int32 sTT)
			{
				_maBC = maBC;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaOther
        {
            private String _maBC;
            public String MaBC
            {
                get
                {
                    return _maBC;
                }
            }

            private int _STT;
            public int STT
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, int STT)
            {
                _maBC = maBC;
                _STT  = STT ;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
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
		/// Retrieve an existing <see cref="BC_HDChiDaoTuyenB" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT);
        //    // public override IDataReader GetBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_HDChiDaoTuyenB(crit.MaBC, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_HDChiDaoTuyenB" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("TenDeTai") != null) _tenDeTai = dr.GetString("TenDeTai");
        //    if (dr.GetDecimal("KinhPhi") != null) _kinhPhi = dr.GetDecimal("KinhPhi");
        //    if (dr.GetInt32("SLCapNN") != null) _sLCapNN = dr.GetInt32("SLCapNN");
        //    if (dr.GetInt32("SLCapBo") != null) _sLCapBo = dr.GetInt32("SLCapBo");
        //    if (dr.GetInt32("SLCapCoSo") != null) _sLCapCoSo = dr.GetInt32("SLCapCoSo");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //}
		private BC_HDChiDaoTuyenB(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("TenDeTai") != null) _tenDeTai = dr.GetString("TenDeTai");
            if (dr.GetDecimal("KinhPhi") != null) _kinhPhi = dr.GetDecimal("KinhPhi");
            if (dr.GetInt32("SLCapNN") != null) _sLCapNN = dr.GetInt32("SLCapNN");
            if (dr.GetInt32("SLCapBo") != null) _sLCapBo = dr.GetInt32("SLCapBo");
            if (dr.GetInt32("SLCapCoSo") != null) _sLCapCoSo = dr.GetInt32("SLCapCoSo");
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_HDChiDaoTuyenB" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_HDChiDaoTuyenB(_maBC, _tenDeTai, _kinhPhi, _sLCapNN, _sLCapBo, _sLCapCoSo, _nguoiSD , _maMay);
			// public abstract String InsertBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT, String _tenDeTai, Decimal _kinhPhi, Int32 _sLCapNN, Int32 _sLCapBo, Int32 _sLCapCoSo, String _nguoiSD, SmartDate _ngaysd, Boolean _huy, String _maMay);
			// public override String InsertBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT, String _tenDeTai, Decimal _kinhPhi, Int32 _sLCapNN, Int32 _sLCapBo, Int32 _sLCapCoSo, String _nguoiSD, SmartDate _ngaysd, Boolean _huy, String _maMay);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _sTT, _tenDeTai, _kinhPhi, _sLCapNN, _sLCapBo, _sLCapCoSo, _nguoiSD , _ngaysd.DBValue, _huy, _maMay), String);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_HDChiDaoTuyenB" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_HDChiDaoTuyenB(_maBC, _sTT, _tenDeTai, _kinhPhi, _sLCapNN, _sLCapBo, _sLCapCoSo, _nguoiSD , _huy, _maMay);
				// public abstract void UpdateBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT, String _tenDeTai, Decimal _kinhPhi, Int32 _sLCapNN, Int32 _sLCapBo, Int32 _sLCapCoSo, String _nguoiSD, SmartDate _ngaysd, Boolean _huy, String _maMay);
				// public override void UpdateBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT, String _tenDeTai, Decimal _kinhPhi, Int32 _sLCapNN, Int32 _sLCapBo, Int32 _sLCapCoSo, String _nguoiSD, SmartDate _ngaysd, Boolean _huy, String _maMay);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _sTT, _tenDeTai, _kinhPhi, _sLCapNN, _sLCapBo, _sLCapCoSo, _nguoiSD , _ngaysd.DBValue, _huy, _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBC, _sTT));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_HDChiDaoTuyenB" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_HDChiDaoTuyenB
            DataProvider.Instance().DeleteBC_HDChiDaoTuyenB(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.STT);
			// public abstract void DeleteBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT);
			// public override void DeleteBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDChiDaoTuyenB_Deleted", _maBC, _sTT);
			// }
		}

		#endregion
	}

}
