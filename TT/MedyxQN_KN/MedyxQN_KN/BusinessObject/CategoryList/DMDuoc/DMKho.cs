// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMKho
// Kieu doi tuong  :	DMKho
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/7/2008 9:56:20 AM
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
	/// This is a base generated class of <see cref="DMKho" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMKho : BusinessBase<DMKho>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maKho = String.Empty;
		private String _tenKho = String.Empty;
		private Byte _loai;
        private Boolean _kieukho = false;
        private Boolean _khoban = false;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
        private bool _chon = false;

		#endregion
		
		#region Business Properties and Methods
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
		public String MaKho
		{
			get 
			{
				CanReadProperty("MaKho", true);
				return _maKho;
			}
			set 
			{
				CanWriteProperty("MaKho", true);
				if (_maKho != value) 
				{
					_maKho = value;
					PropertyHasChanged("MaKho");
				}
			}
		}
		
		public String TenKho
		{
			get 
			{
				CanReadProperty("TenKho", true);
				return _tenKho;
			}
			set 
			{
				CanWriteProperty("TenKho", true);
				if (_tenKho != value) 
				{
					_tenKho = value;
					PropertyHasChanged("TenKho");
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

        public Boolean kieukho
        {
            get
            {
                CanReadProperty("kieukho", true);
                return _kieukho;
            }
            set
            {
                CanWriteProperty("kieukho", true);
                if (_kieukho != value)
                {
                    _kieukho = value;
                    PropertyHasChanged("kieukho");
                }
            }
        }

        public Boolean khoban
        {
            get
            {
                CanReadProperty("khoban", true);
                return _khoban;
            }
            set
            {
                CanWriteProperty("khoban", true);
                if (_khoban != value)
                {
                    _khoban = value;
                    PropertyHasChanged("khoban");
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
        public bool chon
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _chon;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_chon.Equals(value))
                {
                    _chon = value;
                    //PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maKho;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	    protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenKho", 150));
            ValidationRules.AddRule<DMKho>(StringRequired<DMKho>, "TenKho");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMKho
        {

            if (target._tenKho == null || target._tenKho.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMKho" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMKho NewDMKho()
        {
            //return new DMKho();
            return DataPortal.Create<DMKho>();
        }
        public static DMKho GetDMKho(String maKho)
		{
            return DataPortal.Fetch<DMKho>(new Criteria(maKho));
		}
		
		/// <summary>
		/// Marks the <see cref="DMKho" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMKho(String maKho, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maKho));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMKho()
		{	
			// Prevent direct creation
		}

        internal DMKho(int ordernumber, string Makho, string Tenkho, Byte loai, Boolean kieukho, Boolean khoban, string ghichu, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, Boolean chon, string hoten)
        {
            _OrderNumber = ordernumber;
            _maKho   = Makho;
            _tenKho  = Tenkho ;
            _loai = loai ;
            _kieukho = kieukho;
            _khoban = khoban;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _chon = chon;
            _hoten = hoten;
            _ghichu = ghichu ;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKho;
			public String MaKho 
			{
				get
				{
					return _maKho;
				}
			}
			
			public Criteria(String maKho)
			{
				_maKho = maKho;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maKho.Equals(c._maKho)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maKho.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maKho)
            {
                _maKho = maKho;
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
		/// Retrieve an existing <see cref="DMKho" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMKho(String _maKho);
			// public override IDataReader GetDMKho(String _maKho)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKho));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKho(crit.MaKho)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMKho" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKho") != null) _maKho = dr.GetString("MaKho");
			if (dr.GetString("TenKho") != null) _tenKho = dr.GetString("TenKho");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Kieukho") != null) _kieukho  = dr.GetBoolean("Kieukho");
            if (dr.GetBoolean("Khoban") != null) _khoban = dr.GetBoolean("Khoban");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMKho" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMKho
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maKho = DataProvider.Instance().InsertDMKho(_tenKho, _kieukho,_khoban,  _ghichu, _maMay, _nguoiSD ,_loai );
			// public abstract String InsertDMKho(String _maKho, String _tenKho, Boolean _khochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMKho(String _maKho, String _tenKho, Boolean _khochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKho, _tenKho, _khochinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMKho" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKho
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMKho(_maKho, _tenKho, _kieukho,_khoban, _ghichu, _maMay, _nguoiSD ,_huy);
				// public abstract void UpdateDMKho(String _maKho, String _tenKho, Boolean _khochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMKho(String _maKho, String _tenKho, Boolean _khochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKho, _tenKho, _khochinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maKho));
		}

		/// <summary>
		/// Delete the <see cref="DMKho" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKho
			DataProvider.Instance().DeleteDMKho(crit.MaMay, crit.NguoiSD,  crit.MaKho);
			// public abstract void DeleteDMKho(String _maKho);
			// public override void DeleteDMKho(String _maKho);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKho);
			// }
		}

		#endregion
	}

}
