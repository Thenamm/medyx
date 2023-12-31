//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HTC.BusinessObject.KHTH
//{
//    class BC_KHTH
//    {
//    }
//}

// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_KHTH
// Kieu doi tuong  :	BC_KHTH
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/4/2009 9:46:40 AM
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

namespace HTC.Business.KHTH
{

    /// <summary>
    /// This is a base generated class of <see cref="BC_KHTH" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BC_KHTH : BusinessBase<BC_KHTH>
    {
        #region Business Methods

        #region State Fields

        private String _maBC = String.Empty;
        private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _tuNgayD = new SmartDate(true);
        private SmartDate _denNgay = new SmartDate(true);
        private SmartDate _denNgayD = new SmartDate(true);
        private String _tieuDeBC = String.Empty;
        private Int32 _soLanKham_PX;
        private Int32 _soLanKham_DP;
        private Int32 _soNguoiKham_KV;
        private Int32 _soNguoiKham_PX;
        private Int32 _soNguoiKham_DP;
        private String _tacHaiThuoc = String.Empty;
        private String _bcChitiet = String.Empty;
        private String _cacHDCM = String.Empty;
        private String _deNghiSoYT = String.Empty;
        private String _taiBien = String.Empty;
        private Int32 _benhAnKT_Tot;
        private Int32 _benhAnKT_Kha;
        private Int32 _benhAnKT_TB;
        private Int32 _benhAnKT_Kem;
        private Int32 _donThuocKT_Tot;
        private Int32 _donThuocKT_Kha;
        private Int32 _donThuocKT_TB;
        private Int32 _donThuocKT_Kem;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;

        private int _OrderNumber;
        //private String _tenNguoiLap = String.Empty;
        //private String _tenNguoiHuy = String.Empty;
        #endregion

        #region Business Properties and Methods

        public String MaBC
        {
            get
            {
                CanReadProperty("MaBC", true);
                return _maBC ;
            }
            set
            {
                CanWriteProperty("MaBC", true);
                if (_maBC != value)
                {
                    _maBC = value;
                    PropertyHasChanged("MaBC");
                }
            }
        }
        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _tuNgay.Text;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_tuNgay.Text != value)
                {
                    _tuNgay.Text = value;
                    PropertyHasChanged("TuNgay");
                }
            }
        }

        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _tuNgayD  = _tuNgay ;
                _tuNgayD.FormatString = "dd/MM/yyyy";
                return _tuNgayD.Text;
            }

        }

        public string DenNgay
        {
            get
            {
                CanReadProperty("DenNgay", true);
                return _denNgay.Text;
            }
            set
            {
                CanWriteProperty("DenNgay", true);
                if (_denNgay.Text != value)
                {
                    _denNgay.Text = value;
                    PropertyHasChanged("DenNgay");
                }
            }
        }
        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _denNgayD  = _denNgay;
                _denNgayD.FormatString = "dd/MM/yyyy";
                return _denNgayD.Text;
            }

        }

        public String TieuDeBC
        {
            get
            {
                CanReadProperty("TieuDeBC", true);
                return _tieuDeBC;
            }
            set
            {
                CanWriteProperty("TieuDeBC", true);
                if (_tieuDeBC != value)
                {
                    _tieuDeBC = value;
                    PropertyHasChanged("TieuDeBC");
                }
            }
        }
        public string SoLanKham_Phuongxa
        {
            get
            {
                CanReadProperty("SoLanKham_Phuongxa", true);
                if (_soLanKham_PX  == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanKham_PX.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanKham_Phuongxa", true);

                if (_soLanKham_PX.ToString() != value)
                {
                    if (value == "")
                        _soLanKham_PX = 0;
                    else
                        _soLanKham_PX = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanKham_Phuongxa");
                }
            }
        }
        public string SoLanKham_Duphong
        {
            get
            {
                CanReadProperty("SoLanKham_Duphong", true);
                if (_soLanKham_DP  == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanKham_DP.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanKham_Duphong", true);

                if (_soLanKham_DP.ToString() != value)
                {
                    if (value == "")
                        _soLanKham_DP = 0;
                    else
                        _soLanKham_DP = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanKham_Duphong");
                }
            }
        }
        public string SoNguoiKham_Khuvuc
        {
            get
            {
                CanReadProperty("SoNguoiKham_Khuvuc", true);
                if (_soNguoiKham_KV  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiKham_KV.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiKham_Khuvuc", true);

                if (_soNguoiKham_KV.ToString() != value)
                {
                    if (value == "")
                        _soNguoiKham_KV = 0;
                    else
                        _soNguoiKham_KV = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiKham_Khuvuc");
                }
            }
        }
        public string SoNguoiKham_Phuongxa
        {
            get
            {
                CanReadProperty("SoNguoiKham_Phuongxa", true);
                if (_soNguoiKham_PX  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiKham_PX.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiKham_Phuongxa", true);

                if (_soNguoiKham_PX.ToString() != value)
                {
                    if (value == "")
                        _soNguoiKham_PX = 0;
                    else
                        _soNguoiKham_PX = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiKham_Phuongxa");
                }
            }
        }
        public string SoNguoiKham_Duphong
        {
            get
            {
                CanReadProperty("SoNguoiKham_Duphong", true);
                if (_soNguoiKham_DP  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiKham_DP.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiKham_Duphong", true);

                if (_soNguoiKham_DP.ToString() != value)
                {
                    if (value == "")
                        _soNguoiKham_DP = 0;
                    else
                        _soNguoiKham_DP = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiKham_Duphong");
                }
            }
        }
       
        
        public String TacHaiThuoc
        {
            get
            {
                CanReadProperty("TacHaiThuoc", true);
                return _tacHaiThuoc ;
            }
            set
            {
                CanWriteProperty("TacHaiThuoc", true);
                if (_tacHaiThuoc != value)
                {
                    _tacHaiThuoc = value;
                    PropertyHasChanged("TacHaiThuoc");
                }
            }
        }
        public String BCChiTiet
        {
            get
            {
                CanReadProperty("BCChiTiet", true);
                return _bcChitiet;
            }
            set
            {
                CanWriteProperty("BCChiTiet", true);
                if (_bcChitiet != value)
                {
                    _bcChitiet = value;
                    PropertyHasChanged("BCChiTiet");
                }
            }
        }
        public String CacHDCM
        {
            get
            {
                CanReadProperty("CacHDCM", true);
                return _cacHDCM ;
            }
            set
            {
                CanWriteProperty("CacHDCM", true);
                if (_cacHDCM != value)
                {
                    _cacHDCM = value;
                    PropertyHasChanged("CacHDCM");
                }
            }
        }
        public String DeNghiSoYT
        {
            get
            {
                CanReadProperty("DeNghiSoYT", true);
                return _deNghiSoYT ;
            }
            set
            {
                CanWriteProperty("DeNghiSoYT", true);
                if (_deNghiSoYT != value)
                {
                    _deNghiSoYT = value;
                    PropertyHasChanged("DeNghiSoYT");
                }
            }
        }
        public String TaiBien
        {
            get
            {
                CanReadProperty("TaiBien", true);
                return _taiBien ;
            }
            set
            {
                CanWriteProperty("TaiBien", true);
                if (_taiBien != value)
                {
                    _taiBien = value;
                    PropertyHasChanged("TaiBien");
                }
            }
        }

        public string BenhAnKT_Tot
        {
            get
            {
                CanReadProperty("BenhAnKT_Tot", true);
                if (_benhAnKT_Tot  == 0)
                {
                    return "";
                }
                else
                {
                    return _benhAnKT_Tot.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("BenhAnKT_Tot", true);

                if (_benhAnKT_Tot.ToString() != value)
                {
                    if (value == "")
                        _benhAnKT_Tot = 0;
                    else
                        _benhAnKT_Tot = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BenhAnKT_Tot");
                }
            }
        }
        public string BenhAnKT_Kha
        {
            get
            {
                CanReadProperty("BenhAnKT_Kha", true);
                if (_benhAnKT_Kha  == 0)
                {
                    return "";
                }
                else
                {
                    return _benhAnKT_Kha.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("BenhAnKT_Kha", true);

                if (_benhAnKT_Kha.ToString() != value)
                {
                    if (value == "")
                        _benhAnKT_Kha = 0;
                    else
                        _benhAnKT_Kha = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BenhAnKT_Kha");
                }
            }
        }
        public string BenhAnKT_TB
        {
            get
            {
                CanReadProperty("BenhAnKT_TB", true);
                if (_benhAnKT_TB  == 0)
                {
                    return "";
                }
                else
                {
                    return _benhAnKT_TB.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("BenhAnKT_TB", true);

                if (_benhAnKT_TB.ToString() != value)
                {
                    if (value == "")
                        _benhAnKT_TB = 0;
                    else
                        _benhAnKT_TB = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BenhAnKT_TB");
                }
            }
        }
        public string BenhAnKT_Kem
            {
                get
                {
                    CanReadProperty("BenhAnKT_Kem", true);
                    if (_benhAnKT_Kem  == 0)
                    {
                        return "";
                    }
                    else
                    {
                        return _benhAnKT_Kem.ToString("###,###");
                    }
                }
                set
                {
                    CanWriteProperty("BenhAnKT_Kem", true);

                    if (_benhAnKT_Kem.ToString() != value)
                    {
                        if (value == "")
                            _benhAnKT_Kem = 0;
                        else
                            _benhAnKT_Kem = Int32.Parse(value.Replace(",", ""));
                        PropertyHasChanged("BenhAnKT_Kem");
                    }
                }
            }
        public string DonThuocKT_Tot
        {
            get
            {
                CanReadProperty("DonThuocKT_Tot", true);
                if (_donThuocKT_Tot  == 0)
                {
                    return "";
                }
                else
                {
                    return _donThuocKT_Tot.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonThuocKT_Tot", true);

                if (_donThuocKT_Tot.ToString() != value)
                {
                    if (value == "")
                        _donThuocKT_Tot = 0;
                    else
                        _donThuocKT_Tot = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonThuocKT_Tot");
                }
            }
        }
        public string DonThuocKT_Kha
        {
            get
            {
                CanReadProperty("DonThuocKT_Kha", true);
                if (_donThuocKT_Kha  == 0)
                {
                    return "";
                }
                else
                {
                    return _donThuocKT_Kha.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonThuocKT_Kha", true);

                if (_donThuocKT_Kha.ToString() != value)
                {
                    if (value == "")
                        _donThuocKT_Kha = 0;
                    else
                        _donThuocKT_Kha = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonThuocKT_Kha");
                }
            }
        }
        public string DonThuocKT_TB
        {
            get
            {
                CanReadProperty("DonThuocKT_TB", true);
                if (_donThuocKT_TB  == 0)
                {
                    return "";
                }
                else
                {
                    return _donThuocKT_TB.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonThuocKT_TB", true);

                if (_donThuocKT_TB.ToString() != value)
                {
                    if (value == "")
                        _donThuocKT_TB = 0;
                    else
                        _donThuocKT_TB = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonThuocKT_TB");
                }
            }
        }
        public string DonThuocKT_Kem
        {
            get
            {
                CanReadProperty("DonThuocKT_Kem", true);
                if (_donThuocKT_Kem  == 0)
                {
                    return "";
                }
                else
                {
                    return _donThuocKT_Kem.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonThuocKT_Kem", true);

                if (_donThuocKT_Kem.ToString() != value)
                {
                    if (value == "")
                        _donThuocKT_Kem = 0;
                    else
                        _donThuocKT_Kem = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonThuocKT_Kem");
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
        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
                return this._ngaySD;
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
        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy";
                return this._ngaySD;
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
            return _maBC ;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BC_KHTH" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BC_KHTH NewBC_KHTH()
        {
            return DataPortal.Create<BC_KHTH>();
        }
        public static BC_KHTH GetBC_KHTH(String maBC)
        {
            return DataPortal.Fetch<BC_KHTH>(new Criteria(maBC));
        }

        /// <summary>
        /// Marks the <see cref="BC_KHTH" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBC_KHTH(String maBC, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBC));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BC_KHTH()
        {
            // Prevent direct creation
        }

        internal BC_KHTH(
                                int OrderNumber,
                                String maBC,
                                SmartDate tuNgay,
                             SmartDate denNgay,
                             String tieuDeBC,
                             Int32 soLanKham_PX,
                             Int32 soLanKham_DP,
                             Int32 soNguoiKham_KV,
                             Int32 soNguoiKham_PX,
                             Int32 soNguoiKham_DP,
                             String tacHaiThuoc,   
                             String bcChiTiet,
                             String cacHDCM,
                             String deNghiSoYT,
                             String taiBien,
                             Int32 benhAnKT_Tot,
                                Int32 benhAnKT_Kha,
                                Int32 benhAnKT_TB,
                                Int32 benhAnKT_Kem,
                                Int32 donThuocKT_Tot,
                                Int32 donThuocKT_Kha,
                                Int32 donThuocKT_TB,
                                Int32 donThuocKT_Kem,
                             SmartDate ngayLap,
                             String nguoiLap,
                             SmartDate ngaySD,
                             String nguoiSD,
                             String maMay,
                             Boolean huy,
                             SmartDate ngayHuy,
                             String nguoiHuy                       
         )
        {
            _OrderNumber = OrderNumber;
            _maBC  = maBC ;
            _tuNgay  = tuNgay ;
            _denNgay  = denNgay ;
            _tieuDeBC  = tieuDeBC ;
            _soLanKham_PX  = soLanKham_PX ;
            _soLanKham_DP  = soLanKham_DP ;
            _soNguoiKham_KV  = soNguoiKham_KV ;
            _soNguoiKham_PX  = soNguoiKham_PX ;
            _soNguoiKham_DP  = soNguoiKham_DP ;
            _tacHaiThuoc  = tacHaiThuoc ;
            _bcChitiet   = bcChiTiet ;
            _cacHDCM  = cacHDCM ;
            _deNghiSoYT  = deNghiSoYT ;
            _taiBien  = taiBien;
            _benhAnKT_Tot = benhAnKT_Tot;
            _benhAnKT_Kha = benhAnKT_Kha;
            _benhAnKT_TB = benhAnKT_TB;
            _benhAnKT_Kem = benhAnKT_Kem;
            _donThuocKT_Tot = donThuocKT_Tot;
            _donThuocKT_Kha = donThuocKT_Kha;
            _donThuocKT_TB = donThuocKT_TB;
            _donThuocKT_Kem = donThuocKT_Kem;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;           
            _maMay = maMay;
            _huy = huy;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBC;
            public String MaBC
            {
                get
                {
                    return _maBC;
                }
            }
           

            public Criteria(String maBC)
            {
                _maBC = maBC ;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBC.Equals(c._maBC))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBC.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBC;
            public String MaBC
            {
                get
                {
                    return _maBC ;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBC)
            {
                _maBC  = maBC ;
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
        /// Retrieve an existing <see cref="BC_KHTH" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBC_KHTH(String _maNV);
            // public override IDataReader GetBC_KHTH(String _maNV)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_KHTH_Get", _maNV));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_KHTH(crit.MaBC)))
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
        /// Load a <see cref="BC_KHTH" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetString("TieuDeBC") != null) _tieuDeBC  = dr.GetString("TieuDeBC");
            if (dr.GetInt32("SoLanKham_Phuongxa") != null) _soLanKham_PX = dr.GetInt32("SoLanKham_Phuongxa");
            if (dr.GetInt32("SoLanKham_Duphong") != null) _soLanKham_DP  = dr.GetInt32("SoLanKham_Duphong");
            if (dr.GetInt32("SoNguoiKham_Khuvuc") != null) _soNguoiKham_KV = dr.GetInt32("SoNguoiKham_Khuvuc");
            if (dr.GetInt32("SoNguoiKham_Phuongxa") != null) _soNguoiKham_PX = dr.GetInt32("SoNguoiKham_Phuongxa");
            if (dr.GetInt32("SoNguoiKham_Duphong") != null) _soNguoiKham_DP = dr.GetInt32("SoNguoiKham_Duphong");
            if (dr.GetString("TacHaiThuoc") != null) _tacHaiThuoc  = dr.GetString("TacHaiThuoc");
            if (dr.GetString("BCChiTiet") != null) _bcChitiet = dr.GetString("BCChiTiet");
            if (dr.GetString("CacHDCM") != null) _cacHDCM = dr.GetString("CacHDCM");
            if (dr.GetString("DeNghiSoYT") != null) _deNghiSoYT = dr.GetString("DeNghiSoYT");
            if (dr.GetString("TaiBien") != null) _taiBien  = dr.GetString("TaiBien");
            if (dr.GetInt32("BenhAnKT_Tot") != null) _benhAnKT_Tot  = dr.GetInt32("BenhAnKT_Tot");
            if (dr.GetInt32("BenhAnKT_Kha") != null) _benhAnKT_Kha  = dr.GetInt32("BenhAnKT_Kha");
            if (dr.GetInt32("BenhAnKT_TB") != null) _benhAnKT_TB  = dr.GetInt32("BenhAnKT_TB");
            if (dr.GetInt32("BenhAnKT_Kem") != null) _benhAnKT_Kem  = dr.GetInt32("BenhAnKT_Kem");
            if (dr.GetInt32("DonThuocKT_Tot") != null) _donThuocKT_Tot  = dr.GetInt32("DonThuocKT_Tot");
            if (dr.GetInt32("DonThuocKT_Kha") != null) _donThuocKT_Kha  = dr.GetInt32("DonThuocKT_Kha");
            if (dr.GetInt32("DonThuocKT_TB") != null) _donThuocKT_TB  = dr.GetInt32("DonThuocKT_TB");
            if (dr.GetInt32("DonThuocKT_Kem") != null) _donThuocKT_Kem  = dr.GetInt32("DonThuocKT_Kem");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        }

        /// <summary>
        /// Insert the new <see cref="BC_KHTH" /> Object to underlying database.
        /// </summary>
        /// 


        protected override void DataPortal_Create()
        {
            

            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBC_KHTH
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maBC = DataProvider.Instance().InsertBC_KHTH(_tuNgay , _denNgay , _tieuDeBC , _soLanKham_PX , _soLanKham_DP , _soNguoiKham_KV , _soNguoiKham_PX , _soNguoiKham_DP , _tacHaiThuoc , _bcChitiet ,_cacHDCM,_deNghiSoYT ,_taiBien,_benhAnKT_Tot ,_benhAnKT_Kha ,_benhAnKT_TB ,_benhAnKT_Kem ,_donThuocKT_Tot ,_donThuocKT_Kha ,_donThuocKT_TB ,_donThuocKT_Kem  ,_maMay , _nguoiSD );


        }

        /// <summary>
        /// Update all changes made on <see cref="BC_KHTH" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_KHTH
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateBC_KHTH(_maBC, _tuNgay, _denNgay, _tieuDeBC, _soLanKham_PX, _soLanKham_DP, _soNguoiKham_KV, _soNguoiKham_PX, _soNguoiKham_DP, _tacHaiThuoc, _bcChitiet, _cacHDCM, _deNghiSoYT, _taiBien, _benhAnKT_Tot, _benhAnKT_Kha, _benhAnKT_TB, _benhAnKT_Kem, _donThuocKT_Tot, _donThuocKT_Kha, _donThuocKT_TB, _donThuocKT_Kem, _huy, _maMay, _nguoiSD   );
   				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBC));
        }

        /// <summary>
        /// Delete the <see cref="BC_KHTH" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_KHTH
            DataProvider.Instance().DeleteBC_KHTH(crit.MaMay, crit.NguoiSD, crit.MaBC );

        }

        #endregion
    }

}
