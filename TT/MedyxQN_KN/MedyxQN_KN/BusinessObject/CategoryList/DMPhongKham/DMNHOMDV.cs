// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNhomDV
// Kieu doi tuong  :	DMNhomDV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/29/2008 4:02:48 PM
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
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMNhomDV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNhomDV : BusinessBase<DMNhomDV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNHOMDV = String.Empty;
		private String _tenNHOMDV = String.Empty;
		private String _tentat = String.Empty;
		private String _maBenhpham = String.Empty;
        private String _maChungloai = String.Empty;
		private Byte _cap = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate();
		private String _nguoiHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate();
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _idparent = String.Empty;
        private String _hoten = String.Empty;
        private String _tenTA = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaNHOMDV
		{
			get 
			{
				CanReadProperty("MaNHOMDV", true);
				return _maNHOMDV;
			}
			set 
			{
				CanWriteProperty("MaNHOMDV", true);
				if (_maNHOMDV != value) 
				{
					_maNHOMDV = value;
					PropertyHasChanged("MaNHOMDV");
				}
			}
		}
		
		public String TenNHOMDV
		{
			get 
			{
				CanReadProperty("TenNHOMDV", true);
				return _tenNHOMDV;
			}
			set 
			{
				CanWriteProperty("TenNHOMDV", true);
				if (_tenNHOMDV != value) 
				{
					_tenNHOMDV = value;
					PropertyHasChanged("TenNHOMDV");
				}
			}
		}
		
		public String Tentat
		{
			get 
			{
				CanReadProperty("Tentat", true);
				return _tentat;
			}
			set 
			{
				CanWriteProperty("Tentat", true);
				if (_tentat != value) 
				{
					_tentat = value;
					PropertyHasChanged("Tentat");
				}
			}
		}
		
		public String MaBenhpham
		{
			get 
			{
				CanReadProperty("MaBenhpham", true);
				return _maBenhpham;
			}
			set 
			{
				CanWriteProperty("MaBenhpham", true);
				if (_maBenhpham != value) 
				{
					_maBenhpham = value;
					PropertyHasChanged("MaBenhpham");
				}
			}
		}

        public String MaChungloai
        {
            get
            {
                CanReadProperty("MaChungloai", true);
                return _maChungloai;
            }
            set
            {
                CanWriteProperty("MaChungloai", true);
                if (_maChungloai != value)
                {
                    _maChungloai = value;
                    PropertyHasChanged("MaChungloai");
                }
            }
        }

		public Byte Cap
		{
			get 
			{
				CanReadProperty("Cap", true);
				return _cap;
			}
			set 
			{
				CanWriteProperty("Cap", true);
				if (_cap != value) 
				{
					_cap = value;
					PropertyHasChanged("Cap");
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
		
		public SmartDate NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy != value) 
				{
					_ngayHuy = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
				}
			}
		}
		
		public SmartDate NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
				return _ngayLap;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap != value) 
				{
					_ngayLap = value;
					PropertyHasChanged("NgayLap");
				}
			}
		}
		
		public String NguoiLap
		{
			get 
			{
				CanReadProperty("NguoiLap", true);
				return _nguoiLap;
			}
			set 
			{
				CanWriteProperty("NguoiLap", true);
				if (_nguoiLap != value) 
				{
					_nguoiLap = value;
					PropertyHasChanged("NguoiLap");
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

        public String idparent
        {
            get
            {
                CanReadProperty("idparent", true);
                return _idparent;
            }
            set
            {
                CanWriteProperty("idparent", true);
                if (_idparent != value)
                {
                    _idparent = value;
                    PropertyHasChanged("idparent");
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
        //public String maChungloai
        //{
        //    get
        //    {
        //        CanReadProperty("maChungloai", true);
        //        return _maChungloai;
        //    }
        //    set
        //    {
        //        CanWriteProperty("maChungloai", true);
        //        if (_maChungloai != value)
        //        {
        //            _maChungloai = value;
        //            PropertyHasChanged("maChungloai");
        //        }
        //    }
        //}
        public String tenTA
        {
            get
            {
                CanReadProperty("tenTA", true);
                return _tenTA;
            }
            set
            {
                CanWriteProperty("tenTA", true);
                if (_tenTA != value)
                {
                    _tenTA = value;
                    PropertyHasChanged("tenTA");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maNHOMDV;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNHOMDV", 150));
            ValidationRules.AddRule<DMNhomDV>(StringRequired<DMNhomDV>, "TenNHOMDV");
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNhomDV
        {
            try
            {
                if (target._tenNHOMDV == null || target._tenNHOMDV.Trim().Length == 0)
                {
                    e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
                return false;
            }


            
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMNhomDV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNhomDV NewDMNhomDV()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMNhomDV>();
        }
        public static DMNhomDV NewDMNhomDV(string idparent)
        {
            //return new DMNhomThuoc(idparent);
            return DataPortal.Create<DMNhomDV>(new Criteria(idparent));
        }
		public static DMNhomDV GetDMNhomDV(String maNHOMDV)
		{
			return DataPortal.Fetch<DMNhomDV>(new Criteria(maNHOMDV));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNhomDV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNhomDV(String maNHOMDV, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNHOMDV));
		}
        private DMNhomDV(string idparent)
        {
            _idparent = idparent;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNhomDV()
		{	
			// Prevent direct creation
		}
        internal DMNhomDV(   String maNHOMDV,
		                     String tenNHOMDV ,
		                     String tentat ,
		                     String maBenhpham ,
		                     Byte cap ,
		                     String maMay ,
		                     Boolean huy ,
		                     SmartDate NgayHuy ,
		                     String nguoiHuy ,
		                     SmartDate NgayLap ,
		                     String nguoiLap ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
                             String idparent ,
                             String hoten,
                             String maChungLoai,
                             String tenTA)
        {
          
                            _maNHOMDV = maNHOMDV;
		                     _tenNHOMDV= tenNHOMDV ;
		                     _maBenhpham= maBenhpham ;
                             _cap = cap;
		                     _maMay= maMay ;
		                     _huy= huy ;
		                     _ngayHuy= NgayHuy ;
		                    _nguoiHuy = nguoiHuy ;
		                     _ngayLap= NgayLap ;
		                    _nguoiLap = nguoiLap ;
		                     _ngaySD= ngaySD ;
		                     _nguoiSD= nguoiSD ;
                             _idparent= idparent ;
                            _hoten = hoten ;
                            _maChungloai = maChungLoai;
                            _tenTA = tenTA;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNHOMDV;
			public String MaNHOMDV 
			{
				get
				{
					return _maNHOMDV;
				}
			}
			
			public Criteria(String maNHOMDV)
			{
				_maNHOMDV = maNHOMDV;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNHOMDV.Equals(c._maNHOMDV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNHOMDV.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNhomDV;
            public String maNhomDV
            {
                get
                {
                    return _maNhomDV;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNhomDV)
            {
                _maNhomDV = maNhomDV;
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
		/// Retrieve an existing <see cref="DMNhomDV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNhomDV(String _maNHOMDV);
			// public override IDataReader GetDMNhomDV(String _maNHOMDV)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNHOMDV));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNhomDV(crit.MaNHOMDV)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNhomDV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaNHOMDV") != null) _maNHOMDV = dr.GetString("MaNHOMDV");
			if (dr.GetString("TenNHOMDV") != null) _tenNHOMDV = dr.GetString("TenNHOMDV");
			if (dr.GetString("Tentat") != null) _tentat = dr.GetString("Tentat");
			if (dr.GetString("MaBenhpham") != null) _maBenhpham = dr.GetString("MaBenhpham");
			if (dr.GetByte("Cap") != null) _cap = dr.GetByte("Cap");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgayLap") != null) _ngayLap = dr.GetSmartDate("NgayLap");
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Machungloai") != null) _maChungloai = dr.GetString("Machungloai");
            if (dr.GetString("tenta") != null) _tenTA = dr.GetString("tenta");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNhomDV" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        protected void DataPortal_Create(Criteria param)
        {
            _idparent = param.MaNHOMDV;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNhomDV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maNHOMDV = DataProvider.Instance().InsertDMNhomDV(_tenNHOMDV, _tentat, _maBenhpham, _maMay, _nguoiSD , _idparent,_maChungloai, _tenTA );
			// public abstract String InsertDMNhomDV(String _tenNHOMDV, String _tentat, String _maBenhpham, String _maMay, String _nguoiLap, String idparent);
            // public override String InsertDMNhomDV(String _tenNHOMDV, String _tentat, String _maBenhpham, String _maMay, String _nguoiLap, String idparent)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenNHOMDV, _tentat, _maBenhpham, _maMay,  _nguoiLap, idparent));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNhomDV" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhomDV
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMNhomDV(_maNHOMDV, _tenNHOMDV, _tentat, _maBenhpham, _maMay, _huy, _nguoiSD ,_maChungloai,_tenTA  );
                // public abstract void UpdateDMNhomDV(String _maNHOMDV, String _tenNHOMDV, String _tentat, String _maBenhpham, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMNhomDV(String _maNHOMDV, String _tenNHOMDV, String _tentat, String _maBenhpham, String _maMay, Boolean _huy, String _nguoiSD)
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNHOMDV, _tenNHOMDV, _tentat, _maBenhpham, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNHOMDV));
		}

		/// <summary>
		/// Delete the <see cref="DMNhomDV" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhomDV
            DataProvider.Instance().DeleteDMNhomDV(crit.MaMay, crit.NguoiSD, crit.maNhomDV);
			// public abstract void DeleteDMNhomDV(String _maNHOMDV);
			// public override void DeleteDMNhomDV(String _maNHOMDV);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNHOMDV);
			// }
		}

		#endregion
	}

}
