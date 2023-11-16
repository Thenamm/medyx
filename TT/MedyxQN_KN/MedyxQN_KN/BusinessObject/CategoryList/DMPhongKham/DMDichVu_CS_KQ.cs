// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh Csla Object Generator 1.0
//
// Ten file        :	DMDichVu_CS_KQ
// Kieu doi tuong  :	DMDichVu_CS_KQ
// Kieu Csla       :	EditableRoot
// Ngay tao        :	3/5/2009 4:12:22 PM
// Nguoi tao       :	HCABXT1
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.KQ
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.KQ
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
	/// This is a base generated class of <see cref="DMDichVu_CS_KQ" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_CS_KQ : BusinessBase<DMDichVu_CS_KQ>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maKQ = String.Empty;
		private String _maCS = String.Empty;
		private String _maKQCu = String.Empty;
		private String _maCSCu = String.Empty;
		private String _tenKQ = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private int _OrderNumber;
        private String _hoten = String.Empty;

		
		#endregion
		
		#region Business Properties and Methods
		
		public String MaKQ
		{
			get 
			{
				CanReadProperty("MaKQ", true);
				return _maKQ;
			}
			set 
			{
				CanWriteProperty("MaKQ", true);
				if (_maKQ != value) 
				{
					_maKQ = value;
					PropertyHasChanged("MaKQ");
				}
			}
		}
        public String MaKQCu
        {
            get
            {
                CanReadProperty("MaKQCu", true);
                return _maKQCu;
            }
            set
            {
                CanWriteProperty("MaKQCu", true);
                if (_maKQCu != value)
                {
                    _maKQCu = value;
                    PropertyHasChanged("MaKQCu");
                }
            }
        }
		public String MaCS
		{
			get 
			{
				CanReadProperty("MaCS", true);
				return _maCS;
			}
			set 
			{
				CanWriteProperty("MaCS", true);
				if (_maCS != value) 
				{
					_maCS = value;
					PropertyHasChanged("MaCS");
				}
			}
		}
        public String MaCSCu
        {
            get
            {
                CanReadProperty("MaCSCu", true);
                return _maCSCu;
            }
            set
            {
                CanWriteProperty("MaCSCu", true);
                if (_maCSCu != value)
                {
                    _maCSCu = value;
                    PropertyHasChanged("MaCSCu");
                }
            }
        }
		public String TenKQ
		{
			get 
			{
				CanReadProperty("TenKQ", true);
				return _tenKQ;
			}
			set 
			{
				CanWriteProperty("TenKQ", true);
				if (_tenKQ != value) 
				{
					_tenKQ = value;
					PropertyHasChanged("TenKQ");
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
			return _maKQ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenKQ", 150));
            ValidationRules.AddRule<DMDichVu_CS_KQ>(StringRequired<DMDichVu_CS_KQ>, "TenKQ");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_CS_KQ
        {

            if (target._tenKQ  == null || target._tenKQ.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDichVu_CS_KQ" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_CS_KQ NewDMDichVu_CS_KQ()
        {
            return DataPortal.Create<DMDichVu_CS_KQ>();
        }
        public static DMDichVu_CS_KQ NewDMDichVu_CS_KQ(string maCS)
        {
            return DataPortal.Create<DMDichVu_CS_KQ>(new CriteriaNew(maCS));
        }
		public static DMDichVu_CS_KQ GetDMDichVu_CS_KQ(String maKQ)
		{
			return DataPortal.Fetch<DMDichVu_CS_KQ>(new Criteria(maKQ));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDichVu_CS_KQ" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_CS_KQ(String macs, String maKQ, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, macs, maKQ));
		}
        private DMDichVu_CS_KQ(string maCS)
        {
            _maCS = maCS;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDichVu_CS_KQ()
		{	
			// Prevent direct creation
		}
        internal DMDichVu_CS_KQ( 
                         int OrderNumber,
                         String maKQ ,
		                 String maCS ,
             String maKQCu,
                         String maCSCu,
		                 String tenKQ ,
		                
		                 String ghichu ,
		                 String maMay ,
		                 SmartDate ngaySD ,
		                 String nguoiSD ,
		                 Boolean huy,         
                         String hoten )
        {
                     _maKQ = maKQ  ;
		             _maCS = maCS ;
                     _maKQCu = maKQCu;
                     _maCSCu = maCSCu;
		             _tenKQ = tenKQ  ;
		             
		             _ghichu = ghichu  ;
		             _maMay = maMay  ;
		             _ngaySD = ngaySD  ;
		             _nguoiSD = nguoiSD  ;
		             _huy = huy  ;
                     _OrderNumber = OrderNumber ;
                    _hoten = hoten  ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKQ;
			public String MaKQ 
			{
				get
				{
					return _maKQ;
				}
			}
			
			public Criteria(String maKQ)
			{
				_maKQ = maKQ;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maKQ.Equals(c._maKQ)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maKQ.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaKQ;
            public String MaKQ
            {
                get
                {
                    return _MaKQ;
                }
            }
            private String _MaCS;
            public String MaCS
            {
                get
                {
                    return _MaCS;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCS, String maKQ)
            {
                _MaKQ = maKQ;
                _MaCS = maCS;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }

        [Serializable()]
        protected class CriteriaNew
        {
            private String _maCS;
            public String maCS
            {
                get
                {
                    return _maCS;
                }
            }

            public CriteriaNew(String maCS)
            {
                _maCS = maCS;
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
		/// Retrieve an existing <see cref="DMDichVu_CS_KQ" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_CS_KQ(String _maKQ);
			// public override IDataReader GetDMDichVu_CS_KQ(String _maKQ)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKQ));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_CS_KQ(crit.MaKQ)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_CS_KQ" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKQ") != null) _maKQ = dr.GetString("MaKQ");
			if (dr.GetString("MaCS") != null) _maCS = dr.GetString("MaCS");
            _maKQCu = _maKQ;
            _maCSCu = _maCS;
			
			if (dr.GetString("TenKQ") != null) _tenKQ = dr.GetString("TenKQ");
			
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_CS_KQ" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected void DataPortal_Create(CriteriaNew param)
        {
            _maCS = param.maCS;
           
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_CS_KQ
			// Copy & paste ham duoi day vao file DataProvider.KQ
            
              
			_maKQ = DataProvider.Instance().InsertDMDichVu_CS_KQ(_maCS, _maKQ, _ghichu, _maMay,  _nguoiSD );
			// public abstract String InsertDMDichVu_CS_KQ(String _maCS, String _tenKQ, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD);
			// public override String InsertDMDichVu_CS_KQ(String _maCS, String _tenKQ, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDichVu_CS_KQ_CREATE", _maCS, _tenKQ, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD ), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_CS_KQ" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_CS_KQ
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDichVu_CS_KQ(_maKQ, _maCS,_maKQCu, _ghichu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateDMDichVu_CS_KQ(String _maKQ, String _maCS, String _tenKQ, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateDMDichVu_CS_KQ(String _maKQ, String _maCS, String _tenKQ, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDichVu_CS_KQ_UPDATE", _maKQ, _maCS, _tenKQ, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,_maCS, _maKQ));
		}

		/// <summary>
		/// Delete the <see cref="DMDichVu_CS_KQ" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_CS_KQ
              
              DataProvider.Instance().DeleteDMDichVu_CS_KQ(crit.MaMay, crit.NguoiSD, crit.MaCS, crit.MaKQ);
			// public abstract void DeleteDMDichVu_CS_KQ(String _maKQ);
			// public override void DeleteDMDichVu_CS_KQ(String _maKQ);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_DELETED", _maKQ);
			// }
		}
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maKQ = DataProvider.Instance().InsertDMDichVu_CS_KQ(_maCS, _maKQ, _ghichu, _maMay, _nguoiSD);
		
           
        }
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMDichVu_CS_KQ(_maKQ, _maCS, _maCSCu, _maKQCu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateDMDichVu_CS_KQ(String _maKQ, String _maCS, String _tenKQ, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateDMDichVu_CS_KQ(String _maKQ, String _maCS, String _tenKQ, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDichVu_CS_KQ_UPDATE", _maKQ, _maCS, _tenKQ, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD , _huy);
                // }				
            }
            MarkOld();
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            
            DataProvider.Instance().DeleteDMDichVu_CS_KQ(_maMay, _nguoiSD,_maCS, _maKQ);

            MarkNew();
        }
		#endregion
	}

}
