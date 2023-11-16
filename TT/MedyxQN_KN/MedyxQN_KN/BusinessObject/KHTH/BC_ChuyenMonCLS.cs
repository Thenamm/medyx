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
    public partial class BC_ChuyenMonCLS : BusinessBase<BC_ChuyenMonCLS>
    {
        #region Business Methods
		
		#region State Fields
        private String _noidung = String.Empty;
        private Byte _cap = 0;
        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _ma = String.Empty;
        private Int32 _xNBenhNhan = 0;
        private Int32 _xNTongSo = 0;
        private Int32 _xNTongSo1 = 0;
        private Int32 _xNBaoHiem = 0;
        private Int32 _xNVienPhi = 0;
        private Int32 _xNMien = 0;
        private Int32 _xNNoiTru = 0;
        private Int32 _xNNgoaiTru = 0;
        private Int32 _tBTongSo = 0;
        private Int32 _tBTongSo1 = 0;
        private Int32 _tBBaoHiem = 0;
        private Int32 _tBVienPhi = 0;
        private Int32 _tBMien = 0;
        private Int32 _tBNoiTru = 0;
        private Int32 _tBNgoaiTru = 0;
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

        public Int32 XNBenhNhan
        {
            get
            {
                CanReadProperty("XNBenhNhan", true);
                return _xNBenhNhan;
            }
            set
            {
                CanWriteProperty("XNBenhNhan", true);
                if (_xNBenhNhan != value)
                {
                    _xNBenhNhan = value;
                    PropertyHasChanged("XNBenhNhan");
                }
            }
        }

        public Int32 XNTongSo
        {
            get
            {
                CanReadProperty("XNTongSo", true);
                if ((_xNBaoHiem!=0) || (_xNVienPhi!=0) || (_xNMien!=0))
                     _xNTongSo =_xNBaoHiem +_xNVienPhi +_xNMien ;
                return _xNTongSo;
            }
            set
            {
                CanWriteProperty("xNTongSo", true);
                if (_xNTongSo != value)
                {
                    _xNTongSo = value;
                    PropertyHasChanged("xNTongSo");
                }
            }
        }
        public Int32 XNTongSo1
        {
            get
            {
                CanReadProperty("XNTongSo1", true);
                _xNTongSo1 = _xNTongSo;
                return _xNTongSo1;
            }

        }
        public Int32 XNBaoHiem
        {
            get
            {
                CanReadProperty("XNBaoHiem", true);
                return _xNBaoHiem;
            }
            set
            {
                CanWriteProperty("XNBaoHiem", true);
                if (_xNBaoHiem != value)
                {
                    _xNBaoHiem = value;
                    PropertyHasChanged("XNBaoHiem");
                }
            }
        }

        public Int32 XNVienPhi
        {
            get
            {
                CanReadProperty("XNVienPhi", true);
                return _xNVienPhi;
            }
            set
            {
                CanWriteProperty("XNVienPhi", true);
                if (_xNVienPhi != value)
                {
                    _xNVienPhi = value;
                    PropertyHasChanged("XNVienPhi");
                }
            }
        }

        public Int32 XNMien
        {
            get
            {
                CanReadProperty("XNMien", true);
                return _xNMien;
            }
            set
            {
                CanWriteProperty("XNMien", true);
                if (_xNMien != value)
                {
                    _xNMien = value;
                    PropertyHasChanged("XNMien");
                }
            }
        }

        public Int32 XNNoiTru
        {
            get
            {
                CanReadProperty("XNNoiTru", true);
                return _xNNoiTru;
            }
            set
            {
                CanWriteProperty("XNNoiTru", true);
                if (_xNNoiTru != value)
                {
                    _xNNoiTru = value;
                    PropertyHasChanged("XNNoiTru");
                }
            }
        }

        public Int32 XNNgoaiTru
        {
            get
            {
                CanReadProperty("XNNgoaiTru", true);
                if (_ma != "018")
                _xNNgoaiTru = _xNTongSo - _xNNoiTru;
                return _xNNgoaiTru;
            }
            //set
            //{
            //    CanWriteProperty("XNNgoaiTru", true);
            //    if (_xNNgoaiTru != value)
            //    {
            //        _xNNgoaiTru = value;
            //        PropertyHasChanged("XNNgoaiTru");
            //    }
            //}
        }

        public Int32 TBTongSo
        {
            get
            {
                CanReadProperty("TBTongSo", true);
                _tBTongSo = _tBBaoHiem + _tBVienPhi +_tBMien ;
                return _tBTongSo;
            }
            set
            {
                CanWriteProperty("tBTongSo", true);
                if (_tBTongSo != value)
                {
                    _tBTongSo = value;
                    PropertyHasChanged("tBTongSo");
                }
            }
        }
        public Int32 TBTongSo1
        {
            get
            {
                CanReadProperty("TBTongSo1", true);
                _tBTongSo1 = _tBTongSo ;
                return _tBTongSo;
            }

        }
        public Int32 TBBaoHiem
        {
            get
            {
                CanReadProperty("TBBaoHiem", true);
                return _tBBaoHiem;
            }
            set
            {
                CanWriteProperty("TBBaoHiem", true);
                if (_tBBaoHiem != value)
                {
                    _tBBaoHiem = value;
                    PropertyHasChanged("TBBaoHiem");
                }
            }
        }

        public Int32 TBVienPhi
        {
            get
            {
                CanReadProperty("TBVienPhi", true);
                return _tBVienPhi;
            }
            set
            {
                CanWriteProperty("TBVienPhi", true);
                if (_tBVienPhi != value)
                {
                    _tBVienPhi = value;
                    PropertyHasChanged("TBVienPhi");
                }
            }
        }

        public Int32 TBMien
        {
            get
            {
                CanReadProperty("TBMien", true);
                return _tBMien;
            }
            set
            {
                CanWriteProperty("TBMien", true);
                if (_tBMien != value)
                {
                    _tBMien = value;
                    PropertyHasChanged("TBMien");
                }
            }
        }

        public Int32 TBNoiTru
        {
            get
            {
                CanReadProperty("TBNoiTru", true);
                return _tBNoiTru;
            }
            set
            {
                CanWriteProperty("TBNoiTru", true);
                if (_tBNoiTru != value)
                {
                    _tBNoiTru = value;
                    PropertyHasChanged("TBNoiTru");
                }
            }
        }

        public Int32 TBNgoaiTru
        {
            get
            {
                CanReadProperty("TBNgoaiTru", true);
                if (_ma != "018")
                _tBNgoaiTru = _tBTongSo - _tBNoiTru;
                return _tBNgoaiTru;
            }
            //set
            //{
            //    CanWriteProperty("TBNgoaiTru", true);
            //    if (_tBNgoaiTru != value)
            //    {
            //        _tBNgoaiTru = value;
            //        PropertyHasChanged("TBNgoaiTru");
            //    }
            //}
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
        public static BC_ChuyenMonCLS NewBC_ChuyenMonCLS()
        {
            return new BC_ChuyenMonCLS();
           
        }
        public static BC_ChuyenMonCLS NewBC_ChuyenMonCLS(string Makhoa, SmartDate thang, string ma)
        {
            return new BC_ChuyenMonCLS(Makhoa,thang,ma );
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
       
        public static BC_ChuyenMonCLS GetBC_ChuyenMonCLS(SafeDataReader dr,int i)
        {
            return new BC_ChuyenMonCLS(dr,i);
        }

        public static void DeleteBC_ChuyenMonCLS(String makhoa, SmartDate thang, string ma)
        {
            DataPortal.Delete(new OtherCriteria(makhoa,thang, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_ChuyenMonCLS()
        {
            // Prevent direct creation
           
        }

        protected BC_ChuyenMonCLS(String makhoa, SmartDate thang, string ma)
        {
            MarkAsChild();
            _maKhoa = makhoa;
            _thang = thang;
            _ma = ma;
             
            //MarkOld();
        }
        protected BC_ChuyenMonCLS(SafeDataReader dr,int i )//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("XNBenhNhan") != null) _xNBenhNhan = dr.GetInt32("XNBenhNhan");
            if (dr.GetInt32("XNTongSo") != null) _xNTongSo = dr.GetInt32("XNTongSo");
            if (dr.GetInt32("XNBaoHiem") != null) _xNBaoHiem = dr.GetInt32("XNBaoHiem");
            if (dr.GetInt32("XNVienPhi") != null) _xNVienPhi = dr.GetInt32("XNVienPhi");
            if (dr.GetInt32("XNMien") != null) _xNMien = dr.GetInt32("XNMien");
            if (dr.GetInt32("XNNoiTru") != null) _xNNoiTru = dr.GetInt32("XNNoiTru");
            if (dr.GetInt32("XNNgoaiTru") != null) _xNNgoaiTru = dr.GetInt32("XNNgoaiTru");
            if (dr.GetInt32("TBTongSo") != null) _tBTongSo = dr.GetInt32("TBTongSo");
            if (dr.GetInt32("TBBaoHiem") != null) _tBBaoHiem = dr.GetInt32("TBBaoHiem");
            if (dr.GetInt32("TBVienPhi") != null) _tBVienPhi = dr.GetInt32("TBVienPhi");
            if (dr.GetInt32("TBMien") != null) _tBMien = dr.GetInt32("TBMien");
            if (dr.GetInt32("TBNoiTru") != null) _tBNoiTru = dr.GetInt32("TBNoiTru");
            if (dr.GetInt32("TBNgoaiTru") != null) _tBNgoaiTru = dr.GetInt32("TBNgoaiTru");
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
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_ChuyenMonCLS_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("XNBenhNhan") != null) _xNBenhNhan = dr.GetInt32("XNBenhNhan");
            if (dr.GetInt32("XNTongSo") != null) _xNTongSo = dr.GetInt32("XNTongSo");
            if (dr.GetInt32("XNBaoHiem") != null) _xNBaoHiem = dr.GetInt32("XNBaoHiem");
            if (dr.GetInt32("XNVienPhi") != null) _xNVienPhi = dr.GetInt32("XNVienPhi");
            if (dr.GetInt32("XNMien") != null) _xNMien = dr.GetInt32("XNMien");
            if (dr.GetInt32("XNNoiTru") != null) _xNNoiTru = dr.GetInt32("XNNoiTru");
            if (dr.GetInt32("XNNgoaiTru") != null) _xNNgoaiTru = dr.GetInt32("XNNgoaiTru");
            if (dr.GetInt32("TBTongSo") != null) _tBTongSo = dr.GetInt32("TBTongSo");
            if (dr.GetInt32("TBBaoHiem") != null) _tBBaoHiem = dr.GetInt32("TBBaoHiem");
            if (dr.GetInt32("TBVienPhi") != null) _tBVienPhi = dr.GetInt32("TBVienPhi");
            if (dr.GetInt32("TBMien") != null) _tBMien = dr.GetInt32("TBMien");
            if (dr.GetInt32("TBNoiTru") != null) _tBNoiTru = dr.GetInt32("TBNoiTru");
            if (dr.GetInt32("TBNgoaiTru") != null) _tBNgoaiTru = dr.GetInt32("TBNgoaiTru");
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
            
              
           
            DataProvider.Instance().InsertBC_ChuyenMonCLS(_maKhoa, _thang,_ma, _xNBenhNhan, _xNTongSo, _xNBaoHiem, _xNVienPhi, _xNMien, _xNNoiTru, _xNNgoaiTru, _tBTongSo, _tBBaoHiem, _tBVienPhi, _tBMien, _tBNoiTru, _tBNgoaiTru, _nguoiSD,  _maMay);
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
                
                  

                DataProvider.Instance().UpdateBC_ChuyenMonCLS(_maKhoa, _thang, _ma, _xNBenhNhan, _xNTongSo, _xNBaoHiem, _xNVienPhi, _xNMien, _xNNoiTru, _xNNgoaiTru, _tBTongSo, _tBBaoHiem, _tBVienPhi, _tBMien, _tBNoiTru, _tBNgoaiTru, _nguoiSD, _huy, _maMay);
				
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
            
            

            DataProvider.Instance().DeleteBC_ChuyenMonCLS(_maKhoa, _thang, _ma,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
