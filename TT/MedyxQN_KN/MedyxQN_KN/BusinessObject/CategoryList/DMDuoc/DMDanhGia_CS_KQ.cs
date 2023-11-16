// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDanhGia_CS_KQ
// Kieu doi tuong  :	DMDanhGia_CS_KQ
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
	/// This is a base generated class of <see cref="DMDanhGia_CS_KQ" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDanhGia_CS_KQ : BusinessBase<DMDanhGia_CS_KQ>
	{
		#region Business Methods
		
		#region State Fields
        private String _TenDG = String.Empty;
       	private String _MaThuoc = String.Empty;
        private String _maDG = String.Empty;
		private String _maCS = String.Empty;
		private String _TenTM = String.Empty;
        private String _TenDVT = String.Empty;
        private Decimal _GHTu = 0;
        private Decimal _GHDen = 0;
        private String _YeuCauTT = String.Empty;
        private String _YeuCau = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private int _OrderNumber;
        private String _hoten = String.Empty;
        private String _tenCS = String.Empty;
        private Decimal _dongiaTT = 0;
		#endregion
		
		#region Business Properties and Methods
        public string dongiaTT
        {
            get
            {
                CanReadProperty("dongiaTT", true);
                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongiaTT.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("dongiaTT", true);

                if (_dongiaTT.ToString() != value)
                {
                    _dongiaTT = decimal.Parse(value);
                    PropertyHasChanged("dongiaTT");
                }
            }
        }
        public String TenCS
        {
            get
            {
                CanReadProperty("TenCS", true);
                return _tenCS;
            }
            set
            {
                CanWriteProperty("TenCS", true);
                if (_tenCS != value)
                {
                    _tenCS = value;
                    PropertyHasChanged("TenCS");
                }
            }
        }
        public String MaDG
        {
            get
            {
                CanReadProperty("maDG", true);
                return _maDG;
            }
            set
            {
                CanWriteProperty("maDG", true);
                if (_maDG != value)
                {
                    _maDG = value;
                    PropertyHasChanged("maDG");
                }
            }
        }
        public String TenDG
        {
            get
            {
                CanReadProperty("TenDG", true);
                return _TenDG;
            }
            set
            {
                CanWriteProperty("TenDG", true);
                if (_TenDG != value)
                {
                    _TenDG = value;
                    PropertyHasChanged("TenDG");
                }
            }
        }
	
      	public String MaThuoc
		{
			get 
			{
				CanReadProperty("MaThuoc", true);
				return _MaThuoc;
			}
			set 
			{
				CanWriteProperty("MaThuoc", true);
				if (_MaThuoc != value) 
				{
					_MaThuoc = value;
					PropertyHasChanged("MaThuoc");
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
		
		public String TenTM
		{
			get 
			{
				CanReadProperty("TenTM", true);
				return _TenTM;
			}
			set 
			{
				CanWriteProperty("TenTM", true);
				if (_TenTM != value) 
				{
					_TenTM = value;
					PropertyHasChanged("TenTM");
				}
			}
		}
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _TenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_TenDVT != value)
                {
                    _TenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
        public string GHTu
        {
            get
            {
                CanReadProperty("GHTu", true);
                if (_GHTu == 0)
                {
                    return "0";
                }
                else
                {
                    return _GHTu.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("GHTu", true);

                if (_GHTu.ToString() != value)
                {
                    _GHTu = decimal.Parse(value);
                    PropertyHasChanged("GHTu");
                }
            }
        }
        public string GHDen
        {
            get
            {
                CanReadProperty("GHDen", true);
                if (_GHDen == 0)
                {
                    return "0";
                }
                else
                {
                    return _GHDen.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("GHDen", true);

                if (_GHDen.ToString() != value)
                {
                    _GHDen = decimal.Parse(value);
                    PropertyHasChanged("GHDen");
                }
            }
        }
        public String YeuCauTT
                {
                    get
                    {
                        CanReadProperty("YeuCauTT", true);
                        return _YeuCauTT;
                    }
                    set
                    {
                        CanWriteProperty("YeuCauTT", true);
                        if (_YeuCauTT != value)
                        {
                            _YeuCauTT = value;
                            PropertyHasChanged("YeuCauTT");
                        }
                    }
                }
      
        public String YeuCau
        {
            get
            {
                CanReadProperty("YeuCau", true);
                return _YeuCau;
            }
            set
            {
                CanWriteProperty("YeuCau", true);
                if (_YeuCau != value)
                {
                    _YeuCau = value;
                    PropertyHasChanged("YeuCau");
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
			return _MaThuoc;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 150));
            //ValidationRules.AddRule<DMDanhGia_CS_KQ>(StringRequired<DMDanhGia_CS_KQ>, "TenTM");


        }

       
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDanhGia_CS_KQ" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDanhGia_CS_KQ NewDMDanhGia_CS_KQ()
        {
            return DataPortal.Create<DMDanhGia_CS_KQ>();
        }
        public static DMDanhGia_CS_KQ NewDMDanhGia_CS_KQ(string maCS)
        {
            return DataPortal.Create<DMDanhGia_CS_KQ>(new CriteriaNew(maCS));
        }
		public static DMDanhGia_CS_KQ GetDMDanhGia_CS_KQ(String MaThuoc)
		{
			return DataPortal.Fetch<DMDanhGia_CS_KQ>(new Criteria(MaThuoc));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDanhGia_CS_KQ" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDanhGia_CS_KQ(String MaThuoc, String MaCS, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, MaThuoc,MaCS));
		}
        private DMDanhGia_CS_KQ(string maCS)
        {
            _maCS = maCS;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDanhGia_CS_KQ()
		{	
			// Prevent direct creation
		}
        internal DMDanhGia_CS_KQ( 
                         int OrderNumber,
                         String MaThuoc ,
		                 String maCS ,
		                 String TenTM ,
                        String TenDVT,
                        String YeuCauTT,
                        String YeuCau,
		               Decimal GHTu,
             Decimal GHden,
		                 String ghichu ,
		                 String maMay ,
		                 SmartDate ngaySD ,
		                 String nguoiSD ,
		                 Boolean huy,         
                         String hoten,
                        string madg,
                        string tendg,
                        string tencs,
             Decimal dongiatt)
        {
                     _MaThuoc = MaThuoc  ;
                     _dongiaTT = dongiatt;
                     _maDG = madg;
                     _TenDG = tendg;
		             _maCS = maCS ;
                     _tenCS = tencs;
		             _TenTM = TenTM  ;
                     _TenDVT = TenDVT;
                     _YeuCau = YeuCau;
                     _YeuCauTT = YeuCauTT;
                     _GHTu = GHTu;
                     _GHDen = GHden;
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
			private String _MaThuoc;
			public String MaThuoc 
			{
				get
				{
					return _MaThuoc;
				}
			}
			
			public Criteria(String MaThuoc)
			{
				_MaThuoc = MaThuoc;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaThuoc.Equals(c._MaThuoc)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaThuoc.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaCS;
            public String MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            private String _MaThuoc;
            public String MaThuoc
            {
                get
                {
                    return _MaThuoc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaThuoc, String MaCS)
            {
                _MaThuoc = MaThuoc;
                _MaCS = MaCS;
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
		/// Retrieve an existing <see cref="DMDanhGia_CS_KQ" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDanhGia_CS_KQ(String _MaThuoc);
			// public override IDataReader GetDMDanhGia_CS_KQ(String _MaThuoc)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaThuoc));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDanhGia_CS_KQ(crit.MaThuoc)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDanhGia_CS_KQ" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaThuoc") != null) _MaThuoc = dr.GetString("MaThuoc");
			if (dr.GetString("MaCS") != null) _maCS = dr.GetString("MaCS");
            if (dr.GetString("MaDG") != null) _maDG = dr.GetString("MaDG");
            if (dr.GetString("TenDG") != null) _TenDG = dr.GetString("TenDG");
            if (dr.GetDecimal("dongiaTT") != null) _dongiaTT = dr.GetDecimal("dongiaTT");
         
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetString("YeuCau") != null) _YeuCau = dr.GetString("YeuCau");
            if (dr.GetString("YeuCauTT") != null) _YeuCauTT = dr.GetString("YeuCauTT");
            if (dr.GetDecimal("GHTu") != null) _GHTu = dr.GetDecimal("GHTu");
            if (dr.GetDecimal("GHDen") != null) _GHDen = dr.GetDecimal("GHDen");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");

		}
		
		/// <summary>
		/// Insert the new <see cref="DMDanhGia_CS_KQ" /> Object to underlying database.
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
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDanhGia_CS_KQ
			// Copy & paste ham duoi day vao file DataProvider.KQ
            
              
            _MaThuoc = DataProvider.Instance().InsertDMDanhGia_CS_KQ(_maCS, _MaThuoc, _YeuCauTT, _YeuCau,_GHTu, _GHDen, _ghichu, _maMay, _nguoiSD);
			// public abstract String InsertDMDanhGia_CS_KQ(String _maCS, String _TenTM, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD);
			// public override String InsertDMDanhGia_CS_KQ(String _maCS, String _TenTM, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGia_CS_KQ_CREATE", _maCS, _TenTM, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD ), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDanhGia_CS_KQ" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDanhGia_CS_KQ
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMDanhGia_CS_KQ(_maCS, _MaThuoc, _YeuCauTT, _YeuCau, _GHTu, _GHDen, _ghichu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateDMDanhGia_CS_KQ(String _MaThuoc, String _maCS, String _TenTM, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateDMDanhGia_CS_KQ(String _MaThuoc, String _maCS, String _TenTM, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGia_CS_KQ_UPDATE", _MaThuoc, _maCS, _TenTM, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaThuoc,MaCS ));
		}

		/// <summary>
		/// Delete the <see cref="DMDanhGia_CS_KQ" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDanhGia_CS_KQ
              
            DataProvider.Instance().DeleteDMDanhGia_CS_KQ(crit.MaMay, crit.NguoiSD,crit.MaCS, crit.MaThuoc );
			// public abstract void DeleteDMDanhGia_CS_KQ(String _MaThuoc);
			// public override void DeleteDMDanhGia_CS_KQ(String _MaThuoc);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGia_DELETED", _MaThuoc);
			// }
		}

        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _MaThuoc = DataProvider.Instance().InsertDMDanhGia_CS_KQ(_maCS, _MaThuoc, _YeuCauTT, _YeuCau, _GHTu, _GHDen, _ghichu, _maMay, _nguoiSD);
            // public abstract String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, String _maMay);
            // public override String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoa_Create", _makho, _makhoa, _maThuoc, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMDanhGia_CS_KQ(_maCS, _MaThuoc, _YeuCauTT, _YeuCau, _GHTu, _GHDen, _ghichu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateDMDanhGia_CS_KQ(String _MaThuoc, String _maCS, String _TenTM, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateDMDanhGia_CS_KQ(String _MaThuoc, String _maCS, String _TenTM, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGia_CS_KQ_UPDATE", _MaThuoc, _maCS, _TenTM, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD , _huy);
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
              
            
            DataProvider.Instance().DeleteDMDanhGia_CS_KQ(_maMay, _nguoiSD,_maCS , _MaThuoc);
	
            MarkNew();
        }
		#endregion
	}

}
