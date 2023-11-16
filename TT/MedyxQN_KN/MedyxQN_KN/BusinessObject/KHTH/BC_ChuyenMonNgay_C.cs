using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
//


namespace HTC.Business.KHTH
{
    [Serializable()]
    public partial class BC_ChuyenMonNgay_C : BusinessBase<BC_ChuyenMonNgay_C>
    {
        #region Business Methods
		
		#region State Fields
        private String _noidung = String.Empty;
        private String _noidungcap1 = String.Empty;
        private Byte _cap = 0;
        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _ma = String.Empty;
        private String _macap1 = String.Empty;
        private Int32 _SoLuong = 0;
       
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaysd = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
         private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
        public String noidung
        {
            get
            {
                CanReadProperty("noidung", true);
                return _noidung;
            }
            set
            {
                CanWriteProperty("noidung", true);
                if (_noidung != value)
                {
                    _noidung = value;
                    PropertyHasChanged("noidung");
                }
            }
        }
        public String noidungcap1
        {
            get
            {
                CanReadProperty("noidungcap1", true);
                return _noidungcap1;
            }
            set
            {
                CanWriteProperty("noidungcap1", true);
                if (_noidungcap1 != value)
                {
                    _noidungcap1 = value;
                    PropertyHasChanged("noidungcap1");
                }
            }
        }
        public Byte  cap
        {
            get
            {
                CanReadProperty("cap", true);
                return _cap;
            }
            set
            {
                CanWriteProperty("cap", true);
                if (_cap != value)
                {
                    _cap = value;
                    PropertyHasChanged("cap");
                }
            }
        }
        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _maKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                    PropertyHasChanged("MaKhoa");
                }
            }
        }
        public string Thang
        {
            get
            {
                CanReadProperty("Thang", true);
                return _thang.Text;
            }
            set
            {
                CanWriteProperty("Thang", true);
                if (_thang.Text != value)
                {
                    _thang.Text = value;
                    PropertyHasChanged("Thang");
                }
            }
        }

        public String Ma
        {
            get
            {
                CanReadProperty("Ma", true);
                return _ma;
            }
            set
            {
                CanWriteProperty("Ma", true);
                if (_ma != value)
                {
                    _ma = value;
                    PropertyHasChanged("Ma");
                }
            }
        }
        public String macap1
        {
            get
            {
                CanReadProperty("macap1", true);
                return _macap1;
            }
            set
            {
                CanWriteProperty("macap1", true);
                if (_macap1 != value)
                {
                    _macap1 = value;
                    PropertyHasChanged("macap1");
                }
            }
        }

        public Int32 SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                return _SoLuong;
            }
            set
            {
                CanWriteProperty("SoLuong", true);
                if (_SoLuong != value)
                {
                    _SoLuong = value;
                    PropertyHasChanged("SoLuong");
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

        public string Ngaysd
        {
            get
            {
                CanReadProperty("Ngaysd", true);
                return _ngaysd.Text;
            }
            set
            {
                CanWriteProperty("Ngaysd", true);
                if (_ngaysd.Text != value)
                {
                    _ngaysd.Text = value;
                    PropertyHasChanged("Ngaysd");
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
            return _maKhoa.ToString() + "!" + _thang.ToString() + "!" + _ma.ToString();
		}
		
		#endregion
		#endregion
        
		#region Business Object Rules and Validation
         
        #endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_PhieuIn_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BC_ChuyenMonNgay_C NewBC_ChuyenMonNgay_C()
        {
            return new BC_ChuyenMonNgay_C();
           
        }
        public static BC_ChuyenMonNgay_C NewBC_ChuyenMonNgay_C(string Makhoa, SmartDate thang, string ma)
        {
            return new BC_ChuyenMonNgay_C(Makhoa,thang,ma );
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
       
        public static BC_ChuyenMonNgay_C GetBC_ChuyenMonNgay_C(SafeDataReader dr,int i)
        {
            return new BC_ChuyenMonNgay_C(dr,i);
        }

        public static void DeleteBC_ChuyenMonNgay_C(String makhoa, SmartDate thang, string ma)
        {
            DataPortal.Delete(new OtherCriteria(makhoa,thang, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_ChuyenMonNgay_C()
        {
            // Prevent direct creation
           
        }

        protected BC_ChuyenMonNgay_C(String makhoa, SmartDate thang, string ma)
        {
            MarkAsChild();
            _maKhoa = makhoa;
            _thang = thang;
            _ma = ma;
             
            //MarkOld();
        }
        protected BC_ChuyenMonNgay_C(SafeDataReader dr,int i )//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            if (dr.GetString("noidungcap1") != null) _noidungcap1 = dr.GetString("noidungcap1");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetString("Macap1") != null) _macap1 = dr.GetString("Macap1");
            if (dr.GetInt32("SoLuong") != null) _SoLuong = dr.GetInt32("SoLuong");
            
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
        [Serializable()]
        protected class Criteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }
            private String _ma;
            public String ma
            {
                get
                {
                    return _ma;
                }
            }
            public Criteria(String makhoa, SmartDate thang, String ma)
            {
                _maKhoa = makhoa;
                _ma = ma;
                _thang = thang;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if ((!_maKhoa.Equals(c._maKhoa)) ||( !_thang.Equals(c._thang) || (!_ma.Equals(c._ma))))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maKhoa.ToString(), _thang.ToString(), _ma.ToString()).GetHashCode();
            }
        }
       
        [Serializable()]
      
        protected class OtherCriteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
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
            private String _dk;
            public String DK
            {
                get
                {
                    return _dk;
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

           // public OtherCriteria(String Mamay, String Nguoisd, String maPhieu, Byte sTT)
            public OtherCriteria(String makhoa, SmartDate thang, String dk)
            {
                _maKhoa = makhoa;
                _dk = dk;
                _thang = thang;
                
                //  _NguoiSD =  HTC.ShareVariables.pub_sNguoiSD;
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
		/// Retrieve an existing <see cref="DMDichVu_PhieuIn_C" /> Object based on data in the database.
		/// </summary>
     
		/// <summary>
		/// Load a <see cref="DMDichVu_PhieuIn_C" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_ChuyenMonNgay_C_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("SoLuong") != null) _SoLuong = dr.GetInt32("SoLuong");
             if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            try
            {
                //if (dr.GetByte("STT") != null) _OrderNumber = dr.GetByte("STT");
                //_OrderNumber = dr.GetByte("STT");

            }
            catch (Exception ex)
            { }


        }
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
		//protected override void DataPortal_Insert()

        internal virtual void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
        
            DataProvider.Instance().InsertBC_ChuyenMonNgay_C(_maKhoa, _thang,_ma, _SoLuong, _nguoiSD,  _maMay);
            MarkOld();
        }
       
		/// Update all changes made on <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        internal virtual void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
              
                DataProvider.Instance().UpdateBC_ChuyenMonNgay_C(_maKhoa, _thang, _ma, _SoLuong, _nguoiSD, _huy, _maMay);
				
            }
            MarkOld();
        }
        
       
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
        //    DataProvider.Instance().DeleteDMDichVu_PhieuIn_C(crit.MaMay, crit.NguoiSD, crit.maPhieu, crit.maDV  );
        //    // public abstract void DeleteDMDichVu_PhieuIn_C(String _maPhieu);
        //    // public override void DeleteDMDichVu_PhieuIn_C(String _maPhieu);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhieu);
        //    // }
        //}String _maPN, int _sTT, String _nguoiSD
        internal void DeleteSelf()
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
            
             
            DataProvider.Instance().DeleteBC_ChuyenMonNgay_C(_maKhoa, _thang, _ma,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
