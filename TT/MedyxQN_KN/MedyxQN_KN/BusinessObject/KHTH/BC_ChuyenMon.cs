


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
    public partial class BC_ChuyenMon : BusinessBase<BC_ChuyenMon>
    {

        #region Business Methods

        #region State Fields

        private String _tenKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _maKhoa = String.Empty;
        private Decimal _SoNgay = 0;
        private Decimal _KeHoach = 0;
        private Decimal _ThucTe = 0;
        private Decimal _tongTT = 0;
        private Decimal _tongPT = 0;
        private Decimal _tTCcuu = 0;
        private Decimal _tTLoai1 = 0;
        private Decimal _tTLoai2 = 0;
        private Decimal _tTLoai3 = 0;
        private Decimal _tTTruyenHC = 0;
        private Decimal _tongBNDTHC = 0;
        private Decimal _tongNgayDTHC = 0;
        private Decimal _tongBNDTNoiT = 0;
        private Decimal _tongNgayDTNoiT = 0;
        private Decimal _ngaySDung = 0;
        private Decimal _ngayDTTB = 0;
        private Decimal _giuongBenhTH = 0;
        private Decimal _congsuatSD = 0;
        private Decimal _tongBNNgoaitinhVV = 0;
        private Decimal _tongBNNgoaitinhVVBH = 0;
        private Decimal _tongBNNgoaitinhVVND = 0;
        private Decimal _tongNgayBNNgoaiT = 0;
        private String _dacBiet = String.Empty;
        private Decimal _pTLoaiDB = 0;
        private Decimal _pTLoai1A = 0;
        private Decimal _pTLoai1B = 0;
        private Decimal _pTLoai1C = 0;
        private Decimal _pTLoai2A = 0;
        private Decimal _pTLoai2B = 0;
        private Decimal _pTLoai2C = 0;
        private Decimal _pTLoai3 = 0;
        private Decimal _pTNgoaiTinh = 0;
        private Decimal _pTTuVong = 0;
        private Decimal _pTTaiBien = 0;
        private Decimal _pTTPPhongK = 0;
        private Decimal _tTSoiCTC = 0;
        private Decimal _tTSoiTMH = 0;
        private Decimal _tTBamST = 0;
        private Decimal _tTSoiDDDT = 0;
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
        public Decimal tongTT
        {
            get
            {
                CanReadProperty("tongTT", true);
                _tongTT = _tTBamST + _tTLoai1 + _tTLoai2 + _tTLoai3 + _tTSoiCTC + _tTSoiDDDT + _tTSoiTMH + _tTTruyenHC;
                return _tongTT;
            }
          
        }
        public Decimal tongPT
        {
            get
            {
                CanReadProperty("tongPT", true);
                return _tongPT;
            }
            set
            {
                CanWriteProperty("tongPT", true);
                if (_tongPT != value)
                {
                    _tongPT = value;
                    PropertyHasChanged("tongPT");
                }
            }
        }
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


        public Decimal SoNgay
        {
            get
            {
                CanReadProperty("SoNgay", true);
                return _SoNgay;
            }
            set
            {
                CanWriteProperty("SoNgay", true);
                if (_SoNgay != value)
                {
                    _SoNgay = value;
                    PropertyHasChanged("SoNgay");
                }
            }
        }
        public Decimal KeHoach
        {
            get
            {
                CanReadProperty("KeHoach", true);
                return _KeHoach;
            }
            set
            {
                CanWriteProperty("KeHoach", true);
                if (_KeHoach != value)
                {
                    _KeHoach = value;
                    PropertyHasChanged("KeHoach");
                }
            }
        }
        public Decimal ThucTe
        {
            get
            {
                CanReadProperty("ThucTe", true);
                return _ThucTe;
            }
            set
            {
                CanWriteProperty("ThucTe", true);
                if (_ThucTe != value)
                {
                    _ThucTe = value;
                    PropertyHasChanged("ThucTe");
                }
            }
        }

        public Decimal TTCcuu
        {
            get
            {
                CanReadProperty("TTCcuu", true);
                return _tTCcuu;
            }
            set
            {
                CanWriteProperty("TTCcuu", true);
                if (_tTCcuu != value)
                {
                    _tTCcuu = value;
                    PropertyHasChanged("TTCcuu");
                }
            }
        }

        public Decimal TTLoai1
        {
            get
            {
                CanReadProperty("TTLoai1", true);
                return _tTLoai1;
            }
            set
            {
                CanWriteProperty("TTLoai1", true);
                if (_tTLoai1 != value)
                {
                    _tTLoai1 = value;
                    PropertyHasChanged("TTLoai1");
                }
            }
        }

        public Decimal TTLoai2
        {
            get
            {
                CanReadProperty("TTLoai2", true);
                return _tTLoai2;
            }
            set
            {
                CanWriteProperty("TTLoai2", true);
                if (_tTLoai2 != value)
                {
                    _tTLoai2 = value;
                    PropertyHasChanged("TTLoai2");
                }
            }
        }

        public Decimal TTLoai3
        {
            get
            {
                CanReadProperty("TTLoai3", true);
                return _tTLoai3;
            }
            set
            {
                CanWriteProperty("TTLoai3", true);
                if (_tTLoai3 != value)
                {
                    _tTLoai3 = value;
                    PropertyHasChanged("TTLoai3");
                }
            }
        }

        public Decimal TTTruyenHC
        {
            get
            {
                CanReadProperty("TTTruyenHC", true);
                return _tTTruyenHC;
            }
            set
            {
                CanWriteProperty("TTTruyenHC", true);
                if (_tTTruyenHC != value)
                {
                    _tTTruyenHC = value;
                    PropertyHasChanged("TTTruyenHC");
                }
            }
        }

        public Decimal TongBNDTHC
        {
            get
            {
                CanReadProperty("TongBNDTHC", true);
                return _tongBNDTHC;
            }
            set
            {
                CanWriteProperty("TongBNDTHC", true);
                if (_tongBNDTHC != value)
                {
                    _tongBNDTHC = value;
                    PropertyHasChanged("TongBNDTHC");
                }
            }
        }

        public Decimal TongNgayDTHC
        {
            get
            {
                CanReadProperty("TongNgayDTHC", true);
                return _tongNgayDTHC;
            }
            set
            {
                CanWriteProperty("TongNgayDTHC", true);
                if (_tongNgayDTHC != value)
                {
                    _tongNgayDTHC = value;
                    PropertyHasChanged("TongNgayDTHC");
                }
            }
        }

        public Decimal TongBNDTNoiT
        {
            get
            {
                CanReadProperty("TongBNDTNoiT", true);
                return _tongBNDTNoiT;
            }
            set
            {
                CanWriteProperty("TongBNDTNoiT", true);
                if (_tongBNDTNoiT != value)
                {
                    _tongBNDTNoiT = value;
                    PropertyHasChanged("TongBNDTNoiT");
                }
            }
        }

        public Decimal TongNgayDTNoiT
        {
            get
            {
                CanReadProperty("TongNgayDTNoiT", true);
                return _tongNgayDTNoiT;
            }
            set
            {
                CanWriteProperty("TongNgayDTNoiT", true);
                if (_tongNgayDTNoiT != value)
                {
                    _tongNgayDTNoiT = value;
                    PropertyHasChanged("TongNgayDTNoiT");
                }
            }
        }

        public Decimal NgaySDung
        {
            get
            {
                CanReadProperty("NgaySDung", true);
                return _ngaySDung;
            }
            set
            {
                CanWriteProperty("NgaySDung", true);
                if (_ngaySDung != value)
                {
                    _ngaySDung = value;
                    PropertyHasChanged("NgaySDung");
                }
            }
        }

        public Decimal NgayDTTB
        {
            get
            {
                CanReadProperty("NgayDTTB", true);
                return _ngayDTTB;
            }
            set
            {
                CanWriteProperty("NgayDTTB", true);
                if (_ngayDTTB != value)
                {
                    _ngayDTTB = value;
                    PropertyHasChanged("NgayDTTB");
                }
            }
        }

        public Decimal GiuongBenhTH
        {
            get
            {
                CanReadProperty("GiuongBenhTH", true);
                return _giuongBenhTH;
            }
            set
            {
                CanWriteProperty("GiuongBenhTH", true);
                if (_giuongBenhTH != value)
                {
                    _giuongBenhTH = value;
                    PropertyHasChanged("GiuongBenhTH");
                }
            }
        }

        public Decimal CongsuatSD
        {
            get
            {
                CanReadProperty("CongsuatSD", true);
                return _congsuatSD;
            }
            set
            {
                CanWriteProperty("CongsuatSD", true);
                if (_congsuatSD != value)
                {
                    _congsuatSD = value;
                    PropertyHasChanged("CongsuatSD");
                }
            }
        }

        public Decimal TongBNNgoaitinhVV
        {
            get
            {
                CanReadProperty("TongBNNgoaitinhVV", true);
                _tongBNNgoaitinhVV = _tongBNNgoaitinhVVBH + _tongBNNgoaitinhVVND;
                return _tongBNNgoaitinhVV;
            }
           
        }

        public Decimal TongBNNgoaitinhVVBH
        {
            get
            {
                CanReadProperty("TongBNNgoaitinhVVBH", true);
                return _tongBNNgoaitinhVVBH;
            }
            set
            {
                CanWriteProperty("TongBNNgoaitinhVVBH", true);
                if (_tongBNNgoaitinhVVBH != value)
                {
                    _tongBNNgoaitinhVVBH = value;
                    PropertyHasChanged("TongBNNgoaitinhVVBH");
                }
            }
        }

        public Decimal TongBNNgoaitinhVVND
        {
            get
            {
                CanReadProperty("TongBNNgoaitinhVVND", true);
                return _tongBNNgoaitinhVVND;
            }
            set
            {
                CanWriteProperty("TongBNNgoaitinhVVND", true);
                if (_tongBNNgoaitinhVVND != value)
                {
                    _tongBNNgoaitinhVVND = value;
                    PropertyHasChanged("TongBNNgoaitinhVVND");
                }
            }
        }

        public Decimal TongNgayBNNgoaiT
        {
            get
            {
                CanReadProperty("TongNgayBNNgoaiT", true);
                return _tongNgayBNNgoaiT;
            }
            set
            {
                CanWriteProperty("TongNgayBNNgoaiT", true);
                if (_tongNgayBNNgoaiT != value)
                {
                    _tongNgayBNNgoaiT = value;
                    PropertyHasChanged("TongNgayBNNgoaiT");
                }
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

        public Decimal PTLoaiDB
        {
            get
            {
                CanReadProperty("PTLoaiDB", true);
                return _pTLoaiDB;
            }
            set
            {
                CanWriteProperty("PTLoaiDB", true);
                if (_pTLoaiDB != value)
                {
                    _pTLoaiDB = value;
                    PropertyHasChanged("PTLoaiDB");
                }
            }
        }

        public Decimal PTLoai1A
        {
            get
            {
                CanReadProperty("PTLoai1A", true);
                return _pTLoai1A;
            }
            set
            {
                CanWriteProperty("PTLoai1A", true);
                if (_pTLoai1A != value)
                {
                    _pTLoai1A = value;
                    PropertyHasChanged("PTLoai1A");
                }
            }
        }

        public Decimal PTLoai1B
        {
            get
            {
                CanReadProperty("PTLoai1B", true);
                return _pTLoai1B;
            }
            set
            {
                CanWriteProperty("PTLoai1B", true);
                if (_pTLoai1B != value)
                {
                    _pTLoai1B = value;
                    PropertyHasChanged("PTLoai1B");
                }
            }
        }

        public Decimal PTLoai1C
        {
            get
            {
                CanReadProperty("PTLoai1C", true);
                return _pTLoai1C;
            }
            set
            {
                CanWriteProperty("PTLoai1C", true);
                if (_pTLoai1C != value)
                {
                    _pTLoai1C = value;
                    PropertyHasChanged("PTLoai1C");
                }
            }
        }

        public Decimal PTLoai2A
        {
            get
            {
                CanReadProperty("PTLoai2A", true);
                return _pTLoai2A;
            }
            set
            {
                CanWriteProperty("PTLoai2A", true);
                if (_pTLoai2A != value)
                {
                    _pTLoai2A = value;
                    PropertyHasChanged("PTLoai2A");
                }
            }
        }

        public Decimal PTLoai2B
        {
            get
            {
                CanReadProperty("PTLoai2B", true);
                return _pTLoai2B;
            }
            set
            {
                CanWriteProperty("PTLoai2B", true);
                if (_pTLoai2B != value)
                {
                    _pTLoai2B = value;
                    PropertyHasChanged("PTLoai2B");
                }
            }
        }

        public Decimal PTLoai2C
        {
            get
            {
                CanReadProperty("PTLoai2C", true);
                return _pTLoai2C;
            }
            set
            {
                CanWriteProperty("PTLoai2C", true);
                if (_pTLoai2C != value)
                {
                    _pTLoai2C = value;
                    PropertyHasChanged("PTLoai2C");
                }
            }
        }

        public Decimal PTLoai3
        {
            get
            {
                CanReadProperty("PTLoai3", true);
                return _pTLoai3;
            }
            set
            {
                CanWriteProperty("PTLoai3", true);
                if (_pTLoai3 != value)
                {
                    _pTLoai3 = value;
                    PropertyHasChanged("PTLoai3");
                }
            }
        }

        public Decimal PTNgoaiTinh
        {
            get
            {
                CanReadProperty("PTNgoaiTinh", true);
                return _pTNgoaiTinh;
            }
            set
            {
                CanWriteProperty("PTNgoaiTinh", true);
                if (_pTNgoaiTinh != value)
                {
                    _pTNgoaiTinh = value;
                    PropertyHasChanged("PTNgoaiTinh");
                }
            }
        }

        public Decimal PTTuVong
        {
            get
            {
                CanReadProperty("PTTuVong", true);
                return _pTTuVong;
            }
            set
            {
                CanWriteProperty("PTTuVong", true);
                if (_pTTuVong != value)
                {
                    _pTTuVong = value;
                    PropertyHasChanged("PTTuVong");
                }
            }
        }

        public Decimal PTTaiBien
        {
            get
            {
                CanReadProperty("PTTaiBien", true);
                return _pTTaiBien;
            }
            set
            {
                CanWriteProperty("PTTaiBien", true);
                if (_pTTaiBien != value)
                {
                    _pTTaiBien = value;
                    PropertyHasChanged("PTTaiBien");
                }
            }
        }

        public Decimal PTTPPhongK
        {
            get
            {
                CanReadProperty("PTTPPhongK", true);
                return _pTTPPhongK;
            }
            set
            {
                CanWriteProperty("PTTPPhongK", true);
                if (_pTTPPhongK != value)
                {
                    _pTTPPhongK = value;
                    PropertyHasChanged("PTTPPhongK");
                }
            }
        }

        public Decimal TTSoiCTC
        {
            get
            {
                CanReadProperty("TTSoiCTC", true);
                return _tTSoiCTC;
            }
            set
            {
                CanWriteProperty("TTSoiCTC", true);
                if (_tTSoiCTC != value)
                {
                    _tTSoiCTC = value;
                    PropertyHasChanged("TTSoiCTC");
                }
            }
        }

        public Decimal TTSoiTMH
        {
            get
            {
                CanReadProperty("TTSoiTMH", true);
                return _tTSoiTMH;
            }
            set
            {
                CanWriteProperty("TTSoiTMH", true);
                if (_tTSoiTMH != value)
                {
                    _tTSoiTMH = value;
                    PropertyHasChanged("TTSoiTMH");
                }
            }
        }

        public Decimal TTBamST
        {
            get
            {
                CanReadProperty("TTBamST", true);
                return _tTBamST;
            }
            set
            {
                CanWriteProperty("TTBamST", true);
                if (_tTBamST != value)
                {
                    _tTBamST = value;
                    PropertyHasChanged("TTBamST");
                }
            }
        }

        public Decimal TTSoiDDDT
        {
            get
            {
                CanReadProperty("TTSoiDDDT", true);
                return _tTSoiDDDT;
            }
            set
            {
                CanWriteProperty("TTSoiDDDT", true);
                if (_tTSoiDDDT != value)
                {
                    _tTSoiDDDT = value;
                    PropertyHasChanged("TTSoiDDDT");
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

        BC_ChuyenMon_CList _BC_ChuyenMon_CList = BC_ChuyenMon_CList.NewBC_ChuyenMon_CList();

        public BC_ChuyenMon_CList BC_ChuyenMon_CList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _BC_ChuyenMon_CList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_BC_ChuyenMon_CList.Equals(value))
                {
                    _BC_ChuyenMon_CList = value;
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
                return base.IsDirty || _BC_ChuyenMon_CList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _BC_ChuyenMon_CList.IsValid;
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
        public static BC_ChuyenMon NewBC_ChuyenMon()
        {
            return DataPortal.Create<BC_ChuyenMon>();
        }
        public static BC_ChuyenMon GetBC_ChuyenMon(String makhoa, DateTime  thang)
        {
            return DataPortal.Fetch<BC_ChuyenMon>(new Criteria(makhoa, SmartDate.Parse ( thang.ToString ())));
        }
        public static BC_ChuyenMon GetBC_ChuyenMon(SafeDataReader dr)
        {
            BC_ChuyenMon obj = new BC_ChuyenMon();
            obj.Fetch(dr);
            return obj;
        }
        /// <summary>
        /// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeleteBC_ChuyenMon_C(String makhoa, SmartDate thang, string nguoisd, string mamay)
        {
            DataPortal.Delete(new OtherCriteria(makhoa, thang, mamay, nguoisd));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BC_ChuyenMon()
        {
            // Prevent direct creation
        }
        internal BC_ChuyenMon(int OrderNumber,
  String MaKhoa,
 SmartDate Thang,
 decimal TTCcuu,
 decimal TTLoai1,
 decimal TTLoai2,
 decimal TTLoai3,
 decimal TTTruyenHC,
 decimal TongBNDTHC,
 decimal TongNgayDTHC,
 decimal TongBNDTNoiT,
 decimal TongNgayDTNoiT,
 decimal NgaySDung,
 decimal NgayDTTB,
 decimal GiuongBenhTH,
 decimal CongsuatSD,
 decimal TongBNNgoaitinhVV,
 decimal TongBNNgoaitinhVVBH,
 decimal TongBNNgoaitinhVVND,
 decimal TongNgayBNNgoaiT,
 string DacBiet,
 decimal PTLoaiDB,
 decimal PTLoai1A,
 decimal PTLoai1B,
 decimal PTLoai1C,
 decimal PTLoai2A,
 decimal PTLoai2B,
 decimal PTLoai2C,
 decimal PTLoai3,
 decimal PTNgoaiTinh,
 decimal PTTuVong,
 decimal PTTaiBien,
 decimal PTTPPhongK,
 decimal TTSoiCTC,
 decimal TTSoiTMH,
 decimal TTBamST,
 decimal TTSoiDDDT,
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
            _tTCcuu = TTCcuu;
            _tTLoai1 = TTLoai1;
            _tTLoai2 = TTLoai2;
            _tTLoai3 = TTLoai3;
            _tTTruyenHC = TTTruyenHC;
            _tongBNDTHC = TongBNDTHC;
            _tongNgayDTHC = TongNgayDTHC;
            _tongBNDTNoiT = TongBNDTNoiT;
            _tongNgayDTNoiT = TongNgayDTNoiT;
            _ngaySDung = NgaySDung;
            _ngayDTTB = NgayDTTB;
            _saiSotChuyenMon = SaiSotChuyenMon;
            _phanUngCoHai = PhanUngCoHai;
            _giuongBenhTH = GiuongBenhTH;
            _congsuatSD = CongsuatSD;
            _tongBNNgoaitinhVV = TongBNNgoaitinhVV;
            _tongBNNgoaitinhVVBH = TongBNNgoaitinhVVBH;
            _tongBNNgoaitinhVVND = TongBNNgoaitinhVVND;
            _tongNgayBNNgoaiT = TongNgayBNNgoaiT;
            _dacBiet = DacBiet;
            _pTLoaiDB = PTLoaiDB;
            _pTLoai1A = PTLoai1A;
            _pTLoai1B = PTLoai1B;
            _pTLoai1C = PTLoai1C;
            _pTLoai2A = PTLoai2A;
            _pTLoai2B = PTLoai2B;
            _pTLoai2C = PTLoai2C;
            _pTLoai3 = PTLoai3;
            _pTNgoaiTinh = PTNgoaiTinh;
            _pTTuVong = PTTuVong;
            _pTTaiBien = PTTaiBien;
            _pTTPPhongK = PTTPPhongK;
            _tTSoiCTC = TTSoiCTC;
            _tTSoiTMH = TTSoiTMH;
            _tTBamST = TTBamST;
            _tTSoiDDDT = TTSoiDDDT;
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
            //DeleteBC_ChuyenMon(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
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
                if (dr.GetDecimal("SoNgay") != null) _SoNgay = dr.GetDecimal("SoNgay");
                if (dr.GetDecimal("KeHoach") != null) _KeHoach = dr.GetDecimal("KeHoach");
                if (dr.GetDecimal("ThucTe") != null) _ThucTe = dr.GetDecimal("ThucTe");
                
                if (dr.GetDecimal("TTCcuu") != null) _tTCcuu = dr.GetDecimal("TTCcuu");
                if (dr.GetDecimal("TTLoai1") != null) _tTLoai1 = dr.GetDecimal("TTLoai1");
                if (dr.GetDecimal("TTLoai2") != null) _tTLoai2 = dr.GetDecimal("TTLoai2");
                if (dr.GetDecimal("TTLoai3") != null) _tTLoai3 = dr.GetDecimal("TTLoai3");
                if (dr.GetDecimal("TTTruyenHC") != null) _tTTruyenHC = dr.GetDecimal("TTTruyenHC");
                if (dr.GetDecimal("TongBNDTHC") != null) _tongBNDTHC = dr.GetDecimal("TongBNDTHC");
                if (dr.GetDecimal("TongNgayDTHC") != null) _tongNgayDTHC = dr.GetDecimal("TongNgayDTHC");
                if (dr.GetDecimal("TongBNDTNoiT") != null) _tongBNDTNoiT = dr.GetDecimal("TongBNDTNoiT");
                if (dr.GetDecimal("TongNgayDTNoiT") != null) _tongNgayDTNoiT = dr.GetDecimal("TongNgayDTNoiT");
                if (dr.GetDecimal("NgaySDung") != null) _ngaySDung = dr.GetDecimal("NgaySDung");
                if (dr.GetDecimal("NgayDTTB") != null) _ngayDTTB = dr.GetDecimal("NgayDTTB");
                if (dr.GetDecimal("GiuongBenhTH") != null) _giuongBenhTH = dr.GetDecimal("GiuongBenhTH");
                if (dr.GetDecimal("CongsuatSD") != null) _congsuatSD = dr.GetDecimal("CongsuatSD");
                if (dr.GetDecimal("TongBNNgoaitinhVV") != null) _tongBNNgoaitinhVV = dr.GetDecimal("TongBNNgoaitinhVV");
                if (dr.GetDecimal("TongBNNgoaitinhVVBH") != null) _tongBNNgoaitinhVVBH = dr.GetDecimal("TongBNNgoaitinhVVBH");
                if (dr.GetDecimal("TongBNNgoaitinhVVND") != null) _tongBNNgoaitinhVVND = dr.GetDecimal("TongBNNgoaitinhVVND");
                if (dr.GetDecimal("TongNgayBNNgoaiT") != null) _tongNgayBNNgoaiT = dr.GetDecimal("TongNgayBNNgoaiT");
                if (dr.GetString("DacBiet") != null) _dacBiet = dr.GetString("DacBiet");
                if (dr.GetDecimal("PTLoaiDB") != null) _pTLoaiDB = dr.GetDecimal("PTLoaiDB");
                if (dr.GetDecimal("PTLoai1A") != null) _pTLoai1A = dr.GetDecimal("PTLoai1A");
                if (dr.GetDecimal("PTLoai1B") != null) _pTLoai1B = dr.GetDecimal("PTLoai1B");
                if (dr.GetDecimal("PTLoai1C") != null) _pTLoai1C = dr.GetDecimal("PTLoai1C");
                if (dr.GetDecimal("PTLoai2A") != null) _pTLoai2A = dr.GetDecimal("PTLoai2A");
                if (dr.GetDecimal("PTLoai2B") != null) _pTLoai2B = dr.GetDecimal("PTLoai2B");
                if (dr.GetDecimal("PTLoai2C") != null) _pTLoai2C = dr.GetDecimal("PTLoai2C");
                if (dr.GetDecimal("PTLoai3") != null) _pTLoai3 = dr.GetDecimal("PTLoai3");
                if (dr.GetDecimal("PTNgoaiTinh") != null) _pTNgoaiTinh = dr.GetDecimal("PTNgoaiTinh");
                if (dr.GetDecimal("PTTuVong") != null) _pTTuVong = dr.GetDecimal("PTTuVong");
                if (dr.GetDecimal("PTTaiBien") != null) _pTTaiBien = dr.GetDecimal("PTTaiBien");
                if (dr.GetDecimal("PTTPPhongK") != null) _pTTPPhongK = dr.GetDecimal("PTTPPhongK");
                if (dr.GetDecimal("TTSoiCTC") != null) _tTSoiCTC = dr.GetDecimal("TTSoiCTC");
                if (dr.GetDecimal("TTSoiTMH") != null) _tTSoiTMH = dr.GetDecimal("TTSoiTMH");
                if (dr.GetDecimal("TTBamST") != null) _tTBamST = dr.GetDecimal("TTBamST");
                if (dr.GetDecimal("TTSoiDDDT") != null) _tTSoiDDDT = dr.GetDecimal("TTSoiDDDT");
                if (dr.GetDecimal("SaiSotChuyenMon") != null) _saiSotChuyenMon = dr.GetDecimal("SaiSotChuyenMon");
                if (dr.GetDecimal("PhanUngCoHai") != null) _phanUngCoHai = dr.GetDecimal("PhanUngCoHai");

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

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_ChuyenMon(crit.Makhoa, crit.Thang)))
            {
                
                {
                       _BC_ChuyenMon_CList = BC_ChuyenMon_CList.GetBC_ChuyenMon_CList(dr);//////////////
                 
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
            
              
            //public abstract String InsertBC_ChuyenMon(string _m SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            DataProvider.Instance().InsertBC_ChuyenMon(_maKhoa, _thang, _tTCcuu, _tTLoai1, _tTLoai2, _tTLoai3, _tTTruyenHC, _tongBNDTHC, _tongNgayDTHC, _tongBNDTNoiT, _tongNgayDTNoiT, _ngaySDung, _ngayDTTB, _giuongBenhTH, _congsuatSD, _tongBNNgoaitinhVV, _tongBNNgoaitinhVVBH, _tongBNNgoaitinhVVND, _tongNgayBNNgoaiT, _dacBiet, _pTLoaiDB, _pTLoai1A, _pTLoai1B, _pTLoai1C, _pTLoai2A, _pTLoai2B, _pTLoai2C, _pTLoai3, _pTNgoaiTinh, _pTTuVong, _pTTaiBien, _pTTPPhongK, _tTSoiCTC, _tTSoiTMH, _tTBamST, _tTSoiDDDT, _saiSotChuyenMon,_phanUngCoHai ,_SoNgay ,_KeHoach ,_ThucTe , _nguoiSD, _maMay);
            // public abstract void UpdateBC_ChuyenMon(String _tenKhoa, SmartDate _thang, String _maKhoa, SmartDate _ngaySD, String _tenNguoiSD, Boolean _huy, String _maMay, String _tenKhoa1, String _maKhoa1, SmartDate _thang1, Decimal _tTCcuu, Decimal _tTLoai1, Decimal _tTLoai2, Decimal _tTLoai3, Decimal _tTTruyenHC, Decimal _tongBNDTHC, Decimal _tongNgayDTHC, Decimal _tongBNDTNoiT, Decimal _tongNgayDTNoiT, Decimal _ngaySDung, Decimal _ngayDTTB, Decimal _giuongBenhTH, Decimal _congsuatSD, Decimal _tongBNNgoaitinhVV, Decimal _tongBNNgoaitinhVVBH, Decimal _tongBNNgoaitinhVVND, Decimal _tongNgayBNNgoaiT, String _dacBiet, Decimal _pTLoaiDB, Decimal _pTLoai1A, Decimal _pTLoai1B, Decimal _pTLoai1C, Decimal _pTLoai2A, Decimal _pTLoai2B, Decimal _pTLoai2C, Decimal _pTLoai3, Decimal _pTNgoaiTinh, Decimal _pTTuVong, Decimal _pTTaiBien, Decimal _pTTPPhongK, Decimal _tTSoiCTC, Decimal _tTSoiTMH, Decimal _tTBamST, Decimal _tTSoiDDDT, Decimal _chitieuGiuong, String _nguoiSD, SmartDate _ngaySD1, Boolean _huy1, String _maMay1, String _tenNguoiSD1);
            _BC_ChuyenMon_CList.Update(this);

        }


        /// <summary>
        /// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {

                
                  

                DataProvider.Instance().UpdateBC_ChuyenMon(_maKhoa, _thang, _tTCcuu, _tTLoai1, _tTLoai2, _tTLoai3, _tTTruyenHC, _tongBNDTHC, _tongNgayDTHC, _tongBNDTNoiT, _tongNgayDTNoiT, _ngaySDung, _ngayDTTB, _giuongBenhTH, _congsuatSD, _tongBNNgoaitinhVV, _tongBNNgoaitinhVVBH, _tongBNNgoaitinhVVND, _tongNgayBNNgoaiT, _dacBiet, _pTLoaiDB, _pTLoai1A, _pTLoai1B, _pTLoai1C, _pTLoai2A, _pTLoai2B, _pTLoai2C, _pTLoai3, _pTNgoaiTinh, _pTTuVong, _pTTaiBien, _pTTPPhongK, _tTSoiCTC, _tTSoiTMH, _tTBamST, _tTSoiDDDT, _saiSotChuyenMon, _phanUngCoHai, _SoNgay, _KeHoach, _ThucTe, _huy, _nguoiSD, _maMay);
                _BC_ChuyenMon_CList.Update(this);

            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maKhoa, _thang, _nguoiSD, _maMay));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            
            

            DataProvider.Instance().DeleteBC_ChuyenMon(crit.MaKhoa, crit.Thang, _nguoiSD, _maMay);

        }

        #endregion
    }

        #endregion
}
