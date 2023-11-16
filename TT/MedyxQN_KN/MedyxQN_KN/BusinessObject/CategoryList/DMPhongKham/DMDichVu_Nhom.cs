// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_Nhom
// Kieu doi tuong  :	DMDichVu_Nhom
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/9/2009 3:56:55 PM
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
	/// This is a base generated class of <see cref="DMDichVu_Nhom" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_Nhom : BusinessBase<DMDichVu_Nhom>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaNhom = String.Empty;
        private String _TenNhom = String.Empty;
       
		private String _maDV = String.Empty;
		
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
		private String _MaKhoaTH = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tenDV = String.Empty;
     
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _TenKhoaTH = String.Empty;
        private int _OrderNumber;
      	#endregion
		
		#region Business Properties and Methods
        
      
		public String MaNhom
		{
			get 
			{
				CanReadProperty("MaNhom", true);
				return _MaNhom;
			}
			set 
			{
				CanWriteProperty("MaNhom", true);
				if (_MaNhom != value) 
				{
					_MaNhom = value;
					PropertyHasChanged("MaNhom");
				}
			}
		}
        public String TenNhom
        {
            get
            {
                CanReadProperty("TenNhom", true);
                return _TenNhom;
            }
            set
            {
                CanWriteProperty("TenNhom", true);
                if (_TenNhom != value)
                {
                    _TenNhom = value;
                    PropertyHasChanged("TenNhom");
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
		
		public String NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayLap.Text ;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text  != value) 
				{
					_ngayLap.Text  = value;
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
		
		public String NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";

				return _ngayHuy.Text ;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text  != value) 
				{
					_ngayHuy.Text  = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String MaKhoaTH
		{
			get 
			{
				CanReadProperty("MaKhoaTH", true);
				return _MaKhoaTH;
			}
			set 
			{
				CanWriteProperty("MaKhoaTH", true);
				if (_MaKhoaTH != value) 
				{
					_MaKhoaTH = value;
					PropertyHasChanged("MaKhoaTH");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenKhoaTH
        {
            get
            {
                CanReadProperty("TenKhoaTH", true);
                return _TenKhoaTH;
            }
            set
            {
                CanWriteProperty("TenKhoaTH", true);
                if (_TenKhoaTH != value)
                {
                    _TenKhoaTH = value;
                    PropertyHasChanged("TenKhoaTH");
                }
            }
        }

        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
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
			return _MaNhom.ToString() + "!" + _maDV.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_Nhom" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_Nhom NewDMDichVu_Nhom()
        {
            return new DMDichVu_Nhom ();
        }
   
        internal static DMDichVu_Nhom  GetDMDichVu_Nhom(SafeDataReader dr,int i)
        {
            return new DMDichVu_Nhom (dr,i);
        }
		
	
        public DMDichVu_Nhom()
        {
            MarkAsChild();
        }
		
		#endregion
		    
		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaNhom;
			public String MaNhom 
			{
				get
				{
					return _MaNhom;
				}
			}

            private string _maDV;
            public string MaDV 
			{
				get
				{
                    return _maDV;
				}
			}

            public Criteria(String MaNhom, string Madv)
			{
				_MaNhom = MaNhom;
                _maDV = Madv;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaNhom.Equals(c._MaNhom)) 
						return false;
                    if (!_maDV.Equals(c._maDV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
                return string.Concat("Criteria", _MaNhom.ToString(), _maDV.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaNhom;
            public String MaNhom
            {
                get
                {
                    return _MaNhom;
                }
            }

            private string _maDV;
            public string MaDV
            {
                get
                {
                    return _maDV;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaNhom, string madv)
            {
                _MaNhom = MaNhom;
                _maDV = madv;
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

		
        private  DMDichVu_Nhom(SafeDataReader dr,int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaNhom") != null) _MaNhom = dr.GetString("MaNhom");
            if (dr.GetString("TenNhom") != null) _TenNhom = dr.GetString("TenNhom");
         
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
         
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap") != null) _ngayLap = dr.GetSmartDate("NgayLap");
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
            if (dr.GetString("MaKhoaTH") != null) _MaKhoaTH = dr.GetString("MaKhoaTH");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
          
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenKhoaTH") != null) _TenKhoaTH = dr.GetString("TenKhoaTH");
          
              
           
            //if (dr.GetString("noiTT") != null) _noiTT = dr.GetString("noiTT");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoaTH
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            //_MaNhom = 
            DataProvider.Instance().InsertDMDichVu_Nhom(_MaNhom, _maDV, _MaKhoaTH, _maMay, _nguoiSD);
            // public abstract String InsertDMThuoc_KhoKhoaTH(String _makho, String _maKhoaTH, String _maThuoc, String _nguoiSD, String _maMay);
            // public override String InsertDMThuoc_KhoKhoaTH(String _makho, String _maKhoaTH, String _maThuoc, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoaTH_Create", _makho, _maKhoaTH, _maThuoc, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_Nhom" /> Object to underlying database.
		/// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Nhom
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateDMDichVu_Nhom(_MaNhom, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD , _aDGiauSD);
        //        // public abstract void UpdateDMDichVu_Nhom(String _MaNhom, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _MaKhoaTH, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //        // public override void UpdateDMDichVu_Nhom(String _MaNhom, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _MaKhoaTH, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaNhom, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _ngay1.DBValue, _ghichu, _maMay, _huy, _ngayLap, _nguoiSD , _ngayHuy, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1, _ngaySD.DBValue, _nguoiSD);
        //        // }				
        //    }
        //}
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoaTH
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateDMDichVu_Nhom(_MaNhom,  _maDV,_MaKhoaTH, _maMay, _huy, _nguoiSD );
            // public abstract void UpdateDMThuoc_KhoKhoaTH(String _makho, Decimal _sTT, String _maKhoaTH, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay);
            // public override void UpdateDMThuoc_KhoKhoaTH(String _makho, Decimal _sTT, String _maKhoaTH, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoaTH_Update", _makho, _sTT, _maKhoaTH, _maThuoc, _huy, _nguoiSD , _maMay);
            // }				
            MarkOld();
        }
    
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaNhom, _maDV));
            MarkNew();
        }


		/// <summary>
		/// Delete the <see cref="DMDichVu_Nhom" />.
		/// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Nhom
        //    DataProvider.Instance().DeleteDMDichVu_Nhom(crit.MaMay, crit.NguoiSD, crit.MaNhom, crit.sTT);
        //    // public abstract void DeleteDMDichVu_Nhom(String _MaNhom, Byte _sTT);
        //    // public override void DeleteDMDichVu_Nhom(String _MaNhom, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaNhom, _sTT);
        //    // }
        //}
        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMDichVu_Nhom(crit.MaMay, crit.NguoiSD, crit.MaNhom, crit.MaDV);
        }

		#endregion
	}

}
