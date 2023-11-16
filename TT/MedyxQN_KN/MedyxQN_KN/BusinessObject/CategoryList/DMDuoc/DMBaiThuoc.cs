// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMBaiThuoc
// Kieu doi tuong  :	DMBaiThuoc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/3/2009 4:05:17 PM
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
	/// This is a base generated class of <see cref="DMBaiThuoc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMBaiThuoc : BusinessBase<DMBaiThuoc>
	{
		#region Business Methods
		
		#region State Fields

        private String _maBThuoc = String.Empty;
        private String _tenBThuoc = String.Empty;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;

        private String _tenNguoiLap = String.Empty;
       
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private Byte _loai = 0; // 0: tay y, 1 dong y 
      
        private String _MaBS = String.Empty;
        private String _TenBS = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods

        public String MaBThuoc
        {
            get
            {
                CanReadProperty("MaBThuoc", true);
                return _maBThuoc;
            }
            set
            {
                CanWriteProperty("MaBThuoc", true);
                if (_maBThuoc != value)
                {
                    _maBThuoc = value;
                    PropertyHasChanged("MaBThuoc");
                }
            }
        }

        public String TenBThuoc
        {
            get
            {
                CanReadProperty("TenBThuoc", true);
                return _tenBThuoc;
            }
            set
            {
                CanWriteProperty("TenBThuoc", true);
                if (_tenBThuoc != value)
                {
                    _tenBThuoc = value;
                    PropertyHasChanged("TenBThuoc");
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
        public byte loai
        {
            get
            {
                CanReadProperty("loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("loai");
                }
            }
        }
        public byte loaiDY
        {
            get
            {
                CanReadProperty("loaiDY", true);
                if (_loai==0 ) 
                return 1;
                else
                return 0;
            }
           
        }
        public String MaBS
        {
            get
            {
                CanReadProperty("MaBS", true);
                return _MaBS;
            }
            set
            {
                CanWriteProperty("MaBS", true);
                if (_MaBS != value)
                {
                    _MaBS = value;
                    PropertyHasChanged("MaBS");
                }
            }
        }
        public String TenBS
        {
            get
            {
                CanReadProperty("TenBS", true);
                return _TenBS;
            }
            set
            {
                CanWriteProperty("TenBS", true);
                if (_TenBS != value)
                {
                    _TenBS = value;
                    PropertyHasChanged("TenBS");
                }
            }
        }
        public string NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
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

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
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

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }

        DMBaiThuoc_CList _DMBaiThuoc_Cs = DMBaiThuoc_CList.NewDMBaiThuoc_CList();
        public DMBaiThuoc_CList DMBaiThuoc_TVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _DMBaiThuoc_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_DMBaiThuoc_Cs.Equals(value))
                {
                    _DMBaiThuoc_Cs = value;
                    PropertyHasChanged();
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
            return _maBThuoc;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _DMBaiThuoc_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _DMBaiThuoc_Cs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
       
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMBaiThuoc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMBaiThuoc NewDMBaiThuoc()
        {
            return DataPortal.Create<DMBaiThuoc>();
        }
		public static DMBaiThuoc GetDMBaiThuoc(String maHC, string dk)
		{
            return DataPortal.Fetch<DMBaiThuoc>(new Criteria(maHC, dk));
		}
        public static DMBaiThuoc GetDMBaiThuoc(SafeDataReader dr)
        {
            DMBaiThuoc obj = new DMBaiThuoc();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="DMBaiThuoc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMBaiThuoc(String maHC, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHC));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMBaiThuoc()
		{	
			// Prevent direct creation
		}
        internal DMBaiThuoc(
                         int OrderNumber,
		                 String maBThuoc ,
                         String tenBThuoc ,
                         String ghichu ,
                         String maMay ,
                         Boolean huy ,
                         SmartDate ngayHuy ,
                         String nguoiHuy ,
                         SmartDate ngayLap ,
                         String nguoiLap ,
                         SmartDate ngaySD ,
                         String nguoiSD ,
                         String tenNguoiLap ,
                         String tenNguoiSD ,
                         String tenNguoiHuy ,
                         byte loai,
                         string mabs,
                        string tenbs 
                    
                    
                     )
        {
                      _OrderNumber = OrderNumber;
                      _loai = loai;
                      _MaBS = mabs ;
                      _TenBS = tenbs;
                      _maBThuoc = maBThuoc ;
                      _tenBThuoc = tenBThuoc ;
                      _ghichu = ghichu ;
                      _maMay = maMay ;
                      _huy = huy ;
                      _ngayHuy = ngayHuy ;
                      _nguoiHuy = nguoiHuy ;
                      _ngayLap = ngayLap ;
                      _nguoiLap = nguoiLap ;
                      _ngaySD = ngaySD ;
                      _nguoiSD = nguoiSD ;
		              
                      _tenNguoiLap = tenNguoiLap ;
                      _tenNguoiSD = tenNguoiSD ;
                      _tenNguoiHuy = tenNguoiHuy ;
                     
        }
		#endregion

		#region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBThuoc;
            public String MaBThuoc
            {
                get
                {
                    return _maBThuoc;
                }
            }
            private String _dk;
            public String DK
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(String maBThuoc, string mDK)
            {
                _maBThuoc = maBThuoc;
                _dk = mDK;
            }

           
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBThuoc;
            public String MaBThuoc
            {
                get
                {
                    return _maBThuoc;
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
            public OtherCriteria(String Mamay, String Nguoisd, string maBThuoc)
            {
                _maBThuoc = maBThuoc;
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
		/// Retrieve an existing <see cref="DMBaiThuoc" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMBaiThuoc(String _maHC);
			// public override IDataReader GetDMBaiThuoc(String _maHC)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMBaiThuoc_Get", _maHC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMBaiThuoc(crit.MaBThuoc,crit.DK  ,false      )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _DMBaiThuoc_Cs = DMBaiThuoc_CList.GetDMBaiThuoc_CList(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMBaiThuoc" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaBThuoc") != null) _maBThuoc = dr.GetString("MaBThuoc");
            if (dr.GetString("TenBThuoc") != null) _tenBThuoc = dr.GetString("TenBThuoc");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetByte("loai") != null) _loai = dr.GetByte("loai");
            if (dr.GetString("MaBS") != null) _MaBS = dr.GetString("MaBS");
            if (dr.GetString("TenBS") != null) _TenBS = dr.GetString("TenBS");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMBaiThuoc" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMBaiThuoc
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maBThuoc = DataProvider.Instance().InsertDMBaiThuoc(_tenBThuoc, _ghichu, _maMay, _nguoiSD ,_loai ,_MaBS );
            _DMBaiThuoc_Cs.Update(this);
            //_DMBaiThuoc_TVs.Update(this);
            // public abstract String InsertDMBaiThuoc(String _tenBThuoc, String _ghichu, string _maMay, String _nguoiLap);
            // public override String InsertDMBaiThuoc(String _tenBThuoc, String _ghichu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMBaiThuoc_CREATE", _tenBThuoc, _ghichu, _maMay, _nguoiSD));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMBaiThuoc" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMBaiThuoc
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMBaiThuoc(_maBThuoc, _tenBThuoc, _ghichu, _maMay, _huy, _nguoiSD, _loai, _MaBS);
                _DMBaiThuoc_Cs.Update(this);
                // _DMBaiThuoc_TVs.Update(this);
                // public abstract void UpdateDMBaiThuoc(String _maBThuoc, String _tenBThuoc, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateDMBaiThuoc(String _maBThuoc, String _tenBThuoc, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMBaiThuoc_UPDATE", _maBThuoc, _tenBThuoc, _ghichu, _maMay, _huy, _nguoiSD);
				// }	
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBThuoc));
		}

		/// <summary>
		/// Delete the <see cref="DMBaiThuoc" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMBaiThuoc
            DataProvider.Instance().DeleteDMBaiThuoc(crit.MaMay, crit.NguoiSD, crit.MaBThuoc);
            // public abstract void DeleteDMBaiThuoc(String _maBThuoc);
            // public override void DeleteDMBaiThuoc(String _maBThuoc);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMBaiThuoc_DELETED", _maBThuoc);
			// }
		}

		#endregion
	}

}
