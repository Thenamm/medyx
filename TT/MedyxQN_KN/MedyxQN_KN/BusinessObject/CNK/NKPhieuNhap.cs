using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.CNK;
using HTC.Business;

namespace HTC.Business.CNK
{
    [Serializable()]
    public partial class NKPhieuNhap : BusinessBase<NKPhieuNhap>
    {
        #region Business Method
        #region State Fields
        private String _maPN = String.Empty;
        private String _noiXuat = String.Empty;
        private SmartDate _ngayNhap = new SmartDate(false);
        private SmartDate _ngayNhapTT = new SmartDate(false);
        private SmartDate _ngayNhapD = new SmartDate(false);
        private SmartDate _ngayNhapTTD = new SmartDate(false);
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
        private SmartDate _ngaySD1 = new SmartDate(false);
        private String _nguoiSD1 = String.Empty;
        private Boolean _daPhat = false;
        private Boolean _khoaYC = false;
        private String _maMay = String.Empty;
        private String _tenNoiXuat = String.Empty;
        private String _tenNoiNhap = String.Empty;
        private String _tenNVXuat = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiNhan = String.Empty;
        private Boolean _daDuyet = false;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Method

        public String NgayNhapD
        {
            get
            {
                CanReadProperty("NgayNhapD", true);
                _ngayNhapD = _ngayNhap;
                _ngayNhapD.FormatString = "dd/MM/yyyy";
                return _ngayNhapD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayNhap", true);
            //    if (_ngayNhap != value)
            //    {
            //        _ngayNhap.Text = value;
            //        PropertyHasChanged("NgayNhap");
            //    }
            //}
        }
        public String NgayNhapTTD
        {
            get
            {
                CanReadProperty("NgayNhapTTD", true);
                _ngayNhapTTD = _ngayNhapTT;
                _ngayNhapTTD.FormatString = "dd/MM/yyyy";
                return _ngayNhapTTD.Text;
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
        public String MaPN
        {
            get
            {
                CanReadProperty("MaPN", true);
                return _maPN;
            }
            set
            {
                CanWriteProperty("MaPN", true);
                if (_maPN != value)
                {
                    _maPN = value;
                    PropertyHasChanged("MaPN");
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
                // _ngayNhap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayNhap.Text;
            }
            set
            {
                CanWriteProperty("NgayNhap", true);
                if (_ngayNhap != value)
                {
                    _ngayNhap.Text = value;
                    PropertyHasChanged("NgayNhap");
                }
            }
        }
        public String NgayNhapTT
        {
            get
            {
                CanReadProperty("NgayNhapTT", true);
                // _ngayNhapTT.FormatString = "dd/MM/yyyy HH:mm:ss";
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
        public String NoiNhap
        {
            get
            {
                CanReadProperty("NoiNhap", true);
                return _noiNhap;
            }
            set
            {
                CanWriteProperty("NoiNhap", true);
                if (_noiNhap != value)
                {
                    _noiNhap = value;
                    PropertyHasChanged("NoiNhap");
                }
            }
        }
        public Byte LoaiPhieu
        {
            get
            {
                CanReadProperty("LoaiPhieu", true);
                return _loaiPhieu;
            }
            set
            {
                CanWriteProperty("LoaiPhieu", true);
                if (_loaiPhieu != value)
                {
                    _loaiPhieu = value;
                    PropertyHasChanged("LoaiPhieu");
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
        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _ghiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_ghiChu != value)
                {
                    _ghiChu = value;
                    PropertyHasChanged("GhiChu");
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
        public Boolean DaPhat
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
        public Boolean KhoaYC
        {
            get
            {
                CanReadProperty("KhoaYC", true);
                return _khoaYC;
            }
            set
            {
                CanWriteProperty("KhoaYC", true);
                if (_khoaYC != value)
                {
                    _khoaYC = value;
                    PropertyHasChanged("KhoaYC");
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

        NKPhieuNhap_Cs _NKPhieuNhapCs = NKPhieuNhap_Cs.NewNKPhieuNhap_Cs();
        public NKPhieuNhap_Cs NKPhieuNhapCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _NKPhieuNhapCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_NKPhieuNhapCs.Equals(value))
                {
                    _NKPhieuNhapCs = value;
                    PropertyHasChanged();
                }
            }
        }


        protected override object GetIdValue()
        {
            return _maPN;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _NKPhieuNhapCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _NKPhieuNhapCs.IsValid;
            }
        }




        #endregion
        #endregion

        #region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //    ValidationRules.AddRule<NKPhieuNhap>(StringRequiredNoiXuat<NKPhieuNhap>, "NoiXuat");
        //    ValidationRules.AddRule<NKPhieuNhap>(StringRequiredNhanVien<NKPhieuNhap>, "NVXuat");
        //    //  ValidationRules.AddRule<NKPhieuNhap>(ValidationDateTT<NKPhieuNhap>, "NgayNhapTT");

        //}
        //private static bool StringRequiredNoiXuat<T>(T target, Csla.Validation.RuleArgs e) where T : NKPhieuNhap
        //{
        //    if (target._noiXuat == "")
        //    {
        //        e.Description = "Phiếu xuất phải có nơi xuất";
        //        return false;
        //    }
        //    if (target._noiNhap == target._noiXuat)
        //    {
        //        e.Description = "Nơi nhập phải khác nơi xuất";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool StringRequiredNhanVien<T>(T target, Csla.Validation.RuleArgs e) where T : NKPhieuNhap
        //{
        //    if (target._nvXuat == target._nvNhan)
        //    {
        //        e.Description = "Nhân viên xuất phải khác nhân viên nhập";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        #endregion

        #region Factory Methods
        public static NKPhieuNhap NewNKPhieuNhap()
        {
            return DataPortal.Create<NKPhieuNhap>();
        }

        public static NKPhieuNhap GetNKPhieuNhap(String maPN,  byte loaiphieu, Boolean daphat,Boolean qadmin)
        {
            return DataPortal.Fetch<NKPhieuNhap>(new Criteria(maPN,  loaiphieu,  daphat, qadmin));
        }

        public static NKPhieuNhap GetNKPhieuNhap(SafeDataReader dr)
        {
            NKPhieuNhap obj = new NKPhieuNhap();
            obj.Fetch(dr);
            return obj;

        }

        public static void DeleteNKPhieuNhap_C(String maPN, string nguoisd, string mamay)
        {
            DataPortal.Delete(new OtherCriteria(maPN, mamay, nguoisd));
        }

        #endregion

        #region Constructors

        protected internal NKPhieuNhap()
        {
            //
            _ngayNhap.Date = DateTime.Now;
          
        }
        internal NKPhieuNhap(int OrderNumber,
                            String maPN,
                            String noiXuat,
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
                            Boolean daPhat,
                            Boolean khoaYC,
                            String maMay,
                            String tenNoiXuat,
                            String tenNoiNhap,
                            String tenNVXuat,
                            String tenNguoiLap,
                            String tenNguoiSD,
                            String tenNguoiHuy,
                            String tenNguoiNhan,
                            Boolean daDuyet

                           )
        {
            _OrderNumber = OrderNumber;
            _maPN = maPN;
            _noiXuat = noiXuat;
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
            _khoaYC = khoaYC;
            _maMay = maMay;
            _tenNoiXuat = tenNoiXuat;
            _tenNoiNhap = tenNoiNhap;
            _tenNVXuat = tenNVXuat;
            _tenNguoiLap = tenNguoiLap;
            _tenNguoiSD = tenNguoiSD;
            _tenNguoiHuy = tenNguoiHuy;
            _tenNguoiNhan = tenNguoiNhan;
            _daDuyet = daDuyet;

        }
        #endregion

        #region Criteria
        [Serializable()]
        protected class Criteria
        {
            private String _maPN;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
            public String MaPN
            {
                get
                {
                    return _maPN;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Boolean daphat
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
            public Criteria(String maPN,  byte loaiphieu, Boolean daphat,Boolean qadmin)
            {
                _maPN = maPN;
                _daPhat = daphat;
                _loaiPhieu = loaiphieu;
                _qadmin = qadmin;
            }
             private Boolean _qadmin = false ;

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maPN.Equals(c._maPN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maPN.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPN;
            public String MaPN
            {
                get
                {
                    return _maPN;
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
            public OtherCriteria(String maPN, String Mamay, String Nguoisd)
            {
                _maPN = maPN;
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
            _maPN = dr.GetString("MaPN");
            _noiXuat = dr.GetString("NoiXuat");
            _ngayNhap = dr.GetSmartDate("NgayNhap");
            _ngayNhapTT = dr.GetSmartDate("NgayNhapTT");
            _noiNhap = dr.GetString("NoiNhap");
            _loaiPhieu = dr.GetByte("LoaiPhieu");
            _soCT = dr.GetString("SoCT");
            _nvXuat = dr.GetString("NVXuat");
            _nvNhan = dr.GetString("NVNhan");
            _ghiChu = dr.GetString("GhiChu");
            _huy = dr.GetBoolean("Huy");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _ngayLap = dr.GetSmartDate("NgayLap", false);
            _nguoiLap = dr.GetString("NguoiLap");
            _ngayHuy = dr.GetSmartDate("NgayHuy", false);
            _nguoiHuy = dr.GetString("NguoiHuy");
            _ngaySD1 = dr.GetSmartDate("NgaySD1", false);
            _nguoiSD1 = dr.GetString("NguoiSD1");
            _daPhat = dr.GetBoolean("DaPhat");
            _khoaYC = dr.GetBoolean("KhoaYC");
            _maMay = dr.GetString("MaMay");
            _tenNoiXuat = dr.GetString("TenNoiXuat");
            _tenNoiNhap = dr.GetString("TenNoiNhap");
            _tenNVXuat = dr.GetString("TenNVXuat");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            _tenNguoiNhan = dr.GetString("TenNguoiNhan");
            _daDuyet = dr.GetBoolean("DaDuyet");

        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNKPhieuNhap(crit.MaPN, crit.qadmin, crit.LoaiPhieu, crit.daphat)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _NKPhieuNhapCs = NKPhieuNhap_Cs.GetNKPhieuNhap_Cs(dr);
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
            
            
            _maPN = DataProvider.Instance().InsertNKPhieuNhap(_noiXuat, _ngayNhap, _ngayNhapTT, _noiNhap, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _nguoiLap, _khoaYC, _maMay, _daPhat, _daDuyet);

            _NKPhieuNhapCs.Update(this);

        }
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
                
                
                DataProvider.Instance().UpdateNKPhieuNhap(_maPN, _noiXuat, _ngayNhap, _ngayNhapTT, _noiNhap, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _maMay, _nguoiSD, _daPhat, _daDuyet);

                _NKPhieuNhapCs.Update(this);
            }
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maPN, _maMay, _nguoiSD));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteNKPhieuNhap(crit.MaPN, crit.MaMay, crit.NguoiSD);

        }

        #endregion


    }
}
