// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_PhauThuat_TV
// Kieu doi tuong  :	BenhAn_PhauThuat_TV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/17/2009 8:54:55 AM
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
	/// This is a base generated class of <see cref="BenhAn_PhauThuat_TV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_PhauThuat_TV : BusinessBase<BenhAn_PhauThuat_TV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private Int32 _sTTTV = 0;
		private String _maNV = String.Empty;
		private Byte _vaiTro = 0;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _hoTen = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tenCV = String.Empty;
        private String _tenVaiTro = String.Empty;
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
		
		public Int32 STTTV
		{
			get 
			{
				CanReadProperty("STTTV", true);
				return _sTTTV;
			}
			set 
			{
				CanWriteProperty("STTTV", true);
				if (_sTTTV != value) 
				{
					_sTTTV = value;
					PropertyHasChanged("STTTV");
				}
			}
		}
		
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _maNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_maNV != value) 
				{
					_maNV = value;
					PropertyHasChanged("MaNV");
				}
			}
		}
		
		public Byte VaiTro
		{
			get 
			{
				CanReadProperty("VaiTro", true);
				return _vaiTro;
			}
			set 
			{
				CanWriteProperty("VaiTro", true);
				if (_vaiTro != value) 
				{
					_vaiTro = value;
					PropertyHasChanged("VaiTro");
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
				}
			}
		}

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoTen;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoTen != value)
                {
                    _hoTen = value;
                    PropertyHasChanged("Hoten");
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

        public String TenCV
        {
            get
            {
                CanReadProperty("TenCV", true);
                return _tenCV;
            }
            set
            {
                CanWriteProperty("TenCV", true);
                if (_tenCV != value)
                {
                    _tenCV = value;
                    PropertyHasChanged("TenCV");
                }
            }
        }

        public String TenVaiTro
        {
            get
            {
                CanReadProperty("TenVaiTro", true);
                return _tenVaiTro;
            }
            set
            {
                CanWriteProperty("TenVaiTro", true);
                if (_tenVaiTro != value)
                {
                    _tenVaiTro = value;
                    PropertyHasChanged("TenVaiTro");
                }
            }
        }
		
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString() + "!" + _sTTTV.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_PhauThuat_TV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_PhauThuat_TV NewBenhAn_PhauThuat_TV()
        {
            return new BenhAn_PhauThuat_TV();

        }
        public static BenhAn_PhauThuat_TV NewBenhAn_PhauThuat_TV(string idNhanvien)
        {
            return new BenhAn_PhauThuat_TV(DMNhanVien.GetDMNhanVien(idNhanvien));
        }
        public static BenhAn_PhauThuat_TV NewBenhAn_PhauThuat_TV(DMNhanVien _DMNhanVien)
        {
            return new BenhAn_PhauThuat_TV(_DMNhanVien);
        }
		public static BenhAn_PhauThuat_TV GetBenhAn_PhauThuat_TV(String maBA, Int32 sTT, Int32 sTTKhoa, Int32 sTTTV)
		{
			return DataPortal.Fetch<BenhAn_PhauThuat_TV>(new Criteria(maBA, sTT, sTTKhoa, sTTTV));
		}
        public static BenhAn_PhauThuat_TV GetBenhAn_PhauThuat_TV(SafeDataReader dr)
        {
            return new BenhAn_PhauThuat_TV(dr);
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_PhauThuat_TV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_PhauThuat_TV(String maBA, Int32 sTT, Int32 sTTKhoa, Int32 sTTTV, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa, sTTTV));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_PhauThuat_TV()
		{	
			// Prevent direct creation
		}
        protected BenhAn_PhauThuat_TV(DMNhanVien pro)
        {
            MarkAsChild();

            _maNV = pro.MaNV;
            _hoTen = pro.HoTen;
            
        }
        //protected BenhAn_PhauThuat_TV(string MaBA,int stt, int sttkhoa, DMNhanVien pro)
        //{
        //    MarkAsChild();
        //    _maBA = MaBA;
        //    _maThuoc = pro.MaThuoc;
        //    _maMay = pro.MaMay;
        //    _huy = pro.Huy;
        //    _nguoiSD = pro.NguoiSD;

        //    //MarkOld();
        //}
        protected BenhAn_PhauThuat_TV(SafeDataReader dr)
        {
            MarkAsChild();
             _maBA = dr.GetString("MaBA");
             _sTT = dr.GetInt32("STT");
             _sTTKhoa = dr.GetInt32("STTKhoa");
             _sTTTV = dr.GetInt32("STTTV");
             _maNV = dr.GetString("MaNV");
             _vaiTro = dr.GetByte("VaiTro");
             _ghichu = dr.GetString("Ghichu");
             _maMay = dr.GetString("MaMay");
             _huy = dr.GetBoolean("Huy");
             _ngaySD = dr.GetSmartDate("NgaySD", true);
             _nguoiSD = dr.GetString("NguoiSD");
             _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
             _nguoiSD1 = dr.GetString("NguoiSD1");
             _hoTen = dr.GetString("HoTen");
             _tennguoiSD = dr.GetString("TenNguoiSD");
             _tenCV = dr.GetString("TenCV");
             _tenVaiTro = dr.GetString("TenVaiTro");
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
			
			private Int32 _sTTTV;
			public Int32 STTTV 
			{
				get
				{
					return _sTTTV;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa, Int32 sTTTV)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
				_sTTTV = sTTTV;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					if (!_sTTTV.Equals(c._sTTTV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString(), _sTTTV.ToString()).GetHashCode();
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            private Int32 _sTTTV;
            public Int32 STTTV
            {
                get
                {
                    return _sTTTV;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, Int32 sTTTV)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTTV = sTTTV;
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
		/// Retrieve an existing <see cref="BenhAn_PhauThuat_TV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV);
			// public override IDataReader GetBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PhauThuat_TV_GET", _maBA, _sTT, _sTTKhoa, _sTTTV));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_PhauThuat_TV(crit.MaBA, crit.STT, crit.STTKhoa, crit.STTTV)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_PhauThuat_TV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetInt32("STTTV") != null) _sTTTV = dr.GetInt32("STTTV");
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetByte("VaiTro") != null) _vaiTro = dr.GetByte("VaiTro");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _hoTen = dr.GetString("HoTen");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            //_tenCV = dr.GetString("TenCV");
            _tenVaiTro = dr.GetString("TenVaiTro");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_PhauThuat_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(BenhAn_PhauThuat obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_PhauThuat_TV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maBA = obj.MaBA;
            _sTT = obj.STT;
            _sTTKhoa = obj.STTKhoa;
            _sTTTV  = DataProvider.Instance().InsertBenhAn_PhauThuat_TV(obj.MaBA, obj.STT ,obj.STTKhoa, _maNV, _vaiTro, _ghichu, _maMay, _nguoiSD);
            MarkOld();// public abstract String InsertBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maNV, Byte _vaiTro, String _ghichu, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maNV, Byte _vaiTro, String _ghichu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PhauThuat_TV_CREATE", _maBA, _sTT, _sTTKhoa, _maNV, _vaiTro, _ghichu, _maMay, _nguoiSD);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_PhauThuat_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(BenhAn_PhauThuat obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PhauThuat_TV
			if (IsDirty)
            {
                
                  
                _maBA = obj.MaBA;
                _sTT = obj.STT;
                _sTTKhoa = obj.STTKhoa;
                DataProvider.Instance().UpdateBenhAn_PhauThuat_TV(obj.MaBA, obj.STT, obj.STTKhoa, _sTTTV, _maNV, _vaiTro, _ghichu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV, String _maNV, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV, String _maNV, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PhauThuat_TV_UPDATE", _maBA, _sTT, _sTTKhoa, _sTTTV, _maNV, _vaiTro, _ghichu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maBA, _sTT, _sTTKhoa, _sTTTV));
        //}

        ///// <summary>
        ///// Delete the <see cref="BenhAn_PhauThuat_TV" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PhauThuat_TV
        //    DataProvider.Instance().DeleteBenhAn_PhauThuat_TV(crit.MaBA, crit.STT, crit.STTKhoa, crit.STTTV);
        //    // public abstract void DeleteBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV);
        //    // public override void DeleteBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PhauThuat_TV_DELETED", _maBA, _sTT, _sTTKhoa, _sTTTV);
        //    // }
        //}
        internal void DeleteSelf(BenhAn_PhauThuat obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteBenhAn_PhauThuat_TV(_maMay , _nguoiSD , _maBA, _sTT , _sTTKhoa, _sTTTV);
            MarkNew();
        }
		#endregion
	}

}
