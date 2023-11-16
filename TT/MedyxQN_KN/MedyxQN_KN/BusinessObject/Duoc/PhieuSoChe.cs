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
    public partial class PhieuSoChe : BusinessBase<PhieuSoChe>
    {
        #region Business Method
        #region State Fields
        private String _MaSC = String.Empty;
        private String _noiXuat = String.Empty;
        private SmartDate _ngayXuat = new SmartDate(false);
        private SmartDate _NgayNhap = new SmartDate(false);
        private SmartDate _ngayXuatD = new SmartDate(false);
        private SmartDate _NgayNhapD = new SmartDate(false);
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
        private SmartDate _ngaySD1 = new SmartDate(false);
        private String _nguoiSD1 = String.Empty;
      
        private Boolean _khoaYC = false;
        private String _maMay = String.Empty;
        private String _tenNoiXuat = String.Empty;
        private String _tenNoiNhap = String.Empty;
        private String _tenNVXuat = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiNhan = String.Empty;
        private Boolean _daPhat = false;
        private Boolean _daDuyet = false;
        private Decimal _TongTien = 0;
    
        private String _maPHC = String.Empty;
        private String _maPPL = String.Empty;
        private String _maPBB = String.Empty;
        private Decimal _TienPX = 0;
        private Decimal _TienHC = 0;
        private Decimal _TienPL = 0;
        private Decimal _TienBB = 0;
        private Decimal _TienKhac = 0;
        private Decimal _TienCong = 0;
        private Decimal _DienNuoc = 0;
        private Decimal _Khoanthem = 0;
        private int _OrderNumber;
        private Boolean _Khongsua = false;
        #endregion

        #region Business Properties and Method
        public string TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
                _TongTien = _TienKhac + _TienPX + _TienHC + _TienPL + _TienBB + _TienCong + _DienNuoc + _Khoanthem;

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
        public String MaSC
        {
            get
            {
                CanReadProperty("MaSC", true);
                return _MaSC;
            }
            set
            {
                CanWriteProperty("MaSC", true);
                if (_MaSC != value)
                {
                    _MaSC = value;
                    PropertyHasChanged("MaSC");
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
        //public String DoiTuong
        //{
        //    get
        //    {
        //        if (_baoHiem == true)
        //            _doiTuong = "1";
        //        else
        //            _doiTuong = "0";
        //        return _doiTuong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DoiTuong", true);
        //        if (_doiTuong != value)
        //        {
        //            _doiTuong = value;

        //            PropertyHasChanged("DoiTuong");
        //        }
        //    }
        //}
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
        //public Boolean BaoHiem
        //{
        //    get
        //    {
        //        //CanReadProperty("BaoHiem", true);
        //        if (_doiTuong == "1")
        //            _baoHiem = true;
        //        else
        //            _baoHiem = false;
        //        return _baoHiem;
        //    }
        //    set
        //    {
        //        CanWriteProperty("BaoHiem", true);
        //        if (_baoHiem != value)
        //        {
        //            _baoHiem = value;
        //            _doiTuong = "1";
        //            PropertyHasChanged("BaoHiem");
        //        }
        //}
        //}
        //public Boolean NhanDan
        //{
        //    get
        //    {
        //        //CanReadProperty("NhanDan", true);
        //        if (_baoHiem == true)
        //            _nhanDan = false;
        //        else
        //            _nhanDan = true;
        //        return _nhanDan;

        //    }
        //    set
        //    {
        //        CanWriteProperty("NhanDan", true);
        //        if (_nhanDan != value)
        //        {
        //            _nhanDan = value;
        //            _doiTuong = "0";
        //            PropertyHasChanged("NhanDan");
        //        }
        //    }
        //}
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

        PhieuSoChe_Cs _PhieuSoCheCs = PhieuSoChe_Cs.NewPhieuSoChe_Cs();
        public PhieuSoChe_Cs PhieuSoCheCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _PhieuSoCheCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_PhieuSoCheCs.Equals(value))
                {
                    _PhieuSoCheCs = value;
                    PropertyHasChanged();
                }
            }
        }


        protected override object GetIdValue()
        {
            return _MaSC;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _PhieuSoCheCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _PhieuSoCheCs.IsValid;
            }
        }




        #endregion
        #endregion

        #region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //    ValidationRules.AddRule<PhieuSoChe>(StringRequiredNoiXuat<PhieuSoChe>, "NoiXuat");
        //    ValidationRules.AddRule<PhieuSoChe>(StringRequiredNhanVien<PhieuSoChe>, "NVXuat");
        //    //  ValidationRules.AddRule<PhieuSoChe>(ValidationDateTT<PhieuSoChe>, "NgayNhap");

        //}
        //private static bool StringRequiredNoiXuat<T>(T target, Csla.Validation.RuleArgs e) where T : PhieuSoChe
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
        //private static bool StringRequiredNhanVien<T>(T target, Csla.Validation.RuleArgs e) where T : PhieuSoChe
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
        public static PhieuSoChe NewPhieuSoChe()
        {
            return DataPortal.Create<PhieuSoChe>();
        }

        public static PhieuSoChe GetPhieuSoChe(String MaSC,  byte loaiphieu, Boolean daphat,Boolean qadmin)
        {
            return DataPortal.Fetch<PhieuSoChe>(new Criteria(MaSC,  loaiphieu,  daphat, qadmin));
        }

        public static PhieuSoChe GetPhieuSoChe(SafeDataReader dr)
        {
            PhieuSoChe obj = new PhieuSoChe();
            obj.Fetch(dr);
            return obj;

        }

        public static void DeletePhieuSoChe_C(String MaSC, string mamay, string nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(MaSC, mamay, nguoisd));
        }

        #endregion

        #region Constructors

        protected internal PhieuSoChe()
        {
            //
            _ngayXuat.Date = DateTime.Now;
        }
        internal PhieuSoChe(int OrderNumber,
                            String MaSC,
                            String noiXuat,
                            SmartDate ngayXuat,
                            SmartDate NgayNhap,
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
                            Boolean daDuyet,
                            String MaDT,
                            String TenDT,
                            Boolean Khongsua,
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
                            Decimal Khoanthem

                           )
        {
            _OrderNumber = OrderNumber;
            _MaSC = MaSC;
            _noiXuat = noiXuat;
            _ngayXuat = ngayXuat;
            _NgayNhap = NgayNhap;
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
            _maPHC = MaPHC;
            _maPPL = MaPPL;
            _maPBB = MaPBB;
            _TienPX = TienPX;
            _TienHC = TienHC;
            _TienPL = TienPL;
            _TienBB = TienBB;
            _TongTien = TongTien;
            _TienKhac = TienKhac;
            _DienNuoc = DienNuoc;
            _TienCong = TienCong;
            _Khoanthem = Khoanthem;

        }
        #endregion

        #region Criteria
        [Serializable()]
        protected class Criteria
        {
            private String _MaSC;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
            public String MaSC
            {
                get
                {
                    return _MaSC;
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
            public Criteria(String MaSC,  byte loaiphieu, Boolean daphat,Boolean qadmin)
            {
                _MaSC = MaSC;
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
                    if (!_MaSC.Equals(c._MaSC))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaSC.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSC;
            public String MaSC
            {
                get
                {
                    return _MaSC;
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
            public OtherCriteria(String MaSC, String Mamay, String Nguoisd)
            {
                _MaSC = MaSC;
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
            _MaSC = dr.GetString("MaSC");
            _noiXuat = dr.GetString("NoiXuat");
            _ngayXuat = dr.GetSmartDate("NgayXuat");
            _NgayNhap = dr.GetSmartDate("NgayNhap");
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
            _MaDT = dr.GetString("MaDT");
            _TenDT = dr.GetString("TenDT");
            _Khongsua = dr.GetBoolean("Khongsua");
            _maPHC = dr.GetString("MaPHC");

            _maPPL = dr.GetString("MaPPL");
            _maPBB = dr.GetString("MaPBB");
            _TienPX = dr.GetDecimal("TienPX");
            _TienHC = dr.GetDecimal("TienHC");
            _TienPL = dr.GetDecimal("TienPL");
            _TienBB = dr.GetDecimal("TienBB");
            _TongTien = dr.GetDecimal("TongTien");
           
            _TienKhac = dr.GetDecimal("TienKhac");
            _DienNuoc = dr.GetDecimal("DienNuoc");
            _TienCong = dr.GetDecimal("TienCong");
            _Khoanthem = dr.GetDecimal("khoanthem");

        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuSoche(crit.MaSC, crit.qadmin, crit.LoaiPhieu, crit.daphat)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _PhieuSoCheCs = PhieuSoChe_Cs.GetPhieuSoChe_Cs(dr);
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
            
            
            _MaSC = DataProvider.Instance().InsertPhieuSoChe(_noiXuat, _ngayXuat ,_noiNhap, _NgayNhap, _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _nguoiLap, _khoaYC, _maMay, _daPhat, _daDuyet, _MaDT, _Khongsua, _TienPX, _maPHC, _TienHC, _maPPL, _TienPL, _maPBB, _TienBB, _TongTien,_TienCong, _DienNuoc, _TienKhac,  _Khoanthem);
            MarkOld();
            _PhieuSoCheCs.Update(this);

        }
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
                
                
                DataProvider.Instance().UpdatePhieuSoChe(_MaSC, _noiXuat, _ngayXuat,_noiNhap,_NgayNhap , _loaiPhieu, _soCT, _nvXuat, _nvNhan, _ghiChu, _huy, _maMay, _nguoiSD , _daPhat, _daDuyet,_MaDT, _TienPX, _maPHC, _TienHC, _maPPL, _TienPL, _maPBB, _TienBB, _TongTien,_TienCong,_DienNuoc,_TienKhac,_Khoanthem );

                _PhieuSoCheCs.Update(this);
            }
          
          
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_MaSC, _maMay, _nguoiSD));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeletePhieuSoChe(crit.MaSC, crit.MaMay, crit.NguoiSD);

        }

        #endregion


    }
}
