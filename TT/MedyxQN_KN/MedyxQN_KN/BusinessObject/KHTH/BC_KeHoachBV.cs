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
    public partial class BC_KeHoachBV : BusinessBase<BC_KeHoachBV>
    {
        #region Business Methods
		
		#region State Fields
        private String _Ten = String.Empty;
        
        //private String _maKhoa = String.Empty;
        private String _nam = String.Empty;
        private Decimal _ma = 0;
        private Decimal _kHThang1 = 0;
        private Decimal _tTThang1 = 0;
        private Decimal _kHThang2 = 0;
        private Decimal _tTThang2 = 0;
        private Decimal _kHThang3 = 0;
        private Decimal _tTThang3 = 0;
        private Decimal _kHThang4 = 0;
        private Decimal _tTThang4 = 0;
        private Decimal _kHThang5 = 0;
        private Decimal _tTThang5 = 0;
        private Decimal _kHThang6 = 0;
        private Decimal _tTThang6 = 0;
        private Decimal _kHThang7 = 0;
        private Decimal _tTThang7 = 0;
        private Decimal _kHThang8 = 0;
        private Decimal _tTThang8 = 0;
        private Decimal _kHThang9 = 0;
        private Decimal _tTThang9 = 0;
        private Decimal _kHThang10 = 0;
        private Decimal _tTThang10 = 0;
        private Decimal _kHThang11 = 0;
        private Decimal _tTThang11 = 0;
        private Decimal _kHThang12 = 0;
        private Decimal _tTThang12 = 0;
        private Decimal _tTTongCong = 0;
        private Decimal _kHTongCong = 0;
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaysd = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
         private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
         public String Ten
         {
             get
             {
                 CanReadProperty("Ten", true);
                 return _Ten;
             }
             set
             {
                 CanWriteProperty("Ten", true);
                 if (_Ten != value)
                 {
                     _Ten = value;
                     PropertyHasChanged("Ten");
                 }
             }
         }

         //public String MaKhoa
         //{
         //    get
         //    {
         //        CanReadProperty("MaKhoa", true);
         //        return _maKhoa;
         //    }
         //    set
         //    {
         //        CanWriteProperty("MaKhoa", true);
         //        if (_maKhoa != value)
         //        {
         //            _maKhoa = value;
         //            PropertyHasChanged("MaKhoa");
         //        }
         //    }
         //}
        public String Nam
        {
            get
            {
                CanReadProperty("Nam", true);
                return _nam;
            }
            set
            {
                CanWriteProperty("Nam", true);
                if (_nam != value)
                {
                    _nam = value;
                    PropertyHasChanged("Nam");
                }
            }
        }

        public Decimal Ma
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

        public Decimal KHThang1
        {
            get
            {
                CanReadProperty("KHThang1", true);
                return _kHThang1;
            }
            set
            {
                CanWriteProperty("KHThang1", true);
                if (_kHThang1 != value)
                {
                    _kHThang1 = value;
                    PropertyHasChanged("KHThang1");
                }
            }
        }

        public Decimal TTThang1
        {
            get
            {
                CanReadProperty("TTThang1", true);
                return _tTThang1;
            }
            set
            {
                CanWriteProperty("TTThang1", true);
                if (_tTThang1 != value)
                {
                    _tTThang1 = value;
                    PropertyHasChanged("TTThang1");
                }
            }
        }

        public Decimal KHThang2
        {
            get
            {
                CanReadProperty("KHThang2", true);
                return _kHThang2;
            }
            set
            {
                CanWriteProperty("KHThang2", true);
                if (_kHThang2 != value)
                {
                    _kHThang2 = value;
                    PropertyHasChanged("KHThang2");
                }
            }
        }

        public Decimal TTThang2
        {
            get
            {
                CanReadProperty("TTThang2", true);
                return _tTThang2;
            }
            set
            {
                CanWriteProperty("TTThang2", true);
                if (_tTThang2 != value)
                {
                    _tTThang2 = value;
                    PropertyHasChanged("TTThang2");
                }
            }
        }

        public Decimal KHThang3
        {
            get
            {
                CanReadProperty("KHThang3", true);
                return _kHThang3;
            }
            set
            {
                CanWriteProperty("KHThang3", true);
                if (_kHThang3 != value)
                {
                    _kHThang3 = value;
                    PropertyHasChanged("KHThang3");
                }
            }
        }

        public Decimal TTThang3
        {
            get
            {
                CanReadProperty("TTThang3", true);
                return _tTThang3;
            }
            set
            {
                CanWriteProperty("TTThang3", true);
                if (_tTThang3 != value)
                {
                    _tTThang3 = value;
                    PropertyHasChanged("TTThang3");
                }
            }
        }

        public Decimal KHThang4
        {
            get
            {
                CanReadProperty("KHThang4", true);
                return _kHThang4;
            }
            set
            {
                CanWriteProperty("KHThang4", true);
                if (_kHThang4 != value)
                {
                    _kHThang4 = value;
                    PropertyHasChanged("KHThang4");
                }
            }
        }

        public Decimal TTThang4
        {
            get
            {
                CanReadProperty("TTThang4", true);
                return _tTThang4;
            }
            set
            {
                CanWriteProperty("TTThang4", true);
                if (_tTThang4 != value)
                {
                    _tTThang4 = value;
                    PropertyHasChanged("TTThang4");
                }
            }
        }

        public Decimal KHThang5
        {
            get
            {
                CanReadProperty("KHThang5", true);
                return _kHThang5;
            }
            set
            {
                CanWriteProperty("KHThang5", true);
                if (_kHThang5 != value)
                {
                    _kHThang5 = value;
                    PropertyHasChanged("KHThang5");
                }
            }
        }

        public Decimal TTThang5
        {
            get
            {
                CanReadProperty("TTThang5", true);
                return _tTThang5;
            }
            set
            {
                CanWriteProperty("TTThang5", true);
                if (_tTThang5 != value)
                {
                    _tTThang5 = value;
                    PropertyHasChanged("TTThang5");
                }
            }
        }

        public Decimal KHThang6
        {
            get
            {
                CanReadProperty("KHThang6", true);
                return _kHThang6;
            }
            set
            {
                CanWriteProperty("KHThang6", true);
                if (_kHThang6 != value)
                {
                    _kHThang6 = value;
                    PropertyHasChanged("KHThang6");
                }
            }
        }

        public Decimal TTThang6
        {
            get
            {
                CanReadProperty("TTThang6", true);
                return _tTThang6;
            }
            set
            {
                CanWriteProperty("TTThang6", true);
                if (_tTThang6 != value)
                {
                    _tTThang6 = value;
                    PropertyHasChanged("TTThang6");
                }
            }
        }

        public Decimal KHThang7
        {
            get
            {
                CanReadProperty("KHThang7", true);
                return _kHThang7;
            }
            set
            {
                CanWriteProperty("KHThang7", true);
                if (_kHThang7 != value)
                {
                    _kHThang7 = value;
                    PropertyHasChanged("KHThang7");
                }
            }
        }

        public Decimal TTThang7
        {
            get
            {
                CanReadProperty("TTThang7", true);
                return _tTThang7;
            }
            set
            {
                CanWriteProperty("TTThang7", true);
                if (_tTThang7 != value)
                {
                    _tTThang7 = value;
                    PropertyHasChanged("TTThang7");
                }
            }
        }

        public Decimal KHThang8
        {
            get
            {
                CanReadProperty("KHThang8", true);
                return _kHThang8;
            }
            set
            {
                CanWriteProperty("KHThang8", true);
                if (_kHThang8 != value)
                {
                    _kHThang8 = value;
                    PropertyHasChanged("KHThang8");
                }
            }
        }

        public Decimal TTThang8
        {
            get
            {
                CanReadProperty("TTThang8", true);
                return _tTThang8;
            }
            set
            {
                CanWriteProperty("TTThang8", true);
                if (_tTThang8 != value)
                {
                    _tTThang8 = value;
                    PropertyHasChanged("TTThang8");
                }
            }
        }

        public Decimal KHThang9
        {
            get
            {
                CanReadProperty("KHThang9", true);
                return _kHThang9;
            }
            set
            {
                CanWriteProperty("KHThang9", true);
                if (_kHThang9 != value)
                {
                    _kHThang9 = value;
                    PropertyHasChanged("KHThang9");
                }
            }
        }

        public Decimal TTThang9
        {
            get
            {
                CanReadProperty("TTThang9", true);
                return _tTThang9;
            }
            set
            {
                CanWriteProperty("TTThang9", true);
                if (_tTThang9 != value)
                {
                    _tTThang9 = value;
                    PropertyHasChanged("TTThang9");
                }
            }
        }

        public Decimal KHThang10
        {
            get
            {
                CanReadProperty("KHThang10", true);
                return _kHThang10;
            }
            set
            {
                CanWriteProperty("KHThang10", true);
                if (_kHThang10 != value)
                {
                    _kHThang10 = value;
                    PropertyHasChanged("KHThang10");
                }
            }
        }

        public Decimal TTThang10
        {
            get
            {
                CanReadProperty("TTThang10", true);
                return _tTThang10;
            }
            set
            {
                CanWriteProperty("TTThang10", true);
                if (_tTThang10 != value)
                {
                    _tTThang10 = value;
                    PropertyHasChanged("TTThang10");
                }
            }
        }

        public Decimal KHThang11
        {
            get
            {
                CanReadProperty("KHThang11", true);
                return _kHThang11;
            }
            set
            {
                CanWriteProperty("KHThang11", true);
                if (_kHThang11 != value)
                {
                    _kHThang11 = value;
                    PropertyHasChanged("KHThang11");
                }
            }
        }

        public Decimal TTThang11
        {
            get
            {
                CanReadProperty("TTThang11", true);
                return _tTThang11;
            }
            set
            {
                CanWriteProperty("TTThang11", true);
                if (_tTThang11 != value)
                {
                    _tTThang11 = value;
                    PropertyHasChanged("TTThang11");
                }
            }
        }

        public Decimal KHThang12
        {
            get
            {
                CanReadProperty("KHThang12", true);
                return _kHThang12;
            }
            set
            {
                CanWriteProperty("KHThang12", true);
                if (_kHThang12 != value)
                {
                    _kHThang12 = value;
                    PropertyHasChanged("KHThang12");
                }
            }
        }

        public Decimal TTThang12
        {
            get
            {
                CanReadProperty("TTThang12", true);
                return _tTThang12;
            }
            set
            {
                CanWriteProperty("TTThang12", true);
                if (_tTThang12 != value)
                {
                    _tTThang12 = value;
                    PropertyHasChanged("TTThang12");
                }
            }
        }
        public Decimal TTTongCong
        {
            get
            {
                CanReadProperty("TTTongCong", true);

                _tTTongCong = _tTThang1+_tTThang10+_tTThang11+_tTThang12+_tTThang2+_tTThang3 +_tTThang4 +_tTThang5 +_tTThang6 +_tTThang7 +_tTThang8 +_tTThang9 ;
                return _tTTongCong;
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
        public Decimal KHTongCong
        {
            get
            {
                CanReadProperty("KHTongCong", true);

                _kHTongCong = _kHThang1 + _kHThang10 + _kHThang11 + _kHThang12 + _kHThang2 + _kHThang3 + _kHThang4 + _kHThang5 + _kHThang6 + _kHThang7 + _kHThang8 + _kHThang9;
                return _kHTongCong;
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
            return  _nam.ToString() + "!" + _ma;
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
        public static BC_KeHoachBV NewBC_KeHoachBV()
        {
            return new BC_KeHoachBV();
           
        }
        public static BC_KeHoachBV NewBC_KeHoachBV(String nam, Decimal ma)
        {
            return new BC_KeHoachBV(nam,ma );
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
       
        public static BC_KeHoachBV GetBC_KeHoachBV(SafeDataReader dr,int i)
        {
            return new BC_KeHoachBV(dr,i);
        }

        public static void DeleteBC_KeHoachBV(String nam, string ma)
        {
            DataPortal.Delete(new OtherCriteria(nam, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_KeHoachBV()
        {
            // Prevent direct creation
           
        }

        protected BC_KeHoachBV(String nam, Decimal ma)
        {
            MarkAsChild();
             
            _nam = nam;
            _ma = ma;
             
            //MarkOld();
        }
        protected BC_KeHoachBV(SafeDataReader dr,int i )//lay nhung nam hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("Ten") != null) _Ten = dr.GetString("Ten");
            
            //if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("Nam") != null) _nam = dr.GetString("Nam");
            if (dr.GetDecimal("Ma") != null) _ma = dr.GetDecimal("Ma");
            if (dr.GetDecimal("KHThang1") != null) _kHThang1 = dr.GetDecimal("KHThang1");
            if (dr.GetDecimal("TTThang1") != null) _tTThang1 = dr.GetDecimal("TTThang1");
            if (dr.GetDecimal("KHThang2") != null) _kHThang2 = dr.GetDecimal("KHThang2");
            if (dr.GetDecimal("TTThang2") != null) _tTThang2 = dr.GetDecimal("TTThang2");
            if (dr.GetDecimal("KHThang3") != null) _kHThang3 = dr.GetDecimal("KHThang3");
            if (dr.GetDecimal("TTThang3") != null) _tTThang3 = dr.GetDecimal("TTThang3");
            if (dr.GetDecimal("KHThang4") != null) _kHThang4 = dr.GetDecimal("KHThang4");
            if (dr.GetDecimal("TTThang4") != null) _tTThang4 = dr.GetDecimal("TTThang4");
            if (dr.GetDecimal("KHThang5") != null) _kHThang5 = dr.GetDecimal("KHThang5");
            if (dr.GetDecimal("TTThang5") != null) _tTThang5 = dr.GetDecimal("TTThang5");
            if (dr.GetDecimal("KHThang6") != null) _kHThang6 = dr.GetDecimal("KHThang6");
            if (dr.GetDecimal("TTThang6") != null) _tTThang6 = dr.GetDecimal("TTThang6");
            if (dr.GetDecimal("KHThang7") != null) _kHThang7 = dr.GetDecimal("KHThang7");
            if (dr.GetDecimal("TTThang7") != null) _tTThang7 = dr.GetDecimal("TTThang7");
            if (dr.GetDecimal("KHThang8") != null) _kHThang8 = dr.GetDecimal("KHThang8");
            if (dr.GetDecimal("TTThang8") != null) _tTThang8 = dr.GetDecimal("TTThang8");
            if (dr.GetDecimal("KHThang9") != null) _kHThang9 = dr.GetDecimal("KHThang9");
            if (dr.GetDecimal("TTThang9") != null) _tTThang9 = dr.GetDecimal("TTThang9");
            if (dr.GetDecimal("KHThang10") != null) _kHThang10 = dr.GetDecimal("KHThang10");
            if (dr.GetDecimal("TTThang10") != null) _tTThang10 = dr.GetDecimal("TTThang10");
            if (dr.GetDecimal("KHThang11") != null) _kHThang11 = dr.GetDecimal("KHThang11");
            if (dr.GetDecimal("TTThang11") != null) _tTThang11 = dr.GetDecimal("TTThang11");
            if (dr.GetDecimal("KHThang12") != null) _kHThang12 = dr.GetDecimal("KHThang12");
            if (dr.GetDecimal("TTThang12") != null) _tTThang12 = dr.GetDecimal("TTThang12");
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
            //private String _maKhoa;
            //public String MaKhoa
            //{
            //    get
            //    {
            //        return _maKhoa;
            //    }
            //}
            private String _nam;
            public String nam
            {
                get
                {
                    return _nam;
                }
            }
            private Decimal _ma;
            public Decimal ma
            {
                get
                {
                    return _ma;
                }
            }
            public Criteria(String nam, Decimal ma)
            {
           
                _ma = ma;
                _nam = nam;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if ((( !_nam.Equals(c._nam) || (!_ma.Equals(c._ma)))))
                        return false;
                    return true;
                }
                return false;
            }
            // abc
            public override int GetHashCode()
            {
                return string.Concat("Criteria",_nam.ToString(), _ma.ToString()).GetHashCode();
            }
        }
       
        [Serializable()]
      
        protected class OtherCriteria
        {
            //private String _maKhoa;
            //public String MaKhoa
            //{
            //    get
            //    {
            //        return _maKhoa;
            //    }
            //}
            private String _nam;
            public String nam
            {
                get
                {
                    return _nam;
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
            public OtherCriteria(String nam, String dk)
            {
                //_maKhoa = makhoa;
                _dk = dk;
                _nam = nam;
                
                  
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
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_KeHoachBV_Get
        {
            // Value properties
            _OrderNumber = i;
            //if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            //if (dr.GetString("TENKhoa") != null) _tenKhoa = dr.GetString("TENKhoa");
           
            if (dr.GetString("Nam") != null) _nam = dr.GetString("Nam");
            if (dr.GetDecimal("Ma") != null) _ma = dr.GetDecimal("Ma");
            if (dr.GetDecimal("KHThang1") != null) _kHThang1 = dr.GetDecimal("KHThang1");
            if (dr.GetDecimal("TTThang1") != null) _tTThang1 = dr.GetDecimal("TTThang1");
            if (dr.GetDecimal("KHThang2") != null) _kHThang2 = dr.GetDecimal("KHThang2");
            if (dr.GetDecimal("TTThang2") != null) _tTThang2 = dr.GetDecimal("TTThang2");
            if (dr.GetDecimal("KHThang3") != null) _kHThang3 = dr.GetDecimal("KHThang3");
            if (dr.GetDecimal("TTThang3") != null) _tTThang3 = dr.GetDecimal("TTThang3");
            if (dr.GetDecimal("KHThang4") != null) _kHThang4 = dr.GetDecimal("KHThang4");
            if (dr.GetDecimal("TTThang4") != null) _tTThang4 = dr.GetDecimal("TTThang4");
            if (dr.GetDecimal("KHThang5") != null) _kHThang5 = dr.GetDecimal("KHThang5");
            if (dr.GetDecimal("TTThang5") != null) _tTThang5 = dr.GetDecimal("TTThang5");
            if (dr.GetDecimal("KHThang6") != null) _kHThang6 = dr.GetDecimal("KHThang6");
            if (dr.GetDecimal("TTThang6") != null) _tTThang6 = dr.GetDecimal("TTThang6");
            if (dr.GetDecimal("KHThang7") != null) _kHThang7 = dr.GetDecimal("KHThang7");
            if (dr.GetDecimal("TTThang7") != null) _tTThang7 = dr.GetDecimal("TTThang7");
            if (dr.GetDecimal("KHThang8") != null) _kHThang8 = dr.GetDecimal("KHThang8");
            if (dr.GetDecimal("TTThang8") != null) _tTThang8 = dr.GetDecimal("TTThang8");
            if (dr.GetDecimal("KHThang9") != null) _kHThang9 = dr.GetDecimal("KHThang9");
            if (dr.GetDecimal("TTThang9") != null) _tTThang9 = dr.GetDecimal("TTThang9");
            if (dr.GetDecimal("KHThang10") != null) _kHThang10 = dr.GetDecimal("KHThang10");
            if (dr.GetDecimal("TTThang10") != null) _tTThang10 = dr.GetDecimal("TTThang10");
            if (dr.GetDecimal("KHThang11") != null) _kHThang11 = dr.GetDecimal("KHThang11");
            if (dr.GetDecimal("TTThang11") != null) _tTThang11 = dr.GetDecimal("TTThang11");
            if (dr.GetDecimal("KHThang12") != null) _kHThang12 = dr.GetDecimal("KHThang12");
            if (dr.GetDecimal("TTThang12") != null) _tTThang12 = dr.GetDecimal("TTThang12");
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
            
              

            DataProvider.Instance().InsertBC_KeHoachBV(_nam, _ma, _kHThang1, _tTThang1, _kHThang2, _tTThang2, _kHThang3, _tTThang3, _kHThang4, _tTThang4, _kHThang5, _tTThang5, _kHThang6, _tTThang6, _kHThang7, _tTThang7, _kHThang8, _tTThang8, _kHThang9, _tTThang9, _kHThang10, _tTThang10, _kHThang11, _tTThang11, _kHThang12, _tTThang12, _nguoiSD, _maMay);
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
                
                  

                DataProvider.Instance().UpdateBC_KeHoachBV(_nam, _ma, _kHThang1, _tTThang1, _kHThang2, _tTThang2, _kHThang3, _tTThang3, _kHThang4, _tTThang4, _kHThang5, _tTThang5, _kHThang6, _tTThang6, _kHThang7, _tTThang7, _kHThang8, _tTThang8, _kHThang9, _tTThang9, _kHThang10, _tTThang10, _kHThang11, _tTThang11, _kHThang12, _tTThang12, _nguoiSD, _huy, _maMay);
				
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
            
            

            DataProvider.Instance().DeleteBC_KeHoachBV(_nam, _ma,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
