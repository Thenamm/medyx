// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhNhan_TienSu_San_C
// Kieu doi tuong  :	BenhNhan_TienSu_San_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/31/2010 9:57:42 AM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhNhan_TienSu_San_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhNhan_TienSu_San_C : BusinessBase<BenhNhan_TienSu_San_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBN = String.Empty;
		private Int32 _sTT = 0;
		private String _thoigianThainghen = String.Empty;
		private String _tuoithai = String.Empty;
		private String _dienbienThai = String.Empty;
		private String _cachde = String.Empty;
		private String _tresosinh = String.Empty;
		private String _hauSan = String.Empty;
		private String _khac = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tennguoiSD = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaBN
		{
			get 
			{
				CanReadProperty("MaBN", true);
				return _maBN;
			}
			set 
			{
				CanWriteProperty("MaBN", true);
				if (_maBN != value) 
				{
					_maBN = value;
					PropertyHasChanged("MaBN");
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
		
		public String ThoigianThainghen
		{
			get 
			{
				CanReadProperty("ThoigianThainghen", true);
				return _thoigianThainghen;
			}
			set 
			{
				CanWriteProperty("ThoigianThainghen", true);
				if (_thoigianThainghen != value) 
				{
					_thoigianThainghen = value;
					PropertyHasChanged("ThoigianThainghen");
				}
			}
		}
		
		public String Tuoithai
		{
			get 
			{
				CanReadProperty("Tuoithai", true);
				return _tuoithai;
			}
			set 
			{
				CanWriteProperty("Tuoithai", true);
				if (_tuoithai != value) 
				{
					_tuoithai = value;
					PropertyHasChanged("Tuoithai");
				}
			}
		}
		
		public String DienbienThai
		{
			get 
			{
				CanReadProperty("DienbienThai", true);
				return _dienbienThai;
			}
			set 
			{
				CanWriteProperty("DienbienThai", true);
				if (_dienbienThai != value) 
				{
					_dienbienThai = value;
					PropertyHasChanged("DienbienThai");
				}
			}
		}
		
		public String Cachde
		{
			get 
			{
				CanReadProperty("Cachde", true);
				return _cachde;
			}
			set 
			{
				CanWriteProperty("Cachde", true);
				if (_cachde != value) 
				{
					_cachde = value;
					PropertyHasChanged("Cachde");
				}
			}
		}
		
		public String Tresosinh
		{
			get 
			{
				CanReadProperty("Tresosinh", true);
				return _tresosinh;
			}
			set 
			{
				CanWriteProperty("Tresosinh", true);
				if (_tresosinh != value) 
				{
					_tresosinh = value;
					PropertyHasChanged("Tresosinh");
				}
			}
		}
		
		public String HauSan
		{
			get 
			{
				CanReadProperty("HauSan", true);
				return _hauSan;
			}
			set 
			{
				CanWriteProperty("HauSan", true);
				if (_hauSan != value) 
				{
					_hauSan = value;
					PropertyHasChanged("HauSan");
				}
			}
		}
		
		public String Khac
		{
			get 
			{
				CanReadProperty("Khac", true);
				return _khac;
			}
			set 
			{
				CanWriteProperty("Khac", true);
				if (_khac != value) 
				{
					_khac = value;
					PropertyHasChanged("Khac");
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
		protected override Object GetIdValue()
		{
			return _maBN.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhNhan_TienSu_San_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhNhan_TienSu_San_C NewBenhNhan_TienSu_San_C()
        {
            return new BenhNhan_TienSu_San_C();

        }
        //public static BenhAn_PhauThuat_TV NewBenhAn_PhauThuat_TV(string idNhanvien)
        //{
        //    return new BenhAn_PhauThuat_TV(DMNhanVien.GetDMNhanVien(idNhanvien));
        //}
        //public static BenhAn_PhauThuat_TV NewBenhAn_PhauThuat_TV(DMNhanVien _DMNhanVien)
        //{
        //    return new BenhAn_PhauThuat_TV(_DMNhanVien);
        //}
		public static BenhNhan_TienSu_San_C GetBenhNhan_TienSu_San_C(String maBN, Int32 sTT)
		{
			return DataPortal.Fetch<BenhNhan_TienSu_San_C>(new Criteria(maBN, sTT));
		}
        public static BenhNhan_TienSu_San_C GetBenhNhan_TienSu_San_C(SafeDataReader dr)
        {
            return new BenhNhan_TienSu_San_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="BenhNhan_TienSu_San_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhNhan_TienSu_San_C(String maBN, Int32 sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhNhan_TienSu_San_C()
		{	
			// Prevent direct creation
		}
        protected BenhNhan_TienSu_San_C(SafeDataReader dr)
        {
            MarkAsChild();
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("ThoigianThainghen") != null) _thoigianThainghen = dr.GetString("ThoigianThainghen");
			if (dr.GetString("Tuoithai") != null) _tuoithai = dr.GetString("Tuoithai");
			if (dr.GetString("DienbienThai") != null) _dienbienThai = dr.GetString("DienbienThai");
			if (dr.GetString("Cachde") != null) _cachde = dr.GetString("Cachde");
			if (dr.GetString("Tresosinh") != null) _tresosinh = dr.GetString("Tresosinh");
			if (dr.GetString("HauSan") != null) _hauSan = dr.GetString("HauSan");
			if (dr.GetString("Khac") != null) _khac = dr.GetString("Khac");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBN;
			public String MaBN 
			{
				get
				{
					return _maBN;
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
			
			public Criteria(String maBN, Int32 sTT)
			{
				_maBN = maBN;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBN.Equals(c._maBN)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBN.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
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
            
            public OtherCriteria(String Mamay, String Nguoisd, String maBN, Int32 sTT)
            {
                _maBN = maBN;
                _sTT = sTT;
                
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
		/// Retrieve an existing <see cref="BenhNhan_TienSu_San_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT);
			// public override IDataReader GetBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_TienSu_San_C_GET", _maBN, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhNhan_TienSu_San_C(crit.MaBN, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhNhan_TienSu_San_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("ThoigianThainghen") != null) _thoigianThainghen = dr.GetString("ThoigianThainghen");
			if (dr.GetString("Tuoithai") != null) _tuoithai = dr.GetString("Tuoithai");
			if (dr.GetString("DienbienThai") != null) _dienbienThai = dr.GetString("DienbienThai");
			if (dr.GetString("Cachde") != null) _cachde = dr.GetString("Cachde");
			if (dr.GetString("Tresosinh") != null) _tresosinh = dr.GetString("Tresosinh");
			if (dr.GetString("HauSan") != null) _hauSan = dr.GetString("HauSan");
			if (dr.GetString("Khac") != null) _khac = dr.GetString("Khac");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            _tennguoiSD = dr.GetString("TenNguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhNhan_TienSu_San_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(BenhNhan_TienSu_San  obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_PhauThuat_TV
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _sTT = DataProvider.Instance().InsertBenhNhan_TienSu_San_C(obj.MaBN, _thoigianThainghen, _tuoithai, _dienbienThai, _cachde, _tresosinh, _hauSan, _khac, _maMay, _nguoiSD);
            MarkOld();// public abstract String InsertBenhNhan_TienSu_San_C(String _maBN, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, String _nguoiSD);
			// public override String InsertBenhNhan_TienSu_San_C(String _maBN, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_TienSu_San_C_CREATE", _maBN, _thoigianThainghen, _tuoithai, _dienbienThai, _cachde, _tresosinh, _hauSan, _khac, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhNhan_TienSu_San_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(BenhNhan_TienSu_San obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PhauThuat_TV
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateBenhNhan_TienSu_San_C(obj.MaBN,_sTT,  _thoigianThainghen, _tuoithai, _dienbienThai, _cachde, _tresosinh, _hauSan, _khac, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_TienSu_San_C_UPDATE", _maBN, _sTT, _thoigianThainghen, _tuoithai, _dienbienThai, _cachde, _tresosinh, _hauSan, _khac, _maMay, _huy, _nguoiSD);
				// }	
			
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maBN, _sTT));
        //}

        ///// <summary>
        ///// Delete the <see cref="BenhNhan_TienSu_San_C" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan_TienSu_San_C
        //    DataProvider.Instance().DeleteBenhNhan_TienSu_San_C(crit.MaBN, crit.STT);
        //    // public abstract void DeleteBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT);
        //    // public override void DeleteBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_TienSu_San_C_Deleted", _maBN, _sTT);
        //    // }
        //}
        internal void DeleteSelf(BenhNhan_TienSu_San obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
               
            

            DataProvider.Instance().DeleteBenhNhan_TienSu_San_C(_maMay,_nguoiSD,  _maBN, _sTT);
            MarkNew();
        }
		#endregion
	}

}
