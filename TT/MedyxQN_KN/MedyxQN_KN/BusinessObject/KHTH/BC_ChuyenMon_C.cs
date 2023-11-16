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
    public partial class BC_ChuyenMon_C : BusinessBase<BC_ChuyenMon_C>
    {
        #region Business Methods
		
		#region State Fields

        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _ma = String.Empty;
        private String _noidung = String.Empty;
        private Byte _cap = 0;
        private Int32 _bh = 0;
        private Int32 _khongThe = 0;
        private Int32 _tongSo = 0;
        private Int32 _tE5 = 0;
        private Int32 _tE15 = 0;
        private Int32 _mien = 0;
        private Int32 _ngheo = 0;
        private Int32 _cc = 0;
        private Int32 _gia60 = 0;
        private Int32 _nuocNgoai = 0;
        private String _ghichu = String.Empty;
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
         public Byte cap
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

        public Int32 BH
        {
            get
            {
                CanReadProperty("BH", true);
                return _bh;
            }
            set
            {
                CanWriteProperty("BH", true);
                if (_bh != value)
                {
                    _bh = value;
                    PropertyHasChanged("BH");
                }
            }
        }

        public Int32 KhongThe
        {
            get
            {
                CanReadProperty("KhongThe", true);
                return _khongThe;
            }
            set
            {
                CanWriteProperty("KhongThe", true);
                if (_khongThe != value)
                {
                    _khongThe = value;
                    PropertyHasChanged("KhongThe");
                }
            }
        }

        public Int32 TongSo
        {
            get
            {
                CanReadProperty("TongSo", true);
                _tongSo = _bh + _khongThe;
                return _tongSo;
            }
         
        }

        public Int32 TE5
        {
            get
            {
                CanReadProperty("TE5", true);
                return _tE5;
            }
            set
            {
                CanWriteProperty("TE5", true);
                if (_tE5 != value)
                {
                    _tE5 = value;
                    PropertyHasChanged("TE5");
                }
            }
        }

        public Int32 TE15
        {
            get
            {
                CanReadProperty("TE15", true);
                return _tE15;
            }
            set
            {
                CanWriteProperty("TE15", true);
                if (_tE15 != value)
                {
                    _tE15 = value;
                    PropertyHasChanged("TE15");
                }
            }
        }

        public Int32 Mien
        {
            get
            {
                CanReadProperty("Mien", true);
                return _mien;
            }
            set
            {
                CanWriteProperty("Mien", true);
                if (_mien != value)
                {
                    _mien = value;
                    PropertyHasChanged("Mien");
                }
            }
        }

        public Int32 Ngheo
        {
            get
            {
                CanReadProperty("Ngheo", true);
                return _ngheo;
            }
            set
            {
                CanWriteProperty("Ngheo", true);
                if (_ngheo != value)
                {
                    _ngheo = value;
                    PropertyHasChanged("Ngheo");
                }
            }
        }

        public Int32 CC
        {
            get
            {
                CanReadProperty("CC", true);
                return _cc;
            }
            set
            {
                CanWriteProperty("CC", true);
                if (_cc != value)
                {
                    _cc = value;
                    PropertyHasChanged("CC");
                }
            }
        }

        public Int32 Gia60
        {
            get
            {
                CanReadProperty("Gia60", true);
                return _gia60;
            }
            set
            {
                CanWriteProperty("Gia60", true);
                if (_gia60 != value)
                {
                    _gia60 = value;
                    PropertyHasChanged("Gia60");
                }
            }
        }

        public Int32 NuocNgoai
        {
            get
            {
                CanReadProperty("NuocNgoai", true);
                return _nuocNgoai;
            }
            set
            {
                CanWriteProperty("NuocNgoai", true);
                if (_nuocNgoai != value)
                {
                    _nuocNgoai = value;
                    PropertyHasChanged("NuocNgoai");
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
        public static BC_ChuyenMon_C NewBC_ChuyenMon_C()
        {
            return new BC_ChuyenMon_C();
           
        }
        public static BC_ChuyenMon_C NewBC_ChuyenMon_C(string Makhoa, SmartDate thang, string ma)
        {
            return new BC_ChuyenMon_C(Makhoa,thang,ma );
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static BC_ChuyenMon_C GetBC_ChuyenMon_C(String makhoa, SmartDate thang,string ma)
        {
            return DataPortal.Fetch<BC_ChuyenMon_C>(new Criteria(makhoa,thang, ma));
        }
        public static BC_ChuyenMon_C GetBC_ChuyenMon_C(SafeDataReader dr,int i)
        {
            return new BC_ChuyenMon_C(dr,i);
        }

        public static void DeleteBC_ChuyenMon_C(String makhoa, SmartDate thang, string ma)
        {
            DataPortal.Delete(new OtherCriteria(makhoa,thang, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_ChuyenMon_C()
        {
            // Prevent direct creation
           
        }

        protected BC_ChuyenMon_C(String makhoa, SmartDate thang, string ma)
        {
            MarkAsChild();
            _maKhoa = makhoa;
            _thang = thang;
            _ma = ma;
             
            //MarkOld();
        }
        protected BC_ChuyenMon_C(SafeDataReader dr,int i )//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("BH") != null) _bh = dr.GetInt32("BH");
            if (dr.GetInt32("KhongThe") != null) _khongThe = dr.GetInt32("KhongThe");
            if (dr.GetInt32("TongSo") != null) _tongSo = dr.GetInt32("TongSo");
            if (dr.GetInt32("TE5") != null) _tE5 = dr.GetInt32("TE5");
            if (dr.GetInt32("TE15") != null) _tE15 = dr.GetInt32("TE15");
            if (dr.GetInt32("Mien") != null) _mien = dr.GetInt32("Mien");
            if (dr.GetInt32("Ngheo") != null) _ngheo = dr.GetInt32("Ngheo");
            if (dr.GetInt32("CC") != null) _cc = dr.GetInt32("CC");
            if (dr.GetInt32("Gia60") != null) _gia60 = dr.GetInt32("Gia60");
            if (dr.GetInt32("NuocNgoai") != null) _nuocNgoai = dr.GetInt32("NuocNgoai");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
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
            private String _Ma;
            public String Ma
            {
                get
                {
                    return _Ma;
                }
            }
            public Criteria(String makhoa, SmartDate thang, String Ma)
            {
                _maKhoa = makhoa;
                _Ma = Ma;
                _thang = thang;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if ((!_maKhoa.Equals(c._maKhoa)) ||( !_thang.Equals(c._thang) || (!_Ma.Equals(c._Ma))))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maKhoa.ToString()).GetHashCode();
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
            private String _Ma;
            public String Ma
            {
                get
                {
                    return _Ma;
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
            public OtherCriteria(String makhoa, SmartDate thang, String Ma)
            {
                _maKhoa = makhoa;
                _Ma = Ma;
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
        protected void DataPortal_Fetch(Criteria crit)
        {
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_ChuyenMon_C(crit.MaKhoa, crit.Thang,crit.Ma  )))
            {
                int i=0;
                if (dr.Read())
                {
                    Fetch(dr,i);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		/// <summary>
		/// Load a <see cref="DMDichVu_PhieuIn_C" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_ChuyenMon_C_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetByte("cap") != null) _cap = dr.GetByte("cap");
            if (dr.GetString("noidung") != null) _noidung = dr.GetString("noidung");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetInt32("BH") != null) _bh = dr.GetInt32("BH");
            if (dr.GetInt32("KhongThe") != null) _khongThe = dr.GetInt32("KhongThe");
            if (dr.GetInt32("TongSo") != null) _tongSo = dr.GetInt32("TongSo");
            if (dr.GetInt32("TE5") != null) _tE5 = dr.GetInt32("TE5");
            if (dr.GetInt32("TE15") != null) _tE15 = dr.GetInt32("TE15");
            if (dr.GetInt32("Mien") != null) _mien = dr.GetInt32("Mien");
            if (dr.GetInt32("Ngheo") != null) _ngheo = dr.GetInt32("Ngheo");
            if (dr.GetInt32("CC") != null) _cc = dr.GetInt32("CC");
            if (dr.GetInt32("Gia60") != null) _gia60 = dr.GetInt32("Gia60");
            if (dr.GetInt32("NuocNgoai") != null) _nuocNgoai = dr.GetInt32("NuocNgoai");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
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

        internal virtual void Insert(BC_ChuyenMon bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _maKhoa = bill.MaKhoa;
            _thang = SmartDate.Parse( bill.Thang);
            DataProvider.Instance().InsertBC_ChuyenMon_C(_maKhoa, _thang, _ma, _bh, _khongThe, _tongSo, _tE5, _tE15, _mien, _ngheo, _cc, _gia60, _nuocNgoai, _ghichu, _nguoiSD, _maMay);
            MarkOld();	
        }
       
		/// Update all changes made on <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        internal virtual void Update(BC_ChuyenMon bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                _maKhoa = bill.MaKhoa;
                _thang = SmartDate.Parse (bill.Thang);
                DataProvider.Instance().UpdateBC_ChuyenMon_C(_maKhoa, _thang, _ma, _bh, _khongThe, _tongSo, _tE5, _tE15, _mien, _ngheo, _cc, _gia60, _nuocNgoai, _ghichu, _nguoiSD, _huy, _maMay);
				
            }
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
        internal void DeleteSelf(BC_ChuyenMon bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
            

            DataProvider.Instance().DeleteBC_ChuyenMon_C(_maKhoa, _thang, _ma,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
