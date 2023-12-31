


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
    public partial class BC_ChuyenMonNgay : BusinessBase<BC_ChuyenMonNgay>
    {

        #region Business Methods

        #region State Fields

        private String _tenKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _maKhoa = String.Empty;

        private Decimal _CVNoiTru = 0;
        private Decimal _TuVong = 0;
        private Decimal _VaoVien = 0;
        private Decimal _RaVien = 0;
        private Decimal _ChuyenKhoa = 0;
        private Decimal _XinVe = 0;
        private Decimal _PhauThuat = 0;
       
        private Decimal _DTCu = 0;
        private Decimal _DTVao = 0;
        private Decimal _DTRa = 0;
        private Decimal _TSBenhAn = 0;
     
        private String _dacBiet = String.Empty;
     
        private Decimal _saiSotChuyenMon = 0;
        private Decimal _phanUngCoHai = 0;
       
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
       
        public Decimal SaiSotChuyenMon
        {
            get
            {
                CanReadProperty("SaiSotChuyenMon", true);
                return _saiSotChuyenMon;
            }
            set
            {
                CanWriteProperty("SaiSotChuyenMon", true);
                if (_saiSotChuyenMon != value)
                {
                    _saiSotChuyenMon = value;
                    PropertyHasChanged("SaiSotChuyenMon");
                }
            }
        }

        public Decimal PhanUngCoHai
        {
            get
            {
                CanReadProperty("PhanUngCoHai", true);
                return _phanUngCoHai;
            }
            set
            {
                CanWriteProperty("PhanUngCoHai", true);
                if (_phanUngCoHai != value)
                {
                    _phanUngCoHai = value;
                    PropertyHasChanged("PhanUngCoHai");
                }
            }
        }
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
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

        public Decimal CVNoiTru
        {
            get
            {
                CanReadProperty("CVNoiTru", true);
                return _CVNoiTru;
            }
            set
            {
                CanWriteProperty("CVNoiTru", true);
                if (_CVNoiTru != value)
                {
                    _CVNoiTru = value;
                    PropertyHasChanged("CVNoiTru");
                }
            }
        }
        public Decimal TuVong
        {
            get
            {
                CanReadProperty("TuVong", true);
                return _TuVong;
            }
            set
            {
                CanWriteProperty("TuVong", true);
                if (_TuVong != value)
                {
                    _TuVong = value;
                    PropertyHasChanged("TuVong");
                }
            }
        }
        public Decimal VaoVien
        {
            get
            {
                CanReadProperty("VaoVien", true);
                return _VaoVien;
            }
            set
            {
                CanWriteProperty("VaoVien", true);
                if (_VaoVien != value)
                {
                    _VaoVien = value;
                    PropertyHasChanged("VaoVien");
                }
            }
        }
        public Decimal RaVien
        {
            get
            {
                CanReadProperty("RaVien", true);
                return _RaVien;
            }
            set
            {
                CanWriteProperty("RaVien", true);
                if (_RaVien != value)
                {
                    _RaVien = value;
                    PropertyHasChanged("RaVien");
                }
            }
        }
        public Decimal ChuyenKhoa
        {
            get
            {
                CanReadProperty("ChuyenKhoa", true);
                return _ChuyenKhoa;
            }
            set
            {
                CanWriteProperty("ChuyenKhoa", true);
                if (_ChuyenKhoa != value)
                {
                    _ChuyenKhoa = value;
                    PropertyHasChanged("ChuyenKhoa");
                }
            }
        }
        public Decimal XinVe
        {
            get
            {
                CanReadProperty("XinVe", true);
                return _XinVe;
            }
            set
            {
                CanWriteProperty("XinVe", true);
                if (_XinVe != value)
                {
                    _XinVe = value;
                    PropertyHasChanged("XinVe");
                }
            }
        }
        public Decimal PhauThuat
        {
            get
            {
                CanReadProperty("PhauThuat", true);
                return _PhauThuat;
            }
            set
            {
                CanWriteProperty("PhauThuat", true);
                if (_PhauThuat != value)
                {
                    _PhauThuat = value;
                    PropertyHasChanged("PhauThuat");
                }
            }
        }
        
        public Decimal DTCu
        {
            get
            {
                CanReadProperty("DTCu", true);
                return _DTCu;
            }
            set
            {
                CanWriteProperty("DTCu", true);
                if (_DTCu != value)
                {
                    _DTCu = value;
                    PropertyHasChanged("DTCu");
                }
            }
        }

        public Decimal DTVao
        {
            get
            {
                CanReadProperty("DTVao", true);
                return _DTVao;
            }
            set
            {
                CanWriteProperty("DTVao", true);
                if (_DTVao != value)
                {
                    _DTVao = value;
                    PropertyHasChanged("DTVao");
                }
            }
        }

        public Decimal DTRa
        {
            get
            {
                CanReadProperty("DTRa", true);
                return _DTRa;
            }
            set
            {
                CanWriteProperty("DTRa", true);
                if (_DTRa != value)
                {
                    _DTRa = value;
                    PropertyHasChanged("DTRa");
                }
            }
        }

        public Decimal TSBenhAn
        {
            get
            {
                CanReadProperty("TSBenhAn", true);
                _TSBenhAn = _DTCu + _DTVao - _DTRa- _CVNoiTru -_TuVong -_XinVe-_ChuyenKhoa  ;
                return _TSBenhAn;
            }
           
        }

      

        public String DacBiet
        {
            get
            {
                CanReadProperty("DacBiet", true);
                return _dacBiet;
            }
            set
            {
                CanWriteProperty("DacBiet", true);
                if (_dacBiet != value)
                {
                    _dacBiet = value;
                    PropertyHasChanged("DacBiet");
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

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySD");
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

        BC_ChuyenMonNgay_CList _BC_ChuyenMonNgay_CList = BC_ChuyenMonNgay_CList.NewBC_ChuyenMonNgay_CList();

        public BC_ChuyenMonNgay_CList BC_ChuyenMonNgay_CList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _BC_ChuyenMonNgay_CList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_BC_ChuyenMonNgay_CList.Equals(value))
                {
                    _BC_ChuyenMonNgay_CList = value;
                    PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maKhoa.ToString() + "!" + _thang.ToString();
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _BC_ChuyenMonNgay_CList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _BC_ChuyenMonNgay_CList.IsValid;
            }
        }
        #endregion
        #endregion

        #region Business Object Rules and Validation //muon kiem tra null cua truong nao thi cho truong do

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BC_ChuyenMonNgay NewBC_ChuyenMonNgay()
        {
            return DataPortal.Create<BC_ChuyenMonNgay>();
        }
        public static BC_ChuyenMonNgay GetBC_ChuyenMonNgay(String makhoa, DateTime  thang)
        {
            return DataPortal.Fetch<BC_ChuyenMonNgay>(new Criteria(makhoa, SmartDate.Parse ( thang.ToString ())));
        }
        public static BC_ChuyenMonNgay GetBC_ChuyenMonNgay(SafeDataReader dr)
        {
            BC_ChuyenMonNgay obj = new BC_ChuyenMonNgay();
            obj.Fetch(dr);
            return obj;
        }
        /// <summary>
        /// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeleteBC_ChuyenMonNgay_C(String makhoa, SmartDate thang, string nguoisd, string mamay)
        {
            DataPortal.Delete(new OtherCriteria(makhoa, thang, mamay, nguoisd));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BC_ChuyenMonNgay()
        {
            // Prevent direct creation
        }
        internal BC_ChuyenMonNgay(int OrderNumber,
  String MaKhoa,
 SmartDate Thang,
 decimal DTCu,
 decimal DTVao,
 decimal DTRa,
 decimal TSBenhAn,
  string DacBiet,
 
  Boolean huy,
  SmartDate ngaySD,
  String nguoiSD,

  String maMay,

  String tenNguoiSD,
 decimal SaiSotChuyenMon, decimal PhanUngCoHai

                 )
        {

            _OrderNumber = OrderNumber;
            _maKhoa = MaKhoa;
            _thang = Thang;
            _DTCu = DTCu;
            _DTVao = DTVao;
            _DTRa = DTRa;
            _TSBenhAn = TSBenhAn;
           
            _saiSotChuyenMon = SaiSotChuyenMon;
            _phanUngCoHai = PhanUngCoHai;
          
            _dacBiet = DacBiet;
            
            _huy = huy ;
            _ngaySD = ngaySD ;
            _nguoiSD = NguoiSD;
            _tenNguoiSD = tenNguoiSD;
            _maMay = maMay;

        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
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
            public Criteria(String makhoa, SmartDate thang)
            {
                _makhoa = makhoa;
                _thang = thang;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_makhoa.Equals(c._makhoa) || !_thang.Equals(c._thang))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _makhoa.ToString()).GetHashCode();
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

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            //DeleteBC_ChuyenMonNgay(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String makhoa, SmartDate thang, String Mamay, String Nguoisd)
            {
                _maKhoa = makhoa;
                
                
               
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
        /// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
        /// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            if (dr.Read())
            {
                if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
                if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
                if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
                if (dr.GetString("dacbiet") != null) _dacBiet = dr.GetString("dacbiet");
           
                
                if (dr.GetDecimal("DTCu") != null) _DTCu = dr.GetDecimal("DTCu");
                if (dr.GetDecimal("DTVao") != null) _DTVao = dr.GetDecimal("DTVao");
                if (dr.GetDecimal("DTRa") != null) _DTRa = dr.GetDecimal("DTRa");
                if (dr.GetDecimal("TSBenhAn") != null) _TSBenhAn = dr.GetDecimal("TSBenhAn");
              
                if (dr.GetDecimal("SaiSotChuyenMon") != null) _saiSotChuyenMon = dr.GetDecimal("SaiSotChuyenMon");
                if (dr.GetDecimal("PhanUngCoHai") != null) _phanUngCoHai = dr.GetDecimal("PhanUngCoHai");
                if (dr.GetDecimal("PhauThuat") != null) _PhauThuat = dr.GetDecimal("PhauThuat");
                if (dr.GetDecimal("XinVe") != null) _XinVe = dr.GetDecimal("XinVe");
                if (dr.GetDecimal("ChuyenKhoa") != null) _ChuyenKhoa = dr.GetDecimal("ChuyenKhoa");
                if (dr.GetDecimal("RaVien") != null) _RaVien = dr.GetDecimal("RaVien");
                if (dr.GetDecimal("VaoVien") != null) _VaoVien = dr.GetDecimal("VaoVien");
                if (dr.GetDecimal("TuVong") != null) _TuVong = dr.GetDecimal("TuVong");
                if (dr.GetDecimal("CVNoiTru") != null) _CVNoiTru = dr.GetDecimal("CVNoiTru");
                
                if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
                if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
                if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
                if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
                if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
                // _OrderNumber = dr.GetInt32("STT");
            }
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_ChuyenMonNgay(crit.Makhoa, crit.Thang)))
            {
                
                {
                       _BC_ChuyenMonNgay_CList = BC_ChuyenMonNgay_CList.GetBC_ChuyenMonNgay_CList(dr);//////////////
                 
                    if (dr.NextResult())
                    {
                        Fetch(dr);
                      }
                    //ValidationRules.CheckRules();
                }
            }
        }


        /// <summary>
        /// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
           
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            //public abstract String InsertBC_ChuyenMonNgay(string _m SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            DataProvider.Instance().InsertBC_ChuyenMonNgay(_maKhoa, _thang, _DTCu, _DTVao, _DTRa, _TSBenhAn, _dacBiet, _saiSotChuyenMon,_phanUngCoHai , _CVNoiTru, _TuVong, _VaoVien, _RaVien, _ChuyenKhoa, _XinVe, _PhauThuat,_nguoiSD, _maMay);
            // public abstract void UpdateBC_ChuyenMonNgay(String _tenKhoa, SmartDate _thang, String _maKhoa, SmartDate _ngaySD, String _tenNguoiSD, Boolean _huy, String _maMay, String _tenKhoa1, String _maKhoa1, SmartDate _thang1, Decimal _DTCu, Decimal _DTVao, Decimal _DTRa, Decimal _TSBenhAn, Decimal _tTTruyenHC, Decimal _tongBNDTHC, Decimal _tongNgayDTHC, Decimal _tongBNDTNoiT, Decimal _tongNgayDTNoiT, Decimal _ngaySDung, Decimal _ngayDTTB, Decimal _giuongBenhTH, Decimal _congsuatSD, Decimal _tongBNNgoaitinhVV, Decimal _tongBNNgoaitinhVVBH, Decimal _tongBNNgoaitinhVVND, Decimal _tongNgayBNNgoaiT, String _dacBiet, Decimal _pTLoaiDB, Decimal _pTLoai1A, Decimal _pTLoai1B, Decimal _pTLoai1C, Decimal _pTLoai2A, Decimal _pTLoai2B, Decimal _pTLoai2C, Decimal _pTLoai3, Decimal _pTNgoaiTinh, Decimal _pTTuVong, Decimal _pTTaiBien, Decimal _pTTPPhongK, Decimal _tTSoiCTC, Decimal _tTSoiTMH, Decimal _tTBamST, Decimal _tTSoiDDDT, Decimal _chitieuGiuong, String _nguoiSD, SmartDate _ngaySD1, Boolean _huy1, String _maMay1, String _tenNguoiSD1);
            _BC_ChuyenMonNgay_CList.Update(this);

        }


        /// <summary>
        /// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {

                
                  

                DataProvider.Instance().UpdateBC_ChuyenMonNgay(_maKhoa, _thang, _DTCu, _DTVao, _DTRa, _TSBenhAn, _dacBiet, _saiSotChuyenMon, _phanUngCoHai, _CVNoiTru, _TuVong, _VaoVien, _RaVien, _ChuyenKhoa, _XinVe, _PhauThuat, _huy, _nguoiSD, _maMay);
                _BC_ChuyenMonNgay_CList.Update(this);

            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maKhoa, _thang, _nguoiSD, _maMay));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            
            

            DataProvider.Instance().DeleteBC_ChuyenMonNgay(crit.MaKhoa, crit.Thang, _nguoiSD, _maMay);

        }

        #endregion
    }

        #endregion
}
