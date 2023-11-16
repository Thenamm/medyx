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
    public partial class BC_ChuyenMonPT : BusinessBase<BC_ChuyenMonPT>
    {
        #region Business Methods
		
		#region State Fields
        private String _noidung = String.Empty;
        private Byte _cap = 0;
        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _ma = String.Empty;
        private Int32 _KeHoach = 0;
        private Int32 _Ulanh = 0;
        private Int32 _Uac = 0;
        private Int32 _CapCuu = 0;
        private Int32 _TongSo = 0;
        private Int32 _TongSo1 = 0;
       
        private Int32 _tBTongSo = 0;
        private Int32 _TVTongSo = 0;
        private Int32 _TBGayMe = 0;
        private Int32 _TBNhiemKhuan = 0;
        private Int32 _TBKhac = 0;
        private Int32 _TVTrenBan = 0;
        private Int32 _TV24 = 0;
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
        public Int32 TongSo
        {
            get
            {
                CanReadProperty("TongSo", true);
                _TongSo = _KeHoach + _CapCuu;
                return _TongSo;
            }
            
        }
        public Int32 TongSo1
        {
            get
            {
                CanReadProperty("TongSo1", true);
                _TongSo1 = _TongSo;
                return _TongSo;
            }

        }
        public Int32 KeHoach
        {
            get
            {
                CanReadProperty("KeHoach", true);
                return _KeHoach;
            }
            set
            {
                CanWriteProperty("KeHoach", true);
                if (_KeHoach != value)
                {
                    _KeHoach = value;
                    PropertyHasChanged("KeHoach");
                }
            }
        }

        public Int32 Ulanh
        {
            get
            {
                CanReadProperty("Ulanh", true);
                _Ulanh = _TongSo1 - _Uac;
                return _Ulanh;
            }
          
        }

        public Int32 Uac
        {
            get
            {
                CanReadProperty("Uac", true);
                return _Uac;
            }
            set
            {
                CanWriteProperty("Uac", true);
                if (_Uac != value)
                {
                    _Uac = value;
                    PropertyHasChanged("Uac");
                }
            }
        }

        public Int32 CapCuu
        {
            get
            {
                CanReadProperty("CapCuu", true);
                return _CapCuu;
            }
            set
            {
                CanWriteProperty("CapCuu", true);
                if (_CapCuu != value)
                {
                    _CapCuu = value;
                    PropertyHasChanged("CapCuu");
                }
            }
        }

     

      
        public Int32 TBTongSo
        {
            get
            {
                CanReadProperty("TBTongSo", true);
                _tBTongSo = _TBGayMe + _TBNhiemKhuan +_TBKhac ;
                return _tBTongSo;
            }
            //set
            //{
            //    CanWriteProperty("tBTongSo", true);
            //    if (_tBTongSo != value)
            //    {
            //        _tBTongSo = value;
            //        PropertyHasChanged("tBTongSo");
            //    }
            //}
        }
        public Int32 TVTongSo
        {
            get
            {
                CanReadProperty("TVTongSo", true);
                _TVTongSo = _TV24 +_TVTrenBan  ;
                return _tBTongSo;
            }

        }
        public Int32 TBGayMe
        {
            get
            {
                CanReadProperty("TBGayMe", true);
                return _TBGayMe;
            }
            set
            {
                CanWriteProperty("TBGayMe", true);
                if (_TBGayMe != value)
                {
                    _TBGayMe = value;
                    PropertyHasChanged("TBGayMe");
                }
            }
        }

        public Int32 TBNhiemKhuan
        {
            get
            {
                CanReadProperty("TBNhiemKhuan", true);
                return _TBNhiemKhuan;
            }
            set
            {
                CanWriteProperty("TBNhiemKhuan", true);
                if (_TBNhiemKhuan != value)
                {
                    _TBNhiemKhuan = value;
                    PropertyHasChanged("TBNhiemKhuan");
                }
            }
        }

        public Int32 TBKhac
        {
            get
            {
                CanReadProperty("TBKhac", true);
                return _TBKhac;
            }
            set
            {
                CanWriteProperty("TBKhac", true);
                if (_TBKhac != value)
                {
                    _TBKhac = value;
                    PropertyHasChanged("TBKhac");
                }
            }
        }

        public Int32 TVTrenBan
        {
            get
            {
                CanReadProperty("TVTrenBan", true);
                return _TVTrenBan;
            }
            set
            {
                CanWriteProperty("TVTrenBan", true);
                if (_TVTrenBan != value)
                {
                    _TVTrenBan = value;
                    PropertyHasChanged("TVTrenBan");
                }
            }
        }

        public Int32 TV24
        {
            get
            {
                CanReadProperty("TV24", true);
              
                return _TV24;
            }
            set
            {
                CanWriteProperty("TV24", true);
                if (_TV24 != value)
                {
                    _TV24 = value;
                    PropertyHasChanged("TV24");
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
        public static BC_ChuyenMonPT NewBC_ChuyenMonPT()
        {
            return new BC_ChuyenMonPT();
           
        }
        public static BC_ChuyenMonPT NewBC_ChuyenMonPT(string Makhoa, SmartDate thang, string ma)
        {
            return new BC_ChuyenMonPT(Makhoa,thang,ma );
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
       
        public static BC_ChuyenMonPT GetBC_ChuyenMonPT(SafeDataReader dr,int i)
        {
            return new BC_ChuyenMonPT(dr,i);
        }

        public static void DeleteBC_ChuyenMonPT(String makhoa, SmartDate thang, string ma)
        {
            DataPortal.Delete(new OtherCriteria(makhoa,thang, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_ChuyenMonPT()
        {
            // Prevent direct creation
           
        }

        protected BC_ChuyenMonPT(String makhoa, SmartDate thang, string ma)
        {
            MarkAsChild();
            _maKhoa = makhoa;
            _thang = thang;
            _ma = ma;
             
            //MarkOld();
        }
        protected BC_ChuyenMonPT(SafeDataReader dr,int i )//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("KeHoach") != null) _KeHoach = dr.GetInt32("KeHoach");
           
            if (dr.GetInt32("Uac") != null) _Uac = dr.GetInt32("Uac");
            if (dr.GetInt32("CapCuu") != null) _CapCuu = dr.GetInt32("CapCuu");
          
          
            if (dr.GetInt32("TBGayMe") != null) _TBGayMe = dr.GetInt32("TBGayMe");
            if (dr.GetInt32("TBNhiemKhuan") != null) _TBNhiemKhuan = dr.GetInt32("TBNhiemKhuan");
            if (dr.GetInt32("TBKhac") != null) _TBKhac = dr.GetInt32("TBKhac");
            if (dr.GetInt32("TVTrenBan") != null) _TVTrenBan = dr.GetInt32("TVTrenBan");
            if (dr.GetInt32("TV24") != null) _TV24 = dr.GetInt32("TV24");
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
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_ChuyenMonPT_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("KeHoach") != null) _KeHoach = dr.GetInt32("KeHoach");
           
            if (dr.GetInt32("Uac") != null) _Uac = dr.GetInt32("Uac");
            if (dr.GetInt32("CapCuu") != null) _CapCuu = dr.GetInt32("CapCuu");
           
            if (dr.GetInt32("TBGayMe") != null) _TBGayMe = dr.GetInt32("TBGayMe");
            if (dr.GetInt32("TBNhiemKhuan") != null) _TBNhiemKhuan = dr.GetInt32("TBNhiemKhuan");
            if (dr.GetInt32("TBKhac") != null) _TBKhac = dr.GetInt32("TBKhac");
            if (dr.GetInt32("TVTrenBan") != null) _TVTrenBan = dr.GetInt32("TVTrenBan");
            if (dr.GetInt32("TV24") != null) _TV24 = dr.GetInt32("TV24");
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
            
              
           
            DataProvider.Instance().InsertBC_ChuyenMonPT(_maKhoa, _thang,_ma, _TongSo,_KeHoach, _Uac, _CapCuu, _TBGayMe, _TBNhiemKhuan, _TBKhac, _TVTrenBan, _TV24, _nguoiSD,  _maMay);
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
                
                  

                DataProvider.Instance().UpdateBC_ChuyenMonPT(_maKhoa, _thang, _ma, _TongSo, _KeHoach, _Uac, _CapCuu, _TBGayMe, _TBNhiemKhuan, _TBKhac, _TVTrenBan, _TV24, _nguoiSD, _huy, _maMay);
				
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
            
            

            DataProvider.Instance().DeleteBC_ChuyenMonPT(_maKhoa, _thang, _ma,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
