// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMPhuongXa
// Kieu doi tuong  :	DMPhuongXa
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
	/// This is a base generated class of <see cref="DMPhuongXa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMPhuongXa : BusinessBase<DMPhuongXa>
	{
		#region Business Methods
		
		#region State Fields
        private String _MaTat = String.Empty;
		private String _MaPXa = String.Empty;
		private String _MaQH = String.Empty;
		private String _TenPXa = String.Empty;
		private String _maBHXH = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _TenQH = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
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
		public String MaPXa
		{
			get 
			{
				CanReadProperty("MaPXa", true);
				return _MaPXa;
			}
			set 
			{
				CanWriteProperty("MaPXa", true);
				if (_MaPXa != value) 
				{
					_MaPXa = value;
					PropertyHasChanged("MaPXa");
				}
			}
		}
		
		public String MaQH
		{
			get 
			{
				CanReadProperty("MaQH", true);
				return _MaQH;
			}
			set 
			{
				CanWriteProperty("MaQH", true);
				if (_MaQH != value) 
				{
					_MaQH = value;
					PropertyHasChanged("MaQH");
				}
			}
		}
		
		public String TenPXa
		{
			get 
			{
				CanReadProperty("TenPXa", true);
				return _TenPXa;
			}
			set 
			{
				CanWriteProperty("TenPXa", true);
				if (_TenPXa != value) 
				{
					_TenPXa = value;
					PropertyHasChanged("TenPXa");
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
        public string  TenQH
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _TenQH;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TenQH.Equals(value))
                {
                    _TenQH = value;
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
			return _MaPXa;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMPhuongXa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMPhuongXa NewDMPhuongXa()
        {
            return new DMPhuongXa();
        }
        public static DMPhuongXa NewDMPhuongXa(string idtinh)
        {
            return new DMPhuongXa(idtinh );
        }
		public static DMPhuongXa GetDMPhuongXa(String MaPXa)
		{
			return DataPortal.Fetch<DMPhuongXa>(new Criteria(MaPXa));
		}
		
		/// <summary>
		/// Marks the <see cref="DMPhuongXa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMPhuongXa(String MaPXa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaPXa));
		}
        private DMPhuongXa(string idtinh)
        {
            _MaQH = idtinh;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMPhuongXa()
		{	
			// Prevent direct creation
		}
        internal DMPhuongXa(int ordernumber, String MaPXa, String MaQH, String TenPXa, String mabhxh, string matat, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten, String TenQH)
        {
            _OrderNumber = ordernumber;
            _MaPXa = MaPXa;
            _MaQH = MaQH;
            _TenPXa = TenPXa;
            _maBHXH = mabhxh ;   
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
            _TenQH = TenQH;
            _MaTat = matat;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaPXa;
			public String MaPXa 
			{
				get
				{
					return _MaPXa;
				}
			}
			
			public Criteria(String MaPXa)
			{
				_MaPXa = MaPXa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaPXa.Equals(c._MaPXa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaPXa.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPXa;
            public String MaPXa
            {
                get
                {
                    return _MaPXa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPXa)
            {
                _MaPXa = MaPXa;
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
		/// Retrieve an existing <see cref="DMPhuongXa" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMPhuongXa(String _MaPXa);
			// public override IDataReader GetDMPhuongXa(String _MaPXa)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaPXa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMPhuongXa(crit.MaPXa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMPhuongXa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPXa") != null) _MaPXa = dr.GetString("MaPXa");
			if (dr.GetString("MaQH") != null) _MaQH = dr.GetString("MaQH");
			if (dr.GetString("TenPXa") != null) _TenPXa = dr.GetString("TenPXa");
            if (dr.GetString("TenQH") != null) _TenQH = dr.GetString("TenQH");
			if (dr.GetString("MaBHXH") != null) _maBHXH = dr.GetString("MaBHXH");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetString("MaTat") != null) _MaTat = dr.GetString("MaTat");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMPhuongXa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMPhuongXa
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_MaPXa = DataProvider.Instance().InsertDMPhuongXa(_MaQH, _TenPXa, _maBHXH, _MaTat , _maMay, _nguoiSD);
			// public abstract String InsertDMPhuongXa(String _MaPXa, String _MaQH, String _TenPXa, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMPhuongXa(String _MaPXa, String _MaQH, String _TenPXa, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaPXa, _MaQH, _TenPXa, _maBHXH, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMPhuongXa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhuongXa
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMPhuongXa(_MaPXa, _MaQH, _TenPXa, _maBHXH,_MaTat, _maMay, _nguoiSD);
				// public abstract void UpdateDMPhuongXa(String _MaPXa, String _MaQH, String _TenPXa, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMPhuongXa(String _MaPXa, String _MaQH, String _TenPXa, String _maBHXH, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaPXa, _MaQH, _TenPXa, _maBHXH, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,  _MaPXa));
		}

		/// <summary>
		/// Delete the <see cref="DMPhuongXa" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhuongXa
			DataProvider.Instance().DeleteDMPhuongXa(crit.MaMay, crit.NguoiSD,   crit.MaPXa);
			// public abstract void DeleteDMPhuongXa(String _MaPXa);
			// public override void DeleteDMPhuongXa(String _MaPXa);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaPXa);
			// }
		}

		#endregion
	}

}
