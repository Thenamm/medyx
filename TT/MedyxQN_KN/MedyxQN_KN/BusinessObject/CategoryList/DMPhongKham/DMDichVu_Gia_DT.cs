// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_Gia_DT
// Kieu doi tuong  :	DMDichVu_Gia_DT
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
    /// This is a base generated class of <see cref="DMDichVu_Gia_DT" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMDichVu_Gia_DT : BusinessBase<DMDichVu_Gia_DT>
    {
        #region Business Methods

        #region State Fields

        private String _maDT = String.Empty;
        private String _tenDT = String.Empty;
        private Decimal _sTT = 0;
        private String _maDV = String.Empty;
        private Decimal _dongia = 0;
        private Decimal _soLuong = 0;
        private Decimal _dongiatt = 0;
        private Boolean _nhapsl = false;
        private String _tentat = String.Empty;
        private String _maLH = String.Empty;  //
        private String _mabs = String.Empty;
        private String _makhoa = String.Empty;
        private String _tenkhoa = String.Empty;
        private String _makhoa087 = String.Empty;
        private String _tenkhoa087 = String.Empty;
        private String _makhoaNG = String.Empty;
        private String _tenkhoaNG = String.Empty;
        private String _tenbs = String.Empty;
        private Decimal _giaChenhlenh = 0;
        private Boolean _aDChenhlech = false;
        private Boolean _dTBH = false;
        private Byte _aDPhongMo = 0;
        private Boolean _aDGiauSD = false;
        private Boolean _apdungsuagia = false;
        private Decimal _tyGia = 0;
        private String _tenDV = String.Empty;
        private Byte _loaiKQ = 0;
        private int _OrderNumber;
        private Boolean _apdungGoi = true;
        private String _tendd = String.Empty;
        private String _madd = String.Empty;
        private Boolean _inthu = false; 
        private Decimal _dongiaclc = 0;
        private Decimal _dongiadv = 0;
        #endregion

        #region Business Properties and Methods
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "";
                }
                else
                {
                    return _soLuong.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    if (value == "")
                        _soLuong = 0;
                    else
                        _soLuong = Decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }
        public String maLH
        {
            get
            {
                CanReadProperty("maLH", true);
                return _maLH;
            }
            set
            {
                CanWriteProperty("maLH", true);
                if (_maLH != value)
                {
                    _maLH = value;
                    PropertyHasChanged("maLH");
                }
            }
        }

        public Boolean inthu
        {
            get
            {
                CanReadProperty("inthu", true);
                return _inthu;
            }
            set
            {
                CanWriteProperty("inthu", true);
                if (_inthu != value)
                {
                    _inthu = value;
                    PropertyHasChanged("inthu");
                }
            }
        }
        public String tendd
        {
            get
            {
                if (_tentat.Length > 1)
                    _tendd = _maDV + " " + _tenDV;
                else
                    _tendd = _tenDV;
                CanReadProperty("tendd", true);
                return _tendd;
            }
        }
        public String madd
        {
            get
            {
                CanReadProperty("madd", true);
                return _madd;
            }
            set
            {
                CanWriteProperty("madd", true);
                if (madd != value)
                {
                    _tendd = value;
                    PropertyHasChanged("madd");
                }
            }
        }
        public Boolean ApdungGoi
        {
            get
            {
                CanReadProperty("ApdungGoi", true);
                return _apdungGoi;
            }
            set
            {
                CanWriteProperty("ApdungGoi", true);
                if (_apdungGoi != value)
                {
                    _apdungGoi = value;
                    PropertyHasChanged("ApdungGoi");
                }
            }
        }
        public Boolean apdungsuagia
        {
            get
            {
                CanReadProperty("apdungsuagia", true);
                return _apdungsuagia;
            }
            set
            {
                CanWriteProperty("apdungsuagia", true);
                if (_apdungsuagia != value)
                {
                    _apdungsuagia = value;
                    PropertyHasChanged("apdungsuagia");
                }
            }
        }
        public Byte LoaiKQ
        {
            get
            {
                CanReadProperty("LoaiKQ", true);
                return _loaiKQ;
            }
            set
            {
                CanWriteProperty("LoaiKQ", true);
                if (_loaiKQ != value)
                {
                    _loaiKQ = value;
                    PropertyHasChanged("LoaiKQ");
                }
            }
        }
        public Decimal TyGia
        {
            get
            {
                CanReadProperty("TyGia", true);
                return _tyGia;
            }
            set
            {
                CanWriteProperty("TyGia", true);
                if (_tyGia != value)
                {
                    _tyGia = value;
                    PropertyHasChanged("TyGia");
                }
            }
        }
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }
        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _tenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_tenDT != value)
                {
                    _tenDT = value;
                    PropertyHasChanged("TenDT");
                }
            }
        }
        public String tentat
        {
            get
            {
                CanReadProperty("tentat", true);
                return _tentat;
            }
            set
            {
                CanWriteProperty("tentat", true);
                if (_tentat != value)
                {
                    _tentat = value;
                    PropertyHasChanged("tentat");
                }
            }
        }
        public String mabs
        {
            get
            {
                CanReadProperty("mabs", true);
                return _mabs;
            }
            set
            {
                CanWriteProperty("mabs", true);
                if (_mabs != value)
                {
                    _mabs = value;
                    PropertyHasChanged("mabs");
                }
            }
        }
        public String tenbs
        {
            get
            {
                CanReadProperty("tenbs", true);
                return _tenbs;
            }
            set
            {
                CanWriteProperty("tenbs", true);
                if (_tenbs != value)
                {
                    _tenbs = value;
                    PropertyHasChanged("tenbs");
                }
            }
        }
        public String makhoa
        {
            get
            {
                CanReadProperty("makhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("makhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("makhoa");
                }
            }
        }
        public String tenkhoa
        {
            get
            {
                CanReadProperty("tenkhoa", true);
                return _tenkhoa;
            }
            set
            {
                CanWriteProperty("tenkhoa", true);
                if (_tenkhoa != value)
                {
                    _tenkhoa = value;
                    PropertyHasChanged("tenkhoa");
                }
            }
        }
        public String makhoaNG
        {
            get
            {
                CanReadProperty("makhoaNG", true);
                return _makhoaNG;
            }
            set
            {
                CanWriteProperty("makhoaNG", true);
                if (_makhoaNG != value)
                {
                    _makhoaNG = value;
                    PropertyHasChanged("makhoaNG");
                }
            }
        }
        public String tenkhoaNG
        {
            get
            {
                CanReadProperty("tenkhoaNG", true);
                return _tenkhoaNG;
            }
            set
            {
                CanWriteProperty("tenkhoaNG", true);
                if (_tenkhoaNG != value)
                {
                    _tenkhoaNG = value;
                    PropertyHasChanged("tenkhoaNG");
                }
            }
        }
        public String makhoa087
        {
            get
            {
                CanReadProperty("makhoa087", true);
                return _makhoa087;
            }
            set
            {
                CanWriteProperty("makhoa087", true);
                if (_makhoa087 != value)
                {
                    _makhoa087 = value;
                    PropertyHasChanged("makhoa087");
                }
            }
        }
        public String tenkhoa087
        {
            get
            {
                CanReadProperty("tenkhoa087", true);
                return _tenkhoa087;
            }
            set
            {
                CanWriteProperty("tenkhoa087", true);
                if (_tenkhoa087 != value)
                {
                    _tenkhoa087 = value;
                    PropertyHasChanged("tenkhoa087");
                }
            }
        }
        public Decimal STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _sTT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_sTT != value)
                {
                    _sTT = value;
                    PropertyHasChanged("STT");
                }
            }
        }
        public string dongiatt
        {
            get
            {
                CanReadProperty("dongiatt", true);
                return _dongiatt.ToString("###,###")  ;
            }
            set
            {
                CanWriteProperty("dongiatt", true);
                if (_dongiatt.ToString()  != value)
                {
                    _dongiatt = decimal.Parse(value);
                    PropertyHasChanged("dongiatt");
                }
            }
        }
        public string dongiadv
        {
            get
            {
                CanReadProperty("dongiadv", true);
                return _dongiadv.ToString("###,###");
            }
            set
            {
                CanWriteProperty("dongiadv", true);
                if (_dongiadv.ToString() != value)
                {
                    _dongiadv = decimal.Parse(value);
                    PropertyHasChanged("dongiadv");
                }
            }
        }
        public string dongiaclc
        {
            get
            {
                CanReadProperty("dongiaclc", true);
                return _dongiaclc.ToString("###,###");
            }
            set
            {
                CanWriteProperty("dongiaclc", true);
                if (_dongiaclc.ToString() != value)
                {
                    _dongiaclc = decimal.Parse(value);
                    PropertyHasChanged("dongiaclc");
                }
            }
        }
        public Boolean nhapsl
        {
            get
            {
                CanReadProperty("nhapsl", true);
                return _nhapsl;
            }
            set
            {
                CanWriteProperty("nhapsl", true);
                if (_nhapsl != value)
                {
                    _nhapsl = value;
                    PropertyHasChanged("nhapsl");
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

        public string Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                return _dongia.ToString("###,###") ;
            }
            set
            {
                CanWriteProperty("Dongia", true);
                if (_dongia.ToString()  != value)
                {
                    _dongia = decimal.Parse(value);
                    PropertyHasChanged("Dongia");
                }
            }
        }

        public string GiaChenhlenh
        {
            get
            {
                CanReadProperty("GiaChenhlenh", true);
                return _giaChenhlenh.ToString("###,###");
            }
            set
            {
                CanWriteProperty("GiaChenhlenh", true);
                if (_giaChenhlenh.ToString()  != value)
                {
                    _giaChenhlenh = decimal.Parse ( value);
                    PropertyHasChanged("GiaChenhlenh");
                }
            }
        }

        public Boolean ADChenhlech
        {
            get
            {
                CanReadProperty("ADChenhlech", true);
                return _aDChenhlech;
            }
            set
            {
                CanWriteProperty("ADChenhlech", true);
                if (_aDChenhlech != value)
                {
                    _aDChenhlech = value;
                    PropertyHasChanged("ADChenhlech");
                }
            }
        }

        public Boolean aDGiauSD
        {
            get
            {
                CanReadProperty("aDGiauSD", true);
                return _aDGiauSD;
            }
            set
            {
                CanWriteProperty("aDGiauSD", true);
                if (_aDGiauSD != value)
                {
                    _aDGiauSD = value;
                    PropertyHasChanged("aDGiauSD");
                }
            }
        }

        public Boolean DTBH
        {
            get
            {
                CanReadProperty("DTBH", true);
                return _dTBH;
            }
            set
            {
                CanWriteProperty("DTBH", true);
                if (_dTBH != value)
                {
                    _dTBH = value;
                    PropertyHasChanged("DTBH");
                }
            }
        }

        public Byte ADPhongMo
        {
            get
            {
                CanReadProperty("ADPhongMo", true);
                return _aDPhongMo;
            }
            set
            {
                CanWriteProperty("ADPhongMo", true);
                if (_aDPhongMo != value)
                {
                    _aDPhongMo = value;
                    PropertyHasChanged("ADPhongMo");
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
            return _maDT.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu_Gia_DT" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMDichVu_Gia_DT NewDMDichVu_Gia_DT()
        {
            return new DMDichVu_Gia_DT();
            //return DataPortal.Create<DMDichVu_Gia_DT>();
        }
        //public static DMDichVu_Gia_DT GetDMDichVu_Gia_DT(String maDT, Decimal sTT)
        //{
        //    return DataPortal.Fetch<DMDichVu_Gia_DT>(new Criteria(maDT, sTT));
        //}
        internal static DMDichVu_Gia_DT GetDMDichVu_Gia_DT(SafeDataReader dr, int i)
        {
            return new DMDichVu_Gia_DT(dr, i);
        }

        /// <summary>
        /// Marks the <see cref="DMDichVu_Gia_DT" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteDMDichVu_Gia_DT(String maDT, Decimal sTT)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDT, sTT));
        //}
        public DMDichVu_Gia_DT()
        {
            MarkAsChild();
        }

        #endregion

        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal DMDichVu_Gia_DT()
        //{	
        //    // Prevent direct creation
        //}
        //internal DMDichVu_Gia_DT(  
        //                         int OrderNumber,
        //                         String maDT ,
        //                         Decimal sTT,
        //                         String maDV ,
        //                         Decimal dongia ,
        //                         Decimal giaChenhlenh ,
        //                         Boolean aDChenhlech ,
        //                         Boolean dTBH ,
        //                         Boolean aDPhongMo ,
        //                         Boolean aDGiauSD,
        //                         Decimal dongia1 ,
        //                         Decimal giaChenhlenh1,
        //                         SmartDate ngay1 ,
        //                         String ghichu ,
        //                         String maMay ,
        //                         Boolean huy,
        //                         SmartDate ngayLap,
        //                         String nguoiLap ,
        //                         SmartDate ngayHuy,
        //                         String nguoiHuy ,
        //                         SmartDate ngaySD1 ,
        //                         String nguoiSD1 ,
        //                         SmartDate ngaySD ,
        //                         String nguoiSD,
        //                         String tenDV
        //     )
        //{
        //                          _OrderNumber = OrderNumber ;
        //                          _maDT = maDT ;
        //                          _sTT = sTT ;
        //                          _maDV = maDV ;
        //                          _dongia = dongia ;
        //                          _giaChenhlenh = giaChenhlenh ;
        //                          _aDChenhlech = aDChenhlech ;
        //                          _dTBH = dTBH ;
        //                          _aDPhongMo = aDPhongMo ;
        //                          _aDGiauSD = aDGiauSD;
        //                          _dongia1 = dongia1 ;
        //                          _giaChenhlenh1 = giaChenhlenh1; 
        //                          _ngay1 = ngay1 ;                                
        //                          _ghichu = ghichu ;
        //                          _maMay = maMay ;
        //                          _huy = huy ;
        //                          _ngayLap = ngayLap ;
        //                          _nguoiLap = nguoiLap ;
        //                          _ngayHuy = ngayHuy ;
        //                          _nguoiHuy = nguoiHuy ;
        //                          _nguoiSD1 = nguoiSD1 ;
        //                          _ngaySD = ngaySD ;
        //                          _nguoiSD = nguoiSD ;
        //                          _tenDV = tenDV;

        //}

        //#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
                }
            }

            private Decimal _sTT;
            public Decimal STT
            {
                get
                {
                    return _sTT;
                }
            }

            public Criteria(String maDT, Decimal sTT)
            {
                _maDT = maDT;
                _sTT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maDT.Equals(c._maDT))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maDT.ToString(), _sTT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDT;
            public String maDT
            {
                get
                {
                    return _maDT;
                }
            }

            private Decimal _sTT;
            public Decimal sTT
            {
                get
                {
                    return _sTT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDT, Decimal sTT)
            {
                _maDT = maDT;
                _sTT = sTT;
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
        /// Retrieve an existing <see cref="DMDichVu_Gia_DT" /> Object based on data in the database.
        /// </summary>
        /// 


        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetDMDichVu_Gia_DT(String _maDT, Byte _sTT);
        //    // public override IDataReader GetDMDichVu_Gia_DT(String _maDT, Byte _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_Gia_DT(crit.MaDT, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="DMDichVu_Gia_DT" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        //    if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
        //    if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
        //    if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
        //    if (dr.GetDecimal("GiaChenhlenh") != null) _giaChenhlenh = dr.GetDecimal("GiaChenhlenh");
        //    if (dr.GetBoolean("ADChenhlech") != null) _aDChenhlech = dr.GetBoolean("ADChenhlech");
        //    if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
        //    if (dr.GetBoolean("ADPhongMo") != null) _aDPhongMo = dr.GetBoolean("ADPhongMo");
        //    if (dr.GetBoolean("ADGiauSD") != null) _aDGiauSD = dr.GetBoolean("ADGiauSD");
        //    if (dr.GetDecimal("Dongia1") != null) _dongia1 = dr.GetDecimal("Dongia1");
        //    if (dr.GetDecimal("GiaChenhlenh1") != null) _giaChenhlenh1 = dr.GetDecimal("GiaChenhlenh1");
        //    if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayLap") != null) _ngayLap = dr.GetSmartDate("NgayLap");
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
        //}

        /// <summary>
        /// Insert the new <see cref="DMDichVu_Gia_DT" /> Object to underlying database.
        /// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_Gia_DT
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //    _maDT = DataProvider.Instance().InsertDMDichVu_Gia_DT(_maDT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _giaChenhlenh1, _ngay1, _ghichu, _maMay, _nguoiSD , _aDGiauSD);
        //    // public abstract String InsertDMDichVu_Gia_DT(String _maDT, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //    // public override String InsertDMDichVu_Gia_DT(String _maDT, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //    // {
        //    //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _ngay1.DBValue, _ghichu, _maMay, _huy, _ngayLap, _nguoiSD , _ngayHuy, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1, _ngaySD.DBValue, _nguoiSD), String);
        //    // }
        //}
        private DMDichVu_Gia_DT(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
            if (dr.GetDecimal("GiaChenhlenh") != null) _giaChenhlenh = dr.GetDecimal("GiaChenhlenh");
            if (dr.GetBoolean("ADChenhlech") != null) _aDChenhlech = dr.GetBoolean("ADChenhlech");
            if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
            if (dr.GetByte("ADPhongMo") != null) _aDPhongMo = dr.GetByte("ADPhongMo");
            if (dr.GetBoolean("ADGiauSD") != null) _aDGiauSD = dr.GetBoolean("ADGiauSD");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("tentat") != null) _tentat = dr.GetString("tentat");
            if (HTC.ShareVariables .pub_spC =="HU") 
            if (dr.GetString("MaDD") != null) _madd = dr.GetString("MaDD");

            if (dr.GetString("mabs") != null) _mabs = dr.GetString("mabs");
            if (dr.GetString("tenbs") != null) _tenbs = dr.GetString("tenbs");
            if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetDecimal("dongiatt") != null) _dongiatt = dr.GetDecimal("dongiatt");
            if (dr.GetDecimal("dongiaclc") != null) _dongiaclc = dr.GetDecimal("dongiaclc");
            if (dr.GetDecimal("dongiadv") != null) _dongiadv = dr.GetDecimal("dongiadv");
            if (dr.GetString("makhoa") != null) _makhoa = dr.GetString("makhoa");
            if (dr.GetString("tenkhoa") != null) _tenkhoa = dr.GetString("tenkhoa");
            if (dr.GetString("makhoa087") != null) _makhoa087 = dr.GetString("makhoa087");
            if (dr.GetString("makhoaNG") != null) _makhoaNG = dr.GetString("makhoaNG");
            if (dr.GetString("tenkhoa087") != null) _tenkhoa087 = dr.GetString("tenkhoa087");
            if (dr.GetString("tenkhoang") != null) _tenkhoaNG = dr.GetString("tenkhoang");
            if (dr.GetDecimal("GiaChenhlenh") != null) _giaChenhlenh = dr.GetDecimal("GiaChenhlenh");
            if (dr.GetDecimal("tygia") != null) _tyGia = dr.GetDecimal("tygia");
            if (dr.GetBoolean("nhapsl") != null) _nhapsl = dr.GetBoolean("nhapsl");
            if (dr.GetByte("LoaiKQ") != null) _loaiKQ = dr.GetByte("LoaiKQ");
            if (dr.GetBoolean("ApdungGoi") != null) _apdungGoi = dr.GetBoolean("ApdungGoi");
            if (dr.GetBoolean("Apdungsuagia") != null) _apdungsuagia = dr.GetBoolean("Apdungsuagia");
            if (dr.GetBoolean("inthu") != null) _inthu = dr.GetBoolean("inthu");
          
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            //  _maDT = DataProvider.Instance().InsertDMDichVu_Gia_DT(_maDT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _giaChenhlenh1, _ngay1, _ghichu, _maMay, _nguoiSD , _aDGiauSD);
            // public abstract String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, String _maMay);
            // public override String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoa_Create", _makho, _makhoa, _maThuoc, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="DMDichVu_Gia_DT" /> Object to underlying database.
        /// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Gia_DT
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateDMDichVu_Gia_DT(_maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD , _aDGiauSD);
        //        // public abstract void UpdateDMDichVu_Gia_DT(String _maDT, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //        // public override void UpdateDMDichVu_Gia_DT(String _maDT, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _ngay1.DBValue, _ghichu, _maMay, _huy, _ngayLap, _nguoiSD , _ngayHuy, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1, _ngaySD.DBValue, _nguoiSD);
        //        // }				
        //    }
        //}
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            //
            //  
            //DataProvider.Instance().UpdateDMDichVu_Gia_DT(_maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD , _aDGiauSD);
            // public abstract void UpdateDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay);
            // public override void UpdateDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoa_Update", _makho, _sTT, _makhoa, _maThuoc, _huy, _nguoiSD , _maMay);
            // }				
            MarkOld();
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDT, _sTT));
        //}
        internal void DeleteSelf()
        {
            //if (!this.IsDirty)
            //    return;
            //if (this.IsNew)
            //    return;
            //DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDT, _sTT));
            //MarkNew();
        }


        /// <summary>
        /// Delete the <see cref="DMDichVu_Gia_DT" />.
        /// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Gia_DT
        //    DataProvider.Instance().DeleteDMDichVu_Gia_DT(crit.MaMay, crit.NguoiSD, crit.maDT, crit.sTT);
        //    // public abstract void DeleteDMDichVu_Gia_DT(String _maDT, Byte _sTT);
        //    // public override void DeleteDMDichVu_Gia_DT(String _maDT, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT);
        //    // }
        //}
        private void DataPortal_Delete(OtherCriteria crit)
        {
            //DataProvider.Instance().DeleteDMDichVu_Gia_DT(crit.MaMay, crit.NguoiSD, crit.maDT, crit.sTT);
        }

        #endregion
    }

}
