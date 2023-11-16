using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.Duoc;
using HTC.Business;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public partial class PhieuCheBien : BusinessBase<PhieuCheBien>
    {
        #region Business Method
        #region State Fields
        private String _MaCB = String.Empty;
        private String _noiXuat = String.Empty;
        private SmartDate _ngayXuat = new SmartDate(false);
        private SmartDate _NgayNhap = new SmartDate(false);
        private SmartDate _ngayXuatD = new SmartDate(false);
        private SmartDate _ngayXuatTT = new SmartDate(false);
        private SmartDate _ngayXuatTTD = new SmartDate(false);
        private SmartDate _NgayNhapD = new SmartDate(false);
        private String _noiNhap = String.Empty;
        private String _MaDT = String.Empty;
        private String _TenDT = String.Empty;        
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
        private String _maMay = String.Empty;
        private String _tenNoiXuat = String.Empty;
        private String _tenNoiNhap = String.Empty;    
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiXuat = String.Empty;
        private String _tenNguoiNhan = String.Empty;

        private String _mathuoc = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private Decimal _soLuong = 0;
        private SmartDate _HanSD = new SmartDate(true);
        private Decimal _donGia = 0;
        private Decimal _giaban = 0;
        private String _soLo = String.Empty;        
        private Decimal _TongTien=0;
        private String _maPX = String.Empty;
        private String _maPHC = String.Empty;
        private String _maPPL = String.Empty;
        private String _maPBB = String.Empty;
        private Decimal _TienPX = 0;
        private Decimal _TienHC = 0;
        private Decimal _TienPL = 0;
        private Decimal _TienBB = 0;
        private Decimal _TienKhac = 0;
        private Decimal _TienCong = 0;
        private Decimal _DienNuoc= 0;
        private Decimal _Khoanthem = 0;
        private Boolean _daPhat = false;
        private Boolean _daDuyet = false;
        private Byte _loaiPhieu;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Method
        public String SoLo
        {
            get
            {
                CanReadProperty("SoLo", true);
                return _soLo;
            }
            set
            {
                CanWriteProperty("SoLo", true);
                if (_soLo != value)
                {
                    _soLo = value;
                    PropertyHasChanged("SoLo");
                }
            }
        }
        public String HanSD
        {
            get
            {
                CanReadProperty("HanSD", true);

                return _HanSD.Text;
            }
            set
            {
                CanWriteProperty("HanSD", true);

                if (!_HanSD.Text.Equals(value))
                {

                    //_hanSD.Date   = DateTime.Parse(value);
                    _HanSD.Text = value;
                    PropertyHasChanged("HanSD");
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
        public String MaCB
        {
            get
            {
                CanReadProperty("MaCB", true);
                return _MaCB;
            }
            set
            {
                CanWriteProperty("MaCB", true);
                if (_MaCB != value)
                {
                    _MaCB = value;
                    PropertyHasChanged("MaCB");
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
        public String NgayNhap
        {
            get
            {
                CanReadProperty("NgayNhap", true);
                // _NgayNhap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayNhap.Text;
            }
            set
            {
                CanWriteProperty("NgayNhap", true);
                if (_NgayNhap != value)
                {
                    _NgayNhap.Text = value;
                    PropertyHasChanged("NgayNhap");
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

        public String NgayNhapD
        {
            get
            {
                CanReadProperty("NgayNhapD", true);
                _NgayNhap.FormatString = "dd/MM/yyyy ";
                return _NgayNhap.Text;
            }
            set
            {
                CanWriteProperty("NgayNhapD", true);
                if (_NgayNhap != value)
                {
                    _NgayNhap.Text = value;
                    PropertyHasChanged("NgayNhapD");
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
        public String TenNguoiXuat
        {
            get
            {
                CanReadProperty("TenNguoiXuat", true);
                return _tenNguoiXuat;
            }
            set
            {
                CanWriteProperty("TenNguoiXuat", true);
                if (_tenNguoiXuat != value)
                {
                    _tenNguoiXuat = value;
                    PropertyHasChanged("TenNguoiXuat");
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
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
        public String Mathuoc
        {
            get
            {
                CanReadProperty("Mathuoc", true);
                return _mathuoc;
            }
            set
            {
                CanWriteProperty("Mathuoc", true);
                if (_mathuoc != value)
                {
                    _mathuoc = value;
                    PropertyHasChanged("Mathuoc");
                }
            }
        }
        public String Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.###");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Soluong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
                }
            }
        }
     
        public string DonGia
        {
            get
            {
                CanReadProperty("DonGia", true);
                if (_donGia == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGia.ToString("###,###.###");
                }
            }
            set
            {
                CanWriteProperty("DonGia", true);

                if (_donGia.ToString() != value)
                {
                    _donGia = decimal.Parse(value);
                    PropertyHasChanged("DonGia");
                }
            }
        }
        public string giaban
        {
            get
            {
                CanReadProperty("giaban", true);
                if (_giaban == 0)
                {
                    return "0";
                }
                else
                {
                    return _giaban.ToString("###,###.###");
                }
            }
            set
            {
                CanWriteProperty("giaban", true);

                if (_giaban.ToString() != value)
                {
                    _giaban = decimal.Parse(value);
                    PropertyHasChanged("giaban");
                }
            }
        }
        public string TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
                _TongTien  = _TienKhac + _TienPX + _TienHC + _TienPL + _TienBB + _TienCong + _DienNuoc + _Khoanthem;
              
                if (_TongTien == 0)
                {
                    return "0";
                }
                else
                {
                    return _TongTien.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TongTien", true);

                if (_TongTien.ToString() != value)
                {
                    _TongTien = decimal.Parse(value);
                    PropertyHasChanged("TongTien");
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
        public String MaPHC
        {
            get
            {
                CanReadProperty("MaPHC", true);
                return _maPHC;
            }
            set
            {
                CanWriteProperty("MaPHC", true);
                if (_maPHC != value)
                {
                    _maPHC = value;
                    PropertyHasChanged("MaPHC");
                }
            }
        }
        public String MaPPL
        {
            get
            {
                CanReadProperty("MaPPL", true);
                return _maPPL;
            }
            set
            {
                CanWriteProperty("MaPPL", true);
                if (_maPPL != value)
                {
                    _maPPL = value;
                    PropertyHasChanged("MaPPL");
                }
            }
        }
        public String MaPBB
        {
            get
            {
                CanReadProperty("MaPBB", true);
                return _maPBB;
            }
            set
            {
                CanWriteProperty("MaPBB", true);
                if (_maPBB != value)
                {
                    _maPBB = value;
                    PropertyHasChanged("MaPBB");
                }
            }
        }
        public string TienPX
        {
            get
            {
                CanReadProperty("TienPX", true);
                if (_TienPX == 0)
                {
                    return "0";
                }
                else
                {
                    return _TienPX.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TienPX", true);

                if (_TienPX.ToString() != value)
                {
                    _TienPX = decimal.Parse(value);
                    PropertyHasChanged("TienPX");
                }
            }
        }
        public string TienHC
        {
            get
            {
                CanReadProperty("TienHC", true);
                if (_TienHC == 0)
                {
                    return "0";
                }
                else
                {
                    return _TienHC.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TienHC", true);

                if (_TienHC.ToString() != value)
                {
                    _TienHC = decimal.Parse(value);
                    PropertyHasChanged("TienHC");
                }
            }
        }
        public string TienPL
        {
            get
            {
                CanReadProperty("TienPL", true);
                if (_TienPL == 0)
                {
                    return "0";
                }
                else
                {
                    return _TienPL.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TienPL", true);

                if (_TienPL.ToString() != value)
                {
                    _TienPL = decimal.Parse(value);
                    PropertyHasChanged("TienPL");
                }
            }
        }
        public string TienBB
        {
            get
            {
                CanReadProperty("TienBB", true);
                if (_TienBB == 0)
                {
                    return "0";
                }
                else
                {
                    return _TienBB.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TienBB", true);

                if (_TienBB.ToString() != value)
                {
                    _TienBB = decimal.Parse(value);
                    PropertyHasChanged("TienBB");
                }
            }
        }
        public string TienKhac
        {
            get
            {
                CanReadProperty("TienKhac", true);
                if (_TienKhac == 0)
                {
                    return "0";
                }
                else
                {
                    return _TienKhac.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TienKhac", true);

                if (_TienKhac.ToString() != value)
                {
                    _TienKhac = decimal.Parse(value);
                    PropertyHasChanged("TienKhac");
                }
            }
        }
        public string TienCong
        {
            get
            {
                CanReadProperty("TienCong", true);
                if (_TienCong == 0)
                {
                    return "0";
                }
                else
                {
                    return _TienCong.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TienCong", true);

                if (_TienCong.ToString() != value)
                {
                    _TienCong = decimal.Parse(value);
                    PropertyHasChanged("TienCong");
                }
            }
        }
        public string DienNuoc
        {
            get
            {
                CanReadProperty("DienNuoc", true);
                if (_DienNuoc == 0)
                {
                    return "0";
                }
                else
                {
                    return _DienNuoc.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("DienNuoc", true);

                if (_DienNuoc.ToString() != value)
                {
                    _DienNuoc = decimal.Parse(value);
                    PropertyHasChanged("DienNuoc");
                }
            }
        }
        public string Khoanthem
        {
            get
            {
                CanReadProperty("Khoanthem", true);
                if (_Khoanthem == 0)
                {
                    return "0";
                }
                else
                {
                    return _Khoanthem.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("Khoanthem", true);

                if (_Khoanthem.ToString() != value)
                {
                    _Khoanthem = decimal.Parse(value);
                    PropertyHasChanged("Khoanthem");
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
        PhieuCheBien_Cs _PhieuCheBienCs = PhieuCheBien_Cs.NewPhieuCheBien_Cs();
        public PhieuCheBien_Cs PhieuCheBienCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _PhieuCheBienCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_PhieuCheBienCs.Equals(value))
                {
                    _PhieuCheBienCs = value;
                    PropertyHasChanged();
                }
            }
        }

        


        protected override object GetIdValue()
        {
            return _MaCB;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _PhieuCheBienCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _PhieuCheBienCs.IsValid;
            }
        }
        #endregion
        #endregion

        #region Business Object Rules and Validation
       
        #endregion

       #region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="PhieuCheBien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static PhieuCheBien NewPhieuCheBien()
        {
            return DataPortal.Create<PhieuCheBien>();
        }
       

        public static PhieuCheBien GetPhieuCheBien(String MaCB, byte loaiphieu, Boolean daphat,Boolean qadmin)
		{
            return DataPortal.Fetch<PhieuCheBien>(new Criteria(MaCB, loaiphieu, daphat,qadmin));
		}
		
		/// <summary>
		/// Marks the <see cref="PhieuCheBien" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeletePhieuCheBien(String maBenhID, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(maBenhID,mamay,nguoihuy ));
		}
        private PhieuCheBien(string MaCB)
        {
            _MaCB = MaCB ;
        }
		#endregion
		

        #region Constructors

        protected internal PhieuCheBien()
        {
            //
            _ngayLap.Date = DateTime.Now;
        }
        internal PhieuCheBien(int OrderNumber,
                            String MaCB,
                           String noiXuat,
                            SmartDate ngayXuat,
                            SmartDate ngayXuatTT,
                            SmartDate NgayNhap,
                            String noiNhap,                           
                            String soCT,
              String nvXuat,            
                            String nvNhan,
                            String ghiChu
                            ,Boolean huy
                            ,SmartDate ngaySD,
                            String nguoiSD,
                            SmartDate ngayLap,
                            String nguoiLap,
                            SmartDate ngayHuy,
                            String nguoiHuy
                            , String maMay,
                            String tenNoixuat,                            
                            String tenNoiNhap,                            
                            String tenNguoiLap,
                            String tenNguoiSD,
                            String tenNguoiHuy,
                            String tenNguoiXuat,
                            String tenNguoiNhan
                            , String MaDT,
                            String TenDT,
                            String Mathuoc,                           
                            String tenTM,
                            Decimal Soluong, 
                            String tenDVT,
                            SmartDate HanSD,
                            String Solo,
                            Decimal Dongia,
                            Decimal giaban,
                          
                            String MaPHC,
                            String MaPPL,
                            String MaPBB,
                            Decimal TienPX,
                            Decimal TienHC,
                            Decimal TienPL,
                            Decimal TienBB,
                            Decimal TongTien,
                            Decimal TienKhac,
                            Decimal DienNuoc,
                            Decimal TienCong,
                            Decimal Khoanthem,
            Boolean daphat,
            Boolean daduyet,
            byte loaiphieu
                           )
        {
            _OrderNumber = OrderNumber;
            _daPhat = daphat;
            _daDuyet = daduyet;
            _loaiPhieu = loaiphieu;
            _MaCB=MaCB ;
            _noiXuat = noiXuat;
            _ngayXuat = ngayXuat;
            _ngayXuatTT = ngayXuatTT;
            _NgayNhap = NgayNhap;
            _noiNhap = noiNhap;                           
            _soCT=soCT ;
            _nvXuat = nvXuat;        
            _nvNhan=NVNhan ;
            _ghiChu=ghiChu ;
            _huy=Huy ;
            _ngaySD = NgaySD;
            _nguoiSD = NguoiSD;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _maMay = MaMay;
            _tenNoiXuat = tenNoixuat;
            _tenNoiNhap = tenNoiNhap;
            _tenNguoiLap = tenNguoiLap;
            _tenNguoiSD = tenNguoiSD;
            _tenNguoiHuy = tenNguoiHuy;
            _tenNguoiXuat = tenNguoiXuat;
            _tenNguoiNhan = tenNguoiNhan;
            _MaDT = MaDT;
            _TenDT = TenDT;
            _mathuoc = Mathuoc;
            _tenTM = tenTM;
            _soLuong =Soluong;
            _tenDVT = tenDVT;
            _HanSD = HanSD;
            _soLo = Solo;
            _donGia = Dongia;
            _giaban = giaban;
          
            _maPHC = MaPHC;
            _maPPL = MaPPL;
            _maPBB = MaPBB;
            _TienPX = TienPX;
            _TienHC = TienHC;
            _TienPL = TienPL;
            _TienBB = TienBB;
            _TongTien = TongTien;             
            _TienKhac =TienKhac ;
            _DienNuoc=DienNuoc ;
            _TienCong = TienCong;
            _Khoanthem = Khoanthem;
        }
        #endregion

        #region Criteria
        [Serializable()]
        protected class Criteria
        {
            private String _MaCB;
            private String _dk;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
            public String MaCB
            {
                get
                {
                    return _MaCB;
                }
            }
            public String dk
            {
                get
                {
                    return _dk;
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
            public Criteria(String MaCB, byte loaiphieu, Boolean daphat,Boolean qadmin)
            {
                _MaCB = MaCB;
                _daPhat = daphat;
                _loaiPhieu = loaiphieu;
                _qadmin =qadmin ;
            }
             private Boolean _qadmin = false ;

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaCB.Equals(c._MaCB))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaCB.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaCB;
            public String MaCB
            {
                get
                {
                    return _MaCB;
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
            public OtherCriteria(String MaCB, String Mamay, String Nguoisd)
            {
                _MaCB = MaCB;
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
            _MaCB = dr.GetString("MaCB");
            _daPhat = dr.GetBoolean("daPhat");
            _daDuyet = dr.GetBoolean("daDuyet");
            _loaiPhieu = dr.GetByte("LoaiPhieu");
            _noiXuat = dr.GetString("NoiXuat");
            _ngayXuat = dr.GetSmartDate("NgayXuat");
            _ngayXuatTT = dr.GetSmartDate("NgayXuatTT");
            _NgayNhap = dr.GetSmartDate("NgayNhap");
            _noiNhap = dr.GetString("NoiNhap");
            _soCT = dr.GetString("soCT");
            _nvNhan = dr.GetString("NVNhan");
            _nvXuat = dr.GetString("NVXuat");
            _ghiChu = dr.GetString("ghiChu");
            _huy = dr.GetBoolean("Huy");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _ngayLap = dr.GetSmartDate("NgayLap", false);
            _nguoiLap = dr.GetString("NguoiLap");
            _ngayHuy = dr.GetSmartDate("NgayHuy", false);
            _nguoiHuy = dr.GetString("NguoiHuy");
            _maMay = dr.GetString("MaMay");
            _tenNoiXuat = dr.GetString("TenNoiXuat");
            _tenNoiNhap = dr.GetString("TenNoiNhap");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("tenNguoiHuy");
            _tenNguoiXuat = dr.GetString("tenNguoiXuat");
            _tenNguoiNhan = dr.GetString("tenNguoiNhan");
            _MaDT = dr.GetString("MaDT");
            _TenDT = dr.GetString("TenDT");
            _mathuoc = dr.GetString("Mathuoc");
            _HanSD = dr.GetSmartDate("HanSD");
            _soLo = dr.GetString("SoLo");
            _donGia = dr.GetDecimal("Dongia");
            _giaban = dr.GetDecimal("giaban");
            _soLuong = dr.GetDecimal("Soluong");
            _maPX = dr.GetString("MaPX");
            _maPHC = dr.GetString("MaPHC");
           
            _maPPL = dr.GetString("MaPPL");
            _maPBB = dr.GetString("MaPBB");
            _TienPX = dr.GetDecimal("TienPX");
            _TienHC = dr.GetDecimal("TienHC");
            _TienPL = dr.GetDecimal("TienPL");
            _TienBB = dr.GetDecimal("TienBB");
            _TongTien = dr.GetDecimal("TongTien");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _TienKhac = dr.GetDecimal("TienKhac");
            _DienNuoc = dr.GetDecimal("DienNuoc");
            _TienCong = dr.GetDecimal("TienCong");
            _Khoanthem  = dr.GetDecimal("khoanthem");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuCheBien(crit.MaCB, crit.qadmin, crit.LoaiPhieu, crit.daphat)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _PhieuCheBienCs = PhieuCheBien_Cs.GetPhieuCheBien_Cs(dr);
                    }
                    MarkOld();
                    ValidationRules.CheckRules();
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
            
            
            _MaCB = DataProvider.Instance().InsertPhieuCheBien(_noiXuat, _ngayXuat, _ngayXuatTT, _noiNhap, _NgayNhap, _soCT, _nvXuat, _nvNhan, _mathuoc, _soLuong, _donGia, _soLo, _HanSD, _TienPX, _maPHC, _TienHC, _maPPL, _TienPL, _maPBB, _TienBB, _ghiChu, _TongTien, _TienCong, _DienNuoc, _Khoanthem, _TienKhac, _MaDT, _daPhat,_daDuyet,_loaiPhieu, _nguoiSD , _maMay);
            MarkOld();
           _PhieuCheBienCs.Update(this);

        }
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
                
                
                DataProvider.Instance().UpdatePhieuCheBien(_MaCB, _noiXuat, _ngayXuat, _ngayXuatTT, _noiNhap, _NgayNhap, _soCT, _nvXuat, _nvNhan, _mathuoc, _soLuong, _donGia,_giaban, _soLo, _HanSD, _TienPX, _maPHC, _TienHC, _maPPL, _TienPL, _maPBB, _TienBB, _ghiChu, _nguoiSD , _TongTien, _TienCong, _DienNuoc, _TienKhac, _Khoanthem, _MaDT, _daPhat, _daDuyet, _loaiPhieu, _huy, _maMay);
            _PhieuCheBienCs.Update(this);
            }
        }  

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_MaCB, _maMay, _nguoiSD));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeletePhieuCheBien(crit.MaCB, crit.MaMay, crit.NguoiSD);

        }

        #endregion


    }
}
