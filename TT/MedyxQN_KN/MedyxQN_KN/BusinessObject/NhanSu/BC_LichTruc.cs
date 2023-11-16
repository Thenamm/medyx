using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
//


namespace HTC.Business.NhanSu
{
    [Serializable()]
    public partial class BC_LichTruc : BusinessBase<BC_LichTruc>
    {
        #region Business Methods
		
		#region State Fields
        private String _HoTen = String.Empty;
       
        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _maNV= String.Empty;
        private String _Ngay1 = String.Empty;
        private String _Ngay2 = String.Empty;
        private String _Ngay3 = String.Empty;
        private String _Ngay4 = String.Empty;
        private String _Ngay5 = String.Empty;
        private String _Ngay6 = String.Empty;
        private String _Ngay7 = String.Empty;
        private String _Ngay8 = String.Empty;
        private String _Ngay9 = String.Empty;
        private String _Ngay10 = String.Empty;

        private String _Ngay11 = String.Empty;
        private String _Ngay12 = String.Empty;
        private String _Ngay13 = String.Empty;
        private String _Ngay14 = String.Empty;
        private String _Ngay15 = String.Empty;
        private String _Ngay16 = String.Empty;
        private String _Ngay17 = String.Empty;
        private String _Ngay18 = String.Empty;
        private String _Ngay19 = String.Empty;
        private String _Ngay20 = String.Empty;

        private String _Ngay21 = String.Empty;
        private String _Ngay22 = String.Empty;
        private String _Ngay23 = String.Empty;
        private String _Ngay24 = String.Empty;
        private String _Ngay25 = String.Empty;
        private String _Ngay26 = String.Empty;
        private String _Ngay27 = String.Empty;
        private String _Ngay28 = String.Empty;
        private String _Ngay29 = String.Empty;
        private String _Ngay30 = String.Empty;
        private String _Ngay31 = String.Empty;
        private String _TenChuyenMon = String.Empty;
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaysd = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
         private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
        public String TenChuyenMon
        {
            get
            {
                CanReadProperty("TenChuyenMon", true);
                return _TenChuyenMon;
            }
            set
            {
                CanWriteProperty("TenChuyenMon", true);
                if (_TenChuyenMon != value)
                {
                    _TenChuyenMon = value;
                    PropertyHasChanged("TenChuyenMon");
                }
            }
        }
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _HoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_HoTen != value)
                {
                    _HoTen = value;
                    PropertyHasChanged("HoTen");
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

        public String MaNV
        {
            get
            {
                CanReadProperty("MaNV", true);
                return _maNV;
            }
            set
            {
                CanWriteProperty("MaNV", true);
                if (_maNV!= value)
                {
                    _maNV= value;
                    PropertyHasChanged("MaNV");
                }
            }
        }

        public String Ngay1
        {
            get
            {
                CanReadProperty("Ngay1", true);
                return _Ngay1;
            }
            set
            {
                CanWriteProperty("Ngay1", true);
                if (_Ngay1 != value)
                {
                    _Ngay1 = value;
                    PropertyHasChanged("Ngay1");
                }
            }
        }

        public String Ngay2
        {
            get
            {
                CanReadProperty("Ngay2", true);
              
                return _Ngay2;
            }
            set
            {
                CanWriteProperty("Ngay2", true);
                if (_Ngay2 != value)
                {
                    _Ngay2 = value;
                    PropertyHasChanged("Ngay2");
                }
            }
        }
        public String Ngay3
        {
            get
            {
                CanReadProperty("Ngay3", true);
              
                return _Ngay3;
            }
            set
            {
                CanWriteProperty("Ngay3", true);
                if (_Ngay3 != value)
                {
                    _Ngay3 = value;
                    PropertyHasChanged("Ngay3");
                }
            }

        }
        public String Ngay4
        {
            get
            {
                CanReadProperty("Ngay4", true);
                return _Ngay4;
            }
            set
            {
                CanWriteProperty("Ngay4", true);
                if (_Ngay4 != value)
                {
                    _Ngay4 = value;
                    PropertyHasChanged("Ngay4");
                }
            }
        }

        public String Ngay5
        {
            get
            {
                CanReadProperty("Ngay5", true);
                return _Ngay5;
            }
            set
            {
                CanWriteProperty("Ngay5", true);
                if (_Ngay5 != value)
                {
                    _Ngay5 = value;
                    PropertyHasChanged("Ngay5");
                }
            }
        }

        public String Ngay6
        {
            get
            {
                CanReadProperty("Ngay6", true);
                return _Ngay6;
            }
            set
            {
                CanWriteProperty("Ngay6", true);
                if (_Ngay6 != value)
                {
                    _Ngay6 = value;
                    PropertyHasChanged("Ngay6");
                }
            }
        }

        public String Ngay7
        {
            get
            {
                CanReadProperty("Ngay7", true);
                return _Ngay7;
            }
            set
            {
                CanWriteProperty("Ngay7", true);
                if (_Ngay7 != value)
                {
                    _Ngay7 = value;
                    PropertyHasChanged("Ngay7");
                }
            }
        }

        public String Ngay8
        {
            get
            {
                CanReadProperty("Ngay8", true);
           
                return _Ngay8;
            }
            set
            {
                CanWriteProperty("Ngay8", true);
                if (_Ngay8 != value)
                {
                    _Ngay8 = value;
                    PropertyHasChanged("Ngay8");
                }
            }
        }

        public String Ngay9
        {
            get
            {
                CanReadProperty("Ngay9", true);
                
                return _Ngay9;
            }
            set
            {
                CanWriteProperty("Ngay9", true);
                if (_Ngay9 != value)
                {
                    _Ngay9 = value;
                    PropertyHasChanged("Ngay9");
                }
            }
        }
      
        public String Ngay10
        {
            get
            {
                CanReadProperty("Ngay10", true);
                return _Ngay10;
            }
            set
            {
                CanWriteProperty("Ngay10", true);
                if (_Ngay10 != value)
                {
                    _Ngay10 = value;
                    PropertyHasChanged("Ngay10");
                }
            }
        }


        public String Ngay11
        {
            get
            {
                CanReadProperty("Ngay11", true);
                return _Ngay11;
            }
            set
            {
                CanWriteProperty("Ngay11", true);
                if (_Ngay11 != value)
                {
                    _Ngay11 = value;
                    PropertyHasChanged("Ngay11");
                }
            }
        }

        public String Ngay12
        {
            get
            {
                CanReadProperty("Ngay12", true);

                return _Ngay12;
            }
            set
            {
                CanWriteProperty("Ngay12", true);
                if (_Ngay12 != value)
                {
                    _Ngay12 = value;
                    PropertyHasChanged("Ngay12");
                }
            }
        }
        public String Ngay13
        {
            get
            {
                CanReadProperty("Ngay13", true);

                return _Ngay13;
            }
            set
            {
                CanWriteProperty("Ngay13", true);
                if (_Ngay13 != value)
                {
                    _Ngay13 = value;
                    PropertyHasChanged("Ngay13");
                }
            }

        }
        public String Ngay14
        {
            get
            {
                CanReadProperty("Ngay14", true);
                return _Ngay14;
            }
            set
            {
                CanWriteProperty("Ngay14", true);
                if (_Ngay14 != value)
                {
                    _Ngay14 = value;
                    PropertyHasChanged("Ngay14");
                }
            }
        }

        public String Ngay15
        {
            get
            {
                CanReadProperty("Ngay15", true);
                return _Ngay15;
            }
            set
            {
                CanWriteProperty("Ngay15", true);
                if (_Ngay15 != value)
                {
                    _Ngay15 = value;
                    PropertyHasChanged("Ngay15");
                }
            }
        }

        public String Ngay16
        {
            get
            {
                CanReadProperty("Ngay16", true);
                return _Ngay16;
            }
            set
            {
                CanWriteProperty("Ngay16", true);
                if (_Ngay16 != value)
                {
                    _Ngay16 = value;
                    PropertyHasChanged("Ngay16");
                }
            }
        }

        public String Ngay17
        {
            get
            {
                CanReadProperty("Ngay17", true);
                return _Ngay17;
            }
            set
            {
                CanWriteProperty("Ngay17", true);
                if (_Ngay17 != value)
                {
                    _Ngay17 = value;
                    PropertyHasChanged("Ngay17");
                }
            }
        }

        public String Ngay18
        {
            get
            {
                CanReadProperty("Ngay18", true);

                return _Ngay18;
            }
            set
            {
                CanWriteProperty("Ngay18", true);
                if (_Ngay18 != value)
                {
                    _Ngay18 = value;
                    PropertyHasChanged("Ngay18");
                }
            }
        }

        public String Ngay19
        {
            get
            {
                CanReadProperty("Ngay19", true);

                return _Ngay19;
            }
            set
            {
                CanWriteProperty("Ngay19", true);
                if (_Ngay19 != value)
                {
                    _Ngay19 = value;
                    PropertyHasChanged("Ngay19");
                }
            }
        }
       
        public String Ngay20
        {
            get
            {
                CanReadProperty("Ngay20", true);
                return _Ngay20;
            }
            set
            {
                CanWriteProperty("Ngay20", true);
                if (_Ngay20 != value)
                {
                    _Ngay20 = value;
                    PropertyHasChanged("Ngay20");
                }
            }
        }
      
        public String Ngay21
        {
            get
            {
                CanReadProperty("Ngay21", true);
                return _Ngay21;
            }
            set
            {
                CanWriteProperty("Ngay21", true);
                if (_Ngay21 != value)
                {
                    _Ngay21 = value;
                    PropertyHasChanged("Ngay21");
                }
            }
        }

        public String Ngay22
        {
            get
            {
                CanReadProperty("Ngay22", true);

                return _Ngay22;
            }
            set
            {
                CanWriteProperty("Ngay22", true);
                if (_Ngay22 != value)
                {
                    _Ngay22 = value;
                    PropertyHasChanged("Ngay22");
                }
            }
        }
        public String Ngay23
        {
            get
            {
                CanReadProperty("Ngay23", true);

                return _Ngay23;
            }
            set
            {
                CanWriteProperty("Ngay23", true);
                if (_Ngay23 != value)
                {
                    _Ngay23 = value;
                    PropertyHasChanged("Ngay23");
                }
            }
        }
        public String Ngay24
        {
            get
            {
                CanReadProperty("Ngay24", true);
                return _Ngay24;
            }
            set
            {
                CanWriteProperty("Ngay24", true);
                if (_Ngay24 != value)
                {
                    _Ngay24 = value;
                    PropertyHasChanged("Ngay24");
                }
            }
        }

        public String Ngay25
        {
            get
            {
                CanReadProperty("Ngay25", true);
                return _Ngay25;
            }
            set
            {
                CanWriteProperty("Ngay25", true);
                if (_Ngay25 != value)
                {
                    _Ngay25 = value;
                    PropertyHasChanged("Ngay25");
                }
            }
        }

        public String Ngay26
        {
            get
            {
                CanReadProperty("Ngay26", true);
                return _Ngay26;
            }
            set
            {
                CanWriteProperty("Ngay26", true);
                if (_Ngay26 != value)
                {
                    _Ngay26 = value;
                    PropertyHasChanged("Ngay26");
                }
            }
        }

        public String Ngay27
        {
            get
            {
                CanReadProperty("Ngay27", true);
                return _Ngay27;
            }
            set
            {
                CanWriteProperty("Ngay27", true);
                if (_Ngay27 != value)
                {
                    _Ngay27 = value;
                    PropertyHasChanged("Ngay27");
                }
            }
        }

        public String Ngay28
        {
            get
            {
                CanReadProperty("Ngay28", true);

                return _Ngay28;
            }
            set
            {
                CanWriteProperty("Ngay28", true);
                if (_Ngay28 != value)
                {
                    _Ngay28 = value;
                    PropertyHasChanged("Ngay28");
                }
            }
        }

        public String Ngay29
        {
            get
            {
                CanReadProperty("Ngay29", true);

                return _Ngay29;
            }
            set
            {
                CanWriteProperty("Ngay29", true);
                if (_Ngay29 != value)
                {
                    _Ngay29 = value;
                    PropertyHasChanged("Ngay29");
                }
            }
        }
        public String Ngay30
        {
            get
            {
                CanReadProperty("Ngay30", true);
                return _Ngay30;
            }
            set
            {
                CanWriteProperty("Ngay30", true);
                if (_Ngay30 != value)
                {
                    _Ngay30 = value;
                    PropertyHasChanged("Ngay30");
                }
            }
        }
        public String Ngay31
        {
            get
            {
                CanReadProperty("Ngay31", true);
                return _Ngay31;
            }
            set
            {
                CanWriteProperty("Ngay31", true);
                if (_Ngay31 != value)
                {
                    _Ngay31 = value;
                    PropertyHasChanged("Ngay31");
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
            return _maKhoa.ToString() + "!" + _thang.ToString() + "!" + _maNV.ToString();
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
        public static BC_LichTruc NewBC_LichTruc()
        {
            return new BC_LichTruc();
           
        }
        public static BC_LichTruc NewBC_LichTruc(string Makhoa, SmartDate thang, string ma)
        {
            return new BC_LichTruc(Makhoa,thang,ma );
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
       
        public static BC_LichTruc GetBC_LichTruc(SafeDataReader dr,int i)
        {
            return new BC_LichTruc(dr,i);
        }

        public static void DeleteBC_LichTruc(String makhoa, SmartDate thang, string ma)
        {
            DataPortal.Delete(new OtherCriteria(makhoa,thang, ma));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BC_LichTruc()
        {
            // Prevent direct creation
           
        }

        protected BC_LichTruc(String makhoa, SmartDate thang, string ma)
        {
            MarkAsChild();
            _maKhoa = makhoa;
            _thang = thang;
            _maNV= ma;
             
            //MarkOld();
        }
        protected BC_LichTruc(SafeDataReader dr,int i )//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
           
            if (dr.GetString("HoTen") != null) _HoTen = dr.GetString("HoTen");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("TenChuyenMon") != null) _TenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("MaNV") != null) _maNV= dr.GetString("MaNV");
            if (dr.GetString("Ngay1") != null) _Ngay1 = dr.GetString("Ngay1");
            if (dr.GetString("Ngay2") != null) _Ngay2 = dr.GetString("Ngay2");
            if (dr.GetString("Ngay3") != null) _Ngay3 = dr.GetString("Ngay3");
            if (dr.GetString("Ngay4") != null) _Ngay4 = dr.GetString("Ngay4");
            if (dr.GetString("Ngay5") != null) _Ngay5 = dr.GetString("Ngay5");
            if (dr.GetString("Ngay6") != null) _Ngay6 = dr.GetString("Ngay6");
            if (dr.GetString("Ngay7") != null) _Ngay7 = dr.GetString("Ngay7");
            if (dr.GetString("Ngay8") != null) _Ngay8 = dr.GetString("Ngay8");
            if (dr.GetString("Ngay9") != null) _Ngay9 = dr.GetString("Ngay9");
            if (dr.GetString("Ngay10") != null) _Ngay1 = dr.GetString("Ngay10");

            if (dr.GetString("Ngay11") != null) _Ngay11 = dr.GetString("Ngay11");
            if (dr.GetString("Ngay12") != null) _Ngay12 = dr.GetString("Ngay12");
            if (dr.GetString("Ngay13") != null) _Ngay13 = dr.GetString("Ngay13");
            if (dr.GetString("Ngay14") != null) _Ngay14 = dr.GetString("Ngay14");
            if (dr.GetString("Ngay15") != null) _Ngay15 = dr.GetString("Ngay15");
            if (dr.GetString("Ngay16") != null) _Ngay16 = dr.GetString("Ngay16");
            if (dr.GetString("Ngay17") != null) _Ngay17 = dr.GetString("Ngay17");
            if (dr.GetString("Ngay18") != null) _Ngay18 = dr.GetString("Ngay18");
            if (dr.GetString("Ngay19") != null) _Ngay19 = dr.GetString("Ngay19");
            if (dr.GetString("Ngay20") != null) _Ngay20 = dr.GetString("Ngay20");
            if (dr.GetString("Ngay21") != null) _Ngay21 = dr.GetString("Ngay21");
            if (dr.GetString("Ngay22") != null) _Ngay22 = dr.GetString("Ngay22");
            if (dr.GetString("Ngay23") != null) _Ngay23 = dr.GetString("Ngay23");
            if (dr.GetString("Ngay24") != null) _Ngay24 = dr.GetString("Ngay24");
            if (dr.GetString("Ngay25") != null) _Ngay25 = dr.GetString("Ngay25");
            if (dr.GetString("Ngay26") != null) _Ngay26 = dr.GetString("Ngay26");
            if (dr.GetString("Ngay27") != null) _Ngay27 = dr.GetString("Ngay27");
            if (dr.GetString("Ngay28") != null) _Ngay28 = dr.GetString("Ngay28");
            if (dr.GetString("Ngay29") != null) _Ngay29 = dr.GetString("Ngay29");
            if (dr.GetString("Ngay30") != null) _Ngay30 = dr.GetString("Ngay30");
            if (dr.GetString("Ngay31") != null) _Ngay31 = dr.GetString("Ngay31");
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
                _ma= ma;
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
        private void Fetch(SafeDataReader dr,int i)//lay o chi tiet thu tuc spBC_LichTruc_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            
            if (dr.GetString("HoTen") != null) _HoTen = dr.GetString("HoTen");
            if (dr.GetString("TenChuyenMon") != null) _TenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV= dr.GetString("MaNV");
            if (dr.GetString("Ngay1") != null) _Ngay1 = dr.GetString("Ngay1");
            if (dr.GetString("Ngay2") != null) _Ngay2 = dr.GetString("Ngay2");
            if (dr.GetString("Ngay3") != null) _Ngay3 = dr.GetString("Ngay3");
            if (dr.GetString("Ngay4") != null) _Ngay4 = dr.GetString("Ngay4");
            if (dr.GetString("Ngay5") != null) _Ngay5 = dr.GetString("Ngay5");
            if (dr.GetString("Ngay6") != null) _Ngay6 = dr.GetString("Ngay6");
            if (dr.GetString("Ngay7") != null) _Ngay7 = dr.GetString("Ngay7");
            if (dr.GetString("Ngay8") != null) _Ngay8 = dr.GetString("Ngay8");
            if (dr.GetString("Ngay9") != null) _Ngay9 = dr.GetString("Ngay9");
            if (dr.GetString("Ngay10") != null) _Ngay1 = dr.GetString("Ngay10");

            if (dr.GetString("Ngay11") != null) _Ngay11 = dr.GetString("Ngay11");
            if (dr.GetString("Ngay12") != null) _Ngay12 = dr.GetString("Ngay12");
            if (dr.GetString("Ngay13") != null) _Ngay13 = dr.GetString("Ngay13");
            if (dr.GetString("Ngay14") != null) _Ngay14 = dr.GetString("Ngay14");
            if (dr.GetString("Ngay15") != null) _Ngay15 = dr.GetString("Ngay15");
            if (dr.GetString("Ngay16") != null) _Ngay16 = dr.GetString("Ngay16");
            if (dr.GetString("Ngay17") != null) _Ngay17 = dr.GetString("Ngay17");
            if (dr.GetString("Ngay18") != null) _Ngay18 = dr.GetString("Ngay18");
            if (dr.GetString("Ngay19") != null) _Ngay19 = dr.GetString("Ngay19");
            if (dr.GetString("Ngay20") != null) _Ngay20 = dr.GetString("Ngay20");
            if (dr.GetString("Ngay21") != null) _Ngay21 = dr.GetString("Ngay21");
            if (dr.GetString("Ngay22") != null) _Ngay22 = dr.GetString("Ngay22");
            if (dr.GetString("Ngay23") != null) _Ngay23 = dr.GetString("Ngay23");
            if (dr.GetString("Ngay24") != null) _Ngay24 = dr.GetString("Ngay24");
            if (dr.GetString("Ngay25") != null) _Ngay25 = dr.GetString("Ngay25");
            if (dr.GetString("Ngay26") != null) _Ngay26 = dr.GetString("Ngay26");
            if (dr.GetString("Ngay27") != null) _Ngay27 = dr.GetString("Ngay27");
            if (dr.GetString("Ngay28") != null) _Ngay28 = dr.GetString("Ngay28");
            if (dr.GetString("Ngay29") != null) _Ngay29 = dr.GetString("Ngay29");
            if (dr.GetString("Ngay30") != null) _Ngay30 = dr.GetString("Ngay30");
            if (dr.GetString("Ngay31") != null) _Ngay31 = dr.GetString("Ngay31");
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



            DataProvider.Instance().InsertBC_LichTruc( _thang, _maNV,_maKhoa, _Ngay1, _Ngay2,_Ngay3 , _Ngay4, _Ngay5, _Ngay6, _Ngay7, _Ngay8, _Ngay9, _Ngay10, _Ngay11, _Ngay12, _Ngay13, _Ngay14, _Ngay15, _Ngay16, _Ngay17, _Ngay18, _Ngay19, _Ngay20, _Ngay21, _Ngay22,_Ngay23 , _Ngay24, _Ngay25, _Ngay26, _Ngay27, _Ngay28, _Ngay29, _Ngay30,_Ngay31, _maMay, _nguoiSD);
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



                DataProvider.Instance().UpdateBC_LichTruc(_thang, _maNV, _maKhoa, _Ngay1, _Ngay2, _Ngay3, _Ngay4, _Ngay5, _Ngay6, _Ngay7, _Ngay8, _Ngay9, _Ngay10, _Ngay11, _Ngay12, _Ngay13, _Ngay14, _Ngay15, _Ngay16, _Ngay17, _Ngay18, _Ngay19, _Ngay20, _Ngay21, _Ngay22, _Ngay23, _Ngay24, _Ngay25, _Ngay26, _Ngay27, _Ngay28, _Ngay29, _Ngay30, _Ngay31, _maMay, _huy, _nguoiSD);
				
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
            
            

            DataProvider.Instance().DeleteBC_LichTruc(_maKhoa, _thang, _maNV,_nguoiSD, _maMay);
            MarkNew();
        }
		#endregion
	}

   
}
