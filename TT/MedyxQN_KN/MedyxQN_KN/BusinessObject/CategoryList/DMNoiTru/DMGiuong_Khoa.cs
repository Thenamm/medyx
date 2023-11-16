// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMGiuong_Khoa
// Kieu doi tuong  :	DMGiuong_Khoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/10/2009 8:51:46 AM
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
	/// This is a base generated class of <see cref="DMGiuong_Khoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMGiuong_Khoa : BusinessBase<DMGiuong_Khoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _sophong = String.Empty;
		private String _sogiuong = String.Empty;
        private String _sophongcu = String.Empty;
        private String _sogiuongcu = String.Empty;
		private String _ghiChu = String.Empty;
		private string _makhoa = String.Empty;
        private Boolean _tinhtrang = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String sophong
		{
			get 
			{
				CanReadProperty("sophong", true);
				return _sophong;
			}
			set 
			{
				CanWriteProperty("sophong", true);
				if (_sophong != value) 
				{
					_sophong = value;
					PropertyHasChanged("sophong");
				}
			}
		}
		
		public String sogiuong
		{
			get 
			{
				CanReadProperty("sogiuong", true);
				return _sogiuong;
			}
			set 
			{
				CanWriteProperty("sogiuong", true);
				if (_sogiuong != value) 
				{
					_sogiuong = value;
					PropertyHasChanged("sogiuong");
				}
			}
		}

        public String sophongcu
        {
            get
            {
                CanReadProperty("sophongcu", true);
                return _sophongcu;
            }
            set
            {
                CanWriteProperty("sophongcu", true);
                if (_sophongcu != value)
                {
                    _sophongcu = value;
                    PropertyHasChanged("sophongcu");
                }
            }
        }

        public String sogiuongcu
        {
            get
            {
                CanReadProperty("sogiuongcu", true);
                return _sogiuongcu;
            }
            set
            {
                CanWriteProperty("sogiuongcu", true);
                if (_sogiuongcu != value)
                {
                    _sogiuongcu = value;
                    PropertyHasChanged("sogiuongcu");
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
		
		public string makhoa
		{
			get 
			{
				CanReadProperty("makhoa", true);
				return _makhoa;
			}
			set 
			{
				CanWriteProperty("makhoa", true);
				if (_makhoa != value) 
				{
					_makhoa = value;
					PropertyHasChanged("makhoa");
				}
			}
		}

        public Boolean tinhtrang
        {
            get
            {
                CanReadProperty("tinhtrang", true);
                return _tinhtrang;
            }
            set
            {
                CanWriteProperty("tinhtrang", true);
                if (_tinhtrang != value)
                {
                    _tinhtrang = value;
                    PropertyHasChanged("tinhtrang");
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
			return _sophong;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("sogiuong", 150));
            ValidationRules.AddRule<DMGiuong_Khoa>(StringRequired<DMGiuong_Khoa>, "sogiuong");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMGiuong_Khoa
        {

            if (target._sogiuong == null || target._sogiuong.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMGiuong_Khoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMGiuong_Khoa NewDMGiuong_Khoa()
        {
            return DataPortal.Create<DMGiuong_Khoa>();
        }
		public static DMGiuong_Khoa GetDMGiuong_Khoa(String makhoa,String sophong,String sogiuong)
		{
			return DataPortal.Fetch<DMGiuong_Khoa>(new Criteria(makhoa,sophong,sogiuong ));
		}
		
		/// <summary>
		/// Marks the <see cref="DMGiuong_Khoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMGiuong_Khoa(String makhoa, String sophong, String sogiuong, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,  sophong,sogiuong,makhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMGiuong_Khoa()
		{	
			// Prevent direct creation
		}

        internal DMGiuong_Khoa(
                             int OrderNumber,
                             String sophong ,
		                     String sogiuong ,
		                     String ghiChu ,
                             String makhoa,
                             Boolean tinhtrang,
		                     String maMay ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
                             String hoten 
         
                            )
        {
                               _OrderNumber = OrderNumber ;
                              _sophong = sophong ;
		                      _sogiuong = sogiuong ;
                              _tinhtrang = tinhtrang;
		                      _ghiChu = ghiChu ;
		                      _makhoa = makhoa ;
		                      _maMay = maMay ;
		                      _huy = huy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
                              _hoten = hoten ;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _sophong;
			public String sophong 
			{
				get
				{
					return _sophong;
				}
			}
            private String _sogiuong;
            public String sogiuong
            {
                get
                {
                    return _sogiuong;
                }
            }
            private string _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            public Criteria( String mmakhoa,String msophong, String msogiuong)
			{
				_sophong = msophong;
                _sogiuong = msogiuong;
                _makhoa = mmakhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sophong.Equals(c._sophong)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sophong.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _sophong;
            public String sophong
            {
                get
                {
                    return _sophong;
                }
            }
            private String _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
                }
            }

            private String _sogiuong;
            public String sogiuong
            {
                get
                {
                    return _sogiuong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String sophong, String sogiuong, String makhoa)
            {
                _sophong = sophong;
                _makhoa = makhoa;
                _sogiuong = sogiuong;
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
		/// Retrieve an existing <see cref="DMGiuong_Khoa" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMGiuong_Khoa(String _sophong);
			// public override IDataReader GetDMGiuong_Khoa(String _sophong)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sophong));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMGiuong_Khoa(crit.sophong, crit.sogiuong, crit.makhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMGiuong_Khoa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("sophong") != null) _sophong = dr.GetString("sophong");
			if (dr.GetString("sogiuong") != null) _sogiuong = dr.GetString("sogiuong");
            if (dr.GetString("sophongcu") != null) _sophongcu = dr.GetString("sophongcu");
            if (dr.GetString("sogiuongcu") != null) _sogiuongcu = dr.GetString("sogiuongcu");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("makhoa") != null) _makhoa = dr.GetString("makhoa");
            if (dr.GetBoolean("tinhtrang") != null) _tinhtrang = dr.GetBoolean("tinhtrang");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMGiuong_Khoa" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMGiuong_Khoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_sophong = DataProvider.Instance().InsertDMGiuong_Khoa(_sophong, _makhoa,_sogiuong, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMGiuong_Khoa(String _sogiuong, String _ghiChu, Boolean _makhoa, String _maMay, String _nguoiSD);
			// public override String InsertDMGiuong_Khoa(String _sogiuong, String _ghiChu, Boolean _makhoa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_Khoa_CREATE", _sogiuong, _ghiChu, _makhoa, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMGiuong_Khoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiuong_Khoa

			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMGiuong_Khoa(_sophong, _makhoa, _sogiuong, _ghiChu, _tinhtrang, _maMay, _huy, _nguoiSD, _sophongcu, _sogiuongcu);
				// public abstract void UpdateDMGiuong_Khoa(String _sophong, String _sogiuong, String _ghiChu, Boolean _makhoa, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMGiuong_Khoa(String _sophong, String _sogiuong, String _ghiChu, Boolean _makhoa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_Khoa_UPDATED", _sophong, _sogiuong, _ghiChu, _makhoa, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _sophong, _sogiuong,_makhoa));
		}

		/// <summary>
		/// Delete the <see cref="DMGiuong_Khoa" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiuong_Khoa
            DataProvider.Instance().DeleteDMGiuong_Khoa(crit.MaMay, crit.NguoiSD, crit.sophong,crit .sogiuong,crit .makhoa);
			// public abstract void DeleteDMGiuong_Khoa(String _sophong);
			// public override void DeleteDMGiuong_Khoa(String _sophong);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_Khoa_DELETED", _sophong);
			// }
		}

		#endregion
	}

}
