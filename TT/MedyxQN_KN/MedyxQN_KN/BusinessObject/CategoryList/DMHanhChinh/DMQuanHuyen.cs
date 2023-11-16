// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMQuanHuyen
// Kieu doi tuong  :	DMQuanHuyen
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 11:26:10 AM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMQuanHuyen" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMQuanHuyen : BusinessBase<DMQuanHuyen>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maQH = String.Empty;
		private String _maTinh = String.Empty;
		private String _tenQH = String.Empty;
		private String _maBHXH = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _tenTinh = String.Empty;
        private String _hoten = String.Empty;
        private String _MaTat = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
		
		public String MaQH
		{
			get 
			{
				CanReadProperty("MaQH", true);
				return _maQH;
			}
			set 
			{
				CanWriteProperty("MaQH", true);
				if (_maQH != value) 
				{
					_maQH = value;
					PropertyHasChanged("MaQH");
				}
			}
		}
		
		public String MaTinh
		{
			get 
			{
				CanReadProperty("MaTinh", true);
				return _maTinh;
			}
			set 
			{
				CanWriteProperty("MaTinh", true);
				if (_maTinh != value) 
				{
					_maTinh = value;
					PropertyHasChanged("MaTinh");
				}
			}
		}
		
		public String TenQH
		{
			get 
			{
				CanReadProperty("TenQH", true);
				return _tenQH;
			}
			set 
			{
				CanWriteProperty("TenQH", true);
				if (_tenQH != value) 
				{
					_tenQH = value;
					PropertyHasChanged("TenQH");
				}
			}
		}
		
		public String MaBHXH
		{
			get 
			{
				CanReadProperty("MaBHXH", true);
				return _maBHXH;
			}
			set 
			{
				CanWriteProperty("MaBHXH", true);
				if (_maBHXH != value) 
				{
					_maBHXH = value;
					PropertyHasChanged("MaBHXH");
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
        public String MaTat
        {
            get
            {
                CanReadProperty("MaTat", true);
                return _MaTat;
            }
            set
            {
                CanWriteProperty("MaTat", true);
                if (_MaTat != value)
                {
                    _MaTat = value;
                    PropertyHasChanged("MaTat");
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
        public String hoten
        {
            get
            {
                CanReadProperty("hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("hoten");
                }
            }
        }
        public string  TenTinh
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _tenTinh;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_tenTinh.Equals(value))
                {
                    _tenTinh = value;
                    //PropertyHasChanged();
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maQH;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMQuanHuyen" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMQuanHuyen NewDMQuanHuyen()
        {
            return new DMQuanHuyen();
        }
        public static DMQuanHuyen NewDMQuanHuyen(string idtinh)
        {
            return new DMQuanHuyen(idtinh );
        }
		public static DMQuanHuyen GetDMQuanHuyen(String maQH)
		{
			return DataPortal.Fetch<DMQuanHuyen>(new Criteria(maQH));
		}
		
		/// <summary>
		/// Marks the <see cref="DMQuanHuyen" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMQuanHuyen(String maQH, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maQH));
		}
        private DMQuanHuyen(string idtinh)
        {
            _maTinh = idtinh;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMQuanHuyen()
		{	
			// Prevent direct creation
		}
        internal DMQuanHuyen(int ordernumber, String maQH, String matinh, String tenQH,  String mabhxh,string matat, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten, String tentinh)
        {
            _OrderNumber = ordernumber;
            _maQH = maQH;
            _maTinh = matinh;
            _tenQH = tenQH;
            _maBHXH = mabhxh ;   
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
            _tenTinh = tentinh;
            _MaTat = matat;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maQH;
			public String MaQH 
			{
				get
				{
					return _maQH;
				}
			}
			
			public Criteria(String maQH)
			{
				_maQH = maQH;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maQH.Equals(c._maQH)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maQH.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maQH;
            public String MaQH
            {
                get
                {
                    return _maQH;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maQH)
            {
                _maQH = maQH;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
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
		/// Retrieve an existing <see cref="DMQuanHuyen" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMQuanHuyen(String _maQH);
			// public override IDataReader GetDMQuanHuyen(String _maQH)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQH));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMQuanHuyen(crit.MaQH)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMQuanHuyen" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaQH") != null) _maQH = dr.GetString("MaQH");
			if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
			if (dr.GetString("TenQH") != null) _tenQH = dr.GetString("TenQH");
            if (dr.GetString("TenTinh") != null) _tenTinh = dr.GetString("TenTinh");
			if (dr.GetString("MaBHXH") != null) _maBHXH = dr.GetString("MaBHXH");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetString("MaTat") != null) _MaTat = dr.GetString("MaTat");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMQuanHuyen" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMQuanHuyen
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maQH = DataProvider.Instance().InsertDMQuanHuyen(_maTinh, _tenQH, _maBHXH, _MaTat, _maMay, _nguoiSD);
			// public abstract String InsertDMQuanHuyen(String _maQH, String _maTinh, String _tenQH, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMQuanHuyen(String _maQH, String _maTinh, String _tenQH, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQH, _maTinh, _tenQH, _maBHXH, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMQuanHuyen" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMQuanHuyen
			if (IsDirty){


                DataProvider.Instance().UpdateDMQuanHuyen(_maQH, _maTinh, _tenQH, _maBHXH, _MaTat, _maMay, _nguoiSD);
				// public abstract void UpdateDMQuanHuyen(String _maQH, String _maTinh, String _tenQH, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMQuanHuyen(String _maQH, String _maTinh, String _tenQH, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQH, _maTinh, _tenQH, _maBHXH, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,  _maQH));
		}

		/// <summary>
		/// Delete the <see cref="DMQuanHuyen" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMQuanHuyen
			DataProvider.Instance().DeleteDMQuanHuyen(crit.MaMay, crit.NguoiSD,   crit.MaQH);
			// public abstract void DeleteDMQuanHuyen(String _maQH);
			// public override void DeleteDMQuanHuyen(String _maQH);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQH);
			// }
		}

		#endregion
	}

}
