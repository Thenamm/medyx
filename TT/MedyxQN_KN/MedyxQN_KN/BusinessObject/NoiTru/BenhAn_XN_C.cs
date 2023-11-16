// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_XN_C
// Kieu doi tuong  :	BenhAn_XN_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/20/2009 9:59:59 AM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_XN_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_XN_C : BusinessBase<BenhAn_XN_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTTKhoa = 0;
		private Int32 _sTT = 0;
		private Int32 _sTTCS = 0;
		private String _maDV = String.Empty;
		private String _maCS = String.Empty;
		private String _kq = String.Empty;
        private String _makq = String.Empty;
		
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tenCS = String.Empty;
        private String _KQCS = String.Empty;
        private String _tenDV = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenNguoiSD = String.Empty;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
				}
			}
		}
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
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
		
		public Int32 STTCS
		{
			get 
			{
				CanReadProperty("STTCS", true);
				return _sTTCS;
			}
			set 
			{
				CanWriteProperty("STTCS", true);
				if (_sTTCS != value) 
				{
					_sTTCS = value;
					PropertyHasChanged("STTCS");
				}
			}
		}
		
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _maDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_maDV != value) 
				{
					_maDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
		
		public String MaCS
		{
			get 
			{
				CanReadProperty("MaCS", true);
				return _maCS;
			}
			set 
			{
				CanWriteProperty("MaCS", true);
				if (_maCS != value) 
				{
					_maCS = value;
					PropertyHasChanged("MaCS");
				}
			}
		}
		
		public String KQ
		{
			get 
			{
				CanReadProperty("KQ", true);
				return _kq;
			}
			set 
			{
				CanWriteProperty("KQ", true);
				if (_kq != value) 
				{
					_kq = value;
					PropertyHasChanged("KQ");
				}
			}
		}
        public String makq
        {
            get
            {
                CanReadProperty("makq", true);
                return _makq;
            }
            set
            {
                CanWriteProperty("makq", true);
                if (_makq != value)
                {
                    _makq = value;
                    PropertyHasChanged("makq");
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
        public String TenCS
        {
            get
            {
                CanReadProperty("TenCS", true);
                return _tenCS;
            }
            set
            {
                CanWriteProperty("TenCS", true);
                if (_tenCS != value)
                {
                    _tenCS = value;
                    PropertyHasChanged("TenCS");
                }
            }
        }

        public String KQCS
        {
            get
            {
                CanReadProperty("KQCS", true);
                return _KQCS;
            }
            set
            {
                CanWriteProperty("KQCS", true);
                if (_KQCS != value)
                {
                    _KQCS = value;
                    PropertyHasChanged("KQCS");
                }
            }
        }

        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
                }
            }
        }

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
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

		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTTKhoa.ToString().ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTCS.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_XN_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_XN_C NewBenhAn_XN_C()
        {
            return new BenhAn_XN_C();
        }
        public static BenhAn_XN_C NewBenhAn_XN_C(string idDV)
        {
            return new BenhAn_XN_C(DMDichVu.GetDMDichVu(idDV));
        }
        public static BenhAn_XN_C NewBenhAn_XN_C(DMDichVu _DMDichVu)
        {
            return new BenhAn_XN_C(_DMDichVu);
        }
		public static BenhAn_XN_C GetBenhAn_XN_C(String maBA, Int32 sTTKhoa, Int32 sTT, Int32 sTTCS)
		{
			return DataPortal.Fetch<BenhAn_XN_C>(new Criteria(maBA, sTTKhoa, sTT, sTTCS));
		}
        public static BenhAn_XN_C GetBenhAn_XN_C(SafeDataReader dr)
        {
            return new BenhAn_XN_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_XN_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBenhAn_XN_C(String maBA, Int32 sTTKhoa, Int32 sTT, Int32 sTTCS)
		{
			DataPortal.Delete(new Criteria(maBA, sTTKhoa, sTT, sTTCS));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_XN_C()
		{	
			// Prevent direct creation
		}
		
        protected BenhAn_XN_C(DMDichVu pro)
        {
            MarkAsChild();

            _maDV = pro.MaDV;
            _tenDV = pro.TenDV ;
            
        }
      
        protected BenhAn_XN_C(SafeDataReader dr)
        {
            MarkAsChild();
            _maBA = dr.GetString("MaBA");
            _sTTKhoa = dr.GetInt32("STTKhoa");
            _sTT = dr.GetInt32("STT");
            _sTTCS = dr.GetInt32("STTCS");
            _maDV = dr.GetString("MaDV");
            _maCS = dr.GetString("MaCS");
            _kq = dr.GetString("KQ");
             _makq = dr.GetString("MaKQ");
			
            _maMay = dr.GetString("MaMay");
            _huy = dr.GetBoolean("Huy");
            _ngaySD = dr.GetSmartDate("NgaySD", true);
            _nguoiSD = dr.GetString("NguoiSD");
            _tenCS = dr.GetString("TenCS");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _KQCS = dr.GetString("KQ");
            _tenDV = dr.GetString("TenDV");
            _tenKhoa = dr.GetString("TenKhoa");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
				}
			}
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
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
			
			private Int32 _sTTCS;
			public Int32 STTCS 
			{
				get
				{
					return _sTTCS;
				}
			}
			
			public Criteria(String maBA, Int32 sTTKhoa, Int32 sTT, Int32 sTTCS)
			{
				_maBA = maBA;
				_sTTKhoa = sTTKhoa;
				_sTT = sTT;
				_sTTCS = sTTCS;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTCS.Equals(c._sTTCS)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTTKhoa.ToString(), _sTT.ToString(), _sTTCS.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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

            private Int32 _sTTCS;
            public Int32 STTCS
            {
                get
                {
                    return _sTTCS;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, Int32 sTTCS)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTCS = sTTCS;
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
		/// Retrieve an existing <see cref="BenhAn_XN_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS);
			// public override IDataReader GetBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_XN_C_GET", _maBA, _sTTKhoa, _sTT, _sTTCS));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_XN_C(crit.MaBA, crit.STTKhoa, crit.STT, crit.STTCS)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_XN_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTCS") != null) _sTTCS = dr.GetInt32("STTCS");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("MaCS") != null) _maCS = dr.GetString("MaCS");
			if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
            if (dr.GetString("MaKQ") != null) _makq = dr.GetString("MaKQ");
			
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            _tenCS = dr.GetString("TenCS");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _KQCS = dr.GetString("KQCS");
            _tenDV = dr.GetString("TenDV");
            _tenKhoa = dr.GetString("TenKhoa");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_XN_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(BenhAn_XN  obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_PhauThuat_TV
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _sTTCS = DataProvider.Instance().InsertBenhAn_XN_C(obj.MaBA,  obj.STTKhoa,obj.STT, _maDV, _maCS, _kq,_makq, _maMay,  _nguoiSD);
            MarkOld();// public abstract String InsertBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, String _maDV, String _maCS, String _kq, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, String _maDV, String _maCS, String _kq, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_XN_C_Create", _maBA, _sTTKhoa, _sTT, _maDV, _maCS, _kq, _maMay,  _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_XN_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(BenhAn_XN obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PhauThuat_TV
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateBenhAn_XN_C(obj.MaBA, obj.STT, obj.STTKhoa, _sTTCS, _maDV, _maCS, _kq,_makq, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS, String _maDV, String _maCS, String _kq, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS, String _maDV, String _maCS, String _kq, String _maMay, Boolean _huy, String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_XN_C_Update", _maBA, _sTTKhoa, _sTT, _sTTCS, _maDV, _maCS, _kq, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maBA, _sTTKhoa, _sTT, _sTTCS));
        //}

		/// <summary>
		/// Delete the <see cref="BenhAn_XN_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_XN_C
        //    DataProvider.Instance().DeleteBenhAn_XN_C(crit.MaBA, crit.STTKhoa, crit.STT, crit.STTCS);
        //    // public abstract void DeleteBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS);
        //    // public override void DeleteBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTTKhoa, _sTT, _sTTCS);
        //    // }
        //}
        internal void DeleteSelf(BenhAn_XN obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
            

            DataProvider.Instance().DeleteBenhAn_XN_C(_maMay,_nguoiSD , _maBA, _sTT, _sTTKhoa, _sTTCS);
            MarkNew();
        }
		#endregion
	}

}
