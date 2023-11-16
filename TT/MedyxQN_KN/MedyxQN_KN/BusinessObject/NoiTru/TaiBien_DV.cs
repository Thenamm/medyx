// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TaiBien_DV
// Kieu doi tuong  :	TaiBien_DV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/11/2009 10:32:59 AM
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
	/// This is a base generated class of <see cref="TaiBien_DV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TaiBien_DV : BusinessBase<TaiBien_DV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTB = String.Empty;
		private Byte _sTT = 0;
		private String _maDV = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tenDV = String.Empty;
        private String _maDVT = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
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

        public String MaDVT
        {
            get
            {
                CanReadProperty("MaDVT", true);
                return _maDVT;
            }
            set
            {
                CanWriteProperty("MaDVT", true);
                if (_maDVT != value)
                {
                    _maDVT = value;
                    PropertyHasChanged("MaDVT");
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
			return _maTB.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TaiBien_DV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static TaiBien_DV NewTaiBien_DV()
        {
            return new TaiBien_DV();

        }
        public static TaiBien_DV NewTaiBien_DV(string idDV)
        {
            return new TaiBien_DV(DMDichVu.GetDMDichVu(idDV));
        }
        public static TaiBien_DV NewTaiBien_DV(DMDichVu _DMDichVu)
        {
            return new TaiBien_DV(_DMDichVu);
        }
        public static TaiBien_DV GetTaiBien_DV(String maTB, Byte sTT, Byte loai)
		{
            return DataPortal.Fetch<TaiBien_DV>(new Criteria(maTB, sTT, loai));
		}
        public static TaiBien_DV GetTaiBien_DV(SafeDataReader dr)
        {
            return new TaiBien_DV(dr);
        }
		/// <summary>
		/// Marks the <see cref="TaiBien_DV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTaiBien_DV(String maTB, Byte sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTB, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TaiBien_DV()
		{	
			// Prevent direct creation
		}
		protected TaiBien_DV(DMDichVu  obj)
        {
            MarkAsChild();

            //_maHC = obj.mahc;
            _maDV = obj.MaDV;
             _maMay = obj.MaMay;
             _huy = obj.Huy;
             _ngaySD = obj.NgaySD ;
             _nguoiSD = obj.NguoiSD;
            //_tenDV = obj.TenCV ;
            //MarkOld();
        }
        protected TaiBien_DV(string _MaTB, DMDichVu obj)
        {
            MarkAsChild();
            //_maHC = _idMahc;
            //_maNV = obj.MaNV;
            _maMay = obj.MaMay;
            _huy = obj.Huy;
            _nguoiSD = obj.NguoiSD;
            //  _tenCV = obj.TenCV;
            //MarkOld();
        }
        protected TaiBien_DV(SafeDataReader dr)
        {
            MarkAsChild();

           _maTB = dr.GetString("MaTB");
           _sTT = dr.GetByte("STT");
           _maDV = dr.GetString("MaDV");
           _maDVT = dr.GetString("maDVT");      
           _huy = dr.GetBoolean("Huy");
           _ghiChu = dr.GetString("Ghichu");
           _maMay = dr.GetString("MaMay");
           _ngaySD = dr.GetSmartDate("NgaySD", false);
           _nguoiSD = dr.GetString("NguoiSD");
           _tenNguoiSD = dr.GetString("TENNGUOISD");
           _tenDV = dr.GetString("TenDV");
           _tenDVT = dr.GetString("TenDVT");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maTB;
            public String MaTB 
			{
				get
				{
                    return _maTB;
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

            private Byte _loai;
            public Byte Loai
            {
                get
                {
                    return _loai;
                }
            }

            public Criteria(String maTB, Byte sTT, Byte loai)
			{
                _maTB = maTB;
				_sTT = sTT;
                _loai = loai;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
                    if (!_maTB.Equals(c._maTB)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
                    if (!_loai.Equals(c._loai))
                        return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTB.ToString(), _sTT.ToString(), _loai.ToString() ).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTB;
            public String MaTB
            {
                get
                {
                    return _maTB;
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
            public OtherCriteria(string mamay, String Nguoisd, String maTB, Byte sTT)
            {
                _maTB = maTB;
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
		/// Retrieve an existing <see cref="TaiBien_DV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTaiBien_DV(String _maTB, Byte _sTT);
            // public override IDataReader GetTaiBien_DV(String _maTB, Byte _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTaiBien_DV_GET", _maTB, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTaiBien_DV(crit.MaTB, crit.STT, crit.Loai)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TaiBien_DV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
			if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            _tenDV = dr.GetString("TENDV");
            _maDVT = dr.GetString("MaDVT");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
		}
		
		/// <summary>
		/// Insert the new <see cref="TaiBien_DV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(TaiBien obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTaiBien_DV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().InsertTaiBien_DV(obj.MaTB, _maDV, _ghiChu, _maMay, _nguoiSD);
            MarkOld();// public abstract String InsertTaiBien_DV(String _maTB, String _maDV, String _ghiChu, String _maMay, String _nguoiSD);
            // public override String InsertTaiBien_DV(String _maTB, String _maDV, String _ghiChu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTaiBien_DV_CREATE", _maTB, _maDV, _ghiChu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TaiBien_DV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(TaiBien obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTaiBien_DV
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateTaiBien_DV(obj.MaTB , _sTT, _maDV, _ghiChu, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateTaiBien_DV(String _MaTB, Byte _sTT, String _maDV, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateTaiBien_DV(String _MaTB, Byte _sTT, String _maDV, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTaiBien_DV_UPDATE", _MaTB, _sTT, _maDV, _ghiChu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maBN, _sTT, _sTTTB));
        //}

		/// <summary>
		/// Delete the <see cref="TaiBien_DV" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTaiBien_DV
        //    DataProvider.Instance().DeleteTaiBien_DV(crit.MaBN, crit.STT, crit.STTTB);
        //    // public abstract void DeleteTaiBien_DV(String _maTB, Byte _sTT);
        //    // public override void DeleteTaiBien_DV(String _maTB, Byte _sTT)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTaiBien_DV_DELETED", _maTB, _sTT);
        //    // }
        //}
        internal void DeleteSelf(TaiBien obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteTaiBien_DV(_maMay, _nguoiSD , _maTB, _sTT);
            MarkNew();
        }
		#endregion
	}

}
