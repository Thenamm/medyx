using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.Duoc;
using HTC.Business;
//

namespace HTC.Business.Duoc
{
    [Serializable()]
    public partial class PhieuXuatDT : BusinessBase<PhieuXuatDT>
    {
        #region Business Method
        #region State Fields
        private String _maPX = String.Empty;
        private String _noiXuat = String.Empty;
        private SmartDate _ngayXuat = new SmartDate(false);
        private SmartDate _ngayXuatTT = new SmartDate(false);
        private SmartDate _ngayXuatD = new SmartDate(false);
        private SmartDate _ngayXuatTTD = new SmartDate(false);
        private String _noiNhap = String.Empty;
        private String _MaDT = String.Empty;
        private String _TenDT = String.Empty;
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
        private Boolean _daPhat=false;
        private Boolean _khoaYC=false;
        private String _maMay = String.Empty;
        private String _tenNoiXuat=String.Empty;
        private String _tenNoiNhap=String.Empty;
        private String _tenNVXuat=String.Empty;        
        private String _tenNguoiLap=String.Empty;
        private String _tenNguoiSD=String.Empty;
        private String _tenNguoiHuy=String.Empty;
        private String _tenNguoiNhan = String.Empty;
        private Boolean _daDuyet = false;
        //private Boolean _baoHiem = false;
        //private Boolean _nhanDan = false;
        private int _OrderNumber;
        private Boolean _Khongsua = false;
        private Decimal  _SLThang =0 ;
        private Decimal _SLDon = 0;
        private Decimal _tongCP = 0;

        #endregion

        #region Business Properties and Method

        public Boolean Khongsua
        {
            get
            {
                CanReadProperty("Khongsua", true);
                return _Khongsua;
            }
            set
            {
                CanWriteProperty("Khongsua", true);
                if (_Khongsua != value)
                {
                    _Khongsua = value;
                    PropertyHasChanged("Khongsua");
                }
            }
        }
        public String MaPX
        {
            get
            {
                CanReadProperty("MaPX", true);
                return _maPX;
            }
            set
            {
                CanWriteProperty("MaPX", true);
                if (_maPX != value)
                {
                    _maPX = value;
                    PropertyHasChanged("MaPX");
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
        public String NgayXuat
        {
            get
            {
                CanReadProperty("NgayXuat", true);
               // _ngayXuat.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayXuat.Text;
            }
            set
            {
                CanWriteProperty("NgayXuat", true);
                if (_ngayXuat != value)
                {
                    _ngayXuat.Text = value;
                    PropertyHasChanged("NgayXuat");
                }
            }
        }
        public String NgayXuatTT
        {
            get
            {
                CanReadProperty("NgayXuatTT", true);
               // _ngayXuatTT.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayXuatTT.Text;
            }
            set
            {
                CanWriteProperty("NgayXuatTT", true);
                if (_ngayXuatTT != value)
                {
                    _ngayXuatTT.Text = value;
                    PropertyHasChanged("NgayXuatTT");
                }
            }
        }
        public String NgayXuatD
        {
            get
            {
                CanReadProperty("NgayXuatD", true);
                _ngayXuatD = _ngayXuat; 
                 _ngayXuatD.FormatString = "dd/MM/yyyy";
                return _ngayXuatD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayXuat", true);
            //    if (_ngayXuat != value)
            //    {
            //        _ngayXuat.Text = value;
            //        PropertyHasChanged("NgayXuat");
            //    }
            //}
        }
        public String NgayXuatTTD
        {
            get
            {
                CanReadProperty("NgayXuatTTD", true);
                _ngayXuatTTD = _ngayXuatTT; 
                 _ngayXuatTTD.FormatString = "dd/MM/yyyy";
                return _ngayXuatTTD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayXuatTTD", true);
            //    if (_ngayXuatTTD != value)
            //    {
            //        _ngayXuatTTD.Text = value;
            //        PropertyHasChanged("NgayXuatTTD");
            //    }
            //}
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
     
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _MaDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_MaDT != value)
                {
                    _MaDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }
        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _TenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_TenDT != value)
                {
                    _TenDT = value;
                    PropertyHasChanged("TenDT");
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
        public Decimal SLThang
        {
            get
            {
                CanReadProperty("SLThang", true);
                return _SLThang;
            }
            set
            {
                CanWriteProperty("SLThang", true);
                if (_SLThang != value)
                {
                    _SLThang = value;
                    PropertyHasChanged("SLThang");
                }
            }
        }
        public Decimal SLDon
        {
            get
            {
                CanReadProperty("SLDon", true);
                return _SLDon;
            }
            set
            {
                CanWriteProperty("SLDon", true);
                if (_SLDon != value)
                {
                    _SLDon = value;
                    PropertyHasChanged("SLDon");
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
        public Decimal tongCP
        {
            get
            {
                CanReadProperty("tongCP", true);
                return _tongCP;
            }
            set
            {
                CanWriteProperty("tongCP", true);
                if (_tongCP != value)
                {
                    _tongCP = value;
                    PropertyHasChanged("tongCP");
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
      
        PhieuXuat_Cs _PhieuXuatCs = PhieuXuat_Cs.NewPhieuXuat_Cs();
        public PhieuXuat_Cs PhieuXuatCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _PhieuXuatCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_PhieuXuatCs.Equals(value))
                {
                    _PhieuXuatCs = value;
                    PropertyHasChanged();
                }
            }
        }


        protected override object GetIdValue()
        {
            return _maPX;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _PhieuXuatCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _PhieuXuatCs.IsValid;
            }
        }

        
        

        #endregion
        #endregion

        #region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //    ValidationRules.AddRule<PhieuXuatDT>(StringRequiredNoiXuat<PhieuXuatDT>, "NoiXuat");
        //    ValidationRules.AddRule<PhieuXuatDT>(StringRequiredNhanVien<PhieuXuatDT>, "NVXuat");
        //    //  ValidationRules.AddRule<PhieuXuatDT>(ValidationDateTT<PhieuXuatDT>, "NgayXuatTT");
           
        //}
        //private static bool StringRequiredNoiXuat<T>(T target, Csla.Validation.RuleArgs e) where T : PhieuXuatDT
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
        //private static bool StringRequiredNhanVien<T>(T target, Csla.Validation.RuleArgs e) where T : PhieuXuatDT
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
        public static PhieuXuatDT NewPhieuXuat()
        { 
            return DataPortal.Create<PhieuXuatDT>();
        }

        public static PhieuXuatDT GetPhieuXuat(String maPX,byte loaiphieu, Boolean daphat,Boolean qadmin)
        {
            return DataPortal.Fetch<PhieuXuatDT>(new Criteria(maPX,loaiphieu,daphat,qadmin));
        }

        public static PhieuXuatDT GetPhieuXuat(SafeDataReader dr)
        {
            PhieuXuatDT obj = new PhieuXuatDT();
            obj.Fetch(dr);
            return obj;
            
        }

        public static void DeletePhieuXuat_C(String maPX,string mamay,string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(maPX, mamay, nguoihuy));
        }

        #endregion

        #region Constructors

        protected internal PhieuXuatDT()
        { 
            //
            _ngayXuat.Date = DateTime.Now;  
        }
        internal PhieuXuatDT( int OrderNumber,
                            String maPx,
                            String noiXuat,
                            SmartDate ngayXuat,
                            SmartDate ngayXuatTT,
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
                            Boolean daDuyet ,  
                            String MaDT,
                            String TenDT,
                            Boolean Khongsua,
                            Decimal   SLthang,Decimal SLDon,
                            Decimal tongCP

                           )
        {
            _OrderNumber = OrderNumber;
            _maPX = maPx;
            _noiXuat = noiXuat;
            _ngayXuat = ngayXuat;
            _ngayXuatTT = ngayXuatTT;
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
            _MaDT = MaDT;
            _TenDT = TenDT;
            _Khongsua = Khongsua;
            _SLThang = SLThang;
            _SLDon = SLDon;
            _tongCP = tongCP;
        }
        #endregion

        #region Criteria
        [Serializable()]
        protected class Criteria
        {
            private String _maPX;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
            public String MaPX
            {
                get
                {
                    return _maPX;
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
            public Criteria(String maPX, Byte loaiphieu, Boolean daphat, Boolean qdamin)
            {
                _maPX = maPX;
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
                    if(!_maPX.Equals(c._maPX))
                        return false;
                    return true;
                }
                return false;
            }
            
            public override int GetHashCode()
            {
                return string.Concat("Criteria",_maPX.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPX;
            public String MaPX
            {
                get
                {
                    return _maPX;
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
            public OtherCriteria( String maPX,String Mamay, String Nguoisd)
            {
                _maPX = maPX;
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
            _maPX = dr.GetString("MaPX");
            _noiXuat = dr.GetString("NoiXuat");
            _ngayXuat = dr.GetSmartDate("NgayXuat");
            _ngayXuatTT = dr.GetSmartDate("NgayXuatTT");
            _noiNhap = dr.GetString("NoiNhap");
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
            _daPhat = dr.GetBoolean("DaPhat");
            _khoaYC = dr.GetBoolean("KhoaYC");
            _maMay=dr.GetString("MaMay");
            _tenNoiXuat = dr.GetString("TenNoiXuat");
            _tenNoiNhap = dr.GetString("TenNoiNhap");
            _tenNVXuat = dr.GetString("TenNVXuat");        
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            _tenNguoiNhan = dr.GetString("TenNguoiNhan");
            _daDuyet = dr.GetBoolean("DaDuyet");
            _MaDT = dr.GetString("MaDT");
            _TenDT = dr.GetString("TenDT");
            _Khongsua = dr.GetBoolean("Khongsua");
            _SLThang = dr.GetDecimal("SLThang");
            _tongCP = dr.GetDecimal("TongCP");

        }
        protected void DataPortal_Fetch(Criteria crit)
        { 
            using (SafeDataReader dr=new SafeDataReader(DataProvider.Instance().GetPhieuXuat(crit.MaPX,crit.qadmin,crit.LoaiPhieu,crit.daphat    )))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _PhieuXuatCs = PhieuXuat_Cs.GetPhieuXuat_Cs(dr);  
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
            
            
            _maPX = DataProvider.Instance().InsertPhieuXuat(_noiXuat, _ngayXuat, _ngayXuatTT, _noiNhap, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _nguoiLap, _khoaYC, _maMay, _daPhat, _daDuyet, _MaDT, _Khongsua,_SLThang,_SLDon  );
            MarkOld();
            _PhieuXuatCs.Update(this);
            
        }
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
            
            
            DataProvider.Instance().UpdatePhieuXuat(_maPX, _noiXuat, _ngayXuat, _ngayXuatTT, _noiNhap, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _maMay, _nguoiSD , _daPhat, _daDuyet, "", _MaDT, _SLThang);
            
            _PhieuXuatCs.Update(this);
            }
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maPX, _maMay, _nguoiSD ));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeletePhieuXuat(crit.MaPX, crit.MaMay, crit.NguoiSD);

        }

        #endregion

        
    }
}
