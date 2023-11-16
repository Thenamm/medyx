// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMCNK_Gia
// Kieu doi tuong  :	DMCNK_Gia
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/15/2008 9:51:22 AM
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
    /// This is a base generated class of <see cref="DMCNK_Gia" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMCNK_Gia : BusinessBase<DMCNK_Gia>
    {
        #region Business Methods

        #region State Fields

        private String _maDT = String.Empty;
        private String _tenDT = String.Empty;
        private Decimal _STT = 0;
        private String _maVT = String.Empty;
        private String _tenTM = String.Empty;
        private String _TenDVT = String.Empty;
        private Decimal _donGiaBH = 0;
        private Decimal _donGiaThuT = 0;
        private Decimal _donGiaPhauT = 0;
        private Decimal _donGiaCLS = 0;
        private Decimal _giachenhlech = 0;
        private Boolean _aDChenhlech = false;
        private Boolean _DTBH = false;
        private Byte _aDPhongMo = 0;
        private Decimal _donGia1 = 0;
        private Decimal _giachenhlech1 = 0;
        private DateTime _ngay1 = DateTime.Now;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(false);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(false);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(false);
        private String _nguoiSD1 = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

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

        public Decimal STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _STT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_STT != value)
                {
                    _STT = value;
                    PropertyHasChanged("STT");
                }
            }
        }

        public String MaVT
        {
            get
            {
                CanReadProperty("MaVT", true);
                return _maVT;
            }
            set
            {
                CanWriteProperty("MaVT", true);
                if (_maVT != value)
                {
                    _maVT = value;
                    PropertyHasChanged("MaVT");
                }
            }
        }
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _TenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_TenDVT != value)
                {
                    _TenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
        //public Decimal DonGiaBH
        //{
        //    get
        //    {
        //        CanReadProperty("DonGiaBH", true);
        //        return _donGiaBH;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DonGiaBH", true);
        //        if (_donGiaBH != value)
        //        {
        //            _donGiaBH = value;
        //            PropertyHasChanged("DonGiaBH");
        //        }
        //    }
        //}
        public string DonGiaBH
        {
            get
            {
                CanReadProperty("DonGiaBH", true);
                if (_donGiaBH == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGiaBH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonGiaBH", true);

                if (_donGiaBH.ToString() != value)
                {
                    _donGiaBH = decimal.Parse(value);
                    PropertyHasChanged("DonGiaBH");
                }
            }
        }

        public Decimal DonGiaThuT
        {
            get
            {
                CanReadProperty("DonGiaThuT", true);
                return _donGiaThuT;
            }
            set
            {
                CanWriteProperty("DonGiaThuT", true);
                if (_donGiaThuT != value)
                {
                    _donGiaThuT = value;
                    PropertyHasChanged("DonGiaThuT");
                }
            }
        }

        public Decimal DonGiaPhauT
        {
            get
            {
                CanReadProperty("DonGiaPhauT", true);
                return _donGiaPhauT;
            }
            set
            {
                CanWriteProperty("DonGiaPhauT", true);
                if (_donGiaPhauT != value)
                {
                    _donGiaPhauT = value;
                    PropertyHasChanged("DonGiaPhauT");
                }
            }
        }

        public Decimal DonGiaCLS
        {
            get
            {
                CanReadProperty("DonGiaCLS", true);
                return _donGiaCLS;
            }
            set
            {
                CanWriteProperty("DonGiaCLS", true);
                if (_donGiaCLS != value)
                {
                    _donGiaCLS = value;
                    PropertyHasChanged("DonGiaCLS");
                }
            }
        }

        //public Decimal GiaChenhLech
        //{
        //    get
        //    {
        //        CanReadProperty("GiaChenhLech", true);
        //        return _giachenhlech;
        //    }
        //    set
        //    {
        //        CanWriteProperty("GiaChenhLech", true);
        //        if (_giachenhlech != value)
        //        {
        //            _giachenhlech = value;
        //            PropertyHasChanged("GiaChenhLech");
        //        }
        //    }
        //}
        public string GiaChenhLech
        {
            get
            {
                CanReadProperty("GiaChenhLech", true);
                if (_giachenhlech == 0)
                {
                    return "0";
                }
                else
                {
                    return _giachenhlech.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhLech", true);

                if (_giachenhlech.ToString() != value)
                {
                    _giachenhlech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhLech");
                }
            }
        }

        public Boolean ADChenhLech
        {
            get
            {
                CanReadProperty("ADChenhLech", true);
                return _aDChenhlech;
            }
            set
            {
                CanWriteProperty("ADChenhLech", true);
                if (_aDChenhlech != value)
                {
                    _aDChenhlech = value;
                    PropertyHasChanged("ADChenhLech");
                }
            }
        }

        public Boolean DTBH
        {
            get
            {
                CanReadProperty("DTBH", true);
                return _DTBH;
            }
            set
            {
                CanWriteProperty("DTBH", true);
                if (_DTBH != value)
                {
                    _DTBH = value;
                    PropertyHasChanged("DTBH");
                }
            }
        }

        public Byte ADPhongmo
        {
            get
            {
                CanReadProperty("ADPhongmo", true);
                return _aDPhongMo;
            }
            set
            {
                CanWriteProperty("ADPhongmo", true);
                if (_aDPhongMo != value)
                {
                    _aDPhongMo = value;
                    PropertyHasChanged("ADPhongmo");
                }
            }
        }

        public Decimal DonGia1
        {
            get
            {
                CanReadProperty("DonGia1", true);
                return _donGia1;
            }
            set
            {
                CanWriteProperty("DonGia1", true);
                if (_donGia1 != value)
                {
                    _donGia1 = value;
                    PropertyHasChanged("DonGia1");
                }
            }
        }

        public Decimal GiaChenhLech1
        {
            get
            {
                CanReadProperty("GiaChenhLech1", true);
                return _giachenhlech1;
            }
            set
            {
                CanWriteProperty("GiaChenhLech1", true);
                if (_giachenhlech1 != value)
                {
                    _giachenhlech1 = value;
                    PropertyHasChanged("GiaChenhLech1");
                }
            }
        }


        public DateTime Ngay1
        {
            get
            {
                return _ngay1;
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


        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayLap;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap != value)
                {
                    _ngayLap = value;
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

        public SmartDate NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayHuy;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy != value)
                {
                    _ngayHuy = value;
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

        public SmartDate NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                _ngaySD1.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD1;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1 != value)
                {
                    _ngaySD1 = value;
                    PropertyHasChanged("NgaySD1");
                }
            }
        }

        public String NguoiSD1
        {
            get
            {
                CanReadProperty("NguoiSD1", true);
                return _nguoiSD1;
            }
            set
            {
                CanWriteProperty("NguoiSD1", true);
                if (_nguoiSD1 != value)
                {
                    _nguoiSD1 = value;
                    PropertyHasChanged("NguoiSD1");
                }
            }
        }

        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
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

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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
            return _maDT.ToString() + "!" + _maVT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMCNK_Gia" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMCNK_Gia NewDMCNK_Gia()
        {
            return new DMCNK_Gia();
        }
        //public static DMCNK_Gia GetDMCNK_Gia(String maDT, String maVT)
        //{
        //    return DataPortal.Fetch<DMCNK_Gia>(new Criteria(maDT, maVT));
        //}
        internal static DMCNK_Gia GetDMCNK_Gia(SafeDataReader dr)
        {
            return new DMCNK_Gia(dr);
        }
        public DMCNK_Gia()
        {
            MarkAsChild();
        }
        /// <summary>
        /// Marks the <see cref="DMCNK_Gia" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteDMCNK_Gia(String maDT, Decimal  sTT)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDT, sTT));
        //}

        #endregion

        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal DMCNK_Gia()
        //{	
        //    // Prevent direct creation
        //}
        //internal DMCNK_Gia( int ordernumber, 
        //                     String maDT,
        //                     Decimal STT,
        //                     String maVT ,
        //                     String tenThuoc,
        //                     Decimal donGiaBH ,
        //                     Decimal donGiaThuT ,
        //                     Decimal donGiaPhauT ,
        //                     Decimal donGiaCLS ,
        //                     Decimal giachenhlech ,
        //                     Boolean aDChenhlech ,
        //                     Boolean DTBH ,
        //                     Boolean aDPhongMo,
        //                     Decimal donGia1 ,
        //                     Decimal giachenhlech1 ,
        //                     SmartDate ngay1 ,
        //                     String ghichu ,
        //                     String maMay ,
        //                     Boolean huy ,
        //                     SmartDate ngayLap ,
        //                     String nguoiLap ,
        //                     SmartDate ngayHuy ,
        //                     String nguoiHuy,
        //                     SmartDate ngaySD1 ,
        //                     String nguoiSD1 ,
        //                     SmartDate ngaySD ,
        //                     String nguoiSD )
        //                {
        //                   _OrderNumber = ordernumber;
        //                    _maDT  = maDT;
        //                    _STT  =  STT ;  
        //                    _maVT  = maVT ;
        //                    _tenThuoc = tenThuoc ;
        //                    _donGiaBH  = donGiaBH ;
        //                    _donGiaThuT  = donGiaThuT ;
        //                    _donGiaPhauT  = donGiaPhauT ;
        //                    _donGiaCLS = donGiaCLS ;
        //                     _giachenhlech = giachenhlech; 
        //                     _aDChenhlech = aDChenhlech ;
        //                     _DTBH = DTBH ;
        //                     _aDPhongMo = aDPhongMo;
        //                     _donGia1 = donGia1 ;
        //                     _giachenhlech1 = giachenhlech1 ;
        //                     _ngay1 = ngay1 ;
        //                     _ghichu = ghichu ;
        //                     _maMay = maMay ;
        //                     _huy = huy ;
        //                     _ngayLap = ngayLap ;
        //                     _nguoiLap = nguoiLap ;
        //                     _ngayHuy = ngayHuy ;
        //                     _nguoiHuy = nguoiHuy;
        //                     _ngaySD1 = ngaySD1 ;
        //                     _nguoiSD1 = nguoiSD1 ;
        //                    _ngaySD = ngaySD ;
        //                    _nguoiSD  = nguoiSD; 
        //                }
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

            private String _maVT;
            public String maVT
            {
                get
                {
                    return _maVT;
                }
            }

            public Criteria(String maDT, String maVT)
            {
                _maDT = maDT;
                _maVT = maVT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maDT.Equals(c._maDT))
                        return false;
                    if (!_maVT.Equals(c._maVT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maDT.ToString(), _maVT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
                }
            }

            private Decimal _STT;
            public Decimal STT
            {
                get
                {
                    return _STT;
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
                _STT = sTT;
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
        /// Retrieve an existing <see cref="DMCNK_Gia" /> Object based on data in the database.
        /// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetDMCNK_Gia(String _maDT, String _maVT);
        //    // public override IDataReader GetDMCNK_Gia(String _maDT, String _maVT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maVT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMCNK_Gia(crit.MaDT, crit.maVT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="DMCNK_Gia" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        //    if (dr.GetDecimal("STT") != null) _STT = dr.GetDecimal("STT");
        //    if (dr.GetString("maVT") != null) _maVT = dr.GetString("maVT");
        //    if (dr.GetString("TenThuoc") != null) _tenThuoc = dr.GetString("TenThuoc");
        //    if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
        //    if (dr.GetDecimal("DonGiaThuT") != null) _donGiaThuT = dr.GetDecimal("DonGiaThuT");
        //    if (dr.GetDecimal("DonGiaPhauT") != null) _donGiaPhauT = dr.GetDecimal("DonGiaPhauT");
        //    if (dr.GetDecimal("DonGiaCLS") != null) _donGiaCLS = dr.GetDecimal("DonGiaCLS");
        //    if (dr.GetDecimal("GiaChenhLech") != null) _giachenhlech = dr.GetDecimal("GiaChenhLech");
        //    if (dr.GetBoolean("ADChenhLech") != null) _aDChenhlech = dr.GetBoolean("ADChenhLech");
        //    if (dr.GetBoolean("DTBH") != null) _DTBH = dr.GetBoolean("DTBH");
        //    if (dr.GetBoolean("ADPhongMo") != null) _aDPhongMo = dr.GetBoolean("ADPhongMo");
        //    if (dr.GetDecimal("DonGia1") != null) _donGia1 = dr.GetDecimal("DonGia1");
        //    if (dr.GetDecimal("GiachenhLech1") != null) _giachenhlech1 = dr.GetDecimal("GiachenhLech1");
        //    if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayLap", false) != null) _ngayLap = dr.GetSmartDate("NgayLap", false);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", false) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", false);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD1", false) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", false);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
        private DMCNK_Gia(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetDecimal("STT") != null) _STT = dr.GetDecimal("STT");
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("DonGia") != null) _donGiaBH = dr.GetDecimal("DonGia");
            if (dr.GetDecimal("DonGiaThuT") != null) _donGiaThuT = dr.GetDecimal("DonGiaThuT");
            if (dr.GetDecimal("DonGiaPhauT") != null) _donGiaPhauT = dr.GetDecimal("DonGiaPhauT");
            if (dr.GetDecimal("DonGiaCLS") != null) _donGiaCLS = dr.GetDecimal("DonGiaCLS");
            if (dr.GetDecimal("GiaChenhLenh") != null) _giachenhlech = dr.GetDecimal("GiaChenhLenh");
            if (dr.GetBoolean("ADChenhLech") != null) _aDChenhlech = dr.GetBoolean("ADChenhLech");
            if (dr.GetBoolean("DTBH") != null) _DTBH = dr.GetBoolean("DTBH");
            if (dr.GetByte("ADPhongMo") != null) _aDPhongMo = dr.GetByte("ADPhongMo");
            if (dr.GetDecimal("DonGia1") != null) _donGia1 = dr.GetDecimal("DonGia1");
            if (dr.GetDecimal("GiachenhLenh1") != null) _giachenhlech1 = dr.GetDecimal("GiachenhLenh1");
            //if (dr.GetDateTime("Ngay1", true) != null) _ngay1 = dr.GetDateTime("Ngay1", true);
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap", false) != null) _ngayLap = dr.GetSmartDate("NgayLap", false);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", false) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", false);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", false) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", false);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="DMCNK_Gia" /> Object to underlying database.
        /// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMCNK_Gia
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            //_maDT = 
                DataProvider.Instance().InsertDMCNK_Gia(_maDT, _maVT, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giachenhlech, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giachenhlech1, _ngay1, _ghichu, _maMay, _nguoiLap);
            // public abstract String InsertDMCNK_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertDMCNK_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maVT, _donGiaBH, _donGiaBH1, _ngayBH1.DBValue, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="DMCNK_Gia" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateDMCNK_Gia(_maDT, _STT, _maVT, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giachenhlech, _aDChenhlech, _DTBH, _aDPhongMo, _ghichu, _maMay, _nguoiSD, _huy);
            // public abstract void UpdateDMCNK_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override void UpdateDMCNK_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaBH1, SmartDate _ngayBH1, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maVT, _donGiaBH, _donGiaBH1, _ngayBH1.DBValue, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
            // }				
            MarkOld();
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maDT, _STT));
            MarkNew();
        }
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCNK_Gia
            DataProvider.Instance().DeleteDMCNK_Gia(crit.MaMay, crit.NguoiSD, crit.MaDT, crit.STT);
            // public abstract void DeleteDMCNK_Gia(String _maDT, String _maVT);
            // public override void DeleteDMCNK_Gia(String _maDT, String _maVT);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _maVT);
            // }
        }

        #endregion
    }

}
