// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_CSTN_TV
// Kieu doi tuong  :	KhamBenh_CSTN_TV
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
	/// This is a base generated class of <see cref="KhamBenh_CSTN_TV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_CSTN_TV : BusinessBase<KhamBenh_CSTN_TV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaSoKham = String.Empty;
		private int _sTT = 0;
        private int _sTTTH = 0;
        private int _sTTTV = 0;
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
		
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _MaSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_MaSoKham != value) 
				{
					_MaSoKham = value;
					PropertyHasChanged("MaSoKham");
				}
			}
		}
		
		public int STT
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
        public int STTTH
        {
            get
            {
                CanReadProperty("STTTH", true);
                return _sTTTH;
            }
            set
            {
                CanWriteProperty("STTTH", true);
                if (_sTTTH != value)
                {
                    _sTTTH = value;
                    PropertyHasChanged("STTTH");
                }
            }
        }
        public int STTTV
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
			return _MaSoKham.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_CSTN_TV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_CSTN_TV NewKhamBenh_CSTN_TV()
        {
            return new KhamBenh_CSTN_TV();

        }
        public static KhamBenh_CSTN_TV NewKhamBenh_CSTN_TV(string idNV)
        {
            return new KhamBenh_CSTN_TV(DMNhanVien.GetDMNhanVien(idNV));
        }
        public static KhamBenh_CSTN_TV NewKhamBenh_CSTN_TV(DMNhanVien _DMNhanVien)
        {
            return new KhamBenh_CSTN_TV(_DMNhanVien);
        }
        public static KhamBenh_CSTN_TV GetKhamBenh_CSTN_TV(String MaSoKham, int sTTTV)
		{
			return DataPortal.Fetch<KhamBenh_CSTN_TV>(new Criteria(MaSoKham, sTTTV));
		}
        public static KhamBenh_CSTN_TV GetKhamBenh_CSTN_TV(SafeDataReader dr)
        {
            return new KhamBenh_CSTN_TV(dr);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_CSTN_TV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKhamBenh_CSTN_TV(String MaSoKham, Byte sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaSoKham, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_CSTN_TV()
		{	
			// Prevent direct creation
		}
		protected KhamBenh_CSTN_TV(DMNhanVien obj)
        {
            MarkAsChild();

            //_MaSoKham = obj.MaSoKham;
            _maNV = obj.MaNV;
             _maMay = obj.MaMay;
             _huy = obj.Huy;
             _ngaySD = obj.NgaySD ;
             _nguoiSD = obj.NguoiSD;
            _tenCV = obj.TenCV ;
            //MarkOld();
        }
        protected KhamBenh_CSTN_TV(string _idMaSoKham, DMNhanVien obj)
        {
            MarkAsChild();
            _MaSoKham = _idMaSoKham;
            _maNV = obj.MaNV;
            _maMay = obj.MaMay;
            _huy = obj.Huy;
            _nguoiSD = obj.NguoiSD;
          //  _tenCV = obj.TenCV;
            //MarkOld();
        }
        protected KhamBenh_CSTN_TV(SafeDataReader dr)
        {
            MarkAsChild();

           _MaSoKham = dr.GetString("MaSoKham");
           _sTT = dr.GetInt32("STT");
           _sTTTH = dr.GetInt32("STTTH");
           _sTTTV = dr.GetInt32("STTTV");
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
			private String _MaSoKham;
			public String MaSoKham 
			{
				get
				{
					return _MaSoKham;
				}
			}
			
			private int _sTTTV;
			public int STTTV 
			{
				get
				{
					return _sTTTV;
				}
			}
          
            public Criteria(String MaSoKham, int sTTTV)
			{
				_MaSoKham = MaSoKham;
                _sTTTV = sTTTV;
               
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaSoKham.Equals(c._MaSoKham)) 
						return false;
					if (!_sTTTV.Equals(c._sTTTV)) 
						return false;
                   
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
                return string.Concat("Criteria", _MaSoKham.ToString(), _sTTTV.ToString()).GetHashCode();
			}
		}

        [Serializable()]

        protected class OtherCriteria
        {
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            public OtherCriteria(string mamay, String Nguoisd, String MaSoKham, decimal sTT)
            {
                _MaSoKham = MaSoKham;
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
		/// Retrieve an existing <see cref="KhamBenh_CSTN_TV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT);
			// public override IDataReader GetKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaSoKham, _sTT));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_CSTN_TV(crit.MaSoKham, crit.STTTV)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_CSTN_TV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTTH") != null) _sTTTH = dr.GetInt32("STTTH");
            if (dr.GetInt32("STTTV") != null) _sTTTV = dr.GetInt32("STTTV");
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
		/// Insert the new <see cref="KhamBenh_CSTN_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(KhamBenh_CSTN obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_CSTN_TV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
       _sTTTV =  DataProvider.Instance().InsertKhamBenh_CSTN_TV(obj.MaSoKham,obj.STT ,obj.STTTH ,  _maNV, _maCD, _ghichu, _maMay, _nguoiSD , _vaiTro, _hoTen);
            MarkOld();// public abstract String InsertKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT, String _maNV, String _maCD, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
			// public override String InsertKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT, String _maNV, String _maCD, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_CSTN_TV_CREATE", _MaSoKham, _sTT, _maNV, _maCD, _ghichu, _maMay, _nguoiSD , _vaiTro));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_CSTN_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KhamBenh_CSTN obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_CSTN_TV
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateKhamBenh_CSTN_TV(obj.MaSoKham, _sTTTV, _maNV, _maCD, _huy, _ghichu, _maMay, _nguoiSD , _vaiTro,_hoTen );
				// public abstract void UpdateKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT, String _maNV, String _maCD, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
				// public override void UpdateKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT, String _maNV, String _maCD, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_CSTN_TV_UPDATE", _MaSoKham, _sTT, _maNV, _maCD, _huy, _ghichu, _maMay, _nguoiSD , _vaiTro);
				// }	
                MarkOld(); 
			}
		}
		

		/// <summary>
		/// Delete the <see cref="KhamBenh_CSTN_TV" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_CSTN_TV
        //    DataProvider.Instance().DeleteKhamBenh_CSTN_TV(crit.MaSoKham, crit.STT);
        //    // public abstract void DeleteKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT);
        //    // public override void DeleteKhamBenh_CSTN_TV(String _MaSoKham, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_CSTN_TV_DELETED", _MaSoKham, _sTT);
        //    // }
        //}
        internal void DeleteSelf(KhamBenh_CSTN obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteKhamBenh_CSTN_TV(_maMay, _nguoiSD , _MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
