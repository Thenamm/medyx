// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_Nghe
// Kieu doi tuong  :	Luong_Nghe
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/29/2009 9:27:28 AM
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


namespace HTC.Business.Luong
{

    /// <summary>
    /// This is a base generated class of <see cref="Luong_Nghe" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class Luong_Nghe : BusinessBase<Luong_Nghe>
    {
        #region Business Methods

        #region State Fields

        private Int32 _sTT = 0;
        private SmartDate _thang = new SmartDate(true);
        private String _maNV = String.Empty;
        private String _makhoa = String.Empty;
        private Decimal _heSoNghe2 = 0;
        private String _maPCNghe1 = String.Empty;
        private String _maPCNghe2 = String.Empty;
        private Decimal _heSoNghe1 = 0;
        private Decimal _ngayNghe1 = 0;
        private Decimal _ngayNghe2 = 0;
        private Decimal _heSo = 0;
        private Decimal _heSoChucVu = 0;
        private Decimal _heSoVK = 0;
        private Decimal _tongHS = 0;
        private Decimal _mucLuongCB = 0;
        private Decimal _mucLuongNgay = 0;
        private Decimal _tong = 0;
        private String _maMay = String.Empty;
        private String _ghiChu = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private Boolean _huy = false;
        private String _hoten = String.Empty;
        private String _tenChuyenMon = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private SmartDate _ngaySinh = new SmartDate(true);
        private Boolean _gioitinh = false;
        private String _gioitinhD = String.Empty;
        private String _tenPNNghe1 = String.Empty;
        private String _tenPNNghe2 = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _maNgach = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public Int32 STT
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
                if (_maNV != value)
                {
                    _maNV = value;
                    PropertyHasChanged("MaNV");
                }
            }
        }

        public String Makhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("Makhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("Makhoa");
                }
            }
        }

        public string HeSoNghe2
        {
            get
            {
                CanReadProperty("HeSoNghe2", true);
                if (_heSoNghe2 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoNghe2.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoNghe2", true);

                if (_heSoNghe2.ToString() != value)
                {
                    if (value == "")
                        _heSoNghe2 = 0;
                    else
                        _heSoNghe2 = Decimal.Parse(value);
                    PropertyHasChanged("HeSoNghe2");
                }
            }
        }
        public String MaPCNghe1
        {
            get
            {
                CanReadProperty("MaPCNghe1", true);
                return _maPCNghe1;
            }
            set
            {
                CanWriteProperty("MaPCNghe1", true);
                if (_maPCNghe1 != value)
                {
                    _maPCNghe1 = value;
                    PropertyHasChanged("MaPCNghe1");
                }
            }
        }
        public String MaPCNghe2
        {
            get
            {
                CanReadProperty("MaPCNghe2", true);
                return _maPCNghe2;
            }
            set
            {
                CanWriteProperty("MaPCNghe2", true);
                if (_maPCNghe2 != value)
                {
                    _maPCNghe2 = value;
                    PropertyHasChanged("MaPCNghe2");
                }
            }
        }
        public string HeSoNghe1
        {
            get
            {
                CanReadProperty("HeSoNghe1", true);
                if (_heSoNghe1 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoNghe1.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoNghe1", true);

                if (_heSoNghe1.ToString() != value)
                {
                    if (value == "")
                        _heSoNghe1 = 0;
                    else
                        _heSoNghe1 = Decimal.Parse(value);
                    PropertyHasChanged("HeSoNghe1");
                }
            }
        }
        //public string NgayNghe1
        //{
        //    get
        //    {
        //        CanReadProperty("NgayNghe1", true);
        //        _ngayNghe1.FormatString = "dd/MM/yyyy";

        //        return _ngayNghe1.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayNghe1", true);
        //        if (_ngayNghe1.Text != value)
        //        {
        //            _ngayNghe1.Text = value;
        //            PropertyHasChanged("NgayNghe1");
        //        }
        //    }
        //}
        public string NgayNghe1
        {
            get
            {
                CanReadProperty("NgayNghe1", true);
                if (_ngayNghe1 == 0)
                {
                    return "";
                }
                else
                {
                    return _ngayNghe1.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("NgayNghe1", true);

                if (_ngayNghe1.ToString() != value)
                {
                    if (value == "")
                        _ngayNghe1 = 0;
                    else
                        _ngayNghe1 = Decimal.Parse(value);
                    PropertyHasChanged("NgayNghe1");
                }
            }
        }

        public string NgayNghe2
        {
            get
            {
                CanReadProperty("NgayNghe2", true);
                if (_ngayNghe2 == 0)
                {
                    return "";
                }
                else
                {
                    return _ngayNghe2.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("NgayNghe2", true);

                if (_heSoNghe1.ToString() != value)
                {
                    if (value == "")
                        _ngayNghe2 = 0;
                    else
                        _ngayNghe2 = Decimal.Parse(value);
                    PropertyHasChanged("NgayNghe2");
                }
            }
        }
        //public string NgayNghe2
        //{
        //    get
        //    {
        //        CanReadProperty("NgayNghe2", true);
        //        _ngayNghe2.FormatString = "dd/MM/yyyy";

        //        return _ngayNghe2.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayNghe2", true);
        //        if (_ngayNghe2.Text != value)
        //        {
        //            _ngayNghe2.Text = value;
        //            PropertyHasChanged("NgayNghe2");
        //        }
        //    }
        //}
        public string HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                if (_heSo == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSo", true);

                if (_heSo.ToString() != value)
                {
                    if (value == "")
                        _heSo = 0;
                    else
                        _heSo = Decimal.Parse(value);
                    PropertyHasChanged("HeSo");
                }
            }
        }
        public string HeSoChucVu
        {
            get
            {
                CanReadProperty("HeSoChucVu", true);
                if (_heSoChucVu == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoChucVu.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoChucVu", true);

                if (_heSoChucVu.ToString() != value)
                {
                    if (value == "")
                        _heSoChucVu = 0;
                    else
                        _heSoChucVu = Decimal.Parse(value);
                    PropertyHasChanged("HeSoChucVu");
                }
            }
        }
        public string HeSoVK
        {
            get
            {
                CanReadProperty("HeSoVK", true);
                if (_heSoVK == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoVK.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoVK", true);

                if (_heSoVK.ToString() != value)
                {
                    if (value == "")
                        _heSoVK = 0;
                    else
                        _heSoVK = Decimal.Parse(value);
                    PropertyHasChanged("HeSoVK");
                }
            }
        }
        public string TongHS
        {
            get
            {
                CanReadProperty("TongHS", true);
                _tongHS  = _heSo  + _heSoChucVu  + _heSoVK ;
                //return _tongSoTheo.ToString("###,###");
                if (_tongHS  == 0)
                {
                    return "";
                }
                else
                {
                    return _tongHS.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("TongHS", true);

                if (_tongHS.ToString() != value)
                {
                    if (value == "")
                        _tongHS = 0;
                    else
                        _tongHS = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongHS");
                }
            }
        }
        public string MucLuongCB
        {
            get
            {
                CanReadProperty("MucLuongCB", true);
                if (_mucLuongCB == 0)
                {
                    return "";
                }
                else
                {
                    return _mucLuongCB.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("MucLuongCB", true);

                if (_mucLuongCB.ToString() != value)
                {
                    if (value == "")
                        _mucLuongCB = 0;
                    else
                        _mucLuongCB = Decimal.Parse(value);
                    PropertyHasChanged("MucLuongCB");
                }
            }
        }
        public string MucLuongNgay
        {
            get
            {
                CanReadProperty("MucLuongNgay", true);
                _mucLuongNgay = (_tongHS * _mucLuongCB) / 22; 

                if (_mucLuongNgay  == 0)
                {
                    return "";
                }
                else
                {
                    return _mucLuongNgay.ToString("###,###,###");
                }
            }
            set
            {
                CanWriteProperty("MucLuongNgay", true);

                if (_mucLuongNgay.ToString() != value)
                {
                    if (value == "")
                        _mucLuongNgay = 0;
                    else
                        _mucLuongNgay = Decimal.Parse(value);
                    PropertyHasChanged("MucLuongNgay");
                }
            }
        }

        public string Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong =_mucLuongNgay * (_ngayNghe1 * _heSoNghe1  + _ngayNghe2 * _heSoNghe2 );
                if (_tong == 0)
                {
                    return "";
                }
                else
                {
                    return _tong.ToString("###,###,###");
                }
            }
            set
            {
                CanWriteProperty("Tong", true);

                if (_tong.ToString() != value)
                {
                    if (value == "")
                        _tong = 0;
                    else
                        _tong = Decimal.Parse(value);
                    PropertyHasChanged("Tong");
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

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
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

        public string NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
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

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
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

        public string NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                return _ngaySD1.Text;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1.Text != value)
                {
                    _ngaySD1.Text = value;
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
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }
        public String TenChuyenMon
        {
            get
            {
                CanReadProperty("TenChuyenMon", true);
                return _tenChuyenMon;
            }
            set
            {
                CanWriteProperty("TenChuyenMon", true);
                if (_tenChuyenMon != value)
                {
                    _tenChuyenMon = value;
                    PropertyHasChanged("TenChuyenMon");
                }
            }
        }
        public String TenLoaiHD
        {
            get
            {
                CanReadProperty("TenLoaiHD", true);
                return _tenLoaiHD;
            }
            set
            {
                CanWriteProperty("TenLoaiHD", true);
                if (_tenLoaiHD != value)
                {
                    _tenLoaiHD = value;
                    PropertyHasChanged("TenLoaiHD");
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

        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public Boolean GioiTinh
        {
            get
            {

                return _gioitinh;
            }
            set
            {
                if (_gioitinh != value)
                {
                    _gioitinh = value;
                }
            }
        }
        public String GioiTinhD
        {
            get
            {

                if (_gioitinh == true)
                {
                    return "Nam";
                }
                else
                    return "Nữ";

            }

        }
        public String TenPNNghe1
        {
            get
            {
                CanReadProperty("TenPNNghe1", true);
                return _tenPNNghe1;
            }
            set
            {
                CanWriteProperty("TenPNNghe1", true);
                if (_tenPNNghe1 != value)
                {
                    _tenPNNghe1 = value;
                    PropertyHasChanged("TenPNNghe1");
                }
            }
        }
        public String TenPNNghe2
        {
            get
            {
                CanReadProperty("TenPNNghe2", true);
                return _tenPNNghe2;
            }
            set
            {
                CanWriteProperty("TenPNNghe2", true);
                if (_tenPNNghe2 != value)
                {
                    _tenPNNghe2 = value;
                    PropertyHasChanged("TenPNNghe2");
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
        public String MaNgach
        {
            get
            {
                CanReadProperty("MaNgach", true);
                return _maNgach;
            }
            set
            {
                CanWriteProperty("MaNgach", true);
                if (_maNgach != value)
                {
                    _maNgach = value;
                    PropertyHasChanged("MaNgach");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _sTT.ToString() + "!" + _thang.ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="Luong_Nghe" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static Luong_Nghe NewLuong_Nghe()
        {
            return new Luong_Nghe();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_Nghe GetLuong_Nghe(SafeDataReader dr, int i)
        {
            return new Luong_Nghe(dr, i);
        }
        //public static Luong_Nghe GetLuong_Nghe(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_Nghe>(new Criteria(sTT, thang));
        //}
        public Luong_Nghe()
        {
            MarkAsChild();
        }
        /// <summary>
        /// Marks the <see cref="Luong_Nghe" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteLuong_Nghe(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_Nghe()
        //{	
        //    // Prevent direct creation
        //}

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
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

            public Criteria(Int32 sTT, SmartDate thang)
            {
                _sTT = sTT;
                _thang = thang;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    if (!_thang.Equals(c._thang))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _sTT.ToString(), _thang.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class CriteriaOther
        {
            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
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
            public CriteriaOther(String Mamay, String Nguoisd, Int32 sTT, SmartDate thang)
            {
                _sTT = sTT;
                _thang = thang;
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
        /// Retrieve an existing <see cref="Luong_Nghe" /> Object based on data in the database.
        /// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_Nghe(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_Nghe(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_Nghe(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        /// <summary>
        /// Load a <see cref="Luong_Nghe" /> Object from given SafeDataReader.
        /// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_NgheCB") != null) _mucLuong_NgheCB = dr.GetDecimal("MucLuong_NgheCB");
        //    if (dr.GetDecimal("HeSoLuong_Nghe") != null) _heSoLuong_Nghe = dr.GetDecimal("HeSoLuong_Nghe");
        //    if (dr.GetDecimal("HeSoPC") != null) _heSoPC = dr.GetDecimal("HeSoPC");
        //    if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
        //    if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
        //    if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
        //    if (dr.GetDecimal("AnToi") != null) _anToi = dr.GetDecimal("AnToi");
        //    if (dr.GetDecimal("AnTrua") != null) _anTrua = dr.GetDecimal("AnTrua");
        //    if (dr.GetDecimal("HeSoDocHai") != null) _heSoDocHai = dr.GetDecimal("HeSoDocHai");
        //    if (dr.GetDecimal("MucPCBoiDuong") != null) _mucPCBoiDuong = dr.GetDecimal("MucPCBoiDuong");
        //    if (dr.GetDecimal("HeSoPCTrachNhiem") != null) _heSoPCTrachNhiem = dr.GetDecimal("HeSoPCTrachNhiem");
        //    if (dr.GetDecimal("TienNgoaiGio") != null) _tienNgoaiGio = dr.GetDecimal("TienNgoaiGio");
        //    if (dr.GetDecimal("TienPC") != null) _tienPC = dr.GetDecimal("TienPC");
        //    if (dr.GetDecimal("TienTruc") != null) _tienTruc = dr.GetDecimal("TienTruc");
        //    if (dr.GetDecimal("TienLamDem") != null) _tienLamDem = dr.GetDecimal("TienLamDem");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //}
        private Luong_Nghe(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetDecimal("HeSoNghe2") != null) _heSoNghe2 = dr.GetDecimal("HeSoNghe2");
            if (dr.GetString("MaPCNghe1") != null) _maPCNghe1 = dr.GetString("MaPCNghe1");
            if (dr.GetString("MaPCNghe2") != null) _maPCNghe2 = dr.GetString("MaPCNghe2");
            if (dr.GetDecimal("HeSoNghe1") != null) _heSoNghe1 = dr.GetDecimal("HeSoNghe1");
            if (dr.GetDecimal("NgayNghe1") != null) _ngayNghe1 = dr.GetDecimal("NgayNghe1");
            if (dr.GetDecimal("NgayNghe2") != null) _ngayNghe2 = dr.GetDecimal("NgayNghe2");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
            if (dr.GetDecimal("HeSoChucVu") != null) _heSoChucVu = dr.GetDecimal("HeSoChucVu");
            if (dr.GetDecimal("HeSoVK") != null) _heSoVK = dr.GetDecimal("HeSoVK");
            if (dr.GetDecimal("MucLuongCB") != null) _mucLuongCB = dr.GetDecimal("MucLuongCB");
            if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("HOTEN") != null) _hoten = dr.GetString("HOTEN");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("TenLoaiHD") != null) _tenLoaiHD = dr.GetString("NguoiSD1");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetBoolean("GioiTinh") != null) _gioitinh = dr.GetBoolean("GioiTinh");
            if (dr.GetString("TenPNNghe1") != null) _tenPNNghe1 = dr.GetString("TenPNNghe1");
            if (dr.GetString("TenPNNghe2") != null) _tenPNNghe2 = dr.GetString("TenPNNghe2");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("MANGACH") != null) _maNgach = dr.GetString("MANGACH"); 


            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="Luong_Nghe" /> Object to underlying database.
        /// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_Nghe(_thang, _maNV, _makhoa, _heSoNghe2, _maPCNghe1, _maPCNghe2, _heSoNghe1, _ngayNghe1, _ngayNghe2, _heSo, _heSoChucVu, _heSoVK, _mucLuongCB, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract Int32 InsertLuong_Nghe(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_Nghe(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiLap)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_Nghe_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSoDieuDuong, _heSoCKCI, _heSoNT, _heSoHVK, _heSoDaiHoc, _heSoTrungCap, _heSoDuocTa, _namDiLam, _heSoThamNien, _maMay, _nguoiSD);
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="Luong_Nghe" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateLuong_Nghe(_sTT, _thang, _maNV, _makhoa, _heSoNghe2, _maPCNghe1, _maPCNghe2, _heSoNghe1, _ngayNghe1, _ngayNghe2, _heSo, _heSoChucVu, _heSoVK, _mucLuongCB, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
            // public abstract void UpdateLuong_Nghe(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiSD, Boolean _huy);
            // public override void UpdateLuong_Nghe(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiSD, Boolean _huy)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_Nghe_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSoDieuDuong, _heSoCKCI, _heSoNT, _heSoHVK, _heSoDaiHoc, _heSoTrungCap, _heSoDuocTa, _namDiLam, _heSoThamNien, _maMay, _nguoiSD , _huy);
            // }				
            MarkOld();
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _sTT, _thang));
            MarkNew();
        }

        /// <summary>
        /// Delete the <see cref="Luong_Nghe" />.
        /// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_Nghe
            DataProvider.Instance().DeleteLuong_Nghe(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
            // public abstract void DeleteLuong_Nghe(Int32 _sTT, SmartDate _thang);
            // public override void DeleteLuong_Nghe(Int32 _sTT, SmartDate _thang);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_Nghe_DELETED", _sTT, _thang);
            // }
        }

        #endregion
    }

}
