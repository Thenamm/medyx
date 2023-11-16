// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Mat
// Kieu doi tuong  :	BenhAn_Mat
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
    /// This is a base generated class of <see cref="BenhAn_Mat" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhAn_Mat : BusinessBase<BenhAn_Mat>
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
        private String _thiLucVV = String.Empty;
        private String _khongKinhMP = String.Empty;
        private String _khongKinhMT = String.Empty;
        private String _coKinhMP = String.Empty;
        private String _coKinhMT = String.Empty;
        private String _nhanAPMP = String.Empty;
        private String _nhanApMT = String.Empty;
        private String _thiTruongMP = String.Empty;
        private String _thiTruongMT = String.Empty;





        private String _leDaoMP = String.Empty;
        private String _leDaoMT = String.Empty;
        private String _miMatMP = String.Empty;
        private String _miMatMT = String.Empty;
        private String _ketMacMP = String.Empty;
        private String _ketMacMT = String.Empty;
        private String _matHotMP = String.Empty;
        private String _matHotMT = String.Empty;
        private String _giaMacMP = String.Empty;
        private String _giaMacMT = String.Empty;
        private String _cungMacMP = String.Empty;
        private String _cungMacMT = String.Empty;
        private String _tTTienPhongMP = String.Empty;
        private String _tTTienPhongMT = String.Empty;
        private String _tTMongMatMP = String.Empty;
        private String _tTMongMatMT = String.Empty;
        private String _tTDongTuPXMP = String.Empty;
        private String _tTDongTuPXMT = String.Empty;
        private String _tTThuyTinhTheMP = String.Empty;
        private String _tTThuyTinhTheMT = String.Empty;
        private String _tTThuyTinhDichMP = String.Empty;
        private String _tTThuyTinhDichMT = String.Empty;
        private String _tTSADongTuMP = String.Empty;
        private String _tTSADongTuMT = String.Empty;
        private String _tTNhanCauMP = String.Empty;
        private String _tTNhanCauMT = String.Empty;
        private String _tTHocMatMP = String.Empty;
        private String _tTHocMatMT = String.Empty;
        private String _tTDayMatMP = String.Empty;
        private String _tTDayMatMT = String.Empty;
        private String _khamToanThan = String.Empty;
        private String _cQNoiTiet = String.Empty;
        private String _cQTamThan = String.Empty;
        private String _cQTuanHoan = String.Empty;
        private String _cQHoHap = String.Empty;
        private String _cQTieuHoa = String.Empty;
        private String _cQCXKhop = String.Empty;
        private String _cQTietNieuSD = String.Empty;
        private String _coQuanKhac = String.Empty;
        private String _dieuTri = String.Empty;
        private String _benhSu = String.Empty;
        private String _mabenh = String.Empty;
        private String _maBenhKem = String.Empty;
        private String _phanBiet = String.Empty;
        private String _tienLuong = String.Empty;
        private String _huongDT = String.Empty;
        private String _tomtatBA = String.Empty;
        private String _cacxncls = String.Empty;
        private String _machuyenkhoa = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
      
      
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

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
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";
                _ngayKhamD = _ngayKham;
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

        public String ThiLucVV
        {
            get
            {
                CanReadProperty("ThiLucVV", true);
                return _thiLucVV;
            }
            set
            {
                CanWriteProperty("ThiLucVV", true);
                if (_thiLucVV != value)
                {
                    _thiLucVV = value;
                    PropertyHasChanged("ThiLucVV");
                }
            }
        }

        public String KhongKinhMP
        {
            get
            {
                CanReadProperty("KhongKinhMP", true);
                return _khongKinhMP;
            }
            set
            {
                CanWriteProperty("KhongKinhMP", true);
                if (_khongKinhMP != value)
                {
                    _khongKinhMP = value;
                    PropertyHasChanged("KhongKinhMP");
                }
            }
        }

        public String KhongKinhMT
        {
            get
            {
                CanReadProperty("KhongKinhMT", true);
                return _khongKinhMT;
            }
            set
            {
                CanWriteProperty("KhongKinhMT", true);
                if (_khongKinhMT != value)
                {
                    _khongKinhMT = value;
                    PropertyHasChanged("KhongKinhMT");
                }
            }
        }

        public String CoKinhMP
        {
            get
            {
                CanReadProperty("CoKinhMP", true);
                return _coKinhMP;
            }
            set
            {
                CanWriteProperty("CoKinhMP", true);
                if (_coKinhMP != value)
                {
                    _coKinhMP = value;
                    PropertyHasChanged("CoKinhMP");
                }
            }
        }

        public String CoKinhMT
        {
            get
            {
                CanReadProperty("CoKinhMT", true);
                return _coKinhMT;
            }
            set
            {
                CanWriteProperty("CoKinhMT", true);
                if (_coKinhMT != value)
                {
                    _coKinhMT = value;
                    PropertyHasChanged("CoKinhMT");
                }
            }
        }

        public String NhanAPMP
        {
            get
            {
                CanReadProperty("NhanAPMP", true);
                return _nhanAPMP;
            }
            set
            {
                CanWriteProperty("NhanAPMP", true);
                if (_nhanAPMP != value)
                {
                    _nhanAPMP = value;
                    PropertyHasChanged("NhanAPMP");
                }
            }
        }

        public String NhanApMT
        {
            get
            {
                CanReadProperty("NhanApMT", true);
                return _nhanApMT;
            }
            set
            {
                CanWriteProperty("NhanApMT", true);
                if (_nhanApMT != value)
                {
                    _nhanApMT = value;
                    PropertyHasChanged("NhanApMT");
                }
            }
        }

        public String ThiTruongMP
        {
            get
            {
                CanReadProperty("ThiTruongMP", true);
                return _thiTruongMP;
            }
            set
            {
                CanWriteProperty("ThiTruongMP", true);
                if (_thiTruongMP != value)
                {
                    _thiTruongMP = value;
                    PropertyHasChanged("ThiTruongMP");
                }
            }
        }

        public String ThiTruongMT
        {
            get
            {
                CanReadProperty("ThiTruongMT", true);
                return _thiTruongMT;
            }
            set
            {
                CanWriteProperty("ThiTruongMT", true);
                if (_thiTruongMT != value)
                {
                    _thiTruongMT = value;
                    PropertyHasChanged("ThiTruongMT");
                }
            }
        }


        public String LeDaoMP
        {
            get
            {
                CanReadProperty("LeDaoMP", true);
                return _leDaoMP;
            }
            set
            {
                CanWriteProperty("LeDaoMP", true);
                if (_leDaoMP != value)
                {
                    _leDaoMP = value;
                    PropertyHasChanged("LeDaoMP");
                }
            }
        }
        public String LeDaoMT
        {
            get
            {
                CanReadProperty("LeDaoMT", true);
                return _leDaoMT;
            }
            set
            {
                CanWriteProperty("LeDaoMT", true);
                if (_leDaoMT != value)
                {
                    _leDaoMT = value;
                    PropertyHasChanged("LeDaoMT");
                }
            }
        }
        public String MiMatMP
        {
            get
            {
                CanReadProperty("MiMatMP", true);
                return _miMatMP;
            }
            set
            {
                CanWriteProperty("MiMatMP", true);
                if (_miMatMP != value)
                {
                    _miMatMP = value;
                    PropertyHasChanged("MiMatMP");
                }
            }
        }
        public String MiMatMT
        {
            get
            {
                CanReadProperty("MiMatMT", true);
                return _miMatMT;
            }
            set
            {
                CanWriteProperty("MiMatMT", true);
                if (_miMatMT != value)
                {
                    _miMatMT = value;
                    PropertyHasChanged("MiMatMT");
                }
            }
        }
        public String KetMacMP
        {
            get
            {
                CanReadProperty("KetMacMP", true);
                return _ketMacMP;
            }
            set
            {
                CanWriteProperty("KetMacMP", true);
                if (_ketMacMP != value)
                {
                    _ketMacMP = value;
                    PropertyHasChanged("KetMacMP");
                }
            }
        }
        public String KetMacMT
        {
            get
            {
                CanReadProperty("KetMacMT", true);
                return _ketMacMT;
            }
            set
            {
                CanWriteProperty("KetMacMT", true);
                if (_ketMacMT != value)
                {
                    _ketMacMT = value;
                    PropertyHasChanged("KetMacMT");
                }
            }
        }
        public String MatHotMP
        {
            get
            {
                CanReadProperty("MatHotMP", true);
                return _matHotMP;
            }
            set
            {
                CanWriteProperty("MatHotMP", true);
                if (_matHotMP != value)
                {
                    _matHotMP = value;
                    PropertyHasChanged("MatHotMP");
                }
            }
        }
        public String MatHotMT
        {
            get
            {
                CanReadProperty("MatHotMT", true);
                return _matHotMT;
            }
            set
            {
                CanWriteProperty("MatHotMT", true);
                if (_matHotMT != value)
                {
                    _matHotMT = value;
                    PropertyHasChanged("MatHotMT");
                }
            }
        }
        public String GiaMacMP
        {
            get
            {
                CanReadProperty("GiaMacMP", true);
                return _giaMacMP;
            }
            set
            {
                CanWriteProperty("GiaMacMP", true);
                if (_giaMacMP != value)
                {
                    _giaMacMP = value;
                    PropertyHasChanged("GiaMacMP");
                }
            }
        }
        public String GiaMacMT
        {
            get
            {
                CanReadProperty("GiaMacMT", true);
                return _giaMacMT;
            }
            set
            {
                CanWriteProperty("GiaMacMT", true);
                if (_giaMacMT != value)
                {
                    _giaMacMT = value;
                    PropertyHasChanged("GiaMacMT");
                }
            }
        }
        public String CungMacMP
        {
            get
            {
                CanReadProperty("CungMacMP", true);
                return _cungMacMP;
            }
            set
            {
                CanWriteProperty("CungMacMP", true);
                if (_cungMacMP != value)
                {
                    _cungMacMP = value;
                    PropertyHasChanged("CungMacMP");
                }
            }
        }
        public String CungMacMT
        {
            get
            {
                CanReadProperty("CungMacMT", true);
                return _cungMacMT;
            }
            set
            {
                CanWriteProperty("CungMacMT", true);
                if (_cungMacMT != value)
                {
                    _cungMacMT = value;
                    PropertyHasChanged("CungMacMT");
                }
            }
        }

        public String TTTienPhongMP
        {
            get
            {
                CanReadProperty("TTTienPhongMP", true);
                return _tTTienPhongMP;
            }
            set
            {
                CanWriteProperty("TTTienPhongMP", true);
                if (_tTTienPhongMP != value)
                {
                    _tTTienPhongMP = value;
                    PropertyHasChanged("TTTienPhongMP");
                }
            }
        }


        public String TTTienPhongMT
        {
            get
            {
                CanReadProperty("TTTienPhongMT", true);
                return _tTTienPhongMT;
            }
            set
            {
                CanWriteProperty("TTTienPhongMT", true);
                if (_tTTienPhongMT != value)
                {
                    _tTTienPhongMT = value;
                    PropertyHasChanged("TTTienPhongMT");
                }
            }
        }
        public String TTMongMatMP
        {
            get
            {
                CanReadProperty("TTMongMatMP", true);
                return _tTMongMatMP;
            }
            set
            {
                CanWriteProperty("TTMongMatMP", true);
                if (_tTMongMatMP != value)
                {
                    _tTMongMatMP = value;
                    PropertyHasChanged("TTMongMatMP");
                }
            }
        }
        public String TTMongMatMT
        {
            get
            {
                CanReadProperty("TTMongMatMT", true);
                return _tTMongMatMT;
            }
            set
            {
                CanWriteProperty("TTMongMatMT", true);
                if (_tTMongMatMT != value)
                {
                    _tTMongMatMT = value;
                    PropertyHasChanged("TTMongMatMT");
                }
            }
        }
        public String TTDongTuPXMP
        {
            get
            {
                CanReadProperty("TTDongTuPXMP", true);
                return _tTDongTuPXMP;
            }
            set
            {
                CanWriteProperty("TTDongTuPXMP", true);
                if (_tTDongTuPXMP != value)
                {
                    _tTDongTuPXMP = value;
                    PropertyHasChanged("TTDongTuPXMP");
                }
            }
        }
        public String TTDongTuPXMT
        {
            get
            {
                CanReadProperty("TTDongTuPXMT", true);
                return _tTDongTuPXMT;
            }
            set
            {
                CanWriteProperty("TTDongTuPXMT", true);
                if (_tTDongTuPXMT != value)
                {
                    _tTDongTuPXMT = value;
                    PropertyHasChanged("TTDongTuPXMT");
                }
            }
        }
        public String TTThuyTinhTheMP
        {
            get
            {
                CanReadProperty("TTThuyTinhTheMP", true);
                return _tTThuyTinhTheMP;
            }
            set
            {
                CanWriteProperty("TTThuyTinhTheMP", true);
                if (_tTThuyTinhTheMP != value)
                {
                    _tTThuyTinhTheMP = value;
                    PropertyHasChanged("TTThuyTinhTheMP");
                }
            }
        }
        public String TTThuyTinhTheMT
        {
            get
            {
                CanReadProperty("TTThuyTinhTheMT", true);
                return _tTThuyTinhTheMT;
            }
            set
            {
                CanWriteProperty("TTThuyTinhTheMT", true);
                if (_tTThuyTinhTheMT != value)
                {
                    _tTThuyTinhTheMT = value;
                    PropertyHasChanged("TTThuyTinhTheMT");
                }
            }
        }
        public String TTThuyTinhDichMP
        {
            get
            {
                CanReadProperty("TTThuyTinhDichMP", true);
                return _tTThuyTinhDichMP;
            }
            set
            {
                CanWriteProperty("TTThuyTinhDichMP", true);
                if (_tTThuyTinhDichMP != value)
                {
                    _tTThuyTinhDichMP = value;
                    PropertyHasChanged("TTThuyTinhDichMP");
                }
            }
        }
        public String TTThuyTinhDichMT
        {
            get
            {
                CanReadProperty("TTThuyTinhDichMT", true);
                return _tTThuyTinhDichMT;
            }
            set
            {
                CanWriteProperty("TTThuyTinhDichMT", true);
                if (_tTThuyTinhDichMT != value)
                {
                    _tTThuyTinhDichMT = value;
                    PropertyHasChanged("TTThuyTinhDichMT");
                }
            }
        }
        public String TTSADongTuMP
        {
            get
            {
                CanReadProperty("TTSADongTuMP", true);
                return _tTSADongTuMP;
            }
            set
            {
                CanWriteProperty("TTSADongTuMP", true);
                if (_tTSADongTuMP != value)
                {
                    _tTSADongTuMP = value;
                    PropertyHasChanged("TTSADongTuMP");
                }
            }
        }
        public String TTSADongTuMT
        {
            get
            {
                CanReadProperty("TTSADongTuMT", true);
                return _tTSADongTuMT;
            }
            set
            {
                CanWriteProperty("TTSADongTuMT", true);
                if (_tTSADongTuMT != value)
                {
                    _tTSADongTuMT = value;
                    PropertyHasChanged("TTSADongTuMT");
                }
            }
        }
        public String TTNhanCauMP
        {
            get
            {
                CanReadProperty("TTNhanCauMP", true);
                return _tTNhanCauMP;
            }
            set
            {
                CanWriteProperty("TTNhanCauMP", true);
                if (_tTNhanCauMP != value)
                {
                    _tTNhanCauMP = value;
                    PropertyHasChanged("TTNhanCauMP");
                }
            }
        }
        public String TTNhanCauMT
        {
            get
            {
                CanReadProperty("TTNhanCauMT", true);
                return _tTNhanCauMT;
            }
            set
            {
                CanWriteProperty("TTNhanCauMT", true);
                if (_tTNhanCauMT != value)
                {
                    _tTNhanCauMT = value;
                    PropertyHasChanged("TTNhanCauMT");
                }
            }
        }
        public String TTHocMatMP
        {
            get
            {
                CanReadProperty("TTHocMatMP", true);
                return _tTHocMatMP;
            }
            set
            {
                CanWriteProperty("TTHocMatMP", true);
                if (_tTHocMatMP != value)
                {
                    _tTHocMatMP = value;
                    PropertyHasChanged("TTHocMatMP");
                }
            }
        }
        public String TTHocMatMT
        {
            get
            {
                CanReadProperty("TTHocMatMT", true);
                return _tTHocMatMT;
            }
            set
            {
                CanWriteProperty("TTHocMatMT", true);
                if (_tTHocMatMT != value)
                {
                    _tTHocMatMT = value;
                    PropertyHasChanged("TTHocMatMT");
                }
            }
        }
        public String TTDayMatMP
        {
            get
            {
                CanReadProperty("TTDayMatMP", true);
                return _tTDayMatMP;
            }
            set
            {
                CanWriteProperty("TTDayMatMP", true);
                if (_tTDayMatMP != value)
                {
                    _tTDayMatMP = value;
                    PropertyHasChanged("TTDayMatMP");
                }
            }
        }
        public String TTDayMatMT
        {
            get
            {
                CanReadProperty("TTDayMatMT", true);
                return _tTDayMatMT;
            }
            set
            {
                CanWriteProperty("TTDayMatMT", true);
                if (_tTDayMatMT != value)
                {
                    _tTDayMatMT = value;
                    PropertyHasChanged("TTDayMatMT");
                }
            }
        }
        public String KhamToanThan
        {
            get
            {
                CanReadProperty("KhamToanThan", true);
                return _khamToanThan;
            }
            set
            {
                CanWriteProperty("KhamToanThan", true);
                if (_khamToanThan != value)
                {
                    _khamToanThan = value;
                    PropertyHasChanged("KhamToanThan");
                }
            }
        }
        public String CQNoiTiet
        {
            get
            {
                CanReadProperty("CQNoiTiet", true);
                return _cQNoiTiet;
            }
            set
            {
                CanWriteProperty("CQNoiTiet", true);
                if (_cQNoiTiet != value)
                {
                    _cQNoiTiet = value;
                    PropertyHasChanged("CQNoiTiet");
                }
            }
        }
        public String CQTamThan
        {
            get
            {
                CanReadProperty("CQTamThan", true);
                return _cQTamThan;
            }
            set
            {
                CanWriteProperty("CQTamThan", true);
                if (_cQTamThan != value)
                {
                    _cQTamThan = value;
                    PropertyHasChanged("CQTamThan");
                }
            }
        }
        public String CQTuanHoan
        {
            get
            {
                CanReadProperty("CQTuanHoan", true);
                return _cQTuanHoan;
            }
            set
            {
                CanWriteProperty("CQTuanHoan", true);
                if (_cQTuanHoan != value)
                {
                    _cQTuanHoan = value;
                    PropertyHasChanged("CQTuanHoan");
                }
            }
        }
        public String CQHoHap
        {
            get
            {
                CanReadProperty("CQHoHap", true);
                return _cQHoHap;
            }
            set
            {
                CanWriteProperty("CQHoHap", true);
                if (_cQHoHap != value)
                {
                    _cQHoHap = value;
                    PropertyHasChanged("CQHoHap");
                }
            }
        }
        public String CQTieuHoa
        {
            get
            {
                CanReadProperty("CQTieuHoa", true);
                return _cQTieuHoa;
            }
            set
            {
                CanWriteProperty("CQTieuHoa", true);
                if (_cQTieuHoa != value)
                {
                    _cQTieuHoa = value;
                    PropertyHasChanged("CQTieuHoa");
                }
            }
        }
        public String CQCXKhop
        {
            get
            {
                CanReadProperty("CQCXKhop", true);
                return _cQCXKhop;
            }
            set
            {
                CanWriteProperty("CQCXKhop", true);
                if (_cQCXKhop != value)
                {
                    _cQCXKhop = value;
                    PropertyHasChanged("CQCXKhop");
                }
            }
        }
        public String CQTietNieuSD
        {
            get
            {
                CanReadProperty("CQTietNieuSD", true);
                return _cQTietNieuSD;
            }
            set
            {
                CanWriteProperty("CQTietNieuSD", true);
                if (_cQTietNieuSD != value)
                {
                    _cQTietNieuSD = value;
                    PropertyHasChanged("CQTietNieuSD");
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
        public String PhanBiet
        {
            get
            {
                CanReadProperty("PhanBiet", true);
                return _phanBiet;
            }
            set
            {
                CanWriteProperty("PhanBiet", true);
                if (_phanBiet != value)
                {
                    _phanBiet = value;
                    PropertyHasChanged("PhanBiet");
                }
            }
        }
        public String TienLuong
        {
            get
            {
                CanReadProperty("TienLuong", true);
                return _tienLuong;
            }
            set
            {
                CanWriteProperty("TienLuong", true);
                if (_tienLuong != value)
                {
                    _tienLuong = value;
                    PropertyHasChanged("TienLuong");
                }
            }
        }


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

        public string tomtatBA
        {
            get
            {
                CanReadProperty("tomtatBA", true);
                return _tomtatBA;
            }
            set
            {
                CanWriteProperty("tomtatBA", true);
                if (_tomtatBA != value)
                {
                    _tomtatBA = value;
                    PropertyHasChanged("tomtatBA");
                }
            }
        }

        public String cacxncls
        {
            get
            {
                CanReadProperty("cacxncls", true);
                return _cacxncls;
            }
            set
            {
                CanWriteProperty("cacxncls", true);
                if (_cacxncls != value)
                {
                    _cacxncls = value;
                    PropertyHasChanged("cacxncls");
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
        /// Factory method. New <see cref="BenhAn_Mat" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_Mat NewBenhAn_Mat()
        {
            return DataPortal.Create<BenhAn_Mat>();
        }
        public static BenhAn_Mat GetBenhAn_Mat(String maBA, Int32 sTT, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_Mat>(new Criteria(maBA, sTT, sTTKhoa));
        }

        /// <summary>
        /// Marks the <see cref="BenhAn_Mat" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhAn_Mat(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, sTT, sTTKhoa));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhAn_Mat()
        {
            // Prevent direct creation
        }

        internal BenhAn_Mat(int OrderNumber,
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
                                 String thiLucVV,
                                 String khongKinhMP,
                                 String khongKinhMT,
                                 String coKinhMP,
                                 String coKinhMT,
                                 String nhanAPMP,
                                 String nhanApMT,
                                 String thiTruongMP,
                                 String thiTruongMT,
            String leDaoMP,
String leDaoMT,
String miMatMP,
String miMatMT,
String ketMacMP,
String ketMacMT,
String matHotMP,
String matHotMT,
String giaMacMP,
String giaMacMT,
String cungMacMP,
String cungMacMT,
String tTTienPhongMP,
String tTTienPhongMT,
String tTMongMatMP,
String tTMongMatMT,
String tTDongTuPXMP,
String tTDongTuPXMT,
String tTThuyTinhTheMP,
String tTThuyTinhTheMT,
String tTThuyTinhDichMP,
String tTThuyTinhDichMT,
String tTSADongTuMP,
String tTSADongTuMT,
String tTNhanCauMP,
String tTNhanCauMT,
String tTHocMatMP,
String tTHocMatMT,
String tTDayMatMP,
String tTDayMatMT,
String khamToanThan,
String cQNoiTiet,
String cQTamThan,
String cQTuanHoan,
String cQHoHap,
String cQTieuHoa,
String cQCXKhop,
String cQTietNieuSD,
String coQuanKhac,
String dieuTri,
String benhSu,
String mabenh,
String maBenhKem,
String phanBiet,
String tienLuong,
String huongDT,
                                 String machuyenkhoa,
                                 String maMay,
                                 Boolean huy,
                                 SmartDate ngaySD,
                                 String nguoiSD,
                                 String tomtatBA,
                                 String cacxncls,
                                 String tenBenh,
                                 String tenBenhKem,
            //String maICD ,
                                 String maICDKem,
                                 String tenBSKham,
                                string tennguoisd
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
            _thiLucVV = thiLucVV;
            _khongKinhMP = khongKinhMP;
            _khongKinhMT = khongKinhMT;
            _coKinhMP = coKinhMP;
            _coKinhMT = coKinhMT;
            _nhanAPMP = nhanAPMP;
            _nhanApMT = nhanApMT;
            _thiTruongMP = thiTruongMP;
            _thiTruongMT = thiTruongMT;
            _leDaoMP = leDaoMP;
            _leDaoMT = leDaoMT;
            _miMatMP = miMatMP;
            _miMatMT = miMatMT;
            _ketMacMP = ketMacMP;
            _ketMacMT = ketMacMT;
            _matHotMP = matHotMP;
            _matHotMT = matHotMT;
            _giaMacMP = giaMacMP;
            _giaMacMT = giaMacMT;
            _cungMacMP = cungMacMP;
            _cungMacMT = cungMacMT;
            _tTTienPhongMP = tTTienPhongMP;
            _tTTienPhongMT = tTTienPhongMT;
            _tTMongMatMP = tTMongMatMP;
            _tTMongMatMT = tTMongMatMT;
            _tTDongTuPXMP = tTDongTuPXMP;
            _tTDongTuPXMT = tTDongTuPXMT;
            _tTThuyTinhTheMP = tTThuyTinhTheMP;
            _tTThuyTinhTheMT = tTThuyTinhTheMT;
            _tTThuyTinhDichMP = tTThuyTinhDichMP;
            _tTThuyTinhDichMT = tTThuyTinhDichMT;
            _tTSADongTuMP = tTSADongTuMP;
            _tTSADongTuMT = tTSADongTuMT;
            _tTNhanCauMP = tTNhanCauMP;
            _tTNhanCauMT = tTNhanCauMT;
            _tTHocMatMP = tTHocMatMP;
            _tTHocMatMT = tTHocMatMT;
            _tTDayMatMP = tTDayMatMP;
            _tTDayMatMT = tTDayMatMT;
            _khamToanThan = khamToanThan;
            _cQNoiTiet = cQNoiTiet;
            _cQTamThan = cQTamThan;
            _cQTuanHoan = cQTuanHoan;
            _cQHoHap = cQHoHap;
            _cQTieuHoa = cQTieuHoa;
            _cQCXKhop = cQCXKhop;
            _cQTietNieuSD = cQTietNieuSD;
            _coQuanKhac = coQuanKhac;
            _dieuTri = dieuTri;
            _benhSu = benhSu;
            _mabenh = benhSu;
            _maBenhKem = maBenhKem;
            _phanBiet = phanBiet;
            _tienLuong = tienLuong;
            _huongDT = huongDT;
            _machuyenkhoa = machuyenkhoa;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _tomtatBA = tomtatBA;
            _cacxncls = cacxncls;
            _tenBenh = tenBenh;
            _tenBenhKem = tenBenhKem;
            // _maICD = maICD ;
            _maICDKem = maICDKem;
            _tenBSKham = tenBSKham;
            _tennguoiSD = tennguoisd;
        }

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
        /// Retrieve an existing <see cref="BenhAn_Mat" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mat_GET", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Mat(crit.MaBA, crit.STT, crit.STTKhoa)))
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
        /// Load a <see cref="BenhAn_Mat" /> Object from given SafeDataReader.
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
            if (dr.GetString("ThiLucVV") != null) _thiLucVV = dr.GetString("ThiLucVV");
            if (dr.GetString("KhongKinhMP") != null) _khongKinhMP = dr.GetString("KhongKinhMP");
            if (dr.GetString("KhongKinhMT") != null) _khongKinhMT = dr.GetString("KhongKinhMT");
            if (dr.GetString("CoKinhMP") != null) _coKinhMP = dr.GetString("CoKinhMP");
            if (dr.GetString("CoKinhMT") != null) _coKinhMT = dr.GetString("CoKinhMT");
            if (dr.GetString("NhanAPMP") != null) _nhanAPMP = dr.GetString("NhanAPMP");
            if (dr.GetString("NhanApMT") != null) _nhanApMT = dr.GetString("NhanApMT");
            if (dr.GetString("ThiTruongMP") != null) _thiTruongMP = dr.GetString("ThiTruongMP");
            if (dr.GetString("ThiTruongMT") != null) _thiTruongMT = dr.GetString("ThiTruongMT");

            if (dr.GetString("LeDaoMP") != null) _leDaoMP = dr.GetString("LeDaoMP");
            if (dr.GetString("LeDaoMT") != null) _leDaoMT = dr.GetString("LeDaoMT");
            if (dr.GetString("MiMatMP") != null) _miMatMP = dr.GetString("MiMatMP");
            if (dr.GetString("MiMatMT") != null) _miMatMT = dr.GetString("MiMatMT");
            if (dr.GetString("KetMacMP") != null) _ketMacMP = dr.GetString("KetMacMP");
            if (dr.GetString("KetMacMT") != null) _ketMacMT = dr.GetString("KetMacMT");
            if (dr.GetString("MatHotMP") != null) _matHotMP = dr.GetString("MatHotMP");
            if (dr.GetString("MatHotMT") != null) _matHotMT = dr.GetString("MatHotMT");
            if (dr.GetString("GiaMacMP") != null) _giaMacMP = dr.GetString("GiaMacMP");

            if (dr.GetString("GiaMacMT") != null) _giaMacMT = dr.GetString("GiaMacMT");
            if (dr.GetString("CungMacMP") != null) _cungMacMP = dr.GetString("CungMacMP");
            if (dr.GetString("CungMacMT") != null) _cungMacMT = dr.GetString("CungMacMT");
            if (dr.GetString("TTTienPhongMP") != null) _tTTienPhongMP = dr.GetString("TTTienPhongMP");
            if (dr.GetString("TTTienPhongMT") != null) _tTTienPhongMT = dr.GetString("TTTienPhongMT");

            if (dr.GetString("TTMongMatMP") != null) _tTMongMatMP = dr.GetString("TTMongMatMP");
            if (dr.GetString("TTMongMatMT") != null) _tTMongMatMT = dr.GetString("TTMongMatMT");
            if (dr.GetString("TTDongTuPXMP") != null) _tTDongTuPXMP = dr.GetString("TTDongTuPXMP");
            if (dr.GetString("TTDongTuPXMT") != null) _tTDongTuPXMT = dr.GetString("TTDongTuPXMT");

            if (dr.GetString("TTThuyTinhTheMP") != null) _tTThuyTinhTheMP = dr.GetString("TTThuyTinhTheMP");
            if (dr.GetString("TTThuyTinhTheMT") != null) _tTThuyTinhTheMT = dr.GetString("TTThuyTinhTheMT");
            if (dr.GetString("TTThuyTinhDichMP") != null) _tTThuyTinhDichMP = dr.GetString("TTThuyTinhDichMP");
            if (dr.GetString("TTThuyTinhDichMT") != null) _tTThuyTinhDichMT = dr.GetString("TTThuyTinhDichMT");
            if (dr.GetString("TTSADongTuMP") != null) _tTSADongTuMP = dr.GetString("TTSADongTuMP");
            if (dr.GetString("TTSADongTuMT") != null) _tTSADongTuMT = dr.GetString("TTSADongTuMT");
            if (dr.GetString("TTNhanCauMP") != null) _tTNhanCauMP = dr.GetString("TTNhanCauMP");

            if (dr.GetString("TTNhanCauMT") != null) _tTNhanCauMT = dr.GetString("TTNhanCauMT");
            if (dr.GetString("TTHocMatMP") != null) _tTHocMatMP = dr.GetString("TTHocMatMP");
            if (dr.GetString("TTHocMatMT") != null) _tTHocMatMT = dr.GetString("TTHocMatMT");

            if (dr.GetString("TTDayMatMP") != null) _tTDayMatMP = dr.GetString("TTDayMatMP");
            if (dr.GetString("TTDayMatMT") != null) _tTDayMatMT = dr.GetString("TTDayMatMT");
            if (dr.GetString("KhamToanThan") != null) _khamToanThan = dr.GetString("KhamToanThan");
            if (dr.GetString("CQNoiTiet") != null) _cQNoiTiet = dr.GetString("CQNoiTiet");
            if (dr.GetString("CQTamThan") != null) _cQTamThan = dr.GetString("CQTamThan");
            if (dr.GetString("CQTuanHoan") != null) _cQTuanHoan = dr.GetString("CQTuanHoan");
            if (dr.GetString("CQHoHap") != null) _cQHoHap = dr.GetString("CQHoHap");
            if (dr.GetString("CQTieuHoa") != null) _cQTieuHoa = dr.GetString("CQTieuHoa");
            if (dr.GetString("CQCXKhop") != null) _cQCXKhop = dr.GetString("CQCXKhop");
            if (dr.GetString("CQTietNieuSD") != null) _cQTietNieuSD = dr.GetString("CQTietNieuSD");
            if (dr.GetString("CoQuanKhac") != null) _coQuanKhac = dr.GetString("CoQuanKhac");
            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
            if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("PhanBiet") != null) _phanBiet = dr.GetString("PhanBiet");
            if (dr.GetString("TienLuong") != null) _tienLuong = dr.GetString("TienLuong");
            if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");




            if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("tomtatBA") != null) _tomtatBA = dr.GetString("tomtatBA");
            if (dr.GetString("cacxncls") != null) _cacxncls = dr.GetString("cacxncls");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }

        /// <summary>
        /// Insert the new <see cref="BenhAn_Mat" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_Mat
            // Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn_Mat(_maBA, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _thiLucVV, _khongKinhMP, _khongKinhMT, _coKinhMP, _coKinhMT, _nhanAPMP, _nhanApMT, _thiTruongMP, _thiTruongMT,
_coQuanKhac,
_dieuTri,
_benhSu,
_tomtatBA, // Thông tin tóm tắt theo store ? 
_mabenh,
_maBenhKem,
_phanBiet,
_tienLuong,
_huongDT,
_machuyenkhoa,
_maMay,
_nguoiSD,
_leDaoMP,
_leDaoMT,
_miMatMP,
_miMatMT,
_ketMacMP,
_ketMacMT,
_matHotMP,
_matHotMT,
_giaMacMP,
_giaMacMT,
_cungMacMP,
_cungMacMT,
_tTTienPhongMP,
_tTTienPhongMT,
_tTMongMatMP,
_tTMongMatMT,
_tTDongTuPXMP,
_tTDongTuPXMT,
_tTThuyTinhTheMP,
_tTThuyTinhTheMT,
_tTThuyTinhDichMP,
_tTThuyTinhDichMT,
_tTSADongTuMP,
_tTSADongTuMT,
_tTNhanCauMP,
_tTNhanCauMT,
_tTHocMatMP,
_tTHocMatMT,
_tTDayMatMP,
_tTDayMatMT,
_khamToanThan,
_cQNoiTiet,
_cQTamThan,
_cQTuanHoan,
_cQHoHap,
_cQTieuHoa,
_cQCXKhop,
_cQTietNieuSD,
_cacxncls
);
            // public abstract String InsertBenhAn_Mat(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_Mat(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mat_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _thiLucVV, _khongKinhMP, _khongKinhMT, _coKinhMP, _coKinhMT, _nhanAPMP, _nhanApMT, _thiTruongMP, _thiTruongMT, _moTaBenhLy, _tonThuong, _coQuanKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _tomtatBA.DBValue, _cacxncls), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="BenhAn_Mat" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Mat
            if (IsDirty)
            {
                DataProvider.Instance().UpdateBenhAn_Mat(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _thiLucVV, _khongKinhMP, _khongKinhMT, _coKinhMP, _coKinhMT, _nhanAPMP, _nhanApMT, _thiTruongMP, _thiTruongMT,

_leDaoMP,
_leDaoMT,
_miMatMP,
_miMatMT,
_ketMacMP,
_ketMacMT,
_matHotMP,
_matHotMT,
_giaMacMP,
_giaMacMT,
_cungMacMP,
_cungMacMT,
_tTTienPhongMP,
_tTTienPhongMT,
_tTMongMatMP,
_tTMongMatMT,
_tTDongTuPXMP,
_tTDongTuPXMT,
_tTThuyTinhTheMP,
_tTThuyTinhTheMT,
_tTThuyTinhDichMP,
_tTThuyTinhDichMT,
_tTSADongTuMP,
_tTSADongTuMT,
_tTNhanCauMP,
_tTNhanCauMT,
_tTHocMatMP,
_tTHocMatMT,
_tTDayMatMP,
_tTDayMatMT,
_khamToanThan,
_cQNoiTiet,
_cQTamThan,
_cQTuanHoan,
_cQHoHap,
_cQTieuHoa,
_cQCXKhop,
_cQTietNieuSD,
_coQuanKhac,
_cacxncls,
_tomtatBA,
_dieuTri,
_benhSu,
_mabenh,
_maBenhKem,
_phanBiet,
_tienLuong,
_huongDT, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mat_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _thiLucVV, _khongKinhMP, _khongKinhMT, _coKinhMP, _coKinhMT, _nhanAPMP, _nhanApMT, _thiTruongMP, _thiTruongMT, _moTaBenhLy, _tonThuong, _coQuanKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maBA, _sTT, _sTTKhoa));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_Mat" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Mat
            DataProvider.Instance().DeleteBenhAn_Mat(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
            // public abstract void DeleteBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Mat_Deleted", _maBA, _sTT, _sTTKhoa);
            // }
        }

        #endregion
    }

}
