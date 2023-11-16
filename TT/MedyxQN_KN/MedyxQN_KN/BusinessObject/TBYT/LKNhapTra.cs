using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.TBYT;
using HTC.Business;
////

namespace HTC.Business.TBYT
{
    [Serializable()]
    public partial class LKNhapTra : BusinessBase<LKNhapTra>
    {

        #region Business Method
        #region State Fields
        private String _MaPNT = String.Empty;
        //private String _noiXuat = HTC.Business.CategoryList.DMKhoListcb.DefaultPosition();
        private String _noiXuat = String.Empty;
        //private SmartDate _ngayXuat = new SmartDate(false);
       // private SmartDate _ngayXuatTT = new SmartDate(false);
        private SmartDate _ngayNhap = new SmartDate(DateTime.Today);
        private SmartDate _ngayNhapD = new SmartDate(DateTime.Today);
        private SmartDate _ngayNhapTT = new SmartDate(false);
        private SmartDate _ngayNhapTTD = new SmartDate(false);
        //private String _noiNhap = HTC.Business.CategoryList.DMKhoListcb.DefaultPosition();
        private String _noiNhap = String.Empty;
        private Byte _loaiPhieu;
        private String _soCT = String.Empty;
        private String _nvXuat = String.Empty;
        private String _nvNhan = String.Empty;
        private String _ghiChu = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngayLap = new SmartDate(false);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(false);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1=new SmartDate(false); 
        private String _nguoiSD1 = String.Empty;
        private Byte _daPhat;
        private Boolean _BNTra=false;
        private String _maMay = String.Empty;
        private String _tenNoiXuat=String.Empty;
        private String _tenNoiNhap = String.Empty;
        private String _tenNVXuat=String.Empty;        
        private String _tenNguoiLap=String.Empty;
        private String _tenNguoiSD=String.Empty;
        private String _tenNguoiHuy=String.Empty;
        private String _tenNguoiNhan = String.Empty;
        private Boolean _daDuyet = false;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Method
        public Boolean DaDuyet
        {
            get
            {
                CanReadProperty("DaDuyet", true);
                return _daDuyet;
            }
            set
            {
                CanWriteProperty("DaDuyet", true);
                if (_daDuyet != value)
                {
                    _daDuyet = value;
                    PropertyHasChanged("DaDuyet");
                }
            }
        }
        
        public String MaPNT
        {
            get
            {
                CanReadProperty("MaPNT", true);
                return _MaPNT;
            }
            set
            {
                CanWriteProperty("MaPNT", true);
                if (_MaPNT != value)
                {
                    _MaPNT = value;
                    PropertyHasChanged("MaPNT");
                }
            }
        }
        public String NoiXuat
        {
            get
            {
                CanReadProperty("NoiXuat", true);
                return _noiXuat;
            }
            set
            {
                CanWriteProperty("NoiXuat", true);
                if (_noiXuat != value)
                {
                    _noiXuat = value;
                    PropertyHasChanged("NoiXuat");
                }
            }
        }
        public String NgayNhap
        {
            get
            {
                CanReadProperty("NgayNhap", true);
                //_ngayNhap.FormatString = "dd/MM/yyyy";
                return _ngayNhap.Text;
            }
            set
            {
                CanWriteProperty("NgayNhap", true);
                if (!_ngayNhap.Equals(value))
                {
                    _ngayNhap.Text = value;
                    PropertyHasChanged("NgayNhap");
                }
            }
        }
        public String NgayNhapD
        {
            get
            {
                CanReadProperty("NgayNhapD", true);
                _ngayNhap.FormatString = "dd/MM/yyyy";
                return _ngayNhap.Text;
            }
            set
            {
                CanWriteProperty("NgayNhapD", true);
                if (!_ngayNhap.Equals(value))
                {
                    _ngayNhap.Text = value;
                    PropertyHasChanged("NgayNhapD");
                }
            }
        }
        //public SmartDate NgayNhap
        //{
        //    get
        //    {
        //        CanReadProperty("NgayNhap", true);
        //        _ngayNhap.FormatString = "dd/MM/yyyy HH:mm:ss";
        //        return _ngayNhap;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayNhap", true);
        //        if (!_ngayNhap.Equals(value))
        //        {
        //            _ngayNhap = value;
        //            PropertyHasChanged("NgayNhap");
        //        }
        //    }
        //}
        //public SmartDate NgayNhapTT
        //{
        //    get
        //    {
        //        CanReadProperty("NgayNhapTT", true);
        //        _ngayNhapTT.FormatString = "dd/MM/yyyy HH:mm:ss";
        //        return _ngayNhapTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayNhapTT", true);
        //        if (_ngayNhapTT != value)
        //        {
        //            _ngayNhapTT = value;
        //            PropertyHasChanged("NgayNhapTT");
        //        }
        //    }
        //}_ngayNhapTTD
        public String NgayNhapTT
        {
            get
            {
                CanReadProperty("NgayNhapTT", true);
                //_ngayNhapTT.FormatString = "dd/MM/yyyy ";
                return _ngayNhapTT.Text;
            }
            set
            {
                CanWriteProperty("NgayNhapTT", true);
                if (_ngayNhapTT != value)
                {
                    _ngayNhapTT.Text = value;
                    PropertyHasChanged("NgayNhapTT");
                }
            }
        }
        public String NgayNhapTTD
        {
            get
            {
                CanReadProperty("NgayNhapTTD", true);
                _ngayNhapTT.FormatString = "dd/MM/yyyy ";
                return _ngayNhapTT.Text;
            }
            set
            {
                CanWriteProperty("NgayNhapTTD", true);
                if (_ngayNhapTT != value)
                {
                    _ngayNhapTT.Text = value;
                    PropertyHasChanged("NgayNhapTTD");
                }
            }
        }
        public String Noinhap
        {
            get
            {
                CanReadProperty("Noinhap", true);
                return _noiNhap;
            }
            set
            {
                CanWriteProperty("Noinhap", true);
                if (_noiNhap != value)
                {
                    _noiNhap = value;
                    PropertyHasChanged("Noinhap");
                }
            }
        }
        public Byte Loaiphieu
        {
            get
            {
                CanReadProperty("Loaiphieu", true);
                return _loaiPhieu;
            }
            set
            {
                CanWriteProperty("Loaiphieu", true);
                if (_loaiPhieu != value)
                {
                    _loaiPhieu = value;
                    PropertyHasChanged("Loaiphieu");
                }
            }
        }
        public String SoCT
        {
            get
            {
                CanReadProperty("SoCT", true);
                return _soCT;
            }
            set
            {
                CanWriteProperty("SoCT", true);
                if (_soCT != value)
                {
                    _soCT = value;
                    PropertyHasChanged("SoCT");
                }
            }
        }
        public String NVXuat
        {
            get
            {
                CanReadProperty("NVXuat", true);
                return _nvXuat;
            }
            set
            {
                CanWriteProperty("NVXuat", true);
                if (_nvXuat != value)
                {
                    _nvXuat = value;
                    PropertyHasChanged("NVXuat");
                }
            }
        }
        public String NVNhan
        {
            get
            {
                CanReadProperty("NVNhan", true);
                return _nvNhan;
            }
            set
            {
                CanWriteProperty("NVNhan", true);
                if (_nvNhan != value)
                {
                    _nvNhan = value;
                    PropertyHasChanged("NVNhan");
                }
            }
        }
        public String ghichu
        {
            get
            {
                CanReadProperty("ghichu", true);
                return _ghiChu;
            }
            set
            {
                CanWriteProperty("ghichu", true);
                if (_ghiChu != value)
                {
                    _ghiChu = value;
                    PropertyHasChanged("ghichu");
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
        public Byte DaPhat
        {
            get
            {
                CanReadProperty("DaPhat", true);
                return _daPhat;
            }
            set
            {
                CanWriteProperty("DaPhat", true);
                if (_daPhat != value)
                {
                    _daPhat = value;
                    PropertyHasChanged("DaPhat");
                }
            }
        }
        public Boolean BNTra
        {
            get
            {
                CanReadProperty("BNTra", true);
                return _BNTra;
            }
            set
            {
                CanWriteProperty("BNTra", true);
                if (_BNTra != value)
                {
                    _BNTra = value;
                    PropertyHasChanged("BNTra");
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
        public String TenNoiXuat
        {
            get
            {
                CanReadProperty("TenNoiXuat", true);
                return _tenNoiXuat;
            }
            set
            {
                CanWriteProperty("TenNoiXuat", true);
                if (_tenNoiXuat != value)
                {
                    _tenNoiXuat = value;
                    PropertyHasChanged("TenNoiXuat");
                }
            }
        }
        public String TenNoiNhap
        {
            get
            {
                CanReadProperty("TenNoiNhap", true);
                return _tenNoiNhap;
            }
            set
            {
                CanWriteProperty("TenNoiNhap", true);
                if (_tenNoiNhap != value)
                {
                    _tenNoiNhap = value;
                    PropertyHasChanged("TenNoiNhap");
                }
            }
        }
        public String TenNVXuat
        {
            get
            {
                CanReadProperty("TenNVXuat", true);
                return _tenNVXuat;
            }
            set
            {
                CanWriteProperty("TenNVXuat", true);
                if (_tenNVXuat != value)
                {
                    _tenNVXuat = value;
                    PropertyHasChanged("TenNVXuat");
                }
            }
        }
        
        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }
        public String TenNguoiNhan
        {
            get
            {
                CanReadProperty("TenNguoiNhan", true);
                return _tenNguoiNhan;
            }
            set
            {
                CanWriteProperty("TenNguoiNhan", true);
                if (_tenNguoiNhan != value)
                {
                    _tenNguoiNhan = value;
                    PropertyHasChanged("TenNguoiNhan");
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        LKNhapTra_Cs _LKNhapTraCs = LKNhapTra_Cs.NewLKNhapTra_Cs();
        public LKNhapTra_Cs LKNhapTraCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _LKNhapTraCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_LKNhapTraCs.Equals(value))
                {
                    _LKNhapTraCs = value;
                    PropertyHasChanged();
                }
            }
        }


        protected override object GetIdValue()
        {
            return _MaPNT;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _LKNhapTraCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _LKNhapTraCs.IsValid;
            }
        }

        
        

        #endregion
        #endregion

        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("NoiXuat", 9));
            ValidationRules.AddRule<LKNhapTra>(StringRequired<LKNhapTra>, "NoiXuat");

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("Noinhap", 6));
            ValidationRules.AddRule<LKNhapTra>(StringRequiredNoiNhap<LKNhapTra>, "Noinhap");


        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : LKNhapTra
        {

            if (target._noiXuat == null || target._noiXuat.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredNoiNhap<T>(T target, Csla.Validation.RuleArgs e) where T : LKNhapTra
        {

            if (target._noiNhap == null || target._noiNhap.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Factory Methods
        public static LKNhapTra NewLKNhapTra()
        { 
            return DataPortal.Create<LKNhapTra>();
        }

        public static LKNhapTra GetLKNhapTra(String MaPNT,byte loaiphieu,byte daphat,Boolean qadmin)
        {
            return DataPortal.Fetch<LKNhapTra>(new Criteria(MaPNT,loaiphieu ,daphat,qadmin  ));
        }

        public static LKNhapTra GetLKNhapTra(SafeDataReader dr)
        {
            LKNhapTra obj = new LKNhapTra();
            obj.Fetch(dr);
            return obj;
            
        }

        public static void DeleteLKNhapTra(String MaPNT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaPNT));
        }

        #endregion

        #region Constructors

        protected internal LKNhapTra()
        { 
            //
        }
        internal LKNhapTra( int OrderNumber,
                            String MaPNT,
                            String noiXuat,
                            //SmartDate ngayXuat,
                            //SmartDate ngayXuatTT,
                            SmartDate ngayNhap,
                            SmartDate ngayNhapTT,
                            String noiNhap,
                            Byte loaiPhieu,
                            String soCT,
                            String nvXuat,
                            String nvNhan,
                            String ghiChu,
                            Boolean huy,
                            SmartDate ngaySD,
                            String nguoiSD,
                            SmartDate ngayLap,
                            String nguoiLap,
                            SmartDate ngayHuy,
                            String nguoiHuy,
                            SmartDate ngaySD1,
                            String nguoiSD1,
                            Byte daPhat,
                            Boolean BNTra,
                            String maMay,
                            String tenNoiXuat,
                            String tenNoiNhap,
                            String tenNVXuat,                            
                            String tenNguoiLap,
                            String tenNguoiSD,
                            String tenNguoiHuy,
                            String tenNguoiNhan,
                            Boolean daDUYET
                       
                           )
        {
            _OrderNumber = OrderNumber;
            _MaPNT = MaPNT;
            _noiXuat = noiXuat;
            _daDuyet = daDUYET;
            //_ngayXuat = ngayXuat;
            //_ngayXuatTT = ngayXuatTT;
            _ngayNhap = ngayNhap;
            _ngayNhapTT = ngayNhapTT;
            _noiNhap = noiNhap;
            _loaiPhieu = loaiPhieu;
            _soCT = soCT;
            _nvXuat = nvXuat;
            _nvNhan = nvNhan;
            _ghiChu = ghiChu;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngayLap = ngayLap;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _daPhat = daPhat;
            _BNTra = BNTra;
            _maMay = maMay;
            _tenNoiXuat = tenNoiXuat;
            _tenNoiNhap = tenNoiNhap;
            _tenNVXuat = tenNVXuat;
            _tenNguoiLap = tenNguoiLap;
            _tenNguoiSD = tenNguoiSD;
            _tenNguoiHuy = tenNguoiHuy;
            _tenNguoiNhan = tenNguoiNhan;
          
        }
        #endregion

        #region Criteria
        [Serializable()]
        protected class Criteria
        {
            private String _MaPNT;
            private Byte _loaiPhieu;
            private Byte _daPhat;
            public String MaPNT
            {
                get
                {
                    return _MaPNT;
                }
            }
            public Byte daphat
            {
                get
                {
                    return _daPhat;
                }
            }
            public Byte LoaiPhieu
            {
                get
                {
                    return _loaiPhieu;
                }
            }
           public Criteria(String MaPNT, Byte loaiphieu, Byte daphat,Boolean qadmin)
            {
                _MaPNT = MaPNT;
                _daPhat = daphat;
                _loaiPhieu = loaiphieu;
                _qadmin = qadmin;
            }
            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if(!_MaPNT.Equals(c._MaPNT))
                        return false;
                    return true;
                }
                return false;
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public override int GetHashCode()
            {
                return string.Concat("Criteria",_MaPNT.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPNT;
            public String MaPNT
            {
                get
                {
                    return _MaPNT;
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

            public OtherCriteria(String Mamay, String Nguoisd, String MaPNT)
            {
                _MaPNT = MaPNT;
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
        protected void Fetch(SafeDataReader dr)
        {
            _MaPNT = dr.GetString("MaPNT");
            _noiXuat = dr.GetString("NoiXuat");
            //_ngayXuat = dr.GetSmartDate("Ngayxuat");
            //_ngayXuatTT = dr.GetSmartDate("NgayXuatTT");
            _ngayNhap = dr.GetSmartDate("ngayNhap");
            _ngayNhapD = dr.GetSmartDate("ngayNhap");
            _ngayNhapTT = dr.GetSmartDate("ngayNhapTT");
            _ngayNhapTTD = dr.GetSmartDate("ngayNhapTT");
            _noiNhap = dr.GetString("NoiNhap");
            _daDuyet = dr.GetBoolean("DADUYET");
            _loaiPhieu=dr.GetByte("LoaiPhieu");
            _soCT=dr.GetString("SoCT");
            _nvXuat=dr.GetString("NVXuat");
            _nvNhan=dr.GetString("NVNhan");
            _ghiChu=dr.GetString("GhiChu");
            _huy=dr.GetBoolean("Huy");
            _ngaySD=dr.GetSmartDate("NgaySD",false);
            _nguoiSD=dr.GetString("NguoiSD");
            _ngayLap=dr.GetSmartDate("NgayLap",false);
            _nguoiLap=dr.GetString("NguoiLap");
            _ngayHuy=dr.GetSmartDate("NgayHuy",false);
            _nguoiHuy=dr.GetString("NguoiHuy");
            _ngaySD1 = dr.GetSmartDate("NgaySD1",false);
            _nguoiSD1 = dr.GetString("NguoiSD1");
            _daPhat = dr.GetByte("DaPhat");
            _BNTra = dr.GetBoolean("BNTra");
            _maMay=dr.GetString("MaMay");
            _tenNoiXuat = dr.GetString("TenNoiXuat");
            _tenNoiNhap = dr.GetString("TenNoiNhap");
            _tenNVXuat = dr.GetString("TenNVXuat");        
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            _tenNguoiNhan = dr.GetString("TenNguoiNhan"); 
            
        }
        protected void DataPortal_Fetch(Criteria crit)
        { 
            using (SafeDataReader dr=new SafeDataReader(DataProvider.Instance().GetLKNhapTra(crit.MaPNT,crit.qadmin,crit.LoaiPhieu,crit.daphat)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _LKNhapTraCs = LKNhapTra_Cs.GetLKNhapTra_Cs(dr);  
                    } 
                }
            }
        }
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            
            
            _MaPNT = DataProvider.Instance().InsertLKNhapTra(_noiNhap, _ngayNhap, _ngayNhapTT, _noiXuat, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _nguoiSD , _BNTra,_maMay, _daPhat);
            MarkOld();
            _LKNhapTraCs.Update(this);
            
        }
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
            
              
            DataProvider.Instance().UpdateLKNhapTra(_MaPNT, _noiXuat, _ngayNhap, _ngayNhapTT, _noiNhap, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _maMay, _nguoiSD , _daPhat, _BNTra, _daDuyet);
            
            _LKNhapTraCs.Update(this);
            }
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_MaPNT, _maMay, _nguoiSD ));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteLKNhapTra(crit.MaPNT, crit.MaMay, crit.NguoiSD);

        }

        #endregion

        
    }
}
