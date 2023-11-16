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
    public partial class BC_MacBenh : BusinessBase<BC_MacBenh>
    {
        #region Business Methods
		
		#region State Fields
        private String _tenQH = String.Empty;
        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _maQH = String.Empty;
        private Int32 _dauMatMoi = 0;
        private Int32 _dauMatCu = 0;
        private Int32 _phoiMoi = 0;
        private Int32 _phoiCu = 0;
        private Int32 _vuMoi = 0;
        private Int32 _vuCu = 0;
        private Int32 _tieuHoaMoi = 0;
        private Int32 _tieuHoaCu = 0;
        private Int32 _hachMoi = 0;
        private Int32 _hachCu = 0;
        private Int32 _phuMoi = 0;
        private Int32 _phuCu = 0;
        private Int32 _khacMoi = 0;
        private Int32 _khacCu = 0;
        private Int32 _tongSo = 0;
        private Int32 _moiMac = 0;
        private Int32 _ulanh = 0;
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaysd = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
         private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
        public String tenQH
        {
            get
            {
                CanReadProperty("tenQH", true);
                return _tenQH;
            }
            set
            {
                CanWriteProperty("tenQH", true);
                if (_tenQH != value)
                {
                    _tenQH = value;
                    PropertyHasChanged("tenQH");
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

        public String MaQH
        {
            get
            {
                CanReadProperty("MaQH", true);
                return _maQH;
            }
            set
            {
                CanWriteProperty("MaQH", true);
                if (_maQH != value)
                {
                    _maQH = value;
                    PropertyHasChanged("MaQH");
                }
            }
        }

        public Int32 DauMatMoi
        {
            get
            {
                CanReadProperty("DauMatMoi", true);
                return _dauMatMoi;
            }
            set
            {
                CanWriteProperty("DauMatMoi", true);
                if (_dauMatMoi != value)
                {
                    _dauMatMoi = value;
                    PropertyHasChanged("DauMatMoi");
                }
            }
        }

        public Int32 DauMatCu
        {
            get
            {
                CanReadProperty("DauMatCu", true);
                return _dauMatCu;
            }
            set
            {
                CanWriteProperty("DauMatCu", true);
                if (_dauMatCu != value)
                {
                    _dauMatCu = value;
                    PropertyHasChanged("DauMatCu");
                }
            }
        }

        public Int32 PhoiMoi
        {
            get
            {
                CanReadProperty("PhoiMoi", true);
                return _phoiMoi;
            }
            set
            {
                CanWriteProperty("PhoiMoi", true);
                if (_phoiMoi != value)
                {
                    _phoiMoi = value;
                    PropertyHasChanged("PhoiMoi");
                }
            }
        }

        public Int32 PhoiCu
        {
            get
            {
                CanReadProperty("PhoiCu", true);
                return _phoiCu;
            }
            set
            {
                CanWriteProperty("PhoiCu", true);
                if (_phoiCu != value)
                {
                    _phoiCu = value;
                    PropertyHasChanged("PhoiCu");
                }
            }
        }

        public Int32 VuMoi
        {
            get
            {
                CanReadProperty("VuMoi", true);
                return _vuMoi;
            }
            set
            {
                CanWriteProperty("VuMoi", true);
                if (_vuMoi != value)
                {
                    _vuMoi = value;
                    PropertyHasChanged("VuMoi");
                }
            }
        }

        public Int32 VuCu
        {
            get
            {
                CanReadProperty("VuCu", true);
                return _vuCu;
            }
            set
            {
                CanWriteProperty("VuCu", true);
                if (_vuCu != value)
                {
                    _vuCu = value;
                    PropertyHasChanged("VuCu");
                }
            }
        }

        public Int32 TieuHoaMoi
        {
            get
            {
                CanReadProperty("TieuHoaMoi", true);
                return _tieuHoaMoi;
            }
            set
            {
                CanWriteProperty("TieuHoaMoi", true);
                if (_tieuHoaMoi != value)
                {
                    _tieuHoaMoi = value;
                    PropertyHasChanged("TieuHoaMoi");
                }
            }
        }

        public Int32 TieuHoaCu
        {
            get
            {
                CanReadProperty("TieuHoaCu", true);
                return _tieuHoaCu;
            }
            set
            {
                CanWriteProperty("TieuHoaCu", true);
                if (_tieuHoaCu != value)
                {
                    _tieuHoaCu = value;
                    PropertyHasChanged("TieuHoaCu");
                }
            }
        }

        public Int32 HachMoi
        {
            get
            {
                CanReadProperty("HachMoi", true);
                return _hachMoi;
            }
            set
            {
                CanWriteProperty("HachMoi", true);
                if (_hachMoi != value)
                {
                    _hachMoi = value;
                    PropertyHasChanged("HachMoi");
                }
            }
        }

        public Int32 HachCu
        {
            get
            {
                CanReadProperty("HachCu", true);
                return _hachCu;
            }
            set
            {
                CanWriteProperty("HachCu", true);
                if (_hachCu != value)
                {
                    _hachCu = value;
                    PropertyHasChanged("HachCu");
                }
            }
        }

        public Int32 PhuMoi
        {
            get
            {
                CanReadProperty("PhuMoi", true);
                return _phuMoi;
            }
            set
            {
                CanWriteProperty("PhuMoi", true);
                if (_phuMoi != value)
                {
                    _phuMoi = value;
                    PropertyHasChanged("PhuMoi");
                }
            }
        }

        public Int32 PhuCu
        {
            get
            {
                CanReadProperty("PhuCu", true);
                return _phuCu;
            }
            set
            {
                CanWriteProperty("PhuCu", true);
                if (_phuCu != value)
                {
                    _phuCu = value;
                    PropertyHasChanged("PhuCu");
                }
            }
        }

        public Int32 KhacMoi
        {
            get
            {
                CanReadProperty("KhacMoi", true);
                return _khacMoi;
            }
            set
            {
                CanWriteProperty("KhacMoi", true);
                if (_khacMoi != value)
                {
                    _khacMoi = value;
                    PropertyHasChanged("KhacMoi");
                }
            }
        }

        public Int32 KhacCu
        {
            get
            {
                CanReadProperty("KhacCu", true);
                return _khacCu;
            }
            set
            {
                CanWriteProperty("KhacCu", true);
                if (_khacCu != value)
                {
                    _khacCu = value;
                    PropertyHasChanged("KhacCu");
                }
            }
        }

        public Int32 TongSo
        {
            get
            {
                CanReadProperty("TongSo", true);
                _tongSo = _dauMatMoi + _phoiMoi + _vuMoi + _tieuHoaMoi + _phuMoi + _khacMoi +_hachMoi+ _dauMatCu + _phoiCu + _vuCu + _tieuHoaCu + _phuCu + _khacCu+_hachCu;
                return _tongSo;
            }
            //set
            //{
            //    CanWriteProperty("TongSo", true);
            //    if (_tongSo != value)
            //    {
            //        _tongSo = value;
            //        PropertyHasChanged("TongSo");
            //    }
            //}
        }

        public Int32 MoiMac
        {
            get
            {
                CanReadProperty("MoiMac", true);
                _moiMac = _dauMatMoi + _phoiMoi + _vuMoi + _tieuHoaMoi + _phuMoi + _khacMoi;
      
                return _moiMac;
            }
            //set
            //{
            //    CanWriteProperty("MoiMac", true);
            //    if (_moiMac != value)
            //    {
            //        _moiMac = value;
            //        PropertyHasChanged("MoiMac");
            //    }
            //}
        }

        public Int32 Ulanh
        {
            get
            {
                CanReadProperty("Ulanh", true);
                return _ulanh;
            }
            set
            {
                CanWriteProperty("Ulanh", true);
                if (_ulanh != value)
                {
                    _ulanh = value;
                    PropertyHasChanged("Ulanh");
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
            return _maKhoa.ToString() + "!" + _thang.ToString() + "!" + _maQH.ToString();
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
        public static BC_MacBenh NewBC_MacBenh()
        {
            return new BC_MacBenh();
           
        }
        public static BC_MacBenh NewBC_MacBenh(string Makhoa, SmartDate thang, string maqh)
        {
            return new BC_MacBenh(Makhoa,thang,maqh );
           }
       
        public static BC_MacBenh GetBC_MacBenh(SafeDataReader dr,int i)
        {
            return new BC_MacBenh(dr,i);
        }

        public static void DeleteBC_MacBenh(String makhoa, SmartDate thang, string ma)
        {
            DataPortal.Delete(new OtherCriteria(makhoa,thang, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_MacBenh()
        {
            // Prevent direct creation
           
        }

        protected BC_MacBenh(String makhoa, SmartDate thang, string maqh)
        {
            MarkAsChild();
            _maKhoa = makhoa;
            _thang = thang;
            _maQH = maqh;
             
            //MarkOld();
        }
        protected BC_MacBenh(SafeDataReader dr,int i )//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("tenQH") != null) _tenQH = dr.GetString("tenQH");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaQH") != null) _maQH = dr.GetString("MaQH");
            if (dr.GetInt32("DauMatMoi") != null) _dauMatMoi = dr.GetInt32("DauMatMoi");
            if (dr.GetInt32("DauMatCu") != null) _dauMatCu = dr.GetInt32("DauMatCu");
            if (dr.GetInt32("PhoiMoi") != null) _phoiMoi = dr.GetInt32("PhoiMoi");
            if (dr.GetInt32("PhoiCu") != null) _phoiCu = dr.GetInt32("PhoiCu");
            if (dr.GetInt32("VuMoi") != null) _vuMoi = dr.GetInt32("VuMoi");
            if (dr.GetInt32("VuCu") != null) _vuCu = dr.GetInt32("VuCu");
            if (dr.GetInt32("TieuHoaMoi") != null) _tieuHoaMoi = dr.GetInt32("TieuHoaMoi");
            if (dr.GetInt32("TieuHoaCu") != null) _tieuHoaCu = dr.GetInt32("TieuHoaCu");
            if (dr.GetInt32("HachMoi") != null) _hachMoi = dr.GetInt32("HachMoi");
            if (dr.GetInt32("HachCu") != null) _hachCu = dr.GetInt32("HachCu");
            if (dr.GetInt32("PhuMoi") != null) _phuMoi = dr.GetInt32("PhuMoi");
            if (dr.GetInt32("PhuCu") != null) _phuCu = dr.GetInt32("PhuCu");
            if (dr.GetInt32("KhacMoi") != null) _khacMoi = dr.GetInt32("KhacMoi");
            if (dr.GetInt32("KhacCu") != null) _khacCu = dr.GetInt32("KhacCu");
            if (dr.GetInt32("TongSo") != null) _tongSo = dr.GetInt32("TongSo");
            if (dr.GetInt32("MoiMac") != null) _moiMac = dr.GetInt32("MoiMac");
            if (dr.GetInt32("Ulanh") != null) _ulanh = dr.GetInt32("Ulanh");
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
            private String _maQH;
            public String maQH
            {
                get
                {
                    return _maQH;
                }
            }
            public Criteria(String makhoa, SmartDate thang, String maqh)
            {
                _maKhoa = makhoa;
                _maQH = maqh;
                _thang = thang;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if ((!_maKhoa.Equals(c._maKhoa)) ||( !_thang.Equals(c._thang) || (!_maQH.Equals(c._maQH))))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maKhoa.ToString(), _thang.ToString(), _maQH.ToString()).GetHashCode();
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
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_MacBenh_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("tenQH") != null) _tenQH = dr.GetString("tenQH");
            
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaQH") != null) _maQH = dr.GetString("MaQH");
            if (dr.GetInt32("DauMatMoi") != null) _dauMatMoi = dr.GetInt32("DauMatMoi");
            if (dr.GetInt32("DauMatCu") != null) _dauMatCu = dr.GetInt32("DauMatCu");
            if (dr.GetInt32("PhoiMoi") != null) _phoiMoi = dr.GetInt32("PhoiMoi");
            if (dr.GetInt32("PhoiCu") != null) _phoiCu = dr.GetInt32("PhoiCu");
            if (dr.GetInt32("VuMoi") != null) _vuMoi = dr.GetInt32("VuMoi");
            if (dr.GetInt32("VuCu") != null) _vuCu = dr.GetInt32("VuCu");
            if (dr.GetInt32("TieuHoaMoi") != null) _tieuHoaMoi = dr.GetInt32("TieuHoaMoi");
            if (dr.GetInt32("TieuHoaCu") != null) _tieuHoaCu = dr.GetInt32("TieuHoaCu");
            if (dr.GetInt32("HachMoi") != null) _hachMoi = dr.GetInt32("HachMoi");
            if (dr.GetInt32("HachCu") != null) _hachCu = dr.GetInt32("HachCu");
            if (dr.GetInt32("PhuMoi") != null) _phuMoi = dr.GetInt32("PhuMoi");
            if (dr.GetInt32("PhuCu") != null) _phuCu = dr.GetInt32("PhuCu");
            if (dr.GetInt32("KhacMoi") != null) _khacMoi = dr.GetInt32("KhacMoi");
            if (dr.GetInt32("KhacCu") != null) _khacCu = dr.GetInt32("KhacCu");
            if (dr.GetInt32("TongSo") != null) _tongSo = dr.GetInt32("TongSo");
            if (dr.GetInt32("MoiMac") != null) _moiMac = dr.GetInt32("MoiMac");
            if (dr.GetInt32("Ulanh") != null) _ulanh = dr.GetInt32("Ulanh");
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
            
              

            DataProvider.Instance().InsertBC_MacBenh(_maKhoa, _thang, _maQH, _dauMatMoi, _dauMatCu, _phoiMoi, _phoiCu, _vuMoi, _vuCu, _tieuHoaMoi, _tieuHoaCu, _hachMoi, _hachCu, _phuMoi, _phuCu, _khacMoi, _khacCu, _tongSo, _moiMac, _ulanh, _nguoiSD, _maMay);
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
                
                  

                DataProvider.Instance().UpdateBC_MacBenh(_maKhoa, _thang, _maQH, _dauMatMoi, _dauMatCu, _phoiMoi, _phoiCu, _vuMoi, _vuCu, _tieuHoaMoi, _tieuHoaCu, _hachMoi, _hachCu, _phuMoi, _phuCu, _khacMoi, _khacCu, _tongSo, _moiMac, _ulanh, _nguoiSD, _huy, _maMay);
				
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
            
            

            DataProvider.Instance().DeleteBC_MacBenh(_maKhoa, _thang, _maQH,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
