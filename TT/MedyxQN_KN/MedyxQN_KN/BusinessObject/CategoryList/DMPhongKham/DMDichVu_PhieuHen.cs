// *****************************************************************************************************
//  PhieuHen nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten PhieuHen        :	DMDichVu_PhieuHen
// Kieu doi tuong  :	DMDichVu_PhieuHen
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/5/2009 2:55:02 PM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong PhieuHen DataProvider.cs
// 3. Viet them cac ham tuong ung trong PhieuHen SqlDataProvider.cs
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
	/// This is a base generated class of <see cref="DMDichVu_PhieuHen" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_PhieuHen : BusinessBase<DMDichVu_PhieuHen>
	{
		#region Business Methods
		
		#region State Fields


        private String _NoiDungKQ = String.Empty;	
		private String _MaPH = String.Empty;
		private String _maDV = String.Empty;
       
		private String _tenHT = String.Empty;
       	private String _kq = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private int _OrderNumber;
        private String _hoten = String.Empty;

		#endregion
		
		#region Business Properties and Methods

        public String NoiDungKQ
        {
            get
            {
                CanReadProperty("NoiDungKQ", true);
                return _NoiDungKQ;
            }
            set
            {
                CanWriteProperty("NoiDungKQ", true);
                if (_NoiDungKQ != value)
                {
                    _NoiDungKQ = value;
                    PropertyHasChanged("NoiDungKQ");
                }
            }
        }

		public String MaPH
		{
			get 
			{
				CanReadProperty("MaPH", true);
				return _MaPH;
			}
			set 
			{
				CanWriteProperty("MaPH", true);
				if (_MaPH != value) 
				{
					_MaPH = value;
					PropertyHasChanged("MaPH");
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
      
		public String TenHT
		{
			get 
			{
				CanReadProperty("TenHT", true);
				return _tenHT;
			}
			set 
			{
				CanWriteProperty("TenHT", true);
				if (_tenHT != value) 
				{
					_tenHT = value;
					PropertyHasChanged("TenHT");
				}
			}
		}
		
		
		public String KQ
		{
			get 
			{
				CanReadProperty("KQ", true);
				return _kq;
			}
			set 
			{
				CanWriteProperty("KQ", true);
				if (_kq != value) 
				{
					_kq = value;
					PropertyHasChanged("KQ");
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
		protected override Object GetIdValue()
		{
			return _MaPH;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{

        //    //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
        //    ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenCPMau", 150));
        //    ValidationRules.AddRule<DMDichVu_PhieuHen>(StringRequired<DMDichVu_PhieuHen>, "TenCPMau");


        //}

        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_PhieuHen
        //{

        //    if (target._TenCPMau == null || target._TenCPMau.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_PhieuHen" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_PhieuHen NewDMDichVu_PhieuHen()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMDichVu_PhieuHen>();
        }
		public static DMDichVu_PhieuHen GetDMDichVu_PhieuHen(String MaPH)
		{
			return DataPortal.Fetch<DMDichVu_PhieuHen>(new Criteria(MaPH));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDichVu_PhieuHen" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_PhieuHen(String MaPH, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaPH));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDichVu_PhieuHen()
		{	
			// Prevent direct creation
		}
        internal DMDichVu_PhieuHen(int OrderNumber,
                 String MaPH ,
		         String maDV ,
		         String tenHT ,
		      
		         String kq ,
		         String ghichu ,
		         String maMay ,
		         SmartDate ngaySD ,
		         String nguoiSD ,
                 Boolean huy, string hoten, string noiDungKQ
                 )
        {
            _OrderNumber = OrderNumber;
                  _MaPH = MaPH  ;
                  _NoiDungKQ = noiDungKQ;
		          _tenHT = tenHT  ;
		        
		          _kq = kq  ;
		          _ghichu = ghichu  ;
		          _maMay = maMay  ;
		          _ngaySD = ngaySD  ;
		          _nguoiSD = nguoiSD  ;
		          _huy = huy ;
                  _hoten = hoten;
                 
                  _maDV = MaDV;
                
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaPH;
			public String MaPH 
			{
				get
				{
					return _MaPH;
				}
			}
			
			public Criteria(String MaPH)
			{
				_MaPH = MaPH;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaPH.Equals(c._MaPH)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaPH.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPH;
            public String MaPH
            {
                get
                {
                    return _MaPH;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPH)
            {
                _MaPH = MaPH ;
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
		/// Retrieve an existing <see cref="DMDichVu_PhieuHen" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_PhieuHen(String _MaPH);
			// public override IDataReader GetDMDichVu_PhieuHen(String _MaPH)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaPH));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_PhieuHen(crit.MaPH)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_PhieuHen" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPH") != null) _MaPH = dr.GetString("MaPH");
            if (dr.GetString("NoiDungKQ") != null) _NoiDungKQ = dr.GetString("NoiDungKQ");
		
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
          
			if (dr.GetString("TenHT") != null) _tenHT = dr.GetString("TenHT");
        
			if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_PhieuHen" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuHen
			// Copy & paste ham duoi day vao PhieuHen DataProvider.cs
			_MaPH = DataProvider.Instance().InsertDMDichVu_PhieuHen(_maDV, _tenHT,  _kq, _ghichu, _maMay, _nguoiSD , _NoiDungKQ );
			// public abstract String InsertDMDichVu_PhieuHen(String _maDV, String _tenHT, ByteArray _PhieuHenMau, String _kq, String _ghichu, String _maMay,  String _nguoiSD);
			// public override String InsertDMDichVu_PhieuHen(String _maDV, String _tenHT, ByteArray _PhieuHenMau, String _kq, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_PhieuHen_CREATE",  _maDV, _tenHT, _PhieuHenMau, _kq, _ghichu, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_PhieuHen" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuHen
			if (IsDirty){
				DataProvider.Instance().UpdateDMDichVu_PhieuHen(_MaPH, _maDV, _tenHT, _kq, _ghichu, _maMay, _nguoiSD , _huy, _NoiDungKQ);
				// public abstract void UpdateDMDichVu_PhieuHen(String _MaPH, String _maDV, String _tenHT, ByteArray _PhieuHenMau, String _kq, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateDMDichVu_PhieuHen(String _MaPH, String _maDV, String _tenHT, ByteArray _PhieuHenMau, String _kq, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_PhieuHen_UPDATE", _MaPH, _maDV, _tenHT, _PhieuHenMau, _kq, _ghichu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaPH));
		}

		/// <summary>
		/// Delete the <see cref="DMDichVu_PhieuHen" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuHen
            DataProvider.Instance().DeleteDMDichVu_PhieuHen(crit.MaMay, crit.NguoiSD, crit.MaPH);
			// public abstract void DeleteDMDichVu_PhieuHen(String _MaPH);
			// public override void DeleteDMDichVu_PhieuHen(String _MaPH);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_PhieuHen_DELETED", _MaPH);
			// }
		}

		#endregion
	}

}
