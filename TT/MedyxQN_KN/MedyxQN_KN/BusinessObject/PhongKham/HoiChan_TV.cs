// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HoiChan_TV
// Kieu doi tuong  :	HoiChan_TV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/4/2009 9:15:13 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HoiChan_TV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HoiChan_TV : BusinessBase<HoiChan_TV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maHC = String.Empty;
		private Byte _sTT = 0;
		private String _maNV = String.Empty;
		private String _maCD = String.Empty;
        //private String _maCD = HTC.Business.CategoryList.DMChucDanhListcb.DefaultPosition();
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Byte _vaiTro = 0;
        private String _tenCD = String.Empty;
        private String _hoTen = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tenCV = String.Empty;
        private String _tenVaiTro = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaHC
		{
			get 
			{
				CanReadProperty("MaHC", true);
				return _maHC;
			}
			set 
			{
				CanWriteProperty("MaHC", true);
				if (_maHC != value) 
				{
					_maHC = value;
					PropertyHasChanged("MaHC");
				}
			}
		}
		
		public Byte STT
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
		
		public String MaCD
		{
			get 
			{
				CanReadProperty("MaCD", true);
				return _maCD;
			}
			set 
			{
				CanWriteProperty("MaCD", true);
				if (_maCD != value) 
				{
					_maCD = value;
					PropertyHasChanged("MaCD");
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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

        public String TenCD
        {
            get
            {
                CanReadProperty("TenCD", true);
                return _tenCD;
            }
            set
            {
                CanWriteProperty("TenCD", true);
                if (_tenCD != value)
                {
                    _tenCD = value;
                    PropertyHasChanged("TenCD");
                }
            }
        }

        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoTen != value)
                {
                    _hoTen = value;
                    PropertyHasChanged("HoTen");
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
                return _tenVaiTro ;
            }
            set
            {
                CanWriteProperty("TenVaiTro", true);
                if (_tenVaiTro  != value)
                {
                    _tenVaiTro  = value;
                    PropertyHasChanged("TenVaiTro");
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
			return _maHC.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HoiChan_TV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static HoiChan_TV NewHoiChan_TV()
        {
            return new HoiChan_TV();

        }
        public static HoiChan_TV NewHoiChan_TV(string idNV)
        {
            return new HoiChan_TV(DMNhanVien.GetDMNhanVien(idNV));
        }
        public static HoiChan_TV NewHoiChan_TV(DMNhanVien _DMNhanVien)
        {
            return new HoiChan_TV(_DMNhanVien);
        }
		public static HoiChan_TV GetHoiChan_TV(String maHC, Byte sTT)
		{
			return DataPortal.Fetch<HoiChan_TV>(new Criteria(maHC, sTT));
		}
        public static HoiChan_TV GetHoiChan_TV(SafeDataReader dr)
        {
            return new HoiChan_TV(dr);
        }
		/// <summary>
		/// Marks the <see cref="HoiChan_TV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteHoiChan_TV(String maHC, Byte sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHC, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HoiChan_TV()
		{	
			// Prevent direct creation
		}
		protected HoiChan_TV(DMNhanVien obj)
        {
            MarkAsChild();

            //_maHC = obj.mahc;
            _maNV = obj.MaNV;
             _maMay = obj.MaMay;
             _huy = obj.Huy;
             _ngaySD = obj.NgaySD ;
             _nguoiSD = obj.NguoiSD;
            _tenCV = obj.TenCV ;
            //MarkOld();
        }
        protected HoiChan_TV(string _idMahc, DMNhanVien obj)
        {
            MarkAsChild();
            _maHC = _idMahc;
            _maNV = obj.MaNV;
            _maMay = obj.MaMay;
            _huy = obj.Huy;
            _nguoiSD = obj.NguoiSD;
          //  _tenCV = obj.TenCV;
            //MarkOld();
        }
        protected HoiChan_TV(SafeDataReader dr)
        {
            MarkAsChild();

           _maHC = dr.GetString("MaHC");
           _sTT = dr.GetByte("STT");
           _maNV = dr.GetString("MaNV");
           _maCD = dr.GetString("MaCD");      
           _huy = dr.GetBoolean("Huy");
           _ghichu = dr.GetString("Ghichu");
           _maMay = dr.GetString("MaMay");
           _ngaySD = dr.GetSmartDate("NgaySD", false);
           _nguoiSD = dr.GetString("NguoiSD");
           _vaiTro = dr.GetByte("VaiTro");
           _tenCD = dr.GetString("TENCD");
           _hoTen = dr.GetString("Hoten");
           _tennguoiSD = dr.GetString("TENNGUOISD");
           _tenVaiTro = dr.GetString("TenVaiTro");
          // _tenCV = dr.GetString("TenCV");
        
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maHC;
			public String MaHC 
			{
				get
				{
					return _maHC;
				}
			}
			
			private Byte _sTT;
			public Byte STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maHC, Byte sTT)
			{
				_maHC = maHC;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maHC.Equals(c._maHC)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maHC.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]

        protected class OtherCriteria
        {
            private String _maHC;
            public String maHC
            {
                get
                {
                    return _maHC;
                }
            }

            private decimal _sTT;
            public decimal sTT
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
            // public OtherCriteria(String Mamay, String Nguoisd, String maPhieu, Byte sTT)
            public OtherCriteria(string mamay, String Nguoisd, String maHC, decimal sTT)
            {
                _maHC = maHC;
                _sTT = sTT;
                _maMay = mamay;
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
		/// Retrieve an existing <see cref="HoiChan_TV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetHoiChan_TV(String _maHC, Byte _sTT);
			// public override IDataReader GetHoiChan_TV(String _maHC, Byte _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHC, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHoiChan_TV(crit.MaHC, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="HoiChan_TV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHC") != null) _maHC = dr.GetString("MaHC");
			if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("MaCD") != null) _maCD = dr.GetString("MaCD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetByte("VaiTro") != null) _vaiTro = dr.GetByte("VaiTro");
            dr.GetString("TENCD");
            dr.GetString("Hoten");
            dr.GetString("TENNGUOISD");
            if (dr.GetString("TenVaiTro") != null) _tenVaiTro  = dr.GetString("TenVaiTro");
           // dr.GetString("TenCV");

		}
		
		/// <summary>
		/// Insert the new <see cref="HoiChan_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(HoiChan obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHoiChan_TV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            obj.MaHC = DataProvider.Instance().InsertHoiChan_TV(obj.MaHC, _maNV, _maCD, _ghichu, _maMay, _nguoiSD , _vaiTro, _hoTen);
            MarkOld();// public abstract String InsertHoiChan_TV(String _maHC, Byte _sTT, String _maNV, String _maCD, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
			// public override String InsertHoiChan_TV(String _maHC, Byte _sTT, String _maNV, String _maCD, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spHoiChan_TV_CREATE", _maHC, _sTT, _maNV, _maCD, _ghichu, _maMay, _nguoiSD , _vaiTro));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="HoiChan_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(HoiChan obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHoiChan_TV
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateHoiChan_TV(obj.MaHC, _sTT, _maNV, _maCD, _huy, _ghichu, _maMay, _nguoiSD , _vaiTro,_hoTen );
				// public abstract void UpdateHoiChan_TV(String _maHC, Byte _sTT, String _maNV, String _maCD, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
				// public override void UpdateHoiChan_TV(String _maHC, Byte _sTT, String _maNV, String _maCD, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHoiChan_TV_UPDATE", _maHC, _sTT, _maNV, _maCD, _huy, _ghichu, _maMay, _nguoiSD , _vaiTro);
				// }	
                MarkOld(); 
			}
		}
		

		/// <summary>
		/// Delete the <see cref="HoiChan_TV" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHoiChan_TV
        //    DataProvider.Instance().DeleteHoiChan_TV(crit.MaHC, crit.STT);
        //    // public abstract void DeleteHoiChan_TV(String _maHC, Byte _sTT);
        //    // public override void DeleteHoiChan_TV(String _maHC, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHoiChan_TV_DELETED", _maHC, _sTT);
        //    // }
        //}
        internal void DeleteSelf(HoiChan obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteHoiChan_TV(_maMay, _nguoiSD , _maHC, _sTT);
            MarkNew();
        }
		#endregion
	}

}
