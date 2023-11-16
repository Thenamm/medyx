// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNoiXuat
// Kieu doi tuong  :	DMNoiXuat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/11/2009 4:18:48 PM
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
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMNoiXuat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNoiXuat : BusinessBase<DMNoiXuat>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNoiXuat = String.Empty;
		private Byte _loai = 0;
		private String _tenNoiXuat = String.Empty;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
        private String _maMay = String.Empty;
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaNoiXuat
		{
			get 
			{
                CanReadProperty("MaNoiXuat", true);
				return _maNoiXuat;
			}
			set 
			{
                CanWriteProperty("MaNoiXuat", true);
				if (_maNoiXuat != value) 
				{
					_maNoiXuat = value;
                    PropertyHasChanged("MaNoiXuat");
				}
			}
		}
		
		public Byte Loai
		{
			get 
			{
				CanReadProperty("Loai", true);
				return _loai;
			}
			set 
			{
				CanWriteProperty("Loai", true);
				if (_loai != value) 
				{
					_loai = value;
					PropertyHasChanged("Loai");
				}
			}
		}
		
		public String TenNoiXuat
		{
			get 
			{
                CanReadProperty("TenNoiXuat", true);
				return _tenNoiXuat;
			}
			set 
			{
                CanWriteProperty("TenNoiXuat", true);
				if (_tenNoiXuat != value) 
				{
					_tenNoiXuat = value;
                    PropertyHasChanged("TenNoiXuat");
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
			return _maNoiXuat;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMNoiXuat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNoiXuat NewDMNoiXuat()
        {
            //return DataPortal.Create<DMNCC>();
            return new DMNoiXuat();
        }
		public static DMNoiXuat GetDMNoiXuat(String maNoiXuat)
		{
			return DataPortal.Fetch<DMNoiXuat>(new Criteria(maNoiXuat));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNoiXuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNoiXuat(String maNoiXuat, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNoiXuat));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNoiXuat()
		{	
			// Prevent direct creation
		}

        internal DMNoiXuat(
                                 int OrderNumber,
                                 String maNoi ,
		                         Byte loai ,
		                         String tenNoi ,
		                         String ghichu ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
                                 string mamay
                                // string hoten
             )
        {
                          _maNoiXuat = maNoi ;
		                  _loai = loai ;
		                  _tenNoiXuat = tenNoi ;
		                  _ghichu = ghichu ;
		                  _huy = huy;
		                  _ngaySD = ngaySD ;
                          _maMay = mamay;
		                  _nguoiSD = nguoiSD ;
                          _OrderNumber = OrderNumber;
                          //_hoten = hoten;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNoiXuat;
			public String MaNoiXuat 
			{
				get
				{
					return _maNoiXuat;
				}
			}
			
			public Criteria(String maNoiXuat)
			{
				_maNoiXuat = maNoiXuat;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNoiXuat.Equals(c._maNoiXuat)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNoiXuat.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNoiXuat;
            public String MaNoiXuat
            {
                get
                {
                    return _maNoiXuat;
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
            public OtherCriteria(String Mamay, String Nguoisd, String Manoixuat)
            {
                _maNoiXuat = Manoixuat;
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
		/// Retrieve an existing <see cref="DMNoiXuat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNoiXuat(String _maNoi);
			// public override IDataReader GetDMNoiXuat(String _maNoi)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNoi));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNoiXuat(crit.MaNoiXuat)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNoiXuat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaNoiXuat") != null) _maNoiXuat = dr.GetString("MaNoiXuat");
			if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetString("TenNoiXuat") != null) _tenNoiXuat = dr.GetString("TenNoiXuat");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            //if (dr.GetString("HOTEN") != null) _hoten = dr.GetString("hoten");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNoiXuat" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNoiXuat
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maNoiXuat = DataProvider.Instance().InsertDMNoiXuat(_loai, _tenNoiXuat, _ghichu, _maMay, _nguoiSD);
            // public abstract String InsertDMNoiXuat(Byte _loai, String _tenNoiXuat, String _ghichu, string _maMay, String _nguoiSD);
            // public override String InsertDMNoiXuat(Byte _loai, String _tenNoiXuat, String _ghichu,string _maMay,  String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNoiXuat_CREATE", _loai, _tenNoiXuat, _ghichu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNoiXuat" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNoiXuat
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMNoiXuat(_maNoiXuat, _loai, _tenNoiXuat, _ghichu,_maMay , _huy, _nguoiSD);
				// public abstract void UpdateDMNoiXuat(String _maNoi, Byte _loai, String _tenNoi, String _ghichu,string _maMay Boolean _huy, String _nguoiSD);
				// public override void UpdateDMNoiXuat(String _maNoi, Byte _loai, String _tenNoi, String _ghichu,string _maMay Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNoiXuat_UPDATED", _maNoi, _loai, _tenNoi, _ghichu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNoiXuat));
		}

		/// <summary>
		/// Delete the <see cref="DMNoiXuat" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNoiXuat
            DataProvider.Instance().DeleteDMNoiXuat(crit.MaMay, crit.NguoiSD, crit.MaNoiXuat);
			// public abstract void DeleteDMNoiXuat(String _maNoi);
			// public override void DeleteDMNoiXuat(String _maNoi)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNoiXuat_DELETED", _maNoi);
			// }
		}

		#endregion
	}

}
