// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Bong
// Kieu doi tuong  :	BenhAn_Bong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/8/2009 2:28:41 PM
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


namespace HTC.Business.NoiTru
{

    /// <summary>
    /// This is a base generated class of <see cref="BenhAn_Bong" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhAn_Bong : BusinessBase<BenhAn_Bong>
    {
        #region Business Methods

        #region State Fields

        private String _maBA = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
        private String _bSKHAM = String.Empty;
        private String _lyDoKham = String.Empty;
        private String _mach = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _nhipTho = String.Empty;
        private String _canNang = String.Empty;
        private String _chieuCao = String.Empty;

        private String _toanThan = String.Empty;
        //private String _benhChuyenKhoa = String.Empty;
        private String _cqtuanhoan = String.Empty;
        private String _cqhohap = String.Empty;
        private String _cqtieuhoa = String.Empty;
        //private String _cqtietnieu = String.Empty;
        private String _cqtamthan = String.Empty;
        private String _cqcoxuongkhop = String.Empty;
        private String _cqtietnieu = String.Empty;
        private String _cqsinhduc = String.Empty;
        //private String _mat = String.Empty;
        //private String _noitiet_dinhduong = String.Empty;
        private String _coQuanKhac = String.Empty;
        private String _tonThuong = String.Empty;


        private String _dieuTri = String.Empty;
        private String _benhSu = String.Empty;
        private String _huongDT = String.Empty;
        private String _mabenh = String.Empty;
        private String _maBenhKem = String.Empty;
        private String _machuyenkhoa = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;
        private int i;
      

        #endregion

        #region Business Properties and Methods

        public String MaBA
        {
            get
            {
                CanReadProperty("MaBA", true);
                return _maBA;
            }
            set
            {
                CanWriteProperty("MaBA", true);
                if (_maBA != value)
                {
                    _maBA = value;
                    PropertyHasChanged("MaBA");
                }
            }
        }


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

        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _sTTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                    PropertyHasChanged("STTKhoa");
                }
            }
        }

        public string NgayKham
        {
            get
            {
                CanReadProperty("NgayKham", true);

                return _ngayKham.Text;
            }
            set
            {
                CanWriteProperty("NgayKham", true);
                if (_ngayKham.Text != value)
                {
                    _ngayKham.Text = value;
                    PropertyHasChanged("NgayKham");
                }
            }
        }
        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham;
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";

                return _ngayKhamD.Text;
            }

        }
        public String BSKHAM
        {
            get
            {
                CanReadProperty("BSKHAM", true);
                return _bSKHAM;
            }
            set
            {
                CanWriteProperty("BSKHAM", true);
                if (_bSKHAM != value)
                {
                    _bSKHAM = value;
                    PropertyHasChanged("BSKHAM");
                }
            }
        }

        public String LyDoKham
        {
            get
            {
                CanReadProperty("LyDoKham", true);
                return _lyDoKham;
            }
            set
            {
                CanWriteProperty("LyDoKham", true);
                if (_lyDoKham != value)
                {
                    _lyDoKham = value;
                    PropertyHasChanged("LyDoKham");
                }
            }
        }

        public String Mach
        {
            get
            {
                CanReadProperty("Mach", true);
                return _mach;
            }
            set
            {
                CanWriteProperty("Mach", true);
                if (_mach != value)
                {
                    _mach = value;
                    PropertyHasChanged("Mach");
                }
            }
        }

        public String ApHuyet
        {
            get
            {
                CanReadProperty("ApHuyet", true);
                return _apHuyet;
            }
            set
            {
                CanWriteProperty("ApHuyet", true);
                if (_apHuyet != value)
                {
                    _apHuyet = value;
                    PropertyHasChanged("ApHuyet");
                }
            }
        }

        public String NhietDo
        {
            get
            {
                CanReadProperty("NhietDo", true);
                return _nhietDo;
            }
            set
            {
                CanWriteProperty("NhietDo", true);
                if (_nhietDo != value)
                {
                    _nhietDo = value;
                    PropertyHasChanged("NhietDo");
                }
            }
        }

        public String NhipTho
        {
            get
            {
                CanReadProperty("NhipTho", true);
                return _nhipTho;
            }
            set
            {
                CanWriteProperty("NhipTho", true);
                if (_nhipTho != value)
                {
                    _nhipTho = value;
                    PropertyHasChanged("NhipTho");
                }
            }
        }

        public String CanNang
        {
            get
            {
                CanReadProperty("CanNang", true);
                return _canNang;
            }
            set
            {
                CanWriteProperty("CanNang", true);
                if (_canNang != value)
                {
                    _canNang = value;
                    PropertyHasChanged("CanNang");
                }
            }
        }

        public String ChieuCao
        {
            get
            {
                CanReadProperty("ChieuCao", true);
                return _chieuCao;
            }
            set
            {
                CanWriteProperty("ChieuCao", true);
                if (_chieuCao != value)
                {
                    _chieuCao = value;
                    PropertyHasChanged("ChieuCao");
                }
            }
        }

        public String ToanThan
        {
            get
            {
                CanReadProperty("ToanThan", true);
                return _toanThan;
            }
            set
            {
                CanWriteProperty("ToanThan", true);
                if (_toanThan != value)
                {
                    _toanThan = value;
                    PropertyHasChanged("ToanThan");
                }
            }
        }

        //public String BenhChuyenKhoa
        //{
        //    get
        //    {
        //        CanReadProperty("BenhChuyenKhoa", true);
        //        return _benhChuyenKhoa;
        //    }
        //    set
        //    {
        //        CanWriteProperty("BenhChuyenKhoa", true);
        //        if (_benhChuyenKhoa != value)
        //        {
        //            _benhChuyenKhoa = value;
        //            PropertyHasChanged("BenhChuyenKhoa");
        //        }
        //    }
        //}

        public String cqtuanhoan
        {
            get
            {
                CanReadProperty("cqtuanhoan", true);
                return _cqtuanhoan;
            }
            set
            {
                CanWriteProperty("cqtuanhoan", true);
                if (_cqtuanhoan != value)
                {
                    _cqtuanhoan = value;
                    PropertyHasChanged("cqtuanhoan");
                }
            }
        }

        public String cqhohap
        {
            get
            {
                CanReadProperty("cqhohap", true);
                return _cqhohap;
            }
            set
            {
                CanWriteProperty("cqhohap", true);
                if (_cqhohap != value)
                {
                    _cqhohap = value;
                    PropertyHasChanged("cqhohap");
                }
            }
        }
        public String cqtieuhoa
        {
            get
            {
                CanReadProperty("cqtieuhoa", true);
                return _cqtieuhoa;
            }
            set
            {
                CanWriteProperty("cqtieuhoa", true);
                if (_cqtieuhoa != value)
                {
                    _cqtieuhoa = value;
                    PropertyHasChanged("cqtieuhoa");
                }
            }
        }

        public String cqtietnieu
        {
            get
            {
                CanReadProperty("cqtietnieu", true);
                return _cqtietnieu;
            }
            set
            {
                CanWriteProperty("cqtietnieu", true);
                if (_cqtietnieu != value)
                {
                    _cqtietnieu = value;
                    PropertyHasChanged("cqtietnieu");
                }
            }
        }

        public String cqtamthan
        {
            get
            {
                CanReadProperty("cqtamthan", true);
                return _cqtamthan;
            }
            set
            {
                CanWriteProperty("cqtamthan", true);
                if (_cqtamthan != value)
                {
                    _cqtamthan = value;
                    PropertyHasChanged("cqtamthan");
                }
            }
        }

        public String cqcoxuongkhop
        {
            get
            {
                CanReadProperty("cqcoxuongkhop", true);
                return _cqcoxuongkhop;
            }
            set
            {
                CanWriteProperty("cqcoxuongkhop", true);
                if (_cqcoxuongkhop != value)
                {
                    _cqcoxuongkhop = value;
                    PropertyHasChanged("cqcoxuongkhop");
                }
            }
        }

        public String cqsinhduc
        {
            get
            {
                CanReadProperty("cqsinhduc", true);
                return _cqsinhduc;
            }
            set
            {
                CanWriteProperty("cqsinhduc", true);
                if (_cqsinhduc != value)
                {
                    _cqsinhduc = value;
                    PropertyHasChanged("cqsinhduc");
                }
            }
        }
       
        //public String mat
        //{
        //    get
        //    {
        //        CanReadProperty("mat", true);
        //        return _mat;
        //    }
        //    set
        //    {
        //        CanWriteProperty("mat", true);
        //        if (_mat != value)
        //        {
        //            _mat = value;
        //            PropertyHasChanged("mat");
        //        }
        //    }
        //}

        //public String noitiet_dinhduong
        //{
        //    get
        //    {
        //        CanReadProperty("noitiet_dinhduong", true);
        //        return _noitiet_dinhduong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("noitiet_dinhduong", true);
        //        if (_noitiet_dinhduong != value)
        //        {
        //            _noitiet_dinhduong = value;
        //            PropertyHasChanged("noitiet_dinhduong");
        //        }
        //    }
        //}


        public String CoQuanKhac
        {
            get
            {
                CanReadProperty("CoQuanKhac", true);
                return _coQuanKhac;
            }
            set
            {
                CanWriteProperty("CoQuanKhac", true);
                if (_coQuanKhac != value)
                {
                    _coQuanKhac = value;
                    PropertyHasChanged("CoQuanKhac");
                }
            }
        }
        public String tonThuong
        {
            get
            {
                CanReadProperty("tonThuong", true);
                return _tonThuong;
            }
            set
            {
                CanWriteProperty("tonThuong", true);
                if (_tonThuong != value)
                {
                    _tonThuong = value;
                    PropertyHasChanged("tonThuong");
                }
            }
        }

        public String DieuTri
        {
            get
            {
                CanReadProperty("DieuTri", true);
                return _dieuTri;
            }
            set
            {
                CanWriteProperty("DieuTri", true);
                if (_dieuTri != value)
                {
                    _dieuTri = value;
                    PropertyHasChanged("DieuTri");
                }
            }
        }

        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _benhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_benhSu != value)
                {
                    _benhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }

        public String HuongDT
        {
            get
            {
                CanReadProperty("HuongDT", true);
                return _huongDT;
            }
            set
            {
                CanWriteProperty("HuongDT", true);
                if (_huongDT != value)
                {
                    _huongDT = value;
                    PropertyHasChanged("HuongDT");
                }
            }
        }

        public String Mabenh
        {
            get
            {
                CanReadProperty("Mabenh", true);
                return _mabenh;
            }
            set
            {
                CanWriteProperty("Mabenh", true);
                if (_mabenh != value)
                {
                    _mabenh = value;
                    PropertyHasChanged("Mabenh");
                }
            }
        }

        public String MaBenhKem
        {
            get
            {
                CanReadProperty("MaBenhKem", true);
                return _maBenhKem;
            }
            set
            {
                CanWriteProperty("MaBenhKem", true);
                if (_maBenhKem != value)
                {
                    _maBenhKem = value;
                    PropertyHasChanged("MaBenhKem");
                }
            }
        }

        public String Machuyenkhoa
        {
            get
            {
                CanReadProperty("Machuyenkhoa", true);
                return _machuyenkhoa;
            }
            set
            {
                CanWriteProperty("Machuyenkhoa", true);
                if (_machuyenkhoa != value)
                {
                    _machuyenkhoa = value;
                    PropertyHasChanged("Machuyenkhoa");
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

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenBenhKem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenBenhKem != value)
                {
                    _tenBenhKem = value;
                    PropertyHasChanged("TenBenhKem");
                }
            }
        }
        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
                }
            }
        }
        public String MaICDKem
        {
            get
            {
                CanReadProperty("MaICDKem", true);
                return _maICDKem;
            }
            set
            {
                CanWriteProperty("MaICDKem", true);
                if (_maICDKem != value)
                {
                    _maICDKem = value;
                    PropertyHasChanged("MaICDKem");
                }
            }
        }
        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
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
            return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_Bong" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_Bong NewBenhAn_Bong()
        {
            return DataPortal.Create<BenhAn_Bong>();
        }
        public static BenhAn_Bong GetBenhAn_Bong(String maBA, Int32 sTT, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_Bong>(new Criteria(maBA, sTT, sTTKhoa));
        }

        /// <summary>
        /// Marks the <see cref="BenhAn_Bong" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhAn_Bong(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, sTT, sTTKhoa));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhAn_Bong()
        {
            // Prevent direct creation
        }

        internal BenhAn_Bong(int OrderNumber,
                                 String maBA,
                                 Int32 sTT,
                                 Int32 sTTKhoa,
                                 SmartDate ngayKham,
                                 String bSKHAM,
                                 String lyDoKham,
                                 String mach,
                                 String apHuyet,
                                 String nhietDo,
                                 String nhipTho,
                                 String canNang,
                                 String chieuCao,

                                String toanThan,
                                //String BenhNgoaiKhoa,
                               
                                String cqtuanhoan,
                                String cqhohap,
                                String cqtieuhoa,
                                String cqtietnieu,
                                String cqtamthan,
                                String cqcoxuongkhop,
                              
                                String cqSinhDuc,
                                //String mat,
                                //String noitiet_dingduong,
                                String CoQuanKhac,
                                String tonthuong,


                                 String dieuTri,
                                 String benhSu,
                                 String huongDT,
                                 String mabenh,
                                 String maBenhKem,
                                 String machuyenkhoa,
                                 String maMay,
                                 Boolean huy,
                                 SmartDate ngaySD,
                                 String nguoiSD,
                                 SmartDate ngaySD1,
                                 String nguoiSD1,
                                 String tenBenh,
                                 String tenBenhKem,
            //String maICD ,
                                 String maICDKem,
                                 String tenBSKham,
                                String tennguoisd
                               )
        {
            _OrderNumber = OrderNumber;
            _maBA = maBA;
            _sTT = sTT;
            _sTTKhoa = sTTKhoa;
            _ngayKham = ngayKham;
            _bSKHAM = bSKHAM;
            _lyDoKham = lyDoKham;
            _mach = mach;
            _apHuyet = apHuyet;
            _nhietDo = nhietDo;
            _nhipTho = nhipTho;
            _canNang = canNang;
            _chieuCao = chieuCao;

            _toanThan = toanThan;
            //_benhChuyenKhoa = BenhChuyenKhoa;
            _cqtuanhoan = cqtuanhoan;
            _cqhohap = cqhohap;
            _cqtieuhoa = cqtieuhoa;
            _cqtietnieu = cqtietnieu;
            _cqtamthan = cqtamthan;
            _cqcoxuongkhop = cqcoxuongkhop;
            //_tietnieu = TietNieu;
            _cqsinhduc = _cqsinhduc;
            //_mat = mat;
            //_noitiet_dinhduong = noitiet_dingduong;
            _coQuanKhac = CoQuanKhac;
            _tonThuong = tonthuong;


            _dieuTri = dieuTri;
            _benhSu = benhSu;
            _huongDT = huongDT;
            _mabenh = mabenh;
            _maBenhKem = maBenhKem;
            _machuyenkhoa = machuyenkhoa;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _tenBenh = tenBenh;
            _tenBenhKem = tenBenhKem;
            // _maICD = maICD ;
            _maICDKem = maICDKem;
            _tenBSKham = tenBSKham;
            _tennguoiSD = tennguoisd;
        }

      
            
        //public BenhAn_Bong(string p1, int p2, int p3, SmartDate smartDate1, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14, string p15, string p16, string p17, string p18, string p19, string p20, string p21, string p22, string p23, string p24, string p25, string p26, string p27, string p28, string p29, string p30, string p31, string p32, bool p33, SmartDate smartDate2, string p34, SmartDate smartDate3, string p35, string p36, string p37, string p38, string p39, string p40)
        //{
        //    // TODO: Complete member initialization
        //    this.p1 = p1;
        //    this.p2 = p2;
        //    this.p3 = p3;
        //    this.smartDate1 = smartDate1;
        //    this.p4 = p4;
        //    this.p5 = p5;
        //    this.p6 = p6;
        //    this.p7 = p7;
        //    this.p8 = p8;
        //    this.p9 = p9;
        //    this.p10 = p10;
        //    this.p11 = p11;
        //    this.p12 = p12;
        //    this.p13 = p13;
        //    this.p14 = p14;
        //    this.p15 = p15;
        //    this.p16 = p16;
        //    this.p17 = p17;
        //    this.p18 = p18;
        //    this.p19 = p19;
        //    this.p20 = p20;
        //    this.p21 = p21;
        //    this.p22 = p22;
        //    this.p23 = p23;
        //    this.p24 = p24;
        //    this.p25 = p25;
        //    this.p26 = p26;
        //    this.p27 = p27;
        //    this.p28 = p28;
        //    this.p29 = p29;
        //    this.p30 = p30;
        //    this.p31 = p31;
        //    this.p32 = p32;
        //    this.p33 = p33;
        //    this.smartDate2 = smartDate2;
        //    this.p34 = p34;
        //    this.smartDate3 = smartDate3;
        //    this.p35 = p35;
        //    this.p36 = p36;
        //    this.p37 = p37;
        //    this.p38 = p38;
        //    this.p39 = p39;
        //    this.p40 = p40;
        //}

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }

            public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    if (!_sTTKhoa.Equals(c._sTTKhoa))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
        /// Retrieve an existing <see cref="BenhAn_Bong" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Bong_GET", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Bong(crit.MaBA, crit.STT, crit.STTKhoa)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="BenhAn_Bong" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
            if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
            if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
            if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
            if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");

            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
            //if (dr.GetString("BenhChuyenKhoa") != null) _benhChuyenKhoa = dr.GetString("BenhChuyenKhoa");
            if (dr.GetString("cqtuanhoan") != null) _cqtuanhoan = dr.GetString("cqtuanhoan");
            if (dr.GetString("cqhohap") != null) _cqhohap = dr.GetString("cqhohap");
            if (dr.GetString("cqtieuhoa") != null) _cqtieuhoa = dr.GetString("cqtieuhoa");
            if (dr.GetString("cqtietnieu") != null) _cqtietnieu = dr.GetString("cqtietnieu");
            if (dr.GetString("cqtamthan") != null) _cqtamthan = dr.GetString("cqtamthan");
            if (dr.GetString("cqcoxuongkhop") != null) _cqcoxuongkhop = dr.GetString("cqcoxuongkhop");

            if (dr.GetString("cqSinhDuc") != null) _cqsinhduc = dr.GetString("cqSinhDuc");
            //if (dr.GetString("mat") != null) _mat = dr.GetString("mat");
            //if (dr.GetString("noitiet_dinhduong") != null) _noitiet_dinhduong = dr.GetString("noitiet_dinhduong");
            if (dr.GetString("CoQuanKhac") != null) _coQuanKhac = dr.GetString("CoQuanKhac");
            if (dr.GetString("tonThuong") != null) _tonThuong = dr.GetString("tonThuong");


            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
            if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }

        /// <summary>
        /// Insert the new <see cref="BenhAn_Bong" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_Bong
            // Copy & paste ham duoi day vao file DataProvider.cs
            _maBA  = DataProvider.Instance().InsertBenhAn_Bong(_maBA,  _sTTKhoa, _ngayKham,_bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _tonThuong, _cqtamthan, _cqtuanhoan, _cqhohap, _cqtieuhoa, _cqcoxuongkhop, _cqtietnieu, _cqsinhduc, _coQuanKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem,_machuyenkhoa, _maMay, _nguoiSD);
            // public abstract String InsertBenhAn_Bong(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa,String _cqtuanhoan,String _cqhohap,String _cqtieuhoa, String _cqtietnieu,String _cqtamthan,String _cqcoxuongkhop,String _tietnieu,String _sinhduc,String _mat,String _noitiet_dinhduong, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_Bong(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa,String _cqtuanhoan,String _cqhohap,String _cqtieuhoa, String _cqtietnieu,String _cqtamthan,String _cqcoxuongkhop,String _tietnieu,String _sinhduc,String _mat,String _noitiet_dinhduong, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Bong_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhChuyenKhoa,_cqtuanhoan,_cqhohap, _cqtieuhoa,  _cqtietnieu, _cqtamthan, _cqcoxuongkhop, _tietnieu, _sinhduc, _mat, _noitiet_dinhduong, _coQuanKhac, _tonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="BenhAn_Bong" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Bong
            if (IsDirty)
            {
                DataProvider.Instance().UpdateBenhAn_Bong(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKHAM,_lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _tonThuong, _cqtamthan, _cqtuanhoan, _cqhohap, _cqtieuhoa, _cqcoxuongkhop, _cqtietnieu, _cqsinhduc, _coQuanKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String_cqtuanhoan,String_cqhohap, String_cqtieuhoa,  String_cqtietnieu, String_cqtamthan, String_cqcoxuongkhop, String_TietNieu, String_SinhDuc, String_mat, String_noitiet_dinhduong, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa,String_cqtuanhoan,String_cqhohap,String _cqtieuhoa, String _cqtietnieu,String _cqtamthan,String _cqcoxuongkhop,String _tietnieu,String _sinhduc, String _mat,String _noitiet_dinhduong, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Bong_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhChuyenKhoa, _coQuanKhac, _tonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD, _maBA, _sTT, _sTTKhoa));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_Bong" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Bong
            DataProvider.Instance().DeleteBenhAn_Bong(crit.MaMay, crit.NguoiSD, crit.maBA, crit.STT, crit.STTKhoa);
            // public abstract void DeleteBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Bong_Deleted", _maBA, _sTT, _sTTKhoa);
            // }
        }

        #endregion
    }

}
