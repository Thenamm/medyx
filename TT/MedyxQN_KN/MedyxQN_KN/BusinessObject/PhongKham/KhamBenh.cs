// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh
// Kieu doi tuong  :	KhamBenh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/23/2009 3:09:20 PM
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
using System.Transactions;
namespace HTC.Business.PhongKham
{

    /// <summary>
    /// This is a base generated class of <see cref="KhamBenh" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class KhamBenh : BusinessBase<KhamBenh>
    {
        #region Business Methods

        #region State Fields
        private String _maBVGT = String.Empty;
        private String _tenBVGT = String.Empty;
        private String _maBHXHGT = String.Empty;
        private String _maSoKham = String.Empty;
        private String _maBN = String.Empty;
        private String _maDT = String.Empty;
        private String _sothe = String.Empty;
        private SmartDate _giatriDN = new SmartDate(true);
        private String _maBV = String.Empty;
        private String _mabhxh = String.Empty;
        private String _tenbv = String.Empty;
        private Decimal _bhtra = 0;
        private Decimal _MienGiam = 0;
        private Decimal _MienGiamTT = 0;
        private Decimal _MienGiamBH = 0;
        private Decimal _sotienbhtra = 0;
        private String _maTinh = String.Empty;
        private SmartDate _ngayKT = new SmartDate(true);
        private SmartDate _ngayGT = new SmartDate(true);
        private String _gio = String.Empty;
        private SmartDate _ngayduyet = new SmartDate(true);
        private String _nguoiduyet = String.Empty;
        private SmartDate _ngayQT = new SmartDate(true);
        private SmartDate _ngayQTTT = new SmartDate(true);
        private String _nguoiQT = String.Empty;
        private String _maBenhNoiGT = String.Empty;
        private String _maicdngt = String.Empty;
        private String _tenbenhngt = String.Empty;
        private String _maNoiGT = String.Empty;
        private String _cDNoiGT = String.Empty;
        private String _ghichu = String.Empty;
        private Byte _loaiKham = 0;
        private Boolean _cungtra = false;
        private Decimal _ck = 0;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _dienThoai = String.Empty;
        private String _diaChi = String.Empty;
        private String _sosohd = String.Empty;
        private String _sohd = String.Empty;
        private Decimal _TongTien = 0;
        private Decimal _TongBHTra = 0;
        private Decimal _TongBHKTra = 0;
        private Decimal _TongTienBH = 0;
        private Decimal _TongTienTT = 0;
        private Decimal _TongTienTTCTT = 0;
        private Decimal _TongBHTraCTT = 0;
        private Decimal _TongTienBHCTT = 0;
        private Decimal _TongTienTTDTT = 0;
        private Decimal _TongBHTraDTT = 0;
        private Decimal _TongTienBHDTT = 0;
        private Decimal _TongTienTTDTTKTra = 0;
        private Decimal _TongThanhToan = 0;
        private Decimal _TongTraLaiBN = 0;
        private Decimal _TongHD = 0;
        private Decimal _TongTienCTT = 0;
        private Decimal _TongTienHoaDon = 0;
        private Decimal _TongThuHoaDon = 0;
        private Decimal _TongTTThucTe = 0;

        private SmartDate _ngayDK = new SmartDate(true);
        private Byte _loai = 0;
        private Boolean _DuyetBH = false;
        private Decimal _KyQuyBH;
        private int _OrderNumber;
        private String _sophieuttrv = String.Empty;
        private SmartDate _giaTriTN = new SmartDate(true);
        private Decimal _TongDV = 0;
        private Decimal _TongThuocTY = 0;
        private Decimal _TongThuocDY = 0;
        private Decimal _TongSac = 0;
        private String _noitt = String.Empty;
        private String _ngayDu5Nam = String.Empty;
        private String _maKV = String.Empty;
        private String _ngayMienCCT = String.Empty;
        //private decimal _bhtrat;
        //private decimal _sotienbhtrat; 
        #endregion

        #region Business Properties and Methods
        public string MaKV
        {
            get
            {
                CanReadProperty(true);
                return _maKV;
            }
            set
            {
                CanReadProperty("MaKV", true);
                if (!_maKV.Equals(value))
                {
                    _maKV = value;
                    PropertyHasChanged("MaKV");
                }
            }
        }
        public string NgayMienCCT
        {
            get
            {
                CanReadProperty(true);
                return _ngayMienCCT;
            }
            set
            {
                CanReadProperty("NgayMienCCT", true);
                if (!_ngayMienCCT.Equals(value))
                {
                    _ngayMienCCT = value;
                    PropertyHasChanged("NgayMienCCT");
                }
            }
        }
        public String ngayDu5Nam
        {
            get
            {
                CanReadProperty("ngayDu5Nam", true);
                return _ngayDu5Nam;
            }
            set
            {
                CanWriteProperty("ngayDu5Nam", true);
                if (_ngayDu5Nam != value)
                {
                    _ngayDu5Nam = value;
                    PropertyHasChanged("ngayDu5Nam");
                }
            }
        }
        public Boolean DuyetBH
        {
            get
            {
                CanReadProperty("DuyetBH", true);
                return _DuyetBH;
            }
            set
            {
                CanWriteProperty("DuyetBH", true);
                if (_DuyetBH != value)
                {
                    _DuyetBH = value;
                    PropertyHasChanged("DuyetBH");
                }
            }
        }

        public String MABHXHGT
        {
            get
            {
                CanReadProperty("MABHXHGT", true);
                return _maBHXHGT;
            }
            set
            {
                CanWriteProperty("MABHXHGT", true);
                if (_maBHXHGT != value)
                {
                    _maBHXHGT = value;
                    PropertyHasChanged("MABHXHGT");
                }
            }
        }
        public decimal TongDV
        {
            get
            {
                CanReadProperty("TongDV", true);
                return _TongDV;
               // return _TongDV.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongDV", true);
                //if (_TongDV.ToString() != value)
                //{
                //    _TongDV = decimal.Parse(value);
                //    PropertyHasChanged("TongDV");
                //}
              
                    _TongDV = value;
                    PropertyHasChanged("TongDV");
               
            }
        }
        //public string TongSac
        //{
        //    get
        //    {
        //        CanReadProperty("TongSac", true);

        //        return _TongSac.ToString("###,###");
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongSac", true);
        //        if (_TongSac.ToString() != value)
        //        {
        //            _TongSac = decimal.Parse(value);
        //            PropertyHasChanged("TongSac");
        //        }
        //    }
        //}
        public decimal TongThuocTY
        {
            get
            {
                CanReadProperty("TongThuocTY", true);
                return _TongThuocTY;
               // return _TongThuocTY.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongThuocTY", true);
                //if (_TongThuocTY.ToString() != value)
                //{
                //    _TongThuocTY = decimal.Parse(value);
                //    PropertyHasChanged("TongThuocTY");
                //}
                if (_TongThuocTY != value)
                {
                    _TongThuocTY = value;
                    PropertyHasChanged("TongThuocTY");
                }
                  
               
            }
        }
        public decimal TongThanhToan
        {
            get
            {
                CanReadProperty("TongThanhToan", true);
                return _TongThanhToan;
                // return _TongThuocTY.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongThanhToan", true);
                //if (_TongThuocTY.ToString() != value)
                //{
                //    _TongThuocTY = decimal.Parse(value);
                //    PropertyHasChanged("TongThuocTY");
                //}

                if (_TongThanhToan != value)
                {
                    _TongThanhToan = value;
                    PropertyHasChanged("TongThanhToan");
                }

            }
        }
        //public string TongTTThucTe
        //{
        //    get
        //    {
        //        CanReadProperty("TongTTThucTe", true);

        //        _TongTTThucTe = _KyQuyBH - _TongThuHoaDon;// -(_TongTienTTDTT - _TongTienTTDTTKTra);
        //        return _TongTTThucTe.ToString("###,###");
        //    }

        //}
        //public decimal TongTienBHCTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienBHCTT", true);


        //        return _TongTienBHCTT ;
        //    }

        //}
        public decimal TongTienBH
        {
            get
            {
                CanReadProperty("TongTienBH", true);


                return _TongTienBH;
            }
            set
            {
                CanWriteProperty("TongTienBH", true);
                if (_TongTienBH != value)
                {
                    _TongTienBH = value;
                    PropertyHasChanged("TongTienBH");
                }
            }
        }
        public decimal TongTienTTCTT
        {
            get
            {
                CanReadProperty("TongTienTTCTT", true);


                return _TongTienTTCTT;
            }
           
        }
        public decimal TongTienBHCTT
        {
            get
            {
                CanReadProperty("TongTienBHCTT", true);


                return _TongTienBHCTT;
            }
            set
            {
                CanWriteProperty("TongTienBHCTT", true);
                if (_TongTienBHCTT != value)
                {
                    _TongTienBHCTT = value;
                    PropertyHasChanged("TongTienBHCTT");
                }
            }
        }
        public decimal TongTienTTDTT
        {
            get
            {
                CanReadProperty("TongTienTTDTT", true);


                return _TongTienTTDTT;
            }
            set
            {
                CanWriteProperty("TongTienTTDTT", true);
                if (_TongTienTTDTT != value)
                {
                    _TongTienTTDTT = value;
                    PropertyHasChanged("TongTienTTDTT");
                }
            }
        }
        public decimal TongThuocDY
        {
            get
            {
                CanReadProperty("TongThuocDY", true);
                return _TongThuocDY;
               // return _TongThuocDY.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongThuocDY", true);
                //if (_TongThuocDY.ToString() != value)
                //{
                //    _TongThuocDY = decimal.Parse(value);
                //    PropertyHasChanged("TongThuocDY");
                //}

                if (_TongThuocDY != value)
                {
                    _TongThuocDY = value;
                    PropertyHasChanged("TongThuocDY");
                }
               
            }
        }

        public string KyQuyBH
        {
            get
            {
                CanReadProperty("KyQuyBH", true);

                return _KyQuyBH.ToString("###,###");
            }
            set
            {
                CanWriteProperty("KyQuyBH", true);
                if (_KyQuyBH.ToString() != value)
                {
                    _KyQuyBH = decimal.Parse(value);
                    PropertyHasChanged("KyQuyBH");
                }
            }
        }
        public Decimal TongBHTra
        {
            get
            {
                CanReadProperty("TongBHTra", true);

                return _TongBHTra;
            }
          
        }
        public String MaBVGT
        {
            get
            {
                CanReadProperty("MaBVGT", true);
                //if ((_maBVGT == "") && (_maBV != ""))
                //{
                //    _maBVGT = _maBV;
                //    _maBHXHGT = _mabhxh;
                //    _tenBVGT = _tenbv;
                //}
                return _maBVGT;
            }
            set
            {
                CanWriteProperty("MaBVGT", true);
                if (_maBVGT != value)
                {
                    _maBVGT = value;
                    PropertyHasChanged("MaBVGT");
                }
            }
        }
        public String TenBVGT
        {
            get
            {
                CanReadProperty("TenBVGT", true);
                return _tenBVGT;
            }
            set
            {
                CanWriteProperty("TenBVGT", true);
                if (_tenBVGT != value)
                {
                    _tenBVGT = value;
                    PropertyHasChanged("TenBVGT");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
        public String MaSoKham
        {
            get
            {
                CanReadProperty("MaSoKham", true);
                return _maSoKham;
            }
            set
            {
                CanWriteProperty("MaSoKham", true);
                if (_maSoKham != value)
                {
                    _maSoKham = value;
                    PropertyHasChanged("MaSoKham");
                }
            }
        }
        public String sosohd
        {
            get
            {
                CanReadProperty("sosohd", true);
                return _sosohd;
            }
            set
            {
                CanWriteProperty("sosohd", true);
                if (_sosohd != value)
                {
                    _sosohd = value;
                    PropertyHasChanged("sosohd");
                }
            }
        }
        public String sohd
        {
            get
            {
                CanReadProperty("sohd", true);
                return _sohd;
            }
            set
            {
                CanWriteProperty("sohd", true);
                if (_sohd != value)
                {
                    _sohd = value;
                    PropertyHasChanged("sohd");
                }
            }
        }
        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _maBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_maBN != value)
                {
                    _maBN = value;
                    PropertyHasChanged("MaBN");
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
        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }
        public String sophieuttrv
        {
            get
            {
                CanReadProperty("sophieuttrv", true);
                return _sophieuttrv;
            }
            set
            {
                CanWriteProperty("sophieuttrv", true);
                if (_sophieuttrv != value)
                {
                    _sophieuttrv = value;
                    PropertyHasChanged("sophieuttrv");
                }
            }
        }
        public String tenbv
        {
            get
            {
                CanReadProperty("tenbv", true);
                return _tenbv;
            }
            set
            {
                CanWriteProperty("tenbv", true);
                if (_tenbv != value)
                {
                    _tenbv = value;
                    PropertyHasChanged("tenbv");
                }
            }
        }
        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
                }
            }
        }
        public String maicdngt
        {
            get
            {
                CanReadProperty("maicdngt", true);
                return _maicdngt;
            }
            set
            {
                CanWriteProperty("maicdngt", true);
                if (_maicdngt != value)
                {
                    _maicdngt = value;
                    PropertyHasChanged("maicdngt");
                }
            }
        }
        public String tenbenhngt
        {
            get
            {
                CanReadProperty("tenbenhngt", true);
                return _tenbenhngt;
            }
            set
            {
                CanWriteProperty("tenbenhngt", true);
                if (_tenbenhngt != value)
                {
                    _tenbenhngt = value;
                    PropertyHasChanged("tenbenhngt");
                }
            }
        }
        public Decimal bhtra
        {
            get
            {
                CanReadProperty("bhtra", true);
                return _bhtra;
            }
            set
            {
                CanWriteProperty("bhtra", true);
                if (_bhtra != value)
                {
                    _bhtra = value;
                    PropertyHasChanged("bhtra");
                }
            }
        }
        public Decimal MienGiam
        {
            get
            {
                CanReadProperty("MienGiam", true);
                return _MienGiam;
            }
            set
            {
                CanWriteProperty("MienGiam", true);
                if (_MienGiam != value)
                {
                    _MienGiam = value;
                    PropertyHasChanged("MienGiam");
                }
            }
        }
        public Decimal MienGiamTT
        {
            get
            {
                CanReadProperty("MienGiamTT", true);
                return _MienGiamTT;
            }
            set
            {
                CanWriteProperty("MienGiamTT", true);
                if (_MienGiamTT != value)
                {
                    _MienGiamTT = value;
                    PropertyHasChanged("MienGiamTT");
                }
            }
        }
        public Decimal MienGiamBH
        {
            get
            {
                CanReadProperty("MienGiamBH", true);
                return _MienGiamBH;
            }
            set
            {
                CanWriteProperty("MienGiamBH", true);
                if (_MienGiamBH != value)
                {
                    _MienGiamBH = value;
                    PropertyHasChanged("MienGiamBH");
                }
            }
        }
        public Decimal sotienbhtra
        {
            get
            {
                CanReadProperty("sotienbhtra", true);
                return _sotienbhtra;
            }
            set
            {
                CanWriteProperty("sotienbhtra", true);
                if (_sotienbhtra != value)
                {
                    _sotienbhtra = value;
                    PropertyHasChanged("sotienbhtra");
                }
            }
        }

        public string GiatriDN
        {
            get
            {
                CanReadProperty("GiatriDN", true);
                return _giatriDN.Text;
            }
            set
            {
                CanWriteProperty("GiatriDN", true);
                if (_giatriDN.Text != value)
                {
                    _giatriDN.Text = value;
                    PropertyHasChanged("GiatriDN");
                }
            }
        }

        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _maBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_maBV != value)
                {
                    _maBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }

        public String MaTinh
        {
            get
            {
                CanReadProperty("MaTinh", true);
                return _maTinh;
            }
            set
            {
                CanWriteProperty("MaTinh", true);
                if (_maTinh != value)
                {
                    _maTinh = value;
                    PropertyHasChanged("MaTinh");
                }
            }
        }

        public string NgayKT
        {
            get
            {
                CanReadProperty("NgayKT", true);
                return _ngayKT.Text;
            }
            set
            {
                CanWriteProperty("NgayKT", true);
                if (_ngayKT.Text != value)
                {
                    _ngayKT.Text = value;
                    PropertyHasChanged("NgayKT");
                }
            }
        }
        public string NgayGT
        {
            get
            {
                CanReadProperty("NgayGT", true);
                return _ngayGT.Text;
            }
            set
            {
                CanWriteProperty("NgayGT", true);
                if (_ngayGT.Text != value)
                {
                    _ngayGT.Text = value;
                    PropertyHasChanged("NgayGT");
                }
            }
        }
        public String Gio
        {
            get
            {
                CanReadProperty("Gio", true);
                return _gio;
            }
            set
            {
                CanWriteProperty("Gio", true);
                if (_gio != value)
                {
                    _gio = value;
                    PropertyHasChanged("Gio");
                }
            }
        }
        public string NgayDK
        {
            get
            {
                CanReadProperty("NgayDK", true);
                return _ngayDK.Text;
            }
            set
            {
                CanWriteProperty("NgayDK", true);
                if (_ngayDK.Text != value)
                {
                    _ngayDK.Text = value;
                    PropertyHasChanged("NgayDK");
                }
            }
        }

        //public string NgayDK
        //{
        //    get
        //    {
        //        CanReadProperty("NgayDK", true);
        //        _ngayDK.FormatString = "dd/MM/yyyy";
        //        return _ngayDK.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayDK", true);
        //        if (_ngayDK.Text != value)
        //        {
        //            _ngayDK.FormatString = "dd/MM/yyyy";
        //            _ngayDK.Text = value;
        //            PropertyHasChanged("NgayDK");
        //        }
        //    }
        //}
        public string Ngayduyet
        {
            get
            {
                CanReadProperty("Ngayduyet", true);
                return _ngayduyet.Text;
            }
            set
            {
                CanWriteProperty("Ngayduyet", true);
                if (_ngayduyet.Text != value)
                {
                    _ngayduyet.Text = value;
                    PropertyHasChanged("Ngayduyet");
                }
            }
        }

        public String Nguoiduyet
        {
            get
            {
                CanReadProperty("Nguoiduyet", true);
                return _nguoiduyet;
            }
            set
            {
                CanWriteProperty("Nguoiduyet", true);
                if (_nguoiduyet != value)
                {
                    _nguoiduyet = value;
                    PropertyHasChanged("Nguoiduyet");
                }
            }
        }

        public string NgayQT
        {
            get
            {
                CanReadProperty("NgayQT", true);
                _ngayQT.FormatString = "dd/MM/yyyy HH:mm";
                return _ngayQT.Text;
            }
            set
            {
                CanWriteProperty("NgayQT", true);
                if (_ngayQT.Text != value)
                {
                    _ngayQT.Text = value;
                    PropertyHasChanged("NgayQT");
                }
            }
        }

        public string NgayQTTT
        {
            get
            {
                CanReadProperty("NgayQTTT", true);
                return _ngayQTTT.Text;
            }
            set
            {
                CanWriteProperty("NgayQTTT", true);
                if (_ngayQTTT.Text != value)
                {
                    _ngayQTTT.Text = value;
                    PropertyHasChanged("NgayQTTT");
                }
            }
        }

        public String NguoiQT
        {
            get
            {
                CanReadProperty("NguoiQT", true);
                return _nguoiQT;
            }
            set
            {
                CanWriteProperty("NguoiQT", true);
                if (_nguoiQT != value)
                {
                    _nguoiQT = value;
                    PropertyHasChanged("NguoiQT");
                }
            }
        }

        public String MaBenhNoiGT
        {
            get
            {
                CanReadProperty("MaBenhNoiGT", true);
                return _maBenhNoiGT;
            }
            set
            {
                CanWriteProperty("MaBenhNoiGT", true);
                if (_maBenhNoiGT != value)
                {
                    _maBenhNoiGT = value;
                    PropertyHasChanged("MaBenhNoiGT");
                }
            }
        }

        public String MaNoiGT
        {
            get
            {
                CanReadProperty("MaNoiGT", true);
                return _maNoiGT;
            }
            set
            {
                CanWriteProperty("MaNoiGT", true);
                if (_maNoiGT != value)
                {
                    _maNoiGT = value;
                    PropertyHasChanged("MaNoiGT");
                }
            }
        }

        public String CDNoiGT
        {
            get
            {
                CanReadProperty("CDNoiGT", true);
                return _cDNoiGT;
            }
            set
            {
                CanWriteProperty("CDNoiGT", true);
                if (_cDNoiGT != value)
                {
                    _cDNoiGT = value;
                    PropertyHasChanged("CDNoiGT");
                }
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

        public Byte LoaiKham
        {
            get
            {
                CanReadProperty("LoaiKham", true);
                return _loaiKham;
            }
            set
            {
                CanWriteProperty("LoaiKham", true);
                if (_loaiKham != value)
                {
                    _loaiKham = value;
                    PropertyHasChanged("LoaiKham");
                }
            }
        }

        public Boolean Cungtra
        {
            get
            {
                CanReadProperty("Cungtra", true);
                return _cungtra;
            }
            set
            {
                CanWriteProperty("Cungtra", true);
                if (_cungtra != value)
                {
                    _cungtra = value;
                    PropertyHasChanged("Cungtra");
                }
            }
        }

        public Decimal CK
        {
            get
            {
                CanReadProperty("CK", true);
                return _ck;
            }
            set
            {
                CanWriteProperty("CK", true);
                if (_ck != value)
                {
                    _ck = value;
                    PropertyHasChanged("CK");
                }
            }
        }

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm";
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

        //public String NguoiHuy
        //{
        //    get
        //    {
        //        CanReadProperty("NguoiHuy", true);
        //        return _nguoiHuy;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NguoiHuy", true);
        //        if (_nguoiHuy != value)
        //        {
        //            _nguoiHuy = value;
        //            PropertyHasChanged("NguoiHuy");
        //        }
        //    }
        //}

        //public string NgayHuy
        //{
        //    get
        //    {
        //        CanReadProperty("NgayHuy", true);
        //        return _ngayHuy.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayHuy", true);
        //        if (_ngayHuy.Text != value)
        //        {
        //            _ngayHuy.Text = value;
        //            PropertyHasChanged("NgayHuy");
        //        }
        //    }
        //}

        //public string NgaySD1
        //{
        //    get
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _ngaySD1.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value)
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}

        //public String NguoiSD1
        //{
        //    get
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value)
        //        {
        //            _nguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}

        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                return _dienThoai;
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_dienThoai != value)
                {
                    _dienThoai = value;
                    PropertyHasChanged("DienThoai");
                }
            }
        }

        public String DiaChi
        {
            get
            {
                CanReadProperty("DiaChi", true);
                return _diaChi;
            }
            set
            {
                CanWriteProperty("DiaChi", true);
                if (_diaChi != value)
                {
                    _diaChi = value;
                    PropertyHasChanged("DiaChi");
                }
            }
        }



        //public string TongTienCTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienCTT", true);
        //        //return _TongTienCTT;
        //        return _TongTienCTT.ToString("###,###");
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienCTT", true);
        //        if (_TongTienCTT.ToString () != value)
        //        {
        //            _TongTienCTT = decimal.Parse(value);
        //            PropertyHasChanged("TongTienCTT");
        //        }
        //    }
        //}

        public decimal TongTienCTT
        {
            get
            {
                CanReadProperty("TongTienCTT", true);
                return _TongTienCTT;
               // return _TongTienCTT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongTienCTT", true);
                //if (_TongTienCTT.ToString() != value)
                //{
                //    _TongTienCTT = decimal.Parse(value);
                //    PropertyHasChanged("TongTienCTT");
                //}
                _TongTienCTT = value;
                PropertyHasChanged("TongTienCTT");
            }
        }
        public Decimal TongTienBHDTT
        {
            get
            {
                CanReadProperty("TongTienBHDTT", true);
                return _TongTienBHDTT;
            }
            set
            {
                CanWriteProperty("TongTienBHDTT", true);
                if (_TongTienBHDTT != value)
                {
                    _TongTienBHDTT = value;
                    PropertyHasChanged("TongTienBHDTT");
                }
            }
        }

        //public string TongThanhToan
        //{
        //    get
        //    {
        //        CanReadProperty("TongThanhToan", true);
        //        if ((_TongThanhToan < 100) && (_TongThanhToan > -100))
        //            _TongThanhToan = 0;
        //        return _TongThanhToan.ToString("###,###");
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongThanhToan", true);
        //        if (_TongThanhToan.ToString() != value)
        //        {
        //            _TongThanhToan = decimal.Parse(value);
        //            if ((_TongThanhToan < 100) && (_TongThanhToan > -100))
        //                _TongThanhToan = 0;
        //            PropertyHasChanged("TongThanhToan");
        //        }
        //    }
        //}
        public string TongHD
        {
            get
            {
                CanReadProperty("TongHD", true);

                return _TongHD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongHD", true);
                if (_TongHD.ToString() != value)
                {
                    _TongHD = decimal.Parse(value);
                    PropertyHasChanged("TongHD");
                }
            }
        }

        public decimal TongThuHoaDon
        {
            get
            {
                CanReadProperty("TongThuHoaDon", true);
                return _TongThuHoaDon;
               // return _TongThuHoaDon.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongThuHoaDon", true);
                //if (_TongThuHoaDon.ToString() != value)
                //{
                //_TongThuHoaDon = decimal.Parse(value);
                _TongThuHoaDon = value;
                    PropertyHasChanged("TongThuHoaDon");
                //}
            }
        }
        //public string TongTraLaiBN
        //{
        //    get
        //    {
        //        CanReadProperty("TongTraLaiBN", true);
        //        if (_TongThanhToan >= 0)
        //            _TongTraLaiBN = 0;

        //        else
        //            _TongTraLaiBN = 0 - _TongThanhToan;

        //        return _TongTraLaiBN.ToString("###,###");
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTraLaiBN", true);
        //        if (_TongTraLaiBN.ToString() != value)
        //        {
        //            _TongTraLaiBN = decimal.Parse(value);
        //            PropertyHasChanged("TongTraLaiBN");
        //        }
        //    }
        //}
        //public string TongTienCTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienCTT", true);
        //        return _TongTienCTT.ToString("###,###")  ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienCTT", true);

        //        if (_TongTienCTT.ToString()  != value)
        //        {
        //            _TongTienCTT  = decimal.Parse(value) ;
        //            PropertyHasChanged("TongTienCTT");
        //        }
        //    }
        //}

        //public Decimal TongBHKTra
        //{
        //    get
        //    {
        //        CanReadProperty("TongBHKTra", true);
        //        return _TongBHKTra;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongBHKTra", true);
        //        if (_TongBHKTra != value)
        //        {
        //            _TongBHKTra = value;
        //            PropertyHasChanged("TongBHKTra");
        //        }
        //    }
        //}

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
        public Byte loai
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _loai;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_loai.Equals(value))
                {
                    _loai = value;
                    //PropertyHasChanged();
                }
            }
        }


      private   KhamBenh_C_List _KhamBenh_TTNgoai_List = KhamBenh_C_List.NewKhamBenh_C_List();

        public KhamBenh_C_List KhamBenh_TTNgoai_List
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_TTNgoai_List;

            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_TTNgoai_List.Equals(value))
                {
                    _KhamBenh_TTNgoai_List = value;
                    PropertyHasChanged();
                }
            }
        }


        private KhamBenh_C_List _KhamBenh_C_List = KhamBenh_C_List.NewKhamBenh_C_List();

        public KhamBenh_C_List KhamBenh_C_List
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                      return _KhamBenh_C_List;
              
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_C_List.Equals(value))
                {
                    _KhamBenh_C_List = value;
                    PropertyHasChanged();
                }
            }
        }
        private KhamBenh_XN_GetsList _KhamBenh_XN_GetsList = KhamBenh_XN_GetsList.NewKhamBenh_XN_GetsList();

        public KhamBenh_XN_GetsList KhamBenh_XN_GetsList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                if (_loai == 3 || _loai == 4 )
                     return _KhamBenh_XN_GetsList;
                else
                    return null;

            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_XN_GetsList.Equals(value))
                {
                    _KhamBenh_XN_GetsList = value;
                    PropertyHasChanged();
                }
            }
        }

        private KhamBenh_ThuocSDList _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.NewKhamBenh_ThuocSDList();

        public KhamBenh_ThuocSDList KhamBenh_ThuocSDList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
               
                    return _KhamBenh_ThuocSDList;
              
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_ThuocSDList.Equals(value))
                {
                    _KhamBenh_ThuocSDList = value;
                    PropertyHasChanged();
                }
            }
        }

        private KhamBenh_ThuocSD_DYList _KhamBenh_ThuocSD_DYList = KhamBenh_ThuocSD_DYList.NewKhamBenh_ThuocSD_DYList();

        public KhamBenh_ThuocSD_DYList KhamBenh_ThuocSD_DYList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                //if ( HTC.ShareVariables.pub_spC != "YH")
                //    return null;
             
                //else if (_loai == 2 || _loai == 3 || (_loai == 7 && HTC.ShareVariables.pub_spC == "YH"))

                    return _KhamBenh_ThuocSD_DYList;
                //else
                //    return null;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_ThuocSD_DYList.Equals(value))
                {
                    _KhamBenh_ThuocSD_DYList = value;
                    PropertyHasChanged();
                }
            }
        }
        private KhamBenh_MauList _KhamBenh_MauList = KhamBenh_MauList.NewKhamBenh_MauList();

        public KhamBenh_MauList KhamBenh_MauList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
               
                    return _KhamBenh_MauList;
                
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_MauList.Equals(value))
                {
                    _KhamBenh_MauList = value;
                    PropertyHasChanged();
                }
            }
        }

        private KhamBenh_HoaDonList _KhamBenh_HoaDonList = KhamBenh_HoaDonList.NewKhamBenh_HoaDonList();

        public KhamBenh_HoaDonList KhamBenh_HoaDonList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                if (_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 7)

                    return _KhamBenh_HoaDonList;
                else
                    return null;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_HoaDonList.Equals(value))
                {
                    _KhamBenh_HoaDonList = value;
                    PropertyHasChanged();
                }
            }
        }

        private KhamBenh_VTTHList _KhamBenh_VTTHList = KhamBenh_VTTHList.NewKhamBenh_VTTHList();

        public KhamBenh_VTTHList KhamBenh_VTTHList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                //if (_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 3)

                    return _KhamBenh_VTTHList;
                //else
                //    return null;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_VTTHList.Equals(value))
                {
                    _KhamBenh_VTTHList = value;
                    PropertyHasChanged();
                }
            }
        }
        private KhamBenh_HoaChatList _KhamBenh_HoaChatList = KhamBenh_HoaChatList.NewKhamBenh_HoaChatList();

        public KhamBenh_HoaChatList KhamBenh_HoaChatList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                //if (_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 3)

                    return _KhamBenh_HoaChatList;
                //else
                //    return null;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_HoaChatList.Equals(value))
                {
                    _KhamBenh_HoaChatList = value;
                    PropertyHasChanged();
                }
            }
        }


        private KhamBenh_GetsDichVuList _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList();
        public KhamBenh_GetsDichVuList KhamBenh_GetsDichVuCTTList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                if (_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 1 || _loai == 11 || _loai == 7)

                    return _KhamBenh_GetsDichVuCTTList;
                else
                    return KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList(); 
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_GetsDichVuCTTList.Equals(value))
                {
                    _KhamBenh_GetsDichVuCTTList = value;
                    PropertyHasChanged();
                }
            }
        }
        private KhamBenh_GetsDichVuList _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList();
        public KhamBenh_GetsDichVuList KhamBenh_GetsDichVuList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                if (_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 1 || _loai == 11 || _loai == 7)
                    return _KhamBenh_GetsDichVuList;
                else
                    return KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList();;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_GetsDichVuList.Equals(value))
                {
                    _KhamBenh_GetsDichVuList = value;
                    PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maSoKham;
        }

        public override bool IsDirty
        {
            get
            {
                if (_loai == 1 || _loai == 11 ||_loai ==4)
                    return base.IsDirty || _KhamBenh_C_List.IsDirty ;
                else if (_loai == 7 && (HTC .ShareVariables .pub_spC =="YH" ||HTC .ShareVariables .pub_spC =="QN"))
                    return base.IsDirty || _KhamBenh_C_List.IsDirty || _KhamBenh_ThuocSDList.IsDirty || _KhamBenh_ThuocSD_DYList.IsDirty;
                else if (_loai == 7 )
                    return base.IsDirty  || _KhamBenh_ThuocSDList.IsDirty ;
                else
                    return base.IsDirty || _KhamBenh_C_List.IsDirty | _KhamBenh_TTNgoai_List.IsDirty || _KhamBenh_ThuocSDList.IsDirty || _KhamBenh_ThuocSD_DYList.IsDirty || _KhamBenh_MauList.IsDirty || _KhamBenh_VTTHList.IsDirty || _KhamBenh_HoaChatList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                if (_loai == 1 || _loai == 11 || _loai == 4)
                    return base.IsValid && _KhamBenh_C_List.IsValid ;
              else if (_loai == 7 && (HTC .ShareVariables .pub_spC =="YH"||HTC .ShareVariables .pub_spC =="QN"))
                        return base.IsValid && _KhamBenh_C_List.IsValid && _KhamBenh_ThuocSDList.IsValid && _KhamBenh_ThuocSD_DYList.IsValid ;
              else if (_loai == 7)
                     return base.IsValid&& _KhamBenh_ThuocSDList.IsValid ;
                else
                    return base.IsValid && _KhamBenh_C_List.IsValid && _KhamBenh_TTNgoai_List.IsValid && _KhamBenh_ThuocSDList.IsValid && _KhamBenh_ThuocSD_DYList.IsValid && _KhamBenh_MauList.IsValid && _KhamBenh_VTTHList.IsValid && _KhamBenh_HoaChatList.IsValid;
            }
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static KhamBenh NewKhamBenh()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<KhamBenh>();
        }
        public static KhamBenh GetKhamBenh(String maSoKham, Byte loai, Byte datt, DateTime ngayyc, string dk, byte loaikqcn)
        {

            return DataPortal.Fetch<KhamBenh>(new Criteria(maSoKham, loai, datt, ngayyc, dk, loaikqcn));
        }

        public static KhamBenh FindKhamBenh(String mabn, DateTime ngaydk, string dk, Byte loai, byte loaikqcn, byte loaikq, string makhoa)
        {
            return DataPortal.Fetch<KhamBenh>(new FindCriteria(mabn, ngaydk, dk, loai, loaikqcn, loaikq, makhoa));
        }
        public static KhamBenh FindKhamBenh(String mabn, DateTime ngaydk, string dk, Byte loai, byte loaikqcn)
        {
            return DataPortal.Fetch<KhamBenh>(new FindCriteria(mabn, ngaydk, dk, loai, loaikqcn, 0, ""));
        }
        public static KhamBenh FindKhamBenh(String mabn, DateTime ngaydk, Byte loai, string noitt)
        {
            return DataPortal.Fetch<KhamBenh>(new CriteriaTT(mabn, ngaydk, loai, noitt));
        }
        public static void ChangeKhamBenhDT(String maSoKham, string MaDT, byte loai)
        {
            //DataPortal.Execute<CommandBase>(new CommandBase(maSoKham, MaDT, loai, ""));
            DataProvider.Instance().KhamBenh_TINHLAIDT(maSoKham, MaDT, loai, "");
        }

        public static KhamBenh GetKhamBenh(SafeDataReader dr, Byte loai, byte loaikqcn)
        {
            KhamBenh obj = new KhamBenh();
            obj.Fetch(dr, loai, "", loaikqcn, 0, "");
            return obj;
        }
        /// <summary>
        /// Marks the <see cref="KhamBenh" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh(String maSoKham, Byte loai, Byte datt, DateTime ngayyc, String dk)
        {
            DataPortal.Delete(new Criteria(maSoKham, loai, datt, ngayyc, dk, 1));
        }
        public static void UpdateKhamBenh(String maSoKham, Byte loai, Byte datt, DateTime ngayyc, String dk)
        {
            DataPortal.Update(new Criteria(maSoKham, loai, datt, ngayyc, dk, 1));
        }
        public static void InsertKhamBenh(String maSoKham, Byte loai, Byte datt, DateTime ngayyc, String dk)
        {
            //DataPortal.Insert(new Criteria(maSoKham, loai, datt, ngayyc, dk));
        }

        #endregion


        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!


        protected internal KhamBenh()
        {
            // Prevent direct creation

        }
        internal KhamBenh(int OrderNumber,
                             String maSoKham,
                             String maBN,
                             String maDT,
                             String sothe,
                             SmartDate giatriDN,
                             String maBV,
                             String maTinh,
                             SmartDate ngayKT,
                             String gio,
                             SmartDate ngayduyet,
                             String nguoiduyet,
                             SmartDate ngayQT,
                             SmartDate ngayQTTT,
                             String nguoiQT,
                             String maBenhNoiGT,
                             String maNoiGT,
                             String cDNoiGT,
                             String ghichu,
                             Byte loaiKham,
                             Boolean cungtra,
                             Decimal ck,
                             SmartDate ngayLap,
                             String nguoiLap,
                             SmartDate ngaySD,
                             String nguoiSD,
                             String maMay,
                             Boolean huy,
                             String nguoiHuy,
                             SmartDate ngayHuy,
                             SmartDate ngaySD1,
                             String nguoiSD1,
                             String dienThoai,
                             String diaChi,
                             Decimal tongTien,
                             Decimal tongBHTra,
                             Decimal tongTienBH,
                             string mabhxh,
                             decimal bhtra,
                             decimal sotienbhtra,
                             string tenbv,
                             SmartDate ngaydk,
                             SmartDate giatriTN, String maBVGT, String maBHXHGT, string tenbvGT, bool duyetbh, decimal kyquybh
            ,
                             SmartDate ngaygt
                                          )
        {

            _maBVGT = maBVGT;
            _ngayGT = ngaygt;
            _maBHXHGT = maBHXHGT;
            _tenBVGT = tenbvGT;
            _OrderNumber = OrderNumber;
            _maSoKham = maSoKham;
            _maBN = maBN;
            _maDT = maDT;
            _sothe = sothe;
            _giatriDN = giatriDN;
            _maBV = maBV;
            _maTinh = maTinh;
            _ngayKT = ngayKT;
            _gio = gio;
            _ngayduyet = ngayduyet;
            _nguoiduyet = nguoiduyet;
            _ngayQT = ngayQT;
            _ngayQTTT = ngayQTTT;
            _nguoiQT = nguoiQT;
            _maBenhNoiGT = maBenhNoiGT;
            _maNoiGT = maNoiGT;
            _cDNoiGT = cDNoiGT;
            _ghichu = ghichu;
            _loaiKham = loaiKham;
            _cungtra = cungtra;
            _ck = ck;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _maMay = maMay;
            _huy = huy;
            _nguoiHuy = nguoiHuy;
            _ngayHuy = ngayHuy;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _dienThoai = dienThoai;
            _diaChi = diaChi;
            _TongTien = tongTien;
            _TongBHTra = tongBHTra;
            _TongTienBH = tongTienBH;
            _mabhxh = mabhxh;
            _bhtra = bhtra;
            _sotienbhtra = sotienbhtra;
            _tenbv = tenbv;
            _ngayDK = ngaydk;
            _giaTriTN = giatriTN;
            _DuyetBH = duyetbh;
            _KyQuyBH = kyquybh;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maSoKham;
            public String MaSoKham
            {
                get
                {
                    return _maSoKham;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _datt;
            public Byte datt
            {
                get
                {
                    return _datt;
                }
            }
            private DateTime _ngayyc;
            public DateTime ngayyc
            {
                get
                {
                    return _ngayyc;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(String MaSoKham, Byte loai, Byte datt, DateTime ngayyc, string dk, byte loaikqcn)
            {
                _maSoKham = MaSoKham;

                _loai = loai;
                _datt = datt;
                _ngayyc = ngayyc;
                _dk = dk;
                _loaikqcn = loaikqcn;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maSoKham.Equals(c._maSoKham))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maSoKham.ToString()).GetHashCode();
            }
        }
        protected class CriteriaTT
        {
            private String _mabn;
            public String Mabn
            {
                get
                {
                    return _mabn;
                }
            }
            private String _noitt;
            public String noitt
            {
                get
                {
                    return _noitt;
                }
            }
            private Byte _datt;
            public Byte datt
            {
                get
                {
                    return _datt;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }

            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _loaikq;
            public Byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
             private Boolean _qadmin = false ;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaTT(String Mabn, DateTime ngaydk, Byte loai, string noitt)
            {
                _mabn = Mabn;
                _ngaydk = ngaydk;

                _loai = loai;

                _noitt = noitt;

            }
        }

        protected class OtherCriteria
        {
            private String _maSoKham;
            public String MaSoKham
            {
                get
                {
                    return _maSoKham;
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
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _datt;
            public Byte datt
            {
                get
                {
                    return _datt;
                }
            }
            private DateTime _ngayyc;
            public DateTime ngayyc
            {
                get
                {
                    return _ngayyc;
                }
            }
            public OtherCriteria(String MaSoKham, Byte loai, Byte datt, DateTime ngayyc, string dk)
            {
                _maSoKham = MaSoKham;

                _loai = loai;
                _datt = datt;
                _ngayyc = ngayyc;
                _dk = dk;
            }
        }


        protected class FindCriteria
        {
            private String _mabn;
            public String Mabn
            {
                get
                {
                    return _mabn;
                }
            }
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private Byte _datt;
            public Byte datt
            {
                get
                {
                    return _datt;
                }
            }
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }

            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _loaikq;
            public Byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
             private Boolean _qadmin = false ;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public FindCriteria(String Mabn, DateTime ngaydk, string dk, Byte loai, byte loaikqcn, byte loaikq, string makhoa)
            {
                _mabn = Mabn;
                _ngaydk = ngaydk;
                _dk = dk;
                _loai = loai;
                _loaikqcn = loaikqcn;
                _loaikq = loaikq;
                _makhoa = makhoa;

            }
        }


        protected class CriteriaTL
        {

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
        /// Retrieve an existing <see cref="KhamBenh" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetKhamBenh(String _maSoKham);
            // public override IDataReader GetKhamBenh(String _maSoKham)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham));
            // }
            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh(crit.MaSoKham, crit.loai)))
            {
                if (dr.Read())
                {
                    //String _masokhamt = dr.GetString("masokham");
                    //_bhtrat = dr.GetDecimal("BHtra");
                    //_sotienbhtrat = dr.GetDecimal("SotienbhTra");
                    Fetch(dr, crit.loai, crit.dk, crit.loaikqcn, 0, "");
                    //if (dr.NextResult())
                    //{
                    //    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    //    _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //    _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    //    _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //    _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //    _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    //    _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    //}
                    //if (crit.loai != 3)
                    //{
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                    //        _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                    //        _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                    //        _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //        _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                    //        _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT  ;
                    //        _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_MauList = KhamBenh_MauList.GetKhamBenh_MauList(dr);
                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                    //    }
                    //}

                    //// loai = 0 : tiep don , loai = 1 : vien phi, loai = 2 : kham benh , loai = 3 : can lam sang
                    //if ((crit.loai == 0) || (crit.loai ==  1)) 
                    //{

                    //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt,0, crit.ngayyc,crit.loai,   crit.dk); 

                    //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt, 1, crit.ngayyc, crit.loai, crit.dk);

                    //}
                    //MarkOld();
                    //ValidationRules.CheckRules();

                }
                dr.Close(); dr.Dispose();
                // dr.Close();
            }
            //_TongTien = _TongTienBH + _TongTienTT;
            //if  (_TongTienBH <=_sotienbhtrat)
            //    _TongBHTra = _TongTienBH ;
            //else
            //    _TongBHTra = ((_TongTienBH ) * _bhtrat) / decimal.Parse("100")   ;
            //_TongBHKTra = TongTienBH - TongBHTra; 

            //if (_TongTienBHDTT  <= _sotienbhtrat)
            //    _TongBHTraDTT  = _TongTienBHDTT;
            //else
            //    _TongBHTraDTT = ((_TongTienBHDTT ) * _bhtrat) / decimal.Parse("100") ;
            //_TongThanhToan = _TongBHKTra - (_TongTienBHDTT - _TongBHTraDTT) + _TongTienTTCTT;
            //_TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
        }
        protected void DataPortal_Fetch(CriteriaTT crit)
        {


            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh(crit.Mabn, crit.ngaydk, crit.loai, crit.noitt)))
            {
                if (dr.Read())
                {

                    Fetch(dr, crit.loai, crit.noitt);


                }


            }

        }

        protected void DataPortal_Fetch(FindCriteria crit)
        {
            // public abstract IDataReader GetKhamBenh(String _maSoKham);
            // public override IDataReader GetKhamBenh(String _maSoKham)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham));
            // }

            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh(crit.Mabn, crit.ngaydk, crit.dk, crit.loai, crit.loaikq, crit.qadmin)))
            {
                if (dr.Read())
                {
                    //String _masokhamt = dr.GetString("masokham");
                    //_bhtrat = dr.GetDecimal("BHtra");
                    //_sotienbhtrat = dr.GetDecimal("SotienbhTra");
                    Fetch(dr, crit.loai, crit.dk, crit.loaikqcn, crit.loaikq, crit.Makhoa);

                    //if (crit.loai == 2)
                    //{
                    //    if (dr.NextResult())
                    //    {

                    //        _KhamBenh_HoaDonList = KhamBenh_HoaDonList.GetKhamBenh_HoaDonList(dr);  
                    //    }
                    //}
                    //if (dr.NextResult())
                    //{
                    //    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    //    _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //    _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    //    _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //    _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //    _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    //    _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    //}
                    //if (crit.loai != 4)
                    //{
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                    //        _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                    //        _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                    //        _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //        _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                    //        _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                    //        _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_MauList = KhamBenh_MauList.GetKhamBenh_MauList(dr);
                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                    //    }
                    //}

                    //// loai = 1 : tiep don , loai = 2 : vien phi, loai = 3 : kham benh , loai = 4 : can lam sang
                    //if ((crit.loai == 1) || (crit.loai == 2))
                    //{


                    //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt, 0, crit.ngaydk, crit.loai, crit.dk);

                    //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt, 1, crit.ngaydk, crit.loai, crit.dk);


                    //}
                    //MarkOld();
                    //ValidationRules.CheckRules();
                }
                // dr.Close();
                dr.Close(); dr.Dispose();
            }
            //_TongTien = _TongTienBH + _TongTienTT;
            //if (_TongTienBH <= _sotienbhtrat)
            //    _TongBHTra = _TongTienBH;
            //else
            //    _TongBHTra = (_TongTienBH  * _bhtrat) / decimal.Parse("100") ;
            //_TongBHKTra = TongTienBH - TongBHTra;

            //if (_TongTienBHDTT <= _sotienbhtra)
            //    _TongBHTraDTT = _TongTienBHDTT;
            //else
            //    _TongBHTraDTT = ((_TongTienBHDTT ) * _bhtrat) / decimal.Parse("100") ;
            //_TongThanhToan = _TongBHKTra - (_TongTienBHDTT - _TongBHTraDTT) + _TongTienTTCTT;
            //_TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
        }
        /// <summary>
        /// Load a <see cref="KhamBenh" /> Object from given SafeDataReader.
        /// </summary>
        /// 
        private void Fetch(SafeDataReader dr, byte loaiphieu, string _noitt)
        {
            // Value properties

            //if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            //if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            //if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
            if (dr.GetSmartDate("GiatriDN", true) != null) _giatriDN = dr.GetSmartDate("GiatriDN", true);
            if (dr.GetSmartDate("GiatritN", true) != null) _giaTriTN = dr.GetSmartDate("GiatritN", true);
            if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
            if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
            if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetSmartDate("NgayGT", true) != null) _ngayGT = dr.GetSmartDate("NgayGT", true);

            if (dr.GetString("Gio") != null) _gio = dr.GetString("Gio");
            if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
            if (dr.GetString("Nguoiduyet") != null) _nguoiduyet = dr.GetString("Nguoiduyet");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
            if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
            if (dr.GetString("MaBenhNoiGT") != null) _maBenhNoiGT = dr.GetString("MaBenhNoiGT");
            if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
            if (dr.GetString("CDNoiGT") != null) _cDNoiGT = dr.GetString("CDNoiGT");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetByte("LoaiKham") != null) _loaiKham = dr.GetByte("LoaiKham");
            if (dr.GetBoolean("Cungtra") != null) _cungtra = dr.GetBoolean("Cungtra");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetSmartDate("ngaydk", true) != null) _ngayDK = dr.GetSmartDate("ngaydk", true);
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
            if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
            if (dr.GetDecimal("TongDV") != null) _TongDV = dr.GetDecimal("TongDV");
            if (dr.GetDecimal("TongThuocTY") != null) _TongThuocTY = dr.GetDecimal("TongThuocTY");
            if (dr.GetDecimal("TongThuocDY") != null) _TongThuocDY = dr.GetDecimal("TongThuocDY");
            if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("tongTien");
            if (dr.GetDecimal("KyQuyBH") != null) _KyQuyBH = dr.GetDecimal("KyQuyBH");
            //if (dr.GetDecimal("TongTienBH") != null) _TongTienBH = dr.GetDecimal("tongTienBH");
            //if (dr.GetDecimal("TongBHTra") != null) _TongBHTra = dr.GetDecimal("TongBHTra");
            if (dr.GetDecimal("bhtra") != null) _bhtra = dr.GetDecimal("bhtra");
            if (dr.GetBoolean("duyetbh") != null) _DuyetBH = dr.GetBoolean("duyetbh");
            if (dr.GetDecimal("sotienbhtra") != null) _sotienbhtra = dr.GetDecimal("sotienbhtra");
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenbv") != null) _tenbv = dr.GetString("tenbv");
            if (dr.GetString("tenbenhngt") != null) _tenbenhngt = dr.GetString("tenbenhngt");
            if (dr.GetString("maicdngt") != null) _maicdngt = dr.GetString("maicdngt");
            if (dr.GetString("sophieuttrv") != null) _sophieuttrv = dr.GetString("sophieuttrv");
            if (dr.GetString("MABHXHGT") != null) this._maBHXHGT = dr.GetString("MABHXHGT");
            if (dr.GetString("MaBVGT") != null) _maBVGT = dr.GetString("MaBVGT");
            if (dr.GetString("tenbvGT") != null) _tenBVGT = dr.GetString("tenbvGT");
            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;
            _TongTienTTDTTKTra = 0;
            _loai = loaiphieu;
            _KhamBenh_ThuocSDList._loai = _loai;
            _KhamBenh_C_List._loai = _loai;
            _KhamBenh_VTTHList._loai = _loai;
            _KhamBenh_HoaChatList._loai = _loai;
            _KhamBenh_MauList._loai = _loai;
            if ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) || _loai == 7)
            {
                if (dr.NextResult())
                {
                    _KhamBenh_HoaDonList = KhamBenh_HoaDonList.GetKhamBenh_HoaDonList(dr);
                    //_TongHD = _KhamBenh_HoaDonList._TongTT;
                }
            }



            if ((_loai != 7 && _loai != 6))
            {
                if (dr.NextResult())
                {
                    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr, _loai);

                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                }
            }
            else if ((_loai == 7 &&  (_noitt == "090" ||_noitt =="094" || (_noitt =="085" &&HTC.ShareVariables.pub_spC =="QN"))))
            {
                if (dr.NextResult())
                {
                    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr, _loai, _noitt);

                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                }
            }
            else if (_loai != 6 && _loai != 7 && _loai != 1)
            {
                if (dr.NextResult())
                {
                    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;

                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;

                }
            }
            if (_loai != 1)
            {
                if (_loai != 4  && _loai != 6)
                {
                    if (!(_noitt == "090" || _noitt == "094" || (_loai == 7 && _noitt == "087")))
                        if (dr.NextResult())
                        {
                            _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                            //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                            //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                            ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                            //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                            //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                            ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                        }
                    if (_TongThuocDY != 0 && (_loai == 11 || _loai == 2 || _loai == 7 || _loai == 3)&&_loaiKham !=2)
                        if (dr.NextResult())
                        {
                            _KhamBenh_ThuocSD_DYList = KhamBenh_ThuocSD_DYList.GetKhamBenh_ThuocSD_DYList(dr);
                            //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                            //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                            ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                            //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                            //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                            ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                        }
                    if (dr.NextResult())
                    {
                        _KhamBenh_MauList = KhamBenh_MauList.GetKhamBenh_MauList(dr);
                        //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_MauList._TongBHCTT;
                        //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_MauList._TongBH;
                        ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                        //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_MauList._TongTTCTT;
                        //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_MauList._TongTT;
                        ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    }
                    if (dr.NextResult())
                    {
                        _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                        //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_VTTHList._TongBHCTT;
                        //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_VTTHList._TongBH;
                        ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                        //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_VTTHList._TongTTCTT;
                        //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_VTTHList._TongTT;
                        ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    }
                    if (dr.NextResult())
                    {
                        _KhamBenh_HoaChatList = KhamBenh_HoaChatList.GetKhamBenh_HoaChatList(dr);
                        //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_HoaChatList._TongBHCTT;
                        //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_HoaChatList._TongBH;
                        ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                        //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_HoaChatList._TongTTCTT;
                        //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_HoaChatList._TongTT;
                        ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    }
                }
                dr.Close();
                dr = null;
            }
            // cac dich vu thanh toan
            // loai = 1 : tiep don , loai = 2 : vien phi, loai = 3 : kham benh , loai = 4 : can lam sang
            if (_KhamBenh_C_List.Count > 0 || _KhamBenh_VTTHList.Count > 0 || _KhamBenh_HoaChatList.Count > 0 || _KhamBenh_MauList.Count > 0 || _KhamBenh_ThuocSDList.Count > 0 || _KhamBenh_ThuocSD_DYList.Count > 0)
            {
              
                    //chua thanh toan

                    int i = 1;
                    // xn
                    foreach (KhamBenh_C _kbc in _KhamBenh_C_List)
                      //  if (_kbc.DaTT == 0 && ( _loai ==1 ||(_loai ==2&&HTC .ShareVariables .pub_spC =="HU") ||(_kbc .BHTinhtien ==true && _kbc.Tinhtien ==false &&(_loai ==2||_loai ==11))||(_loai ==9&&(_kbc.BHTinhtien ==false||_kbc .Tinhtien ==true))))
                        if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DaTT == 0 && (_loai == 1 || (_loai == 2 && (HTC.ShareVariables.pub_spC == "HU"  || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || (((_loai == 9 || _loai == 8)|| _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                            {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                                  _kbc.MaSoKham,
                                   1,
                                   _kbc.MaDV,
                                  _kbc.TenDV ,
                                  _kbc.STT,
                                   decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                                   decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                                   _kbc.ADGiaUSD,
                                   decimal.Parse(_kbc.slmua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra),
                                   _kbc.Makhoa,
                                  _kbc.BSKham,
                                   _kbc.Tinhtien,
                                   _kbc.BHTinhtien,
                                   _kbc.DaTT,
                                   decimal.Parse(_kbc.CK==""?"0":_kbc.CK ),
                                  _kbc.tenkhoa,
                                  _kbc.tenbs,
                                   SmartDate.Parse(_kbc.NgayDK),
                                   SmartDate.Parse(null),
                                  null,
                                  null,
                                   SmartDate.Parse(null),
                                   SmartDate.Parse(null),
                                  null,
                                  null,
                                  null,
                                  null,
                                  i,
                                 _kbc.SoSoHD,
                                 _kbc.SoHD,
                                 decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                                 SmartDate.Parse(_kbc.NgayGioKham),
                                    _kbc.tentat,
                                        _kbc.inthu,
                                        _kbc.DuyetBH
                              );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuCTTList.Add(item);
                            i += 1;

                        };
                    //thuoc
                    foreach (KhamBenh_ThuocSD _kbc in _KhamBenh_ThuocSDList)
                       // if (_kbc.DATT == 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (((_loai == 9 || _loai == 8)|| _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || (_loai == 7 && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                        if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DATT == 0 && (_loai == 1 || (_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) ||  (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || ((_loai == 9||_loai == 8||_loai ==7) && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || (((_loai == 9 || _loai == 8)|| _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                          _kbc.MaSoKham,
                           2,
                           _kbc.Mathuoc,
                          _kbc.TenTM,
                          _kbc.STT,
                           decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                           decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                          false,
                            decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra),
                           _kbc.Makhoa,
                          _kbc.BSChiDinh,
                           _kbc.Tinhtien,
                           _kbc.BHTinhtien,
                           _kbc.DATT,
                          decimal.Parse(_kbc.CK==""?"0":_kbc.CK ),
                          null,
                          _kbc.tenbschidinh,
                           SmartDate.Parse(_kbc.NgayDK),
                           SmartDate.Parse(null),
                          null,
                          null,
                           SmartDate.Parse(null),
                           SmartDate.Parse(null),
                          null,
                          null,
                          null,
                          null,
                          i,
                         _kbc.SoSoHD,
                         _kbc.SoHD,
                         decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                         SmartDate.Parse(_kbc.NgayDK),
                            _kbc.Mathuoc,
                                false,
                                _kbc.DuyetBH
                          );
                                    item.OrderNumber = i;
                                    _KhamBenh_GetsDichVuCTTList.Add(item);
                                    i += 1;

                        }
                    // thuoc dy
                    foreach (KhamBenh_ThuocSD_DY _kb in _KhamBenh_ThuocSD_DYList)
                        if (_kb.DATT == 0 && ( (_kb.MaDT.Substring(0, 1) != "0" && _kb.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 7 && (_kb.MaDT.Substring(0, 1) == "0" || _kb.Tinhtien == true || _kb.MaDT.Substring(0, 1) == "3" || _kb.MaDT.Substring(0, 1) == "2"))))
                        {
                            foreach (KhamBenh_ThuocSD_DY_C _kbc in _kb.KhamBenh_ThuocSD_DY_Cs)
                            {
                                KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                      _kbc.MaSoKham,
                       1,
                       _kbc.Mathuoc,
                      _kbc.TenTM,
                      _kbc.STT,
                       decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT)/ _kbc.QuyDoi ,
                       decimal.Parse(_kbc.DongiaBH == "" ? "0" : _kbc.DongiaBH) / _kbc.QuyDoi,
                      false,
                       decimal.Parse(_kbc.SLKeDon) * (decimal.Parse(_kb.SLMua) )* _kbc.QuyDoi ,
                        decimal.Parse(_kbc.SLKeDon) * ( _kb.SLTra) * _kbc.QuyDoi,
                       _kb.MaKhoa,
                      _kb.BSChiDinh,
                       _kbc.Tinhtien,
                       _kbc.BHTinhtien,
                       _kb.DATT,
                      _kb.CK,
                      null,
                      _kb.TenBSChidinh,
                       SmartDate.Parse(_kb.NgayDK),
                       SmartDate.Parse(null),
                      null,
                      null,
                       SmartDate.Parse(null),
                       SmartDate.Parse(null),
                      null,
                      null,
                      null,
                      null,
                      i,
                     _kb.SoSoHD,
                     _kb.SoHD,
                     decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                     SmartDate.Parse(_kb.NgayDK),
                        _kbc.Mathuoc,
                            false,
                            _kb.DuyetBH
                      );
                                item.OrderNumber = i;
                                _KhamBenh_GetsDichVuCTTList.Add(item);
                                i += 1;

                            }
                        }
                            //vtth
                            foreach (KhamBenh_VTTH _kbc in _KhamBenh_VTTHList)
                                if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DATT == 0 && (_loai == 1 || (_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH"))|| (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                                    //if (_kbc.DATT == 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                         {
                                    KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                          _kbc.MaSoKham,
                           3,
                           _kbc.MaVT,
                          _kbc.TenTM,
                          _kbc.STT,
                           decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                           decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                          false,
                          decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                          _kbc.BSChiDinh,
                           _kbc.Tinhtien,
                           _kbc.BHTinhtien,
                           _kbc.DATT,
                          decimal.Parse(_kbc.CK == "" ? "0" : _kbc.CK),
                          null,
                          _kbc.tenbschidinh,
                           SmartDate.Parse(_kbc.NgayDK),
                           SmartDate.Parse(null),
                          null,
                          null,
                           SmartDate.Parse(null),
                           SmartDate.Parse(null),
                          null,
                          null,
                          null,
                          null,
                          i,
                         _kbc.SoSoHD,
                         _kbc.SoHD,
                         decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                         SmartDate.Parse(_kbc.NgayDK),
                            _kbc.MaVT,
                                false,
                                _kbc.DuyetBH
                          );
                                    item.OrderNumber = i;
                                    _KhamBenh_GetsDichVuCTTList.Add(item);
                                    i += 1;

                               
                        }
                      //hoa chat
                    foreach (KhamBenh_HoaChat _kbc in _KhamBenh_HoaChatList)
                        if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DATT == 0 && (_loai == 1 || (_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                          //  if (_kbc.DATT == 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                  _kbc.MaSoKham,
                   4,
                   _kbc.MaHC,
                  _kbc.TenTM,
                  _kbc.STT,
                   decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                   decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                  false,
                    decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                 
                  _kbc.BSChiDinh,
                   _kbc.Tinhtien,
                   _kbc.BHTinhtien,
                   _kbc.DATT,
                  decimal.Parse(_kbc.CK==""?"0":_kbc.CK ),
                  null,
                  _kbc.tenbschidinh,
                   SmartDate.Parse(_kbc.NgayDK),
                   SmartDate.Parse(null),
                  null,
                  null,
                   SmartDate.Parse(null),
                   SmartDate.Parse(null),
                  null,
                  null,
                  null,
                  null,
                  i,
                 _kbc.SoSoHD,
                 _kbc.SoHD,
                 decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                 SmartDate.Parse(_kbc.NgayDK),
                    _kbc.MaHC ,
                        false,
                        _kbc.DuyetBH
                  );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuCTTList.Add(item);
                            i += 1;

                        }
                     //mau
                    foreach (KhamBenh_Mau _kbc in _KhamBenh_MauList)
                        if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DATT == 0 && (_loai == 1 || (_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                            //if (_kbc.DATT == 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                  _kbc.MaSoKham,
                   5,
                   _kbc.MaCPMau,
                  _kbc.TenTM,
                  _kbc.STT,
                   decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                   decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                  false,
                    decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                  _kbc.BSChiDinh,
                   _kbc.Tinhtien,
                   _kbc.BHTinhtien,
                   _kbc.DATT,
                  decimal.Parse(_kbc.CK==""?"0":_kbc.CK ),
                  null,
                  _kbc.tenbschidinh,
                   SmartDate.Parse(_kbc.NgayDK),
                   SmartDate.Parse(null),
                  null,
                  null,
                   SmartDate.Parse(null),
                   SmartDate.Parse(null),
                  null,
                  null,
                  null,
                  null,
                  i,
                 _kbc.SoSoHD,
                 _kbc.SoHD,
                 decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                 SmartDate.Parse(_kbc.NgayDK),
                    _kbc.MaCPMau,
                        false,
                        _kbc.DuyetBH
                  );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuCTTList.Add(item);
                            i += 1;

                        }
                    //da thanh toan

                     i = 1;
                    // xn
                    foreach (KhamBenh_C _kbc in _KhamBenh_C_List)

                        if ((_loai == 11 && _kbc.DuyetBH == true) || (_kbc.DaTT != 0 && ((_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || (((_loai == 9 || _loai == 8)|| _loai == 7) && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                                  _kbc.MaSoKham,
                                   1,
                                   _kbc.MaDV,
                                  _kbc.TenDV,
                                  _kbc.STT,
                                   decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                                   decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                                   _kbc.ADGiaUSD,
                                    decimal.Parse(_kbc.slmua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                                  _kbc.BSKham,
                                   _kbc.Tinhtien,
                                   _kbc.BHTinhtien,
                                   _kbc.DaTT,
                                   decimal.Parse(_kbc.CK == "" ? "0" : _kbc.CK),
                                  _kbc.tenkhoa,
                                  _kbc.tenbs,
                                   SmartDate.Parse(_kbc.NgayDK),
                                   SmartDate.Parse(null),
                                  null,
                                  null,
                                   SmartDate.Parse(null),
                                   SmartDate.Parse(null),
                                  null,
                                  null,
                                  null,
                                  null,
                                  i,
                                 _kbc.SoSoHD,
                                 _kbc.SoHD,
                                 decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                                 SmartDate.Parse(_kbc.NgayGioKham),
                                    _kbc.tentat,
                                        _kbc.inthu,
                                        _kbc.DuyetBH
                              );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuList.Add(item);
                            i += 1;

                        };
                    //thuoc
                    foreach (KhamBenh_ThuocSD _kbc in _KhamBenh_ThuocSDList)
                        if ((_loai == 11 && _kbc.DuyetBH == true) || (_kbc.DATT != 0 && ((_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || (((_loai == 9 || _loai == 8)|| _loai == 7) && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                            //if (_kbc.DATT != 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || (_loai == 7 && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                          _kbc.MaSoKham,
                           2,
                           _kbc.Mathuoc,
                          _kbc.TenTM,
                          _kbc.STT,
                           decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT) ,
                           decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH) ,
                          false,
                            decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                          _kbc.BSChiDinh,
                           _kbc.Tinhtien,
                           _kbc.BHTinhtien,
                           _kbc.DATT,
                          decimal.Parse(_kbc.CK == "" ? "0" : _kbc.CK),
                          null,
                          _kbc.tenbschidinh,
                           SmartDate.Parse(_kbc.NgayDK),
                           SmartDate.Parse(null),
                          null,
                          null,
                           SmartDate.Parse(null),
                           SmartDate.Parse(null),
                          null,
                          null,
                          null,
                          null,
                          i,
                         _kbc.SoSoHD,
                         _kbc.SoHD,
                         decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                         SmartDate.Parse(_kbc.NgayDK),
                            _kbc.Mathuoc,
                                false,
                                _kbc.DuyetBH
                          );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuList.Add(item);
                            i += 1;

                        }
                    // thuoc dy
                    foreach (KhamBenh_ThuocSD_DY _kb in _KhamBenh_ThuocSD_DYList)
                        if (_kb.DATT != 0 && ((_kb.MaDT.Substring(0, 1) != "0" && _kb.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 7 && (_kb.MaDT.Substring(0, 1) == "0" || _kb.Tinhtien == true || _kb.MaDT.Substring(0, 1) == "3" || _kb.MaDT.Substring(0, 1) == "2"))))
                        {
                            foreach (KhamBenh_ThuocSD_DY_C _kbc in _kb.KhamBenh_ThuocSD_DY_Cs)
                            {
                                KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                      _kbc.MaSoKham,
                       1,
                       _kbc.Mathuoc,
                      _kbc.TenTM,
                      _kbc.STT,
                       decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT)/ _kbc.QuyDoi,
                       decimal.Parse(_kbc.DongiaBH == "" ? "0" : _kbc.DongiaBH) / _kbc.QuyDoi,
                      false,
                     
                         decimal.Parse(_kbc.SLKeDon) * (decimal.Parse(_kb.SLMua)) * _kbc.QuyDoi,
                        decimal.Parse(_kbc.SLKeDon) * (_kb.SLTra) * _kbc.QuyDoi,
                       _kb.MaKhoa,
                      _kb.BSChiDinh,
                       _kbc.Tinhtien,
                       _kbc.BHTinhtien,
                       _kb.DATT,
                      _kb.CK,
                      null,
                      _kb.TenBSChidinh,
                       SmartDate.Parse(_kb.NgayDK),
                       SmartDate.Parse(null),
                      null,
                      null,
                       SmartDate.Parse(null),
                       SmartDate.Parse(null),
                      null,
                      null,
                      null,
                      null,
                      i,
                     _kb.SoSoHD,
                     _kb.SoHD,
                     decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                     SmartDate.Parse(_kb.NgayDK),
                        _kbc.Mathuoc,
                            false,
                            _kb.DuyetBH
                      );
                                item.OrderNumber = i;
                                _KhamBenh_GetsDichVuList.Add(item);
                                i += 1;

                            }
                        }
          
                            //vtth
                            foreach (KhamBenh_VTTH _kbc in _KhamBenh_VTTHList)
                                if ((_loai == 11 && _kbc.DuyetBH == true) || (_kbc.DATT != 0 && ((_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) ||  (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || (((_loai == 9 || _loai == 8)|| _loai == 7) && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                    
                              //  if (_kbc.DATT != 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 2 && HTC.ShareVariables.pub_spC == "HU") || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                                {
                                    KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                          _kbc.MaSoKham,
                           3,
                           _kbc.MaVT,
                          _kbc.TenTM,
                          _kbc.STT,
                           decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                           decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                          false,
                           decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                          _kbc.BSChiDinh,
                           _kbc.Tinhtien,
                           _kbc.BHTinhtien,
                           _kbc.DATT,
                          decimal.Parse(_kbc.CK == "" ? "0" : _kbc.CK),
                          null,
                          _kbc.tenbschidinh,
                           SmartDate.Parse(_kbc.NgayDK),
                           SmartDate.Parse(null),
                          null,
                          null,
                           SmartDate.Parse(null),
                           SmartDate.Parse(null),
                          null,
                          null,
                          null,
                          null,
                          i,
                         _kbc.SoSoHD,
                         _kbc.SoHD,
                         decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                         SmartDate.Parse(_kbc.NgayDK),
                            _kbc.MaVT,
                                false,
                                _kbc.DuyetBH
                          );
                                    item.OrderNumber = i;
                                    _KhamBenh_GetsDichVuList.Add(item);
                                    i += 1;

                                }
                    
                    //hoa chat
                    foreach (KhamBenh_HoaChat _kbc in _KhamBenh_HoaChatList)
                        if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DATT != 0 && ((_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || (((_loai == 9 || _loai == 8)|| _loai == 7) && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                        //  if (_kbc.DATT != 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 2 && HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                  _kbc.MaSoKham,
                   4,
                   _kbc.MaHC,
                  _kbc.TenTM,
                  _kbc.STT,
                   decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                   decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                  false,
                    decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                  _kbc.BSChiDinh,
                   _kbc.Tinhtien,
                   _kbc.BHTinhtien,
                   _kbc.DATT,
                  decimal.Parse(_kbc.CK == "" ? "0" : _kbc.CK),
                  null,
                  _kbc.tenbschidinh,
                   SmartDate.Parse(_kbc.NgayDK),
                   SmartDate.Parse(null),
                  null,
                  null,
                   SmartDate.Parse(null),
                   SmartDate.Parse(null),
                  null,
                  null,
                  null,
                  null,
                  i,
                 _kbc.SoSoHD,
                 _kbc.SoHD,
                 decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                 SmartDate.Parse(_kbc.NgayDK),
                    _kbc.MaHC,
                        false,
                        _kbc.DuyetBH
                  );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuList.Add(item);
                            i += 1;

                        }
                    //mau
                    foreach (KhamBenh_Mau _kbc in _KhamBenh_MauList)
                        if ((_loai == 11 && _kbc.DuyetBH == false) || (_kbc.DATT != 0 && ((_loai == 2 && (HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH")) || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && _loai == 2) || (((_loai == 9 || _loai == 8)|| _loai == 7) && (_kbc.BHTinhtien == false || _kbc.Tinhtien == true)) || ((_loai == 9 || _loai == 8)&& (_kbc.MaDT == "30001" || _kbc.MaDT == "20002")))))
                            //if (_kbc.DATT != 0 && ((_loai == 2 && HTC.ShareVariables.pub_spC == "HU") || (_kbc.BHTinhtien == true && _kbc.Tinhtien == false && (_loai == 2 || _loai == 11)) || (_loai == 2 && HTC.ShareVariables.pub_spC == "HU") || ((_loai == 9 || _loai == 8)&& (_kbc.BHTinhtien == false || _kbc.Tinhtien == true))))
                        {
                            KhamBenh_GetsDichVu item = new KhamBenh_GetsDichVu(

                  _kbc.MaSoKham,
                   5,
                   _kbc.MaCPMau,
                  _kbc.TenTM,
                  _kbc.STT,
                   decimal.Parse(_kbc.DongiaTT == "" ? "0" : _kbc.DongiaTT),
                   decimal.Parse(_kbc.DonGiaBH == "" ? "0" : _kbc.DonGiaBH),
                  false,
                    decimal.Parse(_kbc.SLMua),
                                   decimal.Parse(_kbc.SLTra == "" ? "0" : _kbc.SLTra), _kbc.Makhoa,
                      
                  _kbc.BSChiDinh,
                   _kbc.Tinhtien,
                   _kbc.BHTinhtien,
                   _kbc.DATT,
                  decimal.Parse(_kbc.CK == "" ? "0" : _kbc.CK),
                  null,
                  _kbc.tenbschidinh,
                   SmartDate.Parse(_kbc.NgayDK),
                   SmartDate.Parse(null),
                  null,
                  null,
                   SmartDate.Parse(null),
                   SmartDate.Parse(null),
                  null,
                  null,
                  null,
                  null,
                  i,
                 _kbc.SoSoHD,
                 _kbc.SoHD,
                 decimal.Parse(_kbc.GiaChenhLech == "" ? "0" : _kbc.GiaChenhLech),
                 SmartDate.Parse(_kbc.NgayDK),
                    _kbc.MaCPMau,
                        false,
                        _kbc.DuyetBH
                  );
                            item.OrderNumber = i;
                            _KhamBenh_GetsDichVuList.Add(item);
                            i += 1;

                        }
                    //foreach (KhamBenh_C _kbc in _KhamBenh_C_List)
                    //    if (_kbc.DaTT == 0)
                    //    {
                    //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 2, "and a.noitttt ='" + _noitt + "'");
                    //        break;
                    //    }
                    //if (_KhamBenh_GetsDichVuCTTList.Count != 0)
                    //{
                    //    foreach (KhamBenh_ThuocSD _kbc in _KhamBenh_ThuocSDList)
                    //        if (_kbc.DATT == 0)
                    //        {
                    //            _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 2, "and a.noitttt ='" + _noitt + "'");
                    //            break;
                    //        }
                    //}
                    //if (_KhamBenh_GetsDichVuCTTList.Count != 0)
                    //{
                    //    foreach (KhamBenh_ThuocSD_DY _kbc in _KhamBenh_ThuocSD_DYList)
                    //        if (_kbc.DATT == 0)
                    //        {
                    //            _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 2, "and a.noitttt ='" + _noitt + "'");
                    //            break;
                    //        }
                    //}
                    //if (_KhamBenh_HoaDonList.Count > 0 || _ngayQT != null)
                    //    _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, 2, "and a.noitttt ='" + _noitt + "'");
                    //else
                    //    foreach (KhamBenh_C _kbc in _KhamBenh_C_List)
                    //        if (_kbc.DaTT != 0)
                    //        {
                    //            _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, 2, "and a.noitttt ='" + _noitt + "'");
                    //            break;
                    //        }

                }
                //else if ((_loai == 9))
                //{
                //    //91
                //    //if (_noitt =="093" &&HTC .ShareVariables.pub_spC=="PS")
                //    //    _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 9, "");
                //    //else
                //    foreach (KhamBenh_C _kbc in _KhamBenh_C_List)
                //        if (_kbc.DaTT == 0)
                //        {
                //            _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 9, "and a.noitttt ='" + _noitt + "'");
                //            break;
                //        }
                //    if (_KhamBenh_GetsDichVuCTTList.Count == 0)
                //    {
                //        foreach (KhamBenh_ThuocSD _kbc in _KhamBenh_ThuocSDList)
                //            if (_kbc.DATT == 0)
                //            {
                //                _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 9, "and a.noitttt ='" + _noitt + "'");
                //                break;
                //            }
                //    }
                   
                //    if (_KhamBenh_HoaDonList.Count > 0)
                //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, 9, "and a.noitttt ='" + _noitt + "'");


                //}
                //// else if (((_loai == 1) || (_loai == 11) || ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) && (_loaiKham != 2)) || (_loai == 7)))
                //else if (((_loai == 11) || ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) && (_loaiKham != 2)) || (_loai == 7)))
                //{
                //    if (_loai == 7 && _noitt == "090")
                //    {
                //        foreach (KhamBenh_ThuocSD_DY _kbc in _KhamBenh_ThuocSD_DYList)
                //            if (_kbc.DATT == 0)
                //            {
                //                _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 77, "");
                //                break;
                //            }
                //    }
                //    else if (_loai == 7)
                //        if (_KhamBenh_GetsDichVuCTTList.Count == 0)
                //        {
                //            foreach (KhamBenh_ThuocSD _kbc in _KhamBenh_ThuocSDList)
                //                if (_kbc.DATT == 0)
                //                {
                //                    _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, _loai, "");
                //                    break;
                //                }
                //        }
                //        else if (_loai == 11)
                //            _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, _loai, "");
                //        else
                //            _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, _loai, "and a.noitttt ='" + _noitt + "'");

                //    if ((_KhamBenh_HoaDonList.Count > 0 || _ngayQT != null) && (_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 7))
                //    {
                //        if (_loai == 7 && _noitt == "090")
                //            _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, 77, "and a.noitttt ='" + _noitt + "'");
                //        else
                //            _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, _loai, "and a.noitttt ='" + _noitt + "'");
                //    }
                //    else if (_loai == 1)
                //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, _loai, "and a.noitttt ='" + _noitt + "'");

               // }
    
           // }
            if (dr != null)
            {
                dr.Close();
                dr = null;
            }

            if ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) || _loai == 3 || _loai == 7 || _loai == 11)
            {

                TinhLaiTienKhamBenh();
            };

        }

        private void Fetch(SafeDataReader dr, byte loaiphieu, string dk, Byte _loaikqcn, Byte _loaikq, string _makhoa)
        {
            // Value properties
            //if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            //if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            //if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
            if (dr.GetSmartDate("GiatriDN", true) != null) _giatriDN = dr.GetSmartDate("GiatriDN", true);
            if (dr.GetSmartDate("GiatritN", true) != null) _giaTriTN = dr.GetSmartDate("GiatritN", true);
            if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
            if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
            if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetSmartDate("NgayGT", true) != null) _ngayGT = dr.GetSmartDate("NgayGT", true);

            if (dr.GetString("Gio") != null) _gio = dr.GetString("Gio");
            //if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
            //if (dr.GetString("Nguoiduyet") != null) _nguoiduyet = dr.GetString("Nguoiduyet");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
            if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
            if (dr.GetString("MaBenhNoiGT") != null) _maBenhNoiGT = dr.GetString("MaBenhNoiGT");
            if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
            if (dr.GetString("CDNoiGT") != null) _cDNoiGT = dr.GetString("CDNoiGT");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetByte("LoaiKham") != null) _loaiKham = dr.GetByte("LoaiKham");
            if (dr.GetBoolean("Cungtra") != null) _cungtra = dr.GetBoolean("Cungtra");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            //if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            //if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            //if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            //if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            //if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            //if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            //if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            //if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetSmartDate("ngaydk", true) != null) _ngayDK = dr.GetSmartDate("ngaydk", true);
            //if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            //if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
            if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
            if (dr.GetDecimal("TongDV") != null) _TongDV = dr.GetDecimal("TongDV");
            if (dr.GetDecimal("TongThuocTY") != null) _TongThuocTY = dr.GetDecimal("TongThuocTY");
            if (dr.GetDecimal("TongThuocDY") != null) _TongThuocDY = dr.GetDecimal("TongThuocDY");
            if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("tongTien");
            if (dr.GetDecimal("KyQuyBH") != null) _KyQuyBH = dr.GetDecimal("KyQuyBH");
            //if (dr.GetDecimal("TongTienBH") != null) _TongTienBH = dr.GetDecimal("tongTienBH");
            //if (dr.GetDecimal("TongBHTra") != null) _TongBHTra = dr.GetDecimal("TongBHTra");
            if (dr.GetDecimal("bhtra") != null) _bhtra = dr.GetDecimal("bhtra");
            if (dr.GetBoolean("duyetbh") != null) _DuyetBH = dr.GetBoolean("duyetbh");
            if (dr.GetDecimal("sotienbhtra") != null) _sotienbhtra = dr.GetDecimal("sotienbhtra");
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenbv") != null) _tenbv = dr.GetString("tenbv");
            if (dr.GetString("tenbenhngt") != null) _tenbenhngt = dr.GetString("tenbenhngt");
            if (dr.GetString("maicdngt") != null) _maicdngt = dr.GetString("maicdngt");
            if (dr.GetString("sophieuttrv") != null) _sophieuttrv = dr.GetString("sophieuttrv");
            if (dr.GetString("MABHXHGT") != null) this._maBHXHGT = dr.GetString("MABHXHGT");
            if (dr.GetString("MaBVGT") != null) _maBVGT = dr.GetString("MaBVGT");
            if (dr.GetString("tenbvGT") != null) _tenBVGT = dr.GetString("tenbvGT");
            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;
            _TongTienTTDTTKTra = 0;
            _loai = loaiphieu;
            _KhamBenh_ThuocSDList._loai = _loai;
            _KhamBenh_C_List._loai = _loai;
            _KhamBenh_VTTHList._loai = _loai;
            _KhamBenh_HoaChatList._loai = _loai;
            _KhamBenh_MauList._loai = _loai;
            if ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) || _loai == 7)
            {
                if (dr.NextResult())
                {
                    _KhamBenh_HoaDonList = KhamBenh_HoaDonList.GetKhamBenh_HoaDonList(dr);
                    //_TongHD = _KhamBenh_HoaDonList._TongTT;
                }
            }



            if (_loai != 7 && _loai != 6)
            {
                if (dr.NextResult())
                {
                      if (_loai == 3)
                    {
                        KhamBenh_C_List kbl = KhamBenh_C_List.GetKhamBenh_C_List(dr,_loai );
                        foreach (KhamBenh_C kb in kbl)
                        {
                            if (kb.MaDT == "00006")
                                _KhamBenh_TTNgoai_List.Add(kb);
                            else
                                _KhamBenh_C_List.Add(kb);
                        }
                    }
                    else
                    {
                        _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr, _loai);
                    }
                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                }
            }
            else if (_loai != 6 && _loai != 7)
            {
                if (dr.NextResult())
                {
                    if (_loai == 3)
                    {
                        KhamBenh_C_List kbl = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                        foreach (KhamBenh_C kb in kbl)
                        {
                            if (kb.MaDT == "00006")
                                _KhamBenh_TTNgoai_List.Add(kb);
                            else
                                _KhamBenh_C_List.Add(kb);
                        }
                    }
                    else
                    {
                        _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    }
                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;

                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;

                }
            }
            if ( _loai != 6) //_loai != 4
            {
                if (_TongThuocTY != 0)
                    if (dr.NextResult())
                    {
                        _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                        //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                        //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                        ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                        //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                        //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                        ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                    }
                if (_TongThuocDY != 0 && (HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN") && _loaiKham != 2)
                    if (dr.NextResult())
                    {
                        _KhamBenh_ThuocSD_DYList = KhamBenh_ThuocSD_DYList.GetKhamBenh_ThuocSD_DYList(dr);
                        //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                        //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                        ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                        //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                        //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                        ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                    }
                if (dr.NextResult())
                {
                    _KhamBenh_MauList = KhamBenh_MauList.GetKhamBenh_MauList(dr);
                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_MauList._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_MauList._TongBH;
                    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_MauList._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_MauList._TongTT;
                    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                }
                if (dr.NextResult())
                {
                    _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_VTTHList._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_VTTHList._TongBH;
                    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_VTTHList._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_VTTHList._TongTT;
                    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                }
                if (dr.NextResult())
                {
                    _KhamBenh_HoaChatList = KhamBenh_HoaChatList.GetKhamBenh_HoaChatList(dr);
                    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_HoaChatList._TongBHCTT;
                    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_HoaChatList._TongBH;
                    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_HoaChatList._TongTTCTT;
                    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_HoaChatList._TongTT;
                    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                }
            }
            dr.Close();
            dr = null;
            // cac dich vu thanh toan
            // loai = 1 : tiep don , loai = 2 : vien phi, loai = 3 : kham benh , loai = 4 : can lam sang
            //if (_KhamBenh_C_List.Count > 0 || _KhamBenh_ThuocSDList.Count > 0 || _KhamBenh_ThuocSD_DYList.Count > 0)
            //{
            //    if (((_loai == 1) || ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) && (_loaiKham != 2)) || (_loai == 7)))
            //    {


            //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, _loai, "");

            //        if (_KhamBenh_HoaDonList.Count > 0 || _ngayQT != null)
            //            _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, _loai, "");


            //    }
            //    else if ((_loai == 2))
            //    {


            //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 2, "");

            //        //if (_KhamBenh_HoaDonList.Count > 0 || _ngayQT != null)
            //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, 2, "");


            //    }
            //    else if ((_loai == 9))
            //    {


            //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0, 9, "");

            //        if (_KhamBenh_HoaDonList.Count > 0)
            //            _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1, 9, "");


            //    }
            //}
            if (dr != null)
            {
                dr.Close();
                dr = null;
            }
            // cac ket qua xet nghiem
            if (_KhamBenh_C_List.Count > 0)
            {
                if ((_loai == 4) && (_loaikq == (1) || (_loaikq == 2)))
                {


                    // _KhamBenh_C_KB_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    _KhamBenh_XN_GetsList = KhamBenh_XN_GetsList.GetAllGetsDichVu(_maSoKham, _loaikqcn, _ngayDK.Date, _loai, _loaikq.ToString() + " and a.makhoa like N'%" + _makhoa + "%'", Int32.Parse(dk));

                }
                //else
                //    if ((_loai == 3) && (dk.ToString() != ""))
                //    {


                //        // _KhamBenh_C_KB_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);

                //        _KhamBenh_XN_GetsList = KhamBenh_XN_GetsList.GetAllGetsDichVu(_maSoKham, _loaikqcn, _ngayDK.Date, _loai, "", Int32.Parse(dk));

                //    }
            }
            if ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) || _loai == 3 || _loai == 7)
            {
                ////////decimal _tbhtra = 0;
                ////////decimal _tbh = 0;
                //////////foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuCTTList )
                ////////// {

                //////////    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                //////////    {
                //////////        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong) ) * (100 - decimal.Parse(obj.CK)) / 100);
                //////////        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

                //////////    }
                //////////    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                //////////        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

                //////////}
                //////////foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuList)
                //////////{
                //////////    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                //////////    {
                //////////        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);
                //////////        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

                //////////    }
                //////////    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                //////////        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong )) * (100 - decimal.Parse(obj.CK)) / 100);

                //////////}

                ////////// TINH LAI THUOC
                ////////_KhamBenh_ThuocSDList._loai = _loai;
                ////////_KhamBenh_C_List._loai = _loai;
                ////////_KhamBenh_VTTHList._loai = _loai;
                ////////_KhamBenh_HoaChatList._loai = _loai;
                ////////_KhamBenh_MauList._loai = _loai;
                ////////foreach (KhamBenh_ThuocSD obj in _KhamBenh_ThuocSDList)
                ////////{

                ////////    if (_loai == 3)
                ////////    {
                ////////        if ((obj.DaTTTT != 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            {
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }

                ////////        }
                ////////        else if ((obj.DaTTTT == 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////    }
                ////////    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }

                ////////    }
                ////////    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;

                ////////        }

                ////////    }
                ////////    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////    }
                ////////    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }

                ////////    }
                ////////};

                ////////// TINH LAI DICH VU
                ////////foreach (KhamBenh_C obj in _KhamBenh_C_List)
                ////////{


                ////////     if (_loai == 3)
                ////////    {
                ////////        if ((obj.DaTTTT != 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            {
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }

                ////////        }
                ////////        else if ((obj.DaTTTT == 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////    }
                ////////    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }


                ////////    }
                ////////    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai ==2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }



                ////////    }
                ////////    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai ==9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////    }
                ////////    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }

                ////////    }
                ////////};
                //////////TINH LAI VTTH
                ////////foreach (KhamBenh_VTTH obj in _KhamBenh_VTTHList)
                ////////{


                ////////    if (_loai == 3)
                ////////    {
                ////////        if ((obj.DaTTTT != 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            {
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }

                ////////        }
                ////////        else if ((obj.DaTTTT == 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////    }
                ////////    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }

                ////////    }
                ////////    else   if ((obj.DaTTBH != 0) && (obj.Huy ==false)&& (_loai ==2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////    }

                ////////    }
                ////////    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////           _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////    }
                ////////    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }

                ////////    }
                ////////};
                //////////TINH LAI MAU
                ////////foreach (KhamBenh_Mau obj in _KhamBenh_MauList)
                ////////{


                ////////    if (_loai == 3)
                ////////    {
                ////////        if ((obj.DaTTTT != 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            {
                ////////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            }

                ////////        }
                ////////        else if ((obj.DaTTTT == 0) && (obj.Huy == false))
                ////////        {
                ////////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////            {
                ////////                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////            }
                ////////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }
                ////////    }
                ////////    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////        {
                ////////            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }

                ////////    }
                ////////    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai ==2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }

                ////////    }
                ////////    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai ==9))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) ||  (1==1)))
                ////////        {
                ////////             _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                ////////        }
                ////////        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                ////////            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////    }
                ////////    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
                ////////    {
                ////////        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                ////////        {
                ////////            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                ////////        }


                ////////    }
                ////////};
                //////////TINH TIEN HOA DON
                ////////_TongTienHoaDon = 0;
                ////////foreach (KhamBenh_HoaDon obj in _KhamBenh_HoaDonList)
                ////////{
                ////////    if (_loai == 2 && (obj.MaDT.Substring (0, 1) == "1"))
                ////////    {
                ////////        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                ////////            _tbhtra = _tbhtra + obj.TongTienBH;
                ////////        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                ////////            _tbh = _tbh + obj.TongTienBH;
                ////////        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
                ////////    }

                ////////    else if ((_loai == 9 || _loai == 8)&& (obj.MaDT.Substring (0, 1) == "0"))
                ////////    {
                ////////        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                ////////            _tbhtra = 0;
                ////////        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                ////////            _tbh = 0;
                ////////        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
                ////////    }
                ////////    else if (_loai !=2 && _loai !=9)
                ////////    {
                ////////        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                ////////            _tbhtra = _tbhtra + obj.TongTienBH;
                ////////        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                ////////            _tbh = _tbh + obj.TongTienBH;
                ////////        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
                ////////    }

                ////////};
                ////////_TongHD = _TongTienHoaDon;
                ////////if (_loai ==2)
                ////////_TongThuHoaDon = _TongTienHoaDon + _MienGiamBH ;
                ////////else
                ////////_TongThuHoaDon = _TongTienHoaDon +  _MienGiamTT;


                ////////_TongTienTT = _TongTienTTCTT + _TongTienTTDTT;
                ////////_TongTienBH = _TongTienBHDTT + _TongTienBHCTT;
                ////////if (_loai == 2)
                ////////{
                ////////    _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                ////////    if (_TongTienBH <= _sotienbhtra)
                ////////        _TongBHTra = _TongTienBH;
                ////////    else
                ////////        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                ////////    _TongBHKTra = _TongTienBH - _TongBHTra;
                ////////}
                ////////else if (_loai == 9)
                ////////{
                ////////    _TongBHKTra = 0;
                ////////    _TongTienBH = 0;
                ////////    _TongBHTra = 0;
                ////////    _tbh = 0;
                ////////}
                ////////else
                ////////{
                ////////    _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                ////////    if (_TongTienBH <= _sotienbhtra)
                ////////        _TongBHTra = _TongTienBH;
                ////////    else
                ////////        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                ////////    _TongBHKTra = _TongTienBH - _TongBHTra;

                ////////    if (_TongTienBHDTT <= _sotienbhtra)
                ////////        _TongBHTraDTT = _TongTienBHDTT;
                ////////    else
                ////////    {
                ////////        _TongBHTraDTT = ((_TongTienBHDTT) * _bhtra) / decimal.Parse("100");

                ////////    }
                ////////}
                ////////if (_maDT == "00001")
                ////////    {
                ////////    _TongBHKTra = 0;
                ////////    _TongTienBH=0;
                ////////    _TongBHTra=0;
                ////////    _tbh=0;
                ////////    }
                ////////else
                ////////    _TongBHKTra = _TongTienBH - _TongBHTra - _tbh;
                ////////if (_loai == 2)
                ////////{
                ////////    _TongThanhToan = _TongBHKTra - _tbhtra;
                ////////    _TongTienCTT = _TongTienBHCTT ;
                ////////    _TongThuHoaDon = _TongBHKTra -_MienGiam ;

                ////////}
                ////////else if (_loai == 9)
                ////////{
                ////////    _TongThanhToan = _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT;
                ////////    _TongTienCTT =  _TongTienTTCTT;
                ////////    _TongThuHoaDon = _TongTienTTCTT-_MienGiam ;
                ////////}
                ////////else if (_loai == 3)
                ////////{
                ////////    _TongThanhToan = _TongTienTT+_TongTienBH ;

                ////////}
                ////////else
                ////////{
                ////////    _TongThanhToan = _TongBHKTra + _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT - _tbhtra;

                ////////    _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;

                ////////}

                //////////_TongThanhToan = _TongThanhToan - _tbh;
                //////////if ((( _loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8)) || (_loai == 7))
                //////////     if (_TongTienHoaDon > _TongTienTTCTT + _TongTienTTDTT)
                //////////  {
                //////////         KhamBenh_HoaDon _KhamBenhhd = _KhamBenh_HoaDonList.ContainsCIn();
                //////////    if (_KhamBenhhd == null)
                //////////    {
                //////////        //_KhamBenhhd = _KhamBenh_HoaDonList.NewTo();
                //////////        //if (( _loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8))
                //////////        //    _KhamBenhhd.loai = 1;
                //////////        //else if (_loai == 7)
                //////////        //    _KhamBenhhd.loai = 2;
                //////////        //if (_KhamBenhhd.LydoChi  == "")
                //////////        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "Chi hóa đơn";
                //////////        //else if (_KhamBenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
                //////////        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Chi hóa đơn";
                //////////        //_KhamBenhhd.TongChi = _TongTienHoaDon - _TongTienTTCTT - _TongTienTTDTT;
                //////////       // _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                //////////       // _KhamBenh_HoaDonList.AssignTo(_KhamBenhhd);  
                //////////    }
                //////////    else
                //////////    {
                //////////        //if (_KhamBenhhd.LydoChi == "")
                //////////        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "Chi hóa đơn";
                //////////        //else if (_KhamBenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
                //////////        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Chi hóa đơn";
                //////////        //_KhamBenhhd.TongChi = _KhamBenhhd.TongThu;// 0 - (0 - _KhamBenhhd.TongChi + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon);
                //////////        ////_TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                //////////        //_KhamBenh_HoaDonList.UpdatedTo(_KhamBenhhd);  
                //////////    }


                //////////}
                //////////else if ((_TongTienHoaDon < _TongTienTTCTT + _TongTienTTDTTKTra) && (_TongTienTTDTTKTra != _TongTienTTDTT ) && _TongThanhToan ==0 )
                //////////{
                //////////    KhamBenh_HoaDon _KhamBenhhd = _KhamBenh_HoaDonList.ContainsCIn();
                //////////    if (_KhamBenhhd == null)
                //////////    {
                //////////        _KhamBenhhd = _KhamBenh_HoaDonList.NewTo();
                //////////        if (( _loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8))
                //////////            _KhamBenhhd.loai = 1;
                //////////        else if (_loai == 7)
                //////////            _KhamBenhhd.loai = 2;
                //////////        if (_TongThanhToan > 0)
                //////////        {

                //////////            _KhamBenhhd.TongChi  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
                //////////        }
                //////////        else
                //////////        {
                //////////            if (_KhamBenhhd.LydoThu == "")
                //////////                _KhamBenhhd.LydoThu = _KhamBenhhd.LydoThu + "Đổi hóa đơn";
                //////////            else if (_KhamBenhhd.LydoThu.CompareTo("Đổi hóa đơn") <= 0)
                //////////                _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Đổi hóa đơn";
                //////////            _KhamBenhhd.TongThu  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;

                //////////            _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                //////////            _KhamBenh_HoaDonList.AssignTo(_KhamBenhhd);  
                //////////        }

                //////////    }
                //////////    else
                //////////    {
                //////////        if (_KhamBenhhd.LydoChi == "")
                //////////            _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "Đổi hóa đơn";
                //////////        else if (_KhamBenhhd.LydoChi.CompareTo("Đổi hóa đơn") <= 0)
                //////////            _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Đổi hóa đơn";
                //////////        _KhamBenhhd.TongThu = _KhamBenhhd.TongThu + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
                //////////        _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                //////////        _KhamBenh_HoaDonList.UpdatedTo(_KhamBenhhd);  
                //////////    }
                //////////    }
                TinhLaiTienKhamBenh();
            };
            if (dr != null)
            {
                dr.Close();
                dr = null;
            }
        }

        /// <summary>
        /// Insert the new <see cref="KhamBenh" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _maDT = "00001";
            _ngayDK.Date = DateTime.Now;
            ValidationRules.CheckRules();
            //_KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList;   
        }

        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            //_nguoiLap = _nguoiLap != "" ? _nguoiLap : HTC.ShareVariables.pub_sNguoiSD;
            //using (TransactionScope oTranScope = new TransactionScope())
            //{

            _maSoKham = DataProvider.Instance().InsertKhamBenh(_maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck,_nguoiSD, _maMay, _TongTien, _TongBHTra, _TongTienBH, _ngayDK, _giaTriTN, _maBVGT, _ngayGT, _TongDV, _TongThuocTY, _TongThuocDY, _KyQuyBH );
            MarkOld();   //if (this.sosohd != "")
            //    _KhamBenh_HoaDonList.Update(this);
            if ((_loai == 1 ||_loai ==11))
            {
                _KhamBenh_C_List.Update(this);
            }
            else if (!((_loai == 9 || _loai == 8)|| _loai == 2 || _loai == 7||_loai ==4))
            {
                _KhamBenh_C_List.Update(this);
                _KhamBenh_ThuocSDList.Update(this);
                if ( loai !=4)
                _KhamBenh_ThuocSD_DYList.Update(this);
                _KhamBenh_VTTHList.Update(this);
                _KhamBenh_HoaChatList.Update(this);
                _KhamBenh_MauList.Update(this);
                if (_loai ==3 )
                    if (_KhamBenh_TTNgoai_List.Count >0)
                        _KhamBenh_TTNgoai_List.Update(this);
            }
            // public abstract String InsertKhamBenh(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH );
            // public override String InsertKhamBenh(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH )
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Create", _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck,_nguoiSD ,_maMay ,  _tongTien , _tongBHTra , _tongTienBH );
            // }
            //    oTranScope.Complete();
            //}
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh
            if (IsDirty)
            {
                
                
                //using (TransactionScope oTranScope = new TransactionScope(TransactionScopeOption.RequiresNew ,HTC.ShareVariables.ts    ))
                //{
                if (_loai == 2)
                    _MienGiamBH = _MienGiamBH + _MienGiam;
                else if (_loai == 9)
                    _MienGiamTT = _MienGiamTT + _MienGiam;
                if (base.IsDirty && (_loai != 4))
                    _sophieuttrv = DataProvider.Instance().UpdateKhamBenh(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _nguoiSD, _maMay, _huy, _TongTien, _TongBHTra, _TongTienBH, _ngayDK, _giaTriTN, _maBVGT, _DuyetBH, _KyQuyBH, _MienGiamBH, _MienGiamTT, _ngayGT, _TongDV, _TongThuocTY, _TongThuocDY);
                //CO HOA DON 
                if ((_loai == 1 || _loai == 11))
                {
                    _KhamBenh_C_List.Update(this);
                }
                else if ((_loai == 2) || (_loai == 9)||_loai ==4)
                {

                    // _KhamBenh_HoaDonList.Update(this);
                    _KhamBenh_C_List.Update(this);
                    if (_KhamBenh_ThuocSDList.Count > 0 && _TongThuocTY > 0)
                        _KhamBenh_ThuocSDList.Update(this);
                    if (_KhamBenh_ThuocSD_DYList.Count > 0 && _TongThuocDY > 0 && loai !=4)
                        _KhamBenh_ThuocSD_DYList.Update(this);
                    _KhamBenh_VTTHList.Update(this);
                    _KhamBenh_HoaChatList.Update(this);
                    _KhamBenh_MauList.Update(this);

                }
                else if ((_loai == 3))
                {
                    _KhamBenh_C_List.Update(this);
                    //_KhamBenh_C_KB_List.Update(this);
                   // if (_KhamBenh_ThuocSDList.Count > 0)
                        _KhamBenh_ThuocSDList.Update(this);
                   // if (_KhamBenh_ThuocSD_DYList.Count > 0)
                        _KhamBenh_ThuocSD_DYList.Update(this);
                   // if (_KhamBenh_VTTHList.Count > 0)
                        _KhamBenh_VTTHList.Update(this);
                   // if (_KhamBenh_HoaChatList.Count > 0)
                        _KhamBenh_HoaChatList.Update(this);
                    //if (_KhamBenh_MauList.Count > 0)
                        _KhamBenh_MauList.Update(this);
                    if (_loai == 3)
                            _KhamBenh_TTNgoai_List.Update(this);
                }

                else if ((_loai == 7))
                {
                    //  _KhamBenh_HoaDonList.Update(this);
                    _KhamBenh_ThuocSDList.Update(this);
                    if (_KhamBenh_ThuocSD_DYList.Count > 0)
                        _KhamBenh_ThuocSD_DYList.Update(this);
                    if (_KhamBenh_C_List.Count > 0)
                        _KhamBenh_C_List.Update(this);
                }
                else
                {
                    _KhamBenh_C_List.Update(this);
                    // if (_KhamBenh_ThuocSDList.Count >0 )
                    //    _KhamBenh_ThuocSDList.Update(this);
                    // if (_KhamBenh_ThuocSD_DYList.Count >0 )
                    //    _KhamBenh_ThuocSD_DYList.Update(this);
                    //if (_KhamBenh_VTTHList.Count > 0)
                    //    _KhamBenh_VTTHList.Update(this);
                    //if (_KhamBenh_HoaChatList.Count > 0) 
                    //    _KhamBenh_HoaChatList.Update(this);
                    //if (_KhamBenh_MauList.Count > 0) 
                    //    _KhamBenh_MauList.Update(this);
                }

                //   oTranScope.Complete();
                //}
                // public abstract void UpdateKhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy,Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH  );
                // public override void UpdateKhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy,Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH  )
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Update", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck,_nguoiSD ,_maMay ,   _huy,_tongTien , _tongBHTra , _tongTienBH );
                // }				
            }
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maSoKham, _loai,_da));
        //}

        /// <summary>
        /// Delete the <see cref="KhamBenh" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh
            DataProvider.Instance().DeleteKhamBenh(crit.MaMay, crit.NguoiSD, crit.MaSoKham);
            // public abstract void DeleteKhamBenh(String _maSoKham);
            // public override void DeleteKhamBenh(String _maSoKham);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Deleted", _maSoKham);
            // }

        }
        //protected void DataPortal_Execute(CommandBase crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh

        //    DataProvider.Instance().KhamBenh_TINHLAIDT(crit.MaSoKham, crit.MaDT, crit.loai, crit.dk);


        //}
        //public void TinhLaiTienKhamBenh()
        //{
        //    _TongTien = 0;
        //    _TongBHTra = 0;
        //    _TongTienBH = 0;
        //    _TongTienTT = 0;
        //    _TongTienBHCTT = 0;
        //    _TongTienTTCTT = 0;
        //    _TongBHTraCTT = 0;
        //    _TongTienBHDTT = 0;
        //    _TongTienTTDTT = 0;
        //    _TongBHTraDTT = 0;
        //    _TongTienTTCTT = 0;
        //    _TongTienTTDTTKTra = 0;
        //    if (_loai == 3)
        //    {
        //        _TongDV = 0;
        //        if (_loai == 3 || (_loai == 7 && _noitt != "090"))
        //            _TongThuocTY = 0;
        //        if ((_loai == 3) || (_loai == 7 && _noitt == "090"))
        //            _TongThuocDY = 0;
        //    }
        //    decimal _tbhtra = 0;
        //    decimal _tttt = 0;
        //    decimal _tbh = 0;
        //    //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuCTTList )
        //    // {

        //    //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //    //    {
        //    //        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong) ) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //    }
        //    //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //}
        //    //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuList)
        //    //{
        //    //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //    //    {
        //    //        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //    }
        //    //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong )) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //}

        //    // TINH LAI THUOC
        //    // TINH LAI THUOC
        //    //_KhamBenh_ThuocSDList._loai = _loai;
        //    //_KhamBenh_ThuocSD_DYList._loai = _loai;
        //    //_KhamBenh_C_List._loai = _loai;
        //    //_KhamBenh_VTTHList._loai = _loai;
        //    //_KhamBenh_HoaChatList._loai = _loai;
        //    //_KhamBenh_MauList._loai = _loai;
        //    //    foreach (KhamBenh_ThuocSD obj in _KhamBenh_ThuocSDList)
        //    //    {


        //    //        if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }

        //    //        }
        //    //        else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;

        //    //            }

        //    //        }
        //    //        else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //        }
        //    //        else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }

        //    //        }
        //    //    };

        //    //    // TINH LAI DICH VU
        //    //    foreach (KhamBenh_C obj in _KhamBenh_C_List)
        //    //    {


        //    //        if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }


        //    //        }
        //    //        else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }



        //    //        }
        //    //        else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //        }
        //    //        else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }

        //    //        }
        //    //    };
        //    //    //TINH LAI VTTH
        //    //    foreach (KhamBenh_VTTH obj in _KhamBenh_VTTHList)
        //    //    {


        //    //        if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }

        //    //        }
        //    //        else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }

        //    //        }
        //    //        else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //        }
        //    //        else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }

        //    //        }
        //    //    };
        //    //    //TINH LAI MAU
        //    //    foreach (KhamBenh_Mau obj in _KhamBenh_MauList)
        //    //    {


        //    //        if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //            {
        //    //                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }

        //    //        }
        //    //        else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }

        //    //        }
        //    //        else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai ==9))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                 _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //    //            }
        //    //            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //    //                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //        }
        //    //        else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai ==2))
        //    //        {
        //    //            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //    //            {
        //    //                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //    //            }


        //    //        }
        //    //    };
        //    //    //TINH TIEN HOA DON
        //    //    _TongTienHoaDon = 0;
        //    //    _TongThuHoaDon=0;
        //    //    foreach (KhamBenh_HoaDon obj in _KhamBenh_HoaDonList)
        //    //    {
        //    //        if (_loai == 2 && (obj.MaDT.Substring(0, 1) == "1"))
        //    //        {
        //    //            if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //    //                _tbhtra = _tbhtra + obj.TongTienBH;
        //    //            if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //    //                _tbh = _tbh + obj.TongTienBH;
        //    //            _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
        //    //        }

        //    //        else if ((_loai == 9 || _loai == 8)&& (obj.MaDT.Substring(0, 1) == "0"))
        //    //        {
        //    //            if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //    //                _tbhtra = 0;
        //    //            if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //    //                _tbh = 0;
        //    //            if ((obj.TongThu == obj.TongChi) && (obj.TongChi != 0))
        //    //                _TongThuHoaDon = _TongThuHoaDon + obj.TongThu;
        //    //            _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
        //    //        }
        //    //        else if (_loai !=9 && _loai !=2)
        //    //        {
        //    //            if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //    //                _tbhtra = _tbhtra + obj.TongTienBH;
        //    //            if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //    //                _tbh = _tbh + obj.TongTienBH;
        //    //            _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
        //    //        }

        //    //    };
        //    //    if (_loai == 2)
        //    //    {
        //    //        _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
        //    //        if (_TongTienBH <= _sotienbhtra)
        //    //            _TongBHTra = _TongTienBH;
        //    //        else
        //    //            _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

        //    //        _TongBHKTra = _TongTienBH - _TongBHTra;
        //    //    }
        //    //    else if (_loai == 9)
        //    //    {
        //    //        _TongBHKTra = 0;
        //    //        _TongTienBH = 0;
        //    //        _TongBHTra = 0;
        //    //        _tbh = 0;
        //    //    }
        //    //    else
        //    //    {
        //    //        _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
        //    //        if (_TongTienBH <= _sotienbhtra)
        //    //            _TongBHTra = _TongTienBH;
        //    //        else
        //    //            _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

        //    //        _TongBHKTra = _TongTienBH - _TongBHTra;

        //    //        if (_TongTienBHDTT <= _sotienbhtra)
        //    //            _TongBHTraDTT = _TongTienBHDTT;
        //    //        else
        //    //        {
        //    //            _TongBHTraDTT = ((_TongTienBHDTT) * _bhtra) / decimal.Parse("100");

        //    //        }
        //    //    }
        //    //    if (_maDT == "00001")
        //    //    {
        //    //        _TongBHKTra = 0;
        //    //        _TongTienBH = 0;
        //    //        _TongBHTra = 0;
        //    //        _tbh = 0;
        //    //    }
        //    //    else
        //    //    _TongBHKTra = _TongTienBH - _TongBHTra -_tbh ;
        //    //if (_loai == 2)
        //    //{
        //    //    _TongThanhToan = _TongBHKTra - _tbhtra;
        //    //    _TongTienCTT = _TongTienBHCTT;
        //    //    _TongThuHoaDon = _TongBHKTra;

        //    //}
        //    //else if (_loai == 9)
        //    //{
        //    //    _TongThanhToan = _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT;
        //    //    _TongTienCTT = _TongTienTTCTT;
        //    //    _TongThuHoaDon =  _TongThuHoaDon + _TongThanhToan;
        //    //}
        //    //else
        //    //{
        //    //    _TongThanhToan = _TongBHKTra + _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT - _tbhtra;

        //    //    _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;

        //    //}


        //    //_TongThanhToan = _TongThanhToan - _tbh;
        //    //if ((( _loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8)) || (_loai == 7))
        //    //     if (_TongTienHoaDon > _TongTienTTCTT + _TongTienTTDTT)
        //    //  {
        //    //         KhamBenh_HoaDon _KhamBenhhd = _KhamBenh_HoaDonList.ContainsCIn();
        //    //    if (_KhamBenhhd == null)
        //    //    {
        //    //        //_KhamBenhhd = _KhamBenh_HoaDonList.NewTo();
        //    //        //if (( _loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8))
        //    //        //    _KhamBenhhd.loai = 1;
        //    //        //else if (_loai == 7)
        //    //        //    _KhamBenhhd.loai = 2;
        //    //        //if (_KhamBenhhd.LydoChi  == "")
        //    //        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "Chi hóa đơn";
        //    //        //else if (_KhamBenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
        //    //        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Chi hóa đơn";
        //    //        //_KhamBenhhd.TongChi = _TongTienHoaDon - _TongTienTTCTT - _TongTienTTDTT;
        //    //       // _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
        //    //       // _KhamBenh_HoaDonList.AssignTo(_KhamBenhhd);  
        //    //    }
        //    //    else
        //    //    {
        //    //        //if (_KhamBenhhd.LydoChi == "")
        //    //        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "Chi hóa đơn";
        //    //        //else if (_KhamBenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
        //    //        //    _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Chi hóa đơn";
        //    //        //_KhamBenhhd.TongChi = _KhamBenhhd.TongThu;// 0 - (0 - _KhamBenhhd.TongChi + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon);
        //    //        ////_TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
        //    //        //_KhamBenh_HoaDonList.UpdatedTo(_KhamBenhhd);  
        //    //    }


        //    //}
        //    //else if ((_TongTienHoaDon < _TongTienTTCTT + _TongTienTTDTTKTra) && (_TongTienTTDTTKTra != _TongTienTTDTT ) && _TongThanhToan ==0 )
        //    //{
        //    //    KhamBenh_HoaDon _KhamBenhhd = _KhamBenh_HoaDonList.ContainsCIn();
        //    //    if (_KhamBenhhd == null)
        //    //    {
        //    //        _KhamBenhhd = _KhamBenh_HoaDonList.NewTo();
        //    //        if (( _loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8))
        //    //            _KhamBenhhd.loai = 1;
        //    //        else if (_loai == 7)
        //    //            _KhamBenhhd.loai = 2;
        //    //        if (_TongThanhToan > 0)
        //    //        {

        //    //            _KhamBenhhd.TongChi  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
        //    //        }
        //    //        else
        //    //        {
        //    //            if (_KhamBenhhd.LydoThu == "")
        //    //                _KhamBenhhd.LydoThu = _KhamBenhhd.LydoThu + "Đổi hóa đơn";
        //    //            else if (_KhamBenhhd.LydoThu.CompareTo("Đổi hóa đơn") <= 0)
        //    //                _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Đổi hóa đơn";
        //    //            _KhamBenhhd.TongThu  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;

        //    //            _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
        //    //            _KhamBenh_HoaDonList.AssignTo(_KhamBenhhd);  
        //    //        }

        //    //    }
        //    //    else
        //    //    {
        //    //        if (_KhamBenhhd.LydoChi == "")
        //    //            _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "Đổi hóa đơn";
        //    //        else if (_KhamBenhhd.LydoChi.CompareTo("Đổi hóa đơn") <= 0)
        //    //            _KhamBenhhd.LydoChi = _KhamBenhhd.LydoChi + "- Đổi hóa đơn";
        //    //        _KhamBenhhd.TongThu = _KhamBenhhd.TongThu + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
        //    //        _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
        //    //        _KhamBenh_HoaDonList.UpdatedTo(_KhamBenhhd);  
        //    //    }
        //    //    }

        //    if ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) || _loai == 3 || _loai == 7||_loai ==11)
        //    {

        //        //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuCTTList )
        //        // {

        //        //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //        //    {
        //        //        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong) ) * (100 - decimal.Parse(obj.CK)) / 100);
        //        //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

        //        //    }
        //        //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //        //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

        //        //}
        //        //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuList)
        //        //{
        //        //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //        //    {
        //        //        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);
        //        //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

        //        //    }
        //        //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //        //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong )) * (100 - decimal.Parse(obj.CK)) / 100);

        //        //}

        //        // TINH LAI THUOC
        //        _KhamBenh_ThuocSD_DYList._loai = _loai;
        //        _KhamBenh_ThuocSDList._loai = _loai;
        //        _KhamBenh_C_List._loai = _loai;
        //        _KhamBenh_VTTHList._loai = _loai;
        //        _KhamBenh_HoaChatList._loai = _loai;
        //        _KhamBenh_MauList._loai = _loai;
        //        foreach (KhamBenh_ThuocSD obj in _KhamBenh_ThuocSDList)
        //        {

        //            if (_loai == 3)


        //            {
        //                if ((obj.DaTTBH != 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //                    {
        //                        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    {
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                    }

        //                }
        //                else if ((obj.DaTTBH == 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //                    {
        //                        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    {
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                }
        //            }
        //            else if ((obj.DaTTTT != 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }

        //            }
        //            else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2||_loai ==11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
        //                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }

        //            }
        //            else if ((obj.DaTTTT == 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                {
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //            }
        //            else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }

        //            }
        //        };
        //        _TongSac = 0;
        //        // tinh thuoc dong y
        //        foreach (KhamBenh_ThuocSD_DY objM in _KhamBenh_ThuocSD_DYList)
        //        {
        //            if ((_loai == 3 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 7) && (objM.Huy == false))
        //            {
        //                if (objM.DaTTTT != 0)
        //                    if (objM.Sac == true)
        //                    {
        //                        _TongTienTTDTT = _TongTienTTDTT + objM.GiaSac * Decimal.Parse(objM.SLMua);
        //                        _TongSac = _TongSac + objM.GiaSac * Decimal.Parse(objM.SLMua);
        //                    }
        //                if (objM.DaTTTT == 0)
        //                    if (objM.Sac == true)
        //                    {
        //                        _TongTienTTCTT = _TongTienTTCTT + objM.GiaSac * Decimal.Parse(objM.SLMua);
        //                        _TongSac = _TongSac + objM.GiaSac * Decimal.Parse(objM.SLMua);
        //                    }
        //            }

        //            if (objM.Huy == false)
        //                foreach (KhamBenh_ThuocSD_DY_C obj in objM.KhamBenh_ThuocSD_DY_Cs)
        //                {

        //                    if (_loai == 3)
        //                    {

        //                        if ((objM.DaTTBH != 0) && (obj.Huy == false))
        //                        {
        //                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //                            {
        //                                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;
        //                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
        //                                _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;
        //                            }
        //                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                            {
        //                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
        //                                _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

        //                            }

        //                        }
        //                        else if ((objM.DaTTBH == 0) && (obj.Huy == false) && (obj.Huy == false))
        //                        {
        //                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
        //                            {
        //                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                                _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            }
        //                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                            {
        //                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                                _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            }
        //                        }
        //                    }
        //                    else if ((objM.DaTTTT != 0) && (objM.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
        //                    {
        //                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
        //                        {
        //                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
        //                            _TongThuocDY = _TongThuocDY + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                        }
        //                        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                        {
        //                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
        //                            _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                        }

        //                    }
        //                    else if ((objM.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //                    {
        //                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
        //                        {
        //                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;

        //                            _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

        //                        }

        //                    }
        //                    else if ((objM.DaTTTT == 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
        //                    {
        //                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
        //                        {
        //                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            _TongThuocDY = _TongThuocDY + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

        //                        }
        //                        else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                        {
        //                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

        //                        }
        //                    }
        //                    else if ((objM.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //                    {
        //                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
        //                        {
        //                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
        //                            _TongThuocDY = _TongThuocDY + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

        //                        }
        //                    }
        //                }
        //        };
        //        // TINH LAI DICH VU
        //        foreach (KhamBenh_C obj in _KhamBenh_C_List)
        //        {


        //            if (_loai == 3)
        //            {
        //                if ((obj.DaTTBH != 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                    {
        //                        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    {
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                    }

        //                }
        //                else if ((obj.DaTTBH == 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                    {
        //                        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    {
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                }
        //            }
        //            else if ((obj.DaTTTT != 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongDV = _TongDV + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }


        //            }
        //            else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }



        //            }
        //            else if ((obj.DaTTTT == 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongDV = _TongDV + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                {
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //            }
        //            else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }

        //            }
        //        };
        //        //TINH LAI VTTH
        //        foreach (KhamBenh_VTTH obj in _KhamBenh_VTTHList)
        //        {


        //            if (_loai == 3)
        //            {
        //                if ((obj.DaTTBH != 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                    {
        //                        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    {
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }

        //                }
        //                else if ((obj.DaTTBH == 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                    {
        //                        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }
        //            }
        //            else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }

        //            }
        //            else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }

        //            }
        //            else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //            }
        //            else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }

        //            }
        //        };
        //        //TINH LAI MAU
        //        foreach (KhamBenh_Mau obj in _KhamBenh_MauList)
        //        {


        //            if (_loai == 3)
        //            {
        //                if ((obj.DaTTBH != 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                    {
        //                        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    {
        //                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    }

        //                }
        //                else if ((obj.DaTTBH == 0) && (obj.Huy == false))
        //                {
        //                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                    {
        //                        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                    }
        //                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }
        //            }
        //            else if ((obj.DaTTTT != 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                {
        //                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }

        //            }
        //            else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }

        //            }
        //            else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
        //                }
        //                else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
        //                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //            }
        //            else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
        //            {
        //                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
        //                {
        //                    _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

        //                }


        //            }
        //        };
        //        //TINH TIEN HOA DON
        //        _TongTienHoaDon = 0;
        //        _TongHD = 0;
        //        foreach (KhamBenh_HoaDon obj in _KhamBenh_HoaDonList)
        //        {
        //            if ((_loai == 2||_loai ==11) && (obj.MaDT.Substring(0, 1) == "1"))
        //            {
        //                if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                {
        //                    _tbhtra = _tbhtra + obj.TongTienBH;
        //                    _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
        //                }
        //                if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                    _tbh = _tbh + obj.TongTienBH;
        //                _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
        //            }

        //            else if ((_loai == 9 || _loai == 8)&& (obj.MaDT.Substring(0, 1) == "0"))
        //            {
        //                if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                {
        //                    _tbhtra = 0;
        //                    _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
        //                }
        //                if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                    _tbh = 0;
        //                _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

        //            }
        //            else if (_loai == 7 && (obj.MaDT.Substring(0, 1) == "0"))
        //            {
        //                if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                {
        //                    _tbhtra = 0;
        //                    _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
        //                }
        //                if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                    _tbh = 0;
        //                _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

        //            }
        //            else if (_loai != 2 && _loai != 9&& _loai !=11)
        //            {
        //                if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                {
        //                    _tbhtra = _tbhtra + obj.TongTienBH;
        //                    _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
        //                }
        //                if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
        //                    _tbh = _tbh + obj.TongTienBH;
        //                _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

        //            }

        //        };
        //        //_TongHD = _TongTienHoaDon;
        //        if (_loai == 2||_loai ==11)
        //            _TongThuHoaDon = _TongTienHoaDon + _MienGiamBH;
        //        else
        //            _TongThuHoaDon = _TongTienHoaDon + _MienGiamTT;

        //        _TongTienTT = _TongTienTTCTT + _TongTienTTDTT;
        //        _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
        //        if (_loai == 2 || _loai == 11)
        //        {
        //            _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
        //            if (_TongTienBH <= _sotienbhtra)
        //                _TongBHTra = _TongTienBH;
        //            else
        //                _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

        //            _TongBHKTra = _TongTienBH - _TongBHTra;
        //        }
        //        else if ((_loai == 9 || _loai == 8)|| _loai == 7)
        //        {
        //            _TongBHKTra = 0;
        //            _TongTienBH = 0;
        //            _TongBHTra = 0;
        //            _tbh = 0;
        //        }
        //        else
        //        {
        //            _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
        //            if (_TongTienBH <= _sotienbhtra)
        //                _TongBHTra = _TongTienBH;
        //            else
        //                _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

        //            _TongBHKTra = _TongTienBH - _TongBHTra;

        //            if (_TongTienBHDTT <= _sotienbhtra)
        //                _TongBHTraDTT = _TongTienBHDTT;
        //            else
        //            {
        //                _TongBHTraDTT = ((_TongTienBHDTT) * _bhtra) / decimal.Parse("100");

        //            }
        //        }
        //        if (_maDT.Substring(0, 1) == "0" || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 7)
        //        {
        //            _TongBHKTra = 0;
        //            _TongTienBH = 0;
        //            _TongBHTra = 0;
        //            _tbh = 0;
        //        }
        //        else
        //            _TongBHKTra = _TongTienBH - _TongBHTra - _tbh;
        //        if (_loai == 2 || _loai == 11)
        //        {
        //            _TongThanhToan = _TongBHKTra - _tbhtra;
        //            _TongTienCTT = _TongTienBHCTT;
        //            _TongThuHoaDon = _TongBHKTra - _MienGiam;

        //        }
        //        else if ((_loai == 9 || _loai == 8)|| _loai == 7)
        //        {
        //            _TongThanhToan = _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT;
        //            _TongTienCTT = _TongTienTTCTT;
        //            if (_TongThanhToan < 0)
        //                _MienGiamBH = 0;
        //            if (_TongThanhToan < 0)
        //                _TongThuHoaDon = _TongThanhToan + _TongHD - _MienGiam;
        //            else
        //                _TongThuHoaDon = _TongThanhToan - _MienGiam;
        //        }
        //        else if (_loai == 3)
        //        {
        //            _TongThanhToan = _TongTienTT + _TongTienBH;

        //        }
        //        else
        //        {
        //            _TongThanhToan = _TongBHKTra + _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT - _tbhtra;

        //            _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;

        //        }
        //        _TongHD = _TongTienHoaDon;
        //    }


        //}
        public void TinhLaiTienKhamBenh()
        {
            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;
            _TongTienTTDTTKTra = 0;
            if (_loai == 3)
            {
                _TongDV = 0;
            }
            if (_loai == 3 || (_loai == 7 && _noitt != "090"))
                _TongThuocTY = 0;
            if ((_loai == 3) || (_loai == 7 && _noitt == "090") || (_loai == 7 && HTC.ShareVariables.pub_spC == "QN"))
                _TongThuocDY = 0;
            decimal _tbhtra = 0;
            decimal _tttt = 0;
            decimal _tbh = 0;


            if ((_loai == 2 || (_loai == 9 || _loai == 8)|| _loai == 8) || _loai == 3 || _loai == 7 || _loai == 11)
            {



                // TINH LAI THUOC
                _KhamBenh_ThuocSD_DYList._loai = _loai;
                _KhamBenh_ThuocSDList._loai = _loai;
                _KhamBenh_C_List._loai = _loai;
                _KhamBenh_VTTHList._loai = _loai;
                _KhamBenh_HoaChatList._loai = _loai;
                _KhamBenh_MauList._loai = _loai;
                foreach (KhamBenh_ThuocSD obj in _KhamBenh_ThuocSDList)
                {

                    if (_loai == 3 || ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))//  if (_loai == 3)// if (_loai == 3 ||(HTC.ShareVariables .pub_spC =="HU"&&_loai ==2))
                    {
                        if ((obj.DATT != 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                            {
                                if (decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra) > 0)
                                {
                                    _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                }
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                if (decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra) > 0)
                                {
                                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                    _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                }
                            }

                        }
                        else if ((obj.DATT == 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                            {
                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                        }
                    }
                    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        else if ((obj.MaDT =="30001" ||obj.MaDT =="20002")&& _loai ==9)
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                           _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                    }
                    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        else if ((obj.MaDT =="30001" ||obj.MaDT =="20002")&& (_loai ==9))
                        {
                             _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                    }
                    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }

                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongThuocTY = _TongThuocTY + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }


                    }
                };
                _TongSac = 0;
                // tinh thuoc dong y
                foreach (KhamBenh_ThuocSD_DY objM in _KhamBenh_ThuocSD_DYList)
                {
                    //if ((_loai == 3 || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 7) && (objM.Huy == false))
                    //{
                    //    if (objM.DaTTTT != 0)
                    //        if (objM.Sac == true)
                    //        {
                    //            _TongTienTTDTT = _TongTienTTDTT + objM.GiaSac * Decimal.Parse(objM.SLMua);
                    //            _TongSac = _TongSac + objM.GiaSac * Decimal.Parse(objM.SLMua);
                    //        }
                    //    if (objM.DaTTTT == 0)
                    //        if (objM.Sac == true)
                    //        {
                    //            _TongTienTTCTT = _TongTienTTCTT + objM.GiaSac * Decimal.Parse(objM.SLMua);
                    //            _TongSac = _TongSac + objM.GiaSac * Decimal.Parse(objM.SLMua);
                    //        }
                    //}

                    if (objM.Huy == false)
                        foreach (KhamBenh_ThuocSD_DY_C obj in objM.KhamBenh_ThuocSD_DY_Cs)
                        {

                            if (_loai == 3 || ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))// if (_loai == 3 ||(HTC.ShareVariables .pub_spC =="HU"&&_loai ==2))
                            {

                                if ((objM.DATT != 0) && (obj.Huy == false))
                                {
                                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                                    {
                                        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;
                                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
                                        _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;
                                    }
                                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                    {
                                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
                                        _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

                                    }

                                }
                                else if ((objM.DATT == 0) && (obj.Huy == false) && (obj.Huy == false))
                                {
                                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                                    {
                                        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                        _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    }
                                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                    {
                                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                        _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    }
                                }
                            }
                            else if ((objM.DaTTTT != 0) && (objM.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
                            {
                                if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                {
                                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
                                    _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                }

                            }
                            else if ((objM.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                            {
                                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                                {
                                    _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;

                                    _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

                                }
                                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                                {
                                    _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMuaCu) * (100 - objM.CK) / 100);
                                    _TongThuocDY = _TongThuocDY + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                }

                            }
                            else if ((objM.DaTTTT == 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
                            {
                                if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                {
                                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    _TongThuocDY = _TongThuocDY + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

                                }
                               
                            }
                            else if ((objM.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                            {
                                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                                {
                                    _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    _TongThuocDY = _TongThuocDY + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

                                }
                                if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                                {
                                    _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                    _TongThuocDY = _TongThuocDY + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

                                }

                            }
                        }
                };
                // TINH LAI DICH VU
                foreach (KhamBenh_C obj in _KhamBenh_C_List)
                {

                    if (_loai == 3 || ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))// if (_loai == 3 ||(HTC.ShareVariables .pub_spC =="HU"&&_loai ==2))
                    {
                        if ((obj.DaTT != 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                            }

                        }
                        else if ((obj.DaTT == 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                        }
                    }
                    else if ((obj.DaTTTT != 0 && obj.DaTTTT <90 ) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        else if ((obj.MaDT == "30001" || obj.MaDT == "20002") && (_loai == 9))
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }

                    }
                    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }



                    }
                    else if ((obj.DaTTTT == 0 || obj.DaTTTT >=90) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 7))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        else if ((obj.MaDT == "30001" || obj.MaDT == "20002") && (_loai == 9))
                        {
                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                    }
                    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100 + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongDV = _TongDV + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.slmua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }

                    }
                };
                //TINH LAI VTTH
                foreach (KhamBenh_VTTH obj in _KhamBenh_VTTHList)
                {


                    if (_loai == 3 || ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))// if (_loai == 3 ||(HTC.ShareVariables .pub_spC =="HU"&&_loai ==2))
                    {
                        if ((obj.DATT != 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }

                        }
                        else if ((obj.DATT == 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                    }
                    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                    }
                    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }

                    }
                };
                //TINH LAI hoa chat
                foreach (KhamBenh_HoaChat obj in _KhamBenh_HoaChatList)
                {


                    if (_loai == 3 || ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))// if (_loai == 3 ||(HTC.ShareVariables .pub_spC =="HU"&&_loai ==2))
                    {
                        if ((obj.DATT != 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }

                        }
                        else if ((obj.DATT == 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                    }
                    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && (_loai == 9))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                    }
                    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }

                    }
                };
                //TINH LAI MAU
                foreach (KhamBenh_Mau obj in _KhamBenh_MauList)
                {


                    if (_loai == 3 || ((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))// if (_loai == 3 ||(HTC.ShareVariables .pub_spC =="HU"&&_loai ==2))
                
                    {
                        if ((obj.DATT != 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                            }

                        }
                        else if ((obj.DATT == 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                    }
                    else if ((obj.DaTTTT != 0) && (obj.Huy == false) && ((_loai == 9 || _loai == 8)|| _loai == 11))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTBH != 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                            _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                    else if ((obj.DaTTTT == 0) && (obj.Huy == false) && (_loai == 9))
                    {
                        if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                    }
                    else if ((obj.DaTTBH == 0) && (obj.Huy == false) && (_loai == 2 || _loai == 11))
                    {
                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                        }

                        if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((obj.MaDT == _maDT) || (1 == 1)))
                        {
                            _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        }

                    }
                };
                //TINH TIEN HOA DON
                _TongTienHoaDon = 0;
                _TongHD = 0;
                foreach (KhamBenh_HoaDon obj in _KhamBenh_HoaDonList)
                {
                    if (((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))
                    {
                        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                        {
                            _tbhtra = _tbhtra + obj.TongTienBH;
                            _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
                        }
                        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                            _tbh = _tbh + obj.TongTienBH;
                        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
                    }
                    else if ((_loai == 2 || _loai == 11) && (obj.MaDT.Substring(0, 1) == "1"))
                    {
                        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                        {
                            _tbhtra = _tbhtra + obj.TongTienBH;
                            _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
                        }
                        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                            _tbh = _tbh + obj.TongTienBH;
                        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;
                    }

                    else if ((_loai == 9 || _loai == 8)&& (obj.MaDT.Substring(0, 1) == "0"))
                    {
                        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                        {
                            _tbhtra = 0;
                            _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
                        }
                        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                            _tbh = 0;
                        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

                    }
                    else if (_loai == 7 && (obj.MaDT.Substring(0, 1) == "0"))
                    {
                        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                        {
                            _tbhtra = 0;
                            _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
                        }
                        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                            _tbh = 0;
                        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

                    }
                    else if (_loai != 2 && _loai != 9 && _loai != 8 && _loai != 11)
                    {
                        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                        {
                            _tbhtra = _tbhtra + obj.TongTienBH;
                            _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
                        }
                        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                            _tbh = _tbh + obj.TongTienBH;
                        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

                    }

                };
                //_TongHD = _TongTienHoaDon;

                if (_loai == 2 || _loai == 11)
                    _TongThuHoaDon = _TongTienHoaDon + _MienGiamBH;
                else
                    _TongThuHoaDon = _TongTienHoaDon + _MienGiamTT;

                _TongTienTT = _TongTienTTCTT + _TongTienTTDTT;
                _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                if (((HTC.ShareVariables.pub_spC == "HU" || HTC.ShareVariables.pub_spC == "QN" || HTC.ShareVariables.pub_spC == "PH") && _loai == 2))
                {
                    _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                    if (_TongTienBH <= _sotienbhtra)
                        _TongBHTra = _TongTienBH;
                    else
                        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                    _TongBHKTra = _TongTienBH - _TongBHTra;

                    if (_TongTienBHDTT <= _sotienbhtra)
                        _TongBHTraDTT = _TongTienBHDTT;
                    else
                    {
                        _TongBHTraDTT = ((_TongTienBHDTT) * _bhtra) / decimal.Parse("100");

                    }
                }
                else if ((_loai == 2 || _loai == 11 ))//if ((_loai == 2 || _loai == 11 ) &&(HTC .ShareVariables .pub_spC!="HU"))
                {
                    _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                    if (_TongTienBH <= _sotienbhtra)
                        _TongBHTra = _TongTienBH;
                    else
                        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                    _TongBHKTra = _TongTienBH - _TongBHTra;
                }
                else if ((_loai == 9 || _loai == 8)|| _loai == 7)
                {
                    _TongBHKTra = 0;
                    _TongTienBH = 0;
                    _TongBHTra = 0;
                    _tbh = 0;
                }
                else
                {
                    if (HTC.ShareVariables .pub_spC =="YH" && _maDT =="20002") 
                         _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                    else
                        _TongTienBH = _TongTienBHCTT ;
                    if (_TongTienBH <= _sotienbhtra)
                        _TongBHTra = _TongTienBH;
                    else
                        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                    _TongBHKTra = _TongTienBH - _TongBHTra;

                    if (_TongTienBHDTT <= _sotienbhtra)
                        _TongBHTraDTT = _TongTienBHDTT;
                    else
                    {
                        _TongBHTraDTT = ((_TongTienBHDTT) * _bhtra) / decimal.Parse("100");

                    }
                }
                if (_maDT.Substring(0, 1) == "0" || (_loai == 9 || _loai == 8)|| _loai == 8 || _loai == 7)
                {
                    _TongBHKTra = 0;
                    _TongTienBH = 0;
                    _TongBHTra = 0;
                    _tbh = 0;
                }
                else
                    _TongBHKTra = _TongTienBH - _TongBHTra - _tbh ;

                if ((_loai == 2 || _loai == 11))// && HTC .ShareVariables .pub_spC !="HU" -- cai nay bi tinh nham chenhlech 
                {
                    _TongThanhToan = _TongBHKTra - _tbhtra;
                    _TongThanhToan = _TongThanhToan + _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT;

                    _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
                    _TongThuHoaDon = _TongBHKTra - _MienGiam + _TongTienTTCTT;

                }
                else if ((_loai == 9 || _loai == 8)|| _loai == 7)
                {
                    _TongThanhToan = _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT;
                    _TongTienCTT = _TongTienTTCTT+_TongTienBHCTT ;
                    if (_TongThanhToan < 0)
                        _MienGiamBH = 0;
                    if (_TongThanhToan < 0 && _TongHD >0)
                        _TongThuHoaDon = _TongThanhToan + _TongHD - _MienGiam;
                    else if (_TongThanhToan < 0 && _TongHD != _TongThuHoaDon)
                        _TongThuHoaDon = _TongThuHoaDon + _TongThanhToan - _TongHD - _MienGiam;
                    else if (_TongThanhToan < 0 && _TongHD == 0)
                        _TongThuHoaDon = _TongThuHoaDon + _TongThanhToan  - _MienGiam;
                    else
                        _TongThuHoaDon = _TongThanhToan - _MienGiam;
                }
                else if (_loai == 3)// else if (_loai == 3||(_loai ==2&&HTC .ShareVariables .pub_spC =="HU"))
                {
                    _TongThanhToan = _TongTienTT + _TongTienBH;
                    _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
                    _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                    if (_TongTienBH <= _sotienbhtra)
                        _TongBHTra = _TongTienBH;
                    else
                        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                    _TongBHKTra = _TongTienBH - _TongBHTra;
                    _TongThuHoaDon = _TongBHKTra - _MienGiam + _TongTienTTCTT - _MienGiam;
                }
                else
                {
                    _TongThanhToan = _TongBHKTra + _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT - _tbhtra;

                    _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;

                }
                _TongHD = _TongTienHoaDon;
            }


        }

        #endregion
    }

}
