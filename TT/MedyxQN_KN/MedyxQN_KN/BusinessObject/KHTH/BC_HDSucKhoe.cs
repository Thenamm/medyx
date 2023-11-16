// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_HDSucKhoe
// Kieu doi tuong  :	BC_HDSucKhoe
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/6/2009 9:32:30 AM
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
	/// This is a base generated class of <see cref="BC_HDSucKhoe" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_HDSucKhoe : BusinessBase<BC_HDSucKhoe>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _ma = String.Empty;
		private Int32  _soLuong ;
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private int _OrderNumber;
        private String _tenLoai = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _ten = String.Empty;
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
		
		public String MA
		{
			get 
			{
				CanReadProperty("MA", true);
				return _ma;
			}
			set 
			{
				CanWriteProperty("MA", true);
				if (_ma != value) 
				{
					_ma = value;
					PropertyHasChanged("MA");
				}
			}
		}
		
        //public Int32 SoLuong
        //{
        //    get 
        //    {
        //        CanReadProperty("SoLuong", true);
        //        if (_soLuong == 0)
        //        {
        //            return "0";
        //        }
        //        else
        //        {
        //            return _soLuong.ToString("###,###");
        //        }
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SoLuong", true);
        //        if (_soLuong!= value) 
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}
        ////    {
        ////        CanWriteProperty("SoLuong", true);

        ////        if (_soLuong.ToString() != value)
        ////        {
        ////            _soLuong = Int32 .Parse(value);
        ////            PropertyHasChanged("SoLuong");
        ////        }
        ////    }
        ////}
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "";
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    if (value=="")
                    _soLuong=0;
                    else
                    _soLuong = Int32.Parse(value.Replace(",","") );
                    PropertyHasChanged("SoLuong");
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
                _ngaysd.FormatString = "dd/MM/yyyy  hh:mm";
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
        public String TenLoai
        {
            get
            {
                CanReadProperty("TenLoai", true);
                return _tenLoai;
            }
            set
            {
                CanWriteProperty("TenLoai", true);
                if (_tenLoai != value)
                {
                    _tenLoai = value;
                    PropertyHasChanged("TenLoai");
                }
            }
        }
        public String Ten
        {
            get
            {
                CanReadProperty("Ten", true);
                return _ten;
            }
            set
            {
                CanWriteProperty("Ten", true);
                if (_ten != value)
                {
                    _ten = value;
                    PropertyHasChanged("Ten");
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
			return _maBC.ToString() + "!" + _ma.ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_HDSucKhoe" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BC_HDSucKhoe NewBC_HDSucKhoe()
        {
            return new BC_HDSucKhoe();
            //return DataPortal.Create<BC_HDSucKhoe>();
        }
        ////public static DMThuoc_KhoKhoa GetDMThuoc_KhoKhoa(String makho, Decimal sTT, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMThuoc_KhoKhoa>(new Criteria(makho, sTT, makhoa));
        ////}
        internal static BC_HDSucKhoe GetBC_HDSucKhoe(SafeDataReader dr, int i)
        {
            return new BC_HDSucKhoe(dr,i);
        }
        //public static BC_HDSucKhoe GetBC_HDSucKhoe(String maBC, String ma)
        //{
        //    return DataPortal.Fetch<BC_HDSucKhoe>(new Criteria(maBC, ma));
        //}
		
		/// <summary>
		/// Marks the <see cref="BC_HDSucKhoe" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_HDSucKhoe(String maBC, String ma)
		{
			DataPortal.Delete(new Criteria(maBC, ma));
		}
        public BC_HDSucKhoe()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_HDSucKhoe()
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
			
			private String _ma;
			public String MA 
			{
				get
				{
					return _ma;
				}
			}
			
			public Criteria(String maBC, String ma)
			{
				_maBC = maBC;
				_ma = ma;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_ma.Equals(c._ma)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _ma.ToString()).GetHashCode();
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

            private String _ma;
            public String MA
            {
                get
                {
                    return _ma;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, String ma)
            {
                _maBC = maBC;
                _ma = ma;
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
		/// Retrieve an existing <see cref="BC_HDSucKhoe" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_HDSucKhoe(String _maBC, String _ma);
        //    // public override IDataReader GetBC_HDSucKhoe(String _maBC, String _ma)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _ma));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_HDSucKhoe(crit.MaBC, crit.MA)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_HDSucKhoe" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("MA") != null) _ma = dr.GetString("MA");
        //    if (dr.GetInt32("SoLuong") != null) _soLuong = dr.GetInt32("SoLuong");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //}
        private BC_HDSucKhoe(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MA") != null) _ma = dr.GetString("MA");
			if (dr.GetInt32("SoLuong") != null) _soLuong = dr.GetInt32("SoLuong");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenLoai") != null) _tenLoai = dr.GetString("TenLoai");
            if (dr.GetString("Ten") != null) _ten = dr.GetString("Ten");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_HDSucKhoe" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			 DataProvider.Instance().InsertBC_HDSucKhoe(_maBC, _ma, _soLuong, _nguoiSD , _maMay);
			// public abstract String InsertBC_HDSucKhoe(String _maBC, String _ma, Int32 _soLuong, String _nguoiSD, String _maMay);
			// public override String InsertBC_HDSucKhoe(String _maBC, String _ma, Int32 _soLuong, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDSUCKHOE_CREATE", _maBC, _ma, _soLuong, _nguoiSD ,  _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_HDSucKhoe" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_HDSucKhoe(_maBC, _ma, _soLuong, _nguoiSD , _huy, _maMay);
				// public abstract void UpdateBC_HDSucKhoe(String _maBC, String _ma, Int32 _soLuong, String _nguoiSD, SmartDate _ngaysd, String _maMay);
				// public override void UpdateBC_HDSucKhoe(String _maBC, String _ma, Int32 _soLuong, String _nguoiSD, SmartDate _ngaysd, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDSucKhoe_Update", _maBC, _ma, _soLuong, _nguoiSD , _ngaysd.DBValue, _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBC, _ma));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_HDSucKhoe" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_HDSucKhoe
			DataProvider.Instance().DeleteBC_HDSucKhoe(crit.MaMay, crit.NguoiSD ,   crit.MaBC, crit.MA);
			// public abstract void DeleteBC_HDSucKhoe(String _maBC, String _ma);
			// public override void DeleteBC_HDSucKhoe(String _maBC, String _ma)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDSucKhoe_Deleted", _maBC, _ma);
			// }
		}

		#endregion
	}

}
