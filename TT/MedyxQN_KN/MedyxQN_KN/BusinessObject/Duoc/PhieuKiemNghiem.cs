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
    public partial class PhieuKiemNghiem : BusinessBase<PhieuKiemNghiem>
    {
        #region Business Method
        #region State Fields
        private String _MaKN = String.Empty;

        private SmartDate _NgayKN = new SmartDate(false);
        private SmartDate _NgayYCKN = new SmartDate(false);
        private SmartDate _NgayTraKN = new SmartDate(false);
        private SmartDate _NgayU = new SmartDate(false);
        private String _DangMau = String.Empty;
        private String _DangKN = String.Empty;
        private String _YeuCauKN = String.Empty;
        private String _maNCC = String.Empty;
        private String _tenNCC = String.Empty;
        private String _tengoc = String.Empty;
      
        private Decimal _donGiaTT = 0;
        private Decimal _soLuong = 0;
        private SmartDate _NgayNhap = new SmartDate(false);
        private SmartDate _NgayGiao = new SmartDate(false);
        private SmartDate _NgayKND = new SmartDate(false);
        private SmartDate _NgayGiaoD = new SmartDate(false);
        private String _noiNhap = String.Empty;
        private String _MaDT = String.Empty;
        private String _TenDT = String.Empty;
        private String _soCT = String.Empty;
        private String _solt = String.Empty;
        private String _NVKN = String.Empty;

        private String _nvGiao = String.Empty;
        private String _nvLay = String.Empty;
        private String _nvTra = String.Empty;
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
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;

        private String _mathuoc = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private SmartDate _HanSD = new SmartDate(true);
        private SmartDate _NgaySX = new SmartDate(true);
        private String _soLo = String.Empty;
        private String _tenNoiNhap = String.Empty;
        private String _KetQua = String.Empty;
        private String _tenNguoiKN = String.Empty;
        private String _tenNguoilay = String.Empty;
        private String _tenNguoigiao = String.Empty;
        private String _tenNguoitra = String.Empty;
        private String _tenNguoinhan = String.Empty;

        private Boolean _KQ ;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Method
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
        public String tengoc
        {
            get
            {
                CanReadProperty("tengoc", true);
                return _tengoc;
            }
            set
            {
                CanWriteProperty("tengoc", true);
                if (_tengoc != value)
                {
                    _tengoc = value;
                    PropertyHasChanged("tengoc");
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
        public String YeuCauKN
        {
            get
            {
                CanReadProperty("YeuCauKN", true);
                return _YeuCauKN;
            }
            set
            {
                CanWriteProperty("YeuCauKN", true);
                if (_YeuCauKN != value)
                {
                    _YeuCauKN = value;
                    PropertyHasChanged("YeuCauKN");
                }
            }
        }
        public String NgayU
        {
            get
            {
                CanReadProperty("NgayU", true);
                // _ngayLayKN.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayU.Text;
            }
            set
            {
                CanWriteProperty("NgayU", true);
                if (_NgayU != value)
                {
                    _NgayU.Text = value;
                    PropertyHasChanged("NgayU");
                }
            }
        }
        public String MaKQ
        {
            get
            {

                if (_KQ == false && _NgayKN !=null)
                    return "KDat";
                else if (_KQ == true)
                    return "Dat";
                return "";
            }
           
        }
        public String DangMau
        {
            get
            {
                CanReadProperty("DangMau", true);
                return _DangMau;
            }
            set
            {
                CanWriteProperty("DangMau", true);
                if (_DangMau != value)
                {
                    _DangMau = value;
                    PropertyHasChanged("DangMau");
                }
            }
        }
        public String DangKN
        {
            get
            {
                CanReadProperty("DangKN", true);
                return _DangKN;
            }
            set
            {
                CanWriteProperty("DangKN", true);
                if (_DangKN != value)
                {
                    _DangKN = value;
                    PropertyHasChanged("DangKN");
                }
            }
        }
        public String TenNCC
        {
            get
            {
                CanReadProperty("TenNCC", true);
                return _tenNCC;
            }
            set
            {
                CanWriteProperty("TenNCC", true);
                if (_tenNCC != value)
                {
                    _tenNCC = value;
                    PropertyHasChanged("TenNCC");
                }
            }
        }
        public String MaNCC
        {
            get
            {
                CanReadProperty("MaNCC", true);
                return _maNCC;
            }
            set
            {
                CanWriteProperty("MaNCC", true);
                if (_maNCC != value)
                {
                    _maNCC = value;
                    PropertyHasChanged("MaNCC");
                }
            }
        }
        public String NgayTraKN
        {
            get
            {
                CanReadProperty("NgayTraKN", true);
                // _ngayLayKN.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayTraKN.Text;
            }
            set
            {
                CanWriteProperty("NgayTraKN", true);
                if (_NgayTraKN != value)
                {
                    _NgayTraKN.Text = value;
                    PropertyHasChanged("NgayTraKN");
                }
            }
        }
        public String NVGiao
        {
            get
            {
                CanReadProperty("NVGiao", true);
                return _nvGiao;
            }
            set
            {
                CanWriteProperty("NVGiao", true);
                if (_nvGiao != value)
                {
                    _nvGiao = value;
                    PropertyHasChanged("NVGiao");
                }
            }
        }
        public String NVLay
        {
            get
            {
                CanReadProperty("NVLay", true);
                return _nvLay;
            }
            set
            {
                CanWriteProperty("NVLay", true);
                if (_nvLay != value)
                {
                    _nvLay = value;
                    PropertyHasChanged("NVLay");
                }
            }
        }
        public String NVTra
        {
            get
            {
                CanReadProperty("NVTra", true);
                return _nvTra;
            }
            set
            {
                CanWriteProperty("NVTra", true);
                if (_nvTra != value)
                {
                    _nvTra = value;
                    PropertyHasChanged("NVTra");
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
        public String TenNguoinhan
        {
            get
            {
                CanReadProperty("TenNguoinhan", true);
                return _tenNguoinhan;
            }
            set
            {
                CanWriteProperty("TenNguoinhan", true);
                if (_tenNguoinhan != value)
                {
                    _tenNguoinhan = value;
                    PropertyHasChanged("TenNguoinhan");
                }
            }
        }

        public String TenNguoitra
        {
            get
            {
                CanReadProperty("TenNguoitra", true);
                return _tenNguoitra;
            }
            set
            {
                CanWriteProperty("TenNguoitra", true);
                if (_tenNguoitra != value)
                {
                    _tenNguoitra = value;
                    PropertyHasChanged("TenNguoitra");
                }
            }
        }

        public String TenNguoigiao
        {
            get
            {
                CanReadProperty("TenNguoigiao", true);
                return _tenNguoigiao;
            }
            set
            {
                CanWriteProperty("TenNguoigiao", true);
                if (_tenNguoigiao != value)
                {
                    _tenNguoigiao = value;
                    PropertyHasChanged("TenNguoigiao");
                }
            }
        }

        public String TenNguoilay
        {
            get
            {
                CanReadProperty("TenNguoilay", true);
                return _tenNguoilay;
            }
            set
            {
                CanWriteProperty("TenNguoilay", true);
                if (_tenNguoilay != value)
                {
                    _tenNguoilay = value;
                    PropertyHasChanged("TenNguoilay");
                }
            }
        }

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
        public String NgaySX
        {
            get
            {
                CanReadProperty("NgaySX", true);

                return _NgaySX.Text;
            }
            set
            {
                CanWriteProperty("NgaySX", true);

                if (!_NgaySX.Text.Equals(value))
                {

                    //_NgaySX.Date   = DateTime.Parse(value);
                    _NgaySX.Text = value;
                    PropertyHasChanged("NgaySX");
                }
            }
        }
        public Boolean KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                return _KQ;
            }
            set
            {
                CanWriteProperty("KQ", true);
                if (_KQ != value)
                {
                    _KQ = value;
                    PropertyHasChanged("KQ");
                }
            }
        }


        public String MaKN
        {
            get
            {
                CanReadProperty("MaKN", true);
                return _MaKN;
            }
            set
            {
                CanWriteProperty("MaKN", true);
                if (_MaKN != value)
                {
                    _MaKN = value;
                    PropertyHasChanged("MaKN");
                }
            }
        }


        public String NgayYCKN
        {
            get
            {
                CanReadProperty("NgayYCKN", true);
                // _NgayYCKN.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayYCKN.Text;
            }
            set
            {
                CanWriteProperty("NgayYCKN", true);
                if (_NgayYCKN != value)
                {
                    _NgayYCKN.Text = value;
                    PropertyHasChanged("NgayYCKN");
                }
            }
        }
        public String NgayKN
        {
            get
            {
                CanReadProperty("NgayKN", true);
                // _NgayKN.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayKN.Text;
            }
            set
            {
                CanWriteProperty("NgayKN", true);
                if (_NgayKN != value)
                {
                    _NgayKN.Text = value;
                    PropertyHasChanged("NgayKN");
                }
            }
        }

        public String NgayGiao
        {
            get
            {
                CanReadProperty("NgayGiao", true);
                // _NgayGiao.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayGiao.Text;
            }
            set
            {
                CanWriteProperty("NgayGiao", true);
                if (_NgayGiao != value)
                {
                    _NgayGiao.Text = value;
                    PropertyHasChanged("NgayGiao");
                }
            }
        }
        public String NgayKND
        {
            get
            {
                CanReadProperty("NgayKND", true);
                _NgayKND = _NgayKN;
                _NgayKND.FormatString = "dd/MM/yyyy";
                return _NgayKND.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayKN", true);
            //    if (_NgayKN != value)
            //    {
            //        _NgayKN.Text = value;
            //        PropertyHasChanged("NgayKN");
            //    }
            //}
        }

        public String NgayGiaoD
        {
            get
            {
                CanReadProperty("NgayGiaoD", true);
                _NgayGiao.FormatString = "dd/MM/yyyy ";
                return _NgayGiao.Text;
            }
            set
            {
                CanWriteProperty("NgayGiaoD", true);
                if (_NgayGiao != value)
                {
                    _NgayGiao.Text = value;
                    PropertyHasChanged("NgayGiaoD");
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
        public String Solt
        {
            get
            {
                CanReadProperty("Solt", true);
                return _solt;
            }
            set
            {
                CanWriteProperty("Solt", true);
                if (_solt != value)
                {
                    _solt = value;
                    PropertyHasChanged("Solt");
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
        public String NVKN
        {
            get
            {
                CanReadProperty("NVKN", true);
                return _NVKN;
            }
            set
            {
                CanWriteProperty("NVKN", true);
                if (_NVKN != value)
                {
                    _NVKN = value;
                    PropertyHasChanged("NVKN");
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
        public String TenNguoiKN
        {
            get
            {
                CanReadProperty("TenNguoiKN", true);
                return _tenNguoiKN;
            }
            set
            {
                CanWriteProperty("TenNguoiKN", true);
                if (_tenNguoiKN != value)
                {
                    _tenNguoiKN = value;
                    PropertyHasChanged("TenNguoiKN");
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

        public String KetQua
        {
            get
            {
                CanReadProperty("KetQua", true);
                return _KetQua;
            }
            set
            {
                CanWriteProperty("KetQua", true);
                if (_KetQua != value)
                {
                    _KetQua = value;
                    PropertyHasChanged("KetQua");
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
        PhieuKiemNghiem_Cs _PhieuKiemNghiemCs = PhieuKiemNghiem_Cs.NewPhieuKiemNghiem_Cs();
        public PhieuKiemNghiem_Cs PhieuKiemNghiemCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _PhieuKiemNghiemCs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_PhieuKiemNghiemCs.Equals(value))
                {
                    _PhieuKiemNghiemCs = value;
                    PropertyHasChanged();
                }
            }
        }




        protected override object GetIdValue()
        {
            return _MaKN;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _PhieuKiemNghiemCs.IsDirty;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _PhieuKiemNghiemCs.IsValid;
            }
        }
        #endregion
        #endregion

        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="PhieuKiemNghiem" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static PhieuKiemNghiem NewPhieuKiemNghiem()
        {
            return DataPortal.Create<PhieuKiemNghiem>();
        }


        public static PhieuKiemNghiem GetPhieuKiemNghiem(String MaKN)
        {
            return DataPortal.Fetch<PhieuKiemNghiem>(new Criteria(MaKN));
        }

        /// <summary>
        /// Marks the <see cref="PhieuKiemNghiem" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeletePhieuKiemNghiem(String maBenhID, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBenhID));
        }
        private PhieuKiemNghiem(string MaKN)
        {
            _MaKN = MaKN;
        }
        #endregion


        #region Constructors

        protected internal PhieuKiemNghiem()
        {
            //
            _ngayLap.Date = DateTime.Now;
        }
        internal PhieuKiemNghiem(int OrderNumber,
                            String MaKN,
            SmartDate ngaynhap,
                            SmartDate NgayYCKN,
                          SmartDate NgayKN,
                            SmartDate Ngaytrakn,

                            SmartDate NgayGiao,
                            String noiNhap,
             String solt,
                            String soCT,
                           String NVKN,
                          string tennguoikn,

               String NVgiao,
                          string tennguoigiao,
               String NVlay,
                          string tennguoilay,
               String NVtra,
                          string tennguoitra,
               String NVnhan,
                          string tennguoinhan,

                             String ghiChu
                            , Boolean huy
                            , SmartDate ngaySD,
                            String nguoiSD,
                            SmartDate ngayLap,
                            String nguoiLap,
                            SmartDate ngayHuy,
                            String nguoiHuy
                            , String maMay,

                            String tenNoiNhap,
                            String tenNguoiLap,
                            String tenNguoiSD,
                            String tenNguoiHuy,
                             String MaDT,
                            String TenDT,
                            String Mathuoc,
                            String tenTM,
                      
                            String tenDVT,
                            Decimal Soluong, 
                            SmartDate HanSD,
             SmartDate NgaySx,
                            String Solo,

                            String KetQua,

            Boolean KQ,
            string YeuCauKN,
            SmartDate ngayu,
            string DangMau,
            string DangKN,
            string mancc,
            string tenncc,
            string 
            tengoc
                           )
        {
            _tengoc = tengoc;
            _YeuCauKN = YeuCauKN;
            _NgayNhap = ngaynhap;
            _DangKN = DangKN;
            _DangMau = DangMau;
            _NgayU = ngayu;
            _tenNCC = tenncc;
            _maNCC = mancc;
            _OrderNumber = OrderNumber;
            _KQ = KQ;
            _MaKN = MaKN;
            _NgayYCKN = NgayYCKN;
            _NgayKN = NgayKN;
            _NgayTraKN = Ngaytrakn;
            _nvGiao = NVgiao;
            _tenNguoigiao = tennguoigiao;
            _nvLay = NVlay;
            _tenNguoilay = tennguoilay;
            _nvTra = NVtra;
            _tenNguoitra = tennguoitra;
            _nvNhan = NVnhan;
            _tenNguoinhan = tennguoinhan;
            _NgayGiao = NgayGiao;
            _noiNhap = noiNhap;
            _soCT = soCT;
            _solt = solt;
            _NVKN = NVKN;
            _tenNguoiKN = tennguoikn;
            _ghiChu = ghiChu;
            _huy = Huy;
            _ngaySD = NgaySD;
            _nguoiSD = NguoiSD;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _maMay = MaMay;
            _tenNoiNhap = tenNoiNhap;
            _tenNguoiLap = tenNguoiLap;
            _tenNguoiSD = tenNguoiSD;
            _tenNguoiHuy = tenNguoiHuy;
            _MaDT = MaDT;
            _TenDT = TenDT;
            _mathuoc = Mathuoc;
            _tenTM = tenTM;
            _tenDVT = tenDVT;
            _soLuong = Soluong;
            _HanSD = HanSD;
            _NgaySX = NgaySx;
            _soLo = Solo;
            _KetQua = KetQua;

        }
        #endregion

        #region Criteria
        [Serializable()]
        protected class Criteria
        {
            private String _MaKN;
            private String _dk;
            private Byte _loaiPhieu;
            private Boolean _KQ;
            public String MaKN
            {
                get
                {
                    return _MaKN;
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

            public Boolean KQ
            {
                get
                {
                    return _KQ;
                }
            }
            public Byte LoaiPhieu
            {
                get
                {
                    return _loaiPhieu;
                }
            }
            public Criteria(String MaKN)
            {
                _MaKN = MaKN;

            }
             private Boolean _qadmin = false ;

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaKN.Equals(c._MaKN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaKN.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaKN;
            public String MaKN
            {
                get
                {
                    return _MaKN;
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
            public OtherCriteria(String MaKN, String Mamay, String Nguoisd)
            {
                _MaKN = MaKN;
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
            _tengoc = dr.GetString("TenGoc");
            _MaKN = dr.GetString("MaKN");
            _NgayU = dr.GetSmartDate("NgayU");
            _NgayNhap = dr.GetSmartDate("NgayNhap");
            _YeuCauKN = dr.GetString("YeuCauKN");
            _DangMau = dr.GetString("DangMau");
            _DangKN = dr.GetString("DangKN");
            _maNCC = dr.GetString("MaNCC");
            _tenNCC = dr.GetString("TenNCC");
            _KQ = dr.GetBoolean("KQ");
            _tenNguoiKN = dr.GetString("tenNguoiKN");
            _tenNguoinhan = dr.GetString("tenNguoinhan");
            _tenNguoitra = dr.GetString("tenNguoitra");
            _tenNguoigiao = dr.GetString("tenNguoigiao");
            _tenNguoilay = dr.GetString("tenNguoilay");

            _NVKN = dr.GetString("NVKN");
            _nvNhan = dr.GetString("nvNhan");
            _nvTra = dr.GetString("nvTra");
            _nvGiao = dr.GetString("nvGiao");
            _nvLay = dr.GetString("nvLay");

            _NgayKN = dr.GetSmartDate("NgayKN");
            _NgayYCKN = dr.GetSmartDate("NgayYCKN");
            _NgayTraKN = dr.GetSmartDate("NgayTraKN");
          
            _NgayGiao = dr.GetSmartDate("NgayGiao");
            _noiNhap = dr.GetString("NoiNhap");
            _soCT = dr.GetString("soCT");
            _solt = dr.GetString("solt");
            _NVKN = dr.GetString("NVKN");
            _ghiChu = dr.GetString("ghiChu");
            _huy = dr.GetBoolean("Huy");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _ngayLap = dr.GetSmartDate("NgayLap", false);
            _nguoiLap = dr.GetString("NguoiLap");
            _ngayHuy = dr.GetSmartDate("NgayHuy", false);
            _nguoiHuy = dr.GetString("NguoiHuy");
            _maMay = dr.GetString("MaMay");
            _tenNoiNhap = dr.GetString("TenNoiNhap");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("tenNguoiHuy");
            _MaDT = dr.GetString("MaDT");
            _TenDT = dr.GetString("TenDT");
            _mathuoc = dr.GetString("Mathuoc");
            _soLuong = dr.GetDecimal("Soluong");
            _HanSD = dr.GetSmartDate("HanSD");
            _NgaySX = dr.GetSmartDate("NgaySX");
            _soLo = dr.GetString("SoLo");
            _KetQua = dr.GetString("KetQua");

            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuKiemNghiem(crit.MaKN, crit.qadmin)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _PhieuKiemNghiemCs = PhieuKiemNghiem_Cs.GetPhieuKiemNghiem_Cs(dr);
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
            
            
            _MaKN = DataProvider.Instance().InsertPhieuKiemNghiem(YeuCauKN ,_NgayU ,_DangMau ,_DangKN,_maNCC ,_solt,_NgayNhap , _NgayYCKN, _NgayKN, _NgayTraKN, _noiNhap, _NgayGiao, _soCT, _NVKN, _nvGiao, _nvLay, _nvTra, _nvNhan, _mathuoc,_soLuong , _soLo, _HanSD, _NgaySX, _KetQua, _ghiChu, _nguoiSD , _MaDT, KQ, _maMay);
            MarkOld();
            _PhieuKiemNghiemCs.Update(this);

        }
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
                
                
                  DataProvider.Instance().UpdatePhieuKiemNghiem(_MaKN, YeuCauKN, _NgayU, _DangMau, _DangKN, _maNCC, _solt, _NgayNhap, _NgayYCKN, _NgayKN, _NgayTraKN, _noiNhap, _NgayGiao, _soCT, _NVKN, _nvGiao, _nvLay, _nvTra, _nvNhan, _mathuoc, _soLuong, _soLo, _HanSD, _NgaySX, _KetQua, _ghiChu,_nguoiSD, _MaDT, _KQ, _huy, _maMay);
                _PhieuKiemNghiemCs.Update(this);
            }
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_MaKN, _maMay, _nguoiSD));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeletePhieuKiemNghiem(crit.MaKN, crit.MaMay, crit.NguoiSD);

        }

        #endregion


    }
}
